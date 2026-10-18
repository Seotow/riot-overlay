import { useEffect, useRef, useState } from "react";
import { Button } from "../components/ui/button";
import { Input } from "../components/ui/input";
import { NativeSelect } from "../components/ui/native-select";
import {
  defaultPostgameConfig,
  postgameErrorText,
  postgameFonts,
  postgameRegions,
  type PostgameConfig,
} from "../../shared/valorant-postgame";
import { useValorantPostgame } from "../lib/useValorantPostgame";

type Colors =
  | "primaryColor"
  | "cellColor"
  | "cell2Color"
  | "headerBgColor"
  | "headerTextColor"
  | "bodyTextColor"
  | "overlayBgColor";
type Opacities =
  "primaryOpacity" | "cellOpacity" | "cell2Opacity" | "headerBgOpacity" | "overlayBgOpacity";
const themeFields: [string, Colors, Opacities | null][] = [
  ["Màu chủ đạo", "primaryColor", "primaryOpacity"],
  ["Ô nền", "cellColor", "cellOpacity"],
  ["Ô nền 2", "cell2Color", "cell2Opacity"],
  ["Nền header", "headerBgColor", "headerBgOpacity"],
  ["Chữ header", "headerTextColor", null],
  ["Chữ nội dung", "bodyTextColor", null],
  ["Màu phủ nền", "overlayBgColor", "overlayBgOpacity"],
];
const overlays = [
  { id: "preview", label: "Postgame", path: "/valorant-postgame/preview.html" },
  { id: "mvp", label: "MVP", path: "/valorant-postgame/mvp.html" },
] as const;

function Preview({ path }: { path: string }) {
  const box = useRef<HTMLDivElement>(null);
  const [scale, setScale] = useState(0.4);
  useEffect(() => {
    const el = box.current;
    if (!el) return;
    const fit = () => setScale(el.clientWidth / 1920);
    fit();
    const observer = new ResizeObserver(fit);
    observer.observe(el);
    return () => observer.disconnect();
  }, []);
  return (
    <div className="val-preview" ref={box} style={{ height: 1080 * scale }}>
      <iframe
        title="Xem trước postgame Valorant"
        src={path}
        width={1920}
        height={1080}
        style={{ transform: `scale(${scale})` }}
      />
    </div>
  );
}

