import test from "node:test";
import assert from "node:assert/strict";
import { cleanPlayerName, draftPlayerName, playerDisplayName } from "../shared/player-name";
import { normalizeIngame } from "../server/ingame-adapter";
import { broadcastColors, SECONDARY_BLUE } from "../shared/broadcast-colors";
import { defaultTheme, themeSchema } from "../shared/schema";
import { swapTeamSides } from "../shared/match-config";
test("nickname uses Riot game name, strips tag, permits Unicode and preserves missing", () => {
  assert.equal(cleanPlayerName(" Seotoww#2013 "), "Seotoww");
  assert.equal(cleanPlayerName("Tên người chơi#VN2"), "Tên người chơi");
  assert.equal(cleanPlayerName("#VN2"), null);
  assert.equal(cleanPlayerName(undefined), null);
  const s = normalizeIngame(
    {
      allPlayers: [
        {
          riotIdGameName: "Seotoww",
          riotId: "Seotoww#2013",
          summonerName: "old",
          championId: 157,
          team: "ORDER",
        },
      ],
    },
    {},
    "2026-10-17T00:00:00Z",
  );
  const p = s.players[0];
  assert.equal(p.playerName?.value, "Seotoww");
  assert.equal(playerDisplayName(p), "Seotoww");
  assert.equal(playerDisplayName(p, ["TournamentName#VN2"]), "TournamentName");
  assert.equal(playerDisplayName({ ...p, playerName: undefined }), "Yasuo");
});
test("ten explicit nicknames round-trip config and follow team side swap", () => {
  const t = themeSchema.parse({
    ...defaultTheme,
    playerNames: Array.from({ length: 10 }, (_, i) => `Name${i}`),
  });
  assert.equal(swapTeamSides(t).playerNames?.[0], "Name5");
  assert.deepEqual(swapTeamSides(swapTeamSides(t)).playerNames, t.playerNames);
  assert.equal(themeSchema.safeParse({ ...t, playerNames: ["OnlyOne"] }).success, false);
});
test("team colours are the light blue and the dark red, ignoring the old dark blue and light red", () => {
  assert.deepEqual(broadcastColors({ blueSecondary: "#69afd4", red: "#c42b35" }), {
    blue: SECONDARY_BLUE,
    red: "#c42b35",
  });
  assert.deepEqual(broadcastColors({ blueSecondary: undefined, red: "#bb243b" }), {
    blue: SECONDARY_BLUE,
    red: "#bb243b",
  });
  assert.deepEqual(broadcastColors({ blueSecondary: "#123456", red: "#654321" }), {
    blue: "#123456",
    red: "#654321",
  });
});

test("draft shows the typed name and falls back to the exact client name", () => {
  assert.equal(draftPlayerName(["Faker"], "RealName", 0), "Faker");
  assert.equal(draftPlayerName(["  "], "RealName", 0), "RealName");
  assert.equal(draftPlayerName(undefined, "RealName", 3), "RealName");
  assert.equal(draftPlayerName(["", "Alias#VN2"], "RealName", 1), "Alias");
});
