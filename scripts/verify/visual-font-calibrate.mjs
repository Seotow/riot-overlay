import { createRequire } from "node:module";
import { resolve } from "node:path";
import { writeFile } from "node:fs/promises";
const require = createRequire(import.meta.url),
  root = process.env.OVERLAY_BROWSER_PACKAGES;
const { chromium } = require(resolve(root, "playwright")),
  sharp = require(resolve(root, "sharp"));
const area = { left: 12, top: 154, width: 145, height: 40 };
async function mask(bytes) {
  const { data } = await sharp(bytes)
    .extract(area)
    .ensureAlpha()
    .raw()
    .toBuffer({ resolveWithObject: true });
  return Array.from(
    { length: 5800 },
    (_, i) =>
      data[i * 4 + 3] > 150 &&
      Math.min(...data.subarray(i * 4, i * 4 + 3)) > 155 &&
      Math.max(...data.subarray(i * 4, i * 4 + 3)) - Math.min(...data.subarray(i * 4, i * 4 + 3)) <
        55,
  );
}
const target = await mask("images/xếp hạng gold.png");
function score(a, b) {
  const near = (m, x, y) => {
    for (let dy = -1; dy <= 1; dy++)
      for (let dx = -1; dx <= 1; dx++)
        if (x + dx >= 0 && x + dx < 145 && y + dy >= 0 && y + dy < 40 && m[(y + dy) * 145 + x + dx])
          return true;
    return false;
  };
  const match = (a, b) =>
    a.reduce((n, p, i) => n + (p && near(b, i % 145, Math.floor(i / 145)) ? 1 : 0), 0) /
    Math.max(1, a.filter(Boolean).length);
  const p = match(a, b),
    r = match(b, a);
  return (2 * p * r) / (p + r);
}
const browser = await chromium.launch({ headless: true, channel: "msedge" });
try {
  const studio = await browser.newPage();
  await studio.goto("http://127.0.0.1:4310/?page=demo");
  await studio.getByRole("button", { name: "Leaderboard gold", exact: false }).click();
  const page = await browser.newPage({
    viewport: { width: 1920, height: 1080 },
    deviceScaleFactor: 1,
  });
  await page.goto("http://127.0.0.1:4310/overlay");
  await page.locator(".real-gold-ranking").waitFor();
  await page.evaluate(() => document.fonts.ready);
  const results = [];
  for (const size of [26, 26.5, 27, 27.5, 28])
    for (const top of [8, 9, 10]) {
      const style = await page.addStyleTag({
        content: `.live-canvas .real-gold-ranking h3 {font-size:${size}px;padding-top:${top}px;}`,
      });
      results.push({
        size,
        paddingTop: top,
        f1: score(await mask(await page.screenshot({ omitBackground: true })), target),
      });
      await style.evaluate((el) => el.remove());
    }
  results.sort((a, b) => b.f1 - a.f1);
  await writeFile(
    ".npm-cache/visual-audit/font-calibration.json",
    JSON.stringify(results, null, 2),
  );
  console.log(JSON.stringify(results.slice(0, 5)));
  await studio.getByRole("button", { name: "Ẩn bảng thử / về bình thường", exact: false }).click();
} finally {
  await browser.close();
}
