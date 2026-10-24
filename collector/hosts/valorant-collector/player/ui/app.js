const $ = (id) => document.getElementById(id);

const PHASES = {
  idle: ["Chưa kết nối", "muted"],
  resolving: ["Đang tra code…", "warn"],
  downloading: ["Đang chuẩn bị client…", "warn"],
  starting: ["Đang mở client…", "warn"],
  waiting: ["Đang chờ vào trận", "warn"],
  ready: ["Đã tra được host", "ok"],
  connected: ["Đang gửi dữ liệu", "ok"],
  error: ["Lỗi", "bad"],
};

let view = null;
let camOn = false;
let selfTestStream = null;
let warmUpMessage = "";
let camProblem = "";
let prefilledStored = false;

const RIOT_ID_KEY = "riotovl.player.riotId";
const readStoredRiotId = () => {
  try {
    return localStorage.getItem(RIOT_ID_KEY) ?? "";
  } catch {
    return "";
  }
};
const storeRiotId = (value) => {
  try {
    localStorage.setItem(RIOT_ID_KEY, value ?? "");
  } catch {
    // Trình duyệt chặn localStorage: không sao, chỉ mất phần nhớ.
  }
};

const post = async (path, body) => {
  const response = await fetch(path, {
    method: "POST",
    headers: { "Content-Type": "application/json" },
    body: JSON.stringify(body ?? {}),
  });
  return response.json();
};

const setText = (id, value, tone) => {
  const node = $(id);
  node.textContent = value ?? "—";
  if (tone) node.dataset.tone = tone;
  else delete node.dataset.tone;
};

function renderHost() {
  const node = $("host");
  const host = view?.host;
  if (!host) {
    node.hidden = true;
    return;
  }
  node.hidden = false;
  node.innerHTML = "";
  const rows = [
    ["Kiểu code", host.kind === "short" ? "5 ký tự (điểm hẹn)" : "code dài"],
    ["Đích dữ liệu của host", host.origin],
    ["Group code", host.groupCode || "(không cần cho auxiliary)"],
    ["Room cam vdo.ninja", host.camRoom || "(host chưa đặt)"],
  ];
  for (const [label, value] of rows) {
    const row = document.createElement("div");
    row.className = "fact";
    const dt = document.createElement("dt");
    const dd = document.createElement("dd");
    dt.textContent = label;
    dd.textContent = value;
    row.append(dt, dd);
    node.append(row);
  }
}

function renderCamera() {
  const cam = view?.cam ?? { on: false, auto: true, room: "", streamId: "", url: "", waiting: null };
  camOn = cam.on;
  if (camOn) camProblem = "";
  setText("f-room", cam.room || "(host chưa đặt room id)");
  setText("f-stream", cam.streamId || "(chưa có Riot ID hợp lệ)");

  const autoNode = $("cam-auto");
  if (document.activeElement !== autoNode) autoNode.checked = !!cam.auto;

  const toggle = $("cam-toggle");
  toggle.textContent = camOn ? "Tắt camera" : "Bật camera";

  const open = $("cam-open");
  open.hidden = !cam.url;
  if (cam.url) open.href = cam.url;

  // Camera đang bật thì thông báo chờ không còn ý nghĩa.
  const waitText = camOn ? "" : (cam.waiting ?? "") || warmUpMessage;
  const wait = $("cam-wait");
  wait.hidden = !waitText;
  wait.textContent = waitText;

  const problem = $("cam-problem");
  problem.hidden = !camProblem;
  problem.textContent = camProblem;

  const frame = $("cam-frame");
  const desired = cam.url;
  if (!camOn || !desired) {
    frame.hidden = true;
    frame.innerHTML = "";
  } else if (frame.dataset.src !== desired) {
    frame.dataset.src = desired;
    frame.innerHTML = "";
    const iframe = document.createElement("iframe");
    iframe.src = desired;
    iframe.allow = "camera; microphone; autoplay; fullscreen";
    iframe.allowFullscreen = true;
    iframe.title = "Camera của bạn (vdo.ninja)";
    frame.append(iframe);
    frame.hidden = false;
  } else {
    frame.hidden = false;
  }
}

