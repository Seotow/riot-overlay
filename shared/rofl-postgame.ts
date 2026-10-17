import { z } from "zod";
import { draftCatalog } from "./draft-assets";
import { liveCatalog } from "./live-assets";
import { riotPostgameSchema, type RiotPostgameState } from "./postgame";
import type { LedgerSnapshot } from "./match-ledger";

// Replay (.rofl) metadata -> postgame. The tail of a ROFL2 file holds JSON with the final stats of
// all ten players; only the numbers and the champion are kept (no names, PUUIDs or Riot IDs).

const KEEP = [
  "CHAMPIONS_KILLED",
  "NUM_DEATHS",
  "ASSISTS",
  "GOLD_EARNED",
  "TOTAL_DAMAGE_DEALT_TO_CHAMPIONS",
  "TURRETS_KILLED",
  "BARRACKS_KILLED",
  "BARON_KILLS",
  "RIFT_HERALD_KILLS",
  "HORDE_KILLS",
  "DRAGON_KILLS",
  "ELDER_DRAGON_KILLS",
] as const;
const count = z.number().int().min(0).max(100000000).nullable();
export const roflRowSchema = z
  .object({
    champion: z.string().max(40),
    team: z.union([z.literal(100), z.literal(200)]),
    win: z.boolean().nullable(),
    position: z.string().max(20),
    bot: z.boolean(),
    stats: z.object(Object.fromEntries(KEEP.map((k) => [k, count]))).strict(),
  })
  .strict();
export const roflInputSchema = z
  .object({
    // Game id from the file name (VN2-<id>.rofl); the file itself does not carry a verified match id.
    gameId: z.number().int().min(1).max(1e15),
    gameLengthMs: z.number().int().min(0).max(86_400_000).nullable(),
    rows: z.array(roflRowSchema).length(10),
  })
  .strict();
export type RoflInput = z.infer<typeof roflInputSchema>;

const num = (v: unknown): number | null => {
  const n = typeof v === "string" && /^\d+$/.test(v) ? Number(v) : typeof v === "number" ? v : NaN;
  return Number.isInteger(n) && n >= 0 && n <= 100000000 ? n : null;
};

// Parses the `statsJson` string of the metadata into anonymous rows.
export function reduceRofl(metadata: unknown, gameId: number): RoflInput {
  const root = metadata && typeof metadata === "object" ? (metadata as Record<string, any>) : {};
  const stats = typeof root.statsJson === "string" ? JSON.parse(root.statsJson) : null;
  if (!Array.isArray(stats) || stats.length !== 10) throw Error("invalid-rofl");
  return roflInputSchema.parse({
    gameId,
    gameLengthMs: num(root.gameLength),
    rows: stats.map((p: Record<string, any>) => ({
      champion: String(p?.SKIN ?? "").slice(0, 40),
      team: num(p?.TEAM),
      win: p?.WIN === "Win" ? true : p?.WIN === "Fail" ? false : null,
      position: String(p?.TEAM_POSITION || p?.INDIVIDUAL_POSITION || "").slice(0, 20),
      // A bot has no account: the PUUID is empty. The PUUID itself is never kept.
      bot: !p?.PUUID,
      stats: Object.fromEntries(KEEP.map((k) => [k, num(p?.[k])])),
    })),
  });
}

const positions = ["TOP", "JUNGLE", "MIDDLE", "BOTTOM", "UTILITY"];

