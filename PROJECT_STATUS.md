# Trạng thái bàn giao

Cập nhật 17/10/2026. Bản hiện tại chuẩn bị dùng nội bộ trên Windows, chạy
bằng terminal. Giữ bố cục draft/in-game đã duyệt, không mở lại vòng thiết kế.

## Đã có

- Studio dùng shadcn, tách cấu hình trận, nguồn dữ liệu, phát sóng, phòng thử,
  cấm chọn, sau trận và HUD.
- Layout có cam/không cam, đầy đủ/tối giản; leaderboard vàng và XP đủ 10 người;
  rune, lane quest, cooldown, stack và counter đồ theo dữ liệu đã có.
- Timer rồng đọc quái sống hoặc Dragon Indicator trong frame hiện tại.
  Không đoán loại rồng tiếp theo từ lịch sử hạ rồng. Thiếu nguồn thì giữ unknown.
- Thứ tự Top, Jungle, Mid, Bot, Support từ role quest quan sát được; không
  đổi slot gốc. Ẩn số Atlas 3865, giữ số của các đồ hỗ trợ đã nâng cấp.
- Timer mục tiêu thu phần số khi về 0; icon có nền theo loại. XP, HP và
  resource cùng chiều rộng. Icon lane quest đã sửa tâm vòng và tâm glyph.
- Animation draft theo lượt/hover/khóa, không chạy lại khi timer tick.
- Bản ghi hiện hành là projection 10 từ raw ngày 16/10, có 1.525 mẫu.
  Raw và các projection trước được giữ nguyên, không theo Git.

## Đầu ra phát sóng

Thanh điểm số: cụm logo/tên sát hai mép hơn, chừa đủ chỗ cho tên 5 ký tự.
Mỗi đội có mô tả/thứ hạng riêng trong cấu hình; đổi bên mang theo mô tả.
Không dùng tên giải làm nhãn phụ. Để trống mô tả thì tên dùng toàn chiều cao.
Theme cũ vẫn đọc được, không tự ghi đè cấu hình cá nhân.

Đã bỏ nhãn bản ghi/kiểm thử, nhãn kích hoạt thử và ghi chú dữ liệu mẫu khỏi
graphic. Studio vẫn báo nguồn đang dùng và cảnh báo; không đổi provenance
hoặc tự biến bộ mẫu thành dữ liệu thật.

## Postgame và các phần tạm hoãn

**Postgame đã mở khóa, hướng replay `.rofl` (17/10/2026):** backend yêu cầu client tải replay sau trận (chưa
kiểm chứng với spectator), theo dõi thư mục Replays và `.npm-cache/rofl-inbox`, đọc metadata cuối file và đưa vào
vùng duyệt. Phân tích file mẫu VN2-1607368559: damage, KDA, vàng, trụ, Baron, Sứ giả, Sâu, winner, bot; thiếu vị
trí, cấm chọn, lịch sử vàng, rồng. Khóa lại bằng `RIOT_OVERLAY_POSTGAME=0`. Chi tiết: docs/POSTGAME_DATA_FINDINGS.md.

- LCU trả đủ damage/KDA/vàng cho trận custom 1607368559 khi dùng tài khoản
  người tham gia. Đổi sang spectator: history không có trận, detail/timeline 404.
- ROFL đọc được damage của 10 người, khớp LCU. Người dùng xác nhận file do
  tài khoản Seotoww tải trước đó. **Tạm hoãn hướng ROFL**, chưa làm import hoặc
  coi đây là nguồn tự động cho spectator. Elder counter còn lệch với raw.
- Riot API (Standard/RSO) và LCU EOG đã gỡ khỏi project (18/10/2026) sau khi chốt hướng replay `.rofl`;
  mã cũ còn trong lịch sử Git.
- Damage theo combat, một số champion stack, end-game tự động và draft live
  chưa hoàn tất. Không bù dữ liệu thiếu bằng mock.
