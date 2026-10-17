#!/usr/bin/env python3
"""Package the independent experiment, with per-file hashes and strict inputs.

No downloads, credentials, original lblib or old collector bundles are used.
"""
import argparse
import hashlib
import json
from pathlib import Path
import zipfile

ROOT = Path(__file__).resolve().parent
COLLECTOR = ROOT.parent.parent
BASELINE = COLLECTOR / "archive/cloud-export/RiotOverlay-local/cloud-project"
ORIGINAL_HASH = "a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3"
SKIP_PARTS = {"__pycache__", ".git", "build", "dist", "bin", "obj"}


def sha(raw): return hashlib.sha256(raw).hexdigest()


def add(files, name, path):
    name = str(name).replace("\\", "/")
    assert not name.startswith("/") and ".." not in Path(name).parts, name
    assert name not in files, "Duplicate entry: " + name
    assert Path(name).name.casefold() != "lblib.dll", "Original DLL must not enter independent package"
    raw = Path(path).read_bytes()
    assert sha(raw) != ORIGINAL_HASH, "Original DLL content detected"
    files[name] = raw


def tree(files, source, destination, allowed=None):
    for path in sorted(source.rglob("*")):
        relative = path.relative_to(source)
        if not path.is_file() or any(part in SKIP_PARTS for part in relative.parts): continue
        if path.name == "package-verification.json": continue
        if allowed is not None and path.suffix not in allowed: continue
        assert not path.name.startswith(".env"), "Credential filename refused"
        add(files, Path(destination) / relative, path)


def archive(path, prefix, files):
    manifest = {"package": prefix, "experimental": True, "originalLibraryIncluded": False,
                "gameRuntimeTested": False, "fullParityEstablished": False,
                "files": [{"path": name, "bytes": len(raw), "sha256": sha(raw)} for name, raw in sorted(files.items())]}
    files = {**files, "MANIFEST.json": (json.dumps(manifest, ensure_ascii=False, indent=2) + "\n").encode()}
    path.parent.mkdir(parents=True, exist_ok=True)
    with zipfile.ZipFile(path, "w", zipfile.ZIP_DEFLATED, compresslevel=9) as output:
        for name, raw in sorted(files.items()): output.writestr(prefix + "/" + name, raw)
    with zipfile.ZipFile(path) as output:
        assert output.testzip() is None, "Archive CRC failure"
        assert len(output.namelist()) == len(files)
        for name, raw in files.items(): assert sha(output.read(prefix + "/" + name)) == sha(raw)
    return {"name": path.name, "bytes": path.stat().st_size, "sha256": sha(path.read_bytes()),
            "files": len(files), "crcAndPerFileSha256Verified": True}


