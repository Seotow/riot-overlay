# Chốt an toàn collector

Collector chỉ dành cho máy spectator hoặc xem replay. Không dùng trên máy
đang điều khiển người chơi, kể cả phòng tập, custom hoặc bot.

## Quy tắc

Ứng dụng đọc tên active player qua Live Client API. Nếu có tên người điều
khiển thì chặn ngay, kể cả khi Replay API vẫn trả clock.

Tên Unknown/Spectator không tự đủ điều kiện. Cần thêm một trong hai bằng chứng:

- Tiến trình game duy nhất được hệ điều hành xác nhận chạy với tham số
  spectator hoặc đường dẫn replay .rofl.
- LCU báo session InProgress và gameData.isSpectator bằng true.

Không đọc được API, không xem được chế độ tiến trình, LCU thiếu field hoặc
bằng chứng không đủ thì chặn. Không có nút xác nhận tay để bỏ qua.

## Khi đang chạy

Chốt được gọi trước khi khởi động host và ngay trước spawn, trước khi backend
kết nối/đọc nguồn live. Host do ứng dụng quản lý có vòng kiểm tra riêng.
Kết quả kiểm tra dùng chung tối đa 500 ms; request có timeout nên thời gian
phát hiện không được bảo đảm chính xác 500 ms.

Nếu kết quả chuyển sang player hoặc không xác nhận được:

- Ngắt socket collector/LB trong ứng dụng, xóa frame đang phát.
- Dừng host do ứng dụng sở hữu. Vòng giám sát host kết thúc process khi chặn.
- Bộ ghi capture dừng với lý do safety-blocked và hoàn tất file đang ghi.
- Studio báo bị chặn hoặc chờ xác nhận. Không gửi tên người chơi, command line
  hay LCU credentials ra frontend/log.

Ứng dụng không thể dừng LB hoặc collector bên ngoài do phần mềm khác quản lý.
Với chế độ đó, chốt chỉ ngắt kết nối của Rift Studio. Giữ nguyên các guard
của native collector; chốt này không thay thế chúng.

## Không bị chặn

Phát bản ghi đã có, nhập tay cấm chọn, chỉnh theme và thử dữ liệu mẫu không
cần collector game. Các chức năng này vẫn chạy khi client đóng hoặc đang chơi.

## Nếu spectator/replay bị chặn

1. Kiểm tra đúng chế độ xem, không phải điều khiển tướng.
2. Đợi game/API tải xong, xem lại **Nguồn dữ liệu**.
3. Nếu game cài ở vị trí khác, có thể đặt biến môi trường LOL_LOCKFILE trỏ
   đúng file lockfile trên máy. Không chép nội dung file vào chat hoặc Git.
4. Nếu vẫn không xác nhận được, giữ collector tắt và ghi nhận để kiểm tra.
   Không sửa DLL, tắt guard hoặc mở quyền truy cập mạng để vượt chốt.

Kiểm thử fixture nằm ở tests/collector-safety.test.ts và
tests/collector-project.integration.ts. Preload giả lập chỉ được nạp rõ ràng
trong tiến trình test, không có biến môi trường bỏ qua trong ứng dụng.