- Ẩn riêng dấu 18+ VNG đang nghiên cứu. REA và Valorant giữ riêng, không
  nằm trong bản vận hành LoL này.

- 17/10: đo game 1608102102: spectator không nhận EOG; chỉ client người tham gia có. Số đo giữ ở
  [postgame](docs/POSTGAME_DATA_FINDINGS.md); hướng vận hành là replay `.rofl`.

Chi tiết: [LCU](docs/LCU_POSTGAME_FINDINGS.md),
[ROFL](docs/ROFL_POSTGAME_FINDINGS.md), [postgame](docs/POSTGAME_DATA_FINDINGS.md).

## Cài và chuyển máy

Tài liệu cài đặt, kiến trúc, kiểm thử và nghiên cứu đã gom vào docs/;
gốc chỉ giữ README.md, AGENTS.md và PROJECT_STATUS.md. Ảnh tham chiếu dùng
bản trong public/references, Baron SVG dùng bản trong public/broadcast.
Đã bỏ các bản trùng ở gốc và baron-white.png không có tham chiếu sử dụng.
Không xóa ảnh mẫu trong images/, dữ liệu trận hoặc tài liệu REA/Valorant.

Làm theo [SETUP_VI.md](docs/SETUP_VI.md). Git không chứa credentials, theme cá nhân,
captures, DLL/runtime/cache collector hoặc vendor source. Máy mới cần được
chuẩn bị runtime riêng nếu dùng collector tích hợp. Backend chỉ bind loopback,
không triển khai LAN/public. Chưa phải bộ cài độc lập.

## Kiểm chứng và bước tiếp

Kết quả các bài kiểm tra được ghi trong [TEST_REPORT.md](docs/TEST_REPORT.md).
Gate được kiểm bằng fixture cho player, spectator, replay, mất xác nhận và
chuyển trạng thái trong lúc chạy. Cần thêm một phiên spectator live để kiểm
đầu cuối trên máy vận hành; không coi fixture là test game thật.

Sau bản nội bộ: thử toàn trận spectator, kiểm chốt khi chuyển chế độ, rồi
mới mở lại nguồn postgame custom. Không sửa layout baseline nếu không có
yêu cầu mới.

[Nhật ký các mốc trước](docs/history/PROJECT_STATUS_2026-10-17.md) giữ các
số đo, bản ghi và quyết định cũ để tra cứu.

## Cấu trúc 17/10/2026

Thư mục `Collector/` đổi thành `collector/` với `hosts/` (source native), `bundles/` (bản build kèm runtime), `supervisor/`. `scripts/` chia thành assets, capture, inspect, verify, dev. Đã thêm Prettier (`npm run format`). Các tài liệu trong `docs/history/` giữ đường dẫn cũ. Chưa build lại host C# tại máy này; manifest và build script của host giữ nguyên.

## Adapter Valorant → Studio/OBS 18/10/2026

Đã làm: `server/valorant-spectra.ts` đọc Socket.IO output Spectra (cổng/group từ `collector/hosts/valorant-collector/local/module.json`, không đọc key) bằng client Engine.IO tối thiểu qua `ws`, chuẩn hoá sang contract `shared/valorant.ts` (value/null + availability + provenance). Route `/api/valorant/status|frame` (loopback, nguồn mở lười khi có request đầu), trang Studio Valorant (xem mục dưới); renderer OBS tối giản `/valorant-overlay` đã gỡ, thay bằng overlay VAL26. Không đổi contract/theme/renderer LoL.

Quy tắc: HP/ability chỉ nhận khi `auxiliaryAvailable` xác nhận (Spectra mặc định HP 100/ability 0 nên không dùng được); HP người chết = 0 (derived); tên đội = manual; mốc hết round = derived. Scoreboard thiếu thì money/vũ khí/giáp/ult = null; KDA giữ nhưng gắn derived.

Kiểm chứng: `tests/valorant-spectra.test.ts` (7 ca), `npm test` 238 pass, `npm run build`, `format:check` đạt; đã đọc frame thật từ backend Spectra với 1 người chơi (coverage: 1 slot, 1 scoreboard, 0 HP, 0 ability) và xem Studio + overlay trong browser.

