import { z } from "zod";
import { liveCatalog } from "../shared/live-assets";
import { riotPostgameSchema, type RiotPostgameState } from "../shared/postgame";

export const riotCredentialSchema = z
  .object({
    mode: z.enum(["standard", "rso"]),
    secret: z
      .string()
      .trim()
      .min(12)
      .max(8192)
      .regex(/^[\x21-\x7e]+$/),
  })
  .strict();
export const riotLoadSchema = z
  .object({
    matchId: z
      .string()
      .trim()
      .regex(/^VN2_\d{1,20}$/, "Dùng Riot match ID dạng VN2_123456"),
    gameNumber: z.number().int().min(1).max(99),
  })
  .strict();
const obj = (v: unknown): Record<string, any> =>
  v && typeof v === "object" && !Array.isArray(v)
    ? (v as Record<string, any>)
    : {};
const num = (v: unknown): number | null =>
  typeof v === "number" && Number.isInteger(v) && v >= 0 && v <= 100000000
    ? v
    : null;
const roles = ["TOP", "JUNGLE", "MIDDLE", "BOTTOM", "UTILITY"];
export function normalizeRiotPostgame(
  raw: unknown,
  timeline: unknown,
  matchId: string,
  mode: "standard" | "rso",
  gameNumber: number,
): RiotPostgameState {
  const root = obj(raw),
    info = obj(root.info);
  if (obj(root.metadata).matchId !== matchId || info.platformId !== "VN2")
    throw Error("invalid-match");
  const players = info.participants;
  const teamRows = info.teams;
  if (
    !Array.isArray(players) ||
    players.length !== 10 ||
    !Array.isArray(teamRows) ||
    teamRows.length !== 2 ||
    new Set(players.map((p) => p.participantId)).size !== 10 ||
    players.some(
      (p) =>
        ![100, 200].includes(p.teamId) ||
        !Number.isInteger(p.participantId) ||
        p.participantId < 1 ||
        p.participantId > 10,
    )
  )
    throw Error("invalid-roster");
  const warnings: string[] = [];
  const patch =
    typeof info.gameVersion === "string" &&
    /^\d{1,3}\.\d{1,3}\.\d{1,10}(?:\.\d{1,10})?$/.test(info.gameVersion)
      ? info.gameVersion
      : "";
  const patchParts = patch.split(".").map(Number);
  const modern =
    patchParts[0] > 11 || (patchParts[0] === 11 && patchParts[1] >= 20);
  const durationValue = num(info.gameDuration);
  const duration =
    durationValue === null
      ? null
      : modern || num(info.gameEndTimestamp) !== null
        ? durationValue
        : patchParts[0] > 0
          ? Math.floor(durationValue / 1000)
          : null;
  if (duration !== null && duration > 86400) throw Error("invalid-duration");
  const roleOrderResolved: [boolean, boolean] = [false, false];
  const roster = [100, 200].map((id, side) => {
    const p = players.filter((p) => p.teamId === id);
    if (p.length !== 5) throw Error("invalid-roster");
    roleOrderResolved[side] =
      p.every((p) => roles.includes(p.teamPosition)) &&
      new Set(p.map((p) => p.teamPosition)).size === 5;
    return p.sort((a, b) =>
      roleOrderResolved[side]
        ? roles.indexOf(a.teamPosition) - roles.indexOf(b.teamPosition)
        : a.participantId - b.participantId,
    );
  });
  const byTeam = [100, 200].map((id) => {
    const matches = teamRows.filter((t) => t.teamId === id);
    if (matches.length !== 1) throw Error("invalid-teams");
    return matches[0];
  });
  const win = byTeam.map((t) => (typeof t.win === "boolean" ? t.win : null));
  const winner =
    win[0] === true && win[1] === false
      ? "blue"
      : win[1] === true && win[0] === false
        ? "red"
        : null;
  const isFinal =
    winner !== null &&
    duration !== null &&
    (typeof info.endOfGameResult !== "string" ||
      !/abort|terminate/i.test(info.endOfGameResult));
  if (!isFinal)
    warnings.push(
      "Kết quả/thời lượng chưa đầy đủ hoặc trận bị hủy; chưa coi là kết quả cuối hợp lệ.",
    );
  if (roleOrderResolved.some((v) => !v))
    warnings.push(
      "Riot không trả đủ 5 vị trí duy nhất: hàng damage sẽ dùng thứ tự participant, không giả TOP/JUNGLE.",
    );
  warnings.push(
    "Role có sẵn được xếp theo teamPosition dự đoán của Riot; cần đối chiếu roster của giải.",
  );
  if (
    !patch.startsWith(
      liveCatalog.version.split(".").slice(0, 2).join(".") + ".",
    )
  )
    warnings.push(
      "Patch trận khác bộ ảnh local; số liệu không đổi, ảnh tướng cần đối chiếu version.",
    );
  const ti = obj(obj(timeline).info);
  const timelineAvailable =
    obj(obj(timeline).metadata).matchId === matchId &&
    Array.isArray(ti.frames) &&
    ti.frames.length > 0 &&
    ti.frames.length <= 2000;
  const goldHistory: RiotPostgameState["goldHistory"] = [];
  if (timelineAvailable) {
    for (const frame of ti.frames) {
      if (num(frame.timestamp) === null) continue;
      const at = frame.timestamp / 1000;
      if (duration !== null && at > duration) continue;
      if (goldHistory.length && at <= goldHistory.at(-1)!.at)
        throw Error("invalid-timeline-order");
      const gold = roster.map((ps) => {
        const values = ps.map((p) =>
          num(
            obj(obj(frame.participantFrames)[String(p.participantId)])
              .totalGold,
          ),
        );
        return values.every((v) => v !== null)
          ? values.reduce<number>((n, v) => n + v!, 0)
          : null;
      });
      goldHistory.push({
        at,
        delta: gold.some((v) => v === null) ? null : gold[0]! - gold[1]!,
      });
    }
  } else
    warnings.push(
      "Không có timeline hợp lệ: chưa có biểu đồ vàng; không dùng số liệu mẫu để lấp.",
    );
  // No fabricated Elder split: require complete timeline plus recognized kill details and counter agreement.
  let dragonCounts: { elemental: number; elder: number }[] | null = null;
  if (
    timelineAvailable &&
    duration !== null &&
    ti.frames[0].timestamp <= 2000 &&
    ti.frames.at(-1).timestamp / 1000 >=
      duration - Math.max(1, (num(ti.frameInterval) ?? 60000) / 1000)
  ) {
    const counts = [
      { elemental: 0, elder: 0 },
      { elemental: 0, elder: 0 },
    ];
    let valid = ti.frames.every((f: any) => Array.isArray(f.events));
    for (const frame of ti.frames)
      for (const e of frame.events ?? []) {
        if (e.type !== "ELITE_MONSTER_KILL" || e.monsterType !== "DRAGON")
          continue;
        const side = [100, 200].indexOf(
          e.killerTeamId ??
            players.find((p) => p.participantId === e.killerId)?.teamId,
        );
        if (side < 0) {
          valid = false;
          continue;
        }
        if (e.monsterSubType === "ELDER_DRAGON") counts[side].elder++;
        else if (
          [
            "FIRE_DRAGON",
            "EARTH_DRAGON",
            "WATER_DRAGON",
            "AIR_DRAGON",
            "HEXTECH_DRAGON",
            "CHEMTECH_DRAGON",
          ].includes(e.monsterSubType)
        )
          counts[side].elemental++;
        else valid = false;
      }
    if (
      valid &&
      counts.every((c, i) => {
        const total = num(obj(obj(byTeam[i].objectives).dragon).kills);
        return (
          total !== null &&
          (total === c.elemental || total === c.elemental + c.elder)
        );
      })
    )
      dragonCounts = counts;
  }
  if (!dragonCounts)
    warnings.push(
      "Chưa đủ event/counter để tách rồng nguyên tố và Elder; hai mục giữ —.",
    );
  const championId = (n: unknown) =>
    num(n) && Number(n) <= 999999 ? String(n) : null;
  const teams = roster.map((ps, side) => {
    const t = byTeam[side],
      objectives = obj(t.objectives);
    const sum = (key: string) => {
      const values = ps.map((p) => num(p[key]));
      return values.every((v) => v !== null)
        ? values.reduce<number>((n, v) => n + v!, 0)
        : null;
    };
    const bans = Array.isArray(t.bans)
      ? [...t.bans]
          .sort((a, b) => (a.pickTurn ?? 0) - (b.pickTurn ?? 0))
          .slice(0, 5)
          .map((b) => championId(b.championId))
      : [];
    while (bans.length < 5) bans.push(null);
    return {
      kills: sum("kills"),
      deaths: sum("deaths"),
      assists: sum("assists"),
      gold: sum("goldEarned"),
      towers: num(obj(objectives.tower).kills),
      barons: num(obj(objectives.baron).kills),
      heralds: num(obj(objectives.riftHerald).kills),
      grubs: num(obj(objectives.horde).kills),
      drakes: dragonCounts?.[side].elemental ?? null,
      elders: dragonCounts?.[side].elder ?? null,
      bans,
      players: ps.map((p) => ({
        champion: championId(p.championId),
        damage: num(p.totalDamageDealtToChampions),
      })),
    };
  }) as RiotPostgameState["teams"];
  if (teams.some((t) => t.players.some((p) => p.damage === null)))
    warnings.push(
      "Một số player thiếu damage to champions; không suy từ HP hoặc tổng damage mọi mục tiêu.",
    );
  if (teams.some((t) => t.grubs === null))
    warnings.push(
      "Không có objectives.horde: số sâu giữ —; chưa xác minh patch này.",
    );
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
      matchId,
      mode,
      fetchedAt: new Date().toISOString(),
      patch,
      roleOrderResolved,
      timelineAvailable,
      isFinal,
      warnings,
    },
  });
}

