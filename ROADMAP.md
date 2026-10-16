# Lộ trình tiếp theo — ưu tiên LoL

## Ưu tiên hiện hành 17/10/2026

Đã chốt phase snapshot/UI bằng commit `7c79bb1` và trùng tu Studio bằng
shadcn theo luồng vận hành: cấu hình, nguồn, phát sóng, bản ghi, cấm chọn,
sau trận và HUD. Đã giảm thông tin thừa, giữ cảnh báo cần thiết và layout
phát sóng đã duyệt. Hướng tiếp theo là custom/EOG và các telemetry còn thiếu
trong `docs/PHASE_HANDOFF_2026-10-17.md`; không phải thêm mock UI.

## Collector tích hợp — ưu tiên hiện tại 15/10/2026

Launcher/provider/Studio/OBS đã nối và test offline, kể cả launcher thử thoát
không cleanup ở host idle. Khi game sẵn sàng, kiểm tuyến thật không mở LB gốc rồi đối chiếu
CS, lane, HP/gold/cooldown và stability qua session. Ngọc/buff/objective/event
vẫn là phần thiếu của mục tiêu đầy đủ. Xem
[runbook](Collector/docs/PROJECT-RUNBOOK.vi.md); không quay lại khảo sát UI baseline.

## Postgame UI đang chờ duyệt — 13/10/2026

Đã dựng trang `/?page=postgame` và contract mẫu phiên bản 1 theo ảnh người dùng.
Chưa nối nguồn thật, chưa tự activate theo GameEnd. Người dùng duyệt bố cục
trước; sau đó mới kiểm chứng nguồn winner, damage và lịch sử vàng. Xem
[POSTGAME_UI_REVIEW](docs/POSTGAME_UI_REVIEW.md). Giữ baseline draft/in-game
và nhánh REA độc lập.

## Ưu tiên 12/10/2026

In-game tạm dừng ở mức kiểm thử từng phần; bước kiểm chứng kế tiếp là track toàn
bộ trận và ghi feed xuyên suốt, xem `docs/LIVE_MATCH_RUNBOOK.md`. Chưa chạy trận
live mới. Cấm chọn chuyển sang hoàn thiện module theo ảnh: UI/luồng nhập tay đã
có, draft tự động cần capture session thật và kiểm chứng hover/lock/timer/swap.
Xem `docs/DRAFT_RUNBOOK.md`; thứ tự này thay mốc hoãn champ-select phía dưới.

Baseline UI draft/in-game đã được người dùng duyệt. Lộ trình dưới đây chưa phải danh sách tính năng đã triển khai.

## 1. Chẩn đoán nguồn dữ liệu local

Xây công cụ chỉ đọc và màn hình trạng thái nguồn. Kiểm tra client đang mở, game phase và các endpoint thực tế khả dụng. Hướng dẫn người dùng lần lượt mở client → lobby → chọn tướng → spectator → kết thúc trận. Không giả định endpoint từng dùng trong toolkit cũ còn hoạt động.

Đầu ra: bảng field pre-game/in-game/postgame có nguồn, kiểu dữ liệu, availability, độ trễ quan sát, giới hạn và mẫu payload đã loại credentials. Bao gồm picks/bans, champion ID, level, KDA, CS, item, gold, objective, inhibitor. Điều kiện xong: từng field quan trọng có bằng chứng hoặc được đánh dấu chưa kiểm chứng/không khả dụng.

## 2. Observer Agent

Tách collector và adapter; chuẩn hóa envelope theo session/sequence/gameTime, reconnect và phát hiện mất nguồn. Ghi phiên đã lọc dữ liệu nhạy cảm để có thể replay khi phát triển. Credentials local ở lại máy observer.

Điều kiện xong: thu được phiên chọn tướng và spectator, backend nhận ổn định, reconnect không trộn hai trận. Chỉ mở kết nối nhiều máy sau khi có xác thực và cấu hình rõ ràng.

## 3. Nối dữ liệu thật vào overlay

Thay từng nhóm mock bằng field đã xác minh. Đưa số liệu đang hardcode về state contract; tách branding khỏi match data. Studio hiển thị trạng thái nguồn, field thiếu và hỗ trợ nhập tay những phần production cần.

Điều kiện xong: draft/in-game chạy với dữ liệu thật; không biến field thiếu thành số 0 hoặc số mock; mất nguồn không giữ dữ liệu cũ như đang live. Giữ chế độ mock để thử UI.

## 4. Widget nâng cao

Triển khai leaderboard level/gold, objective timer và inhibitor timer theo nguồn thực sự thu được. Kiểm thử spectator delay, pause, replay seek, reconnect và event trùng. Phân biệt dữ liệu quan sát trực tiếp với dữ liệu suy ra.

Nếu API thiếu, đánh giá nhập tay hoặc nhận diện màn hình cho từng field, kèm độ tin cậy; không mặc định OCR toàn màn hình. Điều kiện xong: mỗi widget có quy tắc, nguồn và cách xử lý không chắc chắn rõ ràng.

## 5. Tùy biến và đóng gói

Logo/font riêng, vị trí/kích thước từng widget, preset có migration, hướng dẫn OBS và bản khởi động thuận tiện. Thu bộ nhận diện gốc khi đến bước này. Quyết định lưu trữ production config/event log (file hoặc SQLite) dựa trên yêu cầu thực tế.

