import { z } from "zod";
const finite = z.number().finite().nonnegative();
const source = z.enum([
  "live-client",
  "replay-api",
  "leaguebroadcast",
  "league-collector",
  "riot-events",
]);
function field<T extends z.ZodType>(value: T) {
  return z
    .object({
      value: value.nullable(),
      availability: z.enum(["observed", "missing"]),
      source,
      observedAt: z.string().datetime(),
    })
    .strict();
}
export const observedPlayerSchema = z
  .object({
    slot: z.number().int().min(0).max(9),
    playerName: field(z.string().min(1).max(80)).optional(),
    championStacks: field(finite).optional(),
    itemCounters: field(
      z
        .array(
          z
            .object({
              slot: z.number().int().min(0).max(8),
              id: z.number().int().positive(),
              stack: finite.nullable(),
              quantity: z.number().int().nonnegative().nullable(),
            })
            .strict(),
        )
        .max(9),
    ).optional(),
    team: field(z.enum(["ORDER", "CHAOS"])),
    championId: field(z.number().int().positive()),
    championMapping: z.enum(["numeric-id", "raw-code", "display-name", "unmapped"]).optional(),
    spells: field(z.tuple([z.string().nullable(), z.string().nullable()])).optional(),
    keystone: field(z.number().int().positive()).optional(),
    roleQuest: field(
      z
        .object({
          role: z.enum(["top", "jungle", "mid", "bot", "support"]),
          itemId: z.number().int().positive(),
          completed: z.boolean(),
          progress: z.number().min(0).max(1).nullable(),
          rewardItemId: z.number().int().positive().nullable(),
          rewardSpellId: z.string().max(100).nullable(),
        })
        .strict(),
    ).optional(),
    sourceStats: field(z.record(z.string().max(40), z.number().finite().nullable())).optional(),
    perks: field(z.array(z.number().int().positive()).max(9)).optional(),
    wardScore: field(finite).optional(),
    isDead: field(z.boolean()).optional(),
    respawnSeconds: field(finite).optional(),
    hasBaron: field(z.boolean()).optional(),
    hasElder: field(z.boolean()).optional(),
    experience: field(
      z.object({ previousLevel: finite, current: finite, nextLevel: finite }).strict(),
    ).optional(),
    cooldowns: field(
      z
        .array(
          z
            .object({
              kind: z.enum(["item", "ultimate", "spell"]),
              slot: z.string().max(8),
              id: z.number().int().positive().optional(),
              readyAt: finite,
              total: finite,
            })
            .strict(),
        )
        .max(10),
    ).optional(),
    health: field(z.object({ current: finite, max: finite.positive() }).strict()).optional(),
    resource: field(z.object({ current: finite, max: finite.positive() }).strict()).optional(),
    inventory: field(
      z
        .array(
          z
            .object({
              slot: z.number().int().min(0).max(6),
              id: z.number().int().nonnegative(),
              count: z.number().int().nonnegative().nullable(),
            })
            .strict(),
        )
        .max(7),
    ).optional(),
    level: field(z.number().int().min(1).max(30)),
    kills: field(z.number().int().nonnegative()),
    deaths: field(z.number().int().nonnegative()),
    assists: field(z.number().int().nonnegative()),
    cs: field(z.number().int().nonnegative()),
    totalGold: field(finite),
    currentGold: field(finite).optional(),
    items: field(z.array(z.number().int().nonnegative()).max(7)),
  })
  .strict();
export const observedEventSchema = z
  .object({
    id: z.number().int().nonnegative(),
    at: finite,
    kind: z.enum([
      "GameStart",
      "ChampionKill",
      "DragonKill",
      "DragonSoul",
      "BaronKill",
      "HeraldKill",
      "VoidGrubKill",
      "TurretKilled",
      "InhibKilled",
      "InhibRespawned",
      "GameEnd",
      "Ace",
      "LevelUp",
      "ItemCompleted",
      "RoleQuestCompleted",
    ]),
    team: z.enum(["ORDER", "CHAOS"]).optional(),
    firstTurret: z.boolean().optional(),
    goldBaseline: z.object({ own: finite, enemy: finite }).strict().optional(),
    objectiveType: z
      .enum(["fire", "earth", "water", "air", "hextech", "chemtech", "elder", "baron", "herald"])
      .optional(),
    playerSlot: z.number().int().min(0).max(9).optional(),
    killerSlot: z.number().int().min(0).max(9).optional(),
    killerUnitType: z.enum(["minion", "monster", "turret", "grubs"]).optional(),
    killerObjectiveType: z
      .enum(["fire", "earth", "water", "air", "hextech", "chemtech", "elder", "baron", "herald"])
      .optional(),
    victimSlot: z.number().int().min(0).max(9).optional(),
    assistSlots: z.array(z.number().int().min(0).max(9)).max(4).optional(),
    level: z.number().int().min(1).max(30).optional(),
    itemId: z.number().int().positive().optional(),
  })
  .strict();
