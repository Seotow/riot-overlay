import { createRequire } from "node:module";
import { readFile, writeFile } from "node:fs/promises";
import { resolve } from "node:path";
const require = createRequire(import.meta.url);
const sharp = require(resolve(process.env.OVERLAY_BROWSER_PACKAGES, "sharp"));
const out = ".npm-cache/visual-audit";
// Fixed static label only. White glyph mask avoids including game background.
const rect = { left: 12, top: 154, width: 145, height: 40 };
async function mask(path) {
  const { data, info } = await sharp(path)
    .extract(rect)
    .ensureAlpha()
    .raw()
    .toBuffer({ resolveWithObject: true });
  return Array.from(
    { length: info.width * info.height },
    (_, i) =>
      data[i * 4 + 3] > 150 &&
      Math.min(...data.subarray(i * 4, i * 4 + 3)) > 155 &&
      Math.max(...data.subarray(i * 4, i * 4 + 3)) -
        Math.min(...data.subarray(i * 4, i * 4 + 3)) <
        55,
  );
}
const a = await mask("images/xếp hạng gold.png"),
  b = await mask(`${out}/gold.png`);
const near = (mask, x, y) => {
  for (let dy = -1; dy <= 1; dy++)
    for (let dx = -1; dx <= 1; dx++)
      if (
        x + dx >= 0 &&
        x + dx < 145 &&
        y + dy >= 0 &&
        y + dy < 40 &&
        mask[(y + dy) * 145 + x + dx]
      )
        return true;
  return false;
};
const match = (from, to) =>
  from.reduce(
    (sum, p, i) => sum + (p && near(to, i % 145, Math.floor(i / 145)) ? 1 : 0),
    0,
  ) / Math.max(1, from.filter(Boolean).length);
const precision = match(b, a),
  recall = match(a, b);
const measurements = JSON.parse(
  await readFile(`${out}/measurements.json`, "utf8"),
);
const report = {
  scope:
    "Static TOTAL GOLD label only; 1px mask tolerance. NOT full-overlay similarity.",
  precision,
  recall,
  f1: (2 * precision * recall) / (precision + recall),
  measurements,
};
await writeFile(`${out}/scores.json`, JSON.stringify(report, null, 2));
console.log(
  JSON.stringify({ scope: report.scope, precision, recall, f1: report.f1 }),
);
