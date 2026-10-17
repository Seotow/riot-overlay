# Kiểm chứng provider trong project với trận thật

Mốc 15/10/2026: thêm `npm run collector:validate`. Đây là công cụ chỉ đọc,
attach backend hiện có; không tự launch collector, đọc env, auth, inject, gọi
LCU, đổi source/demo/theme, gửi command WS hoặc sửa playback. Không cần mở LB gốc.

## Chạy khi game sẵn sàng

1. Người dùng mở spectator live SR10 hoặc replay SR10 còn trong trận, cùng patch.
   Giữ LB gốc đóng. Runtime collector vẫn giữ auth/native/version/spectator guard.
2. Từ root, `npm run start:collector` để project sở hữu host. Studio chọn
   LeagueCollector, demo tắt; đây là luồng vận hành đã tích hợp, không phải
   command của validator. Credentials tại `collector/config/collector.env`.
3. Chạy ở terminal khác: `npm run collector:validate`. Mặc định attach loopback
   4310, tối đa30 giây đo sau preflight. Không dừng hoặc đổi host/backend khi xong.
4. Cần đổi cổng/thời lượng thì gọi trực tiếp:
   `npx tsx collector/scripts/validate-project-live.ts --port 4310 --seconds 30`.
   Thời lượng hợp lệ5..120s. Wrapper npm.ps1 trên máy đã bỏ tên flag khi dùng
   `npm run ... -- --seconds 5`; lệnh npx trực tiếp và npm không flag đã chạy được.

## Các điều kiện và số đo

- Trước attach project: GET API2999 phải có map11, 10 người5+5, spectator
  Unknown/Spectator, clock tăng qua hai mẫu và có event vector không GameEnd.
  Roster/champion phải rõ và giữ ổn định; trường hợp duplicate champion cùng
  team không đoán bằng thứ tự. Không đủ điều kiện thì dừng trước backend/WS.
- Sau ready: LB listener58869 phải xác nhận đóng; `/api/providers` phải chọn
  `league-collector`, output cùng provider, runtime running/owned. `running`
  là process ownership, chưa chứng minh telemetry. Validator không bật provider
  hộ người dùng. Kiểm lại source/ownership mỗi lượt để dừng khi đổi nguồn/demo.
- Subscribe Studio/OBS read-only và ghép theo session/epoch/sequence. Chỉ đếm
  native source frame observed, không playback, timestamp mới dưới5s. So toàn
  frame của hai consumer, không suy bằng việc cả hai có cùng số player.
- Đọc `/api/observer` và Riot allgamedata cùng cửa sổ; timestamp dưới5s, future
  tối đa1s, clock skew≤0.5 game second mới đối chiếu. Match team+champion1:1,
  provenance đúng hai nguồn, không dùng tên/raw ID trong report. Bỏ frame trùng.
- Mỗi field có nativePresent/referencePresent/compared/matched/disagreed riêng.
  Field Riot không cung cấp cho đủ người không được coi là matched; CS null
  không là0 CS. Inventory so multiset ID khác0; spell cần cả hai ID có mặt.
  HP/resource/gold/cooldown semantics vẫn cần reference phù hợp hoặc HUD thật.
- Dừng đo khi mất API, GameEnd/end-state thiếu, đổi roster/clock quay lùi,
  đổi provider/ownership. LB listener kiểm tra ở đầu/cuối; đây là hai boundary
  checks, không là bằng chứng process LB vắng mặt liên tục toàn cửa sổ.

Report tại `collector/evidence/validation/project-live-<UTC>.json`, bị ignore.
Chỉ có counts/clock skew/status và cờ phạm vi, không snapshot/player identity/
credential/raw stats. `null` là bước chưa kiểm hoặc chưa thể xác minh; không
coi defaultfalse là kết quả negative. Không xuất signature roster nội bộ.

Process trả nonzero nếu chưa ready, nguồn chưa owned, không có mẫu aligned
roster10, field bất đồng hoặc consumer frame khác nhau.
Core gate còn cần ít nhất một sample so đủ level/K/D/A/items của10 người;
clock/roster mà core telemetry thiếu không được trả thành công. Exit0 chỉ nói lượt đo
đã thực hiện với các điều kiện trên; **fullParityVerified luônfalse**, không
tự chốt goal, entitlement hoặc productionReady từ những field API có thể so.
Windows shell có thể biểu diễn nonzero khác giá trị exit2 của Node.

## Kiểm chứng đã làm và còn thiếu

146 unit test và build đạt; 3 test mới kiểm preflight, presence/equality, stale/
clock skew/ambiguous roster/provenance, không raw identity trong comparison.
Chạy CLI thật cuối15/10 local (14/10 18:28:32.333UTC) báo game-api-unavailable,
measurementScope=preflight-only, project/LB checks null và0 sample/consumer frame.
Evidence `project-live-2026-10-14T18-28-32.333Z.json`. Không gọi backend, không
chạy host/DLL và không thao tác game trong lượt này.

Engine positive HTTP/WS đã kiểm bằng `npm run test:collector-validation`,
10 scenario (positive, consumer khác, field khác, lệch clock, đổi provider,
GameEnd, game absent, external, core missing, LB busy). `dataOrigin=fixture`,
scope fixture-project-comparison; simulated ownership/reference không native
proof. CLI production không có flag fixture; vẫn cần game thật. Lab evidence
`project-validator-lab-2026-10-14T18-38-19.108Z.json`. CLI thật sau refactor
18:38:59.804Z vẫn game API absent/preflight-only, không backend/host/auth.
Sau khi game mở được, dùng công cụ này đo toàn tuyến rồi bổ sung
đối chiếu HUD cho field Riot không cung cấp, retention/event mapping, CS/lane,
buff/respawn/objective/counter và stability. Mục tiêu LB tích hợp đầy đủ chưa đạt.
