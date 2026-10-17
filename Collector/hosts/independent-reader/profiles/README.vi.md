# Tạo profile từ game.exe — thử nghiệm

`resolve_profile.py` đọc file PE AMD64 ở chế độ offline, tìm signature và tạo
profile cho C ABI riêng. Không thực thi file game hay `lblib.dll`, không đăng
nhập BlueBottle và không sửa file game. Cần Python 3.10 trở lên, chỉ dùng thư
viện chuẩn. Profile kết quả luôn là `static-derived`, chưa được kiểm với game.

## Dữ liệu đầu vào

1. File executable **đúng của tiến trình game** đang chạy; không phải launcher.
2. `identity.json` đo bằng host Windows:

```bat
run.cmd --identity --pid 1234 > identity.json
```

Identity có `module`, `version`, `sha256`, `moduleBase`, `processId`,
`measured:true`, `synthetic:false`. PID 1234 là ví dụ. Resolver kiểm tên file
và SHA-256 của file thực; lấy version từ identity. Nó không kiểm độc lập
version resource, không xác thực tác giả của JSON và không chứng minh identity
đã được đo trung thực. Host đo lại identity khi bắt đầu đọc tiến trình.

## Chạy resolver

Trong gói Windows, chạy từ thư mục chứa `run.cmd`:

```bat
python tools\profiles\resolve_profile.py --game-exe "C:\duong-dan\League of Legends.exe" --identity-json identity.json --catalog tools\profiles\profile-catalog.json --profile-out game-profile.json --report-out resolution-report.json
```

Trong source, các file resolver/catalog ở cùng thư mục `profiles/`. Đường dẫn
ví dụ phải thay bằng file thật. Mã thoát 0: có ít nhất một field; 1: không có
field nào được phục hồi; 2: lỗi đầu vào/ghi file. Luôn xem `resolution-report.json`:
`resolvedFields` không đồng nghĩa đủ dữ liệu và `fullParityEstablished:false`
không được tự đổi thành true. Nếu không tạo profile mới, profile cũ tại đường
dẫn output có thể còn; kiểm `profileWritten` trước khi sử dụng. Các đường dẫn
output phải khác nhau và khác mọi input.

Sau khi có profile:

```bat
run.cmd --pid 1234 --profile game-profile.json --allow-unverified-profile
```

Hiện chưa tự tìm hero roots. Có thể đọc field ở root module như `gameTime`
nếu resolve được; `heroes:null` và `waiting-for-roots` là trạng thái đúng khi
chưa biết danh sách đối tượng. Không điền địa chỉ minh họa vào game thật.
Địa chỉ hàm first/next và object manager trong report là dữ liệu để phân tích
tiếp; host không gọi các hàm này trong tiến trình game.

## Phạm vi và giới hạn

Catalog lấy từ initializer của DLL SHA-256
`a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3`:
226 descriptor, 241 biến thể signature, thêm 4 hằng số đã nối với reader.
Catalog chỉ có mapping 13 field đã ghi trong README gốc. Không phải mọi
descriptor đã phục hồi đều là field offset; không dùng cả 214 scalar candidate
như một bảng offset game.

Resolver chỉ tìm trong section executable có bytes trên đĩa. Tất cả biến thể
tìm thấy phải cho cùng giá trị; kết quả mơ hồ, instruction chưa hỗ trợ hay
offset âm bị giữ unresolved. Bộ giải mã giới hạn hỗ trợ match RVA, CALL/JMP
rel32, ADD register/immediate và một số memory operand MOV/LEA/MOVZX/SSE.
Nó không thay thế toàn bộ instruction decoder/getter của DLL gốc. Với SIB,
chỉ lấy displacement; không tái dựng phép tính chỉ số hoặc logic getter.

Giới hạn: PE 512 MiB, 96 section, 512 variant, 256 byte/pattern, 8.192 anchor
hit/pattern, offset tối đa `0x3fffffff`. Không cấp phát toàn bộ SizeOfImage.
File game đổi build/hash cần identity và profile mới; không bảo đảm signature
này tương thích phiên bản khác. Field không resolve bị bỏ khỏi profile và
ghi lý do trong report; field có profile nhưng không đọc được xuất null.

## Kiểm thử

```sh
python3 profiles/test_resolver.py
```

14 test dùng PE tự dựng: sai kiến trúc/range, mẫu trùng, wildcard, section
boundary, các instruction hỗ trợ, offset âm/không hỗ trợ, identity/hash,
JSON trùng key, đường dẫn output và nối profile với C ABI thật. Test nối C ABI
cần build `native/build/liblc_reader.so` trước; thiếu thư viện thì test đó skip.
Không có test nào dùng game/account thật; kết quả nằm trong `test-results.json`.
