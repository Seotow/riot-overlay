import test from "node:test";
import assert from "node:assert/strict";
import { readFileSync } from "node:fs";
import { createElement } from "react";
import { renderToStaticMarkup } from "react-dom/server";
import { createState, applyCommand } from "../shared/mock";
import { commandSchema } from "../shared/schema";
import { broadcastWidgetOn } from "../shared/broadcast-controls";
import { levelProgress } from "../shared/ui-metrics";
import { InhibitorTimers } from "../src/overlay/InhibitorTimers";
import { graphicEnabled } from "../shared/broadcast-graphics";
import { presentationPitTimers } from "../shared/pit-timers";
import { normalizeIngame } from "../server/ingame-adapter";
import { CooldownVeil } from "../src/overlay/CooldownVeil";
import { SoulTakeover } from "../src/overlay/SoulTakeover";
import {
  advanceBaronWindow,
  advanceElderWindow,
} from "../shared/baron-powerplay";
import { ObserverSession } from "../server/observer-session";
const stamp = "2026-10-16T15:00:00.000Z";
test("buff tint keeps current intensity and fades inward from each edge at30%, not across portrait center",()=>{
 const css=readFileSync("src/overlay/overlay.css","utf8");
 assert.match(css,/linear-gradient\(to right,#000,transparent 30%\)/);
 assert.match(css,/linear-gradient\(to left,#000,transparent 30%\)/);
 assert.match(css,/linear-gradient\(to bottom,#000,transparent 30%\)/);
 assert.match(css,/linear-gradient\(to top,#000,transparent 30%\)/);
 assert.match(css,/@keyframes buff-tint \{ from\{opacity:\.024\} to\{opacity:\.128\}/);
});
test("death styling targets champion portrait only, never nested item cue images", () => {
  const css = readFileSync("src/overlay/overlay.css", "utf8");
  assert.match(css, /\.is-dead \.row-champion > img\s*\{/);
  assert.doesNotMatch(css, /\.is-dead \.row-champion img\s*\{/);
});
test("layout, both leaderboards and runes are independent broadcast controls", () => {
  let state = createState();
  for (const key of ["minimal", "gold", "levels", "runes"] as const)
    state = applyCommand(
      state,
      commandSchema.parse({ type: "broadcastWidget", key, value: true }),
    );
  for (const key of ["minimal", "gold", "levels", "runes"] as const)
    assert.equal(broadcastWidgetOn(state.broadcast, key, state.theme), true);
  state = applyCommand(
    state,
    commandSchema.parse({
      type: "broadcastWidget",
      key: "minimal",
      value: false,
    }),
  );
  assert.equal(
    broadcastWidgetOn(state.broadcast, "minimal", state.theme),
    false,
  );
  assert.equal(broadcastWidgetOn(state.broadcast, "gold", state.theme), true);
  assert.equal(broadcastWidgetOn(state.broadcast, "runes", state.theme), true);
});
test("native total XP yields SR level progress and never fabricates a missing scalar", () => {
  const p = sample().players[0];
  p.level.value = 9;
  p.sourceStats = {
    value: { experience: 5580 },
    availability: "observed",
    source: "league-collector",
    observedAt: stamp,
  };
  assert.equal(levelProgress(p), 0.5);
  p.sourceStats.value = null;
  assert.equal(levelProgress(p), null);
  p.level.value = 18;
  p.sourceStats.value = { experience: 20000 };
  assert.equal(levelProgress(p), null);
});
test("manual inhibitor selection opens all three lanes even when none are down; auto stays hidden", () => {
  const s = sample();
  s.inhibitors = {
    value: [],
    availability: "observed",
    source: "league-collector",
    observedAt: stamp,
  };
  const render = (team?: "ORDER" | "CHAOS") =>
    renderToStaticMarkup(
      createElement(InhibitorTimers, {
        sample: s,
        time: 100,
        theme: createState().theme,
        team,
      }),
    );
  assert.equal(render(), "");
  assert.equal((render("ORDER").match(/class="standing"/g) ?? []).length, 3);
  assert.doesNotMatch(render("ORDER"), /<time>/);
  s.inhibitors.value = [
    { team: "CHAOS", lane: "mid", destroyedAt: 90, respawnsAt: 390 },
  ];
  assert.match(render("CHAOS"), /4:50/);
  assert.doesNotMatch(render("ORDER"), /<time>/);
});
test("rapid independent graphics commands merge flags without changing layout, data or other switches", () => {
  const state = createState();
  let next = applyCommand(
    state,
    commandSchema.parse({
      type: "ingameGraphic",
      key: "soulTakeover",
      value: false,
    }),
  );
  next = applyCommand(
    next,
    commandSchema.parse({
      type: "ingameGraphic",
      key: "pitTimers",
      value: false,
    }),
  );
  assert.equal(next.theme.ingameGraphics?.soulTakeover, false);
  assert.equal(next.theme.ingameGraphics?.pitTimers, false);
  assert.equal(next.theme.variant, state.theme.variant);
  assert.deepEqual(next.players, state.players);
  assert.equal(
    commandSchema.safeParse({
      type: "ingameGraphic",
      key: "unknown",
      value: true,
    }).success,
    false,
  );
});
const sample = () =>
  normalizeIngame(
    {
      gameData: { gameTime: 100 },
      allPlayers: Array.from({ length: 10 }, (_, slot) => ({
        team: slot < 5 ? "ORDER" : "CHAOS",
        championId: 103,
        level: 5,
        scores: { creepScore: 0, kills: 0, deaths: 0, assists: 0 },
        items: [],
      })),
    },
    null,
    stamp,
  );
test("graphics switches are independent and compatible with older theme imports", () => {
  const theme = createState().theme;
  theme.ingameGraphics = {
    soulTakeover: false,
    baronPowerplay: false,
    elderTimer: true,
  };
  assert.equal(graphicEnabled(theme, "soulTakeover"), false);
  assert.equal(graphicEnabled(theme, "baronPowerplay"), false);
  assert.equal(graphicEnabled(theme, "elderTimer"), true);
  assert.equal(theme.variant, "panel");
  const css = readFileSync("src/overlay/overlay.css", "utf8");
  assert.doesNotMatch(css, /:has\(\.live-soul-takeover\)/);
  const event = {
    id: 1,
    at: 100,
    kind: "DragonSoul" as const,
    team: "ORDER" as const,
    objectiveType: "water" as const,
  };
  const banner = renderToStaticMarkup(
    createElement(SoulTakeover, {
      event,
      theme,
      artworkVisible: false,
      bannerVisible: true,
    }),
  );
  assert.doesNotMatch(banner, /class="live-soul-takeover"/);
  assert.match(banner, /soul-description/);
  const panel = renderToStaticMarkup(
    createElement(SoulTakeover, {
      event,
      theme,
      artworkVisible: true,
      bannerVisible: false,
    }),
  );
  assert.match(panel, /class="live-soul-takeover"/);
  assert.doesNotMatch(panel, /soul-description/);
});
test("two pit timers exist with explicitly estimated provenance; reported timers win per pit", () => {
  const s = sample();
  let timers = presentationPitTimers(s);
  assert.equal(timers.length, 2);
  assert.equal(timers[0].type.value, "grubs");
  assert.equal(timers[0].timeAlive.value, 480);
  assert.equal(timers[1].timeAlive.value, 300);
  s.events = [
    { id: 1, at: 90, kind: "DragonKill", team: "ORDER", objectiveType: "fire" },
    { id: 2, at: 95, kind: "BaronKill", team: "ORDER" },
  ];
  timers = presentationPitTimers(s);
  assert.equal(timers[0].timeAlive.value, 455);
  assert.equal(timers[1].timeAlive.value, 390);
  assert.equal(timers[0].basis, "rule-estimate");
  const reported = {
    ...timers[1],
    timeAlive: { ...timers[1].timeAlive, value: 1234 },
  };
  s.pitTimers = [reported];
  assert.equal(presentationPitTimers(s)[1].timeAlive.value, 1234);
  s.events.push({
    id: 3,
    at: 99,
    kind: "DragonSoul",
    team: "ORDER",
    objectiveType: "water",
  });
  delete s.pitTimers;
  assert.equal(presentationPitTimers(s)[1].type.value, "dragon"); // Soul alone is not observed next-monster identity.
  assert.equal(presentationPitTimers(null).length, 0);
});
test("ultimate uses a dark clockwise veil, with numbers only in the final ten seconds", () => {
  const render = (remaining: number) =>
    renderToStaticMarkup(
      createElement(CooldownVeil, { remaining, total: 100, dark: true }),
    );
  assert.match(render(50), /conic-gradient/);
  assert.match(render(50), /#000d/);
  assert.doesNotMatch(render(50), /item-countdown/);
  assert.match(render(10), /item-countdown[^>]*>10/);
  assert.equal(render(0), "");
});
test("recorded history restores Baron/Elder windows after seeking without inventing gold baselines", () => {
  const s = sample();
  for (const p of s.players) {
    p.hasBaron = {
      value: p.slot < 5,
      availability: "observed",
      source: "league-collector",
      observedAt: stamp,
    };
    p.hasElder = { ...p.hasBaron };
  }
  s.events = [
    {
      id: 1,
      at: 90,
      kind: "BaronKill",
      team: "ORDER",
      goldBaseline: { own: 20000, enemy: 18000 },
    },
    {
      id: 2,
      at: 95,
      kind: "DragonKill",
      team: "ORDER",
      objectiveType: "elder",
    },
  ];
  const f = new ObserverSession().ingest(s, "test", stamp);
  f.transition = "seek";
  assert.deepEqual(advanceBaronWindow(null, f), {
    team: "ORDER",
    startedAt: 90,
    ownGold: 20000,
    enemyGold: 18000,
  });
  assert.deepEqual(advanceElderWindow(null, f), {
    team: "ORDER",
    startedAt: 95,
  });
  delete f.sample!.events[0].goldBaseline;
  assert.equal(advanceBaronWindow(null, f)?.ownGold, null);
});
