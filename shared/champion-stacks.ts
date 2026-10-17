// Icon choices explicitly requested by the operator; not inferred from game stats.
export const stackChampions: Record<
  number,
  { code: string; ability: "passive" | "Q" | "W" | "R"; nativeBuff?: string }
> = {
  432: { code: "Bard", ability: "passive" },
  75: { code: "Nasus", ability: "Q" },
  136: { code: "AurelionSol", ability: "passive" },
  901: { code: "Smolder", ability: "passive", nativeBuff: "SmolderQPassive" },
  45: { code: "Veigar", ability: "passive", nativeBuff: "VeigarPhenomenalEvilPower" },
  235: { code: "Senna", ability: "passive" },
  31: { code: "Chogath", ability: "R" },
  14: { code: "Sion", ability: "W" },
  412: { code: "Thresh", ability: "passive" },
  200: { code: "Belveth", ability: "passive" },
  203: { code: "Kindred", ability: "passive" },
};
export function stackChampion(id: number | null | undefined) {
  return id == null ? undefined : stackChampions[id];
}
export function validChampionStacks(value: unknown): number | null {
  return typeof value === "number" &&
    Number.isFinite(value) &&
    value >= 0 &&
    value <= Number.MAX_SAFE_INTEGER
    ? value
    : null;
}
// Only exact buff mappings verified in captured telemetry. Never sum generic buffs,
// ability charges, AP/health growth, items or CS to manufacture a champion counter.
export function nativeChampionStacks(id: number | null, buffs: unknown): number | null {
  const name = stackChampion(id)?.nativeBuff;
  if (!name || !Array.isArray(buffs)) return null;
  const candidates = buffs.filter(
    (b) =>
      b &&
      typeof b === "object" &&
      typeof b.name === "string" &&
      b.name.toLowerCase() === name.toLowerCase(),
  );
  if (candidates.length !== 1) return null;
  return validChampionStacks(candidates[0].count);
}
