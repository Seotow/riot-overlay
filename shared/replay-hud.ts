import { z } from "zod";

export const hudFields = {
  interfaceAll: "HUD tổng (cần bật để giữ thông báo)",
  interfaceReplay: "Nhóm HUD replay",
  interfaceScore: "Điểm số mặc định phía trên",
  interfaceScoreboard: "Bảng điểm mặc định",
  interfaceFrames: "Danh sách tướng hai bên",
  interfaceTimeline: "Timeline replay",
  interfaceMinimap: "Minimap",
  interfaceTarget: "Thông tin mục tiêu đang chọn",
  interfaceChat: "Chat",
  interfaceQuests: "Quest mặc định",
  interfaceNeutralTimers: "Timer mục tiêu mặc định",
  interfaceAnnounce: "Announcements (giữ thông báo)",
  interfaceKillCallouts: "Killfeed gốc / Kill Callouts (tắt = ẩn killfeed góc phải)",
} as const;
export type HudKey = keyof typeof hudFields;
export const hudSchema = z
  .object({
    interfaceAll: z.literal(true),
    interfaceReplay: z.literal(true),
    interfaceScore: z.boolean(),
    interfaceScoreboard: z.boolean(),
    interfaceFrames: z.boolean(),
    interfaceTimeline: z.boolean(),
    interfaceMinimap: z.boolean(),
    interfaceTarget: z.boolean(),
    interfaceChat: z.boolean(),
    interfaceQuests: z.boolean(),
    interfaceNeutralTimers: z.boolean(),
    interfaceAnnounce: z.literal(true),
    interfaceKillCallouts: z.boolean(),
  })
  .strict();
export type HudConfig = z.infer<typeof hudSchema>;
export const defaultHud: HudConfig = {
  interfaceAll: true,
  interfaceReplay: true,
  interfaceScore: false,
  interfaceScoreboard: false,
  interfaceFrames: false,
  interfaceTimeline: false,
  interfaceMinimap: true,
  interfaceTarget: true,
  interfaceChat: false,
  interfaceQuests: false,
  interfaceNeutralTimers: false,
  interfaceAnnounce: true,
  // Off: the overlay draws its own killfeed. Verified on a replay: this flag hides the game's one.
  interfaceKillCallouts: false,
};
export function renderHudFields(raw: unknown): Partial<Record<HudKey, boolean>> {
  if (!raw || typeof raw !== "object" || Array.isArray(raw)) return {};
  return Object.fromEntries(
    Object.keys(hudFields).flatMap((key) => {
      const value = (raw as Record<string, unknown>)[key];
      return typeof value === "boolean" ? [[key, value]] : [];
    }),
  );
}
