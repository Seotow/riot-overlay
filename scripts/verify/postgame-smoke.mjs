import assert from "node:assert/strict";
import { createRequire } from "node:module";
import { resolve } from "node:path";
import { mkdir } from "node:fs/promises";
const base = process.env.OVERLAY_VISUAL_URL;
assert.match(base ?? "", /^http:\/\/127\.0\.0\.1:\d+$/);
assert.ok(!base.endsWith(":4310"), "Isolated QA backend only");
const { chromium } = createRequire(import.meta.url)(
  resolve(process.env.OVERLAY_BROWSER_PACKAGES, "playwright"),
);
const browser = await chromium.launch({ channel: "msedge", headless: true });
await mkdir(".npm-cache/visual-audit", { recursive: true });
try {
  const context = await browser.newContext({
    viewport: { width: 1920, height: 1080 },
  });
  const page = await context.newPage(),
    output = await context.newPage();
  const errors = [];
  for (const p of [page, output]) p.on("pageerror", (e) => errors.push(String(e)));
  await page.goto(base + "/?page=postgame");
  await page.getByRole("button", { name: "Nạp bộ mẫu theo ảnh", exact: true }).click();
  await output.goto(base + "/overlay?scene=postgame");
  await output.locator('.production-postgame[data-source="sample"]').waitFor();
  await output.evaluate(() => document.fonts.ready);
  await output.waitForFunction(() =>
    [...document.querySelectorAll(".pg-champion")].every(
      (e) => e instanceof HTMLImageElement && e.complete && e.naturalWidth > 0,
    ),
  );
  assert.equal(await output.locator(".pg-champion").count(), 20);
  assert.equal(await output.locator(".pg-damage-row").count(), 5);
  assert.equal(await output.locator(".pg-stat").count(), 8);
  assert.equal(await output.locator(".pg-logo").count(), 0);
  assert.equal(await output.locator(".pg-team.pg-side-0.pg-winner").count(), 1);
  const meters = await output
    .locator(".pg-damage-row")
    .first()
    .locator(".pg-damage-meter")
    .evaluateAll((els) => els.map((e) => e.getBoundingClientRect().width));
  assert.ok(
    Math.abs(meters[0] - meters[1]) < 1 && meters[0] > 300,
    "Damage sides are equally wide, not squeezed into the role column",
  );
  const history = await output.locator(".pg-history").boundingBox(),
    chart = await output.locator(".pg-gold-chart").boundingBox();
  assert.ok(chart.y + chart.height <= history.y + history.height, "Chart stays inside its panel");
  const footer = await output.locator(".pg-footer").boundingBox();
  assert.ok(Math.abs(footer.height - 122) < 1, "Studio footer styles cannot add a top margin");
  assert.equal(
    await output.evaluate(() => document.fonts.check('40px "Broadcast Condensed"')),
    true,
  );
  assert.equal(
    await output.evaluate(() => getComputedStyle(document.body).backgroundColor),
    "rgba(0, 0, 0, 0)",
  );
  await output.screenshot({
    path: ".npm-cache/visual-audit/postgame-sample-v2.png",
    omitBackground: true,
  });
  await page.getByRole("button", { name: "Đổi đội thắng", exact: true }).click();
  await output.locator(".pg-team.pg-side-1.pg-winner").waitFor();
  await page.getByRole("button", { name: "Thử thiếu dữ liệu", exact: true }).click();
  await output.waitForFunction(() => document.querySelectorAll("[data-gold-segment]").length === 2);
  assert.match(await output.locator(".pg-damage-row").nth(2).innerText(), /—/);
  await output.screenshot({
    path: ".npm-cache/visual-audit/postgame-missing-v1.png",
    omitBackground: true,
  });
  await page.locator(".postgame-data summary").click();
  await page.getByLabel("Nhập JSON postgame").setInputFiles({
    name: "invalid.json",
    mimeType: "application/json",
    buffer: Buffer.from('{"source":"live"}'),
  });
  await page.getByRole("alert").waitFor();
  assert.equal(await output.locator("[data-gold-segment]").count(), 2);
  await page.getByRole("button", { name: "Nạp bộ mẫu theo ảnh", exact: true }).click();
  await output.waitForFunction(() => document.querySelectorAll("[data-gold-segment]").length === 1);
  const snapshot = JSON.parse(await page.locator(".postgame-data pre").innerText());
  snapshot.gameNumber = 2;
  await page.getByLabel("Nhập JSON postgame").setInputFiles({
    name: "valid.json",
    mimeType: "application/json",
    buffer: Buffer.from(JSON.stringify(snapshot)),
  });
  await output.waitForFunction(() =>
    document.querySelector(".pg-ribbon")?.textContent.includes("GAME 02"),
  );
  const downloadWait = page.waitForEvent("download");
  await page.getByRole("button", { name: "Xuất JSON mẫu", exact: true }).click();
  assert.equal((await downloadWait).suggestedFilename(), "postgame-sample.json");
  await page.setViewportSize({ width: 1280, height: 800 });
  assert.ok(await page.evaluate(() => document.documentElement.scrollWidth <= innerWidth));
  const frame = page.frameLocator('iframe[title="Preview postgame OBS"]');
  assert.equal(await frame.locator(".pg-stat").count(), 8);
  await output.setViewportSize({ width: 1280, height: 720 });
  await output.waitForFunction(() => {
    const r = document.querySelector(".production-postgame")?.getBoundingClientRect();
    return r && Math.abs(r.width - 1280) < 1 && Math.abs(r.height - 720) < 1;
  });
  const bounds = await output.locator(".production-postgame").boundingBox();
  assert.ok(Math.abs(bounds.width - 1280) < 1 && Math.abs(bounds.height - 720) < 1);
  await output.screenshot({
    path: ".npm-cache/visual-audit/postgame-1280-v1.png",
    omitBackground: true,
  });
  await page.getByRole("button", { name: "Xóa bộ mẫu", exact: true }).click();
  await output.locator(".pg-empty").waitFor();
  await page.getByRole("button", { name: "Nạp bộ mẫu theo ảnh", exact: true }).click();
  assert.deepEqual(errors, []);
  console.log(
    "PASS postgame: shared Studio/OBS, fonts/assets, 10 players/bans, winner, missing/gaps, JSON validation, 1920/1280, empty state",
  );
} finally {
  await browser.close();
}
