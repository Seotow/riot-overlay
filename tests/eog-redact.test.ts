import test from "node:test";
import assert from "node:assert/strict";
import { describeEog, redactEog } from "../server/eog-redact";

const payload = {
  gameId: 1607368559,
  gameLength: 786,
  mucJwtDto: { jwt: "secret.token.value", domain: "x" },
  multiUserChatPassword: "pw",
  teams: [
    {
      isWinningTeam: true,
      players: [
        {
          puuid: "abc",
          riotIdGameName: "Seotoww",
          riotIdTagLine: "2013",
          summonerName: "Seotoww",
          summonerId: 42,
          championId: 157,
          championName: "Yasuo",
          teamId: 100,
          note: "Seotoww#2013",
          stats: { CHAMPIONS_KILLED: 9, TOTAL_DAMAGE_DEALT_TO_CHAMPIONS: 40241, WIN: 1 },
        },
      ],
    },
  ],
};

test("EOG redaction keeps shape and numbers and removes identity, chat and tokens", () => {
  const { value, removed } = redactEog(payload);
  const text = JSON.stringify(value);
  for (const secret of ["abc", "Seotoww", "secret.token", 'pw"', '2013"', '"puuid'])
    assert.ok(!text.includes(secret), secret);
  assert.ok(removed >= 7);
  assert.match(text, /"championName":"Yasuo"/);
  assert.match(text, /"TOTAL_DAMAGE_DEALT_TO_CHAMPIONS":40241/);
  assert.match(text, /"gameId":1607368559/);
});

test("EOG description reports players and whether damage to champions is present", () => {
  const d = describeEog(payload);
  assert.equal(d.players, 1);
  assert.equal(d.hasDamageToChampions, true);
  assert.ok((d.playerStatKeys as string[]).includes("WIN"));
  assert.deepEqual(describeEog(null).players, 0);
});
