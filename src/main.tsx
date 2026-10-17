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
  Crosshair,
  Gamepad2,
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
import { ValorantOverview, moduleText } from "./valorant/ValorantOverview";
import { ValorantMatchConfig } from "./valorant/ValorantMatchConfig";
import { ValorantBroadcast } from "./valorant/ValorantBroadcast";
import { useGames, type GameId } from "./lib/useGames";
import { useValorantConfig } from "./lib/useValorantConfig";
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
import "./valorant.css";

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
const valorantNavigation = [
  { id: "overview", label: "Tổng quan", icon: LayoutDashboard },
  { id: "config", label: "Cấu hình trận", icon: Settings2 },
  { id: "broadcast", label: "Phát sóng", icon: Clapperboard },
] as const;
type ValorantPage = (typeof valorantNavigation)[number]["id"];
const gameLabels: Record<GameId, string> = { lol: "League of Legends", valorant: "VALORANT" };
const readGame = (): GameId => {
  const fromUrl = new URLSearchParams(location.search).get("game");
  if (fromUrl === "lol" || fromUrl === "valorant") return fromUrl;
  try {
    const saved = localStorage.getItem("studio-game");
    if (saved === "lol" || saved === "valorant") return saved;
  } catch {}
  return "lol";
};
const readValorantPage = (): ValorantPage =>
  valorantNavigation.find((n) => n.id === new URLSearchParams(location.search).get("page"))?.id ??
  "overview";

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
  const [game, setGameState] = useState<GameId>(readGame);
  const [valorantPage, setValorantPage] = useState<ValorantPage>(readValorantPage);
  const gamesPower = useGames();
  const valorantConfig = useValorantConfig();
  const query = (g: GameId, p: string) =>
    g === "lol" ? `/?page=${p}` : `/?game=valorant&page=${p}`;
  const navigate = (next: StudioPage) => {
    setPage(next);
    history.pushState(null, "", query("lol", next));
    window.scrollTo(0, 0);
  };
  const navigateValorant = (next: ValorantPage) => {
    setValorantPage(next);
    history.pushState(null, "", query("valorant", next));
    window.scrollTo(0, 0);
  };
  const setGame = (next: GameId) => {
    setGameState(next);
    try {
      localStorage.setItem("studio-game", next);
    } catch {}
    history.pushState(null, "", query(next, next === "lol" ? page : valorantPage));
  };
  useEffect(() => {
    const pop = () => {
      setGameState(readGame());
      setValorantPage(readValorantPage());
      setPage(
        studioModules.find((m) => m.id === new URLSearchParams(location.search).get("page"))?.id ??
          "overview",
      );
    };
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
  const isVal = game === "valorant";
  const title = isVal
    ? (valorantNavigation.find((n) => n.id === valorantPage)?.label ?? "VALORANT")
    : (navigation.find((n) => n.id === page)?.label ?? "Thông tin kỹ thuật");
  const gameOn = gamesPower.report?.games[game] ?? false;
  const valorantTeams = valorantConfig.view?.config.teams;
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
            Rift Studio<small>{gameLabels[game]}</small>
          </span>
        </a>
        <div className="rail-game">
          <div className="games" role="group" aria-label="Chọn game">
            {(["lol", "valorant"] as const).map((id) => (
              <Button
                key={id}
                variant="ghost"
                className={`game ${game === id ? "active" : ""}`}
                aria-pressed={game === id}
                onClick={() => setGame(id)}
              >
                {id === "lol" ? <Gamepad2 size={16} /> : <Crosshair size={16} />}
                <span>{id === "lol" ? "LoL" : "Valorant"}</span>
              </Button>
            ))}
          </div>
          <label className="power">
            <span>
              Kết nối {game === "lol" ? "LoL" : "Valorant"}
              {isVal && gamesPower.report
                ? ` · ${moduleText[gamesPower.report.valorant.status]}`
                : ""}
            </span>
            <input
              type="checkbox"
              role="switch"
              aria-label={`Bật kết nối ${gameLabels[game]}`}
              checked={gameOn}
              disabled={gamesPower.busy || !gamesPower.report}
              onChange={(e) => void gamesPower.toggle(game, e.target.checked)}
            />
          </label>
        </div>
        <nav aria-label="Điều hướng Studio">
          {isVal &&
            valorantNavigation.map(({ id, label, icon: Icon }) => (
              <Button
                key={id}
                variant="ghost"
                className={`nav ${valorantPage === id ? "active" : ""}`}
                aria-current={valorantPage === id ? "page" : undefined}
                onClick={() => navigateValorant(id)}
              >
                <Icon size={18} />
                <span>{label}</span>
              </Button>
            ))}
          {!isVal &&
            navigation.map(({ id, label, icon: Icon }, i) => (
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
              {isVal
                ? `${valorantTeams?.[0].name ?? "Team 1"} vs ${valorantTeams?.[1].name ?? "Team 2"}`
                : `${state.theme.blueName} vs ${state.theme.redName}`}
            </span>
          </div>
          <div className="header-actions">
            <Badge variant="outline">{isVal ? "Trực tiếp" : mode}</Badge>
            <Button asChild variant="outline">
              <a
                href={isVal ? "http://127.0.0.1:5322/overlay?groupCode=RIOTLOCAL" : "/overlay"}
                target="_blank"
                rel="noreferrer"
              >
                <ExternalLink size={15} />
                Mở overlay
              </a>
            </Button>
          </div>
        </header>
        <div className={`content module-content view-${isVal ? `valorant-${valorantPage}` : page}`}>
          {!connected && (
            <div className="studio-alert" role="alert">
              Đang kết nối lại. Các nút điều khiển tạm ngưng.
            </div>
          )}
          {isVal && valorantPage === "overview" && (
            <ValorantOverview
              games={gamesPower.report}
              busy={gamesPower.busy}
              toggle={(on) => void gamesPower.toggle("valorant", on)}
              config={valorantConfig.view}
            />
          )}
          {isVal && valorantPage === "config" && (
            <ValorantMatchConfig view={valorantConfig.view} save={valorantConfig.save} />
          )}
          {isVal && valorantPage === "broadcast" && (
            <ValorantBroadcast
              games={gamesPower.report}
              busy={gamesPower.busy}
              toggle={(on) => void gamesPower.toggle("valorant", on)}
            />
          )}
          {!isVal && page === "overview" && (
            <Dashboard
              state={state}
              connected={connected}
              observation={observation}
              report={report}
              send={send}
              navigate={navigate}
            />
          )}
          {!isVal && page === "sources" && (
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
          {!isVal && page === "theme" && (
            <MatchConfig
              state={state}
              connected={connected}
              send={send}
              next={() => navigate("studio")}
            />
          )}
          {!isVal && page === "studio" && (
            <ProductionDesk
              state={state}
              connected={connected}
              send={send}
              observation={observation}
            />
          )}
          {!isVal && page === "demo" && (
            <RecordingDesk
              state={state}
              connected={connected}
              send={send}
              observation={observation}
            />
          )}
          {!isVal && page === "draft" && (
            <DraftDesk state={state} connected={connected} send={send} />
          )}
          {!isVal && page === "postgame" && (
            <PostgameDesk state={state} connected={connected} send={send} />
          )}
          {!isVal && page === "hud" && (
            <ReplayHud state={state} connected={connected} send={send} />
          )}
          {!isVal && page === "roadmap" && <Roadmap />}
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
