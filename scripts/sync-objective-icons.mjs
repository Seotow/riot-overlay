import { mkdir, writeFile, rename } from "node:fs/promises";
import { createHash } from "node:crypto";
const revision = "486502329f2c18ddf1cfce6cb8886ae4606b0722";
const base = `https://raw.githubusercontent.com/BlueBottleGG/leaguebroadcast-js-client-demo/${revision}/src/assets`;
const root = "public/broadcast/objectives";
await mkdir(root, { recursive: true });
const assets = [];
for (const [group, ids] of [
  ["baron", ["baron", "herald", "grubs"]],
  ["dragon", ["air", "chemtech", "earth", "elder", "fire", "hextech", "water"]],
]) {
  for (const id of ids) {
    const source = `${base}/${group}/${id}.png`;
    const response = await fetch(source, {
      signal: AbortSignal.timeout(20000),
    });
    if (!response.ok) throw Error(`HTTP ${response.status}`);
    const bytes = Buffer.from(await response.arrayBuffer());
    if (bytes.subarray(0, 8).toString("hex") !== "89504e470d0a1a0a")
      throw Error("Not PNG");
    const path = `${root}/${id}.png`;
    await writeFile(path + ".tmp", bytes);
    await rename(path + ".tmp", path);
    assets.push({
      id,
      source,
      path,
      sha256: createHash("sha256").update(bytes).digest("hex"),
    });
  }
}
await writeFile(
  root + "/provenance.json",
  JSON.stringify(
    {
      repository:
        "https://github.com/BlueBottleGG/leaguebroadcast-js-client-demo",
      revision,
      notice:
        "Visual game assets hosted by BlueBottle; underlying Riot artwork. No provider runtime/source code copied. Verify redistribution rights before publishing.",
      assets,
    },
    null,
    2,
  ),
);
console.log(
  `Downloaded ${assets.length} PNG objective icons at pinned revision ${revision}`,
);
