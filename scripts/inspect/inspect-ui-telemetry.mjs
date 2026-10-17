import { createReadStream } from "node:fs";
import { createInterface } from "node:readline";
const path = "data/captures/lb-2026-10-11T09-07-37-947Z/leaguebroadcast-ws.ndjson";
const keys = new Set(),
  abilities = new Set(),
  timers = new Map(),
  examples = [];
const messageTypes = new Map();
const variants = new Map();
let count = 0;
for await (const line of createInterface({ input: createReadStream(path), crlfDelay: Infinity })) {
  const entry = JSON.parse(line);
  const msg =
    typeof entry.data === "string"
      ? JSON.parse(entry.data)
      : (entry.message ?? entry.data ?? entry);
  const s = msg.state;
  const messageShape = JSON.stringify(Object.keys(msg));
  messageTypes.set(messageShape, (messageTypes.get(messageShape) ?? 0) + 1);
  if (!s?.tabs) continue;
  count++;
  Object.keys(s).forEach((k) => keys.add(k));
  for (const team of ["Order", "Chaos"])
    for (const p of s.tabs[team]?.players ?? []) {
      for (const a of p.abilities ?? [])
        if (["D", "F"].includes(a.slot)) {
          abilities.add(a.identifier);
          if (/Smite|Upgrade/.test(a.identifier) && !variants.has(a.identifier))
            variants.set(a.identifier, { assets: a.assets, identifier: a.identifier });
        }
      if (examples.length < 2 || (s.gameTime > 700 && examples.length < 3))
        examples.push({
          time: s.gameTime,
          playerKeys: Object.keys(p),
          xp: p.experience,
          level: p.level,
        });
    }
  for (const [k, v] of Object.entries(s))
    if (/baron|dragon.*timer|powerplay/i.test(k)) {
      const filtered = JSON.stringify(v, (key, value) =>
        /name|url|icon|identifier|player/i.test(key) ? undefined : value,
      );
      const shape = k + ":" + JSON.stringify(Object.keys(v ?? {})) + ":" + v?.type;
      if (!timers.has(shape))
        timers.set(shape, { time: s.gameTime, field: k, data: JSON.parse(filtered) });
    }
}
console.log(
  JSON.stringify(
    {
      count,
      messageTypes: [...messageTypes],
      stateKeys: [...keys],
      abilities: [...abilities],
      variants: [...variants.values()],
      examples,
      timers: [...timers.values()],
    },
    null,
    2,
  ),
);
