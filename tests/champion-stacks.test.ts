import test from "node:test";
import assert from "node:assert/strict";
import { readFileSync } from "node:fs";
import { createHash } from "node:crypto";
import {
  nativeChampionStacks,
  stackChampions,
  validChampionStacks,
} from "../shared/champion-stacks";
import { ChampionStack } from "../src/overlay/ChampionStack";
import { renderToStaticMarkup } from "react-dom/server";
import { createElement } from "react";
import { normalizeIngame } from "../server/ingame-adapter";
test("stack counters use exact verified buff; zero observed, absent/ambiguous/corrupt never inferred", () => {
  assert.equal(
    nativeChampionStacks(901, [
      { name: "SmolderP", count: 1 },
      { name: "SmolderQPassive", count: 32 },
    ]),
    32,
  );
  assert.equal(
    nativeChampionStacks(45, [
      { name: "VeigarPassive", count: 0 },
      { name: "VeigarPhenomenalEvilPower", count: 77 },
    ]),
    77,
  );
  assert.equal(nativeChampionStacks(901, [{ name: "SmolderQPassive", count: 0 }]), 0);
  assert.equal(nativeChampionStacks(901, []), null);
  assert.equal(
    nativeChampionStacks(901, [
      { name: "SmolderQPassive", count: 3 },
      { name: "smolderqpassive", count: 4 },
    ]),
    null,
  );
  assert.equal(nativeChampionStacks(75, [{ name: "QCharges", count: 999 }]), null);
  for (const v of [-1, NaN, Infinity, "32", null]) assert.equal(validChampionStacks(v), null);
});
test("all eleven operator-selected icons are original cached Riot PNGs with hashes", () => {
  const m = JSON.parse(readFileSync("public/broadcast/champion-stacks/manifest.json", "utf8"));
  assert.equal(m.files.length, 11);
  for (const r of Object.values(stackChampions)) {
    const f = m.files.find((f: any) => f.code === r.code);
    assert.equal(f.ability, r.ability);
    assert.match(
      f.source,
      /^https:\/\/ddragon\.leagueoflegends\.com\/cdn\/16\.20\.1\/img\/(passive|spell)\//,
    );
    const b = readFileSync(f.path);
    assert.equal(b.subarray(1, 4).toString(), "PNG");
    assert.equal(createHash("sha256").update(b).digest("hex"), f.sha256);
  }
});
test("stack widget preserves exact value, missing display zero without fabricating telemetry, and skips other champions", () => {
  const p = normalizeIngame({ allPlayers: [{ championId: 901 }] }, null, "2026-10-17T00:00:00Z")
    .players[0];
  const render = () => renderToStaticMarkup(createElement(ChampionStack, { player: p }));
  assert.match(render(), />0<\/em>/);
  assert.doesNotMatch(render(), /data-stack-value=/);
  assert.match(render(), /chưa có dữ liệu stack/);
  p.championStacks = { ...p.totalGold, value: 12345, availability: "observed" };
  assert.match(render(), /data-stack-value="12345"/);
  assert.match(render(), />12345<\/em>/);
  p.championStacks.value = 0;
  assert.match(render(), />0<\/em>/);
  p.championId.value = 120;
  assert.equal(render(), "");
});
