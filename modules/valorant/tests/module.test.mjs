import test from 'node:test';
import assert from 'node:assert/strict';
import { mkdir, mkdtemp, readFile, writeFile, rm, access } from 'node:fs/promises';
import { resolve } from 'node:path';
import { createServer, request } from 'node:http';
import { io } from '../backend/node_modules/socket.io-client/build/esm/index.js';
import { workspace, defaults, validateConfig, initConfig, loadConfig, loadKey, setCollectorPath } from '../runtime/config.mjs';
import { startModule, availablePort } from '../runtime/supervisor.mjs';

async function freePort() {
  const server = createServer();
  await new Promise(ok => server.listen(0, '127.0.0.1', ok));
  const port = server.address().port;
  await new Promise(ok => server.close(ok));
  return port;
}
async function temporaryConfig() {
  const parent = resolve(workspace, '.npm-cache');
  await mkdir(parent, { recursive: true });
  const directory = await mkdtemp(resolve(parent, 'valorant-test-'));
  const path = resolve(directory, 'module.json');
  await initConfig(path);
  const config = await loadConfig(path);
  const used = new Set();
  for (const name of Object.keys(config.ports)) {
    let port;
    do { port = await freePort(); } while (used.has(port));
    used.add(port); config.ports[name] = port;
  }
  return { config, path, directory, clean: async () => {
    assert.ok(directory.startsWith(resolve(workspace, '.npm-cache', 'valorant-test-')));
    await rm(directory, { recursive: true, force: true });
  } };
}
function event(socket, name, timeout = 5000) {
  return new Promise((ok, fail) => {
    const timer = setTimeout(() => { socket.off(name, handler); fail(new Error(`Timeout waiting for ${name}`)); }, timeout);
    const handler = value => { clearTimeout(timer); ok(value); };
    socket.once(name, handler);
  });
}
async function connect(port, options = {}) {
  const socket = io(`http://127.0.0.1:${port}`, { transports: ['websocket'], reconnection: false, ...options });
  await event(socket, 'connect');
  return socket;
}

test('config isolates LoL, rejects duplicate ports, command injection and unsafe paths', () => {
  assert.deepEqual(validateConfig(defaults), defaults);
  assert.throws(() => validateConfig({ ...defaults, ports: { ...defaults.ports, ingest: 4310 } }));
  assert.throws(() => validateConfig({ ...defaults, ports: { ...defaults.ports, ingest: defaults.ports.output } }));
  assert.throws(() => validateConfig({ ...defaults, groupCode: '__proto__' }));
  assert.throws(() => validateConfig({ ...defaults, groupCode: 'A; rm' }));
  assert.throws(() => validateConfig({ ...defaults, collectorPath: 'spectra.exe' }));
  assert.throws(() => validateConfig({ ...defaults, collectorPath: 'C:/Spectra/start.cmd' }));
});

test('init never overwrites config or key; secrets are not in config', async () => {
  const temp = await temporaryConfig();
  try {
    const before = await loadKey(temp.path);
    await assert.rejects(initConfig(temp.path), { code: 'EEXIST' });
    assert.equal(await loadKey(temp.path), before);
    assert.ok(!(await readFile(temp.path, 'utf8')).includes(before));
  } finally { await temp.clean(); }
});

test('collector configuration checks path and preserves access key, group and ports', async () => {
  const temp = await temporaryConfig();
  try {
    const previous = await loadConfig(temp.path);
    const key = await loadKey(temp.path);
    await assert.rejects(setCollectorPath(temp.path, resolve(temp.directory, 'missing.exe')), { code: 'ENOENT' });
    assert.deepEqual(await loadConfig(temp.path), previous);
    const executable = resolve(temp.directory, 'Spectra Client.exe');
    await writeFile(executable, 'configuration test only; not executed');
    await setCollectorPath(temp.path, executable);
    assert.deepEqual(await loadConfig(temp.path), { ...previous, collectorPath: executable });
    assert.equal(await loadKey(temp.path), key);
  } finally { await temp.clean(); }
});

test('port conflict fails without stopping the existing listener or leaving ownership', async () => {
  const temp = await temporaryConfig();
  const existing = createServer((req, res) => res.end('existing-server'));
  await new Promise(ok => existing.listen(temp.config.ports.extras, '127.0.0.1', ok));
  try {
    await assert.rejects(startModule({ config: temp.config, configPath: temp.path, servicesOnly: true }), { code: 'EADDRINUSE' });
    assert.equal(await (await fetch(`http://127.0.0.1:${temp.config.ports.extras}`)).text(), 'existing-server');
    await assert.rejects(access(resolve(temp.directory, 'runtime/owner.json')), { code: 'ENOENT' });
  } finally { await new Promise(ok => existing.close(ok)); await temp.clean(); }
});

test('backend failure cleans up module; unrelated service continues and restart succeeds', async () => {
  const temp = await temporaryConfig();
  const sentinel = createServer((req, res) => res.end('unrelated-module'));
  await new Promise(ok => sentinel.listen(0, '127.0.0.1', ok));
  let runtime;
  try {
    runtime = await startModule({ config: temp.config, configPath: temp.path, servicesOnly: true });
    process.kill(runtime.pids[0]);
    assert.equal(await runtime.fatal, 'backend-exited');
    await runtime.stop();
    for (const port of Object.values(temp.config.ports)) await availablePort(port);
    assert.equal(await (await fetch(`http://127.0.0.1:${sentinel.address().port}`)).text(), 'unrelated-module');
    runtime = await startModule({ config: temp.config, configPath: temp.path, servicesOnly: true });
    assert.equal((await runtime.getStatus()).backend, 'ready');
  } finally { await runtime?.stop(); await new Promise(ok => sentinel.close(ok)); await temp.clean(); }
});

