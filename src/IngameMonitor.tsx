import { liveCatalog, liveChampion, liveItem } from "../shared/live-assets";
import { useEffect, useRef, useState } from "react";
import {
  observerFrameSchema,
  recordingSchema,
  type ObserverFrame,
} from "../shared/observer";
const display = (v: number | boolean | null | undefined) =>
  v == null ? "N/A" : String(v);
export function IngameMonitor() {
  const [running, setRunning] = useState(false);
  const [frame, setFrame] = useState<ObserverFrame | null>(null);
  const [error, setError] = useState("");
  const [now, setNow] = useState(Date.now());
  const current = useRef<AbortController | null>(null);
  useEffect(() => {
    const timer = setInterval(() => setNow(Date.now()), 500);
    return () => clearInterval(timer);
  }, []);
  useEffect(() => {
    if (!running) return;
    let stopped = false;
    let timer: ReturnType<typeof setTimeout>;
    const poll = async () => {
      const controller = new AbortController();
      current.current = controller;
      const deadline = setTimeout(() => controller.abort(), 8000);
      try {
        const res = await fetch("/api/observer", {
          signal: controller.signal,
          cache: "no-store",
        });
        if (!res.ok) throw Error();
        const next = observerFrameSchema.parse(await res.json());
        if (!stopped) {
          setFrame(next);
          setError("");
        }
      } catch {
        if (!stopped) {
          setFrame(null);
          setError("Mất kết nối backend hoặc mẫu không hợp lệ.");
        }
      } finally {
        clearTimeout(deadline);
        if (!stopped) timer = setTimeout(poll, 750);
      }
    };
    void poll();
    return () => {
      stopped = true;
      clearTimeout(timer);
      current.current?.abort();
    };
  }, [running]);
  async function exportRecording() {
    try {
      const res = await fetch("/api/observer/recording", {
        cache: "no-store",
        signal: AbortSignal.timeout(8000),
      });
      if (!res.ok) throw Error();
      const data = recordingSchema.parse(await res.json());
      const url = URL.createObjectURL(
        new Blob([JSON.stringify(data, null, 2)], { type: "application/json" }),
      );
      const a = document.createElement("a");
      a.href = url;
      a.download = `ingame-observations-${Date.now()}.json`;
      a.click();
      setTimeout(() => URL.revokeObjectURL(url), 1000);
    } catch {
      setError("Không xuất được bản ghi. Hãy kiểm tra backend.");
    }
  }
  const age = frame
    ? Math.max(0, now - Date.parse(frame.capturedAt))
    : Infinity;
  const fresh = running && age < 5000 && frame?.status === "observed";
  const sample = fresh ? frame.sample : null;
  return (
    <section className="ingame-monitor">
      <h3>In-game / Replay</h3>
      <p>
        Data Dragon {liveCatalog.version}. Chưa xác minh patch replay trùng
        phiên bản asset.
      </p>
      <p>
        Overlay nhận dữ liệu local khi tắt chế độ demo. Có thể bật theo dõi
        trước khi mở replay; công cụ sẽ thử lại khi chưa có nguồn.
      </p>
      <button
        onClick={() => {
          setFrame(null);
          setError("");
          setRunning((v) => !v);
        }}
      >
        {running ? "Dừng theo dõi" : "Bắt đầu theo dõi"}
      </button>
      <button onClick={exportRecording}>Xuất bản ghi đã lọc</button>
      <p role="status">
        {!running
          ? "Đã dừng"
          : !frame
            ? "Đang chờ nguồn…"
            : age >= 5000
              ? "Mẫu đã cũ, dữ liệu đang ẩn"
              : frame.status === "observed"
                ? "Đã nhận mẫu quan sát"
                : "Chưa có dữ liệu in-game/replay"}
      </p>
      {error && <p role="alert">{error}</p>}
      {frame && (
        <p>
          Mẫu {frame.sequence}, epoch {frame.epoch}, {Math.floor(age / 1000)}{" "}
          giây trước, {frame.transition}
        </p>
      )}
      {sample && (
        <>
          <div className="observation-clocks">
            <span>Game: {display(sample.gameTime.value)} s</span>
            <span>Replay: {display(sample.replay.time.value)} s</span>
            <span>
              Pause: {display(sample.replay.paused.value)}, tốc độ:{" "}
              {display(sample.replay.speed.value)}
            </span>
          </div>
          <p>
            {sample.players.length}/10 slot quan sát. Slot là vị trí trong mẫu;
            chưa xác minh đủ roster. N/A nghĩa là thiếu, không thay bằng mock.
          </p>
          <div className="diagnostic-table">
            <table>
              <thead>
                <tr>
                  <th>Slot / đội</th>
                  <th>Cấp, K/D/A, CS</th>
                  <th>Gold / items</th>
                </tr>
              </thead>
              <tbody>
                {sample.players.map((p) => (
                  <tr key={p.slot}>
                    <td>
                      {p.slot + 1}
                      <small>{p.team.value ?? "N/A"}</small>
                      <small>
                        {liveChampion(p.championId.value)?.name ??
                          "Tướng chưa map"}
                      </small>
                    </td>
                    <td>
                      {display(p.level.value)}
                      <small>
                        {display(p.kills.value)}/{display(p.deaths.value)}/
                        {display(p.assists.value)}
                      </small>
                      <small>CS {display(p.cs.value)}</small>
                    </td>
                    <td>
                      {display(p.totalGold.value)}
                      <small>
                        {p.items.value === null
                          ? "N/A"
                          : p.items.value.length
                            ? p.items.value
                                .map(
                                  (id) =>
                                    liveItem(id)?.name ??
                                    `Chưa có asset (${id})`,
                                )
                                .join(", ")
                            : "Trống"}
                      </small>
                    </td>
                  </tr>
                ))}
              </tbody>
            </table>
          </div>
          <p>
            {sample.events.length} sự kiện có loại nhận diện, {" "}
            {frame?.newEvents.length ?? 0} sự kiện mới trong mẫu. Không phát lại
            lịch sử khi kết nối, tua hoặc đổi phiên.
          </p>
          {(sample.limits.playersTruncated ||
            sample.limits.eventsTruncated) && (
            <p>Mẫu vượt giới hạn; bản quan sát đã được giới hạn kích thước.</p>
          )}
        </>
      )}
      <p>
        Replay API có thể cần EnableReplayApi=1. Đồng hồ replay không chứng minh
        có dữ liệu người chơi. Chưa suy ra objective hoặc inhibitor timer.
      </p>
    </section>
  );
}
