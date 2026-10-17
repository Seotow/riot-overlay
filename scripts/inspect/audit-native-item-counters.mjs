import { createReadStream } from "node:fs";
import { createGunzip } from "node:zlib";
import { createInterface } from "node:readline";
import { writeFile } from "node:fs/promises";
const items = new Map(),
  buffs = new Map();
let frames = 0;
const itemData = JSON.parse(
  await (
    await import("node:fs/promises")
  ).readFile("public/ddragon/16.20.1/data/item.json", "utf8"),
).data;
function add(map, key, value) {
  const s = map.get(key) ?? new Set();
  if (s.size < 25) s.add(JSON.stringify(value));
  map.set(key, s);
}
for await (const l of createInterface({
  input: createReadStream("data/captures/2026-10-16T12-43-43-938Z/collector-native.ndjson.gz").pipe(
    createGunzip(),
  ),
})) {
  const d = JSON.parse(l).message?.data;
  if (!d?.heroes) continue;
  frames++;
  for (const h of d.heroes) {
    for (const i of h.items ?? []) {
      const name = itemData[i.id]?.name ?? String(i.id);
      if (
        /Tear|Seraph|Archangel|Manamune|Muramana|Winter|Fimbul|Blood|Boot|Ward|Potion|Atlas|Compass|Bounty|Zak|Dream|Solstice|Celestial/i.test(
          name,
        ) ||
        i.slot >= 6
      ) {
        const spell = h.spells?.find((s) => s.index === i.slot + 6);
        add(items, `${i.id}:${name}`, {
          slot: i.slot,
          count: i.count,
          stacks: i.stacks,
          charges: i.charges,
          stats: i.stats,
          keys: Object.keys(i),
          ammo: spell ? { count: spell.ammoCount, max: spell.ammoMax } : null,
        });
      }
    }
    for (const b of h.common?.buffs ?? [])
      if (/tear|manacharge|blood|boot|ward|item30|archangel|seraph/i.test(b.name ?? ""))
        add(buffs, b.name, { count: b.count, type: b.type });
  }
}
const report = {
  frames,
  items: Object.fromEntries([...items].map(([k, v]) => [k, [...v].map(JSON.parse)])),
  buffs: Object.fromEntries([...buffs].map(([k, v]) => [k, [...v].map(JSON.parse)])),
};
await writeFile(".npm-cache/data-audit/native-item-counters.json", JSON.stringify(report, null, 2));
console.log(JSON.stringify(report));
