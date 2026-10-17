import { test } from "node:test";
import assert from "node:assert/strict";
import { statSync } from "node:fs";
import { resolve } from "node:path";
import { champion, item, spell, rune, catalog } from "../shared/assets";
import { draftFixture, ingameFixture } from "../shared/reference";

test("every mocked game entity resolves to a named, cached Data Dragon asset", () => {
  const assets = new Set<string>();
  for (const id of [
    ...ingameFixture.champions,
    ...draftFixture.picks,
    ...draftFixture.blueBans,
    ...draftFixture.redBans,
  ]) {
    const c = champion(id);
    assert.ok(c?.name, `Missing champion ${id}`);
    assets.add(c.icon);
    assets.add(c.portrait);
  }
  for (const id of ingameFixture.items.flat()) {
    assert.ok(item(id)?.name, `Missing item ${id}`);
    assets.add(item(id).icon);
  }
  for (const id of ingameFixture.spells.flat()) {
    assert.ok(spell(id)?.name, `Missing spell ${id}`);
    assets.add(spell(id).icon);
  }
  for (const id of ingameFixture.runes) {
    assert.ok(rune(id)?.name, `Missing rune ${id}`);
    assets.add(rune(id).icon);
  }
  for (const asset of assets) {
    assert.ok(asset.startsWith(`/ddragon/${catalog.version}/`));
    assert.ok(statSync(resolve("public", `.${asset}`)).size > 100, asset);
  }
  assert.equal(champion("MonkeyKing").name, "Wukong");
});

test("official LoL typography assets used by Studio and overlay are present", () => {
  for (const name of [
    "BeaufortforLOL-Regular.otf",
    "BeaufortforLOL-Bold.otf",
    "BeaufortforLOL-Heavy.otf",
    "Spiegel-Regular.otf",
    "Spiegel-SemiBold.otf",
    "Spiegel-Bold.otf",
  ]) {
    assert.ok(statSync(resolve("public", "fonts", "riot", name)).size > 50_000, name);
  }
});
