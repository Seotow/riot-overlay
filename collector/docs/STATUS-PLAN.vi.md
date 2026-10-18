# Status và plan tiếp tục — 14/10/2026

## HP/MP/vàng trên replay map12 — 15/10/2026

Đã có native data thật qua host riêng, không LB gốc: HP10/resource9/currentGold10/
totalGold10,232frame reconnect no-inject và tất cả hero có field đều có biến thiên.
Riot reference coverage0 ở bốn field nên chưa numeric parity. Không cần SR để
tiếp tục basic fields. [Bằng chứng và lệnh](BASIC-FIELDS.vi.md). Build148unit đạt,
host18814 dừng sạch/postcheck0, replay còn chạy. Full goal vẫn chưa hoàn thành.

## Positive validator lab và completion audit — 15/10/2026

Engine positive HTTP/WS10 case đạt qua `npm run test:collector-validation`;
CLI thật vẫn game API absent, không host/auth. Core telemetry gate không cho
clock+roster thiếu fields trả success. Build146unit đạt. Xem
[completion audit](COMPLETION-AUDIT.vi.md): mục tiêu giữ đầy đủ, chưa hoàn thành,
phần tiếp theo cần game thật thay vì lặp fixture. Không có test/runtime đang chờ.

## Validator toàn tuyến — 15/10/2026

Đã thêm [live project check](LIVE-PROJECT-CHECK.vi.md), lệnh
`npm run collector:validate`, pure preflight/parity tests và shared consumer
measurement. 146 test/build đạt; CLI thật dừng ở game API unavailable trước
backend/host. Positive branch chưa đo, không nâng unit/negative preflight thành
proof trận thật. Giữ mục tiêu full integration và các field còn thiếu.

## Native event delivery — 15/10/2026

Typed kill/turret/inhibitor/Ace record đã map và queue giữa native100ms/backend
750ms đã triển khai, có diagnostics chỉ đọc và expiry game/wall5s. 143 test,
build, transport/system integration và shared collector/browser fixture đạt.
Source/hash/giới hạn tại [native events](NATIVE-EVENTS.vi.md). Chưa event game
proof và chưa counter/timer objective đầy đủ; không đổi entitlement/guard.

## Mapping bổ sung — 15/10/2026

Adapter đã thêm perk ID/keystone và item cooldown dựa trên source/catalog:
[evidence mapping](NATIVE-PROJECTION.vi.md). 139 unit test/build và integration
fixture đạt; targeted adapter9/9 đạt sau sửa join inventory. Chưa game proof;
ngọc/cooldown có code projection không đồng nghĩa đã có field runtime hợp lệ.
Giữ mục tiêu toàn tuyến thật và full telemetry, không chốt parity từ fixture.

## Mốc mới nhất — tích hợp project 15/10/2026

Đã nối provider `league-collector`, launcher owned host và selector Studio;
`npm run start:collector` không cần mở LB gốc. Dùng DLL gốc/guard/auth gốc,
không phải reader độc lập. Config ổn định tại `collector/config/collector.env`.
137 unit test/build/integration và browser fixture đạt; host thật idle start/
stop và launcher thử thoát không cleanup đã đạt ở idle. Dữ liệu game thật toàn tuyến chưa đo.
Người dùng hiện chưa thể bật game; tiếp tục offline và giữ CS/null, lane chưa
chốt, field ngọc/buff/objective/event chưa nối. Xem
[runbook](PROJECT-RUNBOOK.vi.md) và PROJECT_STATUS.md ở root.

Các plan import/no-frame bên dưới ghi lịch sử trước mốc SR live và tích hợp;
không dùng chúng để phủ nhận frame thật đã đo hoặc triển khai lại từ đầu.

## Mốc mới nhất — SR live ngày15/10/2026

Adapter đãkiểmgameSR10: roster/team/champkhớp10, level/KDA/items220/220matched
ở22samplefinal/212frame. Nativeaux7/8 làm inventorycũmissing,đãlọcstandard0..6;
CScandidatekhôngkhớp nênprojectiondisabled/null. HaihostWS đầu cầnwatchdog;
thêmApplicationStopping token choWS,trialfinaldừngsạch/postcheck0host. Không
nạpDLLthêm ở2lượtreconnect, khôngthaytrận/Studio/OBS. Chưa lane/cooldownsemantics/
fullparity. Xem [report SRlive](SR-LIVE-VALIDATION.vi.md). Bước tiếpCS/lane và
kiểmfieldnghĩa trướcnguồn thửnghiệmStudio;không tựrollout từpresence.

## Mốc mới nhất: field matrix và adapter offline đã triển khai

