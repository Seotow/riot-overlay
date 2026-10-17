import test from "node:test";
import assert from "node:assert/strict";
import {
  CollectorSafetyGate,
  decideCollectorSafety,
} from "../server/collector-safety";
import { CollectorRuntime } from "../Collector/runtime/supervisor";
import { EventEmitter } from "node:events";

test("player identity blocks collection even if replay API or mode claims spectator", () => {
  for (const name of ["Seotoww#2013", "Seotoww", "Yasuo", "Bot Ashe"])
    for (const mode of ["spectator", "replay", null])
      assert.deepEqual(decideCollectorSafety(name, mode), {
        allowed: false,
        reason: "player",
      });
});
test("missing evidence and unknown active name alone fail closed", () => {
  for (const active of [null, undefined, {}, "", " ", "unknown", "spectator"])
    assert.equal(decideCollectorSafety(active, null).allowed, false);
  assert.equal(decideCollectorSafety(null, "replay").allowed, false);
  assert.equal(decideCollectorSafety("unknown", "replay").allowed, true);
  assert.equal(decideCollectorSafety("Spectator", "spectator").allowed, true);
});
test("safety single flight, expiry, transition to player and probe failure", async () => {
  let time = 1000,
    calls = 0,
    player = false;
  const gate = new CollectorSafetyGate(
    async () => {
      calls++;
      return decideCollectorSafety(player ? "Seotoww" : "unknown", "replay");
    },
    () => time,
  );
  await Promise.all([gate.check(), gate.check()]);
  assert.equal(calls, 1);
  player = true;
  time += 501;
  assert.equal((await gate.check()).reason, "player");
  const failed = new CollectorSafetyGate(async () => {
    throw Error("secret-not-exported");
  });
  assert.deepEqual(await failed.check(), {
    allowed: false,
    reason: "unverified",
  });
});
test("runtime blocks owned and external collectors before startup and can resume after safe mode", async () => {
  for (const external of [false, true]) {
    let player = true;
    const runtime = new CollectorRuntime({
      external,
      safety: async () =>
        decideCollectorSafety(player ? "Seotoww" : "unknown", "replay"),
    });
    await runtime.setEnabled(true);
    assert.equal(runtime.snapshot().owned, false);
    assert.equal(runtime.snapshot().error, "collector-blocked-player");
    player = false;
    if (external) {
      await runtime.setEnabled(true);
      assert.equal(runtime.snapshot().status, "external");
      player = true;
      await runtime.setEnabled(true);
      assert.equal(runtime.snapshot().status, "stopped");
    }
    await runtime.stop();
  }
});

test("owned host watchdog kills its child when safety changes, without launching native code", async () => {
  const runtime = new CollectorRuntime({
    safety: async () => ({ allowed: false, reason: "player" }),
  });
  const child = new EventEmitter() as EventEmitter & {
    exitCode: number | null;
    kill: () => boolean;
  };
  let killed = 0;
  child.exitCode = null;
  child.kill = () => {
    killed++;
    child.exitCode = 0;
    child.emit("exit", 0);
    return true;
  };
  const internal = runtime as unknown as {
    child: typeof child;
    desired: boolean;
    monitorSafety: () => void;
  };
  internal.child = child;
  internal.desired = true;
  internal.monitorSafety();
  await new Promise((resolve) => setTimeout(resolve, 650));
  assert.equal(killed, 1);
  assert.equal(runtime.snapshot().owned, false);
  assert.equal(runtime.snapshot().error, "collector-blocked-player");
  await runtime.stop();
});
