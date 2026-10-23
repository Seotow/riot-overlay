// Bản PLAYER: nhập code ngắn của host → chạy Spectra Client chính thức ngầm, đẩy dữ liệu của máy
// player (auxiliary: máu, chiêu, tiền chính xác) về ingest của host qua tunnel. Dùng lại y hệt cơ chế
// chạy ngầm của host (client/official.mjs), chỉ đổi đích ingest thành URL công khai trong code.
//
//   node collector/hosts/valorant-collector/player/join.mjs <CODE>
//
// Player chỉ cần nhập đúng một code; Client được tải một lần nếu máy chưa có (kiểm SHA256).
import { createInterface } from "node:readline/promises";
import { stdin, stdout } from "node:process";
import { acquireOfficial, startOfficial } from "../client/official.mjs";
import { decodeJoinCode } from "./remote-code.mjs";

async function readCode() {
  const fromArg = process.argv.slice(2).join(" ").trim();
  if (fromArg) return fromArg;
  const rl = createInterface({ input: stdin, output: stdout });
  try {
    return (await rl.question("Dán code của host rồi Enter: ")).trim();
  } finally {
    rl.close();
  }
}

const log = (msg) => console.log(msg);

try {
  const join = decodeJoinCode(await readCode());
  if (!join) throw new Error("Code không hợp lệ. Hãy xin host dán lại code mới.");
  log("Chuẩn bị Spectra Client (tải một lần nếu máy chưa có)…");
  await acquireOfficial({}, log);
  log(`Kết nối tới host (${join.origin}), group ${join.groupCode}.`);
  const match = {
    observerName: "Player",
    key: join.key,
    groupCode: join.groupCode,
    ingest: join.origin,
    teams: [
      { name: "Team 1", tricode: "T1", url: "" },
      { name: "Team 2", tricode: "T2", url: "" },
    ],
    tournamentLogo: "",
  };
  const runtime = await startOfficial({
    config: {},
    match,
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
