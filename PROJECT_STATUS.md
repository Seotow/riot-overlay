# Trạng thái bàn giao

## Chốt phase LoL UI/phòng thử — 11/10/2026

Theo yêu cầu rà project/commit: đã kiểm tra source/contract, metadata,
asset/font/hash, descriptions và các nhánh test. Chốt **phần có dữ liệu**:
gold/level 10 player, rune chính/phụ, quest progress/reward/cue, CD sweep,
objective variants, Soul takeover/copy, Baron/Elder, trụ đầu và inhibitor.
Không coi toàn bộ production hoặc REA đã xong; damage/combat/Zhonya
activation/end-game/draft live, Elder/inhibitor xanh live và độ giống 95–98%
vẫn ghi rõ chưa chứng minh. REA và Valorant feasibility được giữ.

README/setup/architecture/roadmap/visual notes/test report bỏ mô tả cũ trái
source (chưa nối data, thiếu scene đã có, mock phòng thử, Power Play cũ).
Quest labels đối chiếu Riot 26.1/26.9; MID bonus AD/AP đúng thay đổi mới,
không đổi ngược thành empowered recall. Nguồn ở docs/ROLE_QUEST_COPY.md.
Production sửa MIME WebP/OTF/TTF, WS reject Host lạ/unknown upgrade.
Integration từ chối port 4311 bận trước khi gửi lệnh, test MIME/traversal.

Kiểm chứng: build đạt (cảnh báo Zod/bundle 536 KB còn), **94/94 test, 0 skip**,
integration cô lập đạt khi chạy lại ngoài sandbox; lượt đầu startup timeout
không được tính PASS. Browser full variants 1920×1080/DPR1 đạt trên backend
test 4391/theme riêng; phase-smoke đạt draft/in-game/postgame fixture và
5 module Studio/1280px. Không sửa theme/playback 4310, không kill port 4312.
TEST_REPORT.md là kết luận hiện tại; các mốc phía dưới là lịch sử.

Commit gồm source/test/scripts/docs và assets/reference cần để clone;
capture/theme/.research/.npm-cache/node_modules/dist giữ ngoài Git. Không
push/publish. Tiếp theo tách riêng collector headless/REA theo roadmap;
không cần custom mới để chốt phase UI, chỉ khi kiểm chứng field còn thiếu.

## Mô tả sáu linh hồn rồng có số liệu — 11/10/2026

Đã đối chiếu Leaguepedia/Fandom qua search-index và patch notes Riot 12.10,
13.20, 2025.S1.3, 11.23/12.2; đọc patch hiện tại 26.20 không thấy đổi Soul.
Wiki chính bị robots chặn, không vượt rào; không tuyên bố đã audit mọi patch
trung gian/tooltip client. Nguồn, phạm vi và số liệu ở `docs/DRAGON_SOUL_RULES.md`.

Sửa nước: câu cũ hồi 2% máu thiếu/5s là Dragon Slayer, không phải Soul.
Sáu Soul có banner hai dòng ghi chỉ số, điều kiện và thời gian/cooldown;
tooltip/aria-label chứa scaling đầy đủ. `+` chỉ phần scaling, không phải
heal/damage đo được. Gió dùng 15%, Hóa kỹ 13%, không dùng buff zombie cũ.
Catalog tập trung `shared/dragon-soul-copy.ts`; không sửa snapshot/provider,
artwork, theme, patch ảnh demo hoặc transport. Giữ vùng strip 503×35.

Kiểm chứng: build đạt (cảnh báo bundle >500 KB vẫn có), **94/94 test** đạt,
không skip. Browser thật 1920×1080 test cả sáu Soul và đo hai dòng không
overflow; toàn bộ visual-capture đạt, đã xem screenshot nước/Hextech.
Không chạy transport integration vì không đổi transport. Bước tiếp: reload
phòng thử để xem copy mới; nếu cần khớp nguyên văn broadcast hãy cung cấp
mẫu sáu banner, không thay mô tả Soul bằng buff stack trong ảnh cũ.

## Đủ sáu ảnh rồng tĩnh, tối ưu 2D — 11/10/2026

Đã tìm Hextech đúng loài trong tranh Preseason Key Art 2022 trên CDN Riot,
nguồn bài `Quick Gameplay Thoughts 1/14: Preseason 2022`; crop phần rồng
xanh bên trái, không dùng boon emblem. Infernal dùng ảnh render sẵn 1263×550
host bởi Dignitas; đây là raster từ model, **không phải tranh vẽ 2D**.
Không tìm được tranh painted Infernal phù hợp; không lấy Kadregrin/generic
dragon để giả danh. Hai boon emblem cũ không còn được widget dùng.

Theo yêu cầu tránh xử lý nặng: cả sáu asset runtime là WebP tĩnh local,
resize tối đa 1600×900/quality 85, không AI, WebGL, model hoặc pixel processing
trong frontend. Tổng nguồn đang dùng 7.190.572 byte → WebP 528.052 byte,
giảm khoảng 92,7%; mỗi ảnh dưới 150 KB. Script sharp chỉ chạy offline;
Infernal loại nền trắng nối với mép bằng flood-fill xác định, giữ highlight
khép kín và bytes gốc. Giữ bố cục sponsor-free/theme/data baseline.

Provenance lưu URL/page/hash gốc và output/kind/transform, script sync cho
phép tái tạo. Build, 93/93 test và browser QA được chạy cho mốc này; xem
ảnh `variant-soul-{fire,hextech}.png` trong `.npm-cache/visual-audit/`.
Không đổi transport nên không chạy integration. Bước tiếp: reload phòng
thử để xem sáu loại; tranh painted Infernal có thể thay sau nếu tìm được nguồn.

## Thay artwork AI bằng ảnh 2D Riot — 11/10/2026

Đã kiểm tra repo `BlueBottleGG/leaguebroadcast-js-client-demo` và
`rcv-prod-toolkit/module-league-in-game`: có icon rồng, chưa tìm thấy pack
tranh lớn đủ sáu nguyên tố. Ảnh AI thực tế nằm ở Soul takeover bên trái;
DragonKill strip đã dùng icon repo nên giữ nguyên.

Soul takeover hiện dùng sáu PNG riêng từ CDN Riot LoR Data Dragon, pin
`7_10_0`: Ocean/Cloud/Mountain/Chemtech là tranh đúng loài; Infernal Might và
Hextech Prowess là biểu trưng boon chính thức, **không phải tranh toàn thân
rồng lửa/Hextech**. Hai tranh đúng loài này chưa tìm được trong nguồn đã
kiểm tra. Không khẳng định đây là pack Worlds gốc. Bỏ hue-rotate/AI fallback,
crop riêng từng tranh, biểu trưng có layout tròn; giữ bố cục và không sponsor.
Loại không nhận diện chỉ hiện nền trung tính. File AI cũ giữ để phục hồi,
không còn được renderer gọi.

Nguồn/card code/hash tại `public/broadcast/artwork/riot-dragons/provenance.json`,
ghi chú tại `public/broadcast/artwork/PROVENANCE.md`, script tải lại
`scripts/sync-dragon-art.mjs`. Không thay Data Dragon demo/live baseline,
telemetry hoặc theme cá nhân.

Kiểm chứng: build đạt (lần sandbox đầu EPERM realpath, chạy lại được duyệt
đạt); **93/93 test**, không skip. Browser QA 1920×1080 đạt các biến thể hiện
có, chờ sáu ảnh Soul tải đủ và xác nhận filter `none`; đã xem cả sáu screenshot
`variant-soul-*.png` trong `.npm-cache/visual-audit/`. OBS vẫn không nền tham
chiếu, không control hoặc ảnh hỏng. Không đổi transport nên không chạy lại
integration. Bước tiếp: reload phòng thử để xem artwork; có thể thay hai boon
emblem khi có nguồn tranh rồng lửa/Hextech đúng danh tính.

## Làm rõ mục tiêu tích hợp Valorant — 11/10/2026

Người dùng muốn gắn collector vào ứng dụng, khởi động cùng project và fork/custom BE/FE ValoSpectra trong workspace; không chỉ xây UI từ output của stack bên ngoài. Đã sửa hướng nghiên cứu tại `VALOSPECTRA_FEASIBILITY.md`: giữ collector Overwolf Electron là process do launcher quản lý, fork BE Node/FE Angular thành package riêng trước khi hợp nhất sâu với Studio React. Có thể dùng collector sẵn, chưa yêu cầu viết acquisition từ đầu. REA đã được đọc để tham khảo; skill hướng dẫn dùng normal source tools khi repository đầy đủ nên chưa cài/chạy REA.

Đã đối chiếu manifest và license/source công khai; chưa fork source vào runtime, chưa viết launcher, chưa cài dependency hoặc chạy game. Mốc này chỉ sửa tài liệu, không chạy test ứng dụng. Việc tiếp theo: pin/import source có provenance/LICENSE, xác định binary collector local, build baseline rồi triển khai startup/readiness/shutdown và custom module Valorant. Giữ các thay đổi LoL đang có.

## Banner rồng và progress nhiệm vụ — 11/10/2026

### Phòng thử: dropdown biến thể, Elder và banner trụ

Đã gom mục tiêu/hạ rồng/Soul/buff/trụ/nhà lính/quest thành nhóm dropdown. Timer có hai selector riêng: GRUB/HERALD/BARON và 7 dragon type; Hạ rồng 7 loại; Soul chỉ 6 nguyên tố (Elder bị backend từ chối); buff chọn Baron/Elder/cả hai; quest chọn 5 role từ event thật. Chọn loại rồi bấm nút trong nhóm. Các nút thường gold/level/cooldown/death/rune giữ nguyên.

`rehearsal.variant` là presentation config chỉ được chấp nhận khi provider recording/demo tắt; không sửa sample, capture hoặc provider live. Mặc định "Theo bản ghi thật" giữ hành vi cũ. Các lựa chọn loại/buff/đội mới có nhãn `GIẢ LẬP UI · NỀN SNAPSHOT THẬT`, không được coi là mẫu telemetry mới. Timer preview mục tiêu 2:00, Baron 180s/+1500, Elder 150s không gold, nhà lính giữa 300s. Preview buff chỉ tô player xanh còn sống; telemetry buff vẫn nguyên. Play/tua/provider/clear loại variant; không lưu theme cá nhân.

Nhà lính có selector xanh/đỏ (xanh giả lập khi capture không có). Live và preview chỉ hiện một đội tại một thời điểm, ưu tiên đội có lần respawn gần nhất; đội khác được hiển thị khi đội trước không còn timer. Mỗi panel đủ top/mid/bot, chỉ lane bị phá đếm. Bỏ nút nhà lính hồi sinh và toast hồi sinh trong UI, giữ event nội bộ để tương thích capture.

