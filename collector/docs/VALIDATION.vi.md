# Kiểm tra gói Collector trên replay thật — 14/10/2026

## Kết luận hiện tại

**Build/doctor/self-test đạt; đã thử một lần nạp DLL, chưa nhận được dữ liệu native.**
Trial đầu bắt đầu sau timestamp GameEnd. Chưa xác minh đầy đủ LB Free hoặc xác thực native và chưa
thay provider production của overlay. Replay hiện hành báo map 12, không map
11 Summoner's Rift; không dùng phiên này để tuyên bố độ phủ giải đấu SR.

## Checkpoint lifecycle và lưu bằng chứng — 14/10/2026, 13:32Z

Đã dùng skill REA để giữ ranh giới artifact/runtime và review độc lập; không có
REA provider trong phiên nên các kết quả này là bằng chứng công cụ thông thường.
Chỉ sửa source copy validation, không đổi ZIP/DLL native hoặc app production.

- Build offline, doctor, serializer và lifecycle lab đạt; lab hiện đã đo 14/14
  ca trong `../evidence/validation/managed-lab-2026-10-14T13-25-57-972Z-88ef0d0d0b1e4dfabb41e2e8f0629ede/`.
  Có hash host/Farsight/native/ZIP và log đầy đủ trong summary/các file cùng thư mục.
  Lab không truy cập game, không chứng minh telemetry hoặc quyền native.
- Sửa propagation cancellation tới connect/spectator request, gate khởi tạo
  theo generation, tạo message queue trước khi công bố worker ID, thu hồi
  hook/own process watch và chờ disconnect/task/thread. Không gửi native Quit.
  Giới hạn 2 giây áp dụng await/join, không bao trùm cleanup đồng bộ; watchdog
  ngoài tiến trình vẫn cần. Không gọi đây là root cause duy nhất của hang cũ.
- Kiểm chứng no-inject sau bản 14-ca: khoảng 31 giây, exit 0, không cưỡng chế,
  31 poll, 0 native frame/hero; source vẫn waiting.
  Evidence: `../evidence/validation/no-inject-2026-10-14T13-30-10.763Z.json`.
- Passive IPC: expected pipe absent với reported error 2, TCP4998 không bound
  tới game tại thời điểm probe; không connect/request/load DLL/inject.
  Evidence: `../evidence/validation/ipc-2026-10-14T13-14-47-995Z-52378e7e5dc248b2ac3f3ad1faecd4e3.json`.
  Đây không phải bằng chứng DLL chưa từng load hoặc bị anti-cheat chặn.
- Review tiếp phát hiện startup trùng và process-watch cleanup; đã sửa
  single-startup claim mỗi lease và invalidate khi window đóng. Build/doctor/
  serializer đạt, lifecycle **16/16** trong
  `../evidence/validation/managed-lab-2026-10-14T13-32-17-490Z-ef80476171a84b7dadc0e18f5783a601/`.
  Review lưu ở `LIFECYCLE_REVIEW.vi.md`; không tự re-arm trial sau lỗi.
  No-inject bản cuối cũng đạt: 31 poll, 0 frame/hero, exit0, không cưỡng chế;
  `../evidence/validation/no-inject-2026-10-14T13-33-11.501Z.json`.
  Postcheck đúng host/validation flag còn 0 process, lưu
  `../evidence/validation/lifecycle-final-postcheck-20261014.json`.
- Người dùng đã đồng ý **một trial mới** trên replay mới, chưa báo sẵn sàng.
  GET lúc 13:31:58Z vẫn clock1234.220/map12/GameEnd1228.122 của replay cũ.
  Chưa dùng consent mới, marker trial cũ giữ nguyên. Trial tiếp phải kiểm tra
  replay thật sự mới/còn chạy trước GameEnd, giữ nguyên DLL/guard/quyền.

