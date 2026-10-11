import { useEffect, useState } from "react";
import { SoulTakeover } from "./SoulTakeover";
import { DragonBanner } from "./DragonBanner";
import { CooldownVeil } from "./CooldownVeil";
import { InhibitorTimers } from "./InhibitorTimers";
import { QuestCompletion } from "./QuestCompletion";
import { showItemCooldown } from "../../shared/role-quest";
import { runeSummary } from "../../shared/rune-summary";
import { TowerBanner } from "./TowerBanner";
import { BARON_BUFF_SECONDS } from "../../shared/game-rules";
import {
  advanceBaronWindow,
  allBaronLost,
  baronGoldDelta,
  type BaronWindow,
  advanceElderWindow,
  allElderLost,
  type ElderWindow,
  ELDER_BUFF_SECONDS,
} from "../../shared/baron-powerplay";
import {
  levelProgress,
  rankLevels,
  objectiveVisual,
} from "../../shared/ui-metrics";
import {
  liveCatalog,
  liveChampion,
  liveItem,
  liveSpell,
  liveRune,
} from "../../shared/live-assets";
import type { Theme } from "../../shared/schema";
import type { RehearsalDisplay } from "../../shared/rehearsal";
import type {
  ObservedEvent,
  ObservedPlayer,
  ObserverFrame,
} from "../../shared/observer";
import {
  latestObjectiveEvent,
  livePresentation,
} from "../../shared/live-presentation";
const value = (n: number | null | undefined) => (n == null ? "" : String(n));
const gold = (n: number | null) =>
  n === null ? "" : `${(n / 1000).toFixed(1)}K`;
const goldGap = (n: number) =>
  n >= 1000 ? `${(n / 1000).toFixed(1)}K` : String(Math.round(n));
