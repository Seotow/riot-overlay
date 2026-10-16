import test from "node:test";
import assert from "node:assert/strict";
import { once } from "node:events";
import { WebSocketServer } from "ws";
import {
  normalizeCollector,
  LeagueCollectorSource,
} from "../Collector/adapter";
import { observerFrameSchema } from "../shared/observer";
import { CollectorGameplay } from "../Collector/adapter/gameplay";

const base = Date.parse("2026-10-14T15:00:00Z");
test("native champion stack contract exposes real Smolder/Veigar counters and clears on missing buff",()=>{
 const raw=fixture();const h=raw.data.heroes[0];
 h.common.identifier="Smolder";h.common.buffs=[{name:"SmolderQPassive",count:32}];
 assert.equal(normalizeCollector(raw,base)!.sample.players[0].championStacks?.value,32);
 h.common.identifier="Veigar";h.common.buffs=[{name:"VeigarPhenomenalEvilPower",count:77}];
 assert.equal(normalizeCollector(raw,base)!.sample.players[0].championStacks?.value,77);
 h.common.buffs=[];
 assert.equal(normalizeCollector(raw,base)!.sample.players[0].championStacks?.availability,"missing");
});
test("native values are not gated by external comparisons: CS, death bit, buffs, quest and raw stats", () => {
  const raw = fixture(),
    h = raw.data.heroes[0];
  h.laneMinionKills = 0;
  h.neutralMinionKills = 0;
  h.respawnTime = 0;
  h.common.status = 13;
  h.common.buffs = [
    { name: "ExaltedWithMiniBaronNashor", endTime: 500 },
    { name: "BlessingoftheLizardElder", endTime: 500 },
  ];
  h.items.push({ slot: 8, id: 1220, count: 1 });
  h.experience = 123;
  h.resourceType = 1;
  h.common.armor = -5;
  let p = normalizeCollector(raw, base)!.sample.players[0];
  assert.equal(p.cs.value, 0);
  assert.equal(p.isDead?.value, false);
  assert.equal(p.respawnSeconds?.value, 0);
  assert.equal(p.hasBaron?.value, false);
  assert.equal(p.hasElder?.value, false);
  assert.equal(p.roleQuest?.value?.completed, true);
  assert.equal(p.sourceStats?.value?.experience, 123);
  assert.equal(p.sourceStats?.value?.resourceType, 1);
  assert.equal(p.sourceStats?.value?.armor, -5);
  h.common.status = 8;
  h.resourceType = 0;
  h.respawnTime = 20;
  h.common.buffs = [
    { name: "exaltedwithbaronnashor", endTime: 280 },
    { name: "ElderDragonBuff", endTime: 250 },
  ];
  p = normalizeCollector(raw, base)!.sample.players[0];
  assert.equal(p.sourceStats?.value?.resourceType, 0);
  assert.equal(p.isDead?.value, true);
  assert.equal(p.hasBaron?.value, true);
  assert.equal(p.hasElder?.value, true);
});
test("cached objective identities survive disappearance, deduplicate and reset on backwards seek", () => {
  const project = new CollectorGameplay();
  const raw = fixture();
  raw.data.minions = [
    {
      info: { networkId: 9000, team: 0 },
      common: { identifier: "SRU_Dragon_Earth" },
    },
  ];
  const apply = () =>
    project.enrich(raw, normalizeCollector(raw, base)!).sample;
  apply();
  raw.data.minions = [];
  raw.data.gameTime = 101;
  raw.data.gameEvents = {
    deathEvents: [
      { gameTime: 101, killerNetworkId: 1000, victimNetworkId: 9000 },
    ],
  };
  let s = apply();
  assert.deepEqual(s.teams?.[0].dragons.value, ["earth"]);
  assert.equal(s.events.filter((e) => e.kind === "DragonKill").length, 1);
  s = apply();
  assert.deepEqual(s.teams?.[0].dragons.value, ["earth"]);
  raw.data.gameTime = 102;
  raw.data.minions = [
    {
      info: { networkId: 9001, team: 0 },
      common: { identifier: "SRU_RiftHerald_Relic" },
    },
  ];
  raw.data.gameEvents.deathEvents = [
    { gameTime: 102, killerNetworkId: 1000, victimNetworkId: 9001 },
  ];
  assert.equal(apply().events.filter((e) => e.kind === "HeraldKill").length, 0);
  raw.data.gameTime = 50;
  raw.data.gameEvents = {};
  s = apply();
  assert.deepEqual(s.teams?.[0].dragons.value, []);
});
test("source hero death with unknown killer is retained without inventing an actor", () => {
  const raw = fixture();
  raw.data.gameEvents = {
    heroDieEvents: [
      { gameTime: 100, killerNetworkId: 9999, victimNetworkId: 1000 },
    ],
  };
  const s = new CollectorGameplay().enrich(
    raw,
    normalizeCollector(raw, base)!,
  ).sample;
  assert.equal(s.events.length, 1);
  assert.equal(s.events[0].victimSlot, 0);
  assert.equal(s.events[0].killerSlot, undefined);
  assert.equal(s.events[0].team, undefined);
  raw.data.minions = [
    {
      info: { networkId: 9999, team: 0 },
      common: { identifier: "SRU_Dragon_Chemtech" },
    },
  ];
  const known = new CollectorGameplay().enrich(
    raw,
    normalizeCollector(raw, base)!,
  ).sample.events[0];
  assert.equal(known.killerObjectiveType, "chemtech");
  assert.equal(known.killerSlot, undefined);
  assert.equal(known.team, undefined);
});
// Invented fixture derived from serializer schema, never captured gameplay.
test("non-player killers resolve by exact network identity: minion, jungle monster, grub, Baron and turret", () => {
  for (const [code, team, unitType, objective] of [
    ["SRU_OrderMinionMelee", 1, "minion", undefined],
    ["SRU_Blue", 0, "monster", undefined],
    ["SRU_Horde", 0, "grubs", undefined],
    ["SRU_Baron", 0, "monster", "baron"],
    ["", 2, "turret", undefined],
  ] as const) {
    const raw = fixture();
    const unit = {
      info: { networkId: 9999, team },
      common: { identifier: code },
    };
    if (unitType === "turret") raw.data.turrets = [unit];
    else raw.data.minions = [unit];
    raw.data.gameEvents = {
      heroDieEvents: [
        { gameTime: 100, killerNetworkId: 9999, victimNetworkId: 1000 },
      ],
    };
    const e = new CollectorGameplay().enrich(
      raw,
      normalizeCollector(raw, base)!,
    ).sample.events[0];
    assert.equal(e.killerUnitType, unitType);
    assert.equal(e.killerObjectiveType, objective);
    assert.equal(e.killerSlot, undefined);
    assert.equal(e.victimSlot, 0);
    assert.equal(
      e.team,
      team === 1 ? "ORDER" : team === 2 ? "CHAOS" : undefined,
    );
  }
});
function fixture(sequence = 1, time = 100, now = base): any {
  return {
    schemaVersion: 1,
    sequence,
    timestamp: new Date(now).toISOString(),
    type: "snapshot",
    source: "lblib",
    synthetic: false,
    recordedAt: null,
    token: "SECRET_SENTINEL",
    data: {
      gameTime: time,
      gameId: "PRIVATE_GAME_SENTINEL",
      playbackSpeed: 1,
      heroes: Array.from({ length: 10 }, (_, i) => ({
        heroIndex: i,
        info: {
          team: i < 5 ? 1 : 2,
            name: "TestPlayer#VN2",
          networkId: 1000 + i,
        },
        common: {
          identifier: i % 2 ? "Garen" : "Ahri",
          level: 10,
          health: 0,
          maxHealth: 1000,
        },
        gold: 0,
        totalGold: 5000,
        resource: 50,
        maxResource: 100,
        kills: 0,
        deaths: 1,
        assists: 2,
        laneMinionKills: 20,
        neutralMinionKills: 3,
        visionScore: 4,
        items: [
          { slot: 0, id: 0, count: 0 },
          { slot: 6, id: 3340, count: 1 },
        ],
        spells: [
          { index: 3, name: "TestUlt", readyAt: 130, maxCooldown: 60 },
          { index: 4, name: "SummonerFlash", readyAt: 200, maxCooldown: 300 },
          { index: 5, name: "SummonerHeal", readyAt: 0, maxCooldown: 240 },
        ],
      })),
    },
  };
}
test("native projection allows broadcast nickname but not account IDs/secrets", () => {
  const result = normalizeCollector(fixture(), base)!;
  assert.ok(result);
  const p = result.sample.players[0];
  assert.equal(p.championId.value, 103);
  assert.equal(p.team.value, "ORDER");
  assert.equal(p.playerName?.value, "TestPlayer");
  assert.equal(p.currentGold?.value, 0);
  assert.equal(p.health?.value?.current, 0);
  assert.equal(p.isDead?.value, null);
  assert.equal(p.cs.value, 23);
  assert.equal(p.totalGold.source, "league-collector");
  assert.deepEqual(p.inventory?.value, [
    { slot: 0, id: 0, count: 0 },
    { slot: 6, id: 3340, count: 1 },
  ]);
  assert.deepEqual(p.spells?.value, ["SummonerFlash", "SummonerHeal"]);
  assert.equal(p.cooldowns?.value?.find((c) => c.slot === "F")?.readyAt, 0);
  const text = JSON.stringify(result);
  assert.ok(!text.includes("SENTINEL"));
  assert.ok(!text.includes("networkId"));
  assert.equal(result.sample.replay.paused.value, null);
  assert.equal(result.sample.mapNumber?.value, null);
  assert.equal(result.sample.teams?.[0].totalGold.value, 25000);
  assert.equal(result.sample.teams?.[0].kills.value, 0);
  assert.equal(result.sample.teams?.[0].towers.value, null);
  assert.deepEqual(result.sample.events, []);
});
test("malformed/unsupported fields remain missing; zero is not a substitute", () => {
  const raw = fixture();
  const h = raw.data.heroes[0];
  h.common.identifier = "UnknownChampion";
  h.common.maxHealth = 0;
  h.maxResource = 0;
  delete h.neutralMinionKills;
  h.items.push({ slot: 9, id: 1200 });
  h.spells.push({ index: 3, readyAt: 50, maxCooldown: 20 });
  h.kills = -1;
  const p = normalizeCollector(raw, base)!.sample.players[0];
  for (const value of [
    p.championId,
    p.health,
    p.resource,
    p.cs,
    p.items,
    p.cooldowns,
    p.kills,
  ]) {
    assert.equal(value?.value, null);
    assert.equal(value?.availability, "missing");
  }
  assert.equal(p.perks?.value, null);
  assert.equal(
    normalizeCollector(raw, base)!.sample.teams?.[0].kills.value,
    null,
  );
});

