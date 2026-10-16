# Stack và damage trong bản ghi thật — 17/10/2026

Audit offline original `2026-10-16T12-43-43-938Z`, 7331 native snapshots,
game clock20.799257–786.3254; 1586 Riot-reference records. Không mở game,
không đổi quyền tài khoản hoặc gọi endpoint Premium.

## Stack có dữ liệu thật

Đọc `heroes[].common.buffs[]`, chọn theo champion identifier và tên buff chính xác:

| Tướng | Buff / field | Min → max / cuối | Số lần thay đổi |
| --- | --- | --- | --- |
| Smolder | `SmolderQPassive.count` | 0 → 32 / 32 | 26 |
| Veigar | `VeigarPhenomenalEvilPower.count` | 0 → 77 / 77 | 68 |

Cả hai có trong7331 snapshots, không thấy giảm. `SmolderP.count` luôn1,
`VeigarPassive.count` luôn0: không dùng nhầm các buff này làm stack.
Đây là các bộ đếm trực tiếp, không suy từ AP, CS, cấp hay ability charges.
Projection5 hiện chưa có field stack; thêm hiển thị cần bước triển khai riêng.
Không tự áp mapping sang mọi tướng hoặc khẳng định đã đối chiếu HUD từng stack.

## Damage chưa sử dụng được

- `gameEvents.damageDealtEvents`:30171 appearances;21296 payload khác nhau
  khi dedup bằng JSON (không khẳng định mỗi payload là một hit duy nhất).
- Trong số payload khác nhau,2711 có `targetNetworkId` khớp hero.
- Toàn bộ `damageDealt` bằng0; `damageType` luôn3. Chưa giải nghĩa enum này.
- Các numeric damage/amount trong hero/common/misc không cung cấp counter tổng.
-1586 Riot-reference payload không có numeric damage field; projection5 cũng
  không có damage field. Không đưa những số0 trên thành biểu đồ damage thật.
- Có thể liên quan feature Premium LB theo thông tin user, nhưng chưa chứng
  minh nguyên nhân bằng account capability/error response/runtime đối chứng.
  Không thử vượt quyền tính năng. Khác biệt giữa khóa view UI và khóa telemetry
  cần kiểm chứng riêng, không kết luận từ tên field.

Lưu mỗi0.5s không khôi phục được damage vốn không được nguồn cung cấp.
Không cộng HP giảm: thiếu healing/shield/mitigation/nguồn gây damage và tick.

## Phương án postgame không dựa Standard Match-v5 cho custom

1. Ưu tiên kiểm chứng LCU `/lol-end-of-game/v1/eog-stats-block` sau một custom
   thực sự kết thúc, giữ client ở màn kết quả. Project đã có read-only probe,
   **chưa có response xác minh đủ10 player và damage** ở player/spectator.
   LCU là local, khác Production API key. Riot không bảo đảm hỗ trợ LCU cho
   third-party: <https://developer.riotgames.com/docs/lol#league-client-api>.
2. Nếu spectator không có EOG, thử thu bảng kết quả từ máy người tham gia có
   đồng ý. Nếu chỉ có ảnh: nhập/OCR damage cuối trận với provenance và xác nhận
   người vận hành; chưa đủ làm damage/combat realtime.
3. Overwolf GEP có tài liệu `total_damage_dealt_to_champions`, nhưng chưa có
   bằng chứng đủ10 người ở spectator/custom; không coi là giải pháp đã đạt:
   <https://dev.overwolf.com/ow-native/live-game-data-gep/supported-games/league-of-legends/>.
4. RSO/Tournament là hướng xin quyền riêng, xem `RIOT_POSTGAME_API_FINDINGS.md`;
   không mặc định Production Standard mở custom hoặc entitlement khác.

Các thống kê KDA/vàng/mục tiêu/gold history có thể dùng ledger snapshot theo
coverage đã xác minh. Damage chart vẫn unavailable cho capture này; không làm
giả số để hoàn thiện postgame. Winner/final time cần terminal evidence.

## Tái lập

`node scripts/audit-native-stacks-damage.mjs`

Report `.npm-cache/data-audit/native-stacks-damage.json` chỉ aggregate gameplay,
không log player identity/credentials. Original không sửa. Audit không thay
provider/UI. Không cần build ứng dụng cho báo cáo thuần túy này.
