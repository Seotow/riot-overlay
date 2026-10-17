import test from "node:test";
import assert from "node:assert/strict";
import { inspectBasicFields } from "../collector/validation/basic-fields";
const now = Date.parse("2026-10-15T15:00:00Z");
function frame(count = 1): any {
  return {
    schemaVersion: 1,
    sequence: 1,
    type: "snapshot",
    source: "lblib",
    synthetic: false,
    recordedAt: null,
    timestamp: new Date(now).toISOString(),
    data: {
      gameTime: 30,
      heroes: Array.from({ length: count }, () => ({
        info: { team: 1, name: "PRIVATE_SENTINEL", networkId: 1000 },
        common: { identifier: "Ahri", health: 500, maxHealth: 1000 },
        resource: 100,
        maxResource: 800,
        resourceType: 0,
        gold: 0,
        totalGold: 1500,
      })),
    },
  };
}
test("basic native fields accept non-SR rosters without inventing ten players or exposing identities", () => {
  for (const count of [1, 4, 8, 10, 16]) {
    const result = inspectBasicFields(frame(count), now)!;
    assert.equal(result.rows.length, count);
    assert.equal(result.coverage.health, count);
    assert.equal(result.rows[0].champion, "Ahri");
    assert.equal(result.rows[0].currentGold, 0);
    assert.equal(result.rows[0].totalGold, 1500);
    assert.equal(result.rows[0].reportedResourceKind, "mana");
    assert.equal(result.valueSemanticsVerified, false);
    assert.ok(!JSON.stringify(result).includes("SENTINEL"));
    assert.ok(!JSON.stringify(result).includes("networkId"));
  }
});
test("missing/invalid HP/resource/gold remain null and unsupported resource kinds never default to mana", () => {
  const raw = frame();
  const h = raw.data.heroes[0];
  h.common.health = 2000;
  h.maxResource = 0;
  h.resourceType = 255;
  delete h.gold;
  h.totalGold = -1;
  const row = inspectBasicFields(raw, now)!.rows[0];
  assert.equal(row.health, null);
  assert.equal(row.resource, null);
  assert.equal(row.reportedResourceKind, null);
  assert.equal(row.currentGold, null);
  assert.equal(row.totalGold, null);
  for (const edit of [
    (e: any) => (e.synthetic = true),
    (e: any) => (e.recordedAt = e.timestamp),
    (e: any) => (e.data.heroes = []),
    (e: any) => (e.timestamp = new Date(now - 5000).toISOString()),
  ]) {
    const raw = frame();
    edit(raw);
    assert.equal(inspectBasicFields(raw, now), null);
  }
});
