import { useEffect, useMemo, useState, type CSSProperties } from "react";
import { draftChampion as champion } from "../../shared/draft-assets";
import { draftSlots, draftTurns, emptyDraft, type DraftState } from "../../shared/draft";
import type { Theme } from "../../shared/schema";

// The line runs from the source deadline with one CSS animation: it neither steps per second nor
// restarts when the overlay re-renders. A new deadline (next turn) restarts it from its own offset.
function TimerFill({ deadline, duration }: { deadline: number | null; duration: number }) {
  const total = duration * 1000;
  const delay = useMemo(
    () => (deadline == null ? 0 : -Math.min(total, Math.max(0, total - (deadline - Date.now())))),
    // eslint-disable-next-line react-hooks/exhaustive-deps
    [deadline, total],
  );
  if (deadline == null) return <i style={{ width: "0%" }} />;
  return (
    <i
      key={`${deadline}:${total}`}
      className="draft-timer-fill"
      style={{ animationDuration: `${total}ms`, animationDelay: `${delay}ms` }}
    />
  );
}
const roles = ["top", "jungle", "mid", "bot", "support"];
// Names fit the 5-character limit; without a logo the name is larger and fills the logo area.
function teamNameSize(name: string, simple: boolean, hasLogo: boolean) {
  if (simple) return Math.max(16, Math.min(hasLogo ? 48 : 72, 1000 / Math.max(1, name.length)));
  return Math.max(16, Math.min(hasLogo ? 46 : 72, 260 / Math.max(1, name.length)));
}

// Champions banned in earlier games of the series: one row per side, one column per position.
function SeriesBans({ draft }: { draft: DraftState }) {
  if (!draft.seriesBans.some((cell) => cell.length)) return null;
  return (
    <section className="series-bans" data-region="series-bans" aria-label="Series ban">
      <h3>SERIES BAN</h3>
      <div className="series-bans-grid">
        {roles.map((role, position) => (
          <div className="series-bans-column" key={role}>
            <i
              className="series-bans-role"
              style={{
                maskImage: `url(/broadcast/glyphs/role-${role}.svg)`,
                WebkitMaskImage: `url(/broadcast/glyphs/role-${role}.svg)`,
              }}
            />
            {[0, 1].map((side) => (
              <div className={`series-bans-row ${side ? "red" : "blue"}`} key={side}>
                {draft.seriesBans[side * 5 + position].map((id) => {
                  const c = champion(id);
                  return c ? <img src={c.icon} alt={c.name} title={c.name} key={id} /> : null;
                })}
              </div>
            ))}
          </div>
        ))}
      </div>
    </section>
  );
}

