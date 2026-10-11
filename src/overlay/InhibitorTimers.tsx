import type { IngameSample } from "../../shared/observer";
import type { Theme } from "../../shared/schema";

const lanes = ["top", "mid", "bot"] as const;
const names = { top: "TRÊN", mid: "GIỮA", bot: "DƯỚI" };
export function InhibitorTimers({
  sample,
  time,
  theme,
  team,
  preview,
}: {
  sample: IngameSample;
  time: number | null;
  theme: Theme;
  team?: "ORDER" | "CHAOS";
  preview?: { team: "ORDER" | "CHAOS"; endsAt: number };
}) {
  const candidates = (["ORDER", "CHAOS"] as const).filter(
    (t) =>
      (!team || team === t) &&
      sample.inhibitors?.value?.some(
        (i) => i.team === t && (time == null || i.respawnsAt > time),
      ),
  );
  // One panel at a time, prefer the team whose next inhibitor respawns first.
  const nextRespawn = (t: string) =>
    Math.min(
      ...(sample.inhibitors?.value ?? [])
        .filter((i) => i.team === t && (time == null || i.respawnsAt > time))
        .map((i) => i.respawnsAt),
    );
  const visibleTeams = preview
    ? time == null || preview.endsAt > time
      ? [preview.team]
      : []
    : candidates.sort((a, b) => nextRespawn(a) - nextRespawn(b)).slice(0, 1);
  if (!visibleTeams.length) return null;
  return (
    <aside
      className="live-inhibitors"
      aria-label="Hồi sinh nhà lính"
      data-region="inhibitors"
    >
      {visibleTeams.map((t) => (
        <section
          key={t}
          className={t === "ORDER" ? "blue" : "red"}
          data-team={t}
        >
          <div className="inhibitor-team">
            <i className="inhibitor-emblem" aria-hidden="true" />
            <b>{t === "ORDER" ? theme.blueName : theme.redName}</b>
            <small>NHÀ LÍNH</small>
          </div>
          <div className="inhibitor-lanes">
            {lanes.map((lane) => {
              const down = preview
                ? lane === "mid"
                  ? { respawnsAt: preview.endsAt }
                  : undefined
                : sample.inhibitors?.value?.find(
                    (i) => i.team === t && i.lane === lane,
                  );
              const remaining =
                down && time != null ? down.respawnsAt - time : null;
              const active = remaining != null && remaining > 0;
              const seconds = active ? Math.ceil(remaining) : 0;
              return (
                <div
                  key={lane}
                  data-lane={lane}
                  className={active ? "destroyed" : "standing"}
                  title={`${names[lane]} · ${active ? "Đang hồi sinh" : sample.inhibitors?.value == null ? "Chưa có dữ liệu" : "Không có timer hồi sinh"}`}
                >
                  <i
                    className={`inhibitor-lane-icon ${lane}`}
                    aria-label={names[lane]}
                    style={{
                      maskImage: `url(/broadcast/glyphs/role-${lane}.svg)`,
                      WebkitMaskImage: `url(/broadcast/glyphs/role-${lane}.svg)`,
                    }}
                  />
                  {active ? (
                    <time>
                      {Math.floor(seconds / 60)}:
                      {(seconds % 60).toString().padStart(2, "0")}
                    </time>
                  ) : (
                    <span>
                      {sample.inhibitors?.value == null ? "—" : "---"}
                    </span>
                  )}
                </div>
              );
            })}
          </div>
        </section>
      ))}
    </aside>
  );
}
