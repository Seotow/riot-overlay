import { liveItem } from "./live-assets";
export type QuestRole = "top" | "jungle" | "mid" | "bot" | "support";
export const questRoles: Record<number, QuestRole> = {
  1200: "top",
  1201: "mid",
  1202: "bot",
  1203: "support",
  1204: "jungle",
  1205: "jungle",
  1206: "mid",
  1207: "bot",
  1208: "support",
  1209: "jungle",
  1210: "jungle",
  1211: "jungle",
  1220: "top",
  1221: "top",
  1222: "top",
};
export const completedQuestIds = new Set([
  1205, 1206, 1207, 1208, 1209, 1210, 1211, 1220, 1221,
]);
export const bootIds = new Set([
  1001, 3006, 3009, 3020, 3047, 3111, 3117, 3158, 2422, 3170, 3171, 3172, 3173,
  3174, 3175, 3176, 3177,
]);
// Exclusions concern broadcast cooldown presentation, never remove actual inventory.
export const excludedCooldownItems = new Set([
  2003, 2004, 2009, 2010, 2031, 2032, 2033, 2043, 2044, 2055, 2138, 2139, 2140,
  2150, 2151, 2152, 2153, 2154, 2161, 2162, 3363, 3364, 3340, 3341, 3513,
]);
export function showItemCooldown(id: number | null | undefined) {
  if (id == null || excludedCooldownItems.has(id)) return false;
  const name = liveItem(id)?.name ?? "";
  return !/potion|biscuit|ward|elixir|scry|sweeper/i.test(name);
}