function render() {
  if (!view) return;
  const [label, tone] = PHASES[view.phase] ?? [view.phase, "muted"];
  const phase = $("phase");
  phase.textContent = label;
  phase.dataset.tone = tone;
  $("detail").textContent = view.detail || "";

  const client = view.client;
  setText("f-connected", client.connected ? "đã kết nối" : "chưa kết nối", client.connected ? "ok" : "bad");
  setText("f-mode", client.isAux ? "auxiliary (máu, kỹ năng)" : "chưa xác định");
  setText("f-match", client.matchId || "(chưa có — vào trận sẽ tự có)");
  setText("f-ingest", client.ingest || view.host?.origin || "—");
  setText("f-tap", client.tap);
  setText("f-aux", String(view.counters.aux));

  if (view.riotId) {
    storeRiotId(view.riotId);
    if (document.activeElement !== $("riot-id")) $("riot-id").value = view.riotId;
  }

  const busy = view.phase === "downloading" || view.phase === "starting" || view.phase === "resolving";
  $("code").disabled = busy;
  $("join-form").querySelector("button").disabled = busy;

  renderHost();
  renderCamera();
}

const refresh = async () => {
  try {
    view = await (await fetch("/api/state")).json();
    // Lần đầu: điền lại Riot ID đã nhớ (manual: false để client còn tự đọc đè khi vào trận).
    if (!prefilledStored) {
      prefilledStored = true;
      if (!view.riotId) {
        const stored = readStoredRiotId();
        if (stored) view = await post("/api/riot-id", { value: stored, manual: false });
      }
    }
    render();
  } catch {
    // UI cục bộ tạm mất: lần sau thử lại.
  }
};

/** Xin quyền camera sớm (rồi dừng ngay) để lần đẩy thật không bị chặn giữa trận. */
async function warmUpCamera() {
  if (!navigator.mediaDevices?.getUserMedia) return;
  try {
    const stream = await navigator.mediaDevices.getUserMedia({ video: true, audio: false });
    for (const track of stream.getTracks()) track.stop();
    warmUpMessage = "Đã cho phép camera. Hình sẽ tự gửi ngay khi biết Riot ID.";
  } catch (error) {
    warmUpMessage = `Chưa có quyền camera: ${error?.message || error}. Bấm Kiểm tra webcam để thử lại.`;
  }
  render();
}

$("join-form").addEventListener("submit", async (event) => {
  event.preventDefault();
  const input = $("code");
  const code = input.value.trim().toUpperCase();
  if (code.length !== 5) {
    $("detail").textContent = "Code phải có đúng 5 ký tự.";
    return;
  }
  camProblem = "";
  view = await post("/api/join", { code, noClient: $("no-client").checked });
  render();
  // Code đã mang room cam: xin quyền camera sớm nếu chưa có Riot ID (khi có Riot ID camera đã tự bật).
  if (view?.cam?.auto && view?.cam?.room && !view?.cam?.on) void warmUpCamera();
});

$("code").addEventListener("input", (event) => {
  const clean = event.target.value.toUpperCase().replace(/[^0-9A-Z]/g, "");
  event.target.value = clean;
  // Dán/điền đủ 5 ký tự thì gửi luôn, khỏi phải bấm nút.
  if (clean.length === 5) $("join-form").requestSubmit();
});

$("riot-id").addEventListener("change", async (event) => {
  const value = event.target.value;
  storeRiotId(value);
  view = await post("/api/riot-id", { value, manual: true });
  render();
});

$("cam-auto").addEventListener("change", async (event) => {
  view = await post("/api/cam", { auto: event.target.checked });
  render();
});

$("cam-toggle").addEventListener("click", async () => {
  camProblem = "";
  if (!camOn && !(view?.cam?.streamId ?? "")) {
    await refresh();
    if (!view?.cam?.streamId) {
      camProblem = "Chưa có Riot ID hợp lệ để đặt tên stream. Nhập Riot ID (Tên#Tag) bên trên.";
      renderCamera();
      return;
    }
  }
  view = await post("/api/cam", { on: !camOn });
  render();
});

$("cam-test").addEventListener("click", async () => {
  const video = $("cam-preview");
  if (selfTestStream) {
    for (const track of selfTestStream.getTracks()) track.stop();
    selfTestStream = null;
    video.hidden = true;
    video.srcObject = null;
    $("cam-test").textContent = "Kiểm tra webcam";
    return;
  }
  camProblem = "";
  try {
    selfTestStream = await navigator.mediaDevices.getUserMedia({ video: true, audio: false });
    video.srcObject = selfTestStream;
    video.hidden = false;
    await video.play().catch(() => {});
    $("cam-test").textContent = "Dừng xem trước";
  } catch (error) {
    camProblem = `Không mở được webcam: ${error?.message || error}`;
  }
  renderCamera();
});

$("leave").addEventListener("click", async () => {
  view = await post("/api/leave");
  render();
});

await refresh();
setInterval(() => void refresh(), 1500);
