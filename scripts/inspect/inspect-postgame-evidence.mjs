// Offline, read-only audit. Emits schema paths and aggregate gameplay numbers only.
// Never prints identities, credentials, provider strings, URLs or raw payloads.
import { readdir, writeFile, mkdir } from "node:fs/promises";
import { createReadStream } from "node:fs";
import { createInterface } from "node:readline";
import { resolve } from "node:path";
const root = resolve("data/captures");
const sensitive =
  /name|token|password|secret|authorization|credential|url|path|address|account|summoner|riotid/i;
const candidate =
  /damage|winner|victor|winning|gameend|gameover|postgame|goldgraph|goldhistory|baron|herald|elder|grub|ban|event|result|combat|fight/i;
const finite = (n) => typeof n === "number" && Number.isFinite(n);
function teamSummary(s, side) {
  const t = s.scoreboard?.teams?.[side];
  const rows = s.scoreboardBottom?.teams?.[side]?.players;
  if (!t || !Array.isArray(rows)) return null;
  const sum = (key) =>
    rows.every((p) => finite(p[key])) ? rows.reduce((n, p) => n + p[key], 0) : null;
  return {
    kills: finite(t.kills) ? t.kills : null,
    playerKills: sum("kills"),
    deaths: sum("deaths"),
    assists: sum("assists"),
    gold: finite(t.gold) ? t.gold : null,
    playerGold: sum("totalGold"),
    towers: finite(t.towers) ? t.towers : null,
    grubs: finite(t.grubs) ? t.grubs : null,
    dragons: Array.isArray(t.dragons)
      ? t.dragons
          .map((d) => (typeof d === "string" ? d.toLowerCase().replace(/^dragon_/, "") : "unknown"))
          .map((d) =>
            ["earth", "fire", "water", "air", "hextech", "chemtech", "elder"].includes(d)
              ? d
              : "unknown",
          )
      : null,
  };
}
const report = {
  files: [],
  total: { records: 0, stateFrames: 0, invalidLines: 0 },
  candidatePaths: {},
  rootStateKeys: new Set(),
  teamKeys: new Set(),
  tabPlayerKeys: new Set(),
  statusNumbers: new Set(),
  eventKeys: new Set(),
  eventShapes: new Set(),
  eventTypes: new Set(),
  stateTeamKeys: new Set(),
};
function scan(v, paths, path = "", depth = 0) {
  if (!v || typeof v !== "object" || depth > 10) return;
  if (Array.isArray(v)) {
    for (const child of v) scan(child, paths, `${path}[]`, depth + 1);
    return;
  }
  for (const [key, child] of Object.entries(v)) {
    if (sensitive.test(key) || !/^[a-zA-Z][a-zA-Z0-9_-]{0,60}$/.test(key)) continue;
    const p = path ? `${path}.${key}` : key;
    if (candidate.test(key))
      paths.add(`${p}:${Array.isArray(child) ? "array" : child === null ? "null" : typeof child}`);
    scan(child, paths, p, depth + 1);
  }
}
for (const entry of await readdir(root, { withFileTypes: true })) {
  if (!entry.isDirectory() || !/^(lb-)?\d{4}-/.test(entry.name)) continue;
  for (const filename of await readdir(resolve(root, entry.name))) {
    if (filename !== "leaguebroadcast-ws.ndjson") continue;
    const f = {
      capture: entry.name,
      records: 0,
      states: 0,
      completeRosterFrames: 0,
      firstRosterTime: null,
      validTimes: 0,
      messageTypes: {},
      firstTime: null,
      lastTime: null,
      minTime: null,
      maxTime: null,
      gameBacksteps: 0,
      gameForwardJumpsOver10s: 0,
      wallGapsOver5s: 0,
      maxWallGapSeconds: 0,
      firstTeams: null,
      lastTeams: null,
      paths: [],
      statuses: [],
      teamGoldPresent: 0,
      tenPlayerKdaPresent: 0,
      objectiveKills: [],
      observedBaronFalseToTrue: [0, 0],
      observedElderFalseToTrue: [0, 0],
    };
    let lastTime = null,
      lastWall = null,
      buffs = [null, null],
      elders = [null, null];
    const paths = new Set();
    for await (const line of createInterface({
      input: createReadStream(resolve(root, entry.name, filename)),
      crlfDelay: Infinity,
    })) {
      if (!line.trim()) continue;
      let record;
      try {
        record = JSON.parse(line);
      } catch {
        report.total.invalidLines++;
        continue;
      }
      const m = record?.message;
      if (!m || typeof m !== "object") continue;
      f.records++;
      const type = [
        "ingame-state-update",
        "gameStatus",
        "match-update",
        "champion-select-state-update",
        "postgame-state-update",
        "postgame",
        "event",
      ].includes(m.type)
        ? m.type
        : "other";
      f.messageTypes[type] = (f.messageTypes[type] ?? 0) + 1;
      scan(m, paths);
      for (const [key, children] of Object.entries(m.events ?? {})) {
        if (sensitive.test(key) || !/^[a-zA-Z][a-zA-Z0-9_-]{0,60}$/.test(key)) continue;
        report.eventKeys.add(key);
        if (!Array.isArray(children)) continue;
        for (const child of children)
          if (child && typeof child === "object") {
            for (const k of Object.keys(child))
              if (!sensitive.test(k) && /^[a-zA-Z][a-zA-Z0-9_-]{0,60}$/.test(k))
                report.eventShapes.add(`${key}.${k}`);
            if (finite(child.eventType)) report.eventTypes.add(`${key}:${child.eventType}`);
            else if (
              typeof child.eventType === "string" &&
              /^(kill|spawn|despawn|killed)$/i.test(child.eventType)
            )
              report.eventTypes.add(`${key}:${child.eventType.toLowerCase()}`);
            if (
              key === "objective" &&
              typeof child.eventType === "string" &&
              child.eventType.toLowerCase() === "kill"
            ) {
              const kind =
                typeof child.objective === "string"
                  ? (/baron|herald|grub|dragon|elder/i.exec(child.objective)?.[0]?.toLowerCase() ??
                    "unknown")
                  : "unknown";
              f.objectiveKills.push({
                at: finite(m.state?.gameTime) ? m.state.gameTime : null,
                kind,
                team: finite(child.team) ? child.team : null,
              });
            }
          }
      }
      if (m.type === "gameStatus" && finite(m.gameState)) {
        f.statuses.push(m.gameState);
        report.statusNumbers.add(m.gameState);
      }
      if (m.type !== "ingame-state-update" || !m.state) continue;
      const s = m.state;
      f.states++;
      if (Array.isArray(s.teams))
        for (const team of s.teams)
          for (const key of Object.keys(team))
            if (!sensitive.test(key)) report.stateTeamKeys.add(key);
      for (const key of Object.keys(s)) if (!sensitive.test(key)) report.rootStateKeys.add(key);
      for (const t of s.scoreboard?.teams ?? [])
        for (const key of Object.keys(t)) if (!sensitive.test(key)) report.teamKeys.add(key);
      for (const side of ["Order", "Chaos"])
        for (const p of s.tabs?.[side]?.players ?? [])
          for (const key of Object.keys(p)) if (!sensitive.test(key)) report.tabPlayerKeys.add(key);
      if (!finite(s.gameTime)) continue;
      const time = s.gameTime,
        wall = Date.parse(record.receivedAt);
      f.validTimes++;
      f.firstTime ??= time;
      f.lastTime = time;
      f.minTime = Math.min(f.minTime ?? time, time);
      f.maxTime = Math.max(f.maxTime ?? time, time);
      if (lastTime !== null && time < lastTime) f.gameBacksteps++;
      if (lastTime !== null && time - lastTime > 10) f.gameForwardJumpsOver10s++;
      if (lastWall !== null && finite(wall)) {
        const gap = (wall - lastWall) / 1000;
        if (gap > 5) f.wallGapsOver5s++;
        f.maxWallGapSeconds = Math.max(f.maxWallGapSeconds, gap);
      }
      const teams = [teamSummary(s, 0), teamSummary(s, 1)];
      const rows = (s.scoreboardBottom?.teams ?? []).flatMap((t) => t.players ?? []);
      if (rows.length === 10) {
        f.completeRosterFrames++;
        f.firstRosterTime ??= time;
      }
      if (teams.every((t) => t?.gold !== null && t?.gold !== undefined)) f.teamGoldPresent++;
      if (
        rows.length === 10 &&
        rows.every((p) => ["kills", "deaths", "assists"].every((k) => finite(p[k])))
      )
        f.tenPlayerKdaPresent++;
      if (teams.every(Boolean)) {
        f.firstTeams ??= teams;
        f.lastTeams = teams;
      }
      for (const side of [0, 1]) {
        const players = s.tabs?.[side ? "Chaos" : "Order"]?.players ?? [];
        for (const [key, previous, counts] of [
          ["hasBaron", buffs, f.observedBaronFalseToTrue],
          ["hasElder", elders, f.observedElderFalseToTrue],
        ]) {
          if (!players.length || !players.every((p) => typeof p[key] === "boolean")) continue;
          const current = players.some((p) => p[key]);
          if (lastTime !== null && time >= lastTime && previous[side] === false && current)
            counts[side]++;
          previous[side] = current;
        }
      }
      lastTime = time;
      if (finite(wall)) lastWall = wall;
    }
    f.paths = [...paths].sort();
    for (const path of paths) report.candidatePaths[path] = (report.candidatePaths[path] ?? 0) + 1;
    report.total.records += f.records;
    report.total.stateFrames += f.states;
    report.files.push(f);
  }
}
for (const key of [
  "rootStateKeys",
  "teamKeys",
  "tabPlayerKeys",
  "statusNumbers",
  "eventKeys",
  "eventShapes",
  "eventTypes",
  "stateTeamKeys",
])
  report[key] = [...report[key]].sort();
if (process.argv.includes("--save")) {
  await mkdir(resolve(".npm-cache"), { recursive: true });
  await writeFile(resolve(".npm-cache/postgame-evidence.json"), JSON.stringify(report, null, 2));
}
console.log(JSON.stringify(report, null, 2));
