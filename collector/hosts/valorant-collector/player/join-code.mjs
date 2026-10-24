// Phân giải thứ player dán vào: code dài (base64, có sẵn origin + key) hoặc code ngắn 5 ký tự
// (tra ở điểm hẹn để lấy origin). Dùng chung cho UI và CLI.
import { resolveCode, resolveErrorMessage } from "../runtime/rendezvous.mjs";
import { decodeJoinCode } from "./remote-code.mjs";

/**
 * Trả { kind: "long"|"short", code, origin, groupCode, key, camRoom, host }.
 * Ném lỗi có thông báo tiếng Việt khi không phân giải được.
 */
export async function resolveJoin(raw, options = {}) {
  const text = String(raw ?? "").trim();
  if (!text) throw new Error("Chưa nhập code.");

  const long = decodeJoinCode(text);
  if (long) {
    return {
      kind: "long",
      code: text,
      origin: long.origin,
      groupCode: long.groupCode,
      key: long.key,
      camRoom: "",
      host: "",
    };
  }

  const resolved = await resolveCode(text, options);
  if (resolved.error) throw new Error(resolveErrorMessage(resolved.error));
  const payload = resolved.payload;
  return {
    kind: "short",
    code: resolved.code,
    origin: payload.origin,
    groupCode: payload.groupCode ?? "",
    key: "",
    camRoom: payload.camRoom ?? "",
    host: payload.host ?? "",
  };
}
