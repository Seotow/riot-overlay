# Bàn giao collector không đăng nhập sang chat UI — 16/10/2026

Workspace dùng chung: `D:\Workspace\RiotAPI\riot-overlay`.
Chat tiếp tục: **UI**, ID `01a1210f-1dc5-7a00-b2b9-89e49d9610e0`.

## Quyết định của người dùng

Người dùng chấp nhận kết quả hiện tại làm baseline đạt yêu cầu để chuyển sang
test toàn diện UI, ghi một trận và đối chiếu rồi sửa tiếp. Ưu tiên collector
DLL cache không tài khoản, không mở LB gốc. Người dùng xác nhận dữ liệu
gameplay/overlay không cần ẩn; giữ tên người chơi, game ID/network ID và toàn bộ
field native để điều tra. Chỉ lọc thông tin xác thực LB; không ghi credentials LCU.
Không biến quyết định nghiệm thu baseline thành tuyên bố full telemetry/parity
đã đo: các điểm thiếu phía dưới là đầu việc cụ thể cho test UI tiếp theo.

## Kết quả chuyển giao

- Host .NET + DLL cache gốc chạy không GUI LB. Hash native
  `a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3`.
- `collector-accountless` quản lý owned host18799; môi trường con không account,
  không đọc file env thật. Auth not-configured/feature0/signingAttempts0/signed0.
  Giữ feature/version/spectator guard; không tải mới hoặc patch DLL.
- SR map11 coldstart không producer trước test104/104 valid; reconnect qua app
  432/432 valid45s,10hero; HP/resource/currentGold/totalGold10/10. Biến thiên9/8/10/10.
  Studio/OBS53 sample giống nhau. Kiểm browser thật1920×1080/OBSalpha đạt.
- Yasuo là người chơi,9 slot bot theo user. Mẫu pause621.7712s level10/KDA6/4/0,
  HP1495.4379/1583.4,wind341.2647/341.2647, currentGold2066.4946,totalGold6566.506.
  User sửa báo nhầm HP và xác nhận số đúng; resource HUD341/341. Gold chưa HUDcheck.
- Event ChampionKill thật đi qua native→adapter→Studio/OBS, timestamp gần Riot.
  Các audit chi tiết ở `Collector/evidence/validation/accountless-full-*.json`.
- Rồng Hóa Kỹ bị Yasuo/teamORDER hạ950.9522s qua native DeathEvent nối chính
  unit đã quan sát trước đó. HP5790.625→0. User xác nhận HUD xanh1/đỏ0.
  Riot2999 bỏ sót DragonKill; không dùng Riot làm nguồn chuẩn đầy đủ cho objectives.

## Những gì UI cần tiếp tục sửa/đo

1. DragonKill/counter rồng: native đã có proof, adapter hiện chưa map nên app
   dragons vẫnnull. DeathEvent cần join minion/object context an toàn; không
   suy kill từ việc unit biến mất hoặc suy lịch sử đầy đủ từ recent events.
2. CS candidate92 vs Riot90 cùng clock, tiếp tụcnull. Không bật lại chỉ để đủ UI.
3. TurretKilled có trong Riot nhưng thiếu counterpart normalize ở một window;
   cần kiểm source vector/context. Inhibitor/Ace/Baron/Elder/full endgame chưa đo.
4. Cooldown/perks/buffs/death/respawn/quest/XP còn các mức schema/source-only;
   field nào chưa support giữnull/capability. Resource Yasuo làwind, không mana.
5. Hai Kog'Maw cùng đội làm comparator team/champion chỉ ghép chắc8 cặp.
   VisionScore sai khácfloat nhỏ:8/8 epsilon0.0001,maxdelta4.61e-8,không exact cả8.
6. Collector ChampionKill hiện cóplayerSlot nhưng thiếukillerSlot/victimSlot ở
   adapter output: kiểm mapping để killfeed icon có actor chính xác; không đoán.
7. Validator `collector:validate` cũ chỉ nhận league-collector có account/roster
   unique. Chưa dùng nó để tuyên bố mode mới đạt. Phòng thử mock không là liveproof.

Không chạy lại audit live ở chat nguồn; user đã tạm dừng điều tra và chuyển
việc test/sửa sangUI. Không tự reset theme, đè UI baseline hoặc mở game/seek.

## Cách chạy và ghi một trận

Build trước. Chỉ chạy một backend sở hữu collector; nếu4310 đã có backend cũ,
dừng terminal cũ rồi khởi động bản mới. Không dừng game chỉ để restart backend.
Terminal1 tại root:

```powershell
npm run build
npm run start:collector:no-auth
```

Mở `http://127.0.0.1:4310/?page=sources`. Nguồn tự chọn **Collector không tài
khoản LB**, demo tắt. Process phải running; có game hợp lệ mới receiving/10hero.
Nếu đặt `RIOT_OVERLAY_COLLECTOR_EXTERNAL=1`, bỏ biến đó trong terminal rồi chạy
lại; mode này cần host do app quản lý. Không cần xóa file tài khoản LB.