def main():
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("--output-dir", type=Path, default=COLLECTOR / "archive/packages")
    parser.add_argument("--analysis-dir", type=Path,
                        default=ROOT / "analysis/native" if (ROOT / "analysis/native").exists() else BASELINE / "native")
    parser.add_argument("--runtime-dir", type=Path, default=COLLECTOR / "bundles/lb-host/runtime")
    parser.add_argument("--runtime-metadata-dir", type=Path, default=BASELINE / "standalone")
    args = parser.parse_args()
    host = ROOT / "host/dist"
    required = [ROOT / "native/build/lc_reader.dll", ROOT / "native/build/windows-build.json",
                host / "IndependentCollector.dll", ROOT / "profiles/test-results.json",
                args.runtime_dir / "dotnet.exe", ROOT / "verification/status.json"]
    assert all(path.is_file() for path in required), "Build/test source and provide official runtime before packaging"
    status = json.loads((ROOT / "verification/status.json").read_text())
    assert status["fullParityEstablished"] is False
    for name, key in [("native/tests/verification.json", "allPassed"), ("host/tests/verification.json", "allPassed"),
                      ("profiles/test-results.json", "success"), ("parity/test-results.json", "success")]:
        assert json.loads((ROOT / name).read_text())[key] is True, "Tests must pass: " + name
    assert json.loads((ROOT / "profiles/test-results.json").read_text())["skipped"] == 0
    for folder, manifest_path, artifact in [("native", ROOT / "native/build/windows-build.json", "native/build/lc_reader.dll"),
                                            ("host", host / "build.json", "host/dist/IndependentCollector.dll")]:
        build = json.loads(manifest_path.read_text())
        expected = build["output"]["sha256"] if folder == "native" else build["sha256"]
        assert sha((ROOT / artifact).read_bytes()) == expected, "Built artifact hash mismatch"
        for name, expected in build["sourceSha256"].items():
            assert sha((ROOT / folder / name).read_bytes()) == expected, "Source changed after build: " + name
    assert (host / "lc_reader.dll").read_bytes() == (ROOT / "native/build/lc_reader.dll").read_bytes()
    source = {}
    for name in ["README.vi.md", "THIRD-PARTY.md", "WINDOWS-QUICKSTART.vi.md", "package.py"]:
        add(source, name, ROOT / name)
    for folder in ["native", "host", "profiles", "parity", "verification"]:
        tree(source, ROOT / folder, folder, {".py", ".h", ".cpp", ".cs", ".csproj", ".json", ".md", ".txt", ".cmd"})
    for name in ["lc_reader.dll", "liblc_reader.so", "windows-build.json"]:
        path = ROOT / "native/build" / name
        if path.exists(): add(source, "native/build/" + name, path)
    for path in sorted(host.rglob("*")):
        if path.is_file(): add(source, "host/dist/" + str(path.relative_to(host)), path)
    analysis = args.analysis_dir
    for name in ["ANALYSIS.vi.md", "artifact.json", "pseudocode-index.json", "snapshot-feature-checks.json",
                 "reconstruction-initializer-assembly.txt", "reconstruction-offset-references-assembly.txt"]:
        add(source, "analysis/native/" + name, analysis / name)
    for folder in ["pseudocode", "reconstruction", "scripts"]:
        tree(source, analysis / folder, "analysis/native/" + folder,
             {".py", ".cpp", ".c", ".java", ".json", ".md", ".txt", ".tsv"})
    # Include the exact REA evidence documents referenced by the recovered index.
    index = json.loads((analysis / "pseudocode-index.json").read_text())
    for name in sorted({item["evidence_file"] for item in index["records"]}):
        path = analysis / name
        assert path.resolve().is_relative_to(analysis.resolve())
        add(source, "analysis/native/" + name, path)
    windows = {}
    for path in sorted(host.rglob("*")):
        if path.is_file() and path.name != "liblc_reader.so": add(windows, path.relative_to(host), path)
    for src, dst in [("README.vi.md", "README.vi.md"), ("THIRD-PARTY.md", "THIRD-PARTY.md"),
                     ("WINDOWS-QUICKSTART.vi.md", "WINDOWS-QUICKSTART.vi.md"), ("host/README.vi.md", "HOST.vi.md")]:
        add(windows, dst, ROOT / src)
    for folder in ["profiles", "parity"]:
        tree(windows, ROOT / folder, "tools/" + folder, {".py", ".json", ".md"})
    add(windows, "native/README.vi.md", ROOT / "native/README.vi.md")
    add(windows, "native/include/lc_reader.h", ROOT / "native/include/lc_reader.h")
    add(windows, "host/README.vi.md", ROOT / "host/README.vi.md")
    tree(windows, ROOT / "native/third-party", "native/third-party")
    tree(windows, ROOT / "verification", "verification", {".json"})
    tree(windows, args.runtime_dir, "runtime")
    for name in ["runtime-sources.json", "verification/runtime-verification.json"]:
        path = args.runtime_metadata_dir / name
        add(windows, "runtime-evidence/" + name, path)
        add(source, "runtime-evidence/" + name, path)
    results = [archive(args.output_dir / "LeagueReader-independent-source.zip", "LeagueReader-source", source),
               archive(args.output_dir / "LeagueReader-independent-Windows-x64.zip", "LeagueReader-Windows-x64", windows)]
    sums = "".join(item["sha256"] + "  " + item["name"] + "\n" for item in results)
    (args.output_dir / "LeagueReader-independent-SHA256.txt").write_text(sums)
    (ROOT / "verification/package-verification.json").write_text(json.dumps({"packages": results,
        "originalLibraryIncluded": False, "credentialsIncluded": False, "gameRuntimeTested": False,
        "fullParityEstablished": False}, indent=2) + "\n")
    print(json.dumps(results, indent=2))


if __name__ == "__main__": main()
