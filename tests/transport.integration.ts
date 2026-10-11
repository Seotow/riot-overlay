import { WebSocket } from "ws";
import assert from "node:assert/strict";
const origin = process.env.OVERLAY_TEST_URL || "http://127.0.0.1:4310";
function connect(role: string) {
  const ws = new WebSocket(`${origin.replace(/^http/, "ws")}/ws?role=${role}`, {
    origin,
  });
  const snapshot = next(ws);
  return { ws, snapshot };
}
function next(ws: WebSocket) {
  return new Promise<any>((resolve, reject) => {
    const timeout = setTimeout(() => reject(Error("No snapshot")), 3000);
    const listener = (raw: import("ws").RawData) => {
      const message = JSON.parse(raw.toString());
      if (message.type === "observer") return;
      clearTimeout(timeout);
      ws.off("message", listener);
      resolve(message);
    };
    ws.on("message", listener);
  });
}
const sc = connect("studio");
const studio = sc.ws;
const first = await sc.snapshot;
const oc = connect("overlay");
const overlay = oc.ws;
await oc.snapshot;
const a = next(studio),
  b = next(overlay);
studio.send(JSON.stringify({ type: "event", value: "kill" }));
const [sa, sb] = await Promise.all([a, b]);
assert.equal(sa.state.revision, sb.state.revision);
assert.equal(sa.state.blueKills, first.state.blueKills + 1);
const rejected = next(overlay);
overlay.send(JSON.stringify({ type: "reset" }));
assert.equal((await rejected).type, "error");
const reset = next(studio);
studio.send(JSON.stringify({ type: "reset" }));
await reset;
studio.close();
overlay.close();
console.log(
  "PASS: shared snapshots, kill propagation, read-only overlay and reset",
);
