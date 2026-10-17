// Explicit synthetic visual fixture for boundary cases; never a real match capture.
import assert from "node:assert/strict";
import { createRequire } from "node:module";
import { resolve } from "node:path";
import { readFile, mkdir } from "node:fs/promises";
import { createElement } from "react";
import { renderToStaticMarkup } from "react-dom/server";
import { WebSocket } from "ws";
import { LiveOverlay } from "../../src/overlay/LiveOverlay";
import { normalizeIngame } from "../../server/ingame-adapter";
import { ObserverSession } from "../../server/observer-session";
import { liveCatalog } from "../../shared/live-assets";
import { createState } from "../../shared/mock";

const base = process.env.OVERLAY_VISUAL_URL!;
assert.match(base ?? "", /^http:\/\/127\.0\.0\.1:\d+$/);
assert.ok(!base.endsWith(":4310"));
const { chromium } = createRequire(import.meta.url)(
  resolve(process.env.OVERLAY_BROWSER_PACKAGES!, "playwright"),
);
const browser = await chromium.launch({ channel: "msedge", headless: true });
const ws = new WebSocket(base.replace("http", "ws") + "/ws?role=studio", {
  origin: base,
});
await new Promise<void>((done, fail) => {
  ws.once("open", done);
  ws.once("error", fail);
});
const errors: string[] = [];
try {
  const config = await browser.newPage({
    viewport: { width: 1920, height: 1080 },
  });
  config.on("pageerror", (e: Error) => errors.push(String(e)));
  await config.goto(base + "/?page=theme");
  const png = Buffer.from(
    "iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAYAAAAfFcSJAAAADUlEQVQIHWP4z8DwHwAFgAI/ScLbtAAAAABJRU5ErkJggg==",
    "base64",
  );
  for (const label of ["Logo giữa thanh tỉ số", "Logo giữa hai đội tối giản"]) {
    await config.getByLabel(label, { exact: false }).setInputFiles({
      name: "center.png",
      mimeType: "image/png",
      buffer: png,
    });
  }
  await config.getByLabel("Thể thức loạt trận").selectOption("2");
  await config.getByLabel("Tên đội", { exact: true }).nth(0).fill("TEAM A");
  await config.getByLabel("Tên đội", { exact: true }).nth(1).fill("TEAM B");
  await config.getByLabel("Tỉ số", { exact: true }).nth(0).fill("1");
  await config.getByLabel("Tỉ số", { exact: true }).nth(1).fill("2");
  await config.getByRole("button", { name: "Đổi bên xanh ↔ đỏ", exact: true }).click();
  assert.equal(await config.getByLabel("Tên đội", { exact: true }).nth(0).inputValue(), "TEAM B");
  assert.equal(await config.getByLabel("Tỉ số", { exact: true }).nth(0).inputValue(), "2");
  await config.getByRole("button", { name: "Lưu cấu hình", exact: true }).click();
  await config.getByText("Backend đã nhận cấu hình", { exact: false }).waitFor();
  const obs = await browser.newPage({
    viewport: { width: 1920, height: 1080 },
  });
  await obs.goto(base + "/overlay?scene=ingame");
  await obs.locator(".live-versus img").waitFor();
  assert.equal(await obs.locator(".live-series-pips i").count(), 4);
  assert.equal(await obs.locator(".side-blue .live-series-pips i.won").count(), 2);
  const colors = await obs
    .locator(".side-blue .live-series-pips i.won")
    .first()
    .evaluate((e: Element) => ({
      fill: getComputedStyle(e).backgroundColor,
      side: getComputedStyle(e).getPropertyValue("--blue"),
    }));
  assert.ok(colors.fill !== "rgb(255, 255, 255)");
  await config.getByLabel("Thể thức loạt trận").selectOption("3");
  await config.getByRole("button", { name: "Lưu cấu hình", exact: true }).click();
  await obs.waitForFunction(() => document.querySelectorAll(".live-series-pips i").length === 6);
  await config.reload();
  assert.equal(await config.getByLabel("Thể thức loạt trận").inputValue(), "3");
  assert.equal(await config.locator('img[alt="Logo giữa thanh tỉ số"]').count(), 1);

  const css = (await readFile("dist/index.html", "utf8")).match(/href="([^"]+\.css)"/)![1];
  const at = "2026-10-16T00:00:00.000Z",
    now = Date.parse(at);
  const observed = <T>(value: T) => ({
    value,
    availability: "observed" as const,
    source: "leaguebroadcast" as const,
    observedAt: at,
  });
  const sample = normalizeIngame(
    {
      gameData: { gameTime: 100 },
      allPlayers: Array.from({ length: 10 }, (_, i) => ({
        team: i < 5 ? "ORDER" : "CHAOS",
        items: [],
        level: 16,
      })),
    },
    null,
    at,
  );
  sample.assetVersion = liveCatalog.version;
  sample.players.forEach((p, i) => {
    p.championId = observed([266, 120, 103, 222, 412, 58, 64, 7, 145, 111][i]);
    p.spells = observed(["SummonerFlash", i === 0 ? "SummonerTeleport" : "SummonerHeal"]);
    p.health = observed({ current: 900, max: 1200 });
    p.resource = observed({ current: 500, max: 1000 });
    p.inventory = observed(
      [3152, 3157, 3026, 3142, 2003].map((id, slot) => ({
        id,
        slot,
        count: 1,
      })),
    );
    p.cooldowns = observed(
      [3152, 3157, 3026, 3142, 2003].map((id, slot) => ({
        id,
        slot: String(slot),
        kind: "item" as const,
        readyAt: 105,
        total: 90,
      })),
    );
    p.roleQuest = observed({
      role: "top" as const,
      completed: true,
      itemId: 1220,
      progress: 1,
      rewardItemId: null,
      rewardSpellId: "S12_SummonerTeleportUpgrade",
    });
  });
  const fixture = await browser.newPage({
    viewport: { width: 1920, height: 1080 },
  });
  // tsx preserves function names; Playwright serializes nested callbacks.
  await fixture.addInitScript("window.__name = (fn) => fn;");
  await mkdir(".npm-cache/visual-audit", { recursive: true });
  for (const cameras of [true, false])
    for (const completed of [true, false]) {
      sample.players.forEach((p) => (p.roleQuest!.value!.completed = completed));
      const html = renderToStaticMarkup(
        createElement(LiveOverlay, {
          theme: {
            ...createState().theme,
            playerCameras: cameras,
            variant: "minimal",
          },
          frame: new ObserverSession().ingest(sample, "visual-synthetic", at),
          now,
        }),
      );
      await fixture.route(base + "/__minimal-fixture", async (route: any) =>
        route.fulfill({
          contentType: "text/html",
          body: `<!doctype html><html><head><meta charset="utf-8"><link rel="stylesheet" href="${css}"></head><body class="overlay-body" style="margin:0;background:transparent"><div class="canvas ref-canvas live-canvas minimal ${cameras ? "" : "no-player-cameras"}" style="--blue:#1687d2;--red:#d12a38;--accent:#d8bc7e;--panel:#101820;--ingame-panel-opacity:.84;--display-font:'Broadcast Condensed';--body-font:'Spiegel'"><div class="ref-graphics">${html}</div></div><p style="position:absolute;top:820px;color:#bbb;font:14px sans-serif">SYNTHETIC UI FIXTURE · NOT LIVE DATA</p></body></html>`,
        }),
      );
      await fixture.goto(base + "/__minimal-fixture");
      await fixture.evaluate(() => document.fonts.ready);
      await fixture.locator(".row-champion img").first().waitFor();
      await fixture.waitForFunction(() => [...document.images].every((i) => i.complete));
      await fixture.waitForTimeout(1200); // Measure settled layout, not center-out entry scale.
      const geometry = await fixture.evaluate(() => {
        const rect = (e: Element) => {
          const r = e.getBoundingClientRect();
          return {
            x: r.x,
            y: r.y,
            w: r.width,
            h: r.height,
            right: r.right,
            bottom: r.bottom,
          };
        };
        return {
          table: rect(document.querySelector(".ref-player-table")!),
          rows: [...document.querySelectorAll(".live-player-row")].map((row) => ({
            red: row.classList.contains("red-row"),
            champion: rect(row.querySelector(".row-champion")!),
            stats: rect(row.querySelector(".row-name")!),
            spells: [...row.querySelectorAll(".row-spells .live-spell-slot")].map(rect),
            items: [...row.querySelectorAll(".minimal-active-item,.minimal-quest-reward")].map(
              (e) => ({
                pos: e.getAttribute("data-position"),
                ...rect(e),
              }),
            ),
          })),
          images: [...document.images]
            .filter((i) => !i.complete || !i.naturalWidth)
            .map((i) => i.src),
          oldItems: [...document.querySelectorAll(".row-items")].every(
            (e) => getComputedStyle(e).display === "none",
          ),
        };
      });
      assert.equal(geometry.table.w, cameras ? 992 : 1346);
      assert.deepEqual(geometry.images, []);
      assert.equal(geometry.oldItems, true);
      for (const row of geometry.rows) {
        assert.equal(row.items.length, completed ? 4 : 3);
        assert.equal(row.items[0].pos, "0");
        for (const item of row.items)
          assert.ok(row.red ? item.x >= row.champion.right : item.right <= row.champion.x);
        assert.equal(row.champion.w, 58);
        assert.equal(row.champion.h, 58);
        assert.equal(row.spells.length, 2);
        assert.equal(row.spells[0].w + row.spells[1].w, row.champion.w);
        assert.equal(row.spells[0].bottom, row.champion.y);
        assert.equal(row.stats.y, row.champion.bottom);
        assert.equal(row.stats.h, 29);
        for (const item of row.items) {
          assert.equal(item.w, 29);
          assert.equal(item.h, 29);
        }
        if (completed) {
          assert.equal(row.items[1].y, row.champion.y);
          assert.equal(row.items[2].bottom, row.champion.bottom);
          assert.equal(row.items[3].y, row.stats.y);
          assert.equal(row.items[3].bottom, row.stats.bottom);
        } else assert.equal(row.items[0].bottom, row.champion.y);
      }
      await fixture.screenshot({
        path: `.npm-cache/visual-audit/minimal-${cameras ? "camera" : "no-camera"}-${completed ? "complete" : "pending"}.png`,
        omitBackground: true,
      });
      console.log(
        `PASS minimal ${cameras ? "camera" : "no-camera"} ${completed ? "complete" : "pending"}: width ${geometry.table.w}, mirrored loadouts, no broken assets`,
      );
      await fixture.unroute(base + "/__minimal-fixture");
    }
  assert.deepEqual(errors, []);
  console.log("PASS config PNG upload, BO3/BO5, swap + scores, backend save/reload and OBS sync");
} finally {
  ws.close();
  await browser.close();
}
