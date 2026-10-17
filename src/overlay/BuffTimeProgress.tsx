export function buffTimeFraction(
  endAt: number | null,
  time: number | null,
  duration: number,
): number | null {
  if (
    endAt === null ||
    time === null ||
    !Number.isFinite(endAt) ||
    !Number.isFinite(time) ||
    !Number.isFinite(duration) ||
    duration <= 0
  )
    return null;
  return Math.max(0, Math.min(1, (endAt - time) / duration));
}
export function BuffTimeProgress({
  endAt,
  time,
  duration,
  label,
}: {
  endAt: number | null;
  time: number | null;
  duration: number;
  label: string;
}) {
  const fraction = buffTimeFraction(endAt, time, duration);
  return (
    <span
      className={`buff-time-progress${fraction === null ? " unavailable" : ""}`}
      role="progressbar"
      aria-label={label}
      aria-valuemin={0}
      aria-valuemax={100}
      aria-valuenow={fraction === null ? undefined : Math.round(fraction * 100)}
      aria-valuetext={fraction === null ? "Chưa có dữ liệu thời gian" : undefined}
    >
      <i style={{ width: fraction === null ? "0%" : `${fraction * 100}%` }} />
    </span>
  );
}
