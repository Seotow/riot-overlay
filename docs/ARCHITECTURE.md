# Kiến trúc LoL

## Studio shadcn — 17/10/2026

`src/main.tsx` là shell LoL với 8 route; các trang dùng chung component shadcn
local `src/components/ui`. Vite/Tailwind 4 xử lý `src/studio.css`, không preflight.
Scope Studio không áp vào OBS `/overlay`; Surface/renderer và transport contracts
giữ nguyên. State/persistence vẫn ở backend, không nhân bản config trong UI.
Preview dùng iframe output URL thật; ảnh đối chiếu ở máy operator.
Xem `docs/STUDIO_UI.md`.

### Native events Collector — 15/10/2026

Typed native event → exact object lookup → sanitized ObservedEvent → bounded
queue của source → `broadcastFrame()` dùng chung cho Studio/OBS. Queue tránh mất
event giữa tick100ms và poll750ms; HTTP observe chỉ đọc. Baseline/seek/reconnect/
loss reset, expiry theo game time và wall time5s; không history completeness
hoặc counter derive. Mapping vẫn source-derived, game semantics chưa xác minh.

### Provider và launcher LeagueCollector — 15/10/2026

`server/index.ts` chọn `league-collector` → `collector/supervisor/supervisor.ts`
khởi động host .NET dùng DLL LB gốc → WS loopback `/ws` → adapter →
ObserverFrame chung cho Studio/OBS. Supervisor sở hữu process, không xác nhận
telemetry; adapter xác minh envelope/roster/freshness riêng. Không đưa env/token
điều khiển sang frontend. Đổi nguồn/demo/shutdown dừng owned host; external
mode không sở hữu host. Parent worker đã kiểm chứng host idle dừng khi launcher
thử thoát không cleanup. Fixture đã chứng minh routing; game toàn tuyến còn chờ.

### LeagueCollector adapter riêng — 14/10/2026

`collector/adapter` đọc envelope native từ host .NET qua `/ws` loopback và
allowlistnormalize sang shared ObserverFrame. Không nhập vendorFarsight/DLL
vào backendTS, khônglaunch/auth/gamecontrol. `ObserverSession` quảnlý epoch/
session, adapter loại duplicate/stale/invalid và xóa output khi mấtnguồn.
Source mới chưaregister providerselectorStudio; LBproduction giữ baseline.
Fieldmatrix/capabilities tách supportedprojection khỏi runtimeverification và
productionreadiness. Xem collector/docs/ADAPTER.vi.md và FIELD-MATRIX.vi.md.

### Riot postgame staged / secrets RAM — 13/10/2026

`RiotPostgamePanel` POST local credential → `RiotPostgameService` RAM vault
(không persist/WS), rồi explicit load Match+Timeline qua SEA GET. Adapter
allowlist → candidate normalized v2. Review cùng Surface/PostgameOverlay;
explicit publish chỉ gửi matchId và backend lấy candidate do nó đã tải, rồi
broadcast state chung. Command/import bộ mẫu chỉ nhận v1/source sample.
Không raw provider/secret/PUUID vào widget. Clear/config generation hủy pending,
giữ result đã publish; lỗi tải không thay chương trình. Cả key/candidate/result
không tự tồn tại qua restart. Header/Origin/body/egress/rate limits tại
`docs/RIOT_API_SETUP.md`. Chưa authenticated test bằng key người dùng.

### Postgame sample review — 13/10/2026

`shared/postgame.ts` định nghĩa contract mẫu version 1 và validation Zod.
Studio `PostgameDesk` gửi command `postgameState` vào backend reducer;
snapshot chung được renderer `PostgameOverlay` và iframe OBS nhận-only đọc.
Không lấy raw payload provider, không có adapter live hoặc auto GameEnd.
Branding vẫn đọc theme chung; source sample được ghi nhãn ở cả Studio/graphic.
Gold history null tách segment thay vì tự nối; stat null khác zero.
Chi tiết và bước nối nguồn sau duyệt tại `docs/POSTGAME_UI_REVIEW.md`.

## Đã thực hiện

