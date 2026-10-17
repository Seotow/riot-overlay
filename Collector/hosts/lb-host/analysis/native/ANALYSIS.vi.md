# Phân tích native lblib: collector và xác thực

## Kết quả chính

Đã dịch ngược có chọn lọc 246 hàm native, gồm 224 hàm trong vùng gần các hàm đọc
đối tượng và dựng snapshot, cộng các hàm khởi tạo, IPC, dispatcher và xác thực.
Đã xác định đường đi tới `GameInfo` và những kiểm tra quyền nằm ngay trong
collector. Đây là pseudocode để nghiên cứu và tái dựng, chưa phải dự án C++
biên dịch được hoặc toàn bộ nguồn gốc của lblib.

## Artifact và phương pháp

- Tệp: `lblib.dll`, 14.187.936 byte; tải có xác thực từ root key
  `lblib-16.1.0-16.20.9999.dll`, không lấy bản backup.
- SHA-256: `a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3`.
- PE32+, AMD64, native C++; image base `0x180000000`, entry RVA `0x977760`.
- Timestamp trong header: 2026-10-06 18:23:52 UTC; đây là metadata tự khai báo.
- 21 export: `BlueBottleHook`, `DllMain` và 19 API AngelScript.
- CodeView tham chiếu `D:/a/Farsight/Farsight/x64/Release/lblib.pdb`; chưa có PDB.
- REA 6.4.0 với Ghidra 12.1.4, JDK 21. `pseudocode-index.json` gắn từng hàm với
  Evidence ID, SHA-256 và analysis profile. `.cpp` trong `pseudocode/` là văn bản
  từ decompiler, không có đủ kiểu/global/helper để build trực tiếp.
- Vùng ứng viên `[0x180420000, 0x180443500)` được chọn theo địa chỉ gần các hàm
  đã xác định. 224/224 truy vấn trả pseudocode, không chứng minh cả vùng chỉ có
  collector hoặc đã bao phủ hết phụ thuộc. Chưa kiểm tra thủ công từng hàm.

DLL không được thực thi, nạp hoặc inject. Bytes nguồn được giữ nguyên.

## Đường đi dữ liệu đã xác định

```text
DllMain -> startup worker -> kiểm tra/khởi tạo môi trường game
  -> server IPC -> RegisterService(LeagueBroadcastLiveSnapshot = 2)
  -> đăng ký callback tick và callback sự kiện game
  -> gom sự kiện, duyệt đối tượng trong game, dựng FlatBuffer GameInfo
  -> queue của từng client -> TCP 127.0.0.1:4998 hoặc named pipe
  -> Farsight -> LeagueConnector.GameInfoReceived
  -> LocalFarsightDataSource -> IngameState -> dữ liệu overlay
```

| Thành phần | Địa chỉ VA trong DLL này | Quan sát |
|---|---|---|
| Hook export | `0x18042d8e0` | Gọi tiếp `CallNextHookEx` |
| DllMain | `0x18042d900` | Tạo worker thread |
| Startup worker | `0x18042ee00` | Lấy game module, khởi tạo và mở IPC |
| TCP listener | `0x1803c9060` | AF_INET/SOCK_STREAM, loopback, port 4998 |
| TCP accept | `0x1803c0440` | Tạo session TCP và đăng ký client |
| Named pipe accept | `0x1803c1580` | Kiểm tra process và các nhánh trust |
| Client receive/send | `0x1803be810` / `0x1803bf150` | Nhận frame, queue request/response |
| Request dispatcher | `0x1803db830` | Phân nhánh theo RequestKind |
| RegisterService | `0x1803da5d0` | Tạo service theo ServiceType và kiểm tra gate |
| Snapshot tick | `0x180410710` | Kiểm tra interval, lặp subscriber, truyền feature từng client cho builder |
| Snapshot builder | `0x18043eea0` | Duyệt đối tượng, dựng các vector và root GameInfo |
| First/next object | `0x180425d20` / `0x180425de0` | Gọi hàm game qua địa chỉ phân giải |

