// Chạy Spectra Client CHÍNH THỨC (bản phát hành nguyên vẹn, danh tính Overwolf đã đăng ký của Spectra) ở dạng ngầm.
// Không sửa binary hay app.asar: tải một lần (kiểm SHA256), chạy với profile riêng, rồi điều khiển giao diện của chính
// Client qua Chrome DevTools Protocol trên cổng loopback ngẫu nhiên để điền form và bấm Connect, và ẩn cửa sổ.
import { spawn } from "node:child_process";
import { createServer } from "node:net";
import { createHash } from "node:crypto";
import { createWriteStream } from "node:fs";
import { access, mkdir, readFile, rename, rm } from "node:fs/promises";
import { dirname, resolve } from "node:path";
import { Readable } from "node:stream";
import { pipeline } from "node:stream/promises";
import { createRequire } from "node:module";
import WebSocket from "ws";
import { fileURLToPath } from "node:url";
import { localRoot, workspace } from "../runtime/config.mjs";

const require = createRequire(import.meta.url);
const exists = (path) =>
  access(path).then(
    () => true,
    () => false,
  );
const pause = (ms) => new Promise((ok) => setTimeout(ok, ms));

export async function releaseInfo() {
  return JSON.parse(
    await readFile(resolve(dirname(fileURLToPath(import.meta.url)), "release.json"), "utf8"),
  );
}

/** Cổng loopback trống: inspector cần cổng biết trước, khỏi phải đọc stderr. */
const freePort = () =>
  new Promise((ok, fail) => {
    const server = createServer();
    server.once("error", fail);
    server.listen(0, "127.0.0.1", () => {
      const { port } = server.address();
      server.close(() => ok(port));
    });
  });

/** Chờ inspector của main process lên rồi trả target "node". */
async function waitForMainTarget(port, timeoutMs = 20000) {
  const deadline = Date.now() + timeoutMs;
  while (Date.now() < deadline) {
    try {
      const list = await (await fetch(`http://127.0.0.1:${port}/json/list`)).json();
      const node = list.find((t) => t.type === "node");
      if (node) return node;
    } catch {}
    await pause(300);
  }
  return null;
}

/**
 * Tap chạy trong main process của Client, đẩy frame ra named pipe.
 * NODE_OPTIONS=--require bị Electron chặn với app đã đóng gói (đã đo trên 0.3.4), nên đường vào là
 * `--inspect=<cổng>` + Runtime.evaluate: lấy process.mainModule.require rồi gọi tap.install().
 * Không sửa binary/asar; đóng inspector ngay sau khi gắn.
 */
export const tapPipe = "\\\\.\\pipe\\riot-spectra-tap";
const tapModule = () => resolve(dirname(fileURLToPath(import.meta.url)), "tap/tap.cjs").replace(/\\/g, "/");

/**
 * Client tự thêm ":5100" khi URL không kèm cổng (connectorService.handleAuthProcess).
 * Quick tunnel chỉ nghe 443, relay LAN nghe cổng riêng → luôn gửi URL có cổng tường minh.
 */
export function withIngestPort(url) {
  const text = String(url ?? "").replace(/\/+$/, "");
  if (/^https?:\/\/[^/]+:\d+/.test(text)) return text;
  return `${text}:${text.startsWith("https://") ? 443 : 80}`;
}

// Vá tap ở main process qua CDP. `require` không phải biến toàn cục trong main process, và
// `process.mainModule` không phải lúc nào cũng có (Electron có thể đã bỏ nó, hoặc evaluate chạy quá
// sớm) — từng gặp lỗi "Cannot read properties of undefined (reading 'require')". Vì vậy thử lần lượt:
// require của command-line API (Node inspector cấp khi includeCommandLineAPI), rồi process.mainModule.
function armScript() {
  return `(() => {
    const pick = () => {
      if (typeof require === "function") return require;
      const main = process.mainModule;
      if (main && typeof main.require === "function") return main.require.bind(main);
      return null;
    };
    const req = pick();
    if (!req) throw new Error("không lấy được require của main process");
    const install = req(${JSON.stringify(tapModule())}).install;
    const result = install();
    setTimeout(() => { try { req("node:inspector").close(); } catch {} }, 400);
    return JSON.stringify(result);
  })()`;
}

