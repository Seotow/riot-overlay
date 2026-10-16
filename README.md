# Rift Studio — LoL Overlay Kit

**Test UI/ghi toàn trận không đăng nhập:** chạy `npm run start:collector:no-auth`,
terminal khác `npm run capture:collector -- 10800000`; sau trận dùng
`npm run capture:collector:stop`. Native/Riot và sample playback lưu tại
`data/captures/`. [Bàn giao sang chat UI và cách đối chiếu](docs/UI_COLLECTOR_HANDOFF.md).

**Collector không tài khoản — 16/10/2026:** đã có tại **Kết nối dữ liệu →
Nguồn trận đấu → Collector DLL cache: không tài khoản (thử nghiệm)**, bên cạnh
LB gốc, Riot local và collector có tài khoản. Cần runtime/DLL cache đã restore;
đã nhận HP/resource/vàng thật trên SR khi không auth với cache hiện tại;
chưa full parity hoặc đối chiếu số liệu với HUD. Build và restart backend sau cập nhật.
Xem [các chế độ collector](Collector/docs/PROJECT-RUNBOOK.vi.md).

**Collector trong project — 15/10/2026:** `npm run start:collector` chạy backend
và quản lý host LeagueCollector, không cần mở LB gốc. Credentials tại
`Collector/config/collector.env`. Chưa full telemetry/parity; tuyến Studio/OBS
đã test bằng fixture, còn chờ kiểm chứng trận thật. Xem
[hướng dẫn chạy](Collector/docs/PROJECT-RUNBOOK.vi.md).
Đo provider hiện hành với Riot/Studio/OBS bằng `npm run collector:validate`
khi spectator SR10 sẵn sàng; [hướng dẫn đo](Collector/docs/LIVE-PROJECT-CHECK.vi.md).

Collector LoL nằm trong [Collector/README.vi.md](Collector/README.vi.md): source
làm việc, runtime, scripts, evidence và archive tách riêng. Trạng thái/kế hoạch
tại [Collector/docs/STATUS-PLAN.vi.md](Collector/docs/STATUS-PLAN.vi.md).

Ứng dụng local-first: collector/adapter → backend TypeScript → WebSocket → React Studio / OBS renderer. LeagueBroadcast là nguồn production đầy đủ; Riot local là nguồn giới hạn, recording phát snapshot đã lưu. Demo là nhánh riêng, mặc định tắt.

## Chạy

Yêu cầu Node.js 22.12+ hoặc 24.

```sh
npm ci
npm run dev
```

- Studio: http://127.0.0.1:4310
- OBS Browser Source: http://127.0.0.1:4310/overlay (1920 × 1080)
- Scene cố định: `/overlay?scene=ingame`, `draft`, `postgame`.
- `npm run build` kiểm tra TypeScript và tạo bản production. Sau đó `npm start`.
- `npm test` kiểm tra logic trạng thái và validation.

Backend chỉ bind loopback. Đây là ứng dụng một máy, không triển khai LAN/public trước khi bổ sung xác thực và phân quyền.

## Kiểm thử và vận hành

**Phòng thử hiện hành:** `/?page=demo` là bàn phát lại capture thật, dùng cùng
preview/điều khiển như Studio, thêm play/pause/seek/tốc độ và timer game từ sample.
Chọn bản ghi rồi Tải; mở trang không tự đổi nguồn. Nút widget không cần marker
hoặc mốc event, không tạo dữ liệu thiếu. Các bộ giả lập UI cũ tạm ẩn (giữ source
để phục vụ demo sau). Phát bản ghi cũng thay nguồn cho OBS cùng backend.

**HUD game:** `/?page=hud` lưu preset và áp thủ công qua Replay API render,
không camera3D. Killfeed icon chọn tại config trước trận. Chưa chốt cờ ẩn
riêng killfeed gốc/18+ VNG; giữ thông báo hạ gục/double kill. Xem
[hướng dẫn HUD](docs/HUD_GAME_RUNBOOK.md). Cần restart backend sau cập nhật.

