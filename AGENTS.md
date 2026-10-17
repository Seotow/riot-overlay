# Hướng dẫn làm việc với Riot Overlay

## Mốc hiện hành 11/10/2026

Phase UI/phòng thử trên snapshot thật được chốt theo PROJECT_STATUS.md và
docs/TEST_REPORT.md. Không quay lại các bước khảo sát cũ như thể chưa triển khai.
Giữ nhánh REA/collector và tài liệu Valorant để tiếp tục riêng; chưa có
collector headless thay LB hoặc runtime Valorant. Các mốc thiếu telemetry
đã hoãn (damage/combat/end-game/Elder live) phải tiếp tục ghi rõ, không
biến preview giả lập UI thành dữ liệu thật. Không tuyên bố 95–98% khi chưa đo.

## Đọc trước khi tiếp tục

1. `PROJECT_STATUS.md`: trạng thái bàn giao, quyết định người dùng đã chốt.
2. `README.md` và `docs/SETUP_VI.md`: cách cài, chạy, kiểm tra và chuyển máy.
3. `docs/ARCHITECTURE.md`: phần đang có và kiến trúc mục tiêu.
4. `docs/ROADMAP.md`: trình tự triển khai tiếp theo.
5. `docs/VISUAL_AUDIT.md`: số đo và khác biệt của UI tham chiếu.

Các tài liệu này giúp tiếp tục công việc mà không cần lịch sử chat. Luôn kiểm tra source và trạng thái workspace thực tế trước khi sửa; tài liệu bàn giao không thay thế kiểm chứng trên máy mới.

## Quyết định đã chốt

- Giao tiếp với người dùng bằng tiếng Việt, giải thích ngắn và dễ hiểu.
- Ưu tiên LoL. Valorant và TFT là hướng mở rộng, chưa triển khai.
- Người dùng đã xác nhận draft và in-game hiện tại đạt yêu cầu ban đầu. Giữ chúng làm baseline; không tự thiết kế lại hoặc mở thêm vòng audit UI nếu không cần cho yêu cầu mới.
- Postgame đi theo hướng replay `.rofl` (người dùng chốt 17/10/2026); mọi nguồn phải tự động, không nhập tay. Khóa bằng `RIOT_OVERLAY_POSTGAME=0`.
- Người dùng sẽ hỗ trợ thao tác LoL Client, chọn tướng và spectator khi được hướng dẫn từng bước. Không giả định client đang mở hoặc đã có trận test.
- Bước phát triển tiếp theo là chẩn đoán nguồn dữ liệu chỉ đọc, không phải hoàn thiện lại mock.

## Ranh giới kỹ thuật

- Có nhánh in-game quan sát thật và nhánh mock riêng. Có ảnh/tên Data Dragon không tự chứng minh field đã được nguồn live cung cấp.
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
- `npm run format:check` / `npm run format`: Prettier cho mã nguồn app và collector (cấu hình `.prettierrc.json`, loại trừ ở `.prettierignore`; không format hosts, bundles, vendor, Valorant, docs).

## Cấu trúc thư mục

- `server/`, `shared/`, `src/`, `tests/`: ứng dụng Studio/OBS.
- `scripts/{assets,capture,inspect,verify,dev}/`: công cụ phát triển, nhóm theo chức năng.
- `collector/`: `adapter`, `supervisor`, `validation`, `scripts`, `config`, `docs`; `hosts/` là source native (`lb-host`, `independent-reader`); `bundles/` là bản đã build kèm runtime. Xem collector/README.vi.md.
- Khi đổi transport: chạy backend và `npx tsx tests/transport.integration.ts`. Test này thay đổi mock trận và reset về cuối; chạy trong phiên test.
- Khi đổi UI: kiểm tra draft/in-game ở 1920×1080, ảnh/font đã tải, chế độ không có nền tham chiếu và renderer OBS. Không suy ra độ giống từ ảnh nền có sẵn HUD.
- Không cần chạy test ứng dụng cho thay đổi tài liệu thuần túy; kiểm tra liên kết, lệnh và tính nhất quán.

Cập nhật `PROJECT_STATUS.md` khi hoàn thành một mốc, ghi rõ đã làm, chưa làm, kiểm chứng và bước tiếp theo. Không ghi trạng thái chạy của port/process như một đảm bảo lâu dài.

## Cập nhật hướng ưu tiên 19/09/2026

Người dùng chọn in-game trước và sẽ mở replay để cung cấp mẫu. collector/adapter/session phục vụ Studio đã được chuẩn bị, xem phần cuối PROJECT_STATUS.md. Tiếp tục kiểm chứng replay khi client sẵn sàng; tạm hoãn champ-select. Không coi Replay API có clock là bằng chứng có dữ liệu 10 người chơi.
