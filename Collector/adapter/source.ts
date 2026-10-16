import { WebSocket } from "ws";
import { CollectorGameplay } from "./gameplay";
import { ObserverSession } from "../../server/observer-session";
import type { ObserverFrame, ObservedEvent } from "../../shared/observer";
import {
  normalizeCollector,
  object,
  type NormalizedCollector,
} from "./normalize";

export class LeagueCollectorSource {
  readonly endpoint: string;
  private clock: () => number;
  private socket?: WebSocket;
  private stopped = false;
  private nextAttempt = 0;
  private status:
    | "offline"
    | "connecting"
    | "waiting"
    | "receiving"
    | "stale"
    | "invalid"
    | "stopped" = "offline";
  private normalized: NormalizedCollector | null = null;
  private session = new ObserverSession();
  private gameplay = new CollectorGameplay();
  private frame: ObserverFrame;
  private lastSequence = -1;
  private lastProviderTime = -1;
  private accepted = 0;
  private rejected = 0;
  private pendingEvents = new Map<
    string,
    { event: ObservedEvent; receivedAt: number }
  >();
  private deliveryPrimed = false;
  private pendingTruncated = false;
  constructor(options: { port?: number; clock?: () => number } = {}) {
    const port = options.port ?? 18799;
    if (!Number.isInteger(port) || port < 1024 || port > 65535)
      throw Error("Invalid collector loopback port");
    this.endpoint = `ws://127.0.0.1:${port}/ws`;
    this.clock = options.clock ?? Date.now;
    this.frame = this.session.ingest(null, "", this.now());
  }
  private now() {
    return new Date(this.clock()).toISOString();
  }
  private invalidate(status: typeof this.status) {
    this.pendingEvents.clear();
    this.deliveryPrimed = false;
    this.pendingTruncated = false;
    if (this.normalized || this.frame.status === "observed")
      this.frame = this.session.ingest(null, "", this.now());
    this.normalized = null;
    this.status = status;
  }
  private refresh() {
    if (
      this.normalized &&
      this.clock() - Date.parse(this.normalized.sample.capturedAt) >= 5000
    )
      this.invalidate("stale");
  }
  accept(raw: unknown): boolean {
    if (this.stopped) return false;
    this.refresh();
    const envelope = object(raw);
    if (envelope.type === "lcu") return false; // never retain identity/LCU payloads
    if (envelope.type === "status") {
      if (
        envelope.schemaVersion === 1 &&
        envelope.source === "lblib" &&
        envelope.synthetic === false &&
        ["waiting", "error", "ended", "stopped"].includes(
          String(object(envelope.data).state),
        )
      )
        this.invalidate("waiting");
      return false;
    }
    const normalized = normalizeCollector(raw, this.clock());
    if (!normalized) {
      this.rejected++;
      this.invalidate("invalid");
      return false;
    }
    const sequence = envelope.sequence as number;
    const stamp = Date.parse(normalized.sample.capturedAt);
    // Duplicate/late frames never extend freshness or roll back the epoch.
    if (sequence <= this.lastSequence || stamp < this.lastProviderTime)
      return false;
    this.lastSequence = sequence;
    this.lastProviderTime = stamp;
    this.gameplay.enrich(raw, normalized);
    this.normalized = normalized;
    this.frame = this.session.ingest(
      normalized.sample,
      normalized.signature,
      this.now(),
    );
    if (this.frame.transition !== "none") {
      this.pendingEvents.clear();
      this.deliveryPrimed = false;
      this.pendingTruncated = false;
    } else {
      const clock = normalized.sample.gameTime.value!;
      for (const [key, pending] of this.pendingEvents)
        if (
          pending.event.at > clock ||
          clock - pending.event.at > 5 ||
          this.clock() - pending.receivedAt >= 5000
        )
          this.pendingEvents.delete(key);
      for (const event of this.frame.newEvents) {
        const key = `${event.id}:${event.at}:${event.kind}`;
        if (this.pendingEvents.size >= 4096 && !this.pendingEvents.has(key)) {
          this.pendingTruncated = true;
          continue;
        }
        if (!this.pendingEvents.has(key))
          this.pendingEvents.set(key, { event, receivedAt: this.clock() });
      }
    }
    this.status = "receiving";
    this.accepted++;
    return true;
  }
  disconnected() {
    this.invalidate(this.stopped ? "stopped" : "offline");
    this.lastSequence = -1;
    this.lastProviderTime = -1;
  }
  observe(): ObserverFrame {
    this.refresh();
    return this.frame;
  }
  // Drain only for the shared backend broadcast. HTTP diagnostics are read-only.
  // Native snapshots arrive faster than the backend poll; retain their alerts
  // until both Studio and OBS receive the same latest frame.
  broadcastFrame(): ObserverFrame {
    this.refresh();
    if (!this.frame.sample) return this.frame;
    if (!this.deliveryPrimed) {
      this.deliveryPrimed = true;
      this.pendingEvents.clear();
      this.pendingTruncated = false;
      return { ...this.frame, newEvents: [] };
    }
    const clock = this.frame.sample.gameTime.value!;
    const newEvents = [...this.pendingEvents.values()]
      .filter((p) => this.clock() - p.receivedAt < 5000)
      .map((p) => p.event)
      .filter((e) => e.at <= clock && clock - e.at <= 5)
      .sort((a, b) => a.at - b.at || a.id - b.id);
    this.pendingEvents.clear();
    const truncated = this.pendingTruncated;
    this.pendingTruncated = false;
    return {
      ...this.frame,
      newEvents,
      ...(truncated
        ? {
            sample: {
              ...this.frame.sample,
              limits: { ...this.frame.sample.limits, eventsTruncated: true },
            },
          }
        : {}),
    };
  }
  snapshot() {
    this.refresh();
    const players = this.normalized?.sample.players ?? [];
    const coverage: Record<string, number> = {};
    for (const player of players)
      for (const [key, value] of Object.entries(player)) {
        if (
          value !== null &&
          typeof value === "object" &&
          "availability" in value &&
          value.availability === "observed"
        )
          coverage[key] = (coverage[key] ?? 0) + 1;
      }
    return {
      status: this.status,
      endpoint: this.endpoint,
      acceptedFrames: this.accepted,
      invalidFrames: this.rejected,
      players: players.length,
      coverage,
      lastFrameAt: this.normalized?.sample.capturedAt ?? null,
      capabilities: {
        fields: Object.keys(coverage),
        events: (this.normalized?.sample.events.length ?? 0) > 0,
        objectives: !!this.normalized?.sample.teams?.some(
          (t) => t.dragons.value !== null,
        ),
        roleOrderVerified: false,
        productionReady: false,
      },
      slotOrder: "team-hero-index" as const,
      eventSemantics: "unverified" as const,
    };
  }
  // Explicit opt-in only. Never launches collector, reads env or switches Studio.
  ensureConnected() {
    if (this.stopped || this.socket || this.clock() < this.nextAttempt) return;
    this.status = "connecting";
    const socket = new WebSocket(this.endpoint, {
      handshakeTimeout: 2500,
      maxPayload: 16 * 1024 * 1024,
      followRedirects: false,
    });
    this.socket = socket;
    socket.on("open", () => {
      if (this.socket === socket) this.status = "waiting";
    });
    socket.on("message", (bytes) => {
      if (this.socket !== socket) return;
      try {
        this.accept(JSON.parse(bytes.toString()));
      } catch {
        this.rejected++;
        this.invalidate("invalid");
      }
    });
    socket.on("unexpected-response", (_request, response) => {
      response.resume();
      socket.terminate();
    });
    socket.on("error", () => {
      if (this.socket === socket) this.invalidate("offline");
    });
    socket.on("close", () => {
      if (this.socket !== socket) return;
      this.disconnected();
      this.socket = undefined;
      this.nextAttempt = this.clock() + 5000;
    });
  }
  stop() {
    this.stopped = true;
    this.disconnect();
  }
  recording() {
    return this.session.recording();
  }
  disconnect() {
    this.nextAttempt = 0;
    const socket = this.socket;
    this.socket = undefined;
    socket?.terminate();
    this.disconnected();
  }
}
