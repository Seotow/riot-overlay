import type { CSSProperties } from "react";
import { objectiveVisual } from "../../shared/ui-metrics";
import { dragonSoulCopy } from "../../shared/dragon-soul-copy";
const names: Record<string, string> = {
  earth: "MOUNTAIN DRAKE",
  fire: "INFERNAL DRAKE",
  water: "OCEAN DRAKE",
  air: "CLOUD DRAKE",
  hextech: "HEXTECH DRAKE",
  chemtech: "CHEMTECH DRAKE",
  elder: "ELDER DRAGON",
};
export function DragonBanner({
  type,
  soul = false,
}: {
  type?: string;
  soul?: boolean;
}) {
  const key = type?.replace(/^DRAGON_/i, "").toLowerCase() ?? "";
  const visual = objectiveVisual(key);
  const effect = soul ? dragonSoulCopy(key) : undefined;
  const icon = (
    <i
      className="dragon-banner-icon"
      style={{
        maskImage: `url(/broadcast/objectives/${visual?.glyph ?? "elder"}.svg)`,
        WebkitMaskImage: `url(/broadcast/objectives/${visual?.glyph ?? "elder"}.svg)`,
      }}
      aria-hidden="true"
    />
  );
  return (
    <aside
      className={`dragon-event-strip ${soul ? "live-soul-description" : ""}`}
      data-region={soul ? "soul-description" : "dragon-banner"}
      role="status"
      title={effect?.detail}
      aria-label={effect?.detail}
      style={{ "--dragon-color": visual?.color ?? "#ccc" } as CSSProperties}
    >
      {visual && icon}
      <span className={effect ? "soul-effect-copy" : undefined}>
        {soul
          ? effect
            ? effect.lines.map((line) => <span key={line}>{line}</span>)
            : "DRAGON SOUL ACQUIRED"
          : Object.hasOwn(names, key)
            ? names[key]
            : "DRAKE"}
      </span>
      {!soul && visual && icon}
    </aside>
  );
}
