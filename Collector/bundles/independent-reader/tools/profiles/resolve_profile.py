#!/usr/bin/env python3
"""Offline, bounded PE signature resolver for static-derived reader profiles.

Reads an AMD64 PE and an independently measured identity. Never loads or runs
the executable/DLL, attaches to a process, authenticates, or writes game files.
Instruction decoding deliberately covers a small documented subset only.
"""
from __future__ import annotations

import argparse
from collections import Counter
import hashlib
import json
import mmap
import ntpath
from pathlib import Path
import re
import struct
import sys

MAX_FILE = 512 * 1024 * 1024
MAX_SECTIONS = 96
MAX_SIGNATURES = 512
MAX_PATTERN = 256
MAX_ANCHOR_HITS = 8192
MAX_MATCHES = 2
MAX_OFFSET = 0x3fffffff
TYPES = {"u8", "i8", "u16", "i16", "u32", "i32", "u64", "i64", "f32", "f64", "bool", "vec3", "utf8"}


class ResolveError(ValueError):
    pass


def require(condition, message):
    if not condition:
        raise ResolveError(message)


def digest(raw):
    return hashlib.sha256(raw).hexdigest()


def unsigned(value, name, maximum=MAX_OFFSET, positive=False):
    if isinstance(value, str) and re.fullmatch(r"0x[0-9a-fA-F]+", value):
        value = int(value, 16)
    require(type(value) is int and (value > 0 if positive else value >= 0) and value <= maximum,
            "Invalid unsigned integer: " + name)
    return value


def address_key(value):
    require(isinstance(value, str) and re.fullmatch(r"0x[0-9a-fA-F]+", value), "Invalid descriptor address")
    return hex(unsigned(value, "descriptor address", (1 << 64) - 1, positive=True))


def text(value, name, maximum=2048):
    require(isinstance(value, str) and 0 < len(value.encode("utf-8")) <= maximum, "Invalid text: " + name)
    return value


def strict_json(path, max_bytes=16 * 1024 * 1024):
    path = Path(path)
    require(path.stat().st_size <= max_bytes, "JSON input exceeds size bound")
    raw = path.read_bytes()
    def unique(pairs):
        result = {}
        for key, value in pairs:
            require(key not in result, "Duplicate JSON property: " + key)
            result[key] = value
        return result
    def reject(value):
        raise ResolveError("Non-finite JSON literal: " + value)
    return json.loads(raw.decode("utf-8-sig"), object_pairs_hook=unique, parse_constant=reject), digest(raw)


