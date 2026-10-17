import test from "node:test";
import assert from "node:assert/strict";
import { createElement } from "react";
import { renderToStaticMarkup } from "react-dom/server";
import { levelProgress, rankLevels, objectiveVisual } from "../shared/ui-metrics";
import { CooldownVeil } from "../src/overlay/CooldownVeil";
import { liveSpell, resolveSpell } from "../shared/live-assets";
import type { ObservedPlayer } from "../shared/observer";
import { readFileSync } from "node:fs";
import { createHash } from "node:crypto";

test("XP fraction uses current-level thresholds, ranking uses level then progress then slot", () => {
  const p = (slot: number, level: number, current: number): ObservedPlayer =>
    ({
      slot,
      level: { value: level },
      experience: { value: { previousLevel: 100, current, nextLevel: 200 } },
    }) as ObservedPlayer;
  const a = p(0, 2, 150),
    b = p(1, 3, 105),
    c = p(2, 2, 175);
  assert.equal(levelProgress(a), 0.5);
  assert.deepEqual(
    rankLevels([a, b, c]).map((p) => p.slot),
    [1, 2, 0],
  );
  assert.equal(levelProgress({ ...a, experience: undefined }), null);
  assert.equal(levelProgress(p(0, 2, 300)), null);
  assert.deepEqual(
    [a, b, c].map((p) => p.slot),
    [0, 1, 2],
  );
});
test("cooldown sweep clears clockwise from top; numbers appear only during last ten seconds", () => {
  const render = (remaining: number, total = 100) =>
    renderToStaticMarkup(createElement(CooldownVeil, { remaining, total }));
  assert.match(render(50), /transparent 0deg 180deg/);
  assert.doesNotMatch(render(50), /item-countdown/);
  assert.match(render(9.1), /item-countdown">10/);
  assert.equal(render(0), "");
  assert.equal(render(20, 0), "");
  assert.equal(render(Number.NaN), "");
});
test("pit identities map observed GRUB/HERALD/BARON and all seven dragons separately", () => {
  assert.equal(objectiveVisual("GRUB")?.glyph, "grubs");
  assert.equal(objectiveVisual("HERALD")?.glyph, "herald");
  assert.equal(objectiveVisual("BARON")?.glyph, "baron");
  for (const element of ["air", "earth", "fire", "water", "elder", "hextech", "chemtech"])
    assert.equal(objectiveVisual(`DRAGON_${element.toUpperCase()}`)?.glyph, element);
  assert.equal(objectiveVisual("UNDEFINED"), null);
  assert.equal(objectiveVisual("toString"), null);
});
test("Smite and Teleport upgrades resolve exact identifiers, never silently revert to base spell", () => {
  for (const id of [
    "S5_SummonerSmitePlayerGanker",
    "SummonerSmiteAvatarOffensive",
    "SummonerSmiteAvatarDefensive",
    "SummonerSmiteAvatarUtility",
    "S12_SummonerTeleportUpgrade",
  ]) {
    assert.equal(
      resolveSpell({
        rawDisplayName: `GeneratedTip_SummonerSpell_${id}_DisplayName`,
      }),
      id,
    );
    assert.ok(liveSpell(id)?.icon.includes("broadcast/spells"));
    const bytes = readFileSync(`public${liveSpell(id)!.icon}`);
    assert.equal(bytes.subarray(0, 8).toString("hex"), "89504e470d0a1a0a");
  }
  assert.equal(
    resolveSpell({
      rawDisplayName: "GeneratedTip_SummonerSpell_UnknownSmiteUpgrade_DisplayName",
    }),
    null,
  );
});
test("downloaded objective PNGs retain pinned provenance and hashes", () => {
  const manifest = JSON.parse(readFileSync("public/broadcast/objectives/provenance.json", "utf8"));
  assert.equal(manifest.assets.length, 10);
  for (const asset of manifest.assets) {
    const bytes = readFileSync(asset.path);
    assert.equal(bytes.subarray(0, 8).toString("hex"), "89504e470d0a1a0a");
    assert.equal(createHash("sha256").update(bytes).digest("hex"), asset.sha256);
  }
});
