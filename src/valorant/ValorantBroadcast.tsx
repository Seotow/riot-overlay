import { useEffect, useRef, useState } from "react";
import { Button } from "../components/ui/button";
import { Input } from "../components/ui/input";
import type { ValorantCommand, ValorantFrame } from "../../shared/valorant";
import type { GamesReport } from "../lib/useGames";
import { useValorant } from "../lib/useValorant";
import { RemotePanel } from "./ValorantRemote";
import { ingameUrl } from "./ValorantOverview";

const errors: Record<string, string> = {
  "client-not-managed": "Client chưa chạy.",
  "client-unreachable": "Không nối được Client.",
  "not-connected": "Client chưa kết nối backend.",
  "invalid-command": "Lệnh không hợp lệ.",
  "not-in-combat": "Chỉ đặt bom được khi round đang giao tranh.",
};

function Preview({ group }: { group: string }) {
  const box = useRef<HTMLDivElement>(null);
  const [scale, setScale] = useState(0.4);
  useEffect(() => {
    const el = box.current;
    if (!el) return;
    const fit = () => setScale(el.clientWidth / 1920);
    fit();
    const observer = new ResizeObserver(fit);
    observer.observe(el);
    return () => observer.disconnect();
  }, []);
  return (
    <div className="val-preview" ref={box} style={{ height: 1080 * scale }}>
      <iframe
        title="Xem trước overlay Valorant"
        src={ingameUrl(group)}
        width={1920}
        height={1080}
        style={{ transform: `scale(${scale})` }}
      />
    </div>
  );
}

export function ValorantBroadcast({
  games,
  busy,
  toggle,
}: {
  games: GamesReport | null;
  busy: boolean;
  toggle: (on: boolean) => void;
}) {
  const on = games?.games.valorant ?? false;
  const { frame, detail } = useValorant(700, true);
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
      setMessage(body.ok ? "" : (errors[body.error] ?? "Không gửi được lệnh."));
    } catch {
      setMessage("Mất kết nối Studio.");
    }
  };
  if (!on)
    return (
      <section className="val-page">
        <p>Kết nối Valorant đang tắt.</p>
        <Button disabled={busy} onClick={() => toggle(true)}>
          Bật kết nối Valorant
        </Button>
      </section>
    );
  const c: ValorantFrame["controls"] | undefined = frame?.controls;
  const buttons: [string, ValorantCommand, boolean, string?][] = [
    ["Bom đã đặt", { command: "spike_planted" }, false],
    ["Tech pause", { command: "tech_pause" }, !!c?.techPause],
    [
      "Timeout trái",
      { command: "left_timeout" },
      !!c?.leftTimeout,
      c?.leftTimeout ? `${c.timeoutRemaining}s` : undefined,
    ],
    [
      "Timeout phải",
      { command: "right_timeout" },
      !!c?.rightTimeout,
      c?.rightTimeout ? `${c.timeoutRemaining}s` : undefined,
    ],
    ["KDA / Credits", { command: "switch_kda_credits" }, !!c?.showAliveKda],
    ["Đổi trái / phải", { command: "swap_left_right" }, false],
    ["Đổi tấn công / thủ", { command: "swap_attacker_defender" }, false],
    ["Áp dụng lại cấu hình", { command: "apply_config" }, false],
  ];
  return (
    <section className="val-broadcast">
      <Preview group={detail?.groupCode ?? "RIOTLOCAL"} />
      <div className="val-controls">
        <div className="val-buttons">
          {buttons.map(([label, command, active, extra]) => (
            <Button
              key={command.command}
              className={active ? "active" : ""}
              onClick={() => void send(command)}
            >
              {label}
              {extra ? ` · ${extra}` : ""}
            </Button>
          ))}
        </div>
        <div className="val-toast">
          <Input
            placeholder="Tiêu đề toast"
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
          <Button
            className={c?.toast.active ? "active" : ""}
            onClick={() => void send({ command: "toast", ...toast, duration: 8000 })}
          >
            {c?.toast.active ? "Tắt toast" : "Hiện toast 8 giây"}
          </Button>
        </div>
        {message && <p role="alert">{message}</p>}
        <RemotePanel />
      </div>
    </section>
  );
}
