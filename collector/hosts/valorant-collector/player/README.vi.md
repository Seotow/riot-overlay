# Bản player (đẩy dữ liệu về host)

Để host lấy đủ dữ liệu 10 người (máu, chiêu, tiền chính xác), **mỗi player** chạy bản này trên máy
mình. Nó dùng lại Spectra Client chính thức chạy ngầm (giống host), chỉ đổi đích về ingest công khai
của host qua tunnel. Player **chỉ cần nhập một code ngắn** do host cung cấp — không cần cùng mạng LAN.

## Cách dùng

1. Host mở Studio → Valorant → Phát sóng → bật **"Player đẩy dữ liệu (ngoài LAN)"**, chép **code** và
   gửi riêng cho từng player (code chứa key, không đăng công khai).
2. Player chạy:

   ```bash
   node collector/hosts/valorant-collector/player/join.mjs <CODE>
   ```

   hoặc `npm run valorant:player -- <CODE>`. Bỏ trống `<CODE>` thì chương trình sẽ hỏi.
3. Lần đầu, Spectra Client được tải một lần (kiểm SHA256) rồi chạy ngầm (cửa sổ ẩn). Player cứ vào trận
   bình thường; dữ liệu tự đẩy về host. Nhấn `Ctrl+C` để dừng.

## Ghi chú

- Code chỉ dùng được khi host đang bật tunnel. Mỗi lần host bật lại, URL `trycloudflare.com` đổi nên
  **code cũng đổi** — xin host code mới.
- Không sửa binary/app.asar của Client; chỉ điền form và bấm Connect qua DevTools như bản host.
- `remote-code.mjs` là bản JS thuần của bộ giải mã (giữ đồng bộ với `shared/valorant-remote.ts`).
