# Kiểm chứng email/password và native — 14/10/2026

> Cập nhật runtime: account login và native snapshots đã có bằng chứng trong
> [AUTHENTICATED-RUNTIME.vi.md](AUTHENTICATED-RUNTIME.vi.md). Signed native
> challenge vẫn chưa chạy; phần thiếu credentials dưới đây là mốc offline cũ.

## Bằng chứng hiện tại

Source `BlueBottleAuth.Initialize` hỗ trợ Cognito SRP, giữ token trong RAM và
lookup subscription. `SourceWorker.Native` truyền `auth.Features` cho Farsight.
Nếu lookup không trả features thì bộ quyền yêu cầu vẫn Empty. Method managed
`RequestFeatures` trả true ngay khi Empty, không tạo AuthenticationStart hoặc
gọi callback Sign. True này không chứng minh native chấp nhận account.

Đã thêm `--auth-flow-self-test` vào host và build harness. Test gọi method
managed thực bằng reflection trong process offline: Empty, callback count,
client chưa connected và stale-handshake. Không sửa vendor/native/auth grant,
không gửi request tới provider/game/private IPC. Requested feature synthetic
trong test không được cài thành grant và không được gửi ra ngoài.

`scripts/check-auth.py` chạy riêng `--auth-check --no-inject --no-lcu`, tối đa
45giây, dừng owned child khi timeout. Raw output chỉ trong RAM, file evidence
chỉ state/count/hash đã allowlist. Nó kiểm account/subscription, không thực
hiện native challenge, không khởi động collector hoặc tải/update DLL.

Lần kiểm trên máy 14/10: không credential file/LB env, host trả not-configured
exit2; provider chưa được gọi. Process check không thấy Client/game/LB. Replay
GET đầu EACCES do sandbox, lần được phép sau ECONNREFUSED. Không kết luận
mode unsupported hoặc lỗi auth từ các trạng thái này.

## Phần cần người dùng trước runtime

1. Cấu hình local: copy
   `Collector/config/collector.env.example` thành
   `Collector/config/collector.env`,
   điền email/password bằng editor trên máy. Không gửi mật khẩu/token vào chat.
   File env đã bị Git ignore. Đây là tài khoản email/password; OAuth Google
   tương tác hoặc MFA chưa được host hỗ trợ.
   Launcher và `check-auth.py` truyền đường dẫn bằng `LB_CREDENTIAL_FILE`.
   Các script trial one-shot lịch sử vẫn dùng env ở thư mục build; không tự
   chạy lại chúng hoặc chép credentials vào build để tái sử dụng marker cũ.
2. Mở LoL Client. Client phải chạy thì mới truy cập được LCU. Sau đó có thể
   inventory replay qua API client, chọn replay tương thích hoặc người dùng
   mở replay SR/map11 mới và báo sẵn sàng. Không cần chạy LB đồng thời host thử.

Trình tự tiếp tục: account check → preflight replay trước GameEnd, clock tăng →
bounded native trial theo phạm vi được phép → transport/handshake/service/frame.
Không điền quyền giả, sửa gate hoặc giả AppId/publisher. Nếu lookup Empty,
phải ghi rõ chưa chạy signed challenge; không dùng authenticated/HTTP200 làm
native authorization proof. Chỉ có frame thật mới đánh giá roster/field/parity.

Lệnh account-only (chỉ sau cấu hình):

```powershell
python Collector/scripts/check-auth.py
```

Lệnh này không cần replay. Nếu network bị sandbox chặn thì dùng approval
đúng scope; không phân loại network denial thành sai mật khẩu.
