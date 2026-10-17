import test from "node:test";
import assert from "node:assert/strict";
import { existsSync, readdirSync, readFileSync } from "node:fs";
import { normalizeEog } from "../shared/eog-postgame";
import { postgameSchema } from "../shared/postgame";
import { redactEog } from "../server/eog-redact";

const fixture = JSON.parse(readFileSync("tests/fixtures/eog-stats-block.json", "utf8"));
const now = new Date("2026-10-17T10:10:00.000Z");

test("EOG block becomes the postgame contract: 10 players, damage, KDA, gold, winner and bots", () => {
  const p = normalizeEog(fixture, 2, now);
  assert.ok(postgameSchema.safeParse(p).success);
  assert.equal(p.source, "riot");
  assert.equal(p.evidence.mode, "lcu-eog");
  assert.equal(p.evidence.matchId, `LCU_${fixture.gameId}`);
  assert.equal(p.gameNumber, 2);
  assert.equal(p.duration, fixture.gameLength);
  // Team 200 is red and won in the measured game; sides map 100 -> blue, 200 -> red.
  assert.equal(p.winner, "red");
  assert.equal(p.evidence.isFinal, true);
  assert.deepEqual(p.evidence.roleOrderResolved, [true, true]);
  const [blue, red] = p.teams;
  assert.equal(blue.players.length, 5);
  assert.equal(red.players.length, 5);
  // Lane order TOP, JUNGLE, MID, BOT, SUPPORT from detectedTeamPosition.
  const order = fixture.teams.find((t: any) => t.teamId === 200).players;
  const lanes = ["TOP", "JUNGLE", "MIDDLE", "BOTTOM", "UTILITY"];
  assert.deepEqual(
    red.players.map((x) => x.champion),
    lanes.map((l) => String(order.find((o: any) => o.detectedTeamPosition === l).championId)),
  );
  assert.equal(
    red.players.every((x) => typeof x.damage === "number"),
    true,
  );
  assert.equal(
    red.kills,
    order.reduce((n: number, x: any) => n + x.stats.CHAMPIONS_KILLED, 0),
  );
  assert.equal(
    red.gold,
    order.reduce((n: number, x: any) => n + x.stats.GOLD_EARNED, 0),
  );
  assert.equal(
    [...blue.players, ...red.players].filter((x) => x.bot).length,
    fixture.teams.flatMap((t: any) => t.players).filter((x: any) => x.botPlayer).length,
  );
  // Nothing the block lacks is invented.
  for (const t of p.teams) {
    assert.deepEqual(t.bans, [null, null, null, null, null]);
    assert.equal(t.drakes, null);
    assert.equal(t.elders, null);
    assert.equal(t.barons, null);
  }
  assert.deepEqual(p.goldHistory, []);
  assert.equal(p.evidence.timelineAvailable, false);
});

test("EOG import carries no identity and rejects malformed blocks", () => {
  const raw = {
    ...fixture,
    teams: fixture.teams.map((t: any) => ({
      ...t,
      players: t.players.map((x: any) => ({
        ...x,
        puuid: "p",
        summonerName: "Someone",
        riotIdGameName: "Someone",
      })),
    })),
  };
  const text = JSON.stringify(normalizeEog(raw, 1, now));
  for (const secret of ["Someone", '"p"', "puuid"]) assert.ok(!text.includes(secret), secret);
  // The server also redacts before normalizing; the result is the same.
  assert.deepEqual(normalizeEog(redactEog(raw).value, 1, now), normalizeEog(raw, 1, now));
  assert.throws(() => normalizeEog({ ...fixture, teams: [fixture.teams[0]] }, 1, now));
  assert.throws(() => normalizeEog({ ...fixture, gameId: 0 }, 1, now));
  assert.throws(() => normalizeEog({}, 1, now));
  const missing = structuredClone(fixture);
  delete missing.teams[0].players[0].stats.TOTAL_DAMAGE_DEALT_TO_CHAMPIONS;
  const partial = normalizeEog(missing, 1, now);
  assert.equal(
    partial.teams[1].players.some((x) => x.damage === null),
    true,
  );
  assert.match(partial.evidence.warnings.join(" "), /thiếu damage/);
});

test(
  "real probe sample, when present locally, normalizes too",
  { skip: !existsSync(".npm-cache/lcu-eog") },
  () => {
    const files = readdirSync(".npm-cache/lcu-eog").filter((f) =>
      f.endsWith("-eog-stats-block.json"),
    );
    for (const file of files) {
      const p = normalizeEog(
        JSON.parse(readFileSync(`.npm-cache/lcu-eog/${file}`, "utf8")),
        1,
        now,
      );
      assert.equal(p.teams[0].players.length, 5);
    }
  },
);

test("live EOG is staged once per game for review and saved files accept plain names only", async () => {
  const { RiotPostgameService } = await import("../server/riot-postgame");
  const service = new RiotPostgameService();
  assert.equal(service.stageLiveEog(null), false);
  assert.equal(service.stageLiveEog({ gameId: 0 }), false);
  assert.equal(service.stageLiveEog(fixture), true);
  assert.equal(service.status().candidate?.evidence.matchId, `LCU_${fixture.gameId}`);
  // Same game again (for example after the operator cleared it) is not staged a second time.
  assert.equal(service.stageLiveEog(fixture), false);
  for (const file of [
    "../secret-eog-stats-block.json",
    "x/y-eog-stats-block.json",
    "notes.json",
    "",
  ])
    await assert.rejects(service.importEog({ gameNumber: 1, file }));
  await assert.rejects(service.importEog({ gameNumber: 1, file: "missing-eog-stats-block.json" }));
});
