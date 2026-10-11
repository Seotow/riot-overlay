import test from "node:test";
import assert from "node:assert/strict";
import { readFileSync } from "node:fs";
import { resolve } from "node:path";
import { createHash } from "node:crypto";
import { renderToStaticMarkup } from "react-dom/server";
import { createElement } from "react";
import {
  liveCatalog,
  liveChampion,
  liveItem,
  liveSpell,
  resolveChampion,
  resolveSpell,
} from "../shared/live-assets";
import { normalizeIngame } from "../server/ingame-adapter";
import { ObserverSession } from "../server/observer-session";
import { LiveOverlay } from "../src/overlay/LiveOverlay";
import { createState } from "../shared/mock";
import { recordingSchema } from "../shared/observer";
const now = Date.UTC(2026, 8, 19),
  at = new Date(now).toISOString();
test("Riot live catalog assets are local valid PNGs matching the downloaded manifest", () => {
  const root = `public/ddragon/${liveCatalog.version}`;
  const manifest = JSON.parse(readFileSync(`${root}/manifest.json`, "utf8"));
  assert.equal(manifest.version, liveCatalog.version);
  for (const file of manifest.files) {
    const bytes = readFileSync(file.path);
    assert.equal(bytes.subarray(0, 8).toString("hex"), "89504e470d0a1a0a");
    assert.equal(createHash("sha256").update(bytes).digest("hex"), file.sha256);
  }
  for (const asset of [
    ...Object.values(liveCatalog.champions),
    ...Object.values(liveCatalog.items),
    ...Object.values(liveCatalog.spells),
    ...Object.values(liveCatalog.runes),
  ])
    assert.ok(readFileSync(resolve("public", `.${asset.icon}`)).length > 100);
  for (const champion of Object.values(liveCatalog.champions)) {
    assert.ok(champion.ultimateIcon);
    assert.ok(readFileSync(resolve("public", `.${champion.ultimateIcon}`)).length > 100);
  }
  assert.equal(liveItem(126697)?.name.length! > 0, true);
});
test("champion raw codes resolve independently of display language, and unsafe identifiers never escape", () => {
  assert.equal(
    resolveChampion({
      rawChampionName: "game_character_displayname_Twitch",
      championName: "localized",
    }).id,
    29,
  );
  assert.equal(
    resolveChampion({
      rawChampionName: "game_character_displayname_MonkeyKing",
    }).id,
    62,
  );
  assert.equal(resolveChampion({ championName: "Wukong" }).id, 62);
  assert.equal(resolveChampion({ rawChampionName: "SECRET" }).id, null);
  assert.equal(liveItem(-1), undefined);
  assert.equal(liveSpell("__proto__"), undefined);
});
test("Flash and Mark map from the actual replay raw spell keys", () => {
  for (const id of ["SummonerFlash", "SummonerSnowball", "SummonerHaste"])
    assert.equal(
      resolveSpell({
        rawDisplayName: `GeneratedTip_SummonerSpell_${id}_DisplayName`,
      }),
      id,
    );
  assert.equal(resolveSpell({ rawDisplayName: "SECRET" }), null);
});
test("adapter preserves item slots, maps identities and keeps missing stats null", () => {
  const s = normalizeIngame(
    {
      gameData: { gameTime: 100, mapNumber: 12 },
      allPlayers: [
        {
          rawChampionName: "game_character_displayname_Twitch",
          level: 4,
          team: "ORDER",
          items: [
            { itemID: 2052, slot: 6, count: 1 },
            { itemID: 3086, slot: 0, count: 1 },
          ],
          summonerSpells: {
            summonerSpellOne: {
              rawDisplayName:
                "GeneratedTip_SummonerSpell_SummonerFlash_DisplayName",
            },
            summonerSpellTwo: {
              rawDisplayName:
                "GeneratedTip_SummonerSpell_SummonerSnowball_DisplayName",
            },
          },
          runes: null,
          isDead: false,
          respawnTimer: 0,
          scores: { wardScore: 0 },
          riotId: "SECRET",
        },
      ],
    },
    null,
    at,
  );
  const p = s.players[0];
  assert.equal(s.assetVersion, liveCatalog.version);
  assert.equal(p.championId.value, 29);
  assert.equal(p.championMapping, "raw-code");
  assert.deepEqual(p.spells?.value, ["SummonerFlash", "SummonerSnowball"]);
  assert.equal(p.inventory?.value?.[0].slot, 6);
  assert.equal(p.keystone?.value, null);
  assert.equal(p.health?.value, null);
  assert.equal(p.resource?.value, null);
  assert.equal(p.totalGold.value, null);
  assert.equal(p.isDead?.value, false);
  assert.equal(p.wardScore?.value, 0);
  const frame = new ObserverSession().ingest(s, "test", at);
  const html = renderToStaticMarkup(
    createElement(LiveOverlay, { theme: createState().theme, frame, now }),
  );
  assert.ok(html.includes(liveChampion(29)!.icon));
  assert.ok(html.includes(liveItem(3086)!.icon));
  assert.ok(html.includes(liveSpell("SummonerSnowball")!.icon));
  assert.ok(!html.includes(">3086<"));
  assert.ok(!html.includes("SECRET"));
});
test("unknown item fallback is explicit and old recording fields remain readable", () => {
  const sample = normalizeIngame(
    {
      gameData: { gameTime: 1 },
      allPlayers: [{ items: [{ itemID: 999999, slot: 0 }], team: "ORDER" }],
    },
    null,
    at,
  );
  const f = new ObserverSession().ingest(sample, "r", at);
  const html = renderToStaticMarkup(
    createElement(LiveOverlay, { theme: createState().theme, frame: f, now }),
  );
  assert.ok(html.includes("Chưa có asset item 999999"));
  assert.ok(!html.includes("/999999.png"));
  const old = structuredClone(f);
  delete old.sample!.assetVersion;
  delete old.sample!.assetPatchMatch;
  delete old.sample!.mapNumber;
  const p = old.sample!.players[0];
  for (const key of [
    "championMapping",
    "spells",
    "keystone",
    "wardScore",
    "isDead",
    "respawnSeconds",
    "health",
    "resource",
    "inventory",
  ] as const)
    delete p[key];
  assert.ok(
    recordingSchema.safeParse({
      version: 1,
      kind: "sanitized-observer-recording",
      exportedAt: at,
      frames: [old],
    }).success,
  );
});
