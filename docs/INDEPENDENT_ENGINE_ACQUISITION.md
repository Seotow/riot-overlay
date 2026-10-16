# Acquisition engine riêng — kiểm chứng 14/10/2026

**Mốc tiếp tục hiện hành:** API2999 đã được lấy mẫu thật nhưng vẫn thiếu các
field mục tiêu. Probe game một lần dừng ở module query, chưa RPM. Diagnostic v2
đã đạt 5/5 lab trên own processes; chưa có telemetry memory LoL. Xem
[checkpoint lab](../.research/independent-memory/LAB_DIAGNOSTICS.md) và
[game test cũ](../.research/independent-memory/GAME_TEST_HANDOFF.md).
Các bước API ở dưới là lịch sử/gateway, không yêu cầu lặp API test để coi là
đã xây collector. Bước mới cần replay và consent cho một probe v2 có giới hạn.

## Bước đã tiến thêm

Không lặp thử hostLB thiếuDevelop. Engine không gọi LB; đầu vào hiện có là
hai GET2999, không memory/privateIPC/auth/injector. Mục tiêu dữ liệu tương đương
LB vẫn giữ, chưa coi lớp HTTP/WS hoặc API giới hạn là hoàn thành acquisition.

Đã bổ sung:

- Bằng chứng hữu hạn theo mẫu, chỉ timestamp/clock/HTTPoutcome/roster/coverage,
  không raw frame, identity, credentials hoặc giá trị stats.
- Probe timing riêng cho LiveClient và Replay; cảnh báo clockdivergent. Chưa
  suy same-match identity hoặc datafreshness chỉ từ capturedAt mới.
- Roster5+5/10slot riêng, coverage inventory/spells/keystone/vision/death/
  respawn; perks9ID và cooldown entry không bị tính đầy đủ từ arraytrống.
- Từ chối input sourceLB/recording bị gắn nhãn acquisitionđộc lập.
- Một công cụ GET Swagger của patchgame, lưu tên schema đã lọc, không điều
  khiển game. Self-test parser không network.

## Vì sao chưa có source bổ sung được chứng minh

Rà lại [Riot Live Client Data API](https://developer.riotgames.com/docs/lol#live-client-data-api):
activeplayer có currentGold/championStats cho một activeplayer; các route
playerscores/playeritems/playersummonerspells/playermainrunes là subset của
allgamedata, không một nguồn được tài liệu hóa cho HP/vàng/resource/cooldown
của10người spectator. Ability identity/level hoặc canUse không phải cooldown
timer. Đây là giới hạn tài liệu và mẫu đã đo, không khẳng định mọi patch tương
lai sẽ không có endpoint mới; Swagger thật là phép kiểm tra bounded tiếp theo.

[Replay API](https://developer.riotgames.com/docs/lol#replay-api) chủ yếu expose
playback/camera/render/recording/sequence, không rosterstats10người.
[League Director của Riot](https://github.com/RiotGames/leaguedirector/blob/main/leaguedirector/api.py)
cũng phân biệt processID/render visibility với telemetry: healthBarChampions
là setting hiển thị, không health values. Không dùng setting render làmstats.

## Mốc kiểm thử gateway trước phiên probe game

Kiểm tra host chỉ đọc thấy LB listener58869, không listener2999. Bounded engine
2s với `--report` startup/exit0, unavailable/0players; report
`data/engine-reports/engine-2026-10-13T17-26-13.621Z.json` (UTC; ngày local14/10).
Không gọi LB, không coi mẫu unavailable là dữ liệu thật hoặc game unsupported.
Không chạy live Swagger khi chưa có game. Chưa đối chiếu gamepatch/matchidentity.

12testengine +3collector riêng đạt;128unit/regression toànproject đạt, build
đạt. Schema parser syntax +16assertions synthetic đạt, không network/write.
Backend integration riêng4311/theme tạm đạt observer/transport/scenes/providers/
playback. Không
đổi UI/theme/provider production hoặc autostart; không commit/push.

## Runbook test nguồn API — không phải bước hiện hành của nhánh memory

TắtLB, sau đó mở replay Summoner's Rift mới cùng patch,1×, chưa pause/tua, báo
sẵn sàng. Mục tiêu: thu engine thật khôngLB và audit Swagger hiện hành, xác
định chính xác field nào có/thiếu. Chỉ thử endpoint đọc được tài liệu/schema
công khai xác nhận; không patch auth hoặc tìm cách né giới hạn memoryRiot.

Nếu nguồn vẫn thiếu HP/gold/cooldown, kết quả sẽ ghi acquisition chưa đủ; không
gọi thành fullreplacement, không tạo số giả. Nguồn độc lập thực sự cho cácfield
này vẫn là câu hỏi chưa giải, không giải quyết bằng thêm server/mẫu UI.
