// Test cho phần camera tự kết nối của nhân player: nhập code xong camera tự bật khi đã biết room
// (từ code) + Riot ID (từ GEP hoặc nhập tay), tắt tay thì không tự bật lại.
//   npm run test:valorant
import test from 'node:test';
import assert from 'node:assert/strict';
import { canonicalRiotId, createPlayerAgent } from '../player/agent.mjs';

// Lời giải giả: không gọi mạng, không tải/mở client.
const fakeJoin = (camRoom, over = {}) => ({
  kind: 'short',
  code: 'ABCDE',
  origin: 'https://fake.trycloudflare.com',
  groupCode: 'RIOTLOCAL',
  key: '',
  camRoom,
  host: '',
  ...over,
});

const makeAgent = resolver => createPlayerAgent({ resolver, log: () => {}, onUpdate: () => {} });

test('canonicalRiotId chuẩn hoá "Tên #Tag" và giữ nguyên khi thiếu #', () => {
  assert.equal(canonicalRiotId(' Seotoww # 2013 '), 'Seotoww#2013');
  assert.equal(canonicalRiotId('Seotoww#2013'), 'Seotoww#2013');
  assert.equal(canonicalRiotId('Seotoww'), 'Seotoww');
  assert.equal(canonicalRiotId(''), '');
});

test('nhập code có room + đã biết Riot ID → camera tự bật', async () => {
  const agent = makeAgent(async () => fakeJoin('room-a'));
  agent.setRiotId('Seotoww #2013', { manual: true });
  const view = await agent.join('ABCDE', { startClient: false });
  assert.equal(view.cam.on, true);
  assert.equal(view.cam.auto, true);
  assert.equal(view.cam.room, 'room-a');
  assert.equal(view.cam.streamId, 'Seotoww_H_2013');
  assert.match(view.cam.url, /room=room-a/);
  assert.match(view.cam.url, /push=Seotoww_H_2013/);
  assert.equal(view.cam.waiting, null);
});

test('chưa biết Riot ID → chưa bật, báo đang chờ Riot ID', async () => {
  const agent = makeAgent(async () => fakeJoin('room-a'));
  const view = await agent.join('ABCDE', { startClient: false });
  assert.equal(view.cam.on, false);
  assert.match(view.cam.waiting, /Riot ID/);
});

test('code không mang room cam → không bật camera', async () => {
  const agent = makeAgent(async () => fakeJoin(''));
  agent.setRiotId('Seotoww#2013', { manual: true });
  const view = await agent.join('ABCDE', { startClient: false });
  assert.equal(view.cam.on, false);
  assert.match(view.cam.waiting, /room id/);
});

test('GEP đọc được player_name thì tự điền Riot ID và bật camera', async () => {
  const agent = makeAgent(async () => fakeJoin('room-a'));
  let view = await agent.join('ABCDE', { startClient: false });
  assert.equal(view.cam.on, false);
  agent.handleFrame({ k: 'gep', c: 'infoupdate', d: { key: 'player_name', value: 'Seotoww #2013' } });
  view = agent.view();
  assert.equal(view.riotId, 'Seotoww#2013');
  assert.equal(view.cam.on, true);
  assert.equal(view.cam.streamId, 'Seotoww_H_2013');
});

test('Riot ID nhập tay thì GEP không ghi đè', async () => {
  const agent = makeAgent(async () => fakeJoin('room-a'));
  await agent.join('ABCDE', { startClient: false });
  agent.setRiotId('Nhaptay#1111', { manual: true });
  agent.handleFrame({ k: 'gep', c: 'infoupdate', d: { key: 'player_name', value: 'Seotoww #2013' } });
  const view = agent.view();
  assert.equal(view.riotId, 'Nhaptay#1111');
  assert.equal(view.cam.on, true);
});

test('tắt tay thì không tự bật lại dù Riot ID đổi hay join lại', async () => {
  const agent = makeAgent(async () => fakeJoin('room-a'));
  agent.setRiotId('Seotoww#2013', { manual: false });
  assert.equal((await agent.join('ABCDE', { startClient: false })).cam.on, true);

  assert.equal(agent.setCam(false).cam.on, false);
  // GEP đổi tên và join lại vẫn không bật.
  agent.handleFrame({ k: 'gep', c: 'infoupdate', d: { key: 'player_name', value: 'Khac #9999' } });
  assert.equal(agent.view().riotId, 'Khac#9999');
  assert.equal(agent.view().cam.on, false);
  assert.equal((await agent.join('ABCDE', { startClient: false })).cam.on, false);
  // Bật tay lại thì được.
  assert.equal(agent.setCam(true).cam.on, true);
});

test('bỏ chọn tự động thì dừng camera; bật lại thì tự kết nối lại', async () => {
  const agent = makeAgent(async () => fakeJoin('room-a'));
  agent.setRiotId('Seotoww#2013', { manual: true });
  assert.equal((await agent.join('ABCDE', { startClient: false })).cam.on, true);

  const off = agent.setAutoCam(false);
  assert.equal(off.cam.on, false);
  assert.equal(off.cam.auto, false);

  // Chế độ không tự động vẫn bật tay được.
  assert.equal(agent.setCam(true).cam.on, true);

  const on = agent.setAutoCam(true);
  assert.equal(on.cam.auto, true);
  assert.equal(on.cam.on, true);
});

test('rời kết nối (idle) thì camera tắt dù vẫn còn room + Riot ID', async () => {
  const agent = makeAgent(async () => fakeJoin('room-a'));
  agent.setRiotId('Seotoww#2013', { manual: true });
  assert.equal((await agent.join('ABCDE', { startClient: false })).cam.on, true);
  const view = await agent.leave();
  assert.equal(view.phase, 'idle');
  assert.equal(view.cam.on, false);
});
