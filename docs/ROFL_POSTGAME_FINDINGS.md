# Nguồn postgame từ metadata replay, 17/10/2026

## Kết quả thực tế

**Tạm hoãn.** Người dùng xác nhận file do tài khoản Seotoww tải từ client
trước khi đổi sang spectator. Giữ kết quả đọc metadata để nghiên cứu sau;
không triển khai import, không coi đây là nguồn tự động cho máy spectator.

Đọc chỉ metadata của file local:
`C:/Users/Seotow/OneDrive/Documents/League of Legends/Replays/VN2-1607368559.rofl`.
Không chạy replay, không giải mã packet, không cần API key, tài khoản player
hay quyền LCU. File chỉ mở read-only. Đây là file đã tồn tại trên máy, không
phải bằng chứng spectator tải được replay custom mới sau mỗi trận.

- File 7.813.521 byte, magic RIOT/version 2.
- u32 little-endian cuối file bằng 56299; JSON metadata ở offset 7757218.
- Metadata có gameLength=786412ms và statsJson với 10 người, 5+5.
- Mười người có TOTAL_DAMAGE_DEALT_TO_CHAMPIONS, KDA, GOLD_EARNED và WIN.
- Đã so từng người bằng team+champion với kết quả LCU player đã lấy trước
  logout: **10/10 khớp damage, gold, kills, deaths, assists và winner**.
- Damage Yasuo 40241, Smolder 4366, Veigar 5889. Có cả physical/magic/true
  damage lên tướng cho 10 người, không phải suy từ HP hoặc replay timeline.

Script chẩn đoán `scripts/probe-rofl-postgame.mjs` kiểm magic/version, bounds
metadata tối đa 2MB, UTF-8/JSON, roster10 và đối chiếu LCU. Report chọn field,
không copy Riot ID/PUUID/summoner ID từ statsJson vào log:
`.npm-cache/rofl-postgame-probe.json`. Có SHA-256 riêng của metadata.
Không xác minh chữ ký replay; tên file không phải embedded match ID đã được
kiểm chứng độc lập. File/hash/roster/thời lượng và đối chiếu LCU là evidence
riêng, không tự gắn nhãn authenticated official API khi import file.

## Mục tiêu và field còn hạn chế

Tổng từ player stats đội xanh: DRAGON_KILLS=5, BARON_KILLS=1,
RIFT_HERALD_KILLS=1, HORDE_KILLS=3, TURRETS_KILLED=8, khớp aggregate LCU.
Đội đỏ các aggregate này bằng 0. Đây là kiểm riêng trận này, chưa là quy tắc
chung cho mọi counter hoặc cách cộng takedown/assist.

**ELDER_DRAGON_KILLS đều bằng 0 trong file**, trong khi ledger native đã ghi
Elder bị hạ. Không dùng field này làm sự thật hoàn chỉnh hoặc biến tổng 5
rồng thành 5 nguyên tố. Phải giữ discrepancy/provenance và lấy ledger đã
kiểm chứng hoặc yêu cầu operator xác nhận khi reconcile.

TEAM_POSITION rỗng ở trận phòng tập. Dùng roster/lane của archive cùng trận;
không sort theo array index/tên tướng. Metadata là thống kê cuối trận, không
chứa sẵn đường vàng 0.5s hoặc damage theo từng combat. Gold chart cần archive
hoặc timeline nguồn khác. Bans/patch/match identity cần kiểm riêng trước khi
thiết kế import production. Chưa nối vào UI/publish postgame.

## Hướng nghiên cứu khi mở lại

Một phương án là module nhập replay hoặc chọn file `.rofl` local: parse metadata có
giới hạn → stage candidate → map đúng trận/roster và lane từ archive → preview
→ operator xác nhận publish. Không sửa file replay, không bắt buộc replay chạy
được trên patch hiện tại để thử đọc metadata. Khả năng tương thích các format/
patch khác phải có fixture/test, không suy từ một file thành hỗ trợ mọi replay.

Nếu spectator không lấy được file mới thì một người tham gia trận cần cung
cấp replay, hoặc dùng agent/export LCU trên máy người tham gia. Không hứa
collector hiện tại tự tạo được `.rofl` đầy đủ sau trận.

## Nguồn format tham khảo

- [ROFL-X format notes](https://github.com/Toastaspiring/ROFL-X/blob/main/docs/ROFL_FORMAT.md),
  mô tả metadata JSON ở đuôi ROFL2. Chỉ dùng thông tin format, không chạy repo.
- [lol-replay-stats](https://github.com/Amirormir/lol-replay-stats),
  ví dụ đọc statsJson cuối trận. Kết luận ở trên dựa vào file local và đối
  chiếu LCU thực tế, không coi tuyên bố của repo là bằng chứng cho trận này.
