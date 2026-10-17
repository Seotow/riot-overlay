import { createHash } from "node:crypto";
import type { IngameSample, ObservedEvent } from "../../shared/observer";
import { INHIBITOR_RESPAWN_SECONDS } from "../../shared/game-rules";
import { completedItemIds } from "../../shared/completed-items";
import { object, type NormalizedCollector } from "./normalize";
type Team = "ORDER" | "CHAOS";
type Unit = {
  code: string;
  lastSeen: number;
  team?: Team;
  slot?: number;
  unitType?: NonNullable<ObservedEvent["killerUnitType"]>;
  kind?: "TurretKilled" | "InhibKilled";
  lane?: "top" | "mid" | "bot";
};
const objectiveCodes: Record<
  string,
  NonNullable<ObservedEvent["objectiveType"]>
> = {
  sru_dragon_fire: "fire",
  sru_dragon_earth: "earth",
  sru_dragon_water: "water",
  sru_dragon_air: "air",
  sru_dragon_hextech: "hextech",
  sru_dragon_chemtech: "chemtech",
  sru_dragon_elder: "elder",
  sru_baron: "baron",
  sru_riftherald: "herald",
};
const id = (v: unknown): v is number =>
  typeof v === "number" && Number.isInteger(v) && v > 0 && v <= 0xffffffff;
const hash = (s: string) =>
  parseInt(createHash("sha256").update(s).digest("hex").slice(0, 13), 16);
