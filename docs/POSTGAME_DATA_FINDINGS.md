# Điều tra nguồn postgame từ dữ liệu hiện có — 13/10/2026

## Trạng thái hiện tại, 17/10/2026: hướng **replay `.rofl`** (đã mở khóa)

Người dùng chốt hướng tải replay. Postgame đã mở khóa (chỉ khóa khi backend chạy với `RIOT_OVERLAY_POSTGAME=0`).
Luồng, không nhập tay:

1. Sau trận, backend gửi yêu cầu tải replay theo gameId (`POST /lol-replays/v1/rofls/{gameId}/download`, cùng
   yêu cầu với nút tải replay của client) một lần cho mỗi game. **Chưa kiểm chứng spectator tải được replay trận
   tùy chọn**; nếu client từ chối, trạng thái hiện mã HTTP và không làm gì thêm.
2. Backend theo dõi thư mục Replays của client (hỏi LCU `/lol-replays/v1/rofls/path`, `LOL_REPLAYS_DIR`, thư mục
   Documents mặc định) và thư mục thả file `.npm-cache/rofl-inbox`. File `.rofl` mới tự vào vùng duyệt; file có
   sẵn lúc khởi động bị bỏ qua. Chọn file bằng tay vẫn có (trình duyệt chỉ đọc phần metadata ở cuối file).
3. Chỉ đọc metadata JSON ở đuôi ROFL2 (giới hạn 2 MB, không giải mã packet, không chạy replay). Giữ số liệu cuối
   trận và tướng; bỏ tên, PUUID, Riot ID. `shared/rofl-postgame.ts`, `server/rofl.ts`, `server/replays.ts`.

Phân tích `VN2-1607368559.rofl` (7.813.521 byte, 786,4 giây): 10 người, 200 khóa stats mỗi người. Bot là người không
có PUUID (9/10). Winner đội 100 (xanh). Tổng đội xanh: 40/6/14, vàng 63.611, 8 trụ, 1 Baron, 1 Sứ giả, 3 Sâu;
damage lên tướng 40.241/4.366/1.798/3.669/7.025 (khớp LCU). Không có: vị trí (TEAM_POSITION rỗng, nên hàng damage
theo thứ tự trong file), cấm chọn, lịch sử vàng, và rồng: `DRAGON_KILLS` = 5 nhưng `ELDER_DRAGON_KILLS` = 0 trái với
sổ native nên hai mục rồng giữ —. Overlay đã hiển thị đúng bản này (fixture ẩn danh `tests/fixtures/rofl-rows.json`).

Các hướng khác (collector, đại lý máy tham gia, Match-V5 kiểu RCV) giữ trong ghi chú bên dưới để tham khảo.

Đã xác nhận bằng đo thật (game 1608102102, hai máy): máy spectator không có phase kết thúc, không có EOG,
không thấy lịch sử trận tùy chọn; máy người tham gia có `eog-stats-block` đủ 10 người (damage, KDA, vàng,
winner, bot) và lịch sử trận (rồng, sâu, cấm chọn, vàng theo phút). Giải dùng lobby tùy chọn thường, không có
tournament code; mọi bước phải tự động, không nhập tay; LB cần gói trả phí cho damage.

Hướng đang cân nhắc (chưa chọn):

1. **Sổ trận từ collector trên máy spectator** (partial): KDA, trụ, rồng, Sâu, vàng theo thời gian. Winner có thể
   suy từ Nexus (loại `HQ` trong schema native), cần kiểm chứng bằng bản ghi cuối trận thật.
2. **Replay `.rofl` theo gameId**: `POST /lol-replays/v1/rofls/{gameId}/download` rồi parse metadata (đã có
   parser, khớp 10/10 với LCU). Chưa biết spectator tải được replay trận tùy chọn không; cần thử một lần.
