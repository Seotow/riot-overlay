import { object } from "../adapter/normalize";
import { resolveChampion, liveChampion } from "../../shared/live-assets";

const number = (v: unknown) => (typeof v === "number" && Number.isFinite(v) && v >= 0 ? v : null);
const pair = (current: unknown, max: unknown) => {
  const a = number(current),
    b = number(max);
  return a !== null && b !== null && b > 0 && a <= b ? { current: a, max: b } : null;
};
const kinds = [
  "mana",
  "energy",
  "none",
  "shield",
  "battlefury",
  "dragonfury",
  "rage",
  "heat",
  "gnarfury",
  "ferocity",
  "bloodwell",
  "wind",
  "ammo",
  "moonlight",
  "other",
];

// Diagnostic projection for any roster/map, independent of SR10 UI contract.
// Public champion metadata only; never names, network IDs, auth or raw events.
export function inspectBasicFields(raw: unknown, now: number) {
  const e = object(raw),
    data = object(e.data);
  if (
    e.schemaVersion !== 1 ||
    e.type !== "snapshot" ||
    e.source !== "lblib" ||
    e.synthetic !== false ||
    e.recordedAt !== null ||
    typeof e.sequence !== "number" ||
    !Number.isSafeInteger(e.sequence) ||
    e.sequence < 1 ||
    typeof e.timestamp !== "string" ||
    !/^\d{4}-\d{2}-\d{2}T.*(?:Z|[+-]\d{2}:\d{2})$/.test(e.timestamp)
  )
    return null;
  const time = Date.parse(e.timestamp);
  if (
    !Number.isFinite(time) ||
    time > now + 1000 ||
    now - time >= 5000 ||
    number(data.gameTime) === null ||
    !Array.isArray(data.heroes) ||
    data.heroes.length < 1 ||
    data.heroes.length > 64
  )
    return null;
  const rows = data.heroes.map((raw, index) => {
    const h = object(raw),
      c = object(h.common),
      info = object(h.info);
    const code =
      typeof c.identifier === "string" && /^[A-Za-z0-9]{1,64}$/.test(c.identifier)
        ? c.identifier
        : null;
    const champion = resolveChampion({
      rawChampionName: code ? `game_character_displayname_${code}` : undefined,
    });
    return {
      row: index,
      champion: liveChampion(champion.id)?.id ?? null,
      team: info.team === 1 ? "ORDER" : info.team === 2 ? "CHAOS" : null,
      health: pair(c.health, c.maxHealth),
      resource: pair(h.resource, h.maxResource),
      reportedResourceKind:
        typeof h.resourceType === "number" && Number.isInteger(h.resourceType)
          ? (kinds[h.resourceType] ?? null)
          : null,
      currentGold: number(h.gold),
      totalGold: number(h.totalGold),
    };
  });
  const coverage = Object.fromEntries(
    (["health", "resource", "currentGold", "totalGold"] as const).map((key) => [
      key,
      rows.filter((row) => row[key] !== null).length,
    ]),
  );
  return {
    gameTime: number(data.gameTime)!,
    rows,
    coverage,
    valueSemanticsVerified: false as const,
  };
}
