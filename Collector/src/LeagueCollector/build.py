"""Build with the .NET 10 SDK's compiler; no NuGet restore is needed.

The SDK project also supports normal dotnet build on Windows. This compiler path
avoids the managed cloud's unavailable NuGet migration named mutex.
"""
from pathlib import Path
import hashlib
import json
import os
import shutil
import subprocess
import sys

ROOT = Path(__file__).resolve().parent
SDK = Path(os.environ.get('DOTNET_ROOT', '/workspace/.tools/dotnet'))
DOTNET = SDK / ('dotnet.exe' if os.name == 'nt' else 'dotnet')

def version(path):
    return tuple(int(part) for part in path.name.split('-')[0].split('.'))

def main():
    compiler = max((SDK / 'sdk').glob('10.*'), key=version) / 'Roslyn/bincore/csc.dll'
    core = max((SDK / 'packs/Microsoft.NETCore.App.Ref').glob('10.*'), key=version) / 'ref/net10.0'
    web = max((SDK / 'packs/Microsoft.AspNetCore.App.Ref').glob('10.*'), key=version) / 'ref/net10.0'
    refs = {path.name: path for path in list(core.glob('*.dll')) + list(web.glob('*.dll'))}
    libs = {path.name: path for path in (ROOT / 'lib').glob('*.dll') if path.name != 'Farsight.dll'}
    out = ROOT / 'dist/app'; out.mkdir(parents=True, exist_ok=True)
    logs = ROOT / 'build-logs'; logs.mkdir(exist_ok=True)
    def compile(name, sources, extra, target='library'):
        parameters = ['-nologo', '-nullable:enable', '-langversion:14', '-unsafe', '-platform:x64',
                      '-target:' + target, '-out:' + str(out / (name + '.dll'))]
        parameters += ['-r:' + str(p) for p in refs.values()]
        parameters += ['-r:' + str(p) for p in libs.values() if p.name not in refs]
        parameters += extra + [str(p) for p in sources]
        rsp = logs / (name + '.rsp'); rsp.write_text('\n'.join('"' + p + '"' for p in parameters))
        result = subprocess.run([str(DOTNET), str(compiler), '@' + str(rsp)], capture_output=True, text=True)
        output = result.stdout + result.stderr
        (logs / (name + '.log')).write_text(output)
        print(json.dumps({'assembly': name, 'errors': sum('error CS' in line for line in output.splitlines()),
                          'warnings': sum('warning CS' in line for line in output.splitlines()), 'exit_code': result.returncode}), flush=True)
        if result.returncode:
            print('\n'.join(line for line in output.splitlines() if 'error CS' in line), file=sys.stderr)
            raise SystemExit(result.returncode)
    vendor = ROOT / 'vendor/Farsight'
    compile('Farsight', sorted(p for p in vendor.rglob('*.cs') if not {'obj', 'bin'} & set(p.relative_to(vendor).parts)), ['-nullable:disable', '-resource:' + str(vendor / 'Farsight.angelscript-api.json') + ',Farsight.angelscript-api.json'])
    compile('LeagueCollector', sorted((ROOT / 'src/LeagueCollector').glob('*.cs')), ['-r:' + str(out / 'Farsight.dll')], 'exe')
    for path in libs.values(): shutil.copy2(path, out / path.name)
    shutil.copy2(out / 'Farsight.dll', ROOT / 'lib/Farsight.dll')
    shutil.copytree(ROOT / 'src/LeagueCollector/wwwroot', out / 'wwwroot', dirs_exist_ok=True)
    native = ROOT / 'native/lblib.dll'
    if native.exists():
        shutil.copy2(native, out / 'lblib.dll')
        shutil.copy2(ROOT / 'native/lblib.dll.version.json', out / 'lblib.dll.version.json')
    runtime = {'runtimeOptions': {'tfm': 'net10.0', 'frameworks': [
        {'name': 'Microsoft.NETCore.App', 'version': '10.0.0'},
        {'name': 'Microsoft.AspNetCore.App', 'version': '10.0.0'}]}}
    (out / 'LeagueCollector.runtimeconfig.json').write_text(json.dumps(runtime, indent=2))
    target = '.NETCoreApp,Version=v10.0'
    entries = {'LeagueCollector/1.0.0': {'dependencies': {name[:-4]: '1.0.0' for name in libs} | {'Farsight': '1.0.0'}, 'runtime': {'LeagueCollector.dll': {}}}}
    libraries = {'LeagueCollector/1.0.0': {'type': 'project', 'serviceable': False, 'sha512': ''}}
    for name in ['Farsight.dll'] + list(libs):
        key = name[:-4] + '/1.0.0'; entries[key] = {'runtime': {name: {}}}
        libraries[key] = {'type': 'reference', 'serviceable': False, 'sha512': ''}
    (out / 'LeagueCollector.deps.json').write_text(json.dumps({'runtimeTarget': {'name': target}, 'targets': {target: entries}, 'libraries': libraries}, indent=2))
    print(json.dumps({'app': str(out), 'app_sha256': hashlib.sha256((out / 'LeagueCollector.dll').read_bytes()).hexdigest()}))

if __name__ == '__main__': main()