// `ledger` is what the collector observed during the same match (matched by game id, or by game
// length when the game id was unknown). It adds dragons and gold over time; each is checked against
// the replay before it is used.
export function normalizeRofl(
  input: RoflInput,
  gameNumber: number,
  now: Date = new Date(),
  ledger: LedgerSnapshot | null = null,
): RiotPostgameState {
  const value = roflInputSchema.parse(input);
  const sides = [100, 200].map((id) => value.rows.filter((r) => r.team === id));
  if (sides.some((s) => s.length !== 5)) throw Error("invalid-rofl");
  const warnings: string[] = [];
  const roleOrderResolved: [boolean, boolean] = [false, false];
  sides.forEach((rows, i) => {
    roleOrderResolved[i] =
      rows.every((r) => positions.includes(r.position)) &&
      new Set(rows.map((r) => r.position)).size === 5;
    if (roleOrderResolved[i])
      rows.sort((a, b) => positions.indexOf(a.position) - positions.indexOf(b.position));
  });
  if (roleOrderResolved.some((v) => !v))
    warnings.push("Replay không ghi vị trí đủ 5 người: hàng damage theo thứ tự trong file.");
  const wins = sides.map((rows) => (rows.every((r) => r.win === rows[0].win) ? rows[0].win : null));
  const winner =
    wins[0] === true && wins[1] === false
      ? "blue"
      : wins[1] === true && wins[0] === false
        ? "red"
        : null;
  const duration =
    value.gameLengthMs !== null && value.gameLengthMs > 0
      ? Math.round(value.gameLengthMs / 1000)
      : null;
  const isFinal = winner !== null && duration !== null;
  if (!isFinal) warnings.push("Replay thiếu winner hoặc thời lượng; chưa coi là kết quả cuối.");
  const sum = (rows: typeof value.rows, key: (typeof KEEP)[number]) => {
    const values = rows.map((r) => r.stats[key]);
    return values.every((v) => v !== null) ? values.reduce<number>((n, v) => n + v!, 0) : null;
  };
  const championId = (name: string) => {
    const c = Object.hasOwn(draftCatalog.champions, name)
      ? draftCatalog.champions[name as keyof typeof draftCatalog.champions]
      : undefined;
    return c ? String(c.key) : null;
  };
  const matches =
    !!ledger &&
    (ledger.gameId !== null
      ? ledger.gameId === value.gameId
      : duration !== null && Math.abs(ledger.lastGameTime - duration) <= 30);
  const lg = matches ? ledger : null;
  // Dragons: only when the kills the collector saw add up exactly to the replay's DRAGON_KILLS per team.
  const dragonSplit = sides.map((rows, i) => {
    const total = rows.reduce<number | null>(
      (n, r) => (n === null || r.stats.DRAGON_KILLS === null ? null : n + r.stats.DRAGON_KILLS),
      0,
    );
    if (!lg || total === null) return null;
    const mine = lg.dragons.filter((d) => d.team === (i === 0 ? "ORDER" : "CHAOS"));
    const elder = mine.filter((d) => d.type === "elder").length;
    return mine.length === total ? { elemental: mine.length - elder, elder } : null;
  });
  const teams = sides.map((rows, side) => ({
    kills: sum(rows, "CHAMPIONS_KILLED"),
    deaths: sum(rows, "NUM_DEATHS"),
    assists: sum(rows, "ASSISTS"),
    gold: sum(rows, "GOLD_EARNED"),
    towers: sum(rows, "TURRETS_KILLED"),
    // DRAGON_KILLS in the file counts every dragon, and ELDER_DRAGON_KILLS contradicts the other
    // sources, so neither split is claimed.
    drakes: dragonSplit[side]?.elemental ?? null,
    elders: dragonSplit[side]?.elder ?? null,
    barons: sum(rows, "BARON_KILLS"),
    heralds: sum(rows, "RIFT_HERALD_KILLS"),
    grubs: sum(rows, "HORDE_KILLS"),
    bans: Array<string | null>(5).fill(null),
    players: rows.map((r) => ({
      champion: championId(r.champion),
      damage: r.stats.TOTAL_DAMAGE_DEALT_TO_CHAMPIONS,
      bot: r.bot,
    })),
  })) as RiotPostgameState["teams"];
  if (teams.some((t) => t.players.some((p) => p.champion === null)))
    warnings.push("Có tướng ngoài bộ ảnh local (15.20.1): ô đó để trống.");
  const dragons = sides.map((rows) => sum(rows, "DRAGON_KILLS"));
  if (dragons.some((d) => d) && dragonSplit.some((d) => d === null))
    warnings.push(
      lg
        ? `Rồng collector thấy không khớp replay (${dragons.join("/")} lượt hạ); không tách nguyên tố và Elder, hai mục rồng giữ —.`
        : `Replay ghi ${dragons.join("/")} lượt hạ rồng (có thể gồm Elder) và không có sổ collector của trận này; hai mục rồng giữ —.`,
    );
  // Gold difference over time (blue - red) from the collector's own samples of this match.
  const goldHistory: RiotPostgameState["goldHistory"] = [];
  if (lg)
    for (const point of lg.gold) {
      if (duration !== null && point.at > duration + 1) continue;
      if (goldHistory.length && point.at <= goldHistory.at(-1)!.at) continue;
      goldHistory.push({
        at: duration !== null ? Math.min(point.at, duration) : point.at,
        delta: point.blue - point.red,
      });
    }
  if (goldHistory.length) {
    warnings.push("Vàng theo thời gian và rồng lấy từ collector trong trận (partial).");
    if (lg!.firstGameTime > 60)
      warnings.push(
        `Collector bắt đầu thu từ ${Math.round(lg!.firstGameTime)} giây: đoạn đầu biểu đồ vàng thiếu.`,
      );
  } else warnings.push("Không có sổ collector của trận này: biểu đồ vàng trống.");
  warnings.push("Replay không có cấm chọn: bans trống.");
  const bots = value.rows.filter((r) => r.bot).length;
  if (bots) warnings.push(`Có ${bots} bot trong trận (không có tài khoản).`);
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
      matchId: `VN2_${value.gameId}`,
      mode: "rofl",
      fetchedAt: now.toISOString(),
      patch: "",
      roleOrderResolved,
      timelineAvailable: goldHistory.length > 0,
      isFinal,
      warnings,
    },
  });
}
