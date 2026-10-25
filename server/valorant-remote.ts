import { resolve } from "node:path";
import { pathToFileURL } from "node:url";
import { encodeJoinCode } from "../shared/valorant-remote";
import { defaultPaths, loadMatchConfig } from "./valorant-config";

interface Tunnel {
  readonly origin: string;
  status: () => { state: string; origin: string };
  stop: () => Promise<void>;
}

// Đăng lại code lên điểm hẹn định kỳ (ntfy giữ message ~12h, host đăng để player luôn tra được).
const REPUBLISH_MS = 4 * 60 * 1000;

/**
 * Bật/tắt tunnel cloudflared cho phép player ngoài LAN đẩy dữ liệu về ingest của host, và sinh code.
 * Có hai code: code dài (base64: origin + group code + key, dán được vào bản player CLI) và code ngắn
 * 5 ký tự (chỉ là chìa khoá tra cứu; host công bố origin/group/room cam lên điểm hẹn công khai).
 * Code ngắn không chứa key và chỉ dùng được với chế độ auxiliary của Client.
 */
export class ValorantRemoteAccess {
  private tunnel: Tunnel | null = null;
  private starting: Promise<void> | null = null;
  private state = "off";
  private origin = "";
  private error: string | null = null;
  private shortCode = "";
  private publishedAt = 0;
  private publishError: string | null = null;

  private load(file: string) {
    const dir = resolve("collector/hosts/valorant-collector/runtime");
    return import(pathToFileURL(resolve(dir, file)).href);
  }

  /** Mã camera được sinh cùng mã tunnel, không cần operator nhập room riêng. */
  cameraRoom() {
    return this.tunnel && this.shortCode ? this.shortCode : "";
  }

  /**
   * Công bố origin hiện tại lên điểm hẹn dưới code ngắn. Giữ nguyên code trong suốt phiên: tunnel
   * khởi động lại (URL mới) thì chỉ cần đăng lại, player vẫn dùng code cũ.
   */
  private async publish() {
    const origin = this.tunnel?.origin || this.origin;
    if (!origin) return;
    try {
      const config = await this.load("config.mjs");
      const loaded = await config.ensureConfig(config.defaultConfigPath);
      const rendezvous = await this.load("rendezvous.mjs");
      if (!this.shortCode) this.shortCode = rendezvous.newCode();
      const match = await loadMatchConfig(defaultPaths());
      const payload = rendezvous.buildPayload({
        origin,
        groupCode: loaded.groupCode,
        camRoom: match.playercams.enable ? this.cameraRoom() : "",
        host: "host",
      });
      const result = await rendezvous.publishCode(this.shortCode, payload);
      if (result.ok) {
        this.publishedAt = Date.now();
        this.publishError = null;
      } else {
        this.publishError = result.error ?? "publish-failed";
      }
    } catch (e) {
      this.publishError = e instanceof Error ? e.message : String(e);
    }
  }

  enable() {
    if (this.tunnel || this.starting) return this.starting ?? Promise.resolve();
    this.state = "starting";
    this.error = null;
    this.starting = this.boot().finally(() => (this.starting = null));
    return this.starting;
  }
  private async boot() {
    try {
      const config = await this.load("config.mjs");
      const loaded = await config.ensureConfig(config.defaultConfigPath);
      const rendezvous = await this.load("rendezvous.mjs");
      if (!this.shortCode) this.shortCode = rendezvous.newCode();
      const tunnelMod = await this.load("tunnel.mjs");
      this.tunnel = await tunnelMod.startTunnel({
        ingestPort: loaded.ports.ingest,
        onState: ({ state, origin }: { state: string; origin: string }) => {
          this.state = state;
          this.origin = origin;
          // Đăng code ngay khi có URL công khai (tunnel khởi động lại sẽ đăng lại URL mới).
          if (state === "connected" && origin) void this.publish();
        },
        log: () => {},
      });
      const snap = this.tunnel!.status();
      this.state = snap.state;
      this.origin = snap.origin;
      if (snap.origin) void this.publish();
    } catch (e) {
      this.state = "failed";
      this.error = e instanceof Error ? e.message : String(e);
      this.tunnel = null;
    }
  }

  async disable() {
    const t = this.tunnel;
    this.tunnel = null;
    this.state = "off";
    this.origin = "";
    this.error = null;
    this.publishedAt = 0;
    this.publishError = null;
    await t?.stop();
  }
  stop() {
    void this.disable();
  }

  async status() {
    const origin = this.tunnel?.origin || this.origin;
    let code = "";
    let groupCode = "";
    if (origin) {
      try {
        const config = await this.load("config.mjs");
        const loaded = await config.ensureConfig(config.defaultConfigPath);
        const key = await config.loadKey(config.defaultConfigPath);
        groupCode = loaded.groupCode;
        code = encodeJoinCode({ origin, groupCode, key });
      } catch {
        // Key/config chưa sẵn: trả origin, code để trống.
      }
      // UI hỏi trạng thái mỗi vài giây: chỉ đăng lại khi đã quá hạn, không đăng theo nhịp hỏi.
      if (Date.now() - this.publishedAt > REPUBLISH_MS) void this.publish();
    }
    return {
      enabled: this.tunnel !== null,
      state: this.tunnel ? this.state : "off",
      origin,
      groupCode,
      code,
      shortCode: this.shortCode,
      cameraRoom: this.cameraRoom(),
      publishError: this.publishError,
      error: this.error,
    };
  }
}
