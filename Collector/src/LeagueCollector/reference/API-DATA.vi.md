# Endpoint và dữ liệu của LeagueCollector

Đối chiếu trực tiếp mã host, schema Farsight đã khôi phục và luồng tạo dữ liệu
overlay của LB ngày 2026-10-14. Phạm vi mong muốn: dữ liệu của tài khoản Free.
Free khác BasicTier. Tài liệu này không phải bản ghi của một trận thật.

Về xác thực: có nhánh C# dùng bộ quyền rỗng không chứng minh DLL sẽ duy trì
kết nối hoặc trả đủ dữ liệu Free. Free đã xác thực và client chưa xác thực
phải được kiểm tra riêng; xem `AUTH-STATUS.vi.md`.

## Endpoint của collector hiện tại

Địa chỉ mặc định `http://127.0.0.1:18799`, trên máy Windows chạy collector.

| Phương thức | Đường dẫn | Nội dung |
|---|---|---|
| GET | `/api/snapshot` | Envelope snapshot gần nhất từ nguồn đã chọn |
| WebSocket | `/ws` | Đẩy envelope `snapshot`, `lcu`, `status`; chỉ đọc |
| GET | `/api/lcu` | Envelope phase/client và nguyên session chọn tướng từ LCU |
| GET | `/api/status` | Nguồn, trạng thái, số snapshot/client, độ mới, auth, ghi dữ liệu |
| GET | `/api/health` | Tiến trình còn hoạt động và trạng thái collector |
| GET | `/api/schema` | Mô tả envelope/nguồn; không phải danh mục đầy đủ field |
| GET | `/` | Dashboard |
| GET | `/overlay.html` | Overlay mẫu |

WebSocket: `ws://127.0.0.1:18799/ws`. Mặc định yêu cầu snapshot native mỗi
100 ms; tần suất thực nhận tùy game/thư viện. `/api/snapshot` trả 204 nếu chưa
có snapshot, 503 với `{"error":"snapshot_stale"}` nếu dữ liệu quá cũ.
`/api/lcu` có thể trả 204 trước sự kiện đầu tiên. `health.alive=true` chỉ cho
biết host hoạt động; `collector.fresh` cho biết snapshot còn mới.

Các địa chỉ dưới đây là đầu vào của host, không phải endpoint mà overlay gọi:

- Native IPC của lblib: TCP loopback 4998, giao thức nhị phân.
- LCU: HTTPS loopback với port lấy từ lockfile;
  `/lol-gameflow/v1/gameflow-phase` và `/lol-champ-select/v1/session`.
- Chế độ `live`: `https://127.0.0.1:2999/liveclientdata/allgamedata`.
  Đây là nguồn thay thế cho `lblib`, không chạy đồng thời hai nguồn snapshot.

## Dữ liệu snapshot native

`snapshot.example.json` minh họa cấu trúc JSON, dùng giá trị hư cấu. Nó không
chứng minh tài khoản Free đã trả các giá trị đó. Mẫu chỉ có một hero và các
danh sách rỗng để dễ đọc; một trận thực có dữ liệu khác.

`native-fields.json` liệt kê các property có `[FlatBufferItem]` trong namespace
snapshot, enum và public field của value struct tìm thấy trong nguồn. Đây là
danh mục schema, không phải bảng xác nhận quyền Free cho từng field.

| Nhóm | Các field chính |
|---|---|
| Trận | `gameTime`, `playbackSpeed`, `utcTime`, `gameId` |
| Tướng/người chơi | `heroes[].info`: tên, networkId, index, vị trí x/y/z, team |
| Máu/cấp/trạng thái | `heroes[].common`: identifier, health, maxHealth, level, status |
| Chỉ số người chơi | gold, totalGold, goldGivenOnDeath, experience, resource, maxResource, resourceType, visionScore, respawnTime, kills, deaths, assists, laneMinionKills, neutralMinionKills |
| Kỹ năng | `spells`: name, icon, index, level, readyAt, maxCooldown, cooldown, ammo và toggle |
| Trang bị | `items`: id, count, stacks, charges, slot, stats, assets/hashes |
| Ngọc | `perks`: id, value, statModValue |
| Đối tượng | minions, turrets, barracksDampeners (nhà lính), hqs (nhà chính), misc |
| Đội | `teamStats[].towersLost`; tổng vàng/KDA đội chưa được host tính sẵn |
| Sự kiện | `gameEvents`: deathEvents, damageDealtEvents, notificationEvents, inhibitorKillEvents, firstBloodEvents, turretKillEvents, turretPlateDestroyEvents, xKillEvents, aceEvents, objectiveStealEvents, heroDieEvents |
| Các phần có giới hạn quyền | camera, missiles, rotation, bones, characterStats và một số trường common/event |

Host không tự loại bỏ trường native theo tier: nó xuất model mà DLL đã lọc.
Một field có trong schema không có nghĩa Free nhận được giá trị hữu ích.
DLL có thể trả null, NaN, số 0, chuỗi rỗng hoặc danh sách rỗng; host đổi
NaN/infinity thành JSON null và giữ các giá trị khác. Schema không gắn lý do
thiếu dữ liệu vào từng field. Enum xuất dưới dạng số. Với common.status:
IsAlive=1, IsZombie=2, IsRecalling=4, IsTargetable=8; có thể kết hợp bit.

Các property tính toán như `creepScore`, `q`, `r`, `isAlive` không được thêm
vào JSON. Overlay có thể tính CS từ laneMinionKills + neutralMinionKills,
tổng vàng đội bằng tổng totalGold của các hero cùng team. Không suy ra thứ tự
spells chỉ bằng vị trí trong mảng nếu chưa đối chiếu index/dữ liệu thật.

