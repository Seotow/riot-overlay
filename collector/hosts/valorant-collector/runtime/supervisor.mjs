import { spawn } from 'node:child_process';
import { createServer } from 'node:net';
import { access, mkdir, open, readFile, unlink, writeFile } from 'node:fs/promises';
import { dirname, resolve } from 'node:path';
import { moduleRoot, loadKey, overlayDir } from './config.mjs';
import { createFrontend } from './frontend.mjs';
import { officialPaths, officialMatch, startOfficial } from '../client/official.mjs';

export async function availablePort(port) {
  const server = createServer();
  await new Promise((ok, fail) => { server.once('error', fail); server.listen(port, '127.0.0.1', ok); });
  await new Promise(ok => server.close(ok));
}
const pause = ms => new Promise(ok => setTimeout(ok, ms));
export async function backendHealth(port) {
  const res = await fetch(`http://127.0.0.1:${port}/status`, { signal: AbortSignal.timeout(900) });
  const health = await res.json();
  if (!res.ok || health.module !== 'riot-overlay-valorant') throw new Error('Unexpected backend');
  return { status: health.status, matchesRunning: health.matchesRunning, observersConnected: health.observersConnected };
}

export async function startModule({ config, configPath, servicesOnly = false, startupMs = 15000, onState = () => {} }) {
  const runtimeDir = resolve(dirname(configPath), 'runtime');
  const lockPath = resolve(runtimeDir, 'owner.json');
  const children = [];
  let frontend;
  let lock;
  let lockOwned = false;
  let stopping = false;
  let stopPromise;
  let backendState = 'starting';
  let official = null;
  let collectorError = null;
  let collectorState = servicesOnly ? 'external-or-not-launched' : 'awaiting-executable';
  let fatalResolve;
  const fatal = new Promise(ok => { fatalResolve = ok; });
  const stop = () => {
    if (stopPromise) return stopPromise;
    stopping = true;
    stopPromise = (async () => {
    if (official) await official.stop().catch(() => {});
    if (frontend) await new Promise(ok => { frontend.close(ok); frontend.closeAllConnections(); });
    // No shell, process-name kill or global Docker commands. Only exact children owned here.
    for (const child of children.slice().reverse()) {
      if (child.exitCode !== null || child.signalCode !== null) continue;
      const exited = new Promise(ok => child.once('exit', ok));
      if (process.platform === 'win32') {
        // Terminate only the tree rooted at this still-owned child, never by name.
        const terminator = spawn('taskkill.exe', ['/PID', String(child.pid), '/T', '/F'], { windowsHide: true, stdio: 'ignore', shell: false });
        await new Promise(ok => { terminator.once('exit', ok); terminator.once('error', ok); });
      } else child.kill();
      await Promise.race([exited, pause(2000)]);
      if (child.exitCode === null && child.signalCode === null) child.kill('SIGKILL');
    }
    if (lockOwned) { await lock?.close(); await unlink(lockPath).catch(() => {}); }
    backendState = 'stopped';
    })();
    return stopPromise;
  };
  try {
    await access(resolve(moduleRoot, 'backend/dist/index.js'));
    const browserDir = overlayDir;
    await access(resolve(browserDir, 'index.html'));
    const authKey = await loadKey(configPath);
    await mkdir(runtimeDir, { recursive: true });
    try { lock = await open(lockPath, 'wx', 0o600); }
    catch (error) {
      if (error.code !== 'EEXIST') throw error;
      const owner = JSON.parse(await readFile(lockPath, 'utf8'));
      if (!Number.isSafeInteger(owner.pid) || owner.pid <= 0) throw new Error('Invalid module owner file');
      let alive = true;
      try { process.kill(owner.pid, 0); } catch (e) { if (e.code === 'ESRCH') alive = false; }
      if (alive) throw new Error('Valorant module already has a running owner');
      await unlink(lockPath);
      lock = await open(lockPath, 'wx', 0o600);
    }
    lockOwned = true;
    await lock.writeFile(JSON.stringify({ pid: process.pid }));
    for (const port of Object.values(config.ports)) await availablePort(port);
    const backend = spawn(process.execPath, [resolve(moduleRoot, 'backend/dist/index.js')], {
      cwd: runtimeDir, windowsHide: true, stdio: 'ignore', shell: false,
      env: { ...process.env, INSECURE: 'true', USE_BACKEND: 'false', REQUIRE_AUTH_KEY: 'true', AUTH_KEY: authKey,
        VALORANT_PRIVATE_LOGS: 'false', VALORANT_ENABLE_PREVIEWS: 'false',
        VALORANT_INGEST_PORT: String(config.ports.ingest), VALORANT_EXTRAS_PORT: String(config.ports.extras), VALORANT_OUTPUT_PORT: String(config.ports.output),
        VALORANT_BROWSER_ORIGINS: `http://127.0.0.1:${config.ports.frontend},http://localhost:${config.ports.frontend}` },
    });
    children.push(backend);
    backend.on('error', () => { backendState = 'failed'; fatalResolve('backend-start-failed'); });
    backend.on('exit', () => { if (!stopping) { backendState = 'failed'; fatalResolve('backend-exited'); void stop(); } });
    const deadline = Date.now() + startupMs;
    while (true) {
      if (backendState === 'failed') throw new Error('Valorant backend exited during startup');
      try { await backendHealth(config.ports.extras); break; } catch {}
      if (Date.now() > deadline) throw new Error('Valorant backend readiness timeout');
      await pause(100);
    }
    backendState = 'ready';
    const collectorDetail = async () => (official ? { official: official.status(), error: collectorError } : collectorError ? { error: collectorError } : null);
    const getStatus = async () => {
      let health = null;
      try { health = await backendHealth(config.ports.extras); } catch {}
      return { module: 'valorant', groupCode: config.groupCode, backend: health ? backendState : 'unavailable', frontend: stopping ? 'stopped' : 'ready',
        collector: collectorState, collectorDetail: await collectorDetail(), observerConnected: (health?.observersConnected ?? 0) > 0, matchesRunning: health?.matchesRunning ?? 0,
        telemetry: 'not-yet-verified', ports: config.ports };
    };
    frontend = createFrontend({ config, browserDir, getStatus, assetsDir: resolve(dirname(configPath), 'assets') });
    await new Promise((ok, fail) => { frontend.once('error', fail); frontend.listen(config.ports.frontend, '127.0.0.1', ok); });
    frontend.on('error', () => { fatalResolve('frontend-failed'); void stop(); });
    // Client chính thức nguyên vẹn chạy ngầm; module điều khiển giao diện của nó (official.mjs).
    const launchOfficial = async () => {
      const paths = await officialPaths();
      if (!(await access(paths.exe).then(() => true, () => false))) { collectorState = 'official-not-installed'; return; }
      collectorState = 'official-starting';
      const match = await officialMatch(config, configPath, authKey);
      const onOfficial = ({ state }) => { if (!stopping) { collectorState = `official-${state}`; onState(collectorState); } };
      startOfficial({ config, match, onState: onOfficial })
        .then(started => { if (stopping) void started.stop(); else { official = started; collectorState = `official-${started.status().state}`; } })
        .catch(error => { collectorError = error.message; collectorState = 'official-failed'; onState(collectorState); });
    };
    if (!servicesOnly) await launchOfficial();
    onState('services-ready');
    return { stop, getStatus, fatal, pids: children.map(child => child.pid).filter(Boolean) };
  } catch (error) { await stop(); throw error; }
}
