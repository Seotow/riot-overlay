# HUD game và killfeed — 16/10/2026

## Kiểm tra dấu 18+ VNG, 17/10/2026

**Đã tạm hoãn theo yêu cầu người dùng.** Lưu hướng điều tra, chưa thay game.
Ảnh cung cấp xác nhận sign native góc (0,0), khoảng 168×28px ở 1920×1080.
Không chọn phương án che OBS. Thư mục cài từ metadata Riot:
`E:/Riot Games/League of Legends`; chưa kiểm config/tài nguyên ở thư mục này.

Đã GET `/replay/render` thật khi replay hoạt động. Có các cờ interface hiện
được allowlist, không có field riêng age/rating/VNG/watermark. `banners=false`
đã có sẵn; chưa có đối chiếu hình để kết luận dấu 18+ chịu cờ nào. Không gửi
POST hoặc tắt interfaceAll/Announce/KillCallouts để thử che dấu này.

Thảo luận PenguLoader #8 năm 2023 có selector `vng-age-rating ember-view`
nhưng là LoL Client dạng web, không phải HUD renderer trong trận; không dùng
nó làm bằng chứng có thể ẩn sign ingame. Chưa cài loader hoặc patch client.
Bước cần người dùng: ảnh đầy đủ màn game có sign để định vị và thống nhất
phương án nếu cần che ở đầu ra OBS thay vì ẩn native. Che đầu ra không được
mô tả là đã tắt sign trong game, và sẽ che cả pixel gameplay trong vùng đó.

## Overlay killfeed

Trang Cấu hình trước trận → Kiểu killfeed → Broadcast → Lưu. Checkbox
“Thông báo hạ gục” vẫn là công tắc tổng. Theme cũ giữ kiểu chữ, không tự đổi.
Broadcast góc trên phải: assist nhỏ → killer → ký hiệu → victim/objective,
viền xanh/đỏ theo event team. Tối đa4 dòng,7s/dòng; seek/loss/reconnect reset
cùng cơ chế transient hiện có. Trụ có thể hiện dạng icon trong chế độ này;
banner trụ và thông báo chữ cũ không bị đổi thành toast trụ.

Quái dùng SVG có sẵn như mask trắng hoàn toàn; timer/banner rồng vẫn giữ
theme nguyên tố. Rồng chưa rõ loại dùng glyph chung, không đoán nguyên tố.
Ký hiệu hạ gục dùng PNG All-In gốc patch16.20 qua CommunityDragon (source/hash
ở `public/broadcast/all-in-ping.provenance.json`), mask trắng; nền xanh/đỏ
bán trong suốt34% và fade trái, không chỉ đổi màu viền.
Chỉ hiện portrait nếu có slot và đúng asset version. Thiếu actor thì dùng
tên đội/placeholder, không dựng killer/victim/assist từ biến động KDA.

Contract có optional killerSlot/victimSlot/assistSlots, giữ tương thích bản ghi
cũ. Riot allgamedata map identity nội bộ chỉ khi duy nhất, không đưa tên/raw
identity vào event. LB cũ chủ yếu có event suy ra từ scoreboard, không có đủ
actor cho mọi event. Collector giữ nguyên ở mốc này, chưa bổ sung actor mapping.
Chưa chứng minh killfeed thay hoàn toàn nguồn game trong một trận thật.

## Trang HUD riêng

Mở `/?page=hud`. Không cần cài League Director: backend gọi trực tiếp
`https://127.0.0.1:2999/replay/render` GET/POST. Không có route cho camera,
playback, tốc độ, file output hay host tùy ý; chỉ boolean HUD trong allowlist.

1. Mở replay/spectator; kiểm tra kết nối HUD.
2. Nạp preset overlay hoặc chọn các ô (bật=hiện).
3. Lưu preset để persist/export/import trong themev1. Lưu không sửa game.
4. Bấm Áp dụng để ghi vào game đang mở. Backend đọc trước, chỉ gửi field được
   game trả về, đọc lại và báo mismatch/unsupported. Không tự ghi khi vào trang,
   save, refresh hoặc reconnect. API xác nhận field không đồng nghĩa đã đối chiếu
   hình game; cần kiểm tra HUD thật trước phát sóng.
5. Muốn hiện HUD lại: Nạp preset hiện HUD → Áp dụng. Đây là preset hiện các nhóm
   HUD được hỗ trợ, không phải khôi phục toàn bộ cấu hình game trước đó.

Preset ẩn interfaceScore/Scoreboard/Frames/Timeline/Chat/Quests/NeutralTimers,
giữ Minimap và Target. Giữ interfaceAll/interfaceReplay và cả
interfaceAnnounce/interfaceKillCallouts=true để bảo vệ thông báo. Thiếu bất kỳ
cờ bảo vệ nào thì backend từ chối ghi, không áp preset một phần thiếu bảo vệ.

## Kết quả điều tra và phần chưa chốt

- [Riot Replay API](https://developer.riotgames.com/docs/lol#game-client-api_replay-api):
  GET/POST render, bật `[General] EnableReplayApi=1` trong Config/game.cfg.
  Project không tự sửa game.cfg. Tài liệu mô tả replay, chưa là bằng chứng
  mọi spectator live/patch đều hỗ trợ.
- [League Director api.py](https://github.com/RiotGames/leaguedirector/blob/master/leaguedirector/api.py)
  và [app.py](https://github.com/RiotGames/leaguedirector/blob/master/leaguedirector/app.py):
  các field HUD và nhãn visibility; không cần module camera3D để dùng chúng.
- Chưa xác minh field nào tách killfeed góc phải khỏi banner giữa màn hình.
  Vì vậy chưa có tùy chọn ẩn riêng killfeed gốc; không tự tắt hai cờ thông báo.
  Bước tiếp cần user mở replay để đối chiếu từng cờ có kiểm soát và hoàn trả.
- Không thấy field riêng cho dấu18+ VNG trong bề mặt API/League Director đã đọc.
  Chưa hỗ trợ ẩn dấu này, không kết luận có thể làm bằng API, không patch client.
- GET thật ngày16/10 trả không kết nối được2999: chưa kiểm chứng hình game,
  chưa gửi POST vào game trong quá trình phát triển.

## Kiểm chứng

Unit161/161, build, integration backend riêng; origin/method/invalid-HUD guards.
HUD service positive/unsupported/mismatch/safeguard được kiểm bằng transport giả.
`scripts/hud-killfeed-smoke.ts` chạy Edge1920×1080, intercept toàn bộ request
HUD trong bài test; kiểm save không apply, reload không apply, explicit apply,
config killfeed persist, hình/layout/icon trắng. Ảnh `*-lab.png` là fixture UI,
không phải event/bằng chứng HUD game thật. Không đánh đồng với kiểm live.