Chưa làm: đủ 10 người/Auxiliary, kill feed, spike/plant thật, đổi observed player, reconnect giữa trận, giao diện overlay chưa audit (bản tối giản), `gameTelemetryVerified` vẫn false. Bước tiếp: thu mẫu có Auxiliary và nhiều người chơi.

Launcher `start:all` đã bỏ: Studio tự quản lý module Valorant qua công tắc (xem mục 18/10 cuối file).

Client fork gắn thẳng vào app (18/10/2026): Module Valorant tự chạy Client fork ẩn (`headless.ts`, `collectorMode: fork`), tự xác thực với backend; GEP 315.3.5 ready, observer=1, Studio nhận frame lobby. Chưa kiểm trong trận (HP/ability cần Auxiliary). Đã pull `origin/main` (ed83667), conflict `server/index.ts` giữ `PostgameService` + nguồn Valorant. Nhánh `backup/valorant-adapter-wip` giữ bản trước pull.

Điều khiển thủ công + overlay VAL26 (18/10/2026): nút Spectra (plant, tech pause, timeout, KDA/credits, swap, toast) có trong Studio qua kênh loopback Client fork; đã kiểm tech pause, KDA/credits, toast, guard origin. Đã import `frontend-val26` (nobiiVAL, ELv2, ghi nguồn), build và render với dữ liệu trận thật. Chưa làm: kiểm plant/timeout/swap trong trận, cấu hình tên/logo/series đội từ Studio, audit widget VAL26, tắt phần phụ thuộc runtime ngoài (font/ảnh đội từ URL).

Chọn game + công tắc kết nối + trang Valorant hoàn chỉnh (18/10/2026): thanh bên chọn LoL/Valorant, mỗi game có công tắc riêng (tắt thì dừng socket/process/poll của game đó); Valorant có Tổng quan, Cấu hình trận (đội, logo, tỉ số loạt trận, giải, tên thay thế) và Phát sóng (overlay thu nhỏ + nút điều khiển gọn). Cấu hình đổi được giữa trận qua `config_update` của backend fork. Đã kiểm live: bật/tắt LoL và Valorant qua API, lưu cấu hình với logo, backend nhận đúng đội/logo/series/giải/tên thay thế, `/uploads` chặn tên lạ, guard origin. Chưa kiểm: tên thay thế khớp `fullName` trong trận nhiều người, plant/timeout trong trận mới, tắt LoL khi đang có trận LoL thật.

Máy mới (18/10/2026): lỗi thiếu `module.json` do `data/` bị Git bỏ qua. Module nay tự tạo config + key khi bật kết nối; `collectorPath` không tồn tại không còn chặn chế độ fork (chỉ báo `executable-missing`); `npm run valorant:setup` dựng backend, overlay và Client fork; Studio hiện gợi ý khi fork chưa build. Đã kiểm bằng test (config trống, đường dẫn Client giả) nhưng chưa chạy trên một máy sạch thật.

Collector Valorant tự dựng (18/10/2026): `collector/hosts/valorant-collector` (Electron/ow-electron, không cửa sổ, dịch lại phần observer của Spectra Client, GPL-3.0-only, xem NOTICE.md) thay Client fork; gồm GEP → ingest, cổng lệnh loopback có `/status` (GEP, ingest, Overwolf thường đang chạy), tự cài/biên dịch khi bật kết nối lần đầu (`collector/hosts/valorant-collector/runtime/setup.mjs`). Đã kiểm: build sạch, xác thực ingest, Studio thấy trạng thái.

