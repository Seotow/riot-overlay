// Keeps the shape and the numbers of an LCU end-of-game payload and removes anything that
// identifies a person or grants access. Used by the read-only EOG probe before anything is saved.
const SECRET_KEY =
  /puuid|riotid|gamename|tagline|summonername|summonerid|accountid|playername|displayname|internalname|jwt|channelclaim|multiuserchat|mucjwt|token|password|secret|reportgameid|chatid/i;

export type Redaction = { value: unknown; removed: number };

export function redactEog(input: unknown): Redaction {
  let removed = 0;
  const walk = (value: unknown, depth: number): unknown => {
    if (depth > 12) return "[depth]";
    if (Array.isArray(value)) return value.slice(0, 200).map((v) => walk(v, depth + 1));
    if (value && typeof value === "object") {
      const out: Record<string, unknown> = {};
      for (const [key, v] of Object.entries(value as Record<string, unknown>)) {
        if (SECRET_KEY.test(key)) {
          removed++;
          continue;
        }
        out[key] = walk(v, depth + 1);
      }
      return out;
    }
    // Free text can still carry a Riot ID (Name#TAG); keep numbers/booleans, mask such strings.
    if (typeof value === "string" && /#\w{2,5}$/.test(value)) {
      removed++;
      return "[removed]";
    }
    return value;
  };
  return { value: walk(input, 0), removed };
}

// Compact description of a payload for the log: which stats keys exist and how many players.
export function describeEog(payload: unknown): Record<string, unknown> {
  const data = (payload && typeof payload === "object" ? payload : {}) as Record<string, unknown>;
  const teams = Array.isArray(data.teams) ? (data.teams as Record<string, unknown>[]) : [];
  const players = teams.flatMap((t) =>
    Array.isArray(t?.players) ? (t.players as Record<string, unknown>[]) : [],
  );
  const statsOf = (p: Record<string, unknown>) =>
    p?.stats && typeof p.stats === "object" ? Object.keys(p.stats as object) : [];
  const block =
    data.statsBlock && typeof data.statsBlock === "object"
      ? (data.statsBlock as Record<string, unknown>)
      : null;
  return {
    topLevelKeys: Object.keys(data).slice(0, 60),
    teams: teams.length,
    players: players.length,
    playerStatKeys: [...new Set(players.flatMap(statsOf))].slice(0, 200),
    hasDamageToChampions: players.some((p) =>
      statsOf(p).some((k) => /DAMAGE_DEALT_TO_CHAMPIONS/i.test(k)),
    ),
    statsBlockKeys: block ? Object.keys(block).slice(0, 60) : null,
  };
}
