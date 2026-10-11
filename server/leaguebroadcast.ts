import { WebSocket } from "ws";
import { questRoles, completedQuestIds, bootIds } from "../shared/role-quest";
import { INHIBITOR_RESPAWN_SECONDS } from "../shared/game-rules";
import { normalizeIngame } from "./ingame-adapter";
import {
  ingameSampleSchema,
  type IngameSample,
  type ObservedEvent,
} from "../shared/observer";
import { ObserverSession } from "./observer-session";
import type { ProviderReport } from "../shared/providers";
const finite = (v: unknown): v is number =>
  typeof v === "number" && Number.isFinite(v) && v >= 0;

const obj = (v: unknown): Record<string, any> =>
  v && typeof v === "object" && !Array.isArray(v)
    ? (v as Record<string, any>)
    : {};
const gameStatusName = (
  value: unknown,
): ProviderReport["leaguebroadcast"]["gameStatus"] => {
  const names: Record<number, ProviderReport["leaguebroadcast"]["gameStatus"]> =
    {
      0: "out-of-game",
      1: "loading",
      2: "running",
      3: "paused",
      4: "mocking",
      5: "game-over",
      6: "champion-select",
    };
  return typeof value === "number" ? (names[value] ?? "unknown") : "unknown";
};
// Independent adapter for the documented JSON feed. Never executes provider URLs or code.
// All identities/assets are discarded; the existing allowlist normalizer validates fields.
export function normalizeLeagueBroadcast(
  raw: unknown,
  now: string,
): IngameSample | null {
  const s = obj(raw);
  if (s.isTestingEnvironment !== false || ![2, 3].includes(s.gameStatus))
    return null;
  if (
    typeof s.gameTime !== "number" ||
    !Number.isFinite(s.gameTime) ||
    s.gameTime < 0
  )
    return null;
  const teams = obj(s.scoreboardBottom).teams;
  if (!Array.isArray(teams) || teams.length !== 2) return null;
  const players: unknown[] = [];
  for (let side = 0; side < 2; side++) {
    const rows = obj(teams[side]).players;
    if (!Array.isArray(rows) || rows.length !== 5) return null;
    const details = Array.isArray(
      obj(obj(s.tabs)[side === 0 ? "Order" : "Chaos"]).players,
    )
      ? (obj(obj(s.tabs)[side === 0 ? "Order" : "Chaos"]).players as unknown[])
      : [];
    for (let slot = 0; slot < rows.length; slot++) {
      const row = rows[slot];
      const p = obj(row);
      const detail = details.length === 5 ? obj(details[slot]) : {};
      const health = obj(detail.health);
      const resource = obj(detail.resource);
      const abilities = Array.isArray(detail.abilities)
        ? detail.abilities.map(obj)
        : [];
      const spell = (slot: "D" | "F") => {
        const ability = abilities.find((a) => a.slot === slot);
        return ability && typeof ability.identifier === "string"
          ? {
              rawDisplayName: `GeneratedTip_SummonerSpell_${ability.identifier}_DisplayName`,
            }
          : undefined;
      };
      const perks = Array.isArray(detail.perks) ? detail.perks.map(obj) : [];
      const keystone = perks.find(
        (perk) => Number.isInteger(perk.id) && Number(perk.id) > 0,
      );
      players.push({
        team: side === 0 ? "ORDER" : "CHAOS",
        championId: obj(p.champion).id,
        level: p.level,
        totalGold: p.totalGold,
        championStats: {
          currentHealth: health.current,
          maxHealth: health.max,
          resourceValue: resource.current,
          resourceMax: resource.max,
        },
        summonerSpells: {
          summonerSpellOne: spell("D"),
          summonerSpellTwo: spell("F"),
        },
        runes: { keystone: keystone ? { id: keystone.id } : undefined },
        scores: {
          kills: p.kills,
          deaths: p.deaths,
          assists: p.assists,
          creepScore: p.creepScore,
          wardScore: p.visionScore,
        },
        items: Array.isArray(p.items)
          ? p.items
              .map((i: unknown) => obj(i))
              .filter(
                (i) =>
                  Number.isInteger(i.slot) &&
                  Number(i.slot) >= 0 &&
                  Number(i.slot) <= 6,
              )
              .map((i) => ({ itemID: i.id, slot: i.slot, count: i.count }))
          : undefined,
        // respawnAt is an absolute game clock, never a wall-clock timestamp.
        isDead:
          typeof p.respawnAt === "number"
            ? p.respawnAt > s.gameTime
            : undefined,
        respawnTimer:
          typeof p.respawnAt === "number" && Number.isFinite(p.respawnAt)
            ? Math.max(0, p.respawnAt - s.gameTime)
            : undefined,
      });
    }
  }
  try {
    const sample = normalizeIngame(
      { allPlayers: players, gameData: { gameTime: s.gameTime } },
      { time: s.gameTime, paused: s.gameStatus === 3, speed: s.playbackSpeed },
      now,
    );
    if (sample.players.some((p) => p.championId.value === null)) return null;
    const scoreboardTeams = obj(s.scoreboard).teams;
    if (Array.isArray(scoreboardTeams) && scoreboardTeams.length === 2) {
      sample.teams = scoreboardTeams.map((rawTeam, side) => {
        const team = obj(rawTeam);
        const dragons = Array.isArray(team.dragons)
          ? team.dragons
              .filter((dragon): dragon is string => typeof dragon === "string")
              .slice(0, 8)
          : null;
        const observed = <T>(value: T | null) => ({
          value,
          availability:
            value === null ? ("missing" as const) : ("observed" as const),
          source: "leaguebroadcast" as const,
          observedAt: now,
        });
        const number = (value: unknown, integer = false) =>
          typeof value === "number" &&
          Number.isFinite(value) &&
          value >= 0 &&
          (!integer || Number.isInteger(value))
            ? value
            : null;
        const roleByItem: Record<
          number,
          "top" | "jungle" | "mid" | "bot" | "support"
        > = {
          1200: "top",
          1201: "mid",
          1202: "bot",
          1203: "support",
          1204: "jungle",
          1205: "jungle",
          1206: "mid",
          1207: "bot",
          1208: "support",
          1209: "jungle",
          1210: "jungle",
          1211: "jungle",
          1220: "top",
          1221: "top",
          1222: "top",
        };
        const bottomPlayers = obj(teams[side]).players;
        const roleOrder = {
          top: 0,
          jungle: 1,
          mid: 2,
          bot: 3,
          support: 4,
        } as const;
        const roleQuests = Array.isArray(bottomPlayers)
          ? bottomPlayers
              .flatMap((player) => {
                const quest = Array.isArray(obj(player).items)
                  ? obj(player)
                      .items.map(obj)
                      .find(
                        (item: Record<string, any>) =>
                          item.slot === 8 && roleByItem[item.id],
                      )
                  : undefined;
                return quest
                  ? [
                      {
                        role: roleByItem[quest.id],
                        itemId: quest.id,
                        progress:
                          [1200, 1201, 1202, 1203, 1204, 1222].includes(
                            quest.id,
                          ) &&
                          Array.isArray(quest.stats) &&
                          finite(quest.stats[0]) &&
                          finite(quest.stats[1]) &&
                          quest.stats[1] > 0 &&
                          quest.stats[0] <= quest.stats[1]
                            ? quest.stats[0] / quest.stats[1]
                            : null,
                        completed: [
                          1205, 1206, 1207, 1208, 1209, 1210, 1211, 1220, 1221,
                        ].includes(quest.id),
                      },
                    ]
                  : [];
              })
              .sort((a, b) => roleOrder[a.role] - roleOrder[b.role])
          : null;
        return {
          team: side === 0 ? ("ORDER" as const) : ("CHAOS" as const),
          totalGold: observed(number(team.gold)),
          kills: observed(number(team.kills, true)),
          towers: observed(number(team.towers, true)),
          towerPlates: observed(number(team.towerPlates, true)),
          dragons: observed(dragons),
          grubs: observed(number(team.grubs, true)),
          roleQuests: observed(roleQuests),
        };
      });
    }
    const observed = <T>(value: T | null) => ({
      value,
      availability:
        value === null ? ("missing" as const) : ("observed" as const),
      source: "leaguebroadcast" as const,
      observedAt: now,
    });
    sample.players.forEach((player, index) => {
      const side = index < 5 ? 0 : 1,
        slot = index % 5;
      const details = obj(obj(s.tabs)[side === 0 ? "Order" : "Chaos"]).players;
      const detail =
        Array.isArray(details) && details.length === 5
          ? obj(details[slot])
          : {};
      const row = obj(obj(teams[side]).players[slot]);
      const rowItems = Array.isArray(row.items) ? row.items.map(obj) : [];
      const questItem = rowItems.find(
        (i) =>
          i.slot === 8 &&
          (Object.hasOwn(questRoles, i.id) ||
            bootIds.has(i.id) ||
            i.id === 2055),
      );
      const role =
        questItem &&
        (Object.hasOwn(questRoles, questItem.id)
          ? questRoles[questItem.id]
          : bootIds.has(questItem.id)
            ? "bot"
            : questItem.id === 2055
              ? "support"
              : null);
      const completed =
        !!questItem &&
        (completedQuestIds.has(questItem.id) ||
          bootIds.has(questItem.id) ||
          questItem.id === 2055);
      const abilityIds = Array.isArray(detail.abilities)
        ? detail.abilities
            .map((a) => obj(a).identifier)
            .filter((id) => typeof id === "string")
        : [];
      const rewardSpellId =
        role === "jungle"
          ? (abilityIds.find((id) => /^SummonerSmiteAvatar/.test(id)) ?? null)
          : role === "top" && completed
            ? "S12_SummonerTeleportUpgrade"
            : null;
      const rewardItemId =
        role === "bot" && questItem && bootIds.has(questItem.id)
          ? questItem.id
          : role === "support" && completed
            ? 2055
            : role === "mid" && completed
              ? (rowItems.find((i) => i.slot < 6 && bootIds.has(i.id))?.id ??
                null)
              : null;
      player.roleQuest = observed(
        role && questItem
          ? {
              role,
              itemId: questItem.id,
              completed,
              progress:
                !completed &&
                Array.isArray(questItem.stats) &&
                finite(questItem.stats[0]) &&
                finite(questItem.stats[1]) &&
                questItem.stats[1] > 0 &&
                questItem.stats[0] <= questItem.stats[1]
                  ? questItem.stats[0] / questItem.stats[1]
                  : null,
              rewardItemId,
              rewardSpellId,
            }
          : null,
      );
      player.hasBaron = observed(
        typeof detail.hasBaron === "boolean" ? detail.hasBaron : null,
      );
      player.hasElder = observed(
        typeof detail.hasElder === "boolean" ? detail.hasElder : null,
      );
      const xp = obj(detail.experience);
      player.experience = observed(
        finite(xp.previousLevel) &&
          finite(xp.current) &&
          finite(xp.nextLevel) &&
          xp.nextLevel > xp.previousLevel &&
          xp.current >= xp.previousLevel &&
          xp.current <= xp.nextLevel
          ? {
              previousLevel: xp.previousLevel,
              current: xp.current,
              nextLevel: xp.nextLevel,
            }
          : null,
      );
      player.perks = observed(
        Array.isArray(detail.perks) &&
          detail.perks.length <= 9 &&
          detail.perks.every(
            (raw) => Number.isInteger(obj(raw).id) && obj(raw).id > 0,
          )
          ? detail.perks.map((raw) => obj(raw).id)
          : null,
      );
      const cooldowns: NonNullable<
        NonNullable<typeof player.cooldowns>["value"]
      > = [];
      if (Array.isArray(row.items))
        for (const raw of row.items) {
          const item = obj(raw);
          if (
            Number.isInteger(item.slot) &&
            item.slot >= 0 &&
            item.slot < 6 &&
            Number.isInteger(item.id) &&
            item.id > 0 &&
            finite(item.maxCooldown) &&
            item.maxCooldown > 0 &&
            (item.readyAt === undefined || finite(item.readyAt))
          ) {
            cooldowns.push({
              kind: "item",
              slot: String(item.slot),
              id: item.id,
              readyAt: item.readyAt ?? 0,
              total: item.maxCooldown,
            });
          }
        }
      if (Array.isArray(detail.abilities))
        for (const raw of detail.abilities) {
          const a = obj(raw);
          if (
            ["R", "D", "F"].includes(a.slot) &&
            finite(a.readyAt) &&
            finite(a.totalCooldown) &&
            a.totalCooldown > 0
          ) {
            cooldowns.push({
              kind: a.slot === "R" ? "ultimate" : "spell",
              slot: a.slot,
              readyAt: a.readyAt,
              total: a.totalCooldown,
            });
          }
        }
      player.cooldowns = observed(
        Array.isArray(row.items) ? cooldowns.slice(0, 10) : null,
      );
    });
    for (const team of sample.teams ?? []) {
      const quests = sample.players
        .filter((p) => p.team.value === team.team)
        .flatMap((p) => (p.roleQuest?.value ? [p.roleQuest.value] : []));
      team.roleQuests = observed(
        quests.length
          ? quests.map(({ role, itemId, completed, progress }) => ({
              role,
              itemId,
              completed,
              progress,
            }))
          : null,
      );
    }
    sample.inhibitors = observed(
      Array.isArray(s.inhibitors)
        ? s.inhibitors.flatMap((raw) => {
            const group = obj(raw),
              team =
                group.teamid === 1
                  ? ("ORDER" as const)
                  : group.teamid === 2
                    ? ("CHAOS" as const)
                    : null;
            if (!team) return [];
            return (["L0", "L1", "L2"] as const).flatMap((key, index) => {
              const inhibitor = obj(obj(group.inhibitors)[key]);
              const respawnsAt = finite(inhibitor.timeAlive)
                ? inhibitor.timeAlive > inhibitor.timeDestroy
                  ? inhibitor.timeAlive
                  : null
                : finite(inhibitor.timeDestroy)
                  ? inhibitor.timeDestroy + INHIBITOR_RESPAWN_SECONDS
                  : null;
              return finite(inhibitor.timeDestroy) &&
                inhibitor.timeDestroy > 0 &&
                respawnsAt != null &&
                respawnsAt > s.gameTime
                ? [
                    {
                      team,
                      lane: (["top", "mid", "bot"] as const)[index],
                      destroyedAt: inhibitor.timeDestroy,
                      respawnsAt,
                    },
                  ]
                : [];
            });
          })
        : null,
    );
    sample.pitTimers = (["baron", "dragon"] as const).map((pit) => {
      const timer = obj(
        s[pit === "baron" ? "baronPitTimer" : "dragonPitTimer"],
      );
      const finite = (value: unknown) =>
        typeof value === "number" && Number.isFinite(value) && value >= 0
          ? value
          : null;
      return {
        pit,
        type: observed(typeof timer.type === "string" ? timer.type : null),
        timeAlive: observed(finite(timer.timeAlive)),
        timeDestroy: observed(finite(timer.timeDestroy)),
      };
    });
    // Provenance is changed for every field, including missing values.
    const mark = (v: any): void => {
      if (!v || typeof v !== "object") return;
      if ("availability" in v && "source" in v) v.source = "leaguebroadcast";
      else Object.values(v).forEach(mark);
    };
    mark(sample);
    return ingameSampleSchema.parse(sample);
  } catch {
    return null;
  }
}

