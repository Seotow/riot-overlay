import test from "node:test";
import assert from "node:assert/strict";
import {
  LeagueBroadcastSource,
  normalizeLeagueBroadcast,
} from "../server/leaguebroadcast";

const now = "2026-09-19T12:00:00.000Z";
test("LB stacksData is direct for all supported champions, missing is not zero",()=>{
 for(const id of [432,75,136,901,45,235,31,14,412,200,203]){
  const raw:any=frame();raw.scoreboardBottom.teams[0].players[0].champion.id=id;
  raw.tabs.Order.players[0].stacksData=152;
  assert.equal(normalizeLeagueBroadcast(raw,now)!.players[0].championStacks?.value,152);
  raw.tabs.Order.players[0].stacksData=0;
  assert.equal(normalizeLeagueBroadcast(raw,now)!.players[0].championStacks?.value,0);
  delete raw.tabs.Order.players[0].stacksData;
  assert.equal(normalizeLeagueBroadcast(raw,now)!.players[0].championStacks?.value,null);
 }
});
test("first turret is global 0→1, never the other team's first or a multi-turret jump", () => {
  for (const jump of [1, 2]) {
    let clock = Date.parse(now);
    const source = new LeagueBroadcastSource(() => clock);
    const raw: any = frame();
    raw.scoreboard.teams.forEach((t: any) => (t.towers = 0));
    source.accept({ type: "ingame-state-update", state: raw });
    source.observe();
    raw.gameTime += 0.5;
    clock += 500;
    raw.scoreboard.teams[0].towers = jump;
    source.accept({ type: "ingame-state-update", state: raw });
    assert.equal(
      source.observe().newEvents.find((e) => e.kind === "TurretKilled")
        ?.firstTurret,
      jump === 1,
    );
    raw.gameTime += 0.5;
    clock += 500;
    raw.scoreboard.teams[1].towers = 1;
    source.accept({ type: "ingame-state-update", state: raw });
    assert.equal(
      source.observe().newEvents.find((e) => e.kind === "TurretKilled")
        ?.firstTurret,
      false,
    );
    source.stop();
  }
});
test("quest rewards preserve bot boots slot, mid inventory and support ward slot", () => {
  const raw: any = frame();
  raw.scoreboardBottom.teams[0].players[0].items = [
    { id: 3006, slot: 8, count: 1 },
  ];
  let player = normalizeLeagueBroadcast(raw, now)!.players[0];
  assert.equal(player.roleQuest?.value?.role, "bot");
  assert.equal(player.roleQuest?.value?.rewardItemId, 3006);
  assert.equal(
    player.inventory?.value?.some((i) => i.id === 3006),
    false,
  );
  raw.scoreboardBottom.teams[0].players[0].items = [
    { id: 1206, slot: 8 },
    { id: 3175, slot: 2, count: 1 },
  ];
  player = normalizeLeagueBroadcast(raw, now)!.players[0];
  assert.equal(player.roleQuest?.value?.role, "mid");
  assert.equal(player.roleQuest?.value?.rewardItemId, 3175);
  assert.ok(player.inventory?.value?.some((i) => i.id === 3175));
  raw.scoreboardBottom.teams[0].players[0].items = [{ id: 2055, slot: 8 }];
  player = normalizeLeagueBroadcast(raw, now)!.players[0];
  assert.equal(player.roleQuest?.value?.role, "support");
  assert.equal(player.roleQuest?.value?.rewardItemId, 2055);
});
test("quest completion emits once from observed transition, not initial completed snapshot", () => {
  let clock = Date.parse(now);
  const source = new LeagueBroadcastSource(() => clock);
  const raw: any = frame();
  raw.scoreboardBottom.teams[0].players[0].items = [
    { id: 1200, slot: 8, stats: [1199, 1200] },
  ];
  source.accept({ type: "ingame-state-update", state: raw });
  source.observe();
  raw.gameTime += 0.5;
  clock += 500;
  raw.scoreboardBottom.teams[0].players[0].items = [{ id: 1220, slot: 8 }];
  source.accept({ type: "ingame-state-update", state: raw });
  assert.equal(
    source.observe().newEvents.filter((e) => e.kind === "RoleQuestCompleted")
      .length,
    1,
  );
  raw.gameTime += 0.5;
  clock += 500;
  source.accept({ type: "ingame-state-update", state: raw });
  assert.equal(
    source.observe().newEvents.filter((e) => e.kind === "RoleQuestCompleted")
      .length,
    0,
  );
  source.stop();
});
test("role quest progress uses validated current/target counters from item stats", () => {
  const raw: any = frame();
  raw.scoreboardBottom.teams[0].players[0].items = [
    { id: 1200, slot: 8, stats: [600, 1200] },
  ];
  assert.equal(
    normalizeLeagueBroadcast(raw, now)?.teams?.[0].roleQuests?.value?.[0]
      .progress,
    0.5,
  );
  raw.scoreboardBottom.teams[0].players[0].items.at(-1).stats = [600, 0];
  assert.equal(
    normalizeLeagueBroadcast(raw, now)?.teams?.[0].roleQuests?.value?.[0]
      .progress,
    null,
  );
});
test("LB preserves validated experience and exact upgraded summoner IDs", () => {
  const raw: any = frame();
  raw.tabs.Order.players[0].experience = {
    previousLevel: 100,
    current: 140,
    nextLevel: 200,
    secret: "never",
  };
  raw.tabs.Order.players[0].abilities = [
    { slot: "D", identifier: "S5_SummonerSmitePlayerGanker" },
    { slot: "F", identifier: "S12_SummonerTeleportUpgrade" },
  ];
  const sample = normalizeLeagueBroadcast(raw, now)!;
  assert.deepEqual(sample.players[0].experience?.value, {
    previousLevel: 100,
    current: 140,
    nextLevel: 200,
  });
  assert.deepEqual(sample.players[0].spells?.value, [
    "S5_SummonerSmitePlayerGanker",
    "S12_SummonerTeleportUpgrade",
  ]);
  assert.ok(!JSON.stringify(sample).includes("never"));
  raw.tabs.Order.players[0].experience.nextLevel = 100;
  assert.equal(
    normalizeLeagueBroadcast(raw, now)?.players[0].experience?.value,
    null,
  );
});
test("LB validates GA cooldowns and inhibitor timestamps without leaking raw metadata", () => {
  const raw: any = frame();
  raw.scoreboardBottom.teams[0].players[0].items.push({
    id: 3026,
    slot: 1,
    count: 1,
    readyAt: 708.19775,
    maxCooldown: 300,
    secret: "never",
  });
  raw.tabs.Order.players[0].hasBaron = true;
  raw.inhibitors = [
    { teamid: 2, inhibitors: { L1: { timeDestroy: 410, timeAlive: 710 } } },
  ];
  const sample = normalizeLeagueBroadcast(raw, now)!;
  assert.equal(sample.players[0].hasBaron?.value, true);
  assert.deepEqual(
    sample.players[0].cooldowns?.value?.find((c) => c.id === 3026),
    { kind: "item", slot: "1", id: 3026, readyAt: 708.19775, total: 300 },
  );
  assert.deepEqual(sample.inhibitors?.value, [
    { team: "CHAOS", lane: "mid", destroyedAt: 410, respawnsAt: 710 },
  ]);
  assert.ok(!JSON.stringify(sample).includes("never"));
  raw.scoreboardBottom.teams[0].players[0].items.at(-1).readyAt = -1;
  assert.equal(
    normalizeLeagueBroadcast(raw, now)?.players[0].cooldowns?.value?.some(
      (c) => c.id === 3026,
    ),
    false,
  );
});

