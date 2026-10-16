import test from "node:test";
import assert from "node:assert/strict";
import { normalizeIngame, rosterSignature } from "../server/ingame-adapter";
import { ObserverSession } from "../server/observer-session";
import { recordingSchema } from "../shared/observer";
const stamp = (seconds: number) =>
  new Date(Date.UTC(2026, 8, 19) + seconds * 1000).toISOString();
function fixture(clock = 100, events: unknown[] = []) {
  return {
    gameData: { gameTime: clock },
    allPlayers: Array.from({ length: 10 }, (_, i) => ({
      riotId: `PRIVATE-${i}`,
      summonerName: `PRIVATE-${i}`,
      team: i < 5 ? "ORDER" : "CHAOS",
      championId: i + 1,
      level: 10,
      scores: { kills: i, deaths: 0, assists: 2, creepScore: 100 },
      items: [{ itemID: 1001 }],
      token: "SECRET",
      championStats: { currentHealth: 10 },
    })),
    activePlayer: { currentGold: 555 },
    events: { Events: events },
    password: "SECRET",
  };
}
const event = (id: number, at: number) => ({
  EventID: id,
  EventTime: at,
  EventName: "ChampionKill",
  KillerName: "PRIVATE",
  VictimName: "PRIVATE",
  token: "SECRET",
});
const sample = (
  time: number,
  wall = time,
  events: unknown[] = [],
  playback: unknown = null,
) => normalizeIngame(fixture(time, events), playback, stamp(wall));
test("adapter preserves zero, empty inventory and missing gold independently", () => {
  const input = fixture();
  input.allPlayers[0].items = [];
  const result = normalizeIngame(input, null, stamp(1));
  assert.equal(result.players.length, 10);
  assert.equal(result.players[0].deaths.value, 0);
  assert.deepEqual(result.players[0].items.value, []);
  assert.equal(result.players[0].totalGold.value, null);
  assert.equal(result.players[0].totalGold.availability, "missing");
  assert.equal(result.replay.paused.value, null);
});
test("adapter rejects wrong types, nonfinite values and partial inventories", () => {
  const result = normalizeIngame(
    {
      gameData: { gameTime: "100" },
      allPlayers: [
        {
          level: 0,
          championId: -1,
          totalGold: Infinity,
          scores: { kills: -1, deaths: "0", assists: 1.5, creepScore: NaN },
          items: [{ itemID: 1001 }, {}],
          team: "PRIVATE",
        },
      ],
    },
    { paused: "false", speed: -1, time: 0 },
    stamp(1),
  );
  const p = result.players[0];
  for (const f of [
    p.level,
    p.championId,
    p.totalGold,
    p.kills,
    p.deaths,
    p.assists,
    p.cs,
    p.items,
    p.team,
  ])
    assert.equal(f.value, null);
  assert.equal(result.replay.time.value, 0);
  assert.equal(result.replay.paused.value, null);
});
test("replay-only sample exposes clocks without inventing player stats", () => {
  const result = normalizeIngame(
    null,
    { time: 60, speed: 2, paused: false, token: "SECRET" },
    stamp(1),
  );
  assert.equal(result.gameTime.value, null);
  assert.deepEqual(result.players, []);
  assert.equal(result.replay.time.value, 60);
  assert.equal(result.replay.paused.value, false);
  assert.ok(!JSON.stringify(result).includes("SECRET"));
});
test("export is allowlisted and caps player and event input", () => {
  const input = fixture(100, [
    event(1, 2),
    { EventID: 2, EventTime: 3, EventName: "SECRET" },
  ]);
  input.allPlayers.push(input.allPlayers[0]);
  const result = normalizeIngame(input, null, stamp(1));
  assert.equal(result.players.length, 10);
  assert.equal(result.limits.playersTruncated, true);
  assert.equal(result.events.length, 1);
  assert.ok(
    !/SECRET|password|riotId|summonerName/.test(JSON.stringify(result)),
  );
  const long = normalizeIngame(
    fixture(
      5000,
      Array.from({ length: 4100 }, (_, i) => event(i, i)),
    ),
    null,
    stamp(2),
  );
  assert.equal(long.events.length, 4096);
  assert.equal(long.limits.eventsTruncated, true);
});
test("new connection seeds history, normal events deduplicate, future events wait", () => {
  const session = new ObserverSession();
  const first = session.ingest(
    sample(100, 0, [event(1, 90), event(2, 102)]),
    "roster",
    stamp(0),
  );
  assert.equal(first.transition, "connected");
  assert.deepEqual(first.newEvents, []);
  const second = session.ingest(
    sample(101, 1, [event(1, 90), event(3, 101), event(3, 101), event(2, 102)]),
    "roster",
    stamp(1),
  );
  assert.deepEqual(
    second.newEvents.map((e) => e.id),
    [3],
  );
  assert.equal(second.sessionId, first.sessionId);
  const third = session.ingest(
    sample(102, 2, [event(1, 90), event(2, 102), event(3, 101)]),
    "roster",
    stamp(2),
  );
  assert.deepEqual(
    third.newEvents.map((e) => e.id),
    [2],
  );
  assert.equal(third.sequence, 3);
});
test("pause and playback speed preserve session without wall-clock extrapolation", () => {
  const s = new ObserverSession();
  s.ingest(sample(100, 0), "r", stamp(0));
  const paused = s.ingest(
    sample(100, 1, [], { time: 100, paused: true, speed: 1 }),
    "r",
    stamp(1),
  );
  assert.equal(paused.transition, "none");
  assert.equal(paused.sample?.gameTime.value, 100);
  const fast = s.ingest(
    sample(120, 2, [], { time: 120, paused: false, speed: 20 }),
    "r",
    stamp(2),
  );
  assert.equal(fast.transition, "none");
  assert.equal(fast.epoch, 0);
});
test("backwards and forward seeks create epochs and suppress historical alerts", () => {
  const s = new ObserverSession();
  const a = s.ingest(sample(100, 0, [event(1, 90)]), "r", stamp(0));
  const back = s.ingest(sample(50, 1, [event(1, 90)]), "r", stamp(1));
  assert.equal(back.transition, "seek");
  assert.equal(back.epoch, 1);
  assert.equal(back.sessionId, a.sessionId);
  assert.deepEqual(back.newEvents, []);
  const forward = s.ingest(
    sample(200, 2, [event(1, 90), event(2, 150)]),
    "r",
    stamp(2),
  );
  assert.equal(forward.epoch, 2);
  assert.deepEqual(forward.newEvents, []);
});
test("loss clears data; reconnect and roster changes rotate sessions", () => {
  const s = new ObserverSession();
  const first = s.ingest(sample(100, 0), "a", stamp(0));
  const lost = s.ingest(null, "", stamp(1));
  assert.equal(lost.status, "unavailable");
  assert.equal(lost.sample, null);
  assert.equal(lost.transition, "lost");
  const again = s.ingest(sample(101, 2, [event(1, 90)]), "a", stamp(2));
  assert.equal(again.transition, "reconnected");
  assert.notEqual(again.sessionId, first.sessionId);
  assert.deepEqual(again.newEvents, []);
  const changed = s.ingest(sample(102, 3), "b", stamp(3));
  assert.equal(changed.transition, "source-changed");
  assert.notEqual(changed.sessionId, again.sessionId);
});
test("recording validates, stays bounded and rejects raw injected fields", () => {
  const s = new ObserverSession();
  for (let i = 0; i < 130; i++) s.ingest(sample(i, i), "r", stamp(i));
  const record = s.recording();
  assert.ok(record.frames.length <= 120);
  assert.equal(record.frames.at(-1)?.sequence, 130);
  assert.ok(!/SECRET|password|riotId|summonerName/.test(JSON.stringify(record)));
  assert.equal(
    recordingSchema.safeParse({ ...record, password: "SECRET" }).success,
    false,
  );
  assert.deepEqual(
    recordingSchema.parse(JSON.parse(JSON.stringify(record))),
    record,
  );
});
test("roster identity is private but distinguishes a new match roster", () => {
  const a = fixture(),
    b = fixture();
  b.allPlayers[0].riotId = "different";
  assert.notEqual(rosterSignature(a), rosterSignature(b));
  assert.equal(rosterSignature(a), rosterSignature(fixture()));
});

test("a long observation gap starts a fresh session and seeds events", () => {
  const s = new ObserverSession();
  const first = s.ingest(sample(100, 0), "r", stamp(0));
  const next = s.ingest(sample(110, 10, [event(1, 105)]), "r", stamp(10));
  assert.equal(next.transition, "reconnected");
  assert.notEqual(next.sessionId, first.sessionId);
  assert.deepEqual(next.newEvents, []);
});
test("recording evicts old frames by byte budget as well as frame count", () => {
  const s = new ObserverSession();
  const events = Array.from({ length: 4096 }, (_, i) => event(i, i));
  for (let i = 0; i < 20; i++)
    s.ingest(sample(5000 + i, i, events), "r", stamp(i));
  const record = s.recording();
  assert.ok(record.frames.length < 20);
  assert.ok(Buffer.byteLength(JSON.stringify(record)) < 2_001_000);
});