export async function officialPaths() {
  const release = await releaseInfo();
  const dir = resolve(localRoot, "spectra", release.tag.replace(/^v/, ""));
  return { release, dir, exe: resolve(dir, release.executable), profile: resolve(localRoot, "spectra/official-profile") };
}

const sha256File = async (path) => {
  const hash = createHash("sha256");
  hash.update(await readFile(path));
  return hash.digest("hex");
};

/** Tải bản chính thức đúng một lần: kiểm SHA256 của gói và của exe, giải nén bằng 7za đi kèm npm (không cần cài 7-Zip). */
export async function acquireOfficial(config, log = () => {}) {
  const { release, dir, exe } = await officialPaths();
  if (await exists(exe)) return exe;
  const archive = resolve(workspace, ".npm-cache", release.artifact);
  await mkdir(dirname(archive), { recursive: true });
  log(`Tải Spectra Client ${release.tag} (một lần, ${(release.size / 1048576).toFixed(0)} MB)`);
  const res = await fetch(release.url, { redirect: "follow" });
  if (!res.ok || !res.body) throw new Error(`Tải Spectra Client thất bại (HTTP ${res.status})`);
  await pipeline(Readable.fromWeb(res.body), createWriteStream(`${archive}.part`));
  if ((await sha256File(`${archive}.part`)) !== release.sha256) {
    await rm(`${archive}.part`, { force: true });
    throw new Error("Gói Spectra Client không khớp SHA256 đã pin");
  }
  await rename(`${archive}.part`, archive);
  log("Giải nén Spectra Client");
  await mkdir(dir, { recursive: true });
  await new Promise((ok, fail) => {
    const child = spawn(require("7zip-bin").path7za, ["x", archive, `-o${dir}`, "-y"], {
      windowsHide: true,
      stdio: "ignore",
    });
    child.on("error", fail);
    child.on("exit", (code) => (code === 0 ? ok() : fail(new Error(`7za thất bại (mã ${code})`))));
  });
  if ((await sha256File(exe)) !== release.executableSha256)
    throw new Error("Spectra Client.exe không khớp SHA256 đã pin");
  await rm(archive, { force: true });
  return exe;
}

// PowerShell nền: ẩn cửa sổ của đúng process Client và báo tiêu đề cửa sổ (trạng thái Ready/Connected...).
// Tự thoát khi Client hoặc process cha biến mất.
const helperScript = (clientPid, parentPid) => `
$ErrorActionPreference = 'SilentlyContinue'
[Console]::OutputEncoding = [System.Text.Encoding]::UTF8
Add-Type @"
using System; using System.Runtime.InteropServices; using System.Text;
public class OwWin {
  public delegate bool EnumProc(IntPtr h, IntPtr l);
  [DllImport("user32.dll")] public static extern bool EnumWindows(EnumProc p, IntPtr l);
  [DllImport("user32.dll")] public static extern uint GetWindowThreadProcessId(IntPtr h, out uint pid);
  [DllImport("user32.dll")] public static extern bool IsWindowVisible(IntPtr h);
  [DllImport("user32.dll")] public static extern bool ShowWindow(IntPtr h, int c);
  [DllImport("user32.dll", CharSet=CharSet.Unicode)] public static extern int GetWindowText(IntPtr h, StringBuilder s, int n);
}
"@
$target = ${clientPid}; $parent = ${parentPid}; $last = ''
while ($true) {
  if (-not (Get-Process -Id $target)) { break }
  if (-not (Get-Process -Id $parent)) { break }
  $title = ''
  $cb = [OwWin+EnumProc]{ param($h, $l)
    $p = 0; [void][OwWin]::GetWindowThreadProcessId($h, [ref]$p)
    if ($p -eq $target) {
      $sb = New-Object System.Text.StringBuilder 256
      [void][OwWin]::GetWindowText($h, $sb, 256)
      if ($sb.ToString().StartsWith('Spectra Client')) {
        $script:title = $sb.ToString()
        if ([OwWin]::IsWindowVisible($h)) { [void][OwWin]::ShowWindow($h, 0) }
      }
    }
    return $true }
  [void][OwWin]::EnumWindows($cb, [IntPtr]::Zero)
  if ($title -ne $last -and $title -ne '') { $last = $title; Write-Output ('T|' + $title) }
  Start-Sleep -Milliseconds 400
}
`;

