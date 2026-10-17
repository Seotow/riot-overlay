// Test-only dependency replacement. There is no production environment bypass.
import { collectorSafety } from "../../server/collector-safety";
import type { SafetyDecision } from "../../server/collector-safety";
let decision: SafetyDecision = { allowed: true, reason: "spectator" };
collectorSafety.check = async () => ({ ...decision });
collectorSafety.snapshot = () => ({ ...decision });
process.on("message", (message: unknown) => {
  if (message === "test-player")
    decision = { allowed: false, reason: "player" };
  if (message === "test-spectator")
    decision = { allowed: true, reason: "spectator" };
  if (message === "test-unknown")
    decision = { allowed: false, reason: "unverified" };
});
