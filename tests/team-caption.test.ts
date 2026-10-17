import test from "node:test";
import assert from "node:assert/strict";
import { createElement } from "react";
import { renderToStaticMarkup } from "react-dom/server";
import { LiveOverlay } from "../src/overlay/LiveOverlay";
import { themeSchema, defaultTheme } from "../shared/schema";
import { swapTeamSides } from "../shared/match-config";

test("optional team descriptions round trip and follow teams when swapping sides", () => {
  const theme = themeSchema.parse({ ...defaultTheme, blueDescription: " LCK #1 ", redDescription: "VCS #2" });
  assert.equal(theme.blueDescription, "LCK #1");
  assert.equal(themeSchema.parse(JSON.parse(JSON.stringify(theme))).redDescription, "VCS #2");
  assert.equal(swapTeamSides(theme).blueDescription, "VCS #2");
  assert.equal(swapTeamSides(theme).redDescription, "LCK #1");
  assert.ok(themeSchema.safeParse(defaultTheme).success);
  assert.equal(themeSchema.safeParse({ ...theme, blueDescription: "x".repeat(41) }).success, false);
});

test("scoreboard shows five-character names and per-team description, never tournament fallback", () => {
  const theme = { ...defaultTheme, blueName: "ABCDE", redName: "VWXYZ", tournament: "NOT A TEAM RANK", blueDescription: "LCK #1", redDescription: "" };
  const html = renderToStaticMarkup(createElement(LiveOverlay, { theme, frame: null, now: Date.now() }));
  const header = html.match(/<header[^]*?<\/header>/)?.[0] ?? "";
  assert.match(header, /team-caption has-description[^]*?<b>ABCDE<\/b><span>LCK #1<\/span>/);
  assert.match(header, /team-caption name-only[^]*?<b>VWXYZ<\/b><\/div>/);
  assert.doesNotMatch(header, /NOT A TEAM RANK/);
});
