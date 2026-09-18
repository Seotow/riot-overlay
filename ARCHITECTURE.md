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

## Lộ trình sau baseline đã duyệt

1. UI draft/in-game đã được người dùng duyệt; renderer nằm trong `src/overlay`. Giữ baseline này.
2. Xây màn hình chẩn đoán và khảo sát chỉ đọc LCU/Live Client trên máy thực; người dùng hỗ trợ thao tác client.
3. Kiểm chứng data matrix trên patch thực trước khi cam kết field; bật feature dựa capability.
4. Xây Agent, adapter và bản ghi phiên; kiểm thử reconnect, session và clock.
5. Nối widget thật, hoàn thiện tùy biến và đóng gói. SQLite là lựa chọn tương lai, chưa phải dependency hiện tại.

Chi tiết thứ tự và điều kiện hoàn thành: `ROADMAP.md`. Trạng thái bàn giao: `PROJECT_STATUS.md`.