**Sau trận / Riot API:** mở `/?page=postgame`, nhập Standard key hoặc RSO access
token vào ô password, lưu trong phiên RAM, nhập Riot match ID `VN2_…` và tải
Match+Timeline qua SEA. Duyệt candidate trước khi publish; không tự đổi OBS
khi tải. Restart backend cần nhập key lại; không đưa key vào chat/theme/Git.
Standard không mặc định truy cập custom thường. Hướng dẫn và giới hạn tại
[RIOT_API_SETUP](docs/RIOT_API_SETUP.md). Luồng đã test synthetic, chưa xác minh
key/trận của người dùng. Backend đang chạy phiên cũ cần restart sau build.

Layout production mặc định cho cấu hình mới là **không cam**, HP/mana200px cân đối; vẫn chọn lại cam trong config, không ép theme cũ. Bản không cam có ô lane quest hình tròn riêng giữa trang bị/ngọc từng player, giữ vòng progress rồi chuyển sang reward, giữ nguyên nhánh ngọc phụ và không hiện quest trên scoreboard. Bản có cam giữ tiến trình trên scoreboard, khi hoàn thành reward thay nhánh ngọc phụ để tiết kiệm chỗ. Stack champion chưa bật: đã thấy field LB nhưng cần đối chiếu game, xem [bằng chứng stack](docs/LB_STACKS_EVIDENCE.md).

Nền HUD in-game dùng xám than trong suốt, mức chính mặc định84% sau đo ảnh mẫu; chỉnh **Độ đậm nền in-game** (35–90%) tại config và Save. Chỉ đổi nền, giữ độ rõ chữ/ảnh/gauge; lựa chọn lưu/export/import cùng theme. Số đo/giới hạn tại [hiệu chỉnh tone](docs/INGAME_PANEL_CALIBRATION.md). Khởi động lại backend sau thay đổi schema/source khi dùng `npm start`.

Workflow trận thật: **Cấu hình trước trận** (`/?page=theme`) → **Cấm chọn** (`/?page=draft`, nhập tay) → **Điều khiển phát sóng** (`/?page=studio`) → **Sau trận** (`/?page=postgame`, tải Riot/duyệt trước khi phát). Config lưu tên/điểm/logo tùy chọn và toàn bộ theme; Save cập nhật realtime Studio/OBS và lưu local. Bàn điều khiển có preview đúng `/overlay?scene=ingame`, các widget preview nhỏ và nút phát dữ liệu hiện hành. Cấm chọn có đủ 20 lượt, hover/lock, timer, swap, coach/roster, export/import phiên và preview đúng `/overlay?scene=draft`; nguồn draft live chưa nối. Xem [runbook cấm chọn](docs/DRAFT_RUNBOOK.md) và [runbook trận thật](docs/LIVE_MATCH_RUNBOOK.md). Theme v1 cũ vẫn tương thích; logo raster được nhúng khi export/import.

Chọn nguồn tại **Kết nối dữ liệu**; giữ demo tắt khi dùng trận thật hoặc recording.
**Bộ demo UI cũ (tạm ẩn)** có snapshot thật local và dropdown cho
3 loại hang Baron, 7 rồng, 6 Soul, Baron/Elder/cả hai, trụ đầu/thường,
nhà lính xanh/đỏ và 5 role quest. Biến thể mang nhãn giả lập UI, không sửa
telemetry hoặc chứng minh nguồn có field đó. Không dùng Phòng thử lúc phát sóng.

Leaderboard gold/level đủ 10 người, rune chính/phụ, quest progress/reward,
cooldown sweep, Soul artwork tĩnh, Power Play và timer nhà lính đã có.
Damage/combat tự động, champ-select live và end-game vẫn chưa chốt.

### Demo fixture riêng

1. Chọn scene.
2. Bật ảnh tham chiếu để đối chiếu bố cục. Ảnh đã có HUD gốc, nên có thể chồng hình. Không có ảnh nền trong renderer OBS.
3. Chạy/tạm dừng mock, đổi thời gian, kích hoạt kill/level/objective/draft.
4. Chọn kịch bản thiếu gold để kiểm tra fallback.
5. Đổi branding/layout tại **Cấu hình trước trận**, bấm **Lưu cấu hình**. Theme lưu ở `data/theme.json`.
6. Export/import JSON từ trang config. Import chỉ nạp form, bấm Save để phát; thay theme không đặt lại trận.

