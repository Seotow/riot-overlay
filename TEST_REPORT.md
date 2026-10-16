# Kiểm chứng chốt phase UI/phòng thử — 11/10/2026

## Studio shadcn, 17/10/2026

Build đạt. Bộ unit có 213 test: 212 đạt, 1 bỏ qua, không lỗi.
System integration đạt trên phiên test riêng; nhánh capture legacy thiếu file
được bỏ qua, không dùng để khẳng định nguồn live. Browser QA Edge kiểm đủ
8 trang, lưu config, toggle leaderboard, phát/tạm dừng bản ghi, responsive
900px và OBS 1920×1080 nền trong suốt; không page error hoặc tràn ngang.
Ảnh và report: `.npm-cache/studio-shadcn-qa/`.

`npm audit` không báo lỗ hổng sau cập nhật dependency. Source overlay,
backend và shared contracts không đổi trong lần trùng tu Studio này.
Theme cá nhân và capture gốc giữ nguyên. Các giới hạn damage/EOG/native
stack đã ghi ở báo cáo bàn giao vẫn còn, không được coi là đã giải quyết.

## Mix icon + powerplay + simple + XP/resource — 17/10/2026

Build và193 unit đạt192pass/1skip/0fail. Native resourceType1 và0 giữ nguyên
qua adapter; helper không đoán mana khi thiếu type. Bản projection5 giữ1.525
mẫu/counters từ original, thêm numeric type. Simple4 fixture(camera/no-camera,
pending/complete) đạt:58px champion,29px spell/active, 2spell bằng cạnh champion,
2active bằng chiều cao champion,active3 khít strip29px. Fixture ghi nhãn rõ,
không phải telemetry live. Config logo/BO3/BO5/swap và OBS sync smoke vẫn đạt.

Trên bản ghi thật tại12:20: Baron170px/progress168px, Elder120px/progress118px
(trừ2px border), y-bottom chung,5px high, màu fill trùng icon;47%/86% tương ứng
1:25/2:09 còn lại. Elder không có tên team. SVG user Baron render được ở cả
OBS và HTML offline; grub cũ khôi phục; màu Elder RGB30,228,222. Catalog11 mục,
mask SVG/PNG không bị trắng/mất hình. Không sửa SVG gốc/theme local.

Style-only test trên CSS renderer thật: center pixel không đổi32/32/32 dù
viền có tint;4gradient mờ30% vào trong. Keyframes simple1590ms, hold749.9998ms;
full3840ms, hold2999.808ms. Không coi đây là sự kiện phát sinh từ bản ghi.
Player bars full/simple trên source thật đều10XPtrack nằm trênHP, cùng width,
XP3.59375px vớiHP/resource6px; LeeSin kindenergy,RGB200,217,75. Màu XP126,60,117.
Script `mixed-powerplay-smoke.mjs`, `minimal-layout-smoke.ts`; artifacts xem
PROJECT_STATUS. Chưa kiểm chứng live mới hay khẳng định giống95–98%.

## Objective PNG và portrait layers — 16/10/2026

Build đạt. Bộ188 unit sau regression CSS:187pass/1skip/0fail.
Test mới giữ hash/provenance11 PNG, tất cả7 rồng và3 quái hang Baron dùng
mask đúng, rồng chưa rõ loại có PNG chung thay SVG tự vẽ. Không sửa glyph
lane/inhibitor. Smoke Edge1920×1080 chạy capture thật16:02:26 trên server
test riêng, đo gold/level đều286px và goldTrack/xpTrack đều190px. Kiểm thử
style-only cue trên portrait chết: item filter none, opacity1; avatar vẫn
grayscale1, cue z5. Đây là kiểm tra layer, không tuyên bố cue đó phát sinh
thật trong source ở mốc được chụp. Toàn bộ smoke motion/control trước vẫn đạt.
Artifact `riot-objectives-sheet.png` và `motion-levels.png` ở visual-audit.
Đo cuối sau phản hồi đẩy số cấp: box số cách XP6px; đủ11PNG decode64×64.
Ảnh cuối `final-objectives-levels.png`, build đạt; không đổi bản ghi/theme.

## Progress lane thật — 16/10/2026

Build đạt;185 unit:184pass/1skip,0fail; collector integration đạt. Regression
mới kiểm tra buffpoints thay item.stats rỗng, zero thật khác null, mắt2055
không hoàn thành support và jungle dùng35 treat còn lại thay RoleBound count0.
Projection4 `2026-10-16T16-02-26-924Z` giữ1.525 mẫu. Browser smoke trên backend
cô lập xác minh aria-label và SVG quest-progress đúng số liệu từng mẫu:

| Game time | Progress của các quest chưa hoàn thành (%) | Đã hoàn thành |
| --- | --- | --- |
| 2:00 | 9,7,6,4,8,4,6,5,4,5 | 0 |
| 6:40 | 50,40,40,24,41,37,37,38,37,31 | 0 |
| 10:00 | 71,66,52,69,51,43,60,63,59 | 1 |
| 13:00 | 83,70,67,60,73,88,78 | 3 |

Không sửa native gốc/theme. Không coi support mua mắt là event quest thật.
Các báo cáo lịch sử7 event quest được thay bởi kết quả3 event trong projection4.

## Motion/control trên bản ghi thật — 16/10/2026

Build production đạt (warning Zod annotation và bundle >500kB không chặn).
`npm test`: 182 ca, 181 pass, 1 skip, 0 fail. System integration,
collector integration và transport integration đạt; chạy trên backend/theme
test riêng, không ghi đè `data/theme.json`.

