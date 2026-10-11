export function CooldownVeil({
  remaining,
  total,
}: {
  remaining: number;
  total: number;
}) {
  if (
    !Number.isFinite(remaining) ||
    !Number.isFinite(total) ||
    remaining <= 0 ||
    total <= 0
  )
    return null;
  const elapsed = 360 * (1 - Math.min(1, Math.max(0, remaining / total)));
  return (
    <>
      <i
        className="cooldown-sweep"
        aria-hidden="true"
        style={{
          background: `conic-gradient(from 0deg, transparent 0deg ${elapsed}deg, #000a ${elapsed}deg 360deg)`,
        }}
      />
      {remaining <= 10 && (
        <b className="item-countdown">{Math.ceil(remaining)}</b>
      )}
    </>
  );
}
