# Kiểm thử bản nội bộ

Ngày 17/10/2026. Backend test dùng port/theme riêng, không sửa cấu hình cá nhân
hoặc raw capture. Test nguồn dùng fixture; không khởi động DLL native trong trận.

## Kết quả

| Bài kiểm tra | Kết quả |
| --- | --- |
| npm run build | Đạt TypeScript và Vite |
| npm test | 222 bài: 221 đạt, 1 bỏ qua |
| npm run test:integration | Đạt backend, scene, theme, API, transport Studio/OBS |
| npm run test:collector | Đạt nhận dữ liệu, ngắt/chuyển nguồn, chốt player/mất xác nhận và kết nối lại |
| npm run test:collector-capture | Đạt ghi native/Riot/observer, lọc secrets, marker, dừng và đóng gzip |
| npm run test:collector-validation | Đạt 10 tình huống thành công/lỗi nguồn |

Một unit bỏ qua vì thiếu bản ghi phòng tập cũ lb-2026-10-11T09-07-37-947Z.
System integration bỏ qua
nhánh bản ghi cũ không có sẵn tại đường dẫn mà bài đó yêu cầu; không bỏ qua
nhánh gate hoặc tự tạo bản ghi thay thế.

Build còn cảnh báo từ thư viện về use client, annotation và kích thước bundle.
Không có lỗi TypeScript/build. Chưa tối ưu chia bundle trong lần bàn giao này.

## Chốt collector

- Tên active player thật chặn dù có mode replay/spectator hoặc Replay API clock.
- Unknown/Spectator không đủ nếu thiếu bằng chứng chế độ; API lỗi cũng chặn.
- Runtime không spawn host khi bị chặn. Test watchdog dùng child giả, xác
  nhận kết thúc child và bỏ quyền sở hữu khi chuyển thành player.
- Integration chuyển spectator sang player/mất xác nhận: ngắt socket, bỏ
  frame cho cả Studio và OBS, rồi kết nối lại khi spectator được xác nhận.
- Cả collector có tài khoản và không tài khoản dùng cùng chốt. Không có
  config/biến môi trường bỏ qua trong ứng dụng.

Probe chỉ đọc trên máy hiện tại trả unverified, collector không được mở.
Chưa có phiên game thật mới để xác nhận các chuyển trạng thái trên máy người
vận hành. Giữ guard native hiện có, không dùng fixture làm bằng chứng game thật.

## Kiểm tra giao diện

Bản ghi projection 10, 1920 × 1080, Edge headless, backend QA riêng.
Kiểm đủ bốn biến thể có cam/không cam và đầy đủ/tối giản bằng
scripts/verify-atlas-xp.mjs --assert. Kiểm XP/HP/resource cùng chiều rộng,
tâm vòng/glyph lane quest và quantity đồ hỗ trợ. Kiểm không còn nhãn bản ghi,
kích hoạt thử hoặc giả lập UI trên đầu ra.

Draft đã chạy lại smoke 20 lượt, hover/lock/undo/skip/swap, hai layout, giảm
chuyển động, asset/font và vùng cam trong suốt. Chi tiết giữ trong
[nhật ký kiểm thử](docs/history/TEST_REPORT_2026-10-17.md).

## Giới hạn còn lại

Chưa thử toàn trận spectator live mới. LCU/ROFL custom và Riot API key chưa
thành luồng postgame tự động; ROFL đã tạm hoãn. Không có kết luận độ giống
95–98% toàn bộ UI. DLL/runtime/cache collector không nằm trong Git, máy mới
cần chuẩn bị riêng trước khi thử live.

Log và ảnh QA nằm trong .npm-cache, không đưa lên Git. Không xóa captures,
credentials hoặc theme cá nhân khi dọn bản nội bộ.