TurretKilled bỏ toast bên phải, chuyển strip tại vùng giống banner rồng với hai icon trụ, tên đội và `FIRST TURRET · BONUS GOLD` hoặc `TURRET DESTROYED`. `firstTurret` suy ra chỉ khi tổng towers cả hai đội đầy đủ chuyển 0→1; không phải trụ đầu riêng từng đội. Jump nhiều trụ/thiếu baseline không khẳng định trụ đầu, reconnect/seek không phát lịch sử. Không tự cộng vàng từ banner.

Kiểm chứng: build đạt, **93/93 test** không skip, integration backend/theme cô lập đạt cả variants và từ chối Elder Soul/sai nhóm. Integration so sánh pit type/inhibitor/buff player trước-sau, telemetry không bị sửa. Browser 1920×1080 bấm 21 tổ hợp timer, 7 kill, 6 Soul, 3 buff, 2 đội nhà lính, trụ đầu/thường, 5 quest; đã xem `variant-buff-both.png`, `variant-tower-first.png` trong `.npm-cache/visual-audit/`. Backend phòng thử mở lại, không đảm bảo process tồn tại lâu dài. Bước tiếp: người dùng reload trang, thử các dropdown; mẫu Elder/nhà lính xanh live vẫn chưa có, variant không thay thế bằng chứng đó.

### Cập nhật tiếp: phần thưởng lane quest và căn phải scoreboard

#### Sửa vị trí ngọc và icon R theo `all.png`

Lần triển khai quest trước đã đặt sai rune/reward vào ô R cạnh tên và thiếu cặp ô ngọc cạnh spell. Đã sửa: thêm `row-runes` giữa inventory và hai spell, primary keystone 18×18, secondary tree/reward 14×14, spell 22×22, gap 4 px; phản chiếu đúng cả hai đội. Inventory vùng 184→162 px để thêm cột mà không dịch portrait/các vùng sau. Ô cạnh tên trở lại actual champion ultimate; minimal tiếp tục dùng actual ultimate riêng, ẩn cột rune.

Capture raw đã đối chiếu thứ tự 4 main + 2 secondary + 3 shards. `shared/rune-summary.ts` đối chiếu membership và keystone theo `shared/generated/rune-paths.json` sinh từ metadata Riot cache 16.20.1 (62 ID); secondary phải cùng một tree khác primary, không lấy icon minor perk thứ 5. Quest completed chỉ thay secondary bằng reward, không thay keystone hoặc R. Thiếu/unknown/conflicting vẫn trống. Script sync live cập nhật mapping cùng version; không đổi demo baseline, không tải lại toàn bộ asset hoặc sửa theme.

Kiểm chứng: build đạt, **91/91 test** không skip; browser QA 1920×1080 đạt 10 cột/20 ô ngọc, kích thước/gap chính xác, cả 10 icon R thuộc ability asset trong full/minimal, 5 cue quest vẫn hoạt động; không broken image/reference/control OBS. Đã xem ảnh `levels.png` không nền tham chiếu. Không đổi transport nên không chạy lại integration cho mốc UI này. Bước tiếp: người dùng reload phòng thử, kiểm tra ngọc/quest/R với các nút đã có; không cần thao tác game mới cho sửa này.

Đã đối chiếu `toplane/jungle/midlane/botlane/support/all.png`. Player có field `roleQuest` allowlist từ item slot 8: quest ID, completion, progress và reward. Slot 8 thay bằng boots nhận diện AD; thay bằng 2055 nhận diện support. MID giữ boots trong inventory; AD boots nằm ô quest không trùng inventory. Jungle lấy identifier Smite thực từ abilities. Icon xanh dương/xanh lục trước bị đảo: đã sửa Utility/Gustwalker → 1102, Defensive/Mosstomper → 1103 và tải lại asset CDragon 16.20, giữ provenance/hash. TOP reward Teleport theo completed quest ID, chưa xác minh mọi shield/Teleport variant; reward thiếu vẫn không tự tạo boots/smite.

Transition observed unfinished → completed phát `RoleQuestCompleted`, không replay sự kiện ở baseline/reconnect/seek. Banner phủ đúng hàng player, copy benefit theo ảnh (không coi là công thức gameplay đã xác minh patch 26.20), sponsor-free, hiển thị 4 giây; chuyển ô cạnh tên từ rune phụ sang reward. Phòng thử thêm 5 nút quest với mốc capture thật, xóa alert cũ khi bấm cue mới. Capture phòng tập có vị trí role/row khác hình tham chiếu: dùng role nguồn, không ép row theo ảnh. Chưa đo animation gốc từ video hoặc cam kết độ giống 95–98%; wiki Role Quest chưa truy cập được, cần đường dẫn chính xác để kiểm chứng bổ sung.

Cooldown presentation loại potion/refillable/biscuit/ward/elixir, không xóa inventory/telemetry; GA/Rocketbelt/Zhonya vẫn theo dữ liệu. Đã bỏ toàn bộ hai dòng trạng thái `BARON · đội · n/5` và `LINH HỒN · loại`, giữ Powerplay/khung buff và số rồng/banner sự kiện.

Lỗi T1/pips chưa sát phải do tổng cột scoreboard thiếu 30 px. Cột cuối dùng phần chiều rộng còn lại. Đo browser: mép cụm đỏ cách mép ngoài 3 px (border), pips cách 8 px, đối xứng bên trái. Không đổi theme cá nhân.

Kiểm chứng cuối: build đạt, **87/87 test** không skip; integration cô lập đạt. Browser 1920×1080 bấm 5 quest và các chức năng trước đó, mỗi cue quest đúng một banner; không broken image/reference image/control OBS. Ảnh và số đo tại `.npm-cache/visual-audit/`, đã xem `questMid.png`. Inhibitor xanh không có trong recording nên nút disabled, không fabricate. Backend đã mở lại để kiểm tra nhưng không đảm bảo trạng thái process lâu dài. Bước tiếp: người dùng kiểm tra các nút quest và cung cấp wiki/video nếu cần xác minh variant/animation chính xác hơn.

DragonKill dùng strip (715,113)/503×35 theo `hạ rồng.png`: tên rồng tiếng Anh và hai glyph, không ghi đội hạ; màu theo nguyên tố. Soul giữ artwork sponsor-free bên trái, strip cùng theme và mô tả hiệu ứng. Nước dùng câu trong ảnh “Heal 2% missing health every 5 seconds”; đây là copy tham chiếu, không phải số hồi máu đo hoặc xác nhận công thức Soul patch 16.20. Loại khác dùng mô tả không có chỉ số chưa kiểm chứng. Wiki người dùng chỉ định bị robots/access chặn.

Icon rồng bị đặc do RGB nền tối của PNG vẫn có alpha; `scripts/build-objective-masks.mjs` sinh 10 SVG foreground, giữ PNG/provenance nguồn. Renderer đổi sang SVG, không dùng alpha PNG nữa. Counter `teams.grubs` đặt cạnh 5 role quest về phía giữa, thiếu hiện `—`.

Role quest trước chỉ có completed theo item slot 8/allowlist ID, không progress. Capture xác nhận `stats[0]/stats[1]` là current/target của 1200/1201/1202/1203/1204/1222: top đạt 1199,2013/1200, mid 1349,4607/1350, jungle 34/35 trước reward. Adapter thêm progress optional, validate rồi tính tỷ lệ, circle SVG vẽ quanh icon. Không lấy stats của reward item làm progress vì ý nghĩa đã đổi; thiếu không giả %. Completed vẫn theo ID; chưa kiểm chứng mọi trường hợp slot quest bị thay bằng boots/ward hoặc variant patch tương lai.

Inhibitor không còn luôn hiện: chỉ đội có nhà lính đang hồi sinh mới có panel đủ 3 đường; hết tất cả timer thì ẩn. Hai đội cùng có timer thì xếp dọc cùng mép trái. Top/mid/bot dùng cùng SVG với role quest. Logo/caption T1 và 3 pips căn phải theo đính chính cuối của người dùng.

Kiểm chứng: build đạt, **82/82 test** không skip, integration cô lập đạt. Browser bấm Hạ rồng/Soul/inhibitor và chụp 1920×1080, xác nhận 2 glyph và không tên đội trong banner, inhibitor chỉ 3 hàng khi đỏ đang hồi sinh; không broken image/reference/control OBS. Đã xem `dragon.png` và `soul.png` tại `.npm-cache/visual-audit/`. Không tuyên bố 95–98% toàn UI, không đổi theme/capture, không push/publish.

## Timer nhà lính hai bên và constants — 11/10/2026

Kiểm chứng cuối: `npm run build` đạt, **80/80 test** không skip, `npm run test:integration` đạt với backend/theme cô lập; browser 1920×1080 đạt các assertion 6 hàng/hai đội và 3 hàng/đội đỏ. Backend phòng thử đã được mở lại với code mới, không đảm bảo process sống lâu dài sau restart máy.

Đã đối chiếu `images/hồi sinh nhà lính.png`: panel góc dưới trái, tên đội/emblem bên trái và 3 hàng icon đường bên phải. Renderer mặc định có cả ORDER/CHAOS (mỗi đội 3 đường); đường không có timer hiện `---`, field thiếu hiện `—`, chỉ nhà lính bị phá còn thời gian mới đếm `M:SS`. Hai panel xếp dọc tại (12,745)/263×220; chọn riêng một đội tại (12,858)/263×107, gần vùng mẫu (12,859)/263×106. Icon đường là hình CSS riêng, chưa tuyên bố pixel-perfect.

Phòng thử thêm `Timer nhà lính xanh` và `Timer nhà lính đỏ`, tìm snapshot thật theo đội sở hữu nhà lính, không đổi màu/đội của capture. Capture 11/10 có nhà lính đỏ giữa bị phá nên nút đỏ hoạt động; nút xanh khóa vì thiếu mẫu. Logic xanh đã có test riêng, chưa kiểm chứng thao tác với mẫu live xanh.

Thời lượng mặc định dùng chung tại `shared/game-rules.ts`: inhibitor 300s, Baron 180s, Elder 150s. Adapter ưu tiên mốc hồi sinh hợp lệ từ nguồn, chỉ fallback `destroyedAt + 300` khi mốc thiếu; không ghi đè trạng thái hồi sinh explicit. Constants không thay thế dữ liệu đội/lane/buff hoặc mốc bắt đầu. Theme cá nhân và capture không bị sửa. Browser QA bấm nút và chụp OBS 1920×1080, xác nhận 6/3 hàng, chỉ đường giữa đỏ đếm; không broken image/reference/control. Ảnh `.npm-cache/visual-audit/inhibitor.png` và `inhibitorRed.png`.

