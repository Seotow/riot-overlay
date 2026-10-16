import type { ObservedPlayer } from "./observer";
export function resourcePresentation(player?: ObservedPlayer) {
  const code = player?.sourceStats?.value?.resourceType;
  if (code === 0)
    return { kind: "mana", label: "Năng lượng", color: "#259dd9" };
  if (code === 1)
    return { kind: "energy", label: "Nội năng", color: "#c8d94b" };
  if (code === 4 || code === 5 || code === 6 || code === 8)
    return { kind: "fury", label: "Nộ", color: "#d8574c" };
  if (code === 7) return { kind: "heat", label: "Nhiệt", color: "#e5a34b" };
  if (code === 11) return { kind: "flow", label: "Nhịp", color: "#cbd3d7" };
  return {
    kind: code == null ? "unknown" : "other",
    label: code == null ? "Chưa có loại resource" : "Resource",
    color: "#9ca6aa",
  };
}
export function levelProgress(player: ObservedPlayer): number | null {
  const xp = player.experience?.value;
  if (!xp) {
    const total = player.sourceStats?.value?.experience,
      level = player.level.value;
    // SR level1–18 cumulative thresholds: 0,280,660,...18360. The source
    // reports total XP; boundaries are rules, not native-reported fields.
    if (
      typeof total !== "number" ||
      !Number.isFinite(total) ||
      total < 0 ||
      level === null ||
      level < 1 ||
      level >= 18
    )
      return null;
    const previous = (level - 1) * (180 + 50 * level),
      next = level * (180 + 50 * (level + 1));
    return Math.min(1, Math.max(0, (total - previous) / (next - previous)));
  }
  if (
    !xp ||
    xp.nextLevel <= xp.previousLevel ||
    xp.current < xp.previousLevel ||
    xp.current > xp.nextLevel
  )
    return null;
  return (xp.current - xp.previousLevel) / (xp.nextLevel - xp.previousLevel);
}
export function rankLevels(players: ObservedPlayer[]) {
  return [...players].sort(
    (a, b) =>
      (b.level.value ?? -1) - (a.level.value ?? -1) ||
      (levelProgress(b) ?? -1) - (levelProgress(a) ?? -1) ||
      a.slot - b.slot,
  );
}
export const objectiveVisual = (type: string | null | undefined) => {
  const key = type?.replace(/^DRAGON_/i, "").toLowerCase();
  const map: Record<string, { glyph: string; color: string; label: string }> = {
    grub: { glyph: "grubs", color: "#b68cce", label: "SÂU HƯ KHÔNG" },
    grubs: { glyph: "grubs", color: "#b68cce", label: "SÂU HƯ KHÔNG" },
    herald: { glyph: "herald", color: "#bb83dc", label: "SỨ GIẢ KHE NỨT" },
    baron: { glyph: "baron", color: "#c691ed", label: "BARON NASHOR" },
    earth: { glyph: "earth", color: "#bd8f5d", label: "RỒNG ĐẤT" },
    fire: { glyph: "fire", color: "#ef574c", label: "RỒNG LỬA" },
    water: { glyph: "water", color: "#65c8bd", label: "RỒNG NƯỚC" },
    air: { glyph: "air", color: "#c3d1cf", label: "RỒNG GIÓ" },
    hextech: { glyph: "hextech", color: "#68bdeb", label: "RỒNG HEXTECH" },
    chemtech: { glyph: "chemtech", color: "#b5ce5d", label: "RỒNG HÓA KỸ" },
    elder: { glyph: "elder", color: "#1ee4de", label: "RỒNG NGÀN TUỔI" },
  };
  return key && Object.hasOwn(map, key) ? map[key] : null;
};
