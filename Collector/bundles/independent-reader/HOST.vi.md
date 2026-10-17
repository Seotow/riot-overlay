# Host thử nghiệm độc lập

Host này dùng C ABI của thư viện C++ tự viết ở `../native`. Không tham chiếu Farsight, AWS, `lblib`, mã đăng nhập hoặc dịch vụ BlueBottle. Chưa xác nhận tương đương dữ liệu LB/tài khoản hiện tại; chưa kiểm thử Windows/game thật.

Đã build .NET 10 trên Linux: **0 lỗi, 0 warning**. 10 nhóm integration test chạy qua ASP.NET host và native memory-reader thật bằng sparse fixture, gồm ghi NDJSON, không ghi đè và lỗi I/O thật. Chi tiết trong `tests/verification.json`.

## Bản chạy thử

Các tệp cần thiết nằm trong `dist/`: `IndependentCollector.dll`, runtimeconfig/deps, `lc_reader.dll` cho Windows x64, `liblc_reader.so` cho Linux fixture test, script và fixture.

Host cần .NET 10 và ASP.NET Core runtime 10 x64. Script `run.cmd` tìm runtime trong `dist/runtime`, `../runtime`, sau đó lệnh `dotnet` trên PATH. Khi gói giao đi đã kèm runtime, người dùng không cần SDK, Python hoặc compiler để chạy host.

### Thử pipeline bằng dữ liệu tổng hợp

```bat
start-fixture.cmd
```

Mở `http://127.0.0.1:18801/api/status` và `/api/snapshot`. Đây **chỉ là fixture**, `synthetic:true`, `runtimeVerified:false`, không phải dữ liệu tài khoản/game. Fixture kiểm việc đọc bộ nhớ sparse qua C ABI, không phát JSON mẫu giả làm game.

### Đo identity của tiến trình thật

Chỉ Windows x64, ví dụ PID 1234:

```bat
run.cmd --identity --pid 1234 > identity.json
```

Lệnh không cần profile. Kết quả có `module`, `version`, `sha256`, `moduleBase`, `processId`, `imagePath`, `processStartTimeUtcTicks`, `measured:true`, `synthetic:false`. Host lấy identity từ main module tiến trình và hash nội dung file thực tế. Nếu không đọc được tiến trình/module, lệnh trả mã lỗi 3, không tạo identity dự phòng.

Không dùng PID của launcher/client khi profile dành cho game. Chọn PID đúng của tiến trình game đang chạy. File version có thể là chuỗi `unknown` nếu file không khai báo metadata; SHA-256 vẫn phải khớp đúng file. Profile resolver cần dùng chính identity đã đo, và host sẽ đo lại khi chạy.

### Đọc thử với profile game đã phục hồi

```bat
run.cmd --pid 1234 --profile game-profile.json --allow-unverified-profile
```

Profile `static-derived`/`unverified` cần `--allow-unverified-profile`. Host và core vẫn kiểm module/version/SHA-256 khớp target thực tế; flag này không bỏ kiểm tra identity. Profile fixture bị cấm trong chế độ đọc tiến trình.

Khi chưa có object discovery, trạng thái là `waiting-for-roots`; `data.heroes:null`. Những module fields đã có descriptor có thể vẫn đọc được. Host không tự tạo danh sách 10 người, không biến thiếu dữ liệu thành `[]` và không tự dùng fixture.

Nếu đã xác minh được các hero root addresses trong cùng tiến trình/phiên đang chạy:

```bat
run.cmd --pid 1234 --profile game-profile.json --heroes 0x2000000,0x2100000 --allow-unverified-profile
```

Các địa chỉ trên chỉ minh họa cú pháp, **không phải địa chỉ LoL thật**. Roots có thể hết hiệu lực khi đổi trận hoặc tiến trình; core giữ field lỗi đọc là `null` và báo issue. Cấp roots thủ công không chứng minh collection đã đầy đủ. Host giữ đối tượng process và kiểm start time/module trước, sau khi mở read handle; mỗi snapshot còn kiểm process exit/start time để tránh dùng identity cũ khi PID thay đổi. Khi tiến trình thoát, host xóa snapshot và báo lỗi; không tự gắn PID mới hay đoán địa chỉ. Các guard Windows này chưa được kiểm với tiến trình Windows thật trong cloud Linux.

