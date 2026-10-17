// Explicit test preload: no request reaches the real game API.
import https from "node:https";
import { EventEmitter } from "node:events";
import { Readable } from "node:stream";
import { syncBuiltinESMExports } from "node:module";
const original = https.request;
(https as any).request = (options: any, callback: any) => {
  if (Number(options.port) !== 2999) return original(options, callback);
  const req: any = new EventEmitter();
  req.destroy = () => {};
  req.end = () =>
    queueMicrotask(() => {
      const body = {
        gameData: { gameTime: 100, mapNumber: 11 },
        events: { Events: [] },
        allPlayers: Array.from({ length: 10 }, (_, i) => ({
          team: i < 5 ? "ORDER" : "CHAOS",
          rawChampionName: "game_character_displayname_Yasuo",
          level: 10,
          scores: { kills: 0, deaths: 0, assists: 0, creepScore: 40 },
          items: [],
          summonerName: "GameplayNamePreserved",
          token: "AUTH_SENTINEL",
        })),
      };
      const response: any = Readable.from([Buffer.from(JSON.stringify(body))]);
      response.statusCode = 200;
      callback(response);
    });
  return req;
};
syncBuiltinESMExports();
