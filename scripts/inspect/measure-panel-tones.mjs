import { createRequire } from "node:module";
import { resolve } from "node:path";
import { writeFile } from "node:fs/promises";
const sharp = createRequire(import.meta.url)(
  resolve(process.env.OVERLAY_BROWSER_PACKAGES, "sharp"),
);
const files = [
  "ingame new.png",
  "ingame thông thường.png",
  "ingame chênh lệch tiền 2 bên và các player.png",
  "all.png",
  "../.npm-cache/visual-audit/ingame-opacity-preview-final.png",
  "../.npm-cache/visual-audit/ingame-opacity-calibrated.png",
];
const patches = {
  scoreMain: [660, 18, 30, 35],
  scoreSub: [780, 76, 55, 24],
  playerName: [842, 826, 18, 18],
  gold: [939, 824, 10, 10],
};
const report = [];
for (const file of files) {
  const samples = {};
  for (const [name, [left, top, width, height]] of Object.entries(patches)) {
    const { data, info } = await sharp(`images/${file}`)
      .extract({ left, top, width, height })
      .removeAlpha()
      .raw()
      .toBuffer({ resolveWithObject: true });
    const colors = [];
    for (let i = 0; i < data.length; i += info.channels) {
      const rgb = [data[i], data[i + 1], data[i + 2]];
      colors.push({
        rgb,
        luma: 0.2126 * rgb[0] + 0.7152 * rgb[1] + 0.0722 * rgb[2],
      });
    }
    colors.sort((a, b) => a.luma - b.luma);
    // Lower 30% excludes bright lettering/icons; coordinates are retained for review.
    const clean = colors.slice(0, Math.ceil(colors.length * 0.3));
    samples[name] = {
      patch: [left, top, width, height],
      rgb: clean[0].rgb.map((_, c) =>
        Math.round(clean.reduce((n, p) => n + p.rgb[c], 0) / clean.length),
      ),
      medianLuma: Math.round(colors[Math.floor(colors.length / 2)].luma),
    };
  }
  report.push({ file, samples });
}
await writeFile(
  ".npm-cache/visual-audit/panel-tone-measurements.json",
  JSON.stringify(report, null, 2),
);
console.log(JSON.stringify(report));
