import assert from "node:assert/strict";
import { spawn } from "node:child_process";
import { once } from "node:events";
import { createServer } from "node:net";
import { mkdtemp, rm } from "node:fs/promises";
import { tmpdir } from "node:os";
import { join } from "node:path";
import { WebSocket, WebSocketServer } from "ws";
import { providerReportSchema } from "../shared/providers";
import { observerFrameSchema } from "../shared/observer";
import { createRequire } from "node:module";
import { mkdir } from "node:fs/promises";
import { resolve } from "node:path";

const feed = new WebSocketServer({ host: "127.0.0.1", port: 0 });
await once(feed, "listening");
const address = feed.address();
assert.ok(address && typeof address === "object");
let sequence = 0;
let liveEventAt: number | null = null;
const fixture = () => ({
  schemaVersion: 1,
  sequence: ++sequence,
  timestamp: new Date().toISOString(),
  type: "snapshot",
  source: "lblib",
  synthetic: false,
  recordedAt: null,
  token: "NO_LEAK_SENTINEL",
  data: {
    gameTime: 100 + sequence / 10,
    gameId: "PRIVATE_SENTINEL",
    playbackSpeed: 1,
    gameEvents: {
      heroDieEvents:
        liveEventAt === null
          ? []
          : [
              {
                gameTime: liveEventAt,
                killerNetworkId: 1000,
                victimNetworkId: 1005,
              },
            ],
    },
    heroes: Array.from({ length: 10 }, (_, i) => ({
      heroIndex: i,
      info: { team: i < 5 ? 1 : 2, name: "PRIVATE_NAME", networkId: 1000 + i },
      common: {
        identifier: i % 2 ? "Garen" : "Ahri",
        level: 10,
        health: 500,
        maxHealth: 1000,
      },
      gold: 100,
      totalGold: 5000,
      resource: 50,
      maxResource: 100,
      kills: 2,
      deaths: 1,
      assists: 3,
      items: [{ slot: 0, id: 3157, count: 1 }],
      spells: [
        { index: 3, readyAt: 150, maxCooldown: 60 },
        { index: 6, readyAt: 200, maxCooldown: 120 },
      ],
      perks: [8005, 8009, 9104, 8014, 8226, 8237, 5008, 5008, 5001].map(
        (id) => ({ id, value: "PRIVATE_PERK_SENTINEL" }),
      ),
    })),
  },
});
feed.on("connection", (socket) => socket.send(JSON.stringify(fixture())));
const ticker = setInterval(() => {
  const json = JSON.stringify(fixture());
  for (const client of feed.clients)
    if (client.readyState === WebSocket.OPEN) client.send(json);
}, 100);
const probe = createServer();
probe.listen(0, "127.0.0.1");
await once(probe, "listening");
const bound = probe.address();
assert.ok(bound && typeof bound === "object");
const port = bound.port;
await new Promise<void>((yes) => probe.close(() => yes()));
const directory = await mkdtemp(join(tmpdir(), "collector-project-"));
const backend = spawn(
  process.execPath,
  [
    "--import",
    "tsx",
    "--import",
    "./tests/fixtures/spectator-safety-preload.ts",
    "server/index.ts",
    "--production",
    "--collector",
  ],
  {
    cwd: process.cwd(),
    windowsHide: true,
    stdio: ["ignore", "pipe", "pipe", "ipc"],
    env: {
      ...process.env,
      PORT: String(port),
      RIOT_OVERLAY_THEME_PATH: join(directory, "theme.json"),
      RIOT_OVERLAY_COLLECTOR_PORT: String(address.port),
      RIOT_OVERLAY_COLLECTOR_EXTERNAL: "1",
    },
  },
);
const url = `http://127.0.0.1:${port}`;
let logs = "",
  studio: WebSocket | undefined,
  obs: WebSocket | undefined;