## Hiệu chỉnh UI và thời lượng buff — 11/10/2026

Quy tắc người dùng chốt: Baron 180 giây, Rồng Ngàn Tuổi **150 giây theo game clock**; kết thúc sớm khi đủ 5 player của đội được nguồn báo mất buff. Field thiếu/null không được coi là mất buff. Khung tím Baron và khung trắng có hiệu ứng Elder theo từng `hasBaron`/`hasElder` thật của LB, không tự cấp cho người chết hoặc vừa hồi sinh. Elder chỉ có timer, không tính vàng; nếu kết nối giữa buff mà chưa biết mốc nhận thì hiện `--`, không bịa thời gian còn lại. Seek/loss/reconnect xóa cửa sổ lịch sử.

Baron fallback bắt đầu +1.500 G (kể cả teammate đang chết), cộng thay đổi chênh vàng ròng hai đội sau snapshot nhận buff. Không tìm thấy field Power Play trực tiếp trong state của bản ghi đã kiểm tra; không kết luận mọi phiên bản/provider đều thiếu. Chưa có mẫu Elder nhận/mất buff thật trong capture để xác minh end-to-end, chỉ có loại pit DRAGON_ELDER; kiểm thử logic duration không thay thế mẫu live.

Level ranking nay đủ 10 player, sắp level rồi phần trăm XP, có progress trước số level từ `experience.previousLevel/current/nextLevel`. Cooldown là sweep đen opacity quay theo game clock, chỉ đếm số trong 10 giây cuối. Thêm arrow gold-gap, icon riêng GRUB/HERALD/BARON và 7 loại rồng (GitHub BlueBottle demo revision/provenance được lưu), 5 icon Smite/Teleport nâng cấp từ CommunityDragon 16.20; giữ exact ability ID có underscore để Hecarim không mất Smite. Demo asset baseline không đổi.

Kiểm chứng: build production đạt; **77/77 test**, không skip; integration backend cô lập đạt. Browser tự bấm 9 chức năng trên capture thật, renderer 1920×1080, level có 10 hàng/10 progress, cooldown giữ Unleashed Smite, Baron có khung tím và gold lớn/timer dưới; không broken image/reference/control trong OBS. Ảnh và rectangle ở `.npm-cache/visual-audit/`. Đã xem trực tiếp ảnh level/Baron; không tuyên bố đạt 95–98% toàn overlay. Chưa kiểm chứng Elder live hoặc damage/combat tự động. Không đổi theme cá nhân, không push/publish.

## Điều tra Valorant / ValoSpectra local, 11/10/2026

Người dùng yêu cầu nghiên cứu Valorant bên cạnh LoL và xác nhận dùng ba project ValoSpectra local. Đã đọc source Client/Server công khai, ghi revision và ma trận field tại [VALOSPECTRA_FEASIBILITY.md](VALOSPECTRA_FEASIBILITY.md). Xác nhận acquisition qua Overwolf GEP, output Socket.IO 5200 (`logon` → `match_data`); HP/abilities có nhánh auxiliary, HP 100 có thể là default, timer/plant có logic derived/manual. Không coi schema provider là bằng chứng telemetry trực tiếp đủ 10 người.

Trên máy có compose Server/Frontend dưới `../spectra`, frontend trỏ localhost:5200; chưa xác minh image đang chạy, binary Client hoặc mẫu custom live. Workspace Valorant vẫn là placeholder; chưa đổi runtime/UI/contract LoL, chưa cài dependency hoặc nối nguồn. Kiểm chứng mốc này bằng source và cấu hình allowlist chỉ đọc; thay tài liệu nên không chạy test ứng dụng. Bước tiếp theo: mở stack local, xác định version/digest rồi thu output chỉ nhận, đã ẩn danh theo phase custom observer để chốt capability trước adapter Valorant.

## Quyết định production và phase hoàn thiện, 26/09/2026

Người dùng chốt LeagueBroadcast là dependency bắt buộc cho các mục dữ liệu giải đấu đầy đủ; Riot local chỉ dùng cho replay, kiểm thử và chế độ giới hạn. Màn hình Nguồn dữ liệu, README, setup, kiến trúc, ma trận nguồn và roadmap đã đổi nhãn đồng bộ; không tự fallback hoặc biến field thiếu thành dữ liệu thật. Phase tiếp theo là audit video giải đấu do người dùng cung cấp, lập ma trận toàn bộ event/scene/animation rồi hoàn thiện event contract, renderer, UI và workflow production theo bằng chứng từ video. Baseline draft/in-game đã duyệt vẫn được giữ; chỉ sửa khác biệt được audit xác định.

## Đo cloud metadata và restart LB giữa spectator, 26/09/2026

Theo accept của người dùng, chạy PktMon elevated ở chế độ counters-only, filter `178.105.0.170:443`, không lưu payload. Restart LB giữa custom spectator đã tự tái khởi tạo collector: Loading 03:52:14 UTC, NamedPipe/Running 03:52:37, 92 update tới 03:53:25 rồi lỗi parser và OutOfGame. Trong cửa sổ khớp 47,31 giây, `/ws/in` xuất khoảng 1,53 MB JSON còn `broadcast.bluebottle.gg` chỉ có 1.789 byte nhận + 2.186 byte gửi. Đây là STRONG EVIDENCE endpoint broadcast không mang snapshot gameplay; acquisition chính vẫn là native/local qua hook + NamedPipe. Endpoint AWS/Cloudflare lúc startup tương quan với login, CommunityDragon và S3 library, rồi đóng sau startup/collector failure; chưa đo byte riêng nên không tuyên bố mọi cloud traffic đều không liên quan. Helper tự dừng/xóa filter sau tối đa 12 phút. Artifact bị Git ignore; chi tiết ở feasibility.

## Lặp dynamic lần hai và call chain injection, 26/09/2026

Custom thứ hai lặp lại đúng lifecycle: Loading 03:37:36 UTC, NamedPipe/Running 03:38:01, 101 frame median 508 ms, lỗi IPC 03:38:51 và OutOfGame 03:38:52. Lúc Running đã lấy được path module `current\lblib.dll`, SHA-256 `4F9B...43C5`, chữ ký BlueBottle hợp lệ; module unload sau lỗi. IL tĩnh khoanh vùng xác nhận `UpdateAndInjectLib -> LibInjector.Inject`: kiểm tra spectator qua API 2999, `LoadLibraryEx`, lấy export `BlueBottleHook`, `SetWindowsHookEx` vào thread cửa sổ LoL, kích hoạt bằng `PostThreadMessage`; `Release` unhook và `FreeLibrary`. Vì module enumeration của game bị giới hạn, việc map thành công trong process game của phiên cụ thể vẫn là STRONG EVIDENCE, không tuyên bố quan sát trực tiếp. Artifact capture nằm trong `data/captures/lb-2026-09-26T03-37-50-293Z/`. Bước còn lại để phân loại cloud là packet metadata theo PID, có thể cần quyền admin/accept; chưa thực hiện.

## Dynamic custom spectator và lifecycle collector, 26/09/2026

Đã capture liên tục từ champ-select qua Loading/Running. `League of Legends.exe` xuất hiện 03:31:08 UTC; LB chuyển Loading 03:31:33, Farsight kết nối NamedPipe 03:31:56.334 rồi chuyển Running và phát 54 frame với median 506 ms. `tasklist` xác nhận `lblib.dll` được nạp trong `BlueBottleClient.Interface.exe` khi Running; game process bị giới hạn module enumeration nên chưa thể kết luận module có đồng thời nằm trong game. Lúc 03:32:23 parser FlatBuffers lại lỗi ở vector `AIHeroClient`, LB trở về OutOfGame, unload `lblib.dll` và không tự reconnect trong 60 giây dù trận còn chạy. Running mở thêm local port 2999 và kết nối thứ hai tới `broadcast.bluebottle.gg`, nhưng chưa phân loại được traffic cloud nếu không có packet metadata theo PID. Capture nằm trong `data/captures/lb-2026-09-26T03-30-43-117Z/` và `lb-2026-09-26T03-33-23-643Z/`, bị Git ignore. Không attach/debug, nâng quyền, đọc memory hoặc kết nối pipe riêng.

## Baseline dynamic LeagueBroadcast OutOfGame, 26/09/2026

Đã chụp baseline khi LB + Riot/League Client đang mở nhưng chưa vào replay/custom. `BlueBottleClient.Interface.exe` sở hữu cổng 58869; process đã nạp `Farsight.dll` và `BlueBottleClient.GameLib.dll`, chưa thấy `lblib.dll`, và chưa có `League of Legends.exe`. Log cho biết `LocalFarsightDataSource` đang chờ game; public `/ws/in` trong 5 giây chỉ trả một `gameStatus` với `gameState=0`. LB kết nối LCU loopback và `wss://broadcast.bluebottle.gg/ws/rpc`; chưa có bằng chứng gameplay đi qua cloud. Chi tiết/hash nằm trong `LEAGUEBROADCAST_FEASIBILITY.md`; capture cục bộ bị Git ignore. Bước tiếp theo cần người dùng vào custom spectator hoặc replay để chụp Loading/Running và diff module/network/IPC. Không attach, debug, đọc memory, mở pipe riêng hoặc thay runtime.

## Ghi chú điều tra BlueBottle và lab laptop, 26/09/2026

Đã hợp nhất nội dung trao đổi bổ sung vào `LEAGUEBROADCAST_FEASIBILITY.md` và cập nhật ma trận trong `DATA_SOURCES.md`, không tạo file nghiên cứu mới. Kết luận được giữ có giới hạn: xác nhận Discord do người dùng cung cấp cùng artifact cài đặt tạo **STRONG EVIDENCE** cho khả năng collector hiện hành đọc state/memory, nhưng logic native lấy từng field và lý do tương thích Vanguard vẫn chưa được xác nhận. Frontend JS `/ws/in` là consumer, không phải acquisition backend.

Kế hoạch tiếp theo chỉ dùng laptop/account test: baseline, process tree và owner cổng 58869, Procmon, snapshot qua chuyển trạng thái spectator, module diff, inventory handle, network/IPC và schema WebSocket; sau đó mới triage DIE/PE-bear, ILSpy/dnSpyEx hoặc Ghidra có mục tiêu. Risk model: GREEN quan sát, YELLOW phân tích file trên đĩa, RED không injection/hook mới, patch, memory read/write, chiếm IPC hoặc bypass anti-cheat. Sáu câu hỏi điều tra và nhãn **CONFIRMED / STRONG EVIDENCE / HYPOTHESIS / UNKNOWN** đã được ghi trong tài liệu feasibility. Đây là cập nhật tài liệu thuần túy; không chạy BlueBottle/LoL, không kết nối 58869 và không thay runtime.

