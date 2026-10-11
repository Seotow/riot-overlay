export function TowerBanner({
  team,
  first,
}: {
  team: string;
  first?: boolean;
}) {
  return (
    <aside
      className="dragon-event-strip tower-event-strip"
      data-region="tower-banner"
      role="status"
    >
      <svg className="tower-banner-icon" viewBox="0 0 30 30" aria-hidden="true">
        <path d="M8 4h4v5h6V4h4v10l-3 3 2 9H9l2-9-3-3zM12 0h6v6h-6z" />
      </svg>
      <span>
        {team} · {first ? "FIRST TURRET · BONUS GOLD" : "TURRET DESTROYED"}
      </span>
      <svg className="tower-banner-icon" viewBox="0 0 30 30" aria-hidden="true">
        <path d="M8 4h4v5h6V4h4v10l-3 3 2 9H9l2-9-3-3zM12 0h6v6h-6z" />
      </svg>
    </aside>
  );
}
