// Read-only geometry check on the selected real source; never enables demo.
import assert from "node:assert/strict";
import { createRequire } from "node:module";
import { resolve } from "node:path";
const base = process.env.OVERLAY_VISUAL_URL;
assert.match(base ?? "", /^http:\/\/127\.0\.0\.1:\d+$/);
const { chromium } = createRequire(import.meta.url)(
  resolve(process.env.OVERLAY_BROWSER_PACKAGES, "playwright"),
);
const browser = await chromium.launch({ channel: "msedge", headless: true });
try {
  const page = await browser.newPage({ viewport: { width: 1920, height: 1080 } }),
    errors = [];
  page.on("pageerror", (e) => errors.push(String(e)));
  await page.goto(base + "/overlay?scene=ingame");
  await page.locator(".canvas.no-player-cameras").waitFor();
  const box = await page.locator(".ref-player-table").boundingBox();
  assert.equal(box.x, 287);
  assert.equal(box.width, 1346);
  assert.equal(await page.locator(".live-player-row").count(), 10);
  assert.equal(await page.locator(".reference,.stage").count(), 0);
  assert.deepEqual(errors, []);
  console.log(
    JSON.stringify({
      layout: "expanded-no-camera",
      table: box,
      rows: 10,
      referenceBackground: false,
      gameDataVerified: false,
    }),
  );
} finally {
  await browser.close();
}