test("SR auxiliary native slots 7/8 do not suppress standard inventory or masquerade as items", () => {
  const raw = fixture();
  raw.data.heroes[0].items.push(
    { slot: 7, id: 12345, count: 1 },
    { slot: 8, id: 34567, count: 1 },
  );
  const p = normalizeCollector(raw, base)!.sample.players[0];
  assert.deepEqual(p.items.value, [0, 3340]);
  assert.equal(p.inventory?.value?.length, 2);
  assert.equal(p.cs.availability, "observed");
});
test("native perks validate metadata and order without leaking raw perk statistics", () => {
  const raw = fixture();
  const h = raw.data.heroes[0];
  const ids = [8005, 8009, 9104, 8014, 8226, 8237, 5008, 5008, 5001];
  h.perks = ids.map((id) => ({
    id,
    value: "PRIVATE_PERK_SENTINEL",
    statModValue: 123,
  }));
  const result = normalizeCollector(raw, base)!;
  assert.deepEqual(result.sample.players[0].perks?.value, ids);
  assert.equal(result.sample.players[0].keystone?.value, 8005);
  assert.ok(!JSON.stringify(result).includes("SENTINEL"));
  // A known key can be reported alone; never infer the missing panel.
  h.perks = [{ id: 8005 }];
  let p = normalizeCollector(raw, base)!.sample.players[0];
  assert.equal(p.keystone?.value, 8005);
  assert.equal(p.perks?.value, null);
  // Same IDs in arbitrary order cannot masquerade as 4+2+3 slots.
  h.perks = ids
    .slice()
    .reverse()
    .map((id) => ({ id }));
  p = normalizeCollector(raw, base)!.sample.players[0];
  assert.equal(p.keystone?.value, 8005);
  assert.equal(p.perks?.value, null);
  for (const perks of [
    [],
    [{ id: 8005 }, { id: 8112 }],
    [{ id: 999999 }],
    [{ id: "8005" }],
    [{ id: 8000 }],
    [{ id: 8005 }, { id: 8005 }],
    Array.from({ length: 33 }, () => ({ id: 8005 })),
  ]) {
    h.perks = perks;
    p = normalizeCollector(raw, base)!.sample.players[0];
    assert.equal(p.keystone?.value, null);
    assert.equal(p.perks?.value, null);
  }
});

