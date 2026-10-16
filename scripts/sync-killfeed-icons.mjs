import { writeFile, mkdir } from "node:fs/promises";
import { createHash } from "node:crypto";
const base =
  "https://raw.communitydragon.org/16.20/game/assets/ux/minimap/icons/";
const root = "public/broadcast/killers";
await mkdir(root, { recursive: true });
const assets = [];
for (const [name, file] of [
  ["minion", "minionmapcircle.png"],
  ["monster", "camp.png"],
]) {
  const source = base + file,
    response = await fetch(source);
  if (!response.ok) throw Error(`${response.status}: ${source}`);
  const bytes = Buffer.from(await response.arrayBuffer());
  if (bytes.subarray(1, 4).toString() !== "PNG") throw Error("Invalid PNG");
  const path = `${root}/${name}.png`;
  await writeFile(path, bytes);
  assets.push({
    name,
    path,
    source,
    sha256: createHash("sha256").update(bytes).digest("hex"),
  });
}
await writeFile(
  `${root}/provenance.json`,
  JSON.stringify(
    {
      notice:
        "Original Riot minimap unit glyphs, rendered as white alpha masks. Check redistribution rights before publishing.",
      version: "16.20",
      assets,
    },
    null,
    2,
  ) + "\n",
);
console.log(JSON.stringify(assets));
