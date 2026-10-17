import test from "node:test";
import assert from "node:assert/strict";
import { readFileSync } from "node:fs";
import { normalizeRofl, reduceRofl, roflInputSchema } from "../shared/rofl-postgame";
import { postgameSchema } from "../shared/postgame";
import { roflGameId } from "../server/rofl";

const rows = roflInputSchema.parse(
  JSON.parse(readFileSync("tests/fixtures/rofl-rows.json", "utf8")),
);
const now = new Date("2026-10-17T12:00:00.000Z");

test("replay metadata becomes the postgame contract with real final stats", () => {
  const p = normalizeRofl(rows, 1, now);
  assert.ok(postgameSchema.safeParse(p).success);
  assert.equal(p.evidence.mode, "rofl");
  assert.equal(p.evidence.matchId, "VN2_1607368559");
  assert.equal(p.winner, "blue");
  assert.equal(p.duration, 786);
  assert.equal(p.evidence.isFinal, true);
  const [blue, red] = p.teams;
  // Final damage to champions from the replay file (matches the client's own match history).
  assert.equal(blue.players.map((x) => x.damage).includes(40241), true);
  assert.equal(red.players.map((x) => x.damage).includes(5889), true);
  assert.equal(blue.towers, 8);
  assert.deepEqual([blue.barons, blue.heralds, blue.grubs], [1, 1, 3]);
  assert.deepEqual([red.towers, red.barons, red.grubs], [0, 0, 0]);
  assert.equal([...blue.players, ...red.players].filter((x) => x.bot).length, 9);
  // Dragon split is not claimed; bans and gold history do not exist in a replay.
  for (const t of p.teams) {
    assert.equal(t.drakes, null);
    assert.equal(t.elders, null);
    assert.deepEqual(t.bans, [null, null, null, null, null]);
  }
  assert.deepEqual(p.goldHistory, []);
  assert.deepEqual(p.evidence.roleOrderResolved, [false, false]);
});

test("reduction keeps no identity and rejects malformed metadata", () => {
  const stats = rows.rows.map((r, i) => ({
    SKIN: r.champion,
    TEAM: String(r.team),
    WIN: r.win ? "Win" : "Fail",
    TEAM_POSITION: "",
    NAME: "Someone",
    PUUID: i === 0 ? "secret-puuid" : "",
    RIOT_ID_GAME_NAME: "Someone",
    CHAMPIONS_KILLED: "1",
    TOTAL_DAMAGE_DEALT_TO_CHAMPIONS: String(100 + i),
  }));
  const reduced = reduceRofl({ gameLength: 600000, statsJson: JSON.stringify(stats) }, 42);
  const text = JSON.stringify(reduced);
  for (const secret of ["Someone", "secret-puuid", "PUUID"])
    assert.ok(!text.includes(secret), secret);
  assert.equal(reduced.rows[0].bot, false);
  assert.equal(reduced.rows[1].bot, true);
  assert.equal(reduced.rows[3].stats.TOTAL_DAMAGE_DEALT_TO_CHAMPIONS, 103);
  assert.throws(() => reduceRofl({ gameLength: 1, statsJson: "[]" }, 1));
  assert.throws(() => reduceRofl({}, 1));
  assert.throws(() => normalizeRofl({ ...rows, rows: rows.rows.slice(1) } as never, 1, now));
});

test("replay file names carry the game id", () => {
  assert.equal(roflGameId("C:/x/VN2-1607368559.rofl"), 1607368559);
  assert.equal(roflGameId("notes.rofl"), null);
  assert.equal(roflGameId("VN2-12.txt"), null);
});