class Cdp {
  constructor(url) {
    this.url = url;
    this.id = 0;
    this.pending = new Map();
  }
  async open() {
    this.ws = new WebSocket(this.url);
    this.ws.on("message", (raw) => {
      const m = JSON.parse(raw);
      const p = m.id && this.pending.get(m.id);
      if (p) {
        this.pending.delete(m.id);
        p(m);
      }
    });
    await new Promise((ok, fail) => {
      this.ws.once("open", ok);
      this.ws.once("error", fail);
    });
  }
  call(method, params = {}) {
    return new Promise((ok, fail) => {
      const id = ++this.id;
      const timer = setTimeout(() => {
        this.pending.delete(id);
        fail(new Error(`CDP ${method} timeout`));
      }, 8000);
      this.pending.set(id, (m) => {
        clearTimeout(timer);
        ok(m);
      });
      this.ws.send(JSON.stringify({ id, method, params }));
    });
  }
  async eval(expression) {
    const m = await this.call("Runtime.evaluate", {
      expression,
      returnByValue: true,
      awaitPromise: true,
      // Node inspector cấp `require` qua command-line API; armScript dựa vào đó khi mainModule thiếu.
      includeCommandLineAPI: true,
    });
    if (m.result?.exceptionDetails)
      throw new Error(m.result.exceptionDetails.exception?.description ?? "CDP exception");
    return m.result?.result?.value;
  }
  close() {
    try {
      this.ws.close();
    } catch {}
  }
}

/** Dữ liệu điền vào form của Client, lấy từ cấu hình trận Studio đã lưu (thiếu thì dùng mặc định). */
export async function officialMatch(config, configPath, key) {
  let saved = {};
  try {
    saved = JSON.parse(await readFile(resolve(dirname(configPath), "match-config.json"), "utf8"));
  } catch {}
  const base = `http://127.0.0.1:${config.ports.frontend}`;
  const logo = (name) =>
    typeof name === "string" && /^[a-f0-9]{16}\.(png|jpg|webp)$/.test(name)
      ? `${base}/uploads/${name}`
      : `${base}/assets/misc/logo.webp`;
  const team = (t, n) => ({
    name: String(t?.name || `Team ${n}`).slice(0, 40),
    tricode: String(t?.tricode || `T${n}`)
      .slice(0, 5)
      .toUpperCase(),
    url: logo(t?.logo),
  });
  return {
    observerName: "Riot Overlay",
    key,
    groupCode: config.groupCode,
    ingest: withIngestPort(`http://127.0.0.1:${config.ports.ingest}`),
    teams: [team(saved.teams?.[0], 1), team(saved.teams?.[1], 2)],
    tournamentLogo: saved.tournament?.logo ? logo(saved.tournament.logo) : "",
  };
}

/** Điền form của Client (DOM Angular) từ cấu hình trận. Chọn phần tử theo id đã có trong bản 0.3.4. */
const fillScript = (v) => `(() => {
  const set = (el, value) => {
    if (!el) throw new Error('Không thấy ô nhập trong giao diện Client');
    Object.getOwnPropertyDescriptor(Object.getPrototypeOf(el), 'value').set.call(el, value);
    el.dispatchEvent(new Event('input', { bubbles: true }));
    el.dispatchEvent(new Event('change', { bubbles: true }));
  };
  const values = ${JSON.stringify(v)};
  const group = document.getElementById('GroupCodeInput');
  const inputs = [...document.querySelectorAll('input')];
  const ingest = inputs[inputs.indexOf(group) + 1];
  const key = document.querySelector('input[type=password]');
  const names = document.querySelectorAll('#TeamNameInput'), codes = document.querySelectorAll('#TeamTricodeInput'), logos = document.querySelectorAll('#TeamLogoInput');
  set(document.getElementById('ValorantNameInput'), values.observerName);
  set(key, values.key); set(group, values.groupCode); set(ingest, values.ingest);
  [0, 1].forEach(i => { set(names[i], values.teams[i].name); set(codes[i], values.teams[i].tricode); set(logos[i], values.teams[i].url); });
  const tournamentLogo = document.getElementById('TournamentLogoInput');
  if (tournamentLogo && values.tournamentLogo) set(tournamentLogo, values.tournamentLogo);
  // Client mặc định đăng ký phím nóng TOÀN CỤC (F10, O, P, I): sẽ nuốt phím gõ của người dùng ở mọi ứng dụng.
  // Studio gửi các lệnh đó qua ingest nên luôn tắt hết.
  const hotkeys = document.querySelector('app-hotkeys') || document;
  hotkeys.querySelectorAll('p-togglebutton').forEach(t => { if (t.innerText.trim() === 'Enabled') t.click(); });
  return true;
})()`;

