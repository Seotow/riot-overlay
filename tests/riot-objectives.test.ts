import test from "node:test";
import assert from "node:assert/strict";
import { enrichRiotObjectives } from "../server/riot-objectives";
import { normalizeIngame } from "../server/ingame-adapter";
import { ingameSampleSchema } from "../shared/observer";
import { sourceCoverage } from "../shared/coverage";
const now = "2026-09-24T00:00:00.000Z";
const start = { EventID: 0, EventName: "GameStart", EventTime: 0 };
const tower = { EventID: 1, EventName: "TurretKilled", EventTime: 100, KillerName: "Minion_T100", TurretKilled: "Turret_TChaos_L2_P3_2521511112_0" };
function sample(events: unknown[], time = 200, mapNumber = 11) {
  const raw = { gameData: { gameTime: time, mapNumber }, allPlayers: Array.from({ length: 10 }, (_, slot) => ({ summonerName: `PRIVATE-${slot}`, team: slot < 5 ? "ORDER" : "CHAOS", championId: 1, level: 1, scores: { kills: 0, deaths: 0, assists: 0, creepScore: 0 }, items: [] })), events: { Events: events } };
  return ingameSampleSchema.parse(enrichRiotObjectives(normalizeIngame(raw, null, now), raw));
}
test("Riot attributes minion tower kills by structure owner, deduplicates event IDs, and leaves dragons unknown", () => {
  const s = sample([start, tower, tower]);
  assert.equal(s.teams?.[0].towers.value, 1);
  assert.equal(s.teams?.[1].towers.value, 0);
  assert.equal(s.teams?.[0].towers.source, "riot-events");
  assert.equal(s.teams?.[0].dragons.value, null);
  assert.equal(s.teams?.[0].totalGold.value, null);
  assert.equal(s.events.filter(e => e.kind === "TurretKilled").length, 1);
  assert.equal(s.events[1].team, "ORDER");
  assert.ok(!JSON.stringify(s).includes("PRIVATE"));
});
test("missing history, gaps, malformed tower IDs, conflicting duplicates and unsupported maps clear tower totals", () => {
  for (const events of [[tower], [start, { ...tower, EventID: 2 }], [start, { ...tower, TurretKilled: "unknown" }], [start, tower, { ...tower, EventTime: 101 }]]) {
    assert.equal(sample(events).teams?.[0].towers.value, null);
  }
  assert.equal(sample([start, tower], 200, 30).teams?.[0].towers.value, null);
});
test("seeking before a kill removes future totals and does not count repeated structure names as duplicate kills", () => {
  assert.equal(sample([start, tower], 50).teams?.[0].towers.value, 0);
  const repeated = sample([start, tower, { ...tower, EventID: 2, EventTime: 150 }]);
  assert.equal(repeated.teams?.[0].towers.value, 2);
});
test("objective attribution does not expose player names or treat partial dragon history as full totals", () => {
  const s = sample([start, { EventID: 1, EventName: "DragonKill", EventTime: 50, KillerName: "PRIVATE-6", DragonType: "Hextech" }]);
  assert.equal(s.events[1].team, "CHAOS");
  assert.equal(s.events[1].objectiveType, "hextech");
  assert.equal(s.teams?.[1].dragons.value, null);
  const rows = sourceCoverage(s);
  assert.equal(rows.find(r => r.id === "team-towers")?.available, 2);
  assert.equal(rows.find(r => r.id === "team-dragons")?.available, 0);
  assert.match(rows.find(r => r.id === "team-dragons")!.note, /bỏ sót/);
});