Terminal2, bắt đầu ghi trước loading/trước đoạn cần kiểm tra:

```powershell
npm run capture:collector -- 10800000
```

3giờ là ngân sách ghi tối đa phiên, không phải phải chờ đủ3giờ. Recorder chỉ
attach/read, không mở game, đổi source hoặc dùng credentials. Tạo thư mục mới
`data/captures/<UTC timestamp>/`, in đường dẫn ngay khi bắt đầu. Tự reconnect;
provider/demo/auth đổi thì dừng. Ghi từ giữa trận không phục hồi được đầu trận.
Chờ hết trận thêm15s rồi dừng sạch từ terminal3:

```powershell
npm run capture:collector:stop
```

Chờ terminal2 in `state: stopped`. Ctrl+C cũng yêu cầu flush; lệnh stop tránh
phụ thuộc cách terminal Windows chuyển Ctrl+C. Không đóng cưỡng bức terminal
trước khi gzip/manifest ghi xong. Lệnh stop chỉ dừng recorder, giữ game/app.
Đánh dấu sự cố hoặc sự kiện trong lúc ghi:

```powershell
npm run capture:collector:mark -- "15:50 Yasuo an rong Hoa Ky, xanh 1 do 0"
```

Marker lưu cả clock app tại lúc bấm và ghi chú; thời điểm user đọc ghi trong
note để phân biệt với độ trễ operator. Không dùng `capture:lb`/`capture:mark`
cũ cho mode mới vì các lệnh đó trỏ feed/pointer LB58869.

## File dùng đối chiếu và phát lại

| File | Mục đích |
| --- | --- |
| collector-native.ndjson.gz | Mọi snapshot/status native nhận được, fullschema giữ names/IDs, lọc auth, nén gzip; dùng sửa adapter/event sau này |
| observer-samples.ndjson | Sample app và queued event đã giao cho renderer, dùng playback UI |
| riot-reference.ndjson.gz | Riot allgamedata đầy đủ đã lọc auth kèm projection để đối chiếu; mục tiêu500ms không thay mọi native event |
| manifest.json | Counts,first/lastclock,connection/disconnect,sequenceGaps,invalidMessages,stopReason; checkpoint trong phiên |
| markers.ndjson | Mốc do operator ghi, chỉ có khi đánh dấu |

Native được ghi theo từng message, không polling snapshot cuối; backpressure
WS khi nén/đĩa chậm. Archive giữ các field chưa map để UI có thể sửa sau trận.
Không có dữ liệu ở nguồn thì không tạo dữ liệu thay thế. Manifest luôn giữ
fullMatchVerified/fullTelemetryVerified=false cho tới khi người kiểm tra thực
sự đối chiếu coverage toàn trận; việc có file không chứng minh không mất đoạn.
Nếu process/đĩa lỗi hoặc bịkill, gzip đang ghi có thể chưa flush; giữ file để
phục hồi, không gọi đó là capture hoàn chỉnh. Dữ liệu ởdata/không theoGit.

Sau ghi, chạy backend bản mới, vào **Phòng thử** hoặc **Bản ghi offline**,
Refresh/danh sách→chọn timestamp capture→tải→play/seek. Reader đã hỗ trợ file
observer-samples của collector; archive native dùng offlineanalysis riêng,
không phát raw payload vào widget. Reader giới hạn512MB/30.000 sample collector (LB cũ10.000);
bản ghi dài vẫn được giữ đủ trênđĩa nhưng cần chia/index nếu vượt reader limit.
Giữ biểu thị dữ liệu lịch sử; preview giả lập không là event thật.

Kiểm ít nhất: HUD Yasuo/đủ10player, HP/resource/gold, items/spells/perks/cooldown,
killfeed, rồng/trụ/nhà lính, pause/seek/reconnect/mất nguồn, Studio↔OBS và alpha.
User sẽ hỗ trợ thao tác game từng bước và báo hoàn thành; chưa tự nhận game sẵn.

## Kiểm chứng công cụ mới

Unit privacy/playback2ca đạt. Fixture integration recorder đạt native/fullRiot/
app, giữ names/IDs, lọc authsentinel, gzipflush,marker,operatorstop và playback.
Lượt smoke thật5s đầu khi APIgame không còn dữ liệu có0snapshot; không gọi
lượt này là record trận. Chưa thu một trận đầy đủ bằng recorder mới.
Các lệnh regression: `npm test`, `npm run test:collector-capture`,
`npm run test:collector` (kèm transport), `npm run build`.

Tài liệu nguồn: PROJECT_STATUS.md, TEST_REPORT.md,
Collector/docs/ACCOUNTLESS-VERIFICATION.vi.md, BASIC-FIELDS.vi.md,
PROJECT-RUNBOOK.vi.md, FIELD-MATRIX.vi.md, NATIVE-EVENTS.vi.md.
