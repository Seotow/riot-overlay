# Module Valorant — khởi động độc lập

Mốc 13/10/2026: đã import/fork local source ValoSpectra Client, Server, Frontend
theo revision pin. Backend/FE build và chạy riêng; đã có launcher và kiểm thử
lifecycle/Socket.IO. Đã gắn và khởi động **official Client 0.3.4 Observer**, cửa
sổ báo Ready/GEP 315.1.0. **Chưa kết nối collector tới backend hoặc xác minh
telemetry trận Valorant.** Source collector fork 0.3.3 chưa build; không coi
binary official 0.3.4 là bản build từ source fork.

## Cấu trúc và ranh giới

- `modules/valorant/collector`: source Overwolf Electron, giữ GPL; chưa build.
- `modules/valorant/backend`: fork Spectra Server, dependency/build riêng.
- `modules/valorant/frontend`: fork Angular FE, dependency/build riêng.
- `modules/valorant/runtime`: launcher Node và static/status server chỉ loopback.
- `modules/valorant/upstream.json`, `MODIFICATIONS.md`: provenance và thay đổi.
- `data/valorant`: config, key và owner runtime; bị Git ignore, tách theme LoL.

Không sửa contract, provider, theme hoặc renderer LoL. Lệnh `dev`/`start` LoL
giữ nguyên. Module chưa được nhúng vào tab Valorant của Studio; đó là mốc kế tiếp.
Không tự chạy Docker, đóng Overwolf hoặc chiếm cổng của stack Spectra cũ.

## Cài và build

Từ root project:

```powershell
npm ci --ignore-scripts --prefix modules/valorant/backend
npm ci --ignore-scripts --prefix modules/valorant/frontend
npm run build:valorant
npm run valorant:init
npm run valorant:doctor
```

Node 22.12 hiện đã build được; một dependency lint mới cảnh báo cần 22.13+/24.
Không tự nâng Node toàn máy. Dependency module nằm ngoài root lock/tsconfig,
không thêm Angular vào build LoL. Npm lifecycle scripts upstream được tắt để
không cài hook Git hoặc tự chạy installer.

`valorant:init` không ghi đè config/key đã có. Đặt `collectorPath` trong
`data/valorant/module.json` thành đường dẫn absolute tới **Spectra Client.exe**
đã cài, hoặc để `null` khi chỉ kiểm chứng services. Không nhập command shell.
Source Client không thay thế executable/Overwolf runtime. Đã có helper
`scripts/assets/acquire-spectra-client.ps1` tải/giải nén release 0.3.4 theo SHA256
pin (cần 7-Zip); không chạy installer hoặc can thiệp anti-cheat. Nếu thư mục
runtime đã có, helper từ chối ghi đè.

Sau khi tìm/khôi phục executable, gắn path bằng:

```powershell
npm run valorant:collector -- "D:\duong-dan\Spectra Client.exe"
```

Lệnh tạo backup config, kiểm tra path, giữ group/port/key hiện có. Runtime đang
dùng nằm trong `data/valorant/collector/0.3.4` (bị Git ignore). Đã tìm thấy
installer cũ 0.3.4 trong Downloads/SetUp, hash khớp release chính thức; shortcut
Player/Auxiliary cũ trỏ tới executable đã mất. Không chạy lại installer cũ hoặc
ghi đè shortcut. Provenance ở `modules/valorant/collector-release.json`.

Binary official dùng profile/log upstream Spectra Client tại AppData, chưa có
profile riêng như BE/config module. Module không copy/export raw log; chỉ đọc
marker version/Observer/GEP ready để kiểm chứng. Không đưa config, key hay
log toàn bộ upstream vào chat/Git. Startup collector GUI được để hiển thị
cho operator; helper/backend vẫn ẩn console.

## Chạy

```powershell
npm run start:valorant
```

Launcher mở backend/FE, chờ health rồi gọi collector nếu đã cấu hình path.
Nếu path còn null, services vẫn chạy và hiển thị cần executable; không coi đó
là collector ready. `--services-only` bỏ qua collector cho phiên kiểm thử:

```powershell
npm run start:valorant -- --services-only
```

