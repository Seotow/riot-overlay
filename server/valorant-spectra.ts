import { readFile } from "node:fs/promises";
import { resolve } from "node:path";
import { WebSocket } from "ws";
import {
  valorantFrameSchema,
  type ValorantField,
  type ValorantFrame,
  type ValorantStatus,
} from "../shared/valorant";

// Spectra Server là nguồn trung gian: giá trị mặc định (HP 100, ability 0, tiền 800...) không
// phân biệt được với giá trị thật, nên chỉ nhận khi cờ availability của Spectra xác nhận.
const ok = <T>(value: T, provenance: "observed" | "derived" | "manual" = "observed") =>
  ({ value, availability: "available", provenance }) satisfies ValorantField<T>;
const none = <T>(provenance: "observed" | "derived" | "manual" = "observed") =>
  ({ value: null, availability: "unavailable", provenance }) satisfies ValorantField<T>;
const text = (v: unknown) => (typeof v === "string" && v.trim() ? v : null);
const num = (v: unknown) => (typeof v === "number" && Number.isFinite(v) ? v : null);
const bool = (v: unknown) => (typeof v === "boolean" ? v : null);
const phases = ["LOBBY", "shopping", "combat", "end", "game_end"] as const;

function player(raw: any, slot: number) {
  const board = raw?.scoreboardAvailable === true;
  const aux = raw?.auxiliaryAvailable ?? {};
  const fromBoard = <T>(value: T | null) => (board && value !== null ? ok(value) : none<T>());
  const alive = bool(raw?.isAlive);
  const name = text(raw?.name);
  const tag = text(raw?.tagline);
  // HP chỉ đáng tin từ kênh Auxiliary; chết thì 0 là suy ra từ trạng thái scoreboard.
  const health: ValorantField<number> =
    aux.health === true && num(raw?.health) !== null
      ? ok(num(raw.health)!)
      : board && alive === false
        ? ok(0, "derived")
        : none();
  const ability = (key: string): ValorantField<number> =>
    aux.abilities === true && num(raw?.abilities?.[key]) !== null
      ? ok(num(raw.abilities[key])!)
      : none();
  // KDA có thể đến từ killfeed khi chưa có scoreboard: giữ giá trị nhưng gắn derived.
  const stat = (v: unknown): ValorantField<number> =>
    num(v) === null ? none() : board ? ok(num(v)!) : ok(num(v)!, "derived");
  return {
    slot,
    name: name ? ok(tag ? `${name}#${tag}` : name) : none<string>(),
    agent: text(raw?.agentProper) ? ok(text(raw.agentProper)!) : none<string>(),
    agentLocked: raw?.locked === true,
    isObserved: raw?.isObserved === true,
    isAlive: fromBoard(alive),
    hasSpike: fromBoard(bool(raw?.hasSpike)),
    health,
    abilities: {
      grenade: ability("grenade"),
      ability1: ability("ability1"),
      ability2: ability("ability2"),
    },
    ultimate: {
      points: fromBoard(num(raw?.currUltPoints)),
      max: fromBoard(num(raw?.maxUltPoints)),
      ready: fromBoard(bool(raw?.ultReady)),
    },
    kills: stat(raw?.kills),
    deaths: stat(raw?.deaths),
    assists: stat(raw?.assists),
    money: fromBoard(num(raw?.money)),
    armor: fromBoard(text(raw?.armorName)),
    weapon: fromBoard(text(raw?.highestWeapon)),
  };
}

/** Payload `match_data` của Spectra Server → contract Valorant. Trả null nếu không đúng dạng. */
export function normalizeSpectra(
  raw: any,
  receivedAt: string,
  sequence: number,
): ValorantFrame | null {
  if (!raw || typeof raw !== "object" || !Array.isArray(raw.teams) || raw.teams.length !== 2)
    return null;
  const teams = raw.teams.map((team: any, index: number) => {
    const players = Array.isArray(team?.players) ? team.players : [];
    return {
      index,
      // Tên đội do operator đặt trong Client/config, không phải telemetry game.
      name: text(team?.teamName) ? ok(text(team.teamName)!, "manual") : none<string>("manual"),
      isAttacking: team?.isAttacking === true,
      roundsWon: Math.max(0, Math.trunc(num(team?.roundsWon) ?? 0)),
      players: players.map((p: unknown, slot: number) => player(p, slot)),
    };
  });
  const all = teams.flatMap((t: { players: ReturnType<typeof player>[] }) => t.players);
  const phase = phases.find((p) => p === raw.roundPhase);
  const spike = raw.spikeState ?? {};
  const flag = (v: unknown): ValorantField<boolean> =>
    bool(v) === null ? none() : ok(bool(v)!, "derived");
  const frame = {
    schemaVersion: 1,
    game: "valorant",
    source: "spectra",
    receivedAt,
    sequence,
    match: {
      running: raw.isRunning === true,
      map: text(raw.map) ? ok(text(raw.map)!) : none<string>(),
      mode: text(raw.matchType) ? ok(text(raw.matchType)!) : none<string>(),
      roundNumber: Math.max(0, Math.trunc(num(raw.roundNumber) ?? 0)),
      roundPhase: phase ? ok(phase) : none<(typeof phases)[number]>(),
      roundEndsAt:
        phase === "combat" && num(raw.roundTimeoutTime)
          ? ok(raw.roundTimeoutTime, "derived")
          : none<number>("derived"),
      spike: {
        planted: flag(spike.planted),
        detonated: flag(spike.detonated),
        defused: flag(spike.defused),
      },
    },
    teams,
    controls: {
      techPause: raw.timeoutState?.techPause === true,
      leftTimeout: raw.timeoutState?.leftTeam === true,
      rightTimeout: raw.timeoutState?.rightTeam === true,
      timeoutRemaining: Math.max(0, num(raw.timeoutState?.timeRemaining) ?? 0),
      showAliveKda: raw.showAliveKDA === true,
      toast: {
        active: raw.toastInfo?.active === true,
        title: text(raw.toastInfo?.title) ?? "",
        message: text(raw.toastInfo?.message) ?? "",
      },
    },
    coverage: {
      players: all.length,
      scoreboard: all.filter((p: ReturnType<typeof player>) => p.money.availability === "available")
        .length,
      health: all.filter(
        (p: ReturnType<typeof player>) =>
          p.health.provenance === "observed" && p.health.availability === "available",
      ).length,
      abilities: all.filter(
        (p: ReturnType<typeof player>) => p.abilities.grenade.availability === "available",
      ).length,
    },
  };
  const parsed = valorantFrameSchema.safeParse(frame);
  return parsed.success ? parsed.data : null;
}

