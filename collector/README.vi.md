# Collector

Workspace collector LoL: source, runtime, scripts và evidence đều ở đây.
Đọc [status/plan](docs/STATUS-PLAN.vi.md) trước khi tiếp tục.

Kiểm chứng account/native: [AUTH-VERIFICATION.vi.md](docs/AUTH-VERIFICATION.vi.md).

Provider tích hợp thử nghiệm: [runbook](docs/PROJECT-RUNBOOK.vi.md),
[field matrix](docs/FIELD-MATRIX.vi.md) và
[hướng dẫn adapter](docs/ADAPTER.vi.md). Entry TypeScript `collector/adapter/index.ts`;
đã đăng ký trong Studio và có launcher owned host; chưa full LB parity.

```text
collector/
  adapter/              Adapter TypeScript: native frame -> frame chuẩn của Studio
  supervisor/           Launcher host (supervisor.ts) và môi trường không tài khoản
  validation/           Bộ so khớp/kiểm tra dữ liệu thu được
  hosts/                Source của các host native
    lb-host/            Host dùng DLL LB (trước là src/LeagueCollector); có lifecycle fix.
                        Project C# nằm ở src/LeagueCollector
    independent-reader/ Source C++/host độc lập (trước là src/LeagueReader), chưa game-validated
  bundles/              Gói Windows đã build kèm runtime .NET, tách khỏi source đang sửa
    lb-host/            Bản chạy của lb-host (trước là runtime/LeagueCollector)
    independent-reader/ Bản chạy của independent-reader (trước là runtime/LeagueReader-Windows-x64)
  config/               collector.env local bị ignore; example không chứa secret
  scripts/              Build, audit và validation/probe
  docs/                 Status, plan, validation và lifecycle review
  evidence/
    validation/         Log, kết quả và one-shot marker đã restore
    import/             Audit hash và bản đồ đường dẫn cũ → mới
  archive/
    cloud-export/       Export cloud nguyên vẹn để diff/kiểm checksum
    packages/           ZIP gốc và hướng dẫn download
```

`hosts/independent-reader` là source làm việc từ baseline cloud. Archive giữ
nguyên để truy nguyên; không sửa archive để phát triển. `hosts/lb-host` lấy từ
validation local mới nhất, khác standalone cloud. `bundles/lb-host` là binary
đã build; supervisor dùng `hosts/lb-host/src/LeagueCollector/bin/Release/net10.0`
nếu có, nếu không thì dùng bundle này. Collector chưa thay LB production.

## Lệnh từ root Riot Overlay

```powershell
# Kiểm export cloud, không chạy game
python collector/archive/cloud-export/RiotOverlay-local/tools/verify_export.py
# So sánh source local/cloud, đọc evidence lab đã có
python collector/scripts/audit-import.py
# Build và managed lab offline, không injection hoặc game access
powershell -NoProfile -File collector/scripts/build-validate.ps1
```

`inspect-replay`, `validate-no-inject`, `validate-single-inject` và
`inspect-validation-process` ở root Collector là wrapper giữ lệnh cũ.
Implementation nằm trong `scripts/`; kết quả mới vào `evidence/validation/`.
Giữ nguyên one-shot marker; sắp xếp file không cấp consent cho trial mới.

Runtime launcher mặc định có thể truy cập game/LCU/auth hoặc injection tùy nhánh;
không dùng nó để kiểm layout. Script validation giữ guards hiện hành.
Source/vendor, binary, ZIP và evidence local được loại khỏi Git; thay đổi source
vẫn nằm trên đĩa. Không đưa account env/token hoặc raw capture vào commit.

Chuyển máy: giữ cả source, evidence, archive, runtime và tools cần thiết.
SDK .NET hiện ở `.npm-cache/lb-headless`; scripts tìm theo root repository,
không theo thư mục terminal. SDK/cache là dependency tool, không source.