const countdown = (n: number) => {
  const seconds = Math.ceil(Math.max(0, n));
  return `${Math.floor(seconds / 60)}:${String(seconds % 60).padStart(2, "0")}`;
};
function MetricIcon({
  kind,
  dragonType,
}: {
  kind: "gold" | "tower" | "dragon" | "baron";
  dragonType?: string;
}) {
  const element = dragonType?.replace(/^DRAGON_/i, "").toLowerCase();
  const objective =
    kind === "baron"
      ? objectiveVisual(dragonType ?? "BARON")
      : kind === "dragon"
        ? objectiveVisual(dragonType)
        : null;
  if (objective) {
    return (
      <span
        className={`metric-icon ${kind} objective-glyph`}
        title={objective.label}
        style={{
          backgroundColor: objective.color,
          maskImage: `url(/broadcast/objectives/${objective.glyph}.svg)`,
          WebkitMaskImage: `url(/broadcast/objectives/${objective.glyph}.svg)`,
        }}
      />
    );
  }
  if (kind === "baron" && dragonType) {
    return (
      <span
        className="metric-icon unavailable-objective"
        title="Chưa xác định loại mục tiêu"
      >
        ?
      </span>
    );
  }
  const glyph =
    kind !== "dragon"
      ? kind
      : element && ["air", "water", "fire", "earth"].includes(element)
        ? element
        : null;
  if (glyph)
    return (
      <span
        className={`metric-icon ${kind} traced-metric`}
        aria-hidden="true"
        style={{
          maskImage: `url(/broadcast/glyphs/${glyph}.svg)`,
          WebkitMaskImage: `url(/broadcast/glyphs/${glyph}.svg)`,
        }}
      />
    );
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
function RoleQuestIcon({
  role,
  completed,
  progress,
}: {
  role: "top" | "jungle" | "mid" | "bot" | "support";
  completed: boolean;
  progress?: number | null;
}) {
  return (
    <span
      className={`role-quest-icon ${completed ? "completed" : ""}`}
      role="img"
      aria-label={`Role quest ${role}`}
      title={
        completed
          ? "Hoàn thành"
          : progress != null
            ? `${Math.round(progress * 100)}%`
            : "Chưa có progress"
      }
    >
      {progress != null && !completed && (
        <svg
          className="quest-progress"
          viewBox="0 0 32 32"
          aria-label={`Tiến độ ${Math.round(progress * 100)}%`}
        >
          <circle
            cx="16"
            cy="16"
            r="15"
            fill="none"
            stroke="currentColor"
            strokeWidth="2"
            pathLength="100"
            strokeDasharray={`${progress * 100} 100`}
            transform="rotate(-90 16 16)"
          />
        </svg>
      )}
      <i
        className="role-quest-glyph"
        style={{
          maskImage: `url(/broadcast/glyphs/role-${role}.svg)`,
          WebkitMaskImage: `url(/broadcast/glyphs/role-${role}.svg)`,
        }}
      />
    </span>
  );
}
const roleQuestRoles = ["top", "jungle", "mid", "bot", "support"] as const;
function RoleQuestRow({
  quests,
}: {
  quests: Array<{
    role: (typeof roleQuestRoles)[number];
    completed: boolean;
    progress?: number | null;
  }> | null;
}) {
  return (
    <>
      {roleQuestRoles.map((role) => (
        <RoleQuestIcon
          key={role}
          role={role}
          completed={
            quests?.find((quest) => quest.role === role)?.completed === true
          }
          progress={quests?.find((quest) => quest.role === role)?.progress}
        />
      ))}
    </>
  );
}
function LiveRow({
  player,
  slot,
  red,
  assetsReady,
  time,
  alert,
  previewBuffs,
}: {
  player?: ObservedPlayer;
  slot: number;
  red: boolean;
  assetsReady: boolean;
  time: number | null;
  alert?: ObservedEvent;
  previewBuffs?: "baron" | "elder" | "both" | "none";
}) {
  const c = assetsReady ? liveChampion(player?.championId.value) : undefined;
  const ultimate = player?.cooldowns?.value?.find((c) => c.kind === "ultimate");
  const ultimateRemaining =
    time == null || !ultimate ? null : Math.max(0, ultimate.readyAt - time);
  const inventory = player?.inventory?.value;
  const quest = player?.roleQuest?.value;
  const reward =
    quest?.completed && assetsReady
      ? quest.rewardItemId
        ? liveItem(quest.rewardItemId)
        : liveSpell(quest.rewardSpellId)
      : undefined;
  const runes = assetsReady
    ? runeSummary(player?.perks?.value, player?.keystone?.value)
    : { keystone: undefined, secondary: undefined };
  const secondary = quest?.completed ? reward : runes.secondary;
  const ids = inventory
    ? Array.from(
        { length: 6 },
        (_, slot) => inventory.find((i) => i.slot === slot)?.id ?? null,
      )
    : Array.from({ length: 6 }, (_, i) => player?.items.value?.[i] ?? null);
  const trinketId = inventory?.find((i) => i.slot === 6)?.id;
  const trinket = assetsReady ? liveItem(trinketId) : undefined;
  const health = player?.health?.value,
    resource = player?.resource?.value;
  const dead = player?.isDead?.value === true;
  return (
    <div
      className={`ref-player-row live-player-row ${red ? "red-row" : ""} ${dead ? "is-dead" : ""}`}
    >
      {alert?.kind === "RoleQuestCompleted" && quest && (
        <QuestCompletion role={quest.role} reward={reward} />
      )}
      <div className="row-vision">
        <b>
          {player?.wardScore?.value == null
            ? ""
            : Math.floor(player.wardScore.value)}
        </b>
        {trinket ? (
          <img src={trinket.icon} alt={trinket.name} title={trinket.name} />
        ) : (
          <span
            className="live-icon-empty"
            title={
              trinketId
                ? `Chưa có asset item ${trinketId}`
                : "Slot 6 trống / chưa có dữ liệu"
            }
          >
            {trinketId ? "?" : ""}
          </span>
        )}
      </div>
      <div className="row-items" aria-label="Trang bị">
        {(red ? ids : [...ids].reverse()).map((id, i) => {
          const asset = assetsReady ? liveItem(id) : undefined;
          const itemSlot = red ? i : 5 - i;
          const cd = player?.cooldowns?.value?.find(
            (c) =>
              showItemCooldown(id) &&
              c.kind === "item" &&
              c.id === id &&
              c.slot === String(itemSlot),
          );
          const remaining =
            time == null || !cd ? 0 : Math.max(0, cd.readyAt - time);
          return asset ? (
            <span
              key={i}
              className={`live-item-slot ${cd || id === 3026 ? "tracked-item" : ""}`}
              title={asset.name}
            >
              <img src={asset.icon} alt={asset.name} />
              {cd && <CooldownVeil remaining={remaining} total={cd.total} />}
            </span>
          ) : (
            <span
              className="live-icon-empty"
              key={i}
              title={
                id
                  ? `Chưa có asset item ${id}`
                  : `Slot ${i + 1} trống / chưa có dữ liệu`
              }
            >
              {id ? "?" : ""}
            </span>
          );
        })}
      </div>
      <div className="row-runes" aria-label="Ngọc chính và nhánh phụ">
        <span
          className="row-keystone"
          title={runes.keystone?.name ?? "Chưa có ngọc chủ chốt"}
        >
          {runes.keystone && (
            <img src={runes.keystone.icon} alt={runes.keystone.name} />
          )}
        </span>
        <span
          className={`row-secondary ${quest?.completed ? "quest-reward" : "rune-path"}`}
          title={
            secondary?.name ??
            (quest?.completed
              ? "Chưa có icon phần thưởng quest"
              : "Chưa có nhánh ngọc phụ")
          }
        >
          {secondary && <img src={secondary.icon} alt={secondary.name} />}
        </span>
      </div>
      <div className="row-spells">
        {[0, 1].map((i) => {
          const s = assetsReady
            ? liveSpell(player?.spells?.value?.[i])
            : undefined;
          const cd = player?.cooldowns?.value?.find(
            (c) => c.kind === "spell" && c.slot === (i === 0 ? "D" : "F"),
          );
          const remaining =
            time == null || !cd ? 0 : Math.max(0, cd.readyAt - time);
          return s ? (
            <span key={i} className="live-spell-slot" title={s.name}>
              <img src={s.icon} alt={s.name} />
              {cd && <CooldownVeil remaining={remaining} total={cd.total} />}
            </span>
          ) : (
            <span className="live-icon-empty" key={i}>
              {""}
            </span>
          );
        })}
      </div>
      <div className="row-champion live-champion">
        {c ? <img src={c.icon} alt={c.name} title={c.name} /> : <span>?</span>}
        {dead && (
          <span className="live-respawn">
            {player?.respawnSeconds?.value == null
              ? "†"
              : Math.ceil(player.respawnSeconds.value)}
          </span>
        )}
        <b>{value(player?.level.value)}</b>
        {(previewBuffs
          ? !dead && (previewBuffs === "baron" || previewBuffs === "both")
          : player?.hasBaron?.value === true) && (
          <i className="baron-player-buff" title="Bùa lợi Baron" />
        )}
        {(previewBuffs
          ? !dead && (previewBuffs === "elder" || previewBuffs === "both")
          : player?.hasElder?.value === true) && (
          <i className="elder-player-buff" title="Bùa lợi Rồng Ngàn Tuổi" />
        )}
        {alert && alert.kind !== "RoleQuestCompleted" && (
          <span key={alert.id} className="portrait-alert">
            {alert.kind === "LevelUp"
              ? `↑ ${alert.level}`
              : (() => {
                  const item = liveItem(alert.itemId);
                  return item ? (
                    <img src={item.icon} alt={item.name} />
                  ) : (
                    "ITEM"
                  );
                })()}
          </span>
        )}
      </div>
      <div className="row-name">
        {c?.ultimateIcon && (
          <span
            className={`minimal-ultimate ${ultimateRemaining === null || ultimateRemaining > 0 ? "on-cooldown" : ""}`}
            title={
              ultimateRemaining === null
                ? "Chưa có dữ liệu cooldown R"
                : `R ${Math.ceil(ultimateRemaining)}`
            }
          >
            <img src={c.ultimateIcon} alt="Chiêu cuối" />
          </span>
        )}
        <div>
          {c?.ultimateIcon ? (
            <span
              className={`row-ultimate ${ultimateRemaining === null || ultimateRemaining > 0 ? "on-cooldown" : ""}`}
              title={
                ultimateRemaining === null
                  ? "Chưa có dữ liệu cooldown R"
                  : `R ${Math.ceil(ultimateRemaining)}`
              }
            >
              <img src={c.ultimateIcon} alt="Chiêu cuối" />
              {ultimateRemaining != null && ultimateRemaining > 0 && (
                <small>{Math.ceil(ultimateRemaining)}</small>
              )}
            </span>
          ) : (
            <span className="live-rune-empty" />
          )}
          <b title={c?.name}>
            {c?.name ?? `${red ? "RED" : "BLUE"} ${slot + 1}`}
          </b>
        </div>
        {health ? (
          <span className="health-track">
            <i
              style={{
                width: `${Math.min(100, (100 * health.current) / health.max)}%`,
              }}
            />
          </span>
        ) : (
          <span className="live-missing-stat">HP</span>
        )}
        {resource ? (
          <span className="resource-track">
            <i
              style={{
                width: `${Math.min(100, (100 * resource.current) / resource.max)}%`,
              }}
            />
          </span>
        ) : (
          <span className="live-missing-stat">MP</span>
        )}
      </div>
      <div className="row-numbers">
        <b>{value(player?.cs.value)}</b>
        <span>
          {value(player?.kills.value)}/{value(player?.deaths.value)}/
          {value(player?.assists.value)}
        </span>
      </div>
    </div>
  );
}
export function LiveOverlay({
  theme,
  frame,
  now,
  rehearsal,
}: {
  theme: Theme;
  frame: ObserverFrame | null;
  now: number;
  rehearsal?: RehearsalDisplay;
}) {
  const v = livePresentation(frame, now);
  const [baronWindow, setBaronWindow] = useState<BaronWindow | null>(null);
  const [elderWindow, setElderWindow] = useState<ElderWindow | null>(null);
  const [objectiveAlert, setObjectiveAlert] = useState<{
    event: ObservedEvent;
    expiresAt: number;
  } | null>(null);
  const [portraitAlerts, setPortraitAlerts] = useState<
    Record<number, { event: ObservedEvent; expiresAt: number }>
  >({});
  const [structureAlerts, setStructureAlerts] = useState<
    Array<{ event: ObservedEvent; expiresAt: number }>
  >([]);
  useEffect(() => {
    setBaronWindow((previous) => advanceBaronWindow(previous, frame));
    setElderWindow((previous) => advanceElderWindow(previous, frame));
    if (
      !frame ||
      ["lost", "seek", "reconnected", "source-changed"].includes(
        frame.transition,
      )
    ) {
      setObjectiveAlert(null);
      setPortraitAlerts({});
      setStructureAlerts([]);
      return;
    }
    const event =
      latestObjectiveEvent(frame) ??
      frame.newEvents.find((e) => e.kind === "TurretKilled");
    const manualCue = frame.playback?.trigger === "manual-rehearsal";
    if (manualCue && !event) setObjectiveAlert(null);
    if (event) setObjectiveAlert({ event, expiresAt: now + 7000 });
    setStructureAlerts((previous) =>
      [
        ...(manualCue ? [] : previous.filter((a) => a.expiresAt > now)),
        ...frame.newEvents
          .filter((e) =>
            ["InhibKilled", "ChampionKill", "Ace"].includes(e.kind),
          )
          .map((event) => ({ event, expiresAt: now + 7000 })),
      ].slice(-4),
    );
    setPortraitAlerts((previous) => {
      const next = manualCue ? {} : { ...previous };
      for (const e of frame.newEvents)
        if (
          (e.kind === "LevelUp" ||
            e.kind === "ItemCompleted" ||
            e.kind === "RoleQuestCompleted") &&
          e.playerSlot != null
        )
          if (
            e.kind === "RoleQuestCompleted" ||
            next[e.playerSlot]?.event.kind !== "RoleQuestCompleted" ||
            next[e.playerSlot].expiresAt <= now
          )
            next[e.playerSlot] = {
              event: e,
              expiresAt: now + (e.kind === "RoleQuestCompleted" ? 4000 : 3000),
            };
      return next;
    });
  }, [frame?.sessionId, frame?.epoch, frame?.sequence]);
  const recordedObjectiveAlert =
    v.sample && objectiveAlert && now < objectiveAlert.expiresAt
      ? objectiveAlert.event
      : null;
  const variant = rehearsal?.variant;
  const previewAt = rehearsal?.previewAt ?? v.time ?? 0;
  const visibleObjectiveAlert =
    recordedObjectiveAlert && variant
      ? {
          ...recordedObjectiveAlert,
          ...(variant.dragon ? { objectiveType: variant.dragon } : {}),
          ...(variant.tower ? { firstTurret: variant.tower === "first" } : {}),
        }
      : recordedObjectiveAlert;
  const playerAlert = (slot: number) =>
    v.sample && portraitAlerts[slot]?.expiresAt > now
      ? portraitAlerts[slot].event
      : undefined;
  const delta =
    v.blueGold !== null && v.redGold !== null ? v.redGold - v.blueGold : null;
  const previewBaron = variant?.buffs === "baron" || variant?.buffs === "both";
  const previewElder = variant?.buffs === "elder" || variant?.buffs === "both";
  const powerPlay = variant?.buffs
    ? previewBaron
      ? {
          team: "ORDER" as const,
          startedAt: previewAt,
          endsAt: previewAt + BARON_BUFF_SECONDS,
          goldDelta: 1500,
        }
      : null
    : rehearsal?.kind === "baron"
      ? rehearsal.powerPlay
      : !rehearsal && baronWindow && v.sample
        ? {
            team: baronWindow.team,
            startedAt: baronWindow.startedAt,
            endsAt: baronWindow.startedAt + BARON_BUFF_SECONDS,
            goldDelta: baronGoldDelta(baronWindow, v.sample),
          }
        : null;
  const powerPlayEnd = powerPlay
    ? Math.min(
        powerPlay.startedAt + BARON_BUFF_SECONDS,
        powerPlay.endsAt ?? Infinity,
      )
    : null;
  const showPowerPlay =
    v.sample &&
    (variant?.buffs
      ? previewBaron
      : rehearsal?.kind === "baron" || powerPlay) &&
    (previewBaron || !powerPlay || !allBaronLost(v.sample, powerPlay.team)) &&
    (powerPlayEnd == null || v.time == null || v.time < powerPlayEnd);
  const elderTeam =
    (previewElder ? "ORDER" : elderWindow?.team) ??
    v.sample?.players.find((p) => p.hasElder?.value === true)?.team.value;
  const elderEnd = previewElder
    ? previewAt + ELDER_BUFF_SECONDS
    : elderWindow
      ? elderWindow.startedAt + ELDER_BUFF_SECONDS
      : null;
  const showElder =
    v.sample &&
    (variant?.buffs ? previewElder : elderTeam) &&
    (previewElder || !allElderLost(v.sample, elderTeam!)) &&
    (elderEnd == null || v.time == null || v.time < elderEnd);
  const clock =
    v.time === null
      ? "00:00"
      : `${Math.floor(v.time / 60)
          .toString()
          .padStart(2, "0")}:${Math.floor(v.time % 60)
          .toString()
          .padStart(2, "0")}`;
  return (
    <>
      {rehearsal && v.sample && (
        <div className="rehearsal-watermark">
          {variant
            ? "GIẢ LẬP UI · NỀN SNAPSHOT THẬT"
            : "KÍCH HOẠT THỬ · SNAPSHOT THẬT"}
        </div>
      )}
      {rehearsal?.kind === "runes" && v.sample && (
        <aside className="real-rune-board" data-region="runes">
          <h3>TEAM RUNES</h3>
          <div className="rune-teams">
            {[v.blue, v.red].map((players, side) => (
              <div className={`rune-team ${side ? "red" : "blue"}`} key={side}>
                {players.map((p) => (
                  <div className="rune-card" key={p.slot}>
                    {v.sample?.assetVersion === liveCatalog.version &&
                      liveChampion(p.championId.value) && (
                        <img
                          className="rune-champion"
                          src={liveChampion(p.championId.value)!.icon}
                          alt={liveChampion(p.championId.value)!.name}
                        />
                      )}
                    <span className="rune-grid">
                      {p.perks?.value?.map((id, i) => {
                        const rune =
                          v.sample?.assetVersion === liveCatalog.version
                            ? liveRune(id)
                            : undefined;
                        return rune ? (
                          <img
                            key={i}
                            src={rune.icon}
                            alt={rune.name}
                            title={rune.name}
                          />
                        ) : (
                          <i key={i} title={`Perk ID ${id}; chưa có asset`}>
                            {id}
                          </i>
                        );
                      })}
                    </span>
                  </div>
                ))}
              </div>
            ))}
          </div>
          <b className="rune-blue-name">{theme.blueName}</b>
          <b className="rune-versus">VS</b>
          <b className="rune-red-name">{theme.redName}</b>
        </aside>
      )}
      {rehearsal?.kind === "gold" && v.sample && (
        <aside className="real-gold-ranking" data-region="gold">
          <h3>TOTAL GOLD</h3>
          {[...v.sample.players]
            .filter((p) => p.totalGold.value != null)
            .sort((a, b) => b.totalGold.value! - a.totalGold.value!)
            .map((p, index) => (
              <div
                key={p.slot}
                className={p.team.value === "ORDER" ? "blue" : "red"}
              >
                {v.sample?.assetVersion === liveCatalog.version &&
                  liveChampion(p.championId.value) && (
                    <img src={liveChampion(p.championId.value)!.icon} alt="" />
                  )}
                <span>
                  {liveChampion(p.championId.value)?.name ??
                    `SLOT ${p.slot + 1}`}
                </span>
                <b>{gold(p.totalGold.value)}</b>
                <span className="ranking-track">
                  <i
                    style={{
                      width: `${(100 * p.totalGold.value!) / Math.max(1, ...v.sample!.players.map((p) => p.totalGold.value ?? 0))}%`,
                    }}
                  />
                </span>
              </div>
            ))}
        </aside>
      )}
      {showPowerPlay && (
        <aside
          className="real-powerplay"
          data-region="baron"
          title="Δ vàng suy ra từ mốc nhận buff; timer quy tắc 3 phút, kết thúc sớm khi cả đội mất buff quan sát"
        >
          <span className="powerplay-symbol">
            <MetricIcon kind="baron" />
          </span>
          <h3 className="sr-only">
            {powerPlay?.team === "ORDER"
              ? theme.blueName
              : powerPlay?.team === "CHAOS"
                ? theme.redName
                : "BARON"}
          </h3>
          <b>
            {powerPlay?.goldDelta != null
              ? `${powerPlay.goldDelta >= 0 ? "+" : ""}${Math.round(powerPlay.goldDelta).toLocaleString("en-US")}`
              : "CHƯA CÓ MỐC VÀNG"}
          </b>
          <time>
            {powerPlayEnd != null && v.time != null
              ? countdown(powerPlayEnd - v.time)
              : "--:--"}
          </time>
          <small className="sr-only">
            Δ GOLD · SUY RA · TIMER QUY TẮC 3 PHÚT
          </small>
        </aside>
      )}
      {frame?.playback && (
        <div className="recording-watermark">BẢN GHI / KIỂM THỬ</div>
      )}
      {theme.widgets.objectives && showElder && (
        <aside
          className={`real-elder-timer ${showPowerPlay ? "alongside-baron" : ""}`}
          data-region="elder"
          title="Rồng Ngàn Tuổi: timer quy tắc 150 giây; buff từng player do LB báo, không tính vàng"
        >
          <span className="elder-symbol">
            <MetricIcon kind="dragon" dragonType="elder" />
          </span>
          <b>{elderTeam === "ORDER" ? theme.blueName : theme.redName}</b>
          <time>
            {elderEnd != null && v.time != null
              ? countdown(elderEnd - v.time)
              : "--:--"}
          </time>
        </aside>
      )}
      <header
        className="ref-scoreboard live-scoreboard"
        data-region="scoreboard"
        data-source="observed"
      >
        <div className="score-main">
          <div className="score-team side-blue">
            <span className="live-series-pips" aria-hidden="true">
              <i />
              <i />
              <i />
            </span>
            {theme.blueName === "KT" && (
              <span className="broadcast-mark mark-kt" aria-label="KT" />
            )}
            <div className="team-caption">
              <b>{theme.blueName}</b>
              <span>BLUE</span>
            </div>
          </div>
          <div className="score-economy">
            <span title="Số trụ">
              <MetricIcon kind="tower" />
              {value(v.blueTowers)}
            </span>
            <span>
              <MetricIcon kind="gold" />
              {theme.widgets.gold ? gold(v.blueGold) : ""}
              {theme.widgets.gold && delta !== null && delta < 0 && (
                <small className="blue-lead">+{goldGap(Math.abs(delta))}</small>
              )}
            </span>
          </div>
          <div className="score-kills">
            <b>{value(v.blueKills)}</b>
            <span className="live-versus" aria-label="Giải đấu">
              ◆
            </span>
            <b>{value(v.redKills)}</b>
          </div>
          <div className="score-economy right">
            <span>
              {theme.widgets.gold ? gold(v.redGold) : ""}
              <MetricIcon kind="gold" />
              {theme.widgets.gold && delta !== null && delta > 0 && (
                <small className="red-lead">+{goldGap(delta)}</small>
              )}
            </span>
            <span title="Số trụ">
              {value(v.redTowers)}
              <MetricIcon kind="tower" />
            </span>
          </div>
          <div className="score-team side-red">
            <span className="live-series-pips" aria-hidden="true">
              <i />
              <i />
              <i />
            </span>
            <div className="team-caption">
              <b>{theme.redName}</b>
              <span>RED</span>
            </div>
            {theme.redName === "T1" && (
              <span className="broadcast-mark mark-t1" aria-label="T1" />
            )}
          </div>
        </div>
        <div className="score-sub">
          <span
            className="live-role-quests blue-role-quests"
            aria-label="Role Quest đội xanh"
          >
            <RoleQuestRow quests={v.blueRoleQuests} />
            <span className="grub-count" title="Sâu hư không đội xanh">
              <MetricIcon kind="baron" dragonType="GRUB" />
              <b>
                {v.sample?.teams?.find((t) => t.team === "ORDER")?.grubs
                  .value ?? "—"}
              </b>
            </span>
          </span>
          <span
            className="live-dragons blue-team-dragons"
            aria-label="Rồng đội xanh"
          >
            {!v.sample
              ? "CHỜ DỮ LIỆU"
              : v.blueDragons?.map((type, i) => (
                  <span
                    className={`dragon-token dragon-${type.toLowerCase()}`}
                    title={type}
                    key={`${type}-${i}`}
                  >
                    <MetricIcon kind="dragon" dragonType={type} />
                  </span>
                ))}
          </span>
          <time>{clock}</time>
          <span
            className="live-dragons red-team-dragons"
            aria-label="Rồng đội đỏ"
          >
            {v.redDragons?.map((type, i) => (
              <span
                className={`dragon-token dragon-${type.toLowerCase()}`}
                title={type}
                key={`${type}-${i}`}
              >
                <MetricIcon kind="dragon" dragonType={type} />
              </span>
            ))}
          </span>
          <span
            className="live-role-quests red-role-quests"
            aria-label="Role Quest đội đỏ"
          >
            <RoleQuestRow quests={v.redRoleQuests} />
            <span className="grub-count" title="Sâu hư không đội đỏ">
              <MetricIcon kind="baron" dragonType="GRUB" />
              <b>
                {v.sample?.teams?.find((t) => t.team === "CHAOS")?.grubs
                  .value ?? "—"}
              </b>
            </span>
          </span>
        </div>
      </header>
      {theme.widgets.objectives &&
        visibleObjectiveAlert &&
        (() => {
          const blue = visibleObjectiveAlert.team === "ORDER";
          if (visibleObjectiveAlert.kind === "TurretKilled")
            return (
              <TowerBanner
                team={blue ? theme.blueName : theme.redName}
                first={visibleObjectiveAlert.firstTurret}
              />
            );
          if (visibleObjectiveAlert.kind === "DragonSoul") {
            return <SoulTakeover event={visibleObjectiveAlert} theme={theme} />;
          }
          if (visibleObjectiveAlert.kind === "DragonKill")
            return <DragonBanner type={visibleObjectiveAlert.objectiveType} />;
          const team = blue ? theme.blueName : theme.redName;
          const dragonNames: Record<string, string> = {
            fire: "RỒNG LỬA",
            earth: "RỒNG ĐẤT",
            water: "RỒNG NƯỚC",
            air: "RỒNG GIÓ",
            hextech: "RỒNG HEXTECH",
            chemtech: "RỒNG HÓA KỸ",
            elder: "RỒNG NGÀN TUỔI",
          };
          const dragon =
            dragonNames[visibleObjectiveAlert.objectiveType ?? ""] ?? "RỒNG";
          const objective =
            visibleObjectiveAlert.kind === "BaronKill"
              ? "BARON NASHOR"
              : dragon;
          return (
            <aside
              className={`live-event-banner ${blue ? "blue" : "red"}`}
              role="status"
            >
              <MetricIcon
                dragonType={visibleObjectiveAlert.objectiveType}
                kind={
                  visibleObjectiveAlert.kind === "BaronKill"
                    ? "baron"
                    : "dragon"
                }
              />
              <div>
                <b>{team}</b>
                <span>ĐÃ HẠ GỤC {objective}</span>
              </div>
            </aside>
          );
        })()}
      {theme.widgets.objectives && (
        <div className="live-objective-stack">
          {v.pitTimers.map((timer) => {
            const timerType =
              timer.pit === "baron"
                ? (variant?.pit ?? timer.type.value)
                : variant?.dragon
                  ? `DRAGON_${variant.dragon.toUpperCase()}`
                  : timer.type.value;
            const at = timer.timeAlive.value;
            const destroy = timer.timeDestroy.value;
            const remaining =
              rehearsal?.kind === "timers" && variant
                ? Math.max(0, previewAt + 120 - (v.time ?? previewAt))
                : v.time == null
                  ? null
                  : at != null && at > v.time
                    ? at - v.time
                    : destroy != null && destroy > v.time
                      ? destroy - v.time
                      : 0;
            const label =
              objectiveVisual(timerType)?.label ?? "CHƯA XÁC ĐỊNH MỤC TIÊU";
            return (
              <aside
                className="ref-objective live-objective"
                key={timer.pit}
                title={label}
              >
                <span>
                  <MetricIcon
                    kind={timer.pit === "baron" ? "baron" : "dragon"}
                    dragonType={timerType ?? undefined}
                  />
                </span>
                <div>
                  <small>{label}</small>
                  <b>
                    {remaining == null
                      ? "--:--"
                      : remaining <= 0
                        ? "LIVE"
                        : `${Math.floor(remaining / 60)
                            .toString()
                            .padStart(2, "0")}:${Math.floor(remaining % 60)
                            .toString()
                            .padStart(2, "0")}`}
                  </b>
                </div>
              </aside>
            );
          })}
        </div>
      )}
      {theme.widgets.objectives && v.sample && (
        <>
          <InhibitorTimers
            preview={
              variant?.inhibitorTeam
                ? { team: variant.inhibitorTeam, endsAt: previewAt + 300 }
                : undefined
            }
            sample={v.sample}
            time={v.time}
            theme={theme}
            team={
              rehearsal?.kind === "inhibitorBlue"
                ? "ORDER"
                : rehearsal?.kind === "inhibitorRed"
                  ? "CHAOS"
                  : undefined
            }
          />
        </>
      )}
      {theme.widgets.players && rehearsal?.kind !== "runes" && (
        <section
          className="ref-player-table"
          data-region="players"
          data-source="observed"
        >
          <div className="table-blue">
            {Array.from({ length: 5 }, (_, i) => (
              <LiveRow
                key={i}
                slot={i}
                player={v.blue[i]}
                assetsReady={v.sample?.assetVersion === liveCatalog.version}
                red={false}
                time={v.time}
                alert={playerAlert(v.blue[i]?.slot ?? i)}
                previewBuffs={variant?.buffs}
              />
            ))}
          </div>
          <div className="table-gold">
            {v.laneGold.map((gap, i) => (
              <div key={i} className={gap ? `lane-gold-${gap.leader}` : ""}>
                {theme.widgets.gold && gap && gap.leader !== "even" && (
                  <i
                    className={`lane-gold-arrow ${gap.leader}`}
                    aria-label={`Đội ${gap.leader === "blue" ? "xanh" : "đỏ"} dẫn vàng`}
                  />
                )}
                {theme.widgets.gold && gap && gap.leader !== "even"
                  ? goldGap(gap.value)
                  : ""}
              </div>
            ))}
          </div>
          <div className="table-red">
            {Array.from({ length: 5 }, (_, i) => (
              <LiveRow
                key={i}
                slot={i}
                player={v.red[i]}
                assetsReady={v.sample?.assetVersion === liveCatalog.version}
                red
                time={v.time}
                alert={playerAlert(v.red[i]?.slot ?? i + 5)}
                previewBuffs={variant?.buffs ? "none" : undefined}
              />
            ))}
          </div>
        </section>
      )}
      {theme.widgets.killfeed && v.sample && (
        <div className="killfeed">
          {structureAlerts
            .filter((a) => a.expiresAt > now)
            .map(({ event }) => (
              <div key={event.id}>
                {event.team === "ORDER"
                  ? theme.blueName
                  : event.team === "CHAOS"
                    ? theme.redName
                    : ""}{" "}
                ·{" "}
                {
                  (
                    {
                      TurretKilled: "PHÁ TRỤ",
                      InhibKilled: "PHÁ NHÀ LÍNH",
                      InhibRespawned: "NHÀ LÍNH HỒI SINH",
                      ChampionKill: "HẠ GỤC",
                      Ace: "QUÉT SẠCH",
                    } as Record<string, string>
                  )[event.kind]
                }
              </div>
            ))}
        </div>
      )}
      {(theme.widgets.levels || rehearsal?.kind === "levels") && v.sample && (
        <aside className="live-level-ranking" data-region="levels">
          <h3>LEVEL / EXPERIENCE</h3>
          {rankLevels(v.sample.players).map((p) => {
            const progress = levelProgress(p);
            return (
              <div
                key={p.slot}
                className={p.team.value === "CHAOS" ? "red" : "blue"}
                data-slot={p.slot}
              >
                {v.sample?.assetVersion === liveCatalog.version &&
                  liveChampion(p.championId.value) && (
                    <img
                      width="30"
                      height="30"
                      src={liveChampion(p.championId.value)!.icon}
                      alt=""
                    />
                  )}
                <div className="level-summary">
                  <span>
                    {liveChampion(p.championId.value)?.name ??
                      `SLOT ${p.slot + 1}`}
                  </span>
                  {progress == null ? (
                    <span
                      className="level-progress unavailable"
                      title="Chưa có dữ liệu XP"
                    >
                      CHƯA CÓ XP
                    </span>
                  ) : (
                    <span
                      className="level-progress"
                      role="progressbar"
                      aria-label="Tiến độ cấp tiếp theo"
                      aria-valuemin={0}
                      aria-valuemax={100}
                      aria-valuenow={Math.round(progress * 100)}
                    >
                      <i style={{ width: `${progress * 100}%` }} />
                    </span>
                  )}
                </div>
                <b>{p.level.value ?? "—"}</b>
              </div>
            );
          })}
        </aside>
      )}
    </>
  );
}
