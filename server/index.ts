import { createServer } from "node:http";
import { readFile, writeFile, mkdir, rename } from "node:fs/promises";
import { resolve, extname } from "node:path";
import { WebSocketServer, WebSocket } from "ws";
import { commandSchema, themeSchema } from "../shared/schema";
import { createState, applyCommand, tick } from "../shared/mock";
const host = "127.0.0.1",
  port = Number(process.env.PORT || 4310);
let state = createState();
try {
  state.theme = themeSchema.parse(
    JSON.parse(await readFile("data/theme.json", "utf8")),
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
  if (req.url === "/api/health") {
    res.setHeader("Content-Type", "application/json");
    res.end(JSON.stringify({ ok: true, source: "mock", protocol: 1 }));
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
          ".json": "application/json",
          ".woff": "font/woff",
          ".woff2": "font/woff2",
        } as Record<string, string>
      )[extname(file)] || "application/octet-stream",
    );
    res.end(body);
  } catch {
    res.statusCode = 404;
    res.end("Not found");
  }
});
const wss = new WebSocketServer({ noServer: true, maxPayload: 65536 });
server.on("upgrade", (req, socket, head) => {
  if (req.url?.split("?")[0] !== "/ws") return;
  const origin = req.headers.origin;
  if (
    origin !== `http://${host}:${port}` &&
    origin !== `http://localhost:${port}`
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
  const readonly =
    new URL(req.url || "/", `http://${host}`).searchParams.get("role") ===
    "overlay";
  ws.on("message", (raw) => {
    try {
      if (readonly) throw Error();
      const cmd = commandSchema.parse(JSON.parse(raw.toString()));
      state = applyCommand(state, cmd);
      broadcast();
      if (cmd.type === "theme") {
        const json = JSON.stringify(state.theme, null, 2);
        saves = saves
          .then(async () => {
            await mkdir("data", { recursive: true });
            await writeFile("data/theme.tmp", json);
            await rename("data/theme.tmp", "data/theme.json");
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
server.listen(port, host, () =>
  console.log(
    `Rift Studio: http://${host}:${port}\nOBS overlay: http://${host}:${port}/overlay`,
  ),
);
