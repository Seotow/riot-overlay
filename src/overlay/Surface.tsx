import { useEffect, useRef, useState, type CSSProperties } from "react";
import type { State, Player } from "../../shared/schema";
import { clock } from "../../shared/mock";
import { champion, item, spell, rune, catalog } from "../../shared/assets";
import { draftFixture } from "../../shared/reference";

// Broadcast marks are explicit crops from the user-supplied reference, never HUD/data.
function Mark({ kind, name }: { kind: "kt" | "t1" | "worlds"; name?: string }) {
  const known = !name || name === (kind === "kt" ? "KT" : "T1");
  return known ? (
    <span
      className={`broadcast-mark mark-${kind}`}
      role="img"
      aria-label={name || "Worlds reference mark"}
    />
  ) : (
    <b className="custom-team-mark">{name.slice(0, 3)}</b>
  );
}
function Role({ index }: { index: number }) {
  const paths = [
    "M5 5h22v6H11v16H5z M14 14h13v13H14z",
    "M15 30 8 21 3 4l10 10 3-12 3 12L30 4l-5 17-8 9z",
    "M3 23 23 3h8L11 31H3z",
    "M5 5h22v22H5z M11 11v10h10V11z",
    "M16 8 5 5l4 10 5 3-3 11h10l-3-11 5-3 4-10z",
  ];
  return (
    <svg className="role-symbol" viewBox="0 0 34 34" aria-hidden="true">
      <path d={paths[index]} fill="currentColor" />
    </svg>
  );
}
function MetricIcon({ kind }: { kind: "gold" | "tower" | "dragon" | "baron" }) {
  return (
    <svg
      className={`metric-icon ${kind}`}
      viewBox="0 0 30 30"
      aria-hidden="true"
    >
      {kind === "gold" ? (
        <>
          <ellipse cx="15" cy="18" rx="12" ry="6" />
          <path d="M5 13 20 8l5 6-16 5z" />
        </>
      ) : kind === "tower" ? (
        <path d="M8 4h4v5h6V4h4v10l-3 3 2 9H9l2-9-3-3z M12 0h6v6h-6z" />
      ) : kind === "dragon" ? (
        <path d="m15 2 5 8 8-4-3 12-7 9-3-5-3 5-7-9L2 6l8 4z M12 12l3 5 3-5-3 2z" />
      ) : (
        <path d="m5 2 5 7 5-5 5 5 5-7-1 18-9 8-9-8z M10 13l3 3-4 1z M20 13l-3 3 4 1z" />
      )}
    </svg>
  );
}
function SeriesPips() {
  return (
    <span className="series-pips">
      <i />
      <i />
      <i />
    </span>
  );
}
function Scoreboard({ state }: { state: State }) {
  const t = state.theme;
  const totals = [0, 1].map((side) =>
    state.players
      .slice(side * 5, side * 5 + 5)
      .reduce((n, p) => n + (p.gold || 0), 0),
  );
  const showGold = state.capabilities.gold && t.widgets.gold;
  const difference = totals[1] - totals[0];
  return (
    <header className="ref-scoreboard" data-region="scoreboard">
      <div className="score-main">
        <div className="score-team side-blue">
          <SeriesPips />
          <Mark kind="kt" name={t.blueName} />
          <div className="team-caption">
            <b>{t.blueName}</b>
            <span>LCK #3</span>
          </div>
        </div>
        <div className="score-economy">
          <span>
            <MetricIcon kind="tower" />1
          </span>
          <span>
            <MetricIcon kind="gold" />
            {showGold ? `${(totals[0] / 1000).toFixed(1)}K` : "—"}
          </span>
        </div>
        <div className="score-kills">
          <b>{state.blueKills}</b>
          <Mark kind="worlds" />
          <b>{state.redKills}</b>
        </div>
        <div className="score-economy right">
          <span>
            {showGold ? `${(totals[1] / 1000).toFixed(1)}K` : "—"}
            <MetricIcon kind="gold" />
            {showGold && difference !== 0 && (
              <small className={difference > 0 ? "red-lead" : "blue-lead"}>
                {difference > 0 ? "+" : ""}
                {(difference / 1000).toFixed(1)}K
              </small>
            )}
          </span>
          <span>
            4<MetricIcon kind="tower" />
          </span>
        </div>
        <div className="score-team side-red">
          <div className="team-caption">
            <b>{t.redName}</b>
            <span>LCK #4</span>
          </div>
          <Mark kind="t1" name={t.redName} />
          <SeriesPips />
        </div>
      </div>
      <div className="score-sub">
        <div className="team-objectives">
          <MetricIcon kind="baron" />
          <b>2</b>
          <MetricIcon kind="tower" />
          <b>3</b>
        </div>
        <div className="dragon-icons blue-dragons">
          <MetricIcon kind="dragon" />
          <MetricIcon kind="dragon" />
        </div>
        <time>{clock(state.gameTime)}</time>
        <div className="dragon-icons red-dragons">
          <MetricIcon kind="dragon" />
          <MetricIcon kind="dragon" />
        </div>
        <div className="team-objectives right">
          <MetricIcon kind="baron" />
          <b>0</b>
          <MetricIcon kind="tower" />
          <b>43</b>
        </div>
      </div>
    </header>
  );
}
function PlayerRow({ p, red }: { p: Player; red: boolean }) {
  return (
    <div className={`ref-player-row ${red ? "red-row" : "blue-row"}`}>
      <div className="row-vision">
        <b>{p.vision}</b>
        <img src={item(p.items[5])?.icon} alt={item(p.items[5])?.name} />
      </div>
      <div className="row-items">
        {p.items.slice(0, 5).map((id, i) => (
          <img
            key={`${id}-${i}`}
            src={item(id)?.icon}
            alt={item(id)?.name}
            title={item(id)?.name}
          />
        ))}
      </div>
      <div className="row-spells">
        {p.spells.map((id) => (
          <img key={id} src={spell(id)?.icon} alt={spell(id)?.name} />
        ))}
      </div>
      <div className="row-champion">
        <img
          src={champion(p.championId)?.icon}
          alt={champion(p.championId)?.name}
        />
        <b>{p.level}</b>
      </div>
      <div className="row-name">
        <div>
          <img src={rune(p.rune)?.icon} alt={rune(p.rune)?.name} />
          <b>{p.name}</b>
        </div>
        <span className="health-track">
          <i style={{ width: `${p.health * 100}%` }} />
        </span>
        <span className="resource-track">
          <i style={{ width: `${p.resource * 100}%` }} />
        </span>
      </div>
      <div className="row-numbers">
        <b>{p.cs}</b>
        <span>
          {p.kills}/{p.deaths}/{p.assists}
        </span>
      </div>
    </div>
  );
}
function PlayerTable({ state }: { state: State }) {
  return (
    <section className="ref-player-table" data-region="players">
      <div className="table-blue">
        {state.players.slice(0, 5).map((p) => (
          <PlayerRow p={p} red={false} key={p.id} />
        ))}
      </div>
      <div className="table-gold">
        {[931, 962, 825, 851, 1500].map((g, i) => (
          <div key={i}>
            {state.capabilities.gold && state.theme.widgets.gold
              ? g >= 1000
                ? `${(g / 1000).toFixed(1)}K`
                : g
              : "—"}
          </div>
        ))}
      </div>
      <div className="table-red">
        {state.players.slice(5).map((p) => (
          <PlayerRow p={p} red key={p.id} />
        ))}
      </div>
    </section>
  );
}
function Draft({ state }: { state: State }) {
  const t = state.theme;
  const locked = new Set(
    [
      ...draftFixture.initialLocked,
      ...[3, 8, 4, 9].slice(0, Math.max(0, state.draftStep - 6)),
    ].slice(0, state.draftStep),
  );
  return (
    <>
      <div className="draft-bans blue-bans" data-region="blue-bans">
        <h3>COACH: {draftFixture.blueCoach}</h3>
        <div>
          {draftFixture.blueBans.map((id) => (
            <img
              key={id}
              src={champion(id)?.icon}
              alt={`Ban ${champion(id)?.name}`}
            />
          ))}
        </div>
      </div>
      <div className="draft-bans red-bans">
        <h3>COACH: {draftFixture.redCoach}</h3>
        <div>
          {draftFixture.redBans.map((id) => (
            <img
              key={id}
              src={champion(id)?.icon}
              alt={`Ban ${champion(id)?.name}`}
            />
          ))}
        </div>
      </div>
      <section className="ref-draft" data-region="draft">
        <div className="draft-progress" />
        <div className="ref-draft-picks">
          {[0, 1].map((side) => (
            <div className={`draft-team draft-team-${side}`} key={side}>
              {draftFixture.picks.slice(side * 5, side * 5 + 5).map((id, i) => {
                const index = side * 5 + i,
                  hover = index === draftFixture.hovered && !locked.has(index),
                  picked = locked.has(index);
                const c = champion(id);
                return (
                  <article
                    className={`ref-pick ${picked ? "is-picked" : ""} ${hover ? "is-hover" : ""} ${!picked && !hover ? "is-empty" : ""}`}
                    key={id}
                    title={c.name}
                  >
                    <span className="pick-number">
                      [{side ? "R" : "B"}
                      {i + 1}]
                    </span>
                    {(picked || hover) && (
                      <img
                        className="pick-portrait"
                        src={c.portrait}
                        alt={c.name}
                      />
                    )}
                    <div className="pick-shade" />
                    <span className="vertical-player">
                      {draftFixture.names[index]}
                    </span>
                    <Role index={i} />
                    {hover && (
                      <div className="pick-stat">
                        <b>82.3%</b>
                        <strong>FEARLESS PB%</strong>
                        <p>
                          <b>15.2%</b>
                          <br />
                          PICK
                        </p>
                        <small>9W - 3L</small>
                      </div>
                    )}
                  </article>
                );
              })}
            </div>
          ))}
        </div>
        <div className="ref-draft-center">
          <div className="draft-series">
            <SeriesPips />
            <SeriesPips />
          </div>
          <div className="draft-logos">
            <Mark kind="kt" name={t.blueName} />
            <Mark kind="worlds" />
            <Mark kind="t1" name={t.redName} />
          </div>
          <div className="draft-team-names">
            <b>{t.blueName}</b>
            <b>{t.redName}</b>
          </div>
          <div className="draft-patch">PATCH {catalog.displayPatch}</div>
          <div
            className="reference-sponsors"
            aria-label="Sponsor marks from supplied reference"
          />
        </div>
      </section>
    </>
  );
}
export function Surface({
  state,
  preview = false,
  reference = false,
  compare = false,
}: {
  state: State;
  preview?: boolean;
  reference?: boolean;
  compare?: boolean;
}) {
  const shell = useRef<HTMLDivElement>(null);
  const [scale, setScale] = useState(1);
  useEffect(() => {
    const el = shell.current!;
    const observer = new ResizeObserver(() => setScale(el.clientWidth / 1920));
    observer.observe(el);
    return () => observer.disconnect();
  }, []);
  const requested = new URLSearchParams(location.search).get("scene");
  const overlay = location.pathname === "/overlay";
  const active =
    overlay && ["draft", "ingame", "postgame"].includes(requested || "")
      ? requested
      : state.scene;
  const t = state.theme;
  const style = {
    "--blue": t.blue,
    "--red": t.red,
    "--accent": t.accent,
    "--panel": t.background,
    "--display-font":
      t.font === "condensed"
        ? "Anton"
        : t.font === "serif"
          ? "Georgia"
          : '"Segoe UI"',
    "--body-font": t.font === "serif" ? "Georgia" : '"Roboto Condensed"',
    transform: `scale(${scale})`,
  } as CSSProperties;
  return (
    <div ref={shell} className={`surface ${preview ? "preview" : ""}`}>
      <div className={`canvas ref-canvas ${t.variant}`} style={style}>
        {preview && (reference || compare) && (
          <img
            className="reference"
            src={`/references/${active === "draft" ? "draft" : "ingame"}.png`}
            alt="Ảnh gốc do bạn cung cấp"
          />
        )}
        {preview && !reference && !compare && (
          <div className="stage">
            <div className="river" />
            <span>VÙNG HÌNH GAME / CAMERA</span>
            <small>1920 × 1080 · nền chỉ xuất hiện trong preview</small>
            <div className="minimap">
              MINIMAP
              <br />
              SAFE AREA
            </div>
          </div>
        )}
        {!compare && (
          <div
            className="ref-graphics"
            style={{
              transform: `translateY(${t.offsetY}px) scale(${t.scale})`,
            }}
          >
            {active === "ingame" && (
              <>
                <Scoreboard state={state} />
                {t.widgets.objectives && (
                  <div className="ref-objective" data-region="objective">
                    <span className="objective-baron">
                      <MetricIcon kind="baron" />
                    </span>
                    <span className="objective-gem">♦</span>
                    <b>{clock(state.objectives[0]?.endsAt - state.gameTime)}</b>
                  </div>
                )}
                {t.widgets.players && <PlayerTable state={state} />}
                <div className="camera-caption caption-blue">CUZZ</div>
                <div className="camera-caption caption-red">ONER</div>
                {t.widgets.killfeed && (
                  <div className="killfeed">
                    {state.events.map((e) => (
                      <div key={e.id}>
                        {e.text}
                        <small>{clock(e.at)}</small>
                      </div>
                    ))}
                  </div>
                )}
                {t.widgets.levels && (
                  <aside className="levels">
                    <small>LEADERBOARD</small>
                    <h3>CHAMPION LEVEL</h3>
                    {[...state.players]
                      .sort((a, b) => b.level - a.level)
                      .slice(0, 5)
                      .map((p) => (
                        <div key={p.id}>
                          <img
                            width="30"
                            height="30"
                            src={champion(p.championId).icon}
                            alt=""
                          />
                          <span>{p.champion}</span>
                          <b>{p.level}</b>
                        </div>
                      ))}
                  </aside>
                )}
              </>
            )}
            {active === "draft" && <Draft state={state} />}
            {active === "postgame" && (
              <section className="postgame">
                <small>{t.tournament} / GAME 01</small>
                <h1>{t.redName}</h1>
                <h2>VICTORY</h2>
                <div className="result-score">
                  {state.blueKills} <span>—</span> {state.redKills}
                </div>
                <p>THỜI GIAN TRẬN · {clock(state.gameTime)}</p>
                <div className="result-table">
                  <div>
                    <b>PLAYER</b>
                    <b>CHAMPION</b>
                    <b>K / D / A</b>
                    <b>CS</b>
                  </div>
                  {state.players.map((p) => (
                    <div key={p.id}>
                      <span>{p.name}</span>
                      <span>
                        <img
                          className="result-champion"
                          src={champion(p.championId).icon}
                          alt=""
                        />
                        {p.champion}
                      </span>
                      <span>
                        {p.kills}/{p.deaths}/{p.assists}
                      </span>
                      <span>{p.cs}</span>
                    </div>
                  ))}
                </div>
              </section>
            )}
          </div>
        )}
      </div>
    </div>
  );
}
