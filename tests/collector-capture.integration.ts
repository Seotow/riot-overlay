import assert from "node:assert/strict";
import { createServer } from "node:http";
import { WebSocketServer, WebSocket } from "ws";
import { once } from "node:events";
import { spawn } from "node:child_process";
import { mkdtemp, readFile, rm, readdir } from "node:fs/promises";
import { join } from "node:path";
import { tmpdir } from "node:os";
import { gunzipSync } from "node:zlib";
import { normalizeCollector } from "../collector/adapter/normalize";
import { ObserverSession } from "../server/observer-session";
import { parseCapture } from "../server/capture-replay";
const root = await mkdtemp(join(tmpdir(), "collector-capture-"));
let sequence = 0;
const raw = () => ({
  schemaVersion: 1,
  type: "snapshot",
  source: "lblib",
  synthetic: false,
  recordedAt: null,
  sequence: ++sequence,
  timestamp: new Date().toISOString(),
  password: "AUTH_SENTINEL",
  data: {
    gameId: "OriginalGame",
    gameTime: 100 + sequence / 10,
    heroes: Array.from({ length: 10 }, (_, i) => ({
      heroIndex: i,
      info: {
        team: i < 5 ? 1 : 2,
        name: "GameplayNamePreserved",
        networkId: 9000 + i,
      },
      common: { identifier: "Yasuo", level: 10, health: 500, maxHealth: 1000 },
      gold: 100,
      totalGold: 1000,
      kills: 0,
      deaths: 0,
      assists: 0,
    })),
  },
});
const session = new ObserverSession();
const sample = () => normalizeCollector(raw(), Date.now())!.sample;
const frame = () => session.ingest(sample(), "fixture", new Date().toISOString());
const native = createServer((req, res) => {
  res.setHeader("Content-Type", "application/json");
  res.end(
    JSON.stringify({
      authentication: {
        state: "not-configured",
        features: [],
        signedResponses: 0,
      },
    }),
  );
});
native.listen(0, "127.0.0.1");
await once(native, "listening");
const nativePort = (native.address() as any).port;
const app = createServer((req, res) => {
  res.setHeader("Content-Type", "application/json");
  res.end(
    JSON.stringify(
      req.url === "/api/providers"
        ? {
            selected: "collector-accountless",
            output: "collector-accountless",
            collector: {
              observerIntervalMs: 500,
              runtime: {
                status: "running",
                owned: true,
                withoutAccount: true,
                credentialConfigured: false,
                port: nativePort,
              },
            },
          }
        : frame(),
    ),
  );
});
app.listen(0, "127.0.0.1");
await once(app, "listening");
const appPort = (app.address() as any).port;
const nw = new WebSocketServer({ server: native }),
  aw = new WebSocketServer({ server: app });
nw.on("connection", (ws, req) => {
  assert.equal(req.headers.origin, undefined);
  ws.send(JSON.stringify(raw()));
});
aw.on("connection", (ws) => ws.send(JSON.stringify({ type: "observer", frame: frame() })));
const ticker = setInterval(() => {
  for (const s of nw.clients) if (s.readyState === WebSocket.OPEN) s.send(JSON.stringify(raw()));
  for (const s of aw.clients)
    if (s.readyState === WebSocket.OPEN)
      s.send(JSON.stringify({ type: "observer", frame: frame() }));
}, 100);
const env = {
  ...process.env,
  RIOT_OVERLAY_CAPTURE_ROOT: root,
  RIOT_OVERLAY_CAPTURE_PORT: String(appPort),
};
const child = spawn(
  process.execPath,
  [
    "--import",
    "tsx",
    "--import",
    "./tests/fixtures/collector-capture-preload.ts",
    "collector/scripts/capture-match.ts",
    "15000",
  ],
  { env, windowsHide: true, stdio: ["ignore", "pipe", "pipe"] },
);
let output = "";
child.stdout.on("data", (b) => (output += b));
child.stderr.on("data", (b) => (output += b));
const command = async (args: string[]) => {
  const c = spawn(
    process.execPath,
    ["--import", "tsx", "collector/scripts/capture-match.ts", ...args],
    { env, windowsHide: true, stdio: "ignore" },
  );
  const [code] = await once(c, "exit");
  assert.equal(code, 0);
};
try {
  for (let i = 0; i < 100 && !output.includes('"recording":true'); i++)
    await new Promise((r) => setTimeout(r, 100));
  assert.ok(output.includes('"recording":true'), output);
  await command(["--mark", "dragon test"]);
  await command(["--stop"]);
  if (child.exitCode === null) await once(child, "exit");
  assert.equal(child.exitCode, 0, output);
  const id = (await readdir(root)).find((s) => /^\d{4}-/.test(s))!;
  assert.ok(id);
  const dir = join(root, id),
    manifest = JSON.parse(await readFile(join(dir, "manifest.json"), "utf8"));
  assert.equal(manifest.stopReason, "operator");
  assert.ok(
    manifest.nativeFrames > 0 && manifest.observerFrames > 0 && manifest.referenceFrames > 0,
    JSON.stringify(manifest),
  );
  assert.equal(manifest.invalidMessages, 0);
  assert.equal(manifest.observerTargetIntervalMs, 500);
  assert.equal(manifest.referenceTargetIntervalMs, 500);
  assert.ok(Number.isFinite(manifest.observerMaxGapMs));
  const full = gunzipSync(await readFile(join(dir, "collector-native.ndjson.gz"))).toString();
  assert.ok(full.includes("GameplayNamePreserved"));
  assert.ok(full.includes("OriginalGame"));
  assert.ok(full.includes("9000"));
  assert.ok(!full.includes("AUTH_SENTINEL"));
  const reference = gunzipSync(await readFile(join(dir, "riot-reference.ndjson.gz"))).toString();
  assert.ok(reference.includes("GameplayNamePreserved"));
  assert.ok(!reference.includes("AUTH_SENTINEL"));
  assert.ok(parseCapture(await readFile(join(dir, "observer-samples.ndjson"), "utf8")).length > 0);
  assert.match(await readFile(join(dir, "markers.ndjson"), "utf8"), /dragon test/);
  assert.ok(!(await readdir(root)).includes("active-collector.json"));
  console.log(
    "PASS: fixture native/full Riot + app archive, credentials filtered/gameplay preserved, gzip flush, marker, operator stop and playback",
  );
} finally {
  if (child.exitCode === null) {
    child.kill();
    await once(child, "exit");
  }
  clearInterval(ticker);
  for (const w of [nw, aw]) {
    for (const s of w.clients) s.terminate();
    await new Promise<void>((r) => w.close(() => r()));
  }
  await new Promise<void>((r) => native.close(() => r()));
  await new Promise<void>((r) => app.close(() => r()));
  await rm(root, { recursive: true, force: true });
}