Giới hạn serializer hiện tại: value struct chỉ xuất public field; các inline
vector lưu bằng private field, ví dụ danh sách assister trong HeroDieEvent,
chưa được xuất. Struct triển khai IEnumerable, như Matrix4x4, xuất thành mảng.
Vì vậy ngay cả việc dùng cùng DLL cũng chưa đủ để khẳng định JSON giữ toàn bộ
nội dung native ở mọi kiểu dữ liệu.

## Đối chiếu với Free của LB gốc

Trong `IngameState.cs`, các nhánh tạo Scoreboard, Tabs, ScoreboardBottom,
Inhibitors, BaronPitTimer và DragonPitTimer không đặt yêu cầu tier tối thiểu.
Chúng còn phụ thuộc cấu hình overlay và trạng thái trận. Vì vậy đây là các
nhóm cần đối chiếu khi xác nhận đầy đủ đầu ra Free:

- Scoreboard: thời gian, tổng vàng/KDA đội, trụ/giáp trụ, grubs, rồng,
  trạng thái power play; tên/logo/điểm series đến từ cơ sở dữ liệu/cấu hình LB.
- Tabs: danh tính người chơi/tướng, kỹ năng, ngọc, HP/resource, level/XP,
  hồi sinh và các trạng thái hỗ trợ mà dữ liệu nguồn cung cấp.
- ScoreboardBottom: KDA, vàng, CS, vision score, shutdown, hồi sinh, trang bị.
- Timer Baron/rồng và trạng thái/timer nhà lính: có lớp theo dõi chuyển trạng
  thái của LB, không đơn thuần là một field đã có sẵn trong snapshot.

Chưa thể suy ra mọi giá trị của các nhóm trên đều đầy đủ chỉ từ việc nhánh
frontend không yêu cầu tier. Cần đối chiếu dữ liệu native và game thực tế.

Những giới hạn đã thấy trong DLL gốc:

| Phần | Kiểm tra đã theo dõi |
|---|---|
| Đăng ký LB snapshot | Không yêu cầu Develop tại gate đăng ký |
| Camera | Yêu cầu Enterprise |
| Missile | Yêu cầu Pro |
| ObjectInfo.rotation | Thiếu Enterprise dùng NaN, host xuất null |
| AIClient.dataStack | Có kiểm tra Basic |
| Một số thống kê/animation/bone/characterStats | Có kiểm tra Enterprise |
| Sự kiện | Có lọc theo Basic/Pro/Enterprise; chưa ánh xạ đầy đủ từng list/field |

Trong managed LB, nhiều biểu đồ damage/gold, side-info, rune panel nâng cao,
damage recap và các phân tích bổ sung yêu cầu Basic; ChampionDetail yêu cầu
Pro. Chúng không phải tiêu chí cần đạt cho phạm vi Free mà người dùng yêu cầu.
Panel rune nâng cao khác với việc có `heroes[].perks` trong snapshot.

Collector hiện chưa chuyển snapshot thành hợp đồng overlay LB gốc, chưa xuất
các endpoint riêng `/api/scoreboard`, `/api/players`, `/api/objectives`, và chưa
tái dựng lớp state/asset/config phục vụ tất cả đầu ra Free trên. LCU hiện xuất
nguyên session, không dựng lại toàn bộ mô hình champion-select của LB.

## LCU và nguồn Live API

`lcu.example.json` là mẫu hư cấu, rút gọn session. Host thực giữ nguyên payload
session trả về, gồm myTeam/enemyTeam, actions, bans, timer và các trường khác
nếu LCU cung cấp. Session chỉ được đọc khi phase là ChampSelect; khi rời chọn
tướng champSelect=null; khi mất kết nối state=waiting, phase=null.

Chế độ Live API giữ nguyên toàn bộ JSON upstream ở
`data.rawLiveClientData`: activePlayer, allPlayers, events, gameData và các
trường khác API trả. Shape `heroes` trong chế độ này khác native. Nguồn này
không cung cấp mọi dữ liệu nội bộ/vị trí/camera của lblib và chưa được chứng
minh tương đương toàn bộ Free của LB.

## Mức xác nhận

HTTP/WebSocket, FlatBuffer→JSON, record/replay, Live API và LCU giả lập đã qua
kiểm thử. Chưa thu trận LoL thật trên Windows và chưa có bản ghi LB Free cùng
trận để so sánh. Lần auth trước đăng nhập thành công nhưng API subscription
trả 404; kết quả này không đủ để xác nhận quyền hoặc kết luận Free không chạy.

Các mẫu JSON được kiểm tra cú pháp và đối chiếu tên field với nguồn. Chúng
không phải kết quả kiểm thử dữ liệu Free thực tế.

Nguồn đối chiếu:

- `src/LeagueCollector/Program.cs`, `Sources.cs`, `LcuWorker.cs`, `SchemaJson.cs`.
- `vendor/Farsight/BlueBottleIPC.LeagueBroadcast.Snapshot/*.cs`.
- `vendor/Farsight/Farsight.Auth/TierFeatureBridge.cs`.
- `../../recovery/decompiled/BlueBottleClient.GameLib/BlueBottleClient.GameLib.Ingame.State/IngameState.cs`,
  phần tạo frontend và GenerateScoreboard/GenerateTeamTabs/GenerateBottomScoreboard.
- `../../native/ANALYSIS.vi.md`, pseudocode camera/missile/object/common/hero/events.
