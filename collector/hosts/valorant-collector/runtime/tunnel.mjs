// Tunnel cloudflared "quick tunnel": mở một URL công khai trycloudflare.com trỏ về ingest loopback,
// để player ngoài LAN đẩy dữ liệu về host. Tải cloudflared.exe một lần (kiểm SHA256), không cần tài khoản.
import { spawn } from "node:child_process";
import { createHash } from "node:crypto";
import { createWriteStream } from "node:fs";
import { access, chmod, mkdir, readFile, rename, rm } from "node:fs/promises";
import { dirname, resolve } from "node:path";
import { Readable } from "node:stream";
import { pipeline } from "node:stream/promises";
import { localRoot, workspace } from "./config.mjs";

// Bản cloudflared chính thức (GitHub releases), pin phiên bản + SHA256 (hash tính khi tải trong phiên phát hành).
export const cloudflaredRelease = {
  tag: "2026.10.3",
  url: "https://github.com/cloudflare/cloudflared/releases/download/2026.10.3/cloudflared-windows-amd64.exe",
  size: 55329336,
  sha256: "76b2805253d0d6ffacb092a7acfbee99e7af6917835c0c5410e23f3ef5052da2",
};

const exists = (path) =>
  access(path).then(
    () => true,
    () => false,
  );
const sha256File = async (path) => createHash("sha256").update(await readFile(path)).digest("hex");

export function cloudflaredPath() {
  return resolve(localRoot, "cloudflared", `cloudflared-${cloudflaredRelease.tag}.exe`);
}

/** Tải cloudflared đúng một lần, kiểm SHA256. Trả về đường dẫn exe. */
export async function acquireCloudflared(log = () => {}) {
  const exe = cloudflaredPath();
  if (await exists(exe)) return exe;
  await mkdir(dirname(exe), { recursive: true });
  log(`Tải cloudflared ${cloudflaredRelease.tag} (một lần, ${(cloudflaredRelease.size / 1048576).toFixed(0)} MB)`);
  const res = await fetch(cloudflaredRelease.url, { redirect: "follow" });
  if (!res.ok || !res.body) throw new Error(`Tải cloudflared thất bại (HTTP ${res.status})`);
  await pipeline(Readable.fromWeb(res.body), createWriteStream(`${exe}.part`));
  if ((await sha256File(`${exe}.part`)) !== cloudflaredRelease.sha256) {
    await rm(`${exe}.part`, { force: true });
    throw new Error("cloudflared không khớp SHA256 đã pin");
  }
  await rename(`${exe}.part`, exe);
  await chmod(exe, 0o755).catch(() => {});
  return exe;
}

const TRYCLOUDFLARE = /https:\/\/[a-z0-9-]+\.trycloudflare\.com/;

/**
 * Mở quick tunnel tới http://127.0.0.1:<ingestPort>. Trả {origin, stop, status()}.
 * origin là URL công khai (https). Tự khởi động lại nếu cloudflared thoát bất ngờ.
 */
export async function startTunnel({ ingestPort, onState = () => {}, log = () => {} }) {
  const exe = await acquireCloudflared(log);
  let child = null;
  let origin = "";
  let state = "starting";
  let stopped = false;

  const launch = () => {
    const proc = spawn(
      exe,
      [
        "tunnel",
        "--no-autoupdate",
        "--url",
        `http://127.0.0.1:${ingestPort}`,
        "--loglevel",
        "info",
      ],
      { windowsHide: true, stdio: ["ignore", "ignore", "pipe"] },
    );
    child = proc;
    proc.stderr.setEncoding("utf8");
    proc.stderr.on("data", (chunk) => {
      if (origin) return;
      const found = String(chunk).match(TRYCLOUDFLARE);
      if (found) {
        origin = found[0];
        state = "connected";
        onState({ state, origin });
      }
    });
    proc.on("exit", () => {
      if (stopped) return;
      origin = "";
      state = "restarting";
      onState({ state, origin });
      setTimeout(() => {
        if (!stopped) launch();
      }, 2000);
    });
    proc.on("error", () => {
      if (!stopped) {
        state = "failed";
        onState({ state, origin });
      }
    });
  };
  launch();

  return {
    get origin() {
      return origin;
    },
    status: () => ({ state, origin }),
    stop: async () => {
      stopped = true;
      const proc = child;
      child = null;
      if (!proc || proc.exitCode !== null) return;
      if (process.platform === "win32")
        await new Promise((ok) => {
          const t = spawn("taskkill.exe", ["/PID", String(proc.pid), "/T", "/F"], {
            windowsHide: true,
            stdio: "ignore",
          });
          t.once("exit", ok);
          t.once("error", ok);
        });
      else proc.kill();
    },
  };
}
