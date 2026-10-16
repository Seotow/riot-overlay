"""Offline handoff audit; hashes files and reads retained lab evidence only."""
import hashlib
import json
from pathlib import Path

ROOT = Path(__file__).resolve().parent.parent
CLOUD = ROOT / 'archive/cloud-export/RiotOverlay-local'
LOCAL = ROOT / 'src/LeagueCollector'

def digest(path):
    return hashlib.sha256(path.read_bytes()).hexdigest()

changes = []
for path in sorted(LOCAL.rglob('*')):
    if not path.is_file() or path.suffix not in {'.cs', '.csproj', '.props', '.targets', '.py'}:
        continue
    relative = path.relative_to(LOCAL)
    if any(part in {'bin', 'obj', '__pycache__'} for part in relative.parts):
        continue
    baseline = CLOUD / 'cloud-project/standalone' / relative
    local_hash = digest(path)
    cloud_hash = digest(baseline) if baseline.is_file() else None
    if local_hash != cloud_hash:
        changes.append({'path': relative.as_posix(), 'localSha256': local_hash,
                        'cloudSha256': cloud_hash,
                        'kind': 'modified' if cloud_hash else 'local-only'})

lab_path = ROOT / 'evidence/validation/managed-lab-2026-10-14T13-32-17-490Z-ef80476171a84b7dadc0e18f5783a601/lifecycle-self-test.json'
lab = json.loads(lab_path.read_text(encoding='utf-8-sig'))
native_local = LOCAL / 'native/lblib.dll'
native_cloud = CLOUD / 'cloud-project/native/lblib.dll'
verification = json.loads((ROOT / 'evidence/import/import-verification-20261014.json').read_text(encoding='utf-8'))
report = {'dateLocal': '2026-10-14', 'retainedArchiveVerification': verification,
          'validationRestored': LOCAL.is_dir(), 'sourceChanges': changes,
          'retainedLifecycleLab': lab, 'testsRerun': False,
          'nativeLocalSha256': digest(native_local), 'nativeCloudSha256': digest(native_cloud),
          'gameExecuted': False, 'authenticationPerformed': False}
output = ROOT / 'evidence/import/import-audit-20261014.json'
output.write_text(json.dumps(report, ensure_ascii=False, indent=2) + '\n', encoding='utf-8')
print(json.dumps({'output': str(output), 'changedSourceFiles': len(changes),
                  'nativeHashesMatch': report['nativeLocalSha256'] == report['nativeCloudSha256']}, indent=2))