`build-validate.ps1` lưu cả log thành công/thất bại; `inspect-replay.mjs` và
`inspect-ipc.ps1` tự lưu mỗi kết quả metadata vào `../evidence/validation/`.
Không chạy integration.py nguyên gốc trên Windows vì có nhánh auto-inject
và giả định lifecycle Unix. Không lưu credentials/raw player stats/address.

## Artifact đã kiểm tra

- Gói người dùng cung cấp: `LeagueCollector-source.zip`, SHA256
  `59370210865bc39b291ab93fa8bccac741594233e11e520536e572603efef264`.
- Inventory bằng công cụ filesystem thông thường: 1543 entry, 37,551,636 byte
  giải nén; đã kiểm tra mọi resolved path nằm trong đích và không ghi đè.
  Bản ZIP không đổi. Source copy ở `../archive/legacy-src/LeagueCollector` (bản sao cũ, đã lưu trữ).
- Native vẫn là DLL gốc LB, SHA256
  `a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3`.
  Các file C++ trong archive là pseudocode chọn lọc, không engine native build lại.
- Managed host/Farsight được build từ source phục hồi bằng SDK 10.0.401 có sẵn,
  restore dùng NuGet config nguồn rỗng của workspace. Không tải SDK/package mới.
  Build exit 0/error 0; còn nhiều warning ở source decompiled/reference.
  Số dòng warning console không phải số warning duy nhất.
- Doctor: Windows x64, DLL hiện diện/PE hợp lệ; `gameTested=false` vẫn đúng cho
  doctor. Self-test đạt 8 nhóm serializer/fixtures/parser, không native game proof.

Đã đọc skill REA và hướng dẫn artifact/runtime boundary. Phiên này không có
REA MCP tools hoặc CLI hiện diện trên PATH; tiếp tục bằng source/file/runtime
tools thường, không cài hoặc sửa đăng ký. Các hash/kết quả dưới đây không được
gọi là REA Evidence. Tài liệu kèm archive là nguồn tham khảo, không tự cấp
quyền thực thi mọi lệnh/injection/download được mô tả bên trong.

## Trial một lần nạp DLL — đã có consent, không lặp

Người dùng đã đồng ý riêng và approve execution ngoài sandbox. Supervisor
kiểm tra replay HTTP200/paused=false và activeplayername thuộc Unknown/Spectator
trước khi bắt đầu; không chạy trên client player. Native giữ nguyên hash, không
login/LCU/update/record. Program.cs validation copy chỉ thêm event metadata,
chặn window attempt thứ hai và dừng khi InjectionFailed/GameEnded; không đổi
LibInjector, Farsight transport/auth/feature/version hoặc DLL.

Bằng chứng:
[validation-results/single-inject-2026-10-14T12-35-43.585Z.json](../evidence/validation/single-inject-2026-10-14T12-35-43.585Z.json).

- GameVersion thực nhận `16.20.824.8524`; nằm trong khoảng sidecar DLL nhưng
  điều này không chứng minh ABI/offset/replay compatibility.
- Một event game-window, một `inject-reported`; không event `game-started`,
  không frame hoặc hero. `Injected` ở managed phát sau lời gọi injector, trước
  connect/handshake; không phải bằng chứng DLL initialized hoặc producer ready.
- TCP4998 trước/sau closed, LB58869 trước closed. 35polls:26status200/snapshot204/
  waiting/authnot-configured,8unavailable và1snapshot204/statusunavailable.
- Host không dừng sạch ở mốc30s; watchdog yêu cầu terminate đúng child tại45s.
  `forcedOwnedStop=true`, `gracefulExit=false`, exitCode=null. Kiểm tra Windows
  độc lập sau đó xác nhận 0 process khớp exact DLL/validation flags. Không gửi
  Quit/unload tới native game, không đóng game/LB hoặc terminate process khác.