test("inhibitor default fills a missing timer but does not override an explicit respawn state", () => {
  const raw: any = frame();
  raw.inhibitors = [{ teamid: 2, inhibitors: { L1: { timeDestroy: 410 } } }];
  assert.equal(
    normalizeLeagueBroadcast(raw, now)?.inhibitors?.value?.[0].respawnsAt,
    710,
  );
  raw.inhibitors[0].inhibitors.L1.timeAlive = 0;
  assert.deepEqual(normalizeLeagueBroadcast(raw, now)?.inhibitors?.value, []);
  raw.inhibitors[0].inhibitors.L1.timeAlive = 750;
  assert.equal(
    normalizeLeagueBroadcast(raw, now)?.inhibitors?.value?.[0].respawnsAt,
    750,
  );
});

test("LB micro-events deduplicate, expire baseline on source loss, and map structures", () => {
  let wall = Date.parse(now);
  const source = new LeagueBroadcastSource(() => wall);
  const a: any = frame();
  a.inhibitors = [];
  source.accept({ type: "ingame-state-update", state: a });
  source.observe();
  wall += 500;
  const b = structuredClone(a);
  b.gameTime += 0.5;
  b.scoreboardBottom.teams[0].players[0].level = 9;
  b.scoreboardBottom.teams[0].players[0].items.push({
    id: 3152,
    slot: 1,
    count: 1,
  });
  b.scoreboard.teams[0].towers++;
  b.inhibitors = [
    { teamid: 2, inhibitors: { L1: { timeDestroy: 420.5, timeAlive: 720.5 } } },
  ];
  source.accept({ type: "ingame-state-update", state: b });
  assert.deepEqual(
    source.observe().newEvents.map((e) => e.kind),
    ["LevelUp", "ItemCompleted", "TurretKilled", "InhibKilled"],
  );
  assert.equal(source.observe().newEvents.length, 0);
  wall += 500;
  const c = structuredClone(b);
  c.gameTime = 721;
  c.inhibitors = [];
  source.accept({ type: "ingame-state-update", state: c });
  assert.equal(source.currentSample()?.events.at(-1)?.kind, "InhibRespawned");
  wall += 6000;
  c.gameTime = 727;
  c.scoreboardBottom.teams[0].players[0].level = 10;
  source.accept({ type: "ingame-state-update", state: c });
  assert.equal(source.currentSample()?.events.length, 0);
  source.stop();
});
function frame(testing = false) {
  const ids = [266, 103, 84, 166, 12, 122, 131, 119, 222, 350];
  return {
    gameTime: 420,
    playbackSpeed: 1,
    gameStatus: 2,
    isTestingEnvironment: testing,
    scoreboardBottom: {
      teams: [0, 1].map((team) => ({
        players: ids.slice(team * 5, team * 5 + 5).map((id, slot) => ({
          champion: { id, name: "untrusted-name" },
          name: "private-player-name",
          level: 8,
          kills: slot,
          deaths: 1,
          assists: 4,
          creepScore: 70,
          visionScore: 5,
          gold: 500,
          totalGold: 4200 + slot,
          respawnAt: slot === 0 ? 430 : undefined,
          items: [
            { id: 1001, slot: 0, count: 1, assetUrl: "https://untrusted" },
            { id: 9999, slot: 8, count: 1, assetUrl: "https://ignored" },
            ...(slot === 0
              ? [
                  {
                    id: team === 0 ? 1200 : 1220,
                    slot: 8,
                    count: 1,
                    displayName: "untrusted-quest-name",
                  },
                ]
              : []),
          ],
        })),
      })),
    },
    tabs: {
      Order: {
        players: Array.from({ length: 5 }, (_, slot) => ({
          health: { current: 500 + slot, max: 1000 },
          resource: { current: 200 + slot, max: 500 },
          abilities: [
            { slot: "D", identifier: "SummonerFlash" },
            { slot: "F", identifier: "SummonerTeleport" },
          ],
          perks: [{ id: 8005, name: "untrusted-rune-name" }],
          hasBaron: false,
        })),
      },
      Chaos: {
        players: Array.from({ length: 5 }, (_, slot) => ({
          health: { current: 600 + slot, max: 1100 },
          resource: { current: 300 + slot, max: 600 },
          abilities: [
            { slot: "D", identifier: "SummonerDot" },
            { slot: "F", identifier: "SummonerFlash" },
          ],
          perks: [{ id: 8112, name: "untrusted-rune-name" }],
          hasBaron: false,
        })),
      },
    },
    scoreboard: {
      teams: [
        {
          gold: 22000,
          kills: 9,
          towers: 2,
          towerPlates: 7,
          dragons: ["fire", "earth"],
          grubs: 3,
        },
        {
          gold: 24000,
          kills: 12,
          towers: 4,
          towerPlates: 2,
          dragons: ["water"],
          grubs: 0,
        },
      ],
    },
    baronPitTimer: { type: "HERALD", timeAlive: 900, timeDestroy: 1185 },
    dragonPitTimer: { type: "DRAGON_AIR", timeAlive: 600, timeDestroy: 0 },
  };
}

