import test from "node:test";
import assert from "node:assert/strict";
import { mkdtemp, mkdir, readFile, rm, writeFile } from "node:fs/promises";
import { tmpdir } from "node:os";
import { join, resolve } from "node:path";
import { spawnSync } from "node:child_process";

test("custom markers attach only to the active capture and analyze a ±10 second game-time window", async () => {
  const root = await mkdtemp(join(tmpdir(), "rift-capture-markers-"));
  const directory = "lb-2026-09-27T00-00-00-000Z";
  const capture = join(root, directory);
  const receivedAt = new Date().toISOString();
  try {
    await mkdir(capture);
    await writeFile(join(root, "active-lb.json"), JSON.stringify({ directory }));
    await writeFile(
      join(capture, "leaguebroadcast-ws.ndjson"),
      [
        { receivedAt, message: { type: "gameStatus", gameState: 2 } },
        ...[89.9, 100.25, 110].map((gameTime) => ({
          receivedAt,
          message: { type: "ingame-state-update", state: { gameTime } },
        })),
      ]
        .map((record) => JSON.stringify(record))
        .join("\n") + "\n",
    );

    const environment = { ...process.env, RIOT_CAPTURE_ROOT: root };
    const marked = spawnSync(
      process.execPath,
      [resolve("scripts/capture/mark-capture-event.mjs"), "6", "-", "01:40", "bắt đầu"],
      { cwd: resolve("."), env: environment, encoding: "utf8" },
    );
    assert.equal(marked.status, 0, marked.stderr);
    const marker = JSON.parse((await readFile(join(capture, "markers.ndjson"), "utf8")).trim());
    assert.equal(marker.sequence, 6);
    assert.equal(marker.gameTimeSeconds, 100);
    assert.equal(marker.windowSeconds, 10);
    assert.equal(marker.note, "bắt đầu");
    assert.equal(marker.captureWarning, undefined);

    const analyzed = spawnSync(
      process.execPath,
      [resolve("scripts/capture/analyze-capture-events.mjs"), directory],
      { cwd: resolve("."), env: environment, encoding: "utf8" },
    );
    assert.equal(analyzed.status, 0, analyzed.stderr);
    const report = JSON.parse(analyzed.stdout).report[0];
    assert.equal(report.frames, 2);
    assert.equal(report.closest.gameTime, 100.25);
    assert.equal(report.closest.deltaSeconds, 0.25);
    assert.equal(report.nearbyGameStatuses.length, 1);
    assert.equal(report.sourceHealthyAtMark, true);
  } finally {
    await rm(root, { recursive: true, force: true });
  }
});

test("marker command refuses to fall back to an old capture", async () => {
  const root = await mkdtemp(join(tmpdir(), "rift-capture-markers-"));
  try {
    await writeFile(
      join(root, "latest-lb.json"),
      JSON.stringify({ directory: "lb-2026-09-27T00-00-00-000Z" }),
    );
    const result = spawnSync(
      process.execPath,
      [resolve("scripts/capture/mark-capture-event.mjs"), "6", "-", "01:40"],
      {
        cwd: resolve("."),
        env: { ...process.env, RIOT_CAPTURE_ROOT: root },
        encoding: "utf8",
      },
    );
    assert.notEqual(result.status, 0);
    assert.match(result.stderr, /Không có capture LB đang chạy/);
  } finally {
    await rm(root, { recursive: true, force: true });
  }
});
