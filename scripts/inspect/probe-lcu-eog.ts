// Read-only LCU end-of-game probe for a spectator machine.
// Polls the game flow phase and the two end-of-game endpoints (plus replay metadata by game id)
// from before the match until the client is back in the lobby, and stores filtered payloads.
//   npm run probe:eog            (stops by itself after the match, or Ctrl+C)
//   npm run probe:eog -- --keep  (keep running across several matches)
// Only GET requests. Credentials stay in memory. Saved payloads have PUUIDs, Riot IDs, names,
// tokens and chat data removed; see server/eog-redact.ts.
import { createHash } from "node:crypto";
import { appendFile, mkdir, writeFile } from "node:fs/promises";
import { resolve } from "node:path";
import { discover, getLocal, type Credentials } from "../../server/diagnostics";
import { describeEog, redactEog } from "../../server/eog-redact";
import { reduceHistory } from "../../shared/eog-history";

const keep = process.argv.includes("--keep");
const maxMinutes = Number(
  process.argv.find((a) => a.startsWith("--minutes="))?.split("=")[1] ?? 360,
);
const outDir = resolve(".npm-cache/lcu-eog");
const stamp = new Date().toISOString().replace(/[:.]/g, "-");
const logPath = resolve(outDir, `probe-${stamp}.ndjson`);
await mkdir(outDir, { recursive: true });

const log = async (entry: Record<string, unknown>) => {
  const line = JSON.stringify({ at: new Date().toISOString(), ...entry });
  console.log(line);
  await appendFile(logPath, line + "\n");
};

let credentials: Credentials | null = null;
const get = async (id: string, endpoint: string) => {
  credentials ??= await discover();
  if (!credentials) return { status: "no-client" as const, httpStatus: null, data: undefined };
  const result = await getLocal(id, endpoint, credentials);
  if (result.probe.status === "unreachable") credentials = null; // client restarted
  return { status: result.probe.status, httpStatus: result.probe.httpStatus, data: result.data };
};

const EOG = [
  ["gameclient-eog-stats-block", "/lol-end-of-game/v1/gameclient-eog-stats-block"],
  ["eog-stats-block", "/lol-end-of-game/v1/eog-stats-block"],
] as const;
const seen = new Map<string, string>();
let saved = 0;
let phase = "";
let sawGame = false;
let gameId: number | null = null;
let doneAt: number | null = null;
// After an end-of-game block is saved, the participant client's match history (objectives, bans,
// gold per minute, dragon kinds) is fetched, reduced and stored next to it as a postgame bundle.
let bundle: { gameId: number; eog: unknown; startedAt: number; tries: number } | null = null;
let leftGameAt = 0; // end-of-game data is polled every second for a minute after the match ends
const lastStatus = new Map<string, string>();
const noteStatus = async (id: string, status: string, httpStatus: number | null) => {
  const key = `${status}:${httpStatus}`;
  if (lastStatus.get(id) === key) return;
  lastStatus.set(id, key);
  await log({ event: "endpoint-status", endpoint: id, status, httpStatus });
};
const started = Date.now();
let stopping = false;
process.on("SIGINT", () => {
  stopping = true;
});

await log({
  event: "start",
  keep,
  maxMinutes,
  note: "GET only; payloads are filtered before saving",
});

