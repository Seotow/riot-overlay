import test from "node:test";
import assert from "node:assert/strict";
import { mkdtemp, rm } from "node:fs/promises";
import { join } from "node:path";
import { tmpdir } from "node:os";
import { CollectorRuntime } from "../Collector/runtime/supervisor";
test("accountless mode rejects an external host whose authentication cannot be isolated", async () => {
  const runtime = new CollectorRuntime({
    external: true,
    withoutAccount: true,
  });
  await runtime.setEnabled(true);
  assert.equal(runtime.snapshot().status, "failed");
  assert.equal(runtime.snapshot().error, "accountless-external-not-supported");
  assert.equal(runtime.snapshot().owned, false);
  assert.equal(runtime.snapshot().credentialConfigured, false);
  assert.equal(runtime.snapshot().withoutAccount, true);
  await runtime.stop();
});
test("external collector is never owned or stopped by the project", async () => {
  const runtime = new CollectorRuntime({ external: true });
  await runtime.setEnabled(true);
  assert.equal(runtime.snapshot().status, "external");
  assert.equal(runtime.snapshot().owned, false);
  await runtime.stop();
  assert.equal(runtime.snapshot().status, "stopped");
  await runtime.setEnabled(true);
  assert.equal(runtime.snapshot().status, "external");
  await runtime.stop();
});
test("missing collector build fails closed without child, retries only after explicit disable", async () => {
  const root = await mkdtemp(join(tmpdir(), "collector-missing-"));
  try {
    const runtime = new CollectorRuntime({ root });
    await runtime.setEnabled(true);
    assert.equal(runtime.snapshot().status, "failed");
    assert.equal(runtime.snapshot().owned, false);
    assert.ok(
      ["windows-required", "build-missing"].includes(runtime.snapshot().error!),
    );
    await runtime.setEnabled(true);
    assert.equal(runtime.snapshot().status, "failed");
    await runtime.stop();
    assert.equal(runtime.snapshot().status, "stopped");
  } finally {
    await rm(root, { recursive: true, force: true });
  }
});
