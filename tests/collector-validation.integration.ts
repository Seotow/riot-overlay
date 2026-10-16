import assert from "node:assert/strict";
import { createServer } from "node:http";
import { once } from "node:events";
import { randomUUID } from "node:crypto";
import { mkdir, writeFile } from "node:fs/promises";
import { resolve } from "node:path";
import { WebSocketServer, WebSocket } from "ws";
import { normalizeCollector } from "../Collector/adapter";
import { validateProject } from "../Collector/validation/project";

type Scenario =
  | "pass"
  | "different-obs"
  | "different-field"
  | "clock-skew"
  | "provider-change"
  | "game-end"
  | "no-game"
  | "external"
  | "missing-core"
  | "LB-busy";
const codes = ["Ahri", "Garen", "Annie", "Ashe", "Lux"];
const startedAt = new Date().toISOString();
const outcomes: Record<string, unknown>[] = [];

// Entire server/reference/ownership below is invented test data. No native DLL,
// game port2999, LB listener, credentials, auth, injection or real project state.
async function scenario(kind: Scenario) {
  const start = Date.now(),
    sessionId = randomUUID();
  let sequence = 0,
    referenceReads = 0,
    providerReads = 0,
    projectReads = 0,
    lbReads = 0;
  let wsCommands = 0,
    nonGetRequests = 0;
  const roles = new Map<WebSocket, string>();
  const clock = () => 100 + (Date.now() - start) / 1000;
  const makeFrame = () => {
    const timestamp = new Date().toISOString();
    const sample = normalizeCollector(
      {
        schemaVersion: 1,
        sequence: ++sequence,
        timestamp,
        type: "snapshot",
        source: "lblib",
        synthetic: false,
        recordedAt: null,
        data: {
          gameTime: clock() + (kind === "clock-skew" ? 2 : 0),
          heroes: Array.from({ length: 10 }, (_, i) => ({
            heroIndex: i,
            info: {
              team: i < 5 ? 1 : 2,
              networkId: i + 1000,
              name: "PRIVATE_NATIVE_SENTINEL",
            },
            common: {
              identifier: codes[i % 5],
              level:
                kind === "missing-core"
                  ? undefined
                  : kind === "different-field" && i === 0
                    ? 11
                    : 10,
              health: 500,
              maxHealth: 1000,
            },
            kills: kind === "missing-core" ? undefined : 0,
            deaths: 1,
            assists: 2,
            totalGold: 5000,
            items: [{ slot: 6, id: 3340, count: 1 }],
          })),
        },
      },
      Date.now(),
    )!.sample;
    return {
      protocolVersion: 1,
      sessionId,
      sequence,
      epoch: 0,
      status: "observed",
      transition: "none",
      capturedAt: timestamp,
      sample,
      newEvents: [],
    };
  };
  let latest = makeFrame();
  const server = createServer((req, res) => {
    if (req.method !== "GET") {
      nonGetRequests++;
      res.writeHead(405);
      res.end();
      return;
    }
    let data: unknown;
    if (req.url === "/game/liveclientdata/activeplayername/")
      data = "Spectator";
    else if (req.url === "/game/liveclientdata/allgamedata") {
      referenceReads++;
      if (kind === "no-game") {
        res.writeHead(503);
        res.end("{}");
        return;
      }
      data = {
        gameData: { mapNumber: 11, gameTime: clock() },
        events: {
          Events:
            kind === "game-end" && referenceReads > 2
              ? [{ EventName: "GameEnd" }]
              : [],
        },
        allPlayers: Array.from({ length: 10 }, (_, i) => ({
          rawChampionName: `game_character_displayname_${codes[i % 5]}`,
          team: i < 5 ? "ORDER" : "CHAOS",
          level: 10,
          riotId: "PRIVATE_REFERENCE_SENTINEL",
          scores: { kills: 0, deaths: 1, assists: 2, creepScore: 30 },
          items: [{ slot: 6, itemID: 3340, count: 1 }],
        })),
      };
    } else if (req.url === "/api/providers") {
      projectReads++;
      providerReads++;
      const switched = kind === "provider-change" && providerReads >= 3;
      data = {
        capturedAt: new Date().toISOString(),
        selected: switched ? "riot" : "league-collector",
        output: switched ? "riot" : "league-collector",
        collector: {
          status: "receiving",
          endpoint: "ws://127.0.0.1:18799/ws",
          acceptedFrames: sequence,
          invalidFrames: 0,
          players: 10,
          coverage: { level: 10 },
          lastFrameAt: latest.capturedAt,
          capabilities: {
            fields: ["level"],
            events: false,
            objectives: false,
            roleOrderVerified: false,
            productionReady: false,
          },
          slotOrder: "team-hero-index",
          eventSemantics: "unverified",
          runtime: {
            status: kind === "external" ? "external" : "running",
            error: null,
            owned: kind !== "external",
            credentialConfigured: false,
            port: 18799,
          },
        },
        leaguebroadcast: {
          status: "offline",
          lastFrameAt: null,
          lastMessageAt: null,
          frames: 0,
          players: 0,
          fields: [],
          endpoint: "ws://127.0.0.1:58869/ws/in",
          gameStatus: "unknown",
          testingEnvironment: null,
          telemetry: null,
          assetCache: null,
        },
      };
    } else if (req.url === "/api/observer") {
      projectReads++;
      data = latest;
    } else {
      res.writeHead(404);
      res.end("{}");
      return;
    }
    res.writeHead(200, { "Content-Type": "application/json" });
    res.end(JSON.stringify(data));
  });
  const sockets = new WebSocketServer({ server });
  const send = (socket: WebSocket) => {
    if (socket.readyState !== WebSocket.OPEN) return;
    const frame = structuredClone(latest);
    if (kind === "different-obs" && roles.get(socket) === "overlay")
      frame.sample.players[0].level.value = 11;
    socket.send(JSON.stringify({ type: "observer", frame }));
  };
  sockets.on("connection", (socket, req) => {
    roles.set(
      socket,
      new URL(req.url!, "http://127.0.0.1").searchParams.get("role") ?? "",
    );
    socket.on("message", () => wsCommands++);
    send(socket);
  });
  server.listen(0, "127.0.0.1");
  await once(server, "listening");
  const bound = server.address();
  assert.ok(bound && typeof bound === "object");
  const url = `http://127.0.0.1:${bound.port}`;
  const ticker = setInterval(() => {
    latest = makeFrame();
    for (const socket of sockets.clients) send(socket);
  }, 100);
  try {
    const report = await validateProject({
      dataOrigin: "fixture",
      projectBaseUrl: url,
      seconds: 1,
      get: async (game, path) => {
        const response = await fetch(url + (game ? "/game" : "") + path, {
          signal: AbortSignal.timeout(2000),
        });
        return { http: response.status, data: await response.json() };
      },
      lbListener: async () => {
        lbReads++;
        return kind === "LB-busy";
      },
    });
    assert.equal(report.dataOrigin, "fixture");
    assert.equal(report.launcherStarted, false);
    assert.equal(report.fullParityVerified, false);
    assert.ok(!JSON.stringify(report).includes("SENTINEL"));
    assert.equal(wsCommands, 0);
    assert.equal(nonGetRequests, 0);
    if (kind === "no-game") {
      assert.equal(report.preflight, "game-api-unavailable");
      assert.equal(projectReads, 0);
      assert.equal(lbReads, 0);
      assert.equal(sockets.clients.size, 0);
      assert.equal(report.projectOwned, null);
    } else if (kind === "external") {
      assert.equal(report.projectOwned, false);
      assert.equal(report.samples.length, 0);
      assert.ok(report.errors.includes("project-owned-collector-unavailable"));
      assert.equal(sockets.clients.size, 0);
    } else if (kind === "LB-busy") {
      assert.equal(report.lbListenerClosed, false);
      assert.equal(report.samples.length, 0);
      assert.equal(sockets.clients.size, 0);
      assert.ok(report.errors.includes("LB-listener-not-confirmed-closed"));
    } else {
      assert.equal(report.measurementScope, "fixture-project-comparison");
      if (kind === "pass") {
        assert.deepEqual(report.errors, []);
        assert.ok(report.samples.length > 0);
        assert.ok(
          report.samples.every(
            (s) => s.rosterMatches === 10 && s.fields.level.matched === 10,
          ),
        );
        assert.ok(report.shared.pairedFrames > 0);
        assert.equal(report.shared.equalFrames, report.shared.pairedFrames);
        assert.equal(report.shared.differingFrames, 0);
        assert.ok(
          report.samples.every(
            (s) =>
              s.fields.health.referencePresent === 0 &&
              s.fields.health.compared === 0,
          ),
        );
      } else if (kind === "different-obs") {
        assert.ok(report.shared.differingFrames > 0);
        assert.ok(report.errors.includes("consumer-frame-disagreement"));
      } else if (kind === "different-field")
        assert.ok(report.errors.includes("field-disagreements-observed"));
      else if (kind === "clock-skew")
        assert.ok(report.errors.includes("no-aligned-roster-comparisons"));
      else if (kind === "provider-change")
        assert.ok(
          report.errors.includes("project-provider-changed-or-stopped"),
        );
      else if (kind === "game-end")
        assert.ok(report.errors.includes("game-session-ended-or-changed"));
      else if (kind === "missing-core") {
        assert.ok(report.shared.equalFrames > 0);
        assert.ok(report.errors.includes("no-complete-core-comparison"));
        assert.ok(report.samples.every((s) => s.fields.level.compared === 0));
      }
    }
    // Only summary counts/status survive. Reference/native payloads never persist.
    outcomes.push({
      scenario: kind,
      preflight: report.preflight,
      measurementScope: report.measurementScope,
      comparisons: report.samples.length,
      pairedFrames: report.shared.pairedFrames,
      equalFrames: report.shared.equalFrames,
      differingFrames: report.shared.differingFrames,
      errors: report.errors,
      wsCommands,
      nonGetRequests,
      projectReads,
      lbReads,
      dataOrigin: "fixture",
    });
  } finally {
    clearInterval(ticker);
    for (const socket of sockets.clients) socket.terminate();
    await new Promise<void>((yes) => sockets.close(() => yes()));
    await new Promise<void>((yes) => server.close(() => yes()));
  }
  assert.equal(server.listening, false);
}
for (const kind of [
  "pass",
  "different-obs",
  "different-field",
  "clock-skew",
  "provider-change",
  "game-end",
  "no-game",
  "external",
  "missing-core",
  "LB-busy",
] as const)
  await scenario(kind);
const report = {
  kind: "collector-project-validator-lab",
  startedAt,
  dataOrigin: "fixture",
  gameAccessed: false,
  nativeLaunched: false,
  credentialsExported: false,
  rawRecorded: false,
  outcomes,
};
const folder = resolve("Collector/evidence/validation");
await mkdir(folder, { recursive: true });
await writeFile(
  resolve(
    folder,
    `project-validator-lab-${startedAt.replaceAll(":", "-")}.json`,
  ),
  JSON.stringify(report, null, 2),
  { flag: "wx" },
);
console.log(
  "PASS: project validator HTTP/WS fixture, ten positive/failure scenarios, cleanup and read-only guards; no game/native proof",
);
