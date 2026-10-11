import { readFile, readdir, stat } from "node:fs/promises";
import { createReadStream } from "node:fs";
import { createInterface } from "node:readline";
import { resolve } from "node:path";
import { z } from "zod";
import { BARON_BUFF_SECONDS } from "../shared/game-rules";
import {
  rehearsalButtons,
  type RehearsalKind,
  type RehearsalDisplay,
} from "../shared/rehearsal";
import type { ObservedEvent } from "../shared/observer";
import { LeagueBroadcastSource } from "./leaguebroadcast";
import { ingameSampleSchema, type IngameSample } from "../shared/observer";
import { ObserverSession } from "./observer-session";

export const captureIdSchema = z
  .string()
  .regex(/^(?:lb-)?\d{4}-\d{2}-\d{2}T\d{2}-\d{2}-\d{2}-\d{3}Z$/);
type Entry = { offsetMs: number; recordedAt: string; sample: IngameSample };
const captureRoot = resolve("data/captures");

export async function listCaptures() {
  try {
    const directories = await readdir(captureRoot, { withFileTypes: true });
    const records = await Promise.all(
      directories
        .filter(
          (d) => d.isDirectory() && captureIdSchema.safeParse(d.name).success,
        )
        .map(async (d) => {
          try {
            const manifest = JSON.parse(
              await readFile(
                resolve(captureRoot, d.name, "manifest.json"),
                "utf8",
              ),
            );
            return {
              id: d.name,
              frames:
                Number(
                  manifest.ingameStateFrames ??
                    manifest.frames ??
                    manifest.websocket?.frames,
                ) || 0,
              hasState:
                manifest.ingameStateFrames > 0 ||
                (Array.isArray(
                  manifest.messageTypes ?? manifest.websocket?.messageTypes,
                ) &&
                  (
                    manifest.messageTypes ?? manifest.websocket?.messageTypes
                  ).includes("ingame-state-update")),
            };
          } catch {
            return null;
          }
        }),
    );
    return records
      .filter((r) => r !== null)
      .sort((a, b) => b.id.localeCompare(a.id));
  } catch {
    return [];
  }
}

function captureParser() {
  const entries: Entry[] = [];
  let baseline: number | undefined,
    last = -Infinity;
  let clock = 0;
  const source = new LeagueBroadcastSource(() => clock);
  const append = (line: string) => {
    if (!line.trim()) return;
    const record = JSON.parse(line);
    const timestamp = Date.parse(record.receivedAt);
    if (!Number.isFinite(timestamp) || timestamp < last)
      throw Error("Timestamp bản ghi không hợp lệ.");
    last = timestamp;
    clock = timestamp;
    const message = record.message;
    // LB emits an empty bootstrap state before its first complete roster.
    if (
      message?.type === "ingame-state-update" &&
      message.state?.gameTime === 0 &&
      !message.state?.scoreboardBottom?.teams?.length
    )
      return;
    source.accept(message);
    if (message?.type !== "ingame-state-update") return;
    const sample = source.currentSample();
    if (!sample) throw Error("Bản ghi chứa frame trận không hợp lệ hoặc demo.");
    baseline ??= timestamp;
    entries.push({
      offsetMs: timestamp - baseline,
      recordedAt: sample.capturedAt,
      sample,
    });
    if (entries.length > 10000) throw Error("Bản ghi quá dài.");
  };
  return {
    append,
    finish() {
      if (!entries.length) throw Error("Bản ghi không có state in-game.");
      return entries;
    },
  };
}
export function parseCapture(text: string): Entry[] {
  const parser = captureParser();
  for (const line of text.split(/\r?\n/)) parser.append(line);
  return parser.finish();
}

