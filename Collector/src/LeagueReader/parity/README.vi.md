# Đối chiếu dữ liệu thư viện độc lập với tài khoản hiện tại

Chưa có recording trận thật của LB đã xác thực bằng tài khoản hiện tại; chưa
có recording thư viện độc lập chạy trong game. `current-status.json` vì vậy
phải báo blocked. Những mẫu JSON trong standalone/reference là hư cấu, không
được dùng làm bằng chứng dữ liệu của tài khoản.

## Chạy công cụ

Chỉ cần Python 3, không cần package ngoài, tài khoản hoặc mật khẩu:

```sh
python compare.py --baseline lb-authenticated.ndjson --candidate independent.ndjson --baseline-evidence lb-authenticated.evidence.json --output report.json
python -m unittest discover -s . -p 'test_*.py' -v
```

Nhận file JSON chứa một envelope, mảng envelope, hoặc NDJSON của host.
Mỗi snapshot phải có schemaVersion=1, type=snapshot, synthetic=false,
recordedAt=null, source và data.gameId/data.gameTime. Baseline yêu cầu
source=lblib; candidate phải có nguồn riêng, ví dụ independent. Các frame
status/LCU không được so sánh bằng công cụ snapshot này.

Tùy chọn `--time-tolerance` mặc định 0.15 giây để ghép một-một theo gameTime.
Không nội suy, không tái dùng frame; mẫu không ghép được đều chặn kết quả
matched. Có thể cắt cùng cửa sổ thời gian hoặc điều chỉnh tần suất thu trước
khi so sánh. Tolerance số thực mặc định abs=0.001, rel=0.00001; integer/ID
không dùng tolerance. Hai recording phải có cùng một gameId rõ ràng, kể cả
kiểu JSON; ID khác/thiếu thì không ghép để tạo kết quả có vẻ hợp lệ.
Nếu tua ngược replay làm gameTime giảm, recording bị chặn; hãy cắt riêng từng
cửa sổ tăng thời gian, không tự sắp xếp để biến lần xem khác nhau thành parity.

Report phân biệt missing, null, default_zero, default_false, chuỗi/mảng/object
rỗng. Mỗi nhóm ghi riêng; không suy ra 0/null là do thiếu quyền. Đối tượng
game có info.networkId duy nhất được đối chiếu bằng ID thay vì thứ tự mảng.
Mảng sự kiện vẫn giữ thứ tự: chưa khôi phục ngữ nghĩa stable event ID, vòng
đời lưu giữ hoặc exactly-once; không tự bịa ID từ thời gian/đối tượng.
Số entriesAcrossSnapshots chỉ là tổng phần tử đã quan sát, không phải số
sự kiện duy nhất: một event có thể lặp lại ở nhiều snapshot.

Exit code: 0 = matched_observed_samples, 1 = blocked hoặc different_observed_samples,
2 = input lỗi. matched chỉ là các field trong những mẫu đã ghi. Không khẳng
định parity đầy đủ của Free, sự kiện, LCU, overlay, phiên bản game hay khả năng
thư viện không phụ thuộc DLL gốc. `fullParityEstablished` luôn false ở giai
đoạn này.

## Cần thu trên Windows

1. Dùng LB chính thức đăng nhập tài khoản hiện tại. Ghi rõ phiên bản game,
   phiên bản/hash lblib và cách chạy (spectator hay replay). Tài khoản Free
   là phạm vi người dùng khai báo; không suy từ features=[]/subscription404.
2. Thu raw snapshot từ phiên LB đang thực sự hoạt động cùng một game, không
   dùng demo hoặc frame phát lại đã bọc thành source=replay. Việc xem một
   replay LoL là ngữ cảnh game hợp lệ; phát lại recording JSON là replay
   provenance không hợp lệ cho phép thử runtime này.
3. Thu candidate độc lập trong cùng game/cùng cửa sổ, giữ nguyên source,
   synthetic và gameId thực. Không đổi nhãn JSON để vượt kiểm tra. Nếu gameId
   không có trong đầu đọc mới, đối chiếu vẫn blocked; chưa tự suy luận từ tên file.
4. Bao phủ khởi đầu trận, lên cấp, mua/bán item, hạ lính/tướng, hạ rồng/Baron/
   Herald, phá trụ/nhà lính và hồi sinh; ghi thêm lúc API/kết nối gián đoạn.
   Những cảnh chưa có thì giữ unknown, không suy từ mảng sự kiện rỗng.
5. Tạo sidecar theo baseline-evidence.example.json, điền SHA-256 thật của
   baseline và chỉ đánh true sau khi xác nhận đăng nhập server, DLL đã nhận
   phiên và capture thuộc tài khoản hiện tại. Không gửi token, mật khẩu,
   challenge-response hoặc khóa riêng. Sidecar là lời xác nhận của người
   chạy, không phải chứng minh mật mã mà công cụ tự xác minh.

Nếu LB chính thức không có chức năng xuất raw snapshot, cần adapter thu đúng
nguồn native; ảnh overlay hoặc JSON Live API không thay thế được baseline
native. Collector cũ có thể hỗ trợ ghi dữ liệu, nhưng chỉ việc host hiển thị
authenticated-subscription-unavailable không đủ chứng minh native đã nhận
quyền tài khoản. Cần ghi rõ ngữ cảnh phiên LB chính thức và kết quả nhận dữ liệu.

`baseline-target.json` ghi mục tiêu và các khoảng trống dựa trên mã đã khôi
phục, không phải danh sách field Free đã xác nhận. `native-schema.target.json`
chỉ bảo toàn schema hiện có để tránh bỏ quên field chưa xuất hiện trong capture.
