# Studio

## Vận hành

1. Vào **Cấu hình trận đấu** để nhập đội, tỉ số, logo và tên tuyển thủ.
   Bấm **Lưu cấu hình**. Có thể lưu hoặc nhập lại file JSON.
2. Chọn nguồn tại **Nguồn dữ liệu**. Kiểm tra số người chơi và dữ liệu khả dụng.
3. Mở **Phát sóng**. Preview bên trái là đầu ra OBS; các nút bên phải bật/tắt
   leaderboard, rune, layout tối giản và timer nhà lính. Trạng thái nút đang
   bật được tô màu và có `aria-pressed`.
4. **Phòng thử** dùng bản ghi thật, có thanh tiến độ và tốc độ phát.
   Bản ghi không tự thay thế nguồn trận khi chỉ mở trang.
5. **Cấm chọn**, **Sau trận** và **HUD trong game** giữ chức năng hiện tại.
   Dữ liệu mẫu và các giới hạn nguồn vẫn được ghi rõ.

Ảnh đối chiếu chỉ dùng trong Studio, không xuất sang OBS. Các thông tin kỹ
thuật nằm trong mục thu gọn. Không xóa dữ liệu khỏi nguồn khi ẩn một đồ họa.

## Giao diện và phát triển

Studio dùng các component shadcn/ui chính thức, style `new-york`: Button,
Card, Badge, Input, NativeSelect, Textarea và Separator; icon Lucide.
Các component được lưu trong `src/components/ui`, cấu hình ở `components.json`.
`src/studio.css` chứa theme xám trung tính và bố cục riêng cho Studio.

Tailwind4 chỉ nhập theme/utilities, **không nhập preflight**. CSS Studio được
scope bằng `.studio-shell`; không đổi source của `src/overlay`, backend hoặc
schema dữ liệu trong lần trùng tu này. Font Studio là Segoe UI; font phát sóng
giữ nguyên. Layout OBS vẫn 1920×1080, nền trong suốt, chỉ nhận dữ liệu.

Menu chính chỉ hiện các công cụ LoL đang dùng. Module Valorant/REA và tài liệu
nghiên cứu không bị xóa; chúng không được dùng làm nội dung lấp chỗ trống.

Nguồn component: [shadcn/ui](https://ui.shadcn.com/docs/installation/vite).
Không dùng ảnh AI hay thư viện ảnh trang trí cho Studio.

## Kiểm tra

```powershell
npm ci
npm run build
npm test
npx tsx tests/system.integration.ts
```

`scripts/verify/verify-studio-shadcn.mjs` chạy Edge headless trên backend QA riêng 4393,
theme riêng. Kiểm 8 route, lưu config, toggle widget, phát/tạm dừng recording,
responsive 900px và renderer OBS trong suốt. Ảnh/report tại
`.npm-cache/studio-shadcn-qa/`. Không chạy script này trên backend operator.

`npm audit` sau cập nhật dependency không còn vulnerability được báo.
Những giới hạn native stack/damage/EOG không thay đổi; xem báo cáo phase.
