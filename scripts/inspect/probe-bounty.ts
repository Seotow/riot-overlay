// Diagnostic only, read-only: does the native snapshot carry the shutdown bounty of each player?
// Candidates in the native schema: heroes[].goldGivenOnDeath (gold given when that hero dies) and
// gameEvents.heroDieEvents[].goldReward (gold the killer got). Run it during a replay or spectated
// game with a visible bounty badge, then compare the series with what the game shows.
import { writeFile, mkdir } from "node:fs/promises";
import { CollectorRuntime } from "../../collector/supervisor/supervisor";
import { WebSocket } from "ws";

const SECONDS = Number(process.argv[2] ?? 120);
const runtime = new CollectorRuntime({ port: 18816, withoutAccount: true });
const object = (v: any) => (v && typeof v === "object" ? v : {});
let socket: WebSocket | undefined;

type Row = {
  champion: string;
  networkId: number | null;
  kills: number | null;
  deaths: number | null;
  series: [number, number][];
};
try {
  await runtime.setEnabled(true);
  for (let attempt = 0; attempt < 100; attempt++) {
    try {
      if ((await fetch("http://127.0.0.1:18816/api/status")).ok) break;
    } catch {}
    await new Promise((r) => setTimeout(r, 200));
  }
  const heroes = new Map<number, Row>();
  const dieEvents: any[] = [];
  const seenEvents = new Set<string>();
  let snapshots = 0;
  let firstTime: number | null = null;
  let lastTime: number | null = null;
  let hasField = false;
  socket = new WebSocket("ws://127.0.0.1:18816/ws");
  socket.on("error", () => {});
  socket.on("message", (bytes) => {
    const raw = JSON.parse(bytes.toString());
    if (raw.type !== "snapshot") return;
    const d = object(raw.data);
    if (typeof d.gameTime !== "number") return;
    snapshots++;
    firstTime ??= d.gameTime;
    lastTime = d.gameTime;
    (Array.isArray(d.heroes) ? d.heroes : []).forEach((h: any, i: number) => {
      const value = h?.goldGivenOnDeath;
      if (typeof value === "number") hasField = true;
      const row = heroes.get(i) ?? {
        champion: String(h?.common?.identifier ?? "?"),
        networkId: typeof h?.info?.networkId === "number" ? h.info.networkId : null,
        kills: null,
        deaths: null,
        series: [],
      };
      row.kills = typeof h?.kills === "number" ? h.kills : row.kills;
      row.deaths = typeof h?.deaths === "number" ? h.deaths : row.deaths;
      // Only changes are stored, so the series stays small.
      if (typeof value === "number" && row.series.at(-1)?.[1] !== value)
        row.series.push([Math.round(d.gameTime), value]);
      heroes.set(i, row);
    });
    for (const e of object(d.gameEvents).heroDieEvents ?? []) {
      const key = JSON.stringify(e);
      if (seenEvents.has(key)) continue;
      seenEvents.add(key);
      // Names and ids are dropped; only numbers are kept.
      dieEvents.push(
        Object.fromEntries(Object.entries(object(e)).filter(([, v]) => typeof v === "number")),
      );
    }
  });
  await new Promise((r) => setTimeout(r, SECONDS * 1000));
  // Events carry network ids; map them to the hero index (local file, never sent anywhere).
  const indexOf = (id: unknown) => [...heroes.entries()].find(([, r]) => r.networkId === id)?.[0];
  for (const e of dieEvents) {
    e.killerIndex = indexOf(e.killerNetworkId) ?? null;
    e.victimIndex = indexOf(e.victimNetworkId) ?? null;
  }
  const rows = [...heroes.entries()].map(([index, row]) => ({
    index,
    ...row,
    max: Math.max(0, ...row.series.map(([, v]) => v)),
  }));
  const result = {
    snapshots,
    gameTime: [firstTime, lastTime],
    heroGoldGivenOnDeathPresent: hasField,
    heroesWithNonZero: rows.filter((r) => r.max > 0).length,
    heroes: rows,
    heroDieEvents: dieEvents.slice(0, 40),
  };
  await mkdir(".npm-cache/probe", { recursive: true });
  await writeFile(".npm-cache/probe/bounty.json", JSON.stringify(result, null, 1));
  console.log(
    JSON.stringify({
      snapshots,
      gameTime: result.gameTime,
      heroGoldGivenOnDeathPresent: hasField,
      heroesWithNonZero: result.heroesWithNonZero,
      topValues: rows.map((r) => [r.champion, r.max]),
      heroDieEvents: dieEvents.length,
      file: ".npm-cache/probe/bounty.json",
    }),
  );
} finally {
  socket?.close();
  await runtime.stop();
}
