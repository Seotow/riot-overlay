import { readFile, writeFile, mkdir, access } from 'node:fs/promises';
import { dirname, resolve } from 'node:path';
import { randomBytes } from 'node:crypto';
import { fileURLToPath } from 'node:url';

export const workspace = resolve(dirname(fileURLToPath(import.meta.url)), '../../../..');
// ValorantCollector là một host tự chứa; dữ liệu cục bộ (config, key, Spectra Client, profile, logo) nằm ở local/ và bị Git bỏ qua.
export const moduleRoot = resolve(workspace, 'collector/hosts/valorant-collector');
export const localRoot = resolve(moduleRoot, 'local');
export const defaultConfigPath = resolve(localRoot, 'module.json');
export const defaults = Object.freeze({ schemaVersion: 1, groupCode: 'RIOTLOCAL',
  ports: { ingest: 5310, extras: 5311, output: 5320, frontend: 5322 } });

// Các khoá cũ (collectorPath, collectorMode, frontendVariant) của bản trước được bỏ qua khi đọc.
export function validateConfig(input) {
  if (!input || input.schemaVersion !== 1) throw new Error('Unsupported Valorant config version');
  if (typeof input.groupCode !== 'string' || !/^[A-Z0-9_-]{1,32}$/.test(input.groupCode)) throw new Error('Invalid group code');
  const ports = {};
  for (const name of Object.keys(defaults.ports)) {
    const value = input.ports?.[name];
    if (!Number.isInteger(value) || value < 1024 || value > 65535) throw new Error(`Invalid ${name} port`);
    ports[name] = value;
  }
  if (new Set(Object.values(ports)).size !== 4) throw new Error('Valorant ports must be distinct');
  if (Object.values(ports).some(port => [2999, 4310, 4311, 58869].includes(port))) throw new Error('Reserved LoL port');
  return { schemaVersion: 1, groupCode: input.groupCode, ports };
}

export async function initConfig(path = defaultConfigPath) {
  const config = validateConfig(defaults);
  await mkdir(dirname(path), { recursive: true });
  // Exclusive writes preserve the user's configuration and access key.
  await writeFile(path, `${JSON.stringify(config, null, 2)}\n`, { flag: 'wx', mode: 0o600 });
  const keyFile = resolve(dirname(path), 'auth.key');
  try { await writeFile(keyFile, randomBytes(32).toString('hex'), { flag: 'wx', mode: 0o600 }); }
  catch (error) { if (error.code !== 'EEXIST') throw error; }
  return config;
}

export async function loadConfig(path = defaultConfigPath) {
  let text;
  try { text = await readFile(path, 'utf8'); }
  catch (error) {
    if (error.code === 'ENOENT') throw new Error(`Chưa có cấu hình Valorant (${path}). Chạy "npm run valorant:init" hoặc bật công tắc trong Studio để tự tạo.`);
    throw error;
  }
  try { return validateConfig(JSON.parse(text)); }
  catch (error) { throw new Error(`Cấu hình Valorant không hợp lệ (${path}): ${error.message}`); }
}

// Máy mới: local/ không nằm trong Git nên chưa có module.json và auth.key; tự tạo, không ghi đè bản đã có.
export async function ensureConfig(path = defaultConfigPath) {
  try { await access(path); } catch { await initConfig(path); }
  try { await access(resolve(dirname(path), 'auth.key')); }
  catch { await writeFile(resolve(dirname(path), 'auth.key'), randomBytes(32).toString('hex'), { flag: 'wx', mode: 0o600 }).catch(error => { if (error.code !== 'EEXIST') throw error; }); }
  return loadConfig(path);
}

export async function loadKey(configPath) {
  const key = (await readFile(resolve(dirname(configPath), 'auth.key'), 'utf8')).trim();
  if (!/^[a-f0-9]{64}$/.test(key)) throw new Error('Invalid local access key file');
  return key;
}

// Overlay in-game: bản VAL26 (nobiiVAL, ELv2), build ở frontend-val26/dist.
export const overlayDir = resolve(moduleRoot, 'frontend-val26/dist/spectra-frontend/browser');
