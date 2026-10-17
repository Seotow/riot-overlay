#!/usr/bin/env python3
"""Build the independent C ABI with g++ (no lblib, managed or network dependency)."""
import argparse
import json
import os
from pathlib import Path
import subprocess
import sys

ROOT = Path(__file__).resolve().parent

def main():
    parser = argparse.ArgumentParser()
    parser.add_argument("--test", action="store_true")
    parser.add_argument("--sanitize", action="store_true", help="UBSan build for fixture tests")
    args = parser.parse_args()
    build = ROOT / "build"
    build.mkdir(exist_ok=True)
    output = build / ("lc_reader.dll" if os.name == "nt" else "liblc_reader.so")
    command = [os.environ.get("CXX", "g++"), "-std=c++17", "-Wall", "-Wextra", "-Wpedantic", "-Werror",
               "-DLC_READER_BUILD", "-fPIC", "-shared", "-fvisibility=hidden", "-O2", "-g",
               "-I", str(ROOT / "include"), str(ROOT / "src/lc_reader.cpp"),
               str(ROOT / "src/win32_reader.cpp"), "-o", str(output)]
    if args.sanitize:
        command += ["-fsanitize=undefined", "-fno-sanitize-recover=all"]
    subprocess.run(command, check=True)
    print(json.dumps({"library": str(output), "apiVersion": 1, "sanitizer": "undefined" if args.sanitize else None}))
    if args.test:
        subprocess.run([sys.executable, str(ROOT / "tests/test_reader.py"), str(output)], check=True)

if __name__ == "__main__":
    main()
