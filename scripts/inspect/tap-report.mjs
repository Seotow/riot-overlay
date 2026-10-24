// Đọc log của tap (NDJSON, UTF-8 hoặc UTF-16 do PowerShell redirect) và in bảng phủ dữ liệu.
// Trả lời đúng một câu: trận này GEP đã gửi field nào, cho bao nhiêu người.
//   node scripts/inspect/tap-report.mjs --log <.npm-cache/tap.log>
import { readFileSync } from "node:fs";
import { resolve } from "node:path";

const arg = (name) => {
  const i = process.argv.indexOf(`--${name}`);
  return i >= 0 ? process.argv[i + 1] : undefined;
};

const logPath = resolve(arg("log") ?? "tap.log");
const buffer = readFileSync(logPath);
const text =
  buffer[0] === 0xff && buffer[1] === 0xfe ? buffer.toString("utf16le") : buffer.toString("utf8");

const frames = [];
for (const line of text.split(/\r?\n/)) {
  const match = line.match(/^([\d.]+)s ([\w/]+) (.*)$/);
  if (!match) continue;
  try {
    frames.push({ at: Number(match[1]), channel: match[2], frame: JSON.parse(match[3]) });
  } catch {}
}

const counts = new Map();
const samples = new Map();
const roster = new Map();
const scoreboard = new Map();
const killfeed = [];
const phases = [];
const scores = [];
const raw = [];

for (const { at, channel, frame } of frames) {
  if (channel === "status/connector") continue;
  counts.set(channel, (counts.get(channel) ?? 0) + 1);
  if (channel.startsWith("gep/")) raw.push({ at, value: frame.value });

  if (channel !== "out/obs_data") continue;
  const type = frame.type ?? "?";
  const data = frame.data;
  if (!samples.has(type)) samples.set(type, { at, data });

  if (type === "roster")
    roster.set(data.playerId, {
      name: data.name,
      team: data.startTeam,
      agent: data.agentInternal,
      locked: data.locked,
    });
  if (type === "scoreboard") scoreboard.set(data.playerId, data);
  if (type === "killfeed") killfeed.push(data);
  if (type === "round_info") phases.push(data.roundPhase);
  if (type === "score") scores.push(data);
}

const pad = (v, n) => String(v).padEnd(n);

console.log(`log: ${logPath}  (${frames.length} dòng, ${raw.length} frame GEP)`);
console.log("\n== luồng ==");
for (const [channel, n] of [...counts].sort((a, b) => b[1] - a[1]))
  console.log(`${String(n).padStart(6)}  ${channel}`);

console.log(`\n== roster: ${roster.size} người ==`);
for (const r of roster.values())
  console.log(`${pad(r.name, 18)} team${r.team} ${pad(r.agent || "-", 12)} locked=${r.locked}`);

console.log(`\n== scoreboard: ${scoreboard.size} người ==`);
for (const p of scoreboard.values())
  console.log(
    `${pad(p.name, 18)} team${p.startTeam} ${pad(p.agentInternal || "-", 12)} ${p.kills}/${p.deaths}/${p.assists} $${p.money} alive=${p.isAlive} ult=${p.currUltPoints}/${p.maxUltPoints} armor=${p.initialArmor}`,
  );

console.log(`\n== killfeed: ${killfeed.length} ==`);
for (const k of killfeed.slice(-10)) console.log(JSON.stringify(k));

console.log(`\n== round_phase: ${[...new Set(phases)].join(" → ") || "(chưa có)"}`);
console.log(`== score: ${scores.length ? JSON.stringify(scores.at(-1)) : "(chưa có)"}`);

console.log("\n== mẫu theo type ==");
for (const [type, { at, data }] of samples)
  console.log(`${String(at).padStart(7)}s ${pad(type, 12)} ${JSON.stringify(data).slice(0, 180)}`);

console.log("\n== GEP raw gần nhất ==");
for (const { value } of raw.slice(-25)) console.log(String(value).slice(0, 130));
