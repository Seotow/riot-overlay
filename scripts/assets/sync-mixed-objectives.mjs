import { readFile, writeFile, mkdir } from "node:fs/promises";
import { createHash } from "node:crypto";
const root = "public/broadcast/objectives/mixed";
await mkdir(root, { recursive: true });
const baron = await readFile(`${root}/baron.svg`);
if (/<script|<foreignObject|\bon\w+\s*=|(?:href|src)\s*=\s*["']https?:/i.test(baron.toString()))
  throw Error("Unsupported active/external SVG content");
const entries = [
  {
    id: "baron",
    path: `${root}/baron.svg`,
    source: "User-provided Baron SVG, retained without modification",
  },
  {
    id: "grubs",
    path: "public/broadcast/objectives/grubs.svg",
    source: "Previous overlay foreground mask from BlueBottle PNG; original retained",
  },
  {
    id: "elder",
    path: "public/broadcast/objectives/riot-16.20/elder.png",
    source: "Riot spectator atlas16.20, retained glyph; cyan measured from user reference",
    color: "#1ee4de",
  },
];
for (const e of entries)
  e.sha256 = createHash("sha256")
    .update(await readFile(e.path))
    .digest("hex");
await writeFile(
  `${root}/provenance.json`,
  JSON.stringify(
    {
      notice:
        "Mixed asset selection requested by user. Other objectives retain their pinned Riot16.20 PNGs. Underlying artwork rights remain with their owners.",
      assets: entries,
    },
    null,
    2,
  ) + "\n",
);
console.log("Mixed objective assets ready; canonical Baron SVG unchanged");
