import test from "node:test";
import assert from "node:assert/strict";
import { createElement } from "react";
import { renderToStaticMarkup } from "react-dom/server";
import { DraftOverlay } from "../src/overlay/DraftOverlay";
import { draftCatalog } from "../shared/draft-assets";
import { draftSchema, draftTurns, emptyDraft, swapDraftSides } from "../shared/draft";
import { mapChampSelect } from "../shared/draft-lcu";
import { createState } from "../shared/mock";
import { applyCommand } from "../shared/mock";

const key = (id: string) =>
  Number(draftCatalog.champions[id as keyof typeof draftCatalog.champions].key);
const ids = Object.keys(draftCatalog.champions);

// One LCU action per draft turn, in the table order, cells 0-4 blue and 5-9 red.
function session(done: number, hover?: string) {
  const bySide: number[] = [0, 0];
  const actions = draftTurns.map(([side, kind, slot], i) => {
    const cell = kind === "ban" ? side * 5 + (slot % 5) : side * 5 + [0, 1, 2, 3, 4][slot];
    bySide[side]++;
    return [
      {
        actorCellId: cell,
        type: kind,
        championId: i < done ? key(ids[i]) : i === done && hover ? key(hover) : 0,
        completed: i < done,
        isInProgress: i === done,
      },
    ];
  });
  return {
    actions,
    myTeam: [],
    theirTeam: [],
    timer: { adjustedTimeLeftInPhase: 25000, totalTimeInPhase: 30000, isInfinite: false },
  };
}

test("champ select maps bans, picks, active turn, hover and timer, keeping the team setup", () => {
  const current = { ...emptyDraft(), coaches: ["A", "B"], patch: "26.20" };
  const draft = mapChampSelect(session(8, ids[40]), current, 1_000_000)!;
  assert.equal(draft.source, "lcu");
  assert.equal(draft.step, 8);
  assert.equal(draft.hover, ids[40]);
  assert.equal(draft.actions[0], ids[0]);
  assert.equal(draft.actions[8], null);
  assert.equal(draft.deadline, 1_025_000);
  assert.equal(draft.duration, 30);
  assert.deepEqual(draft.coaches, ["A", "B"]);
  assert.equal(draft.patch, "26.20");
  // Names come from the client by cell, trimmed, and never from typed input.
  const named = mapChampSelect(
    {
      ...session(8),
      myTeam: [{ cellId: 0, gameName: " Faker " }],
      theirTeam: [
        { cellId: 7, summonerName: "Chovy" },
        { cellId: 8, gameName: "" },
      ],
    },
    { ...current, names: Array.from({ length: 10 }, (_, i) => `old${i}`) },
    0,
  )!;
  assert.equal(named.names[0], "Faker");
  assert.equal(named.names[7], "Chovy");
  assert.equal(named.names[8], ""); // a bot without a name is blank, not a leftover
  assert.equal(named.names[3], "");
  // Same deadline jitter does not restart the overlay timer.
  const again = mapChampSelect(session(8, ids[40]), draft, 1_000_300)!;
  assert.equal(again.deadline, draft.deadline);
  // Finished draft has no active turn or timer.
  const done = mapChampSelect(session(20), draft, 2_000_000)!;
  assert.equal(done.step, 20);
  assert.equal(done.hover, null);
  assert.equal(done.deadline, null);
});

test("champ select maps pick order to the player's position and ignores unusable payloads", () => {
  const raw = session(20);
  assert.equal(mapChampSelect(null, emptyDraft(), 0), null);
  assert.equal(mapChampSelect({ actions: [] }, emptyDraft(), 0), null);
  const draft = mapChampSelect(raw, emptyDraft(), 0)!;
  assert.ok(draftSchema.safeParse(draft).success);
  for (const side of [0, 1]) assert.equal(new Set(draft.order[side]).size, 5);
});

test("swap sides moves setup with the teams, via one command for both buttons", () => {
  const d = {
    ...emptyDraft(),
    coaches: ["Blue", "Red"],
    names: ["b1", "b2", "b3", "b4", "b5", "r1", "r2", "r3", "r4", "r5"],
    seriesBans: Array.from({ length: 10 }, (_, i) =>
      i === 0 ? ["Ahri"] : i === 5 ? ["Ashe"] : [],
    ),
  };
  const swapped = swapDraftSides(d);
  assert.deepEqual(swapped.coaches, ["Red", "Blue"]);
  assert.equal(swapped.names[0], "b1"); // names follow the client's map side, not the team
  assert.deepEqual(swapped.seriesBans[0], ["Ashe"]);
  assert.deepEqual(swapped.seriesBans[5], ["Ahri"]);
  const state = { ...createState(), draft: d };
  const next = applyCommand(state, { type: "swapSides" });
  assert.equal(next.theme.blueName, state.theme.redName);
  assert.deepEqual(next.draft?.coaches, ["Red", "Blue"]);
});

