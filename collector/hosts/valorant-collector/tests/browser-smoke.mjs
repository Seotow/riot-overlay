// Isolated browser profile; no game/collector or personal browser is used.
import assert from 'node:assert/strict';
import { createRequire } from 'node:module';
import { mkdir, mkdtemp, rm } from 'node:fs/promises';
import { resolve } from 'node:path';
import { createServer } from 'node:net';
import { workspace, initConfig, loadConfig } from '../runtime/config.mjs';
import { startModule } from '../runtime/supervisor.mjs';
const require = createRequire(import.meta.url);
if (!process.env.OVERLAY_BROWSER_PACKAGES) throw new Error('Set OVERLAY_BROWSER_PACKAGES to bundled Playwright/sharp packages');
const { chromium } = require(resolve(process.env.OVERLAY_BROWSER_PACKAGES, 'playwright'));
const sharp = require(resolve(process.env.OVERLAY_BROWSER_PACKAGES, 'sharp'));
const parent = resolve(workspace, '.npm-cache');
await mkdir(parent, { recursive: true });
const directory = await mkdtemp(resolve(parent, 'valorant-browser-'));
const path = resolve(directory, 'module.json');
await initConfig(path);
const config = await loadConfig(path);
const used = new Set();
for (const name of Object.keys(config.ports)) {
  let port;
  do {
    const s = createServer(); await new Promise(ok => s.listen(0, '127.0.0.1', ok));
    port = s.address().port; await new Promise(ok => s.close(ok));
  } while (used.has(port) || [2999, 4310, 4311, 58869].includes(port));
  used.add(port); config.ports[name] = port;
}
let browser, runtime;
try {
  runtime = await startModule({ config, configPath: path, servicesOnly: true });
  browser = await chromium.launch({ headless: true, channel: 'msedge' });
  const page = await browser.newPage({ viewport: { width: 1920, height: 1080 }, deviceScaleFactor: 1 });
  const errors = [], external = [];
  page.on('pageerror', error => errors.push(error.message));
  page.on('request', req => { if (!new URL(req.url()).hostname.match(/^(127\.0\.0\.1|localhost)$/)) external.push(req.url()); });
  const base = `http://127.0.0.1:${config.ports.frontend}`;
  await page.goto(base + '/_module');
  await page.waitForFunction(() => document.querySelector('#status').textContent.includes('"ready"'));
  await page.screenshot({ path: resolve(parent, 'valorant-module.png') });
  await page.goto(base + '/overlay?groupCode=RIOTLOCAL');
  await page.waitForFunction(() => document.querySelector('app-match-overlay') !== null);
  await page.evaluate(() => document.fonts.ready);
  assert.equal(await page.locator('app-match-overlay app-team-info').count(), 0, 'No initial fixture on OBS');
  const screenshot = await page.screenshot({ omitBackground: true, path: resolve(parent, 'valorant-obs-no-source.png') });
  const pixels = await sharp(screenshot).ensureAlpha().raw().toBuffer();
  assert.ok(pixels.every((value, index) => index % 4 !== 3 || value === 0), 'OBS is transparent with no source');
  await page.goto(base + '/agent-select?groupCode=RIOTLOCAL');
  await page.waitForFunction(() => document.querySelector('app-agent-select-overlay') !== null);
  assert.equal(await page.locator('app-agent-select-overlay app-agent-select').count(), 0);
  assert.deepEqual(errors, []); assert.deepEqual(external, []);
  console.log('PASS: module status, Angular routes, no initial fixture, 1920x1080 transparent OBS, no external requests or JS errors');
} finally {
  await browser?.close(); await runtime?.stop();
  assert.ok(directory.startsWith(resolve(workspace, '.npm-cache', 'valorant-browser-')));
  await rm(directory, { recursive: true, force: true });
}