Tên và ảnh tướng, trang bị, phép bổ trợ, ngọc lấy từ Data Dragon và cache local. Trong nhánh fixture, đội, timer và số liệu là demo. Postgame có trang `/?page=postgame` để nạp bộ mẫu duyệt UI, không tự suy kết quả từ fixture hay GameEnd; xem [hướng dẫn duyệt](docs/POSTGAME_UI_REVIEW.md). Draft dùng fixture riêng; module cấm chọn sản xuất và nguồn dữ liệu được mô tả trong tài liệu draft hiện hành. Thanh timeline fixture không phải replay `.rofl`; timeline recording phát snapshot NDJSON thật đã lưu.

Preset KT/T1 giữ trong source cho regression baseline; trang config production không tự gán logo theo tên. Preview bản ghi/phòng thử tách khỏi bàn live. Xem `VISUAL_AUDIT.md` để biết các chi tiết còn khác ảnh.

`npm run assets:sync` đồng bộ bộ asset demo từ CDN chính thức. Metadata/icon khóa tại Data Dragon **15.20.1**, tương ứng nhãn patch **25.20** trong ảnh mẫu, không phải patch live mới nhất. Portrait loading có URL không chứa version và được lưu local. Studio dùng Beaufort for LoL/Spiegel; headline live dùng Anton (Broadcast Condensed/OFL), nhãn dùng Spiegel. Không khẳng định Anton là font gốc Riot.

## Cấu trúc

Module Valorant được fork local và chạy riêng ở `modules/valorant`, có dependency/build/config/launcher độc lập. Xem [runbook module Valorant](docs/VALORANT_MODULE.md). Chưa xác minh collector/game telemetry thật; tab Valorant trong Studio chưa nối runtime module.

- `shared/schema.ts`: hợp đồng state, theme v1, validation command.
- `shared/mock.ts`: nguồn demo và reducer xác định trạng thái.
- `server/index.ts`: server local, snapshot WebSocket, persistence theme.
- `src/main.tsx`: Studio và kết nối tự phục hồi.
- `src/overlay/Surface.tsx`, `overlay.css`: renderer và layout theo ảnh mẫu.
- `shared/reference.ts`: preset nhận diện và hai fixture độc lập.
- `shared/assets.ts`, `shared/generated/catalog.json`: tra ID → tên/ảnh Data Dragon.
- `src/style.css`: Studio responsive.
- `public/references`: ảnh người dùng cung cấp để preview.

## Giới hạn / bước tiếp theo

- Đã có collector/adapter/session trong backend, playback NDJSON và logo raster tùy chọn nhúng trong config; chưa có agent headless production độc lập, SQLite, ban phase thật hoặc kéo/thả widget.
- Theme hỗ trợ tên, màu, font có sẵn, biến thể, tỷ lệ/dịch dọc toàn cục và widget visibility.
- Snapshot mock protocol v1 và observer envelope riêng có session/epoch/sequence, provenance, availability và dedup. Không nội suy gold, HP hoặc item.
- Mất nguồn/socket: nhánh live giữ khung, ẩn số liệu/hiệu ứng hết hạn sau tối đa 5s; Studio báo thiếu nguồn. Không tự chuyển provider hoặc điền mock.
- Assets tham chiếu không phải asset phát hành mặc định; xác minh quyền trước khi phân phối.

Xem `ARCHITECTURE.md` để biết ranh giới thiết kế và lộ trình adapter.

## Tài liệu bàn giao

UI draft/in-game đã được duyệt làm baseline. In-game đã nối nguồn replay thật; xem mốc mới nhất trong PROJECT_STATUS.md để biết field đã xác minh và field còn thiếu.

- [AGENTS.md](AGENTS.md): hướng dẫn cho Codex và các quy tắc cần giữ.
- [PROJECT_STATUS.md](PROJECT_STATUS.md): đã làm, chưa làm, quyết định đã chốt và bước tiếp theo.
- [SETUP_VI.md](SETUP_VI.md): clone, cài, chạy, chuyển theme và chuẩn bị Git.
- [ARCHITECTURE.md](ARCHITECTURE.md): kiến trúc hiện tại và ranh giới mục tiêu.
- [ROADMAP.md](ROADMAP.md): năm giai đoạn tiếp theo và điều kiện hoàn thành.
- [VISUAL_AUDIT.md](VISUAL_AUDIT.md): mốc bố cục và các khác biệt đã ghi nhận.

