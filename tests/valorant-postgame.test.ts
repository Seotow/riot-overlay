import test from "node:test";
import assert from "node:assert/strict";
import { mkdtemp, readFile } from "node:fs/promises";
import { tmpdir } from "node:os";
import { join } from "node:path";
import { normalizeSpectra } from "../server/valorant-spectra";
import {
  PostgameStore,
  buildMvp,
  buildRender,
  normalizeHenrik,
  normalizeSpectraFrame,
  noLookups,
  type RenderContext,
} from "../server/valorant-postgame";
import { defaultValorantMatchConfig } from "../shared/valorant-config";
import { defaultPostgameConfig } from "../shared/valorant-postgame";

const ME = "me";
const player = (puuid: string, team_id: string, score: number, kills: number, deaths: number) => ({
  puuid,
  name: puuid.toUpperCase(),
  tag: "VN",
  team_id,
  agent: { id: `agent-${puuid}`, name: "Jett" },
  stats: { score, kills, deaths, assists: 2, damage: { dealt: 1000 } },
});
// Trận 4 vòng: "me" mở màn ở vòng 0 và bị "e1" hạ ở vòng 1 nhưng được trade trong 3 giây.
const henrikMatch = {
  metadata: {
    match_id: "11111111-2222-3333-4444-555555555555",
    map: { id: "map-ascent", name: "Ascent" },
    queue: { id: "competitive", name: "Competitive" },
    game_length_in_ms: 1_445_000,
  },
  teams: [
    { team_id: "Blue", won: true, rounds: { won: 3, lost: 1 } },
    { team_id: "Red", won: false, rounds: { won: 1, lost: 3 } },
  ],
  players: [
    player(ME, "Blue", 1000, 8, 3),
    player("ally", "Blue", 800, 5, 4),
    player("e1", "Red", 1200, 6, 6),
    player("e2", "Red", 400, 2, 7),
  ],
  rounds: [{}, {}, {}, {}],
  kills: [
    {
      round: 0,
      time_in_round_in_ms: 5000,
      killer: { puuid: ME },
      victim: { puuid: "e2" },
      assistants: [],
    },
    {
      round: 1,
      time_in_round_in_ms: 9000,
      killer: { puuid: "e1" },
      victim: { puuid: ME },
      assistants: [],
    },
    {
      round: 1,
      time_in_round_in_ms: 12000,
      killer: { puuid: "ally" },
      victim: { puuid: "e1" },
      assistants: [],
    },
    {
      round: 2,
      time_in_round_in_ms: 4000,
      killer: { puuid: "ally" },
      victim: { puuid: "e2" },
      assistants: [{ puuid: ME }],
    },
  ],
};

const ctx = (over: Partial<RenderContext> = {}): RenderContext => ({
  config: { ...defaultPostgameConfig },
  matchConfig: structuredClone(defaultValorantMatchConfig),
  logo: (name) => (name ? `http://logo/${name}` : ""),
  lookups: noLookups,
  ...over,
});

test("Henrik: ACS, damage, first kill và KAST tính từ dữ liệu vòng", () => {
  const match = normalizeHenrik(henrikMatch, ME)!;
  const me = match.players.find((p) => p.puuid === ME)!;
  assert.equal(match.rounds[0], 3);
  assert.equal(me.side, "left");
  assert.equal(me.acs, 250);
  assert.equal(me.damagePerRound, 250);
  assert.equal(me.firstKillPct, 25);
  // Vòng 0 kill, vòng 1 chết nhưng được trade trong 5s, vòng 2 assist, vòng 3 sống: 4/4.
  assert.equal(me.kastPct, 100);
  assert.equal(match.durationMs, 1_445_000);
});

test("Henrik: đội của chủ tài khoản luôn ở bên trái", () => {
  const match = normalizeHenrik(henrikMatch, "e1")!;
  assert.equal(match.players.find((p) => p.puuid === "e1")!.side, "left");
  assert.deepEqual(match.rounds, [1, 3]);
});

test("Henrik: dữ liệu rỗng hoặc sai dạng trả null", () => {
  assert.equal(normalizeHenrik({}, ME), null);
  assert.equal(normalizeHenrik({ players: [{}], teams: [] }, ME), null);
});

test("render từ Henrik: MVP theo ACS, duration và kết quả", () => {
  const render = buildRender(normalizeHenrik(henrikMatch, ME), ctx());
  assert.equal(render.empty, false);
  assert.equal(render.match.leftResult, "THẮNG");
  assert.equal(render.match.rightResult, "THUA");
  assert.equal(render.match.duration, "24:05");
  assert.equal(
    render.match.mapImageLeft,
    "https://media.valorant-api.com/maps/map-ascent/splash.png",
  );
  assert.equal(render.mvp.left.name, "ME");
  assert.equal(render.mvp.right.name, "E1");
  assert.equal(render.rows.left.length, 1);
  const shown = buildRender(
    normalizeHenrik(henrikMatch, ME),
    ctx({ config: { ...defaultPostgameConfig, hidePlayerTag: false } }),
  );
  assert.equal(shown.mvp.left.name, "ME#VN");
});

