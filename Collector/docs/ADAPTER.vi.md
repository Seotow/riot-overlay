# Adapter riêng sang ObserverFrame

Entry: `collector/adapter/index.ts`. Projectionnative trực tiếp; không bọc feed
`LeagueBroadcastSource` hoặc giả thành Riotallgamedata.

```ts
import { LeagueCollectorSource } from "./collector/adapter";
const source = new LeagueCollectorSource({ port: 18799 });
source.ensureConnected(); // explicit, chỉ WS loopback /ws
const frame = source.observe(); // shared observerFrameSchema
const report = source.snapshot(); // aggregate capability/freshness
source.stop();
```

Ví dụ chỉ minh họa lifecycle; consumer thực gọi ensureConnected/observe theo
tick riêng. Constructor không mở socket, đọc env, launchCollector/game hoặc
switchprovider. Từ mốc 15/10/2026, backend dùng adapter này qua provider
`league-collector`; launcher riêng quản lý host. Xem [runbook](PROJECT-RUNBOOK.vi.md).

## Freshness/session

- Chỉ nhận envelopev1/type snapshot/source lblib/syntheticfalse/recordedAtnull.
- TimestampISOZ/offset được normalizeUTC; stale≥5s hoặc future>1s bị từchối.
  Duplicatesequence/lateframe không gia hạn freshness; socketclose/statusended/
  lỗi/invalidsample xóa output/coverage ngay.
- Đủ10hero/uniqueindex và5+5 mới emit; reorder không đổi slot hoặc tạo sessionmới.
  Signaturehash từ gameId/roster dùng nội bộ. Đổi game/roster thay session.
- Mất socket rồi hồi phục thay sessionId, resetsequence/epoch và baseline.
  Seek clock đổiepoch qua ObserverSession, không dựng event từ lịch sử.
- Heartbeat/status/LCU không dùng làm telemetry. `events=[]` có thể do vector
  thiếu, không có record gần đây hoặc không resolve được object; không chứng minh
  trận không có event. Chỉ bốn loại typed event đã map, history coverage false.
  Raw bị bỏ sau projection. Chi tiết tại [native events](NATIVE-EVENTS.vi.md).
- WS fixed127.0.0.1, configurableport, noredirect, max16MiB; không gửi command.
  stop chỉ dừng socket adapter, không dừng collector/producer/game.

`observe()` và `snapshot()` chỉ đọc, không drain event. Backend broadcast gọi
`broadcastFrame()` một lần cho cả Studio/OBS để không mất event giữa native
tick100ms và poll750ms. Hàng đợi tối đa4096, hết hạn theo cả wall time và game
time5s; lần đọc broadcast đầu/seek/reconnect/lost reset baseline, không phát
alert lịch sử. Signature nội bộ có gameId, team/index/champion và networkId;
networkId không xuất sang contract/frontend.

Contract thêm source `league-collector` và optional currentGold; tương thích
sample/recording cũ, không thay theme hoặc schema command. `currentGold` chưa
được renderer sử dụng. Chưa xác minh thứ tựlane, nên source khôngproductionready.
Tổng vàng/kills đội được tính chỉ khi đủ5fieldplayer hợp lệ; towers/plates/
dragons/grubs luônmissing trong mốc này. Không coi tổng derived là fieldnative
team đã đo hoặc suy objectives từ vị trí object.

## Kiểm tra thủ công chỉ đọc

Collector phải được chạy trước trong phiên riêng. Không chạy launcher mặc định
chỉ để thử adapter. Từ root:

```powershell
npm run collector:inspect -- --port 18799 --duration 10000
```

CLI chỉ in status/count/coverage, không snapshot/identity/statsvalues. Không
start collector, đọc credentials, inject, sửaplayback hoặc thay nguồn Studio.
Đã có [SRlive validation](SR-LIVE-VALIDATION.vi.md): level/KDA/items matched,
nativeauxslots7/8 được bỏ khỏiinventory chuẩn; CS lệch nên null. WebSocket
host linkApplicationStopping để không giữ server lúcshutdown. Chưa lane-order,
cooldownsemantics hoặcfullparity trướcrollout.
