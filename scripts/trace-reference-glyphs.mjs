// Trace only small static overlay glyphs, never HUD panels/data or game pixels.
import { createRequire } from "node:module";
import { resolve } from "node:path";
import { mkdir, writeFile } from "node:fs/promises";
const require = createRequire(import.meta.url),
  sharp = require(resolve(process.env.OVERLAY_BROWSER_PACKAGES, "sharp"));
const root = "public/broadcast/glyphs";
await mkdir(root, { recursive: true });
const glyphs = [
  ["earth", "xếp hạng gold.png", [125, 20, 31, 31], "earth"],
  ["role-top", "ingame new.png", [526, 79, 23, 24], "blue"],
  ["role-jungle", "ingame new.png", [563, 79, 23, 24], "blue"],
  ["role-mid", "ingame new.png", [600, 79, 23, 24], "blue"],
  ["role-bot", "ingame new.png", [637, 79, 23, 24], "blue"],
  ["role-support", "ingame new.png", [674, 79, 23, 24], "blue"],
  ["baron", "ingame new.png", [16, 18, 32, 34], "purple"],
  ["air", "ingame new.png", [125, 20, 31, 31], "mint"],
  ["fire", "ingame new.png", [1011, 78, 25, 25], "orange"],
  ["water", "Linh hồn rồng.png", [856, 77, 26, 26], "mint"],
  ["tower", "ingame new.png", [716, 26, 26, 31], "neutral"],
  ["gold", "ingame new.png", [782, 29, 28, 25], "neutral"],
];
const entries = [];
const previews = [];
for (const [name, file, [left, top, width, height], color] of glyphs) {
  const { data } = await sharp(resolve("images", file))
    .extract({ left, top, width, height })
    .removeAlpha()
    .raw()
    .toBuffer({ resolveWithObject: true });
  let path = "",
    count = 0;
  const present = (i) => {
    const r = data[i * 3],
      g = data[i * 3 + 1],
      b = data[i * 3 + 2];
    return color === "blue"
      ? b > 65 && b > r * 1.3 && b > g * 1.2
      : color === "earth"
        ? r > 135 && g > 100 && g > b * 1.2
        : color === "purple"
          ? b > 130 && r > 90 && b > g * 1.3
          : color === "mint"
            ? g > 120 && b > 85 && g > r * 1.25
            : color === "orange"
              ? r > 135 && r > g * 1.35 && g > b * 1.1
              : Math.min(r, g, b) > 110 &&
                Math.max(r, g, b) - Math.min(r, g, b) < 70;
  };
  for (let y = 0; y < height; y++)
    for (let x = 0; x < width;) {
      if (!present(y * width + x)) {
        x++;
        continue;
      }
      const start = x;
      while (x < width && present(y * width + x)) {
        x++;
        count++;
      }
      path += `M${start} ${y}h${x - start}v1H${start}z`;
    }
  if (count < 20 || count > width * height * 0.8)
    throw Error(`Unsafe glyph mask ${name}: ${count}`);
  const svg = `<svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 ${width} ${height}"><path fill="white" d="${path}"/></svg>`;
  await writeFile(`${root}/${name}.svg`, svg);
  entries.push({
    name,
    file,
    rect: [left, top, width, height],
    color,
    foregroundPixels: count,
  });
  previews.push({
    input: await sharp(Buffer.from(svg))
      .resize(96, 96, { fit: "contain" })
      .png()
      .toBuffer(),
    left: previews.length * 100,
    top: 0,
  });
}
await sharp({
  create: {
    width: glyphs.length * 100,
    height: 100,
    channels: 4,
    background: "#101820",
  },
})
  .composite(previews)
  .png()
  .toFile(".npm-cache/visual-audit/glyphs.png");
await writeFile(
  `${root}/provenance.json`,
  JSON.stringify(
    {
      source:
        "User supplied 1920x1080 broadcast references; static glyph masks only. Review rights before distributing.",
      glyphs: entries,
    },
    null,
    2,
  ),
);
console.log(JSON.stringify(entries));
