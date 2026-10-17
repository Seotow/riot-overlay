// Shutdown bounty as the game shows it: the native `goldGivenOnDeath` (a float that grows with the
// kill streak and gold lead) rounded to the nearest 50, shown only from 100 upwards.
export function bountyLabel(value: number | null | undefined): number | null {
  if (typeof value !== "number" || !Number.isFinite(value)) return null;
  const rounded = Math.round(value / 50) * 50;
  return rounded >= 100 ? rounded : null;
}
