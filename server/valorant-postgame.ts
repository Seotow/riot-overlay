import { createHash } from "node:crypto";
import { mkdir, readFile, rename, writeFile } from "node:fs/promises";
import { dirname } from "node:path";
import { valorantFrameSchema, type ValorantFrame } from "../shared/valorant";
import type { ValorantMatchConfig } from "../shared/valorant-config";
import {
  defaultPostgameConfig,
  postgameConfigSchema,
  postgameSaveSchema,
  type PostgameConfig,
  type PostgameError,
  type PostgameHistoryResult,
  type PostgameMvpFull,
  type PostgameRender,
  type PostgameRow,
  type PostgameSelection,
  type PostgameStyle,
  type PostgameStatus,
} from "../shared/valorant-postgame";

const HENRIK = "https://api.henrikdev.xyz";
const VALORANT_API = "https://valorant-api.com/v1";

type Side = "left" | "right";
export interface PostgamePlayer {
  puuid: string;
  name: string;
  tag: string;
  side: Side;
  agent: string;
  agentId: string;
  kills: number;
  deaths: number;
  assists: number;
  /** null = nguồn không có số liệu (Spectra không đo ACS, damage, first kill, KAST). */
  acs: number | null;
  damagePerRound: number | null;
  firstKillPct: number | null;
  kastPct: number | null;
}
export interface PostgameMatch {
  source: "spectra" | "henrik";
  id: string;
  map: string;
  mapId: string;
  queue: string;
  durationMs: number | null;
  /** [trái, phải] */
  rounds: [number, number];
  players: PostgamePlayer[];
}

const num = (v: unknown, fallback = 0) =>
  typeof v === "number" && Number.isFinite(v) ? v : fallback;
const str = (v: unknown) => (typeof v === "string" ? v : "");
const round1 = (v: number) => Math.round(v * 10) / 10;

// ─── Henrik v4 → PostgameMatch ────────────────────────────────────────────────

/** Cùng công thức với valorant-postgame-stats: ACS = score/rounds, KAST có tính trade trong 5 giây. */
export function normalizeHenrik(data: any, myPuuid: string): PostgameMatch | null {
  const players: any[] = Array.isArray(data?.players) ? data.players : [];
  const teams: any[] = Array.isArray(data?.teams) ? data.teams : [];
  if (players.length === 0 || teams.length < 2) return null;
  const mine = players.find((p) => p?.puuid === myPuuid);
  const leftId = str(mine?.team_id) || "Blue";
  const teamOf = (id: string) => teams.find((t) => t?.team_id === id);
  const left = teamOf(leftId);
  const right = teams.find((t) => t?.team_id !== leftId);
  const rounds: [number, number] = [num(left?.rounds?.won), num(right?.rounds?.won)];
  const roundList: any[] = Array.isArray(data?.rounds) ? data.rounds : [];
  const total = Math.max(roundList.length || rounds[0] + rounds[1], 1);
  const kills: any[] = Array.isArray(data?.kills) ? data.kills : [];
  const byRound = new Map<number, any[]>();
  for (const k of kills) {
    const r = num(k?.round);
    byRound.set(r, [...(byRound.get(r) ?? []), k]);
  }
  const firstKills = new Map<string, number>();
  for (const list of byRound.values()) {
    if (list.length === 0) continue;
    const first = list.reduce((a, b) =>
      num(b.time_in_round_in_ms) < num(a.time_in_round_in_ms) ? b : a,
    );
    const id = str(first?.killer?.puuid);
    if (id) firstKills.set(id, (firstKills.get(id) ?? 0) + 1);
  }
  const kast = (puuid: string) => {
    let count = 0;
    for (let r = 0; r < total; r++) {
      const list = byRound.get(r) ?? [];
      const gotKill = list.some((k) => k?.killer?.puuid === puuid);
      const gotAssist = list.some(
        (k) => Array.isArray(k?.assistants) && k.assistants.some((a: any) => a?.puuid === puuid),
      );
      const deaths = list.filter((k) => k?.victim?.puuid === puuid);
      const traded = deaths.some((d) =>
        list.some(
          (k) =>
            k?.victim?.puuid === d?.killer?.puuid &&
            num(k.time_in_round_in_ms) - num(d.time_in_round_in_ms) >= 0 &&
            num(k.time_in_round_in_ms) - num(d.time_in_round_in_ms) <= 5000,
        ),
      );
      if (gotKill || gotAssist || deaths.length === 0 || traded) count++;
    }
    return round1((count / total) * 100);
  };
  return {
    source: "henrik",
    id: str(data?.metadata?.match_id),
    map: str(data?.metadata?.map?.name),
    mapId: str(data?.metadata?.map?.id),
    queue: str(data?.metadata?.queue?.name) || str(data?.metadata?.queue?.id),
    durationMs:
      typeof data?.metadata?.game_length_in_ms === "number"
        ? data.metadata.game_length_in_ms
        : null,
    rounds,
    players: players.map((p) => {
      const stats = p?.stats ?? {};
      const puuid = str(p?.puuid);
      return {
        puuid,
        name: str(p?.name),
        tag: str(p?.tag),
        side: p?.team_id === leftId ? "left" : "right",
        agent: str(p?.agent?.name) || "?",
        agentId: str(p?.agent?.id),
        kills: num(stats.kills),
        deaths: num(stats.deaths),
        assists: num(stats.assists),
        acs: Math.round(num(stats.score) / total),
        damagePerRound: round1(num(stats?.damage?.dealt) / total),
        firstKillPct: round1(((firstKills.get(puuid) ?? 0) / total) * 100),
        kastPct: kast(puuid),
      } satisfies PostgamePlayer;
    }),
  };
}

