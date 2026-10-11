import data from "./generated/rune-paths.json";
import { liveCatalog, liveRune } from "./live-assets";
const paths: Record<string, { treeId: number; keystone: boolean }> = data.paths;
/** LB order verified in capture: 4 primary, 2 secondary, 3 stat shards.
 * Resolve only known metadata IDs; ambiguous/missing paths remain unavailable. */
export function runeSummary(
  perks: number[] | null | undefined,
  keystoneId: number | null | undefined,
) {
  if (data.version !== liveCatalog.version)
    return { keystone: undefined, secondary: undefined };
  const key =
    keystoneId != null && paths[keystoneId]?.keystone
      ? keystoneId
      : perks?.slice(0, 4).find((id) => paths[id]?.keystone);
  const primary = key == null ? undefined : paths[key]?.treeId;
  const secondaryIds = perks?.slice(4, 6) ?? [];
  const treeIds = secondaryIds.map((id) => paths[id]?.treeId);
  const secondary =
    primary != null &&
    treeIds.length === 2 &&
    treeIds[0] != null &&
    treeIds[0] === treeIds[1] &&
    treeIds[0] !== primary
      ? liveRune(treeIds[0])
      : undefined;
  return { keystone: liveRune(key), secondary };
}
