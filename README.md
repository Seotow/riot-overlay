# Rift Studio — LoL Overlay Kit

Ứng dụng local-first: collector/adapter → backend TypeScript → WebSocket → React Studio / OBS renderer. LeagueBroadcast là nguồn production đầy đủ; Riot local là nguồn giới hạn, recording phát snapshot đã lưu. Demo là nhánh riêng, mặc định tắt.

## Chạy

Yêu cầu Node.js 22.12+ hoặc 24.

```sh
npm ci
npm run dev
```

- Studio: http://127.0.0.1:4310
- OBS Browser Source: http://127.0.0.1:4310/overlay (1920 × 1080)
- Scene cố định: `/overlay?scene=ingame`, `draft`, `postgame`.
- `npm run build` kiểm tra TypeScript và tạo bản production. Sau đó `npm start`.
- `npm test` kiểm tra logic trạng thái và validation.

Backend chỉ bind loopback. Đây là ứng dụng một máy, không triển khai LAN/public trước khi bổ sung xác thực và phân quyền.

## Kiểm thử và vận hành

Chọn nguồn tại **Kết nối dữ liệu**; giữ demo tắt khi dùng trận thật hoặc recording.
**Phòng thử** (`/?page=demo`) chọn snapshot thật local và có dropdown cho
3 loại hang Baron, 7 rồng, 6 Soul, Baron/Elder/cả hai, trụ đầu/thường,
nhà lính xanh/đỏ và 5 role quest. Biến thể mang nhãn giả lập UI, không sửa
telemetry hoặc chứng minh nguồn có field đó. Không dùng Phòng thử lúc phát sóng.

Leaderboard gold/level đủ 10 người, rune chính/phụ, quest progress/reward,
cooldown sweep, Soul artwork tĩnh, Power Play và timer nhà lính đã có.
Damage/combat tự động, champ-select live và end-game vẫn chưa chốt.

### Demo fixture riêng

1. Chọn scene.
2. Bật ảnh tham chiếu để đối chiếu bố cục. Ảnh đã có HUD gốc, nên có thể chồng hình. Không có ảnh nền trong renderer OBS.
3. Chạy/tạm dừng mock, đổi thời gian, kích hoạt kill/level/objective/draft.
4. Chọn kịch bản thiếu gold để kiểm tra fallback.
5. Đổi branding/layout trong tab Theme. Theme tự lưu ở `data/theme.json`.
6. Export/import JSON hoặc thử theme mẫu 2. Thay theme không đặt lại trận.

Tên và ảnh tướng, trang bị, phép bổ trợ, ngọc lấy từ Data Dragon và cache local. Trong nhánh fixture, đội, kết quả, timer và số liệu là demo; postgame minh họa T1 thắng. Draft dùng fixture riêng với bans, picks và hover, chưa mô phỏng luật pick/ban. Thanh timeline fixture không phải replay `.rofl`; timeline recording phát snapshot NDJSON thật đã lưu.

Chọn **Theme & layout → Khớp ảnh mẫu** để áp dụng preset KT/T1, font và vị trí theo hai ảnh 1920×1080. Nút **Xem ảnh gốc** đổi sang ảnh gốc hoàn toàn; bỏ **Ảnh tham chiếu** để kiểm tra bản dựng độc lập. Xem `VISUAL_AUDIT.md` để biết các chi tiết còn khác ảnh.

`npm run assets:sync` đồng bộ bộ asset demo từ CDN chính thức. Metadata/icon khóa tại Data Dragon **15.20.1**, tương ứng nhãn patch **25.20** trong ảnh mẫu, không phải patch live mới nhất. Portrait loading có URL không chứa version và được lưu local. Studio dùng Beaufort for LoL/Spiegel; headline live dùng Anton (Broadcast Condensed/OFL), nhãn dùng Spiegel. Không khẳng định Anton là font gốc Riot.

## Cấu trúc

- `shared/schema.ts`: hợp đồng state, theme v1, validation command.
- `shared/mock.ts`: nguồn demo và reducer xác định trạng thái.
- `server/index.ts`: server local, snapshot WebSocket, persistence theme.
- `src/main.tsx`: Studio và kết nối tự phục hồi.
- `src/overlay/Surface.tsx`, `overlay.css`: renderer và layout theo ảnh mẫu.
- `shared/reference.ts`: preset nhận diện và hai fixture độc lập.
- `shared/assets.ts`, `shared/generated/catalog.json`: tra ID → tên/ảnh Data Dragon.
- `src/style.css`: Studio responsive.
- `public/references`: ảnh người dùng cung cấp để preview.

## Giới hạn / bước tiếp theo

