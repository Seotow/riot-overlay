import test from "node:test";
import assert from "node:assert/strict";
import { readFileSync } from "node:fs";
import { createHash } from "node:crypto";
import { objectiveIconUrl } from "../shared/objective-icons";
test("Riot objective family uses pinned PNG masks, including all pits and generic unknown dragon", () => {
  const m = JSON.parse(
    readFileSync(
      "public/broadcast/objectives/riot-16.20/provenance.json",
      "utf8",
    ),
  );
  assert.equal(m.assets.length, 11);
  assert.equal(m.version, "16.20");
  for (const a of m.assets) {
    if (!["baron", "grubs"].includes(a.id))
      assert.equal(
        objectiveIconUrl(a.id),
        "/" + a.path.replace(/^public\//, ""),
      );
    assert.ok(a.source.startsWith("https://raw.communitydragon.org/16.20/"));
    const b = readFileSync(a.path);
    assert.equal(b.subarray(0, 8).toString("hex"), "89504e470d0a1a0a");
    assert.equal(createHash("sha256").update(b).digest("hex"), a.sha256);
  }
  assert.equal(objectiveIconUrl("DRAGON_EARTH"), objectiveIconUrl("earth"));
  assert.equal(objectiveIconUrl("GRUB"), objectiveIconUrl("grubs"));
});
test("mixed selection preserves user Baron SVG exactly and restores previous grubs", () => {
  assert.equal(
    objectiveIconUrl("baron"),
    "/broadcast/objectives/mixed/baron.svg",
  );
  assert.equal(objectiveIconUrl("grubs"), "/broadcast/objectives/grubs.svg");
  assert.deepEqual(
    readFileSync("public/broadcast/objectives/mixed/baron.svg"),
    readFileSync("baron.svg"),
  );
  const m = JSON.parse(
    readFileSync("public/broadcast/objectives/mixed/provenance.json", "utf8"),
  );
  for (const a of m.assets)
    assert.equal(
      createHash("sha256").update(readFileSync(a.path)).digest("hex"),
      a.sha256,
    );
});