`scripts/motion-ui-smoke.mjs` chạy Edge headless 1920×1080 với capture
`2026-10-16T14-22-34-808Z`, không tạo cue giả: upload chỉ Studio, OBS trong
suốt; chuyển camera/no-camera rộng 992/1346px; 7 cụm row không đè nhau;
Baron/Elder ẩn pit timer riêng và trở lại với motion; rune không đổi minimal;
gold và level bật đồng thời, mỗi bảng 10 người, 10 thanh XP; KT mở bảng 3 ô
không đếm giờ, CHAOS có đúng một nhà lính đang hồi; Soul panel/banner bật tắt
riêng không đổi layout; không pageerror. Kiểm tra animation-name/delay và
transition rank qua DOM thật, chưa phải so sánh video từng frame với mẫu Riot.

Artifacts: `.npm-cache/visual-audit/motion-{full-no-camera,minimal-no-camera,levels,runes,inhibitors}.png`.
XP fallback là suy ra từ tổng XP native + luật cấp SR, không phải nguồn trả
trực tiếp progress. Timer fallback có provenance rule-estimate. Không coi
thử nghiệm projection là xác nhận telemetry live mới.

### Native data và tác nhân killfeed ngoài player — 16/10/2026

Build đạt;173unit/172pass/1skip archive/0fail. Thêm regression cho CS0/tổngCS,
death status bit0, buff đúng/mini-Baron/red buff, quest slot8, sourceStats âm,
cached objective identity/dedup/seek, death khi chưa biết actor và killer là
lính/quái/sâu/Baron/trụ; static renderer kiểm white-mask assets.
test:collector và test:integration đạt (nhánh LB archive skip).

Đọc7331 native/1525observer/1586reference offline; giữ nguyên original, tạo derived
2026-10-16T13-43-33-081Z,1525sample. Có4elemental +1Elder,1Baron,1Herald,3sâu,
8trụ,46death và1Soul. Edge trên theme không cam thật sao chép vào backend cô lập:
CS10hàng không trống,4icon rồng (2đất), sourceStats trong viewer và Hóa Kỹ trắng
hạ Yasuo lúc06:45 đạt. Không dùng mock/cue để dựng event này. Ảnh lưu
.npm-cache/visual-audit/recorded-{all-data,dragon-kills-yasuo}.png.
Kiểm tra room play/pause/seek/speed và OBS đồng bộ vẫn đạt.

Không nâng damage lên available: archive damageDealtEvents đều0. Native không
có pit timer/level boundaries/quest-progress dùng được; các scalar thực có vẫn
hiện đầy đủ. Reference có GameEnd nhưng chưa trộn vào native-derived capture.

### Bàn phát lại bản ghi thật thay cue room — 16/10/2026

Build đạt,167unit/166pass/1skip(dataset đãarchive)/0fail. Metadata timeline
test cùng clock thực và gap expiry. Integration backend riêng đạt,nhánh LB
capture cũ skip vì đãarchive. Edge test mới dùng1525sample collector thật:
play/pause/seek/±10s/về đầu/0.25–4×,6widget khả dụng không phụ thuộcmarker,
đổiview không đổi position,OBS timer khớp khi pause,legacycue/mock DOM0,
không auto đổisource khi mởroom và không overflow1920/1280.
Phép đo không nâng capability/điền field nguồn thiếu thànhđãsupport.

### Chuẩn bị ghi500ms — 16/10/2026

Build/166unit đạt; test:collector-capture đạt gzip/marker/flush/privacy/playback;
test:collector đạt và thêm phép đo5 frame broadcast (mean350–650ms, target500).
Playback unit dùng sample cách500ms, kiểm clock/event khi seek. Reader collector
30.000 sample và512MB, LB giữ10.000. Ghi gap thực trong manifest, không fake tick.
Edge read-only trên4310 xác nhận không cam/w1346/10 hàng/không ảnh tham chiếu;
nguồn chưa có sample game. Backend hiện cũ cần restart để nhận500ms, recorder
có guard từ chối backend cũ. Chưa bắt đầu capture trận thật.

### Recorder toàn trận collector và bàn giao UI — 16/10/2026

165/165 unit đạt, build đạt; thêm2 unit privacy/playback. Fixture integration
`test:collector-capture` đạt native/fullRiot + app archive, giữ names/networkIDs,
lọc authsentinel, gzipflush,marker,operatorstop và normalizedplayback. Preload
chỉ trong test chặn game2999; không game/account thật. `test:collector` và
transport shared/OBSreadonly/reset đạt trên backend tạm. Không UI redesign.
Smoke5s trên phiên thật không còn gameAPI có0frame, không phải bằng chứng ghi
trọn trận. Recorder mới chưa thu trọn trận; fullMatch/fullTelemetryVerified vẫnfalse.
Reader hỗ trợ collector-sample trong observer-samples.ndjson, giữ limit512MB/
10.000frame. Fullnative và fullRiot được nén riêng để điều tra field chưa map.
Handoff, commands và các điểm chưa đo tại `docs/UI_COLLECTOR_HANDOFF.md`.

### SR spectator native không auth thật — 16/10/2026

Map11/noGameEnd/spectator verified; không producer4998 hoặc LB58869 trước trial.
Coldstart cache gốc qua host18814 không tài khoản104/104 valid,10hero/coverage10
cho HP/resource/currentGold/totalGold. Auth not-configured/feature0/sign0.
Đầu trận không biến thiên. Host18814 dừng; app chọn không tài khoản/owned18799
nối producer vừa tạo, đo45s432/432 valid, changedHeroes9/8/10/10; Studio53,
OBS53 và53 sample JSON giống nhau theo timestamp, coverage bốn field10/10.
Không mock/fixture, không thay credentials/DLL/guard; hash cache không đổi.
Evidence basic-fields-2026-10-16T10-44-29.354Z.json và
accountless-project-2026-10-16T10-46-16.037Z.json ở Collector/evidence/validation.
Chưa numeric parity với HUD/full telemetry/stability dài hạn. Không coi lượt
app reconnect là coldstart độc lập thứ hai. Native field values chỉ in đã lọc,
không lưu raw/identity/token vào evidence. Cập nhật mô tả UI theo kết quả mới.
Build đạt sau đổi mô tả. Edge headless1920×1080 kiểm nguồn SR thật10/10,
OBS transparent fraction0.83375048,0lỗiJS. Evidence browser
accountless-live-browser-2026-10-16T10-49-03.947Z.json, ảnh tại
`.npm-cache/collector-accountless-live/`; không fixture hoặc game/theme mutation.