class PEImage:
    """Map raw sections to RVA ranges without allocating SizeOfImage bytes."""
    def __init__(self, raw):
        self.raw = raw
        require(0x40 <= len(raw) <= MAX_FILE, "PE file size outside bound")
        require(raw[:2] == b"MZ", "Missing DOS signature")
        header = self.u32(0x3c)
        require(0x40 <= header and header + 24 <= len(raw), "PE header outside file")
        require(raw[header:header + 4] == b"PE\0\0", "Missing PE signature")
        machine, count = self.unpack("<HH", header + 4)
        require(machine == 0x8664, "PE must be AMD64")
        require(1 <= count <= MAX_SECTIONS, "PE section count outside bound")
        optional_size = self.u16(header + 20)
        optional = header + 24
        require(optional_size >= 0x70 and optional + optional_size <= len(raw), "Truncated PE optional header")
        require(self.u16(optional) == 0x20b, "PE must use PE32+")
        self.preferred_base = self.unpack("<Q", optional + 24)[0]
        self.image_size = self.u32(optional + 56)
        self.header_size = self.u32(optional + 60)
        require(0 < self.header_size <= len(raw) and self.header_size <= self.image_size,
                "Invalid image/header size")
        section_table = optional + optional_size
        require(section_table + count * 40 <= len(raw), "Truncated section table")
        self.sections = []
        for index in range(count):
            offset = section_table + index * 40
            name = bytes(raw[offset:offset + 8]).rstrip(b"\0").decode("ascii", "replace")
            virtual_size, rva, raw_size, pointer = self.unpack("<IIII", offset + 8)
            flags = self.u32(offset + 36)
            mapped_size = max(virtual_size, raw_size)
            require(rva >= self.header_size and mapped_size <= self.image_size and rva <= self.image_size - mapped_size,
                    "Section virtual range outside image")
            require(pointer <= len(raw) and raw_size <= len(raw) - pointer, "Section raw range outside file")
            if raw_size:
                require(pointer >= self.header_size, "Section overlaps PE headers")
            section = {"name": name, "rva": rva, "mappedSize": mapped_size,
                       "rawSize": raw_size, "rawOffset": pointer, "executable": bool(flags & 0x20000000)}
            for old in self.sections:
                require(not self.overlap(rva, mapped_size, old["rva"], old["mappedSize"]), "Overlapping virtual sections")
                if raw_size and old["rawSize"]:
                    require(not self.overlap(pointer, raw_size, old["rawOffset"], old["rawSize"]), "Overlapping raw sections")
            self.sections.append(section)
        self.executable = [section for section in self.sections if section["executable"] and section["rawSize"]]
        require(bool(self.executable), "No file-backed executable section")

    @staticmethod
    def overlap(a, n, b, m):
        return n > 0 and m > 0 and a < b + m and b < a + n

    def unpack(self, format, offset):
        size = struct.calcsize(format)
        require(0 <= offset and offset + size <= len(self.raw), "Truncated PE integer")
        return struct.unpack_from(format, self.raw, offset)

    def u16(self, offset):
        return self.unpack("<H", offset)[0]

    def u32(self, offset):
        return self.unpack("<I", offset)[0]

    def section_at(self, rva):
        for section in self.sections:
            if section["rva"] <= rva < section["rva"] + section["mappedSize"]:
                return section
        return None

    def instruction_window(self, rva, maximum=15):
        section = self.section_at(rva)
        require(section is not None and section["executable"], "Instruction RVA is not executable")
        relative = rva - section["rva"]
        require(relative < section["rawSize"], "Instruction has no raw backing")
        count = min(maximum, section["rawSize"] - relative)
        offset = section["rawOffset"] + relative
        return bytes(self.raw[offset:offset + count])

    def validate_rva(self, rva):
        require(0 <= rva < self.image_size and self.section_at(rva) is not None, "Resolved RVA is unmapped/outside image")
        return rva


def parse_pattern(pattern):
    require(isinstance(pattern, str), "Pattern must be text")
    parts = pattern.split()
    require(1 <= len(parts) <= MAX_PATTERN, "Pattern byte length outside bound")
    values = []
    for part in parts:
        if part in {"?", "??"}:
            values.append(None)
        else:
            require(re.fullmatch(r"[0-9a-fA-F]{2}", part) is not None, "Unsupported pattern token: " + part)
            values.append(int(part, 16))
    # A longest contiguous literal run avoids Python scanning of every byte.
    best_offset, best = 0, b""
    start = 0
    while start < len(values):
        if values[start] is None:
            start += 1
            continue
        end = start
        while end < len(values) and values[end] is not None:
            end += 1
        run = bytes(values[start:end])
        if len(run) > len(best):
            best_offset, best = start, run
        start = end
    require(bool(best), "All-wildcard signature is refused")
    return values, best_offset, best


def scan_pattern(pe, pattern):
    values, anchor_offset, anchor = parse_pattern(pattern)
    matches = []
    hits = 0
    literals = [(index, byte) for index, byte in enumerate(values) if byte is not None]
    for section in pe.executable:
        begin = section["rawOffset"]
        end = begin + section["rawSize"]
        cursor = begin
        while True:
            found = pe.raw.find(anchor, cursor, end)
            if found < 0:
                break
            cursor = found + 1
            hits += 1
            if hits > MAX_ANCHOR_HITS:
                return {"status": "anchor_hit_limit", "anchorHits": hits, "matches": matches}
            candidate = found - anchor_offset
            if candidate < begin or candidate + len(values) > end:
                continue
            if all(pe.raw[candidate + index] == byte for index, byte in literals):
                matches.append(section["rva"] + candidate - begin)
                if len(matches) >= MAX_MATCHES:
                    return {"status": "ambiguous_matches", "anchorHits": hits, "matches": matches}
    return {"status": "unique_match" if len(matches) == 1 else "not_found", "anchorHits": hits, "matches": matches}


