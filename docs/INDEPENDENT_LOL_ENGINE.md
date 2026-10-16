# Engine LoL riêng — prototype 14/10/2026

**Tách rõ hai nhánh:** prototype dưới đây vẫn chỉ gateway API2999. Research
memory riêng đã thử game một lần (module query failed, dừng trước RPM), rồi
diagnostic v2 đạt 5/5 đối chứng lab, không thêm dữ liệu LoL. Xem
[mốc lab hiện hành](../.research/independent-memory/LAB_DIAGNOSTICS.md).
Chưa tích hợp memory probe vào app hoặc thay LB; bước cần người dùng hiện tại
là replay/consent mới cho probe v2, không lặp gateway để tuyên bố full parity.

## Phạm vi đã xây

Engine `rift-independent` là tiến trình riêng, không sử dụng LB DLL, tài khoản/
quyềnDevelop, privateIPC hoặc WebSocketLB. Đầu vào hiện tại chỉ là GET của
Live Client Data và Replay API trên127.0.0.1:2999. Một cổng xuất local riêng
cấp snapshot chuẩn hóa, capability và WebSocket nhận-only.

Đây là **lõi điều phối/gateway độc lập, nguồn thu còn giới hạn**, không phải
engine thu telemetry đầy đủ thayLB. Chưa cài autostart vào app production,
chưa chuyển Studio/OBS sang engine mới. LB vẫn là dependency của nhánh production
đầy đủ hiện hành. Không tự fallback/ghépLB/API2999 hoặc điền mock.

## Chạy

Từ workspace đã cài dependencies:

```powershell
npm run engine:lol
```

Cổng mặc định4313, chỉ bind127.0.0.1. Dừng bằngCtrl+C; chỉ dừng engine do lệnh
này tạo, không dừng game/LB/backend khác. Port conflict làm startup thất bại,
không tự kill process. Có thể kiểm tra một phiên hữu hạn:

```powershell
npm.cmd run engine:lol -- --port 4313 --duration 10000
```

Để lưu bằng chứng acquisition đã lọc trong một phiên hữu hạn:

```powershell
npm.cmd run engine:lol -- --port 4313 --duration 90000 --report
```

Report exclusive-create ở `data/engine-reports/engine-<UTC>.json`, tối đa1500
mẫu metadata; không lưu frame raw, số stats hoặc tên người chơi. Giữ receive/
capture time, probe HTTPstatus/latency/time riêng, hai clock, pause/speed, map,
sequence/epoch/transition, roster và coverage. `clockAlignment=near` chỉ là
sai lệch hai clock≤1s, không chứng minh cùng trận; `divergent` là cảnh báo,
chưa tự giải đồng bộ nguồn hoặc freshness của từng giá trị.

Một lần kiểm tra schema công khai của game patch đang chạy:

```powershell
node scripts/inspect-game-client-schema.mjs
```

Công cụ chỉGET Swagger2999, không gọi gameplay command; report chỉ tên route/
method/model/property đã lọc. Không tải raw schema; khai báo field không chứng
minh runtime cung cấp field đó. Test parser không network: thêm `--self-test`.

- GET `http://127.0.0.1:4313/health`: server readiness, không game readiness.
- GET `/snapshot`: envelope engine và `ObserverFrame` đã lọc.
- GET `/capabilities`: độ phủ **mẫu hiện tại**, không cam kết mọi mode/patch.
- WS `ws://127.0.0.1:4313/ws`: message `type=independent-engine`, snapshot đầy
  đủ khi kết nối và mỗi cập nhật. Không gửi command; server đóng1008 nếu nhận.

Trên PowerShell dùng `npm.cmd` khi truyền flags; wrapper `npm.ps1` trong môi
trường đã thử có thể bỏ `--port`/`--duration`. Trên Linux/macOS dùng `npm`.

HTTP chỉGET, khôngCORS, guardHost/Origin local chống truy cập browser ngoài.
Không mởLAN/public; đây không phải xác thực mạnh chống processlocal có quyền.
Tối đa16WSclients, inbound4KB, backpressure256KB. Không raw errors/credential
hoặc playeridentity trong output/log. Dữ liệu số chuẩn hóa xuất qua snapshot,
console chỉ status/capability và đường report nếu bật. Không persist snapshot
hoặc sửa theme; report metadata nằm trong data được Git bỏ qua.

