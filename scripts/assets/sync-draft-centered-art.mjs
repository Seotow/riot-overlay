import { createRequire } from "node:module";
import { resolve } from "node:path";
import { mkdir, readFile, writeFile } from "node:fs/promises";
import { createHash } from "node:crypto";
const packages = process.env.OVERLAY_BROWSER_PACKAGES;
if (!packages) throw Error("Set OVERLAY_BROWSER_PACKAGES to the installed sharp package directory");
const sharp = createRequire(import.meta.url)(resolve(packages, "sharp"));
const file = "shared/generated/draft-catalog.json";
const catalog = JSON.parse(await readFile(file, "utf8"));
const root = `public/ddragon/${catalog.version}/splash-centered`;
const cache = ".npm-cache/draft-centered-source";
const base = "https://raw.communitydragon.org/15.20/plugins/rcp-be-lol-game-data/global/default";
await mkdir(root, { recursive: true });
await mkdir(cache, { recursive: true });
const hash = (b) => createHash("sha256").update(b).digest("hex");
const cached = async (url, path) => {
  try {
    return await readFile(path);
  } catch {
    const response = await fetch(url);
    if (!response.ok) throw Error(`${response.status}: ${url}`);
    const body = Buffer.from(await response.arrayBuffer());
    await writeFile(path, body);
    return body;
  }
};
let index = 0;
const entries = Object.values(catalog.champions),
  provenance = {};
await Promise.all(
  Array.from({ length: 6 }, async () => {
    while (index < entries.length) {
      const c = entries[index++];
      const metadataUrl = `${base}/v1/champions/${c.key}.json`;
      const metadata = JSON.parse(await cached(metadataUrl, `${cache}/${c.id}.json`));
      const skin = metadata.skins.find((s) => s.id === Number(c.key) * 1000) ?? metadata.skins[0];
      if (!skin?.splashPath?.startsWith("/lol-game-data/assets/"))
        throw Error(`Missing centered art: ${c.id}`);
      const url = base + "/" + skin.splashPath.replace("/lol-game-data/assets/", "").toLowerCase();
      const input = await cached(url, `${cache}/${c.id}.jpg`);
      const output = await sharp(input)
        .resize({
          width: 800,
          height: 480,
          fit: "inside",
          withoutEnlargement: true,
        })
        .webp({ quality: 82 })
        .toBuffer();
      await writeFile(`${root}/${c.id}_0.webp`, output);
      c.splash = `/ddragon/${catalog.version}/splash-centered/${c.id}_0.webp`;
      provenance[c.id] = {
        metadataUrl,
        url,
        kind: "Riot centered splash via CommunityDragon 15.20",
        inputSha256: hash(input),
        outputSha256: hash(output),
        bytes: output.length,
      };
    }
  }),
);
await writeFile(`${root}/provenance.json`, JSON.stringify(provenance, null, 2) + "\n");
await writeFile(file, JSON.stringify(catalog, null, 2) + "\n");
console.log(
  `PASS: ${entries.length} centered WebP splashes, ${Object.values(provenance).reduce((n, p) => n + p.bytes, 0)} bytes; baseline unchanged`,
);
