// Isolated browser QA against our own local app, never a personal browser profile.
import { createRequire } from "node:module";
import { resolve } from "node:path";
import { readFile, mkdir, writeFile } from "node:fs/promises";
import assert from "node:assert/strict";
import { WebSocket } from "ws";
const require = createRequire(import.meta.url);
const { chromium } = require(resolve(process.env.OVERLAY_BROWSER_PACKAGES, "playwright"));
const base = "http://127.0.0.1:4393",
  id = "2026-10-16T19-21-14-286Z";
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
const pause = (ms) => new Promise((r) => setTimeout(r, ms));
const send = (c) => ws.send(JSON.stringify(c));
const until = async (fn) => {
  for (let i = 0; i < 200; i++) {
    if (await fn()) return;
    await pause(100);
  }
  throw Error("QA condition timeout");
};
const out = resolve(".npm-cache/name-ranking-qa");
await mkdir(out, { recursive: true });
const browser = await chromium.launch({ headless: true, channel: "msedge" });
try {
  await until(() => state);
  const theme = JSON.parse(await readFile("data/theme.json", "utf8"));
  send({ type: "theme", value: { ...theme, playerCameras: false } });
  send({ type: "captureLoad", id });
  await until(
    async () => (await (await fetch(base + "/api/providers")).json()).recording.id === id,
  );
  send({ type: "captureControl", playing: false, positionMs: 770346 });
  send({ type: "scene", value: "ingame" });
  send({
    type: "broadcast",
    value: {
      view: "normal",
      inhibitors: "off",
      layout: "panel",
      gold: true,
      levels: true,
      runes: false,
    },
  });
  const page = await browser.newPage({
    viewport: { width: 1920, height: 1080 },
    deviceScaleFactor: 1,
  });
  const errors = [];
  page.on("pageerror", (e) => errors.push(e.message));
  await page.goto(base + "/overlay?scene=ingame");
  await page.evaluate(() => document.fonts.ready);
  await page.locator('.row-name b[title="Seotoww"]').waitFor();
  await pause(1400);
  const metrics = await page.evaluate(() => {
    const xp = [...document.querySelectorAll(".live-level-ranking .rank-content")];
    return {
      xpRows: xp.length,
      percentages: xp.map((e) => e.querySelector(".xp-percent").textContent),
      levelBoxes: xp.map((e) => {
        const b = e.querySelector(".rank-level"),
          s = getComputedStyle(b);
        return { border: s.borderTopWidth, box: b.getBoundingClientRect().toJSON() };
      }),
      blue: getComputedStyle(document.querySelector(".canvas"))
        .getPropertyValue("--broadcast-blue")
        .trim(),
      red: getComputedStyle(document.querySelector(".canvas"))
        .getPropertyValue("--broadcast-red")
        .trim(),
      tracks: [...document.querySelectorAll(".ranking-track,.level-progress")].map((e) => {
        const s = getComputedStyle(e);
        return { border: s.borderTopWidth, background: s.backgroundColor };
      }),
    };
  });
  assert.equal(metrics.xpRows, 10);
  assert.equal(metrics.blue, "#0373e0");
  assert.equal(metrics.red, "#ba191c");
  assert.ok(metrics.percentages.some((s) => /^\d+%$/.test(s)));
  assert.ok(metrics.levelBoxes.every((b) => b.border === "1px"));
  await page.screenshot({ path: resolve(out, "leaderboards.png") });
  const runes = [];
  for (const layout of ["panel", "minimal"]) {
    send({
      type: "broadcast",
      value: { view: "normal", inhibitors: "off", layout, gold: false, levels: false, runes: true },
    });
    await page.locator('[data-region="runes"]').waitFor();
    await pause(1600);
    assert.equal(await page.locator('[data-region="players"]').count(), 0);
    const geometry = await page.evaluate(() =>
      [...document.querySelectorAll(".rune-card")].map((card) => {
        const c = card.getBoundingClientRect(),
          icons = [...card.querySelectorAll(".rune-grid > *")];
        return {
          count: icons.length,
          bottom: c.bottom,
          last: Math.max(...icons.map((e) => e.getBoundingClientRect().bottom)),
        };
      }),
    );
    assert.equal(geometry.length, 10);
    assert.ok(geometry.every((g) => g.last <= g.bottom && g.bottom <= 1080));
    const branding = await page.evaluate(() =>
      [...document.querySelectorAll(".rune-team-brand")].map((e) => ({
        color: getComputedStyle(e).color,
        logo: e.querySelector("img")?.getBoundingClientRect().toJSON() ?? null,
      })),
    );
    assert.equal(branding.length, 2);
    const rgb = (hex) =>
      `rgb(${[1, 3, 5].map((i) => parseInt(hex.slice(i, i + 2), 16)).join(", ")})`;
    assert.equal(branding[0].color, rgb(theme.blue));
    assert.equal(branding[1].color, rgb(theme.red));
    await page.screenshot({ path: resolve(out, `runes-${layout}.png`) });
    runes.push({ layout, geometry, branding });
    send({ type: "broadcastWidget", key: "runes", value: false });
    await page.locator('[data-region="players"]').waitFor();
    await pause(650);
    assert.equal(await page.locator(".canvas.minimal").count(), layout === "minimal" ? 1 : 0);
  }
  // Exercise actual React alert paths using explicit UI previews, not fabricated telemetry.
  send({
    type: "broadcast",
    value: {
      view: "normal",
      inhibitors: "off",
      layout: "panel",
      runes: false,
      gold: false,
      levels: false,
    },
  });
  const rows = (await readFile(`data/captures/${id}/observer-samples.ndjson`, "utf8"))
    .trim()
    .split(/\r?\n/)
    .map(JSON.parse);
  const q = rows.findIndex((r) =>
    r.message.sample.events.some((e) => e.kind === "RoleQuestCompleted"),
  );
  assert.ok(q > 2);
  const offset = Date.parse(rows[q - 2].receivedAt) - Date.parse(rows[0].receivedAt);
  send({ type: "rehearsal", value: "clear" });
  send({ type: "captureControl", playing: false, positionMs: offset });
  await pause(250);
  send({ type: "captureControl", playing: true });
  await page.locator(".quest-completion").first().waitFor();
  await pause(700);
  send({ type: "captureControl", playing: false });
  const quest = await page
    .locator(".quest-completion")
    .first()
    .evaluate((e) => ({
      background: getComputedStyle(e, "::before").backgroundColor,
      bgAnimation: getComputedStyle(e, "::before").animationName,
      copyAnimation: getComputedStyle(e.querySelector("strong")).animationName,
    }));
  assert.equal(quest.bgAnimation, "portrait-back");
  assert.equal(quest.copyAnimation, "portrait-copy");
  await page.screenshot({ path: resolve(out, "quest-panel.png") });
  send({ type: "broadcastWidget", key: "minimal", value: true });
  await pause(150);
  assert.equal(await page.locator(".quest-completion").first().isVisible(), false);
  send({ type: "rehearsal", value: "baron" });
  await pause(550);
  assert.equal(await page.locator(".live-event-banner").count(), 0);
  send({ type: "rehearsal", value: "dragon", variant: { dragon: "earth" } });
  await pause(700);
  assert.equal(await page.locator(".live-event-banner").count(), 0);
  assert.ok(await page.locator(".dragon-event-strip").count());
  assert.deepEqual(errors, []);
  await writeFile(
    resolve(out, "report.json"),
    JSON.stringify({ metrics, runes, quest, errors }, null, 2),
  );
  console.log(
    JSON.stringify({
      pass: true,
      xpRows: metrics.xpRows,
      colors: [metrics.blue, metrics.red],
      runeLayouts: runes.length,
      quest,
      errors,
    }),
  );
} finally {
  ws.close();
  await browser.close();
}
