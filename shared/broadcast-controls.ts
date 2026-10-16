import type { State, Theme } from "./schema";
type Controls = State["broadcast"];
export function broadcastWidgetOn(
  control: Controls,
  key: "gold" | "levels" | "runes" | "minimal",
  theme: Theme,
) {
  if (key === "minimal")
    return (
      (control?.layout ??
        (control?.view === "minimal" ? "minimal" : theme.variant)) === "minimal"
    );
  if (control?.[key] !== undefined) return control[key]!;
  return (
    control?.view === key ||
    (key === "levels" &&
      (!control || control.view === "normal") &&
      theme.widgets.levels)
  );
}
