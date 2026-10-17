import { readFile, writeFile, mkdir, access, copyFile, rename } from 'node:fs/promises';
import { dirname, resolve } from 'node:path';
import { randomBytes } from 'node:crypto';
import { fileURLToPath } from 'node:url';

export const workspace = resolve(dirname(fileURLToPath(import.meta.url)), '../../..');
export const moduleRoot = resolve(workspace, 'modules/valorant');
export const defaultConfigPath = resolve(workspace, 'data/valorant/module.json');
export const defaults = Object.freeze({ schemaVersion: 1, groupCode: 'RIOTLOCAL', collectorPath: null, collectorMode: 'fork', frontendVariant: 'val26',
  ports: { ingest: 5310, extras: 5311, output: 5320, frontend: 5322 } });

export function validateConfig(input) {
  if (!input || input.schemaVersion !== 1) throw new Error('Unsupported Valorant config version');
  if (typeof input.groupCode !== 'string' || !/^[A-Z0-9_-]{1,32}$/.test(input.groupCode)) throw new Error('Invalid group code');
  if (input.collectorPath !== null && (typeof input.collectorPath !== 'string' || !input.collectorPath.toLowerCase().endsWith('.exe'))) throw new Error('collectorPath must be an absolute .exe path or null');
  if (input.collectorPath && !/^(?:[A-Za-z]:[\\/]|\/)/.test(input.collectorPath)) throw new Error('Collector path must be absolute');
  const collectorMode = input.collectorMode ?? 'fork';
  if (!['fork', 'official'].includes(collectorMode)) throw new Error('collectorMode must be fork or official');
  const frontendVariant = input.frontendVariant ?? 'val26';
  if (!['val26', 'spectra'].includes(frontendVariant)) throw new Error('frontendVariant must be val26 or spectra');
  const ports = {};
  for (const name of Object.keys(defaults.ports)) {
    const value = input.ports?.[name];
    if (!Number.isInteger(value) || value < 1024 || value > 65535) throw new Error(`Invalid ${name} port`);
    ports[name] = value;
  }
  if (new Set(Object.values(ports)).size !== 4) throw new Error('Valorant ports must be distinct');
  if (Object.values(ports).some(port => [2999, 4310, 4311, 58869].includes(port))) throw new Error('Reserved LoL port');
  return { schemaVersion: 1, groupCode: input.groupCode, collectorPath: input.collectorPath, collectorMode, frontendVariant, ports };
}

export async function initConfig(path = defaultConfigPath, collectorPath = null) {
  const config = validateConfig({ ...defaults, collectorPath });
  await mkdir(dirname(path), { recursive: true });
  // Exclusive writes preserve the user's configuration and access key.
  await writeFile(path, `${JSON.stringify(config, null, 2)}\n`, { flag: 'wx', mode: 0o600 });
  const keyFile = resolve(dirname(path), 'auth.key');
  try { await writeFile(keyFile, randomBytes(32).toString('hex'), { flag: 'wx', mode: 0o600 }); }
  catch (error) { if (error.code !== 'EEXIST') throw error; }
  return config;
}

export async function loadConfig(path = defaultConfigPath) {
  return validateConfig(JSON.parse(await readFile(path, 'utf8')));
}

export async function loadKey(configPath) {
  const key = (await readFile(resolve(dirname(configPath), 'auth.key'), 'utf8')).trim();
  if (!/^[a-f0-9]{64}$/.test(key)) throw new Error('Invalid local access key file');
  return key;
}

export async function setCollectorPath(configPath, collectorPath) {
  const config = validateConfig({ ...await loadConfig(configPath), collectorPath });
  if (collectorPath) await access(collectorPath);
  const backup = `${configPath}.backup-${Date.now()}`;
  await copyFile(configPath, backup);
  const temporary = `${configPath}.tmp-${Date.now()}`;
  await writeFile(temporary, `${JSON.stringify(config, null, 2)}\n`, { flag: 'wx', mode: 0o600 });
  await rename(temporary, configPath);
  return config;
}

// Overlay in-game: bản VAL26 (nobiiVAL, ELv2) nếu đã build, ngược lại về bản Spectra Frontend gốc.
export async function frontendBrowserDir(config) {
  const val26 = resolve(moduleRoot, 'frontend-val26/dist/spectra-frontend/browser');
  const spectra = resolve(moduleRoot, 'frontend/dist/spectra-frontend/browser');
  if (config.frontendVariant === 'val26') {
    try { await access(resolve(val26, 'index.html')); return { variant: 'val26', dir: val26 }; } catch {}
  }
  return { variant: 'spectra', dir: spectra };
}
