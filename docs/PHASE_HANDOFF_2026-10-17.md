# Tổng hợp phase UI và dữ liệu — 17/10/2026

## Đã hoàn thành bằng dữ liệu hiện có

| Nhóm yêu cầu | Kết quả |
| --- | --- |
| Tên người chơi | Nickname thật, bỏ #tag;10 ô override config; fallback tên tướng khi không có tên; đổi bên đổi cả roster override |
| Leaderboards |10 người; XP có% và ô level riêng; cảXP/gold có viền track nhạt/phần trống xám nhẹ; animation/sort giữ nguyên |
| Màu và rune | Màu phụ theo ảnh, màu chính cho tên đội; rune tạm thay player table ở cả2 layout, tắt khôi phục;9 perks nằm trong card; logo dưới tên nếu có |
| Banner/quest | Bỏ generic banner ghi đội hạ mục tiêu; giữ strip tên rồng/soul/trụ đầu; quest completion nền đen + slide như level/item, ẩn khi simple |
| Stack tướng | Field observed riêng; stack thay rune phụ ở full, ưu tiên hơn quest ở camera; simple26px góc dưới phải củaR40px, không tràn; chữ trắng/shadow nhẹ/không nền |
| Icon stack |11 icon PNG Riot theo kỹ năng operator chọn; Veigar dùng nội tại; không dùng ảnh AI |
| Giá trị thiếu | UI stack hiện0 theo yêu cầu nhưng sample vẫnnull/missing; tooltip phân biệt, không dùng placeholder để làm dữ liệu thật |
| Item counters | Điểm tích lũy trắng dưới giữa; quantity/stock dưới phải; hỗ trợ auxiliary8 và cùng item ở hai slot; không dùng count1 thành Tearstack1 |
| Layout camera | Tất cả hàng dùng cùng chiều rộng cột rune, Smolder/Veigar không bị đẩy lệch riêng |
| Phát lại | Projection8 bổ sung counters, giữ nguyên archive gốc và config; Studio/OBS nhận cùng sample |

11 icon: BardP, NasusQ, AurelionSolP, SmolderP, **VeigarP**, SennaP,
ChogathR, SionW, ThreshP, BelvethP, KindredP. Badge26px là quyết định mới nhất,
thay20px ban đầu. Không quay về VeigarQ hoặc màu nền chữ số cũ.

## Đã xác minh từ bản ghi thật

- Original `2026-10-16T12-43-43-938Z`;7331 native snapshots.
- Projection8 `2026-10-16T19-49-29-104Z`;1525 observer samples, khoảng0.5s.
- Yasuo: tên nguồn Seotoww, không phải tên tướng hay tag2013.
- Cuối capture: Smolder32, Veigar77; Tear củaVeigar330.
- Mắt vàng ammo0–2; support3866 charges1–3; potion count1/2, control ward
  auxiliary8 có count. Số liệu luôn theo thời điểm đang phát, không cố định
  các giá trị cuối trên. Không thêm fake events hoặc fake damage vào capture.

## Chưa thể tuyên bố hoàn tất dữ liệu thật

1. **Native stack9tướng khác:** UI/icon và nhánh LB stacksData đã nối, nhưng
   native mapping mới xác minh Smolder/Veigar. Cần capture có các tướng còn lại
   và HUD counter để xác định field/buff chính xác. Không dùng regex đoán buff.
2. **Giày Phàm Ăn3008:** đã xác định item và nối rule charges nếu nguồn trả;
   chưa có item này trong capture. Cần mua giày rồi tăng stack/đối chiếuHUD.
   Atlas3865 cũng cần đối chiếu counter trực tiếp vớiHUD trước khi khẳng định
   ý nghĩa tích trữ0/1 đã trùng hoàn toàn.
3. **Damage/postgame:**21296 payload damage khác nhau đều có damageDealt0,
   bao gồm2711 target hero. Không phải sát thương thật bằng0. Có thể liên quan
   Premium nhưng chưa chứng minh nguyên nhân, không vượt quyền tính năng.
   Thu0.5s không chữa được trường vốn không được trả.
4. **Nguồn damage khác:** ưu tiên kiểm chứng LCU
   `/lol-end-of-game/v1/eog-stats-block` sau custom kết thúc. Chưa có response
   thật đủ10 player. Nếu spectator thiếu, kiểm tra máy người tham gia được
   đồng ý; dự phòng nhập/OCR bảng kết quả với provenance manual/OCR. Production
   Standard không được mặc định là đã có RSO/Tournament/quyền custom.

## Kiểm chứng và trạng thái bàn giao

- `npm run build`:đạt; cảnh báo chunk/dependency không phải lỗi build.
- `npm test`:209 test,208 đạt,1skip fixture cũ.
- `tests/system.integration.ts`:đạt các scene/config/provider/recording,
  guards và đồng bộ. Một nhánh kiểm legacy capture riêng không có file nên
  skip; không thay thế bằng tuyên bố live đã đạt.
- `tests/transport.integration.ts`:đạt trên backend QA riêng4393, không reset
  app người dùng. Collector project integration đã đạt ở lượt triển khai.
- Browser QA1920×1080: nickname/XP/rune/quest/banner;4 stack layout variants,
  X mỗi cột lệch<1px, badge26×26 trongR40px sát phải, số trắng nềntransparent,
  ảnh/font tải được, không pageerror. Report/ảnh ở `.npm-cache/`.
- Theme local giữ nguyên hash
  `9C13D86AB1EE0C03CE7A6501A8666B6589FA223DA9F23A3D2A17FE1690A1D7E9`.
- Không commit/push; không chạy/inject game/REA hoặc đổi entitlement.

## Lượt test tiếp theo cần người dùng

Mở custom và ghi từ đầu. Khi trận kết thúc, giữ client ở màn kết quả, chưa
đóng hoặc vào trận mới, rồi báo để kiểm EOG. Trong trận có thể bổ sung các
tướng stack chưa xác minh và giày3008; chỉ cần game time + ảnh HUD counter
trước/sau thay đổi. Mục tiêu là xác minh nguồn, không dựng lại UI đã duyệt.

Chi tiết: `CHAMPION_ITEM_COUNTERS.md`, `NATIVE_STACKS_DAMAGE_FINDINGS.md`,
`RIOT_POSTGAME_API_FINDINGS.md`, `PROJECT_STATUS.md`, `TEST_REPORT.md`.