Startup đặt `DAT_180d20bd0` bằng `GetModuleHandleW(NULL)`. Các reader dùng game
module cộng RVA/offset đã phân giải và truy cập con trỏ nội bộ. Đó là collector
chạy trong tiến trình game; không phải gọi HTTP Live Client Data API cổng 2999.
Một số offset và đích gọi đi qua helper giải mã. Đích gián tiếp, layout đối tượng
và tính tương thích phiên bản vẫn cần kiểm chứng; không coi mọi offset tĩnh là
địa chỉ hợp lệ cho mọi bản game.

Transport dùng frame tiền tố độ dài 4 byte và FlatBuffers theo managed client.
Named pipe có magic `BBP2`; nó có thêm nhận diện process, session Windows, SID
và trust chữ ký executable. `IdentifyClient` trong dispatcher chủ yếu ghi nhận
AppId; nó khác bước xác thực feature.

## Quyền của collector

| Phần đã theo dõi | Điều kiện trong DLL | Ý nghĩa |
|---|---|---|
| Đăng ký `LeagueBroadcastLiveSnapshot` | Vtable `0x180c6fb88`, slot `+0x20` trỏ tới `0x180183380`, bytes `b0 01 c3` | Gate trả true, không kiểm tra Develop tại bước đăng ký |
| Đăng ký Zenos snapshot | Gate riêng tại `0x180406490` | Kiểm tra bit Enterprise; không được áp điều kiện này sang LB snapshot |
| Dữ liệu Missile | `0x18043da00` kiểm tra bit 1 | Thiếu Pro trả offset 0; nhận diện table bằng schema Info/SourceIdx/TargetIdx/StartPos/EndPos |
| Camera | `0x18043e580` kiểm tra bit 2 | Thiếu Enterprise trả offset 0; table khớp ScreenX/ScreenY/View/Proj/FocusPosition/AutoDirector |
| Rotation của ObjectInfo | `0x1804395d0` kiểm tra bit 2 | Thiếu Enterprise dùng NaN; các field khác đi qua logic riêng |
| Sự kiện game | `0x18043e9e0` kiểm tra bit 0/1/2 | Loại bớt một số danh sách và thay một số trường bằng giá trị mặc định |
| Một số phần hero/common | `0x18043c210`, `0x180439a70` | Có kiểm tra Basic/Enterprise; chưa lập bảng đầy đủ cho từng field |
| OffsetDump / ObjectAddressDump | `0x1803e5af0` / `0x1803e5ef0`, mask `0x200` | Hai lệnh chẩn đoán yêu cầu Develop |

Tên Basic/Pro/Enterprise/Develop đối chiếu với enum managed: bit 0/1/2/9.
`0x180393770` thực hiện phép kiểm tra bit và chỉ chấp nhận 15 feature đã biết.
Các tên table ở trên là đối chiếu cấu trúc FlatBuffer với C# đã khôi phục, chưa
phải quan sát gói dữ liệu của trận thật. `snapshot-feature-checks.json` lưu các
vị trí kiểm tra tìm được; đây không phải phân tích data-flow bao phủ toàn DLL.

Hàm tick chép feature client vào serializer trước khi dựng snapshot. Vì vậy
đăng ký service thành công không đồng nghĩa nhận đủ dữ liệu. Kết nối TCP và
named pipe còn có policy khác nhau: TCP dùng predicate `+0x20 = false`; named
pipe dùng predicate theo trường `+0x170`. Nhánh pipe cần proof còn yêu cầu
Develop sau khi xác minh chữ ký và có trạng thái/deadline phiên. Không được
kết luận mọi client đều cần Develop hoặc mọi client tùy ý đều được chấp nhận.

## Bắt tay xác thực native

1. `AuthenticationStart` tới `0x1803e6330`: `BCryptGenRandom` tạo nonce 12 byte,
   lưu vào session và trả `AuthenticationChallenge`.
2. Host C# gửi nonce tới `subscription-status/sign-challenge-v2` bằng request có
   xác thực, nhận signature 64 byte và feature bits.
3. `AuthenticationVerify` tới `0x1803e6780`, gọi `0x180393790`: xác minh chữ ký
   bằng OpenSSL và khóa nhúng. Payload thấy trong mã gồm nonce 12 byte và
   4 byte đầu của feature word. Nonce bị tiêu thụ trước khi verify.