**Chặn: app UID Overwolf.** README ow-electron: UID = băm của productName/name + author.name; log `owpm.log` cho thấy app UID lạ nhận gói GEP giả `0.0.0` (21KB) thay vì GEP thật 315.x. Client fork trước đây chạy được vì giữ nguyên danh tính Spectra (name/author của Purple Shark). Vì vậy kết luận cũ "không cần đăng ký Overwolf" **chưa đúng**: collector mang danh tính của chính dự án cần được Overwolf đăng ký UID; tới lúc đó Studio hiện cảnh báo gói giả và UID cần đăng ký. Chưa quyết: đăng ký UID riêng, hay dùng Spectra Client chính thức (`collectorMode: official`).

Chế độ Client chính thức ngầm (18/10/2026, thay Client fork làm mặc định): Studio tải Spectra Client chính thức một lần (SHA256 pin), chạy với profile riêng, ẩn cửa sổ, điền form và bấm Connect qua DevTools của chính nó, tắt phím nóng toàn cục mặc định; controller của Studio (observer thứ hai, không bao giờ tạo trận) gửi lệnh thủ công và `config_update`. Đã kiểm live: tải + giải nén + hash khớp, GEP 315.3.5 Ready, Connected, 2 observer, tech pause, cấu hình đội đổi giữa trận, chặn "bom đã đặt" ngoài giao tranh, tắt công tắc dọn sạch process, không còn cửa sổ hiện. Chưa kiểm: trận thật nhiều round với controller (game_end xoá trận → controller chờ bí mật mới), plant/timeout trong combat, máy sạch hoàn toàn. Bước tiếp: liên hệ Overwolf đăng ký UID nếu muốn dùng collector riêng.

ValorantCollector (18/10/2026): `collector/hosts/valorant-collector` là collector nối thẳng ingest (GEP → ingest, `/status`, cổng lệnh), fork Client cũ `collector/hosts/valorant-collector/collector` đã gỡ khỏi cây mã. Collector chỉ nhận GEP thật khi app UID Overwolf của dự án được đăng ký (`collectorMode: gep`); mặc định vẫn là Spectra Client chính thức chạy ngầm.

Collector chạy được trên mọi máy (18/10/2026): mặc định ValorantCollector; GEP giả (UID chưa đăng ký) → tự chuyển sang Spectra Client chính thức ngầm. Đã kiểm live với `collectorMode: gep`: collector khởi động, phát hiện gói giả, dừng, Client chính thức Connected, controller nối (2 observer). Chưa kiểm sau khi UID Overwolf của dự án được đăng ký.

Collector nối trực tiếp (18/10/2026): ValorantCollector nối ingest ngay khi khởi động; GEP giả → trao bí mật trận cho Spectra Client chính thức ngầm, Client nối vào cùng trận, controller Studio nối (2 observer). Đã kiểm live. Dữ liệu game thật qua collector riêng vẫn cần app UID Overwolf đã đăng ký.

Chốt collector Valorant (18/10/2026): dùng Spectra Client chính thức chạy ngầm (`collector/hosts/valorant-collector`), tự tải một lần nếu thiếu, tự cấu hình, tắt phím nóng toàn cục, controller Studio gửi lệnh/cấu hình. Collector riêng đã dịch được lưu ở `collector/archive/valorant-collector` (không nhận GEP thật khi UID Overwolf chưa đăng ký); supervisor/server/UI đã dọn phần liên quan. Các mục "Collector Valorant tự dựng"/"Collector nối trực tiếp" phía trên là lịch sử, không còn đúng với runtime.

Cấu trúc Valorant (18/10/2026): toàn bộ Valorant gói thành host `collector/hosts/valorant-collector` (backend, overlay VAL26, client, runtime, tests, local/); dữ liệu cục bộ chuyển từ `data/valorant` sang `collector/hosts/valorant-collector/local`. Đã gỡ bản Spectra Frontend cũ, chế độ/khoá cấu hình cũ (collectorPath, collectorMode, frontendVariant), `set-collector`, script tải/import PowerShell cũ. Bản sao cũ `collector/src/League*` (không còn dùng) chuyển vào `collector/archive/legacy-src`. Các đường dẫn `modules/valorant`, `collector/valorant`, `collector/src/ValorantCollector` và `data/valorant` trong các mục phía trên là lịch sử.

