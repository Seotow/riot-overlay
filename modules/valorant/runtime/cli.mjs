import { access } from 'node:fs/promises';
import { resolve } from 'node:path';
import { defaultConfigPath, frontendBrowserDir, initConfig, loadConfig, moduleRoot, setCollectorPath } from './config.mjs';
import { startModule, availablePort } from './supervisor.mjs';

const args = process.argv.slice(2);
const command = args[0] ?? 'doctor';
const value = name => { const i = args.indexOf(name); return i < 0 ? undefined : args[i + 1]; };
const configPath = resolve(value('--config') ?? defaultConfigPath);
try {
  if (command === 'init') {
    await initConfig(configPath, value('--collector') ?? null);
    console.log('Đã tạo config Valorant và key riêng trong data/valorant. Không ghi đè cấu hình LoL.');
  } else if (command === 'set-collector') {
    const executable = value('--collector') ?? args[1];
    if (!executable) throw new Error('Provide --collector with an absolute executable path');
    await setCollectorPath(configPath, executable);
    console.log('Đã gắn executable collector; giữ nguyên key, group code và port. Khởi động lại module để áp dụng.');
  } else if (command === 'doctor') {
    const config = await loadConfig(configPath);
    const result = { config: 'valid', backendBuild: false, frontendBuild: false, collector: config.collectorPath ? 'missing' : 'not-configured', ports: {} };
    try { await access(resolve(moduleRoot, 'backend/dist/index.js')); result.backendBuild = true; } catch {}
    try { const { dir, variant } = await frontendBrowserDir(config); await access(resolve(dir, 'index.html')); result.frontendBuild = true; result.frontendVariant = variant; } catch {}
    if (config.collectorPath) { try { await access(config.collectorPath); result.collector = 'executable-found-gep-unverified'; } catch {} }
    for (const [name, port] of Object.entries(config.ports)) { try { await availablePort(port); result.ports[name] = 'free'; } catch { result.ports[name] = 'occupied'; } }
    console.log(JSON.stringify(result, null, 2));
  } else if (command === 'start') {
    const config = await loadConfig(configPath);
    const runtime = await startModule({ config, configPath, servicesOnly: args.includes('--services-only') });
    console.log(`Valorant module: http://127.0.0.1:${config.ports.frontend}/_module`);
    console.log(`Collector ingest: http://127.0.0.1:${config.ports.ingest}; group ${config.groupCode}`);
    if (!config.collectorPath && !args.includes('--services-only')) console.log('Cần đường dẫn Spectra Client .exe. Backend/FE đã chạy; chưa có telemetry game.');
    let closing = false;
    const shutdown = async code => { if (closing) return; closing = true; await runtime.stop(); process.exit(code); };
    process.on('SIGINT', () => void shutdown(0));
    process.on('SIGTERM', () => void shutdown(0));
    await runtime.fatal;
    await shutdown(1);
  } else throw new Error('Command must be init, set-collector, doctor or start');
} catch (error) {
  // Do not print provider payload, key, config contents or raw child output.
  console.error(error.code === 'EEXIST' ? 'Cấu hình đã tồn tại; không ghi đè.' : error.code === 'ENOENT' ? 'Thiếu config, build hoặc executable. Xem docs/VALORANT_MODULE.md.' : error.code === 'EADDRINUSE' ? 'Cổng Valorant đang có process khác. Không tự dừng process đó.' : error.message);
  process.exitCode = 1;
}