### Collector không tài khoản trong app — 16/10/2026

Build và163/163 unit đạt, thêm ca external host không được nhận ở mode accountless.
Integration trên backend/theme/feed fixture riêng đạt: provider schema/UI mới,
switch/reselect, không kế thừa frame/player/count từ mode cũ, không attach host
ngoài để giả kết quả không auth. `tests/transport.integration.ts` chạy cùng
backend tạm đạt shared snapshots/kill propagation/read-only OBS/reset.
Edge headless1920×1080 đạt dropdown/accountless status/reselect/OBS alpha,
không lỗi JS; screenshot tại `.npm-cache/collector-project-qa/` là fixture.
Không native/game access hoặc thay theme cá nhân. Runtime HP/MP/vàng không
tài khoản vẫn chưa kiểm chứng; không suy từ test routing thành khả năng live.

### Cô lập account cho phép thử DLL cache — 16/10/2026

Build đạt; unit149/149 đạt khi cho phép HTTP/WS loopback. Trong sandbox,
147/149 đạt,2 lỗi localhost timeout/EACCES; lượt ngoài sandbox đã xác minh lại.
Test mới kiểm biến credential không kế thừa và không sửa môi trường cha.
Offline chạy host thật với env cô lập: auth-check `not-configured`, exit2,
hash cache đúng, không load native/truy cập game. Evidence:
`Collector/evidence/validation/accountless-offline-2026-10-16T02-30-07.021Z.json`.
Chưa chạy live không account: API2999 ECONNREFUSED, user chưa thể mở trận.
Không dùng kết quả offline làm bằng chứng HP/MP/vàng hay full parity.

### Basic fields trên replay map12 thật — 15/10/2026

148/148 unit test, build đạt; thêm2 case diagnostic projection roster1/4/8/10/16,
zero hợp lệ/null/range/resource kind/identity/freshness. Runtime coldstart29frame
và reconnect bắt buộc no-inject232frame đều valid,10hero. HP10/resource9/gold10/
totalGold10, lượt sau đo changedHeroes10/9/10/10. Không fixture/game API hybrid.
Reference Riot coverage0 ở bốn field; numeric semantics chưa độc lập xác minh.
Owned host18814 dừng, postcheck exact host và listener0, replay còn chạy1×map12.
Evidence `basic-fields-2026-10-15T15-30-24.462Z.json` và
`basic-fields-2026-10-15T15-32-41.100Z.json`. Không LB gốc/LCU/seek/pause/rawrecord.

### Validator HTTP/WS lab — 15/10/2026

`npm run test:collector-validation` đạt10 case: positive, consumer frame khác,
field bất đồng, clock skew, provider đổi, GameEnd, game absent, external host,
core field missing và LB listener busy (simulated). Dùng HTTP/WS cổng ngẫu nhiên,
không gọi2999/58869 hoặc DLL/auth/credentials; metadata ownership là fixture.
GET only/0 WScommand, cleanup từng server/socket/timer đạt. Evidence
`project-validator-lab-2026-10-14T18-38-19.108Z.json`, dataOrigin fixture.
Gate mới yêu cầu ít nhất một mẫu aligned với đầy đủ core comparisons10 người.
146 unit test/build đạt. CLI thật sau refactor dừng ở preflight-only/API game
absent, dataOrigin local-game-api; evidence `project-live-2026-10-14T18-38-59.804Z.json`.
Nhánh engine positive đã có fixture proof; positive game toàn tuyến vẫn chưa đo.

### Validator live project — 15/10/2026

146/146 unit test và build đạt. Ba test mới kiểm preflight spectator SR10/end/
clock/roster, comparison presence≠equality, skew/stale/mixed provenance không
so field; identity không vào report. TypeScript và format bản cuối đạt.
`npm run collector:validate` thật hiện trả nonzero/preflight-only/game API chưa
sẵn sàng, không backend/WS/launch/auth; evidence
`project-live-2026-10-14T18-28-32.333Z.json`. Chưa kiểm positive branch HTTP/WS/
game toàn tuyến của CLI. [Chi tiết](Collector/docs/LIVE-PROJECT-CHECK.vi.md).

### Native events và shared broadcast — 15/10/2026

143/143 unit test; targeted collector13/13 sau thêm wall-time expiry đạt.
Build và system integration (bao gồm transport integration) đạt. Collector
integration đạt một ChampionKill được cả Studio/OBS nhận đúng một lần dù native
frame mới thay thế frame event trước poll và HTTP diagnostics đọc xen giữa.
Có case baseline/seek/reconnect/invalid identity/future/late event, lookup
duplicate, queue expiry khi clock đứng; recording không raw identity. Mapping
dựa trên source và fixture; chưa có game event hoặc full history proof.
Xem `Collector/docs/NATIVE-EVENTS.vi.md`.
Edge headless1920×1080 đạt source selection/reselect, không pageerror và OBS
alpha; ảnh source/OBS đã xem tại `.npm-cache/collector-project-qa`. Fixture mới
có perk9 và item cooldown; không dùng ảnh đó làm native runtime proof.

### Collector ngọc/item cooldown — 15/10/2026

139/139 unit test, build đạt. Sau đổi join sang inventory đã validate,
targeted adapter9/9 và TypeScript được kiểm lại. `npm run test:collector` với
fixture mới đạt: backend đưa đủ perk9, keystone8005 và item cooldown3157 vào
ObserverFrame Studio/OBS, không raw perk stat/sentinel trong recording.
Đây là fixture và static mapping, chưa runtime proof. Xem
`Collector/docs/NATIVE-PROJECTION.vi.md`. Không đổi transport/UI hoặc chạy game.

