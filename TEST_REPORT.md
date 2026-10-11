# Kiểm chứng chốt phase UI/phòng thử — 11/10/2026

## Kết luận hiện hành

Chốt phần LoL đã có dữ liệu và công cụ rehearsal, không tuyên bố toàn bộ
production/collector hoàn tất hoặc đạt 95–98% giống UI. **94/94 unit/regression
đạt, 0 skip trên máy hiện tại; build đạt; integration và browser QA đạt.**
REA/LB/Valorant feasibility giữ nguyên để tiếp tục riêng.

| Lệnh | Kết quả/phạm vi |
| --- | --- |
| `npm test` | 94 đạt: mock/schema, collector/privacy, dedup/session/seek, playback bản ghi thật, objective/buff/timer, quest/rune/spell, UI missing/stale, asset/font/hash |
| `npm run build` | TypeScript + Vite đạt; Zod annotation warning và bundle JS 536,29 kB (gzip 151,30 kB) còn tồn tại, không lỗi build |
| `npm run test:integration` | Backend 4311/theme tạm: HTTP/probe, Host/origin/method guard, WebSocket/OBS read-only, scene/mock/validation/theme persistence, provider, capture load/pause/4×/seek, rehearsal/variants không sửa telemetry |
| `node scripts/visual-capture.mjs` | Edge 1920×1080/DPR1/backend 4391: gold/level/rune/minimal/CD, 21 timer combinations, 7 DragonKill, 6 Soul, 3 buff modes, trụ đầu/thường, inhibitor từng đội, 5 quest |
| `node scripts/phase-smoke.mjs` | Draft/in-game/postgame fixture: asset/font đủ, OBS trong suốt/no control/reference; 5 module Studio và theme page 1280px không overflow ngang |
| `git diff --check` | Không lỗi whitespace; LF/CRLF warning không phải lỗi source |

Lượt integration sandbox đầu không khởi động kịp; chạy lại được duyệt ngoài
sandbox đạt. Không kill process cổng 4312 đang bận. QA dùng backend 4391 do
tác vụ tạo, không đổi phiên/theme 4310. Integration từ chối cổng 4311 bận
trước khi gửi lệnh. Production sửa MIME WebP/OTF/TTF và reject WS Host lạ;
integration xác minh response asset và chặn path traversal.

Đã thử listener tạm trên 4311: integration từ chối đúng trước khi gửi lệnh.
`npm ls --depth=0` không có dependency thiếu; máy còn hai fontsource package
extraneous từ phiên cũ, source/runtime không còn import chúng. Không commit
node_modules hoặc tự sửa lockfile để hợp thức hóa dependency không dùng.

README/setup/architecture/roadmap/visual docs và UI đồng bộ với source.
Soul phân biệt Dragon Slayer/Dragon Soul, chỉ số/điều kiện/cooldown và tooltip
scaling: docs/DRAGON_SOUL_RULES.md. Quest đối chiếu Riot 26.1/26.9, MID hiện
bonus AD/AP chứ không phải empowered recall cũ: docs/ROLE_QUEST_COPY.md.
Preview biến thể có nhãn giả lập UI, không sửa capture.

Artifact tại `.npm-cache/visual-audit/`: measurements, variant PNG và
`phase-baseline-{draft,ingame,postgame}.png`. Hai dòng cả sáu Soul được đo
không overflow. Browser QA cần Playwright/sharp/Edge, đặt
`OVERLAY_BROWSER_PACKAGES` và `OVERLAY_VISUAL_URL` trỏ backend test loopback;
phase-smoke từ chối cổng vận hành 4310. Máy clone thiếu capture local báo
skip regression thật, không thay bằng fixture rồi gọi là bằng chứng live.

### Còn hoãn / chưa chứng minh

- Damage/combat tự động, activation Zhonya, end-game/champ-select live và
  transition production đầy đủ.
- Elder buff/inhibitor xanh thiếu capture live; preview không thay thế mẫu.
- Power Play fallback +1500 rồi biến động chênh vàng ròng, không field trực
  tiếp; có thể lệch nếu bỏ lỡ snapshot lúc nhận buff. Buff player lấy nguồn.
- ItemCompleted allowlist chưa bao phủ mọi món/mua-bán; assets 16.20.1 không
  tự chứng minh trùng patch game; chưa đo toàn UI 95–98% hoặc latency video.
