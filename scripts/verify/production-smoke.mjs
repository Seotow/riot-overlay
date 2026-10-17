import assert from "node:assert/strict";
import { createRequire } from "node:module";
import { resolve } from "node:path";
import { mkdir } from "node:fs/promises";
import { WebSocket } from "ws";
const base = process.env.OVERLAY_VISUAL_URL;
assert.match(base ?? "", /^http:\/\/127\.0\.0\.1:\d+$/);
assert.ok(!base.endsWith(":4310"), "Isolated backend only");
const { chromium } = createRequire(import.meta.url)(
  resolve(process.env.OVERLAY_BROWSER_PACKAGES, "playwright"),
);
const ws = new WebSocket(base.replace("http", "ws") + "/ws?role=studio", {
  origin: base,
});
await new Promise((done, fail) => {
  ws.once("open", done);
  ws.once("error", fail);
});
const command = (cmd) =>
  new Promise((done, fail) => {
    const timeout = setTimeout(() => {
      ws.off("message", receive);
      fail(Error(`timeout ${cmd.type}`));
    }, 45000);
    const receive = (raw) => {
      const m = JSON.parse(raw);
      if (m.type !== "snapshot" && m.type !== "error") return;
      clearTimeout(timeout);
      ws.off("message", receive);
      m.type === "error" ? fail(Error(m.message)) : done(m.state);
    };
    ws.on("message", receive);
    ws.send(JSON.stringify(cmd));
  });
