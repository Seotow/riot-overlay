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

test("control commands are validated and forwarded with a bearer token only", async () => {
  const { sendValorantCommand } = await import("../server/valorant-control");
  const { mkdtemp, writeFile } = await import("node:fs/promises");
  const { tmpdir } = await import("node:os");
  const { join } = await import("node:path");
  const dir = await mkdtemp(join(tmpdir(), "val-ctl-"));
  const runtimePath = join(dir, "headless.json");
  await writeFile(runtimePath, JSON.stringify({ controlPort: 5330, controlToken: "a".repeat(64) }));
  const calls: any[] = [];
  const fetcher = (async (url: string, init: any) => {
    calls.push({ url, init });
    return { ok: true, status: 200, json: async () => ({ ok: true }) };
  }) as any;
  assert.deepEqual(await sendValorantCommand({ command: "tech_pause" }, { runtimePath, fetcher }), {
    ok: true,
  });
  assert.equal(calls[0].url, "http://127.0.0.1:5330/command");
  assert.equal(calls[0].init.headers.Authorization, `Bearer ${"a".repeat(64)}`);
  assert.equal(
    (await sendValorantCommand({ command: "rm -rf" }, { runtimePath, fetcher })).error,
    "invalid-command",
  );
  assert.equal(
    (
      await sendValorantCommand(
        { command: "toast", title: "x", message: "y", duration: 5 },
        { runtimePath, fetcher },
      )
    ).error,
    "invalid-command",
  );
  assert.equal(
    (
      await sendValorantCommand(
        { command: "tech_pause" },
        { runtimePath: join(dir, "none.json"), fetcher },
      )
    ).error,
    "client-not-managed",
  );
  assert.equal(calls.length, 1);
});
