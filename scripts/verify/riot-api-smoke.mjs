// Isolated browser QA. All credential values and Riot responses below are synthetic.
import assert from "node:assert/strict";
import { createRequire } from "node:module";
import { resolve } from "node:path";
import { mkdir } from "node:fs/promises";
import { normalizeRiotPostgame } from "../../server/riot-postgame.ts";
const base = process.env.OVERLAY_VISUAL_URL;
assert.match(base ?? "", /^http:\/\/127\.0\.0\.1:\d+$/);
assert.ok(!base.endsWith(":4310"));
const { chromium } = createRequire(import.meta.url)(
  resolve(process.env.OVERLAY_BROWSER_PACKAGES, "playwright"),
);
const browser = await chromium.launch({ channel: "msedge", headless: true });
await mkdir(".npm-cache/visual-audit", { recursive: true });
try {
  const context = await browser.newContext({
    viewport: { width: 1920, height: 1080 },
  });
  const page = await context.newPage(),
    obs = await context.newPage();
  const errors = [];
  for (const p of [page, obs]) p.on("pageerror", (e) => errors.push(String(e)));
  await page.goto(base + "/?page=postgame");
  const panel = page.locator(".riot-postgame-panel");
  await panel.getByText("Chưa nhập key/token", { exact: true }).waitFor();
  assert.equal(
    await panel
      .getByRole("button", {
        name: "Tải match + timeline / kiểm tra quyền",
        exact: true,
      })
      .isDisabled(),
    true,
  );
  await page.getByRole("button", { name: "Nạp bộ mẫu theo ảnh", exact: true }).click();
  await obs.goto(base + "/overlay?scene=postgame");
  await obs.locator('[data-source="sample"]').waitFor();
  const secret = "SYNTHETIC-BROWSER-QA-KEY-NOT-REAL";
  await panel.getByLabel("Riot key hoặc token", { exact: true }).fill(secret);
  await panel.getByRole("button", { name: "Lưu key/token trong phiên", exact: true }).click();
  await panel.getByText("Đã có key/token trong RAM", { exact: true }).waitFor();
  assert.equal(await panel.getByLabel("Riot key hoặc token", { exact: true }).inputValue(), "");
  const stored = await page.evaluate(
    async () => await (await fetch("/api/riot-postgame/status")).text(),
  );
  assert.doesNotMatch(stored, /SYNTHETIC|secret/);
  assert.equal(
    await page.evaluate(() => Object.keys(localStorage).some((k) => /riot|token|secret/i.test(k))),
    false,
  );
  await panel.getByLabel("Riot match ID", { exact: true }).fill("https://evil.test/");
  assert.equal(
    await panel
      .getByRole("button", {
        name: "Tải match + timeline / kiểm tra quyền",
        exact: true,
      })
      .isDisabled(),
    true,
  );
  await panel.getByLabel("Riot match ID", { exact: true }).fill("VN2_123456");
  // Synthetic load for review UI only. Publish still goes to the real isolated backend,
  // which must reject this forged browser-only candidate (no upstream Riot data loaded).
  const participants = Array.from({ length: 10 }, (_, i) => ({
    participantId: i + 1,
    teamId: i < 5 ? 100 : 200,
    teamPosition: ["TOP", "JUNGLE", "MIDDLE", "BOTTOM", "UTILITY"][i % 5],
    championId: (i % 5) + 1,
    goldEarned: 10000,
    kills: 1,
    deaths: 1,
    assists: 3,
    totalDamageDealtToChampions: 1000,
  }));
  const candidate = normalizeRiotPostgame(
    {
      metadata: { matchId: "VN2_123456" },
      info: {
        platformId: "VN2",
        gameVersion: "16.20.123.456",
        gameDuration: 120,
        participants,
        teams: [100, 200].map((teamId) => ({
          teamId,
          win: teamId === 100,
          objectives: {},
        })),
      },
    },
    null,
    "VN2_123456",
    "standard",
    1,
  );
  await page.route("**/api/riot-postgame/load", (route) =>
    route.fulfill({
      status: 200,
      contentType: "application/json",
      body: JSON.stringify({
        configured: true,
        mode: "standard",
        storage: "memory",
        retryAfter: 0,
        candidate,
      }),
    }),
  );
  await panel
    .getByRole("button", {
      name: "Tải match + timeline / kiểm tra quyền",
      exact: true,
    })
    .click();
  await panel.locator(".riot-candidate").waitFor();
  await panel.locator('.production-postgame[data-source="riot"]').waitFor();
  assert.equal(
    await panel
      .getByRole("button", {
        name: "Dùng dữ liệu Riot cho postgame",
        exact: true,
      })
      .isDisabled(),
    true,
  );
  assert.equal(
    await obs.locator('[data-source="sample"]').count(),
    1,
    "Staging does not replace OBS",
  );
  await panel.getByRole("checkbox").check();
  await panel
    .getByRole("button", {
      name: "Dùng dữ liệu Riot cho postgame",
      exact: true,
    })
    .click();
  await panel
    .getByText("Chưa có bản dữ liệu đã tải khớp match ID để phát.", {
      exact: false,
    })
    .waitFor();
  assert.equal(
    await obs.locator('[data-source="sample"]').count(),
    1,
    "Browser cannot impersonate Riot source",
  );
  await panel.getByRole("button", { name: "Xóa key/token", exact: true }).click();
  await panel.getByText("Chưa nhập key/token", { exact: true }).waitFor();
  assert.equal(await panel.locator(".riot-candidate").count(), 0);
  await panel.getByLabel("Riot match ID", { exact: true }).fill("");
  await panel.getByLabel("Kiểu xác thực Riot", { exact: true }).selectOption("rso");
  await panel.getByText("Nhập access token RSO đã cấp", { exact: false }).waitFor();
  await panel.getByLabel("Kiểu xác thực Riot", { exact: true }).selectOption("standard");
  await panel.screenshot({
    path: ".npm-cache/visual-audit/riot-api-config-ready.png",
  });
  await page.setViewportSize({ width: 1280, height: 800 });
  assert.equal(await page.evaluate(() => document.documentElement.scrollWidth <= innerWidth), true);
  await panel.screenshot({
    path: ".npm-cache/visual-audit/riot-api-config-1280.png",
  });
  assert.deepEqual(errors, []);
  console.log(
    "PASS Riot config: password/RAM/clear, no secret in status/localStorage, validation, Standard/RSO, staged renderer, publish guard, 1920/1280; no real Riot calls",
  );
} finally {
  await browser.close();
}
