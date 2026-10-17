// Game end evidence from the native snapshot: the Nexus (`hqs`) of each team and the native game id.
// The collector host only reports that the game process or connection ended; who won has to come
// from the Nexus. A team lost when its Nexus reaches 0 health, or disappears from the list after it
// was seen alive while the other Nexus is still there. Anything ambiguous leaves the winner null.

export type NexusReading = {
  health: number | null;
  maxHealth: number | null;
  status: number | null;
} | null;
export type EndTailEntry = {
  at: number; // game time in seconds
  nexus: { ORDER: NexusReading; CHAOS: NexusReading };
};
export type GameEndSnapshot = {
  gameId: number | null;
  winner: "blue" | "red" | null;
  // Game time of the snapshot in which a Nexus was first found destroyed.
  destroyedAt: number | null;
  lastGameTime: number | null;
  tail: EndTailEntry[];
};

const TAIL = 60; // about six seconds of snapshots at 10 Hz
const obj = (v: unknown): Record<string, unknown> =>
  v && typeof v === "object" && !Array.isArray(v) ? (v as Record<string, unknown>) : {};
const finite = (v: unknown): number | null =>
  typeof v === "number" && Number.isFinite(v) ? v : null;

export class GameEndWatch {
  private gameId: number | null = null;
  private lastGameTime: number | null = null;
  private tail: EndTailEntry[] = [];
  private alive = { ORDER: false, CHAOS: false };
  private destroyed: { ORDER: number | null; CHAOS: number | null } = { ORDER: null, CHAOS: null };
  private reset() {
    this.tail = [];
    this.alive = { ORDER: false, CHAOS: false };
    this.destroyed = { ORDER: null, CHAOS: null };
  }
  observe(raw: unknown) {
    const envelope = obj(raw);
    if (envelope.type !== "snapshot") return;
    const data = obj(envelope.data);
    const time = finite(data.gameTime);
    if (time === null || !Array.isArray(data.heroes) || data.heroes.length !== 10) return;
    // Native game id looks like "VN2-1607368559"; only the numeric part is kept.
    const id = typeof data.gameId === "string" ? /(\d{6,15})$/.exec(data.gameId)?.[1] : undefined;
    const nativeId = id ? Number(id) : null;
    // A new game (other id, or the clock jumped back) starts a clean watch.
    if (
      (nativeId !== null && this.gameId !== null && nativeId !== this.gameId) ||
      (this.lastGameTime !== null && time + 30 < this.lastGameTime)
    )
      this.reset();
    if (nativeId !== null) this.gameId = nativeId;
    this.lastGameTime = time;
    if (!Array.isArray(data.hqs)) return;
    const found: { ORDER: NexusReading; CHAOS: NexusReading } = { ORDER: null, CHAOS: null };
    for (const hq of data.hqs.map(obj)) {
      const team = obj(hq.info).team === 1 ? "ORDER" : obj(hq.info).team === 2 ? "CHAOS" : null;
      if (!team) continue;
      found[team] = {
        health: finite(hq.health),
        maxHealth: finite(hq.maxHealth),
        status: finite(hq.status),
      };
    }
    this.tail.push({ at: time, nexus: found });
    if (this.tail.length > TAIL) this.tail.shift();
    for (const team of ["ORDER", "CHAOS"] as const) {
      const other = team === "ORDER" ? "CHAOS" : "ORDER";
      const reading = found[team];
      if (reading && reading.health !== null && reading.health > 0) {
        this.alive[team] = true;
        this.destroyed[team] = null; // seen alive again: an earlier reading was not a kill
      } else if (this.alive[team] && this.destroyed[team] === null) {
        const dead = reading !== null && reading.health !== null && reading.health <= 0;
        const gone = reading === null && found[other] !== null && (found[other]!.health ?? 0) > 0;
        if (dead || gone) this.destroyed[team] = time;
      }
    }
  }
  winner(): "blue" | "red" | null {
    const order = this.destroyed.ORDER !== null;
    const chaos = this.destroyed.CHAOS !== null;
    return order && !chaos ? "red" : chaos && !order ? "blue" : null;
  }
  snapshot(): GameEndSnapshot {
    const times = [this.destroyed.ORDER, this.destroyed.CHAOS].filter(
      (t): t is number => t !== null,
    );
    return {
      gameId: this.gameId,
      winner: this.winner(),
      destroyedAt: times.length ? Math.min(...times) : null,
      lastGameTime: this.lastGameTime,
      tail: this.tail.map((e) => ({ at: e.at, nexus: { ...e.nexus } })),
    };
  }
}
