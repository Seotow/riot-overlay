import { createConnection } from "node:net";
import { request } from "node:http";
import { mkdir, writeFile } from "node:fs/promises";
import { resolve } from "node:path";
import { WebSocket } from "ws";
import { getLocal } from "../../server/diagnostics";
import { CollectorRuntime } from "../supervisor/supervisor";
import { object } from "../adapter/normalize";
import { inspectBasicFields } from "../validation/basic-fields";

const flags = process.argv.slice(2);
if (
  flags.some((f) => !["--no-inject", "--without-account"].includes(f)) ||
  new Set(flags).size !== flags.length
)
  throw Error("Only --no-inject and --without-account are accepted");
const noInject = flags.includes("--no-inject"),
  withoutAccount = flags.includes("--without-account");
const wait = (ms: number) => new Promise((r) => setTimeout(r, ms));
async function open(port: number): Promise<boolean | null> {
  return new Promise((yes) => {
    const socket = createConnection({ host: "127.0.0.1", port });
    let done = false;
    const end = (v: boolean | null) => {
      if (done) return;
      done = true;
      clearTimeout(timer);
      socket.destroy();
      yes(v);
    };
    const timer = setTimeout(() => end(null), 1000);
    socket.once("connect", () => end(true));
    socket.once("error", (e: NodeJS.ErrnoException) =>
      end(e.code === "ECONNREFUSED" ? false : null),
    );
  });
}
async function collectorStatus(port: number): Promise<Record<string, unknown> | null> {
  return new Promise((yes) => {
    let finished = false;
    const end = (v: Record<string, unknown> | null) => {
      if (finished) return;
      finished = true;
      clearTimeout(timer);
      yes(v);
    };
    const req = request(
      {
        hostname: "127.0.0.1",
        port,
        path: "/api/status",
        method: "GET",
      },
      (res) => {
        let data = "";
        res.on("data", (b) => {
          data += b;
          if (data.length > 65536) {
            end(null);
            req.destroy();
          }
        });
        res.on("end", () => {
          try {
            end(res.statusCode === 200 ? object(JSON.parse(data)) : null);
          } catch {
            end(null);
          }
        });
        res.on("error", () => end(null));
      },
    );
    const timer = setTimeout(() => {
      end(null);
      req.destroy();
    }, 1500);
    req.on("error", () => end(null));
    req.end();
  });
}
const startedAt = new Date().toISOString();
const report = {
  kind: "collector-basic-fields-probe",
  startedAt,
  mapNumber: null as number | null,
  outcome: "not-run",
  attachedExisting: false,
  startedOwned: false,
  autoInject: null as boolean | null,
  withoutAccount,
  producerPresentBefore: null as boolean | null,
  authentication: null as {
    state: string;
    signingAttempts: number;
    signedResponses: number;
    featureCount: number;
  } | null,
  nativeFrames: 0,
  validFrames: 0,
  maxHeroes: 0,
  coverageMax: { health: 0, resource: 0, currentGold: 0, totalGold: 0 },
  changedHeroes: { health: 0, resource: 0, currentGold: 0, totalGold: 0 },
  rawRecorded: false,
  sanitizedRowsPrinted: false,
  credentialsExported: false,
  valueSemanticsVerified: false,
};
let runtime: CollectorRuntime | undefined, socket: WebSocket | undefined;
let latest: ReturnType<typeof inspectBasicFields> = null;
const previous = new Map<
  string,
  NonNullable<ReturnType<typeof inspectBasicFields>>["rows"][number]
