# Nghiên cứu nguồn in-game thay thế LeagueBroadcast

## Ghi chú điều tra BlueBottle từ trao đổi bổ sung, 26/09/2026

### Kết luận có giới hạn

Thông tin người dùng cung cấp từ Discord nói BlueBottle đọc memory. Kết hợp với artifact đã kiểm tra trên máy (đường `Farsight.LibInjector`, export `BlueBottleHook`, module `lblib.dll`, NamedPipe/FlatBuffers và output đủ các field không có trong Riot spectator API), đánh giá hiện tại là **STRONG EVIDENCE** rằng backend acquisition của BlueBottle lấy state bên trong tiến trình game và có khả năng dùng memory reading. Chưa có call trace hoặc method body native chứng minh chính xác field nào được lấy bằng cách nào, nên không nâng phát biểu đó thành **CONFIRMED** cho collector hiện hành.

Việc ứng dụng vẫn chạy cùng Vanguard không chứng minh cơ chế tương tự do bên thứ ba tự viết sẽ được cho phép. Lý do tương thích có thể liên quan chữ ký, quan hệ thương mại, entitlement, phiên bản module hoặc cơ chế riêng khác; tất cả hiện là **UNKNOWN**. Không dùng hành vi quan sát được của BlueBottle làm tiền lệ để né anti-cheat.

Phải giữ tách biệt hai lớp:

- **Frontend JavaScript client:** kết nối `ws://127.0.0.1:58869/ws/in`, nhận schema JSON, heartbeat và nội suy clock. Đây là consumer/wrapper, không thu state từ LoL.
- **Backend acquisition:** phát hiện phiên game, quản lý `lblib.dll`, tích hợp với tiến trình game, chuyển snapshot qua NamedPipe/FlatBuffers, chuẩn hóa rồi mới xuất HTTP/WebSocket. Phần lấy field bên trong `lblib.dll` vẫn chưa được xác định đầy đủ.

### Nhãn độ tin cậy

- **CONFIRMED:** có artifact trực tiếp, log/capture lặp lại hoặc kiểm tra tĩnh xác định đúng mệnh đề.
- **STRONG EVIDENCE:** nhiều dấu vết độc lập cùng chỉ về một kết luận nhưng còn thiếu call trace hoặc thử nghiệm quyết định.
- **HYPOTHESIS:** giải thích hợp lý cần phép thử phân biệt; không dùng làm đầu vào triển khai.
- **UNKNOWN:** chưa có bằng chứng đủ để chọn giữa các khả năng.

Nhãn luôn gắn với một mệnh đề cụ thể. Ví dụ, WebSocket 58869 xuất frame là **CONFIRMED**; JavaScript client là collector là sai; memory reading trong collector hiện hành là **STRONG EVIDENCE**; lý do Vanguard cho phép là **UNKNOWN**.

### Baseline dynamic OutOfGame, 26/09/2026

Snapshot lúc `2026-09-26T03:19Z` được lấy khi Riot/League Client và LeagueBroadcast đang mở nhưng chưa vào replay/custom; `League of Legends.exe` chưa tồn tại. Đây là quan sát thụ động trên laptop lab, không attach/debug, không mở NamedPipe riêng và không đọc memory.

- **CONFIRMED:** `BlueBottleClient.Interface.exe` sở hữu listener `:::58869`. WebView của chính ứng dụng có ba kết nối loopback tới cổng này; owner chưa đổi trong baseline.
- **CONFIRMED:** process LB đã nạp `Farsight.dll` và `BlueBottleClient.GameLib.dll`, nhưng không thấy `lblib.dll` trong các process League/Riot/BlueBottle được liệt kê ở trạng thái này. Điều này tạo mốc để diff khi Loading/Running, chưa chứng minh lúc nào code acquisition thực thi.
- **CONFIRMED:** log ghi `LocalFarsightDataSource starting, waiting for game`, sau đó `started`, trong khi trạng thái vẫn `OutOfGame`. Log cũng ghi Replay API được phát hiện và bật.
- **CONFIRMED:** capture công khai `/ws/in` trong 5 giây nhận đúng một `gameStatus` với `gameState=0`, không có `ingame-state-update`, không disconnect hoặc message lỗi. Artifact cục bộ nằm trong `data/captures/lb-2026-09-26T03-19-05-898Z/` và bị Git ignore.
- **CONFIRMED:** LB có các kết nối loopback tới LCU `127.0.0.1:50474` và một kết nối HTTPS tới `178.105.0.170`; DNS tại thời điểm chụp ánh xạ địa chỉ này tới `broadcast.bluebottle.gg`. Log xác nhận kết nối `wss://broadcast.bluebottle.gg/ws/rpc`.
- **UNKNOWN:** kết nối cloud quan sát được là control-plane/auth/telemetry hay có mang gameplay khi Running. Baseline OutOfGame không đủ phân biệt; cần diff endpoint/cadence/byte count khi Loading và Running.
- **CONFIRMED:** file chạy LB tại bản cài `current` có SHA-256 `7CF766740B92177F59E8A8FABE9E1595A0BA51D8E2ADD74E516A0E26D57410F5`; Windows báo chữ ký hợp lệ của BlueBottle GmbH tại thời điểm kiểm tra.

Bước quyết định tiếp theo là lặp cùng snapshot ngay khi `League of Legends.exe` xuất hiện ở Loading và khi spectator Running, ưu tiên module diff (`lblib.dll`), owner/connection cổng, log IPC và public WebSocket. Không cần Procmon hoặc handle inventory trước khi phép so sánh ít xâm nhập này hoàn tất.

### Chuyển trạng thái custom spectator, 26/09/2026

Đã chụp liên tục từ champ-select tới Running trong cùng phiên LB/process. Các mốc UTC lấy từ log và NDJSON:

- `03:31:08`: `League of Legends.exe` xuất hiện.
- `03:31:33`: public WebSocket chuyển `gameState` từ `0` sang `1`; log ghi `OutOfGame -> Loading`.
- `03:31:56.334`: Farsight ghi `IPC2 - Connected using NamedPipe`.
- `03:31:56.449`: log chuyển `Loading -> Running`; public WebSocket chuyển `gameState=2` và bắt đầu phát `ingame-state-update`.
- Từ `03:31:56` tới `03:32:23`: capture nhận 54 update, median 506 ms, min 335 ms, max 526 ms.
- `03:32:19`: `tasklist /m lblib.dll` xác nhận `lblib.dll` đang được nạp trong `BlueBottleClient.Interface.exe`. Trước Loading module không xuất hiện; sau lỗi IPC module không còn được liệt kê.
- `03:32:23.899`: Farsight lỗi parse `Snapshot.Response` từ NamedPipe, `uoffset_t=1` trong vector đã ánh xạ tới `AIHeroClient`.
- `03:32:24`: public WebSocket trở về `gameState=0`. Quan sát thêm 60 giây chỉ có một `gameStatus`, không có update; `lblib.dll` không xuất hiện lại dù game vẫn chạy. LB không tự phục hồi collector trong khoảng quan sát này.

**CONFIRMED:** lifecycle `lblib.dll` trong process LB, kết nối NamedPipe, trạng thái Running và frame WebSocket có tương quan thời gian trực tiếp. Khi Running, LB mở thêm bốn kết nối loopback tới Live Client API `127.0.0.1:2999`; listener 58869 vẫn thuộc cùng process.

**UNKNOWN:** module có đồng thời được map vào `League of Legends.exe` hay không. PowerShell chỉ liệt kê được một module của game process và `tasklist` chỉ báo bản được thấy trong process LB, nên kết quả âm tính đối với game không đáng tin. Không nâng quyền, dùng driver, attach hoặc mở process để vượt giới hạn quan sát này.

**UNKNOWN:** Running có thêm một kết nối HTTPS thứ hai tới cùng địa chỉ `178.105.0.170` của `broadcast.bluebottle.gg`, nhưng bảng socket không cho biết byte/cadence. Chưa thể phân loại đây là gameplay, telemetry hay control-plane. Muốn phân biệt cần packet metadata theo PID; bước đó có thể yêu cầu quyền admin/công cụ capture và phải xin người dùng trước.

Artifact cục bộ: `data/captures/lb-2026-09-26T03-30-43-117Z/` (59 message: 5 status, 54 update) và capture hậu lỗi `data/captures/lb-2026-09-26T03-33-23-643Z/` (chỉ 1 status). Cả hai bị Git ignore và giữ payload gameplay cục bộ.

Lần custom thứ hai lặp lại cùng lifecycle: Loading `03:37:36`, NamedPipe/Running `03:38:01`, lỗi IPC `03:38:51`, OutOfGame `03:38:52`. Capture `data/captures/lb-2026-09-26T03-37-50-293Z/` nhận 101 update với median 508 ms (min 212, max 534 ms). Khi Running, PowerShell đọc được module đang nạp tại `C:\Users\Seotow\AppData\Local\LeagueBroadcast\current\lblib.dll`, kích thước mapping 14.487.552 byte, SHA-256 `4F9BEEF18CFC9672C0A27EA38A0CCD2B53DC4313BE2C3C4F51669DE0599443C5`, chữ ký Windows hợp lệ của BlueBottle GmbH. Module biến mất khỏi process LB sau lỗi. Hai lần độc lập cùng thứ tự loại bỏ khả năng đây chỉ là tương quan ngẫu nhiên của một phiên.

