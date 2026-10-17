// Summoner's Rift PC rules, not measured healing/damage from the provider.
// Reviewed 2026-10-11. Source history and scope: docs/DRAGON_SOUL_RULES.md.
// Keep concise broadcast lines separate from complete tooltip explanations.
export const DRAGON_SOUL_COPY = {
  water: {
    lines: [
      "Damage heals 150+ HP & restores 100+ mana",
      "Over 4s · 30% effect on minions / monsters",
    ],
    detail:
      "Dealing damage heals 150 + 26% bonus AD + 17% AP + 7% bonus health and restores 100 + 3.5% maximum mana over 4 seconds. Minion and monster damage grants 30% of this restoration.",
  },
  earth: {
    lines: ["Gain a 220+ shield after avoiding damage", "Shield refreshes after 5s without damage"],
    detail:
      "After taking no damage for 5 seconds, gain a shield of 220 + 16% bonus AD + 12% AP + 12% bonus health.",
  },
  fire: {
    lines: [
      "Attacks & abilities: 100+ adaptive damage burst",
      "Explosion hits nearby enemies · 3s cooldown",
    ],
    detail:
      "Damaging attacks and abilities trigger an explosion on the target and nearby enemies for 100 + 22.5% bonus AD + 13.5% AP + 2.75% bonus health adaptive damage. Cooldown: 3 seconds.",
  },
  air: {
    lines: [
      "15% move speed · 60% after casting ultimate",
      "Ultimate burst lasts 6s · 30s cooldown",
    ],
    detail:
      "Gain 15% bonus movement speed, increased to 60% for 6 seconds after casting your ultimate ability. Cooldown: 30 seconds.",
  },
  hextech: {
    lines: ["Chain lightning: 25–50 true damage + slow", "45% / 35% slow for 2s · 8s cooldown"],
    detail:
      "Attacks or ability damage trigger 25–50 true damage (level 1–18), chaining to up to 3 additional enemies. Slow: 45% melee / 35% ranged + 3% per 100 bonus AD + 1% per 100 AP + 0.5% per 100 bonus health, decaying over 2 seconds. Cooldown: 8 seconds.",
  },
  chemtech: {
    lines: ["Below 50% HP: deal 13% more damage", "Take 13% less damage while below 50% HP"],
    detail:
      "While below 50% maximum health, deal 13% increased damage and gain 13% damage reduction. This is the reworked Chemtech Soul, not the removed zombie resurrection effect.",
  },
} as const;

export function dragonSoulCopy(key: string) {
  return Object.hasOwn(DRAGON_SOUL_COPY, key)
    ? DRAGON_SOUL_COPY[key as keyof typeof DRAGON_SOUL_COPY]
    : undefined;
}
