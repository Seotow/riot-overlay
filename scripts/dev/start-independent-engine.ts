import { startIndependentEngineServer } from "../../server/independent-engine-server";
import { IndependentEngineEvidence } from "../../server/independent-engine-evidence";
import { mkdir, writeFile } from "node:fs/promises";
import { resolve } from "node:path";
const args = process.argv.slice(2);
let port = 4313,
  saveReport = false,
  duration: number | undefined;
for (let i = 0; i < args.length; i++) {
  if (args[i] === "--report") {
    saveReport = true;
    continue;
  }
  const key = args[i],
    value = Number(args[++i]);
  if (!Number.isInteger(value)) throw Error("Expected integer option value");
  if (key === "--port" && value > 0 && value <= 65535) port = value;
  else if (key === "--duration" && value >= 1000 && value <= 180000) duration = value;
  else throw Error("Supported options: --port 1..65535, --duration 1000..180000, --report");
}
if (saveReport && duration === undefined) throw Error("--report requires bounded --duration");
const startedAt = new Date().toISOString();
const evidence = new IndependentEngineEvidence(startedAt);
const service = await startIndependentEngineServer({ port });
const unsubscribe = service.engine.onUpdate(() => {
  if (saveReport) evidence.record(service.engine.snapshot());
});
console.log(
  JSON.stringify({
    engine: "rift-independent",
    port: service.port,
    acquisition: "riot-local-api",
    replacementReady: false,
  }),
);
let stopping = false;
let timer: ReturnType<typeof setTimeout> | undefined;
const stop = async () => {
  if (stopping) return;
  stopping = true;
  clearTimeout(timer);
  unsubscribe();
  const snapshot = service.engine.snapshot();
  // No player values/identities or raw error bodies in console.
  console.log(
    JSON.stringify({
      status: snapshot.status,
      capabilities: snapshot.capabilities,
    }),
  );
  await service.close();
  if (saveReport) {
    const directory = resolve("data/engine-reports");
    await mkdir(directory, { recursive: true });
    const output = resolve(directory, `engine-${startedAt.replaceAll(":", "-")}.json`);
    await writeFile(output, JSON.stringify(evidence.report(), null, 2), {
      flag: "wx",
    });
    console.log(JSON.stringify({ evidenceReport: output }));
  }
};
process.once("SIGINT", () => {
  void stop();
});
process.once("SIGTERM", () => {
  void stop();
});
if (duration !== undefined)
  timer = setTimeout(() => {
    void stop();
  }, duration);
