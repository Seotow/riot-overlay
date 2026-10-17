# Điều tra module Valorant / ValoSpectra

Cập nhật triển khai 13/10/2026: đã fork local source và có runtime/lifecycle độc lập, xem [runbook](VALORANT_MODULE.md) và `modules/valorant/MODIFICATIONS.md`. Chưa chạy collector thật hoặc xác minh telemetry game. Các phân tích/kế hoạch dưới đây là mốc nghiên cứu 11/10, được giữ để truy nguồn.

## Mục tiêu được làm rõ — 11/10/2026

Người dùng muốn **tích hợp stack vào project**, gồm collector khởi động cùng ứng dụng và fork/custom BE, FE ValoSpectra. Không chỉ nhận output của một stack ValoSpectra do người dùng vận hành riêng để xây UI mới. Không yêu cầu viết collector từ đầu; có thể tái sử dụng công cụ đang có. Phần kết luận và kế hoạch dưới đây đã đổi theo mục tiêu này.

## Kết luận

ValoSpectra là ứng viên provider cho module Valorant bên cạnh LoL. Luồng được source xác nhận: **Valorant → Overwolf GEP → Spectra Client → Spectra Server → Socket.IO output → frontend**. Collector phụ thuộc GEP; server dựng state từ các update/event, không phải nguồn tự đọc game độc lập. Chưa xác định cơ chế bên trong GEP thu từng field.

Đích tích hợp là fork/pin stack vào workspace, quản lý lifecycle collector và BE/FE bằng launcher của project, rồi custom module Valorant. Output Spectra Server là đường nối nội bộ hữu ích cho giai đoạn đầu, không phải sản phẩm cuối chỉ dùng feed của ứng dụng ngoài. Chưa có bằng chứng một observer cung cấp HP/ability trực tiếp cho đủ 10 người. Không dùng snapshot Spectra nguyên trạng làm contract widget vì có giá trị mặc định, fallback và dữ liệu suy ra.

## Bằng chứng và phiên bản

Đọc source `main` ngày 11/10/2026, ghi lại commit từ GitHub API:

| Project | Commit | Vai trò |
| --- | --- | --- |
| Spectra-Client | `a07fd0853129a549ac4d657544ae1e0b93e4f5e8` | Electron / Overwolf GEP; package version 0.3.3 |
| Spectra-Server | `64782ac2dcd5863aa179a084c8f402c3be794ebe` | Nhận update, dựng state và phát output |
| Spectra-Frontend | `1e81de161c35d4b6f5e4fb6056c6db100734bf96` | Renderer tham khảo; chưa audit đầy đủ source frontend |

Các file nghiên cứu lưu trong `.research/valospectra/`, đã bị Git ignore. Chưa đối chiếu commit với image Docker hoặc binary client người dùng đang chạy. Source công khai không tự chứng minh compatibility trên patch hiện tại.

Người dùng xác nhận chạy local qua ba project. Kiểm tra trên máy thấy:

- `../spectra/spectra-server/docker-compose.yml`: image `ghcr.io/valospectra/server`, port mapping 5100, 5101, 5200.
- `../spectra/spectra-frontend/docker-compose.yml`: image `ghcr.io/valospectra/overlay:latest`, port mapping 3000 → 80.
- Cấu hình frontend trỏ `http://localhost:5200`.
- Chưa thấy checkout Client hoặc source Server trong thư mục này. Lần kiểm tra không trả listener trên các cổng trên; `docker` không có trong PATH của phiên shell. Đây là quan sát tại thời điểm kiểm tra, không kết luận Docker chưa được cài hoặc setup không hoạt động.

Không đọc nội dung `.env`, private key hoặc log có credentials. Không chạy, restart hay thay cấu hình ứng dụng.

## Collector và giao thức

