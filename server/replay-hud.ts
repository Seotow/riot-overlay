import { request } from "node:https";
import { hudSchema, renderHudFields, type HudKey } from "../shared/replay-hud";

// Fixed local endpoint. No credentials, process injection, camera or playback writes.
export function replayRender(
  method: "GET" | "POST",
  payload?: Record<string, boolean>,
): Promise<unknown> {
  return new Promise((resolve, reject) => {
    const finish = (error?: Error, value?: unknown) => {
      clearTimeout(deadline);
      if (error) reject(error);
      else resolve(value);
    };
    let size = 0;
    const body = payload ? JSON.stringify(payload) : undefined;
    const req = request(
      {
        hostname: "127.0.0.1",
        port: 2999,
        path: "/replay/render",
        method,
        rejectUnauthorized: false,
        headers: body
          ? {
              "Content-Type": "application/json",
              "Content-Length": Buffer.byteLength(body),
            }
          : {},
      },
      (res) => {
        const chunks: Buffer[] = [];
        res.on("data", (chunk: Buffer) => {
          size += chunk.length;
          if (size > 128000) req.destroy(Error("oversize"));
          else chunks.push(chunk);
        });
        res.on("end", () => {
          if (res.statusCode !== 200) {
            finish(
              Error("Replay API không sẵn sàng hoặc không chấp nhận cấu hình."),
            );
            return;
          }
          try {
            finish(
              undefined,
              JSON.parse(Buffer.concat(chunks).toString("utf8")),
            );
          } catch {
            finish(Error("Replay API trả dữ liệu không hợp lệ."));
          }
        });
        res.on("error", (error) => finish(error));
      },
    );
    const deadline = setTimeout(
      () => req.destroy(Error("Replay API không phản hồi.")),
      2500,
    );
    req.on("error", () =>
      finish(
        Error(
          "Không kết nối được Replay API 2999. Mở replay/spectator và kiểm tra EnableReplayApi=1.",
        ),
      ),
    );
    req.end(body);
  });
}
export class ReplayHudService {
  constructor(private transport = replayRender) {}
  async status() {
    try {
      const fields = renderHudFields(await this.transport("GET"));
      return {
        connected: Object.keys(fields).length > 0,
        fields,
        checkedAt: new Date().toISOString(),
      };
    } catch (e) {
      return {
        connected: false,
        fields: {},
        message: (e as Error).message,
        checkedAt: new Date().toISOString(),
      };
    }
  }
  async apply(input: unknown) {
    const config = hudSchema.parse(input);
    const before = renderHudFields(await this.transport("GET"));
    // Do not hide groups if the current patch cannot confirm announcement controls.
    for (const key of [
      "interfaceAll",
      "interfaceReplay",
      "interfaceAnnounce",
      "interfaceKillCallouts",
    ] as const)
      if (typeof before[key] !== "boolean")
        throw Error(
          "Patch hiện tại thiếu cờ bảo vệ thông báo; chưa áp dụng HUD.",
        );
    const keys = Object.keys(config) as HudKey[];
    const supported = keys.filter((key) => typeof before[key] === "boolean");
    const patch = Object.fromEntries(
      supported.map((key) => [key, config[key]]),
    );
    await this.transport("POST", patch);
    const fields = renderHudFields(await this.transport("GET"));
    const mismatched = supported.filter((key) => fields[key] !== config[key]);
    return {
      connected: true,
      fields,
      unsupported: keys.filter((key) => !supported.includes(key)),
      mismatched,
      verified: mismatched.length === 0,
      checkedAt: new Date().toISOString(),
    };
  }
}