test('real fork startup, read-only frontend, Socket.IO auth/reconnect, source loss and owned shutdown', async () => {
  const temp = await temporaryConfig();
  const sentinel = createServer((req, res) => res.end('unrelated-module'));
  await new Promise(ok => sentinel.listen(0, '127.0.0.1', ok));
  const sentinelPort = sentinel.address().port;
  const sockets = [];
  let runtime;
  try {
    runtime = await startModule({ config: temp.config, configPath: temp.path, servicesOnly: true });
    const status = await runtime.getStatus();
    assert.equal(status.backend, 'ready');
    assert.equal(status.observerConnected, false);
    const base = `http://127.0.0.1:${temp.config.ports.frontend}`;
    assert.equal((await fetch(base)).status, 200);
    assert.equal((await fetch(`${base}/overlay?groupCode=RIOTLOCAL`)).status, 200);
    assert.equal((await fetch(`${base}/testing`)).status, 404);
    assert.equal((await fetch(`${base}/api/module/status`, { method: 'POST' })).status, 405);
    const wrongHost = await new Promise((ok, fail) => {
      const req = request(`${base}/api/module/status`, { headers: { Host: 'attacker.example' } }, res => { res.resume(); ok(res.statusCode); });
      req.on('error', fail); req.end();
    });
    assert.equal(wrongHost, 403);
    const config = await (await fetch(`${base}/assets/config/config.json`)).json();
    assert.equal(config.serverEndpoint, `http://127.0.0.1:${temp.config.ports.output}`);
    assert.equal(config.mapbanEndpoint, '');
    assert.ok(!JSON.stringify(await (await fetch(`${base}/api/module/status`)).json()).includes(await loadKey(temp.path)));
    const body = await fetch(`http://127.0.0.1:${temp.config.ports.extras}/createPreview`, { method: 'PUT', headers: { 'Content-Type': 'application/json' }, body: '{}' });
    assert.equal(body.status, 403);
    await assert.rejects(startModule({ config: temp.config, configPath: temp.path, servicesOnly: true }), /running owner/);

    const invalid = await connect(temp.config.ports.ingest); sockets.push(invalid);
    const rejected = event(invalid, 'obs_logon_ack');
    invalid.emit('obs_logon', JSON.stringify({ type: 'authenticate', clientVersion: '0.3.3', groupCode: 'INVALID', key: 'invalid-key' }));
    assert.equal(JSON.parse(await rejected).value, false);

    const output = await connect(temp.config.ports.output); sockets.push(output);
    const ready = event(output, 'logon_success');
    output.emit('logon', JSON.stringify({ groupCode: 'RIOTLOCAL' })); await ready;
    const observer = await connect(temp.config.ports.ingest); sockets.push(observer);
    const authenticated = event(observer, 'obs_logon_ack');
    observer.emit('obs_logon', JSON.stringify({ type: 'authenticate', clientVersion: '0.3.3', obsName: 'Synthetic transport test', groupCode: 'RIOTLOCAL', key: await loadKey(temp.path),
      leftTeam: { name: 'TEST-A', tricode: 'A', url: '', attackStart: true }, rightTeam: { name: 'TEST-B', tricode: 'B', url: '', attackStart: false }, toolsData: {} }));
    assert.equal(JSON.parse(await authenticated).value, true);
    const snapshot = event(output, 'match_data');
    observer.emit('obs_data', JSON.stringify({ obsName: 'Synthetic transport test', groupCode: 'RIOTLOCAL', type: 'match_start', data: 'synthetic-match' }));
    const data = JSON.parse(await snapshot);
    assert.equal(data.groupCode, 'RIOTLOCAL');
    assert.ok(!('groupSecret' in data));
    assert.equal((await runtime.getStatus()).observerConnected, true);
    const source = await event(output, 'source_status');
    assert.equal(source.connected, true); assert.ok(source.lastDataAt > 0);
    const second = await connect(temp.config.ports.output); sockets.push(second);
    const reconnectSnapshot = event(second, 'match_data');
    second.emit('logon', JSON.stringify({ groupCode: 'RIOTLOCAL' }));
    assert.equal(JSON.parse(await reconnectSnapshot).matchId, 'synthetic-match');
    observer.disconnect();
    const disconnected = await event(output, 'source_status');
    assert.equal(disconnected.connected, false);
    await assert.rejects(access(resolve(temp.directory, 'runtime/replays')), { code: 'ENOENT' });
    await runtime.stop();
    for (const port of Object.values(temp.config.ports)) await availablePort(port);
    assert.equal(await (await fetch(`http://127.0.0.1:${sentinelPort}`)).text(), 'unrelated-module');
  } finally {
    sockets.forEach(socket => socket.disconnect());
    await runtime?.stop();
    await new Promise(ok => sentinel.close(ok));
    await temp.clean();
  }
});
