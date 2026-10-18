// Đọc Overwolf GEP của Valorant và chuyển lên ingest. Dịch từ Spectra Client (services/gepService.ts,
// GPL-3.0-only), chỉ nhánh observer, không UI. Xem NOTICE.md.
import type { overwolf } from "@overwolf/ow-electron";
import { log } from "./log";
import {
  DataTypes,
  formatKillfeedData,
  formatRosterData,
  formatRoundData,
  formatScoreboardData,
} from "./protocol";
import { Ingest } from "./ingest";

// electron chỉ nạp khi chạy thật, để các hàm xử lý sự kiện kiểm thử được ngoài Electron.
const overwolfApp = () => (require("electron").app as overwolf.OverwolfApp);
const VALORANT_ID = 21640;

export interface GepStatus {
  ready: boolean;
  version: string | null;
  error: string | null;
  updating: boolean;
  /** Overwolf chỉ trả gói GEP giả 0.0.0 cho app UID chưa đăng ký: không có dữ liệu game. */
  stub: boolean;
  /** UID Overwolf của app (băm từ productName/name + author.name trong package.json). */
  appUid: string | null;
  scene: string;
  roundNumber: number;
  roundPhase: string;
  map: string;
}

export class GepSession {
  private gep!: overwolf.packages.OverwolfGameEventPackage;
  private enabled = false;
  private ready = false;
  private version: string | null = null;
  private error: string | null = null;
  private updating = false;
  private scene = "";
  private roundNumber = 0;
  private roundPhase = "";
  private matchId = "";
  private map = "";
  private gameMode = "";
  private isCustomGame = false;

  constructor(
    private readonly ingest: Ingest,
    /** Yêu cầu collector mở/nối lại ingest (vào chọn agent, bắt đầu trận). */
    private readonly requestConnect: () => void,
  ) {}

  status(): GepStatus {
    return {
      ready: this.ready,
      version: this.version,
      error: this.error,
      updating: this.updating,
      stub: this.version === "0.0.0",
      appUid: process.env.OVERWOLF_APP_UID ?? null,
      scene: this.scene,
      roundNumber: this.roundNumber,
      roundPhase: this.roundPhase,
      map: this.map,
    };
  }
  phase() {
    return this.roundPhase;
  }

  start() {
    overwolfApp().overwolf.packages.on("failed-to-initialize", (_e, info) => {
      this.error = `GEP không khởi tạo được: ${String(info)}`;
      log.error(this.error);
    });
    overwolfApp().overwolf.packages.on("package-update-pending", (_e, info) => {
      for (const pkg of info) {
        if (pkg.name !== "gep") continue;
        this.updating = true;
        log.info(`GEP đang cập nhật lên ${pkg.version}`);
      }
    });
    overwolfApp().overwolf.packages.on("ready", (_e, packageName, version) => {
      if (packageName !== "gep") return;
      this.version = version;
      this.updating = false;
      log.info(`GEP ${version} sẵn sàng`);
      void this.onReady();
    });
  }

  private async onReady() {
    this.gep = overwolfApp().overwolf.packages.gep;
    this.gep.removeAllListeners();
    try {
      // https://overwolf.github.io/api/live-game-data/supported-games/valorant
      await this.gep.setRequiredFeatures(VALORANT_ID, ["match_info", "me", "game_info"]);
      this.ready = true;
      this.error = null;
    } catch (e) {
      this.error = `GEP ${this.version} không hỗ trợ Valorant: ${e instanceof Error ? e.message : e}`;
      log.error(this.error);
    }
    this.gep.on("game-detected", (e, gameId, name) => {
      log.info(`Phát hiện game ${gameId} ${name}`);
      if (gameId !== VALORANT_ID) return;
      e.enable();
      this.enabled = true;
    });
    this.gep.on("new-info-update", (_e, _gameId, ...args) => {
      if (!this.enabled) return;
      for (const data of args as any[]) {
        try {
          this.processInfoUpdate(data);
        } catch (e) {
          log.error("Lỗi info update", e as Error);
        }
      }
    });
    this.gep.on("new-game-event", (_e, _gameId, ...args) => {
      if (!this.enabled) return;
      for (const data of args as any[]) {
        try {
          this.processGameEvent(data);
        } catch (e) {
          log.error("Lỗi game event", e as Error);
        }
      }
    });
    this.gep.on("error", (_e, _gameId, error) => {
      this.error = `GEP lỗi: ${String(error)}`;
      log.error(this.error);
      this.enabled = false;
    });
  }

