import pathsData from "../../shared/generated/rune-paths.json";
import { liveCatalog, liveRune } from "../../shared/live-assets";

const paths: Record<string, { treeId: number; keystone: boolean }> = pathsData.paths;
const shards = new Set([5001, 5005, 5007, 5008, 5011]);

// Source-derived projection only. Never assume that native vector order matches
// LB UI order: validate the structure before supplying the ordered rune panel.
export function collectorPerks(raw: unknown) {
  const missing = { perks: null, keystone: null };
  if (
    pathsData.version !== liveCatalog.version ||
    !Array.isArray(raw) ||
    raw.length === 0 ||
    raw.length > 32
  )
    return missing;
  const ids: number[] = [];
  for (const entry of raw) {
    if (!entry || typeof entry !== "object" || Array.isArray(entry)) return missing;
    const id = (entry as Record<string, unknown>).id;
    if (
      typeof id !== "number" ||
      !Number.isSafeInteger(id) ||
      id <= 0 ||
      !liveRune(id) ||
      (!paths[id] && !shards.has(id))
    )
      return missing;
    ids.push(id);
  }
  const keys = ids.filter((id) => paths[id]?.keystone);
  const keystone = keys.length === 1 ? keys[0] : null;
  if (ids.length !== 9 || keystone === null) return { perks: null, keystone };
  const primary = paths[keystone].treeId;
  const first = ids.slice(0, 4),
    second = ids.slice(4, 6);
  const secondary = paths[second[0]]?.treeId;
  const ordered =
    new Set(first.concat(second)).size === 6 &&
    first.every((id) => paths[id]?.treeId === primary) &&
    first.includes(keystone) &&
    secondary !== undefined &&
    secondary !== primary &&
    second.every((id) => paths[id]?.treeId === secondary && !paths[id].keystone) &&
    ids.slice(6).every((id) => shards.has(id));
  return { perks: ordered ? ids : null, keystone };
}
