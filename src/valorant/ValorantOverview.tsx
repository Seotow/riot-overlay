import { Card } from "../components/ui/card";
import { Button } from "../components/ui/button";
import { Badge } from "../components/ui/badge";
import type { ValorantField, ValorantFrame } from "../../shared/valorant";
import type { ValorantConfigView } from "../../shared/valorant-config";
import type { GamesReport } from "../lib/useGames";
import { useValorant } from "../lib/useValorant";

export const moduleText = {
  stopped: "Đã tắt",
  installing: "Đang cài đặt…",
  starting: "Đang khởi động…",
  running: "Đang chạy",
  failed: "Lỗi",
} as const;
// Trạng thái collector do supervisor báo; chỉ nêu lỗi cần người dùng xử lý.
const collectorHint = (state: string | null) =>
  state === "official-not-installed"
    ? "Chưa có Spectra Client chính thức: tắt rồi bật lại kết nối để tự tải (một lần), hoặc chạy npm run valorant:setup."
    : state === "official-failed"
      ? "Không điều khiển được Spectra Client chính thức; xem lỗi bên dưới."
      : state === "official-exited-1" || state?.startsWith("official-exited")
        ? "Spectra Client chính thức đã thoát; tắt rồi bật lại kết nối."
        : null;
const sourceText = {
  offline: "Chưa kết nối",
  connecting: "Đang kết nối",
  waiting: "Chờ dữ liệu trận",
  receiving: "Đang nhận dữ liệu",
  stale: "Lâu chưa có sự kiện mới",
  invalid: "Payload lỗi",
} as const;
const phaseText: Record<string, string> = {
  LOBBY: "Sảnh",
  shopping: "Mua đồ",
  combat: "Giao tranh",
  end: "Kết thúc round",
  game_end: "Kết thúc trận",
};
export const val = (f: ValorantField<string | number | boolean>) =>
  f.value === null ? "—" : String(f.value);
export const ingameUrl = (group: string) => `http://127.0.0.1:5322/overlay?groupCode=${group}`;

function Roster({ frame }: { frame: ValorantFrame }) {
  const rows = frame.teams.flatMap((t) => t.players.map((p) => ({ team: t.index, p })));
  if (rows.length === 0) return <p>Chưa có người chơi.</p>;
  return (
    <table className="val-table">
      <thead>
        <tr>
          <th>Đội</th>
          <th>Agent</th>
          <th>K/D/A</th>
          <th>Tiền</th>
          <th>Vũ khí</th>
          <th>Giáp</th>
          <th>Ult</th>
        </tr>
      </thead>
      <tbody>
        {rows.map(({ team, p }) => (
          <tr key={`${team}-${p.slot}`} className={p.isAlive.value === false ? "dead" : ""}>
            <td>{team + 1}</td>
            <td>{val(p.agent)}</td>
            <td>
              {val(p.kills)}/{val(p.deaths)}/{val(p.assists)}
            </td>
            <td>{val(p.money)}</td>
            <td>{val(p.weapon)}</td>
            <td>{val(p.armor)}</td>
            <td>
              {val(p.ultimate.points)}/{val(p.ultimate.max)}
            </td>
          </tr>
        ))}
      </tbody>
    </table>
  );
}

export function ValorantOverview({
  games,
  busy,
  toggle,
  config,
}: {
  games: GamesReport | null;
  busy: boolean;
  toggle: (on: boolean) => void;
  config: ValorantConfigView | null;
}) {
  const on = games?.games.valorant ?? false;
  const { status, frame, detail } = useValorant(1000, true);
  const group = detail?.groupCode ?? "RIOTLOCAL";
  const module = games?.valorant;
  const teams = config?.config.teams;
  const series = config?.config.series;
  return (
    <section className="val-page">
      <Card className="val-card">
        <div className="val-row">
          <h3>Kết nối</h3>
          <Badge variant="outline">
            {module ? moduleText[module.status] : "Studio chưa trả lời"}
          </Badge>
          {on && <Badge variant="outline">{sourceText[status]}</Badge>}
          <Button disabled={busy} onClick={() => toggle(!on)}>
            {on ? "Tắt kết nối Valorant" : "Bật kết nối Valorant"}
          </Button>
        </div>
        {module?.step && <p>{module.step}…</p>}
        {module?.error && <p role="alert">{module.error}</p>}
        {module?.official && (
          <p>
            Spectra Client (chạy ngầm): {module.official.title || module.official.state}
            {module.controllerConnected === false ? " · lệnh thủ công chờ trận bắt đầu" : ""}
          </p>
        )}
        {module?.collectorError && <p role="alert">{module.collectorError}</p>}
        {collectorHint(module?.collector ?? null) && (
          <p role="alert">{collectorHint(module?.collector ?? null)}</p>
        )}
        {detail && (
          <p>
            {detail.acceptedFrames} frame hợp lệ · {detail.invalidFrames} lỗi · group{" "}
            {detail.groupCode}
          </p>
        )}
        <p>
          OBS in-game:{" "}
          <a href={ingameUrl(group)} target="_blank" rel="noreferrer">
            {ingameUrl(group)}
          </a>
        </p>
      </Card>
      <Card className="val-card">
        <h3>Trận</h3>
        {frame ? (
          <>
            <p>
              {val(frame.match.map)} · {val(frame.match.mode)} · round {frame.match.roundNumber} ·{" "}
              {phaseText[String(frame.match.roundPhase.value)] ?? "—"}
            </p>
            <div className="val-score">
              <span>{teams?.[0].name ?? val(frame.teams[0].name)}</span>
              <b>{frame.teams[0].roundsWon}</b>
              <small>round</small>
              <b>{frame.teams[1].roundsWon}</b>
              <span>{teams?.[1].name ?? val(frame.teams[1].name)}</span>
            </div>
            {series && (
              <p>
                Loạt trận BO{series.needed * 2 - 1}: {series.wonLeft} – {series.wonRight}
              </p>
            )}
            <Roster frame={frame} />
          </>
        ) : (
          <p>{on ? "Chưa có dữ liệu trận." : "Bật kết nối để nhận dữ liệu."}</p>
        )}
      </Card>
    </section>
  );
}
