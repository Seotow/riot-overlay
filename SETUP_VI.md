# Cài đặt, chuyển máy và đưa lên Git

## Cài trên máy mới

Khuyến nghị Node.js 24 và npm đi kèm. Mở terminal tại thư mục có `package.json` sau khi clone hoặc giải nén source.

```powershell
npm ci
npm run build
npm start
```

Giữ terminal backend đang chạy. Studio: http://127.0.0.1:4310/ . OBS Browser Source: http://127.0.0.1:4310/overlay , kích thước 1920×1080. Địa chỉ này chỉ trỏ đến máy đang chạy backend.

Để sửa source với frontend tự cập nhật:

```powershell
npm run dev
```

Dừng phiên trước bằng Ctrl+C trước khi mở phiên mới trên cùng port. `npm start` phục vụ bản `dist` đã build; sửa frontend rồi dùng chế độ này thì phải build lại và reload trình duyệt. `tsx` là devDependency nhưng hiện cũng được dùng để chạy backend, vì vậy **không dùng `npm ci --omit=dev`** với cấu trúc hiện tại.

## Asset và theme

Commit `public/ddragon`, `public/broadcast`, `public/fonts`, `public/references`,
`shared/generated` và ảnh tham chiếu trong `images` để clone đủ tài nguyên.
Font/ảnh runtime có sẵn local, không cần tải lại để chạy. Asset Riot/nhận diện
giải không mặc nhiên có quyền phân phối công khai; kiểm tra quyền trước publish.

Nếu cần phục hồi asset demo, dùng `npm run assets:sync` khi có mạng. Script dùng version demo cố định; không coi đây là bộ cập nhật asset live.

`data/` bị loại khỏi Git. Để chuyển theme cá nhân: Export trong Studio máy cũ, Import trên máy mới. Hoặc copy riêng `data/theme.json` khi backend đã dừng. Theme baseline nằm trong source; chọn **Theme & layout → Khớp ảnh mẫu** nếu muốn áp dụng lại preset.

## Kiểm tra

```powershell
npm test
```

Ưu tiên bộ integration cô lập (build trước, cổng 4311 trống):

```powershell
npm run build
npm run test:integration
```

Lệnh sau chỉ dùng trong phiên backend test riêng vì đổi/reset mock:

```powershell
npx tsx tests/transport.integration.ts
```

Transport test trực tiếp thay đổi/reset mock; không chạy lúc phát sóng.
Integration hệ thống tự dùng backend/theme tạm. Kiểm tra Studio, draft fixture,
in-game live/recording và OBS. LoL thật đã nối qua provider, không phải mọi
field được Riot local cung cấp.

## Chuẩn bị repository

Nên dùng repository private vì có ảnh tham chiếu và nhận diện giải. Theo dõi source, tests, scripts, `public`, tài liệu, `package.json`, `package-lock.json`, cấu hình TypeScript và `.gitignore`.

Không đưa `node_modules`, `.npm-cache`, `dist`, `.research`, `data`, log hoặc credentials vào Git. Không phụ thuộc đường dẫn tuyệt đối `D:\Workspace\Riot-overlay`; mọi lệnh chạy từ thư mục clone trên máy mới.

Nếu thư mục chưa có Git, có thể khởi tạo bằng `git init`. Trước khi commit/push, kiểm tra `git status --short` và diff staged. Chỉ thêm remote và push đến repository do chủ dự án chọn. Việc bổ sung bộ tài liệu này không tự tạo remote hoặc push code.

Trên máy mới: đọc AGENTS.md, PROJECT_STATUS.md và ROADMAP.md, xác minh source
chạy được rồi tiếp tục mốc mới nhất. Không quay lại giai đoạn 1 chỉ vì clone
mới; giữ baseline UI và ranh giới field đã kiểm chứng.

## Lỗi thường gặp

