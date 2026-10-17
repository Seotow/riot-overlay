"""Fetch the pinned official Windows runtime, verifying published SHA-512."""
from pathlib import Path, PurePosixPath
import hashlib
import json
import shutil
import urllib.request
import zipfile

ROOT = Path(__file__).resolve().parent

def main():
    metadata = json.loads((ROOT / 'runtime-sources.json').read_text())
    cache = ROOT / 'runtime-downloads'; cache.mkdir(exist_ok=True)
    output = ROOT / 'dist/windows-runtime'; output.mkdir(parents=True, exist_ok=True)
    for item in metadata['files']:
        if not item['url'].startswith('https://builds.dotnet.microsoft.com/dotnet/'):
            raise ValueError('Unexpected runtime download host')
        path = cache / (item['component'] + '.zip')
        if not path.exists():
            with urllib.request.urlopen(item['url'], timeout=60) as response, path.open('wb') as destination:
                shutil.copyfileobj(response, destination)
        if hashlib.sha512(path.read_bytes()).hexdigest().lower() != item['hash'].lower():
            raise ValueError('Runtime SHA-512 mismatch: ' + path.name)
        with zipfile.ZipFile(path) as archive:
            if archive.testzip() is not None: raise ValueError('Runtime CRC failure')
            for name in archive.namelist():
                if name.startswith('/') or '..' in PurePosixPath(name).parts: raise ValueError('Unsafe ZIP member')
            archive.extractall(output)
        print(item['component'] + ': official SHA-512 verified', flush=True)

if __name__ == '__main__': main()