- Đã có collector/adapter/session trong backend và playback NDJSON; chưa có agent headless độc lập, SQLite, ban phase thật, logo upload hoặc kéo/thả widget.
- Theme hỗ trợ tên, màu, font có sẵn, biến thể, tỷ lệ/dịch dọc toàn cục và widget visibility.
- Snapshot mock protocol v1 và observer envelope riêng có session/epoch/sequence, provenance, availability và dedup. Không nội suy gold, HP hoặc item.
- Mất nguồn/socket: nhánh live giữ khung, ẩn số liệu/hiệu ứng hết hạn sau tối đa 5s; Studio báo thiếu nguồn. Không tự chuyển provider hoặc điền mock.
- Assets tham chiếu không phải asset phát hành mặc định; xác minh quyền trước khi phân phối.

Xem `ARCHITECTURE.md` để biết ranh giới thiết kế và lộ trình adapter.

## Tài liệu bàn giao

UI draft/in-game đã được duyệt làm baseline. In-game đã nối nguồn replay thật; xem mốc mới nhất trong PROJECT_STATUS.md để biết field đã xác minh và field còn thiếu.

- [AGENTS.md](AGENTS.md): hướng dẫn cho Codex và các quy tắc cần giữ.
- [PROJECT_STATUS.md](PROJECT_STATUS.md): đã làm, chưa làm, quyết định đã chốt và bước tiếp theo.
- [SETUP_VI.md](SETUP_VI.md): clone, cài, chạy, chuyển theme và chuẩn bị Git.
- [ARCHITECTURE.md](ARCHITECTURE.md): kiến trúc hiện tại và ranh giới mục tiêu.
- [ROADMAP.md](ROADMAP.md): năm giai đoạn tiếp theo và điều kiện hoàn thành.
- [VISUAL_AUDIT.md](VISUAL_AUDIT.md): mốc bố cục và các khác biệt đã ghi nhận.

Trên máy khác, mở thư mục clone làm workspace và bắt đầu bằng AGENTS.md. Các tài liệu dùng đường dẫn tương đối, không cần lịch sử cuộc trò chuyện để tiếp tục.

## Công cụ chẩn đoán local

Module **Kết nối dữ liệu** kiểm tra LCU/Live Client chỉ đọc và xuất báo cáo field đã lọc. Mock là nhánh thử riêng, mặc định tắt. Xem phần “Chẩn đoán LoL chỉ đọc” trong [SETUP_VI.md](SETUP_VI.md).

Đối với in-game/replay, chọn nguồn tại **Kết nối dữ liệu**. Collector và adapter cấp cùng dữ liệu quan sát cho Studio và OBS; hỗ trợ thiếu field, mất nguồn, session/epoch và xuất bản ghi đã lọc trong RAM. Xem “Ưu tiên kiểm thử in-game bằng replay” trong `SETUP_VI.md`.


## In-game quan sát thật

Tắt “Dùng dữ liệu demo” để nhận nguồn live trong Studio và OBS. Khi mất nguồn, khung còn hiển thị nhưng số liệu chuyển thành —. Tên/icon tướng, item, spell và chiêu cuối dùng catalog live riêng; `npm run assets:sync:live` tải bản mới nhất từ Riot (16.20.1 tại 11/10/2026), rồi chạy build và khởi động lại. Demo vẫn khóa 15.20.1. Field thiếu không được thay bằng mock. Kết quả đo UI từng vùng và giới hạn 95–98% xem [VISUAL_MEASUREMENTS.md](VISUAL_MEASUREMENTS.md).

Dashboard dùng module theo workflow sản xuất: Tổng quan, Nguồn dữ liệu, Studio/OBS, Demo, Theme và Lộ trình. Nguồn LoL có Riot local và LeagueBroadcast local; người vận hành chọn một nguồn cho output, dashboard ghi provenance từng field. **LeagueBroadcast là dependency production bắt buộc khi cần bộ telemetry giải đấu đầy đủ**; Riot local chỉ phục vụ replay, kiểm thử và chế độ dữ liệu giới hạn. Adapter trong project không phụ thuộc SDK npm. Valorant hiện chỉ có workspace placeholder để giữ kiến trúc mở rộng.

Kiểm thử: `npm test`, `npm run build`, rồi `npm run test:integration`. Lệnh tích hợp tự chạy backend riêng ở cổng 4311 và theme tạm, không thay theme người dùng. Cần build trước và cổng 4311 trống. Xem [TEST_REPORT.md](TEST_REPORT.md) cho phạm vi và giới hạn kiểm chứng.

Mô tả Soul có nguồn tại [docs/DRAGON_SOUL_RULES.md](docs/DRAGON_SOUL_RULES.md).
Ghi chú REA/LB và hướng Valorant giữ tại `LEAGUEBROADCAST_FEASIBILITY.md`
và `VALOSPECTRA_FEASIBILITY.md`; chưa phải collector thay thế đang chạy.