- Trang không kết nối: xác nhận backend đang chạy và không có lỗi port đã dùng; không cần đổi cấu hình firewall để chạy loopback.
- Theme khác baseline: theme local được ưu tiên; áp dụng preset hoặc import theme mong muốn.
- Ảnh thiếu: xác nhận các file trong `public/ddragon` đã được clone và build lại.
- Windows báo EPERM tại `dist/assets`: dừng tiến trình đang giữ file rồi build lại. Có thể dùng `npm run build -- --emptyOutDir false` để kiểm tra tạm; cách này giữ asset cũ, không phải clean build.
- Các lỗi quyền của môi trường agent không đồng nghĩa lỗi source; kiểm tra lại bằng terminal bình thường trước khi sửa kiến trúc.

## Chẩn đoán LoL chỉ đọc

Trong Studio, chọn tab **Nguồn dữ liệu → Kiểm tra nguồn**. Công cụ chỉ gửi GET đến loopback: Live Client ở port 2999 và LCU theo lockfile. Không cần Riot API key. Nó không thay dữ liệu mock của overlay.

Trên Windows, backend thử tìm đường dẫn LeagueClient đang chạy và các thư mục cài mặc định. Nếu không tìm thấy, đặt biến trước khi chạy backend (thay bằng đường dẫn cài thực tế):

```powershell
$env:LOL_LOCKFILE = 'D:\Riot Games\League of Legends\lockfile'
npm run dev
```

Không copy nội dung lockfile. Credentials chỉ dùng trong backend. TLS self-signed được chấp nhận riêng cho request HTTPS tới 127.0.0.1, không tắt kiểm tra TLS toàn ứng dụng.

Mở client, lobby, chọn tướng, spectator và kết thúc trận lần lượt; ở mỗi bước kiểm tra rồi xuất báo cáo JSON. Báo cáo chỉ chứa mẫu số thuộc danh sách field cho phép và phase thuộc danh sách cố định; bỏ tên tài khoản, token, đối tượng và chuỗi provider khác. Không lưu raw payload. LCU endpoints là ứng viên khảo sát, có thể không hỗ trợ trên patch/chế độ hiện tại.

“Đã quan sát” nghĩa là có ít nhất một giá trị số trong mẫu, không chứng minh đủ 10 người hoặc mọi chế độ. “Không có trong mẫu” không có nghĩa API vĩnh viễn không hỗ trợ. “Chưa kiểm chứng” nghĩa là chưa có response thành công. Báo cáo hiển thị tuổi mẫu; cần bấm lại sau khi đổi phase. Có timeout 2,5 giây mỗi request, giới hạn body 2 MB và cache 3 giây. Độ trễ HTTP không phải độ trễ spectator. Gold active player không phải total gold. Event IDs chưa đủ xác minh objective/inhibitor timer.

Tham khảo chính thức: https://developer.riotgames.com/docs/lol#game-client-api .
Khảo sát client thật cần người dùng thao tác; adapter live cho OBS đã có.

## Ưu tiên kiểm thử in-game bằng replay

1. Chạy backend, mở Studio → **Nguồn dữ liệu → Bắt đầu theo dõi**. Có thể bật trước khi mở client. Công cụ không cần lockfile cho hai nguồn trên port 2999.
2. Mở replay từ LoL Client. Quan sát riêng **Game** và **Replay**; Replay có giờ nhưng bảng người chơi trống nghĩa là chưa thu được dữ liệu player qua Live Client.
3. Để chạy khoảng 10 giây, pause khoảng 5 giây rồi resume. Thử tốc độ 2x, tua tiến và tua lùi. Theo dõi epoch/session và xuất bản ghi ngay sau từng tình huống; bản ghi RAM chỉ giữ tối đa 120 mẫu hoặc khoảng 2 MB compact.
4. Đóng replay để kiểm tra mất nguồn, mở lại để kiểm tra phiên mới. Field thiếu hiện —, dữ liệu quá 5 giây bị ẩn. OBS nhận nguồn được chọn khi demo tắt; replay clock không chứng minh có roster/telemetry.
5. **Dừng theo dõi** hoặc chuyển tab sẽ dừng request của cửa sổ đó; cửa sổ Studio khác đang bật theo dõi vẫn tiếp tục.