Cấm chọn production: `shared/draft.ts` là schema/trình tự 20 lượt và helpers;
command `draftState` cập nhật state có revision qua WS. `DraftDesk` điều khiển
nguồn nhập tay/bộ mẫu, `DraftOverlay` render snapshot nhận-only cho OBS và iframe.
Draft không đọc provider raw, không dùng in-game player để đoán pick/ban. Catalog
asset riêng giữ 15.20.1. Chưa có collector draft live; phiên draft RAM/export JSON,
theme vẫn persistence riêng. Scene cố định và scene theo chương trình tách rõ;
widget preview in-game luôn ép đúng scene.

Mock reducer → backend state → WebSocket → Studio và Overlay Renderer. Schema Zod v1 kiểm tra command/theme tại backend. Mỗi cập nhật có revision; kết nối mới nhận snapshot đầy đủ. Scene và theme nằm trong state, nên các cửa sổ dùng cùng trạng thái. Overlay dùng chế độ nhận-only. Backend ghi theme theo hàng đợi và đổi tên file tạm.

Đã nối Riot local, LeagueBroadcast và recording qua observer envelope riêng.
Snapshot mock v1 vẫn được giữ độc lập. Mỗi field quan sát mang availability/source;
snapshot đầy đủ phù hợp roster 10 player. Event có ID/dedup nhưng chưa có database event log bền vững.

## Các ranh giới cần giữ

1. Observer Agent chỉ thu, đóng dấu phiên/thời gian và gửi dữ liệu; không biết theme.
2. Adapter chuyển payload provider sang game state. Không đưa raw LCU vào React.
3. Backend giữ authoritative state, đồng hồ, logic timer, dedup và capability.
4. Widget nhận state và cấu hình theme. Không tự truy cập Riot hoặc tính ra gold thiếu.
5. Studio quản lý production và theme; OBS renderer chỉ trình bày.

## Adapter tiếp theo

Chuẩn hóa envelope: protocolVersion, sessionId, sequence, source, capturedAt, gameTime, payload. Field nhạy cảm: value hoặc null, availability, source và observedAt. Nguồn mock/live/replay triển khai cùng interface snapshot/events/capabilities. Backend cần phát hiện mất nguồn ngay cả khi socket còn mở.

Kết nối Agent có token riêng trước khi hỗ trợ nhiều máy. Credentials LCU không rời máy observer. Xử lý pause/reconnect/replay seek bằng game clock, không setInterval trên frontend.

## Theme

Theme v1 là JSON cấu hình, không thực thi JavaScript/CSS do người dùng nhập. Mở rộng asset manifest với logo/font/champion art sau khi duyệt UI. Mở rộng layout theo widget (anchor, x/y, size, zIndex) trước khi làm drag/drop. Giữ migration khi schema thay đổi.

## Lộ trình sau baseline đã duyệt

1. UI draft/in-game đã được người dùng duyệt; renderer nằm trong `src/overlay`. Giữ baseline này.
2. Xây màn hình chẩn đoán và khảo sát chỉ đọc LCU/Live Client trên máy thực; người dùng hỗ trợ thao tác client.
3. Kiểm chứng data matrix trên patch thực trước khi cam kết field; bật feature dựa capability.
4. Xây Agent, adapter và bản ghi phiên; kiểm thử reconnect, session và clock.
5. Nối widget thật, hoàn thiện tùy biến và đóng gói. SQLite là lựa chọn tương lai, chưa phải dependency hiện tại.

Chi tiết thứ tự và điều kiện hoàn thành: `docs/ROADMAP.md`. Trạng thái bàn giao: `PROJECT_STATUS.md`.

## Collector in-game hiện tại

Đã có nhánh quan sát song song: Live Client / Replay GET → IngameCollector → normalizeIngame → ObserverSession → `/api/observer` và WebSocket observer → Studio/OBS. `/api/observer/recording` xuất bộ đệm đã lọc; `/api/diagnostics` kiểm tra sáu endpoint ứng viên. Nhánh này dùng message observer riêng bên cạnh snapshot mock protocol v1.

