import test from "node:test";
import assert from "node:assert/strict";
import { decodeJoinCode, encodeJoinCode, playercamPushUrl } from "../shared/valorant-remote";

const join = {
  origin: "https://brave-fox-lake-1234.trycloudflare.com",
  groupCode: "RIOTLOCAL",
  key: "496870740726 29ec".replace(" ", "") + "6f133096ba0cd0230000000000000000".slice(0, 16),
};

test("code vòng lại đúng origin/groupCode/key", () => {
  const code = encodeJoinCode(join);
  assert.match(code, /^[A-Za-z0-9_-]+$/); // base64url, không có ký tự cần escape
  assert.deepEqual(decodeJoinCode(code), join);
  assert.deepEqual(decodeJoinCode(`  ${code}  `), join); // chấp nhận khoảng trắng thừa
});

test("từ chối code sai dạng", () => {
  assert.equal(decodeJoinCode("khong-phai-base64!@#"), null);
  assert.equal(decodeJoinCode(encodeJoinCode({ ...join, origin: "ftp://x" })), null);
  assert.equal(decodeJoinCode(encodeJoinCode({ ...join, groupCode: "lowercase" })), null);
  assert.equal(decodeJoinCode(encodeJoinCode({ ...join, key: "XYZ" })), null);
  assert.equal(decodeJoinCode(""), null);
});

test("link cam vdo.ninja khớp định dạng overlay (Tên_H_Tag)", () => {
  const url = playercamPushUrl("my room", "Seo Tow#VN1");
  assert.match(url, /vdo\.ninja/);
  assert.match(url, /room=my%20room/);
  assert.match(url, /push=Seo_Tow_H_VN1/);
  assert.match(url, /webcam/);
  // GEP trả "Seotoww #2013" (có dấu cách trước #); overlay dựng từ roster nên phải trim.
  assert.match(playercamPushUrl("room", "Seotoww #2013"), /push=Seotoww_H_2013/);
});

test("bản JS thuần của player dựng link cam khớp bản TS", async () => {
  const mod = (await import(
    // @ts-expect-error JS thuần của runtime player, không có khai báo kiểu
    "../collector/hosts/valorant-collector/player/cam.mjs"
  )) as { playercamPushUrl: (room: string, name: string) => string };
  for (const name of ["Seo Tow#VN1", "Seotoww #2013", "Solo#123"])
    for (const room of ["my room", "room-a"])
      assert.equal(mod.playercamPushUrl(room, name), playercamPushUrl(room, name));
});

test("bản JS thuần của player giải mã khớp bản TS", async () => {
  const mod = (await import(
    // @ts-expect-error JS thuần của runtime player, không có khai báo kiểu
    "../collector/hosts/valorant-collector/player/remote-code.mjs"
  )) as { decodeJoinCode: (code: string) => unknown };
  const decodePlayer = mod.decodeJoinCode;
  assert.deepEqual(decodePlayer(encodeJoinCode(join)), join);
  assert.equal(decodePlayer("rac!!!"), null);
});
