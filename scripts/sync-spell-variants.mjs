import { mkdir, writeFile, rename } from "node:fs/promises";
import { createHash } from "node:crypto";
const root = "public/broadcast/spells";
await mkdir(root, { recursive: true });
const variants = [
  [
    "S5_SummonerSmitePlayerGanker",
    "Unleashed Smite",
    "avatarsmite_firstupgrade.png",
  ],
  [
    "SummonerSmiteAvatarOffensive",
    "Primal Smite · Scorchclaw",
    "1101_smite.png",
  ],
  [
    "SummonerSmiteAvatarDefensive",
    "Primal Smite · Mosstomper",
    "1103_smite.png",
  ],
  ["SummonerSmiteAvatarUtility", "Primal Smite · Gustwalker", "1102_smite.png"],
  [
    "S12_SummonerTeleportUpgrade",
    "Unleashed Teleport",
    "unleashed_teleport_new.png",
  ],
];
const catalog = { version: "16.20", spells: {} };
for (const [id, name, file] of variants) {
  const source = `https://raw.communitydragon.org/16.20/game/data/spells/icons2d/${file}`;
  const r = await fetch(source, { signal: AbortSignal.timeout(15000) });
  if (!r.ok) throw Error(`${file}: HTTP ${r.status}`);
  const bytes = Buffer.from(await r.arrayBuffer());
  if (bytes.subarray(0, 8).toString("hex") !== "89504e470d0a1a0a")
    throw Error("Not PNG");
  await writeFile(`${root}/${id}.png.tmp`, bytes);
  await rename(`${root}/${id}.png.tmp`, `${root}/${id}.png`);
  catalog.spells[id] = {
    id,
    name,
    key: 0,
    icon: `/broadcast/spells/${id}.png`,
    source,
    sha256: createHash("sha256").update(bytes).digest("hex"),
  };
}
await writeFile(
  "shared/generated/spell-variants.json",
  JSON.stringify(catalog, null, 2),
);
console.log(`Saved ${variants.length} versioned spell variants`);
