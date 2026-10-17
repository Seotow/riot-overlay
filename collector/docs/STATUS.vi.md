# Trạng thái bàn giao: 2026-10-14-status-update

> Trạng thái gói trước import. Xem [STATUS-PLAN.vi.md](STATUS-PLAN.vi.md) cho
> bàn giao local mới nhất, validation đã restore và nhánh reader độc lập.

Phạm vi mong muốn là dữ liệu tương đương tài khoản LB Free. Bản này phục vụ
chạy thử trên Windows; chưa phải collector đã được xác nhận hoàn chỉnh.

## Đã có

- Host độc lập với giao diện/tiến trình ứng dụng LB: JSON HTTP, WebSocket,
  LCU chọn tướng, overlay mẫu, ghi/phát lại NDJSON.
- Mã managed Farsight đã khôi phục và build lại. HTTP/WebSocket, serializer,
  LCU và Live API đã kiểm thử bằng dữ liệu giả lập trên Linux.
- Đăng nhập BlueBottle đã thành công ở lần kiểm tra trước; subscription lookup
  trả 404. Không có bằng chứng server đã xác nhận đầy đủ quyền Free.
- Đã phân tích tĩnh 246 hàm native có chọn lọc và xác định luồng IPC/snapshot,
  một số bộ lọc quyền, trạng thái và thời hạn phiên. Không phải toàn bộ DLL.

## Những điều chưa được chứng minh

- Thu dữ liệu native trong LoL thật trên Windows; chạy lâu, kết nối lại,
  đổi trận, OBS và tương thích game patch.
- Đủ mọi trường/sự kiện mà LB Free trả trong cùng một trận.
- Chạy không đăng nhập vẫn giữ kết nối và nhận đủ dữ liệu Free. Nhánh C#
  FeatureSet.Empty trả true không phải xác nhận của DLL. Tài khoản Free đã
  xác thực và client chưa xác thực phải được phân biệt.

DLL có nhánh đóng phiên khi hết hạn/xác thực không hợp lệ và có lọc dữ liệu
theo quyền. TCP/named pipe và mức tin cậy của client có policy khác nhau;
chưa thể kết luận mọi client không auth đều bị ngắt. Chi tiết ở
[AUTH-STATUS.vi.md](../archive/cloud-export/RiotOverlay-local/cloud-project/standalone/reference/AUTH-STATUS.vi.md).

## Phụ thuộc và phần còn thiếu

- Native vẫn là `lblib.dll` chính thức đã tải hợp lệ; không thay đổi byte.
  SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3.
- Chưa tái dựng C++ đủ để build DLL thay thế. Pseudocode trong gói source là
  kết quả decompiler, không phải source C++ gốc có thể biên dịch.
- Host xuất sự kiện native thô; chưa tích hợp lớp nhận diện rồng/Baron,
  timer mục tiêu, tổng hợp scoreboard và asset/config giống toàn bộ LB Free.
- Serializer chưa xuất một số inline vector trong native struct, chẳng hạn
  assister IDs; một số property tính toán của Farsight không xuất có chủ đích.
- WebSocket ưu tiên snapshot mới, không phải luồng sự kiện bảo đảm không mất.
  Ghi NDJSON cũng có queue; cần kiểm tra `recording.dropped` khi đánh giá bản ghi.

## Thay đổi của bản cập nhật này

- Thêm `validation` trong `/api/status` và `--doctor`, hiển thị giới hạn ngay
  trên dashboard. Nhãn trạng thái không tự suy ra Free từ bộ quyền rỗng.
- Thêm `--export-diagnostics`, `export-diagnostics.cmd`, `start-test.cmd` và
  hướng dẫn [WINDOWS-TEST.vi.md](../archive/cloud-export/RiotOverlay-local/cloud-project/standalone/WINDOWS-TEST.vi.md).
- Đưa tài liệu endpoint, field, ví dụ JSON và ghi chú auth vào cả hai gói.
- Gói source có host, managed vendor, dependency DLL, native DLL, script build,
  kiểm thử và pseudocode native đã khôi phục. Không chứa mật khẩu/token tài khoản.

Luồng xác thực và DLL native không được sửa trong bản cập nhật trạng thái này.
Kết quả kiểm thử được lưu ở `verification/`; kiểm thử giả lập không thay cho
việc so sánh với LB Free trên Windows.
