import { mkdir, writeFile } from "node:fs/promises";
// OFL font used as a measured substitute, not claimed as Riot's original font.
const root = "public/fonts/broadcast";
await mkdir(root, { recursive: true });
for (const file of ["Anton-Regular.ttf", "OFL.txt"]) {
  const response = await fetch(
    `https://raw.githubusercontent.com/google/fonts/main/ofl/anton/${file}`,
    { signal: AbortSignal.timeout(20000) },
  );
  if (!response.ok) throw Error(`Font download HTTP ${response.status}`);
  const bytes = Buffer.from(await response.arrayBuffer());
  if (file.endsWith(".ttf") && bytes.readUInt32BE(0) !== 0x00010000)
    throw Error("Invalid TrueType font");
  await writeFile(`${root}/${file}`, bytes);
}
console.log("Anton font and OFL license downloaded");
