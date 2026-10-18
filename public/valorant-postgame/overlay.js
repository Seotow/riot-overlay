/* Overlay hậu trận Valorant (bố cục gốc của valorant-postgame-stats, dữ liệu lấy từ Studio).
   Số liệu mà nguồn không có (null) hiển thị "—", không đoán giá trị. */
const API = "/api/valorant/postgame/render";
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

function setText(selector, value) {
  document.querySelectorAll(selector).forEach((el) => {
    el.textContent = value ?? "";
  });
}

function setImg(selector, src) {
  const el = document.querySelector(selector);
  if (!el) return;
  el.onerror = () => {
    el.style.visibility = "hidden"; // ảnh lỗi/không tải được: ẩn thay vì hiện ô ảnh vỡ
  };
  el.src = src || "";
  el.style.visibility = src ? "visible" : "hidden";
}

const stat = (value) => (value === null || value === undefined ? DASH : value);

function render(data) {
  applyStyle(data.style);
  // Chưa có trận nào: để nền trong suốt thay vì hiện số liệu mẫu lên stream.
  document.body.style.visibility = data.empty ? "hidden" : "visible";
  const m = data.match;
  for (const [key, value] of Object.entries(m))
    if (typeof value === "string" || typeof value === "number")
      setText(`[data-bind="${key}"]`, value);
  setText('[data-bind="mapNameLeft"]', m.mapName || "MAP");

  for (const side of ["left", "right"]) {
    const card = data.mvp[side];
    setText(`[data-bind="${side}MvpAgent"]`, card.agent);
    setText(`[data-bind="${side}MvpName"]`, card.name);
    setText(`[data-bind="${side}MvpKills"]`, card.kills);
    setText(`[data-bind="${side}MvpDeaths"]`, card.deaths);
    setText(`[data-bind="${side}MvpAcs"]`, stat(card.acs));
    setImg(`[data-bind-img="${side}MvpPortrait"]`, card.portrait);
    setImg(`[data-bind-img="${side}TeamLogo"]`, m[`${side}TeamLogo`]);
    for (let i = 0; i < 4; i++) {
      const row = data.rows[side][i];
      setText(`[data-round-${side}-sub="${i}"]`, row?.agent ?? "");
      setText(`[data-round-${side}-main="${i}"]`, row?.name ?? "");
      setText(`[data-round-${side}-kills="${i}"]`, row ? row.kills : "");
      setText(`[data-round-${side}-acs="${i}"]`, row ? stat(row.acs) : "");
      setImg(`[data-round-${side}-icon="${i}"]`, row?.icon);
    }
  }
  setImg('[data-bind-img="leagueLogo"]', m.leagueLogo);
  setImg('[data-bind-img="mapImageLeft"]', m.mapImageLeft);
  setImg('[data-bind-img="sponsorImage"]', data.style.sponsorImage);
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