## Kết quả lấy dữ liệu LeagueBroadcast, 25/09/2026

Đã chốt không điều tra sai lệch clock do seek. Metadata tĩnh ánh xạ lỗi FlatSharp vào vector `AIHeroClient` của `GameInfo`, xảy ra trước WebSocket/adapter; log cũng chứng minh lỗi có thể xảy ra khi chưa có client `/ws/in`, nên project không phải nguyên nhân cần thiết. Frame thật trước lúc upstream ngắt đã có đầy đủ 10 người cùng gold/HP/resource/ability/perk và state đội/objective. Thêm `npm run capture:lb -- 20000` để mở feed ngay, ghi NDJSON từng frame và tự reconnect; đây chỉ là công cụ chẩn đoán output của LB, không phải nguồn thay LB. Production build và 48 test qua esbuild workaround đạt; `npm test` trực tiếp vẫn vướng `uv_os_get_passwd ENOMEM` của môi trường Windows. Chưa sửa/patch LB và chưa có collector độc lập thay thế phần native.

## IL tĩnh IPC LeagueBroadcast, 25/09/2026

Đã đọc method body managed từ file trên đĩa: ReceiveData dùng ReadExactlyAsync cho header 4 byte và payload, kiểm tra chiều dài; HandleFullMessage parse FlatBuffers Response rồi mới phát event. Exception làm RequestDisconnect, khớp hiện tượng OutOfGame. Đã xác định cơ chế dừng feed, chưa xác định nguyên nhân payload sai hoặc logic native thu game state. LocalFarsightDataSource nhận GameInfo từ lblib, không tìm được getter HUD trong các method đã kiểm tra. Không kết nối game/LB, không patch DLL, không thay runtime. Chi tiết ở LEAGUEBROADCAST_FEASIBILITY.md.

## Phạm vi điều tra đã xác nhận và source audit, 25/09/2026

Tiếp tục nghiên cứu tĩnh, không mở thêm kết nối game/LB hoặc chạy collector để tránh tác động phiên live. Đã đọc source Farsight cũ tại commit 0d3c16951803b3074bdf4cb57377910d6574a7db: đường HP/gold dùng đọc bộ nhớ theo offset; wrapper JS không có nguồn độc lập. Metadata LB hiện tại xác nhận lớp nguồn LocalFarsightDataSource và xử lý IngameState tách nhau, chưa xác định collector mới thu state bằng logic nào. Chưa có nguồn đầy đủ thay LB phù hợp ràng buộc; không cần custom cho bước nghiên cứu tĩnh. Kết quả ghi đầu LEAGUEBROADCAST_FEASIBILITY.md; không đổi runtime.

## Kết quả điều tra custom và collector, 25/09/2026

Phân tích tĩnh PE/.NET trên file cài đặt tìm được Farsight.LibInjector (InjectIntoLeague/SetWindowsHookEx), lblib export BlueBottleHook, transport NamedPipe/FlatBuffers. Đây là bằng chứng có cơ chế tích hợp module, chưa xác định logic native thu từng field và không chứng minh an toàn cho clone. Không chạy DLL/hook/debugger/memory reader. Phiên custom map11 có feed thật 10 người nhưng hai lần lại lỗi parser FlatBuffers và OutOfGame; lần mở lại nhận 9 frame trung bình 476 ms. Đã ghi chi tiết, hashes, giới hạn suy luận ở đầu LEAGUEBROADCAST_FEASIBILITY.md. Chưa thay được collector; không mở rộng snapshot hoặc sửa runtime dự án.

## Nghiên cứu HUD element, 25/09/2026

Đã kiểm chứng UI Automation ngoài sandbox: LoL chỉ có RiotWindowClass, không có raw child hoặc supported pattern; chưa có đường đọc gold/HP/timer bằng accessibility. Replay render API có cờ hiện/ẩn HUD, không xuất các giá trị HUD thiếu. Schema game đã đọc trực tiếp. Log LeagueBroadcast mới xác nhận NamedPipe + FlatBuffers, nhưng lỗi giải mã Snapshot.Response rồi ClientDisconnected; health lúc kiểm tra idle/0 update. Chi tiết và giới hạn kết luận nằm đầu LEAGUEBROADCAST_FEASIBILITY.md. Không thay runtime, không can thiệp game và không coi pipe là collector độc lập.

## Ưu tiên mới nhất, 24/09/2026

Người dùng làm rõ yêu cầu: nghiên cứu collector lấy dữ liệu trận đang chạy để thay LeagueBroadcast, không tiếp tục hướng snapshot. Xem phần đầu LEAGUEBROADCAST_FEASIBILITY.md: đã đối chiếu LHM/LeagueOCR (OCR HUD), Trinket (LiveEvents), Overwolf, ROFL parser và OSL. Chưa có collector độc lập đủ state được xác minh. Bước tiếp theo là kiểm chứng LiveEvents và độ phủ HUD; không coi phát lại bản ghi là hoàn thành thay nguồn live.

Trước khi nhận điều chỉnh đã có thay đổi chưa commit cho Riot event enrichment, bảng coverage và capture replay. Build và 48 unit test qua esbuild workaround đã đạt; transport/observer integration đã chạy. Nhánh capture replay chưa audit UI hoàn chỉnh và không phải mục tiêu hiện tại. Giữ thay đổi để tránh mất công việc, chưa tuyên bố thay được LeagueBroadcast.

Cập nhật: 19/09/2026. Đây là bộ nhớ dự án để đọc cùng source trên máy khác.

## Mục tiêu

Xây bộ kit overlay cho game Riot, bắt đầu với LoL. Người dùng muốn Observer Agent thu dữ liệu, backend xử lý, frontend dành cho OBS và Studio tùy chỉnh nhận diện giải. Valorant/TFT chưa nằm trong phần triển khai hiện tại.

## Mốc đã được duyệt

Người dùng đã xác nhận **hai bản draft và in-game đạt yêu cầu ban đầu** sau vòng chỉnh theo `ingame.png` và `overlay.png`. Đây là baseline được duyệt về sản phẩm, không phải kết quả đo chứng minh độ giống 90%. Những khác biệt ở `VISUAL_AUDIT.md` vẫn được giữ làm ghi chú, không chặn chuyển sang khảo sát live data.

## Đã có trong source

- React/TypeScript Studio; canvas thiết kế 1920×1080 và renderer OBS trong suốt.
- Backend Node HTTP/WebSocket loopback, snapshot chung, revision, command/theme validation bằng Zod.
- Mock pause/play, seek, kill, level, objective, draft, kịch bản gold thiếu; reset giữ theme.
- Draft và in-game theo ảnh mẫu. Postgame là demo phụ, chưa có yêu cầu đối chiếu ảnh riêng.
- Asset Data Dragon cache local: tên/ảnh tướng, loading portrait, item, spell, rune. Metadata/icon version 15.20.1; nhãn patch trong ảnh là 25.20.
- Theme JSON: tên giải/đội, màu, font preset, biến thể, scale/offset toàn lớp và widget visibility. Tự lưu `data/theme.json`, import/export.
- Preset tham chiếu trong `shared/reference.ts`; chạy mới không cần mang theo `data` để có baseline.
- Nút chuyển ảnh gốc/bản dựng và bật/tắt ảnh nền trong Studio.

## Chưa có

Observer Agent, adapter LCU/Live Client, dữ liệu trận thật, data availability matrix được kiểm chứng trên máy, event log/replay thật, reconnect theo session nguồn, editor từng widget, upload logo/font, gói cài đặt desktop. Chưa có tích hợp Valorant/TFT.

Một số số liệu phụ vẫn cố định trong renderer (objective counters, cột gold giữa bảng, hover stats); cần đưa về contract khi kết nối dữ liệu. Draft dùng fixture riêng vì hai ảnh chụp không cùng trạng thái trận. Timer demo không phải logic timer đã kiểm chứng. Một số ban/skin được suy luận từ ảnh.

Logo đội/Worlds/sponsor hiện crop CSS từ ảnh tham chiếu. Font thay thế là Anton/Roboto Condensed và Arial ở một số nhãn. Chưa có bộ nhận diện gốc dạng asset rời.

## Kiểm chứng gần nhất

- TypeScript + production build thành công.
- 6 test tự động đạt: state/validation và tham chiếu asset.
- Integration test đạt: snapshot chung, kill propagation, overlay read-only, reset.
- Browser: draft và in-game không có ảnh lỗi sau tải; đo vị trí vùng chính ở 1920×1080; body OBS trong suốt.
- Windows từng khóa `dist/assets` khi build; build lại với `npm run build -- --emptyOutDir false` thành công. Không cần thay mặc định chỉ vì lỗi cục bộ này.

Các kết quả trên là lần kiểm tra trước bàn giao, không phải kiểm tra trên máy mới.

## Việc tiếp theo

Triển khai **giai đoạn 1 trong `ROADMAP.md`**: màn hình chẩn đoán nguồn dữ liệu local chỉ đọc. Chuẩn bị công cụ trước, sau đó hướng dẫn người dùng mở client, vào chọn tướng và spectator để thu mẫu đã loại bỏ credentials. Chưa cần Riot API key cho mock hiện tại; chỉ yêu cầu thông tin thật khi adapter cụ thể cần.

## Tiếp tục trên máy khác

Đọc `AGENTS.md`, làm theo `SETUP_VI.md`, xác minh baseline và tiếp tục giai đoạn 1. Không cần tái nghiên cứu toàn bộ hoặc dựng lại UI từ đầu. Không giả định thư mục `.research`, theme cá nhân hoặc lịch sử chat có trong Git.

## Tiến độ chẩn đoán — 19/09/2026

Đã thêm tab **Nguồn dữ liệu**, endpoint GET `/api/diagnostics`, tự tìm lockfile từ LeagueClient trên Windows hoặc `LOL_LOCKFILE`, probe LCU phase/champ-select/postgame và Live Client allgamedata. Request chỉ GET loopback, timeout/body limit, không follow redirect, cache ngắn và gộp request đồng thời. Route kiểm tra Host/Origin và không cho phương thức ghi.

Báo cáo có nguồn, đường dẫn field ứng viên, kiểu, availability, mẫu số đã lọc, timestamp và thời gian phản hồi HTTP. Export JSON không chứa raw payload, credentials hoặc tên tài khoản. Không đưa dữ liệu chẩn đoán vào state mock hoặc renderer. Objective/inhibitor state vẫn đánh dấu chưa kiểm chứng; EventID không chứng minh capability objective.

Kiểm chứng phiên này: production build đạt; 9 unit tests và transport integration đạt khi chạy bản biên dịch tạm bằng esbuild + Node. `npm test` trực tiếp vướng lỗi môi trường `uv_os_get_passwd ENOMEM` của tsx trên Windows sandbox; không thay dependency hoặc script project để né lỗi. HTTP GET/405/cross-origin 403 đã kiểm tra. Trình duyệt hiển thị báo cáo thiếu nguồn đúng trạng thái.

