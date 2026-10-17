import { resolve } from "node:path";
import { pathToFileURL } from "node:url";

export type ModuleState = "stopped" | "starting" | "running" | "failed";
interface Runtime {
  stop: () => Promise<void>;
  fatal: Promise<string>;
  getStatus: () => Promise<Record<string, unknown>>;
}

/**
 * Chạy backend/frontend Spectra và Client fork ngay trong tiến trình Studio khi game Valorant được bật.
 * Chỉ dừng những process do supervisor này tạo; tắt game thì giải phóng toàn bộ.
 */
export class ValorantModule {
  private runtime: Runtime | null = null;
  private state: ModuleState = "stopped";
  private error: string | null = null;
  private starting: Promise<void> | null = null;
  start() {
    if (this.runtime || this.starting) return this.starting ?? Promise.resolve();
    this.state = "starting";
    this.error = null;
    this.starting = this.boot().finally(() => (this.starting = null));
    return this.starting;
  }
  private async boot() {
    try {
      // Đường dẫn động để tsc không phải khai báo kiểu cho module .mjs của runtime.
      const dir = resolve("modules/valorant/runtime");
      const load = (file: string) => import(pathToFileURL(resolve(dir, file)).href);
      const [config, supervisor] = await Promise.all([load("config.mjs"), load("supervisor.mjs")]);
      const configPath: string = config.defaultConfigPath;
      const runtime: Runtime = await supervisor.startModule({
        config: await config.loadConfig(configPath),
        configPath,
      });
      this.runtime = runtime;
      this.state = "running";
      void runtime.fatal.then(async (reason) => {
        if (this.runtime !== runtime) return;
        this.runtime = null;
        this.state = "failed";
        this.error = String(reason);
        await runtime.stop().catch(() => {});
      });
    } catch (e) {
      this.runtime = null;
      this.state = "failed";
      this.error = e instanceof Error ? e.message : "Không khởi động được module Valorant.";
    }
  }
  async stop() {
    await this.starting?.catch(() => {});
    const runtime = this.runtime;
    this.runtime = null;
    this.state = "stopped";
    this.error = null;
    if (runtime) await runtime.stop().catch(() => {});
  }
  snapshot() {
    return { status: this.state, error: this.error };
  }
  async detail() {
    return this.runtime ? await this.runtime.getStatus().catch(() => null) : null;
  }
}