test("LeagueBroadcast adapter allowlists a real frame and labels provenance", () => {
  const sample = normalizeLeagueBroadcast(frame(), now);
  assert.ok(sample);
  assert.equal(sample.players.length, 10);
  assert.equal(sample.players[0].championId.value, 266);
  assert.equal(sample.players[0].totalGold.value, 4200);
  assert.equal(sample.players[0].totalGold.source, "leaguebroadcast");
  assert.equal(sample.players[0].isDead?.value, true);
  assert.equal(sample.players[0].respawnSeconds?.value, 10);
  assert.deepEqual(sample.players[0].health?.value, {
    current: 500,
    max: 1000,
  });
  assert.deepEqual(sample.players[0].resource?.value, {
    current: 200,
    max: 500,
  });
  assert.deepEqual(sample.players[0].spells?.value, [
    "SummonerFlash",
    "SummonerTeleport",
  ]);
  assert.equal(sample.players[0].keystone?.value, 8005);
  assert.deepEqual(sample.players[5].spells?.value, [
    "SummonerDot",
    "SummonerFlash",
  ]);
  assert.equal(sample.players[5].keystone?.value, 8112);
  assert.equal(sample.teams?.[0].towers.value, 2);
  assert.deepEqual(sample.teams?.[0].dragons.value, ["fire", "earth"]);
  assert.equal(sample.teams?.[1].totalGold.value, 24000);
  assert.equal(sample.pitTimers?.[0].type.value, "HERALD");
  assert.equal(sample.pitTimers?.[0].timeDestroy.value, 1185);
  assert.deepEqual(sample.players[0].inventory?.value, [
    { slot: 0, id: 1001, count: 1 },
  ]);
  assert.deepEqual(sample.players[0].items.value, [1001]);
  assert.deepEqual(sample.teams?.[0].roleQuests?.value, [
    { role: "top", itemId: 1200, completed: false, progress: null },
  ]);
  assert.deepEqual(sample.teams?.[1].roleQuests?.value, [
    { role: "top", itemId: 1220, completed: true, progress: null },
  ]);
  const exported = JSON.stringify(sample);
  assert.ok(exported.includes('"playerName"'));
  assert.equal(sample.players[0].playerName?.value, "private-player-name");
  assert.ok(!exported.includes("untrusted-name"));
  assert.ok(!exported.includes("untrusted-rune-name"));
  assert.ok(!exported.includes("https://untrusted"));
  assert.ok(!exported.includes("https://ignored"));
});

