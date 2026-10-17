// Item-specific semantics: accumulated points and stock are different counters.
const points = new Set([3070, 3003, 3004, 3119, 3008, 223008, 323070]);
const bagCount = new Set([2003, 2010, 2055, 2049, 2050]);
const ammoStock = new Set([2031, 2033, 3340, 3364]);
const wardStock = new Set([3866, 3867, 3869, 3870, 3871, 3876, 3877]);
const obj = (v: unknown): Record<string, unknown> =>
  v !== null && typeof v === "object" && !Array.isArray(v) ? (v as Record<string, unknown>) : {};
const counter = (v: unknown) =>
  typeof v === "number" && Number.isSafeInteger(v) && v >= 0 ? v : null;
export function projectItemCounters(rawItems: unknown, rawSpells?: unknown) {
  if (!Array.isArray(rawItems)) return null;
  const spells = Array.isArray(rawSpells) ? rawSpells.map(obj) : [];
  return rawItems.map(obj).flatMap((i) => {
    const id = counter(i.id),
      slot = counter(i.slot);
    if (!id || slot === null || slot > 8) return [];
    const stack = points.has(id) ? counter(i.charges) : null;
    const spell = spells.find((s) => s.index === 6 + slot);
    const quantity = bagCount.has(id)
      ? counter(i.count)
      : ammoStock.has(id)
        ? counter(spell?.ammoCount)
        : wardStock.has(id)
          ? counter(i.charges)
          : id === 3865
            ? counter(i.stacks)
            : null;
    return stack === null && quantity === null ? [] : [{ id, slot, stack, quantity }];
  });
}
