# ValorantCollector riêng (nghiên cứu, đã lưu trữ)

Bản dịch tối thiểu phần observer của Spectra Client thành app Electron/ow-electron không cửa sổ (GEP → ingest, cổng lệnh
loopback có `/status`). Giấy phép GPL-3.0-only, xem `NOTICE.md` và `LICENSE`. **Không còn được runtime dùng.**

Kết luận nghiên cứu (18/10/2026):

- Đường nối hoạt động: collector xác thực với backend Spectra, tạo trận, báo trạng thái GEP/ingest. Các hàm dịch được kiểm
  bằng fixture tổng hợp (`valorant-collector.test.ts`, 5 ca), chưa bằng dữ liệu trận thật.
- Overwolf chỉ cấp gói GEP thật cho app UID đã đăng ký. UID là băm của `productName/name + author.name` trong package.json
  (README ow-electron); UID `ofmfejpggnbkkifikjahkmkgendoajoihppidomd` của collector này nhận gói giả `0.0.0` (log `owpm.log`),
  nên không có roster, scoreboard hay round. Muốn dùng lại phải để Overwolf đăng ký UID cho dự án.
- Không dùng danh tính (name/author) của Spectra và không chỉnh gói GEP để vượt bước đăng ký.

Hướng thay thế đang dùng: `collector/hosts/valorant-collector`, chạy Spectra Client chính thức nguyên vẹn ở dạng ngầm.

Khôi phục để thử: chép thư mục này về `collector/hosts/valorant-collector`, rồi `npm install --ignore-scripts`, chạy
`node node_modules/@overwolf/ow-electron/install.js` và `npx tsc`; nối vào supervisor cần viết lại nhánh khởi chạy
(xem lịch sử Git trước commit lưu trữ).
