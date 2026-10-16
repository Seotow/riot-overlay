import test from "node:test";
import assert from "node:assert/strict";
import { createElement } from "react";
import { renderToStaticMarkup } from "react-dom/server";
import {
  postgameSchema,
  samplePostgame,
  goldSegments,
} from "../shared/postgame";
import { applyCommand, createState } from "../shared/mock";
import { commandSchema } from "../shared/schema";
import { PostgameOverlay } from "../src/overlay/PostgameOverlay";

test("postgame sample is coherent, lane ordered, and explicitly not live", () => {
  const d = samplePostgame();
  assert.equal(d.source, "sample");
  assert.equal(d.teams[0].kills, d.teams[1].deaths);
  assert.equal(d.teams[1].kills, d.teams[0].deaths);
  assert.equal(
    d.goldHistory.at(-1)!.delta,
    d.teams[0].gold! - d.teams[1].gold!,
  );
  assert.equal(d.goldHistory.at(-1)!.at, d.duration);
  assert.equal(d.teams.flatMap((t) => t.players).length, 10);
});
test("postgame validates null vs zero, time ordering, bounds, asset ids and sample provenance", () => {
  const d = samplePostgame();
  d.teams[0].elders = null;
  d.teams[1].elders = 0;
  assert.equal(postgameSchema.parse(d).teams[0].elders, null);
  assert.equal(postgameSchema.parse(d).teams[1].elders, 0);
  for (const invalid of [
    { ...d, source: "live" },
    {
      ...d,
      goldHistory: [
        { at: 20, delta: 0 },
        { at: 10, delta: 0 },
      ],
    },
    { ...d, goldHistory: [{ at: 99999, delta: 0 }] },
    { ...d, winner: "unknown" },
  ])
    assert.equal(postgameSchema.safeParse(invalid).success, false);
  d.teams[0].players[0].champion = "NotAChampion";
  assert.equal(postgameSchema.safeParse(d).success, false);
});
test("null gold points break paths instead of interpolating or resetting to zero", () => {
  assert.deepEqual(
    goldSegments([
      { at: 0, delta: 0 },
      { at: 10, delta: null },
      { at: 20, delta: -200 },
    ]),
    [[{ at: 0, delta: 0 }], [{ at: 20, delta: -200 }]],
  );
});
test("postgame commands do not change live/mock gameplay, theme or draft", () => {
  const before = createState();
  const after = applyCommand(
    before,
    commandSchema.parse({ type: "postgameState", value: samplePostgame() }),
  );
  for (const key of [
    "players",
    "theme",
    "draft",
    "scene",
    "gameTime",
    "provider",
  ] as const)
    assert.deepEqual(after[key], before[key]);
  assert.equal(before.postgame, undefined);
  assert.equal(
    applyCommand(after, { type: "postgameState", value: null }).postgame,
    null,
  );
});
test("postgame renders 10 damage players and 10 bans, missing placeholders, no sponsors", () => {
  const d = samplePostgame();
  d.teams[1].players[2].damage = null;
  d.goldHistory[7].delta = null;
  const html = renderToStaticMarkup(
    createElement(PostgameOverlay, { theme: createState().theme, data: d }),
  );
  assert.equal((html.match(/class="pg-champion"/g) ?? []).length, 20);
  assert.equal((html.match(/data-gold-segment/g) ?? []).length, 2);
  assert.match(html, /DỮ LIỆU MẪU/);
  assert.match(html, /—/);
  assert.doesNotMatch(html, /sponsor|powered by|AWS/);
  assert.match(
    renderToStaticMarkup(
      createElement(PostgameOverlay, { theme: createState().theme }),
    ),
    /CHỜ DỮ LIỆU/,
  );
});
