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
  return {
    ingestIp,
    groupCode,
    key,
    observerName: String(raw.observerName || "Riot Overlay"),
    controlPort,
    controlToken,
    teamLogoUrl,
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
