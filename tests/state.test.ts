import { test } from "node:test";
import assert from "node:assert/strict";
import { applyCommand, createState, tick } from "../shared/mock";
import { commandSchema, themeSchema } from "../shared/schema";
test("missing gold remains null rather than a fabricated zero", () => {
  const s = applyCommand(createState(), { type: "scenario", value: "missing" });
  assert.equal(s.capabilities.gold, false);
  assert.ok(s.players.every((p) => p.gold === null));
});
test("kill event and scoreboard stay consistent without mutating source", () => {
  const before = createState();
  const after = applyCommand(before, { type: "event", value: "kill" });
  assert.equal(after.blueKills, before.blueKills + 1);
  assert.equal(after.players[2].kills, before.players[2].kills + 1);
  assert.equal(after.players[7].deaths, before.players[7].deaths + 1);
  assert.equal(before.events.length, 0);
  assert.equal(after.events.length, 1);
});
test("pause freezes clock; reset preserves branding and increments revision", () => {
  let s = createState();
  s.theme.tournament = "MY CUP";
  s = applyCommand(s, { type: "event", value: "kill" });
  assert.deepEqual(tick(s), s);
  const reset = applyCommand(s, { type: "reset" });
  assert.equal(reset.theme.tournament, "MY CUP");
  assert.ok(reset.revision > s.revision);
  assert.equal(reset.events.length, 0);
});
test("theme boundary rejects malformed imports and unsafe color values", () => {
  const s = createState();
  assert.equal(
    themeSchema.safeParse({ ...s.theme, version: 2 }).success,
    false,
  );
  assert.equal(
    themeSchema.safeParse({ ...s.theme, blue: "url(https://example.com)" })
      .success,
    false,
  );
  assert.equal(
    commandSchema.safeParse({ type: "seek", value: -1 }).success,
    false,
  );
});
test("seeking clears transient events and resets demo timers deterministically", () => {
  const s = applyCommand(
    applyCommand(createState(), { type: "event", value: "kill" }),
    { type: "seek", value: 600 },
  );
  assert.equal(s.events.length, 0);
  assert.equal(s.objectives[0].endsAt, 728);
});
