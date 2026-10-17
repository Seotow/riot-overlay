# Riot Portal làm nguồn postgame — 13/10/2026

## Chốt endpoint / đủ thiếu sau khi đọc DTO

Yêu cầu mới: ưu tiên xác minh endpoint + payload phục vụ postgame trước;
chỉ tính đến archive theo thời gian nếu nguồn đó không đáp ứng. Chưa triển
khai archive hoặc sửa production. **Damage toàn trận có trong schema Riot**;
không nên tiếp tục gọi nó là field không có ở mọi nguồn chỉ vì feed LB thiếu.

Hai request chính cho VN2 khi match được quyền truy cập:

```text
GET https://sea.api.riotgames.com/lol/match/v5/matches/{matchId}
GET https://sea.api.riotgames.com/lol/match/v5/matches/{matchId}/timeline
```

Request đầu trả **MatchDto**: `metadata` và `info`; `info.participants` chứa
số liệu từng người, `info.teams` chứa kết quả/bans/objectives từng đội.
Request thứ hai trả **TimelineDto**: metadata + info có frames, mỗi frame
có timestamp, participantFrames và events. Match list `/by-puuid/.../ids`
chỉ giúp tìm ID, không phải endpoint trả thống kê.

| Nhóm | Đủ từ MatchDto | Cần TimelineDto / kiểm chứng thêm |
| --- | --- | --- |
| Kết quả + thời gian | teams win, gameDuration, endOfGameResult | Không suy thời lượng từ gameEndTimestamp − gameStartTimestamp khi có gameDuration; Riot cảnh báo end timestamp có thể trễ |
| KDA / vàng / tướng | participant kills/deaths/assists, goldEarned, championId | Bind participantId/teamId và xác minh role, không lấy PUUID/tên vào widget |
| Damage tổng | totalDamageDealtToChampions; physical/magic/trueDamageDealtToChampions | DamageStatsDto của timeline còn có totalDamageDoneToChampions và ba loại tương ứng; đó không phải damage từng hit hoặc combat-window chính xác |
| Trụ / Baron / Herald | team objectives tower/baron/riftHerald kills | Ưu tiên counter đội, không cộng takedown/assist của player thành số mục tiêu |
| Sâu | objectives horde có trong DTO | Cần đối chiếu field với grubs trên patch/trận thật |
| Rồng nguyên tố / Elder | objectives dragon là counter chung, không có counter Elder riêng trong DTO đã đọc | Cần event subtype trong payload timeline hoặc ledger LB để tách; không mặc định counter chung là sáu loại nguyên tố |
| Bans | team bans championId/pickTurn | Không ban/ban thiếu vẫn để slot rỗng; không tạo bans giả |
| Gold graph | Không có lịch sử trong MatchDto | frame participantFrames totalGold; đọc frameInterval. Thiếu 0,5s detail không phải thiếu hoàn toàn graph |
| Buff từng người / Power Play theo thời gian | Không có chuỗi trạng thái buff trong các DTO tổng kết | Nếu muốn thêm vào postgame phải dùng LB history; không cần cho các ô tổng kết hiện tại |

**Khó nhất với người dùng hiện tại là quyền truy cập trận custom thường**,
không phải công thức tính damage. Nhánh official RSO trả MatchDto/TimelineDto
cho custom được phép, nhưng Standard key không phải OAuth token. Tournament
code là hướng khác, chưa có quyền và không dùng hồi tố cho custom cũ.

Portal hiện mô tả EventsTimeLineDto chỉ ba field `timestamp`, `realTimestamp`,
`type`. Vì vậy chưa cam kết field phân loại rồng/Elder, killer team, kết thúc
Nexus hay đầy đủ event-specific schema từ bảng này. Cần response thật để
kiểm chứng; thiếu trong bảng tài liệu không có nghĩa payload không thể có.

## Kiểm chứng tài liệu có thể tái lập

```powershell
node scripts/inspect/inspect-riot-postgame-schema.mjs
```

Hai GET chỉ vào public reference của Riot, không dùng key, không query game.
Artifact `.npm-cache/riot-postgame-schema.json` chứa tên/type field và endpoint.
Có cờ phân biệt rõ **schema, không phải gameplay response**. Script không
đọc key/tên/PUUID. Kiểm chứng này xác nhận khả năng dữ liệu, chưa xác nhận
entitlement hoặc payload của trận mục tiêu.

## Nếu Riot không trả được trận mục tiêu

- KDA/gold/towers/dragons/grubs và chart có thể lấy từ các snapshot LB đã
  xác minh. Counter lấy giá trị cuối, không cộng giữa nhiều frame.
- Baron đếm raw objective Kill, không chỉ buff; Herald/Elder cần kill event
  thật và coverage để không gán số 0 khi không có bản ghi.
