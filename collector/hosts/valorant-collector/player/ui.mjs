// Máy chủ UI cục bộ của bản player: phục vụ trang tĩnh trong ui/ và API JSON cho nhân runtime.
// Chỉ nghe 127.0.0.1 (không phơi ra LAN) và từ chối request có Host lạ.
//   node collector/hosts/valorant-collector/player/app.mjs
import { readFile } from "node:fs/promises";
import { createServer } from "node:http";
import { dirname, resolve } from "node:path";
import { fileURLToPath } from "node:url";
import { createPlayerAgent } from "./agent.mjs";

const uiDir = resolve(dirname(fileURLToPath(import.meta.url)), "ui");
const assets = new Map([
  ["/", ["index.html", "text/html; charset=utf-8"]],
  ["/index.html", ["index.html", "text/html; charset=utf-8"]],
  ["/app.js", ["app.js", "text/javascript; charset=utf-8"]],
  ["/style.css", ["style.css", "text/css; charset=utf-8"]],
]);

const readBody = async (req) => {
  const chunks = [];
  for await (const chunk of req) chunks.push(Buffer.from(chunk));
  try {
    return JSON.parse(Buffer.concat(chunks).toString("utf8") || "{}");
  } catch {
    return null;
  }
};

const json = (res, status, value) => {
  res.writeHead(status, { "Content-Type": "application/json; charset=utf-8", "Cache-Control": "no-store" });
  res.end(JSON.stringify(value));
};

export async function startPlayerUi({ port = Number(process.env.RIOT_OVERLAY_PLAYER_PORT || 5398), log = console.log } = {}) {
  const agent = createPlayerAgent({ log });
  const tap = await agent.startTap();
  log(`tap: ${tap}`);

  const server = createServer(async (req, res) => {
    const allowedHosts = [`127.0.0.1:${port}`, `localhost:${port}`];
    if (!allowedHosts.includes(req.headers.host ?? "")) {
      json(res, 403, { error: "Forbidden" });
      return;
    }
    const path = (req.url ?? "/").split("?")[0];

    const asset = assets.get(path);
    if (asset) {
      try {
        const body = await readFile(resolve(uiDir, asset[0]));
        res.writeHead(200, { "Content-Type": asset[1], "Cache-Control": "no-store" });
        res.end(body);
      } catch (error) {
        json(res, 500, { error: String(error?.message || error) });
      }
      return;
    }

    if (!path.startsWith("/api/")) {
      json(res, 404, { error: "Not found" });
      return;
    }
    if (req.method === "GET" && path === "/api/state") {
      json(res, 200, agent.view());
      return;
    }
    if (req.method !== "POST") {
      json(res, 405, { error: "Method not allowed" });
      return;
    }
    const body = await readBody(req);
    if (body === null) {
      json(res, 400, { error: "JSON không hợp lệ" });
      return;
    }
    switch (path) {
      case "/api/join":
        json(res, 200, await agent.join(body.code, { startClient: body.noClient !== true }));
        return;
      case "/api/cam":
        json(res, 200, body.auto === undefined ? agent.setCam(body.on) : agent.setAutoCam(body.auto));
        return;
      case "/api/riot-id":
        json(res, 200, agent.setRiotId(body.value, { manual: body.manual }));
        return;
      case "/api/leave":
        json(res, 200, await agent.leave());
        return;
      default:
        json(res, 404, { error: "Not found" });
    }
  });

  await new Promise((ok, fail) => {
    server.once("error", fail);
    server.listen(port, "127.0.0.1", ok);
  });
  const url = `http://127.0.0.1:${port}/`;
  return {
    url,
    port,
    agent,
    stop: async () => {
      agent.stopTap();
      await new Promise((ok) => server.close(ok));
    },
  };
}
