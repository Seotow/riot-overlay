import test from "node:test";
import assert from "node:assert/strict";
import { createElement } from "react";
import { renderToStaticMarkup } from "react-dom/server";
import { applyCommand, createState } from "../shared/mock";
import { commandSchema, themeSchema } from "../shared/schema";
import { LiveOverlay } from "../src/overlay/LiveOverlay";

test("in-game opacity survives theme roundtrip with bounds and old-theme compatibility", () => {
  const old = createState().theme;
  assert.equal(themeSchema.parse(old).ingamePanelOpacity, undefined);
  const theme = themeSchema.parse({ ...old, ingamePanelOpacity: 0.72 });
  assert.equal(themeSchema.parse(JSON.parse(JSON.stringify(theme))).ingamePanelOpacity, 0.72);
  assert.equal(themeSchema.safeParse({ ...old, ingamePanelOpacity: 1 }).success, false);
});

test("operational views change display only, not telemetry, game clock or theme", () => {
  const before = createState();
  for (const view of ["normal", "gold", "levels", "runes", "minimal"] as const) {
    const after = applyCommand(
      before,
      commandSchema.parse({
        type: "broadcast",
        value: { view, inhibitors: "ORDER" },
      }),
    );
    assert.equal(after.broadcast?.view, view);
    assert.deepEqual(after.players, before.players);
    assert.deepEqual(after.events, before.events);
    assert.deepEqual(after.theme, before.theme);
    assert.equal(after.gameTime, before.gameTime);
    assert.equal(after.rehearsal, undefined);
  }
  assert.equal(before.broadcast, undefined);
  assert.equal(
    commandSchema.safeParse({
      type: "broadcast",
      value: { view: "damage", inhibitors: "both" },
    }).success,
    false,
  );
});
test("new production configuration defaults to no-camera while older imported themes keep their choice", () => {
  assert.equal(createState().theme.playerCameras, false);
  const old = { ...createState().theme };
  delete old.playerCameras;
  assert.equal(themeSchema.parse(old).playerCameras, undefined);
  assert.equal(themeSchema.parse({ ...old, playerCameras: true }).playerCameras, true);
});
test("old themes remain compatible; logos only accept bounded raster data, scores integral", () => {
  const theme = createState().theme;
  assert.deepEqual(themeSchema.parse(theme), theme);
  assert.equal(themeSchema.parse({ ...theme, playerCameras: false }).playerCameras, false);
  assert.equal(themeSchema.safeParse({ ...theme, playerCameras: "no" }).success, false);
  for (const logo of [
    "javascript:alert(1)",
    "https://example.com/logo.png",
    "data:image/svg+xml;base64,AAAA",
  ]) {
    assert.equal(themeSchema.safeParse({ ...theme, blueLogo: logo }).success, false);
  }
  assert.equal(themeSchema.safeParse({ ...theme, blueScore: 1.5 }).success, false);
  const updated = themeSchema.parse({
    ...theme,
    blueName: "LOCAL TEAM",
    blueLogo: "data:image/png;base64,AAAA",
    blueScore: 2,
    redScore: 1,
    seriesGames: 3,
  });
  assert.equal(updated.blueScore, 2);
});
test("live scoreboard uses configured teams, series score and optional logo, never guessed KT branding", () => {
  const theme = {
    ...createState().theme,
    blueName: "KT",
    redName: "LOCAL RED",
    tournament: "SMALL CUP",
    blueScore: 2,
    seriesGames: 3,
  };
  const html = renderToStaticMarkup(
    createElement(LiveOverlay, { theme, frame: null, now: Date.now() }),
  );
  assert.doesNotMatch(html, /SMALL CUP/); // caption span is a per-team description, not the tournament
  assert.match(html, /LOCAL RED/);
  assert.equal((html.match(/class="won"/g) ?? []).length, 2);
  assert.doesNotMatch(html, /mark-kt|mark-t1/);
});
