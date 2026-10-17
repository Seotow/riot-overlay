# Kiểm chứng đầy đủ collector không tài khoản — 16/10/2026

**Tạm dừng theo yêu cầu user.** User xác nhận sau event rồng: xanh1/đỏ0.
Watcher đã bắt DeathEvent950.9522s, unit`sru_dragon_chemtech`,killer Yasuo/teamORDER,
HP unit về0. Riot vẫn không cóDragonKill sau event; app dragons vẫnnull/missing
vì chưa có mapping. Không gọi đây là end-to-end dragon support. Bằng chứng
`dragon-watch-2026-10-16T11-02-58.031Z.json` và
`dragon-check-2026-10-16T11-06-33.875Z.json` tại `../evidence/validation/`.
Giữ app/game; dừng audit chủ động, chưa tiếp tục sửa mapping hay test khác.

Đang thực hiện cùng user trên SR map11, Yasuo là người chơi, các slot còn lại
là bot theo user xác nhận. Không đổi auth/cache/guard, không tự điều khiển game.
Mọi kết luận chỉ áp dụng field/cửa sổ đã đo, chưa full parity.

## Mẫu pause 10:21.77

User đã pause và chọn tướng, sau đó yêu cầu ưu tiên Yasuo. Mẫu native/app:
Yasuo level10, K/D/A6/4/0, HP1495.4379/1583.4, resource wind341.2647/341.2647,
vàng đang giữ2066.4946,totalGold6566.506. User ban đầu báo1496/1496, sau đó
xác nhận đã đọc nhầm và số native/app là đúng. Ghi nhận user-confirmed HP tại
mẫu pause này; resource341/341 khớp ở độ chính xác hiển thị HUD. Không có ảnh
HUD độc lập và chưa xác minh mọi trạng thái HP. User không thấy vàng nên
currentGold/totalGold vẫn chưa HUD-verified.
Riot cùng clock xác nhận level/KDA/items/DFlash/FIgnite/keystone8008; HP/resource/
gold Riot không cung cấp. CS DLLcandidate92+0 khác Riot90 nên output vẫnnull.
Các cooldown readyAt source chưa HUD-verified; không coi presence là proof.

Roster có hai Kog'Maw cùng đội. Audit chỉ so8 cặp team/champion duy nhất;
không ghép hai slot trùng theo chỉ số, tên hoặc KDA. Validator tổng thể vẫn
từ chối roster ambiguous/provider mới, chưa nới gate production.
Mẫu visionScore:8/8 cặp trong epsilon tuyệt đối0.0001,5/8 exact,
maxdelta4.61395e-8. Mismatch strict của audit không tự chứng minh sai mapping.
Epsilon là phép kiểm diagnostic riêng, không âm thầm đổi comparator hiện có.

## Đang đo rồng và event sau resume

User yêu cầu lấy mốc rồng rồi sẽ cho chạy qua đoạn ăn rồng; báo HUD hiện0.
Tại clock696.3588s, Riot allgamedata có0DragonKill và GameStart; completeness
vẫnfalse, không suy lịch sử đầy đủ từ riêng GameStart. App cả hai team dragons
null/missing; native teamStats chỉ cótowersLost, chưa counter rồng. Không épnull
thành0. Mốc `dragon-check-2026-10-16T11-01-07.633Z.json`.

Watcher chỉ đọc đã thấy minion rồng code`sru_dragon_chemtech`,HP5790.625/max5790.625
tại822.1165s. Giữ network IDs tạm trongRAM để đối chiếu DeathEvent nếu rồng chết;
không log IDs hoặc suy kill từ việc unit biến mất. Watcher ghi các candidate
đã lọc vào `dragon-watch-2026-10-16T11-02-58.031Z.json`; chưa mapping production.
User đã được hướng dẫn chạy1× qua thời điểm ăn rồi pause/báo đội/loại/time.

Audit sau resume đã có ChampionKill native và Riot tương ứng, Studio/OBS nhận
cùng event. Các slot Kog'Maw trùng có thể thiếu actor resolution phía Riot;
không đoán. Checkpoint có TurretKilled Riot mà chưa có counterpart native đã
normalize: cần kiểm vector/context trước khi kết luận nguồn hoặc adapter lỗi.
Chưa nâng thành event parity toàn diện.

Evidence: `yasuo-reference-2026-10-16T10-56-17.747Z.json`,
`ward-score-precision-2026-10-16T10-57-54.246Z.json`, audit checkpoint
`accountless-full-2026-10-16T10-55-11.613Z.json` ở `../evidence/validation/`.
Focus file chỉ giá trị public champion, không identity/token/raw payload.
Audit checkpoint lưu counts/event đã normalize, không raw names/network IDs.

## Trình tự cần hoàn tất cùng user

1. HUD Yasuo khi pause: thời gian, HP/max, resource/max nếu thấy, vàng đang giữ.
   So với mẫu cùng clock; ghi sai số hiển thị, thiếu mục giữ chưa xác minh.
2. Cooldown: đối chiếu D/F/R/ward đang pause, rồi resume và ghi nhận lần dùng
   phép/kỹ năng/item để kiểm readyAt/total và countdown. Spectator không điều
   khiển tướng; chỉ yêu cầu user quan sát hoặc thao tác khi họ thật sự điều khiển.
3. Resume, theo dõi Yasuo trong giao tranh: kill/death/assist, chết/hồi sinh.
   So native vectors → adapter recent events → Studio/OBS → Riot event đúng thời
   điểm. Không coi vector trống trong pause là lỗi. Ghi sự kiện chưa xuất hiện.
4. Theo dõi trụ/nhà lính/Ace; rồng/Baron/buff/objective counter còn thiếu mapping.
   Xác minh source trước khi bổ sung; không tự dựng event từ scoreboard thay đổi.
5. Sau đoạn có event: pause/resume/seek nếu user có thể, reconnect/loss và
   cuối trận. Không chủ động đổi nguồn hoặc dừng host giữa event đang đo.

Mỗi bước chờ user báo thao tác hoàn thành. Không hứa xác minh Elder/Baron hoặc
end-game nếu trận test không tạo được tình huống; trạng thái cuối phải phân biệt
đạt/sai/chưa có dữ liệu/chưa diễn ra/chưa hỗ trợ.
