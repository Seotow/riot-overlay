import { randomUUID } from "node:crypto";
import {
  observerFrameSchema,
  recordingSchema,
  type IngameSample,
  type ObserverFrame,
  type ObserverRecording,
} from "../shared/observer";
export class ObserverSession {
  private sessionId: string | null = null;
  private sequence = 0;
  private epoch = 0;
  private signature = "";
  private previous: IngameSample | null = null;
  private lost = false;
  private seen = new Set<string>();
  private history: ObserverFrame[] = [];
  private historyBytes = 0;
  private sizes: number[] = [];
  ingest(
    sample: IngameSample | null,
    signature: string,
    now: string,
    playback?: ObserverFrame["playback"],
  ): ObserverFrame {
    let transition: ObserverFrame["transition"] = "none";
    if (this.previous && Date.parse(now) - Date.parse(this.previous.capturedAt) > 5000)
      this.lost = true;
    if (!sample) {
      if (!this.lost && this.sessionId) transition = "lost";
      this.lost = true;
      this.previous = null;
      this.seen.clear();
    } else {
      if (!this.sessionId || this.lost || this.signature !== signature) {
        transition = !this.sessionId ? "connected" : this.lost ? "reconnected" : "source-changed";
        this.sessionId = randomUUID();
        this.sequence = 0;
        this.epoch = 0;
        this.seen.clear();
        this.previous = null;
      } else if (this.previous) {
        // A discontinuity creates an epoch; do not replay old kills as new alerts.
        const before = this.previous.gameTime.value ?? this.previous.replay.time.value;
        const after = sample.gameTime.value ?? sample.replay.time.value;
        const elapsed = Math.max(
          0,
          (Date.parse(now) - Date.parse(this.previous.capturedAt)) / 1000,
        );
        const speed = sample.replay.speed.value ?? 1;
        if (
          before !== null &&
          after !== null &&
          (after < before - 0.05 || after - before > Math.max(5, elapsed * Math.max(1, speed) + 2))
        ) {
          transition = "seek";
          this.epoch++;
          this.seen.clear();
        }
      }
      this.signature = signature;
      this.lost = false;
    }
    const newEvents: NonNullable<ObserverFrame["sample"]>["events"] = [];
    if (sample) {
      const clock = sample.gameTime.value ?? sample.replay.time.value;
      const currentEvents = sample.events.filter((e) => clock !== null && e.at <= clock);
      for (const e of currentEvents) {
        const key = `${e.id}:${e.at}:${e.kind}`;
        if (transition === "none" && !this.seen.has(key)) newEvents.push(e);
        this.seen.add(key);
      }
      // Bound dedup memory to current provider window.
      if (this.seen.size > 8192)
        this.seen = new Set(currentEvents.map((e) => `${e.id}:${e.at}:${e.kind}`));
      this.previous = sample;
    }
    const frame = observerFrameSchema.parse({
      protocolVersion: 1,
      sessionId: this.sessionId,
      sequence: ++this.sequence,
      epoch: this.epoch,
      status: sample ? "observed" : "unavailable",
      transition,
      capturedAt: now,
      sample,
      newEvents,
      ...(playback ? { playback } : {}),
    });
    this.history.push(frame);
    const size = Buffer.byteLength(JSON.stringify(frame));
    this.sizes.push(size);
    this.historyBytes += size;
    while (
      this.history.length > 120 ||
      (this.historyBytes > 2_000_000 && this.history.length > 1)
    ) {
      this.history.shift();
      this.historyBytes -= this.sizes.shift()!;
    }
    return frame;
  }
  recording(): ObserverRecording {
    return recordingSchema.parse({
      version: 1,
      kind: "sanitized-observer-recording",
      exportedAt: new Date().toISOString(),
      frames: this.history,
    });
  }
}
