import test from "node:test";
import assert from "node:assert/strict";
import { createElement } from "react";
import { renderToStaticMarkup } from "react-dom/server";
import { catalog } from "../shared/assets";
import {
  draftSchema,
  draftTurns,
  draftSlots,
  emptyDraft,
  lockDraft,
  undoDraft,
} from "../shared/draft";
import { applyCommand, createState } from "../shared/mock";
import { commandSchema, themeSchema } from "../shared/schema";
import { DraftOverlay } from "../src/overlay/DraftOverlay";
import { draftCatalog } from "../shared/draft-assets";
import { statSync } from "node:fs";

test("complete draft catalog has local portraits and icons with the pinned baseline", () => {
  assert.equal(draftCatalog.version, "15.20.1");
  assert.equal(Object.keys(draftCatalog.champions).length, 171);
  for (const c of Object.values(draftCatalog.champions))
    for (const path of [c.icon, c.portrait, c.splash])
      assert.ok(statSync(`public${path}`).size > 1000, path);
});

test("complete tournament draft locks 10 bans and 10 picks, rejects duplicates and undoes last action", () => {
  let d = emptyDraft();
  const ids = Object.keys(catalog.champions).slice(0, 20);
  for (let i = 0; i < 20; i++) d = lockDraft({ ...d, hover: ids[i] });
  assert.equal(d.step, 20);
  for (const side of [0, 1])
    for (const kind of ["ban", "pick"] as const)
      assert.equal(draftSlots(d, side, kind).filter(Boolean).length, 5);
  assert.equal(lockDraft({ ...d, hover: ids[20] }).step, 20);
  const previous = undoDraft(d);
  assert.equal(previous.step, 19);
  assert.equal(previous.actions[19], null);
  assert.throws(() => lockDraft({ ...previous, hover: ids[0] }));
  assert.equal(d.actions[19], ids[19]);
  assert.equal(draftTurns[12][0], 1);
  assert.equal(draftTurns[16][0], 1);
});
test("draft command keeps in-game data and theme, swaps picks by slot and validates imports", () => {
  const before = createState();
  assert.equal(themeSchema.parse(before.theme).draftLayout, undefined);
  assert.equal(themeSchema.parse({ ...before.theme, draftLayout: "simple" }).draftLayout, "simple");
  assert.equal(themeSchema.safeParse({ ...before.theme, draftLayout: "unknown" }).success, false);
  const d = emptyDraft();
  d.step = 7;
  d.actions[6] = "Annie";
  d.order[0] = [1, 0, 2, 3, 4];
  const after = applyCommand(before, commandSchema.parse({ type: "draftState", value: d }));
  assert.deepEqual(after.players, before.players);
  assert.deepEqual(after.theme, before.theme);
  assert.equal(draftSlots(after.draft!, 0, "pick")[1], "Annie");
  assert.equal(
    draftSchema.safeParse({ ...d, order: [[0, 0, 2, 3, 4], d.order[1]] }).success,
    false,
  );
  assert.equal(draftSchema.safeParse({ ...d, hover: "UnknownChampion" }).success, false);
});
test("draft renderer has empty truthful slots, shows hover then lock, no fixture stats or reference assets", () => {
  const theme = createState().theme;
  let d = emptyDraft();
  const render = () =>
    renderToStaticMarkup(createElement(DraftOverlay, { theme, draft: d, now: 1000 }));
  let html = render();
  assert.equal((html.match(/class="ref-pick /g) || []).length, 10);
  assert.doesNotMatch(html, /pick-portrait|references\/|82.3%|COACH:/);
  d.step = 6;
  d.hover = "Annie";
  d.deadline = 31000;
  html = render();
  assert.match(html, /is-hover/);
  assert.match(html, /alt="Annie"/);
  assert.match(html, /<b>30<\/b>/);
  d = lockDraft(d);
  html = render();
  assert.match(html, /is-picked/);
  assert.doesNotMatch(html, /<b>30<\/b>/);
  const expired = renderToStaticMarkup(
    createElement(DraftOverlay, {
      theme,
      draft: { ...d, deadline: 100 },
      now: 1000,
    }),
  );
  assert.match(expired, /<b>0<\/b>/);
  assert.equal(d.step, 7);
});
