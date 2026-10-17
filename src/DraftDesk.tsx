import { NativeSelect } from "./components/ui/native-select";
import { Button } from "./components/ui/button";
import { Card } from "./components/ui/card";
import { Input } from "./components/ui/input";
import { useEffect, useMemo, useRef, useState } from "react";
import { catalog } from "../shared/assets";
import { draftCatalog, draftChampion } from "../shared/draft-assets";
import { draftSchema, draftTurns, emptyDraft, type DraftState } from "../shared/draft";
import { draftFixture } from "../shared/reference";
import type { Command, State } from "../shared/schema";

const draftUrl = "/overlay?scene=draft";
const ingameUrl = "/overlay?scene=ingame";
const positions = ["TOP", "JUNGLE", "MID", "BOT", "SUPPORT"];
const roleKeys = ["top", "jungle", "mid", "bot", "support"];
const MAX_SERIES_GAMES = 4; // BO5 supports at most four earlier games.

const lcuLabel: Record<string, string> = {
  offline: "Chưa thấy LoL Client",
  idle: "LoL Client đang mở, chưa vào cấm chọn",
  "champ-select": "Đang nhận dữ liệu cấm chọn từ LCU",
  error: "Không đọc được LCU",
};

// Pick champions by name: the search shows the icon so the right champion is easy to choose.
function ChampionPicker({
  label,
  value,
  onChange,
}: {
  label: string;
  value: string[];
  onChange: (next: string[]) => void;
}) {
  const [query, setQuery] = useState("");
  const [open, setOpen] = useState(false);
  const box = useRef<HTMLDivElement>(null);
  // The result list floats over the page and closes on any click outside this picker.
  useEffect(() => {
    if (!open) return;
    const close = (e: MouseEvent) => {
      if (!box.current?.contains(e.target as Node)) setOpen(false);
    };
    document.addEventListener("mousedown", close);
    return () => document.removeEventListener("mousedown", close);
  }, [open]);
  const all = useMemo(
    () => Object.values(draftCatalog.champions).sort((a, b) => a.name.localeCompare(b.name)),
    [],
  );
  const text = query.trim().toLowerCase();
  const matches = text
    ? all
        .filter((c) => !value.includes(c.id) && c.name.toLowerCase().includes(text))
        .sort(
          (a, b) =>
            Number(b.name.toLowerCase().startsWith(text)) -
            Number(a.name.toLowerCase().startsWith(text)),
        )
        .slice(0, 6)
    : [];
  const full = value.length >= MAX_SERIES_GAMES;
  return (
    <div className="series-picker" ref={box}>
      <div className="series-chips">
        {value.map((id) => {
          const c = draftChampion(id);
          return (
            <button
              type="button"
              className="series-chip"
              key={id}
              title={`Xóa ${c?.name ?? id}`}
              aria-label={`Xóa ${c?.name ?? id}`}
              onClick={() => onChange(value.filter((v) => v !== id))}
            >
              {c && <img src={c.icon} alt="" />}
              <i aria-hidden="true">×</i>
            </button>
          );
        })}
      </div>
      <Input
        aria-label={label}
        placeholder={full ? "Đủ 4 tướng" : "Tìm tướng"}
        disabled={full}
        value={query}
        onFocus={() => setOpen(true)}
        onChange={(e) => {
          setQuery(e.target.value);
          setOpen(true);
        }}
        onKeyDown={(e) => {
          if (e.key === "Escape") setOpen(false);
          if (e.key === "Enter" && matches[0]) {
            onChange([...value, matches[0].id]);
            setQuery("");
            setOpen(false);
          }
        }}
      />
      {open && matches.length > 0 && (
        <ul className="series-results">
          {matches.map((c) => (
            <li key={c.id}>
              <button
                type="button"
                onClick={() => {
                  onChange([...value, c.id]);
                  setQuery("");
                  setOpen(false);
                }}
              >
                <img src={c.icon} alt="" />
                {c.name}
              </button>
            </li>
          ))}
        </ul>
      )}
    </div>
  );
}