backend.stdout!.on("data", (b) => (logs += b));
backend.stderr!.on("data", (b) => (logs += b));
const wait = (ms: number) => new Promise((r) => setTimeout(r, ms));
async function until(check: () => Promise<boolean>, budget = 10000) {
  const caller = new Error().stack;
  for (let i = 0; i < budget / 100; i++) {
    if (await check()) return;
    await wait(100);
  }
  throw Error(`Integration timeout: ${caller}`);
}
try {
  await until(async () => {
    try {
      return (await fetch(url + "/api/health")).ok;
    } catch {
      return false;
    }
  });
  const connect = async (role: string) => {
    const socket = new WebSocket(
      url.replace("http", "ws") + `/ws?role=${role}`,
      { origin: url },
    );
    await once(socket, "open");
    return socket;
  };
  studio = await connect("studio");
  obs = await connect("overlay");
  const studioFrames: any[] = [];
  const obsFrames: any[] = [];
  const collectorArrivalMs: number[] = [];
  studio.on("message", (b) => {
    const m = JSON.parse(b.toString());
    if (m.type === "observer") {
      studioFrames.push(m.frame);
      if (m.frame?.status === "observed") collectorArrivalMs.push(Date.now());
    }
  });
  obs.on("message", (b) => {
    const m = JSON.parse(b.toString());
    if (m.type === "observer") obsFrames.push(m.frame);
  });
  await until(
    async () =>
      studioFrames.some((f) => f?.status === "observed") &&
      obsFrames.some((f) => f?.status === "observed"),
  );
  const frame = studioFrames.find((f) => f?.status === "observed");
  observerFrameSchema.parse(frame);
  assert.equal(frame.sample.players.length, 10);
  assert.equal(frame.sample.players[0].totalGold.source, "league-collector");
  assert.equal(frame.sample.players[0].keystone.value, 8005);
  assert.equal(frame.sample.players[0].perks.value.length, 9);
  assert.deepEqual(
    frame.sample.players[0].cooldowns.value.find((c: any) => c.kind === "item"),
    { kind: "item", slot: "0", id: 3157, readyAt: 200, total: 120 },
  );
  assert.ok(obsFrames.some((f) => f?.sessionId === frame.sessionId));
  await until(async () => collectorArrivalMs.length >= 5);
  const cadence = (collectorArrivalMs[4] - collectorArrivalMs[0]) / 4;
  assert.ok(
    cadence >= 350 && cadence < 650,
    `Expected collector ~500ms broadcast, measured ${cadence}ms`,
  );
  // The event-bearing native frame can pass between backend polls. Both
  // clients still receive it once; HTTP diagnostics never drain this queue.
  liveEventAt = 100 + sequence / 10;
  for (let i = 0; i < 5; i++) {
    await fetch(url + "/api/observer");
    await wait(100);
  }
  await until(
    async () =>
      studioFrames.some((f) =>
        f.newEvents?.some((e: any) => e.kind === "ChampionKill"),
      ) &&
      obsFrames.some((f) =>
        f.newEvents?.some((e: any) => e.kind === "ChampionKill"),
      ),
  );
  const studioEvent = studioFrames.find((f) =>
    f.newEvents?.some((e: any) => e.kind === "ChampionKill"),
  );
  const obsEvent = obsFrames.find((f) =>
    f.newEvents?.some((e: any) => e.kind === "ChampionKill"),
  );
  assert.deepEqual(studioEvent.newEvents, obsEvent.newEvents);
  await wait(1000);
  assert.equal(
    studioFrames.filter((f) =>
      f.newEvents?.some((e: any) => e.kind === "ChampionKill"),
    ).length,
    1,
  );
  assert.equal(
    obsFrames.filter((f) =>
      f.newEvents?.some((e: any) => e.kind === "ChampionKill"),
    ).length,
    1,
  );
  const report = providerReportSchema.parse(
    await (await fetch(url + "/api/providers")).json(),
  );
  assert.equal(report.selected, "league-collector");
  assert.equal(report.collector?.runtime.status, "external");
  assert.equal(report.collector?.runtime.owned, false);
  assert.equal(report.collector?.players, 10);
  assert.equal(report.leaguebroadcast.status, "offline");
  const recording = await (await fetch(url + "/api/observer/recording")).text();
  assert.ok(!recording.includes("SENTINEL"));
  assert.ok(recording.includes('"playerName"'));
  assert.ok(!recording.includes('"networkId"'));
  studio.send(JSON.stringify({ type: "provider", value: "riot" }));
  await until(async () => {
    const r = await (await fetch(url + "/api/providers")).json();
    return (
      r.selected === "riot" &&
      r.collector.runtime.status === "stopped" &&
      r.collector.players === 0
    );
  });
  studio.send(JSON.stringify({ type: "provider", value: "league-collector" }));
  await until(async () => {
    const r = await (await fetch(url + "/api/providers")).json();
    return r.collector.players === 10;
  });
  assert.ok(feed.clients.size > 0); // selecting source again reconnects, no permanent stop
  for (const reason of ["player", "unverified"]) {
    backend.send(reason === "player" ? "test-player" : "test-unknown");
    await until(async () => {
      const r = await (await fetch(url + "/api/providers")).json();
      return (
        r.safety.reason === reason &&
        r.collector.players === 0 &&
        r.collector.runtime.status === "stopped" &&
        feed.clients.size === 0
      );
    });
    assert.equal(await (await fetch(url + "/api/observer")).json(), null);
    await until(
      async () => studioFrames.at(-1) === null && obsFrames.at(-1) === null,
    );
    backend.send("test-spectator");
    await until(
      async () =>
        (await (await fetch(url + "/api/providers")).json()).collector
          .players === 10,
    );
  }
  studio.send(
    JSON.stringify({ type: "provider", value: "collector-accountless" }),
  );
  await until(async () => {
    const r = providerReportSchema.parse(
      await (await fetch(url + "/api/providers")).json(),
    );
    return (
      r.selected === "collector-accountless" &&
      r.output === "collector-accountless" &&
      r.collector?.runtime.error === "accountless-external-not-supported" &&
      r.collector.acceptedFrames === 0 &&
      r.collector.players === 0
    );
  });
  await wait(1000);
  const accountlessObservation = await (
    await fetch(url + "/api/observer")
  ).json();
  assert.equal(
    accountlessObservation.sample,
    null,
    "must not reuse authenticated/external frames",
  );
  studio.send(JSON.stringify({ type: "provider", value: "league-collector" }));
  await until(
    async () =>
      (await (await fetch(url + "/api/providers")).json()).collector.players ===
      10,
  );
  if (process.env.COLLECTOR_BROWSER_QA === "1") {
    const packages = process.env.OVERLAY_BROWSER_PACKAGES;
    assert.ok(packages);
    const require = createRequire(import.meta.url);
    const { chromium } = require(resolve(packages, "playwright"));
    const sharp = require(resolve(packages, "sharp"));
    const browser = await chromium.launch({
      channel: "msedge",
      headless: true,
    });
    const out = resolve(".npm-cache/collector-project-qa");
    await mkdir(out, { recursive: true });
    try {
      const page = await browser.newPage({
        viewport: { width: 1920, height: 1080 },
      });
      const errors: string[] = [];
      page.on("pageerror", (e: Error) => errors.push(e.message));
      await page.goto(url + "/?page=sources");
      await page.getByLabel("Nguồn trận đấu").waitFor();
      assert.equal(
        await page.getByLabel("Nguồn trận đấu").inputValue(),
        "league-collector",
      );
      await page.waitForFunction(() =>
        document.body.innerText.includes("10/10 người"),
      );
      await page.evaluate(() => document.fonts.ready);
      await page.screenshot({
        path: join(out, "sources-1920.png"),
        fullPage: true,
      });
      await page.getByLabel("Nguồn trận đấu").selectOption("riot");
      await page
        .getByLabel("Nguồn trận đấu")
        .selectOption("collector-accountless");
      await page
        .getByText("DLL cache · Không dùng tài khoản LB", { exact: true })
        .waitFor();
      await page
        .getByText("Chế độ không tài khoản cần host do app quản lý.", {
          exact: false,
        })
        .waitFor();
      await page.screenshot({
        path: join(out, "sources-accountless-1920.png"),
        fullPage: true,
      });
      await page.getByLabel("Nguồn trận đấu").selectOption("league-collector");
      await page.waitForFunction(() =>
        document.body.innerText.includes("10/10 người"),
      );
      const overlay = await browser.newPage({
        viewport: { width: 1920, height: 1080 },
      });
      overlay.on("pageerror", (e: Error) => errors.push(e.message));
      await overlay.goto(url + "/overlay?scene=ingame");
      await overlay.evaluate(() => document.fonts.ready);
      await overlay.waitForTimeout(1500);
      const png = await overlay.screenshot({
        path: join(out, "obs-1920.png"),
        omitBackground: true,
      });
      const { data, info } = await sharp(png)
        .ensureAlpha()
        .raw()
        .toBuffer({ resolveWithObject: true });
      let transparent = 0;
      for (let i = 3; i < data.length; i += 4) if (data[i] === 0) transparent++;
      assert.ok(
        transparent / (info.width * info.height) > 0.2,
        "OBS alpha missing",
      );
      assert.deepEqual(errors, []);
      console.log(
        "PASS: browser source selection/reselection, shared collector frames and OBS transparency1920",
      );
    } finally {
      await browser.close();
    }
  }
  const transport = spawn(
    process.execPath,
    ["--import", "tsx", "tests/transport.integration.ts"],
    {
      windowsHide: true,
      env: { ...process.env, OVERLAY_TEST_URL: url },
      stdio: ["ignore", "pipe", "pipe"],
    },
  );
  let transportOutput = "";
  transport.stdout.on("data", (b) => (transportOutput += b));
  transport.stderr.on("data", (b) => (transportOutput += b));
  const [transportCode] = await once(transport, "exit");
  assert.equal(transportCode, 0, transportOutput);
  console.log(transportOutput.trim());
  console.log(
    "PASS: collector provider → shared Studio/OBS, accountless isolation, switch/stop/reselect without LB",
  );
} catch (error) {
  throw Error(
    `Collector project integration failed: ${(error as Error).message}; backend=${logs.slice(-2000)}`,
  );
} finally {
  studio?.terminate();
  obs?.terminate();
  clearInterval(ticker);
  backend.kill();
  if (backend.exitCode === null) await once(backend, "exit");
  for (const client of feed.clients) client.terminate();
  await new Promise<void>((yes) => feed.close(() => yes()));
  await rm(directory, { recursive: true, force: true });
}