// ─── Spectra frame → PostgameMatch ────────────────────────────────────────────

export function normalizeSpectraFrame(frame: ValorantFrame): PostgameMatch {
  const players: PostgamePlayer[] = frame.teams.flatMap((team, index) =>
    team.players.map((p, slot) => {
      const full = p.name.value ?? `Player ${index * 5 + slot + 1}`;
      const cut = full.lastIndexOf("#");
      return {
        puuid: "",
        name: cut > 0 ? full.slice(0, cut) : full,
        tag: cut > 0 ? full.slice(cut + 1) : "",
        side: index === 0 ? "left" : "right",
        agent: p.agent.value ?? "?",
        agentId: "",
        kills: p.kills.value ?? 0,
        deaths: p.deaths.value ?? 0,
        assists: p.assists.value ?? 0,
        acs: null,
        damagePerRound: null,
        firstKillPct: null,
        kastPct: null,
      } satisfies PostgamePlayer;
    }),
  );
  return {
    source: "spectra",
    id: frame.receivedAt,
    map: frame.match.map.value ?? "",
    mapId: "",
    queue: frame.match.mode.value ?? "",
    durationMs: null,
    rounds: [frame.teams[0].roundsWon, frame.teams[1].roundsWon],
    players,
  };
}

// ─── Dựng dữ liệu overlay ─────────────────────────────────────────────────────

export interface Lookups {
  agentId(name: string): string;
  map(name: string): { id: string; splash: string } | null;
}
export const noLookups: Lookups = { agentId: () => "", map: () => null };

const portrait = (id: string) =>
  id ? `https://media.valorant-api.com/agents/${id}/fullportrait.png` : "";
const icon = (id: string) =>
  id ? `https://media.valorant-api.com/agents/${id}/displayicon.png` : "";

/** ACS khi mọi người đều có, nếu không thì K rồi ít chết, nhiều assist. */
export function rank(players: PostgamePlayer[]): PostgamePlayer[] {
  const hasAcs = players.length > 0 && players.every((p) => p.acs !== null);
  return [...players].sort((a, b) =>
    hasAcs && a.acs !== b.acs
      ? b.acs! - a.acs!
      : b.kills - a.kills || a.deaths - b.deaths || b.assists - a.assists,
  );
}

function styleOf(c: PostgameConfig): PostgameStyle {
  const { name, tag, region, platform, hidePlayerTag, ...theme } = c;
  void [name, tag, region, platform, hidePlayerTag];
  return {
    ...theme,
    overlayBg: c.useDefaultBg ? "/valorant-postgame/default-bg.jpg" : "",
    sponsorImage: c.useDefaultSponsor ? "/valorant-postgame/default-sponsor.png" : "",
  };
}

