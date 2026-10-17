import { execFile } from "node:child_process";
import { promisify } from "node:util";
import { discover, getLocal } from "./diagnostics";

export type SafetyDecision = {
  allowed: boolean;
  reason: "spectator" | "replay" | "player" | "unverified";
};
export function decideCollectorSafety(
  active: unknown,
  mode: unknown,
): SafetyDecision {
  if (typeof active !== "string" || !active.trim())
    return { allowed: false, reason: "unverified" };
  if (!["unknown", "spectator"].includes(active.trim().toLowerCase()))
    return { allowed: false, reason: "player" };
  return mode === "replay" || mode === "spectator"
    ? { allowed: true, reason: mode }
    : { allowed: false, reason: "unverified" };
}

// Return only a mode. Process command lines and LCU credentials stay local.
export async function probeCollectorSafety(): Promise<SafetyDecision> {
  try {
    const active = await getLocal(
      "collector-safety",
      "/liveclientdata/activeplayername/",
    );
    if (active.probe.status !== "ok") return decideCollectorSafety(null, null);
    const early = decideCollectorSafety(active.data, null);
    if (early.reason === "player") return early;
    let mode: string | null = null;
    if (process.platform === "win32") {
      try {
        const { stdout } = await promisify(execFile)(
          "powershell.exe",
          [
            "-NoProfile",
            "-NonInteractive",
            "-Command",
            String.raw`$ErrorActionPreference='Stop'; $p=@(Get-CimInstance Win32_Process -Filter "Name = 'League of Legends.exe'"); if($p.Count -eq 1) { $c=$p[0].CommandLine; if($c -match '(?i)\.rofl(?:"|\s|$)') {'replay'} elseif($c -match '(?i)(?:^|\s|")spectator\s') {'spectator'} }`,
          ],
          { timeout: 2000, windowsHide: true, maxBuffer: 1024 },
        );
        mode = stdout.trim();
      } catch {
        /* LCU can still confirm spectator when process inspection is unavailable. */
      }
    }
    if (mode !== "replay" && mode !== "spectator") {
      const credentials = await discover();
      if (credentials) {
        const session = await getLocal(
          "collector-safety-session",
          "/lol-gameflow/v1/session",
          credentials,
        );
        const data = session.data as
          { gameData?: { isSpectator?: unknown }; phase?: unknown } | undefined;
        if (
          session.probe.status === "ok" &&
          data?.phase === "InProgress" &&
          data.gameData?.isSpectator === true
        )
          mode = "spectator";
      }
    }
    return decideCollectorSafety(active.data, mode);
  } catch {
    return { allowed: false, reason: "unverified" };
  }
}

export class CollectorSafetyGate {
  private pending?: Promise<SafetyDecision>;
  private last: SafetyDecision = { allowed: false, reason: "unverified" };
  private checkedAt = 0;
  constructor(
    private probe = probeCollectorSafety,
    private clock = Date.now,
  ) {}
  snapshot() {
    return { ...this.last };
  }
  check(): Promise<SafetyDecision> {
    if (this.pending) return this.pending;
    if (this.clock() - this.checkedAt < 500) return Promise.resolve(this.last);
    this.pending = this.probe()
      .catch((): SafetyDecision => ({ allowed: false, reason: "unverified" }))
      .then((result) => {
        this.last = result;
        this.checkedAt = this.clock();
        return result;
      })
      .finally(() => {
        this.pending = undefined;
      });
    return this.pending;
  }
}
export const collectorSafety = new CollectorSafetyGate();
