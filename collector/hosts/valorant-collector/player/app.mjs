// Điểm chạy bản PLAYER: mở UI cục bộ để nhập code, theo dõi kết nối và bật/tắt camera.
//
//   npm run valorant:player
//   node collector/hosts/valorant-collector/player/app.mjs --code ABCDE --no-open
//
// Code (5 ký tự) được phân giải qua điểm hẹn (runtime/rendezvous.mjs) rồi Client chạy ngầm ở chế độ
// auxiliary để đẩy máu/kỹ năng của chính máy này về ingest của host.
import { spawn } from "node:child_process";
import { startPlayerUi } from "./ui.mjs";

const arg = (name) => {
  const index = process.argv.indexOf(`--${name}`);
  return index >= 0 ? process.argv[index + 1] : undefined;
};

const openBrowser = (url) => {
  const child =
    process.platform === "win32"
      ? spawn("cmd", ["/c", "start", "", url], { windowsHide: true, detached: true })
      : process.platform === "darwin"
        ? spawn("open", [url], { detached: true })
        : spawn("xdg-open", [url], { detached: true });
  child.unref();
};

const log = (message) => console.log(`[player] ${message}`);

let ui;
try {
  ui = await startPlayerUi({ log });
} catch (error) {
  if (error?.code === "EADDRINUSE") {
    console.error(
      `[player] Cổng ${process.env.RIOT_OVERLAY_PLAYER_PORT || 5398} đang bị chiếm. Đóng tiến trình cũ hoặc đổi cổng: RIOT_OVERLAY_PLAYER_PORT=5397 npm run valorant:player`,
    );
  } else {
    console.error(`[player] Không mở được UI: ${error?.message || error}`);
  }
  process.exit(1);
}
log(`UI: ${ui.url}  (Ctrl+C để dừng)`);
if (!process.argv.includes("--no-open")) openBrowser(ui.url);

const code = arg("code") ?? process.argv.slice(2).find((value) => !value.startsWith("--"));
if (code) {
  log(`Tự kết nối bằng code ${code}`);
  const view = await ui.agent.join(code, { startClient: !process.argv.includes("--no-client") });
  if (view.phase === "error") log(`Không kết nối được: ${view.detail}`);
}

const shutdown = async () => {
  await ui.agent.leave();
  await ui.stop();
  process.exit(0);
};
process.on("SIGINT", () => void shutdown());
process.on("SIGTERM", () => void shutdown());
