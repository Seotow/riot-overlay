# Mô tả linh hồn rồng — đối chiếu 11/10/2026

Phạm vi: LoL PC, Summoner's Rift. Không dùng thông số Wild Rift, Arena hoặc
buff Dragon Slayer mỗi lần hạ rồng. Đây là mô tả luật chơi, **không phải** lượng
heal/shield/damage đo từ LB. Catalog: `shared/dragon-soul-copy.ts`.

| Soul | Hiệu ứng cơ bản trong banner |
| --- | --- |
| Nước | Gây damage hồi 150+ máu, 100+ mana trong 4s; lính/quái chỉ 30% hiệu lực |
| Đất | 220+ shield sau 5s không nhận damage |
| Lửa | Đòn đánh/kỹ năng gây nổ 100+ adaptive damage; cooldown 3s |
| Gió | 15% tốc chạy; tăng thành 60% trong 6s sau ultimate; cooldown 30s |
| Hextech | 25–50 true damage theo level; slow 45% melee/35% ranged trong 2s; cooldown 8s |
| Hóa kỹ | Dưới 50% máu: thêm 13% damage và giảm 13% damage nhận |

Dấu `+` là phần scaling, không phải chỉ số player tính sẵn. Tooltip chứa
công thức đầy đủ; không tính giả heal/damage từ các hằng số này. Hextech
truyền tới tối đa ba mục tiêu thêm; slow còn tăng theo stats. Không có Elder Soul.

## Nguồn và cách xử lý số liệu cũ

- [Leaguepedia/Fandom: Dragon Soul](https://lol.fandom.com/wiki/Dragon_Soul):
  bản search-index có đủ sáu công thức và điều kiện, dùng đối chiếu tổng hợp.
  Mở toàn trang trả lỗi; không coi đó là xác minh trực tiếp tooltip client.
- [Riot 12.10](https://www.leagueoflegends.com/en-us/news/game-updates/patch-12-10-notes/):
  scaling mới của nước (26% bAD, 17% AP, 7% bHP) và đất (16% bAD, 12% AP, 12% bHP).
- [Riot 13.20](https://www.leagueoflegends.com/en-us/news/game-updates/patch-13-20-notes/):
  base nước 150/100, đất 220, lửa 100, slow Hextech 45%/35%; riêng Ocean
  Dragon Slayer mới là hồi 2% máu thiếu mỗi 5s. Đã sửa nhầm này trong UI.
- [Riot 2025.S1.3](https://www.leagueoflegends.com/en-us/news/game-updates/patch-2025-s1-3-notes/):
  Gió giảm base tốc chạy về 15%, Hóa kỹ tăng hiệu ứng lên 13%.
- [Riot 11.23](https://www.leagueoflegends.com/en-au/news/game-updates/patch-11-23-notes/)
  và [12.2](https://www.leagueoflegends.com/en-au/news/game-updates/patch-12-2-notes/):
  Hextech chaining/scaling/cooldown; true damage giảm từ 25–75 xuống 25–50.
- [Riot 26.20](https://www.leagueoflegends.com/en-us/news/game-updates/league-of-legends-patch-26-20-notes/):
  không thấy thay đổi Soul trong patch đang dùng. Đây không phải chứng nhận
  đã audit mọi patch trung gian hoặc kiểm tra tooltip trực tiếp trong game.

Wiki chính `wiki.leagueoflegends.com` bị robots chặn trong công cụ đọc web;
không vượt rào. Các hướng dẫn ghi nước 160, đất 200, Gió 20%, Hóa kỹ 11%
không được dùng thay các thay đổi Riot nêu trên. Không đổi patch ảnh demo,
artwork, dữ liệu trận, theme hay transport để sửa nội dung này.
