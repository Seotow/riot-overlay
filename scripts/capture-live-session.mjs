import { createHash } from "node:crypto";
import { mkdir, writeFile } from "node:fs/promises";
import https from "node:https";
import { WebSocket } from "ws";

const durationMs = Math.max(5_000, Math.min(120_000, Number(process.argv[2] ?? 20_000)));
const stamp = new Date().toISOString().replaceAll(":", "-").replace(".", "-");
const output = new URL(`../data/captures/${stamp}/`, import.meta.url);
await mkdir(output, { recursive: true });

const secretKey = /authorization|password|secret|token|lockfile/i;
function sanitize(value) {
  if (Array.isArray(value)) return value.map(sanitize);
  if (!value || typeof value !== "object") return value;
  const out = {};
  for (const [key, child] of Object.entries(value)) {
    if (secretKey.test(key)) { out[key] = "[redacted]"; continue; }
    out[key] = sanitize(child);
  }
  return out;
}
const save = async (name, value) => writeFile(new URL(name, output), JSON.stringify(sanitize(value), null, 2));

function riotGet(path) {
  return new Promise((resolve, reject) => {
    const req = https.get({ hostname: "127.0.0.1", port: 2999, path, rejectUnauthorized: false, timeout: 4000 }, res => {
      const chunks = [];
      let size = 0;
      res.on("data", chunk => { size += chunk.length; if (size <= 16 * 1024 * 1024) chunks.push(chunk); else req.destroy(Error("response too large")); });
      res.on("end", () => {
        const text = Buffer.concat(chunks).toString("utf8");
        if ((res.statusCode ?? 500) >= 400) return reject(Error(`HTTP ${res.statusCode}`));
        try { resolve(JSON.parse(text)); } catch { reject(Error("invalid JSON")); }
      });
    });
    req.on("timeout", () => req.destroy(Error("timeout")));
    req.on("error", reject);
  });
}
async function httpGet(base, path) {
  const response = await fetch(base + path, { signal: AbortSignal.timeout(4000) });
  if (!response.ok) throw Error(`HTTP ${response.status}`);
  return response.json();
}
async function collectGroup(prefix, entries, reader) {
  const report = [];
  for (const [name, path] of entries) {
    try {
      const data = await reader(path);
      await save(`${prefix}-${name}.json`, data);
      report.push({ name, path, status: "saved" });
    } catch (error) {
      report.push({ name, path, status: "unavailable", error: String(error?.message ?? error) });
    }
  }
  return report;
}

const riot = await collectGroup("riot", [
  ["allgamedata", "/liveclientdata/allgamedata"],
  ["playerlist", "/liveclientdata/playerlist"],
  ["eventdata", "/liveclientdata/eventdata"],
  ["gamestats", "/liveclientdata/gamestats"],
  ["replay-game", "/replay/game"],
  ["replay-playback", "/replay/playback"],
  ["swagger-v3", "/swagger/v3/openapi.json"],
], riotGet);

const leagueBroadcast = await collectGroup("leaguebroadcast", [
  ["ingame-status", "/api/ingame/status"],
  ["diagnostics-health", "/api/diagnostics/health"],
  ["asset-job", "/api/settings/patches/job"],
  ["match-current-game", "/api/match/current/game"],
  ["game-current", "/api/game/current"],
  ["swagger", "/swagger/v1/swagger.json"],
], path => httpGet("http://127.0.0.1:58869", path));

const overlay = await collectGroup("overlay", [
  ["providers", "/api/providers"],
  ["observer", "/api/observer"],
  ["recording", "/api/observer/recording"],
  ["diagnostics", "/api/diagnostics"],
], path => httpGet("http://127.0.0.1:4310", path));

const frames = [];
const messageTypes = new Set();
await new Promise((resolve, reject) => {
  const socket = new WebSocket("ws://127.0.0.1:58869/ws/in", { maxPayload: 4 * 1024 * 1024, handshakeTimeout: 4000 });
  const timer = setTimeout(() => { socket.close(); resolve(); }, durationMs);
  socket.on("message", raw => {
    if (raw.toString() === "KeepAlive") return;
    try {
      const message = sanitize(JSON.parse(raw.toString()));
      messageTypes.add(String(message.type ?? "unknown"));
      frames.push({ receivedAt: new Date().toISOString(), message });
    } catch {}
  });
  socket.on("error", error => { clearTimeout(timer); reject(error); });
  socket.on("close", () => { clearTimeout(timer); resolve(); });
});
await writeFile(new URL("leaguebroadcast-ws.ndjson", output), frames.map(frame => JSON.stringify(frame)).join("\n") + "\n");

const manifest = {
  version: 1,
  kind: "credential-filtered-live-session-capture",
  capturedAt: new Date().toISOString(),
  durationMs,
  sources: { riot, leagueBroadcast, overlay },
  websocket: { endpoint: "ws://127.0.0.1:58869/ws/in", frames: frames.length, messageTypes: [...messageTypes] },
  privacy: "Gameplay, player identity and asset fields are preserved locally. Credentials, tokens, passwords and lockfile values are redacted.",
};
await writeFile(new URL("manifest.json", output), JSON.stringify(manifest, null, 2));
await writeFile(
  new URL("../latest.json", output),
  JSON.stringify({ directory: stamp, capturedAt: manifest.capturedAt, kind: manifest.kind }, null, 2),
);
console.log(JSON.stringify({ directory: output.pathname, ...manifest.websocket, capturedAt: manifest.capturedAt }));
