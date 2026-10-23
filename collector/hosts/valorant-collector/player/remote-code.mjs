// Giải mã code ngắn player nhập. Bản JS thuần cho runtime player (chạy bằng node, không qua tsx).
// GIỮ ĐỒNG BỘ với shared/valorant-remote.ts (bản TypeScript dùng ở server/UI).
const fromBase64Url = (code) =>
  Buffer.from(code.trim().replace(/-/g, "+").replace(/_/g, "/"), "base64").toString("utf8");

export function decodeJoinCode(code) {
  try {
    const parsed = JSON.parse(fromBase64Url(code));
    if (!Array.isArray(parsed)) return null;
    const [origin, groupCode, key] = parsed;
    if (typeof origin !== "string" || !/^https?:\/\/[A-Za-z0-9.-]+(?::\d+)?$/.test(origin)) return null;
    if (typeof groupCode !== "string" || !/^[A-Z0-9_-]{1,32}$/.test(groupCode)) return null;
    if (typeof key !== "string" || !/^[a-f0-9]{16,128}$/.test(key)) return null;
    return { origin, groupCode, key };
  } catch {
    return null;
  }
}
