import { createHash } from "node:crypto";
import { mkdir, readFile, rename, writeFile } from "node:fs/promises";
import { dirname, resolve } from "node:path";
import {
  LOGO_MAX_BYTES,
  defaultValorantMatchConfig,
  logoSlots,
  valorantConfigSaveSchema,
  valorantMatchConfigSchema,
  type LogoSlot,
  type ValorantConfigView,
  type ValorantMatchConfig,
} from "../shared/valorant-config";

export interface ValorantConfigPaths {
  config: string;
  assets: string;
  frontendPort: number;
}

export const defaultPaths = (frontendPort = 5322): ValorantConfigPaths => ({
  config: resolve(
    process.env.RIOT_OVERLAY_VALORANT_MATCH_CONFIG || "data/valorant/match-config.json",
  ),
  assets: resolve(process.env.RIOT_OVERLAY_VALORANT_ASSETS || "data/valorant/assets"),
  frontendPort,
});

const extensions = { png: "png", jpeg: "jpg", webp: "webp" } as const;

/** Nhận diện ảnh bằng chữ ký file, không tin MIME do trình duyệt khai báo. */
export function decodeLogo(dataUrl: string): { bytes: Buffer; ext: string } | null {
  const match = /^data:image\/(png|jpeg|webp);base64,([A-Za-z0-9+/=]+)$/.exec(dataUrl);
  if (!match) return null;
  const bytes = Buffer.from(match[2], "base64");
  if (bytes.length === 0 || bytes.length > LOGO_MAX_BYTES) return null;
  const kind = bytes
    .subarray(0, 8)
    .equals(Buffer.from([0x89, 0x50, 0x4e, 0x47, 0x0d, 0x0a, 0x1a, 0x0a]))
    ? "png"
    : bytes.subarray(0, 3).equals(Buffer.from([0xff, 0xd8, 0xff]))
      ? "jpeg"
      : bytes.subarray(0, 4).toString() === "RIFF" && bytes.subarray(8, 12).toString() === "WEBP"
        ? "webp"
        : null;
  if (!kind || kind !== match[1]) return null;
  return { bytes, ext: extensions[kind] };
}

export const logoUrl = (paths: ValorantConfigPaths, name: string) =>
  name ? `http://127.0.0.1:${paths.frontendPort}/uploads/${name}` : "";

export async function loadMatchConfig(paths: ValorantConfigPaths): Promise<ValorantMatchConfig> {
  try {
    return valorantMatchConfigSchema.parse(JSON.parse(await readFile(paths.config, "utf8")));
  } catch {
    return structuredClone(defaultValorantMatchConfig);
  }
}

export async function viewMatchConfig(paths: ValorantConfigPaths): Promise<ValorantConfigView> {
  const config = await loadMatchConfig(paths);
  return {
    config,
    logoUrls: {
      left: logoUrl(paths, config.teams[0].logo),
      right: logoUrl(paths, config.teams[1].logo),
      tournament: logoUrl(paths, config.tournament.logo),
    },
  };
}

/** Kiểm tra, lưu logo mới (tên file = hash nội dung) rồi ghi cấu hình nguyên tử. */
export async function saveMatchConfig(
  input: unknown,
  paths: ValorantConfigPaths,
): Promise<{ ok: true; view: ValorantConfigView } | { ok: false; error: string }> {
  const parsed = valorantConfigSaveSchema.safeParse(input);
  if (!parsed.success) return { ok: false, error: "invalid-config" };
  const config = structuredClone(parsed.data.config);
  const names: Record<LogoSlot, string> = {
    left: config.teams[0].logo,
    right: config.teams[1].logo,
    tournament: config.tournament.logo,
  };
  const writes: { name: string; bytes: Buffer }[] = [];
  for (const slot of logoSlots) {
    const upload = parsed.data.uploads[slot];
    if (upload === undefined) continue;
    const logo = decodeLogo(upload);
    if (!logo) return { ok: false, error: "invalid-logo" };
    const name = `${createHash("sha256").update(logo.bytes).digest("hex").slice(0, 16)}.${logo.ext}`;
    names[slot] = name;
    writes.push({ name, bytes: logo.bytes });
  }
  config.teams[0].logo = names.left;
  config.teams[1].logo = names.right;
  config.tournament.logo = names.tournament;
  await mkdir(paths.assets, { recursive: true });
  for (const { name, bytes } of writes) await writeFile(resolve(paths.assets, name), bytes);
  await mkdir(dirname(paths.config), { recursive: true });
  await writeFile(`${paths.config}.tmp`, JSON.stringify(config, null, 2));
  await rename(`${paths.config}.tmp`, paths.config);
  return { ok: true, view: await viewMatchConfig(paths) };
}