| Phần | Mặc định |
| --- | --- |
| Collector ingest | `http://127.0.0.1:5310` |
| Backend status | `http://127.0.0.1:5311/status` |
| Socket.IO output | `http://127.0.0.1:5320` |
| Trạng thái module | `http://127.0.0.1:5322/_module` |
| OBS in-game | `http://127.0.0.1:5322/overlay?groupCode=RIOTLOCAL` |
| Agent select | `http://127.0.0.1:5322/agent-select?groupCode=RIOTLOCAL` |

OBS 1920×1080, nền trong suốt. FE giữ baseline upstream, chưa audit toàn bộ
widget/animation. Các route fixture/testing không được launcher expose như live.
Health có process/collector socket riêng, không chứng minh đủ 10 người hoặc GEP
hoạt động. Gate 5s không có ingest update sẽ ẩn HUD; pause hoặc phase ít event
có thể bị ẩn, cần điều chỉnh sau mẫu thật. Availability HP vẫn phụ thuộc cờ upstream,
chưa đủ timestamp từng field. Phần telemetry contract riêng còn chờ mẫu.

Ctrl+C trong terminal launcher dừng process/tree do nó sở hữu và đóng frontend.
Backend lỗi sẽ dừng module; không dừng LoL hoặc process Spectra người dùng mở
trước đó. Trùng cổng/owner báo lỗi, không tự kill process khác. Nếu collector
single-instance chuyển sang instance đã có, status ghi rõ chưa xác nhận ownership;
launcher không nhận quyền dừng instance đó.

## Thao tác cần trên Spectra Client thật

Handshake phiên 13/10 đã xác nhận sau khi mở lại BE/FE: Client Connected,
server có authenticated observer và output trả snapshot đúng RIOTLOCAL.
Main Menu có LOBBY/isRunning=false/0 player, chưa xác minh telemetry trận.
Nếu Reconnecting trong khi game status vẫn đúng, kiểm tra backend còn chạy;
GEP và đường Client→Server là hai kết nối riêng. Giữ terminal launcher hoạt động.
`node modules/valorant/runtime/inspect-output.mjs` đọc một snapshot output và
chỉ báo số slot/capability, không ghi raw/danh tính. Services-only giữ Client
người dùng đã mở, không dừng nó khi đóng services.

1. Cung cấp đường dẫn/version Client và mở bằng launcher sau khi config path.
2. Chọn ingest custom `http://127.0.0.1:5310`, group code `RIOTLOCAL`.
3. Nhập access key từ **file local** `data/valorant/auth.key`; không gửi nội dung
   key vào chat, log, screenshot hoặc Git. Điền observer/team theo UI Client.
4. Kết nối, đối chiếu `observerConnected` và GEP Ready ở Client. Sau đó mới mở
   custom observer để thu mẫu roster/scoreboard/round/kill/spike và reconnect.

Key local dùng để xác thực feed của bản Server fork, không phải Riot API key
hay key dịch vụ cloud. Module không tắt hoặc bypass kiểm tra auth/Plus/watermark.
Không copy secret/backend auth vào frontend config được serve.

## Kiểm chứng

```powershell
npm run test:valorant
npm run build
npm test
npm run test:integration
```

Valorant test tự chọn cổng/config/key tạm trong cache, chạy BE fork thật,
kiểm tra conflict, ownership, lỗi/restart, auth, output/reconnect, source loss,
HTTP guard và shutdown. Dữ liệu là synthetic transport fixture, không phải game.
LoL integration dùng backend/theme riêng; không gọi command lên phiên đang phát.

Browser QA: `modules/valorant/tests/browser-smoke.mjs`, cần biến
`OVERLAY_BROWSER_PACKAGES` trỏ thư mục Playwright/sharp có sẵn. Dùng Edge
headless/profile riêng, kiểm tra status, routes, transparent OBS 1920×1080 và
không request ngoài. Screenshot nằm trong `.npm-cache`, không thuộc runtime.

Windows sandbox từng chặn loopback/realpath/dist (EPERM); các build/integration
đã được chạy lại với quyền môi trường bình thường, không đổi logic để né lỗi.
Các kết quả không đảm bảo cổng/process tiếp tục chạy qua reboot.

