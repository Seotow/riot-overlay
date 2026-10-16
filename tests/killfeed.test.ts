import test from "node:test";
import assert from "node:assert/strict";
import { renderToStaticMarkup } from "react-dom/server";
import { createElement } from "react";
import { normalizeIngame } from "../server/ingame-adapter";
import { BroadcastKillfeed } from "../src/overlay/BroadcastKillfeed";
import { createState } from "../shared/mock";
import type { ObservedEvent } from "../shared/observer";
import { readFileSync } from "node:fs";
import { createHash } from "node:crypto";

const at = "2026-10-16T00:00:00.000Z";
test("all non-champion killer glyphs reuse assets as white masks", () => {
  const sample = normalizeIngame(fixture(), null, at);
  for (const killerUnitType of [
    "minion",
    "monster",
    "turret",
    "grubs",
  ] as const) {
    const html = renderToStaticMarkup(
      createElement(BroadcastKillfeed, {
        events: [
          {
            id: 1,
            at: 100,
            kind: "ChampionKill",
            killerUnitType,
            victimSlot: 1,
          },
        ],
        sample,
        theme: createState().theme,
      }),
    );
    assert.match(html, /feed-objective-icon/);
    assert.doesNotMatch(html, /feed-missing/);
    assert.match(
      html,
      killerUnitType === "turret"
        ? /glyphs\/tower\.svg/
        : killerUnitType === "grubs"
          ? /objectives\/grubs\.svg/
          : new RegExp(`killers/${killerUnitType}\\.png`),
    );
  }
});
function fixture() {
  return {
    gameData: { gameTime: 100 },
    allPlayers: [
      {
        riotId: "PRIVATE#1",
        summonerName: "PRIVATE",
        championId: 120,
        team: "ORDER",
      },
      {
        riotId: "ENEMY#2",
        summonerName: "ENEMY",
        championId: 103,
        team: "CHAOS",
      },
      { riotId: "HELP#3", championId: 222, team: "ORDER" },
    ],
    events: {
      Events: [
        {
          EventID: 1,
          EventTime: 99,
          EventName: "ChampionKill",
          KillerName: "PRIVATE#1",
          VictimName: "ENEMY",
          Assisters: ["HELP#3", "HELP#3", "UNKNOWN", "PRIVATE#1"],
        },
      ],
    },
  };
}
test("Riot event actors map exact slots; event contract excludes raw identity while roster permits nickname", () => {
  const input = fixture(),
    before = JSON.stringify(input);
  const s = normalizeIngame(input, null, at),
    e = s.events[0];
  assert.equal(e.killerSlot, 0);
  assert.equal(e.victimSlot, 1);
  assert.deepEqual(e.assistSlots, [2]);
  assert.ok(!JSON.stringify(s.events).includes("PRIVATE"));
  assert.equal(s.players[0].playerName?.value, "PRIVATE");
  assert.equal(JSON.stringify(input), before);
  input.allPlayers[1].summonerName = "PRIVATE";
  input.events.Events[0].KillerName = "PRIVATE";
  assert.equal(
    normalizeIngame(input, null, at).events[0].killerSlot,
    undefined,
  );
});
test("broadcast killfeed shows actual killer, victim and helpers; unknown actors stay missing", () => {
  const sample = normalizeIngame(fixture(), null, at);
  const html = renderToStaticMarkup(
    createElement(BroadcastKillfeed, {
      events: sample.events,
      sample,
      theme: createState().theme,
    }),
  );
  assert.match(html, /alt="PRIVATE"/);
  assert.match(html, /alt="ENEMY"/);
  assert.match(html, /alt="HELP"/);
  assert.match(html, /<span class="feed-kill-mark"/);
  const unknown = renderToStaticMarkup(
    createElement(BroadcastKillfeed, {
      events: [{ id: 3, at: 100, kind: "ChampionKill" }],
      sample,
      theme: createState().theme,
    }),
  );
  assert.doesNotMatch(unknown, /feed-champion/);
  assert.match(unknown, /feed-missing/);
});
test("neutral monster kill uses a white objective icon as killer, never a team identity", () => {
  const sample = normalizeIngame(fixture(), null, at);
  const html = renderToStaticMarkup(
    createElement(BroadcastKillfeed, {
      events: [
        {
          id: 55,
          at: 100,
          kind: "ChampionKill",
          killerObjectiveType: "chemtech",
          victimSlot: 1,
        },
      ],
      sample,
      theme: createState().theme,
    }),
  );
  assert.match(html, /objectives\/riot-16.20\/chemtech\.png/);
  assert.match(html, /alt="ENEMY"/);
  assert.match(html, /broadcast-feed-row unknown/);
  assert.doesNotMatch(html, /feed-missing/);
});

test("killfeed uses the pinned original All-In PNG and translucent team-color backgrounds", () => {
  const provenance = JSON.parse(
    readFileSync("public/broadcast/all-in-ping.provenance.json", "utf8"),
  );
  const png = readFileSync("public/broadcast/all-in-ping.png");
  assert.equal(png.subarray(1, 4).toString(), "PNG");
  assert.equal(
    createHash("sha256").update(png).digest("hex"),
    provenance.sha256,
  );
  assert.match(
    provenance.source,
    /16\.20\/game\/assets\/ux\/minimap\/pings\/all_in\.png$/,
  );
  const css = readFileSync("src/overlay/overlay.css", "utf8");
  assert.match(css, /mask:url\('\/broadcast\/all-in-ping\.png'\)/);
  assert.match(css, /--feed-team:var\(--blue\)/);
  assert.match(css, /--feed-team:var\(--red\)/);
  assert.match(css, /color-mix\(in srgb,var\(--feed-team\) 34%,transparent\)/);
});
test("all elemental and epic monster icons use existing assets as white masks; generic dragon has no missing URL", () => {
  const sample = normalizeIngame(fixture(), null, at);
  const events: ObservedEvent[] = [
    "fire",
    "water",
    "earth",
    "air",
    "hextech",
    "chemtech",
    "elder",
  ].map((type, i) => ({
    id: i,
    at: 100,
    kind: "DragonKill",
    objectiveType: type as ObservedEvent["objectiveType"],
  }));
  events.push(
    { id: 8, at: 100, kind: "BaronKill" },
    { id: 9, at: 100, kind: "HeraldKill" },
    { id: 10, at: 100, kind: "DragonKill" },
  );
  const html = renderToStaticMarkup(
    createElement(BroadcastKillfeed, {
      events,
      sample,
      theme: createState().theme,
    }),
  );
  assert.equal((html.match(/class="feed-objective-icon"/g) ?? []).length, 10);
  assert.match(html, /mask-image:url\(\/broadcast\/objectives\/mixed\/baron.svg\)/);
  assert.doesNotMatch(html, /\/dragon.svg/);
  assert.match(html, /chưa rõ loại/);
});