### Call chain lifecycle đã xác định bằng IL tĩnh

Dynamic ở trên khoanh đúng đường cần đọc; IL hiện tại của `Farsight.dll` xác nhận:

1. `LeagueConnector.UpdateAndInjectLib` giữ injection lock theo game PID. Nếu host khác sở hữu injection hoặc server lblib đã tồn tại, nó chỉ kết nối `FarsightSocketClient` tới loopback.
2. Nếu cần khởi tạo, method cập nhật/kiểm tra `lblib.dll`, rồi gọi `_injector.Inject(dllPath, GameWindowOpenedEventArgs.WindowHandle, cancellationToken)`.
3. `LibInjector.Inject` validate DLL, lấy thread/process từ window LoL, và gọi `IsSpectator`. Method `IsSpectator` poll `https://127.0.0.1:2999/liveclientdata/activeplayername/` tới khi giá trị là `Spectator`; vì vậy ít nhất một phần traffic 2999 là cổng xác nhận, không phải bằng chứng các field gameplay của LB đến từ API này.
4. Sau khi xác nhận spectator, `Inject` gọi `LoadLibraryEx` trong host LB, lấy địa chỉ export `BlueBottleHook`, gọi `SetWindowsHookEx` với hook id 3 và thread của cửa sổ LoL, rồi `PostThreadMessage` để kích hoạt hook.
5. Sau khi init thành công, `UpdateAndInjectLib` kết nối `FarsightSocketClient` tới loopback và chờ NamedPipe producer. `LibInjector.Release` gọi `UnhookWindowsHookEx` rồi `FreeLibrary`, khớp việc bản `lblib.dll` trong process LB biến mất sau lỗi.

Mức kết luận: đường Windows hook/injection là **CONFIRMED trong binary hiện hành** và đã được dynamic liên kết với lifecycle Running/NamedPipe. Việc module được map thành công bên trong game ở hai phiên cụ thể vẫn là **STRONG EVIDENCE**, không phải quan sát module trực tiếp, vì hệ điều hành chỉ cho tool không nâng quyền thấy một module của game process. Không dùng debugger/driver/quyền cao để vượt giới hạn này.

### Restart LB giữa spectator và đo cloud metadata, 26/09/2026

LB được đóng/mở lại trong khi một custom spectator khác đang chạy. Process mới tự tìm game và tái khởi tạo collector mà không cần khởi động lại game:

- `03:52:14` Loading; `03:52:37` NamedPipe connected và Running; `lblib.dll` xuất hiện trong process LB.
- `03:52:38.492` tới `03:53:25.214`: public feed nhận 92 update trong 46,722 giây. Tổng JSON message khoảng 1.534.301 byte, trung bình 16.677 byte/update.
- `03:53:25.724` lỗi FlatBuffers cùng vector; `03:53:26` OutOfGame; `lblib.dll` unload ngay sau đó.

Theo accept của người dùng, Windows Packet Monitor được chạy elevated ở chế độ **counters-only**, filter duy nhất `178.105.0.170:443`; không ghi packet payload. Trong cửa sổ khớp 47,31 giây của public feed, endpoint `broadcast.bluebottle.gg` chỉ có 16 packet/1.789 byte nhận và 16 packet/2.186 byte gửi. So với 1,53 MB JSON gameplay được phát local trong cùng khoảng, đây là **STRONG EVIDENCE** endpoint broadcast không mang snapshot gameplay 2 Hz; cadence/volume phù hợp control-plane hoặc heartbeat hơn.

LB còn mở endpoint AWS/Cloudflare trong lúc khởi động. Log cùng thời điểm ghi login, CommunityDragon/cache và tìm `lblib-16.1.0-16.19.9999.dll` trong S3 bucket `bb-lb-libs`; các connection này đã đóng sau startup/collector failure, chỉ connection broadcast còn duy trì. Chưa đo byte riêng từng endpoint nên không khẳng định mọi traffic cloud đều không liên quan gameplay. Native `lblib.dll` cũng import `WS2_32.dll`, vì vậy chỉ import network không đủ xác định provenance. Tuy nhiên chuỗi thời gian NamedPipe -> update local, kết hợp lượng traffic cực thấp ở broadcast endpoint, củng cố kết luận acquisition chính nằm ở producer native/local chứ không phải WebSocket cloud.

Artifact: `data/captures/lb-2026-09-26T03-52-28-207Z/` và `data/captures/pktmon-lb-2026-09-26T10-47/`; cả hai bị Git ignore. Packet counter helper tự dừng, xóa filter do nó tạo và ghi `stopped.txt` sau cửa sổ tối đa 12 phút.

### Lab chỉ dùng laptop

PC chính và account chính nằm ngoài phạm vi: không cài BlueBottle, debugger, memory scanner, injector hay tool nghiên cứu; chỉ dùng LoL bình thường. Laptop là thiết bị nghiên cứu riêng, dùng account test không có giá trị và được coi là thiết bị có thể chịu enforcement/HWID risk. Máy ảo không được coi là ranh giới an toàn hoặc cách né ban.

Trước khi chạy, lưu bản cài/binary, phiên bản, kích thước, SHA-256, chữ ký số và thời gian thu vào thư mục nghiên cứu riêng. Không đưa credential, token, lockfile hoặc danh tính người chơi vào ghi chú/Git. Mọi quan sát phải ghi timestamp, game mode, patch, trạng thái spectator và artifact nguồn để có thể đối chiếu.

### Quy trình dynamic, từ ít xâm nhập đến nhiều thông tin hơn

1. **Baseline:** snapshot process/service, cổng nghe, file hash/chữ ký, log và trạng thái game khi BlueBottle chưa chạy.
2. **Process tree và cổng 58869:** xác định PID cha/con, executable đã ký nào sở hữu listener, thời điểm listener xuất hiện và thay đổi qua từng trạng thái.
3. **Procmon:** lọc theo PID/path BlueBottle và LoL để ghi file, registry, process/thread và network events; không sửa filter thành hành động can thiệp.
4. **Chuyển sang spectator:** chụp cùng một bộ snapshot trước khi vào trận, lúc Loading, Running và OutOfGame; đồng bộ với log/health và frame WebSocket.
5. **Module diff:** so sánh module của BlueBottle và LoL giữa các snapshot, ghi path/hash/signer; sự xuất hiện của module chỉ chứng minh module được load, không tự chứng minh method nào đã chạy.
6. **Process handles:** thống kê owner, target và loại handle hiện có; không tự mở handle mới tới LoL, không duplicate handle và không đọc memory.
7. **Network/IPC:** ghi endpoint loopback, owner, connection direction và tên pipe đã được hệ điều hành/log công khai; không kết nối, chiếm, giả danh hoặc fuzz NamedPipe riêng.
8. **WebSocket schema:** chỉ quan sát output được ứng dụng công khai tại `/ws/in`, lưu message type, cadence, field presence/nullability và chuyển trạng thái; không gửi command game hoặc suy collector từ schema frontend.

Mỗi phase phải có baseline đối chứng và bảng thời gian chung. Nếu artifact không phân biệt được hai giả thuyết, giữ nhãn **UNKNOWN** thay vì suy từ tên file, import hoặc timing trùng nhau.

### Static analysis có mục tiêu sau dynamic

- Dùng DIE/PE-bear để phân loại PE, packer/runtime, import/export, section và chữ ký.
- Nếu là .NET, dùng ILSpy/dnSpyEx để đọc type, call graph và đường orchestration/serialization; không patch hoặc chạy method nghiên cứu.
- Nếu là native, dùng Ghidra để đi từ export/import và callsite đã được dynamic khoanh vùng; ưu tiên `BlueBottleHook`, pipe/serializer, module lifecycle và đường tạo field. Không biến phân tích thành bản sao collector.

Mục tiêu là kiểm chứng kiến trúc và thu hẹp **UNKNOWN**, không viết injector, reader, bypass hoặc cơ chế tương tác memory. Kết quả static phải nêu rõ “import tồn tại”, “callsite reachable” hay “đã quan sát thực thi”; ba mức này không tương đương.

### Mô hình rủi ro

- **GREEN — observe:** hash/chữ ký, process tree, owner cổng, log, Procmon, snapshot module/handle do hệ điều hành liệt kê, traffic loopback và WebSocket output công khai.
- **YELLOW — analyze:** decompile/disassemble file trên đĩa, đối chiếu call graph, metadata/strings và schema; kiểm tra điều khoản/license trước khi lưu hoặc chia sẻ trích xuất.
- **RED — không thực hiện:** injection/hook mới, patch binary/game, gọi hoặc tái sử dụng collector DLL, mở process để đọc/ghi memory, duplicate handle, chiếm/giả danh IPC, kernel driver, làm giả entitlement/tournament hoặc bất kỳ anti-cheat bypass nào.

