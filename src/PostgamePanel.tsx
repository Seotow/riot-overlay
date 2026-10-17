import { NativeSelect } from "./components/ui/native-select";
import { Input } from "./components/ui/input";
import { Button } from "./components/ui/button";
import { useEffect, useState } from "react";
import type { State } from "../shared/schema";
import { riotPostgameSchema, type RiotPostgameState } from "../shared/postgame";
import { reduceRofl } from "../shared/rofl-postgame";
import { Surface } from "./overlay/Surface";
type Status = { candidate: RiotPostgameState | null };
const errors: Record<string, string> = {
  "no-candidate": "Chưa có bản dữ liệu khớp match ID để phát.",
  "no-file": "Không đọc được file replay (đã bị xóa hoặc không nằm trong thư mục cho phép).",
  "invalid-data": "Dữ liệu replay không hợp lệ: cần đủ 10 người hai đội.",
  "body-too-large": "Dữ liệu quá lớn.",
};
export function PostgamePanel({ state, connected }: { state: State; connected: boolean }) {
  const [status, setStatus] = useState<Status | null>(null);
  const [gameNumber, setGameNumber] = useState(1);
  const [busy, setBusy] = useState(false);
  const [notice, setNotice] = useState("");
  const [showCandidate, setShowCandidate] = useState(false);
  const [replays, setReplays] = useState<{ name: string; size: number; modified: string }[]>([]);
  const [replayName, setReplayName] = useState("");
  const [replayState, setReplayState] = useState<{
    download: string;
    detail: string | null;
  } | null>(null);
  const [reviewed, setReviewed] = useState(false);
  // A replay staged by the server (the client downloaded it after the match) shows up without a
  // reload, and the list of replays on this machine stays current.
  useEffect(() => {
    const refresh = () => {
      if (document.hidden) return;
      fetch("/api/postgame/status", { cache: "no-store" })
        .then((r) => (r.ok ? r.json() : null))
        .then((s: Status | null) => {
          if (!s) return;
          setStatus((current) => {
            if (
              !s.candidate ||
              current?.candidate?.evidence.fetchedAt === s.candidate.evidence.fetchedAt
            )
              return current ?? s;
            setShowCandidate(true);
            setReviewed(false);
            setNotice("Có dữ liệu cuối trận mới từ replay, đang chờ duyệt. Chưa lên overlay.");
            return { ...s, candidate: riotPostgameSchema.parse(s.candidate) };
          });
        })
        .catch(() => {});
      fetch("/api/postgame/rofl-files", { cache: "no-store" })
        .then((r) => (r.ok ? r.json() : null))
        .then((r) => {
          if (!r) return;
          setReplays(r.files ?? []);
          setReplayState(r.replay ?? null);
        })
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
      const response = await fetch(`/api/postgame/${route}`, {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify(value),
      });
      const result = await response.json();
      if (!response.ok) {
        setNotice(errors[result.error] ?? "Request thất bại; chưa thay dữ liệu đang phát.");
        return;
      }
      if (route === "publish")
        setNotice(`Đã đưa ${result.matchId} lên postgame. Studio/OBS nhận cùng snapshot.`);
      else {
        if (result.candidate) result.candidate = riotPostgameSchema.parse(result.candidate);
        setStatus(result);
        setReviewed(false);
        setShowCandidate(true);
        setNotice("Đã nhập dữ liệu vào vùng duyệt. Chưa thay overlay đang phát.");
      }
    } catch {
      setNotice(
        "Backend không phản hồi hoặc dữ liệu không đúng contract. Chưa thay overlay đang phát.",
      );
    } finally {
      setBusy(false);
    }
  };
  // Only the metadata at the end of the replay is read in the browser (a few tens of KB): the
  // multi-megabyte file is never uploaded, and names/PUUIDs are dropped before anything is sent.
  const importRofl = async (file: File | undefined) => {
    if (!file) return;
    const id = /^[A-Za-z0-9]{2,6}-(\d{1,15})\.rofl$/.exec(file.name)?.[1];
    if (!id) {
      setNotice("Tên file phải dạng VN2-<gameId>.rofl.");
      return;
    }
    try {
      const length = new DataView(await file.slice(file.size - 4).arrayBuffer()).getUint32(0, true);
      if (length <= 0 || length > 2_000_000 || length > file.size - 12) throw Error();
      const text = await file.slice(file.size - 4 - length, file.size - 4).text();
      const rofl = reduceRofl(JSON.parse(text), Number(id));
      await action("import-rofl", { gameNumber, rofl });
    } catch {
      setNotice("Không đọc được metadata replay. Chưa thay dữ liệu đang phát.");
    }
  };
  const candidate = status?.candidate;
  const bots = candidate
    ? candidate.teams.reduce((n, t) => n + t.players.filter((p) => p.bot).length, 0)
    : 0;
  return (
    <section className="postgame-panel">
      <div className="section-heading">
        <div>
          <h3>Dữ liệu sau trận từ replay</h3>
          <p>
            Client tải replay (.rofl) của trận; dữ liệu cuối trận vào vùng duyệt rồi mới lên sóng.
          </p>
        </div>
      </div>
      <fieldset disabled={!connected || busy}>
        <p>
          Backend tự gửi yêu cầu tải replay sau trận và theo dõi thư mục Replays cùng thư mục thả
          file <code>.npm-cache/rofl-inbox</code>. Mỗi file mới tự vào vùng duyệt. Chỉ đọc số liệu
          cuối trận và tướng; bỏ tên, PUUID, Riot ID.
          {replayState
            ? ` Tải replay: ${replayState.download === "idle" ? "chưa có yêu cầu" : replayState.download === "requested" ? "đã yêu cầu" : "client từ chối"}${replayState.detail ? ` (${replayState.detail})` : ""}.`
            : ""}
        </p>
        <div className="postgame-config-grid">
          <label>
            Replay trên máy này
            <NativeSelect
              aria-label="Replay trên máy"
              value={replayName}
              onChange={(e) => setReplayName(e.target.value)}
            >
              <option value="">
                {replays.length ? "Chọn một replay" : "Chưa thấy replay nào"}
              </option>
              {replays.map((f) => (
                <option value={f.name} key={f.name}>
                  {new Date(f.modified).toLocaleString("vi-VN")} , {f.name}
                </option>
              ))}
            </NativeSelect>
          </label>
          <label>
            Ván trong loạt trận
            <Input
              aria-label="Ván trong loạt trận"
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
            type="button"
            disabled={!replayName}
            onClick={() => action("import-rofl", { gameNumber, replay: replayName })}
          >
            Nạp replay đã chọn
          </Button>
          <Button
            className="secondary"
            disabled={!candidate}
            onClick={() => setShowCandidate((v) => !v)}
          >
            {showCandidate ? "Ẩn" : "Hiện"} bản chờ duyệt
          </Button>
        </div>
        <div className="postgame-config-grid">
          <label>
            Hoặc chọn file .rofl
            <Input
              aria-label="File replay"
              type="file"
              accept=".rofl"
              onChange={(e) => {
                void importRofl(e.target.files?.[0]);
                e.target.value = "";
              }}
            />
          </label>
        </div>
      </fieldset>
      {notice && (
        <p role="status" className="postgame-notice">
          {notice}
        </p>
      )}
      {candidate && showCandidate && (
        <div className="postgame-candidate">
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
          <label className="postgame-review-check">
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