Probe thực tế ở phiên này: Live Client không kết nối được; chưa tìm thấy lockfile LCU hợp lệ. Đây không phải bằng chứng API không hỗ trợ. Chưa thu mẫu lobby/champ-select/spectator/postgame trên client thật, chưa hoàn tất giai đoạn 1. Tiếp theo: người dùng mở LoL Client, kiểm tra lại, cấu hình đường dẫn lockfile nếu cần, rồi thu báo cáo từng phase theo `SETUP_VI.md`. Chưa triển khai Observer Agent hoặc adapter live.

## In-game / replay — phần chuẩn bị trước client (19/09/2026)

Người dùng chốt ưu tiên in-game, dùng replay để kiểm thử như thời gian thực; tạm hoãn luồng chọn tướng. Đã có collector chạy trong backend (chưa là Observer Agent desktop độc lập), adapter chuẩn hóa và session engine riêng với mock.

- `shared/observer.ts`: schema snapshot/bản ghi nghiêm ngặt; field có value/null, availability, source và observedAt.
- `server/ingame-adapter.ts`: lọc KDA, level, CS, items, team, championId/totalGold khi thật sự xuất hiện; giữ null khi thiếu. Không suy ra champion ID từ tên hoặc totalGold từ currentGold. Event chỉ xuất ID/thời gian/loại thuộc allowlist, không xuất danh tính.
- `server/observer-session.ts`: session ID/sequence/epoch, dedup sự kiện, bỏ lịch sử khỏi newEvents lúc kết nối/tua; mất nguồn xóa sample. Gián đoạn lấy mẫu trên 5 giây hoặc đổi roster/nguồn tạo phiên mới. Nhận biết tua tiến là heuristic theo clock/speed, chưa kiểm chứng patch thật; chưa có match ID đáng tin để phân biệt hai replay cùng roster nếu không thấy gián đoạn.
- `server/observer.ts`: chỉ GET Live Client allgamedata và Replay playback; gộp request đang chạy và cache 500 ms. Không cần LCU lockfile cho luồng in-game này. Một nguồn lỗi không chặn nguồn kia.
- Studio: bắt đầu/dừng theo dõi, retry tuần tự (750 ms sau khi request xong), ẩn sample quá 5 giây, hiển thị slot/KDA/CS/items/gold thiếu; xuất bản ghi đã lọc. Chuyển tab/đóng màn hình dừng polling tại cửa sổ đó.
- Bản ghi chỉ giữ trong RAM, tối đa 120 frame và khoảng 2 MB JSON compact; bản export có thể lớn hơn do format. Khởi động lại backend sẽ mất bản ghi. Chưa có tự lưu đĩa hoặc trình phát bản ghi offline.
- Chẩn đoán có thêm GET replay/game và replay/playback. Không thay đổi game.cfg, không điều khiển camera, pause hoặc seek của game bằng API.

Kiểm chứng: 24 unit tests đạt qua bản biên dịch tạm (9 test trước + 15 test adapter/session/collector). Production build đạt. Observer HTTP integration và transport integration đạt. Browser xác nhận bắt đầu theo dõi và báo thiếu nguồn. Export endpoint trả bản ghi đúng schema; sự kiện download của in-app browser chưa xác nhận được bằng công cụ tự động. `npm test` vẫn có thể vướng lỗi os.userInfo/tsx của sandbox như ghi phía trên.

Chưa có dữ liệu client thật: lần probe mới nhất vẫn unavailable. Chưa hoàn tất capability matrix, chưa nối OBS với live, chưa có objective/inhibitor timer thật. UI draft/in-game baseline và theme giữ nguyên. Bước cần người dùng: mở replay, sau đó kiểm tra play/pause/tốc độ/tua và so field trực tiếp với màn hình.

## Chuẩn bị kiểm tra in-game — tắt demo

Theo yêu cầu người dùng, mặc định khởi động tắt hình/số liệu demo ở cả Studio và OBS, ảnh tham chiếu bỏ chọn và mở tab Nguồn dữ liệu. Có checkbox “Hiện demo (Studio + OBS)” để bật lại khi cần audit baseline. Tắt demo đồng thời pause mock; reset giữ lựa chọn hiển thị. Đây là công tắc hiển thị, không tự nối dữ liệu thật vào OBS. Mock fixture/theme vẫn được giữ để thử UI sau này.

Điều chỉnh theo phản hồi mới: thanh scoreboard chính cao 78px (trước 65px), tổng scoreboard 115px; nhãn gold gap có line-height 18px và nằm sát dưới gold trong thanh chính, tách khỏi hàng rồng. Đối chiếu lại `ingame.png`; giữ nguyên chiều rộng/vị trí ngang.

## Sửa tắt mock và nối overlay quan sát — 19/09/2026

**Thay thế cách tắt demo ở mục trước:** tắt demo chỉ loại fixture/ảnh tham chiếu, không ẩn overlay. `LiveOverlay` giữ scoreboard và 10 hàng người chơi; lấy frame qua WebSocket từ collector backend. Khi không có nguồn, socket mất hoặc frame quá 5 giây, hiển thị khung và dấu —, không lấy số mock. Backend thu tuần tự khi có cửa sổ kết nối và demo tắt; nút theo dõi trong tab Nguồn dữ liệu chỉ điều khiển bảng chẩn đoán, không dừng luồng cấp overlay.

Replay thực tế phiên này đã trả HTTP 200 ở Live Client allgamedata, Replay game/playback. Quan sát được 10 players, team ORDER/CHAOS, clock, level, KDA, CS, item IDs. Chưa đối chiếu bằng mắt từng field với game; không kết luận độ chính xác tuyệt đối. Champion ID và totalGold thiếu trong contract hiện tại: giữ —. Team kills là tổng kills chỉ khi có đủ 5 player có kills; chưa suy ra objectives, gold gap khi gold thiếu hoặc timer.

Renderer live giữ kích thước scoreboard/bảng và branding tên đội từ Theme, không dùng logo/ảnh trận mẫu, tên người chơi fixture, rune/spell/HP giả. Slot dùng BLUE/RED 1–5, item hiển thị ID; champion art và tên người chơi chờ mapping được xác minh. Widget objectives giữ placeholder; draft/postgame live chưa triển khai (khi không dùng mock hiện khung in-game).

Đã thêm 3 test renderer/presentation về khung thiếu nguồn, dữ liệu thật, stale và team chưa đủ; build đạt. Transport test lọc message observer mới để tiếp tục kiểm tra snapshot mock riêng.


## Mapping Data Dragon và kiểm chứng replay — 19/09/2026

Mốc này thay thế các ghi chú trước về champion/item raw, OBS chỉ mock và chưa có mẫu thật. Theo yêu cầu người dùng, tải Data Dragon mới nhất 16.18.1 từ versions.json/CDN Riot, tách khỏi demo 15.20.1. Có 173 champion, 868 item, 34 spell và 67 rune/tree icon (1.142 PNG); manifest SHA256 và metadata lưu local. Chạy npm run assets:sync:live để cập nhật catalog live; sau đó build/restart. Không tự xác nhận patch replay trùng asset: assetPatchMatch vẫn unverified.

Adapter map numeric ID hoặc raw champion/spell token đã biết sang catalog; không đưa raw name/account vào renderer. Inventory giữ slot/count, trinket riêng. UI dùng tên tướng và icon; asset lạ hiện placeholder, không lấy ảnh demo. Field mới optional để đọc được recording cũ.

Mẫu replay thực: map 12, mode KIWI; 10/10 tướng, 57/57 item và 20/20 phép map được. Cả 10 player có level/KDA/CS/wardScore/death/respawn. HP/resource, totalGold, keystone không được nguồn trả về: giữ null/—; gold gap không tính. Team kills chỉ tổng khi đủ 5 player. Tên đội vẫn lấy Theme, tên hàng là tướng chứ không phải tên người chơi. Event đã lọc có GameStart/ChampionKill/Ace/TurretKilled; chưa nối objective/trụ/inhibitor counters và timer. Chưa đối chiếu từng số với màn hình game hoặc kiểm chứng đầy đủ Summoner's Rift.

Kiểm chứng: build đạt; 32 unit tests qua esbuild/Node; transport và observer HTTP integration đạt. Browser OBS 1920×1080 thấy 67 ảnh tải thành công, đều dùng 16.18.1, nền transparent, clock cập nhật, không ảnh mock. File audit/sample đã lọc nằm trong data/ bị ignore. Collector cấp WS khi có cửa sổ và demo tắt; nút theo dõi chỉ dừng bảng chẩn đoán.

Tiếp theo: đối chiếu play/pause/speed/seek trên replay với người dùng; khảo sát nguồn HP/MP/gold/runes nếu contract khác có hỗ trợ, triển khai objectives theo map và bằng chứng event. Không suy ra field thiếu từ fixture.

## Dashboard module và LeagueBroadcast provider, 19/09/2026

Dashboard được tổ chức thành module tương tự workflow của LoL Prod Toolkit: Tổng quan, Nguồn dữ liệu, Studio/OBS, Demo, Theme và Lộ trình. Menu dùng số 01 đến 06, giao diện phẳng và classic; loại các icon trang trí, mũi tên, dấu chấm phân cách và em dash trong phần dashboard. Có game workspace LoL và placeholder Valorant, nhưng Valorant chưa có adapter hoặc renderer.

State có provider `riot | leaguebroadcast`. Trang Nguồn dữ liệu cho chọn nguồn, bật demo, xem trạng thái Riot/LeagueBroadcast/Data Dragon và bảng provenance theo từng field. Backend có `/api/providers`. Chuyển provider xóa frame cũ; không trộn nguồn và không tự fallback.

LeagueBroadcast adapter tự kết nối WebSocket local `/ws/in`, không thêm SDK npm. Chỉ nhận `ingame-state-update` khi gameStatus Running/Paused và `isTestingEnvironment=false`; cần đủ 10 người và champion ID hợp lệ. Adapter loại tên người chơi, URL asset và object lạ; chỉ giữ champion, KDA, level, CS, vision, gold, respawn và item allowlist. Frame thiếu, mock hoặc quá 5 giây không được phát. Dữ liệu Free thực tế vẫn cần được xác minh trong một custom game đang spectate.

Thử nghiệm bản 1.13.3 với replay thường: ứng dụng kết nối cổng 58869 nhưng giữ `gameStatus=Loading`, telemetry `idle`, không tạo current game và không phát frame. Tài liệu sản phẩm hướng dẫn spectate custom game. Dashboard nay hiển thị game status, telemetry và tiến độ asset cache để phân biệt kết nối transport với dữ liệu trận thực tế.

