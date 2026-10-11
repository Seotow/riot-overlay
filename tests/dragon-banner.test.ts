import test from "node:test";
import assert from "node:assert/strict";
import { createElement } from "react";
import { renderToStaticMarkup } from "react-dom/server";
import { DragonBanner } from "../src/overlay/DragonBanner";
import { DRAGON_SOUL_COPY, dragonSoulCopy } from "../shared/dragon-soul-copy";
test("drake banner has name and two matching icons, elemental theme and no team kill text", () => {
  const html = renderToStaticMarkup(
    createElement(DragonBanner, { type: "earth" }),
  );
  assert.match(html, /MOUNTAIN DRAKE/);
  assert.equal((html.match(/class="dragon-banner-icon"/g) ?? []).length, 2);
  assert.match(html, /#bd8f5d/);
  assert.doesNotMatch(html, /ĐÃ HẠ|KT|T1/);
});
test("all six Souls display quantified rules, conditions and complete tooltip, not stack buffs", () => {
  for (const [type, copy] of Object.entries(DRAGON_SOUL_COPY)) {
    const html = renderToStaticMarkup(
      createElement(DragonBanner, { type, soul: true }),
    );
    assert.equal((html.match(/class="dragon-banner-icon"/g) ?? []).length, 1);
    assert.ok(html.includes('class="soul-effect-copy"'));
    assert.ok(html.includes('title="'));
    assert.ok(html.includes('aria-label="'));
    assert.ok(copy.lines.every((line) => /\d/.test(line)));
    assert.ok(copy.detail.length > 100);
    assert.doesNotMatch(html, /Heal 2% missing health every 5 seconds/);
  }
  assert.match(
    DRAGON_SOUL_COPY.earth.detail,
    /220 \+ 16% bonus AD \+ 12% AP \+ 12% bonus health/,
  );
  assert.match(
    DRAGON_SOUL_COPY.water.detail,
    /26% bonus AD \+ 17% AP \+ 7% bonus health/,
  );
  assert.match(DRAGON_SOUL_COPY.chemtech.detail, /13%/);
  for (const key of ["elder", "toString", "__proto__", ""])
    assert.equal(dragonSoulCopy(key), undefined);
  const unknown = renderToStaticMarkup(
    createElement(DragonBanner, { type: "elder", soul: true }),
  );
  assert.match(unknown, /DRAGON SOUL ACQUIRED/);
  assert.doesNotMatch(unknown, /soul-effect-copy|title=/);
});
