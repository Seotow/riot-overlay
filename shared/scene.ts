import type { ObserverFrame } from "./observer";
import type { State } from "./schema";

export type ConcreteScene = "draft" | "ingame" | "postgame";
const FRESH_MS = 5000;

// Which scene the overlay shows when nothing is pinned. Null means a completely empty overlay.
// Champ select from the client wins; live game data takes over once it is flowing.
export function detectScene(
  state: Pick<State, "scene" | "draftLcu" | "postgame">,
  frame: ObserverFrame | null,
  now: number,
): ConcreteScene | null {
  if (state.scene !== "auto") return state.scene;
  if (state.draftLcu?.status === "champ-select") return "draft";
  if (
    frame?.status === "observed" &&
    frame.sample &&
    now - Date.parse(frame.sample.capturedAt) < FRESH_MS
  )
    return "ingame";
  return null;
}
