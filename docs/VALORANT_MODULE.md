# Module Valorant: ValorantCollector

Valorant là một collector tự chứa ở `collector/hosts/valorant-collector`, cùng cấp với các host LoL. Nó dùng **Spectra**:
Spectra Client chính thức chạy ngầm (lấy dữ liệu qua Overwolf GEP), backend Spectra Server fork và overlay VAL26.
Studio chỉ giữ phần giao diện/API (`server/valorant-*.ts`, `shared/valorant*.ts`, `src/valorant/`).
Mốc 13/10 (import fork Client/Server/Frontend) và các mốc 18/10 (Client ngầm, controller, cấu hình trận) xem `PROJECT_STATUS.md`.

## Cấu trúc và ranh giới

- `collector/hosts/valorant-collector/backend`: fork Spectra Server (ELv2), dependency/build riêng.
- `collector/hosts/valorant-collector/frontend-val26`: overlay in-game VAL26 của nobiiVAL (ELv2, `SOURCE.md`).
- `collector/hosts/valorant-collector/client`: điều khiển Spectra Client chính thức (tải một lần, SHA256 đã pin trong `release.json`).
- `collector/hosts/valorant-collector/runtime`: supervisor (backend + overlay + Client), cấu hình, setup tự cài, CLI; chỉ loopback.
- `collector/hosts/valorant-collector/tests`, `upstream.json`, `MODIFICATIONS.md`: kiểm thử, provenance, thay đổi so với upstream.
- `collector/hosts/valorant-collector/local`: dữ liệu cục bộ (config, key, Spectra Client đã tải, profile ngầm, logo, cấu hình trận); Git bỏ qua, tách theme LoL.
- Collector riêng đã nghiên cứu: `collector/archive/valorant-collector` (không dùng).

Không sửa contract, provider, theme hoặc renderer LoL. Không tự chạy Docker, đóng Overwolf hay chiếm cổng của stack Spectra khác.

## Cài và build

Thường không cần làm tay: bật công tắc Valorant trong Studio lần đầu sẽ tự cài (xem [SETUP_VI.md](SETUP_VI.md)). Chạy tay:

```powershell
npm run valorant:setup    # config + key, backend, overlay VAL26, tải Spectra Client (một lần, SHA256 pin)
npm run valorant:doctor   # kiểm build, Spectra Client, cổng
```

Cần Node 22 và mạng. Dependency module nằm ngoài root lock/tsconfig; npm lifecycle scripts upstream bị tắt (`--ignore-scripts`)
để không cài hook Git hay tự chạy installer. `npm run build:valorant` build lại backend và overlay.
Spectra Client dùng profile riêng trong `local/spectra/official-profile`; log của chính Client có ghi key local nên không chia sẻ thư mục `local/`.

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
`node collector/hosts/valorant-collector/runtime/inspect-output.mjs` đọc một snapshot output và
chỉ báo số slot/capability, không ghi raw/danh tính. Services-only giữ Client
người dùng đã mở, không dừng nó khi đóng services.

1. Cung cấp đường dẫn/version Client và mở bằng launcher sau khi config path.
2. Chọn ingest custom `http://127.0.0.1:5310`, group code `RIOTLOCAL`.
3. Nhập access key từ **file local** `collector/hosts/valorant-collector/local/auth.key`; không gửi nội dung
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

Browser QA: `collector/hosts/valorant-collector/tests/browser-smoke.mjs`, cần biến
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
Giấy phép/provenance và khác biệt manifest được ghi ở `collector/hosts/valorant-collector/MODIFICATIONS.md`.

## Client chạy ngầm cùng app (18/10/2026)

Chạy `npm start`, chọn game Valorant ở thanh bên Studio và bật công tắc **Kết nối Valorant**. Lần đầu Studio tự cài (backend, overlay VAL26) và **tải Spectra Client chính thức một lần**
(kiểm SHA256 đã pin) nếu máy chưa có, rồi chạy ngầm; không cần mở Client hay nhập form. Chi tiết cách chạy ngầm, tự cấu hình, tắt phím nóng toàn cục, controller và giới hạn:
[collector/valorant/README.vi.md](../collector/hosts/valorant-collector/client/README.vi.md).

Vì sao dùng Client chính thức thay vì collector riêng: Overwolf chỉ cấp GEP thật cho app UID đã đăng ký (UID là băm của `productName/name + author.name`). Collector riêng đã dịch từ Spectra Client
nhận gói giả `0.0.0` với UID của dự án nên không có dữ liệu; nó được lưu ở `collector/archive/valorant-collector`. Dự án không dùng danh tính của Spectra cho app khác và không chỉnh gói GEP.
`collectorMode` trong `module.json` chỉ còn `official` (giá trị cũ `gep`/`fork` được coi là `official`).

## Điều khiển thủ công và overlay VAL26 (18/10/2026)

Trang Studio `/?page=valorant` có các nút tương đương phím nóng/nút của Spectra Client: bom đã đặt (chỉ nhận khi
round đang combat), tech pause, timeout đội trái/phải, đổi KDA/credits, đổi trái-phải, đổi tấn công-thủ và toast.
Lệnh đi Studio `POST /api/valorant/control` (cùng origin, JSON, allowlist) → controller của Studio (phiên observer thứ hai) → ingest. Trạng thái pause/timeout/toast đọc
lại từ frame (`controls`) và là dữ liệu nhập tay, không phải telemetry. Đã kiểm: tech pause, đổi KDA/credits, toast
(tự tắt) và chặn origin lạ; chưa thử plant/timeout trong trận.

