import type { CSSProperties } from "react";
import type { IngameSample } from "../../shared/observer";
import { liveCatalog, liveChampion } from "../../shared/live-assets";
import { levelProgress, rankLevels } from "../../shared/ui-metrics";
import { MotionPresence } from "./MotionPresence";
import { AnimatedRank } from "./AnimatedRank";
import { playerDisplayName } from "../../shared/player-name";
export function RankingBoard({
  sample,
  mode,
  show,
  alongside = false,
  playerNames,
}: {
  playerNames?: string[];
  sample: IngameSample | null;
  mode: "gold" | "levels";
  show: boolean;
  alongside?: boolean;
}) {
  const players =
    mode === "levels"
      ? rankLevels(sample?.players ?? [])
      : [...(sample?.players ?? [])]
          .filter((p) => p.totalGold.value !== null)
          .sort(
            (a, b) =>
              b.totalGold.value! - a.totalGold.value! || a.slot - b.slot,
          );
  const max = Math.max(1, ...players.map((p) => p.totalGold.value ?? 0));
  return (
    <MotionPresence show={show && !!sample}>
      <aside
        className={
          mode === "gold"
            ? "real-gold-ranking"
            : `live-level-ranking ${alongside ? "alongside-gold" : ""}`
        }
        data-region={mode}
      >
        <h3>{mode === "gold" ? "TOTAL GOLD" : "XP + LVL"}</h3>
        <AnimatedRank slots={players.map((p) => p.slot)}>
          {players.map((p, index) => {
            const asset =
                sample?.assetVersion === liveCatalog.version
                  ? liveChampion(p.championId.value)
                  : undefined,
              progress = levelProgress(p);
            return (
              <div
                key={p.slot}
                className="rank-entry"
                data-slot={p.slot}
                style={
                  {
                    transform: `translateY(${index * 53}px)`,
                    "--rank-delay": `${400 + index * 45}ms`,
                  } as CSSProperties
                }
              >
                <div
                  className={`rank-content ${p.team.value === "CHAOS" ? "red" : "blue"}`}
                >
                  {asset && (
                    <img width="44" height="44" src={asset.icon} alt="" />
                  )}
                  {mode === "gold" ? (
                    <>
                      <span title={playerDisplayName(p, playerNames)}>{playerDisplayName(p, playerNames)}</span>
                      <b>{((p.totalGold.value ?? 0) / 1000).toFixed(1)}K</b>
                      <span className="ranking-track">
                        <i
                          style={{
                            width: `${(100 * (p.totalGold.value ?? 0)) / max}%`,
                          }}
                        />
                      </span>
                    </>
                  ) : (
                    <>
                      <div className="level-summary">
                        <span title={playerDisplayName(p, playerNames)}>{playerDisplayName(p, playerNames)}</span>
                        <span className="xp-percent">{progress === null ? "—" : `${Math.floor(progress * 100)}%`}</span>
                        {progress === null ? (
                          <span
                            className="level-progress unavailable"
                            title="Chưa có dữ liệu XP"
                          >
                            {p.sourceStats?.value?.experience != null
                              ? `XP ${Math.floor(p.sourceStats.value.experience)}`
                              : "CHƯA CÓ XP"}
                          </span>
                        ) : (
                          <span
                            className="level-progress"
                            role="progressbar"
                            aria-label="Tiến độ cấp tiếp theo"
                            title={
                              p.experience?.value
                                ? "XP do nguồn báo"
                                : `XP SR suy ra từ tổng XP native ${p.sourceStats?.value?.experience ?? "—"} + ngưỡng cấp mặc định`
                            }
                            aria-valuemin={0}
                            aria-valuemax={100}
                            aria-valuenow={Math.round(progress * 100)}
                          >
                            <i style={{ width: `${progress * 100}%` }} />
                          </span>
                        )}
                      </div>
                      <b className="rank-level">{p.level.value ?? "—"}</b>
                    </>
                  )}
                </div>
              </div>
            );
          })}
        </AnimatedRank>
      </aside>
    </MotionPresence>
  );
}
