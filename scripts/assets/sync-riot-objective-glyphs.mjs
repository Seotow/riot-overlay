// Offline-build PNG masks from pinned Riot game textures; no runtime tracing/GPU effect.
import { createRequire } from "node:module";
import { mkdir, writeFile } from "node:fs/promises";
import { createHash } from "node:crypto";
import { resolve } from "node:path";
const sharp = createRequire(import.meta.url)(
  resolve(process.env.OVERLAY_BROWSER_PACKAGES, "sharp"),
);
const root = "public/broadcast/objectives/riot-16.20",
  base = "https://raw.communitydragon.org/16.20/";
await mkdir(root, { recursive: true });
const atlas = "game/assets/ux/spectator/esportsneutraltimersatlas.png";
const specs = [
  ["earth", atlas, [0, 56, 42, 36]],
  ["water", atlas, [43, 56, 42, 36]],
  ["fire", atlas, [86, 56, 42, 36]],
  ["baron", atlas, [0, 92, 42, 36]],
  ["elder", atlas, [43, 92, 42, 36]],
  ["air", atlas, [86, 92, 42, 36]],
  ["hextech", "game/assets/ux/scoreboard/_hextechdrake.png"],
  ["chemtech", "game/assets/ux/scoreboard/_chemtechdrake.png"],
  ["herald", "game/assets/ux/scoreboard/_riftherald.png"],
  [
    "grubs",
    "plugins/rcp-fe-lol-match-history/global/default/right_icons_grub.png",
    [0, 400, 80, 80],
  ],
  ["dragon", "game/assets/ux/scoreboard/_dragon.png"],
];
const cache = new Map(),
  assets = [];
for (const [id, source, crop] of specs) {
  let bytes = cache.get(source);
  if (!bytes) {
    const r = await fetch(base + source);
    if (!r.ok) throw Error(`${r.status} ${source}`);
    bytes = Buffer.from(await r.arrayBuffer());
    cache.set(source, bytes);
  }
  let image = sharp(bytes);
  if (crop) {
    const [left, top, width, height] = crop;
    image = image.extract({ left, top, width, height });
  }
  const { data, info } = await image.ensureAlpha().raw().toBuffer({ resolveWithObject: true });
  // Remove dark atlas backplate/shadows, preserve soft foreground edges.
  for (let p = 0; p < data.length; p += 4) {
    const light = Math.max(data[p], data[p + 1], data[p + 2]);
    data[p + 3] = Math.round(data[p + 3] * Math.max(0, Math.min(1, (light - 48) / 64)));
    data[p] = data[p + 1] = data[p + 2] = 255;
  }
  const mask = await sharp(data, {
    raw: { width: info.width, height: info.height, channels: 4 },
  })
    .trim({ background: "#00000000", threshold: 1 })
    .resize(64, 64, { fit: "contain", background: "#00000000" })
    .png()
    .toBuffer();
  const path = `${root}/${id}.png`;
  await writeFile(path, mask);
  assets.push({
    id,
    path,
    source: base + source,
    sourceSha256: createHash("sha256").update(bytes).digest("hex"),
    crop: crop ?? null,
    sha256: createHash("sha256").update(mask).digest("hex"),
  });
}
await writeFile(
  `${root}/provenance.json`,
  JSON.stringify(
    {
      version: "16.20",
      notice:
        "Riot game artwork mirrored by CommunityDragon. Cropped and soft foreground alpha extracted once for CSS tint masks; original shapes, no AI or runtime vectorization. Verify redistribution rights before publishing.",
      processing:
        "alpha *= clamp((max(R,G,B)-48)/64); white RGB; trim transparent padding; fit64x64",
      assets,
    },
    null,
    2,
  ) + "\n",
);
console.log(`Saved ${assets.length} pinned Riot objective PNG masks`);
