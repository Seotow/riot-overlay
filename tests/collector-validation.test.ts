import test from "node:test";
import assert from "node:assert/strict";
import { normalizeCollector } from "../Collector/adapter";
import { normalizeIngame } from "../server/ingame-adapter";
import {
  compareCollectorReference,
  gamePreflight,
} from "../Collector/validation/compare";

const now = Date.parse("2026-10-15T00:00:00Z");
const codes = ["Ahri", "Garen", "Annie", "Ashe", "Lux"];
function reference(time = 100): any {
  return {
    gameData: { mapNumber: 11, gameTime: time },
    events: { Events: [] },
    allPlayers: Array.from({ length: 10 }, (_, i) => ({
      rawChampionName: `game_character_displayname_${codes[i % 5]}`,
      team: i < 5 ? "ORDER" : "CHAOS",
      riotId: "PRIVATE_SENTINEL",
      level: 10,
      scores: { kills: 0, deaths: 1, assists: 2, creepScore: 30 },
      items: [{ slot: 6, itemID: 3340, count: 1 }],
    })),
  };
}
function native(): any {
  return {
    schemaVersion: 1,
    sequence: 1,
    timestamp: new Date(now).toISOString(),
    type: "snapshot",
    source: "lblib",
    synthetic: false,
    recordedAt: null,
    data: {
      gameTime: 100,
      heroes: Array.from({ length: 10 }, (_, i) => ({
        heroIndex: i,
        info: {
          team: i < 5 ? 1 : 2,
          networkId: i + 1000,
          name: "PRIVATE_SENTINEL",
        },
        common: {
          identifier: codes[i % 5],
          level: 10,
          health: 500,
          maxHealth: 1000,
        },
        kills: 0,
        deaths: 1,
        assists: 2,
        totalGold: 5000,
        items: [{ slot: 6, id: 3340, count: 1 }],
      })),
    },
  };
}

test("live preflight requires advancing SR10 spectator, known roster and no GameEnd", () => {
  assert.equal(
    gamePreflight(reference(), reference(100.6), "Spectator"),
    "ready",
  );
  assert.equal(
    gamePreflight(reference(), reference(100.6), "PRIVATE_PLAYER"),
    "spectator-unverified",
  );
  assert.equal(
    gamePreflight(reference(), reference(), "Unknown"),
    "clock-not-advancing",
  );
  const end = reference(101);
  end.events.Events.push({ EventName: "GameEnd" });
  assert.equal(gamePreflight(reference(), end, "Unknown"), "game-ended");
  const partial = reference(101);
  partial.allPlayers.pop();
  assert.equal(
    gamePreflight(reference(), partial, "Unknown"),
    "SR10-unverified",
  );
  const duplicate = reference(101);
  duplicate.allPlayers[1].rawChampionName =
    duplicate.allPlayers[0].rawChampionName;
  assert.equal(
    gamePreflight(reference(), duplicate, "Unknown"),
    "roster-ambiguous",
  );
  const noEvents = reference(101);
  delete noEvents.events;
  assert.equal(
    gamePreflight(reference(), noEvents, "Unknown"),
    "end-state-unavailable",
  );
});

test("live comparison separates presence from equality and never exports identities or stats", () => {
  const c = normalizeCollector(native(), now)!.sample;
  const r = normalizeIngame(reference(100.2), {}, new Date(now).toISOString());
  const report = compareCollectorReference(c, r, now);
  assert.equal(report.aligned, true);
  assert.equal(report.rosterMatches, 10);
  assert.equal(report.fields.level.compared, 10);
  assert.equal(report.fields.level.matched, 10);
  assert.equal(report.fields.kills.matched, 10); // valid zero is compared
  assert.equal(report.fields.items.matched, 10);
  assert.equal(report.fields.health.nativePresent, 10);
  assert.equal(report.fields.health.referencePresent, 0);
  assert.equal(report.fields.health.compared, 0);
  assert.equal(report.fields.totalGold.compared, 0);
  assert.equal(report.fields.cs.nativePresent, 0);
  assert.equal(report.fields.cs.referencePresent, 10);
  assert.equal(report.fields.cs.compared, 0);
  assert.equal(report.fullParityVerified, false);
  assert.ok(!JSON.stringify(report).includes("SENTINEL"));
  assert.ok(!JSON.stringify(report).includes("championId"));
  const changed = reference(100.2);
  changed.allPlayers[0].level = 11;
  assert.equal(
    compareCollectorReference(
      c,
      normalizeIngame(changed, {}, new Date(now).toISOString()),
      now,
    ).fields.level.disagreed,
    1,
  );
});

test("stale/skewed or ambiguous roster samples cannot produce parity comparisons", () => {
  const c = normalizeCollector(native(), now)!.sample;
  const r = normalizeIngame(reference(101), {}, new Date(now).toISOString());
  assert.equal(compareCollectorReference(c, r, now).fields.level.compared, 0);
  r.gameTime.value = 100;
  assert.equal(compareCollectorReference(c, r, now + 5000).aligned, false);
  r.players[1].championId.value = r.players[0].championId.value;
  const ambiguous = compareCollectorReference(c, r, now);
  assert.equal(ambiguous.rosterComplete, false);
  assert.equal(ambiguous.rosterMatches, 0);
  assert.equal(ambiguous.fields.level.compared, 0);
  const validReference = normalizeIngame(
    reference(),
    {},
    new Date(now).toISOString(),
  );
  c.players[0].championId.source = "leaguebroadcast";
  assert.equal(
    compareCollectorReference(c, validReference, now).rosterComplete,
    false,
  );
  c.gameTime.source = "leaguebroadcast";
  assert.equal(compareCollectorReference(c, r, now).aligned, false);
});
