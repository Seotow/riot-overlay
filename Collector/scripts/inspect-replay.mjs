import https from "node:https";
import { mkdir, writeFile } from "node:fs/promises";
import { dirname, resolve } from "node:path";
import { fileURLToPath } from "node:url";
import { randomUUID } from "node:crypto";

// Fixed loopback game endpoints; never reads LCU credentials or raw identities.
function request(path, method = "GET", value) {
  return new Promise((resolve) => {
    const body = value === undefined ? undefined : JSON.stringify(value);
    const req = https.request(
      {
        hostname: "127.0.0.1",
        port: 2999,
        path,
        method,
        rejectUnauthorized: false,
        timeout: 2500,
        headers: body
          ? { "Content-Type": "application/json", "Content-Length": Buffer.byteLength(body) }
          : {},
      },
      (response) => {
        const chunks = [];
        let bytes = 0;
        response.on("data", (chunk) => {
          bytes += chunk.length;
          if (bytes > 2 * 1024 * 1024) req.destroy(new Error("budget"));
          else chunks.push(chunk);
        });
        response.on("end", () => {
          try {
            resolve({
              http: response.statusCode,
              data: JSON.parse(Buffer.concat(chunks).toString("utf8")),
            });
          } catch {
            resolve({ http: response.statusCode, error: "invalid-json" });
          }
        });
        response.on("error", () =>
          resolve({ http: response.statusCode, error: "response-unavailable" }),
        );
      },
    );
    req.on("timeout", () => req.destroy(new Error("timeout")));
    req.on("error", (error) => resolve({ http: null, error: error.code || "request-unavailable" }));
    req.end(body);
  });
}
const args = process.argv.slice(2);
if (
  args.length &&
  !(args.length === 1 && ["--resume-if-paused", "--resume-if-stopped"].includes(args[0]))
) {
  console.error("Invalid mode.");
  process.exit(2);
}
const playback = await request("/replay/playback");
const stats = await request("/liveclientdata/gamestats");
const events = await request("/liveclientdata/eventdata");
const gameEnds = Array.isArray(events.data?.Events)
  ? events.data.Events.filter((event) => event.EventName === "GameEnd")
  : [];
const finite = (value) => (Number.isFinite(value) ? value : null);
const result = {
  capturedAt: new Date().toISOString(),
  playback: {
    http: playback.http,
    error: playback.error ?? null,
    time: finite(playback.data?.time),
    paused: typeof playback.data?.paused === "boolean" ? playback.data.paused : null,
    speed: finite(playback.data?.speed),
    seeking: typeof playback.data?.seeking === "boolean" ? playback.data.seeking : null,
  },
  game: {
    http: stats.http,
    error: stats.error ?? null,
    time: finite(stats.data?.gameTime),
    mapNumber: finite(stats.data?.mapNumber),
  },
  end: {
    http: events.http,
    observed: gameEnds.length > 0,
    time: finite(gameEnds.at(-1)?.EventTime),
  },
};
// Optional action explicitly authorized for a stopped replay. No automatic
// repeated seek, no config changes, no attempt to relaunch an ended client.
if (args.length) {
  let stoppedVerified = playback.data?.paused === true;
  if (
    args[0] === "--resume-if-stopped" &&
    playback.http === 200 &&
    Number.isFinite(playback.data?.time) &&
    !stoppedVerified
  ) {
    await new Promise((resolve) => setTimeout(resolve, 5000));
    const confirmation = await request("/replay/playback");
    result.confirmation = {
      http: confirmation.http,
      time: finite(confirmation.data?.time),
      paused: typeof confirmation.data?.paused === "boolean" ? confirmation.data.paused : null,
    };
    stoppedVerified =
      confirmation.http === 200 &&
      Number.isFinite(confirmation.data?.time) &&
      Math.abs(confirmation.data.time - playback.data.time) < 0.01 &&
      confirmation.data.seeking !== true;
  }
  if (playback.http === 200 && stoppedVerified && Number.isFinite(playback.data.time)) {
    const target = Math.max(0, playback.data.time - 120);
    const action = await request("/replay/playback", "POST", {
      time: target,
      paused: false,
      speed: 1,
    });
    result.action = {
      kind: "single-rewind-and-resume",
      target,
      http: action.http,
      error: action.error ?? null,
    };
  } else result.action = { kind: "not-performed", reason: "stopped-replay-not-verified" };
}
const directory = resolve(dirname(fileURLToPath(import.meta.url)), "../evidence/validation");
await mkdir(directory, { recursive: true });
const evidence = `replay-${result.capturedAt.replaceAll(":", "-")}-${randomUUID()}.json`;
await writeFile(resolve(directory, evidence), JSON.stringify(result, null, 2), { flag: "wx" });
console.log(JSON.stringify({ ...result, evidence }));
