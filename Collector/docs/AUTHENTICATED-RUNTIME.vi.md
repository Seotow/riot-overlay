# LeagueCollector runtime với env local — 14/10/2026

## Phạm vi và kết luận mới

Nhánh host riêng dùng DLL LB đã nhận native telemetry trên replay map12,
patch16.20.824.8524, không chạy LB UI/listener58869 lúc preflight. Đây không
phải LeagueReader độc lập và chưa phải parity đầy đủ hoặc coverage map11/SR.

Account-only check thành công: `authenticated-subscription-unavailable`,
subscriptionFeatureCount0. Không lưu email/password/token/nonce/signature.
Trong trial native, signingAttempts0/signedResponses0/requestedFeatureCount0.
Vì vậy đã kiểm chứng login account, **chưa kiểm chứng signed native challenge**
và chưa chứng minh login là điều kiện cần để nhận các field quan sát được.

Kết quả này sửa kết luận quá rộng rằng mọi collector riêng thiếuDevelop đều
không có data hoặc khôngsignedauth luôn trả rỗng. Trial host cũ thiếuDevelop
vẫn là evidence của đườnghost đó; không áp rule của nhánhNamedPipe cũ cho
mọi transport/client. Source gói mới dùng PreferTcpTransport=true; chưa có
trace native xác định policy/classification chính xác gây khác biệt.
Không bypass gate, giảAppId/publisher hoặc gán grant trong lượt này.

## Account và replay preflight

- Account check: `account-auth-2026-10-14T15-01-36-25eabfe5d13f4448a9bea3627453ac82.json`.
- ReplayGET200: time130.0175s,1×,pausedfalse,seekingfalse,map12,khôngGameEnd.
- Process inventory trong sandbox không đáng dùng để phủ định game đang chạy;
  approvedReplayAPI là bằng chứng runtime. Không mở/tua/pause replay hoặc dùng LCU.

## Trial native có account — một lần nạp DLL gốc

Evidence: `../evidence/validation/authenticated-native-2026-10-14T15-04-58.838Z.json`.

- Port18805; noLCU/noUpdate/noRawRecording; auth từfile local.
- LB58869 và native4998 closed trước; DLLhash ghim giữ nguyên.
- 1game-window,1inject-reported,1game-started; host ghi nhận tối thiểu84snapshot.
- Harness lấy9snapshot samples: clock353.1676→361.21332s, tất cả10hero.
- HP/maxHP/gold/totalGold numericpresence10; item/spell nonempty10 trong mỗi sample.
  Presence chưa tự chứng minh giá trị hữu ích, đúng semantics hoặc đầy đủ quyền.
- Account state authenticated/subscription-unavailable; khôngcallbackSign.
- Exit0/dừngsạch, khôngwatchdogkill; read-onlypostcheck0matching validationhost.
- Replay vẫnGET200/unpaused; native4998 còn nghe sauhoststop. Hoststop không
  đồng nghĩa moduleproducer tronggame đãunload; không gửiQuit hoặc đónggame.
- PassiveIPC sautrial: pipeCandidate=true/pipeOwnerVerified=false,
  tcpBoundToGame=true; probe khôngconnect/load/inject/snapshotrequest.

## Sửa diagnostic và guard

Thêm signingAttempts/signedResponses chỉ là số đếm. Không đổi response/quyền.
NativeLibraryFetcher giờ fail closed khi noUpdate và version/metadata không
phù hợp, tránh implicitdownload thay DLL. Regression offline trường hợp này đạt.
Build harness6check đạt, lifecycle16/16/authflow5/5; giữ log failed development
passes và lượt cuối ở `managed-lab-2026-10-14T15-04-19-837Z-b4f9456fe09448f396e5061e1d11ab2b`.

## Tiếp tục

### Kết nối lại đã kiểm chứng, không nạp DLL thêm

Evidence: `../evidence/validation/authenticated-reconnect-2026-10-14T15-07-57.281Z.json`.
Port18806, --no-inject/noLCU/noUpdate/noRawRecording; native4998 sẵn có,
LB58869 không nghe. Host ghi nhận tối thiểu228snapshot, harness24sample từ
516.2971→539.6159s, tất cả10hero. PositiveMaxHP/totalGold/spellReadyAt10 trong
mọi sample; sốhero có thay đổi HP/totalGold/resource giữa các sample tối đa10.
Không retain giá trị player thực, identity hoặc memoryaddress. Phép đo không
chứng minh cooldown từng slot/GA/perks/events, độ chính xác từng field hay
đủ data tierFree. SigningAttempts/signedResponses/requestedFeatureCount đều0;
account vẫn authenticated-subscription-unavailable.

Exit0/dừngsạch, forcedstopfalse; postcheck0matching validationhost. Replay vẫn
GET200/unpaused,producer4998 vẫn nghe. Không thêm injection, không gửiQuit hoặc
đónggame. Marker hai trial mới được giữ, không tự rerun.

**Đã đạt:** host collector riêng dùng DLL LB nhận dữ liệu và kết nối lại trên
replay mẫu khi LB UI tắt. **Chưa đạt:** signed native account authorization,
đăng nhập là điều kiện cần, map11SR/fullparity hoặc collector C++ độc lập.

Không cần lặp trial cùng input lúc này. Bước tiếp là review field mapping/contract
offline; nếu cần tăng coverage thật, dùng replaySR và baseline có provenance.

Sau đó cần replaySR/map11 và baselineLB cùng
trận để kiểm field/event, pause/seek/reconnect và quyền account. Không auto
đưa dữ liệu raw vào Studio/OBS hoặc tuyên bố fullFree/LBreplacement.
