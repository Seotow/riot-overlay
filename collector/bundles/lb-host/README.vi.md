# LeagueCollector chạy độc lập

**Bản cập nhật 2026-10-14:** đọc [STATUS.vi.md](STATUS.vi.md) trước khi thử.
Chưa chứng minh không đăng nhập vẫn thu đủ dữ liệu Free/giữ kết nối. Tài khoản
Free đã xác thực khác với client dùng bộ quyền rỗng. Hướng dẫn ghi lại lần
thử và xuất chẩn đoán nằm ở [WINDOWS-TEST.vi.md](WINDOWS-TEST.vi.md).

Đã có ứng dụng collector .NET chạy riêng, API JSON/WebSocket, trang theo dõi,
overlay mẫu cho OBS, ghi/phát lại và kết nối League Client. Gói Windows kèm
runtime .NET nên không cần cài SDK để chạy.

**Đây là bản cần kiểm thử với game trên Windows.** HTTP/WebSocket, serializer,
ghi/phát lại, API game local giả lập và LCU giả lập đã được kiểm thử trên cloud
Linux. Đăng nhập BlueBottle bằng C# đã thành công. Chưa chạy native collector
trong game thật; API subscription của tài khoản trả 404, chưa xác định quyền.

Mã ứng dụng và phần managed Farsight có thể build lại. Phần đọc bộ nhớ native
vẫn dùng `lblib.dll` chính thức đã tải, không phải C++ đã tái dựng hoàn chỉnh.
SHA-256 của DLL gốc:
`a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3`.

## Chạy bản Windows x64

1. Giải nén toàn bộ `LeagueCollector-Windows-x64.zip` vào thư mục có quyền ghi.
2. Chạy `start-demo.cmd` để kiểm tra ứng dụng và overlay bằng dữ liệu mẫu.
3. Mở `http://127.0.0.1:18799/`. Thêm
   `http://127.0.0.1:18799/overlay.html` vào Browser Source của OBS.
4. Muốn thu bằng lblib: dừng chế độ mẫu, chạy `start-collector.cmd`, rồi mở game
   spectator/replay phù hợp với phiên bản thư viện. Mã gốc chỉ hỗ trợ spectator;
   collector giữ kiểm tra này.
5. Nếu cần đăng nhập, sao chép `collector.env.example` thành `collector.env`,
   điền email/mật khẩu BlueBottle riêng và khởi động lại. Nội dung giữa hai dấu
   nháy được giữ nguyên, không chạy shell hoặc thay ký tự `$`, dấu nháy, dấu `#`.

Tệp tài khoản thật không nằm trong gói bàn giao. Token và AWS credentials chỉ
giữ trong bộ nhớ, có luồng refresh; không ghi chúng vào bản ghi game hoặc API.
Đăng nhập Google tương tác chưa có trong host này; đường email/mật khẩu đã kiểm.

`diagnose.cmd` kiểm tra hệ điều hành, kiến trúc và PE của DLL. Nó không xác nhận
thư viện đã chạy được trong game. Nếu ứng dụng LB khác đã khởi tạo lblib, có thể
dùng `start-collector.cmd --no-inject` để chỉ kết nối. Khi dừng, collector hủy
subscription của mình, không gửi lệnh Quit tới native server của các host khác.

## Các nguồn dữ liệu

| Nguồn | Lệnh | Phạm vi |
|---|---|---|
| lblib | `start-collector.cmd` | Các field GameInfo serializer hỗ trợ, theo dữ liệu/quyền native thực trả; cần Windows/game tương thích |
| Live Client Data API | `start-live-api.cmd` | Toàn bộ JSON trả từ API local 2999, không có camera/vị trí nội bộ như lblib |
| Mẫu | `start-demo.cmd` | Dữ liệu mô phỏng, luôn có `synthetic=true` |
| Bản ghi | Kéo tệp NDJSON vào `start-replay.cmd` | `source=replay`, giữ timestamp nguồn trong `recordedAt` |

