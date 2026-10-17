# Audit mục tiêu tích hợp LB — 15/10/2026

**Cập nhật sau audit:** người dùng đã mở replay map12; blocker game API vắng
đã được gỡ cho kiểm chứng field cơ bản. Native host riêng thu được HP10/10,
resource9/10 và hai loại vàng10/10, có biến thiên trong232frame no-inject.
Không cần SR để tiếp tục HP/MP/vàng. Xem PROJECT_STATUS.md/root và
[basic probe](BASIC-FIELDS.vi.md). Các kết luận thiếu proof toàn tuyến/full
telemetry bên dưới vẫn còn; mô tả game vắng ở cuối là lịch sử trước lượt này.

Mục tiêu giữ nguyên: “tiếp tục xây cho đến khi hoàn toàn đính được LB vào
project của tôi mà không cần khởi động LB gốc”. Không thay mục tiêu thành
fixture, compatible subset, reader prototype hoặc chỉ launcher chạy được.

| Yêu cầu cần chứng minh | Evidence hiện có | Kết luận |
| --- | --- | --- |
| Project tự quản lý collector, không cần mở UI LB gốc | supervisor/start:collector, owned host idle start/stop403, parent-lifetime test; DLL hash ghim | Triển khai và idle proof có; in-game tự khởi động toàn tuyến chưa đo |
| Account/auth/feature/version/spectator guard giữ đúng | source giữ guard, auth lab5/lifecycle16; SR trước nhận native frame với feature/signcount0 | Không bypass; chưa signed native/full entitlement proof, không suy Develop là blocker chung |
| Roster10, dữ liệu thật đi từ host qua adapter đến Studio/OBS | SR riêng level/KDA/items220/220; shared routing/browser/validator positive fixture | Chưa có game proof toàn tuyến mới; không cộng hai cửa sổ thành một proof |
| Bộ telemetry LB cần cho HUD hiện hành | FIELD-MATRIX/source; perks/item timer/event projection mới dựa source | CS null; lane chưa map; HP/gold/cooldown semantics chưa parity; buff/respawn/counter/timer objective còn thiếu |
| Event/state/session ổn định trong vận hành | bounded queue, expiry, dedup/seek/reconnect fixture; native third shutdown exit0 | Native event retention và full session/loss/reconnect/patch chưa đo |
| Credentials/provenance/OBS/theme đúng ranh giới | config ignored, filtered adapter/recording, fixture sentinel checks, OBS1920 alpha | Đã kiểm phạm vi lab; không raw payload vào widget/theme, giữ baseline |
| Kiểm chứng build/regression và lệnh chạy | build146unit; test:collector, transport/system từ mốc trước; validator lab10 hiện tại | Đạt ở phạm vi được ghi trong TEST_REPORT, chưa là parity game |

Completion **không được chứng minh**. Source hiện vẫn productionReady=false,
roleOrderVerified=false, CS/respawn/Baron/team towers có null rõ ràng; đây là
giới hạn có bằng chứng, không được thay bằng số0 hoặc nội suy để đóng mục tiêu.

Blocker hiện hành là game/test input: người dùng đã báo chưa thể bật game;
API2999 unavailable lặp qua các lượt tiếp tục, cuối18:38:59.804UTC. Không còn
job runtime/lab đang chờ ở cuối lượt; các test handles đã exit0. Engine positive
HTTP/WS đã kiểm10 fixture scenarios, nên tiếp tục lặp lab không giải quyết
missing game semantics hoặc thiếu telemetry. Không coi blocker này là lỗi
auth/native, hoặc dừng chỉ vì test khó hay cần thêm confirmation.

Để mở lại work có nghĩa: spectator live SR10 hoặc replay SR10 tương thích
patch, trước GameEnd, LB gốc đóng. Chạy project owned collector và validator
theo [runbook](PROJECT-RUNBOOK.vi.md)/[live check](LIVE-PROJECT-CHECK.vi.md),
đối chiếu clock/roster/field/HUD. Dùng kết quả thật để khoanh CS/lane/timer,
buff/respawn/objective acquisition và full session stability. Nếu account/DLL
không cấp field thì ghi response và xử lý đường được hỗ trợ, không fake quyền.
Chỉ chốt hoàn thành sau khi các yêu cầu còn thiếu đã có evidence phù hợp.
