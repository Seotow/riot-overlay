import { createReadStream } from "node:fs";
import { readFile } from "node:fs/promises";
import { resolve, sep } from "node:path";
import { createInterface } from "node:readline";
import { pathToFileURL } from "node:url";

const root = process.env.RIOT_CAPTURE_ROOT
  ? pathToFileURL(resolve(process.env.RIOT_CAPTURE_ROOT) + sep)
  : new URL("../../data/captures/", import.meta.url);
let directory = process.argv[2];
const windowSeconds = Math.max(1, Math.min(60, Number(process.argv[3] ?? 10)));
if (!directory) {
  let pointer;
  try {
    pointer = JSON.parse(await readFile(new URL("active-lb.json", root), "utf8"));
  } catch {
    pointer = JSON.parse(await readFile(new URL("latest-lb.json", root), "utf8"));
  }
  directory = pointer.directory;
}
if (!/^lb-\d{4}-\d{2}-\d{2}T\d{2}-\d{2}-\d{2}-\d{3}Z$/.test(directory)) {
  throw Error("Capture directory không hợp lệ.");
}

const parseLines = (text) =>
  text
    .split(/\r?\n/)
    .filter(Boolean)
    .map((line) => JSON.parse(line));
const markers = parseLines(await readFile(new URL(`${directory}/markers.ndjson`, root), "utf8"));
const matches = markers.map(() => ({ frames: [], statuses: [], lastSourceAtBeforeMarker: null }));
const input = createInterface({
  input: createReadStream(new URL(`${directory}/leaguebroadcast-ws.ndjson`, root), {
    encoding: "utf8",
  }),
  crlfDelay: Infinity,
});
for await (const line of input) {
  if (!line.trim()) continue;
  const record = JSON.parse(line);
  markers.forEach((marker, index) => {
    if (Date.parse(record.receivedAt) <= Date.parse(marker.markedAt)) {
      matches[index].lastSourceAtBeforeMarker = record.receivedAt;
    }
  });
  if (record.message?.type === "ingame-state-update") {
    const gameTime = Number(record.message.state?.gameTime);
    if (!Number.isFinite(gameTime)) continue;
    markers.forEach((marker, index) => {
      if (Math.abs(gameTime - marker.gameTimeSeconds) <= windowSeconds) {
        matches[index].frames.push({ receivedAt: record.receivedAt, gameTime });
      }
    });
  } else if (record.message?.type === "gameStatus") {
    const receivedAt = Date.parse(record.receivedAt);
    markers.forEach((marker, index) => {
      if (Math.abs(receivedAt - Date.parse(marker.markedAt)) <= windowSeconds * 1000) {
        matches[index].statuses.push({
          receivedAt: record.receivedAt,
          gameState: record.message.gameState,
        });
      }
    });
  }
}

const report = markers.map((marker, index) => {
  const candidates = matches[index].frames;
  const closest = candidates.reduce(
    (best, frame) =>
      !best ||
      Math.abs(frame.gameTime - marker.gameTimeSeconds) <
        Math.abs(best.gameTime - marker.gameTimeSeconds)
        ? frame
        : best,
    null,
  );
  return {
    sequence: marker.sequence,
    label: marker.label,
    ...(marker.note ? { note: marker.note } : {}),
    targetGameTime: marker.gameTime,
    windowSeconds,
    sourceAgeSecondsAtMark: matches[index].lastSourceAtBeforeMarker
      ? Number(
          (
            (Date.parse(marker.markedAt) - Date.parse(matches[index].lastSourceAtBeforeMarker)) /
            1000
          ).toFixed(3),
        )
      : null,
    sourceHealthyAtMark: matches[index].lastSourceAtBeforeMarker
      ? Date.parse(marker.markedAt) - Date.parse(matches[index].lastSourceAtBeforeMarker) <= 5000
      : false,
    frames: candidates.length,
    nearbyGameStatuses: matches[index].statuses,
    range: candidates.length ? [candidates[0].gameTime, candidates.at(-1).gameTime] : null,
    closest: closest
      ? {
          gameTime: closest.gameTime,
          deltaSeconds: Number((closest.gameTime - marker.gameTimeSeconds).toFixed(3)),
          receivedAt: closest.receivedAt,
        }
      : null,
  };
});
console.log(JSON.stringify({ capture: directory, markers: report.length, report }, null, 2));