test("native item cooldown joins inventory slot to spell index and respects empty ammo recharge", () => {
  const raw = fixture();
  const h = raw.data.heroes[0];
  h.items = [
    { slot: 0, id: 3157, count: 1 },
    { slot: 6, id: 3340, count: 1 },
    { slot: 7, id: 3157, count: 1 },
    { slot: 8, id: 3157, count: 1 },
  ];
  h.spells.push(
    { index: 6, readyAt: 160, maxCooldown: 120 },
    {
      index: 12,
      readyAt: 0,
      maxCooldown: 90,
      ammoReadyAt: 180,
      ammoCooldown: 180,
      ammoCount: 0,
    },
    { index: 13, readyAt: 190, maxCooldown: 200 },
    { index: 14, readyAt: 190, maxCooldown: 200 },
  );
  let p = normalizeCollector(raw, base)!.sample.players[0];
  assert.deepEqual(
    p.cooldowns?.value?.filter((c) => c.kind === "item"),
    [
      { kind: "item", slot: "0", id: 3157, readyAt: 160, total: 120 },
      { kind: "item", slot: "6", id: 3340, readyAt: 180, total: 180 },
    ],
  );
  h.spells.find((s: any) => s.index === 12).ammoCount = 1;
  p = normalizeCollector(raw, base)!.sample.players[0];
  assert.equal(p.cooldowns?.value?.find((c) => c.slot === "6")?.readyAt, 0);
  assert.equal(p.cooldowns?.value?.find((c) => c.slot === "6")?.total, 90);
  // Missing timer, empty inventory slot or duplicate spell index is not ready=0.
  delete h.spells.find((s: any) => s.index === 6).readyAt;
  h.items[1].id = 0;
  p = normalizeCollector(raw, base)!.sample.players[0];
  assert.equal(p.cooldowns?.value?.filter((c) => c.kind === "item").length, 0);
  h.spells.push({ index: 6, readyAt: 0, maxCooldown: 120 });
  assert.equal(
    normalizeCollector(raw, base)!.sample.players[0].cooldowns?.value,
    null,
  );
});