test("tên thay thế của cấu hình trận áp dụng cho hậu trận", () => {
  const matchConfig = structuredClone(defaultValorantMatchConfig);
  matchConfig.nameOverrides = [{ player: "e1#vn", display: "Hiếu" }];
  const mvp = buildMvp(normalizeHenrik(henrikMatch, ME), ctx({ matchConfig }));
  assert.equal(mvp.name, "Hiếu");
});

test("version đổi khi dữ liệu đổi và ổn định khi không đổi", () => {
  const a = buildRender(normalizeHenrik(henrikMatch, ME), ctx());
  const b = buildRender(normalizeHenrik(henrikMatch, ME), ctx());
  const c = buildRender(
    normalizeHenrik(henrikMatch, ME),
    ctx({ config: { ...defaultPostgameConfig, primaryColor: "#00ff00" } }),
  );
  assert.equal(a.version, b.version);
  assert.notEqual(a.version, c.version);
});

function spectraFrame() {
  const p = (name: string, kills: number, deaths: number) => ({
    name,
    tagline: "VN1",
    agentProper: "Sage",
    locked: true,
    isAlive: true,
    scoreboardAvailable: true,
    kills,
    deaths,
    assists: 1,
    money: 0,
  });
  return normalizeSpectra(
    {
      isRunning: true,
      map: "Ascent",
      matchType: "bomb",
      roundNumber: 9,
      roundPhase: "game_end",
      teams: [
        { teamName: "A", roundsWon: 13, players: [p("Alpha", 20, 10), p("Beta", 5, 12)] },
        { teamName: "B", roundsWon: 7, players: [p("Gamma", 11, 14)] },
      ],
    },
    "2026-10-19T10:00:00.000Z",
    1,
  )!;
}

test("Spectra: số liệu không đo được là null và hiện thành dấu gạch", () => {
  const match = normalizeSpectraFrame(spectraFrame());
  assert.equal(match.source, "spectra");
  assert.deepEqual(match.rounds, [13, 7]);
  assert.ok(match.players.every((p) => p.acs === null && p.kastPct === null));
  const render = buildRender(match, ctx());
  assert.equal(render.mvp.left.name, "Alpha");
  assert.equal(render.mvp.left.acs, null);
  assert.equal(render.match.duration, "—");
  assert.equal(render.match.leftResult, "THẮNG");
  const mvp = buildMvp(match, ctx());
  assert.equal(mvp.acs, null);
  assert.equal(mvp.damagePerRound, null);
});

test("Spectra: map và agent lấy ảnh từ bảng tra cứu khi có", () => {
  const lookups = {
    agentId: (n: string) => (n === "Sage" ? "sage-uuid" : ""),
    map: (n: string) => (n === "Ascent" ? { id: "m", splash: "https://x/splash.png" } : null),
  };
  const render = buildRender(normalizeSpectraFrame(spectraFrame()), ctx({ lookups }));
  assert.equal(render.match.mapImageLeft, "https://x/splash.png");
  assert.match(render.mvp.left.portrait, /sage-uuid/);
});

test("không có trận thì overlay ở trạng thái rỗng", () => {
  const render = buildRender(null, ctx());
  assert.equal(render.empty, true);
  assert.equal(render.source, null);
  assert.equal(buildMvp(null, ctx()).empty, true);
});

async function store(fetcher?: typeof fetch) {
  const dir = await mkdtemp(join(tmpdir(), "postgame-"));
  const paths = { file: join(dir, "postgame.json"), snapshot: join(dir, "last.json") };
  return { dir, paths, store: new PostgameStore(paths, fetcher) };
}
const json = (body: unknown, status = 200) =>
  Promise.resolve(new Response(JSON.stringify(body), { status }));

test("cấu hình: API key không bao giờ lộ qua status và giữ nguyên khi không gửi lại", async () => {
  const { store: s, paths } = await store();
  assert.deepEqual(
    await s.save({
      config: { ...defaultPostgameConfig, name: "Me", tag: "VN" },
      apiKey: "HDEV-secret",
    }),
    { ok: true },
  );
  const status = await s.status();
  assert.equal(status.hasApiKey, true);
  assert.ok(!JSON.stringify(status).includes("HDEV-secret"));
  await s.save({ config: { ...defaultPostgameConfig, name: "Me", tag: "VN" } });
  assert.match(await readFile(paths.file, "utf8"), /HDEV-secret/);
  await s.save({ config: { ...defaultPostgameConfig, name: "Me", tag: "VN" }, apiKey: "" });
  assert.equal((await s.status()).hasApiKey, false);
});

test("cấu hình sai bị từ chối", async () => {
  const { store: s } = await store();
  assert.deepEqual(await s.save({ config: { ...defaultPostgameConfig, primaryColor: "red" } }), {
    ok: false,
    error: "invalid-config",
  });
});

