// Isolated local browser QA; never connects to a personal browser profile.
import { createRequire } from "node:module";
import { mkdir, writeFile, readFile } from "node:fs/promises";
import { resolve } from "node:path";
import assert from "node:assert/strict";
const require = createRequire(import.meta.url);
const packages = process.env.OVERLAY_BROWSER_PACKAGES;
if (!packages)
  throw Error(
    "Set OVERLAY_BROWSER_PACKAGES to the installed Playwright/sharp package directory.",
  );
const { chromium } = require(resolve(packages, "playwright"));
const sharp = require(resolve(packages, "sharp"));
const base = process.env.OVERLAY_VISUAL_URL ?? "http://127.0.0.1:4310";
if (!/^http:\/\/127\.0\.0\.1:\d+$/.test(base))
  throw Error("Local backend only");
const out = resolve(".npm-cache/visual-audit");
await mkdir(out, { recursive: true });
const manifest = JSON.parse(
  await readFile("scripts/visual-regions.json", "utf8"),
);
for (const [file, regions] of Object.entries(manifest.references)) {
  const input = resolve("images", file);
  const meta = await sharp(input).metadata();
  if (meta.width !== 1920 || meta.height !== 1080)
    throw Error(`Reference dimensions: ${file}`);
  const boxes = Object.entries(regions)
    .map(
      ([label, [x, y, w, h]]) =>
        `<rect x="${x}" y="${y}" width="${w}" height="${h}" fill="none" stroke="#00ffff" stroke-width="2"/><text x="${x + 4}" y="${y + 16}" fill="#00ffff" font-size="14">${label}</text>`,
    )
    .join("");
  await sharp(input)
    .composite([
      { input: Buffer.from(`<svg width="1920" height="1080">${boxes}</svg>`) },
    ])
    .png()
    .toFile(resolve(out, `regions-${file}`));
}
const browser = await chromium.launch({ headless: true, channel: "msedge" });
try {
  const studio = await browser.newPage({
    viewport: { width: 1920, height: 1080 },
    deviceScaleFactor: 1,
  });
  await studio.goto(base + "/?page=demo");
  await studio
    .getByRole("button", { name: "Leaderboard gold", exact: false })
    .waitFor();
  await studio.waitForFunction(
    () =>
      [...document.querySelectorAll("button")].some(
        (b) => b.textContent.includes("Leaderboard gold") && !b.disabled,
      ),
    { timeout: 45000 },
  );
  const renderer = await browser.newPage({
    viewport: { width: 1920, height: 1080 },
    deviceScaleFactor: 1,
  });
  await renderer.goto(base + "/overlay?scene=ingame");
  const results = [];
  for (const [kind, label] of [
    ["gold", "Leaderboard gold"],
    ["levels", "Leaderboard level"],
    ["cooldowns", "Cooldown item / GA"],
    ["minimal", "Layout tối giản"],
    ["baron", "Baron Power Play"],
    ["timers", "Timer mục tiêu"],
    ["dragon", "Hạ rồng"],
    ["runes", "Rune toàn đội"],
    ["questTop", "Hoàn thành quest"],
    ["questJungle", "Hoàn thành quest"],
    ["questMid", "Hoàn thành quest"],
    ["questBot", "Hoàn thành quest"],
    ["questSupport", "Hoàn thành quest"],
    ["inhibitor", "Timer nhà lính"],
    ["inhibitorRed", "Timer nhà lính"],
    ["inhibitorBlue", "Timer nhà lính"],
    ["soul", "Linh hồn rồng"],
  ]) {
    if (kind.startsWith("quest"))
      await studio
        .getByLabel("Hoàn thành quest · loại")
        .selectOption(kind.slice(5));
    if (kind.startsWith("inhibitor"))
      await studio
        .getByLabel("Timer nhà lính · loại")
        .selectOption(
          kind === "inhibitor"
            ? "recorded"
            : kind === "inhibitorBlue"
              ? "ORDER"
              : "CHAOS",
        );
    const button = studio.getByRole("button", { name: label, exact: false });
    if (!(await button.isEnabled())) {
      results.push({ kind, unavailable: true });
      continue;
    }
    await button.click();
    await renderer.waitForTimeout(650);
    await renderer.evaluate(() => document.fonts.ready);
    assert.equal(await renderer.locator(".live-buff-status").count(), 0);
    const scoreEdges = await renderer.evaluate(() => {
      const score = document
        .querySelector(".live-scoreboard .score-main")
        .getBoundingClientRect();
      const team = document
        .querySelector(".live-scoreboard .side-red")
        .getBoundingClientRect();
      const pips = document
        .querySelector(".live-scoreboard .side-red .live-series-pips")
        .getBoundingClientRect();
      return {
        teamGap: score.right - team.right,
        pipsGap: score.right - pips.right,
      };
    });
    assert.ok(
      Math.abs(scoreEdges.teamGap - 3) < 0.1,
      JSON.stringify(scoreEdges),
    );
    assert.ok(
      Math.abs(scoreEdges.pipsGap - 8) < 0.1,
      JSON.stringify(scoreEdges),
    );
    if (kind.startsWith("quest")) {
      await renderer.locator(".quest-completion").first().waitFor();
      assert.equal(await renderer.locator(".quest-completion").count(), 1);
      assert.ok(
        (await renderer.locator(".row-secondary.quest-reward img").count()) > 0,
      );
      const questBoxes = await renderer
        .locator(".quest-completion")
        .evaluateAll((els) =>
          els.map((el) => {
            const r = el.getBoundingClientRect();
            return [r.x, r.y, r.width, r.height];
          }),
        );
      assert.ok(
        questBoxes.every((r) => r[2] > 400 && r[3] >= 48 && r[3] <= 53),
        JSON.stringify(questBoxes),
      );
      results.push({ kind: kind + "-banner", questBoxes, scoreEdges });
    }
    if (kind === "levels") {
      assert.equal(await renderer.locator(".row-runes").count(), 10);
      assert.equal(await renderer.locator(".row-keystone img").count(), 10);
      assert.equal(await renderer.locator(".row-ultimate img").count(), 10);
      assert.equal(
        await renderer
          .locator(".row-ultimate img")
          .evaluateAll((els) =>
            els.every((img) => img.src.includes("/ability/")),
          ),
        true,
      );
      const runeGeometry = await renderer
        .locator(".live-player-row")
        .evaluateAll((rows) =>
          rows.map((row) => {
            const rect = (s) => row.querySelector(s).getBoundingClientRect();
            const k = rect(".row-keystone"),
              p = rect(".row-secondary"),
              r = rect(".row-runes"),
              spells = rect(".row-spells"),
              image = rect(".row-spells img");
            return {
              main: k.width,
              secondary: p.width,
              spell: image.width,
              gap: row.classList.contains("red-row")
                ? r.left - spells.right
                : spells.left - r.right,
            };
          }),
        );
      assert.ok(
        runeGeometry.every(
          (r) =>
            r.main === 18 &&
            r.secondary === 14 &&
            r.spell === 22 &&
            r.gap === 4,
        ),
        JSON.stringify(runeGeometry),
      );
      results.push({ kind: "rune-slots", runeGeometry });
      assert.equal(
        await renderer.locator(".live-level-ranking > div").count(),
        10,
      );
      assert.equal(
        await renderer
          .locator('.live-level-ranking [role="progressbar"]')
          .count(),
        10,
      );
    }
    if (kind === "cooldowns") {
      assert.ok((await renderer.locator(".cooldown-sweep").count()) > 0);
      assert.ok(
        (await renderer.locator('img[alt="Unleashed Smite"]').count()) > 0,
      );
    }
    if (kind === "minimal") {
      assert.equal(
        await renderer.locator(".minimal-ultimate:visible").count(),
        10,
      );
      assert.equal(await renderer.locator(".row-runes:visible").count(), 0);
      assert.equal(
        await renderer
          .locator(".minimal-ultimate img")
          .evaluateAll((els) =>
            els.every((img) => img.src.includes("/ability/")),
          ),
        true,
      );
    }
    if (kind === "baron") {
      assert.ok((await renderer.locator(".baron-player-buff").count()) > 0);
      assert.match(
        await renderer.locator(".real-powerplay > time").textContent(),
        /\d+:\d{2}/,
      );
    }
    if (kind.startsWith("inhibitor")) {
      const teams = await renderer
        .locator(".live-inhibitors > section")
        .count();
      assert.equal(teams, 1);
      if (kind !== "inhibitor") assert.equal(teams, 1);
      assert.equal(
        await renderer.locator(".live-inhibitors > section").count(),
        teams,
      );
      assert.equal(
        await renderer.locator(".inhibitor-lanes [data-lane]").count(),
        teams * 3,
      );
      assert.ok((await renderer.locator(".inhibitor-lanes time").count()) > 0);
      if (kind !== "inhibitor")
        assert.equal(
          await renderer
            .locator(
              `.live-inhibitors > section[data-team="${kind === "inhibitorRed" ? "CHAOS" : "ORDER"}"]`,
            )
            .count(),
          1,
        );
    }
    if (kind === "dragon") {
      assert.equal(
        await renderer
          .locator(".dragon-event-strip .dragon-banner-icon")
          .count(),
        2,
      );
      assert.ok(
        !(await renderer.locator(".dragon-event-strip").textContent()).includes(
          "ĐÃ HẠ",
        ),
      );
    }
    if (kind === "soul") {
      await renderer.locator(".live-soul-takeover").waitFor();
      const boxes = await renderer.evaluate(() =>
        ["soul-takeover", "soul-description", "players"].map((name) => {
          const rect = document
            .querySelector(`[data-region="${name}"]`)
            .getBoundingClientRect();
          return [rect.x, rect.y, rect.width, rect.height];
        }),
      );
      assert.deepEqual(boxes, [
        [0, 145, 286, 600],
        [715, 113, 503, 35],
        [464, 909, 992, 171],
      ]);
    }
    await renderer.screenshot({
      path: resolve(out, `${kind}.png`),
      omitBackground: true,
    });
    results.push({
      kind,
      regions: await renderer.evaluate(() =>
        [...document.querySelectorAll("[data-region]")].map((el) => {
          const r = el.getBoundingClientRect();
          return {
            region: el.getAttribute("data-region"),
            rect: [r.x, r.y, r.width, r.height],
          };
        }),
      ),
      brokenImages: await renderer.evaluate(() =>
        [...document.images]
          .filter((i) => !i.complete || i.naturalWidth === 0)
          .map((i) => i.src),
      ),
      referenceImages: await renderer.locator("img.reference").count(),
      controls: await renderer.locator("button,input,select").count(),
    });
    if (kind === "soul") {
      await renderer
        .locator(".live-soul-takeover")
        .waitFor({ state: "detached", timeout: 10000 });
      assert.equal(await renderer.locator(".live-soul-description").count(), 0);
      const restored = await renderer.evaluate(() => {
        const r = document
          .querySelector('[data-region="players"]')
          .getBoundingClientRect();
        return [r.x, r.y, r.width, r.height];
      });
      results.push({ kind: "soul-expired", restored });
      assert.deepEqual(
        restored,
        results
          .find((r) => r.kind === "inhibitor")
          .regions.find((r) => r.region === "players").rect,
      );
    }
  }
  for (const [group, choices] of [
    [
      "Hạ rồng",
      ["earth", "fire", "water", "air", "hextech", "chemtech", "elder"],
    ],
    ["Linh hồn rồng", ["earth", "fire", "water", "air", "hextech", "chemtech"]],
    ["Baron Power Play", ["baron", "elder", "both"]],
    ["Phá trụ", ["first", "normal"]],
  ]) {
    for (const value of choices) {
      await studio.getByLabel(group + " · loại").selectOption(value);
      await studio.getByRole("button", { name: group, exact: false }).click();
      await renderer.waitForTimeout(350);
      assert.match(
        await renderer.locator(".rehearsal-watermark").textContent(),
        /GIẢ LẬP UI/,
      );
      if (group === "Hạ rồng" || group === "Linh hồn rồng") {
        const selector =
          group === "Hạ rồng"
            ? ".dragon-event-strip"
            : ".live-soul-description";
        assert.ok((await renderer.locator(selector).count()) > 0);
        assert.ok(
          (await renderer.locator(selector).getAttribute("style")).includes(
            "--dragon-color",
          ),
        );
      }
      if (group === "Baron Power Play") {
        assert.equal(
          await renderer.locator('[data-region="baron"]').count(),
          value === "elder" ? 0 : 1,
        );
        assert.equal(
          await renderer.locator('[data-region="elder"]').count(),
          value === "baron" ? 0 : 1,
        );
      }
      if (group === "Phá trụ") {
        assert.equal(
          await renderer.locator('[data-region="tower-banner"]').count(),
          1,
        );
        assert.equal(
          (
            await renderer.locator('[data-region="tower-banner"]').textContent()
          ).includes("FIRST TURRET"),
          value === "first",
        );
        assert.ok(
          !(await renderer.locator(".killfeed").textContent()).includes(
            "PHÁ TRỤ",
          ),
        );
      }
      if (group === "Linh hồn rồng") {
        const copyMetrics = await renderer
          .locator(".soul-effect-copy > span")
          .evaluateAll((lines) =>
            lines.map((line) => ({
              text: line.textContent,
              width: line.clientWidth,
              content: line.scrollWidth,
            })),
          );
        assert.equal(copyMetrics.length, 2);
        assert.ok(
          copyMetrics.every((line) => line.content <= line.width),
          `Soul ${value} copy clipped: ${JSON.stringify(copyMetrics)}`,
        );
        await renderer
          .locator(`.soul-artwork[src$="/${value}.webp"]`)
          .waitFor();
        await renderer.waitForFunction(() => {
          const art = document.querySelector(".soul-artwork");
          return (
            art instanceof HTMLImageElement &&
            art.complete &&
            art.naturalWidth > 0
          );
        });
        assert.equal(
          await renderer
            .locator(".soul-artwork")
            .evaluate((art) => getComputedStyle(art).filter),
          "none",
        );
      }
      await renderer.screenshot({
        path: resolve(
          out,
          `variant-${group === "Hạ rồng" ? "dragon" : group === "Linh hồn rồng" ? "soul" : group === "Phá trụ" ? "tower" : "buff"}-${value}.png`,
        ),
        omitBackground: true,
      });
    }
  }
  for (const pit of ["GRUB", "HERALD", "BARON"])
    for (const dragon of [
      "earth",
      "fire",
      "water",
      "air",
      "hextech",
      "chemtech",
      "elder",
    ]) {
      await studio.getByLabel("Hang Baron · loại").selectOption(pit);
      await studio.getByLabel("Hang rồng · loại").selectOption(dragon);
      await studio
        .getByRole("button", { name: "Timer mục tiêu", exact: false })
        .click();
      await renderer.waitForTimeout(200);
      assert.equal(
        await renderer.locator(".live-objective-stack .live-objective").count(),
        2,
      );
      assert.ok(
        (await renderer.locator(".live-objective-stack").innerHTML()).includes(
          `/broadcast/objectives/${pit === "GRUB" ? "grubs" : pit.toLowerCase()}.svg`,
        ),
      );
      assert.ok(
        (await renderer.locator(".live-objective-stack").innerHTML()).includes(
          `/broadcast/objectives/${dragon}.svg`,
        ),
      );
    }
  await studio
    .getByRole("button", { name: "Ẩn bảng thử / về bình thường", exact: false })
    .click();
  await writeFile(
    resolve(out, "measurements.json"),
    JSON.stringify(results, null, 2),
  );
  console.log(JSON.stringify({ out, results }, null, 2));
} finally {
  await browser.close();
}
