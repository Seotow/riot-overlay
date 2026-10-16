import type { Theme } from "../../shared/schema";
import {
  goldSegments,
  postgameRoles,
  type PostgameState,
} from "../../shared/postgame";
import { draftChampion } from "../../shared/draft-assets";
import { liveChampion } from "../../shared/live-assets";

const number = (n: number | null) => (n === null ? "—" : String(n));
const compact = (n: number | null) =>
  n === null ? "—" : `${(n / 1000).toFixed(1)}K`;
function Champion({ id, live = false }: { id: string | null; live?: boolean }) {
  const c = id
    ? live
      ? liveChampion(Number(id))
      : draftChampion(id)
    : undefined;
  return c ? (
    <img className="pg-champion" src={c.icon} alt={c.name} />
  ) : (
    <span className="pg-champion pg-unknown">?</span>
  );
}
function GoldChart({ data }: { data: PostgameState }) {
  const points = data.goldHistory;
  const end = Math.max(1, data.duration ?? points.at(-1)?.at ?? 1);
  const hi =
    Math.ceil(Math.max(2000, ...points.map((p) => p.delta ?? 0)) / 2000) * 2000;
  const lo =
    Math.floor(Math.min(0, ...points.map((p) => p.delta ?? 0)) / 2000) * 2000;
  const x = (at: number) => 88 + (792 * at) / end;
  const y = (delta: number) => 222 - (176 * (delta - lo)) / (hi - lo);
  const zero = y(0);
  const segments = goldSegments(points);
  const ticks = Array.from(
    { length: Math.floor(end / 600) + 1 },
    (_, i) => i * 600,
  );
  if (!segments.length)
    return <div className="pg-no-history">CHƯA CÓ LỊCH SỬ VÀNG</div>;
  return (
    <svg
      className="pg-gold-chart"
      viewBox="0 0 900 280"
      role="img"
      aria-label="Chênh lệch vàng: đội xanh trừ đội đỏ"
    >
      <defs>
        <clipPath id="pg-positive">
          <rect x="88" y="46" width="792" height={zero - 46} />
        </clipPath>
        <clipPath id="pg-negative">
          <rect x="88" y={zero} width="792" height={222 - zero} />
        </clipPath>
        <linearGradient id="pg-blue-fill" x2="0" y2="1">
          <stop stopColor="var(--blue)" stopOpacity=".6" />
          <stop offset="1" stopColor="var(--blue)" stopOpacity=".05" />
        </linearGradient>
        <linearGradient id="pg-red-fill" x2="0" y2="1">
          <stop stopColor="var(--red)" stopOpacity=".05" />
          <stop offset="1" stopColor="var(--red)" stopOpacity=".6" />
        </linearGradient>
      </defs>
      {[hi, 0, ...(lo < 0 ? [lo] : [])].map((v) => (
        <g key={v}>
          <line
            x1="88"
            x2="880"
            y1={y(v)}
            y2={y(v)}
            className={v === 0 ? "pg-zero" : "pg-grid"}
          />
          <text x="74" y={y(v) + 6} textAnchor="end">
            {Math.round(v).toLocaleString("en-US")}
          </text>
        </g>
      ))}
      {ticks.map((at) => (
        <g key={at}>
          <line x1={x(at)} x2={x(at)} y1="46" y2="222" className="pg-grid" />
          <text x={x(at)} y="252" textAnchor="middle">
            {at / 60}
          </text>
        </g>
      ))}
      {segments.map((segment, i) => {
        const line = segment
          .map((p, j) => `${j ? "L" : "M"}${x(p.at)},${y(p.delta)}`)
          .join(" ");
        const area = `${line} L${x(segment.at(-1)!.at)},${zero} L${x(segment[0].at)},${zero} Z`;
        return (
          <g key={i} data-gold-segment>
            <path
              d={area}
              fill="url(#pg-blue-fill)"
              clipPath="url(#pg-positive)"
            />
            <path
              d={area}
              fill="url(#pg-red-fill)"
              clipPath="url(#pg-negative)"
            />
            <path
              d={line}
              className="pg-curve pg-blue"
              clipPath="url(#pg-positive)"
            />
            <path
              d={line}
              className="pg-curve pg-red"
              clipPath="url(#pg-negative)"
            />
            {segment.length === 1 && (
              <circle
                cx={x(segment[0].at)}
                cy={y(segment[0].delta)}
                r="3"
                fill="currentColor"
              />
            )}
          </g>
        );
      })}
      <text x="880" y="274" textAnchor="end" className="pg-axis-unit">
        PHÚT
      </text>
    </svg>
  );
}
export function PostgameOverlay({
  theme: t,
  data,
}: {
  theme: Theme;
  data?: PostgameState | null;
}) {
  if (!data)
    return (
      <section className="production-postgame pg-empty">
        <small>POSTGAME · UI PREVIEW</small>
        <h1>CHỜ DỮ LIỆU SAU TRẬN</h1>
        <p>Tải kết quả Riot hoặc nạp bộ mẫu từ Studio.</p>
      </section>
    );
  const stats = [
    [
      "KDA",
      ...data.teams.map((s) =>
        [s.kills, s.deaths, s.assists].map(number).join("/"),
      ),
    ],
    ["GOLD", ...data.teams.map((s) => compact(s.gold))],
    ...(
      [
        ["TURRETS", "towers"],
        ["DRAKES", "drakes"],
        ["ELDER DRAGONS", "elders"],
        ["BARONS", "barons"],
        ["RIFT HERALDS", "heralds"],
        ["VOIDGRUBS", "grubs"],
      ] as const
    ).map(([label, key]) => [label, ...data.teams.map((s) => number(s[key]))]),
  ];
  const damageMax = Math.max(
    1,
    ...data.teams.flatMap((s) => s.players.map((p) => p.damage ?? 0)),
  );
  return (
    <section className="production-postgame" data-source={data.source}>
      <header className="pg-header">
        {data.teams.map((s, side) => (
          <div
            className={`pg-team pg-side-${side} ${data.winner === (side ? "red" : "blue") ? "pg-winner" : ""}`}
            key={side}
          >
            <div className="pg-team-brand">
              <small>{side ? "RED SIDE" : "BLUE SIDE"}</small>
              <b title={side ? t.redName : t.blueName}>
                {side ? t.redName : t.blueName}
              </b>
            </div>
            {(side ? t.redLogo : t.blueLogo) && (
              <img
                className="pg-logo"
                src={side ? t.redLogo : t.blueLogo}
                alt="Logo đội"
              />
            )}
            <span className="pg-result">
              {data.winner === null
                ? "—"
                : data.winner === (side ? "red" : "blue")
                  ? "WIN"
                  : "LOSS"}
            </span>
            <strong>{number(s.kills)}</strong>
          </div>
        ))}
        <div className="pg-time">
          <strong>
            {data.duration === null
              ? "—"
              : `${Math.floor(data.duration / 60)}:${String(data.duration % 60).padStart(2, "0")}`}
          </strong>
          <span>GAMETIME</span>
        </div>
      </header>
      <div className="pg-ribbon">
        <span>{t.tournament}</span>
        <i /> GAME {String(data.gameNumber).padStart(2, "0")} · MATCH SUMMARY
      </div>
      <div className="pg-content">
        <div className="pg-stats">
          {stats.map(([label, blue, red]) => (
            <div className="pg-stat" key={label}>
              <b className={data.winner === "blue" ? "pg-highlight-blue" : ""}>
                {blue}
              </b>
              <span>{label}</span>
              <b className={data.winner === "red" ? "pg-highlight-red" : ""}>
                {red}
              </b>
            </div>
          ))}
          <div className="pg-bans">
            <div>
              {data.teams[0].bans.map((id, i) => (
                <Champion key={i} id={id} live={data.source === "riot"} />
              ))}
            </div>
            <span>BAN</span>
            <div>
              {data.teams[1].bans.map((id, i) => (
                <Champion key={i} id={id} live={data.source === "riot"} />
              ))}
            </div>
          </div>
        </div>
        <div className="pg-analytics">
          <section className="pg-damage">
            <h2>DAMAGE DEALT TO CHAMPIONS</h2>
            {postgameRoles.map((role, i) => (
              <div className="pg-damage-row" key={role}>
                {[0, 1].map((side) => {
                  const p = data.teams[side].players[i];
                  return (
                    <div
                      key={side}
                      className={`pg-damage-side pg-side-${side}`}
                    >
                      <Champion id={p.champion} live={data.source === "riot"} />
                      <div className="pg-damage-meter">
                        <b>{compact(p.damage)}</b>
                        <div>
                          <i
                            style={{
                              width: `${(100 * (p.damage ?? 0)) / damageMax}%`,
                            }}
                          />
                        </div>
                      </div>
                    </div>
                  );
                })}
                <span className="pg-role">
                  {data.source === "riot" &&
                  data.evidence.roleOrderResolved.some((v) => !v)
                    ? `P${i + 1}`
                    : role}
                </span>
              </div>
            ))}
          </section>
          <section className="pg-history">
            <h2>GOLD DIFFERENCE OVER TIME</h2>
            <div className="pg-chart-legend">
              <span className="pg-highlight-blue">{t.blueName} +</span>
              <span className="pg-highlight-red">{t.redName} −</span>
            </div>
            <GoldChart data={data} />
          </section>
          <footer className="pg-footer">
            <b title={t.tournament}>{t.tournament}</b>
            <div>
              <span>POSTGAME REPORT</span>
              <small>
                {data.source === "riot"
                  ? `RIOT API · ${data.evidence.isFinal ? "POSTGAME" : "CHƯA ĐỦ KẾT QUẢ"} · ${data.evidence.patch || "PATCH —"}`
                  : "DỮ LIỆU MẪU · CHƯA NỐI NGUỒN THẬT"}
              </small>
            </div>
          </footer>
        </div>
      </div>
    </section>
  );
}