export function DraftDesk({
  state,
  send,
  connected,
}: {
  state: State;
  send: (c: Command) => void;
  connected: boolean;
}) {
  const live = state.draft ?? emptyDraft();
  const [form, setForm] = useState<DraftState>(live);
  const [dirty, setDirty] = useState(false);
  const [message, setMessage] = useState("");
  const lcu = state.draftLcu;
  const edit = (value: Partial<DraftState>) => {
    setForm((current) => ({ ...current, ...value }));
    setDirty(true);
    setMessage("Có thay đổi chưa lưu.");
  };
  // Setup that arrives from elsewhere (swap sides, import) replaces an untouched form.
  useEffect(() => {
    if (!dirty) setForm(live);
  }, [live, dirty]);
  const send0 = (value: DraftState) => {
    const result = draftSchema.safeParse(value);
    if (!result.success) {
      setMessage(result.error.issues[0].message);
      return false;
    }
    send({ type: "draftState", value: result.data });
    return true;
  };
  // Only the setup is written; picks, bans, hover and timer always come from the LCU.
  const save = () => {
    const next: DraftState = {
      ...live,
      coaches: form.coaches,
      seriesBans: form.seriesBans,
    };
    if (send0(next)) {
      setDirty(false);
      setMessage("Đã lưu và đẩy lên view.");
    }
  };
  const swap = () => {
    send({ type: "swapSides" });
    setDirty(false);
    setMessage("Đã đổi bên.");
  };
  return (
    <section className="draft-desk">
      <div className="section-heading">
        <div>
          <h2>Cấm chọn</h2>
          <p>
            {live.source === "reference"
              ? "BỘ MẪU UI , Không phải dữ liệu live"
              : (lcuLabel[lcu?.status ?? "offline"] ?? lcuLabel.offline)}
          </p>
        </div>
        <a className="button secondary" href={draftUrl} target="_blank" rel="noreferrer">
          Mở overlay OBS ↗
        </a>
      </div>
      <div className="program-monitor">
        <iframe title="Preview cấm chọn OBS" src={draftUrl} />
      </div>
      <fieldset disabled={!connected}>
        <label className="draft-layout-selector">
          Layout cấm chọn
          <NativeSelect
            aria-label="Layout cấm chọn"
            value={state.theme.draftLayout ?? "broadcast"}
            onChange={(e) =>
              send({
                type: "theme",
                value: { ...state.theme, draftLayout: e.target.value as "broadcast" | "simple" },
              })
            }
          >
            <option value="broadcast">Cam tuyển thủ , dải picks phía dưới</option>
            <option value="simple">Simple , cam caster ở giữa</option>
          </NativeSelect>
        </label>
        <div className="config-actions">
          <Button
            onClick={() => {
              send({ type: "mockVisible", value: false });
              send({ type: "scene", value: "draft" });
            }}
          >
            Đưa cấm chọn lên chương trình
          </Button>
          <Button
            onClick={() => {
              send({ type: "mockVisible", value: false });
              send({ type: "scene", value: "ingame" });
            }}
          >
            Vào in-game (ẩn cấm chọn)
          </Button>
          <Button
            onClick={() => {
              send({ type: "mockVisible", value: false });
              send({ type: "scene", value: "auto" });
            }}
          >
            Tự động theo dữ liệu
          </Button>
          <Button type="button" onClick={swap}>
            Đổi bên xanh ↔ đỏ
          </Button>
        </div>
        <p className="draft-urls">
          OBS: <code>/overlay</code> tự nhận diện (trống → cấm chọn khi vào phòng cấm chọn → in-game
          khi có dữ liệu trận) · <code>{draftUrl}</code> luôn là cấm chọn · <code>{ingameUrl}</code>{" "}
          luôn là in-game.{" "}
          <Button
            type="button"
            onClick={() =>
              navigator.clipboard
                .writeText(location.origin + "/overlay")
                .then(() => setMessage("Đã copy URL OBS theo chương trình"))
                .catch(() => setMessage(location.origin + "/overlay"))
            }
          >
            Copy URL theo chương trình
          </Button>
        </p>
        {state.mockVisible && (
          <p role="alert">
            Mock đang bật. Bấm “Đưa cấm chọn lên chương trình” để preview dùng dữ liệu cấm chọn.
          </p>
        )}
        <Card className="panel series-ban-editor">
          <h3>HLV và Series Ban</h3>
          <p>
            Tướng bị cấm từ các ván trước vì đối thủ đã chọn. Tối đa {MAX_SERIES_GAMES} tướng mỗi ô
            (BO5). Hàng trên là bên trái, hàng dưới là bên phải.
          </p>
          {[0, 1].map((side) => (
            <div className="series-side" key={side}>
              <h4>{side ? state.theme.redName : state.theme.blueName}</h4>
              <label className="series-coach">
                HLV (để trống sẽ ẩn thẻ HLV)
                <Input
                  aria-label={`HLV ${side ? "đỏ" : "xanh"}`}
                  value={form.coaches[side]}
                  maxLength={40}
                  onChange={(e) => {
                    const coaches = [...form.coaches];
                    coaches[side] = e.target.value;
                    edit({ coaches });
                  }}
                />
              </label>
              <div className="series-row">
                {positions.map((position, i) => (
                  <div className="series-cell" key={position}>
                    <span
                      className="series-role"
                      title={position}
                      style={{
                        maskImage: `url(/broadcast/glyphs/role-${roleKeys[i]}.svg)`,
                        WebkitMaskImage: `url(/broadcast/glyphs/role-${roleKeys[i]}.svg)`,
                      }}
                    />
                    <ChampionPicker
                      label={`Series ban ${side ? "đỏ" : "xanh"} ${position}`}
                      value={form.seriesBans[side * 5 + i]}
                      onChange={(next) => {
                        const seriesBans = form.seriesBans.map((v) => [...v]);
                        seriesBans[side * 5 + i] = next;
                        edit({ seriesBans });
                      }}
                    />
                  </div>
                ))}
              </div>
            </div>
          ))}
        </Card>
        <div className="config-actions">
          <Button type="button" onClick={save} disabled={!dirty}>
            Lưu và đẩy lên view
          </Button>
          <Button
            type="button"
            onClick={() => {
              setForm({ ...form, seriesBans: emptyDraft().seriesBans });
              setDirty(true);
              setMessage("Đã xóa series ban, bấm lưu để áp dụng.");
            }}
          >
            Xóa series ban
          </Button>
        </div>
        <details>
          <summary>Bộ mẫu UI (chỉ để kiểm thử giao diện)</summary>
          <div className="config-actions">
            <Button
              onClick={() => {
                const sample = emptyDraft();
                sample.source = "reference";
                sample.names = [...draftFixture.names];
                sample.coaches = [draftFixture.blueCoach, draftFixture.redCoach];
                sample.patch = catalog.displayPatch;
                sample.step = 16;
                draftTurns.forEach(([side, kind, slot], i) => {
                  if (i < sample.step)
                    sample.actions[i] =
                      kind === "ban"
                        ? (side ? draftFixture.redBans : draftFixture.blueBans)[slot]
                        : draftFixture.picks[side * 5 + slot];
                });
                sample.hover = "Ezreal";
                send0(sample);
                send({ type: "mockVisible", value: false });
              }}
            >
              Nạp ảnh mẫu , UI test
            </Button>
            <Button
              onClick={() =>
                send0({
                  ...emptyDraft(),
                  names: live.names,
                  coaches: live.coaches,
                  patch: live.patch,
                  seriesBans: live.seriesBans,
                })
              }
            >
              Xóa lượt cấm/chọn
            </Button>
          </div>
        </details>
      </fieldset>
      <p role="status">{message}</p>
    </section>
  );
}
