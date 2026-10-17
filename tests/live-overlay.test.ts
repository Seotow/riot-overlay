import test from "node:test";
import assert from "node:assert/strict";
import { renderToStaticMarkup } from "react-dom/server";
import { createElement } from "react";
import { LiveOverlay } from "../src/overlay/LiveOverlay";
import { createState } from "../shared/mock";
import { normalizeIngame } from "../server/ingame-adapter";
import { ObserverSession } from "../server/observer-session";
import { livePresentation, projectedGameTime } from "../shared/live-presentation";
import { liveCatalog } from "../shared/live-assets";
import { objectiveIconUrl } from "../shared/objective-icons";
const now = Date.UTC(2026, 8, 19);

test("team presentation sorts observed lane quests without changing source slots or same-lane gold pairing", () => {
  const f = frame(),
    s = f.sample!,
    original = s.players.map((p) => p.slot);
  const lanes = ["support", "bot", "top", "mid", "jungle"] as const;
  for (const p of s.players) {
    p.roleQuest = {
      ...p.totalGold,
      availability: "observed",
      value: {
        role: lanes[p.slot % 5],
        itemId: 0 + 1220,
        completed: false,
        progress: 0,
        rewardItemId: null,
        rewardSpellId: null,
      },
    };
    p.totalGold = { ...p.totalGold, value: 1000 + p.slot * 100, availability: "observed" };
  }
  let v = livePresentation(f, now);
  assert.deepEqual(
    v.blue.map((p) => p.slot),
    [2, 4, 3, 1, 0],
  );
  assert.deepEqual(
    v.red.map((p) => p.slot),
    [7, 9, 8, 6, 5],
  );
  assert.deepEqual(
    s.players.map((p) => p.slot),
    original,
  );
  assert.ok(v.laneGold.every((g) => g?.value === 500 && g.leader === "red"));
  s.players[7].roleQuest!.availability = "missing";
  v = livePresentation(f, now);
  assert.equal(v.red.at(-1)?.slot, 7);
  assert.equal(v.laneGold[0], null); // Do not compare known Top against a different role.
});
test("champion stack takes secondary rune/quest priority in both full layouts and overlays ultimate in simple", () => {
  const f = frame(),
    p = f.sample!.players[0];
  f.sample!.assetVersion = liveCatalog.version;
  p.championId = { ...p.championId, value: 901 };
  p.championStacks = { ...p.totalGold, value: 32, availability: "observed" };
  p.perks = { ...p.totalGold, value: [8112, 8143, 8140, 8106, 8017, 8009, 5005, 5008, 5011] };
  p.roleQuest = {
    ...p.totalGold,
    value: {
      role: "top",
      itemId: 1220,
      completed: true,
      progress: 1,
      rewardItemId: null,
      rewardSpellId: "S12_SummonerTeleportUpgrade",
    },
  };
  for (const playerCameras of [false, true]) {
    const html = renderToStaticMarkup(
      createElement(LiveOverlay, {
        theme: { ...createState().theme, playerCameras },
        frame: f,
        now,
      }),
    );
    assert.match(
      html,
      /row-runes has-champion-stack[^]*?secondary-stack[^]*?data-stack-value="32"/,
    );
    assert.doesNotMatch(html, /row-secondary quest-reward/);
    assert.match(html, /minimal-ultimate[^]*?minimal-stack[^]*?data-stack-value="32"/);
  }
});
test("team runes temporarily replace player table in either layout without changing selection", () => {
  const f = frame();
  for (const layout of ["panel", "minimal"] as const) {
    const render = (runes: boolean) =>
      renderToStaticMarkup(
        createElement(LiveOverlay, {
          theme: { ...createState().theme, variant: layout },
          frame: f,
          now,
          broadcast: { view: "normal", inhibitors: "off", layout, runes },
        }),
      );
    assert.doesNotMatch(render(true), /data-region="players"/);
    assert.match(render(true), /data-region="runes"/);
    assert.match(render(false), /data-region="players"/);
  }
});
test("rune team branding uses team names and only renders supplied logos below names", () => {
  const f = frame();
  const render = (blueLogo?: string, redLogo?: string) =>
    renderToStaticMarkup(
      createElement(LiveOverlay, {
        theme: { ...createState().theme, blueLogo, redLogo },
        frame: f,
        now,
        broadcast: { view: "normal", inhibitors: "off", runes: true },
      }),
    );
  assert.doesNotMatch(render(), /class="rune-team-logo"/);
  const png = "data:image/png;base64,iVBORw0KGgo=";
  const html = render(png, png);
  assert.equal((html.match(/class="rune-team-logo"/g) ?? []).length, 2);
  assert.match(html, /rune-team-brand rune-blue-name[^]*?<b[^]*?<\/b><img class="rune-team-logo"/);
});
test("scoreboard and both rankings share sanitized nickname and explicit override", () => {
  const f = frame();
  f.sample!.players[0].playerName = { ...f.sample!.players[0].totalGold, value: "Seotoww" };
  f.sample!.players[0].totalGold = { ...f.sample!.players[0].totalGold, value: 1000 };
  const render = (playerNames?: string[]) =>
    renderToStaticMarkup(
      createElement(LiveOverlay, {
        theme: { ...createState().theme, playerNames },
        frame: f,
        now,
        broadcast: { view: "normal", inhibitors: "off", gold: true, levels: true },
      }),
    );
  assert.ok((render().match(/>Seotoww</g) ?? []).length >= 3);
  assert.ok(
    (render(["Override#VN2", ...Array(9).fill("")]).match(/>Override</g) ?? []).length >= 3,
  );
  assert.doesNotMatch(render(["Override#VN2", ...Array(9).fill("")]), /#VN2/);
});
test("dead player's resource bar displays zero without changing recorded resource; alive restores it", () => {
  const f = frame();
  const p = f.sample!.players[0];
  p.resource = { ...p.totalGold, value: { current: 75, max: 100 } };
  p.isDead = { ...p.totalGold, value: true };
  const render = () =>
    renderToStaticMarkup(
      createElement(LiveOverlay, {
        theme: createState().theme,
        frame: f,
        now,
      }),
    );
  assert.equal(render().match(/class="resource-track"[^>]*><i style="width:([^;\"]+)/)?.[1], "0%");
  assert.equal(p.resource.value!.current, 75);
  p.isDead.value = false;
  assert.equal(render().match(/class="resource-track"[^>]*><i style="width:([^;\"]+)/)?.[1], "75%");
});
test("preview variants show all pit types, Baron/Elder separately or together without changing source", () => {
  const f = frame(),
    s = f.sample!;
  const observed = <T>(value: T) => ({
    value,
    availability: "observed" as const,
    source: "leaguebroadcast" as const,
    observedAt: s.capturedAt,
  });
  s.pitTimers = [
    {
      pit: "baron",
      type: observed("BARON"),
      timeAlive: observed(300),
      timeDestroy: observed(0),
    },
    {
      pit: "dragon",
      type: observed("DRAGON_FIRE"),
      timeAlive: observed(300),
      timeDestroy: observed(0),
    },
  ];
  const baseline = JSON.stringify(f);
  const render = (variant: import("../shared/rehearsal").RehearsalVariant) =>
    renderToStaticMarkup(
      createElement(LiveOverlay, {
        theme: createState().theme,
        frame: f,
        now,
        rehearsal: {
          kind: variant.buffs ? "baron" : "timers",
          variant,
          previewAt: 123,
        },
      }),
    );
  for (const pit of ["GRUB", "HERALD", "BARON"] as const)
    for (const dragon of [
      "earth",
      "fire",
      "water",
      "air",
      "hextech",
      "chemtech",
      "elder",
    ] as const) {
      const html = render({ pit, dragon });
      assert.ok(!html.includes("GIẢ LẬP UI"));
      assert.ok(html.includes(objectiveIconUrl(pit)));
      assert.ok(html.includes(`/broadcast/objectives/riot-16.20/${dragon}.png`));
    }
  for (const buffs of ["baron", "elder", "both"] as const) {
    const html = render({ buffs });
    assert.equal(html.includes('data-region="baron"'), buffs !== "elder");
    assert.equal(html.includes('data-region="elder"'), buffs !== "baron");
    if (buffs !== "elder") assert.ok(html.includes("3:00"));
    if (buffs !== "baron") assert.ok(html.includes("2:30"));
  }
  assert.equal(JSON.stringify(f), baseline);
});
test("two rune slots beside spells remain separate from actual ultimate, quest replaces only secondary", () => {
  const f = frame(),
    s = f.sample!;
  s.assetVersion = liveCatalog.version;
  const observed = <T>(value: T) => ({
    value,
    availability: "observed" as const,
    source: "leaguebroadcast" as const,
    observedAt: s.capturedAt,
  });
  for (const p of s.players) {
    p.championId = observed(120);
    p.keystone = observed(8112);
    p.perks = observed([8112, 8143, 8140, 8106, 8017, 8009, 5005, 5008, 5011]);
  }
  const render = () =>
    renderToStaticMarkup(createElement(LiveOverlay, { theme: createState().theme, frame: f, now }));
  let html = render();
  assert.equal((html.match(/class="row-runes"/g) || []).length, 10);
  assert.equal((html.match(/class="row-keystone" title="Electrocute"/g) || []).length, 10);
  assert.equal((html.match(/class="row-secondary rune-path" title="Precision"/g) || []).length, 10);
  assert.equal((html.match(/class="row-ultimate on-cooldown"/g) || []).length, 10);
  assert.equal((html.match(/src="\/ddragon\/16.20.1\/ability\/Hecarim.png"/g) || []).length, 20);
  s.players[0].roleQuest = observed({
    role: "bot" as const,
    itemId: 3006,
    completed: true,
    progress: null,
    rewardItemId: 3006,
    rewardSpellId: null,
  });
  html = render();
  assert.equal((html.match(/class="row-keystone" title="Electrocute"/g) || []).length, 10);
  assert.equal((html.match(/class="row-secondary rune-path" title="Precision"/g) || []).length, 10);
  assert.match(html, /class="quest-reward"[^]*?title="Berserker&#x27;s Greaves"/);
});
test("lane quest keeps observed circular progress beside inventory and restores secondary path after completion", () => {
  const f = frame();
  const s = f.sample!;
  s.assetVersion = liveCatalog.version;
  const observed = <T>(value: T) => ({
    value,
    availability: "observed" as const,
    source: "leaguebroadcast" as const,
    observedAt: s.capturedAt,
  });
  const p = s.players[0];
  p.championId = observed(120);
  p.perks = observed([8112, 8143, 8140, 8106, 8017, 8009, 5005, 5008, 5011]);
  p.keystone = observed(8112);
  p.roleQuest = observed({
    role: "jungle" as const,
    itemId: 1204,
    completed: false,
    progress: 0.5,
    rewardItemId: null,
    rewardSpellId: null,
  });
  const render = () =>
    renderToStaticMarkup(createElement(LiveOverlay, { theme: createState().theme, frame: f, now }));
  let html = render();
  assert.match(html, /row-lane-quest pending[^]*?Tiến độ 50%/);
  assert.ok(html.indexOf('class="row-items"') < html.indexOf('class="row-lane-quest pending"'));
  assert.ok(html.indexOf('class="row-lane-quest pending"') < html.indexOf('class="row-runes"'));
  assert.match(html, /row-secondary rune-path" title="Precision"/);
  p.roleQuest.value!.completed = true;
  p.roleQuest.value!.rewardSpellId = "SummonerSmiteAvatarOffensive";
  html = render();
  assert.match(html, /row-lane-quest completed/);
  assert.match(html, /row-secondary rune-path" title="Precision"/);
  assert.doesNotMatch(html, /class="row-secondary quest-reward"/);
  const cameraRender = () =>
    renderToStaticMarkup(
      createElement(LiveOverlay, {
        theme: { ...createState().theme, playerCameras: true },
        frame: f,
        now,
      }),
    );
  html = cameraRender();
  assert.doesNotMatch(html, /row-lane-quest/);
  assert.match(html, /live-role-quests blue-role-quests/);
  assert.match(html, /row-secondary quest-reward/);
  p.roleQuest.value!.completed = false;
  p.roleQuest.value!.progress = 0.5;
  html = cameraRender();
  assert.match(html, /Tiến độ 50%/);
  assert.match(html, /row-secondary rune-path" title="Precision"/);
});
test("observed cooldowns, Baron count and inhibitor timer disappear when source expires", () => {
  const f = frame();
  const s = f.sample!;
  s.assetVersion = liveCatalog.version;
  const observed = <T>(value: T) => ({
    value,
    availability: "observed" as const,
    source: "leaguebroadcast" as const,
    observedAt: s.capturedAt,
  });
  s.players[0].hasBaron = observed(true);
  s.players[0].inventory = observed([{ id: 3026, slot: 0, count: 1 }]);
  s.players[0].cooldowns = observed([
    { kind: "item", slot: "0", id: 3026, readyAt: 403, total: 300 },
  ]);
  s.inhibitors = observed([{ team: "CHAOS", lane: "mid", destroyedAt: 100, respawnsAt: 400 }]);
  const render = (at: number) =>
    renderToStaticMarkup(
      createElement(LiveOverlay, {
        theme: createState().theme,
        frame: f,
        now: at,
      }),
    );
  assert.ok(render(now).includes("baron-player-buff"));
  assert.ok(!render(now).includes("live-buff-status"));
  assert.ok(render(now).includes("NHÀ LÍNH"));
  assert.ok(render(now).includes('class="cooldown-sweep"'));
  assert.ok(!render(now).includes('class="item-countdown">280'));
  assert.ok(render(now).includes("4:37"));
  s.inhibitors!.value![0].respawnsAt = 183.2;
  assert.ok(render(now).includes("1:01"));
  assert.ok(!render(now).includes("0:60"));
  assert.ok(!render(now + 6000).includes("NHÀ LÍNH"));
  assert.ok(!render(now + 6000).includes("baron-player-buff"));
});
test("death timer projects with speed, freezes on pause and never fabricates revival", () => {
  const f = frame(),
    s = f.sample!;
  const observed = <T>(value: T) => ({
    value,
    availability: "observed" as const,
    source: "leaguebroadcast" as const,
    observedAt: s.capturedAt,
  });
  s.players[0].isDead = observed(true);
  s.players[0].respawnSeconds = observed(10);
  s.replay.speed = observed(2);
  s.replay.paused = observed(false);
  assert.equal(livePresentation(f, now + 1000).blue[0].respawnSeconds?.value, 8);
  assert.equal(s.players[0].respawnSeconds.value, 10);
  s.replay.paused = observed(true);
  assert.equal(livePresentation(f, now + 1000).blue[0].respawnSeconds?.value, 10);
  s.players[0].respawnSeconds = observed(0);
  assert.equal(livePresentation(f, now + 1000).blue[0].isDead?.value, true);
});
test("observed level ranking respects widget switches and stale source", () => {
  const theme = createState().theme;
  theme.widgets.levels = true;
  theme.widgets.players = false;
  const render = (at: number) =>
    renderToStaticMarkup(createElement(LiveOverlay, { theme, frame: frame(), now: at }));
  assert.ok(render(now).includes("XP + LVL"));
  assert.ok(!render(now).includes("live-player-row"));
  assert.ok(!render(now + 5000).includes("XP + LVL"));
});
test("real rehearsal gold ranking and Power Play never fill missing data", () => {
  const f = frame();
  f.sample!.players[0].totalGold.value = 12000;
  const render = (rehearsal: any, at = now) =>
    renderToStaticMarkup(
      createElement(LiveOverlay, {
        theme: createState().theme,
        frame: f,
        now: at,
        rehearsal,
      }),
    );
  assert.ok(render({ kind: "gold" }).includes("12.0K"));
  assert.ok(render({ kind: "gold" }).includes("ranking-track"));
  assert.ok(!render({ kind: "gold" }, now + 5000).includes("TOTAL GOLD"));
  assert.ok(render({ kind: "baron" }).includes("CHƯA CÓ MỐC VÀNG"));
  assert.ok(
    render({
      kind: "baron",
      powerPlay: { team: "ORDER", startedAt: 100, goldDelta: 1250 },
    }).includes("+1,250"),
  );
});
test("level leaderboard shows ten ranked rows and observed XP before current level", () => {
  const f = frame();
  for (const p of f.sample!.players)
    p.experience = {
      value: { previousLevel: 100, current: 100 + p.slot * 10, nextLevel: 200 },
      availability: "observed",
      source: "leaguebroadcast",
      observedAt: f.sample!.capturedAt,
    };
  const html = renderToStaticMarkup(
    createElement(LiveOverlay, {
      theme: createState().theme,
      frame: f,
      now,
      rehearsal: { kind: "levels" },
    }),
  );
  assert.equal((html.match(/data-slot=/g) ?? []).length, 10);
  assert.equal((html.match(/role="progressbar"/g) ?? []).length, 20);
  assert.ok(html.indexOf('data-slot="9"') < html.indexOf('data-slot="0"'));
  assert.match(html, /aria-valuenow="90"/);
  assert.match(html, /class="xp-percent">90%/);
  assert.match(html, /level-progress[^]*?<\/div><b class="rank-level">4<\/b>/);
});
test("Power Play puts signed gold above timer with the user-defined three minute fallback", () => {
  const render = (endsAt?: number) =>
    renderToStaticMarkup(
      createElement(LiveOverlay, {
        theme: createState().theme,
        frame: frame(),
        now,
        rehearsal: {
          kind: "baron",
          powerPlay: { team: "ORDER", startedAt: 100, goldDelta: -20, endsAt },
        },
      }),
    );
  assert.match(render(280), /<b>-20<\/b><time>2:37<\/time>/);
  assert.match(render(), /<time>2:37<\/time>/);
});
function frame(count = 10) {
  const sample = normalizeIngame(
    {
      gameData: { gameTime: 123 },
      allPlayers: Array.from({ length: count }, (_, i) => ({
        team: i < 5 ? "ORDER" : "CHAOS",
        level: 4,
        scores: { kills: i, deaths: 0, assists: 2, creepScore: 10 },
        items: [],
      })),
    },
    null,
    new Date(now).toISOString(),
  );
  return new ObserverSession().ingest(sample, "test", sample.capturedAt);
}
test("live overlay retains scoreboard and ten rows without mock values when source is missing", () => {
  const html = renderToStaticMarkup(
    createElement(LiveOverlay, {
      theme: createState().theme,
      frame: null,
      now,
    }),
  );
  assert.ok(html.includes('data-region="scoreboard"'));
  assert.equal((html.match(/live-player-row/g) || []).length, 10);
  for (const fixture of ["43.0K", "48.0K", "25:38", "PerfecT", "931", "BARON BUFF"])
    assert.ok(!html.includes(fixture));
  assert.ok(html.includes("CHỜ DỮ LIỆU"));
});
test("live overlay renders real time and KDA while missing gold stays unknown", () => {
  const f = frame();
  const view = livePresentation(f, now);
  assert.equal(view.blueKills, 10);
  assert.equal(view.redKills, 35);
  assert.equal(view.blueGold, null);
  const html = renderToStaticMarkup(
    createElement(LiveOverlay, { theme: createState().theme, frame: f, now }),
  );
  assert.ok(html.includes("02:03"));
  assert.ok(html.includes("9/0/2"));
  assert.ok(!html.includes("48.0K"));
});
test("stale data clears numbers but preserves the layout; partial teams never produce totals", () => {
  assert.equal(livePresentation(frame(), now + 5000).time, null);
  assert.equal(livePresentation(frame(9), now).redKills, null);
  const html = renderToStaticMarkup(
    createElement(LiveOverlay, {
      theme: createState().theme,
      frame: frame(),
      now: now + 6000,
    }),
  );
  assert.ok(html.includes('data-region="players"'));
  assert.ok(!html.includes("9/0/2"));
});

test("presentation clock advances from an authoritative snapshot without changing discrete state", () => {
  const f = frame();
  assert.equal(projectedGameTime(f, now + 250), 123.25);
  assert.equal(livePresentation(f, now + 250).blueKills, 10);
  assert.equal(projectedGameTime(f, now + 5000), null);
});

test("presentation clock respects replay pause and playback speed", () => {
  const make = (paused: boolean, speed: number) => {
    const sample = normalizeIngame(
      { gameData: { gameTime: 100 } },
      { time: 100, paused, speed },
      new Date(now).toISOString(),
    );
    return new ObserverSession().ingest(sample, "clock", sample.capturedAt);
  };
  assert.equal(projectedGameTime(make(true, 2), now + 400), 100);
  assert.equal(projectedGameTime(make(false, 2), now + 400), 100.8);
});

test("team lead, lane gaps, towers, dragons and objective timers use observed data", () => {
  const f = frame();
  const sample = f.sample!;
  sample.players.forEach((player, index) => {
    player.totalGold = {
      value:
        index < 5
          ? 5000 + index * 100
          : index === 6
            ? 7000
            : index === 9
              ? 1000
              : 4000 + index * 300,
      availability: "observed",
      source: "leaguebroadcast",
      observedAt: sample.capturedAt,
    };
  });
  const observed = <T>(value: T) => ({
    value,
    availability: "observed" as const,
    source: "leaguebroadcast" as const,
    observedAt: sample.capturedAt,
  });
  sample.teams = [
    {
      team: "ORDER",
      totalGold: observed(45000),
      kills: observed(14),
      towers: observed(6),
      towerPlates: observed(0),
      dragons: observed(["fire"]),
      grubs: observed(3),
    },
    {
      team: "CHAOS",
      totalGold: observed(40000),
      kills: observed(9),
      towers: observed(2),
      towerPlates: observed(0),
      dragons: observed(["water", "earth"]),
      grubs: observed(0),
    },
  ];
  sample.pitTimers = [
    {
      pit: "baron",
      type: observed("BARON"),
      timeAlive: observed(100),
      timeDestroy: observed(100),
    },
    {
      pit: "dragon",
      type: observed("DRAGON_HEXTECH"),
      timeAlive: observed(180),
      timeDestroy: observed(300),
    },
  ];
  const html = renderToStaticMarkup(
    createElement(LiveOverlay, { theme: createState().theme, frame: f, now }),
  );
  assert.match(html, /class="blue-lead">\+5\.0K/);
  assert.ok(!html.includes("-5.0K"));
  assert.ok(html.includes('class="lane-gold-blue"'));
  assert.ok(html.includes("lane-gold-arrow blue"));
  assert.ok(html.includes("4.4K"));
  assert.ok(html.includes('class="lane-gold-red">'));
  assert.ok(html.includes('title="Số trụ"'));
  assert.equal((html.match(/metric-icon dragon/g) || []).length, 4);
  assert.equal((html.match(/row-lane-quest/g) || []).length, 10);
  assert.equal((html.match(/Role Quest đội/g) || []).length, 0);
  assert.ok(html.includes("dragon-fire"));
  assert.ok(html.includes("dragon-water"));
  assert.ok(html.includes("dragon-earth"));
  assert.ok(html.includes("HEXTECH"));
  assert.ok(html.includes("00:57"));
  assert.ok(html.includes('data-available="true"'));
  assert.ok(html.includes("is-available"));
  assert.ok(!html.includes(">LIVE<"));
});
test("ultimate stays locked below level 6 even when its cooldown reads ready, and unlocks at 6", () => {
  const f = frame(),
    s = f.sample!;
  s.assetVersion = liveCatalog.version;
  const observed = <T>(value: T) => ({
    value,
    availability: "observed" as const,
    source: "leaguebroadcast" as const,
    observedAt: s.capturedAt,
  });
  for (const p of s.players) {
    p.championId = observed(120);
    p.cooldowns = observed([{ kind: "ultimate" as const, slot: "R", readyAt: 0, total: 100 }]);
    p.level = observed(5);
  }
  const render = () =>
    renderToStaticMarkup(createElement(LiveOverlay, { theme: createState().theme, frame: f, now }));
  let html = render();
  assert.equal((html.match(/class="row-ultimate on-cooldown"/g) || []).length, 10);
  assert.match(html, /Chưa học R \(cấp 6\)/);
  // Solid black cover on both the panel icon and the simple-layout icon of every player.
  assert.equal((html.match(/class="ult-lock-cover"/g) || []).length, 20);
  for (const p of s.players) p.level = observed(6);
  html = render();
  assert.equal((html.match(/class="row-ultimate on-cooldown"/g) || []).length, 0);
  assert.equal((html.match(/ult-lock-cover/g) || []).length, 0);
});
