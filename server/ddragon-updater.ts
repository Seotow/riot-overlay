import { spawn } from "node:child_process";
import { readFile, readdir, rm } from "node:fs/promises";
import { resolve, sep } from "node:path";
// https://riot-api-libraries.readthedocs.io/en/latest/ddragon.html: realms/<region>.json carries the
// Data Dragon version (`dd`) that is live for players; versions.json[0] can be ahead of it.
const base = "https://ddragon.leagueoflegends.com";
const semver = /^\d+\.\d+\.\d+$/;
const ddragonRoot = resolve("public", "ddragon");
const generatedRoot = resolve("shared", "generated");
const getJson = async (url: string) => {
  const res = await fetch(url, { signal: AbortSignal.timeout(15000) });
  if (!res.ok) throw Error(`HTTP ${res.status}: ${url}`);
  return res.json() as Promise<unknown>;
};
export async function latestVersion(): Promise<string> {
  try {
    const realm = (await getJson(`${base}/realms/na.json`)) as { dd?: unknown };
    if (typeof realm.dd === "string" && semver.test(realm.dd)) return realm.dd;
  } catch {}
  const versions = (await getJson(`${base}/api/versions.json`)) as unknown[];
  const first = versions[0];
  if (typeof first !== "string" || !semver.test(first)) throw Error("Invalid Data Dragon version");
  return first;
}
export async function installedVersion(): Promise<string | null> {
  try {
    const catalog = JSON.parse(await readFile(resolve(generatedRoot, "live-catalog.json"), "utf8"));
    return semver.test(catalog.version) ? catalog.version : null;
  } catch {
    return null;
  }
}
// Versions still named by a generated catalog (draft/demo baseline included) must stay on disk.
export async function referencedVersions(): Promise<Set<string>> {
  const used = new Set<string>();
  for (const name of await readdir(generatedRoot)) {
    if (!name.endsWith(".json")) continue;
    const text = await readFile(resolve(generatedRoot, name), "utf8");
    for (const match of text.matchAll(/\/ddragon\/(\d+\.\d+\.\d+)\//g)) used.add(match[1]);
  }
  return used;
}
export async function pruneOldVersions(keep: string): Promise<string[]> {
  const used = await referencedVersions();
  used.add(keep);
  const removed: string[] = [];
  for (const entry of await readdir(ddragonRoot, { withFileTypes: true })) {
    if (!entry.isDirectory() || !semver.test(entry.name) || used.has(entry.name)) continue;
    const dir = resolve(ddragonRoot, entry.name);
    if (!dir.startsWith(ddragonRoot + sep)) continue;
    await rm(dir, { recursive: true, force: true });
    removed.push(entry.name);
  }
  return removed;
}
function runSync(version: string) {
  return new Promise<void>((done, fail) => {
    const child = spawn(
      process.execPath,
      ["scripts/assets/sync-live-assets.mjs", `--version=${version}`],
      { stdio: "ignore", windowsHide: true },
    );
    child.on("error", fail);
    child.on("exit", (code) => (code === 0 ? done() : fail(Error(`sync exited with ${code}`))));
  });
}
// Runs in the background after start: offline or failed downloads leave the current assets untouched.
export async function updateDataDragon(log: (message: string) => void = console.log) {
  try {
    const [latest, current] = await Promise.all([latestVersion(), installedVersion()]);
    if (latest !== current) {
      log(`Data Dragon: ${current ?? "chưa có"} → ${latest}, đang tải...`);
      await runSync(latest);
      log(`Data Dragon ${latest}: đã tải xong. Chạy "npm run build" để bản đóng gói dùng ảnh mới.`);
    }
    const removed = await pruneOldVersions(latest);
    if (removed.length) log(`Data Dragon: đã xóa bản cũ ${removed.join(", ")}`);
  } catch (error) {
    log(`Data Dragon: bỏ qua cập nhật (${error instanceof Error ? error.message : error})`);
  }
}