test("rejects synthetic/replayed/wrong-source, stale/future envelopes and incomplete/ambiguous rosters", () => {
  for (const change of [
    (f: any) => (f.synthetic = true),
    (f: any) => (f.source = "live"),
    (f: any) => (f.recordedAt = f.timestamp),
    (f: any) => (f.timestamp = new Date(base - 5000).toISOString()),
    (f: any) => (f.timestamp = new Date(base + 1001).toISOString()),
    (f: any) => (f.sequence = NaN),
    (f: any) => f.data.heroes.pop(),
    (f: any) => (f.data.heroes[1].heroIndex = 0),
    (f: any) => (f.data.heroes[0].info.team = 100),
    (f: any) => (f.data.heroes[0].info.team = 2),
  ]) {
    const f = fixture();
    change(f);
    assert.equal(normalizeCollector(f, base), null);
  }
});

function nativeEventsFixture(sequence = 1, time = 100, now = base): any {
  const raw = fixture(sequence, time, now);
  raw.data.turrets = [
    { info: { networkId: 2000, team: 2, name: "PRIVATE_TURRET_SENTINEL" } },
  ];
  raw.data.barracksDampeners = [{ info: { networkId: 3000, team: 2 } }];
  raw.data.gameEvents = {
    heroDieEvents: [
      { gameTime: 99, killerNetworkId: 1000, victimNetworkId: 1005 },
    ],
    turretKillEvents: [
      { gameTime: 99.2, killerNetworkId: 1000, victimNetworkId: 2000 },
    ],
    inhibitorKillEvents: [
      { gameTime: 99.3, killerNetworkId: 1000, inhibitorNetworkId: 3000 },
    ],
    aceEvents: [
      { gameTime: 99.4, killerNetworkId: 1000, victimNetworkId: 1005 },
    ],
    // Generic deaths are not ChampionKill records and must not double count.
    deathEvents: [
      { gameTime: 99, killerNetworkId: 1000, victimNetworkId: 1005 },
    ],
    notificationEvents: [{ type: "GameEnd", token: "PRIVATE_SENTINEL" }],
  };
  return raw;
}

