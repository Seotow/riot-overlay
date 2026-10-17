# Postgame qua lịch sử người tham gia trên LCU

## Đối chiếu tài khoản spectator, 17/10/2026

Người dùng logout player, đăng nhập spectator rồi yêu cầu kiểm lại đúng Riot ID
và game ID. Probe đọc lockfile mới; xác nhận PUUID của current-summoner khác
PUUID tra đúng `Seotoww#2013` (report chỉ lưu boolean, không lưu PUUID).

| Thao tác bằng phiên spectator | Kết quả |
| --- | --- |
| Tra Riot ID | 200, một kết quả khớp chính xác |
| Lịch sử của Seotoww | 200, trả 20 trận, 0 CUSTOM_GAME; không có 1607368559 |
| GET chi tiết 1607368559 | 404, không có participants/damage |
| GET timeline 1607368559 | 404, không có frame |

Đây là đối chiếu thật cùng game: player trước đó 200, spectator sau đó 404.
Biết game ID không đủ để lấy custom từ spectator ở trường hợp này. Dừng
nhánh endpoint đã bị từ chối; không dùng credentials cũ hoặc tìm cách vượt
quyền. Không suy nguyên nhân bên trong server hoặc khái quát mọi loại custom.
Evidence `.npm-cache/lcu-postgame-spectator.log` và
`.npm-cache/lcu-postgame-spectator-history.log`. Bằng chứng thành công ở phiên
player vẫn nằm riêng trong `.npm-cache/lcu-postgame-custom.log`; không coi
response cũ là kết quả request của phiên spectator.

Hướng khả thi tiếp theo là thu kết quả trên client của một người tham gia:
agent chỉ đọc LCU sau trận rồi export JSON chuẩn hóa để Studio import/stage,
hoặc chuyển về Studio bằng kênh được cấp quyền. Không chuyển mật khẩu/token
LCU sang máy spectator. Một máy dùng luân phiên hai tài khoản phải lưu kết quả
trước logout. Đây là phương án đề xuất, chưa triển khai agent/import LCU.

## Kết quả thật, 17/10/2026

Đã kiểm bằng GET local, không đổi trang client, không dùng Riot production
key hoặc LB postgame premium. Riot ID người dùng đưa: `Seotoww#2013`.
Game ID người dùng chỉ định: `1607368559`. Các response thành công HTTP 200:

| Bước | Endpoint | Kết quả quan sát |
| --- | --- | --- |
| Tìm người | `/lol-summoner/v1/summoners?name=Seotoww%232013` | Một kết quả, gameName/tagLine khớp chính xác |
| Lịch sử người tham gia | `/lol-match-history/v1/products/lol/{puuid}/matches?begIndex=0&endIndex=4` | Danh sách trận; mỗi trận ở list chỉ có một participant |
| Chi tiết trận đã chọn | `/lol-match-history/v1/games/1607368559` | CUSTOM_GAME, queue 3140, 786 giây, 10 participant |
| Timeline | `/lol-match-history/v1/game-timelines/1607368559` | 15 frame, timestamp 0 đến 786545ms |

PUUID và thông tin đăng nhập chỉ xử lý trong bộ nhớ. Credentials LCU không
được in, lưu vào evidence, đưa frontend, theme hoặc Git. Local report chỉ có
field gameplay đã chọn, tại `.npm-cache/lcu-postgame-player.json` và
`.npm-cache/lcu-postgame-custom.log`. Probe: `scripts/inspect/probe-lcu-postgame.ts`.

`/lol-summoner/v1/alias/summoners` trả 404 ở client này. Không dùng một endpoint
theo tài liệu cũ như bằng chứng nó đang hoạt động. Swagger ở hai đường đã thử
không cung cấp schema dùng được; kết luận trên dựa vào response thật.
History có thể trả nhiều hơn range yêu cầu (đã thấy 20 thay vì 5); integration
phải đọc gameCount/index thực và giới hạn hiển thị/xử lý, không giả định số lượng.

## Đúng cùng trận với bản ghi

