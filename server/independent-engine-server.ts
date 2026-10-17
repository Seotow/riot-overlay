import { createServer, type IncomingMessage } from "node:http";
import { WebSocket, WebSocketServer } from "ws";
import { IndependentEngine } from "./independent-engine";

export async function startIndependentEngineServer(
  options: {
    port?: number;
    engine?: IndependentEngine;
    poll?: boolean;
  } = {},
) {
  const requestedPort = options.port ?? 4313;
  if (!Number.isInteger(requestedPort) || requestedPort < 0 || requestedPort > 65535)
    throw Error("Invalid local port");
  const engine = options.engine ?? new IndependentEngine();
  let port = requestedPort;
  const authorized = (req: IncomingMessage) => {
    if (req.headers.host !== `127.0.0.1:${port}` && req.headers.host !== `localhost:${port}`)
      return false;
    if (req.headers.origin === undefined) return true; // non-browser local consumer
    try {
      const origin = new URL(req.headers.origin);
      return (
        origin.protocol === "http:" &&
        ["localhost", "127.0.0.1"].includes(origin.hostname) &&
        ["4310", "4311", String(port)].includes(origin.port) &&
        !origin.username &&
        !origin.password
      );
    } catch {
      return false;
    }
  };
  const server = createServer((req, res) => {
    res.setHeader("Cache-Control", "no-store");
    res.setHeader("X-Content-Type-Options", "nosniff");
    res.setHeader("Content-Type", "application/json");
    const send = (status: number, data: unknown) => {
      res.writeHead(status);
      res.end(JSON.stringify(data));
    };
    if (!authorized(req)) return send(403, { error: "Local consumer required" });
    if (req.method !== "GET") return send(405, { error: "Read-only endpoint" });
    if (req.url === "/health")
      return send(200, {
        engine: "rift-independent",
        serverReady: true,
        running: engine.snapshot().running,
        acquisition: "riot-local-api",
        replacementReady: false,
      });
    if (req.url === "/snapshot") return send(200, engine.snapshot());
    if (req.url === "/capabilities") return send(200, engine.snapshot().capabilities);
    return send(404, { error: "Not found" });
  });
  server.requestTimeout = 5000;
  server.headersTimeout = 5000;
  const sockets = new WebSocketServer({ noServer: true, maxPayload: 4096 });
  server.on("upgrade", (req, socket, head) => {
    if (!authorized(req) || req.url !== "/ws" || sockets.clients.size >= 16) {
      socket.end("HTTP/1.1 403 Forbidden\r\nConnection: close\r\n\r\n");
      return;
    }
    sockets.handleUpgrade(req, socket, head, (ws) => sockets.emit("connection", ws, req));
  });
  const send = (ws: WebSocket) => {
    if (ws.readyState !== WebSocket.OPEN) return;
    if (ws.bufferedAmount > 256 * 1024) {
      ws.terminate();
      return;
    }
    ws.send(JSON.stringify({ type: "independent-engine", ...engine.snapshot() }));
  };
  sockets.on("connection", (ws) => {
    ws.on("error", () => {});
    ws.on("message", () => ws.close(1008, "Receive-only"));
    send(ws);
  });
  const unsubscribe = engine.onUpdate(() => {
    for (const ws of sockets.clients) send(ws);
  });
  try {
    await new Promise<void>((resolve, reject) => {
      server.once("error", reject);
      server.listen(requestedPort, "127.0.0.1", () => {
        server.off("error", reject);
        resolve();
      });
    });
  } catch (error) {
    unsubscribe();
    sockets.close();
    throw error;
  }
  port = (server.address() as { port: number }).port;
  if (options.poll !== false) engine.start();
  let closing: Promise<void> | undefined;
  return {
    port,
    engine,
    close: () =>
      (closing ??= (async () => {
        unsubscribe();
        await engine.stop();
        for (const ws of sockets.clients) ws.terminate();
        await new Promise<void>((resolve) => sockets.close(() => resolve()));
        await new Promise<void>((resolve) => {
          server.close(() => resolve());
          server.closeAllConnections();
        });
      })()),
  };
}
