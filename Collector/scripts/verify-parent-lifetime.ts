import assert from "node:assert/strict";
import { spawn } from "node:child_process";
import { once } from "node:events";
import { mkdir, writeFile } from "node:fs/promises";
import { resolve } from "node:path";
import { pathToFileURL } from "node:url";

// Controlled launcher exit only; never terminate a game or foreign collector.
const port = 18812;
const startedAt = new Date().toISOString();
const moduleUrl = pathToFileURL(resolve("Collector/runtime/supervisor.ts")).href;
const code = `
import { CollectorRuntime } from ${JSON.stringify(moduleUrl)};
const runtime = new CollectorRuntime({port:${port}});
await runtime.setEnabled(true);
if (!runtime.snapshot().owned) process.exit(2);
process.send({owned:true});
process.on("message", async (message) => {
  if (message === "exit-without-cleanup") process.exit(0);
  if (message === "stop") { await runtime.stop(); process.exit(0); }
});
`;
const launcher = spawn(process.execPath,
  ["--import", "tsx", "--input-type", "module", "-e", code],
  { cwd: process.cwd(), windowsHide: true, stdio: ["ignore", "ignore", "ignore", "ipc"] });
const exited = once(launcher, "exit");
const wait = (ms: number) => new Promise(r => setTimeout(r, ms));
let alive = false, stopped = false, exitedWithoutCleanup = false;
try {
  for (let i = 0; i < 100; i++) {
    assert.equal(launcher.exitCode, null, "Test launcher exited before health");
    try { alive = (await fetch(`http://127.0.0.1:${port}/api/health`,
      {signal: AbortSignal.timeout(500)})).ok; } catch {}
    if (alive) break;
    await wait(100);
  }
  assert.ok(alive, "Owned host health unavailable");
  launcher.send("exit-without-cleanup");
  assert.equal((await exited)[0], 0);
  exitedWithoutCleanup = true;
  for (let i = 0; i < 100; i++) {
    try { await fetch(`http://127.0.0.1:${port}/api/health`,
      {signal: AbortSignal.timeout(500)}); }
    catch { stopped = true; break; }
    await wait(100);
  }
  assert.ok(stopped, "Host still listening after launcher disappeared");
} finally {
  if (launcher.connected) launcher.send("stop");
}
const report = {kind:"collector-parent-lifetime-check", startedAt, alive,
  exitedWithoutCleanup, stopped, rawRecorded:false, credentialsExported:false,
  gameTelemetryVerified:false};
const folder = resolve("Collector/evidence/validation");
await mkdir(folder, {recursive:true});
await writeFile(resolve(folder, `parent-lifetime-${startedAt.replaceAll(":","-")}.json`),
  JSON.stringify(report, null, 2), {flag:"wx"});
console.log(JSON.stringify(report));
