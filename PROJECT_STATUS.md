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

## Đầu ra phát sóng

Thanh điểm số: cụm logo/tên sát hai mép hơn, chừa đủ chỗ cho tên 5 ký tự.
Mỗi đội có mô tả/thứ hạng riêng trong cấu hình; đổi bên mang theo mô tả.
Không dùng tên giải làm nhãn phụ. Để trống mô tả thì tên dùng toàn chiều cao.
Theme cũ vẫn đọc được, không tự ghi đè cấu hình cá nhân.

Đã bỏ nhãn bản ghi/kiểm thử, nhãn kích hoạt thử và ghi chú dữ liệu mẫu khỏi
graphic. Studio vẫn báo nguồn đang dùng và cảnh báo; không đổi provenance
hoặc tự biến bộ mẫu thành dữ liệu thật.

## Postgame và các phần tạm hoãn

**Postgame đã mở khóa, hướng replay `.rofl` (17/10/2026):** backend yêu cầu client tải replay sau trận (chưa
kiểm chứng với spectator), theo dõi thư mục Replays và `.npm-cache/rofl-inbox`, đọc metadata cuối file và đưa vào
vùng duyệt. Phân tích file mẫu VN2-1607368559: damage, KDA, vàng, trụ, Baron, Sứ giả, Sâu, winner, bot; thiếu vị
trí, cấm chọn, lịch sử vàng, rồng. Khóa lại bằng `RIOT_OVERLAY_POSTGAME=0`. Chi tiết: docs/POSTGAME_DATA_FINDINGS.md.

- LCU trả đủ damage/KDA/vàng cho trận custom 1607368559 khi dùng tài khoản
  người tham gia. Đổi sang spectator: history không có trận, detail/timeline 404.
- ROFL đọc được damage của 10 người, khớp LCU. Người dùng xác nhận file do
  tài khoản Seotoww tải trước đó. **Tạm hoãn hướng ROFL**, chưa làm import hoặc
  coi đây là nguồn tự động cho spectator. Elder counter còn lệch với raw.
- Riot API (Standard/RSO) và LCU EOG đã gỡ khỏi project (18/10/2026) sau khi chốt hướng replay `.rofl`;
  mã cũ còn trong lịch sử Git.
- Damage theo combat, một số champion stack, end-game tự động và draft live
  chưa hoàn tất. Không bù dữ liệu thiếu bằng mock.
- Ẩn riêng dấu 18+ VNG đang nghiên cứu. REA và Valorant giữ riêng, không
  nằm trong bản vận hành LoL này.

- 17/10: đo game 1608102102: spectator không nhận EOG; chỉ client người tham gia có. Số đo giữ ở
  [postgame](docs/POSTGAME_DATA_FINDINGS.md); hướng vận hành là replay `.rofl`.

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

## Cấu trúc 17/10/2026

Thư mục `Collector/` đổi thành `collector/` với `hosts/` (source native), `bundles/` (bản build kèm runtime), `supervisor/`. `scripts/` chia thành assets, capture, inspect, verify, dev. Đã thêm Prettier (`npm run format`). Các tài liệu trong `docs/history/` giữ đường dẫn cũ. Chưa build lại host C# tại máy này; manifest và build script của host giữ nguyên.
