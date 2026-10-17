# Đo UI theo ảnh — 11/10/2026

## Kết quả và giới hạn

Đã đo trực tiếp renderer OBS bằng Edge headless **1920×1080, DPR 1**, bấm nút trong phòng thử để chọn snapshot thật. Không dùng ảnh tham chiếu làm nền renderer. Công cụ dùng Playwright/sharp đã có trong runtime; không cần cài browser mới hoặc dùng profile cá nhân. Theme local giữ nguyên.

**Chưa đạt/chưa chứng minh 95–98% độ giống toàn overlay.** Khớp rectangle không đồng nghĩa khớp icon/font/artwork. F1 dưới đây chỉ dành cho một nhãn chữ tĩnh, không phải điểm tổng thể.

| Vùng | X / Y / rộng / cao ở 1920×1080 | Kết quả DOM |
|---|---|---|
| Scoreboard + hàng Role Quest | 512 / 10 / 896 / 98 | Khớp |
| Bảng 10 player | 464 / 821 / 992 / 259 | Khớp |
| Total Gold | 0 / 145 / 286 / 600 | Khớp |
| Minimal | 464 / 909 / 992 / 171 | Khớp |
| Baron Power Play | 1414 / 12 / 170 / 60 | Khớp |
| Team Runes | 287 / 793 / 1346 / 287 | Khớp |
| Soul takeover | 0 / 145 / 286 / 600 | Khớp |
| Soul description strip | 715 / 113 / 503 / 35 | Khớp |

Biên tham chiếu được kiểm tra thủ công từ ảnh 1920×1080, sai số dự kiến ±2 px do video nén. Manifest `scripts/verify/visual-regions.json` phân vùng cả 11 ảnh. Minimap, bảng champion đang chọn/ability phía trái, HP/nameplate trong map và thông báo game không thuộc UI renderer. Camera và sponsor là input broadcast riêng; Soul artwork/takeover vẫn là đồ họa cần dựng, không được loại khỏi phạm vi chỉ để tăng điểm.

Font Beaufort vẫn được giữ cho Studio/theme đã có. Nhánh live dùng **Anton** (alias Broadcast Condensed, kèm OFL); đây là font thay thế được đo, **chưa xác nhận font gốc Riot**. Thử 15 tổ hợp size/padding nhãn TOTAL GOLD, chọn 27px/padding-top 9px. Mask chữ sáng, crop cố định x12 y154 rộng145 cao40, dung sai lân cận 1px: precision 99,467%, recall 99,574%, F1 **99,521%**. Không căn tự động mỗi ảnh để giấu sai lệch vị trí. Không suy ra điểm cho scoreboard, số liệu hoặc tất cả font từ nhãn này.

## Đã chỉnh

- Scoreboard chính 60px thay vì 78px; hàng phụ 38px; Role Quest cùng hàng timer, không thêm Feat of Strength.
- Objective timer nằm ngang 103×48 mỗi ô, không xếp dọc 151px như trước.
- Gold có 10 portrait 44px, thanh tỷ lệ vàng quan sát thật, nhãn K và màu từng đội.
- Minimal có 10 card hẹp, portrait, HP/resource, phép, item đặc biệt/GA và **icon chiêu cuối R**, không lấy keystone thay R.
- Team Runes chuyển thành lower-third 10 card, 2 đội; che bảng player trong cảnh rune. ID chưa map vẫn fallback rõ ràng.
- Power Play phía phải scoreboard: gold lớn trên/timer dưới; fallback +1500
  rồi biến động chênh vàng ròng, timer mặc định 180s hoặc loss cả đội.
  Elder chỉ timer 150s, có thể cùng hiện. Không tự cấp buff cho người chết.
