import type { IngameSample, ObservedEvent } from "../../shared/observer";
import type { Theme } from "../../shared/schema";
import { liveCatalog, liveChampion } from "../../shared/live-assets";
import { objectiveIconUrl } from "../../shared/objective-icons";
import { playerDisplayName } from "../../shared/player-name";
const labels: Record<string, string> = {
  ChampionKill: "Hạ gục",
  DragonKill: "Hạ rồng",
  BaronKill: "Baron Nashor",
  HeraldKill: "Sứ giả khe nứt",
  TurretKilled: "Phá trụ",
  InhibKilled: "Phá nhà lính",
  Ace: "Quét sạch",
};
export function BroadcastKillfeed({
  events,
  sample,
  theme,
}: {
  events: ObservedEvent[];
  sample: IngameSample;
  theme: Theme;
}) {
  function portrait(slot: number | undefined, assist = false) {
    if (slot === undefined || sample.assetVersion !== liveCatalog.version)
      return null;
    const player = sample.players.find((p) => p.slot === slot),
      asset = liveChampion(player?.championId.value);
    return asset ? (
      <img
        className={assist ? "feed-assist" : "feed-champion"}
        src={asset.icon}
        alt={playerDisplayName(player, theme.playerNames)}
        title={playerDisplayName(player, theme.playerNames)}
      />
    ) : null;
  }
  return (
    <aside
      className="broadcast-killfeed"
      aria-label="Killfeed overlay"
      data-region="killfeed"
    >
      {events.map((event) => {
        const killer = portrait(event.killerSlot),
          victim = portrait(event.victimSlot);
        const objective =
          event.kind === "DragonKill"
            ? (event.objectiveType ?? "dragon")
            : event.kind === "BaronKill"
              ? "baron"
              : event.kind === "HeraldKill"
                ? "herald"
                : null;
        return (
          <div
            className={`broadcast-feed-row ${event.team === "ORDER" ? "blue" : event.team === "CHAOS" ? "red" : "unknown"}`}
            key={event.id}
            title={labels[event.kind] ?? event.kind}
          >
            <span className="feed-assists">
              {event.assistSlots?.map((slot) => (
                <span key={slot}>{portrait(slot, true)}</span>
              ))}
            </span>
            {killer ??
              (event.killerObjectiveType || event.killerUnitType ? (
                <span
                  className="feed-objective-icon"
                  role="img"
                  aria-label={`Tác nhân hạ gục: ${event.killerObjectiveType ?? event.killerUnitType}`}
                  style={{
                    maskImage: `url(${event.killerObjectiveType ? objectiveIconUrl(event.killerObjectiveType) : event.killerUnitType === "grubs" ? objectiveIconUrl("grubs") : event.killerUnitType === "turret" ? "/broadcast/glyphs/tower.svg" : `/broadcast/killers/${event.killerUnitType}.png`})`,
                  }}
                />
              ) : (
                <small>
                  {event.team === "ORDER"
                    ? theme.blueName
                    : event.team === "CHAOS"
                      ? theme.redName
                      : "—"}
                </small>
              ))}
            <span className="feed-kill-mark" aria-hidden="true" />
            {objective === "dragon" ? (
              <span
                className="feed-objective-icon"
                style={{ maskImage: `url(${objectiveIconUrl("dragon")})` }}
                role="img"
                aria-label="Hạ rồng (chưa rõ loại)"
              />
            ) : objective ? (
              <span
                className="feed-objective-icon"
                role="img"
                aria-label={labels[event.kind]}
                style={{
                  maskImage: `url(${objectiveIconUrl(objective)})`,
                }}
              />
            ) : event.kind === "ChampionKill" ? (
              (victim ?? (
                <span className="feed-missing" title="Chưa có victim từ nguồn">
                  ?
                </span>
              ))
            ) : event.kind === "TurretKilled" ||
              event.kind === "InhibKilled" ? (
              <svg
                className="feed-structure-icon"
                viewBox="0 0 30 30"
                role="img"
                aria-label={labels[event.kind]}
              >
                <path
                  fill="currentColor"
                  d={
                    event.kind === "TurretKilled"
                      ? "M6 3h5v6h8V3h5v10l-4 4 2 10H8l2-10-4-4z"
                      : "M15 2 26 15 15 28 4 15zm0 7-5 6 5 6 5-6z"
                  }
                />
              </svg>
            ) : (
              <b>{labels[event.kind] ?? event.kind}</b>
            )}
          </div>
        );
      })}
    </aside>
  );
}
