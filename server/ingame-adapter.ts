import { liveCatalog, resolveChampion, resolveSpell } from "../shared/live-assets";
import { createHash } from "node:crypto";
import { cleanPlayerName } from "../shared/player-name";
import { projectItemCounters } from "../shared/item-counters";
import { ingameSampleSchema, observedEventSchema, type IngameSample } from "../shared/observer";
const object = (v: unknown): Record<string, unknown> =>
  v !== null && typeof v === "object" && !Array.isArray(v) ? (v as Record<string, unknown>) : {};
function numeric(v: unknown, integer = false, max = Number.MAX_SAFE_INTEGER): number | null {
  return typeof v === "number" &&
    Number.isFinite(v) &&
    v >= 0 &&
    v <= max &&
    (!integer || Number.isInteger(v))
    ? v
    : null;
}
function observed<T>(
  value: T | null,
  observedAt: string,
  source: "live-client" | "replay-api" = "live-client",
) {
  return {
    value,
    availability: value === null ? ("missing" as const) : ("observed" as const),
    source,
    observedAt,
  };
}
export function normalizeIngame(
  live: unknown,
  playback: unknown,
  capturedAt: string,
): IngameSample {
  const root = object(live),
    replay = object(playback);
  const sourcePlayers = Array.isArray(root.allPlayers) ? root.allPlayers : [];
  const sourceEvents = object(root.events).Events;
  const slotFor = (name: unknown) => {
    if (typeof name !== "string" || !name) return undefined;
    const slots = sourcePlayers.slice(0, 10).flatMap((raw, slot) => {
      const p = object(raw);
      return [p.riotId, p.summonerName, p.riotIdGameName].includes(name) ? [slot] : [];
    });
    return slots.length === 1 ? slots[0] : undefined;
  };
  const events = (Array.isArray(sourceEvents) ? sourceEvents : []).slice(-4096).flatMap((raw) => {
    const e = object(raw);
    const killerSlot = slotFor(e.KillerName),
      victimSlot = slotFor(e.VictimName);
    const killerTeam =
      killerSlot === undefined ? undefined : object(sourcePlayers[killerSlot]).team;
    const parsed = observedEventSchema.safeParse({
      id: e.EventID,
      at: e.EventTime,
      kind: e.EventName,
      ...(killerSlot !== undefined ? { killerSlot } : {}),
      ...(killerTeam === "ORDER" || killerTeam === "CHAOS" ? { team: killerTeam } : {}),
      ...(victimSlot !== undefined ? { victimSlot } : {}),
      ...(Array.isArray(e.Assisters)
        ? {
            assistSlots: [
              ...new Set(
                e.Assisters.flatMap((name) => {
                  const slot = slotFor(name);
                  return slot !== undefined && slot !== killerSlot && slot !== victimSlot
                    ? [slot]
                    : [];
                }),
              ),
            ].slice(0, 4),
          }
        : {}),
    });
    return parsed.success ? [parsed.data] : [];
  });
  return ingameSampleSchema.parse({
    capturedAt,
    assetVersion: liveCatalog.version,
    assetPatchMatch: "unverified",
    mapNumber: observed(numeric(object(root.gameData).mapNumber, true), capturedAt),
    gameTime: observed(numeric(object(root.gameData).gameTime), capturedAt),
    replay: {
      time: observed(numeric(replay.time), capturedAt, "replay-api"),
      paused: observed(
        typeof replay.paused === "boolean" ? replay.paused : null,
        capturedAt,
        "replay-api",
      ),
      speed: observed(numeric(replay.speed), capturedAt, "replay-api"),
    },
    players: sourcePlayers.slice(0, 10).map((raw, slot) => {
      const p = object(raw),
        scores = object(p.scores);
      const itemIds =
        Array.isArray(p.items) && p.items.length <= 7
          ? p.items.map((i) => numeric(object(i).itemID, true))
          : null;
      const level = numeric(p.level, true, 30),
        championId = numeric(p.championId, true);
      const champion = resolveChampion(p);
      const spells = object(p.summonerSpells);
      const spellIds: [string | null, string | null] = [
        resolveSpell(spells.summonerSpellOne),
        resolveSpell(spells.summonerSpellTwo),
      ];
      const inventory =
        Array.isArray(p.items) && p.items.length <= 7
          ? p.items.map((raw) => {
              const i = object(raw);
              return {
                slot: numeric(i.slot, true, 6),
                id: numeric(i.itemID, true),
                count: numeric(i.count, true),
              };
            })
          : null;
      const validInventory =
        inventory &&
        inventory.every((i) => i.slot !== null && i.id !== null) &&
        new Set(inventory.map((i) => i.slot)).size === inventory.length
          ? inventory
          : null;
      const stats = object(p.championStats);
      const healthCurrent = numeric(stats.currentHealth),
        healthMax = numeric(stats.maxHealth);
      const resourceCurrent = numeric(stats.resourceValue),
        resourceMax = numeric(stats.resourceMax);
      return {
        slot,
        playerName: observed(
          cleanPlayerName(p.riotIdGameName) ??
            cleanPlayerName(p.riotId) ??
            cleanPlayerName(p.summonerName),
          capturedAt,
        ),
        itemCounters: observed(
          projectItemCounters(
            Array.isArray(p.items)
              ? p.items.map((raw) => {
                  const i = object(raw);
                  return { id: i.itemID, slot: i.slot, count: i.count };
                })
              : null,
          ),
          capturedAt,
        ),
        team: observed(p.team === "ORDER" || p.team === "CHAOS" ? p.team : null, capturedAt),
        championId: observed(
          champion.id ?? (championId && championId > 0 ? championId : null),
          capturedAt,
        ),
        championMapping: champion.via,
        spells: observed(spellIds.some((id) => id !== null) ? spellIds : null, capturedAt),
        keystone: observed(numeric(object(object(p.runes).keystone).id, true) || null, capturedAt),
        wardScore: observed(numeric(scores.wardScore), capturedAt),
        isDead: observed(typeof p.isDead === "boolean" ? p.isDead : null, capturedAt),
        respawnSeconds: observed(numeric(p.respawnTimer), capturedAt),
        health: observed(
          healthCurrent !== null && healthMax !== null && healthMax > 0
            ? { current: healthCurrent, max: healthMax }
            : null,
          capturedAt,
        ),
        resource: observed(
          resourceCurrent !== null && resourceMax !== null && resourceMax > 0
            ? { current: resourceCurrent, max: resourceMax }
            : null,
          capturedAt,
        ),
        inventory: observed(validInventory, capturedAt),
        level: observed(level && level > 0 ? level : null, capturedAt),
        kills: observed(numeric(scores.kills, true), capturedAt),
        deaths: observed(numeric(scores.deaths, true), capturedAt),
        assists: observed(numeric(scores.assists, true), capturedAt),
        cs: observed(numeric(scores.creepScore, true), capturedAt),
        totalGold: observed(numeric(p.totalGold), capturedAt),
        items: observed(itemIds && itemIds.every((id) => id !== null) ? itemIds : null, capturedAt),
      };
    }),
    events,
    limits: {
      playersTruncated: sourcePlayers.length > 10,
      eventsTruncated: Array.isArray(sourceEvents) && sourceEvents.length > 4096,
    },
  });
}
// Internal correlation only: never export identities, roster strings or the hash.
export function rosterSignature(live: unknown): string {
  const players = object(live).allPlayers;
  if (!Array.isArray(players)) return "no-roster";
  const roster = players.slice(0, 10).map((raw) => {
    const p = object(raw);
    return [p.riotId, p.summonerName, p.team, p.championName, p.championId].map((v) =>
      typeof v === "string" || typeof v === "number" ? v : null,
    );
  });
  return createHash("sha256").update(JSON.stringify(roster)).digest("hex");
}
