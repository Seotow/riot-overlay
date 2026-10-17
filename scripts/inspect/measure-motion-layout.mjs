import { createRequire } from "node:module";
import { resolve } from "node:path";
import { mkdir, writeFile } from "node:fs/promises";
const sharp = createRequire(import.meta.url)(
  resolve(process.env.OVERLAY_BROWSER_PACKAGES, "sharp"),
);
const path =
  process.argv[2] ??
  "C:/Users/Seotow/AppData/Local/Temp/codex-clipboard-2dfc8320-7763-4bac-bd4e-ceb706315268.png";
const { data, info } = await sharp(path).removeAlpha().raw().toBuffer({ resolveWithObject: true });
const median = (a) => a.sort((x, y) => x - y)[Math.floor(a.length / 2)];
const patches = {
  blueCorner: [463, 1069, 470, 11],
  redCorner: [986, 1069, 470, 11],
  blueVertical: [463, 978, 8, 91],
  redVertical: [1449, 978, 8, 91],
  blueLogo: [587, 18, 54, 35],
};
const report = { file: path, width: info.width, height: info.height, patches: {} };
for (const [key, [x, y, w, h]] of Object.entries(patches)) {
  const pixels = [],
    rows = {},
    cols = {};
  for (let yy = y; yy < Math.min(info.height, y + h); yy++)
    for (let xx = x; xx < Math.min(info.width, x + w); xx++) {
      const i = (yy * info.width + xx) * info.channels,
        r = data[i],
        g = data[i + 1],
        b = data[i + 2];
      if (
        key.startsWith("red")
          ? r > 95 && r > g * 1.35 && r > b * 1.1
          : b > 100 && b > r * 1.35 && g > 65
      ) {
        pixels.push([r, g, b]);
        rows[yy] = (rows[yy] ?? 0) + 1;
        cols[xx] = (cols[xx] ?? 0) + 1;
      }
    }
  report.patches[key] = {
    rect: [x, y, w, h],
    pixels: pixels.length,
    medianRGB: pixels.length ? [0, 1, 2].map((c) => median(pixels.map((p) => p[c]))) : null,
    strongRows: Object.entries(rows)
      .sort((a, b) => b[1] - a[1])
      .slice(0, 8),
    strongColumns: Object.entries(cols)
      .sort((a, b) => b[1] - a[1])
      .slice(0, 8),
  };
}
await mkdir(".npm-cache/visual-audit", { recursive: true });
await writeFile(
  ".npm-cache/visual-audit/motion-reference-measurements.json",
  JSON.stringify(report, null, 2),
);
console.log(JSON.stringify(report, null, 2));
