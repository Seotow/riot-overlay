import { LeagueCollectorSource } from "../../collector/adapter";
let port = 18799,
  duration = 10000;
const args = process.argv.slice(2);
for (let i = 0; i < args.length; i += 2) {
  const value = Number(args[i + 1]);
  if (args[i] === "--port" && Number.isInteger(value) && value >= 1024 && value <= 65535)
    port = value;
  else if (args[i] === "--duration" && Number.isInteger(value) && value >= 1000 && value <= 60000)
    duration = value;
  else throw Error("Supported options: --port 1024..65535 --duration 1000..60000");
}
const source = new LeagueCollectorSource({ port });
const started = Date.now();
let previousSequence = -1,
  observed = 0;
try {
  while (Date.now() - started < duration) {
    source.ensureConnected();
    const frame = source.observe();
    if (frame.status === "observed" && frame.sequence !== previousSequence) observed++;
    previousSequence = frame.sequence;
    await new Promise((resolve) => setTimeout(resolve, 100));
  }
  // Only aggregate diagnostics. No provider payload, credentials or player values.
  console.log(
    JSON.stringify({
      kind: "collector-adapter-inspection",
      framesSampled: observed,
      ...source.snapshot(),
    }),
  );
} finally {
  source.stop();
}
