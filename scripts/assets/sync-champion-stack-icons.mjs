// Download only 11 pinned 2D Riot assets, no catalog/patch baseline migration.
import { readFile, writeFile, mkdir } from "node:fs/promises";
import { createHash } from "node:crypto";
const version = JSON.parse(await readFile("shared/generated/live-catalog.json", "utf8")).version;
if (version !== "16.20.1") throw Error("Review icon patch before changing pinned version");
const rules = [
  ["Bard", "passive"],
  ["Nasus", "Q"],
  ["AurelionSol", "passive"],
  ["Smolder", "passive"],
  ["Veigar", "passive"],
  ["Senna", "passive"],
  ["Chogath", "R"],
  ["Sion", "W"],
  ["Thresh", "passive"],
  ["Belveth", "passive"],
  ["Kindred", "passive"],
];
const root = "public/broadcast/champion-stacks";
await mkdir(root, { recursive: true });
let previous = [];
try {
  previous = JSON.parse(await readFile(`${root}/manifest.json`, "utf8")).files;
} catch {}
const files = [];
await Promise.all(
  rules.map(async ([code, ability]) => {
    const d = JSON.parse(
      await readFile(`public/ddragon/${version}/data/champion/${code}.json`, "utf8"),
    ).data[code];
    const a = ability === "passive" ? d.passive : d.spells[{ Q: 0, W: 1, R: 3 }[ability]];
    const source = `https://ddragon.leagueoflegends.com/cdn/${version}/img/${ability === "passive" ? "passive" : "spell"}/${a.image.full}`;
    const path = `${root}/${code}.png`;
    let bytes;
    if (previous.some((f) => f.code === code && f.source === source))
      try {
        bytes = await readFile(path);
      } catch {}
    if (!bytes) {
      const r = await fetch(source, { signal: AbortSignal.timeout(25000) });
      if (!r.ok) throw Error(`${code}: ${r.status}`);
      bytes = Buffer.from(await r.arrayBuffer());
    }
    if (!bytes.subarray(0, 8).equals(Buffer.from([137, 80, 78, 71, 13, 10, 26, 10])))
      throw Error(`Not PNG: ${code}`);
    await writeFile(path, bytes);
    files.push({
      code,
      ability,
      name: a.name,
      path,
      source,
      sha256: createHash("sha256").update(bytes).digest("hex"),
    });
  }),
);
files.sort((a, b) => a.code.localeCompare(b.code));
await writeFile(
  `${root}/manifest.json`,
  JSON.stringify(
    { version, source: "Riot Data Dragon", iconRules: "operator-requested", files },
    null,
    2,
  ) + "\n",
);
console.log(JSON.stringify({ version, icons: files.length }));
