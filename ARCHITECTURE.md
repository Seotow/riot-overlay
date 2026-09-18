# Kiến trúc LoL — bản khung 0.1

## Đã thực hiện

Mock reducer → backend state → WebSocket → Studio và Overlay Renderer. Schema Zod v1 kiểm tra command/theme tại backend. Mỗi cập nhật có revision; kết nối mới nhận snapshot đầy đủ. Scene và theme nằm trong state, nên các cửa sổ dùng cùng trạng thái. Overlay dùng chế độ nhận-only. Backend ghi theme theo hàng đợi và đổi tên file tạm.

Nguồn dữ liệu thật chưa được nối. Prototype hiện cố ý gửi snapshot toàn bộ để đơn giản; dữ liệu nhỏ (10 player). Event nằm trong snapshot với ID ổn định cho killfeed, chưa phải event log bền vững.

## Các ranh giới cần giữ

1. Observer Agent chỉ thu, đóng dấu phiên/thời gian và gửi dữ liệu; không biết theme.
2. Adapter chuyển payload provider sang game state. Không đưa raw LCU vào React.
3. Backend giữ authoritative state, đồng hồ, logic timer, dedup và capability.
4. Widget nhận state và cấu hình theme. Không tự truy cập Riot hoặc tính ra gold thiếu.
5. Studio quản lý production và theme; OBS renderer chỉ trình bày.

## Adapter tiếp theo

Chuẩn hóa envelope: protocolVersion, sessionId, sequence, source, capturedAt, gameTime, payload. Field nhạy cảm: value hoặc null, availability, source và observedAt. Nguồn mock/live/replay triển khai cùng interface snapshot/events/capabilities. Backend cần phát hiện mất nguồn ngay cả khi socket còn mở.

Kết nối Agent có token riêng trước khi hỗ trợ nhiều máy. Credentials LCU không rời máy observer. Xử lý pause/reconnect/replay seek bằng game clock, không setInterval trên frontend.

## Theme

Theme v1 là JSON cấu hình, không thực thi JavaScript/CSS do người dùng nhập. Mở rộng asset manifest với logo/font/champion art sau khi duyệt UI. Mở rộng layout theo widget (anchor, x/y, size, zIndex) trước khi làm drag/drop. Giữ migration khi schema thay đổi.

## Lộ trình ngay sau preview

1. Duyệt bố cục ingame/draft theo hai ảnh; nhận branding thực.
2. Tách scene/widget thành module riêng khi bổ sung assets và bố cục chi tiết.
3. Collector read-only LCU + Live Client; ghi fixture có consent trong trận test.
4. Kiểm chứng data matrix trên patch thực. Bật feature dựa capability, không dựa giao diện demo.
5. Replay log, snapshot checkpoint, SQLite production config; kiểm thử reconnect và clock.