export interface SpectraOptions {
  port: number;
  groupCode: string;
  frontendPort?: number;
  now?: () => number;
  /** Chỉ dùng trong test: bỏ qua việc mở socket thật. */
  connect?: boolean;
}

// Nhịp Spectra phát chỉ khi có sự kiện mới; ngưỡng này chỉ để UI báo "chậm", không kết luận nguồn chết.
const STALE_MS = 15_000;

/** Máy khách Engine.IO v4 tối thiểu (ws) cho đúng một lần logon + match_data. */
export class ValorantSpectraSource {
  private ws: WebSocket | null = null;
  private timer: ReturnType<typeof setTimeout> | undefined;
  private frame: ValorantFrame | null = null;
  private stopped = true;
  private state: ValorantStatus["status"] = "offline";
  private accepted = 0;
  private invalid = 0;
  private lastAt: number | null = null;
  private readonly now: () => number;
  constructor(private readonly options: SpectraOptions) {
    this.now = options.now ?? Date.now;
  }
  private get endpoint() {
    return `ws://127.0.0.1:${this.options.port}/socket.io/?EIO=4&transport=websocket`;
  }
  start() {
    if (!this.stopped) return;
    this.stopped = false;
    if (this.options.connect !== false) this.open();
  }
  stop() {
    this.stopped = true;
    clearTimeout(this.timer);
    this.ws?.terminate();
    this.ws = null;
    this.state = "offline";
  }
  private open() {
    this.state = "connecting";
    let ws: WebSocket;
    try {
      ws = new WebSocket(this.endpoint, { handshakeTimeout: 3000 });
    } catch {
      return this.retry();
    }
    this.ws = ws;
    ws.on("message", (data) => this.message(ws, data.toString()));
    ws.on("error", () => ws.close());
    ws.on("close", () => {
      if (this.ws === ws) this.ws = null;
      if (!this.stopped) {
        this.state = "offline";
        this.retry();
      }
    });
  }
  private retry() {
    clearTimeout(this.timer);
    if (!this.stopped) this.timer = setTimeout(() => this.open(), 2000);
  }
  /** Engine.IO: 0=open, 2=ping, 4=message; Socket.IO: 40=connect, 42=event. */
  message(ws: Pick<WebSocket, "send">, packet: string) {
    if (packet[0] === "0") ws.send("40");
    else if (packet === "2") ws.send("3");
    else if (packet.startsWith("40")) {
      this.state = "waiting";
      ws.send(
        `42${JSON.stringify(["logon", JSON.stringify({ groupCode: this.options.groupCode })])}`,
      );
    } else if (packet.startsWith("42")) this.event(packet.slice(2));
  }
  private event(body: string) {
    try {
      const [name, payload] = JSON.parse(body);
      if (name !== "match_data" || typeof payload !== "string") return;
      this.accept(JSON.parse(payload));
    } catch {
      this.invalid++;
      this.state = "invalid";
    }
  }
  accept(raw: unknown) {
    const at = this.now();
    const frame = normalizeSpectra(raw, new Date(at).toISOString(), this.accepted + 1);
    if (!frame) {
      this.invalid++;
      this.state = "invalid";
      return;
    }
    this.accepted++;
    this.frame = frame;
    this.lastAt = at;
    this.state = "receiving";
  }
  observe(): ValorantFrame | null {
    return this.frame;
  }
  snapshot(): ValorantStatus {
    const age = this.lastAt === null ? null : this.now() - this.lastAt;
    const status =
      this.state === "receiving" && age !== null && age > STALE_MS ? "stale" : this.state;
    return {
      status,
      endpoint: `ws://127.0.0.1:${this.options.port}`,
      groupCode: this.options.groupCode,
      acceptedFrames: this.accepted,
      invalidFrames: this.invalid,
      lastFrameAt: this.lastAt === null ? null : new Date(this.lastAt).toISOString(),
      quietIsNotDead: true,
      gameTelemetryVerified: false,
    };
  }
}

/** Đọc cổng output + group code từ config module; không đụng tới key xác thực. */
export async function loadSpectraOptions(
  path = resolve(
    process.env.RIOT_OVERLAY_VALORANT_CONFIG ||
      "collector/hosts/valorant-collector/local/module.json",
  ),
): Promise<SpectraOptions> {
  let port = 5320,
    groupCode = "RIOTLOCAL",
    frontendPort = 5322;
  try {
    const config = JSON.parse(await readFile(path, "utf8"));
    if (Number.isInteger(config?.ports?.output)) port = config.ports.output;
    if (typeof config?.groupCode === "string" && config.groupCode) groupCode = config.groupCode;
    if (Number.isInteger(config?.ports?.frontend)) frontendPort = config.ports.frontend;
  } catch {}
  return { port, groupCode, frontendPort };
}