// Client kiểm tra form bất đồng bộ nên phải bấm Connect sau khi Angular đã cập nhật trạng thái hợp lệ.
const clickConnectScript = `(() => {
  const hotkeys = document.querySelector('app-hotkeys') || document;
  if ([...hotkeys.querySelectorAll('p-togglebutton')].some(t => t.innerText.trim() === 'Enabled'))
    throw new Error('Phím nóng toàn cục của Client vẫn đang bật; không kết nối');
  const connect = [...document.querySelectorAll('button')].find(b => b.innerText.trim() === 'Connect');
  if (!connect) throw new Error('Không thấy nút Connect');
  connect.click();
  return true;
})()`;

/** Client ngầm còn sót từ lần Studio bị tắt đột ngột (cửa sổ ẩn, vẫn giữ GEP và khoá profile): chỉ dừng đúng process dùng profile của ta. */
async function reapOrphans(profile) {
  if (process.platform !== "win32") return;
  const like = profile.replace(/'/g, "''");
  const script = `Get-CimInstance Win32_Process -Filter "Name='Spectra Client.exe'" | Where-Object { $_.CommandLine -like '*${like}*' } | ForEach-Object { Stop-Process -Id $_.ProcessId -Force -ErrorAction SilentlyContinue }`;
  await new Promise((ok) => {
    const child = spawn("powershell.exe", ["-NoProfile", "-NonInteractive", "-Command", script], {
      windowsHide: true,
      stdio: "ignore",
    });
    child.once("exit", ok);
    child.once("error", ok);
  });
}

/**
 * Chạy Client chính thức ngầm. match: {observerName, key, groupCode, ingest, teams:[{name,tricode,url}], tournamentLogo}.
 * Trả về {pid, stop, status()}; chỉ dừng những process do hàm này tạo.
 */
export async function startOfficial({
  config,
  match,
  onState = () => {},
  parentPid = process.pid,
  mode = "observer",
  auxName = "Player",
}) {
  const auxiliary = mode === "auxiliary";
  const ingest = withIngestPort(match?.ingest);
  const { exe, profile } = await officialPaths();
  if (!(await exists(exe)))
    throw new Error("Chưa có Spectra Client chính thức (chạy npm run valorant:setup)");
  await mkdir(profile, { recursive: true });
  await reapOrphans(profile);
  await pause(500);
  await rm(resolve(profile, "DevToolsActivePort"), { force: true });
  let title = "";
  let state = "starting";
  let stopped = false;
  const children = [];
  const inspectorPort = await freePort();
  const child = spawn(
    exe,
    [
      `--user-data-dir=${profile}`,
      "--remote-debugging-port=0",
      `--inspect=${inspectorPort}`,
      ...(auxiliary ? ["--auxiliary"] : []),
    ],
    {
      windowsHide: true,
      stdio: "ignore",
      shell: false,
      env: { ...process.env, RIOT_SPECTRA_PIPE: tapPipe },
    },
  );
  children.push(child);
  child.on("exit", (code) => {
    if (!stopped) {
      state = `exited-${code}`;
      onState({ state, title });
    }
  });
  const stop = async () => {
    stopped = true;
    cdp?.close();
    for (const c of children.reverse()) {
      if (c.exitCode !== null || c.signalCode !== null) continue;
      if (process.platform === "win32")
        await new Promise((ok) => {
          const t = spawn("taskkill.exe", ["/PID", String(c.pid), "/T", "/F"], {
            windowsHide: true,
            stdio: "ignore",
          });
          t.once("exit", ok);
          t.once("error", ok);
        });
      else c.kill();
    }
  };
  let cdp;
  try {
    // Gắn tap vào main process trước khi chờ GEP, để không mất frame đầu trận.
    try {
      const tapPort = inspectorPort;
      const mainTarget = await waitForMainTarget(tapPort);
      if (!mainTarget) throw new Error("Không thấy target main process");
      // main process có thể chưa sẵn sàng ngay sau khi spawn: thử lại vài lần trước khi bỏ.
      let armed = null;
      let lastError = null;
      for (let attempt = 1; attempt <= 3 && !armed; attempt++) {
        const mainCdp = new Cdp(mainTarget.webSocketDebuggerUrl);
        try {
          await mainCdp.open();
          armed = JSON.parse(await mainCdp.eval(armScript()));
        } catch (error) {
          lastError = error;
          if (attempt < 3) await pause(700);
        } finally {
          mainCdp.close();
        }
      }
      if (!armed) throw lastError ?? new Error("không vá được tap");
      console.log(`[tap] ${JSON.stringify(armed)}`);
      onState({ state, title, tap: armed });
    } catch (error) {
      // Tap là tuỳ chọn: GEP vẫn phải chạy dù gắn tap lỗi.
      console.error(`[tap] gắn thất bại: ${error?.message ?? error}`);
      onState({ state, title, tap: { error: String(error?.message ?? error) } });
    }
    // Cổng DevTools ngẫu nhiên, chỉ loopback; Chromium ghi cổng vào DevToolsActivePort.
    let port = 0;
    for (let i = 0; i < 100 && !port; i++) {
      await pause(300);
      try {
        port = Number(
          (await readFile(resolve(profile, "DevToolsActivePort"), "utf8")).split(/\r?\n/)[0],
        );
      } catch {}
    }
    if (!port) throw new Error("Client chính thức không mở cổng điều khiển");
    const helper = spawn(
      "powershell.exe",
      [
        "-NoProfile",
        "-NonInteractive",
        "-EncodedCommand",
        Buffer.from(helperScript(child.pid, parentPid), "utf16le").toString("base64"),
      ],
      { windowsHide: true, stdio: ["ignore", "pipe", "ignore"] },
    );
    children.push(helper);
    helper.stdout.setEncoding("utf8");
    helper.stdout.on("data", (chunk) => {
      for (const line of String(chunk).split(/\r?\n/))
        if (line.startsWith("T|")) {
          title = line.slice(2);
          onState({ state, title });
        }
    });
    let target;
    for (let i = 0; i < 100 && !target; i++) {
      try {
        target = (await (await fetch(`http://127.0.0.1:${port}/json`)).json()).find(
          (t) => t.type === "page" && t.url.includes("app.asar"),
        );
      } catch {}
      if (!target) await pause(300);
    }
    if (!target) throw new Error("Không thấy giao diện của Client chính thức");
    cdp = new Cdp(target.webSocketDebuggerUrl);
    await cdp.open();
    if (auxiliary) {
      // Chế độ aux không dùng form observer: gọi thẳng IPC qua preload.
      // Client chỉ có MATCH_ID sau khi GEP thấy trận, nên phải lặp: gọi sớm trả "No Match ID".
      state = "aux-waiting";
      const auxScript = `window.electronAPI.processAuxInputs(${JSON.stringify(ingest)}, ${JSON.stringify(auxName)})`;
      const deadline = Date.now() + 10 * 60 * 1000;
      while (Date.now() < deadline && !/Connected/.test(title)) {
        try {
          await cdp.eval(auxScript);
        } catch {}
        for (let i = 0; i < 20 && !/Connected/.test(title); i++) await pause(500);
      }
      state = /Connected/.test(title) ? "connected" : "connect-unconfirmed";
      onState({ state, title });
    } else {
      // GEP ready: tiêu đề cửa sổ có "Ready" (Client tự báo khi gói GEP của Overwolf sẵn sàng).
      for (let i = 0; i < 200 && !/Ready/.test(title); i++) await pause(300);
      if (!/Ready/.test(title)) throw new Error("GEP của Client chính thức chưa sẵn sàng");
      await cdp.eval(fillScript({ ...match, ingest }));
      await pause(1200);
      state = "connecting";
      // Thử bấm Connect vài lần: lần đầu có thể rơi vào lúc form chưa được Angular xác nhận hợp lệ.
      for (let attempt = 0; attempt < 3 && !/Connected/.test(title); attempt++) {
        await cdp.eval(clickConnectScript);
        for (let i = 0; i < 24 && !/Connected/.test(title); i++) await pause(250);
      }
      state = /Connected/.test(title) ? "connected" : "connect-unconfirmed";
      onState({ state, title });
    }
  } catch (e) {
    await stop();
    throw e;
  }
  return {
    pid: child.pid,
    profile,
    stop,
    status: () => ({
      state:
        /Connected|Game Started|Round/.test(title) && state !== "stopped" ? "connected" : state,
      title,
    }),
  };
}
