import data from "./generated/live-catalog.json";
import variants from "./generated/spell-variants.json";
export interface NamedAsset {
  name: string;
  icon: string;
}
export interface ChampionAsset extends NamedAsset {
  id: string;
  key: number;
  ultimateIcon?: string;
}
export interface SpellAsset extends NamedAsset {
  id: string;
  key: number;
}
export const liveCatalog = data as {
  version: string;
  locale: string;
  source: string;
  champions: Record<string, ChampionAsset>;
  items: Record<string, NamedAsset & { id: number }>;
  spells: Record<string, SpellAsset>;
  runes: Record<string, NamedAsset & { id: number }>;
};
const own = <T>(record: Record<string, T>, key: unknown): T | undefined =>
  (typeof key === "string" || typeof key === "number") && Object.hasOwn(record, String(key))
    ? record[String(key)]
    : undefined;
export const liveChampion = (id: number | null | undefined) => own(liveCatalog.champions, id);
export const liveItem = (id: number | null | undefined) => own(liveCatalog.items, id);
export const liveSpell = (id: string | null | undefined) =>
  own(liveCatalog.spells, id) ?? own(variants.spells as Record<string, SpellAsset>, id);
export const liveRune = (id: number | null | undefined) => own(liveCatalog.runes, id);
const byCode = new Map(Object.values(liveCatalog.champions).map((c) => [c.id.toLowerCase(), c]));
const byName = new Map(Object.values(liveCatalog.champions).map((c) => [c.name.toLowerCase(), c]));
export function resolveChampion(p: Record<string, unknown>) {
  const direct = typeof p.championId === "number" ? liveChampion(p.championId) : undefined;
  if (direct) return { id: direct.key, via: "numeric-id" as const };
  const match =
    typeof p.rawChampionName === "string"
      ? /^game_character_displayname_([A-Za-z0-9]+)$/.exec(p.rawChampionName)
      : null;
  const raw = match ? byCode.get(match[1].toLowerCase()) : undefined;
  if (raw) return { id: raw.key, via: "raw-code" as const };
  const named =
    typeof p.championName === "string" ? byName.get(p.championName.toLowerCase()) : undefined;
  if (named) return { id: named.key, via: "display-name" as const };
  return { id: null, via: "unmapped" as const };
}
export function resolveSpell(value: unknown): string | null {
  if (!value || typeof value !== "object" || Array.isArray(value)) return null;
  const p = value as Record<string, unknown>;
  const match =
    typeof p.rawDisplayName === "string"
      ? /^GeneratedTip_SummonerSpell_([A-Za-z0-9_]+)_DisplayName$/.exec(p.rawDisplayName)
      : null;
  if (match && liveSpell(match[1])) return match[1];
  if (typeof p.displayName === "string")
    return Object.values(liveCatalog.spells).find((s) => s.name === p.displayName)?.id ?? null;
  return null;
}
