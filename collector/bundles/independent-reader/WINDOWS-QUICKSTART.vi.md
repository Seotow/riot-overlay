# Chạy thử LeagueReader riêng trên Windows x64

Đây là bản thử nghiệm 0.1, **chưa thay thế collector LB dùng trong trận thật**.
Không cần tài khoản LB cho mã mới. Gói có DLL C++ riêng, host HTTP/WebSocket
và .NET/ASP.NET Core runtime; không có `lblib.dll` hay Farsight. Chưa chạy
Windows/game thật trong cloud. Giải nén toàn bộ trước khi chạy.

1. Mở `start-fixture.cmd`, rồi mở
   `http://127.0.0.1:18801/api/status` và `/api/snapshot`.
   Đây là dữ liệu tổng hợp kiểm pipeline; `synthetic:true` không phải dữ liệu
   LoL. Đóng bằng Ctrl+C trước khi thử tiến trình thật.
2. Khi game đang chạy, xác định PID của **tiến trình game**, mở Command Prompt
   tại thư mục vừa giải nén và chạy:

```bat
run.cmd --identity --pid 1234 > identity.json
```

PID 1234 chỉ minh họa. Lệnh này đo tên file/version/hash/base, không thu game
snapshot và không đăng nhập. Nếu thất bại, thông báo lỗi ở cửa sổ dòng lệnh;
file identity rỗng không phải kết quả hợp lệ. Đọc file xem có JSON đo thành
công trước khi tiếp tục.

3. Có Python 3.10+ và đúng executable của game thì có thể tạo profile bằng
   `tools/profiles/README.vi.md`. Không có Python thì vẫn chạy được fixture và
   lệnh identity. Resolver có thể chỉ resolve một phần hoặc không resolve.
4. Chạy profile thử nghiệm:

```bat
run.cmd --pid 1234 --profile game-profile.json --allow-unverified-profile --record independent.ndjson
```

`--record` tạo file mới; đổi tên output nếu đã tồn tại. Chưa tự tìm danh sách
hero, nên `waiting-for-roots` và `heroes:null` là giới hạn dự kiến. Không coi
HTTP 200, hash khớp hoặc một gameTime đọc được là đã thu đủ dữ liệu Free.
Profile không tạo ra hero roots; địa chỉ first/next function trong report
chưa được host sử dụng để duyệt đối tượng.

Kết quả hữu ích để phân tích tiếp: `identity.json`, `resolution-report.json`,
`/api/status`, recording nếu thu được, phiên bản game và spectator/replay.
Đối chiếu LB còn cần snapshot native của phiên LB đang hoạt động bằng tài
khoản hiện tại cùng một game/cửa sổ thời gian. Không gửi mật khẩu/token.

Xem `HOST.vi.md` cho chi tiết endpoint/recording, `README.vi.md` cho phạm vi
13 field và những phần chưa hoàn tất. Dữ liệu fixture chứa thêm ví dụ KDA/tên
để kiểm kiểu dữ liệu của C ABI; các ví dụ đó không có nghĩa reader LoL đã phục
hồi được KDA/tên.
