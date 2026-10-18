import { readFile } from "node:fs/promises";
import { resolve } from "node:path";
import { WebSocket } from "ws";
import type { ValorantCommand } from "../shared/valorant";
import { loadMatchConfig, logoUrl, type ValorantConfigPaths } from "./valorant-config";

// Controller của Studio: một phiên observer thứ hai trên ingest, dùng cùng group code và bí mật trận của
// Client chính thức, chỉ để gửi lệnh thủ công (plant, pause, timeout, KDA/credits, swap, toast) và cấu hình
// trận giữa trận. Nó KHÔNG BAO GIỜ tạo trận: chỉ logon khi backend đã có trận do Client tạo.
export interface ControllerOptions {
  ingestPort: number;
  extrasPort: number;
  groupCode: string;
  key: string;
  observerName: string;
  /** File matchSecret.json trong profile của Client chính thức. */
  secretFile: string;
  paths: ValorantConfigPaths;
  phase: () => string | null;
  now?: () => number;
}

const PROTOCOL_VERSION = "0.3.3";

type Secret = { secret: string; endTime: number };

export class ValorantController {
  private ws: WebSocket | null = null;
  private connected = false;
  private timer: ReturnType<typeof setInterval> | undefined;
  private busy = false;
  private usedSecret = "";
  private lastGood = "";
  private staleSecret = "";
  private error: string | null = null;
  private readonly now: () => number;
  constructor(private readonly options: ControllerOptions) {
    this.now = options.now ?? Date.now;
  }

  start() {
    if (this.timer) return;
    this.timer = setInterval(() => void this.tick(), 1000);
  }
  stop() {
    clearInterval(this.timer);
    this.timer = undefined;
    this.close();
  }
  isConnected() {
    return this.connected;
  }
  status() {
    return { connected: this.connected, error: this.error };
  }

  private async secret(): Promise<string> {
    try {
      const saved = JSON.parse(await readFile(this.options.secretFile, "utf8")) as Secret;
      return typeof saved.secret === "string" && saved.secret && this.now() < saved.endTime
        ? saved.secret
        : "";
    } catch {
      return "";
    }
  }
  private async matches(): Promise<number> {
    try {
      const res = await fetch(`http://127.0.0.1:${this.options.extrasPort}/status`, {
        signal: AbortSignal.timeout(800),
      });
      return Number((await res.json()).matchesRunning) || 0;
    } catch {
      return 0;
    }
  }

  private async tick() {
    if (this.busy) return;
    this.busy = true;
    try {
      const matches = await this.matches();
      // Trận kết thúc: bí mật cũ không được dùng lại cho đến khi Client tạo trận mới.
      if (matches === 0) {
        if (this.usedSecret) this.staleSecret = this.usedSecret;
        this.close();
        return;
      }
      if (this.connected || this.ws) return;
      const fromFile = await this.secret();
      if (fromFile) this.lastGood = fromFile;
      // Client chính thức ghi đè file bằng bí mật rỗng lúc match_start: dùng bí mật hợp lệ gần nhất.
      const secret = fromFile || this.lastGood;
      if (!secret || secret === this.staleSecret) return;
      this.open(secret);
    } finally {
      this.busy = false;
    }
  }

  private open(secret: string) {
    const ws = new WebSocket(
      `ws://127.0.0.1:${this.options.ingestPort}/socket.io/?EIO=4&transport=websocket`,
      { handshakeTimeout: 3000 },
    );
    this.ws = ws;
    this.usedSecret = secret;
    ws.on("message", (data) => this.message(ws, data.toString(), secret));
    ws.on("error", () => ws.close());
    ws.on("close", () => {
      if (this.ws === ws) {
        this.ws = null;
        this.connected = false;
      }
    });
  }

