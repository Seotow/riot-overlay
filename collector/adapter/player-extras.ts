import { bootIds, completedQuestIds, questRoles } from "../../shared/role-quest";
import type { ObservedPlayer } from "../../shared/observer";
const obj = (v: unknown): Record<string, unknown> =>
  v !== null && typeof v === "object" && !Array.isArray(v) ? (v as Record<string, unknown>) : {};
export const nonnegative = (v: unknown): number | null =>
  typeof v === "number" && Number.isFinite(v) && v >= 0 ? v : null;
export function collectorPlayerExtras(h: Record<string, unknown>, gameTime: number) {
  const common = obj(h.common),
    respawn = nonnegative(h.respawnTime);
  const buffs = Array.isArray(common.buffs) ? common.buffs.map(obj) : null;
  const hasBuff = (name: string) =>
    buffs === null
      ? null
      : buffs.some(
          (b) =>
            typeof b.name === "string" &&
            b.name.toLowerCase() === name &&
            (nonnegative(b.endTime) === null || Number(b.endTime) > gameTime),
        );
  const items = Array.isArray(h.items) ? h.items.map(obj) : [];
  const quest = items.find(
    (i) =>
      i.slot === 8 &&
      typeof i.id === "number" &&
      (questRoles[i.id] || bootIds.has(i.id) || i.id === 2055),
  );
  // Item slot8 can hold a control ward before support completes its quest.
  // Exact role buffs carry points even when item.stats is an empty object.
  const roleNames = {
    top: "Top",
    jungle: "Jungle",
    mid: "Mid",
    bot: "Bot",
    support: "Support",
  } as const;
  const activeBuff = (name: string) =>
    buffs?.find(
      (b) =>
        typeof b.name === "string" &&
        b.name.toLowerCase() === name.toLowerCase() &&
        (nonnegative(b.endTime) === null || Number(b.endTime) > gameTime),
    );
  const buffRole = (Object.keys(roleNames) as Array<keyof typeof roleNames>).find(
    (r) =>
      activeBuff(`SR_2026_S1_RoleBound_${roleNames[r]}_Quest`) ||
      activeBuff(`SR_2026_S1_RoleBound_${roleNames[r]}_QuestCompleted`),
  );
  const id = quest?.id as number | undefined,
    role = buffRole ?? (id ? (questRoles[id] ?? (bootIds.has(id) ? "bot" : "support")) : null);
  const questBuff = role ? activeBuff(`SR_2026_S1_RoleBound_${roleNames[role]}_Quest`) : undefined;
  const doneBuff = role
    ? activeBuff(`SR_2026_S1_RoleBound_${roleNames[role]}_QuestCompleted`)
    : undefined;
  const supportDone = items.some((i) =>
    [3867, 3869, 3870, 3871, 3876, 3877].includes(Number(i.id)),
  );
  const completed =
    !!doneBuff ||
    (questBuff
      ? false
      : !!id &&
        (completedQuestIds.has(id) || bootIds.has(id) || (role === "support" && supportDone)));
  const spells = Array.isArray(h.spells) ? h.spells.map(obj) : [];
  const stats = quest?.stats;
  const itemProgress =
    Array.isArray(stats) &&
    nonnegative(stats[0]) !== null &&
    nonnegative(stats[1]) !== null &&
    stats[1] > 0 &&
    stats[0] <= stats[1]
      ? stats[0] / stats[1]
      : null;
  // Patch26 SR rules: points are native, denominators are pinned game rules.
  // Jungle's RoleBound count stays zero; itemsmitecounter / pet charges count DOWN.
  const target =
    role === "top"
      ? 1200
      : role === "mid" || role === "bot"
        ? 1350
        : role === "support"
          ? 800
          : null;
  const points = nonnegative(questBuff?.count);
  const pet = items.find((i) => [1101, 1102, 1103].includes(Number(i.id)));
  const remaining = nonnegative(activeBuff("itemsmitecounter")?.count) ?? nonnegative(pet?.charges);
  const progress =
    role === "jungle"
      ? remaining !== null && remaining <= 35
        ? (35 - remaining) / 35
        : itemProgress
      : points !== null && target !== null
        ? Math.min(1, points / target)
        : itemProgress;
  const roleQuest: NonNullable<ObservedPlayer["roleQuest"]>["value"] =
    quest && id && role
      ? {
          role,
          itemId: id,
          completed,
          progress: completed ? 1 : progress,
          rewardItemId:
            role === "bot" && bootIds.has(id)
              ? id
              : role === "support" && completed
                ? 2055
                : role === "mid" && completed
                  ? ((items.find((i) => Number(i.slot) < 6 && bootIds.has(Number(i.id)))
                      ?.id as number) ?? null)
                  : null,
          rewardSpellId:
            role === "jungle"
              ? ((spells.find(
                  (s) => typeof s.name === "string" && /^SummonerSmiteAvatar/.test(s.name),
                )?.name as string) ?? null)
              : role === "top" && completed
                ? "S12_SummonerTeleportUpgrade"
                : null,
        }
      : null;
  const status = nonnegative(common.status);
  return {
    respawnSeconds: respawn,
    isDead:
      status !== null && Number.isInteger(status)
        ? (status & 1) === 0
        : respawn === null
          ? null
          : respawn > 0,
    hasBaron: hasBuff("exaltedwithbaronnashor"),
    hasElder: hasBuff("elderdragonbuff"),
    roleQuest,
  };
}
