// Read-only LCU investigation. Credentials stay in memory; no frontend or raw logs.
import { readFile, writeFile } from "node:fs/promises";
import { request } from "node:https";
import { parseLockfile } from "../../server/diagnostics";
const credentials = parseLockfile(
  await readFile(process.env.LOL_LOCKFILE ?? "E:/Riot Games/League of Legends/lockfile", "utf8"),
);
if (!credentials) throw Error("LCU lockfile unavailable");
async function get(path: string) {
  if (!path.startsWith("/")) throw Error("Invalid local endpoint");
  return new Promise<{ status: number; data: any }>((resolve) => {
    const req = request(
      {
        hostname: "127.0.0.1",
        port: credentials!.port,
        path,
        method: "GET",
        rejectUnauthorized: false,
        headers: {
          Authorization: "Basic " + Buffer.from("riot:" + credentials!.password).toString("base64"),
        },
      },
      (res) => {
        let bytes = 0;
        const chunks: Buffer[] = [];
        res.on("data", (b) => {
          bytes += b.length;
          if (bytes > 24_000_000) req.destroy();
          else chunks.push(b);
        });
        res.on("end", () => {
          let data;
          try {
            data = JSON.parse(Buffer.concat(chunks).toString());
          } catch {}
          resolve({ status: res.statusCode ?? 0, data });
        });
      },
    );
    req.setTimeout(6000, () => req.destroy());
    req.on("error", () => resolve({ status: 0, data: null }));
    req.end();
  });
}
const report: any = { at: new Date().toISOString(), readOnly: true };
if (process.argv.includes("--schema")) {
  for (const path of ["/swagger/v3/openapi.json", "/swagger/v2/swagger.json", "/Help"]) {
    const r = await get(path);
    report.schema = { path, status: r.status };
    if (path === "/Help" && r.status === 200) {
      report.helpKeys = Object.keys(r.data ?? {});
      report.functions = Object.entries(r.data?.functions ?? {})
        .filter(([p, v]) => /match-history|alias|summoner.*name/i.test(p))
        .map(([name, v]: any) => ({
          name,
          parameters: v.arguments ?? v.parameters,
          description: v.description,
        }));
    }
    if (r.status !== 200 || !r.data?.paths) continue;
    report.paths = Object.entries(r.data.paths)
      .filter(([p]) =>
        /\/lol-match-history\/|\/lol-summoner\/.*alias|\/lol-end-of-game\/.*stats-block/.test(p),
      )
      .map(([path, v]: any) => ({
        path,
        methods: Object.keys(v),
        parameters: v.get?.parameters,
      }));
    break;
  }
} else {
  const current = await get("/lol-summoner/v1/current-summoner");
  report.current = { status: current.status, hasPuuid: !!current.data?.puuid };
  const playerIndex = process.argv.indexOf("--player"),
    input = playerIndex < 0 ? null : process.argv[playerIndex + 1];
  let puuid = current.data?.puuid;
  if (input) {
    const split = input.lastIndexOf("#");
    if (split < 1) throw Error("Use name#tag");
    let alias = await get(
      "/lol-summoner/v1/alias/summoners?gameName=" +
        encodeURIComponent(input.slice(0, split)) +
        "&tagLine=" +
        encodeURIComponent(input.slice(split + 1)),
    );
    let lookup = "alias";
    if (alias.status === 404) {
      lookup = "summoners-name";
      alias = await get("/lol-summoner/v1/summoners?name=" + encodeURIComponent(input));
    }
    const entries = Array.isArray(alias.data) ? alias.data : [alias.data];
    const matches = entries.filter(
      (x) => x?.puuid && `${x.gameName}#${x.tagLine}`.toLowerCase() === input.toLowerCase(),
    );
    report.alias = {
      lookup,
      status: alias.status,
      results: entries.filter((x) => x?.puuid).length,
      exactRiotIdMatches: matches.length,
    };
    puuid = matches.length === 1 ? matches[0].puuid : null;
  }
  if (puuid) {
    report.currentMatchesRequestedPlayer = current.data?.puuid === puuid;
    const path =
      "/lol-match-history/v1/products/lol/" +
      encodeURIComponent(puuid) +
      "/matches?begIndex=0&endIndex=4";
    const history = await get(path);
    const games = history.data?.games?.games ?? [];
    report.history = {
      status: history.status,
      keys: Object.keys(history.data ?? {}),
      requestedRange: [0, 4],
      returnedCount: games.length,
      customGamesCount: games.filter((g: any) => g.gameType === "CUSTOM_GAME").length,
      games: games.slice(0, 5).map((g: any) => ({
        gameId: g.gameId,
        gameType: g.gameType,
        queueId: g.queueId,
        gameDuration: g.gameDuration,
        participants: g.participants?.length,
        damageFields: g.participants?.map((p: any) => p.stats?.totalDamageDealtToChampions),
      })),
    };
    const gameIndex = process.argv.indexOf("--game-id"),
      id = gameIndex >= 0 ? process.argv[gameIndex + 1] : games[0]?.gameId;
    report.history.requestedGameInHistory = games.some((g: any) => String(g.gameId) === String(id));
    if (id && /^\d+$/.test(String(id)) && !process.argv.includes("--history-only")) {
      const detail = await get("/lol-match-history/v1/games/" + id);
      report.detail = {
        status: detail.status,
        gameId: id,
        keys: Object.keys(detail.data ?? {}),
        gameType: detail.data?.gameType,
        gameDuration: detail.data?.gameDuration,
        gameVersion: detail.data?.gameVersion,
        endOfGameResult: detail.data?.endOfGameResult,
        teams: detail.data?.teams?.map((t: any) => ({
          teamId: t.teamId,
          keys: Object.keys(t),
          win: t.win,
          towerKills: t.towerKills,
          dragonKills: t.dragonKills,
          baronKills: t.baronKills,
          riftHeraldKills: t.riftHeraldKills,
          hordeKills: t.hordeKills,
          bans: t.bans?.length,
        })),
        participants: detail.data?.participants?.map((p: any) => ({
          championId: p.championId,
          teamId: p.teamId,
          damage: p.stats?.totalDamageDealtToChampions,
          physical: p.stats?.physicalDamageDealtToChampions,
          magic: p.stats?.magicDamageDealtToChampions,
          trueDamage: p.stats?.trueDamageDealtToChampions,
          gold: p.stats?.goldEarned,
          win: p.stats?.win,
          kills: p.stats?.kills,
          deaths: p.stats?.deaths,
          assists: p.stats?.assists,
          lane: p.timeline?.lane,
          role: p.timeline?.role,
        })),
      };
      const timeline = await get("/lol-match-history/v1/game-timelines/" + id);
      report.timeline = {
        status: timeline.status,
        keys: Object.keys(timeline.data ?? {}),
        frames: timeline.data?.frames?.length,
        firstTimestamp: timeline.data?.frames?.[0]?.timestamp,
        lastTimestamp: timeline.data?.frames?.at(-1)?.timestamp,
        firstParticipantKeys: Object.keys(
          Object.values(timeline.data?.frames?.[0]?.participantFrames ?? {})[0] ?? {},
        ),
      };
      report.timeline.secondTimestamp = timeline.data?.frames?.[1]?.timestamp;
      report.timeline.objectiveEvents = (timeline.data?.frames ?? [])
        .flatMap((f: any) => f.events ?? [])
        .filter((e: any) => e.type === "ELITE_MONSTER_KILL")
        .map((e: any) => ({
          timestamp: e.timestamp,
          type: e.monsterType,
          subtype: e.monsterSubType,
        }));
    }
  }
}
await writeFile(
  ".npm-cache/lcu-postgame-probe" +
    (process.argv.includes("--schema") ? "-schema" : playerIndexForReport()) +
    ".json",
  JSON.stringify(report, null, 2),
);
console.log(JSON.stringify(report));
function playerIndexForReport() {
  return process.argv.includes("--player") ? "-player" : "";
}
