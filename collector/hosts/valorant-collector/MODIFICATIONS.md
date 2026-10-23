# Riot Overlay local fork

Imported 13/10/2026 from the exact revisions in `upstream.json`. Original code,
assets and copyright/license notices remain in each package. No remote fork,
push, release, upstream key bypass or watermark removal has been performed.

Local modifications:

- Added `runtime/` for independent Node supervisor, config, readiness, exclusive
  ownership, port checks, static frontend and collector executable startup.
- Backend binds only `127.0.0.1`, accepts configured ports and local browser
  origins, bounds Socket.IO messages, and confines data to authenticated session.
- HTTP status reports observer socket connectivity separately from process
  readiness. Added read-only `source_status` on output; last ingest time is not
  proof of per-field freshness or frame acquisition time.
- Disabled upstream raw replay persistence and default private payload logging.
  Preview creation is disabled by the supervisor, not used as live data.
- Frontend assets/config are served locally with endpoints from module config;
  cloud mapban/stats/testing routes are not exposed by this launcher. Bundled
  Fontsource fonts and OFL licenses replace runtime Google Fonts requests.
- Fixed browser timer types. Match and agent-select routes do not render initial
  fixture state before a source sample, on socket loss or after 5 seconds without
  ingest updates. HP gauge requires auxiliary health availability. This is a
  conservative gate, not a complete telemetry capability implementation.
- Added npm locks for backend/frontend; installation uses `--ignore-scripts`.
  Collector source is imported for future customization, not yet built/run.
  Running an existing upstream executable does not apply these source changes.
- Acquired official Client v0.3.4 archive (matching GitHub release SHA256),
  extracted unmodified into ignored data runtime; executable/ASAR identity in
  `collector-release.json`. Added config path setter with backup; key/ports stay
  intact. GUI is shown for operator interaction; backend/helpers remain hidden.
  The official binary uses upstream AppData profile/logs, not a project-isolated
  collector profile. Window/log version markers verified Observer + GEP 315.1.0
  Ready; no game telemetry or authenticated backend connection yet.
- Added lifecycle/Socket.IO and isolated browser tests. Synthetic test messages
  verify transport, not game coverage or correctness.

License inventory: Client has GPL-3.0 LICENSE/package metadata; Server/Frontend
have ELv2 LICENSE.md. Server package.json says GPL-3.0-only while its LICENSE.md
says ELv2; both upstream files are preserved. Do not assume the root ISC metadata
relicenses these components. Distribution/hosting and deeper source merging
must resolve the upstream license discrepancy first. Local implementation
preserves auth and watermark functionality.

Excluded import files: GitHub CI, Husky hooks and editor settings, recorded in
`upstream.json`. Upstream yarn locks remain as reference; npm locks govern these
local BE/FE builds. Do not enable `prepare` to install nested upstream Git hooks.

- 18/10/2026: thêm `collector/src/headless.ts` và các nhánh `headless` trong `src/main.ts`
  (profile riêng, ẩn cửa sổ/tray, bỏ update check, nuốt dialog, tự kết nối ingest loopback bằng key từ file).
  Chỉ hoạt động khi có biến môi trường; không đổi giao thức, không bỏ qua auth/watermark. Supervisor có
  `collectorMode: fork`. Fork đã build local (không dùng bản official 0.3.4).

- 18/10/2026: kênh điều khiển loopback trong Client fork (`headless.ts`: `startControlServer`, bearer token, chỉ
  `127.0.0.1`) cho các lệnh thủ công sẵn có của Spectra (spike planted, tech pause, timeout trái/phải, đổi KDA/credits,
  đổi trái-phải, đổi tấn công-thủ, toast) qua `HotkeyService.trigger` và `sendToIngest`; logo đội mặc định trỏ tới asset
  loopback của frontend. Studio gửi lệnh qua `POST /api/valorant/control`.
