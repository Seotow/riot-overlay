#!/usr/bin/env python3
"""Compile using .NET 10 framework references; no NuGet, vendor DLL or auth code."""
from pathlib import Path
import hashlib
import json
import os
import shutil
import subprocess

ROOT = Path(__file__).resolve().parent
SDK = Path(os.environ.get("DOTNET_ROOT", "/workspace/.tools/dotnet"))
DOTNET = SDK / ("dotnet.exe" if os.name == "nt" else "dotnet")

def version(path):
    return tuple(int(x) for x in path.name.split("-")[0].split("."))

def main():
    compiler = max((SDK / "sdk").glob("10.*"), key=version) / "Roslyn/bincore/csc.dll"
    core = max((SDK / "packs/Microsoft.NETCore.App.Ref").glob("10.*"), key=version) / "ref/net10.0"
    web = max((SDK / "packs/Microsoft.AspNetCore.App.Ref").glob("10.*"), key=version) / "ref/net10.0"
    refs = {p.name: p for p in [*core.glob("*.dll"), *web.glob("*.dll")]}
    out = ROOT / "dist"; out.mkdir(exist_ok=True)
    logs = ROOT / "build-logs"; logs.mkdir(exist_ok=True)
    sources = sorted((ROOT / "src").glob("*.cs"))
    parameters = ["-nologo", "-nullable:enable", "-langversion:14", "-unsafe", "-platform:x64",
                  "-target:exe", "-out:" + str(out / "IndependentCollector.dll")]
    parameters += ["-r:" + str(p) for p in refs.values()] + [str(p) for p in sources]
    rsp = logs / "IndependentCollector.rsp"
    rsp.write_text("\n".join('"' + p + '"' for p in parameters))
    result = subprocess.run([str(DOTNET), str(compiler), "@" + str(rsp)], capture_output=True, text=True)
    output = result.stdout + result.stderr
    (logs / "IndependentCollector.log").write_text(output)
    summary = {"errors": sum("error CS" in line for line in output.splitlines()),
               "warnings": sum("warning CS" in line for line in output.splitlines()), "exitCode": result.returncode}
    print(json.dumps(summary), flush=True)
    if result.returncode:
        print(output)
        raise SystemExit(result.returncode)
    runtime = {"runtimeOptions": {"tfm": "net10.0", "frameworks": [
        {"name": "Microsoft.NETCore.App", "version": "10.0.0"},
        {"name": "Microsoft.AspNetCore.App", "version": "10.0.0"}]}}
    (out / "IndependentCollector.runtimeconfig.json").write_text(json.dumps(runtime, indent=2) + "\n")
    target = ".NETCoreApp,Version=v10.0"
    deps = {"runtimeTarget": {"name": target}, "targets": {target: {"IndependentCollector/0.1.0": {
        "runtime": {"IndependentCollector.dll": {}}}}}, "libraries": {"IndependentCollector/0.1.0": {
        "type": "project", "serviceable": False, "sha512": ""}}}
    (out / "IndependentCollector.deps.json").write_text(json.dumps(deps, indent=2) + "\n")
    native = ROOT.parent / "native/build"
    native_files = ["lc_reader.dll", "liblc_reader.so", "windows-build.json"]
    for name in native_files:
        if (native / name).is_file(): shutil.copy2(native / name, out / name)
    for path in (ROOT / "scripts").glob("*.cmd"):
        shutil.copy2(path, out / path.name)
    fixtures = out / "fixtures"; fixtures.mkdir(exist_ok=True)
    shutil.copy2(ROOT.parent / "native/profiles/sparse-fixture-v1.json", fixtures / "profile.json")
    shutil.copy2(ROOT.parent / "native/tests/fixtures/memory.json", fixtures / "memory.json")
    manifest = {"assembly": "IndependentCollector.dll", "sha256": hashlib.sha256((out / "IndependentCollector.dll").read_bytes()).hexdigest(),
        "references": sorted(refs), "vendorReferences": [], "nativeFiles": {name: hashlib.sha256((out / name).read_bytes()).hexdigest()
            for name in native_files if (out / name).is_file()}, "sourceSha256": {str(p.relative_to(ROOT)): hashlib.sha256(p.read_bytes()).hexdigest() for p in sources},
        "windowsExecutionTested": False, "gameParityVerified": False}
    (out / "build.json").write_text(json.dumps(manifest, indent=2) + "\n")
    print(json.dumps({"app": str(out), "sha256": manifest["sha256"]}))

if __name__ == "__main__":
    main()
