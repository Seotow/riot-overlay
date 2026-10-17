# Đính chính về nhánh không đăng nhập

Kết luận hiện tại: chưa chứng minh collector có thể thu đủ dữ liệu LB Free
và duy trì phiên khi không xác thực. Tài khoản Free đã xác thực và client có
FeatureSet.Empty là hai trạng thái không được coi tương đương chỉ từ mã C#.

## Những gì đã xác nhận tĩnh

- LeagueConnector.RequestFeatures trả true ngay khi features.IsEmpty. Điều
  này chỉ là quyết định của managed client, không phải xác nhận từ DLL.
- Gate đăng ký service LB snapshot không yêu cầu Develop tại gate đó. Quyền
  đi tới gate này còn phụ thuộc trạng thái phiên và policy của transport.
- Constructor native 0x1803bd780 đặt trạng thái ở +0x38 và deadline ở +0x40.
  Một nhánh dùng deadline tối đa, nhánh còn lại dùng thời gian hiện tại cộng
  30000000000 tick. Callsite TCP đã đối chiếu truyền cờ deadline bằng 0;
  callsite named pipe truyền các cờ lấy từ kết quả phân loại client.
- Đối chiếu assembly 0x1803bdd40: khi hiện tại >= deadline và trạng thái đang
  là 0, hàm chuyển trạng thái sang 2, xóa cờ hoạt động, báo dừng và gọi virtual
  close. Dispatcher gọi hàm này trước khi xử lý request.
- Dispatcher 0x1803db830 kiểm tra predicate của client. Với nhánh cần proof,
  trước trạng thái 1 chỉ một tập request được phép; request ngoài tập này đi
  tới nhánh đóng kết nối. Đây không phải điều kiện áp cho mọi client TCP.
- AuthenticationVerify 0x1803e6780 có nhánh thất bại xóa feature và đóng phiên.
  Nhánh cần proof còn kiểm tra Develop, deadline và trạng thái. Các trường
  hợp khác có policy khác; không suy rộng yêu cầu Develop sang tài khoản Free.
- Snapshot tick truyền feature của từng client cho serializer; nhiều helper
  có bộ lọc field/event theo feature. Được kết nối không đồng nghĩa đủ dữ liệu.
- Native có chia sẻ hợp feature trong cùng tiến trình cho một số client;
  kết quả khi LB khác đã chạy không đủ chứng minh một phiên độc lập từ đầu.

## Điều chưa được chứng minh

- Client độc lập với bộ quyền rỗng có khởi tạo game thành công, giữ kết nối
  và nhận đủ trường/sự kiện Free hay không.
- Các điều kiện khởi tạo toàn cục và phụ thuộc chưa được lần theo hết.
- Hành vi thực tế của cùng bản DLL trên Windows/game phù hợp. Chưa có capture.

Lần đăng nhập trước thành công nhưng subscription lookup trả 404 và host giữ
features rỗng. Đây không phải bằng chứng server đã xác nhận đầy đủ quyền Free.

Nhận định của người dùng rằng thiếu auth có thể gây dữ liệu trống/ngắt kết
nối phù hợp với các cơ chế đã thấy, nhưng chưa đủ bằng chứng để kết luận
mọi loại kết nối không auth đều có cùng hành vi.

Nguồn: native/pseudocode/0x1803bd780_initialize_client_session.cpp,
0x1803db830_dispatch_requests.cpp, 0x1803e6780_verify_feature_challenge.cpp,
0x180410710_leaguebroadcast_snapshot_tick.cpp; native/tcp-session-constructor-assembly.txt,
pipe-session-constructor-assembly.txt và client-auth-deadline-assembly.txt.
Đường dẫn native tính từ /workspace/leaguebroadcast. Đây là phân tích tĩnh;
không thực thi hay sửa DLL.
