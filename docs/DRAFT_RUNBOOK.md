# Cấm chọn — 12/10/2026

## Animation, 17/10/2026

Cả hai layout có intro khung/đội, reveal ảnh hover, sweep nhẹ khi khóa tướng/
ban và chuyển nhãn lượt. Không đổi geometry hoặc vùng trong suốt cho cam.
Đổi hover/lock/swap có thể chạy lại hiệu ứng ảnh; timer tick không remount ảnh.
`prefers-reduced-motion: reduce` tắt animation/transition cấm chọn.

Module production tại `/?page=draft`; đầu ra OBS `/overlay?scene=draft`,
1920×1080 và nền trong suốt. `/?page=theme` cung cấp tên đội, logo tùy chọn,
tỉ số, số trận loạt đấu và tên giải cho cùng renderer. Đội không có logo dùng tên.
Preview iframe nhận cùng snapshot với OBS. `/overlay` không khóa scene sẽ đi theo
scene chương trình; URL có `scene=draft` luôn giữ cấm chọn.

## Vận hành

Chọn **Layout cấm chọn** tại trang này hoặc config trước trận:
**Cam tuyển thủ** giữ dải picks dưới như ảnh Riot; **Simple · cam caster** đưa
header lên trên, picks dọc hai bên và bans dưới, chừa giữa trong suốt. Lựa chọn
lưu cùng theme, không nằm trong JSON phiên draft; theme cũ thiếu field giữ bản cũ.
OBS dùng cùng URL, không cần tạo nguồn mới. Đặt cam caster ở source phía dưới
overlay, trong vùng giữa x400–1520/y183–873 (1120×690); renderer không nhúng camera.

1. Lưu branding trước trận ở trang config; mở Cấm chọn.
2. Nhập HLV (để trống sẽ ẩn thẻ COACH) và series ban; tên người chơi lấy từ LCU, rồi bấm
   **Lưu và đẩy lên view**. Chỉ nhập tên được phép công khai lên stream.
3. Mở LoL Client ở phòng cấm chọn. Lượt, tướng cấm/chọn, hover, timer và vị trí
   (theo ô người chơi) lấy từ LCU `/lol-champ-select/v1/session`, chỉ đọc; không còn nhập tay.
   Thông tin kết nối LCU nằm trong bộ nhớ server, không gửi ra frontend hay log.
4. Một luồng overlay: `/overlay` tự nhận diện scene. Không có dữ liệu thì trống hoàn toàn; khi LCU vào
   phòng cấm chọn, cấm chọn tự lên (hiện từ giữa ra, từng cụm: khối giữa, series ban, các pick từ ô
   gần giữa, ban và HLV, thanh timer); khi có dữ liệu trận mới (collector) thì tự chuyển sang
   in-game. Cấm chọn đã đủ 20 lượt vẫn giữ cho tới khi có dữ liệu trận. URL có `?scene=draft`,
   `?scene=ingame` hoặc `?scene=postgame` luôn ghim đúng màn đó. Các nút dưới đây ghim scene
   thủ công; **Tự động theo dữ liệu** trả về chế độ tự động.
   Bấm **Đưa cấm chọn lên chương trình** để tắt mock và chọn scene draft. Khi vào trận,
   bấm **Vào in-game (ẩn cấm chọn)** hoặc dùng URL `/overlay?scene=ingame`.
   `/overlay` không khóa scene đi theo chương trình; `scene=draft` luôn là cấm chọn.
5. **Đổi bên xanh ↔ đỏ** (cấu hình trước trận và trang này) cùng gọi lệnh `swapSides`: đổi tên,
   logo, tỉ số, HLV, thứ tự và series ban (tên người chơi theo phía bản đồ từ LCU).

Series ban: tướng bị cấm từ các ván trước vì đối thủ đã chọn, mỗi vị trí và mỗi bên tối đa
4 tướng (BO5). Tìm theo tên, có icon, chọn nhiều và bấm icon để xóa. Bảng chỉ hiện trên
layout Cam tuyển thủ và chỉ khi có ít nhất một tướng.

Thanh timer chạy từ hai đầu vào giữa và lấy màu đội đang thao tác. Ô đang ban/pick nhấp nháy nhẹ;
khi khóa, ô chớp viền theo màu đội. Khối giữa không hiện patch.


## Bộ mẫu và ranh giới dữ liệu

**Nạp ảnh mẫu · UI test** dựng tên/HLV, bans, sáu pick đã khóa và R4 hover từ
fixture tham chiếu. Studio ghi nhãn bộ mẫu; không coi đây là payload live.
Tướng/skin/bans fixture là diễn giải của ảnh, không xác nhận chính xác skin giải.
Không đưa sponsor/logo Riot crop hoặc phần trăm thắng/pick giả vào production.

Nguồn draft live là `lcu` (đọc LCU, đã dò được thông tin kết nối từ tiến trình LeagueClientUx);
`reference` là bộ mẫu UI. Chưa thu phiên cấm chọn thật để xác minh hover/lock/timer/swap/reconnect
của ánh xạ LCU: hiện kiểm bằng payload tổng hợp trong tests/draft-lcu.test.ts. Không lấy
snapshot in-game để suy ra quá trình cấm chọn.

Catalog riêng đủ 171 tướng của Data Dragon **15.20.1**; giữ catalog demo đã duyệt.
Icon và portrait base 2D đều local; tổng portrait khoảng 7,99 MB, chỉ ảnh được
hiển thị mới tải. Metadata/icon có version; endpoint loading art của Riot không
có version nên không khẳng định texture/skin trùng patch. Tái tạo bằng
`node scripts/assets/sync-draft-assets.mjs` từ CDN Riot. Patch nhãn do operator nhập,
không tự nâng asset baseline theo nhãn.

## Kiểm tra

- `npm run build`, `npm test`, `npm run test:integration`.
- `scripts/verify/draft-smoke.mjs`: backend/theme riêng khác 4310,
  `OVERLAY_VISUAL_URL` và `OVERLAY_BROWSER_PACKAGES` (Playwright).
  Tương tác 20 lượt, undo/skip/swap, timer, export/import, preview/OBS,
  1920×1080, asset/font, transparency và Studio 1280px.
- Geometry tham chiếu: bans xanh `(0,667,360,112)`, đỏ `(1560,667,360,112)`,
  dải pick `(0,790,1920,290)`, giữa `(800,790,320,290)`.
  Hover rộng 320px, bốn ô cùng phía thu về 120px; phía khác giữ 160px/ô.
  Không tuyên bố độ giống 95–98% từ các số đo vùng.

In-game dừng ở kiểm thử từng phần. Lượt test tiếp theo theo dõi xuyên suốt trận,
ghi feed/snapshot theo `LIVE_MATCH_RUNBOOK.md`; chưa thực hiện trận mới ở mốc này.

Simple tham khảo geometry từ [RCVolus layout-simple](https://github.com/RCVolus/lol-pick-ban-ui/tree/master/layouts/layout-simple),
đặc biệt `style.css`/`index.html` vì `overlay.png` là lớp nền. Header150px,
picks x0/1520,y183,w400,h690, bans x45/1155,y900,w720,h130. Giữ icon bans vuông
và nhận diện hiện tại thay màu/font/artwork repo; không sao chép runtime hoặc
đưa nền repo vào OBS. QA script đo hai layout và kiểm tra alpha vùng cam.

Simple dùng centered splash WebP ngang, bản cam tuyển thủ vẫn loading portrait.
Nguồn/provenance và cách phục hồi tại `DRAFT_VISUAL_SOURCES.md`.