export function ValorantPostgame() {
  const { status, history, loading, save, select, loadHistory } = useValorantPostgame();
  const [draft, setDraft] = useState<PostgameConfig>(defaultPostgameConfig);
  const [apiKey, setApiKey] = useState("");
  const [message, setMessage] = useState("");
  // Chỉ nạp lại form khi cấu hình đã lưu thật sự đổi; trạng thái được làm mới định kỳ nên
  // so theo nội dung, nếu không sẽ ghi đè chữ đang gõ.
  const saved = status ? JSON.stringify(status.config) : "";
  useEffect(() => {
    if (saved) setDraft(JSON.parse(saved) as PostgameConfig);
  }, [saved]);

  const submit = async () => {
    setMessage("Đang lưu…");
    const ok = await save(draft, apiKey === "" ? undefined : apiKey === "-" ? "" : apiKey);
    setApiKey("");
    setMessage(ok ? "Đã lưu." : "Không lưu được: kiểm tra Riot ID và màu.");
  };
  const choose = async (selection: Parameters<typeof select>[0]) => {
    setMessage("Đang tải trận…");
    const result = await select(selection);
    setMessage(
      result.ok ? "Đã chọn trận cho overlay." : (result.message ?? "Không chọn được trận."),
    );
  };
  const spectra = status?.spectra;
  const using = status?.selection?.source === "henrik" ? "henrik" : "spectra";
  const url = (path: string) => `${location.origin}${path}`;
  const set = (patch: Partial<PostgameConfig>) => setDraft({ ...draft, ...patch });

  return (
    <section className="val-page val-postgame">
      <div className="val-broadcast">
        <div className="val-previews">
          {overlays.map((o) => (
            <div className="val-card" key={o.id}>
              <div className="val-row">
                <h3>{o.label}</h3>
                <Button
                  type="button"
                  onClick={() => window.open(url(o.path), "_blank", "noopener")}
                >
                  Mở overlay
                </Button>
              </div>
              <Preview key={`${o.id}-${using}`} path={o.path} />
              <p>OBS Browser Source 1920×1080: {url(o.path)}</p>
            </div>
          ))}
          <p>
            Đang dùng nguồn <b>{using === "henrik" ? "Henrik Dev" : "Spectra"}</b>. Số liệu nguồn
            không có hiện "—".
          </p>
        </div>

        <div className="val-controls">
          <div className="val-card">
            <h3>Trận vừa chơi (Spectra)</h3>
            {spectra ? (
              <p>
                {spectra.map ?? "Map chưa rõ"} · {spectra.score[0]}–{spectra.score[1]} ·{" "}
                {spectra.players} người · {spectra.final ? "đã kết thúc" : "chưa kết thúc"}
              </p>
            ) : (
              <p>
                Chưa có trận. Bật Valorant và vào trận observer, khung cuối được giữ lại tự động.
              </p>
            )}
            <p>Có: {status?.coverage.spectra.join(", ")}.</p>
            <p>Không có: {status?.coverage.missingFromSpectra.join(", ")}.</p>
            <Button disabled={!spectra} onClick={() => void choose({ source: "spectra" })}>
              Dùng trận này
            </Button>
          </div>

          <div className="val-card">
            <h3>Henrik Dev (đủ số liệu)</h3>
            <label>
              Tên Riot ID
              <Input
                maxLength={32}
                value={draft.name}
                onChange={(e) => set({ name: e.target.value })}
              />
            </label>
            <label>
              Tag
              <Input
                maxLength={10}
                value={draft.tag}
                onChange={(e) => set({ tag: e.target.value })}
              />
            </label>
            <div className="val-row">
              <NativeSelect
                value={draft.region}
                onChange={(e) => set({ region: e.target.value as PostgameConfig["region"] })}
                aria-label="Khu vực"
              >
                {postgameRegions.map((r) => (
                  <option key={r} value={r}>
                    {r.toUpperCase()}
                  </option>
                ))}
              </NativeSelect>
              <NativeSelect
                value={draft.platform}
                onChange={(e) => set({ platform: e.target.value as PostgameConfig["platform"] })}
                aria-label="Nền tảng"
              >
                <option value="pc">PC</option>
                <option value="console">Console</option>
              </NativeSelect>
            </div>
            <label>
              API key {status?.hasApiKey ? "(đã lưu; nhập để thay, gõ - để xóa)" : ""}
              <Input
                type="password"
                autoComplete="off"
                maxLength={100}
                value={apiKey}
                placeholder={status?.hasApiKey ? "••••••••" : "HDEV-..."}
                onChange={(e) => setApiKey(e.target.value)}
              />
            </label>
            <fieldset className="val-theme">
              <legend>Giao diện</legend>
              {themeFields.map(([label, colorKey, opacityKey]) => (
                <div className="val-row" key={colorKey}>
                  <label>
                    {label}
                    <Input
                      type="color"
                      value={draft[colorKey]}
                      onChange={(e) => set({ [colorKey]: e.target.value })}
                    />
                  </label>
                  {opacityKey && (
                    <label>
                      Độ mờ {Math.round(draft[opacityKey] * 100)}%
                      <Input
                        type="range"
                        min="0"
                        max="1"
                        step="0.01"
                        value={draft[opacityKey]}
                        onChange={(e) => set({ [opacityKey]: Number(e.target.value) })}
                      />
                    </label>
                  )}
                </div>
              ))}
              <label>
                Font
                <NativeSelect
                  value={draft.fontFamily}
                  onChange={(e) =>
                    set({ fontFamily: e.target.value as PostgameConfig["fontFamily"] })
                  }
                >
                  {postgameFonts.map((f) => (
                    <option key={f} value={f}>
                      {f}
                    </option>
                  ))}
                </NativeSelect>
              </label>
              <label className="val-check">
                <input
                  type="checkbox"
                  checked={draft.useDefaultBg}
                  onChange={(e) => set({ useDefaultBg: e.target.checked })}
                />{" "}
                Dùng ảnh nền mặc định
              </label>
              <label className="val-check">
                <input
                  type="checkbox"
                  checked={draft.useDefaultSponsor}
                  onChange={(e) => set({ useDefaultSponsor: e.target.checked })}
                />{" "}
                Dùng ảnh nhà tài trợ mặc định
              </label>
              <Button
                type="button"
                onClick={() =>
                  setDraft({
                    ...defaultPostgameConfig,
                    name: draft.name,
                    tag: draft.tag,
                    region: draft.region,
                    platform: draft.platform,
                  })
                }
              >
                Về theme mặc định
              </Button>
            </fieldset>
            <label className="val-check">
              <input
                type="checkbox"
                checked={draft.hidePlayerTag}
                onChange={(e) => set({ hidePlayerTag: e.target.checked })}
              />{" "}
              Ẩn #tag của người chơi
            </label>
            <div className="val-row">
              <Button onClick={() => void submit()}>Lưu</Button>
              <Button
                disabled={loading || !status?.hasApiKey || !status.config.name}
                onClick={() => void loadHistory()}
              >
                {loading ? "Đang tải…" : "Tải lịch sử trận"}
              </Button>
            </div>
            <details>
              <summary>Hướng dẫn thiết lập</summary>
              <ol>
                <li>
                  Lấy API key miễn phí tại{" "}
                  <a
                    href="https://docs.henrikdev.xyz/general/api-keys"
                    target="_blank"
                    rel="noreferrer"
                  >
                    docs.henrikdev.xyz
                  </a>
                  . Key chỉ lưu trên máy này (collector/hosts/valorant-collector/local), không gửi
                  đi đâu khác ngoài Henrik Dev.
                </li>
                <li>Nhập Riot ID (tên và tag), khu vực, rồi dán key và bấm Lưu.</li>
                <li>
                  Bấm "Tải lịch sử trận", chọn trận vừa chơi; overlay đổi ngay, OBS không cần tải
                  lại.
                </li>
                <li>
                  Trong OBS thêm Browser Source với URL ở khung xem trước (1920×1080). Trận custom
                  của người khác có thể không có trong lịch sử của bạn; khi đó dùng nguồn Spectra.
                </li>
              </ol>
            </details>
          </div>
        </div>
      </div>

      {history && (
        <div className="val-card">
          <h3>Lịch sử {history.ok ? `${history.name}#${history.tag}` : ""}</h3>
          {history.ok ? (
            history.matches.length === 0 ? (
              <p>Không có trận nào gần đây.</p>
            ) : (
              <table className="val-table">
                <thead>
                  <tr>
                    <th>Map</th>
                    <th>Hàng đợi</th>
                    <th>Agent</th>
                    <th>Tỉ số</th>
                    <th>Kết quả</th>
                    <th />
                  </tr>
                </thead>
                <tbody>
                  {history.matches.map((m) => (
                    <tr key={m.matchId}>
                      <td>{m.map}</td>
                      <td>{m.queue}</td>
                      <td>{m.agent}</td>
                      <td>{m.score}</td>
                      <td>{m.won === null ? "—" : m.won ? "Thắng" : "Thua"}</td>
                      <td>
                        <Button
                          disabled={
                            status?.selection?.source === "henrik" &&
                            status.selection.matchId === m.matchId
                          }
                          onClick={() => void choose({ source: "henrik", matchId: m.matchId })}
                        >
                          {status?.selection?.source === "henrik" &&
                          status.selection.matchId === m.matchId
                            ? "Đang dùng"
                            : "Dùng"}
                        </Button>
                      </td>
                    </tr>
                  ))}
                </tbody>
              </table>
            )
          ) : (
            <p>{postgameErrorText[history.error]}</p>
          )}
        </div>
      )}
      {message && <p role="status">{message}</p>}
    </section>
  );
}
