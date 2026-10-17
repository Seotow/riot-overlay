import { createRequire } from "node:module";
import { resolve } from "node:path";
import { readFile, mkdir, writeFile } from "node:fs/promises";
import assert from "node:assert/strict";
import { WebSocket } from "ws";
const require = createRequire(import.meta.url),
  { chromium } = require(resolve(process.env.OVERLAY_BROWSER_PACKAGES, "playwright"));
const base = "http://127.0.0.1:4393",
  id = "2026-10-16T19-49-29-104Z",
  out = resolve(".npm-cache/stack-ui-qa");
await mkdir(out, { recursive: true });
const ws = new WebSocket(base.replace("http", "ws") + "/ws", { origin: base });
let state;
ws.on("message", (b) => {
  const r = JSON.parse(b);
  if (r.type === "snapshot") state = r.state;
});
await new Promise((r, j) => {
  ws.once("open", r);
  ws.once("error", j);
});
const pause = (ms) => new Promise((r) => setTimeout(r, ms)),
  send = (c) => ws.send(JSON.stringify(c));
const until = async (fn) => {
  for (let i = 0; i < 200; i++) {
    if (await fn()) return;
    await pause(100);
  }
  throw Error("Timeout");
};
const browser = await chromium.launch({ headless: true, channel: "msedge" });
const report = [];
try {
  await until(() => state);
  const theme = JSON.parse(await readFile("data/theme.json", "utf8"));
  const before = (await (await fetch(base + "/api/providers")).json()).recording.loadGeneration;
  send({ type: "captureLoad", id });
  await until(async () => {
    const r = (await (await fetch(base + "/api/providers")).json()).recording;
    return r.id === id && r.loadGeneration > before;
  });
  send({ type: "captureControl", playing: false, positionMs: 770346 });
  send({ type: "scene", value: "ingame" });
  const page = await browser.newPage({ viewport: { width: 1920, height: 1080 } });
  const errors = [];
  page.on("pageerror", (e) => errors.push(e.message));
  await page.goto(base + "/overlay?scene=ingame");
  await page.evaluate(() => document.fonts.ready);
  for (const camera of [false, true])
    for (const layout of ["panel", "minimal"]) {
      send({ type: "theme", value: { ...theme, playerCameras: camera } });
      send({
        type: "broadcast",
        value: {
          view: "normal",
          layout,
          inhibitors: "off",
          gold: false,
          levels: false,
          runes: false,
        },
      });
      await pause(1500);
      const values = await page
        .locator(".secondary-stack[data-stack-value]")
        .evaluateAll((es) => es.map((e) => e.getAttribute("data-stack-value")));
      assert.deepEqual(values.sort(), ["32", "77"]);
      const geometry = await page.evaluate(() =>
        [...document.querySelectorAll(".live-player-row")].map((row) => {
          const rect = (s) => row.querySelector(s)?.getBoundingClientRect().toJSON();
          return {
            red: row.classList.contains("red-row"),
            champion: rect(".row-champion"),
            rune: rect(".row-runes"),
            hp: rect(".health-track"),
            ultimate: rect(".minimal-ultimate"),
            badge: rect(".minimal-stack"),
          };
        }),
      );
      if (layout === "panel")
        for (const red of [false, true]) {
          const rows = geometry.filter((r) => r.red === red);
          for (const key of ["champion", "rune", "hp"])
            assert.ok(
              Math.max(...rows.map((r) => r[key].x)) - Math.min(...rows.map((r) => r[key].x)) < 1,
              `${camera}:${key} misaligned`,
            );
        }
      else
        for (const r of geometry.filter((r) => r.badge)) {
          assert.equal(r.badge.width, 26);
          assert.equal(r.badge.height, 26);
          assert.equal(r.ultimate.width, 40);
          assert.ok(Math.abs(r.badge.right - r.ultimate.right) < 0.1);
          assert.ok(r.badge.x >= r.ultimate.x && r.badge.y >= r.ultimate.y);
          assert.ok(
            r.badge.right <= r.ultimate.right + 0.1 && r.badge.bottom <= r.ultimate.bottom + 0.1,
          );
        }
      const tear = page.locator(".item-stack-number").filter({ hasText: "330" });
      assert.ok(await tear.count());
      const style = await tear.first().evaluate((e) => ({
        color: getComputedStyle(e).color,
        background: getComputedStyle(e).backgroundColor,
      }));
      assert.equal(style.color, "rgb(255, 255, 255)");
      assert.equal(style.background, "rgba(0, 0, 0, 0)");
      await page.screenshot({
        path: resolve(out, `${camera ? "camera" : "expanded"}-${layout}.png`),
      });
      report.push({ camera, layout, geometry, style, values });
    }
  const cfg = await browser.newPage();
  await cfg.goto(base + "/?page=config");
  const assets = await page
    .locator(".champion-stack img")
    .evaluateAll((es) =>
      es.map((e) => ({ complete: e.complete, width: e.naturalWidth, src: e.getAttribute("src") })),
    );
  assert.ok(assets.every((a) => a.complete && a.width > 0));
  assert.ok(assets.some((a) => a.src.endsWith("/Veigar.png")));
  assert.deepEqual(errors, []);
  await writeFile(resolve(out, "report.json"), JSON.stringify({ report, assets, errors }, null, 2));
  console.log(
    JSON.stringify({
      pass: true,
      layouts: report.length,
      counts: ["Smolder32", "Veigar77", "Tear330"],
      errors,
    }),
  );
} finally {
  ws.close();
  await browser.close();
}