Ranh giới an toàn được ghi vào kiến trúc và setup: không đọc memory, inject, hook process hoặc can thiệp Vanguard. Phase tái tạo collector chỉ nghiên cứu các API/spectator interface được Riot cho phép. Build đạt; 35 unit tests đạt, gồm adapter LeagueBroadcast và provider selection.

## Hướng nguồn thay thế và reverse engineering an toàn, 20/09/2026

Đã xác minh giới hạn nguồn hiện có và ghi ma trận tại `DATA_SOURCES.md`. Overwolf GEP là lựa chọn hợp lệ nhưng tài liệu gold áp dụng cho người chơi cục bộ; chưa có bằng chứng cung cấp telemetry đầy đủ của 10 observer. Public LeagueBroadcast JS client chỉ bọc WebSocket, không chứa collector. Vì vậy không thêm hai nguồn này như provider hoạt động khi chưa có frame thật.

Phase tiếp theo là OBS capture + OCR cho những giá trị nhìn thấy trên HUD, trước hết team gold, kills, objectives và clock. Kết quả OCR phải có confidence, timestamp, profile vùng ảnh và hết hạn khi HUD đổi hoặc bị ẩn. Không suy total gold từng người từ team gold và không tuyên bố HP/resource 10 người từ ảnh không hiển thị chúng.

Dashboard Nguồn dữ liệu có thêm bảng ứng viên, yêu cầu cài đặt, độ phủ thực tế và ranh giới nghiên cứu. Ranh giới loại bỏ memory reading, injection, hook/driver, né Vanguard, decompile collector và giải mã replay/giao thức riêng khi chưa được Riot cho phép. Các hướng chấp nhận gồm API/Swagger loopback, SDK/WebSocket công khai, spectator service được cấp quyền và ảnh OBS.

## Presentation clock, 20/09/2026

Đã thêm lớp nội suy clock theo mô hình public LeagueBroadcast client: snapshot Riot là anchor, renderer cộng tuổi snapshot nhân playback speed; pause giữ nguyên và frame từ 5 giây trở lên chuyển unavailable. Kills, gold, item và các state rời rạc không bị nội suy. Session/sequence/epoch và seek detection hiện có tiếp tục kiểm soát event ordering. Thiết kế và điều kiện để dùng nhãn frame accurate được ghi tại `FRAME_ACCURATE_STATE.md`.

## LeagueBroadcast custom tournament xác minh thành công, 20/09/2026

Custom tournament spectator trên map 11 đã làm LeagueBroadcast 1.13.3 chuyển từ Loading sang Running. `/api/diagnostics/health` báo good khoảng 2 update/giây; asset cache 16.18 đạt 100%; `/ws/in` phát frame đủ 10 người. Điều này xác nhận replay/spec trận thường trước đó không phù hợp với luồng nhận diện, không phải lỗi cổng WebSocket hay asset.

Đã mở rộng adapter bằng dữ liệu `tabs.Order/Chaos`: HP, resource, phép bổ trợ và keystone. Item slot 7/8 riêng của provider bị loại, chỉ slot inventory 0 đến 6 được đưa vào contract. Kiểm tra live sau khi nạp lại backend: champion 10/10, level 10/10, KDA 10/10, CS 10/10, total gold 10/10, HP 10/10, resource 9/10, spells 10/10, keystone 10/10, inventory 10/10 và vision 10/10. Một champion resource-less có max 0 nên giữ missing đúng thiết kế.

Payload đã quan sát còn có team gold/kills/towers/tower plates/dragons/grubs, Baron và Dragon pit timer, inhibitors, ability cooldown và perk list. Các nhóm team/objective/event này chưa được normalize. Raw identity, player name, URL asset và field lạ tiếp tục bị loại khỏi frontend. 40 test và production build đạt sau thay đổi.

## Scoreboard, objective và snapshot live, 20/09/2026

Ghi chú nghiên cứu mới nhất 24/09/2026: xem `LEAGUEBROADCAST_FEASIBILITY.md`. Chỉ nghiên cứu, chưa triển khai thay collector. Capture mới `data/captures/2026-09-24T15-14-32-437Z` chỉ có Riot map 12/10 players và LeagueBroadcast OutOfGame, sau đó Loading/idle; backend 4310 không phản hồi. `latest.json` là lần chụp mới nhất, không phải lần chụp đầy đủ nhất. Bản tournament đầy đủ để kiểm thử vẫn là `2026-09-19T18-57-45-942Z`. Chưa xác minh nguồn free độc lập đủ state 10 người; SDK công khai chỉ là client. Người dùng ưu tiên bất kỳ phương pháp hợp lệ nào lấy đủ dữ liệu in-game, cần nghiên cứu kỹ trước triển khai.

Đã normalize scoreboard theo đội và timer hai hố từ LeagueBroadcast. Overlay đặt chênh lệch vàng dưới đội đang dẫn với dấu cộng, hiển thị chênh lệch vàng từng vị trí theo màu đội dẫn, số trụ, số rồng bằng icon và timer Baron/Rồng. Thứ tự item đã đặt slot gần tướng theo từng phía; vision score dạng số thực được làm tròn xuống để bỏ số lạ ở đầu hàng. Dashboard Nguồn dữ liệu báo riêng độ phủ vàng/kills/trụ, rồng và timer objective.

Đã lưu snapshot đầy đủ tại `data/captures/2026-09-19T18-47-08-742Z`: 41 frame WebSocket trong 20 giây, toàn bộ endpoint Riot Live Client/Replay, LeagueBroadcast/Swagger và API overlay. Dữ liệu trận, nhận diện người chơi và URL asset được giữ theo yêu cầu; chỉ credential kỹ thuật theo tên field authorization/password/secret/token/lockfile bị lọc. Script `npm run capture:live` tạo snapshot mới và cập nhật `data/captures/latest.json`. Bộ phát giả lập từ NDJSON chưa triển khai.

## Event objective, Role Quest và audit production — 26/09/2026

Đã đối chiếu toàn bộ ảnh trong `images/`, lấy `ingame new.png` làm baseline mới. Hàng năm icon dưới tên đội được xác định là Role Quest, không phải Feat of Strength cũ. Adapter LeagueBroadcast đọc item slot 8 bằng allowlist ID role/reward, không đưa tên/URL raw sang frontend; scoreboard live hiển thị năm icon mỗi đội và nhấn sáng quest đã hoàn thành.

Đã thêm event `DragonKill`, `BaronKill` và `DragonSoul` từ chênh lệch state LB. Dragon dùng phần tử mới trong danh sách rồng; Baron dùng cạnh false→true của buff trên player; Dragon Soul phát riêng khi đội chuyển từ 3 lên 4 rồng. Lần lấy mẫu đầu, reconnect, game status ngoài Running/Paused và clock tua ngược reset baseline để không phát lại lịch sử. Overlay giữ banner objective 7 giây.

Audit mới xác nhận các phần production còn thiếu: combat-minimal; damage physical/magic/true của **giao tranh gần nhất**; timer active item/Guardian Angel; level-up và completed-item animation trên portrait; gold ranking; team runes; Baron Power Play; inhibitor respawn; Dragon Soul takeover; transition giữa scene. Chưa tự động tính damage vì capture hiện tại chưa chứng minh combat trigger hoặc damage telemetry phù hợp. Snapshot đầy đủ đã xác minh cooldown Luden's Echo bằng `maxCooldown=12` và `readyAt` đếm về 0; Guardian Angel đã kích hoạt vẫn chưa có mẫu để chốt semantics.

Font hiện vẫn là Anton/Roboto Condensed. Baseline MSI mới gần typography LoL hơn; cần thử Beaufort for LoL và Spiegel từ gói tải chính thức của Riot. Chưa commit font asset khi chưa có file và xác nhận quyền dùng.

Kiểm chứng: `npm run build` đạt; 51/51 test đạt qua bundle esbuild + Node. `npm test` trực tiếp vẫn vướng `uv_os_get_passwd ENOMEM` của tsx trên Windows sandbox.

## Font LoL, giao diện Studio và kiểm tra mock — 26/09/2026

Đã tìm thấy gói người dùng tải tại `data/font-source`, kiểm tra hai family Beaufort for LoL và Spiegel rồi đưa sáu OTF cần thiết vào `public/fonts/riot`. `src/fonts.css` khai báo weight 400/600/700/800; Studio và overlay dùng Beaufort cho headline/team/score, Spiegel cho nội dung và control. Runtime không còn import Anton/Roboto Condensed.

Studio được làm lại theo bảng màu xanh đen, teal và vàng LoL, tăng tương phản, trạng thái focus, khoảng cách và hierarchy. Nhãn chính đã Việt hóa. Trang Studio và Phòng thử mở thẳng bảng điều khiển thay vì bảng chẩn đoán dài; menu module vẫn hiện và thao tác được trên màn hình hẹp. Dữ liệu demo mặc định vẫn tắt như quyết định trước.

Mock được kiểm tra bằng cả test và browser: đủ 10 người, role theo đội hình, 6 item, 2 phép bổ trợ, vàng hợp lệ; các control level, draft, lợi thế và objective tạo thay đổi xác định. Nút hạ gục rồng tạo cả timer lẫn dòng event hiển thị. Đã thêm test đảm bảo sáu file font tồn tại và có dữ liệu.

Kiểm chứng: browser desktop và viewport hẹp đạt; bật demo, phát kill/rồng, thấy dữ liệu và event rồi đã tắt demo lại. `npm run build` đạt; 54/54 test đạt qua bundle esbuild + Node. `npm test` trực tiếp vẫn vướng `uv_os_get_passwd ENOMEM` của tsx trên Windows sandbox.

## Đối chiếu snapshot với ảnh production — 26/09/2026

Đã nạp bản đầy đủ `2026-09-19T18-57-45-942Z` bằng provider Bản ghi offline và kiểm tra trực tiếp renderer OBS. Coverage thực tế: champion/level/KDA/CS/items/spells/gold/HP/perks/vision/respawn 10/10, resource 9/10; team gold/kills/towers/dragons và hai pit timer 2/2. Không bật demo và không dùng fixture để lấp field thiếu.

Đã sửa ba sai khác thấy ngay khi so với `images/ingame new.png`: renderer luôn giữ đủ năm slot Role Quest mỗi đội, dragon token lấy màu theo loại và toàn bộ typography live chuyển sang Beaufort/Spiegel thay Arial. Bản ghi xác minh một level-up 15→16 ở frame 23, inhibitor Red L1 còn khoảng 208 giây, chín perk mỗi player và cooldown Luden's Echo 12 giây chạy về 0,11 giây. Không có inventory transition, Baron buff, fourth dragon hoặc damage physical/magic/true trong cửa sổ 20 giây.

