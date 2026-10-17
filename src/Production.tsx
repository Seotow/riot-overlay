import { Input } from "./components/ui/input";
import { NativeSelect } from "./components/ui/native-select";
import { Button } from "./components/ui/button";
import { Card } from "./components/ui/card";
import React, { useEffect, useState } from "react";
import { themeSchema, type Theme, type State, type Command } from "../shared/schema";
import type { ObserverFrame } from "../shared/observer";
import { Surface } from "./overlay/Surface";
import { swapTeamSides } from "../shared/match-config";
import { broadcastColors } from "../shared/broadcast-colors";
import { ProgramMonitor } from "./ProgramMonitor";
import { broadcastWidgetOn } from "../shared/broadcast-controls";
import { graphicsLabels, graphicEnabled, type GraphicKey } from "../shared/broadcast-graphics";

export const outputUrl = "/overlay?scene=ingame";
export const defaultBroadcast = { view: "normal", inhibitors: "auto" } as const;
export function MatchConfig({
  state,
  send,
  connected,
  next,
}: {
  state: State;
  send: (c: Command) => void;
  connected: boolean;
  next: () => void;
}) {
  const [draft, setDraft] = useState<Theme>(state.theme);
  const [message, setMessage] = useState("");
  const [pending, setPending] = useState<string | null>(null);
  useEffect(() => {
    if (pending && JSON.stringify(state.theme) === pending) {
      setPending(null);
      setMessage("Đã lưu cấu hình.");
    }
  }, [state.theme, pending]);
  const patch = (value: Partial<Theme>) => {
    setDraft((current) => ({ ...current, ...value }));
    setMessage("Có thay đổi chưa lưu.");
  };
  const save = () => {
    const result = themeSchema.safeParse(draft);
    if (!result.success) {
      setMessage("Cấu hình không hợp lệ: kiểm tra tên, màu, tỉ số và logo.");
      return;
    }
    if (Math.max(draft.blueScore ?? 0, draft.redScore ?? 0) > (draft.seriesGames ?? 3)) {
      setMessage("Tỉ số không được vượt số trận thắng của thể thức đã chọn.");
      return;
    }
    setPending(JSON.stringify(result.data));
    send({ type: "theme", value: result.data });
    setMessage("Đang gửi cấu hình...");
  };
  return (
    <section className="match-config">
      <h2>Cấu hình trước trận</h2>
      <p>Thay đổi sẽ áp dụng sau khi lưu.</p>
      <div className="config-grid">
        <fieldset>
          <legend>Giải đấu & loạt trận</legend>
          {(
            [
              ["name", "Tên cấu hình"],
              ["tournament", "Tên giải"],
            ] as const
          ).map(([key, label]) => (
            <label key={key}>
              {label}
              <Input value={draft[key]} onChange={(e) => patch({ [key]: e.target.value })} />
            </label>
          ))}
          <label>
            Thể thức loạt trận
            <NativeSelect
              value={draft.seriesGames ?? 3}
              onChange={(e) => {
                const wins = Number(e.target.value);
                patch({
                  seriesGames: wins,
                  blueScore: Math.min(draft.blueScore ?? 0, wins),
                  redScore: Math.min(draft.redScore ?? 0, wins),
                });
              }}
            >
              {Array.from({ length: 9 }, (_, i) => (
                <option key={i} value={i + 1}>
                  BO{i * 2 + 1}, {i + 1} ô thắng
                </option>
              ))}
            </NativeSelect>
          </label>
          <Button
            type="button"
            onClick={() => {
              // Same action as the draft desk button; the form follows the saved swap.
              send({ type: "swapSides" });
              setDraft((current) => swapTeamSides(current));
              setMessage("Đã đổi bên.");
            }}
          >
            Đổi bên xanh ↔ đỏ
          </Button>
          <small>
            Đổi tên, logo, tỉ số, HLV, tên người chơi và series ban; giữ màu theo phía bản đồ. Áp
            dụng ngay.
          </small>
        </fieldset>
        {(["blue", "red"] as const).map((side) => (
          <fieldset key={side}>
            <legend>Đội {side === "blue" ? "xanh" : "đỏ"}</legend>
            <label>
              Tên đội
              <Input
                maxLength={5}
                value={draft[`${side}Name`]}
                onChange={(e) => patch({ [`${side}Name`]: e.target.value })}
              />
            </label>
            <label>
              Mô tả / thứ hạng
              <Input
                maxLength={40}
                placeholder="VD: LCK #1"
                value={draft[`${side}Description`] ?? ""}
                onChange={(e) => patch({ [`${side}Description`]: e.target.value })}
              />
            </label>
            <label>
              Tỉ số
              <Input
                type="number"
                min="0"
                max={draft.seriesGames ?? 3}
                value={draft[`${side}Score`] ?? 0}
                onChange={(e) => patch({ [`${side}Score`]: Number(e.target.value) })}
              />
            </label>
            <label>
              Logo tùy chọn (PNG / JPEG / WebP, tối đa 350KB)
              <Input
                type="file"
                accept="image/png,image/jpeg,image/webp"
                onChange={async (e) => {
                  const file = e.target.files?.[0];
                  if (!file) return;
                  if (
                    file.size > 350000 ||
                    !["image/png", "image/jpeg", "image/webp"].includes(file.type)
                  ) {
                    setMessage("Logo phải là PNG/JPEG/WebP, tối đa 350KB.");
                    return;
                  }
                  const reader = new FileReader();
                  reader.onload = () => patch({ [`${side}Logo`]: String(reader.result) });
                  reader.readAsDataURL(file);
                  e.target.value = "";
                }}
              />
            </label>
            {draft[`${side}Logo`] && (
              <img className="config-logo" src={draft[`${side}Logo`]} alt="Logo đội" />
            )}
            <Button onClick={() => patch({ [`${side}Logo`]: "" })}>Không dùng logo</Button>
          </fieldset>
        ))}
        <fieldset>
          <legend>Logo giữa overlay</legend>
          {(
            [
              ["scoreboardLogo", "Logo giữa thanh tỉ số"],
              ["minimalLogo", "Logo giữa hai đội tối giản"],
            ] as const
          ).map(([key, label]) => (
            <div key={key}>
              <label>
                {label} (PNG, tối đa 100KB)
                <Input
                  type="file"
                  accept="image/png"
                  onChange={(e) => {
                    const file = e.target.files?.[0];
                    e.target.value = "";
                    if (!file) return;
                    if (file.type !== "image/png" || file.size > 100000) {
                      setMessage("Logo giữa phải là PNG, tối đa 100KB.");
                      return;
                    }
                    const reader = new FileReader();
                    reader.onload = () => patch({ [key]: String(reader.result) });
                    reader.readAsDataURL(file);
                  }}
                />
              </label>
              {draft[key] && <img className="config-logo" src={draft[key]} alt={label} />}
              <Button type="button" onClick={() => patch({ [key]: "" })}>
                Bỏ {label.toLowerCase()}
              </Button>
            </div>
          ))}
        </fieldset>
        <fieldset>
          <legend>Nhận diện & bố cục</legend>
          <label>
            Kiểu killfeed
            <NativeSelect
              aria-label="Kiểu killfeed"
              value={draft.killfeedStyle ?? "text"}
              onChange={(e) => patch({ killfeedStyle: e.target.value as "text" | "broadcast" })}
            >
              <option value="text">Thông báo chữ hiện tại</option>
              <option value="broadcast">Broadcast, icon như mẫu</option>
            </NativeSelect>
          </label>
          <label>
            Độ đậm nền in-game, {Math.round((draft.ingamePanelOpacity ?? 0.84) * 100)}%
            <Input
              aria-label="Độ đậm nền in-game"
              type="range"
              min="0.35"
              max="0.9"
              step="0.01"
              value={draft.ingamePanelOpacity ?? 0.84}
              onChange={(e) => patch({ ingamePanelOpacity: Number(e.target.value) })}
            />
          </label>
          <label>
            Layout cấm chọn
            <NativeSelect
              value={draft.draftLayout ?? "broadcast"}
              onChange={(e) => patch({ draftLayout: e.target.value as "broadcast" | "simple" })}
            >
              <option value="broadcast">Cam tuyển thủ</option>
              <option value="simple">Simple, cam caster</option>
            </NativeSelect>
          </label>
          {(["red", "accent", "background"] as const).map((key) => (
            <label key={key}>
              {
                {
                  red: "Đỏ, tên đội / icon / progress / chênh vàng",
                  accent: "Màu nhấn",
                  background: "Nền panel",
                }[key]
              }
              <Input
                type="color"
                value={draft[key]}
                onChange={(e) => patch({ [key]: e.target.value })}
              />
            </label>
          ))}
          <label>
            Font
            <NativeSelect
              value={draft.font}
              onChange={(e) => patch({ font: e.target.value as Theme["font"] })}
            >
              <option value="system">Spiegel</option>
              <option value="condensed">Beaufort</option>
              <option value="serif">Georgia</option>
            </NativeSelect>
          </label>
          <label>
            Xanh, tên đội / icon / progress / chênh vàng
            <Input
              type="color"
              value={broadcastColors(draft).blue}
              onChange={(e) => patch({ blueSecondary: e.target.value })}
            />
          </label>
          <label>
            Bố cục mặc định
            <NativeSelect
              value={draft.variant}
              onChange={(e) => patch({ variant: e.target.value as Theme["variant"] })}
            >
              <option value="panel">Đầy đủ</option>
              <option value="minimal">Tối giản</option>
            </NativeSelect>
          </label>
          <label>
            Layout tuyển thủ
            <NativeSelect
              aria-label="Layout tuyển thủ mặc định"
              value={draft.playerCameras === false ? "expanded" : "camera"}
              onChange={(e) => patch({ playerCameras: e.target.value === "camera" })}
            >
              <option value="expanded">Không cam, bảng mở rộng</option>
              <option value="camera">Có cam, chừa hai vùng tuyển thủ</option>
            </NativeSelect>
          </label>
          <label>
            Tỉ lệ {draft.scale}
            <Input
              type="range"
              min="0.75"
              max="1.15"
              step="0.01"
              value={draft.scale}
              onChange={(e) => patch({ scale: +e.target.value })}
            />
          </label>
          <label>
            Dịch dọc {draft.offsetY}px
            <Input
              type="range"
              min="0"
              max="100"
              value={draft.offsetY}
              onChange={(e) => patch({ offsetY: +e.target.value })}
            />
          </label>
          {Object.entries(draft.widgets).map(([key, value]) => (
            <label key={key}>
              <Input
                type="checkbox"
                checked={value}
                onChange={(e) =>
                  patch({
                    widgets: { ...draft.widgets, [key]: e.target.checked },
                  })
                }
              />
              {
                {
                  players: "Bảng người chơi",
                  levels: "Level mặc định",
                  objectives: "Mục tiêu / sự kiện tự động",
                  killfeed: "Thông báo hạ gục",
                  gold: "Vàng / chênh lệch vàng",
                }[key as keyof Theme["widgets"]]
              }
            </label>
          ))}
        </fieldset>
      </div>
      <fieldset className="graphics-controls">
        <legend>Đổi tên tuyển thủ</legend>
        <p>
          Tên nhập ở đây hiện ở banpick và in-game. Để trống thì dùng đúng tên lấy từ client hoặc
          nguồn dữ liệu.
        </p>
        {Array.from({ length: 10 }, (_, slot) => (
          <label key={slot}>
            {slot < 5 ? draft.blueName : draft.redName}, người {(slot % 5) + 1}
            <Input
              aria-label={`Tên tuyển thủ ${slot + 1}`}
              maxLength={80}
              value={draft.playerNames?.[slot] ?? ""}
              placeholder="Tự lấy tên người chơi"
              onChange={(e) => {
                const names = [...(draft.playerNames ?? Array(10).fill(""))];
                names[slot] = e.target.value;
                patch({ playerNames: names });
              }}
            />
          </label>
        ))}
      </fieldset>
      <fieldset className="graphics-controls">
        <legend>Đồ họa ingame độc lập</legend>
        {Object.entries(graphicsLabels).map(([key, label]) => (
          <label key={key}>
            <Input
              type="checkbox"
              checked={graphicEnabled(draft, key as GraphicKey)}
              onChange={(e) =>
                patch({
                  ingameGraphics: {
                    ...draft.ingameGraphics,
                    [key]: e.target.checked,
                  },
                })
              }
            />
            {label}
          </label>
        ))}
      </fieldset>
      <div className="config-actions">
        <Button variant="default" disabled={!connected} onClick={save}>
          Lưu cấu hình
        </Button>
        <Button
          onClick={() => {
            setDraft(state.theme);
            setMessage("Đã lấy cấu hình hiện hành.");
          }}
        >
          Lấy cấu hình đang phát
        </Button>
        <Button
          onClick={() => {
            const url = URL.createObjectURL(
              new Blob([JSON.stringify(draft, null, 2)], {
                type: "application/json",
              }),
            );
            const a = document.createElement("a");
            a.href = url;
            a.download = "match-config.json";
            a.click();
            URL.revokeObjectURL(url);
          }}
        >
          Export JSON
        </Button>
        <label>
          Import JSON
          <Input
            type="file"
            accept=".json"
            onChange={async (e) => {
              const f = e.target.files?.[0];
              if (!f) return;
              try {
                if (f.size > 1100000) throw Error();
                setDraft(themeSchema.parse(JSON.parse(await f.text())));
                setMessage("Đã nhập vào form; bấm Lưu để phát.");
              } catch {
                setMessage("JSON không hợp lệ.");
              }
              e.target.value = "";
            }}
          />
        </label>
        <Button onClick={next}>Đến bàn điều khiển →</Button>
      </div>
      <p role="status">{message}</p>
    </section>
  );
}

