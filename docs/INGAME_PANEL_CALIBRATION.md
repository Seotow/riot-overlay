# Hiệu chỉnh nền in-game — 13/10/2026

Đo pixel ở 4 ảnh người dùng: `ingame new.png`, `ingame thông thường.png`,
`ingame chênh lệch tiền 2 bên và các player.png`, `all.png` (1920×1080).
So sánh bản72% và bản mới84% trên cùng game-only backdrop/cùng snapshot.
Không suy ra opacity chính xác của Riot vì ảnh đã composite và không có frame
footage nguyên bản nằm dưới HUD. Đây là cân chỉnh tone theo vùng ảnh, không
phải phép đo95–98% similarity.

| Vùng | ROI x,y,w,h | Luma median mẫu (0–255) | Bản trước | Bản mới |
| --- | --- | ---: | ---: | ---: |
| Scoreboard main | 660,18,30,35 | 10–22 | 32 | 14 |
| Hàng timer/quest | 780,76,55,24 | 14–30 | 33 | 19 |
| Nền tên player | 842,826,18,18 | 15–33 | 39 | 20 |
| Cột chênh vàng | 939,824,10,10 | 11–31 | 39 | 20 |

Luma dùng0.2126R+0.7152G+0.0722B trên giá trị RGB ảnh (không phải luminance
vật lý tuyến tính). Script còn ghi RGB trung bình của30% pixel tối nhất nhằm
giảm ảnh hưởng chữ/icon; tọa độ nhỏ đã chọn tránh nội dung sáng ở phần lớn mẫu.
Ví dụ scoreboard RGB mẫu6–18(R),10–22(G),9–14(B), trong khi màu nền cũ cố
định24,30,32 vốn quá sáng ngay cả khi tăng opacity. Các ROI có footage/nén và
nội dung khác nhau nên dùng khoảng tham chiếu, không ép trùng một pixel.

Màu nền mới8,12,14; base mặc định84%, main+8%=92% (cap95%), sub×.88≈74%.
Giữ một surface chính, font/ảnh/gauge không giảm opacity. Config riêng đã lưu
giá trị khác vẫn được giữ; theme cá nhân hiện chưa lưu field, nên reload nhận
mặc định mới mà không sửa file của người dùng. Bans/draft không thay đổi.

Tái đo: `scripts/measure-panel-tones.mjs`, cần `OVERLAY_BROWSER_PACKAGES` có
sharp; JSON trong cache ignored. Renderer PNG alpha kiểm tra qua production-smoke,
build/104 test đạt, hai layout và slider/save/OBS vẫn đạt. Preview mới
`.npm-cache/visual-audit/ingame-opacity-calibrated.png` chỉ minh họa tone trên
nền crop game-only; OBS không nhúng footage hoặc reference HUD.
