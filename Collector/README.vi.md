# Collector

Workspace collector LoL: source, runtime, scripts và evidence đều ở đây.
Đọc [status/plan](docs/STATUS-PLAN.vi.md) trước khi tiếp tục.

Kiểm chứng account/native: [AUTH-VERIFICATION.vi.md](docs/AUTH-VERIFICATION.vi.md).

Provider tích hợp thử nghiệm: [runbook](docs/PROJECT-RUNBOOK.vi.md),
[field matrix](docs/FIELD-MATRIX.vi.md) và
[hướng dẫn adapter](docs/ADAPTER.vi.md). Entry TypeScript `Collector/adapter/index.ts`;
đã đăng ký trong Studio và có launcher owned host; chưa full LB parity.

```text
Collector/
  src/
    LeagueCollector/    Source local mới nhất, dùng DLL LB; có lifecycle fix
    LeagueReader/       Source C++/host độc lập, chưa game-validated
  runtime/              Hai gói Windows cloud, tách khỏi source đang sửa
    supervisor.ts       Launcher host dùng bản managed local đã build
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

`src/LeagueReader` là source làm việc từ baseline cloud. Archive giữ nguyên
để truy nguyên; không sửa archive để phát triển. `src/LeagueCollector` lấy
từ validation local mới nhất, khác standalone cloud. `runtime/LeagueCollector`
là binary cloud cũ, chưa chứa lifecycle fix local; build source local nếu cần
chạy bản sửa. Collector chưa thay LB production.

## Lệnh từ root Riot Overlay

```powershell
# Kiểm export cloud, không chạy game
python Collector/archive/cloud-export/RiotOverlay-local/tools/verify_export.py
# So sánh source local/cloud, đọc evidence lab đã có
python Collector/scripts/audit-import.py
# Build và managed lab offline, không injection hoặc game access
powershell -NoProfile -File Collector/scripts/build-validate.ps1
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
