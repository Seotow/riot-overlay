# Lõi đọc bộ nhớ độc lập — trạng thái thử nghiệm

Đây là mã C++17 tự viết để đọc dữ liệu từ callback bộ nhớ read-only và xuất JSON. Nó không nạp, gọi hay đóng gói `lblib.dll`, không gọi BlueBottle và không yêu cầu tài khoản BlueBottle. Đây **chưa phải thư viện thay thế LB đã chạy được với game thật**: object discovery và profile LoL đủ bằng chứng vẫn còn thiếu.

Không có injection, ghi bộ nhớ, gọi hàm trong game hoặc cơ chế vượt bảo vệ. Win32 adapter chỉ dùng `OpenProcess(PROCESS_VM_READ | PROCESS_QUERY_LIMITED_INFORMATION)` và `ReadProcessMemory`. Nếu hệ điều hành từ chối quyền đọc, adapter trả lỗi.

## Những gì đã kiểm tra

- Build Linux bằng g++, C++17, `-Wall -Wextra -Wpedantic -Werror`.
- Kiểm thử qua C ABI với sparse memory: position, HP, gold, KDA, pointer chain và chuỗi UTF-8.
- Trường không đọc được, con trỏ sai, NaN/infinity xuất `null` cùng lý do; giữ nguyên giá trị 0 đọc thành công.
- Từ chối module/version/SHA-256 không khớp trước khi thực hiện lần đọc đầu tiên.
- Giới hạn số field, chain, offset, hero root, chuỗi, số lần đọc, tổng byte và số diagnostic.
- Đã cross-build Windows x64 và kiểm tra PE imports/exports; chưa thực thi trên Windows, chưa kiểm tra tương đương dữ liệu với LB, tài khoản Free hay trận thật.

Kết quả máy đọc được nằm trong `tests/verification.json`. `tests/fixture-snapshot.json` chỉ là dữ liệu tổng hợp, có `synthetic:true`.

## Build và test

Linux, Python 3 và g++:

```sh
python3 build.py --test
```

Đầu ra: `build/liblc_reader.so`. `python3 build.py --sanitize --test` thêm UndefinedBehaviorSanitizer. Lệnh sanitizer cần bộ runtime GCC tương ứng.

Windows x64, Visual Studio Build Tools và CMake:

```powershell
cmake -S . -B build-windows -A x64
cmake --build build-windows --config Release
python tests/test_reader.py build-windows/Release/lc_reader.dll
```

Lệnh Windows là hướng dẫn chưa được thực thi trong cloud Linux. Không cần runtime .NET cho chính DLL C++ này.

Bản cross-build sẵn: `build/lc_reader.dll`, import library `build/liblc_reader.dll.a`, manifest `build/windows-build.json`. DLL liên kết tĩnh GCC/libstdc++/winpthreads, chỉ import `KERNEL32.dll` và `msvcrt.dll` của Windows. Cross-build không chứng minh DLL đã hoạt động trong game.

Để tái tạo với MinGW-w64 đã có sẵn (script không tải/cài công cụ):

```sh
python3 build_windows.py --toolchain-root /path/to/extracted-mingw-root
```

Toolchain dùng trong cloud được giải nén từ package Debian chính thức; SHA-256 package được đối chiếu với Packages.xz, hash Packages được đối chiếu InRelease và chữ ký InRelease được kiểm bằng keyring Debian có sẵn. Manifest lưu phiên bản/hash compiler, hash source, package và imports/exports. Thông báo bản quyền runtime ở `third-party/`.

## Contract C ABI

Header chuẩn: `include/lc_reader.h`, API version 1. Kiểu `lc_reader_target` và `lc_reader_request` có `struct_size`, phải điền bằng `sizeof(...)`. Host và DLL phải cùng kiến trúc.

1. Host **đo** tên module, version và SHA-256 của file game/module mục tiêu; không sao chép identity từ profile để làm giả bước kiểm tra. Xác định module base theo tiến trình thực tế.
2. Gọi `lc_reader_create(profile_json, length, target, callback, context, flags, &handle, &error)`.
3. Callback trả số byte thực đọc được, tối đa bằng số yêu cầu; khi không đọc được trả 0. Callback/context phải sống đến khi hủy handle.
4. Gọi `lc_reader_snapshot(handle, &request, &json, &length, &error)`. `hero_addresses` là các địa chỉ object do host biết rõ. Core không tự tìm danh sách và không giả định stride.
5. Sao chép/đọc JSON UTF-8, sau đó gọi `lc_reader_free_buffer(json)`. Không dùng allocator khác để giải phóng.
6. Gọi `lc_reader_destroy(handle)` và tự hủy read context. Handle không sở hữu callback/context.

