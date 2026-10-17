import { request } from "node:https";
import { readFile } from "node:fs/promises";
import { execFile } from "node:child_process";
import { promisify } from "node:util";
import { dirname, join } from "node:path";
import type { DiagnosticReport, Evidence, Probe } from "../shared/diagnostics";
type Credentials = { port: number; password: string };
export function parseLockfile(text: string): Credentials | null {
  const parts = text.trim().split(":");
  const port = Number(parts[2]);
  return parts.length === 5 &&
    parts[0] === "LeagueClient" &&
    parts[4] === "https" &&
    Number.isInteger(port) &&
    port > 0 &&
    port <= 65535 &&
    !!parts[3]
    ? { port, password: parts[3] }
    : null;
}
export async function discover(): Promise<Credentials | null> {
  const paths = process.env.LOL_LOCKFILE
    ? [process.env.LOL_LOCKFILE]
    : [
        "C:/Riot Games/League of Legends/lockfile",
        "D:/Riot Games/League of Legends/lockfile",
      ];
  if (!process.env.LOL_LOCKFILE && process.platform === "win32") {
    try {
      const { stdout } = await promisify(execFile)(
        "powershell.exe",
        [
          "-NoProfile",
          "-NonInteractive",
          "-Command",
          "Get-Process LeagueClient -ErrorAction SilentlyContinue | Select-Object -ExpandProperty Path",
        ],
        { timeout: 2000, windowsHide: true, maxBuffer: 8192 },
      );
      for (const p of stdout.trim().split(/\r?\n/).filter(Boolean))
        paths.unshift(join(dirname(p), "lockfile"));
    } catch {
      /* No client or permission to read executable path. */
    }
  }
  for (const path of paths) {
    try {
      const c = parseLockfile(await readFile(path, "utf8"));
      if (c) return c;
    } catch {}
  }
  return null;
}
export type Result = { probe: Probe; data?: unknown };
export function getLocal(
  id: string,
  endpoint: string,
  credentials?: Credentials,
): Promise<Result> {
  const started = performance.now();
  return new Promise((resolve) => {
    let finished = false;
    const finish = (
      status: Probe["status"],
      httpStatus: number | null = null,
      data?: unknown,
    ) => {
      if (finished) return;
      finished = true;
      clearTimeout(deadline);
      resolve({
        probe: {
          id,
          source: credentials
            ? "LCU"
            : endpoint.startsWith("/replay/")
              ? "Replay API"
              : "Live Client",
          endpoint,
          status,
          httpStatus,
          latencyMs: Math.round(performance.now() - started),
          observedAt: new Date().toISOString(),
        },
        data,
      });
    };
    // Self-signed TLS exception is scoped to this fixed loopback request only.
    const req = request(
      {
        hostname: "127.0.0.1",
        port: credentials?.port ?? 2999,
        path: endpoint,
        method: "GET",
        rejectUnauthorized: false,
        headers: credentials
          ? {
              Authorization: `Basic ${Buffer.from(`riot:${credentials.password}`).toString("base64")}`,
            }
          : {},
      },
      (res) => {
        let size = 0;
        const chunks: Buffer[] = [];
        res.on("data", (chunk: Buffer) => {
          size += chunk.length;
          if (size > 2_000_000) {
            finish("invalid", res.statusCode);
            req.destroy();
          } else chunks.push(chunk);
        });
        res.on("error", () => finish("unreachable"));
        res.on("end", () => {
          if (res.statusCode !== 200)
            return finish("http-error", res.statusCode);
          try {
            finish(
              "ok",
              200,
              JSON.parse(Buffer.concat(chunks).toString("utf8")),
            );
          } catch {
            finish("invalid", 200);
          }
        });
      },
    );
    const deadline = setTimeout(() => {
      finish("unreachable");
      req.destroy();
    }, 2500);
    req.on("error", () => finish("unreachable"));
    req.end();
  });
}
function at(value: unknown, path: string[]): unknown {
  if (!path.length) return value;
  if (Array.isArray(value)) return value.map((v) => at(v, path));
  if (!value || typeof value !== "object") return undefined;
  return at((value as Record<string, unknown>)[path[0]], path.slice(1));
}
const definitions = [
  [
    "playback",
    "replay",
    "Replay time",
    "time",
    "number",
    "Đồng hồ phát replay, không thay thế gameTime.",
  ],
  [
    "playback",
    "replay",
    "Replay speed",
    "speed",
    "number",
    "Không suy ra thống kê người chơi từ playback.",
  ],
  [
    "draft",
    "pre-game",
    "Picks / champion ID",
    "myTeam.championId",
    "number",
    "Đội phía client; kiểm chứng riêng spectator.",
  ],
  [
    "draft",
    "pre-game",
    "Picks đối phương",
    "theirTeam.championId",
    "number",
    "Có thể bị ẩn trong một số chế độ.",
  ],
  [
    "draft",
    "pre-game",
    "Bans đội phía client",
    "bans.myTeamBans",
    "number",
    "Danh sách trống chưa chứng minh có ban.",
  ],
  [
    "draft",
    "pre-game",
    "Bans đối phương",
    "bans.theirTeamBans",
    "number",
    "Cần thu ở phase chọn tướng.",
  ],
  [
    "live",
    "in-game",
    "Level",
    "allPlayers.level",
    "number",
    "Chỉ xác nhận các giá trị có trong mẫu.",
  ],
  [
    "live",
    "in-game",
    "Kills",
    "allPlayers.scores.kills",
    "number",
    "Không suy ra dữ liệu người chơi thiếu.",
  ],
  [
    "live",
    "in-game",
    "Deaths",
    "allPlayers.scores.deaths",
    "number",
    "Không suy ra dữ liệu người chơi thiếu.",
  ],
  [
    "live",
    "in-game",
    "Assists",
    "allPlayers.scores.assists",
    "number",
    "Không suy ra dữ liệu người chơi thiếu.",
  ],
  [
    "live",
    "in-game",
    "CS",
    "allPlayers.scores.creepScore",
    "number",
    "Không chứng minh độ trễ spectator.",
  ],
  [
    "live",
    "in-game",
    "Items",
    "allPlayers.items.itemID",
    "number",
    "Chỉ ID, không xuất tên tài khoản.",
  ],
  [
    "live",
    "in-game",
    "Current gold (active player)",
    "activePlayer.currentGold",
    "number",
    "Không phải total gold hoặc gold cả 10 người.",
  ],
  [
    "live",
    "in-game",
    "Total gold",
    "allPlayers.totalGold",
    "number",
    "Không dùng currentGold thay thế.",
  ],
  [
    "live",
    "in-game",
    "Game clock",
    "gameData.gameTime",
    "number",
    "Một mẫu chưa xác minh pause/reconnect.",
  ],
  [
    "live",
    "in-game",
    "Event IDs",
    "events.Events.EventID",
    "number",
    "ID sự kiện không chứng minh loại objective hoặc trạng thái inhibitor; cần adapter kiểm chứng tiếp.",
  ],
  [
    "post",
    "postgame",
    "Champion ID",
    "teams.players.championId",
    "number",
    "Endpoint khảo sát, chưa có cam kết schema.",
  ],
] as const;
export function makeReport(results: Result[]): DiagnosticReport {
  const fields: Evidence[] = definitions.map(
    ([id, stage, field, path, type, limitation]) => {
      const r = results.find((r) => r.probe.id === id);
      const raw = at(r?.data, path.split("."));
      // Export only explicitly selected finite numeric samples. Never export provider objects or strings.
      const values = (Array.isArray(raw) ? raw.flat(Infinity) : [raw]).filter(
        (v) => typeof v === "number" && Number.isFinite(v),
      );
      return {
        field,
        stage,
        source: r?.probe.source ?? "LCU",
        path,
        type,
        limitation,
        availability:
          r?.probe.status !== "ok"
            ? "unverified"
            : values.length
              ? "observed"
              : "missing",
        sample:
          r?.probe.status === "ok" && values.length
            ? values.slice(0, 50)
            : null,
      };
    },
  );
  for (const field of ["Objective state", "Inhibitor state / respawn"]) {
    fields.push({
      field,
      stage: "in-game",
      source: "Live Client",
      path: "events.Events",
      type: "unverified",
      availability: "unverified",
      sample: null,
      limitation:
        "Chưa có adapter xác minh loại sự kiện và thời điểm; không suy ra trạng thái hoặc timer từ EventID.",
    });
  }
  const phase = results.find((r) => r.probe.id === "phase")?.data;
  const phases = [
    "None",
    "Lobby",
    "Matchmaking",
    "ReadyCheck",
    "ChampSelect",
    "InProgress",
    "WaitingForStats",
    "PreEndOfGame",
    "EndOfGame",
    "Reconnect",
    "GameStart",
  ];
  return {
    version: 1,
    capturedAt: new Date().toISOString(),
    phase: typeof phase === "string" && phases.includes(phase) ? phase : null,
    probes: results.map((r) => r.probe),
    fields,
  };
}
let pending: Promise<DiagnosticReport> | undefined;
let cached: DiagnosticReport | undefined;
export async function diagnose(): Promise<DiagnosticReport> {
  if (pending) return pending;
  if (cached && Date.now() - Date.parse(cached.capturedAt) < 3000)
    return cached;
  pending = (async () => {
    const credentials = await discover();
    const endpoints = [
      ["phase", "/lol-gameflow/v1/gameflow-phase"],
      ["draft", "/lol-champ-select/v1/session"],
      ["post", "/lol-end-of-game/v1/eog-stats-block"],
    ];
    const results = await Promise.all([
      getLocal("live", "/liveclientdata/allgamedata"),
      getLocal("replay-game", "/replay/game"),
      getLocal("playback", "/replay/playback"),
      ...endpoints.map(([id, endpoint]): Promise<Result> =>
        credentials
          ? getLocal(id, endpoint, credentials)
          : Promise.resolve({
              probe: {
                id,
                endpoint,
                source: "LCU",
                status: "not-configured",
                httpStatus: null,
                latencyMs: null,
                observedAt: new Date().toISOString(),
              },
            }),
      ),
    ]);
    cached = makeReport(results);
    return cached;
  })();
  try {
    return await pending;
  } finally {
    pending = undefined;
  }
}
