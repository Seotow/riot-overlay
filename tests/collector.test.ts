import test from "node:test";
import assert from "node:assert/strict";
import { IngameCollector } from "../server/observer";
import type { Result } from "../server/diagnostics";
function result(
  id: string,
  data: unknown,
  status: Result["probe"]["status"] = "ok",
): Result {
  return {
    data,
    probe: {
      id,
      source: id === "live" ? "Live Client" : "Replay API",
      endpoint: "/fixture",
      status,
      httpStatus: status === "ok" ? 200 : null,
      latencyMs: 0,
      observedAt: "2026-09-19T00:00:00.000Z",
    },
  };
}
test("collector coalesces simultaneous requests and expires its cache", async () => {
  let calls = 0,
    time = Date.UTC(2026, 8, 19);
  const paths: string[] = [];
  const collector = new IngameCollector(
    async (id, path) => {
      calls++;
      paths.push(path);
      return result(
        id,
        id === "live"
          ? { gameData: { gameTime: 100 } }
          : { time: 100, paused: false, speed: 1 },
      );
    },
    () => time,
  );
  const [a, b] = await Promise.all([collector.observe(), collector.observe()]);
  assert.deepEqual(a, b);
  assert.equal(calls, 2);
  assert.deepEqual(paths, ["/liveclientdata/allgamedata", "/replay/playback"]);
  await collector.observe();
  assert.equal(calls, 2);
  time += 750;
  const c = await collector.observe();
  assert.equal(calls, 4);
  assert.equal(c.sequence, a.sequence + 1);
});
test("collector tolerates one failed source and rotates on recovery", async () => {
  let failed = true,
    time = Date.UTC(2026, 8, 19);
  const collector = new IngameCollector(
    async (id) => {
      if (id === "live" && failed) throw Error("SECRET");
      return result(
        id,
        id === "live"
          ? { gameData: { gameTime: 100 } }
          : { time: 100, paused: true },
      );
    },
    () => time,
  );
  const first = await collector.observe();
  assert.equal(first.status, "observed");
  assert.equal(first.sample?.gameTime.value, null);
  assert.equal(first.sample?.players.length, 0);
  failed = false;
  time += 1000;
  const second = await collector.observe();
  assert.notEqual(second.sessionId, first.sessionId);
  assert.ok(!JSON.stringify(collector.recording()).includes("SECRET"));
});
test("empty payloads and failed HTTP responses clear observed state", async () => {
  let mode = 0,
    time = Date.UTC(2026, 8, 19);
  const collector = new IngameCollector(
    async (id) =>
      result(
        id,
        mode === 0 ? { gameData: { gameTime: 100 } } : { allPlayers: [{}] },
        mode === 2 ? "http-error" : "ok",
      ),
    () => time,
  );
  assert.equal((await collector.observe()).status, "observed");
  mode = 1;
  time += 1000;
  const empty = await collector.observe();
  assert.equal(empty.status, "unavailable");
  assert.equal(empty.sample, null);
  mode = 2;
  time += 1000;
  assert.equal((await collector.observe()).sample, null);
});
