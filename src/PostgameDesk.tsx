import { Button } from "./components/ui/button";
import { Input } from "./components/ui/input";
import { useState } from "react";
import { postgameSampleSchema, samplePostgame } from "../shared/postgame";
import type { Command, State } from "../shared/schema";
import { PostgamePanel } from "./PostgamePanel";

export function PostgameDesk({
  state,
  send,
  connected,
}: {
  state: State;
  send: (c: Command) => void;
  connected: boolean;
}) {
  const [message, setMessage] = useState("");
  const data = state.postgame;
  const update = (value: ReturnType<typeof samplePostgame> | null) => {
    send({ type: "mockVisible", value: false });
    send({ type: "postgameState", value });
    setMessage("");
  };
  // Locked while the data source is being decided: nothing here can reach the overlay.
  if (state.postgameLocked)
    return (
      <section className="postgame-desk">
        <div className="section-heading">
          <div>
            <h2>Kết quả sau trận</h2>
            <p>ĐANG KHÓA (RIOT_OVERLAY_POSTGAME=0).</p>
          </div>
        </div>
        <p role="status">
          Postgame đang bị khóa nên overlay postgame trống và các thao tác nhập, nạp, phát bị khóa.
          Máy spectator không có màn kết thúc trận, lịch sử trận tùy chọn hay EOG. Hướng đã chốt là
          replay .rofl; chi tiết: docs/POSTGAME_DATA_FINDINGS.md.
        </p>
        <p>
          Khóa do backend được khởi động với <code>RIOT_OVERLAY_POSTGAME=0</code>; bỏ biến này để
          mở.
        </p>
      </section>
    );
  return (
    <section className="postgame-desk">
      <div className="section-heading">
        <div>
          <h2>Kết quả sau trận</h2>
          <p>
            {data?.source === "riot"
              ? `RIOT , ${data.evidence.matchId} , ${data.evidence.isFinal ? "kết quả sau trận" : "dữ liệu chưa đầy đủ"}`
              : "DỮ LIỆU MẪU , Không tự kích hoạt khi trận kết thúc."}
          </p>
        </div>
        <a
          className="button secondary"
          href="/overlay?scene=postgame"
          target="_blank"
          rel="noreferrer"
        >
          Mở overlay postgame ↗
        </a>
      </div>
      <PostgamePanel state={state} connected={connected} />
      <h3>Xem trước</h3>
      <div className="program-monitor">
        <iframe title="Preview postgame OBS" src="/overlay?scene=postgame" />
      </div>
      <fieldset disabled={!connected}>
        <div className="config-actions">
          <Button onClick={() => update(samplePostgame())}>Nạp bộ mẫu theo ảnh</Button>
          <Button
            className="secondary"
            disabled={!data || data.source !== "sample"}
            onClick={() =>
              data?.source === "sample" &&
              update({
                ...data,
                winner: data.winner === "red" ? "blue" : "red",
              })
            }
          >
            Đổi đội thắng
          </Button>
          <Button
            className="secondary"
            disabled={!data || data.source !== "sample"}
            onClick={() => {
              if (!data || data.source !== "sample") return;
              const next = structuredClone(data);
              next.winner = null;
              next.teams[0].elders = null;
              next.teams[1].players[2].damage = null;
              next.goldHistory[7].delta = null;
              update(next);
            }}
          >
            Thử thiếu dữ liệu
          </Button>
          <Button className="secondary" onClick={() => update(null)}>
            Xóa bộ mẫu
          </Button>
        </div>
        <details className="postgame-data">
          <summary>Dữ liệu JSON , xuất kết quả / nhập bộ mẫu</summary>
          <p>
            Đội xanh trước, đội đỏ sau. Người chơi theo TOP → JUNGLE → MID → BOT → SUPPORT. Vàng
            chênh lệch = xanh − đỏ. Giá trị chưa có dùng null.
          </p>
          <div className="config-actions">
            <Button
              disabled={!data}
              onClick={() => {
                if (!data) return;
                const url = URL.createObjectURL(
                  new Blob([JSON.stringify(data, null, 2)], {
                    type: "application/json",
                  }),
                );
                const a = document.createElement("a");
                a.href = url;
                a.download = data.source === "riot" ? "postgame-riot.json" : "postgame-sample.json";
                a.click();
                URL.revokeObjectURL(url);
              }}
            >
              {data?.source === "riot" ? "Xuất JSON kết quả" : "Xuất JSON mẫu"}
            </Button>
            <label className="button secondary">
              Nhập JSON mẫu
              <Input
                aria-label="Nhập JSON postgame"
                type="file"
                accept=".json,application/json"
                onChange={async (e) => {
                  const file = e.target.files?.[0];
                  e.target.value = "";
                  if (!file) return;
                  try {
                    if (file.size > 500000) throw Error("File vượt giới hạn 500 KB");
                    update(postgameSampleSchema.parse(JSON.parse(await file.text())));
                  } catch {
                    setMessage(
                      "JSON không hợp lệ: kiểm tra version, source sample, tướng, số liệu và thứ tự thời gian. Giới hạn 500 KB.",
                    );
                  }
                }}
              />
            </label>
          </div>
          <pre>{data ? JSON.stringify(data, null, 2) : "Chưa nạp bộ mẫu."}</pre>
        </details>
      </fieldset>
      {message && <p role="alert">{message}</p>}
    </section>
  );
}
