// UI-only lab: Replay render writes are intercepted, never sent to a game.
import assert from "node:assert/strict";
import { createRequire } from "node:module";
import { resolve } from "node:path";
import { readFile, mkdir } from "node:fs/promises";
import { renderToStaticMarkup } from "react-dom/server";
import { createElement } from "react";
import { BroadcastKillfeed } from "../../src/overlay/BroadcastKillfeed";
import { normalizeIngame } from "../../server/ingame-adapter";
import { createState } from "../../shared/mock";
import { defaultHud } from "../../shared/replay-hud";
import { liveCatalog } from "../../shared/live-assets";
import type { ObservedEvent } from "../../shared/observer";
const base = process.env.OVERLAY_VISUAL_URL!;
assert.match(base ?? "", /^http:\/\/127\.0\.0\.1:\d+$/);
assert.ok(!base.endsWith(":4310"));
const { chromium } = createRequire(import.meta.url)(
  resolve(process.env.OVERLAY_BROWSER_PACKAGES!, "playwright"),
);
const browser = await chromium.launch({ channel: "msedge", headless: true });
try {
  const page = await browser.newPage({
    viewport: { width: 1920, height: 1080 },
  });
  const errors: string[] = [];
  page.on("pageerror", (e: Error) => errors.push(String(e)));
  let writes = 0,
    fields = { ...defaultHud, interfaceFrames: true };
  await page.route(base + "/api/replay-hud/**", async (route: any) => {
    if (route.request().method() === "POST") {
      writes++;
      fields = { ...fields, ...route.request().postDataJSON() };
    }
    await route.fulfill({
      contentType: "application/json",
      body: JSON.stringify({
        connected: true,
        fields,
        verified: true,
        unsupported: [],
        mismatched: [],
      }),
    });
  });
  await page.goto(base + "/?page=hud");
  await page.getByRole("button", { name: "Áp dụng vào game đang mở" }).waitFor();
  await page.waitForFunction(
    () =>
      [...document.querySelectorAll("button")].some(
        (b) => b.textContent?.includes("Áp dụng vào game đang mở") && !b.disabled,
      ),
    undefined,
    { timeout: 10000 },
  );
  assert.equal(writes, 0);
  assert.equal(await page.locator(".hud-option input:disabled").count(), 4);
  await page.getByRole("button", { name: "Lưu preset HUD", exact: true }).click();
  await page.getByText("Đã lưu preset vào cấu hình.", { exact: false }).waitFor();
  assert.equal(writes, 0, "Save must not apply");
  await page.getByRole("button", { name: "Áp dụng vào game đang mở" }).click();
  await page.getByText("API đã xác nhận", { exact: false }).waitFor();
  assert.equal(writes, 1);
  await page.reload();
  assert.equal(writes, 1, "Reload must not apply");
  await mkdir(".npm-cache/visual-audit", { recursive: true });
  await page
    .locator(".replay-hud h2")
    .evaluate((e: Element) => e.append(" · UI TEST / API GIẢ LẬP"));
  await page.screenshot({
    path: ".npm-cache/visual-audit/hud-config-lab.png",
    fullPage: true,
  });
  await page.goto(base + "/?page=theme");
  await page.getByLabel("Kiểu killfeed", { exact: false }).selectOption("broadcast");
  await page.getByRole("button", { name: "Lưu cấu hình", exact: true }).click();
  await page.getByText("Backend đã nhận cấu hình", { exact: false }).waitFor();
  await page.reload();
  assert.equal(await page.getByLabel("Kiểu killfeed", { exact: false }).inputValue(), "broadcast");

  const sample = normalizeIngame(
    {
      gameData: { gameTime: 100 },
      allPlayers: [
        "Aurora",
        "Yunara",
        "Hecarim",
        "Fizz",
        "Galio",
        "Pantheon",
        "Nasus",
        "Ashe",
        "Sion",
        "Malphite",
      ].map((name, i) => ({
        championId: Object.values(liveCatalog.champions).find((c) => c.name === name)!.key,
        team: i < 5 ? "ORDER" : "CHAOS",
        items: [],
      })),
    },
    null,
    new Date().toISOString(),
  );
  const events: ObservedEvent[] = [
    {
      id: 1,
      at: 100,
      kind: "ChampionKill",
      team: "ORDER",
      killerSlot: 2,
      victimSlot: 5,
      assistSlots: [0, 1],
    },
    {
      id: 2,
      at: 100,
      kind: "InhibKilled",
      team: "CHAOS",
      killerSlot: 7,
      assistSlots: [6],
    },
    {
      id: 3,
      at: 100,
      kind: "BaronKill",
      team: "ORDER",
      killerSlot: 2,
      assistSlots: [0, 3],
    },
    {
      id: 4,
      at: 100,
      kind: "DragonKill",
      objectiveType: "earth",
      team: "CHAOS",
      killerSlot: 6,
    },
  ];
  const html = renderToStaticMarkup(
    createElement(BroadcastKillfeed, {
      events,
      sample,
      theme: createState().theme,
    }),
  );
  const css = (await readFile("dist/index.html", "utf8")).match(/href="([^"]+\.css)"/)![1];
  await page.route(base + "/__feed-lab", async (route: any) =>
    route.fulfill({
      contentType: "text/html",
      body: `<!doctype html><meta charset="utf-8"><link rel="stylesheet" href="${css}"><body class="overlay-body"><div class="canvas ref-canvas live-canvas" style="--blue:#1687d2;--red:#d12a38;--panel:#101820">${html}<span style="position:absolute;right:24px;top:124px;font:12px sans-serif;color:#c8c8c8">UI FIXTURE · NOT LIVE EVENTS</span></div>`,
    }),
  );
  await page.goto(base + "/__feed-lab");
  await page.evaluate(() => document.fonts.ready);
  await page.waitForFunction(() =>
    [...document.images].every((i) => i.complete && i.naturalWidth > 0),
  );
  assert.equal(await page.locator(".broadcast-feed-row").count(), 4);
  assert.match(
    await page
      .locator(".feed-kill-mark")
      .first()
      .evaluate((e: Element) => getComputedStyle(e).maskImage),
    /all-in-ping\.png/,
  );
  assert.equal(
    await page
      .locator(".feed-kill-mark")
      .first()
      .evaluate((e: Element) => getComputedStyle(e).backgroundColor),
    "rgb(255, 255, 255)",
  );
  const blueBackground = await page
    .locator(".broadcast-feed-row.blue")
    .first()
    .evaluate((e: Element) => getComputedStyle(e).backgroundImage);
  const redBackground = await page
    .locator(".broadcast-feed-row.red")
    .first()
    .evaluate((e: Element) => getComputedStyle(e).backgroundImage);
  assert.notEqual(blueBackground, redBackground);
  assert.match(blueBackground, /0\.34/);
  assert.match(redBackground, /0\.34/);
  assert.equal(
    await page
      .locator(".feed-objective-icon")
      .first()
      .evaluate((e: Element) => getComputedStyle(e).backgroundColor),
    "rgb(255, 255, 255)",
  );
  assert.ok(
    await page
      .locator(".broadcast-killfeed")
      .evaluate((e: Element) => e.getBoundingClientRect().right === 1898),
  );
  await page.screenshot({
    path: ".npm-cache/visual-audit/killfeed-broadcast-lab.png",
    clip: { x: 1370, y: 115, width: 550, height: 245 },
    omitBackground: true,
  });
  assert.deepEqual(errors, []);
  console.log(
    "PASS HUD manual apply only (intercepted fixture), locked announcements, save/reload; killfeed style persistence, old roster artwork, white masks and top-right geometry",
  );
} finally {
  await browser.close();
}
