# Nguồn gốc và giấy phép

Collector này **dịch lại và tái sử dụng** các phần cần thiết của **Spectra Client** (ValoSpectra, Purple Shark UG),
https://github.com/ValoSpectra/Spectra-Client, revision `a07fd0853129a549ac4d657544ae1e0b93e4f5e8` (v0.3.3),
giấy phép **GPL-3.0-only** (xem `LICENSE`). Vì vậy thư mục này là tác phẩm phái sinh và giữ GPL-3.0-only;
phần còn lại của Riot Overlay không bị trộn mã GPL, hai bên chỉ nói chuyện qua socket/HTTP loopback.

| File | Lấy từ Spectra Client | Thay đổi |
| --- | --- | --- |
| `src/protocol.ts` | `services/formattingService.ts` | Chỉ giữ nhánh observer: kiểu dữ liệu, `DataTypes`, các hàm format scoreboard/roster/killfeed/round |
| `src/gep.ts` | `services/gepService.ts` | Chỉ giữ nhánh observer; bỏ Auxiliary, UI, cập nhật; trạng thái đi qua `/status` thay vì cửa sổ |
| `src/ingest.ts` | `services/connectorService.ts` | Chỉ giữ kết nối observer, logon lại mỗi lần socket nối lại; bỏ cửa sổ, hộp thoại, Auxiliary |
| `src/control.ts` | `services/hotkeyService.ts` | Phím nóng thay bằng cổng lệnh loopback có token (cùng dữ liệu gửi lên ingest) |
| `src/config.ts`, `src/main.ts`, `src/log.ts` | tham khảo `main.ts` | Viết lại: không cửa sổ, không tray, không kiểm tra cập nhật, profile riêng |

Không có giao diện Angular, updater, deeplink, Discord hay Playercams của Spectra Client. Không thay đổi giao thức
ingest, không bỏ qua xác thực, watermark hay cơ chế license của Spectra Server. Giá trị `clientVersion` gửi lên là
phiên bản giao thức ingest mà collector này cài đặt (`0.3.3`), không phải bản phát hành của Spectra.

Overwolf GEP vẫn bắt buộc: gói `gep` do runtime `@overwolf/ow-electron` của Overwolf cung cấp khi chạy;
repo này không chứa và không sửa runtime đó.
