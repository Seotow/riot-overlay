# ValorantCollector

Collector Valorant tự chứa, cùng cấp với `LeagueCollector`: dùng **Spectra** (Client chính thức chạy ngầm, backend và overlay VAL26) để lấy dữ liệu
trận và phát cho Studio. Studio chỉ giữ phần giao diện/API (`server/valorant-*.ts`, `shared/valorant*.ts`, `src/valorant/`).

```text
collector/hosts/valorant-collector/
  backend/         Fork Spectra Server (ELv2): ingest 5310, output Socket.IO 5320, status 5311; thêm sự kiện config_update
  frontend-val26/  Overlay in-game VAL26 của nobiiVAL (ELv2), nguồn ghi ở SOURCE.md
  client/          Điều khiển Spectra Client chính thức: tải một lần (release.json: bản, URL, SHA256), chạy ngầm, tự cấu hình (official.mjs)
  runtime/         Supervisor (backend + overlay + Client), cấu hình, setup tự cài, CLI
  tests/           Kiểm thử vòng đời, ownership, auth, shutdown, máy mới
  upstream.json    Provenance các nguồn import
  MODIFICATIONS.md Thay đổi so với upstream
  local/           (Git bỏ qua) dữ liệu cục bộ: module.json, auth.key, match-config.json, assets/ (logo),
                   runtime/ (owner), spectra/ (Spectra Client đã tải + profile ngầm)
```

Chạy: `npm start`, chọn Valorant trong Studio rồi bật công tắc kết nối; lần đầu Studio tự cài mọi thứ (cũng chạy tay bằng `npm run valorant:setup`).
Chi tiết: [client/README.vi.md](client/README.vi.md), [docs/VALORANT_MODULE.md](../../../docs/VALORANT_MODULE.md). Collector riêng đã nghiên cứu nằm ở
`collector/archive/valorant-collector`.