`heroes_known=0, hero_count=0` có nghĩa chưa biết object roots, kết quả `data.heroes:null`. `heroes_known=1, hero_count=0` nghĩa collection đã biết là rỗng, kết quả `[]`. Không dùng collection rỗng để che lỗi discovery. Tối đa 64 hero roots.

Core không gọi handle đồng thời; host phải tuần tự hóa khi dùng chung handle. Bộ nhớ game có thể thay đổi giữa các lần đọc nên snapshot read-only này không bảo đảm tính nguyên tử. Không được coi các `null` là số 0.

## Profile và bằng chứng

Profile mẫu cú pháp là `profiles/sparse-fixture-v1.json`. **Tất cả địa chỉ/offset trong profile đó là layout do test tự đặt, không phải offset LoL.** Core không có fallback tự chọn profile hoặc tự dùng fixture.

Profile yêu cầu:

- `schemaVersion:1`, `profileId`.
- `target.module`, `target.version`, `target.sha256`: khớp toàn bộ với target identity được host đo.
- `validation.status`: `fixture-only`, `static-derived`, `unverified`, hoặc `verified`.
- `evidence`: mỗi entry có `id`, `source`, có thể có `sha256` và `note`.
- `fields`: 1–128 descriptor; mỗi descriptor tham chiếu một `evidenceId` có tồn tại.

`fixture-only` cần flag `LC_READER_ALLOW_FIXTURE` (1); `static-derived`/`unverified` cần `LC_READER_ALLOW_UNVERIFIED` (2). Chỉ profile đã kiểm với đúng game/build/hash/Windows mới nên được gắn `verified`, và profile này phải có `validation.runtimeEvidenceId` tham chiếu bằng chứng. Engine kiểm cấu trúc, liên kết và identity; nó không tự xác minh nội dung tài liệu bằng chứng hay chứng minh LB parity. `metadata.runtimeVerified` phản ánh trạng thái profile đã khai báo, không phải chứng nhận do core tự tạo.

Descriptor field:

```json
{
  "root": "hero",
  "path": "common.health",
  "offset": 32,
  "type": "f32",
  "evidenceId": "sparse-memory"
}
```

Ví dụ trên lấy từ fixture; số 32 không có ý nghĩa với game thật. `root` chỉ có `hero` hoặc `module`. `path` là đường dẫn object JSON, phân tách bằng dấu chấm; không có array index. Từ chối field trùng hoặc chồng đường dẫn để tránh ghi đè.

Kiểu hỗ trợ: `u8`, `i8`, `u16`, `i16`, `u32`, `i32`, `u64`, `i64`, `f32`, `f64`, `bool` (1 byte), `vec3` (3 float little-endian liên tiếp: x/y/z), `utf8` (buffer char có NUL, cần `maxBytes` 1–1024). Core không đoán layout `std::string`/MSVC, buff, inventory hay spell.

`derefOffsets` là mảng tùy chọn, tối đa 8 bước. Bắt đầu ở root; mỗi bước đọc một pointer 64-bit tại `cursor + step`, thay cursor bằng pointer đã đọc. Cuối cùng đọc giá trị tại `cursor + offset`. Cả pointer, phép cộng địa chỉ và vùng đọc đều được kiểm giới hạn. Offset phải không âm, tối đa `0x3fffffff`.

Core chỉ nhận vùng địa chỉ user-mode x64 thấp từ `0x10000` đến `0x00007fffffffffff`. Snapshot bị giới hạn 16.384 callback đọc, tổng 2 MiB yêu cầu. Diagnostic giữ tối đa 256 mục, có `issueCount` và `issuesTruncated` để nhận biết phần bị lược.

## Output và giới hạn

Output có `schemaVersion`, `source:"independent-memory-reader"`, `synthetic`, `data` và `metadata`. Field profile chưa khai báo được **bỏ vắng**, không tự tạo giá trị. Field đã khai báo nhưng lỗi đọc được xuất `null` kèm issue. `synthetic:true` chỉ với fixture; `synthetic:false` ở profile thử nghiệm không có nghĩa đã kiểm đúng dữ liệu game.

`metadata.objectDiscoveryAvailable` luôn `false` ở phiên bản này. Việc caller cung cấp hero roots không chứng minh collection đã đủ 10 người. Core chưa thu game events, chưa nhận diện rồng/Baron, chưa tính timer và chưa thực hiện overlay state. Đây là nền triển khai để ghép dữ liệu phục hồi được có bằng chứng, không phải gói collector hoàn chỉnh tương đương LB.
