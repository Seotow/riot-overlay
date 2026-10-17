import { createRequire } from "node:module";
import { resolve } from "node:path";
import assert from "node:assert/strict";
const require = createRequire(import.meta.url),
  { chromium } = require(resolve(process.env.OVERLAY_BROWSER_PACKAGES, "playwright"));
const browser = await chromium.launch({ channel: "msedge", headless: true });
try {
  const page = await browser.newPage({
    viewport: { width: 1920, height: 1080 },
  });
  await page.goto("http://127.0.0.1:4310/overlay?scene=ingame");
  await page.waitForTimeout(1300);
  const geometry = await page.evaluate(() => {
    const box = (e) => {
      const r = e.getBoundingClientRect();
      return { x: r.x, y: r.y, w: r.width, h: r.height };
    };
    return {
      divider: (() => {
        const s = getComputedStyle(document.querySelector(".table-gold"));
        return { left: s.borderLeft, right: s.borderRight };
      })(),
      icons: [...document.querySelectorAll(".role-quest-icon")].map((e) => {
        const ring = e.querySelector(".quest-progress"),
          circle = ring?.querySelector("circle"),
          matrix = circle?.getScreenCTM(),
          center = matrix ? new DOMPoint(16, 16).matrixTransform(matrix) : null;
        return {
          role: e.dataset.role,
          outer: box(e),
          glyph: box(e.querySelector(".role-quest-glyph")),
          ring: ring ? box(ring) : null,
          center: center ? { x: center.x, y: center.y } : null,
          style: getComputedStyle(e.querySelector(".role-quest-glyph")).maskImage,
        };
      }),
    };
  });
  console.log(JSON.stringify(geometry));
  await page.screenshot({ path: ".npm-cache/scoreboard-alignment.png" });
  assert.equal(geometry.divider.right, geometry.divider.left);
  const bodies = {
    top: [2, 3, 15, 16],
    jungle: [4, 5, 17, 19],
    mid: [2, 3, 18, 19],
    bot: [5, 6, 19, 19],
    support: [3, 3, 18, 18],
  };
  for (const icon of geometry.icons) {
    const [x0, y0, x1, y1] = bodies[icon.role],
      g = icon.glyph,
      o = icon.outer;
    const scale = Math.min(g.w / 23, g.h / 24),
      cx = g.x + (g.w - 23 * scale) / 2 + ((x0 + x1) / 2) * scale,
      cy = g.y + (g.h - 24 * scale) / 2 + ((y0 + y1) / 2) * scale;
    assert.ok(Math.abs(cx - o.x - o.w / 2) < 0.1, icon.role + " horizontal body alignment");
    assert.ok(Math.abs(cy - o.y - o.h / 2) < 0.1, icon.role + " vertical body alignment");
  }
  await page.screenshot({
    path: ".npm-cache/lane-quest-alignment.png",
    clip: { x: 480, y: 825, width: 45, height: 250 },
  });
  console.log(
    JSON.stringify({
      pass: true,
      icons: geometry.icons.length,
      maxCenterErrorPx: 0.1,
    }),
  );
} finally {
  await browser.close();
}
