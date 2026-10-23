import { useEffect, useState } from "react";
import { Button } from "../components/ui/button";
import { Input } from "../components/ui/input";
import { NativeSelect } from "../components/ui/native-select";
import {
  LOGO_MAX_BYTES,
  defaultValorantMatchConfig,
  valorantMatchConfigSchema,
  type LogoSlot,
  type ValorantConfigView,
  type ValorantMatchConfig as Config,
} from "../../shared/valorant-config";
import { useValorant } from "../lib/useValorant";

const errors: Record<string, string> = {
  "invalid-config": "Cấu hình không hợp lệ: kiểm tra tên, mã đội và tỉ số.",
  "invalid-logo": "Logo phải là PNG/JPEG/WebP hợp lệ, tối đa 350KB.",
};
const readFile = (file: File) =>
  new Promise<string>((ok, fail) => {
    const reader = new FileReader();
    reader.onload = () => ok(String(reader.result));
    reader.onerror = () => fail(reader.error);
    reader.readAsDataURL(file);
  });

type Uploads = Partial<Record<LogoSlot, string>>;
type SaveResult = { ok: true; applied: boolean } | { ok: false; error: string };

function LogoField({
  label,
  shown,
  onPick,
  onClear,
}: {
  label: string;
  shown: string;
  onPick: (file: File) => void;
  onClear: () => void;
}) {
  return (
    <div className="val-logo">
      <label>
        {label}
        <Input
          type="file"
          accept="image/png,image/jpeg,image/webp"
          onChange={(e) => {
            const file = e.target.files?.[0];
            e.target.value = "";
            if (file) onPick(file);
          }}
        />
      </label>
      {shown && <img className="config-logo" src={shown} alt={label} />}
      <Button type="button" onClick={onClear}>
        Bỏ logo
      </Button>
    </div>
  );
}

