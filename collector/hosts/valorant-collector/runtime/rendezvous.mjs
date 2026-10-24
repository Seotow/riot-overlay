// Code ngắn (<6 ký tự) để player tự phân giải ra địa chỉ ingest của host.
//
// Tunnel cloudflared quick đổi URL mỗi lần chạy, nên code KHÔNG thể chứa sẵn origin. Host công bố
// { origin, groupCode, camRoom } lên một điểm hẹn công khai, topic suy ra từ chính code; player
// đọc lại đúng topic đó. Code chỉ là chìa khoá tra cứu, không mang dữ liệu.
//
// Mặc định dùng ntfy.sh (pub/sub công khai, không cần tài khoản). Đổi điểm hẹn bằng biến môi
// trường RIOT_OVERLAY_RENDEZVOUS (ví dụ server ntfy tự dựng: https://ntfy.example.com).
//
// Bảo mật: topic công khai, ai biết code đều đọc được origin + group code + room cam. Code là bí
// mật chia sẻ riêng tư; payload KHÔNG chứa auth.key (chế độ auxiliary của Client không cần key).
import { randomInt } from "node:crypto";

export const RENDEZVOUS_VERSION = 1;
export const TOPIC_PREFIX = "riotovl-";
// Bỏ các ký tự dễ đọc nhầm khi đọc qua điện thoại/voice: 0 1 I L O.
export const CODE_ALPHABET = "23456789ABCDEFGHJKMNPQRSTUVWXYZ";
export const CODE_LENGTH = 5;
export const VALIDITY_SECONDS = 12 * 60 * 60;

const ORIGIN_RE = /^https?:\/\/[A-Za-z0-9.-]+(?::\d{1,5})?$/;
const GROUP_RE = /^[A-Z0-9_-]{1,32}$/;
const ROOM_RE = /^[A-Za-z0-9_-]{0,64}$/;

export const rendezvousService = () =>
  (process.env.RIOT_OVERLAY_RENDEZVOUS || "https://ntfy.sh").replace(/\/+$/, "");

/** Sinh code mới. Dùng randomInt của crypto để không phụ thuộc Math.random của caller. */
export function newCode(length = CODE_LENGTH, random = () => randomInt(CODE_ALPHABET.length)) {
  let code = "";
  for (let i = 0; i < length; i++) code += CODE_ALPHABET[Math.floor(random()) % CODE_ALPHABET.length];
  return code;
}

/** Chuẩn hoá code người dùng dán vào: bỏ khoảng trắng/gạch, viết hoa; sai bảng chữ thì trả null. */
export function normalizeCode(raw, length = CODE_LENGTH) {
  if (typeof raw !== "string") return null;
  const code = raw.toUpperCase().replace(/[\s_-]/g, "");
  if (code.length !== length) return null;
  for (const character of code) if (!CODE_ALPHABET.includes(character)) return null;
  return code;
}

/** Topic điểm hẹn của một code. Ném lỗi nếu code sai để không âm thầm đăng lên topic rỗng. */
export function topicFor(code) {
  const normalized = normalizeCode(code);
  if (!normalized) throw new Error(`Code không hợp lệ: ${JSON.stringify(code)}`);
  return `${TOPIC_PREFIX}${normalized.toLowerCase()}`;
}

/** Payload host công bố. Trả về thông báo lỗi (chuỗi) hoặc null nếu hợp lệ. */
export function validatePayload(value) {
  if (!value || typeof value !== "object" || Array.isArray(value)) return "payload không phải object";
  if (value.v !== RENDEZVOUS_VERSION) return `payload version không hỗ trợ: ${value.v}`;
  if (typeof value.origin !== "string" || !ORIGIN_RE.test(value.origin))
    return "origin không hợp lệ (phải là http(s)://host[:port])";
  if (value.groupCode !== undefined && (typeof value.groupCode !== "string" || !GROUP_RE.test(value.groupCode)))
    return "groupCode không hợp lệ";
  if (value.camRoom !== undefined && (typeof value.camRoom !== "string" || !ROOM_RE.test(value.camRoom)))
    return "camRoom không hợp lệ";
  if (value.host !== undefined && typeof value.host !== "string") return "host không hợp lệ";
  return null;
}

