const $ = id => document.getElementById(id);
const wsUrl = `ws://${location.host}/ws`;
if ($('ws')) $('ws').textContent = wsUrl;
if ($('copy')) $('copy').onclick = async () => { try { await navigator.clipboard.writeText(wsUrl); $('copy').textContent = 'Đã sao chép'; } catch { $('copy').textContent = 'Chọn URL để sao chép'; } };
const display = value => value === null || value === undefined ? '—' : typeof value === 'number' ? Math.round(value).toLocaleString('vi') : String(value);
function showFrame(frame) {
  if (frame.type !== 'snapshot') return;
  const data = frame.data;
  $('badge').textContent = frame.source === 'replay' ? 'BẢN GHI PHÁT LẠI' : frame.synthetic ? 'DỮ LIỆU MẪU' : 'DỮ LIỆU GAME';
  $('badge').className = 'badge ' + (frame.synthetic || frame.source === 'replay' ? 'synthetic' : 'live');
  const seconds = Number(data.gameTime);
  if ($('time')) $('time').textContent = Number.isFinite(seconds) ? `${Math.floor(seconds/60)}:${String(Math.floor(seconds%60)).padStart(2,'0')}` : '—';
  const rows = (data.heroes || []).map(hero => {
    const info = hero.info || {}, common = hero.common || {}, scores = hero.scores || {};
    const row = document.createElement('tr');
    const values = [info.team ?? hero.team, `${info.name || hero.riotIdGameName || hero.summonerName || '—'} / ${common.identifier || hero.championName || '—'}`, common.level ?? hero.level,
      `${display(common.health)} / ${display(common.maxHealth)}`, `${display(hero.kills ?? scores.kills)} / ${display(hero.deaths ?? scores.deaths)} / ${display(hero.assists ?? scores.assists)}`, hero.gold];
    for (const value of values) { const cell = document.createElement('td'); cell.textContent = display(value); row.append(cell); }
    return row;
  });
  $('heroes').replaceChildren(...rows);
  if ($('raw')) $('raw').textContent = JSON.stringify(frame, null, 2).slice(0, 100000);
}
async function status() {
  try {
    const response = await fetch('/api/status'); if (!response.ok) throw Error();
    const state = await response.json(), c = state.collector;
    if ($('source')) $('source').textContent = c.source;
    if ($('frames')) $('frames').textContent = display(c.snapshots);
    if ($('age')) $('age').textContent = c.ageMs === null ? '—' : `${display(c.ageMs)} ms`;
    if ($('state')) $('state').textContent = c.state;
    if ($('auth')) $('auth').textContent = state.authentication.state;
    if ($('record')) $('record').textContent = `${state.recording.state} · ${state.recording.written} frames · ${state.recording.dropped} mất`;
    const nativeAuthNotice = c.source !== 'lblib' ? '' : state.authentication.state === 'not-configured' ? 'Chưa cấu hình tài khoản. Nhánh không đăng nhập chưa được xác nhận thu đủ dữ liệu Free hoặc giữ kết nối.' : state.authentication.state.includes('subscription-unavailable') ? 'Đăng nhập thành công nhưng chưa xác nhận quyền; bộ quyền rỗng không chứng minh phiên Free hợp lệ.' : '';
    if ($('notice')) $('notice').textContent = [c.error, nativeAuthNotice, c.source === 'demo' ? 'Đang phát dữ liệu mô phỏng để kiểm tra kết nối overlay.' : c.source === 'replay' ? 'Đang đọc bản ghi; đây không phải dữ liệu trực tiếp.' : c.fresh ? 'Collector đang nhận dữ liệu.' : 'Đang chờ dữ liệu game.'].filter(Boolean).join(' ');
    if ($('validation')) $('validation').textContent = `Bản ${state.validation.release}: chưa kiểm chứng game thật, dữ liệu Free hoặc nhánh không đăng nhập. Native dùng lblib.dll gốc.`;
    if (!c.fresh) { $('heroes').replaceChildren(); if ($('time')) $('time').textContent = '—'; $('badge').textContent = 'CHƯA CÓ DỮ LIỆU MỚI'; $('badge').className = 'badge'; }
    const lcu = await fetch('/api/lcu');
    if (lcu.status === 200 && $('phase')) $('phase').textContent = (await lcu.json()).data.phase || 'Chờ client';
  } catch { $('badge').textContent = 'MẤT KẾT NỐI'; $('badge').className = 'badge'; $('heroes').replaceChildren(); }
}
function connect() { const ws = new WebSocket(wsUrl); ws.onmessage = e => { try { showFrame(JSON.parse(e.data)); } catch {} }; ws.onclose = () => setTimeout(connect, 1000); ws.onerror = () => ws.close(); }
connect(); status(); setInterval(status, 1000);
