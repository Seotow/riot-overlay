// Test cho code ngắn 5 ký tự: sinh/tra code, công bố và phân giải qua điểm hẹn giả (không gọi mạng
// ngoài), và quy tắc stream id cam khớp overlay.
//   npm run test:valorant
import test from 'node:test';
import assert from 'node:assert/strict';
import { createServer } from 'node:http';
import {
  CODE_ALPHABET,
  CODE_LENGTH,
  buildPayload,
  newCode,
  normalizeCode,
  publishCode,
  rendezvousService,
  resolveCode,
  resolveErrorMessage,
  topicFor,
  validatePayload,
} from '../runtime/rendezvous.mjs';
import { camStreamId, playercamPushUrl, streamIdProblem } from '../player/cam.mjs';
import { resolveJoin } from '../player/join-code.mjs';

// Điểm hẹn giả giữ message theo topic, trả NDJSON giống ntfy khi poll.
async function fakeRendezvous() {
  const messages = new Map();
  const server = createServer((req, res) => {
    const path = (req.url || '/').split('?')[0];
    const topic = decodeURIComponent(path.replace(/^\//, '').replace(/\/json$/, ''));
    if (req.method === 'POST') {
      const chunks = [];
      req.on('data', chunk => chunks.push(Buffer.from(chunk)));
      req.on('end', () => {
        const list = messages.get(topic) || [];
        list.push(Buffer.concat(chunks).toString('utf8'));
        messages.set(topic, list);
        res.writeHead(200, { 'Content-Type': 'application/json' });
        res.end('{"event":"message"}');
      });
      return;
    }
    const events = (messages.get(topic) || []).map(message => JSON.stringify({ event: 'message', topic, message }));
    res.writeHead(200, { 'Content-Type': 'application/x-ndjson' });
    res.end(events.join('\n'));
  });
  await new Promise(ok => server.listen(0, '127.0.0.1', ok));
  const { port } = server.address();
  return { service: `http://127.0.0.1:${port}`, close: () => new Promise(ok => server.close(ok)) };
}

const longCode = (origin, groupCode, key) =>
  Buffer.from(JSON.stringify([origin, groupCode, key])).toString('base64url');

test('code ngắn: 5 ký tự, không dùng ký tự dễ đọc nhầm', () => {
  assert.equal(CODE_LENGTH, 5);
  for (const character of '01ILO') assert.equal(CODE_ALPHABET.includes(character), false, character);
  for (let i = 0; i < 200; i++) {
    const code = newCode();
    assert.equal(code.length, 5);
    for (const character of code) assert.ok(CODE_ALPHABET.includes(character), code);
    assert.equal(normalizeCode(code), code);
  }
  const seen = new Set(Array.from({ length: 200 }, () => newCode()));
  assert.ok(seen.size > 190, `chỉ có ${seen.size} code khác nhau trong 200 lần sinh`);
});

test('chuẩn hoá code: bỏ khoảng trắng/gạch, viết hoa; từ chối code sai', () => {
  assert.equal(normalizeCode(' abcde '), 'ABCDE');
  assert.equal(normalizeCode('a-b c d e'), 'ABCDE');
  assert.equal(normalizeCode('ABCD'), null, '4 ký tự');
  assert.equal(normalizeCode('ABCDEF'), null, '6 ký tự');
  assert.equal(normalizeCode('ABCD1'), null, 'chứa 1');
  assert.equal(normalizeCode('ABCDO'), null, 'chứa O');
  assert.equal(normalizeCode(''), null);
  assert.throws(() => topicFor('abc'), /Code không hợp lệ/);
  assert.equal(topicFor('abcde'), 'riotovl-abcde');
});

test('payload hợp lệ, và bị từ chối khi sai', () => {
  const payload = buildPayload({
    origin: 'https://brave-fox.trycloudflare.com',
    groupCode: 'RIOTLOCAL',
    camRoom: 'phong-1',
  });
  assert.equal(validatePayload(payload), null);
  assert.equal(validatePayload({ ...payload, v: 2 }), 'payload version không hỗ trợ: 2');
  assert.equal(validatePayload(null), 'payload không phải object');
  assert.match(validatePayload({ ...payload, origin: 'ftp://x' }), /origin không hợp lệ/);
  assert.match(validatePayload({ ...payload, origin: 'https://x/y' }), /origin không hợp lệ/);
  assert.match(validatePayload({ ...payload, groupCode: 'lowercase' }), /groupCode không hợp lệ/);
  assert.match(validatePayload({ ...payload, camRoom: 'phòng 1' }), /camRoom không hợp lệ/);
  assert.throws(() => buildPayload({ origin: 'khong-phai-url' }), /Payload công bố không hợp lệ/);
});

test('công bố rồi phân giải đúng code; đổi URL tunnel thì đăng lại cùng code', async () => {
  const fake = await fakeRendezvous();
  try {
    const code = newCode();
    const first = buildPayload({ origin: 'https://one.trycloudflare.com', groupCode: 'RIOTLOCAL', camRoom: 'room-a' });
    assert.equal((await publishCode(code, first, { service: fake.service })).ok, true);

    const resolved1 = await resolveCode(code.toLowerCase(), { service: fake.service });
    assert.equal(resolved1.error, null);
    assert.deepEqual(resolved1.payload, first);

    const second = buildPayload({ origin: 'https://two.trycloudflare.com', groupCode: 'RIOTLOCAL', camRoom: 'room-a' });
    await publishCode(code, second, { service: fake.service });
    const resolved2 = await resolveCode(code, { service: fake.service });
    assert.equal(resolved2.payload.origin, 'https://two.trycloudflare.com');

    const missing = await resolveCode('ZZZZZ', { service: fake.service });
    assert.equal(missing.error, 'not-found');
    assert.match(resolveErrorMessage('not-found'), /Không thấy code này/);
    assert.equal((await resolveCode('abc', { service: fake.service })).error, 'code-invalid');
  } finally {
    await fake.close();
  }
});

test('payload rác trên topic bị bỏ qua, không làm hỏng lần phân giải sau', async () => {
  const fake = await fakeRendezvous();
  try {
    const code = newCode();
    const topic = topicFor(code);
    await publishCode(code, buildPayload({ origin: 'https://good.trycloudflare.com' }), { service: fake.service });
    // Giả lập message hỏng do người khác đăng cùng topic.
    await fetch(`${fake.service}/${topic}`, { method: 'POST', body: 'khong-phai-json' });
    const resolved = await resolveCode(code, { service: fake.service });
    assert.equal(resolved.payload.origin, 'https://good.trycloudflare.com');
  } finally {
    await fake.close();
  }
});

test('điểm hẹn không tới được thì báo lỗi rõ, không treo', async () => {
  const result = await resolveCode('ABCDE', { service: 'http://127.0.0.1:1', timeout: 500 });
  assert.equal(result.error, 'unreachable');
  assert.match(resolveErrorMessage('unreachable'), /Không kết nối được điểm hẹn/);
  assert.ok(rendezvousService().startsWith('http'));
});

test('player phân giải cả code ngắn (qua điểm hẹn) lẫn code dài cũ', async () => {
  const fake = await fakeRendezvous();
  try {
    const code = newCode();
    await publishCode(
      code,
      buildPayload({ origin: 'https://short.trycloudflare.com', groupCode: 'RIOTLOCAL', camRoom: 'r1' }),
      { service: fake.service },
    );
    const short = await resolveJoin(` ${code.toLowerCase()} `, { service: fake.service });
    assert.equal(short.kind, 'short');
    assert.equal(short.origin, 'https://short.trycloudflare.com');
    assert.equal(short.camRoom, 'r1');
    assert.equal(short.key, '', 'code ngắn không mang key');

    const key = 'a'.repeat(64);
    const long = await resolveJoin(longCode('https://long.trycloudflare.com', 'RIOTLOCAL', key), {
      service: fake.service,
    });
    assert.equal(long.kind, 'long');
    assert.equal(long.origin, 'https://long.trycloudflare.com');
    assert.equal(long.key, key);

    await assert.rejects(() => resolveJoin('khong-phai-code'), /Code phải có đúng 5 ký tự/);
    await assert.rejects(() => resolveJoin(''), /Chưa nhập code/);
  } finally {
    await fake.close();
  }
});

test('stream id cam khớp quy tắc overlay (<Tên>_H_<Tag>)', () => {
  // Overlay dựng stream id từ roster (name#tagline, không dấu cách); GEP trả "Seotoww #2013".
  assert.equal(camStreamId('Seotoww #2013'), 'Seotoww_H_2013');
  assert.equal(camStreamId('Seo Tow#VN1'), 'Seo_Tow_H_VN1');
  const url = playercamPushUrl('room-a', 'Seotoww #2013');
  assert.match(url, /room=room-a/);
  assert.match(url, /push=Seotoww_H_2013/);
  assert.match(url, /cleanoutput/);
  assert.match(url, /noaudio/);
  assert.match(url, /webcam/);
  assert.equal(streamIdProblem('Seotoww #2013'), null);
  assert.match(streamIdProblem('Seotoww'), /Tên#Tag/);
  assert.match(streamIdProblem(''), /Chưa biết Riot ID/);
});
