"""Validate local layout and Markdown links without starting collector or game."""
import hashlib
import json
from pathlib import Path
import re
import urllib.parse

ROOT = Path(__file__).resolve().parent.parent
required = [
    'hosts/lb-host/src/LeagueCollector/LeagueCollector.csproj',
    'hosts/independent-reader/native/include/lc_reader.h',
    'bundles/lb-host/LeagueCollector.dll',
    'bundles/independent-reader/IndependentCollector.dll',
    'evidence/validation/single-inject-attempt-20261014.json',
    'archive/cloud-export/RiotOverlay-local/EXPORT-MANIFEST.json',
    'scripts/NuGet.offline.config',
]
failures = []
for name in required:
    if not (ROOT / name).is_file():
        failures.append({'reason': 'required-file-missing', 'path': name})
links = 0
for document in [ROOT / 'README.vi.md', *(ROOT / 'docs').glob('*.md')]:
    for target in re.findall(r'\]\(([^)]+)\)', document.read_text(encoding='utf-8-sig')):
        if target.startswith(('https:', 'http:', '#')):
            continue
        target = urllib.parse.unquote(target.split('#', 1)[0])
        links += 1
        if not (document.parent / target).is_file():
            failures.append({'reason': 'broken-link', 'document': str(document.relative_to(ROOT)), 'target': target})
native = ROOT / 'hosts/lb-host/native/lblib.dll'
native_hash = hashlib.sha256(native.read_bytes()).hexdigest()
if native_hash != 'a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3':
    failures.append({'reason': 'native-hash-mismatch'})
report = {'kind': 'collector-layout-check', 'passed': not failures, 'localLinksChecked': links,
          'nativeHashUnchanged': not any(x['reason'] == 'native-hash-mismatch' for x in failures),
          'gameExecuted': False, 'failures': failures}
(ROOT / 'evidence/import/layout-verification-20261014.json').write_text(json.dumps(report, ensure_ascii=False, indent=2) + '\n')
print(json.dumps(report, ensure_ascii=False, indent=2))
raise SystemExit(0 if report['passed'] else 1)
