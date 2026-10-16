import { spawn } from "node:child_process";
import { createHash } from "node:crypto";
import { readFile, access, mkdir, writeFile } from "node:fs/promises";
import http from "node:http";
import https from "node:https";
import net from "node:net";
import { resolve, dirname } from "node:path";
import { fileURLToPath } from "node:url";
import { LeagueCollectorSource, normalizeCollector } from "../adapter";
import { object } from "../adapter/normalize";
import { normalizeIngame } from "../../server/ingame-adapter";

if (process.argv.length !== 2) throw Error("No options accepted");
const root = resolve(dirname(fileURLToPath(import.meta.url)), "..");
const output = resolve(
  root,
  "src/LeagueCollector/src/LeagueCollector/bin/Release/net10.0",
);
const dll = resolve(output, "LeagueCollector.dll");
const sdk = resolve(
  root,
  "../.npm-cache/lb-headless/dotnet-10.0.401/dotnet.exe",
);
const port = 18807;
const hash = async (path: string) =>
  createHash("sha256")
    .update(await readFile(path))
    .digest("hex");
const delay = (ms: number) => new Promise((r) => setTimeout(r, ms));
const numeric = (v: unknown) =>
  typeof v === "number" && Number.isFinite(v) ? v : null;
async function get(
  path: string,
  game = false,
): Promise<{ http: number | null; data: any }> {
  return new Promise((resolveResult) => {
    const request = (game ? https : http).get(
      {
        hostname: "127.0.0.1",
        port: game ? 2999 : port,
        path,
        rejectUnauthorized: false,
        timeout: 2000,
      },
      (response) => {
        let size = 0;
        const chunks: Buffer[] = [];
        response.on("data", (b) => {
          size += b.length;
          if (size > 16 * 1024 * 1024) request.destroy();
          else chunks.push(b);
        });
        response.on("end", () => {
          try {
            resolveResult({
              http: response.statusCode ?? null,
              data: JSON.parse(Buffer.concat(chunks).toString()),
            });
          } catch {
            resolveResult({ http: response.statusCode ?? null, data: null });
          }
        });
        response.on("error", () => resolveResult({ http: null, data: null }));
      },
    );
    request.on("timeout", () => request.destroy());
    request.on("error", () => resolveResult({ http: null, data: null }));
  });
}
async function open(number: number): Promise<boolean | null> {
  return new Promise((resolveResult) => {
    const socket = net.connect({ host: "127.0.0.1", port: number });
    const finish = (v: boolean | null) => {
      socket.destroy();
      resolveResult(v);
    };
    socket.setTimeout(700, () => finish(false));
    socket.once("connect", () => finish(true));
    socket.once("error", (e) =>
      finish((e as NodeJS.ErrnoException).code === "EACCES" ? null : false),
    );
  });
}
if (
  (await hash(resolve(output, "lblib.dll"))) !==
  "a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3"
)
  throw Error("Pinned native hash mismatch");
await access(resolve(output, "collector.env"));
if ((await open(port)) !== false || (await open(58869)) !== false)
  throw Error("Validation or LB listener occupied; no host started");
const nativeBefore = await open(4998);
if (nativeBefore !== false)
  throw Error("Existing native producer; this cold-start trial not run");
const before = await get("/liveclientdata/allgamedata", true);
const active = await get("/liveclientdata/activeplayername/", true);
if (
  before.http !== 200 ||
  before.data?.gameData?.mapNumber !== 11 ||
  before.data?.allPlayers?.length !== 10 ||
  active.http !== 200 ||
  !["unknown", "spectator"].includes(String(active.data).toLowerCase())
)
  throw Error("SR10 spectator preflight failed");
if (before.data?.events?.Events?.some((e: any) => e.EventName === "GameEnd"))
  throw Error("GameEnd observed; no trial");
await delay(600);
const second = await get("/liveclientdata/gamestats", true);
if (
  second.http !== 200 ||
  !(second.data?.gameTime > before.data.gameData.gameTime)
)
  throw Error("Clock not advancing; no trial");