Tùy chọn: `--port 18801`, `--interval 100` (50–5000 ms). Ngắt bằng Ctrl+C. Không có tài khoản/tokens hay `.env` cần cấu hình.

### Ghi dữ liệu để đối chiếu

```bat
run.cmd --pid 1234 --profile game-profile.json --allow-unverified-profile --record captures\candidate.ndjson
```

Hoặc thử bằng fixture:

```bat
start-fixture.cmd --record captures\fixture.ndjson
```

Mỗi dòng là một envelope JSON `snapshot` hoặc `status`, giữ provenance và native metadata. File dùng chế độ tạo mới độc quyền; nếu tên đã tồn tại, host dừng trước khi mở server và giữ nguyên nội dung file. Thư mục cha được tạo nếu cần. Writer flush sau mỗi dòng và đóng khi Ctrl+C/shutdown hoàn tất.

`/api/status` có `recording.state`, `written`, `dropped`, `error`. Lỗi ghi chuyển recorder sang `error`, tăng `dropped`; collector/server tiếp tục chạy. Lỗi I/O có thể để lại dòng cuối chưa hoàn chỉnh, nên kiểm file trước khi dùng làm bằng chứng parity. Capture synthetic không thể chứng minh dữ liệu tài khoản/game thật.

## Endpoint

| Endpoint | Nội dung |
| --- | --- |
| `GET /api/snapshot` | Envelope snapshot gần nhất: `data` và `metadata` từ core |
| `GET /api/status` | Trạng thái, identity, provenance, độ mới, lỗi, object discovery |
| `ws://127.0.0.1:18801/ws` | Envelope `snapshot` và `status`, chỉ đọc |
| `GET /` | Thông tin endpoint dạng text |

Snapshot chưa có trả 204; snapshot quá cũ trả 503. Lỗi nguồn xóa cached snapshot. `fresh:true` nghĩa capture gần đây, không chứng minh đủ field hay đúng LB parity. `partial` nghĩa có field không đọc được; `waiting-for-roots` nghĩa chưa biết collection hero.

Envelope gồm `schemaVersion`, `sequence`, `timestamp`, `type`, `source:"independent-memory-reader"`, `synthetic`, `data`, `metadata`. Missing field đã khai báo giữ `null` cùng lý do. Field chưa có descriptor thì vắng, không được suy ra là 0. `metadata.runtimeVerified` phản ánh validation profile, không phải kết quả so sánh LB. Host luôn báo `lbParityVerified:false` vì chưa thực hiện đối chiếu đó.

Server chỉ bind loopback. Host/Origin của trình duyệt phải là localhost/127.0.0.1 cùng port. WebSocket chỉ nhận subscription; client gửi nội dung bị đóng mã 1008. Tối đa 32 client, queue 4 frame/client và bỏ frame cũ nếu đọc chậm. Đây là stream snapshot, không có bảo đảm giao mọi sự kiện.

## Build từ source

Trên cloud có SDK:

```sh
DOTNET_ROOT=/workspace/.tools/dotnet python3 build.py
DOTNET_ROOT=/workspace/.tools/dotnet python3 tests/integration.py
```

`build.py` dùng compiler Roslyn và framework reference .NET 10 trực tiếp, không NuGet restore. Native DLL phải build trước ở `../native`; script copy bản build đó vào dist. `dist/build.json` ghi hash source/assembly/native và `vendorReferences:[]`.

Windows có SDK .NET 10 có thể build project `src/IndependentCollector.csproj`; phải copy `lc_reader.dll` cùng thư mục assembly đầu ra. Phương án này chưa được thực thi tại cloud Linux.

Các điểm còn thiếu: object discovery tự động, profile offsets game đủ bằng chứng, sự kiện game/timer mục tiêu, kiểm chứng dữ liệu tài khoản và chạy thật trên Windows. Không thể coi việc chạy fixture thành công là hoàn thành các mục đó.
