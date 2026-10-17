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
  assert.equal(themeSchema.safeParse({ ...s.theme, version: 2 }).success, false);
  assert.equal(
    themeSchema.safeParse({ ...s.theme, blue: "url(https://example.com)" }).success,
    false,
  );
  assert.equal(commandSchema.safeParse({ type: "seek", value: -1 }).success, false);
});
test("seeking clears transient events and resets demo timers deterministically", () => {
  const s = applyCommand(applyCommand(createState(), { type: "event", value: "kill" }), {
    type: "seek",
    value: 600,
  });
  assert.equal(s.events.length, 0);
  assert.equal(s.objectives[0].endsAt, 728);
});
test("provider selection is validated and survives a demo reset", () => {
  const selected = applyCommand(createState(), {
    type: "provider",
    value: "leaguebroadcast",
  });
  assert.equal(selected.provider, "leaguebroadcast");
  assert.equal(applyCommand(selected, { type: "reset" }).provider, "leaguebroadcast");
  assert.equal(
    commandSchema.safeParse({ type: "provider", value: "memory-reader" }).success,
    false,
  );
});

test("mock fixture remains a complete ten-player tournament sample", () => {
  const state = createState();
  assert.equal(state.players.length, 10);
  assert.deepEqual(
    state.players.map((player) => player.role),
    ["TOP", "JGL", "MID", "BOT", "SUP", "TOP", "JGL", "MID", "BOT", "SUP"],
  );
  assert.ok(state.players.every((player) => player.items.length === 6));
  assert.ok(state.players.every((player) => player.spells.length === 2));
  assert.ok(state.players.every((player) => player.gold !== null && player.gold > 0));
  assert.equal(themeSchema.safeParse(state.theme).success, true);
});

test("every mock control produces an explicit, deterministic state change", () => {
  const base = createState();
  const level = applyCommand(base, { type: "event", value: "level" });
  assert.equal(level.players[2].level, base.players[2].level + 1);
  const objective = applyCommand(base, { type: "event", value: "objective" });
  assert.equal(objective.objectives[0].name, "DRAGON");
  assert.match(objective.events[0].text, /RỒNG/);
  const draft = applyCommand(base, { type: "event", value: "draft" });
  assert.equal(draft.draftStep, (base.draftStep + 1) % 11);
  const advantage = applyCommand(base, { type: "scenario", value: "advantage" });
  assert.ok(
    advantage.players
      .slice(0, 5)
      .every((player, index) => player.gold! > advantage.players[index + 5].gold!),
  );
});
