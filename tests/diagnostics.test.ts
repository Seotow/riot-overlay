import test from "node:test";
import assert from "node:assert/strict";
import { makeReport, parseLockfile, type Result } from "../server/diagnostics";
function result(id: string, data: unknown, status: Result["probe"]["status"] = "ok"): Result {
  return {
    data,
    probe: {
      id,
      source: id === "live" ? "Live Client" : "LCU",
      endpoint: "/fixture",
      status,
      httpStatus: status === "ok" ? 200 : null,
      latencyMs: 1,
      observedAt: "2026-09-19T00:00:00.000Z",
    },
  };
}
test("lockfile rejects invalid ports, protocols and malformed input", () => {
  assert.deepEqual(parseLockfile("LeagueClient:1:12345:secret:https"), {
    port: 12345,
    password: "secret",
  });
  for (const value of [
    "",
    "LeagueClient:1:0:secret:https",
    "LeagueClient:1:65536:secret:https",
    "LeagueClient:1:12:secret:http",
    "LeagueClient:1:12::https",
  ])
    assert.equal(parseLockfile(value), null);
});
test("reports never expose credentials, identities or unknown provider objects", () => {
  const report = makeReport([
    result("live", {
      token: "SECRET",
      allPlayers: [
        {
          summonerName: "PRIVATE",
          level: 0,
          items: [{ itemID: 1001, password: "SECRET" }],
          scores: { kills: 0 },
        },
      ],
      activePlayer: { currentGold: 100 },
    }),
    result("phase", "SECRET"),
  ]);
  const json = JSON.stringify(report);
  assert.ok(!json.includes("SECRET") && !json.includes("PRIVATE"));
  assert.equal(report.phase, null);
  assert.deepEqual(report.fields.find((f) => f.field === "Level")?.sample, [0]);
  assert.equal(report.fields.find((f) => f.field === "Total gold")?.availability, "missing");
  assert.equal(report.fields.find((f) => f.field === "Champion ID")?.availability, "unverified");
});
test("empty, invalid and disconnected samples do not claim availability", () => {
  for (const data of [
    null,
    {},
    { allPlayers: [] },
    { allPlayers: [{ level: "secret" }, { level: null }] },
  ]) {
    assert.equal(
      makeReport([result("live", data)]).fields.find((f) => f.field === "Level")?.availability,
      "missing",
    );
  }
  assert.equal(
    makeReport([result("live", { allPlayers: [{ level: 18 }] }, "unreachable")]).fields.find(
      (f) => f.field === "Level",
    )?.availability,
    "unverified",
  );
});
