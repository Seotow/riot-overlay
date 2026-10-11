# Nguồn dữ liệu và hướng nghiên cứu

Cập nhật: 26/09/2026.

## Kết luận hiện tại

Không có một API miễn phí đã xác minh nào thay thế toàn bộ LeagueBroadcast cho observer. Với phạm vi sản phẩm hiện tại, **LeagueBroadcast là dependency bắt buộc cho chế độ production giải đấu đầy đủ**. Riot local được giữ cho replay, chẩn đoán và chế độ giới hạn; OCR hoặc feed được cấp quyền chỉ là hướng bổ sung/thay thế trong tương lai sau khi được kiểm chứng.

| Nguồn | Trạng thái | Lấy được | Không giải quyết được |
| --- | --- | --- | --- |
| Riot Live Client + Replay API | Đang hoạt động | 10 người, tướng, cấp, KDA, CS, trang bị, phép, ward score, chết/hồi sinh, event, clock và điều khiển replay | Total gold, HP, resource và rune đang thiếu trong mẫu spectator/replay |
| LeagueBroadcast WebSocket | Đã xác minh với custom tournament spectator | 10 người, champion, level, KDA, CS, item, gold, HP, resource, spells, perks, vision, respawn; payload còn có team score, objective và pit timer | Replay thường chỉ ở trạng thái Loading; event/objective adapter vẫn cần hoàn thiện |
| Overwolf GEP | Nghiên cứu | Live Client Data được chuyển tiếp, event, match clock; tài liệu có `gold`/`total_gold` nhưng không xác định scope | Chưa có bằng chứng cung cấp gold, HP và resource của đủ 10 observer |
| OBS capture + OCR | Phase tiếp theo | Tổng gold đội, kills, trụ, rồng, clock và các giá trị thật sự đang hiển thị trên HUD | Không thể lấy ổn định dữ liệu không hiện đồng thời như HP/resource của cả 10 người; rune phụ thuộc layout |
| Feed giải đấu được cấp quyền | Chưa có quyền | Có thể cung cấp telemetry chính xác và đầy đủ tùy hợp đồng | Không phải nguồn free; cần xác minh license và quyền phát lại |

Data Dragon chỉ dùng để đổi ID/token thành tên và ảnh. Nó không phải nguồn realtime.

## Ma trận bằng chứng BlueBottle

Nhãn dùng trong nghiên cứu: **CONFIRMED** = artifact/log/capture trực tiếp; **STRONG EVIDENCE** = nhiều dấu vết độc lập nhưng thiếu phép thử quyết định; **HYPOTHESIS** = cần phép thử phân biệt; **UNKNOWN** = chưa đủ bằng chứng. Quy trình lab, risk model và sáu câu hỏi điều tra nằm trong `LEAGUEBROADCAST_FEASIBILITY.md`.

| Mệnh đề | Nhãn | Bằng chứng hiện có | Khoảng trống |
| --- | --- | --- | --- |
| JS client chỉ nhận feed, không phải collector | CONFIRMED | Source client công khai chỉ kết nối `/ws/in`, xử lý message/heartbeat/clock | Không mô tả backend acquisition |
| Process local xuất WebSocket trên cổng 58869 | CONFIRMED | Baseline, Loading và Running đều do `BlueBottleClient.Interface.exe` sở hữu listener; capture nhận `gameStatus` và `ingame-state-update` | PID là chi tiết từng phiên, không phải identity bền vững |
| Backend tách acquisition khỏi frontend qua native module và IPC | CONFIRMED | Hai lần dynamic: `lblib.dll` xuất hiện trong process LB, Farsight kết nối NamedPipe rồi phát 54/101 frame; static IL xác nhận `LoadLibraryEx` + `BlueBottleHook` + `SetWindowsHookEx` tới thread LoL | Chưa quan sát trực tiếp module trong game process; logic native tạo từng field chưa được đọc đầy đủ |
| Collector hiện hành đọc state/memory bên trong LoL | STRONG EVIDENCE | Xác nhận Discord do người dùng cung cấp, đường injection/module, field vượt Riot spectator API và tiền thân Farsight đọc memory | Chưa có call trace chứng minh provenance từng field; import `ReadProcessMemory` riêng lẻ không đủ |
| BlueBottle được Vanguard cho phép theo cơ chế có thể sao chép | UNKNOWN | Ứng dụng đã chạy trong các phiên quan sát; `lblib.dll` có chữ ký BlueBottle GmbH | Không có xác nhận Riot về allowlist, entitlement hoặc điều kiện kỹ thuật/pháp lý |
| Snapshot gameplay đi qua `broadcast.bluebottle.gg` | STRONG EVIDENCE: KHÔNG | Trong 47,31 giây Running, public local feed xuất 92 update/~1,53 MB JSON; endpoint broadcast chỉ trao đổi 1.789 byte nhận + 2.186 byte gửi. Frame bắt đầu sau NamedPipe connected | JSON lớn hơn FlatBuffer nguồn; các endpoint AWS/Cloudflare khác chưa đo riêng, nên chưa khái quát thành “không cloud ở mọi bước” |

