import { discover, getLocal, type Credentials } from "./diagnostics";

// Read-only watcher for the client's own end-of-game block. A participant's client has it right
// after the match ends; a spectator's client never does (the endpoint just answers 404).
export class EogLcu {
  private credentials: Credentials | null = null;
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
