// Công bố code ngắn 5 ký tự cho player, không cần Studio.
// Mở (hoặc dùng lại) tunnel cloudflared tới cổng ingest, rồi đăng {origin, groupCode, camRoom} lên
// điểm hẹn (runtime/rendezvous.mjs) và in code. Giữ tiến trình sống để đăng lại định kỳ.
//
//   npm run valorant:code
//   node .../runtime/publish-code.mjs --origin https://abc.trycloudflare.com:443
//   node .../runtime/publish-code.mjs --code ABCDE --interval 240 --once
import { readFile } from "node:fs/promises";
import { resolve } from "node:path";
import { defaultConfigPath, loadConfig, localRoot } from "./config.mjs";
import { buildPayload, newCode, publishCode, rendezvousService } from "./rendezvous.mjs";
import { startTunnel } from "./tunnel.mjs";

const arg = (name) => {
  const index = process.argv.indexOf(`--${name}`);
  return index >= 0 ? (process.argv[index + 1] ?? true) : undefined;
};
const numberArg = (name, fallback) => {
  const value = arg(name);
  return value === undefined ? fallback : Number(value);
};

const matchConfigPath = resolve(localRoot, "match-config.json");
const readCamRoom = async () => {
  try {
    const config = JSON.parse(await readFile(matchConfigPath, "utf8"));
    return String(config?.playercams?.roomId ?? "");
  } catch {
    return "";
  }
};

const config = await loadConfig(defaultConfigPath);
const intervalMs = Math.max(60, numberArg("interval", 240)) * 1000;
let code = String(arg("code") ?? newCode()).toUpperCase();
let origin = String(arg("origin") ?? "").replace(/\/+$/, "");
let tunnel = null;

if (!origin) {
  console.log(`Mở tunnel tới ingest 127.0.0.1:${config.ports.ingest}…`);
  tunnel = await startTunnel({
    ingestPort: config.ports.ingest,
    onState: ({ origin: next }) => {
      if (next) origin = next;
    },
    log: (line) => console.log(`[tunnel] ${line}`),
  });
  const deadline = Date.now() + 60_000;
  while (!tunnel.origin && Date.now() < deadline) await new Promise((ok) => setTimeout(ok, 500));
  origin = tunnel.origin || origin;
}
if (!origin) {
  console.error("Không lấy được URL tunnel. Kiểm tra kết nối mạng rồi chạy lại.");
  await tunnel?.stop();
  process.exit(1);
}

const camRoom = String(arg("room") ?? (await readCamRoom()) ?? "");

const publishOnce = async () => {
  const payload = buildPayload({ origin, groupCode: config.groupCode, camRoom, host: "host" });
  const result = await publishCode(code, payload);
  if (result.ok) {
    console.log(`code ${code} → ${origin}  (topic ${result.topic}, điểm hẹn ${rendezvousService()})`);
    if (camRoom) console.log(`room cam: ${camRoom}`);
  } else {
    console.error(`Đăng code thất bại: ${result.error}`);
  }
  return result.ok;
};

await publishOnce();
if (arg("once")) {
  await tunnel?.stop();
  process.exit(0);
}

console.log(`Đăng lại mỗi ${Math.round(intervalMs / 1000)}s. Ctrl+C để dừng.`);
const timer = setInterval(() => void publishOnce(), intervalMs);
timer.unref?.();

const stop = async () => {
  clearInterval(timer);
  await tunnel?.stop();
  process.exit(0);
};
process.on("SIGINT", () => void stop());
process.on("SIGTERM", () => void stop());
