import { createWriteStream } from "node:fs";
import { mkdir, readFile, writeFile, rename, unlink, access } from "node:fs/promises";
import { resolve } from "node:path";
import { createGzip } from "node:zlib";
import { WebSocket } from "ws";
import { observerFrameSchema, ingameSampleSchema } from "../../shared/observer";
import { normalizeIngame } from "../../server/ingame-adapter";
import { getLocal } from "../../server/diagnostics";
import { capturePrivacy } from "../validation/capture-privacy";
import { COLLECTOR_SAMPLE_INTERVAL_MS, remainingSampleDelay } from "../../shared/capture-rules";

const appPort = Number(process.env.RIOT_OVERLAY_CAPTURE_PORT ?? 4310);
if (!Number.isInteger(appPort) || appPort < 1024 || appPort > 65535)
  throw Error("Invalid app port");
const base = `http://127.0.0.1:${appPort}`,
  root = resolve(process.env.RIOT_OVERLAY_CAPTURE_ROOT ?? "data/captures");
const args = process.argv.slice(2);
const json = async (url: string) => {
  const r = await fetch(url, { signal: AbortSignal.timeout(4000) });
  if (!r.ok) throw Error("local-api-unavailable");
  return r.json();
};
if (args[0] === "--mark" || args[0] === "--stop") {
  const note = args.slice(1).join(" ").trim();
  if (args[0] === "--mark" && (!note || note.length > 500))
    throw Error('Use --mark "note" (1..500 characters)');
  const pointer = JSON.parse(await readFile(resolve(root, "active-collector.json"), "utf8"));
  if (
    !/^\d{4}-\d{2}-\d{2}T\d{2}-\d{2}-\d{2}-\d{3}Z$/.test(pointer.directory) ||
    Date.now() - Date.parse(pointer.updatedAt) > 20000
  )
    throw Error("No current collector capture");
  if (args[0] === "--stop") {
    await writeFile(resolve(root, pointer.directory, "stop.request"), "operator\n");
    console.log(JSON.stringify({ directory: pointer.directory, stopRequested: true }));
  } else {
    const frame = await json(base + "/api/observer");
    const { appendFile } = await import("node:fs/promises");
    await appendFile(
      resolve(root, pointer.directory, "markers.ndjson"),
      JSON.stringify({
        markedAt: new Date().toISOString(),
        gameTime: frame.sample?.gameTime?.value ?? null,
        note,
      }) + "\n",
    );
    console.log(JSON.stringify({ directory: pointer.directory, markerSaved: true }));
  }
} else {
  if (args.length > 1) throw Error("Use npm run capture:collector -- <duration-ms>");
  const durationMs = Number(args[0] ?? 10800000);
  if (!Number.isInteger(durationMs) || durationMs < 5000 || durationMs > 14400000)
    throw Error("Duration must be 5000..14400000 ms");
  const provider = await json(base + "/api/providers");
  if (provider.collector?.observerIntervalMs !== COLLECTOR_SAMPLE_INTERVAL_MS)
    throw Error(
      "Backend chưa hỗ trợ nhịp 500ms. Khởi động lại backend từ workspace đã build trước khi ghi.",
    );
  if (
    provider.selected !== "collector-accountless" ||
    provider.output !== "collector-accountless" ||
    provider.collector?.runtime.status !== "running" ||
    !provider.collector.runtime.owned ||
    provider.collector.runtime.withoutAccount !== true ||
    provider.collector.runtime.credentialConfigured !== false
  )
    throw Error("Select owned Collector không tài khoản LB and turn demo off first");
  const port = provider.collector.runtime.port;
  if (!Number.isInteger(port) || port < 1024 || port > 65535) throw Error("Invalid loopback port");
  const authUrl = `http://127.0.0.1:${port}/api/status`;
  const authOk = (s: any) =>
    s.authentication?.state === "not-configured" &&
    s.authentication?.signedResponses === 0 &&
    s.authentication?.features?.length === 0;
  if (!authOk(await json(authUrl))) throw Error("Accountless authentication state not verified");
  const startedAt = new Date().toISOString(),
    id = startedAt.replaceAll(":", "-").replace(".", "-"),
    folder = resolve(root, id);
  await mkdir(root, { recursive: true });
  await mkdir(folder);
  const pointer = resolve(root, "active-collector.json");
  try {
    const p = JSON.parse(await readFile(pointer, "utf8"));
    if (Date.now() - Date.parse(p.updatedAt) < 20000) throw Error("capture-already-active");
  } catch (e) {
    if ((e as Error).message === "capture-already-active") throw e;
  }
  const report: any = {
    version: 1,
    kind: "collector-match-capture",
    id,
    startedAt,
    updatedAt: startedAt,
    state: "recording",
    requestedDurationMs: durationMs,
    source: "collector-accountless",
    nativeFrames: 0,
    observerFrames: 0,
    observerTargetIntervalMs: COLLECTOR_SAMPLE_INTERVAL_MS,
    referenceTargetIntervalMs: COLLECTOR_SAMPLE_INTERVAL_MS,
    observerMaxGapMs: 0,
    observerLateIntervals: 0,
    referenceFrames: 0,
    connections: 0,
    disconnects: 0,
    invalidMessages: 0,
    sequenceGaps: 0,
    firstGameTime: null,
    lastGameTime: null,
    firstNativeAt: null,
    lastNativeAt: null,
    stopReason: null,
    errors: [],
    fullMatchVerified: false,
    fullTelemetryVerified: false,
    privacy:
      "Gameplay, player names and original game/network IDs preserved locally by user request. Authentication fields redacted. No LCU or provider auth calls.",
    files: [
      "collector-native.ndjson.gz",
      "observer-samples.ndjson",
      "riot-reference.ndjson.gz",
      "markers.ndjson",
    ],
  };
  let stopped = false,
    reason = "duration",
    notifyStop = () => {};
  const done = new Promise<void>((r) => (notifyStop = r));
  const stop = (why: string) => {
    if (stopped) return;
    stopped = true;
    reason = why;
    notifyStop();
  };
  process.once("SIGINT", () => stop("operator"));
  process.once("SIGTERM", () => stop("operator"));
  const timeout = setTimeout(() => stop("duration"), durationMs);
  const outputs: any[] = [];
  function output(name: string, gzip = false) {
    const file = createWriteStream(resolve(folder, name), { flags: "wx" });
    const input = gzip ? createGzip() : file;
    if (gzip) input.pipe(file);
    outputs.push({ input, file });
    file.on("error", () => stop("write-error"));
    input.on("error", () => stop("write-error"));
    return input;
  }
  const nativeOut = output("collector-native.ndjson.gz", true),
    sampleOut = output("observer-samples.ndjson"),
    referenceOut = output("riot-reference.ndjson.gz", true);
  const privacy = capturePrivacy();
  const sockets = new Set<WebSocket>(),
    retries = new Set<ReturnType<typeof setTimeout>>();
  let lastSequence: number | null = null;
  let lastObserverAt: number | null = null;
  function write(out: any, record: unknown, ws?: WebSocket) {
    if (stopped) return;
    const ready = out.write(JSON.stringify(record) + "\n");
    if (!ready && ws) {
      ws.pause();
      out.once("drain", () => {
        if (!stopped && ws.readyState === WebSocket.OPEN) ws.resume();
      });
    }
  }
  function connect(kind: "native" | "app") {
    if (stopped) return;
    const ws = new WebSocket(
      kind === "native"
        ? `ws://127.0.0.1:${port}/ws`
        : base.replace("http", "ws") + "/ws?role=overlay",
      {
        ...(kind === "app" ? { origin: base } : {}),
        handshakeTimeout: 2500,
        maxPayload: 16 * 1024 * 1024,
      },
    );
    sockets.add(ws);
    ws.on("open", () => report.connections++);
    ws.on("error", () => {});
    ws.on("message", (b) => {
      if (stopped) return;
      try {
        const raw = JSON.parse(b.toString()),
          receivedAt = new Date().toISOString();
        if (kind === "native") {
          if (
            raw.schemaVersion !== 1 ||
            raw.source !== "lblib" ||
            raw.synthetic !== false ||
            raw.recordedAt !== null ||
            !["snapshot", "status"].includes(raw.type) ||
            !Number.isSafeInteger(raw.sequence)
          )
            return;
          if (lastSequence !== null && raw.sequence > lastSequence + 1)
            report.sequenceGaps += raw.sequence - lastSequence - 1;
          lastSequence = raw.sequence;
          write(nativeOut, { receivedAt, message: privacy(raw) }, ws);
          report.nativeFrames++;
          report.firstNativeAt ??= receivedAt;
          report.lastNativeAt = receivedAt;
          if (raw.type === "snapshot" && typeof raw.data?.gameTime === "number") {
            report.firstGameTime ??= raw.data.gameTime;
            report.lastGameTime = raw.data.gameTime;
          }
        } else {
          if (raw.type !== "observer") return;
          const f = observerFrameSchema.safeParse(raw.frame);
          if (
            !f.success ||
            !f.data.sample ||
            f.data.playback ||
            f.data.sample.gameTime.source !== "league-collector"
          )
            return;
          const events = new Map(
            [...f.data.sample.events, ...f.data.newEvents].map((e) => [
              `${e.id}:${e.at}:${e.kind}`,
              e,
            ]),
          );
          const sample = ingameSampleSchema.parse({
            ...f.data.sample,
            events: [...events.values()],
          });
          write(sampleOut, { receivedAt, message: { type: "collector-sample", sample } }, ws);
          report.observerFrames++;
          const receivedMs = Date.parse(receivedAt);
          if (lastObserverAt !== null) {
            const gap = receivedMs - lastObserverAt;
            report.observerMaxGapMs = Math.max(report.observerMaxGapMs, gap);
            if (gap > 750) report.observerLateIntervals++;
          }
          lastObserverAt = receivedMs;
        }
      } catch {
        report.invalidMessages++;
      }
    });
    ws.on("close", () => {
      sockets.delete(ws);
      report.disconnects++;
      if (!stopped) {
        const timer = setTimeout(() => {
          retries.delete(timer);
          connect(kind);
        }, 750);
        retries.add(timer);
      }
    });
  }
  async function checkpoint() {
    report.updatedAt = new Date().toISOString();
    await writeFile(resolve(folder, "manifest.json.tmp"), JSON.stringify(report, null, 2));
    await rename(resolve(folder, "manifest.json.tmp"), resolve(folder, "manifest.json"));
    await writeFile(pointer, JSON.stringify({ directory: id, updatedAt: report.updatedAt }));
  }
  await checkpoint();
  console.log(
    JSON.stringify({
      recording: true,
      directory: folder,
      stop: "Ctrl+C after match +15 seconds",
      native: "full schema stream, compressed and privacy filtered",
    }),
  );
  connect("native");
  connect("app");
  const poll = async () => {
    while (!stopped) {
      const pollStarted = performance.now();
      try {
        await access(resolve(folder, "stop.request"));
        stop("operator");
        break;
      } catch {}
      try {
        const [p, a, ref] = await Promise.all([
          json(base + "/api/providers"),
          json(authUrl),
          getLocal("capture-reference", "/liveclientdata/allgamedata"),
        ]);
        if (p.selected !== "collector-accountless" || p.output !== "collector-accountless")
          stop("provider-changed");
        else if (!authOk(a)) stop("auth-state-changed");
        if (!stopped && ref.probe.status === "ok") {
          const sample = normalizeIngame(ref.data, {}, new Date().toISOString());
          write(referenceOut, {
            receivedAt: new Date().toISOString(),
            message: privacy(ref.data),
            sample,
          });
          report.referenceFrames++;
        } else if (!stopped) report.referenceUnavailable = (report.referenceUnavailable ?? 0) + 1;
        await checkpoint();
      } catch {
        report.localUnavailable = (report.localUnavailable ?? 0) + 1;
      }
      if (!stopped)
        await new Promise((r) =>
          setTimeout(r, remainingSampleDelay(performance.now() - pollStarted)),
        );
    }
  };
  const polling = poll();
  await done;
  clearTimeout(timeout);
  for (const t of retries) clearTimeout(t);
  for (const ws of sockets) ws.terminate();
  await polling;
  await Promise.all(
    outputs.map(
      ({ input, file }) =>
        new Promise<void>((r) => {
          if (file.closed) {
            r();
            return;
          }
          file.once("close", r);
          input.end();
        }),
    ),
  );
  report.state = reason === "write-error" ? "failed" : "stopped";
  report.stopReason = reason;
  report.finishedAt = new Date().toISOString();
  await checkpoint();
  try {
    const p = JSON.parse(await readFile(pointer, "utf8"));
    if (p.directory === id) await unlink(pointer);
  } catch {}
  console.log(
    JSON.stringify({
      directory: folder,
      state: report.state,
      stopReason: reason,
      nativeFrames: report.nativeFrames,
      observerFrames: report.observerFrames,
      referenceFrames: report.referenceFrames,
      sequenceGaps: report.sequenceGaps,
    }),
  );
  if (report.state === "failed") process.exitCode = 1;
}
