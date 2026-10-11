import type { ObservedPlayer } from "./observer";
export function levelProgress(player: ObservedPlayer): number | null {
  const xp = player.experience?.value;
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
    elder: { glyph: "elder", color: "#ece5d7", label: "RỒNG NGÀN TUỔI" },
  };
  return key && Object.hasOwn(map, key) ? map[key] : null;
};