export function ValorantMatchConfig({
  view,
  save,
}: {
  view: ValorantConfigView | null;
  save: (body: { config: Config; uploads: Uploads }) => Promise<SaveResult>;
}) {
  const [draft, setDraft] = useState<Config>(defaultValorantMatchConfig);
  const [uploads, setUploads] = useState<Uploads>({});
  const [message, setMessage] = useState("");
  const { frame } = useValorant(2000);
  const loaded = view?.config;
  useEffect(() => {
    if (loaded) {
      setDraft(loaded);
      setUploads({});
    }
  }, [loaded]);
  const change = (next: Config) => {
    setDraft(next);
    setMessage("Có thay đổi chưa lưu.");
  };
  const team = (i: 0 | 1, patch: Partial<Config["teams"][0]>) => {
    const teams = [...draft.teams] as Config["teams"];
    teams[i] = { ...teams[i], ...patch };
    change({ ...draft, teams });
  };
  const pick = async (slot: LogoSlot, file: File) => {
    if (file.size > LOGO_MAX_BYTES || !/^image\/(png|jpeg|webp)$/.test(file.type)) {
      setMessage(errors["invalid-logo"]);
      return;
    }
    const data = await readFile(file);
    setUploads((u) => ({ ...u, [slot]: data }));
    setMessage("Có thay đổi chưa lưu.");
  };
  const clear = (slot: LogoSlot) => {
    setUploads((u) => {
      const rest = { ...u };
      delete rest[slot];
      return rest;
    });
    if (slot === "left") team(0, { logo: "" });
    else if (slot === "right") team(1, { logo: "" });
    else change({ ...draft, tournament: { ...draft.tournament, logo: "" } });
  };
  const setNeeded = (needed: number) =>
    change({
      ...draft,
      series: {
        needed,
        wonLeft: Math.min(draft.series.wonLeft, needed),
        wonRight: Math.min(draft.series.wonRight, needed),
      },
    });
  const setOverride = (index: number, patch: Partial<Config["nameOverrides"][0]>) =>
    change({
      ...draft,
      nameOverrides: draft.nameOverrides.map((r, j) => (j === index ? { ...r, ...patch } : r)),
    });
  const setMap = (index: number, patch: Partial<Config["mapInfo"]["maps"][0]>) =>
    change({
      ...draft,
      mapInfo: {
        ...draft.mapInfo,
        maps: draft.mapInfo.maps.map((m, j) => (j === index ? { ...m, ...patch } : m)),
      },
    });
  const players = (frame?.teams.flatMap((t) => t.players.map((p) => p.name.value)) ?? []).filter(
    (n): n is string => !!n,
  );
  // Logo đã lưu chỉ hiện khi tên file chưa bị đổi; logo vừa chọn hiện ngay từ bản xem trước.
  const shownLogo = (slot: LogoSlot) => {
    if (uploads[slot]) return uploads[slot]!;
    const name =
      slot === "tournament" ? draft.tournament.logo : draft.teams[slot === "left" ? 0 : 1].logo;
    const saved =
      slot === "tournament" ? loaded?.tournament.logo : loaded?.teams[slot === "left" ? 0 : 1].logo;
    return name && name === saved ? (view?.logoUrls[slot] ?? "") : "";
  };
  const submit = async () => {
    const parsed = valorantMatchConfigSchema.safeParse(draft);
    if (!parsed.success) {
      setMessage(errors["invalid-config"]);
      return;
    }
    setMessage("Đang lưu…");
    const result = await save({ config: parsed.data, uploads });
    setMessage(
      result.ok
        ? result.applied
          ? "Đã lưu và áp dụng cho trận đang chạy."
          : "Đã lưu; sẽ áp dụng khi Client kết nối."
        : (errors[result.error] ?? "Không lưu được cấu hình."),
    );
  };
  return (
    <section className="val-page val-config">
      <div className="config-grid">
        {([0, 1] as const).map((i) => {
          const slot = i === 0 ? "left" : "right";
          return (
            <fieldset key={i}>
              <legend>Đội {i === 0 ? "trái" : "phải"}</legend>
              <label>
                Tên đội
                <Input
                  maxLength={40}
                  value={draft.teams[i].name}
                  onChange={(e) => team(i, { name: e.target.value })}
                />
              </label>
              <label>
                Mã đội (tối đa 5 ký tự)
                <Input
                  maxLength={5}
                  value={draft.teams[i].tricode}
                  onChange={(e) => team(i, { tricode: e.target.value })}
                />
              </label>
              <label>
                Tỉ số loạt trận
                <Input
                  type="number"
                  min="0"
                  max={draft.series.needed}
                  value={i === 0 ? draft.series.wonLeft : draft.series.wonRight}
                  onChange={(e) =>
                    change({
                      ...draft,
                      series: {
                        ...draft.series,
                        [i === 0 ? "wonLeft" : "wonRight"]: Number(e.target.value),
                      },
                    })
                  }
                />
              </label>
              <LogoField
                label="Logo đội"
                shown={shownLogo(slot)}
                onPick={(f) => void pick(slot, f)}
                onClear={() => clear(slot)}
              />
            </fieldset>
          );
        })}
        <fieldset>
          <legend>Giải đấu</legend>
          <label>
            Tên giải
            <Input
              maxLength={80}
              value={draft.tournament.name}
              onChange={(e) =>
                change({ ...draft, tournament: { ...draft.tournament, name: e.target.value } })
              }
            />
          </label>
          <label>
            Thể thức
            <NativeSelect
              value={draft.series.needed}
              onChange={(e) => setNeeded(Number(e.target.value))}
            >
              {Array.from({ length: 9 }, (_, i) => (
                <option key={i} value={i + 1}>
                  BO{i * 2 + 1}, {i + 1} ô thắng
                </option>
              ))}
            </NativeSelect>
          </label>
          <LogoField
            label="Logo giải"
            shown={shownLogo("tournament")}
            onPick={(f) => void pick("tournament", f)}
            onClear={() => clear("tournament")}
          />
        </fieldset>
        <fieldset>
          <legend>Dải map (overlay in-game)</legend>
          <label className="val-check">
            <input
              type="checkbox"
              checked={draft.mapInfo.enabled}
              onChange={(e) =>
                change({ ...draft, mapInfo: { ...draft.mapInfo, enabled: e.target.checked } })
              }
            />{" "}
            Hiện dải map (tắt thì ẩn cả cụm)
          </label>
          {draft.mapInfo.maps.map((m, index) => (
            <div className="val-override" key={index}>
              <Input
                list="val-maps"
                placeholder={index === 0 ? "Map hiện tại" : "Map kế tiếp"}
                maxLength={40}
                value={m.map}
                onChange={(e) => setMap(index, { map: e.target.value })}
              />
              <NativeSelect
                value={m.pickedBy}
                onChange={(e) =>
                  setMap(index, { pickedBy: e.target.value as "left" | "right" | "none" })
                }
                aria-label="Đội chọn map"
              >
                <option value="none">Không logo</option>
                <option value="left">Đội trái chọn</option>
                <option value="right">Đội phải chọn</option>
              </NativeSelect>
              <Button
                type="button"
                onClick={() =>
                  change({
                    ...draft,
                    mapInfo: {
                      ...draft.mapInfo,
                      maps: draft.mapInfo.maps.filter((_, j) => j !== index),
                    },
                  })
                }
              >
                Xóa
              </Button>
            </div>
          ))}
          <datalist id="val-maps">
            {[
              "Ascent",
              "Bind",
              "Haven",
              "Split",
              "Lotus",
              "Sunset",
              "Icebox",
              "Breeze",
              "Fracture",
              "Pearl",
              "Abyss",
              "Corrode",
            ].map((name) => (
              <option key={name} value={name} />
            ))}
          </datalist>
          <Button
            type="button"
            disabled={draft.mapInfo.maps.length >= 5}
            onClick={() =>
              change({
                ...draft,
                mapInfo: {
                  ...draft.mapInfo,
                  maps: [...draft.mapInfo.maps, { map: "", pickedBy: "none" }],
                },
              })
            }
          >
            Thêm map (ô đầu = hiện tại)
          </Button>
          <label className="val-check">
            <input
              type="checkbox"
              checked={draft.watermarkText}
              onChange={(e) => change({ ...draft, watermarkText: e.target.checked })}
            />{" "}
            Hiện tên giải ở góc phải thay watermark (cần key Spectra Plus)
          </label>
        </fieldset>
        <fieldset>
          <legend>Tên thay thế người chơi</legend>
          {draft.nameOverrides.map((row, index) => (
            <div className="val-override" key={index}>
              <Input
                list="val-players"
                placeholder="Tên#Tag trong game"
                maxLength={60}
                value={row.player}
                onChange={(e) => setOverride(index, { player: e.target.value })}
              />
              <Input
                placeholder="Tên hiển thị"
                maxLength={40}
                value={row.display}
                onChange={(e) => setOverride(index, { display: e.target.value })}
              />
              <Button
                type="button"
                onClick={() =>
                  change({
                    ...draft,
                    nameOverrides: draft.nameOverrides.filter((_, j) => j !== index),
                  })
                }
              >
                Xóa
              </Button>
            </div>
          ))}
          <datalist id="val-players">
            {players.map((p) => (
              <option key={p} value={p} />
            ))}
          </datalist>
          <Button
            type="button"
            disabled={draft.nameOverrides.length >= 20}
            onClick={() =>
              change({
                ...draft,
                nameOverrides: [...draft.nameOverrides, { player: "", display: "" }],
              })
            }
          >
            Thêm người chơi
          </Button>
        </fieldset>
      </div>
      <div className="val-row">
        <Button onClick={() => void submit()}>Lưu và áp dụng</Button>
        <span role="status">{message}</span>
      </div>
    </section>
  );
}
