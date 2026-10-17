import { WebSocket } from "ws";
import { observerFrameSchema, type ObserverFrame } from "../../shared/observer";
import { providerReportSchema } from "../../shared/providers";
import { normalizeIngame, rosterSignature } from "../../server/ingame-adapter";
import { compareCollectorReference, gamePreflight } from "./compare";

export interface ValidationIO {
  get(game: boolean, path: string): Promise<{ http: number | null; data: unknown }>;
  lbListener(): Promise<boolean | null>;
  projectBaseUrl: string;
  dataOrigin: "fixture" | "local-game-api";
  seconds: number;
  now?: () => number;
  wait?: (ms: number) => Promise<void>;
}
// Dependency injection is only for explicit fixture tests. Production CLI always
// supplies literal local endpoints and local-game-api; no command enables a fixture.
export async function validateProject(io: ValidationIO) {
  const { get, lbListener, projectBaseUrl, seconds, dataOrigin } = io;
  const now = io.now ?? Date.now;
  const wait = io.wait ?? ((ms: number) => new Promise<void>((r) => setTimeout(r, ms)));
  const url = new URL(projectBaseUrl);
  if (
    url.protocol !== "http:" ||
    url.hostname !== "127.0.0.1" ||
    !url.port ||
    Number(url.port) < 1024 ||
    url.username ||
    url.password ||
    url.pathname !== "/" ||
    url.search ||
    url.hash ||
    !Number.isInteger(seconds) ||
    seconds < 1 ||
    seconds > 120 ||
    !["fixture", "local-game-api"].includes(dataOrigin)
  )
    throw Error("Invalid validation transport/options");
  const startedAt = new Date(now()).toISOString();
  const report = {
    kind: "collector-project-live-validation",
    startedAt,
    preflight: "not-run",
    measurementScope: "preflight-only",
    dataOrigin,
    projectOwned: null as boolean | null,
    lbListenerClosed: null as boolean | null,
    lbListenerClosedAtEnd: null as boolean | null,
    samples: [] as ReturnType<typeof compareCollectorReference>[],
    shared: {
      studioFrames: 0,
      obsFrames: 0,
      pairedFrames: 0,
      equalFrames: 0,
      differingFrames: 0,
    },
    errors: [] as string[],
    rawRecorded: false,
    credentialsExported: false,
    gameManipulated: false,
    launcherStarted: false,
    fullParityVerified: false,
  };
  let studio: WebSocket | undefined, obs: WebSocket | undefined;
  let baselineReferenceSignature = "";
  let previousReferenceClock = -1;
  let lastComparedFrame = "";
  const object = (v: unknown): Record<string, unknown> =>
    v !== null && typeof v === "object" && !Array.isArray(v) ? (v as Record<string, unknown>) : {};
  try {
    const first = await get(true, "/liveclientdata/allgamedata");
    if (first.http !== 200) report.preflight = "game-api-unavailable";
    else {
      const active = await get(true, "/liveclientdata/activeplayername/");
      await wait(600);
      const second = await get(true, "/liveclientdata/allgamedata");
      report.preflight =
        second.http === 200 && active.http === 200
          ? gamePreflight(first.data, second.data, active.data)
          : "game-preflight-unavailable";
      if (report.preflight === "ready") baselineReferenceSignature = rosterSignature(second.data);
    }
    if (report.preflight === "ready") {
      const lbOpen = await lbListener();
      report.lbListenerClosed = lbOpen === null ? null : !lbOpen;
      const providers = await get(false, "/api/providers");
      const parsed = providerReportSchema.safeParse(providers.data);
      report.projectOwned =
        providers.http === 200 && parsed.success
          ? parsed.data.selected === "league-collector" &&
            parsed.data.output === "league-collector" &&
            parsed.data.collector?.runtime.owned === true &&
            parsed.data.collector.runtime.status === "running"
          : null;
      if (!report.lbListenerClosed) report.errors.push("LB-listener-not-confirmed-closed");
      if (!report.projectOwned) report.errors.push("project-owned-collector-unavailable");
      if (report.lbListenerClosed && report.projectOwned) {
        report.measurementScope =
          dataOrigin === "fixture" ? "fixture-project-comparison" : "live-project-comparison";
        const url = projectBaseUrl;
        const frames = new Map<string, { studio?: ObserverFrame; obs?: ObserverFrame }>();
        const paired = new Set<string>();
        const connect = (role: "studio" | "obs") => {
          const socket = new WebSocket(
            url.replace("http", "ws") + `/ws?role=${role === "obs" ? "overlay" : "studio"}`,
            {
              origin: url,
              handshakeTimeout: 2500,
              maxPayload: 8_000_000,
              followRedirects: false,
            },
          );
          socket.on("error", () => {
            if (!report.errors.includes("consumer-socket-error"))
              report.errors.push("consumer-socket-error");
          });
          socket.on("message", (bytes) => {
            try {
              const message = JSON.parse(bytes.toString());
              if (message.type !== "observer") return;
              const parsed = observerFrameSchema.safeParse(message.frame);
              if (
                !parsed.success ||
                parsed.data.playback ||
                parsed.data.status !== "observed" ||
                parsed.data.sample?.gameTime.source !== "league-collector"
              )
                return;
              const frame = parsed.data,
                key = `${frame.sessionId}:${frame.epoch}:${frame.sequence}`;
              const age = now() - Date.parse(frame.sample!.capturedAt);
              if (!Number.isFinite(age) || age >= 5000 || age < -1000) return;
              if (role === "studio") report.shared.studioFrames++;
              else report.shared.obsFrames++;
              const pair = frames.get(key) ?? {};
              pair[role] = frame;
              frames.set(key, pair);
              if (pair.studio && pair.obs && !paired.has(key)) {
                paired.add(key);
                report.shared.pairedFrames++;
                if (JSON.stringify(pair.studio) === JSON.stringify(pair.obs))
                  report.shared.equalFrames++;
                else report.shared.differingFrames++;
              }
              if (frames.size > 64) frames.delete(frames.keys().next().value!);
              if (paired.size > 128) paired.delete(paired.values().next().value!);
            } catch {
              if (!report.errors.includes("consumer-invalid-json"))
                report.errors.push("consumer-invalid-json");
            }
          });
          return socket;
        };
        studio = connect("studio");
        obs = connect("obs");
        const deadline = now() + seconds * 1000;
        while (now() < deadline) {
          const currentProviders = await get(false, "/api/providers");
          const current = providerReportSchema.safeParse(currentProviders.data);
          if (
            currentProviders.http !== 200 ||
            !current.success ||
            current.data.selected !== "league-collector" ||
            current.data.output !== "league-collector" ||
            current.data.collector?.runtime.owned !== true ||
            current.data.collector.runtime.status !== "running"
          ) {
            report.errors.push("project-provider-changed-or-stopped");
            break;
          }
          const candidate = await get(false, "/api/observer");
          const reference = await get(true, "/liveclientdata/allgamedata");
          const frame = observerFrameSchema.safeParse(candidate.data);
          if (reference.http !== 200) {
            report.errors.push("game-api-lost");
            break;
          }
          const referenceSample = normalizeIngame(
            reference.data,
            {},
            new Date(now()).toISOString(),
          );
          const referenceClock = referenceSample.gameTime.value;
          const rawEvents = object(object(reference.data).events).Events;
          if (
            referenceSample.mapNumber?.value !== 11 ||
            referenceSample.players.length !== 10 ||
            referenceSample.limits.playersTruncated ||
            !Array.isArray(rawEvents) ||
            rawEvents.some((e) => object(e).EventName === "GameEnd") ||
            referenceSample.events.some((e) => e.kind === "GameEnd") ||
            rosterSignature(reference.data) !== baselineReferenceSignature ||
            referenceClock === null ||
            referenceClock < previousReferenceClock - 0.05
          ) {
            report.errors.push("game-session-ended-or-changed");
            break;
          }
          previousReferenceClock = referenceClock;
          if (
            candidate.http === 200 &&
            frame.success &&
            frame.data.status === "observed" &&
            !frame.data.playback &&
            frame.data.sample &&
            `${frame.data.sessionId}:${frame.data.epoch}:${frame.data.sequence}` !==
              lastComparedFrame
          ) {
            lastComparedFrame = `${frame.data.sessionId}:${frame.data.epoch}:${frame.data.sequence}`;
            report.samples.push(
              compareCollectorReference(frame.data.sample, referenceSample, now()),
            );
          }
          await wait(750);
        }
        if (!report.samples.length) report.errors.push("no-live-comparisons");
        if (!report.samples.some((s) => s.aligned && s.rosterMatches === 10))
          report.errors.push("no-aligned-roster-comparisons");
        if (
          !report.samples.some(
            (s) =>
              s.aligned &&
              s.rosterMatches === 10 &&
              (["level", "kills", "deaths", "assists", "items"] as const).every(
                (key) => s.fields[key].compared === 10,
              ),
          )
        )
          report.errors.push("no-complete-core-comparison");
        if (report.samples.some((s) => Object.values(s.fields).some((f) => f.disagreed > 0)))
          report.errors.push("field-disagreements-observed");
        if (!report.shared.pairedFrames) report.errors.push("no-shared-consumer-frames");
        if (report.shared.differingFrames) report.errors.push("consumer-frame-disagreement");
        const lbAtEnd = await lbListener();
        report.lbListenerClosedAtEnd = lbAtEnd === null ? null : !lbAtEnd;
        if (!report.lbListenerClosedAtEnd)
          report.errors.push("LB-listener-present-or-unverified-at-end");
      }
    }
  } catch {
    report.errors.push("validation-failed");
  } finally {
    studio?.terminate();
    obs?.terminate();
  }

  return report;
}
