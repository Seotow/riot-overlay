import { readFile, writeFile, mkdir, rename } from "node:fs/promises";
import { dirname } from "node:path";
import { createHash } from "node:crypto";
const base = "https://ddragon.leagueoflegends.com";
async function fetchBytes(url) {
  let last;
  for (let attempt = 0; attempt < 3; attempt++) {
    try {
      const res = await fetch(url, { signal: AbortSignal.timeout(20000) });
      if (!res.ok) throw Error(`HTTP ${res.status}: ${url}`);
      return Buffer.from(await res.arrayBuffer());
    } catch (error) {
      last = error;
    }
  }
  throw last;
}
async function save(path, bytes) {
  await mkdir(dirname(path), { recursive: true });
  await writeFile(`${path}.tmp`, bytes);
  await rename(`${path}.tmp`, path);
}
const versions = JSON.parse((await fetchBytes(`${base}/api/versions.json`)).toString());
// `--version=x.y.z` lets the server pin the realm's live patch instead of the newest listed one.
const pinned = process.argv.find((a) => a.startsWith("--version="))?.slice(10);
const version = pinned ?? versions[0];
if (!/^\d+\.\d+\.\d+$/.test(version)) throw Error("Invalid Riot version");
const root = `public/ddragon/${version}`;
const metadata = {};
for (const name of ["champion", "item", "summoner", "runesReforged"]) {
  const bytes = await fetchBytes(`${base}/cdn/${version}/data/en_US/${name}.json`);
  metadata[name] = JSON.parse(bytes.toString());
  await save(`${root}/data/${name}.json`, bytes);
}
const jobs = [];
const asset = (kind, id, remote) => {
  const path = `${root}/${kind}/${id}.png`;
  jobs.push({ source: remote, path });
  return `/ddragon/${version}/${kind}/${id}.png`;
};
const champions = Object.fromEntries(
  Object.values(metadata.champion.data).map((c) => [
    c.key,
    {
      id: c.id,
      key: Number(c.key),
      name: c.name,
      icon: asset("champion", c.id, `${base}/cdn/${version}/img/champion/${c.image.full}`),
    },
  ]),
);
const items = Object.fromEntries(
  Object.entries(metadata.item.data).map(([id, i]) => [
    id,
    {
      id: Number(id),
      name: i.name,
      icon: asset("item", id, `${base}/cdn/${version}/img/item/${i.image.full}`),
    },
  ]),
);
const spells = Object.fromEntries(
  Object.values(metadata.summoner.data).map((s) => [
    s.id,
    {
      id: s.id,
      key: Number(s.key),
      name: s.name,
      icon: asset("spell", s.id, `${base}/cdn/${version}/img/spell/${s.image.full}`),
    },
  ]),
);
const runes = {};
const runePaths = {};
for (const tree of metadata.runesReforged) {
  for (const [slot, group] of tree.slots.entries())
    for (const rune of group.runes) runePaths[rune.id] = { treeId: tree.id, keystone: slot === 0 };
  for (const r of [tree, ...tree.slots.flatMap((s) => s.runes)])
    runes[r.id] = {
      id: r.id,
      name: r.name,
      icon: asset("rune", r.id, `${base}/cdn/img/${r.icon}`),
    };
}
// Data Dragon's rune metadata omits stat shards; these are Riot CDN icons.
for (const [id, name, file] of [
  [5001, "Health", "StatModsHealthPlusIcon"],
  [5011, "Scaling Health", "StatModsHealthScalingIcon"],
  [5005, "Attack Speed", "StatModsAttackSpeedIcon"],
  [5007, "Ability Haste", "StatModsCDRScalingIcon"],
  [5008, "Adaptive Force", "StatModsAdaptiveForceIcon"],
])
  runes[id] = {
    id,
    name,
    icon: asset("rune", id, `${base}/cdn/img/perk-images/StatMods/${file}.png`),
  };
let championNext = 0;
const championList = Object.values(champions);
await Promise.all(
  Array.from({ length: 6 }, async () => {
    while (championNext < championList.length) {
      const champion = championList[championNext++];
      const path = `${root}/data/champion/${champion.id}.json`;
      let bytes;
      try {
        bytes = await readFile(path);
      } catch {
        bytes = await fetchBytes(`${base}/cdn/${version}/data/en_US/champion/${champion.id}.json`);
        await save(path, bytes);
      }
      const ultimate = JSON.parse(bytes.toString()).data[champion.id].spells[3];
      champion.ultimateIcon = asset(
        "ability",
        champion.id,
        `${base}/cdn/${version}/img/spell/${ultimate.image.full}`,
      );
    }
  }),
);
let next = 0,
  done = 0;
const manifest = [];
let previousSources = new Map();
try {
  const previous = JSON.parse(await readFile(`${root}/manifest.json`, "utf8"));
  previousSources = new Map(previous.files.map((file) => [file.path, file.source]));
} catch {}
const png = Buffer.from([137, 80, 78, 71, 13, 10, 26, 10]);
async function worker() {
  while (next < jobs.length) {
    const job = jobs[next++];
    let bytes;
    try {
      bytes = await readFile(job.path);
      if (!bytes.subarray(0, 8).equals(png)) bytes = null;
      if (
        process.argv.includes("--refresh-shards") &&
        /\/rune\/(5001|5005|5007|5008|5011)\.png$/.test(job.path)
      )
        bytes = null;
      if (previousSources.has(job.path) && previousSources.get(job.path) !== job.source)
        bytes = null;
    } catch {}
    if (!bytes) {
      bytes = await fetchBytes(job.source);
      if (!bytes.subarray(0, 8).equals(png)) throw Error(`Not a PNG: ${job.source}`);
      await save(job.path, bytes);
    }
    manifest.push({
      ...job,
      sha256: createHash("sha256").update(bytes).digest("hex"),
      bytes: bytes.length,
    });
    done++;
    if (done % 100 === 0 || done === jobs.length)
      console.log(`Data Dragon ${version}: ${done}/${jobs.length}`);
  }
}
await Promise.all(Array.from({ length: 6 }, worker));
const catalog = {
  version,
  locale: "en_US",
  source: base,
  champions,
  items,
  spells,
  runes,
};
await save(
  `${root}/manifest.json`,
  JSON.stringify(
    {
      version,
      source: base,
      downloadedAt: new Date().toISOString(),
      files: manifest.sort((a, b) => a.path.localeCompare(b.path)),
    },
    null,
    2,
  ),
);
// Catalog files are written last so a failed download never leaves a half-updated version.
await save(
  "shared/generated/rune-paths.json",
  Buffer.from(JSON.stringify({ version, paths: runePaths }, null, 2) + "\n"),
);
await save("shared/generated/live-catalog.json", JSON.stringify(catalog, null, 2));
console.log(
  JSON.stringify({
    version,
    champions: Object.keys(champions).length,
    items: Object.keys(items).length,
    spells: Object.keys(spells).length,
    runes: Object.keys(runes).length,
    files: done,
  }),
);