test("typed native events resolve exact object teams/slots, sanitize identity and keep stable IDs", () => {
  const raw = nativeEventsFixture();
  const result = normalizeCollector(raw, base)!;
  const events = result.sample.events;
  assert.deepEqual(
    events.map((e) => e.kind),
    ["ChampionKill", "TurretKilled", "InhibKilled", "Ace"],
  );
  assert.ok(
    events.every(
      (e) =>
        e.team === "ORDER" && e.playerSlot === 0 && Number.isSafeInteger(e.id),
    ),
  );
  assert.equal(events[1].firstTurret, undefined);
  assert.deepEqual(result.sample.eventCoverage, {
    historyFromStart: false,
    towerEventsComplete: false,
    dragonEventsComplete: false,
  });
  assert.equal(result.sample.teams?.[0].towers.value, null);
  const json = JSON.stringify(events);
  assert.ok(!json.includes("networkId"));
  assert.ok(!json.includes("SENTINEL"));
  raw.data.heroes.reverse();
  raw.data.gameEvents.heroDieEvents.push({
    ...raw.data.gameEvents.heroDieEvents[0],
  });
  assert.deepEqual(normalizeCollector(raw, base)!.sample.events, events);
});

test("ambiguous, unknown, friendly, future and historical native events cannot create alerts", () => {
  for (const change of [
    (r: any) => delete r.data.heroes[0].info.networkId,
    (r: any) => (r.data.heroes[1].info.networkId = 1000),
    (r: any) => (r.data.gameEvents.heroDieEvents[0].victimNetworkId = 1001),
    (r: any) => (r.data.gameEvents.heroDieEvents[0].victimNetworkId = 999999),
    (r: any) => (r.data.gameEvents.heroDieEvents[0].killerNetworkId = 0),
    (r: any) => (r.data.gameEvents.heroDieEvents[0].gameTime = 101),
    (r: any) => (r.data.gameEvents.heroDieEvents[0].gameTime = 94.9),
    (r: any) => (r.data.gameEvents.heroDieEvents[0].gameTime = "99"),
    (r: any) => r.data.turrets.push({ info: { networkId: 1005, team: 2 } }),
  ]) {
    const raw = nativeEventsFixture();
    change(raw);
    assert.ok(
      !normalizeCollector(raw, base)!.sample.events.some(
        (e) => e.kind === "ChampionKill",
      ),
    );
  }
  const unknown = nativeEventsFixture();
  delete unknown.data.turrets;
  delete unknown.data.barracksDampeners;
  assert.deepEqual(
    normalizeCollector(unknown, base)!.sample.events.map((e) => e.kind),
    ["ChampionKill", "Ace"],
  );
  const over = nativeEventsFixture();
  over.data.gameEvents.heroDieEvents = Array.from(
    { length: 4097 },
    () => over.data.gameEvents.heroDieEvents[0],
  );
  const sample = normalizeCollector(over, base)!.sample;
  assert.equal(sample.limits.eventsTruncated, true);
  assert.ok(!sample.events.some((e) => e.kind === "ChampionKill"));
});

