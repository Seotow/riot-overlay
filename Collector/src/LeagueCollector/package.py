"""Create reviewed Windows/runtime and source packages, excluding credentials."""
from pathlib import Path
import hashlib
import json
import shutil
import zipfile

ROOT = Path(__file__).resolve().parent
OUTPUT = ROOT.parent

def archive(name, prefix, files, extra=None):
    manifest=[]
    path=OUTPUT/name
    with zipfile.ZipFile(path, 'w', zipfile.ZIP_DEFLATED, compresslevel=6) as z:
        for relative, source in sorted(files.items()):
            if Path(relative).name == 'collector.env' or relative.startswith(('recordings/','test-results/')):
                raise ValueError('Credential/recording file cannot be packaged')
            data=source.read_bytes()
            manifest.append({'path':relative,'bytes':len(data),'sha256':hashlib.sha256(data).hexdigest()})
            z.writestr(prefix+relative,data)
        for relative, text in (extra or {}).items():
            data=text.encode();z.writestr(prefix+relative,data)
            manifest.append({'path':relative,'bytes':len(data),'sha256':hashlib.sha256(data).hexdigest()})
        z.writestr(prefix+'package-manifest.json',json.dumps({'files':manifest},indent=2))
    with zipfile.ZipFile(path) as z:
        assert z.testzip() is None
        for item in manifest:
            assert hashlib.sha256(z.read(prefix+item['path'])).hexdigest()==item['sha256']
    return {'path':str(path),'bytes':path.stat().st_size,'sha256':hashlib.sha256(path.read_bytes()).hexdigest(),
            'payload_files':len(manifest),'crc_and_sha256_verified':True,'credential_files_included':False}

def main():
    app=ROOT/'dist/app';runtime=ROOT/'dist/windows-runtime'
    if not (app/'LeagueCollector.dll').exists(): raise SystemExit('Run build.py first.')
    if not (runtime/'dotnet.exe').exists(): raise SystemExit('Run fetch_runtime.py first.')
    verification=ROOT/'verification';verification.mkdir(exist_ok=True)
    for name in ['integration.json','auth-check.json','runtime-verification.json','self-test.json']:
        source=ROOT/'build-logs'/name
        if source.exists():shutil.copy2(source,verification/name)
    summary={'release':'2026-10-14-status-update','native_game_tested':False,'windows_runtime_executed':False,'native_cpp_source_complete':False,
             'free_tier_parity_verified':False,'unauthenticated_native_verified':False,
             'managed_build_errors':0,'native_dependency':'original lblib.dll',
             'native_sha256':'a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3',
             'authentication_status':'previous login succeeded; subscription lookup returned 404; entitlements unresolved',
             'native_events':'raw events; objective classification and timers not integrated',
             'serializer_limitations':['some native struct inline vectors not exported'],
             'remaining_blockers':['Windows/LoL runtime validation','same-match comparison with LB Free','native acceptance without authentication unverified']}
    (verification/'status.json').write_text(json.dumps(summary,indent=2))
    windows={}
    for p in app.rglob('*'):
        if p.is_file() and (p.suffix=='.dll' or p.name in ['LeagueCollector.deps.json','LeagueCollector.runtimeconfig.json','lblib.dll.version.json'] or 'wwwroot' in p.relative_to(app).parts):
            windows[p.relative_to(app).as_posix()]=p
    for p in runtime.rglob('*'):
        if p.is_file():windows['runtime/'+p.relative_to(runtime).as_posix()]=p
    for name in ['README.vi.md','STATUS.vi.md','WINDOWS-TEST.vi.md','THIRD-PARTY.md','collector.env.example']:
        windows[name]=ROOT/name
    for p in (ROOT/'reference').glob('*'):
        if p.is_file():windows['reference/'+p.name]=p
    for p in verification.glob('*.json'):windows['verification/'+p.name]=p
    windows['verification/runtime-sources.json']=ROOT/'runtime-sources.json'
    def launch(args):
        return '@echo off\r\ncd /d "%~dp0"\r\n"runtime\\dotnet.exe" "LeagueCollector.dll" '+args+' %*\r\npause\r\n'
    scripts={'start-collector.cmd':launch('--source lblib'),'start-demo.cmd':launch('--source demo --no-lcu'),
             'start-live-api.cmd':launch('--source live'),'diagnose.cmd':launch('--doctor'),
             'export-diagnostics.cmd':launch('--export-diagnostics'),
             'start-test.cmd':'@echo off\r\nsetlocal\r\ncd /d "%~dp0"\r\nif not exist "test-results" mkdir "test-results"\r\nset "LB_TEST_RUN=test-results\\run-%RANDOM%-%RANDOM%"\r\nmkdir "%LB_TEST_RUN%"\r\nif errorlevel 1 (echo Could not create test directory.& pause & exit /b 1)\r\necho Dashboard: http://127.0.0.1:18799/\r\necho Results: %LB_TEST_RUN%\r\necho Press Ctrl+C to stop and finish the recording.\r\n"runtime\\dotnet.exe" "LeagueCollector.dll" --source lblib --record "%LB_TEST_RUN%\\frames.ndjson" %* > "%LB_TEST_RUN%\\collector.log" 2>&1\r\necho Collector exited. Results: %LB_TEST_RUN%\r\npause\r\n',
             'start-replay.cmd':'@echo off\r\nif "%~1"=="" (echo Drag an NDJSON file onto this script.& pause & exit /b 2)\r\ncd /d "%~dp0"\r\n"runtime\\dotnet.exe" "LeagueCollector.dll" --replay %*\r\npause\r\n'}
    results=[archive('LeagueCollector-Windows-x64.zip','LeagueCollector/',windows,scripts)]
    source={}
    for folder in ['src','vendor','lib','native','tests','fixtures','verification','reference']:
        for p in (ROOT/folder).rglob('*'):
            if p.is_file() and not {'bin','obj','__pycache__'} & set(p.relative_to(ROOT).parts):source[p.relative_to(ROOT).as_posix()]=p
    for name in ['README.vi.md','STATUS.vi.md','WINDOWS-TEST.vi.md','THIRD-PARTY.md','collector.env.example','NuGet.Config','.gitignore','build.py','fetch_runtime.py','package.py','runtime-sources.json']:
        source[name]=ROOT/name
    native_analysis=OUTPUT/'native'
    for name in ['ANALYSIS.vi.md','pseudocode-index.json','client-auth-deadline-assembly.txt','tcp-session-constructor-assembly.txt','pipe-session-constructor-assembly.txt']:
        source['analysis/native/'+name]=native_analysis/name
    for p in (native_analysis/'pseudocode').glob('*.cpp'):
        source['analysis/native/pseudocode/'+p.name]=p
    results.append(archive('LeagueCollector-source.zip','LeagueCollector-source/',source))
    (ROOT/'delivery.json').write_text(json.dumps(results,indent=2));print(json.dumps(results,indent=2))

if __name__=='__main__':main()
