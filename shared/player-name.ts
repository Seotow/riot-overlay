import type { ObservedPlayer } from "./observer";
import { liveChampion } from "./live-assets";

// Broadcast nickname only. Never copy account IDs, credentials or raw provider objects.
export function cleanPlayerName(value: unknown): string | null {
  if (typeof value !== "string" || value.length > 160) return null;
  const name = value
    .split("#", 1)[0]
    .replace(/[\u0000-\u001f\u007f]/g, "")
    .trim();
  return name && name.length <= 80 ? name : null;
}

export function playerDisplayName(
  player: ObservedPlayer | undefined,
  overrides?: string[],
  slot = player?.slot ?? 0,
): string {
  return (
    cleanPlayerName(overrides?.[slot]) ??
    cleanPlayerName(player?.playerName?.value) ??
    liveChampion(player?.championId.value)?.name ??
    `PLAYER ${slot + 1}`
  );
}
