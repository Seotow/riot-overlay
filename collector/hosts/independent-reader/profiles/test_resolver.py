#!/usr/bin/env python3
"""Resolver tests use invented PE bytes, never a real game or account capture."""
import contextlib
import copy
import ctypes as C
import hashlib
import importlib.util
import io
import json
from pathlib import Path
import struct
import tempfile
import unittest

import resolve_profile as R

ROOT = Path(__file__).resolve().parent


def fake_pe():
    raw = bytearray(b"\0" * 0x3400)
    raw[:2] = b"MZ"
    struct.pack_into("<I", raw, 0x3c, 0x80)
    raw[0x80:0x84] = b"PE\0\0"
    struct.pack_into("<HH", raw, 0x84, 0x8664, 2)
    struct.pack_into("<H", raw, 0x94, 0xf0)
    struct.pack_into("<H", raw, 0x98, 0x20b)
    struct.pack_into("<Q", raw, 0x98 + 24, 0x140000000)
    struct.pack_into("<II", raw, 0x98 + 56, 0x5000, 0x400)
    for i, (name, size, rva, offset, flags) in enumerate([
        (b".text", 0x2000, 0x1000, 0x400, 0x60000020),
        (b".data", 0x1000, 0x4000, 0x2400, 0xc0000040),
    ]):
        at = 0x188 + i * 40
        raw[at:at + len(name)] = name
        struct.pack_into("<IIII", raw, at + 8, size, rva, size, offset)
        struct.pack_into("<I", raw, at + 36, flags)
    raw[0x400:0x2400] = b"\xcc" * 0x2000
    return raw


def put(raw, rva, code):
    offset = rva - 0x1000 + 0x400 if rva < 0x4000 else rva - 0x4000 + 0x2400
    raw[offset:offset + len(code)] = code


def signature(pattern, kind=0):
    return {"kind": "signature", "evidenceId": "test", "variants": [
        {"pattern": pattern, "resolveKind": kind, "knownConstant": False, "value": 0}]}


def populate_catalog(raw):
    catalog = json.loads((ROOT / "profile-catalog.json").read_text())
    patterns = {
        "0x180d21e20": (4, 0x4100 - (0x1100 + 8), 0x1100),
        "0x180d2d8a0": (3, 0x3c, 0x1200),
        "0x180d316c0": (3, 0x400, 0x1300),
        "0x180d335d0": (3, 0x500, 0x1400),
        "0x180d33160": (3, 0x600, 0x1500),
        "0x180d2fc20": (3, 0x300, 0x1600),
        "0x180d30090": (4, 0x700, 0x1700),
    }
    for key, (at, value, rva) in patterns.items():
        pattern = catalog["descriptors"][key]["variants"][0]["pattern"]
        code = bytearray(0 if x in {"?", "??"} else int(x, 16) for x in pattern.split())
        struct.pack_into("<i", code, at, value)
        put(raw, rva, code)
    return catalog