test("native event baseline, repeats, seek, reconnect and lost source do not replay alerts", () => {
  let clock = base;
  const source = new LeagueCollectorSource({ clock: () => clock });
  source.accept(nativeEventsFixture());
  assert.deepEqual(source.observe().newEvents, []);
  source.accept(nativeEventsFixture(2, 100.1, (clock += 100)));
  assert.deepEqual(source.observe().newEvents, []);
  const next = nativeEventsFixture(3, 100.2, (clock += 100));
  next.data.gameEvents.heroDieEvents.push({
    gameTime: 100.2,
    killerNetworkId: 1001,
    victimNetworkId: 1006,
  });
  source.accept(next);
  assert.equal(source.observe().newEvents.length, 1);
  assert.equal(source.observe().newEvents[0].playerSlot, 1);
  assert.equal(source.snapshot().capabilities.events, true);
  const seek = nativeEventsFixture(4, 99.5, (clock += 100));
  source.accept(seek);
  assert.equal(source.observe().transition, "seek");
  assert.deepEqual(source.observe().newEvents, []);
  source.disconnected();
  assert.equal(source.snapshot().capabilities.events, false);
  source.accept(nativeEventsFixture(1, 100, (clock += 100)));
  assert.equal(source.observe().transition, "reconnected");
  assert.deepEqual(source.observe().newEvents, []);
  clock += 5000;
  assert.equal(source.observe().sample, null);
  assert.equal(source.snapshot().capabilities.events, false);
  source.stop();
});