export interface RenderContext {
  config: PostgameConfig;
  matchConfig: ValorantMatchConfig;
  logo: (name: string) => string;
  lookups: Lookups;
}

const emptyCard = { agent: "", name: "", kills: 0, deaths: 0, acs: null, portrait: "" };
const hash = (v: unknown) =>
  createHash("sha1").update(JSON.stringify(v)).digest("hex").slice(0, 12);

function displayName(p: PostgamePlayer, ctx: RenderContext) {
  const full = p.tag ? `${p.name}#${p.tag}` : p.name;
  const hit = ctx.matchConfig.nameOverrides.find(
    (o) =>
      o.player.toLowerCase() === full.toLowerCase() ||
      o.player.toLowerCase() === p.name.toLowerCase(),
  );
  if (hit) return hit.display;
  return ctx.config.hidePlayerTag ? p.name : full;
}

function withAgentIds(match: PostgameMatch, lookups: Lookups): PostgameMatch {
  const mapHit = match.mapId ? null : lookups.map(match.map);
  return {
    ...match,
    mapId: match.mapId || mapHit?.id || "",
    players: match.players.map((p) => ({ ...p, agentId: p.agentId || lookups.agentId(p.agent) })),
  };
}

export function buildRender(source: PostgameMatch | null, ctx: RenderContext): PostgameRender {
  const style = styleOf(ctx.config);
  const teams = ctx.matchConfig.teams;
  const base = {
    leftTeamName: teams[0].name,
    rightTeamName: teams[1].name,
    leftTeamLogo: ctx.logo(teams[0].logo),
    rightTeamLogo: ctx.logo(teams[1].logo),
    leagueLogo: ctx.logo(ctx.matchConfig.tournament.logo),
  };
  if (!source) {
    const empty: PostgameRender = {
      empty: true,
      source: null,
      version: "",
      style,
      match: {
        ...base,
        leftScore: 0,
        rightScore: 0,
        leftResult: "",
        rightResult: "",
        mapName: "",
        queueName: "",
        duration: "—",
        mapImageLeft: "",
      },
      mvp: { left: emptyCard, right: emptyCard },
      rows: { left: [], right: [] },
    };
    return { ...empty, version: hash(empty) };
  }
  const match = withAgentIds(source, ctx.lookups);
  const [leftScore, rightScore] = match.rounds;
  const done = leftScore !== rightScore;
  const sorted = (side: Side) => rank(match.players.filter((p) => p.side === side));
  const card = (p?: PostgamePlayer) =>
    p
      ? {
          agent: p.agent.toUpperCase(),
          name: displayName(p, ctx),
          kills: p.kills,
          deaths: p.deaths,
          acs: p.acs,
          portrait: portrait(p.agentId),
        }
      : emptyCard;
  const rows = (list: PostgamePlayer[]): PostgameRow[] =>
    list.slice(1, 5).map((p) => ({
      agent: p.agent.toUpperCase(),
      name: displayName(p, ctx),
      kills: p.kills,
      acs: p.acs,
      icon: icon(p.agentId),
    }));
  const left = sorted("left");
  const right = sorted("right");
  const seconds = match.durationMs === null ? null : Math.floor(match.durationMs / 1000);
  const mapName = match.map.toUpperCase();
  const splash = ctx.lookups.map(match.map)?.splash ?? "";
  const render: PostgameRender = {
    empty: false,
    source: match.source,
    version: "",
    style,
    match: {
      ...base,
      leftScore,
      rightScore,
      leftResult: done && leftScore > rightScore ? "THẮNG" : "THUA",
      rightResult: done && rightScore > leftScore ? "THẮNG" : "THUA",
      mapName,
      queueName: match.queue.toUpperCase(),
      duration:
        seconds === null
          ? "—"
          : `${Math.floor(seconds / 60)}:${String(seconds % 60).padStart(2, "0")}`,
      mapImageLeft:
        splash ||
        (match.mapId ? `https://media.valorant-api.com/maps/${match.mapId}/splash.png` : ""),
    },
    mvp: { left: card(left[0]), right: card(right[0]) },
    rows: { left: rows(left), right: rows(right) },
  };
  return { ...render, version: hash(render) };
}

