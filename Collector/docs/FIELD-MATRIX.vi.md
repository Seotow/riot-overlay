# Field matrix — LeagueCollector adapter v1

Nguồn: native schema được `SchemaJson` xuất qua `CollectorHub` envelope v1.
Runtime evidence gồm map12 ngày14/10 và SRlive ngày15/10/2026. Xem
[SR-LIVE-VALIDATION](SR-LIVE-VALIDATION.vi.md) cho sample counts và giới hạn;
không coi một cửa sổ đối chiếu là fullparity.
Bảng máy đọc được: `Collector/adapter/fields.ts`. Không cần credentials để
import hoặc kiểm thử adapter; nó chỉ đọc feed collector đã chạy.

| Field của project | Native path | Bằng chứng hiện có / xử lý |
| --- | --- | --- |
| gameTime | data.gameTime | Clock thật tăng trong runtime; timestamp field lấy từ envelope |
| team | heroes[].info.team | SRmatch roster10 với Riot,1/2 mỗi5; bắt buộc đủ5+5 |
| slot | heroes[].heroIndex | Key schema; unique10, sort theo team/index. **Chưa là thứ tự đường** |
| championId | common.identifier | SRmatch10; unknownnull, transform/skin chưa xác minh |
| level | common.level | SR220/220 lượt khớp; integer1..30 |
| K/D/A | kills/deaths/assists | Mỗi fieldSR220/220 lượt khớp; không tự chứng minh entitlement/fullparity |
| CS | laneMinionKills + neutralMinionKills candidate | Lệch Riot trong SR (0–2/10 khớp); projection tắt→null, chưa rõ nguyên nhân |
| currentGold / totalGold | gold / totalGold | Hai giá trị khác nhau; runtimepresence, totalGolddương/thayđổi; không suy current từ total |
| health | common.health/maxHealth | Runtimepresence/positive/change; current0hợp lệ, max>0, không suy isDead từHP |
| resource | resource/maxResource | Runtimepresence/change; max0→missing, không tạo thanhresource giả |
| inventory/items | items[].slot/id/count | SR220/220 matcheditems sau táchaux7/8; unique0..6, unknownslots→null; chưa map quest/boots |
| spells D/F | spells[].index/name | Metadata D4/F5; exactcatalogcode, không đọc iconURL/nameplayer |
| cooldown R/D/F và item | index/readyAt/maxCooldown/ammoReadyAt/ammoCooldown/ammoCount | R3/D4/F5; item slot0..6 nối spell6..12 theo Farsight source. Empty ammo chọn recharge theo GetMaxCooldown. Source-derived/fixture-tested; chưa runtime semantic proof, không suy GA activation |
| wardScore | visionScore | Schema-only, numeric≥0 |
| perks / keystone | perks[].id | Catalog cùng version: một keystone duy nhất; panel9 chỉ khi primary4/secondary2/shards3 hợp lệ. Không đoán order/không copy Value; source-derived/fixture-tested, chưa game verified |
| experience | experience scalar | Không có previous/nextlevelboundary, không tạo objectXP giả |
| isDead / respawn | status/respawnTime | Chưa xác minh bit/timer semantics; null |
| Baron/Elder/quest | buffs/items/spells | Chưa kiểm chứng mapping; null |
| teamgold/kills | Tổng5player đãnormalize | Chỉ cộng khi cả5field hợp lệ; thiếu→null. Đây là derivedsum, không fieldteam trực tiếp |
| recent events | heroDieEvents/turretKillEvents/inhibitorKillEvents/aceEvents | Map record rõ kiểu bằng exact object/networkId join, IDs opaque, recent5s; fixture-tested, chưa game-verified, history coveragefalse |
| teamobjectives/timers/other events | teamStats/gameEvents/turrets/barracksDampeners | Counter/timer còn thiếu; TowersLost không phải counter trụ hạ. Không suy counts từ cửa sổ event ngắn |
| map/replay.pause/time | Không có trong snapshotnative hiện hành | null; playbackSpeed không chứng minh pause |
| damage/winner/endGame | Chưa có bằng chứng phù hợp | Không emit |

`availability=observed` nghĩa là provider **đã báo giá trị hợp lệ về kiểu/range**;
không phải chứng minh field đúng toàn diện hoặc fullFree. FlatBuffer có default0,
không đủ marker entitlement. Các field schema-only được cho phép projection để
kiểm thử tiếp, không được nâng thành runtime-verified. Capability report tách
coverage hiện hành khỏi `productionReady=false` và `roleOrderVerified=false`.

Adapter không copy info.name/networkId/gameId, token, rawGameEvents/assets/camera
hoặc URLprovider. gameId/roster chỉ dùng hash nội bộ xác định session. Catalog
live được tái dùng, patchmatch luônunverified; DataDragon demo15.20.1 không đổi.
