# SR live spectator — 15/10/2026 (Bangkok)

Người dùng mở game live SR và đang spec. Không mở/tua/pause game, không LCU,
không sửa nguồn Studio/OBS. Native DLL giữ hash `a1028d56…f2fe`; env đọc local,
không log secrets/playeridentity/raw payload. UTC artifact ngày14/10 buổi17h
tương ứng ngày15/10 tạiBangkok. Không gọi phiên này là replay.

## Kết quả hiện hành

| Vùng | Bằng chứng | Giới hạn |
| --- | --- | --- |
| Roster/đội/tướng | UniqueheroIndex10, team1/2 mỗi5; match roster10 với Riot cùng cửa sổ | HeroIndex chưa chứng minh thứ tự lane; skin/transform chưa kiểm |
| Level/K/D/A | Mỗi field220/220 lượt khớp trong22sample cuối | Khớp mẫu quan sát, không bảo đảm mọi thời điểm/trận |
| Items | Sau táchslotphụ7/8, inventory10/10; items220/220 khớp Riot | Chưa xác minh quest/boots/GA activation hoặc cooldownitem |
| HP/vàng/spells/cooldowns | Fieldcoverage10/10 | API đối chiếu thiếu HP/vàng10người; chưa value/semantics parity |
| Resource |8/10 cặp cómax>0;2 cònmissing | Không dựng resource giả cho max0; chưa kết luận vì champion hay missingfield |
| CS | Candidate lane+neutral chỉ0–2/10 khớp ở các mẫu trước sửa | Tắt projectionCS→null; chưa xác định lỗi getter/schema/semantics; không ghép Riot để che lệch |
| Shutdown với adapterWS mở | Lượt cuối exit0/dừngsạch/khôngforcedstop | Hai lượt trước cầnwatchdog được giữ; không tuyên bố mọi cleanupnative đã giải |
| Auth | Account authenticated-subscription-unavailable; Signcount0/features0 | Chưa signednativechallenge hoặc fullFreeproof |

Lượt cuối clockskew native/Riot tối đa0.1261421s; không phải latency SLA.
Adapter nhận212frame/0invalid, harness22sample. Không có event/objective/perk/
damage/endgame hoặc lane-order mới được xác minh. productionReadyfalse.

## Ba lượt runtime có input khác nhau

1. Coldstart port18807, một lần nạp DLL gốc:87frame/9sample normalized; team/
   champ/level/KDA khớp10, inventory0, CSchỉ2/10; watchdog45s dừngownedhost.
   Evidence `../evidence/validation/sr-live-2026-10-14T17-14-14.039Z.json`.
2. Port18808 --no-inject:229frame/24sample, giữWSconsumer để kiểm lỗi. Nativeitem
   cóslot7/8 mọihero vàlistđến9entries; CS0–2/10 dùclock gần. Vẫnforcedstop.
   Evidence `../evidence/validation/sr-live-reconnect-2026-10-14T17-16-43.041Z.json`.
3. Sau sửa port18809 --no-inject:212frame/22sample, inventory10/10, mỗi field
   level/KDA/items220/220khớp, CSnull. Exit0/forcedfalse, postcheck0ownedhost,
   game vẫnGET200/map11/clock702.488s sautrial.
   Evidence `../evidence/validation/sr-live-fixed-2026-10-14T17-21-57.102Z.json`.

Giữ riêng 3marker; không rerun/xóa marker để tái dùng quyền một lần. Chỉ lượt1
nạp DLL, lượt2/3 reuse producer. Không gửi nativeQuit hoặc đónggame; producer
có thể còn nghe4998 sauhoststop, không diễn giảihoststopthành unloadgameDLL.

## Sửa code và kiểm chứng

- Adapter chỉgiữstandardinventory0..6, bỏknownaux7/8 mà không đoán questsemantics;
  unknownslot/duplicate/malformed vẫnmissing. Thêm regression test.
- CSdisabled sau bằng chứng lệch; không reinterpretbyte hoặc ép số/API fallback.
- WebSocket endpoint host trước chỉ linkRequestAborted, có thể giữ request khi
  host dừng. Nay link thêmApplicationStopping; cancelSend/Receive và dispose.
  LượtWSlive cuối dừngsạch, phù hợp giải thích2watchdogtrước; chưafullnative trace.
- Managedbuild6check/lifecycle16/authflow5đạt; rootbuild và135/135unit đạt.
- Backendintegration cô lập kiểm transport/read-onlyOBS/theme, không themeuser.
- Scripts chỉ giữ count/coverage/comparison/histogramslot/index/stage/hash;
  raw values và identity dùng để match trongRAM rồi bỏ.

## Bước tiếp

Chẩn đoán CS và chốt lane mapping bằng nguồn xác nhận. Kiểm riêng wardScore,
HP/vàng vàcooldown qua thao tác có mốc; livekhôngtua/pause, replay dùng để kiểm
seek sau. Chưa thêm source vàoStudio hoặc tuyên bố LB parity. Đây là mốc SR
baseline cho các field đãđốichiếu, không triển khai C++LeagueReader.
