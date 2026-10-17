import type { Theme } from "./schema";
export const graphicsLabels = {
  pitTimers: "Timer hang rồng / Baron",
  baronPowerplay: "Baron powerplay",
  elderTimer: "Timer buff Elder",
  soulTakeover: "Panel linh hồn rồng",
  objectiveBanners: "Banner mục tiêu / trụ đầu",
  inhibitorTimers: "Timer nhà lính",
  portraitEffects: "Hiệu ứng lên cấp / đồ / quest",
  buffFrames: "Khung buff trên tướng",
} as const;
export type GraphicKey = keyof typeof graphicsLabels;
export function graphicEnabled(theme: Theme, key: GraphicKey) {
  return (
    theme.ingameGraphics?.[key] ??
    (["portraitEffects", "buffFrames"].includes(key) ? true : theme.widgets.objectives)
  );
}
