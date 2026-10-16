import test from "node:test";
import assert from "node:assert/strict";
import { capturePrivacy } from "../Collector/validation/capture-privacy";
import { normalizeCollector } from "../Collector/adapter/normalize";
import { parseCapture, CaptureReplay } from "../server/capture-replay";

test("collector archive retains gameplay identifiers and names, filters nested authentication only", () => {
  const value = {
    gameId: "match-42",
    info: { name: "Player#VN", networkId: 123456 },
    killerNetworkId: 123456,
    assisterNetworkIds: [789],
    password: "PASSWORD_SENTINEL",
    auth: { email: "EMAIL_SENTINEL", accessToken: "TOKEN_SENTINEL" },
    common: { identifier: "Yasuo" },
    buffs: [{ name: "sru_dragon_chemtech", count: 1 }],
  };
  const out = capturePrivacy()(value) as any;
  assert.equal(out.gameId, "match-42");
  assert.equal(out.info.name, "Player#VN");
  assert.equal(out.info.networkId, out.killerNetworkId);
  assert.equal(out.killerNetworkId, 123456);
  assert.deepEqual(out.assisterNetworkIds, [789]);
  assert.deepEqual(out.buffs, value.buffs);
  assert.ok(!JSON.stringify(out).includes("SENTINEL"));
  assert.equal(value.password, "PASSWORD_SENTINEL");
});
test("collector capture replays normalized telemetry/events without LB and rejects a different source", () => {
  const now = Date.parse("2026-10-16T12:00:00Z");
  const make = (time: number) =>
    normalizeCollector(
      {
        schemaVersion: 1,
        sequence: 1,
        timestamp: new Date(now).toISOString(),
        type: "snapshot",
        source: "lblib",
        synthetic: false,
        recordedAt: null,
        data: {
          gameTime: time,
          heroes: Array.from({ length: 10 }, (_, i) => ({
            heroIndex: i,
            info: { team: i < 5 ? 1 : 2 },
            common: {
              identifier: "Yasuo",
              level: 10,
              health: 700,
              maxHealth: 1000,
            },
            gold: 50,
            totalGold: 4000,
            kills: 0,
            deaths: 0,
            assists: 0,
          })),
        },
      },
      now,
    )!.sample;
  const a = make(100),
    b = make(100.5);
  b.events = [
    { id: 1, at: 100.5, kind: "ChampionKill", team: "ORDER", playerSlot: 0 },
  ];
  const line = (offset: number, sample: unknown) =>
    JSON.stringify({
      receivedAt: new Date(now + offset).toISOString(),
      message: { type: "collector-sample", sample },
    });
  const entries = parseCapture([line(0, a), line(500, b)].join("\n"));
  assert.equal(entries.length, 2);
  assert.equal(entries[0].sample.players[0].health?.value?.current, 700);
  assert.equal(entries[1].sample.events[0].kind, "ChampionKill");
  const replay = new CaptureReplay(() => now);
  replay.loadEntries("fixture", entries);
  assert.equal(replay.observe().sample?.players[0].totalGold.value, 4000);
  replay.control({ positionMs: 500 });
  assert.equal(replay.observe().sample?.gameTime.value, 100.5);
  assert.equal(replay.observe().sample?.events[0].kind, "ChampionKill");
  assert.throws(() =>
    parseCapture(
      line(0, { ...a, gameTime: { ...a.gameTime, source: "live-client" } }),
    ),
  );
});
