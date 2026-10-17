import { mkdir, readFile, writeFile } from "node:fs/promises";
import { dirname, resolve } from "node:path";
import type { LedgerSnapshot } from "../shared/match-ledger";
import type { ObserverFrame } from "../shared/observer";
import type { GameEndSnapshot } from "../collector/adapter/game-end";

const STEP = 15; // seconds of game time between gold samples
const DEFAULT_DIR = resolve(".npm-cache/match-ledger");

// Accumulates what the collector sees for the current match. A new match (game id changes, or the
// game clock jumps back) starts a fresh ledger; the last one is kept on disk for restarts.
export class MatchLedger {
  private FILE: string;
  private TAIL_FILE: string;
  constructor(dir: string = DEFAULT_DIR) {
    this.FILE = resolve(dir, "ledger.json");
    this.TAIL_FILE = resolve(dir, "game-end-tail.json");
  }
  private ledger: LedgerSnapshot | null = null;
  private dragonIds = new Set<number>();
  private dirtyAt = 0;
  private saved = 0;
  async load() {
    try {
      const data = JSON.parse(await readFile(this.FILE, "utf8")) as LedgerSnapshot;
      if (Array.isArray(data.gold) && Array.isArray(data.dragons)) this.ledger = data;
    } catch {
      /* no earlier ledger */
    }
  }
  private tailKey = "";
  // Nexus evidence from the collector: the winner and the last snapshots of both Nexus, written to a
  // file whenever they change so a real match can be checked afterwards (no names or accounts in it).
  async observeEnd(end: GameEndSnapshot) {
    if (this.ledger) {
      if (this.ledger.gameId === null && end.gameId !== null) this.ledger.gameId = end.gameId;
      if (end.gameId === null || this.ledger.gameId === end.gameId) {
        if (this.ledger.winner !== end.winner) this.dirtyAt = Date.now();
        this.ledger.winner = end.winner;
      }
    }
    const key = JSON.stringify([end.gameId, end.winner, end.tail.at(-1)]);
    if (!end.tail.length || key === this.tailKey) return;
    // Only worth writing once a Nexus is hurt or a winner exists; healthy tails are routine.
    const hurt = end.tail.some((e) =>
      [e.nexus.ORDER, e.nexus.CHAOS].some(
        (n) => n && n.health !== null && n.maxHealth !== null && n.health < n.maxHealth,
      ),
    );
    if (!hurt && end.winner === null) return;
    this.tailKey = key;
    try {
      await mkdir(dirname(this.TAIL_FILE), { recursive: true });
      await writeFile(
        this.TAIL_FILE,
        JSON.stringify({ ...end, writtenAt: new Date().toISOString() }, null, 1),
      );
    } catch {
      /* ignore */
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
      await mkdir(dirname(this.FILE), { recursive: true });
      await writeFile(this.FILE, JSON.stringify(this.ledger));
    } catch {
      /* ignore */
    }
  }
}
