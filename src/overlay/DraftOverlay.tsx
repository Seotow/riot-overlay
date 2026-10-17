import { draftChampion as champion } from "../../shared/draft-assets";
import {
  draftSlots,
  draftTurns,
  emptyDraft,
  type DraftState,
} from "../../shared/draft";
import type { Theme } from "../../shared/schema";
import type { CSSProperties } from "react";

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
      : Math.min(
          draft.duration,
          Math.max(0, Math.ceil((draft.deadline - now) / 1000)),
        );
  return (
    <div
      className={`production-draft ${t.draftLayout === "simple" ? "draft-simple" : "draft-broadcast"}`}
      data-source={draft.source}
    >
      {[0, 1].map((side) => (
        <div
          className={`draft-bans ${side ? "red-bans" : "blue-bans"}`}
          data-region={side ? "red-bans" : "blue-bans"}
          key={side}
        >
          <h3>{draft.coaches[side] ? `COACH: ${draft.coaches[side]}` : ""}</h3>
          <div>
            {draftSlots(draft, side, "ban").map((id, i) => {
              const active =
                turn?.[0] === side && turn[1] === "ban" && turn[2] === i;
              const c = champion(id ?? (active ? (draft.hover ?? "") : ""));
              return (
                <span
                  className={`draft-ban ${active ? "active" : ""} ${id ? "is-locked" : ""}`}
                  key={i}
                  style={{ "--draft-delay": `${i * 45}ms` } as CSSProperties}
                >
                  {c && (
                    <img
                      key={`${c.id}:${id ? "locked" : "hover"}`}
                      src={c.icon}
                      alt={`Ban ${c.name}`}
                    />
                  )}
                  {id && (
                    <i
                      className="draft-lock-flash"
                      key={`lock:${id}`}
                      aria-hidden="true"
                    />
                  )}
                  {!c && <small>{i + 1}</small>}
                </span>
              );
            })}
          </div>
        </div>
      ))}
      <section className="ref-draft" data-region="draft">
        <div className={`draft-progress ${turn?.[0] ? "red" : "blue"}`}>
          <i
            style={{
              width:
                remaining == null
                  ? "0%"
                  : `${Math.min(100, (remaining / draft.duration) * 100)}%`,
            }}
          />
          {remaining != null && <b>{remaining}</b>}
        </div>
        <div className="ref-draft-picks">
          {[0, 1].map((side) => (
            <div className={`draft-team draft-team-${side}`} key={side}>
              {draftSlots(draft, side, "pick").map((id, i) => {
                const active =
                  turn?.[0] === side &&
                  turn[1] === "pick" &&
                  draft.order[side][i] === turn[2];
                const c = champion(id ?? (active ? (draft.hover ?? "") : ""));
                return (
                  <article
                    className={`ref-pick ${id ? "is-picked" : active ? "is-hover" : "is-empty"}`}
                    data-champion={c?.id}
                    style={{ "--draft-delay": `${i * 55}ms` } as CSSProperties}
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
                        key={`${c.id}:${id ? "locked" : "hover"}`}
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
                    {id && (
                      <i
                        className="draft-lock-flash"
                        key={`lock:${id}`}
                        aria-hidden="true"
                      />
                    )}
                    {t.draftLayout === "simple" && c && (
                      <span className="draft-champion-name">{c.name}</span>
                    )}
                    <span className="vertical-player">
                      {draft.names[side * 5 + i]}
                    </span>
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
        <div className="ref-draft-center">
          <div className="draft-series">
            {[t.blueScore ?? 0, t.redScore ?? 0].map((score, i) => (
              <span
                className={`series-pips ${i === 0 ? "blue-series" : "red-series"}`}
                key={i}
              >
                {Array.from({ length: t.seriesGames ?? 3 }, (_, n) => (
                  <i className={n < score ? "won" : ""} key={n} />
                ))}
              </span>
            ))}
          </div>
          <div className="draft-logos">
            {t.blueLogo ? <img src={t.blueLogo} alt={t.blueName} /> : <span />}
            <span className="draft-tournament">{t.tournament}</span>
            {t.redLogo ? <img src={t.redLogo} alt={t.redName} /> : <span />}
          </div>
          <div className="draft-team-names">
            <b
              title={t.blueName}
              style={{
                fontSize: Math.max(
                  16,
                  Math.min(
                    t.draftLayout === "simple" ? 64 : 45,
                    (t.draftLayout === "simple" ? 1000 : 220) /
                      t.blueName.length,
                  ),
                ),
              }}
            >
              {t.blueName}
            </b>
            <b
              title={t.redName}
              style={{
                fontSize: Math.max(
                  16,
                  Math.min(
                    t.draftLayout === "simple" ? 64 : 45,
                    (t.draftLayout === "simple" ? 1000 : 220) /
                      t.redName.length,
                  ),
                ),
              }}
            >
              {t.redName}
            </b>
          </div>
          {draft.patch && (
            <div className="draft-patch">PATCH {draft.patch}</div>
          )}
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
