import type { IngameSample } from "./observer";
import { PIT_RULES as rules } from "./game-rules";
export type PitTimer = NonNullable<IngameSample["pitTimers"]>[number] & {
  basis?: "reported" | "rule-estimate";
};
export function presentationPitTimers(sample: IngameSample | null): PitTimer[] {
  if (!sample || sample.gameTime.value === null) return [];
  const time = sample.gameTime.value,
    events = sample.events.filter((e) => e.at <= time);
  const field = <T>(value: T | null) => ({
    value,
    availability: value === null ? ("missing" as const) : ("observed" as const),
    source: sample.gameTime.source,
    observedAt: sample.capturedAt,
  });
  const dragon = [...events].reverse().find((e) => e.kind === "DragonKill");
  const soul = events.some((e) => e.kind === "DragonSoul");
  const reportedDragon = sample.pitTimers?.find(t => t.pit === "dragon");
  // Type comes from source only. History may estimate the clock, not identity.
  const elderRespawn = reportedDragon?.type.value
    ? /^(?:DRAGON_)?elder$/i.test(reportedDragon.type.value)
    : dragon?.objectiveType === "elder" || soul;
  const baron = [...events].reverse().find((e) => e.kind === "BaronKill");
  const heraldKilled = events.some((e) => e.kind === "HeraldKill");
  const grubsKilled =
    events.filter((e) => e.kind === "VoidGrubKill").length >= 3;
  const topType =
    baron || time >= rules.baronFirst || heraldKilled
      ? "baron"
      : time >= rules.heraldFirst || grubsKilled
        ? "herald"
        : "grubs";
  const defaults: PitTimer[] = [
    {
      pit: "baron",
      type: field(topType),
      timeAlive: field(
        baron
          ? baron.at + rules.baronRespawn
          : topType === "baron"
            ? rules.baronFirst
            : topType === "herald"
              ? rules.heraldFirst
              : rules.grubsFirst,
      ),
      timeDestroy: field<number>(null),
      basis: "rule-estimate",
    },
    {
      pit: "dragon",
      type: field("dragon"),
      timeAlive: field(
        dragon
          ? dragon.at +
              (elderRespawn
                ? rules.elderRespawn
                : rules.dragonRespawn)
          : rules.dragonFirst,
      ),
      timeDestroy: field<number>(null),
      basis: "rule-estimate",
    },
  ];
  return defaults.map((timer) => {
    const reported = sample.pitTimers?.find((t) => t.pit === timer.pit);
    return reported &&
      (reported.isAlive?.value === true || reported.timeAlive.value !== null || reported.timeDestroy.value !== null)
      ? reported
      : { ...timer, ...(reported?.type.value ? { type: reported.type } : {}) };
  });
}
