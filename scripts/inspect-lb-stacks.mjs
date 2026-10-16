// Read-only local evidence survey. Print schema paths/counts only, never player identity.
import { readdir } from "node:fs/promises";
import { createReadStream } from "node:fs";
import { createInterface } from "node:readline";
import { resolve } from "node:path";
const root = resolve("data/captures");
const targets = { 75: "Nasus", 901: "Smolder", 45: "Veigar" };
const result = {
  files: 0,
  stateFrames: 0,
  champions: {},
  candidatePaths: {},
  abilityKeys: [],
  playerKeys: [],
};
const abilityKeys = new Set(),
  playerKeys = new Set();
function survey(value, path = "", depth = 0) {
  if (depth > 8 || !value || typeof value !== "object") return;
  for (const [key, child] of Object.entries(value)) {
    if (/authorization|token|password|secret|name|address|path|url/i.test(key))
      continue;
    const p = path ? `${path}.${Array.isArray(value) ? "[]" : key}` : key;
    if (/stack|siphon|phenomenal|dragonpractice|buff/i.test(key)) {
      const type = Array.isArray(child)
        ? "array"
        : child === null
          ? "null"
          : typeof child;
      result.candidatePaths[p + ":" + type] =
        (result.candidatePaths[p + ":" + type] ?? 0) + 1;
    }
    survey(child, p, depth + 1);
  }
}
for (const entry of await readdir(root, { withFileTypes: true })) {
  if (!entry.isDirectory() || !/^(lb-)?\d{4}-/.test(entry.name)) continue;
  for (const file of await readdir(resolve(root, entry.name))) {
    if (!/\.ndjson$/.test(file) || !/leaguebroadcast/i.test(file)) continue;
    result.files++;
    const lines = createInterface({
      input: createReadStream(resolve(root, entry.name, file)),
      crlfDelay: Infinity,
    });
    let count = 0;
    for await (const line of lines) {
      let message;
      try {
        message = JSON.parse(line).message;
      } catch {
        continue;
      }
      if (message?.type !== "ingame-state-update") continue;
      result.stateFrames++;
      count++;
      const state = message.state;
      for (const side of [0, 1]) {
        const rows = state?.scoreboardBottom?.teams?.[side]?.players ?? [];
        const details =
          state?.tabs?.[side === 0 ? "Order" : "Chaos"]?.players ?? [];
        for (let i = 0; i < rows.length; i++) {
          const id = rows[i]?.champion?.id;
          const detail = details[i];
          if (targets[id]) {
            const name = targets[id];
            result.champions[name] ??= {
              frames: 0,
              min: null,
              max: null,
              examples: [],
            };
            result.champions[name].frames++;
            if (typeof detail?.stacksData === "number") {
              const value = detail.stacksData,
                summary = result.champions[name];
              summary.min =
                summary.min === null ? value : Math.min(summary.min, value);
              summary.max =
                summary.max === null ? value : Math.max(summary.max, value);
              if (
                summary.examples.length < 12 &&
                !summary.examples.some((e) => e.value === value)
              )
                summary.examples.push({ gameTime: state.gameTime, value });
            }
            if (detail)
              for (const key of Object.keys(detail)) playerKeys.add(key);
          }
          if (count === 1 || count % 100 === 0 || targets[id]) {
            survey(detail, "tabs.players");
            survey(rows[i], "scoreboard.players");
            for (const ability of detail?.abilities ?? [])
              for (const key of Object.keys(ability)) abilityKeys.add(key);
          }
        }
      }
    }
  }
}
result.abilityKeys = [...abilityKeys].sort();
result.playerKeys = [...playerKeys]
  .filter((k) => !/name|url|token|password/i.test(k))
  .sort();
console.log(JSON.stringify(result, null, 2));
