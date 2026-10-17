import { useState } from "react";
import { Card } from "./components/ui/card";
import { Button } from "./components/ui/button";
import { Input } from "./components/ui/input";
import { Badge } from "./components/ui/badge";
import type { ValorantCommand, ValorantField, ValorantFrame } from "../shared/valorant";
import { useValorant } from "./lib/useValorant";

const statusText = {
  offline: "Chưa kết nối backend Spectra (cổng output)",
  connecting: "Đang kết nối…",
  waiting: "Đã kết nối, chờ dữ liệu trận",
  receiving: "Đang nhận dữ liệu",
  stale: "Lâu chưa có frame mới (nguồn chỉ phát khi có sự kiện)",
  invalid: "Payload không hợp lệ",
} as const;
const mark = { observed: "", derived: " (suy ra)", manual: " (nhập tay)" } as const;
const show = (f: ValorantField<string | number | boolean>) =>
  f.value === null ? "—" : `${String(f.value)}${mark[f.provenance]}`;

const controlErrors: Record<string, string> = {
  "client-not-managed": "Client do Studio quản lý chưa chạy (dùng npm run start:all).",
  "client-unreachable": "Không nối được Client fork.",
  "not-connected": "Client chưa kết nối backend Spectra.",
  "invalid-command": "Lệnh không hợp lệ.",
};

function Controls({ frame }: { frame: ValorantFrame | null }) {
  const [message, setMessage] = useState("");
  const [toast, setToast] = useState({ title: "", message: "" });
  const send = async (command: ValorantCommand) => {
    try {
      const res = await fetch("/api/valorant/control", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify(command),
      });
      const body = await res.json();
      setMessage(body.ok ? "Đã gửi lệnh." : (controlErrors[body.error] ?? "Không gửi được lệnh."));
    } catch {
      setMessage("Mất kết nối Studio.");
    }
  };
  const c = frame?.controls;
  const buttons: [string, ValorantCommand, string][] = [
    ["Bom đã đặt (spike planted)", { command: "spike_planted" }, "Chỉ nhận khi round đang combat."],
    ["Tech pause", { command: "tech_pause" }, c?.techPause ? "Đang bật" : "Đang tắt"],
    [
      "Timeout đội trái",
      { command: "left_timeout" },
      c?.leftTimeout ? `Đang chạy ${c.timeoutRemaining}s` : "Sẵn sàng",
    ],
    [
      "Timeout đội phải",
      { command: "right_timeout" },
      c?.rightTimeout ? `Đang chạy ${c.timeoutRemaining}s` : "Sẵn sàng",
    ],
    [
      "Đổi KDA / Credits",
      { command: "switch_kda_credits" },
      c?.showAliveKda ? "Đang hiện KDA" : "Đang hiện credits",
    ],
    ["Đổi trái / phải", { command: "swap_left_right" }, "Đảo vị trí hai đội"],
    ["Đổi tấn công / thủ", { command: "swap_attacker_defender" }, "Đảo phe"],
  ];
  return (
    <Card>
      <small>ĐIỀU KHIỂN THỦ CÔNG (CÙNG LỆNH VỚI SPECTRA CLIENT)</small>
      <p>Các giá trị này do operator bấm tay, không phải telemetry game.</p>
      <div className="module-grid">
        {buttons.map(([label, command, hint]) => (
          <Button className="module-card" key={command.command} onClick={() => void send(command)}>
            <b>{label}</b>
            <p>{hint}</p>
          </Button>
        ))}
      </div>
      <h3>Thông báo (toast)</h3>
      <Input
        placeholder="Tiêu đề"
        maxLength={80}
        value={toast.title}
        onChange={(e) => setToast({ ...toast, title: e.target.value })}
      />
      <Input
        placeholder="Nội dung"
        maxLength={200}
        value={toast.message}
        onChange={(e) => setToast({ ...toast, message: e.target.value })}
      />
      <Button onClick={() => void send({ command: "toast", ...toast, duration: 8000 })}>
        {c?.toast.active ? "Đang hiện, bấm để tắt" : "Hiện toast 8 giây"}
      </Button>
      {message && <p role="status">{message}</p>}
    </Card>
  );
}

export function ValorantDesk() {
  const { status, frame, detail } = useValorant(1000, true);
  const overlayUrl = `${location.origin}/valorant-overlay`;
  const ingameUrl = `http://127.0.0.1:5322/overlay?groupCode=${detail?.groupCode ?? "RIOTLOCAL"}`;
  return (
    <section className="dashboard">
      <Card>
        <small>NGUỒN: SPECTRA → SOCKET.IO OUTPUT</small>
        <h3>{statusText[status]}</h3>
        <p>
          Backend và Client chạy bằng <code>npm run start:valorant</code>. Ô trống nghĩa là Spectra
          chưa có bằng chứng cho field đó; HP/ability chỉ hiện khi kênh Auxiliary xác nhận.
        </p>
        {detail && (
          <p>
            {detail.endpoint} · group {detail.groupCode} · {detail.acceptedFrames} frame hợp lệ ·{" "}
            {detail.invalidFrames} lỗi
          </p>
        )}
        <p>
          URL OBS (1920×1080, nền trong suốt):{" "}
          <a href={overlayUrl} target="_blank" rel="noreferrer">
            {overlayUrl}
          </a>
        </p>
        <p>
          Overlay in-game đầy đủ (VAL26, 1920×1080, nền trong suốt):{" "}
          <a href={ingameUrl} target="_blank" rel="noreferrer">
            {ingameUrl}
          </a>
        </p>
        <Badge variant="outline">Telemetry game chưa được kiểm chứng đầy đủ</Badge>
      </Card>
      <Controls frame={frame} />
      {frame && (
        <>
          <Card>
            <small>TRẬN</small>
            <h3>
              {show(frame.match.map)} · round {frame.match.roundNumber} ·{" "}
              {show(frame.match.roundPhase)}
            </h3>
            <p>
              Slot {frame.coverage.players} · scoreboard {frame.coverage.scoreboard} · HP{" "}
              {frame.coverage.health} · ability {frame.coverage.abilities}
            </p>
          </Card>
          {frame.teams.map((team) => (
            <Card key={team.index}>
              <small>
                {show(team.name)} · {team.isAttacking ? "tấn công" : "phòng thủ"} · {team.roundsWon}
              </small>
              {team.players.length === 0 && <p>Chưa có người chơi.</p>}
              {team.players.map((p) => (
                <p key={p.slot}>
                  <b>{show(p.agent)}</b> · HP {show(p.health)} · {show(p.weapon)} / {show(p.armor)}{" "}
                  · ${show(p.money)} · Ult {show(p.ultimate.points)}/{show(p.ultimate.max)} · KDA{" "}
                  {show(p.kills)}/{show(p.deaths)}/{show(p.assists)}· chiêu C/Q/E{" "}
                  {show(p.abilities.grenade)}/{show(p.abilities.ability1)}/
                  {show(p.abilities.ability2)}
                </p>
              ))}
            </Card>
          ))}
        </>
      )}
    </section>
  );
}
