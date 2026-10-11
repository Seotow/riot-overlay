import test from "node:test";
import assert from "node:assert/strict";
import { runeSummary } from "../shared/rune-summary";
import { liveCatalog } from "../shared/live-assets";
import { readFileSync, existsSync } from "node:fs";
import data from "../shared/generated/rune-paths.json";
test("rune summary uses keystone and secondary TREE, never a secondary minor rune or shard", () => {
  const result = runeSummary(
    [8112, 8143, 8140, 8106, 8017, 8009, 5005, 5008, 5011],
    8112,
  );
  assert.equal(result.keystone?.name, "Electrocute");
  assert.equal(result.secondary?.name, "Precision");
  assert.match(result.secondary!.icon, /\/8000\.png$/);
  assert.equal(
    runeSummary([8437, 8446, 8444, 8451, 8224, 8237, 5008, 5001, 5001], 8437)
      .secondary?.name,
    "Sorcery",
  );
});
test("missing, unknown or conflicting secondary rune IDs remain unavailable", () => {
  for (const perks of [
    null,
    [],
    [8112, 8143, 8140, 8106],
    [8112, 8143, 8140, 8106, 999999, 8009],
    [8112, 8143, 8140, 8106, 8237, 8009],
    [8112, 8143, 8140, 8106, 8139, 8106],
  ])
    assert.equal(runeSummary(perks, 8112).secondary, undefined);
  assert.equal(runeSummary([], 5005).keystone, undefined);
});
test("rune membership and keystone classification match pinned cached Riot metadata", () => {
  assert.equal(data.version, liveCatalog.version);
  const trees = JSON.parse(
    readFileSync(
      `public/ddragon/${data.version}/data/runesReforged.json`,
      "utf8",
    ),
  );
  const paths: Record<number, { treeId: number; keystone: boolean }> =
    data.paths;
  for (const tree of trees) {
    assert.ok(existsSync("public" + liveCatalog.runes[tree.id].icon));
    tree.slots.forEach((slot: any, index: number) =>
      slot.runes.forEach((r: any) =>
        assert.deepEqual(paths[r.id], {
          treeId: tree.id,
          keystone: index === 0,
        }),
      ),
    );
  }
});