### Sáu câu hỏi điều tra cần trả lời

1. Process/executable nào thực sự sở hữu listener `127.0.0.1:58869`, và owner có đổi theo trạng thái không?
2. Gold/CS bắt nguồn từ Riot API, module native, OCR hay một nguồn khác; artifact nào chứng minh provenance từng field?
3. Thành phần nào tương tác trực tiếp với tiến trình LoL, bằng handle/module/IPC nào, và interaction nào thực sự được quan sát thay vì chỉ suy từ import?
4. Pipeline chỉ chạy trong custom spectator/tournament hay cũng chạy trong normal game/replay; field, cadence và entitlement khác nhau thế nào?
5. Có module BlueBottle nào được load bên trong tiến trình LoL; path/hash/signer và thời điểm load/unload là gì?
6. Pipeline thu và xử lý hoàn toàn local hay có bước cloud; endpoint nào mang telemetry, auth, asset hoặc chỉ control-plane?

Ghi đáp án vào ma trận bằng chứng với nhãn confidence và link tới artifact; không trả lời bằng tên sản phẩm, tuyên bố marketing hoặc một lần quan sát đơn lẻ.

## Kết quả tập trung lấy dữ liệu, 25/09/2026

Theo yêu cầu mới, sai lệch clock sau seek không còn là mục tiêu chẩn đoán. Kết quả cần dùng là đường lấy snapshot mà LeagueBroadcast đã công khai ra localhost.

- Đã ánh xạ type serializer trong ba stack trace FlatSharp bằng metadata tĩnh: `GeneratedVector_c3880...` có phần tử `BlueBottleIPC.LeagueBroadcast.Snapshot.AIHeroClient`. Lỗi `uoffset_t` 1/2 vì vậy xảy ra khi consumer parse vector hero trong `GameInfo`, trước adapter JSON/WebSocket của project. Không phải `server/leaguebroadcast.ts` làm hỏng payload.
- WebSocket `/ws/in` không phải nguyên nhân cần thiết của lỗi: lúc 12:59:46 lỗi xảy ra mà chưa có client `/ws/in`; lúc 13:14:13 lỗi xảy ra khoảng 414 ms trước kết nối `/ws/ui`. Hai lần có client `/ws/in` thì lỗi xảy ra sau 715 ms và 4,064 giây. Kết luận giới hạn: lỗi nằm ở đường native IPC/serializer của LB và có thể xảy ra độc lập với collector của project.
- Frame JSON đã lấy được trước khi upstream ngắt có đủ 10 người và các nhóm field: champion, KDA/CS/level, current/total gold, item, health/shield/resource, 6 ability với cooldown/readyAt, 9 perk, EXP/respawn; team gold/kills/towers/plates/dragons/grubs; Baron/Dragon pit timer và inhibitor. Đây là bằng chứng lấy được dữ liệu, không phải cam kết độ chính xác sau seek.
- Thêm `npm run capture:lb -- 20000`: kết nối ngay `ws://127.0.0.1:58869/ws/in`, ghi NDJSON từng frame vào `data/captures/lb-<thời-gian>/`, tự reconnect trong cửa sổ capture và lọc key giống credential. Công cụ không mở NamedPipe, không load DLL và không điều khiển game. Lần smoke test khi LB idle kết nối thành công, nhận một `gameStatus`, không có message lỗi.

Đường sử dụng hiện tại: để LB đảm nhiệm collector native được cấp, project lấy output JSON qua WebSocket local và ghi ngay khi nhận. Script capture chỉ là công cụ chẩn đoán output, **không phải kết quả thay nguồn LB**. Parser native của LB vẫn có thể ngắt phiên; script mới giảm nguy cơ bỏ lỡ frame ngắn nhưng không thể sửa producer/consumer IPC từ bên ngoài. Nếu cần loại bỏ hoàn toàn LB, bằng chứng hiện tại cho thấy các field riêng của LB đi qua module `lblib.dll` được tích hợp vào tiến trình game; không có endpoint collector độc lập trong SDK/WebSocket công khai. Tái tạo đúng cơ chế này sẽ đi vào injection/đọc state nội bộ và nằm ngoài ranh giới Vanguard của project.

## Đọc IL tĩnh đường nhận LB, 25/09/2026

Đọc method body managed IL bằng dnfile/dncil từ file DLL trên đĩa. Không load assembly vào CLR để gọi code LB, không kết nối transport. Script nghiên cứu cục bộ .npm-cache/inspect-lb-il.py và bản trích lb-transport-il.json/lb-source-il.json không được đưa vào runtime hoặc tái phân phối.

Đã kiểm chứng nội dung method (vượt mức tên method/chuỗi ký tự):

1. FarsightSocketClient.ReceiveData đọc đúng 4 byte đầu bằng ReadExactlyAsync, chuyển ToUInt32 thành độ dài. Từ chối độ dài 0 hoặc lớn hơn 64 MiB, rồi đọc đúng số byte payload bằng ReadExactlyAsync.
2. HandleFullMessage đưa vùng payload trong _recbuf vào serializer BlueBottleIPC.LeagueBroadcast.Snapshot.Response. Sau Parse thành công mới phát ResponseReceived.
3. Exception trong vòng nhận dẫn tới log 'Error while reading from the ... stream', đổi ConnectionStatus và RequestDisconnect. Không có phục hồi bỏ qua frame lỗi trong nhánh này. Đây là cơ chế giải thích feed ngừng sau lỗi FlatBuffer đã ghi, không phải chứng minh nguyên nhân làm FlatBuffer hỏng.
4. Vì có ReadExactlyAsync, chưa có cơ sở chẩn đoán đơn giản rằng một lần Read trả ít byte hơn yêu cầu làm parser đọc thiếu. Vẫn còn các giả thuyết producer/consumer schema không khớp, payload producer sai, lệch framing hoặc vấn đề đồng bộ; chưa có bằng chứng phân biệt.
5. LocalFarsightDataSource.OnGameInfoReceived xử lý GameInfo từ lblib, đo interval và phát callback. OnGameWindowOpened chỉ nhận window handle/location/version. Không thấy đường đọc giá trị HUD ở hai method này; không khái quát thành đã kiểm toán toàn bộ collector.

Mức kết luận: đường IPC managed và hành vi disconnect đã được xác định từ IL + log. Logic native tạo GameInfo chưa được xác định; không thể thay collector bằng cách sửa parser. Không patch DLL để nuốt exception vì tiếp tục dùng state sai có thể làm overlay hiển thị sai và che lỗi nguồn. Chưa có thử nghiệm đối chứng WebSocket; không kết luận việc quan sát không liên quan lỗi.

## Kiểm tra source trong phạm vi không tương tác game, 25/09/2026

Người dùng xác nhận tiếp tục với ràng buộc Vanguard. Phiên này chỉ tải văn bản source công khai, đọc metadata file DLL trên đĩa và ghi tài liệu. Không mở kết nối game/LB, không load DLL, thực thi collector, attach, hook, đọc process memory hoặc mở IPC. Đây là mô tả thao tác thực hiện, không phải chứng nhận zero ban risk từ Riot.

Đã ghim source native-farsight-module ở commit 0d3c16951803b3074bdf4cb57377910d6574a7db:

- src/Farsight.cc mở process bằng OpenProcess; src/Utils.cc dùng ReadProcessMemory.
- src/unit/GameObject.cc lấy health/maxHealth/currentGold/totalGold từ buffer theo Offsets, rồi ToNapiObject xuất field cho Node.js. Không có bước đọc OCR/control HUD trong đường lấy các field này đã kiểm tra.
- index.js gọi native addon, tải metadata champion từ CommunityDragon và offsets theo phiên bản; makeSnapshot phụ thuộc addon. Tách riêng wrapper JS không thay thế nguồn memory collector.
- index.d.ts mô tả game object và snapshot; có thể tham khảo thiết kế kiểu dữ liệu nhưng không tạo được state thật. Project hiện đã có contract/adapter tương ứng, không có lý do nhập reader cũ chỉ để tái sử dụng types.

Metadata BlueBottleClient.GameLib.dll hiện có LocalFarsightDataSource (StartAsync/OnGameStarted), IngameState.GameDataSource_GameInfoReceived, OnFirstSnapshot và bộ Serialization.Update. Có IngameStateMocking riêng. Tên và metadata củng cố việc tách nguồn thu khỏi xử lý/serialization; không chứng minh có collector API độc lập được công bố hoặc field chính xác ở runtime. Bản trích metadata lưu tạm .npm-cache/lb-datasource-metadata.json. Chưa đọc method body native hoặc khẳng định cơ chế collector mới giống reader cũ.

Kết quả khả thi: Farsight cũ không cung cấp đường thu bổ sung đáp ứng ràng buộc đã chốt; wrapper/API schema chỉ tái sử dụng phần tổ chức dữ liệu. Chưa có căn cứ triển khai collector đầy đủ độc lập an toàn từ những nguồn này. Tiếp tục source research không cần custom; chỉ thử live khi đã có giả thuyết và tiêu chí đo cụ thể.