def decode_instruction(pe, rva, resolve_kind):
    """Extract one immediate/displacement/relative target, never execute code."""
    require(type(resolve_kind) is int and resolve_kind in {0, 1, 2, 3}, "Unsupported resolve kind")
    pe.validate_rva(rva)
    if resolve_kind == 2:
        return {"value": rva, "valueKind": "module-rva", "method": "match-rva", "instructionLength": None}
    code = pe.instruction_window(rva)
    cursor = 0
    prefixes = []
    rex_seen = False
    def take(count):
        nonlocal cursor
        require(count > 0 and cursor + count <= len(code), "Truncated instruction")
        result = code[cursor:cursor + count]
        cursor += count
        return result
    while cursor < len(code) and (code[cursor] in {0xf2, 0xf3, 0x66} or 0x40 <= code[cursor] <= 0x4f):
        prefix = take(1)[0]
        require(len(prefixes) < 5, "Prefix count exceeds supported subset")
        if prefix in {0xf2, 0xf3, 0x66}:
            require(not rex_seen, "Legacy prefix after REX is outside supported subset")
        else:
            require(not rex_seen, "Multiple REX prefixes are outside supported subset")
            rex_seen = True
        prefixes.append(prefix)
    opcode = take(1)[0]
    if opcode in (0xe8, 0xe9):
        require(resolve_kind == 0, "Kind 1/3 require non-RIP memory displacement")
        displacement = int.from_bytes(take(4), "little", signed=True)
        target = pe.validate_rva(rva + cursor + displacement)
        return {"value": target, "valueKind": "module-rva", "method": "relative-branch-target-rva",
                "instructionLength": cursor, "signedDisplacement": displacement, "instructionHex": code[:cursor].hex()}
    if opcode in (0x81, 0x83):
        require(resolve_kind == 0, "Kind 1/3 require non-RIP memory displacement")
        require(0x66 not in prefixes, "16-bit ADD is outside supported subset")
        modrm = take(1)[0]
        require(modrm >> 6 == 3 and (modrm >> 3) & 7 == 0, "Only ADD register,immediate is supported")
        value = int.from_bytes(take(4 if opcode == 0x81 else 1), "little", signed=True)
        require(value >= 0, "Negative immediate offset is refused")
        return {"value": value, "valueKind": "offset", "method": "add-register-immediate",
                "instructionLength": cursor, "instructionHex": code[:cursor].hex()}
    if opcode == 0x0f:
        extension = take(1)[0]
        require(extension in {0x10, 0x5c, 0xb6, 0xb7}, "Unsupported 0F opcode")
    else:
        require(opcode in {0x8d, 0x8b, 0x89}, "Unsupported instruction opcode")
    modrm = take(1)[0]
    mode, rm = modrm >> 6, modrm & 7
    require(mode != 3, "Register-only operand has no memory displacement")
    sib = take(1)[0] if rm == 4 else None
    rip_relative = mode == 0 and rm == 5
    if mode == 1:
        displacement = int.from_bytes(take(1), "little", signed=True)
    elif mode == 2 or rip_relative or (mode == 0 and sib is not None and sib & 7 == 5):
        displacement = int.from_bytes(take(4), "little", signed=True)
    else:
        raise ResolveError("Memory operand has no encoded displacement")
    if rip_relative:
        require(resolve_kind == 0, "Kind 1/3 refuse RIP-relative operands")
        value = pe.validate_rva(rva + cursor + displacement)
        value_kind, method = "module-rva", "rip-relative-target-rva"
    else:
        require(displacement >= 0, "Negative memory displacement is refused")
        value, value_kind, method = displacement, "offset", "non-rip-memory-displacement"
    return {"value": value, "valueKind": value_kind, "method": method,
            "instructionLength": cursor, "signedDisplacement": displacement,
            "indexedAddress": sib is not None, "instructionHex": code[:cursor].hex()}


