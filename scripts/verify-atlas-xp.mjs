import { createRequire } from "node:module";
import { resolve } from "node:path";
import { readFile } from "node:fs/promises";
import assert from "node:assert/strict";
import { WebSocket } from "ws";
const require = createRequire(import.meta.url),
  { chromium } = require(
    resolve(process.env.OVERLAY_BROWSER_PACKAGES, "playwright"),
  );
const base = "http://127.0.0.1:4393",
  id = "2026-10-17T02-41-50-859Z",
  rows = (await readFile(`data/captures/${id}/observer-samples.ndjson`, "utf8"))
    .trim()
    .split(/\r?\n/)
    .map(JSON.parse);
const target = rows.find((r) => r.message.sample.gameTime.value >= 524),
  offset = Date.parse(target.receivedAt) - Date.parse(rows[0].receivedAt);
const w = new WebSocket(base.replace("http", "ws") + "/ws", { origin: base });
await new Promise((r) => w.once("open", r));
const send = (c) => w.send(JSON.stringify(c)),
  pause = (ms) => new Promise((r) => setTimeout(r, ms));
async function until(fn) {
  for (let i = 0; i < 200; i++) {
    if (await fn()) return;
    await pause(100);
  }
  throw Error("timeout");
}
const before = (await (await fetch(base + "/api/providers")).json()).recording
  .loadGeneration;
send({ type: "captureLoad", id });
await until(async () => {
  const r = (await (await fetch(base + "/api/providers")).json()).recording;
  return r.id === id && r.loadGeneration > before;
});
send({ type: "captureControl", positionMs: offset, playing: false });
send({ type: "scene", value: "ingame" });
await until(
  async () =>
    Math.abs(
      (await (await fetch(base + "/api/providers")).json()).recording
        .positionMs - offset,
    ) < 1,
);
const browser = await chromium.launch({ channel: "msedge", headless: true });
try {
  const p = await browser.newPage({ viewport: { width: 1920, height: 1080 } });
  await p.goto(base + "/overlay?scene=ingame");
  await pause(1200);
  await p.evaluate(() => document.fonts.ready);
  assert.equal(
    await p.locator(".recording-watermark,.rehearsal-watermark").count(),
    0,
  );
  assert.doesNotMatch(
    await p.locator("body").innerText(),
    /BẢN GHI \/ KIỂM THỬ|GIẢ LẬP UI|KÍCH HOẠT THỬ/,
  );
  const atlas = p
      .locator(".live-item-slot")
      .filter({ has: p.locator('img[src*="3865"]') }),
    upgrade = p
      .locator(".live-item-slot")
      .filter({ has: p.locator('img[src*="3866"]') });
  assert.equal(await atlas.count(), 1);
  assert.equal(await atlas.locator(".item-stock-number").count(), 0);
  assert.equal(await upgrade.locator(".item-stock-number").innerText(), "1");
  const order = ["top", "jungle", "mid", "bot", "support"];
  const names = await p
    .locator(".live-player-row .row-name > div > b")
    .allTextContents();
  const expected = ["ORDER", "CHAOS"].flatMap((team) =>
    target.message.sample.players
      .filter((x) => x.team.value === team)
      .sort(
        (a, b) =>
          order.indexOf(a.roleQuest.value.role) -
          order.indexOf(b.roleQuest.value.role),
      )
      .map((x) => x.playerName.value.split("#")[0]),
  );
  assert.deepEqual(names, expected);
  const measure = () =>
    p.evaluate(() =>
      [...document.querySelectorAll(".row-name")].map((r) =>
        ["experience", "health", "resource"].map((k) => {
          const e = r.querySelector("." + k + "-track");
          if (!e) return null;
          const b = e.getBoundingClientRect(),
            s = getComputedStyle(e);
          return {
            kind: k,
            x: b.x,
            width: b.width,
            fillWidth:
              b.width -
              parseFloat(s.borderLeftWidth) -
              parseFloat(s.borderRightWidth),
          };
        }),
      ),
    );
  const bars = await measure();
  console.log(JSON.stringify({ atlasHidden: true, upgradeCount: 1, bars }));
  const check = (rows) => {
    for (const row of rows) {
      const valid = row.filter(Boolean);
      for (const b of valid) {
        assert.ok(Math.abs(b.x - valid[0].x) < 0.1);
        assert.ok(Math.abs(b.width - valid[0].width) < 0.1);
        assert.ok(Math.abs(b.fillWidth - valid[0].fillWidth) < 0.1);
      }
    }
  };
  const checkRings = async () => {
    const rings = await p.evaluate(() =>
      [...document.querySelectorAll(".quest-progress")]
        .map((e) => {
          const outer = e.parentElement.getBoundingClientRect(),
            r = e.getBoundingClientRect(),
            c = e.querySelector("circle"),
            m = c.getScreenCTM(),
            center = new DOMPoint(16, 16).matrixTransform(m);
          const body = {
              top: [2, 3, 15, 16],
              jungle: [4, 5, 17, 19],
              mid: [2, 3, 18, 19],
              bot: [5, 6, 19, 19],
              support: [3, 3, 18, 18],
            }[e.parentElement.dataset.role],
            g = e.parentElement
              .querySelector(".role-quest-glyph")
              .getBoundingClientRect(),
            scale = Math.min(g.width / 23, g.height / 24);
          const gx =
              g.x +
              (g.width - 23 * scale) / 2 +
              ((body[0] + body[2]) / 2) * scale -
              outer.x -
              outer.width / 2,
            gy =
              g.y +
              (g.height - 24 * scale) / 2 +
              ((body[1] + body[3]) / 2) * scale -
              outer.y -
              outer.height / 2;
          return {
            size: outer.width,
            w: r.width,
            h: r.height,
            dx: r.x - outer.x,
            dy: r.y - outer.y,
            cx: center.x - outer.x - outer.width / 2,
            cy: center.y - outer.y - outer.height / 2,
            gx,
            gy,
          };
        })
        .filter((x) => x.size > 0),
    );
    for (const r of rings)
      for (const delta of [
        r.w - r.size,
        r.h - r.size,
        r.dx,
        r.dy,
        r.cx,
        r.cy,
        r.gx,
        r.gy,
      ])
        assert.ok(Math.abs(delta) < 0.1, JSON.stringify(r));
    return rings.length;
  };
  if (process.argv.includes("--assert")) check(bars);
  if (process.argv.includes("--assert")) await checkRings();
  await p.screenshot({ path: ".npm-cache/atlas-xp-844.png" });
  if (process.argv.includes("--assert")) {
    const theme = JSON.parse(await readFile("data/theme.json", "utf8"));
    for (const [camera, minimal] of [
      [true, false],
      [false, true],
      [true, true],
    ]) {
      send({ type: "theme", value: { ...theme, playerCameras: camera } });
      send({
        type: "broadcast",
        value: {
          view: minimal ? "minimal" : "normal",
          layout: minimal ? "minimal" : "panel",
          inhibitors: "off",
          gold: false,
          levels: false,
          runes: false,
        },
      });
      await pause(1500);
      check(await measure());
      await checkRings();
      assert.equal(
        await p.locator(".recording-watermark,.rehearsal-watermark").count(),
        0,
      );
    }
    console.log(
      JSON.stringify({
        pass: true,
        layouts: 4,
        playersPerLayout: 10,
        atlasHidden: true,
        upgradesVisible: true,
        ringsAligned: true,
      }),
    );
  }
} finally {
  await browser.close();
  w.close();
}
