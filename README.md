# Rift Studio

Bộ công cụ phát sóng LoL chạy trên máy Windows. Studio dùng để cấu hình trận,
điều khiển overlay và phát lại bản ghi. OBS nhận hình qua Browser Source.
Bản hiện tại dành cho nội bộ, chưa phải dịch vụ web hoặc bộ cài độc lập.

## Chạy nhanh

Cài Node.js 24, mở terminal tại thư mục project:

```powershell
npm ci
npm run build
npm start
```

- Studio: http://127.0.0.1:4310/?page=studio
- Cấu hình trận: http://127.0.0.1:4310/?page=theme
- OBS: http://127.0.0.1:4310/overlay, kích thước 1920 × 1080.
- Dừng bằng Ctrl+C. Sau khi cập nhật source, build lại rồi khởi động lại backend.

Backend chỉ lắng nghe trên máy local. Không mở port ra LAN hoặc Internet.
Không dùng `npm ci --omit=dev`: backend hiện chạy bằng `tsx`.

## Trước khi phát

1. Vào **Cấu hình trận đấu** để đặt tên đội, màu, logo, tỉ số và layout.
   Logo không bắt buộc. Lưu cấu hình để cập nhật Studio và OBS.
2. Vào **Nguồn dữ liệu** để chọn nguồn trận. Tắt dữ liệu mẫu khi phát thật.
3. Dùng **Cấm chọn** để điều khiển pick/ban thủ công.
4. Dùng **Phát sóng** để bật leaderboard, rune, timer nhà lính và layout tối giản.
5. **Phòng thử** dùng bản ghi đã lưu, có play/pause, tua và tốc độ.
   Khi phát bản ghi, đầu ra OBS cũng dùng bản ghi đó.

Các scene OBS cố định: `/overlay?scene=ingame`, `/overlay?scene=draft`,
`/overlay?scene=postgame`. Renderer không chứa ảnh đối chiếu, nút điều khiển
hoặc nhãn kiểm thử. Trạng thái nguồn và cảnh báo nằm trong Studio.

## An toàn khi lấy dữ liệu

Collector chỉ được mở khi ứng dụng xác nhận đang xem spectator hoặc replay.
Nếu phát hiện tên người chơi đang điều khiển, hoặc không xác nhận được chế độ,
ứng dụng không mở collector. Khi mất xác nhận trong lúc chạy, ứng dụng ngắt
nguồn live và dừng host do nó quản lý.

Không có nút bỏ qua chốt này. Có clock từ Replay API chưa đủ để cho phép thu.
Chốt áp dụng cả collector có tài khoản và không tài khoản; bản ghi đã lưu,
cấm chọn thủ công và dữ liệu mẫu vẫn dùng được. Xem
[quy tắc và cách xử lý bị chặn](docs/COLLECTOR_SAFETY.md).

## Nguồn dữ liệu

| Nguồn | Điều kiện |
| --- | --- |
| LeagueBroadcast | LB chạy riêng và đang xuất feed spectator |
| Collector tích hợp | Cần runtime, DLL và cache local được chuẩn bị riêng |
| Riot local | Chỉ có các field mà API local cung cấp |
| Bản ghi | Cần thư mục capture trên máy; không đi kèm Git |

Chạy collector tích hợp bằng `npm run start:collector` hoặc
`npm run start:collector:no-auth` sau khi chuẩn bị runtime.
Clone repository không tự có DLL, runtime hoặc tài khoản collector.
Xem [hướng dẫn collector](Collector/docs/PROJECT-RUNBOOK.vi.md).

Ghi trận với collector không tài khoản bằng terminal thứ hai:

```powershell
npm run capture:collector -- 10800000
```

Dừng ghi ở terminal khác:

```powershell
npm run capture:collector:stop
```

Bản ghi nằm trong `data/captures`, nhịp mục tiêu 0,5 giây. Giữ nguyên bản gốc.
[Hướng dẫn trận thật](docs/LIVE_MATCH_RUNBOOK.md) có quy trình kiểm tra chi tiết.

## Phần chưa hoàn tất

- Draft hiện nhập tay, chưa nhận cấm chọn tự động.
- Chưa có nguồn postgame tự động đáng tin cậy cho custom trên máy spectator.
  LCU đọc được trận khi đăng nhập người tham gia, nhưng cùng trận trả 404 khi
  đổi sang spectator. File replay thử nghiệm do tài khoản người chơi tải;
  hướng đọc metadata đang tạm hoãn.
- Standard Riot API đã có luồng tải và duyệt kết quả. Thử key hiện tại chưa
  thành công; không coi đây là nguồn đã dùng được cho custom.
- Damage theo giao tranh, một số stack champion và telemetry khác còn thiếu mẫu.
- Ẩn riêng dấu 18+ VNG trong game đang để nghiên cứu. Valorant và REA giữ riêng.

## Kiểm tra và tài liệu

```powershell
npm test
npm run build
npm run test:integration
npm run test:collector
npm run test:collector-capture
npm run test:collector-validation
```

Integration dùng backend/theme test riêng; không chạy script đổi mock trên
phiên đang phát sóng. Hướng dẫn chi tiết:

- [Cài đặt và chuyển máy](SETUP_VI.md)
- [Trạng thái bàn giao](PROJECT_STATUS.md)
- [Kết quả kiểm thử](TEST_REPORT.md)
- [Kiến trúc](ARCHITECTURE.md)
- [Lộ trình](ROADMAP.md)
- [Hướng dẫn Studio](docs/STUDIO_UI.md)

Theme cá nhân, captures và credentials không theo Git. Không gửi API key hoặc
LCU credentials vào chat. Asset Riot và nhận diện giải cần được kiểm tra quyền
sử dụng trước khi phân phối ngoài nội bộ.

