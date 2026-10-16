# Bộ đếm tướng và item — 17/10/2026

## Dữ liệu thật, không tính từ chỉ số khác

`ObservedPlayer.championStacks` là optional observed field. Native hiện chỉ
map chính xác SmolderQPassive.count và VeigarPhenomenalEvilPower.count, đã
kiểm7331 frames và thấy tăng0→32/77. Không dùng SmolderP/VeigarPassive.count,
ability charges, AP hoặc CS. LB đọc trực tiếp `tabPlayer.stacksData` cho11
tướng đã chọn; unit fixtures xác nhận luồng, không chứng minh telemetry native
của9 tướng khác. Native khác thiếu thì null; loss/seek theo session hiện có.

User yêu cầu UI hiện0 thay em dash khi thiếu:0 lúc thiếu **chỉ là placeholder**,
không ghi0 vào sample, tooltip ghi thiếu, không có `data-stack-value`.

Icons không được bộ đếm raw hiện tại cung cấp. Dùng11 PNG Riot Data Dragon
16.20.1 theo quy tắc operator, Veigar đã đổi từQ sang nội tại theo yêu cầu sau:
BardP, NasusQ, AurelionSolP, SmolderP, VeigarP, SennaP, ChogathR, SionW,
ThreshP, BelvethP, KindredP. Manifest/hash tại
`public/broadcast/champion-stacks/manifest.json`; không nâng baseline demo15.20.

## Vị trí UI

- Full không cam: stack thay rune nhánh phụ; quest slot riêng không đổi.
- Full có cam: stack ưu tiên hơn quest reward tại ô rune nhánh phụ.
- Tướng không thuộc11 tướng giữ logic rune/quest cũ.
- Cả10 hàng dùng vùng rune rộng30px, không chỉ stack champion, tránh lệch
  riêng Smolder/Veigar ở layout camera.
- Simple: badge tròn26px (tăng30% từ20px theo yêu cầu sau), góc phải dưới
  sát mép phải ultimate40px và nằm trọn
  bounding box ultimate. Cho parent overflow để không cắt góc badge; sweep và
  countdown vẫn có border-radius50%. Số trắng, không background riêng,
  shadow nhỏ; số simple khoảng13px. Không rút gọn/ký hiệu K số stack.

## Item: điểm tích lũy khác số lượng/tích trữ

Contract riêng `itemCounters` giữ `{slot,id,stack,quantity}`, bao gồm auxiliary8.
Không sửa inventory count, không đưa raw stats/assets sang renderer.
Riot Live Client cũng chuyển count của potion/control ward nếu được trả;
không suy Tear stacks/ward ammo từ count1. LB và native qua cùng quy tắc item.

| Trường hợp | Nguồn | Kiểm chứng bản ghi |
| --- | --- | --- |
| Nước Mắt3070 | items.charges → stack, không phải count/stacks/ammo | thay đổi, cuối330 |
| Bình máu2003, mắt kiểm soát2055 | items.count → quantity | potion1/2, ward1 |
| Mắt3340, máy quét3364 | spell index6+slot, ammoCount → quantity |0–2 |
| Support3866 và đồ ward nâng cấp | items.charges → quantity |3866 có1/3 |
| Atlas3865 | items.stacks, không phải số item trong túi | thấy0/1, chưa đối chiếu HUD |
| Control ward ở auxiliary8 | items.count | có slot8 id2055,1 |
| Giày Phàm Ăn3008 /223008 | items.charges → stack nếu có | metadata vi_VN xác định đúng tên, chưa có live sample |

Nhánh tích điểm cùng họ Tear3003/3004/3119/323070 và stock refill2031/2033
có rule, nhưng chưa khẳng định đã test runtime từ bản ghi này. Không suy
stack giày từ kills/assists; không dùng count1 làm stack1. Thiếu field không
in số item giả. Số điểm trắng căn dưới giữa, quantity dưới phải, không nền
chữ; auxiliary8 được ưu tiên nếu cùng2055 tồn tại cả ô đồ và ô lane reward.

## Bản ghi/QA

Projection8 `2026-10-16T19-49-29-104Z`:1525 samples từ7331 native frames,
giữ original `2026-10-16T12-43-43-938Z` nguyên vẹn. Projection7 trước đó chỉ
thêm championStacks, không có đầy đủ itemCounters. Không xóa các phiên trước.

Audit `scripts/audit-native-item-counters.mjs`; JSON aggregate tại
`.npm-cache/data-audit/native-item-counters.json`. Metadata giày được đối
chiếu URL Riot `/cdn/16.20.1/data/vi_VN/item.json`.

Browser QA: `scripts/verify-stack-ui.mjs`,1920×1080,4 camera/layout variants;
Smolder32, Veigar77, Tear330; cột champion/rune/HP cùng X mỗi đội (<1px),
badge26px trong ultimate40px, sát mép phải, số trắng nền transparent và assets tải được.
Ảnh/report `.npm-cache/stack-ui-qa/`. Không có gameplay mới hoặc xác minh
stack của9 tướng còn lại/giày bằng HUD trong lượt này.
