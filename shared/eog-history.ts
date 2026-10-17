import { z } from "zod";

// Reduced, anonymous view of the client's match history for one game: objective counters, bans, gold
// per minute and dragon kills. It comes from /lol-match-history/v1/games/{id} and
// /game-timelines/{id}, which a participant's client serves after the match. Nothing identifying is
// kept (no names, ids of accounts, positions or items).

export type EogHistory = {
  gameVersion: string;
  gameDuration: number | null;
  teams: {
    teamId: number;
    towerKills: number | null;
    dragonKills: number | null;
    baronKills: number | null;
    riftHeraldKills: number | null;
    hordeKills: number | null;
    bans: number[];
  }[];
  participants: { participantId: number; teamId: number }[];
  frames: { timestamp: number; gold: Record<string, number> }[];
  dragonEvents: {
    timestamp: number;
    teamId: number | null;
    killerId: number | null;
    subType: string;
  }[];
};

const n = z.number().int().min(0).max(100000000);
export const eogHistorySchema = z
  .object({
    gameVersion: z.string().max(30),
    gameDuration: n.nullable(),
    teams: z
      .array(
        z.object({
          teamId: z.number().int(),
          towerKills: n.nullable(),
          dragonKills: n.nullable(),
          baronKills: n.nullable(),
          riftHeraldKills: n.nullable(),
          hordeKills: n.nullable(),
          bans: z.array(z.number().int().min(1).max(999999)).max(10),
        }),
      )
      .length(2),
    participants: z
      .array(z.object({ participantId: z.number().int(), teamId: z.number().int() }))
      .length(10),
    frames: z.array(z.object({ timestamp: n, gold: z.record(z.string(), n) })).max(2000),
    dragonEvents: z
      .array(
        z.object({
          timestamp: n,
          teamId: z.number().int().nullable(),
          killerId: n.nullable(),
          subType: z.string().max(30),
        }),
      )
      .max(100),
  })
  .strict();

const obj = (v: unknown): Record<string, any> =>
  v && typeof v === "object" && !Array.isArray(v) ? (v as Record<string, any>) : {};
const count = (v: unknown): number | null =>
  typeof v === "number" && Number.isInteger(v) && v >= 0 && v <= 100000000 ? v : null;

export function reduceHistory(detail: unknown, timeline: unknown): EogHistory | null {
  const d = obj(detail);
  const teams = Array.isArray(d.teams) ? d.teams.map(obj) : [];
  const participants = Array.isArray(d.participants) ? d.participants.map(obj) : [];
  if (teams.length !== 2 || participants.length !== 10) return null;
  const frames = Array.isArray(obj(timeline).frames)
    ? (obj(timeline).frames as unknown[]).map(obj)
    : [];
  return {
    gameVersion: typeof d.gameVersion === "string" ? d.gameVersion.slice(0, 30) : "",
    gameDuration: count(d.gameDuration),
    teams: teams.map((t) => ({
      teamId: Number(t.teamId),
      towerKills: count(t.towerKills),
      dragonKills: count(t.dragonKills),
      baronKills: count(t.baronKills),
      riftHeraldKills: count(t.riftHeraldKills),
      hordeKills: count(t.hordeKills),
      bans: (Array.isArray(t.bans) ? t.bans : [])
        .map((b: any) => Number(obj(b).championId))
        .filter((n: number) => Number.isInteger(n) && n > 0 && n < 1000000),
    })),
    participants: participants.map((p) => ({
      participantId: Number(p.participantId),
      teamId: Number(p.teamId),
    })),
    frames: frames
      .slice(0, 2000)
      .filter((f) => count(f.timestamp) !== null)
      .map((f) => ({
        timestamp: f.timestamp as number,
        gold: Object.fromEntries(
          Object.entries(obj(f.participantFrames))
            .map(([id, v]) => [id, count(obj(v).totalGold)] as const)
            .filter(([, g]) => g !== null),
        ) as Record<string, number>,
      })),
    dragonEvents: frames
      .flatMap((f) => (Array.isArray(f.events) ? f.events.map(obj) : []))
      .filter((e) => e.type === "ELITE_MONSTER_KILL" && e.monsterType === "DRAGON")
      .map((e) => ({
        timestamp: count(e.timestamp) ?? 0,
        teamId: [100, 200].includes(e.killerTeamId) ? e.killerTeamId : null,
        killerId: count(e.killerId),
        subType: String(e.monsterSubType ?? "").slice(0, 30),
      })),
  };
}
