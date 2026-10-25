# Hướng dẫn setup Valorant

Tài liệu này hướng dẫn hai vai trò của module Valorant:

- **Host**: máy chạy Riot Overlay Studio, Spectra backend và tunnel nhận dữ liệu.
- **Player**: máy của tuyển thủ, chạy Spectra Client ở chế độ auxiliary để gửi dữ liệu
  và camera về host.

Module dùng Spectra Client chính thức chạy ngầm, backend fork và overlay VAL26. Chưa
coi đây là bằng chứng telemetry game đầy đủ; cần kiểm tra lại trong trận thật trước
buổi phát.

## Chuẩn bị chung

Trên mỗi máy cần Windows, Node.js và mạng Internet. Tại thư mục gốc repository:

```powershell
npm ci
```

Không gửi `auth.key`, mã tunnel hoặc dữ liệu trong `collector/hosts/valorant-collector/local`
vào chat, screenshot hay Git. Thư mục `local/` là dữ liệu riêng của từng máy và đã
được Git bỏ qua.

## Setup host

### 1. Cài module

Có thể để Studio tự cài lần đầu, hoặc chạy trực tiếp:

```powershell
npm run valorant:setup
npm run valorant:doctor
```

Lệnh setup tạo cấu hình và key trong `collector/hosts/valorant-collector/local`,
build backend/overlay và tải Spectra Client chính thức một lần với kiểm tra SHA256.
Cần Node.js 22 trở lên cho các dependency của module.

### 2. Chạy Studio và kết nối Valorant

```powershell
npm run build
npm start
```

Mở Studio tại `http://127.0.0.1:4310/?page=studio`, chọn **Valorant**, rồi bật
**Kết nối Valorant**. Không cần tự mở Spectra Client; Studio quản lý tiến trình do
nó khởi động.

Khi Client đã kết nối, kiểm tra trang Valorant nhận được trạng thái module và frame.
Đây chỉ xác nhận đường truyền hoạt động, không xác nhận đủ 10 player hoặc đủ HP/ability.

### 3. Cho player kết nối ngoài LAN

Trong Studio mở **Valorant → Phát sóng**, bật **Player đẩy dữ liệu (ngoài LAN)**.
Studio sẽ mở cloudflared quick tunnel và sinh code 5 ký tự. Gửi code riêng cho từng
player:

```text
Ví dụ: K7M2P
```

Không cần nhập room camera hoặc danh sách player. Mã camera vdo.ninja được sinh tự
động theo mã tunnel. Khi player auxiliary kết nối, backend tự nhận tên từ roster và
Studio hiển thị tên camera cùng nút **Preview cam**.

Nếu không dùng Studio để mở tunnel:

```powershell
npm run valorant:code
```

Giữ terminal host chạy trong suốt phiên. Code là thông tin riêng; người biết code có
thể tra địa chỉ tunnel và mã camera.

## Setup player

Player cần được host gửi code 5 ký tự. Trên máy player, tại thư mục repository:

```powershell
npm ci
npm run valorant:player
```

Trình duyệt mở `http://127.0.0.1:5398/`. Nhập code; đủ 5 ký tự sẽ tự kết nối.
Spectra Client được tải và chạy ngầm nếu máy chưa có. Player không cần mở Spectra
Client thủ công, không cần nhập Riot ID và không cần nhập room.

Trang player chỉ hiển thị:

- tình trạng kết nối tới host;
- tên player tự đọc từ trận;
- nút **Mở camera**;
- nút **Preview camera** để thử webcam;
- nút dừng kết nối.

Camera chỉ truyền hình, microphone và âm thanh hai chiều bị tắt. Khi vào trận, Client
mới có `match_id` và mới gửi auxiliary; hãy giữ trang mở cho tới khi trạng thái chuyển
sang đã kết nối. Cho phép quyền camera khi trình duyệt hỏi.

Để chạy bản dòng lệnh không mở UI:

```powershell
npm run valorant:player:cli -- K7M2P
```

Bản CLI dùng cho kiểm tra kết nối; UI player là cách dùng camera được hỗ trợ.

## Kiểm tra và dừng

Host có thể chạy bộ kiểm tra module:

```powershell
npm run test:valorant
npm run build
npm run format:check
```

Tắt kết nối player bằng nút **Dừng kết nối** hoặc đóng terminal player. Tắt tunnel
bằng công tắc trong Studio hoặc Ctrl+C ở terminal chạy `valorant:code`. Không tự kill
process lạ đang giữ cổng.

## Giới hạn hiện tại

- Chưa kiểm chứng đủ 10 player và hình camera trong overlay bằng một trận thật.
- Code ngắn không chứa key và chỉ dùng cho chế độ auxiliary.
- Tunnel quick có URL thay đổi khi khởi động lại; code rendezvous được đăng lại để
  player tra địa chỉ hiện tại.
- Không sửa binary hoặc `app.asar` của Spectra Client.

Chi tiết kiến trúc và giới hạn: [docs/VALORANT_MODULE.md](../../../docs/VALORANT_MODULE.md).
