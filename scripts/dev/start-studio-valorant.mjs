// Launcher chung: Studio (production) + module Valorant. Chỉ dừng process do chính script này tạo.
// Tham số sau `--` được chuyển cho module Valorant, ví dụ `--services-only`.
import { spawn } from "node:child_process";
import { fileURLToPath } from "node:url";
import { resolve, dirname } from "node:path";

const root = resolve(dirname(fileURLToPath(import.meta.url)), "../..");
const run = (name, script, args) => {
  const child = spawn(process.execPath, [script, ...args], {
    cwd: root,
    stdio: "inherit",
    windowsHide: true,
  });
  child.on("exit", (code) => void stop(`${name} dừng (mã ${code ?? "signal"})`, code ?? 1));
  return child;
};
let closing = false;
const children = [];
async function stop(reason, code = 0) {
  if (closing) return;
  closing = true;
  console.log(reason);
  for (const child of children) child.kill();
  setTimeout(() => process.exit(code), 1500).unref();
}
children.push(
  run("Valorant", "modules/valorant/runtime/cli.mjs", ["start", ...process.argv.slice(2)]),
  run("Studio", "node_modules/tsx/dist/cli.mjs", ["server/index.ts", "--production"]),
);
process.on("SIGINT", () => void stop("Đang dừng Studio và module Valorant…"));
process.on("SIGTERM", () => void stop("Đang dừng Studio và module Valorant…"));
