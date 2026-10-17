# Chạy thử Windows và gửi kết quả

Cần Windows x64 và LoL spectator/replay tương thích. Bản native hiện giữ kiểm
tra spectator của thư viện gốc; không coi chạy trận dưới tài khoản người chơi
là tình huống đã được hỗ trợ. Gói Windows kèm runtime, không cần SDK/Python.

## Kiểm tra ứng dụng

1. Giải nén toàn bộ `LeagueCollector-Windows-x64.zip`.
2. Chạy `diagnose.cmd`: kiểm tra Windows x64 và DLL hiện diện/hợp lệ. Kết quả
   này không chứng minh thu được dữ liệu game.
3. Chạy `start-demo.cmd`, mở `http://127.0.0.1:18799/`. Dữ liệu phải có nhãn
   mẫu; đóng tiến trình demo trước khi chạy native trên cùng cổng.

## Thu một lần chạy native

1. Nếu thử bằng tài khoản BlueBottle, sao chép `collector.env.example` thành
   `collector.env`, đặt cạnh LeagueCollector.dll và điền tài khoản riêng. Nếu
   không cấu hình tài khoản, host thử nhánh không đăng nhập; nhánh đó chưa
   được chứng minh giữ kết nối hoặc trả đủ dữ liệu Free. Biến môi trường
   LB_EMAIL/LB_PASSWORD đang có cũng được host sử dụng.
2. Để kiểm tra host độc lập, bắt đầu lần thử khi ứng dụng LB đã đóng. Một DLL
   còn trong tiến trình game từ lần LB trước có thể giữ trạng thái/quyền của
   phiên trước; cần phân biệt trường hợp này trong ghi chú kết quả.
3. Chạy `start-test.cmd`. Script tạo thư mục `test-results/run-...`, ghi
   `frames.ndjson` và `collector.log`. Xem dashboard tại
   `http://127.0.0.1:18799/` để theo dõi trạng thái.
4. Mở spectator/replay phù hợp. Theo dõi ít nhất vài phút qua các mốc khoảng
   30 giây và một sự kiện mục tiêu nếu có. Ghi lại thời gian bắt đầu nhận/mất
   dữ liệu, thông báo error, authentication.state, snapshots và recording.dropped.
5. Khi đang nhận dữ liệu, chạy `export-diagnostics.cmd` ở cửa sổ khác. Nếu bị
   mất dữ liệu, chạy thêm lần nữa để có trạng thái sau lỗi. Mỗi lần xuất tạo
   một ZIP mới trong `test-results/`, không dừng collector.
6. Dừng collector bằng Ctrl+C và chờ tiến trình đóng để hoàn tất bản ghi.

`start-test.cmd` không cần LB chạy cùng. Điều này chưa phải kết quả kiểm thử
thành công với native/game. Khi tự chẩn đoán sau lần thử độc lập, có thể thử
`start-collector.cmd --no-inject` với DLL đã được LB khởi tạo, nhưng phải ghi
rõ đó là tình huống chạy chung để tránh suy ra nhầm rằng không cần auth.

## Gói chẩn đoán chứa gì?

Lệnh `--export-diagnostics` đọc một lần các endpoint loopback `/api/status`,
`health`, `schema`, `snapshot`, `lcu`. Nó xuất JSON còn nhận được và bảng mã
HTTP/lỗi; vẫn tạo ZIP nếu collector không truy cập được, trả exit code 1.

Nó không đọc collector.env, biến môi trường, lockfile LCU hoặc console log.
Snapshot/LCU có thể có tên người chơi và thông tin trận. Console log và bản
ghi NDJSON không tự đưa vào ZIP này.

Gửi ZIP chẩn đoán và mô tả ngắn: Windows/LoL patch, spectator hay replay,
có cấu hình tài khoản không, có LB hoặc phiên game cũ chạy trước đó không,
dữ liệu ngắt sau bao lâu. Nếu cần đối chiếu sự kiện, gửi thêm frames.ndjson
từ lần thử tương ứng. Không gửi collector.env hay lockfile.

Các lệnh tương đương trong thư mục gói Windows:

```bat
runtime\dotnet.exe LeagueCollector.dll --export-diagnostics
runtime\dotnet.exe LeagueCollector.dll --export-diagnostics --port 18800
```

Gói source không kèm runtime Windows. Muốn build từ source, cài .NET 10 SDK
x64 và Python 3, đặt DOTNET_ROOT tới thư mục SDK, rồi chạy `python build.py`.
App ở `dist/app`; `fetch_runtime.py` + `package.py` tạo lại gói Windows. Đường
build qua compiler trực tiếp đã kiểm tra ở cloud; build Windows chưa được chạy.
