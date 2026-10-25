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

function renderCamera() {
  const cam = view?.cam ?? { on: false, streamId: "", url: "", waiting: null };
  camOn = cam.on;
  if (camOn) camProblem = "";
  $("cam-toggle").textContent = camOn ? "Đóng camera" : "Mở camera";

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
    iframe.allow = "camera; autoplay; fullscreen";
    iframe.allowFullscreen = true;
    iframe.title = "Camera của bạn";
    frame.append(iframe);
    frame.hidden = false;
  } else {
    frame.hidden = false;
  }
}

function render() {
  if (!view) return;
  const [label, tone] = PHASES[view.phase] ?? [view.phase, "muted"];
  $("phase").textContent = label;
  $("phase").dataset.tone = tone;
  $("detail").textContent = view.detail || "";
  const client = view.client;
  setText("f-connected", client.connected ? "đã kết nối" : "chưa kết nối", client.connected ? "ok" : "bad");
  setText("f-player", view.riotId || "đang chờ client nhận diện");

  const busy = view.phase === "downloading" || view.phase === "starting" || view.phase === "resolving";
  $("code").disabled = busy;
  $("join-form").querySelector("button").disabled = busy;
  renderCamera();
}

const refresh = async () => {
  try {
    view = await (await fetch("/api/state")).json();
    render();
  } catch {
    // Lần sau sẽ thử lại khi UI cục bộ tạm mất.
  }
};

async function warmUpCamera() {
  if (!navigator.mediaDevices?.getUserMedia) return;
  try {
    const stream = await navigator.mediaDevices.getUserMedia({ video: true, audio: false });
    for (const track of stream.getTracks()) track.stop();
    warmUpMessage = "Đã cho phép camera. Hình sẽ tự gửi khi player được nhận diện.";
  } catch (error) {
    warmUpMessage = `Chưa có quyền camera: ${error?.message || error}.`;
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
  view = await post("/api/join", { code });
  render();
  if (view?.cam?.room && !view?.cam?.on) void warmUpCamera();
});

$("code").addEventListener("input", (event) => {
  const clean = event.target.value.toUpperCase().replace(/[^0-9A-Z]/g, "");
  event.target.value = clean;
  if (clean.length === 5) $("join-form").requestSubmit();
});

$("cam-toggle").addEventListener("click", async () => {
  camProblem = "";
  if (!camOn && !(view?.cam?.streamId ?? "")) {
    await refresh();
    if (!view?.cam?.streamId) {
      camProblem = "Đang chờ client nhận diện tên player từ trận.";
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
    $("cam-test").textContent = "Preview camera";
    return;
  }
  camProblem = "";
  try {
    selfTestStream = await navigator.mediaDevices.getUserMedia({ video: true, audio: false });
    video.srcObject = selfTestStream;
    video.hidden = false;
    await video.play().catch(() => {});
    $("cam-test").textContent = "Đóng preview";
  } catch (error) {
    camProblem = `Không mở được webcam: ${error?.message || error}`;
    renderCamera();
  }
});

$("leave").addEventListener("click", async () => {
  view = await post("/api/leave");
  render();
});

void refresh();
setInterval(refresh, 1000);
