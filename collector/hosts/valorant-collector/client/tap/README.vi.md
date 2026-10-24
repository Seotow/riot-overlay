# Tap nội bộ Spectra Client + overlay native

Đọc binary 0.3.4, không sửa `app.asar`. Ba mảnh:

| Mảnh | Vị trí | Việc |
| --- | --- | --- |
| `tap.cjs` | `client/tap/` | nạp vào **main process** của Client, chặn dữ liệu, đẩy NDJSON ra named pipe |
| `overlay-host` | `overlay-host/` | cửa sổ trong suốt, xuyên chuột, luôn nổi; nạp frontend overlay + nhận pipe |
| `shim.js` | `overlay-host/web/` | phát frame thành `riot-tap` event cho trang |

## Vì sao vào được main process mà không cần inject

Đọc fuse của `Spectra Client.exe` (`node scripts/inspect/spectra-client.mjs`):

```
EnableNodeOptionsEnvironmentVariable   enabled
EnableNodeCliInspectArguments          enabled
EnableEmbeddedAsarIntegrityValidation  disabled
```

Nhưng **fuse `NODE_OPTIONS` enabled không có nghĩa `--require` chạy**: đo thực tế trên 0.3.4,
`NODE_OPTIONS=--require <tap>` không nạp gì (Electron lọc cờ này với app đã đóng gói). Đường
dùng được là `--inspect=<cổng>`:

1. `official.mjs` tự lấy một cổng loopback trống, spawn Client với `--inspect=<cổng>`.
2. Chờ `/json/list` trả target `type: "node"` (main process).
3. `Runtime.evaluate`: `process.mainModule.require('<tap.cjs>').install()`.
4. Gọi `require('node:inspector').close()` để đóng cổng debug.

`install()` vá thẳng prototype trong `require.cache` (module đã nạp trước đó) và gắn thêm hook
`Module._load` cho module nạp muộn. Client vẫn là binary nguyên bản; không có byte nào bị sửa.

## Dữ liệu lấy được

- `k=out, c=obs_data` — đúng payload Client gửi lên ingest: `scoreboard`, `killfeed`, `roster`,
  `round_info`, `score`, `map`, `game_mode`, `observing`, `spike_*`, `toast`, `swap_*`.
- `k=out, c=aux_data` — `aux_health`, `aux_scoreboard_team`, `aux_abilities`.
- `k=gep` — GEP raw **trước** format: `observing`, `planted_location`, `shop`, `health`, `abilities`,
  `player_id`, `pseudo_match_id`, `ui_team_order_*`. Đây là phần frontend hiện chưa nhận.
- `k=status` — trạng thái kết nối Client, số frame bị bỏ.

`key` và `groupSecret` bị che thành `***` trước khi ghi ra pipe.

## Chạy

```powershell
# 1. recon contract (không chạy Client)
node scripts/inspect/spectra-client.mjs

# 2. build overlay host (một lần)
nuget install Microsoft.Web.WebView2 -OutputDirectory third_party
cmake -B collector/hosts/valorant-collector/overlay-host/build `
      -DWEBVIEW2_ROOT=third_party/Microsoft.Web.WebView2.<version>
cmake --build collector/hosts/valorant-collector/overlay-host/build --config Release

# 3. mở overlay (pipe tự có khi Studio bật công tắc Valorant)
collector\hosts\valorant-collector\overlay-host\build\Release\riot-overlay-host.exe `
  --url "http://127.0.0.1:5322/overlay?groupCode=RIOTLOCAL"
```

`Ctrl+Alt+H` bật/tắt chế độ xuyên chuột để chỉnh overlay bằng chuột.

## Giới hạn đã biết

- Chưa chạy trên máy có trận thật; chưa xác nhận frame rate/CPU khi overlay phủ lên game.
- VALORANT phải ở **borderless fullscreen**; fullscreen exclusive sẽ che cửa sổ overlay.
- Overlay đọc frontend qua HTTP loopback như hiện tại. Tap không thay reducer của backend fork,
  nên độ trễ server/browser vẫn còn cho tới khi nối `riot-tap` vào dataModel.
- Không chạm vào process VALORANT: không inject, không open handle, không đọc memory.