Postgame Valorant (19/10/2026): trang Valorant → Postgame, overlay OBS `/valorant-postgame/preview.html` (bảng điểm) và `/valorant-postgame/mvp.html` (thẻ MVP) chạy ngay trong Studio, bố cục và theme mặc định lấy từ `Seotow/valorant-postgame-stats` (`public/valorant-postgame/SOURCE.md`). Hai nguồn: khung cuối Spectra (không cần key; thiếu ACS, damage, first kill, KAST, thời lượng nên hiện "—") và Henrik Dev (cần Riot ID + API key, lưu ở `collector/hosts/valorant-collector/local/postgame.json`). GEP Overwolf không có ACS, damage người khác hay thời lượng, nên chưa thể bỏ Henrik. Đã kiểm: 261 test, build, overlay dựng trên trình duyệt với dữ liệu giả. Chưa kiểm: Henrik với key thật, khung Spectra từ trận thật, first kill/thời lượng suy ra từ kill feed (chưa làm).

Player đẩy dữ liệu + cam (23/10/2026): bản player (`collector/hosts/valorant-collector/player/`) nhập code ngắn, chạy Spectra Client ngầm đẩy về ingest host qua cloudflared quick tunnel (`runtime/tunnel.mjs`, pin SHA256; `server/valorant-remote.ts`; API `/api/valorant/remote`; UI RemotePanel ở Phát sóng). Code = origin tunnel + group code + key (`shared/valorant-remote.ts`). Player cam qua vdo.ninja (bên thứ ba): cấu hình room id + danh sách player ở Cấu hình trận, gửi qua config_update. Đã kiểm: codec test, smoke test tunnel sinh URL trycloudflare thật và dừng sạch; build + 266 test. Chưa kiểm với player thật trong trận và cam thật trong overlay. Bỏ watermark Spectra góc phải: KHÔNG làm (giấy phép cần Spectra Plus); custom text tên giải gửi qua config_update nhưng backend giữ cổng supporter, không giả isSupporter.

Tap nội bộ Spectra Client + overlay native (24/10/2026): đọc thẳng binary 0.3.4 đã tải (không chạy) bằng `scripts/inspect/spectra-client.mjs` → `local/spectra-contract.json`; contract xác nhận GEP gameId 21640, kênh `obs_logon/obs_data/aux_logon/aux_data`, 28 DataType, key GEP đầy đủ (`observing`, `planted_location`, `shop`, `health`, `abilities`, `player_id`, `ui_team_order_*`), 10 IPC handler, toàn bộ đường dữ liệu nằm ở main process. Fuse `EnableNodeOptionsEnvironmentVariable` enabled nhưng ĐO THẬT cho thấy `NODE_OPTIONS=--require` không nạp trong app đóng gói; đường dùng được là `--inspect=<cổng>` + `Runtime.evaluate` gọi `tap.install()` rồi đóng inspector. Đã thêm `client/tap/tap.cjs` (vá `ConnectorService.sendToIngest/sendToIngestAux` và `GameEventsService.process*`, che `key`/`groupSecret`, đẩy NDJSON ra `\\.\pipe\riot-spectra-tap`), `client/tap/watch.mjs` (tự làm pipe server để xem frame; có `--max-mb`, mặc định 64 MB, vì chế độ `--raw` từng ghi 37 GB làm đầy ổ), và `overlay-host` (Win32 + WebView2, alpha từng pixel, xuyên chuột, topmost, zoom theo 1080, Ctrl+Alt+H). Đã kiểm LIVE: launcher spawn Client với inspector, `[tap] patched {connector:true, gep:true}`, pipe nối, `status/connector` 2s/frame với `connected:true`, groupCode RIOTLOCAL — tức tap chạy trên Client thật đang kết nối ingest. Chưa kiểm: frame `obs_data`/GEP trong trận (chưa vào custom game), build/run overlay host, nối `riot-tap` vào dataModel VAL26 (reducer của backend fork vẫn là nguồn chính). Gắn tap nay chịu được việc `process.mainModule` thiếu: `armScript` lấy `require` từ command-line API của Node inspector (`includeCommandLineAPI`) trước, rồi mới tới `process.mainModule.require`, và thử lại 3 lần (từng gặp lỗi `Cannot read properties of undefined (reading 'require')` khi main process chưa sẵn sàng — nếu không vá được thì dữ liệu aux vẫn chạy, chỉ mất phần quan sát trạng thái/Riot ID trên UI player). Không chạm process VALORANT.

