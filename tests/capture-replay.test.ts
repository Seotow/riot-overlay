import test from "node:test";
import assert from "node:assert/strict";
import {
  CaptureReplay,
  parseCapture,
  captureIdSchema,
} from "../server/capture-replay";
import { observerFrameSchema } from "../shared/observer";
const start = Date.parse("2026-09-20T00:00:00Z");
test("reloading the same capture produces a new load acknowledgement; seeking does not", () => {
  const replay = new CaptureReplay(() => start),
    entries = parseCapture([line(0, 100), line(1000, 101)].join("\n"));
  assert.equal(replay.snapshot().loadGeneration, 0);
  replay.loadEntries("same", entries);
  assert.equal(replay.snapshot().loadGeneration, 1);
  replay.control({ positionMs: 500 });
  assert.equal(replay.snapshot().loadGeneration, 1);
  replay.loadEntries("same", entries);
  assert.equal(replay.snapshot().loadGeneration, 2);
  assert.equal(replay.snapshot().positionMs, 0);
});
function line(offset: number, time: number, kills = 1) {
  return JSON.stringify({
    receivedAt: new Date(start + offset).toISOString(),
    message: {
      type: "ingame-state-update",
      state: {
        gameTime: time,
        gameStatus: 2,
        isTestingEnvironment: false,
        playbackSpeed: 1,
        scoreboardBottom: {
          teams: [0, 1].map(() => ({
            players: Array.from({ length: 5 }, () => ({
              champion: { id: 1 },
              kills,
              level: 10,
              items: [],
              totalGold: 5000,
            })),
          })),
        },
      },
    },
  });
}
test("capture playback advances only its clock between snapshots, pauses, seeks and freezes at end", () => {
  let wall = start + 100000;
  const replay = new CaptureReplay(() => wall);
  replay.loadEntries(
    "fixture",
    parseCapture(
      [line(0, 100), line(1000, 101, 2), line(2000, 102, 3)].join("\n"),
    ),
  );
  const first = replay.observe();
  assert.equal(replay.snapshot().firstGameTime, 100);
  assert.equal(replay.snapshot().lastGameTime, 102);
  assert.equal(replay.snapshot().gameTime, 100);
  observerFrameSchema.parse(first);
  assert.equal(first.sample?.replay.paused.value, true);
  assert.equal(first.playback?.recordedAt, new Date(start).toISOString());
  wall += 1000;
  assert.equal(replay.observe().sample?.gameTime.value, 100);
  replay.control({ playing: true, speed: 2 });
  wall += 250;
  const middle = replay.observe();
  assert.equal(middle.sample?.gameTime.value, 100.5);
  assert.equal(replay.snapshot().gameTime, 100.5);
  assert.equal(middle.sample?.players[0].kills.value, 1);
  wall += 250;
  assert.equal(replay.observe().sample?.players[0].kills.value, 2);
  replay.control({ playing: false });
  wall += 5000;
  assert.equal(replay.observe().sample?.gameTime.value, 101);
  replay.control({ positionMs: 0 });
  assert.notEqual(replay.observe().sessionId, first.sessionId);
  replay.control({ playing: true });
  wall += 10000;
  const end = replay.observe();
  assert.equal(end.sample?.gameTime.value, 102);
  assert.equal(end.sample?.replay.paused.value, true);
  assert.equal(replay.snapshot().playing, false);
  assert.equal(replay.recording().frames.at(-1)?.playback?.kind, "recording");
});
test("capture gaps expire data instead of interpolating stats or inventing future game state", () => {
  let wall = start;
  const replay = new CaptureReplay(() => wall);
  replay.loadEntries(
    "gap",
    parseCapture([line(0, 100), line(10000, 110)].join("\n")),
  );
  replay.control({ playing: true });
  wall += 6000;
  assert.equal(replay.observe().sample, null);
  assert.equal(replay.snapshot().gameTime, null);
  wall += 4000;
  assert.equal(replay.observe().sample?.gameTime.value, 110);
});
test("capture parser rejects empty state, reversed timestamps, demo and path traversal", () => {
  assert.throws(() => parseCapture(""));
  assert.throws(() => parseCapture([line(1000, 100), line(0, 101)].join("\n")));
  assert.throws(() =>
    parseCapture(
      line(0, 100).replace(
        '"isTestingEnvironment":false',
        '"isTestingEnvironment":true',
      ),
    ),
  );
  for (const id of [
    "../outside",
    "C:\\secret",
    "2026-09-19T18-57-45-942Z/../x",
  ])
    assert.equal(captureIdSchema.safeParse(id).success, false);
});
