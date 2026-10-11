import { z } from "zod";
export const rehearsalKindSchema = z.enum([
  "clear",
  "gold",
  "levels",
  "timers",
  "minimal",
  "dragon",
  "soul",
  "baron",
  "cooldowns",
  "death",
  "respawn",
  "tower",
  "inhibitor",
  "inhibitorBlue",
  "inhibitorRed",
  "inhibitorRespawn",
  "level",
  "item",
  "runes",
  "damage",
  "questTop",
  "questJungle",
  "questMid",
  "questBot",
  "questSupport",
]);
export type RehearsalKind = z.infer<typeof rehearsalKindSchema>;
export const dragonTypes = [
  "earth",
  "fire",
  "water",
  "air",
  "hextech",
  "chemtech",
  "elder",
] as const;
export const rehearsalVariantSchema = z
  .object({
    pit: z.enum(["GRUB", "HERALD", "BARON"]).optional(),
    dragon: z.enum(dragonTypes).optional(),
    buffs: z.enum(["baron", "elder", "both"]).optional(),
    inhibitorTeam: z.enum(["ORDER", "CHAOS"]).optional(),
    tower: z.enum(["first", "normal"]).optional(),
  })
  .strict();
export type RehearsalVariant = z.infer<typeof rehearsalVariantSchema>;
export const rehearsalButtons: Array<{ kind: RehearsalKind; label: string }> = [
  { kind: "gold", label: "Leaderboard gold" },
  { kind: "levels", label: "Leaderboard level" },
  { kind: "timers", label: "Timer mục tiêu" },
  { kind: "minimal", label: "Layout tối giản" },
  { kind: "dragon", label: "Hạ rồng" },
  { kind: "soul", label: "Linh hồn rồng" },
  { kind: "baron", label: "Baron Power Play" },
  { kind: "cooldowns", label: "Cooldown item / GA" },
  { kind: "death", label: "Chết / đếm hồi sinh" },
  { kind: "respawn", label: "Hồi sinh" },
  { kind: "tower", label: "Phá trụ" },
  { kind: "inhibitor", label: "Phá nhà lính / timer" },
  { kind: "inhibitorBlue", label: "Timer nhà lính xanh" },
  { kind: "inhibitorRed", label: "Timer nhà lính đỏ" },
  { kind: "inhibitorRespawn", label: "Nhà lính hồi sinh" },
  { kind: "level", label: "Hiệu ứng lên cấp" },
  { kind: "item", label: "Hoàn thành món lớn" },
  { kind: "runes", label: "Rune toàn đội" },
  { kind: "damage", label: "Damage giao tranh" },
  { kind: "questTop", label: "Quest TOP hoàn thành" },
  { kind: "questJungle", label: "Quest JUNGLE hoàn thành" },
  { kind: "questMid", label: "Quest MID hoàn thành" },
  { kind: "questBot", label: "Quest AD hoàn thành" },
  { kind: "questSupport", label: "Quest SUPPORT hoàn thành" },
  { kind: "clear", label: "Ẩn bảng thử / về bình thường" },
];
export type RehearsalDisplay = {
  kind: RehearsalKind;
  variant?: RehearsalVariant;
  previewAt?: number;
  powerPlay?: {
    team: "ORDER" | "CHAOS";
    startedAt: number;
    goldDelta: number;
    endsAt?: number;
    timerSource?: "recorded-buff-loss";
  };
};