Player thật + máu/kỹ năng (24/10/2026): máy player chạy Spectra Client chính thức ở chế độ **auxiliary** (không phải observer) trỏ về ingest của host qua cloudflared quick tunnel. Client tự thêm `:5100` khi URL thiếu cổng, nên mọi URL ingest được chuẩn hoá có cổng tường minh (`withIngestPort`, `:443` cho tunnel). Auxiliary không cần key: server chỉ kiểm kiểu gói, phiên bản client và `matchId` có tồn tại; `matchId` lấy từ GEP `match_start` của chính máy player nên phải vào trận rồi client mới đăng nhập được. Đã kiểm LIVE qua output handshake: `auxiliaryHealthSlots: 1`, `auxiliaryAbilitySlots: 1`, `rosterSlots/scoreboardSlots: 1/1`, `roundPhase: combat` — máu và kỹ năng của máy player đã vào tới output. 1/1 là mức tối đa vì lobby chỉ có một người; muốn chứng minh 10 slot phải có ≥2 người thật trong lobby.

Code 5 ký tự tự phân giải + UI player (24/10/2026): URL quick tunnel đổi mỗi lần chạy nên code ngắn không thể chứa địa chỉ. `runtime/rendezvous.mjs` sinh code 5 ký tự (bảng chữ bỏ `0 1 I L O`) và công bố `{origin, groupCode, camRoom}` lên điểm hẹn công khai (mặc định `ntfy.sh`, topic `riotovl-<code>`, đổi bằng `RIOT_OVERLAY_RENDEZVOUS`); player đọc lại đúng topic, nên host khởi động lại tunnel vẫn dùng được code cũ. Studio đăng code ngay khi tunnel connected và đăng lại mỗi ~4 phút (`server/valorant-remote.ts`), bảng Phát sóng hiện code 5 ký tự và giữ code dài base64 làm dự phòng; không dùng Studio thì có `npm run valorant:code`. Bản player có UI cục bộ: `npm run valorant:player` (`player/app.mjs` + `player/ui.mjs` + `player/ui/`, `http://127.0.0.1:5398`) cho nhập code, xem trạng thái kết nối/match id/số frame aux, tự đọc Riot ID từ GEP qua tap, và bật/tắt camera vdo.ninja (`player/cam.mjs` khớp `player/cam.mjs`↔`shared/valorant-remote.ts`, trim trước khi dựng `<Tên>_H_<Tag>`). Đã kiểm: công bố/phân giải code thật qua `ntfy.sh` (một tiến trình khác đọc lại đúng origin + room cam), 8 test mới cho code/payload/cam/join (`npm run test:valorant`), UI phục vụ trang tĩnh và API, join code sai trả đúng thông báo lỗi, `tsc --noEmit` sạch. `client/tap/watch.mjs` được thêm `--max-mb` (mặc định 64 MB) vì chế độ `--raw` từng ghi `tap.log` phình 37 GB làm đầy ổ C: và giết watcher; quá ngưỡng thì watcher ngừng in nhưng vẫn giữ pipe để tap không bị ngắt (đã kiểm bằng test bơm 1000 frame: dừng đúng ở ~ngưỡng, pipe còn sống). Chưa kiểm: chạy `app.mjs` trên máy player thật trong trận và hình cam thật hiện trong overlay (cần máy player bấm Bật camera); chưa kiểm ntfy khi mất mạng giữa trận.

