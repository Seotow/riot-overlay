import test from "node:test";
import assert from "node:assert/strict";
import { createElement } from "react";
import { renderToStaticMarkup } from "react-dom/server";
import { InhibitorTimers } from "../src/overlay/InhibitorTimers";
import { createState } from "../shared/mock";
import type { IngameSample } from "../shared/observer";
import {
  BARON_BUFF_SECONDS,
  ELDER_BUFF_SECONDS,
  INHIBITOR_RESPAWN_SECONDS,
} from "../shared/game-rules";

test("inhibitor panel selects one team at a time, prioritizing the nearest respawn", () => {
  const sample = {
    inhibitors: {
      value: [
        { team: "CHAOS", lane: "mid", destroyedAt: 100, respawnsAt: 400 },
        { team: "ORDER", lane: "top", destroyedAt: 80, respawnsAt: 380 },
      ],
    },
  } as IngameSample;
  const render = (time: number | null, team?: "ORDER" | "CHAOS") =>
    renderToStaticMarkup(
      createElement(InhibitorTimers, {
        sample,
        theme: createState().theme,
        time,
        team,
      }),
    );
  const both = render(120);
  assert.equal((both.match(/data-lane=/g) ?? []).length, 3);
  assert.equal((both.match(/<time>/g) ?? []).length, 1);
  assert.ok(!both.includes('data-team="CHAOS"'));
  assert.ok(both.includes("4:20"));
  assert.equal((both.match(/>---</g) ?? []).length, 2);
  assert.equal((render(400).match(/<time>/g) ?? []).length, 0);
  assert.equal(render(400), "");
  assert.equal((render(null).match(/<time>/g) ?? []).length, 0);
  const blue = render(120, "ORDER"),
    red = render(120, "CHAOS");
  assert.equal((blue.match(/data-lane=/g) ?? []).length, 3);
  assert.ok(!blue.includes('data-team="CHAOS"'));
  assert.ok(!red.includes('data-team="ORDER"'));
});
test("default objective durations are shared game-clock constants", () => {
  assert.deepEqual(
    [INHIBITOR_RESPAWN_SECONDS, BARON_BUFF_SECONDS, ELDER_BUFF_SECONDS],
    [300, 180, 150],
  );
});
