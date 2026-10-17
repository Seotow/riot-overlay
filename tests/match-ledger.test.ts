import test from "node:test";
import assert from "node:assert/strict";
import { readFileSync } from "node:fs";
import { normalizeRofl, roflInputSchema } from "../shared/rofl-postgame";
import type { LedgerSnapshot } from "../shared/match-ledger";
import { MatchLedger } from "../server/match-ledger";

const rows = roflInputSchema.parse(
  JSON.parse(readFileSync("tests/fixtures/rofl-rows.json", "utf8")),
);
const now = new Date("2026-10-17T12:00:00.000Z");
const ledger = (over: Partial<LedgerSnapshot> = {}): LedgerSnapshot => ({
  gameId: 1607368559,
  firstGameTime: 20,
  lastGameTime: 786,
  gold: [
    { at: 20, blue: 2500, red: 2500 },
    { at: 300, blue: 12000, red: 9000 },
    { at: 786, blue: 63000, red: 17000 },
  ],
  dragons: [
    { at: 330, team: "ORDER", type: "fire" },
    { at: 600, team: "ORDER", type: "earth" },
    { at: 640, team: "ORDER", type: "water" },
    { at: 700, team: "ORDER", type: "air" },
    { at: 760, team: "ORDER", type: "elder" },
  ],
  ...over,
});

test("collector ledger adds dragons and gold over time when it matches the replay", () => {
  const p = normalizeRofl(rows, 1, now, ledger());
  const [blue, red] = p.teams;
  // The replay counts five dragon kills for the blue team: 4 elemental + 1 Elder adds up.
  assert.deepEqual([blue.drakes, blue.elders, red.drakes, red.elders], [4, 1, 0, 0]);
  assert.deepEqual(
    p.goldHistory.map((x) => x.delta),
    [0, 3000, 46000],
  );
  assert.equal(p.evidence.timelineAvailable, true);
  assert.match(p.evidence.warnings.join(" "), /collector trong trận/);
});

test("ledger that disagrees with the replay, or belongs to another game, is not used", () => {
  const wrong = normalizeRofl(rows, 1, now, ledger({ dragons: ledger().dragons.slice(0, 3) }));
  assert.equal(wrong.teams[0].drakes, null);
  assert.equal(wrong.teams[0].elders, null);
  assert.match(wrong.evidence.warnings.join(" "), /không khớp replay/);
  const other = normalizeRofl(rows, 1, now, ledger({ gameId: 42 }));
  assert.equal(other.teams[0].drakes, null);
  assert.deepEqual(other.goldHistory, []);
  // Unknown game id: matched by game length, which fits here (786 s) and not for a short ledger.
  assert.deepEqual(normalizeRofl(rows, 1, now, ledger({ gameId: null })).goldHistory.length, 3);
  assert.deepEqual(
    normalizeRofl(rows, 1, now, ledger({ gameId: null, lastGameTime: 300 })).goldHistory,
    [],
  );
  assert.deepEqual(normalizeRofl(rows, 1, now, null).goldHistory, []);
});

const frame = (time: number, blue: number, red: number, events: unknown[] = []) =>
  ({
    status: "observed",
    sample: {
      gameTime: { value: time },
      players: Array.from({ length: 10 }, () => ({})),
      teams: [
        { team: "ORDER", totalGold: { value: blue } },
        { team: "CHAOS", totalGold: { value: red } },
      ],
      events,
    },
  }) as never;

test("ledger samples gold every 15 seconds, dedupes dragon events and starts over on a new game", () => {
  const l = new MatchLedger();
  l.observe(frame(100, 5000, 4000), 7);
  l.observe(frame(103, 5100, 4100), 7); // same 15 s bucket: no new point
  const dragon = { id: 9, at: 110, kind: "DragonKill", team: "ORDER", objectiveType: "fire" };
  l.observe(frame(120, 6000, 4500, [dragon]), 7);
  l.observe(frame(121, 6100, 4600, [dragon]), 7); // same event id again
  let snap = l.snapshot()!;
  assert.equal(snap.gameId, 7);
  assert.deepEqual(
    snap.gold.map((g) => g.at),
    [100, 120],
  );
  assert.equal(snap.dragons.length, 1);
  // Clock jumps back (a new game): fresh ledger.
  l.observe(frame(10, 2500, 2500), 8);
  snap = l.snapshot()!;
  assert.equal(snap.gameId, 8);
  assert.equal(snap.gold.length, 1);
  assert.equal(snap.dragons.length, 0);
  // Frames without ten players or without data are ignored.
  l.observe({ status: "idle", sample: null } as never, 8);
  assert.equal(l.snapshot()!.gold.length, 1);
});