>();
const changed = {
  health: new Set<string>(),
  resource: new Set<string>(),
  currentGold: new Set<string>(),
  totalGold: new Set<string>(),
};
try {
  const [stats, active, events] = await Promise.all([
    getLocal("stats", "/liveclientdata/gamestats"),
    getLocal("active", "/liveclientdata/activeplayername/"),
    getLocal("events", "/liveclientdata/eventdata"),
  ]);
  const game = object(stats.data),
    end = object(events.data).Events;
  if (stats.probe.status !== "ok") report.outcome = "game-api-unavailable";
  else if (
    active.probe.status !== "ok" ||
    typeof active.data !== "string" ||
    !["unknown", "spectator"].includes(active.data.toLowerCase())
  )
    report.outcome = "spectator-unverified";
  else if (!Array.isArray(end) || end.some((e) => object(e).EventName === "GameEnd"))
    report.outcome = "end-state-unavailable-or-ended";
  else if (
    typeof game.gameTime !== "number" ||
    !Number.isFinite(game.gameTime) ||
    game.gameTime < 0
  )
    report.outcome = "game-clock-unavailable";
  else if ((await open(58869)) !== false) report.outcome = "LB-listener-not-confirmed-closed";
  else {
    report.mapNumber =
      typeof game.mapNumber === "number" && Number.isInteger(game.mapNumber)
        ? game.mapNumber
        : null;
    const portExisting = await open(18799);
    let port = 18799;
    if (portExisting === true && withoutAccount)
      report.outcome = "existing-host-would-confound-accountless-test";
    else if (
      portExisting === true &&
      object((await collectorStatus(18799))?.collector).source === "lblib"
    )
      report.attachedExisting = true;
    else if (portExisting !== false) report.outcome = "existing-collector-unverified";
    else {
      const native = await open(4998);
      report.producerPresentBefore = native;
      if (native === null) report.outcome = "native-listener-unverified";
      else if (noInject && !native) report.outcome = "existing-producer-unavailable";
      else {
        port = 18814;
        report.autoInject = !native && !noInject;
        runtime = new CollectorRuntime({
          port,
          autoInject: report.autoInject,
          withoutAccount,
        });
        await runtime.setEnabled(true);
        report.startedOwned = runtime.snapshot().owned;
        if (!report.startedOwned) report.outcome = "collector-launch-failed";
      }
    }
    if (report.attachedExisting || report.startedOwned) {
      const deadline = Date.now() + 30000;
      while (Date.now() < deadline) {
        if (!socket) {
          const ws = new WebSocket(`ws://127.0.0.1:${port}/ws`, {
            handshakeTimeout: 1500,
            maxPayload: 16 * 1024 * 1024,
            followRedirects: false,
          });
          socket = ws;
          ws.on("error", () => {});
          ws.on("close", () => {
            if (socket === ws) socket = undefined;
          });
          ws.on("message", (bytes) => {
            try {
              const raw = JSON.parse(bytes.toString());
              if (object(raw).type !== "snapshot") return;
              report.nativeFrames++;
              const result = inspectBasicFields(raw, Date.now());
              if (!result) return;
              latest = result;
              report.validFrames++;
              report.maxHeroes = Math.max(report.maxHeroes, result.rows.length);
              for (const row of result.rows) {
                const key = `${row.row}:${row.team}:${row.champion}`,
                  before = previous.get(key);
                if (before)
                  for (const field of ["health", "resource", "currentGold", "totalGold"] as const)
                    if (
                      before[field] !== null &&
                      row[field] !== null &&
                      JSON.stringify(before[field]) !== JSON.stringify(row[field])
                    ) {
                      changed[field].add(key);
                      report.changedHeroes[field] = changed[field].size;
                    }
                previous.set(key, row);
              }
              for (const key of ["health", "resource", "currentGold", "totalGold"] as const)
                report.coverageMax[key] = Math.max(report.coverageMax[key], result.coverage[key]);
            } catch {}
          });
        }
        await wait(250);
      }
      report.outcome = latest ? "native-fields-observed" : "no-valid-native-fields";
      const auth = object((await collectorStatus(port))?.authentication);
      if (
        typeof auth.state === "string" &&
        [auth.signingAttempts, auth.signedResponses].every(
          (n) => typeof n === "number" && Number.isInteger(n) && n >= 0,
        ) &&
        Array.isArray(auth.features)
      ) {
        report.authentication = {
          state: auth.state,
          signingAttempts: auth.signingAttempts as number,
          signedResponses: auth.signedResponses as number,
          featureCount: auth.features.length,
        };
      }
      if (
        withoutAccount &&
        (!report.authentication ||
          report.authentication.state !== "not-configured" ||
          report.authentication.signedResponses !== 0 ||
          report.authentication.featureCount !== 0)
      )
        report.outcome = "accountless-auth-state-unverified";
    }
  }
} catch {
  report.outcome = "probe-failed";
} finally {
  socket?.terminate();
  await runtime?.stop();
}
if (latest) {
  report.sanitizedRowsPrinted = true;
  const display = latest as NonNullable<ReturnType<typeof inspectBasicFields>>;
  console.log(JSON.stringify({ kind: "sanitized-basic-field-values", ...display }));
}
const folder = resolve("collector/evidence/validation");
await mkdir(folder, { recursive: true });
await writeFile(
  resolve(folder, `basic-fields-${startedAt.replaceAll(":", "-")}.json`),
  JSON.stringify(report, null, 2),
  { flag: "wx" },
);
console.log(JSON.stringify(report));
if (report.outcome !== "native-fields-observed") process.exitCode = 2;
