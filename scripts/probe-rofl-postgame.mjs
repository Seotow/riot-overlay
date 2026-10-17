// Offline metadata only. Does not execute the replay or decrypt packet payloads.
import { open, readFile, writeFile } from "node:fs/promises";
import { createHash } from "node:crypto";
import assert from "node:assert/strict";
const path = process.argv[2];
if (!path?.toLowerCase().endsWith(".rofl"))
  throw Error("Supply explicit .rofl path");
const f = await open(path, "r");
try {
  const { size } = await f.stat();
  assert.ok(size >= 12);
  const h = Buffer.alloc(8),
    tail = Buffer.alloc(4);
  await f.read(h, 0, 8, 0);
  await f.read(tail, 0, 4, size - 4);
  assert.equal(h.subarray(0, 4).toString(), "RIOT");
  assert.equal(h.readUInt16LE(4), 2, "Only observed ROFL2 metadata format");
  const length = tail.readUInt32LE(),
    offset = size - 4 - length;
  assert.ok(
    length > 0 && length <= 2_000_000 && offset >= 8,
    "Metadata bounds",
  );
  const b = Buffer.alloc(length);
  const { bytesRead } = await f.read(b, 0, length, offset);
  assert.equal(bytesRead, length);
  const metadata = JSON.parse(
    new TextDecoder("utf-8", { fatal: true }).decode(b),
  );
  assert.equal(typeof metadata.statsJson, "string");
  const stats = JSON.parse(metadata.statsJson);
  assert.ok(Array.isArray(stats) && stats.length === 10);
  const number = (v) =>
    typeof v === "string" && /^\d+$/.test(v)
      ? Number(v)
      : typeof v === "number" && Number.isFinite(v)
        ? v
        : null;
  const fields = [
    "CHAMPIONS_KILLED",
    "NUM_DEATHS",
    "ASSISTS",
    "GOLD_EARNED",
    "TOTAL_DAMAGE_DEALT_TO_CHAMPIONS",
    "PHYSICAL_DAMAGE_DEALT_TO_CHAMPIONS",
    "MAGIC_DAMAGE_DEALT_TO_CHAMPIONS",
    "TRUE_DAMAGE_DEALT_TO_CHAMPIONS",
    "DRAGON_KILLS",
    "ELDER_DRAGON_KILLS",
    "BARON_KILLS",
    "RIFT_HERALD_KILLS",
    "HORDE_KILLS",
    "TURRETS_KILLED",
  ];
  const players = stats.map((p) => ({
    champion: p.SKIN,
    team: number(p.TEAM),
    win: p.WIN,
    teamPosition: p.TEAM_POSITION,
    stats: Object.fromEntries(fields.map((k) => [k, number(p[k])])),
  }));
  const previous = JSON.parse(
    await readFile(".npm-cache/lcu-postgame-custom.log", "utf8"),
  );
  const championNames = {
    157: "Yasuo",
    901: "Smolder",
    23: "Tryndamere",
    44: "Taric",
    42: "Corki",
    45: "Veigar",
    64: "LeeSin",
    10: "Kayle",
    25: "Morgana",
    11: "MasterYi",
  };
  const comparison = previous.detail.participants.map((p) => {
    const matches = players.filter(
      (x) => x.team === p.teamId && x.champion === championNames[p.championId],
    );
    assert.equal(matches.length, 1);
    const r = matches[0];
    assert.equal(r.stats.TOTAL_DAMAGE_DEALT_TO_CHAMPIONS, p.damage);
    assert.equal(r.stats.GOLD_EARNED, p.gold);
    assert.equal(r.stats.CHAMPIONS_KILLED, p.kills);
    assert.equal(r.stats.NUM_DEATHS, p.deaths);
    assert.equal(r.stats.ASSISTS, p.assists);
    assert.equal(r.win === "Win", p.win);
    return {
      champion: r.champion,
      team: r.team,
      damage: r.stats.TOTAL_DAMAGE_DEALT_TO_CHAMPIONS,
      matched: true,
    };
  });
  const report = {
    at: new Date().toISOString(),
    kind: "offline-rofl2-metadata-probe",
    readOnly: true,
    size,
    metadataOffset: offset,
    metadataLength: length,
    metadataSha256: createHash("sha256").update(b).digest("hex"),
    gameLengthMs: number(metadata.gameLength),
    metadataKeys: Object.keys(metadata),
    players,
    comparedWithLcuGameId: previous.detail.gameId,
    comparison,
    limits: [
      "Not packet decoding or a timeline",
      "No signature verification",
      "Filename is not an independently verified embedded match ID",
      "No automatic source/publish integration",
      "Future custom replay availability on spectator not established",
    ],
  };
  await writeFile(
    ".npm-cache/rofl-postgame-probe.json",
    JSON.stringify(report, null, 2),
  );
  console.log(JSON.stringify(report));
} finally {
  await f.close();
}
