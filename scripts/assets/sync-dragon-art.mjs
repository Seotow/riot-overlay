import { mkdir, writeFile } from "node:fs/promises";
import { createHash } from "node:crypto";
import { createRequire } from "node:module";
import { resolve } from "node:path";
const require = createRequire(import.meta.url);
const packages = process.env.OVERLAY_BROWSER_PACKAGES;
const sharp = require(packages ? resolve(packages, "sharp") : "sharp");
const version = "7_10_0";
const choices = [
  ["water", "set8", "08IO012", "Ocean Drake", "creature"],
  ["air", "set8", "08DE025", "Cloud Drake", "creature"],
  ["earth", "set5", "05DE015", "Mountain Drake", "creature"],
  ["chemtech", "set8", "08PZ028", "Chemtech Drake", "creature"],
  ["fire", null, null, "Infernal Drake", "static-render"],
  ["hextech", null, null, "Preseason Key Art 2022", "creature"],
];
const root = "public/broadcast/artwork/riot-dragons";
// Offline, deterministic removal of the mirror's edge-connected white matte.
// Preserve enclosed white highlights; never run pixel processing in the widget.
async function removeWhiteMatte(bytes) {
  const { data, info } = await sharp(bytes)
    .ensureAlpha()
    .raw()
    .toBuffer({ resolveWithObject: true });
  const total = info.width * info.height;
  const seen = new Uint8Array(total);
  const queue = new Uint32Array(total);
  let head = 0,
    tail = 0;
  const visit = (index) => {
    if (seen[index]) return;
    seen[index] = 1;
    const pixel = index * 4;
    if (data[pixel] < 248 || data[pixel + 1] < 248 || data[pixel + 2] < 248) return;
    data[pixel + 3] = 0;
    queue[tail++] = index;
  };
  for (let x = 0; x < info.width; x++) {
    visit(x);
    visit(total - info.width + x);
  }
  for (let y = 0; y < info.height; y++) {
    visit(y * info.width);
    visit((y + 1) * info.width - 1);
  }
  while (head < tail) {
    const index = queue[head++],
      x = index % info.width;
    if (x > 0) visit(index - 1);
    if (x < info.width - 1) visit(index + 1);
    if (index >= info.width) visit(index - info.width);
    if (index + info.width < total) visit(index + info.width);
  }
  return sharp(data, {
    raw: { width: info.width, height: info.height, channels: 4 },
  });
}
await mkdir(root, { recursive: true });
const assets = [];
for (const [element, set, code, name, kind] of choices) {
  const source =
    element === "fire"
      ? "https://cdn.sanity.io/images/ccckgjf9/production/3e27876ae60714a31a2a804bba901526a99eef1f-1263x550.png"
      : element === "hextech"
        ? "https://cmsassets.rgpub.io/sanity/images/dsfx7636/news_live/4d0a23800ce31ab8c9d44851c8b9e950c3428e22-1920x1080.jpg"
        : `https://dd.b.pvp.net/${version}/${set}/en_us/img/cards/${code}-full.png`;
  const response = await fetch(source, { signal: AbortSignal.timeout(20000) });
  if (!response.ok) throw Error(`${code}: ${response.status}`);
  const bytes = Buffer.from(await response.arrayBuffer());
  const metadata = await sharp(bytes).metadata();
  if (!["png", "jpeg"].includes(metadata.format)) throw Error("Invalid source image");
  const originalPath = `${element}.source.${metadata.format === "jpeg" ? "jpg" : "png"}`;
  await writeFile(`${root}/${originalPath}`, bytes);
  const pipeline = element === "fire" ? await removeWhiteMatte(bytes) : sharp(bytes);
  const optimized = await pipeline
    .resize({
      width: 1600,
      height: 900,
      fit: "inside",
      withoutEnlargement: true,
    })
    .webp({ quality: 85, effort: 5 })
    .toBuffer();
  await writeFile(`${root}/${element}.webp`, optimized);
  assets.push({
    element,
    code,
    name,
    kind,
    source,
    page:
      element === "fire"
        ? "https://dignitas.gg/articles/an-in-depth-overview-of-all-seven-dragons-league-of-legends-season-13"
        : element === "hextech"
          ? "https://www.leagueoflegends.com/en-us/news/dev/quick-gameplay-thoughts-1-14-preseason-2022/"
          : "https://developer.riotgames.com/docs/lor",
    originalPath: `/broadcast/artwork/riot-dragons/${originalPath}`,
    originalSha256: createHash("sha256").update(bytes).digest("hex"),
    path: `/broadcast/artwork/riot-dragons/${element}.webp`,
    sha256: createHash("sha256").update(optimized).digest("hex"),
    sourceBytes: bytes.length,
    bytes: optimized.length,
    transform:
      element === "fire"
        ? "edge-connected white matte removed offline; resize and WebP"
        : "resize and WebP",
  });
}
await writeFile(
  `${root}/provenance.json`,
  JSON.stringify(
    {
      version,
      source: "Riot LoR and LoL artwork; Infernal static render hosted by Dignitas",
      docs: "https://developer.riotgames.com/docs/lor",
      notice:
        "Not the exact Worlds broadcast pack. Five creature illustrations; Infernal is a pre-rendered raster image, not a 2D painting. All runtime assets are static optimized WebP; no 3D renderer or AI artwork.",
      assets,
    },
    null,
    2,
  ) + "\n",
);
console.log(
  JSON.stringify(
    assets.map(({ element, sourceBytes, bytes }) => ({
      element,
      sourceBytes,
      bytes,
    })),
  ),
);
