// Bản PLAYER (CLI, không có UI): nhập code của host → chạy Spectra Client chính thức ngầm, đẩy dữ
// liệu của máy player (auxiliary: máu, chiêu, tiền chính xác) về ingest của host qua tunnel.
// Bản có UI đầy đủ (nhập code, trạng thái, bật/tắt camera) là player/app.mjs — dùng bản đó trước.
//
//   npm run valorant:player:cli -- ABCDE
//   node collector/hosts/valorant-collector/player/join.mjs ABCDE
//
// Code nhận cả dạng ngắn 5 ký tự (tra ở điểm hẹn, runtime/rendezvous.mjs) lẫn code dài base64 cũ.
import { createInterface } from "node:readline/promises";
import { stdin, stdout } from "node:process";
import { acquireOfficial, startOfficial } from "../client/official.mjs";
import { playercamPushUrl, streamIdProblem } from "./cam.mjs";
import { resolveJoin } from "./join-code.mjs";

async function readCode() {
  const fromArg = process.argv.slice(2).join(" ").trim();
  if (fromArg) return fromArg;
  const rl = createInterface({ input: stdin, output: stdout });
  try {
    return (await rl.question("Nhập code của host (5 ký tự hoặc code dài) rồi Enter: ")).trim();
  } finally {
    rl.close();
  }
}

const log = (msg) => console.log(msg);

try {
  const join = await resolveJoin(await readCode());
  if (join.kind === "short") log(`Code ${join.code} → ${join.origin}`);
  else log(`Code dài → ${join.origin}, group ${join.groupCode}`);
  if (join.camRoom) {
    const riotId = process.env.RIOT_OVERLAY_PLAYER_ID || "";
    const problem = streamIdProblem(riotId);
    log(`Room cam của host: ${join.camRoom}`);
    log(
      problem
        ? "Đặt RIOT_OVERLAY_PLAYER_ID=Tên#Tag để in link đẩy cam, hoặc dùng player/app.mjs để tự đọc từ trận."
        : `Link đẩy cam: ${playercamPushUrl(join.camRoom, riotId)}`,
    );
  }

  log("Chuẩn bị Spectra Client (tải một lần nếu máy chưa có)…");
  await acquireOfficial({}, log);
  // Player đẩy dữ liệu của chính máy mình (máu, chiêu, tiền) nên phải chạy chế độ auxiliary;
  // observer của host đã phủ roster/scoreboard. URL thiếu cổng sẽ bị Client tự thêm :5100.
  const runtime = await startOfficial({
    config: {},
    match: {
      observerName: "Player",
      key: join.key,
      groupCode: join.groupCode,
      ingest: join.origin,
      teams: [
        { name: "Team 1", tricode: "T1", url: "" },
        { name: "Team 2", tricode: "T2", url: "" },
      ],
      tournamentLogo: "",
    },
    mode: "auxiliary",
    auxName: "Player",
    onState: ({ state, title }) => log(`Client: ${title || state}`),
  });
  log("Đang chạy ngầm. Vào trận bình thường; cửa sổ Client đã ẩn. Nhấn Ctrl+C để dừng.");
  let closing = false;
  const stop = async () => {
    if (closing) return;
    closing = true;
    await runtime.stop();
    process.exit(0);
  };
  process.on("SIGINT", () => void stop());
  process.on("SIGTERM", () => void stop());
} catch (error) {
  console.error(error.message || String(error));
  process.exitCode = 1;
}
