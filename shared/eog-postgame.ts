import { liveCatalog } from "./live-assets";
import { riotPostgameSchema, type RiotPostgameState } from "./postgame";

// Turns an LCU end-of-game block (/lol-end-of-game/v1/eog-stats-block, as saved by the EOG probe)
// into the postgame contract. Only numbers and champion ids are read: no names, PUUIDs or
// Riot IDs are carried over, and anything the block does not contain stays null.

const obj = (v: unknown): Record<string, any> =>
  v && typeof v === "object" && !Array.isArray(v) ? (v as Record<string, any>) : {};
const num = (v: unknown): number | null =>
  typeof v === "number" && Number.isInteger(v) && v >= 0 && v <= 100000000 ? v : null;
const positions = ["TOP", "JUNGLE", "MIDDLE", "BOTTOM", "UTILITY"];

export function normalizeEog(
  raw: unknown,
  gameNumber: number,
  now: Date = new Date(),
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
  const teams = sides.map(({ players }) => ({
    kills: sum(players, "CHAMPIONS_KILLED"),
    deaths: sum(players, "NUM_DEATHS"),
    assists: sum(players, "ASSISTS"),
    gold: sum(players, "GOLD_EARNED"),
    towers: sum(players, "TURRETS_KILLED"),
    // The block has no per-objective counters for these, and no bans: left empty, never zero.
    drakes: null,
    elders: null,
    barons: sum(players, "BARON_KILLS"),
    heralds: sum(players, "RIFT_HERALD_KILLS"),
    grubs: sum(players, "HORDE_KILLS"),
    bans: Array<string | null>(5).fill(null),
    players: players.map((p) => ({
      champion: championId(p.championId),
      damage: stat(p, "TOTAL_DAMAGE_DEALT_TO_CHAMPIONS"),
      bot: p.botPlayer === true,
    })),
  })) as RiotPostgameState["teams"];
  if (teams.some((t) => t.players.some((p) => p.damage === null)))
    warnings.push("Một số người thiếu damage to champions; giữ —, không suy từ nguồn khác.");
  if (teams.some((t) => t.drakes === null))
    warnings.push("EOG không tách rồng nguyên tố/Elder; hai mục rồng giữ —.");
  if (teams.some((t) => t.barons === null || t.heralds === null || t.grubs === null))
    warnings.push("EOG không có đếm Baron/Sứ giả/Sâu cho trận này; các mục đó giữ —.");
  warnings.push("EOG không có cấm/chọn và lịch sử vàng: bans và biểu đồ vàng trống.");
  const bots = teams.reduce((n, t) => n + t.players.filter((p) => (p as any).bot).length, 0);
  if (bots) warnings.push(`Có ${bots} bot trong trận (botPlayer).`);

  return riotPostgameSchema.parse({
    version: 2,
    source: "riot",
    assetVersion: liveCatalog.version,
    gameNumber,
    duration,
    winner,
    teams,
    goldHistory: [],
    evidence: {
      matchId: `LCU_${gameId}`,
      mode: "lcu-eog",
      fetchedAt: now.toISOString(),
      patch: "",
      roleOrderResolved,
      timelineAvailable: false,
      isFinal,
      warnings,
    },
  });
}
