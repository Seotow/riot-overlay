# Cài đặt và vận hành nội bộ

## Cài trên máy mới

Cần Windows, Node.js 24 và npm. Clone repository, mở terminal trong thư mục
có `package.json` rồi chạy:

```powershell
npm ci
npm run build
npm start
```

Không bỏ devDependencies vì backend hiện cần `tsx`. Giữ terminal chạy.
Mở http://127.0.0.1:4310/?page=studio. Khi dừng, bấm Ctrl+C.

Máy OBS và backend hiện phải cùng máy. Backend chỉ bind `127.0.0.1`;
chưa có xác thực để dùng qua LAN. Nếu port 4310 đã được dùng, dừng đúng
terminal của phiên cũ, không tắt hàng loạt tiến trình Node.

Để sửa source và xem frontend cập nhật tự động, dùng `npm run dev`.
Để cập nhật bản đang dùng: dừng backend, kéo source, chạy `npm ci`,
`npm run build` rồi `npm start`.

## Cấu hình OBS

Thêm Browser Source, đặt kích thước 1920 × 1080 và URL:

```text
http://127.0.0.1:4310/overlay
```

URL này theo scene đang chọn trong Studio. Có thể tạo source riêng:

- In-game: `http://127.0.0.1:4310/overlay?scene=ingame`
- Cấm chọn: `http://127.0.0.1:4310/overlay?scene=draft`
- Sau trận: `http://127.0.0.1:4310/overlay?scene=postgame`

Đầu ra trong suốt, không kèm ảnh chụp game để đối chiếu hoặc nhãn kiểm thử.
Kiểm tra bằng OBS trước buổi phát. Dữ liệu mẫu/bản ghi chỉ được báo trong
Studio; người vận hành cần kiểm tra nguồn trước khi lên sóng.

## Chuyển cấu hình và bản ghi

Export theme ở **Cấu hình trận đấu**, import trên máy mới rồi bấm
**Lưu cấu hình**. Hoặc copy riêng `data/theme.json` khi backend đã dừng.
Không lấy theme test thay theme đang dùng.

`data/` không theo Git. Nếu cần phát lại trận, copy nguyên thư mục capture
vào `data/captures/`, mở **Phòng thử**, chọn và tải bản ghi.
Raw có thể chứa tên người chơi và định danh trận; chỉ chia sẻ nội bộ khi cần.

Ảnh, font và catalog runtime đã có trong `public/` và `shared/generated/`.
Không cần tải lại chỉ để chạy ứng dụng. Bộ demo khóa Data Dragon 15.20.1;
bộ live dùng catalog riêng. Không tự đổi version baseline khi cập nhật máy.

## Chuẩn bị nguồn live

Collector tích hợp không được đóng gói trong Git: DLL, runtime, cache và
source vendor được quản lý riêng. Người quản trị cần chuẩn bị các thành phần
đã được phép sử dụng theo [runbook collector](../Collector/docs/PROJECT-RUNBOOK.vi.md).
Không tải DLL từ nguồn không rõ hoặc chép credentials vào repository.

Sau khi chuẩn bị:

```powershell
npm run start:collector:no-auth
```

Hoặc `npm run start:collector` nếu dùng chế độ có tài khoản.
Cấu hình tài khoản ở `Collector/config/collector.env`, file bị Git bỏ qua.
Chế độ không tài khoản vẫn cần runtime và cache thích hợp, không phải clone
xong là có thể thu dữ liệu.

Tại **Nguồn dữ liệu**, ứng dụng phải xác nhận spectator hoặc replay trước
khi mở collector. Đang chơi trận hoặc không xác nhận được chế độ thì bị chặn.
Không sửa chốt để dùng trên máy người đang thi đấu.
Xem [chốt an toàn](COLLECTOR_SAFETY.md).

Nếu dùng LB gốc, chạy LB riêng rồi chọn **LeagueBroadcast**.
Ứng dụng có thể ngắt kết nối feed nhưng không quản lý tiến trình LB bên ngoài.

## Ghi và phát lại trận

1. Mở spectator hoặc replay, xác nhận Studio nhận được dữ liệu.
2. Dùng terminal thứ hai: `npm run capture:collector -- 10800000`.
3. Sau trận, chạy `npm run capture:collector:stop` hoặc Ctrl+C ở terminal ghi.
4. Mở **Phòng thử**, tải bản ghi rồi kiểm play/pause, timeline và các widget.

Nhịp mục tiêu là 500 ms, không phải bảo đảm tuyệt đối dưới mọi tải máy.
Capture tự dừng nếu chốt không còn xác nhận spectator/replay.
Cách đối chiếu raw và bản dựng: [bàn giao dữ liệu](UI_COLLECTOR_HANDOFF.md).

## Sau trận và bảo mật

Trang **Sau trận** có ô nhập Riot API key, lưu trong RAM của backend.
Khởi động lại cần nhập lại. Không đưa key vào theme, file ghi trận, frontend
hoặc Git. Xem [thiết lập Riot API](RIOT_API_SETUP.md).

LCU/ROFL cho custom vẫn là hướng nghiên cứu, chưa có bước tự động trong
quy trình vận hành. File ROFL đã thử do người chơi tải trước đó; không xem
nó là bằng chứng tài khoản spectator tự tải được trận.

## Kiểm tra trước bàn giao

```powershell
npm test
npm run build
npm run test:integration
npm run test:collector
npm run test:collector-capture
npm run test:collector-validation
```

Các bài integration mở port loopback và dùng dữ liệu giả lập tách biệt.
Không dùng chúng làm bằng chứng đã kiểm đủ telemetry trong trận thật.
Không chạy `tests/transport.integration.ts` trực tiếp trên phiên phát sóng
vì bài đó thay đổi mock state.

Giữ theme, credentials, captures, cache, binary và thư mục REA riêng khi chuyển
máy. Trạng thái hiện hành nằm ở [PROJECT_STATUS.md](../PROJECT_STATUS.md).
