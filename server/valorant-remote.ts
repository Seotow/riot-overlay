import { resolve } from "node:path";
import { pathToFileURL } from "node:url";
import { encodeJoinCode } from "../shared/valorant-remote";

interface Tunnel {
  readonly origin: string;
  status: () => { state: string; origin: string };
  stop: () => Promise<void>;
}

/**
 * Bật/tắt tunnel cloudflared cho phép player ngoài LAN đẩy dữ liệu về ingest của host, và sinh code ngắn.
 * Code chứa origin công khai + group code + key; chỉ chia sẻ riêng tư cho player tin cậy.
 */
export class ValorantRemoteAccess {
  private tunnel: Tunnel | null = null;
  private starting: Promise<void> | null = null;
  private state = "off";
  private origin = "";
  private error: string | null = null;

  private load(file: string) {
    const dir = resolve("collector/hosts/valorant-collector/runtime");
    return import(pathToFileURL(resolve(dir, file)).href);
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
      const tunnelMod = await this.load("tunnel.mjs");
      this.tunnel = await tunnelMod.startTunnel({
        ingestPort: loaded.ports.ingest,
        onState: ({ state, origin }: { state: string; origin: string }) => {
          this.state = state;
          this.origin = origin;
        },
        log: () => {},
      });
      const snap = this.tunnel!.status();
      this.state = snap.state;
      this.origin = snap.origin;
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
    }
    return {
      enabled: this.tunnel !== null,
      state: this.tunnel ? this.state : "off",
      origin,
      groupCode,
      code,
      error: this.error,
    };
  }
}
