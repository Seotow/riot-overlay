import { appendFile, readFile, stat } from "node:fs/promises";
import { resolve, sep } from "node:path";
import { pathToFileURL } from "node:url";

const labels = {
  1: "Bắt đầu cấm chọn",
  2: "Bắt đầu loading / trận",
  3: "Lên cấp",
  4: "Hoàn thành món lớn",
  5: "Kích hoạt item / Guardian Angel",
  6: "Giao tranh",
  7: "Chết / hồi sinh",
  8: "Hạ rồng / Dragon Soul",
  9: "Hạ Baron / Power Play",
  10: "Nhà lính bị phá / hồi sinh",
  11: "Kết thúc trận",
  12: "Hạ trụ / trụ đầu",
};

const raw = process.argv.slice(2).join(" ").trim();
const match = /^(\d{1,2})\s*-\s*(\d{1,3}):(\d{2})(?:\s+(.+))?$/.exec(raw);
if (!match) throw Error("Marker phải có dạng: STT - MM:SS [ghi chú] (ví dụ: 5 - 18:42 ITEM GA)");
const sequence = Number(match[1]);
if (!labels[sequence]) throw Error("STT phải từ 1 đến 12.");
const minutes = Number(match[2]);
const seconds = Number(match[3]);
if (seconds >= 60) throw Error("Giây phải từ 00 đến 59.");

const root = process.env.RIOT_CAPTURE_ROOT
  ? pathToFileURL(resolve(process.env.RIOT_CAPTURE_ROOT) + sep)
  : new URL("../../data/captures/", import.meta.url);
try {
  const pointer = JSON.parse(await readFile(new URL("active-lb.json", root), "utf8"));
  if (!/^lb-\d{4}-\d{2}-\d{2}T\d{2}-\d{2}-\d{2}-\d{3}Z$/.test(pointer.directory)) {
    throw Error("Capture directory không hợp lệ.");
  }
  let sourceAgeSeconds = null;
  try {
    const source = await stat(new URL(`${pointer.directory}/leaguebroadcast-ws.ndjson`, root));
    sourceAgeSeconds = Math.max(0, (Date.now() - source.mtimeMs) / 1000);
  } catch {}
  const captureWarning =
    sourceAgeSeconds === null
      ? "Chưa có file dữ liệu LB."
      : sourceAgeSeconds > 5
        ? `Nguồn LB không có frame mới trong ${sourceAgeSeconds.toFixed(1)} giây.`
        : null;
  const marker = {
    sequence,
    label: labels[sequence],
    gameTime: `${minutes.toString().padStart(2, "0")}:${seconds.toString().padStart(2, "0")}`,
    gameTimeSeconds: minutes * 60 + seconds,
    markedAt: new Date().toISOString(),
    windowSeconds: 10,
    ...(match[4] ? { note: match[4].trim() } : {}),
    sourceAgeSeconds: sourceAgeSeconds === null ? null : Number(sourceAgeSeconds.toFixed(3)),
    ...(captureWarning ? { captureWarning } : {}),
  };
  await appendFile(
    new URL(`${pointer.directory}/markers.ndjson`, root),
    JSON.stringify(marker) + "\n",
    "utf8",
  );
  console.log(JSON.stringify({ capture: pointer.directory, marker }, null, 2));
} catch {
  throw Error("Không có capture LB đang chạy; không ghi marker vào bản cũ.");
}
