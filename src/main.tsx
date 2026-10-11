import { observerFrameSchema, type ObserverFrame } from "../shared/observer";
import { Diagnostics } from "./Diagnostics";
import { RealTestPanel } from "./RealTestPanel";
import {
  Dashboard,
  SourcePanel,
  Roadmap,
  studioModules,
  useProviders,
  type StudioPage,
} from "./Dashboard";
import { gameModules } from "../shared/providers";
import React, { useEffect, useRef, useState, type CSSProperties } from "react";
import { createRoot } from "react-dom/client";
import {
  type State,
  type Theme,
  type Command,
  themeSchema,
  defaultTheme,
} from "../shared/schema";
import { clock } from "../shared/mock";
import "./fonts.css";
import "./style.css";
import { Surface } from "./overlay/Surface";
import { referenceTheme } from "../shared/reference";
import "./overlay/overlay.css";
const isOverlay = location.pathname === "/overlay";
document.body.className = isOverlay ? "overlay-body" : "";
document.documentElement.classList.toggle("overlay-body", isOverlay);
function useSession() {
  const [state, setState] = useState<State | null>(null);
  const [connected, setConnected] = useState(false);
  const [observation, setObservation] = useState<ObserverFrame | null>(null);
  const [error, setError] = useState("");
  const ref = useRef<WebSocket | null>(null);
  useEffect(() => {
    let stopped = false;
    let timer: ReturnType<typeof setTimeout>;
    const connect = () => {
      const ws = new WebSocket(
        `${location.protocol === "https:" ? "wss" : "ws"}://${location.host}/ws?role=${isOverlay ? "overlay" : "studio"}`,
      );
      ref.current = ws;
      ws.onopen = () => setConnected(true);
      ws.onmessage = (e) => {
        const data = JSON.parse(e.data);
        if (data.type === "observer") {
          const parsed = observerFrameSchema.safeParse(data.frame);
          setObservation(parsed.success ? parsed.data : null);
        }
        if (data.type === "snapshot") setState(data.state);
        if (data.type === "error") setError(data.message);
      };
      ws.onclose = () => {
        setConnected(false);
        setObservation(null);
        if (!stopped) timer = setTimeout(connect, 1500);
      };
      ws.onerror = () => ws.close();
    };
    connect();
    return () => {
      stopped = true;
      clearTimeout(timer);
      ref.current?.close();
    };
  }, []);
  const send = (cmd: Command) => {
    if (ref.current?.readyState !== WebSocket.OPEN) {
      setError("Mất kết nối. Thay đổi chưa được gửi.");
      return;
    }
    ref.current.send(JSON.stringify(cmd));
  };
  return { state, connected, observation, error, setError, send };
}
function App() {
  const { state, connected, observation, error, setError, send } = useSession();
  const report = useProviders(!isOverlay);
  const [page, setPage] = useState<StudioPage>(
    new URLSearchParams(location.search).get("page") === "demo"
      ? "demo"
      : "overview",
  );
  const [game, setGame] = useState("lol");
  const [tab, setTab] = useState(
    new URLSearchParams(location.search).get("page") === "demo"
      ? "control"
      : "diagnostics",
  );
  const [reference, setReference] = useState(false);
  const [compare, setCompare] = useState(false);
  const [notice, setNotice] = useState("");
  const file = useRef<HTMLInputElement>(null);
  const navigate = (next: StudioPage) => {
    setPage(next);
    if (next === "theme") setTab("theme");
    else if (next === "demo" || next === "studio") setTab("control");
    else setTab("diagnostics");
  };
  if (!state) return <div className="loading">Đang kết nối backend…</div>;
  if (isOverlay)
    return (
      <>{connected && <Surface state={state} observation={observation} />}</>
    );
  const theme = state.theme;
  const change = (patch: Partial<Theme>) =>
    send({ type: "theme", value: { ...theme, ...patch } });
  const exportTheme = () => {
    const url = URL.createObjectURL(
      new Blob([JSON.stringify(theme, null, 2)], { type: "application/json" }),
    );
    const a = document.createElement("a");
    a.href = url;
    a.download = "lol-theme.json";
    a.click();
    URL.revokeObjectURL(url);
  };
  return (
    <div className="app">
      <aside className="rail">
        <a className="brand" href="/">
          R
          <span>
            RIFT
            <br />
            STUDIO
          </span>
        </a>
        <div className="workspace-label">GAME WORKSPACE</div>
        <select
          className="game-picker"
          aria-label="Game workspace"
          value={game}
          onChange={(e) => setGame(e.target.value)}
        >
          {gameModules.map((g) => (
            <option key={g.id} value={g.id}>
              {g.name}
              {g.status === "planned" ? " (sắp tới)" : ""}
            </option>
          ))}
        </select>
        <nav aria-label="Module sản xuất">
          {studioModules.map((m) => (
            <button
              key={m.id}
              className={`nav ${page === m.id ? "active" : ""}`}
              onClick={() => navigate(m.id)}
            >
              <span>{m.icon}</span>
              {m.title}
            </button>
          ))}
        </nav>
        <div className="rail-bottom">
          <span className="version">LOCAL WORKSPACE</span>
          <p>
            Overlay Kit <b>0.1</b>
          </p>
          <small>Local data / Modular studio</small>
        </div>
      </aside>
      <main>
        <header className="topbar">
          <div>
            <span className="breadcrumb">
              WORKSPACE / {game === "lol" ? "LEAGUE OF LEGENDS" : "VALORANT"}
            </span>
            <h1>
              {studioModules.find((m) => m.id === page)?.title}
              <span className="badge">
                {state.mockVisible
                  ? "DEMO"
                  : state.provider === "recording"
                    ? "BẢN GHI"
                    : "OBSERVED"}
              </span>
            </h1>
          </div>
          <div className="connection">
            <i className={connected ? "online" : ""} />
            {connected ? "Hệ thống đã sẵn sàng" : "Đang kết nối lại…"}
          </div>
        </header>
        <div className="content module-content">
          {game === "valorant" ? (
            <Roadmap valorant />
          ) : (
            <>
              {page === "overview" && (
                <Dashboard
                  state={state}
                  connected={connected}
                  observation={observation}
                  report={report}
                  send={send}
                  navigate={navigate}
                />
              )}
              {page === "sources" && (
                <>
                  <SourcePanel
                    state={state}
                    connected={connected}
                    observation={observation}
                    report={report}
                    send={send}
                  />
                  <details className="diagnostic-details">
                    <summary>Chẩn đoán Riot / theo dõi nguồn đang chọn</summary>
                    <Diagnostics />
                  </details>
                </>
              )}
              {page === "roadmap" && <Roadmap />}
              <div
                className={`production-view view-${page}`}
                hidden={!["studio", "theme", "demo"].includes(page)}
              >
                <div className="section-heading">
                  <div>
                    <h2>Xem trước chương trình</h2>
                    <p>
                      Kiểm tra bố cục, thử sự kiện và tinh chỉnh nhận diện giải
                      đấu.
                    </p>
                  </div>
                  <a
                    className="button secondary"
                    href="/overlay"
                    target="_blank"
                    rel="noreferrer"
                  >
                    Mở đầu ra OBS
                  </a>
                </div>
                <div className="workspace">
                  <section className="preview-column">
                    <div className="monitor">
                      <div className="monitor-bar">
                        <span>
                          <i /> {state.scene.toUpperCase()}
                        </span>
                        <span>
                          1920 × 1080{" "}
                          <b>{state.mockVisible ? "MOCK" : "OBSERVED"}</b>
                        </span>
                      </div>
                      <Surface
                        state={state}
                        observation={observation}
                        preview
                        reference={reference}
                        compare={compare}
                      />
                    </div>
                    <div className="preview-tools">
                      <label>
                        <input
                          type="checkbox"
                          checked={state.mockVisible}
                          disabled={page === "demo"}
                          onChange={(e) =>
                            send({
                              type: "mockVisible",
                              value: e.target.checked,
                            })
                          }
                        />
                        Dùng dữ liệu demo (Studio + OBS)
                      </label>
                      <label>
                        <input
                          type="checkbox"
                          disabled={!state.mockVisible}
                          checked={state.mockVisible && reference}
                          onChange={(e) => setReference(e.target.checked)}
                        />
                        Ảnh tham chiếu
                      </label>
                      <span>
                        <button
                          disabled={!state.mockVisible}
                          onClick={() => setCompare(!compare)}
                        >
                          {compare ? "Xem bản dựng" : "Xem ảnh gốc"}
                        </button>
                      </span>
                    </div>
                    <div
                      className="transport"
                      style={
                        state.mockVisible ? undefined : { display: "none" }
                      }
                    >
                      <button
                        disabled={!connected}
                        className="play"
                        onClick={() =>
                          send({ type: "playing", value: !state.playing })
                        }
                      >
                        {state.playing ? "Ⅱ Tạm dừng" : "▶ Chạy mock"}
                      </button>
                      <b>{clock(state.gameTime)}</b>
                      <input
                        aria-label="Thời gian giả lập"
                        type="range"
                        min="0"
                        max="2400"
                        value={Math.min(2400, state.gameTime)}
                        onChange={(e) =>
                          send({ type: "seek", value: +e.target.value })
                        }
                      />
                      <button
                        onClick={() => send({ type: "reset" })}
                        title="Đặt lại dữ liệu, giữ theme"
                      >
                        ↺ Reset
                      </button>
                    </div>
                    <div className="scene-title">
                      CẢNH PHÁT SÓNG{" "}
                      <span>Chọn bố cục đang đưa lên chương trình</span>
                    </div>
                    <div className="scene-grid">
                      {(
                        [
                          ["draft", "01", "Cấm chọn", "Lượt chọn và đội hình"],
                          [
                            "ingame",
                            "02",
                            "Trong trận",
                            "Bảng điểm và thông tin người chơi",
                          ],
                          ["postgame", "03", "Sau trận", "Kết quả và thống kê"],
                        ] as const
                      ).map(([id, n, title, sub]) => (
                        <button
                          key={id}
                          className={`scene-card ${state.scene === id ? "selected" : ""}`}
                          onClick={() => send({ type: "scene", value: id })}
                        >
                          <span>
                            {n}
                            <i>
                              {state.scene === id ? "ĐANG PHÁT" : "SẴN SÀNG"}
                            </i>
                          </span>
                          <b>{title}</b>
                          <small>{sub}</small>
                        </button>
                      ))}
                    </div>
                    <div className="output">
                      <div>
                        <small>OBS BROWSER SOURCE</small>
                        <code>{location.origin}/overlay</code>
                      </div>
                      <button
                        onClick={() => {
                          navigator.clipboard
                            .writeText(`${location.origin}/overlay`)
                            .then(() => setNotice("Đã sao chép URL OBS."))
                            .catch(() =>
                              setNotice("Hãy sao chép URL được hiển thị."),
                            );
                        }}
                      >
                        Sao chép URL
                      </button>
                    </div>
                    <div className="note">
                      <span>◉</span>
                      <p>
                        {state.mockVisible
                          ? "Dữ liệu demo để thử bố cục."
                          : "Overlay nhận dữ liệu quan sát. Field thiếu để trống; mất nguồn giữ khung và xóa số liệu cũ. Tên đội lấy từ Theme; tên hiển thị là tên tướng. Asset dùng Data Dragon mới nhất đã tải; patch replay chưa xác minh."}
                      </p>
                    </div>
                  </section>
                  <aside className="inspector">
                    <div className="tabs">
                      <button
                        className={tab === "diagnostics" ? "active" : ""}
                        onClick={() => setTab("diagnostics")}
                      >
                        Nguồn dữ liệu
                      </button>
                      <button
                        className={tab === "control" ? "active" : ""}
                        onClick={() => setTab("control")}
                      >
                        Điều khiển
                      </button>
                      <button
                        className={tab === "theme" ? "active" : ""}
                        onClick={() => setTab("theme")}
                      >
                        Theme & layout
                      </button>
                    </div>
                    <div className="inspector-body">
                      {page === "demo" ? (
                        <RealTestPanel state={state} send={send} />
                      ) : tab === "diagnostics" ? (
                        page === "studio" ? (
                          <SourcePanel
                            state={state}
                            connected={connected}
                            observation={observation}
                            report={report}
                            send={send}
                          />
                        ) : (
                          <Diagnostics />
                        )
                      ) : tab === "control" ? (
                        <>
                          <div className="eyebrow">DỮ LIỆU THỬ</div>
                          <h3>Thử một tình huống</h3>
                          <p className="muted">
                            Cùng một trạng thái cấp dữ liệu cho preview và OBS.
                          </p>
                          <label className="field">
                            Kịch bản
                            <select
                              value={state.scenario}
                              onChange={(e) =>
                                send({
                                  type: "scenario",
                                  value: e.target.value as State["scenario"],
                                })
                              }
                            >
                              <option value="balanced">Trận cân bằng</option>
                              <option value="advantage">
                                Blue dẫn trước về vàng
                              </option>
                              <option value="missing">
                                Nguồn không hỗ trợ gold
                              </option>
                            </select>
                          </label>
                          <div className="event-buttons">
                            {(
                              [
                                ["kill", "⚔", "Hạ gục", "Ryze hạ Taliyah"],
                                ["level", "↑", "Lên cấp", "Ryze lên một cấp"],
                                [
                                  "objective",
                                  "◇",
                                  "Hạ gục rồng",
                                  "Tạo sự kiện và đặt lại bộ đếm",
                                ],
                                [
                                  "draft",
                                  "PICK",
                                  "Lượt chọn tiếp",
                                  "Khóa tướng tiếp theo",
                                ],
                              ] as const
                            ).map(([value, icon, title, sub]) => (
                              <button
                                key={value}
                                onClick={() => send({ type: "event", value })}
                              >
                                <span>{icon}</span>
                                <div>
                                  <b>{title}</b>
                                  <small>{sub}</small>
                                </div>
                                <span>＋</span>
                              </button>
                            ))}
                          </div>
                          <div className="divider" />
                          <div className="eyebrow">ĐỘ PHỦ DỮ LIỆU</div>
                          <div className="capability">
                            <span>Cấp độ / KDA / CS</span>
                            <b>DEMO</b>
                          </div>
                          <div className="capability">
                            <span>Tổng vàng</span>
                            <b
                              className={
                                !state.capabilities.gold ? "unavailable" : ""
                              }
                            >
                              {state.capabilities.gold ? "DEMO" : "KHÔNG CÓ"}
                            </b>
                          </div>
                          <div className="capability">
                            <span>XP chính xác</span>
                            <b className="unavailable">KHÔNG CÓ</b>
                          </div>
                          <div className="capability">
                            <span>Observer Agent</span>
                            <b className="unavailable">CHƯA KẾT NỐI</b>
                          </div>
                          <div className="divider" />
                          <p className="muted">
                            Thay đổi được áp dụng ngay. Theme tự lưu trên máy;
                            trạng thái mock được đặt lại khi khởi động backend.
                          </p>
                        </>
                      ) : (
                        <>
                          <div className="eyebrow">NHẬN DIỆN GIẢI ĐẤU</div>
                          <h3>Theme của giải đấu</h3>
                          <p className="muted">
                            Preset 1920×1080 sử dụng Beaufort for LoL và Spiegel
                            chính thức; hình ảnh tướng, item và rune lấy từ Data
                            Dragon local.
                          </p>
                          {(
                            [
                              ["name", "Tên theme"],
                              ["tournament", "Tên giải"],
                              ["blueName", "Đội xanh"],
                              ["redName", "Đội đỏ"],
                            ] as const
                          ).map(([key, label]) => (
                            <label className="field" key={key}>
                              {label}
                              <input
                                key={`${key}-input`}
                                value={theme[key]}
                                maxLength={
                                  key === "tournament"
                                    ? 80
                                    : key === "name"
                                      ? 60
                                      : 30
                                }
                                onChange={(e) => {
                                  if (e.target.value.trim())
                                    change({ [key]: e.target.value });
                                }}
                              />
                            </label>
                          ))}
                          <div className="colors">
                            {(
                              [
                                ["blue", "Đội xanh"],
                                ["red", "Đội đỏ"],
                                ["accent", "Màu nhấn"],
                                ["background", "Nền bảng"],
                              ] as const
                            ).map(([key, label]) => (
                              <label key={key}>
                                {label}
                                <div>
                                  <input
                                    aria-label={label}
                                    type="color"
                                    value={theme[key]}
                                    onChange={(e) =>
                                      change({ [key]: e.target.value })
                                    }
                                  />
                                  <small>{theme[key]}</small>
                                </div>
                              </label>
                            ))}
                          </div>
                          <label className="field">
                            Kiểu chữ
                            <select
                              value={theme.font}
                              onChange={(e) =>
                                change({
                                  font: e.target.value as Theme["font"],
                                })
                              }
                            >
                              <option value="system">
                                Spiegel — rõ ràng, hiện đại
                              </option>
                              <option value="condensed">
                                Beaufort — phong cách LoL
                              </option>
                              <option value="serif">
                                Georgia — phong cách biên tập
                              </option>
                            </select>
                          </label>
                          <label className="field">
                            Biến thể
                            <select
                              value={theme.variant}
                              onChange={(e) =>
                                change({
                                  variant: e.target.value as Theme["variant"],
                                })
                              }
                            >
                              <option value="panel">
                                Bảng phát sóng đầy đủ
                              </option>
                              <option value="minimal">
                                Tối giản / đường nhấn
                              </option>
                            </select>
                          </label>
                          <label className="field">
                            Tỷ lệ widget: {Math.round(theme.scale * 100)}%
                            <input
                              type="range"
                              min=".75"
                              max="1.15"
                              step=".01"
                              value={theme.scale}
                              onChange={(e) =>
                                change({ scale: +e.target.value })
                              }
                            />
                          </label>
                          <label className="field">
                            Dịch dọc: {theme.offsetY}px
                            <input
                              type="range"
                              min="0"
                              max="100"
                              value={theme.offsetY}
                              onChange={(e) =>
                                change({ offsetY: +e.target.value })
                              }
                            />
                          </label>
                          <div className="divider" />
                          <div className="eyebrow">THÀNH PHẦN TRONG TRẬN</div>
                          {Object.entries({
                            players: "Bảng 10 người chơi",
                            levels: "Xếp hạng cấp độ",
                            objectives: "Mục tiêu và bộ đếm",
                            killfeed: "Thông báo hạ gục",
                            gold: "Thông tin vàng",
                          }).map(([key, label]) => (
                            <label className="toggle" key={key}>
                              {label}
                              <input
                                type="checkbox"
                                checked={
                                  theme.widgets[key as keyof Theme["widgets"]]
                                }
                                onChange={(e) =>
                                  change({
                                    widgets: {
                                      ...theme.widgets,
                                      [key]: e.target.checked,
                                    },
                                  })
                                }
                              />
                            </label>
                          ))}
                          <div className="theme-actions">
                            <button onClick={() => change(referenceTheme)}>
                              Khớp ảnh mẫu
                            </button>
                            <button onClick={exportTheme}>↓ Export</button>
                            <button onClick={() => file.current?.click()}>
                              ↑ Import
                            </button>
                            <button
                              onClick={() => {
                                change({
                                  ...defaultTheme,
                                  name: "Minimal / Placeholder",
                                  variant: "minimal",
                                  accent: "#a9c9be",
                                  font: "serif",
                                });
                              }}
                            >
                              Theme mẫu 2
                            </button>
                          </div>
                          <input
                            ref={file}
                            hidden
                            type="file"
                            accept=".json"
                            onChange={async (e) => {
                              const f = e.target.files?.[0];
                              if (!f) return;
                              try {
                                if (f.size > 65536) throw Error();
                                const result = themeSchema.parse(
                                  JSON.parse(await f.text()),
                                );
                                send({ type: "theme", value: result });
                                setNotice("Đã nhập theme.");
                              } catch {
                                setError(
                                  "Theme không hợp lệ. Cần JSON schema phiên bản 1, tối đa 64KB.",
                                );
                              }
                              e.target.value = "";
                            }}
                          />
                        </>
                      )}
                    </div>
                  </aside>
                </div>
              </div>
            </>
          )}
          <footer>
            RIFT STUDIO <span>LOCAL-FIRST / MODULAR WORKSPACE</span>
            <span>LOL ACTIVE / VALORANT PLANNED</span>
          </footer>
        </div>
      </main>
      {(error || notice) && (
        <div
          role="status"
          className="toast"
          onClick={() => {
            setError("");
            setNotice("");
          }}
        >
          {error || notice} <b>×</b>
        </div>
      )}
    </div>
  );
}
createRoot(document.getElementById("root")!).render(<App />);
