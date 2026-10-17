import assert from "node:assert/strict";
import { createRequire } from "node:module";
import { resolve } from "node:path";
import { mkdir, readFile } from "node:fs/promises";
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
  for (const p of [page, output])
    p.on("pageerror", (e) => errors.push(String(e)));
  await page.goto(base + "/?page=theme");
  const config = page.locator(".match-config");
  await config.getByLabel("Tên đội", { exact: true }).nth(0).fill("KT");
  await config.getByLabel("Tên đội", { exact: true }).nth(1).fill("T1");
  await config.getByLabel("Tên giải", { exact: true }).fill("YOUR CUP");
  await config
    .getByRole("button", { name: "Không dùng logo", exact: true })
    .nth(0)
    .click();
  await config
    .getByRole("button", { name: "Không dùng logo", exact: true })
    .nth(1)
    .click();
  await config
    .getByRole("button", { name: "Lưu cấu hình", exact: true })
    .click();
  await config
    .getByText("Đã lưu cấu hình.", { exact: true })
    .waitFor();
  await page.goto(base + "/?page=draft");
  await page
    .getByLabel("Layout cấm chọn", { exact: true })
    .selectOption("broadcast");
  await page
    .getByRole("button", { name: "Đưa cấm chọn lên chương trình", exact: true })
    .click();
  await output.goto(base + "/overlay?scene=draft");
  await output.locator(".production-draft").waitFor();
  assert.equal(await output.locator(".live-scoreboard").count(), 0);
  await page.locator(".draft-desk details summary").click();
  await page
    .getByRole("button", { name: "Xóa lượt cấm/chọn", exact: true })
    .click();
  await output.waitForFunction(
    () => document.querySelectorAll(".pick-portrait").length === 0,
  );
  await page.waitForFunction(() =>
    document
      .querySelector(".draft-controls h3")
      ?.textContent.startsWith("Lượt 1/20"),
  );
  const ids = await page
    .getByLabel("Tướng đang hover", { exact: true })
    .locator("option")
    .evaluateAll((els) =>
      els
        .filter((e) => e.value)
        .slice(0, 20)
        .map((e) => e.value),
    );
  for (let i = 0; i < 20; i++) {
    await page
      .getByLabel("Tướng đang hover", { exact: true })
      .selectOption(ids[i]);
    await page
      .getByRole("button", { name: "Khóa & lượt tiếp", exact: true })
      .click();
    await page
      .waitForFunction(
        (step) =>
          document
            .querySelector(".draft-controls h3")
            .textContent.includes(
              step === 20 ? "hoàn tất" : `Lượt ${step + 1}/20`,
            ),
        i + 1,
      )
      .catch(async (error) => {
        throw Error(
          `Draft step ${i + 1}: ${await page.locator(".draft-controls h3").first().textContent()} / ${await page.locator('.draft-desk [role="status"]').textContent()} / ${error.message}`,
        );
      });
  }
  await output
    .locator(".draft-phase", { hasText: "ĐỘI HÌNH HOÀN TẤT" })
    .waitFor();
  assert.equal(await output.locator(".is-picked").count(), 10);
  assert.equal(await output.locator(".draft-ban img").count(), 10);
  assert.equal(
    await page
      .getByRole("button", { name: "Khóa & lượt tiếp", exact: true })
      .isDisabled(),
    true,
  );
  await page.getByLabel("Vị trí B1", { exact: true }).selectOption("1");
  await page.getByRole("button", { name: "Lùi một lượt", exact: true }).click();
  await output.waitForFunction(
    () => document.querySelectorAll(".is-picked").length === 9,
  );
  await page.getByRole("button", { name: "Bỏ lượt", exact: true }).click();
  await output
    .locator(".draft-phase", { hasText: "ĐỘI HÌNH HOÀN TẤT" })
    .waitFor();
  assert.equal(await output.locator(".is-picked").count(), 9);
  await page
    .getByRole("button", { name: "Nạp ảnh mẫu , UI test", exact: true })
    .click();
  await output.locator('.production-draft[data-source="reference"]').waitFor();
  await output.locator('.is-hover img[alt="Ezreal"]').waitFor();
  await page
    .getByRole("button", { name: "Bắt đầu timer", exact: true })
    .click();
  await output.locator(".draft-progress b").waitFor();
  const hoverArt = output.locator('.is-hover .pick-portrait');
  await hoverArt.evaluate(e => { window.__draftHoverArt = e; });
  await output.waitForTimeout(800);
  assert.ok(await hoverArt.evaluate(e => window.__draftHoverArt === e), "Timer ticks must not remount portrait animation");
  assert.equal(await hoverArt.evaluate(e => getComputedStyle(e).animationName), "draft-art-in");
  assert.ok(await output.locator('.draft-lock-flash').count() > 0);
  await output.emulateMedia({reducedMotion:"reduce"});
  assert.equal(await hoverArt.evaluate(e => getComputedStyle(e).animationName), "none");
  await output.emulateMedia({reducedMotion:"no-preference"});
  await output.waitForTimeout(800); // Media change restarts entrance animation.
  const embed = page.frameLocator('iframe[title="Preview cấm chọn OBS"]');
  await embed.locator('.is-hover img[alt="Ezreal"]').waitFor();
  await output.evaluate(() => document.fonts.ready);
  await output.waitForFunction(() =>
    [...document.images].every((i) => i.complete && i.naturalWidth > 0),
  );
  const measurement = await output.evaluate(() => {
    const rect = (s) => {
      const r = document.querySelector(s).getBoundingClientRect();
      return [r.x, r.y, r.width, r.height];
    };
    return {
      draft: rect(".ref-draft"),
      blue: rect(".blue-bans"),
      red: rect(".red-bans"),
      center: rect(".ref-draft-center"),
      hover: rect(".is-hover"),
      reference: document.querySelectorAll('img[src*="references/"]').length,
      controls: document.querySelectorAll("button,input,select").length,
      transparent: getComputedStyle(document.body).backgroundColor,
    };
  });
  assert.deepEqual(measurement.draft, [0, 790, 1920, 290]);
  assert.deepEqual(measurement.blue, [0, 667, 360, 112]);
  assert.deepEqual(measurement.red, [1560, 667, 360, 112]);
  assert.deepEqual(measurement.center, [800, 790, 320, 290]);
  assert.equal(measurement.hover[2], 320);
  assert.equal(measurement.reference, 0);
  assert.equal(measurement.controls, 0);
  assert.equal(measurement.transparent, "rgba(0, 0, 0, 0)");
  await output.screenshot({
    path: ".npm-cache/visual-audit/draft-production.png",
    omitBackground: true,
  });
  await page
    .getByLabel("Layout cấm chọn", { exact: true })
    .selectOption("simple");
  await output.locator(".draft-simple").waitFor();
  await embed.locator(".draft-simple").waitFor();
  await output.waitForTimeout(800);
  await output.waitForFunction(() =>
    [...document.images].every((i) => i.complete && i.naturalWidth > 0),
  );
  assert.ok(
    await output
      .locator(".pick-portrait")
      .evaluateAll(
        (imgs) =>
          imgs.length > 0 &&
          imgs.every((i) => i.src.includes("/splash-centered/")),
      ),
    "Simple must use centered landscape art",
  );
  const simple = await output.evaluate(() => {
    const rect = (s) => {
      const r = document.querySelector(s).getBoundingClientRect();
      return [r.x, r.y, r.width, r.height];
    };
    return {
      blue: rect(".draft-team-0"),
      red: rect(".draft-team-1"),
      header: rect(".ref-draft-center"),
      bans: rect(".blue-bans"),
      widths: [...document.querySelectorAll(".ref-pick")].map(
        (e) => e.getBoundingClientRect().width,
      ),
    };
  });
  assert.deepEqual(simple.blue, [0, 183, 400, 690]);
  assert.deepEqual(simple.red, [1520, 183, 400, 690]);
  assert.deepEqual(simple.header, [0, 0, 1920, 150]);
  assert.deepEqual(simple.bans, [45, 900, 720, 130]);
  assert.ok(
    simple.widths.every((w) => w === 400),
    "Hover must not expand into caster space",
  );
  const shot = await output.screenshot({
    path: ".npm-cache/visual-audit/draft-simple-polished.png",
    omitBackground: true,
  });
  const sharp = createRequire(import.meta.url)(
    resolve(process.env.OVERLAY_BROWSER_PACKAGES, "sharp"),
  );
  const pixels = await sharp(shot)
    .extract({ left: 400, top: 183, width: 1120, height: 690 })
    .ensureAlpha()
    .raw()
    .toBuffer();
  assert.ok(
    pixels.every((v, i) => i % 4 !== 3 || v === 0),
    "Caster camera area must be fully transparent",
  );
  await page
    .getByLabel("Layout cấm chọn", { exact: true })
    .selectOption("broadcast");
  await output.locator(".draft-broadcast").waitFor();
  assert.equal(
    await output
      .locator(".ref-draft")
      .evaluate((e) => e.getBoundingClientRect().y),
    790,
  );
  const downloaded = page.waitForEvent("download");
  await page.getByRole("button", { name: "Export phiên", exact: true }).click();
  const session = await readFile(await (await downloaded).path());
  assert.equal(JSON.parse(session).step, 16);
  await page
    .getByRole("button", { name: "Xóa lượt cấm/chọn", exact: true })
    .click();
  await output.waitForFunction(
    () => document.querySelectorAll(".pick-portrait").length === 0,
  );
  await page.locator('.draft-desk input[type="file"]').setInputFiles({
    name: "draft-session.json",
    mimeType: "application/json",
    buffer: session,
  });
  await output.locator('.is-hover img[alt="Ezreal"]').waitFor();
  await page.setViewportSize({ width: 1280, height: 800 });
  assert.ok(
    await page.evaluate(
      () => document.documentElement.scrollWidth <= innerWidth,
    ),
  );
  assert.deepEqual(errors, []);
  console.log(
    "PASS: 20-turn draft via actual controls, bans/picks/hover/undo/skip/swap, shared preview/OBS, timer, exact regions, assets/fonts, transparent output, 1280px Studio",
    measurement,
  );
} finally {
  await browser.close();
}
