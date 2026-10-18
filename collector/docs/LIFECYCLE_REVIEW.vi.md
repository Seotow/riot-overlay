# Review lifecycle Collector — 14/10/2026

Phạm vi: bản source thử nghiệm trong `../archive/legacy-src/LeagueCollector` (bản sao cũ, đã lưu trữ).
Review chỉ đọc source và bằng chứng managed lab; không truy cập game, không chạy
DLL native, không đổi xác thực, quyền, spectator check hoặc transport.

## Bằng chứng đã kiểm tra

- Managed lab `managed-lab-2026-10-14T13-25-57…`: build/doctor/serializer đạt;
  lifecycle 14/14 đạt, `gameAccessed=false`, `telemetryFields=0`.
- Lab không chứng minh collector lấy được snapshot LoL hoặc thay thế LB.

## Phát hiện và thay đổi được giao

1. CTS tạo trễ có thể xuất hiện sau stop. Helper `ManagedWatcherLifetime` dùng
   generation/lease, child CTS liên kết lifetime và gate đồng bộ cho startup.
   Lease cũ không được tạo child hoặc install sau Stop/restart.
2. Hook worker tạo trễ có thể thoát cleanup. Gate dùng chung với Stop ngăn tạo
   resource sau stop; connector integration chịu trách nhiệm join worker.
3. Disconnect là async. Caller phải giữ task và chờ có timeout riêng;
   stop đồng bộ không tự chứng minh cleanup async đã hoàn tất.
4. Kiểm tra window ban đầu và event window có thể tạo nhiều startup cùng lease,
   ghi đè CTS và để task cũ tồn tại. Đã thêm `TryClaimStartup(lease)` nguyên tử:
   tối đa một startup attempt mỗi generation, không tự retry khi attempt lỗi.
   Claim reset chỉ khi Begin tạo generation mới. Root tích hợp claim vào connector
   và xử lý destroy đúng active window riêng.
5. Process watch cần được thu hồi trực tiếp khi Stop, không chỉ dựa vào socket
   disconnected event vốn có thể bị unsubscribe trước cleanup.

## Kiểm chứng bổ sung của root

Hai test mới cho claim: 32 lời gọi đồng thời chỉ một lời gọi thành công;
lease stale bị từ chối và generation mới được claim lại. Tổng suite dự kiến
16 ca. Root đã build/chạy: **16/16 đạt**, gameAccessed=false/telemetryFields=0.
Evidence: `../evidence/validation/managed-lab-2026-10-14T13-32-17-490Z-ef80476171a84b7dadc0e18f5783a601/`.
Root cũng tích hợp claim, invalidate/stop khi đúng active window đóng,
gate process-watch creation và thu hồi trực tiếp khi Stop.

## Giới hạn

- Timeout join/disconnect không giới hạn cleanup native đồng bộ diễn ra trước
  `WaitAsync`; cần watchdog ngoài host và không hứa stop luôn hoàn tất trong 2 giây.
- Root đã thêm cancellation vào HTTP/delay của `IsSpectator`; chưa đo đường
  request đó trên một trial native mới, không suy lab thành runtime game proof.
- Claim là giới hạn một session thử nghiệm, không phải reconnect policy production.
- Không kết luận nguyên nhân lần thử native không có snapshot là auth, replay
  hay game đã kết thúc chỉ từ các test managed.
