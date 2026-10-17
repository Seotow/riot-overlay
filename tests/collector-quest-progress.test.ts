import test from "node:test";
import assert from "node:assert/strict";
import { collectorPlayerExtras } from "../collector/adapter/player-extras";
const make = (role: string, id: number, count: number): any => ({
  common: {
    buffs: [{ name: `SR_2026_S1_RoleBound_${role}_Quest`, count, endTime: 25000 }],
  },
  items: [{ slot: 8, id, stats: {} }],
});
test("native exact role-buff points drive top/mid/bot/support progress despite empty item stats", () => {
  for (const [role, id, points] of [
    ["Top", 1200, 600],
    ["Mid", 1201, 675],
    ["Bot", 1202, 675],
    ["Support", 1203, 400],
  ] as const) {
    const h = make(role, id, points);
    assert.equal(collectorPlayerExtras(h, 100).roleQuest?.progress, 0.5);
    h.common.buffs[0].count = 0;
    assert.equal(collectorPlayerExtras(h, 100).roleQuest?.progress, 0);
    h.common.buffs = [];
    assert.equal(collectorPlayerExtras(h, 100).roleQuest?.progress, null);
  }
});
test("control ward in role slot never completes support; exact quest completion does", () => {
  const h = make("Support", 2055, 153);
  let q = collectorPlayerExtras(h, 350).roleQuest!;
  assert.equal(q.role, "support");
  assert.equal(q.completed, false);
  assert.equal(q.progress, 153 / 800);
  h.common.buffs[0].name += "Completed";
  q = collectorPlayerExtras(h, 350).roleQuest!;
  assert.equal(q.completed, true);
  assert.equal(q.progress, 1);
  h.common.buffs = [];
  assert.equal(collectorPlayerExtras(h, 350).roleQuest?.completed, false);
});
test("jungle progress uses remaining pet treats, not the always-zero role-buff count", () => {
  const h = make("Jungle", 1204, 0);
  h.items.push({ slot: 0, id: 1101, charges: 28 });
  assert.equal(collectorPlayerExtras(h, 100).roleQuest?.progress, 0.2);
  h.common.buffs.push({ name: "itemsmitecounter", count: 14, endTime: 25000 });
  assert.equal(collectorPlayerExtras(h, 100).roleQuest?.progress, 0.6);
  h.common.buffs[1].count = 36;
  assert.equal(collectorPlayerExtras(h, 100).roleQuest?.progress, null);
});
