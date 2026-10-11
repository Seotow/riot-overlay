// Convert the foreground of licensed source glyphs to code-native SVG masks.
// Original PNGs/provenance are kept intact; dark RGB backplates are not alpha masks.
import { createRequire } from "node:module";
import { resolve } from "node:path";
import { readFile, writeFile } from "node:fs/promises";
const require = createRequire(import.meta.url);
const sharp = require(resolve(process.env.OVERLAY_BROWSER_PACKAGES, "sharp"));
await readFile("public/broadcast/objectives/provenance.json", "utf8");
for (const name of [
  "air",
  "earth",
  "fire",
  "water",
  "hextech",
  "chemtech",
  "elder",
  "baron",
  "herald",
  "grubs",
]) {
  const { data, info } = await sharp(`public/broadcast/objectives/${name}.png`)
    .ensureAlpha()
    .raw()
    .toBuffer({ resolveWithObject: true });
  const present = (i) =>
    data[i * 4 + 3] > 100 &&
    Math.max(data[i * 4], data[i * 4 + 1], data[i * 4 + 2]) > 90;
  let path = "",
    pixels = 0;
  for (let y = 0; y < info.height; y++)
    for (let x = 0; x < info.width;) {
      if (!present(y * info.width + x)) {
        x++;
        continue;
      }
      const start = x;
      while (x < info.width && present(y * info.width + x)) {
        x++;
        pixels++;
      }
      path += `M${start} ${y}h${x - start}v1H${start}z`;
    }
  if (pixels < 20 || pixels > info.width * info.height * 0.85)
    throw Error(`Invalid mask ${name}`);
  await writeFile(
    `public/broadcast/objectives/${name}.svg`,
    `<svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 ${info.width} ${info.height}"><path fill="white" d="${path}"/></svg>`,
  );
}