### Launcher và provider Collector — 15/10/2026

- `npm test`: 137/137, không skip; build đạt. Integration ứng dụng cô lập đạt.
- `npm run test:collector`: shared Studio/OBS frames, recording đã lọc,
  switch/stop/reselect đạt. External fixture không launch native hoặc cấp game proof.
- Browser QA Edge 1920×1080: chọn/reselect nguồn, không browser error, OBS alpha
  đạt; đã xem `.npm-cache/collector-project-qa/{sources,obs}-1920.png`.
- Managed build/lab: 6 check đạt, lifecycle 16/16, auth-flow 5/5.
  Evidence `managed-lab-2026-10-14T17-38-53-841Z-690fcfd2963d44ce9b3b4c260ecdfdba`.
- Host thật idle: owned start/health HTTP200, unauthenticated stop403, stop và
  đóng listener đạt cả sau chuyển env. Evidence
  `Collector/evidence/validation/owned-runtime-2026-10-14T17-48-40.942Z.json`.
- Launcher thử thoát không cleanup: host thật idle tự đóng listener, đạt.
  Evidence `Collector/evidence/validation/parent-lifetime-2026-10-14T17-51-30.518Z.json`.
- Chưa thử cleanup khi có game và game toàn tuyến. API2999 cuối phiên ECONNREFUSED,
  người dùng chưa thể bật game. Fixture/idle/lab không thay đối chiếu live.

### SR live10 spectator / adapter — 15/10/2026

Coldstart87frame/9sample vàno-inject229frame/24sample: fieldroster/team/champ/
level/KDAmatched10,inventory0 doaux7/8,CS0–2/10khớp;2hostwatchdogstop. Saufix
standarditemsfilter vàWSApplicationStopping:212frame/22sample/0invalid,
level/K/D/A/items mỗi220/220 matchedRiot,clockskewmax0.1261421s. CSnull; HP/
gold/cooldowncoverage10/resource8 khôngfullcorrectnessproof. Finalexit0/
forcedfalse/postcheck0host,game map11giữchạy;khôngpause/seek/LCU/rawrecord.
Managedbuild6check/lifecycle16/authflow5đạt;rootbuildvà135/135unitđạt;
backendintegrationcôlập chạyriêng, khôngthemeproduction. Detail/source/evidence
ởCollector/docs/SR-LIVE-VALIDATION.vi.md. Không signednativechallenge hoặc
lane/event/objective/endgame/fullFreeparity proof.

### Collector field matrix / adapter offline — 14/10/2026

`npm run build` đạt; `npm test`134/134đạt, khôngskip.6testmới dùng fixturetổnghợp
theonative serializer: projectionallowlist/nosecret,zero/missing/unsupported,
timestamp/source/synthetic/rosterreject,stableorder/session/seek,duplicate/stale/
statusloss vàisolatedWSsocketclose. Teamgold/kills chỉsumđủ5validfield,thiếu→null.
Backend `npm run test:integration`đạt, gồmtransport.integration sharedsnapshots/
killpropagation/read-onlyOBS/reset,theme/provider/capture ởbackend/theme côlập.
Khôngchạy game/collector/auth hoặc ghiđètheme cá nhân choadaptertest.

SandboxVite realpathEPERM vàloopbackconnectiontimeout:rerun approvedhost đạt,
khôngđổicho game/source. TypeScript includeCollector/adapter; contractsource
league-collector/currentGoldoptional backwardscompatible. UI/theme/baseline
assetkhôngđổi. Chưarealreplayadaptermapping/teamroles/cooldownsemantics/parity.
Matrix vàgiớihạn: Collector/docs/FIELD-MATRIX.vi.md, ADAPTER.vi.md.

### LeagueCollector authenticated runtime / reconnect — 14/10/2026

LoginSRP thànhcông/subscription-unavailable/features0. DLLgốcboundedtrial có
game-started/counter≥84snapshot/9sample đủ10hero; no-injectreconnectcounter≥228/
24sample,10hero/maxHP/totalGold/spellReadyAtdương,scalarvalues thayđổi. Map12,
patch16.20.824.8524; haihostdừngsạch/exit0/postcheck0host. LBlistener58869closed,
nativeproducer4998 còn sauhoststop;replay vẫnchạy. Không signedchallenge:
signingAttempts/signedResponses/requestedFeatureCount0,không nativegrantproof.
KhôngfullFree/map11/fieldsemanticcorrectness hoặc C++replacementproof.
Evidence ở Collector/evidence/validation authenticated-native15-04-58 và
authenticated-reconnect15-07-57; chi tiết Collector/docs/AUTHENTICATED-RUNTIME.vi.md.
Offline regression: build6checks/lifecycle16/authflow5đạt, gồmnoUpdate guard
khôngimplicitdownload khiversionmismatch. DLLhashgốc/layout/syntaxđạt.

### Collector account/native auth flow offline — 14/10/2026

Build harness6check đạt; lifecycle16/16 và auth-flow4/4. Auth-flow gọi managed
RequestFeatures thực: Empty trảtrue/callback0 dù clientdisconnected; nonempty
với stalehandshake trảfalse. Không provider/game/privateIPC/nativeauth; không
gán grant. Các sửa chỉ test entry và account-only diagnostic, không vendor/DLL.
Evidence: `Collector/evidence/validation/managed-lab-2026-10-14T14-52-28-761Z-f7a2f7336e4c436da68a2a2e212cc177/`.
Account-only check trảnot-configured vì thiếuconfig; khôngauthenticatedrequest.
ApprovedGET2999 ECONNREFUSED, trước đó sandbox EACCES. Layout/nativehash/syntax
đạt. Chưa chứng minh email/password đủ nativeauthorization hoặc telemetry.

### Collector layout và managed lab — 14/10/2026

