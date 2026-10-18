import { access } from 'node:fs/promises';
import { resolve } from 'node:path';
import { defaultConfigPath, ensureConfig, initConfig, loadConfig, moduleRoot, overlayDir } from './config.mjs';
import { officialPaths } from '../client/official.mjs';
import { startModule, availablePort } from './supervisor.mjs';

const args = process.argv.slice(2);
const command = args[0] ?? 'doctor';
const value = name => { const i = args.indexOf(name); return i < 0 ? undefined : args[i + 1]; };
const configPath = resolve(value('--config') ?? defaultConfigPath);
const exists = path => access(path).then(() => true, () => false);
try {
  if (command === 'init') {
    await initConfig(configPath);
    console.log('Đã tạo config Valorant và key riêng trong collector/hosts/valorant-collector/local. Không ghi đè cấu hình LoL.');
  } else if (command === 'doctor') {
    const config = await loadConfig(configPath);
    const result = {
      config: 'valid',
      backendBuild: await exists(resolve(moduleRoot, 'backend/dist/index.js')),
      overlayBuild: await exists(resolve(overlayDir, 'index.html')),
      spectraClient: (await exists((await officialPaths()).exe)) ? 'installed' : 'not-installed (tự tải khi bật kết nối hoặc npm run valorant:setup)',
      ports: {},
    };
    for (const [name, port] of Object.entries(config.ports)) { try { await availablePort(port); result.ports[name] = 'free'; } catch { result.ports[name] = 'occupied'; } }
    console.log(JSON.stringify(result, null, 2));
  } else if (command === 'start') {
    const config = await ensureConfig(configPath);
    const runtime = await startModule({ config, configPath, servicesOnly: args.includes('--services-only') });
    console.log(`Valorant module: http://127.0.0.1:${config.ports.frontend}/_module`);
    console.log(`Collector ingest: http://127.0.0.1:${config.ports.ingest}; group ${config.groupCode}`);
    let closing = false;
    const shutdown = async code => { if (closing) return; closing = true; await runtime.stop(); process.exit(code); };
    process.on('SIGINT', () => void shutdown(0));
    process.on('SIGTERM', () => void shutdown(0));
    await runtime.fatal;
    await shutdown(1);
  } else throw new Error('Command must be init, doctor or start');
} catch (error) {
  // Do not print provider payload, key, config contents or raw child output.
  console.error(error.code === 'EEXIST' ? 'Cấu hình đã tồn tại; không ghi đè.' : error.code === 'ENOENT' ? 'Thiếu config hoặc build. Xem docs/VALORANT_MODULE.md.' : error.code === 'EADDRINUSE' ? 'Cổng Valorant đang có process khác. Không tự dừng process đó.' : error.message);
  process.exitCode = 1;
}
