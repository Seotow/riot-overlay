// Explicit offline projection upgrade. Original recording and theme are read-only.
import { createReadStream } from "node:fs";
import { mkdir, readFile, writeFile } from "node:fs/promises";
import { createGunzip } from "node:zlib";
import { createInterface } from "node:readline";
import { resolve } from "node:path";
import {
  normalizeCollector,
  type NormalizedCollector,
} from "../Collector/adapter/normalize";
import { CollectorGameplay } from "../Collector/adapter/gameplay";
import { ingameSampleSchema } from "../shared/observer";
const original = process.argv[2] ?? "2026-10-16T12-43-43-938Z";
if (!/^\d{4}-\d{2}-\d{2}T\d{2}-\d{2}-\d{2}-\d{3}Z$/.test(original))
  throw Error("Invalid id");
const root = resolve("data/captures", original),
  id = new Date().toISOString().replace(/[:.]/g, "-"),
  out = resolve("data/captures", id);
const originalManifest = JSON.parse(
  await readFile(resolve(root, "manifest.json"), "utf8"),
);
const targets = (
  await readFile(resolve(root, "observer-samples.ndjson"), "utf8")
)
  .trim()
  .split(/\r?\n/)
  .map((l) => JSON.parse(l));
const gameplay = new CollectorGameplay();
let latest: NormalizedCollector | null = null,
  index = 0,
  native = 0;
const records: string[] = [];
function append(target: any) {
  if (!latest) throw Error("No native frame for observer sample");
  const sample = ingameSampleSchema.parse(latest.sample);
  records.push(
    JSON.stringify({
      ...target,
      message: { type: "collector-sample", sample },
    }),
  );
}
const lines = createInterface({
  input: createReadStream(resolve(root, "collector-native.ndjson.gz")).pipe(
    createGunzip(),
  ),
  crlfDelay: Infinity,
});
for await (const line of lines) {
  const r = JSON.parse(line),
    e = r.message;
  if (e?.type !== "snapshot") continue;
  while (
    index < targets.length &&
    Date.parse(targets[index].receivedAt) < Date.parse(r.receivedAt)
  ) {
    append(targets[index++]);
  }
  const normalized = normalizeCollector(e, Date.parse(e.timestamp));
  if (!normalized) throw Error(`Invalid native snapshot ${e.sequence}`);
  latest = gameplay.enrich(e, normalized);
  native++;
}
while (index < targets.length) append(targets[index++]);
await mkdir(out, { recursive: false });
await writeFile(
  resolve(out, "observer-samples.ndjson"),
  records.join("\n") + "\n",
);
const manifest = {
  ...originalManifest,
  id,
  kind: "collector-match-capture",
  state: "stopped",
  derivedFrom: original,
  projectionVersion: 10,
  reprocessedAt: new Date().toISOString(),
  nativeFramesProcessed: native,
  observerFrames: records.length,
  files: ["observer-samples.ndjson"],
  originalFilesUnmodified: true,
  notes:
    "Native-derived CS, quest, death/respawn, exact buffs, cached objective deaths and current dragon spawn indicators/live monster identity. Counts cover observed history only; original raw archives remain in derivedFrom. No reference data substituted.",
};
await writeFile(
  resolve(out, "manifest.json"),
  JSON.stringify(manifest, null, 2) + "\n",
);
const final = latest!.sample;
console.log(
  JSON.stringify(
    {
      id,
      original,
      native,
      frames: records.length,
      teams: final.teams?.map((t) => ({
        team: t.team,
        dragons: t.dragons.value,
        towers: t.towers.value,
      })),
      events: final.events.reduce(
        (a, e) => ({ ...a, [e.kind]: (a[e.kind] ?? 0) + 1 }),
        {} as Record<string, number>,
      ),
      cs: final.players.map((p) => ({
        slot: p.slot,
        cs: p.cs.value,
        quest: p.roleQuest?.value,
        buffs: [p.hasBaron?.value, p.hasElder?.value],
      })),
    },
    null,
    2,
  ),
);
