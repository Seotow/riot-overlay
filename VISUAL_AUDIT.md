# Audit giao diện LoL — 18/09/2026

**Cập nhật sau audit:** người dùng đã xác nhận draft và in-game đạt yêu cầu ban đầu. Hai scene là baseline được duyệt để tiếp tục kết nối dữ liệu. Các khác biệt bên dưới được ghi nhận, không phải yêu cầu mở lại vòng thiết kế.

Nguồn chuẩn là `ingame.png` và `overlay.png` do người dùng cung cấp, kích thước 1920×1080. Đã đo vùng chính trên DOM của renderer độc lập ở cùng độ phân giải; không dùng ảnh nền để đánh giá thành phần đã vẽ.

| Thành phần | X | Y | Rộng | Cao |
| --- | ---: | ---: | ---: | ---: |
| Scoreboard | 512 | 8 | 896 | 102 |
| Objective timer | 12 | 12 | 151 | 48 |
| Bảng 10 người chơi | 464 | 821 | 992 | 259 |
| Coach + ban trái | 0 | 667 | 360 | 112 |
| Coach + ban phải | 1560 | 667 | 360 | 112 |
| Dải draft | 0 | 790 | 1920 | 290 |
| Trung tâm draft | 800 | 790 | 320 | 290 |

## Đã chỉnh

- Scoreboard chia đội/economy/kills ở tâm, series pips, gold delta và mục tiêu.
- Bảng người chơi phản chiếu hai phía, ảnh tướng 47px, spell xếp dọc, items, rune, HP/resource, level/CS/KDA. Điểm tầm nhìn là field mock riêng.
- Draft có 5 cột trái 160px, giữa 320px; bên phải 120/120/120/320/120 khi R4 hover. Tên người chơi dựng dọc, ban và coach tách khỏi dải pick.
- Chữ hiển thị bằng font cài local, màu nền tối và xanh theo preset. Có chuyển ảnh gốc/bản dựng trong Studio, và renderer OBS trong suốt.
- Tên/ảnh game tra bằng ID Data Dragon; `MonkeyKing` hiển thị là Wukong. Kiểm tra fixture không có ID thiếu hoặc file asset trống.

## Các khác biệt còn lại

Chưa chứng minh mức giống 90% và chưa xem đây là bản tái tạo pixel-perfect. Font gốc chưa được cung cấp; Anton và Roboto Condensed là bản thay thế, một số nhãn dùng Arial. Icon role/mục tiêu đang là SVG minh họa nên chưa trùng hình gốc. Tướng/skin và một số bans được suy luận từ ảnh; portrait dùng base loading art, crop và skin có thể khác. Trang bị hợp lệ trong catalog nhưng không khẳng định trùng toàn bộ inventory trong ảnh. Số liệu phụ như gold giữa bảng, objective counters và hover stats là fixture minh họa.

Logo KT/T1/Worlds và sponsor hiện là các vùng crop CSS từ ảnh người dùng; cần file logo trong suốt để hoàn thiện theme giải và bỏ phần nền đen đi kèm. Camera, minimap và game footage chỉ có trong nền tham chiếu của Studio; OBS không nhúng toàn bộ ảnh chụp.

## Tham khảo cấu trúc

- [RCV in-game module](https://github.com/rcv-prod-toolkit/module-league-in-game): `frontend/gfx/ingame.css`, cấu trúc scoreboard hai đội và bảng hàng người chơi.
- [RCV champion select module](https://github.com/rcv-prod-toolkit/module-league-champselect-ui): `src/europe/style/variables.less`, `picks.less`, `bans.less`, cách tách pick/ban và crop portrait.
- [Riot Data Dragon](https://developer.riotgames.com/docs/lol#data-dragon): metadata và image assets.

CSS renderer được viết riêng theo ảnh mẫu; không chạy runtime toolkit hoặc đưa font của toolkit vào dự án. Theme tiếp tục hỗ trợ đổi màu, font, tên đội, tỷ lệ/vị trí toàn bộ lớp và bật/tắt widget; chưa có editor từng phần tử.