Nguồn: [index.js](https://github.com/floh22/native-farsight-module/blob/0d3c16951803b3074bdf4cb57377910d6574a7db/index.js), [Farsight.cc](https://github.com/floh22/native-farsight-module/blob/0d3c16951803b3074bdf4cb57377910d6574a7db/src/Farsight.cc), [Utils.cc](https://github.com/floh22/native-farsight-module/blob/0d3c16951803b3074bdf4cb57377910d6574a7db/src/Utils.cc), [GameObject.cc](https://github.com/floh22/native-farsight-module/blob/0d3c16951803b3074bdf4cb57377910d6574a7db/src/unit/GameObject.cc), [Riot Vanguard FAQ](https://www.riotgames.com/en/DevRel/vanguard-faq).

## Tra cứu keyword Farsight theo người dùng, 25/09/2026

- URL https://github.com/farsight-lol/farsight hiện là TCP SYN scanner/banner grabber viết Rust trên Linux AF_XDP, không phải collector League of Legends. Chưa có bằng chứng URL này từng là project LoL; không suy ra từ hậu tố lol.
- Project đúng lĩnh vực: https://github.com/floh22/native-farsight-module, tác giả Lars Eble, MIT, native Node.js module đọc bộ nhớ spectator. README liệt kê HP/mana/position/gold/XP/objectives và phụ thuộc memory offsets theo patch; không phải OCR hay Windows HUD controls.
- https://github.com/FeldrinH/python-farsight-module là bản port Python của nguồn trên, không phải cơ chế thu mới.
- https://github.com/RCVolus/league-observer-tool xác nhận từng dùng Farsight từ v5.0.0; cảnh báo IMPORTANT đầu README nói memory reading có thể dẫn tới ban khi Vanguard được phát hành và tính năng sẽ bị tắt. Cảnh báo này cập nhật ngữ cảnh cho những đoạn README cũ còn nói spectator tương đối an toàn; không lấy đoạn cũ làm bảo đảm hiện hành.
- Tác giả floh22 gắn với BlueBottle, nhưng repo memory reader cũ không chứng minh cùng cơ chế với Farsight.dll/lblib hiện tại. Phân tích bản cài hiện tại đã tìm thấy LibInjector/BlueBottleHook; cần giữ phân biệt hai thế hệ.

Không cần custom để đọc source, metadata và đối chiếu kiến trúc. Cần trận hoặc replay tương thích để chứng minh collector hiện hành phát field mới; nghiên cứu offline không thể xác nhận độ phủ realtime. Phiên tra cứu này không chạy/cài memory reader, không kết nối LB/game.

## Custom live và phân tích tĩnh collector, 25/09/2026

### Kết quả mới quan trọng

Đã đọc PE import/export và metadata .NET trên các file cài đặt, không load/execute DLL, attach debugger, inject hay đọc bộ nhớ game. Phương pháp này xác định thành phần và tên method, chưa giải mã logic native lấy từng field.

- Farsight.dll chứa type Farsight.LibInjector với InjectIntoLeague, Inject, Release, IsSpectator và các P/Invoke LoadLibraryEx, SetWindowsHookEx, UnhookWindowsHookEx. Có InjectionLock và state machine UpdateAndInjectLib.
- Chuỗi thông báo đi kèm gồm kiểm tra export BlueBottleHook, lblib already injected; connecting as client, another host owns lblib injection, failed to set hook, cooperative lblib shutdown. Đây là bằng chứng trực tiếp rằng bản cài có đường tích hợp module bằng hook/injection, không chỉ tên DLL mơ hồ. Chưa trace callsite để khẳng định từng method thực thi trong phiên này.
- lblib.dll native x64 export BlueBottleHook, DllMain và API AngelScript. Import gồm CreateNamedPipeW, ConnectNamedPipe, CallNextHookEx, D3D11CreateDevice, ReadProcessMemory và OpenProcess. Import ReadProcessMemory KHÔNG chứng minh nó được gọi, đọc tiến trình nào hoặc dùng để lấy state; không dùng dấu hiệu này để cáo buộc bypass/Vanguard violation.
- Authenticode của lblib.dll trả Valid, signer BlueBottle GmbH. Chữ ký xác minh publisher/integrity, không chứng minh quyền Riot cấp hoặc collector tự viết tương đương sẽ được chấp nhận.
- SHA256 lblib.dll: 4f9beef18cfc9672c0a27ea38a0ccd2b53dc4313be2c3c4f51669de0599443c5. Farsight.dll: 7842bf7a52ca0d70191042c145e532c733ee0c2ea34c8be0fbb195d56a4fdcd4.
- Pipe quan sát theo game PID: BlueBottleGG.Farsight.v2.s12.p21384, sau mở lại p16764. Chỉ liệt kê tên, không mở/chiếm/giả danh peer. Metadata có VerifyServerProcess và WaitForAdmissionAsync; không thử vượt kiểm tra này.

Luồng kiến trúc phù hợp với bằng chứng: thành phần LibInjector quản lý lblib -> collector native (logic nội bộ chưa rõ) -> NamedPipe / FlatBuffers -> Farsight -> GameLib chuẩn hóa state -> HTTP/WebSocket -> overlay. Phần từ game tới collector vẫn chưa đủ chứng cứ để tái hiện chính xác; không còn cơ sở ưu tiên giả thuyết UI Automation/HUD control công khai.

### Quan sát feed custom thật

Map11 CLASSIC, 10 player; Riot activePlayer vẫn báo spectator unsupported. Lần đầu nhận 2 frame khoảng gameTime 74.47 đến 74.98. Sau người dùng mở lại, nhận 9 frame gameTime 60.79 đến 64.87, khoảng cách trung bình 476.25 ms. State báo 16.19.0, isTestingEnvironment=false; tabs có health/resource/abilities/perks 10/10, health gồm shield riêng vật lý/phép, abilities có readyAt/totalCooldown. Đây là field hiện diện, chưa đo độ chính xác cả trận. Gold đội ở scoreboard; không có gold trong tabs player nên không suy ra thiếu gold ở toàn payload.

Log mới log-2026-09-25-20-13-44.txt: Running lúc 13:17:31 UTC; 13:18:38.775 lỗi FlatBuffers uoffset_t=1; 13:18:39.546 ClientDisconnected và OutOfGame. Tương tự phiên custom trước lỗi lúc 13:11:38 UTC. Không phải chỉ replay lỗi. Các lỗi xảy ra trong cửa sổ thời gian client nghiên cứu đăng ký WS; chưa kiểm nghiệm có/không client nên không kết luận WS gây lỗi hay hoàn toàn không liên quan. Không gửi command game, không sửa cấu hình, chỉ mở đầu ra WS được cung cấp. Game process vẫn tồn tại sau collector disconnect.

Tệp tạm .npm-cache/lb-pe-research.json lưu import/export/hash; .npm-cache/lb-research-current.json chỉ giữ một frame làm bằng chứng phân tích field, không xây snapshot playback. pefile/dnfile cài riêng trong .npm-cache/research-python, không thêm dependency runtime.

### Ý nghĩa cho thay LeagueBroadcast

Đã xác định rõ hơn cơ chế tích hợp và vận chuyển, chưa xây được collector độc lập. Clone WebSocket/NamedPipe chỉ thay bên nhận. Tự viết hook/injection không đáp ứng yêu cầu tránh ban chỉ dựa trên việc BlueBottle đang chạy được. Cần nguồn được xuất có quyền sử dụng hoặc thỏa thuận collector; nếu tự phát triển từ HUD/API, phải chấp nhận và đo giới hạn field. Điều khoản BlueBottle mục 8.2 có hạn chế reverse engineering với ngoại lệ pháp luật bắt buộc; không suy ra quyền tái phân phối DLL từ quyền dùng app. Chưa dịch ngược toàn bộ native, chưa giải mã packet game hoặc triển khai cơ chế hook.

## Kiểm chứng giả thuyết đọc HUD element, 25/09/2026

Thực hiện chỉ đọc, không sửa game, không attach debugger, đọc bộ nhớ, hook hay gọi thư viện collector. Người dùng đang mở replay và LeagueBroadcast.

### Kết quả trên phiên thực

- Lần đọc UIA trong sandbox không thấy cửa sổ của cả hai app, nên không dùng kết quả đó để kết luận. Đọc lại ngoài sandbox thấy đúng cửa sổ LoL PID 3008 và LeagueBroadcast PID 24456.
- LoL: subtree chỉ có 1 node, tên League of Legends (TM) Client, class RiotWindowClass, ControlType.Pane. RawViewWalker không có child, GetSupportedPatterns trả mảng rỗng, ProviderDescription null. Không tìm được gold/HP/timer/scoreboard qua accessibility trong phiên này. Đây không chứng minh engine không có object HUD nội bộ hoặc không thể có provider khác ở mode khác.
- LeagueBroadcast: subtree 19 node WPF/Chromium/webview. Cây này thuộc giao diện app, không phải state game hay bằng chứng nguồn collector.
- Riot allgamedata HTTP 200: map12, KIWI, 10 người, gameTime khoảng 405.78. ActivePlayer là lỗi spectator unsupported. Player có screenPositionBottom/Center nhưng không có HP/gold/cooldown đầy đủ: tọa độ trên màn hình không phải cây HUD hoặc giá trị trong HUD.
- GET /replay/render có interfaceAll, interfaceScore, interfaceScoreboard, interfaceTarget, healthBarChampions... Đây là trạng thái hiển thị/render, không chứa số vàng/máu tương ứng. Không gửi lệnh thay đổi render.
- GET /swagger/v3/openapi.json HTTP 200 liệt kê LiveClientData, Replay và hạ tầng async/subscribe. Không thấy endpoint cây HUD hoặc getter state từng HUD element trong schema được xuất. /swagger.json trả 404, không phải bằng chứng thiếu schema.
- Không thấy TCP 34243 nghe trong lần kiểm tra ngoài sandbox. Chưa chứng minh LiveEvents hoạt động trong phiên replay này.

### Bằng chứng mới về collector

Log log-2026-09-25-19-54-27.txt ở AppData/Roaming/BlueBottle/LeagueBroadcast/logs ghi:

- 12:59:45.915 UTC: Farsight.IPC2.FarsightSocketClient kết nối transport NamedPipe.
- 12:59:46.008 UTC: Loading -> Running.
- 12:59:46.359 UTC: lỗi đọc NamedPipe; System.IO.InvalidDataException, FlatBuffer invalid format, decoded uoffset_t = 2 (nhỏ hơn 4), parser BlueBottleIPC.LeagueBroadcast.Snapshot.Response.
- 12:59:47.187 UTC: ClientDisconnected, Running -> OutOfGame; gameTime null, không có winner ghi nhận.
- GET /api/diagnostics/health hiện trả idle, updatesPerSecond 0, connected 0. App mở không đồng nghĩa đang có feed.

Luồng được củng cố: collector chưa rõ cơ chế -> NamedPipe/FlatBuffers -> Farsight client -> backend -> WebSocket. NamedPipe là IPC vận chuyển dữ liệu, không phải nguồn dữ liệu tự thân. Chưa kết nối hoặc chiếm pipe. Dùng lại pipe vẫn phụ thuộc producer BlueBottle nên chưa đạt mục tiêu thay collector. Lỗi giải mã có thể liên quan tính tương thích producer/consumer hoặc dữ liệu truyền, nhưng chưa đủ căn cứ chốt nguyên nhân hay khẳng định cập nhật sẽ sửa được.

### Kết luận cho giả thuyết của người dùng

HUD có thể có cấu trúc nội bộ dù bị ẩn; cấu trúc đó không tự trở thành control Windows đọc được. Thử nghiệm hiện tại không tìm thấy đường đọc HUD element qua UIA hoặc API game được xuất. Nếu cấu trúc chỉ nằm trong tiến trình, việc truy cập cần cơ chế khác và không thể coi là accessibility an toàn chỉ vì gọi nó là HUD. Không suy ra cơ chế riêng của BlueBottle từ tuyên bố không đọc pixel. Hướng frame-state độc lập vẫn cần một nguồn xuất được phép hoặc nghiên cứu giao thức có quyền phù hợp; không triển khai memory reading để bù dữ liệu.

Nguồn đối chiếu: [Microsoft UIA providers](https://learn.microsoft.com/en-us/windows/win32/winauto/uiauto-providersoverview), [Microsoft accessibility/DirectX](https://learn.microsoft.com/windows/apps/design/accessibility/accessibility), [LeagueBroadcast how-it-works](https://leaguebroadcast.gg/how-it-works), [Riot Vanguard FAQ](https://www.riotgames.com/en/DevRel/vanguard-faq).

## Phạm vi đã làm rõ: collector trực tiếp, 24/09/2026

Người dùng xác nhận muốn thay nguồn thu dữ liệu trận đang chạy, không phát triển snapshot. Tiêu chí: tắt LeagueBroadcast vẫn nhận được dữ liệu trận mới. Wrapper, script chạy trong LeagueBroadcast và phát lại bản ghi không đạt tiêu chí này.

Các phát hiện bổ sung từ nguồn gốc:

- [LHM](https://guide.lhm.gg/docs/lhm-basics/games-configurations/league-of-legends/) công bố dùng OCR, cần 1920x1080 borderless với Score Display, Scoreboard, Objective Timers hiện trên màn hình. Có mô hình hai máy tách HUD thu dữ liệu khỏi hình phát sóng. Đây là tiền lệ collector độc lập có thể tự xây, chưa chứng minh đủ HP/gold/cooldown đồng thời của 10 người.
- [LeagueOCR](https://github.com/floh22/LeagueOCR) của floh22 có license MIT, công bố team gold và Dragon/Baron state/timer. Chưa build hay kiểm chứng với HUD hiện tại. Không suy ra BlueBottle hiện hành dùng OCR: trang how-it-works của hãng nói không dùng pixel reading.
- [Trinket](https://github.com/floh22/Trinket) mô tả LiveEvents qua game.cfg, LiveEvents.ini và port mặc định 34243. Đây là feed khác allgamedata. README cảnh báo đa số event trong danh sách không phát. Kiểm tra netstat phiên này thấy TCP 2999 và 58869 nghe, không thấy 34243; chưa kiểm tra port tùy chỉnh/cấu hình và chưa sửa game.cfg. Cần thử để xác minh event/objective, không suy ra đầy đủ state từ tên event.
- [Overwolf GEP](https://dev.overwolf.com/ow-native/live-game-data-gep/supported-games/league-of-legends/) tài liệu hóa gold/total_gold nhưng không nêu scope; `team_frames_0..3` có `ult_cd`, song chưa xác định các key này ánh xạ tới người chơi/đội nào trong spectator. Không tìm thấy cam kết spectator đủ 10 người trong trang đã đọc. Chưa đủ bằng chứng thay collector.
- [Mowokuma/ROFL](https://github.com/Mowokuma/ROFL) đã archive và công bố position/wards. [ROFL-X](https://github.com/Toastaspiring/ROFL-X) còn làm model/spec, decoder phụ thuộc patch và phạm vi file offline. Đây là hướng R&D parser giao thức riêng, chưa phải nguồn realtime sẵn dùng hoặc đã xác minh phù hợp Vanguard. Không kết luận bất khả thi, cũng không hứa an toàn.
- [OSL](https://github.com/Sky-CSC/OSL) còn liệt kê ingame overlay là đang phát triển, chưa chứng minh có nguồn đầy đủ.

Ưu tiên nghiên cứu tiếp: kiểm chứng LiveEvents cho event/objective và collector HUD theo tiền lệ LHM/LeagueOCR. Đo field thật, độ trễ, sai số, dữ liệu cũ và phụ thuộc bố cục trước khi nối vào overlay. Không dùng giá item giả totalGold hoặc phần trăm thanh máu giả HP tuyệt đối. Với yêu cầu đủ state/frame accurate như BlueBottle, cơ chế collector vẫn chưa được xác minh; snapshot không giải quyết điểm thiếu này.

Ngày kiểm tra: 24/09/2026. Phạm vi: nghiên cứu, đọc giao thức công khai và probe GET/WebSocket. Chưa triển khai collector, chưa thay đổi provider hoặc dashboard.

## Mục tiêu và kết luận

Người dùng cần mọi phương pháp khả thi để lấy đủ dữ liệu in-game, ưu tiên độc lập với LeagueBroadcast và phù hợp Vanguard. Giả lập đầu ra WebSocket chỉ thay lớp giao tiếp; không tạo ra dữ liệu thật mà nguồn chưa cung cấp.

Hiện chưa xác minh được phương pháp công khai, miễn phí, độc lập cung cấp đầy đủ state của 10 người từ một máy spectator. LeagueBroadcast đã có bằng chứng cung cấp nhiều field cần thiết ở custom tournament; cơ chế collector hiện hành chưa được công bố trong SDK đã khảo sát. Không kết luận rằng cơ chế đó có thể sao chép hoặc được Riot cấp phép chỉ từ việc app hoạt động.

## Bằng chứng trên máy

- Capture mới: `data/captures/2026-09-24T15-14-32-437Z`. Riot allgamedata có 10 người, map 12, mode KIWI, clock 251.607 giây khi chụp. `activePlayer` là lỗi, `runes` của player đầu tiên null.
- Ba GET activeplayer, activeplayerabilities, activeplayerrunes đều trả HTTP 400 với thông báo spectator không hỗ trợ chức năng này. Đây là bằng chứng trên phiên hiện tại, không phải suy luận từ tên endpoint.
- LeagueBroadcast kết nối được nhưng chỉ phát một message gameStatus=0 trong 10 giây, không có ingame-state-update. Kiểm tra sau đó chuyển Loading=1, health vẫn idle/0 update/s. Không có bằng chứng state trận hiện tại đã vào LeagueBroadcast.
- API overlay cổng 4310 chưa phản hồi. Capture mới có endpoint unavailable được ghi trong manifest; không phải bản đầy đủ thay thế capture tournament cũ. `latest.json` hiện trỏ tới lần chụp mới nhất này.
- Capture đầy đủ trước: `data/captures/2026-09-19T18-57-45-942Z`, 41 message gồm 40 state, khoảng 20 giây game, gameVersion 16.18.0, isTestingEnvironment=false. Các interval chủ yếu 492 đến 523 ms, một interval đầu 230 ms. Đây là tốc độ feed khoảng 2 Hz, không chứng minh mọi tick game được xuất.
- State cũ chứa scoreboard, scoreboardBottom, tabs, inhibitors và timer hai hố. Có health/shield, resource, experience, perk, abilities với readyAt/totalCooldown, gold/totalGold, items và shutdown.
- Mẫu cũ không có goldGraph, damageGraph, damageRecap hoặc teamfightTimeline. Trong đoạn 20 giây chỉ đếm được một player event; chưa đủ kiểm chứng chuỗi kill/objective/death/respawn/seek.

## Phân biệt ba lớp

1. Collector lấy state từ game. Đây là phần khó và còn thiếu để độc lập hoàn toàn.
2. Backend tổ chức state, event, tài nguyên và xuất HTTP/WebSocket.
3. Frontend mapping/clock/overlay. Project đã tự làm phần lớn lớp này.

SDK công khai là client kết nối backend, không phải collector cắm trực tiếp vào LoL. Đã đọc WebSocketManager.ts, LeagueBroadcastClient.ts, ingameTimerUtils.ts và các type state/event tại commit `b8c70f1d5b9f70c5fb9d36c5ea2f37a31a91ae91`. Giao thức dùng `/ws/in`, message `gameStatus` và `ingame-state-update` với `state`/`events`, heartbeat KeepAlive. Clock client tính từ snapshot, utcTime và playbackSpeed. Có type FlatBuffers/IPC trong cây source không chứng minh tồn tại transport collector công khai hoặc quyền gọi thư viện native.

Bộ cài có BlueBottleClient.GameLib.dll, lblib.dll và Farsight.dll. Chỉ kiểm tra tên file và release notes 1.13.3; không decompile hay gọi DLL. Tên DLL không đủ xác định cơ chế thu, quyền tích hợp hoặc an toàn Vanguard. Repository LeagueBroadcast cũ tự ghi đã ngừng hoạt động vì dùng memory reading; không dùng nó làm nền collector mới.

## Ma trận khả thi

### Bổ sung từ ứng dụng đang chạy ngày 24/09

Log ứng dụng `C:/Users/Seotow/AppData/Roaming/BlueBottle/LeagueBroadcast/logs/log-2026-09-24-21-56-10.txt` cho bằng chứng cụ thể hơn tên DLL:

- IngameController khởi động LocalFarsightDataSource để chờ game.
- GameLibFetcher tải thư viện `lblib-16.1.0-16.19.9999.dll` và cập nhật lblib.dll ngày 24/09. Đây là module riêng, có dải tương thích phiên bản; chưa xác định cơ chế lấy dữ liệu bên trong nó.
- Log 15:10:41 UTC cảnh báo LoL chạy administrator, LeagueBroadcast không chạy administrator, dữ liệu có thể không khả dụng. Trước đó LCU báo Access denied khi đăng ký theo dõi tiến trình. Hai dấu hiệu quyền này có thể liên quan nhưng không chứng minh cùng một nguyên nhân.
- Ingame chuyển OutOfGame -> Loading lúc 15:15:41 UTC. Asset 16.19 đạt 4470/4470, không file lỗi. Sau cache, log báo entered inactive game và phát hiện Replay API. Lần probe cuối vẫn Loading, telemetry idle, connected=0. Cache hoàn tất không đồng nghĩa collector đã nhận state.

Tài liệu đi kèm `current/angelscript-api.json` có version=3, language=AngelScript. Các namespace Game, Heroes, World, Objectives mô tả truy cập state bên trong scene scripting: Heroes.all()/byNetworkId()/byTeamAndRole(), Hero.health/maxHealth/resource/maxResource/gold/totalGold/position/ultimateCooldown, World.turrets()/inhibitors(), Objectives.dragon()/baron(). Có callback onUpdate, onGameEvent, onChampionKill, Game.frameCount/timelineEpoch/timelineStable.

Đây là hướng extension do ứng dụng cung cấp, có thể đáng thử khi nguồn đã Running và quyền tài khoản cho phép. Chưa thực thi script, chưa xác minh mọi field trả giá trị hoặc có đường export state ra ứng dụng khác. Các namespace Shared/log chỉ mô tả chia sẻ trong script và console; không tự chứng minh HTTP/WebSocket export. Vẫn phụ thuộc runtime LeagueBroadcast, không phải collector độc lập. Trước khi chọn cần xác minh scope Scene Editor, license và cơ chế export được hỗ trợ.

Luồng có bằng chứng: nhận diện game + quản lý phiên bản library -> LocalFarsightDataSource -> state game/scene -> backend snapshot/events -> WebSocket -> frontend. Ranh giới từ game vào library còn chưa rõ, không kết luận injection, memory reading hay quyền đặc biệt từ tên Farsight hoặc cảnh báo administrator.

| Phương án | Khả năng đáp ứng | Hạn chế / cần chứng minh |
| --- | --- | --- |
| LeagueBroadcast local feed | Đã có vàng, HP/resource, cooldown, scoreboard/objective trong mẫu tournament | Vẫn cần app/tài khoản; không bảo đảm mọi loại trận hay toàn bộ field của SDK |
| BlueBottle collector SDK/OEM riêng | Có thể giải quyết bài toán độc lập về giao diện nếu hãng cung cấp | Chưa tìm thấy SDK collector tải công khai; cần hãng xác nhận license, runtime, quyền phân phối, chế độ game, patch và Vanguard |
| Riot Live Client + Replay | Tướng, KDA, CS, item, spell identity, clock, một số event và respawn trong mẫu | Không có HP/resource/gold/cooldown 10 người trong mẫu spectator; activeplayer bị từ chối. Không thay được collector đầy đủ |
| Riot Tournament API | Tạo lobby/code, lobby events và kết quả cuối trận | Không phải live telemetry cho HP/gold/cooldown |
| Overwolf GEP | Có dữ liệu người chơi, gold và event/ability trong tài liệu | Chưa có bằng chứng đầy đủ 10 spectator; không mặc định gold là per-player toàn trận. Cần runtime và kiểm chứng quyền/chế độ |
| Riot API + OCR HUD spectator | Có thể bổ sung gold đội, bảng gold cá nhân, trụ/rồng, biểu tượng cooldown hoặc thanh máu khi nhìn thấy | Chỉ đọc được phần hiện trên HUD; phần trăm thanh máu không tương đương HP tuyệt đối. Các trang HUD khác nhau không đồng thời; không đảm bảo toàn bộ state hay frame accurate |
| Agent trên từng máy người chơi | Giả thuyết bổ sung local-player stats rồi hợp nhất | Chưa thử. Cần triển khai trên 10 máy, đồng bộ spectator delay, quyền người tham gia và field contract; không mặc định có totalGold/cooldown đủ |
| GRID / feed được cấp quyền | Có live esports data theo danh mục/hợp đồng | GRID Open Access không bao gồm LoL; chưa xác minh hỗ trợ custom game của người dùng |
| Phát lại capture qua server giả lập | Khả thi để test renderer/adapter offline | Chỉ tái hiện đoạn đã ghi, không lấy state trận mới |
| Memory reading, inject, bypass hoặc collector cũ | Không chọn trong project | Không phù hợp ràng buộc Vanguard đã chốt |

## Kế hoạch nghiên cứu trước triển khai

1. Chốt field bắt buộc: gold hiện tại/tổng, HP/max/shield, resource, QWER/DF và item cooldown, XP/level, inventory, scoreboard, rồng/Baron/inhibitor, event, damage và clock. Phân biệt dữ liệu thô cần có với widget chỉ cần phần trăm/trạng thái.
2. Xác minh lại custom tournament map 11 nhận Running. Thu chuỗi mẫu dài hơn có mua/bán item, chết/hồi sinh, đổi level, dùng phép, objective và kết thúc trận. Capture hiện tại map 12/Loading không thay được bước này. Đối chiếu HUD/video cùng timestamp để đo sai lệch.
3. Khảo sát API public và field thật theo từng chế độ, không tìm cách biến activeplayer thành endpoint arbitrary player. Data Dragon chỉ cung cấp metadata/asset, không bù state realtime.
4. Nếu cần mọi field chính xác, hỏi BlueBottle về collector SDK/headless/OEM được cấp quyền hoặc Riot về spectator feed hợp lệ. Các câu hỏi: có runtime riêng không, các mode được hỗ trợ, độ phủ/tần số, điều khoản redistributing, xác nhận tương thích Vanguard cho cách tích hợp dự kiến. Chưa gửi liên hệ nào.
5. Nếu chấp nhận giới hạn HUD, làm thử nghiệm OCR độc lập với overlay: một video có nhãn chuẩn, đo tỷ lệ đúng, jitter, missing và tốc độ ở độ phân giải/HUD thực. Chưa cài OCR hoặc can thiệp camera.
6. Chỉ triển khai provider sau khi có mẫu đủ field, quyền tích hợp rõ ràng và tiêu chí đo. Mỗi field có nguồn, thời gian, observed/derived/OCR/missing; không gộp nguồn sai clock.

## Thiết kế giả lập cho kiểm thử sau này

Dùng cổng loopback riêng để không chiếm 58869; replay NDJSON theo khoảng receivedAt, giữ gameTime/timestamp trong game và rebase utcTime. Pause/seek/loop tạo epoch, không phát lại event lịch sử khi seek. Tách nguồn replay khỏi nhãn live vì adapter hiện từ chối isTestingEnvironment=true. Không chỉ sửa bit này thành false để giả làm dữ liệu thật. Asset URL trỏ cache local của LeagueBroadcast không còn dùng được khi tắt app, cần manifest tài nguyên hoặc mapping catalog riêng. Không tuyên bố hỗ trợ toàn bộ endpoint chỉ với 17 endpoint capture hiện có.

Snapshot không chứa mọi trạng thái trận, không chứng minh mọi field khả dụng. Phát lại capture phục vụ phát triển, không phải đáp án cho thu thập live độc lập.

## Nguồn chính đã kiểm tra

- [LeagueBroadcast: cách hoạt động](https://leaguebroadcast.gg/how-it-works): hãng tuyên bố nguồn game state tương thích Vanguard, không mô tả collector.
- [SDK công khai](https://github.com/BlueBottleGG/leaguebroadcast-js-client): client WebSocket, type, clock; license GPL-3.0. Không nhập SDK vào project trong phiên nghiên cứu.
- [Repository cũ](https://github.com/floh22/LeagueBroadcast): thông báo deprecated, memory reading không còn hoạt động với Vanguard.
- [Riot Game Client và Tournament API](https://developer.riotgames.com/docs/lol).
- [Riot Vanguard FAQ](https://www.riotgames.com/en/DevRel/vanguard-faq): API và spectator/replay được kỳ vọng tiếp tục hoạt động; external memory reading không có allowlist. Không phải đảm bảo mọi tích hợp bên thứ ba sẽ không bị ban.
- [Overwolf LoL GEP](https://dev.overwolf.com/ow-native/live-game-data-gep/supported-games/league-of-legends/).
- [GRID Open Access](https://grid.helpjuice.com/3673199): loại LoL khỏi phạm vi Open Access.
- [Riot esports data](https://riotesportsdata.com/en-us/league-of-legends/).
- [BlueBottle điều khoản](https://bluebottle.gg/terms): OEM/platform/white-label phải được cấp quyền riêng; không suy ra quyền tái phân phối DLL từ quyền dùng ứng dụng.

Kết luận kỹ thuật: ưu tiên xác minh collector được cấp quyền nếu yêu cầu đầy đủ state. OCR/API là hướng độc lập có thể thử cho overlay giới hạn field. Chưa có căn cứ cam kết clone collector BlueBottle an toàn và đầy đủ.

## Cập nhật điều tra tài liệu công khai (25/09/2026)

Đã đối chiếu tài liệu Riot, Overwolf GEP và repository LiveEvents được cộng đồng duy trì. Đây là kết quả tài liệu, chưa phải xác nhận runtime trên spectator custom hiện tại.

### Overwolf GEP: có giá trị bổ sung, chưa thay được LB

- Trang LoL GEP liệt kê `live_client_data.all_players` và ví dụ chứa đội, tướng, cấp, K/D/A, CS, inventory, spell identity, rune, death và respawn cho roster. Đây là lớp Live Client Data được GEP chuyển tiếp; không nên tính các field này thành telemetry độc lập mới nếu Riot local đã cung cấp cùng field.
- Ví dụ `all_players` không có `championStats`/HP/resource hoặc per-player cooldown. Trong cùng trang, `gold` chỉ được mô tả là `game_info` với `gold` và `total_gold`, không nêu rõ player scope, spectator scope hay roster đầy đủ. GEP không xác nhận đủ 10 người từ observer.
- `team_frames_x` mô tả cooldown ultimate theo từng player ở vị trí scoreboard, nhưng tài liệu chỉ nêu key từ `team_frames_0` đến `team_frames_3`; không xác định cách bao phủ hai đội hay chế độ spectator. Đây là ứng viên đáng kiểm tra trong một thử nghiệm được phép, không phải bằng chứng thay thế cooldown của LB.
- GEP hỗ trợ event như kill, death, respawn, ability/abilityReady, objective/camp, nhưng event không được lưu sẵn và ứng dụng phải đăng ký listener. Trang GEP cũng cảnh báo feature health/availability có thể thay đổi. Không có cam kết spectator/replay trong bảng hỗ trợ LoL đã kiểm tra.
- GEP do đó là ứng viên có thể tăng coverage cho event, game lifecycle, scoreboard/camp state và có thể ult cooldown cục bộ. Không có căn cứ hiện tại để nâng mức coverage gold thành đủ 10, HP/resource thành toàn roster hoặc xác nhận cadence/timing tương đương LB.

### LiveEvents: tài liệu cũ, không đưa vào kế hoạch tích hợp

Repository `SkinSpotlights/LiveEventsDocumentation` nói API chỉ dành cho spectator/replay và có event kill/damage/heal/dragon, nhưng cũng cảnh báo API có vẻ bị xóa hoặc vô hiệu từ patch 14.1. Đây là tài liệu cộng đồng về một API không được Riot công bố/hỗ trợ; cấu hình yêu cầu sửa `game.cfg`, và tác giả nói nhiều event khai báo thực tế không phát. Vì vậy không xem đây là Riot public API, không thay đổi config, không kết nối thử port hoặc xây adapter dựa trên giả định endpoint còn hoạt động. Có thể giữ lại như lịch sử/ngữ cảnh, trạng thái hiện tại là **không xác minh, có dấu hiệu đã bị vô hiệu**.

### Ma trận field cập nhật

| Nhóm field | Riot Live Client / Replay đã quan sát | Overwolf GEP theo tài liệu công khai | LiveEvents community docs | Kết luận |
| --- | --- | --- | --- | --- |
| Roster, tướng, cấp, KDA, CS, item, spell identity, death/respawn | Có trong `allPlayers`/Replay recording hiện có | Có trong `live_client_data.all_players` mẫu (wrapper dữ liệu Riot) | Không phải mục tiêu chính | Đã có nguồn Riot; GEP không làm tăng đáng kể coverage |
| Rune/perk | `keystone` thiếu/null trong mẫu Riot đã ghi; chưa xác minh qua replay API | Rune/perk xuất hiện trong tài liệu mẫu `all_players`; đây là bằng chứng tài liệu, chưa chứng minh runtime spectator | Không xác minh | Riot sample: missing/unverified; GEP runtime: cần kiểm chứng |
| Gold cá nhân/current + total của 10 người | Thiếu trong mẫu Riot local đã ghi | `gold` có gold/total_gold nhưng scope và 10-player spectator không được tài liệu hóa | Không xác minh | Chưa có nguồn độc lập đủ 10; GEP cần xác minh riêng |
| HP/max HP/shield và resource/max resource đủ 10 | Thiếu trong dữ liệu spectator mẫu; active-player endpoint bị từ chối | Không có trong bảng LoL GEP đã kiểm tra | Một số `OnDamage`/`OnHeal` được nêu, không phải HP tuyệt đối | Chưa có nguồn xác nhận |
| Cooldown phép bổ trợ và Q/W/E/R | Chưa có trong mẫu Riot hiện tại | Ability events là hành động chọn/dùng/ready, không phải snapshot cooldown tổng quát; `team_frames` chỉ nêu ultimate với key 0–3 và scope chưa rõ | Không chắc event còn phát | Có thể bổ sung event ult hạn chế; không đủ thay timer cooldown 10 người |
| Kill/death/assist và vòng đời trận | Riot eventdata có mẫu; lịch sử/độ phủ tùy feed | GEP tài liệu hóa kill/death/assist, matchStart/announcer/respawn; cần listener và kiểm tra trạng thái feature | Nêu OnKill/OnDie nhưng API có dấu hiệu bị vô hiệu | GEP là ứng viên event theo tài liệu; cần xác nhận delivery trong observer mode và event chỉ đến khi listener hoạt động |
| Rồng/Baron/Herald, trụ và trạng thái objective | Một số event/trụ đã có; dragon coverage không hoàn chỉnh theo recording | `jungle_camps` có alive/vision cho một số camp; tài liệu không đưa ra contract đầy đủ objective scoreboard/timers | Nêu OnDragonKill và mob kill, nhưng tính khả dụng hiện tại không xác minh | Có thể bổ sung camp state theo tài liệu, không chứng minh timer đầy đủ |
| Timestamp, tick và cadence | API/recording có timestamp nhưng spectator/replay clock cần kiểm tra | GEP mô tả realtime info/event, không công bố cadence/timestamp theo từng field trong trang LoL | Không đủ căn cứ sau patch 14.1 | Không được gọi frame-accurate; phải đo jitter/staleness nếu được phép thử |

### Kết luận và bước hợp lệ tiếp theo

Kết quả cập nhật tinh chỉnh ma trận cũ: Overwolf GEP không chỉ có event; tài liệu hiện tại còn liệt kê wrapper `all_players` và `team_frames` cooldown ultimate. Tuy vậy, chưa thấy bằng chứng công khai về đủ 10-player HP/resource/gold/cooldowns trong spectator; LiveEvents lại là API cộng đồng không hỗ trợ với cảnh báo đã bị vô hiệu. Vì vậy chưa có cơ sở triển khai hai nguồn này như collector thay LB.

Phần tiếp theo có thể làm offline là đọc release/sample app chính thức của Overwolf để xác định chính xác quan hệ giữa `live_client_data` và GEP riêng, rồi chuẩn bị checklist runtime chỉ khi người dùng chủ động yêu cầu thử. Một lần thử sau này chỉ nên đăng ký feature được tài liệu hỗ trợ, ghi tên feature, mode, số player, field, timestamp/độ trễ và health; không cài collector tự viết hay suy diễn quyền Vanguard từ sự tồn tại của GEP. Nếu yêu cầu tuyệt đối đủ field, tiếp tục ưu tiên xin quyền/SDK OEM hoặc feed được cấp phép.

Nguồn đọc ngày 25/09/2026: Riot [Live Client Data API](https://developer.riotgames.com/docs/lol); Overwolf [LoL GEP field/event list](https://dev.overwolf.com/ow-native/live-game-data-gep/supported-games/league-of-legends/) và [GEP semantics](https://dev.overwolf.com/ow-native/live-game-data-gep/live-game-data-gep-intro/); cộng đồng [LiveEventsDocumentation](https://github.com/SkinSpotlights/LiveEventsDocumentation). Riot nêu League Client API là không được hỗ trợ cho app bên thứ ba và không bảo đảm schema/uptime; Live Client Data API là giao diện khác được mô tả riêng. Các nguồn này không xác nhận LiveEvents là API được Riot hỗ trợ.

## Collector trên replay `.rofl` — ưu tiên thấp, 11/10/2026

Người dùng yêu cầu điều tra khả năng lấy dữ liệu khi spectate replay, sau collector headless cho live. Đây không phải nguồn recording phát NDJSON, cũng không chỉ là tua timeline của spectator live. Chưa xác nhận hỗ trợ hoặc kết luận bất khả thi. Các ranh giới “chưa decompile/gọi DLL” trong mốc cũ phía trên là lịch sử; phương án headless đã được người dùng yêu cầu triển khai riêng, xem PROJECT_STATUS.md.

### Bằng chứng ban đầu

Kiểm tra metadata/IL của thư viện **đang cài** bằng `.research/lb-headless/inspect-managed.py`, chỉ đọc, không patch hay thay mode:

- `Farsight.LeagueConnector.IsLeagueWindow`: kiểm tra handle, PID và tên executable thuộc TARGET_PROCESS_NAMES; trong chính hàm này không thấy phân biệt `.rofl`/live. Đây chỉ là tầng nhận diện cửa sổ, không chứng minh native collector chấp nhận replay.
- `IngameController.<OnGameLoading>d__58.MoveNext`: nhánh “Entered inactive game” đọc game hiện tại trong database, thử `StartNextGameAsync` và tiếp tục luồng loading. Vì vậy thông báo này không tự chứng minh replay bị native collector từ chối. Còn các điều kiện asset/version/runtime riêng.
- Cùng luồng loading gọi `LeagueReplayApi.EnableReplayApi` và có thông báo phát hiện Replay API. `OnGameStarted` đăng ký `TransitionData_GameRewind`; LocalFarsightDataSource chỉ phát capture sau lifecycle native và khi capture được bật. Có phần xử lý replay/tua, nhưng cũng có thể phục vụ spectator live; chưa phải bằng chứng dữ liệu `.rofl`.
- `IngameFailure.FromException` nhận `Farsight.Exceptions.NotSpectatorException` riêng với lỗi version/network/validation/load/hook. Cần phân biệt lỗi mode thật với việc UI chưa tạo match/game hoặc collector chưa kết nối; không ép bỏ kiểm tra spectator.
- Capture replay cũ chỉ thấy UI Loading/idle và không có state đầy đủ. Đây là bằng chứng của lần thử cụ thể, không phải kết luận cho mọi bản LB/patch.

Tài liệu công khai kiểm tra lại 11/10: [cách hoạt động](https://leaguebroadcast.gg/how-it-works) mô tả game trên observer PC; [changelog](https://leaguebroadcast.gg/changelog) đã đọc không có mục “replay”. Hai trang này không xác nhận hỗ trợ đầy đủ `.rofl`; không dùng issue của bản open-source deprecated để kết luận về bản hiện tại.

### Hướng thử sau khi live đạt

1. Dùng một `.rofl` mở được bằng game build hiện tại, LB UI tắt, giữ nguyên collector/version/auth của host đã chạy được trên live. Không tự sửa replay hoặc giả mode.
2. Thử host trước replay và host sau replay; ghi nhận riêng window detected, connected, signed handshake, native GameStarted và số GameInfo. Nếu thiếu metadata, chỉ bổ sung diagnostic enum/count đã lọc, không ghi challenge/token/raw process command line.
3. Nếu GameInfo đủ Heroes/stat nhưng UI LB chỉ Loading: tập trung điều kiện database/normalization, dùng adapter riêng cho host; không sửa provider thành Running giả. Nếu window thấy nhưng không GameInfo: tập trung lifecycle/capture và lỗi native, không quy cho UI.
4. Đối chiếu tối thiểu roster 10, level/items/KDA/CS, gold/HP/resource/cooldowns, objective/inhibitor. Có clock hoặc roster không đủ chứng minh telemetry đầy đủ; field nào thiếu vẫn null/unavailable.
5. Khi có mẫu, pause/resume, 1×/2×, seek tiến/lùi; kiểm tra session/epoch, stale và chống event lịch sử. Tua/tăng tốc có thể tạo discontinuity, không coi mọi chênh lệch thời gian là lỗi collector.

Không triển khai thay runtime hoặc yêu cầu người dùng mở replay riêng ở mốc này. Quyết định tiếp tục dựa trên live headless trước; có thể tận dụng replay đã mở sẵn sau đó. Nếu native trả NotSpectator/unsupported mode hoặc quyền không cho phép, ghi rõ giới hạn và xem hỗ trợ chính thức, không patch/vượt rào.

### Khoanh vùng spectator gate và sửa host diagnostic — lượt tiếp theo 11/10

Đã xác định `Farsight.LibInjector.IsSpectator` dùng GET `/liveclientdata/activeplayername/` cổng 2999: nhận `Unknown`/`Spectator` hoặc JSON errorCode `RPC_ERROR`; nhánh HTTP 404 tiếp tục chờ đến cancellation. WebClient bên dưới dùng HttpClient.GetStringAsync, nên HTTP lỗi khác phải được phân biệt với body JSON thành công. **Suy luận chưa kiểm chứng:** khác biệt endpoint giữa replay/live có thể chặn bước init trước GameStarted. Chưa có replay đang chạy để đối chiếu; probe lúc ngoài trận chỉ thấy 2999 unreachable, không được suy ra replay trả 404.

GameStarted ở managed connector phát sau kết nối và cấp feature; polling ở LocalFarsightDataSource còn yêu cầu capture bật/native started/connected. Host đã thêm bộ đếm event và connected/ready/handshakeFailed để phân biệt các tầng. Đồng thời sửa lỗi host tự tìm GameInfo theo kiểu property: wrapper LB khai báo object, phải kiểm tra kiểu giá trị/kế thừa của DTO. Fix chỉ trong `.research/lb-headless/`, không đổi source/UI overlay, không sửa DLL hay ép spectator.

Skill REA đã cài theo yêu cầu; CLI 6.4.0 nằm cache riêng, chạy Node 24.19 có sẵn. Không sửa MCP config hoặc cài native engine. REA managed parser chạm representation budget 64 MiB trên Farsight/Common nên coverage members unavailable; các kết luận CIL đến từ inspector dnfile/dncil, không gán cho REA. Evidence IDs/identity/offset/giới hạn và probe tại `.research/lb-headless/REPLAY_FINDINGS.md` (local ignored).

Build host sạch, 9 assertions tổng hợp và idle HTTP/WS/guards đạt; bản host mới đã được khởi động thay phiên agent cũ khi không có game/LB UI. Chưa có sample game mới hoặc kết luận `.rofl` đầy đủ. Live headless vẫn ưu tiên trước; runtime tiếp theo cần người dùng mở spectator game, sau đó replay cùng patch khi thuận tiện.