Kết luận UI/data: scoreboard thường và chênh lệch vàng đã có dữ liệu phù hợp; gold ranking, team runes, combat minimal/cooldown, inhibitor respawn có raw data nhưng chưa có scene/contract đầy đủ; damage dealt không có telemetry trong snapshot; Baron Power Play và Dragon Soul cần capture đúng thời điểm. Draft không thể xác minh bằng capture in-game này. Chi tiết theo từng ảnh nằm trong `VISUAL_AUDIT.md`.

Kiểm chứng sau chỉnh sửa: production build đạt; 54/54 test đạt, gồm kiểm tra đủ 10 icon Role Quest và class màu elemental dragon.

## Marker realtime cho custom — 27/09/2026

Đã kiểm tra logic snapshot: mỗi frame LB có `receivedAt` và state có `gameTime`, đủ ghép tin nhắn `STT - MM:SS` theo cửa sổ ±10 giây. Hạn chế cũ là capture tối đa 120 giây, không có marker và Ctrl+C có thể kết thúc trước khi ghi manifest.

`capture:lb` nay stream tối đa 4 giờ, tạo `active-lb.json`, tự reconnect và hoàn tất manifest khi nhận SIGINT/SIGTERM. `capture:mark` chỉ ghi vào phiên đang chạy, validate STT 1–11 và clock `MM:SS`, cho phép lặp STT. `capture:analyze` ghép marker với frame theo game clock ±10 giây, trả frame gần nhất/sai lệch và dùng wall-clock để tìm `gameStatus` quanh các mốc cấm chọn/loading chưa có game time. Chưa chạy capture custom thật ở mốc này.

Analyzer quét NDJSON theo stream thay vì nạp toàn bộ trận vào RAM. Production build, kiểm tra cú pháp ba script và 56/56 test đạt; test mới xác minh biên ±10 giây, frame gần nhất, gameStatus theo wall-clock và việc không ghi marker vào capture cũ.

Custom Phòng Tập ngày 27/09 đã ghi đủ 17 marker từ STT 2 đến 11, tập trung người chơi `yueliang#252` (Zed). Tuy nhiên LB chỉ xuất 40 state frame từ game time 54,811 đến 74,694 giây; log LB xác nhận lúc 13:46:23.165Z Farsight IPC2 lỗi FlatBuffer (`uoffset_t = 1`), sau đó `ClientDisconnected`, `Running -> OutOfGame`. Vì nguồn dừng trước marker STT 3 ở 01:40, các event cấp độ/item/GA/giao tranh/chết/rồng/Baron/nhà lính/kết thúc không có snapshot LB để kiểm chứng; marker không được coi là dữ liệu event. Đã bổ sung note tùy chọn, tuổi frame và cảnh báo nguồn stale >5 giây vào `capture:mark`; analyzer nay báo `sourceHealthyAtMark` để phân biệt event không xuất hiện với upstream đã chết. Lượt test tiếp theo cần khởi động lại LB sau lỗi và xác nhận marker đầu tiên báo nguồn khỏe trước khi tiếp tục chuỗi.

Kiểm chứng sau thay đổi: cú pháp hai script đạt, 56/56 test đạt qua esbuild + Node và production build đạt. `npm test` trực tiếp vẫn gặp lỗi môi trường Windows `uv_os_get_passwd ENOMEM` đã biết.

## Capture event Phòng Tập — 11/10/2026

Lượt mới sau Loading thất bại đã thu 2.304 state frame patch 16.20.0, Seotoww#2013/Aurora, và 27 marker. Đã xác minh level 1→2/2→3, inventory Stormsurge/Rocketbelt/GA, Rocketbelt cooldown 50 giây, GA maxCooldown 300 giây và readyAt (07:09 còn 279,34 giây), chết/hồi sinh, bốn rồng Blue và Soul suy ra, trụ đầu từ counter 0→1, Baron buff nhận/mất trên Seotoww, Red L1 bị phá/hồi sinh với timer 300 giây. Có Zhonya inventory nhưng chưa thấy cooldown activation; không tìm được field damage/combat/fight trong state. Chưa xác minh sát thương giao tranh, trigger combat tự động, Baron Power Play tổng thể hoặc payload kết thúc trận. Mốc 05:30 đã sửa về STT 6 theo người dùng; thêm STT 12 cho hạ trụ. Phân tích event theo nội dung note khi người dùng đổi STT.

Người dùng fast-forward Phòng Tập trước mốc nhà lính hồi sinh rồi tăng tốc replay; feed ghi playbackSpeed 2×/4×/8×. Capture bị dừng trước khi replay bắt kịp mốc kết thúc 22:13, snapshot cuối là 21:37.696; không quy khoảng thiếu này thành lỗi LB. Manifest đã dựng lại sau terminal interruption và pointer active đã xóa. Bằng chứng chi tiết tại data/captures/lb-2026-10-11T09-07-37-947Z/EVENT_FINDINGS.md (local, Git ignore). Bước tiếp theo dùng capture này làm regression cho event/cooldown/inhibitor; kiểm chứng end-game và Zhonya kích hoạt cần mẫu bổ sung. Chỉ thay đổi marker label/range nhỏ cho STT 12, chưa thay renderer.

## Hoàn thiện phần đã có và regression toàn project — 11/10/2026

Theo yêu cầu mới, tạm bỏ các mốc thiếu và triển khai phần đã xác minh. Contract/adapter thêm cooldown item/ultimate/phép, hasBaron và inhibitor timer; event level-up/item lớn (allowlist explicit), trụ và nhà lính phá/hồi sinh. Renderer có countdown Rocketbelt/GA và item có cooldown, countdown phép/ultimate, hiệu ứng level/item 3 giây trên portrait, dấu Baron và số player còn buff, nhãn Soul, timer nhà lính, feed structure, bảng level thật khi bật widget. Elder không tính vào Soul, ability chưa học không được báo ready vì cooldown 0. Timer item khớp slot+ID; timer hồi sinh tiến theo game clock, nhưng không tự bịa trạng thái hồi sinh khi hết số đếm.

Live minimal chuyển thành 10 thẻ nhỏ ở dưới qua **Giao diện & đội → Biến thể**, giữ HP/resource/phép/ultimate và item cooldown/GA; chưa auto combat. Giữ baseline mock/draft. Seek/reconnect/loss xóa hiệu ứng lịch sử, stale 5 giây bỏ dữ liệu và buff. Parser capture stream tối đa 512 MB/10.000 frame và hỗ trợ ID `lb-`; bản 194 MB đã nạp 2.303 frame hợp lệ (bỏ bootstrap trống), qua cùng adapter để phát event, không chỉ normalize tĩnh.

Kiểm chứng: `npm test` trực tiếp đạt **63/63**, không skip (gồm regression toàn bản ghi thật và validate mọi sample); `npm run build` đạt; `npm run test:integration` đạt HTTP/recording/6 probes/origin/method guard, WS đồng bộ và OBS read-only, scene/mock controls, validation, theme persistence/reset, provider, bản ghi lớn/pause/4×/seek. Test tích hợp tự mở backend 4311 và theme tạm; `RIOT_OVERLAY_THEME_PATH` giữ nguyên `data/theme.json` của người dùng. Browser kiểm tra panel/minimal với nguồn recording, đủ 10 slot, không icon hỏng, không background reference và không control trong renderer, body/canvas trong suốt. Canvas CSS 1920×1080 nhưng ảnh in-app bị giới hạn vùng preview; chưa có full-size OBS 1:1 và chưa kết luận pixel-perfect. Báo cáo đầy đủ ở `TEST_REPORT.md`.

Chưa làm: mọi item lớn ngoài allowlist; damage/combat trigger tự động; activation Zhonya/end-game thật; gold ranking/team rune scene; Soul takeover/Baron Power Play gold delta và transition production. Không coi nhãn buff là Power Play đầy đủ. Asset live vẫn 16.18.1, patch capture 16.20.0 chưa match được xác minh. Bước tiếp theo có thể test OBS 1920×1080 thực tế và hoàn thiện các scene còn lại bằng dữ liệu đã có; mốc telemetry thiếu chờ mẫu bổ sung khi người dùng sẵn sàng, không yêu cầu vào custom ở mốc này. Không push/publish.

## Phòng thử dùng snapshot thật và nút chức năng — 11/10/2026

Ghi chú bàn giao UI mới: xem mốc “Đo UI trực tiếp” ở cuối file; các mô tả bố cục/asset bên dưới phản ánh trước lượt hiệu chỉnh này.

Người dùng yêu cầu bật công cụ và thử mọi chức năng có thể có bằng dữ liệu thật. Phòng thử nay dùng `RealTestPanel`, tự chọn bản ghi có độ phủ frame lớn nhất khi chưa chọn recording; demo checkbox bị khóa trong module này. Nút capability được backend tính từ chính capture đã mở, không theo fixture. Có leaderboard gold/level, timer, minimal, hạ rồng, Soul, Baron Power Play, item/GA cooldown, chết/hồi sinh, trụ, nhà lính phá/hồi sinh, level/item effect, rune toàn đội và clear. Phát tiếp/pause cho timer. Nút không có dữ liệu bị disable kèm lý do; damage giao tranh vẫn khóa.

`rehearsal` là command chỉ cho Studio khi recording và demo tắt; nó tìm frame thực, tạm dừng ở mốc đó và chỉ chủ động phát lại event thật đã có trong sample. Cue có `playback.trigger=manual-rehearsal`; renderer ghi KÍCH HOẠT THỬ / SNAPSHOT THẬT, không gọi đây là event live mới. State rehearsal tạm không lưu vào theme; đổi nguồn/mock/reset xóa state, tua timeline xóa view thử. Renderer OBS vẫn chỉ đọc. `/api/rehearsal` có cùng Host/Origin/method guard với API nguồn.

Đã thêm bảng gold thật và bảng rune từ optional `perks` allowlist chỉ giữ tối đa 9 ID dương/người, loại raw metadata. Rune test chỉ khả dụng khi đủ 9 ID cho cả 10 người; asset thiếu hiện ID thay vì tên/icon đoán. Baron Power Play **offline thử** hiển thị thay đổi chênh vàng ròng hai đội giữa mốc nhận buff và snapshot còn buff khoảng 10 giây sau, có nhãn suy ra/mốc đo; chưa thành engine Power Play live, chưa có timer duration hoặc damage. Timer thật và các effect vẫn dùng contract hiện có, không sửa payload capture.