[GEP service của Client](https://github.com/ValoSpectra/Spectra-Client/blob/a07fd0853129a549ac4d657544ae1e0b93e4f5e8/src/services/gepService.ts) đăng ký game ID 21640, yêu cầu `match_info`, `me`, `game_info`, nhận `new-info-update` và `new-game-event`. Có mode observer và auxiliary; observer không gửi HP/abilities qua nhánh xử lý thông thường, auxiliary gửi dữ liệu của player tương ứng. Nhận event không đồng nghĩa field luôn có trong mọi chế độ.

[Ingest server](https://github.com/ValoSpectra/Spectra-Server/blob/64782ac2dcd5863aa179a084c8f402c3be794ebe/src/connector/websocketIncoming.ts) dùng Socket.IO port 5100, auth qua `obs_logon`/`obs_logon_ack`, nhận `obs_data`; auxiliary có `aux_logon` và `aux_data`. Đây là đường collector, không cần tái triển khai để nhận output. Port 5101 có trong compose nhưng chưa audit giao thức, không mặc định dùng nó.

[Output server](https://github.com/ValoSpectra/Spectra-Server/blob/64782ac2dcd5863aa179a084c8f402c3be794ebe/src/connector/websocketOutgoing.ts) dùng Socket.IO port 5200. Consumer emit `logon` với chuỗi JSON chứa `groupCode`, nhận `logon_success`, sau đó `match_data` là chuỗi JSON. Có snapshot khi logon; TLS/HTTP tùy cấu hình server. Không dùng client WebSocket thuần như adapter LeagueBroadcast.

[MatchController](https://github.com/ValoSpectra/Spectra-Server/blob/64782ac2dcd5863aa179a084c8f402c3be794ebe/src/controller/MatchController.ts) kiểm tra gửi mỗi 100 ms, chỉ phát khi `eventNumber` tăng. Timestamp ingest được gán `Date.now()` tại server. Do đó 100 ms là nhịp kiểm tra output, không chứng minh tốc độ lấy game hoặc độ trễ end-to-end. Không có frame mới cũng chưa chắc nguồn đã chết; freshness cần kiểm chứng theo phase và từng nhóm field.

## Ma trận dữ liệu ứng viên

“Source xác nhận” dưới đây chỉ nói đường code tồn tại. Tất cả độ phủ live trên máy người dùng vẫn **chưa kiểm chứng**.

| Nhóm | Đường dữ liệu / cách hình thành | Hạn chế cho adapter |
| --- | --- | --- |
| Roster, agent, lock, map | GEP → Client → Server | Kiểm tra đủ 10 slot; map/token không biết phải giữ unknown |
| KDA, alive, credits | Scoreboard; server có fallback từ killfeed | Tách observed và derived; chưa mặc định 10/10 hoặc cập nhật liên tục |
| Weapon, armor, spike carrier, ultimate points | Scoreboard | Weapon là primary/loadout; armor là loại giáp, không phải HP giáp hiện tại |
| Killfeed / headshot / weapon gây kill | GEP kill feed; server tích lũy | Kiểm tra duplicate, resurrection và event rơi; không đồng nhất killfeed với mọi combat event |
| HP và ability | Auxiliary player feed | Chỉ xuất value khi capability và freshness hợp lệ; chưa xác nhận một observer đủ 10 người |
| Round, phase, score, side | GEP và logic side-switch server | Đội ổn định phải tách attack/defense thay đổi theo round |
| Round timer, spike countdown | Timestamp server + thời lượng code | Đánh dấu derived; kiểm chứng pause, delay, reconnect |
| Plant / defuse / detonate | Event; plant còn có heuristic và hotkey | Không coi plant luôn là event trực tiếp |
| Timeout, tech pause, branding/series | Operator/config | Tách manual/config khỏi telemetry game |
| Economy, moneySpent, headshot ratio, round reason | Tính từ update/history | Không cam kết chính xác nếu bỏ lỡ đầu trận hoặc update |

[Overwolf Valorant docs](https://dev.overwolf.com/ow-native/live-game-data-gep/supported-games/valorant/) mô tả scoreboard gồm KDA/money/alive/ult; weapon, shield và spike có giới hạn teammate/local trong tài liệu. HP/abilities thuộc `me`, `observing` dành custom. `match_end` được ghi không hoạt động cho custom/training. Cần kiểm chứng hành vi observer riêng, không suy rộng từ mode player.

### Giá trị dễ bị hiểu sai

[Player model](https://github.com/ValoSpectra/Spectra-Server/blob/64782ac2dcd5863aa179a084c8f402c3be794ebe/src/model/Player.ts) khởi tạo HP 100, abilities 0 và thống kê 0; có `scoreboardAvailable` và `auxiliaryAvailable`. Reset round đưa HP về 100; HP chết/hồi sinh có thể từ alive. Cờ availability chưa cung cấp timestamp từng field. Money spent và thống kê killfeed là giá trị tính toán. Adapter phải loại default thiếu bằng chứng và duy trì tuổi mẫu riêng.

[Match model](https://github.com/ValoSpectra/Spectra-Server/blob/64782ac2dcd5863aa179a084c8f402c3be794ebe/src/model/Match.ts) đặt mốc round timeout bằng timestamp + 99 giây, spike + 45 giây; suy ra plant khi money tăng đúng 300 trong combat. Có fallback map không nhận diện sang map biết sẵn. Không dùng các hành vi này làm bằng chứng game clock/map trực tiếp.

[Hotkeys](https://github.com/ValoSpectra/Spectra-Client/blob/a07fd0853129a549ac4d657544ae1e0b93e4f5e8/src/services/hotkeyService.ts) có spike planted, tech pause và timeout. Output có thể không giữ đủ thông tin để phân biệt hotkey với GEP/heuristic. Khi không xác định được, ghi provenance `provider-derived-or-manual`, không gắn nhãn observed.

## Thiết kế module đề xuất

Workspace hiện chỉ có placeholder Valorant ở `shared/providers.ts`, `src/Dashboard.tsx`, `src/main.tsx`; chưa có provider/schema/renderer Valorant.

Luồng mục tiêu: **launcher Riot Overlay → collector dựa trên Spectra Client/Overwolf GEP + BE Valorant fork từ Spectra Server + FE Valorant fork từ Spectra Frontend → Studio / OBS**. Project quản lý khởi động, trạng thái sẵn sàng, lỗi và dừng các process do nó tạo. Dùng chung hạ tầng theme, connection status và recording khi phù hợp, giữ contract trận riêng với LoL.

Spectra Client là Overwolf Electron; không thể đưa GEP vào backend Node thuần bằng cách copy TypeScript. Ban đầu giữ collector thành executable/process riêng được launcher gọi. Khởi chạy thành công chưa có nghĩa GEP ready, đã đăng nhập hoặc đang nhận dữ liệu. Không tự đóng Overwolf/collector do người dùng mở sẵn; cấu hình path executable cục bộ, không đưa đường dẫn máy cá nhân vào source.

Spectra Server có thể giữ làm service Node riêng trong cùng workspace trước, sau đó tách ingest, reducer/state và output thành module khi đã có fixture kiểm chứng. Giữ auth/secret trong backend; ranh giới transport nội bộ vẫn cần validation và bảo vệ endpoint.

Spectra Frontend là Angular 20, project hiện tại là React 19. Giai đoạn đầu fork FE thành ứng dụng con có build/output riêng, đưa vào điều hướng và renderer Valorant; không copy component Angular vào React. Một entrypoint vận hành vẫn có thể quản lý nhiều process/bundle. Chỉ port widget sang React hoặc hợp nhất backend sau khi baseline stack fork chạy đúng.

Envelope đề xuất có game/provider, sessionId, matchId nullable, sequence, receivedAt, schemaVersion. Field có value/null, availability, observedAt và provenance (`observed`, `derived`, `manual`, `unknown`). Không lấy sequence nhận ở adapter làm sequence acquisition. Group code không thay thế match ID; reconnect không được trộn trận hoặc phát lịch sử killfeed thành alert mới. OBS vẫn chỉ nhận dữ liệu, nền trong suốt, không fallback sang mock/LoL.

## Kế hoạch tích hợp và kiểm chứng

1. Xác định binary/version Client và image digest đang dùng. Nhập source upstream theo commit pin vào các package riêng trong workspace, giữ LICENSE/NOTICE và ghi modifications. Đây là fork local; chưa tạo remote hoặc push GitHub.
2. Build baseline BE/FE fork, xác định đường chạy collector có sẵn. Chuẩn bị launcher chung với config riêng: executable path, endpoint và secret; kiểm tra health/readiness, port conflict, startup failure và shutdown. Không sửa cấu hình stack cũ để thử nghiệm.
3. Chạy collector + BE/FE fork trong phiên test, đối chiếu với stack gốc; sau đó nối navigation/config/status vào Studio và route OBS Valorant. LoL không phụ thuộc việc Valorant có khởi động được.
4. Thu bản ghi allowlist đã ẩn danh: lobby/agent select → custom observer → buy/combat → plant/defuse/detonate → halftime/OT → end. Đo đủ 10 slot, field completeness và độ trễ bằng đối chiếu màn hình. Không export key, secret hoặc toàn bộ log upstream.
5. Thử scoreboard đóng/mở, đổi observed player, mất collector nhưng server còn chạy, reconnect, match mới cùng group code. Với HP/abilities: so sánh observer-only và auxiliary từng player nếu setup có hỗ trợ.
6. Chốt capability/contract rồi custom BE/FE theo sản phẩm; giữ fixture regression cho reducer, reconnect và renderer. UI LoL baseline giữ nguyên.

Đã tham khảo [REA SKILL.md](https://github.com/morluto/rea/blob/main/.agents/skills/reverse-engineer-anything/SKILL.md): dùng normal repository tools cho source đầy đủ; chỉ cần REA khi có câu hỏi về shipped artifact/runtime chưa được source giải thích. Chưa cài REA hoặc engine; không cần reverse engineer GEP để thực hiện fork/lifecycle integration này.

## Dependency và giới hạn

Source Client ghi [GPL-3.0-only](https://github.com/ValoSpectra/Spectra-Client/blob/a07fd0853129a549ac4d657544ae1e0b93e4f5e8/package.json); Server/Frontend có [ELv2](https://github.com/ValoSpectra/Spectra-Server/blob/64782ac2dcd5863aa179a084c8f402c3be794ebe/LICENSE.md). Đây là giấy phép khác nhau, không mặc định toàn bộ stack MIT. Kế hoạch fork phải giữ giấy phép, attribution và chức năng license/watermark được bảo vệ; chưa nhập source vào runtime. Việc gộp source không làm các phần upstream trở thành ISC theo package root hiện tại. Quyền phân phối/hosting cần đối chiếu điều khoản trước mốc sản phẩm tương ứng.

Ở mốc nghiên cứu 11/10 chưa cài dependency/chạy runtime. Mốc 13/10 đã cài/build riêng BE/FE và kiểm chứng launcher; vẫn chưa tạo collector thay GEP, probe game, kiểm thử replay Valorant hoặc chạy Docker. Không dùng test synthetic làm bằng chứng dữ liệu live.