class ResolverTests(unittest.TestCase):
    def setUp(self):
        self.raw = fake_pe()

    def test_pe_rejects_malformed_headers_sections_and_architecture(self):
        variants = []
        for offset, data in [(0, b"NO"), (0x84, b"\x4c\x01"), (0x86, b"\xff\xff"),
                             (0x188 + 12, struct.pack("<I", 0x6000)),
                             (0x1b0 + 20, struct.pack("<I", 0x500))]:
            raw = self.raw.copy(); raw[offset:offset + len(data)] = data; variants.append(raw)
        variants += [self.raw[:0x90]]
        for raw in variants:
            with self.subTest(length=len(raw)), self.assertRaises(R.ResolveError): R.PEImage(raw)

    def test_scan_unique_wildcards_and_data_exclusion(self):
        put(self.raw, 0x1150, b"\x48\x8d\x93\x34\x12\0\0\xc3")
        put(self.raw, 0x4100, b"\x48\x8d\x93\x34\x12\0\0\xc3")
        result = R.scan_pattern(R.PEImage(self.raw), "48 8D 93 ? ?? 00 00 C3")
        self.assertEqual(result["matches"], [0x1150])
        self.assertEqual(result["status"], "unique_match")

    def test_ambiguity_and_anchor_limit_never_choose_first(self):
        put(self.raw, 0x1100, b"\x12\x34"); put(self.raw, 0x1200, b"\x12\x34")
        self.assertEqual(R.scan_pattern(R.PEImage(self.raw), "12 34")["status"], "ambiguous_matches")
        old = R.MAX_ANCHOR_HITS
        try:
            R.MAX_ANCHOR_HITS = 2
            self.assertEqual(R.scan_pattern(R.PEImage(self.raw), "CC ? 90")["status"], "anchor_hit_limit")
        finally: R.MAX_ANCHOR_HITS = old

    def test_pattern_and_section_boundary_bounds(self):
        for pattern in ["? ??", "48 GG", "A", "90 " * 257]:
            with self.assertRaises(R.ResolveError): R.parse_pattern(pattern)
        self.raw[0x23ff] = 0x12; self.raw[0x2400] = 0x34
        self.assertEqual(R.scan_pattern(R.PEImage(self.raw), "12 34")["status"], "not_found")

    def test_supported_instruction_displacements(self):
        for code, kind, expected in [
            ("48 81 C1 00 04 00 00", 0, 0x400), ("48 83 C0 28", 0, 40),
            ("48 8D 93 00 05 00 00", 0, 0x500), ("0F B6 88 3C 00 00 00", 1, 0x3c),
            ("0F B6 84 08 00 07 00 00", 3, 0x700), ("48 8B 41 10", 0, 16),
        ]:
            with self.subTest(code=code):
                put(self.raw, 0x1100, bytes.fromhex(code))
                self.assertEqual(R.decode_instruction(R.PEImage(self.raw), 0x1100, kind)["value"], expected)

    def test_relative_targets_and_match_rva(self):
        for code, size in [(b"\xe8", 5), (b"\xe9", 5), (bytes.fromhex("F3 0F 5C 35"), 8)]:
            put(self.raw, 0x1100, code + struct.pack("<i", 0x4100 - (0x1100 + size)))
            result = R.decode_instruction(R.PEImage(self.raw), 0x1100, 0)
            self.assertEqual((result["value"], result["valueKind"]), (0x4100, "module-rva"))
        self.assertEqual(R.decode_instruction(R.PEImage(self.raw), 0x1100, 2)["value"], 0x1100)

    def test_unsupported_negative_unmapped_and_truncated_are_unresolved(self):
        for code, kind, rva in [("90", 0, 0x1100), ("48 81 C1 FF FF FF FF", 0, 0x1100),
                                ("48 8B 89 FF FF FF FF", 0, 0x1100),
                                ("E8 00 00 00 7F", 0, 0x1100),
                                ("48 8B 0D 00 00 00 00", 1, 0x1100), ("E8", 0, 0x2fff)]:
            put(self.raw, rva, bytes.fromhex(code))
            with self.subTest(code=code), self.assertRaises(R.ResolveError):
                R.decode_instruction(R.PEImage(self.raw), rva, kind)

    def test_conflicting_and_ambiguous_variants_remain_unresolved(self):
        put(self.raw, 0x1100, bytes.fromhex("48 83 C0 10"))
        put(self.raw, 0x1200, bytes.fromhex("48 83 C1 20"))
        descriptor = signature("48 83 C0 10")
        descriptor["variants"] += signature("48 83 C1 20")["variants"]
        self.assertEqual(R.resolve_descriptor(R.PEImage(self.raw), descriptor)["status"], "unresolved")
        put(self.raw, 0x1300, bytes.fromhex("48 83 C1 20"))
        self.assertEqual(R.resolve_descriptor(R.PEImage(self.raw), descriptor)["status"], "unresolved")

    def test_real_catalog_recovers_thirteen_fields_from_invented_pe(self):
        catalog = populate_catalog(self.raw)
        identity = {"module": "fake-game.exe", "version": "test", "sha256": R.digest(self.raw),
                    "moduleBase": 0x140000000, "processId": 123}
        profile, report = R.resolve_catalog(R.PEImage(self.raw), catalog, "catalog", "a" * 64,
                                            identity, "identity", "b" * 64, "fake-game.exe")
        self.assertEqual(len(profile["fields"]), 13)
        offsets = {f["path"]: f["offset"] for f in profile["fields"]}
        self.assertEqual(offsets["common.maxHealth"], 0x428)
        self.assertEqual(offsets["gameTime"], 0x4100)
        self.assertEqual(profile["validation"]["status"], "static-derived")
        self.assertFalse(report["runtimeVerified"])
        self.assertFalse(report["fullParityEstablished"])
        self.assertFalse(report["objectDiscoveryAvailable"])
        self.assertEqual(report["summary"]["resolvedFields"], 13)

    def test_identity_hash_filename_and_fixture_rejected(self):
        identity = {"module": "game.exe", "version": "test", "sha256": "a" * 64,
                    "moduleBase": "0x140000000", "processId": 123, "measured": True, "synthetic": False}
        self.assertEqual(R.validate_identity(identity, "game.exe", "a" * 64)["processId"], 123)
        for change in [{"sha256": "b" * 64}, {"module": "other.exe"}, {"synthetic": True},
                       {"measured": False}, {"processId": True}, {"moduleBase": 0}]:
            with self.subTest(change=change), self.assertRaises(R.ResolveError):
                R.validate_identity({**identity, **change}, "game.exe", "a" * 64)

    def test_strict_json_duplicate_and_nonfinite(self):
        with tempfile.TemporaryDirectory() as directory:
            path = Path(directory) / "input.json"
            for value in ['{"x":1,"x":2}', '{"x":NaN}', '{"x":Infinity}']:
                path.write_text(value)
                with self.assertRaises((ValueError, R.ResolveError)): R.strict_json(path)

    def test_cli_identity_mismatch_and_overwrite_preserves_inputs(self):
        with tempfile.TemporaryDirectory() as directory:
            root = Path(directory)
            game = root / "game.exe"; game.write_bytes(self.raw)
            identity = root / "identity.json"
            identity.write_text(json.dumps({"module": "game.exe", "version": "test", "sha256": "0" * 64,
                "moduleBase": "0x140000000", "processId": 123, "measured": True, "synthetic": False}))
            catalog = root / "catalog.json"; catalog.write_text(json.dumps(populate_catalog(self.raw)))
            args = ["--game-exe", str(game), "--identity-json", str(identity), "--catalog", str(catalog),
                    "--profile-out", str(root / "profile.json"), "--report-out", str(root / "report.json")]
            with contextlib.redirect_stdout(io.StringIO()): self.assertEqual(R.main(args), 2)
            self.assertFalse((root / "profile.json").exists())
            original = game.read_bytes()
            args[-1] = str(game)
            with contextlib.redirect_stderr(io.StringIO()): self.assertEqual(R.main(args), 2)
            self.assertEqual(game.read_bytes(), original)

    def test_cli_full_offline_files_and_no_resolved_profile(self):
        with tempfile.TemporaryDirectory() as directory:
            root = Path(directory)
            catalog = populate_catalog(self.raw)
            game = root / "game.exe"; game.write_bytes(self.raw)
            identity = root / "identity.json"
            identity.write_text(json.dumps({"module": "game.exe", "version": "test", "sha256": R.digest(self.raw),
                "moduleBase": "0x140000000", "processId": 123, "measured": True, "synthetic": False}))
            catalog_file = root / "catalog.json"; catalog_file.write_text(json.dumps(catalog))
            output, report = root / "profile.json", root / "report.json"
            args = ["--game-exe", str(game), "--identity-json", str(identity), "--catalog", str(catalog_file),
                    "--profile-out", str(output), "--report-out", str(report)]
            with contextlib.redirect_stdout(io.StringIO()): self.assertEqual(R.main(args), 0)
            self.assertEqual(len(json.loads(output.read_text())["fields"]), 13)
            self.assertTrue(json.loads(report.read_text())["profileWritten"])
            self.assertEqual(game.read_bytes(), self.raw)
            catalog["fields"] = []; catalog_file.write_text(json.dumps(catalog))
            previous = output.read_bytes()
            with contextlib.redirect_stdout(io.StringIO()): self.assertEqual(R.main(args), 1)
            self.assertEqual(output.read_bytes(), previous)
            self.assertFalse(json.loads(report.read_text())["profileWritten"])

    def test_emitted_profile_loaded_and_read_by_own_c_abi(self):
        # Integration uses the real profile catalog, scanner and compiled core.
        library = ROOT.parent / "native/build/liblc_reader.so"
        if not library.exists(): self.skipTest("Build own Linux core before cross-component test")
        test_path = ROOT.parent / "native/tests/test_reader.py"
        spec = importlib.util.spec_from_file_location("reader_harness", test_path)
        native = importlib.util.module_from_spec(spec); spec.loader.exec_module(native)
        catalog = populate_catalog(self.raw)
        identity = {"module": "fake-game.exe", "version": "test", "sha256": R.digest(self.raw),
                    "moduleBase": 0x140000000, "processId": 123}
        profile, _ = R.resolve_catalog(R.PEImage(self.raw), catalog, "catalog", "a" * 64,
                                      identity, "identity", "b" * 64, "fake-game.exe")
        harness = native.Harness(library)
        memory = native.SparseMemory()
        hero = memory.heroes[0]
        memory.write(memory.module_base + 0x4100, struct.pack("<f", 123.5))
        memory.write(hero + 0xbc, struct.pack("<I", 424242))
        memory.write(hero + 0x400, struct.pack("<f", 875.0))
        memory.write(hero + 0x428, struct.pack("<f", 1200.0))
        handle = harness.create(memory, profile, flags=2, target_changes={
            "module_name": b"fake-game.exe", "version": b"test", "sha256": identity["sha256"].encode()})
        try:
            snapshot = harness.snapshot(handle, memory, addresses=[hero])
            self.assertEqual(snapshot["data"]["gameTime"], 123.5)
            self.assertEqual(snapshot["data"]["heroes"][0]["info"]["networkId"], 424242)
            self.assertEqual(snapshot["data"]["heroes"][0]["common"], {"health": 875, "maxHealth": 1200})
            self.assertIsNone(snapshot["data"]["heroes"][0]["gold"])
            self.assertFalse(snapshot["metadata"]["runtimeVerified"])
        finally: harness.lib.lc_reader_destroy(handle)


if __name__ == "__main__":
    result = unittest.TextTestRunner(verbosity=2).run(unittest.defaultTestLoader.loadTestsFromTestCase(ResolverTests))
    (ROOT / "test-results.json").write_text(json.dumps({"suite": "offline profile resolver and native ABI integration",
        "tests": result.testsRun, "failures": len(result.failures), "errors": len(result.errors),
        "skipped": len(result.skipped), "success": result.wasSuccessful(),
        "scope": "Invented PE and sparse-memory fixtures; no real game/account parity."}, indent=2) + "\n")
    raise SystemExit(0 if result.wasSuccessful() else 1)