Kiểm chứng: 64/64 unit/regression, không skip; build production và integration đạt, integration gọi mọi nút theo availability (bao gồm rune), từ chối chức năng thiếu. Browser xác minh bản ghi 11/10 tự nạp; vàng Aurora 132.500 từ snapshot, Baron delta -20 ở mốc 11:58→12:08 có nhãn suy ra. Công cụ đã mở tại `http://127.0.0.1:4310/?page=demo`; đây là trạng thái phiên hiện tại, không bảo đảm process luôn chạy sau restart/máy khác. Theme người dùng không thay. Bước tiếp theo kiểm tra thêm bố cục/soul takeover và Power Play live theo source, không coi thử offline là hoàn tất scene production.

## Đo UI trực tiếp và cập nhật asset 26.20 — 11/10/2026

**Cập nhật Soul sau quyết định người dùng:** giữ bố cục, không dùng sponsor Riot. Đã dựng takeover ở (0,145)/286×600 và strip (715,113)/503×35; event DragonSoul thật quyết định đội/loại. Artwork riêng tạo bằng imagegen, không lấy nguyên screenshot/Riot sponsor; prompt và provenance ở `public/broadcast/artwork/PROVENANCE.md`. Đây là minh họa thay thế dùng chung/hue theo nguyên tố, chưa phải artwork chính xác từng rồng. Strip ghi thông tin Soul quan sát, không sao chép % hồi máu chưa xác minh. Hiệu ứng 7 giây, tạm chuyển player sang minimal rồi trở lại layout trước đó; không ghi theme. Build đạt, 67/67 test không skip, integration cô lập đạt. Browser QA 1920×1080 xác nhận panel/strip/minimal đúng rectangle, hết hiệu ứng trở về bảng đầy đủ, không broken image/reference/control OBS. Ảnh `.npm-cache/visual-audit/soul.png`. Các ghi chú “Soul chưa takeover” dưới đây là trạng thái trước cập nhật này. Chưa chứng minh 95–98% toàn overlay; tiếp tục cần đo cột con/alpha/branding và artwork không dùng làm điểm tương đồng Riot.

Theo yêu cầu mới, mở lại audit UI, dùng `ingame new.png` làm chuẩn in-game mới và các ảnh còn lại cho từng view. Đã xem cả 11 ảnh, tạo manifest rectangle và ảnh đánh dấu vùng; phân biệt graphics overlay với map/nameplate/game announcement, spectator HUD/minimap và input camera/sponsor. Dùng Edge headless đã cài + Playwright/sharp từ runtime, bấm nút thật trong phòng thử và chụp OBS trong suốt 1920×1080 DPR1. Không còn giới hạn screenshot sidebar; không ghi theme cá nhân, không đổi mock/draft baseline.

Nhánh live hiệu chỉnh scoreboard896×98 ở(512,10), hàng chính60px, timer mục tiêu nằm ngang103×48, Gold panel286×600 ở(0,145) có thanh tỷ lệ, minimal992×171 ở(464,909), Power Play170×60 ở(1414,12), Team Runes lower-third1346×287 ở(287,793), cạnh gold-gap màu đội. Chuyển icon cạnh tên và trên minimal từ keystone sang iconR thật; cooldown thiếu không được báo ready. Glyph Baron/air/fire/water/earth/trụ/vàng và5 Role Quest tách maskSVG từ ảnh nén, có provenance; không dùng screenshot HUD/số liệu làm UI. Chưa có glyph rõ hextech/chemtech/elder.

Live assets cập nhật Data Dragon **16.20.1** từ danh sách version Riot chính thức:173 champion,870 item,34 spell,72 rune/tree/shard,173 iconR; tổng1.322 PNG có manifestSHA256. MetadataR cùng patch; stat shard theo RiotCDN. Demo15.20.1 giữ nguyên. Font live thay thế Anton/OFL, không gọi là fontRiot gốc. Nhãn TOTAL GOLD đo15 biến thể chọn27px/padding9px; mask tĩnh dung sai1px đạtF1 **99,521%**. **Không phải điểm tương đồng toàn overlay; chưa chứng minh đạt95–98%.** Rectangle chính khớpDOM nhưng alpha/icon/cột con/branding và Soul takeover còn thiếu.

Kiểm chứng lượt cuối: `npm run build` đạt, `npm test`64/64 không skip, integration cô lập đạt; 7ảnh OBS không broken image/reference/control, rectangle khớp như báo cáo. GRUB chưa có glyph rõ nên giữ nhãn loại quan sát, không gán iconBaron choGRUB. Chi tiết phương pháp, giới hạn, kiểm chứng, lệnh tái chạy và phần tiếp theo ở `VISUAL_MEASUREMENTS.md`; artifact local trong `.npm-cache/visual-audit/`. Soul hiện vẫn banner/status, chưa artwork takeover; Damage vẫn unavailable. Đã hỏi người dùng chọn giữ sponsorRiot trongSoul hay chỉ giữ bố cục/nhận diện riêng, và xin asset gốc nếu có. Tiếp tục đo nội bộ từng vùng, không gộp điểm chữ thành95–98% toànUI. Không push/publish.

## Collector headless — phương án 2, nhánh nghiên cứu riêng — 11/10/2026

Người dùng yêu cầu triển khai host không UI tái sử dụng collector LB, thay vì dịch ngược toàn bộ field/hook. Thử nghiệm cô lập tại `.research/lb-headless/` (Git ignore); không sửa source/backend/UI đang được xử lý ở nhánh khác. SDK .NET 10.0.401 portable tải từ Microsoft, xác minh SHA512, nằm trong cache project. Chưa copy/phân phối DLL LB hoặc hoàn tất launcher cùng app.

Đã build CollectorHost, nạp thư viện Common/GameLib/Host/Farsight nguyên bản và resolve GameLibFetcher/AuthApiGatewayClient/IngameConfigFile. Đọc phiên đăng nhập hiện có trong bộ nhớ, gọi dịch vụ xác thực/làm mới chính thức thành công; so sánh trước/sau xác nhận file Credentials.bbd gốc không thay đổi. Không log/export token, không patch DLL, không giả feature grant, không bỏ version check hoặc thay đổi anti-cheat. Auth/update của BlueBottle vẫn là dependency; quyền phân phối lại thư viện chưa xác nhận.

LocalFarsightDataSource.StartAsync đã hoàn tất, IsActive=true và chờ game bằng detector riêng, không khởi động Interface.exe/WPF Application. HTTP/WebSocket loopback riêng thiết kế tại 4312; health phân biệt authenticated/collectorStarted/dataAvailable. Snapshot chưa có hoặc quá 5 giây trả unavailable/null, không lấp mock. Projection native có session/sequence, reset khi clock lùi, depth/list/body giới hạn, loại address/offset/buffer/credential. Schema lb-collector-native-v1 chưa tương thích ingame-state-update/adapter overlay hiện tại; chưa nối vào widget.

Kiểm chứng: build host 0 warning/error; 6 assertions SnapshotStore tổng hợp đạt; idle HTTP, WebSocket, missing-data 503/null và Host/Origin guard đạt. LB UI vốn còn chạy khi idle test; uiStarted=false chỉ chứng minh host không mở UI, **chưa chứng minh lấy được dữ liệu 10 người độc lập khi UI tắt**. Chưa có signed challenge/native module/snapshot trong game để kiểm chứng.

Bước tiếp theo cần người dùng: tắt LB hoàn toàn (tránh hai collector tranh IPC nội bộ 4998), mở replay hoặc spectator custom, rồi thu/kiểm tra Heroes/stat/objective và pause/seek/reconnect. Sau khi live đạt mới triển khai adapter và autostart cùng app ở nhánh source. README/lệnh/test của thử nghiệm tại `.research/lb-headless/README.md`; artifact ignored chỉ có trên máy này. Không coi port/process đang chờ là bảo đảm lâu dài.

### Ưu tiên mới: collector replay thấp hơn live — 11/10/2026

Người dùng bổ sung điều tra telemetry khi spectate replay `.rofl`, đánh dấu **ưu tiên thấp**. Live headless vẫn là việc chính; thay hướng “mở replay trước” trong bàn giao cũ và README thử nghiệm bằng spectator custom live trước. Không yêu cầu vào trận/replay riêng cho nhánh thấp lúc này.

Điều tra tĩnh thư viện đang cài: detector cửa sổ kiểm tra PID/tên executable, chưa thấy phân biệt replay/live trong chính hàm đó; log “inactive game” thuộc nhánh database và có thử StartNextGameAsync, không tự chứng minh native từ chối replay. Có Replay API và GameRewind ở lớp controller; vẫn có NotSpectatorException riêng. Chưa biết điểm ngăn `.rofl`, chưa có dữ liệu thật từ replay khi LB UI tắt. Chỉ sửa tài liệu/thứ tự kiểm thử, không thay collector/UI hoặc bỏ kiểm tra mode/version/auth. Kế hoạch và bằng chứng theo tầng tại `LEAGUEBROADCAST_FEASIBILITY.md`, ưu tiên tại `ROADMAP.md`; không cần chạy test ứng dụng cho lượt tài liệu này.

### Tiếp tục điều tra với skill REA — 11/10/2026

Đã cài skill reverse-engineer-anything bằng skill-installer và REA CLI 6.4.0 vào cache riêng; dùng Node 24.19 đã có, không đổi Node hệ thống/package overlay/MCP config và không cài engine native. REA chỉ xác minh artifact identity, member parser chạm budget 64 MiB trên Farsight/Common; ghi coverage unavailable, không dùng làm bằng chứng đã giải mã CIL. Tiếp tục bằng inspector dnfile/dncil. Ledger chi tiết local ignored: `.research/lb-headless/REPLAY_FINDINGS.md`.

Khoanh vùng mới: spectator gate dùng activeplayername cổng 2999, chấp nhận Unknown/Spectator/RPC_ERROR; 404 còn chờ đến cancellation. GameStarted theo sau kết nối/cấp feature; polling cần capture/native started/connected. Replay khác phản hồi ở gate là giả thuyết, chưa có mẫu runtime. Probe ngoài trận xác nhận không game/LB UI và 2999 unreachable, không chứng minh replay bị chặn.

Source CollectorHost thử nghiệm đã sửa lỗi GameInfoReceivedEventArgs.GameInfo khai báo object, hỗ trợ generated subclass; thêm health diagnostic và event counts, không xuất message/token/challenge. Build 0 warning/error, 9 assertions tổng hợp đạt; syntax probe và idle HTTP/WS/null/Host/Origin đạt. Đã dừng phiên agent cũ và khởi động bản mới khi không có game; không đụng process người dùng. Source/UI overlay không thay. Chưa xác minh telemetry live độc lập hoặc replay đầy đủ; bước cần người dùng vẫn spectator live khi LB UI tắt, replay cùng patch là ưu tiên thấp sau đó. Trạng thái process/port không là bảo đảm lâu dài.