`collector/adapter` normalize nativeenvelopev1 sangIngameSample/ObserverFrame,
sourceleague-collector riêng, nullablefield, ổnđịnhslot theo team/heroIndex,
teamgold/kills chỉaggregate5fieldhợp lệ. SourceWS chỉđọc loopback, freshness5s,
duplicate/lateframe khônggia hạn, status/socketclose/invalid xóa sample,
reconnectthay session/seekđổiepoch. Khôngcredentials/raw/identity vàooutput.
Matrixtách runtimepresence/positive-change/schema-only/chưa hỗ trợ. Perks/buff/
objectives/events/roleorder chưaverified; productionReadyfalse.
Xem [field matrix](FIELD-MATRIX.vi.md), [adapter](ADAPTER.vi.md). CLI
`npm run collector:inspect` chỉconsume feedđãchạy, khônglaunchCollector/game.
Chưaregister providerStudio/OBS hoặc đoadaptertrênreplay; bước tiếp map11SR/
fieldmapping thật trước integrationproduction.

## Mốc mới nhất: collector dùng DLL LB đã nhận dữ liệu replay

User mở replay/cấu hìnhenv. Login thành công/subscription-unavailable/features0.
Một authenticated bounded trial dùng DLLgốc ghi nhận≥84snapshot/9sample đủ10hero;
no-injectreconnect ghi nhận≥228snapshot/24sample đủ10hero, maxHP/totalGold/spell
readyAt dương và scalarvalues thay đổi. Hai hostexit0/dừngsạch/postcheck0process.
Không LBUI/listener58869; nativeproducer còn4998 sauhoststop, replay giữchạy.
SigningAttempts/signedResponses/requestedFeatures0: chưa native signedauthproof,
chưa chứngminh login là điều kiện cần. Map12/patch16.20.824.8524, chưa map11/
fullparity hoặc C++independent. Chi tiết [runtime](AUTHENTICATED-RUNTIME.vi.md).
Bước tiếp review contract/field offline; runtime thêm cần câu hỏi/coverage mới,
không lặp marker hoặc đổi Studio/OBS production từ các sample này.

## Mốc mới nhất: kiểm chứng auth flow offline

Build harness6check/lifecycle16/16/auth-flow4/4 đạt. Empty features bỏ qua native
challenge trong managed source thực; đăng nhập chưa tự chứng minh native auth.
Account checker trên máy trảnot-configured; Client/game/LB không chạy, ReplayAPI
approvedGET ECONNREFUSED. Cần cấu hìnhaccountlocal và mởClient/replay trước trial
thật. Xem [hướng dẫn và bằng chứng](AUTH-VERIFICATION.vi.md).

## Cấu trúc hiện hành sau dọn workspace

Source làm việc đã chuyển tới `collector/hosts/lb-host` và
`collector/hosts/independent-reader`. Runtime cloud nằm trong `collector/runtime`,
scripts ở `collector/scripts`, evidence ở `collector/evidence`, baseline/ZIP
trong `collector/archive`. Xem [README](../README.vi.md) và
[bản đồ di chuyển](../evidence/import/layout-migration-20261014.json).
Evidence lịch sử giữ nguyên nội dung, kể cả đường dẫn cũ trong log.
Các wrapper root giữ lệnh validation cũ và dùng cùng one-shot marker đã di chuyển.

Kiểm chứng layout mới: managed build/doctor/serializer/lifecycle đạt5check,
lifecycle16/16, khônggameaccess; kết quả ở
`../evidence/validation/managed-lab-2026-10-14T14-39-47-357Z-c9c90bbf8edf4cd3bd4a2b1752fcd6e3/`.
JS/PowerShell syntax đạt; layout verifier kiểm16link local, source/runtime paths,
marker và hash native đạt. Xóa một bản `LeagueCollector-source.zip` trùng SHA-256
10.754.626byte; bản canonical vẫn ở cloud export/packages. Evidence trial giữ nguyên.

## Kết quả import trên máy này

- Hai ZIP độc lập khớp SHA-256 trong `00-DOWNLOAD-AND-EXTRACT.vi.txt`.
- Kiểm entry trước giải nén: không trùng đích, không path traversal hoặc symlink.
- Giải nén vào `../archive/cloud-export/`: 12.733 entry, tổng 396.986.510 byte.
- `verify_export.py` đạt: 12.731 file trong manifest khớp size/SHA-256, 0 lỗi.
- Hai runtime Windows giải nén riêng vào `../runtime/`: 757 file.
- Người dùng restore validation; source, script, lab 16/16 và log no-inject đã
  hiện diện. Không ghi đè chúng bằng source cloud cũ.
- Đối chiếu 10 source file khác/new so với standalone cloud, gồm host diagnostics,
  lifecycle tests/scope, watcher/connector/injector và cancellation HTTP. Hash
  DLL native local/cloud khớp `a1028d56…f2fe`.
- Đã đọc evidence và đối chiếu hash/source, không chạy lại build/lab/game/auth
  trong lượt import. Không chuyển Studio/OBS sang collector mới.

## Hai nhánh hiện có

