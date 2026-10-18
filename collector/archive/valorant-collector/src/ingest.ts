// Kết nối observer tới ingest của Spectra Server. Dịch từ Spectra Client (services/connectorService.ts,
// GPL-3.0-only), chỉ nhánh observer; khác upstream: logon lại mỗi lần socket nối lại. Xem NOTICE.md.
import { mkdirSync, readFileSync, rmSync, writeFileSync } from "fs";
import { join } from "path";
import { io, Socket } from "socket.io-client";
import { HostConfig, MatchConfigPayload } from "./config";
import { log } from "./log";
import { DataTypes, FormattedData, SocketChannels } from "./protocol";

// Phiên bản giao thức ingest mà collector này cài đặt (backend kiểm tra tương thích theo số này).
export const PROTOCOL_VERSION = "0.3.3";
const SECRET_TTL_MS = 2 * 60 * 60 * 1000;

/** Bí mật nối lại trận (do server cấp) lưu trong profile để reconnect sau khi collector khởi động lại. */
export class SecretStore {
  private file: string;
  constructor(dir: string) {
    mkdirSync(dir, { recursive: true });
    this.file = join(dir, "match-secret.json");
  }
  get(): string {
    try {
      const saved = JSON.parse(readFileSync(this.file, "utf8"));
      if (typeof saved.secret === "string" && Date.now() < saved.endTime) return saved.secret;
      rmSync(this.file, { force: true });
    } catch {}
    return "";
  }
  remember(secret: string) {
    if (secret === "reconnected") return;
    writeFileSync(this.file, JSON.stringify({ secret, endTime: Date.now() + SECRET_TTL_MS }), {
      mode: 0o600,
    });
  }
}

export class Ingest {
  private ws?: Socket;
  private connected = false;
  private match?: MatchConfigPayload;
  private lastError: string | null = null;
  constructor(
    private readonly config: HostConfig,
    private readonly secrets: SecretStore,
  ) {}

  isConnected() {
    return this.connected;
  }
  error() {
    return this.lastError;
  }

  /** Mở kết nối (nếu chưa có) với cấu hình trận hiện tại; gọi nhiều lần vẫn an toàn. */
  connect(match: MatchConfigPayload) {
    this.match = match;
    if (this.connected || this.ws) return;
    log.info(`Kết nối ingest ${this.config.ingestUrl}, group ${this.config.groupCode}`);
    const ws = io(this.config.ingestUrl, {
      reconnection: true,
      reconnectionDelay: 1000,
      reconnectionDelayMax: 5000,
      transports: ["websocket"],
    });
    this.ws = ws;
    ws.on("connect", () => this.logon(ws));
    ws.on("obs_logon_ack", (msg: unknown) => {
      let ack: any;
      try {
        ack = JSON.parse(String(msg));
      } catch {
        return;
      }
      if (ack?.type !== DataTypes.AUTH) return;
      if (ack.value === true) {
        this.connected = true;
        this.lastError = null;
        this.secrets.remember(String(ack.reason ?? ""));
        log.info("Xác thực ingest thành công");
      } else {
        this.connected = false;
        this.lastError = String(ack.reason ?? "auth-failed");
        log.warn(`Xác thực ingest thất bại: ${this.lastError}`);
        this.close();
      }
    });
    ws.on("disconnect", (reason: string) => {
      this.connected = false;
      log.info(`Ingest ngắt kết nối: ${reason}`);
      // Server chủ động ngắt thì socket.io không tự nối lại.
      if (reason === "io server disconnect" && this.ws === ws) ws.connect();
    });
    ws.on("connect_error", (e: Error) => {
      this.connected = false;
      this.lastError = e.message;
    });
  }

  private logon(ws: Socket) {
    const match = this.match;
    if (!match) return;
    const data = {
      type: DataTypes.AUTH,
      clientVersion: PROTOCOL_VERSION,
      obsName: this.config.observerName,
      key: this.config.key,
      groupCode: this.config.groupCode.toUpperCase(),
      groupSecret: this.secrets.get(),
      leftTeam: match.leftTeam,
      rightTeam: match.rightTeam,
      toolsData: {
        seriesInfo: { ...match.series, mapInfo: [] },
        seedingInfo: { left: "", right: "" },
        tournamentInfo: { ...match.tournament, timeoutDuration: 60 },
        timeoutDuration: 60,
        timeoutCounter: { max: 2, left: 2, right: 2 },
        sponsorInfo: { enabled: false, duration: 5000, sponsors: [] },
        // Watermark của Spectra giữ nguyên theo điều khoản license.
        watermarkInfo: { spectraWatermark: true, customTextEnabled: false, customText: "" },
        playercamsInfo: { enable: false, identifier: "", secret: "", endTime: 0 },
        roundWinBox: { type: "disabled", sponsors: [] },
        nameOverrides: { overrides: JSON.stringify(match.nameOverrides) },
      },
    };
    ws.emit(SocketChannels.OBSERVER_LOGON, JSON.stringify(data));
  }

  send(formatted: FormattedData) {
    if (!this.connected || !this.ws) return false;
    this.ws.emit(
      SocketChannels.OBSERVER_DATA,
      JSON.stringify({
        obsName: this.config.observerName,
        groupCode: this.config.groupCode.toUpperCase(),
        ...formatted,
      }),
    );
    return true;
  }

  /** Hết trận: ngắt để trận sau logon lại bằng bí mật mới. */
  endMatch() {
    this.close();
  }

  private close() {
    const ws = this.ws;
    this.ws = undefined;
    this.connected = false;
    ws?.removeAllListeners();
    ws?.disconnect();
  }
  stop() {
    this.close();
  }
}