def validate_identity(identity, game_path, actual_hash):
    require(isinstance(identity, dict), "Identity must be an object")
    require(identity.get("measured") is True and identity.get("synthetic") is False,
            "Identity must declare measured:true and synthetic:false; fixture identity is not a game measurement")
    module = text(identity.get("module"), "identity.module")
    require(ntpath.basename(module) == module and "/" not in module, "identity.module must be a filename")
    require(Path(game_path).name.casefold() == module.casefold(), "Game filename does not match measured identity.module")
    claimed_hash = identity.get("sha256")
    require(isinstance(claimed_hash, str) and re.fullmatch(r"[0-9a-fA-F]{64}", claimed_hash), "Invalid identity SHA-256")
    require(actual_hash == claimed_hash.lower(), "Game file SHA-256 does not match measured identity")
    version = text(identity.get("version"), "identity.version")
    module_base = unsigned(identity.get("moduleBase"), "identity.moduleBase", (1 << 64) - 1, positive=True)
    require(module_base >= 0x10000, "Identity module base below address bound")
    process = unsigned(identity.get("processId"), "identity.processId", 0xffffffff, positive=True)
    return {"module": module, "version": version, "sha256": actual_hash,
            "moduleBase": module_base, "processId": process}


def resolve_descriptor(pe, descriptor):
    require(isinstance(descriptor, dict), "Descriptor must be an object")
    evidence_id = text(descriptor.get("evidenceId"), "descriptor.evidenceId")
    if descriptor.get("kind") == "fixed":
        value = unsigned(descriptor.get("value"), "fixed descriptor value")
        return {"status": "resolved", "value": value, "method": "catalog-fixed-constant",
                "valueKind": "offset", "evidenceId": evidence_id}
    require(descriptor.get("kind") == "signature", "Unsupported descriptor kind")
    variants = descriptor.get("variants")
    require(isinstance(variants, list) and 1 <= len(variants) <= 4, "Descriptor requires 1..4 variants")
    details = []
    resolved = []
    unsafe_failure = False
    for index, variant in enumerate(variants):
        detail = {"index": index}
        details.append(detail)
        try:
            require(isinstance(variant, dict), "Variant must be object")
            require(type(variant.get("knownConstant")) is bool, "knownConstant must be explicit boolean")
            if variant["knownConstant"]:
                value = unsigned(variant.get("value"), "known constant", positive=True)
                decoded = {"value": value, "valueKind": "offset", "method": "known-constant-no-scan"}
            else:
                scan = scan_pattern(pe, variant.get("pattern"))
                detail["scan"] = scan
                if scan["status"] != "unique_match":
                    detail["status"] = "unresolved"
                    detail["reason"] = scan["status"]
                    unsafe_failure |= scan["status"] != "not_found"
                    continue
                decoded = decode_instruction(pe, scan["matches"][0], variant.get("resolveKind"))
                decoded["matchRva"] = scan["matches"][0]
            unsigned(decoded["value"], "resolved offset/RVA")
            detail.update({"status": "resolved", **decoded})
            resolved.append(decoded)
        except ResolveError as exc:
            detail.update({"status": "unresolved", "reason": str(exc)})
            unsafe_failure = True
    values = {item["value"] for item in resolved}
    if unsafe_failure or not resolved or len(values) != 1:
        reason = "unsafe_or_unsupported_variant" if unsafe_failure else ("no_variant_resolved" if not resolved else "conflicting_variant_values")
        return {"status": "unresolved", "reason": reason, "evidenceId": evidence_id, "variants": details}
    result = {"status": "resolved", "value": resolved[0]["value"], "valueKind": resolved[0]["valueKind"],
              "method": "all_matching_variants_agree", "evidenceId": evidence_id, "variants": details}
    if result["valueKind"] == "module-rva":
        section = pe.section_at(result["value"])
        if section is not None and section["executable"]:
            result["executableCodeWindowHex"] = pe.instruction_window(result["value"], 64).hex()
            result["codeWindowMeaning"] = "raw bytes at executable RVA; not proof of function entry"
    return result


