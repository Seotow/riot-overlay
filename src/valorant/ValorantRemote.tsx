import { useCallback, useEffect, useState } from "react";
import { Button } from "../components/ui/button";
import { Input } from "../components/ui/input";

interface RemoteStatus {
  enabled: boolean;
  state: string;
  origin: string;
  groupCode: string;
  code: string;
  error: string | null;
}

const stateText: Record<string, string> = {
  off: "Đang tắt",
  starting: "Đang mở tunnel…",
  connected: "Đang bật",
  restarting: "Đang kết nối lại…",
  failed: "Lỗi",
};

/** Bảng cho phép player ngoài LAN đẩy dữ liệu về: bật tunnel, hiện code ngắn để player nhập. */
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

  const copy = async () => {
    if (!status?.code) return;
    try {
      await navigator.clipboard.writeText(status.code);
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
      {on && !status?.code && <p>Đang lấy địa chỉ công khai…</p>}
      {status?.code && (
        <>
          <p>
            Gửi code này cho từng player (họ dán vào bản player). Code chứa key, chỉ gửi riêng tư.
          </p>
          <div className="val-row">
            <Input readOnly value={status.code} onFocus={(e) => e.currentTarget.select()} />
            <Button onClick={() => void copy()}>{copied ? "Đã chép" : "Chép code"}</Button>
          </div>
        </>
      )}
    </div>
  );
}
