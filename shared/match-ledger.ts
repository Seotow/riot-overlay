// What the collector observed during a match, kept small and anonymous: gold per team over game
// time and the dragon kills it saw. Used to fill what a replay file does not contain.
export type LedgerDragon = { at: number; team: "ORDER" | "CHAOS"; type: string };
export type LedgerSnapshot = {
  gameId: number | null;
  firstGameTime: number;
  lastGameTime: number;
  gold: { at: number; blue: number; red: number }[];
  dragons: LedgerDragon[];
};
