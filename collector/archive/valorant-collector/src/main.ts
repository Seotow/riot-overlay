// Collector Valorant của Riot Overlay: không cửa sổ, không tray, không cập nhật. Studio cấp cấu hình qua
// RIOT_OVERLAY_VALORANT_CONFIG; collector đọc GEP, gửi lên ingest và nhận lệnh qua cổng loopback.
import { app } from "electron";
import { execFile } from "child_process";
import { appendFileSync } from "fs";
import { tmpdir } from "os";
import { join } from "path";
import { loadHostConfig, readMatchConfig } from "./config";
import { Control } from "./control";
import { GepSession } from "./gep";
import { Ingest, SecretStore } from "./ingest";
import { initLog, log } from "./log";

// Lỗi trước khi log của profile sẵn sàng vẫn để lại dấu vết (không chứa key hay cấu hình).
function crash(stage: string, e: unknown) {
  try {
    appendFileSync(
      join(tmpdir(), "riot-overlay-valorant-collector.log"),
      `${new Date().toISOString()} ${stage}: ${e instanceof Error ? e.stack : String(e)}\n`,
    );
  } catch {}
  app.exit(1);
}
process.on("uncaughtException", (e) => crash("uncaughtException", e));
process.on("unhandledRejection", (e) => crash("unhandledRejection", e));

try {
  const config = loadHostConfig();
  // Profile riêng: không dùng chung dữ liệu hay khoá single-instance với Overwolf/Spectra Client cài sẵn.
  if (config.profileDir) app.setPath("userData", config.profileDir);
  initLog(join(app.getPath("userData"), "logs"));

  if (!app.requestSingleInstanceLock()) {
    log.warn("Đã có một collector Valorant khác dùng profile này; thoát.");
    app.exit(0);
  } else {
    let overwolfRunning = false;
    const checkOverwolf = () =>
      execFile(
        "tasklist",
        ["/FI", "IMAGENAME eq Overwolf.exe", "/NH"],
        { windowsHide: true },
        (_e, out) => {
          overwolfRunning = /Overwolf\.exe/i.test(String(out));
          if (overwolfRunning) log.warn("Overwolf thường đang chạy: có thể tranh GEP với collector.");
        },
      );

    const ingest = new Ingest(config, new SecretStore(join(app.getPath("userData"), "state")));
    const connect = () => ingest.connect(readMatchConfig(config));
    const gep: GepSession = new GepSession(ingest, connect);
    const control = new Control(config, ingest, gep, () => overwolfRunning);

    app.whenReady().then(() => {
      log.info("Collector Valorant khởi động");
      checkOverwolf();
      gep.start();
      control.start();
      // Nối thẳng ingest ngay khi khởi động (Studio thấy collector ngay); trận mới nối lại ở màn chọn agent.
      setTimeout(connect, 1500);
      // Cấu hình mới của Studio được đẩy vào trận ngay khi nối xong.
      let tries = 0;
      const push = setInterval(() => {
        if (ingest.isConnected()) {
          clearInterval(push);
          control.sendConfig();
        } else if (++tries > 120) clearInterval(push);
      }, 500);
    });
    // Không có cửa sổ nên không để Electron tự thoát; chỉ dừng khi bị yêu cầu.
    app.on("window-all-closed", () => {});
    app.on("before-quit", () => ingest.stop());
  }
} catch (e) {
  crash("startup", e);
}