4. Thành công lưu feature vào client. Enterprise bao hàm Pro, Pro bao hàm Basic.
   Các client thuộc nhánh cho phép còn chia sẻ hợp feature qua server trong
   cùng tiến trình. Đây là trạng thái bộ nhớ, chưa thấy cache bền vững trong
   các hàm đã theo dõi.

Không có cơ sở nói auth chỉ dùng tải DLL. Cũng chưa có cơ sở nói mọi lần chạy
đều gọi server: managed client có nhánh feature rỗng; native có kế thừa quyền
trong tiến trình. DLL giữ nguyên vẫn kiểm tra chữ ký cho những quyền cần proof.
Mã phân tích và bộ collector bàn giao giữ các bước xác thực hiện có.

Đính chính về Free: `FeatureSet.Empty` ở managed không tự chứng minh phiên
Free đã được DLL chấp nhận. Đã đối chiếu assembly `0x1803bdd40`: khi deadline
hết và trạng thái phiên vẫn là 0, native chuyển trạng thái sang 2 và đóng
kết nối. Dispatcher gọi kiểm tra này trước request, và nhánh cần proof giới
hạn request trước trạng thái 1. TCP/named pipe có cờ khởi tạo khác nhau nên
chưa thể suy ra mọi client không auth đều bị ngắt. Chi tiết và giới hạn ở
`../standalone/reference/AUTH-STATUS.vi.md`; assembly mới được lưu trong
`client-auth-deadline-assembly.txt`.

## Bằng chứng tiêu biểu

- RegisterService: `ev_f50661c563bb38a0fdae3b354bea8849fa094d8d93350910be9ffa5effa366f4`.
- Gate bytes: `ev_5a3945d70f91ca4962f9334cf3c561dfdc447114c52e0e5a884c6a636225fffc`;
  vtable: `ev_47106dc410ab347b912b560d2b8ba9dbfd290e702c77a0e3943712a823ecfaa7`.
- Tick: `ev_86ab94cb5bf793e7e3194ddfa1d28c9b1d5d2a27d9d8d9f8f47f76d3e9dd67c1`.
- Builder: `ev_967c2da169c9ec8074a59f30e796dd74ff026e7ba937d9d0c373e26b399ba6a7`.
- Events: `ev_e01dec728266452a9c114a3598a92cf428be2d5ee6699238c7099e12ef19ff9d`.
- Verify signature: `ev_fd4ccf26a8ecab26267bcba7a556ccf88402c851181e113e91b7015296579086`.
- Verify handler: `ev_3b2bc7919640ed00d9c7bc0a5a0b023def0d9cb0cdd5a453ec6d53b3f86c27f0`.

Các JSON Evidence giữ cả kết quả và limitations. Snapshot/cache cùng bundle
của phiên REA mới đã được xuất trước khi đóng provider; các Evidence giai đoạn
trước vẫn giữ từng tệp riêng. Ba helper nhỏ chưa được REA auto-analysis định
nghĩa thành procedure; đã đối chiếu bằng bytes gốc, `read_bytes` và profile
Ghidra focused riêng trong `focused/`. Không coi kết quả focused là cùng
analysis profile với REA default.

## Những phần chưa hoàn tất

- Chưa có project C++ gốc, PDB, kiểu chính xác, build settings hoặc dependency
  closure đủ để dựng lại native DLL từ pseudocode.
- Chưa kiểm thử game/replay, Windows, injection/lifecycle hoặc overlay OBS.
- Chưa lập ma trận mọi field snapshot theo từng quyền; chưa kiểm tra một collector
  host mới với bộ feature rỗng trên game thật.
- Địa chỉ/offset và kết luận chỉ gắn với SHA-256 này; tên version trong S3 không
  tự chứng minh tương thích mọi patch của LoL.

Phần managed đã build và fixture tổng hợp đã kiểm tra ở `../collector/`.
Mốc tiếp theo của việc tái dựng là phục hồi kiểu và phụ thuộc của native reader,
đối chiếu đầy đủ schema/feature, rồi kiểm thử trên Windows có game/replay phù hợp.