## Tái sử dụng và ranh giới

`server/independent-engine.ts` tạo instance `IngameCollector` riêng, dùng lại
normalizeIngame/ObserverSession/riot-objectives đang có. Collector chỉGET hai
endpoint chính thức, timeout/cache/singleflight như nhánhRiot hiện tại.
Không đọcLCUlockfile hoặc gọi discovery/login. Đây là code nội bộ project,
không sao chép logic native đã decompile củaLB.

`IndependentEngine` tách interface collector trảObserverFrame khỏi server.
Nguồn mới sau này cần adapter được kiểm chứng vào contract; không cắmraw provider
thẳngwidget hoặc đổisource thànhLB để giả tương thích. Clock-only không báo đủ
roster; source fail/exception xóa sample; sau5s không có frame thì snapshot
ẩn sample/events. Pause được giữ khi vẫn nhận sample mới từAPI; backwardseek
tăngepoch và seed eventhistory, không phát lại kills/objectives cũ.

`replacementReady=false` luôn rõ. `coverage` đếm field observed/non-null theo
player, không đo semantic đúng; perks cần9ID riêng biệt, cooldown cần ít nhất
một entry chứ chưa chứng minh mọi slot. Roster complete cần10slot riêng,5người
mỗi đội. Core từ chối field sourceLB hoặc playback recording bị gắn nhãn engine.
`missing` bao gồm phần field chưa đủ10 và
currentGold/damage/combat chưa có contract/acquisition tại prototype này.
Resource missing có thể do champion không córesource, không mặc định là lỗi.
Assets vẫn dùng cataloglive hiện có, patchmatch unverified; demo baseline giữ.

## Bước phát triển để đạt yêu cầu đầy đủ

1. **Mốc nền hiện tại:** tiến trình độc lập, output local, lifecycle/freshness,
   capability/null và kiểm thử transport. Không cầnLB để chạy tiến trình.
2. **Acquisition proof:** tìm nguồn độc lập được phép cho HP/maxHP, resource,
   gold/totalGold, QWER/summoner/itemcooldown, perks, buff/quest/objectives/
   inhibitor. Phải chứng minh bằng dữ liệu thật đủroster vàmode/patch mục tiêu.
   API2999 trong mẫu13/10/map12 chưa đủ các nhóm này. Xâyserver không giải quyết
   thiếu nguồn. Chưa có implementation hay quyền cho source thay thế.
3. **Full parity và tích hợp:** kiểm chứng đối chiếuLB (chỉ làmreference),
   pause/seek/reconnect/restart/patch, rồi nốiprovider mới và autostart cóownership
   cùngapp. Không enablefull-production trước khi vượt mốc2. Combat/damage chỉ
   mở khi cótelemetry thật, không suy damage từHP hoặc sốfixture.

QuyềnLB không áp dụng nếu không dùngengineLB; giới hạn truy cập game củaRiot
vẫn áp dụng riêng. Prototype không triển khai memoryreader/injector, patch
xác thực/signature, giảpublisher hay néVanguard. Không thể cam kết full parity
chỉ dựa trên phân tích tĩnh trước đó.

## Kiểm thử

```powershell
npx tsx --test tests/independent-engine.test.ts
npm test
npm run build
```

Test mới dùng source tổng hợp và cổng ephemeral, không gọigame/LB, không thay
theme/production. Phân biệt kiểm thử core/HTTP/WS với test acquisition thật.
Kết quả từng lượt ghiPROJECT_STATUS.md; trạng tháiport không là đảm bảo lâu dài.

## Runbook kiểm chứng gateway API — không phải bước hiện hành của nhánh memory

TắtLB trước, mở replay Summoner's Rift mới cùng patch1×, báo sẵn sàng. Không
tự đóng LB/game hoặc điều khiển replay. Agent kiểm tra listener/game schema và
thu baseline, rồi hướng dẫn pause10s/resume20s/seekback30s nếu nguồn phát được.
Mốc đạt chỉ là field lấy được thật; HP/gold/cooldown thiếu vẫn null. Mẫumap12
ngày13/10 không thay kiểm chứng này, và testAPI không tự giải bài toán fullparity.
