import test from "node:test";
import assert from "node:assert/strict";
import { existsSync } from "node:fs";
import { CaptureReplay, listCaptures } from "../server/capture-replay";
import { ingameSampleSchema } from "../shared/observer";

const id = "lb-2026-10-11T09-07-37-947Z";
// Local real recording stays Git-ignored; CI without it explicitly skips this regression.
test(
  "full Practice Tool recording preserves confirmed events, timers and playback",
  {
    skip: !existsSync(`data/captures/${id}/leaguebroadcast-ws.ndjson`),
  },
  async () => {
    let wall = Date.now();
    const replay = new CaptureReplay(() => wall);
    const entries = await replay.prepare(id);
    assert.ok(entries.length > 2200);
    for (const entry of entries) ingameSampleSchema.parse(entry.sample);
    assert.ok(
      entries.some((e) =>
        e.sample.players.every((p) => p.experience?.value != null),
      ),
    );
    assert.ok(
      entries.some((e) =>
        e.sample.players
          .find((p) => p.championId.value === 120)
          ?.spells?.value?.includes("S5_SummonerSmitePlayerGanker"),
      ),
    );
    assert.ok(
      entries.some((e) =>
        e.sample.pitTimers?.some((t) => t.type.value === "DRAGON_ELDER"),
      ),
    );
    assert.ok((await listCaptures()).find((c) => c.id === id)?.hasState);
    const events = [
      ...new Map(
        entries.flatMap((e) => e.sample.events).map((e) => [e.id, e]),
      ).values(),
    ];
    for (const kind of [
      "LevelUp",
      "ItemCompleted",
      "DragonKill",
      "DragonSoul",
      "TurretKilled",
      "BaronKill",
      "InhibKilled",
      "InhibRespawned",
      "RoleQuestCompleted",
    ])
      assert.ok(
        events.some((e) => e.kind === kind),
        kind,
      );
    assert.equal(events.filter((e) => e.kind === "DragonKill").length, 4);
    assert.equal(events.filter((e) => e.kind === "DragonSoul").length, 1);
    for (const itemId of [4646, 3152, 3026, 3157])
      assert.ok(
        events.some((e) => e.kind === "ItemCompleted" && e.itemId === itemId),
      );
    const ga = entries.find((e) =>
      e.sample.players.some((p) =>
        p.cooldowns?.value?.some((c) => c.id === 3026 && c.readyAt > 700),
      ),
    );
    assert.ok(ga);
    assert.equal(
      ga.sample.players
        .find((p) =>
          p.cooldowns?.value?.some((c) => c.id === 3026 && c.readyAt > 700),
        )
        ?.cooldowns?.value?.find((c) => c.id === 3026)?.total,
      300,
    );
    assert.ok(
      entries.some((e) =>
        e.sample.inhibitors?.value?.some(
          (i) =>
            i.team === "CHAOS" &&
            i.lane === "mid" &&
            Math.abs(i.respawnsAt - i.destroyedAt - 300) < 0.01,
        ),
      ),
    );
    replay.loadEntries(id, entries);
    const capabilities = replay.capabilities().buttons;
    assert.equal(
      capabilities.find((b) => b.kind === "damage")?.available,
      false,
    );
    assert.equal(capabilities.find((b) => b.kind === "runes")?.available, true);
    assert.equal(
      capabilities.find((b) => b.kind === "inhibitorRed")?.available,
      true,
    );
    assert.equal(
      capabilities.find((b) => b.kind === "inhibitorBlue")?.available,
      entries.some((e) =>
        e.sample.inhibitors?.value?.some((i) => i.team === "ORDER"),
      ),
    );
    assert.throws(() => replay.rehearse("damage"));
    for (const button of capabilities.filter((b) => b.available)) {
      const display = replay.rehearse(button.kind);
      const frame = replay.observe();
      assert.ok(frame.sample, button.kind);
      assert.equal(frame.sample.replay.paused.value, true);
      if (
        [
          "dragon",
          "soul",
          "level",
          "item",
          "tower",
          "inhibitor",
          "inhibitorRespawn",
        ].includes(button.kind) ||
        button.kind.startsWith("quest")
      ) {
        assert.equal(frame.newEvents.length, 1, button.kind);
        assert.equal(frame.playback?.trigger, "manual-rehearsal");
        assert.equal(replay.observe().newEvents.length, 0);
      }
      if (button.kind === "baron") {
        assert.ok(display.powerPlay);
        assert.ok(display.powerPlay.endsAt! > display.powerPlay.startedAt);
        assert.equal(display.powerPlay.timerSource, "recorded-buff-loss");
      }
    }
    replay.control({ positionMs: ga.offsetMs });
    assert.equal(replay.observe().newEvents.length, 0);
    replay.control({ playing: true, speed: 4 });
    wall += 250;
    assert.ok(replay.observe().sample);
    replay.control({ playing: false });
    const paused = replay.observe().sample?.gameTime.value;
    wall += 2000;
    assert.equal(replay.observe().sample?.gameTime.value, paused);
    replay.control({ positionMs: entries.at(-1)!.offsetMs });
    assert.equal(replay.observe().newEvents.length, 0);
    assert.ok(replay.observe().sample!.gameTime.value! < 1333);
  },
);
