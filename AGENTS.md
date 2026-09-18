# Hướng dẫn làm việc với Riot Overlay

## Đọc trước khi tiếp tục

1. `PROJECT_STATUS.md`: trạng thái bàn giao, quyết định người dùng đã chốt.
2. `README.md` và `SETUP_VI.md`: cách cài, chạy, kiểm tra và chuyển máy.
3. `ARCHITECTURE.md`: phần đang có và kiến trúc mục tiêu.
4. `ROADMAP.md`: trình tự triển khai tiếp theo.
5. `VISUAL_AUDIT.md`: số đo và khác biệt của UI tham chiếu.

Các tài liệu này giúp tiếp tục công việc mà không cần lịch sử chat. Luôn kiểm tra source và trạng thái workspace thực tế trước khi sửa; tài liệu bàn giao không thay thế kiểm chứng trên máy mới.

## Quyết định đã chốt

- Giao tiếp với người dùng bằng tiếng Việt, giải thích ngắn và dễ hiểu.
- Ưu tiên LoL. Valorant và TFT là hướng mở rộng, chưa triển khai.
- Người dùng đã xác nhận draft và in-game hiện tại đạt yêu cầu ban đầu. Giữ chúng làm baseline; không tự thiết kế lại hoặc mở thêm vòng audit UI nếu không cần cho yêu cầu mới.
- Người dùng sẽ hỗ trợ thao tác LoL Client, chọn tướng và spectator khi được hướng dẫn từng bước. Không giả định client đang mở hoặc đã có trận test.
- Bước phát triển tiếp theo là chẩn đoán nguồn dữ liệu chỉ đọc, không phải hoàn thiện lại mock.

## Ranh giới kỹ thuật

- Hiện toàn bộ số liệu trận là mock. Có ảnh/tên Data Dragon không đồng nghĩa có dữ liệu live.
- Luồng mục tiêu: nguồn local → Observer Agent → adapter/backend → Studio và renderer OBS.
- Không đưa credentials LCU vào frontend, log, fixture, tài liệu hay Git. Không đưa raw payload provider trực tiếp vào widget.
- Không giả lập giá trị thiếu thành dữ liệu thật. Dùng availability/capability và `null` thích hợp; chỉ hứa hỗ trợ field sau khi kiểm chứng.
- Renderer OBS giữ nền trong suốt và chế độ chỉ nhận dữ liệu. Nền ảnh tham chiếu chỉ dùng ở Studio.
- Theme phải có thể lưu/export/import; giữ tương thích hoặc migration khi thay schema.
- Data Dragon demo khóa 15.20.1 cho ảnh patch 25.20. Không tự nâng asset baseline sang patch mới nhất. Nguồn live sau này cần chiến lược version riêng.
- Giữ thay đổi người dùng, không ghi đè theme local để chạy test. Không tự push/publish repository khi chỉ được yêu cầu sửa file.

## Kiểm chứng

- `npm run build`: kiểm tra TypeScript và build frontend.
- `npm test`: kiểm tra reducer, validation và asset fixture.
- Khi đổi transport: chạy backend và `npx tsx tests/transport.integration.ts`. Test này thay đổi mock trận và reset về cuối; chạy trong phiên test.
- Khi đổi UI: kiểm tra draft/in-game ở 1920×1080, ảnh/font đã tải, chế độ không có nền tham chiếu và renderer OBS. Không suy ra độ giống từ ảnh nền có sẵn HUD.
- Không cần chạy test ứng dụng cho thay đổi tài liệu thuần túy; kiểm tra liên kết, lệnh và tính nhất quán.

Cập nhật `PROJECT_STATUS.md` khi hoàn thành một mốc, ghi rõ đã làm, chưa làm, kiểm chứng và bước tiếp theo. Không ghi trạng thái chạy của port/process như một đảm bảo lâu dài.
