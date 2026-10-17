# Frame accurate state

Cập nhật: 20/09/2026.

## Mục tiêu

Renderer phải bám clock của trận, không bám nhịp polling hay tốc độ render của browser. Khái niệm frame accurate trong project gồm hai lớp:

1. Snapshot authoritative chứa state rời rạc do nguồn thật cung cấp.
2. Presentation clock nội suy thời gian giữa hai snapshot để timer chạy mượt và khớp game.

Không nội suy kills, gold, item, HP hoặc objective. Các field này chỉ đổi khi có snapshot hay event mới từ nguồn.

## Trạng thái đã có

Observer envelope đã có `sessionId`, `sequence`, `epoch`, `capturedAt` và `transition`. Seek lùi hoặc nhảy xa tạo epoch mới; reconnect hoặc đổi nguồn tạo session mới. Event được deduplicate bằng ID, timestamp và loại sự kiện.

Presentation clock hiện lấy `gameTime` làm anchor, fallback sang replay time, rồi tiến theo tuổi snapshot và playback speed. Khi replay pause, clock giữ nguyên. Khi frame quá 5 giây, clock chuyển unavailable thay vì tiếp tục chạy bằng suy đoán.

Đây là cùng kiểu mô hình mà public LeagueBroadcast client mô tả: backend phát snapshot theo update rate; client cung cấp clock liên tục từ snapshot gần nhất. Nó chưa chứng minh collector của project có độ phủ hoặc tần số giống collector BlueBottle.

## Contract mục tiêu

Mỗi snapshot hoặc event cần giữ bốn miền thời gian riêng:

- `sourceTime`: clock trận do game/provider cung cấp.
- `capturedAt`: thời điểm adapter hoàn tất mẫu.
- `receivedAt`: thời điểm backend nhận message từ provider.
- `presentedAt`: thời điểm browser dựng khung hình.

Khi provider có sequence/tick riêng, giữ nguyên dưới dạng metadata đã lọc. Không dùng wall clock để sắp lại event có source timestamp đáng tin hơn.

## Đồng bộ renderer

- Timer và cooldown đọc presentation clock trong animation frame, nhưng chỉ render lại khi giá trị nhìn thấy thay đổi.
- State rời rạc dùng selector để tránh render toàn bộ overlay khi một field không liên quan đổi.
- Event có `sourceTime <= presentationTime` mới được phát.
- Seek tăng epoch, xóa hàng đợi animation và không phát lại event lịch sử.
- Snapshot đến muộn được dùng để sửa drift; không được làm clock chạy lùi trong cùng epoch trừ khi provider xác nhận seek.
- Mất nguồn quá ngưỡng xóa state khỏi sóng, không extrapolate vô hạn.

## Capture và OCR

Ảnh OBS phải có capture timestamp. Kết quả OCR gắn với presentation clock gần nhất và chỉ hợp nhất khi sai lệch dưới ngưỡng cấu hình. OCR không thể được gọi là frame accurate nếu ảnh được lấy thưa, source OBS bị buffer hoặc HUD đang chuyển cảnh.

Đề xuất ban đầu:

- Snapshot Riot: 2 đến 4 Hz, tùy endpoint và tải máy.
- Clock trình bày: nội suy liên tục, lượng tử theo nội dung hiển thị.
- OCR scoreboard: 2 Hz; tăng tần số ngắn hạn khi phát hiện vùng thay đổi.
- Event UI: dùng timestamp nguồn, không dùng thời điểm HTTP hoàn tất.
- Giữ metric drift, tuổi snapshot, update rate và số lần correction trên dashboard.

## Điều kiện để tuyên bố frame accurate

Chỉ dùng nhãn này cho một field khi đã đo được trên video/spectator chuẩn:

- Có clock hoặc tick authoritative.
- Xác định được latency và jitter từ source đến renderer.
- Pause, tốc độ replay, seek và reconnect không làm phát sai event.
- Sai lệch nằm trong ngưỡng đã công bố cho field đó.

Với nguồn Riot local hiện tại, có thể đạt timer mượt và event ordering ổn định. Chưa thể tuyên bố full game state frame accurate vì total gold, HP, resource và rune của 10 người chưa có trong payload đã quan sát.