## Chưa làm

Build/package collector fork, health GEP readiness tự động tại launcher (đã quan
sát Ready trực tiếp từ cửa sổ/log version nhưng status module chưa có IPC GEP), tự cấu hình Client,
thu mẫu game thật, capability/normalization đầy đủ, custom giao diện/branding,
nhúng FE vào Studio và launcher chung LoL+Valorant. Không có collector mới thay GEP.
Giấy phép/provenance và khác biệt manifest được ghi ở `modules/valorant/MODIFICATIONS.md`.

## Client fork tự gắn vào app (18/10/2026)

`npm run start:all` chạy Studio + backend/FE Valorant + **Client fork** (build từ source trong
`modules/valorant/collector`), không cần mở Spectra Client hay nhập form. Fork thêm `src/headless.ts`:
chỉ bật khi có `RIOT_OVERLAY_SPECTRA_CONFIG` (JSON do supervisor ghi vào `data/valorant/runtime/headless.json`,
chỉ chứa ingest loopback, group code và đường dẫn tới `auth.key`; key không nằm trong config và không ghi log).
Chế độ này ẩn cửa sổ/tray, bỏ kiểm tra cập nhật, nuốt hộp thoại, tự kết nối ingest và dùng profile riêng
(`data/valorant/collector/fork-profile`, `RIOT_OVERLAY_SPECTRA_PROFILE`) nên không đụng Client cài sẵn.
Không có biến này thì fork chạy như upstream. GEP do Overwolf cung cấp qua ow-electron, không cần đăng nhập.

Build (một lần, cần Node 22, Yarn 4 qua corepack; không cần Visual Studio vì bỏ qua rebuild native):

```powershell
cd modules/valorant/collector
$env:YARN_ENABLE_SCRIPTS = "false"; yarn install
node node_modules/@overwolf/ow-electron/install.js
npx tsc; yarn workspace angular build
```

`collectorMode` trong `data/valorant/module.json` (`fork` mặc định, hoặc `official` để dùng
`collectorPath`). Fork chưa build thì supervisor quay về `collectorPath` nếu có. Chỉ nên chạy một Client tại
một thời điểm: Client chính thức đang mở sẽ tranh GEP với fork. Đã kiểm chứng: fork xác thực với backend,
GEP 315.3.5 báo ready, observer=1, Studio `receiving` ở lobby. Chưa kiểm trong trận.
Dừng bằng Ctrl+C ở terminal launcher; nếu launcher bị kill đột ngột, process Electron của fork có thể còn sót.

## Điều khiển thủ công và overlay VAL26 (18/10/2026)

Trang Studio `/?page=valorant` có các nút tương đương phím nóng/nút của Spectra Client: bom đã đặt (chỉ nhận khi
round đang combat), tech pause, timeout đội trái/phải, đổi KDA/credits, đổi trái-phải, đổi tấn công-thủ và toast.
Lệnh đi Studio `POST /api/valorant/control` (cùng origin, JSON, allowlist) → Client fork (cổng output + 10, bearer
token trong `data/valorant/runtime/headless.json`, không trả về trình duyệt) → ingest. Trạng thái pause/timeout/toast đọc
lại từ frame (`controls`) và là dữ liệu nhập tay, không phải telemetry. Đã kiểm: tech pause, đổi KDA/credits, toast
(tự tắt) và chặn origin lạ; chưa thử plant/timeout trong trận.

Overlay in-game dùng bản **VAL26** của nobiiVAL (`modules/valorant/frontend-val26`, ELv2, xem `SOURCE.md`):
`http://127.0.0.1:5322/overlay?groupCode=RIOTLOCAL` (OBS 1920×1080). Build bằng `npm run build:valorant`
(hoặc `npm run build` trong thư mục đó). `frontendVariant: "spectra"` trong `data/valorant/module.json` quay về bản cũ.
Chưa audit toàn bộ widget/animation; team name/logo đang là mặc định "Team 1/Team 2" cho tới khi có cấu hình đội.
