import test from "node:test";
import assert from "node:assert/strict";
import { createElement } from "react";
import { renderToStaticMarkup } from "react-dom/server";
import { buffTimeFraction, BuffTimeProgress } from "../src/overlay/BuffTimeProgress";
import { objectiveVisual } from "../shared/ui-metrics";
test("buff progress uses remaining game-clock seconds with fixed Baron180/Elder150 windows", () => {
  assert.equal(buffTimeFraction(280, 100, 180), 1);
  assert.equal(buffTimeFraction(280, 190, 180), 0.5);
  assert.equal(buffTimeFraction(250, 175, 150), 0.5);
  assert.equal(buffTimeFraction(250, 300, 150), 0);
  assert.equal(buffTimeFraction(250, 0, 150), 1);
  for (const [end, time, duration] of [
    [null, 10, 150],
    [200, null, 150],
    [200, 10, 0],
    [NaN, 10, 150],
  ] as const)
    assert.equal(buffTimeFraction(end, time, duration), null);
  const html = renderToStaticMarkup(
    createElement(BuffTimeProgress, {
      endAt: 250,
      time: 175,
      duration: 150,
      label: "Elder",
    }),
  );
  assert.match(html, /aria-valuenow="50"/);
  assert.match(html, /width:50%/);
  assert.equal(objectiveVisual("elder")?.color, "#1ee4de");
});