Điều tra dynamic chỉ thực hiện trên laptop nghiên cứu và đi theo thứ tự baseline → process tree/owner 58869 → Procmon → snapshot chuyển spectator → module diff → handle inventory → network/IPC → quan sát schema WebSocket. Static analysis chỉ bắt đầu sau đó bằng DIE/PE-bear, ILSpy/dnSpyEx cho .NET và Ghidra cho native. Ranh giới: GREEN quan sát thụ động; YELLOW phân tích file trên đĩa; RED không injection, patch, memory read/write, IPC impersonation hoặc anti-cheat bypass.

### Cập nhật bằng chứng công khai ngày 25/09/2026

Overwolf LoL GEP hiện tài liệu hóa `live_client_data.all_players` (roster, cấp, KDA, CS, item, rune, spell, chết/hồi sinh) và các event kill/death/respawn. Đây phần lớn là dữ liệu Live Client được chuyển tiếp. GEP cũng có `gold` với `gold`/`total_gold`, nhưng tài liệu không xác định scope hoặc xác nhận đủ 10 người trong spectator. `team_frames_0..3` có `ult_cd`, song chỉ mô tả timer ultimate ở một số vị trí scoreboard; chưa rõ scope hai đội và spectator. Không coi những field này là full-roster telemetry trước khi có phép thử và dữ liệu đo thực tế.

LiveEvents không được Riot công bố như API được hỗ trợ. Tài liệu cộng đồng ghi spectator/replay và event objectives, đồng thời cảnh báo có thể đã bị vô hiệu từ patch 14.1 và cần sửa config. Không tích hợp hoặc thay đổi cấu hình dựa trên nguồn này.

