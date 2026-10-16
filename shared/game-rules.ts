// Default broadcast rules, in game-clock seconds; not wall-clock time.
export const INHIBITOR_RESPAWN_SECONDS = 300;
export const BARON_BUFF_SECONDS = 180;
export const ELDER_BUFF_SECONDS = 150;
// SR defaults. Reported provider timers take precedence; practice-tool spawns
// may differ. Riot 25.09: Grubs8m/no respawn, Herald15m; Riot26.1: Baron20m.
export const PIT_RULES = {
  dragonFirst: 300,
  dragonRespawn: 300,
  elderRespawn: 360,
  grubsFirst: 480,
  heraldFirst: 900,
  baronFirst: 1200,
  baronRespawn: 360,
} as const;
