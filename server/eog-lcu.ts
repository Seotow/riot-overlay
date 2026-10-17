import { discover, getLocal, type Credentials } from "./diagnostics";
import { reduceHistory, type EogHistory } from "../shared/eog-history";

// Read-only watcher for the client's own end-of-game block. A participant's client has it right
// after the match ends; a spectator's client never does (the endpoint just answers 404).
export class EogLcu {
  private credentials: Credentials | null = null;
  // The participant's client keeps the finished game in its match history for a while.
  async readHistory(gameId: number): Promise<EogHistory | null> {
    try {
      this.credentials ??= await discover();
      if (!this.credentials || !Number.isInteger(gameId) || gameId <= 0) return null;
      const detail = await getLocal(
        "eog-history",
        `/lol-match-history/v1/games/${gameId}`,
        this.credentials,
      );
      if (detail.probe.status !== "ok") return null;
      const timeline = await getLocal(
        "eog-timeline",
        `/lol-match-history/v1/game-timelines/${gameId}`,
        this.credentials,
      );
      return reduceHistory(detail.data, timeline.probe.status === "ok" ? timeline.data : null);
    } catch {
      return null;
    }
  }
  async read(): Promise<unknown | null> {
    try {
      this.credentials ??= await discover();
      if (!this.credentials) return null;
      const result = await getLocal(
        "eog-lcu",
        "/lol-end-of-game/v1/eog-stats-block",
        this.credentials,
      );
      if (result.probe.status === "unreachable") this.credentials = null; // client restarted
      return result.probe.status === "ok" ? (result.data ?? null) : null;
    } catch {
      this.credentials = null;
      return null;
    }
  }
}
