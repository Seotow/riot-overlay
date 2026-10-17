import { mkdir, writeFile, readFile } from "node:fs/promises";
import { dirname } from "node:path";
// The reference broadcast is patch 25.20 (Data Dragon version 15.20.1).
const version = "15.20.1",
  root = `public/ddragon/${version}`;
const base = "https://ddragon.leagueoflegends.com";
async function download(url, path) {
  try {
    await readFile(path);
    return;
  } catch {}
  const response = await fetch(url);
  if (!response.ok) throw Error(`${response.status}: ${url}`);
  await mkdir(dirname(path), { recursive: true });
  await writeFile(path, Buffer.from(await response.arrayBuffer()));
}
for (const name of ["champion", "item", "summoner", "runesReforged"])
  await download(`${base}/cdn/${version}/data/en_US/${name}.json`, `${root}/data/${name}.json`);
const champions = JSON.parse(await readFile(`${root}/data/champion.json`, "utf8")).data;
const items = JSON.parse(await readFile(`${root}/data/item.json`, "utf8")).data;
const spells = JSON.parse(await readFile(`${root}/data/summoner.json`, "utf8")).data;
const runes = JSON.parse(await readFile(`${root}/data/runesReforged.json`, "utf8"));
const ids = [
  "Gnar",
  "XinZhao",
  "Ryze",
  "Zeri",
  "Neeko",
  "Ambessa",
  "JarvanIV",
  "Taliyah",
  "Sivir",
  "Lulu",
  "MonkeyKing",
  "Rumble",
  "Varus",
  "Ezreal",
  "Blitzcrank",
  "Gwen",
  "Shen",
  "Zed",
  "Leona",
  "Yunara",
  "Yone",
  "Jhin",
  "Azir",
];
const itemIds = [
  "1055",
  "1054",
  "1056",
  "2003",
  "2055",
  "3363",
  "3364",
  "3340",
  "3047",
  "3111",
  "3006",
  "3020",
  "3158",
  "3078",
  "3053",
  "3071",
  "3161",
  "3107",
  "3190",
  "3877",
  "3089",
  "3135",
  "3118",
  "3040",
  "6657",
  "3031",
  "3085",
  "3036",
  "6672",
  "3094",
  "3116",
  "3152",
  "3083",
  "3110",
];
const jobs = [];
for (const id of ids) {
  if (!champions[id]) throw Error(`Unknown champion ${id}`);
  jobs.push([
    `${base}/cdn/${version}/img/champion/${champions[id].image.full}`,
    `${root}/champion/${id}.png`,
  ]);
  jobs.push([`${base}/cdn/img/champion/loading/${id}_0.jpg`, `${root}/loading/${id}_0.jpg`]);
}
for (const id of itemIds) {
  if (!items[id]) throw Error(`Unknown item ${id}`);
  jobs.push([`${base}/cdn/${version}/img/item/${items[id].image.full}`, `${root}/item/${id}.png`]);
}
for (const id of [
  "SummonerFlash",
  "SummonerTeleport",
  "SummonerSmite",
  "SummonerHeal",
  "SummonerExhaust",
  "SummonerDot",
  "SummonerBarrier",
])
  jobs.push([
    `${base}/cdn/${version}/img/spell/${spells[id].image.full}`,
    `${root}/spell/${id}.png`,
  ]);
const runeIcons = [];
for (const tree of runes)
  for (const slot of tree.slots)
    for (const rune of slot.runes)
      if ([8005, 8008, 8010, 8021, 8112, 8439, 8465, 8230, 8229].includes(rune.id)) {
        runeIcons.push(rune);
        jobs.push([`${base}/cdn/img/${rune.icon}`, `${root}/rune/${rune.id}.png`]);
      }
let done = 0;
for (let i = 0; i < jobs.length; i += 8) {
  await Promise.all(jobs.slice(i, i + 8).map(([url, path]) => download(url, path)));
  done = Math.min(i + 8, jobs.length);
  console.log(`Assets ${done}/${jobs.length}`);
}
const catalog = {
  version,
  displayPatch: "25.20",
  locale: "en_US",
  source: base,
  champions: Object.fromEntries(
    ids.map((id) => [
      id,
      {
        id,
        key: champions[id].key,
        name: champions[id].name,
        icon: `/ddragon/${version}/champion/${id}.png`,
        portrait: `/ddragon/${version}/loading/${id}_0.jpg`,
      },
    ]),
  ),
  items: Object.fromEntries(
    itemIds.map((id) => [
      id,
      { id, name: items[id].name, icon: `/ddragon/${version}/item/${id}.png` },
    ]),
  ),
  spells: Object.fromEntries(
    Object.entries(spells)
      .filter(([id]) => jobs.some(([, p]) => p.endsWith(`/spell/${id}.png`)))
      .map(([id, s]) => [id, { id, name: s.name, icon: `/ddragon/${version}/spell/${id}.png` }]),
  ),
  runes: Object.fromEntries(
    runeIcons.map((r) => [
      r.id,
      { id: r.id, name: r.name, icon: `/ddragon/${version}/rune/${r.id}.png` },
    ]),
  ),
};
await mkdir("shared/generated", { recursive: true });
await writeFile("shared/generated/catalog.json", JSON.stringify(catalog, null, 2));
await writeFile(
  `${root}/manifest.json`,
  JSON.stringify(
    {
      version,
      source: base,
      downloadedAt: new Date().toISOString(),
      files: jobs.map(([source, path]) => ({ source, path })),
    },
    null,
    2,
  ),
);
console.log(`Pinned Data Dragon ${version}: ${jobs.length} assets verified.`);
