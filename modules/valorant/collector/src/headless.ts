import { readFileSync } from "fs";
import { createServer, Server } from "http";
import { timingSafeEqual } from "crypto";

// Riot Overlay: chế độ do Studio quản lý. Chỉ bật khi RIOT_OVERLAY_SPECTRA_CONFIG trỏ tới file
// JSON local {ingestIp, groupCode, keyFile, observerName}. Không có biến này thì Client chạy như upstream.
// Key đọc từ keyFile, không nằm trong config, không ghi log.
export interface HeadlessConfig {
  ingestIp: string;
  groupCode: string;
  key: string;
  observerName: string;
  controlPort: number;
  controlToken: string;
  teamLogoUrl: string;
  matchConfigFile: string;
  assetBase: string;
}

export function loadHeadlessConfig(): HeadlessConfig | null {
  const path = process.env.RIOT_OVERLAY_SPECTRA_CONFIG;
  if (!path) return null;
  const raw = JSON.parse(readFileSync(path, "utf8"));
  const key = readFileSync(String(raw.keyFile), "utf8").trim();
  const ingestIp = String(raw.ingestIp ?? "");
  const groupCode = String(raw.groupCode ?? "");
  // Chỉ nhận ingest loopback để key local không bị gửi ra ngoài.
  if (!/^http:\/\/127\.0\.0\.1:\d+$/.test(ingestIp)) throw new Error("Headless ingest must be http://127.0.0.1:<port>");
  if (!groupCode || !key) throw new Error("Headless config needs groupCode and key");
  const controlPort = Number(raw.controlPort);
  const controlToken = String(raw.controlToken ?? "");
  if (!Number.isInteger(controlPort) || controlPort < 1024 || controlPort > 65535)
    throw new Error("Headless config needs controlPort");
  if (!/^[a-f0-9]{32,128}$/.test(controlToken)) throw new Error("Headless config needs controlToken");
  // Logo mặc định chỉ được trỏ về frontend loopback để overlay không gọi ra ngoài.
  const teamLogoUrl = String(raw.teamLogoUrl ?? "");
  if (teamLogoUrl && !/^http:\/\/127\.0\.0\.1:\d+\/assets\/[\w./-]+$/.test(teamLogoUrl))
    throw new Error("Headless teamLogoUrl must be a loopback asset");
  const matchConfigFile = String(raw.matchConfigFile ?? "");
  const assetBase = String(raw.assetBase ?? "");
  if (assetBase && !/^http:\/\/127\.0\.0\.1:\d+\/uploads\/$/.test(assetBase))
    throw new Error("Headless assetBase must be a loopback uploads path");
  return {
    ingestIp,
    groupCode,
    key,
    observerName: String(raw.observerName || "Riot Overlay"),
    controlPort,
    controlToken,
    teamLogoUrl,
    matchConfigFile,
    assetBase,
  };
}

export interface MatchConfigPayload {
  leftTeam: { name: string; tricode: string; url: string; attackStart: boolean };
  rightTeam: { name: string; tricode: string; url: string; attackStart: boolean };
  series: { needed: number; wonLeft: number; wonRight: number };
  tournament: { name: string; logoUrl: string; backdropUrl: string };
  nameOverrides: [string, string][];
}

/** Đọc cấu hình trận do Studio ghi; thiếu hoặc sai thì dùng mặc định, không làm Client dừng. */
export function readMatchConfig(config: HeadlessConfig): MatchConfigPayload {
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
  const team = (t: any, n: number, attackStart: boolean) => ({
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

export type ControlResult = { ok: boolean; error?: string };

/**
 * Kênh điều khiển loopback thay cho phím nóng/nút trong cửa sổ Client: Studio gửi lệnh đã có sẵn
 * của Spectra (plant, pause, timeout...). Chỉ bind 127.0.0.1, cần bearer token trong config, một lệnh/lần.
 */
export function startControlServer(
  config: HeadlessConfig,
  run: (body: any) => ControlResult,
): Server {
  const expected = Buffer.from(config.controlToken);
  const server = createServer((req, res) => {
    const send = (code: number, body: object) => {
      res.writeHead(code, { "Content-Type": "application/json", "Cache-Control": "no-store" });
      res.end(JSON.stringify(body));
    };
    const given = Buffer.from(String(req.headers.authorization ?? "").replace(/^Bearer /, ""));
    if (given.length !== expected.length || !timingSafeEqual(given, expected))
      return send(401, { ok: false, error: "unauthorized" });
    if (req.headers.host !== `127.0.0.1:${config.controlPort}`)
      return send(403, { ok: false, error: "forbidden-host" });
    if (req.method !== "POST" || req.url !== "/command")
      return send(405, { ok: false, error: "method-not-allowed" });
    const chunks: Buffer[] = [];
    let size = 0;
    req.on("data", (chunk: Buffer) => {
      size += chunk.length;
      if (size > 4096) req.destroy();
      else chunks.push(chunk);
    });
    req.on("end", () => {
      try {
        const result = run(JSON.parse(Buffer.concat(chunks).toString("utf8")));
        send(result.ok ? 200 : 409, result);
      } catch {
        send(400, { ok: false, error: "bad-request" });
      }
    });
  });
  server.listen(config.controlPort, "127.0.0.1");
  return server;
}
