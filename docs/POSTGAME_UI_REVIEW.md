# Postgame · duyệt UI trước khi tìm nguồn thật

**Cập nhật 13/10:** đã thêm nhánh Riot API bên cạnh bộ mẫu; thao tác/security
và phạm vi kiểm chứng tại [RIOT_API_SETUP](RIOT_API_SETUP.md). Các phần dưới
mô tả baseline mẫu ban đầu, không phải trạng thái nguồn mới. UI sample v1
giữ nguyên; dataset Riot v2 chỉ backend tải được quyền mới có thể publish.

Ngày 13/10/2026. Phạm vi người dùng chốt: thiết kế UI và mẫu dữ liệu trước;
chỉ kiểm chứng/nối data thật sau khi duyệt. Không có adapter postgame live,
không tự kích hoạt theo GameEnd và không lấy số mock in-game làm kết quả thật.

## Cách duyệt

1. Mở Studio `/?page=postgame` → **Nạp bộ mẫu theo ảnh**.
2. Preview là iframe của `/overlay?scene=postgame`, nhận cùng snapshot backend.
3. Thử đổi đội thắng, thiếu dữ liệu, xóa mẫu; mở JSON để nhập/xuất.
4. Đổi tên đội, logo tùy chọn, màu và tên giải trong cấu hình trước trận,
   lưu; postgame nhận cùng theme realtime. Không có logo vẫn hiển thị tên đội.

Graphic 1920×1080: header kết quả/time, dải tên giải, tám hàng thống kê + bans
bên trái, damage của 10 người theo đường, biểu đồ vàng và nhận diện giải bên
phải. Không dùng logo/sponsor Riot/AWS. Nền graphic là CSS 2D, graph là SVG;
không cần ảnh AI, renderer 3D hay thư viện chart. Body OBS vẫn trong suốt;
bản thân bảng tổng kết phủ khung hình giống mẫu.

## Contract phiên bản 1

`shared/postgame.ts`: Zod validation dùng chung import/backend và type renderer.

- `source: "sample"`: hiện **chỉ** nhận bộ mẫu, từ chối nhãn live. Graphic luôn
  có nhãn mẫu để tránh nhầm khi mở URL overlay.
- `assetVersion: "15.20.1"`: baseline demo đã chốt, không suy patch trận thật.
- `winner: "blue" | "red" | null`, `duration` giây hoặc null, `gameNumber`.
- `teams: [blue, red]`: kills/deaths/assists/gold/towers/drakes/elders/barons/
  heralds/grubs; giá trị chưa có là null, khác số 0.
- Mỗi đội có 5 bans (champion code hoặc null), 5 players theo thứ tự cố định
  TOP/JUNGLE/MID/BOT/SUPPORT; mỗi player có champion code và damage to champions.
- `goldHistory: [{at, delta}]`: at là giây game tăng nghiêm ngặt, delta =
  blue gold − red gold. delta null ngắt đường; không nội suy qua khoảng thiếu.
  Tối đa 2.000 điểm, import file tối đa 500 KB. Adapter thật sau này cần
  downsample history riêng, không đẩy raw provider payload vào widget.

Số tổng đội, damage và thời gian mẫu phỏng theo ảnh người dùng. Tướng, bans
và các điểm đường vàng là minh họa, không phải dữ liệu của trận trong ảnh.
Endpoint mẫu 12.000G khớp 66.800 − 54.800; không cố sao chép nhãn 11.902 trên
ảnh vì các tổng vàng ở ảnh được làm tròn. Damage hai bên chung scale lớn nhất.
Tên/logo đội không nhân bản vào mẫu; lấy trực tiếp theme hiện hành.

Command `postgameState` đồng bộ bộ mẫu giữa Studio/OBS; null xóa. Không đổi
telemetry, draft, scene, game clock hoặc theme. Bộ mẫu không persist khi restart;
có thể xuất JSON để giữ. Khi chưa nạp chỉ hiện trạng thái chờ, không tự tạo kết quả.

## Kiểm chứng / giới hạn

- `npm run build`, `npm test`, `npm run test:integration`.
- `scripts/verify/postgame-smoke.mjs`: backend QA riêng, Edge 1920×1080 và 1280×720;
  Studio 1280×800. Kiểm tra icon/font, 10 damage players, 10 bans, hai đội thắng,
  khoảng thiếu, validation import/export, frame OBS thật, body trong suốt,
  căn đều hai cột damage và graph nằm trong panel.
- Ảnh QA: `.npm-cache/visual-audit/postgame-sample-v2.png`.
- Đây là thiết kế đang chờ duyệt, không tuyên bố độ giống 95–98%.
- Winner, damage tổng kết và lịch sử vàng live chưa kiểm chứng; các capture
  hiện có không tự chứng minh đủ dữ liệu end-game. Bước tiếp: người dùng duyệt
  bố cục rồi mới lập phiên capture/kiểm chứng nguồn thật.
