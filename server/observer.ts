import { getLocal, type Result } from "./diagnostics";
import { normalizeIngame, rosterSignature } from "./ingame-adapter";
import { ObserverSession } from "./observer-session";
import { enrichRiotObjectives } from "./riot-objectives";
import type { ObserverFrame } from "../shared/observer";
import type { Probe } from "../shared/diagnostics";
type ReadSource = (id: string, endpoint: string) => Promise<Result>;
export class IngameCollector {
  private session = new ObserverSession();
  private pending: Promise<ObserverFrame> | undefined;
  private cached: ObserverFrame | undefined;
  constructor(
    private read: ReadSource = getLocal,
    private clock: () => number = Date.now,
    private onProbes?: (probes: readonly Probe[]) => void,
  ) {}
  recording() {
    return this.session.recording();
  }
  async observe(): Promise<ObserverFrame> {
    if (this.pending) return this.pending;
    if (this.cached && this.clock() - Date.parse(this.cached.capturedAt) < 500)
      return this.cached;
    this.pending = (async () => {
      const results = await Promise.allSettled([
        this.read("live", "/liveclientdata/allgamedata"),
        this.read("playback", "/replay/playback"),
      ]);
      const live = results[0].status === "fulfilled" ? results[0].value : null;
      const replay =
        results[1].status === "fulfilled" ? results[1].value : null;
      const now = new Date(this.clock()).toISOString();
      try {
        this.onProbes?.(
          results.flatMap((r) =>
            r.status === "fulfilled" ? [r.value.probe] : [],
          ),
        );
      } catch {
        /* Diagnostic consumers must not affect collection. */
      }
      const sample = enrichRiotObjectives(
        normalizeIngame(
          live?.probe.status === "ok" ? live.data : null,
          replay?.probe.status === "ok" ? replay.data : null,
          now,
        ),
        live?.probe.status === "ok" ? live.data : null,
      );
      const available =
        sample.gameTime.value !== null ||
        sample.replay.time.value !== null ||
        sample.players.some((p) =>
          [p.level, p.kills, p.cs, p.championId].some((f) => f.value !== null),
        );
      // Different source sets/clock domains/rosters must not share event history.
      const domain =
        sample.gameTime.value !== null
          ? "live"
          : sample.replay.time.value !== null
            ? "replay"
            : "none";
      const signature = `${live?.probe.status}:${replay?.probe.status}:${domain}:${rosterSignature(live?.probe.status === "ok" ? live.data : null)}`;
      this.cached = this.session.ingest(
        available ? sample : null,
        signature,
        now,
      );
      return this.cached;
    })();
    try {
      return await this.pending;
    } finally {
      this.pending = undefined;
    }
  }
}
const collector = new IngameCollector();
export const observerRecording = () => collector.recording();
export const observeIngame = () => collector.observe();