Trên máy khác, mở thư mục clone làm workspace và bắt đầu bằng AGENTS.md. Các tài liệu dùng đường dẫn tương đối, không cần lịch sử cuộc trò chuyện để tiếp tục.

## Công cụ chẩn đoán local

Module **Kết nối dữ liệu** kiểm tra LCU/Live Client chỉ đọc và xuất báo cáo field đã lọc. Mock là nhánh thử riêng, mặc định tắt. Xem phần “Chẩn đoán LoL chỉ đọc” trong [SETUP_VI.md](SETUP_VI.md).

Đối với in-game/replay, chọn nguồn tại **Kết nối dữ liệu**. Collector và adapter cấp cùng dữ liệu quan sát cho Studio và OBS; hỗ trợ thiếu field, mất nguồn, session/epoch và xuất bản ghi đã lọc trong RAM. Xem “Ưu tiên kiểm thử in-game bằng replay” trong `SETUP_VI.md`.


## In-game quan sát thật

Tắt “Dùng dữ liệu demo” để nhận nguồn live trong Studio và OBS. Khi mất nguồn, khung còn hiển thị nhưng số liệu chuyển thành —. Tên/icon tướng, item, spell và chiêu cuối dùng catalog live riêng; `npm run assets:sync:live` tải bản mới nhất từ Riot (16.20.1 tại 11/10/2026), rồi chạy build và khởi động lại. Demo vẫn khóa 15.20.1. Field thiếu không được thay bằng mock. Kết quả đo UI từng vùng và giới hạn 95–98% xem [VISUAL_MEASUREMENTS.md](VISUAL_MEASUREMENTS.md).

Dashboard dùng module theo workflow sản xuất: Tổng quan, Nguồn dữ liệu, Studio/OBS, Demo, Theme và Lộ trình. Nguồn LoL có Riot local và LeagueBroadcast local; người vận hành chọn một nguồn cho output, dashboard ghi provenance từng field. **LeagueBroadcast là dependency production bắt buộc khi cần bộ telemetry giải đấu đầy đủ**; Riot local chỉ phục vụ replay, kiểm thử và chế độ dữ liệu giới hạn. Adapter trong project không phụ thuộc SDK npm. Valorant hiện chỉ có workspace placeholder để giữ kiến trúc mở rộng.

Kiểm thử: `npm test`, `npm run build`, rồi `npm run test:integration`. Lệnh tích hợp tự chạy backend riêng ở cổng 4311 và theme tạm, không thay theme người dùng. Cần build trước và cổng 4311 trống. Xem [TEST_REPORT.md](TEST_REPORT.md) cho phạm vi và giới hạn kiểm chứng.

Mô tả Soul có nguồn tại [docs/DRAGON_SOUL_RULES.md](docs/DRAGON_SOUL_RULES.md).
Ghi chú REA/LB và hướng Valorant giữ tại `LEAGUEBROADCAST_FEASIBILITY.md`
và `VALOSPECTRA_FEASIBILITY.md`; chưa phải collector thay thế đang chạy.

## Engine LoL độc lập — prototype

`npm run engine:lol` chạy lõi engine riêng tại loopback4313, không dùng LB DLL,
tài khoản LB hoặc feed LB. Hiện chỉ thu API2999, xuất snapshot/capability/WS và
giữ field thiếu là null; **chưa thay LB đầy đủ**, chưa tự khởi động cùng Studio.
Provider production hiện hành không đổi. Hướng chạy, kiểm thử và mốc acquisition
còn thiếu tại [INDEPENDENT_LOL_ENGINE](docs/INDEPENDENT_LOL_ENGINE.md).
# Bàn giao hiện hành

Phase UI trên bản ghi thật và counters đã chốt ngày17/10/2026. Xem
[báo cáo tổng hợp](docs/PHASE_HANDOFF_2026-10-17.md) và
[trạng thái](PROJECT_STATUS.md) trước khi tiếp tục. Studio đã chuyển sang
shadcn; layout overlay OBS đã duyệt được giữ nguyên.

## Studio mới

Studio dùng shadcn/ui, bố cục vận hành gọn và theme tối trung tính.
[Hướng dẫn Studio](docs/STUDIO_UI.md). Sau khi cập nhật source, chạy
`npm ci`, `npm run build` rồi tải lại trang. Layout overlay OBS giữ nguyên.