| Nhánh | Đã có | Chưa chứng minh |
| --- | --- | --- |
| LeagueCollector dùng DLL LB | Host .NET, managed Farsight, HTTP/WS, serializer, recording; bản local sửa lifecycle | Native ready, handshake/service và snapshot thật trong trial của gói này; parity tài khoản hiện tại |
| LeagueReader độc lập | C++17/C ABI, callback reader/Win32 adapter, host .NET, profile resolver, parity tools, Windows cross-build | Tự tìm hero roots, field đúng trên game, reader phức tạp/events và thay LB production |

Theo `STATE.json` và source cloud: 226 descriptor, 241 signature variant, 214
scalar candidate; 13 field mapping tĩnh, **0 field game-validated**. Không coi
pseudocode 246 hàm chọn lọc là toàn bộ source LB. Nhánh độc lập không dùng DLL
hoặc auth BlueBottle, nhưng chưa giải quyết acquisition thực tế đủ dữ liệu.

Bản local có `ManagedWatcherLifetime`, startup claim theo generation và sửa
cancellation/cleanup. Log đã restore ghi lab **16/16**, `gameAccessed=false`,
`telemetryFields=0`; build exit 0 nhưng có warning, không gọi build sạch warning.
No-inject cuối thoát 0/dừng sạch, 0 frame. Trial injection lịch sử có 0 frame,
phải watchdog và bắt đầu sau GameEnd ở map12; không dùng nó để kết luận lỗi
Develop, Free, replay hay anti-cheat. Lab/no-inject chưa chứng minh đường native
cleanup thực tế sau các sửa cuối. Xem [review](LIFECYCLE_REVIEW.vi.md) và
[validation](VALIDATION.vi.md).

Trial của `.research/lb-headless` trước đó nhận response thiếu Develop là bằng
chứng của **host/đường auth đó**. Không tự áp kết luận cho trial gói cloud đang
chưa qua native ready. LB gốc đã có replay telemetry trong các phiên riêng;
collector mới chưa kế thừa kết quả đó.

## Plan tiếp tục

1. **Chốt baseline local offline.** Dùng source validation làm nhánh tiếp tục
   DLL gốc; giữ source cloud nguyên để diff. Review các khác biệt ghi trong
   `import-audit-20261014.json`, đối chiếu lifecycle cancellation, startup claim,
   cleanup và diagnostic stage. Build/lab lại khi sửa source hoặc đổi SDK/binary;
   ghi hash và không coi log lịch sử là test vừa chạy.
2. **Xác minh Windows fixture của thư viện riêng.** Review launcher/test rồi
   chạy nguồn synthetic cô lập, không PID game. Kiểm DLL load/ABI, null/error,
   API/recording và dừng process. Kết quả chỉ chứng minh runtime Windows/fixture,
   không game coverage. Không tự cài toolchain hoặc đăng ký REA khi chưa cần.
3. **Tiếp tục nghiên cứu offline có mục tiêu.** Tái sử dụng evidence/database
   ghim hash, lập ledger cho object discovery và field còn thiếu; phân biệt
   static-derived với game-validated. Chỉ mở native analysis khi có câu hỏi còn
   thiếu cụ thể. Không bỏ auth, giả identity/grant hoặc vượt quyền đọc game.
4. **Runtime riêng là mốc kế tiếp khi có phiên phù hợp.** Cần replay mới còn
   đang chạy, ưu tiên map11/SR; kiểm clock tăng/pause/seek/GameEnd ngay trước
   test. Chọn rõ nhánh DLL gốc hay reader riêng, giới hạn quyền và hành động
   theo phiên hiện tại. Consent/one-shot marker cũ là lịch sử, không tái dùng
   hoặc xóa marker để chạy lại. Với DLL gốc: đo window/version → producer IPC →
   transport → handshake/quyền → service → first valid frame, giữ watchdog và
   dừng ở lỗi. Không suy Injected thành producer ready.
5. **Đối chiếu và tích hợp sau khi có frame thật.** Baseline LB và candidate phải
   cùng trận/epoch/cửa sổ thời gian và provenance tài khoản đã xác nhận. So roster,
   giá trị biến đổi, freshness, pause/seek, reconnect và event coverage. Không sửa
   gameId/source/synthetic cho tool parity báo matched. Sau đó mới thiết kế adapter
   theo contract project; field thiếu giữ null/availability và tiếp tục giữ LB
   production cho đến khi coverage/stability được đo.

Ưu tiên gần nhất: bước 1–2 offline. Chưa cần người dùng mở game để hoàn thành
review/fixture. Mục tiêu full telemetry chưa đạt; không báo phần trăm tương đương.

## Tài liệu gốc

- [Bắt đầu gói cloud](../archive/cloud-export/RiotOverlay-local/00-START-HERE.vi.md)
- [Kế hoạch cloud](../archive/cloud-export/RiotOverlay-local/docs/LOCAL-NEXT-STEPS.vi.md)
- [State machine-readable](../archive/cloud-export/RiotOverlay-local/STATE.json)
- [Source reader riêng](../archive/legacy-src/LeagueReader/README.vi.md)
- [Bằng chứng đối chiếu local](../evidence/import/import-audit-20261014.json)
