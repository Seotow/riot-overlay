import test from "node:test";
import assert from "node:assert/strict";
import {
  DataTypes,
  formatKillfeedData,
  formatRosterData,
  formatRoundData,
  formatScoreboardData,
} from "./src/protocol";
import { GepSession } from "./src/gep";

// Hình dạng sự kiện theo tài liệu Overwolf GEP của Valorant (key + value dạng chuỗi JSON). Đây là fixture
// tổng hợp để kiểm hàm dịch, không phải dữ liệu trận thật.
const VALORANT = 21640;
const scoreboard = {
  name: "Tester #VN1",
  player_id: "p-1",
  team: 1,
  character: "Thorne",
  alive: true,
  armor: 25,
  weapon: "TX_Hud_Pistol_Compact",
  ult_points: 3,
  ult_max: 7,
  spike: "TX_Hud_Bomb_S",
  money: 1900,
  kills: 2,
  deaths: 1,
  assists: 0,
};

function harness() {
  const sent: { type: string; data: any }[] = [];
  let connected = true;
  let ended = 0;
  let connects = 0;
  const ingest: any = {
    isConnected: () => connected,
    send: (m: { type: string; data: any }) => {
      sent.push(m);
      return connected;
    },
    endMatch: () => ended++,
  };
  const session: any = new GepSession(ingest, () => connects++);
  return {
    session,
    sent,
    ended: () => ended,
    connects: () => connects,
    setConnected: (v: boolean) => (connected = v),
  };
}
const info = (key: string, value: unknown) => ({
  gameId: VALORANT,
  key,
  value: typeof value === "string" ? value : JSON.stringify(value),
});

test("scoreboard: tên tách theo ' #', spike dạng chuỗi hoặc boolean, giáp armor/shield", () => {
  const f: any = formatScoreboardData(scoreboard);
  assert.equal(f.type, DataTypes.SCOREBOARD);
  assert.deepEqual(
    {
      n: f.data.name,
      t: f.data.tagline,
      spike: f.data.hasSpike,
      armor: f.data.initialArmor,
      w: f.data.scoreboardWeaponInternal,
    },
    { n: "Tester", t: "VN1", spike: true, armor: 25, w: "TX_Hud_Pistol_Compact" },
  );
  const old: any = formatScoreboardData({
    ...scoreboard,
    armor: undefined,
    shield: 50,
    spike: false,
  });
  assert.equal(old.data.initialArmor, 50);
  assert.equal(old.data.hasSpike, false);
});

test("roster, killfeed và round được format đúng định dạng ingest", () => {
  const roster: any = formatRosterData(
    { name: "A #B", team: 0, character: "Clay", player_id: "x", locked: true, rank: 12 },
    "roster_3",
  );
  assert.equal(roster.data.position, 3);
  assert.equal(roster.data.tagline, "B");
  const kill: any = formatKillfeedData({
    attacker: "A",
    victim: "B",
    weapon: "w",
    headshot: true,
    assist1: "C",
    assist2: "",
    is_victim_teammate: false,
  });
  assert.deepEqual(kill.data.assists, ["C"]);
  assert.deepEqual(formatRoundData("combat", 4), {
    type: DataTypes.ROUND_INFO,
    data: { roundNumber: 4, roundPhase: "combat" },
  });
});

test("GepSession dịch sự kiện GEP thành thông điệp ingest", () => {
  const h = harness();
  h.session.processInfoUpdate(info("scoreboard_0", scoreboard));
  h.session.processInfoUpdate(
    info("roster_1", {
      name: "A #B",
      team: 1,
      character: "Clay",
      player_id: "p",
      locked: true,
      rank: 3,
    }),
  );
  h.session.processInfoUpdate(info("round_number", "2"));
  h.session.processInfoUpdate(info("round_phase", "combat"));
  h.session.processInfoUpdate(info("match_score", { team_0: 1, team_1: 0 }));
  h.session.processInfoUpdate(
    info("kill_feed", {
      attacker: "A",
      victim: "B",
      weapon: "w",
      headshot: false,
      assist1: "",
      assist2: "",
      assist3: "",
      assist4: "",
      is_victim_teammate: false,
    }),
  );
  assert.deepEqual(
    h.sent.map((m) => m.type),
    [
      DataTypes.SCOREBOARD,
      DataTypes.ROSTER,
      DataTypes.ROUND_INFO,
      DataTypes.SCORE,
      DataTypes.KILLFEED,
    ],
  );
  assert.deepEqual(h.sent[2].data, { roundNumber: 2, roundPhase: "combat" });
  assert.equal(h.session.phase(), "combat");
  // scoreboard rỗng/đóng-mở và tên trống bị bỏ qua như upstream
  h.session.processInfoUpdate(info("scoreboard_1", "open"));
  h.session.processInfoUpdate(info("scoreboard_2", { ...scoreboard, name: "" }));
  assert.equal(h.sent.length, 5);
});

test("sự kiện trận: spike, kết thúc trận và nối ingest ở màn chọn agent", () => {
  const h = harness();
  h.session.processGameEvent({ gameId: VALORANT, key: "spike_planted" });
  h.session.processGameEvent({ gameId: VALORANT, key: "spike_defused" });
  h.session.processGameEvent({ gameId: VALORANT, key: "spike_detonated" });
  assert.deepEqual(
    h.sent.map((m) => m.type),
    [DataTypes.SPIKE_PLANTED, DataTypes.SPIKE_DEFUSED, DataTypes.SPIKE_DETONATED],
  );
  h.session.processInfoUpdate(info("scene", "CharacterSelectPersistentLevel"));
  assert.equal(h.connects(), 1);
  h.session.processInfoUpdate(info("round_phase", "game_end"));
  assert.equal(h.ended(), 1);
  h.session.processGameEvent({ gameId: VALORANT, key: "match_end" });
  assert.equal(h.ended(), 2);
  // game khác bị bỏ qua
  h.session.processGameEvent({ gameId: 999, key: "spike_planted" });
  assert.equal(h.sent.length, 4);
});

test("map 'Infinity' được đổi tên; map/game_mode chờ nối ingest rồi mới gửi", async () => {
  const h = harness();
  h.session.processInfoUpdate(info("map", "Infinity"));
  h.session.processInfoUpdate(info("game_mode", { mode: "bomb", custom: true }));
  assert.deepEqual(
    h.sent.map((m) => [m.type, m.data]),
    [
      [DataTypes.MAP, "Infinityy"],
      [DataTypes.GAME_MODE, "bomb"],
    ],
  );
  assert.equal(h.session.status().map, "Infinityy");
});
