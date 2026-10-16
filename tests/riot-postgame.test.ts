import test from "node:test";
import assert from "node:assert/strict";
import { createElement } from "react";
import { renderToStaticMarkup } from "react-dom/server";
import {
  RiotPostgameService,
  normalizeRiotPostgame,
  riotError,
} from "../server/riot-postgame";
import { commandSchema } from "../shared/schema";
import { createState } from "../shared/mock";
import { PostgameOverlay } from "../src/overlay/PostgameOverlay";
const id = "VN2_123456";
const key = "RGAPI-SYNTHETIC-UNIT-TEST-NOT-A-REAL-KEY";
function fixture() {
  const participants = Array.from({ length: 10 }, (_, i) => ({
    participantId: i + 1,
    teamId: i < 5 ? 100 : 200,
    teamPosition: ["TOP", "JUNGLE", "MIDDLE", "BOTTOM", "UTILITY"][i % 5],
    championId: [1, 2, 3, 4, 5][i % 5],
    kills: i < 5 ? 2 : 1,
    deaths: i < 5 ? 1 : 2,
    assists: 3,
    goldEarned: i < 5 ? 10000 : 8000,
    totalDamageDealtToChampions: 1000 + i,
    totalDamageDealt: 99000,
    riotIdGameName: "PRIVATE-FIXTURE-NAME",
    puuid: "PRIVATE-FIXTURE-PUUID",
  }));
  const match = {
    metadata: { matchId: id },
    info: {
      gameVersion: "16.20.123.456",
      gameDuration: 120,
      platformId: "VN2",
      endOfGameResult: "GameComplete",
      participants,
      teams: [100, 200].map((teamId) => ({
        teamId,
        win: teamId === 100,
        bans: [{ championId: 266, pickTurn: 1 }],
        objectives: {
          tower: { kills: 3 },
          baron: { kills: 1 },
          riftHerald: { kills: 1 },
          horde: { kills: 3 },
          dragon: { kills: teamId === 100 ? 2 : 0 },
        },
      })),
    },
  };
  const timeline = {
    metadata: { matchId: id },
    info: {
      frameInterval: 60000,
      frames: [0, 60000, 120000].map((timestamp) => ({
        timestamp,
        participantFrames: Object.fromEntries(
          participants.map((p) => [
            String(p.participantId),
            { totalGold: timestamp ? p.goldEarned : 500 },
          ]),
        ),
        events:
          timestamp === 60000
            ? [
                {
                  type: "ELITE_MONSTER_KILL",
                  monsterType: "DRAGON",
                  monsterSubType: "EARTH_DRAGON",
                  killerTeamId: 100,
                },
                {
                  type: "ELITE_MONSTER_KILL",
                  monsterType: "DRAGON",
                  monsterSubType: "ELDER_DRAGON",
                  killerTeamId: 100,
                },
              ]
            : [],
      })),
    },
  };
  return { match, timeline };
}
test("Riot normalization uses champion damage, team counters, role order, gold and timeline; strips identities", () => {
  const { match, timeline } = fixture();
  match.info.participants.reverse();
  const d = normalizeRiotPostgame(match, timeline, id, "standard", 2);
  assert.equal(d.source, "riot");
  assert.equal(d.version, 2);
  assert.equal(d.assetVersion, "16.20.1");
  assert.equal(d.teams[0].players[0].damage, 1000);
  assert.equal(d.teams[0].kills, 10);
  assert.equal(d.teams[0].gold, 50000);
  assert.equal(d.teams[0].barons, 1);
  assert.equal(d.teams[0].drakes, 1);
  assert.equal(d.teams[0].elders, 1);
  assert.equal(d.winner, "blue");
  assert.equal(d.goldHistory.at(-1)!.delta, 10000);
  assert.deepEqual(d.evidence.roleOrderResolved, [true, true]);
  assert.doesNotMatch(JSON.stringify(d), /PRIVATE|puuid|riotId|RGAPI/);
  assert.equal(
    commandSchema.safeParse({ type: "postgameState", value: d }).success,
    false,
    "WS/import cannot impersonate observed Riot results",
  );
  const html = renderToStaticMarkup(
    createElement(PostgameOverlay, { theme: createState().theme, data: d }),
  );
  assert.match(html, /data-source="riot"/);
  assert.match(html, /16\.20\.1\/champion/);
  assert.doesNotMatch(html, /DỮ LIỆU MẪU/);
});
test("missing damage/role/timeline remain unknown; wrong match and non-10-roster rejected", () => {
  const { match } = fixture();
  delete (match.info.participants[0] as any).totalDamageDealtToChampions;
  match.info.participants[0].teamPosition = "";
  const d = normalizeRiotPostgame(match, null, id, "standard", 1);
  assert.equal(d.teams[0].players[0].damage, null);
  assert.equal(d.teams[0].elders, null);
  assert.equal(d.teams[0].drakes, null);
  assert.deepEqual(d.goldHistory, []);
  assert.equal(d.evidence.roleOrderResolved[0], false);
  assert.match(
    renderToStaticMarkup(
      createElement(PostgameOverlay, { theme: createState().theme, data: d }),
    ),
    />P1</,
  );
  assert.throws(() =>
    normalizeRiotPostgame(match, null, "VN2_99", "standard", 1),
  );
  match.info.participants.pop();
  assert.throws(() => normalizeRiotPostgame(match, null, id, "standard", 1));
});
test("timeline gold gaps, mismatched objective totals and aborted match are not fabricated", () => {
  const { match, timeline } = fixture();
  delete (timeline.info.frames[1].participantFrames as any)["1"];
  match.info.teams[0].objectives.dragon.kills = 8;
  match.info.endOfGameResult = "Abort_Unexpected";
  const d = normalizeRiotPostgame(match, timeline, id, "standard", 1);
  assert.equal(d.goldHistory[1].delta, null);
  assert.equal(d.teams[0].elders, null);
  assert.equal(d.evidence.isFinal, false);
});
test("Riot service uses only fixed SEA GETs and headers, stages until publish, does not expose secrets", async () => {
  const f = fixture();
  const calls: { url: string; options: RequestInit }[] = [];
  const service = new RiotPostgameService((async (url, options) => {
    calls.push({ url: String(url), options: options! });
    return Response.json(
      String(url).endsWith("/timeline") ? f.timeline : f.match,
    );
  }) as typeof fetch);
  assert.equal(service.status().configured, false);
  service.configure({ mode: "standard", secret: key });
  assert.doesNotMatch(JSON.stringify(service.status()), /RGAPI|secret/);
  const result = await service.load({ matchId: id, gameNumber: 1 });
  assert.equal(result.busy, false);
  assert.equal(result.candidate?.evidence.matchId, id);
  assert.equal(calls.length, 2);
  assert.ok(
    calls.every(
      (c) =>
        c.url.startsWith(
          "https://sea.api.riotgames.com/lol/match/v5/matches/VN2_123456",
        ) &&
        !c.url.includes(key) &&
        c.options.redirect === "error" &&
        c.options.method === "GET",
    ),
  );
  assert.equal(
    (calls[0].options.headers as Record<string, string>)["X-Riot-Token"],
    key,
  );
  const published = service.publishedCandidate(id);
  published.teams[0].kills = 999;
  assert.equal(service.status().candidate?.teams[0].kills, 10);
  service.clear();
  assert.equal(service.status().candidate, null);
  assert.equal(service.status().configured, false);
});
test("Riot 403/429 errors do not leak raw payload; respects Retry-After with no retries", async () => {
  let calls = 0;
  const service = new RiotPostgameService((async () => {
    calls++;
    return new Response("RAW SECRET", {
      status: 429,
      headers: { "Retry-After": "20" },
    });
  }) as typeof fetch);
  service.configure({ mode: "standard", secret: key });
  for (let i = 0; i < 2; i++)
    await assert.rejects(service.load({ matchId: id, gameNumber: 1 }), (e) => {
      assert.equal(riotError(e).code, "rate-limit");
      assert.ok(riotError(e).retryAfter > 0);
      assert.doesNotMatch(JSON.stringify(riotError(e)), /RAW|SECRET|RGAPI/);
      return true;
    });
  assert.equal(calls, 1);
  const denied = new RiotPostgameService(
    (async () => new Response("RAW SECRET", { status: 403 })) as typeof fetch,
  );
  denied.configure({ mode: "standard", secret: key });
  await assert.rejects(
    denied.load({ matchId: id, gameNumber: 1 }),
    (e) => riotError(e).code === "upstream-403",
  );
  assert.equal(denied.status().candidate, null);
  for (const retryHeader of [
    "7200",
    new Date(Date.now() + 120000).toUTCString(),
  ]) {
    const limited = new RiotPostgameService(
      (async () =>
        new Response("", {
          status: 429,
          headers: { "Retry-After": retryHeader },
        })) as typeof fetch,
    );
    limited.configure({ mode: "standard", secret: key });
    await assert.rejects(
      limited.load({ matchId: id, gameNumber: 1 }),
      (e) => riotError(e).retryAfter >= (retryHeader === "7200" ? 7200 : 100),
    );
  }
});
test("timeline failure still stages match with warning; RSO uses Bearer, no API-key impersonation", async () => {
  const f = fixture();
  let header: HeadersInit | undefined;
  const service = new RiotPostgameService((async (url, options) => {
    header = options?.headers;
    return String(url).endsWith("/timeline")
      ? new Response("PRIVATE", { status: 404 })
      : Response.json(f.match);
  }) as typeof fetch);
  service.configure({
    mode: "rso",
    secret: "SYNTHETIC-RSO-TOKEN-FOR-UNIT-TEST",
  });
  const result = await service.load({ matchId: id, gameNumber: 1 });
  assert.match((header as Record<string, string>).Authorization, /^Bearer /);
  assert.equal((header as Record<string, string>)["X-Riot-Token"], undefined);
  assert.equal(result.candidate?.evidence.timelineAvailable, false);
  assert.ok(
    result.candidate?.evidence.warnings.some((w) => w.includes("upstream-404")),
  );
  await assert.rejects(
    service.load({ matchId: "https://evil.test", gameNumber: 1 }),
  );
});
test("clearing credentials while load is pending prevents old result from becoming a candidate", async () => {
  const f = fixture();
  let complete!: (r: Response) => void;
  const service = new RiotPostgameService(
    (async () =>
      await new Promise<Response>((resolve) => {
        complete = resolve;
      })) as typeof fetch,
  );
  service.configure({ mode: "standard", secret: key });
  const pending = service.load({ matchId: id, gameNumber: 1 });
  service.clear();
  complete(Response.json(f.match));
  // Make the following timeline fail immediately after the stale match completes.
  const timer = setInterval(
    () => complete(new Response("", { status: 404 })),
    1,
  );
  try {
    await assert.rejects(pending);
    assert.equal(service.status().candidate, null);
  } finally {
    clearInterval(timer);
  }
});
