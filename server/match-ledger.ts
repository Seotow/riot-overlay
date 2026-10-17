import { mkdir, readFile, writeFile } from "node:fs/promises";
import { dirname, resolve } from "node:path";
import type { LedgerSnapshot } from "../shared/match-ledger";
import type { ObserverFrame } from "../shared/observer";

const STEP = 15; // seconds of game time between gold samples
const FILE = resolve(".npm-cache/match-ledger/ledger.json");

// Accumulates what the collector sees for the current match. A new match (game id changes, or the
// game clock jumps back) starts a fresh ledger; the last one is kept on disk for restarts.
export class MatchLedger {
  private ledger: LedgerSnapshot | null = null;
  private dragonIds = new Set<number>();
  private dirtyAt = 0;
  private saved = 0;
  async load() {
    try {
      const data = JSON.parse(await readFile(FILE, "utf8")) as LedgerSnapshot;
      if (Array.isArray(data.gold) && Array.isArray(data.dragons)) this.ledger = data;
    } catch {
      /* no earlier ledger */
    }
  }
  snapshot(): LedgerSnapshot | null {
    return this.ledger ? structuredClone(this.ledger) : null;
  }
  observe(frame: ObserverFrame | null, gameId: number | null) {
    const sample = frame?.status === "observed" ? frame.sample : null;
    const time = sample?.gameTime.value;
    if (!sample || typeof time !== "number" || sample.players.length < 10) return;
    const known = this.ledger;
    const sameGame =
      known &&
      time + 30 >= known.lastGameTime &&
      (gameId === null || known.gameId === null || known.gameId === gameId);
    if (!sameGame) {
      this.ledger = { gameId, firstGameTime: time, lastGameTime: time, gold: [], dragons: [] };
      this.dragonIds.clear();
    }
    const ledger = this.ledger!;
    if (gameId !== null && ledger.gameId === null) ledger.gameId = gameId;
    ledger.lastGameTime = Math.max(ledger.lastGameTime, time);
    const gold = ["ORDER", "CHAOS"].map(
      (team) => sample.teams?.find((t) => t.team === team)?.totalGold.value ?? null,
    );
    const bucket = Math.floor(time / STEP);
    const last = ledger.gold.at(-1);
    if (gold[0] !== null && gold[1] !== null && (!last || Math.floor(last.at / STEP) < bucket))
      ledger.gold.push({ at: time, blue: gold[0], red: gold[1] });
    for (const e of sample.events) {
      if (e.kind !== "DragonKill" || !e.team || !e.objectiveType || this.dragonIds.has(e.id))
        continue;
      this.dragonIds.add(e.id);
      ledger.dragons.push({ at: e.at, team: e.team, type: e.objectiveType });
    }
    this.dirtyAt = Date.now();
  }
  // Best effort: a restart in the middle of a match keeps the history so far.
  async persist() {
    if (!this.ledger || this.dirtyAt <= this.saved || Date.now() - this.saved < 30_000) return;
    this.saved = Date.now();
    try {
      await mkdir(dirname(FILE), { recursive: true });
      await writeFile(FILE, JSON.stringify(this.ledger));
    } catch {
      /* ignore */
    }
  }
}
