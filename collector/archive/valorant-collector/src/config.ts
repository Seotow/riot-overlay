import { readFileSync } from "fs";

// Cấu hình do Studio/supervisor ghi cho mỗi lần chạy (RIOT_OVERLAY_VALORANT_CONFIG trỏ tới file JSON).
// Key đọc từ keyFile, không nằm trong config và không ghi log.
export interface HostConfig {
  ingestUrl: string;
  groupCode: string;
  key: string;
  observerName: string;
  controlPort: number;
  controlToken: string;
  teamLogoUrl: string;
  matchConfigFile: string;
  assetBase: string;
  profileDir: string;
}

export function loadHostConfig(): HostConfig {
  const path = process.env.RIOT_OVERLAY_VALORANT_CONFIG;
  if (!path) throw new Error("Thiếu RIOT_OVERLAY_VALORANT_CONFIG");
  const raw = JSON.parse(readFileSync(path, "utf8"));
  const key = readFileSync(String(raw.keyFile), "utf8").trim();
  const ingestUrl = String(raw.ingestUrl ?? "");
  // Chỉ gửi key tới ingest loopback.
  if (!/^http:\/\/127\.0\.0\.1:\d+$/.test(ingestUrl))
    throw new Error("ingestUrl phải là http://127.0.0.1:<port>");
  const groupCode = String(raw.groupCode ?? "");
  if (!groupCode || !key) throw new Error("Cần groupCode và key");
  const controlPort = Number(raw.controlPort);
  if (!Number.isInteger(controlPort) || controlPort < 1024 || controlPort > 65535)
    throw new Error("controlPort không hợp lệ");
  const controlToken = String(raw.controlToken ?? "");
  if (!/^[a-f0-9]{32,128}$/.test(controlToken)) throw new Error("controlToken không hợp lệ");
  const teamLogoUrl = String(raw.teamLogoUrl ?? "");
  if (teamLogoUrl && !/^http:\/\/127\.0\.0\.1:\d+\/assets\/[\w./-]+$/.test(teamLogoUrl))
    throw new Error("teamLogoUrl phải là asset loopback");
  const assetBase = String(raw.assetBase ?? "");
  if (assetBase && !/^http:\/\/127\.0\.0\.1:\d+\/uploads\/$/.test(assetBase))
    throw new Error("assetBase phải là đường dẫn uploads loopback");
  return {
    ingestUrl,
    groupCode,
    key,
    observerName: String(raw.observerName || "Riot Overlay"),
    controlPort,
    controlToken,
    teamLogoUrl,
    matchConfigFile: String(raw.matchConfigFile ?? ""),
    assetBase,
    profileDir: String(raw.profileDir ?? ""),
  };
}

export interface TeamPayload {
  name: string;
  tricode: string;
  url: string;
  attackStart: boolean;
}
export interface MatchConfigPayload {
  leftTeam: TeamPayload;
  rightTeam: TeamPayload;
  series: { needed: number; wonLeft: number; wonRight: number };
  tournament: { name: string; logoUrl: string; backdropUrl: string };
  nameOverrides: [string, string][];
}

/** Đọc cấu hình trận do Studio ghi; thiếu hoặc sai thì dùng mặc định, không làm collector dừng. */
export function readMatchConfig(config: HostConfig): MatchConfigPayload {
  let raw: any = {};
  try {
    raw = JSON.parse(readFileSync(config.matchConfigFile, "utf8"));
  } catch {}
  const str = (v: unknown, max: number, fallback: string) =>
    typeof v === "string" && v.trim() ? v.trim().slice(0, max) : fallback;
  const int = (v: unknown, min: number, max: number, fallback: number) =>
    Number.isInteger(v) ? Math.min(max, Math.max(min, v as number)) : fallback;
  const logo = (name: unknown, fallback: string) =>
    typeof name === "string" && /^[a-f0-9]{16}\.(png|jpg|webp)$/.test(name) && config.assetBase
      ? config.assetBase + name
      : fallback;
  const team = (t: any, n: number, attackStart: boolean): TeamPayload => ({
    name: str(t?.name, 40, `Team ${n}`),
    tricode: str(t?.tricode, 5, `T${n}`).toUpperCase(),
    url: logo(t?.logo, config.teamLogoUrl),
    attackStart,
  });
  const needed = int(raw.series?.needed, 1, 9, 1);
  const pairs = Array.isArray(raw.nameOverrides) ? raw.nameOverrides.slice(0, 20) : [];
  return {
    leftTeam: team(raw.teams?.[0], 1, true),
    rightTeam: team(raw.teams?.[1], 2, false),
    series: {
      needed,
      wonLeft: int(raw.series?.wonLeft, 0, needed, 0),
      wonRight: int(raw.series?.wonRight, 0, needed, 0),
    },
    tournament: {
      name: str(raw.tournament?.name, 80, ""),
      logoUrl: logo(raw.tournament?.logo, ""),
      backdropUrl: "",
    },
    nameOverrides: pairs
      .filter((p: any) => typeof p?.player === "string" && typeof p?.display === "string")
      .map((p: any): [string, string] => [p.player.slice(0, 60), p.display.slice(0, 40)]),
  };
}
