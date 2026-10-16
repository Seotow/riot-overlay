import { spawn } from 'node:child_process';
import { createHash } from 'node:crypto';
import { readFile, access, mkdir, writeFile } from 'node:fs/promises';
import http from 'node:http';
import net from 'node:net';
import { dirname, resolve } from 'node:path';
import { fileURLToPath } from 'node:url';

// Fixed user-supplied artifact and bounded lifecycle; never selects another PID,
// injects a DLL, changes privileges, reads LCU secrets or enables account login.
if (process.argv.length !== 2) { console.error('No options accepted.'); process.exit(2); }
const collector = resolve(dirname(fileURLToPath(import.meta.url)), '..');
const root = resolve(collector, '..');
const output = resolve(collector, 'src/LeagueCollector/src/LeagueCollector/bin/Release/net10.0');
const sdk = resolve(root, '.npm-cache/lb-headless/dotnet-10.0.401/dotnet.exe');
const dll = resolve(output, 'LeagueCollector.dll');
const hash = async path => createHash('sha256').update(await readFile(path)).digest('hex');
const port = 18803;
const delay = ms => new Promise(resolve => setTimeout(resolve, ms));
async function portOpen(number) {
  return new Promise(resolve => {
    const socket = net.connect({ host: '127.0.0.1', port: number });
    const finish = result => { socket.destroy(); resolve(result); };
    socket.setTimeout(750, () => finish(false));
    socket.once('connect', () => finish(true));
    socket.once('error', error => error.code === 'EACCES' ? finish(null) : finish(false));
  });
}
async function get(path) {
  return new Promise(resolve => {
    const req = http.get({ hostname: '127.0.0.1', port, path, timeout: 1200 }, response => {
      const chunks = []; let bytes = 0;
      response.on('data', chunk => { bytes += chunk.length; if (bytes > 16 * 1024 * 1024) req.destroy(); else chunks.push(chunk); });
      response.on('end', () => {
        try { resolve({ http: response.statusCode, data: chunks.length ? JSON.parse(Buffer.concat(chunks).toString()) : null }); }
        catch { resolve({ http: response.statusCode, data: null }); }
      });
      response.on('error', () => resolve({ http: response.statusCode, data: null }));
    });
    req.on('timeout', () => req.destroy());
    req.on('error', () => resolve({ http: null, data: null }));
  });
}
const originalNativeHash = 'a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3';
if (await hash(resolve(output, 'lblib.dll')) !== originalNativeHash) throw new Error('Native identity mismatch.');
try { await access(resolve(output, 'collector.env')); throw new Error('Credential file present; do not auto-read it.'); }
catch (error) { if (error.code !== 'ENOENT') throw error; }
const occupied = await portOpen(port);
if (occupied !== false) throw new Error('Validation port unavailable; no process started.');
const env = { ...process.env, DOTNET_CLI_TELEMETRY_OPTOUT: '1', DOTNET_CLI_HOME: resolve(root, '.npm-cache/collector-validation/cli') };
delete env.LB_EMAIL; delete env.LB_PASSWORD;
const evidence = {
  kind: 'collector-no-injection-validation', startedAt: new Date().toISOString(),
  autoInject: false, lcuEnabled: false, accountLoginEnabled: false, productionChanged: false,
  originalNativeSha256: originalNativeHash, hostSha256: await hash(dll),
  farsightSha256: await hash(resolve(output, 'Farsight.dll')),
  nativeListenerBefore: await portOpen(4998), lbListenerBefore: await portOpen(58869),
  samples: [], consoleCategories: {}, gracefulExit: false, forcedOwnedStop: false,
};
const child = spawn(sdk, [dll, '--source', 'lblib', '--no-inject', '--no-lcu', '--port', String(port), '--interval', '100', '--validation-30s-no-inject'],
  { cwd: output, env, windowsHide: true, stdio: ['ignore', 'pipe', 'pipe'] });
