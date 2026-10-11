import { observeIngame, observerRecording } from "./observer";
import { diagnose } from "./diagnostics";
import { leagueBroadcast } from "./leaguebroadcast";
import { CaptureReplay, listCaptures } from "./capture-replay";
import { createServer } from "node:http";
import { readFile, writeFile, mkdir, rename } from "node:fs/promises";
import { resolve, extname, dirname } from "node:path";
import { WebSocketServer, WebSocket } from "ws";
import { commandSchema, themeSchema } from "../shared/schema";
import { createState, applyCommand, tick } from "../shared/mock";
const host = "127.0.0.1",
  port = Number(process.env.PORT || 4310);
let state = createState();
// Isolated verification can persist a temporary theme without touching user branding.
const themePath = resolve(
  process.env.RIOT_OVERLAY_THEME_PATH || "data/theme.json",
);
const captureReplay = new CaptureReplay();
let captureLoadVersion = 0;
const selectedObservation = () =>
  state.provider === "recording"
    ? Promise.resolve(captureReplay.observe())
    : state.provider === "leaguebroadcast"
      ? Promise.resolve(leagueBroadcast.observe())
      : observeIngame();
const selectedRecording = () =>
  state.provider === "recording"
    ? captureReplay.recording()
    : state.provider === "leaguebroadcast"
      ? leagueBroadcast.recording()
      : observerRecording();
try {
  state.theme = themeSchema.parse(
    JSON.parse(await readFile(themePath, "utf8")),
  );
} catch {}
let saves = Promise.resolve();
const production = process.argv.includes("--production");
const vite = production
  ? null
  : await (
      await import("vite")
    ).createServer({ server: { middlewareMode: true, host }, appType: "spa" });
const server = createServer(async (req, res) => {
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
      ![`127.0.0.1:${port}`, `localhost:${port}`].includes(
        req.headers.host || "",
      ) ||
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
    if (
      !file.startsWith(resolve("dist") + "/") &&
      !file.startsWith(resolve("dist") + "\\")
    )
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
const wss = new WebSocketServer({ noServer: true, maxPayload: 65536 });
server.on("upgrade", (req, socket, head) => {
  if (req.url?.split("?")[0] !== "/ws") {
    socket.destroy();
    return;
  }
  const origin = req.headers.origin;
  if (
    ![`127.0.0.1:${port}`, `localhost:${port}`].includes(
      req.headers.host || "",
    ) ||
    (origin !== `http://${host}:${port}` &&
      origin !== `http://localhost:${port}`)
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
  if (lastObservation)
    ws.send(JSON.stringify({ type: "observer", frame: lastObservation }));
  const readonly =
    new URL(req.url || "/", `http://${host}`).searchParams.get("role") ===
    "overlay";
  ws.on("message", async (raw) => {
    try {
      if (readonly) throw Error();
      const cmd = commandSchema.parse(JSON.parse(raw.toString()));
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
            c.send(
              JSON.stringify({ type: "observer", frame: lastObservation }),
            );
        return;
      }
      if (cmd.type === "captureLoad") {
        const version = ++captureLoadVersion;
        const entries = await captureReplay.prepare(cmd.id);
        if (version !== captureLoadVersion || ws.readyState !== WebSocket.OPEN)
          return;
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
            c.send(
              JSON.stringify({ type: "observer", frame: lastObservation }),
            );
        return;
      }
      if (cmd.type === "provider" || cmd.type === "mockVisible")
        captureLoadVersion++;
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
      state = applyCommand(state, cmd);
      if (
        cmd.type === "provider" ||
        cmd.type === "mockVisible" ||
        cmd.type === "reset"
      )
        state.rehearsal = undefined;
      if (state.provider !== "leaguebroadcast" || state.mockVisible)
        leagueBroadcast.disconnect();
      if (cmd.type === "provider") {
        lastObservation = null;
        for (const c of wss.clients)
          if (c.readyState === WebSocket.OPEN)
            c.send(JSON.stringify({ type: "observer", frame: null }));
      }
      broadcast();
      if (cmd.type === "theme") {
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
setInterval(() => {
  if (state.playing) {
    state = tick(state);
    broadcast();
  }
}, 1000);
async function pollObservation() {
  try {
    if (
      wss.clients.size > 0 &&
      state.provider === "leaguebroadcast" &&
      !state.mockVisible
    )
      leagueBroadcast.ensureConnected();
    if (!state.mockVisible && wss.clients.size > 0) {
      const providerAtStart = state.provider;
      const next = await selectedObservation();
      if (providerAtStart !== state.provider || state.mockVisible) return;
      lastObservation = next;
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
    setTimeout(pollObservation, 750);
  }
}
void pollObservation();
server.listen(port, host, () =>
  console.log(
    `Rift Studio: http://${host}:${port}\nOBS overlay: http://${host}:${port}/overlay`,
  ),
);
