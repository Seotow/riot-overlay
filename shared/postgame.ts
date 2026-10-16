import { z } from "zod";
import { draftChampion } from "./draft-assets";

const count = z.number().int().min(0).max(100000000).nullable();
const champion = z
  .string()
  .max(40)
  .refine((id) => !!draftChampion(id), "Không có asset tướng này")
  .nullable();
export const postgameRoles = [
  "TOP",
  "JUNGLE",
  "MID",
  "BOT",
  "SUPPORT",
] as const;
const team = z.object({
  kills: count,
  deaths: count,
  assists: count,
  gold: count,
  towers: count,
  drakes: count,
  elders: count,
  barons: count,
  heralds: count,
  grubs: count,
  bans: z.array(champion).length(5),
  // Fixed lane order: TOP, JUNGLE, MID, BOT, SUPPORT. Missing damage remains null.
  players: z.array(z.object({ champion, damage: count })).length(5),
});
export const postgameSampleSchema = z
  .object({
    version: z.literal(1),
    source: z.literal("sample"),
    assetVersion: z.literal("15.20.1"),
    gameNumber: z.number().int().min(1).max(99),
    duration: z.number().int().min(0).max(86400).nullable(),
    winner: z.enum(["blue", "red"]).nullable(),
    teams: z.tuple([team, team]),
    // Signed delta = BLUE gold - RED gold. null breaks the curve, not a zero.
    goldHistory: z
      .array(
        z.object({
          at: z.number().int().min(0).max(86400),
          delta: z.number().finite().min(-100000000).max(100000000).nullable(),
        }),
      )
      .max(2000),
  })
  .superRefine((p, ctx) => {
    p.goldHistory.forEach((point, i) => {
      if (i && point.at <= p.goldHistory[i - 1].at)
        ctx.addIssue({
          code: "custom",
          path: ["goldHistory", i, "at"],
          message: "Mốc thời gian phải tăng dần",
        });
      if (p.duration !== null && point.at > p.duration)
        ctx.addIssue({
          code: "custom",
          path: ["goldHistory", i, "at"],
          message: "Mốc vượt thời gian trận",
        });
    });
  });
export const riotPostgameSchema = z
  .object({
    version: z.literal(2),
    source: z.literal("riot"),
    assetVersion: z.string().regex(/^\d+\.\d+\.\d+$/),
    gameNumber: z.number().int().min(1).max(99),
    duration: z.number().int().min(0).max(86400).nullable(),
    winner: z.enum(["blue", "red"]).nullable(),
    teams: z.tuple([
      team.extend({
        bans: z
          .array(
            z
              .string()
              .regex(/^\d{1,6}$/)
              .nullable(),
          )
          .length(5),
        players: z
          .array(
            z.object({
              champion: z
                .string()
                .regex(/^\d{1,6}$/)
                .nullable(),
              damage: count,
            }),
          )
          .length(5),
      }),
      team.extend({
        bans: z
          .array(
            z
              .string()
              .regex(/^\d{1,6}$/)
              .nullable(),
          )
          .length(5),
        players: z
          .array(
            z.object({
              champion: z
                .string()
                .regex(/^\d{1,6}$/)
                .nullable(),
              damage: count,
            }),
          )
          .length(5),
      }),
    ]),
    goldHistory: z
      .array(
        z.object({
          at: z.number().finite().min(0).max(86400),
          delta: z.number().finite().min(-100000000).max(100000000).nullable(),
        }),
      )
      .max(2000),
    evidence: z
      .object({
        matchId: z.string().regex(/^VN2_\d{1,20}$/),
        mode: z.enum(["standard", "rso"]),
        fetchedAt: z.string().datetime(),
        patch: z.string().max(40),
        roleOrderResolved: z.tuple([z.boolean(), z.boolean()]),
        timelineAvailable: z.boolean(),
        isFinal: z.boolean(),
        warnings: z.array(z.string().max(180)).max(20),
      })
      .strict(),
  })
  .superRefine((p, ctx) => {
    p.goldHistory.forEach((point, i) => {
      if (
        (i && point.at <= p.goldHistory[i - 1].at) ||
        (p.duration !== null && point.at > p.duration)
      )
        ctx.addIssue({
          code: "custom",
          path: ["goldHistory", i],
          message: "Timeline không hợp lệ",
        });
    });
  });
export const postgameSchema = z.union([
  postgameSampleSchema,
  riotPostgameSchema,
]);
export type PostgameState = z.infer<typeof postgameSchema>;
export type RiotPostgameState = z.infer<typeof riotPostgameSchema>;
export function samplePostgame(): z.infer<typeof postgameSampleSchema> {
  const make = (red: boolean) => ({
    kills: red ? 7 : 20,
    deaths: red ? 20 : 7,
    assists: red ? 17 : 43,
    gold: red ? 54800 : 66800,
    towers: red ? 2 : 10,
    drakes: red ? 1 : 4,
    elders: 0,
    barons: red ? 0 : 1,
    heralds: red ? 0 : 1,
    grubs: red ? 0 : 3,
    bans: red
      ? ["Akali", "Sylas", "Renekton", "Ahri", "Poppy"]
      : ["Gnar", "Vi", "Leona", "Anivia", "Kalista"],
    players: (red
      ? ["Renekton", "LeeSin", "Ahri", "Ezreal", "Rakan"]
      : ["Gnar", "XinZhao", "Annie", "Varus", "Alistar"]
    ).map((champion, i) => ({
      champion,
      damage: (red
        ? [12900, 11500, 15200, 23100, 4000]
        : [18200, 16500, 16200, 35000, 4600])[i],
    })),
  });
  return postgameSampleSchema.parse({
    version: 1,
    source: "sample",
    assetVersion: "15.20.1",
    gameNumber: 1,
    duration: 1938,
    winner: "blue",
    teams: [make(false), make(true)],
    goldHistory: [
      0, 120, 240, 360, 480, 600, 720, 840, 960, 1080, 1200, 1320, 1440, 1560,
      1680, 1800, 1938,
    ].map((at, i) => ({
      at,
      delta: [
        0, 200, 900, 600, 1600, 1500, 1200, -100, 600, 1300, -300, 1800, 3200,
        3900, 3600, 4800, 12000,
      ][i],
    })),
  });
}
export function goldSegments(points: PostgameState["goldHistory"]) {
  const segments: { at: number; delta: number }[][] = [];
  let current: { at: number; delta: number }[] = [];
  for (const p of points) {
    if (p.delta === null) {
      if (current.length) segments.push(current);
      current = [];
    } else current.push({ at: p.at, delta: p.delta });
  }
  if (current.length) segments.push(current);
  return segments;
}
