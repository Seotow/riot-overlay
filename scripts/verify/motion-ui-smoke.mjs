import assert from "node:assert/strict";
import { createRequire } from "node:module";
import { readFile, mkdir } from "node:fs/promises";
import { resolve } from "node:path";
const base = process.env.OVERLAY_VISUAL_URL,
  id = process.env.OVERLAY_CAPTURE_ID ?? "2026-10-16T14-22-34-808Z";
assert.match(base ?? "", /^http:\/\/127\.0\.0\.1:\d+$/);
assert.ok(!base.endsWith(":4310"));
const { chromium } = createRequire(import.meta.url)(
  resolve(process.env.OVERLAY_BROWSER_PACKAGES, "playwright"),
);
const records = (await readFile(`data/captures/${id}/observer-samples.ndjson`, "utf8"))
    .trim()
    .split(/\r?\n/)
    .map(JSON.parse),
  start = Date.parse(records[0].receivedAt);
const report = async () => await (await fetch(base + "/api/providers")).json();
const until = async (check) => {
  for (let i = 0; i < 180; i++) {
    if (await check()) return;
    await new Promise((r) => setTimeout(r, 100));
  }
  throw Error("Condition timeout");
};
const browser = await chromium.launch({ channel: "msedge", headless: true }),
  results = { id };
