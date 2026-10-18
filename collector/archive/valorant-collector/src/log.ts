import { appendFileSync, mkdirSync, statSync, truncateSync } from "fs";
import { join } from "path";

let file = "";
const MAX_BYTES = 2 * 1024 * 1024;

/** Log chỉ ghi vào profile của collector; không bao giờ ghi key, secret hay payload trận. */
export function initLog(dir: string) {
  mkdirSync(dir, { recursive: true });
  file = join(dir, "collector.log");
  try {
    if (statSync(file).size > MAX_BYTES) truncateSync(file, 0);
  } catch {}
}

function write(level: string, parts: unknown[]) {
  const line = `${new Date().toISOString()} ${level} ${parts
    .map((p) => (p instanceof Error ? p.message : typeof p === "string" ? p : JSON.stringify(p)))
    .join(" ")}\n`;
  if (!file) return;
  try {
    appendFileSync(file, line);
  } catch {}
}

export const log = {
  info: (...parts: unknown[]) => write("INFO", parts),
  warn: (...parts: unknown[]) => write("WARN", parts),
  error: (...parts: unknown[]) => write("ERROR", parts),
};