- **Damage vẫn thiếu ở LB hiện tại**, ngay cả khi lưu mọi frame suốt trận.
  Không suy từ HP/ability cooldown. Cần nguồn damage được cấp quyền, EOG
  Riot xác minh hoặc nhập từ bảng kết quả; không hứa archive giải quyết nó.
- Winner / thời lượng final vẫn cần terminal evidence hoặc xác nhận operator,
  không suy từ last snapshot/mất socket.
- Bans cần giữ phiên draft / nguồn pre-game; in-game archive không tự phục hồi.

Do chưa có key local hoặc match ID, chưa thực hiện authenticated request;
không báo endpoint đạt/không đạt chỉ từ HTTP của trang tài liệu. Bước kế tiếp
để kiểm chứng payload là key nhập local an toàn + Riot match ID đã kết thúc
(không cần chạy game mới). Trận normal dùng control, custom mục tiêu thử riêng.

Người dùng xác nhận **LoL Production Standard API**, máy chủ **VN2**, chưa
cung cấp match ID/key local. Không có `RIOT_API_KEY` trong môi trường agent.
Lượt này chỉ GET tài liệu công khai; **chưa gọi endpoint gameplay có key**,
không tạo tournament/provider/code hoặc triển khai RSO/server public.

## Kết luận cho cấu hình hiện tại

Riot là nguồn đáng ưu tiên cho số liệu sau trận, đặc biệt damage và winner
mà feed LB đã ghi chưa có. Nhưng Production Standard không tự mở custom
thường, Tournament API hoặc OAuth RSO. Phải chọn đường được cấp quyền:

| Loại trận / quyền | Đường truy cập | Trạng thái |
| --- | --- | --- |
| Trận công khai được Match-v5 hỗ trợ | API key Standard, match ID Riot | Có thể thử trên trận cũ, không cần chạy game mới; chưa thử key thật |
| Custom thông thường | LoL RSO Match v1 + player Bearer token | Official reference ghi match-list gồm custom; cần RSO client/quyền người chơi, chưa xác nhận người dùng có |
| Custom tạo bằng tournament code | Tournament v5, callback/game lookup rồi Match-v5 | Người dùng chưa có quyền Tournament; cần xin bổ sung, không tự đăng ký tài nguyên |
| Practice Tool / custom cũ trong capture LB | Không tự mặc định truy cập được | Chưa có Riot match ID/response; LB database gameId không phải Riot matchId |

## Routing VN2 đã đối chiếu reference hiện hành

- Match-v5 dùng **SEA**: `https://sea.api.riotgames.com` (không phải ASIA).
- Platform APIs dùng `https://vn2.api.riotgames.com`.
- LoL RSO Match reference cho chọn AMERICAS/ASIA/EUROPE/SEA; cần kiểm chứng
  SEA trên match VN2 thật.
- Riot match ID của VN2 có prefix platform, ví dụ dạng `VN2_<gameId>`;
  không lấy số record nội bộ LB rồi ghép prefix để đoán ID.

