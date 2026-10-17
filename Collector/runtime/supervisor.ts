import { spawn, type ChildProcess } from "node:child_process";
import { access, readFile } from "node:fs/promises";
import { createHash, randomBytes } from "node:crypto";
import { createServer } from "node:net";
import http from "node:http";
import { resolve } from "node:path";
import { accountlessEnvironment } from "./accountless-environment";
import {
  collectorSafety,
  type SafetyDecision,
} from "../../server/collector-safety";

type Status =
  "stopped" | "starting" | "running" | "external" | "failed" | "conflict";
export class CollectorRuntime {
  private child?: ChildProcess;
  private pending?: Promise<void>;
  private stopping?: Promise<void>;
  private token = "";
  private state: Status = "stopped";
  private error: string | null = null;
  private desired = false;
  private credentialConfigured = false;
  private generation = 0;
  readonly port: number;
  private external: boolean;
  private root: string;
  private autoInject: boolean;
  private withoutAccount: boolean;
  private safety: () => Promise<SafetyDecision>;
  private safetyTimer?: ReturnType<typeof setTimeout>;
  constructor(
    options: {
      port?: number;
      external?: boolean;
      root?: string;
      autoInject?: boolean;
      withoutAccount?: boolean;
      safety?: () => Promise<SafetyDecision>;
    } = {},
  ) {
    this.port = options.port ?? 18799;
    if (!Number.isInteger(this.port) || this.port < 1024 || this.port > 65535)
      throw Error("Invalid collector port");
    this.external = options.external ?? false;
    this.root = resolve(options.root ?? process.cwd());
    this.autoInject = options.autoInject ?? true;
    this.withoutAccount = options.withoutAccount ?? false;
    this.safety = options.safety ?? (() => collectorSafety.check());
  }
  snapshot() {
    return {
      status: this.state,
      error: this.error,
      owned: !!this.child,
      credentialConfigured: this.credentialConfigured,
      withoutAccount: this.withoutAccount,
      port: this.port,
    };
  }
  async setEnabled(enabled: boolean) {
    this.desired = enabled;
    if (!enabled) {
      await this.stop();
      return;
    }
    const decision = await this.safety();
    if (!this.desired) return;
    if (!decision.allowed) {
      await this.stop();
      this.error = `collector-blocked-${decision.reason}`;
      return;
    }
    if (this.external) {
      this.state = this.withoutAccount ? "failed" : "external";
      this.error = this.withoutAccount
        ? "accountless-external-not-supported"
        : null;
      return;
    }
    if (this.stopping) await this.stopping;
    if (
      !this.desired ||
      this.child ||
      this.state === "failed" ||
      this.state === "conflict"
    )
      return;
    if (this.pending) return this.pending;
    this.pending = this.start().finally(() => {
      this.pending = undefined;
    });
    return this.pending;
  }
  private async start() {
    const generation = ++this.generation;
    this.state = "starting";
    this.error = null;
    let stage = "build-missing";
    try {
      if (process.platform !== "win32") {
        stage = "windows-required";
        throw Error();
      }
      const output = resolve(
        this.root,
        "Collector/src/LeagueCollector/src/LeagueCollector/bin/Release/net10.0",
      );
      const dll = resolve(output, "LeagueCollector.dll");
      await access(dll);
      stage = "native-hash-mismatch";
      if (
        createHash("sha256")
          .update(await readFile(resolve(output, "lblib.dll")))
          .digest("hex") !==
        "a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3"
      )
        throw Error();
      stage = "runtime-missing";
      let executable = resolve(
        this.root,
        "Collector/runtime/LeagueCollector/runtime/dotnet.exe",
      );
      try {
        await access(executable);
      } catch {
        executable = resolve(
          this.root,
          ".npm-cache/lb-headless/dotnet-10.0.401/dotnet.exe",
        );
        await access(executable);
      }
      let credentials = resolve(this.root, "Collector/config/collector.env");
      if (this.withoutAccount) {
        // DotEnv receives an explicitly absent path, never the real env file.
        credentials = resolve(
          this.root,
          "Collector/config/.accountless-env-must-not-exist",
        );
        stage = "accountless-env-path-not-empty";
        let absent = false;
        try {
          await access(credentials);
        } catch (e) {
          absent = (e as NodeJS.ErrnoException).code === "ENOENT";
        }
        if (!absent) throw Error();
        this.credentialConfigured = false;
      } else {
        try {
          await access(credentials);
          this.credentialConfigured = true;
        } catch {
          credentials = resolve(output, "collector.env");
          try {
            await access(credentials);
            this.credentialConfigured = true;
          } catch {
            this.credentialConfigured =
              !!process.env.LB_EMAIL && !!process.env.LB_PASSWORD;
          }
        }
        stage = "credentials-missing";
        if (!this.credentialConfigured) throw Error();
      }
      stage = "port-conflict";
      await new Promise<void>((yes, no) => {
        const probe = createServer();
        probe.once("error", no);
        probe.listen(this.port, "127.0.0.1", () =>
          probe.close((e) => (e ? no(e) : yes())),
        );
      });
      if (!this.desired || generation !== this.generation) return;
      const decision = await this.safety();
      if (!this.desired || generation !== this.generation) return;
      if (!decision.allowed) {
        this.state = "stopped";
        this.error = `collector-blocked-${decision.reason}`;
        return;
      }
      this.token = randomBytes(32).toString("hex");
      const child = spawn(
        executable,
        [
          dll,
          "--source",
          "lblib",
          "--no-lcu",
          "--port",
          String(this.port),
          "--interval",
          "100",
          ...(this.autoInject ? [] : ["--no-inject"]),
        ],
        {
          cwd: output,
          windowsHide: true,
          stdio: "ignore",
          env: {
            ...(this.withoutAccount
              ? accountlessEnvironment(process.env, credentials)
              : process.env),
            LB_CREDENTIAL_FILE: credentials,
            COLLECTOR_CONTROL_TOKEN: this.token,
            COLLECTOR_PARENT_PID: String(process.pid),
            DOTNET_CLI_TELEMETRY_OPTOUT: "1",
          },
        },
      );
      this.child = child;
      child.on("error", () => {
        if (this.child === child) {
          this.state = "failed";
          this.error = "launch-failed";
        }
      });
      child.on("exit", () => {
        if (this.child === child) {
          this.child = undefined;
          this.token = "";
          if (this.desired) {
            this.state = "failed";
            this.error = "collector-exited";
          } else this.state = "stopped";
        }
      });
      this.state = "running"; // process ownership, never telemetry readiness
      this.monitorSafety();
    } catch {
      if (generation !== this.generation) return;
      this.state = stage === "port-conflict" ? "conflict" : "failed";
      this.error = stage;
    }
  }
  private monitorSafety() {
    clearTimeout(this.safetyTimer);
    if (!this.child || !this.desired) return;
    this.safetyTimer = setTimeout(async () => {
      const decision = await this.safety();
      if (!this.desired) return;
      if (!decision.allowed) {
        this.child?.kill();
        await this.stop();
        this.error = `collector-blocked-${decision.reason}`;
      } else this.monitorSafety();
    }, 500);
    this.safetyTimer.unref();
  }
  async stop() {
    clearTimeout(this.safetyTimer);
    this.desired = false;
    ++this.generation;
    if (this.stopping) return this.stopping;
    this.stopping = (async () => {
      if (this.pending) await this.pending;
      const child = this.child;
      if (child && child.exitCode === null) {
        const closed = new Promise<void>((yes) =>
          child.once("exit", () => yes()),
        );
        await new Promise<void>((yes) => {
          const request = http.request(
            {
              hostname: "127.0.0.1",
              port: this.port,
              path: "/internal/stop",
              method: "POST",
              headers: { "X-Collector-Control": this.token },
              timeout: 1500,
            },
            (response) => {
              response.resume();
              response.once("end", yes);
            },
          );
          request.on("error", () => yes());
          request.on("timeout", () => {
            request.destroy();
            yes();
          });
          request.end();
        });
        let timer: ReturnType<typeof setTimeout>;
        await Promise.race([
          closed,
          new Promise<void>((yes) => {
            timer = setTimeout(() => {
              if (child.exitCode === null) child.kill();
              yes();
            }, 8000);
          }),
        ]);
        clearTimeout(timer!);
      }
      this.child = undefined;
      this.token = "";
      this.state = "stopped";
      this.error = null;
    })().finally(() => {
      this.stopping = undefined;
    });
    return this.stopping;
  }
}
