import { Button } from "./components/ui/button";
import { Input } from "./components/ui/input";
import { useEffect, useState } from "react";
import type { State, Command } from "../shared/schema";
import {
  defaultHud,
  hudFields,
  type HudConfig,
  type HudKey,
} from "../shared/replay-hud";
type Status = {
  connected: boolean;
  fields: Partial<Record<HudKey, boolean>>;
  message?: string;
  verified?: boolean;
  unsupported?: string[];
  mismatched?: string[];
};
export function ReplayHud({
  state,
  send,
  connected,
}: {
  state: State;
  send: (c: Command) => void;
  connected: boolean;
}) {
  const [draft, setDraft] = useState<HudConfig>(
    state.theme.replayHud ?? defaultHud,
  );
  const [status, setStatus] = useState<Status | null>(null);
  const [busy, setBusy] = useState(false),
    [message, setMessage] = useState("");
  const [pending, setPending] = useState<string | null>(null);
  useEffect(() => {
    if (pending && JSON.stringify(state.theme.replayHud) === pending) {
      setPending(null);
      setMessage("Đã lưu preset vào cấu hình. Chưa thay đổi HUD game.");
    }
  }, [state.theme.replayHud, pending]);
  async function refresh() {
    setBusy(true);
    try {
      const r = await fetch("/api/replay-hud/status");
      if (!r.ok) throw Error("Không đọc được trạng thái.");
      setStatus(await r.json());
    } catch (e) {
      setMessage((e as Error).message);
    } finally {
      setBusy(false);
    }
  }
  useEffect(() => {
    void refresh();
  }, []);
  async function apply() {
    setBusy(true);
    setMessage("Đang áp dụng và đọc lại trạng thái...");
    try {
      const r = await fetch("/api/replay-hud/apply", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify(draft),
      });
      const value = await r.json();
      if (!r.ok) throw Error(value.error || "Không áp dụng được.");
      setStatus(value);
      setMessage(
        value.verified
          ? `API đã xác nhận các cờ đã gửi. Cần đối chiếu hình game; ${value.unsupported.length} cờ không được hỗ trợ.`
          : `Có cờ chưa khớp: ${value.mismatched.join(", ")}. Kiểm tra trước khi phát sóng.`,
      );
    } catch (e) {
      setMessage((e as Error).message);
    } finally {
      setBusy(false);
    }
  }
  return (
    <section className="match-config replay-hud">
      <h2>HUD game , League Director / Replay API</h2>
      <p>Chọn các thành phần muốn hiển thị trong game.</p>
      <div className="config-actions">
        <Button disabled={busy} onClick={refresh}>
          Kiểm tra kết nối HUD
        </Button>
        <Button
          disabled={busy || !connected}
          onClick={() => {
            setPending(JSON.stringify(draft));
            send({
              type: "theme",
              value: { ...state.theme, replayHud: draft },
            });
            setMessage("Đang lưu preset...");
          }}
        >
          Lưu preset HUD
        </Button>
        <Button disabled={busy || !status?.connected} onClick={apply}>
          Áp dụng vào game đang mở
        </Button>
        <Button
          disabled={busy}
          onClick={() => {
            setDraft(defaultHud);
            setMessage("Đã nạp preset overlay vào form, chưa áp dụng.");
          }}
        >
          Nạp preset overlay
        </Button>
        <Button
          disabled={busy}
          onClick={() => {
            setDraft({
              ...defaultHud,
              interfaceScore: true,
              interfaceScoreboard: true,
              interfaceFrames: true,
              interfaceTimeline: true,
              interfaceChat: true,
              interfaceQuests: true,
              interfaceNeutralTimers: true,
            });
            setMessage("Đã nạp preset hiện HUD vào form, chưa áp dụng.");
          }}
        >
          Nạp preset hiện HUD
        </Button>
      </div>
      <p role="status">
        {message ||
          status?.message ||
          (status?.connected
            ? "Replay API đã kết nối."
            : "Chưa kiểm tra kết nối.")}
      </p>
      <div className="config-grid">
        <fieldset>
          <legend>Preset hiển thị (bật = hiện)</legend>
          {(Object.keys(hudFields) as HudKey[]).map((key) => {
            const locked = [
              "interfaceAll",
              "interfaceReplay",
              "interfaceAnnounce",
              "interfaceKillCallouts",
            ].includes(key);
            return (
              <label key={key} className="hud-option">
                <Input
                  type="checkbox"
                  checked={draft[key]}
                  disabled={locked || busy}
                  onChange={(e) =>
                    setDraft({ ...draft, [key]: e.target.checked })
                  }
                />
                <span>
                  {hudFields[key]}
                  <small>
                    Game:{" "}
                    {status?.fields[key] === undefined
                      ? "chưa có dữ liệu"
                      : status.fields[key]
                        ? "hiện"
                        : "ẩn"}
                    {locked ? " (luôn bật)" : ""}
                  </small>
                </span>
              </label>
            );
          })}
        </fieldset>
        <fieldset>
          <legend>Giới hạn cần biết</legend>
          <p>
            Thông báo hạ gục và chuỗi hạ gục luôn được giữ lại. Chưa hỗ trợ ẩn
            riêng killfeed gốc.
          </p>
          <p>Chưa hỗ trợ ẩn riêng dấu 18+ VNG.</p>
          <p>
            Chỉ hỗ trợ khi bản game đang mở cung cấp Replay API. Chưa xác nhận
            spectator trực tiếp trên patch hiện tại. Nếu chưa kết nối: mở
            replay, kiểm tra <code>[General] EnableReplayApi=1</code> trong{" "}
            <code>Config/game.cfg</code> rồi khởi động lại replay nếu cần.
          </p>
          <p>Lưu cấu hình, sau đó bấm Áp dụng khi game đã mở.</p>
          <a
            href="https://github.com/RiotGames/leaguedirector"
            target="_blank"
            rel="noreferrer"
          >
            Mã nguồn League Director
          </a>{" "}
          ,{" "}
          <a
            href="https://developer.riotgames.com/docs/lol#game-client-api_replay-api"
            target="_blank"
            rel="noreferrer"
          >
            Replay API chính thức
          </a>
        </fieldset>
      </div>
    </section>
  );
}