export function DraftOverlay({
  theme: t,
  draft = emptyDraft(),
  now,
}: {
  theme: Theme;
  draft?: DraftState;
  now: number;
}) {
  const turn = draftTurns[draft.step];
  const remaining =
    draft.deadline == null
      ? null
      : Math.min(draft.duration, Math.max(0, Math.ceil((draft.deadline - now) / 1000)));
  // The staged intro only runs on mount; afterwards state changes never replay it.
  const [intro, setIntro] = useState(true);
  useEffect(() => {
    const timer = setTimeout(() => setIntro(false), 2600);
    return () => clearTimeout(timer);
  }, []);
  return (
    <div
      className={`production-draft ${intro ? "is-intro" : ""} ${t.draftLayout === "simple" ? "draft-simple" : "draft-broadcast"}`}
      data-source={draft.source}
    >
      {[0, 1].map((side) => (
        <div
          className={`draft-bans ${side ? "red-bans" : "blue-bans"} ${draft.coaches[side]?.trim() ? "has-coach" : "no-coach"}`}
          data-region={side ? "red-bans" : "blue-bans"}
          key={side}
        >
          {draft.coaches[side]?.trim() && <h3>COACH: {draft.coaches[side].trim()}</h3>}
          <div>
            {draftSlots(draft, side, "ban").map((id, i) => {
              const active = turn?.[0] === side && turn[1] === "ban" && turn[2] === i;
              const c = champion(id ?? (active ? (draft.hover ?? "") : ""));
              return (
                <span
                  className={`draft-ban ${active ? "active" : ""} ${id ? "is-locked" : ""}`}
                  key={i}
                  style={
                    {
                      "--draft-delay": `${i * 45}ms`,
                      "--enter-order": side ? i : 4 - i,
                    } as CSSProperties
                  }
                >
                  {c && <img key={c.id} src={c.icon} alt={`Ban ${c.name}`} />}
                  {id && <i className="draft-lock-flash" key={`lock:${id}`} aria-hidden="true" />}
                  {!c && <small>{i + 1}</small>}
                </span>
              );
            })}
          </div>
        </div>
      ))}
      <SeriesBans draft={draft} />
      <section className="ref-draft" data-region="draft">
        <div
          className={`draft-progress ${turn?.[0] ? "red" : "blue"}`}
          data-team={turn?.[0] ? "red" : "blue"}
        >
          <TimerFill deadline={draft.deadline} duration={draft.duration} />
          {remaining != null && <b>{remaining}</b>}
        </div>
        <div className="ref-draft-picks">
          {[0, 1].map((side) => (
            <div className={`draft-team draft-team-${side}`} key={side}>
              {draftSlots(draft, side, "pick").map((id, i) => {
                const active =
                  turn?.[0] === side && turn[1] === "pick" && draft.order[side][i] === turn[2];
                const c = champion(id ?? (active ? (draft.hover ?? "") : ""));
                return (
                  <article
                    className={`ref-pick ${id ? "is-picked" : active ? "is-hover" : "is-empty"}`}
                    data-champion={c?.id}
                    style={
                      {
                        "--draft-delay": `${i * 55}ms`,
                        "--enter-order": side ? i : 4 - i,
                      } as CSSProperties
                    }
                    key={i}
                  >
                    <span className="pick-number">
                      {t.draftLayout === "simple" ? "" : "["}
                      {side ? "R" : "B"}
                      {i + 1}
                      {t.draftLayout === "simple" ? "" : "]"}
                    </span>
                    {c && (
                      <img
                        key={c.id}
                        className="pick-portrait"
                        src={
                          t.draftLayout === "simple" && "splash" in c
                            ? String(c.splash)
                            : c.portrait
                        }
                        alt={c.name}
                      />
                    )}
                    <div className="pick-shade" />
                    {id && <i className="draft-lock-flash" key={`lock:${id}`} aria-hidden="true" />}
                    {t.draftLayout === "simple" && c && (
                      <span className="draft-champion-name">{c.name}</span>
                    )}
                    <span className="vertical-player">{draft.names[side * 5 + i]}</span>
                    <i
                      className="role-symbol draft-role"
                      style={{
                        maskImage: `url(/broadcast/glyphs/role-${["top", "jungle", "mid", "bot", "support"][i]}.svg)`,
                      }}
                    />
                  </article>
                );
              })}
            </div>
          ))}
        </div>
        <div className={`ref-draft-center ${t.blueLogo || t.redLogo ? "has-logos" : "name-only"}`}>
          <div className="draft-series">
            {[t.blueScore ?? 0, t.redScore ?? 0].map((score, i) => (
              <span className={`series-pips ${i === 0 ? "blue-series" : "red-series"}`} key={i}>
                {Array.from({ length: t.seriesGames ?? 3 }, (_, n) => (
                  <i className={n < score ? "won" : ""} key={n} />
                ))}
              </span>
            ))}
            <span className="draft-series-arrow" aria-hidden="true" />
          </div>
          <div className="draft-side-labels">
            <span>BLUE SIDE</span>
            <span>2ND PICK</span>
          </div>
          <div className="draft-logos">
            {t.blueLogo ? <img src={t.blueLogo} alt={t.blueName} /> : <span />}
            {t.scoreboardLogo ? (
              <img className="draft-tournament-logo" src={t.scoreboardLogo} alt={t.tournament} />
            ) : (
              <span className="draft-tournament">{t.tournament}</span>
            )}
            {t.redLogo ? <img src={t.redLogo} alt={t.redName} /> : <span />}
          </div>
          <div className="draft-team-names">
            {[t.blueName, t.redName].map((name, i) => (
              <b
                key={i}
                title={name}
                style={{
                  fontSize: teamNameSize(
                    name,
                    t.draftLayout === "simple",
                    !!(i ? t.redLogo : t.blueLogo),
                  ),
                }}
              >
                {name}
              </b>
            ))}
          </div>
          <div className="draft-phase" key={draft.step}>
            {!turn
              ? "ĐỘI HÌNH HOÀN TẤT"
              : `${turn[0] ? t.redName : t.blueName} · ${turn[1] === "ban" ? "BAN" : "PICK"} ${turn[2] + 1}`}
          </div>
        </div>
      </section>
    </div>
  );
}
