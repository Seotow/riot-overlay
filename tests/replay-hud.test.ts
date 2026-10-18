import test from "node:test";
import assert from "node:assert/strict";
import { defaultHud, hudSchema, renderHudFields } from "../shared/replay-hud";
import { ReplayHudService } from "../server/replay-hud";
import { createState } from "../shared/mock";
import { themeSchema } from "../shared/schema";

test("HUD defaults hide redundant groups and the game killfeed, retain minimap, announcements and parent groups", () => {
  assert.equal(defaultHud.interfaceKillCallouts, false);
  assert.equal(defaultHud.interfaceFrames, false);
  assert.equal(defaultHud.interfaceScore, false);
  assert.equal(defaultHud.interfaceScoreboard, false);
  assert.equal(defaultHud.interfaceTimeline, false);
  for (const key of [
    "interfaceAll",
    "interfaceReplay",
    "interfaceAnnounce",
    "interfaceMinimap",
  ] as const)
    assert.equal(defaultHud[key], true);
  for (const key of ["interfaceAll", "interfaceReplay", "interfaceAnnounce"])
    assert.equal(hudSchema.safeParse({ ...defaultHud, [key]: false }).success, false);
  // The killfeed flag is the one switch that may be on or off.
  assert.equal(hudSchema.safeParse({ ...defaultHud, interfaceKillCallouts: true }).success, true);
  for (const key of ["cameraPosition", "speed", "path", "vngWarning", "environment"])
    assert.equal(hudSchema.safeParse({ ...defaultHud, [key]: false }).success, false);
});
test("HUD status filters camera/private fields and never writes", async () => {
  const calls: string[] = [];
  const s = new ReplayHudService(async (method) => {
    calls.push(method);
    return { ...defaultHud, cameraPosition: { x: 1 }, token: "SECRET" };
  });
  const status = await s.status();
  assert.equal(status.connected, true);
  assert.deepEqual(calls, ["GET"]);
  assert.ok(!JSON.stringify(status).includes("SECRET"));
  assert.deepEqual(renderHudFields(null), {});
});
test("HUD apply validates before network, posts supported HUD keys only then verifies", async () => {
  const calls: { method: string; body?: Record<string, boolean> }[] = [];
  let current = { ...defaultHud, interfaceFrames: true } as Record<string, boolean>;
  delete current.interfaceQuests;
  const s = new ReplayHudService(async (method, body) => {
    calls.push({ method, body });
    if (body) current = { ...current, ...body };
    return current;
  });
  await assert.rejects(() => s.apply({ ...defaultHud, cameraMode: "fps" }));
  assert.equal(calls.length, 0);
  const result = await s.apply(defaultHud);
  assert.deepEqual(
    calls.map((c) => c.method),
    ["GET", "POST", "GET"],
  );
  assert.equal(calls[1].body?.interfaceFrames, false);
  assert.equal(Object.hasOwn(calls[1].body!, "interfaceQuests"), false);
  assert.deepEqual(result.unsupported, ["interfaceQuests"]);
  assert.equal(result.verified, true);
});
test("HUD missing announcement safeguards refuses any write; ignored writes are not success", async () => {
  const calls: string[] = [];
  const missing = new ReplayHudService(async (method) => {
    calls.push(method);
    return { interfaceFrames: true };
  });
  await assert.rejects(() => missing.apply(defaultHud), /thiếu cờ/);
  assert.deepEqual(calls, ["GET"]);
  const ignored = new ReplayHudService(async () => ({
    ...defaultHud,
    interfaceFrames: true,
  }));
  const result = await ignored.apply(defaultHud);
  assert.equal(result.verified, false);
  assert.deepEqual(result.mismatched, ["interfaceFrames"]);
  const offline = new ReplayHudService(async () => {
    throw Error("offline");
  });
  assert.equal((await offline.status()).connected, false);
});
test("HUD profile and feed style persist in version1 without changing old themes", () => {
  const old = createState().theme;
  assert.deepEqual(themeSchema.parse(old), old);
  const t = themeSchema.parse({
    ...old,
    replayHud: defaultHud,
    killfeedStyle: "broadcast",
  });
  assert.deepEqual(themeSchema.parse(JSON.parse(JSON.stringify(t))), t);
  assert.equal(themeSchema.safeParse({ ...t, killfeedStyle: "unknown" }).success, false);
});
