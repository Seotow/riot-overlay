import { request as httpsRequest } from "node:https";
import { request as httpRequest } from "node:http";
import { createConnection } from "node:net";
import { mkdir, writeFile } from "node:fs/promises";
import { resolve } from "node:path";
import { validateProject } from "../validation/project";

// Attach/read only. Start the project with npm run start:collector separately.
// No auth, credential read, launch/injection, LCU, playback mutation or UI command.
const args = process.argv.slice(2);
let port = 4310,
  seconds = 30;
for (let i = 0; i < args.length; i++) {
  if (args[i] === "--port") port = Number(args[++i]);
  else if (args[i] === "--seconds") seconds = Number(args[++i]);
  else throw Error("Use --port <1024..65535> --seconds <5..120>");
}
if (
  !Number.isInteger(port) ||
  port < 1024 ||
  port > 65535 ||
  !Number.isInteger(seconds) ||
  seconds < 5 ||
  seconds > 120
)
  throw Error("Invalid validation options");
const wait = (ms: number) => new Promise((r) => setTimeout(r, ms));
async function get(game: boolean, path: string): Promise<{ http: number | null; data: unknown }> {
  return new Promise((yes) => {
    let finished = false;
    const finish = (http: number | null, data: unknown = null) => {
      if (finished) return;
      finished = true;
      clearTimeout(timer);
      yes({ http, data });
    };
    const send = game ? httpsRequest : httpRequest;
    const req = send(
      {
        hostname: "127.0.0.1",
        port: game ? 2999 : port,
        path,
        method: "GET",
        ...(game ? { rejectUnauthorized: false } : {}),
      },
      (res) => {
        const parts: Buffer[] = [];
        let bytes = 0;
        res.on("data", (b: Buffer) => {
          bytes += b.length;
          if (bytes > 2_000_000) {
            finish(null);
            req.destroy();
          } else parts.push(b);
        });
        res.on("error", () => finish(null));
        res.on("end", () => {
          try {
            finish(res.statusCode ?? null, JSON.parse(Buffer.concat(parts).toString()));
          } catch {
            finish(res.statusCode ?? null);
          }
        });
      },
    );
    const timer = setTimeout(() => {
      finish(null);
      req.destroy();
    }, 2500);
    req.on("error", () => finish(null));
    req.end();
  });
}
async function lbListener(): Promise<boolean | null> {
  return new Promise((yes) => {
    const socket = createConnection({ host: "127.0.0.1", port: 58869 });
    const timer = setTimeout(() => done(null), 1000);
    let finished = false;
    const done = (open: boolean | null) => {
      if (finished) return;
      finished = true;
      clearTimeout(timer);
      socket.destroy();
      yes(open);
    };
    socket.once("connect", () => done(true));
    socket.once("error", (e: NodeJS.ErrnoException) =>
      done(e.code === "ECONNREFUSED" ? false : null),
    );
  });
}
const report = await validateProject({
  get,
  lbListener,
  projectBaseUrl: `http://127.0.0.1:${port}`,
  seconds,
  dataOrigin: "local-game-api",
});
const startedAt = report.startedAt;
const folder = resolve("collector/evidence/validation");
await mkdir(folder, { recursive: true });
await writeFile(
  resolve(folder, `project-live-${startedAt.replaceAll(":", "-")}.json`),
  JSON.stringify(report, null, 2),
  { flag: "wx" },
);
console.log(JSON.stringify(report));
if (report.preflight !== "ready" || report.errors.length) process.exitCode = 2;