def validate_field(field):
    require(isinstance(field, dict), "Field must be an object")
    require(field.get("root") in {"module", "hero"}, "Field root must be module or hero")
    path = text(field.get("path"), "field.path", 128)
    parts = path.split(".")
    require(len(parts) <= 8 and all(re.fullmatch(r"[A-Za-z_][A-Za-z_0-9]{0,47}", x) for x in parts), "Invalid field path")
    require(not (field["root"] == "module" and parts[0] == "heroes"), "Module field cannot overwrite heroes")
    require(field.get("type") in TYPES, "Unsupported field type")
    require(isinstance(field.get("terms"), list) and 1 <= len(field["terms"]) <= 8, "Field requires 1..8 terms")
    text(field.get("evidenceId"), "field.evidenceId")
    if field["type"] == "utf8":
        unsigned(field.get("maxBytes"), "utf8 maxBytes", 1024, positive=True)
    elif "maxBytes" in field:
        raise ResolveError("maxBytes applies only to utf8")
    if "derefOffsets" in field:
        require(isinstance(field["derefOffsets"], list) and len(field["derefOffsets"]) <= 8, "Pointer chain exceeds bound")
        for value in field["derefOffsets"]:
            unsigned(value, "pointer-chain offset")


def resolve_catalog(pe, catalog, catalog_path, catalog_hash, identity, identity_path, identity_hash, game_path):
    require(isinstance(catalog, dict), "Catalog must be an object")
    require(type(catalog.get("schemaVersion")) is int and catalog["schemaVersion"] == 1, "Unsupported catalog schema")
    descriptors = catalog.get("descriptors")
    fields = catalog.get("fields")
    require(isinstance(descriptors, dict) and len(descriptors) <= MAX_SIGNATURES, "Descriptor map exceeds bound")
    require(isinstance(fields, list) and len(fields) <= 128, "Field list exceeds core bound")
    signature_count = 0
    normalized = {}
    for key, descriptor in descriptors.items():
        key = address_key(key)
        require(key not in normalized, "Duplicate normalized descriptor address")
        normalized[key] = descriptor
        if isinstance(descriptor, dict) and descriptor.get("kind") == "signature":
            variants = descriptor.get("variants")
            require(isinstance(variants, list), "Signature variants must be array")
            signature_count += len(variants)
    require(signature_count <= MAX_SIGNATURES, "Signature variant count exceeds bound")
    resolved = {}
    for key, descriptor in normalized.items():
        try:
            resolved[key] = resolve_descriptor(pe, descriptor)
        except ResolveError as exc:
            resolved[key] = {"status": "unresolved", "reason": str(exc)}
    evidence = catalog.get("evidence", [])
    require(isinstance(evidence, list) and len(evidence) <= 128, "Catalog evidence exceeds bound")
    evidence_map = {}
    for item in evidence:
        require(isinstance(item, dict), "Catalog evidence must be object")
        key = text(item.get("id"), "evidence.id")
        require(key not in evidence_map, "Duplicate catalog evidence ID")
        entry = {"id": key, "source": text(item.get("source"), "evidence.source")}
        if "sha256" in item:
            require(isinstance(item["sha256"], str) and re.fullmatch(r"[0-9a-fA-F]{64}", item["sha256"]), "Invalid evidence SHA-256")
            entry["sha256"] = item["sha256"].lower()
        if "note" in item:
            entry["note"] = text(item["note"], "evidence.note")
        evidence_map[key] = entry
    output_fields, field_results, used_evidence = [], [], set()
    for field in fields:
        detail = {key: field.get(key) for key in ("root", "path", "type", "evidenceId")} if isinstance(field, dict) else {}
        field_results.append(detail)
        try:
            validate_field(field)
            keys = [address_key(value) for value in field["terms"]]
            detail["terms"] = keys
            missing = [key for key in keys if key not in resolved or resolved[key]["status"] != "resolved"]
            require(not missing, "Missing/unresolved descriptor terms: " + ", ".join(missing))
            require(field["evidenceId"] in evidence_map, "Field evidence ID missing from catalog")
            offset = sum(resolved[key]["value"] for key in keys)
            unsigned(offset, "summed field offset")
            if field["root"] == "module":
                pe.validate_rva(offset)
            candidate = {key: field[key] for key in ("root", "path", "type", "evidenceId")}
            candidate["offset"] = offset
            for key in ("derefOffsets", "maxBytes"):
                if key in field:
                    candidate[key] = field[key]
            for old in output_fields:
                require(not (old["root"] == candidate["root"] and
                    (old["path"] == candidate["path"] or old["path"].startswith(candidate["path"] + ".") or candidate["path"].startswith(old["path"] + "."))),
                    "Duplicate/overlapping output field path")
            output_fields.append(candidate)
            used_evidence.add(field["evidenceId"])
            detail.update({"status": "resolved", "offset": offset,
                           "termValues": [resolved[key]["value"] for key in keys]})
        except ResolveError as exc:
            detail.update({"status": "unresolved", "reason": str(exc)})
    require(len(used_evidence) + 2 <= 128, "Output evidence exceeds native core bound")
    catalog_id = "offline-catalog-" + catalog_hash[:16]
    image_id = "offline-target-" + identity["sha256"][:16]
    require(catalog_id not in used_evidence and image_id not in used_evidence, "Reserved evidence ID collision")
    profile_evidence = [evidence_map[key] for key in sorted(used_evidence)] + [
        {"id": catalog_id, "source": str(catalog_path), "sha256": catalog_hash,
         "note": "Static descriptor/field source; game SHA-256 " + identity["sha256"] + "; see the companion resolution report for per-descriptor details."},
        {"id": image_id, "source": str(game_path), "sha256": identity["sha256"],
         "note": "Offline AMD64 PE bytes matched independently supplied identity.module and identity.sha256; not a runtime memory capture."}]
    profile = None
    if output_fields:
        profile = {"schemaVersion": 1, "profileId": "lb-independent-static-" + identity["sha256"][:16] + "-" + catalog_hash[:8],
            "target": {key: identity[key] for key in ("module", "version", "sha256")},
            "validation": {"status": "static-derived", "note": "Offline signatures/constants only; not runtime-verified. Hero discovery and full account parity are unproven."},
            "evidence": profile_evidence, "fields": output_fields}
    report = {"reportVersion": 1, "status": "static-derived-partial" if profile else "blocked-no-resolved-fields",
        "profileWritten": False, "runtimeVerified": False, "fullParityEstablished": False,
        "objectDiscoveryAvailable": False, "heroRootsAvailable": False,
        "target": identity, "identityEvidence": {"source": str(identity_path), "sha256": identity_hash,
            "fileSha256Matched": True, "filenameMatched": True,
            "versionSource": "supplied measured identity; PE version resource not independently compared"},
        "catalogEvidence": {"source": str(catalog_path), "sha256": catalog_hash},
        "gameFile": {"source": str(game_path), "sha256": identity["sha256"], "length": len(pe.raw),
                     "preferredImageBase": pe.preferred_base, "sizeOfImage": pe.image_size},
        "limits": {"maxFileBytes": MAX_FILE, "maxSections": MAX_SECTIONS, "maxSignatureVariants": MAX_SIGNATURES,
                   "maxPatternBytes": MAX_PATTERN, "maxAnchorHitsPerPattern": MAX_ANCHOR_HITS,
                   "maxMatchesBeforeAmbiguous": MAX_MATCHES, "maxOffset": MAX_OFFSET,
                   "mappedImageAllocated": False, "gameFileModified": False, "operatingSystemCodeExecution": False},
        "summary": {"descriptors": len(resolved), "resolvedDescriptors": sum(x["status"] == "resolved" for x in resolved.values()),
                    "fields": len(fields), "resolvedFields": len(output_fields), "unresolvedFields": len(fields) - len(output_fields)},
        "descriptorResolutions": resolved, "fieldResolutions": field_results,
        "unknowns": ["Static-derived offsets have not been validated in a running game.",
                     "Hero object discovery/list layout and root addresses are unavailable.",
                     "Full native fields, event delivery, objective state, LCU and current-account parity remain unverified.",
                     "Catalog evidence hashes bind supplied claims; this resolver does not independently authenticate those sources.",
                     "SIB-based displacement extraction does not reconstruct index calculations or getter semantics."]}
    return profile, report


