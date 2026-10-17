import { observeIngame, observerRecording } from "./observer";
import { diagnose } from "./diagnostics";
import { leagueBroadcast } from "./leaguebroadcast";
import { DraftLcu } from "./draft-lcu";
import { EogLcu } from "./eog-lcu";
import { ReplayWatcher } from "./replays";
import { MatchLedger } from "./match-ledger";
import { emptyDraft } from "../shared/draft";
import { LeagueCollectorSource } from "../collector/adapter";
import { CollectorRuntime } from "../collector/supervisor/supervisor";
import { CaptureReplay, listCaptures } from "./capture-replay";
import { createServer } from "node:http";
import { readFile, writeFile, mkdir, rename } from "node:fs/promises";
import { resolve, extname, dirname } from "node:path";
import { WebSocketServer, WebSocket } from "ws";
import { commandSchema, themeSchema } from "../shared/schema";
import { createState, applyCommand, tick } from "../shared/mock";
import type { State } from "../shared/schema";
import { RiotPostgameService, riotError } from "./riot-postgame";
import { ReplayHudService } from "./replay-hud";
import { COLLECTOR_SAMPLE_INTERVAL_MS, remainingSampleDelay } from "../shared/capture-rules";
const host = "127.0.0.1",
  port = Number(process.env.PORT || 4310);
// Postgame is locked while its data source is undecided; the code stays for development.
const postgameLocked = process.env.RIOT_OVERLAY_POSTGAME === "0";
let state: State = { ...createState(), postgameLocked };
const collectorPort = Number(process.env.RIOT_OVERLAY_COLLECTOR_PORT ?? 18799);
const localCollector = new LeagueCollectorSource({ port: collectorPort });
const accountlessCollector = new LeagueCollectorSource({ port: collectorPort });
const collectorRuntime = new CollectorRuntime({
  port: collectorPort,
  external: process.env.RIOT_OVERLAY_COLLECTOR_EXTERNAL === "1",
});
const accountlessRuntime = new CollectorRuntime({
  port: collectorPort,
  withoutAccount: true,
  external: process.env.RIOT_OVERLAY_COLLECTOR_EXTERNAL === "1",
});
const usesCollector = () =>
  state.provider === "league-collector" || state.provider === "collector-accountless";
const selectedCollectorRuntime = () =>
  state.provider === "collector-accountless" ? accountlessRuntime : collectorRuntime;
const selectedCollectorSource = () =>
  state.provider === "collector-accountless" ? accountlessCollector : localCollector;
// Isolated runs (tests) can pick another starting source without launching a collector host.
const startProvider = process.env.RIOT_OVERLAY_PROVIDER;
if (startProvider === "riot" || startProvider === "recording") state.provider = startProvider;
if (process.argv.includes("--collector")) state.provider = "league-collector";
if (process.argv.includes("--collector-accountless")) state.provider = "collector-accountless";
const riotPostgame = new RiotPostgameService();
const replayHud = new ReplayHudService();
// Isolated verification can persist a temporary theme without touching user branding.
const themePath = resolve(process.env.RIOT_OVERLAY_THEME_PATH || "data/theme.json");
const captureReplay = new CaptureReplay();
let shuttingDown = false;
let captureLoadVersion = 0;
async function selectedObservation(broadcast = false) {
  return state.provider === "recording"
    ? Promise.resolve(captureReplay.observe())
    : state.provider === "leaguebroadcast"
      ? Promise.resolve(leagueBroadcast.observe())
      : usesCollector()
        ? Promise.resolve(
            broadcast
              ? selectedCollectorSource().broadcastFrame()
              : selectedCollectorSource().observe(),
          )
        : observeIngame();
}
const selectedRecording = () =>
  state.provider === "recording"
    ? captureReplay.recording()
    : state.provider === "leaguebroadcast"
      ? leagueBroadcast.recording()
      : usesCollector()
        ? selectedCollectorSource().recording()
        : observerRecording();
