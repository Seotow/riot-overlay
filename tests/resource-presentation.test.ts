import test from "node:test";
import assert from "node:assert/strict";
import { resourcePresentation } from "../shared/ui-metrics";
test("resource type comes from native enum, energy1 is yellow, mana0 blue, missing not guessed", () => {
  const p = (resourceType: number) =>
    ({ sourceStats: { value: { resourceType } } }) as any;
  assert.deepEqual(resourcePresentation(p(1)), {
    kind: "energy",
    label: "Nội năng",
    color: "#c8d94b",
  });
  assert.equal(resourcePresentation(p(0)).kind, "mana");
  assert.equal(resourcePresentation(p(4)).kind, "fury");
  assert.equal(resourcePresentation(p(11)).kind, "flow");
  assert.equal(resourcePresentation().kind, "unknown");
});