LCU tự đọc lockfile cạnh `LeagueClientUx` và polling phase/chọn tướng. Token
chỉ dùng trên HTTPS loopback. Có thể đặt `--lockfile "đường dẫn\lockfile"`
hoặc tắt bằng `--no-lcu`. Kết nối lại khi API/game/client đổi trạng thái; LCU
đọc lại lockfile để nhận token/port mới. LCU hiện dùng polling, không phải WAMP.

## API cho overlay

| Đường dẫn | Nội dung |
|---|---|
| `/ws` | WebSocket JSON, sự kiện `snapshot`, `lcu`, `status` |
| `/api/snapshot` | Snapshot gần nhất còn mới; 204 khi chưa có, 503 nếu đã cũ |
| `/api/lcu` | Phase và session chọn tướng; trạng thái waiting khi mất client |
| `/api/status` | Nguồn, số frame, độ mới, auth và tình trạng bản ghi |
| `/api/health` | Tiến trình còn hoạt động; kiểm tra `collector.fresh` để biết có dữ liệu mới |
| `/api/schema` | Hợp đồng envelope và quy ước dữ liệu thiếu |

Ví dụ:

```json
{"schemaVersion":1,"sequence":42,"timestamp":"2026-10-14T00:00:00Z",
 "type":"snapshot","source":"lblib","synthetic":false,"recordedAt":null,
 "data":{"gameTime":123.5,"heroes":[],"camera":null}}
```

Chế độ lblib xuất các field schema được serializer hỗ trợ, gồm teamStats, heroes, minions,
turrets, buildings, missiles, particles, camera và events khi native cung cấp.
NaN/infinity được chuyển thành `null`. Native cũng có thể trả số 0 hoặc danh
sách rỗng cho phần thiếu quyền; schema không có marker cho từng field nên không
thể luôn phân biệt default này với giá trị thật. Collector giữ nguyên chúng,
không suy ra đầy đủ quyền từ một số 0. Các property tính toán/cache của Farsight
không được xuất.
Chế độ Live API giữ nguyên upstream tại `data.rawLiveClientData`; shape hero
của nguồn này khác native, không giả lập các trường mà API không có.

WebSocket có queue giới hạn cho mỗi client: client chậm có thể bỏ qua frame
cũ để bắt kịp trạng thái mới. Sequence giúp phát hiện khoảng trống. Luồng chỉ
đọc, không nhận lệnh điều khiển game. Server chỉ bind `127.0.0.1`; dashboard và
overlay cùng origin hoạt động trực tiếp. Các origin/Host khác bị từ chối; muốn
overlay tùy chỉnh thì phục vụ nó từ `wwwroot` trong cùng ứng dụng.

Đây là API của collector mới, chưa phải định dạng giao thức của mọi overlay LB
gốc. Muốn tái sử dụng overlay LB cụ thể cần adapter định dạng/trạng thái tương ứng.
Serializer hiện chưa xuất một số inline vector trong value struct, ví dụ
assister IDs. Xem `reference/` để biết field, mẫu và giới hạn chính xác hơn.

## Ghi và phát lại

```bat
start-collector.cmd --record "recordings\match-01.ndjson"
start-replay.cmd "recordings\match-01.ndjson" --loop --speed 1
```

Bản ghi gồm envelope NDJSON, timestamp, nguồn và nhãn synthetic. Không ghi đè
tệp có sẵn. Recorder báo `written` và `dropped`; kiểm tra `dropped=0` nếu cần
bản ghi liên tục. Dừng bình thường sẽ hoàn tất dòng đang ghi và xử lý queue.
Phát lại giữ nguồn gốc synthetic; dữ liệu sai định dạng sẽ dừng nguồn và hiện
error. Muốn dùng cổng khác: `--port 18800`; interval: `--interval 100` (ms).

