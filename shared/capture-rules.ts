export const COLLECTOR_SAMPLE_INTERVAL_MS = 500;
export const COLLECTOR_REPLAY_MAX_SAMPLES = 30000;
// Compensate processing time without overlapping requests or fabricating ticks.
export function remainingSampleDelay(elapsedMs: number, intervalMs = COLLECTOR_SAMPLE_INTERVAL_MS) {
  return Math.max(0, intervalMs - Math.max(0, elapsedMs));
}