const browser = await chromium.launch({ channel: "msedge", headless: true });
const errors = [];
const sharp = createRequire(import.meta.url)(
  resolve(process.env.OVERLAY_BROWSER_PACKAGES, "sharp"),
);
async function panelAlpha(page, selector, max = 0.86) {
  const box = await page.locator(selector).first().boundingBox();
  const raw = await sharp(await page.screenshot({ clip: box, omitBackground: true }))
    .ensureAlpha()
    .raw()
    .toBuffer();
  const bins = Array(256).fill(0);
  for (let i = 3; i < raw.length; i += 4) if (raw[i] > 0 && raw[i] < 255) bins[raw[i]]++;
  const mode = bins.indexOf(Math.max(...bins)) / 255;
  assert.ok(mode > 0 && mode <= max, `${selector}: modal opacity ${mode}`);
  return mode;
}
try {
  await command({ type: "mockVisible", value: false });
  await command({
    type: "broadcast",
    value: { view: "normal", inhibitors: "auto" },
  });
  const page = await browser.newPage({
    viewport: { width: 1920, height: 1080 },
  });
  page.on("pageerror", (e) => errors.push(String(e)));
  await page.goto(base + "/?page=theme");
  const config = page.locator(".match-config");
  await config.waitFor();
  assert.equal(await page.locator(".program-monitor:visible").count(), 0);
  await config.getByLabel("Tên giải", { exact: true }).fill("LOCAL CUP");
  await config.getByLabel("Tên đội", { exact: true }).nth(0).fill("LOCAL BLUE");
  await config.getByLabel("Tên đội", { exact: true }).nth(1).fill("LOCAL RED");
  await config.getByLabel("Tỉ số", { exact: true }).nth(0).fill("2");
  await config.getByLabel("Độ đậm nền in-game", { exact: true }).press("Home");
  for (let i = 0; i < 25; i++)
    await config.getByLabel("Độ đậm nền in-game", { exact: true }).press("ArrowRight");
  await config
    .getByLabel("Logo tùy chọn", { exact: false })
    .nth(0)
    .setInputFiles({
      name: "logo.png",
      mimeType: "image/png",
      buffer: Buffer.from(
        "iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAYAAAAfFcSJAAAADUlEQVQIHWP4z8DwHwAFgAI/ScLbtAAAAABJRU5ErkJggg==",
        "base64",
      ),
    });
  await config.getByRole("button", { name: "Lưu cấu hình", exact: true }).click();
  await config.getByText("Backend đã nhận cấu hình", { exact: false }).waitFor();
  const overlay = await browser.newPage({
    viewport: { width: 1920, height: 1080 },
  });
  await overlay.goto(base + "/overlay?scene=ingame");
  await overlay.locator(".team-caption b", { hasText: "LOCAL BLUE" }).waitFor();
  assert.equal(
    await overlay
      .locator(".live-canvas")
      .evaluate((e) => getComputedStyle(e).getPropertyValue("--ingame-panel-opacity").trim()),
    "0.6",
  );
  assert.equal(
    await overlay.locator(".live-scoreboard").evaluate((e) => getComputedStyle(e).backgroundColor),
    "rgba(0, 0, 0, 0)",
  );
  await panelAlpha(overlay, ".live-scoreboard .score-main");
  assert.equal(await overlay.locator(".live-series-pips i.won").count(), 2);
  assert.equal(await overlay.locator(".team-logo").count(), 1);
  assert.equal(await overlay.locator("button,input,.reference,.stage").count(), 0);
  await page.getByRole("button", { name: "Đến bàn điều khiển →" }).click();
  await page.locator(".program-monitor iframe").waitFor();
  const embedded = page.frameLocator(".program-monitor iframe");
  await embedded.locator(".team-caption b", { hasText: "LOCAL BLUE" }).waitFor();
  assert.equal(await page.locator(".operator-card").count(), 6);
  assert.equal(await page.locator(".widget-preview").count(), 5);
  assert.equal(
    await page.getByRole("link", { name: "Cấm chọn →" }).getAttribute("href"),
    "/?page=draft",
  );
  await page.getByRole("button", { name: "Đưa lên chương trình", exact: true }).nth(3).click();
  await overlay.locator(".canvas.minimal").waitFor();
  await embedded.locator(".canvas.minimal").waitFor();
  await page.getByRole("button", { name: "Trở về bảng đầy đủ" }).click();
  await overlay.locator(".canvas.panel").waitFor();
  await mkdir(".npm-cache/visual-audit", { recursive: true });
  await page.screenshot({
    path: ".npm-cache/visual-audit/production-desk.png",
    fullPage: true,
  });
  for (const width of [1920, 1280]) {
    await page.setViewportSize({ width, height: 1080 });
    assert.ok(
      await page.evaluate(() => document.documentElement.scrollWidth <= innerWidth),
      `Overflow at ${width}`,
    );
  }
  assert.deepEqual(errors, []);
  const captures = await (await fetch(base + "/api/captures")).json();
  const capture = captures.find((c) => c.hasState && c.frames > 40);
  assert.ok(capture, "Real capture required for widget preview QA");
  await command({ type: "captureLoad", id: capture.id });
  await command({ type: "captureControl", playing: false });
  await page
    .locator(".operator-card")
    .filter({
      has: page.getByRole("heading", { name: "Leaderboard vàng", exact: true }),
    })
    .getByRole("button")
    .click();
  await overlay.locator('[data-region="gold"]').waitFor();
  await panelAlpha(overlay, '[data-region="gold"]');
  await page.locator('.widget-preview [data-region="gold"]').waitFor();
  await page
    .locator(".operator-card")
    .filter({
      has: page.getByRole("heading", {
        name: "Leaderboard cấp độ",
        exact: true,
      }),
    })
    .getByRole("button")
    .click();
  await overlay.locator('[data-region="levels"]').waitFor();
  await panelAlpha(overlay, '[data-region="levels"]');
  assert.equal(await overlay.locator(".live-level-ranking > div").count(), 10);
  await page.locator('.widget-preview [data-region="levels"]').waitFor();
  await page
    .locator(".operator-card")
    .filter({
      has: page.getByRole("heading", { name: "Rune toàn đội", exact: true }),
    })
    .getByRole("button")
    .click();
  await overlay.locator('[data-region="runes"]').waitFor();
  await panelAlpha(overlay, '[data-region="runes"]');
  await page.locator('.widget-preview [data-region="runes"]').waitFor();
  await page.screenshot({
    path: ".npm-cache/visual-audit/production-data.png",
    fullPage: true,
  });
  await command({
    type: "broadcast",
    value: { view: "normal", inhibitors: "auto" },
  });
  const goldCapture = captures.find((c) => c.id === "2026-09-19T18-57-45-942Z");
  assert.ok(goldCapture, "Pinned real gold-gap sample required");
  await command({ type: "captureLoad", id: goldCapture.id });
  await command({ type: "captureControl", playing: false });
  await page.goto(base + "/?page=theme");
  await page.getByLabel("Độ đậm nền in-game", { exact: true }).press("Home");
  for (let i = 0; i < 49; i++)
    await page.getByLabel("Độ đậm nền in-game", { exact: true }).press("ArrowRight");
  await page.getByLabel("Dành chỗ cam tuyển thủ", { exact: false }).uncheck();
  await page
    .locator(".match-config")
    .getByRole("button", { name: "Lưu cấu hình", exact: true })
    .click();
  await page.getByText("Backend đã nhận cấu hình", { exact: false }).waitFor();
  await overlay.locator(".no-player-cameras").waitFor();
  await panelAlpha(overlay, ".ref-player-table");
  const geometry = await overlay.evaluate(() => {
    const rect = (selector) => {
      const r = document.querySelector(selector).getBoundingClientRect();
      return { x: r.x, y: r.y, width: r.width, height: r.height };
    };
    return {
      table: rect(".ref-player-table"),
      gold: rect(".table-gold"),
      health: [...document.querySelectorAll(".health-track")].map(
        (e) => e.getBoundingClientRect().width,
      ),
      arrows: [...document.querySelectorAll(".lane-gold-arrow")].map((e) => {
        const r = e.getBoundingClientRect(),
          p = e.parentElement.getBoundingClientRect();
        return {
          blue: e.classList.contains("blue"),
          left: r.left,
          right: r.right,
          parentLeft: p.left,
          parentRight: p.right,
        };
      }),
    };
  });
  assert.equal(geometry.table.x, 287);
  assert.equal(geometry.table.width, 1346);
  assert.equal(geometry.gold.x, 927);
  assert.equal(geometry.health.length, 10);
  assert.ok(geometry.health.every((w) => w === 200));
  assert.equal(await overlay.locator(".row-lane-quest").count(), 10);
  assert.ok(
    await overlay
      .locator(
        ".row-lane-quest img, .row-lane-quest .role-quest-icon, .row-lane-quest .quest-unavailable",
      )
      .evaluateAll(
        (els) => els.length === 10 && els.every((e) => getComputedStyle(e).borderRadius === "50%"),
      ),
    "No-camera quest progress and reward must be circular",
  );
  assert.equal(await overlay.locator(".live-scoreboard .role-quest-icon").count(), 0);
  const rowOrder = await overlay.evaluate(() =>
    [...document.querySelectorAll(".live-player-row")].every((row) => {
      const name = row.querySelector(".row-name").getBoundingClientRect();
      const champion = row.querySelector(".row-champion").getBoundingClientRect();
      return (
        getComputedStyle(row.querySelector(".row-name")).order === "0" &&
        (row.classList.contains("red-row")
          ? name.right <= champion.left
          : name.left >= champion.right)
      );
    }),
  );
  assert.ok(rowOrder, "Expanded layout must keep the default row order");
  assert.ok(geometry.arrows.length > 0, "Captured gold differences required");
  for (const a of geometry.arrows)
    assert.ok(
      a.blue ? a.right <= a.parentLeft : a.left >= a.parentRight,
      "Arrow must sit outside the coloured side bar",
    );
  await overlay.screenshot({
    path: ".npm-cache/visual-audit/ingame-translucent.png",
    omitBackground: true,
  });
  await overlay.screenshot({
    path: ".npm-cache/visual-audit/compare-no-camera-translucent.png",
    omitBackground: true,
    clip: { x: 287, y: 821, width: 1346, height: 259 },
  });
  // Clean branding for the illustrative opacity artifact; restore the test config afterwards.
  const visualState = await command({
    type: "broadcast",
    value: { view: "normal", inhibitors: "auto" },
  });
  await command({
    type: "theme",
    value: {
      ...visualState.theme,
      blueName: "KT",
      redName: "T1",
      blueLogo: "",
      redLogo: "",
    },
  });
  await overlay.locator(".team-caption b", { hasText: "KT" }).waitFor();
  await overlay.screenshot({
    path: ".npm-cache/visual-audit/ingame-translucent-preview.png",
    omitBackground: true,
  });
  await command({ type: "theme", value: visualState.theme });
  await overlay.locator(".team-caption b", { hasText: "LOCAL BLUE" }).waitFor();
  await command({
    type: "broadcast",
    value: { view: "minimal", inhibitors: "off" },
  });
  await overlay.locator(".canvas.minimal").waitFor();
  assert.equal(
    await overlay.locator(".ref-player-table").evaluate((e) => e.getBoundingClientRect().width),
    1346,
  );
  await command({
    type: "broadcast",
    value: { view: "normal", inhibitors: "auto" },
  });
  await page.getByLabel("Dành chỗ cam tuyển thủ", { exact: false }).check();
  await page
    .locator(".match-config")
    .getByRole("button", { name: "Lưu cấu hình", exact: true })
    .click();
  await overlay.waitForFunction(
    () => document.querySelector(".ref-player-table")?.getBoundingClientRect().width === 992,
  );
  assert.deepEqual(errors, []);
  assert.equal(await overlay.locator(".row-lane-quest").count(), 0);
  assert.ok((await overlay.locator(".live-scoreboard .role-quest-icon").count()) > 0);
  await overlay.screenshot({
    path: ".npm-cache/visual-audit/compare-camera-translucent.png",
    omitBackground: true,
    clip: { x: 287, y: 821, width: 1346, height: 259 },
  });
  console.log(
    "PASS: actual UI config Save -> OBS + embedded preview, optional raster logo, series scores, operator toggles, disabled scenes, responsive widths",
  );
} finally {
  ws.close();
  await browser.close();
}
