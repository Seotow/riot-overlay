import { createReadStream } from "node:fs";
import { createGunzip } from "node:zlib";
import { createInterface } from "node:readline";
const lines = createInterface({
  input: createReadStream("data/captures/2026-10-16T12-43-43-938Z/collector-native.ndjson.gz").pipe(
    createGunzip(),
  ),
});
let first = true;
const statuses = new Map<number, { n: number; respawning: number }>();
for await (const line of lines) {
  const d = JSON.parse(line).message?.data;
  if (!d?.heroes) continue;
  if (first) {
    const h = d.heroes[0];
    console.log(
      JSON.stringify(
        {
          experience: h.experience,
          item: h.items.find((i: any) => i.slot === 8),
          turret: d.turrets[0],
          inhib: d.barracksDampeners[0],
          misc: d.misc,
        },
        null,
        2,
      ),
    );
    first = false;
  }
  for (const e of d.gameEvents?.heroDieEvents ?? []) {
    const killer = d.heroes.find((h: any) => h.info.networkId === e.killerNetworkId);
    if (!killer || e.gameTime > d.gameTime)
      console.log(
        JSON.stringify({ unmappedHeroDeath: e, clock: d.gameTime, knownKiller: !!killer }),
      );
  }
  for (const h of d.heroes) {
    const s = statuses.get(h.common.status) ?? { n: 0, respawning: 0 };
    s.n++;
    if (h.respawnTime > 0) s.respawning++;
    statuses.set(h.common.status, s);
  }
}
console.log(JSON.stringify([...statuses]));