- Collector headless thay LB/Valorant runtime chưa có. Giữ capture/theme/
  credentials/binary nghiên cứu ngoài Git; xác minh quyền assets trước publish.

## Báo cáo các lượt triển khai đầu (lịch sử, không phải trạng thái hiện hành)

## Phạm vi

Ưu tiên phần đã có dữ liệu xác minh. Tạm hoãn mốc chưa có telemetry: damage/combat tự động, activation Zhonya, end-game và Baron Power Play gold delta. Không tuyên bố đã hoàn thành mọi đồ họa giải đấu.

## Bộ test tái sử dụng

Kết quả lần chạy này: **63/63 unit/regression test đạt, 0 skip; build đạt; test tích hợp đạt**. Các warning build chỉ là annotation tree-shaking trong dependency Zod, không lỗi TypeScript/build.

Cập nhật Phòng thử: **64/64 đạt, 0 skip; build và integration đạt**. Regression/integration chạy mọi nút rehearsal khả dụng qua bản ghi thật, kiểm tra cue chỉ phát một lần và mang nhãn manual-rehearsal; damage bị từ chối, rune chỉ khả dụng đủ perk IDs. Thêm renderer test cho leaderboard gold/Power Play missing/stale. Build có thêm cảnh báo bundle frontend khoảng 502 kB (không chặn build); chưa tối ưu chia bundle ở mốc này.

| Lệnh | Phạm vi |
| --- | --- |
| `npm test` | Reducer và mọi control mock; schema/validation; asset/font local; collector/cache/loss; adapter/provenance/privacy; session/epoch/dedup/seek; Riot objective; LB objective/micro-event/cooldown/inhibitor; renderer/missing/stale; playback; capture marker/analyzer; regression bản ghi thật local |
| `npm run build` | TypeScript toàn project và frontend production |
| `npm run test:integration` | Backend cô lập 4311: HTTP/report/recording/6 probes; origin/method guard; WebSocket Studio/OBS đồng bộ và chỉ đọc; đổi scene; tất cả control mock; lệnh/theme sai; lưu theme tạm/reset; provider; nạp bản ghi lớn/pause/4×/seek |

Test tích hợp không ghi vào `data/theme.json`. Theme test nằm trong thư mục tạm và được xóa khi test kết thúc. Không đổi game/client/LB. Nếu máy không có capture local, test regression thật báo skip rõ ràng; không thay bằng fixture rồi coi là đã kiểm chứng thật.

## Bản ghi thật

`lb-2026-10-11T09-07-37-947Z`: khoảng 194 MB, 2.304 state frame raw, parser nhận 2.303 frame trận và bỏ một bootstrap trống. Regression validate mọi sample theo contract, xác nhận level/item, bốn rồng và một Soul, trụ, Baron, inhibitor phá/hồi sinh, GA cooldown 300 giây. Seek không phát lại lịch sử; pause đứng clock; 4× tiến clock; kết thúc bản ghi không biến thành payload end-game. Frame cuối 21:37.696, không suy ra mốc người dùng 22:13.

## Kiểm tra giao diện

Kiểm tra Studio/OBS bằng bản ghi thật, không bật demo/ảnh tham chiếu. Canvas CSS 1920×1080; bảng đầy đủ và tối giản có đủ 10 slot, icon tải đủ, body/canvas trong suốt. Cửa sổ in-app browser hiện thu nhỏ 662×372 dù yêu cầu viewport 1920×1080; chưa có ảnh xuất OBS kích thước 1:1, chưa coi đây là pixel-perfect QA.

Các lỗi đã sửa: timer hồi sinh đứng giữa frame; timer nhà lính có thể hiện `0:60`; timer item phải khớp cả slot và ID; ultimate chưa học không được báo ready chỉ vì cooldown zero; Elder không tính vào bốn rồng Soul. Layout/animation chưa được xác nhận pixel-perfect so với tất cả ảnh production.

## Giới hạn

Test không đảm bảo LB/client luôn hoạt động trên trận mới. Live asset 16.18.1 chưa xác minh trùng patch capture 16.20.0. ItemCompleted là inventory edge trong allowlist item lớn, không xác nhận mọi món hay nguồn mua/bán riêng. Buff Baron không suy ra Power Play. Timer objective trong Phòng Tập có thể bị công cụ spawn làm lệch; ưu tiên event. Champ-select thật và end-game thật vẫn cần phiên kiểm chứng riêng.
