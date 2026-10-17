import type { ValorantFrame, ValorantPlayer } from "../../shared/valorant";
import { useValorant } from "../lib/useValorant";
import "./valorant.css";

// Renderer OBS chỉ nhận dữ liệu: không có nền, không nút. Ô thiếu dữ liệu để trống, không điền số mặc định.
function Card({ p }: { p: ValorantPlayer }) {
  const hp = p.health.value;
  return (
    <div
      className={`vo-card ${p.isAlive.value === false ? "dead" : ""} ${p.isObserved ? "watched" : ""}`}
    >
      <div className="vo-head">
        <b>{p.agent.value ?? "—"}</b>
        <span>{p.name.value?.split("#")[0] ?? ""}</span>
      </div>
      {hp !== null && (
        <div className="vo-hp">
          <i style={{ width: `${Math.max(0, Math.min(100, hp))}%` }} />
          <em>{hp}</em>
        </div>
      )}
      <div className="vo-row">
        {p.weapon.value && <span>{p.weapon.value}</span>}
        {p.armor.value && <span>{p.armor.value}</span>}
        {p.money.value !== null && <span>${p.money.value}</span>}
      </div>
      <div className="vo-row">
        {p.ultimate.points.value !== null && p.ultimate.max.value !== null && (
          <span className={p.ultimate.ready.value ? "ult ready" : "ult"}>
            ULT {p.ultimate.points.value}/{p.ultimate.max.value}
          </span>
        )}
        {p.kills.value !== null && (
          <span>
            {p.kills.value}/{p.deaths.value ?? "–"}/{p.assists.value ?? "–"}
          </span>
        )}
        {p.hasSpike.value && <span className="spike">SPIKE</span>}
      </div>
    </div>
  );
}
function Board({ frame }: { frame: ValorantFrame }) {
  const [a, b] = frame.teams;
  return (
    <>
      <div className="vo-score">
        <span>{a.name.value ?? "Đội 1"}</span>
        <b>{a.roundsWon}</b>
        <small>
          {frame.match.map.value ?? ""} · R{frame.match.roundNumber}
        </small>
        <b>{b.roundsWon}</b>
        <span>{b.name.value ?? "Đội 2"}</span>
      </div>
      {frame.teams.map((t) => (
        <div className={`vo-team t${t.index}`} key={t.index}>
          {t.players.map((p) => (
            <Card key={p.slot} p={p} />
          ))}
        </div>
      ))}
    </>
  );
}
export function ValorantOverlay() {
  const { status, frame } = useValorant(250);
  // Không có nguồn hoặc chưa chạy trận thì để trống trong suốt, không hiển thị mock.
  if (!frame || !frame.match.running || status === "offline" || status === "invalid") return null;
  return (
    <div className="vo-root">
      <Board frame={frame} />
    </div>
  );
}
