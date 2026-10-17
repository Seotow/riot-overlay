import { z } from "zod";

// Contract Valorant tách riêng khỏi LoL. Widget chỉ đọc contract này, không đọc payload Spectra.
// `value` luôn đi kèm availability + provenance; thiếu bằng chứng thì value = null.
export const availabilitySchema = z.enum(["available", "unavailable"]);
export const provenanceSchema = z.enum(["observed", "derived", "manual"]);

const field = <T extends z.ZodType>(value: T) =>
  z.object({
    value: value.nullable(),
    availability: availabilitySchema,
    provenance: provenanceSchema,
  });
export type ValorantField<T> = {
  value: T | null;
  availability: "available" | "unavailable";
  provenance: "observed" | "derived" | "manual";
};

export const valorantPlayerSchema = z.object({
  slot: z.number().int().nonnegative(),
  name: field(z.string()),
  agent: field(z.string()),
  agentLocked: z.boolean(),
  isObserved: z.boolean(),
  isAlive: field(z.boolean()),
  hasSpike: field(z.boolean()),
  health: field(z.number()),
  abilities: z.object({
    grenade: field(z.number()),
    ability1: field(z.number()),
    ability2: field(z.number()),
  }),
  ultimate: z.object({
    points: field(z.number()),
    max: field(z.number()),
    ready: field(z.boolean()),
  }),
  kills: field(z.number()),
  deaths: field(z.number()),
  assists: field(z.number()),
  money: field(z.number()),
  armor: field(z.string()),
  weapon: field(z.string()),
});
export type ValorantPlayer = z.infer<typeof valorantPlayerSchema>;

export const valorantTeamSchema = z.object({
  index: z.number().int().nonnegative(),
  name: field(z.string()),
  isAttacking: z.boolean(),
  roundsWon: z.number().int().nonnegative(),
  players: z.array(valorantPlayerSchema),
});

export const valorantFrameSchema = z.object({
  schemaVersion: z.literal(1),
  game: z.literal("valorant"),
  source: z.literal("spectra"),
  receivedAt: z.string().datetime(),
  sequence: z.number().int().nonnegative(),
  match: z.object({
    running: z.boolean(),
    map: field(z.string()),
    mode: field(z.string()),
    roundNumber: z.number().int().nonnegative(),
    roundPhase: field(z.enum(["LOBBY", "shopping", "combat", "end", "game_end"])),
    // Mốc +99 giây do Spectra Server tự cộng, không phải đồng hồ game.
    roundEndsAt: field(z.number()),
    spike: z.object({
      planted: field(z.boolean()),
      detonated: field(z.boolean()),
      defused: field(z.boolean()),
    }),
  }),
  teams: z.array(valorantTeamSchema).length(2),
  // Trạng thái do operator bấm tay trong Studio (provenance manual), không phải telemetry game.
  controls: z.object({
    techPause: z.boolean(),
    leftTimeout: z.boolean(),
    rightTimeout: z.boolean(),
    timeoutRemaining: z.number().nonnegative(),
    showAliveKda: z.boolean(),
    toast: z.object({ active: z.boolean(), title: z.string(), message: z.string() }),
  }),
  coverage: z.object({
    players: z.number().int().nonnegative(),
    scoreboard: z.number().int().nonnegative(),
    health: z.number().int().nonnegative(),
    abilities: z.number().int().nonnegative(),
  }),
});
export type ValorantFrame = z.infer<typeof valorantFrameSchema>;

export const valorantStatusSchema = z.object({
  status: z.enum(["offline", "connecting", "waiting", "receiving", "stale", "invalid"]),
  endpoint: z.string(),
  groupCode: z.string(),
  acceptedFrames: z.number().int().nonnegative(),
  invalidFrames: z.number().int().nonnegative(),
  lastFrameAt: z.string().datetime().nullable(),
  // Spectra chỉ phát khi có sự kiện mới, nên im lặng chưa chắc là nguồn chết.
  quietIsNotDead: z.literal(true),
  gameTelemetryVerified: z.literal(false),
});
export type ValorantStatus = z.infer<typeof valorantStatusSchema>;

// Lệnh thủ công của Spectra Client mà Studio được phép gửi (Studio → Client fork → ingest).
export const valorantCommandSchema = z.discriminatedUnion("command", [
  z.object({ command: z.literal("spike_planted") }),
  z.object({ command: z.literal("tech_pause") }),
  z.object({ command: z.literal("left_timeout") }),
  z.object({ command: z.literal("right_timeout") }),
  z.object({ command: z.literal("switch_kda_credits") }),
  z.object({ command: z.literal("swap_left_right") }),
  z.object({ command: z.literal("swap_attacker_defender") }),
  z.object({ command: z.literal("apply_config") }),
  z.object({
    command: z.literal("toast"),
    title: z.string().max(80),
    message: z.string().max(200),
    duration: z.number().int().min(1000).max(60000).nullable(),
  }),
]);
export type ValorantCommand = z.infer<typeof valorantCommandSchema>;