const observedTeamSchema = z
  .object({
    team: z.enum(["ORDER", "CHAOS"]),
    totalGold: field(finite),
    kills: field(z.number().int().nonnegative()),
    towers: field(z.number().int().nonnegative()),
    towerPlates: field(z.number().int().nonnegative()),
    dragons: field(z.array(z.string().max(64)).max(8)),
    grubs: field(z.number().int().nonnegative()),
    roleQuests: field(
      z
        .array(
          z
            .object({
              role: z.enum(["top", "jungle", "mid", "bot", "support"]),
              itemId: z.number().int().positive(),
              completed: z.boolean(),
              progress: z.number().min(0).max(1).nullable().optional(),
            })
            .strict(),
        )
        .max(5),
    ).optional(),
  })
  .strict();
const observedPitTimerSchema = z
  .object({
    pit: z.enum(["baron", "dragon"]),
    type: field(z.string().max(64)),
    isAlive: field(z.boolean()).optional(),
    timeAlive: field(finite),
    timeDestroy: field(finite),
  })
  .strict();
export const ingameSampleSchema = z
  .object({
    capturedAt: z.string().datetime(),
    gameTime: field(finite),
    assetVersion: z
      .string()
      .regex(/^\d+\.\d+\.\d+$/)
      .optional(),
    assetPatchMatch: z.literal("unverified").optional(),
    mapNumber: field(z.number().int().positive()).optional(),
    replay: z
      .object({
        time: field(finite),
        paused: field(z.boolean()),
        speed: field(finite),
      })
      .strict(),
    players: z.array(observedPlayerSchema).max(10),
    teams: z.array(observedTeamSchema).max(2).optional(),
    pitTimers: z.array(observedPitTimerSchema).max(2).optional(),
    inhibitors: field(
      z
        .array(
          z
            .object({
              team: z.enum(["ORDER", "CHAOS"]),
              lane: z.enum(["top", "mid", "bot"]),
              destroyedAt: finite,
              respawnsAt: finite,
            })
            .strict(),
        )
        .max(6),
    ).optional(),
    events: z.array(observedEventSchema).max(4096),
    eventCoverage: z
      .object({
        historyFromStart: z.boolean(),
        towerEventsComplete: z.boolean(),
        // Riot spectator has omitted dragon events in verified recordings.
        dragonEventsComplete: z.literal(false),
      })
      .strict()
      .optional(),
    limits: z.object({ playersTruncated: z.boolean(), eventsTruncated: z.boolean() }).strict(),
  })
  .strict();
export type IngameSample = z.infer<typeof ingameSampleSchema>;
export type ObservedPlayer = z.infer<typeof observedPlayerSchema>;
export type ObservedEvent = z.infer<typeof observedEventSchema>;
export const observerFrameSchema = z
  .object({
    protocolVersion: z.literal(1),
    sessionId: z.string().uuid().nullable(),
    sequence: z.number().int().nonnegative(),
    epoch: z.number().int().nonnegative(),
    status: z.enum(["idle", "observed", "unavailable"]),
    transition: z.enum(["none", "connected", "reconnected", "source-changed", "seek", "lost"]),
    capturedAt: z.string().datetime(),
    sample: ingameSampleSchema.nullable(),
    newEvents: z.array(observedEventSchema).max(4096),
    playback: z
      .object({
        kind: z.literal("recording"),
        captureId: z.string().max(80),
        recordedAt: z.string().datetime(),
        trigger: z.literal("manual-rehearsal").optional(),
      })
      .strict()
      .optional(),
  })
  .strict();
export type ObserverFrame = z.infer<typeof observerFrameSchema>;
export const recordingSchema = z
  .object({
    version: z.literal(1),
    kind: z.literal("sanitized-observer-recording"),
    exportedAt: z.string().datetime(),
    frames: z.array(observerFrameSchema).max(120),
  })
  .strict();
export type ObserverRecording = z.infer<typeof recordingSchema>;
