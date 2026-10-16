# Kiểm HP/MP/vàng trên map bất kỳ — 15/10/2026

## Không tài khoản đã có dữ liệu thật trên SR — 16/10/2026

SR map11, spectator, trận chưa kết thúc. Trước test không có listener producer4998
hoặc LB58869. Coldstart DLL cache qua owned18814 nhận104/104 frame valid,10hero;
auth not-configured/features0/signingAttempts0/signedResponses0. Đầu trận bốn
field chưa biến thiên. Host diagnostic dừng sạch rồi app chọn chế độ không tài
khoản, nối lại producer vừa tạo qua18799, đo45s:

| Field | Native coverage | Hero biến thiên | Studio/OBS coverage |
| --- | --- | --- | --- |
| HP |10/10|9/10|10/10|
| Resource (mana/energy/wind) |10/10|8/10|10/10|
| Vàng đang giữ |10/10|10/10|10/10|
| Tổng vàng native |10/10|10/10|10/10|

App nhận432/432 native valid; Studio53/OBS53 sample,53 sample trùng JSON theo
timestamp. Auth vẫn not-configured/features0/sign0. App runtime xác nhận
withoutAccount=true/credentialConfigured=false; cache hash vẫn bản đã pin.
Lượt app là reconnect cùng producer không tài khoản, không coldstart thứ hai.

Evidence counts: `../evidence/validation/basic-fields-2026-10-16T10-44-29.354Z.json`
và `accountless-project-2026-10-16T10-46-16.037Z.json`. Không raw/identity/credentials;
giá trị theo public champion chỉ in trong phiên. Đây là bằng chứng field cơ bản
không cần tài khoản trong cấu hình hiện tại, chưa numeric HUD parity, full LB
feature parity, độ ổn định toàn trận hoặc bảo đảm cache/patch tương lai.

## Chuẩn bị phép thử không tài khoản — 16/10/2026

Lệnh từ root: `npx tsx Collector/scripts/probe-basic-fields.ts --without-account`.
Chế độ này giữ DLL cache đã pin hash, không dùng `--update-lib`, tạo host riêng
với email/password rỗng, loại các biến LB/AWS/Cognito kế thừa và trỏ file env
đến đường dẫn bắt buộc không tồn tại. Không sửa file tài khoản thật hoặc DLL,
không cấp feature/ký challenge giả. Luồng chạy project mặc định không đổi.

Probe từ chối attach host18799 khi thử không tài khoản; ghi producer4998 có
sẵn hay không và trạng thái auth/count ký/feature từ host. Nếu producer đã
có, kết quả chỉ là reconnect không tài khoản, chưa chứng minh coldstart độc lập.
Có thể thêm `--no-inject` để bắt buộc dùng producer sẵn có.

Offline `npx tsx Collector/scripts/check-accountless-offline.ts` đã đạt:
hash DLL đúng, `--auth-check` trả `not-configured`, exit2 đúng thiết kế; không
khởi tạo native hoặc đọc game. Evidence:
`../evidence/validation/accountless-offline-2026-10-16T02-30-07.021Z.json`.
Offline chỉ xác nhận cô lập cấu hình; sau đó đã có phép thử runtime ở phần trên.
Ở lần chuẩn bị đầu GET2999 ECONNREFUSED và user chưa mở được trận. Map12 vẫn
phù hợp cho phép đo field cơ bản; lượt runtime16/10 thực tế dùng SR map11.

User ưu tiên lấy field cơ bản ngay trên trận không phải SR. Lệnh từ root:
`npm run collector:probe-fields`. Projection diagnostic riêng nhận1..64 hero,
không nới contract HUD/validator SR10 hoặc tạo player giả cho đủ10.

Preflight cần game API/spectator và end-state hợp lệ, LB listener đóng. Có
collector đã xác minh ở18799 thì chỉ attach; nếu không, tạo owned host18814,
giữ DLL/auth/version/spectator guard gốc và config local. Producer4998 đã có
thì dùng --no-inject. Coldstart chỉ khi chưa có producer, dùng luồng gốc của
collector đã được user yêu cầu kiểm chứng. Không LCU/đổi replay/quit game.

Để tuyệt đối không nạp DLL lại:
`npx tsx Collector/scripts/probe-basic-fields.ts --no-inject`.
Nếu producer không còn, lệnh dừng; không fallback injection. Mỗi lượt≤30s đo
cộng startup/cleanup; chỉ dừng host do mình tạo, không dừng host attach ngoài.
HP/resource cần current≥0 và max>0/current≤max. MP chỉ là resource loại mana;
energy/shield/none/unknown không đổi thành mana. currentGold khác totalGold;
0 hợp lệ, missing/null/NaN/negative không ép thành0.

## Runtime đã quan sát

Replay map12, tốc độ1×, spectator, trước GameEnd. Coldstart29frame valid10hero;
reconnect no-inject232frame valid10hero. Lượt sau:

| Field | Hero có dữ liệu | Hero có biến thiên |
| --- | --- | --- |
| HP/current,max |10|10|
| Resource/current,max |9|9|
| Vàng đang giữ |10|10|
| Tổng vàng kiếm được (native totalGold) |10|10|

8 tướng báo mana, Mordekaiser báo shield, Mundo báo none/resource null.
Giá trị đã lọc in ở console trong phiên, không lưu raw frame/identity/credentials.
Hai evidence counts tại `../evidence/validation/basic-fields-2026-10-15T15-30-24.462Z.json`
và `basic-fields-2026-10-15T15-32-41.100Z.json`. Console có số liệu field cụ thể
theo champion công khai do user yêu cầu; đây không phải log raw payload.

Riot API allgamedata HTTP200/10player nhưng coverage HP/resource/currentGold/
totalGold đều0, nên không coi nó là reference numeric parity. Cần đối chiếu HUD
hoặc nguồn có field để xác minh giá trị và ý nghĩa đầy đủ. Presence+change cho
thấy native thu được data động, không chứng minh full LB parity/entitlement.
Không claim resource null do license khi champion none/max0 đã giải thích.

Host thử18814 đã đóng, exact host/listener còn0; game vẫn chạy clock419.088s,
map12/1×/unpaused. Build148unit đạt; không đổi baseline theme/UI/assets. Bước
tiếp: kiểm HP/MP/vàng trên Studio/OBS cùng replay, tiếp tục đối chiếu semantics;
CS/lane và objectives vẫn là các vấn đề riêng còn thiếu.
