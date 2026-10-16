import type { Theme } from "./schema";
// Sampled from the supplied XP ranking screenshot; compressed-image approximation.
export const SECONDARY_BLUE = "#0373e0";
export const SECONDARY_RED = "#ba191c";
export function broadcastColors(theme: Pick<Theme, "blueSecondary" | "redSecondary">) {
  return {
    blue: !theme.blueSecondary || theme.blueSecondary.toLowerCase() === "#69afd4" ? SECONDARY_BLUE : theme.blueSecondary,
    red: !theme.redSecondary || theme.redSecondary.toLowerCase() === "#df7d86" ? SECONDARY_RED : theme.redSecondary,
  };
}
