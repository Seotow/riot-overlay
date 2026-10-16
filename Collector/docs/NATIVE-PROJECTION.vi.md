# Mapping native bổ sung — 15/10/2026

Đã bổ sung projection ngọc và cooldown trang bị vào adapter đang cấp Studio/OBS.
Đây là mapping dựa trên source khôi phục và catalog local, không phải xác minh
trên game. REA MCP/CLI không hiện diện trong phiên này; không có Evidence ID
REA mới và không thực hiện native decompilation, auth, inject hoặc đọc game.

## Nguồn và giới hạn

Source đã restore dưới `Collector/src/LeagueCollector/vendor/Farsight/`:

- `BlueBottleIPC.LeagueBroadcast.Snapshot/Perk.cs`: FlatBuffer struct có Id,
  Value và StatModValue. `SchemaJson.cs` xuất trường schema; adapter chỉ lấy Id.
- `SpellSlotIndex.cs`: R3, D4, F5, Item1..Item6 là 6..11, trinket12,
  Recall13 và Quest14. `SpellBookUtils.GetItemSpellByItemIndex` dùng 6+itemIndex.
- `Spell.GetMaxCooldown`: empty ammo và AmmoReadyAt>0 dùng AmmoCooldown.
  Adapter chọn cặp ammoReadyAt/ammoCooldown khi điều kiện đó đủ; không có timer
  không được coi là ready=0. ReadyAt semantics vẫn cần đối chiếu trong game.
- `AIHeroClient.CreepScore` cộng lane+neutral, đúng candidate cũ. Static source
  không giải thích được SR mismatch nên CS vẫn null, không bật lại chỉ vì đọc
  được getter. Status IsAlive/IsZombie tồn tại nhưng chưa map chết/hồi sinh;
  chưa xác minh RespawnTime là mốc game time hay remaining duration.

SHA-256 đã đọc ở workspace:

| Tệp | SHA-256 |
| --- | --- |
| lib/Farsight.dll | b8418791d059bc97838adfc3ad5bc86b0b23e3d000ef9e1d36976544f35d4585 |
| Perk.cs | ff5f55fbdf7504c2ac52fba9cd20d4df70f09f3e61c843e08ceea358544d3f46 |
| Spell.cs | c4727b73ca707ed52c455a2c3b9c3d1415a32ae4c3674af3a1383bd07d4b19b7 |
| SpellBookUtils.cs | 94de1700c0418ea196f69de41b8611c79ee7ae3684d9fc606067803dae24f975 |
| SpellSlotIndex.cs | 3b70a7bc8a2c17d677265e84374f075e7ec4d30d0c744dbf0a66bae289de58e7 |
| shared/generated/rune-paths.json ở root | 81cc5c634b6178bfb293abb3ef3d6902c412dacce1a70911a26bc2f8b0124024 |

Hash ràng buộc những file đã đọc, không tự chứng minh bản dịch ngược hoàn chỉnh
hoặc bytes/runtime native tương thích. DLL native vẫn giữ nguyên hash ghim.

## Quy tắc mới

Ngọc: chỉ ID có trong catalog cùng version với rune-paths. Raw perk list thiếu,
rỗng, quá32, sai kiểu/unknown/path-ID hoặc keystone mơ hồ không thành panel giả.
Một keystone duy nhất có thể hiển thị riêng. Panel đủ9 cần bốn perk cùng primary
tree, hai perk secondary cùng tree khác primary, sáu perk đó khác nhau, ba shard
đã biết; shard trùng được giữ. Vector sai order không được tự sort hoặc sửa.
Chưa kiểm từng slot rune tree trong game hoặc claim full entitlement.

Cooldown item: chỉ inventory đã validate, item ID có catalog, slots0..6;
aux7/8 không thành timer quest/recall. Spell index tương ứng phải có mặt và
duy nhất; thiếu timer/null/âm/total0 bị bỏ, không suy activation. Tối đa3 spell
và7 item phù hợp contract hiện có. Numeric validity không là semantic proof.

## Kiểm chứng

139/139 unit test và build đạt; adapter targeted9/9 sau sửa join đạt.
`npm run test:collector` xác nhận fixture perk9/keystone và item cooldown đi
qua backend thành ObserverFrame chung Studio/OBS; sentinel raw perk stats không
đi vào recording. Không đổi renderer/theme/demo asset. Sandbox loopback timeout
được phân biệt và rerun ngoài sandbox đạt, không quy lỗi cho collector/game.

Runtime lần tiếp cần đo perk vector/order/key với scoreboard và ngọc thật,
item cooldown cả có ammo/không ammo, spell ready/cast/recharge và timestamps
cùng cửa sổ. Không coi code/fixture này là dữ liệu thật. CS/lane/objective/buff/
respawn và ổn định full session còn là phần chưa hoàn tất của mục tiêu tích hợp.