export function buildMvp(source: PostgameMatch | null, ctx: RenderContext): PostgameMvpFull {
  const style = styleOf(ctx.config);
  const empty: PostgameMvpFull = {
    empty: true,
    name: "",
    agentName: "",
    agentId: "",
    teamName: "",
    teamLogo: "",
    acs: null,
    kills: 0,
    deaths: 0,
    assists: 0,
    damagePerRound: null,
    firstKillPct: null,
    kastPct: null,
    version: "",
    style,
  };
  if (!source || source.players.length === 0) return { ...empty, version: hash(empty) };
  const match = withAgentIds(source, ctx.lookups);
  const best = rank(match.players)[0];
  const team = ctx.matchConfig.teams[best.side === "left" ? 0 : 1];
  const mvp: PostgameMvpFull = {
    empty: false,
    name: displayName(best, ctx),
    agentName: best.agent.toUpperCase(),
    agentId: best.agentId,
    teamName: team.name,
    teamLogo: ctx.logo(team.logo),
    acs: best.acs,
    kills: best.kills,
    deaths: best.deaths,
    assists: best.assists,
    damagePerRound: best.damagePerRound,
    firstKillPct: best.firstKillPct,
    kastPct: best.kastPct,
    version: "",
    style,
  };
  return { ...mvp, version: hash(mvp) };
}

// ─── Tra cứu agent/map từ valorant-api.com (ảnh, không cần key) ───────────────

export class ValorantAssets implements Lookups {
  private agents = new Map<string, string>();
  private maps = new Map<string, { id: string; splash: string }>();
  private loadedAt = 0;
  constructor(private readonly fetcher: typeof fetch = fetch) {}
  async ensure() {
    if (this.loadedAt && Date.now() - this.loadedAt < 24 * 3600_000) return;
    try {
      const get = async (path: string) =>
        (await (
          await this.fetcher(`${VALORANT_API}${path}`, { signal: AbortSignal.timeout(8000) })
        ).json()) as any;
      const [agents, maps] = await Promise.all([
        get("/agents?isPlayableCharacter=true"),
        get("/maps"),
      ]);
      for (const a of agents?.data ?? [])
        if (a?.displayName && a?.uuid) this.agents.set(String(a.displayName).toLowerCase(), a.uuid);
      for (const m of maps?.data ?? [])
        if (m?.displayName && m?.uuid && m?.splash)
          this.maps.set(String(m.displayName).toLowerCase(), { id: m.uuid, splash: m.splash });
      this.loadedAt = Date.now();
    } catch {
      // Không có mạng: overlay vẫn hiện số liệu, chỉ thiếu ảnh. Thử lại sau 1 phút.
      this.loadedAt = Date.now() - 24 * 3600_000 + 60_000;
    }
  }
  agentId(name: string) {
    return this.agents.get(name.toLowerCase()) ?? "";
  }
  map(name: string) {
    return this.maps.get(name.toLowerCase()) ?? null;
  }
}

// ─── Lưu trữ + Henrik client ──────────────────────────────────────────────────

const THEME_VERSION = 1;
interface Persisted {
  config: PostgameConfig;
  apiKey: string;
  selection: PostgameSelection | null;
}

export interface PostgamePaths {
  file: string;
  snapshot: string;
}

type Fetched = { ok: true; data: any } | { ok: false; error: PostgameError };

export class PostgameStore {
  private persisted: Persisted = {
    config: { ...defaultPostgameConfig },
    apiKey: "",
    selection: null,
  };
  private loaded: Promise<void> | null = null;
  private frame: ValorantFrame | null = null;
  private frameFinal = false;
  private savedAt = 0;
  private account: { key: string; puuid: string; name: string; tag: string } | null = null;
  private matches = new Map<string, PostgameMatch>();
  constructor(
    private readonly paths: PostgamePaths,
    private readonly fetcher: typeof fetch = fetch,
    private readonly now: () => number = Date.now,
  ) {}