Điều kiện xong: thiết lập giải mới không sửa code, chuyển máy được, dữ liệu cá nhân và credentials tách khỏi source.

## Ngoài phạm vi hiện tại

Valorant được nghiên cứu song song với LoL theo yêu cầu 11/10/2026; mốc 13/10 đã fork local BE/FE/Client và triển khai launcher độc lập, build/lifecycle/browser kiểm chứng đạt. Tiếp theo cần executable collector để chạy nguồn thật, rồi chốt capability và nhúng/custom module trong Studio. Chưa xác minh telemetry game hoặc collector fork; TFT vẫn để sau. Xem [runbook module](docs/VALORANT_MODULE.md) và [nghiên cứu nguồn](VALOSPECTRA_FEASIBILITY.md). Thông tin API/chính sách cần kiểm chứng từ nguồn chính thức khi mở rộng.

## Phase provider và game module

1. Giữ LeagueBroadcast là dependency production cho telemetry đầy đủ; Riot local là replay/diagnostic và chế độ giới hạn. Dashboard phải thể hiện rõ trạng thái này và không tự fallback.
2. Lập ma trận sự kiện giải đấu từ video tham chiếu: nguồn trigger, payload, điều kiện phát, thời lượng, ưu tiên, chống trùng và hành vi khi seek/reconnect.
3. Hoàn thiện event contract và renderer cho kill, multikill, first blood, ace, objective, tower, inhibitor, power play, pause/resume, replay và transition đã được xác nhận trong audit.
4. Audit rồi chỉnh scoreboard, player panel, objective/timer, lower-third, replay/transition và công cụ điều khiển production; không mở lại baseline draft/in-game ngoài các khác biệt được video chứng minh.
5. Xây bộ phát bản ghi regression để kiểm tra toàn bộ trigger/animation mà không cần custom mới ở mỗi lần sửa.
6. Tạo contract và renderer riêng cho Valorant sau khi đường production LoL hoàn tất.

Ma trận chi tiết và ranh giới nghiên cứu nằm tại `DATA_SOURCES.md`.

Mốc chốt phase UI/phòng thử 11/10/2026: đã có gold/level ranking 10 người,
rune scene, Soul takeover sáu artwork tĩnh và copy có nguồn, Baron Power Play
derived/Elder timer, active item/GA sweep, quest progress/reward/cue, trụ đầu
và inhibitor một đội mỗi lần. Dropdown phòng thử phủ các biến thể mục tiêu.
Parser/capture regression toàn trận đã có. **Chốt phần đã có dữ liệu, không
chốt toàn bộ sản phẩm production**: combat/damage tự động, Zhonya activation,
end-game, draft live và transition đầy đủ vẫn hoãn; Elder/nhà lính xanh thiếu
mẫu live. Chưa chứng minh 95–98% toàn UI. Collector headless/REA là nhánh riêng.

## Tiến độ chuẩn bị in-game

Đã có collector trong backend, adapter mẫu đã lọc, session/epoch/dedup và bảng quan sát Studio; xem `PROJECT_STATUS.md`. Người dùng chọn kiểm chứng bằng replay trước, tạm hoãn champ-select. Việc kế tiếp cần client: xác minh từng field, pause/tốc độ/tua/reconnect. Không coi kiểm thử fixture là bằng chứng API thực tế hỗ trợ field.

## Ưu tiên mới cho collector — 11/10/2026

**Cập nhật 14/10:** người dùng chọn engine riêng, không reuse LB engine. Đã có
lõi độc lập và HTTP/WS tại4313, chỉ acquisition Riot API2999, chưa full parity.
Hướng này thay việc lặp thử CollectorHost thiếu Develop trong nhánh nghiên cứu;
không thay provider production đang dùng. Bước quyết định tiếp là nguồn thật
được phép cho HP/vàng/cooldown/buff/quest/objectives còn thiếu, rồi mới tích hợp
và autostart cùng app. Xem `docs/INDEPENDENT_LOL_ENGINE.md`. Đoạn11/10 dưới đây
giữ làm lịch sử, không phải yêu cầu chạy lại host chưa có thay đổi quyền.

Ưu tiên chính: xác minh CollectorHost headless lấy dữ liệu spectator **live** khi LB UI tắt, sau đó adapter và autostart cùng app. Cập nhật này thay thứ tự “replay trước” của các mốc cũ đối với nhánh collector.

**Ưu tiên thấp:** điều tra collector có thu telemetry đầy đủ khi xem replay `.rofl` hay không. Phân biệt replay trận trong LoL với phát lại snapshot NDJSON của overlay và tua trong spectator live. Kiểm tra từng tầng: phát hiện cửa sổ → kết nối/auth/version → GameStarted/capture → GameInfo → normalized state. Không chỉ dựa vào Replay API có clock hoặc UI báo Loading. Điều kiện đạt: dữ liệu 10 player/field bắt buộc có mẫu thật, pause/tốc độ/seek không giữ stale hoặc phát event lịch sử sai. Không yêu cầu người dùng vào trận riêng cho nhánh thấp này trước khi đường live đạt. Xem mục mới trong `LEAGUEBROADCAST_FEASIBILITY.md`.
