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
import "./style.css";
import { Surface } from "./overlay/Surface";
import { referenceTheme } from "../shared/reference";
import "@fontsource/anton/latin-400.css";
import "@fontsource/roboto-condensed/latin-700.css";
import "./overlay/overlay.css";
const isOverlay = location.pathname === "/overlay";
document.body.className = isOverlay ? "overlay-body" : "";
document.documentElement.classList.toggle("overlay-body", isOverlay);
function useSession() {
  const [state, setState] = useState<State | null>(null);
  const [connected, setConnected] = useState(false);
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
        if (data.type === "snapshot") setState(data.state);
        if (data.type === "error") setError(data.message);
      };
      ws.onclose = () => {
        setConnected(false);
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
  return { state, connected, error, setError, send };
}
function App() {
  const { state, connected, error, setError, send } = useSession();
  const [tab, setTab] = useState("control");
  const [reference, setReference] = useState(true);
  const [compare, setCompare] = useState(false);
  const [notice, setNotice] = useState("");
  const file = useRef<HTMLInputElement>(null);
  if (!state) return <div className="loading">Đang kết nối backend…</div>;
  if (isOverlay) return <>{connected && <Surface state={state} />}</>;
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
        <div className="workspace-label">WORKSPACE</div>
        <button className="nav active">
          ◈ <span>LoL Broadcast</span>
        </button>
        <div className="rail-bottom">
          <span className="version">LOCAL WORKSPACE</span>
          <p>
            Overlay Kit <b>0.1</b>
          </p>
          <small>Mock-first prototype</small>
        </div>
      </aside>
      <main>
        <header className="topbar">
          <div>
            <span className="breadcrumb">WORKSPACE / LEAGUE OF LEGENDS</span>
            <h1>
              Broadcast studio<span className="badge">PROTOTYPE</span>
            </h1>
          </div>
          <div className="connection">
            <i className={connected ? "online" : ""} />
            {connected ? "Backend connected" : "Đang kết nối lại…"}
          </div>
        </header>
        <div className="content">
          <div className="section-heading">
            <div>
              <h2>Program preview</h2>
              <p>Duyệt bố cục, thử sự kiện và xây theme của bạn.</p>
            </div>
            <a
              className="button secondary"
              href="/overlay"
              target="_blank"
              rel="noreferrer"
            >
              Mở overlay ↗
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
                    1920 × 1080 <b>MOCK</b>
                  </span>
                </div>
                <Surface
                  state={state}
                  preview
                  reference={reference}
                  compare={compare}
                />
              </div>
              <div className="preview-tools">
                <label>
                  <input
                    type="checkbox"
                    checked={reference}
                    onChange={(e) => setReference(e.target.checked)}
                  />
                  Ảnh tham chiếu
                </label>
                <span>
                  <button onClick={() => setCompare(!compare)}>
                    {compare ? "Xem bản dựng" : "Xem ảnh gốc"}
                  </button>
                </span>
              </div>
              <div className="transport">
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
                SCENES <span>Chuyển cảnh phát sóng</span>
              </div>
              <div className="scene-grid">
                {(
                  [
                    ["draft", "01", "Champion select", "Lượt chọn & đội hình"],
                    [
                      "ingame",
                      "02",
                      "In-game HUD",
                      "Scoreboard & player overview",
                    ],
                    ["postgame", "03", "Post-game", "Kết quả & thống kê"],
                  ] as const
                ).map(([id, n, title, sub]) => (
                  <button
                    key={id}
                    className={`scene-card ${state.scene === id ? "selected" : ""}`}
                    onClick={() => send({ type: "scene", value: id })}
                  >
                    <span>
                      {n}
                      <i>{state.scene === id ? "ON AIR" : "SCENE"}</i>
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
                  Copy URL
                </button>
              </div>
              <div className="note">
                <span>◉</span>
                <p>
                  <b>Dữ liệu giả lập, chưa kết nối LoL.</b> Gold và timer chỉ
                  minh họa UI. Tên, portrait, item và spell lấy từ Data Dragon
                  15.20.1. Camera/logo trên nền tham chiếu không phải dữ liệu
                  game.
                </p>
              </div>
            </section>
            <aside className="inspector">
              <div className="tabs">
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
                {tab === "control" ? (
                  <>
                    <div className="eyebrow">MOCK PROVIDER</div>
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
                        <option value="missing">Nguồn không hỗ trợ gold</option>
                      </select>
                    </label>
                    <div className="event-buttons">
                      {(
                        [
                          ["kill", "⚔", "Champion kill", "Ryze hạ Taliyah"],
                          ["level", "↑", "Level up", "Ryze lên một cấp"],
                          [
                            "objective",
                            "◇",
                            "Dragon taken",
                            "Đặt lại timer minh họa",
                          ],
                          [
                            "draft",
                            "◈",
                            "Next pick",
                            "Khóa lượt chọn tiếp theo",
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
                    <div className="eyebrow">DATA CAPABILITIES</div>
                    <div className="capability">
                      <span>Level / KDA / CS</span>
                      <b>MOCK</b>
                    </div>
                    <div className="capability">
                      <span>Total gold</span>
                      <b
                        className={
                          !state.capabilities.gold ? "unavailable" : ""
                        }
                      >
                        {state.capabilities.gold ? "MOCK" : "UNAVAILABLE"}
                      </b>
                    </div>
                    <div className="capability">
                      <span>XP chính xác</span>
                      <b className="unavailable">UNAVAILABLE</b>
                    </div>
                    <div className="capability">
                      <span>Observer Agent</span>
                      <b className="unavailable">CHƯA KẾT NỐI</b>
                    </div>
                    <div className="divider" />
                    <p className="muted">
                      Thay đổi được áp dụng ngay. Theme tự lưu trên máy; trạng
                      thái mock được đặt lại khi khởi động backend.
                    </p>
                  </>
                ) : (
                  <>
                    <div className="eyebrow">BRAND IDENTITY</div>
                    <h3>Theme của giải đấu</h3>
                    <p className="muted">
                      Preset reference bám ảnh ở 1920×1080. Font Anton + Roboto
                      Condensed; asset Data Dragon cache local.
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
                            key === "tournament" ? 80 : key === "name" ? 60 : 30
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
                          ["blue", "Blue side"],
                          ["red", "Red side"],
                          ["accent", "Accent"],
                          ["background", "Panel"],
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
                      Typography
                      <select
                        value={theme.font}
                        onChange={(e) =>
                          change({ font: e.target.value as Theme["font"] })
                        }
                      >
                        <option value="system">System Sans</option>
                        <option value="condensed">Broadcast Condensed</option>
                        <option value="serif">Editorial Serif</option>
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
                        <option value="panel">Broadcast panels</option>
                        <option value="minimal">Minimal / accent lines</option>
                      </select>
                    </label>
                    <label className="field">
                      Tỷ lệ widget · {Math.round(theme.scale * 100)}%
                      <input
                        type="range"
                        min=".75"
                        max="1.15"
                        step=".01"
                        value={theme.scale}
                        onChange={(e) => change({ scale: +e.target.value })}
                      />
                    </label>
                    <label className="field">
                      Dịch dọc · {theme.offsetY}px
                      <input
                        type="range"
                        min="0"
                        max="100"
                        value={theme.offsetY}
                        onChange={(e) => change({ offsetY: +e.target.value })}
                      />
                    </label>
                    <div className="divider" />
                    <div className="eyebrow">INGAME WIDGETS</div>
                    {Object.entries({
                      players: "Player overview",
                      levels: "Level leaderboard",
                      objectives: "Objective timers",
                      killfeed: "Killfeed",
                      gold: "Gold display",
                    }).map(([key, label]) => (
                      <label className="toggle" key={key}>
                        {label}
                        <input
                          type="checkbox"
                          checked={theme.widgets[key as keyof Theme["widgets"]]}
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
          <footer>
            RIFT STUDIO <span>LOCAL-FIRST / LOL PROTOTYPE</span>
            <span>REFERENCE-LED DESIGN · THEME V1</span>
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
