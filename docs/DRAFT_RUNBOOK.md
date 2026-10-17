# Cấm chọn — 12/10/2026

## Animation, 17/10/2026

Cả hai layout có intro khung/đội, reveal ảnh hover, sweep nhẹ khi khóa tướng/
ban và chuyển nhãn lượt. Không đổi geometry hoặc vùng trong suốt cho cam.
Đổi hover/lock/swap có thể chạy lại hiệu ứng ảnh; timer tick không remount ảnh.
`prefers-reduced-motion: reduce` tắt animation/transition cấm chọn.

Module production nhập tay tại `/?page=draft`; đầu ra OBS `/overlay?scene=draft`,
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
2. Nhập HLV, 10 tên hiển thị và patch. Chỉ nhập tên được phép công khai lên stream.
3. Bấm **Đưa cấm chọn lên chương trình** để tắt mock và chọn scene draft.
4. Chọn tướng đang hover, bắt đầu timer nếu cần, bấm **Khóa & lượt tiếp**.
   Trình tự 20 lượt: 6 ban → 6 pick → 4 ban → 4 pick. Vòng ban thứ hai
   và vòng pick cuối bắt đầu ở đỏ. Timer hết chỉ về 0, chờ operator khóa.
5. **Bỏ lượt** để giữ ô trống, **Lùi một lượt** xóa lựa chọn cuối và trở lại lượt đó.
   Không tự gán tướng cho lượt trống. Một tướng không được ban/pick hai lần.
6. Cột **Lượt chọn** đổi tướng giữa các vị trí trong cùng đội (swap hai ô),
   giữ tên/role ở vị trí hiện hành. Có thể đổi sau khi hoàn tất draft.
7. Export phiên để lưu actions, hover, roster, coach, timer, patch và thứ tự vị trí;
   import có validation. Phiên draft nằm trong RAM backend, không tự lưu qua restart.
   Theme được lưu/export riêng như trước.
8. Đến bàn in-game, bấm nút phát widget/bảng đầy đủ để chuyển chương trình về in-game.
   Postgame vẫn hoãn.

## Bộ mẫu và ranh giới dữ liệu

**Nạp ảnh mẫu · UI test** dựng tên/HLV, bans, sáu pick đã khóa và R4 hover từ
fixture tham chiếu. Studio ghi nhãn bộ mẫu; không coi đây là payload live.
Tướng/skin/bans fixture là diễn giải của ảnh, không xác nhận chính xác skin giải.
Không đưa sponsor/logo Riot crop hoặc phần trăm thắng/pick giả vào production.

Nguồn draft hiện là `manual` hoặc `reference`. Chưa nối session LCU/LB draft,
chưa thu mẫu live để xác minh hover/lock/bans/timer/swap/reconnect. Không lấy
snapshot in-game để suy ra quá trình cấm chọn. Đây là mốc UI và luồng nhập tay;
kiểm chứng draft tự động cần phiên cấm chọn thật ở bước tiếp theo.

Catalog riêng đủ 171 tướng của Data Dragon **15.20.1**; giữ catalog demo đã duyệt.
Icon và portrait base 2D đều local; tổng portrait khoảng 7,99 MB, chỉ ảnh được
hiển thị mới tải. Metadata/icon có version; endpoint loading art của Riot không
có version nên không khẳng định texture/skin trùng patch. Tái tạo bằng
`node scripts/sync-draft-assets.mjs` từ CDN Riot. Patch nhãn do operator nhập,
không tự nâng asset baseline theo nhãn.

## Kiểm tra

- `npm run build`, `npm test`, `npm run test:integration`.
- `scripts/draft-smoke.mjs`: backend/theme riêng khác 4310,
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
