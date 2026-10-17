# Lịch sử bàn giao đến 17/10/2026

Đây là nhật ký cũ, giữ để tra cứu bằng chứng. Đọc PROJECT_STATUS.md ở thư mục
gốc để biết trạng thái hiện hành. Các đường dẫn trong nhật ký tính từ gốc project.

## Thử Riot API và tìm được metadata ROFL, 17/10/2026

Key người dùng nhập ở postgame: status configured=true, Standard, chỉ RAM.
Dùng service backend hiện có để load/stage (không publish): custom
VN2_1607368559 trả upstream404; control trận thường VN2_1607651234 trả upstream403.
Không kết luận key hợp lệ chỉ từ configured; chưa xác định 403 do quyền/key
hết hạn hoặc nguyên nhân khác. Dừng nhánh bị từ chối, không thử key Standard
làm RSO token hoặc thử endpoint để vượt quyền. Không restart server hoặc đọc key.

Nguồn khác đã kiểm thành công: `.rofl` cùng trận hiện có trên máy. Metadata
cuối file chứa 10 người/5+5 và final damage/KDA/gold/winner; đối chiếu 10/10
khớp LCU đã lấy khi login player. Yasuo40241, Smolder4366, Veigar5889.
Không cần đăng nhập player để đọc file đã có, không giải mã packet hay sửa file.
Elder counter metadata=0 trái ledger, lane rỗng, chart vàng vẫn cần archive.
Chưa tích hợp import/publish production; chưa chứng minh spectator lấy được
file custom mới. Hướng ưu tiên: import/stage metadata replay + reconcile archive.
Chi tiết `docs/ROFL_POSTGAME_FINDINGS.md`, probe `scripts/probe-rofl-postgame.mjs`.

## LCU custom khi đổi sang spectator, 17/10/2026

Đã kiểm lại cùng game 1607368559 sau user logout player và đăng nhập spectator.
Lockfile mới/current-summoner khác target Riot ID; search đúng người trả 200,
history trả 20 trận thường, 0 custom và không có game đã chỉ định. GET game
detail và timeline đều 404. Biết game ID không đủ ở tài khoản spectator trong
trường hợp này; không bypass hoặc dùng lại auth phiên cũ. Bằng chứng 200 ở
phiên player vẫn là evidence riêng, không phải nguồn đang đọc được từ spectator.
Hướng đề xuất: agent/export JSON kết quả LCU từ máy một người tham gia sau trận
rồi import/stage tại Studio; chưa triển khai. Xem `docs/LCU_POSTGAME_FINDINGS.md`.

## Animation draft và bằng chứng LCU custom, 17/10/2026

Đã thêm motion vào cả draft broadcast/simple: khung xuất hiện trước, hai cụm
đội trượt từ hai bên, portrait reveal khi hover/đổi tướng, flash khóa pick/ban
và nhãn chuyển lượt. Key theo champion/locked, không theo timer; giữ geometry,
asset và cửa sổ cam caster trong suốt. Có prefers-reduced-motion.
Build đạt; 217 unit (216 đạt, 1 bỏ qua). Browser smoke 20 lượt/undo/skip/swap,
hai layout, assets/fonts/transparency và 1280px đã đạt. Kiểm thêm ảnh hover
không remount khi timer tick và reduced-motion đạt; log
`.npm-cache/draft-motion-browser-final.log`.

Postgame: GET LCU thật cho Riot ID Seotoww#2013 và game 1607368559 trả CUSTOM_GAME,
786s, đủ 10 người với damage lên tướng/KDA/vàng/winner. Raw ghi chính xác
VN2-1607368559, chứng minh cùng trận archive đang dùng. Timeline có 15 frame
và gold. Chưa nối candidate/publish production; không coi mọi custom đều hỗ trợ.
Lane NONE, dragonKills gộp Elder cần nguồn ledger/timeline để tách.
Chi tiết và hướng triển khai: `docs/LCU_POSTGAME_FINDINGS.md`.
Lượt probe bổ sung dừng vì client không còn lockfile, không tự mở lại client.

## Điều tra 18+ VNG trong HUD, 17/10/2026

**Tạm hoãn theo yêu cầu người dùng.** Tiếp tục sau, không triển khai che OBS
hoặc sửa game. Ảnh đã xác nhận sign native ở (0,0), khoảng 168×28px trên
1920×1080. Chỉ mới tìm được install path `E:/Riot Games/League of Legends`
từ metadata Riot; chưa phân tích hay sửa tài nguyên game/tiến trình. REA MCP
không có trong phiên, chưa cài/repair tool. Hướng sau: config/tài nguyên HUD
chỉ đọc và bằng chứng runtime được duyệt, không coi CSS client web là giải pháp.

GET Replay API thật đã có kết nối, không thấy field riêng để ẩn age/rating/
VNG/watermark; chỉ đọc, không đổi HUD, replay hoặc config. Chưa có giải pháp
ẩn riêng native được xác minh. Giải pháp CSS PenguLoader tìm được nói về
client web, không áp vào ingame. Cần ảnh game có sign và quyết định nếu phải
che ở đầu ra OBS; chưa triển khai che hoặc thêm nút giả không hoạt động.
Chi tiết `docs/HUD_GAME_RUNBOOK.md`.

## Vòng lane quest và timer mục tiêu thu gọn, 17/10/2026

Sửa SVG progress 32px/inset -1px trong khung header 31px: dùng --quest-size
22px/31px theo parent và căn tuyệt đối 50%/translate(-50%). Glyph cũng căn
tuyệt đối trước optical offset, bỏ tác động grid đẩy xuống 0.5px ở header.
Browser QA cả 4 layout xác nhận box SVG, tâm circle và tâm thân glyph khớp
khung dưới 0.1px; không sửa asset hoặc giá trị tiến trình.

Timer hang rồng/Baron dùng màu loại mục tiêu cho nền ô icon với alpha 22%,
icon 28px trong ô vuông 38px. Nền Elder powerplay giảm tỷ lệ màu từ 27%
xuống 17%. Khi remaining về 0, không hiện LIVE; phần số/khung thu ngang
trong 0.35s, còn ô icon; khi countdown trở lại thì mở ra. Null vẫn --:--,
không được coi là 0. Tôn trọng prefers-reduced-motion. Không thay logic nguồn.

Build đạt; 217 test có 216 đạt, 1 bỏ qua. Browser QA 9 mốc dữ liệu thật
đạt màu theo loại, kích thước icon/ô và panel 103px → 46px sau animation.
Logs `.npm-cache/quest-ring-final-browser.log`, `timer-square-browser.log`;
ảnh trong `.npm-cache/living-dragon-qa/`. Không đổi theme/controls Studio chính.

## Thứ tự lane và chốt Atlas/XP, 17/10/2026

Presentation hai đội sắp Top → Jungle → Mid → Bot → Support theo roleQuest
có availability observed. Người thiếu lane để cuối theo slot gốc, không đoán
lane từ tướng. Không đổi slot trong raw/contract, giữ identity cho events,
counter và nickname override. Chênh vàng ghép sau khi sắp; nếu lane hai người
khác nhau hoặc chỉ một phía có lane thì không so chéo. Bảng rune và các bố
cục ingame dùng chung presentation; leaderboard vẫn xếp theo gold/XP.

Đã chốt ba yêu cầu: ẩn quantity Atlas 3865 nhưng giữ nâng cấp; lòng thanh
XP bằng HP/resource; sắp lane hai đội. Build đạt, 217 test (216 đạt, 1 bỏ qua).
Browser QA tại 8:44 kiểm đúng tên/thứ tự 10 người, Atlas xanh không số và
3866 đỏ còn 1; cả bốn layout cam/no-cam × full/simple có khung/lòng thanh
XP/HP/resource cùng vị trí và chiều rộng, sai số dưới 0.1px.
Script `scripts/verify-atlas-xp.mjs --assert`; log `.npm-cache/atlas-xp-final.log`.
Không đổi nguồn hoặc vị trí phát của Studio chính, không sửa theme người dùng.

## Số Atlas và chiều dài lòng thanh XP, 17/10/2026

ItemCounter chỉ ẩn quantity của Atlas Thế Giới gốc (3865); giữ nguyên field
nguồn và số trên 3866/3867/các reward support, kể cả ô quest/slot 8 và số 0.
Đối chiếu snapshot 8:44.428: support xanh 3865 quantity 1 bị ẩn, support đỏ
3866 quantity 1 vẫn hiện. Test tất cả 7 ID nâng cấp, không đổi projection.

Đo 1920×1080: khung XP/HP/resource bằng nhau, nhưng XP không có viền nên
lòng màu dài hơn 2px. Thêm border-inline 1px giống HP/resource, giữ nguyên
chiều cao XP 3.6px và data %. Script QA: `scripts/verify-atlas-xp.mjs`.

## Viền giữa bảng và tâm icon lane quest, 17/10/2026

Bỏ viền đỏ 3px chạy suốt cạnh phải cột chênh vàng, thay bằng viền mảnh
trung tính 1px giống cạnh trái. Giữ arrow và các vạch màu riêng từng hàng.
Khung glyph lane vốn đúng tâm nhưng hình SVG 23×24 có padding lệch;
thêm data-role và optical offset theo bounding box thân glyph của 5 lane.
Không sửa asset lane/inhibitor, vòng progress hoặc icon đồ quest hoàn thành.
Build đạt; 215 test có 214 đạt, 1 bỏ qua. Browser 1920×1080 xác nhận hai
viền bằng nhau và tâm thân 9 glyph đang hiện lệch dưới 0.1px so tâm vòng.
Script `scripts/verify-scoreboard-alignment.mjs`, ảnh trong `.npm-cache/`.

## Đã triển khai indicator rồng sắp xuất hiện, 17/10/2026

Adapter hiện ưu tiên quái rồng sống, sau đó đọc chính xác
`particleEmitters[].info.name`: `Dragon_Indicator_<type>` hoặc tên có đường
dẫn/đuôi `.troy`, cho 6 nguyên tố và Elder. Không dùng lịch sử hạ rồng hoặc
linh hồn để đoán loại rồng tiếp theo. Nhiều indicator khác loại không tự chọn;
không cache indicator qua frame/seek. Marker không khẳng định quái còn sống
và không cung cấp thời điểm spawn; countdown vẫn ghi `rule-estimate` nếu
phải tính từ event/quy tắc mặc định. Quái sống hiện LIVE.

Projection 10: `2026-10-17T02-41-50-859Z`, từ raw gốc 16/10, 1.525 mẫu.
Đối chiếu toàn bộ với projection 8: chỉ khác field `pitTimers`. Đã nạp vào
Studio chính, giữ vị trí phát/các nút điều khiển và không sửa theme người dùng.
Browser QA 1920×1080 đạt 9 mốc: 0:30/4:40 Hóa Kỹ chờ, 5:00 Hóa Kỹ LIVE,
7:15 Hextech chờ, 8:50 Hextech LIVE, 9:10 Đất chờ, 9:30 Đất LIVE,
11:30 Elder chờ, 11:45 Elder LIVE. Ảnh `.npm-cache/living-dragon-qa/`;
log `.npm-cache/dragon-indicator-browser.log`.
Build đạt; 215 unit test (214 đạt, 1 bỏ qua); system/transport integration đạt.
Raw, projection cũ và vị trí replay LoL không thay đổi. Chưa test toàn trận live mới.

## Kiểm chứng chỉ báo rồng sắp xuất hiện, 17/10/2026

Probe collector tạm không tài khoản, không đổi nguồn Studio/seek replay:
ở 2:05.095 có `Dragon_Indicator_Chemtech`, user xác nhận Hóa Kỹ;
ở 16:38.769 có `DATA/Particles/Dragon_Indicator_Water.troy`, user xác nhận
rồng Nước. Mẫu thứ ba tại 11:30.932 có
`DATA/Particles/Dragon_Indicator_Elder.troy` trong ba snapshot liên tiếp,
chưa có quái rồng sống. Ba snapshot liên tiếp ở mỗi vị trí đều nhất quán, chưa có quái
`sru_dragon_*` sống. Field nằm ở `data.particleEmitters[].info.name`.
Host chẩn đoán sở hữu đã dừng, không cần LB gốc. Không dùng chỉ báo để
khẳng định đã có quái sống hoặc bịa thời điểm spawn.

Raw gốc 16/10 đã đối chiếu: Hóa Kỹ từ 20.799; đổi sang Hextech ở 410.023,
Đất ở 541.267, Elder ở 675.225; có khoảng trống ngắn giữa các chỉ báo.
Đây là nguồn candidate cho loại rồng tiếp theo trước spawn, đã kiểm Nước
Hóa Kỹ và Elder trực tiếp; chưa kiểm trực tiếp đủ mọi loại.
Indicator sau đó đã được nối vào adapter/renderer và projection 10, xem mốc
triển khai phía trên. Các mẫu trực tiếp không thay thế test toàn trận live mới.
Probe: `scripts/probe-next-dragon.ts`; log local trong `.npm-cache/`.

## Loại rồng đang sống từ collector, 17/10/2026

CollectorGameplay bổ sung `pitTimers.dragon` từ đúng identifier của quái
trong snapshot hiện tại, health > 0 và trạng thái sống. Không dùng identity
cache dành cho death event để khẳng định quái còn sống. Snapshot có nhiều
loại rồng sống cùng lúc không tự chọn một loại. Contract thêm `isAlive`
tùy chọn, tương thích bản ghi cũ; không bịa thời điểm spawn. Renderer ưu tiên
loại quan sát được và hiện LIVE, kể cả khi timer theo quy tắc phòng tập khác.
Khi chưa có quái quan sát được, fallback timer theo quy tắc vẫn ghi provenance
`rule-estimate`, không phải telemetry rồng sống.

Projection 9: `2026-10-17T02-18-56-031Z`, 1.525 mẫu từ raw gốc
`2026-10-16T12-43-43-938Z`; bản cũ và raw gốc không sửa. Đã đối chiếu mọi
mẫu với projection 8: chỉ khác `pitTimers`. Browser QA xác nhận 4:40 chưa rõ
loại, 5:00 Hóa Kỹ LIVE, 8:50 Hextech LIVE, 9:30 Đất LIVE. Script kiểm tra:
`scripts/verify-living-dragon.mjs`; ảnh `.npm-cache/living-dragon-qa/`.
Build đạt; 214 unit test (213 đạt, 1 bỏ qua); system integration đạt.
Đã nạp projection mới vào Studio và giữ vị trí phát/các nút vận hành khi cập
nhật backend. Theme cá nhân không đổi. Chưa kiểm live mới.

## Trùng tu Studio shadcn, 17/10/2026

Checkpoint trước sửa UI: `7c79bb1` (local, không push). Mốc counters/UI trên
bản ghi và tài liệu trước đó được bảo toàn trong commit này, không có captures,
theme cá nhân hoặc credentials.

Studio đã dùng 7 component shadcn/ui chính thức, Tailwind 4 không preflight,
Lucide và font Segoe UI; theme xám trung tính scope `.studio-shell`. Menu 8 trang
LoL chia theo thao tác, bỏ menu kế hoạch/placeholder game khác khỏi luồng chính.
Preview phát sóng và điều khiển đặt cạnh nhau, card có preview widget nhỏ;
nút hiện/ẩn có trạng thái bật. Cấu hình theo lưới, giữ đủ tên/tỉ số/logo/override.
Xóa màn hình legacy không còn dùng; bỏ nội dung lấp chỗ trống, session/sequence/revision
trên màn vận hành, em dash/dấu chấm giữa từ và ghi chú sửa lỗi dư. Giữ lỗi,
cảnh báo dữ liệu mẫu/mất nguồn và khả dụng. Chẩn đoán chi tiết thu gọn, không tắt field.

Tám route đã kiểm bằng trình duyệt: overview/theme/sources/studio/demo/draft/postgame/hud.
Lưu config, bật/tắt vàng, phát/tạm dừng bản ghi và responsive 900px đạt,
không tràn ngang hoặc page error. OBS 1920×1080 nền trong suốt. Source overlay,
backend/shared không đổi so checkpoint; Data Dragon/stack/damage không đổi.
Audit không báo lỗ hổng sau cập nhật source-map-js. Build đạt; 213 unit test
(212 đạt, 1 bỏ qua); system integration đạt. Báo cáo/ảnh `.npm-cache/studio-shadcn-qa/`.
Hướng dẫn: `docs/STUDIO_UI.md`. Các giới hạn thật ở báo cáo phase vẫn còn;
không tuyên bố damage/native 9 champion đã được giải quyết bằng sửa giao diện.

## Mốc trước trùng tu Studio bằng shadcn — 17/10/2026

Theo yêu cầu user, chốt tài liệu và commit trạng thái hiện tại trước khi đổi
Studio. Baseline overlay draft/ingame/postgame, data contracts, capture gốc và
theme local giữ nguyên. Báo cáo phase: `docs/PHASE_HANDOFF_2026-10-17.md`.
Build đạt;209tests208pass/1skip; system/transport/collector integration và
browserQA1920×1080 đã kiểm. Native9champion/giày3008/EOGdamage vẫn cần dữ liệu.

Bước tiếp: thay UI vận hành bằng shadcn, màu trung tính dễ nhìn lâu, phân cấp
nút rõ ràng, bỏ trang trí và nội dung debug/confirm dư, không em dash/dấu chấm
giữa từ trong copy Studio. Giữ cảnh báo quan trọng (mất nguồn, dữ liệu mẫu,
trường chưa có); đưa chẩn đoán chi tiết vào phần nâng cao. Không thiết kế lại
renderer OBS hoặc thay logic dữ liệu. Commit local, không push.

## Chốt rà soát các yêu cầu hiện hành — 17/10/2026

Tổng hợp/checklist: `docs/PHASE_HANDOFF_2026-10-17.md`. UI/counter trên dữ liệu
đang có hoàn thành; chưa tuyên bố đủ native9champion hoặc damage postgame.
Thêm quantity potion/control ward từ Live Client theo count thật, không suy
stack/ammo từ count1. Build đạt;209 tests208pass/1skip; system integration và
transport trên QA riêng đạt, collector integration đã đạt. Browser1920×1080
đã kiểm nickname/XP/rune/quest/banner và4 layout stack với badge26px.
Đã cập nhật tài liệu26px, VeigarP, placeholder0 không phải observed0; giữ
original capture/theme. Không commit/push. Bước cần user: custom kết thúc,
giữ màn kết quả để kiểm LCU EOG; bổ sung HUD các tướng stack/giày3008 nếu có.

### Badge stack simple tăng30% — 17/10/2026

Theo yêu cầu mới, badge stack simple26×26px (trước20×20), right0/bottom0
trong ultimate40px. Số tăng tương ứng lên khoảng13px, vẫn trắng/không nền.
Full layout không đổi. Đây là quyết định mới thay tỷ lệ50% trước đó.

## Champion stack và item counters — 17/10/2026

- Triển khai `championStacks` optional observed: native chỉ exact2 buff đã
  kiểm (Smolder32/Veigar77 ở cuối bản ghi); LB direct `tabs.players.stacksData`
  cho11 tướng. Không tự tính từ AP/CS/ability charges. Native9 tướng khác vẫn
  chưa có mapping xác minh, không tuyên bố đủ telemetry chỉ vì có icon.
-11 icon PNG2D Riot16.20.1, theo yêu cầu user; Veigar đổi sang nội tại
  (quyết định mới nhất), NasusQ/ChogathR/SionW,8 tướng còn lại nội tại.
  Full dùng stack thay rune phụ, camera ưu tiên hơn lane reward. Tất cả hàng
  dùng cùng cột rune30px để Smolder/Veigar không lệch. Simple badge tròn26px
  trong R40px góc dưới phải; sweep/countdown giữ circle. Chữ số trắng không
  nền, shadow nhẹ. User yêu cầu thiếu thì hiện0: placeholder UI, data vẫnnull.
- `itemCounters` tách stack/quantity và giữ slot8. Tear charges cuối330;
  potion/count, trinket/ammoCount0–2, support3866/charges1–3. Chữ điểm dưới
  giữa, stock dưới phải, cả reward lane. Ưu tiên slot8 khi cùng item2055 có
  trong inventory. Giày Phàm Ăn3008 xác định từ Riotvi_VN, có rule direct
  charges nhưng chưa có runtime/HUD sample; không suy từ takedown.
- Projection8 `2026-10-16T19-49-29-104Z`:1525 samples/7331 nativeframes,
  original và các projection trước giữ nguyên. Đã nạp app chính, giữ vị trí
  và controls thực tế lúc restart, không lưu đè theme người dùng (hash cũ
  giữ nguyên). Không hứa process/port tồn tại lâu dài.
- Build đạt,208 tests:207pass/1skip; collector project integration đạt.
  Browser QA4 camera/layout variants1920×1080 xác nhận stack32/77/Tear330,
  các cột cùngX(<1px), badge đúng26/40 và không vượtR, assets tải được,
  số trắng nền transparent, không pageerror. Ảnh `.npm-cache/stack-ui-qa/`.
  Xem `docs/CHAMPION_ITEM_COUNTERS.md`. Chưa trận live mới hoặc test giày3008.
  Không commit/push. Bước tiếp đối chiếu HUD thêm các tướng/item còn thiếu.

## Nickname, XP ranking và rune — 17/10/2026

- Theo yêu cầu user, cho phép duy nhất nickname hiển thị `playerName` trong
  observed contract, bỏ #tag; không đưa account ID/PUUID/networkId/token/raw
  provider sang widget. Collector lấy `info.name`, Live Client ưu tiên
  riotIdGameName/riotId/summonerName; LB qua allowlist. UI bảng tuyển thủ,
  cả2 ranking và tooltip killfeed dùng chung resolver. Config có10 ô ghi đè,
  ưu tiên override→nickname→champion; tên không được bịa khi thiếu. Khi đổi
  bên, đổi cả5 override mỗi đội. Schema optional tương thích bản ghi cũ.
- Original capture giữ nguyên. Projection6
  `2026-10-16T19-21-14-286Z` có1525 samples/7331 native frames; Yasuo xác nhận
  nickname `Seotoww`, bot có tên nguồn như `Veigar Máy`. Events/CS/buff không
  thay đổi so projection5; không nhập dữ liệu preview vào recording.
- XP+LVL hiện% tiến trình và level trong ô viền màu đội. Hai ranking có viền
  progress nhạt, phần trống xám9%. Màu phụ lấy median vùng thanh XP trong ảnh
  mới: xanh#0373E0 (crop78,232–190,236), đỏ#BA191C (76,281–98,285).
  Migrate lúc đọc màu mặc định cũ; giữ màu custom và không ghi đè theme local.
- Bỏ generic banner giữa màn hình “đội đã hạ” mục tiêu; strip tên rồng,
  soul, trụ đầu, powerplay/timer/counter vẫn riêng. Quest completion nền đen
  .94, background và copy slide cùng nhịp portrait3840ms, giữ3s; simple ẩn.
- Rune tạm thay bảng tuyển thủ ở cả2 layout, không đổi control layout;
  tắt sẽ khôi phục bảng. Card202px để đủ9 perks; tên đội màu chính và logo
  có điều kiện xếp bên dưới, không logo không thêm placeholder.
- Stack/damage: audit7331 snapshots xác nhận SmolderQPassive.count0→32,
  VeigarPhenomenalEvilPower.count0→77; field/UI stack đã triển khai ở mốc mới
  phía trên (đoạn này giữ lịch sử audit trước triển khai).
  Damage21296 payload khác nhau đều damageDealt0, bao gồm2711 target hero;
 1586 Riot reference không có numeric damage. Premium có thể liên quan nhưng
  chưa chứng minh nguyên nhân; không vượt entitlement hoặc giả damage0.
  Ưu tiên kiểm chứng LCU EOG ở custom đã kết thúc; chưa có response đủ10 người.
  Xem `docs/NATIVE_STACKS_DAMAGE_FINDINGS.md`.
