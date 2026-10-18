/* Thẻ MVP trận Valorant (bố cục gốc của valorant-postgame-stats, dữ liệu lấy từ Studio).
   Số liệu mà nguồn không có (null) hiển thị "—". */
const API = "/api/valorant/postgame/mvp";
const DASH = "—";
let lastVersion = "";

function hexToRgb(hex) {
  const h = hex.replace("#", "");
  return `${parseInt(h.slice(0, 2), 16)}, ${parseInt(h.slice(2, 4), 16)}, ${parseInt(h.slice(4, 6), 16)}`;
}

function applyStyle(c) {
  const root = document.documentElement.style;
  root.setProperty("--primary-rgb", hexToRgb(c.primaryColor));
  root.setProperty("--primary-a", c.primaryOpacity);
  root.setProperty("--cell-rgb", hexToRgb(c.cellColor));
  root.setProperty("--cell-a", c.cellOpacity);
  root.setProperty("--cell2-rgb", hexToRgb(c.cell2Color));
  root.setProperty("--cell2-a", c.cell2Opacity);
  root.setProperty("--header-bg-rgb", hexToRgb(c.headerBgColor));
  root.setProperty("--header-bg-a", c.headerBgOpacity);
  root.setProperty("--header-text", c.headerTextColor);
  root.setProperty("--body-text", c.bodyTextColor);
  root.setProperty("--font-overlay", `"${c.fontFamily}"`);
  const bg = document.getElementById("bg-layer");
  if (bg) {
    bg.style.backgroundImage = c.overlayBg ? `url("${c.overlayBg}")` : "none";
    bg.style.backgroundColor = c.overlayBgColor;
    bg.style.opacity = String(c.overlayBgOpacity);
  }
}

const el = (id) => document.getElementById(id);
const set = (id, value) => {
  const e = el(id);
  if (e) e.textContent = value ?? "";
};
const setSrc = (id, src) => {
  const e = el(id);
  if (!e) return;
  e.onerror = () => {
    e.style.visibility = "hidden"; // ảnh lỗi/không tải được: ẩn thay vì hiện ô ảnh vỡ
  };
  e.src = src || "";
  e.style.visibility = src ? "visible" : "hidden";
};
const stat = (value) => (value === null || value === undefined ? DASH : value);

function render(mvp) {
  applyStyle(mvp.style);
  document.body.style.visibility = mvp.empty ? "hidden" : "visible";
  const id = mvp.agentId;
  setSrc("mvp-agent-bg", id ? `https://media.valorant-api.com/agents/${id}/background.png` : "");
  setSrc("mvp-agent-portrait", id ? `https://media.valorant-api.com/agents/${id}/fullportrait.png` : "");
  set("mvp-name", mvp.name);
  set("mvp-team-name", mvp.teamName);
  setSrc("mvp-team-logo", mvp.teamLogo);
  set("mvp-acs", stat(mvp.acs));
  set("mvp-kda", `${mvp.kills}/${mvp.deaths}`);
  set("mvp-dpr", stat(mvp.damagePerRound));
  set("mvp-fk", stat(mvp.firstKillPct));
  set("mvp-kast", stat(mvp.kastPct));
}

async function poll() {
  try {
    const data = await fetch(API, { cache: "no-store" }).then((r) => r.json());
    if (data.version !== lastVersion) {
      lastVersion = data.version;
      render(data);
    }
  } catch {
    // Studio chưa chạy hoặc đang khởi động lại: giữ nguyên hình hiện tại.
  }
}

poll();
setInterval(poll, 2000);