const folder = resolve(root, "evidence/validation");
await mkdir(folder, { recursive: true });
await writeFile(
  resolve(folder, "sr-live-attempt-20261015.json"),
  JSON.stringify({
    authorization: "user-live-SR-spectator-ready",
    startedAt: new Date().toISOString(),
  }),
  { flag: "wx" },
);
const report: any = {
  kind: "collector-sr-live-validation",
  startedAt: new Date().toISOString(),
  dateLocal: "2026-10-15",
  port,
  autoInject: true,
  lcuEnabled: false,
  rawRecorded: false,
  productionChanged: false,
  nativeHash: await hash(resolve(output, "lblib.dll")),
  hostHash: await hash(dll),
  farsightHash: await hash(resolve(output, "Farsight.dll")),
  preflight: {
    mapNumber: 11,
    players: 10,
    spectatorVerified: true,
    clock: second.data.gameTime,
  },
  samples: [],
  events: [],
  forcedOwnedStop: false,
};
const adapter = new LeagueCollectorSource({ port });
const env = {
  ...process.env,
  DOTNET_CLI_TELEMETRY_OPTOUT: "1",
  DOTNET_CLI_HOME: resolve(root, "../.npm-cache/collector-validation/cli"),
};
const child = spawn(
  sdk,
  [
    dll,
    "--source",
    "lblib",
    "--no-lcu",
    "--port",
    String(port),
    "--interval",
    "100",
    "--validation-30s-single-inject",
  ],
  { cwd: output, env, windowsHide: true, stdio: ["ignore", "pipe", "pipe"] },
);
let exited = false,
  exitCode: number | null = null,
  text = "";