Raw gốc `data/captures/2026-10-16T12-43-43-938Z/collector-native.ndjson.gz`
chứa `data.gameId = "VN2-1607368559"`. Đây là liên kết identity trực tiếp với
chi tiết LCU, không chỉ đoán từ roster/duration. Projection 10 vẫn giữ raw gốc.

## Dữ liệu postgame thực sự có

- `participants[].stats.totalDamageDealtToChampions` đủ 10 người.
  Yasuo 40241, Smolder 4366, Veigar 5889. Đây là sát thương lên tướng toàn trận,
  không phải damage=0 của native feed, không suy từ HP hoặc cộng snapshot.
- Cùng stats có kills/deaths/assists, goldEarned, win; cả 10 người có giá trị.
- teams có towerKills, dragonKills, baronKills, riftHeraldKills, hordeKills,
  inhibitorKills, bans và win. Đội 100 thắng, 8 trụ, 5 dragonKills, 1 Baron,
  1 Herald, 3 hordeKills. Đội 200 thua. Bans thực tế trống ở trận phòng tập.
- Timeline participantFrames có totalGold/currentGold, XP/level/CS và participantId.
  Có thể tạo đường chênh vàng theo những mốc đã trả, không phải dữ liệu 0.5s.

## Không tự điền hoặc gán sai

- Lane ở trận này là NONE và role nhiều người là SUPPORT/DUO, không đủ sắp lane.
  Ưu tiên roster/lane quan sát trong trận, map bằng identity; nếu thiếu/không
  duy nhất thì yêu cầu operator xác nhận, không đoán bằng champion hoặc array index.
- `dragonKills=5` không có nghĩa 5 rồng nguyên tố: ledger trận này ghi 4 nguyên tố
  và 1 Elder. Muốn chia Drakes/Elder cần timeline event hoặc ledger đã xác minh;
  không hiển thị aggregate vào cả hai chỉ số.
- Chưa kiểm đầy đủ split physical/magic/true damage hoặc event subtype Elder trong
  response timeline. Client đóng trước lượt probe bổ sung; không suy từ field schema.
- Chưa có bằng chứng mọi custom giải 5v5 hoặc mọi trường hợp privacy đều lấy
  được. Trận CUSTOM_GAME này đã lấy được khi đăng nhập người tham gia, nhưng
  đã kiểm thất bại với tài khoản spectator khác người chơi (chi tiết ở trên).
- Không tự chọn latest làm kết quả giải. Phải chọn/đối chiếu chính xác gameId,
  platform, roster, thời gian và trạng thái kết thúc; không ghi đè trận khác.
- LCU là API nội bộ client, chưa coi là hợp đồng ổn định như Riot Web API.
  401/403/404 hoặc lịch sử không truy cập được phải báo và dừng, không bypass.

## Bước triển khai đề xuất, chưa nối production

1. Backend discovery lockfile gồm đường cài thực hoặc cấu hình local; credentials
   chỉ RAM. Chỉ allowlist GET cho search/history/detail/timeline, không làm proxy URL tùy ý.
2. UI Sau trận: nhập Riot ID, tải danh sách tóm tắt, chọn trận rõ game ID/thời gian/
   loại trận. Có ô game ID để tra trực tiếp trận đã xác định.
3. Stage normalized candidate riêng với provenance LCU; kiểm 10 người 5+5, damage,
   winner, identity và khả dụng từng field. Preview trước, operator publish sau.
4. Đối chiếu archive native qua game ID để lấy lane/branding/gold samples/objective
   ledger. Không âm thầm trộn hoặc thay missing thành 0. Giữ partial/gap rõ ràng.
5. Test fixture cho missing/403/404/wrong match/ambiguous identity. Triển khai
   collector kết quả trên máy người tham gia nếu user chọn hướng này; không
   hứa spectator tự đọc được custom qua LCU sau đối chiếu thất bại thực tế.

Đã điều tra được nguồn dữ liệu; chưa thêm LCU source vào module postgame hoặc tự
publish kết quả. Luồng Riot Web API đã có được giữ nguyên.
