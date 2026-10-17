#!/usr/bin/env python3
"""Cross-build Windows x64 DLL with an existing, user-local MinGW-w64 toolchain.

This script downloads/installs nothing. --toolchain-root is the extracted root
containing usr/bin/x86_64-w64-mingw32-g++-posix. Windows execution is not tested.
"""
import argparse
import hashlib
import json
import os
from pathlib import Path
import re
import shutil
import subprocess

ROOT = Path(__file__).resolve().parent
EXPORTS = {"lc_reader_api_version", "lc_reader_create", "lc_reader_destroy",
           "lc_reader_free_buffer", "lc_reader_profile_info", "lc_reader_snapshot",
           "lc_reader_win32_close", "lc_reader_win32_open", "lc_reader_win32_read"}

def sha(path):
    return hashlib.sha256(Path(path).read_bytes()).hexdigest()

def main():
    parser = argparse.ArgumentParser()
    parser.add_argument("--toolchain-root", type=Path)
    parser.add_argument("--compiler", help="Override existing cross-compiler executable")
    args = parser.parse_args()
    if args.compiler:
        compiler = Path(args.compiler).resolve()
    elif args.toolchain_root:
        compiler = args.toolchain_root.resolve() / "usr/bin/x86_64-w64-mingw32-g++-posix"
    else:
        found = shutil.which("x86_64-w64-mingw32-g++-posix") or shutil.which("x86_64-w64-mingw32-g++")
        if not found:
            raise SystemExit("MinGW-w64 not found; provide --toolchain-root or --compiler")
        compiler = Path(found)
    if not compiler.is_file():
        raise SystemExit("Cross-compiler file missing")
    build = ROOT / "build"
    build.mkdir(exist_ok=True)
    output = build / "lc_reader.dll"
    import_library = build / "liblc_reader.dll.a"
    command = [str(compiler), "-std=c++17", "-Wall", "-Wextra", "-Wpedantic", "-Werror",
        "-DLC_READER_BUILD", "-shared", "-O2", "-static", "-static-libgcc", "-static-libstdc++",
        "-frandom-seed=lc_reader_v1", "-I", "include", "src/lc_reader.cpp", "src/win32_reader.cpp",
        "-Wl,--no-insert-timestamp", "-Wl,--out-implib,build/liblc_reader.dll.a", "-o", "build/lc_reader.dll"]
    subprocess.run(command, cwd=ROOT, check=True)
    objdump = shutil.which("objdump")
    if not objdump:
        raise SystemExit("objdump required to inspect PE output")
    inspection = subprocess.run([objdump, "-p", str(output)], check=True, capture_output=True, text=True).stdout
    if "file format pei-x86-64" not in inspection:
        raise SystemExit("Unexpected PE architecture")
    imports = sorted(set(re.findall(r"DLL Name:\s*(\S+)", inspection)))
    export_section = inspection.split("[Ordinal/Name Pointer] Table", 1)[1].split("The Function Table", 1)[0]
    exports = sorted(set(re.findall(r"\b(lc_reader_\w+)\b", export_section)))
    if set(exports) != EXPORTS:
        raise SystemExit("Unexpected C ABI exports: " + repr(exports))
    if not set(x.lower() for x in imports) <= {"kernel32.dll", "msvcrt.dll"}:
        raise SystemExit("Unexpected non-system DLL import: " + repr(imports))
    inputs = [ROOT / "include/lc_reader.h", *sorted((ROOT / "src").glob("*.cpp")), Path(__file__)]
    manifest = {
        "apiVersion": 1,
        "target": "Windows x64 PE32+",
        "compiler": {"executable": str(compiler), "sha256": sha(compiler),
            "version": subprocess.check_output([str(compiler), "--version"], text=True).splitlines()[0]},
        "command": command,
        "sourceSha256": {str(p.relative_to(ROOT)): sha(p) for p in inputs},
        "output": {"file": "build/lc_reader.dll", "bytes": output.stat().st_size, "sha256": sha(output)},
        "importLibrary": {"file": "build/liblc_reader.dll.a", "sha256": sha(import_library)},
        "peImports": imports, "cAbiExports": exports,
        "crossBuildPassed": True, "peInspectionPassed": True,
        "windowsExecutionTested": False, "gameRuntimeTested": False, "lbParityVerified": False,
    }
    metadata = args.toolchain_root.parent / "metadata" if args.toolchain_root else None
    if metadata and (metadata / "selected.json").is_file():
        manifest["toolchainPackages"] = json.loads((metadata / "selected.json").read_text())
        manifest["toolchainSource"] = "https://deb.debian.org/debian/"
        manifest["metadataSha256"] = {p.name: sha(p) for p in [metadata / "InRelease", metadata / "Packages.xz"]}
        verification = metadata / "signature-verification.json"
        if verification.is_file():
            manifest["repositorySignatureVerification"] = json.loads(verification.read_text())
    (build / "windows-build.json").write_text(json.dumps(manifest, indent=2) + "\n")
    print(json.dumps({"file": str(output), "bytes": output.stat().st_size, "sha256": sha(output),
                      "imports": imports, "exports": exports, "windowsExecutionTested": False}))

if __name__ == "__main__":
    main()
