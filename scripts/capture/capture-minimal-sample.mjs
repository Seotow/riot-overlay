// Capture the existing recorded sample, never mutate the operator's backend.
import assert from "node:assert/strict";
import { createRequire } from "node:module";
import { resolve } from "node:path";
import { mkdir, readFile } from "node:fs/promises";
import { WebSocket } from "ws";
const base = process.env.OVERLAY_VISUAL_URL;
assert.match(base ?? "", /^http:\/\/127\.0\.0\.1:\d+$/);
assert.ok(!base.endsWith(":4310"));
const { chromium } = createRequire(import.meta.url)(
  resolve(process.env.OVERLAY_BROWSER_PACKAGES, "playwright"),
);
const ws = new WebSocket(base.replace("http", "ws") + "/ws?role=studio", { origin: base });
await new Promise((done, fail) => {
  ws.once("open", done);
  ws.once("error", fail);
});
const command = (cmd) =>
  new Promise((done, fail) => {
    const timeout = setTimeout(() => {
      ws.off("message", receive);
      fail(Error("Timeout " + cmd.type));
    }, 45000);
    const receive = (raw) => {
      const m = JSON.parse(raw);
      if (!["snapshot", "error"].includes(m.type)) return;
      clearTimeout(timeout);
      ws.off("message", receive);
      m.type === "error" ? fail(Error(m.message)) : done(m.state);
    };
    ws.on("message", receive);
    ws.send(JSON.stringify(cmd));
  });
const browser = await chromium.launch({ channel: "msedge", headless: true });
try {
  const captures = await (await fetch(base + "/api/captures")).json();
  const sample = captures.filter((c) => c.hasState).sort((a, b) => b.frames - a.frames)[0];
  assert.ok(sample, "Existing sample required");
  let state = await command({ type: "captureLoad", id: sample.id });
  await command({ type: "captureControl", playing: false });
  state = await command({ type: "rehearsal", value: "minimal" });
  let theme;
  try {
    theme = JSON.parse(await readFile("data/theme.json", "utf8"));
  } catch {
    theme = state.theme;
  }
  const page = await browser.newPage({
    viewport: { width: 1920, height: 1080 },
    deviceScaleFactor: 1,
  });
  await mkdir(".npm-cache/visual-audit", { recursive: true });
  for (const cameras of [true, false]) {
    await command({
      type: "theme",
      value: { ...theme, playerCameras: cameras, scale: 1, offsetY: 0 },
    });
    await page.goto(base + "/overlay?scene=ingame");
    await page.locator(".canvas.minimal").waitFor();
    await page.waitForFunction(
      () =>
        document.querySelectorAll(".row-champion > img").length === 10 &&
        [...document.images].every((i) => i.complete && i.naturalWidth > 0),
    );
    await page.evaluate(() => document.fonts.ready);
    // Only screenshot presentation: neutral background improves readability.
    await page.addStyleTag({ content: "body.overlay-body { background:#17282f !important; }" });
    const name = `minimal-old-sample-${cameras ? "camera" : "no-camera"}`;
    await page.screenshot({ path: `.npm-cache/visual-audit/${name}-full.png` });
    await page.screenshot({
      path: `.npm-cache/visual-audit/${name}.png`,
      clip: { x: 287, y: 900, width: 1346, height: 180 },
    });
    console.log(
      JSON.stringify({
        name,
        capture: sample.id,
        champions: await page
          .locator(".row-champion > img")
          .evaluateAll((imgs) => imgs.map((i) => i.alt)),
      }),
    );
  }
} finally {
  ws.close();
  await browser.close();
}
