// Link đẩy cam vdo.ninja cho player. GIỮ ĐỒNG BỘ với shared/valorant-remote.ts (playercamPushUrl):
// overlay kéo cam bằng vdo.ninja/?room=<id>&view=<Tên>_H_<Tag>, nên stream id phải khớp từng ký tự.
export function camStreamId(playerFullName) {
  const [name, tag = ""] = String(playerFullName || "").split("#");
  return `${name.trim().replaceAll(" ", "_")}_H_${tag.trim()}`;
}

export function playercamPushUrl(roomId, playerFullName) {
  const streamId = camStreamId(playerFullName);
  return `https://vdo.ninja/?room=${encodeURIComponent(roomId)}&push=${encodeURIComponent(
    streamId,
  )}&webcam&noaudio&quality=2&codec=h264`;
}

/** Kiểm tra Riot ID trước khi dựng link đẩy cam; trả thông báo lỗi hoặc null. */
export function streamIdProblem(playerFullName) {
  const text = String(playerFullName || "").trim();
  if (!text) return "Chưa biết Riot ID của bạn (chờ client đọc từ trận, hoặc nhập tay).";
  if (!text.includes("#")) return "Riot ID phải có dạng Tên#Tag, ví dụ Seotoww#2013.";
  return null;
}
