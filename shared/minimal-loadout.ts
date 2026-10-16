import type { ObservedPlayer } from "./observer";
import { liveItem, liveSpell } from "./live-assets";
import { showItemCooldown } from "./role-quest";

export function minimalLoadout(player?: ObservedPlayer) {
  const cooldowns = player?.cooldowns?.value ?? [];
  const inventory =
    player?.inventory?.value ??
    (player?.items.value ?? []).map((id, slot) => ({ id, slot }));
  const quest = player?.roleQuest?.value;
  const reward = quest?.completed
    ? quest.rewardItemId
      ? liveItem(quest.rewardItemId)
      : liveSpell(quest.rewardSpellId)
    : undefined;
  // A granted Teleport is not Flash's D/F cooldown. Reuse only matching evidence.
  const teleportSlot =
    player?.spells?.value?.findIndex((id) => /teleport/i.test(id ?? "")) ?? -1;
  const rewardSpellKey = liveSpell(quest?.rewardSpellId)?.key;
  const rewardCooldown =
    reward && quest?.rewardSpellId
      ? cooldowns.find(
          (cd) =>
            cd.kind === "spell" &&
            ((rewardSpellKey != null && cd.id === rewardSpellKey) ||
              (quest.role === "top" &&
                teleportSlot >= 0 &&
                cd.slot === (teleportSlot === 0 ? "D" : "F"))),
        )
      : reward && quest?.rewardItemId
        ? cooldowns.find(
            (cd) => cd.kind === "item" && cd.id === quest.rewardItemId,
          )
        : undefined;
  const items = inventory
    .filter((item) => item.slot >= 0 && item.slot < 6)
    .sort((a, b) => a.slot - b.slot)
    .flatMap((item) => {
      const asset = liveItem(item.id);
      const cooldown = cooldowns.find(
        (cd) =>
          cd.kind === "item" &&
          cd.id === item.id &&
          cd.slot === String(item.slot),
      );
      return asset &&
        showItemCooldown(item.id) &&
        (cooldown || item.id === 3026)
        ? [{ id: item.id, slot: item.slot, asset, cooldown }]
        : [];
    })
    .slice(0, 3);
  return { reward, rewardCooldown, items };
}
