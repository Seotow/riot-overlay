import test from "node:test";
import assert from "node:assert/strict";
import { normalizeSpectra, ValorantSpectraSource } from "../server/valorant-spectra";

const at = "2026-10-18T10:00:00.000Z";
// Hình dạng đã quan sát từ output Spectra thật (đã ẩn danh); không phải log game.
function raw(over: any = {}) {
  return {
    isRunning: true,
    matchType: "bomb",
    map: "Ascent",
    roundNumber: 1,
    roundPhase: "combat",
    roundTimeoutTime: 1792259151383,
    spikeState: { planted: false, detonated: false, defused: false },
    teams: [
      {
        teamName: "Alpha",
        isAttacking: true,
        roundsWon: 0,
        players: [
          {
            name: "Tester",
            tagline: "VN1",
            agentProper: "Sage",
            locked: true,
            isAlive: true,
            hasSpike: true,
            isObserved: true,
            health: 100,
            abilities: { grenade: 0, ability1: 0, ability2: 0 },
            kills: 0,
            deaths: 0,
            assists: 0,
            currUltPoints: 7,
            maxUltPoints: 7,
            ultReady: true,
            money: 99999,
            armorName: "Regen",
            highestWeapon: "Vandal",
            scoreboardAvailable: true,
            auxiliaryAvailable: { health: false, abilities: false, scoreboard: false },
            ...over,
          },
        ],
      },
      { teamName: "Bravo", isAttacking: false, roundsWon: 0, players: [] },
    ],
  };
}

test("scoreboard fields are observed, Spectra default HP/abilities are not trusted", () => {
  const p = normalizeSpectra(raw(), at, 1)!.teams[0].players[0];
  assert.equal(p.money.value, 99999);
  assert.equal(p.weapon.value, "Vandal");
  assert.equal(p.ultimate.ready.value, true);
  assert.equal(p.name.value, "Tester#VN1");
  assert.deepEqual(p.health, { value: null, availability: "unavailable", provenance: "observed" });
  assert.equal(p.abilities.grenade.value, null);
  assert.equal(p.abilities.grenade.availability, "unavailable");
});

test("HP and abilities appear only when Auxiliary confirms them", () => {
  const aux = { health: true, abilities: true, scoreboard: true };
  const f = normalizeSpectra(
    raw({
      auxiliaryAvailable: aux,
      health: 63,
      abilities: { grenade: 1, ability1: 2, ability2: 0 },
    }),
    at,
    1,
  )!;
  const p = f.teams[0].players[0];
  assert.equal(p.health.value, 63);
  assert.equal(p.abilities.ability1.value, 2);
  assert.equal(f.coverage.health, 1);
  assert.equal(f.coverage.abilities, 1);
});

test("dead player's HP is derived 0, never copied from the default", () => {
  const p = normalizeSpectra(raw({ isAlive: false, health: 100 }), at, 1)!.teams[0].players[0];
  assert.deepEqual(p.health, { value: 0, availability: "available", provenance: "derived" });
});

test("without scoreboard nothing is invented and KDA is marked derived", () => {
  const p = normalizeSpectra(raw({ scoreboardAvailable: false, kills: 2 }), at, 1)!.teams[0]
    .players[0];
  assert.equal(p.money.value, null);
  assert.equal(p.weapon.availability, "unavailable");
  assert.equal(p.isAlive.value, null);
  assert.deepEqual(p.kills, { value: 2, availability: "available", provenance: "derived" });
});

test("team names are manual, round end is derived and only valid during combat", () => {
  const f = normalizeSpectra(raw(), at, 1)!;
  assert.equal(f.teams[0].name.provenance, "manual");
  assert.equal(f.match.roundEndsAt.provenance, "derived");
  assert.notEqual(f.match.roundEndsAt.value, null);
  const shop = normalizeSpectra({ ...raw(), roundPhase: "shopping" }, at, 1)!;
  assert.equal(shop.match.roundEndsAt.value, null);
  assert.equal(
    normalizeSpectra({ ...raw(), roundPhase: "weird" }, at, 1)!.match.roundPhase.value,
    null,
  );
});

test("malformed payloads are rejected", () => {
  assert.equal(normalizeSpectra(null, at, 1), null);
  assert.equal(normalizeSpectra({ teams: [] }, at, 1), null);
});

