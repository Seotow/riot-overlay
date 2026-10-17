import { readdir, stat } from "node:fs/promises";
import { homedir } from "node:os";
import { resolve } from "node:path";
import { discover, getLocal, postLocal, type Credentials } from "./diagnostics";
import { roflGameId } from "./rofl";

// Where replay files can come from: the client's own replay folder (asked from the LCU), an
// optional LOL_REPLAYS_DIR, the default Documents folder, and a drop folder for files copied over.
export const ROFL_INBOX = resolve(".npm-cache/rofl-inbox");

export type ReplayStatus = {
  phase: string | null;
  gameId: number | null;
  download: "idle" | "requested" | "failed" | "ready";
  detail: string | null;
};

export class ReplayWatcher {
  private credentials: Credentials | null = null;
  private seen = new Set<string>();
  private attempted = new Set<number>();
  private status: ReplayStatus = { phase: null, gameId: null, download: "idle", detail: null };
  snapshot(): ReplayStatus {
    return { ...this.status };
  }
  private async client() {
    this.credentials ??= await discover();
    return this.credentials;
  }
  async dirs(): Promise<string[]> {
    const dirs = new Set<string>([ROFL_INBOX]);
    if (process.env.LOL_REPLAYS_DIR) dirs.add(resolve(process.env.LOL_REPLAYS_DIR));
    const credentials = await this.client();
    if (credentials) {
      const path = await getLocal("replays-path", "/lol-replays/v1/rofls/path", credentials);
      if (path.probe.status === "ok" && typeof path.data === "string") dirs.add(resolve(path.data));
    }
    dirs.add(resolve(homedir(), "Documents", "League of Legends", "Replays"));
    return [...dirs];
  }
  async files(): Promise<{ name: string; dir: string; size: number; modified: string }[]> {
    const out: { name: string; dir: string; size: number; modified: string }[] = [];
    for (const dir of await this.dirs()) {
      try {
        for (const name of await readdir(dir)) {
          if (roflGameId(name) === null) continue;
          const info = await stat(resolve(dir, name));
          out.push({ name, dir, size: info.size, modified: info.mtime.toISOString() });
        }
      } catch {
        /* folder does not exist on this machine */
      }
    }
    return out.sort((a, b) => b.modified.localeCompare(a.modified)).slice(0, 30);
  }
  // New replay files since the last scan (the first scan only records what already exists).
  private primed = false;
  async fresh(): Promise<{ name: string; dir: string }[]> {
    const files = await this.files();
    const fresh = this.primed ? files.filter((f) => !this.seen.has(f.dir + "|" + f.name)) : [];
    for (const f of files) this.seen.add(f.dir + "|" + f.name);
    this.primed = true;
    return fresh;
  }
  // After a spectated/played match the replay is requested once per game from the client itself
  // (the same request the client's own "download replay" button sends). Nothing is bypassed: if the
  // client refuses, the status says so and nothing else happens.
  async afterMatch(): Promise<void> {
    const credentials = await this.client();
    if (!credentials) return;
    const flow = await getLocal("replays-phase", "/lol-gameflow/v1/gameflow-phase", credentials);
    const phase = flow.probe.status === "ok" && typeof flow.data === "string" ? flow.data : null;
    const previous = this.status.phase;
    this.status.phase = phase;
    if (phase === "InProgress" || phase === "WatchInProgress") {
      const session = await getLocal("replays-session", "/lol-gameflow/v1/session", credentials);
      const id = Number(
        (session.data as { gameData?: { gameId?: unknown } } | undefined)?.gameData?.gameId,
      );
      if (Number.isInteger(id) && id > 0) this.status.gameId = id;
      return;
    }
    const gameId = this.status.gameId;
    const ended =
      previous === "InProgress" || previous === "WatchInProgress" || previous === "Reconnect";
    if (!gameId || this.attempted.has(gameId) || !(ended || phase === "EndOfGame")) return;
    this.attempted.add(gameId);
    const code = await postLocal(
      `/lol-replays/v1/rofls/${gameId}/download`,
      { componentType: "replay-button-match-history" },
      credentials,
    );
    this.status = {
      ...this.status,
      download: code !== null && code < 300 ? "requested" : "failed",
      detail: `HTTP ${code ?? "không kết nối"}`,
    };
  }
}