export class LeagueBroadcastSource {
  private socket?: WebSocket;
  private sample: IngameSample | null = null;
  private session = new ObserverSession();
  private nextAttempt = 0;
  private stopped = false;
  private testing: boolean | undefined;
  private gameStatus: number | undefined;
  private objectiveBaseline: {
    gameTime: number;
    dragons: [string[], string[]];
    baron: [boolean, boolean];
  } | null = null;
  private objectiveEvents: ObservedEvent[] = [];
  private nextObjectiveEventId = 1_000_000;
  private eventSample: IngameSample | null = null;
  private nextDiagnosticAt = 0;
  private diagnosticInFlight = false;
  private report: ProviderReport["leaguebroadcast"] = {
    status: "offline",
    lastFrameAt: null,
    lastMessageAt: null,
    frames: 0,
    players: 0,
    fields: [],
    endpoint: "ws://127.0.0.1:58869/ws/in",
    gameStatus: "unknown",
    testingEnvironment: null,
    telemetry: null,
    assetCache: null,
  };
  constructor(private clock = Date.now) {}
  private resetObjectives() {
    this.eventSample = null;
    this.objectiveBaseline = null;
    this.objectiveEvents = [];
    this.nextObjectiveEventId = 1_000_000;
  }
  private addObjectiveEvents(state: Record<string, any>, sample: IngameSample) {
    const gameTime = sample.gameTime.value;
    if (gameTime === null) return;
    const scoreboardTeams = obj(state.scoreboard).teams;
    const dragons = ([0, 1] as const).map((side) => {
      const raw = Array.isArray(scoreboardTeams)
        ? obj(scoreboardTeams[side]).dragons
        : null;
      return Array.isArray(raw)
        ? raw
            .filter((value): value is string => typeof value === "string")
            .slice(0, 8)
        : [];
    }) as [string[], string[]];
    const tabs = obj(state.tabs);
    const previous = this.objectiveBaseline;
    const observedBaron = (["Order", "Chaos"] as const).map((side) => {
      const players = obj(tabs[side]).players;
      return Array.isArray(players) && players.length === 5
        ? players.some((player) => obj(player).hasBaron === true)
        : null;
    }) as [boolean | null, boolean | null];
    const baron = observedBaron.map(
      (value, side) => value ?? previous?.baron[side] ?? false,
    ) as [boolean, boolean];
    const isPrefix = (before: string[], after: string[]) =>
      before.every((value, index) => after[index] === value);
    if (
      !previous ||
      gameTime < previous.gameTime - 0.05 ||
      dragons.some(
        (current, side) => !isPrefix(previous.dragons[side], current),
      )
    ) {
      this.objectiveEvents = [];
      this.objectiveBaseline = { gameTime, dragons, baron };
      sample.events = [];
      this.eventSample = sample;
      return;
    }
    const before = this.eventSample;
    const emit = (event: Omit<ObservedEvent, "id" | "at">) =>
      this.objectiveEvents.push({
        id: this.nextObjectiveEventId++,
        at: gameTime,
        ...event,
      });
    if (before) {
      // Explicit major-item allowlist: do not classify arbitrary unknown IDs as completions.
      const completedItems = new Set([
        4646, 3152, 3026, 3157, 3089, 4645, 3031, 3036, 6676, 3124, 3072,
      ]);
      for (const player of sample.players) {
        const old = before.players.find(
          (p) =>
            p.slot === player.slot &&
            p.championId.value === player.championId.value,
        );
        if (!old) continue;
        if (
          old.roleQuest?.value?.completed === false &&
          player.roleQuest?.value?.completed === true
        )
          emit({
            kind: "RoleQuestCompleted",
            playerSlot: player.slot,
            team: player.team.value ?? undefined,
          });
        if (
          old.level.value !== null &&
          player.level.value !== null &&
          player.level.value > old.level.value
        )
          emit({
            kind: "LevelUp",
            playerSlot: player.slot,
            level: player.level.value,
          });
        if (old.items.value && player.items.value)
          for (const id of new Set(player.items.value)) {
            if (completedItems.has(id) && !old.items.value.includes(id))
              emit({
                kind: "ItemCompleted",
                playerSlot: player.slot,
                itemId: id,
              });
          }
      }
      for (const team of sample.teams ?? []) {
        const old = before.teams?.find((t) => t.team === team.team);
        if (
          old?.towers.value != null &&
          team.towers.value != null &&
          team.towers.value > old.towers.value
        ) {
          const previousTotal =
            before.teams?.length === 2 &&
            before.teams.every((t) => t.towers.value != null)
              ? before.teams.reduce((sum, t) => sum + t.towers.value!, 0)
              : null;
          const currentTotal =
            sample.teams?.length === 2 &&
            sample.teams.every((t) => t.towers.value != null)
              ? sample.teams.reduce((sum, t) => sum + t.towers.value!, 0)
              : null;
          emit({
            kind: "TurretKilled",
            team: team.team,
            ...(previousTotal != null && currentTotal != null
              ? { firstTurret: previousTotal === 0 && currentTotal === 1 }
              : {}),
          });
        }
      }
      if (before.inhibitors?.value && sample.inhibitors?.value) {
        const key = (
          i: NonNullable<
            NonNullable<IngameSample["inhibitors"]>["value"]
          >[number],
        ) => `${i.team}:${i.lane}`;
        for (const i of sample.inhibitors.value)
          if (!before.inhibitors.value.some((p) => key(p) === key(i)))
            emit({
              kind: "InhibKilled",
              team: i.team === "ORDER" ? "CHAOS" : "ORDER",
            });
        for (const i of before.inhibitors.value)
          if (!sample.inhibitors.value.some((p) => key(p) === key(i)))
            emit({ kind: "InhibRespawned", team: i.team });
      }
    }
    for (const side of [0, 1] as const) {
      for (const rawType of dragons[side].slice(
        previous.dragons[side].length,
      )) {
        const normalized = rawType.toLowerCase().replace(/^dragon_/, "");
        const objectiveType = [
          "fire",
          "earth",
          "water",
          "air",
          "hextech",
          "chemtech",
          "elder",
        ].includes(normalized)
          ? (normalized as ObservedEvent["objectiveType"])
          : undefined;
        this.objectiveEvents.push({
          id: this.nextObjectiveEventId++,
          at: gameTime,
          kind: "DragonKill",
          team: side === 0 ? "ORDER" : "CHAOS",
          ...(objectiveType ? { objectiveType } : {}),
        });
      }
      const elemental = (list: string[]) =>
        list
          .map((d) => d.toLowerCase().replace(/^dragon_/, ""))
          .filter((d) =>
            ["fire", "earth", "water", "air", "hextech", "chemtech"].includes(
              d,
            ),
          );
      if (
        elemental(previous.dragons[side]).length < 4 &&
        elemental(dragons[side]).length >= 4
      ) {
        const normalized = elemental(dragons[side])[3];
        const objectiveType = [
          "fire",
          "earth",
          "water",
          "air",
          "hextech",
          "chemtech",
        ].includes(normalized)
          ? (normalized as ObservedEvent["objectiveType"])
          : undefined;
        this.objectiveEvents.push({
          id: this.nextObjectiveEventId++,
          at: gameTime,
          kind: "DragonSoul",
          team: side === 0 ? "ORDER" : "CHAOS",
          ...(objectiveType ? { objectiveType } : {}),
        });
      }
      if (!previous.baron[side] && baron[side]) {
        this.objectiveEvents.push({
          id: this.nextObjectiveEventId++,
          at: gameTime,
          kind: "BaronKill",
          team: side === 0 ? "ORDER" : "CHAOS",
          objectiveType: "baron",
        });
      }
    }
    this.objectiveEvents = this.objectiveEvents.slice(-256);
    this.objectiveBaseline = { gameTime, dragons, baron };
    sample.events = [...this.objectiveEvents];
    this.eventSample = sample;
  }
  ensureConnected() {
    void this.refreshDiagnostics();
    if (this.stopped || this.socket || this.clock() < this.nextAttempt) return;
    this.report.status = "connecting";
    const ws = new WebSocket(this.report.endpoint, {
      handshakeTimeout: 2500,
      maxPayload: 2 * 1024 * 1024,
      followRedirects: false,
    });
    this.socket = ws;
    ws.on("open", () => {
      if (this.socket === ws) this.report.status = "waiting";
    });
    ws.on("message", (data) => {
      if (this.socket !== ws) return;
      if (data.toString() === "KeepAlive") return;
      this.report.lastMessageAt = new Date(this.clock()).toISOString();
      try {
        this.accept(JSON.parse(data.toString()));
      } catch {
        this.sample = null;
        this.resetObjectives();
        this.report.status = "invalid";
      }
    });
    ws.on("unexpected-response", (_req, res) => {
      this.report.status = [401, 403].includes(res.statusCode ?? 0)
        ? "restricted"
        : "offline";
      res.resume();
      ws.terminate();
    });
    ws.on("error", () => {
      this.sample = null;
      this.resetObjectives();
    });
    ws.on("close", () => {
      if (this.socket !== ws) return;
      this.sample = null;
      this.testing = undefined;
      this.gameStatus = undefined;
      this.resetObjectives();
      if (this.report.status !== "restricted") this.report.status = "offline";
      this.socket = undefined;
      this.nextAttempt = this.clock() + 5000;
    });
  }
  accept(message: unknown) {
    const m = obj(message);
    if (m.type === "gameStatus") {
      this.testing =
        typeof m.isTestingEnvironment === "boolean"
          ? m.isTestingEnvironment
          : undefined;
      this.gameStatus = m.gameState;
      this.report.testingEnvironment = this.testing ?? null;
      this.report.gameStatus = gameStatusName(this.gameStatus);
      if (this.testing !== false || ![2, 3].includes(this.gameStatus!)) {
        this.sample = null;
        this.resetObjectives();
        this.report.status =
          this.testing || this.gameStatus === 4
            ? "mock"
            : this.gameStatus === 1
              ? "loading"
              : "waiting";
      }
      return;
    }
    if (m.type !== "ingame-state-update") return;
    if (
      this.report.lastFrameAt &&
      this.clock() - Date.parse(this.report.lastFrameAt) >= 5000
    )
      this.resetObjectives();
    const s = obj(m.state);
    const merged = {
      ...s,
      isTestingEnvironment: s.isTestingEnvironment ?? this.testing,
      gameStatus: s.gameStatus ?? this.gameStatus,
    };
    this.sample = normalizeLeagueBroadcast(
      merged,
      new Date(this.clock()).toISOString(),
    );
    if (!this.sample) {
      this.resetObjectives();
      this.report.status =
        merged.isTestingEnvironment === true || merged.gameStatus === 4
          ? "mock"
          : "invalid";
      return;
    }
    this.addObjectiveEvents(s, this.sample);
    this.sample = ingameSampleSchema.parse(this.sample);
    this.report.status = "receiving";
    this.report.frames++;
    this.report.lastFrameAt = this.sample.capturedAt;
  }
  snapshot() {
    const fresh =
      this.sample && this.clock() - Date.parse(this.sample.capturedAt) < 5000;
    const fields = fresh
      ? [
          ...new Set(
            this.sample!.players.flatMap((p) =>
              Object.entries(p)
                .filter(
                  ([, v]) =>
                    v &&
                    typeof v === "object" &&
                    "availability" in v &&
                    v.availability === "observed",
                )
                .map(([k]) => k),
            ),
          ),
        ]
      : [];
    return {
      ...this.report,
      status:
        !fresh && this.report.status === "receiving"
          ? ("stale" as const)
          : this.report.status,
      players: fresh ? this.sample!.players.length : 0,
      fields,
    };
  }
  private async refreshDiagnostics() {
    if (this.diagnosticInFlight || this.clock() < this.nextDiagnosticAt) return;
    this.diagnosticInFlight = true;
    this.nextDiagnosticAt = this.clock() + 5000;
    const safeJson = async (path: string) => {
      const response = await fetch(`http://127.0.0.1:58869${path}`, {
        signal: AbortSignal.timeout(2000),
      });
      if (!response.ok) throw Error(String(response.status));
      return obj(await response.json());
    };
    try {
      const [telemetry, cache] = await Promise.all([
        safeJson("/api/diagnostics/health"),
        safeJson("/api/settings/patches/job"),
      ]);
      this.report.telemetry = {
        status:
          typeof telemetry.status === "string" ? telemetry.status : "unknown",
        updatesPerSecond:
          typeof telemetry.updatesPerSecond === "number" &&
          Number.isFinite(telemetry.updatesPerSecond)
            ? Math.max(0, telemetry.updatesPerSecond)
            : 0,
      };
      this.report.assetCache = {
        version: typeof cache.version === "string" ? cache.version : null,
        state: typeof cache.state === "string" ? cache.state : "unknown",
        phase: typeof cache.phase === "string" ? cache.phase : "unknown",
        readiness:
          typeof cache.readiness === "string" ? cache.readiness : "unknown",
        progressPercent:
          typeof cache.progressPercent === "number" &&
          Number.isFinite(cache.progressPercent)
            ? Math.max(0, Math.min(100, cache.progressPercent))
            : null,
        failedAssets:
          Number.isInteger(cache.failedAssets) && cache.failedAssets >= 0
            ? cache.failedAssets
            : 0,
      };
    } catch {
      this.report.telemetry = null;
      this.report.assetCache = null;
    } finally {
      this.diagnosticInFlight = false;
    }
  }
  observe() {
    const fresh = this.snapshot().status === "receiving";
    const sample = fresh ? this.sample : null;
    const signature =
      "leaguebroadcast:" +
      (sample?.players
        .map((p) => `${p.team.value}:${p.championId.value}`)
        .join(",") ?? "none");
    return this.session.ingest(
      sample,
      signature,
      new Date(this.clock()).toISOString(),
    );
  }
  recording() {
    return this.session.recording();
  }
  currentSample() {
    return this.sample;
  }
  disconnect() {
    const ws = this.socket;
    this.socket = undefined;
    ws?.terminate();
    this.sample = null;
    this.testing = undefined;
    this.gameStatus = undefined;
    this.resetObjectives();
    this.report.status = "offline";
    this.report.gameStatus = "unknown";
    this.report.telemetry = null;
    this.report.assetCache = null;
  }
  stop() {
    this.stopped = true;
    this.socket?.terminate();
    this.sample = null;
    this.resetObjectives();
  }
}
export const leagueBroadcast = new LeagueBroadcastSource();