test("Socket.IO handshake: open → connect → logon, then match_data is accepted", () => {
  let clock = Date.parse(at);
  const sent: string[] = [];
  const source = new ValorantSpectraSource({
    port: 5320,
    groupCode: "G",
    now: () => clock,
    connect: false,
  });
  const ws = { send: (m: string) => sent.push(m) };
  source.message(ws, '0{"sid":"x"}');
  source.message(ws, "40");
  source.message(ws, "2");
  assert.deepEqual(sent, ["40", '42["logon","{\\"groupCode\\":\\"G\\"}"]', "3"]);
  assert.equal(source.snapshot().status, "waiting");
  source.message(ws, `42${JSON.stringify(["match_data", JSON.stringify(raw())])}`);
  assert.equal(source.snapshot().status, "receiving");
  assert.equal(source.observe()!.sequence, 1);
  clock += 20_000;
  assert.equal(source.snapshot().status, "stale");
  assert.equal(source.snapshot().quietIsNotDead, true);
  source.message(ws, `42${JSON.stringify(["match_data", "not json"])}`);
  assert.equal(source.snapshot().status, "invalid");
  assert.equal(source.snapshot().invalidFrames, 1);
});

test("manual controls are read from timeout/toast state and marked as operator state", () => {
  const f = normalizeSpectra(
    {
      ...raw(),
      showAliveKDA: true,
      timeoutState: { techPause: true, leftTeam: true, rightTeam: false, timeRemaining: 41 },
      toastInfo: { active: true, title: "Tạm dừng", message: "Kiểm tra mạng" },
    },
    at,
    1,
  )!;
  assert.deepEqual(f.controls, {
    techPause: true,
    leftTimeout: true,
    rightTimeout: false,
    timeoutRemaining: 41,
    showAliveKda: true,
    toast: { active: true, title: "Tạm dừng", message: "Kiểm tra mạng" },
  });
  assert.equal(normalizeSpectra(raw(), at, 1)!.controls.toast.active, false);
});

test("controller: chỉ reconnect vào trận có sẵn, gửi lệnh đúng định dạng obs_data, chặn plant ngoài combat", async () => {
  const { ValorantController } = await import("../server/valorant-controller");
  const { sendValorantCommand } = await import("../server/valorant-control");
  const { defaultPaths } = await import("../server/valorant-config");
  let phase: string | null = "shopping";
  const controller: any = new ValorantController({
    ingestPort: 1,
    extrasPort: 1,
    groupCode: "RIOTLOCAL",
    key: "k".repeat(64),
    observerName: "Studio",
    secretFile: "unused",
    paths: { ...defaultPaths(5322), config: "nope.json", assets: "nope" },
    phase: () => phase,
  });
  const sent: string[] = [];
  const ws = { send: (m: string) => sent.push(m) };
  controller.ws = ws;
  await controller.message(ws, '0{"sid":"x"}', "SECRET");
  await controller.message(ws, "40", "SECRET");
  assert.equal(sent[0], "40");
  const logon = JSON.parse(JSON.parse(sent[1].slice(2))[1]);
  assert.equal(logon.groupSecret, "SECRET");
  assert.equal(logon.groupCode, "RIOTLOCAL");
  // Chưa nối: mọi lệnh báo not-connected
  assert.deepEqual(await controller.run({ command: "tech_pause" }), {
    ok: false,
    error: "not-connected",
  });
  // Server chấp nhận bằng reconnected
  await controller.message(
    ws,
    '42["obs_logon_ack","{\\"type\\":\\"authenticate\\",\\"value\\":true,\\"reason\\":\\"reconnected\\"}"]',
    "SECRET",
  );
  assert.equal(controller.isConnected(), true);
  assert.deepEqual(await controller.run({ command: "tech_pause" }), { ok: true });
  const frame = JSON.parse(JSON.parse(sent.at(-1)!.slice(2))[1]);
  assert.deepEqual(
    { t: frame.type, d: frame.data, g: frame.groupCode },
    { t: "tech_pause", d: true, g: "RIOTLOCAL" },
  );
  assert.deepEqual(await controller.run({ command: "spike_planted" }), {
    ok: false,
    error: "not-in-combat",
  });
  phase = "combat";
  assert.deepEqual(await controller.run({ command: "spike_planted" }), { ok: true });
  assert.deepEqual(
    await controller.run({ command: "toast", title: "t", message: "m", duration: 3000 }),
    { ok: true },
  );
  const toast = JSON.parse(JSON.parse(sent.at(-1)!.slice(2))[1]);
  assert.equal(toast.data.active, true);
  // Qua sendValorantCommand: lệnh sai bị từ chối, thiếu controller báo not-connected
  assert.equal(
    (await sendValorantCommand({ command: "rm -rf" }, { controller })).error,
    "invalid-command",
  );
  assert.equal((await sendValorantCommand({ command: "tech_pause" })).error, "not-connected");
  assert.deepEqual(await sendValorantCommand({ command: "left_timeout" }, { controller }), {
    ok: true,
  });
  // Nếu server cấp bí mật mới (controller vô tình tạo trận) thì không bao giờ chấp nhận
  await controller.message(
    ws,
    '42["obs_logon_ack","{\\"type\\":\\"authenticate\\",\\"value\\":true,\\"reason\\":\\"NEWSECRET1234\\"}"]',
    "SECRET",
  );
  assert.equal(controller.isConnected(), false);
  assert.equal(controller.status().error, "controller-created-match");
});

