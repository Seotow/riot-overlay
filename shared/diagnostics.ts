export type ProbeStatus =
  "ok" | "unreachable" | "http-error" | "invalid" | "not-configured";
export interface Probe {
  id: string;
  source: "LCU" | "Live Client" | "Replay API";
  endpoint: string;
  status: ProbeStatus;
  httpStatus: number | null;
  latencyMs: number | null;
  observedAt: string;
}
export interface Evidence {
  field: string;
  stage: string;
  source: string;
  path: string;
  availability: "observed" | "missing" | "unverified";
  type: string;
  sample: unknown;
  limitation: string;
}
export interface DiagnosticReport {
  version: 1;
  capturedAt: string;
  phase: string | null;
  probes: Probe[];
  fields: Evidence[];
}
