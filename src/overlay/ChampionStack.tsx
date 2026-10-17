import type { ObservedPlayer } from "../../shared/observer";
import { stackChampion } from "../../shared/champion-stacks";
export function ChampionStack({
  player,
  minimal = false,
}: {
  player?: ObservedPlayer;
  minimal?: boolean;
}) {
  const rule = stackChampion(player?.championId.value);
  if (!rule) return null;
  const field = player?.championStacks;
  const value = field?.availability === "observed" ? field.value : null;
  const text = value == null ? "0" : String(value);
  return (
    <span
      className={`champion-stack ${minimal ? "minimal-stack" : "secondary-stack"} ${value == null ? "unavailable" : ""}`}
      data-region="champion-stack"
      data-stack-value={value ?? undefined}
      title={`${rule.code}: ${value == null ? "chưa có dữ liệu stack · hiển thị tạm 0" : `${text} stack · ${field?.source}`} · icon ${rule.ability}`}
      aria-label={`${rule.code} stack ${text}`}
    >
      <img
        src={`/broadcast/champion-stacks/${rule.code}.png`}
        alt={`Stack ${rule.code} · ${rule.ability}`}
      />
      <em
        style={{
          fontSize: `${Math.min(minimal ? 13 : 11, (minimal ? 38 : 44) / Math.max(3, text.length))}px`,
        }}
      >
        {text}
      </em>
    </span>
  );
}
