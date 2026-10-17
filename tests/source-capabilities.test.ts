import assert from "node:assert/strict";
import test from "node:test";
import { researchBoundary, sourceCandidates } from "../shared/source-capabilities";

test("source catalog keeps active and proposed routes distinct", () => {
  assert.equal(sourceCandidates.filter((source) => source.stage === "active").length, 1);
  assert.equal(sourceCandidates.find((source) => source.id === "riot-local")?.stage, "active");
  assert.equal(sourceCandidates.find((source) => source.id === "screen-capture")?.stage, "planned");
  assert.equal(
    sourceCandidates.find((source) => source.id === "overwolf")?.coverage.includes("đủ 10 người"),
    true,
  );
});

test("research boundary excludes Vanguard-risk collection", () => {
  const excluded = researchBoundary.excluded.join(" ").toLowerCase();
  assert.match(excluded, /bộ nhớ/);
  assert.match(excluded, /inject/);
  assert.match(excluded, /vanguard/);
});
