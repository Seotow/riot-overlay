# Test trận thật — 12/10/2026

## Quy trình hiện hành collector không tài khoản — 16/10/2026

Phần LB bên dưới là hướng cũ; lượt tiếp theo dùng collector không tài khoản.
Build đã chuẩn bị nhịp mục tiêu500ms và reader30.000 sample collector/512MB.
Restart terminal backend cũ bằng `npm run start:collector:no-auth` (không đóng
game). Dùng Studio `http://127.0.0.1:4310/?page=studio`, OBS/overlay chính
`http://127.0.0.1:4310/overlay?scene=ingame`,1920×1080. Layout panel không cam,
demo tắt và nguồn collector-accountless. Giữ nguyên tên/điểm/logo cá nhân.

Trước loading, terminal khác cùng workspace chạy:

```powershell
npm run capture:collector -- 10800000
```

Recorder phải in recording=true và đường dẫn mới; khi game có dữ liệu phải
có observer/native frame tăng, không chỉ có thư mục rỗng. Recorder từ chối
backend cũ chưa công bố cadence500. Giữ terminal ghi mở trong suốt trận.
Native giữ mọi message; app sample và Riot reference mục tiêu500ms, ghi gap
thật nếu nguồn/hệ thống chậm, không tạo sample bù.

Trong trận: thao tác widget tại Studio, không nạp bộ dữ liệu Phòng thử hoặc
chuyển provider/demo khi recorder đang chạy (đổi nguồn sẽ dừng ghi). User có
thể pause/seek/tăng tốc trong game/replay; archive giữ clock thực đã quan sát,
cần báo mốc thao tác để phân biệt timeline game với thời gian ghi.

Kết thúc+15s, terminal khác chạy `npm run capture:collector:stop`, chờ recorder
in state=stopped để gzip/manifest flush. Sau đó mới mở Phòng thử→Refresh→chọn
timestamp vừa ghi→tải/play/pause/seek. Kiểm coverage/gap/đầu-cuối trước khi gọi
capture là trọn trận; capture hoàn chỉnh không đồng nghĩa mọi field đã support.
Chi tiết file/marker/privacy tại [bàn giao UI](UI_COLLECTOR_HANDOFF.md).

Dọn trước lượt này:17 dataset cũ và2 con trỏ latest đã chuyển recoverable sang
`data/capture-archive/2026-10-16-before-full-match/`. Danh sách capture hiện0;
giữ nguyên pktmon/REA,theme,assets và test fixtures. Muốn phục hồi, chỉ chuyển
thư mục timestamp cần thiết về data/captures khi không có recorder đang chạy;
không ghi đè capture mới. Những regression cần bản ghi cũ phải restore hoặc
trỏ archive rõ ràng, không thay bằng mock để giả proof.

## Chuẩn bị

1. Build rồi chạy backend. Mở `/?page=theme`: nhập tên giải, hai đội, điểm loạt trận, logo tùy chọn, màu/font/widget; bấm **Lưu cấu hình**. Không có logo thì chỉ có tên; không tự gán KT/T1.
2. Kết nối dữ liệu → LeagueBroadcast. Giữ demo tắt, không cue phòng thử. LB cần đăng nhập và nhận spectator custom live; client/replay có clock không chứng minh có đủ người chơi. Nhánh collector headless/REA giữ riêng, chưa thay LB production.
3. `/?page=studio`: preview nhúng đúng `/overlay?scene=ingame`. OBS Browser Source dùng URL này, 1920×1080. Không chọn URL Studio/phòng thử. Preview/checkerboard thuộc Studio, output trong suốt và chỉ nhận dữ liệu.
4. Kiểm tra đủ 10 player, game clock, gold, objective pit và trạng thái mẫu mới. Chọn widget tại bàn điều khiển; các nút không sửa telemetry. Cấm chọn và postgame tạm khóa trong UI; renderer fixture và hợp đồng scene cũ vẫn giữ để regression.

## Trigger

