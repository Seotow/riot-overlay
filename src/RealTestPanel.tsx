import { NativeSelect } from "./components/ui/native-select";
import { Button } from "./components/ui/button";
import { useEffect, useState } from "react";
import type { Command, State } from "../shared/schema";
import {
  rehearsalButtons,
  dragonTypes,
  type RehearsalKind,
  type RehearsalVariant,
} from "../shared/rehearsal";
const dragonLabels: Record<string, string> = {
  earth: "Rồng đất",
  fire: "Rồng lửa",
  water: "Rồng nước",
  air: "Rồng gió",
  hextech: "Rồng Hextech",
  chemtech: "Rồng Hóa kỹ",
  elder: "Rồng Ngàn Tuổi",
};
const groups: Array<{
  id: string;
  label: string;
  options: Array<{
    value: string;
    label: string;
    kind: RehearsalKind;
    variant?: RehearsalVariant;
  }>;
}> = [
  {
    id: "timers",
    label: "Timer mục tiêu",
    options: [
      { value: "recorded", label: "Theo bản ghi thật", kind: "timers" },
      {
        value: "preview",
        label: "Chọn loại mục tiêu , giả lập UI",
        kind: "timers",
        variant: { pit: "GRUB", dragon: "earth" },
      },
    ],
  },
  {
    id: "dragon",
    label: "Hạ rồng",
    options: [
      { value: "recorded", label: "Theo bản ghi thật", kind: "dragon" },
      ...dragonTypes.map((dragon) => ({
        value: dragon,
        label: dragonLabels[dragon],
        kind: "dragon" as const,
        variant: { dragon },
      })),
    ],
  },
  {
    id: "soul",
    label: "Linh hồn rồng",
    options: [
      { value: "recorded", label: "Theo bản ghi thật", kind: "soul" },
      ...dragonTypes
        .filter((d) => d !== "elder")
        .map((dragon) => ({
          value: dragon,
          label: dragonLabels[dragon],
          kind: "soul" as const,
          variant: { dragon },
        })),
    ],
  },
  {
    id: "baron",
    label: "Baron Power Play",
    options: [
      { value: "recorded", label: "Theo bản ghi thật", kind: "baron" },
      ...(["baron", "elder", "both"] as const).map((buffs) => ({
        value: buffs,
        label: {
          baron: "Chỉ Baron , 180s",
          elder: "Chỉ Elder , 150s",
          both: "Baron + Elder",
        }[buffs],
        kind: "baron" as const,
        variant: { buffs },
      })),
    ],
  },
  {
    id: "tower",
    label: "Phá trụ",
    options: [
      { value: "recorded", label: "Theo bản ghi thật", kind: "tower" },
      {
        value: "first",
        label: "Trụ đầu",
        kind: "tower",
        variant: { tower: "first" },
      },
      {
        value: "normal",
        label: "Trụ thường",
        kind: "tower",
        variant: { tower: "normal" },
      },
    ],
  },
  {
    id: "inhibitor",
    label: "Timer nhà lính",
    options: [
      { value: "recorded", label: "Theo bản ghi thật", kind: "inhibitor" },
      {
        value: "ORDER",
        label: "Đội xanh , đường giữa",
        kind: "inhibitor",
        variant: { inhibitorTeam: "ORDER" },
      },
      {
        value: "CHAOS",
        label: "Đội đỏ , đường giữa",
        kind: "inhibitor",
        variant: { inhibitorTeam: "CHAOS" },
      },
    ],
  },
  {
    id: "quest",
    label: "Hoàn thành quest",
    options: (["Top", "Jungle", "Mid", "Bot", "Support"] as const).map(
      (role) => ({
        value: role,
        label: role.toUpperCase(),
        kind: ("quest" + role) as RehearsalKind,
      }),
    ),
  },
];
const grouped = new Set([
  "timers",
  "dragon",
  "soul",
  "baron",
  "tower",
  "inhibitor",
  "inhibitorBlue",
  "inhibitorRed",
  "inhibitorRespawn",
  "questTop",
  "questJungle",
  "questMid",
  "questBot",
  "questSupport",
]);
export function RealTestPanel({
  state,
  send,
}: {
  state: State;
  send: (cmd: Command) => void;
}) {
  const [captures, setCaptures] = useState<
    Array<{ id: string; frames: number; hasState: boolean }>
  >([]);
  const [buttons, setButtons] = useState<
    Array<{ kind: RehearsalKind; available: boolean; reason: string }>
  >([]);
  const [id, setId] = useState("");
  const [error, setError] = useState("");
  const [selections, setSelections] = useState<Record<string, string>>({});
  useEffect(() => {
    let stopped = false;
    void fetch("/api/captures")
      .then((r) => {
        if (!r.ok) throw Error();
        return r.json();
      })
      .then((data) => {
        if (stopped) return;
        const records = data
          .filter((c: any) => c.hasState)
          .sort((a: any, b: any) => b.frames - a.frames);
        setCaptures(records);
        setId(records[0]?.id ?? "");
        if (state.provider !== "recording" && records[0])
          send({ type: "captureLoad", id: records[0].id });
      })
      .catch(
        () => !stopped && setError("Không tải được danh sách bản ghi thật."),
      );
    return () => {
      stopped = true;
    };
  }, []);
  useEffect(() => {
    let stopped = false;
    const poll = () =>
      fetch("/api/rehearsal")
        .then((r) => {
          if (!r.ok) throw Error();
          return r.json();
        })
        .then((data) => {
          if (!stopped) {
            setButtons(data.buttons);
            setError("");
          }
        })
        .catch(() => !stopped && setError("Không lấy được khả năng bản ghi."));
    void poll();
    const timer = setInterval(poll, 1500);
    return () => {
      stopped = true;
      clearInterval(timer);
    };
  }, []);
  const ready = state.provider === "recording" && !state.mockVisible;
  return (
    <section className="real-test-panel">
      <div className="eyebrow">PHÒNG THỬ , SNAPSHOT THẬT</div>
      <h3>Thử toàn bộ đồ họa</h3>
      <p>
        Nền là snapshot thật. Chọn “Theo bản ghi thật” để xem dữ liệu đã ghi;
        các loại chọn riêng là giả lập đồ họa, có nhãn rõ trên OBS và không sửa
        bản ghi hay nguồn live.
      </p>
      <label className="field">
        Bộ dữ liệu thật
        <NativeSelect
          aria-label="Bộ dữ liệu thật"
          value={id}
          onChange={(e) => setId(e.target.value)}
        >
          {captures.map((c) => (
            <option key={c.id} value={c.id}>
              {c.id} , {c.frames} frame
            </option>
          ))}
        </NativeSelect>
      </label>
      <Button disabled={!id} onClick={() => send({ type: "captureLoad", id })}>
        Mở bộ dữ liệu thật
      </Button>
      {!ready && (
        <p role="status">
          Đang chờ bản ghi thật. Không bật demo; hãy mở bộ dữ liệu phía trên.
        </p>
      )}
      {error && <p role="alert">{error}</p>}
      <div className="event-buttons">
        {groups.map((group) => {
          const choice =
            group.options.find((o) => o.value === selections[group.id]) ??
            group.options[0];
          const selected =
            group.id === "timers" && choice.variant
              ? {
                  ...choice,
                  variant: {
                    pit: (selections.pit ?? "GRUB") as
                      "GRUB" | "HERALD" | "BARON",
                    dragon: (selections.dragonType ??
                      "earth") as (typeof dragonTypes)[number],
                  },
                }
              : choice;
          const enabled =
            ready &&
            buttons.find((b) => b.kind === selected.kind)?.available === true;
          return (
            <div className="rehearsal-group" key={group.id}>
              <label className="field">
                {group.label}
                <NativeSelect
                  aria-label={group.label + " , loại"}
                  value={selected.value}
                  onChange={(e) =>
                    setSelections((s) => ({ ...s, [group.id]: e.target.value }))
                  }
                >
                  {group.options.map((o) => (
                    <option key={o.value} value={o.value}>
                      {o.label}
                    </option>
                  ))}
                </NativeSelect>
              </label>
              {group.id === "timers" && (
                <>
                  <label className="field">
                    Hang Baron
                    <NativeSelect
                      aria-label="Hang Baron , loại"
                      value={selections.pit ?? "GRUB"}
                      onChange={(e) =>
                        setSelections((s) => ({
                          ...s,
                          timers: "preview",
                          pit: e.target.value,
                        }))
                      }
                    >
                      <option value="GRUB">Sâu hư không</option>
                      <option value="HERALD">Sứ giả khe nứt</option>
                      <option value="BARON">Baron Nashor</option>
                    </NativeSelect>
                  </label>
                  <label className="field">
                    Hang rồng
                    <NativeSelect
                      aria-label="Hang rồng , loại"
                      value={selections.dragonType ?? "earth"}
                      onChange={(e) =>
                        setSelections((s) => ({
                          ...s,
                          timers: "preview",
                          dragonType: e.target.value,
                        }))
                      }
                    >
                      {dragonTypes.map((d) => (
                        <option key={d} value={d}>
                          {dragonLabels[d]}
                        </option>
                      ))}
                    </NativeSelect>
                  </label>
                </>
              )}
              <Button
                disabled={!enabled}
                onClick={() =>
                  send({
                    type: "rehearsal",
                    value: selected.kind,
                    variant: selected.variant,
                  })
                }
              >
                <div>
                  <b>{group.label}</b>
                  <small>
                    {selected.variant
                      ? "Giả lập UI , nền snapshot thật"
                      : "Sự kiện / dữ liệu trong bản ghi"}
                  </small>
                </div>
                <span>▶</span>
              </Button>
            </div>
          );
        })}
        {rehearsalButtons
          .filter((b) => !grouped.has(b.kind))
          .map((b) => {
            const capability = buttons.find((c) => c.kind === b.kind);
            const enabled = ready && capability?.available === true;
            return (
              <Button
                key={b.kind}
                disabled={!enabled}
                title={
                  enabled
                    ? "Mở snapshot thật phù hợp"
                    : (capability?.reason ?? "Đang đọc bản ghi")
                }
                onClick={() => send({ type: "rehearsal", value: b.kind })}
              >
                <div>
                  <b>{b.label}</b>
                  <small>
                    {enabled
                      ? "Dữ liệu thật , kích hoạt thử"
                      : (capability?.reason ?? "Đang đọc bản ghi")}
                  </small>
                </div>
                <span>{enabled ? "▶" : "Chưa có"}</span>
              </Button>
            );
          })}
      </div>
      <div className="divider" />
      <Button
        disabled={!ready}
        onClick={() =>
          send({ type: "captureControl", playing: true, speed: 1 })
        }
      >
        Phát tiếp timer / bản ghi
      </Button>
      <Button
        disabled={!ready}
        onClick={() => send({ type: "captureControl", playing: false })}
      >
        Tạm dừng
      </Button>
      <p className="muted">
        Baron Power Play bắt đầu +1.500 G rồi cộng biến động chênh lệch vàng
        ròng hai đội sau khi nhận buff, đây là số suy ra; thời lượng mặc định
        Baron 180s, Elder 150s, nhà lính 300s. Biến thể UI không chứng minh
        nguồn có loại mục tiêu/buff đó. Nhà lính chỉ hiện một đội mỗi lần; không
        phát toast hồi sinh. Rune cần đủ perk ID cho 10 người; damage bị khóa
        nếu nguồn chưa hỗ trợ.
      </p>
    </section>
  );
}