Sau di chuyển source/scripts/runtime/evidence vào cấu trúc Collector mới:
build offline, doctor, serializer và lifecycle đạt5check; lifecycle16/16,
gameAccessedfalse/telemetryFields0. Không chạy native/game/auth/LCU hoặc app UI.
Evidence: `Collector/evidence/validation/managed-lab-2026-10-14T14-39-47-357Z-c9c90bbf8edf4cd3bd4a2b1752fcd6e3/`.
JS/PS syntax đạt; layout verifier kiểm16link local, source/runtime/one-shot marker
và native SHA-256 đạt. Bản cloud và raw evidence lịch sử giữ nguyên. ZIP source
trùng hash đã xóa, canonical còn trong archive/cloud-export/packages. Không xem
lab hoặc layout check là bằng chứng có native telemetry/parity.

### Spectra handshake thật tại Main Menu — 13/10/2026

Backend trước đó không lắng nghe; mở lại BE/FE riêng thì Client Connected.
Health xác nhận 1 observer authenticated; Socket.IO output đúng group RIOTLOCAL
trả snapshot isRunning=false/LOBBY và0 slot, khớp menu. Probe allowlist không
xuất raw state/danh tính/key/secret. Đây là handshake thật, chưa là telemetry
custom/10 người. Không chạy synthetic command hoặc đổi trận/theme LoL.

### Riot API config / adapter — 13/10/2026

Build đạt;116/116 tests đạt. Unit Riot dùng payload/header tổng hợp (không
production key): Match/Timeline normalization, damage champions không nhầm
totalDamage, role fallback, counter/dragon split, timeline gap, wrong ID/roster,
Standard/RSO auth, no secret echo,429 Retry-After và clear pending.
Integration local riêng đạt credential Host/Origin/method/invalid-input guards,
RAM status không secret, publish không candidate bị từ chối; full load/stage/
publish/snapshot và WS source-forge rejection đạt với fetch fixture chỉ trong
process test (`tests/fixtures/riot-api-preload.ts`), không gọi Riot thật.
EdgeQA1920/1280 đạt nhập/xóa ô password, khônglocalStorage,IDvalidation,
staging same renderer không đổi OBS, browser-only fake candidate không phát
được lên backend. Postgame sample regression đạt. Không có authenticated Riot
gameplay request thật, không chứng minh Standard truy cập custom/Elder/horde.

### Official Spectra Client startup — 13/10/2026

Installer cũ hash khớp release v0.3.4. Gói official 90.947.888 byte đã kiểm tra
SHA256, giải nén local không chạy installer/patch ASAR. Launcher gọi executable
Observer thật, cửa sổ `Ready (GEP: 315.1.0, Spectra: 0.3.4)`; marker log đã lọc
xác nhận Observer/GEP ready, không thấy feature/init error trong đoạn khảo sát.
Ctrl+C dừng cây process và khởi động lại thành công, GUI hiện cho operator.
Backend/FE ready, observer socket chưa connected, 0 match; không game telemetry.

6/6 module tests đạt (thêm config path setter giữ key/port/group và backup),
root build +109/109 tests đạt. Không sửa theme/provider/renderer LoL. Runtime
official 0.3.4 khác source collector fork 0.3.3, chưa build collector fork.
Chi tiết/provenance tại `modules/valorant/collector-release.json` và runbook.

### Postgame UI mẫu — 13/10/2026

Build đạt; 109/109 unit/regression tests đạt. Integration command postgame,
validation chỉ nhận source sample và xóa bộ mẫu đạt. Browser Edge trực tiếp
1920×1080, 1280×720; Studio 1280×800 đạt: font/icon, 10 người/10 bans, iframe
đồng bộ với OBS, đổi đội thắng, thiếu số liệu/ngắt graph, import invalid không
ghi đè, import/export hợp lệ, trạng thái chờ và body OBS trong suốt. Đã sửa
cột damage bị ép vào ô role và margin footer thừa; có assertion đo kích thước.
Không chạy LoL/LB, không kiểm chứng dữ liệu postgame thật. QA dùng theme riêng.
Xem `docs/POSTGAME_UI_REVIEW.md`, ảnh `.npm-cache/visual-audit/postgame-sample-v2.png`.

### Module Valorant / isolation — 13/10/2026

BE fork tsc + FE Angular production build đạt. 5/5 test module riêng đạt:
config/port isolation, init không ghi đè key/config, conflict không kill process
khác, backend failure/restart, auth/Socket.IO logon/snapshot/reconnect/source
loss, HTTP method/Host guard, raw replay disabled và owned-tree shutdown.
Test dùng cổng/config/key riêng và synthetic observer, không phải game data.

Browser Edge headless/profile riêng 1920×1080 đạt status và Angular overlay/
agent-select routes, không render initial fixture, screenshot OBS alpha=0 khi
thiếu nguồn, không external requests hoặc JS errors. Đã xem screenshot status;
chưa audit HUD có dữ liệu thật/font tất cả widget. CLI start/Ctrl+C thực tế
đóng owner và trả port. Root build/104 unit tests và isolated LoL integration
đạt. Không đổi theme/trận người dùng. Chưa có collector executable/game test.
Chi tiết/lệnh tại `docs/VALORANT_MODULE.md`.

### Hiệu chỉnh tone bằng ảnh — 13/10/2026

Build/104 test và production browser QA đạt, kiểm tra slider60%→save/OBS,
khôi phục mức mới84%, hai layout/minimal/rank/rune và alpha panel dưới86%.
Đo4 ảnh mẫu/2 render trên cùng backdrop: scoreboard median32→14 (mẫu10–22),
player39→20 (mẫu15–33); tọa độ/phương pháp tại `INGAME_PANEL_CALIBRATION.md`
trong docs. Màu8,12,14/base84%, main92%, sub~74% thay bản72% ở mốc cũ.

### Nền in-game / opacity — 12/10/2026

