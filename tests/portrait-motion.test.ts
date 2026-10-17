import test from "node:test";
import assert from "node:assert/strict";
import {
  portraitCueDuration,
  PORTRAIT_ENTER_MS,
  PORTRAIT_EXIT_MS,
} from "../shared/portrait-motion";
test("simple holds item/level cues750ms, full holds3000ms, entrance/exit stay unchanged", () => {
  assert.equal(portraitCueDuration(true), 1590);
  assert.equal(portraitCueDuration(false), 3840);
  assert.equal(portraitCueDuration(true) - PORTRAIT_ENTER_MS - PORTRAIT_EXIT_MS, 750);
});