- Replay trước1229.523s; sau1234.220s, HTTP200/paused=false. GETeventdata sau test
  thấy `GameEnd` ở1228.122s (20:28), **nhỏ hơn clock lúc bắt đầu trial**.
  Như vậy không dùng trial này để kết luận thu được/không thu được dữ liệu
  trong trận đang diễn ra; không tự quy việc clock đứng ở cuối trận cho DLL.

Host SHA256 của trial `977e9a24e7f610e3bffba02eb03b50143efb0653fc9a504d1638df33b441125c`;
Farsight/native hash vẫn như phiên no-inject đầu. One-shot marker
`../evidence/validation/single-inject-attempt-20261014.json` giữ nguyên để ngăn
rerun; không xóa hoặc bỏ guard nhằm dùng lại consent một lần.

### Tua replay và kiểm tra lại không nạp DLL

Clock được quan sát đứng1234.220s ở cả Playback/gamestats, paused=false và có
GameEnd. Theo yêu cầu người dùng, 12:42:19Z xác nhận clock lần nữa sau5s rồi
POSTplayback một lần về1114.220s (lùi120s), paused=false/speed1; HTTP200.
Không dùng LCU, không sửa config, không gọi injection thứ hai.

Phiên chỉ-connect sau POST:
[validation-results/no-inject-2026-10-14T12-43-26.566Z.json](../evidence/validation/no-inject-2026-10-14T12-43-26.566Z.json),
31polls/30status200-snapshot204/waiting/authnot-configured,0frame, TCP4998closed;
host dừng sạch exit0. Đây là cùng process replay sau trial trước, không một
phép thử độc lập từ client mới. GET12:45:47Z lại thấy clock1234.220s/GameEnd;
không có chuỗi clock ngay sau POST để xác minh đầy đủ hành vi seek/resume.
Không suy HTTP200 của POST tự chứng minh native reconnect hoặc game telemetry.

### Vấn đề lifecycle và bước tiếp

SourceWorker.Native đang await StartWatchingForGameStart trước polling/capture
task. Nhánh injection await Socket.Connect; Connect có thể chờ server trong
loop dùng CTS riêng, trong khi StopWatchingForGameStart nằm ở finally của
Native. **Suy luận tĩnh:** cancellation host có thể không tới loop connect
kịp thời, phù hợp host không dừng sạch đã quan sát. Chưa có trace đầy đủ để
khẳng định đây là nguyên nhân duy nhất; chưa sửa core/source này hoặc chạy
trial injection thêm để chứng minh fix.

Bước hợp lý trước trial mới: sửa/kiểm chứng cancellation và stage diagnostics
trong host validation, không thay auth/native gates; sau đó cần replay mới
(ưu tiên map11/SR) và consent mới, khởi chạy test sớm trước GameEnd. Với các
frame thực trả mới đánh giá roster, field có giá trị hữu ích và độ bền phiên.
Hiện còn chưa qua native ready/handshake, không đủ bằng chứng lỗi quyền Free,
Develop hoặc Vanguard. Không hứa 95–98%/full replacement từ kết quả này.

## Kiểm tra thực tế

Preflight sau khi được phép ra ngoài sandbox: 12:20:09Z (19:20:09 Bangkok),
Replay API HTTP 200, clock 294.979s, paused=false, speed=1, seeking=false;
gamestats HTTP 200, mapNumber=12. Lần GET trong sandbox trước đó báo EACCES:
đây là giới hạn sandbox, không phải lỗi game/provider.

Chạy `validate-no-inject.mjs` ngoài sandbox sau approval, từ 12:24:14.774Z
đến 12:24:48.155Z, với `--source lblib --no-inject --no-lcu`, port 18803,
không account env/credential file, không record raw frames. Bằng chứng:
[validation-results/no-inject-2026-10-14T12-24-14.774Z.json](../evidence/validation/no-inject-2026-10-14T12-24-14.774Z.json).

