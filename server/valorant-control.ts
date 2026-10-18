import { valorantCommandSchema } from "../shared/valorant";
import type { ValorantController } from "./valorant-controller";

export type ControlOutcome = { ok: boolean; error?: string };

/**
 * Chuyển lệnh thủ công của Spectra (plant, pause, timeout, KDA/credits, swap, toast, cấu hình) tới trận đang chạy
 * qua controller của Studio (phiên observer thứ hai). Thiếu controller hoặc chưa nối trận thì báo not-connected.
 */
export async function sendValorantCommand(
  input: unknown,
  options: { controller?: ValorantController | null } = {},
): Promise<ControlOutcome> {
  const parsed = valorantCommandSchema.safeParse(input);
  if (!parsed.success) return { ok: false, error: "invalid-command" };
  if (!options.controller) return { ok: false, error: "not-connected" };
  return options.controller.run(parsed.data);
}