const collect = (chunk: Buffer) => {
  if (text.length < 65536)
    text += chunk.toString().slice(0, 65536 - text.length);
};
child.stdout.on("data", collect);
child.stderr.on("data", collect);
const closed = new Promise<void>((r) => {
  child.once("error", () => {
    exited = true;
    r();
  });
  child.once("close", (code) => {
    exitCode = code;
    exited = true;
    r();
  });
});
const watchdog = setTimeout(() => {
  if (!exited) {
    report.forcedOwnedStop = true;
    child.kill();
  }
}, 45000);
try {
  for (let i = 0; i < 35 && !exited; i++) {
    adapter.ensureConnected();
    const status = await get("/api/status");
    const native = await get("/api/snapshot");
    const live = await get("/liveclientdata/allgamedata", true);
    const normalized = normalizeCollector(native.data, Date.now());
    const rows = Array.isArray(native.data?.data?.heroes)
      ? native.data.data.heroes
      : [];
    const indices = rows
      .map((h: any) => h.heroIndex)
      .filter((v: any) => Number.isInteger(v));
    const histogram = (values: unknown[], allowed: number[]) =>
      Object.fromEntries(
        allowed.map((key) => [
          String(key),
          values.filter((v) => v === key).length,
        ]),
      );
    const comparison: any = {
      clockSkew: null,
      aligned: false,
      rosterMatches: 0,
      fields: {},
    };
    if (normalized && live.http === 200) {
      const reference = normalizeIngame(
        live.data,
        {},
        new Date().toISOString(),
      );
      const skew =
        reference.gameTime.value === null
          ? null
          : Math.abs(
              reference.gameTime.value - normalized.sample.gameTime.value!,
            );
      comparison.clockSkew = skew;
      comparison.aligned = skew !== null && skew <= 1;
      if (comparison.aligned)
        for (const p of normalized.sample.players) {
          const candidates = reference.players.filter(
            (q) =>
              q.team.value === p.team.value &&
              q.championId.value !== null &&
              q.championId.value === p.championId.value,
          );
          if (candidates.length !== 1) continue;
          comparison.rosterMatches++;
          const q = candidates[0];
          for (const key of [
            "level",
            "kills",
            "deaths",
            "assists",
            "cs",
            "items",
          ] as const) {
            if (p[key].value === null || q[key].value === null) continue;
            const entry = (comparison.fields[key] ??= {
              compared: 0,
              matched: 0,
            });
            entry.compared++;
            const a =
              key === "items"
                ? [...(p[key].value as number[])]
                    .filter(Boolean)
                    .sort((a, b) => a - b)
                : p[key].value;
            const b =
              key === "items"
                ? [...(q[key].value as number[])]
                    .filter(Boolean)
                    .sort((a, b) => a - b)
                : q[key].value;
            if (JSON.stringify(a) === JSON.stringify(b)) entry.matched++;
          }
        }
    }
    const auth = status.data?.authentication;
    const state = status.data?.collector;
    const safeAuth = [
      "not-configured",
      "authenticated",
      "authenticated-subscription-unavailable",
      "authentication-failed",
      "challenge-signing-failed",
    ];
    const safeStages = [
      "watching",
      "window-detected",
      "awaiting-ipc",
      "ready",
      "registering-service",
      "service-rejected",
      "awaiting-snapshot",
      "streaming",
      "initialization-failed",
      "handshake-failed",
      "stopped",
    ];
    report.samples.push({
      at: new Date().toISOString(),
      statusHttp: status.http,
      nativeHttp: native.http,
      liveHttp: live.http,
      auth: safeAuth.includes(auth?.state) ? auth.state : null,
      signingAttempts: numeric(auth?.signingAttempts),
      signedResponses: numeric(auth?.signedResponses),
      featureCount: Array.isArray(auth?.features) ? auth.features.length : null,
      stage: safeStages.includes(state?.nativeStage) ? state.nativeStage : null,
      snapshots: numeric(state?.snapshots),
      nativeHeroes: rows.length,
      uniqueHeroIndices: new Set(indices).size,
      teamCounts: histogram(
        rows.map((h: any) => h.info?.team),
        [1, 2, 100, 200],
      ),
      spellIndices: histogram(
        rows.flatMap((h: any) =>
          Array.isArray(h.spells) ? h.spells.map((s: any) => s.index) : [],
        ),
        [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 63],
      ),
      normalized: normalized !== null,
      adapter: adapter.snapshot(),
      comparison,
      resourcePairs: rows.filter(
        (h: any) => Number.isFinite(h.resource) && h.maxResource > 0,
      ).length,
      fieldCoverage: normalized
        ? Object.fromEntries(
            [
              "championId",
              "level",
              "kills",
              "deaths",
              "assists",
              "cs",
              "totalGold",
              "currentGold",
              "health",
              "resource",
              "inventory",
              "spells",
              "cooldowns",
            ].map((key) => [
              key,
              normalized.sample.players.filter(
                (p) => (p as any)[key]?.availability === "observed",
              ).length,
            ]),
          )
        : {},
    });
    await Promise.race([delay(1000), closed]);
  }
  await Promise.race([closed, delay(8000)]);
} finally {
  if (!exited) {
    report.forcedOwnedStop = true;
    child.kill();
    await Promise.race([closed, delay(3000)]);
  }
  clearTimeout(watchdog);
  adapter.stop();
}
for (const line of text.split(/\r?\n/))
  if (line.startsWith('{"validationEvent":'))
    try {
      const event = JSON.parse(line);
      if (
        ![
          "game-window",
          "inject-reported",
          "game-started",
          "native-failed",
          "game-ended",
        ].includes(event.validationEvent)
      )
        continue;
      report.events.push({
        stage: event.validationEvent,
        count: numeric(event.count),
        version:
          typeof event.gameVersion === "string" &&
          /^\d+(?:\.\d+){1,3}$/.test(event.gameVersion)
            ? event.gameVersion
            : null,
        errorType: [
          "LibHookException",
          "LibLoadException",
          "NotSpectatorException",
          "InvalidOperationException",
          "InvalidDataException",
        ].includes(event.errorType)
          ? event.errorType
          : null,
        errorCode: numeric(event.reportedError),
      });
    } catch {}
text = "";
report.exitCode = exitCode;
report.gracefulExit = exited && exitCode === 0 && !report.forcedOwnedStop;
report.nativeListenerAfter = await open(4998);
report.finishedAt = new Date().toISOString();
const after = await get("/liveclientdata/gamestats", true);
report.after = {
  http: after.http,
  clock: numeric(after.data?.gameTime),
  mapNumber: numeric(after.data?.mapNumber),
};
const name = `sr-live-${report.startedAt.replaceAll(":", "-")}.json`;
await writeFile(resolve(folder, name), JSON.stringify(report, null, 2), {
  flag: "wx",
});
console.log(
  JSON.stringify({
    evidence: name,
    samples: report.samples.length,
    nativeSamples: report.samples.filter((s: any) => s.nativeHeroes === 10)
      .length,
    normalizedSamples: report.samples.filter((s: any) => s.normalized).length,
    maxSnapshots: Math.max(
      0,
      ...report.samples.map((s: any) => s.snapshots ?? 0),
    ),
    events: report.events,
    gracefulExit: report.gracefulExit,
    after: report.after,
  }),
);
