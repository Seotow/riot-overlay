import { spawn } from "node:child_process";
import { access, readFile, mkdir, writeFile } from "node:fs/promises";
import { createHash } from "node:crypto";
import { resolve } from "node:path";
import assert from "node:assert/strict";
import { accountlessEnvironment } from "../runtime/accountless-environment";

const output = resolve(
  "Collector/src/LeagueCollector/src/LeagueCollector/bin/Release/net10.0",
);
const absent = resolve("Collector/config/.accountless-env-must-not-exist");
let missing = false;
try {
  await access(absent);
} catch (e) {
  missing = (e as NodeJS.ErrnoException).code === "ENOENT";
}
assert.ok(missing, "Accountless env path must not exist");
assert.equal(
  createHash("sha256")
    .update(await readFile(resolve(output, "lblib.dll")))
    .digest("hex"),
  "a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3",
);
const startedAt = new Date().toISOString();
const child = spawn(
  resolve("Collector/runtime/LeagueCollector/runtime/dotnet.exe"),
  [
    resolve(output, "LeagueCollector.dll"),
    "--auth-check",
    "--source",
    "lblib",
    "--no-inject",
    "--no-lcu",
  ],
  {
    cwd: output,
    windowsHide: true,
    env: accountlessEnvironment(process.env, absent),
    stdio: ["ignore", "pipe", "ignore"],
  },
);
let raw = "";
child.stdout.on("data", (b) => {
  raw += b;
  if (raw.length > 65536) child.kill();
});
let timedOut = false;
const timer = setTimeout(() => {
  timedOut = true;
  child.kill();
}, 10000);
const exitCode = await new Promise<number | null>((yes, no) => {
  child.once("exit", yes);
  child.once("error", no);
});
clearTimeout(timer);
const state = (() => {
  try {
    return JSON.parse(raw.trim()).state;
  } catch {
    return null;
  }
})();
assert.equal(timedOut, false);
assert.equal(exitCode, 2);
assert.equal(state, "not-configured");
const report = {
  kind: "accountless-offline-check",
  startedAt,
  state,
  exitCode,
  timedOut,
  credentialFileRead: false,
  accountConfigured: false,
  nativeLaunched: false,
  gameAccessed: false,
  dllCacheHashVerified: true,
  dataWithoutAccountVerified: false,
};
const folder = resolve("Collector/evidence/validation");
await mkdir(folder, { recursive: true });
await writeFile(
  resolve(folder, `accountless-offline-${startedAt.replaceAll(":", "-")}.json`),
  JSON.stringify(report, null, 2),
  { flag: "wx" },
);
console.log(JSON.stringify(report));
