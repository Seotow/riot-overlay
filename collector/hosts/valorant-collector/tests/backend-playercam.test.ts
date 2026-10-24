// Test cho Player cam tự động phía host: player auxiliary báo kết nối → host tự thêm Riot ID của họ
// (khớp roster theo playerId) vào Player cam, gỡ khi ngắt, và giữ lại sau khi host cập nhật cấu hình.
// Dùng tsx để nạp thẳng mã TypeScript của backend.
//   npm run test:valorant
import test from "node:test";
import assert from "node:assert/strict";
import { Match } from "../backend/src/model/Match";
import { DataTypes, IFormattedRoster } from "../backend/src/model/eventData";
import { ToolsData } from "../backend/src/model/ToolsData";

const authTeam = (name: string, tricode: string, attackStart: boolean) => ({
  name,
  tricode,
  url: "",
  attackStart,
});

function makeMatch(playercams: Partial<ToolsData["playercamsInfo"]> = {}) {
  const tools = new ToolsData();
  Object.assign(tools.playercamsInfo, {
    enable: true,
    identifier: "room-a",
    enabledPlayers: [],
    ...playercams,
  });
  const match = new Match({
    type: DataTypes.AUTH,
    clientVersion: "0.3.5",
    obsName: "Riot Overlay",
    key: "",
    groupCode: "RIOTLOCAL",
    leftTeam: authTeam("Team 1", "T1", true),
    rightTeam: authTeam("Team 2", "T2", false),
    toolsData: tools,
    isSupporter: false,
  } as never);
  return match;
}

const enabled = (match: Match): string[] =>
  (match as unknown as { tools: ToolsData }).tools.playercamsInfo.enabledPlayers;

const rosterFrame = (playerId: string, name: string, tagline: string, startTeam = 0) => ({
  type: DataTypes.ROSTER,
  data: {
    playerId,
    name,
    tagline,
    startTeam,
    agentInternal: "Jett",
    position: 0,
    locked: true,
    rank: 0,
  } as IFormattedRoster,
  timestamp: Date.now(),
});

test("player auxiliary kết nối trước, roster tới sau → tự thêm Riot ID", async () => {
  const match = makeMatch();
  match.setAuxConnected("pid-1");
  assert.deepEqual(enabled(match), [], "chưa có roster thì chưa thêm");
  await match.receiveMatchSpecificData(rosterFrame("pid-1", "Seotoww", "2013") as never);
  assert.deepEqual(enabled(match), ["Seotoww#2013"]);
});

test("roster có trước, player kết nối sau → tự thêm ngay", async () => {
  const match = makeMatch();
  await match.receiveMatchSpecificData(rosterFrame("pid-2", "Seo Tow", "VN1") as never);
  assert.deepEqual(enabled(match), []);
  match.setAuxConnected("pid-2");
  assert.deepEqual(enabled(match), ["Seo Tow#VN1"]);
});

test("playerId lạ không khớp roster thì không thêm gì", async () => {
  const match = makeMatch();
  match.setAuxConnected("pid-la");
  await match.receiveMatchSpecificData(rosterFrame("pid-3", "Khac", "9999") as never);
  assert.deepEqual(enabled(match), []);
});

test("host chưa đặt room id thì không tự thêm", async () => {
  const match = makeMatch({ identifier: "" });
  match.setAuxConnected("pid-4");
  await match.receiveMatchSpecificData(rosterFrame("pid-4", "Seotoww", "2013") as never);
  assert.deepEqual(enabled(match), []);
});

test("ngắt kết nối gỡ đúng mục tự thêm, giữ mục host nhập tay", async () => {
  const match = makeMatch({ enabledPlayers: ["Nhap tay#0001"] });
  match.setAuxConnected("pid-5");
  await match.receiveMatchSpecificData(rosterFrame("pid-5", "Seotoww", "2013") as never);
  assert.deepEqual(enabled(match), ["Nhap tay#0001", "Seotoww#2013"]);
  match.setAuxDisconnected("pid-5");
  assert.deepEqual(enabled(match), ["Nhap tay#0001"]);
});

test("host cập nhật lại cấu hình giữa trận vẫn giữ mục tự thêm", async () => {
  const match = makeMatch();
  match.setAuxConnected("pid-6");
  await match.receiveMatchSpecificData(rosterFrame("pid-6", "Seotoww", "2013") as never);
  // Studio/host gửi config mới thay danh sách Player cam.
  await match.receiveMatchSpecificData({
    type: DataTypes.CONFIG_UPDATE,
    data: { playercams: { enable: true, identifier: "room-a", enabledPlayers: ["Host them#2222"] } },
    timestamp: Date.now(),
  } as never);
  assert.deepEqual(enabled(match), ["Host them#2222", "Seotoww#2013"]);
});
