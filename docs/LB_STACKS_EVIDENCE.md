# Stack counter — khảo sát chỉ đọc 12/10/2026

**Có field từ LB, chưa bật widget stack hoặc thay ngọc phụ.**

Schema SDK công khai khai báo `tabPlayer.stacksData?: number`:
[BlueBottleGG / tabPlayer.ts](https://github.com/BlueBottleGG/leaguebroadcast-js-client/blob/main/types/ingame/tab/tabPlayer.ts).
SDK xác nhận kiểu field, không tự xác nhận semantics Q/passive theo từng champion.
Không nhập SDK GPL hoặc DLL vào project; không dùng memory/hook/REA cho khảo sát này.

Đã đọc14 file NDJSON local,2711 state frame. Script `node scripts/inspect/inspect-lb-stacks.mjs` stream chỉ đọc, in tên tướng/field/giá trị/game clock tổng hợp, không xuất identity/credentials/raw provider.

| Tướng | Số frame có tướng | stacksData thấp–cao | Bằng chứng / giới hạn |
| --- | ---: | --- | --- |
| Nasus (75) | 2303 | 0–152 | Có tăng4/10 theo các đoạn; ví dụ4 tại114.90s,8 tại123.06s,30 tại316.70s. Không tính lại từ CS/Q |
| Veigar (45) | 39 | 0–1 | 0 tại54.81s,1 tại70.12s; cửa sổ ngắn |
| Smolder (901) | 100 | 0–0 | Chỉ đầu trận; không chứng minh counter tăng đúng |

Các ability chỉ thấy keys assets/charges/displayName/identifier/isToggled/level/readyAt/slot/totalCooldown. **Không dùng `charges` hay `items[].stacks` làm stack champion**. Các bản ghi cũ có champion stacks trong payload nhưng adapter hiện chưa giữ field; renderer chỉ dùng normalized fields, không đọc raw.

Bước thấp ưu tiên tiếp theo: lấy một snapshot screenshot và game clock có stack rõ của mỗi tướng, đối chiếu `stacksData` (Nasus Q, Veigar passive, Smolder passive). Sau đó thêm field optional observed/null theo allowlist champion đã xác minh; numeric0 chỉ hiển thị khi nguồn thực báo0, thiếu field/nguồn stale trả về rune path, không lấy từ total AP/CS hoặc tự tăng. Thiết kế ô phụ cần đủ chữ số và tooltip nguồn; chưa chốt thay rune phụ tự động hoặc toggle operator.