Collector được kích hoạt theo request từ Studio, chưa là agent chạy nền độc lập. Polling tuần tự; timeout request 2,5 giây, giới hạn body 2 MB; cache 500 ms và single flight giữa cửa sổ. Session đổi khi reconnect, đổi nguồn/roster hoặc gián đoạn mẫu trên 5 giây; epoch đổi khi clock nhảy theo heuristic. Không ngoại suy clock, không phát lại lịch sử sự kiện thành alert mới sau tua. Chưa kiểm chứng định danh trận/clock trên patch thật.

Contract field giữ null khi thiếu và không đưa raw payload vào React. Roster hash chỉ dùng nội bộ, không xuất; player hiển thị champion/slot ẩn danh. Live catalog 16.20.1 map champion/item/spell/R/rune; assetPatchMatch vẫn unverified. Bản ghi observer RAM giới hạn 120 frame; capture NDJSON trên đĩa và playback offline đã có, không commit capture cá nhân.


## Nhánh render quan sát hiện tại

Collector → normalized frame → WebSocket observer → LiveOverlay ở Studio/OBS khi mockVisible=false. Poll tuần tự khi có client, cùng collector/cache với HTTP. Socket mất hoặc mẫu quá 5 giây thì renderer giữ khung và bỏ số liệu cũ. Live catalog độc lập demo: sync-live-assets lấy version Riot mới nhất, kiểm tra PNG, ghi manifest hash và publish catalog sau khi tải đủ. Adapter chỉ map token/ID có trong catalog; assetVersion đi cùng sample, assetPatchMatch unverified. Rune/HP/gold thiếu giữ null, không ghép activePlayer stats sang cả roster.

## Module nguồn và mở rộng game

Mốc Valorant 13/10/2026: đã fork local Client/Server/Frontend trong `modules/valorant`, BE Node/FE Angular có dependency/build riêng, launcher quản lý port/ownership/readiness/shutdown và executable collector tùy cấu hình. Runtime không nhập code Valorant vào contract/build LoL; Studio React chưa nhúng FE Angular. Chưa build collector hoặc xác minh game telemetry. Xem `docs/VALORANT_MODULE.md` và `docs/VALOSPECTRA_FEASIBILITY.md`.

Dashboard tách Tổng quan, Nguồn dữ liệu, Studio/OBS, Demo, Theme và Lộ trình. Workspace game là lớp điều hướng; LoL đang hoạt động, Valorant mới là khung mở rộng và không dùng chung contract trận.

LoL có hai provider độc lập. Riot local đọc Live Client và Replay API ở loopback. LeagueBroadcast adapter chỉ kết nối WebSocket local `ws://127.0.0.1:58869/ws/in`, nhận message JSON được SDK công khai mô tả, allowlist field rồi đưa vào cùng observer contract. Một thời điểm chỉ một provider cấp output. Không tự ghép hai nguồn, không tự fallback, không nhận frame testing/mock từ LeagueBroadcast. Dashboard hiển thị provider cho từng field và trạng thái dữ liệu cũ.

### Mở rộng đã xác minh 11/10/2026

Provider thứ ba `recording` phát lại NDJSON local qua cùng adapter/session. Parser dùng stream, giới hạn 512 MB/10.000 frame, hỗ trợ cả capture ID có `lb-`, bỏ bootstrap trống và từ chối frame demo/sai. Thống kê không nội suy; chỉ clock/respawn countdown tiến giữa frame theo playbackSpeed, pause đứng clock, gap 5 giây ẩn dữ liệu. Seek tăng generation/session và seed lịch sử.

Contract bổ sung optional `hasBaron`, `hasElder`, `experience`, `roleQuest`, `perks`, `cooldowns` (item/ultimate/spell, slot/ID, readyAt/total), `inhibitors` (đội sở hữu/lane/destroyedAt/respawnsAt). Field optional giữ tương thích bản ghi cũ. LB sinh LevelUp/ItemCompleted/RoleQuestCompleted theo diff, TurretKilled theo counter, InhibKilled/InhibRespawned theo nhà lính; reset baseline khi mất nguồn/tua ngược/trạng thái ngoài trận. ItemCompleted dùng allowlist explicit. Bốn rồng nguyên tố mới tạo Soul; Elder không tính. Trụ đầu chỉ xác nhận tổng trụ hai đội chuyển 0→1 với baseline đầy đủ.

