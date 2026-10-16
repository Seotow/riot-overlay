// Only objective families: lane, inhibitor, gold and tower assets stay unchanged.
const names = new Set([
  "air",
  "earth",
  "fire",
  "water",
  "hextech",
  "chemtech",
  "elder",
  "baron",
  "herald",
  "grubs",
  "dragon",
]);
export function objectiveIconUrl(type: string) {
  const name = type.replace(/^DRAGON_/i, "").toLowerCase();
  const normalized = name === "grub" ? "grubs" : name;
  if (normalized === "grubs") return "/broadcast/objectives/grubs.svg";
  if (normalized === "baron") return "/broadcast/objectives/mixed/baron.svg";
  return `/broadcast/objectives/riot-16.20/${names.has(normalized) ? normalized : "dragon"}.png`;
}
