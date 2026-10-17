import test from "node:test";
import assert from "node:assert/strict";
import { showItemCooldown, excludedCooldownItems, bootIds } from "../shared/role-quest";
import { liveSpell } from "../shared/live-assets";
import variants from "../shared/generated/spell-variants.json";
import { renderToStaticMarkup } from "react-dom/server";
import { createElement } from "react";
import { QuestCompletion } from "../src/overlay/QuestCompletion";
test("consumables and wards never receive broadcast cooldowns; pivotal actives remain", () => {
  for (const id of excludedCooldownItems) assert.equal(showItemCooldown(id), false, String(id));
  for (const id of [3152, 3157, 3026, 2065]) assert.equal(showItemCooldown(id), true, String(id));
  assert.equal(showItemCooldown(null), false);
  assert.ok(bootIds.has(3172));
});
test("Smite avatar assets match the three actual jungle companions", () => {
  assert.match(variants.spells.SummonerSmiteAvatarOffensive.source, /1101_smite/);
  assert.match(variants.spells.SummonerSmiteAvatarUtility.source, /1102_smite/);
  assert.match(variants.spells.SummonerSmiteAvatarDefensive.source, /1103_smite/);
  assert.match(liveSpell("SummonerSmiteAvatarOffensive")!.name, /Scorchclaw/);
  assert.match(liveSpell("SummonerSmiteAvatarUtility")!.icon, /SummonerSmiteAvatarUtility/);
  assert.match(liveSpell("SummonerSmiteAvatarDefensive")!.icon, /SummonerSmiteAvatarDefensive/);
});
test("quest reward banner supports all five roles without sponsor artwork", () => {
  for (const role of ["top", "jungle", "mid", "bot", "support"] as const) {
    const html = renderToStaticMarkup(createElement(QuestCompletion, { role }));
    assert.match(html, /QUEST COMPLETE/);
    assert.ok(!html.includes("/references/"));
  }
});