Tham khảo trực tiếp: [Riot Live Client Data API](https://developer.riotgames.com/docs/lol), [Overwolf LoL GEP](https://dev.overwolf.com/ow-native/live-game-data-gep/supported-games/league-of-legends/), [Overwolf GEP model](https://dev.overwolf.com/ow-native/live-game-data-gep/live-game-data-gep-intro/), [LiveEvents community repository](https://github.com/SkinSpotlights/LiveEventsDocumentation). GEP không công bố cadence/timestamp đủ để kết luận frame accuracy; thử nghiệm phải giữ provenance, đo jitter/staleness, và tôn trọng trạng thái feature.

Thiết kế đồng bộ snapshot, event và presentation clock nằm tại `FRAME_ACCURATE_STATE.md`.

## Có thể tái tạo phần nào của LeagueBroadcast

Có thể tái tạo lớp giao tiếp và xử lý dữ liệu bằng các giao diện được công bố:

1. Kết nối Live Client Data và Replay API ở loopback.
2. Nhận WebSocket LeagueBroadcast theo contract client công khai khi tài khoản có quyền.
3. Đọc ảnh từ source OBS bằng request `GetSourceScreenshot`.
4. Cắt các vùng cố định theo profile HUD, nhận dạng số và icon, trả kèm confidence và thời điểm quan sát.
5. Chuẩn hóa mọi field về cùng contract, không ghi đè field Riot bằng kết quả OCR có confidence thấp.

Không thể kết luận bộ collector nội bộ của LeagueBroadcast chỉ dựa trên client JavaScript công khai. Package `@bluebottle_gg/league-broadcast-client` là wrapper cho WebSocket, không chứa cơ chế lấy telemetry từ game.

## Mẫu custom tournament đã xác minh

Ngày 20/09/2026, LeagueBroadcast 1.13.3 nhận một custom tournament spectator trên Summoner's Rift và chuyển `Loading` sang `Running`. Telemetry báo `good` ở khoảng 2 update/giây, asset 16.18 hoàn tất 100% và WebSocket phát đủ 10 người. Log ứng dụng xác nhận game library kết nối thành công và feature được cấp.

Adapter đã đọc được 10/10 champion, level, KDA, CS, total gold, HP, spells, keystone, inventory và vision. Resource đạt 9/10 vì một champion không có resource bar (`max = 0`), được giữ missing theo schema thay vì tạo thanh 0/0. Payload còn có team gold/kills/towers/dragons/grubs, Baron/Dragon pit timer, inhibitors và ability cooldown nhưng các nhóm này chưa được đưa vào normalized contract.

## Thiết kế capture và OCR

Mỗi profile gắn với độ phân giải, patch HUD và loại giải. Với ảnh `ingame.png` 1920×1080, bước đầu chỉ đọc các vùng scoreboard trên cùng và bảng thông tin dưới cùng. Mỗi kết quả cần có:

- `value`: số đã nhận dạng hoặc `null`.
- `confidence`: 0 đến 1.
- `capturedAt`: thời điểm ảnh được lấy.
- `region`: tên vùng và tọa độ theo canvas nguồn.
- `profile`: phiên bản layout.

Giá trị dưới ngưỡng confidence phải giữ `null`. Khi HUD bị ẩn, chuyển cảnh, thay độ phân giải hoặc ảnh quá cũ, adapter phải bỏ toàn bộ kết quả OCR. Tổng gold đội có thể dùng cho scoreboard; không được chia ngược thành gold từng người.

OBS Studio 28 trở lên đã kèm obs-websocket. Kết nối nên giới hạn ở `127.0.0.1`, bật mật khẩu và chỉ yêu cầu ảnh của source game đã chọn. Ứng dụng không cần điều khiển game hoặc đọc tiến trình game.

## Ranh giới reverse engineering

Cho phép trong project:

- Đọc Swagger, tài liệu, SDK và source client được công khai.
- Quan sát request/response của chính ứng dụng trên localhost khi điều khoản cho phép.
- So sánh schema, trạng thái phiên và timing để xây adapter tương thích.
- Phân tích ảnh mà observer/OBS đã hiển thị.

Không triển khai:

- Đọc memory của League of Legends hoặc LeagueBroadcast.
- DLL injection, process hook, kernel driver hay né Vanguard.
- Patch game/client hoặc giả mạo môi trường tournament.
- Giải mã packet replay, file ROFL hoặc giao thức riêng nếu chưa có quyền rõ ràng từ Riot.
- Decompile để sao chép cơ chế collector độc quyền.

Riot nêu rằng API, game client/in-game API và spectator/replay services vẫn được kỳ vọng hoạt động với Vanguard, còn external memory reading sẽ không hoạt động và không có allowlist. Vì LCU và in-game API không được Developer Relations bảo đảm ổn định, adapter phải có version check, timeout và trạng thái unavailable.

## Nguồn tham khảo chính

- Riot Live Client Data API: https://developer.riotgames.com/docs/lol
- Riot Developer FAQ, mục Vanguard: https://developer.riotgames.com/docs/faqs
- Overwolf LoL Game Events: https://dev.overwolf.com/ow-native/live-game-data-gep/supported-games/league-of-legends/
- OBS WebSocket protocol: https://github.com/obsproject/obs-websocket/blob/master/docs/generated/protocol.md
- LeagueBroadcast JS client: https://github.com/BlueBottleGG/leaguebroadcast-js-client
- LeagueBroadcast tournament guide: https://leaguebroadcast.gg/guides/tournament-broadcast

Các link trên mô tả khả năng kỹ thuật, không tự cấp quyền thương mại hoặc phê duyệt sản phẩm. Trước khi phát hành công khai, cần đăng ký sản phẩm với Riot và hoàn tất quy trình của nền tảng tương ứng.
