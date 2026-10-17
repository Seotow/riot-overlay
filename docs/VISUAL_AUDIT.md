# Audit giao diện LoL — 18/09/2026

## Các số đo bổ sung — 17/10/2026

Ảnh cyan Elder `codex-clipboard-31a4f690-8762-4de5-a093-1c83c4a30c13.png`:
crop icon123,15,34,38 có319 pixel cyan sáng, median RGB30,228,222 (#1EE4DE).
Màu là median ảnh nén/composited, không khẳng định màu source production tuyệt đối.
Mẫu player bars `codex-clipboard-fef32d02-cc29-488e-8b2e-6e673520d533.png`:
XP median126,60,117 (#7E3C75),energy200,217,75 (#C8D94B). Script
`measure-player-bars.mjs`; crop zoom `player-bars-reference.png`.

Simple giữ58px portrait,29px icon vàstrip29px,không gap giữa2spell. Geometry
đo sau animation, không đo lúc minimal-spread đang scale .86. Full/simpleXP
cùng widthHP, cao3.59375px thực so6px mục tiêu3.6/6; số cấp nằm cùng strip.
Powerplay track5px chạy toàn panel bên trongborder1px, màu icon. Bloom chỉ
từviền mờ30% vào trong; center40% được giữ. Các số đo này không là điểm giống
tổng thể hoặc xác nhận telemetry trận mới.

## PNG objective và thanh XP — 16/10/2026

Đối chiếu atlas `esportsneutraltimersatlas.png` Riot16.20 với ảnh hạ rồng và
Baron powerplay: giữ silhouette spectator gốc thay SVG threshold scanline cũ.
Hextech/Hóa kỹ/Herald dùng texture scoreboard; grub dùng glyph mặt từ sprite
match-history (không dùng vòng tròn minimap). Source/crop/hash trong manifest.
Ảnh tổng hợp trước/sau ở `.npm-cache/visual-audit/riot-objectives-sheet.png`
và `objective-candidates/contact.png`. Chưa đo IoU hoặc độ giống tổng thể.
Leaderboard286px không đổi; thanh XP từ152→190px bằng thanh gold, số cấp
đưa lên cùng hàng tên. Các icon ngoài hai họ mục tiêu được giữ nguyên.

## Motion và màu phụ — 16/10/2026

Đo ảnh `codex-clipboard-2dfc8320-7763-4bac-bd4e-ceb706315268.png`
1920×1080 bằng `scripts/measure-motion-layout.mjs`: line góc xanh 5px,
đỏ 5–6px; median màu xanh đã compositing RGB(76,143,179), logo xanh
RGB(19,105,189). Không coi màu pixel ghép nền là màu asset nguyên bản.
Minimal dùng line 5px và màu phụ configurable (#69afd4/#df7d86 mặc định).

Kiểm tra Edge 1920×1080 không ảnh nền: no-camera width 1346px;
row trái items x327/w154, quest491/w22, rune525/w18, spell555/w26,
champ589/w47, tên/HP647/w202, CS/KDA859/w62. Các cụm không chồng nhau.
Arrow inset -1px, strip rộng2px/inset4px; gold delta neo số tiền không neo
icon. Màu chính đã lưu của user được giữ; màu phụ tách riêng trong Config.
Ảnh PNG và JSON đo nằm `.npm-cache/visual-audit/`. Motion được kiểm tra
DOM/tương tác và ảnh trạng thái; chưa đo độ giống tổng thể95–98% hay video
animation từng frame. Giữ baseline cũ, không tuyên bố pixel-perfect.

## Nền HUD in-game — 12/10/2026

Đối chiếu trực tiếp ingame new.png: footage còn thấy sau nền HUD. CSS cũ chồng
scoreboard92%+91% thành gần99%, nên chỉnh thành một surface xám than; base72%,
main scoreboard78% (PNG alpha modal199/255), sub59%. Rank/row/rune bỏ layering
gần kín; timer/inhibitor/buff/minimal cũng dùng độ trong suốt phù hợp. Đây là số
đo renderer, không suy được alpha chính xác của Riot từ ảnh nén/nền khác nhau.
Preview composited dùng game-only crop không có HUD/camera, chỉ minh họa; OBS
không thêm ảnh nền. Font/ảnh/gauge giữ opacity, không thay đổi geometry.

## Layout simple cho caster — 12/10/2026

Geometry RCVolus layout-simple, giữ style project: header(0,0,1920,150), picks
x0/1520,y183,w400,h690; mỗi pick400×130, không mở rộng hover. Bans x45/1155,
y900,w720,h130; icon/khung giữ hiện tại. Vùng cam giữa1120×690 trong suốt;
đã kiểm tra screenshot alpha0 và xem ảnh render, không có nền reference.
Lựa chọn lưu cùng theme, bản broadcast không đổi geometry. Không đo95–98%.

## Cấm chọn production — 12/10/2026

Yêu cầu mới mở phần draft để hoàn thiện module. Đã xem `images/Cấm chọn.png`
và ảnh render OBS độc lập, không dùng footage/reference làm nền: bans xanh
(0,667,360,112), đỏ(1560,667,360,112), dải pick(0,790,1920,290), center
(800,790,320,290). Hover320px, các ô cùng phía120px; phía còn lại160px.
Timer strip ở x461/w998/y781. Branding từ config, sponsor-free và logo tùy chọn.
Base loading portraits có crop/skin khác ảnh; ban fixture vẫn là diễn giải cũ.
Không hiện số stats bịa. Module nhập tay/bộ mẫu; draft live chưa xác minh.
Kiểm tra font/asset/transparency1920×1080 và Studio1280px đạt; không kết luận
95–98% từ geometry. Screenshot ignored `.npm-cache/visual-audit/draft-production.png`.

**Cập nhật sau audit:** người dùng đã xác nhận draft và in-game đạt yêu cầu ban đầu. Hai scene là baseline được duyệt để tiếp tục kết nối dữ liệu. Các khác biệt bên dưới được ghi nhận, không phải yêu cầu mở lại vòng thiết kế.

Nguồn chuẩn là `ingame.png` và `overlay.png` do người dùng cung cấp, kích thước 1920×1080. Đã đo vùng chính trên DOM của renderer độc lập ở cùng độ phân giải; không dùng ảnh nền để đánh giá thành phần đã vẽ.

| Thành phần | X | Y | Rộng | Cao |
| --- | ---: | ---: | ---: | ---: |
| Scoreboard | 512 | 8 | 896 | 102 |
| Objective timer | 12 | 12 | 151 | 48 |
| Bảng 10 người chơi | 464 | 821 | 992 | 259 |
| Coach + ban trái | 0 | 667 | 360 | 112 |
| Coach + ban phải | 1560 | 667 | 360 | 112 |
| Dải draft | 0 | 790 | 1920 | 290 |
| Trung tâm draft | 800 | 790 | 320 | 290 |

## Đã chỉnh

- Scoreboard chia đội/economy/kills ở tâm, series pips, gold delta và mục tiêu.
- Bảng người chơi phản chiếu hai phía, ảnh tướng 47px, spell xếp dọc, items, rune, HP/resource, level/CS/KDA. Điểm tầm nhìn là field mock riêng.
- Draft có 5 cột trái 160px, giữa 320px; bên phải 120/120/120/320/120 khi R4 hover. Tên người chơi dựng dọc, ban và coach tách khỏi dải pick.
- Chữ hiển thị bằng font cài local, màu nền tối và xanh theo preset. Có chuyển ảnh gốc/bản dựng trong Studio, và renderer OBS trong suốt.
- Tên/ảnh game tra bằng ID Data Dragon; `MonkeyKing` hiển thị là Wukong. Kiểm tra fixture không có ID thiếu hoặc file asset trống.

## Các khác biệt còn lại

Chưa chứng minh mức giống 90% và chưa xem đây là bản tái tạo pixel-perfect. Beaufort for LoL và Spiegel đã thay font tạm; icon role/mục tiêu vẫn là SVG minh họa nên chưa trùng hình gốc. Tướng/skin và một số bans được suy luận từ ảnh; portrait dùng base loading art, crop và skin có thể khác. Trang bị hợp lệ trong catalog nhưng không khẳng định trùng toàn bộ inventory trong ảnh. Số liệu phụ như gold giữa bảng, objective counters và hover stats là fixture minh họa.

Logo KT/T1/Worlds và sponsor hiện là các vùng crop CSS từ ảnh người dùng; cần file logo trong suốt để hoàn thiện theme giải và bỏ phần nền đen đi kèm. Camera, minimap và game footage chỉ có trong nền tham chiếu của Studio; OBS không nhúng toàn bộ ảnh chụp.

## Tham khảo cấu trúc

- [RCV in-game module](https://github.com/rcv-prod-toolkit/module-league-in-game): `frontend/gfx/ingame.css`, cấu trúc scoreboard hai đội và bảng hàng người chơi.
- [RCV champion select module](https://github.com/rcv-prod-toolkit/module-league-champselect-ui): `src/europe/style/variables.less`, `picks.less`, `bans.less`, cách tách pick/ban và crop portrait.
- [Riot Data Dragon](https://developer.riotgames.com/docs/lol#data-dragon): metadata và image assets.

CSS renderer được viết riêng theo ảnh mẫu; không chạy runtime toolkit hoặc đưa font của toolkit vào dự án. Theme tiếp tục hỗ trợ đổi màu, font, tên đội, tỷ lệ/vị trí toàn bộ lớp và bật/tắt widget; chưa có editor từng phần tử.

## Audit bộ ảnh production mới — 26/09/2026

`images/ingame new.png` là baseline in-game mới nhất. So với overlay hiện tại, các nhóm còn thiếu được ưu tiên như sau:

1. **Scene theo ngữ cảnh:** layout tối giản khi giao tranh; bảng damage của giao tranh gần nhất; bảng xếp hạng tổng vàng; bảng rune toàn đội; Baron Power Play; inhibitor respawn; Dragon Soul và các transition sản xuất.
2. **Event vi mô:** hiệu ứng ngay trên portrait khi người chơi lên cấp hoặc hoàn thành món lớn. LB có level và inventory để phát hiện thay đổi, nhưng cần định nghĩa “món lớn” bằng catalog item hoàn chỉnh để không nháy khi mua linh kiện.
3. **Combat window:** ảnh `damage dealt.png` ghi rõ “Damage Dealt to Champions Last Teamfight”. Bảng có 5 hàng đối xứng mỗi đội và tách physical, magic, true damage. Phải đo trong cửa sổ giao tranh gần nhất, không dùng tổng damage cả trận. Trigger bắt đầu/kết thúc giao tranh và damage telemetry vẫn cần kiểm chứng từ LB.
4. **Combat minimal cooldown:** ảnh tối giản mới giữ portrait/HP/resource/ultimate và thêm timer cho item kích hoạt hoặc item bước ngoặt như Guardian Angel. Snapshot `2026-09-19T18-57-45-942Z` xác minh `totalCooldown/readyAt` của kỹ năng và một chu kỳ Luden's Echo 12 giây giảm còn 0,11 giây; chưa có mẫu Guardian Angel đã kích hoạt nên GA vẫn chưa được chốt semantics.
5. **Dragon Soul:** ảnh `Linh hồn rồng.png` dùng một takeover lớn ở cạnh trái kèm mô tả hiệu ứng soul dưới scoreboard. Event dữ liệu được phát khi đội chuyển từ 3 lên 4 rồng; scene takeover và nội dung mô tả từng loại soul chưa dựng.

Hàng biểu tượng dưới tên đội trong baseline mới là **Role Quest**, không còn được coi là Feat of Strength. LB đã xác minh item slot 8 cho năm role (`1200–1204` và các reward/variant); overlay hiển thị năm icon role và trạng thái hoàn thành. Không phục dựng Feat of Strength cũ.

Rồng/Baron được tạo từ thay đổi trạng thái LB: danh sách rồng tích lũy và chuyển trạng thái buff Baron từ false sang true. Frame đầu, reconnect và tua ngược chỉ đặt baseline, không phát lại lịch sử. Banner event tồn tại 7 giây và dùng tên đội trong Theme.

### Font

Đã nhận bộ font chính thức trong `data/font-source` và đưa sáu file OTF cần thiết vào `public/fonts/riot`. Studio và overlay dùng **Beaufort for LoL** cho headline/team/score, **Spiegel** cho nhãn, người chơi, số nhỏ và control. Anton/Roboto Condensed không còn được nạp ở runtime. Đã kiểm tra font, màu và hierarchy trên browser ở cả bố cục rộng lẫn hẹp; vẫn cần đối chiếu crop 1:1 khi chốt từng scene production.

## Đối chiếu snapshot với bộ ảnh — 26/09/2026

Đã phát lại `data/captures/2026-09-19T18-57-45-942Z` qua đúng adapter và renderer OBS. Bản ghi có 40 state frame trong 19,9 giây, game clock 29:41–30:01, đủ 10 người. Overlay hiển thị được champion, level, KDA, CS, inventory, spell, keystone, HP, 9/10 resource, vision, respawn, vàng cá nhân; team gold/kills/towers/dragons và timer hai hố đều đủ.

| Ảnh tham chiếu | Dữ liệu trong snapshot | Trạng thái giao diện |
| --- | --- | --- |
| `ingame new.png`, `ingame thông thường.png` | Đủ scoreboard và 10 người | Core đã dựng; nền game, camera, minimap và sponsor thuộc source phát sóng ngoài renderer |
| `ingame chênh lệch tiền 2 bên và các player.png` | Đủ team gold và gold 10/10 | Đã có chênh lệch đội và từng vị trí |
| `xếp hạng gold.png` | Đủ total gold 10/10 | Chưa có takeover xếp hạng |
| `Runes.png` | Raw có 9 perk cho mỗi người | Adapter hiện chỉ giữ keystone; chưa có scene rune toàn đội |
| `bộ tối giản khi giao tranh.png` | Đủ HP/resource và cooldown kỹ năng; có mẫu Luden's 12 giây | Chưa có trigger giao tranh và live minimal scene |
| `damage dealt.png` | Không có damage physical/magic/true trong payload | Chưa thể dựng đúng từ snapshot này |
| `baron powerplay.png` | Có `hasBaron` và team gold, nhưng 0/40 frame có Baron buff | Chưa có mốc nhận buff để kiểm chứng power-play delta |
| `hồi sinh nhà lính.png` | Raw có inhibitor Red L1 hồi ở 1989,68; còn khoảng 208 giây tại frame đầu | Chưa normalize/render |
| `Linh hồn rồng.png` | Baseline 3–0 rồng, không đổi trong 40 frame | Logic event rồng/soul có; chưa có takeover và chưa có fourth-dragon sample |
| `Cấm chọn.png` | Capture này chỉ có state in-game | Không dùng snapshot này để xác minh draft |

So với ảnh, hình học cố định vẫn giữ scoreboard `x=512, y=8, w=896` và bảng người chơi `x=464, y=821, w=992, h=259`. Các khác biệt visual đáng kể còn lại là logo/nhãn giải/series, hình icon objective chính xác theo asset giải và các takeover production. Tên hiển thị trong live overlay vẫn là tên tướng theo ranh giới privacy, không lấy player identity raw.

Trong lần đối chiếu này, renderer đã được sửa để luôn có đủ năm slot Role Quest mỗi đội, tô màu rồng theo loại từ snapshot và dùng Spiegel cho toàn bộ bảng người chơi/nhãn live thay cho Arial. Snapshot có một transition level 15→16 ở frame 23, đủ làm fixture tiếp theo cho hiệu ứng lên cấp; không có thay đổi inventory trong cửa sổ 20 giây nên chưa kiểm chứng animation hoàn thành món lớn.

## Cập nhật triển khai 11/10/2026

Giữ baseline draft/in-game đã duyệt. Live có cooldown sweep (số trong 10s
cuối, loại consumable/ward), R thật, level/item/quest cue, khung tím Baron/
trắng Elder theo buff player, Power Play/timer, Soul takeover riêng sáu loại,
timer inhibitor một đội mỗi lần và banner trụ đầu. Hai nhãn trạng thái Baron/
Soul thừa đã bỏ. Minimal đủ 10 thẻ, thủ công, chưa auto combat. Ngọc chính/
nhánh phụ nằm cạnh spell; reward quest chỉ thay ngọc phụ. Không đổi mock/draft.

Đã kiểm tra Edge headless thật 1920×1080/DPR1, không ảnh nền tham chiếu,
không fixture demo; recording thật và preview biến thể được phân biệt.
Icon/font đủ, OBS không control/nền tham chiếu và trong suốt. Artifact
`.npm-cache/visual-audit/`; chưa kết luận pixel-perfect/95–98% toàn UI.
Xem TEST_REPORT.md/PROJECT_STATUS.md. Các phần audit cũ phía trên là lịch sử,
không phải danh sách thiếu hiện tại.