export class CaptureReplay {
  private cue: ObservedEvent | undefined;
  private targets(kind: RehearsalKind) {
    const questRole = {
      questTop: "top",
      questJungle: "jungle",
      questMid: "mid",
      questBot: "bot",
      questSupport: "support",
    }[kind as string];
    if (questRole)
      return this.entries.filter((e) =>
        e.sample.events.some(
          (event) =>
            event.kind === "RoleQuestCompleted" &&
            Math.abs(event.at - e.sample.gameTime.value!) < 0.1 &&
            e.sample.players.find((p) => p.slot === event.playerSlot)?.roleQuest
              ?.value?.role === questRole,
        ),
      );
    if (kind === "inhibitorBlue" || kind === "inhibitorRed") {
      const team = kind === "inhibitorBlue" ? "ORDER" : "CHAOS";
      return this.entries.filter((e) =>
        e.sample.inhibitors?.value?.some(
          (i) => i.team === team && i.respawnsAt > e.sample.gameTime.value!,
        ),
      );
    }
    const eventKinds: Partial<Record<RehearsalKind, ObservedEvent["kind"]>> = {
      dragon: "DragonKill",
      soul: "DragonSoul",
      baron: "BaronKill",
      tower: "TurretKilled",
      inhibitor: "InhibKilled",
      inhibitorRespawn: "InhibRespawned",
      level: "LevelUp",
      item: "ItemCompleted",
    };
    const eventKind = eventKinds[kind];
    if (eventKind)
      return this.entries.filter((e) =>
        e.sample.events.some(
          (event) =>
            event.kind === eventKind &&
            Math.abs(event.at - e.sample.gameTime.value!) < 0.1,
        ),
      );
    return this.entries.filter((e, index) => {
      const s = e.sample;
      if (kind === "gold")
        return (
          s.players.length === 10 &&
          s.players.every((p) => p.totalGold.value != null)
        );
      if (kind === "levels")
        return (
          s.players.length === 10 &&
          s.players.every((p) => p.level.value != null)
        );
      if (kind === "timers")
        return s.pitTimers?.some((t) => t.timeAlive.value != null);
      if (kind === "runes")
        return (
          s.players.length === 10 &&
          s.players.every((p) => p.perks?.value?.length === 9)
        );
      if (kind === "cooldowns" || kind === "minimal")
        return s.players.some((p) =>
          p.cooldowns?.value?.some(
            (c) => c.kind === "item" && c.readyAt > s.gameTime.value!,
          ),
        );
      if (kind === "death")
        return s.players.some((p) => p.isDead?.value === true);
      if (kind === "respawn")
        return (
          index > 0 &&
          s.players.some(
            (p) =>
              p.isDead?.value === false &&
              this.entries[index - 1].sample.players.find(
                (old) => old.slot === p.slot,
              )?.isDead?.value === true,
          )
        );
      return kind === "clear";
    });
  }
  capabilities() {
    return {
      id: this.id,
      buttons: rehearsalButtons.map((button) => ({
        ...button,
        available: this.targets(button.kind).length > 0,
        reason:
          button.kind === "runes"
            ? "Bản ghi chưa đủ 9 perk ID cho cả 10 người."
            : button.kind === "damage"
              ? "Bản ghi không có damage telemetry."
              : "Cần mẫu thật có dữ liệu tương ứng.",
      })),
    };
  }
  rehearse(
    kind: RehearsalKind,
    variant?: import("../shared/rehearsal").RehearsalVariant,
  ): RehearsalDisplay {
    if (!this.id) throw Error("Chưa mở bản ghi thật.");
    const allowed: Partial<Record<RehearsalKind, string[]>> = {
      timers: ["pit", "dragon"],
      dragon: ["dragon"],
      soul: ["dragon"],
      baron: ["buffs"],
      inhibitor: ["inhibitorTeam"],
      inhibitorBlue: ["inhibitorTeam"],
      inhibitorRed: ["inhibitorTeam"],
      tower: ["tower"],
    };
    if (
      variant &&
      Object.keys(variant).some((key) => !allowed[kind]?.includes(key))
    )
      throw Error("Biến thể không hợp lệ cho chức năng này.");
    if (variant?.dragon === "elder" && kind === "soul")
      throw Error("Elder không có linh hồn.");
    if (
      variant &&
      ![
        "timers",
        "dragon",
        "soul",
        "baron",
        "inhibitor",
        "inhibitorBlue",
        "inhibitorRed",
        "tower",
      ].includes(kind)
    )
      throw Error("Biến thể không hợp lệ cho chức năng này.");
    if (kind === "clear") {
      this.cue = undefined;
      return { kind };
    }
    const targets = this.targets(variant?.inhibitorTeam ? "inhibitor" : kind);
    if (!targets.length)
      throw Error("Bản ghi không có dữ liệu cho chức năng này.");
    let entry =
      kind === "gold" || kind === "levels"
        ? targets.at(-1)!
        : kind === "cooldowns" || kind === "minimal"
          ? (targets.find((e) =>
              e.sample.players.some((p) =>
                p.cooldowns?.value?.some(
                  (c) => c.id === 3026 && c.readyAt > e.sample.gameTime.value!,
                ),
              ),
            ) ?? targets[0])
          : targets[0];
    const display: RehearsalDisplay = { kind };
    if (kind === "baron") {
      const event = entry.sample.events.find(
        (e) =>
          e.kind === "BaronKill" &&
          Math.abs(e.at - entry.sample.gameTime.value!) < 0.1,
      )!;
      const team = event.team!;
      const next = this.entries.find(
        (e) =>
          e.offsetMs >= entry.offsetMs + 10000 &&
          e.sample.players.some(
            (p) => p.team.value === team && p.hasBaron?.value === true,
          ),
      );
      const gold = (s: IngameSample, t: string) =>
        s.teams?.find((v) => v.team === t)?.totalGold.value;
      const other = team === "ORDER" ? "CHAOS" : "ORDER";
      const a = gold(entry.sample, team),
        b = gold(entry.sample, other),
        c = gold((next ?? entry).sample, team),
        d = gold((next ?? entry).sample, other);
      if (a != null && b != null && c != null && d != null)
        display.powerPlay = {
          team,
          startedAt: event.at,
          goldDelta: 1500 + c - d - (a - b),
          endsAt: event.at + BARON_BUFF_SECONDS,
        };
      // User-defined rule: 3 minutes, ending early at observed whole-team loss.
      const loss = this.entries.find(
        (e) =>
          e.offsetMs > (next ?? entry).offsetMs &&
          e.sample.players.filter((p) => p.team.value === team).length === 5 &&
          e.sample.players
            .filter((p) => p.team.value === team)
            .every((p) => p.hasBaron?.value === false),
      );
      if (display.powerPlay && loss?.sample.gameTime.value != null) {
        display.powerPlay.endsAt = Math.min(
          event.at + BARON_BUFF_SECONDS,
          loss.sample.gameTime.value,
        );
        display.powerPlay.timerSource = "recorded-buff-loss";
      }
      entry = next ?? entry;
    }
    this.control({ positionMs: entry.offsetMs, playing: false });
    const eventKinds: Partial<Record<RehearsalKind, ObservedEvent["kind"]>> = {
      dragon: "DragonKill",
      soul: "DragonSoul",
      tower: "TurretKilled",
      inhibitor: "InhibKilled",
      inhibitorRespawn: "InhibRespawned",
      level: "LevelUp",
      item: "ItemCompleted",
      questTop: "RoleQuestCompleted",
      questJungle: "RoleQuestCompleted",
      questMid: "RoleQuestCompleted",
      questBot: "RoleQuestCompleted",
      questSupport: "RoleQuestCompleted",
    };
    this.cue = entry.sample.events.find(
      (e) =>
        e.kind === eventKinds[kind] &&
        (!kind.startsWith("quest") ||
          entry.sample.players.find((p) => p.slot === e.playerSlot)?.roleQuest
            ?.value?.role ===
            {
              questTop: "top",
              questJungle: "jungle",
              questMid: "mid",
              questBot: "bot",
              questSupport: "support",
            }[kind as string]) &&
        Math.abs(e.at - entry.sample.gameTime.value!) < 0.1,
    );
    if (variant) {
      display.variant = variant;
      display.previewAt = entry.sample.gameTime.value ?? undefined;
    }
    return display;
  }
  private entries: Entry[] = [];
  private session = new ObserverSession();
  private id: string | null = null;
  private anchorMs = 0;
  private wallAnchor = 0;
  private playing = false;
  private speed = 1;
  private generation = 0;
  constructor(private clock = Date.now) {}
  loadEntries(id: string, entries: Entry[]) {
    this.cue = undefined;
    if (!entries.length) throw Error("Bản ghi trống.");
    this.id = id;
    this.entries = entries;
    this.anchorMs = 0;
    this.wallAnchor = this.clock();
    this.playing = false;
    this.speed = 1;
    this.generation++;
    this.session = new ObserverSession();
  }
  async prepare(id: string) {
    captureIdSchema.parse(id);
    const path = resolve(captureRoot, id, "leaguebroadcast-ws.ndjson");
    if ((await stat(path)).size > 512 * 1024 * 1024)
      throw Error("Bản ghi vượt giới hạn 512 MB.");
    const parser = captureParser();
    const lines = createInterface({
      input: createReadStream(path, { encoding: "utf8" }),
      crlfDelay: Infinity,
    });
    for await (const line of lines) parser.append(line);
    return parser.finish();
  }
  private position() {
    return Math.min(
      this.duration(),
      this.anchorMs +
        (this.playing
          ? Math.max(0, this.clock() - this.wallAnchor) * this.speed
          : 0),
    );
  }
  private duration() {
    return this.entries.at(-1)?.offsetMs ?? 0;
  }
  control(action: { playing?: boolean; speed?: number; positionMs?: number }) {
    if (!this.id) throw Error("Chưa chọn bản ghi.");
    this.anchorMs =
      action.positionMs === undefined
        ? this.position()
        : Math.max(0, Math.min(action.positionMs, this.duration()));
    if (action.positionMs !== undefined) this.generation++;
    this.wallAnchor = this.clock();
    if (action.speed !== undefined) this.speed = action.speed;
    if (action.playing !== undefined) this.playing = action.playing;
  }
  snapshot() {
    const positionMs = this.position();
    return {
      id: this.id,
      frames: this.entries.length,
      positionMs,
      durationMs: this.duration(),
      playing: this.playing && positionMs < this.duration(),
      speed: this.speed,
    };
  }
  observe() {
    const wall = this.clock(),
      now = new Date(wall).toISOString();
    const position = this.position();
    let entry: Entry | undefined;
    for (const candidate of this.entries) {
      if (candidate.offsetMs > position) break;
      entry = candidate;
    }
    if (!entry || position - entry.offsetMs >= 5000)
      return this.session.ingest(null, "capture", now);
    const sample = structuredClone(entry.sample);
    // Only the clock advances between captured snapshots. Stats remain captured values.
    const originalSpeed = sample.replay.speed.value ?? 1;
    const advance = sample.replay.paused.value
      ? 0
      : ((position - entry.offsetMs) / 1000) * originalSpeed;
    if (sample.gameTime.value !== null) sample.gameTime.value += advance;
    if (sample.replay.time.value !== null) sample.replay.time.value += advance;
    for (const player of sample.players) {
      if (player.isDead?.value === true && player.respawnSeconds?.value != null)
        player.respawnSeconds.value = Math.max(
          0,
          player.respawnSeconds.value - advance,
        );
    }
    sample.replay.paused.value =
      !this.snapshot().playing || sample.replay.paused.value === true;
    sample.replay.paused.availability = "observed";
    // Anchor each replay frame exactly; no wall-clock drift during a pause or end.
    sample.replay.speed.value = 0;
    sample.replay.speed.availability = "observed";
    sample.capturedAt = now;
    const rebase = (v: any): void => {
      if (!v || typeof v !== "object") return;
      if ("observedAt" in v) v.observedAt = now;
      else Object.values(v).forEach(rebase);
    };
    rebase(sample);
    const frame = this.session.ingest(
      ingameSampleSchema.parse(sample),
      `capture:${this.id}:${this.generation}`,
      now,
      { kind: "recording", captureId: this.id!, recordedAt: entry.recordedAt },
    );
    if (this.cue) {
      frame.newEvents = [this.cue];
      frame.transition = "none";
      frame.playback!.trigger = "manual-rehearsal";
      this.cue = undefined;
    }
    return frame;
  }
  recording() {
    return this.session.recording();
  }
}