## Phiên bản DLL và quyền

DLL kèm theo được chọn từ key `lblib-16.1.0-16.20.9999.dll`. Collector kiểm
SHA-256, PE và khoảng version trước khi khởi tạo. Khoảng version trong tên
không bảo đảm ABI/game offset đúng với mọi patch; vẫn cần thử game thực tế.

Nếu bản game nằm ngoài khoảng hoặc cần cập nhật, cần credential có quyền đọc
S3. `--update-lib` yêu cầu chọn/download root key phù hợp; không dùng bản backup,
không bỏ qua AccessDenied. Kết quả tải được kiểm PE, ghi tệp tạm rồi thay thế.

Gate đăng ký snapshot không yêu cầu Develop, nhưng native vẫn lọc một số dữ liệu
theo Basic/Pro/Enterprise. Hai lệnh dump yêu cầu Develop không được app gọi.
Host yêu cầu feature theo subscription server trả, chuyển challenge lên server
ký và để DLL xác minh. Không tự gán hoặc nâng quyền. Nếu subscription chưa xác
định, UI thông báo và không hứa có đủ dữ liệu nâng cao.

Fork managed chọn transport TCP loopback có kiểm tra PID/session của server,
là nhánh đã có trong bản gốc, phù hợp host chưa ký executable. Nó vẫn giữ xác
thực feature và mọi kiểm tra quyền của DLL. Hai thay đổi transport có ghi ở
`THIRD-PARTY.md`; DLL native giữ nguyên bytes.

## Build từ nguồn

Cần SDK .NET 10 x64 và Python 3 cho đường build đã kiểm thử:

```bash
DOTNET_ROOT=/duong-dan/dotnet python3 build.py
dotnet dist/app/LeagueCollector.dll --self-test
dotnet dist/app/LeagueCollector.dll --source demo --no-lcu
python3 tests/integration.py
```

Trên PowerShell: đặt `$env:DOTNET_ROOT` rồi `python build.py`. SDK project ở
`src/LeagueCollector/LeagueCollector.csproj`, tham chiếu nguồn `vendor/Farsight`.
Build cloud dùng compiler Roslyn trực tiếp vì NuGet migration named mutex của
`dotnet build` không dùng được ở sandbox. Đường SDK/MSBuild trên Windows chưa
được chạy. Các dependency managed có sẵn ở `lib/`, không cần NuGet restore cho
script. Không cần build native DLL để dùng bản binary đã có.

`package.py` tạo gói app Windows và gói source, kèm manifest SHA-256. Runtime
Windows .NET/ASP.NET Core 10.0.13 được tải chính thức và đối chiếu SHA-512 trong
release metadata. Báo cáo kiểm thử ở `verification/` trong gói chạy.

## Giới hạn xác nhận hiện tại

- Đã build không có lỗi; còn cảnh báo ở nguồn Farsight dịch ngược và reference
  version của SDK. Self-test/kiểm thử tích hợp đã qua, không thay cho game thật.
- Chưa kiểm tra Windows injection/IPC với LoL, nhiều trận liên tiếp, overlay OBS
  trong trận, hoặc quyền Pro/Enterprise thực tế.
- Chưa tái dựng source C++ hoàn chỉnh của lblib. Gói source chứa native binary.
- Chưa đối chiếu đầy đủ dữ liệu Free với LB gốc. API subscription của lần
  kiểm tra trước trả 404; quyền vẫn chưa xác định. Nhánh không đăng nhập cũng
  chưa được kiểm chứng giữ kết nối và trả đủ dữ liệu.

Vì các điểm này, chưa thể xác nhận mục tiêu collector hoàn chỉnh với dữ liệu
game thật đã hoàn tất. Bước xác nhận còn thiếu cần Windows x64 có game/replay
đúng phiên bản và đối chiếu LB Free trong cùng một trận, phân biệt phiên có
xác thực với phiên chưa xác thực.