test("overlay hides the coach tag without a coach and shows series bans only when set", () => {
  const theme = createState().theme;
  const bare = renderToStaticMarkup(
    createElement(DraftOverlay, { theme, draft: emptyDraft(), now: 0 }),
  );
  assert.doesNotMatch(bare, /COACH/);
  assert.match(bare, /no-coach/);
  assert.doesNotMatch(bare, /SERIES BAN/);
  const draft = {
    ...emptyDraft(),
    coaches: ["Fury", ""],
    seriesBans: Array.from({ length: 10 }, (_, i) => (i === 0 ? ["Ahri", "Ashe"] : [])),
  };
  const html = renderToStaticMarkup(createElement(DraftOverlay, { theme, draft, now: 0 }));
  assert.match(html, /COACH: Fury/);
  assert.match(html, /SERIES BAN/);
  assert.equal((html.match(/COACH/g) ?? []).length, 1);
  assert.doesNotMatch(html, /PATCH/);
});

test("timer line is one linear animation from the deadline and the artwork is not remounted on lock", () => {
  const theme = createState().theme;
  const now = Date.now();
  const draft = { ...emptyDraft(), duration: 30, deadline: now + 12_000, step: 6, hover: "Ahri" };
  const html = renderToStaticMarkup(createElement(DraftOverlay, { theme, draft, now }));
  assert.match(html, /draft-timer-fill/);
  assert.match(html, /animation-duration:30000ms/);
  const delay = Number(/animation-delay:(-?\d+)ms/.exec(html)?.[1]);
  assert.ok(delay <= -17_000 && delay >= -18_100, `delay ${delay}`);
  const idle = renderToStaticMarkup(
    createElement(DraftOverlay, { theme, draft: { ...draft, deadline: null }, now }),
  );
  assert.doesNotMatch(idle, /draft-timer-fill/);
});

test("automatic scene: empty without data, draft in champ select, in-game when data flows, pins win", async () => {
  const { detectScene } = await import("../shared/scene");
  const base = createState();
  const now = Date.now();
  const frame = (age: number) =>
    ({ status: "observed", sample: { capturedAt: new Date(now - age).toISOString() } }) as never;
  assert.equal(detectScene(base, null, now), null);
  assert.equal(detectScene(base, frame(20_000), now), null); // stale data is no data
  const picking = {
    ...base,
    draftLcu: { status: "champ-select", phase: "BAN_PICK", updatedAt: now },
  } as never;
  assert.equal(detectScene(picking, null, now), "draft");
  assert.equal(detectScene(base, frame(1000), now), "ingame");
  assert.equal(detectScene({ ...base, scene: "draft" }, frame(1000), now), "draft");
  assert.equal(detectScene({ ...base, scene: "ingame" }, null, now), "ingame");
});

test("a timer snapshot that is not refreshed keeps one deadline instead of drifting later", () => {
  const T = 5_000_000;
  const snapshot = (stamp?: number) => ({
    ...session(8),
    timer: {
      adjustedTimeLeftInPhase: 25000,
      totalTimeInPhase: 30000,
      isInfinite: false,
      ...(stamp === undefined ? {} : { internalNowInEpochMs: stamp }),
    },
  });
  const first = mapChampSelect(snapshot(T), emptyDraft(), T + 150)!;
  assert.equal(first.deadline, T + 25000);
  // Same stale snapshot read 4 s later: the deadline does not move with the local clock.
  const later = mapChampSelect(snapshot(T), first, T + 4150)!;
  assert.equal(later.deadline, T + 25000);
  // A new phase snapshot moves it.
  const next = mapChampSelect(snapshot(T + 30_000), later, T + 30_100)!;
  assert.equal(next.deadline, T + 55_000);
  // A client clock far from this machine's is not trusted: fall back to local time.
  const far = mapChampSelect(snapshot(T + 3_600_000), emptyDraft(), T)!;
  assert.equal(far.deadline, T + 25000);
});
