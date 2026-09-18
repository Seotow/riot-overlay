# Trạng thái bàn giao

Cập nhật: 19/09/2026. Đây là bộ nhớ dự án để đọc cùng source trên máy khác.

## Mục tiêu

Xây bộ kit overlay cho game Riot, bắt đầu với LoL. Người dùng muốn Observer Agent thu dữ liệu, backend xử lý, frontend dành cho OBS và Studio tùy chỉnh nhận diện giải. Valorant/TFT chưa nằm trong phần triển khai hiện tại.

## Mốc đã được duyệt

Người dùng đã xác nhận **hai bản draft và in-game đạt yêu cầu ban đầu** sau vòng chỉnh theo `ingame.png` và `overlay.png`. Đây là baseline được duyệt về sản phẩm, không phải kết quả đo chứng minh độ giống 90%. Những khác biệt ở `VISUAL_AUDIT.md` vẫn được giữ làm ghi chú, không chặn chuyển sang khảo sát live data.

## Đã có trong source

- React/TypeScript Studio; canvas thiết kế 1920×1080 và renderer OBS trong suốt.
- Backend Node HTTP/WebSocket loopback, snapshot chung, revision, command/theme validation bằng Zod.
- Mock pause/play, seek, kill, level, objective, draft, kịch bản gold thiếu; reset giữ theme.
- Draft và in-game theo ảnh mẫu. Postgame là demo phụ, chưa có yêu cầu đối chiếu ảnh riêng.
- Asset Data Dragon cache local: tên/ảnh tướng, loading portrait, item, spell, rune. Metadata/icon version 15.20.1; nhãn patch trong ảnh là 25.20.
- Theme JSON: tên giải/đội, màu, font preset, biến thể, scale/offset toàn lớp và widget visibility. Tự lưu `data/theme.json`, import/export.
- Preset tham chiếu trong `shared/reference.ts`; chạy mới không cần mang theo `data` để có baseline.
- Nút chuyển ảnh gốc/bản dựng và bật/tắt ảnh nền trong Studio.

## Chưa có

Observer Agent, adapter LCU/Live Client, dữ liệu trận thật, data availability matrix được kiểm chứng trên máy, event log/replay thật, reconnect theo session nguồn, editor từng widget, upload logo/font, gói cài đặt desktop. Chưa có tích hợp Valorant/TFT.

Một số số liệu phụ vẫn cố định trong renderer (objective counters, cột gold giữa bảng, hover stats); cần đưa về contract khi kết nối dữ liệu. Draft dùng fixture riêng vì hai ảnh chụp không cùng trạng thái trận. Timer demo không phải logic timer đã kiểm chứng. Một số ban/skin được suy luận từ ảnh.

Logo đội/Worlds/sponsor hiện crop CSS từ ảnh tham chiếu. Font thay thế là Anton/Roboto Condensed và Arial ở một số nhãn. Chưa có bộ nhận diện gốc dạng asset rời.

## Kiểm chứng gần nhất

- TypeScript + production build thành công.
- 6 test tự động đạt: state/validation và tham chiếu asset.
- Integration test đạt: snapshot chung, kill propagation, overlay read-only, reset.
- Browser: draft và in-game không có ảnh lỗi sau tải; đo vị trí vùng chính ở 1920×1080; body OBS trong suốt.
- Windows từng khóa `dist/assets` khi build; build lại với `npm run build -- --emptyOutDir false` thành công. Không cần thay mặc định chỉ vì lỗi cục bộ này.

Các kết quả trên là lần kiểm tra trước bàn giao, không phải kiểm tra trên máy mới.

## Việc tiếp theo

Triển khai **giai đoạn 1 trong `ROADMAP.md`**: màn hình chẩn đoán nguồn dữ liệu local chỉ đọc. Chuẩn bị công cụ trước, sau đó hướng dẫn người dùng mở client, vào chọn tướng và spectator để thu mẫu đã loại bỏ credentials. Chưa cần Riot API key cho mock hiện tại; chỉ yêu cầu thông tin thật khi adapter cụ thể cần.

## Tiếp tục trên máy khác

Đọc `AGENTS.md`, làm theo `SETUP_VI.md`, xác minh baseline và tiếp tục giai đoạn 1. Không cần tái nghiên cứu toàn bộ hoặc dựng lại UI từ đầu. Không giả định thư mục `.research`, theme cá nhân hoặc lịch sử chat có trong Git.