while (!stopping && Date.now() - started < maxMinutes * 60_000) {
  const flow = await get("probe-phase", "/lol-gameflow/v1/gameflow-phase");
  const current = flow.status === "ok" && typeof flow.data === "string" ? flow.data : flow.status;
  if (current !== phase) {
    if (["InProgress", "GameStart", "Reconnect"].includes(phase)) leftGameAt = Date.now();
    phase = current;
    await log({ event: "phase", phase });
    if (["GameStart", "InProgress", "Reconnect", "WatchInProgress"].includes(phase)) sawGame = true;
    if (flow.status === "ok") {
      const session = await get("probe-session", "/lol-gameflow/v1/session");
      const data = (session.data && typeof session.data === "object" ? session.data : {}) as {
        gameData?: { gameId?: number; isSpectator?: boolean; queue?: Record<string, unknown> };
      };
      if (typeof data.gameData?.gameId === "number" && data.gameData.gameId > 0)
        gameId = data.gameData.gameId;
      await log({
        event: "session",
        phase,
        gameId,
        isSpectator: data.gameData?.isSpectator ?? null,
        queueId: data.gameData?.queue?.id ?? null,
        gameMode: data.gameData?.queue?.gameMode ?? null,
      });
    }
  }

  // End-of-game data is polled every second near the end and every few seconds otherwise.
  const near =
    !["None", "Lobby", "Matchmaking", "ReadyCheck", "ChampSelect"].includes(phase) ||
    Date.now() - leftGameAt < 60_000;
  if (near || Date.now() % 5000 < 1100) {
    for (const [id, endpoint] of EOG) {
      const r = await get(`probe-${id}`, endpoint);
      await noteStatus(id, r.status, r.httpStatus);
      if (r.status !== "ok" || r.data === undefined) continue;
      const { value, removed } = redactEog(r.data);
      const body = JSON.stringify(value);
      const hash = createHash("sha256").update(body).digest("hex").slice(0, 16);
      if (seen.get(id) === hash) continue;
      seen.set(id, hash);
      saved++;
      const file = resolve(outDir, `${stamp}-${String(saved).padStart(2, "0")}-${id}.json`);
      await writeFile(file, JSON.stringify(value, null, 2));
      const eogGameId = Number((value as { gameId?: unknown } | null)?.gameId);
      if (id === "eog-stats-block" && eogGameId > 0)
        bundle = { gameId: eogGameId, eog: value, startedAt: Date.now(), tries: 0 };
      await log({
        event: "payload",
        endpoint: id,
        phase,
        removedFields: removed,
        saved: file.replace(resolve(".") + "\\", ""),
        summary: describeEog(r.data),
      });
    }
  }

  if (bundle && Date.now() - bundle.startedAt < 300_000 && bundle.tries++ % 5 === 0) {
    const detail = await get("probe-history", `/lol-match-history/v1/games/${bundle.gameId}`);
    await noteStatus("match-history", detail.status, detail.httpStatus);
    if (detail.status === "ok") {
      const timeline = await get(
        "probe-timeline",
        `/lol-match-history/v1/game-timelines/${bundle.gameId}`,
      );
      await noteStatus("game-timeline", timeline.status, timeline.httpStatus);
      const history = reduceHistory(detail.data, timeline.status === "ok" ? timeline.data : null);
      if (history) {
        saved++;
        const file = resolve(
          outDir,
          `${stamp}-${String(saved).padStart(2, "0")}-postgame-bundle.json`,
        );
        await writeFile(file, JSON.stringify({ eog: bundle.eog, history }, null, 2));
        await log({
          event: "bundle",
          saved: file.replace(resolve(".") + "\\", ""),
          frames: history.frames.length,
          dragonEvents: history.dragonEvents.length,
          bans: history.teams.map((t) => t.bans.length),
        });
        bundle = null;
      }
    }
  }

  // Replay metadata by game id: shows whether the client could fetch the match as a replay.
  if (gameId && ["WaitingForStats", "PreEndOfGame", "EndOfGame", "Lobby", "None"].includes(phase)) {
    const meta = await get("probe-replay", `/lol-replays/v1/metadata/${gameId}`);
    await noteStatus("replay-metadata", meta.status, meta.httpStatus);
    const key = `replay:${JSON.stringify(meta.data)}`;
    if (meta.status === "ok" && seen.get("replay") !== key) {
      seen.set("replay", key);
      await log({ event: "replay-metadata", phase, gameId, metadata: meta.data });
    }
  }

  // Finish once the client is back in the lobby after a game, with a grace period for late data.
  if (!keep && sawGame && ["Lobby", "None"].includes(phase)) {
    doneAt ??= Date.now();
    if (Date.now() - doneAt > 90_000) break;
  } else doneAt = null;
  await new Promise((r) => setTimeout(r, 1000));
}
await log({ event: "stop", payloadsSaved: saved, sawGame, gameId });
