import type { IngameSample, ObservedPlayer } from "../../shared/observer";
import { normalizeIngame } from "../../server/ingame-adapter";

const obj = (v: unknown): Record<string, unknown> =>
  v !== null && typeof v === "object" && !Array.isArray(v) ? (v as Record<string, unknown>) : {};
export function gamePreflight(first: unknown, second: unknown, active: unknown) {
  if (typeof active !== "string" || !["unknown", "spectator"].includes(active.toLowerCase()))
    return "spectator-unverified" as const;
  for (const raw of [first, second]) {
    const root = obj(raw),
      game = obj(root.gameData),
      events = obj(root.events).Events;
    if (game.mapNumber !== 11 || !Array.isArray(root.allPlayers) || root.allPlayers.length !== 10)
      return "SR10-unverified" as const;
    if (!Array.isArray(events)) return "end-state-unavailable" as const;
    if (events.some((e) => obj(e).EventName === "GameEnd")) return "game-ended" as const;
    if (typeof game.gameTime !== "number" || !Number.isFinite(game.gameTime) || game.gameTime < 0)
      return "clock-unavailable" as const;
  }
  if (!(Number(obj(obj(second).gameData).gameTime) > Number(obj(obj(first).gameData).gameTime)))
    return "clock-not-advancing" as const;
  let a: IngameSample, b: IngameSample;
  try {
    a = normalizeIngame(first, {}, new Date(0).toISOString());
    b = normalizeIngame(second, {}, new Date(0).toISOString());
  } catch {
    return "reference-invalid" as const;
  }
  const keys = (sample: IngameSample) =>
    sample.players.map((p) => `${p.team.value}:${p.championId.value}`).sort();
  for (const sample of [a, b])
    if (
      sample.players.some((p) => p.team.value === null || p.championId.value === null) ||
      sample.players.filter((p) => p.team.value === "ORDER").length !== 5 ||
      sample.players.filter((p) => p.team.value === "CHAOS").length !== 5 ||
      new Set(keys(sample)).size !== 10
    )
      return "roster-ambiguous" as const;
  if (JSON.stringify(keys(a)) !== JSON.stringify(keys(b))) return "roster-changed" as const;
  return "ready" as const;
}

const fields = [
  "level",
  "kills",
  "deaths",
  "assists",
  "cs",
  "items",
  "spells",
  "keystone",
  "health",
  "resource",
  "totalGold",
  "currentGold",
  "perks",
  "cooldowns",
  "isDead",
  "respawnSeconds",
  "hasBaron",
  "hasElder",
] as const;
const fresh = (s: IngameSample, now: number) =>
  Number.isFinite(Date.parse(s.capturedAt)) &&
  Date.parse(s.capturedAt) <= now + 1000 &&
  now - Date.parse(s.capturedAt) < 5000;
const value = (
  p: ObservedPlayer,
  key: (typeof fields)[number],
  source: "league-collector" | "live-client",
) => {
  const field = p[key];
  if (
    !field ||
    field.source !== source ||
    field.availability !== "observed" ||
    field.value === null
  )
    return null;
  if (key === "spells" && (field.value as unknown[]).some((v) => v === null)) return null;
  return field.value;
};
const canonical = (key: (typeof fields)[number], v: unknown) =>
  key === "items"
    ? JSON.stringify(
        (v as number[])
          .filter((id) => id !== 0)
          .slice()
          .sort((a, b) => a - b),
      )
    : JSON.stringify(v);

// Aggregate only: never return player/champion identities, field values or raw payload.
// Presence and equality are separate; unavailable Riot fields cannot prove parity.
export function compareCollectorReference(
  candidate: IngameSample,
  reference: IngameSample,
  now: number,
) {
  const metrics = Object.fromEntries(
    fields.map((key) => [
      key,
      {
        nativePresent: candidate.players.filter((p) => value(p, key, "league-collector") !== null)
          .length,
        referencePresent: reference.players.filter((p) => value(p, key, "live-client") !== null)
          .length,
        compared: 0,
        matched: 0,
        disagreed: 0,
      },
    ]),
  ) as Record<
    (typeof fields)[number],
    {
      nativePresent: number;
      referencePresent: number;
      compared: number;
      matched: number;
      disagreed: number;
    }
  >;
  const clocksValid =
    candidate.gameTime.source === "league-collector" &&
    reference.gameTime.source === "live-client" &&
    candidate.gameTime.availability === "observed" &&
    reference.gameTime.availability === "observed" &&
    candidate.gameTime.value !== null &&
    reference.gameTime.value !== null;
  const skew = clocksValid ? Math.abs(candidate.gameTime.value! - reference.gameTime.value!) : null;
  const aligned = fresh(candidate, now) && fresh(reference, now) && skew !== null && skew <= 0.5;
  const signature = (p: ObservedPlayer) =>
    p.team.value !== null && p.championId.value !== null
      ? `${p.team.value}:${p.championId.value}`
      : null;
  const keys = candidate.players.map(signature);
  const refKeys = reference.players.map(signature);
  const knownRoster = (p: ObservedPlayer, source: "league-collector" | "live-client") =>
    p.team.source === source &&
    p.championId.source === source &&
    p.team.availability === "observed" &&
    p.championId.availability === "observed";
  const rosterComplete =
    candidate.players.length === 10 &&
    reference.players.length === 10 &&
    !keys.includes(null) &&
    !refKeys.includes(null) &&
    new Set(keys).size === 10 &&
    new Set(refKeys).size === 10 &&
    candidate.players.every((p) => knownRoster(p, "league-collector")) &&
    reference.players.every((p) => knownRoster(p, "live-client")) &&
    [candidate, reference].every(
      (s) =>
        s.players.filter((p) => p.team.value === "ORDER").length === 5 &&
        s.players.filter((p) => p.team.value === "CHAOS").length === 5,
    );
  let rosterMatches = 0;
  if (aligned && rosterComplete)
    for (const p of candidate.players) {
      const q = reference.players.find((r) => signature(r) === signature(p));
      if (!q) continue;
      rosterMatches++;
      for (const key of fields) {
        const a = value(p, key, "league-collector"),
          b = value(q, key, "live-client");
        if (a === null || b === null) continue;
        metrics[key].compared++;
        if (canonical(key, a) === canonical(key, b)) metrics[key].matched++;
        else metrics[key].disagreed++;
      }
    }
  return {
    aligned,
    clockSkewSeconds: skew,
    rosterComplete,
    rosterMatches,
    fields: metrics,
    fullParityVerified: false as const,
  };
}