Nguồn chính xác: [Match-v5 reference](https://developer.riotgames.com/apis#match-v5).
Trang dùng JavaScript tải GET `/api-details/match-v5` (public JSON có field
`html`); đã đọc trực tiếp để tránh parser chỉ thấy danh mục API. Phần đầu
reference xác nhận SEA phục vụ OCE, SG2, TW2 và VN2. Các docs routing chung
chỉ liệt kê host, không đủ tự ánh xạ VN2 sang ASIA.

## Endpoint và field khớp UI

```text
GET /lol/match/v5/matches/{matchId}
GET /lol/match/v5/matches/{matchId}/timeline
GET /lol/match/v5/matches/by-puuid/{puuid}/ids
```

Header API key: `X-Riot-Token`; không đặt key vào query string hoặc frontend.

| UI postgame | Field/cách lấy từ schema chính thức |
| --- | --- |
| Kết quả | `info.teams[].teamId`, `win`; đối chiếu participants `teamId`, `win` |
| Thời gian/patch | `info.gameDuration`, `gameVersion`, end/start timestamps; schema ghi gameDuration hiện đại tính giây, patch cũ cần xử lý đơn vị |
| KDA | participants `kills/deaths/assists`, cộng theo team; không ép quan hệ kills/deaths |
| Tổng vàng | participants `goldEarned`, cộng theo team; không dùng goldSpent |
| Tướng/role | `championId`, `teamPosition`, `individualPosition`; role thiếu/phỏng đoán cần đối chiếu roster, không tự coi array-order là lane-order |
| Damage | `totalDamageDealtToChampions`; có physical/magic/true splits riêng; không lấy totalDamageDealt gồm mục tiêu khác |
| Trụ/Baron/Herald | teams `objectives.tower/baron/riftHerald.kills` |
| Rồng | teams `objectives.dragon.kills`; cần timeline/event để tách Elder và loại nguyên tố, chưa kiểm chứng semantics trên response thật |
| Sâu hư không | schema có `objectives.horde`; ứng viên map cho grubs, cần payload thật đối chiếu, thiếu giữ null |
| Bans | teams `bans[].championId`, `pickTurn`; slot rỗng/không ban cần fallback đúng |
| Đường vàng | timeline frames `participantFrames[].totalGold`, participantId→teamId từ match; đọc `frameInterval`, không hứa cadence 0,5s |

Đây là **độ phủ schema**, không phải field đã quan sát bằng key người dùng.
Match-v5 không phải feed realtime trong trận. Timeline sau trận không mặc
định thay được đường vàng độ phân giải cao của LB: giữ LB full-feed cho
chart chi tiết, dùng Riot đối soát tổng cuối và trường thiếu khi đã bind
chính xác cùng trận. Không âm thầm merge hai trận có cùng tướng/timestamp gần.

## Custom thường: nhánh RSO chính thức hiện nay

[LoL RSO Match v1](https://developer.riotgames.com/apis#lol-rso-match-v1)
reference public có:

```text
GET /lol/rso-match/v1/matches/ids
GET /lol/rso-match/v1/matches/{matchId}
GET /lol/rso-match/v1/matches/{matchId}/timeline
```

Match-list mô tả gồm custom, dựa trên player access token. Cả ba operation
đòi header `Authorization`; không thay Bearer token bằng `X-Riot-Token`.
Match/timeline trả MatchDto/TimelineDto theo reference. Có production key
là điều kiện để xin RSO, không chứng minh đã có OAuth client, client secret,
redirect URI, access/refresh token hay player consent.

[Chính sách LoL/RSO](https://developer.riotgames.com/docs/lol#rso-integration)
yêu cầu custom history chia sẻ công khai có opt-in phù hợp. Scope dữ liệu
10 người và cách phát trên overlay cần được Riot/consent của giải xác nhận;
không mặc định một token cho phép công bố mọi người khác. Không dùng LCU
hoặc endpoint nội bộ để né quy trình này.

## Nếu xin Tournament API

[Tournament docs](https://developer.riotgames.com/docs/lol#tournament-api)
cho phép tạo code, nhận callback khi trận kết thúc, lấy game ID và pull stats.
Reference v5 có GET `/lol/tournament/v5/games/by-code/{tournamentCode}` để
tra trận đã dùng code. Standard key hiện tại không được coi là có quyền này.
Tournament-Stub chỉ thử quy trình, không tạo dữ liệu trận thật. Không gắn
code hồi tố vào custom cũ để kỳ vọng truy xuất được.

Callback cần hạ tầng được Riot truy cập, không phải loopback của Studio.
Chưa cần triển khai hoặc đăng ký provider trước khi người dùng chọn hướng.

## Bước thử thật, không cần mở game

1. Cần **Riot match ID đã kết thúc** trên VN2 để GET match + timeline qua SEA.
   Trận normal/ranked dùng làm control kiểm tra key/routing/schema, không
   chứng minh custom được hỗ trợ. Custom mục tiêu phải thử riêng.
2. Key chỉ đặt local trong backend/CLI, không gửi vào chat, commit, frontend,
   command-line argument/history hoặc log. Chưa có tool authenticated probe
   trong project; chuẩn bị sau khi xác định match ID và cách nhập key an toàn.
3. Report chỉ status + availability/schema/số gameplay đã lọc; raw response
   chứa PUUID/Riot ID phải giữ local ignored, không đưa vào widget/Git.
4. HTTP 401/403: kiểm tra key/quyền, không đổi host/token để vượt hạn chế.
   404: có thể sai ID/region, dữ liệu chưa có hoặc trận không thuộc phạm vi;
   không coi một 404 là kết luận cả API không hoạt động. 429: tôn trọng
   Retry-After, không polling dồn. Trận cũ có giới hạn lưu trữ cần đọc reference.
5. Nếu custom thường không được Standard trả, xác nhận đã có RSO client
   hay chưa; chọn xin RSO hoặc quyền Tournament cho trận sắp tới. LB vẫn
   là nguồn in-game; Riot postgame độc lập và chỉ nhận sau-trận được xác minh.

Không thay schema UI sample thành live trong lượt điều tra này. Chưa xác
nhận Riot trả đủ dữ liệu cho Practice Tool, custom thường trên key hiện tại,
hoặc thời gian sẵn sàng của match ngay sau khi trận kết thúc.
