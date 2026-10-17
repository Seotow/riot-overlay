import assert from "node:assert/strict";
import { createRequire } from "node:module";
import { resolve } from "node:path";
import { WebSocket } from "ws";
const base = process.env.OVERLAY_VISUAL_URL ?? "http://127.0.0.1:4393";
assert.match(base, /^http:\/\/127\.0\.0\.1:\d+$/);
assert.ok(!base.endsWith(":4310"));
const require = createRequire(import.meta.url),
  { chromium } = require(resolve(process.env.OVERLAY_BROWSER_PACKAGES, "playwright")),
  sharp = require(resolve(process.env.OVERLAY_BROWSER_PACKAGES, "sharp"));
const ws = new WebSocket(base.replace("http:", "ws:") + "/ws?role=studio", {
  origin: base,
});
await new Promise((yes, no) => {
  ws.once("open", yes);
  ws.once("error", no);
});
for (const c of [
  { type: "scene", value: "ingame" },
  { type: "ingameGraphic", key: "baronPowerplay", value: true },
  { type: "ingameGraphic", key: "elderTimer", value: true },
  { type: "broadcastWidget", key: "minimal", value: false },
])
  ws.send(JSON.stringify(c));
const browser = await chromium.launch({ channel: "msedge", headless: true });
try {
  const p = await browser.newPage({ viewport: { width: 1920, height: 1080 } });
  await p.goto(base + "/overlay?scene=ingame");
  await p.locator(".real-powerplay").waitFor();
  await p.locator(".real-elder-timer").waitFor();
  await p.waitForTimeout(1000);
  const panels = await p.evaluate(() =>
    [".real-powerplay", ".real-elder-timer"].map((sel) => {
      const e = document.querySelector(sel),
        progress = e.querySelector(".buff-time-progress"),
        fill = progress.querySelector("i"),
        r = e.getBoundingClientRect(),
        t = progress.getBoundingClientRect(),
        f = fill.getBoundingClientRect(),
        icon = e.querySelector(".metric-icon");
      return {
        kind: sel,
        width: r.width,
        trackWidth: t.width,
        trackBottom: t.bottom,
        panelBottom: r.bottom,
        percent: Number(progress.getAttribute("aria-valuenow")),
        fill: f.width,
        color: getComputedStyle(fill).backgroundColor,
        iconColor: getComputedStyle(icon).backgroundColor,
        mask: getComputedStyle(icon).maskImage,
        teamLabelCount: e.querySelectorAll(":scope > b").length,
        time: e.querySelector("time").textContent.trim(),
      };
    }),
  );
  for (const r of panels) {
    assert.equal(r.trackWidth, r.width - 2);
    assert.ok(Math.abs(r.panelBottom - r.trackBottom - 1) < 0.1);
    assert.ok(r.percent > 0 && r.percent < 100);
    assert.equal(r.color, r.iconColor);
    assert.ok(Math.abs((r.fill / r.trackWidth) * 100 - r.percent) < 1);
  }
  assert.equal(panels[1].teamLabelCount, 0);
  assert.equal(panels[1].color, "rgb(30, 228, 222)");
  assert.match(panels[0].mask, /mixed\/baron.svg/);
  await p.screenshot({
    path: ".npm-cache/visual-audit/mixed-powerplay-real.png",
    omitBackground: true,
  });
  const fade = [];
  for (const kind of ["baron", "elder"]) {
    await p.evaluate((kind) => {
      const host = document.createElement("div");
      host.id = "edge-mask-check";
      host.style.cssText =
        "position:fixed;left:10px;top:300px;width:58px;height:58px;background:rgb(32,32,32);z-index:9999";
      const buff = document.createElement("i");
      buff.className = kind + "-player-buff";
      buff.style.cssText = "inset:0;border:0;box-shadow:none;width:58px;height:58px";
      host.append(buff);
      document.body.append(host);
      const sheet = document.createElement("style");
      sheet.id = "edge-mask-style";
      sheet.textContent = "#edge-mask-check i::after{display:none!important}";
      document.head.append(sheet);
      for (const a of buff.getAnimations({ subtree: true })) {
        a.pause();
        const t = a.effect.getTiming();
        a.currentTime = Number(t.duration) + t.delay;
      }
    }, kind);
    const bytes = await p.locator("#edge-mask-check").screenshot({ animations: "allow" });
    const { data, info } = await sharp(bytes)
      .removeAlpha()
      .raw()
      .toBuffer({ resolveWithObject: true });
    const pixel = (x, y) => [
      ...data.subarray((y * info.width + x) * 3, (y * info.width + x) * 3 + 3),
    ];
    const center = pixel(29, 29),
      edge = pixel(1, 29);
    assert.deepEqual(center, [32, 32, 32]);
    assert.ok(edge.some((n) => Math.abs(n - 32) >= 5));
    fade.push({ kind, center, edge });
    await p.evaluate(() => {
      document.querySelector("#edge-mask-check").remove();
      document.querySelector("#edge-mask-style").remove();
    });
  }
  const cueTiming = await p.evaluate(() => {
    const canvas = document.querySelector(".live-canvas"),
      champion = document.querySelector(".row-champion"),
      cue = document.createElement("span"),
      content = document.createElement("span");
    cue.className = "portrait-alert";
    content.className = "portrait-alert-content";
    content.textContent = "18";
    cue.append(content);
    const results = [];
    for (const minimal of [false, true]) {
      canvas.classList.toggle("minimal", minimal);
      canvas.classList.toggle("panel", !minimal);
      champion.append(cue);
      const animation = content.getAnimations()[0],
        duration = Number(animation.effect.getTiming().duration);
      const frames = animation.effect.getKeyframes(),
        hold = frames.filter(
          (f) => f.transform === "translateY(0px)" || f.transform === "translateY(0)",
        );
      results.push({
        minimal,
        duration,
        holdMs:
          hold.length === 2 ? (hold[1].computedOffset - hold[0].computedOffset) * duration : null,
      });
      cue.remove();
    }
    canvas.classList.remove("minimal");
    canvas.classList.add("panel");
    return results;
  });
  assert.equal(cueTiming[0].duration, 3840);
  assert.equal(cueTiming[1].duration, 1590);
  assert.ok(Math.abs(cueTiming[1].holdMs - 750) < 1);
  const playerBars = [];
  for (const minimal of [false, true]) {
    await p.evaluate((minimal) => {
      const e = document.querySelector(".live-canvas");
      e.classList.toggle("minimal", minimal);
      e.classList.toggle("panel", !minimal);
    }, minimal);
    await p.waitForTimeout(1100);
    const bars = await p.evaluate(() =>
      [...document.querySelectorAll(".live-player-row")].map((row) => {
        const xp = row.querySelector(".experience-track"),
          hp = row.querySelector(".health-track"),
          resource = row.querySelector(".resource-track"),
          x = xp.getBoundingClientRect(),
          h = hp.getBoundingClientRect(),
          r = resource.getBoundingClientRect();
        return {
          champion: row.querySelector(".row-champion > img")?.alt,
          xpHeight: x.height,
          hpHeight: h.height,
          resourceHeight: r.height,
          xpWidth: x.width,
          hpWidth: h.width,
          above: x.bottom <= h.top,
          xpColor: getComputedStyle(xp.querySelector("i")).backgroundColor,
          resourceKind: resource.dataset.resourceKind,
          resourceColor: getComputedStyle(resource.querySelector("i")).backgroundColor,
        };
      }),
    );
    assert.equal(bars.length, 10);
    for (const b of bars) {
      assert.ok(Math.abs(b.xpHeight / b.hpHeight - 0.6) < 0.002);
      assert.equal(b.hpHeight, b.resourceHeight);
      assert.equal(b.xpWidth, b.hpWidth);
      assert.ok(b.above);
      assert.equal(b.xpColor, "rgb(126, 60, 117)");
    }
    const lee = bars.find((b) => b.champion === "Lee Sin");
    assert.equal(lee.resourceKind, "energy");
    assert.equal(lee.resourceColor, "rgb(200, 217, 75)");
    playerBars.push({
      minimal,
      xpHeight: bars[0].xpHeight,
      hpHeight: bars[0].hpHeight,
      energyLee: lee,
    });
    await p.screenshot({
      path: `.npm-cache/visual-audit/player-bars-${minimal ? "simple" : "full"}-real.png`,
      omitBackground: true,
    });
  }
  console.log(
    JSON.stringify({
      pass: true,
      panels,
      edgeFadeStyleOnly: fade,
      cueTimingStyleOnly: cueTiming,
      playerBars,
    }),
  );
} finally {
  ws.close();
  await browser.close();
}