export function buildPayload({ origin, groupCode = "", camRoom = "", host = "" } = {}) {
  const payload = { v: RENDEZVOUS_VERSION, origin: String(origin ?? "").replace(/\/+$/, "") };
  if (groupCode) payload.groupCode = String(groupCode);
  if (camRoom) payload.camRoom = String(camRoom);
  if (host) payload.host = String(host).slice(0, 40);
  payload.at = Math.floor(Date.now() / 1000);
  const problem = validatePayload(payload);
  if (problem) throw new Error(`Payload công bố không hợp lệ: ${problem}`);
  return payload;
}

/** Công bố payload lên điểm hẹn. Trả { ok, code, topic } hoặc { ok:false, error }. */
export async function publishCode(code, payload, options = {}) {
  const service = options.service ?? rendezvousService();
  const request = options.fetch ?? fetch;
  const topic = topicFor(code);
  let response;
  try {
    response = await request(`${service}/${topic}`, {
      method: "POST",
      headers: { "Content-Type": "text/plain", Cache: "yes" },
      body: JSON.stringify(payload),
      signal: AbortSignal.timeout(options.timeout ?? 15_000),
    });
  } catch (error) {
    return { ok: false, code: normalizeCode(code), topic, error: error?.message || "unreachable" };
  }
  if (!response.ok) return { ok: false, code: normalizeCode(code), topic, error: `HTTP ${response.status}` };
  return { ok: true, code: normalizeCode(code), topic, payload };
}

/**
 * Đọc payload mới nhất của một code. Trả { code, payload, error }:
 * error = "code-invalid" | "unreachable" | "HTTP <n>" | "not-found" | null.
 */
export async function resolveCode(code, options = {}) {
  const normalized = normalizeCode(code);
  if (!normalized) return { code: null, payload: null, error: "code-invalid" };
  const service = options.service ?? rendezvousService();
  const request = options.fetch ?? fetch;
  const since = options.since ?? "12h";
  let response;
  try {
    response = await request(`${service}/${topicFor(normalized)}/json?poll=1&since=${since}`, {
      signal: AbortSignal.timeout(options.timeout ?? 15_000),
    });
  } catch (error) {
    return { code: normalized, payload: null, error: "unreachable" };
  }
  if (!response.ok) return { code: normalized, payload: null, error: `HTTP ${response.status}` };
  const text = await response.text();
  let latest = null;
  for (const line of String(text).split(/\r?\n/)) {
    const trimmed = line.trim();
    if (!trimmed) continue;
    let event;
    try {
      event = JSON.parse(trimmed);
    } catch {
      continue;
    }
    if (event?.event !== "message" || typeof event.message !== "string") continue;
    let payload;
    try {
      payload = JSON.parse(event.message);
    } catch {
      continue;
    }
    if (validatePayload(payload)) continue;
    latest = payload;
  }
  if (!latest) return { code: normalized, payload: null, error: "not-found" };
  return { code: normalized, payload: latest, error: null };
}

/** Thông báo tiếng Việt cho lỗi phân giải, dùng chung cho UI và CLI. */
export function resolveErrorMessage(error) {
  switch (error) {
    case "code-invalid":
      return `Code phải có đúng ${CODE_LENGTH} ký tự (bảng chữ: ${CODE_ALPHABET}).`;
    case "not-found":
      return "Không thấy code này. Xin host code mới — code chỉ sống vài giờ và host phải đang bật tunnel.";
    case "unreachable":
      return "Không kết nối được điểm hẹn (kiểm tra mạng máy player).";
    default:
      return `Điểm hẹn trả lỗi: ${error ?? "không rõ"}.`;
  }
}
