# Bản player (đẩy dữ liệu + cam về host)

Để host lấy đủ dữ liệu 10 người (máu, chiêu, tiền chính xác), **mỗi player** chạy bản này trên máy
mình. Nó dùng lại Spectra Client chính thức chạy ngầm (giống host), chỉ đổi đích về ingest công khai
của host qua tunnel. Player **chỉ cần nhập một code 5 ký tự** do host cung cấp — không cần cùng mạng LAN.

## Cách dùng (có UI)

1. Host mở Studio → Valorant → Phát sóng → bật **"Player đẩy dữ liệu (ngoài LAN)"** và gửi **code 5 ký
   tự** cho từng player (ví dụ `K7M2P`). Hoặc host tự chạy `npm run valorant:code` để mở tunnel và in
   code mà không cần Studio.
2. Player chạy:

   ```bash
   npm run valorant:player
   ```

   Trình duyệt mở `http://127.0.0.1:5398/`. Nhập code vào ô đầu — vừa đủ 5 ký tự là tự gửi, khỏi bấm
   nút.
3. Trang hiện trạng thái kết nối và tên player. Lần đầu,
   Spectra Client được tải một lần (kiểm SHA256) rồi chạy ngầm (cửa sổ ẩn); cứ vào trận bình thường.
4. **Camera tự kết nối, không phải bấm gì thêm.** Code mang sẵn mã camera được sinh từ mã tunnel;
   khi client đọc được tên player từ trận, camera tự đẩy hình. Nút **Preview camera** chỉ xem thử
   webcam; nút **Mở camera** bắt đầu đẩy hình. Microphone và âm thanh hai chiều luôn tắt.

Tên player do client tự đọc từ trận và chỉ hiển thị trong thông tin kết nối.

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

Bảo mật: topic công khai, ai biết code đều đọc được địa chỉ + mã camera, nên code phải chia sẻ riêng.
Code ngắn **không chứa key**; nó chỉ dùng được ở chế độ **auxiliary** (đúng thứ player cần). Code dài
base64 cũ vẫn nhập được (nó mang cả key) — dùng khi điểm hẹn không truy cập được.

## Ghi chú

- Vào trận rồi client mới đăng nhập được: chế độ auxiliary cần `match_id` của trận để khớp với host, nên
  cứ để trang chạy, client tự thử lại cho tới khi `Connected`.
- Khi client của bạn đăng nhập (auxiliary), host **tự thêm** Riot ID của bạn vào **Player cam**.
  Studio chỉ hiển thị camera đã kết nối và nút preview, không cần nhập room hoặc tên player.
- Không sửa binary/app.asar của Client; chỉ gọi IPC/DevTools như bản host.
- `remote-code.mjs` là bản JS thuần của bộ giải mã code dài (giữ đồng bộ với `shared/valorant-remote.ts`),
  `cam.mjs` là bản JS thuần của link vdo.ninja (giữ đồng bộ cùng file).
- Tệp: `app.mjs` (điểm chạy + mở trình duyệt), `ui.mjs` (máy chủ UI cục bộ), `ui/` (trang tĩnh),
  `agent.mjs` (chạy client + đọc tap), `join-code.mjs` (phân giải code dài/ngắn), `join.mjs` (CLI).
