import test from "node:test";
import assert from "node:assert/strict";
import {
  COLLECTOR_SAMPLE_INTERVAL_MS,
  COLLECTOR_REPLAY_MAX_SAMPLES,
  remainingSampleDelay,
} from "../shared/capture-rules";
test("collector targets half-second samples without accumulating processing drift; four-hour capture fits reader cap", () => {
  assert.equal(COLLECTOR_SAMPLE_INTERVAL_MS, 500);
  assert.equal(remainingSampleDelay(120), 380);
  assert.equal(remainingSampleDelay(700), 0);
  assert.equal(remainingSampleDelay(20, 750), 730);
  assert.ok(
    COLLECTOR_REPLAY_MAX_SAMPLES >= (4 * 60 * 60 * 1000) / COLLECTOR_SAMPLE_INTERVAL_MS + 1,
  );
});