- Kiểm chứng: build đạt; unit suite199 (198 đạt/1skip), gồm test logo;
  collector project integration đạt. Browser QA isolated1920×1080 xác nhận
 10 XP rows,%/box, hai layout rune không đè bảng và không tràn1080, quest thật
  có background/copy slide, simple ẩn; không pageerror. Report và ảnh tại
  `.npm-cache/name-ranking-qa/`. Chưa chạy trận live mới, không tuyên bố95–98%.
  Browser cũng xác nhận tên đội dùng màu chính. Theme local SHA256 giữ nguyên
  `9C13D86AB1EE0C03CE7A6501A8666B6589FA223DA9F23A3D2A17FE1690A1D7E9`.
  Đã nạp projection6 vào app chính và giữ vị trí/operator controls tại thời
  điểm restart, không hứa trạng thái process/port sẽ tồn tại lâu dài.
  Không commit/push. Bước tiếp kiểm chứng EOG khi user chạy custom kết thúc.

### Căn số cấp simple — 17/10/2026

Số cấp simple căn giữa ô24×29px bằng grid, chỉnh vị trí1px để khớp strip
cấp/XP/HP/resource và bỏ padding cũ. Đặt trắng#FFF, z4 trên nền strip kế tiếp
để không bị làm xám do thứ tự lớp; không đổi text/bars ở layout đầy đủ.

## Bộ mix mục tiêu, powerplay và player bars — 17/10/2026

- User chọn mix: grub quay về `/broadcast/objectives/grubs.svg` trước lần
  đổi bộ; Baron dùng nguyên `baron.svg` gốc, copy bất biến sang
  `public/broadcast/objectives/mixed/baron.svg`. Manifest/hash và script
  `scripts/sync-mixed-objectives.mjs`; không sửa file user. Các rồng/Herald
  khác giữ bộ đã duyệt, lane/inhibitor không đổi. HTML offline đã tái xuất
  theo cùng mapping; PNG/SVG nhúng sẵn, khoảng51KB.
- Elder giữ silhouette spectator cùng kiểu mẫu, đổi cyan đo từ ảnh mới
  `#1EE4DE`, ghép backplate cyan tối + timer đen. Không khẳng định pixel-perfect
  từ ảnh nén. Bỏ tên đội trên Elder (chỉ icon/timer/progress); vẫn giữ owner
  metadata và vị trí theo đội. Baron/Elder thêm progress5px dưới cả icon và
  nội dung,100% bề ngang bên trong border; màu trùng icon,180/150s game clock,
  thiếu clock/endAt thì unavailable, không bịa phần trăm.
- Buff portrait giữ đỉnh tint .128/Elder glow .4 và nhịp hiện tại; bốn gradient
  alpha mờ từ viền vào30%, vùng giữa40% không có lớp tint. Pixel test style-only
  tại đỉnh nháy: nền giữa32,32,32 không đổi, viền Baron47,39,54/Elder57,56,54.
- Simple: champion58px = lưới2×2 icon29px. Hai spell vừa58px; reward cạnh spell,
  hai active sát chiều cao portrait, active thứ3 vừa strip cấp/HP/resource29px;
  active tiếp theo không hiện (nguồn inventory không bị xóa). Chưa xong quest
  thì active đẩy lên vị trí reward. Đối xứng hai đội, camera/no-camera.
- Cue lên cấp/item ở simple giữ750ms, tổng1590ms gồm vào420/ra420; full giữ
 3000ms/tổng3840. Quest completion riêng không đổi. State lifetime theo cùng
  layout, không chỉ rút animation rồi còn DOM trắng.
- Thêm XP track ngay trên HP ở cả hai layout, cùng chiều rộng HP; màu median
  ảnh mới `#7E3C75`, cao3.6px so HP/resource6px (60%). XP từ tổng native và
  ngưỡng SR hiện có; thiếu/cấp ngoài ngưỡng hỗ trợ giữ unavailable, không fake.
- Native có resourceType nhưng adapter cũ chưa chuyển sang sample. Bổ sung
  sourceStats.resourceType:0mana xanh,1energy vàng `#C8D94B` đo theo mẫu,
 4/5/6/8 nộ,11flow; thiếu/không rõ neutral chứ không mặc định mana. LeeSin
  slot6 thật là1. Resource khi chết vẫn0, XP không bị ép0.
- Projection5 mới `2026-10-16T18-48-05-645Z`:1.525 mẫu từ7.331 native, giữ
  original12:43 và mọi bản cũ. Đổi này chỉ thêm resourceType, không đổi các
  event/counter của projection4 (quest3,dragon5,Baron1,...).
- Build đạt,193 unit:192pass/1skip. Edge1920×1080: minimal4 biến thể đạt,
  progress powerplayfull-width/color/47% và86% tại12:20; hold đo749.9998ms;
  XP3.59375px/HP6px (subpixel), LeeSin vàng ở full/simple. Test thật và fixture
  hình học/pixel được phân biệt. Artifacts dưới visual-audit:
  `mixed-powerplay-real.png`, `player-bars-{full,simple}-real.png`,
  `minimal-{camera,no-camera}-{complete,pending}.png`, `mixed-icon-catalog.png`.
  Script kiểm chứng `scripts/mixed-powerplay-smoke.mjs`, không mutate theme chính.
- Chưa có lượt live mới sau thay đổi. Damage/end-game/Elder live thiếu telemetry
  từ trước giữ giới hạn, không dùng preview thay dữ liệu thật. Không commit/push.

### Xuất catalog icon offline — 17/10/2026

`exports/dragon-baron-icons.html`: tên và hai bản màu/trắng của7rồng,
rồng chưa xác định,3loại hangBaron. PNG nhúng dataURL, không JS/CDN/font ngoài,
mở offline. Script tái xuất `npx tsx scripts/export-objective-catalog.ts`.
Không đổi renderer, dữ liệu, theme hoặc các bộicon khác.

### Line góc simple và trạng thái logo — 16/10/2026

Theo ảnh bộ tối giản, line góc giữ5px xuyên suốt, chỉ alpha mờ dần ở đầu
dọc phía trên và đầu ngang phía giữa. Thay border đều bằng hai gradient
strip5px, đối xứng xanh/đỏ, giữ animation mở từ giữa ra ngoài. Không scale
độ dày/taper. Upload logo đã có trong Config cho scoreboardLogo/minimalLogo;
theme đang lưu chưa có cả hai ảnh, renderer dùng ký hiệu◆. Thêm trạng thái
chưa có logo cạnh upload, không tự lấy logo Riot hoặc sửa theme người dùng.

## Leaderboard XP, portrait cue và icon Riot mục tiêu — 16/10/2026

- Khung level/gold vốn cùng286px; sửa thanh XP trong level rộng190px bằng
  thanh gold, đưa số level lên hàng tên; đo cuối số cấp cách thanh XP6px.
- CSS chết chỉ grayscale/opacity ảnh tướng trực tiếp, không áp cho ảnh item
  trong portrait-alert. Cue ở z5 trên respawn/buff. Không tắt cue khi chết,
  không thay timeline3.84s hay nguồn dữ liệu.
- Chỉ thay bộ mục tiêu:6rồng nguyên tố+Elder, grub/Herald/Baron, thêm rồng
  chưa rõ loại. Không đổi icon lane, nhà lính, tower, gold hoặc artwork Soul.
  PNG64 alpha mask, không AI/tracingSVG runtime, tô theme hiện có; killfeed
  vẫn trắng. Giữ nguyên assets cũ và baseline DataDragon demo15.20.1.
