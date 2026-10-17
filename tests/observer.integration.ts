import { get } from "node:http";
import assert from "node:assert/strict";
import { observerFrameSchema, recordingSchema } from "../shared/observer";
import { providerReportSchema } from "../shared/providers";
const base = process.env.OVERLAY_TEST_URL || "http://127.0.0.1:4310";
const started = Date.now();
const [a, b] = await Promise.all([fetch(`${base}/api/observer`), fetch(`${base}/api/observer`)]);
assert.equal(a.status, 200);
assert.equal(b.status, 200);
const first = observerFrameSchema.parse(await a.json()),
  second = observerFrameSchema.parse(await b.json());
assert.equal(first.sequence, second.sequence);
assert.equal(first.sessionId, second.sessionId);
assert.ok(Date.now() - started < 7000);
const recording = recordingSchema.parse(
  await (await fetch(`${base}/api/observer/recording`)).json(),
);
assert.ok(recording.frames.length > 0 && recording.frames.length <= 120);
const diagnostic = await (await fetch(`${base}/api/diagnostics`)).json();
assert.equal(diagnostic.probes.length, 6);
const providers = providerReportSchema.parse(await (await fetch(`${base}/api/providers`)).json());
assert.equal(providers.selected, "riot");
for (const path of [
  "/api/observer",
  "/api/observer/recording",
  "/api/diagnostics",
  "/api/providers",
  "/api/rehearsal",
]) {
  assert.equal((await fetch(base + path, { method: "POST" })).status, 405);
  assert.equal(
    (await fetch(base + path, { headers: { Origin: "https://example.com" } })).status,
    403,
  );
  assert.equal(
    await new Promise<number | undefined>((resolve, reject) => {
      get(base + path, { headers: { Host: "example.com" } }, (res) => {
        res.resume();
        resolve(res.statusCode);
      }).on("error", reject);
    }),
    403,
  );
}
assert.equal((await (await fetch(`${base}/api/health`)).json()).source, providers.output);
console.log(
  `PASS: observer HTTP, provider report, recording, six probes, origin/method guards; source status=${first.status}`,
);
