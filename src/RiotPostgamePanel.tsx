import { NativeSelect } from "./components/ui/native-select";
import { Input } from "./components/ui/input";
import { Button } from "./components/ui/button";
import { useEffect, useState } from "react";
import type { State } from "../shared/schema";
import { riotPostgameSchema, type RiotPostgameState } from "../shared/postgame";
import { Surface } from "./overlay/Surface";
type Status = {
  configured: boolean;
  mode: "standard" | "rso";
  storage: string;
  retryAfter: number;
  candidate: RiotPostgameState | null;
};
const errors: Record<string, string> = {
  "no-credential": "Chưa có key/token. Nhập và lưu vào phiên backend trước.",
  "upstream-401": "Riot trả 401: key hoặc token không hợp lệ/hết hạn.",
  "upstream-403":
    "Riot trả 403: key không có quyền hoặc chưa được chấp nhận. Không tự chuyển sang nguồn khác.",
  "upstream-404":
    "Riot trả 404: kiểm tra match ID, routing hoặc phạm vi truy cập custom. Key Standard không thay token RSO.",
  "rate-limit": "Đang bị giới hạn request. Chờ thời gian Riot yêu cầu rồi thử lại; không tự retry.",
  busy: "Backend đang tải một trận. Chờ request hiện tại hoàn tất.",
  cancelled: "Đã hủy tải vì cấu hình key thay đổi.",
  network: "Không kết nối được Riot hoặc request quá thời gian. Key không được ghi vào lỗi.",
  "invalid-data": "Dữ liệu không hợp lệ: cần trận VN2, đủ 10 người hai đội và đúng match ID.",
  "no-candidate": "Chưa có bản dữ liệu đã tải khớp match ID để phát.",
  "no-file": "Không đọc được file EOG đã lưu (đã bị xóa hoặc quá lớn).",
  "body-too-large": "File quá lớn (tối đa 1 MB). Dùng file eog-stats-block đã lọc từ probe.",
};
export function RiotPostgamePanel({ state, connected }: { state: State; connected: boolean }) {
  const [status, setStatus] = useState<Status | null>(null);
  const [mode, setMode] = useState<"standard" | "rso">("standard");
  const [secret, setSecret] = useState("");
  const [matchId, setMatchId] = useState("");
  const [gameNumber, setGameNumber] = useState(1);
  const [busy, setBusy] = useState(false);
  const [notice, setNotice] = useState("");
  const [showCandidate, setShowCandidate] = useState(false);
  const [files, setFiles] = useState<{ name: string; size: number; modified: string }[]>([]);
  const [fileName, setFileName] = useState("");
  const [reviewed, setReviewed] = useState(false);
  useEffect(() => {
    const controller = new AbortController();
    fetch("/api/riot-postgame/status", {
      cache: "no-store",
      signal: controller.signal,
    })
      .then((r) => {
        if (!r.ok) throw Error();
        return r.json();
      })
      .then((s: Status) => {
        setStatus(s);
        setMode(s.mode);
      })
      .catch(() => {
        if (!controller.signal.aborted)
          setNotice("Chưa đọc được cấu hình Riot. Khởi động lại backend sau khi cập nhật source.");
      });
    return () => controller.abort();
  }, []);
  // A block staged by the server (this machine's client, end of match) shows up without a reload,
  // and the list of blocks saved by the probe stays current.
  useEffect(() => {
    const refresh = () => {
      if (document.hidden) return;
      fetch("/api/riot-postgame/status", { cache: "no-store" })
        .then((r) => (r.ok ? r.json() : null))
        .then((s: Status | null) => {
          if (!s) return;
          setStatus((current) => {
            if (
              !s.candidate ||
              current?.candidate?.evidence.matchId === s.candidate.evidence.matchId
            )
              return current ?? s;
            setShowCandidate(true);
            setReviewed(false);
            setNotice("Có dữ liệu cuối trận mới từ client, đang chờ duyệt. Chưa lên overlay.");
            return { ...s, candidate: riotPostgameSchema.parse(s.candidate) };
          });
        })
        .catch(() => {});
      fetch("/api/riot-postgame/eog-files", { cache: "no-store" })
        .then((r) => (r.ok ? r.json() : null))
        .then((r) => r && setFiles(r.files ?? []))
        .catch(() => {});
    };
    refresh();
    const timer = setInterval(refresh, 4000);
    return () => clearInterval(timer);
  }, []);
  const action = async (route: string, value: unknown) => {
    setBusy(true);
    setNotice("");
    try {
      const response = await fetch(`/api/riot-postgame/${route}`, {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify(value),
      });
      const result = await response.json();
      if (!response.ok) {
        setNotice(
          `${errors[result.error] ?? "Request thất bại; chưa thay dữ liệu đang phát."}${result.retryAfter ? ` Thử lại sau ${result.retryAfter}s.` : ""}`,
        );
        return;
      }
      if (route === "publish")
        setNotice(`Đã đưa ${result.matchId} lên postgame. Studio/OBS nhận cùng snapshot.`);
      else {
        if (result.candidate) result.candidate = riotPostgameSchema.parse(result.candidate);
        setStatus(result);
        setReviewed(false);
        if (route === "credential") {
          setSecret("");
          setShowCandidate(false);
          setNotice(
            value && typeof value === "object" && "clear" in value
              ? "Đã xóa key/token và dữ liệu chờ tải khỏi RAM backend. Kết quả đang phát không bị xóa."
              : "Đã nhận key/token trong RAM. Chưa kiểm chứng quyền; tải một match để kiểm tra.",
          );
        } else {
          setShowCandidate(true);
          setNotice(
            route === "import-eog"
              ? "Đã nhập file EOG vào vùng duyệt. Chưa thay overlay đang phát."
              : "Đã tải dữ liệu Riot vào vùng duyệt. Chưa thay overlay đang phát.",
          );
        }
      }
    } catch {
      setNotice(
        "Backend không phản hồi hoặc dữ liệu không đúng contract. Chưa thay overlay đang phát.",
      );
    } finally {
      setBusy(false);
    }
  };
  const importEog = async (file: File | undefined) => {
    if (!file) return;
    if (file.size > 1_048_576) {
      setNotice(errors["body-too-large"]);
      return;
    }
    try {
      const payload = JSON.parse(await file.text());
      await action("import-eog", { gameNumber, payload });
    } catch {
      setNotice("File không phải JSON hợp lệ. Chưa thay dữ liệu đang phát.");
    }
  };
  const candidate = status?.candidate;
  const bots = candidate
    ? candidate.teams.reduce((n, t) => n + t.players.filter((p) => p.bot).length, 0)
    : 0;
  return (
    <section className="riot-postgame-panel">
      <div className="section-heading">
        <div>
          <h3>Riot API</h3>
          <p>Nhập API key hoặc RSO token để tải kết quả trận.</p>
        </div>
        <span className="riot-key-status">
          {status?.configured ? "Đã cấu hình" : "Chưa cấu hình"}
        </span>
      </div>
      <fieldset disabled={!connected || busy}>
        <h4>Nhập từ file EOG (LCU)</h4>
        <p>
          Chọn file <code>eog-stats-block</code> đã lọc từ probe (<code>npm run probe:eog</code>{" "}
          trên máy người tham gia). File chỉ được đọc số liệu và tướng; không giữ tên, PUUID hay
          Riot ID. Sau khi nhập sẽ vào vùng duyệt, chưa lên overlay.
        </p>
        <div className="riot-config-grid">
          <label>
            Đã lưu trên máy này (probe)
            <NativeSelect
              aria-label="EOG đã lưu"
              value={fileName}
              onChange={(e) => setFileName(e.target.value)}
            >
              <option value="">
                {files.length ? "Chọn một bản đã lưu" : "Chưa có bản nào trong .npm-cache/lcu-eog"}
              </option>
              {files.map((f) => (
                <option value={f.name} key={f.name}>
                  {new Date(f.modified).toLocaleString("vi-VN")} , {f.name.slice(0, 24)}
                </option>
              ))}
            </NativeSelect>
          </label>
          <Button
            type="button"
            disabled={!fileName}
            onClick={() => action("import-eog", { gameNumber, file: fileName })}
          >
            Nạp bản đã lưu
          </Button>
        </div>
        <div className="riot-config-grid">
          <label>
            Ván trong loạt trận
            <Input
              aria-label="Ván EOG"
              type="number"
              min={1}
              max={99}
              value={gameNumber}
              onChange={(e) => setGameNumber(Number(e.target.value))}
            />
          </label>
          <label>
            File EOG (.json)
            <Input
              aria-label="File EOG"
              type="file"
              accept=".json,application/json"
              onChange={(e) => {
                void importEog(e.target.files?.[0]);
                e.target.value = "";
              }}
            />
          </label>
        </div>
        <div className="riot-config-grid">
          <label>
            Kiểu xác thực
            <NativeSelect
              aria-label="Kiểu xác thực Riot"
              value={mode}
              onChange={(e) => {
                setMode(e.target.value as typeof mode);
                setSecret("");
              }}
            >
              <option value="standard">Production Standard , X-Riot-Token</option>
              <option value="rso">RSO , Bearer access token đã được cấp</option>
            </NativeSelect>
          </label>
          <label>
            {mode === "standard" ? "Riot API key" : "RSO access token"}
            <Input
              aria-label="Riot key hoặc token"
              type="password"
              autoComplete="off"
              spellCheck={false}
              value={secret}
              placeholder={
                status?.configured
                  ? "Để trống nếu giữ key phiên hiện tại"
                  : "Nhập tại đây; không gửi qua chat"
              }
              onChange={(e) => setSecret(e.target.value)}
            />
          </label>
        </div>
        <div className="config-actions">
          <Button
            disabled={secret.trim().length < 12}
            onClick={() => action("credential", { mode, secret: secret.trim() })}
          >
            Lưu key/token trong phiên
          </Button>
          <Button
            className="secondary"
            disabled={!status?.configured}
            onClick={() => action("credential", { clear: true })}
          >
            Xóa key/token
          </Button>
        </div>
        <p className="riot-security-note">
          Không lưu key xuống đĩa, theme, localStorage hoặc bản export. Restart backend cần nhập
          lại. Ô nhập được xóa sau khi backend nhận; key không gửi qua WebSocket/OBS. Việc lưu chưa
          chứng minh key có quyền truy cập trận.
        </p>
        {mode === "rso" && (
          <p>
            Nhập access token RSO đã cấp; không phải API key hay client secret. Phần này không tự
            đăng nhập, refresh token hoặc xin quyền Riot.
          </p>
        )}
        <div className="riot-config-grid">
          <label>
            Riot match ID
            <Input
              aria-label="Riot match ID"
              value={matchId}
              placeholder="VN2_123456789"
              spellCheck={false}
              onChange={(e) => setMatchId(e.target.value)}
            />
          </label>
          <label>
            Ván trong loạt trận
            <Input
              aria-label="Ván Riot"
              type="number"
              min={1}
              max={99}
              value={gameNumber}
              onChange={(e) => setGameNumber(Number(e.target.value))}
            />
          </label>
        </div>
        <div className="config-actions">
          <Button
            disabled={
              !status?.configured ||
              !/^VN2_\d{1,20}$/.test(matchId.trim()) ||
              !Number.isInteger(gameNumber) ||
              gameNumber < 1 ||
              gameNumber > 99 ||
              mode !== status?.mode
            }
            onClick={() => action("load", { matchId: matchId.trim(), gameNumber })}
          >
            {busy ? "Đang tải..." : "Tải match + timeline / kiểm tra quyền"}
          </Button>
          <Button
            className="secondary"
            disabled={!candidate}
            onClick={() => setShowCandidate((v) => !v)}
          >
            {showCandidate ? "Ẩn" : "Hiện"} bản chờ duyệt
          </Button>
        </div>
        <p>
          Standard không mặc định truy cập custom thường. Nếu 404/403, giữ dữ liệu đang phát và kiểm
          tra quyền RSO/Tournament; không tự đoán ID hay tạo dữ liệu giả. LB gameId nội bộ không
          phải Riot match ID.
        </p>
      </fieldset>
      {notice && (
        <p role="status" className="riot-notice">
          {notice}
        </p>
      )}
      {candidate && showCandidate && (
        <div className="riot-candidate">
          <h4>Bản chờ duyệt , {candidate.evidence.matchId} , chưa lên chương trình</h4>
          <p>
            {candidate.evidence.isFinal
              ? "Kết quả có winner/thời lượng"
              : "Dữ liệu kết quả chưa đầy đủ"}{" "}
            , Patch {candidate.evidence.patch || "Chưa có"} ,{" "}
            {candidate.evidence.timelineAvailable ? "Có timeline" : "Thiếu timeline"} ,{" "}
            {candidate.evidence.mode.toUpperCase()}
            {bots ? ` , ${bots} bot` : ""}
          </p>
          <div className="program-monitor">
            <Surface
              state={{
                ...state,
                scene: "postgame",
                mockVisible: false,
                postgame: candidate,
                rehearsal: undefined,
              }}
            />
          </div>
          <ul>
            {candidate.evidence.warnings.map((w, i) => (
              <li key={i}>{w}</li>
            ))}
          </ul>
          <label className="riot-review-check">
            <Input
              type="checkbox"
              checked={reviewed}
              onChange={(e) => setReviewed(e.target.checked)}
            />{" "}
            Tôi đã đối chiếu match, hai đội và các mục còn thiếu trước khi phát
          </label>
          <Button
            disabled={!connected || busy || !reviewed}
            onClick={() => action("publish", { matchId: candidate.evidence.matchId })}
          >
            Dùng dữ liệu này cho postgame
          </Button>
        </div>
      )}
    </section>
  );
}
