// Both layouts retain420ms entrance and420ms staggered exit. Only the hold changes.
export const PORTRAIT_ENTER_MS = 420;
export const PORTRAIT_EXIT_MS = 420;
export function portraitCueDuration(minimal: boolean) {
  return PORTRAIT_ENTER_MS + (minimal ? 750 : 3000) + PORTRAIT_EXIT_MS;
}