test("LeagueBroadcast adapter rejects demo, incomplete rosters and invalid champions", () => {
  assert.equal(normalizeLeagueBroadcast(frame(true), now), null);
  const incomplete = frame();
  incomplete.scoreboardBottom.teams[0].players.pop();
  assert.equal(normalizeLeagueBroadcast(incomplete, now), null);
  const invalid = frame();
  invalid.scoreboardBottom.teams[0].players[0].champion.id = 0;
  assert.equal(normalizeLeagueBroadcast(invalid, now), null);
});

test("LeagueBroadcast exposes its upstream loading state without claiming a live frame", () => {
  const source = new LeagueBroadcastSource(() =>
    Date.parse("2026-09-20T00:00:00.000Z"),
  );
  source.accept({
    type: "gameStatus",
    gameState: 1,
    isTestingEnvironment: null,
  });
  const report = source.snapshot();
  assert.equal(report.status, "loading");
  assert.equal(report.gameStatus, "loading");
  assert.equal(report.players, 0);
  assert.equal(report.frames, 0);
  source.stop();
});

test("LeagueBroadcast derives objective events without replaying baseline history", () => {
  let clock = Date.parse("2026-09-20T00:00:00.000Z");
  const source = new LeagueBroadcastSource(() => clock);
  source.accept({
    type: "gameStatus",
    gameState: 2,
    isTestingEnvironment: false,
  });
  const first = frame();
  first.scoreboard.teams[0].dragons = [];
  first.scoreboard.teams[1].dragons = [];
  source.accept({ type: "ingame-state-update", state: first });
  assert.equal(source.observe().newEvents.length, 0);

  clock += 500;
  const dragon = frame();
  dragon.gameTime = 420.5;
  dragon.scoreboard.teams[0].dragons = ["DRAGON_FIRE"];
  dragon.scoreboard.teams[1].dragons = [];
  source.accept({ type: "ingame-state-update", state: dragon });
  assert.deepEqual(
    source
      .observe()
      .newEvents.map((event) => [event.kind, event.team, event.objectiveType]),
    [["DragonKill", "ORDER", "fire"]],
  );

  clock += 500;
  const baron = frame();
  baron.gameTime = 421;
  baron.scoreboard.teams[0].dragons = ["DRAGON_FIRE"];
  baron.scoreboard.teams[1].dragons = [];
  baron.tabs.Chaos.players[0].hasBaron = true;
  source.accept({ type: "ingame-state-update", state: baron });
  assert.deepEqual(
    source
      .observe()
      .newEvents.map((event) => [event.kind, event.team, event.objectiveType]),
    [["BaronKill", "CHAOS", "baron"]],
  );
  source.stop();
});