def resolve_files(game_path, identity_path, catalog_path):
    identity_input, identity_hash = strict_json(identity_path)
    catalog, catalog_hash = strict_json(catalog_path)
    game_path = Path(game_path)
    with game_path.open("rb") as stream:
        initial = game_path.stat()
        require(0 < initial.st_size <= MAX_FILE, "Game file exceeds 512 MiB bound or is empty")
        with mmap.mmap(stream.fileno(), 0, access=mmap.ACCESS_READ) as raw:
            actual_hash = hashlib.sha256(raw).hexdigest()
            identity = validate_identity(identity_input, game_path, actual_hash)
            profile, report = resolve_catalog(PEImage(raw), catalog, catalog_path, catalog_hash, identity,
                                               identity_path, identity_hash, game_path)
            final = game_path.stat()
            require(initial.st_size == final.st_size and initial.st_mtime_ns == final.st_mtime_ns,
                    "Game file changed during offline resolution")
    return profile, report


def main(argv=None):
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("--game-exe", required=True)
    parser.add_argument("--identity-json", required=True)
    parser.add_argument("--catalog", required=True)
    parser.add_argument("--profile-out", required=True)
    parser.add_argument("--report-out", required=True)
    args = parser.parse_args(argv)
    profile = None
    try:
        # Never allow output paths to overwrite the game or input evidence.
        inputs = {Path(x).resolve() for x in (args.game_exe, args.identity_json, args.catalog)}
        outputs = [Path(args.profile_out).resolve(), Path(args.report_out).resolve()]
        require(outputs[0] != outputs[1] and not any(x in inputs for x in outputs), "Output paths must differ from all inputs and each other")
        profile, report = resolve_files(args.game_exe, args.identity_json, args.catalog)
        if profile:
            Path(args.profile_out).write_text(json.dumps(profile, ensure_ascii=False, indent=2, allow_nan=False) + "\n", encoding="utf-8")
            report["profileWritten"] = True
            report["profileOutput"] = str(args.profile_out)
        else:
            report["profileOutputRetainedIfExisting"] = Path(args.profile_out).exists()
        code = 0 if profile else 1
    except (OSError, UnicodeError, ValueError, struct.error) as exc:
        report = {"reportVersion": 1, "status": "blocked-input-error", "profileWritten": False,
                  "runtimeVerified": False, "fullParityEstablished": False,
                  "errors": [str(exc)]}
        code = 2
    try:
        # Check again: reporting an invalid-path error must not overwrite an input.
        require(Path(args.report_out).resolve() not in {Path(x).resolve() for x in (args.game_exe, args.identity_json, args.catalog)},
                "Report output overlaps input")
        Path(args.report_out).write_text(json.dumps(report, ensure_ascii=False, indent=2, allow_nan=False) + "\n", encoding="utf-8")
    except (OSError, ValueError) as exc:
        print("Report write failed: " + str(exc), file=sys.stderr)
        return 2
    print(json.dumps({"status": report["status"], "profileWritten": report["profileWritten"],
                      "report": str(args.report_out)}, ensure_ascii=False))
    return code


if __name__ == "__main__":
    raise SystemExit(main())