- 33 lần polling; 29 mẫu có `/api/status` HTTP 200, `/api/snapshot` HTTP 204,
  state=waiting, authentication=not-configured; 4 mẫu lúc startup chưa kết nối.
- 0 native frame, 0 hero, không HP/gold/cooldown mới; không đánh đồng health
  của host hoặc schema đầy đủ với dữ liệu game thật.
- TCP 4998 không mở trước/sau test; cổng LB feed 58869 không mở lúc bắt đầu.
  Không kiểm tra toàn bộ named-pipe/server state hoặc lịch sử DLL trong game;
  không dùng một port closed để khẳng định DLL chưa từng được tải.
- Host tự dừng, exit 0; không forced stop, không đóng game/LB, không gửi native
  Quit, không thay auth/feature/signature/version/spectator guard.
- Postcheck 12:27:06Z: replay vẫn HTTP 200, clock 712.310s, paused=false,
  speed=1. Không cần tua trong phiên này, không có POST playback hoặc LCU calls.

Host đã thử SHA256 `73b5062f4893ef52a77e18a2237417d533fcf7bc402a7786b37f009928628cc1`;
Farsight build SHA256 `a2de674e7f133a886435bdb3b32a6f2607a0c6fec6487c8b14b93e6b9871ca1a`.
Chỉ sửa lifecycle ở Program.cs trong source copy: flag validation ép no-inject,
no-LCU/no-update/no-auth-check/no-record và tự StopApplication sau 30 giây.
DLL native/bản ZIP nguyên gốc không đổi; các file host/auth/Farsight khác không
được patch để nâng quyền. Diff này không được áp dụng vào app production.

## Điều còn cần chứng minh

Trong source, AutoInject mặc định true, dùng cơ chế Windows hook của gói để
nạp lblib vào cửa sổ game sau kiểm tra spectator/version. Đây khác probe đọc
header 64 byte trước đó và có thể khiến client dừng. Consent riêng đã được
dùng cho đúng một trial ở trên; không tự chạy default hoặc trial mới.

Không nhận frame ở no-inject không chứng minh replay không được hỗ trợ,
Free bị từ chối hoặc cần Develop: chưa có native handshake/snapshot thành công.
`FeatureSet.Empty` được managed client chấp nhận không phải native grant hoặc
LB Free được xác thực. Nếu có frame ở lần thử sau, numeric/schema presence
vẫn chưa chứng minh field hữu ích; zero/empty có thể do native lọc quyền.

Đối với trial mới nếu người dùng đồng ý riêng: giữ nguyên DLL/hash và
mọi guard, không download/update tự động, không bypass; phân biệt khởi tạo,
handshake, service registration, frame thật và coverage/giá trị. Dừng khi lỗi,
không thử đường vòng, không tự đọc dump/offset hoặc giả quyền. Nếu cần tài
khoản, người dùng cấu hình cục bộ theo đường auth hợp lệ; không đưa secrets
vào chat/log/report/source và không suy Free từ lookup 404.

## Replay bị dừng

[Riot Replay API](https://developer.riotgames.com/docs/lol#replay-api) tài liệu
hóa GET/POST `/replay/playback` ở cổng 2999 để đọc/chỉnh pause/time. Đây khác LCU.
`inspect-replay.mjs` mặc định chỉ GET trạng thái/end event đã lọc. Optional
`--resume-if-paused` chỉ khi GET xác nhận paused=true; `--resume-if-stopped`
còn xác nhận hai clock giống nhau sau5s trước tua lùi tối đa120s một lần,
resume1×. Mode stopped đã chạy đúng một lần như trên. Không tự sửa game.cfg,
khởi động client hoặc dùng endpoint LCU phỏng đoán nếu Replay API mất.

Không raw stats/player identity/memory address/credential được ghi trong
evidence. Không đổi Studio/OBS/UI/theme/autostart, không chạy app tests vì app
source không thay; không commit/push hoặc shutdown PC.
