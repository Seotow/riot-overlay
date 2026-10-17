import { createHash } from "node:crypto";
import type { ObservedEvent } from "../../shared/observer";

const obj = (v: unknown): Record<string, unknown> =>
  v !== null && typeof v === "object" && !Array.isArray(v) ? (v as Record<string, unknown>) : {};
const networkId = (v: unknown): number | null =>
  typeof v === "number" && Number.isInteger(v) && v > 0 && v <= 0xffffffff ? v : null;
type Target = {
  team: "ORDER" | "CHAOS";
  kind: "hero" | "turret" | "inhibitor";
  slot?: number;
};

// Typed native events only; no scoreboard-edge inference and no complete-history claim.
// The normalized caller supplies heroes sorted in the exact output slot order.
export function collectorEvents(
  data: Record<string, unknown>,
  heroes: Record<string, unknown>[],
  gameTime: number,
) {
  const targets = new Map<number, Target>();
  const ambiguous = new Set<number>();
  let truncated = false;
  const register = (raw: unknown, kind: Target["kind"], slot?: number) => {
    const info = obj(obj(raw).info),
      id = networkId(info.networkId);
    if (id === null) return false;
    if (targets.has(id) || ambiguous.has(id)) {
      targets.delete(id);
      ambiguous.add(id);
      return false;
    }
    if (info.team !== 1 && info.team !== 2) return false;
    targets.set(id, {
      team: info.team === 1 ? "ORDER" : "CHAOS",
      kind,
      ...(slot === undefined ? {} : { slot }),
    });
    return true;
  };
  // Native identity may be missing while ordinary player telemetry is valid.
  // Suppress events rather than guessing the killer from champion/array order.
  if (heroes.length !== 10 || !heroes.every((h, slot) => register(h, "hero", slot)))
    return { events: [] as ObservedEvent[], truncated: false };
  for (const [key, kind, limit] of [
    ["turrets", "turret", 64],
    ["barracksDampeners", "inhibitor", 6],
  ] as const) {
    const list = data[key];
    if (!Array.isArray(list)) continue;
    if (list.length > limit) {
      truncated = true;
      continue;
    }
    for (const raw of list) register(raw, kind);
  }
  const native = obj(data.gameEvents);
  const output = new Map<string, ObservedEvent>();
  const hashKeys = new Map<number, string>();
  const collisions = new Set<number>();
  let remaining = 4096;
  for (const [key, kind, targetKind, victimKey] of [
    ["heroDieEvents", "ChampionKill", "hero", "victimNetworkId"],
    ["turretKillEvents", "TurretKilled", "turret", "victimNetworkId"],
    ["inhibitorKillEvents", "InhibKilled", "inhibitor", "inhibitorNetworkId"],
    ["aceEvents", "Ace", "hero", "victimNetworkId"],
  ] as const) {
    const list = native[key];
    if (!Array.isArray(list)) continue;
    if (list.length > remaining) {
      truncated = true;
      continue;
    }
    remaining -= list.length;
    for (const raw of list) {
      const e = obj(raw),
        at = e.gameTime;
      // Native retention is unverified. Keep a recent window, never replay a
      // late historical record as a live alert or count it into team totals.
      if (
        typeof at !== "number" ||
        !Number.isFinite(at) ||
        at < 0 ||
        at > gameTime ||
        gameTime - at > 5
      )
        continue;
      const killerId = networkId(e.killerNetworkId),
        victimId = networkId(e[victimKey]);
      if (killerId === null || victimId === null || killerId === victimId) continue;
      const killer = targets.get(killerId),
        victim = targets.get(victimId);
      if (
        !killer ||
        killer.kind !== "hero" ||
        !victim ||
        victim.kind !== targetKind ||
        killer.team === victim.team
      )
        continue;
      const identity = JSON.stringify([kind, at, killerId, victimId]);
      // Safe integer ID is opaque and stable across array reorder. Raw network
      // IDs and player names never enter the shared event contract.
      const id = Number.parseInt(
        createHash("sha256").update(identity).digest("hex").slice(0, 13),
        16,
      );
      if (hashKeys.has(id) && hashKeys.get(id) !== identity) collisions.add(id);
      hashKeys.set(id, identity);
      output.set(identity, {
        id,
        at,
        kind,
        team: killer.team,
        playerSlot: killer.slot,
        killerSlot: killer.slot,
        ...(targetKind === "hero" ? { victimSlot: victim.slot } : {}),
      });
    }
  }
  if (collisions.size) truncated = true;
  const events = [...output.values()]
    .filter((e) => !collisions.has(e.id))
    .sort((a, b) => a.at - b.at || a.kind.localeCompare(b.kind) || a.id - b.id);
  return { events, truncated };
}