test("lịch sử: thiếu key, thiếu Riot ID và lỗi HTTP được báo đúng mã", async () => {
  const { store: s } = await store();
  assert.deepEqual(await s.history(), { ok: false, error: "not-configured" });
  await s.save({ config: { ...defaultPostgameConfig, name: "Me", tag: "VN" } });
  assert.deepEqual(await s.history(), { ok: false, error: "no-api-key" });

  for (const [status, error] of [
    [401, "unauthorized"],
    [404, "not-found"],
    [429, "rate-limited"],
    [500, "bad-response"],
  ] as const) {
    const { store: t } = await store(() => json({}, status));
    await t.save({ config: { ...defaultPostgameConfig, name: "Me", tag: "VN" }, apiKey: "k" });
    assert.deepEqual(await t.history(), { ok: false, error });
  }
  const { store: offline } = await store(() => Promise.reject(new Error("down")));
  await offline.save({ config: { ...defaultPostgameConfig, name: "Me", tag: "VN" }, apiKey: "k" });
  assert.deepEqual(await offline.history(), { ok: false, error: "network" });
});

test("Henrik: key gửi qua header Authorization, chọn trận rồi overlay dùng trận đó", async () => {
  const calls: { url: string; auth: string | null }[] = [];
  const fetcher = ((url: string, init?: RequestInit) => {
    calls.push({ url, auth: new Headers(init?.headers).get("Authorization") });
    if (url.includes("/v1/account/")) return json({ data: { puuid: ME, name: "Me", tag: "VN" } });
    if (url.includes("/v4/by-puuid/matches/"))
      return json({ data: [{ ...henrikMatch, metadata: { ...henrikMatch.metadata } }] });
    return json({ data: henrikMatch });
  }) as typeof fetch;
  const { store: s } = await store(fetcher);
  await s.save({ config: { ...defaultPostgameConfig, name: "Me", tag: "VN" }, apiKey: "HDEV-k" });

  const history = await s.history();
  assert.equal(history.ok && history.matches[0].score, "3-1");
  assert.equal(history.ok && history.matches[0].won, true);

  assert.deepEqual(await s.select({ source: "henrik", matchId: henrikMatch.metadata.match_id }), {
    ok: true,
  });
  const current = await s.current();
  assert.equal(current?.source, "henrik");
  assert.equal(current?.players.length, 4);
  assert.ok(calls.every((c) => c.auth === "HDEV-k"));
  // Match đã cache: gọi lại current() không tốn thêm request.
  const before = calls.length;
  await s.current();
  assert.equal(calls.length, before);
});

test("Henrik lỗi thì lùi về khung Spectra thay vì để overlay trống", async () => {
  const { store: s } = await store(() => json({}, 500));
  await s.save({ config: { ...defaultPostgameConfig, name: "Me", tag: "VN" }, apiKey: "k" });
  s.observe(spectraFrame());
  const picked = await s.select({
    source: "henrik",
    matchId: "11111111-2222-3333-4444-555555555555",
  });
  assert.equal(picked.ok, false);
  assert.equal((await s.current())?.source, "spectra");
});

test("khung cuối Spectra được giữ khi về sảnh và lưu ra đĩa khi kết thúc", async () => {
  const { store: s, paths } = await store();
  s.observe(spectraFrame());
  const lobby = normalizeSpectra(
    { isRunning: false, roundPhase: "LOBBY", teams: [{ players: [] }, { players: [] }] },
    "2026-10-19T10:30:00.000Z",
    2,
  )!;
  s.observe(lobby);
  const status = await s.status();
  assert.equal(status.spectra?.final, true);
  assert.deepEqual(status.spectra?.score, [13, 7]);
  await new Promise((r) => setTimeout(r, 50));
  assert.match(await readFile(paths.snapshot, "utf8"), /game_end/);
  // Tiến trình khởi động lại vẫn thấy trận vừa chơi.
  const again = new PostgameStore(paths);
  assert.deepEqual((await again.status()).spectra?.score, [13, 7]);
});

test("file cấu hình cũ: theme về mặc định của project gốc, giữ Riot ID và key", async () => {
  const { store: s, paths } = await store();
  const { writeFile } = await import("node:fs/promises");
  await writeFile(
    paths.file,
    JSON.stringify({
      config: { ...defaultPostgameConfig, name: "Me", tag: "VN", primaryColor: "#ff5a00" },
      apiKey: "HDEV-old",
      selection: null,
    }),
  );
  const status = await s.status();
  assert.equal(status.config.primaryColor, defaultPostgameConfig.primaryColor);
  assert.equal(status.config.name, "Me");
  assert.equal(status.hasApiKey, true);
  // Sau khi lưu thì theme người dùng chỉnh được giữ lại.
  await s.save({ config: { ...status.config, primaryColor: "#112233" } });
  assert.equal((await new PostgameStore(paths).status()).config.primaryColor, "#112233");
});
