import { z } from "zod";
export const providerReportSchema = z.object({
  capturedAt: z.string().datetime(),
  selected: z.enum([
    "riot",
    "leaguebroadcast",
    "league-collector",
    "collector-accountless",
    "recording",
  ]),
  output: z.enum([
    "demo",
    "riot",
    "leaguebroadcast",
    "league-collector",
    "collector-accountless",
    "recording",
  ]),
  collector: z
    .object({
      status: z.enum([
        "offline",
        "connecting",
        "waiting",
        "receiving",
        "stale",
        "invalid",
        "stopped",
      ]),
      endpoint: z.string(),
      acceptedFrames: z.number(),
      invalidFrames: z.number(),
      players: z.number(),
      coverage: z.record(z.string(), z.number()),
      lastFrameAt: z.string().nullable(),
      capabilities: z.object({
        fields: z.array(z.string()),
        events: z.boolean(),
        objectives: z.boolean(),
        roleOrderVerified: z.boolean(),
        productionReady: z.boolean(),
      }),
      slotOrder: z.literal("team-hero-index"),
      eventSemantics: z.literal("unverified"),
      runtime: z.object({
        status: z.enum(["stopped", "starting", "running", "external", "failed", "conflict"]),
        error: z.string().nullable(),
        owned: z.boolean(),
        credentialConfigured: z.boolean(),
        withoutAccount: z.boolean().optional(),
        port: z.number(),
      }),
    })
    .optional(),
  recording: z
    .object({
      id: z.string().nullable(),
      frames: z.number(),
      positionMs: z.number(),
      durationMs: z.number(),
      gameTime: z.number().nullable().optional(),
      firstGameTime: z.number().nullable().optional(),
      lastGameTime: z.number().nullable().optional(),
      loadGeneration: z.number().int().nonnegative().optional(),
      playing: z.boolean(),
      speed: z.number(),
    })
    .optional(),
  leaguebroadcast: z.object({
    status: z.enum([
      "offline",
      "connecting",
      "waiting",
      "loading",
      "receiving",
      "stale",
      "restricted",
      "mock",
      "invalid",
    ]),
    lastFrameAt: z.string().datetime().nullable(),
    lastMessageAt: z.string().datetime().nullable(),
    frames: z.number().int().nonnegative(),
    players: z.number().int().nonnegative(),
    fields: z.array(z.string()),
    endpoint: z.literal("ws://127.0.0.1:58869/ws/in"),
    gameStatus: z.enum([
      "unknown",
      "out-of-game",
      "loading",
      "running",
      "paused",
      "mocking",
      "game-over",
      "champion-select",
    ]),
    testingEnvironment: z.boolean().nullable(),
    telemetry: z
      .object({
        status: z.string(),
        updatesPerSecond: z.number().nonnegative(),
      })
      .nullable(),
    assetCache: z
      .object({
        version: z.string().nullable(),
        state: z.string(),
        phase: z.string(),
        readiness: z.string(),
        progressPercent: z.number().nullable(),
        failedAssets: z.number().int().nonnegative(),
      })
      .nullable(),
  }),
});
export type ProviderReport = z.infer<typeof providerReportSchema>;
export const sourceNames: Record<string, string> = {
  "live-client": "Riot Live Client",
  "replay-api": "Riot Replay API",
  "riot-events": "Riot: đếm sự kiện trụ",
  leaguebroadcast: "LeagueBroadcast",
  riot: "Riot local",
  demo: "Demo nội bộ",
  "league-collector": "Collector có tài khoản LB",
  "collector-accountless": "LeagueCollector",
  recording: "Bản ghi offline",
};
export const gameModules = [
  {
    id: "lol",
    name: "League of Legends",
    status: "active",
    description: "In-game / replay, Studio / OBS",
  },
  {
    id: "valorant",
    name: "VALORANT",
    status: "planned",
    description: "Chưa có adapter, phase mở rộng",
  },
] as const;