Build và104/104 test đạt. Theme opacity có bounds, old-theme compatibility và
JSON roundtrip; browser dùng keyboard điều chỉnh60%→Save→OBS, sau đó72% cho
ảnh kiểm tra. Đo alpha screenshot thật, header mặc định199/255 và panel không
bị chồng opacity gần kín; gold/level/rune/cả2 layout/minimal/OBS đồng bộ đạt.
Full visual variants timer/buff/inhibitor/quest/Soul đạt. Preview composited từ
crop game-only là minh họa transparency, không thêm nền vào renderer và không
dùng để khẳng định giống95–98% hoặc dữ liệu live. Cache artifact riêng.

### Polish simple / centered art — 12/10/2026

Build/103 test đạt, đủ171 centered WebP local và ảnh cũ đều có file. Edge QA
20 lượt/switch hai layout, xác nhận simple dùng centered-art và tải đủ ảnh,
font/OBS/iframe/export/import/1280px và alpha toàn cam1120×690 đạt. Đã xem ảnh
render độc lập `draft-simple-polished.png`; không dùng footage/reference để
khẳng định crop. Source/provenance tại `docs/DRAFT_VISUAL_SOURCES.md`.

### Layout draft simple — 12/10/2026

Build và103/103 test không skip đạt. Theme optional enum giữ import cũ và từ chối
giá trị lạ. Edge QA chọn layout thật, preview/OBS đồng bộ, đo header1920×150,
picks400×690 hai bên và bans720×130 dưới; toàn bộ10 ô rộng400 kể cả hover.
Kiểm tra alpha vùng cam giữa bằng screenshot trong suốt đạt, switch lại layout
cũ y790 đạt; luồng20 lượt, export/import và Studio1280px vẫn đạt.

### Cấm chọn production — 12/10/2026

Build đạt;103/103 unit/regression không skip; transport integration riêng đạt.
Draft schema 20 lượt, duplicate guard, undo/skip/swap, missing slots, timer và
command không sửa in-game; đủ171 icon/portrait local được kiểm tra. Edge QA
`draft-smoke.mjs` dùng thao tác thật20 lượt, hover/lock, hết lượt, undo/skip/swap,
timer, export/import file, shared preview/OBS, asset/font, đúng vùng1920×1080,
transparent/không control/reference và Studio1280px. Production smoke in-game
đạt sau draft; sửa preview widget bị giữ scene draft. Mẫu/UI nhập tay không
chứng minh champ-select live. Chưa chạy test live toàn trận mới hoặc đo95–98%.

### Phản hồi lane quest theo layout — 12/10/2026

Build, 99/99 test và production browser QA đạt. Có cam: quest trên scoreboard, reward thay secondary rune khi hoàn thành, không có quest cell riêng. Không cam: 10 quest cell hình tròn (pending/reward/unavailable), giữ secondary rune và không có scoreboard quest. Kiểm tra đổi layout qua Save, đo border-radius 50%, xem screenshot cả hai bản trên snapshot thật. Phần này thay kết luận quest row áp dụng chung ở mốc dưới.

### UI lane quest / layout chính — 12/10/2026

Build,99/99 test (0 skip), integration cô lập đạt. Quest chuyển sang ô giữa inventory/rune trong từng hàng, progress nguồn giữ nguyên, reward không chiếm nhánh phụ; regression xác nhận progress50%, secondary tree trước/sau completion và10 slot. Config mới no-camera, theme cũ không ép migration. Production browser QA đo HP200px, bảng1346px/trục gold927, arrow cùng màu đặt ngoài cạnh và bố cục cam/minimal vẫn trở lại992px. Stack mới chỉ khảo sát nguồn, chưa có widget; chi tiết `docs/LB_STACKS_EVIDENCE.md`.

Browser regression bổ sung đạt trên backend/theme riêng: cả 5 quest completion, các biến thể objective/Soul/buff/inhibitor, rune slots, cooldown và leaderboard. `visual-capture.mjs` chọn bản ghi đầy đủ thay vì kế thừa capture ngắn của bài test khác. `phase-smoke.mjs` đạt draft/in-game/postgame baseline, assets/font, OBS trong suốt/không controls hoặc ảnh tham chiếu, 5 trang Studio và config ở 1280px. Các cue trong phòng thử chỉ chứng minh UI; không xác nhận telemetry live còn thiếu.

## Bổ sung vận hành — 12/10/2026

Build đạt; **97/97 test, 0 skip**. Integration riêng 4311 kiểm tra broadcast view không sửa dữ liệu và theme điểm/logo >64KB lưu đúng. Edge headless trên backend riêng với theme cache: config page không preview, bấm Save đồng bộ tên/điểm/logo tới OBS và iframe, tối giản/bảng đầy đủ đồng bộ; draft/postgame disabled, 6 control/5 preview nhỏ, rộng 1920/1280 không overflow. Đã mở recording thật (không cue), phát vàng/cấp/rune; preview nhỏ cùng data và 10 level. Không có lỗi JS.

Script bổ sung: `scripts/production-smoke.mjs`, cần `OVERLAY_VISUAL_URL` loopback riêng khác 4310 và `OVERLAY_BROWSER_PACKAGES` có Playwright. Screenshot ignored `production-desk.png`/`production-data.png`. Chưa test trận spectator live mới; không khẳng định đủ telemetry ngoài feed thực có. README/runbook và PROJECT_STATUS cập nhật ranh giới capture/playback. Kết luận 94 test phía dưới là mốc chốt ngày 11/10.

## Kết luận hiện hành

Chốt phần LoL đã có dữ liệu và công cụ rehearsal, không tuyên bố toàn bộ
production/collector hoàn tất hoặc đạt 95–98% giống UI. **94/94 unit/regression
đạt, 0 skip trên máy hiện tại; build đạt; integration và browser QA đạt.**
REA/LB/Valorant feasibility giữ nguyên để tiếp tục riêng.