Theo tài liệu Riot, Replay API mặc định tắt. Nếu cần bật, khi game đã đóng, tìm file `Config/game.cfg` tại thư mục cài LoL và đặt `EnableReplayApi=1` trong section `[General]` hiện có; sau đó mở lại replay. Công cụ không tự sửa file này. Nguồn chính thức: https://developer.riotgames.com/docs/lol#replay-api . Không mặc định Replay API cung cấp thống kê người chơi.

Integration dành riêng observer, với backend đang chạy:

```powershell
npx tsx tests/observer.integration.ts
```

Test này chỉ đọc nguồn/bản ghi, không đổi mock/theme; nó tạo các mẫu quan sát trong bộ đệm. Test transport cũ vẫn thay đổi/reset mock, nên chỉ chạy trong phiên test.

Nếu sandbox Windows gây lỗi `uv_os_get_passwd ENOMEM` cho tsx, có thể kiểm chứng bằng bản biên dịch tạm trong thư mục đã ignore, không sửa dependency:

```powershell
node node_modules/esbuild/bin/esbuild tests/*.test.ts tests/transport.integration.ts tests/observer.integration.ts server/index.ts --bundle --platform=node --format=esm --packages=external --outdir=.npm-cache/verify --out-extension:.js=.mjs
node --test .npm-cache/verify/tests/*.test.mjs
node .npm-cache/verify/server/index.mjs --production
```

Ở terminal khác, chạy `node .npm-cache/verify/tests/observer.integration.mjs` hoặc `node .npm-cache/verify/tests/transport.integration.mjs`. Bản tạm phải biên dịch lại sau khi sửa source. Đây là cách kiểm chứng môi trường hạn chế, không thay thế script dev mặc định.


## Luồng live hiện tại (thay thế ghi chú OBS mock phía trên)

Giữ “Dùng dữ liệu demo” tắt. Studio/OBS tự nhận frame quan sát khi có kết nối; nút bắt đầu/dừng theo dõi chỉ điều khiển bảng chẩn đoán. Không có nguồn thì giữ khung và dấu —. Icon live dùng Data Dragon 16.20.1 (11/10/2026) riêng với demo 15.20.1. Cập nhật bằng `npm run assets:sync:live`, sau đó `npm run build` và restart backend; patch replay chưa được API xác nhận. Font condensed live được bundle tại public/fonts/broadcast kèm giấy phép OFL; công cụ đo UI xem VISUAL_MEASUREMENTS.md.

## LeagueBroadcast provider

LeagueBroadcast là ứng dụng Windows chạy cùng máy observer. Tải installer hoặc portable từ `https://leaguebroadcast.gg/download`, đăng nhập tài khoản BlueBottle và spectate một custom game. Trong Rift Studio vào **Nguồn dữ liệu**, chọn **LeagueBroadcast: WebSocket local**. Adapter kết nối `ws://127.0.0.1:58869/ws/in`; không cần cài SDK npm vì project tự triển khai client JSON tối thiểu theo giao thức công khai.

Đây là dependency bắt buộc cho phiên production cần bộ dữ liệu giải đấu đầy đủ: gold, HP/resource, rune, ability và objective của đủ 10 người. Riot local vẫn dùng được cho replay/kiểm thử nhưng phải được coi là chế độ giới hạn; không tự fallback từ LB sang Riot local khi đang phát sóng.

Kiểm tra với LeagueBroadcast 1.13.3 cho thấy replay thường của client không được ứng dụng nhận là một trận đang chạy: WebSocket vẫn kết nối nhưng gửi `gameStatus=Loading`, telemetry ở trạng thái `idle` và không có game hiện tại. Workflow chính thức của LeagueBroadcast dùng một custom game đang được spectate trên máy production. Vì vậy dùng Riot local khi phát lại `.rofl`; dùng LeagueBroadcast khi quan sát custom game live. Chờ quá trình kiểm tra asset patch hoàn tất trước khi thử custom game.

