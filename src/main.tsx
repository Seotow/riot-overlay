import React, { useEffect, useRef, useState } from "react";
import { createRoot } from "react-dom/client";
import {
  Radio,
  LayoutDashboard,
  Settings2,
  Cable,
  Clapperboard,
  Film,
  Swords,
  ChartColumn,
  PanelTop,
  ExternalLink,
  X,
} from "lucide-react";
import { observerFrameSchema, type ObserverFrame } from "../shared/observer";
import type { Command, State } from "../shared/schema";
import { Diagnostics } from "./Diagnostics";
import { MatchConfig, ProductionDesk } from "./Production";
import { DraftDesk } from "./DraftDesk";
import { PostgameDesk } from "./PostgameDesk";
import { ReplayHud } from "./ReplayHud";
import { RecordingDesk } from "./RecordingDesk";
import {
  Dashboard,
  SourcePanel,
  Roadmap,
  studioModules,
  useProviders,
  type StudioPage,
} from "./Dashboard";
import { Surface } from "./overlay/Surface";
import { Button } from "./components/ui/button";
import { Badge } from "./components/ui/badge";
import "./fonts.css";
import "./style.css";
import "./overlay/overlay.css";
import "./overlay/postgame.css";
import "./studio.css";

const isOverlay = location.pathname === "/overlay";
document.body.className = isOverlay ? "overlay-body" : "studio-body";
document.documentElement.classList.toggle("overlay-body", isOverlay);
const navigation = [
  { id: "overview", label: "Tổng quan", icon: LayoutDashboard },
  { id: "theme", label: "Cấu hình trận đấu", icon: Settings2 },
  { id: "sources", label: "Nguồn dữ liệu", icon: Cable },
  { id: "studio", label: "Phát sóng", icon: Clapperboard },
  { id: "demo", label: "Phòng thử", icon: Film },
  { id: "draft", label: "Cấm chọn", icon: Swords },
  { id: "postgame", label: "Sau trận", icon: ChartColumn },
  { id: "hud", label: "HUD trong game", icon: PanelTop },
] as const;

function useSession() {
  const [state, setState] = useState<State | null>(null);
  const [connected, setConnected] = useState(false);
  const [observation, setObservation] = useState<ObserverFrame | null>(null);
  const [error, setError] = useState("");
  const ref = useRef<WebSocket | null>(null);
  useEffect(() => {
    let stopped = false,
      timer: ReturnType<typeof setTimeout>;
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
    studioModules.find((m) => m.id === new URLSearchParams(location.search).get("page"))?.id ??
      "overview",
  );
  const navigate = (next: StudioPage) => {
    setPage(next);
    history.pushState(null, "", `/?page=${next}`);
    window.scrollTo(0, 0);
  };
  useEffect(() => {
    const pop = () =>
      setPage(
        studioModules.find((m) => m.id === new URLSearchParams(location.search).get("page"))?.id ??
          "overview",
      );
    addEventListener("popstate", pop);
    return () => removeEventListener("popstate", pop);
  }, []);
  if (isOverlay)
    return <>{state && connected && <Surface state={state} observation={observation} />}</>;
  if (!state)
    return (
      <div className="studio-loading">
        <Radio size={28} />
        <p>Đang kết nối Studio...</p>
      </div>
    );
  const title = navigation.find((n) => n.id === page)?.label ?? "Thông tin kỹ thuật";
  const mode = state.mockVisible
    ? "Dữ liệu mẫu"
    : state.provider === "recording"
      ? "Bản ghi"
      : "Trực tiếp";
  return (
    <div className="app studio-shell dark">
      <aside className="rail">
        <a className="brand" href="/">
          <Radio size={26} />
          <span>
            Rift Studio<small>League of Legends</small>
          </span>
        </a>
        <nav aria-label="Điều hướng Studio">
          {navigation.map(({ id, label, icon: Icon }, i) => (
            <React.Fragment key={id}>
              {(i === 0 || i === 3 || i === 5) && (
                <div className="nav-group-label">
                  {i === 0 ? "Chuẩn bị" : i === 3 ? "Điều khiển" : "Công cụ"}
                </div>
              )}
              <Button
                variant="ghost"
                className={`nav ${page === id ? "active" : ""}`}
                aria-current={page === id ? "page" : undefined}
                onClick={() => navigate(id)}
              >
                <Icon size={18} />
                <span>{label}</span>
              </Button>
            </React.Fragment>
          ))}
        </nav>
        <div className="rail-bottom">
          <span className={`connection-dot ${connected ? "online" : ""}`} />
          {connected ? "Đã kết nối" : "Mất kết nối"}
        </div>
      </aside>
      <main>
        <header className="topbar">
          <div>
            <h1>{title}</h1>
            <span className="header-match">
              {state.theme.blueName} <span>vs</span> {state.theme.redName}
            </span>
          </div>
          <div className="header-actions">
            <Badge variant="outline">{mode}</Badge>
            <Button asChild variant="outline">
              <a href="/overlay" target="_blank" rel="noreferrer">
                <ExternalLink size={15} />
                Mở overlay
              </a>
            </Button>
          </div>
        </header>
        <div className={`content module-content view-${page}`}>
          {!connected && (
            <div className="studio-alert" role="alert">
              Đang kết nối lại. Các nút điều khiển tạm ngưng.
            </div>
          )}
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
                <summary>Chẩn đoán kết nối</summary>
                <Diagnostics />
              </details>
            </>
          )}
          {page === "theme" && (
            <MatchConfig
              state={state}
              connected={connected}
              send={send}
              next={() => navigate("studio")}
            />
          )}
          {page === "studio" && (
            <ProductionDesk
              state={state}
              connected={connected}
              send={send}
              observation={observation}
            />
          )}
          {page === "demo" && (
            <RecordingDesk
              state={state}
              connected={connected}
              send={send}
              observation={observation}
            />
          )}
          {page === "draft" && <DraftDesk state={state} connected={connected} send={send} />}
          {page === "postgame" && <PostgameDesk state={state} connected={connected} send={send} />}
          {page === "hud" && <ReplayHud state={state} connected={connected} send={send} />}
          {page === "roadmap" && <Roadmap />}
        </div>
      </main>
      {error && (
        <div className="toast" role="alert">
          <span>{error}</span>
          <Button
            size="icon-sm"
            variant="ghost"
            aria-label="Đóng thông báo"
            onClick={() => setError("")}
          >
            <X size={16} />
          </Button>
        </div>
      )}
    </div>
  );
}
createRoot(document.getElementById("root")!).render(<App />);
