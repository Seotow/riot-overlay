import { z } from "zod";
import type { RiotPostgameState } from "../shared/postgame";
import { normalizeRofl, roflInputSchema } from "../shared/rofl-postgame";
import { readRofl } from "./rofl";
import type { LedgerSnapshot } from "../shared/match-ledger";

export const roflImportSchema = z.union([
  // Rows reduced in the browser from the tail of a .rofl chosen by the operator.
  z.object({ gameNumber: z.number().int().min(1).max(99), rofl: roflInputSchema }).strict(),
  // A replay already on this machine (client replay folder or the drop folder).
  z
    .object({
      gameNumber: z.number().int().min(1).max(99),
      replay: z.string().regex(/^[A-Za-z0-9]{2,6}-\d{1,15}\.rofl$/),
    })
    .strict(),
]);

class PostgameError extends Error {
  constructor(
    public status: number,
    public code: string,
  ) {
    super(code);
  }
}

// Holds the one postgame candidate waiting for review. It only ever comes from a replay file.
export class PostgameService {
  private candidate: RiotPostgameState | null = null;
  status() {
    return { candidate: this.candidate };
  }
  publishedCandidate(matchId: string) {
    if (!this.candidate || this.candidate.evidence.matchId !== matchId)
      throw new PostgameError(409, "no-candidate");
    return structuredClone(this.candidate);
  }
  // `locate` maps a replay file name to a real path inside one of the allowed folders.
  async importRofl(
    input: unknown,
    locate: (name: string) => Promise<string | null>,
    ledger: LedgerSnapshot | null = null,
  ) {
    const value = roflImportSchema.parse(input);
    let rows;
    if ("replay" in value) {
      const path = await locate(value.replay);
      if (!path) throw new PostgameError(404, "no-file");
      rows = await readRofl(path);
    } else rows = value.rofl;
    this.candidate = normalizeRofl(rows, value.gameNumber, new Date(), ledger);
    return this.status();
  }
  // Automatic path: a new replay file appears (downloaded by the client). Stage it once for review.
  async stageReplayFile(path: string, ledger: LedgerSnapshot | null = null) {
    try {
      const rows = await readRofl(path);
      if (this.candidate?.evidence.matchId === `VN2_${rows.gameId}`) return false;
      this.candidate = normalizeRofl(rows, this.candidate?.gameNumber ?? 1, new Date(), ledger);
      return true;
    } catch {
      return false;
    }
  }
}
export function postgameError(e: unknown) {
  return e instanceof PostgameError
    ? { status: e.status, code: e.code }
    : { status: 400, code: "invalid-data" };
}
