export type SourceCandidate = {
  id: "riot-local" | "leaguebroadcast" | "overwolf" | "screen-capture" | "authorized-feed";
  name: string;
  stage: "active" | "conditional" | "planned" | "external";
  route: string;
  coverage: string;
  requirement: string;
};

export const sourceCandidates: readonly SourceCandidate[] = [
  {
    id: "riot-local",
    name: "Riot local",
    stage: "active",
    route: "Live Client Data và Replay API",
    coverage: "10 người, tướng, cấp, KDA, CS, trang bị, phép, sự kiện và thời gian replay",
    requirement: "League đang chạy; API loopback 2999",
  },
  {
    id: "leaguebroadcast",
    name: "LeagueBroadcast",
    stage: "conditional",
    route: "WebSocket công khai của ứng dụng",
    coverage: "Nguồn production đã xác minh cho gold, HP, resource, rune, objective và telemetry đủ 10 người",
    requirement: "Bắt buộc cho production đầy đủ; cần ứng dụng, quyền tài khoản và custom spectator được hỗ trợ",
  },
  {
    id: "overwolf",
    name: "Overwolf GEP",
    stage: "planned",
    route: "Game Events Provider chính thức",
    coverage: "Sự kiện và người chơi cục bộ; không xác nhận gold, HP hoặc năng lượng của đủ 10 người",
    requirement: "Overwolf runtime và quy trình duyệt ứng dụng",
  },
  {
    id: "screen-capture",
    name: "OBS capture và OCR",
    stage: "planned",
    route: "Ảnh source OBS, chỉ đọc vùng HUD cấu hình",
    coverage: "Giá trị đang nhìn thấy như tổng vàng đội, điểm hạ gục, trụ, rồng và thời gian",
    requirement: "OBS WebSocket, source game và profile vùng ảnh theo HUD",
  },
  {
    id: "authorized-feed",
    name: "Feed giải đấu được cấp quyền",
    stage: "external",
    route: "Nhà cung cấp hoặc đối tác dữ liệu",
    coverage: "Lựa chọn phù hợp khi cần telemetry đầy đủ, chính xác cho cả 10 người",
    requirement: "Hợp đồng, quyền truy cập và điều khoản sử dụng riêng",
  },
] as const;

export const researchBoundary = {
  allowed: [
    "API loopback và Swagger do Riot cung cấp",
    "WebSocket hoặc SDK được nhà cung cấp công bố",
    "Ảnh spectator do OBS chụp và OCR vùng nhìn thấy",
    "Phân tích request, response của chính ứng dụng trên localhost khi được phép",
  ],
  excluded: [
    "Đọc bộ nhớ tiến trình game",
    "Inject DLL, hook hoặc driver kernel",
    "Can thiệp hay né Vanguard",
    "Giải mã định dạng hoặc giao thức riêng khi chưa có quyền từ Riot",
  ],
} as const;
