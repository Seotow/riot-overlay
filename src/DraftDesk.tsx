import { NativeSelect } from "./components/ui/native-select";
import { Button } from "./components/ui/button";
import { Card } from "./components/ui/card";
import { Input } from "./components/ui/input";
import { useState } from "react";
import { catalog } from "../shared/assets";
import { draftCatalog } from "../shared/draft-assets";
import {
  draftSchema,
  draftTurns,
  emptyDraft,
  lockDraft,
  undoDraft,
  type DraftState,
} from "../shared/draft";
import { draftFixture } from "../shared/reference";
import type { Command, State } from "../shared/schema";

const url = "/overlay?scene=draft";
export function DraftDesk({
  state,
  send,
  connected,
}: {
  state: State;
  send: (c: Command) => void;
  connected: boolean;
}) {
  const d = state.draft ?? emptyDraft();
  const [message, setMessage] = useState("");
  const turn = draftTurns[d.step];
  const update = (value: DraftState) => {
    const result = draftSchema.safeParse(value);
    if (!result.success) {
      setMessage(result.error.issues[0].message);
      return;
    }
    send({ type: "draftState", value: result.data });
    setMessage("");
  };
  const used = new Set(d.actions.slice(0, d.step).filter(Boolean));
  return (
    <section className="draft-desk">
      <div className="section-heading">
        <div>
          <h2>Cấm chọn</h2>
          <p>
            {d.source === "reference"
              ? "BỘ MẪU UI , Không phải dữ liệu live"
              : "NHẬP TAY , Nguồn cấm chọn live chưa được kiểm chứng"}
          </p>
        </div>
        <a className="button secondary" href={url} target="_blank" rel="noreferrer">
          Mở overlay OBS ↗
        </a>
      </div>
      <div className="program-monitor">
        <iframe title="Preview cấm chọn OBS" src={url} />
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
                value: {
                  ...state.theme,
                  draftLayout: e.target.value as "broadcast" | "simple",
                },
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
            onClick={() =>
              navigator.clipboard
                .writeText(location.origin + url)
                .then(() => setMessage("Đã copy URL OBS"))
                .catch(() => setMessage(location.origin + url))
            }
          >
            Copy URL OBS
          </Button>
          <a className="button secondary" href="/?page=studio">
            Đến in-game →
          </a>
        </div>
        {state.mockVisible && (
          <p role="alert">
            Mock đang bật. Bấm “Đưa cấm chọn lên chương trình” để preview dùng dữ liệu bên dưới.
          </p>
        )}
        <div className="draft-controls">
          <Card className="panel">
            <h3>
              {turn
                ? `Lượt ${d.step + 1}/20 , ${turn[0] ? state.theme.redName : state.theme.blueName} , ${turn[1] === "ban" ? "CẤM" : "CHỌN"} ${turn[2] + 1}`
                : "Đội hình hoàn tất"}
            </h3>
            <label>
              Tướng đang hover
              <NativeSelect
                aria-label="Tướng đang hover"
                value={d.hover ?? ""}
                disabled={!turn}
                onChange={(e) =>
                  update({
                    ...d,
                    source: "manual",
                    hover: e.target.value || null,
                  })
                }
              >
                <option value="">Chưa hover / bỏ lượt</option>
                {Object.entries(draftCatalog.champions)
                  .sort(([, a], [, b]) => a.name.localeCompare(b.name))
                  .map(([id, c]) => (
                    <option value={id} disabled={used.has(id)} key={id}>
                      {c.name}
                    </option>
                  ))}
              </NativeSelect>
            </label>
            <div className="config-actions">
              <Button
                disabled={!turn || !d.hover}
                onClick={() => {
                  try {
                    update(lockDraft(d));
                  } catch {
                    setMessage("Tướng đã được cấm/chọn.");
                  }
                }}
              >
                Khóa & lượt tiếp
              </Button>
              <Button
                disabled={!turn}
                onClick={() =>
                  update({
                    ...d,
                    source: "manual",
                    step: d.step + 1,
                    hover: null,
                    deadline: null,
                  })
                }
              >
                Bỏ lượt
              </Button>
              <Button disabled={!d.step} onClick={() => update(undoDraft(d))}>
                Lùi một lượt
              </Button>
            </div>
            <label>
              Thời gian mỗi lượt (giây)
              <Input
                type="number"
                min="5"
                max="120"
                value={d.duration}
                onChange={(e) =>
                  update({
                    ...d,
                    duration: Number(e.target.value),
                    deadline: null,
                  })
                }
              />
            </label>
            <div className="config-actions">
              <Button
                disabled={!turn}
                onClick={() => update({ ...d, deadline: Date.now() + d.duration * 1000 })}
              >
                Bắt đầu timer
              </Button>
              <Button onClick={() => update({ ...d, deadline: null })}>Ẩn timer</Button>
            </div>
            <p>Timer về 0 sẽ chờ khóa tay. Bỏ lượt giữ ô trống.</p>
            <label>
              Patch hiển thị
              <Input
                value={d.patch}
                maxLength={20}
                onChange={(e) => update({ ...d, patch: e.target.value })}
              />
            </label>
          </Card>
          {[0, 1].map((side) => (
            <Card className="panel" key={side}>
              <h3>{side ? state.theme.redName : state.theme.blueName}</h3>
              <label>
                HLV
                <Input
                  aria-label={`HLV ${side ? "đỏ" : "xanh"}`}
                  value={d.coaches[side]}
                  maxLength={40}
                  onChange={(e) => {
                    const coaches = [...d.coaches];
                    coaches[side] = e.target.value;
                    update({ ...d, coaches });
                  }}
                />
              </label>
              {Array.from({ length: 5 }, (_, i) => (
                <div className="draft-player-config" key={i}>
                  <label>
                    {["TOP", "JUNGLE", "MID", "BOT", "SUPPORT"][i]}
                    <Input
                      aria-label={`Tên ${side ? "R" : "B"}${i + 1}`}
                      maxLength={30}
                      value={d.names[side * 5 + i]}
                      onChange={(e) => {
                        const names = [...d.names];
                        names[side * 5 + i] = e.target.value;
                        update({ ...d, names });
                      }}
                    />
                  </label>
                  <label>
                    Lượt chọn
                    <NativeSelect
                      aria-label={`Vị trí ${side ? "R" : "B"}${i + 1}`}
                      value={d.order[side][i]}
                      onChange={(e) => {
                        const order: DraftState["order"] = [[...d.order[0]], [...d.order[1]]];
                        const other = order[side].indexOf(Number(e.target.value));
                        [order[side][i], order[side][other]] = [order[side][other], order[side][i]];
                        update({ ...d, order });
                      }}
                    >
                      {[0, 1, 2, 3, 4].map((n) => (
                        <option value={n} key={n}>
                          {side ? "R" : "B"}
                          {n + 1}
                        </option>
                      ))}
                    </NativeSelect>
                  </label>
                </div>
              ))}
            </Card>
          ))}
        </div>
        <details>
          <summary>Bộ mẫu và lưu phiên cấm chọn</summary>
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
                update(sample);
                send({ type: "mockVisible", value: false });
              }}
            >
              Nạp ảnh mẫu , UI test
            </Button>
            <Button
              onClick={() =>
                update({
                  ...emptyDraft(),
                  names: d.names,
                  coaches: d.coaches,
                  patch: d.patch,
                })
              }
            >
              Xóa lượt cấm/chọn
            </Button>
            <Button
              onClick={() => {
                const link = document.createElement("a");
                link.href = URL.createObjectURL(
                  new Blob([JSON.stringify(d, null, 2)], {
                    type: "application/json",
                  }),
                );
                link.download = "draft-session.json";
                link.click();
                URL.revokeObjectURL(link.href);
              }}
            >
              Export phiên
            </Button>
            <label className="button secondary">
              Import phiên
              <Input
                type="file"
                accept=".json"
                onChange={async (e) => {
                  const f = e.target.files?.[0];
                  if (!f) return;
                  if (f.size > 30000) {
                    setMessage("File quá lớn");
                    return;
                  }
                  try {
                    update(draftSchema.parse(JSON.parse(await f.text())));
                  } catch {
                    setMessage("Phiên cấm chọn không hợp lệ");
                  }
                  e.target.value = "";
                }}
              />
            </label>
          </div>
        </details>
      </fieldset>
      <p role="status">{message}</p>
    </section>
  );
}
