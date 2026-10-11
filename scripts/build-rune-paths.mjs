// Mechanical generation from the already cached, version-pinned Riot metadata.
import { readFile, writeFile } from "node:fs/promises";
const catalog = JSON.parse(
  await readFile("shared/generated/live-catalog.json", "utf8"),
);
const trees = JSON.parse(
  await readFile(
    `public/ddragon/${catalog.version}/data/runesReforged.json`,
    "utf8",
  ),
);
const paths = {};
for (const tree of trees)
  for (const [slot, group] of tree.slots.entries())
    for (const rune of group.runes)
      paths[rune.id] = { treeId: tree.id, keystone: slot === 0 };
await writeFile(
  "shared/generated/rune-paths.json",
  JSON.stringify({ version: catalog.version, paths }, null, 2) + "\n",
);
console.log(
  `Mapped ${Object.keys(paths).length} rune IDs from ${catalog.version}`,
);
