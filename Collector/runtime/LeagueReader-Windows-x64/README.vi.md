# LeagueReader — thư viện riêng, bản thử nghiệm 0.1

Đã có mã C++ và DLL Windows x64 riêng, cùng host .NET không tham chiếu
Farsight, AWS hoặc `lblib.dll`. Reader này không đăng nhập và không gọi server
BlueBottle. **Chưa đạt mục tiêu tương đương dữ liệu tài khoản hiện tại.**

Đây là nhánh thử nghiệm riêng; gói collector dùng DLL gốc đã bàn giao trước
vẫn là mốc so sánh. Hai gói không được coi là cùng một triển khai.

## Đã thực hiện

- Phục hồi initializer bằng đánh giá hằng số tĩnh: 226 descriptor, 241 mẫu
  tìm kiếm và 214 global scalar candidate. Không nạp/chạy DLL gốc.
- Lần theo native reader/schema và ánh xạ 13 field đầu tiên. Các offset cố
  định được lấy từ initializer; các offset còn lại phải tìm trong game.exe.
- C++17 core có C ABI, đọc qua callback hoặc Win32 ReadProcessMemory, xuất
  JSON; không ghi bộ nhớ game. Windows DLL được cross-build từ source.
- Host độc lập cung cấp HTTP/WebSocket, kiểm tra identity của process/module
  và hỗ trợ nguồn bộ nhớ fixture được gắn nhãn synthetic.
- Có công cụ tạo profile từ PE game và công cụ đối chiếu recording với
  baseline. Profile tĩnh không được tự nâng thành runtime-verified.

## Phạm vi dữ liệu hiện tại

Catalog hiện ánh xạ các field sau, không có nghĩa chúng đã được đo đúng trong
game hoặc account Free đã xác nhận:

| Root | Field |
|---|---|
| Module game | gameTime |
| Hero | info.networkId, info.index, info.team, info.position |
| Hero | common.health, common.maxHealth |
| Hero | gold, totalGold, experience, resource, maxResource, resourceType |

Chỉ field resolve được mới đưa vào profile. Field đã có profile nhưng đọc
lỗi được xuất null kèm diagnostic; field chưa triển khai giữ vắng. Không
điền giả KDA, tên tướng, spell, item, perk, buff, objective hay gameId.

## Những phần còn thiếu

- Chưa tự khám phá đủ danh sách hero/đối tượng. Hiện core nhận địa chỉ hero
  do caller cung cấp; không biết roots thì heroes=null, không giả thành [].
- Chưa tái triển khai layout/component và reader cho KDA, level, CS, name,
  champion identifier, spells/items/perks/buffs và các kiểu phức tạp khác.
- Chưa thu các callback sự kiện game, phân loại hạ rồng/Baron, timer và lớp
  tổng hợp overlay giống LB. HTTP/WebSocket snapshot không thay thế event bus.
- Chưa có game.exe thực, dump bộ nhớ game hoặc recording LB đã xác thực của
  tài khoản hiện tại trong môi trường cloud này để hoàn thành resolver và
  đối chiếu. Người dùng sẽ cung cấp kết quả Windows sau.
- Windows DLL và Win32 adapter chưa được thực thi ở game thật. Kiểm tra PE,
  build Linux và fixture không xác nhận game parity hoặc toàn bộ dữ liệu Free.

## Cấu trúc source

- `native/`: C++ core, public header, Windows read adapter, build và tests.
- `host/`: host .NET độc lập; xem README và launcher của host.
- `profiles/`: catalog khôi phục, resolver PE và tests; cần Python 3.
- `parity/`: đối chiếu mẫu có provenance, không suy quyền Free từ features rỗng.
- `analysis/native/` trong gói source: pseudocode/bằng chứng phục hồi, không
  phải source C++ gốc có thể biên dịch. DLL gốc không cần để build/run reader.

`native/README.vi.md` mô tả C ABI và profile. `profiles/README.vi.md` hướng dẫn
resolve offset từ game.exe có identity khớp; `host/README.vi.md` hướng dẫn
chạy HTTP/WebSocket. Không dùng profile fixture cho game thật.

## Điều kiện xác nhận hoàn tất

Phải thu được cùng game/cửa sổ thời gian với LB hoạt động bằng tài khoản hiện
tại, xác định rõ field còn thiếu và đối chiếu giá trị/sự kiện. Mục tiêu đầy đủ
vẫn pending; sự tồn tại của DLL riêng hoặc một snapshot giả lập không đủ để
đánh dấu hoàn tất.
