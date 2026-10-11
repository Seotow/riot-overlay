import { IngameMonitor } from "./IngameMonitor";
import { useEffect, useState } from "react";
import type { DiagnosticReport } from "../shared/diagnostics";
export function Diagnostics() {
  const [report, setReport] = useState<DiagnosticReport | null>(null);
  const [busy, setBusy] = useState(false);
  const [error, setError] = useState("");
  const [now, setNow] = useState(Date.now());
  useEffect(() => {
    const timer = setInterval(() => setNow(Date.now()), 1000);
    return () => clearInterval(timer);
  }, []);
  async function scan() {
    setBusy(true);
    setError("");
    setReport(null);
    try {
      const res = await fetch("/api/diagnostics", {
        cache: "no-store",
        signal: AbortSignal.timeout(10000),
      });
      if (!res.ok) throw Error();
      setReport(await res.json());
    } catch {
      setError("Không lấy được báo cáo. Kiểm tra backend và thử lại.");
    } finally {
      setBusy(false);
    }
  }
  function download() {
    const url = URL.createObjectURL(
      new Blob([JSON.stringify(report, null, 2)], { type: "application/json" }),
    );
    const a = document.createElement("a");
    a.href = url;
    a.download = `lol-diagnostics-${Date.now()}.json`;
    a.click();
    setTimeout(() => URL.revokeObjectURL(url), 1000);
  }
  return (
    <section className="diagnostics">
      <IngameMonitor />
      <div className="divider" />
      <h3>Chẩn đoán nguồn LoL</h3>
      <p>
        Kiểm tra chỉ đọc theo yêu cầu. Overlay dùng nguồn quan sát khi bỏ chọn
        dữ liệu demo. Báo cáo chỉ chứa các trường đã lọc, không chứa credentials
        hoặc tên tài khoản.
      </p>
      <p>
        Ưu tiên mở replay, chạy, pause, rồi tua tiến hoặc lùi. Bấm kiểm tra và xuất
        một báo cáo ở từng bước.
      </p>
      <button disabled={busy} onClick={scan}>
        {busy ? "Đang kiểm tra…" : "Kiểm tra nguồn"}
      </button>
      {report && <button onClick={download}>Xuất báo cáo JSON</button>}
      {error && <p role="alert">{error}</p>}
      {report && (
        <>
          <p role="status">
            Mẫu lúc {new Date(report.capturedAt).toLocaleTimeString()}, {" "}
            {Math.max(
              0,
              Math.floor((now - Date.parse(report.capturedAt)) / 1000),
            )}{" "}
            giây trước, phase: {report.phase ?? "Chưa xác định"}. Đây là mẫu
            tại thời điểm kiểm tra, không phải trạng thái live liên tục.
          </p>
          {report.probes.map((p) => (
            <div className="diagnostic-probe" key={p.id}>
              <b>
                {p.source}: {p.id}
              </b>
              <span>
                {p.status} {p.httpStatus ?? ""}, {" "}
                {p.latencyMs === null ? "N/A" : `${p.latencyMs} ms`}
              </span>
            </div>
          ))}
          <p>
            LCU “not-configured”: chưa tìm thấy lockfile hợp lệ. Có thể đặt biến
            LOL_LOCKFILE ở backend theo hướng dẫn. Thời gian phản hồi HTTP không
            phải độ trễ spectator.
          </p>
          <div className="diagnostic-table">
            <table>
              <thead>
                <tr>
                  <th>Field / nguồn</th>
                  <th>Kết quả</th>
                </tr>
              </thead>
              <tbody>
                {report.fields.map((f) => (
                  <tr key={f.field}>
                    <td>
                      <b>{f.field}</b>
                      <small>
                        {f.stage}, {f.source}, {f.type}
                      </small>
                      <small>{f.path}</small>
                    </td>
                    <td>
                      {
                        {
                          observed: "Đã quan sát",
                          missing: "Không có trong mẫu",
                          unverified: "Chưa kiểm chứng",
                        }[f.availability]
                      }
                      <small>{JSON.stringify(f.sample)}</small>
                      <small>{f.limitation}</small>
                    </td>
                  </tr>
                ))}
              </tbody>
            </table>
          </div>
        </>
      )}
    </section>
  );
}
