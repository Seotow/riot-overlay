const root = "https://raw.communitydragon.org/16.20";
const html = await (await fetch(root + "/game/assets/spells/icons2d/")).text();
console.log(
  [...html.matchAll(/href="([^"]+)"/g)].map((m) => m[1]).filter((x) => /smite|teleport/i.test(x)),
);
const dataHtml = await (
  await fetch(root + "/plugins/rcp-be-lol-game-data/global/default/assets/data/spells/icons2d/")
).text();
console.log(
  [...dataHtml.matchAll(/href="([^"]+)"/g)]
    .map((m) => m[1])
    .filter((x) => /smite|teleport/i.test(x)),
);
const dataResponse = await fetch(root + "/game/data/spells/icons2d/");
const dataGame = await dataResponse.text();
console.log(
  "game/data",
  dataResponse.status,
  [...dataGame.matchAll(/href="([^"]+)"/g)]
    .map((m) => m[1])
    .filter((x) => /smite|teleport/i.test(x)),
);
const list = await (
  await fetch(root + "/plugins/rcp-be-lol-game-data/global/default/v1/summoner-spells.json")
).json();
console.log(
  list
    .filter((s) => /smite|teleport/i.test(s.name))
    .map((s) => ({ id: s.id, name: s.name, icon: s.iconPath })),
);
console.log(
  await (
    await fetch(
      "https://raw.githubusercontent.com/BlueBottleGG/leaguebroadcast-js-client/main/types/ingame/tab/tabTeam.ts",
    )
  ).text(),
);
