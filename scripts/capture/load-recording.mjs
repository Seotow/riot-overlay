import { WebSocket } from "ws";
const [id, port = "4310", position = "0"] = process.argv.slice(2);
if (!Number.isFinite(Number(position)) || Number(position) < 0) throw Error("Invalid position");
if (!/^\d{4}-\d{2}-\d{2}T\d{2}-\d{2}-\d{2}-\d{3}Z$/.test(id ?? "") || !/^\d{4,5}$/.test(port))
  throw Error("Expected capture id and loopback port");
const base = `http://127.0.0.1:${port}`,
  ws = new WebSocket(`ws://127.0.0.1:${port}/ws?role=studio`, { origin: base });
let failure;
ws.on("message", (raw) => {
  const m = JSON.parse(raw);
  if (m.type === "error") failure = m.message;
});
await new Promise((yes, no) => {
  ws.once("open", yes);
  ws.once("error", no);
});
try {
  const previous = await (await fetch(base + "/api/providers")).json();
  const generation = previous.recording?.loadGeneration ?? 0;
  ws.send(JSON.stringify({ type: "captureLoad", id }));
  let report;
  for (let i = 0; i < 300; i++) {
    if (failure) throw Error(failure);
    report = await (await fetch(base + "/api/providers")).json();
    if (report.recording?.id === id && (report.recording.loadGeneration ?? 0) > generation) break;
    await new Promise((r) => setTimeout(r, 200));
  }
  if (report.recording?.id !== id || (report.recording.loadGeneration ?? 0) <= generation)
    throw Error("Capture load timeout");
  ws.send(JSON.stringify({ type: "captureControl", positionMs: Number(position), playing: false }));
  await new Promise((r) => setTimeout(r, 700));
  report = await (await fetch(base + "/api/providers")).json();
  console.log(JSON.stringify({ selected: report.selected, recording: report.recording }));
} finally {
  ws.close();
}