test("collector broadcast retains inter-poll events once and diagnostics never drain them", () => {
  let clock = base;
  const source = new LeagueCollectorSource({ clock: () => clock });
  source.accept(nativeEventsFixture());
  assert.deepEqual(source.broadcastFrame().newEvents, []);
  const event = nativeEventsFixture(2, 100.1, (clock += 100));
  event.data.gameEvents.heroDieEvents.push({
    gameTime: 100.1,
    killerNetworkId: 1001,
    victimNetworkId: 1006,
  });
  source.accept(event);
  const after = fixture(3, 100.2, (clock += 100));
  source.accept(after);
  assert.deepEqual(source.observe().newEvents, []); // native event frame already passed
  source.snapshot();
  const delivered = source.broadcastFrame();
  assert.equal(delivered.newEvents.length, 1);
  assert.equal(delivered.newEvents[0].playerSlot, 1);
  assert.deepEqual(source.broadcastFrame().newEvents, []);
  const next = nativeEventsFixture(4, 100.3, (clock += 100));
  next.data.gameEvents.heroDieEvents = [
    { gameTime: 100.3, killerNetworkId: 1002, victimNetworkId: 1007 },
  ];
  source.accept(next);
  // A paused game clock must not keep an undelivered queue alive indefinitely.
  for (let sequence = 5; sequence < 10; sequence++)
    source.accept(fixture(sequence, 100.3, (clock += 1000)));
  assert.deepEqual(source.broadcastFrame().newEvents, []);
  const pending = nativeEventsFixture(10, 100.4, (clock += 100));
  pending.data.gameEvents.heroDieEvents = [
    { gameTime: 100.4, killerNetworkId: 1002, victimNetworkId: 1007 },
  ];
  source.accept(pending);
  source.accept(fixture(11, 90, (clock += 100)));
  assert.deepEqual(source.broadcastFrame().newEvents, []); // seek clears queue
  source.accept(nativeEventsFixture(12, 99.5, (clock += 100)));
  source.disconnected();
  assert.deepEqual(source.broadcastFrame().newEvents, []);
  source.accept(nativeEventsFixture(1, 100, (clock += 100)));
  assert.deepEqual(source.broadcastFrame().newEvents, []);
  const beforeId = source.observe().sessionId;
  const replaced = fixture(2, 100.1, (clock += 100));
  replaced.data.heroes.forEach((h: any) => (h.info.networkId += 10000));
  source.accept(replaced);
  assert.equal(source.observe().transition, "source-changed");
  assert.notEqual(source.observe().sessionId, beforeId);
  assert.deepEqual(source.broadcastFrame().newEvents, []);
  source.stop();
});
test("roster reorder is stable; seek changes epoch; disconnect and game replacement change session", () => {
  let clock = base;
  const source = new LeagueCollectorSource({ clock: () => clock });
  assert.ok(source.accept(fixture()));
  const first = source.observe();
  const reordered = fixture(2, 101, (clock += 1000));
  reordered.data.heroes.reverse();
  source.accept(reordered);
  assert.equal(source.observe().sessionId, first.sessionId);
  assert.equal(source.observe().transition, "none");
  assert.equal(source.observe().sample?.players[0].championId.value, 103);
  source.accept(fixture(3, 50, (clock += 1000)));
  assert.equal(source.observe().transition, "seek");
  assert.equal(source.observe().epoch, 1);
  source.disconnected();
  assert.equal(source.observe().sample, null);
  assert.equal(source.observe().transition, "lost");
  source.accept(fixture(1, 51, (clock += 100)));
  assert.equal(source.observe().transition, "reconnected");
  assert.notEqual(source.observe().sessionId, first.sessionId);
  const another = fixture(2, 52, (clock += 100));
  another.data.gameId = "different-game";
  source.accept(another);
  assert.equal(source.observe().transition, "source-changed");
  source.stop();
});
test("duplicates/status/LCU/invalid payload cannot keep stale data live", () => {
  let clock = base;
  const source = new LeagueCollectorSource({ clock: () => clock });
  source.accept(fixture());
  clock += 4000;
  assert.equal(source.accept(fixture()), false);
  assert.equal(source.snapshot().acceptedFrames, 1);
  clock += 1000;
  assert.equal(source.snapshot().status, "stale");
  assert.equal(source.observe().sample, null);
  assert.equal(source.snapshot().players, 0);
  assert.deepEqual(source.snapshot().coverage, {});
  source.accept(fixture(2, 105, clock));
  source.accept({
    schemaVersion: 1,
    type: "status",
    source: "lblib",
    synthetic: false,
    data: { state: "ended" },
  });
  assert.equal(source.observe().sample, null);
  source.accept({ type: "lcu", data: { token: "SECRET" } });
  assert.equal(source.snapshot().players, 0);
  source.accept(fixture(3, 106, (clock += 100)));
  source.accept({});
  assert.equal(source.observe().sample, null);
  source.stop();
  assert.equal(source.snapshot().status, "stopped");
});
test("WebSocket consumer receives native envelopes and clears output on socket close (isolated loopback)", async () => {
  const server = new WebSocketServer({ host: "127.0.0.1", port: 0 });
  await once(server, "listening");
  const address = server.address();
  assert.ok(typeof address === "object" && address);
  const source = new LeagueCollectorSource({
    port: address.port,
    clock: () => base,
  });
  let connectionDeadline: ReturnType<typeof setTimeout> | undefined;
  try {
    const connected = once(server, "connection");
    source.ensureConnected();
    const [socket] = await Promise.race([
      connected,
      new Promise<never>((_, reject) => {
        connectionDeadline = setTimeout(
          () => reject(Error("Loopback collector connection timeout")),
          3000,
        );
      }),
    ]);
    clearTimeout(connectionDeadline);
    socket.send(JSON.stringify(fixture()));
    for (let i = 0; i < 100 && source.snapshot().players !== 10; i++)
      await new Promise((r) => setTimeout(r, 10));
    assert.equal(source.snapshot().players, 10);
    observerFrameSchema.parse(source.observe());
    socket.close();
    for (let i = 0; i < 100 && source.snapshot().status !== "offline"; i++)
      await new Promise((r) => setTimeout(r, 10));
    assert.equal(source.observe().sample, null);
    assert.equal(source.snapshot().status, "offline");
  } finally {
    clearTimeout(connectionDeadline);
    source.stop();
    await new Promise<void>((resolve) => server.close(() => resolve()));
  }
});