try {
  state.theme = themeSchema.parse(JSON.parse(await readFile(themePath, "utf8")));
} catch {}
let saves = Promise.resolve();
const production = process.argv.includes("--production");
const vite = production
  ? null
  : await (
      await import("vite")
    ).createServer({ server: { middlewareMode: true, host }, appType: "spa" });
const server = createServer(async (req, res) => {
  if (req.url?.startsWith("/api/replay-hud")) {
    res.setHeader("Content-Type", "application/json");
    res.setHeader("Cache-Control", "no-store");
    const allowed = [`http://${host}:${port}`, `http://localhost:${port}`];
    if (
      ![`127.0.0.1:${port}`, `localhost:${port}`].includes(req.headers.host || "") ||
      (req.headers.origin && !allowed.includes(req.headers.origin)) ||
      req.headers["sec-fetch-site"] === "cross-site" ||
      (req.method !== "GET" && !allowed.includes(req.headers.origin || ""))
    ) {
      res.writeHead(403);
      res.end(JSON.stringify({ error: "Forbidden" }));
      return;
    }
    try {
      if (req.url === "/api/replay-hud/status" && req.method === "GET")
        res.end(JSON.stringify(await replayHud.status()));
      else if (req.url === "/api/replay-hud/apply" && req.method === "POST") {
        let body = "";
        for await (const chunk of req) {
          body += chunk.toString();
          if (Buffer.byteLength(body) > 8192) throw Error("Cấu hình quá lớn.");
        }
        res.end(JSON.stringify(await replayHud.apply(JSON.parse(body))));
      } else {
        res.writeHead(405);
        res.end(JSON.stringify({ error: "Method/route not allowed" }));
      }
    } catch (e) {
      res.writeHead(400);
      res.end(
        JSON.stringify({
          error: e instanceof Error ? e.message : "Không áp dụng được HUD.",
        }),
      );
    }
    return;
  }
  if (req.url?.startsWith("/api/riot-postgame")) {
    res.setHeader("Content-Type", "application/json");
    res.setHeader("Cache-Control", "no-store");
    res.setHeader("X-Content-Type-Options", "nosniff");
    const allowed = [`http://${host}:${port}`, `http://localhost:${port}`];
    if (
      ![`127.0.0.1:${port}`, `localhost:${port}`].includes(req.headers.host || "") ||
      (req.headers.origin && !allowed.includes(req.headers.origin)) ||
      req.headers["sec-fetch-site"] === "cross-site" ||
      (req.method !== "GET" && !allowed.includes(req.headers.origin || ""))
    ) {
      res.writeHead(403);
      res.end('{"error":"forbidden"}');
      return;
    }
    const routes = [
      "/api/riot-postgame/status",
      "/api/riot-postgame/credential",
      "/api/riot-postgame/load",
      "/api/riot-postgame/publish",
      "/api/riot-postgame/import-eog",
      "/api/riot-postgame/eog-files",
      "/api/riot-postgame/rofl-files",
      "/api/riot-postgame/import-rofl",
    ];
    if (!routes.includes(req.url)) {
      res.writeHead(404);
      res.end("{}");
      return;
    }
    // Locked: only the read-only status (with the lock flag) answers.
    if (postgameLocked && req.url !== routes[0]) {
      res.writeHead(423);
      res.end('{"error":"postgame-locked"}');
      return;
    }
    if (req.url === routes[6]) {
      if (req.method !== "GET") {
        res.writeHead(405, { Allow: "GET" });
        res.end("{}");
        return;
      }
      res.end(JSON.stringify({ files: await replays.files(), replay: replays.snapshot() }));
      return;
    }
    if (req.url === routes[5]) {
      if (req.method !== "GET") {
        res.writeHead(405, { Allow: "GET" });
        res.end("{}");
        return;
      }
      res.end(JSON.stringify({ files: await riotPostgame.listEogFiles() }));
      return;
    }
    if (req.url === routes[0]) {
      if (req.method !== "GET") {
        res.writeHead(405, { Allow: "GET" });
        res.end("{}");
        return;
      }
      res.end(JSON.stringify({ ...riotPostgame.status(), locked: postgameLocked }));
      return;
    }
    if (req.method !== "POST") {
      res.writeHead(405, { Allow: "POST" });
      res.end("{}");
      return;
    }
    if (req.headers["content-type"]?.split(";")[0] !== "application/json") {
      res.writeHead(415);
      res.end('{"error":"json-required"}');
      return;
    }
    try {
      const chunks: Buffer[] = [];
      let size = 0;
      for await (const chunk of req) {
        size += chunk.length;
        // The EOG block is a few hundred KB at most; every other body is tiny.
        if (size > (req.url === routes[4] ? 1_048_576 : 16384)) {
          res.writeHead(413);
          res.end('{"error":"body-too-large"}');
          return;
        }
        chunks.push(Buffer.from(chunk));
      }
      const input = JSON.parse(Buffer.concat(chunks).toString("utf8"));
      if (req.url === routes[1]) {
        if (input?.clear === true && Object.keys(input).length === 1) {
          riotPostgame.clear();
          res.end(JSON.stringify(riotPostgame.status()));
        } else res.end(JSON.stringify(riotPostgame.configure(input)));
      } else if (req.url === routes[7])
        res.end(
          JSON.stringify(
            await riotPostgame.importRofl(
              input,
              async (name) => {
                const file = (await replays.files()).find((f) => f.name === name);
                return file ? resolve(file.dir, file.name) : null;
              },
              ledger.snapshot(),
            ),
          ),
        );
      else if (req.url === routes[4]) res.end(JSON.stringify(await riotPostgame.importEog(input)));
      else if (req.url === routes[2]) res.end(JSON.stringify(await riotPostgame.load(input)));
      else {
        if (!input || typeof input.matchId !== "string" || Object.keys(input).length !== 1)
          throw Error();
        const candidate = riotPostgame.publishedCandidate(input.matchId);
        state = {
          ...state,
          postgame: candidate,
          mockVisible: false,
          rehearsal: undefined,
          scene: "postgame",
          revision: state.revision + 1,
        };
        broadcast();
        res.end(
          JSON.stringify({
            published: true,
            matchId: candidate.evidence.matchId,
            revision: state.revision,
          }),
        );
      }
    } catch (e) {
      const safe = riotError(e);
      res.writeHead(safe.status >= 400 && safe.status <= 599 ? safe.status : 502);
      res.end(JSON.stringify({ error: safe.code, retryAfter: safe.retryAfter }));
    }
    return;
  }
  if (
    [
      "/api/diagnostics",
      "/api/observer",
      "/api/observer/recording",
      "/api/providers",
      "/api/captures",
      "/api/rehearsal",
    ].includes(req.url || "")
  ) {
    res.setHeader("Content-Type", "application/json");
    res.setHeader("Cache-Control", "no-store");
    const allowed = [`http://${host}:${port}`, `http://localhost:${port}`];
    if (
      ![`127.0.0.1:${port}`, `localhost:${port}`].includes(req.headers.host || "") ||
      (req.headers.origin && !allowed.includes(req.headers.origin)) ||
      req.headers["sec-fetch-site"] === "cross-site"
    ) {
      res.writeHead(403);
      res.end('{"error":"Forbidden"}');
      return;
    }
    if (req.method !== "GET") {
      res.writeHead(405, { Allow: "GET" });
      res.end("{}");
      return;
    }
    try {
      res.end(
        JSON.stringify(
          req.url === "/api/rehearsal"
            ? captureReplay.capabilities()
            : req.url === "/api/captures"
              ? await listCaptures()
              : req.url === "/api/providers"
                ? {
                    capturedAt: new Date().toISOString(),
                    selected: state.provider,
                    output: state.mockVisible ? "demo" : state.provider,
                    leaguebroadcast: leagueBroadcast.snapshot(),
                    collector: {
                      observerIntervalMs: COLLECTOR_SAMPLE_INTERVAL_MS,
                      ...selectedCollectorSource().snapshot(),
                      runtime: selectedCollectorRuntime().snapshot(),
                    },
                    recording: captureReplay.snapshot(),
                  }
                : req.url === "/api/observer"
                  ? await selectedObservation()
                  : req.url === "/api/observer/recording"
                    ? selectedRecording()
                    : await diagnose(),
        ),
      );
    } catch {
      res.writeHead(503);
      res.end('{"error":"Diagnostic unavailable"}');
    }
    return;
  }
  if (req.url === "/api/health") {
    res.setHeader("Content-Type", "application/json");
    res.end(
      JSON.stringify({
        ok: true,
        source: state.mockVisible ? "demo" : state.provider,
        protocol: 1,
      }),
    );
    return;
  }
  if (vite) {
    vite.middlewares(req, res);
    return;
  }
  try {
    const path = decodeURIComponent((req.url || "/").split("?")[0]);
    const file =
      path === "/" || path === "/overlay"
        ? resolve("dist/index.html")
        : resolve("dist", "." + path);
    if (!file.startsWith(resolve("dist") + "/") && !file.startsWith(resolve("dist") + "\\"))
      throw Error();
    const body = await readFile(file);
    res.setHeader(
      "Content-Type",
      (
        {
          ".html": "text/html",
          ".js": "text/javascript",
          ".css": "text/css",
          ".svg": "image/svg+xml",
          ".png": "image/png",
          ".jpg": "image/jpeg",
          ".jpeg": "image/jpeg",
          ".webp": "image/webp",
          ".json": "application/json",
          ".woff": "font/woff",
          ".woff2": "font/woff2",
          ".otf": "font/otf",
          ".ttf": "font/ttf",
        } as Record<string, string>
      )[extname(file)] || "application/octet-stream",
    );
    res.end(body);
  } catch {
    res.statusCode = 404;
    res.end("Not found");
  }
});
let lastObservation: Awaited<ReturnType<typeof observeIngame>> | null = null;
// Two optional raster logos (350KB each) plus the bounded configuration.
const wss = new WebSocketServer({ noServer: true, maxPayload: 1400000 });
server.on("upgrade", (req, socket, head) => {
  if (req.url?.split("?")[0] !== "/ws") {
    socket.destroy();
    return;
  }
  const origin = req.headers.origin;
  if (
    ![`127.0.0.1:${port}`, `localhost:${port}`].includes(req.headers.host || "") ||
    (origin !== `http://${host}:${port}` && origin !== `http://localhost:${port}`)
  ) {
    socket.destroy();
    return;
  }
  wss.handleUpgrade(req, socket, head, (ws) => wss.emit("connection", ws, req));
});
function broadcast() {
  const message = JSON.stringify({ type: "snapshot", state });
  wss.clients.forEach((c) => {
    if (c.readyState === WebSocket.OPEN) c.send(message);
  });
}
wss.on("connection", (ws, req) => {
  ws.send(JSON.stringify({ type: "snapshot", state }));
  if (lastObservation) ws.send(JSON.stringify({ type: "observer", frame: lastObservation }));
  const readonly = new URL(req.url || "/", `http://${host}`).searchParams.get("role") === "overlay";
  ws.on("message", async (raw) => {
    try {
      if (readonly) throw Error();
      const cmd = commandSchema.parse(JSON.parse(raw.toString()));
      if (
        postgameLocked &&
        ((cmd.type === "scene" && cmd.value === "postgame") ||
          (cmd.type === "postgameState" && cmd.value !== null))
      )
        throw Error("postgame-locked");
      if (cmd.type === "rehearsal") {
        if (state.provider !== "recording" || state.mockVisible) throw Error();
        const rehearsal = captureReplay.rehearse(cmd.value, cmd.variant);
        state = {
          ...state,
          scene: "ingame",
          rehearsal: cmd.value === "clear" ? undefined : rehearsal,
          revision: state.revision + 1,
        };
        lastObservation = captureReplay.observe();
        broadcast();
        for (const c of wss.clients)
          if (c.readyState === WebSocket.OPEN)
            c.send(JSON.stringify({ type: "observer", frame: lastObservation }));
        return;
      }
      if (cmd.type === "captureLoad") {
        const version = ++captureLoadVersion;
        const entries = await captureReplay.prepare(cmd.id);
        if (version !== captureLoadVersion || ws.readyState !== WebSocket.OPEN) return;
        captureReplay.loadEntries(cmd.id, entries);
        state = {
          ...state,
          revision: state.revision + 1,
          provider: "recording",
          mockVisible: false,
          playing: false,
          rehearsal: undefined,
        };
        leagueBroadcast.disconnect();
        lastObservation = captureReplay.observe();
        broadcast();
        for (const c of wss.clients)
          if (c.readyState === WebSocket.OPEN)
            c.send(JSON.stringify({ type: "observer", frame: lastObservation }));
        return;
      }
      if (cmd.type === "provider" || cmd.type === "mockVisible") captureLoadVersion++;
      if (cmd.type === "captureControl") {
        if (state.provider !== "recording") throw Error();
        captureReplay.control(cmd);
        if (
          cmd.positionMs !== undefined ||
          state.rehearsal?.kind === "baron" ||
          state.rehearsal?.variant
        )
          state = { ...state, rehearsal: undefined };
      }
      state = { ...applyCommand(state, cmd), postgameLocked };
      if (cmd.type === "provider" || cmd.type === "mockVisible" || cmd.type === "reset")
        state.rehearsal = undefined;
      if (state.provider !== "leaguebroadcast" || state.mockVisible) leagueBroadcast.disconnect();
      if (!usesCollector() || state.mockVisible || cmd.type === "provider") {
        localCollector.disconnect();
        accountlessCollector.disconnect();
        void collectorRuntime.setEnabled(false);
        void accountlessRuntime.setEnabled(false);
      }
      if (cmd.type === "provider") {
        lastObservation = null;
        for (const c of wss.clients)
          if (c.readyState === WebSocket.OPEN)
            c.send(JSON.stringify({ type: "observer", frame: null }));
      }
      broadcast();
      if (cmd.type === "theme" || cmd.type === "ingameGraphic" || cmd.type === "swapSides") {
        const json = JSON.stringify(state.theme, null, 2);
        saves = saves
          .then(async () => {
            await mkdir(dirname(themePath), { recursive: true });
            await writeFile(`${themePath}.tmp`, json);
            await rename(`${themePath}.tmp`, themePath);
          })
          .catch(() => {
            ws.send(
              JSON.stringify({
                type: "error",
                message: "Không lưu được theme vào ổ đĩa.",
              }),
            );
          });
      }
    } catch {
      ws.send(
        JSON.stringify({
          type: "error",
          message: "Lệnh hoặc theme không hợp lệ.",
        }),
      );
    }
  });
});
// Champ select comes only from the LCU; the poll never writes team configuration.
const draftLcu = new DraftLcu();
let lcuBusy = false;
setInterval(async () => {
  if (lcuBusy || shuttingDown || wss.clients.size === 0) return;
  lcuBusy = true;
  try {
    const { draft, changed } = await draftLcu.poll(state.draft ?? emptyDraft());
    const status = draftLcu.snapshot();
    const draftChanged = !!draft && JSON.stringify(draft) !== JSON.stringify(state.draft);
    if (draftChanged || changed) {
      state = {
        ...state,
        revision: state.revision + 1,
        draftLcu: status,
        ...(draftChanged ? { draft: draft! } : {}),
      };
      broadcast();
    }
  } finally {
    lcuBusy = false;
  }
}, 600);
// A participant's client has the end-of-game block as soon as the match ends: stage it for review.
// What the collector sees during the match; fills gold over time and dragons of the replay postgame.
const ledger = new MatchLedger();
void ledger.load();
const replays = new ReplayWatcher();
let replayBusy = false;
setInterval(async () => {
  if (postgameLocked || replayBusy || shuttingDown || wss.clients.size === 0) return;
  replayBusy = true;
  try {
    await replays.afterMatch();
    for (const file of await replays.fresh())
      await riotPostgame.stageReplayFile(resolve(file.dir, file.name), ledger.snapshot());
  } finally {
    replayBusy = false;
  }
}, 5000);
const eogLcu = new EogLcu();
let eogBusy = false;
setInterval(async () => {
  if (postgameLocked || eogBusy || shuttingDown || wss.clients.size === 0) return;
  eogBusy = true;
  try {
    const block = await eogLcu.read();
    if (block) {
      const gameId = Number((block as { gameId?: unknown }).gameId);
      // History can lag a little behind the end-of-game block; try again on later polls.
      riotPostgame.stageLiveEog(
        block,
        riotPostgame.needsLiveHistory(gameId) ? await eogLcu.readHistory(gameId) : null,
      );
    }
  } finally {
    eogBusy = false;
  }
}, 4000);
setInterval(() => {
  if (state.playing) {
    state = tick(state);
    broadcast();
  }
}, 1000);
async function pollObservation() {
  if (shuttingDown) return;
  const pollStarted = performance.now();
  try {
    if (usesCollector() && !state.mockVisible) {
      const provider = state.provider;
      const runtime = selectedCollectorRuntime();
      await (runtime === collectorRuntime ? accountlessRuntime : collectorRuntime).stop();
      if (provider !== state.provider || state.mockVisible || shuttingDown) return;
      await runtime.setEnabled(true);
      if (provider !== state.provider || state.mockVisible || shuttingDown) return;
      if (["running", "external"].includes(runtime.snapshot().status))
        selectedCollectorSource().ensureConnected();
    }
    if (wss.clients.size > 0 && state.provider === "leaguebroadcast" && !state.mockVisible)
      leagueBroadcast.ensureConnected();
    if (!state.mockVisible && wss.clients.size > 0) {
      const providerAtStart = state.provider;
      const next = await selectedObservation(true);
      if (providerAtStart !== state.provider || state.mockVisible) return;
      lastObservation = next;
      if (state.provider !== "recording") {
        ledger.observe(next, replays.snapshot().gameId);
        void ledger.persist();
      }
      const message = JSON.stringify({
        type: "observer",
        frame: lastObservation,
      });
      for (const client of wss.clients)
        if (client.readyState === WebSocket.OPEN) client.send(message);
    }
  } catch {
    lastObservation = null;
    for (const client of wss.clients)
      if (client.readyState === WebSocket.OPEN)
        client.send(JSON.stringify({ type: "observer", frame: null }));
  } finally {
    if (!shuttingDown) {
      const interval = usesCollector() ? COLLECTOR_SAMPLE_INTERVAL_MS : 750;
      setTimeout(pollObservation, remainingSampleDelay(performance.now() - pollStarted, interval));
    }
  }
}
void pollObservation();
server.listen(port, host, () =>
  console.log(`Rift Studio: http://${host}:${port}\nOBS overlay: http://${host}:${port}/overlay`),
);
async function shutdown() {
  if (shuttingDown) return;
  shuttingDown = true;
  localCollector.stop();
  accountlessCollector.stop();
  leagueBroadcast.stop();
  for (const client of wss.clients) client.terminate();
  await collectorRuntime.stop();
  await accountlessRuntime.stop();
  server.close(() => process.exit(0));
  const deadline = setTimeout(() => process.exit(0), 3000);
  deadline.unref();
}
process.on("SIGINT", () => void shutdown());
process.on("SIGTERM", () => void shutdown());
