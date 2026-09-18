# Lộ trình tiếp theo — ưu tiên LoL

Baseline UI draft/in-game đã được người dùng duyệt. Lộ trình dưới đây chưa phải danh sách tính năng đã triển khai.

## 1. Chẩn đoán nguồn dữ liệu local

Xây công cụ chỉ đọc và màn hình trạng thái nguồn. Kiểm tra client đang mở, game phase và các endpoint thực tế khả dụng. Hướng dẫn người dùng lần lượt mở client → lobby → chọn tướng → spectator → kết thúc trận. Không giả định endpoint từng dùng trong toolkit cũ còn hoạt động.

Đầu ra: bảng field pre-game/in-game/postgame có nguồn, kiểu dữ liệu, availability, độ trễ quan sát, giới hạn và mẫu payload đã loại credentials. Bao gồm picks/bans, champion ID, level, KDA, CS, item, gold, objective, inhibitor. Điều kiện xong: từng field quan trọng có bằng chứng hoặc được đánh dấu chưa kiểm chứng/không khả dụng.

## 2. Observer Agent

Tách collector và adapter; chuẩn hóa envelope theo session/sequence/gameTime, reconnect và phát hiện mất nguồn. Ghi phiên đã lọc dữ liệu nhạy cảm để có thể replay khi phát triển. Credentials local ở lại máy observer.

Điều kiện xong: thu được phiên chọn tướng và spectator, backend nhận ổn định, reconnect không trộn hai trận. Chỉ mở kết nối nhiều máy sau khi có xác thực và cấu hình rõ ràng.

## 3. Nối dữ liệu thật vào overlay

Thay từng nhóm mock bằng field đã xác minh. Đưa số liệu đang hardcode về state contract; tách branding khỏi match data. Studio hiển thị trạng thái nguồn, field thiếu và hỗ trợ nhập tay những phần production cần.

Điều kiện xong: draft/in-game chạy với dữ liệu thật; không biến field thiếu thành số 0 hoặc số mock; mất nguồn không giữ dữ liệu cũ như đang live. Giữ chế độ mock để thử UI.

## 4. Widget nâng cao

Triển khai leaderboard level/gold, objective timer và inhibitor timer theo nguồn thực sự thu được. Kiểm thử spectator delay, pause, replay seek, reconnect và event trùng. Phân biệt dữ liệu quan sát trực tiếp với dữ liệu suy ra.

Nếu API thiếu, đánh giá nhập tay hoặc nhận diện màn hình cho từng field, kèm độ tin cậy; không mặc định OCR toàn màn hình. Điều kiện xong: mỗi widget có quy tắc, nguồn và cách xử lý không chắc chắn rõ ràng.

## 5. Tùy biến và đóng gói

Logo/font riêng, vị trí/kích thước từng widget, preset có migration, hướng dẫn OBS và bản khởi động thuận tiện. Thu bộ nhận diện gốc khi đến bước này. Quyết định lưu trữ production config/event log (file hoặc SQLite) dựa trên yêu cầu thực tế.

Điều kiện xong: thiết lập giải mới không sửa code, chuyển máy được, dữ liệu cá nhân và credentials tách khỏi source.

## Ngoài phạm vi hiện tại

Valorant và TFT khảo sát sau khi đường thu dữ liệu LoL ổn định. Các project tham khảo ban đầu: Riot Developer Portal, RCVolus/league-prod-toolkit, League Broadcast và ValoSpectra/Spectra-Client. Thông tin API/chính sách có thể đổi; cần kiểm chứng lại từ nguồn chính thức khi bắt đầu adapter tương ứng.