let exited = false; let exitCode = null; let launchFailed = false;
let consoleText = '';
const collect = chunk => { if (consoleText.length < 65536) consoleText += chunk.toString().slice(0, 65536 - consoleText.length); };
child.stdout.on('data', collect); child.stderr.on('data', collect);
const closed = new Promise(resolve => {
  child.once('error', () => { launchFailed = true; exited = true; resolve(); });
  child.once('close', code => { exited = true; exitCode = code; resolve(); });
});
const hardStop = setTimeout(() => { if (!exited) { evidence.forcedOwnedStop = true; child.kill(); } }, 45000);
try {
  for (let i = 0; i < 35 && !exited; i++) {
    const status = await get('/api/status');
    const snapshot = await get('/api/snapshot');
    const frame = snapshot.data;
    const heroes = Array.isArray(frame?.data?.heroes) ? frame.data.heroes : [];
    const count = predicate => heroes.filter(predicate).length;
    const number = value => Number.isFinite(value) ? value : null;
    const state = status.data?.collector;
    const safeStates = ['starting', 'waiting', 'streaming', 'error', 'ended', 'stopped'];
    const safeErrors = ['native_connection_failed', 'native_feature_authentication_failed', 'snapshot_registration_failed', 'snapshot_decode_failed', 'game_ended', 'windows_required', 'source_failed', 'invalid_source_data'];
    const stages = ['watching', 'window-detected', 'awaiting-ipc', 'ready', 'registering-service', 'service-rejected', 'awaiting-snapshot', 'streaming', 'disconnected', 'initialization-failed', 'handshake-failed', 'stopping', 'stop-failed', 'capture-stop-unavailable', 'stopped'];
    evidence.samples.push({ at: new Date().toISOString(), statusHttp: status.http, snapshotHttp: snapshot.http,
      collectorState: safeStates.includes(state?.state) ? state.state : null,
      nativeStage: stages.includes(state?.nativeStage) ? state.nativeStage : null,
      collectorError: safeErrors.includes(state?.error) ? state.error : null,
      snapshots: number(state?.snapshots), fresh: typeof state?.fresh === 'boolean' ? state.fresh : null,
      authentication: ['not-configured', 'authenticated', 'authenticated-subscription-unavailable', 'authentication-failed', 'challenge-signing-failed'].includes(status.data?.authentication?.state) ? status.data.authentication.state : null,
      nativeFrame: frame?.source === 'lblib' && frame?.synthetic === false,
      gameTime: number(frame?.data?.gameTime), heroes: heroes.length,
      coverage: { hp: count(h => Number.isFinite(h.common?.health)), maxHp: count(h => Number.isFinite(h.common?.maxHealth)),
        gold: count(h => Number.isFinite(h.gold)), totalGold: count(h => Number.isFinite(h.totalGold)),
        items: count(h => Array.isArray(h.items) && h.items.length > 0),
        spells: count(h => Array.isArray(h.spells) && h.spells.length > 0) },
    });
    await Promise.race([delay(1000), closed]);
  }
  await Promise.race([closed, delay(8000)]);
} finally {
  if (!exited) { evidence.forcedOwnedStop = true; child.kill(); await Promise.race([closed, delay(3000)]); }
  clearTimeout(hardStop);
}
for (const [category, pattern] of Object.entries({
  processPathUnavailable: /Failed to obtain process path/, processVersionUnavailable: /Failed to obtain process version/,
  windowDetectorUnavailable: /Failed to set.*hook|Failed to create.*hook/i,
  featureRejected: /Failed to verify subscription tier|Lib handshake failed/,
  portConflict: /address already in use|AddressInUse/i,
  hostAnnounced: /LeagueCollector: http:/,
})) evidence.consoleCategories[category] = pattern.test(consoleText);
consoleText = ''; // Do not persist native exception text or raw snapshots.
evidence.exitCode = exitCode; evidence.launchFailed = launchFailed;
evidence.gracefulExit = exited && exitCode === 0 && !evidence.forcedOwnedStop;
evidence.nativeListenerAfter = await portOpen(4998);
evidence.finishedAt = new Date().toISOString();
const directory = resolve(collector, 'evidence/validation');
await mkdir(directory, { recursive: true });
const name = `no-inject-${evidence.startedAt.replaceAll(':', '-')}.json`;
await writeFile(resolve(directory, name), JSON.stringify(evidence, null, 2), { flag: 'wx' });
console.log(JSON.stringify({ evidence: name, samples: evidence.samples.length, nativeFrames: evidence.samples.filter(s => s.nativeFrame).length,
  maximumHeroes: Math.max(0, ...evidence.samples.map(s => s.heroes)), finalState: evidence.samples.at(-1)?.collectorState,
  finalError: evidence.samples.at(-1)?.collectorError, nativeListenerBefore: evidence.nativeListenerBefore,
  lbListenerBefore: evidence.lbListenerBefore, gracefulExit: evidence.gracefulExit, launchFailed }));
