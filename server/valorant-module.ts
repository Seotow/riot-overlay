import { resolve } from "node:path";
import { pathToFileURL } from "node:url";
import { ValorantController, officialSecretFile } from "./valorant-controller";
import type { ValorantConfigPaths } from "./valorant-config";

export type ModuleState = "stopped" | "installing" | "starting" | "running" | "failed";
interface Runtime {
  stop: () => Promise<void>;
  fatal: Promise<string>;
  getStatus: () => Promise<Record<string, unknown>>;
}

/**
 * Chạy backend/frontend Spectra và Client Valorant ngay trong tiến trình Studio khi game Valorant được bật.
 * Chỉ dừng những process do supervisor này tạo; tắt game thì giải phóng toàn bộ.
 */
export class ValorantModule {
  private runtime: Runtime | null = null;
  private controllerInstance: ValorantController | null = null;
  private state: ModuleState = "stopped";
  private error: string | null = null;
  private step: string | null = null;
  private starting: Promise<void> | null = null;
  constructor(
    private readonly options: {
      paths: ValorantConfigPaths;
      /** Phase round hiện tại từ output Spectra (để chặn "bom đã đặt" ngoài giao tranh). */
      phase: () => string | null;
    },
  ) {}

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
      const dir = resolve("collector/hosts/valorant-collector/runtime");
      const load = (file: string) => import(pathToFileURL(resolve(dir, file)).href);
      // Máy mới: tự dựng backend, overlay và Client trước khi chạy (không cần setup tay).
      const setup = await load("setup.mjs");
      if (await setup.setupPending()) {
        this.state = "installing";
        await setup.runSetup({ onStep: (label: string) => (this.step = label) });
        this.step = null;
        this.state = "starting";
      }
      const [config, supervisor] = await Promise.all([load("config.mjs"), load("supervisor.mjs")]);
      const configPath: string = config.defaultConfigPath;
      const loaded = await config.ensureConfig(configPath);
      const runtime: Runtime = await supervisor.startModule({ config: loaded, configPath });
      this.runtime = runtime;
      this.state = "running";
      {
        // Lệnh thủ công và cấu hình giữa trận đi qua một phiên observer thứ hai của Studio.
        const official = await import(
          pathToFileURL(resolve("collector/hosts/valorant-collector/client/official.mjs")).href
        );
        const { profile } = await official.officialPaths();
        this.controllerInstance = new ValorantController({
          ingestPort: loaded.ports.ingest,
          extrasPort: loaded.ports.extras,
          groupCode: loaded.groupCode,
          key: await config.loadKey(configPath),
          observerName: "Riot Overlay Studio",
          secretFile: officialSecretFile(profile),
          paths: this.options.paths,
          phase: this.options.phase,
        });
        this.controllerInstance.start();
      }
      void runtime.fatal.then(async (reason) => {
        if (this.runtime !== runtime) return;
        this.runtime = null;
        this.controllerInstance?.stop();
        this.controllerInstance = null;
        this.state = "failed";
        this.error = String(reason);
        await runtime.stop().catch(() => {});
      });
    } catch (e) {
      this.runtime = null;
      this.state = "failed";
      this.step = null;
      this.error = e instanceof Error ? e.message : "Không khởi động được module Valorant.";
    }
  }
  async stop() {
    await this.starting?.catch(() => {});
    const runtime = this.runtime;
    this.runtime = null;
    this.controllerInstance?.stop();
    this.controllerInstance = null;
    this.state = "stopped";
    this.error = null;
    this.step = null;
    if (runtime) await runtime.stop().catch(() => {});
  }
  /** Có khi module chạy bằng Client chính thức; chế độ collector riêng dùng cổng điều khiển của nó. */
  controller() {
    return this.controllerInstance;
  }
  snapshot() {
    return { status: this.state, error: this.error, step: this.step };
  }
  async detail() {
    const detail = this.runtime ? await this.runtime.getStatus().catch(() => null) : null;
    return detail && this.controllerInstance
      ? { ...detail, controller: this.controllerInstance.status() }
      : detail;
  }
}
