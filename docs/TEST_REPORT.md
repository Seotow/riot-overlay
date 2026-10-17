# Kiểm thử bản nội bộ

## Sau khi dọn thư mục gốc, 17/10/2026

Đã chuyển 10 tài liệu vào docs/, cập nhật liên kết và hướng dẫn AGENTS.
Hai PNG tham chiếu và Baron SVG ở gốc trùng SHA-256 với bản trong public/;
giữ bản public, bỏ bản trùng. Baron trắng không có tham chiếu sử dụng.
Script/test dùng SVG chuẩn và kiểm hash gốc để không đổi artwork.
Kiểm 14 tài liệu không có liên kết local bị thiếu. Chạy lại npm test:
221 đạt, 1 bỏ qua do thiếu bản ghi cũ; build đạt. Không thay giao diện hoặc telemetry.

Ngày 17/10/2026. Backend test dùng port/theme riêng, không sửa cấu hình cá nhân
hoặc raw capture. Test nguồn dùng fixture; không khởi động DLL native trong trận.

## Kết quả

| Bài kiểm tra | Kết quả |
| --- | --- |
| npm run build | Đạt TypeScript và Vite |
| npm test | 222 bài: 221 đạt, 1 bỏ qua |
| npm run test:integration | Đạt backend, scene, theme, API, transport Studio/OBS |
| npm run test:collector | Đạt nhận dữ liệu, ngắt/chuyển nguồn và kết nối lại |
| npm run test:collector-capture | Đạt ghi native/Riot/observer, lọc secrets, marker, dừng và đóng gzip |
| npm run test:collector-validation | Đạt 10 tình huống thành công/lỗi nguồn |

Một unit bỏ qua vì thiếu bản ghi phòng tập cũ lb-2026-10-11T09-07-37-947Z.
System integration bỏ qua
nhánh bản ghi cũ không có sẵn tại đường dẫn mà bài đó yêu cầu; không bỏ qua
nhánh gate hoặc tự tạo bản ghi thay thế.

Build còn cảnh báo từ thư viện về use client, annotation và kích thước bundle.
Không có lỗi TypeScript/build. Chưa tối ưu chia bundle trong lần bàn giao này.

## Chốt collector

Đã gỡ theo yêu cầu người dùng ngày 17/10/2026 (kết luận cũ "không tài khoản thì
không có dữ liệu" là sai). Collector mở theo lựa chọn nguồn, không còn kiểm chế độ.

## Kiểm tra giao diện

Bản ghi projection 10, 1920 × 1080, Edge headless, backend QA riêng.
Kiểm đủ bốn biến thể có cam/không cam và đầy đủ/tối giản bằng
scripts/verify/verify-atlas-xp.mjs --assert. Kiểm XP/HP/resource cùng chiều rộng,
tâm vòng/glyph lane quest và quantity đồ hỗ trợ. Kiểm không còn nhãn bản ghi,
kích hoạt thử hoặc giả lập UI trên đầu ra.

Draft đã chạy lại smoke 20 lượt, hover/lock/undo/skip/swap, hai layout, giảm
chuyển động, asset/font và vùng cam trong suốt. Chi tiết giữ trong
[nhật ký kiểm thử](history/TEST_REPORT_2026-10-17.md).

## Giới hạn còn lại

Chưa thử toàn trận spectator live mới. LCU/ROFL custom và Riot API key chưa
thành luồng postgame tự động; ROFL đã tạm hoãn. Không có kết luận độ giống
95–98% toàn bộ UI. DLL/runtime/cache collector không nằm trong Git, máy mới
cần chuẩn bị riêng trước khi thử live.

Log và ảnh QA nằm trong .npm-cache, không đưa lên Git. Không xóa captures,
credentials hoặc theme cá nhân khi dọn bản nội bộ.