  private load() {
    return (this.loaded ??= (async () => {
      try {
        const raw = JSON.parse(await readFile(this.paths.file, "utf8"));
        const config = postgameConfigSchema.safeParse({ ...defaultPostgameConfig, ...raw?.config });
        // File cũ (chưa có themeVersion) có thể giữ màu từ bản mặc định trước: nạp lại theme gốc
        // của valorant-postgame-stats, giữ nguyên Riot ID/khu vực.
        const stored = config.success ? config.data : { ...defaultPostgameConfig };
        const { name, tag, region, platform } = stored;
        this.persisted = {
          config:
            raw?.themeVersion === THEME_VERSION
              ? stored
              : { ...defaultPostgameConfig, name, tag, region, platform },
          apiKey: typeof raw?.apiKey === "string" ? raw.apiKey : "",
          selection: raw?.selection ?? null,
        };
      } catch {}
      try {
        const frame = valorantFrameSchema.safeParse(
          JSON.parse(await readFile(this.paths.snapshot, "utf8")),
        );
        if (frame.success) {
          this.frame = frame.data;
          this.frameFinal = frame.data.match.roundPhase.value === "game_end";
        }
      } catch {}
    })());
  }

  private async write(path: string, value: unknown) {
    await mkdir(dirname(path), { recursive: true });
    await writeFile(`${path}.tmp`, JSON.stringify(value, null, 2));
    await rename(`${path}.tmp`, path);
  }

  /** Giữ khung cuối của trận đang theo dõi để làm hậu trận khi Spectra về sảnh. */
  observe(frame: ValorantFrame | null) {
    if (!frame || frame.coverage.scoreboard === 0) return;
    const final = frame.match.roundPhase.value === "game_end";
    // Đã có kết quả cuối thì chỉ nhường chỗ cho trận mới (sảnh/0 người đã bị loại ở trên).
    if (this.frameFinal && final && this.frame?.receivedAt === frame.receivedAt) return;
    this.frame = frame;
    const becameFinal = final && !this.frameFinal;
    this.frameFinal = final;
    const at = this.now();
    if (becameFinal || at - this.savedAt > 10_000) {
      this.savedAt = at;
      void this.load()
        .then(() => this.write(this.paths.snapshot, frame))
        .catch(() => {});
    }
  }

  async status(): Promise<PostgameStatus> {
    await this.load();
    const frame = this.frame;
    return {
      config: this.persisted.config,
      hasApiKey: this.persisted.apiKey !== "",
      selection: this.persisted.selection,
      spectra: frame
        ? {
            map: frame.match.map.value,
            score: [frame.teams[0].roundsWon, frame.teams[1].roundsWon],
            players: frame.coverage.players,
            final: this.frameFinal,
            capturedAt: frame.receivedAt,
          }
        : null,
      coverage: {
        spectra: ["Tỉ số", "Map", "Agent", "K / D / A", "Tên người chơi"],
        henrik: [
          "Tất cả số liệu của Spectra",
          "ACS",
          "Damage/round",
          "First kill %",
          "KAST %",
          "Thời lượng",
          "Hàng đợi",
        ],
        missingFromSpectra: ["ACS", "Damage/round", "First kill %", "KAST %", "Thời lượng"],
      },
    };
  }

  async save(input: unknown): Promise<{ ok: true } | { ok: false; error: "invalid-config" }> {
    await this.load();
    const parsed = postgameSaveSchema.safeParse(input);
    if (!parsed.success) return { ok: false, error: "invalid-config" };
    const identity = (c: PostgameConfig) => `${c.name}#${c.tag}|${c.region}|${c.platform}`;
    const changed = identity(parsed.data.config) !== identity(this.persisted.config);
    this.persisted.config = parsed.data.config;
    if (parsed.data.apiKey !== undefined) this.persisted.apiKey = parsed.data.apiKey;
    if (changed || parsed.data.apiKey !== undefined) {
      this.account = null;
      this.matches.clear();
    }
    await this.write(this.paths.file, { ...this.persisted, themeVersion: THEME_VERSION });
    return { ok: true };
  }

  private async henrik(path: string): Promise<Fetched> {
    const { apiKey } = this.persisted;
    if (!apiKey) return { ok: false, error: "no-api-key" };
    let res: Response;
    try {
      res = await this.fetcher(`${HENRIK}${path}`, {
        headers: { Accept: "application/json", Authorization: apiKey },
        signal: AbortSignal.timeout(15_000),
      });
    } catch {
      return { ok: false, error: "network" };
    }
    if (res.status === 401 || res.status === 403) return { ok: false, error: "unauthorized" };
    if (res.status === 404) return { ok: false, error: "not-found" };
    if (res.status === 429) return { ok: false, error: "rate-limited" };
    if (!res.ok) return { ok: false, error: "bad-response" };
    try {
      return { ok: true, data: (await res.json())?.data };
    } catch {
      return { ok: false, error: "bad-response" };
    }
  }

