import React, { useEffect, useState } from "react";
import {
  providerReportSchema,
  sourceNames,
  type ProviderReport,
} from "../shared/providers";
import { liveCatalog } from "../shared/live-assets";
import type { ObserverFrame } from "../shared/observer";
import { sourceCoverage } from "../shared/coverage";
import {
  researchBoundary,
  sourceCandidates,
} from "../shared/source-capabilities";
import type { Command, State } from "../shared/schema";

export const studioModules = [
  {
    id: "overview",
    title: "Tổng quan",
    icon: "01",
    description: "Tình trạng phiên và các module sản xuất.",
  },
  {
    id: "sources",
    title: "Kết nối dữ liệu",
    icon: "02",
    description: "Chọn nguồn trận và kiểm tra dữ liệu đang nhận.",
  },
  {
    id: "studio",
    title: "Điều khiển phát sóng",
    icon: "03",
    description: "Xem trước, chuyển cảnh và lấy URL cho OBS.",
  },
  {
    id: "demo",
    title: "Phòng thử",
    icon: "04",
    description: "Phát snapshot thật đã lưu và thử các biến thể UI có nhãn.",
  },
  {
    id: "theme",
    title: "Giao diện & đội",
    icon: "05",
    description: "Tên đội, màu sắc, kiểu chữ và thành phần hiển thị.",
  },
  {
    id: "roadmap",
    title: "Kế hoạch",
    icon: "06",
    description: "Các scene, event và nguồn dữ liệu sẽ triển khai tiếp.",
  },
] as const;
export type StudioPage = (typeof studioModules)[number]["id"];
export function useProviders(enabled: boolean) {
  const [report, setReport] = useState<ProviderReport | null>(null);
  useEffect(() => {
    if (!enabled) return;
    let stopped = false;
    let timer: ReturnType<typeof setTimeout>;
    const controller = new AbortController();
    const poll = async () => {
      try {
        const res = await fetch("/api/providers", {
          signal: controller.signal,
        });
        if (!res.ok) throw Error();
        const parsed = providerReportSchema.parse(await res.json());
        if (!stopped) setReport(parsed);
      } catch {
        if (!stopped) setReport(null);
      } finally {
        if (!stopped) timer = setTimeout(poll, 2000);
      }
    };
    void poll();
    return () => {
      stopped = true;
      clearTimeout(timer);
      controller.abort();
    };
  }, [enabled]);
  return report;
}
type Props = {
  state: State;
  observation: ObserverFrame | null;
  report: ProviderReport | null;
  connected: boolean;
  send: (cmd: Command) => void;
};
const statuses: Record<string, string> = {
  offline: "Chưa kết nối",
  connecting: "Đang kết nối",
  waiting: "Đã kết nối, chưa thấy trận",
  loading: "Ứng dụng đang nạp hoặc chưa nhận trận",
  receiving: "Đang nhận dữ liệu",
  stale: "Dữ liệu đã cũ",
  restricted: "Cần đăng nhập hoặc quyền truy cập",
  mock: "Nguồn đang phát demo",
  invalid: "Chưa có frame hợp lệ",
};
const candidateStages = {
  active: "Đang dùng",
  conditional: "Có điều kiện",
  planned: "Đang nghiên cứu",
  external: "Cần cấp quyền",
} as const;
function useFresh(frame: ObserverFrame | null) {
  const [now, setNow] = useState(Date.now());
  useEffect(() => {
    const timer = setInterval(() => setNow(Date.now()), 1000);
    return () => clearInterval(timer);
  }, []);
  return frame?.status === "observed" &&
    frame.sample &&
    now - Date.parse(frame.sample.capturedAt) < 5000
    ? frame.sample
    : null;
}
export function SourcePanel({
  state,
  observation,
  report,
  connected,
  send,
}: Props) {
  const sample = useFresh(connected ? observation : null);
  const bb = connected ? report?.leaguebroadcast : null;
  const coverage = sourceCoverage(sample);
  return (
    <section className="source-panel">
      <div className="dashboard-heading">
        <div>
          <small>DATA ROUTING</small>
          <h2>Nguồn cấp cho chương trình</h2>
        </div>
        <span className={`status-pill ${state.mockVisible ? "amber" : ""}`}>
          {state.mockVisible ? "DEMO ĐANG PHÁT" : sourceNames[state.provider]}
        </span>
      </div>
      <div className="source-routing">
        <label>
          Nguồn trận đấu
          <select
            aria-label="Nguồn trận đấu"
            value={state.provider}
            disabled={!connected}
            onChange={(e) =>
              send({
                type: "provider",
                value: e.target.value as State["provider"],
              })
            }
          >
            <option value="riot">Riot local: dữ liệu giới hạn</option>
            <option value="leaguebroadcast">
              LeagueBroadcast: production đầy đủ
            </option>
            <option value="recording">Bản ghi offline</option>
          </select>
        </label>
        <label className="demo-switch">
          <input
            type="checkbox"
            checked={state.mockVisible}
            disabled={!connected}
            onChange={(e) =>
              send({ type: "mockVisible", value: e.target.checked })
            }
          />
          Dùng dữ liệu demo<span>Áp dụng cho Studio và OBS</span>
        </label>
      </div>
      <CapturePanel
        connected={connected}
        state={state}
        report={report}
        send={send}
      />
      <div className="source-cards">
        <article>
          <span className="module-icon">R</span>
          <h3>Riot local</h3>
          <p>
            Replay và kiểm thử giới hạn
            <br />
            Thiếu telemetry production quan trọng
          </p>
          <small>
            {state.provider === "riot" && sample
              ? "Đang cấp frame quan sát giới hạn"
              : "Dùng khi replay hoặc LB chưa sẵn sàng"}
          </small>
          <code>127.0.0.1:2999</code>
        </article>
        <article>
          <span className="module-icon">B</span>
          <h3>LeagueBroadcast</h3>
          <p>
            {bb
              ? statuses[bb.status]
              : "Nguồn production bắt buộc chưa được kiểm tra"}
          </p>
          <small>
            {bb
              ? `${bb.players}/10 người, ${bb.frames} frame hợp lệ`
              : "Cần cho gold, HP, resource, rune và objective đầy đủ"}
          </small>
          {bb && (
            <small>
              Trạng thái game: {bb.gameStatus}; telemetry:{" "}
              {bb.telemetry
                ? `${bb.telemetry.status}, ${bb.telemetry.updatesPerSecond}/s`
                : "chưa có"}
            </small>
          )}
          {bb?.assetCache && (
            <small>
              Asset {bb.assetCache.version ?? ""}: {bb.assetCache.state},{" "}
              {bb.assetCache.progressPercent == null
                ? "chưa rõ"
                : `${bb.assetCache.progressPercent.toFixed(1)}%`}
            </small>
          )}
          <code>127.0.0.1:58869 /ws/in</code>
        </article>
        <article>
          <span className="module-icon">D</span>
          <h3>Data Dragon</h3>
          <p>Icon và tên, lưu trên máy</p>
          <small>Live {liveCatalog.version} / demo 15.20.1</small>
          <code>Không cung cấp chỉ số realtime</code>
        </article>
      </div>
      <p className="module-note">
        {state.provider === "riot"
          ? "Chế độ giới hạn: phù hợp replay và kiểm thử, không đạt bộ dữ liệu giải đấu đầy đủ. Production cần LeagueBroadcast cho vàng, HP, năng lượng, rune và objective."
          : state.provider === "recording"
            ? "Đang dùng dữ liệu lịch sử. Bản ghi không phản ánh trận đang chạy; nguồn trong bảng là nguồn đã tạo bản ghi."
            : "Nguồn production đầy đủ. LeagueBroadcast, quyền tài khoản và custom spectator được hỗ trợ là bắt buộc; mất kết nối không tự chuyển nguồn."}
      </p>
      <div className="dashboard-heading">
        <h3>Dữ liệu đang vào overlay</h3>
        <small>
          {state.mockVisible
            ? "Fixture demo"
            : sample
              ? `Cập nhật ${new Date(sample.capturedAt).toLocaleTimeString("vi-VN")}`
              : "Chờ nguồn, số liệu cũ đã ẩn"}
        </small>
      </div>
      <div className="table-scroll">
        <table className="provenance-table">
          <thead>
            <tr>
              <th>Thông tin</th>
              <th>Khả dụng</th>
              <th>Nguồn</th>
            </tr>
          </thead>
          <tbody>
            {coverage.map((row) => (
              <tr key={row.id}>
                <td>{row.title}</td>
                <td>
                  {state.mockVisible
                    ? "Demo"
                    : `${row.available}/${row.expected}`}
                </td>
                <td>
                  {state.mockVisible ? (
                    "Demo nội bộ"
                  ) : (
                    <>
                      {row.sources.join(", ") || "Chưa có dữ liệu"}
                      {row.note && (
                        <small className="coverage-note">{row.note}</small>
                      )}
                    </>
                  )}
                </td>
              </tr>
            ))}
            <tr>
              <td>Thời gian trận</td>
              <td>
                {state.mockVisible
                  ? "Demo"
                  : sample?.gameTime.value != null
                    ? `${sample.gameTime.value.toFixed(1)} s`
                    : "N/A"}
              </td>
              <td>
                {state.mockVisible
                  ? "Demo nội bộ"
                  : sample?.gameTime.value != null
                    ? sourceNames[sample.gameTime.source]
                    : "Chưa có dữ liệu"}
              </td>
            </tr>
            <tr>
              <td>Pause / tốc độ replay</td>
              <td>
                {state.mockVisible
                  ? "Demo"
                  : sample?.replay.speed.value != null
                    ? `${sample.replay.speed.value}×`
                    : "N/A"}
              </td>
              <td>
                {state.mockVisible
                  ? "Demo nội bộ"
                  : sample?.replay.speed.value != null
                    ? sourceNames[sample.replay.speed.source]
                    : "Chưa có dữ liệu"}
              </td>
            </tr>
            <tr>
              <td>Tên đội / nhận diện</td>
              <td>Cấu hình thủ công</td>
              <td>Theme trên máy</td>
            </tr>
          </tbody>
        </table>
      </div>
      <div className="dashboard-heading source-research-heading">
        <div>
          <small>SOURCE RESEARCH</small>
          <h3>Nguồn bổ sung có thể triển khai</h3>
        </div>
        <small>Không tự động ghép dữ liệu chưa xác minh</small>
      </div>
      <div className="table-scroll">
        <table className="provenance-table source-candidate-table">
          <thead>
            <tr>
              <th>Nguồn</th>
              <th>Trạng thái</th>
              <th>Đường lấy dữ liệu</th>
              <th>Độ phủ thực tế</th>
              <th>Điều kiện</th>
            </tr>
          </thead>
          <tbody>
            {sourceCandidates.map((candidate) => (
              <tr key={candidate.id}>
                <td>
                  <strong>{candidate.name}</strong>
                </td>
                <td>
                  <span className={`source-stage ${candidate.stage}`}>
                    {candidateStages[candidate.stage]}
                  </span>
                </td>
                <td>{candidate.route}</td>
                <td>{candidate.coverage}</td>
                <td>{candidate.requirement}</td>
              </tr>
            ))}
          </tbody>
        </table>
      </div>
      <div className="research-boundary">
        <div>
          <small>CÓ THỂ NGHIÊN CỨU</small>
          {researchBoundary.allowed.map((item) => (
            <p key={item}>{item}</p>
          ))}
        </div>
        <div>
          <small>LOẠI KHỎI PHƯƠNG ÁN</small>
          {researchBoundary.excluded.map((item) => (
            <p key={item}>{item}</p>
          ))}
        </div>
      </div>
    </section>
  );
}
function CapturePanel({
  connected,
  state,
  report,
  send,
}: Pick<Props, "connected" | "state" | "report" | "send">) {
  const [captures, setCaptures] = useState<
    { id: string; frames: number; hasState: boolean }[]
  >([]);
  const [selected, setSelected] = useState("");
  const [error, setError] = useState("");
  const refresh = async () => {
    try {
      const response = await fetch("/api/captures");
      if (!response.ok) throw Error();
      const data = await response.json();
      setCaptures(data);
      setSelected(
        (previous) =>
          previous ||
          data.find((r: { hasState: boolean }) => r.hasState)?.id ||
          "",
      );
      setError("");
    } catch {
      setError("Chưa đọc được danh sách bản ghi.");
    }
  };
  useEffect(() => {
    if (connected) void refresh();
  }, [connected]);
  const replay = report?.recording;
  return (
    <details className="capture-panel" open={state.provider === "recording"}>
      <summary>Kiểm thử bằng bản ghi đã lưu</summary>
      <p>
        Không cần game hoặc LeagueBroadcast. Bản ghi được mở ở trạng thái tạm
        dừng.
      </p>
      <div className="capture-actions">
        <select
          aria-label="Bản ghi"
          value={selected}
          onChange={(e) => setSelected(e.target.value)}
          disabled={!connected}
        >
          <option value="">Chọn bản ghi</option>
          {captures.map((c) => (
            <option key={c.id} value={c.id} disabled={!c.hasState}>
              {c.id} ({c.frames} frame{c.hasState ? "" : ", không có state"})
            </option>
          ))}
        </select>
        <button
          disabled={!connected || !selected}
          onClick={() => send({ type: "captureLoad", id: selected })}
        >
          Mở bản ghi
        </button>
        <button disabled={!connected} onClick={() => void refresh()}>
          Tải lại danh sách
        </button>
      </div>
      {error && <p role="alert">{error}</p>}
      {state.provider === "recording" && replay?.id && (
        <div className="capture-controls">
          <p>
            {replay.id} / {replay.frames} frame /{" "}
            {(replay.positionMs / 1000).toFixed(1)} trên{" "}
            {(replay.durationMs / 1000).toFixed(1)} giây
          </p>
          <div className="capture-actions">
            <button
              disabled={!connected}
              onClick={() =>
                send({ type: "captureControl", playing: !replay.playing })
              }
            >
              {replay.playing ? "Tạm dừng bản ghi" : "Phát bản ghi"}
            </button>
            <button
              disabled={!connected}
              onClick={() =>
                send({ type: "captureControl", positionMs: 0, playing: false })
              }
            >
              Về đầu
            </button>
            <select
              aria-label="Tốc độ bản ghi"
              value={replay.speed}
              disabled={!connected}
              onChange={(e) =>
                send({ type: "captureControl", speed: Number(e.target.value) })
              }
            >
              {[0.25, 0.5, 1, 2, 4].map((speed) => (
                <option key={speed} value={speed}>
                  {speed}x
                </option>
              ))}
            </select>
          </div>
          <input
            aria-label="Vị trí bản ghi"
            type="range"
            min={0}
            max={replay.durationMs}
            step={100}
            value={replay.positionMs}
            disabled={!connected}
            onChange={(e) =>
              send({
                type: "captureControl",
                positionMs: Number(e.target.value),
                playing: false,
              })
            }
          />
        </div>
      )}
    </details>
  );
}
export function Dashboard(
  props: Props & { navigate: (page: StudioPage) => void },
) {
  const sample = useFresh(props.connected ? props.observation : null);
  return (
    <div className="dashboard">
      <div className="dashboard-heading">
        <div>
          <small>PRODUCTION WORKSPACE</small>
          <h2>Điều hành phiên phát sóng</h2>
          <p>Kết nối nguồn, kiểm tra dữ liệu và đưa đồ họa lên sóng.</p>
        </div>
        <button onClick={() => props.navigate("studio")}>Mở Studio</button>
      </div>
      <div className="session-cards">
        <article>
          <small>ĐẦU RA HIỆN TẠI</small>
          <strong>
            {props.state.mockVisible
              ? "Demo"
              : sourceNames[props.state.provider]}
          </strong>
          <span>
            {props.connected ? "Backend đã kết nối" : "Backend mất kết nối"}
          </span>
        </article>
        <article>
          <small>NGƯỜI CHƠI QUAN SÁT</small>
          <strong>
            {sample?.players.length ?? 0}
            <em> / 10</em>
          </strong>
          <span>{sample ? "Frame còn mới" : "Chưa có frame hợp lệ"}</span>
        </article>
        <article>
          <small>OBS BROWSER SOURCE</small>
          <strong>1920 × 1080</strong>
          <a href="/overlay" target="_blank" rel="noreferrer">
            Mở đầu ra trong suốt
          </a>
        </article>
      </div>
      <h3>Module sản xuất</h3>
      <div className="module-grid">
        {studioModules
          .filter((m) => m.id !== "overview")
          .map((m) => (
            <button
              key={m.id}
              className="module-card"
              onClick={() => props.navigate(m.id)}
            >
              <span className="module-icon">{m.icon}</span>
              <b>{m.title}</b>
              <p>{m.description}</p>
              <small>Mở module</small>
            </button>
          ))}
      </div>
      <div className="quick-controls">
        <label>
          <input
            type="checkbox"
            disabled={!props.connected}
            checked={props.state.mockVisible}
            onChange={(e) =>
              props.send({ type: "mockVisible", value: e.target.checked })
            }
          />{" "}
          Bật dữ liệu demo cho Studio + OBS
        </label>
        <span>
          {props.state.mockVisible
            ? "Đang dùng fixture thử nghiệm"
            : "Đang dùng nguồn trận đã chọn"}
        </span>
      </div>
    </div>
  );
}
export function Roadmap({ valorant = false }: { valorant?: boolean }) {
  return (
    <section className="dashboard roadmap">
      <small>
        {valorant ? "GAME MODULE, CHƯA TRIỂN KHAI" : "DEVELOPMENT ROADMAP"}
      </small>
      <h2>{valorant ? "VALORANT" : "Lộ trình mở rộng"}</h2>
      <p>
        {valorant
          ? "Khu vực dành riêng cho adapter, schema trận và overlay Valorant. Chuyển workspace không thay đổi đầu ra LoL đang phát."
          : "Các module dùng chung nằm ở Studio; dữ liệu và renderer được triển khai riêng theo từng game."}
      </p>
      <div className="module-grid">
        <article>
          <small>HIỆN TẠI</small>
          <h3>LoL production với LeagueBroadcast</h3>
          <p>
            LeagueBroadcast là nguồn bắt buộc cho telemetry giải đấu đầy đủ.
            Riot local giữ vai trò replay, kiểm thử và chế độ giới hạn.
          </p>
        </article>
        <article>
          <small>PHASE TIẾP THEO</small>
          <h3>Sự kiện và scene giải đấu</h3>
          <p>
            Hoàn thiện event contract, trigger, animation và scene theo video
            tham chiếu; giữ provenance và chống phát trùng.
          </p>
        </article>
        <article>
          <small>PHASE SAU</small>
          <h3>Giao diện và vận hành</h3>
          <p>
            Đối chiếu HUD, scoreboard, objective, replay, transition và công cụ
            điều khiển production theo audit đã duyệt.
          </p>
        </article>
        <article>
          <small>PHASE MỞ RỘNG</small>
          <h3>VALORANT</h3>
          <p>
            Adapter và contract riêng; kiểm tra chính sách Riot, nguồn spectator
            được phép và yêu cầu phê duyệt. Chưa có nguồn hay overlay Valorant
            hoạt động.
          </p>
        </article>
      </div>
    </section>
  );
}
