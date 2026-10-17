# Event từ collector — mapping và delivery 15/10/2026

Adapter đã nối bốn record native có schema rõ ràng vào event contract chung:

| Native record | Event của project | Join bắt buộc |
| --- | --- | --- |
| HeroDieEvent | ChampionKill | killer và victim đều là hero, khác đội |
| TurretKillEvent | TurretKilled | killer là hero; victim có trong turrets, khác đội |
| InhibitorKillEvent | InhibKilled | killer là hero; inhibitor có trong barracksDampeners, khác đội |
| AceEvent | Ace | killer và victim là hero, khác đội |

`GameTime`, `KillerNetworkId`, `VictimNetworkId`/`InhibitorNetworkId` là public
fields của FlatBuffer value structs đã restore. `SchemaJson` xuất các fields
này. ObjectInfo cung cấp team và networkId; lookup nội bộ mới đưa ra team và
playerSlot của killer, không đoán bằng tên hoặc thứ tự vector. Hero slots giữ
team/heroIndex, chưa là lane. Environment/minion kill hoặc target bị xóa/không
có trong snapshot chưa được map; vector thiếu/mơ hồ giữ output trống.

Đây là source-derived/fixture-tested, **chưa kiểm chứng event thật trong game**.
Không có native execution, auth request hoặc REA Evidence ID mới trong lượt
này. Source/hash đọc ở workspace dưới `collector/hosts/lb-host/vendor/
Farsight/BlueBottleIPC.LeagueBroadcast.Snapshot`:

| Tệp | SHA-256 |
| --- | --- |
| HeroDieEvent.cs | a430a27aa83f45aa37e3de6709bee2601c63426469cd5985653948b47dc65c6e |
| TurretKillEvent.cs | a7155df0403195374cd68d610819963c231768a65a8d2171a0defb2f6b372cbb |
| InhibitorKillEvent.cs | c495693e85607a7829f8f71425be12e5a41dc5cfb4092f6410e27d2f98e2320a |
| AceEvent.cs | 325063eceee793eb8a8544d256869bb333afded1cbe788f50a159270e37dbd20 |

## Ranh giới event

- Không map generic DeathEvent thành ChampionKill; không double count hai
  vector hoặc suy kills từ thay đổi scoreboard. Notification/objective-steal/
  damage/first-blood event chưa có mapping đủ nghĩa cho output hiện tại.
- Chỉ lấy record không quá5 game seconds và không ở tương lai. History/tower/
  dragon completeness đều false; không suy counter trụ, rồng hoặc grubs từ
  cửa sổ ngắn. Không đoán firstTurret hoặc timer nhà lính.
- IDs shared là integer52bit từ SHA-256 của identity nội bộ, ổn định khi reorder;
  không copy raw networkId/name/assisters/goldReward. Duplicate cùng record được
  gộp; collision trong một batch bị bỏ và báo truncated.
- Native event budget4096 mỗi snapshot, turret context≤64/inhibitor≤6. Vector
  vượt budget bị bỏ và `eventsTruncated=true`; không coi dữ liệu thiếu là0.
- Thiếu networkId hợp lệ/unique cho10 hero chỉ suppress event; player telemetry
  vẫn có thể tồn tại. Cross-object ID ambiguity không được resolve ngẫu nhiên.

## Từ native tick đến Studio/OBS

Native tick100ms có thể ngắn hơn backend poll750ms. Chỉ lưu latest frame sẽ
làm event mới biến mất trước khi broadcast. `LeagueCollectorSource` giữ hàng
đợi event bounded4096 rồi `broadcastFrame()` drain một lần cho cả Studio/OBS;
HTTP diagnostics gọi `observe()` chỉ đọc, không tiêu thụ event.

Queue hết hạn5s theo cả thời gian thực và game time, nên clock đứng không giữ
alert chờ vô hạn. Lần broadcast đầu không phát baseline; seek/session-change/
reconnect/invalid/lost/stop xóa queue. NetworkId roster tham gia signature hash
nội bộ để đổi session khi roster thay mà gameId/champion/index không thay.
Recording sanitized giữ các native frame đã normalize; queue không sửa raw
provider hoặc theme. `capabilities.events` chỉ phản ánh recent event hiện có,
không là proof lịch sử đầy đủ; `eventSemantics=unverified` và productionReady=false.

## Kiểm chứng và bước tiếp

143 unit test đạt; targeted adapter13/13 đạt sau thêm expiry wall time.
Collector integration đạt: một event giữa các poll được cả Studio/OBS nhận đúng
một lần, diagnostics đọc xen giữa không làm mất event; recording không sentinel
identity. Integration ứng dụng/transport cô lập đạt, build đạt. Browser QA dùng
fixture/theme tạm, không chứng minh event hoặc telemetry thật.

Khi game mở được: đối chiếu timestamp/đội/killer và object presence với event
thật, đặc biệt target bị xóa khỏi snapshot; đo retention vector, pause/seek,
đổi roster/trận và bản ghi. Sau đó tiếp tục rồng/Baron, buff, respawn, CS/lane và
counter/timer objective còn thiếu. Mục tiêu tích hợp đầy đủ chưa hoàn tất.
