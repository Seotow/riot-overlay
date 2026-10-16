import {
  independentPlayerFields,
  type IndependentEngineSnapshot,
} from "./independent-engine";

/** Allowlisted metadata recorder: deliberately excludes raw frames and player statistics/identity. */
export class IndependentEngineEvidence {
  private rows: ReturnType<typeof project>[] = [];
  private updates = 0;
  private dropped = 0;
  constructor(private startedAt = new Date().toISOString()) {}
  record(snapshot: IndependentEngineSnapshot) {
    this.updates++;
    if (this.rows.length >= 1500) {
      this.dropped++;
      return;
    }
    this.rows.push(project(snapshot));
  }
  report(completedAt = new Date().toISOString()) {
    return {
      version: 1,
      kind: "independent-engine-acquisition-evidence",
      engine: "rift-independent",
      acquisition: "riot-local-api",
      startedAt: this.startedAt,
      completedAt,
      endpoints: ["/liveclientdata/allgamedata", "/replay/playback"],
      updates: this.updates,
      retained: this.rows.length,
      dropped: this.dropped,
      replacementReady: false,
      rows: this.rows,
      limits: [
        "Sample metadata, not full telemetry or semantic correctness proof.",
        "LB shutdown, game build and same-match identity require separate verification.",
        "Cooldown presence is not proof of every QWER/summoner/item slot.",
        "No raw payload, identities, credentials, stats values or session hashes retained.",
      ],
    };
  }
}
function project(snapshot: IndependentEngineSnapshot) {
  const frame = snapshot.frame,
    sample = frame?.sample;
  return {
    receivedAt: new Date().toISOString(),
    capturedAt: snapshot.capturedAt,
    status: snapshot.status,
    stale: snapshot.stale,
    sequence: frame?.sequence ?? null,
    epoch: frame?.epoch ?? null,
    transition: frame?.transition ?? null,
    gameTime: sample?.gameTime.value ?? null,
    replayTime: sample?.replay.time.value ?? null,
    paused: sample?.replay.paused.value ?? null,
    speed: sample?.replay.speed.value ?? null,
    mapNumber: snapshot.capabilities.mapNumber,
    roster: { ...snapshot.capabilities.roster },
    clockAlignment: snapshot.capabilities.clockAlignment,
    probes: snapshot.probes
      .filter((p) => p.id === "live" || p.id === "playback")
      .map((p) => ({
        id: p.id,
        status: p.status,
        httpStatus: p.httpStatus,
        latencyMs: p.latencyMs,
        observedAt: p.observedAt,
      })),
    coverage: Object.fromEntries(
      independentPlayerFields.map((key) => [
        key,
        snapshot.capabilities.coverage[key].observed,
      ]),
    ),
    eventKinds: [
      ...new Set((frame?.newEvents ?? []).map((event) => event.kind)),
    ].sort(),
  };
}
