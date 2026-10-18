// Shutdown bounty: the native `goldGivenOnDeath` (a float that grows with the kill streak and gold
// lead) with the decimals dropped, shown only from 100 upwards.
export function bountyLabel(value: number | null | undefined): number | null {
  if (typeof value !== "number" || !Number.isFinite(value)) return null;
  const whole = Math.floor(value);
  return whole >= 100 ? whole : null;
}