  // Map và game mode đến sớm hơn lúc kết nối ingest xong, nên chờ rồi gửi lại.
  private sendWhenConnected(payload: { type: string; data: unknown }) {
    if (this.ingest.isConnected()) this.ingest.send(payload);
    else setTimeout(() => this.ingest.send(payload), 5000);
  }

  private processInfoUpdate(data: any) {
    if (data.gameId !== VALORANT_ID) return;
    const key: string = data.key;
    if (key.includes("scoreboard")) {
      if (data.value == null || ["open", "closed", "close"].includes(data.value)) return;
      const value = JSON.parse(data.value);
      if (value.name == undefined || value.name == "") return;
      this.ingest.send(formatScoreboardData(value));
      return;
    }
    if (key.includes("roster")) {
      const value = JSON.parse(data.value);
      if (value.name == undefined || value.name == "") return;
      this.ingest.send(formatRosterData(value, key));
      return;
    }
    switch (key) {
      case "kill_feed":
        if (data.value == null) return;
        this.ingest.send(formatKillfeedData(JSON.parse(data.value)));
        break;
      case "observing":
        if (data.value == null) return;
        this.ingest.send({ type: DataTypes.OBSERVING, data: data.value });
        break;
      case "round_number":
        if (data.value) this.roundNumber = +data.value;
        break;
      case "round_phase": {
        if (data.value == null) return;
        const formatted = formatRoundData(data.value, this.roundNumber);
        this.ingest.send(formatted);
        this.roundPhase = data.value;
        if ((formatted.data as { roundPhase: string }).roundPhase === "game_end") this.ingest.endMatch();
        break;
      }
      case "match_score":
        if (data.value == null) return;
        this.ingest.send({ type: DataTypes.SCORE, data: JSON.parse(data.value) });
        break;
      case "scene":
        if (data.value == null) return;
        this.scene = data.value;
        // Vào chọn agent là lúc nối ingest cho trận mới.
        if (this.scene === "CharacterSelectPersistentLevel") this.requestConnect();
        break;
      case "game_mode": {
        if (data.value == null) return;
        const mode = JSON.parse(data.value);
        if (!mode || !mode.mode) return;
        this.gameMode = mode.mode;
        this.isCustomGame = mode.custom;
        this.sendWhenConnected({ type: DataTypes.GAME_MODE, data: mode.mode });
        break;
      }
      case "map": {
        if (data.value == null) return;
        // Enum phía server không nhận "Infinity" vì là tên số.
        const map = data.value === "Infinity" ? "Infinityy" : data.value;
        this.map = map;
        this.sendWhenConnected({ type: DataTypes.MAP, data: map });
        break;
      }
      case "match_id":
        if (data.value == null) return;
        this.matchId = data.value;
        break;
      default:
        // health/abilities (chỉ Auxiliary), player_id, state, score, agent, ...: collector này không dùng.
        break;
    }
  }

  private processGameEvent(data: any) {
    if (data.gameId !== VALORANT_ID) return;
    switch (data.key) {
      case "match_start":
        this.requestConnect();
        this.ingest.send({ type: DataTypes.MATCH_START, data: this.matchId });
        break;
      case "spike_planted":
        this.ingest.send({ type: DataTypes.SPIKE_PLANTED, data: true });
        break;
      case "spike_detonated":
        this.ingest.send({ type: DataTypes.SPIKE_DETONATED, data: true });
        break;
      case "spike_defused":
        this.ingest.send({ type: DataTypes.SPIKE_DEFUSED, data: true });
        break;
      case "match_end":
        this.ingest.endMatch();
        break;
      default:
        // scoreboard_screen, kill_feed (trùng), shop, planted_location: bỏ qua như upstream.
        break;
    }
  }
}
