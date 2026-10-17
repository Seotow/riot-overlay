import test from "node:test";
import assert from "node:assert/strict";
import { createElement } from "react";
import { renderToStaticMarkup } from "react-dom/server";
import { readFileSync } from "node:fs";
import { createHash } from "node:crypto";
import { SoulTakeover } from "../src/overlay/SoulTakeover";
import { createState } from "../shared/mock";
import type { ObservedEvent } from "../shared/observer";

const event: ObservedEvent = {
  id: 1,
  kind: "DragonSoul",
  at: 823.48,
  team: "ORDER",
  objectiveType: "water",
};
const theme = {
  ...createState().theme,
  blueName: "BLUE TEST",
  redName: "RED TEST",
};
const render = (e: ObservedEvent) =>
  renderToStaticMarkup(createElement(SoulTakeover, { event: e, theme }));
test("Soul takeover uses event team/type, Riot artwork and no sponsor/stat claims", () => {
  const html = render(event);
  assert.match(html, /BLUE TEST/);
  assert.match(html, /RỒNG NƯỚC/);
  assert.match(html, /data-region="soul-takeover"/);
  assert.match(html, /data-region="soul-description"/);
  assert.match(html, /riot-dragons\/water.webp/);
  assert.doesNotMatch(html, /dragon-soul-v1|soul-hue|hue-rotate/);
  assert.doesNotMatch(html, /mastercard|priceless|sponsor|\/references\//i);
  assert.match(html, /Damage heals 150\+ HP/);
  assert.doesNotMatch(html, /Heal 2% missing health/);
  assert.match(render({ ...event, team: "CHAOS", objectiveType: "fire" }), /RED TEST/);
  assert.match(render({ ...event, team: "CHAOS", objectiveType: "fire" }), /RỒNG LỬA/);
});
test("Soul takeover rejects missing team and non-Soul events; unknown element is neutral", () => {
  assert.equal(render({ ...event, team: undefined }), "");
  assert.equal(render({ ...event, kind: "DragonKill" }), "");
  const unknown = render({
    ...event,
    objectiveType: "toString",
  } as unknown as ObservedEvent);
  assert.match(unknown, /LINH HỒN RỒNG/);
  assert.doesNotMatch(unknown, /undefined|RỒNG NƯỚC/);
});
test("Six distinct Riot artwork files match pinned CDN provenance; no AI fallback", () => {
  const provenance = JSON.parse(
    readFileSync("public/broadcast/artwork/riot-dragons/provenance.json", "utf8"),
  );
  const hashes = new Set<string>();
  for (const type of ["water", "air", "earth", "fire", "hextech", "chemtech"]) {
    const html = render({ ...event, objectiveType: type } as ObservedEvent);
    assert.match(html, new RegExp(`riot-dragons/${type}\\.webp`));
    assert.doesNotMatch(html, /dragon-soul-v1|soul-hue/);
    assert.equal(html.includes("soul-artwork-render"), type === "fire");
    const bytes = readFileSync(`public/broadcast/artwork/riot-dragons/${type}.webp`);
    assert.equal(bytes.subarray(0, 4).toString(), "RIFF");
    assert.equal(bytes.subarray(8, 12).toString(), "WEBP");
    if (type === "fire") {
      assert.equal(bytes.subarray(12, 16).toString(), "VP8X");
      assert.ok(bytes[20] & 0x10, "Infernal must retain transparent background");
    }
    assert.ok(bytes.length < 150_000);
    const hash = createHash("sha256").update(bytes).digest("hex");
    hashes.add(hash);
    const entry = provenance.assets.find((asset: { element: string }) => asset.element === type);
    assert.equal(entry.sha256, hash);
    assert.ok(entry.bytes < entry.sourceBytes);
    assert.equal(entry.kind, type === "fire" ? "static-render" : "creature");
    assert.ok(
      entry.source.startsWith(
        type === "fire"
          ? "https://cdn.sanity.io/"
          : type === "hextech"
            ? "https://cmsassets.rgpub.io/"
            : "https://dd.b.pvp.net/7_10_0/",
      ),
    );
    const original = readFileSync(`public${entry.originalPath}`);
    assert.equal(createHash("sha256").update(original).digest("hex"), entry.originalSha256);
  }
  assert.equal(hashes.size, 6);
  assert.doesNotMatch(
    render({ ...event, objectiveType: undefined }),
    /soul-artwork|dragon-soul-v1/,
  );
});