// Stateful source projection: identity survives a monster disappearing on its death
// frame. Counters describe observed history, never an assertion of full coverage.
export class CollectorGameplay {
  private signature = "";
  private time = -1;
  private units = new Map<number, Unit>();
  private history = new Map<number, ObservedEvent>();
  private grubs: Record<Team, number> = { ORDER: 0, CHAOS: 0 };
  private previous: IngameSample | null = null;
  private inhibHealth = new Map<number, number>();
  private inhibTimers = new Map<
    number,
    NonNullable<NonNullable<IngameSample["inhibitors"]>["value"]>[number]
  >();
  reset() {
    this.signature = "";
    this.time = -1;
    this.units.clear();
    this.history.clear();
    this.grubs = { ORDER: 0, CHAOS: 0 };
    this.previous = null;
    this.inhibHealth.clear();
    this.inhibTimers.clear();
  }
  enrich(raw: unknown, normalized: NormalizedCollector): NormalizedCollector {
    const s = normalized.sample,
      d = object(object(raw).data),
      time = s.gameTime.value!;
    if (this.signature !== normalized.signature || time < this.time - 0.05)
      this.reset();
    this.signature = normalized.signature;
    this.time = time;
    const heroes = (Array.isArray(d.heroes) ? d.heroes : [])
      .map(object)
      .sort(
        (a, b) =>
          Number(object(a.info).team) - Number(object(b.info).team) ||
          Number(a.heroIndex) - Number(b.heroIndex),
      );
    const register = (v: unknown, slot?: number, kind?: Unit["kind"]) => {
      const u = object(v),
        info = object(u.info),
        network = info.networkId;
      if (!id(network)) return;
      const name = String(info.name ?? ""),
        laneCode = name.match(/_L([012])_/)?.[1];
      this.units.set(network, {
        lastSeen: time,
        code: String(object(u.common).identifier ?? "").toLowerCase(),
        ...(info.team === 1
          ? { team: "ORDER" as const }
          : info.team === 2
            ? { team: "CHAOS" as const }
            : {}),
        ...(slot === undefined ? {} : { slot }),
        ...(kind === "TurretKilled"
          ? { unitType: "turret" as const }
          : slot === undefined && !kind
            ? {
                unitType:
                  String(object(u.common).identifier ?? "").toLowerCase() ===
                  "sru_horde"
                    ? ("grubs" as const)
                    : info.team === 1 || info.team === 2
                      ? ("minion" as const)
                      : ("monster" as const),
              }
            : {}),
        ...(kind ? { kind } : {}),
        ...(kind === "InhibKilled" && laneCode
          ? {
              lane: ({ "0": "bot", "1": "mid", "2": "top" } as const)[
                laneCode as "0" | "1" | "2"
              ],
            }
          : {}),
      });
    };
    for (const [network, unit] of this.units)
      if (time - unit.lastSeen > 30) this.units.delete(network);
    // Cache all units as possible killers; exact objective codes alone count pit kills.
    for (const v of Array.isArray(d.minions) ? d.minions : []) {
      register(v);
    }
    // Current snapshot only: cached identities are for deaths, not proof of life.
    // Do not expose a dead body or a future dragon from event history as alive.
    const livingDragons = (Array.isArray(d.minions) ? d.minions : [])
      .map(object)
      .filter((u) => {
        const c = object(u.common), code = String(c.identifier ?? "").toLowerCase();
        return code.startsWith("sru_dragon_") && objectiveCodes[code] &&
          typeof c.health === "number" && Number.isFinite(c.health) && c.health > 0 &&
          !(typeof c.status === "number" && (c.status & 1) === 0);
      });
    const dragonTypes = [...new Set(livingDragons.map(u =>
      objectiveCodes[String(object(u.common).identifier).toLowerCase()]))];
    const indicatorTypes = [...new Set((Array.isArray(d.particleEmitters) ? d.particleEmitters : [])
      .map(object)
      .map(p => String(object(p.info).name ?? "").match(/^(?:.*[\\/])?Dragon_Indicator_(Fire|Earth|Water|Air|Hextech|Chemtech|Elder)(?:\.troy)?$/i)?.[1].toLowerCase())
      .filter((type): type is string => !!type))];
    // A live monster outranks the spawn marker. Conflicting live identities or
    // multiple marker types are missing, never resolved by order or cached history.
    const dragonType = dragonTypes.length === 1 ? dragonTypes[0]
      : dragonTypes.length === 0 && indicatorTypes.length === 1 ? indicatorTypes[0] : null;
    if (dragonType) {
      const observed = <T,>(value: T | null) => ({ value,
        availability: value === null ? "missing" as const : "observed" as const,
        source: "league-collector" as const, observedAt: s.capturedAt });
      s.pitTimers = [{ pit: "dragon", type: observed(dragonType),
        isAlive: observed<boolean>(dragonTypes.length === 1 ? true : null),
        timeAlive: observed<number>(null), timeDestroy: observed<number>(null) }];
    }
    heroes.forEach((h, slot) => register(h, slot));
    for (const v of Array.isArray(d.turrets) ? d.turrets : [])
      register(v, undefined, "TurretKilled");
    for (const v of Array.isArray(d.barracksDampeners)
      ? d.barracksDampeners
      : [])
      register(v, undefined, "InhibKilled");
    for (const v of Array.isArray(d.barracksDampeners)
      ? d.barracksDampeners
      : []) {
      const u = object(v),
        network = object(u.info).networkId,
        health = u.health;
      if (
        !id(network) ||
        typeof health !== "number" ||
        !Number.isFinite(health) ||
        health < 0
      )
        continue;
      const target = this.units.get(network),
        before = this.inhibHealth.get(network);
      if (
        health === 0 &&
        before !== undefined &&
        before > 0 &&
        target?.team &&
        target.lane
      )
        this.inhibTimers.set(network, {
          team: target.team,
          lane: target.lane,
          destroyedAt: time,
          respawnsAt: time + INHIBITOR_RESPAWN_SECONDS,
        });
      if (health > 0) this.inhibTimers.delete(network);
      this.inhibHealth.set(network, health);
    }
    s.inhibitors = {
      value: [...this.inhibTimers.values()],
      availability: "observed",
      source: "league-collector",
      observedAt: s.capturedAt,
    };
    // Source-observed state changes, matching the existing LB projection behavior.
    if (this.previous)
      for (const p of s.players) {
        const before = this.previous.players.find((x) => x.slot === p.slot);
        if (!before) continue;
        const emit = (
          kind: "LevelUp" | "RoleQuestCompleted" | "ItemCompleted",
          extra: Partial<ObservedEvent>,
        ) => {
          const key = hash(
            `${kind}:${p.slot}:${time}:${extra.itemId ?? extra.level ?? ""}`,
          );
          this.history.set(key, {
            id: key,
            at: time,
            kind,
            team: p.team.value ?? undefined,
            playerSlot: p.slot,
            ...extra,
          });
        };
        if (
          before.level.value !== null &&
          p.level.value !== null &&
          p.level.value > before.level.value
        )
          emit("LevelUp", { level: p.level.value });
        if (
          before.roleQuest?.value?.completed === false &&
          p.roleQuest?.value?.completed === true
        )
          emit("RoleQuestCompleted", {});
        if (before.items.value && p.items.value)
          for (const itemId of new Set(p.items.value))
            if (
              completedItemIds.has(itemId) &&
              p.items.value.filter((id) => id === itemId).length >
                before.items.value.filter((id) => id === itemId).length
            )
              emit("ItemCompleted", { itemId });
      }
    for (const e of s.events) this.history.set(e.id, e);
    for (const rawDeath of Array.isArray(object(d.gameEvents).heroDieEvents)
      ? (object(d.gameEvents).heroDieEvents as unknown[])
      : []) {
      const e = object(rawDeath),
        at = e.gameTime,
        victim = id(e.victimNetworkId)
          ? this.units.get(e.victimNetworkId)
          : undefined,
        killer = id(e.killerNetworkId)
          ? this.units.get(e.killerNetworkId)
          : undefined;
      if (
        typeof at !== "number" ||
        !Number.isFinite(at) ||
        at < 0 ||
        at > time ||
        victim?.slot === undefined
      )
        continue;
      if (
        [...this.history.values()].some(
          (x) =>
            x.kind === "ChampionKill" &&
            x.at === at &&
            x.victimSlot === victim.slot,
        )
      )
        continue;
      const key = hash(`hero-death:${at}:${e.victimNetworkId}`);
      this.history.set(key, {
        id: key,
        at,
        kind: "ChampionKill",
        victimSlot: victim.slot,
        ...(killer?.team ? { team: killer.team } : {}),
        ...(killer?.unitType ? { killerUnitType: killer.unitType } : {}),
        ...(killer && objectiveCodes[killer.code]
          ? { killerObjectiveType: objectiveCodes[killer.code] }
          : {}),
        ...(killer?.slot !== undefined
          ? { killerSlot: killer.slot, playerSlot: killer.slot }
          : {}),
      });
    }
    const deaths = object(d.gameEvents).deathEvents;
    for (const rawEvent of Array.isArray(deaths) ? deaths : []) {
      const e = object(rawEvent),
        at = e.gameTime;
      if (
        typeof at !== "number" ||
        !Number.isFinite(at) ||
        at < 0 ||
        at > time ||
        !id(e.victimNetworkId) ||
        !id(e.killerNetworkId) ||
        e.victimNetworkId === e.killerNetworkId
      )
        continue;
      const victim = this.units.get(e.victimNetworkId),
        killer = this.units.get(e.killerNetworkId);
      if (!victim || !killer?.team || killer.team === victim.team) continue;
      const type = objectiveCodes[victim.code];
      const key = hash(JSON.stringify(["native-death", at, e.victimNetworkId]));
      if (this.history.has(key)) continue;
      if (victim.code === "sru_horde") {
        this.grubs[killer.team]++;
        this.history.set(key, {
          id: key,
          at,
          kind: "VoidGrubKill",
          team: killer.team,
          killerSlot: killer.slot,
        });
        continue;
      }
      const kind =
        type === "baron"
          ? "BaronKill"
          : type === "herald"
            ? "HeraldKill"
            : type
              ? "DragonKill"
              : victim.kind;
      if (!kind) continue;
      // Typed and generic vectors can both report the same structure death.
      if (
        [...this.history.values()].some(
          (x) => x.kind === kind && x.at === at && x.team === killer.team,
        )
      )
        continue;
      this.history.set(key, {
        id: key,
        at,
        kind,
        team: killer.team,
        playerSlot: killer.slot,
        killerSlot: killer.slot,
        ...(type ? { objectiveType: type } : {}),
        ...(kind === "BaronKill" &&
        s.teams?.every((t) => t.totalGold.value !== null)
          ? {
              goldBaseline: {
                own: s.teams.find((t) => t.team === killer.team)!.totalGold
                  .value!,
                enemy: s.teams.find((t) => t.team !== killer.team)!.totalGold
                  .value!,
              },
            }
          : {}),
        ...(kind === "TurretKilled"
          ? {
              firstTurret: ![...this.history.values()].some(
                (x) => x.kind === "TurretKilled",
              ),
            }
          : {}),
      });
    }
    const events = [...this.history.values()].sort(
      (a, b) => a.at - b.at || a.id - b.id,
    );
    // Soul is confirmed by an explicit soul buff, not guessed from elapsed time.
    for (const h of heroes) {
      const team = object(h.info).team === 1 ? "ORDER" : "CHAOS";
      for (const b of Array.isArray(object(h.common).buffs)
        ? (object(h.common).buffs as unknown[])
        : []) {
        const buff = object(b),
          match = String(buff.name ?? "").match(
            /^SRX_DragonSoulBuff(Mountain|Infernal|Ocean|Cloud|Hextech|Chemtech)$/i,
          );
        if (!match) continue;
        const type = (
          {
            mountain: "earth",
            infernal: "fire",
            ocean: "water",
            cloud: "air",
            hextech: "hextech",
            chemtech: "chemtech",
          } as const
        )[match[1].toLowerCase() as "mountain"];
        const at = buff.startTime;
        if (typeof at !== "number" || at < 0 || at > time) continue;
        const key = hash(`soul:${team}:${type}:${at}`);
        this.history.set(key, {
          id: key,
          at,
          kind: "DragonSoul",
          team,
          objectiveType: type,
        });
      }
    }
    s.events = [...this.history.values()]
      .sort((a, b) => a.at - b.at || a.id - b.id)
      .slice(-4096);
    if (this.history.size > 4096) {
      this.history = new Map(s.events.map((e) => [e.id, e]));
      s.limits.eventsTruncated = true;
    }
    for (const t of s.teams ?? []) {
      const dragons = events
        .filter(
          (e) =>
            e.team === t.team &&
            e.kind === "DragonKill" &&
            e.objectiveType !== "elder",
        )
        .map((e) => e.objectiveType!);
      t.dragons = {
        value: dragons.slice(-8),
        availability: "observed",
        source: "league-collector",
        observedAt: s.capturedAt,
      };
      t.grubs = {
        ...t.grubs,
        value: this.grubs[t.team],
        availability: "observed",
      };
      t.roleQuests = {
        ...t.dragons,
        value: s.players
          .filter((p) => p.team.value === t.team && p.roleQuest?.value)
          .map((p) => {
            const q = p.roleQuest!.value!;
            return {
              role: q.role,
              itemId: q.itemId,
              completed: q.completed,
              progress: q.progress,
            };
          }),
      };
    }
    this.previous = s;
    return normalized;
  }
}