- Gold gap ở bảng player dùng chữ trung tính và cạnh màu đội dẫn.
- Đã tách mask SVG từ icon Baron, bốn rồng nguyên tố air/fire/water/earth, trụ, vàng và 5 Role Quest trong ảnh. Không có nền game/số liệu trong glyph. `public/broadcast/glyphs/provenance.json` ghi crop/threshold; glyph từ ảnh nén còn cần đo nét/antialias, không gọi là asset gốc Riot.
- Giữ mock/draft baseline, không ghi theme cá nhân. Logo KT/T1 vẫn dùng crop nhận diện cũ; không ghép HUD trận từ ảnh vào renderer.

## Asset live

CDN Riot xác nhận mới nhất `16.20.1`: https://ddragon.leagueoflegends.com/api/versions.json . Bộ live: 173 tướng, 870 item, 34 spell, 72 rune/tree/shard và 173 icon R, tổng **1.322 PNG** có SHA-256 manifest. Metadata chiêu cuối lấy từ champion JSON cùng patch. Demo giữ 15.20.1. `assetPatchMatch` vẫn chưa chuyển thành verified chỉ vì số patch gần nhau.

## Cần tiếp tục trước khi chốt 95–98%

1. Hiệu chỉnh/định lượng mask icon đã tách; bổ sung hextech/chemtech/elder chưa có mẫu rõ, không so toàn frame có map.
2. Soul takeover sponsor-free đã dùng sáu WebP riêng, không AI/hue; nguồn Riot
   LoR/key art, Infernal là raster render sẵn từ Dignitas, không tranh painted.
   Provenance/hash tại `public/broadcast/artwork/PROVENANCE.md`. Copy sáu loại
   có nguồn và công thức, không phải heal/damage live. Artwork này không phải
   pack broadcast Worlds gốc, không được tính khớp pixel với artwork tham chiếu.
3. Logo giải/đội, nhãn giải/rank và tên player production cần cấu hình riêng. Không tự đổi branding KT/T1 của theme người dùng thành BLG/HLE để giả khớp ảnh mới.
4. Hiệu chỉnh alpha, border, thanh HP/resource và từng cột bảng player bằng crop nội bộ; chưa có điểm pixel tổng hợp hợp lệ cho chúng.
5. Damage scene chỉ được định vị trong manifest; telemetry vẫn unavailable, không tạo damage giả.

## Chạy lại công cụ

Build/backend local trước. Browser QA bấm các nút thật và thay rehearsal tạm ở Studio/OBS nên **chỉ chạy trong phiên test**, không khi phát sóng. Không ghi theme; cuối script trở về clear, không đảm bảo khôi phục vị trí playback trước đó.

```powershell
$env:OVERLAY_BROWSER_PACKAGES='C:/Users/Seotow/.cache/codex-runtimes/codex-primary-runtime/dependencies/node/node_modules'
node scripts/verify/visual-capture.mjs
node scripts/verify/visual-score.mjs
node scripts/verify/visual-font-calibrate.mjs
```

Máy khác đặt biến thành thư mục package Playwright/sharp thực tế, không mặc định có runtime Codex. Script capture dùng Edge đã cài, URL mặc định 4310; hỗ trợ `OVERLAY_VISUAL_URL` cho backend loopback cô lập. Font calibration hiện dành port4310.

Artifact local ở `.npm-cache/visual-audit/`: `regions-<tên ảnh>.png`, `gold.png`, `minimal.png`, `baron.png`, `runes.png`, `timers.png`, `inhibitor.png`, `soul.png`, `measurements.json`, `scores.json`, `font-calibration.json`. Các PNG OBS trong suốt, màu đen khi viewer compositing không phải nền game.

Kiểm chứng sau cập nhật Soul copy: 94/94 unit/regression không skip, build
đạt, browser QA sáu Soul/biến thể đạt. Panel/strip đúng rectangle, player
tối giản 464/909/992/171 trong 7s rồi trở về 464/821/992/259. Strip ghi hai dòng
hiệu ứng định lượng theo loại, không tên đội; sáu mô tả không bị cắt chữ.
Không ghi theme; không dùng test logic để chứng minh độ giống ảnh.
