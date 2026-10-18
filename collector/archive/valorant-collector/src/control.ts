// Cổng lệnh loopback thay cho phím nóng của Spectra Client (services/hotkeyService.ts, GPL-3.0-only):
// Studio gửi lệnh, collector gửi đúng dữ liệu phím nóng đó lên ingest. Xem NOTICE.md.
import { createServer, Server } from "http";
import { timingSafeEqual } from "crypto";
import { HostConfig, readMatchConfig } from "./config";
import { DataTypes } from "./protocol";
import { Ingest } from "./ingest";
import { GepSession } from "./gep";
import { log } from "./log";

export type ControlResult = { ok: boolean; error?: string };

export class Control {
  constructor(
    private readonly config: HostConfig,
    private readonly ingest: Ingest,
    private readonly gep: GepSession,
    private readonly overwolfRunning: () => boolean,
  ) {}

  /** Gửi lại tên/logo đội, tỉ số loạt trận, giải và tên thay thế cho trận đang chạy. */
  sendConfig(): boolean {
    const match = readMatchConfig(this.config);
    return this.ingest.send({
      type: DataTypes.CONFIG_UPDATE,
      data: {
        leftTeam: match.leftTeam,
        rightTeam: match.rightTeam,
        series: match.series,
        tournament: match.tournament,
        nameOverrides: match.nameOverrides,
      },
    });
  }

  run(body: any): ControlResult {
    if (!this.ingest.isConnected()) return { ok: false, error: "not-connected" };
    const simple: Record<string, DataTypes> = {
      tech_pause: DataTypes.TECH_PAUSE,
      left_timeout: DataTypes.LEFT_TIMEOUT,
      right_timeout: DataTypes.RIGHT_TIMEOUT,
      switch_kda_credits: DataTypes.SWITCH_KDA_CREDITS,
      swap_left_right: DataTypes.SWAP_L_R,
      swap_attacker_defender: DataTypes.SWAP_A_D,
    };
    const command = String(body?.command ?? "");
    if (command in simple) {
      this.ingest.send({ type: simple[command], data: true });
      return { ok: true };
    }
    switch (command) {
      case "spike_planted":
        // Như phím nóng gốc: chỉ hợp lệ khi round đang giao tranh.
        if (this.gep.phase() !== "combat") return { ok: false, error: "not-in-combat" };
        this.ingest.send({ type: DataTypes.SPIKE_PLANTED, data: true });
        return { ok: true };
      case "apply_config":
        return this.sendConfig() ? { ok: true } : { ok: false, error: "not-connected" };
      case "toast": {
        const title = String(body.title ?? "").slice(0, 80);
        const message = String(body.message ?? "").slice(0, 200);
        const duration = body.duration === null ? null : Number(body.duration);
        if (duration !== null && !(duration >= 1000 && duration <= 60000))
          return { ok: false, error: "bad-duration" };
        this.ingest.send({
          type: DataTypes.TOAST,
          data: { title, message, duration, eventLogoEnabled: true, active: true },
        });
        return { ok: true };
      }
      default:
        return { ok: false, error: "unknown-command" };
    }
  }

  status() {
    return {
      gep: this.gep.status(),
      ingest: { connected: this.ingest.isConnected(), error: this.ingest.error() },
      // Overwolf thường đang chạy có thể tranh GEP; chỉ báo, không tự tắt.
      overwolfRunning: this.overwolfRunning(),
    };
  }

  start(): Server {
    const expected = Buffer.from(this.config.controlToken);
    const server = createServer((req, res) => {
      const send = (code: number, body: object) => {
        res.writeHead(code, { "Content-Type": "application/json", "Cache-Control": "no-store" });
        res.end(JSON.stringify(body));
      };
      const given = Buffer.from(String(req.headers.authorization ?? "").replace(/^Bearer /, ""));
      if (given.length !== expected.length || !timingSafeEqual(given, expected))
        return send(401, { ok: false, error: "unauthorized" });
      if (req.headers.host !== `127.0.0.1:${this.config.controlPort}`)
        return send(403, { ok: false, error: "forbidden-host" });
      if (req.method === "GET" && req.url === "/status") return send(200, this.status());
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
          const result = this.run(JSON.parse(Buffer.concat(chunks).toString("utf8")));
          send(result.ok ? 200 : 409, result);
        } catch {
          send(400, { ok: false, error: "bad-request" });
        }
      });
    });
    server.on("error", (e) => log.error("Cổng điều khiển lỗi", e));
    server.listen(this.config.controlPort, "127.0.0.1");
    return server;
  }
}