Overlay in-game dùng bản **VAL26** của nobiiVAL (`collector/hosts/valorant-collector/frontend-val26`, ELv2, xem `SOURCE.md`):
`http://127.0.0.1:5322/overlay?groupCode=RIOTLOCAL` (OBS 1920×1080). Build bằng `npm run build:valorant`
(hoặc `npm run build` trong thư mục đó). `frontendVariant: "spectra"` trong `collector/hosts/valorant-collector/local/module.json` quay về bản cũ.
Chưa audit toàn bộ widget/animation; team name/logo đang là mặc định "Team 1/Team 2" cho tới khi có cấu hình đội.

## Chọn game, công tắc kết nối và cấu hình trận (18/10/2026)

Studio chọn game LoL/Valorant ở thanh bên; mỗi game có công tắc kết nối riêng (lưu ở `data/studio-games.json`, mặc định LoL bật, Valorant tắt).
Tắt LoL ngắt LeagueBroadcast, collector và các vòng poll LoL; tắt Valorant dừng toàn bộ module (backend, frontend, Client) và socket Spectra.
Module Valorant do Studio quản lý (`server/valorant-module.ts`); `npm run start:valorant` vẫn dùng được khi chạy riêng, nhưng không chạy song song với công tắc (trùng owner/cổng sẽ báo lỗi).

Trang Valorant có Tổng quan, Cấu hình trận (tên/mã/logo hai đội, tỉ số loạt trận, thể thức, tên và logo giải, tên thay thế người chơi) và Phát sóng
(overlay thu nhỏ + nút điều khiển). Cấu hình lưu ở `collector/hosts/valorant-collector/local/match-config.json`, logo ở `collector/hosts/valorant-collector/local/assets` (đặt tên theo hash, kiểm tra chữ ký ảnh,
tối đa 350KB, phục vụ ở `/uploads` của frontend module). Lưu xong, Studio gửi lệnh `apply_config`; controller gửi `config_update` lên backend fork để đổi giữa trận
(Spectra gốc chỉ đọc đội lúc tạo trận). Client mới kết nối cũng được điền lại từ file này.

## Postgame (19/10/2026)

Trang Valorant → **Postgame**, overlay OBS tại `/valorant-postgame/preview.html` (bảng điểm) và `/valorant-postgame/mvp.html` (thẻ MVP), 1920×1080, nền trong suốt. Bố cục lấy từ repo `Seotow/valorant-postgame-stats` (xem `public/valorant-postgame/SOURCE.md`), phần Flask đã chuyển vào Studio (`server/valorant-postgame.ts`).

Hai nguồn, chọn trong trang:

- **Spectra (tự động, không cần key):** Studio giữ khung cuối của trận đang theo dõi (lưu ở `local/postgame-last.json`). Có tỉ số, map, agent, K/D/A, tên người chơi. Không có ACS, damage/round, first kill %, KAST %, thời lượng: overlay hiện "—".
- **Henrik Dev (đủ số liệu):** nhập Riot ID, khu vực và API key (lưu ở `local/postgame.json`, không bao giờ trả về trình duyệt), tải lịch sử rồi chọn trận. Nếu Henrik lỗi, overlay lùi về khung Spectra.

Tên đội, logo, logo giải và tên thay thế lấy từ **Cấu hình trận**, dùng chung với overlay in-game.

Vì sao Spectra không đủ: GEP của Overwolf không có ACS, không có damage của người khác (chỉ `round_report` của người chơi cục bộ), `match_end` không kèm dữ liệu hay thời gian. First kill và thời lượng có thể suy ra từ kill feed và mốc thời gian nhưng cần mở rộng backend Spectra; chưa làm.

Bổ sung: theme mặc định (màu, độ mờ, font, ảnh nền và nhà tài trợ) lấy từ `overlay-config.json` của project gốc và chỉnh được trong mục Giao diện; file cấu hình cũ chưa có `themeVersion` được nạp lại theme gốc một lần. Logo đội phục vụ qua `/api/valorant/postgame/logo/<tên>` nên chạy cả khi module Valorant tắt; ảnh lỗi bị ẩn. Overlay đọc `/api/valorant/postgame/render` và `/mvp`, tự làm mới mỗi 2 giây.

## Player đẩy dữ liệu từ xa + cam (23/10/2026)

Để lấy đủ dữ liệu 10 người, mỗi player chạy bản player đẩy về ingest của host qua tunnel.

- **Host:** Valorant → Phát sóng → bật "Player đẩy dữ liệu (ngoài LAN)". Studio chạy `cloudflared`
  quick tunnel (tải một lần, kiểm SHA256, không cần tài khoản) trỏ về cổng ingest, lấy URL
  `trycloudflare.com` rồi sinh **code ngắn** (`shared/valorant-remote.ts`) chứa origin + group code +
  key. API `/api/valorant/remote` GET/POST; quản lý ở `server/valorant-remote.ts`,
  `collector/hosts/valorant-collector/runtime/tunnel.mjs`. Tắt game Valorant thì tunnel tự tắt.
- **Player:** `npm run valorant:player -- <CODE>` (`collector/hosts/valorant-collector/player/`). Giải
  mã code, tải Spectra Client một lần, chạy ngầm trỏ ingest tới URL công khai. Chỉ cần nhập code.
- **Cam:** qua vdo.ninja (bên thứ ba, WebRTC). Trong Cấu hình trận → "Player cam": đặt room id và danh
  sách Tên#Tag; Studio gửi `playercams` (identifier + enabledPlayers) qua config_update, overlay kéo
  cam `vdo.ninja/?room=<id>&view=<Tên>_H_<Tag>`. Mỗi player mở "Link đẩy cam" để phát webcam. Media
  không đi qua host nên host chạy local vẫn hoạt động.