| Lệnh | Kết quả/phạm vi |
| --- | --- |
| `npm test` | 94 đạt: mock/schema, collector/privacy, dedup/session/seek, playback bản ghi thật, objective/buff/timer, quest/rune/spell, UI missing/stale, asset/font/hash |
| `npm run build` | TypeScript + Vite đạt; Zod annotation warning và bundle JS 536,29 kB (gzip 151,30 kB) còn tồn tại, không lỗi build |
| `npm run test:integration` | Backend 4311/theme tạm: HTTP/probe, Host/origin/method guard, WebSocket/OBS read-only, scene/mock/validation/theme persistence, provider, capture load/pause/4×/seek, rehearsal/variants không sửa telemetry |
| `node scripts/visual-capture.mjs` | Edge 1920×1080/DPR1/backend 4391: gold/level/rune/minimal/CD, 21 timer combinations, 7 DragonKill, 6 Soul, 3 buff modes, trụ đầu/thường, inhibitor từng đội, 5 quest |
| `node scripts/phase-smoke.mjs` | Draft/in-game/postgame fixture: asset/font đủ, OBS trong suốt/no control/reference; 5 module Studio và theme page 1280px không overflow ngang |
| `git diff --check` | Không lỗi whitespace; LF/CRLF warning không phải lỗi source |

Lượt integration sandbox đầu không khởi động kịp; chạy lại được duyệt ngoài
sandbox đạt. Không kill process cổng 4312 đang bận. QA dùng backend 4391 do
tác vụ tạo, không đổi phiên/theme 4310. Integration từ chối cổng 4311 bận
trước khi gửi lệnh. Production sửa MIME WebP/OTF/TTF và reject WS Host lạ;
integration xác minh response asset và chặn path traversal.

Đã thử listener tạm trên 4311: integration từ chối đúng trước khi gửi lệnh.
`npm ls --depth=0` không có dependency thiếu; máy còn hai fontsource package
extraneous từ phiên cũ, source/runtime không còn import chúng. Không commit
node_modules hoặc tự sửa lockfile để hợp thức hóa dependency không dùng.

README/setup/architecture/roadmap/visual docs và UI đồng bộ với source.
Soul phân biệt Dragon Slayer/Dragon Soul, chỉ số/điều kiện/cooldown và tooltip
scaling: docs/DRAGON_SOUL_RULES.md. Quest đối chiếu Riot 26.1/26.9, MID hiện
bonus AD/AP chứ không phải empowered recall cũ: docs/ROLE_QUEST_COPY.md.
Preview biến thể có nhãn giả lập UI, không sửa capture.

Artifact tại `.npm-cache/visual-audit/`: measurements, variant PNG và
`phase-baseline-{draft,ingame,postgame}.png`. Hai dòng cả sáu Soul được đo
không overflow. Browser QA cần Playwright/sharp/Edge, đặt
`OVERLAY_BROWSER_PACKAGES` và `OVERLAY_VISUAL_URL` trỏ backend test loopback;
phase-smoke từ chối cổng vận hành 4310. Máy clone thiếu capture local báo
skip regression thật, không thay bằng fixture rồi gọi là bằng chứng live.

### Còn hoãn / chưa chứng minh

- Damage/combat tự động, activation Zhonya, end-game/champ-select live và
  transition production đầy đủ.
- Elder buff/inhibitor xanh thiếu capture live; preview không thay thế mẫu.
- Power Play fallback +1500 rồi biến động chênh vàng ròng, không field trực
  tiếp; có thể lệch nếu bỏ lỡ snapshot lúc nhận buff. Buff player lấy nguồn.
- ItemCompleted allowlist chưa bao phủ mọi món/mua-bán; assets 16.20.1 không
  tự chứng minh trùng patch game; chưa đo toàn UI 95–98% hoặc latency video.
- Collector headless thay LB/Valorant runtime chưa có. Giữ capture/theme/
  credentials/binary nghiên cứu ngoài Git; xác minh quyền assets trước publish.

## Báo cáo các lượt triển khai đầu (lịch sử, không phải trạng thái hiện hành)

## Phạm vi

Ưu tiên phần đã có dữ liệu xác minh. Tạm hoãn mốc chưa có telemetry: damage/combat tự động, activation Zhonya, end-game và Baron Power Play gold delta. Không tuyên bố đã hoàn thành mọi đồ họa giải đấu.

## Bộ test tái sử dụng

Kết quả lần chạy này: **63/63 unit/regression test đạt, 0 skip; build đạt; test tích hợp đạt**. Các warning build chỉ là annotation tree-shaking trong dependency Zod, không lỗi TypeScript/build.

Cập nhật Phòng thử: **64/64 đạt, 0 skip; build và integration đạt**. Regression/integration chạy mọi nút rehearsal khả dụng qua bản ghi thật, kiểm tra cue chỉ phát một lần và mang nhãn manual-rehearsal; damage bị từ chối, rune chỉ khả dụng đủ perk IDs. Thêm renderer test cho leaderboard gold/Power Play missing/stale. Build có thêm cảnh báo bundle frontend khoảng 502 kB (không chặn build); chưa tối ưu chia bundle ở mốc này.

| Lệnh | Phạm vi |
| --- | --- |
| `npm test` | Reducer và mọi control mock; schema/validation; asset/font local; collector/cache/loss; adapter/provenance/privacy; session/epoch/dedup/seek; Riot objective; LB objective/micro-event/cooldown/inhibitor; renderer/missing/stale; playback; capture marker/analyzer; regression bản ghi thật local |
| `npm run build` | TypeScript toàn project và frontend production |
| `npm run test:integration` | Backend cô lập 4311: HTTP/report/recording/6 probes; origin/method guard; WebSocket Studio/OBS đồng bộ và chỉ đọc; đổi scene; tất cả control mock; lệnh/theme sai; lưu theme tạm/reset; provider; nạp bản ghi lớn/pause/4×/seek |