test("LeagueBroadcast emits a separate Dragon Soul event on the fourth dragon", () => {
  let clock = Date.parse("2026-09-20T00:00:00.000Z");
  const source = new LeagueBroadcastSource(() => clock);
  source.accept({
    type: "gameStatus",
    gameState: 2,
    isTestingEnvironment: false,
  });
  const before = frame();
  before.scoreboard.teams[0].dragons = [
    "DRAGON_FIRE",
    "DRAGON_EARTH",
    "DRAGON_WATER",
  ];
  before.scoreboard.teams[1].dragons = [];
  source.accept({ type: "ingame-state-update", state: before });
  source.observe();
  clock += 500;
  const soul = frame();
  soul.gameTime = 420.5;
  soul.scoreboard.teams[0].dragons = [
    "DRAGON_FIRE",
    "DRAGON_EARTH",
    "DRAGON_WATER",
    "DRAGON_WATER",
  ];
  soul.scoreboard.teams[1].dragons = [];
  source.accept({ type: "ingame-state-update", state: soul });
  assert.deepEqual(
    source
      .observe()
      .newEvents.map((event) => [event.kind, event.objectiveType]),
    [
      ["DragonKill", "water"],
      ["DragonSoul", "water"],
    ],
  );
  source.stop();
});

test("LeagueBroadcast resets objective history on a backward seek", () => {
  let clock = Date.parse("2026-09-20T00:00:00.000Z");
  const source = new LeagueBroadcastSource(() => clock);
  source.accept({
    type: "gameStatus",
    gameState: 2,
    isTestingEnvironment: false,
  });
  source.accept({ type: "ingame-state-update", state: frame() });
  source.observe();
  clock += 500;
  const seek = frame();
  seek.gameTime = 100;
  seek.scoreboard.teams[0].dragons = [];
  seek.scoreboard.teams[1].dragons = [];
  source.accept({ type: "ingame-state-update", state: seek });
  assert.equal(source.observe().newEvents.length, 0);
  source.stop();
});
test("Elder is not counted toward Dragon Soul and unlearned abilities do not claim readiness", () => {
  let clock = Date.parse(now);
  const source = new LeagueBroadcastSource(() => clock);
  const before: any = frame();
  before.scoreboard.teams[0].dragons = [
    "DRAGON_FIRE",
    "DRAGON_EARTH",
    "DRAGON_WATER",
  ];
  before.tabs.Order.players[0].abilities = [
    { slot: "R", readyAt: 0, totalCooldown: 0 },
  ];
  source.accept({ type: "ingame-state-update", state: before });
  source.observe();
  assert.equal(
    source
      .currentSample()
      ?.players[0].cooldowns?.value?.some((c) => c.kind === "ultimate"),
    false,
  );
  clock += 500;
  const after = structuredClone(before);
  after.gameTime += 0.5;
  after.scoreboard.teams[0].dragons.push("DRAGON_ELDER");
  source.accept({ type: "ingame-state-update", state: after });
  assert.deepEqual(
    source.observe().newEvents.map((e) => e.kind),
    ["DragonKill"],
  );
  source.stop();
});
