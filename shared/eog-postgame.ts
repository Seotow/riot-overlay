import { liveCatalog } from "./live-assets";
import type { EogHistory } from "./eog-history";
import { riotPostgameSchema, type RiotPostgameState } from "./postgame";

// Turns an LCU end-of-game block (/lol-end-of-game/v1/eog-stats-block, as saved by the EOG probe)
// into the postgame contract. Only numbers and champion ids are read: no names, PUUIDs or
// Riot IDs are carried over, and anything the block does not contain stays null.

const obj = (v: unknown): Record<string, any> =>
  v && typeof v === "object" && !Array.isArray(v) ? (v as Record<string, any>) : {};
const num = (v: unknown): number | null =>
  typeof v === "number" && Number.isInteger(v) && v >= 0 && v <= 100000000 ? v : null;
const positions = ["TOP", "JUNGLE", "MIDDLE", "BOTTOM", "UTILITY"];

const ELEMENTAL = [
  "FIRE_DRAGON",
  "EARTH_DRAGON",
  "WATER_DRAGON",
  "AIR_DRAGON",
  "HEXTECH_DRAGON",
  "CHEMTECH_DRAGON",
];

// `history` is the optional match history of the same game (objectives, bans, gold per minute) read
// from the participant's client. Without it those fields stay empty.
export function normalizeEog(
  raw: unknown,
  gameNumber: number,
  now: Date = new Date(),
  history: EogHistory | null = null,
): RiotPostgameState {
  const root = obj(raw);
  const gameId = Number(root.gameId);
  const teamRows = Array.isArray(root.teams) ? root.teams.map(obj) : [];
  if (!Number.isInteger(gameId) || gameId <= 0 || teamRows.length !== 2) throw Error("invalid-eog");
  const sides = [100, 200].map((id) => {
    const rows = teamRows.filter((t) => t.teamId === id);
    if (rows.length !== 1) throw Error("invalid-eog");
    const players = Array.isArray(rows[0].players) ? rows[0].players.map(obj) : [];
    if (players.length !== 5) throw Error("invalid-eog");
    return { team: rows[0], players };
  });
  const warnings: string[] = [];
  const stat = (p: Record<string, any>, key: string) => num(obj(p.stats)[key]);

  // Lane order from the client's detected position; otherwise the order the client listed them.
  const roleOrderResolved: [boolean, boolean] = [false, false];
  sides.forEach((side, i) => {
    const found = side.players.map((p) => String(p.detectedTeamPosition ?? ""));
    roleOrderResolved[i] = found.every((r) => positions.includes(r)) && new Set(found).size === 5;
    if (roleOrderResolved[i])
      side.players.sort(
        (a, b) =>
          positions.indexOf(a.detectedTeamPosition) - positions.indexOf(b.detectedTeamPosition),
      );
  });
  if (roleOrderResolved.some((v) => !v))
    warnings.push("Client không trả đủ 5 vị trí duy nhất: hàng damage theo thứ tự client liệt kê.");
  else
    warnings.push("Vị trí lấy từ detectedTeamPosition của client; cần đối chiếu roster của giải.");

  const winFlags = sides.map((s) =>
    typeof s.team.isWinningTeam === "boolean" ? s.team.isWinningTeam : null,
  );
  const winner =
    winFlags[0] === true && winFlags[1] === false
      ? "blue"
      : winFlags[1] === true && winFlags[0] === false
        ? "red"
        : null;
  const duration = num(root.gameLength);
  const isFinal = winner !== null && duration !== null && duration > 0 && root.invalid !== true;
  if (!isFinal) warnings.push("Kết quả/thời lượng chưa đầy đủ hoặc trận không hợp lệ.");

  const sum = (players: Record<string, any>[], key: string) => {
    const values = players.map((p) => stat(p, key));
    return values.every((v) => v !== null) ? values.reduce<number>((n, v) => n + v!, 0) : null;
  };
  const championId = (n: unknown) => (num(n) && Number(n) <= 999999 ? String(n) : null);
  // History counters apply only when the history belongs to this game and names both teams.
  const h =
    history && [100, 200].every((id) => history.teams.filter((t) => t.teamId === id).length === 1)
      ? history
      : null;
  const ht = (side: number) => h?.teams.find((t) => t.teamId === [100, 200][side]);
  const teamOfParticipant = new Map(h?.participants.map((p) => [p.participantId, p.teamId]) ?? []);
  // Dragon split only when every kill is attributed and the kinds add up to the client's counter.
  const dragons = [0, 1].map((side) => {
    if (!h) return null;
    const mine = h.dragonEvents.filter(
      (e) => (e.teamId ?? teamOfParticipant.get(e.killerId ?? -1)) === [100, 200][side],
    );
    const total = ht(side)?.dragonKills ?? null;
    const known = mine.every((e) => ELEMENTAL.includes(e.subType) || e.subType === "ELDER_DRAGON");
    const attributed = h.dragonEvents.every(
      (e) => (e.teamId ?? teamOfParticipant.get(e.killerId ?? -1)) !== undefined,
    );
    const elder = mine.filter((e) => e.subType === "ELDER_DRAGON").length;
    const elemental = mine.length - elder;
    return known && attributed && total !== null && (total === mine.length || total === elemental)
      ? { elemental, elder }
      : null;
  });
  const teams = sides.map(({ players }, side) => ({
    kills: sum(players, "CHAMPIONS_KILLED"),
    deaths: sum(players, "NUM_DEATHS"),
    assists: sum(players, "ASSISTS"),
    gold: sum(players, "GOLD_EARNED"),
    towers: sum(players, "TURRETS_KILLED") ?? ht(side)?.towerKills ?? null,
    drakes: dragons[side]?.elemental ?? null,
    elders: dragons[side]?.elder ?? null,
    barons: sum(players, "BARON_KILLS") ?? ht(side)?.baronKills ?? null,
    heralds: sum(players, "RIFT_HERALD_KILLS") ?? ht(side)?.riftHeraldKills ?? null,
    grubs: sum(players, "HORDE_KILLS") ?? ht(side)?.hordeKills ?? null,
    bans: Array.from({ length: 5 }, (_, i) => {
      const id = ht(side)?.bans[i];
      return id ? String(id) : null;
    }),
    players: players.map((p) => ({
      champion: championId(p.championId),
      damage: stat(p, "TOTAL_DAMAGE_DEALT_TO_CHAMPIONS"),
      bot: p.botPlayer === true,
    })),
  })) as RiotPostgameState["teams"];

  // Gold difference per frame: blue total minus red total, null when a participant is missing.
  const goldHistory: RiotPostgameState["goldHistory"] = [];
  if (h)
    for (const frame of h.frames) {
      const at = frame.timestamp / 1000;
      if (duration !== null && at > duration + 1) continue;
      if (goldHistory.length && at <= goldHistory.at(-1)!.at) continue;
      const total = [100, 200].map((id) => {
        const ids = h.participants
          .filter((p) => p.teamId === id)
          .map((p) => String(p.participantId));
        return ids.length === 5 && ids.every((x) => frame.gold[x] !== undefined)
          ? ids.reduce((n, x) => n + frame.gold[x], 0)
          : null;
      });
      goldHistory.push({
        at: duration !== null ? Math.min(at, duration) : at,
        delta: total[0] === null || total[1] === null ? null : total[0] - total[1],
      });
    }

  if (teams.some((t) => t.players.some((p) => p.damage === null)))
    warnings.push("Một số người thiếu damage to champions; hiển thị 0, không suy từ nguồn khác.");
  if (!h)
    warnings.push(
      "Không có lịch sử trận của client: cấm chọn, rồng, Baron, Sứ giả, Sâu và biểu đồ vàng hiển thị 0 hoặc trống.",
    );
  else {
    if (dragons.some((d) => d === null))
      warnings.push(
        "Không tách được rồng nguyên tố/Elder khớp bộ đếm của client; hai mục rồng hiển thị 0.",
      );
    if (teams.every((t) => t.bans.every((b) => b === null)))
      warnings.push("Lịch sử trận không có cấm chọn (trận custom/practice); bans để trống.");
    if (!goldHistory.length) warnings.push("Timeline của client không có dữ liệu vàng.");
  }
  const bots = teams.reduce((n, t) => n + t.players.filter((p) => (p as any).bot).length, 0);
  if (bots) warnings.push(`Có ${bots} bot trong trận (botPlayer).`);
  const patch =
    h && /^\d{1,3}\.\d{1,3}\.\d{1,10}(?:\.\d{1,10})?$/.test(h.gameVersion) ? h.gameVersion : "";

  return riotPostgameSchema.parse({
    version: 2,
    source: "riot",
    assetVersion: liveCatalog.version,
    gameNumber,
    duration,
    winner,
    teams,
    goldHistory,
    evidence: {
      matchId: `LCU_${gameId}`,
      mode: "lcu-eog",
      fetchedAt: now.toISOString(),
      patch,
      roleOrderResolved,
      timelineAvailable: goldHistory.length > 0,
      isFinal,
      warnings,
    },
  });
}