Nếu trạng thái là “Cần đăng nhập hoặc quyền truy cập”, hoàn tất đăng nhập/gói trong LeagueBroadcast. Nếu là “Nguồn đang phát demo”, tắt mocking ở ứng dụng đó; Rift Studio không coi frame demo là live. Chuyển lại Riot local không cần đóng LeagueBroadcast.

Không dùng bản LeagueBroadcast cũ đọc memory. Không cài driver, DLL injector hoặc công cụ hook game. Riot cho biết API/game client/in-game API và spectator/replay service dự kiến tiếp tục hoạt động với Vanguard, còn external memory reading không được phép. Luôn kiểm tra lại policy Riot trước khi phát hành.

## Lưu snapshot phiên live

Khi Riot Client, trận spectator custom, LeagueBroadcast và Rift Studio đang chạy, dùng:

```powershell
npm run capture:live
```

Mặc định công cụ lưu 20 giây dữ liệu vào `data/captures/<thời-gian>/`. Có thể truyền số mili giây, tối thiểu 5 giây và tối đa 120 giây, ví dụ `npm run capture:live -- 60000`. Snapshot gồm các endpoint Live Client, Replay, LeagueBroadcast, backend overlay, Swagger và chuỗi frame WebSocket có timestamp. `data/captures/latest.json` trỏ tới bản mới nhất.

Dữ liệu trận, tên người chơi và URL asset được giữ để xây bộ phát giả lập sau này. Các field có tên authorization, password, secret, token hoặc lockfile luôn bị thay bằng `[redacted]`. Thư mục `data/` bị Git bỏ qua; muốn chuyển snapshot sang máy khác cần copy riêng thư mục capture.

Nếu mục tiêu chỉ là bắt feed LeagueBroadcast và cần mở socket ngay để không bỏ lỡ phiên ngắn, dùng:

```powershell
npm run capture:lb -- 20000
```

Công cụ ghi từng message vào `data/captures/lb-<thời-gian>/leaguebroadcast-ws.ndjson`, tự kết nối lại trong thời lượng đã chọn và tạo `manifest.json`. Thời lượng tối thiểu 5 giây, tối đa 4 giờ. Nó chỉ đọc WebSocket localhost công khai của LB; không kết nối NamedPipe nội bộ hoặc load DLL.

### Capture một trận custom và đánh dấu realtime

Chạy trước khi vào cấm chọn để giữ một phiên tối đa ba giờ:

```powershell
npm run capture:lb -- 10800000
```

Capture stream thẳng xuống đĩa, tự reconnect và khi dừng bằng Ctrl+C vẫn hoàn tất manifest. Trong lúc chạy, `data/captures/active-lb.json` trỏ tới đúng phiên đang ghi; pointer này được xóa khi phiên kết thúc.

Khi người dùng gửi marker dạng `STT - MM:SS`, ghi marker vào phiên đang chạy bằng:

```powershell
npm run capture:mark -- "6 - 18:42"
```

`MM:SS` là clock trong game hoặc spectator. STT từ 1 đến 12 theo checklist custom (12 là trụ bổ sung) và có thể lặp lại, ví dụ nhiều lần hạ rồng. Marker lưu cả game time, thời điểm nhận tin và cửa sổ mặc định ±10 giây. Nếu không có capture đang chạy, lệnh từ chối thay vì ghi nhầm vào bản cũ.

Có thể thêm ghi chú sau timer, ví dụ `npm run capture:mark -- "5 - 03:35 GA kích hoạt"`. Với Phòng Tập có thể bỏ qua STT 1; STT 2 là lúc bắt đầu loading và dùng `00:00`. Tất cả mốc còn lại dùng timer trong game. Mỗi marker cũng kiểm tra tuổi file nguồn: nếu LB không phát frame mới quá 5 giây, kết quả sẽ cảnh báo ngay nhưng vẫn giữ marker để phục vụ đối chiếu sự cố.

Sau trận, ghép marker với frame bằng:

```powershell
npm run capture:analyze -- lb-<thời-gian>
```

