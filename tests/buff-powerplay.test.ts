import test from "node:test";
import assert from "node:assert/strict";
import type { IngameSample, ObserverFrame } from "../shared/observer";
import {
  advanceElderWindow,
  advanceBaronWindow,
  baronGoldDelta,
  ELDER_BUFF_SECONDS,
} from "../shared/baron-powerplay";

const sample = (time: number, buff: boolean | null = true) =>
  ({
    gameTime: { value: time },
    players: Array.from({ length: 10 }, (_, slot) => ({
      slot,
      team: { value: slot < 5 ? "ORDER" : "CHAOS" },
      isDead: { value: slot === 4 },
      hasElder: { value: slot < 4 ? buff : false },
      hasBaron: { value: slot < 4 ? buff : false },
    })),
    teams: [
      { team: "ORDER", totalGold: { value: 10000 } },
      { team: "CHAOS", totalGold: { value: 11000 } },
    ],
  }) as IngameSample;
const frame = (s: IngameSample, events: ObserverFrame["newEvents"] = []) =>
  ({
    sample: s,
    transition: "none",
    newEvents: events,
  }) as ObserverFrame;

test("Elder lasts 150 game seconds, ends on full buff loss, never grants buff to dead players", () => {
  assert.equal(ELDER_BUFF_SECONDS, 150);
  const s = sample(100);
  const event = {
    kind: "DragonKill",
    objectiveType: "elder",
    team: "ORDER",
    at: 100,
  } as ObserverFrame["newEvents"][number];
  const window = advanceElderWindow(null, frame(s, [event]));
  assert.deepEqual(window, { team: "ORDER", startedAt: 100 });
  assert.equal(s.players[4].hasElder?.value, false);
  assert.deepEqual(advanceElderWindow(window, frame(sample(249.99))), window);
  assert.equal(advanceElderWindow(window, frame(sample(250))), null);
  assert.equal(advanceElderWindow(window, frame(sample(110, false))), null);
  assert.deepEqual(advanceElderWindow(window, frame(sample(110, null))), window);
  assert.equal(advanceElderWindow(window, { ...frame(s), transition: "seek" }), null);
  assert.ok(!Object.hasOwn(window!, "goldDelta"));
});

test("Baron starts +1500 including dead teammate, tracks net gold and ends at 180 seconds", () => {
  const s = sample(100);
  const event = {
    kind: "BaronKill",
    team: "ORDER",
    at: 100,
  } as ObserverFrame["newEvents"][number];
  const window = advanceBaronWindow(null, frame(s, [event]))!;
  assert.equal(baronGoldDelta(window, s), 1500);
  assert.equal(s.players[4].hasBaron?.value, false);
  const next = sample(110);
  next.teams![0].totalGold.value = 10700;
  next.teams![1].totalGold.value = 11200;
  assert.equal(baronGoldDelta(window, next), 2000);
  assert.equal(advanceBaronWindow(window, frame(sample(280))), null);
  assert.equal(advanceBaronWindow(window, frame(sample(110, false))), null);
  assert.deepEqual(advanceBaronWindow(window, frame(sample(110, null))), window);
});
