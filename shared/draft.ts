import { z } from "zod";
import { draftChampion as champion } from "./draft-assets";

// Tournament draft: bans 3+2 and picks 3+2 on each side.
export const draftTurns = [
  [0, "ban", 0],
  [1, "ban", 0],
  [0, "ban", 1],
  [1, "ban", 1],
  [0, "ban", 2],
  [1, "ban", 2],
  [0, "pick", 0],
  [1, "pick", 0],
  [1, "pick", 1],
  [0, "pick", 1],
  [0, "pick", 2],
  [1, "pick", 2],
  [1, "ban", 3],
  [0, "ban", 3],
  [1, "ban", 4],
  [0, "ban", 4],
  [1, "pick", 3],
  [0, "pick", 3],
  [0, "pick", 4],
  [1, "pick", 4],
] as const;
function emptySeriesBans(): string[][] {
  return Array.from({ length: 10 }, () => []);
}
const championId = z
  .string()
  .max(40)
  .refine((id) => !!champion(id), "Không có asset tướng này");
const order = z
  .array(z.number().int().min(0).max(4))
  .length(5)
  .refine((v) => new Set(v).size === 5, "Vị trí phải khác nhau");
export const draftSchema = z
  .object({
    source: z.enum(["manual", "reference", "lcu"]),
    step: z.number().int().min(0).max(20),
    actions: z.array(championId.nullable()).length(20),
    hover: championId.nullable(),
    names: z.array(z.string().max(30)).length(10),
    coaches: z.array(z.string().max(40)).length(2),
    order: z.tuple([order, order]),
    duration: z.number().int().min(5).max(120),
    deadline: z.number().finite().nonnegative().nullable(),
    patch: z.string().max(20),
    // Series bans: champions already banned by the opponent in earlier games, per side and
    // position (index side * 5 + position, up to 4 games in a best of five).
    seriesBans: z.array(z.array(championId).max(4)).length(10).default(emptySeriesBans),
  })
  .refine(
    (d) =>
      d.actions.slice(0, d.step).filter(Boolean).length ===
      new Set(d.actions.slice(0, d.step).filter(Boolean)).size,
    "Một tướng không thể được cấm/chọn hai lần",
  );
export type DraftState = z.infer<typeof draftSchema>;
export function emptyDraft(): DraftState {
  return {
    source: "manual",
    step: 0,
    actions: Array(20).fill(null),
    hover: null,
    names: Array(10).fill(""),
    coaches: ["", ""],
    order: [
      [0, 1, 2, 3, 4],
      [0, 1, 2, 3, 4],
    ],
    duration: 30,
    deadline: null,
    patch: "",
    seriesBans: emptySeriesBans(),
  };
}
export function draftSlots(d: DraftState, side: number, kind: "pick" | "ban") {
  const slots: (string | null)[] = Array(5).fill(null);
  draftTurns.forEach(([s, k, slot], i) => {
    // Locked actions stay visible even when the source reports a later turn first.
    if (s === side && k === kind) slots[slot] = d.actions[i];
  });
  return kind === "pick" ? d.order[side].map((i) => slots[i]) : slots;
}
export function lockDraft(d: DraftState): DraftState {
  if (d.step >= 20 || !d.hover) return d;
  const actions = [...d.actions];
  actions[d.step] = d.hover;
  return draftSchema.parse({
    ...d,
    source: "manual",
    actions,
    step: d.step + 1,
    hover: null,
    deadline: null,
  });
}
export function undoDraft(d: DraftState): DraftState {
  if (!d.step) return d;
  const actions = [...d.actions];
  actions.fill(null, d.step - 1);
  return { ...d, step: d.step - 1, actions, hover: null, deadline: null };
}

// Swapping sides moves what belongs to a team: coaches, pick order and series bans. Picks, bans and
// player names come from the client by map side, so they stay where they are.
export function swapDraftSides(d: DraftState): DraftState {
  const half = <T>(v: T[]) => [...v.slice(5), ...v.slice(0, 5)];
  return {
    ...d,
    coaches: [d.coaches[1], d.coaches[0]],
    order: [d.order[1], d.order[0]],
    seriesBans: half(d.seriesBans),
  };
}