  /** Engine.IO: 0=open, 2=ping, 4=message; Socket.IO: 40=connect, 42=event. */
  async message(ws: Pick<WebSocket, "send">, packet: string, secret: string) {
    if (packet[0] === "0") ws.send("40");
    else if (packet === "2") ws.send("3");
    else if (packet.startsWith("40"))
      ws.send(`42${JSON.stringify(["obs_logon", JSON.stringify(await this.logon(secret))])}`);
    else if (packet.startsWith("41")) this.close();
    else if (packet.startsWith("42")) {
      try {
        const [name, body] = JSON.parse(packet.slice(2));
        if (name !== "obs_logon_ack") return;
        const ack = JSON.parse(body);
        this.connected = ack?.value === true;
        this.error = this.connected ? null : String(ack?.reason ?? "auth-failed");
        // Server từ chối chỉ ngắt namespace, transport vẫn mở: đóng hẳn để tick sau thử lại với bí mật mới.
        if (!this.connected) this.close();
        // Server cấp bí mật mới nghĩa là trận này do ta tạo nhầm: không bao giờ chấp nhận.
        if (this.connected && ack.reason !== "reconnected") {
          this.error = "controller-created-match";
          this.connected = false;
          this.close();
        }
      } catch {}
    }
  }

  private async logon(secret: string) {
    const config = await loadMatchConfig(this.options.paths);
    const team = (i: 0 | 1) => ({
      name: config.teams[i].name,
      tricode: config.teams[i].tricode,
      url: logoUrl(this.options.paths, config.teams[i].logo),
      attackStart: i === 0,
    });
    return {
      type: "authenticate",
      clientVersion: PROTOCOL_VERSION,
      obsName: this.options.observerName,
      key: this.options.key,
      groupCode: this.options.groupCode,
      groupSecret: secret,
      leftTeam: team(0),
      rightTeam: team(1),
      toolsData: {},
    };
  }

  private close() {
    const ws = this.ws;
    this.ws = null;
    this.connected = false;
    ws?.removeAllListeners();
    ws?.terminate();
  }

  private send(type: string, data: unknown) {
    if (!this.connected || !this.ws) return false;
    const body = {
      obsName: this.options.observerName,
      groupCode: this.options.groupCode,
      type,
      data,
    };
    this.ws.send(`42${JSON.stringify(["obs_data", JSON.stringify(body)])}`);
    return true;
  }

  /** Cấu hình hiện tại của Studio → cập nhật giữa trận (backend fork: config_update). */
  private async sendConfig() {
    const config = await loadMatchConfig(this.options.paths);
    const team = (i: 0 | 1) => ({
      name: config.teams[i].name,
      tricode: config.teams[i].tricode,
      url: logoUrl(this.options.paths, config.teams[i].logo),
    });
    return this.send("config_update", {
      leftTeam: team(0),
      rightTeam: team(1),
      series: config.series,
      tournament: {
        name: config.tournament.name,
        logoUrl: logoUrl(this.options.paths, config.tournament.logo),
        backdropUrl: "",
      },
      nameOverrides: config.nameOverrides.map((o) => [o.player, o.display]),
    });
  }

  async run(command: ValorantCommand): Promise<{ ok: boolean; error?: string }> {
    if (!this.connected) return { ok: false, error: "not-connected" };
    switch (command.command) {
      case "spike_planted":
        // Như phím nóng gốc: chỉ hợp lệ khi round đang giao tranh.
        if (this.options.phase() !== "combat") return { ok: false, error: "not-in-combat" };
        return this.send("spike_planted", true)
          ? { ok: true }
          : { ok: false, error: "not-connected" };
      case "apply_config":
        return (await this.sendConfig()) ? { ok: true } : { ok: false, error: "not-connected" };
      case "toast":
        return this.send("toast", {
          title: command.title,
          message: command.message,
          duration: command.duration,
          eventLogoEnabled: true,
          active: true,
        })
          ? { ok: true }
          : { ok: false, error: "not-connected" };
      default:
        return this.send(command.command, true)
          ? { ok: true }
          : { ok: false, error: "not-connected" };
    }
  }
}

/** Đường dẫn bí mật trận trong profile Client chính thức. */
export const officialSecretFile = (profileDir: string) =>
  resolve(profileDir, "storage", "matchSecret.json");
