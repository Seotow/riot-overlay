import test from "node:test";
import assert from "node:assert/strict";
import { createElement } from "react";
import { renderToStaticMarkup } from "react-dom/server";
import { DraftOverlay } from "../src/overlay/DraftOverlay";
import { emptyDraft } from "../shared/draft";
import { defaultTheme } from "../shared/schema";

const render = (playerNames: string[] | undefined, names: string[]) =>
  renderToStaticMarkup(
    createElement(DraftOverlay, {
      theme: { ...defaultTheme, playerNames },
      draft: { ...emptyDraft(), names },
      now: 0,
    }),
  );
const names = (html: string) =>
  [...html.matchAll(/class="vertical-player">([^<]*)</g)].map((m) => m[1]);

test("draft overlay shows names typed in the config and falls back to the client names", () => {
  const real = Array.from({ length: 10 }, (_, i) => `Real${i}`);
  const typed = Array.from({ length: 10 }, (_, i) => (i === 2 || i === 7 ? `Typed${i}` : ""));
  assert.deepEqual(names(render(undefined, real)), real);
  const shown = names(render(typed, real));
  assert.equal(shown[2], "Typed2");
  assert.equal(shown[7], "Typed7");
  assert.equal(shown[0], "Real0");
});