Renderer dùng game clock dự phóng trong tối đa 5 giây; không chuyển isDead/buff thành trạng thái mới khi countdown hết. Effect level/item 3 giây, objective/structure 7 giây theo thời gian hiển thị; seek/reconnect xóa effect. Tối giản do người vận hành chọn, không tự nhận diện combat. Không có damage telemetry hoặc Power Play gold delta trong contract.

Theme mặc định `data/theme.json`; override `RIOT_OVERLAY_THEME_PATH` phục vụ kiểm thử cô lập. `test:integration` tạo backend riêng 4311 và theme tạm, không đổi branding vận hành.

Phòng thử: `RealTestPanel` → command `rehearsal` → CaptureReplay chọn frame/event đã ghi → state rehearsal tạm + observer frame → Studio/OBS. Capability lấy qua GET `/api/rehearsal`, command chỉ hợp lệ khi recording và demo tắt. Cue mang `manual-rehearsal`; biến thể có watermark riêng, không sửa telemetry/capture/theme. Rune board cần đủ 9 perk ID/10 người; secondary tree thay reward khi quest hoàn thành, không chiếm ô R.

`shared/baron-powerplay.ts` theo dõi live cửa sổ Baron 180s/Elder 150s,
kết thúc sớm chỉ khi đủ năm player được báo mất buff. Buff ownership lấy từ
telemetry, không tự cấp cho player chết. Baron fallback +1500 rồi cộng biến
động chênh vàng ròng từ snapshot nhận buff; nguồn thiếu gold trả null.
Phòng thử recorded Power Play dùng snapshot sau khoảng 10s và loss đã ghi;
preview loại buff dùng số mô phỏng được gắn nhãn. Inhibitor 300s, chỉ một đội
có timer mỗi lần, ưu tiên hồi sinh gần nhất. Soul descriptions là luật chơi
tĩnh có nguồn, không phải chỉ số heal/damage provider. Artwork sáu WebP local,
không AI/runtime 3D. Damage tiếp tục unavailable.

Quyết định production 26/09/2026: LeagueBroadcast là provider bắt buộc cho chế độ giải đấu đầy đủ vì đây là nguồn đã xác minh cung cấp gold, HP/resource, rune, ability và objective của đủ 10 người. Riot local không thay thế LB; nó là provider replay/diagnostic và chế độ giới hạn. Nếu LB mất kết nối, overlay phải báo thiếu nguồn và hết hạn dữ liệu, không âm thầm hạ xuống Riot local hoặc điền mock.

Ranh giới Vanguard: chỉ dùng API, game client, spectator/replay service và feed local do ứng dụng LeagueBroadcast cung cấp. Không đọc memory, inject DLL, hook process, thay đổi Vanguard hoặc nghiên cứu cách vượt anti-cheat. Việc tái tạo độ phủ dữ liệu của LeagueBroadcast nằm ở phase nghiên cứu riêng và chỉ tiếp tục nếu có giao diện được Riot cho phép.

## Engine LoL riêng — nền độc lập 14/10/2026

`scripts/dev/start-independent-engine.ts` → `IndependentEngine` (instance
`IngameCollector` riêng, API2999) → `startIndependentEngineServer` → loopback4313.
GET health/snapshot/capabilities và WS nhận-only, không nối provider production.
Tái sử dụng adapter/session/event enrichment nội bộ; không import DLL, login,
private IPC hoặc feed LB. Field source vẫn là Riot API thật, không đổi nhãn
thành nguồn native riêng. Capability chỉ nói về sample hiện tại, không parity.

Core có collector interface để thay acquisition sau khi có nguồn thật được
kiểm chứng. Prototype luôn `replacementReady=false`; còn thiếu acquisition đầy
đủ và autostart/tích hợp Studio. Không coi một cổng xuất duy nhất là bằng chứng
một nguồn telemetry đầy đủ. Xem `docs/INDEPENDENT_LOL_ENGINE.md`.
