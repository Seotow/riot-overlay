#!/usr/bin/env python3
"""Exercise the exported ABI against sparse memory, not a mocked JSON serializer."""
import copy
import ctypes as C
import hashlib
import json
import math
from pathlib import Path
import struct
import sys

ROOT = Path(__file__).resolve().parent.parent
FIXTURE = ROOT / "tests/fixtures/memory.json"
PROFILE = ROOT / "profiles/sparse-fixture-v1.json"
READ = C.CFUNCTYPE(C.c_size_t, C.c_void_p, C.c_uint64, C.c_void_p, C.c_size_t)

class Error(C.Structure):
    _fields_ = [("code", C.c_int32), ("message", C.c_char * 256)]

class Target(C.Structure):
    _fields_ = [("struct_size", C.c_uint32), ("module_name", C.c_char_p),
                ("version", C.c_char_p), ("sha256", C.c_char_p), ("module_base", C.c_uint64)]

class Request(C.Structure):
    _fields_ = [("struct_size", C.c_uint32), ("hero_addresses", C.POINTER(C.c_uint64)),
                ("hero_count", C.c_size_t), ("heroes_known", C.c_uint32)]

class SparseMemory:
    def __init__(self):
        doc = json.loads(FIXTURE.read_text())
        self.bytes = {}
        self.calls = []
        self.module_base = int(doc["moduleBase"], 16)
        self.heroes = [int(x, 16) for x in doc["heroAddresses"]]
        for segment in doc["segments"]:
            address = int(segment["address"], 16)
            self.write(address, bytes.fromhex(segment["hex"]))
        self.callback = READ(self.read)

    def write(self, address, data):
        self.bytes.update({address + i: byte for i, byte in enumerate(data)})

    def read(self, _context, address, destination, requested):
        self.calls.append((address, requested))
        data = bytearray()
        for i in range(requested):
            byte = self.bytes.get(address + i)
            if byte is None:
                break
            data.append(byte)
        if data:
            C.memmove(destination, bytes(data), len(data))
        return len(data)

