// TEST PROCESS ONLY: explicit node --import in system.integration.ts.
// No credentials/game API calls; never imported by application code.
const nativeFetch = globalThis.fetch;
const id = "VN2_123456";
const participants = Array.from({ length: 10 }, (_, i) => ({
  participantId: i + 1,
  teamId: i < 5 ? 100 : 200,
  teamPosition: ["TOP", "JUNGLE", "MIDDLE", "BOTTOM", "UTILITY"][i % 5],
  championId: (i % 5) + 1,
  kills: 1,
  deaths: 1,
  assists: 3,
  goldEarned: i < 5 ? 10000 : 8000,
  totalDamageDealtToChampions: 1000 + i,
  puuid: "SYNTHETIC-PRIVATE-IDENTITY",
  riotIdGameName: "SYNTHETIC-PRIVATE-NAME",
}));
globalThis.fetch = async (input, options) => {
  const url = String(input);
  const prefix = `https://sea.api.riotgames.com/lol/match/v5/matches/${id}`;
  if (url !== prefix && url !== `${prefix}/timeline`)
    return url.startsWith("https://") && new URL(url).hostname.endsWith(".api.riotgames.com") ? new Response("", { status: 404 }) : nativeFetch(input, options);
  if (
    new Headers(options?.headers).get("X-Riot-Token") !==
    "SYNTHETIC-NOT-A-REAL-KEY"
  )
    return new Response("", { status: 403 });
  if (url.endsWith("/timeline"))
    return Response.json({
      metadata: { matchId: id },
      info: {
        frameInterval: 60000,
        frames: [0, 60000, 120000].map((timestamp) => ({
          timestamp,
          events: [],
          participantFrames: Object.fromEntries(
            participants.map((p) => [
              String(p.participantId),
              { totalGold: timestamp ? p.goldEarned : 500 },
            ]),
          ),
        })),
      },
    });
  return Response.json({
    metadata: { matchId: id },
    info: {
      platformId: "VN2",
      gameDuration: 120,
      gameVersion: "16.20.123.456",
      endOfGameResult: "GameComplete",
      participants,
      teams: [100, 200].map((teamId) => ({
        teamId,
        win: teamId === 100,
        bans: [],
        objectives: {
          tower: { kills: 3 },
          baron: { kills: 1 },
          riftHerald: { kills: 1 },
          dragon: { kills: 0 },
          horde: { kills: 3 },
        },
      })),
    },
  });
};
export {};
