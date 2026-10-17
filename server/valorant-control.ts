import { readFile } from "node:fs/promises";
import { resolve } from "node:path";
import { valorantCommandSchema } from "../shared/valorant";

export type ControlOutcome = { ok: boolean; error?: string };

/**
 * Chuyển lệnh thủ công của Spectra tới Client fork qua cổng loopback.
 * Port/token nằm trong runtime/headless.json do module Valorant ghi mỗi lần chạy; không bao giờ trả về trình duyệt.
 */
export async function sendValorantCommand(
  input: unknown,
  options: { runtimePath?: string; fetcher?: typeof fetch } = {},
): Promise<ControlOutcome> {
  const parsed = valorantCommandSchema.safeParse(input);
  if (!parsed.success) return { ok: false, error: "invalid-command" };
  let port: number, token: string;
  try {
    const path = options.runtimePath ?? resolve("data/valorant/runtime/headless.json");
    const config = JSON.parse(await readFile(path, "utf8"));
    port = Number(config.controlPort);
    token = String(config.controlToken ?? "");
    if (!Number.isInteger(port) || !token) throw Error();
  } catch {
    return { ok: false, error: "client-not-managed" };
  }
  try {
    const res = await (options.fetcher ?? fetch)(`http://127.0.0.1:${port}/command`, {
      method: "POST",
      headers: { Authorization: `Bearer ${token}`, "Content-Type": "application/json" },
      body: JSON.stringify(parsed.data),
      signal: AbortSignal.timeout(2500),
    });
    const body = (await res.json().catch(() => ({}))) as ControlOutcome;
    return res.ok ? { ok: true } : { ok: false, error: String(body.error ?? `http-${res.status}`) };
  } catch {
    return { ok: false, error: "client-unreachable" };
  }
}
