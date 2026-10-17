# Trạng thái bàn giao

Cập nhật 17/10/2026. Bản hiện tại chuẩn bị dùng nội bộ trên Windows, chạy
bằng terminal. Giữ bố cục draft/in-game đã duyệt, không mở lại vòng thiết kế.

## Đã có

- Studio dùng shadcn, tách cấu hình trận, nguồn dữ liệu, phát sóng, phòng thử,
  cấm chọn, sau trận và HUD.
- Layout có cam/không cam, đầy đủ/tối giản; leaderboard vàng và XP đủ 10 người;
  rune, lane quest, cooldown, stack và counter đồ theo dữ liệu đã có.
- Timer rồng đọc quái sống hoặc Dragon Indicator trong frame hiện tại.
  Không đoán loại rồng tiếp theo từ lịch sử hạ rồng. Thiếu nguồn thì giữ unknown.
- Thứ tự Top, Jungle, Mid, Bot, Support từ role quest quan sát được; không
  đổi slot gốc. Ẩn số Atlas 3865, giữ số của các đồ hỗ trợ đã nâng cấp.
- Timer mục tiêu thu phần số khi về 0; icon có nền theo loại. XP, HP và
  resource cùng chiều rộng. Icon lane quest đã sửa tâm vòng và tâm glyph.
- Animation draft theo lượt/hover/khóa, không chạy lại khi timer tick.
- Bản ghi hiện hành là projection 10 từ raw ngày 16/10, có 1.525 mẫu.
  Raw và các projection trước được giữ nguyên, không theo Git.

## Chốt an toàn collector

Không khởi động collector khi đang là người chơi hoặc chưa xác nhận được
spectator/replay. Có clock Replay API hoặc tên active player là Unknown chưa
đủ để cho phép. Chốt kiểm tra trước khi mở host, trước khi kết nối/đọc nguồn
live và kiểm tra lại trong lúc chạy. Khi bị chặn, Studio/OBS bỏ frame live,
ngắt socket và dừng host do ứng dụng quản lý. Capture cũng có chốt riêng.

Không có config bỏ qua. Bản ghi đã lưu và điều khiển draft vẫn dùng được.
Chỉ trả về trạng thái/lý do; không xuất command line, tên active player hoặc
credentials. Chi tiết: [COLLECTOR_SAFETY](docs/COLLECTOR_SAFETY.md).

## Đầu ra phát sóng

Đã bỏ nhãn bản ghi/kiểm thử, nhãn kích hoạt thử và ghi chú dữ liệu mẫu khỏi
graphic. Studio vẫn báo nguồn đang dùng và cảnh báo; không đổi provenance
hoặc tự biến bộ mẫu thành dữ liệu thật.

## Postgame và các phần tạm hoãn

- LCU trả đủ damage/KDA/vàng cho trận custom 1607368559 khi dùng tài khoản
  người tham gia. Đổi sang spectator: history không có trận, detail/timeline 404.
- ROFL đọc được damage của 10 người, khớp LCU. Người dùng xác nhận file do
  tài khoản Seotoww tải trước đó. **Tạm hoãn hướng ROFL**, chưa làm import hoặc
  coi đây là nguồn tự động cho spectator. Elder counter còn lệch với raw.
- Standard API key đã thử: custom 404, trận thường đối chứng 403. Chưa xác
  nhận được quyền truy cập Match-V5 của key hiện tại.
- Damage theo combat, một số champion stack, end-game tự động và draft live
  chưa hoàn tất. Không bù dữ liệu thiếu bằng mock.
- Ẩn riêng dấu 18+ VNG đang nghiên cứu. REA và Valorant giữ riêng, không
  nằm trong bản vận hành LoL này.

Chi tiết: [LCU](docs/LCU_POSTGAME_FINDINGS.md),
[ROFL](docs/ROFL_POSTGAME_FINDINGS.md), [postgame](docs/POSTGAME_DATA_FINDINGS.md).

## Cài và chuyển máy

Tài liệu cài đặt, kiến trúc, kiểm thử và nghiên cứu đã gom vào docs/;
gốc chỉ giữ README.md, AGENTS.md và PROJECT_STATUS.md. Ảnh tham chiếu dùng
bản trong public/references, Baron SVG dùng bản trong public/broadcast.
Đã bỏ các bản trùng ở gốc và baron-white.png không có tham chiếu sử dụng.
Không xóa ảnh mẫu trong images/, dữ liệu trận hoặc tài liệu REA/Valorant.

Làm theo [SETUP_VI.md](docs/SETUP_VI.md). Git không chứa credentials, theme cá nhân,
captures, DLL/runtime/cache collector hoặc vendor source. Máy mới cần được
chuẩn bị runtime riêng nếu dùng collector tích hợp. Backend chỉ bind loopback,
không triển khai LAN/public. Chưa phải bộ cài độc lập.

## Kiểm chứng và bước tiếp

Kết quả các bài kiểm tra được ghi trong [TEST_REPORT.md](docs/TEST_REPORT.md).
Gate được kiểm bằng fixture cho player, spectator, replay, mất xác nhận và
chuyển trạng thái trong lúc chạy. Cần thêm một phiên spectator live để kiểm
đầu cuối trên máy vận hành; không coi fixture là test game thật.

Sau bản nội bộ: thử toàn trận spectator, kiểm chốt khi chuyển chế độ, rồi
mới mở lại nguồn postgame custom. Không sửa layout baseline nếu không có
yêu cầu mới.

[Nhật ký các mốc trước](docs/history/PROJECT_STATUS_2026-10-17.md) giữ các
số đo, bản ghi và quyết định cũ để tra cứu.
