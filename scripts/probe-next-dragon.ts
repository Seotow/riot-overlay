// Diagnostic only: owned temporary collector, no Studio commands, no replay writes.
import { CollectorRuntime } from "../Collector/runtime/supervisor";
import { getLocal } from "../server/diagnostics";
import { WebSocket } from "ws";
const runtime = new CollectorRuntime({ port: 18814, withoutAccount: true });
const object = (v: any) => (v && typeof v === "object" ? v : {});
let socket: WebSocket | undefined;
try {
  const playback = await getLocal("playback", "/replay/playback");
  console.log(JSON.stringify({ playback: playback.data }));
  await runtime.setEnabled(true);
  console.log(JSON.stringify({ runtime: runtime.snapshot() }));
  // Process ownership is not HTTP readiness. Do not lose the one WS attempt.
  for (let attempt = 0; attempt < 100; attempt++) {
    try {
      const response = await fetch("http://127.0.0.1:18814/api/status");
      if (response.ok) break;
    } catch {}
    await new Promise((r) => setTimeout(r, 200));
  }
  const frames: any[] = [],
    messageTypes = new Set<string>();
  await new Promise<void>((resolve) => {
    const deadline = setTimeout(resolve, 25000);
    socket = new WebSocket("ws://127.0.0.1:18814/ws");
    socket.on("error", () => {});
    socket.on("message", (bytes) => {
      const raw = JSON.parse(bytes.toString());
      messageTypes.add(String(raw.type));
      if (raw.type !== "snapshot") return;
      const d = object(raw.data);
      if (typeof d.gameTime !== "number") return;
      const matches: any[] = [];
      const walk = (v: any, path: string, depth: number) => {
        if (depth > 8 || matches.length >= 70) return;
        if (typeof v === "string" && /dragon|drake/i.test(v))
          matches.push({ path, value: v });
        else if (v && typeof v === "object")
          for (const [k, x] of Object.entries(v)) {
            if (
              /dragon|drake|spawn|camp|timer/i.test(k) &&
              (!x || typeof x !== "object")
            )
              matches.push({ path: path + "." + k, value: x });
            walk(x, path + "." + k, depth + 1);
          }
      };
      walk(d, "data", 0);
      frames.push({
        time: d.gameTime,
        keys: Object.keys(d),
        matches,
        dragonIndicators: (d.particleEmitters ?? [])
          .map((p: any) => p.info?.name)
          .filter(
            (n: any) => typeof n === "string" && /dragon|drake|elder/i.test(n),
          ),
        minionTypes: [
          ...new Set((d.minions ?? []).map((x: any) => x.common?.identifier)),
        ],
        gameEvents: d.gameEvents,
      });
      if (frames.length >= 3) {
        clearTimeout(deadline);
        resolve();
      }
    });
  });
  console.log(JSON.stringify({ frames, messageTypes: [...messageTypes] }));
  const status = await (
    await fetch("http://127.0.0.1:18814/api/status")
  ).json();
  console.log(
    JSON.stringify({
      hostKeys: Object.keys(status),
      collector: status.collector,
      native: status.native,
      replay: status.replay,
    }),
  );
  const events = await getLocal("events", "/liveclientdata/eventdata");
  console.log(
    JSON.stringify({
      riotEvents: object(events.data).Events?.filter((x: any) =>
        /Dragon|GameStart/.test(x.EventName),
      ),
    }),
  );
} finally {
  socket?.close();
  await runtime.stop();
}