Báo cáo trả số frame trong ±10 giây, frame gần nhất và sai lệch game clock. Với cấm chọn/loading chưa có game clock, dùng `markedAt` và các `gameStatus` gần marker. Có thể đổi cửa sổ, ví dụ `npm run capture:analyze -- lb-<thời-gian> 15`.

## Kiểm thử hoàn thiện và layout tối giản

Chạy `npm test`, `npm run build`, `npm run test:integration`. Test tích hợp dùng cổng 4311 và tự tạo/xóa theme tạm; không cần dừng backend vận hành 4310. Nếu cổng 4311 đã dùng, dừng phiên test trước đó, không tự kill process lạ. Backend hỗ trợ biến môi trường `RIOT_OVERLAY_THEME_PATH` để cô lập theme; mặc định vẫn là `data/theme.json`.

Mở **Kết nối dữ liệu → Kiểm thử bằng bản ghi đã lưu**, chọn capture và mở. Cả ID cũ và ID có tiền tố `lb-` được hỗ trợ. Parser stream tối đa 512 MB/10.000 state frame; bỏ bootstrap trống của LB, từ chối frame demo/sai và timestamp đảo chiều. Bản ghi thật local không đi theo Git; regression đó tự báo skip nếu máy không có file.

**Giao diện & đội → Biến thể → Tối giản / đường nhấn** đổi bảng live thành 10 portrait với HP, phép/ultimate và item có cooldown/GA. Đây là chuyển layout thủ công, chưa có trigger tự phát hiện giao tranh. Timer lấy `readyAt`/game clock quan sát, không bắt đầu bằng marker chat; pause/tốc độ được áp dụng. Mất nguồn 5 giây ẩn số và hiệu ứng; seek/reconnect không phát lại event lịch sử.

Event level/item dùng cạnh snapshot và allowlist item lớn; quest completion
cũng phát từ cạnh snapshot. Hạ rồng có banner theo loại; Soul có artwork
riêng/copy có nguồn, không giữ nhãn trạng thái thừa. Buff từng player lấy
telemetry; Power Play gold live là fallback suy ra +1500 rồi cộng biến động
chênh vàng ròng hai đội. Elder chỉ timer 150s, Baron 180s, inhibitor 300s.
Chưa tính damage giao tranh hoặc chốt activation Zhonya/end-game.

### Phòng thử bằng bộ dữ liệu thật

Mở `http://127.0.0.1:4310/?page=demo` hoặc **04 Phòng thử**. Module tự mở capture có nhiều frame nhất nếu chưa dùng recording; có thể chọn bản khác và bấm **Mở bộ dữ liệu thật**. Phòng thử không bật fixture mock. Mỗi nút tìm snapshot thật phù hợp và pause tại mốc đó; event thật được chủ động phát lại để xem hiệu ứng, ghi nhãn kích hoạt thử. Preview và OBS cùng nhận kết quả, nên không dùng Phòng thử khi đang phát sóng live.

Các nút: leaderboard gold/level, timer, minimal, rồng/Soul, Power Play,
cooldown/GA, chết/hồi sinh player, trụ/nhà lính, level/item, rune và clear.
Dropdown chọn 3 loại hang Baron, 7 rồng, 6 Soul, Baron/Elder/cả hai,
trụ đầu/thường, inhibitor xanh/đỏ, 5 role quest. Không có nút nhà lính hồi sinh.
Biến thể ghi rõ giả lập UI trên nền snapshot thật, không thay telemetry.
**Phát tiếp timer / bản ghi** bỏ biến thể; không sửa capture/theme. Nút thiếu
dữ liệu khóa kèm lý do. Rune cần đủ 9 perk ID cho 10 người; damage vẫn khóa.

Power Play recorded: +1500 G cộng biến động chênh vàng ròng từ mốc nhận đến
snapshot khoảng 10s sau, timer tối đa 180s hoặc loss cả đội đã ghi.
Play/tua bỏ bảng tĩnh; engine live theo cửa sổ buff quan sát. Đây là fallback,
không có field Power Play trực tiếp trong capture đã kiểm tra. Elder thật
vẫn cần mẫu mới; chọn Elder giả lập UI không thay thế kiểm chứng live.
