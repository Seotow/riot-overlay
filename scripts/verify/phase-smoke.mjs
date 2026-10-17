// Baseline scenes and Studio smoke test on an isolated backend only.
import assert from "node:assert/strict";
import { createRequire } from "node:module";
import { resolve } from "node:path";
import { mkdir } from "node:fs/promises";
import { WebSocket } from "ws";
const base = process.env.OVERLAY_VISUAL_URL;
assert.match(base ?? "", /^http:\/\/127\.0\.0\.1:\d+$/);
assert.ok(!base.endsWith(":4310"), "Do not run scene mutation against the user backend");
const require = createRequire(import.meta.url);
const { chromium } = require(resolve(process.env.OVERLAY_BROWSER_PACKAGES, "playwright"));
const out = resolve(".npm-cache/visual-audit");
await mkdir(out, { recursive: true });
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
      fail(Error("Snapshot timeout"));
    }, 5000);
    const receive = (raw) => {
      const m = JSON.parse(raw.toString());
      if (!["snapshot", "error"].includes(m.type)) return;
      ws.off("message", receive);
      clearTimeout(timeout);
      m.type === "error" ? fail(Error(m.message)) : done(m.state);
    };
    ws.on("message", receive);
    ws.send(JSON.stringify(cmd));
  });
const browser = await chromium.launch({ channel: "msedge", headless: true });
try {
  await command({ type: "mockVisible", value: true });
  const page = await browser.newPage({
    viewport: { width: 1920, height: 1080 },
    deviceScaleFactor: 1,
  });
  for (const scene of ["draft", "ingame", "postgame"]) {
    await command({ type: "scene", value: scene });
    await page.goto(`${base}/overlay?scene=${scene}`);
    await page.locator(".canvas").waitFor();
    await page.evaluate(() => document.fonts.ready);
    await page.waitForFunction(() => [...document.images].every((img) => img.complete));
    const result = await page.evaluate(() => ({
      broken: [...document.images].filter((i) => i.naturalWidth === 0).map((i) => i.src),
      controls: document.querySelectorAll("button,input,select").length,
      references: document.querySelectorAll("img.reference").length,
      body: getComputedStyle(document.body).backgroundColor,
      canvas: [
        document.querySelector(".canvas").offsetWidth,
        document.querySelector(".canvas").offsetHeight,
      ],
    }));
    assert.deepEqual(result.broken, [], scene);
    assert.equal(result.controls, 0, scene);
    assert.equal(result.references, 0, scene);
    assert.equal(result.body, "rgba(0, 0, 0, 0)", scene);
    assert.deepEqual(result.canvas, [1920, 1080], scene);
    await page.screenshot({
      path: resolve(out, `phase-baseline-${scene}.png`),
      omitBackground: true,
    });
    console.log(`PASS: ${scene} baseline, assets/fonts, OBS transparent/no controls/reference`);
  }
  for (const route of ["overview", "sources", "studio", "theme", "roadmap"]) {
    await page.goto(`${base}/?page=${route}`);
    await page.locator("h2").first().waitFor();
    assert.ok((await page.locator("body").innerText()).length > 100);
  }
  await page.setViewportSize({ width: 1280, height: 800 });
  await page.goto(`${base}/?page=theme`);
  await page.locator("h2").first().waitFor();
  assert.ok(
    await page.evaluate(() => document.documentElement.scrollWidth <= innerWidth),
    "Studio horizontal overflow",
  );
  await command({ type: "mockVisible", value: false });
  console.log("PASS: five Studio modules and 1280px responsive theme page");
} finally {
  ws.terminate();
  await browser.close();
}
