import type { IngameSample } from "../shared/observer";

const object = (value: unknown): Record<string, any> =>
  value && typeof value === "object" && !Array.isArray(value) ? (value as Record<string, any>) : {};
type Team = "ORDER" | "CHAOS";

// Rebuild from the source history on every sample: seeking cannot retain future kills.
// Identities are used only to resolve attribution, never copied into the contract.
export function enrichRiotObjectives(sample: IngameSample, live: unknown): IngameSample {
  const root = object(live),
    time = sample.gameTime.value;
  if (time === null || sample.players.length === 0) return sample;
  const rawEvents: unknown[] = Array.isArray(object(root.events).Events)
    ? object(root.events).Events
    : [];
  const seen = new Map<number, Record<string, any>>();
  let valid = !sample.limits.eventsTruncated && Array.isArray(object(root.events).Events);
  for (const raw of rawEvents) {
    const e = object(raw);
    if (
      !Number.isInteger(e.EventID) ||
      e.EventID < 0 ||
      !Number.isFinite(e.EventTime) ||
      e.EventTime < 0 ||
      typeof e.EventName !== "string"
    ) {
      valid = false;
      continue;
    }
    if (e.EventTime > time) continue;
    const previous = seen.get(e.EventID);
    if (previous && JSON.stringify(previous) !== JSON.stringify(e)) valid = false;
    seen.set(e.EventID, e);
  }
  const events = [...seen.values()].sort((a, b) => a.EventID - b.EventID);
  const fromStart =
    valid &&
    events[0]?.EventID === 0 &&
    events[0]?.EventName === "GameStart" &&
    events.every((e, i) => e.EventID === i);
  const towers: Record<Team, number> = { ORDER: 0, CHAOS: 0 };
  let towerEventsComplete = fromStart && [11, 12].includes(sample.mapNumber?.value ?? -1);
  const aliases = new Map<string, Set<Team>>();
  for (const raw of Array.isArray(root.allPlayers) ? root.allPlayers : []) {
    const p = object(raw);
    if (p.team !== "ORDER" && p.team !== "CHAOS") continue;
    for (const key of [p.summonerName, p.riotId, p.riotIdGameName]) {
      if (typeof key !== "string" || !key) continue;
      const candidates = aliases.get(key) ?? new Set<Team>();
      candidates.add(p.team);
      aliases.set(key, candidates);
    }
  }
  for (const e of events) {
    const normalized = sample.events.find(
      (x) => x.id === e.EventID && x.at === e.EventTime && x.kind === e.EventName,
    );
    let team: Team | undefined;
    if (e.EventName === "TurretKilled") {
      // Structure owner is authoritative even when a minion dealt the last hit.
      const owner =
        typeof e.TurretKilled === "string"
          ? /^Turret_T(Order|Chaos)_/.exec(e.TurretKilled)?.[1]
          : undefined;
      if (owner) {
        team = owner === "Order" ? "CHAOS" : "ORDER";
        towers[team]++;
      } else towerEventsComplete = false;
    } else {
      const candidates = aliases.get(e.KillerName);
      if (candidates?.size === 1) team = [...candidates][0];
    }
    if (normalized && team) normalized.team = team;
    if (normalized && e.EventName === "DragonKill") {
      const dragon = typeof e.DragonType === "string" ? e.DragonType.toLowerCase() : "";
      if (["fire", "earth", "water", "air", "hextech", "chemtech", "elder"].includes(dragon))
        normalized.objectiveType = dragon as NonNullable<typeof normalized.objectiveType>;
    }
    if (normalized && e.EventName === "BaronKill") normalized.objectiveType = "baron";
    if (normalized && e.EventName === "HeraldKill") normalized.objectiveType = "herald";
  }
  sample.events = sample.events
    .filter((e) => e.at <= time)
    .filter((e, i, all) => all.findIndex((x) => x.id === e.id) === i);
  const field = <T>(value: T | null, source: "live-client" | "riot-events" = "live-client") => ({
    value,
    source,
    availability: value === null ? ("missing" as const) : ("observed" as const),
    observedAt: sample.capturedAt,
  });
  sample.teams = (["ORDER", "CHAOS"] as const).map((team) => {
    const players = sample.players.filter((p) => p.team.value === team);
    const sum = (key: "kills" | "totalGold") =>
      players.length === 5 &&
      !sample.limits.playersTruncated &&
      players.every((p) => p[key].value !== null)
        ? players.reduce((n, p) => n + p[key].value!, 0)
        : null;
    return {
      team,
      kills: field(sum("kills")),
      totalGold: field(sum("totalGold")),
      towers: field(towerEventsComplete ? towers[team] : null, "riot-events"),
      towerPlates: field<number>(null),
      dragons: field<string[]>(null),
      grubs: field<number>(null),
    };
  });
  sample.eventCoverage = {
    historyFromStart: fromStart,
    towerEventsComplete,
    dragonEventsComplete: false,
  };
  return sample;
}