try {
  const page = await browser.newPage({
      viewport: { width: 1920, height: 1080 },
    }),
    errors = [];
  page.on("pageerror", (e) => errors.push(String(e)));
  page.on("websocket", (socket) =>
    socket.on("framesent", (f) => {
      try {
        const m = JSON.parse(f.payload);
        if (["captureLoad", "captureControl"].includes(m.type))
          console.log(JSON.stringify({ sent: m }));
      } catch {}
    }),
  );
  await page.goto(base + "/?page=demo");
  const beforeLoad = (await report()).recording.loadGeneration ?? 0;
  await page.getByLabel("Bộ dữ liệu thật", { exact: true }).selectOption(id);
  await page.getByRole("button", { name: "Tải bản ghi", exact: true }).click();
  await until(async () => {
    const r = (await report()).recording;
    return r.id === id && (r.loadGeneration ?? 0) > beforeLoad;
  });
  await page.getByRole("button", { name: "Phát bản ghi", exact: true }).waitFor();
  const overlay = await browser.newPage({
    viewport: { width: 1920, height: 1080 },
  });
  overlay.on("pageerror", (e) => errors.push(String(e)));
  await overlay.goto(base + "/overlay?scene=ingame");
  await overlay.locator(".live-player-row").first().waitFor();
  const seek = async (time) => {
    const r = records.find((r) => r.message.sample.gameTime.value >= time),
      position = Date.parse(r.receivedAt) - start,
      slider = page.getByRole("slider", { name: "Tiến độ bản ghi thật" });
    console.log(
      JSON.stringify({
        seek: time,
        position,
        before: (await report()).recording.positionMs,
      }),
    );
    await slider.evaluate((e, p) => {
      e.value = String(p);
      e.dispatchEvent(new PointerEvent("pointerup", { bubbles: true }));
    }, position);
    await until(async () => {
      const s = (await report()).recording;
      return s.positionMs === position && !s.playing;
    });
    console.log(JSON.stringify({ afterSeek: (await report()).recording.positionMs }));
  };
  const view = async (label) =>
    await page
      .locator(".operator-card")
      .filter({ has: page.getByRole("heading", { name: label, exact: true }) })
      .getByRole("button")
      .click();
  const toggle = async (name, value) => {
    const c = page.getByLabel(name, { exact: true });
    if ((await c.isChecked()) !== value) await c.click();
    await until(async () => (await c.isChecked()) === value);
  };
  await page
    .getByLabel("Upload ảnh ingame đối chiếu", { exact: true })
    .setInputFiles(
      "C:/Users/Seotow/AppData/Local/Temp/codex-clipboard-2dfc8320-7763-4bac-bd4e-ceb706315268.png",
    );
  await page.locator(".monitor-reference").waitFor();
  assert.equal(await overlay.locator(".monitor-reference").count(), 0);
  await page.getByLabel("Độ hiện overlay đối chiếu", { exact: true }).fill("0.5");
  assert.equal(
    await page.locator(".program-monitor iframe").evaluate((e) => getComputedStyle(e).opacity),
    "0.5",
  );
  await page.getByLabel("Độ hiện overlay đối chiếu", { exact: true }).fill("1");
  results.uploadStudioOnly = true;
  await page.getByLabel("Layout tuyển thủ đang phát", { exact: true }).selectOption("camera");
  await until(
    async () =>
      !(await overlay
        .locator(".canvas")
        .evaluate((e) => e.classList.contains("no-player-cameras"))),
  );
  await new Promise((r) => setTimeout(r, 1200));
  let box = await overlay.locator('[data-region="players"]').boundingBox();
  assert.equal(Math.round(box.width), 992);
  await page.getByLabel("Layout tuyển thủ đang phát", { exact: true }).selectOption("expanded");
  await until(
    async () =>
      await overlay.locator(".canvas").evaluate((e) => e.classList.contains("no-player-cameras")),
  );
  await seek(740);
  await new Promise((r) => setTimeout(r, 1200));
  box = await overlay.locator('[data-region="players"]').boundingBox();
  assert.equal(Math.round(box.width), 1346);
  results.fullLayout = await overlay
    .locator(".table-blue .live-player-row")
    .first()
    .evaluate((row) => {
      const names = [
        ".row-items",
        ".row-lane-quest",
        ".row-runes",
        ".row-spells",
        ".row-champion",
        ".row-name",
        ".row-numbers",
      ];
      return names.map((s) => {
        const r = row.querySelector(s).getBoundingClientRect();
        return { s, x: r.x, width: r.width, right: r.right };
      });
    });
  for (let i = 1; i < results.fullLayout.length; i++)
    assert.ok(
      results.fullLayout[i].x >= results.fullLayout[i - 1].right - 1,
      JSON.stringify(results.fullLayout),
    );
  await page.getByText("Bật/tắt từng đồ họa độc lập", { exact: true }).click();
  await until(async () => (await overlay.locator(".live-objective").count()) === 0);
  await toggle("Baron powerplay", false);
  await toggle("Timer buff Elder", false);
  await until(async () => (await overlay.locator(".live-objective").count()) === 2);
  results.timers = await overlay.locator(".live-objective").allTextContents();
  await toggle("Baron powerplay", true);
  await toggle("Timer buff Elder", true);
  await until(async () => (await overlay.locator(".live-objective").count()) === 0);
  results.pitTimersReturnWithMotion = true;
  const lead = await overlay.locator(".blue-lead").boundingBox(),
    number = await overlay.locator(".score-economy:not(.right) .score-gold-value").boundingBox();
  assert.ok(Math.abs(lead.x - number.x) < 1);
  results.arrow = await overlay
    .locator(".lane-gold-blue")
    .first()
    .evaluate((e) => ({
      barWidth: getComputedStyle(e, "::before").width,
      barInset: getComputedStyle(e, "::before").left,
      arrowInset: getComputedStyle(e.querySelector(".lane-gold-arrow")).left,
    }));
  assert.equal(results.arrow.barWidth, "2px");
  await mkdir(".npm-cache/visual-audit", { recursive: true });
  await overlay.screenshot({
    path: ".npm-cache/visual-audit/motion-full-no-camera.png",
    omitBackground: true,
  });
  const baron = overlay.locator('[data-region="baron"]');
  await baron.waitFor();
  assert.equal(await baron.getAttribute("data-team"), "ORDER");
  let b = await baron.boundingBox();
  assert.equal(Math.round(b.x), 336);
  results.mirroredRight = await baron.evaluate((e) => {
    e.classList.replace("buff-side-blue", "buff-side-red");
    const b = e.getBoundingClientRect();
    e.classList.replace("buff-side-red", "buff-side-blue");
    return 1920 - b.right;
  });
  assert.equal(Math.round(results.mirroredRight), 336);
  await view("Layout tối giản");
  await overlay.locator(".canvas.minimal").waitFor();
  results.minimalAnimation = await overlay
    .locator(".table-blue .live-player-row")
    .first()
    .evaluate((e) => getComputedStyle(e).animationName);
  assert.equal(results.minimalAnimation, "minimal-spread");
  assert.equal(
    await overlay
      .locator(".table-blue")
      .evaluate((e) => getComputedStyle(e, "::after").backgroundSize),
    "5px 100%, 100% 5px",
  );
  await new Promise((r) => setTimeout(r, 1200));
  await overlay.screenshot({
    path: ".npm-cache/visual-audit/motion-minimal-no-camera.png",
    omitBackground: true,
  });
  await view("Rune toàn đội");
  await overlay.locator('[data-region="runes"]').waitFor();
  assert.equal(
    await overlay.locator(".canvas").evaluate((e) => e.classList.contains("minimal")),
    true,
  );
  assert.equal(
    await overlay
      .locator(".rune-team")
      .first()
      .evaluate((e) => getComputedStyle(e).animationName),
    "rune-cluster",
  );
  await new Promise((r) => setTimeout(r, 1300));
  await overlay.screenshot({
    path: ".npm-cache/visual-audit/motion-runes.png",
    omitBackground: true,
  });
  await view("Rune toàn đội");
  await overlay.locator('[data-region="runes"]').waitFor({ state: "detached" });
  results.runesDoNotChangeLayout = true;
  await page.getByRole("button", { name: "Trở về bảng đầy đủ", exact: true }).click();
  await view("Leaderboard vàng");
  await overlay.locator('[data-region="gold"]').waitFor();
  await new Promise((r) => setTimeout(r, 1200));
  assert.equal(await overlay.locator('[data-region="gold"] .rank-entry').count(), 10);
  const firstRank = overlay.locator('[data-region="gold"] .rank-entry').first();
  assert.equal(
    await firstRank.evaluate((e) => getComputedStyle(e).transitionProperty),
    "transform",
  );
  results.rankMovement = true;
  await view("Leaderboard cấp độ");
  await overlay.locator('[data-region="levels"]').waitFor();
  assert.equal(await overlay.locator('[data-region="levels"] .rank-entry').count(), 10);
  assert.equal(await overlay.locator('[data-region="gold"] .rank-entry').count(), 10);
  assert.equal(await overlay.locator('[data-region="levels"] [role="progressbar"]').count(), 10);
  results.xpProgress = 10;
  await new Promise((r) => setTimeout(r, 1300));
  results.rankingWidths = await overlay.evaluate(() => ({
    gold: document.querySelector('[data-region="gold"]').getBoundingClientRect().width,
    levels: document.querySelector('[data-region="levels"]').getBoundingClientRect().width,
    goldTrack: document.querySelector('[data-region="gold"] .ranking-track').getBoundingClientRect()
      .width,
    xpTrack: document
      .querySelector('[data-region="levels"] .level-progress')
      .getBoundingClientRect().width,
  }));
  assert.equal(results.rankingWidths.levels, results.rankingWidths.gold);
  assert.equal(results.rankingWidths.xpTrack, results.rankingWidths.goldTrack);
  // Style-only regression: cues on a dead portrait must retain full color/opacity.
  results.deadPortraitCue = await overlay.evaluate(() => {
    const row = document.querySelector(".live-player-row"),
      wasDead = row.classList.contains("is-dead");
    row.classList.add("is-dead");
    const champion = row.querySelector(".row-champion"),
      cue = document.createElement("span");
    cue.className = "portrait-alert";
    const content = document.createElement("span"),
      img = document.createElement("img");
    content.className = "portrait-alert-content";
    img.src = "/ddragon/16.20.1/item/3157.png";
    content.append(img);
    cue.append(content);
    champion.append(cue);
    const s = getComputedStyle(img),
      cs = getComputedStyle(champion.querySelector(":scope > img"));
    const r = {
      itemFilter: s.filter,
      itemOpacity: s.opacity,
      championFilter: cs.filter,
      cueZ: getComputedStyle(cue).zIndex,
    };
    cue.remove();
    if (!wasDead) row.classList.remove("is-dead");
    return r;
  });
  assert.equal(results.deadPortraitCue.itemFilter, "none");
  assert.equal(results.deadPortraitCue.itemOpacity, "1");
  assert.equal(results.deadPortraitCue.championFilter, "grayscale(1)");
  await overlay.screenshot({
    path: ".npm-cache/visual-audit/motion-levels.png",
    omitBackground: true,
  });
  await page
    .locator(".operator-card")
    .filter({
      has: page.getByRole("heading", { name: "Nhà lính KT", exact: true }),
    })
    .getByRole("button")
    .click();
  await overlay.locator('.live-inhibitors section[data-team="ORDER"]').waitFor();
  assert.equal(await overlay.locator(".live-inhibitors .standing").count(), 3);
  assert.equal(await overlay.locator(".live-inhibitors time").count(), 0);
  await page
    .locator(".operator-card")
    .filter({
      has: page.getByRole("heading", { name: "Nhà lính T1", exact: true }),
    })
    .getByRole("button")
    .click();
  await seek(760);
  await overlay.locator('.live-inhibitors section[data-team="CHAOS"] time').waitFor();
  assert.equal(await overlay.locator(".live-inhibitors .destroyed").count(), 1);
  results.inhibitorBlueStandingRedTimer = true;
  await overlay.screenshot({
    path: ".npm-cache/visual-audit/motion-inhibitors.png",
    omitBackground: true,
  });
  await page.getByRole("button", { name: "Ẩn timer nhà lính", exact: true }).click();
  await overlay.locator(".live-inhibitors").waitFor({ state: "detached" });
  await page.getByRole("button", { name: "Trở về bảng đầy đủ", exact: true }).click();
  await seek(672);
  await page.getByRole("button", { name: "Phát bản ghi", exact: true }).click();
  await overlay.locator(".live-soul-takeover").waitFor({ timeout: 12000 });
  assert.equal(
    await overlay.locator(".canvas").evaluate((e) => e.classList.contains("minimal")),
    false,
  );
  await page.getByRole("button", { name: "Tạm dừng bản ghi", exact: true }).click();
  await toggle("Panel linh hồn rồng", false);
  await overlay.locator(".live-soul-takeover").waitFor({ state: "detached" });
  assert.equal(await overlay.locator(".live-soul-description").count(), 1);
  assert.equal(
    await overlay.locator(".canvas").evaluate((e) => e.classList.contains("minimal")),
    false,
  );
  results.soulDoesNotChangeLayout = true;
  await toggle("Panel linh hồn rồng", true);
  await toggle("Banner mục tiêu / trụ đầu", false);
  await overlay.locator(".live-soul-description").waitFor({ state: "detached" });
  assert.equal(await overlay.locator(".live-soul-takeover").count(), 1);
  await toggle("Banner mục tiêu / trụ đầu", true);
  assert.deepEqual(errors, []);
  results.pass = true;
  console.log(JSON.stringify(results));
} finally {
  await browser.close();
}
