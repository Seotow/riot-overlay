# Bản player (đẩy dữ liệu + cam về host)

Để host lấy đủ dữ liệu 10 người (máu, chiêu, tiền chính xác), **mỗi player** chạy bản này trên máy
mình. Nó dùng lại Spectra Client chính thức chạy ngầm (giống host), chỉ đổi đích về ingest công khai
của host qua tunnel. Player **chỉ cần nhập một code 5 ký tự** do host cung cấp — không cần cùng mạng LAN.

## Cách dùng (có UI)

1. Host mở Studio → Valorant → Phát sóng → bật **"Player đẩy dữ liệu (ngoài LAN)"** và gửi **code 5 ký
   tự** cho từng player (ví dụ `K7M2P`).
2. Player chạy:

   ```bash
   npm run valorant:player
   ```

   Trình duyệt mở `http://127.0.0.1:5398/`. Nhập code vào ô đầu rồi bấm **Kết nối**.
3. Trang hiện trạng thái kết nối (kết nối tới host, match id, số frame máu/kỹ năng đã gửi). Lần đầu,
   Spectra Client được tải một lần (kiểm SHA256) rồi chạy ngầm (cửa sổ ẩn); cứ vào trận bình thường.
4. Khi vào trận, trang tự đọc Riot ID của bạn từ dữ liệu game. Bấm **Bật camera** để mở vdo.ninja và
   cho phép webcam — hình được đẩy lên room của host. **Tắt camera** để dừng ngay.

Đóng cửa sổ terminal là client dừng; muốn dừng riêng phần kết nối thì bấm **Dừng kết nối** trong trang.

## Cách dùng (dòng lệnh, không UI)

```bash
node collector/hosts/valorant-collector/player/join.mjs K7M2P
# hoặc
npm run valorant:player:cli -- K7M2P
```

Bản CLI không có camera; nếu host có room cam, đặt `RIOT_OVERLAY_PLAYER_ID=Tên#Tag` để nó in link đẩy
cam cho bạn mở tay.

## Code 5 ký tự hoạt động thế nào

URL tunnel `trycloudflare.com` đổi mỗi lần host chạy lại, nên code **không** chứa địa chỉ. Code là chìa
khoá tra cứu: host công bố `{origin, groupCode, camRoom}` lên điểm hẹn công khai
(`runtime/rendezvous.mjs`, mặc định `ntfy.sh`, đổi bằng `RIOT_OVERLAY_RENDEZVOUS`), bản player đọc lại
đúng topic `riotovl-<code>`. Vì vậy host bật lại tunnel vẫn dùng được code cũ.

Bảo mật: topic công khai, ai biết code đều đọc được địa chỉ + room cam, nên code phải chia sẻ riêng.
Code ngắn **không chứa key**; nó chỉ dùng được ở chế độ **auxiliary** (đúng thứ player cần). Code dài
base64 cũ vẫn nhập được (nó mang cả key) — dùng khi điểm hẹn không truy cập được.

## Ghi chú

- Vào trận rồi client mới đăng nhập được: chế độ auxiliary cần `match_id` của trận để khớp với host, nên
  cứ để trang chạy, client tự thử lại cho tới khi `Connected`.
- Nhớ nhắn host thêm đúng `Tên#Tag` của bạn vào **Cấu hình trận → Player cam** (cùng room id) thì overlay
  mới kéo được cam.
- Không sửa binary/app.asar của Client; chỉ gọi IPC/DevTools như bản host.
- `remote-code.mjs` là bản JS thuần của bộ giải mã code dài (giữ đồng bộ với `shared/valorant-remote.ts`),
  `cam.mjs` là bản JS thuần của link vdo.ninja (giữ đồng bộ cùng file).
- Tệp: `app.mjs` (điểm chạy + mở trình duyệt), `ui.mjs` (máy chủ UI cục bộ), `ui/` (trang tĩnh),
  `agent.mjs` (chạy client + đọc tap), `join-code.mjs` (phân giải code dài/ngắn), `join.mjs` (CLI).
