// Code ngắn để player ngoài LAN nối vào ingest của host qua tunnel (cloudflared).
// Chứa origin công khai của tunnel, group code và key xác thực. Người dùng chia sẻ code này
// riêng tư cho player tin cậy (key cho phép đẩy dữ liệu vào trận).

export interface RemoteJoin {
  origin: string;
  groupCode: string;
  key: string;
}

// Toàn bộ trường là ASCII (URL, group code A-Z0-9_-, key hex) nên btoa/atob an toàn ở cả Node và trình duyệt.
const toBase64Url = (text: string) =>
  btoa(text).replace(/\+/g, "-").replace(/\//g, "_").replace(/=+$/, "");
const fromBase64Url = (code: string) => atob(code.replace(/-/g, "+").replace(/_/g, "/"));

export function encodeJoinCode(join: RemoteJoin): string {
  return toBase64Url(JSON.stringify([join.origin, join.groupCode, join.key]));
}

export function decodeJoinCode(code: string): RemoteJoin | null {
  try {
    const parsed = JSON.parse(fromBase64Url(code.trim()));
    if (!Array.isArray(parsed)) return null;
    const [origin, groupCode, key] = parsed;
    if (typeof origin !== "string" || !/^https?:\/\/[A-Za-z0-9.-]+(?::\d+)?$/.test(origin))
      return null;
    if (typeof groupCode !== "string" || !/^[A-Z0-9_-]{1,32}$/.test(groupCode)) return null;
    if (typeof key !== "string" || !/^[a-f0-9]{16,128}$/.test(key)) return null;
    return { origin, groupCode, key };
  } catch {
    return null;
  }
}

// Link đẩy cam vdo.ninja cho một player: tên hiển thị dạng <Tên>_H_<Tag> khớp với overlay.
// Overlay dựng stream id từ roster (name#tagline không có dấu cách), nên phải trim hai phần:
// GEP trả "Seotoww #2013" còn roster trả name "Seotoww" + tagline "2013".
export function playercamPushUrl(roomId: string, playerFullName: string): string {
  const [name = "", tag = ""] = playerFullName.split("#").map((part) => part.trim());
  const streamId = `${name.replaceAll(" ", "_")}_H_${tag}`;
  return `https://vdo.ninja/?room=${encodeURIComponent(roomId)}&push=${encodeURIComponent(
    streamId,
  )}&webcam&quality=2&codec=h264`;
}