- Trụ/trụ đầu, rồng, linh hồn, Baron/Elder, level/item/quest cue tự phát khi adapter/session tạo event mới. Timer hai hang tự dùng loại và mốc từ nguồn, không cố định hang Baron.
- Bật `Mục tiêu / sự kiện tự động` trong config. First tower cần adapter xác minh thay đổi số trụ, không bật thủ công khi trận thật. Reconnect/seek đặt baseline, không phát lịch sử.
- Baron 180s / Elder 150s theo game clock, buff từng người do nguồn báo. Gold Power Play suy ra có nhãn; không tự cấp buff cho người chết.
- Nhà lính: mặc định tự chọn đội có hồi sinh gần nhất; operator có thể ẩn hoặc chọn riêng xanh/đỏ. Không có timer thì không hiển thị. Config không ghi số thời gian giả.
- Vàng/cấp độ/rune/tối giản do operator chọn, một view mỗi lần. Combat/damage chưa tự động; end-game và draft live hoãn.

## Ghi toàn trận

Điều khiển widget là state phiên chia sẻ qua backend, không lưu qua restart. Sau restart trở về view bình thường và nhà lính auto; theme/config được lưu ổ đĩa. Chuyển nguồn không tự thay config đội: operator phải kiểm tra tên/tỉ số cho trận mới. Export/import chứa cả logo raster; không dùng URL ảnh ngoài hoặc SVG.

Khuyến nghị **event-driven: lưu mọi message JSON của feed LB**, không chỉ snapshot cuối cùng mỗi 0,5s. Feed đang quan sát thường khoảng 2 Hz nhưng không ép/cam kết cadence của provider. Timestamp nhận + game clock cho phép điều tra pause, mất kết nối và sai số. Không suy ra thời điểm game từ thời gian máy.

Trước loading, chạy tại project trong terminal riêng:

```powershell
npm run capture:lb -- 10800000
```

Chờ hết trận thêm khoảng 15s, nhấn Ctrl+C để flush file và ghi manifest. Tham số là millisecond, 3 giờ là ngân sách tối đa phiên; script giới hạn 4 giờ. Auto reconnect, loại KeepAlive, redaction khóa credentials; raw gameplay/tên người chơi vẫn local tại `data/captures/lb-*`, không commit/share nguyên file. Ghi mốc sự cố tùy chọn:

```powershell
npm run capture:mark -- "6 - 18:42"
```

Không có feed trong một đoạn thì không thể phục hồi data đoạn đó. Kiểm tra manifest `frames`, `disconnects`, `invalidMessages`, `firstFrameAt`/`lastFrameAt`; kiểm tra khoảng trống NDJSON trước khi tuyên bố đầy đủ. Disk full/process crash chưa có bảo đảm phục hồi manifest; NDJSON đã ghi vẫn dùng để điều tra. Capture không tự khởi động bởi mở bàn điều khiển.

### Các phương án khác

| Phương án | Ưu / nhược |
| --- | --- |
| Mọi message WS (chọn cho lần test) | Giữ thay đổi tốt nhất từ feed, gồm event/status; tốn đĩa hơn |
| Snapshot mỗi 0,5s + event log độc lập | Giảm lưu snapshot trùng, nhưng cần bổ sung logger event tách riêng; polling đơn lẻ có thể bỏ event ngắn |
| Snapshot khi đổi + checkpoint mỗi 5s | Nhẹ hơn, cần hash/delta và chỉ mục mới; chưa triển khai |

**Giới hạn playback hiện tại:** reader tối đa 512MB và 10.000 state frame (~83 phút nếu đúng 2 Hz). Logger không có giới hạn đó, nhưng bản ghi dài có thể lưu được mà chưa mở nguyên trong phòng thử được. Với trận dài hơn cần chia/index stream trước khi import, không cắt/xóa raw file. Lần test đầu ưu tiên giữ full feed; nâng reader/chia archive khi biết dung lượng/cadence thực tế.

## Sau trận

Đối chiếu ít nhất: trụ đầu vs trụ thường, từng rồng/Soul, pit chuyển GRUB → HERALD → BARON, buff chết/hồi sinh, inhibitor mỗi đội, view rune/leaderboard/minimal. Kiểm tra cả OBS và preview nhận đúng config. Tạm ngắt LB để kiểm tra quá hạn 5s và reconnect không nhân đôi thông báo. Chưa có trận thật mới kiểm chứng workflow production này; test bản ghi/transport không thay thế thử spectator live.
