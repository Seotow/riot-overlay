# Chạy Collector cùng Riot Overlay

**Ghi toàn trận không tài khoản / test tiếp tại chat UI:** dùng
`npm run start:collector:no-auth`, `npm run capture:collector -- 10800000`,
đánh dấu bằng`capture:collector:mark` và dừng sạch bằng`capture:collector:stop`.
File mẫu app đã mở lại được trong Phòngthử; fullnative/Riot giữ riêng để đối chiếu.
Chi tiết tại [bàn giao UI](../../docs/UI_COLLECTOR_HANDOFF.md).

## Chọn chế độ trong app — 16/10/2026

Sau build và khởi động lại backend, mở `/?page=sources` → **Nguồn trận đấu**:

- **Riot local: dữ liệu giới hạn**: đọc API local.
- **LeagueBroadcast gốc: nguồn ngoài dự phòng**: dùng LB đang bật.
- **Collector trong project: có tài khoản LB**: host do app quản lý với cấu hình local.
- **Collector DLL cache: không tài khoản (thử nghiệm)**: host riêng dùng DLL cache,
  không đọc tài khoản LB từ file/env thật, không tải DLL mới. Cần cache/runtime đã restore.

Tắt **Dùng dữ liệu demo** để nhận nguồn đã chọn. Đổi chế độ dừng host do app
sở hữu, xóa output cũ; mỗi chế độ collector có session, recording và bộ đếm riêng.
Không dùng host external ở chế độ không tài khoản vì không kiểm soát được auth.
Nếu đang đặt `RIOT_OVERLAY_COLLECTOR_EXTERNAL=1`, bỏ biến đó và restart backend.
Không tự chuyển sang tài khoản LB hoặc API khác khi nguồn thiếu dữ liệu.

Chế độ không tài khoản đã đo HP/resource/currentGold/totalGold thật trên SR
16/10/2026 với cache hiện tại, gồm coldstart diagnostic và reconnect qua app,
Studio/OBS nhận cùng sample; chưa numeric HUD parity/full telemetry/stability.
Cần spectator/replay chưa kết thúc,
giữ LB gốc đóng để kiểm độc lập. Producer trong game đã có từ phiên auth trước
thì kết quả chỉ chứng minh reconnect; muốn coldstart cần phiên game mới.
UI giữ contract roster10; diagnostic script riêng vẫn nhận1..64 hero.
`collector:validate` hiện chỉ đo chế độ collector có tài khoản; chưa hỗ trợ
chế độ mới. Đo cơ bản bằng [probe không tài khoản](BASIC-FIELDS.vi.md).

Mốc 15/10/2026: launcher và provider đã tích hợp. DLL native vẫn là bản LB
gốc; không cần mở ứng dụng LB. Chưa thay LB đầy đủ hoặc xác minh toàn tuyến
trên trận thật. Bằng chứng SR live riêng tại [SR live](SR-LIVE-VALIDATION.vi.md).

## Chuẩn bị và chạy

1. Giữ runtime/DLL đã restore tại `collector/runtime` và `collector/src`.
   Từ thư mục gốc, chạy `powershell -NoProfile -File collector/scripts/build-validate.ps1`
   nếu sửa source managed hoặc chưa có build. Không tự thay DLL/patch guard.
2. Credentials dùng `collector/config/collector.env`, dựa trên file example
   cùng thư mục. File thật đã có trên máy này; không chép vào Git, theme hoặc
   gửi qua Studio. Có file chỉ chứng minh cấu hình hiện diện, không quyền LB.
3. Chạy `npm run build`, rồi `npm run start:collector` từ thư mục gốc.
4. Mở `http://127.0.0.1:4310/?page=sources`. Nguồn LeagueCollector được chọn,
   demo tắt. Đọc riêng trạng thái process và trạng thái dữ liệu/roster.
5. OBS dùng `http://127.0.0.1:4310/overlay?scene=ingame`, 1920×1080. Khi game
   chưa sẵn sàng hoặc frame quá 5 giây, số liệu không được điền bằng mock.

Nếu backend đã chạy bằng `npm run dev`/`npm start`, có thể chọn LeagueCollector
trong Kết nối dữ liệu để khởi động host. Đổi nguồn hoặc bật demo sẽ dừng host
do backend sở hữu. Ctrl+C dừng backend và host đó; không đóng game/LB gốc.
Các lỗi launch được giữ đến khi đổi nguồn/tắt rồi chọn lại, không tự loop retry.

`RIOT_OVERLAY_COLLECTOR_PORT` đổi cổng host (mặc định 18799).
`RIOT_OVERLAY_COLLECTOR_EXTERNAL=1` chỉ kết nối một host đã có, không launch
hoặc dừng host ngoài. Chỉ dùng khi chủ động chạy host thủ công hoặc test fixture.
Không chạy nhiều backend sở hữu collector cùng lúc; cổng trùng báo conflict.

## Kiểm chứng và phần tiếp tục

Khi game đã sẵn sàng và project chạy nguồn owned LeagueCollector, chạy
`npm run collector:validate` ở terminal khác để đo read-only toàn tuyến.
[Live project check](LIVE-PROJECT-CHECK.vi.md) ghi gate, clock matching, shared
consumer và giới hạn. Hiện mới kiểm negative preflight thật/146 unit test;
positive live branch vẫn cần kiểm chứng.

Adapter hiện hỗ trợ projection ngọc và cooldown item theo source, nhưng chưa
đối chiếu các field này trên game. Quy tắc/null và giới hạn tại
[native projection](NATIVE-PROJECTION.vi.md); test count mới139/139.

Mốc event tiếp theo: typed kill/trụ/nhà lính/Ace có projection và queue shared
broadcast; [native events](NATIVE-EVENTS.vi.md) ghi điều kiện/recent window và
giới hạn. Tổng regression hiện143/143, browser fixture đạt; chưa event game proof.

- Offline đã đạt: 137 unit test, build, integration ứng dụng và
  `npm run test:collector`. Browser test dùng fixture và theme tạm; OBS có alpha.
- Host thật idle đã đạt start/health/stop, yêu cầu dừng thiếu token trả 403.
  Parent lifetime worker đã đo host idle tự dừng khi launcher thử thoát không
  cleanup; chưa đo cleanup trong game.
- SR live trước đó xác minh roster, tướng/đội, level/KDA và item thường.
  CS candidate không khớp nên adapter giữ null. Hero index chưa là thứ tự lane.
- Khi người dùng mở được replay SR 10 người còn trong trận hoặc spectator live:
  kiểm map/roster/clock/version trước; giữ LB gốc đóng, chạy tuyến tích hợp này,
  đối chiếu cùng timestamp và kiểm dữ liệu giống nhau trong Studio/OBS. Đo mất
  nguồn, đổi nguồn, reconnect và shutdown; không coi HTTP 200 là native ready.
- Tiếp tục kiểm nghĩa CS, HP/gold/cooldown và lane mapping; hoàn thiện dữ liệu
  ngọc/buff/objective/event còn thiếu theo evidence. Không báo full parity trước
  khi có coverage và stability đo được. Reader độc lập vẫn là nhánh nghiên cứu.

Chưa cần bật game cho kiểm tra offline. Không tự sửa replay, inject lại hoặc
thay quyền auth chỉ vì fixture đã đạt. Không lưu raw identity/credentials vào
report; phân biệt fixture, lab, host idle và dữ liệu game thật.
