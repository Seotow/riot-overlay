import type { Theme } from "./schema";

// seriesGames is the legacy number of wins required, not the best-of length.
export function seriesSlots(theme: Theme) {
  return Math.max(theme.seriesGames ?? 3, theme.blueScore ?? 0, theme.redScore ?? 0);
}

export function swapTeamSides(theme: Theme): Theme {
  return {
    ...theme,
    blueName: theme.redName,
    redName: theme.blueName,
    blueDescription: theme.redDescription,
    redDescription: theme.blueDescription,
    blueLogo: theme.redLogo,
    redLogo: theme.blueLogo,
    blueScore: theme.redScore,
    redScore: theme.blueScore,
    playerNames: theme.playerNames
      ? [...theme.playerNames.slice(5), ...theme.playerNames.slice(0, 5)]
      : undefined,
  };
}
