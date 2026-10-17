import assert from "node:assert/strict";
import { spawn } from "node:child_process";
import { createServer as createPortProbe } from "node:net";
import { mkdtemp, readFile, rm } from "node:fs/promises";
import { existsSync } from "node:fs";
import { tmpdir } from "node:os";
import { join } from "node:path";
import { WebSocket } from "ws";
import { defaultTheme, themeSchema } from "../shared/schema";
import { defaultHud } from "../shared/replay-hud";
import { observerFrameSchema } from "../shared/observer";
import { emptyDraft } from "../shared/draft";
import { samplePostgame } from "../shared/postgame";

const base = "http://127.0.0.1:4311";
// Refuse an occupied port before starting or mutating any unrelated backend.
await new Promise<void>((resolve, reject) => {
  const probe = createPortProbe();
  probe.once("error", () =>
    reject(Error("Test port 4311 is occupied; no backend commands were sent.")),
  );
  probe.listen(4311, "127.0.0.1", () =>
    probe.close((error) => (error ? reject(error) : resolve())),
  );
});
const directory = await mkdtemp(join(tmpdir(), "riot-overlay-test-"));
const themePath = join(directory, "theme.json");
const server = spawn(
  process.execPath,
  [
    "--import",
    "tsx",
    "--import",
    "./tests/fixtures/riot-api-preload.ts",
    "server/index.ts",
    "--production",
  ],
  {
    env: {
      ...process.env,
      PORT: "4311",
      RIOT_OVERLAY_THEME_PATH: themePath,
      RIOT_OVERLAY_PROVIDER: "riot",
      RIOT_OVERLAY_POSTGAME: "1",
    },
    stdio: ["ignore", "pipe", "pipe"],
  },
);
let logs = "";
server.stdout.on("data", (b) => (logs += b));
server.stderr.on("data", (b) => (logs += b));
let ws: WebSocket | undefined;
const wait = (ms: number) => new Promise((r) => setTimeout(r, ms));
try {
  let ready = false;
  for (let i = 0; i < 80; i++) {
    if (server.exitCode !== null) throw Error(logs);
    try {
      ready = (await fetch(base + "/api/health")).ok;
    } catch {}
    if (ready) break;
    await wait(100);
  }
  assert.ok(
    ready,
    `isolated backend startup failed: ${logs || "no startup output (check sandbox/network permissions)"}`,
  );
  for (const [path, mime] of [
    ["/broadcast/artwork/riot-dragons/water.webp", "image/webp"],
    ["/fonts/riot/Spiegel-Regular.otf", "font/otf"],
    ["/fonts/broadcast/Anton-Regular.ttf", "font/ttf"],
  ]) {
    const response = await fetch(base + path);
    assert.equal(response.status, 200, path);
    assert.equal(response.headers.get("content-type"), mime, path);
    assert.ok((await response.arrayBuffer()).byteLength > 1000);
  }
  assert.equal((await fetch(base + "/%2e%2e%2fpackage.json")).status, 404);
  await new Promise<void>((resolve, reject) => {
    const rejected = new WebSocket(base.replace("http", "ws") + "/ws", {
      origin: base,
      headers: { Host: "example.com" },
    });
    rejected.once("open", () => {
      rejected.terminate();
      reject(Error("WebSocket accepted foreign Host"));
    });
    rejected.once("error", () => resolve());
  });
  process.env.OVERLAY_TEST_URL = base;
  await import("./observer.integration");
  await import("./transport.integration");
  ws = new WebSocket(base.replace("http", "ws") + "/ws?role=studio", {
    origin: base,
  });
  const messages: any[] = [];
  ws.on("message", (raw) => messages.push(JSON.parse(raw.toString())));
  const until = async (predicate: (message: any) => boolean, timeout = 15000) => {
    const start = Date.now();
    while (Date.now() - start < timeout) {
      const index = messages.findIndex(predicate);
      if (index >= 0) return messages.splice(index, 1)[0];
      await wait(20);
    }
    throw Error("Timed out waiting for backend result");
  };
  await until((m) => m.type === "snapshot");
  const command = async (value: any) => {
    messages.length = 0;
    ws!.send(JSON.stringify(value));
    return until((m) => m.type === "snapshot" || m.type === "error");
  };
  const riotPost = (route: string, value: unknown, origin = base) =>
    fetch(`${base}/api/riot-postgame/${route}`, {
      method: "POST",
      headers: { Origin: origin, "Content-Type": "application/json" },
      body: JSON.stringify(value),
    });
  assert.equal((await (await fetch(base + "/api/riot-postgame/status")).json()).configured, false);
  assert.equal(
    (
      await riotPost(
        "credential",
        { mode: "standard", secret: "SYNTHETIC-NOT-A-REAL-KEY" },
        "https://evil.test",
      )
    ).status,
    403,
  );
  const credentialStatus = await (
    await riotPost("credential", { mode: "standard", secret: "SYNTHETIC-NOT-A-REAL-KEY" })
  ).text();
  assert.doesNotMatch(credentialStatus, /SYNTHETIC|secret/);
  assert.equal(JSON.parse(credentialStatus).configured, true);
  assert.equal(
    (await riotPost("load", { matchId: "https://evil.test", gameNumber: 1 })).status,
    400,
  );
  assert.equal((await riotPost("publish", { matchId: "VN2_123456" })).status, 409);
  const candidateResponse = await riotPost("load", { matchId: "VN2_123456", gameNumber: 1 });
  assert.equal(candidateResponse.status, 200);
  const candidate = (await candidateResponse.json()).candidate;
  assert.equal(candidate.teams[0].players[0].damage, 1000);
  assert.doesNotMatch(JSON.stringify(candidate), /SYNTHETIC|puuid|riotId|secret/);
  messages.length = 0;
  assert.equal((await riotPost("publish", { matchId: "VN2_123456" })).status, 200);
  const publishedRiot = (await until((m) => m.type === "snapshot")).state;
  assert.deepEqual(publishedRiot.postgame, candidate);
  assert.equal(publishedRiot.scene, "postgame");
  assert.equal(publishedRiot.mockVisible, false);
  assert.equal(
    (await command({ type: "postgameState", value: candidate })).type,
    "error",
    "Observed provenance cannot be imported over WS",
  );
  assert.equal((await riotPost("credential", { clear: true })).status, 200);
  assert.equal((await riotPost("load", { matchId: "VN2_123456", gameNumber: 1 })).status, 409);
  assert.equal((await fetch(base + "/api/riot-postgame/credential")).status, 405);
  const draft = { ...emptyDraft(), hover: "Annie" };
  const sample = samplePostgame();
  const pgResult = await command({ type: "postgameState", value: sample });
  assert.deepEqual(pgResult.state.postgame, sample);
  assert.equal(
    (await command({ type: "postgameState", value: { ...sample, source: "live" } })).type,
    "error",
  );
  assert.equal((await command({ type: "postgameState", value: null })).state.postgame, null);
  assert.deepEqual((await command({ type: "draftState", value: draft })).state.draft, draft);
  assert.equal(
    (
      await command({
        type: "draftState",
        value: { ...draft, hover: "NotAChampion" },
      })
    ).type,
    "error",
  );
  for (const view of ["gold", "levels", "runes", "minimal", "normal"]) {
    const result = await command({
      type: "broadcast",
      value: { view, inhibitors: "off" },
    });
    assert.equal(result.state.broadcast.view, view);
    assert.equal(result.state.rehearsal, undefined);
  }
  for (const value of ["auto", "ingame", "draft", "postgame"])
    assert.equal((await command({ type: "scene", value })).state.scene, value);
  await command({ type: "mockVisible", value: true });
  for (const value of ["kill", "level", "objective", "draft"])
    assert.equal((await command({ type: "event", value })).type, "snapshot");
  for (const value of ["balanced", "advantage", "missing"])
    assert.equal((await command({ type: "scenario", value })).type, "snapshot");
  for (const value of [true, false])
    assert.equal((await command({ type: "playing", value })).state.playing, value);
  assert.equal((await command({ type: "seek", value: 600 })).state.gameTime, 600);
  for (const invalid of [
    { type: "seek", value: -1 },
    { type: "provider", value: "bad" },
    { type: "captureLoad", id: "../secret" },
    { type: "theme", value: { ...defaultTheme, blue: "url(x)" } },
    { type: "captureControl", speed: 9 },
  ])
    assert.equal((await command(invalid)).type, "error");
  const theme = themeSchema.parse({
    ...defaultTheme,
    killfeedStyle: "broadcast",
    replayHud: defaultHud,
    blueName: "TEST BLUE",
    blueScore: 2,
    redScore: 1,
    seriesGames: 3,
    blueLogo: "data:image/png;base64," + "A".repeat(100000),
    variant: "minimal",
  });
  assert.deepEqual(
    (await command({ type: "theme", value: JSON.parse(JSON.stringify(theme)) })).state.theme,
    theme,
  );
  let saved = false;
  for (let i = 0; i < 50; i++) {
    try {
      saved = JSON.parse(await readFile(themePath, "utf8")).blueName === "TEST BLUE";
    } catch {}
    if (saved) break;
    await wait(20);
  }
  assert.ok(saved, "theme persistence in isolated path");
  assert.equal(
    (
      await fetch(base + "/api/replay-hud/apply", {
        method: "POST",
        headers: { Origin: "https://other.invalid", "Content-Type": "application/json" },
        body: JSON.stringify(defaultHud),
      })
    ).status,
    403,
  );
  assert.equal(
    (
      await fetch(base + "/api/replay-hud/apply", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify(defaultHud),
      })
    ).status,
    403,
  );
  assert.equal(
    (
      await fetch(base + "/api/replay-hud/apply", {
        method: "POST",
        headers: { Origin: base, "Content-Type": "application/json" },
        body: JSON.stringify({ ...defaultHud, cameraMode: "fps" }),
      })
    ).status,
    400,
  );
  assert.equal((await fetch(base + "/api/replay-hud/apply", { method: "GET" })).status, 405);
  assert.equal((await command({ type: "reset" })).state.theme.blueName, "TEST BLUE");
  assert.equal(
    (await command({ type: "provider", value: "recording" })).state.provider,
    "recording",
  );
  assert.equal(
    (await command({ type: "captureControl", playing: true })).type,
    "error",
    "cannot play before load",
  );
  const id = "lb-2026-10-11T09-07-37-947Z";
  if (existsSync(`data/captures/${id}/leaguebroadcast-ws.ndjson`)) {
    assert.equal((await command({ type: "captureLoad", id })).state.provider, "recording");
    const first = observerFrameSchema.parse(
      (await until((m) => m.type === "observer" && m.frame?.playback?.captureId === id)).frame,
    );
    assert.equal(first.sample?.players.length, 10);
    assert.equal(first.newEvents.length, 0);
    const caps = await (await fetch(base + "/api/rehearsal")).json();
    for (const button of caps.buttons) {
      const result = await command({ type: "rehearsal", value: button.kind });
      assert.equal(result.type, button.available ? "snapshot" : "error", button.kind);
      if (button.available) {
        assert.equal(
          result.state.rehearsal?.kind,
          button.kind === "clear" ? undefined : button.kind,
        );
        const observed = observerFrameSchema.parse(
          await (await fetch(base + "/api/observer")).json(),
        );
        assert.equal(observed.sample?.players.length, 10);
      }
    }
    for (const [value, variant] of [
      ["timers", { pit: "GRUB", dragon: "elder" }],
      ["timers", { pit: "HERALD", dragon: "hextech" }],
      ["dragon", { dragon: "elder" }],
      ["soul", { dragon: "chemtech" }],
      ["baron", { buffs: "baron" }],
      ["baron", { buffs: "elder" }],
      ["baron", { buffs: "both" }],
      ["inhibitor", { inhibitorTeam: "ORDER" }],
      ["inhibitor", { inhibitorTeam: "CHAOS" }],
      ["tower", { tower: "first" }],
      ["tower", { tower: "normal" }],
    ] as const) {
      const baseline = await command({ type: "rehearsal", value });
      assert.equal(baseline.type, "snapshot");
      const before = await (await fetch(base + "/api/observer")).json();
      const result = await command({ type: "rehearsal", value, variant });
      assert.equal(result.type, "snapshot");
      assert.deepEqual(result.state.rehearsal.variant, variant);
      const after = observerFrameSchema.parse(await (await fetch(base + "/api/observer")).json());
      assert.deepEqual(
        after.sample?.pitTimers?.map((t) => t.type.value),
        before.sample?.pitTimers?.map((t: any) => t.type.value),
      );
      assert.deepEqual(after.sample?.inhibitors?.value, before.sample?.inhibitors?.value);
      assert.deepEqual(
        after.sample?.players.map((p) => [p.hasBaron?.value, p.hasElder?.value]),
        before.sample?.players.map((p: any) => [p.hasBaron?.value, p.hasElder?.value]),
      );
    }
    assert.equal(
      (
        await command({
          type: "rehearsal",
          value: "soul",
          variant: { dragon: "elder" },
        })
      ).type,
      "error",
    );
    assert.equal(
      (
        await command({
          type: "rehearsal",
          value: "soul",
          variant: { buffs: "both" },
        })
      ).type,
      "error",
    );
    await command({
      type: "captureControl",
      positionMs: 400000,
      playing: false,
    });
    const paused = await (await fetch(base + "/api/observer")).json();
    await wait(250);
    assert.equal(
      (await (await fetch(base + "/api/observer")).json()).sample.gameTime.value,
      paused.sample.gameTime.value,
    );
    await command({ type: "captureControl", speed: 4, playing: true });
    await wait(300);
    assert.ok(
      (await (await fetch(base + "/api/observer")).json()).sample.gameTime.value >
        paused.sample.gameTime.value,
    );
    await command({ type: "captureControl", positionMs: 0, playing: false });
    assert.equal((await (await fetch(base + "/api/observer")).json()).newEvents.length, 0);
  } else console.log("SKIP: local real capture not present");
  await command({ type: "provider", value: "riot" });
  await command({ type: "mockVisible", value: false });
  console.log(
    "PASS: isolated scenes, demo controls, validation, theme persistence, providers, full capture load/pause/speed/seek",
  );
} finally {
  ws?.terminate();
  server.kill();
  if (server.exitCode === null)
    await new Promise<void>((resolve) => server.once("exit", () => resolve()));
  await rm(directory, { recursive: true, force: true });
}