Test tích hợp không ghi vào `data/theme.json`. Theme test nằm trong thư mục tạm và được xóa khi test kết thúc. Không đổi game/client/LB. Nếu máy không có capture local, test regression thật báo skip rõ ràng; không thay bằng fixture rồi coi là đã kiểm chứng thật.

## Bản ghi thật

`lb-2026-10-11T09-07-37-947Z`: khoảng 194 MB, 2.304 state frame raw, parser nhận 2.303 frame trận và bỏ một bootstrap trống. Regression validate mọi sample theo contract, xác nhận level/item, bốn rồng và một Soul, trụ, Baron, inhibitor phá/hồi sinh, GA cooldown 300 giây. Seek không phát lại lịch sử; pause đứng clock; 4× tiến clock; kết thúc bản ghi không biến thành payload end-game. Frame cuối 21:37.696, không suy ra mốc người dùng 22:13.

## Kiểm tra giao diện

Kiểm tra Studio/OBS bằng bản ghi thật, không bật demo/ảnh tham chiếu. Canvas CSS 1920×1080; bảng đầy đủ và tối giản có đủ 10 slot, icon tải đủ, body/canvas trong suốt. Cửa sổ in-app browser hiện thu nhỏ 662×372 dù yêu cầu viewport 1920×1080; chưa có ảnh xuất OBS kích thước 1:1, chưa coi đây là pixel-perfect QA.

Các lỗi đã sửa: timer hồi sinh đứng giữa frame; timer nhà lính có thể hiện `0:60`; timer item phải khớp cả slot và ID; ultimate chưa học không được báo ready chỉ vì cooldown zero; Elder không tính vào bốn rồng Soul. Layout/animation chưa được xác nhận pixel-perfect so với tất cả ảnh production.

## Giới hạn

Test không đảm bảo LB/client luôn hoạt động trên trận mới. Live asset 16.18.1 chưa xác minh trùng patch capture 16.20.0. ItemCompleted là inventory edge trong allowlist item lớn, không xác nhận mọi món hay nguồn mua/bán riêng. Buff Baron không suy ra Power Play. Timer objective trong Phòng Tập có thể bị công cụ spawn làm lệch; ưu tiên event. Champ-select thật và end-game thật vẫn cần phiên kiểm chứng riêng.
# Kiểm chứng bổ sung — 17/10/2026: nickname, XP và rune

- `npm run build`: đạt (Vite cảnh báo chunk lớn và chú thích dependency,
  không lỗi build).
- `npm test`:199 test,198 đạt,1skip; test skipped cần phiên capture fixture
  tùy chọn cũ, không coi là live verification.
- `npx tsx tests/collector-project.integration.ts`: đạt transport shared
  Studio/OBS, read-only renderer, switch/stop/reselect, accountless isolation.
- `scripts/verify-name-ranking-ui.mjs`, backend QA riêng4393/theme riêng:
 1920×1080,10 XP rows, nickname/percent/level box, màu phụ đo ảnh, cả2 layout
  rune tạm thay bảng tuyển thủ/khôi phục đúng layout.10 card đủ9 perk và
  last icon trong card/screen; màu tên đội khớp main color. Không pageerror.
- Quest dùng mốc thật đầu tiên trong capture (572.5687s), phát qua mốc để
  thấy React cue: black .94, portrait-back/portrait-copy, simple ẩn.
  Dragon preview giữ strip riêng, không generic live-event-banner; dữ liệu
  gốc không đổi. Preview không phải bằng chứng telemetry mới.
- Nickname có/không tag, Unicode, fallback,10 override roundtrip/side swap,
  custom colors không bị migration ghi đè và logo rune có/không: unit đạt.
- Report/ảnh: `.npm-cache/name-ranking-qa/`; data audit:
  `.npm-cache/data-audit/native-stacks-damage.json`. Archive gốc giữ nguyên,
  projection6 riêng. Theme local hash không đổi (xem PROJECT_STATUS).
- Không xác nhận damage realtime/postgame, stack UI hay EOG10 player mới;
  không có trận live mới trong lượt này.

# Stack tướng và item — 17/10/2026

Build đạt; `npm test`:208 tests,207pass/1skip. Collector integration đạt.
`scripts/verify-stack-ui.mjs`:4 variants camera/no-camera × full/simple,
1920×1080. Kiểm direct data Smolder32/Veigar77/Tear330; X của các cột
champion/rune/HP trong cùng đội lệch<1px; badge26px chứa trong ultimate40px;
số trắng, không nền chữ; assets hợp lệ, không pageerror. Ảnh/report
`.npm-cache/stack-ui-qa/`. QA dùng loadGeneration để đợi reload cùngcapture,
không coi id trùng là đã nạp xong. Data gốc/theme không sửa.

Unit có zero observed khác missing placeholder0, exact buff/không đoán,
11 icon hashes/quy tắc user (Veigarpassive), LB direct stacksData11tướng,
priority stack hơn rune/quest, Tearcharges khác count, wardammo, supportstock,
auxiliaryslot8 và item trùngslot. Fixture3008 không phải liveverification.
Không xác minh native9tướng còn lại hoặc giày Phàm Ăn bằngHUD mới.

## Rà soát bàn giao cuối — 17/10/2026

Build đạt;209unit tests208pass/1skip sau khi thêm testquantity Live Client.
System integration đạt (legacy capture branch skip thiếufile); transport
integration trênQA riêng4393 đạt, không tác động mock/config app chính.
Browser rerun nickname/XP/rune/quest/banner và4 stack variants: badge26px,
không tràn, cột đồngX, dữ liệu32/77/330 và số trắng nềntransparent. Không
pageerror. Báo cáo tổng hợp `docs/PHASE_HANDOFF_2026-10-17.md` ghi rõ phần
chưa có native telemetry/HUD/EOG damage, không gộp vào trạng thái đạt.

