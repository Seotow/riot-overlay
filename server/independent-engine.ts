import { IngameCollector } from "./observer";
import { observerFrameSchema, type ObserverFrame, type ObservedPlayer } from "../shared/observer";
import type { Probe } from "../shared/diagnostics";

type Collector = { observe(): Promise<ObserverFrame> };
export const independentPlayerFields = [
  "championId",
  "level",
  "kills",
  "deaths",
  "assists",
  "cs",
  "items",
  "inventory",
  "spells",
  "keystone",
  "wardScore",
  "isDead",
  "respawnSeconds",
  "totalGold",
  "health",
  "resource",
  "cooldowns",
  "perks",
  "hasBaron",
  "hasElder",
  "roleQuest",
] as const satisfies readonly (keyof ObservedPlayer)[];

/** Own orchestration, official API acquisition only. No LB imports, entitlement, or fallback. */
export class IndependentEngine {
  private collector: Collector;
  private probes: readonly Probe[] = [];
  private frame: ObserverFrame | null = null;
  private active = false;
  private timer: ReturnType<typeof setTimeout> | undefined;
  private pending: Promise<void> | undefined;
  private generation = 0;
  private listeners = new Set<() => void>();
  constructor(
    collector?: Collector,
    private clock = Date.now,
  ) {
    this.collector =
      collector ??
      new IngameCollector(undefined, clock, (probes) => {
        this.probes = probes;
      });
  }
  onUpdate(listener: () => void) {
    this.listeners.add(listener);
    return () => this.listeners.delete(listener);
  }
  snapshot() {
    const now = this.clock();
    const stale = this.frame !== null && now - Date.parse(this.frame.capturedAt) > 5000;
    const frame = !stale
      ? this.frame
      : this.frame && {
          ...this.frame,
          status: "unavailable" as const,
          transition: "lost" as const,
          sample: null,
          newEvents: [],
        };
    const sample = frame?.sample;
    const players = sample?.players ?? [];
    const coverage = Object.fromEntries(
      independentPlayerFields.map((key) => [
        key,
        {
          observed: players.filter((p) => {
            const value = p[key];
            return (
              typeof value === "object" &&
              value !== null &&
              "availability" in value &&
              value.availability === "observed" &&
              "value" in value &&
              value.value !== null &&
              (key !== "perks" ||
                (Array.isArray(value.value) &&
                  value.value.length === 9 &&
                  new Set<unknown>(value.value).size === 9)) &&
              (key !== "cooldowns" || (Array.isArray(value.value) && value.value.length > 0))
            );
          }).length,
          expected: 10,
        },
      ]),
    );
    // Current gold and damage are not represented/acquired by this prototype.
    const missing = Object.entries(coverage)
      .filter(([, c]) => c.observed < 10)
      .map(([key]) => key);
    const hasPlayers = players.some((p) =>
      [p.championId, p.level, p.kills, p.cs].some(
        (f) => f.availability === "observed" && f.value !== null,
      ),
    );
    const status = !sample ? "unavailable" : hasPlayers ? "partial" : "clock-only";
    const orderPlayers = players.filter(
      (p) => p.team.availability === "observed" && p.team.value === "ORDER",
    ).length;
    const chaosPlayers = players.filter(
      (p) => p.team.availability === "observed" && p.team.value === "CHAOS",
    ).length;
    const uniqueSlots = new Set(players.map((p) => p.slot)).size;
    const gameTime = sample?.gameTime.value ?? null;
    const replayTime = sample?.replay.time.value ?? null;
    return {
      protocolVersion: 1 as const,
      engine: "rift-independent" as const,
      acquisition: "riot-local-api" as const,
      running: this.active,
      status,
      stale,
      capturedAt: frame?.capturedAt ?? null,
      probes: this.probes.map((p) => ({ ...p })),
      replacementReady: false as const,
      capabilities: {
        scope: "current-sample-only" as const,
        players: players.length,
        roster: {
          uniqueSlots,
          orderPlayers,
          chaosPlayers,
          complete:
            players.length === 10 && uniqueSlots === 10 && orderPlayers === 5 && chaosPlayers === 5,
        },
        clockAlignment:
          gameTime === null || replayTime === null
            ? "unverified"
            : Math.abs(gameTime - replayTime) <= 1
              ? "near"
              : "divergent",
        coverage,
        missing: [...missing, "currentGold", "damageToChampions", "combatWindow"],
        gameClock: sample?.gameTime.availability === "observed",
        replayClock: sample?.replay.time.availability === "observed",
        mapNumber: sample?.mapNumber?.value ?? null,
        limitations: [
          "Not a full LB replacement.",
          "Asset patch and match identity not independently verified.",
          "Field presence is not semantic correctness or coverage across all game modes.",
        ],
      },
      frame,
    };
  }
  async tick() {
    if (this.pending) return this.pending;
    const generation = this.generation;
    this.pending = (async () => {
      try {
        const frame = observerFrameSchema.parse(await this.collector.observe());
        // Never stamp LB/recorded input with the independent official-API identity.
        const fields = Object.entries(frame.sample ?? {});
        const hasForeignSource = (value: unknown): boolean => {
          if (value === null || typeof value !== "object") return false;
          if ("source" in value && value.source === "leaguebroadcast") return true;
          return Object.values(value).some(hasForeignSource);
        };
        if (frame.playback || fields.some(([, value]) => hasForeignSource(value)))
          throw Error("Foreign acquisition source");
        if (generation !== this.generation) return;
        this.frame = frame;
      } catch {
        if (generation !== this.generation) return;
        // Never publish raw exceptions or retain an old sample as a successful new read.
        this.frame = this.frame && {
          ...this.frame,
          capturedAt: new Date(this.clock()).toISOString(),
          status: "unavailable",
          transition: "lost",
          sample: null,
          newEvents: [],
        };
      }
      for (const listener of this.listeners) {
        try {
          listener();
        } catch {
          /* isolate consumers */
        }
      }
    })();
    try {
      await this.pending;
    } finally {
      this.pending = undefined;
    }
  }
  start() {
    if (this.active) return;
    this.active = true;
    const generation = this.generation;
    const loop = async () => {
      if (!this.active || generation !== this.generation) return;
      await this.tick();
      if (this.active && generation === this.generation) this.timer = setTimeout(loop, 500);
    };
    void loop();
  }
  async stop() {
    this.active = false;
    this.generation++;
    clearTimeout(this.timer);
    await this.pending;
    this.frame = null;
    this.probes = [];
  }
}
export type IndependentEngineSnapshot = ReturnType<IndependentEngine["snapshot"]>;
