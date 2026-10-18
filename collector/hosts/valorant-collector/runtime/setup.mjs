// Dựng module Valorant trên máy mới: config + key, backend, overlay VAL26 và collector (build từ source).
// Mỗi bước tự bỏ qua nếu đã có kết quả. Không chạy script npm của dependency (--ignore-scripts), không chạy
// installer và không đụng Overwolf cài sẵn; runtime ow-electron được tải bằng đúng script của gói đó.
import { spawn } from 'node:child_process';
import { access } from 'node:fs/promises';
import { resolve } from 'node:path';
import { defaultConfigPath, ensureConfig, moduleRoot } from './config.mjs';
import { acquireOfficial, officialPaths } from '../client/official.mjs';

const exists = path => access(path).then(() => true, () => false);

function run(command, args, cwd, log) {
  return new Promise((ok, fail) => {
    // npm/npx là .cmd trên Windows nên cần shell; node.exe có khoảng trắng trong đường dẫn thì chạy thẳng, không qua shell.
    const shell = process.platform === 'win32' && command !== process.execPath;
    const child = spawn(command, args, { cwd, shell, windowsHide: true, stdio: ['ignore', 'pipe', 'pipe'] });
    let last = '';
    const forward = chunk => { const text = String(chunk).trim(); if (text) { last = text.split(/\r?\n/).slice(-1)[0]; log(last); } };
    child.stdout.on('data', forward);
    child.stderr.on('data', forward);
    child.on('error', fail);
    child.on('exit', code => (code === 0 ? ok() : fail(new Error(`${args.slice(0, 2).join(' ')} thất bại (mã ${code})${last ? `: ${last}` : ''}`))));
  });
}

export async function setupSteps() {
  const config = await ensureConfig(defaultConfigPath);
  const backend = resolve(moduleRoot, 'backend');
  const overlay = resolve(moduleRoot, 'frontend-val26');
  const ci = (cwd, label) => ({ label, done: () => exists(resolve(cwd, 'node_modules')), run: log => run('npm', ['ci', '--ignore-scripts', '--no-audit', '--no-fund'], cwd, log) });
  return [
    { label: 'Cấu hình và key local', done: () => exists(defaultConfigPath), run: async () => { await ensureConfig(defaultConfigPath); } },
    { ...ci(backend, 'Backend Spectra: cài dependency') },
    { label: 'Backend Spectra: build', done: () => exists(resolve(backend, 'dist/index.js')), run: log => run('npm', ['run', 'build'], backend, log) },
    { ...ci(overlay, 'Overlay VAL26: cài dependency') },
    { label: 'Overlay VAL26: build', done: () => exists(resolve(overlay, 'dist/spectra-frontend/browser/index.html')), run: log => run('npm', ['run', 'build'], overlay, log) },
    // Spectra Client chính thức: tải một lần nếu máy chưa có (kiểm SHA256 đã pin trong collector/hosts/valorant-collector/client/release.json).
    { label: 'Spectra Client chính thức: tải một lần (SHA256 đã pin)', done: async () => exists((await officialPaths()).exe), run: log => acquireOfficial(config, log) },
  ];
}

/** Chạy các bước còn thiếu; onStep(label) báo bước đang làm. Trả về số bước đã chạy. */
export async function runSetup({ force = false, onStep = () => {}, log = () => {} } = {}) {
  let ran = 0;
  for (const step of await setupSteps()) {
    if (!force && await step.done()) continue;
    onStep(step.label);
    await step.run(log);
    ran++;
  }
  return ran;
}

export async function setupPending() {
  for (const step of await setupSteps()) if (!(await step.done())) return true;
  return false;
}