test("game power persists per game and defaults to LoL only", async () => {
  const { GamePower } = await import("../server/game-power");
  const { mkdtemp, readFile } = await import("node:fs/promises");
  const { tmpdir } = await import("node:os");
  const { join } = await import("node:path");
  const path = join(await mkdtemp(join(tmpdir(), "games-")), "games.json");
  const power = new GamePower(path);
  await power.load();
  assert.deepEqual(power.snapshot(), { lol: true, valorant: false });
  await power.set("valorant", true);
  await power.set("lol", false);
  const again = new GamePower(path);
  await again.load();
  assert.deepEqual(again.snapshot(), { lol: false, valorant: true });
  assert.deepEqual(JSON.parse(await readFile(path, "utf8")), { lol: false, valorant: true });
});

test("match config: logo is identified by file signature and stored by content hash", async () => {
  const { saveMatchConfig, viewMatchConfig, decodeLogo } =
    await import("../server/valorant-config");
  const { defaultValorantMatchConfig } = await import("../shared/valorant-config");
  const { mkdtemp, readdir } = await import("node:fs/promises");
  const { tmpdir } = await import("node:os");
  const { join } = await import("node:path");
  const dir = await mkdtemp(join(tmpdir(), "val-cfg-"));
  const paths = {
    config: join(dir, "match-config.json"),
    assets: join(dir, "assets"),
    frontendPort: 5322,
  };
  const png = Buffer.concat([
    Buffer.from([0x89, 0x50, 0x4e, 0x47, 0x0d, 0x0a, 0x1a, 0x0a]),
    Buffer.from("x".repeat(20)),
  ]);
  const dataUrl = `data:image/png;base64,${png.toString("base64")}`;
  assert.ok(decodeLogo(dataUrl));
  assert.equal(
    decodeLogo(`data:image/png;base64,${Buffer.from("not an image").toString("base64")}`),
    null,
  );
  assert.equal(decodeLogo(`data:image/jpeg;base64,${png.toString("base64")}`), null);
  const config = structuredClone(defaultValorantMatchConfig);
  config.teams[0].name = "Alpha";
  config.series = { needed: 2, wonLeft: 1, wonRight: 0 };
  config.nameOverrides = [{ player: "Foo#VN1", display: "Foo" }];
  const saved = await saveMatchConfig({ config, uploads: { left: dataUrl } }, paths);
  assert.ok(saved.ok);
  if (!saved.ok) return;
  assert.match(saved.view.config.teams[0].logo, /^[a-f0-9]{16}\.png$/);
  assert.equal(
    saved.view.logoUrls.left,
    `http://127.0.0.1:5322/uploads/${saved.view.config.teams[0].logo}`,
  );
  assert.deepEqual(await readdir(paths.assets), [saved.view.config.teams[0].logo]);
  assert.equal((await viewMatchConfig(paths)).config.teams[0].name, "Alpha");
  const over = structuredClone(config);
  over.series.wonLeft = 3;
  assert.deepEqual(await saveMatchConfig({ config: over }, paths), {
    ok: false,
    error: "invalid-config",
  });
  assert.deepEqual(
    await saveMatchConfig({ config, uploads: { right: "data:image/png;base64,AAAA" } }, paths),
    { ok: false, error: "invalid-logo" },
  );
});
