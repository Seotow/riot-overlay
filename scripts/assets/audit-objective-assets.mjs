// Read-only source research; downloads candidates only under ignored QA artifacts.
import { createRequire } from "node:module";
import { mkdir, writeFile } from "node:fs/promises";
import { resolve } from "node:path";
const sharp = createRequire(import.meta.url)(
  resolve(process.env.OVERLAY_BROWSER_PACKAGES, "sharp"),
);
const root = ".npm-cache/visual-audit/objective-candidates";
await mkdir(root, { recursive: true });
const candidates = [
  ["spectator-atlas", "game/assets/ux/spectator/esportsneutraltimersatlas.png"],
  ["timer-atlas", "game/assets/ux/scoreboard/neutraltimersatlas.png"],
  ...[
    "baronnashor",
    "riftherald",
    "dragon",
    "elderdrake",
    "chemtechdrake",
    "hextechdrake",
    "clouddrake",
    "infernaldrake",
    "mountaindrake",
    "oceandrake",
  ].map((n) => [n, `game/assets/ux/scoreboard/_${n}.png`]),
  ["minimap-grub", "game/assets/ux/minimap/icons/grub.png"],
  ["match-grub", "plugins/rcp-fe-lol-match-history/global/default/right_icons_grub.png"],
  ["match-elements", "plugins/rcp-fe-lol-match-history/global/default/elemental-dragons.png"],
];
const composite = [];
let index = 0;
for (const [name, path] of candidates) {
  const url = `https://raw.communitydragon.org/16.20/${path}`,
    r = await fetch(url);
  if (!r.ok) throw Error(`${r.status}: ${url}`);
  const bytes = Buffer.from(await r.arrayBuffer());
  await writeFile(`${root}/${name}.png`, bytes);
  const m = await sharp(bytes).metadata();
  console.log(JSON.stringify({ name, url, width: m.width, height: m.height }));
  const image = await sharp(bytes).resize(170, 150, { fit: "inside" }).png().toBuffer();
  const im = await sharp(image).metadata();
  const label = Buffer.from(
    `<svg width="200" height="30"><text x="6" y="20" fill="white" font-size="13">${name}</text></svg>`,
  );
  const x = (index % 5) * 200,
    y = Math.floor(index / 5) * 190;
  composite.push(
    { input: label, left: x, top: y },
    { input: image, left: x + Math.floor((200 - im.width) / 2), top: y + 32 },
  );
  index++;
}
await sharp({
  create: {
    width: 1000,
    height: Math.ceil(index / 5) * 190,
    channels: 4,
    background: "#252b30",
  },
})
  .composite(composite)
  .png()
  .toFile(`${root}/contact.png`);