3. **Đại lý trên máy người tham gia**: probe chạy như dịch vụ, ghép nối một lần, gửi bundle sang Studio.
4. **Riot Match-V5 tự động theo gameId**, cách của RCV
   [league-prod-toolkit](https://github.com/RCVolus/league-prod-toolkit): lấy gameId, sau trận tải Match-V5 và
   timeline bằng Riot API key, LCU EOG chỉ là dự phòng. Cần Production key và Tournament-V5 (tournament code)
   hoặc RSO; lobby tùy chọn thường hiện không đủ điều kiện.
5. Loại: LB (damage cần gói trả phí), LCU trên spectator (không có dữ liệu), nhập tay (không chấp nhận).

## Kết luận

Cập nhật 17/10: hướng ROFL tạm hoãn theo quyết định người dùng. File đã thử
do tài khoản người chơi tải từ client trước đó, không phải spectator tự lấy.
Các kết quả LCU và ROFL giữ trong tài liệu riêng để nghiên cứu tiếp, chưa
đưa vào quy trình sau trận tự động của bản nội bộ.

Có thể tự tổng hợp phần lớn thống kê và đường vàng từ **feed in-game đã được
cấp quyền**, không cần dùng endpoint tổng kết premium. Tuy nhiên không thể
phục hồi damage to champions hoặc winner chỉ từ những snapshot đang có.
Thu đầy đủ start→end vẫn là điều kiện cần cho lịch sử, không tự tạo field
mà provider chưa xuất. Chưa nối UI vào dữ liệu này, chưa chạy game/collector.

## Phạm vi / tái lập

Đọc source adapter/session/capture và các file đã lưu; đối chiếu SDK công khai
BlueBottle tại revision `b8c70f1d5b9f70c5fb9d36c5ea2f37a31a91ae91`.
Không gọi LB/LCU hiện tại, không đăng nhập, bật widget, sửa config game,
khởi động REA/collector hoặc can thiệp quyền premium.

```powershell
node scripts/inspect/inspect-postgame-evidence.mjs --save
```

Script stream-read 15 file `leaguebroadcast-ws.ndjson` (14 có message):
2.788 message = 2.752 state + 36 status; 2.556 frame đủ roster 10 người;
không có dòng lỗi JSON. Đây là nhiều phiên, **không phải một trận duy nhất**.
Hai bản Phòng Tập chỉ có 1 người mỗi đội không chứng minh roster 10 người.
Output `.npm-cache/postgame-evidence.json` chỉ schema paths, enum gameplay
đã allowlist, số liệu đội và game-time; không in tên/người chơi/credentials.

Ngoài WS, đã kiểm tra các snapshot HTTP Riot events/allgamedata và LB
game-current/Swagger ngày 19/09; không có GameEnd/winner được xác nhận trong
các snapshot ấy. SDK/Swagger chỉ là contract, không coi như payload đã nhận.

## Premium có bằng chứng gì?

Swagger đã lưu tại
`data/captures/2026-09-19T18-47-08-742Z/leaguebroadcast-swagger.json` khai báo
GET `/api/postgame/overview/current` và `/api/postgame/overview/{gameId}` có
response `403`: quyền feature hiện hành không cho truy cập endpoint.
Đây là khai báo trong snapshot Swagger, **không phải HTTP probe mới** hoặc
cam kết trạng thái entitlement của mọi tài khoản/version. Khớp thông tin
premium người dùng cung cấp; không thử vượt giới hạn này.

Schema `PostGameOverview` gồm winnerSide/gameTime/teamOverviewBySide/goldGraph/
damageGraph. `PostGameTeamOverview` gồm KDA/gold/towers/grubs/heralds/dragons/
elderDragons/baronNashors/bans. Có thể dựng contract của overlay độc lập từ
phần dữ liệu in-game khả dụng, không cần sao chép response premium.

## Ma trận nguồn cho UI hiện tại

| Vùng UI | Bằng chứng đã có | Cách tổng hợp / giới hạn |
| --- | --- | --- |
| Tướng 10 người | `scoreboardBottom.teams[].players[].champion.id` | Numeric ID thật; map bằng catalog phù hợp patch, giữ thứ tự role đã xác nhận |
| K/D/A hai đội | players `kills/deaths/assists`, đội `kills` | Lấy snapshot cuối hợp lệ rồi cộng 5 người; **không cộng KDA giữa các frame**. Kills đội đối chiếu kills player; không ép deaths = kills đối thủ |
| Tổng vàng | `scoreboard.teams[].gold`, players `totalGold` | Lấy tổng tại cuối, không cộng các snapshot. Float thật; giữ precision khi tính, chỉ làm tròn để hiển thị |
| Trụ | `scoreboard.teams[].towers` | Counter tích lũy, lấy cuối. Không cần đếm toast; mất một event vẫn có counter |
| Rồng nguyên tố | `scoreboard.teams[].dragons` | Đếm sáu loại `Dragon_earth/fire/water/air/hextech/chemtech`; Elder tách riêng nếu thật sự xuất hiện |
| Sâu hư không | `scoreboard.teams[].grubs` | Lấy counter, không đếm số event. Mẫu có counter 2 dù chỉ thấy một event kill grub |
| Baron | Raw `message.events.objective[]`: objective Baron, eventType Kill, team | Có event kill thật. Đếm event một lần theo timeline, không cộng thêm buff transition cho cùng kill. Số đã quan sát chưa là tổng chắc chắn nếu capture giữa trận/mất đoạn |
| Sứ giả | SDK cùng objective event, chưa có Herald kill trong capture | Chưa xác minh event thật; không gán 0 chỉ vì không thấy. Không có team herald counter trong các frame đã đọc |
| Elder | Player `hasElder` có nhưng chỉ false; SDK objective/dragon route | Chưa có kill/buff true để xác minh. Không suy tổng số Elder từ buff cuối trận |
| Biểu đồ vàng | Gold đội mỗi snapshot + `state.gameTime` | `delta = blue.gold - red.gold`; dùng sample quan sát, ngắt đoạn thiếu. Không cần field `goldGraph` premium để tự vẽ |
| Damage 10 người | **Không có** damage field trong toàn bộ WS đã scan | Giữ null; HP delta không đủ phân biệt người gây damage, heal/shield/môi trường, sát thương bị bỏ giữa hai sample |
| WIN/LOSS và thời gian cuối | Có game clock; không có winner/terminal được xác minh | Frame cuối chỉ là last-observed, không phải thời điểm Nexus nổ. Disconnect/OutOfGame không đủ kết luận kết thúc hoặc đội thắng |
| Bans | Không có draft/bans trong WS đã lưu | Giữ phiên draft đã nhập tay hoặc thu `/ws/pre` được cấp quyền ở trận sau. `/api/game/{gameid}/bans` là ứng viên GET trong Swagger, chưa có payload bans xác minh |
| Tên/logo/màu/tỉ số loạt | Theme hiện hành | Config của giải, không suy từ provider; game kills không phải tỉ số loạt trận |

## Bằng chứng cụ thể từ capture dài nhất

`lb-2026-10-11T09-07-37-947Z`: 2.304 state gồm bootstrap trống; 2.303 frame
đủ 10 người. Roster đầu ở **00:42.377**, cuối **21:37.696**. Status chỉ 0/1/2;
không có GameOver=5, winner hoặc message postgame. Vì vậy không xác nhận đây
là bản ghi đầy đủ start→end, không sửa thời gian lên mốc chat 22:13.

Frame cuối thật (không phải kết quả cuối trận):

| Chỉ số | Xanh | Đỏ |
| --- | --- | --- |
| KDA cộng player | 48/23/34 | 20/48/38 |
| Gold đội | 165.082,45 | 34.600,645 |
| Trụ | 6 | 1 |
| Rồng nguyên tố | Đất, Lửa, Nước, Nước | 0 |
| Sâu hư không | 0 | 2 |

Số vàng lớn / chênh KDA là số Phòng Tập quan sát, không dùng để suy lỗi hoặc
thắng/thua. Không ép các số liệu thành giá trị của một trận đấu chuẩn.

Raw objective kill trong capture: Dragon ở 530.2821, 769.9357, 796.9565,
823.479 giây (team 1); Baron ở **717.56793** giây (team 1); grub ở
588.80664 giây (team 2). Baron có cả event kill và transition buff; đây là
**một** lần hạ, không hai. Team 1/2 khớp hai phía trong mẫu này, phải validate
mapping cho adapter mới thay vì áp dụng tùy ý cho mọi nguồn.

## Các điểm backend hiện tại sẽ làm mất thông tin tổng kết

- `LeagueBroadcastSource.accept` chỉ normalize `m.state`, không giữ raw
  `m.events.objective`; các event output được dựng từ diff/counter/buff.
  Do đó raw logger trên đĩa có bằng chứng Baron rõ hơn normalized contract.
- Non-running status và socket close xóa sample/baseline. Đây là hành vi
  đúng để OBS không giữ stale in-game, nhưng postgame cần kho phiên riêng
  giữ last valid snapshot và terminal evidence, không đọc frame đã bị xóa.
- `ObserverSession` đổi sessionId khi reconnect; history RAM chỉ 120 frame /
  khoảng 2 MB. Không dùng bộ đệm này như kho lịch sử toàn trận.
- Capture replay chủ yếu dựng lại state, không có final-result/winner/damage
  schema. Alert được reset theo seek; không nên lấy số toast đã phát để đếm
  mục tiêu cả trận. Cần event ledger riêng với coverage.
- Contract postgame hiện **chỉ sample**, asset 15.20.1, số/time integer. Trước
  khi nối thật phải migration/provenance/availability/coverage, patch live
  riêng và game-time float. Không đổi `source` sample thành live cho thuận tiện.

## Cập nhật LCU 17/10/2026

**ROFL tạm hoãn:** đã đọc metadata `.rofl` của chính trận custom, đủ final
damage 10 người, KDA/gold/winner, đối chiếu khớp LCU player. Không cần API key
để đọc file đã có, nhưng file do người tham gia tải từ client trước đó.
Chưa triển khai import/publish; Elder counter có discrepancy
và gold history vẫn cần archive. Xem [ROFL postgame](ROFL_POSTGAME_FINDINGS.md).

Đã lấy chi tiết trận CUSTOM_GAME 1607368559 qua LCU match history của người
tham gia, đủ 10 người và damage/winner/gold/KDA. Raw native chứa đúng game ID.
Đây là nguồn khác với native damage=0 và không cần LB postgame premium.
Đối chiếu sau khi đổi sang spectator: history không có custom; detail/timeline
cùng game trả 404. Vì vậy không dùng LCU trên spectator làm lời hứa tự động
lấy custom; phương án tiếp là thu/export từ client người tham gia trận.
Chưa tích hợp production hoặc khẳng định mọi custom. Xem
[bằng chứng và giới hạn](LCU_POSTGAME_FINDINGS.md).

## Điều tra hướng cho tài khoản spectator, 17/10/2026

Đọc `/help?format=Full` của LCU (chỉ đọc, 1.447 hàm) và thử GET trên client đang mở (tài khoản
Seotoww, phase Lobby). Không POST, không tải file, không in token.

| Điểm | Kết quả |
| --- | --- |
| `GET /lol-end-of-game/v1/gameclient-eog-stats-block` | Có trong LCU: `{ gameId, gameMode, queueId, queueType, isRanked, statsBlock: object }`. Đây là khối game client gửi cho client khi trận kết thúc. 404 khi chưa có trận kết thúc. **Chưa biết** client spectator có nhận khối này không |
| `GET /lol-end-of-game/v1/eog-stats-block` | Có `teams[].players[]` (champion, puuid, riotId, `stats: object`, `isLocalPlayer`), `isWinningTeam`, `gameLength`. Dựng quanh người chơi cục bộ; 404 ngoài màn kết quả |
| `lol-replays` | `GET /lol-replays/v1/metadata/{gameId}` chỉ trả `state` (ví dụ `watch`) và `downloadProgress`. `POST /lol-replays/v1/rofls/{gameId}/download` nhận gameId + contextData; **chưa biết** spectator tải được custom của người khác. Replays có kiểu `GAMHS` chứa `totalDamageDealtToChampions` |
| `lol-match-history` | Chi tiết/timeline theo gameId: đã xác nhận 404 với spectator |
| Native collector | `damageDealtEvents` có nhưng `damageDealt` luôn 0 trong mọi bản ghi; không phải nguồn damage |

### Probe EOG chỉ đọc (chạy trên máy spectator)

```powershell
npm run probe:eog          # tự dừng 90 giây sau khi về lobby; Ctrl+C để dừng sớm
npm run probe:eog -- --keep   # chạy qua nhiều trận
```

Bật trước khi vào trận (hoặc lúc đang ở lobby/phòng cấm chọn). Probe chỉ GET: `gameflow-phase` và
`gameflow/v1/session` (phase, gameId, isSpectator, queueId, gameMode), `gameclient-eog-stats-block`,
`eog-stats-block`, rồi `lol-replays/v1/metadata/{gameId}` khi phase là WaitingForStats/PreEndOfGame/
EndOfGame/Lobby. Thông tin đăng nhập LCU lấy từ tiến trình LeagueClientUx, chỉ nằm trong RAM.
Kết quả ở `.npm-cache/lcu-eog/` (không theo Git): `probe-<thời gian>.ndjson` là nhật ký
(phase, trạng thái HTTP, tóm tắt: số người, các khóa `stats`, có `DAMAGE_DEALT_TO_CHAMPIONS` hay không) và
`<thời gian>-NN-<endpoint>.json` là payload đã lọc (bỏ PUUID, Riot ID, tên, token, dữ liệu chat; giữ
số liệu và champion). Đọc `summary.hasDamageToChampions` và `players` để biết spectator có nhận EOG
đủ 10 người không.

### Kết quả đo thật, 17/10/2026 (game 1608102102, hai máy cùng trận)

| Máy | Phase quan sát | Kết quả |
| --- | --- | --- |
| Spectator | Lobby → ChampSelect → InProgress → **None** (không có WaitingForStats/EndOfGame) | Không có payload EOG nào; metadata replay chưa có dòng hợp lệ |
| Người tham gia | … → **EndOfGame** | `eog-stats-block` 200: 2 đội, 10 người, 183 khóa `stats` mỗi người, có `TOTAL_DAMAGE_DEALT_TO_CHAMPIONS`, KDA, vàng, winner, cờ bot; `gameclient-eog-stats-block` 404; replay metadata `state: download` |

Kết luận: client spectator **không** vào luồng kết thúc trận nên không nhận EOG. Dữ liệu đầy đủ có ở client của
người tham gia ngay khi vào EndOfGame. Hướng khả thi: đọc `eog-stats-block` trên máy người tham gia rồi chuyển
kết quả đã lọc sang Studio (export/import hoặc kênh được cấp quyền), không chuyển token LCU. Probe ghi thêm
`endpoint-status` để phân biệt 404 với lỗi khác và poll mỗi giây trong 60 giây sau khi trận kết thúc.

### Bộ nhập EOG (đã làm)

Studio → **Sau trận** → mục **Nhập từ file EOG (LCU)**: chọn file `*-postgame-bundle.json` (đủ dữ liệu) hoặc `*-eog-stats-block.json` do probe lưu
(hoặc payload thô; server lọc lại trước khi dùng), nhập ván trong loạt, rồi xem bản chờ duyệt, tích đã đối chiếu
và bấm **Dùng dữ liệu này cho postgame**. Chuẩn hóa ở `shared/eog-postgame.ts`, API
`POST /api/riot-postgame/import-eog` (JSON tối đa 1 MB, chỉ từ Studio).

Nguồn nạp: (1) chọn file bằng tay; (2) danh sách **Đã lưu trên máy này** (các bản probe lưu ở
`.npm-cache/lcu-eog`); (3) tự động: backend đọc `eog-stats-block` của client trên máy chạy Studio
(4 giây một lần) và đưa vào vùng duyệt một lần cho mỗi game. Chỉ máy người tham gia mới có khối này; trên
máy spectator, mục (3) không bao giờ có gì. Không có bản nào tự lên overlay: luôn cần tích đã đối chiếu rồi
bấm dùng.

Bổ sung từ lịch sử trận của client người tham gia (`/lol-match-history/v1/games/{id}` và
`/game-timelines/{id}`, chỉ đọc, rút gọn ở `shared/eog-history.ts`, không giữ tên hay ID tài khoản): bộ đếm
rồng/Baron/Sứ giả/Sâu/trụ, cấm chọn, biểu đồ vàng theo phút (mỗi khung timeline), patch, và tách rồng
nguyên tố/Elder từ event `ELITE_MONSTER_KILL` chỉ khi mọi event có đội và tổng khớp bộ đếm. Backend tự lấy
phần này khi đưa EOG vào vùng duyệt (thử lại khi lịch sử đến trễ); probe lưu thêm file
`*-postgame-bundle.json` gồm `{ eog, history }` để nhập trên máy khác. Đã thử với game 1608102102: rồng
đỏ 1 (Hextech), sâu 1/2, 17 điểm vàng, các mục khác 0; trận practice nên không có cấm chọn.

Ánh xạ: đội 100 là xanh, 200 là đỏ; winner từ `isWinningTeam`; thời lượng từ `gameLength`; người chơi
xếp TOP/JUNGLE/MID/BOT/SUPPORT theo `detectedTeamPosition` (thiếu thì theo thứ tự client, có cảnh báo);
damage, KDA, vàng, trụ cộng từ `stats` từng người; `botPlayer` giữ thành cờ `bot`. EOG không có cấm/chọn,
lịch sử vàng, rồng nguyên tố/Elder, Baron, Sứ giả, Sâu: các mục này để —, không điền 0. Định danh trận
là `LCU_<gameId>`, nhãn nguồn `LCU-EOG`. Đã thử với game 1608102102: 10 người, winner đỏ, 15:46, overlay
hiển thị đúng; fixture rút gọn không có tên ở `tests/fixtures/eog-stats-block.json`.

Hướng thử tiếp, theo thứ tự rủi ro thấp trước:

1. **Thăm dò chỉ đọc cuối trận trên máy spectator**: poll `gameflow-phase`, `gameclient-eog-stats-block`
   và `eog-stats-block` từ lúc vào trận tới khi về lobby, ghi payload đã lọc (không PUUID/Riot ID).
   Cho biết spectator có nhận khối EOG không và `stats` có damage đủ 10 người không.
2. **Replay theo gameId**: sau trận, đọc `metadata/{gameId}`; chỉ khi người dùng đồng ý mới thử
   `download`. Nếu tải được `.rofl`, đã có parser đọc metadata (khớp 10/10 với LCU) để lấy damage,
   KDA, gold, winner.
3. **Máy người tham gia**: agent chỉ đọc LCU history sau trận rồi export JSON (đã xác nhận có đủ damage).
4. Riot Match-V5/Tournament/RSO cần quyền riêng; key Standard hiện 403/404.
5. Dự phòng: sổ sự kiện từ collector cho KDA/vàng/mục tiêu (partial) và operator nhập damage + winner
   với provenance thủ công.

## Damage và winner: hướng có thể kiểm chứng tiếp

[SDK ingameFrontendData](https://github.com/BlueBottleGG/leaguebroadcast-js-client/blob/b8c70f1d5b9f70c5fb9d36c5ea2f37a31a91ae91/types/ingame/ingameFrontendData.ts)
có optional damageGraph/damageRecap/teamfightTimeline/goldGraph. Các field
này **không hiện diện** trong capture đang có; không kết luận luôn miễn phí
hoặc luôn xuất. DamageGraphEntry có totalDamageDealt/damageByType nhưng
scope/cửa sổ chưa xác minh. Không cộng các graph snapshot liên tiếp; không
cộng recap của các death/teamfight rồi gọi là damage toàn trận vì có thể
chồng lặp hoặc bỏ damage ngoài giao tranh.

Swagger có GET `/api/ingame/damage/history`, nhưng schema chỉ danh sách
DamageEventHistoryEntry (victim/killer/totalDamage/teamfight times), không
phải đầy đủ damage stream có attacker/target/event ID cho mỗi hit.
Chưa probe, chưa biết tài khoản hiện tại có quyền; 403 phải dừng nguồn đó.

Ứng viên bổ sung có giới hạn, **chưa tích hợp**:

1. LCU `/lol-end-of-game/v1/eog-stats-block` đã có probe chỉ đọc trong project;
   cần response thật sau trận trên máy spectator để biết có winner và damage
   của đủ 10 người không. Hiện không có capture thành công chứng minh.
2. LB GET `/api/game/current` hoặc game đã lưu: Swagger có gameWinnerId,
   isComplete/gameTime; snapshot hiện chỉ isComplete=false và không winner.
   Nếu quyền truy cập cho phép, kiểm chứng sau trận; không coi UI winner
   do operator nhập trong LB là quan sát trực tiếp từ game.
3. [Riot Tournament API](https://developer.riotgames.com/docs/lol#tournament-api)
   có callback kết quả và match lookup cho trận tạo bằng tournament code.
   Cần quyền/API key/quy trình giải; không coi custom thường là tự truy cập
   được Match API. Riot có quy định riêng về opt-in/RSO cho custom history.
4. Với giải nhỏ, lựa chọn dự phòng là operator xác nhận winner và nhập damage
   từ bảng kết quả Riot sau trận. Phải ghi provenance manual; khác dữ liệu tự
   động. Không cần chọn ngay khi người dùng chưa thể mở game.

## Thiết kế bước tiếp theo (chưa triển khai)

1. Match archive riêng trước loading: bind game identity/roster + config/draft
   của phiên; không kết luận reconnect = trận mới. Không auto nối hai trận chỉ
   vì trùng tướng. Live, recording và mock luôn tách provenance.
2. Thu **mọi message WS** theo event-driven, receivedAt + gameTime + sequence;
   logger hiện có thường khoảng 2 Hz. Muốn chart 0,5s có thể chọn sample quan
   sát trong bin để vẽ, không thay logger toàn feed bằng polling 0,5s.
3. Lưu snapshot cuối hợp lệ + gold history + objective ledger. Counter là
   tích lũy; ledger có dedup/correlation và coverage đầu/cuối/gián đoạn.
   Nếu event không có ID nguồn, lưu message sequence/index và kiểm chứng
   replay/reconnect semantics trước khi hứa exactly-once. Buff là fallback
   lower bound, không chứng minh tổng kills objective.
4. Khi có terminal evidence, đóng archive; nếu chỉ mất nguồn, đánh dấu
   interrupted/partial, không tuyên bố winner/finalDuration. Lịch sử thiếu
   giữ gap. Không sửa data để lấp fast-forward/seek.
5. Xuất summary normalized cho UI: observed/derived/manual/missing theo field;
   `isFinal`, terminal evidence, lastObservedGameTime và coverage tách nhau.
   Reconcile nguồn end-game được cấp quyền khi có; không âm thầm merge provider.

Có thể triển khai/test aggregator offline với capture hiện tại (nhãn partial)
trước phiên game mới. Nhưng lượt này là **điều tra**, không tự đổi nguồn sản
xuất/UI hay bắt đầu implementation. Cần trận sau để xác nhận damage/winner/
terminal/Herald/Elder live; các mốc telemetry hoãn vẫn ghi rõ như cũ.
