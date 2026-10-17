import type { Theme } from "./schema";
// Team colours used everywhere: the light blue and the dark red. The dark blue (theme.blue) and the
// light red (theme.redSecondary) are no longer used; they stay in the theme only for compatibility.
export const SECONDARY_BLUE = "#0373e0";
export function broadcastColors(theme: Pick<Theme, "blueSecondary" | "red">) {
  return {
    blue:
      !theme.blueSecondary || theme.blueSecondary.toLowerCase() === "#69afd4"
        ? SECONDARY_BLUE
        : theme.blueSecondary,
    red: theme.red,
  };
}
