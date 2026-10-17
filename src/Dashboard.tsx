import { NativeSelect } from "./components/ui/native-select";
import { Input } from "./components/ui/input";
import { Card } from "./components/ui/card";
import { Button } from "./components/ui/button";
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
    id: "hud",
    title: "HUD game",
    icon: "UI",
    description: "Preset HUD qua Replay API; không điều khiển camera.",
  },
  {
    id: "postgame",
    title: "Sau trận",
    icon: "PG",
    description: "Cấu hình Riot API, duyệt kết quả và phát postgame.",
  },
  {
    id: "draft",
    title: "Cấm chọn",
    icon: "CS",
    description: "Lượt cấm/chọn, timer và đội hình trước trận.",
  },
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
    description:
      "Phát lại dữ liệu thật, tua timeline và điều khiển như phát sóng.",
  },
  {
    id: "theme",
    title: "Cấu hình trước trận",
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
  const coverage = sourceCoverage(sample);
  const choices = [
    ["riot", "Riot Live Client"],
    ["leaguebroadcast", "LeagueBroadcast"],
    ["league-collector", "Collector có tài khoản"],
    ["collector-accountless", "Collector không tài khoản (thử nghiệm)"],
    ["recording", "Bản ghi"],
  ];
  return (
    <section className="source-panel">
      <div className="section-heading">
        <div>
          <h2>Kết nối trận đấu</h2>
          <p>Chọn nguồn dữ liệu cho Studio và overlay.</p>
        </div>
        <span className="status-pill">
          {sample ? `${sample.players.length}/10 người chơi` : "Chờ dữ liệu"}
        </span>
      </div>
      <div className="source-routing">
        <label>
          Nguồn trận đấu
          <NativeSelect
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
            {choices.map(([value, label]) => (
              <option key={value} value={value}>
                {label}
              </option>
            ))}
          </NativeSelect>
        </label>
        <label className="demo-switch">
          <Input
            type="checkbox"
            checked={state.mockVisible}
            disabled={!connected}
            onChange={(e) =>
              send({ type: "mockVisible", value: e.target.checked })
            }
          />
          Dùng dữ liệu mẫu
        </label>
      </div>
      {state.mockVisible && (
        <p className="note" role="status">
          Dữ liệu mẫu đang được dùng cho cả Studio và OBS.
        </p>
      )}
      {!state.mockVisible &&
        state.provider !== "recording" &&
        report?.safety &&
        !report.safety.allowed && (
          <p className="note" role="alert">
            {report.safety.reason === "player"
              ? "Collector đã bị chặn vì bạn đang là người chơi trong trận. Chỉ dùng khi xem spectator hoặc replay."
              : "Collector đang chờ xác nhận spectator hoặc replay. Chưa thu dữ liệu trận."}
          </p>
        )}
      {state.provider === "recording" && (
        <a className="button secondary" href="/?page=demo">
          Mở phòng thử
        </a>
      )}
      <div className="session-cards">
        <Card>
          <small>Kết nối Studio</small>
          <strong>{connected ? "Sẵn sàng" : "Mất kết nối"}</strong>
        </Card>
        <Card>
          <small>Dữ liệu trận</small>
          <strong>{sample ? "Đang nhận" : "Chưa có"}</strong>
        </Card>
        <Card>
          <small>Cập nhật cuối</small>
          <strong>
            {sample
              ? new Date(sample.capturedAt).toLocaleTimeString("vi-VN")
              : "Chưa có"}
          </strong>
        </Card>
      </div>
      <h3>Dữ liệu khả dụng</h3>
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
                  {row.available}/{row.expected}
                </td>
                <td>{row.sources.join(", ") || "Chưa có"}</td>
              </tr>
            ))}
          </tbody>
        </table>
      </div>
      <details className="diagnostic-details">
        <summary>Thông tin kỹ thuật</summary>
        <pre>
          {JSON.stringify(
            {
              provider: state.provider,
              collector: report?.collector,
              leaguebroadcast: report?.leaguebroadcast,
            },
            null,
            2,
          )}
        </pre>
      </details>
    </section>
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
          <h2>{props.state.theme.tournament}</h2>
          <p>
            {props.state.theme.blueName} gặp {props.state.theme.redName}
          </p>
        </div>
        <Button onClick={() => props.navigate("studio")}>
          Mở bàn phát sóng
        </Button>
      </div>
      <div className="session-cards">
        <Card>
          <small>Nguồn đang dùng</small>
          <strong>
            {props.state.mockVisible
              ? "Dữ liệu mẫu"
              : sourceNames[props.state.provider]}
          </strong>
          <span>{props.connected ? "Đã kết nối" : "Mất kết nối"}</span>
        </Card>
        <Card>
          <small>Người chơi</small>
          <strong>
            {sample?.players.length ?? 0}
            <em> / 10</em>
          </strong>
          <span>{sample ? "Đang nhận dữ liệu" : "Chờ dữ liệu trận"}</span>
        </Card>
        <Card>
          <small>Đầu ra OBS</small>
          <strong>1920 × 1080</strong>
          <a href="/overlay" target="_blank" rel="noreferrer">
            Mở overlay
          </a>
        </Card>
      </div>
      <h3>Thao tác nhanh</h3>
      <div className="module-grid">
        {(
          [
            [
              "theme",
              "Cấu hình trận đấu",
              "Tên đội, tỉ số, logo và giao diện.",
            ],
            ["sources", "Nguồn dữ liệu", "Kết nối và kiểm tra dữ liệu trận."],
            ["demo", "Phòng thử", "Phát lại trận đã lưu."],
          ] as const
        ).map(([id, title, description]) => (
          <Button
            className="module-card"
            key={id}
            onClick={() => props.navigate(id)}
          >
            <b>{title}</b>
            <p>{description}</p>
          </Button>
        ))}
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
        <Card>
          <small>HIỆN TẠI</small>
          <h3>LoL production với LeagueBroadcast</h3>
          <p>
            LeagueBroadcast là nguồn bắt buộc cho telemetry giải đấu đầy đủ.
            Riot local giữ vai trò replay, kiểm thử và chế độ giới hạn.
          </p>
        </Card>
        <Card>
          <small>PHASE TIẾP THEO</small>
          <h3>Sự kiện và scene giải đấu</h3>
          <p>
            Hoàn thiện event contract, trigger, animation và scene theo video
            tham chiếu; giữ provenance và chống phát trùng.
          </p>
        </Card>
        <Card>
          <small>PHASE SAU</small>
          <h3>Giao diện và vận hành</h3>
          <p>
            Đối chiếu HUD, scoreboard, objective, replay, transition và công cụ
            điều khiển production theo audit đã duyệt.
          </p>
        </Card>
        <Card>
          <small>PHASE MỞ RỘNG</small>
          <h3>VALORANT</h3>
          <p>
            Adapter và contract riêng; kiểm tra chính sách Riot, nguồn spectator
            được phép và yêu cầu phê duyệt. Chưa có nguồn hay overlay Valorant
            hoạt động.
          </p>
        </Card>
      </div>
    </section>
  );
}
