import { useEffect, useState, type CSSProperties } from "react";
import { MotionPresence } from "./MotionPresence";
import { BuffTimeProgress } from "./BuffTimeProgress";
import { portraitCueDuration } from "../../shared/portrait-motion";
import { RankingBoard } from "./RankingBoard";
import { ChampionStack } from "./ChampionStack";
import { ItemCounter } from "./ItemCounter";
import { stackChampion } from "../../shared/champion-stacks";
import { playerDisplayName } from "../../shared/player-name";
import { broadcastWidgetOn } from "../../shared/broadcast-controls";
import { graphicEnabled } from "../../shared/broadcast-graphics";
import { SoulTakeover } from "./SoulTakeover";
import { DragonBanner } from "./DragonBanner";
import { CooldownVeil } from "./CooldownVeil";
import { InhibitorTimers } from "./InhibitorTimers";
import { QuestCompletion } from "./QuestCompletion";
import { showItemCooldown } from "../../shared/role-quest";
import { minimalLoadout } from "../../shared/minimal-loadout";
import { seriesSlots } from "../../shared/match-config";
import { BroadcastKillfeed } from "./BroadcastKillfeed";
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
import { objectiveVisual, levelProgress, resourcePresentation } from "../../shared/ui-metrics";
import { objectiveIconUrl } from "../../shared/objective-icons";
import { liveCatalog, liveChampion, liveItem, liveSpell, liveRune } from "../../shared/live-assets";
import type { Theme } from "../../shared/schema";
import type { RehearsalDisplay } from "../../shared/rehearsal";
import type { ObservedEvent, ObservedPlayer, ObserverFrame } from "../../shared/observer";
import { latestObjectiveEvent, livePresentation } from "../../shared/live-presentation";
const value = (n: number | null | undefined) => (n == null ? "" : String(n));
const gold = (n: number | null) => (n === null ? "" : `${(n / 1000).toFixed(1)}K`);
const goldGap = (n: number) => (n >= 1000 ? `${(n / 1000).toFixed(1)}K` : String(Math.round(n)));
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
        ? (objectiveVisual(dragonType) ??
          (!dragonType ? { glyph: "dragon", label: "RỒNG", color: "#d2b47d" } : null))
        : null;
  if (objective) {
    return (
      <span
        className={`metric-icon ${kind} objective-glyph`}
        title={objective.label}
        style={{
          backgroundColor: objective.color,
          maskImage: `url(${objectiveIconUrl(objective.glyph)})`,
          WebkitMaskImage: `url(${objectiveIconUrl(objective.glyph)})`,
        }}
      />
    );
  }
  if (kind === "baron" && dragonType) {
    return (
      <span className="metric-icon unavailable-objective" title="Chưa xác định loại mục tiêu">
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
    <svg className={`metric-icon ${kind}`} viewBox="0 0 30 30" aria-hidden="true">
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
      data-role={role}
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
function LiveRow({
  player,
  slot,
  red,
  assetsReady,
  time,
  alert,
  previewBuffs,
  rowQuest,
  buffFrames = true,
  playerNames,
}: {
  playerNames?: string[];
  player?: ObservedPlayer;
  slot: number;
  red: boolean;
  assetsReady: boolean;
  time: number | null;
  alert?: ObservedEvent;
  previewBuffs?: "baron" | "elder" | "both" | "none";
  rowQuest: boolean;
  buffFrames?: boolean;
}) {
  const c = assetsReady ? liveChampion(player?.championId.value) : undefined;
  const ultimate = player?.cooldowns?.value?.find((c) => c.kind === "ultimate");
  // R cannot be used before it is learned at level 6, whatever readyAt says.
  const ultimateLocked = player?.level?.value != null && player.level.value < 6;
  const ultimateRemaining = ultimateLocked
    ? null
    : time == null || !ultimate
      ? null
      : Math.max(0, ultimate.readyAt - time);
  const ultimateTitle = ultimateLocked
    ? "Chưa học R (cấp 6)"
    : ultimateRemaining === null
      ? "Chưa có dữ liệu cooldown R"
      : `R ${Math.ceil(ultimateRemaining)}`;
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
  const secondary = !rowQuest && reward ? reward : runes.secondary;
  const stack = assetsReady && stackChampion(player?.championId.value);
  const ids = inventory
    ? Array.from({ length: 6 }, (_, slot) => inventory.find((i) => i.slot === slot)?.id ?? null)
    : Array.from({ length: 6 }, (_, i) => player?.items.value?.[i] ?? null);
  const trinketId = inventory?.find((i) => i.slot === 6)?.id;
  const trinket = assetsReady ? liveItem(trinketId) : undefined;
  const health = player?.health?.value,
    resource = player?.resource?.value;
  const dead = player?.isDead?.value === true;
  const xpProgress = player ? levelProgress(player) : null;
  const resourceStyle = resourcePresentation(player);
  const compact = assetsReady ? minimalLoadout(player) : undefined;
  return (
    <div
      className={`ref-player-row live-player-row ${red ? "red-row" : ""} ${dead ? "is-dead" : ""}`}
      style={
        {
          "--row-index": slot % 5,
          "--spread-x": `${(red ? -1 : 1) * (red ? (slot % 5) + 1 : 5 - (slot % 5)) * 100}px`,
          "--cluster-delay": `${(red ? slot % 5 : 4 - (slot % 5)) * 65}ms`,
        } as CSSProperties
      }
    >
      {alert?.kind === "RoleQuestCompleted" && quest && (
        <QuestCompletion key={alert.id} role={quest.role} reward={reward} />
      )}
      <div className="row-vision">
        <b>{player?.wardScore?.value == null ? "" : Math.floor(player.wardScore.value)}</b>
        {trinket ? (
          <span className="trinket-with-stock">
            <img src={trinket.icon} alt={trinket.name} title={trinket.name} />
            <ItemCounter player={player} id={trinketId} slot={6} />
          </span>
        ) : (
          <span
            className="live-icon-empty"
            title={trinketId ? `Chưa có asset item ${trinketId}` : "Slot 6 trống / chưa có dữ liệu"}
          >
            {trinketId ? "?" : ""}
          </span>
        )}
      </div>
      <div
        className="minimal-loadout"
        aria-label="Trang bị tối giản"
        data-side={red ? "red" : "blue"}
      >
        {compact?.reward && (
          <span
            className="live-item-slot minimal-quest-reward"
            data-position="0"
            title={compact.reward.name}
          >
            <img src={compact.reward.icon} alt={compact.reward.name} />
            <ItemCounter player={player} id={quest?.rewardItemId} />
            {compact.rewardCooldown && time != null && (
              <CooldownVeil
                remaining={Math.max(0, compact.rewardCooldown.readyAt - time)}
                total={compact.rewardCooldown.total}
              />
            )}
          </span>
        )}
        {compact?.items.map((item, i) => (
          <span
            key={item.slot}
            className="live-item-slot minimal-active-item"
            data-position={i + (compact.reward ? 1 : 0)}
            data-item-slot={item.slot}
            title={item.asset.name}
          >
            <img src={item.asset.icon} alt={item.asset.name} />
            <ItemCounter player={player} id={item.id} slot={item.slot} />
            {item.cooldown && time != null && (
              <CooldownVeil
                remaining={Math.max(0, item.cooldown.readyAt - time)}
                total={item.cooldown.total}
              />
            )}
          </span>
        ))}
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
          const remaining = time == null || !cd ? 0 : Math.max(0, cd.readyAt - time);
          return asset ? (
            <span
              key={i}
              className={`live-item-slot ${cd || id === 3026 ? "tracked-item" : ""}`}
              title={asset.name}
            >
              <img src={asset.icon} alt={asset.name} />
              <ItemCounter player={player} id={id} slot={itemSlot} />
              {cd && <CooldownVeil remaining={remaining} total={cd.total} />}
            </span>
          ) : (
            <span
              className="live-icon-empty"
              key={i}
              title={id ? `Chưa có asset item ${id}` : `Slot ${i + 1} trống / chưa có dữ liệu`}
            >
              {id ? "?" : ""}
            </span>
          );
        })}
      </div>
      {rowQuest && (
        <div
          className={`row-lane-quest ${quest?.completed ? "completed" : "pending"}`}
          aria-label="Nhiệm vụ lane"
          data-role={quest?.role}
        >
          {quest?.completed && reward ? (
            <span className="lane-reward-with-stock">
              <img
                className="quest-reward"
                src={reward.icon}
                alt={reward.name}
                title={reward.name}
              />
              <ItemCounter player={player} id={quest.rewardItemId} />
            </span>
          ) : quest ? (
            <RoleQuestIcon
              role={quest.role}
              completed={quest.completed}
              progress={quest.progress}
            />
          ) : (
            <span className="quest-unavailable" title="Chưa có dữ liệu lane quest">
              —
            </span>
          )}
        </div>
      )}
      <div
        className={`row-runes${stack ? " has-champion-stack" : ""}`}
        aria-label="Ngọc chính và nhánh phụ hoặc stack"
      >
        <span className="row-keystone" title={runes.keystone?.name ?? "Chưa có ngọc chủ chốt"}>
          {runes.keystone && <img src={runes.keystone.icon} alt={runes.keystone.name} />}
        </span>
        {stack ? (
          <ChampionStack player={player} />
        ) : (
          <span
            className={`row-secondary ${!rowQuest && reward ? "quest-reward" : "rune-path"}`}
            title={secondary?.name ?? "Chưa có nhánh ngọc phụ"}
          >
            {secondary && <img src={secondary.icon} alt={secondary.name} />}
            {!rowQuest && reward && <ItemCounter player={player} id={quest?.rewardItemId} />}
          </span>
        )}
      </div>
      <div className="row-spells">
        {[0, 1].map((i) => {
          const spellId = player?.spells?.value?.[i];
          const s = assetsReady
            ? liveSpell(
                quest?.completed && quest.role === "top" && /teleport/i.test(spellId ?? "")
                  ? (quest.rewardSpellId ?? spellId)
                  : spellId,
              )
            : undefined;
          const cd = player?.cooldowns?.value?.find(
            (c) => c.kind === "spell" && c.slot === (i === 0 ? "D" : "F"),
          );
          const remaining = time == null || !cd ? 0 : Math.max(0, cd.readyAt - time);
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
            {player?.respawnSeconds?.value == null ? "†" : Math.ceil(player.respawnSeconds.value)}
          </span>
        )}
        <b>{value(player?.level.value)}</b>
        {buffFrames &&
          (previewBuffs
            ? !dead && (previewBuffs === "baron" || previewBuffs === "both")
            : player?.hasBaron?.value === true) && (
            <i className="baron-player-buff" title="Bùa lợi Baron" />
          )}
        {buffFrames &&
          (previewBuffs
            ? !dead && (previewBuffs === "elder" || previewBuffs === "both")
            : player?.hasElder?.value === true) && (
            <i className="elder-player-buff" title="Bùa lợi Rồng Ngàn Tuổi" />
          )}
        {alert && alert.kind !== "RoleQuestCompleted" && (
          <span key={alert.id} className="portrait-alert">
            <span className="portrait-alert-content">
              {alert.kind === "LevelUp"
                ? `↑ ${alert.level}`
                : (() => {
                    const item = liveItem(alert.itemId);
                    return item ? <img src={item.icon} alt={item.name} /> : "ITEM";
                  })()}
            </span>
          </span>
        )}
      </div>
      <div className="row-name">
        {c?.ultimateIcon && (
          <span
            className={`minimal-ultimate ${ultimateRemaining === null || ultimateRemaining > 0 ? "on-cooldown" : ""}`}
            title={ultimateTitle}
          >
            <img src={c.ultimateIcon} alt="Chiêu cuối" />
            {ultimateRemaining != null && ultimate && (
              <CooldownVeil remaining={ultimateRemaining} total={ultimate.total} dark />
            )}
            {ultimateLocked && <i className="ult-lock-cover" aria-hidden="true" />}
            {stack && <ChampionStack player={player} minimal />}
          </span>
        )}
        <div>
          {c?.ultimateIcon ? (
            <span
              className={`row-ultimate ${ultimateRemaining === null || ultimateRemaining > 0 ? "on-cooldown" : ""}`}
              title={ultimateTitle}
            >
              <img src={c.ultimateIcon} alt="Chiêu cuối" />
              {ultimateRemaining != null && ultimate && (
                <CooldownVeil remaining={ultimateRemaining} total={ultimate.total} dark />
              )}
              {ultimateLocked && <i className="ult-lock-cover" aria-hidden="true" />}
            </span>
          ) : (
            <span className="live-rune-empty" />
          )}
          <b title={playerDisplayName(player, playerNames, player?.slot ?? slot + (red ? 5 : 0))}>
            {playerDisplayName(player, playerNames, player?.slot ?? slot + (red ? 5 : 0))}
          </b>
        </div>
        <span
          className={`experience-track${xpProgress === null ? " unavailable" : ""}`}
          role="progressbar"
          aria-label="Tiến độ kinh nghiệm"
          aria-valuemin={0}
          aria-valuemax={100}
          aria-valuenow={xpProgress === null ? undefined : Math.round(xpProgress * 100)}
          title={
            xpProgress === null
              ? "Chưa có XP đến cấp tiếp theo"
              : `XP ${Math.round(xpProgress * 100)}% · ngưỡng cấp SR`
          }
        >
          <i
            style={{
              width: xpProgress === null ? "0%" : `${xpProgress * 100}%`,
            }}
          />
        </span>
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
          <span
            className="resource-track"
            data-resource-kind={resourceStyle.kind}
            title={resourceStyle.label}
          >
            <i
              style={{
                width: `${dead ? 0 : Math.min(100, (100 * resource.current) / resource.max)}%`,
                backgroundColor: resourceStyle.color,
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
          {value(player?.kills.value)}/{value(player?.deaths.value)}/{value(player?.assists.value)}
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
  broadcast,
}: {
  theme: Theme;
  frame: ObserverFrame | null;
  now: number;
  rehearsal?: RehearsalDisplay;
  broadcast?: import("../../shared/schema").State["broadcast"];
}) {
  const v = livePresentation(frame, now);
  const portraitDuration = portraitCueDuration(
    rehearsal?.kind === "minimal" || broadcastWidgetOn(broadcast, "minimal", theme),
  );
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
    if (!frame || ["lost", "seek", "reconnected", "source-changed"].includes(frame.transition)) {
      setObjectiveAlert(null);
      setPortraitAlerts({});
      setStructureAlerts([]);
      return;
    }
    const event =
      latestObjectiveEvent(frame) ??
      frame.newEvents.find((e) => e.kind === "TurretKilled" && e.firstTurret === true);
    const manualCue = frame.playback?.trigger === "manual-rehearsal";
    if (manualCue && !event) setObjectiveAlert(null);
    if (event) setObjectiveAlert({ event, expiresAt: now + 7000 });
    setStructureAlerts((previous) =>
      [
        ...(manualCue ? [] : previous.filter((a) => a.expiresAt > now)),
        ...frame.newEvents
          .filter(
            (e) =>
              (e.kind !== "TurretKilled" || e.firstTurret === true) &&
              [
                "InhibKilled",
                "ChampionKill",
                "Ace",
                "DragonKill",
                "BaronKill",
                "HeraldKill",
                "TurretKilled",
              ].includes(e.kind),
          )
          .map((event) => ({ event, expiresAt: now + 7000 })),
      ].slice(-32),
    );
    setPortraitAlerts((previous) => {
      const next = manualCue ? {} : { ...previous };
      for (const e of frame.newEvents)
        if (
          (e.kind === "LevelUp" || e.kind === "ItemCompleted" || e.kind === "RoleQuestCompleted") &&
          e.playerSlot != null
        )
          if (
            e.kind === "RoleQuestCompleted" ||
            next[e.playerSlot]?.event.kind !== "RoleQuestCompleted" ||
            next[e.playerSlot].expiresAt <= now
          )
            next[e.playerSlot] = {
              event: e,
              expiresAt:
                now +
                (e.kind === "RoleQuestCompleted" ? portraitCueDuration(false) : portraitDuration),
            };
      return next;
    });
  }, [frame?.sessionId, frame?.epoch, frame?.sequence]);
  const recordedObjectiveAlert =
    v.sample && objectiveAlert && now < objectiveAlert.expiresAt ? objectiveAlert.event : null;
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
    v.sample && portraitAlerts[slot]?.expiresAt > now ? portraitAlerts[slot].event : undefined;
  const delta = v.blueGold !== null && v.redGold !== null ? v.redGold - v.blueGold : null;
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
    ? Math.min(powerPlay.startedAt + BARON_BUFF_SECONDS, powerPlay.endsAt ?? Infinity)
    : null;
  const showPowerPlay =
    graphicEnabled(theme, "baronPowerplay") &&
    v.sample &&
    (variant?.buffs ? previewBaron : rehearsal?.kind === "baron" || powerPlay) &&
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
    graphicEnabled(theme, "elderTimer") &&
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
  const showRunes =
    !!v.sample && (rehearsal?.kind === "runes" || broadcastWidgetOn(broadcast, "runes", theme));
  return (
    <>
      <MotionPresence show={showRunes}>
        <aside className="real-rune-board" data-region="runes">
          <h3>TEAM RUNES</h3>
          <div className="rune-teams">
            {[v.blue, v.red].map((players, side) => (
              <div className={`rune-team ${side ? "red" : "blue"}`} key={side}>
                {players.map((p) => (
                  <div
                    className="rune-card"
                    key={p.slot}
                    style={
                      {
                        "--rune-delay": `${480 + (p.slot % 5) * 55}ms`,
                      } as CSSProperties
                    }
                  >
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
                          v.sample?.assetVersion === liveCatalog.version ? liveRune(id) : undefined;
                        return rune ? (
                          <img key={i} src={rune.icon} alt={rune.name} title={rune.name} />
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
          <div className="rune-team-brand rune-blue-name">
            <b title={theme.blueName}>{theme.blueName}</b>
            {theme.blueLogo && (
              <img className="rune-team-logo" src={theme.blueLogo} alt={`Logo ${theme.blueName}`} />
            )}
          </div>
          <b className="rune-versus">VS</b>
          <div className="rune-team-brand rune-red-name">
            <b title={theme.redName}>{theme.redName}</b>
            {theme.redLogo && (
              <img className="rune-team-logo" src={theme.redLogo} alt={`Logo ${theme.redName}`} />
            )}
          </div>
        </aside>
      </MotionPresence>
      <RankingBoard
        sample={v.sample}
        mode="gold"
        playerNames={theme.playerNames}
        show={rehearsal?.kind === "gold" || broadcastWidgetOn(broadcast, "gold", theme)}
      />
      <MotionPresence show={!!showPowerPlay}>
        <aside
          className={`real-powerplay ${powerPlay?.team === "CHAOS" ? "buff-side-red" : "buff-side-blue"}`}
          data-team={powerPlay?.team}
          data-region="baron"
          style={
            {
              "--powerplay-color": objectiveVisual("baron")!.color,
            } as CSSProperties
          }
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
            {powerPlayEnd != null && v.time != null ? countdown(powerPlayEnd - v.time) : "--:--"}
          </time>
          <small className="sr-only">Δ GOLD · SUY RA · TIMER QUY TẮC 3 PHÚT</small>
          <BuffTimeProgress
            endAt={powerPlayEnd}
            time={v.time}
            duration={BARON_BUFF_SECONDS}
            label="Thời gian Baron còn lại"
          />
        </aside>
      </MotionPresence>
      <MotionPresence show={!!showElder}>
        <aside
          className={`real-elder-timer ${elderTeam === "CHAOS" ? "buff-side-red" : "buff-side-blue"} ${showPowerPlay && powerPlay?.team === elderTeam ? "alongside-baron" : ""}`}
          data-team={elderTeam}
          data-region="elder"
          style={
            {
              "--powerplay-color": objectiveVisual("elder")!.color,
            } as CSSProperties
          }
          title="Rồng Ngàn Tuổi: timer quy tắc 150 giây; buff từng player do LB báo, không tính vàng"
        >
          <span className="elder-symbol">
            <MetricIcon kind="dragon" dragonType="elder" />
          </span>
          <time>{elderEnd != null && v.time != null ? countdown(elderEnd - v.time) : "--:--"}</time>
          <BuffTimeProgress
            endAt={elderEnd}
            time={v.time}
            duration={ELDER_BUFF_SECONDS}
            label="Thời gian Rồng Ngàn Tuổi còn lại"
          />
        </aside>
      </MotionPresence>
      <header
        className="ref-scoreboard live-scoreboard"
        data-region="scoreboard"
        data-source="observed"
      >
        <div className="score-main">
          <div className="score-team side-blue">
            <span className="live-series-pips" aria-hidden="true">
              {Array.from(
                {
                  length: seriesSlots(theme),
                },
                (_, i) => (
                  <i key={i} className={i < (theme.blueScore ?? 0) ? "won" : ""} />
                ),
              )}
            </span>
            {theme.blueLogo && <img className="team-logo" src={theme.blueLogo} alt="" />}
            <div
              className={`team-caption ${theme.blueDescription?.trim() ? "has-description" : "name-only"}`}
              style={
                {
                  "--team-name-size": `${theme.blueName.length >= 5 ? 32 : theme.blueName.length === 4 ? 36 : 40}px`,
                } as CSSProperties
              }
            >
              <b>{theme.blueName}</b>
              {theme.blueDescription?.trim() && <span>{theme.blueDescription.trim()}</span>}
            </div>
          </div>
          <div className="score-economy">
            <span title="Số trụ">
              <MetricIcon kind="tower" />
              {value(v.blueTowers)}
            </span>
            <span>
              <MetricIcon kind="gold" />
              <span className="score-gold-value">
                {theme.widgets.gold ? gold(v.blueGold) : ""}
                {theme.widgets.gold && delta !== null && delta < 0 && (
                  <small className="blue-lead">+{goldGap(Math.abs(delta))}</small>
                )}
              </span>
            </span>
          </div>
          <div className="score-kills">
            <b>{value(v.blueKills)}</b>
            <span className="live-versus" aria-label="Giải đấu">
              {theme.scoreboardLogo ? <img src={theme.scoreboardLogo} alt="Logo giải đấu" /> : "◆"}
            </span>
            <b>{value(v.redKills)}</b>
          </div>
          <div className="score-economy right">
            <span>
              <span className="score-gold-value">
                {theme.widgets.gold ? gold(v.redGold) : ""}
                {theme.widgets.gold && delta !== null && delta > 0 && (
                  <small className="red-lead">+{goldGap(delta)}</small>
                )}
              </span>
              <MetricIcon kind="gold" />
            </span>
            <span title="Số trụ">
              {value(v.redTowers)}
              <MetricIcon kind="tower" />
            </span>
          </div>
          <div className="score-team side-red">
            <span className="live-series-pips" aria-hidden="true">
              {Array.from(
                {
                  length: seriesSlots(theme),
                },
                (_, i) => (
                  <i key={i} className={i < (theme.redScore ?? 0) ? "won" : ""} />
                ),
              )}
            </span>
            <div
              className={`team-caption ${theme.redDescription?.trim() ? "has-description" : "name-only"}`}
              style={
                {
                  "--team-name-size": `${theme.redName.length >= 5 ? 32 : theme.redName.length === 4 ? 36 : 40}px`,
                } as CSSProperties
              }
            >
              <b>{theme.redName}</b>
              {theme.redDescription?.trim() && <span>{theme.redDescription.trim()}</span>}
            </div>
            {theme.redLogo && <img className="team-logo" src={theme.redLogo} alt="" />}
          </div>
        </div>
        <div className="score-sub">
          <span
            className={
              theme.playerCameras === false
                ? "live-team-grubs blue-team-grubs"
                : "live-role-quests blue-role-quests"
            }
            aria-label="Sâu hư không đội xanh"
          >
            {theme.playerCameras !== false &&
              v.blue.map(
                (p) => p.roleQuest?.value && <RoleQuestIcon key={p.slot} {...p.roleQuest.value} />,
              )}
            <span className="grub-count" title="Sâu hư không đội xanh">
              <MetricIcon kind="baron" dragonType="GRUB" />
              <b>{v.sample?.teams?.find((t) => t.team === "ORDER")?.grubs.value ?? "—"}</b>
            </span>
          </span>
          <span className="live-dragons blue-team-dragons" aria-label="Rồng đội xanh">
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
          <span className="live-dragons red-team-dragons" aria-label="Rồng đội đỏ">
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
            className={
              theme.playerCameras === false
                ? "live-team-grubs red-team-grubs"
                : "live-role-quests red-role-quests"
            }
            aria-label="Sâu hư không đội đỏ"
          >
            {theme.playerCameras !== false &&
              v.red.map(
                (p) => p.roleQuest?.value && <RoleQuestIcon key={p.slot} {...p.roleQuest.value} />,
              )}
            <span className="grub-count" title="Sâu hư không đội đỏ">
              <MetricIcon kind="baron" dragonType="GRUB" />
              <b>{v.sample?.teams?.find((t) => t.team === "CHAOS")?.grubs.value ?? "—"}</b>
            </span>
          </span>
        </div>
      </header>
      {(graphicEnabled(theme, "objectiveBanners") || graphicEnabled(theme, "soulTakeover")) &&
        visibleObjectiveAlert &&
        (() => {
          const blue = visibleObjectiveAlert.team === "ORDER";
          if (visibleObjectiveAlert.kind === "TurretKilled")
            return visibleObjectiveAlert.firstTurret === true ? (
              <TowerBanner
                team={blue ? theme.blueName : theme.redName}
                first={visibleObjectiveAlert.firstTurret}
              />
            ) : null;
          if (visibleObjectiveAlert.kind === "DragonSoul") {
            return (
              <SoulTakeover
                key={visibleObjectiveAlert.id}
                event={visibleObjectiveAlert}
                theme={theme}
                artworkVisible={graphicEnabled(theme, "soulTakeover")}
                bannerVisible={graphicEnabled(theme, "objectiveBanners")}
              />
            );
          }
          if (!graphicEnabled(theme, "objectiveBanners")) return null;
          if (visibleObjectiveAlert.kind === "DragonKill")
            return (
              <DragonBanner
                key={visibleObjectiveAlert.id}
                type={visibleObjectiveAlert.objectiveType}
              />
            );
          // No generic "team has slain" center banner. Dedicated dragon/soul
          // strip, first-turret banner, counters and powerplays remain independent.
          return null;
        })()}
      <MotionPresence show={graphicEnabled(theme, "pitTimers") && !!v.sample}>
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
                : timer.isAlive?.value === true
                  ? 0
                  : v.time == null
                    ? null
                    : at != null && at > v.time
                      ? at - v.time
                      : destroy != null && destroy > v.time
                        ? destroy - v.time
                        : 0;
            const label =
              objectiveVisual(timerType)?.label ??
              (timerType === "dragon" ? "RỒNG NGUYÊN TỐ · CHƯA RÕ LOẠI" : "CHƯA XÁC ĐỊNH MỤC TIÊU");
            return (
              <MotionPresence
                key={timer.pit}
                show={!(timer.pit === "baron" ? showPowerPlay : showElder)}
              >
                <aside
                  className={`ref-objective live-objective${remaining === 0 ? " is-available" : ""}`}
                  style={
                    {
                      "--objective-color": objectiveVisual(timerType)?.color ?? "#a3a9ac",
                    } as CSSProperties
                  }
                  data-pit={timer.pit}
                  data-available={remaining === 0}
                  key={timer.pit}
                  title={`${label}${timer.basis === "rule-estimate" ? " · timer suy ra từ event + quy tắc SR; phòng tập có thể khác" : ""}`}
                  data-basis={timer.basis ?? "reported"}
                >
                  <span>
                    <MetricIcon
                      kind={timer.pit === "baron" ? "baron" : "dragon"}
                      dragonType={timerType ?? undefined}
                    />
                  </span>
                  <div aria-hidden={remaining === 0}>
                    <small>{label}</small>
                    <b>
                      {remaining == null
                        ? "--:--"
                        : remaining <= 0
                          ? ""
                          : `${Math.floor(remaining / 60)
                              .toString()
                              .padStart(2, "0")}:${Math.floor(remaining % 60)
                              .toString()
                              .padStart(2, "0")}`}
                    </b>
                  </div>
                </aside>
              </MotionPresence>
            );
          })}
        </div>
      </MotionPresence>
      {v.sample && (
        <>
          <InhibitorTimers
            enabled={graphicEnabled(theme, "inhibitorTimers") && broadcast?.inhibitors !== "off"}
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
                  : broadcast?.inhibitors === "ORDER" || broadcast?.inhibitors === "CHAOS"
                    ? broadcast.inhibitors
                    : undefined
            }
          />
        </>
      )}
      {theme.widgets.players && !showRunes && (
        <section className="ref-player-table" data-region="players" data-source="observed">
          <div className="table-blue">
            {Array.from({ length: 5 }, (_, i) => (
              <LiveRow
                key={i}
                playerNames={theme.playerNames}
                slot={i}
                player={v.blue[i]}
                assetsReady={v.sample?.assetVersion === liveCatalog.version}
                red={false}
                rowQuest={theme.playerCameras === false}
                buffFrames={graphicEnabled(theme, "buffFrames")}
                time={v.time}
                alert={
                  graphicEnabled(theme, "portraitEffects")
                    ? playerAlert(v.blue[i]?.slot ?? i)
                    : undefined
                }
                previewBuffs={variant?.buffs}
              />
            ))}
          </div>
          <div className="table-gold">
            <span className="minimal-center-logo" aria-label="Logo giữa hai đội">
              {theme.minimalLogo ? <img src={theme.minimalLogo} alt="Logo giải đấu" /> : "◆"}
            </span>
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
                  : theme.widgets.gold && gap?.leader === "even"
                    ? "0"
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
                playerNames={theme.playerNames}
                assetsReady={v.sample?.assetVersion === liveCatalog.version}
                red
                rowQuest={theme.playerCameras === false}
                buffFrames={graphicEnabled(theme, "buffFrames")}
                time={v.time}
                alert={
                  graphicEnabled(theme, "portraitEffects")
                    ? playerAlert(v.red[i]?.slot ?? i + 5)
                    : undefined
                }
                previewBuffs={variant?.buffs ? "none" : undefined}
              />
            ))}
          </div>
        </section>
      )}
      {theme.widgets.killfeed &&
        v.sample &&
        (theme.killfeedStyle === "broadcast" ? (
          <BroadcastKillfeed
            sample={v.sample}
            theme={theme}
            events={structureAlerts
              .filter((a) => a.expiresAt > now)
              .slice(-4)
              .map((a) => a.event)}
          />
        ) : (
          <div className="killfeed">
            {structureAlerts
              .filter(
                (a) =>
                  a.expiresAt > now &&
                  ["InhibKilled", "ChampionKill", "Ace"].includes(a.event.kind),
              )
              .slice(-4)
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
        ))}
      <RankingBoard
        sample={v.sample}
        mode="levels"
        playerNames={theme.playerNames}
        show={rehearsal?.kind === "levels" || broadcastWidgetOn(broadcast, "levels", theme)}
        alongside={broadcastWidgetOn(broadcast, "gold", theme)}
      />
    </>
  );
}
