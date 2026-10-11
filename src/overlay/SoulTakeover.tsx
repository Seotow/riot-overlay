import type { CSSProperties } from "react";
import type { ObservedEvent } from "../../shared/observer";
import type { Theme } from "../../shared/schema";
import { DragonBanner } from "./DragonBanner";

const elements: Record<
  string,
  { name: string; crop: string; render?: boolean; color: string }
> = {
  water: { name: "RỒNG NƯỚC", crop: "78% center", color: "#155959" },
  air: { name: "RỒNG GIÓ", crop: "50% center", color: "#565f6b" },
  earth: { name: "RỒNG ĐẤT", crop: "48% center", color: "#6e543d" },
  fire: {
    name: "RỒNG LỬA",
    crop: "80% center",
    render: true,
    color: "#7b291b",
  },
  hextech: {
    name: "RỒNG HEXTECH",
    crop: "32% center",
    color: "#174c7b",
  },
  chemtech: { name: "RỒNG HÓA KỸ", crop: "25% center", color: "#3e5724" },
};

// Static raster art only. Infernal is a pre-rendered image, not a painting
// or a runtime 3D model. See the local asset provenance.
export function SoulTakeover({
  event,
  theme,
}: {
  event: ObservedEvent;
  theme: Theme;
}) {
  if (
    event.kind !== "DragonSoul" ||
    !["ORDER", "CHAOS"].includes(event.team ?? "")
  )
    return null;
  const team = event.team === "ORDER" ? theme.blueName : theme.redName;
  const key = event.objectiveType?.toLowerCase() ?? "";
  const element = Object.hasOwn(elements, key) ? elements[key] : undefined;
  return (
    <>
      <aside
        className="live-soul-takeover"
        data-region="soul-takeover"
        role="status"
        style={{ "--soul-color": element?.color ?? "#343d43" } as CSSProperties}
      >
        {element && (
          <img
            className={`soul-artwork${element.render ? " soul-artwork-render" : ""}`}
            src={`/broadcast/artwork/riot-dragons/${key}.webp`}
            style={{ objectPosition: element.crop }}
            alt=""
          />
        )}
        <div className="soul-team">
          <b>{team}</b>
          <span>LINH HỒN RỒNG</span>
        </div>
        <div className="soul-title">
          <span>DRAGON</span>
          <strong>SOUL</strong>
          <small>{element?.name ?? "LINH HỒN RỒNG"}</small>
        </div>
      </aside>
      <DragonBanner type={event.objectiveType} soul />
    </>
  );
}
