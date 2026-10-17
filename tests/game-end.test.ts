import test from "node:test";
import assert from "node:assert/strict";
import { mkdtemp, readFile, rm } from "node:fs/promises";
import { tmpdir } from "node:os";
import { join } from "node:path";
import { GameEndWatch } from "../collector/adapter/game-end";
import { MatchLedger } from "../server/match-ledger";
import { normalizeRofl, roflInputSchema } from "../shared/rofl-postgame";
import { readFileSync } from "node:fs";

type Hq = { team: number; health: number; max?: number };
const snap = (time: number, hqs: Hq[] | undefined, gameId = "VN2-1607368559") => ({
  type: "snapshot",
  data: {
    gameTime: time,
    gameId,
    heroes: Array.from({ length: 10 }, () => ({})),
    ...(hqs
      ? {
          hqs: hqs.map((h) => ({
            info: { team: h.team, name: "Nexus" },
            health: h.health,
            maxHealth: h.max ?? 5500,
            status: 1,
          })),
        }
      : {}),
  },
});
const alive = [
  { team: 1, health: 5500 },
  { team: 2, health: 5500 },
];

test("Nexus at 0 health decides the winner and keeps the game id and the last snapshots", () => {
  const w = new GameEndWatch();
  w.observe(snap(100, alive));
  assert.equal(w.winner(), null);
  w.observe(
    snap(790, [
      { team: 1, health: 3000 },
      { team: 2, health: 1200 },
    ]),
  );
  assert.equal(w.winner(), null);
  w.observe(
    snap(791, [
      { team: 1, health: 3000 },
      { team: 2, health: 0 },
    ]),
  );
  const end = w.snapshot();
  assert.equal(end.winner, "blue"); // CHAOS Nexus fell
  assert.equal(end.destroyedAt, 791);
  assert.equal(end.gameId, 1607368559);
  assert.equal(end.tail.at(-1)!.nexus.CHAOS!.health, 0);
  assert.ok(end.tail.length <= 60);
});

test("a Nexus that vanishes after being alive counts only while the other is still there", () => {
  const w = new GameEndWatch();
  w.observe(snap(100, alive));
  w.observe(snap(790, [{ team: 2, health: 800 }]));
  assert.equal(w.winner(), "red"); // ORDER Nexus gone, CHAOS present
  // Both gone, or no data, or never seen alive: ambiguous.
  const both = new GameEndWatch();
  both.observe(snap(100, alive));
  both.observe(snap(790, []));
  assert.equal(both.winner(), null);
  const never = new GameEndWatch();
  never.observe(snap(790, [{ team: 2, health: 800 }]));
  assert.equal(never.winner(), null);
  const none = new GameEndWatch();
  none.observe(snap(100, undefined));
  assert.equal(none.winner(), null);
  assert.deepEqual(none.snapshot().tail, []);
});

test("a destroyed reading that turns alive again is not a kill; a new game starts clean", () => {
  const w = new GameEndWatch();
  w.observe(snap(100, alive));
  w.observe(
    snap(200, [
      { team: 1, health: 0 },
      { team: 2, health: 5500 },
    ]),
  );
  assert.equal(w.winner(), "red");
  w.observe(snap(201, alive));
  assert.equal(w.winner(), null);
  w.observe(
    snap(300, [
      { team: 1, health: 0 },
      { team: 2, health: 5500 },
    ]),
  );
  assert.equal(w.winner(), "red");
  // Other game id: reset, the old winner does not carry over.
  w.observe(snap(10, alive, "VN2-1700000000"));
  assert.equal(w.winner(), null);
  assert.equal(w.snapshot().gameId, 1700000000);
  // Clock jumping back also starts over.
  w.observe(
    snap(
      500,
      [
        { team: 2, health: 0 },
        { team: 1, health: 100 },
      ],
      "VN2-1700000000",
    ),
  );
  assert.equal(w.winner(), "blue");
  w.observe(snap(20, alive, "VN2-1700000000"));
  assert.equal(w.winner(), null);
  assert.equal(w.snapshot().tail.length, 1);
});

test("ledger takes the winner and game id from the Nexus watch and writes the last snapshots", async () => {
  const dir = await mkdtemp(join(tmpdir(), "ledger-"));
  try {
    const ledger = new MatchLedger(dir);
    const frame = {
      status: "observed",
      sample: {
        gameTime: { value: 700 },
        players: Array.from({ length: 10 }, () => ({})),
        teams: [
          { team: "ORDER", totalGold: { value: 60000 } },
          { team: "CHAOS", totalGold: { value: 20000 } },
        ],
        events: [],
      },
    } as never;
    ledger.observe(frame, null);
    const w = new GameEndWatch();
    w.observe(snap(700, alive));
    w.observe(
      snap(790, [
        { team: 1, health: 4000 },
        { team: 2, health: 0 },
      ]),
    );
    await ledger.observeEnd(w.snapshot());
    const snapshot = ledger.snapshot()!;
    assert.equal(snapshot.gameId, 1607368559);
    assert.equal(snapshot.winner, "blue");
    const tail = JSON.parse(await readFile(join(dir, "game-end-tail.json"), "utf8"));
    assert.equal(tail.winner, "blue");
    assert.equal(tail.gameId, 1607368559);
    assert.ok(Array.isArray(tail.tail) && tail.tail.length === 2);
    assert.ok(!JSON.stringify(tail).match(/puuid|summoner/i));
  } finally {
    await rm(dir, { recursive: true, force: true });
  }
});

test("replay postgame notes when the Nexus winner agrees or disagrees", () => {
  const rows = roflInputSchema.parse(
    JSON.parse(readFileSync("tests/fixtures/rofl-rows.json", "utf8")),
  );
  const base = {
    gameId: 1607368559,
    firstGameTime: 20,
    lastGameTime: 786,
    gold: [],
    dragons: [],
  };
  const now = new Date("2026-10-17T12:00:00.000Z");
  const agree = normalizeRofl(rows, 1, now, { ...base, winner: "blue" });
  assert.match(agree.evidence.warnings.join(" "), /Winner khớp/);
  const clash = normalizeRofl(rows, 1, now, { ...base, winner: "red" });
  assert.match(clash.evidence.warnings.join(" "), /replay ghi đội xanh thắng/);
  assert.equal(clash.winner, "blue"); // the replay stays authoritative
});