- 18/10/2026: import `frontend-val26` từ https://github.com/nobiiVAL/Spectra-Frontend-VAL26 @ `938cf70`
  (ELv2, fork của Spectra-Frontend; ghi nguồn tại `frontend-val26/SOURCE.md`). Chỉ chạy `npm install --ignore-scripts`
  (lock upstream lệch `node-vibrant`, `package-lock.json` được cập nhật) và build; mã nguồn FE chưa sửa. Runtime chọn
  `frontendVariant` (`val26` mặc định nếu đã build, `spectra` là bản fork cũ); không đổi/vô hiệu license hay watermark.

- 18/10/2026: backend fork thêm sự kiện `config_update` (`Match.handleConfigUpdate`, `Team.updateInfo`) để Studio đổi tên/mã/logo đội, tỉ số loạt trận,
  thông tin giải và tên thay thế giữa trận; chỉ đổi dữ liệu hiển thị, giới hạn kiểu và độ dài, không đụng auth, watermark hay license. Frontend module phục vụ
  `/uploads/<hash>.(png|jpg|webp)` từ `collector/hosts/valorant-collector/local/assets`. Client fork đọc `match-config.json` khi kết nối và khi nhận `apply_config`.

- 18/10/2026: chế độ mặc định `official`: Spectra Client chính thức nguyên vẹn (bản 0.3.4 pin SHA256) chạy ngầm, điều khiển bằng giao diện của chính nó (`runtime/official.mjs`) và
  controller của Studio (`server/valorant-controller.ts`). Không sửa binary/app.asar. Thư mục `collector/hosts/valorant-collector/collector` (fork Client có `headless.ts`) đã gỡ (còn trong lịch sử Git trước commit gỡ);
  collector riêng `collector/hosts/valorant-collector` (GPL-3.0-only, dịch lại phần observer) chỉ dùng khi dự án có app UID Overwolf đã đăng ký (`collectorMode: gep`).

- 18/10/2026: gỡ fork Client `collector/hosts/valorant-collector/collector` và mục tương ứng trong `upstream.json`; ValorantCollector thay thế bằng bản dịch tối thiểu phần observer (GEP → ingest, cổng lệnh, `/status`).

- 18/10/2026: `collectorMode` mặc định `gep` (ValorantCollector) với dự phòng tự động sang Client chính thức ngầm khi GEP là gói giả 0.0.0; collector chờ biết phiên bản GEP thật mới nối ingest.

- 18/10/2026: collector nối thẳng ingest ngay khi khởi động; khi GEP là gói giả, supervisor trao bí mật trận cho Client chính thức để nối lại đúng trận (thay cho việc chặn nối của bản trước). Controller của Studio đóng transport khi bị từ chối và dùng bí mật hợp lệ gần nhất.

- 18/10/2026: chốt dùng Spectra Client chính thức chạy ngầm làm collector (`collector/hosts/valorant-collector`, `release.json` thay `collector/hosts/valorant-collector/collector-release.json`). Collector riêng chuyển vào `collector/archive/valorant-collector`; gỡ chế độ `gep`, fallback tự động và cổng lệnh của collector khỏi supervisor/server/UI. Lệnh thủ công chỉ đi qua controller của Studio.

## config_update mở rộng (23/10/2026)
Fork backend `handleConfigUpdate` nhận thêm: `seriesMaps` (dải map CURRENT/NEXT ghi vào
`seriesInfo.mapInfo`; rỗng/tắt thì overlay tự ẩn), `playercams` (identifier + enabledPlayers cho
vdo.ninja), và `watermark` (customText = tên giải). Cổng Spectra Plus GIỮ NGUYÊN: không supporter
thì `spectraWatermark` luôn true và `customTextEnabled` bị ép false; không giả cờ `isSupporter`,
không bỏ watermark.

## Component tên giải (23/10/2026)
Thêm component riêng `components/top/auxiliary/tournament-name` hiện `tournamentInfo.name` NGAY BÊN
TRÁI logo Spectra (vị trí watermark cũ, `pos-x-1360`). KHÔNG đụng tới watermark/logo Spectra: giữ
nguyên trạng thái upstream, không gỡ/thay để vượt giấy phép.
