import { useCallback, useEffect, useState } from "react";
import { Button } from "../components/ui/button";
import { Input } from "../components/ui/input";

interface RemoteStatus {
  enabled: boolean;
  state: string;
  origin: string;
  groupCode: string;
  code: string;
  shortCode: string;
  publishError: string | null;
  error: string | null;
}

const stateText: Record<string, string> = {
  off: "Đang tắt",
  starting: "Đang mở tunnel…",
  connected: "Đang bật",
  restarting: "Đang kết nối lại…",
  failed: "Lỗi",
};

/**
 * Bảng cho phép player ngoài LAN đẩy dữ liệu về: bật tunnel, hiện code 5 ký tự để player nhập.
 * Code ngắn chỉ là chìa khoá tra cứu: player tự tìm ra URL tunnel hiện tại qua điểm hẹn.
 */
export function RemotePanel() {
  const [status, setStatus] = useState<RemoteStatus | null>(null);
  const [busy, setBusy] = useState(false);
  const [copied, setCopied] = useState(false);

  const reload = useCallback(async () => {
    try {
      setStatus((await (await fetch("/api/valorant/remote")).json()) as RemoteStatus);
    } catch {
      setStatus(null);
    }
  }, []);
  useEffect(() => {
    void reload();
    // Khi đang mở tunnel, URL xuất hiện sau vài giây: làm mới để hiện code.
    const timer = setInterval(() => void reload(), 3000);
    return () => clearInterval(timer);
  }, [reload]);

  const toggle = async (enable: boolean) => {
    setBusy(true);
    try {
      setStatus(
        (await (
          await fetch("/api/valorant/remote", {
            method: "POST",
            headers: { "Content-Type": "application/json" },
            body: JSON.stringify({ enable }),
          })
        ).json()) as RemoteStatus,
      );
    } catch {
      /* giữ trạng thái cũ */
    } finally {
      setBusy(false);
    }
  };

  const copy = async (value: string) => {
    try {
      await navigator.clipboard.writeText(value);
      setCopied(true);
      setTimeout(() => setCopied(false), 1500);
    } catch {
      /* clipboard bị chặn */
    }
  };

  const on = status?.enabled ?? false;
  return (
    <div className="val-remote">
      <div className="val-row">
        <h3>Player đẩy dữ liệu (ngoài LAN)</h3>
        <Button disabled={busy} onClick={() => void toggle(!on)}>
          {on ? "Tắt" : "Bật"}
        </Button>
      </div>
      <p>Trạng thái: {stateText[status?.state ?? "off"] ?? status?.state}</p>
      {status?.error && <p role="alert">{status.error}</p>}
      {on && !status?.shortCode && <p>Đang lấy địa chỉ công khai…</p>}
      {status?.shortCode && (
        <>
          <p>
            Player mở <code>npm run valorant:player</code>, nhập <strong>code 5 ký tự</strong> này:
          </p>
          <div className="val-row">
            <Input
              readOnly
              value={status.shortCode}
              onFocus={(e) => e.currentTarget.select()}
              style={{ fontSize: 22, letterSpacing: "0.3em", textAlign: "center" }}
            />
            <Button onClick={() => void copy(status.shortCode)}>
              {copied ? "Đã chép" : "Chép code"}
            </Button>
          </div>
          <p>
            Code tự phân giải ra địa chỉ tunnel hiện tại nên đổi máy hay khởi động lại tunnel vẫn
            dùng được. Không chứa key; chỉ dùng cho chế độ auxiliary. Chia sẻ riêng cho player tin
            cậy.
          </p>
          {status.publishError && <p role="alert">Đăng code lỗi: {status.publishError}</p>}
        </>
      )}
      {on && (
        <details>
          <summary>Code dài (dự phòng, có key)</summary>
          <p className="val-hint">
            Bản player CLI cũ dán code này khi điểm hẹn không truy cập được. Code chứa key nên chỉ
            gửi riêng tư.
          </p>
          {status?.code ? (
            <div className="val-row">
              <Input readOnly value={status.code} onFocus={(e) => e.currentTarget.select()} />
              <Button onClick={() => void copy(status.code)}>Chép code dài</Button>
            </div>
          ) : (
            <p>Chưa có code dài (cần auth.key trong local/).</p>
          )}
        </details>
      )}
    </div>
  );
}
