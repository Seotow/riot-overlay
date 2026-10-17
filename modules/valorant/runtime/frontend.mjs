import { createServer } from 'node:http';
import { readFile } from 'node:fs/promises';
import { resolve, extname, sep } from 'node:path';

const mime = { '.jpg': 'image/jpeg', '.html': 'text/html; charset=utf-8', '.js': 'text/javascript', '.css': 'text/css', '.json': 'application/json', '.png': 'image/png', '.webp': 'image/webp', '.svg': 'image/svg+xml', '.woff2': 'font/woff2', '.jpg': 'image/jpeg', '.ico': 'image/x-icon' };
const page = `<!doctype html><html lang="vi"><meta charset="utf-8"><title>Riot Overlay · Valorant</title>
<style>body{background:#111b25;color:#e5edf5;font:16px system-ui;max-width:900px;margin:50px auto;padding:20px}a{color:#74e5bc}pre{white-space:pre-wrap;background:#1e2b39;padding:20px}p{line-height:1.6}</style>
<h1>Module Valorant</h1><p>Backend, frontend và collector chạy riêng với LoL. Kết nối Socket.IO chưa chứng minh đang có telemetry live.</p>
<pre id="status">Đang kiểm tra…</pre><p><a id="overlay">Mở renderer OBS</a> · <a id="draft">Mở agent select</a></p>
<p>OBS dùng 1920 × 1080. Khi chưa có nguồn, renderer trống và nền trong suốt. Bản module hiện giữ giao diện ValoSpectra; chưa custom/audit toàn bộ telemetry.</p>
<script>async function refresh(){try{const s=await(await fetch('/api/module/status')).json();document.getElementById('status').textContent=JSON.stringify(s,null,2);document.getElementById('overlay').href='/overlay?groupCode='+encodeURIComponent(s.groupCode);document.getElementById('draft').href='/agent-select?groupCode='+encodeURIComponent(s.groupCode)}catch{document.getElementById('status').textContent='Module không phản hồi'}}refresh();setInterval(refresh,1500)</script></html>`;

export function createFrontend({ config, browserDir, getStatus, assetsDir }) {
  const base = resolve(browserDir);
  return createServer(async (req, res) => {
    const host = req.headers.host;
    if (![ `127.0.0.1:${config.ports.frontend}`, `localhost:${config.ports.frontend}` ].includes(host)) { res.writeHead(403).end(); return; }
    if (!['GET', 'HEAD'].includes(req.method)) { res.writeHead(405, { Allow: 'GET, HEAD' }).end(); return; }
    res.setHeader('X-Content-Type-Options', 'nosniff');
    const send = (body, type, code = 200) => { res.writeHead(code, { 'Content-Type': type, 'Cache-Control': 'no-store' }); res.end(req.method === 'HEAD' ? undefined : body); };
    try {
      const url = new URL(req.url, `http://${host}`);
      if (url.pathname === '/' || url.pathname === '/_module') { send(page, mime['.html']); return; }
      if (url.pathname === '/api/module/status') { send(JSON.stringify(await getStatus()), mime['.json']); return; }
      // Logo do operator tải lên từ Studio: chỉ tên file dạng hash, không đi qua đường dẫn tự do.
      const upload = /^\/uploads\/([a-f0-9]{16}\.(?:png|jpg|webp))$/.exec(url.pathname);
      if (upload && assetsDir) {
        try { send(await readFile(resolve(assetsDir, upload[1])), mime[extname(upload[1])] ?? 'image/png'); }
        catch { send('Not found', 'text/plain', 404); }
        return;
      }
      if (url.pathname === '/assets/config/config.json') {
        const upstream = JSON.parse(await readFile(resolve(base, 'assets/config/config.json'), 'utf8'));
        send(JSON.stringify({ ...upstream, serverEndpoint: `http://127.0.0.1:${config.ports.output}`, extrasEndpoint: `http://127.0.0.1:${config.ports.extras}`, mapbanEndpoint: '', statsEndpoint: '', redirectUrl: '/_module' }), mime['.json']); return;
      }
      // Preview fixtures and unintegrated cloud features are not exposed as live routes.
      if (/^\/(testing|mapban|team-breakdown|map-breakdown)(\/|$)/.test(url.pathname)) { send('Route chưa tích hợp', 'text/plain', 404); return; }
      const relative = decodeURIComponent(url.pathname).replace(/^\/+/, '');
      const candidate = resolve(base, relative);
      if (!candidate.startsWith(base + sep)) { send('Forbidden', 'text/plain', 403); return; }
      try { send(await readFile(candidate), mime[extname(candidate)] ?? 'application/octet-stream'); }
      catch {
        if (/^\/(overlay(?:\/minimal)?|agent-select|autoswitch(?:\/minimal)?)\/?$/.test(url.pathname)) send(await readFile(resolve(base, 'index.html')), mime['.html']);
        else send('Not found', 'text/plain', 404);
      }
    } catch { send('Request failed', 'text/plain', 400); }
  });
}
