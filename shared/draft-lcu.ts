import { draftCatalog } from "./draft-assets";
import { draftSchema, draftTurns, type DraftState } from "./draft";

// Maps an LCU /lol-champ-select/v1/session payload onto the overlay draft. Only the fields the
// LCU really provides are written (picks, bans, hover, timer, pick order); team configuration
// such as coaches, names, patch and series bans is kept from the current draft.

type Action = {
  actorCellId?: number;
  championId?: number;
  completed?: boolean;
  isInProgress?: boolean;
  type?: string;
};
type Player = {
  cellId?: number;
  championId?: number;
  championPickIntent?: number;
  gameName?: string;
  summonerName?: string;
  internalName?: string;
};

const keyToId = new Map<string, string>(
  Object.values(draftCatalog.champions).map((c) => [c.key, c.id]),
);
const championOf = (key: unknown) =>
  typeof key === "number" && key > 0 ? (keyToId.get(String(key)) ?? null) : null;
const array = (value: unknown): unknown[] => (Array.isArray(value) ? value : []);
const object = (value: unknown): Record<string, unknown> =>
  value && typeof value === "object" ? (value as Record<string, unknown>) : {};
const turnIndex = (side: number, kind: "ban" | "pick", slot: number) =>
  draftTurns.findIndex(([s, k, n]) => s === side && k === kind && n === slot);

export type LcuDraftStatus = {
  status: "offline" | "idle" | "champ-select" | "error";
  phase: string | null;
  updatedAt: number;
};

export function mapChampSelect(
  session: unknown,
  current: DraftState,
  now: number,
): DraftState | null {
  const data = object(session);
  const groups = array(data.actions).map(array);
  const flat = groups.flat().map((a) => object(a) as Action);
  const actions: (string | null)[] = Array(20).fill(null);
  const completed: boolean[] = Array(20).fill(false);
  const seen = { ban: [0, 0], pick: [0, 0] };
  const pickSlotByCell = new Map<number, number>();
  let active = -1;
  let activeAction: Action | undefined;
  for (const action of flat) {
    const kind = action.type === "ban" ? "ban" : action.type === "pick" ? "pick" : null;
    if (!kind || typeof action.actorCellId !== "number" || action.actorCellId < 0) continue;
    const side = action.actorCellId < 5 ? 0 : 1;
    const slot = seen[kind][side]++;
    const index = turnIndex(side, kind, slot);
    if (index < 0) continue;
    if (kind === "pick") pickSlotByCell.set(action.actorCellId, slot);
    completed[index] = action.completed === true;
    if (action.completed) actions[index] = championOf(action.championId);
    if (action.isInProgress && active < 0) {
      active = index;
      activeAction = action;
    }
  }
  if (!flat.length || seen.ban[0] + seen.ban[1] + seen.pick[0] + seen.pick[1] === 0) return null;
  // Without an action in progress the draft sits at the first unfinished turn, or is complete.
  if (active < 0) {
    const open = completed.findIndex((done) => !done);
    active = open < 0 ? 20 : open;
  }
  let hover: string | null = null;
  if (activeAction && active < 20) {
    const cell = activeAction.actorCellId;
    const players = [...array(data.myTeam), ...array(data.theirTeam)].map(
      (p) => object(p) as Player,
    );
    const player = players.find((p) => p.cellId === cell);
    hover = championOf(activeAction.championId) ?? championOf(player?.championPickIntent);
    if (hover && actions.includes(hover)) hover = null;
  }
  // Display positions follow the player's cell (top..support); the pick slot is the turn order.
  const order = current.order.map((o) => [...o]) as DraftState["order"];
  for (let side = 0; side < 2; side++) {
    const used = new Set<number>();
    const next: number[] = Array(5).fill(-1);
    for (let position = 0; position < 5; position++) {
      const slot = pickSlotByCell.get(side * 5 + position);
      if (slot !== undefined && !used.has(slot)) {
        next[position] = slot;
        used.add(slot);
      }
    }
    if (used.size === 5) order[side] = next;
  }
  // Player names come from the client, by cell (0-4 blue, 5-9 red); nothing is typed in.
  // Rebuilt from this session every time, so a bot (no name) is blank, never a leftover from an
  // earlier match. If the session carries no team data at all, the last names stay.
  const players = [...array(data.myTeam), ...array(data.theirTeam)].map((v) => object(v) as Player);
  const names = players.length ? Array<string>(10).fill("") : [...current.names];
  for (const p of players) {
    const name = (p.gameName || p.summonerName || "").trim().slice(0, 30);
    if (typeof p.cellId === "number" && p.cellId >= 0 && p.cellId < 10) names[p.cellId] = name;
  }
  const timer = object(data.timer);
  const left =
    typeof timer.adjustedTimeLeftInPhase === "number" ? timer.adjustedTimeLeftInPhase : null;
  const total = typeof timer.totalTimeInPhase === "number" ? timer.totalTimeInPhase : null;
  const finished = active >= 20;
  const duration =
    total && total >= 1000
      ? Math.min(120, Math.max(5, Math.round(total / 1000)))
      : current.duration;
  let deadline: number | null = null;
  if (!finished && timer.isInfinite !== true && left !== null && left > 0) {
    const proposed = Math.round(now + left);
    // Keep the same deadline while the source only jitters, so the overlay does not restart.
    deadline =
      current.deadline !== null &&
      current.step === active &&
      Math.abs(current.deadline - proposed) < 1500
        ? current.deadline
        : proposed;
  }
  const result = draftSchema.safeParse({
    ...current,
    source: "lcu",
    step: Math.min(20, active),
    actions,
    hover: finished ? null : hover,
    order,
    names,
    duration,
    deadline,
  });
  return result.success ? result.data : null;
}

export function champSelectPhase(session: unknown): string | null {
  const phase = object(object(session).timer).phase;
  return typeof phase === "string" ? phase : null;
}
