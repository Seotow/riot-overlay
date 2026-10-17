// Diagnostic only, read-only: does the native snapshot carry hero world positions, and what does the
// Replay API report for the camera? Also samples replay clock vs snapshot clock to estimate latency.
import { writeFile, mkdir } from "node:fs/promises";
import { CollectorRuntime } from "../../collector/supervisor/supervisor";
import { getLocal } from "../../server/diagnostics";
import { WebSocket } from "ws";

const SECONDS = Number(process.argv[2] ?? 20);
const runtime = new CollectorRuntime({ port: 18815, withoutAccount: true });
const object = (v: any) => (v && typeof v === "object" ? v : {});
let socket: WebSocket | undefined;

// Key paths of one hero with their value type, so a position field shows up by name or shape.
const shape = (v: any, path: string, out: string[], depth = 0) => {
  if (depth > 5 || out.length > 400) return;
  if (v && typeof v === "object")
    for (const [k, x] of Object.entries(v)) shape(x, `${path}.${k}`, out, depth + 1);
  else out.push(`${path}=${typeof v === "number" ? Math.round(v * 100) / 100 : typeof v}`);
};

try {
  await runtime.setEnabled(true);
  for (let attempt = 0; attempt < 100; attempt++) {
    try {
      if ((await fetch("http://127.0.0.1:18815/api/status")).ok) break;
    } catch {}
    await new Promise((r) => setTimeout(r, 200));
  }
  const heroSamples: any[] = [];
  const clocks: { wall: number; snapshot: number | null; replay: number | null; speed?: number }[] =
    [];
  let lastSnapshotTime: number | null = null;
  socket = new WebSocket("ws://127.0.0.1:18815/ws");
  socket.on("error", () => {});
  socket.on("message", (bytes) => {
    const raw = JSON.parse(bytes.toString());
    if (raw.type !== "snapshot") return;
    const d = object(raw.data);
    if (typeof d.gameTime !== "number") return;
    lastSnapshotTime = d.gameTime;
    if (heroSamples.length < 3 && Array.isArray(d.heroes) && d.heroes[0]) {
      const out: string[] = [];
      shape(d.heroes[0], "hero", out);
      heroSamples.push({ gameTime: d.gameTime, topKeys: Object.keys(d), paths: out });
    }
  });
  const renderSamples: any[] = [];
  const end = Date.now() + SECONDS * 1000;
  while (Date.now() < end) {
    const wall = Date.now();
    const [playback, render] = await Promise.all([
      getLocal("playback", "/replay/playback").catch(() => null),
      getLocal("render", "/replay/render").catch(() => null),
    ]);
    const p = object(playback?.data);
    clocks.push({
      wall,
      snapshot: lastSnapshotTime,
      replay: typeof p.time === "number" ? p.time : null,
      speed: p.speed,
    });
    if (renderSamples.length < 3) renderSamples.push(render?.data ?? null);
    await new Promise((r) => setTimeout(r, 250));
  }
  const deltas = clocks
    .filter((c) => c.snapshot !== null && c.replay !== null)
    .map((c) => (c.snapshot as number) - (c.replay as number));
  const mean = deltas.length ? deltas.reduce((a, b) => a + b, 0) / deltas.length : null;
  const result = {
    heroHasPositionLikeKey: heroSamples.some((s) =>
      s.paths.some((p: string) => /pos|location|coord|\.x=|\.z=|\.y=/i.test(p)),
    ),
    heroSamples,
    renderSamples,
    // snapshot clock minus replay clock, in seconds; the spread shows the jitter of the pipeline.
    clockDelta: {
      samples: deltas.length,
      mean,
      min: deltas.length ? Math.min(...deltas) : null,
      max: deltas.length ? Math.max(...deltas) : null,
    },
    clocks: clocks.slice(0, 40),
  };
  await mkdir(".npm-cache/probe", { recursive: true });
  await writeFile(".npm-cache/probe/tracking.json", JSON.stringify(result, null, 1));
  console.log(
    JSON.stringify({
      heroHasPositionLikeKey: result.heroHasPositionLikeKey,
      heroSamples: heroSamples.length,
      renderKeys: Object.keys(object(renderSamples[0])),
      clockDelta: result.clockDelta,
      file: ".npm-cache/probe/tracking.json",
    }),
  );
} finally {
  socket?.close();
  await runtime.stop();
}
