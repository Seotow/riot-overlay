// QA backend only. Never changes the operator's theme or recording controls.
import { readFile, mkdir } from "node:fs/promises";
import { resolve } from "node:path";
import { createRequire } from "node:module";
import assert from "node:assert/strict";
import { WebSocket } from "ws";
const require = createRequire(import.meta.url);
const { chromium } = require(resolve(process.env.OVERLAY_BROWSER_PACKAGES, "playwright"));
const id = process.argv[2];
assert.match(id, /^\d{4}-/);
const records = JSON.parse(
  "[" +
    (await readFile(`data/captures/${id}/observer-samples.ndjson`, "utf8"))
      .trim()
      .split(/\r?\n/)
      .join(",") +
    "]",
);
const old = (
  await readFile("data/captures/2026-10-16T19-49-29-104Z/observer-samples.ndjson", "utf8")
)
  .trim()
  .split(/\r?\n/)
  .map(JSON.parse);
assert.equal(records.length, old.length);
for (let i = 0; i < records.length; i++) {
  const current = structuredClone(records[i]);
  delete current.message.sample.pitTimers;
  assert.deepEqual(current, old[i]);
}
const base = "http://127.0.0.1:4393",
  ws = new WebSocket(base.replace("http", "ws") + "/ws", { origin: base });
let state, observed;
ws.on("message", (b) => {
  const m = JSON.parse(b);
  if (m.type === "snapshot") state = m.state;
  if (m.type === "observer") observed = m.frame.sample;
});
await new Promise((r, j) => {
  ws.once("open", r);
  ws.once("error", j);
});
const pause = (ms) => new Promise((r) => setTimeout(r, ms));
async function until(fn) {
  for (let i = 0; i < 150; i++) {
    if (await fn()) return;
    await pause(100);
  }
  throw Error("timeout");
}
const send = (c) => ws.send(JSON.stringify(c));
const previous = (await (await fetch(base + "/api/providers")).json()).recording.loadGeneration;
send({ type: "captureLoad", id });
await until(async () => {
  const r = (await (await fetch(base + "/api/providers")).json()).recording;
  return r.id === id && r.loadGeneration > previous;
});
send({ type: "scene", value: "ingame" });
const browser = await chromium.launch({ channel: "msedge", headless: true });
const page = await browser.newPage({ viewport: { width: 1920, height: 1080 } }),
  results = [];
await mkdir(".npm-cache/living-dragon-qa", { recursive: true });
try {
  await page.goto(base + "/overlay?scene=ingame");
  for (const [time, type, alive] of [
    [30, "chemtech", false],
    [280, "chemtech", false],
    [300, "chemtech", true],
    [435, "hextech", false],
    [530, "hextech", true],
    [550, "earth", false],
    [570, "earth", true],
    [690, "elder", false],
    [705, "elder", true],
  ]) {
    const record = records.find((x) => x.message.sample.gameTime.value >= time),
      sample = record.message.sample;
    assert.equal(sample.pitTimers?.[0]?.type.value ?? null, type);
    assert.equal(sample.pitTimers?.[0]?.isAlive?.value === true, alive);
    const offset = Date.parse(record.receivedAt) - Date.parse(records[0].receivedAt);
    send({ type: "captureControl", playing: false, positionMs: offset });
    await until(
      async () =>
        Math.abs(
          (await (await fetch(base + "/api/providers")).json()).recording.positionMs - offset,
        ) < 1,
    );
    await pause(1000);
    const text = await page.locator(".live-objective-stack").innerText();
    const labels = await page
      .locator(".live-objective")
      .evaluateAll((nodes) => nodes.map((n) => n.title).join("|"));
    if (type) {
      assert.ok(
        !labels.includes("CHƯA RÕ"),
        JSON.stringify({
          labels,
          time: observed?.gameTime,
          pit: observed?.pitTimers,
        }),
      );
    } else assert.ok(labels.includes("CHƯA RÕ"), labels);
    await until(async () => {
      const width = await page
        .locator('[data-pit="dragon"]')
        .evaluate((e) => e.getBoundingClientRect().width);
      return Math.abs(width - (alive ? 46 : 103)) < 0.05;
    });
    const metrics = await page.locator('[data-pit="dragon"]').evaluate((e) => {
      const rect = (x) => {
        const r = x.getBoundingClientRect();
        return { w: r.width, h: r.height };
      };
      return {
        available: e.dataset.available,
        panel: rect(e),
        square: rect(e.querySelector(":scope > span")),
        icon: rect(e.querySelector(".metric-icon")),
        background: getComputedStyle(e.querySelector(":scope > span")).backgroundColor,
      };
    });
    assert.ok(!text.includes("LIVE"));
    assert.equal(metrics.square.w, 38);
    assert.equal(metrics.square.h, 38);
    assert.equal(metrics.icon.w, 28);
    assert.equal(metrics.icon.h, 28);
    if (alive) {
      assert.equal(metrics.available, "true");
      assert.ok(Math.abs(metrics.panel.w - 46) < 0.05);
    } else {
      assert.equal(metrics.available, "false");
      assert.ok(Math.abs(metrics.panel.w - 103) < 0.05);
    }
    await page.screenshot({ path: `.npm-cache/living-dragon-qa/${time}.png` });
    results.push({
      time: sample.gameTime.value,
      type,
      alive,
      text,
      labels,
      metrics,
    });
  }
  console.log(
    JSON.stringify({
      pass: true,
      frames: records.length,
      unchangedExceptPitTimers: true,
      results,
    }),
  );
} finally {
  await browser.close();
  ws.close();
}
