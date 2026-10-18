# Collector Valorant: Spectra Client chính thức chạy ngầm

`official.mjs` chạy **Spectra Client chính thức, nguyên vẹn** (danh tính Overwolf đã đăng ký của Spectra) ở dạng ngầm cùng Studio.
Không sửa binary hay `app.asar`. `release.json` ghim bản (v0.3.4), URL tải, SHA256 của gói và của exe.

- **Tải khi chưa có:** `acquireOfficial` tải gói một lần, kiểm SHA256, giải nén bằng `7za` của gói npm `7zip-bin` (không cần cài 7-Zip),
  kiểm lại SHA256 của exe. Studio gọi bước này khi bật kết nối lần đầu (`collector/hosts/valorant-collector/runtime/setup.mjs`); cũng chạy tay bằng `npm run valorant:setup`.
  Thư mục cài: `collector/hosts/valorant-collector/local/spectra/0.3.4` (bị Git bỏ qua).
- **Chạy ngầm:** profile riêng `collector/hosts/valorant-collector/local/spectra/official-profile` (`--user-data-dir`), cổng DevTools loopback ngẫu nhiên; một PowerShell nền
  ẩn cửa sổ của đúng process Client và đọc tiêu đề (Ready/Connected). Process ngầm còn sót lần trước (cùng profile) được dọn khi khởi động.
- **Tự cấu hình:** chờ GEP "Ready", điền form bằng chính giao diện của Client từ `collector/hosts/valorant-collector/local/match-config.json`, **tắt toàn bộ phím nóng toàn cục**
  (Client mặc định đăng ký F10, O, P, I và nuốt phím gõ ở mọi ứng dụng), rồi bấm Connect; từ chối kết nối nếu phím nóng còn bật.
- **Điều khiển:** lệnh thủ công và cấu hình giữa trận đi qua controller của Studio (`server/valorant-controller.ts`), một phiên observer thứ hai dùng bí mật
  trận trong `official-profile/storage/matchSecret.json`; nó chỉ logon khi backend đã có trận do Client tạo và không bao giờ tạo trận.
- **Giới hạn:** script điền form gắn với bản 0.3.4 (id ô nhập, nút Connect); đổi phiên bản phải kiểm lại. Log của chính Client có ghi key local, nằm trong `data/`.

Collector riêng (bản dịch tối thiểu của Spectra Client) đã được nghiên cứu và lưu ở `collector/archive/valorant-collector`; nó không nhận được GEP thật
vì app UID Overwolf của dự án chưa đăng ký, xem README trong thư mục đó.