class RiotError extends Error {
  constructor(
    public status: number,
    public code: string,
    public retryAfter = 0,
  ) {
    super(code);
  }
}
export class RiotPostgameService {
  private credential: z.infer<typeof riotCredentialSchema> | null = null;
  private candidate: RiotPostgameState | null = null;
  private controller: AbortController | null = null;
  private generation = 0;
  private retryAt = 0;
  constructor(private request: typeof fetch = fetch) {}
  status() {
    return {
      configured: !!this.credential,
      mode: this.credential?.mode ?? "standard",
      platform: "VN2",
      routing: "SEA",
      storage: "memory",
      busy: !!this.controller,
      candidate: this.candidate,
      retryAfter: Math.max(0, Math.ceil((this.retryAt - Date.now()) / 1000)),
    };
  }
  configure(input: unknown) {
    const next = riotCredentialSchema.parse(input);
    this.clear();
    this.credential = next;
    return this.status();
  }
  clear() {
    this.controller?.abort();
    this.controller = null;
    this.credential = null;
    this.candidate = null;
    this.generation++;
  }
  publishedCandidate(matchId: string) {
    if (!this.candidate || this.candidate.evidence.matchId !== matchId)
      throw new RiotError(409, "no-candidate");
    return structuredClone(this.candidate);
  }
  async load(input: unknown) {
    const value = riotLoadSchema.parse(input);
    if (!this.credential) throw new RiotError(409, "no-credential");
    if (this.controller) throw new RiotError(409, "busy");
    if (Date.now() < this.retryAt)
      throw new RiotError(
        429,
        "rate-limit",
        Math.ceil((this.retryAt - Date.now()) / 1000),
      );
    const generation = this.generation,
      controller = new AbortController(),
      credential = this.credential;
    this.controller = controller;
    const headers: HeadersInit =
      credential.mode === "standard"
        ? { "X-Riot-Token": credential.secret }
        : { Authorization: `Bearer ${credential.secret}` };
    const prefix =
      credential.mode === "standard"
        ? "/lol/match/v5/matches/"
        : "/lol/rso-match/v1/matches/";
    const get = async (suffix: string) => {
      if (controller.signal.aborted || generation !== this.generation)
        throw new RiotError(409, "cancelled");
      let response: Response;
      try {
        response = await this.request(
          `https://sea.api.riotgames.com${prefix}${value.matchId}${suffix}`,
          {
            method: "GET",
            headers,
            redirect: "error",
            signal: AbortSignal.any([
              controller.signal,
              AbortSignal.timeout(12000),
            ]),
          },
        );
      } catch {
        throw new RiotError(503, "network");
      }
      if (!response.ok) {
        await response.body?.cancel();
        const retryHeader = response.headers.get("retry-after");
        const retryNumber = retryHeader ? Number(retryHeader) : NaN;
        const retryDate = retryHeader ? Date.parse(retryHeader) : NaN;
        const retry =
          response.status === 429
            ? Math.max(
                1,
                Number.isFinite(retryNumber) && retryNumber >= 0
                  ? Math.ceil(retryNumber)
                  : Number.isFinite(retryDate)
                    ? Math.ceil((retryDate - Date.now()) / 1000)
                    : 60,
              )
            : 0;
        if (retry) this.retryAt = Date.now() + retry * 1000;
        throw new RiotError(
          response.status,
          response.status === 429
            ? "rate-limit"
            : `upstream-${response.status}`,
          retry,
        );
      }
      const reader = response.body?.getReader();
      if (!reader) throw new RiotError(502, "invalid-json");
      const chunks: Uint8Array[] = [];
      let size = 0;
      try {
        while (true) {
          const { done, value: chunk } = await reader.read();
          if (done) break;
          size += chunk.length;
          if (size > 8 * 1024 * 1024) {
            await reader.cancel();
            throw new RiotError(502, "response-too-large");
          }
          chunks.push(chunk);
        }
        return JSON.parse(Buffer.concat(chunks).toString("utf8"));
      } catch (e) {
        if (e instanceof RiotError) throw e;
        throw new RiotError(502, "invalid-json");
      }
    };
    try {
      const match = await get("");
      // Validate match identity/roster before any timeline request.
      normalizeRiotPostgame(
        match,
        null,
        value.matchId,
        credential.mode,
        value.gameNumber,
      );
      let timeline: unknown = null,
        timelineIssue: string | null = null;
      try {
        timeline = await get("/timeline");
      } catch (e) {
        const safe = riotError(e);
        timelineIssue = `Timeline chưa tải được (${safe.code}); thống kê cuối trận vẫn dùng response Match.`;
      }
      const data = normalizeRiotPostgame(
        match,
        timeline,
        value.matchId,
        credential.mode,
        value.gameNumber,
      );
      if (timelineIssue) data.evidence.warnings.push(timelineIssue);
      if (generation !== this.generation || controller.signal.aborted)
        throw new RiotError(409, "cancelled");
      this.candidate = data;
      return { ...this.status(), busy: false };
    } finally {
      if (this.controller === controller) this.controller = null;
    }
  }
}
export function riotError(e: unknown) {
  return e instanceof RiotError
    ? { status: e.status, code: e.code, retryAfter: e.retryAfter }
    : { status: 400, code: "invalid-data", retryAfter: 0 };
}