  private async resolveAccount(): Promise<
    { ok: true; puuid: string; name: string; tag: string } | { ok: false; error: PostgameError }
  > {
    const { name, tag } = this.persisted.config;
    if (!name || !tag) return { ok: false, error: "not-configured" };
    const key = `${name}#${tag}`;
    if (this.account?.key === key) return { ok: true, ...this.account };
    const res = await this.henrik(
      `/valorant/v1/account/${encodeURIComponent(name)}/${encodeURIComponent(tag)}`,
    );
    if (!res.ok) return res;
    const puuid = str(res.data?.puuid);
    if (!puuid) return { ok: false, error: "bad-response" };
    this.account = {
      key,
      puuid,
      name: str(res.data?.name) || name,
      tag: str(res.data?.tag) || tag,
    };
    return { ok: true, ...this.account };
  }

  async history(): Promise<PostgameHistoryResult> {
    await this.load();
    const account = await this.resolveAccount();
    if (!account.ok) return account;
    const { region, platform } = this.persisted.config;
    const res = await this.henrik(
      `/valorant/v4/by-puuid/matches/${region}/${platform}/${account.puuid}?size=10`,
    );
    if (!res.ok) return res;
    if (!Array.isArray(res.data)) return { ok: false, error: "bad-response" };
    const matches = res.data.map((m: any) => {
      const mine = (m?.players ?? []).find((p: any) => p?.puuid === account.puuid);
      const teams: any[] = m?.teams ?? [];
      const own = teams.find((t) => t?.team_id === mine?.team_id);
      const other = teams.find((t) => t?.team_id !== mine?.team_id);
      return {
        matchId: str(m?.metadata?.match_id),
        map: str(m?.metadata?.map?.name),
        queue: str(m?.metadata?.queue?.name) || str(m?.metadata?.queue?.id),
        startedAt: str(m?.metadata?.started_at) || null,
        won: typeof own?.won === "boolean" ? own.won : null,
        score: own && other ? `${num(own.rounds?.won)}-${num(other.rounds?.won)}` : "",
        agent: str(mine?.agent?.name),
      };
    });
    return {
      ok: true,
      name: account.name,
      tag: account.tag,
      matches: matches.filter((m) => m.matchId),
    };
  }

  async select(
    selection: PostgameSelection,
  ): Promise<{ ok: true } | { ok: false; error: PostgameError }> {
    await this.load();
    if (selection.source === "henrik") {
      const loaded = await this.henrikMatch(selection.matchId);
      if (!loaded.ok) return loaded;
    }
    this.persisted.selection = selection;
    await this.write(this.paths.file, { ...this.persisted, themeVersion: THEME_VERSION });
    return { ok: true };
  }

  private async henrikMatch(
    id: string,
  ): Promise<{ ok: true; match: PostgameMatch } | { ok: false; error: PostgameError }> {
    const cached = this.matches.get(id);
    if (cached) return { ok: true, match: cached };
    const account = await this.resolveAccount();
    if (!account.ok) return account;
    const res = await this.henrik(`/valorant/v4/match/${this.persisted.config.region}/${id}`);
    if (!res.ok) return res;
    const match = normalizeHenrik(res.data, account.puuid);
    if (!match) return { ok: false, error: "bad-response" };
    this.matches.set(id, match);
    return { ok: true, match };
  }

  /** Trận đang được chọn cho overlay; null khi chưa có nguồn nào. */
  async current(): Promise<PostgameMatch | null> {
    await this.load();
    const selection = this.persisted.selection;
    if (selection?.source === "henrik") {
      const loaded = await this.henrikMatch(selection.matchId);
      if (loaded.ok) return loaded.match;
      // Henrik lỗi (hết hạn mức, mất mạng...): dùng tạm khung Spectra thay vì để trống.
    }
    return this.frame ? normalizeSpectraFrame(this.frame) : null;
  }
}