function WidgetPreview({
  state,
  observation,
  view,
  inhibitors,
}: {
  state: State;
  observation: ObserverFrame | null;
  view: NonNullable<State["broadcast"]>["view"];
  inhibitors?: "ORDER" | "CHAOS";
}) {
  const regions = {
    gold: [0, 145, 286, 600],
    levels: [0, 145, 286, 600],
    runes: [287, 793, 1346, 287],
    normal: [12, 858, 263, 107],
    minimal: [464, 909, 992, 171],
  };
  const [x, y, w, h] = regions[view];
  const scale = Math.min(145 / w, 108 / h);
  const sample =
    observation?.status === "observed" && Date.now() - Date.parse(observation.capturedAt) < 5000
      ? observation.sample
      : null;
  const empty = !sample
    ? "Chưa có dữ liệu mới"
    : inhibitors &&
        !sample.inhibitors?.value?.some(
          (i) => i.team === inhibitors && i.respawnsAt > (sample.gameTime.value ?? Infinity),
        )
      ? "Không có timer đang chạy"
      : null;
  return (
    <div className="widget-preview" style={{ width: w * scale, height: h * scale }}>
      {empty && <span className="widget-empty">{empty}</span>}
      <div
        style={{
          width: 1920,
          height: 1080,
          position: "absolute",
          left: -x * scale,
          top: -y * scale,
          transform: `scale(${scale})`,
          transformOrigin: "top left",
        }}
      >
        <Surface
          state={{
            ...state,
            scene: "ingame",
            mockVisible: false,
            rehearsal: undefined,
            theme: {
              ...state.theme,
              scale: 1,
              offsetY: 0,
              variant: "panel",
              widgets: {
                ...state.theme.widgets,
                players: true,
                objectives: true,
                levels: view === "levels",
              },
            },
            broadcast: { view, inhibitors: inhibitors ?? "off" },
          }}
          observation={observation}
        />
      </div>
    </div>
  );
}
export function ProductionDesk({
  state,
  observation,
  send,
  connected,
  mode = "live",
}: {
  state: State;
  observation: ObserverFrame | null;
  send: (c: Command) => void;
  connected: boolean;
  mode?: "live" | "recording";
}) {
  const [now, setNow] = useState(Date.now());
  useEffect(() => {
    const timer = setInterval(() => setNow(Date.now()), 500);
    return () => clearInterval(timer);
  }, []);
  const fresh =
    observation?.status === "observed" &&
    !!observation.sample &&
    now - Date.parse(observation.capturedAt) < 5000;
  const control = state.broadcast ?? defaultBroadcast;
  const available = connected && !state.mockVisible && !state.rehearsal;
  const inhibitor = (team: "ORDER" | "CHAOS") => {
    send({ type: "scene", value: "ingame" });
    send({
      type: "broadcastInhibitors",
      value: control.inhibitors === team ? "off" : team,
    });
  };
  return (
    <section
      className={`production-desk modern-production ${mode === "recording" ? "is-recording" : "is-live"}`}
    >
      <div className="section-heading">
        <div>
          <h2>{mode === "recording" ? "Điều khiển đồ họa" : "Chương trình đang phát"}</h2>
          <div className={`data-status ${fresh ? "ready" : "waiting"}`} role="status">
            <i />
            {fresh ? "Đang nhận dữ liệu" : "Chờ dữ liệu trận"}
          </div>
        </div>
        <Button asChild>
          <a href={outputUrl} target="_blank" rel="noreferrer">
            Mở overlay chuẩn
          </a>
        </Button>
      </div>
      {mode === "live" && (state.mockVisible || state.provider === "recording") && (
        <p className="note">
          Đang dùng {state.mockVisible ? "dữ liệu mẫu" : "bản ghi"}. Đổi nguồn khi phát trận trực
          tiếp.
        </p>
      )}
      <div className="broadcast-workspace">
        {mode === "live" && (
          <div className="broadcast-preview">
            <ProgramMonitor url={outputUrl} />
            <div className="output">
              <code>
                {location.origin}
                {outputUrl}
              </code>
              <Button
                onClick={() =>
                  navigator.clipboard.writeText(location.origin + outputUrl).catch(() => {})
                }
              >
                Sao chép URL OBS
              </Button>
            </div>
          </div>
        )}
        <div className="broadcast-controls">
          <div className="operator-grid">
            {(
              [
                ["gold", "Leaderboard vàng"],
                ["levels", "Leaderboard cấp độ"],
                ["runes", "Rune toàn đội"],
                ["minimal", "Layout tối giản"],
              ] as const
            ).map(([view, label]) => (
              <Card className="operator-card" key={view}>
                <div>
                  <h3>{label}</h3>
                  <Button
                    disabled={!available}
                    aria-label={`${label}: ${broadcastWidgetOn(control, view, state.theme) ? "ẩn" : "hiện"}`}
                    aria-pressed={broadcastWidgetOn(control, view, state.theme)}
                    onClick={() =>
                      send({
                        type: "broadcastWidget",
                        key: view,
                        value: !broadcastWidgetOn(control, view, state.theme),
                      })
                    }
                  >
                    {broadcastWidgetOn(control, view, state.theme) ? "Ẩn" : "Hiển thị"}
                  </Button>
                </div>
                {view !== "minimal" && (
                  <WidgetPreview state={state} observation={observation} view={view} />
                )}
              </Card>
            ))}
            {(["ORDER", "CHAOS"] as const).map((team) => (
              <Card className="operator-card" key={team}>
                <div>
                  <h3>Nhà lính {team === "ORDER" ? state.theme.blueName : state.theme.redName}</h3>
                  <Button
                    disabled={!available}
                    aria-pressed={control.inhibitors === team}
                    onClick={() => inhibitor(team)}
                  >
                    {control.inhibitors === team ? "Ẩn timer" : "Hiển thị timer"}
                  </Button>
                </div>
                <WidgetPreview
                  state={state}
                  observation={observation}
                  view="normal"
                  inhibitors={team}
                />
              </Card>
            ))}
          </div>
          <label className="layout-choice">
            Layout
            <NativeSelect
              aria-label="Layout tuyển thủ đang phát"
              disabled={!connected}
              value={state.theme.playerCameras === false ? "expanded" : "camera"}
              onChange={(e) =>
                send({
                  type: "theme",
                  value: {
                    ...state.theme,
                    playerCameras: e.target.value === "camera",
                  },
                })
              }
            >
              <option value="expanded">Không cam</option>
              <option value="camera">Có cam</option>
            </NativeSelect>
          </label>
          <details className="graphics-controls">
            <summary>Đồ họa tự động</summary>
            <div>
              {Object.entries(graphicsLabels).map(([key, label]) => (
                <label key={key}>
                  <Input
                    type="checkbox"
                    checked={graphicEnabled(state.theme, key as GraphicKey)}
                    disabled={!connected}
                    onChange={(e) =>
                      send({
                        type: "ingameGraphic",
                        key: key as GraphicKey,
                        value: e.target.checked,
                      })
                    }
                  />
                  {label}
                </label>
              ))}
            </div>
          </details>
          <div className="config-actions">
            <Button
              disabled={!connected}
              onClick={() => send({ type: "broadcastInhibitors", value: "auto" })}
              aria-pressed={control.inhibitors === "auto"}
            >
              Nhà lính tự động
            </Button>
            <Button
              disabled={!connected}
              onClick={() => send({ type: "broadcastInhibitors", value: "off" })}
            >
              Ẩn timer nhà lính
            </Button>
          </div>
        </div>
      </div>
    </section>
  );
}
