import type { NamedAsset } from "../../shared/live-assets";
import type { QuestRole } from "../../shared/role-quest";

// Broadcast labels, not provider-measured stats. Riot 26.1/26.9 sources:
// docs/ROLE_QUEST_COPY.md. In particular MID's old empowered recall was replaced.
const benefits: Record<QuestRole, string[]> = {
  top: ["BONUS XP", "LVL 20 CAP", "TELEPORT"],
  jungle: ["PET & SMITE", "XP & GOLD", "BONUS MS"],
  mid: ["BONUS AD / AP", "T3 BOOTS"],
  bot: ["LUMP OF GOLD", "BONUS GOLD", "BOOTS SLOT"],
  support: ["SUPPORT ITEM", "WARDS SLOT", "DISCOUNT"],
};
export function QuestCompletion({
  role,
  reward,
}: {
  role: QuestRole;
  reward?: NamedAsset;
}) {
  return (
    <aside
      className="quest-completion"
      data-region="quest-completion"
      aria-label={`Hoàn thành quest ${role}`}
    >
      <strong>
        {role.toUpperCase()}
        <small>QUEST COMPLETE</small>
      </strong>
      {benefits[role].map((label, i) => (
        <span key={label}>
          {reward && i === benefits[role].length - 1 ? (
            <img src={reward.icon} alt={reward.name} />
          ) : (
            <svg viewBox="0 0 32 32" aria-hidden="true">
              {label.includes("GOLD") || label === "DISCOUNT" ? (
                <>
                  <ellipse cx="16" cy="9" rx="11" ry="4" />
                  <path d="M5 9v6c0 5 22 5 22 0V9M5 15v6c0 5 22 5 22 0v-6" />
                </>
              ) : label === "LVL 20 CAP" ? (
                <text
                  x="16"
                  y="25"
                  textAnchor="middle"
                  fill="currentColor"
                  stroke="none"
                  fontSize="25"
                >
                  20
                </text>
              ) : (
                <path d="m7 18 9-10 9 10M16 8v20M6 4h20" />
              )}
            </svg>
          )}
          <small>{label}</small>
        </span>
      ))}
    </aside>
  );
}