- Đối chiếu `images/hạ rồng.png`, `baron powerplay.png`: chọn texture
  [spectator atlas Riot16.20](https://raw.communitydragon.org/16.20/game/assets/ux/spectator/esportsneutraltimersatlas.png)
  cho earth/water/fire/air/elder/Baron; scoreboard `_hextechdrake`,
  `_chemtechdrake`, `_riftherald`, `_dragon` cho phần còn thiếu, grub từ
  match-history sprite `right_icons_grub.png`. Đây là asset Riot mirrored
  CommunityDragon, không khẳng định có productionSVG gốc.
- Script `scripts/sync-riot-objective-glyphs.mjs`, manifest source/crop/hash
  tại `public/broadcast/objectives/riot-16.20/provenance.json`. Tách nền tối và
  shadow thành alpha mềm một lần lúc build asset; browser chỉ CSS maskPNG.
  Quyền artwork thuộc Riot; rà quyền phân phối trước publish.
- Edge1920×1080/bản ghi thật: gold/level286px, hai track190px; dead cue item
  filter none/opacity1, champion grayscale1; motion/control regression đạt.
  Build cuối đạt,188 unit:187pass/1skip. Đủ11PNG tải được ở64×64.
  Artifacts `riot-objectives-sheet.png`, `objective-candidates/contact.png`,
  `motion-levels.png` dưới `.npm-cache/visual-audit/`. Chưa đo độ giống95–98%.

### Màu ô chênh lệch vàng scoreboard — 16/10/2026

Sửa specificity CSS: `.score-economy small.blue-lead` cũ thắng rule màu phụ
nên ô trái vẫn dùng xanh chính. Nay dùng blueSecondary (fallback#69afd4),
rule live có specificity đủ cho cả xanh/đỏ nhạt và màu chữ tương phản.
Không đổi màu tên/logo hoặc giá trị vàng.

### Thu gọn Elder timer — 16/10/2026

Elder panel giảm170→120px (Baron giữ170), đủ icon và timer, tên dài ellipsis.
Giữ mép gần scoreboard khi hiện riêng; khi cùng Baron vẫn cùng hàng y12,
gap6px: xanh Elderleft210/Baron336, đỏ đối xứng. Thay số đo Elder170px ở
ghi chú trước, không đổi nhịp hay dữ liệu.

### Baron/Elder cùng hàng — 16/10/2026

Khi cùng đội có cả hai, Elder đặt liền ngoài Baron trên cùng hàng y12px,
khoảng cách6px: xanh left160/336, đỏ right160/336; mỗi panel170px.
Khi thuộc hai đội khác nhau vẫn mỗi panel ở phía đội sở hữu.
Thay bố cục xếp dọc y78px ở mốc motion trước, không đổi telemetry/timer.

### Tăng nhẹ đỉnh lóe buff — 16/10/2026

Theo phản hồi mức30% hơi nhạt, nâng đỉnh tint .096→.128 và Elder glow
.3→.4 (40% mức gốc). Giữ mức thấp .024/.12, nhịp nháy và khung viền.
Mốc này thay thế mức30% ở ghi chú trước.

### Hiệu chỉnh lại đỉnh lóe buff theo xác nhận user — 16/10/2026

User làm rõ muốn giảm độ lóe sáng trên portrait xuống30%, không chỉ giảm
opacity lớp phủ30% như lần trước. Buff tint nay .024–.096 (30% mức gốc
.08–.32); Elder glow .12–.3 (30% mức gốc .4–1). Giữ nhịp nháy, border và
khung nhận diện, không filter brightness/grayscale trực tiếp lên ảnh tướng.
Mốc này thay thế cường độ ghi trong mục trước.

### Resource khi chết và cường độ buff — 16/10/2026

Resource track hiển thị0 khi isDead=true, trở lại theo dữ liệu nguồn khi sống;
không sửa resource trong payload/bản ghi. Dùng chung cho camera/no-camera/minimal.
Lớp buff-tint Baron/Elder giảm cả hai mức opacity30%: .08–.32 thành .056–.224,
giữ nhịp animation và khung nhận diện. Có regression dead/alive/source unchanged.

## Sửa progress lane từ native buff — 16/10/2026

Đã xác định thiếu mapping, không phải UI bị đứng: cả 73.310 item slot8 trong
7.331 snapshot native đều có stats rỗng. Projection3 có 12.696 trạng thái quest
chưa hoàn thành thiếu progress, không có trạng thái progress trung gian.
Native thật có điểm trong exact buff `SR_2026_S1_RoleBound_{Role}_Quest.count`.
Collector nay đọc điểm này: top/1200, mid và bot/1350, support/800. Jungle
RoleBound count luôn0; lấy số còn lại từ `itemsmitecounter.count` hoặc pet
1101/1102/1103.charges rồi tính (35-còn lại)/35. Số điểm là native; ngưỡng là
luật SR, không nội suy theo thời gian. Không có dữ liệu vẫn null.

Slot8 mắt2055 không chứng minh support hoàn thành: patch26.3+ cho phép mắt ở
slot nhiệm vụ từ đầu. Ưu tiên exact QuestCompleted buff, không đánh dấu hoàn
thành khi exact Quest buff còn hoạt động. Bản ghi này thực tế chỉ3 lần hoàn
thành (ORDER top/bot/mid), không phải7 do cạnh mua/bỏ mắt support trước đây.
Nguồn: [Riot26.1](https://www.leagueoflegends.com/en-us/news/game-updates/patch-26-1-notes/),
[Riot14.6 support800](https://www.leagueoflegends.com/en-us/news/game-updates/patch-14-6-notes/),
[Riot26.2 thông báo đổi slot mắt](https://www.leagueoflegends.com/en-gb/news/game-updates/patch-26-2-notes/),
[mô tả item16.20.1](https://ddragon.leagueoflegends.com/cdn/16.20.1/data/en_US/item.json).

Tạo projection4 `2026-10-16T16-02-26-924Z` từ original12:43, giữ1.525 mẫu và
mọi bản gốc. Sửa này thay thế con số7 quest ở các ghi chú lịch sử phía dưới.
Browser Edge1920×1080 xác minh vòng progress cả10 ở2:00/6:40, 9progress+1done
ở10:00, 7progress+3done ở13:00. Build đạt; unit185:184pass/1skip; collector
integration đạt. Script `scripts/quest-progress-smoke.mjs`, ảnh
`.npm-cache/visual-audit/quest-progress-real.png`. Chưa kiểm chứng live mới.

### Upload ảnh trực tiếp trong Phòng thử — 16/10/2026

Đưa khu vực **Đối chiếu ảnh ingame** ra ngoài điều kiện tải bản ghi trong
RecordingDesk: luôn có input upload và preview, kể cả chưa chọn/tải xong
capture. Khi bản ghi sẵn sàng không tạo thêm preview/upload trùng ở
ProductionDesk. Ảnh vẫn cục bộ, có opacity và nút bỏ ảnh; không ghi theme,
không vào OBS. Regression SSR kiểm tra upload hiện ngay khi chưa có bản ghi.

## Motion và điều khiển đồ họa độc lập — 16/10/2026

- Đã tách layout, rune, leaderboard gold/level, pit timer, Baron/Elder,
  Soul panel/banner, inhibitor, portrait cue và buff frame. Soul không đổi
  layout; lệnh điều khiển từng phần merge riêng, không ghi đè phần khác.
- Rune: nền lên trước, hai cụm từ dưới/giữa tỏa ra. Có motion vào/ra cho
  bảng người chơi, minimal, leaderboard, inhibitor, pit timer và objective.
  Level/item: nền đen lên trước, nội dung theo sau, giữ khoảng 3s rồi ra trước nền.
- Pit timer từng loại ẩn khi powerplay tương ứng được hiển thị, trở lại có
  animation. Ưu tiên timer nguồn; fallback dùng rule có nhãn `rule-estimate`,
  không ghi thành native telemetry. Phòng tập có thể lệch do spawn/fast-forward.
- Thêm màu phụ xanh/đỏ trong Config cho quest, inhibitor, progress gold/XP,
  chênh lệch vàng; màu chính cho nhận diện đội. Default mới dùng màu chính đậm,
  không ghi đè màu/theme người dùng đã lưu. Upload ảnh đối chiếu chỉ ở Studio,
  không đưa nền vào renderer OBS hoặc theme/export.
- XP native `sourceStats.experience` là tổng XP. Khi thiếu ngưỡng nguồn,
  progress dùng ngưỡng Summoner's Rift cấp 1–17, tooltip nêu rõ suy ra;
  cấp 18+ không tự bịa ngưỡng. Nguồn tham khảo: [bảng XP](https://wiki.leagueoflegends.com/en-us/Experience_%28champion%29).
- Chọn nhà lính thủ công luôn mở 3 đường của đội đó; không có timer hiện
  dấu gạch. Auto vẫn chỉ mở đội có nhà lính đang hồi. Bản ghi này chỉ có
  nhà lính giữa CHAOS bị phá khoảng 12:29, không có ORDER/KT bị phá.
- Bản suy chiếu mới `2026-10-16T14-22-34-808Z`, projection 3, giữ 1.525
  mẫu nhận; bản native gốc `2026-10-16T12-43-43-938Z` không sửa.
  Khôi phục buff khi seek từ lịch sử event, baseline vàng Baron ghi ở event;
  ItemCompleted theo inventory edge và tập item hoàn chỉnh pinned 16.20.1.
- Đã sửa race reload cùng capture bằng loadGeneration. Build đạt;
  182 unit test: 181 đạt, 1 skip; system/collector/transport integration đạt.
  Edge 1920×1080 trên capture thật đạt kiểm tra motion/control/XP/inhibitor.
  Xem TEST_REPORT.md và VISUAL_AUDIT.md. Không kết luận giống 95–98%.
- Chưa có phiên live mới để xác nhận mọi transition; damage/end-game/Elder
  live thiếu từ trước vẫn giữ giới hạn. Bước tiếp: người dùng duyệt motion
  trên replay rồi ghi trận thật đầy đủ; không cần quay lại khảo sát mock.

## Khôi phục dữ liệu native và tác nhân killfeed — 16/10/2026

Quyết định mới của user: các đối chiếu lệch trước do thao tác pause, không dùng
chúng để chủ động tắt field. CS native đã bật lại bằng laneMinionKills +
neutralMinionKills (giữ 0). Không dùng Riot reference làm gate hiển thị. Giữ
validation kiểu/số hữu hạn, freshness và ranh giới không tạo dữ liệu thiếu.

Đã nối respawnTime, status bit0 cho trạng thái chết, exact buff
exaltedwithbaronnashor/ElderDragonBuff (không nhầm mini-Baron hoặc red buff),
quest slot8 và reward theo rules hiện có, total XP/thông số native trong
sourceStats. Trụ = towersLost bên đối phương; giáp trụ từ maxPlateCount -
plateCount. Spell ID/cooldown không bị bỏ vì thiếu icon trong catalog.

CollectorGameplay cache network identity qua frame, map deathEvents thành
DragonKill/BaronKill/HeraldKill/VoidGrubKill và trụ; dedup, reset khi game/clock
đổi ngược, giữ lịch sử đã quan sát (không tuyên bố history đầy đủ). Soul dùng
buff soul rõ ràng. Có LevelUp/RoleQuestCompleted từ cạnh trạng thái nguồn;
inhibitor HP edge dùng constant300s (không biết thời điểm trước capture thì
không bịa timer). Bản ghi hiện có 4 rồng nguyên tố + Elder riêng, Baron1,
Herald1, sâu3, trụ8, ChampionKill46, LevelUp73, quest complete7, Soul1.

Hero chết không bắt buộc killer là player: exact unit lookup cho rồng, Baron,
Herald, sâu, quái rừng, lính/pet và trụ. Actor ngoài tướng dùng white alpha mask
từ asset có sẵn, không gán đội cho quái trung lập. Icon lính/quái thường dùng
glyph minimap Riot16.20 (provenance tại public/broadcast/killers/); các epic và
trụ dùng SVG hiện có. Unknown actor vẫn giữ death event, không đoán người giết.
Native xác nhận 06:45.13 rồng Hóa Kỹ hạ Yasuo; 06:48.86 Smolder hạ rồng đó.

Offline scripts/audit-current-capture.ts đã đọc7331 native snapshots,1525
observer samples,1586 Riot reference frames. scripts/reprocess-collector-capture.ts
tạo capture **2026-10-16T13-43-33-081Z**,1525sample cùng mốc receivedAt500ms gốc,
derivedFrom **2026-10-16T12-43-43-938Z**. Không thay file gốc; các bản trung gian
do agent tạo chuyển recoverable sang data/capture-archive/2026-10-16-reprocessing-trials.
RecordingDesk có mục toàn bộ sample chuẩn hóa (không raw provider payload).

Giới hạn còn lại: damageDealt21296 event trong archive đều0; chưa có damage
đáng tin để dựng chart thật. Native chưa cung cấp trực tiếp pit spawn timer,
XP level boundaries hoặc quest progress scalar dùng được (stats là object rỗng
ở mẫu đã xem); total XP vẫn hiện sourceStats, không tự dựng progress. Riot
reference **có GameEnd786.431396**, sửa nhận định trước vốn chỉ xét observer;
native/derived observer kết thúc786.3254, chưa nhập event reference vào native.
Chưa tuyên bố full-match/full-telemetry; capture bắt đầu ở game20.8s.

Build đạt; unit173/172pass/1skip dataset archive/0fail. test:collector và
test:integration đạt. Edge1920x1080 dùng đúng theme không cam sao chép ở backend
cô lập: CS10 hàng,4rồng, toàn bộ sample, killfeed Hóa Kỹ trắng→Yasuo đạt.
Ảnh .npm-cache/visual-audit/recorded-all-data.png và recorded-dragon-kills-yasuo.png;
scripts/recorded-data-smoke.mjs. Backend chính đã nạp bản derived ở0ms paused;
theme hash giữ nguyên9C13D86A…D7E9. Không có recorder active, không commit/push.
Tiếp theo kiểm tra các field còn thiếu bằng nguồn thật; không bật lại gate
so sánh chéo theo các kết luận CS cũ trong lịch sử tài liệu.

## Phòng thử chuyển sang bàn phát lại bản ghi — 16/10/2026

Theo user: thay phòng thử hiện hành bằng RecordingDesk dùng chung ProductionDesk
ở mode recording. Chọn/tải capture rõ ràng, không tự đổi provider khi mở trang.
Có play/pause,seek slider,±10s,về đầu,tốc độ0.25–4×; timeline theo thứ tự sample,
hiện timer game thật hiện tại/đầu/cuối, giữ pause/seek/tăng tốc nguồn đã ghi.
Metadata gameTime từ CaptureReplay, lookup binary-search; gap>=5s hiệnunknown.
Các nút leaderboard/rune/minimal/inhibitor điều khiển view hiện tại, không
rehearse/nhảy event/đòi marker. Thiếu field vẫn trống, không fake event/telemetry.

Legacy demo/cue/variant giữ source (RealTestPanel) cho demo UI tương lai nhưng
không mount hoặc hiển thị trong app hiện tại, không còn auto-load side effect.
Preview iframe vẫn đúng OBS URL; đổi bản ghi/view cũng đổi overlay chính cùng
backend, có nhãn lịch sử và cảnh báo không phải live.

Build đạt; unit167ca/166pass/1skip do dataset cũ đã archive,0fail. Integration
đạt (nhánh LB real cũ skip vì archive). Edge trên backend tạm dùng capture thật
2026-10-16T12-43-43-938Z/1525sample đạt: không auto-source,6control không khóa,
play/pause/seek/speed,view không nhảy clock,OBS khớp timer tại vị trí pause,
legacy UI không cóDOM,1920/1280 không overflow. Script recording-room-smoke.mjs,
ảnh .npm-cache/visual-audit/recording-room-current.png (data thật,không fixture).

Đã restart backend chính do agent quản lý, phục hồi đúng capture trên ở0ms,
paused/source recording. Theme SHA256 trước/sau giống nhau,không recorder active.
Bước tiếp user mở lại /?page=demo để duyệt/test các field trên capture mới;
các lỗi mapping collector/objective còn giữ nguyên giới hạn bàn giao.

## Phiên ghi đã dừng sạch theo user — 16/10/2026

Capture2026-10-16T12-43-43-938Z dừng bằng operator stop,process exit0,manifest
state=stopped/finished12:58:37Z,active pointer đã xóa. Native7332message,
observer1525sample,Riot1586sample; invalid0/sequenceGap0,observerMaxGap535ms,
0interval>750ms. Game clock native đầu20.799257s/cuối786.3254s, không tự gọi
capture trọn trận (fullMatch/fullTelemetryVerified=false). Gzip/file đã flush,
raw native~98.8MB nén, app samples~51.4MB. Giữ app/collector/game, không đổi
provider sang recording. User có thể chọn timestamp này trong Phòng thử.

## Đã khởi động phiên ghi mới theo user — 16/10/2026

Theo yêu cầu kill/restart toàn bộ app+ghi: xác minh backend16724 và collector
con10904 đúng workspace rồi dừng riêng hai process, không đụng game/RiotClient.
Khởi động bản mới4310/accountless owned18799; API xác nhận observerIntervalMs500,
withoutAccount=true/credentialConfigured=false/auth not-configured/signed0.
Recorder đã bắt đầu `data/captures/2026-10-16T12-43-43-938Z`,ngân sách3h.
Lúc kiểm tra checkpoint12:44Z state recording/connections2,1native status,
0observer/0reference/player0: đang chờ game, chưa là bằng chứng có data trận.
Overlay chính đã kiểm lại không cam/w1346. Đây là trạng thái tại lúc kiểm,
không bảo đảm process lâu dài. Khi user báo chọn tướng/loading/vào trận kiểm
frame/clock/10player; khi user báo dừng dùng capture:collector:stop và chờflush,
không kill cưỡng bức recorder. Chưa chốt capture đầy đủ/toàn trận.

## Dọn dataset cũ và chuẩn bị theo dõi overlay chính — 16/10/2026

User yêu cầu dọn snapshot cũ để ghi bộ mới. Đã xác nhận không recorder process/
active pointer; chuyển17 thư mục capture timestamp và2 latest pointer từ
data/captures sang data/capture-archive/2026-10-16-before-full-match, có thể
khôi phục. Giữ pktmon/REA,theme,assets và test fixtures. GET api/captures trả0.
Không xóa vĩnh viễn, không đụng evidence native bên Collector.

Overlay chính4310 vẫn layout không cam; Studio/OBS URL trong runbook hiện hành
`docs/LIVE_MATCH_RUNBOOK.md`. User dùng Studio thao tác view, không chuyển sang
Phòng thử/source recording trong phiên ghi. Recorder chỉ bắt đầu khi user báo
trước loading; kết thúc+15s stop/flush rồi mới tải capture mới trong Phòng thử.
Backend thật vẫn cần restart để nhận code500ms; chưa bắt đầu ghi/trận thật.

## Chuẩn bị test thật 0,5s và layout không cam — 16/10/2026

Theo yêu cầu user: chưa ghi, chờ báo vào trận. Nhánh collector backend dùng
nhịp mục tiêu500ms, trừ thời gian xử lý để không cộng dồn drift; reference
recorder tương tự500ms. Native vẫn giữ mọi message, app sample/event giữ nguyên
luồng giao chung Studio/OBS. Manifest có target interval, max gap và số gap>750ms;
không điền sample giả khi nguồn/network chậm. Recorder từ chối backend cũ thiếu
collector.observerIntervalMs=500, yêu cầu restart trước khi ghi.
Reader collector nâng30.000 sample (4h@2Hz), giữ512MB cap; LB vẫn10.000.
Playback kiểm500ms giữ đúng clock/data/event. Full archive vẫn ở data/captures.

Đã đặt theme thật4310 chỉ playerCameras=false và broadcast normal, giữ các
config khác. Edge OBS thật đo x287/y821/w1346/h259,10 hàng,không ảnh nền tham chiếu;
chưa có sample game nên đây chỉ là xác nhận layout, không phải live data proof.
Backend4310 đang chạy bản cũ đo~738ms/lần, cần user restart terminal backend
bằng `npm run start:collector:no-auth` sau build (không đóng game). Trang4392 cũ
không còn truy cập được tại lần kiểm tra; sử dụng4310. Chưa tự ghi trận.

Build/unit166 đạt, recorder integration gzip/marker/playback đạt; collector
integration đo broadcast trung bình350–650ms và Studio/OBS/event queue đạt.
Bước tiếp: restart backend, user báo vào trận → bắt đầu capture, đánh dấu các
mốc realtime; kết thúc+15s flush, kiểm manifest rồi tải đúng capture vào Phòng thử.

## Chuyển tiếp sang chat UI và ghi toàn trận không auth — 16/10/2026

User chấp nhận kết quả hiện tại làm baseline đạt yêu cầu, yêu cầu chuyển toàn
bộ test/đối chiếu/sửa tiếp sangchat **UI** cùng workspace. User cho phép giữ
nguyên names/gameplay/networkIDs trong archive; chỉ lọc authLB/không ghiLCU.
Thêm `start:collector:no-auth`, `capture:collector`, `capture:collector:mark`,
`capture:collector:stop`; lưu fullnative nén + fullRiot/projection + app samples
vàmanifest/marker. Playback/Phòngthử đọc thêm collector-sample, không đưa raw
vào widget. Hướng dẫn chạy và toàn bộ bằng chứng/giới hạn tại
`docs/UI_COLLECTOR_HANDOFF.md`. Chưa có capture trọn trận bằng recorder mới.
Đồng ý baseline không xóa các đầu việc chưa đo: CSnull,rồngnative chưa map vào
app,turret/objective/cooldown/buff/respawn/fullendgame còn cầnkiểm. Không tự
tuyên bố mọifield/fullparity đãxácminh; tiếp tục trongUI theo yêu cầuuser.

## Tạm dừng điều tra theo user — 16/10/2026

User xác nhận HUD rồng xanh1/đỏ0 sau Yasuo hạ rồng Hóa Kỹ lúc950.9522s.
Watcher native nhận đúng DeathEvent trỏ unit rồng đã thấy trước đó; Riot vẫn
thiếuDragonKill và appdragonsnull (chưa mapping). Đây là native proof kèm user
HUD confirmation, chưa full tuyến event rồng. Dừng các bộ audit chủ động theo
yêu cầu, giữ app/collector/game; không sửa mapping khi đang tạm dừng.
Mốc tiếp tục và evidence tại `Collector/docs/ACCOUNTLESS-VERIFICATION.vi.md`.

## Đang kiểm chứng toàn tuyến không auth, ưu tiên Yasuo — 16/10/2026

User yêu cầu kiểm dữ liệu→event và sẽ báo hoàn thành thao tác. SR vẫn chạy,
sau đó user pause được tại621.771179s và yêu cầu tập trung Yasuo (người chơi;
các slot khác bot theo user). Đã chụp mẫu Yasuo native/app/Riot cùng clock;
HP1495.4379/1583.4, wind341.2647/341.2647,currentGold2066.4946,level10/KDA6/4/0.
User đã đọc HUD và sửa báo nhầm HP, xác nhận số native/app đúng; resource341/341
khớp mức hiển thị. Đây là user-confirmed mẫu pause, chưa mọi trạng thái/ảnh HUD
độc lập; gold không thấy nên chưa đối chiếu. CS candidate92
khác Riot90 nên tiếp tụcnull. Roster có hai Kog'Maw cùng đội: chỉ audit8 cặp
unique, không nới gate validator tổng thể. VisionScore8/8 trong epsilon0.0001,
maxdelta4.61e-8; audit strict mismatch phải đọc cùng phép kiểm precision riêng.
Window5phút read-only đang thu metadata/event sanitized; pause chưa có event
mới, không kết luận event unavailable. Chi tiết và evidence tại
`Collector/docs/ACCOUNTLESS-VERIFICATION.vi.md`. Bước tiếp nhận số HUD user,
rồi hướng dẫn resume/quan sát Yasuo và các objective theo từng bước.

## SR spectator không tài khoản: coldstart và app thật đã nhận field — 16/10/2026

User xác nhận SR spectator. Preflight ban đầu404 khi game mới mở; chờ API200,
map11/clock17.9458s/1×/unpaused/noGameEnd và active spectator verified mới chạy.
Game process25488 mở10:43:53Z; listener58869/4998/18799/18814 không có trước test.
Host diagnostic18814 dùng cache hash cũ, env cô lập không tài khoản, autoInject
luồng gốc nhận104/104 valid frame,10hero, bốn field coverage10. Đầu trận chưa
biến thiên nên không dừng ở presence. Host18814 dừng sạch,4998 còn ở game.

Tiếp chọn `collector-accountless` trong app thật4310, demo tắt; owned18799
credentialConfigured=false/withoutAccount=true, native streaming. Đây là reconnect
vào producer không tài khoản vừa tạo, không là coldstart độc lập lần thứ hai.
Lượt45s nhận432/432 native valid, HP/resource/currentGold/totalGold đều10/10;
changedHeroes9/8/10/10. Studio53 và OBS53 sample,53 sample trùng JSON theo timestamp;
coverage cả hai10/10 cho bốn field. Auth cả hai lượt not-configured,features0,
signingAttempts0,signedResponses0. DLL SHA256 vẫn a1028d56…3141d3, không cập nhật
hoặc sửa native/feature guard, không LCU/playback/game-file mutation.

Ví dụ đã lọc tại gameTime174.2053: Ashe HP838.58234/868.975,
mana185.53357/331.625, currentGold250.38002,totalGold825.3839. Resource gồm mana,
energy và wind; không gọi tất cả là MP. Console chỉ public champion/field,
evidence chỉ counts/authmetadata, không raw payload/credentials/player identity.
Evidence `Collector/evidence/validation/basic-fields-2026-10-16T10-44-29.354Z.json`
và `accountless-project-2026-10-16T10-46-16.037Z.json`. Harness tạm
`.npm-cache/test-accountless-project.ts`, không đổi validator tổng thể.

Kết luận giới hạn: tài khoản LB không bắt buộc cho bốn field đã đo trong cấu hình
cache/game/host hiện tại. Chưa numeric HUD parity, field khác, độ ổn định dài hạn,
hoặc bảo đảm patch/DLL tương lai; fullParityVerified=false. App được giữ chọn
không tài khoản trong phiên test, đây không là đảm bảo process lâu dài.
Bước tiếp đối chiếu HUD và kiểm track toàn trận/reconnect, không suy full LB parity.
Build sau cập nhật mô tả đạt. Edge headless1920×1080 trên nguồn SR thật đã
hiển thị10/10 ở trang nguồn; OBS alpha0 chiếm83.375%,0lỗiJS. Ảnh
`.npm-cache/collector-accountless-live/sources-sr-real.png` và `obs-sr-real.png`;
metadata `accountless-live-browser-2026-10-16T10-49-03.947Z.json`. Chỉ đọc UI,
không thay theme hoặc điều khiển game; các logo/tên đội vẫn là cấu hình cá nhân.

Lựa chọn collector đã được đặt tên đối xứng rõ ràng theo yêu cầu tiếp:
**Collector có tài khoản LB (cấu hình local)** và **Collector không tài khoản LB
(DLL cache · thử nghiệm)**. Có mô tả ngay dưới dropdown về nguồn cấu hình từng
chế độ; không nhúng tài khoản/mật khẩu vào app. Hai provider/backend giữ nguyên.

## Chọn collector không tài khoản ngay trong app — 16/10/2026

`/?page=sources` → Nguồn trận đấu đã có **Collector DLL cache: không tài khoản
(thử nghiệm)** bên cạnh Riot local/LB gốc/collector có tài khoản/recording.
Backend quản lý host không tài khoản qua supervisor hiện có, giữ cache đã pin
và môi trường cô lập; không đọc file tài khoản thật/tải DLL mới hoặc giả feature.
Hai chế độ có adapter session/recording/bộ đếm riêng; đổi nguồn xóa output và
dừng host owned cũ trước khi chạy host mới. Không fallback sang nguồn khác.
External host bị từ chối ở chế độ không tài khoản vì không bảo đảm cô lập auth.

Build đạt,163/163 unit đạt với quyền loopback. Integration fixture kiểm routing,
đổi nguồn/reselect, accountless external refusal/0frame/0player và output null;
transport test đạt snapshot shared/OBS receive-only/reset. Edge headless1920
kiểm dropdown/thông báo/reselect và OBS transparency, không lỗi JS.
Ảnh `.npm-cache/collector-project-qa/sources-accountless-1920.png` là UI test
fixture, không dữ liệu native/trận thật. Không khởi động game/native trong QA,
không đổi theme cá nhân. Cần build/restart backend hiện có để dùng UI mới.
Chưa đo field không auth hoặc chứng minh coldstart độc lập; validator tổng thể
vẫn chỉ nhận provider `league-collector`, probe cơ bản mới hỗ trợ không tài khoản.
Runbook `Collector/docs/PROJECT-RUNBOOK.vi.md`; bước tiếp khi game sẵn sàng.

## Hiệu chỉnh killfeed theo All-In — 16/10/2026

Thay ký hiệu hạ gục tự vẽ bằng PNG All-In gốc từ CommunityDragon16.20,
giữ nguyên file và dùng CSS mask trắng. Có source/hash tại
`public/broadcast/all-in-ping.provenance.json`. Nền mỗi dòng dùng lớp tint
xanh/đỏ bán trong suốt (34%), fade phía trái và giữ viền phía phải; không còn
chỉ viền màu trên nền đen. Không đổi dữ liệu/event hoặc màu timer mục tiêu.
Build đạt,4/4 test killfeed đạt; Edge xác nhận mask All-In trắng, nền hai phía
khác màu và có alpha0.34. Ảnh `killfeed-broadcast-lab.png` đã chụp lại bằng
fixture có nhãn, không phải event trận thật.

## Killfeed broadcast và trang HUD game — 16/10/2026

Thêm lựa chọn text/broadcast tại config; kiểu mới góc phải trên theo mẫu,
assist/killer/victim chỉ khi nguồn có slot, quái dùng SVG sẵn làm mask trắng.
Giữ theme timer/banner nguyên tố và chế độ chữ cũ. Event contract optional
actor slots; Riot adapter resolve identity duy nhất nội bộ, không lộ raw identity.
LB snapshot cũ thiếu actor vẫn thiếu, không fake; chưa đụng mapping collector.

Trang `/?page=hud` lưu preset trong theme và áp riêng bằng Replay API render;
không tự apply/save/reconnect, không camera3D/playback/game-file mutation.
Preset ẩn các nhóm HUD dư, giữ minimap/target/parent HUD và hai cờ thông báo.
Ghi chỉ supported fields, đọc lại xác nhận; thiếu cờ bảo vệ thì từ chối ghi.
Chưa xác định cờ tách killfeed gốc khỏi thông báo giữa màn hình; chưa hỗ trợ
ẩn riêng killfeed gốc hoặc18+ VNG. GET thật2999 không kết nối được16/10;
chưa gửi POST vào game và chưa chứng minh spectator live patch hiện tại.

Build,161/161 unit và integration backend tạm đạt. Edge QA trang HUD/config
và killfeed đạt bằng fixture có nhãn; HUD apply intercept, không là kiểm live.
Runbook/nguồn/mapping/giới hạn: `docs/HUD_GAME_RUNBOOK.md`.
Bước tiếp cần user mở replay để đối chiếu các nhóm HUD và killfeed gốc,
giữ thông báo hạ gục/double kill; không tự nối cờ chưa xác minh.

## Layout tối giản và config loạt trận — 16/10/2026

Theo ảnh tham chiếu mới: thêm line góc xanh/đỏ; loadout tối giản đối xứng,
quest reward cạnh D/F phía ngoài, sau đó tối đa 3 item có cooldown/GA theo slot
inventory. Chưa hoàn thành quest thì item đầu chuyển lên ô trên; item thứ 4 ẩn,
không thay inventory nguồn. Giữ bộ lọc bình/thuốc/mắt. Top đã hoàn thành dùng
reward Teleport ở ô quest và cập nhật ảnh D/F nếu có Teleport; cooldown ô quest
chỉ dùng spell/slot phù hợp, không mượn D/F khác khi được tặng Teleport.
Chưa kiểm chứng thêm game live hoặc identifier mới; tiếp tục dùng roleQuest,
inventory/cooldown đã normalize, không tự tính quest progress hay cooldown thiếu.

Không cam: bảng tối giản x=287, rộng1346; có cam giữ x=464, rộng992 (1920×1080).
Config có chọn BO (BO3=2 ô, BO5=3 ô), đổi tên/logo/tỉ số hai phía, màu giữ theo
phía bản đồ; thao tác chỉ phát sau Lưu. Thêm 2 PNG riêng (mỗi ảnh tối đa100KB)
cho giữa scoreboard và giữa hai đội tối giản; lưu/export/import theo themev1,
field tùy chọn để tương thích theme cũ. Ô thắng dùng màu từng phía, kể cả draft.
Giữ nguyên UI đầy đủ, nhánh collector/REA và cấu hình cá nhân.

Kiểm chứng: build đạt; unit153/153 đạt với quyền loopback; integration backend
tạm đạt; `scripts/production-smoke.mjs` đạt trên port riêng/theme tạm.
`scripts/minimal-layout-smoke.ts` kiểm tra tương tác upload PNG, BO3/BO5,
đổi bên/tỉ số, save/reload và OBS; đo 4 tổ hợp cam/không cam × quest xong/chưa
xong, vị trí item đối xứng, tối đa3 active, asset/font không lỗi.
Ảnh `.npm-cache/visual-audit/minimal-*.png` là fixture UI tổng hợp có nhãn,
không phải dữ liệu trận thật và không là phép đo phần trăm độ giống.
Bước sau: user duyệt bố trí mới rồi kiểm chứng trong trận thật theo kế hoạch track.

## Phép thử DLL cache không tài khoản: offline đạt, chờ game — 16/10/2026

Thêm chế độ diagnostic `probe-basic-fields.ts --without-account`, giữ hash
DLL cache, không tải mới/sửa native hoặc giả quyền. Host con không nhận account
từ env/file thật; file account của user giữ nguyên. Từ chối attach host có thể
đã auth, ghi trạng thái auth và phân biệt producer có sẵn với coldstart.
Offline auth-check trả `not-configured`/exit2, chưa load native/chưa truy cập game.
Build đạt, unit149/149 đạt với quyền loopback (sandbox chặn2 test network).
Evidence `Collector/evidence/validation/accountless-offline-2026-10-16T02-30-07.021Z.json`.
API2999 không chạy và user chưa thể mở trận; chưa có bằng chứng field thực khi
không auth, không kết luận tài khoản bắt buộc hoặc có thể bỏ. Các lần HP/vàng
thành công 15/10 vẫn là trial có cấu hình tài khoản. Cách chạy và giới hạn tại
`Collector/docs/BASIC-FIELDS.vi.md`. Mặc định project vẫn giữ luồng cũ.

## Replay map12: đã lấy HP/resource/vàng thật bằng host riêng — 15/10/2026

User hiện chỉ mở được trận không phải SR và đã báo sẵn sàng. Bỏ yêu cầu SR
cho chẩn đoán field cơ bản: `collector:probe-fields` đọc native envelope riêng,
roster1..64, không dùng gate SR10 của validator tổng thể/không đổi HUD baseline.
Preflight GET2999 map12/clock190s/1×/không pause/không GameEnd, spectator verified,
LB listener đóng. Coldstart DLL gốc qua owned host18814 nhận29/29 valid frame;
không mở LB gốc, không auth/version/spectator patch, không LCU/playback mutation.

Lượt tiếp theo bắt buộc `--no-inject`:232/232 valid frame,10 hero. HP10/10,
resource9/10, currentGold10/10, totalGold10/10; các field đó đều có biến thiên
ở10/9/10/10 hero trong cửa sổ đo. Resource gồm8 mana và shield của Mordekaiser;
Mundo loại none/max0 nên giữnull, không ép thành MP. Vàng đang giữ và tổng vàng
khác nhau; không giả định đồng nghĩa. Đây là native runtime data, không fixture.

Reference Riot allgamedata có10 player nhưng HP/resource/currentGold/totalGold
coverage đều0: chưa independent numeric parity/HUD verification. Snapshot giá
trị đã lọc chỉ in trong phiên phục vụ yêu cầu user; file evidence chỉ counts,
không raw payload/player identity/credentials. Hai report:
`basic-fields-2026-10-15T15-30-24.462Z.json` và
`basic-fields-2026-10-15T15-32-41.100Z.json` trong Collector/evidence/validation.

Postcheck host exactDLL/port18814 và listener đều0; replay vẫn GET200/map12/1×/
unpaused/clock419.088s, không GameEnd. Build148unit đạt. Supervisor thêm option
autoInject=false cho probe reconnect; mặc định project giữ nguyên. Không đổi
theme/asset/UI. Full integration/parity chưa đạt; bước tiếp kiểm cùng field
trên Studio/OBS ở replay đang có, không bắt buộc chờ SR chỉ để kiểm HP/MP/vàng.

## Validator positive HTTP/WS đã kiểm chứng lab; còn chặn ở game thật — 15/10/2026

Tách `Collector/validation/project.ts` làm engine để kiểm đúng nhánh positive
cùng HTTP/WS, giữ CLI production chỉ dùng endpoint local và dataOrigin local-game-api.
Fixture có nhãn riêng dataOrigin fixture/fixture-project-comparison, không có
flag CLI chuyển sang fixture. Thêm `npm run test:collector-validation`:
10 scenario positive/failure đạt, client không gửi command/HTTP mutation,
server/socket/timer đã cleanup. Gate mới từ chối clock+roster nhưng thiếu mẫu
đối chiếu đủ level/K/D/A/items cho10 người. Không coi thiếu telemetry thành0.

Build và146 unit test đạt. Lab summary tại
`Collector/evidence/validation/project-validator-lab-2026-10-14T18-38-19.108Z.json`.
CLI thật sau refactor tiếp tục game-api-unavailable/preflight-only, không backend/
host/auth; evidence `project-live-2026-10-14T18-38-59.804Z.json`.

Audit mục tiêu đầy đủ tại `Collector/docs/COMPLETION-AUDIT.vi.md`: launcher và
lab transport đã có, nhưng toàn tuyến trên game, CS/lane, HP/gold/timer semantics,
buff/respawn/objective và stability chưa được chứng minh. Cùng blocker người
dùng chưa thể mở game/API2999 vắng đã lặp qua các lượt tiếp tục. Phần offline
có đủ nghĩa của tuyến này đã chốt; cần trận SR10/spectator/replay đang chạy
để tiếp tục sửa theo dữ liệu thật. Không suy thiếu Develop là root cause mới,
không gọi fixture là game proof hoặc tuyên bố mục tiêu hoàn thành.

## Collector: chuẩn bị đối chiếu toàn tuyến trên game — 15/10/2026

Thêm `npm run collector:validate`, attach project đang chạy và subscribe Studio/
OBS chỉ đọc. Preflight SR10/spectator/clock/end-state/roster trước backend;
source phải league-collector, demo off và owned runtime. Comparison tách field
presence khỏi equality, không raw identity/stats, filter stale/skew/provenance
và duplicate/ambiguous roster. Pair Studio/OBS theo session/epoch/sequence;
không tự launch/auth/inject/thay source/theme/game. Full parity không tự chốt.

146 unit test và build đạt, TypeScript bản cuối đạt. CLI thật ghi preflight-only/
game-api-unavailable, chưa backend/WS/host; evidence
`Collector/evidence/validation/project-live-2026-10-14T18-28-32.333Z.json`.
Positive branch full HTTP/WS/game chưa được kiểm chứng; pure comparator tests
không thay proof toàn tuyến. Lệnh/các gate tại `Collector/docs/LIVE-PROJECT-CHECK.vi.md`.
Mục tiêu đầy đủ còn mở: cần trận thật, CS/lane/semantics, objective/buff/respawn/
event và stability. Không dùng preflight chưa ready làm native/auth failure.

## Collector: native event projection và broadcast không mất event — 15/10/2026

Đã nối typed HeroDie/TurretKill/InhibitorKill/Ace qua exact networkId lookup
sang ChampionKill/TurretKilled/InhibKilled/Ace. Không copy raw ID/name, không
đoán team/killer/firstTurret và không derive counter từ event window. Chỉ recent
5 game seconds; history coverage false. Mapping source-derived/fixture-tested,
chưa event game proof. NetworkId chỉ tham gia roster signature hash nội bộ.

Sửa khoảng native tick100ms/backend poll750ms: source giữ event queue tối đa4096,
backend drain một lần cho cả Studio/OBS. Diagnostics chỉ đọc; queue expire theo
cả game time và wall time5s, baseline/seek/reconnect/lost reset, không phát lại
alert lịch sử. 143 unit test đạt, targeted13/13 sau expiry wall time; build,
collector integration và system/transport integration cô lập đạt. Các proof
là fixture, không game. Chi tiết/source/hash tại `Collector/docs/NATIVE-EVENTS.vi.md`.

Vẫn chưa có game theo trạng thái người dùng; thiếu xác minh toàn tuyến dữ liệu
thật và CS/lane/timer semantics, rồng/Baron/buff/respawn, counter objective và
stability. Không thay auth/native bytes, không mở LB gốc hoặc thao tác game.

## Collector: thêm projection ngọc và cooldown item — 15/10/2026

Đã đối chiếu Farsight source khôi phục và catalog để thêm keystone/perks và
cooldown item vào provider hiện có. Ngọc: unique known keystone, panel9 chỉ khi
order primary4/secondary2/shards3 hợp lệ; không sort/đoán raw vector. Item timer:
inventory đã validate slots0..6 nối spell6..12; empty ammo dùng recharge;
không map aux7/8/quest/GA activation. Đây là source-derived, không game verified.
137 test mốc trước đã tăng thành139/139; build, targeted adapter9/9 và
integration collector với fixture mới đạt. Không đổi UI/theme/asset/auth/native
bytes. Evidence/source/hash và giới hạn tại `Collector/docs/NATIVE-PROJECTION.vi.md`.
API game chưa có theo trạng thái người dùng; tiếp tục thiếu proof toàn tuyến
trận thật, CS/lane/HP/gold/timer semantics, buff/respawn/objective/event và stability.

## Collector đã nối launcher → Studio/OBS, còn chờ trận thật — 15/10/2026

Backend có provider `league-collector`, selector tại Kết nối dữ liệu và lệnh
`npm run start:collector`. Supervisor tự chạy host trong `Collector` khi chọn
nguồn này, dừng host do mình sở hữu khi đổi nguồn/bật demo/tắt backend. Không
cần mở giao diện LB gốc. Vẫn dùng DLL LB gốc ghim hash và luồng xác thực/guard
gốc; đây chưa phải LeagueReader độc lập hoặc full LB parity.

Credentials đã chuyển sang `Collector/config/collector.env`, bị Git ignore;
không xuất sang frontend, bản ghi hoặc log. Runtime dùng dotnet bundled/cache,
kiểm hash native trước launch, không tự tải update. Token dừng ngẫu nhiên chỉ
trong môi trường host; endpoint điều khiển từ chối yêu cầu thiếu token. Host
theo dõi PID/thời điểm khởi động launcher để dừng nếu launcher biến mất; thử
launcher thoát không gọi cleanup đã đạt trên host thật idle. `running` chỉ là process đang
chạy, không chứng minh đăng nhập hoặc telemetry ready. Chế độ external chỉ đọc
host ngoài, không sở hữu/dừng host đó.

Kiểm chứng: build đạt; unit **137/137**; integration ứng dụng cô lập đạt;
`npm run test:collector` đạt routing chung Studio/OBS, recording đã lọc,
switch/reselect. Edge headless 1920×1080 đạt selector và OBS alpha; đã xem ảnh.
Feed của bài test này là fixture, không game proof. Managed lab 6 check đạt,
lifecycle 16 và auth-flow 5 đạt. Host thật idle start/health/stop đạt, endpoint
không token trả 403; sau chuyển env cũng đạt, evidence
`Collector/evidence/validation/owned-runtime-2026-10-14T17-48-40.942Z.json`.
Parent lifetime đạt, evidence
`Collector/evidence/validation/parent-lifetime-2026-10-14T17-51-30.518Z.json`;
chưa chứng minh shutdown/crash cleanup khi producer đang cấp dữ liệu game.

GET API game 2999 cuối phiên không kết nối được; người dùng báo chưa thể bật
game. Chưa kiểm chứng toàn tuyến launcher → dữ liệu game thật → Studio/OBS.
Giữ kết quả SR live trước đó làm bằng chứng adapter, không nâng nó thành proof
của tuyến mới. CS vẫn null; thứ tự lane, giá trị HP/gold/cooldown, ngọc/buff,
objective/event và ổn định qua trận/patch còn thiếu. Kế hoạch chạy tại
`Collector/docs/PROJECT-RUNBOOK.vi.md`; mục tiêu tích hợp đầy đủ vẫn chưa đạt.

## SR live10 spectator: adapter đối chiếu và sửa inventory/shutdown — 15/10/2026

User mở SRlive/spec; approvedpreflightGET2999 map11/10player/spectator/clocktăng,
noGameEnd. MộtcoldstartDLLgốc port18807 nhận87frame/9sample; no-inject18808 nhận
229frame/24sample. Roster/champ/team/level/KDAkhớp10; inventory0vìnativeaux7/8,
CSsumcandidatechỉ0–2/10khớp;2hostphảiwatchdog. Giữlog/marker,khôngquyauth/gamefailure.

Sửaadapterlọcstandarditems0..6, bỏknownaux7/8 (khôngđoánquest),unknownslots vẫnnull;
CSdisabled→nullchờsemantics/producer investigation. Sửa.NETWSlinkedtoken thêm
ApplicationStopping;3rdtrial18809 --no-inject nhận212frame/22sample/0invalid,
items10/10, mỗi fieldlevel/K/D/A/items220/220khớpRiot; skewmax0.1261421s. HP/gold/
cooldownpresence10/resource8 khôngfullvalueproof. HeroIndexunique10,team1/2 mỗi5
nhưnglane-orderchưađượcxácminh. Exit0/dừngsạch/forcedfalse,postcheck0ownedhost.
Gamegiữchạy/map11/clock702.488s sautrial;khôngLCU/pause/seek/đónggame/reinject.

Signcount/features0/authsubscription-unavailable; vẫnchưa signednativeaccountproof.
Nativebytes/hash/quyền/guards giữnguyên;khôngraw/identity/credentials lưu vàoevidence.
Buildroot/135testđạt;managed6check/lifecycle16/authflow5đạt;integrationcôlậpghi
tạiTEST_REPORT.md. Report `Collector/docs/SR-LIVE-VALIDATION.vi.md`;3artifact
sr-live17-14-14, sr-live-reconnect17-16-43, sr-live-fixed17-21-57 (UTC14/10 =local15/10).
Bước tiếpCS/lanemapping vàHP/gold/cooldownsemanticcheck; chưaStudio/OBSprovider
integration hoặcfullLBparity. UI/theme/asset/production source giữnguyên.

## Collector: field matrix và adapter riêng — 14/10/2026

Đã triển khai `Collector/adapter/{normalize,source,fields}.ts`: directprojection
envelope nativev1/source lblib/syntheticfalse/currenttimestamp sangcontract
IngameSample/ObserverFrame. Bảngfield + evidencelevels tại Collector/docs/FIELD-MATRIX.vi.md;
không nâng schema-only thành runtimeverified. Team1/2 vàuniqueheroIndex10/
5+5 validate,slotstable theo team/index/chưaroleorder. Championcode→cataloglive
patchunverified, nullableKDA/CS/gold/HP/resource/inventory/RDFcooldowncandidate;
teamgold/kills aggregatechỉ đủ5validfield. Unsupportedperks/buff/deathrespawn/
objectives/events giữnull/vắng,khônginvent0 hoặcderiveevent.

Contractthêm sourceleague-collector/currentGoldoptional tươngthíchcũ; sourceNames
nhãn thửnghiệm. AdapterexplicitWS127.0.0.1:/ws,noauth/env/launch/sendcommand,
freshness5s/sequenceanti-replay/statusloss/socketclose/reconnectsession/seekepoch.
Rawplayeridentity/assets/credentials khôngxuất. Capabilitiescoverageđộng tách
productionReadyfalse/roleOrderVerifiedfalse. CLIcollector:inspect chỉaggregates.
Khôngregister vàoStudio/autostart,khôngthayLBproduction/theme/UI/baselineasset.

Kiểm chứng: build + unit/regression và loopbackWSfixture + backendintegration
cô lập; kết quả cụ thể tại TEST_REPORT.md. SandboxViteEPERM/loopbacktimeout được
rerun approvedhost, khônggánchogame. Chưaadapterrealreplay/map11/parity; bước tiếp
đốichiếu team/heroIndex/champion/spellslots vàfieldvalues trênreplaySR trướcrollout.

## Collector DLL LB: authenticated replay và no-inject reconnect đạt — 14/10/2026

User mởreplay/envready. Approved accountcheck login thànhcông,subscriptionlookup
unavailable,0requestedfeature. ApprovedReplayGET200/1×/map12/noGameEnd. Sandbox
processinventory khôngthấygame khôngđược dùng phủđịnh replayAPI thực.

Một bounded authenticatedtrial port18805/DLLhashgốc/noLCU/noUpdate/noRawRecording:
1window/1inject-reported/1game-started,hostsnapshotcounter≥84,harness9sample đủ
10hero/HP/maxHP/gold/totalGold/items/spellspresence. No-injectreconnect18806:
counter≥228/24sample,10hero/maxHP/totalGold/spellReadyAtdương,scalarvalues đổi.
Clock mẫu353.1676→361.21332 và516.2971→539.6159; patch16.20.824.8524/map12.
Haihostexit0/dừngsạch,postcheck0matchinghost;LB58869closed lúcpreflight. Replay
giữchạy;producer4998 cònnghe sauhoststop,khôngQuit/đónggame/reinjectlần2.

SigningAttempts/signedResponses/requestedFeatures đều0. Sửa kếtluận quá rộng
“collectorriêng thiếuDevelop luônkhôngdata”: hostgóiTCP này códata vớiEmpty,
khôngsignedchallenge. Trialcũ thiếuDevelop giữgiới hạn host/transportđó. Chưa
nativeclassificationtrace, chưa loginnecessary/fullFree/fieldcorrectness proof.
Collector riêng dùng engineLB trênsample đãchạy; C++LeagueReader vẫn chưagamevalidated.

Thêm diagnostic signingcount; noUpdate giờfailclosed trướcimplicitdownload nếu
libraryversionkhôngphùhợp. Offlinebuild6check/lifecycle16/authflow5 đạt, hashDLL
giữnguyên. Evidence `Collector/evidence/validation/authenticated-native-2026-10-14T15-04-58.838Z.json`
và `authenticated-reconnect-2026-10-14T15-07-57.281Z.json`; report
`Collector/docs/AUTHENTICATED-RUNTIME.vi.md`. Giữ2trialmarkers/logfailedpasses.
Bước tiếp reviewcontract/fieldmapping offline; map11SR/baselineparity thật trước
adapter/production. Không sửaUI/theme/provider, khôngapp tests/commit/push.

## Kiểm chứng đường email/password collector — 14/10/2026

Đọc source thực: BlueBottleAuth loginSRP→subscriptionlookup; SourceWorker truyền
auth.Features sang Farsight. Lookup không trảfeatures giữEmpty; RequestFeatures
managed trảtrue ngay, khôngchallenge/Sign. Thêm offline auth-flow-self-test gọi
managed method thực:4/4đạt, khôngnetwork/game/privateIPC/nativeauth. Không sửa
vendor/DLL/quyền. Build/doctor/serializer/lifecycle/auth-flow tổng6check đạt,
lifecycle16/16. Evidence `Collector/evidence/validation/managed-lab-2026-10-14T14-52-28-761Z-f7a2f7336e4c436da68a2a2e212cc177/`.
Giữ cả log các lần build/test phát triển lỗi trước lượt cuối đạt.

Thêm bounded account-only checker45s, chỉpersist state/count/hashallowlist,
khôngkhởi độngcollector/LCU/native; thử hiện tại trảnot-configured/exit2 vì
khôngcredentialfile/LBenv. Chưa gọiprovider/authenticatedchallenge. Read-only
process check khôngthấyClient/game/LB; GET2999 EACCES sandbox, approvedread sau
ECONNREFUSED. Không mode/authfailure inference. Nativehash/layout/syntax đạt.

Hướngdẫn tại `Collector/docs/AUTH-VERIFICATION.vi.md`. Cầnuser cấu hìnhemail/
password local (khôngchat), mởLoLClient; sau đó có thểinventory replay quaLCU
hoặc user mởreplaySRmới. Chưa cóclient đểgọiLCU hoặcreplayready, không tựlaunch
binaryclient/game hoặcinjecttrial. Bước tiếp accountcheck→replaypreflight→native
transport/handshake/service/frame theo scope. LBproduction/UI/theme giữnguyên.

## Dọn Collector workspace — 14/10/2026

Source local mới nhất ở `Collector/src/LeagueCollector`; source reader độc lập
ở `Collector/src/LeagueReader`. Runtime/scripts/docs/evidence/archive tách theo
vai trò. Cloud export nguyên vẹn giữ baseline; validation/log/one-shot marker
được di chuyển, không xóa hoặc sửa nội dung. Wrapper giữ4lệnh cũ đã sử dụng;
scripts build/audit/inspect dùng đường dẫn mới, restore offline có config riêng.
Xóa4thư mục đã kiểm tra rỗng: CollectorHost,.dev-build,.test-build và wrapper
validation-20261014 rỗng sau di chuyển. Không xóa source/thay đổi người dùng,
theme hoặc dữ liệu game. Bản đồ ở `Collector/evidence/import/layout-migration-20261014.json`.
Bước tiếp vẫn review/fixture offline rồi kiểm chứng acquisition riêng trước
parity/tích hợp. Collector chưa thay LB production.

Kiểm chứng sau di chuyển: build/doctor/serializer/lifecycle5check đạt,16/16lab,
gameAccessedfalse. JS/PS syntax và16link local/layout/hash native đạt. Kết quả
`Collector/evidence/validation/managed-lab-2026-10-14T14-39-47-357Z-c9c90bbf8edf4cd3bd4a2b1752fcd6e3/`.
Xóa thêm một ZIP source trùng hash10.754.626byte, canonical còn trong cloud export.
Không native trial/auth/game trong lượt dọn; không app test vì app source không đổi.

## Import Collector cloud và restore validation — 14/10/2026

Đã kiểm SHA-256 hai ZIP trong Collector, kiểm entry và giải nén riêng tại
`Collector/archive/cloud-export/RiotOverlay-local`. Verifier đạt12.731file,
0size/hash mismatch. Hai runtime Windows giải nén riêng757file; source cloud
giữ nguyên, không ghi đè validation. User restore source/scripts/results local;
đã đọc lab16/16/gameAccessedfalse/telemetryFields0 và đối chiếu source/hash.
Native DLL giữ nguyên; audit tại `Collector/evidence/import/import-audit-20261014.json`.

Gói có LeagueCollector dùng DLL LB và LeagueReader C++/C ABI độc lập. Reader
có13mapping tĩnh, chưa tự tìm hero roots,0game-validatedfield/fullparityfalse.
Lab16/16 là evidence lịch sử đãrestore, không test chạy lại trong lượt import;
trial gói này chưa có nativeframe, trial cũ sauGameEnd/map12 không chứng minh
Develop/Free/replaydeny. Không áp grantfailure của host nghiên cứu khác cho gói.

Đã thêm index/status/plan ở `Collector/README.vi.md` và `STATUS-PLAN.vi.md`;
giữ source/evidence/packages và ZIP phục hồi, bỏ qua chúng trong Git bằng
rule cụ thể. Không chạy game/collector/auth/build/lab, không đổi provider/UI/theme,
không push. Kiểm manifest/hash và tài liệu cho mốc import, không app tests.
Bước tiếp: review baseline lifecycle local và Windows fixture offline; runtime
chỉ khi có phiên/nguồn phù hợp, rồi parity thật trước adapter/production switch.

## Spectra handshake local xác nhận — 13/10/2026

Người dùng báo Reconnecting/Main Menu; kiểm tra thấy BE/FE Valorant không còn lắng nghe. Đã mở lại riêng services (`start --services-only`), giữ nguyên Client đang mở. Client chuyển Connected, backend health xác nhận 1 observer socket authenticated và 1 session đăng ký; đây chưa phải trận đang chạy. Probe output Socket.IO chỉ nhận theo group config RIOTLOCAL thành công: group đúng, isRunning=false, phase LOBBY, 0 roster/scoreboard/aux HP/ability slot, khớp Main Menu. Không xuất raw payload, tên người chơi, key hoặc secret.

Đã thêm `modules/valorant/runtime/inspect-output.mjs` cho probe một snapshot đã lọc. Đổi nhãn services-only từ disabled-for-test thành external-or-not-launched cho lần khởi động sau; process hiện chạy vẫn dùng nhãn cũ, không restart chỉ để đổi nhãn vì đã có handshake. Source socket health/output probe là bằng chứng kết nối, không phải GEP/player telemetry. Bước tiếp theo cần người dùng mở custom ở Observer và báo khi tới Agent Select, rồi kiểm tra roster/phase trước khi bắt đầu trận. Không sửa runtime/provider/theme LoL. Port/process là quan sát phiên này, không đảm bảo sau restart.

## Cấu hình Riot API / postgame sẵn nhập key — 13/10/2026

Đã triển khai form đầu trang Sau trận: Standard key hoặc RSO access token,
VN2→SEA, Riot match ID/số ván, save vào RAM/xóa, tải Match+Timeline, review
candidate bằng cùng renderer, checkbox đối chiếu rồi publish sang Studio/OBS.
Key không đi qua WS/theme/export/storage; restart cần nhập lại. Tải/đổi/xóa
key không tự ghi đè kết quả đang phát. Không tự tạo OAuth/Tournament hoặc auto
kích hoạt theo GameEnd. Người dùng còn cần match ID, không chỉ key để tìm trận.

HTTP local credential/load/publish có Host/Origin/method/content-type/body
guard. Egress GET literal SEA endpoints, ID VN2 validate, timeout/max response,
no redirect, không echo raw errors. 429 cooldown, no retry; clear hủy pending.
Riot dataset version2/source riot do backend normalize; WS/import chỉ mẫu v1,
không forge observed. Icons live16.20.1, demo baseline15.20.1 giữ riêng.

Adapter lọc identity, KDA/gold/damage/counters/bans, timeline gold/gaps,
role-order unresolved hiện P1…P5, patch/capability cảnh báo. Elder split chỉ
khi đủ timeline/known subtype/counter agreement; live semantics vẫn cần test.
Timeline lỗi không xóa Match đã tải; partial/aborted gắn cờ, không ép số 0.

Build đạt,116/116 unit/regression đạt, integration riêng đạt; Edge1920/1280
API config/save/clear/validation/staging/forge-publish guard và postgame sample
regression đạt. Synthetic credentials/responses, **chưa gọi Riot thật**.
Integration cũng kiểm tra load→stage→publish→snapshot với test-only fetch
preload, không tạo runtime mock Riot trong app. Retry-After số/date và thời
gian >1h không bị rút ngắn; unit đạt.
QA theme/backend riêng, không sửa config cá nhân. Ảnh config đã xem, chưa
tuyên bố similarity. Hướng thao tác/giới hạn: `docs/RIOT_API_SETUP.md`.

Bước tiếp: mở Sau trận, nhập key local + Riot match ID cũ để kiểm chứng
quyền/payload trên VN2, rồi đối chiếu đội trước publish. Nếu dùng backend cũ
phải restart sau build. Không tự khởi động game/LB/REA, commit/push.

## Endpoint/field Riot cho postgame — bổ sung 13/10/2026

Theo yêu cầu ưu tiên endpoint trước archive: đọc đầy đủ bảng DTO reference
Match-v5 chính thức. MatchDto có damage to champions tổng và ba split,
winner/duration/KDA/gold/objectives/bans; TimelineDto có totalGold và cả
damageStats to champions. Có thể làm postgame nếu được trả đúng trận.
Khó khăn chính Standard VN2 là quyền truy cập custom, không phải damage schema.

Thiếu/cần payload thật: tách Elder/loại rồng (team DTO chỉ counter dragon),
mapping objectives horde→grubs, role của custom, timeline resolution. Events
DTO Portal chỉ timestamp/realTimestamp/type, không cam kết event subtype.
Nếu fallback LB archive: damage vẫn không tự tính được, winner/final duration
và bans cần nguồn/xác nhận riêng. Không bắt đầu archive hoặc sửa UI/backend.

`scripts/inspect-riot-postgame-schema.mjs` GET public docs (không key/game),
export tên/type field vào `.npm-cache/riot-postgame-schema.json`; node syntax
và khảo sát chính thức được kiểm chứng. Chưa có API key/match ID/RSO token
trong environment nên chưa có authenticated gameplay response. Matrix chi
tiết tại `docs/RIOT_POSTGAME_API_FINDINGS.md`. Bước tiếp cần match ID + nhập
key local để thử payload, không cần trận mới; không hỏi quyền Tournament lại.

## Riot Portal postgame / Standard VN2 — 13/10/2026

Người dùng có production **Standard** LoL, máy chủ **VN2**, chưa có quyền
Tournament được xác nhận. Đã đọc API reference chính thức (public
`/api-details/match-v5`, `lol-rso-match-v1`, `tournament-v5`) và docs Riot.
Routing Match-v5 VN2 là **SEA**, khác platform host VN2 và Account routing.
Match schema có winner/duration/damage champions/KDA/gold/objectives/bans;
timeline có totalGold/frameInterval. Đây là schema, chưa response key thật.

Custom thường có đường **LoL RSO Match v1** chính thức, Bearer player token,
không được thay bằng key Standard. Production key không tự chứng minh quyền
Tournament hay OAuth client/consent. Khuyến nghị kiểm tra trận cũ được cấp
quyền trước, không cần game mới; custom phải kiểm tra riêng với RSO hoặc
tournament code. LB gameId nội bộ không được coi là Riot matchId.

Environment agent chưa có RIOT_API_KEY hoặc match ID. Chưa authenticated
request, tạo resource, triển khai adapter/probe hoặc sửa production. Tài liệu
`docs/RIOT_POSTGAME_API_FINDINGS.md` nêu field mapping, bảo vệ key và bước
kiểm chứng; docs-only không chạy test app. REA/Valorant/in-game giữ nguyên.
Bước tiếp cần Riot match ID và xác nhận đã có RSO client chưa; key nhập local
an toàn, không đưa vào chat/frontend/Git.

## Spectra Client tìm thấy / runtime Observer Ready — 13/10/2026

Theo quyền người dùng cấp, đã tìm executable/shortcut/install record trên các vùng truy cập được của C user/Program Files và D/E; không tăng quyền để vào các thư mục OS bị ACL chặn. Tìm installer `Downloads/SetUp/Spectra-Client-Setup.exe` 0.3.4 và shortcut Player/Auxiliary cũ trỏ executable không tồn tại. Installer hash khớp asset official GitHub. Đã tải gói `spectra-client-0.3.4-x64.nsis.7z` 90.947.888 byte, SHA256 `ced9bfab...822c9f`, giải nén không chỉnh binary/ASAR vào `data/valorant/collector/0.3.4`; không chạy installer, không sửa shortcut hay anti-cheat. Provenance ở `modules/valorant/collector-release.json`; source fork 0.3.3 chưa build/không đồng nhất binary official 0.3.4.

Đã gắn executable vào config có backup, giữ nguyên key/group/port. Launcher mở được Observer; cửa sổ thực tế `Ready (GEP: 315.1.0, Spectra: 0.3.4)`, log marker có Observer/GEP ready, không thấy feature-setup/GEP init error trong phần kiểm tra. Đã sửa collector GUI không bị windowsHide; backend/helper vẫn ẩn. Ctrl+C dừng toàn bộ cây collector do launcher tạo, rồi mở lại thành công. Client hiện dùng AppData/profile upstream, chưa tách collector profile; không đọc/export storage credentials hoặc raw log, chỉ marker đã allowlist.

Status backend/FE ready nhưng `observerConnected=false`, 0 match; chưa cấu hình Client local, chưa mở trận hay xác minh telemetry. Không coi GEP Ready là dữ liệu 10 người. Cần người dùng nhập ingest `http://127.0.0.1:5310`, group RIOTLOCAL, key từ file local (không gửi vào chat), observer/team rồi Connect; sau đó custom observer để thu mẫu. Không còn cần người dùng tìm path executable. 6/6 module tests đạt; root build và kiểm chứng root ghi tại TEST_REPORT.md. Collector headless fork/Studio embedding vẫn chưa làm.

## Điều tra postgame offline — 13/10/2026

Người dùng cho phép điều tra nguồn thật trên dữ liệu hiện có, chưa thể chạy
game mới. Đã stream scan 15 WS file/14 có message: 2.788 message, 2.752 state,
2.556 frame đủ roster 10, không invalid JSON. Có KDA/gold/towers/dragons/grubs;
goldGraph có thể tự dựng từ gold đội từng frame, không cần endpoint premium.
Tìm thấy raw objective Kill Baron tại 717.56793 giây (team 1) trong capture
11/10; raw ledger nên được dùng thay buff-only inference khi tổng hợp.

Swagger LB đã lưu khai báo 403 cho postgame overview (không probe entitlement
mới). SDK công khai có damage optional nhưng không có trong WS đã scan.
Không suy damage từ HP; winner/terminal chưa có bằng chứng. Capture dài nhất
roster 00:42.377→21:37.696, không GameOver=5/winner: chỉ partial, không final.
Herald/Elder/bans chưa xác minh trong feed đã lưu. LCU EOG/LB game metadata/
Riot Tournament là ứng viên sau trận, không hứa spectator/custom đủ dữ liệu.

Script `scripts/inspect-postgame-evidence.mjs` chỉ đọc; `--save` ghi report
aggregate không identity vào `.npm-cache/postgame-evidence.json`. Chạy
syntax check và audit thật đạt. Không sửa UI/transport/schema/runtime, không
chạy game/LB/collector/REA; không cần test app cho báo cáo + script khảo sát.
Chi tiết, matrix, số liệu và kế hoạch archive tại `docs/POSTGAME_DATA_FINDINGS.md`.

Bước tiếp: triển khai aggregator/kho phiên offline nếu được yêu cầu; chưa
nối sample thành live. Khi game sẵn sàng kiểm chứng winner, final duration,
damage, Herald/Elder và draft capture. Các nhánh REA/Valorant giữ nguyên.

## Postgame UI / mẫu dữ liệu chờ duyệt — 13/10/2026

Theo yêu cầu mới, chỉ triển khai UI và contract mẫu; chưa tìm/nối data thật.
`/?page=postgame` có preview chính xác `/overlay?scene=postgame`, nạp mẫu theo
ảnh, đổi đội thắng, thử thiếu dữ liệu, xóa, nhập/xuất JSON có validation.
Renderer có header kết quả/thời gian, 8 thống kê mục tiêu + bans, damage
10 người theo đường, graph chênh lệch vàng và footer nhận diện giải. Tên/logo
tùy chọn/màu lấy chung theme, bỏ sponsor Riot/AWS; luôn ghi nhãn mẫu. Nhánh
postgame fixture cũ không còn tự tuyên bố T1 thắng khi chưa có bộ mẫu.

`shared/postgame.ts` version 1, source chỉ `sample`, asset baseline 15.20.1,
winner/duration/stat/damage nullable. Gold history tăng dần theo game-time,
delta xanh − đỏ; null ngắt curve. Bộ mẫu ephemeral, có JSON export để giữ.
Không suy kết quả từ in-game, không auto scene/GameEnd và không sửa nguồn REA.

Kiểm chứng: build đạt, 109/109 test đạt; system integration đạt command
postgame/validation/reset và OBS nhận-only; Edge QA 1920×1080 / 1280×720,
Studio 1280×800 đạt fonts/assets, cân hai cột damage, graph trong panel,
hai đội thắng, thiếu dữ liệu/gaps, JSON nhập/xuất và đồng bộ iframe/OBS.
QA dùng backend/theme riêng, không thay theme cá nhân. Không đảm bảo port
test tồn tại lâu dài, không tuyên bố độ giống 95–98%.

Xem `docs/POSTGAME_UI_REVIEW.md`. **Bước tiếp theo: chờ người dùng duyệt UI,
sau đó mới kiểm chứng winner/damage/history và thiết kế adapter postgame thật.**
Các mốc telemetry đã hoãn vẫn hoãn, không coi UI mẫu là dữ liệu live.

## Module Valorant độc lập / lifecycle — 13/10/2026

Theo yêu cầu triển khai phần 2, đã import source Client/Server/Frontend ValoSpectra vào `modules/valorant` theo revision pin, có archive SHA256, LICENSE và MODIFICATIONS. BE Node/FE Angular có npm lock/dependency/build riêng; collector source chưa build. Launcher có config/key riêng trong `data/valorant`, port mặc định 5310/5311/5320/5322, health/readiness, ownership lock, xử lý conflict và shutdown cây process do nó tạo. Không sửa contract, renderer, theme hoặc luồng startup LoL. Chưa nhúng module vào tab Studio.

Fork BE chỉ bind loopback, giữ auth, hạn chế browser Origin/payload, tắt raw replay/default private logging và preview creation trong launcher. FE dùng font local có LICENSE; OBS không render fixture ban đầu, hide khi mất socket/collector hoặc 5s không có ingest update, HP gauge cần auxiliary capability. Gate này có thể ẩn ở phase ít event/pause và chưa thay thế normalization/freshness từng field. Giữ watermark/license upstream. Package Server có metadata GPL nhưng LICENSE ELv2, đã ghi mâu thuẫn thay vì tự relicensing.

Kiểm chứng: `build:valorant` đạt, 5/5 lifecycle/Socket.IO test đạt (source synthetic, không game); browser Edge headless 1920×1080 đạt status/routes, OBS alpha=0 khi thiếu nguồn, không request ngoài/JS errors, đã xem ảnh trang status. Root build, 104/104 unit test và `test:integration` LoL cô lập đạt. CLI start/Ctrl+C thực tế đã giải phóng owner/cổng; không phải đảm bảo process tồn tại lâu dài. Sandbox từng vướng EPERM/loopback, đã chạy lại bằng quyền môi trường bình thường, không né bằng đổi LoL source.

Chưa tìm thấy Spectra Client executable ở process/install location/Downloads đã kiểm tra; không kết luận chưa cài ở vị trí khác. Cần người dùng cung cấp path/version hoặc xác nhận cần cài để tiếp tục khởi động collector thật. Module service có thể chạy không collector, status ghi thiếu executable/telemetry chưa xác minh. Chưa đo game, chưa xác minh 10 người/HP/abilities/spike live, chưa custom toàn FE/BE hoặc build/package collector. Hướng thao tác tại [docs/VALORANT_MODULE.md](../VALORANT_MODULE.md); không yêu cầu Riot API key, không đưa key local vào chat.

## Đo lại tone nền theo ảnh thực tế — 13/10/2026

Theo phản hồi bản72% quá nhạt: đo4 ảnh mẫu bằng ROI pixel và so bản trước/sau
trên cùng game-only backdrop. Scoreboard luma median mẫu10–22, bản trước32,
bản mới14; player panel mẫu15–33, trước39, mới20. Màu nền24,30,32 trước quá
sáng; chỉnh thành8,12,14, base84%, main92%/cap95%, sub~74%. Giữ transparency
một lớp và font/ảnh/gauge; không thay hình học/data/draft hoặc ép config đã lưu.
Theme cá nhân chưa có opacity field, reload nhận fallback mới, không sửa file.

Build/104 test và production browser QA slider/save/OBS/cả2 layout đạt. Đã xem
ảnh calibrated. Tọa độ, phương pháp, số đo và giới hạn tại
`docs/INGAME_PANEL_CALIBRATION.md`; không suy opacity Riot chính xác từ ảnh đã
composite hoặc tuyên bố % similarity. Test/theme/backend riêng, không trận mới.

## Nền in-game nhẹ và trong suốt — 12/10/2026

Theo yêu cầu kiểm tra độ đen/opacity: phát hiện scoreboard chồng nền235/255
và232/255 nên alpha tổng gần99%; leaderboard cũng chồng nền panel/hàng. Chuyển
HUD live sang xám than(24,30,32), một surface chính. Theme v1 thêm optional
`ingamePanelOpacity` .35–.90; thiếu field dùng .72. Config có thanh **Độ đậm nền
in-game**, Save/export/import/realtime theo luồng theme sẵn có, không ghi đè
theme cá nhân khi QA. Header mạnh hơn .06 (mặc định.78), score-sub .82×mức nền.

Đã chỉnh player table cả2 layout, scoreboard, timer mục tiêu, leaderboard gold/
level, rune, inhibitor, Baron/Elder, minimal name, cue/watermark và placeholder.
Không dùng opacity trên toàn container để tránh làm mờ chữ/ảnh/gauge; giữ layer
CD item và artwork/banner màu riêng. Bỏ các lớp nền cha-con gần kín. Có clamp
tên đội dài khi có logo để không chạm cột số; không đổi hình học/data/REA.

Kiểm chứng: build và104/104 test không skip đạt. Browser config slider bằng
keyboard/save đồng bộ OBS; PNG alpha modal header199/255(~78%), các panel được
kiểm tra dưới85%, cả2 layout/minimal/rank/runes đạt. Visual variants đầy đủ
timer/Baron/Elder/nhà lính/quest/Soul đạt, không ảnh hỏng/control/nền tham chiếu.
Đã xem preview nền game crop riêng (không scoreboard/table/cam cũ), chỉ minh họa
transparency, không chứng minh match data/độ giống. Artifact ignored
`ingame-opacity-preview-final.png`; OBS vẫn nền trong suốt. Không chạy trận mới.

## Polish ban/pick simple — 12/10/2026

Đối chiếu RCVolus `script.js` dùng splashCenteredImg và metadata CommunityDragon
15.20: simple chuyển từ loading portrait dọc sang centered splash ngang của Riot;
171 WebP local, tổng3.678.370 byte, tối đa800×480/quality82. Catalog15.20.1/demo
giữ baseline, layout broadcast vẫn loading portrait. Có URL/version/input/output
SHA256 và sync script offline; không AI/runtime processing. Chi tiết nguồn tại
`docs/DRAFT_VISUAL_SOURCES.md`.

Căn footer tên player/icon lane, badge lượt, nhãn champion, coach và header
giải/timer/phase/patch; giữ footprint, palette/theme/data và vùng cam caster.
Build/103 test đạt; browser20 lượt, switch layout, centered art đủ, font/ảnh,
OBS/iframe, export/import và alpha toàn vùng1120×690 đạt. Đã xem ảnh render
`draft-simple-polished.png` (artifact riêng tránh ảnh cũ đang mở bị file lock).
Chưa audit crop mọi tướng/skin hoặc tuyên bố % similarity. Không đổi nguồn draft.

## Ban/pick simple cho cam caster — 12/10/2026

Thêm `theme.draftLayout` optional (`broadcast`/`simple`); thiếu field giữ layout
cam tuyển thủ cũ. Chọn tại trang Cấm chọn hoặc config trước trận, lưu/export/import
cùng theme và đồng bộ preview/OBS. Không đổi theme cá nhân để test.

Simple chỉ lấy geometry của RCVolus `layouts/layout-simple`; overlay.png chỉ là
nền nên đọc thêm CSS/HTML nguồn (không chạy/import runtime repo). Header150px;
picks dọc x0/1520,y183,w400,h690 (5 ô130px); bans x45/1155,y900,w720,h130.
Vùng giữa x400..1520/y183..873 dành cam caster, renderer không chèn camera/nền.
Giữ font/màu/theme/icons/portrait, hover/lock, timer và data/trình tự hiện hành;
hover không nở rộng vào vùng cam. Bans giữ icon/khung hiện có thay artwork nghiêng
của repo. Layout cũ vẫn phục vụ footage tuyển thủ, không đổi mock baseline.

Build và103/103 test đạt. Browser chạy20 lượt, chuyển broadcast→simple→broadcast,
đo vùng/layout, xác nhận preview/OBS cùng class, alpha vùng giữa hoàn toàn0,
font/ảnh đủ, export/import và1280px đạt. Đã xem `draft-simple.png` trong cache
ignored. Không tuyên bố % similarity, không thay nguồn draft manual/live.

## Cấm chọn production nhập tay & hướng test toàn trận — 12/10/2026

Theo yêu cầu mới: in-game dừng ở mức hoàn thiện/test từng phần, lượt kiểm chứng
tiếp theo track toàn bộ trận. Không mở thêm audit in-game hoặc gọi cue là dữ liệu
live. Module cấm chọn theo `images/Cấm chọn.png` đã có bàn riêng `/?page=draft`,
20 lượt ban/pick, hover/lock, bỏ lượt, lùi lượt, timer theo deadline (về 0 chờ tay),
swap vị trí trong đội, HLV/roster/patch, export/import phiên. Preview iframe và
OBS `/overlay?scene=draft` dùng cùng state/revision. Sửa lỗi renderer live không
xét scene và preview widget giữ scene draft sau khi chuyển in-game.

Production dùng branding/series/logo từ theme, không crop sponsor/Riot logo hoặc
hiện số thống kê fixture. Không có logo thì dùng tên; tên dài tự thu font. Giữ
mock draft baseline riêng. Catalog draft đủ 171 champion 15.20.1, icon/portrait
base local (khoảng7,99MB portrait), tách catalog demo, script sync CDN Riot.
Geometry đo: bans (0/1560,667,360,112), pick (0,790,1920,290), giữa
(800,790,320,290), hover320px/ô khác120px. Chưa đo % similarity.

Kiểm chứng: build đạt,103/103 test không skip; integration riêng đạt command
draft/validation/OBS read-only. Edge tương tác đủ20 lượt/undo/skip/swap/timer,
export/import thật, preview/OBS, font/ảnh, transparency và1280px đạt; production
smoke in-game đạt sau chuyển từ draft. Đã xem ảnh render không nền tham chiếu.
Backend/theme test riêng, giữ config cá nhân. Cảnh báo bundle/Zod cũ còn.

Ranh giới: nguồn draft chỉ manual/reference, chưa nối hoặc xác minh draft live
LCU/LB. Không suy draft từ in-game snapshot. Phiên draft RAM, export trước restart;
theme vẫn lưu riêng. Postgame chưa triển khai. Chi tiết `docs/DRAFT_RUNBOOK.md`.
Tiếp theo người dùng kiểm tra bố cục/nhập tay; khi có phiên cấm chọn thật sẽ xác
minh payload trước khi auto. In-game test toàn trận theo `docs/LIVE_MATCH_RUNBOOK.md`.
REA/Valorant giữ riêng; không commit/push trong lượt này.

## Tách lane quest theo layout — 12/10/2026

Điều chỉnh theo phản hồi mới: layout có cam giữ tiến trình quest trên thanh tỉ số; hoàn thành thì reward thay ngọc phụ, không có ô quest trong hàng. Khôi phục chiều rộng inventory/tên của layout cam. Layout không cam giữ ngọc phụ và ô quest riêng giữa đồ/rune, icon tiến trình/reward/placeholder đều hình tròn; không có quest trên scoreboard. Số sâu hư không vẫn ở cả hai layout. Quyết định này thay phần áp dụng quest row cho cả hai layout ở mốc dưới.

Build và 99/99 test đạt; regression kiểm tra chuyển pending/completed theo cả hai layout. Browser production-smoke 1920×1080 đạt: đổi config realtime, bản rộng có 10 ô tròn và không có scoreboard quest, bản cam không có ô riêng và có scoreboard quest. Đã xem ảnh cả hai layout, giữ OBS trong suốt. Không đổi telemetry hay cấu hình cá nhân.

## Layout chính nhỏ, quest trong từng hàng & khảo sát stack — 12/10/2026

Theo yêu cầu: cấu hình mới dùng không cam (`defaultTheme` và initial production state false), không ghi đè theme local cũ; layout có cam vẫn tùy chọn. Thanh HP/mana bản rộng200px thay260px, thứ tự hàng giữ nguyên. Thêm ô22px giữa đồ/ngọc cho lane quest: icon role + vòng progress từ field player khi chưa xong, reward item/spell khi xong; secondary rune path luôn trả lại vị trí cũ. Field quest thiếu hiển thị unavailable, không suy từ slot. Quest bỏ trên scoreboard, số sâu hư không vẫn giữ hai bên. Minimal/Soul không mở ô quest, mock/draft giữ baseline.

Arrow đối chiếu `all.png` và ảnh chênh lệch vàng: bỏ tam giác trắng rời, đổi thành mũi nhọn5×14px cùng màu/liền cạnh thanh đội dẫn; hai phía đặt ngoài thanh tương ứng, áp dụng cả layout. Đã xem screenshot1920×1080 trên snapshot thật, kiểm tra10 quest cell,HP200px, trục gold và thứ tự default; layout cam/tối giản trở lại kích thước cũ. Không tuyên bố % độ giống.

Ưu tiên thấp stack: khảo sát14 file/2711 state frame thấy `tabs.players.stacksData` trong Nasus(0–152), Veigar(0–1), Smolder(chỉ0 đầu trận); schema SDK công khai xác nhận optional number. Chưa bật counter/chưa thay ngọc phụ vì cần đối chiếu với chỉ số Q/passive trong game, nhất là Smolder có giá trị>0. Báo cáo và script tại `docs/LB_STACKS_EVIDENCE.md`/`scripts/inspect-lb-stacks.mjs`; không đưa raw/identity/credentials vào Git. REA không thay đổi. Tiếp theo có thể nhờ người dùng cung cấp screenshot stack và game time trong trận test. Build đạt,99/99 unit test không skip và integration cô lập đạt; thêm regression quest progress→reward và giữ secondary rune, default config không cam/compat theme cũ. Browser production-smoke đạt trên snapshot thật cả2 layout và kiểm tra vị trí/arrow/10 quest slot.

Kiểm tra bổ sung đã đạt: browser đủ 5 loại quest completion và các biến thể objective/Soul/buff/inhibitor; baseline draft/in-game/postgame, assets/font, renderer OBS trong suốt và 5 trang Studio (config 1280px). QA dùng backend/theme riêng, không đổi config cá nhân. Các cue vẫn là kiểm thử UI, không chứng minh telemetry live. Đã hoàn tất phần UI của yêu cầu; phần stack chờ đối chiếu game như trên.

### Điều chỉnh layout không cam theo phản hồi — 12/10/2026

Người dùng yêu cầu bản kéo rộng giữ thứ tự layout mặc định, không chuyển cụm tên/HP/mana ra mép ngoài. Đã bỏ reorder `.row-name`; giữ bảng1346px và thanhHP/mana260px, thứ tự trang bị/ngọc/phép/champion/tên/stat như baseline, trục vàng không đổi. Đây là điều chỉnh thay quyết định đưa cụm HP ra ngoài của mốc bên dưới; layout cam và tối giản không đổi. Build và browser QA với snapshot thật đạt; kiểm tra cả10 hàng thứ tự mặc định và xem ảnh mới `compare-no-camera.png`. Sửa selector test theo từng card tránh race danh sách nút đổi text.

## Arrow vàng & layout không cam — 12/10/2026

Theo yêu cầu UI: arrow chênh vàng xanh đặt ngoài bên trái thanh xanh; arrow đỏ ngoài bên phải thanh đỏ (không còn nằm phía trong cột số). Thêm optional `theme.playerCameras`; mặc định thiếu field giữ layout cam cũ, false mở bảng live từ (464,821)/992×259 sang (287,821)/1346×259, lấp hai vùng cam 177px. Cụm tên/HP/mana chuyển ra mép ngoài, thanh rộng260px; trục gold x927 không đổi. Minimal và Soul takeover không mở rộng, draft/mock giữ baseline.

Chọn tại Cấu hình trước trận → bỏ **Dành chỗ cam tuyển thủ**, Save; export/import/persistence dùng cùng theme v1 tương thích. Không đổi config cá nhân để QA. Build đạt,97/97 test; Edge headless1920×1080 với capture thật có gold hai hướng xác nhận table1346px,10 HP260px, arrow ngoài thanh, chuyển lại layout992px và minimal992px. Đã xem ảnh render không nền tham chiếu `no-camera-overlay.png` trong cache ignored; OBS giữ transparency. Không thay telemetry/REA. Lần tới người dùng chọn layout mong muốn và thử live.

## Bàn vận hành trận thật — 12/10/2026

Theo yêu cầu mới, phòng thử coi như xong; đã tách `/?page=theme` thành cấu hình trước trận (không preview), có Save tên giải/đội/điểm loạt trận/logo raster tùy chọn, toàn bộ theme, import/export v1 tương thích cũ. Đội không logo chỉ dùng tên, không đoán branding KT/T1. Save broadcast state realtime rồi ghi theme local atomic; lỗi ghi đĩa thông báo riêng. Không ghi đè theme cá nhân để QA.

`/?page=studio` có iframe nhận-only đúng `/overlay?scene=ingame` và nút mở/copy URL OBS, trạng thái nguồn/mẫu/revision. Điều khiển vàng/level/rune/minimal và inhibitor off/auto/xanh/đỏ bằng state broadcast chung; preview nhỏ dùng cùng renderer và sample, không seek/sửa telemetry/giả event. View một loại mỗi lần; minimal không preview con. Cấm chọn/postgame làm xám UI, giữ renderer/hợp đồng cũ để regression. Phòng thử giữ riêng và có cảnh báo khi recording/mock/cue trong bàn live.

Kiểm tra trigger source hiện có: trụ/trụ đầu, rồng/Soul, Baron/Elder, hai pit timer tự hoạt động khi bật widget objectives và có field/event mới. Inhibitor mặc định auto, một đội có hồi sinh gần nhất, operator có thể chọn/ẩn. Reconnect/seek đặt baseline, không replay lịch sử. Chưa có auto combat/damage và chưa kiểm chứng live mới; Elder/nhà lính xanh vẫn cần mẫu thật. Nhánh REA/headless không đổi.

Kiểm chứng: build production, 97/97 unit test không skip; integration cô lập gồm command broadcast và theme >64KB/logo/score/persistence đạt. Edge headless thực: bấm Save → OBS và iframe cùng tên/điểm/logo; tối giản/bảng thường đồng bộ, cảnh hoãn disabled, responsive 1920/1280 không overflow; mở bản ghi thật và phát gold/level/rune, preview con có cùng dữ liệu (10 level). Artifact ignored `.npm-cache/visual-audit/production-*.png`, script `scripts/production-smoke.mjs`. Không dùng fixture/mock để chứng minh dữ liệu live.

Bước tiếp theo: người dùng mở spectator live với LB, config tên/đội và kiểm tra đủ 10 người trước on-air. Kế hoạch ghi full message WS (ưu tiên hơn polling 0,5s), lệnh ghi/đánh dấu và giới hạn playback 512MB/10.000 frame tại `docs/LIVE_MATCH_RUNBOOK.md`. Không tự bắt đầu capture hoặc thao tác game; không commit/push trong lượt này. State nút phát là tạm trong phiên backend, theme được lưu qua restart. Port/process không là đảm bảo lâu dài.

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

Người dùng muốn gắn collector vào ứng dụng, khởi động cùng project và fork/custom BE/FE ValoSpectra trong workspace; không chỉ xây UI từ output của stack bên ngoài. Đã sửa hướng nghiên cứu tại `docs/VALOSPECTRA_FEASIBILITY.md`: giữ collector Overwolf Electron là process do launcher quản lý, fork BE Node/FE Angular thành package riêng trước khi hợp nhất sâu với Studio React. Có thể dùng collector sẵn, chưa yêu cầu viết acquisition từ đầu. REA đã được đọc để tham khảo; skill hướng dẫn dùng normal source tools khi repository đầy đủ nên chưa cài/chạy REA.

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

Người dùng yêu cầu nghiên cứu Valorant bên cạnh LoL và xác nhận dùng ba project ValoSpectra local. Đã đọc source Client/Server công khai, ghi revision và ma trận field tại [VALOSPECTRA_FEASIBILITY.md](../VALOSPECTRA_FEASIBILITY.md). Xác nhận acquisition qua Overwolf GEP, output Socket.IO 5200 (`logon` → `match_data`); HP/abilities có nhánh auxiliary, HP 100 có thể là default, timer/plant có logic derived/manual. Không coi schema provider là bằng chứng telemetry trực tiếp đủ 10 người.

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

Đã chụp baseline khi LB + Riot/League Client đang mở nhưng chưa vào replay/custom. `BlueBottleClient.Interface.exe` sở hữu cổng 58869; process đã nạp `Farsight.dll` và `BlueBottleClient.GameLib.dll`, chưa thấy `lblib.dll`, và chưa có `League of Legends.exe`. Log cho biết `LocalFarsightDataSource` đang chờ game; public `/ws/in` trong 5 giây chỉ trả một `gameStatus` với `gameState=0`. LB kết nối LCU loopback và `wss://broadcast.bluebottle.gg/ws/rpc`; chưa có bằng chứng gameplay đi qua cloud. Chi tiết/hash nằm trong `docs/LEAGUEBROADCAST_FEASIBILITY.md`; capture cục bộ bị Git ignore. Bước tiếp theo cần người dùng vào custom spectator hoặc replay để chụp Loading/Running và diff module/network/IPC. Không attach, debug, đọc memory, mở pipe riêng hoặc thay runtime.

## Ghi chú điều tra BlueBottle và lab laptop, 26/09/2026

Đã hợp nhất nội dung trao đổi bổ sung vào `docs/LEAGUEBROADCAST_FEASIBILITY.md` và cập nhật ma trận trong `docs/DATA_SOURCES.md`, không tạo file nghiên cứu mới. Kết luận được giữ có giới hạn: xác nhận Discord do người dùng cung cấp cùng artifact cài đặt tạo **STRONG EVIDENCE** cho khả năng collector hiện hành đọc state/memory, nhưng logic native lấy từng field và lý do tương thích Vanguard vẫn chưa được xác nhận. Frontend JS `/ws/in` là consumer, không phải acquisition backend.

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

Người dùng đã xác nhận **hai bản draft và in-game đạt yêu cầu ban đầu** sau vòng chỉnh theo `ingame.png` và `overlay.png`. Đây là baseline được duyệt về sản phẩm, không phải kết quả đo chứng minh độ giống 90%. Những khác biệt ở `docs/VISUAL_AUDIT.md` vẫn được giữ làm ghi chú, không chặn chuyển sang khảo sát live data.

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

Triển khai **giai đoạn 1 trong `docs/ROADMAP.md`**: màn hình chẩn đoán nguồn dữ liệu local chỉ đọc. Chuẩn bị công cụ trước, sau đó hướng dẫn người dùng mở client, vào chọn tướng và spectator để thu mẫu đã loại bỏ credentials. Chưa cần Riot API key cho mock hiện tại; chỉ yêu cầu thông tin thật khi adapter cụ thể cần.

## Tiếp tục trên máy khác

Đọc `AGENTS.md`, làm theo `docs/SETUP_VI.md`, xác minh baseline và tiếp tục giai đoạn 1. Không cần tái nghiên cứu toàn bộ hoặc dựng lại UI từ đầu. Không giả định thư mục `.research`, theme cá nhân hoặc lịch sử chat có trong Git.

## Tiến độ chẩn đoán — 19/09/2026

Đã thêm tab **Nguồn dữ liệu**, endpoint GET `/api/diagnostics`, tự tìm lockfile từ LeagueClient trên Windows hoặc `LOL_LOCKFILE`, probe LCU phase/champ-select/postgame và Live Client allgamedata. Request chỉ GET loopback, timeout/body limit, không follow redirect, cache ngắn và gộp request đồng thời. Route kiểm tra Host/Origin và không cho phương thức ghi.

Báo cáo có nguồn, đường dẫn field ứng viên, kiểu, availability, mẫu số đã lọc, timestamp và thời gian phản hồi HTTP. Export JSON không chứa raw payload, credentials hoặc tên tài khoản. Không đưa dữ liệu chẩn đoán vào state mock hoặc renderer. Objective/inhibitor state vẫn đánh dấu chưa kiểm chứng; EventID không chứng minh capability objective.

Kiểm chứng phiên này: production build đạt; 9 unit tests và transport integration đạt khi chạy bản biên dịch tạm bằng esbuild + Node. `npm test` trực tiếp vướng lỗi môi trường `uv_os_get_passwd ENOMEM` của tsx trên Windows sandbox; không thay dependency hoặc script project để né lỗi. HTTP GET/405/cross-origin 403 đã kiểm tra. Trình duyệt hiển thị báo cáo thiếu nguồn đúng trạng thái.

Probe thực tế ở phiên này: Live Client không kết nối được; chưa tìm thấy lockfile LCU hợp lệ. Đây không phải bằng chứng API không hỗ trợ. Chưa thu mẫu lobby/champ-select/spectator/postgame trên client thật, chưa hoàn tất giai đoạn 1. Tiếp theo: người dùng mở LoL Client, kiểm tra lại, cấu hình đường dẫn lockfile nếu cần, rồi thu báo cáo từng phase theo `docs/SETUP_VI.md`. Chưa triển khai Observer Agent hoặc adapter live.

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

Đã xác minh giới hạn nguồn hiện có và ghi ma trận tại `docs/DATA_SOURCES.md`. Overwolf GEP là lựa chọn hợp lệ nhưng tài liệu gold áp dụng cho người chơi cục bộ; chưa có bằng chứng cung cấp telemetry đầy đủ của 10 observer. Public LeagueBroadcast JS client chỉ bọc WebSocket, không chứa collector. Vì vậy không thêm hai nguồn này như provider hoạt động khi chưa có frame thật.

Phase tiếp theo là OBS capture + OCR cho những giá trị nhìn thấy trên HUD, trước hết team gold, kills, objectives và clock. Kết quả OCR phải có confidence, timestamp, profile vùng ảnh và hết hạn khi HUD đổi hoặc bị ẩn. Không suy total gold từng người từ team gold và không tuyên bố HP/resource 10 người từ ảnh không hiển thị chúng.

Dashboard Nguồn dữ liệu có thêm bảng ứng viên, yêu cầu cài đặt, độ phủ thực tế và ranh giới nghiên cứu. Ranh giới loại bỏ memory reading, injection, hook/driver, né Vanguard, decompile collector và giải mã replay/giao thức riêng khi chưa được Riot cho phép. Các hướng chấp nhận gồm API/Swagger loopback, SDK/WebSocket công khai, spectator service được cấp quyền và ảnh OBS.

## Presentation clock, 20/09/2026

Đã thêm lớp nội suy clock theo mô hình public LeagueBroadcast client: snapshot Riot là anchor, renderer cộng tuổi snapshot nhân playback speed; pause giữ nguyên và frame từ 5 giây trở lên chuyển unavailable. Kills, gold, item và các state rời rạc không bị nội suy. Session/sequence/epoch và seek detection hiện có tiếp tục kiểm soát event ordering. Thiết kế và điều kiện để dùng nhãn frame accurate được ghi tại `docs/FRAME_ACCURATE_STATE.md`.

## LeagueBroadcast custom tournament xác minh thành công, 20/09/2026

Custom tournament spectator trên map 11 đã làm LeagueBroadcast 1.13.3 chuyển từ Loading sang Running. `/api/diagnostics/health` báo good khoảng 2 update/giây; asset cache 16.18 đạt 100%; `/ws/in` phát frame đủ 10 người. Điều này xác nhận replay/spec trận thường trước đó không phù hợp với luồng nhận diện, không phải lỗi cổng WebSocket hay asset.

Đã mở rộng adapter bằng dữ liệu `tabs.Order/Chaos`: HP, resource, phép bổ trợ và keystone. Item slot 7/8 riêng của provider bị loại, chỉ slot inventory 0 đến 6 được đưa vào contract. Kiểm tra live sau khi nạp lại backend: champion 10/10, level 10/10, KDA 10/10, CS 10/10, total gold 10/10, HP 10/10, resource 9/10, spells 10/10, keystone 10/10, inventory 10/10 và vision 10/10. Một champion resource-less có max 0 nên giữ missing đúng thiết kế.

Payload đã quan sát còn có team gold/kills/towers/tower plates/dragons/grubs, Baron và Dragon pit timer, inhibitors, ability cooldown và perk list. Các nhóm team/objective/event này chưa được normalize. Raw identity, player name, URL asset và field lạ tiếp tục bị loại khỏi frontend. 40 test và production build đạt sau thay đổi.

## Scoreboard, objective và snapshot live, 20/09/2026

Ghi chú nghiên cứu mới nhất 24/09/2026: xem `docs/LEAGUEBROADCAST_FEASIBILITY.md`. Chỉ nghiên cứu, chưa triển khai thay collector. Capture mới `data/captures/2026-09-24T15-14-32-437Z` chỉ có Riot map 12/10 players và LeagueBroadcast OutOfGame, sau đó Loading/idle; backend 4310 không phản hồi. `latest.json` là lần chụp mới nhất, không phải lần chụp đầy đủ nhất. Bản tournament đầy đủ để kiểm thử vẫn là `2026-09-19T18-57-45-942Z`. Chưa xác minh nguồn free độc lập đủ state 10 người; SDK công khai chỉ là client. Người dùng ưu tiên bất kỳ phương pháp hợp lệ nào lấy đủ dữ liệu in-game, cần nghiên cứu kỹ trước triển khai.

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

Kết luận UI/data: scoreboard thường và chênh lệch vàng đã có dữ liệu phù hợp; gold ranking, team runes, combat minimal/cooldown, inhibitor respawn có raw data nhưng chưa có scene/contract đầy đủ; damage dealt không có telemetry trong snapshot; Baron Power Play và Dragon Soul cần capture đúng thời điểm. Draft không thể xác minh bằng capture in-game này. Chi tiết theo từng ảnh nằm trong `docs/VISUAL_AUDIT.md`.

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

Kiểm chứng: `npm test` trực tiếp đạt **63/63**, không skip (gồm regression toàn bản ghi thật và validate mọi sample); `npm run build` đạt; `npm run test:integration` đạt HTTP/recording/6 probes/origin/method guard, WS đồng bộ và OBS read-only, scene/mock controls, validation, theme persistence/reset, provider, bản ghi lớn/pause/4×/seek. Test tích hợp tự mở backend 4311 và theme tạm; `RIOT_OVERLAY_THEME_PATH` giữ nguyên `data/theme.json` của người dùng. Browser kiểm tra panel/minimal với nguồn recording, đủ 10 slot, không icon hỏng, không background reference và không control trong renderer, body/canvas trong suốt. Canvas CSS 1920×1080 nhưng ảnh in-app bị giới hạn vùng preview; chưa có full-size OBS 1:1 và chưa kết luận pixel-perfect. Báo cáo đầy đủ ở `docs/TEST_REPORT.md`.

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

Kiểm chứng lượt cuối: `npm run build` đạt, `npm test`64/64 không skip, integration cô lập đạt; 7ảnh OBS không broken image/reference/control, rectangle khớp như báo cáo. GRUB chưa có glyph rõ nên giữ nhãn loại quan sát, không gán iconBaron choGRUB. Chi tiết phương pháp, giới hạn, kiểm chứng, lệnh tái chạy và phần tiếp theo ở `docs/VISUAL_MEASUREMENTS.md`; artifact local trong `.npm-cache/visual-audit/`. Soul hiện vẫn banner/status, chưa artwork takeover; Damage vẫn unavailable. Đã hỏi người dùng chọn giữ sponsorRiot trongSoul hay chỉ giữ bố cục/nhận diện riêng, và xin asset gốc nếu có. Tiếp tục đo nội bộ từng vùng, không gộp điểm chữ thành95–98% toànUI. Không push/publish.

## Collector headless — phương án 2, nhánh nghiên cứu riêng — 11/10/2026

Người dùng yêu cầu triển khai host không UI tái sử dụng collector LB, thay vì dịch ngược toàn bộ field/hook. Thử nghiệm cô lập tại `.research/lb-headless/` (Git ignore); không sửa source/backend/UI đang được xử lý ở nhánh khác. SDK .NET 10.0.401 portable tải từ Microsoft, xác minh SHA512, nằm trong cache project. Chưa copy/phân phối DLL LB hoặc hoàn tất launcher cùng app.

Đã build CollectorHost, nạp thư viện Common/GameLib/Host/Farsight nguyên bản và resolve GameLibFetcher/AuthApiGatewayClient/IngameConfigFile. Đọc phiên đăng nhập hiện có trong bộ nhớ, gọi dịch vụ xác thực/làm mới chính thức thành công; so sánh trước/sau xác nhận file Credentials.bbd gốc không thay đổi. Không log/export token, không patch DLL, không giả feature grant, không bỏ version check hoặc thay đổi anti-cheat. Auth/update của BlueBottle vẫn là dependency; quyền phân phối lại thư viện chưa xác nhận.

LocalFarsightDataSource.StartAsync đã hoàn tất, IsActive=true và chờ game bằng detector riêng, không khởi động Interface.exe/WPF Application. HTTP/WebSocket loopback riêng thiết kế tại 4312; health phân biệt authenticated/collectorStarted/dataAvailable. Snapshot chưa có hoặc quá 5 giây trả unavailable/null, không lấp mock. Projection native có session/sequence, reset khi clock lùi, depth/list/body giới hạn, loại address/offset/buffer/credential. Schema lb-collector-native-v1 chưa tương thích ingame-state-update/adapter overlay hiện tại; chưa nối vào widget.

Kiểm chứng: build host 0 warning/error; 6 assertions SnapshotStore tổng hợp đạt; idle HTTP, WebSocket, missing-data 503/null và Host/Origin guard đạt. LB UI vốn còn chạy khi idle test; uiStarted=false chỉ chứng minh host không mở UI, **chưa chứng minh lấy được dữ liệu 10 người độc lập khi UI tắt**. Chưa có signed challenge/native module/snapshot trong game để kiểm chứng.

Bước tiếp theo cần người dùng: tắt LB hoàn toàn (tránh hai collector tranh IPC nội bộ 4998), mở replay hoặc spectator custom, rồi thu/kiểm tra Heroes/stat/objective và pause/seek/reconnect. Sau khi live đạt mới triển khai adapter và autostart cùng app ở nhánh source. README/lệnh/test của thử nghiệm tại `.research/lb-headless/README.md`; artifact ignored chỉ có trên máy này. Không coi port/process đang chờ là bảo đảm lâu dài.

### Ưu tiên mới: collector replay thấp hơn live — 11/10/2026

Người dùng bổ sung điều tra telemetry khi spectate replay `.rofl`, đánh dấu **ưu tiên thấp**. Live headless vẫn là việc chính; thay hướng “mở replay trước” trong bàn giao cũ và README thử nghiệm bằng spectator custom live trước. Không yêu cầu vào trận/replay riêng cho nhánh thấp lúc này.

Điều tra tĩnh thư viện đang cài: detector cửa sổ kiểm tra PID/tên executable, chưa thấy phân biệt replay/live trong chính hàm đó; log “inactive game” thuộc nhánh database và có thử StartNextGameAsync, không tự chứng minh native từ chối replay. Có Replay API và GameRewind ở lớp controller; vẫn có NotSpectatorException riêng. Chưa biết điểm ngăn `.rofl`, chưa có dữ liệu thật từ replay khi LB UI tắt. Chỉ sửa tài liệu/thứ tự kiểm thử, không thay collector/UI hoặc bỏ kiểm tra mode/version/auth. Kế hoạch và bằng chứng theo tầng tại `docs/LEAGUEBROADCAST_FEASIBILITY.md`, ưu tiên tại `docs/ROADMAP.md`; không cần chạy test ứng dụng cho lượt tài liệu này.

### Tiếp tục điều tra với skill REA — 11/10/2026

Đã cài skill reverse-engineer-anything bằng skill-installer và REA CLI 6.4.0 vào cache riêng; dùng Node 24.19 đã có, không đổi Node hệ thống/package overlay/MCP config và không cài engine native. REA chỉ xác minh artifact identity, member parser chạm budget 64 MiB trên Farsight/Common; ghi coverage unavailable, không dùng làm bằng chứng đã giải mã CIL. Tiếp tục bằng inspector dnfile/dncil. Ledger chi tiết local ignored: `.research/lb-headless/REPLAY_FINDINGS.md`.

Khoanh vùng mới: spectator gate dùng activeplayername cổng 2999, chấp nhận Unknown/Spectator/RPC_ERROR; 404 còn chờ đến cancellation. GameStarted theo sau kết nối/cấp feature; polling cần capture/native started/connected. Replay khác phản hồi ở gate là giả thuyết, chưa có mẫu runtime. Probe ngoài trận xác nhận không game/LB UI và 2999 unreachable, không chứng minh replay bị chặn.

Source CollectorHost thử nghiệm đã sửa lỗi GameInfoReceivedEventArgs.GameInfo khai báo object, hỗ trợ generated subclass; thêm health diagnostic và event counts, không xuất message/token/challenge. Build 0 warning/error, 9 assertions tổng hợp đạt; syntax probe và idle HTTP/WS/null/Host/Origin đạt. Đã dừng phiên agent cũ và khởi động bản mới khi không có game; không đụng process người dùng. Source/UI overlay không thay. Chưa xác minh telemetry live độc lập hoặc replay đầy đủ; bước cần người dùng vẫn spectator live khi LB UI tắt, replay cùng patch là ưu tiên thấp sau đó. Trạng thái process/port không là bảo đảm lâu dài.

### Khả thi collector replay — tiếp tục 12/10/2026

Theo yêu cầu tiếp tục replay, dùng quy trình evidence của skill REA, tái sử dụng artifact hash/evidence đã có vì Farsight không đổi; không lặp parser đã vượt budget. Đọc CIL thêm bằng dnfile/dncil: spectator gate chạy trước LoadLibraryEx, chưa thấy live-only trong đoạn gate/window đã đọc; native module vẫn chưa được xác nhận trên `.rofl`. GameStateMetaData không có property IsReplay/IsLive; không dùng Replay API hoặc GameState byte để tự xác nhận mode. Update module theo game build/version vẫn giữ nguyên.

Swagger archive dùng activeplayername không slash cuối còn LB dùng slash; chưa biết có khác phản hồi runtime hay không. Probe local ignored đã thêm cả hai URL và spectatorGateCandidate chỉ khi HTTP 2xx + body thuộc category chấp nhận, không log tên/raw credential hoặc spoof endpoint. Log cũ có cả inactive-game warning và kết nối/cấp feature thành công; warning không đủ chứng minh replay bị chặn. Riot Replay API chỉ contract camera/playback/process/render, không chứng minh telemetry 10 người.

Lần kiểm tra 22:41 Asia/Bangkok ngày 12/10: không game/LB UI, endpoint 2999 và host 4312 unreachable. Không tự khởi động collector hoặc điều khiển game; chưa có mẫu replay mới. Cú pháp probe đạt; không đổi source UI/backend/adapter, không cần test ứng dụng. Chi tiết tại `.research/lb-headless/REPLAY_FINDINGS.md`. Cần người dùng mở `.rofl` cùng patch ở 1× để đọc endpoint trước; nếu thử host thất bại cần đối chứng spectator live, không kết luận mode không hỗ trợ từ một failure. Replay vẫn backlog ưu tiên thấp, chưa có headless production thay LB.

### Phiên replay thật và yêu cầu dừng — 12/10/2026

Người dùng mở replay, LB UI tắt. Hai path activeplayername có/không slash đều HTTP 200/Unknown; Riot allgamedata trả 10 người ở clock khoảng 03:04. Không coi roster Riot là telemetry LB đầy đủ. Ba lượt host nguyên bản/auth hợp lệ nhận GameLoaded nhưng không GameStarted/GameInfo; snapshot 503/null, end-cause ClientDisconnected. Lượt chẩn đoán cuối xác nhận IPC connected rồi server đóng stream; native 4998 Listen thuộc game process và replay còn chạy 1×. Không quan sát native signed-challenge callback. Vì vậy chưa thu dữ liệu LB, nhưng cũng chưa chứng minh LB gốc không hỗ trợ replay.

Host nghiên cứu đã thêm stage logger allowlist không format/lưu argument hoặc credential, lastEndCause và history 64; build sạch, 13 assertions tổng hợp đạt. Source UI/backend/adapter không thay, DLL/check spectator/version/auth/transport không sửa. Evidence tổng hợp local ignored: `.research/lb-headless/replay-runtime-2026-10-12.json`; diễn giải/unknowns ở REPLAY_FINDINGS.md.

Người dùng báo replay hết và pause, yêu cầu lưu rồi đợi. Đã dừng host/inspection do agent tạo, giữ replay và LB nguyên trạng, không lập lịch hoặc tiếp tục điều tra. Bước sau chỉ khi người dùng yêu cầu: đối chứng LB gốc trên replay với host tắt, sau đó đối chứng spectator live nếu cần. Chưa có collector headless production thay LB hoặc xác nhận telemetry `.rofl` đầy đủ.

### Resume điều tra replay — 12/10/2026, 23:41–23:43

Người dùng cho tiếp tục. Replay mới/clock 00:44, PID game 20780 khác lượt trước; LB UI tắt. Host diagnostic hiện có ghi native-init-ok, IPC connected rồi server closed stream khoảng 67 ms sau, cuối cùng ClientDisconnected; không GameStarted/GameInfo/callback signed challenge. Native listener 4998 thuộc game. Đây là bằng chứng khởi tạo module trên replay mới thành công, không phải bằng chứng thu được telemetry. Source/DLL/check mode/auth/version không thay ở lượt này.

IdentifyToLib gửi nhận diện trước feature handshake; chưa chứng minh AppId là nguyên nhân đóng, không giả AppId để thử vượt kiểm tra. Evidence local ignored: `.research/lb-headless/replay-runtime-2026-10-12-resumed.json`; ledger REPLAY_FINDINGS.md. Đã dừng host để tránh tranh IPC và yêu cầu người dùng mở LB gốc trên replay làm đối chứng. Chờ thao tác đó; chưa có collector thay LB hoặc replay telemetry đầy đủ.

### Đối chứng xác nhận LB gốc lấy được dữ liệu replay — 12/10/2026, 23:46

User mở LB gốc trên replay, host nghiên cứu dừng. Capture 20 giây `data/captures/lb-2026-10-12T16-46-28-222Z` có 41 state frame thật (Running, isTestingEnvironment=false), clock 05:29→05:49, patch16.20.0, khoảng2Hz. Đủ10 người có gold/totalGold/level/KDA/CS/items và health/resource/ability cooldown fields. Gold/maxHP dương, có readyAt khôngzero; bốn HP0 phù hợp respawnAt trongtươnglai. **Perks array rỗng10/10**, chưa xác minh rune, pause/seek/tốc độ khác hoặc objective/damage/end-game. Không gọi đây là mọi telemetry replay đều đầy đủ.

LB gốc log native feature granted và IPC **NamedPipe**; inactive-game warning xuất hiện nhưng vẫn nhận frame. Kết luận đã chứng minh: LB không chỉ thu spectator live, mà thu được các field trên từ replay hiện tại. Lỗi stream-close của host chưa được giải thích; tập trung bootstrap/transport/identify theo giao diện được hỗ trợ, không giả AppId/grant hoặc patch DLL. Headless production vẫn chưa thay LB.

Evidence local ignored: `.research/lb-headless/replay-lb-original-control-2026-10-12.json`; capture có REPLAY_CONTROL_FINDINGS.md; dùng quy trình đối chứng/evidence của skill REA, không gán kết quả cho decompiler chưa hỗ trợ. Chỉ thêm analyzer/report nghiên cứu và capture, không sửa UI/backend/theme. User báo game tạmđóng và sẽ mở replay mới; host giữdừng, không tự điều khiển game/LB. Bước tiếp chỉ khi replay mới sẵn sàng: pause/seek hoặc đối chiếu transport/init headless với LB gốc.

### Đối chiếu NamedPipe và serialized context — lượt tiếp theo

User cho tiếp tục khi replay mới/LB gốc Running. Host diagnostic thêm transport allowlist; thử như client thứhai qua module cósẵn, không coi là độc lập LB UI. Cả LB gốc và host đều NamedPipe; host server-closed-stream sau khoảng69ms, LB vẫn good/2Hz/dropped0. Variant queue STA khôngUI (`COLLECTOR_SERIAL_CONTEXT=1`) cũng bị đóng khoảng63ms, không callback ký/GameInfo. Không sửa AppId/DLL/quyền/transport verification. Đã dừng host sau mỗi phép thử, giữ LB/replay do user quản lý.

Source thửnghiệm có QueuedContext opt-in và stage transport; build sạch, tổng17 assertions tổnghợp đạt, không phải test telemetry. Native static string/export inventory và hai bblog đãflush chưa đủ control-flow/causal evidence. Hash/observations/timestamps ở `.research/lb-headless/replay-transport-context-comparison.json`; ledger REPLAY_FINDINGS.md. Source UI/backend/adapter/theme khôngthay.

Replay telemetry qua LB gốc đã chứngminh cho sample16.20.0, headless chưahoànthành. Lỗi bootstrap/identify/protocol vẫnunknown; không giả AppId/grant để thử. Theo skillREA, điều tra sâu cần native engine; máy chưa có Ghidra/JDK nhậndiện được. Chưa cài/sửa MCP. Bước tiếp cần user cho phép cài engine/JDK cô lập trongcache hoặc cung cấp đường diagnostic/tích hợp chính thức; không lặp managed parser hoặc native connect cùng input.

### Checkpoint REA/native — tạm dừng theo yêu cầu 13/10/2026

Người dùng đồng ý tải công cụ rồi yêu cầu lưu và chờ. Ghidra12.1.4 và full JDK21.0.12.1+1 đã tải từ NSA/GitHub và Eclipse Adoptium, khớp SHA256 chính thức, giải nén trong `.npm-cache/rea-native/`; java version đạt. Không cài hệ thống/đổi PATH/MCP config hoặc sửa game/DLL. lblib hash không đổi. REA6.4.0 stdio khởi động và trả catalog; chưa có native import/decompile thành công.

open_binary lần đầu dừng ở realpath/access_denied EPERM; request có path Windows escape gấp đôi nên chưa quy lỗi cho sandbox hoặc target. Response lưu nguyên tại `.research/lb-headless/native-evidence/001-open_binary.json`, không có pseudocode/Evidence thành công. Điểm tiếp tục: canonical path dùng slash thường, output evidence mới; nếu vẫn EPERM thì approval đọc artifact qua client, không copy để lách quyền. Sau đó phân tích IPC/bootstrap/IdentifyClient theo skillREA. Chưa cần mở replay cho bước tĩnh.

Đã đóng phiên REA do agent tạo, CollectorHost giữ dừng; không điều khiển game/LB. Ledger/checksum/lệnh ở `.research/lb-headless/REPLAY_FINDINGS.md` và `prepare-native-tools.ps1`/`native-session.mjs` (local ignored). Headless vẫn chưa thay LB; khả năng replay qua LB gốc đã chứng minh ở sample trước, không phải mọi field/mode. Không thay source UI/backend/theme và không chạy test ứng dụng cho lượt nghiên cứu này. Chờ yêu cầu tiếp, không tự lập lịch.

### REA/native thành công, chờ kiểm chứng optional Identify — 13/10/2026

Theo yêu cầu tiếp tục: canonical path vẫn EPERM trong sandbox; execution được
cấp quyền open đúng lblib hash, không copy để lách quyền. Sửa signature timeout
MCP SDKv2; provider330s chưa đủ, budget900s hoàn tất Ghidra12.1.4 auto-analysis
khoảng470s. Có native pseudocode và evidence thật, không chỉ string inventory.
Overview20.268 procedures/17.477 defined strings; không suy độ phủ nghiệp vụ.
Bundle21records/7.146.969bytes local ignored tại
`.research/lb-headless/native-evidence/2026-10-13T02-02-27.302Z/complete-bundle.json`.

Khoanh vùng accept worker0x1803c1580, processPID/session/TokenUser checks rồi
gửi BBP2 admission. CIL Farsight xác minh đủBBP2 + serverPID trước khi log
Connected/NamedPipe. Vì host sample cũ đã có marker này, lỗi ở **sau admission**,
không giải thích bằng gate cùnguser/session. Không bypass kiểm tra native.
Dispatcher post-admission/root cause vẫn chưa xác định; giữ giới hạn decompiler/
truncated valueflow. EvidenceIDs/offsets/coverage tại REPLAY_FINDINGS.md.

Audit managed độc lập theo skillREA: StartAsync tự cấu hình collector; không
thấy bước bắt buộc bị bỏ trong scope. Host gán AppId nghiên cứu nonempty nên
gửi optional IdentifyClient; CIL null/empty bỏ lệnh này, scan7assembly không
setter app chuẩn (runtime/reflection/plugin chưa loại trừ). Chuẩn bị opt-in
`COLLECTOR_LIBRARY_DEFAULT_ID=1` giữ nguyên default thư viện, không force null/
giả danhLB; auth/callback/features/version không đổi. Build0warning/error,
20syntheticassertions đạt; **chưa chạy variant vào game**, chưa lấy GameInfo.

Đã đóng REA/Ghidra, giữ collector dừng và không điều khiển game/LB. Source
UI/backend/theme không đổi, không chạy test ứng dụng/commit/push. Cần user
tắtLB, mở replay cùngpatch1× và báo sẵn sàng để kiểm chứng variant mới, không
lặp trial cũ. Headless vẫn chưa thayLB; replay gốc đã chứng minh giới hạn sample.

### Replay thử mới: identification không giải quyết, access bootstrap bổ sung — 13/10/2026

User mở replay/LBtắt. Readprobe được cấp quyền xác minh gamePID30632/session6,
map12KIWI/10player/1×; sandbox không thấy API không được coi game tắt.
Variant library-default-ID vẫn NamedPipeconnected→closed~32,50ms,
ClientDisconnected, không GameStarted/GameInfo, snapshot503. Native thực ở
hostbin/lblib.dll hashtrùnginstalledcurrent, không thấy mismatch version/hash.

Tìm thiếu bước managed: login validation không nạp CredentialsConfig access.
Thêm authoritative signedGET subscription-status qua gateway nguyên bản,
chỉFound+Response, ResolveExistingFeatures/UpdateAccess nguyên bản trongmemory.
Không claim/provision/override/tierguess/forgegrant; file credentials gốc
checksum không đổi. NoAccount/Unavailable/unknown metadata khôngcollector.
**Empty được giữ đúng semantics thư viện**, không tự ép quyền nonempty:
RequestFeatures(Empty) trảtrue theo design; log đối chứng LB gốc trước có
Features arraycount0 nhưng vẫn nhận41frame/10player. Empty không phải root
cause/thiếu license đã chứng minh.

Lượt accessloaded + librarydefault vẫn close~30,46ms, không data.
Health cónullablebool featuresempty, accessstatus/ready(metadata,khôngcoverage).
Lỗi reflection diagnostic banđầu đã sửa và ghi tách khỏi upstreamfailure.
Build0warning/error,31syntheticassertions đạt. Source ứngdụng UI/backend/theme
khôngthay; khôngappnpmtest/commit/push. Evidence runtime/local tại
`.research/lb-headless/replay-library-default-id-2026-10-13T10-56-29-545Z.json`,
`replay-access-loaded-default-id-2026-10-13T11-17-34-915Z.json` và ledger
REPLAY_FINDINGS.md. Không nói thiếubootstrap đã giải thích tất cảfailure.

Collector/REA do agent tạo đãdừng, khôngđiềukhiểnplayback/game/LB.
Cần user mởLBgốc trên replay hiện hành, giữ1× và báoappxong để thu pairedcontrol
mới. Headless chưa thayLB; rootpost-admission/capabilities/clientclassification
vẫnunknown, khôngbypass. Giữ kếhoạch replay thấp ưu tiên hơn live nhưng lượt
thử này theo yêucầu trực tiếp người dùng.

### Đối chứng replay mới và tìm gate client độc lập — 13/10/2026

LB gốc đang mở theo user: capture20.034s có40state +1gameStatus,10player,
patch16.20.0,map12KIWI,Running/non-testing,clock109.48→129.77; gold/totalGold/
maxHP/maxResource dương10/10 và có level/items/ability cooldown. Perks rỗng;
damage/objectiveevents/pause/seek/endgame chưa xác minh. GamePID2912 mới, khác
30632 trialheadless; không gọi cùngprocessA/B. Capture-summary/report local tại
`data/captures/lb-2026-10-13T12-13-47-135Z`; health good/2Hz/dropped2.

REA/Ghidra tĩnh tìm dispatcher3db830: client không thuộc publisher tin cậy
phải qua authstate1 trước request19(SetClientCapabilities); state0 chỉ nhận
5/6/16, request khác gọiclose. AuthenticationVerify3e6780 cho nhómclient này
yêu cầu verifier success + bit9 trongfeaturemask; enum/BitIndex/BitMask managed
xác minh tên quyền là **Develop**. Empty-request bỏauth rồi gửi19 phù hợp với
post-admission disconnect cũ, nhưng chưawiretrace để chốt causal runtime.
Không khẳngđịnh thiếu license thôngthường, giá/góiDevelop hoặc originalLB
runtimeclassification; kết luậnLBgốc lấyđược replay vẫngiữ.

Headless chưa thayLB. Bước tiếp cần quyền tíchhợp/Develop hợp lệ do provider
cấp, hoặc documentedheadlessmode của originalsignedhost; cần user cungcấp
thôngtin/SDK đó trước trialmới. KhôngpatchDLL/gate, giảpublisher/AppId/grant,
đổiownership hoặc tựmua/claim/subscription/vendorcontact. REA/Ghidra/collector
do agent tạo đãdừng, khôngđiềukhiểnLB/game. HashDLLgốc khôngđổi.

Evidence/giới hạn tại `.research/lb-headless/NATIVE_CLIENT_FINDINGS.md`;
bundle31records +managedcontractv3 dưới native-evidence/2026-10-13T12-16-50.807Z.
Chỉ thêm nghiêncứu/analyzer và bàn giao, khôngsửa UI/backend/theme/appsource,
khôngappnpmtest/commit/push. SkillREA dùng để tách evidence tĩnh/runtimemẫu
và rào cản còn thiếu, không coi pseudocode là thực thi hoặc source nguyênbản.

### Kiểm tra tài liệu tích hợp Bitfocus — 13/10/2026

Đã đọc HELP và source module công khai tại commit Bitfocus
`096e4ed6c06f3a0eeca04a2e2c9b552f038a36f3` (10/10/2026), qua GET chỉ đọc.
Module yêu cầu LB đang chạy/đăng nhập, kết nối WebSocket `/ws/rpc` tới API app
(mặc định58869), nhận trạng thái panel/roster tối thiểu và điều khiển overlay,
recap, teamfight-start/stop. Không phải collector trực tiếp từ game; không giải
quyết LB tắt và không cấp quyền Develop. Local trust/pairing/Basic trong tài liệu
thuộc API app, khác gate native đã tìm. Không hứa damage telemetry từ tên lệnh
hoặc chuỗi entryJson chưa có schema/mẫu.

Report/source links và phạm vi tại `.research/lb-headless/BITFOCUS_FINDINGS.md`.
Chưa thử runtime API Companion với LB hiện tại, chưa cài/khởi động Companion,
gửi lệnh thay trạng thái, tạo token, đổi firewall/subscription hoặc liên hệ hãng.
Không sửa source ứng dụng/UI/backend/theme; không cần app tests cho tài liệu.
Bước tiếp là khảo sát chế độ nền/headless chính thức của host LB gốc hoặc quyền
tích hợp collector được hãng cấp. Headless thay LB vẫn chưa hoàn thành.

### Chốt collector riêng + đăng nhập, chuẩn bị trial auth — 13/10/2026

User xác nhận cần tách collector tích hợp app, không chạy ẩn toàn LB; được dùng
đăng nhập/xác thực tài khoản, không cần bỏ auth. Giữ hướng này, không tự chuyển
sang tray/minimized LB. Không coi thiếu SDK công khai là proof mọi cách tách
đều bất khả thi hoặc hãng đã từ chối tài khoản ở signed challenge chưa thử.

Inventory tĩnh3DLL khớp hashes; lblib21exports không có GetSnapshot C ABI trong
export table. Selected managed surface vẫn thấy LocalFarsight/LeagueConnector/
IPC2; không chứng minh phủ toàn internal APIs. CIL AddFeatures chỉ khai báo
RequestedFeatures, callbackCore dùng nonce thật và signature/bits provider.
Gateway POST xác thực challenge, không claim/mua/nâng subscription ở scope đọc.

Thêm variant nghiên cứu opt-in COLLECTOR_AUTHENTICATE_CLIENT=1 cùng
COLLECTOR_LIBRARY_DEFAULT_ID=1: request client auth bằng public AddFeatures,
giữ CurrentFeatures/access/grant nguyên bản. Server không trả bit cần thiết thì
fail closed; không tạo signature/bit, giả publisher/AppId, patch gate/DLL hoặc
custom hook. Presence bit trong health không phải native authorization/data.
Điều chỉnh kết luận: access metadata Empty không tự chứng minh signed response
thiếu Develop, vì callback chưa chạy trong trial cũ. Chưa có collector thayLB.

Build0warning/error,45assertions tổng hợp đạt; parser Python compile đạt.
Chưa chạy Collect variant/auth provider request mới. Read-only13:54Z thấyLB
gốc11904/session6, khônggameprocess và2999 unreachable. Không tự dừngLB/game.
Cần user tắtLB và mởreplay1× sẵn sàng để thử handshake có căn cứ mới. Source
app UI/backend/theme/adapter khôngthay; khôngappnpmtest/commit/push.
Plan/evidence tại `.research/lb-headless/AUTHENTICATED_COLLECTOR_PLAN.md` và
acquisition-surface/auth-sequence-2026-10-13.json. SkillREA dùng để tái sử dụng
native evidence và giữ ranh giới static/runtime; managed parser không thực thiDLL.

### Runtime auth collector riêng: provider không trả quyền client — 13/10/2026

User báo sẵn sàng: LB tắt, replay newPID13220/session6, Riot endpoints200/
10player/clock69.63. Build sạch trước Collect. Variant library-default-ID +
client-auth đã đăng nhậptrue, NamedPipeconnected, nhận challenge thật và gọi
officialgateway. Response success/có signature+feature-array nhưng không bit9/
Develop. Host guard fail closed trước native AuthenticationVerify; không
GameStarted/GameInfo, snapshot503, ClientDisconnected. Không kết luận native
đã kiểm chứng signature của response này, hoặc replay unsupported.

Đã kiểm chứng đăng nhập/challenge hoạt động nhưng response tài khoản hiện tại
chưa đủ cho đường collector độc lập. Không gán bit/signature, giả publisher/
AppId, patch DLL/gate hoặc thử route tránh auth. Không chuyển sang chạy ẩn LB.
Headless thay LB chưa hoạt động; không lặp trial không có thay đổi quyền/nguồn.

Runtime metadata3samples tại `.research/lb-headless/replay-client-auth-2026-10-13T14-07-23.824Z.json`;
diễn giải/unknowns `CLIENT_AUTH_RUNTIME_FINDINGS.md`. Không lưu authpayload/
token/nonce/signature/bitmask. HostPID2500 đã dừng;14:08:43Z (21:08:43Bangkok)
không còn PID/Listen4312, replay vẫn200/10player/clock311.40. Không dừng game/LB.
Credentialfile metadata LastWrite trước trial; checksum before/after chưa
hoàn tất doPTY ngắt, không suy timestamp thành hashunchanged.

Chỉ thêm capture/report nghiên cứu và status; app UI/backend/theme/adapter không
thay, khôngappnpmtest/commit/push. SkillREA dùng để đối chiếu gate tĩnh với các
stage runtime có giới hạn, không claim attach hoặc đầy đủ executiontrace.
Bước tiếp cần quyền client hợp lệ/response khác hoặc người dùng chọn nghiên
cứu acquisition khác với fieldcoverage riêng; chưa có đường thayLB đã xác minh.

### Producer LB: đào sâu tĩnh — 13/10/2026

User chọn tập trung phần tạo dữ liệu sau khi đọc thông báo Riot29/09 về chặn
memory từ06/10/2026 và grace đến04/2027. Không coi LB chạy được hoặc account
phụ là bảo đảm collector mới được phép/an toàn; không đổi LB dependency production.

REA/Ghidra tĩnh + parser CIL khoanh rõ receiver: LocalFarsightDataSource bật
capture rồi chuyển tiếp GameInfo; Farsight đăng ký periodic service hoặc yêu
cầu một snapshot, decode FlatSharp Response và phát event. Hai callback native
cùng tới builder43eea0; builder duyệt object bằng wrapper gọi hàm nội bộ ở
base+entry resolved, phân nhóm, build tables/vectors và clock. Startup lấy
base bằng GetModuleHandle(NULL). 8 direct RPM callers được lấy pseudocode,
các call site thấy GetCurrentProcess, không phải external OpenProcess reader.
Một số chỉ đọc PE header/table pointer; không gộp thành player telemetry.
Mô hình in-process là suy luận có căn cứ tĩnh + control trước, không live trace.

Đã khoanh ứng viên Hero serializer43c210 nhưng chưa map HP/gold/item/cooldown
từng getter với schema. Bảng địa chỉ/version nguồn nạp và lifecycle producer
còn chưa rõ; auth gate không giải quyết. Nạp DLL vào app riêng không tự chứng
minh có trạng thái game. Chưa tạo collector độc lập hoặc bất kỳ bypass nào.

Report `.research/lb-headless/DATA_PRODUCER_STATIC_FINDINGS.md`; bundle REA
46records/664460bytes tại native-evidence/2026-10-13T14-32-13.805Z, cùng5JSON
CIL data-flow. Sửa một typo Evidence ID dispatcher theo bundle cũ. Node24.19
có sẵn khắc phục lỗi admission file ở lượt Node22, không patch check/tool/DLL.
REA close thành công, launcher exit0; không chạy collector hoặc đọc game memory,
credentials/IPC/provider mới, không đổi UI/backend/theme, không commit/push.

Bước tiếp tĩnh: map FlatBuffer schema→native builder→selected getter, trace
bảng địa chỉ/version và event lifecycle. Chưa cần người dùng mở game hoặc tạo
account phụ. Mốc này chỉ là khảo sát producer, không headless đã hoạt động.
Kiểm chứng analyzer compile/5JSON lọc string và Evidence references đạt;
hash lblib trước/sau khớp, process REA do lượt này tạo không còn lúc check.
Không chạy test ứng dụng vì source ứng dụng không thay ở nhánh nghiên cứu này.

### LB scalar bindings/version; một nguồn ưu tiên — 13/10/2026

User yêu cầu tiếp tục tĩnh; có thể cân nhắc Riot2999 để bổ sung nhưng chốt ưu
tiên một nguồn đầy đủ vì đồng bộ/ổn định. Chưa ghép provider hoặc sửa ứng dụng.
Đã decode metadata39models/278serializedproperties, đối chiếu native wire slots,
caller stack args và getterbody:10scalar bindings HP/maxHP, Gold/TotalGold,
Resource/MaxResource, Experience, VisionScore, RespawnTime, GoldGivenOnDeath.
Schema/table matching xác nhận nhóm AIHeroClient/AIClient, không chỉ reserve10.
Mapping derived-static, không live trace hoặc collector thay LB đang chạy.

Spell metadata có ReadyAt/MaxCooldown/Cooldown và slot Item1–6/trinket/quest;
không suy GA/item activation đã runtime kiểm chứng. Level virtual getter/KDA/
item/perk chi tiết chưa map đủ. Native resolve helper có candidate/byte-pattern/
instruction decode/cache; managed GameLibFetcher trong GameLibDLL chọn artifact
S3 theo min/max gameversion và validate trước thay file. Chỉ đọc CIL/pseudocode,
không gọi auth/S3/download hoặc sửa checks/files provider.

Audit Riot2999 snapshot19/09 chỉ đọc:10/10 level/KDA/CS/vision/items/spell identity/
rune summary,0/10 gold/HP/resource; slots0–6, không cooldown hay9perk proof.
Không coi sample cũ là current patch hoặc frame ghép đã đồng bộ. Hybrid chỉ là
dự phòng nếu cần, phải match cùngtrận/player/clock/epoch và freshness/provenance;
chưa triển khai và không thay thế missing independent-client grant.

Report `.research/lb-headless/FIELD_BINDINGS_AND_VERSION_FINDINGS.md`, native
bundle18records/2199312bytes tại native-evidence/2026-10-13T16-06-09.529Z,
schema-v2/native-field-map/riot-coverage JSON và analyzers riêng. REA đóng thành
công/launcher exit0; không bật game/LB/collector, đọc game memory, hook/inject,
provider request mới hoặc credential. App/UI/backend/theme không thay, không
commit/push. Chưa cần game vì static vẫn còn lifecycle/source-table cần làm;
game mới đơn thuần không giải quyết gate Develop ở collector hiện tại.
Kiểm chứng: analyzer compile/syntax,10mapping và mọi Evidence link đạt; CIL string
đã lọc. Hash lblib cuối khớp; own REA/Java đã dừng lúc check. Không chạy app tests
vì không đổi app; không coi mapping tĩnh là test telemetry/permission runtime.

### LB initialization/readiness; cần replay để đối chứng — 13/10/2026

Tiếp tục theo yêu cầu chạy đến khi cần người dùng bật game. REA tĩnh nối
process-attach → worker42ee00 →8provider contexts →IPC server/worker status.
Export BlueBottleHook chỉ chuyển CallNextHookEx trong pseudocode đã chọn,
không phải snapshot/collector API. Chưa giải hết nested provider targets hoặc
cold-start/late-attach. Đính chính byte DAT180d08f8e: opaque send-gate, initial
byte trên đĩa01; chưa biết writer/semantic, không gọi là game-ready đã chứng minh.

Managed audit phân biệt NativeGameStarted (handshake complete), captureStarted
(intent/gate), service ACK (bool bị bỏ trong method chọn) và first valid GameInfo.
Event/connected không chứng minh10player/freshness; GameEnded có thể disconnect.
Không kết luận bug toàn app từ selected-method coverage. Collector độc lập vẫn
chưa hoạt động; missing Develop không được giải quyết bằng bật game hoặc2999.
Ưu tiên một nguồn đầy đủ, chưa ghép provider, không chạy lại trial thiếu quyền.

Đã chuẩn bị `.research/lb-headless/public-lifecycle-probe.mjs`: chỉ đọc LB public
feed và GET2999 replay clock; chỉ giữ thời gian/count/availability, không player
identity/stats values/credentials/raw payload, không privateIPC/memory/hook.
Syntax và7synthetic assertions đạt, không network trong self-test; runtime chưa
chạy. Presence/clock không chứng minh semantic correctness hoặc cùng identity.

Report `INITIALIZATION_AND_RUNTIME_PLAN.md`, `MANAGED_READINESS_STATIC.md` trong
nhánh nghiên cứu; bundle native8records/115186bytes tại
native-evidence/2026-10-13T16-30-49.913Z, hai JSON managed CIL9+4methods.
REA close thành công/launcher exit0; kiểm tra ownPID16544/14652 không còn và
hash lblib khớp. Không thay app/UI/backend/theme, không app tests/commit/push.

Bước tiếp cần người dùng mở LB gốc + replay Summoner's Rift cùng patch1×, báo
sẵn sàng; hướng dẫn baseline/pause/resume/seek từng bước khi probe chạy. Đây là
đối chứng replay/freshness, không permission bypass hoặc headless proof. Chưa
kiểm tra game/LB đang chạy ở thời điểm bàn giao; không coi port/process là đảm bảo.

### Replay pause/resume/seek đối chứng thật; chưa collector riêng — 13/10/2026

User mở LB gốc/game và hoàn tất pause10s/resume20s/seekback30s/1×. Publicfeed
baseline20frames/10s; transition327frames/180s +346replaypolls.327/327frames
đủ10players, gold/totalGold/HP/resource/items/abilitycooldown presence10,
perks0. Pause window10.936s có1LBframe, gap11.074s; resume stream chạy lại;
seek clock replay lùi33.605s, LB lùi33.523s, receive-time hai rollback cách0.478s.
Không suy latency guarantee, fieldvalue correctness/fullitem-GA/perks support.
LBplaybackSpeed vẫn1 trong một pauseframe, không dùng riêng để suy đang chạy.

GET2999 current sample200/10players/**map12**, không phải kiểm chứng map11SR:
level/KDA/CS/vision/items/spellidentity10, gold/totalGold/HP/resource/runesummary0.
API mẫu hiện tại chưa đủ thay LB; không ghép provider. Clock/count không giữ
identity nên không chứng minh cùngmatch/player toàn diện. Restricted probe đầu
không kết nối; approvedhost-read lấy được cả feed/2999, không gán lỗi đó chogame.

Report `.research/lb-headless/REPLAY_LIFECYCLE_RUNTIME_FINDINGS.md`; captures
public-lifecycle-2026-10-13T16-50-28.248Z.json và16-51-25.605Z.json,
riot-public-coverage-2026-10-13T16-54-34.080Z.json. Metadata/count/clockonly,
không credentials/raw payload/playeridentity/stats values/privateIPC/memory.
Probe/analyzer syntax, publicprobe7synthetic assertions và runtime reads đạt;
probes exit0, không dừng LB/game; sourceapp/UI/backend/theme không thay,
không apptests/commit/push. SkillREA phân biệt retainedstatic với runtimeprobe;
không chạy lại host đã thiếuDevelop hoặc bypass. Không còn native session mới.

Đã giải thích: reuseLBengine cần admission hợp lệ; engine riêng không cần quyền
LB nhưng acquisition/fieldcoverage/patchmaintenance và giới hạnRiot chưa giải.
Kiểm tra lại thông báoRiot13/10: unknownmemorytool chặn từ06/10, approvedgrace
đến04/2027 rồi officialAPIs; không hứa memoryreader riêng dùng bền vững.
Hiện chưa thể hoàn thành yêu cầu đầy đủ khôngLB chỉ bằng dịch ngược tĩnh/API2999.
Không cần người dùng thao tác thêm cho bàipause/seek hiện tại; next phải xác
định nguồn độc lập thật/được phép cho missingfields, không lặp quyềntrial vô ích.

### Engine LoL riêng: lõi/gateway prototype — 14/10/2026

Người dùng chọn xây engine riêng, không dùng engine/xác thực LB. Đã triển khai
`IndependentEngine`, server loopback4313 và launcher `npm run engine:lol`.
Instance collector riêng tái sử dụng adapter/session/objective nội bộ, chỉ GET
API2999; không LB DLL/login/privateIPC/feed hoặc memory/hook/patch. HTTP health,
snapshot, capability và WS receive-only; guard Host/Origin/method, bound payload/
client/backpressure, cleanup process do launcher tạo. Không sửa provider output,
UI/theme hoặc tự khởi động module cùng app production.

Prototype phân biệt unavailable/clock-only/partial, báo coverage mẫu hiện tại,
`replacementReady=false`, null khi thiếu; lỗi nguồn/stale quá5s xóa sample và
events, seek seed lịch sử/tăngepoch. Core có collector interface cho acquisition
mới khi có nguồn thật được kiểm chứng. Đây là lõi độc lập, **chưa engine thu đầy
đủ thayLB**; chưa nguồn riêng cho HP/vàng/cooldown/perks/buff/quest đầy đủ, chưa
damage/combat, full parity hoặc autostart. Mục tiêu đủ dữ liệu nhưLB không đổi.

Kiểm chứng:8/8 test mới core+HTTP/WS tổng hợp đạt;124/124 toàn bộ unit/regression
đạt, build đạt, integration backend4311/theme tạm đạt gồm transport/reset.
Sandbox từng chặn loopback và Vite realpath; chạy lại với quyền host phù hợp đạt,
không sửa source để né. Npm PowerShell wrapper bỏ flags, bounded smoke dùng
`npm.cmd run engine:lol -- --port 4313 --duration 5000`: startup/exit0, output
unavailable/0players trong phiên này, không chứng minh game telemetry. Cổng4313
không còn listener lúc kiểm tra; không dừng game/LB hoặc process không sở hữu.

Runbook `docs/INDEPENDENT_LOL_ENGINE.md`, README/architecture/roadmap cập nhật;
chỉ thêm source/tests/docs và một npm script, giữ mọi thay đổi nhánh khác.
Không commit/push. Bước tiếp quyết định: chứng minh nguồn độc lập được phép cho
field còn thiếu trên mode/patch mục tiêu; chưa cần thao tác game cho lõi này.
Chỉ sau acquisition proof mới nối Studio/OBS/autostart và bỏ LB dependency.

### Engine riêng: acquisition evidence, cần test game — 14/10/2026

User yêu cầu tiếp tục đến khi có dữ liệu hoặc cần họ test. Đã thêm báo cáo hữu
hạn `--report` theo từng mẫu và probe status/timing riêng haiGET2999; không raw
frame/identity/statsvalues/credentials. Coverage thêm inventory/spells/keystone/
vision/death/respawn, kiểm tra roster5+5/10slot, perks9ID, cooldownnonempty;
rejectLB/recording input để không giả independent provenance. Hai clock lệch
>1s gắn divergent, không suy receive freshness là datafreshness/cùngmatch.
Chưa tự giải coherence hoặc hỗ trợ đầy đủ QWER/item/buff/quest; replacementReadyfalse.

Rà nguồn primary Riot không thấy routeall10HP/gold/cooldown mới được tài liệu
hóa; activeplayer khác allplayers, Replayrender visibility kháchealthstats.
Đã thêm `scripts/inspect-game-client-schema.mjs`, đúng mộtGET publicSwagger2999,
deadline3s/body4MB, lưu chỉ route/model/propertynames, không auth/POST/gamecontrol.
Syntax và16syntheticparser assertions đạt, không chạy requestgame trong lượt.

Host read-only chỉ thấyLB58869, chưa2999. Smoke2sengine+report startup/exit0,
unavailable/0players, report `data/engine-reports/engine-2026-10-13T17-26-13.621Z.json`
(UTC; ngày local14/10); không coi là acquisition thật.12engine+3collector test
riêng đạt;128unit/regression vàbuild đạt, integrationbackend riêng đang được
kiểm chứng ở phiên4311/theme tạm. **Kết quả cuối: integration đạt**, gồm observer,
transport/reset, scenes/theme, providers và capture playback. Không đổi UI/theme/providerproduction,
không nativeREA/memory/IPC/auth mới, không commit/push. Parallel review/audit
chỉ source/APIpublic; không mở game hoặc dừng LB thayngười dùng.

Runbook cập nhật, chi tiết `docs/INDEPENDENT_ENGINE_ACQUISITION.md`. Bước tiếp
cần người dùng tắtLB và mở replaySRmới/cùngpatch1×, báo sẵn sàng để engine thu
mẫu thật +schema patch. Mục tiêu đầy đủ nhưLB chưa đạt; nếu test vẫn thiếufields,
phải ghi thiếu nguồn acquisition, không kéo dài bằng wrapper hoặc giảdata.

### Memory collector / tách LB: ranh giới chưa được giải — 14/10/2026

User chốt mục tiêu engine đọc memory tương đươngLB, không gửi authLB; hỏi nếu
decompiletoàn bộ thì bỏverification/giữcollector được không. Đã dùng skillREA
review retained evidence và hai audit độc lập, không mở native session/target
hoặc thử auth/runtime mới. Kết luận: chưa có collector-only khôngauth được
kiểm chứng. Auth không chỉ ởUI; producer còn contextgame/internalcalls/version/
lifecycle/events/readiness. Bỏ một tầng không chứng minh đủ snapshot hoặc giữ
quyền truy cậpgame. Trial13/10 dừng ởhost guard thiếuDevelop, chưa gửi native
verify; không nói native đã verify chữ ký rồi từ chối.

Prototype4313 vẫn gatewayAPI2999, không memoryreader; kiểm thử gateway không
phải acquisition proof. Yêu cầu mởgame test2999 trước đó không phải mốc tiếp
cho mục tiêu memory. Chưa cần userbậtgame cho host/quyền không đổi. Mốc cần giải
là đường acquisitiongame được phép cụ thể; không triển khai patchgate/giảgrant,
publisher/signature hoặc néVanguard để chạy collector gốc.

Report `.research/lb-headless/COLLECTOR_SEPARABILITY_DECISION.md`.4bundle chính
103recordoccurrences/98IDs riêng cùnghash, selectedcoverage không fullprogram.
Kiểm tra phát hiện typo1ký tự verificationEvidenceID trongNATIVE_CLIENT_FINDINGS,
đã sửa theo record thực; không đổi kết luận. Không sửa sourceapp/UI/theme/runtime,
không apptests/commit/push. Tiếp tục nghiên cứu kiếntrúc/data contract có ranh giới,
không hứa full decompile sẽ giải permission hoặc nâng gateway thànhfullcollector.

### Engine mới: probe memory chỉ đọc, chưa thử game — 14/10/2026

User chọn các hướng khả thi và engine mới tương đươngLB. Rà primary Overwolf
LoLGEP/ow-electron chưa có full10spectatorHP/gold/QWER/itemCD được tài liệu hóa;
replay analyzer công khai chỉ saved-replay/partial/exactbuild, chưa license
tái sử dụng rõ. Không cài/vendor/execute/đổi runtime hoặc liên hệ bên ngoài.
Không quay lại gateway2999 làm đáp án đầy đủ, không patchcollectorLBbỏauth.

Đã tự viết `.research/independent-memory/MemoryAccessProbe`: QUERY_INFORMATION+
VM_READ qua APIWindows thông thường, exactimage/modulepath guard, modulebudget256,
single explicit headerread64byte, metadata output không địa chỉ/bytes/rawstats.
Không write/privilege/debug/inject/driver/scanner/LBDLL/auth hoặc bypass. Game
mode chỉ sau humanconsent/replay/path xác nhận và ackclient-may-stop; chưa chạy.
64byte là explicitReadProcessMemorybudget; moduleAPI có thể đọcloader metadata.

Buildoffline SDK10.0.401 có sẵn đạt0warning/error; selftest trên ownprocess đạt
header-readable64/MZtrue/Win32error0. Đây không phải LoLdata: TelemetryFields0,
ReplacementReadyfalse, spectatorstateunverified. Invalidgame-mode thiếu điều
kiện bị từ chối trướchandle/read, đã kiểm chứng. Reviewer chỉđọc đã rà ABI,
handlecleanup/identity/budget và sửa lỗi errorcode stale. Không có memoryread
trên game trong lượt này, không app tests vì chỉ thêm experiment ngoài app.

Runbook `.research/independent-memory/README.md`, script build-self-test chỉ
ownprocess. Không sửa appUI/theme/provider/autostart, không càiSDK mới hoặc
đọc userNuGet/providerconfig (buildprofile task riêng), không commit/push.
Bước tiếp cần người dùng đồng ý test có thể bị chặn/clientdừng, tắtLB và mở
replaySRmới/cùngpatch1×. Denied thì dừng, không workaround; readable cũng chỉ
headerproof, chưa quyềnRiot/heaptelemetry/fullparity. Không hứa an toàn/account
hoặc thayLB chỉ từ kết quả selftest.

### Game memory probe thật: dừng trước RPM; bàn giao shutdown — 14/10/2026

User replay sẵn sàng(~30phút), yêu cầu lưu tiếntrình/shutdown khi dừng, rồi đồng
ý riêng boundedmemoryprobe có thể clientdừng. Preflight2999 có/58869không;
đườngimage xác định từ metadata cài vàfile, probe pathmatched. Một lần tại
18:09:22.640Z(01:09:22local): OpenProcess handletrue/identitytrue nhưng module
queryfailed, ExecutableModuleMatchedfalse, bytes0/Win32error0. Guard dừng trước
ReadProcessMemory. Không kết luận Vanguardchặn hoặc RPMđãbịdeny; causeunknown.
Không rerun/alternateenumeration/elevate/inject/driver/patch/authLB/statsread.

API engine trước39mẫu/20s, sau10mẫu/5s: roster5+5/10slot, GET200/clocktăng,
cùng gamePID/listener sauprobe; chưa thấy clientdừng trong cửa sổ đo. Mẫu báo
map12, khôngSRmap11. HP/vàng/resource/CD/perks/buff/quest vẫn thiếu; data này
là2999, khôngmemorytelemetry. Swagger200/19routes/16models chỉmetadata; chưa
routefull10mới được chứng minh. Readerfull/parity vàRiotpermission vẫn chưa đạt.

Checkpoint `.research/independent-memory/GAME_TEST_HANDOFF.md`, nativeoutput+
hashes `game-probe-2026-10-13T18-09-22Z.json`; reports
data/engine-reports/engine-2026-10-13T18-07-51.261Z.json và18-10-29.396Z.json,
game-client-schema-2026-10-13T18-08-01-829Z-e6f5afe9-770f-4764-aba6-c4f1f5ca3b31.
Không rawdata/identity/credentials/address/bytes, UI/theme/sourceapp không đổi,
khôngapp tests/commit/push. Reviewer chỉđọc: errorcapture có thể cải thiện,
không đủ chứng minh error0do timestamp; không sửaartifact/rerun trong phiên.

Đã đến giới hạn thử được chấp thuận, dừng nhánhmemory thay vì dùng hết30phút
hoặc thửbypass. Chuẩn bị shutdownuserrequested sau kiểm tra checkpoint/report;
chọn `/s /t 0`, không `/f` hay positive-timeout (help nói ngầmforce). Nếu app
chưa lưu chặnshutdown thì không cưỡngbức; commandaccepted không poweroffproof.
Bướcresume: đọc checkpoint này, không tự mởgame/LB; cần nguồnacquisition được
phép/cụ thể hoặc quyết địnhcapability khác, không hứa mộthandlecho fullstats.

### Diagnostic memory v2: đối chứng lab đạt, cần replay mới — 14/10/2026

User yêu cầu tiếp tục đến khi có kết quả hoặc cần mở game. Đã sửa own-source
probe, không decompile/native REA/session LB hoặc chạy game trong lượt này.
Capture error ngay sau mỗi P/Invoke, diagnostic explicit attempted/returned/
failed-stage, module-output null khi API false và byte count không clamp.
Không thêm quyền/route/budget game hoặc đổi guard; không giải auth/protection.

Harness mới `.research/independent-memory/test-lab.ps1` build offline bằng SDK
10.0.401 có sẵn, chỉ own-process và child tự tạo. Kết quả cuối 5/5, exit0,
không timeout: self/child header64 MZ; query-only module false/error5 dừng trước
RPM; invalid-own-read false/error299/0byte; invalid CLI không native +11checks
classifier synthetic. Đây không phải telemetry LoL. Helper exit0/remaining
output được xác nhận trong suite; timeout fallback PowerShell chỉ kill parent,
helper tự hết hạn15s, không hứa tức thì cả cây. Source review độc lập chỉ đọc.

Evidence cuối `.research/independent-memory/lab-evidence/2026-10-14T01-55-10-353Z-179871c0af7f4c2ab52bef9f25f9cf90.json`
giữ SDK/source/DLL/harness SHA256; báo cáo `.research/independent-memory/LAB_DIAGNOSTICS.md`.
Lượt lab đầu trước cleanup hardening cũng 5/5 và được giữ riêng. Không ghi đè
JSON/hash game trước. Lab không chứng minh timestamp gây Win32error0 game cũ,
không chứng minh Riot/Vanguard cho memory read hoặc full field access.
TelemetryFields0/ReplacementReadyfalse; LB vẫn cần cho production đủfield.

Không sửa app/UI/theme/provider/autostart, không app tests vì app source không
thay trong lượt này, không commit/push, không tự shutdown lại. Đã lưu tiến trình;
bước tiếp cần user mở replay SR mới/cùngpatch, LB tắt,1× chưapause/tua và đồng ý
một probe v2 mới có thể bị chặn/clientdừng. Chỉ một lần chuỗi API/budget cũ; fail
thì dừng/lưudiagnostic, readable cũng chưa cho phép statsread/fullcollector.

### Gói Collector mới: build và no-inject trên replay thật — 14/10/2026

User cung cấp `Collector/archive/packages/LeagueCollector-source.zip`, yêu cầu thử trên replay
đang mở và cho phép cân nhắc tua khi replay dừng. Đây là target mới, không lặp
probe64byte hoặc coi gateway2999 là collector tương đương LB. Đã đọc skill REA,
inspect archive/source bằng tools thường vì chưa có REA MCP/CLI; không gọi các
kết quả này là REA Evidence. Gói source gồm host/managed phục hồi + lblib gốc,
không native engine C++ hoàn chỉnh. ZIP hash59370210...efef264, DLL hasha1028d56...
3141d3 đã đo khớp sidecar. ZIP gốc giữ nguyên, giải nén đích mới có path guard.

Build offline SDK10.0.401 đạt, còn nhiều warning generated/reference; doctor
Windowsx64/PE đạt và selftest8nhóm đạt (synthetic, không game proof). Chỉ thêm
bounded lifecycle flag vào Program.cs của validation copy, giữ nguyên auth/
feature/version/spectator/inject code và native bytes. Không đụng app production.

Sau approval ra ngoài sandbox, preflight2999 HTTP200/replay1×/clock~295s,
map12. No-inject/no-LCU/no-account test port18803 trong~33s:33polls,29status200/
snapshot204/waiting/authnot-configured,4startupunavailable;0nativeframes/0hero.
TCP4998closed trước/sau,LB58869closed trước; chưa kiểm tra toàn bộ pipe/lịch sử
load DLL. Host tự dừng exit0, khôngforcedstop. Postcheck replay vẫn chạy1×,
clock~712s/HTTP200. EACCES lúc test trong sandbox là sandboxrestriction, không
gamefailure. Không cần seek/không POST playback/LCU trong lượt này.

Bằng chứng `Collector/evidence/validation/no-inject-2026-10-14T12-24-14.774Z.json`,
report `Collector/docs/VALIDATION.vi.md`. Không rawframes/playerstats/identity/credential/
memoryaddress. Không suy replayunsupported/authdeny/Developneeded từ no-inject
waiting. Default gói có DLLhook/injection, khác consent probeheader trước; đã
hỏi consent riêng một lần thử trên replay, chưa thực hiện. Không authpatch/
giảfeature/bypass hoặc tự download. Numeric presence/zero không Free parity.

Tua/pause dùng Replay API2999 được Riot tài liệu hóa, không LCU phỏng đoán;
script inspect mặc định GET, optionalresume chỉ sau pausedverified. Bước tiếp
cần user chọn đồng ý trial injection hoặc giữ no-inject; nếu có data mới mới
đối chiếu field/runtimesession. Không đổi UI/theme/provider/autostart, không
app tests/commit/push/shutdown. LB vẫn cần cho nhánh production đủtelemetry.

### Collector mới: consent một trial injection, chưa qua native ready — 14/10/2026

User đồng ý một lần nạp DLL gốc trên replay và approve command ngoài sandbox.
Đã chạy riêng port18804, preflightPlayback200/pausedfalse vàactiveplayername
Unknown/Spectator, không playerclient. Giữ hashDLL/managedFarsight/auth/feature/
version/spectator guard; khônglogin/LCU/update/rawrecord/bypass. Hostvalidation
copy thêm metadata stage/single-window/error-stop/timer; ZIP gốc nguyên vẹn.

Trial12:35:43.585Z: gameVersion16.20.824.8524,1game-window/1inject-reported,
0game-started/0nativeframe/0hero; TCP4998closed trước/sau,LB58869closed trước.
35polls:26status200/snapshot204/waiting/authnot-configured,8unavailable,
1snapshot204/statusunavailable. Không nhận snapshot, chưa xác minh native
initialized/handshake/service grant; Injected không là producerreadyproof.
Host không dừng sạch30s,watchdogterminateownedchild45s; exitCodeNULL/forcedtrue.
Windowsread-onlypostcheck xác nhận0process khớp exactDLL/validationflags.

**Giới hạn quan trọng:** replayclock lúc bắt đầu1229.523s, sau1234.220s;
GETeventdata sau test cóGameEnd1228.122s. Trial đã sau timestampkếtthúc trận,
không dùng để kết luận thu live-in-replay hoặc quy clockend cho DLL/anti-cheat.
Versionrange chỉ đáp ứng sidecar, chưa ABI/fieldparity. Chưa nativeauthdeny hoặc
Developfailure được đo. Authnot-configured không LBFreeverified.

Theo requesttua củauser, xác nhận clockđứngqua5s rồi POSTReplayAPI2999 mộtlần
về1114.220s/1×/unpause, HTTP200. KhôngLCU/configchange/reinject. No-injectsau
seek~31s có30status200/snapshot204/waiting,0frame,exit0/dừngsạch. GETmuộn quay
lạiclockend1234.220s; không lưuclockseriesngaysauPOST, không hứa resume/native
ready từ200. Không xem no-injectsau này là clientfresh/independentproof.

Evidence `Collector/evidence/validation/single-inject-2026-10-14T12-35-43.585Z.json`
và `no-inject-2026-10-14T12-43-26.566Z.json`, report `Collector/docs/VALIDATION.vi.md`.
One-shotmarker giữnguyên, khôngrerun/xóađểdùnglạiconsent. Suy luậnsource:
SourceWorkerawaitwatch/inject/connectloop CTSriêng vàstopwatchởfinally cóthể
không nhậncancellationhost kịp, phùhợp hangshutdown; chưa fulltrace/rootcause
duynhất hoặc verifiedfix. Bước tiếp sửa/kiểmchứnglifecycle/stagediagnostic
trước, sauđó replaymớiSR/chạytestsớm vàconsentmới. Không đổiapp/UI/theme/provider,
khôngapp tests/commit/push/shutdown; fullmemorycollector/LBparity vẫnchưađạt.

### Collector validation: lifecycle đã kiểm chứng lab — 14/10/2026

Chỉ sửa bản `Collector/src/LeagueCollector`, không app
production hoặc native bytes. Cancellation liên kết host/session, gate chống
khởi tạo trễ/startup trùng, thu hồi process watch/hook, quan sát completion của
disconnect/tasks/thread. Watcher validation một startup mỗi generation, không
tự retry/reconnect sau lỗi. Không thay xác thực/feature/version/spectator guard.

Build offline/doctor/serializer đạt; lifecycle lab **16/16**, không game access,
không telemetry. Toàn bộ log/hash/output lưu tại
`Collector/evidence/validation/managed-lab-2026-10-14T13-32-17-490Z-ef80476171a84b7dadc0e18f5783a601/`.
No-inject bản trước 14-ca exit0/dừng sạch~31s,31poll/0frame/0hero:
`no-inject-2026-10-14T13-30-10.763Z.json`. Bản cuối cũng exit0/dừng sạch,
31poll/0frame/0hero: `no-inject-2026-10-14T13-33-11.501Z.json`.
Postcheck đúng validation host còn0 process, lưu `lifecycle-final-postcheck-20261014.json`.
Async timeout không bao trùm cleanup đồng bộ; vẫn giữ watchdog owned-host.
Không tuyên bố lifecycle fix đã giải quyết native producer/auth hoặc full LB parity.

Passive IPC expected pipe absent/error2 và TCP4998 không bound tại thời điểm
probe; không connect/load/inject/request. Report `Collector/docs/VALIDATION.vi.md`
và review `Collector/docs/LIFECYCLE_REVIEW.vi.md`; không REA Evidence IDs do provider
không hiện diện. Script build/replay/IPC tự lưu mọi lượt kết quả đã lọc, không
credentials/raw player stats/address. Giữ các evidence thất bại và marker cũ.

User đồng ý một trial mới trên replay mới, chưa báo sẵn sàng. GET13:31:58Z vẫn
replay cũ map12/clock1234.220/GameEnd1228.122; chưa dùng consent mới. Bước tiếp:
user đóng replay cũ, mở replay SR mới/tắt LB/báo sẵn sàng; preflight trước end
rồi một bounded trial giữ DLL/quyền/guard, dừng khi lỗi. LB production vẫn cần.
