"""Bounded account-only check: no game/LCU/native load, safe metadata output."""
import hashlib
import json
from pathlib import Path
import subprocess
import os
from datetime import datetime, timezone
from uuid import uuid4

ROOT = Path(__file__).resolve().parent.parent
SDK = ROOT.parent / '.npm-cache/lb-headless/dotnet-10.0.401/dotnet.exe'
HOST = ROOT / 'hosts/lb-host/src/LeagueCollector/bin/Release/net10.0/LeagueCollector.dll'
CONFIG = ROOT / 'config/collector.env'
CONFIG = CONFIG if CONFIG.is_file() else HOST.with_name('collector.env')
allowed = {'not-configured', 'authenticated', 'authenticated-subscription-unavailable', 'authentication-failed', 'challenge-signing-failed'}
report = {'kind': 'collector-account-auth-check', 'startedAt': datetime.now(timezone.utc).isoformat(),
          'gameAccessed': False, 'nativeConnected': False, 'nativeAuthorizationVerified': False,
          'collectorStarted': False, 'tokensPersisted': False,
          'credentialFilePresent': CONFIG.is_file(),
          'hostSha256': hashlib.sha256(HOST.read_bytes()).hexdigest()}
try:
    # The host auth-check branch exits before server/watchers. Raw stdout/stderr
    # stay in RAM and are discarded; only allowlisted JSON fields are persisted.
    result = subprocess.run([str(SDK), str(HOST), '--auth-check', '--no-inject', '--no-lcu'],
                            capture_output=True, timeout=45, creationflags=subprocess.CREATE_NO_WINDOW,
                            env={**os.environ, 'LB_CREDENTIAL_FILE': str(CONFIG)})
    report['exitCode'] = result.returncode
    parsed = None
    for line in result.stdout.decode('utf-8', errors='replace').splitlines():
        try:
            value = json.loads(line)
            if isinstance(value, dict) and value.get('state') in allowed:
                parsed = value
        except ValueError:
            pass
    report['state'] = parsed['state'] if parsed else 'result-unavailable'
    report['subscriptionFeatureCount'] = len(parsed['features']) if parsed and isinstance(parsed.get('features'), list) else None
    report['scope'] = 'Account login/subscription lookup only; no native challenge is generated.'
except subprocess.TimeoutExpired:
    report['state'] = 'timeout-owned-auth-process-stopped'
    report['exitCode'] = None
folder = ROOT / 'evidence/validation'
folder.mkdir(parents=True, exist_ok=True)
path = folder / ('account-auth-' + datetime.now(timezone.utc).strftime('%Y-%m-%dT%H-%M-%S') + '-' + uuid4().hex + '.json')
path.write_text(json.dumps(report, ensure_ascii=False, indent=2) + '\n', encoding='utf-8')
print(json.dumps({**report, 'evidence': str(path.relative_to(ROOT))}, ensure_ascii=False))
raise SystemExit(0 if report['state'] in {'authenticated', 'authenticated-subscription-unavailable', 'not-configured'} else 1)
