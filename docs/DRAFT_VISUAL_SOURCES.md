# Ban/pick simple — nguồn và chỉnh hình 12/10/2026

Tham khảo trực tiếp nguồn tác giả:

- [RCVolus layout-simple](https://github.com/RCVolus/lol-pick-ban-ui/tree/master/layouts/layout-simple):
  geometry header/picks/bans; `script.js` dùng `splashCenteredImg` cho ô ngang.
- [RCV champion-select module](https://github.com/rcv-prod-toolkit/module-league-champselect-ui):
  tham khảo phân tách graphics khỏi nguồn dữ liệu; không nhập runtime/code module.
- [Riot Data Dragon](https://developer.riotgames.com/docs/lol#data-dragon):
  phân biệt splash art/loading/icon; catalog demo vẫn khóa15.20.1.
- [CommunityDragon15.20 champion metadata mẫu Wukong](https://raw.communitydragon.org/15.20/plugins/rcp-be-lol-game-data/global/default/v1/champions/62.json):
  `skins[].splashPath` cung cấp centered splash của Riot, khác `uncenteredSplashPath`.

## Chỉnh renderer

Simple dùng centered splash ngang thay loading portrait dọc để giảm cắt mặt tướng.
Giữ loading portrait ở layout cam tuyển thủ. Có171 WebP local, tổng3.678.370 byte,
resize tối đa800×480/quality82; không AI, WebGL hoặc xử lý ảnh trong frontend.
Nguồn/version/input/output SHA256 từng ảnh tại
`public/ddragon/15.20.1/splash-centered/provenance.json`.

`scripts/assets/sync-draft-centered-art.mjs` đọc metadata15.20 và tải centered base skin,
tạo WebP offline bằng sharp; `OVERLAY_BROWSER_PACKAGES` trỏ thư mục chứa sharp.
Raw nguồn/metadata chỉ cache ignored. `sync-draft-assets.mjs` giữ field splash
để tái tạo icons/portrait không làm mất liên kết ảnh ngang.

Tên player và icon lane có baseline chung ở footer30px; badge lượt có nền tối,
tên tướng ở mép đối diện. Header giữ tên đội lớn, timer nổi bật, tách nhãn giải,
phase và patch. Bans có khoảng cách, hạ saturation để phân biệt pick; active ban
giữ viền accent. Giữ palette/font/theme của project, footprint/cam giữa và dữ liệu.
Không thêm stats, source giả hoặc logo/sponsor mẫu.

Crop chung dùng centered art42% theo trục dọc; chưa audit từng tướng/skin riêng.
QA ảnh mẫu và asset171 tướng không chứng minh pixel-perfect mọi artwork.