class Harness:
    def __init__(self, path):
        self.lib = C.CDLL(str(path))
        self.lib.lc_reader_api_version.restype = C.c_uint32
        self.lib.lc_reader_create.argtypes = [C.c_char_p, C.c_size_t, C.POINTER(Target), READ,
            C.c_void_p, C.c_uint32, C.POINTER(C.c_void_p), C.POINTER(Error)]
        self.lib.lc_reader_create.restype = C.c_int32
        self.lib.lc_reader_snapshot.argtypes = [C.c_void_p, C.POINTER(Request), C.POINTER(C.c_void_p),
            C.POINTER(C.c_size_t), C.POINTER(Error)]
        self.lib.lc_reader_snapshot.restype = C.c_int32
        self.lib.lc_reader_free_buffer.argtypes = [C.c_void_p]
        self.lib.lc_reader_destroy.argtypes = [C.c_void_p]
        self.lib.lc_reader_win32_open.argtypes = [C.c_uint32, C.POINTER(C.c_void_p), C.POINTER(Error)]
        self.lib.lc_reader_win32_open.restype = C.c_int32
        self.profile = json.loads(PROFILE.read_text())
        self.digest = hashlib.sha256(FIXTURE.read_bytes()).hexdigest().encode()
        self.results = []

    def create(self, memory, profile=None, flags=1, target_changes=None, expected=0):
        raw = json.dumps(profile if profile is not None else self.profile).encode()
        target = Target(C.sizeof(Target), b"sparse-fixture.bin", b"fixture-v1", self.digest, memory.module_base)
        for key, value in (target_changes or {}).items():
            setattr(target, key, value)
        handle = C.c_void_p(123)
        error = Error()
        rc = self.lib.lc_reader_create(raw, len(raw), C.byref(target), memory.callback, None,
            flags, C.byref(handle), C.byref(error))
        assert rc == expected, (rc, expected, error.message.decode())
        if rc:
            assert not handle.value
        return handle

    def snapshot(self, handle, memory, known=1, addresses=None, expected=0):
        addresses = memory.heroes if addresses is None else addresses
        roots = (C.c_uint64 * len(addresses))(*addresses)
        request = Request(C.sizeof(Request), roots, len(addresses), known)
        out = C.c_void_p(123)
        length = C.c_size_t(123)
        error = Error()
        rc = self.lib.lc_reader_snapshot(handle, C.byref(request), C.byref(out), C.byref(length), C.byref(error))
        assert rc == expected, (rc, expected, error.message.decode())
        if rc:
            assert not out.value and length.value == 0
            return None
        try:
            raw = C.string_at(out, length.value)
            assert C.string_at(out, length.value + 1)[-1:] == b"\0"
            return json.loads(raw)
        finally:
            self.lib.lc_reader_free_buffer(out)

    def check(self, name, test):
        test()
        self.results.append({"name": name, "passed": True})

    def run(self):
        assert self.lib.lc_reader_api_version() == 1

        def golden():
            memory = SparseMemory()
            handle = self.create(memory)
            try:
                result = self.snapshot(handle, memory)
                hero, dead = result["data"]["heroes"]
                assert result["data"]["gameTime"] == 900.5
                assert hero["info"]["position"] == {"x": 5400, "y": 52, "z": 6800}
                assert hero["info"]["name"] == "Fixture Ahri"
                assert hero["common"] == {"health": 1250, "maxHealth": 1600, "level": 11}
                assert [hero[k] for k in ["gold", "totalGold", "kills", "deaths", "assists"]] == [1350, 7800, 3, 1, 5]
                assert dead["common"]["health"] == 0 and dead["gold"] == 0
                assert result["synthetic"] is True
                assert result["metadata"]["issueCount"] == 0
                assert result["metadata"]["runtimeVerified"] is False
                assert result["metadata"]["objectDiscoveryAvailable"] is False
                assert result["metadata"]["authenticationRequired"] is False
                assert result["metadata"]["originalLibraryLoaded"] is False
                (ROOT / "tests/fixture-snapshot.json").write_text(json.dumps(result, indent=2) + "\n")
            finally:
                self.lib.lc_reader_destroy(handle)
        self.check("sparse-memory: position, health, gold, KDA, pointer string, legitimate zero", golden)

        def missing():
            memory = SparseMemory()
            del memory.bytes[memory.heroes[0] + 32]
            memory.write(memory.heroes[0] + 44, struct.pack("<f", math.nan))
            handle = self.create(memory)
            try:
                result = self.snapshot(handle, memory)
                hero = result["data"]["heroes"][0]
                assert hero["common"]["health"] is None and hero["gold"] is None
                assert hero["totalGold"] == 7800
                assert {x["reason"] for x in result["metadata"]["issues"]} == {"read_failed", "non_finite"}
            finally:
                self.lib.lc_reader_destroy(handle)
        self.check("unreadable fields and non-finite floats remain null", missing)

        def bounds():
            memory = SparseMemory()
            handle = self.create(memory)
            try:
                result = self.snapshot(handle, memory, addresses=[0, 0xffffffffffffffff])
                assert all(v is None for v in result["data"]["heroes"][0]["common"].values())
                assert all(address >= 0x10000 and address <= 0x7fffffffffff for address, _ in memory.calls)
                previous = len(memory.calls)
                self.snapshot(handle, memory, addresses=[memory.heroes[0]] * 65, expected=5)
                assert len(memory.calls) == previous
                self.snapshot(handle, memory, known=0, addresses=[memory.heroes[0]], expected=1)
                result = self.snapshot(handle, memory, known=0, addresses=[])
                assert result["data"]["heroes"] is None
                result = self.snapshot(handle, memory, known=1, addresses=[])
                assert result["data"]["heroes"] == []
            finally:
                self.lib.lc_reader_destroy(handle)
        self.check("pointer/count bounds and unknown discovery versus known empty", bounds)

        def identity():
            memory = SparseMemory()
            for change in [{"version": b"other"}, {"sha256": b"0" * 64}, {"module_name": b"other.bin"}]:
                self.create(memory, target_changes=change, expected=3)
            self.create(memory, flags=0, expected=4)
            assert not memory.calls
            profile = copy.deepcopy(self.profile)
            profile["validation"]["status"] = "static-derived"
            self.create(memory, profile, flags=0, expected=4)
            handle = self.create(memory, profile, flags=2)
            try:
                assert self.snapshot(handle, memory)["metadata"]["runtimeVerified"] is False
            finally:
                self.lib.lc_reader_destroy(handle)
        self.check("measured version/hash/module mismatch and explicit experimental opt-in", identity)

        def profile_validation():
            memory = SparseMemory()
            mutations = []
            p = copy.deepcopy(self.profile); p["schemaVersion"] = 2; mutations.append(p)
            p = copy.deepcopy(self.profile); p["fields"][0]["offset"] = 0x40000000; mutations.append(p)
            p = copy.deepcopy(self.profile); p["fields"][0]["evidenceId"] = "missing"; mutations.append(p)
            p = copy.deepcopy(self.profile); p["fields"][0]["derefOffsets"] = [0] * 9; mutations.append(p)
            p = copy.deepcopy(self.profile); p["fields"][0]["typoOffset"] = 123; mutations.append(p)
            p = copy.deepcopy(self.profile); p["fields"].append(p["fields"][0]); mutations.append(p)
            p = copy.deepcopy(self.profile); p["fields"][1]["path"] = "common"; mutations.append(p)
            p = copy.deepcopy(self.profile); p["validation"]["status"] = "verified"; mutations.append(p)
            p = copy.deepcopy(self.profile); p["fields"][-1]["maxBytes"] = 1025; mutations.append(p)
            for p in mutations:
                self.create(memory, p, expected=2)
            assert not memory.calls
        self.check("profile evidence, overlapping path, offset, chain, string and schema rejection", profile_validation)

        def pointer_and_string():
            for pointer in [0, 0xffffffffffffffff]:
                memory = SparseMemory()
                memory.write(memory.heroes[0] + 64, struct.pack("<Q", pointer))
                handle = self.create(memory)
                try:
                    result = self.snapshot(handle, memory)
                    assert result["data"]["heroes"][0]["info"]["name"] is None
                    assert any(x["reason"] == "invalid_pointer" for x in result["metadata"]["issues"])
                finally:
                    self.lib.lc_reader_destroy(handle)
            for text, reason in [(b"x" * 64, "string_not_terminated"), (b"\xff\0", "invalid_utf8")]:
                memory = SparseMemory()
                memory.write(0x3000000, text)
                handle = self.create(memory)
                try:
                    result = self.snapshot(handle, memory)
                    assert result["data"]["heroes"][0]["info"]["name"] is None
                    assert any(x["reason"] == reason for x in result["metadata"]["issues"])
                finally:
                    self.lib.lc_reader_destroy(handle)
        self.check("null/invalid pointer, bounded unterminated string and malformed UTF-8", pointer_and_string)

        def budget():
            memory = SparseMemory()
            p = copy.deepcopy(self.profile)
            p["fields"] = [{"root": "hero", "path": "field" + str(i), "offset": 0,
                "type": "utf8", "maxBytes": 1024, "evidenceId": "sparse-memory"} for i in range(128)]
            memory.write(memory.heroes[0], b"x" * 1024)
            handle = self.create(memory, p)
            try:
                result = self.snapshot(handle, memory, addresses=[memory.heroes[0]] * 64)
                meta = result["metadata"]
                assert meta["readCalls"] <= 16384 and meta["bytesRequested"] <= 2 * 1024 * 1024
                assert meta["issueCount"] == 8192 and len(meta["issues"]) == 256
                assert meta["issuesTruncated"] is True
            finally:
                self.lib.lc_reader_destroy(handle)
        self.check("per-snapshot read budget and bounded diagnostic output", budget)

        if sys.platform != "win32":
            def platform():
                context = C.c_void_p(123)
                error = Error()
                rc = self.lib.lc_reader_win32_open(1, C.byref(context), C.byref(error))
                assert rc == 7 and not context.value
            self.check("Win32 adapter unavailable on Linux without fake fallback", platform)
        report = {"apiVersion": 1, "allPassed": True, "checks": self.results,
                  "runtimeParityTested": False, "fixtureSha256": self.digest.decode()}
        (ROOT / "tests/verification.json").write_text(json.dumps(report, indent=2) + "\n")
        print(json.dumps(report))

if __name__ == "__main__":
    Harness(Path(sys.argv[1]) if len(sys.argv) > 1 else ROOT / "build/liblc_reader.so").run()
