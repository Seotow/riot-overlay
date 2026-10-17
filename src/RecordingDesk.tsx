import { NativeSelect } from "./components/ui/native-select";
import { Button } from "./components/ui/button";
import { Input } from "./components/ui/input";
import { useEffect, useState } from "react";
import type { Command, State } from "../shared/schema";
import type { ObserverFrame } from "../shared/observer";
import { providerReportSchema, type ProviderReport } from "../shared/providers";
import { outputUrl, ProductionDesk } from "./Production";
import { ProgramMonitor } from "./ProgramMonitor";

export function recordedClock(value: number | null | undefined) {
  if (value == null || !Number.isFinite(value)) return "--:--";
  return `${Math.floor(value / 60)
    .toString()
    .padStart(2, "0")}:${Math.floor(value % 60)
    .toString()
    .padStart(2, "0")}`;
}
export function RecordingDesk({
  state,
  send,
  connected,
  observation,
}: {
  state: State;
  send: (cmd: Command) => void;
  connected: boolean;
  observation: ObserverFrame | null;
}) {
  const [captures, setCaptures] = useState<
    Array<{ id: string; frames: number; hasState: boolean }>
  >([]);
  const [id, setId] = useState(""),
    [error, setError] = useState("");
  const [recording, setRecording] = useState<ProviderReport["recording"]>();
  const [drag, setDrag] = useState<number | null>(null),
    [pending, setPending] = useState<{ id: string; generation: number } | null>(null);
  async function refresh() {
    try {
      const r = await fetch("/api/captures");
      if (!r.ok) throw Error();
      const records = (await r.json()).filter((c: { hasState: boolean }) => c.hasState);
      setCaptures(records);
      setId((previous) =>
        records.some((c: { id: string }) => c.id === previous) ? previous : (records[0]?.id ?? ""),
      );
      setError("");
    } catch {
      setError("Không đọc được danh sách bản ghi.");
    }
  }
  useEffect(() => {
    void refresh();
  }, []);
  useEffect(() => {
    let stopped = false;
    let timer: ReturnType<typeof setTimeout>;
    const poll = async () => {
      try {
        const r = await fetch("/api/providers");
        if (!r.ok) throw Error();
        const data = providerReportSchema.parse(await r.json());
        if (!stopped) {
          setRecording(data.recording);
          if (data.recording?.id && state.provider === "recording")
            setPending((p) =>
              p?.id === data.recording!.id && (data.recording!.loadGeneration ?? 0) > p.generation
                ? null
                : p,
            );
        }
      } catch {
        if (!stopped) setError("Không đọc được tiến độ bản ghi.");
      } finally {
        if (!stopped) timer = setTimeout(poll, 500);
      }
    };
    void poll();
    return () => {
      stopped = true;
      clearTimeout(timer);
    };
  }, [state.provider]);
  useEffect(() => {
    if (!pending) return;
    const timer = setTimeout(() => {
      setPending(null);
      setError("Chưa xác nhận tải xong bản ghi; kiểm tra thông báo backend hoặc tải lại.");
    }, 60000);
    return () => clearTimeout(timer);
  }, [pending]);
  const ready =
    connected &&
    state.provider === "recording" &&
    !state.mockVisible &&
    !!recording?.id &&
    !pending;
  const seek = (positionMs: number) => {
    if (ready) {
      send({
        type: "captureControl",
        positionMs: Math.max(0, Math.min(recording?.durationMs ?? 0, positionMs)),
      });
      setDrag(null);
    }
  };
  return (
    <section className="recording-desk">
      <div className="section-heading">
        <div>
          <h2>Phát lại trận đấu</h2>
          <p>Chọn bản ghi, tua đến thời điểm cần kiểm tra.</p>
        </div>
      </div>
      <div className="recording-picker">
        <label>
          Bộ dữ liệu thật
          <NativeSelect
            aria-label="Bộ dữ liệu thật"
            value={id}
            onChange={(e) => setId(e.target.value)}
          >
            <option value="">Chọn bản ghi</option>
            {captures.map((c) => (
              <option key={c.id} value={c.id}>
                {c.id} , {c.frames} sample
              </option>
            ))}
          </NativeSelect>
        </label>
        <Button
          disabled={!connected || !id || !!pending}
          onClick={() => {
            setPending({ id, generation: recording?.loadGeneration ?? 0 });
            setError("");
            send({ type: "captureLoad", id });
          }}
        >
          Tải bản ghi
        </Button>
        <Button onClick={refresh}>Làm mới danh sách</Button>
      </div>
      {error && <p role="alert">{error}</p>}
      {pending && <p role="status">Đang tải {pending.id}...</p>}
      <section className="recording-comparison" aria-label="Đối chiếu ảnh ingame">
        <h2>Đối chiếu ảnh ingame</h2>
        <p>
          Tải ảnh chụp trận đấu để đặt dưới overlay. Có thể tải ảnh ngay cả khi chưa chọn bản ghi;
          ảnh không xuất sang OBS.
        </p>
        <ProgramMonitor url={outputUrl} />
      </section>
      {!ready && !pending && (
        <p role="status">
          Chọn và tải bản ghi để bắt đầu. Trang này không tự chuyển nguồn đang phát.
        </p>
      )}
      {ready && recording && (
        <>
          <div className="recording-transport">
            <div className="config-actions">
              <Button
                onClick={() =>
                  send({
                    type: "captureControl",
                    playing: !recording.playing,
                    ...(state.rehearsal ? { positionMs: recording.positionMs } : {}),
                  })
                }
              >
                {recording.playing ? "Tạm dừng bản ghi" : "Phát bản ghi"}
              </Button>
              <Button onClick={() => seek(0)}>Về đầu bản ghi</Button>
              <Button onClick={() => seek(recording.positionMs - 10000)}>−10 giây</Button>
              <Button onClick={() => seek(recording.positionMs + 10000)}>+10 giây</Button>
              <label>
                Tốc độ
                <NativeSelect
                  aria-label="Tốc độ bản ghi"
                  value={recording.speed}
                  onChange={(e) =>
                    send({
                      type: "captureControl",
                      speed: Number(e.target.value),
                    })
                  }
                >
                  {[0.25, 0.5, 1, 2, 4].map((speed) => (
                    <option key={speed} value={speed}>
                      {speed}×
                    </option>
                  ))}
                </NativeSelect>
              </label>
              <strong>
                Timer game:{" "}
                <time data-testid="recorded-game-time">
                  {recordedClock(recording.gameTime ?? observation?.sample?.gameTime.value)}
                </time>
              </strong>
            </div>
            <Input
              className="recording-scrubber"
              aria-label="Tiến độ bản ghi thật"
              aria-valuetext={`Timer game ${recordedClock(recording.gameTime)}`}
              type="range"
              min={0}
              max={Math.max(1, recording.durationMs)}
              step={1}
              value={drag ?? recording.positionMs}
              onChange={(e) => setDrag(Number(e.target.value))}
              onPointerUp={(e) => seek(Number(e.currentTarget.value))}
              onKeyUp={(e) => {
                if (
                  ["ArrowLeft", "ArrowRight", "Home", "End", "PageUp", "PageDown"].includes(e.key)
                )
                  seek(Number(e.currentTarget.value));
              }}
            />
            <div className="recording-time-labels">
              <span>Game đầu: {recordedClock(recording.firstGameTime)}</span>
              <span>
                Đã chạy: {recordedClock((drag ?? recording.positionMs) / 1000)} /{" "}
                {recordedClock(recording.durationMs / 1000)} , {recording.frames} sample
              </span>
              <span>Game cuối: {recordedClock(recording.lastGameTime)}</span>
            </div>
            <p>Kéo thanh tiến độ để chọn thời điểm.</p>
            {state.rehearsal && (
              <Button
                onClick={() =>
                  send({
                    type: "captureControl",
                    positionMs: recording.positionMs,
                    playing: false,
                  })
                }
              >
                Thoát cue thử cũ , dùng dữ liệu tại vị trí này
              </Button>
            )}
          </div>
          <p className="note">
            Đang phát lại {recording.id}. Preview và overlay chính dùng chung bản ghi này; đây không
            phải nguồn live.
          </p>
          <ProductionDesk
            state={state}
            send={send}
            connected={connected}
            observation={observation}
            mode="recording"
          />
          <details className="recording-source-data">
            <summary>Dữ liệu tại thời điểm này</summary>
            <pre
              style={{
                maxHeight: 600,
                overflow: "auto",
                whiteSpace: "pre-wrap",
              }}
            >
              {JSON.stringify(observation?.sample ?? null, null, 2)}
            </pre>
          </details>
        </>
      )}
    </section>
  );
}
