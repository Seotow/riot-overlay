import test from "node:test";
import assert from "node:assert/strict";
import { normalizeIngame } from "../server/ingame-adapter";
import { ObserverSession } from "../server/observer-session";
import { IndependentEngine } from "../server/independent-engine";
import { startIndependentEngineServer } from "../server/independent-engine-server";
import { IngameCollector } from "../server/observer";
import { IndependentEngineEvidence } from "../server/independent-engine-evidence";
import { request } from "node:http";
import { WebSocket } from "ws";

const timestamp = Date.UTC(2026, 9, 14);
function source() {
  let now = timestamp;
  const session = new ObserverSession();
  let live: unknown = {
    gameData: { gameTime: 100 },
    allPlayers: Array.from({ length: 10 }, (_, slot) => ({
      championId: 1,
      level: 5,
      team: slot < 5 ? "ORDER" : "CHAOS",
      riotId: "PRIVATE_SYNTHETIC",
      items: [],
      scores: { kills: 0, deaths: 0, assists: 0, creepScore: 10 },
    })),
  };
  let playback: unknown = { time: 100, speed: 1, paused: false };
  const engine = new IndependentEngine(
    {
      observe: async () =>
        session.ingest(
          normalizeIngame(live, playback, new Date(now).toISOString()),
          "test",
          new Date(now).toISOString(),
        ),
    },
    () => now,
  );
  return {
    engine,
    change: (l: unknown, r: unknown, time = now + 500) => {
      live = l;
      playback = r;
      now = time;
    },
    advance: (ms: number) => {
      now += ms;
    },
  };
}
test("independent engine reports partial telemetry, nulls and no LB parity", async () => {
  const { engine } = source();
  await engine.tick();
  const snapshot = engine.snapshot();
  assert.equal(snapshot.status, "partial");
  assert.equal(snapshot.replacementReady, false);
  assert.equal(snapshot.capabilities.coverage.level.observed, 10);
  assert.equal(snapshot.capabilities.coverage.health.observed, 0);
  assert.equal(snapshot.frame?.sample?.players[0].totalGold.value, null);
  assert.equal(snapshot.frame?.sample?.players[0].playerName?.value, "PRIVATE_SYNTHETIC");
  assert.equal(JSON.stringify(snapshot).includes("summonerName"), false);
  assert.equal(JSON.stringify(snapshot).includes("leaguebroadcast"), false);
});
test("replay clock alone never becomes full roster or full data", async () => {
  const { engine, change } = source();
  change(null, { time: 100, paused: true, speed: 1 });
  await engine.tick();
  assert.equal(engine.snapshot().status, "clock-only");
  assert.equal(engine.snapshot().capabilities.players, 0);
});
test("coverage requires a complete roster and nine distinct perks; empty cooldowns do not count", async () => {
  const { engine: provider } = source();
  await provider.tick();
  const frame = provider.snapshot().frame!;
  const field = {
    availability: "observed" as const,
    source: "live-client" as const,
    observedAt: new Date(timestamp).toISOString(),
  };
  frame.sample!.players[0].perks = { ...field, value: [1, 2] };
  frame.sample!.players[0].cooldowns = { ...field, value: [] };
  const engine = new IndependentEngine({ observe: async () => frame }, () => timestamp);
  await engine.tick();
  const snapshot = engine.snapshot();
  assert.equal(snapshot.capabilities.roster.complete, true);
  assert.equal(snapshot.capabilities.coverage.perks.observed, 0);
  assert.equal(snapshot.capabilities.coverage.cooldowns.observed, 0);
});
test("divergent live/replay clocks are explicitly unverified for coherence", async () => {
  const { engine, change } = source();
  await engine.tick();
  change({ gameData: { gameTime: 100 } }, { time: 120, speed: 1 });
  await engine.tick();
  assert.equal(engine.snapshot().capabilities.clockAlignment, "divergent");
  change({ gameData: { gameTime: 100 } }, { time: 70, speed: 1 });
  await engine.tick();
  assert.equal(engine.snapshot().capabilities.clockAlignment, "divergent");
  assert.equal(engine.snapshot().replacementReady, false);
});
test("LB and recorded inputs cannot be labeled as independent acquisition", async () => {
  const { engine: provider } = source();
  await provider.tick();
  const frame = provider.snapshot().frame!;
  frame.sample!.players[0].health = {
    value: { current: 100, max: 100 },
    availability: "observed",
    source: "leaguebroadcast",
    observedAt: new Date(timestamp).toISOString(),
  };
  const engine = new IndependentEngine({ observe: async () => frame }, () => timestamp);
  await engine.tick();
  assert.equal(engine.snapshot().status, "unavailable");
  assert.equal(engine.snapshot().frame, null);
});
test("bounded acquisition evidence retains only metadata, never values or player identities", async () => {
  const { engine } = source();
  await engine.tick();
  const evidence = new IndependentEngineEvidence(new Date(timestamp).toISOString());
  for (let i = 0; i < 1502; i++) evidence.record(engine.snapshot());
  const report = evidence.report(new Date(timestamp + 1000).toISOString());
  assert.equal(report.retained, 1500);
  assert.equal(report.dropped, 2);
  const json = JSON.stringify(report);
  assert.equal(json.includes("PRIVATE_SYNTHETIC"), false);
  assert.equal(json.includes('"sample"'), false);
  assert.equal(json.includes('"players"'), false);
  assert.equal(report.rows[0].coverage.level, 10);
});
test("pause stays observed while samples arrive, stale data is cleared after five seconds", async () => {
  const { engine, change, advance } = source();
  change({ gameData: { gameTime: 100 } }, { time: 100, paused: true, speed: 1 });
  await engine.tick();
  advance(4000);
  await engine.tick();
  assert.equal(engine.snapshot().stale, false);
  advance(5001);
  assert.equal(engine.snapshot().stale, true);
  assert.equal(engine.snapshot().frame?.sample, null);
});
test("backward seek increments epoch without replaying history alerts", async () => {
  const { engine, change } = source();
  await engine.tick();
  change(
    {
      gameData: { gameTime: 50 },
      events: {
        Events: [{ EventID: 1, EventTime: 30, EventName: "DragonKill" }],
      },
    },
    { time: 50, speed: 1 },
  );
  await engine.tick();
  assert.equal(engine.snapshot().frame?.epoch, 1);
  assert.deepEqual(engine.snapshot().frame?.newEvents, []);
});
test("collector failure discards prior sample and never logs errors in snapshot", async () => {
  let fail = false;
  const { engine: provider } = source();
  await provider.tick();
  const engine = new IndependentEngine(
    {
      observe: async () => {
        if (fail) throw Error("SYNTHETIC_SECRET");
        return provider.snapshot().frame!;
      },
    },
    () => timestamp,
  );
  await engine.tick();
  fail = true;
  await engine.tick();
  assert.equal(engine.snapshot().frame?.sample, null);
  assert.equal(JSON.stringify(engine.snapshot()).includes("SYNTHETIC_SECRET"), false);
});
test("source requests are exclusively official API endpoints", async () => {
  const paths: string[] = [];
  const collector = new IngameCollector(
    async (id, endpoint) => {
      paths.push(endpoint);
      return {
        probe: {
          id,
          source: "Live Client",
          endpoint,
          status: "unreachable",
          httpStatus: null,
          latencyMs: 0,
          observedAt: new Date(timestamp).toISOString(),
        },
      };
    },
    () => timestamp,
  );
  const engine = new IndependentEngine(collector, () => timestamp);
  await engine.tick();
  assert.deepEqual(paths, ["/liveclientdata/allgamedata", "/replay/playback"]);
  assert.equal(engine.snapshot().status, "unavailable");
});
test("stop suppresses in-flight publication and clears output", async () => {
  let release!: () => void;
  const gate = new Promise<void>((resolve) => {
    release = resolve;
  });
  const { engine: provider } = source();
  await provider.tick();
  const engine = new IndependentEngine({
    observe: async () => {
      await gate;
      return provider.snapshot().frame!;
    },
  });
  let notifications = 0;
  engine.onUpdate(() => notifications++);
  const pending = engine.tick(),
    stopped = engine.stop();
  release();
  await Promise.all([pending, stopped]);
  assert.equal(notifications, 0);
  assert.equal(engine.snapshot().frame, null);
});
function read(port: number, path: string, headers: Record<string, string> = {}, method = "GET") {
  return new Promise<{ status: number; body: any }>((resolve, reject) => {
    const req = request({ hostname: "127.0.0.1", port, path, method, headers }, (res) => {
      let body = "";
      res.on("data", (chunk) => {
        body += chunk;
      });
      res.on("end", () => resolve({ status: res.statusCode!, body: JSON.parse(body) }));
    });
    req.on("error", reject);
    req.end();
  });
}
test("standalone loopback HTTP/WS output is read-only and stops cleanly", async () => {
  const { engine } = source();
  await engine.tick();
  const service = await startIndependentEngineServer({
    port: 0,
    engine,
    poll: false,
  });
  try {
    const health = await read(service.port, "/health");
    assert.equal(health.body.serverReady, true);
    assert.equal(health.body.replacementReady, false);
    assert.equal((await read(service.port, "/snapshot")).body.status, "partial");
    assert.equal(
      (
        await read(service.port, "/snapshot", {
          Origin: "https://untrusted.invalid",
        })
      ).status,
      403,
    );
    assert.equal((await read(service.port, "/health", { Host: "untrusted.invalid" })).status, 403);
    assert.equal((await read(service.port, "/snapshot", {}, "POST")).status, 405);
    const ws = new WebSocket(`ws://127.0.0.1:${service.port}/ws`);
    try {
      const message = await new Promise<any>((resolve, reject) => {
        ws.once("message", (data) => resolve(JSON.parse(String(data))));
        ws.once("error", reject);
      });
      assert.equal(message.type, "independent-engine");
      assert.equal(message.replacementReady, false);
      const close = new Promise<number>((resolve) => ws.once("close", resolve));
      ws.send("mutate");
      assert.equal(await close, 1008);
    } finally {
      ws.terminate();
    }
  } finally {
    await service.close();
  }
});
