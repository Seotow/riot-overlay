# Cài đặt, chuyển máy và đưa lên Git

## Cài trên máy mới

Khuyến nghị Node.js 24 và npm đi kèm. Mở terminal tại thư mục có `package.json` sau khi clone hoặc giải nén source.

```powershell
npm ci
npm run build
npm start
```

Giữ terminal backend đang chạy. Studio: http://127.0.0.1:4310/ . OBS Browser Source: http://127.0.0.1:4310/overlay , kích thước 1920×1080. Địa chỉ này chỉ trỏ đến máy đang chạy backend.

Để sửa source với frontend tự cập nhật:

```powershell
npm run dev
```

Dừng phiên trước bằng Ctrl+C trước khi mở phiên mới trên cùng port. `npm start` phục vụ bản `dist` đã build; sửa frontend rồi dùng chế độ này thì phải build lại và reload trình duyệt. `tsx` là devDependency nhưng hiện cũng được dùng để chạy backend, vì vậy **không dùng `npm ci --omit=dev`** với cấu trúc hiện tại.

## Asset và theme

Commit `public/ddragon`, `public/references`, `shared/generated/catalog.json` và hai ảnh gốc để bản clone có đủ tài nguyên. Font cài qua package-lock và bundle khi build. Không cần tải lại Data Dragon để chạy bản đã có assets.

Nếu cần phục hồi asset demo, dùng `npm run assets:sync` khi có mạng. Script dùng version demo cố định; không coi đây là bộ cập nhật asset live.

`data/` bị loại khỏi Git. Để chuyển theme cá nhân: Export trong Studio máy cũ, Import trên máy mới. Hoặc copy riêng `data/theme.json` khi backend đã dừng. Theme baseline nằm trong source; chọn **Theme & layout → Khớp ảnh mẫu** nếu muốn áp dụng lại preset.

## Kiểm tra

```powershell
npm test
```

Với backend đang chạy, mở terminal khác:

```powershell
npx tsx tests/transport.integration.ts
```

Integration test thay đổi và reset dữ liệu mock; không chạy trong một phiên đang phát sóng. Kiểm tra thêm Studio báo kết nối, chuyển draft/in-game và mở OBS renderer. Hiện ứng dụng chưa kết nối LoL thật.

## Chuẩn bị repository

Nên dùng repository private vì có ảnh tham chiếu và nhận diện giải. Theo dõi source, tests, scripts, `public`, tài liệu, `package.json`, `package-lock.json`, cấu hình TypeScript và `.gitignore`.

Không đưa `node_modules`, `.npm-cache`, `dist`, `.research`, `data`, log hoặc credentials vào Git. Không phụ thuộc đường dẫn tuyệt đối `D:\Workspace\Riot-overlay`; mọi lệnh chạy từ thư mục clone trên máy mới.

Nếu thư mục chưa có Git, có thể khởi tạo bằng `git init`. Trước khi commit/push, kiểm tra `git status --short` và diff staged. Chỉ thêm remote và push đến repository do chủ dự án chọn. Việc bổ sung bộ tài liệu này không tự tạo remote hoặc push code.

Để Codex trên máy mới tiếp tục, mở thư mục clone làm workspace và yêu cầu: “Đọc AGENTS.md, PROJECT_STATUS.md và ROADMAP.md; xác minh project chạy được rồi tiếp tục giai đoạn 1 chẩn đoán dữ liệu LoL. Giữ baseline UI đã duyệt.”

## Lỗi thường gặp

- Trang không kết nối: xác nhận backend đang chạy và không có lỗi port đã dùng; không cần đổi cấu hình firewall để chạy loopback.
- Theme khác baseline: theme local được ưu tiên; áp dụng preset hoặc import theme mong muốn.
- Ảnh thiếu: xác nhận các file trong `public/ddragon` đã được clone và build lại.
- Windows báo EPERM tại `dist/assets`: dừng tiến trình đang giữ file rồi build lại. Có thể dùng `npm run build -- --emptyOutDir false` để kiểm tra tạm; cách này giữ asset cũ, không phải clean build.
- Các lỗi quyền của môi trường agent không đồng nghĩa lỗi source; kiểm tra lại bằng terminal bình thường trước khi sửa kiến trúc.
