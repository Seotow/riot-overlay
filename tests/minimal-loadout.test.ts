import test from "node:test";
import assert from "node:assert/strict";
import { minimalLoadout } from "../shared/minimal-loadout";
import { normalizeIngame } from "../server/ingame-adapter";
import { createState } from "../shared/mock";
import { themeSchema } from "../shared/schema";
import { seriesSlots, swapTeamSides } from "../shared/match-config";
import { LiveOverlay } from "../src/overlay/LiveOverlay";
import { createElement } from "react";
import { renderToStaticMarkup } from "react-dom/server";
import { ObserverSession } from "../server/observer-session";
import { liveCatalog } from "../shared/live-assets";

const capturedAt = "2026-10-16T00:00:00.000Z";
const observed = <T>(value: T) => ({
  value,
  availability: "observed" as const,
  source: "leaguebroadcast" as const,
  observedAt: capturedAt,
});
function fixture() {
  const sample = normalizeIngame(
    {
      gameData: { gameTime: 100 },
      allPlayers: Array.from({ length: 10 }, (_, i) => ({
        team: i < 5 ? "ORDER" : "CHAOS",
        items: [],
      })),
    },
    null,
    capturedAt,
  );
  sample.assetVersion = liveCatalog.version;
  for (const p of sample.players) {
    p.championId = observed(120);
    p.inventory = observed(
      [3152, 3157, 3026, 3142, 2003, 2055].map((id, slot) => ({
        id,
        slot,
        count: 1,
      })),
    );
    p.cooldowns = observed(
      [3152, 3157, 3026, 3142, 2003, 2055].map((id, i) => ({
        kind: "item" as const,
        id,
        slot: String(i),
        readyAt: 105,
        total: 90,
      })),
    );
    p.roleQuest = observed({
      role: "top" as const,
      itemId: 1220,
      completed: true,
      progress: 1,
      rewardSpellId: "S12_SummonerTeleportUpgrade",
      rewardItemId: null,
    });
    p.spells = observed(["SummonerFlash", "SummonerTeleport"]);
  }
  return sample;
}
test("minimal loadout keeps inventory slot order, max three actives, excludes consumables and retains source", () => {
  const sample = fixture(),
    p = sample.players[0],
    before = JSON.stringify(sample);
  assert.deepEqual(
    minimalLoadout(p).items.map((i) => i.id),
    [3152, 3157, 3026],
  );
  assert.ok(minimalLoadout(p).reward?.icon.includes("Teleport"));
  assert.equal(minimalLoadout(p).rewardCooldown, undefined);
  assert.equal(JSON.stringify(sample), before);
  p.inventory = observed([
    { id: 2003, slot: 0, count: 1 },
    { id: 2055, slot: 1, count: 1 },
    { id: 3026, slot: 2, count: 1 },
  ]);
  p.cooldowns = observed([]);
  assert.deepEqual(
    minimalLoadout(p).items.map((i) => i.id),
    [3026],
  );
});
test("top quest reuses only Teleport cooldown, never grants a fabricated cooldown to a new Teleport", () => {
  const p = fixture().players[0];
  p.cooldowns = observed([
    { kind: "spell", slot: "D", readyAt: 150, total: 300 },
    { kind: "spell", slot: "F", readyAt: 200, total: 300 },
  ]);
  assert.equal(minimalLoadout(p).rewardCooldown?.slot, "F");
  p.spells = observed(["SummonerFlash", "SummonerHeal"]);
  assert.equal(minimalLoadout(p).rewardCooldown, undefined);
  assert.ok(minimalLoadout(p).reward);
});
test("minimal markup reflects both sides and shifts actives up when quest is pending", () => {
  const sample = fixture();
  const render = () =>
    renderToStaticMarkup(
      createElement(LiveOverlay, {
        theme: { ...createState().theme, variant: "minimal" },
        frame: new ObserverSession().ingest(sample, "minimal-test", capturedAt),
        now: Date.parse(capturedAt),
      }),
    );
  let html = render();
  assert.equal((html.match(/minimal-active-item/g) ?? []).length, 30);
  assert.equal((html.match(/minimal-quest-reward/g) ?? []).length, 10);
  assert.equal((html.match(/data-position="3"/g) ?? []).length, 10);
  assert.equal((html.match(/data-side="red"/g) ?? []).length, 5);
  for (const p of sample.players) p.roleQuest!.value!.completed = false;
  html = render();
  assert.equal((html.match(/minimal-quest-reward/g) ?? []).length, 0);
  assert.equal((html.match(/data-position="0"/g) ?? []).length, 10);
  assert.equal((html.match(/data-position="3"/g) ?? []).length, 0);
});
test("series BO3/BO5, side swap and PNG center logos survive theme roundtrip", () => {
  const png = "data:image/png;base64,AAAA";
  const t = themeSchema.parse({
    ...createState().theme,
    seriesGames: 2,
    blueScore: 1,
    redScore: 2,
    blueLogo: png,
    scoreboardLogo: png,
    minimalLogo: png,
  });
  assert.equal(seriesSlots(t), 2);
  assert.equal(seriesSlots({ ...t, seriesGames: 3 }), 3);
  const swapped = swapTeamSides(t);
  assert.equal(swapped.blueName, t.redName);
  assert.equal(swapped.blueScore, 2);
  assert.equal(swapped.redLogo, png);
  assert.equal(swapped.blue, t.blue);
  assert.deepEqual(JSON.parse(JSON.stringify(swapTeamSides(swapped))), t);
  assert.deepEqual(themeSchema.parse(JSON.parse(JSON.stringify(t))), t);
  for (const key of ["minimalLogo", "scoreboardLogo"]) {
    assert.equal(
      themeSchema.safeParse({ ...t, [key]: "data:image/svg+xml;base64,AAAA" })
        .success,
      false,
    );
    assert.equal(
      themeSchema.safeParse({
        ...t,
        [key]: "data:image/png;base64," + "A".repeat(150001),
      }).success,
      false,
    );
  }
  const html = renderToStaticMarkup(
    createElement(LiveOverlay, { theme: t, frame: null, now: 0 }),
  );
  assert.equal((html.match(/alt="Logo giải đấu"/g) ?? []).length, 2);
  assert.equal((html.match(/class="won"/g) ?? []).length, 3);
});
