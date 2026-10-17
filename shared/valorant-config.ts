import { z } from "zod";

// Cấu hình trận Valorant do operator nhập (provenance manual). Logo lưu bằng tên file trong
// data/valorant/assets, được frontend module phục vụ ở /uploads; không đưa data URL qua socket trận.
export const logoNameSchema = z.string().regex(/^(?:[a-f0-9]{16}\.(?:png|jpg|webp))?$/);

export const valorantTeamConfigSchema = z.object({
  name: z.string().trim().min(1).max(40),
  tricode: z
    .string()
    .trim()
    .min(1)
    .max(5)
    .transform((value) => value.toUpperCase()),
  logo: logoNameSchema,
});

export const valorantMatchConfigSchema = z
  .object({
    schemaVersion: z.literal(1),
    // Thứ tự khớp hiển thị overlay: đội trái rồi đội phải.
    teams: z.tuple([valorantTeamConfigSchema, valorantTeamConfigSchema]),
    series: z.object({
      needed: z.number().int().min(1).max(9),
      wonLeft: z.number().int().min(0).max(9),
      wonRight: z.number().int().min(0).max(9),
    }),
    tournament: z.object({
      name: z.string().trim().max(80),
      logo: logoNameSchema,
    }),
    nameOverrides: z
      .array(
        z.object({
          player: z.string().trim().min(1).max(60),
          display: z.string().trim().min(1).max(40),
        }),
      )
      .max(20),
  })
  .refine((c) => Math.max(c.series.wonLeft, c.series.wonRight) <= c.series.needed, {
    message: "series-score-over-limit",
  });
export type ValorantMatchConfig = z.infer<typeof valorantMatchConfigSchema>;

export const defaultValorantMatchConfig: ValorantMatchConfig = {
  schemaVersion: 1,
  teams: [
    { name: "Team 1", tricode: "T1", logo: "" },
    { name: "Team 2", tricode: "T2", logo: "" },
  ],
  series: { needed: 1, wonLeft: 0, wonRight: 0 },
  tournament: { name: "", logo: "" },
  nameOverrides: [],
};

export const logoSlots = ["left", "right", "tournament"] as const;
export type LogoSlot = (typeof logoSlots)[number];

// PUT /api/valorant/config: cấu hình + logo mới (data URL) cho các ô vừa chọn.
export const valorantConfigSaveSchema = z.object({
  config: valorantMatchConfigSchema,
  uploads: z
    .object({
      left: z.string().max(520_000).optional(),
      right: z.string().max(520_000).optional(),
      tournament: z.string().max(520_000).optional(),
    })
    .default({}),
});
export type ValorantConfigSave = z.infer<typeof valorantConfigSaveSchema>;

// GET /api/valorant/config: kèm URL để Studio hiển thị logo.
export const valorantConfigViewSchema = z.object({
  config: valorantMatchConfigSchema,
  logoUrls: z.object({ left: z.string(), right: z.string(), tournament: z.string() }),
});
export type ValorantConfigView = z.infer<typeof valorantConfigViewSchema>;

export const LOGO_MAX_BYTES = 350_000;
