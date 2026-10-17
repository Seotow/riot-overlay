import { createWriteStream } from "node:fs";
import { mkdir, readFile, unlink, writeFile } from "node:fs/promises";
import { once } from "node:events";
import { WebSocket } from "ws";

const requestedDurationMs = Number(process.argv[2] ?? 20_000);
const durationMs = Math.max(5_000, Math.min(4 * 60 * 60 * 1000, requestedDurationMs));
const stamp = new Date().toISOString().replaceAll(":", "-").replace(".", "-");
const output = new URL(`../../data/captures/lb-${stamp}/`, import.meta.url);
await mkdir(output, { recursive: true });
const startedAt = new Date().toISOString();
const activePointer = new URL("../active-lb.json", output);
await writeFile(
  activePointer,
  JSON.stringify({ directory: `lb-${stamp}`, startedAt, requestedDurationMs: durationMs }, null, 2),
);

const secretKey = /authorization|password|secret|token|lockfile/i;
function sanitize(value) {
  if (Array.isArray(value)) return value.map(sanitize);
  if (!value || typeof value !== "object") return value;
  const result = {};
  for (const [key, child] of Object.entries(value)) {
    result[key] = secretKey.test(key) ? "[redacted]" : sanitize(child);
  }
  return result;
}

const endpoint = "ws://127.0.0.1:58869/ws/in";
const deadline = Date.now() + durationMs;
const stream = createWriteStream(new URL("leaguebroadcast-ws.ndjson", output), {
  encoding: "utf8",
});
const messageTypes = new Set();
let socket;
let retryTimer;
let connections = 0;
let disconnects = 0;
let frames = 0;
let invalidMessages = 0;
let lastError = null;
let firstFrameAt = null;
let lastFrameAt = null;
let stopping = false;

function connect() {
  if (stopping || Date.now() >= deadline) return;
  const current = new WebSocket(endpoint, { maxPayload: 4 * 1024 * 1024, handshakeTimeout: 2500 });
  socket = current;
  current.on("open", () => {
    connections += 1;
  });
  current.on("message", (raw) => {
    const text = raw.toString();
    if (text === "KeepAlive") return;
    try {
      const receivedAt = new Date().toISOString();
      const message = sanitize(JSON.parse(text));
      messageTypes.add(String(message.type ?? "unknown"));
      stream.write(JSON.stringify({ receivedAt, message }) + "\n");
      frames += 1;
      firstFrameAt ??= receivedAt;
      lastFrameAt = receivedAt;
    } catch {
      invalidMessages += 1;
    }
  });
  current.on("error", (error) => {
    lastError = String(error?.message ?? error);
  });
  current.on("close", () => {
    disconnects += 1;
    if (socket === current) socket = undefined;
    if (!stopping && Date.now() < deadline) retryTimer = setTimeout(connect, 750);
  });
}

connect();
await new Promise((resolve) => {
  const timer = setTimeout(resolve, durationMs);
  const stop = () => {
    clearTimeout(timer);
    resolve();
  };
  process.once("SIGINT", stop);
  process.once("SIGTERM", stop);
});
stopping = true;
clearTimeout(retryTimer);
socket?.terminate();
stream.end();
await once(stream, "finish");

let markers = 0;
try {
  markers = (await readFile(new URL("markers.ndjson", output), "utf8"))
    .split(/\r?\n/)
    .filter(Boolean).length;
} catch {}

const manifest = {
  version: 1,
  kind: "credential-filtered-leaguebroadcast-capture",
  endpoint,
  startedAt,
  capturedAt: new Date().toISOString(),
  requestedDurationMs: durationMs,
  durationMs: Date.now() - Date.parse(startedAt),
  connections,
  disconnects,
  frames,
  invalidMessages,
  messageTypes: [...messageTypes],
  firstFrameAt,
  lastFrameAt,
  markers,
  lastError,
  privacy:
    "Gameplay and player identity fields are preserved locally. Credential-like fields are redacted.",
};
await writeFile(new URL("manifest.json", output), JSON.stringify(manifest, null, 2));
await writeFile(
  new URL("../latest-lb.json", output),
  JSON.stringify(
    { directory: `lb-${stamp}`, capturedAt: manifest.capturedAt, kind: manifest.kind },
    null,
    2,
  ),
);
try {
  const active = JSON.parse(await readFile(activePointer, "utf8"));
  if (active.directory === `lb-${stamp}`) await unlink(activePointer);
} catch {}
console.log(JSON.stringify({ directory: output.pathname, ...manifest }, null, 2));
