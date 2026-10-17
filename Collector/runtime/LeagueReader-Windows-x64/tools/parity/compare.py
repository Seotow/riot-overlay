#!/usr/bin/env python3
"""Compare observed native snapshot recordings. No external dependencies or credentials.

An equality result concerns these samples only; it is never proof of complete
account-tier coverage, runtime independence, event semantics or all future games.
"""
from __future__ import annotations

import argparse
from bisect import bisect_left
from collections import Counter, defaultdict
import hashlib
import json
import math
from pathlib import Path
import sys


class InputError(ValueError):
    pass


def strict_json(text):
    def reject(value):
        raise InputError("Non-finite JSON literal: " + value)
    def unique_keys(pairs):
        result = {}
        for key, value in pairs:
            if key in result:
                raise InputError("Duplicate JSON property: " + key)
            result[key] = value
        return result
    def finite_float(text):
        value = float(text)
        if not math.isfinite(value):
            raise InputError("JSON number exceeds finite floating-point range")
        return value
    return json.loads(text, parse_constant=reject, object_pairs_hook=unique_keys,
                      parse_float=finite_float)


def read_recording(path):
    raw = Path(path).read_bytes()
    text = raw.decode("utf-8-sig")
    if not text.strip():
        raise InputError("Empty recording: " + str(path))
    try:
        root = strict_json(text)
        frames = root if isinstance(root, list) else [root]
    except json.JSONDecodeError:
        frames = []
        for line, value in enumerate(text.splitlines(), 1):
            if value.strip():
                try:
                    frames.append(strict_json(value))
                except (ValueError, InputError) as exc:
                    raise InputError(f"Invalid JSON at line {line}: {exc}") from exc
    if not all(isinstance(frame, dict) for frame in frames):
        raise InputError("Every frame must be a JSON envelope object")
    snapshots = [frame for frame in frames if frame.get("type") == "snapshot"]
    return snapshots, {"path": str(path), "sha256": hashlib.sha256(raw).hexdigest(),
                       "bytes": len(raw), "envelopes": len(frames), "snapshots": len(snapshots)}


def number(value):
    return isinstance(value, (int, float)) and not isinstance(value, bool) and math.isfinite(value)


def identity(value):
    # Include JSON type: gameId 123 is not automatically the same as "123".
    if value is None or value == "" or value == 0 or value is False:
        return None
    return json.dumps(value, sort_keys=True, separators=(",", ":"), ensure_ascii=False)


def validate(frames, role):
    reasons = set()
    games = set()
    valid = []
    previous_time = None
    if not frames:
        reasons.add(role + ":no_snapshots")
    for frame in frames:
        if type(frame.get("schemaVersion")) is not int or frame.get("schemaVersion") != 1:
            reasons.add(role + ":unsupported_or_missing_schema_version")
        source = frame.get("source")
        if role == "baseline" and source != "lblib":
            reasons.add(role + ":source_must_be_lblib")
        if not isinstance(source, str) or not source or source in {"demo", "replay"}:
            reasons.add(role + ":source_is_missing_synthetic_or_replay")
        if role == "candidate" and source == "lblib":
            reasons.add(role + ":original_lblib_is_not_independent_candidate")
        if frame.get("synthetic") is not False:
            reasons.add(role + ":synthetic_must_be_explicit_false")
        if frame.get("recordedAt") is not None:
            reasons.add(role + ":replay_provenance_present")
        data = frame.get("data")
        if not isinstance(data, dict):
            reasons.add(role + ":data_must_be_object")
            continue
        game = identity(data.get("gameId"))
        if game is None:
            reasons.add(role + ":game_id_missing_or_empty")
        else:
            games.add(game)
        time = data.get("gameTime")
        if not number(time):
            reasons.add(role + ":finite_game_time_required")
            continue
        if previous_time is not None and time < previous_time:
            reasons.add(role + ":non_monotonic_game_time_capture")
        previous_time = time
        valid.append((float(time), frame))
    return sorted(valid, key=lambda item: item[0]), games, reasons


def state(value):
    if value is MISSING:
        return "missing"
    if value is None:
        return "null"
    if value is False:
        return "default_false"
    if isinstance(value, str) and value == "":
        return "default_empty_string"
    if number(value) and value == 0:
        return "default_zero"
    if isinstance(value, list):
        return "default_empty_array" if not value else "array"
    if isinstance(value, dict):
        return "default_empty_object" if not value else "object"
    return "value"


MISSING = object()


def escaped(value):
    return str(value).replace("~", "~0").replace("/", "~1")


def flatten(value, path="", result=None):
    """Retain containers, nulls and defaults; identity-align game objects only.

    These are report paths, not RFC6901 pointers: @networkId selects an object.
    Events deliberately have no invented IDs and remain order-sensitive.
    """
    if result is None:
        result = {}
    result[path or "/"] = value
    if isinstance(value, dict):
        for key, child in value.items():
            flatten(child, path + "/" + escaped(key), result)
    elif isinstance(value, list):
        ids = []
        for item in value:
            obj = item.get("info") if isinstance(item, dict) else None
            obj_id = obj.get("networkId") if isinstance(obj, dict) else None
            ids.append(obj_id if number(obj_id) and obj_id != 0 else None)
        use_ids = bool(ids) and all(x is not None for x in ids) and len(set(ids)) == len(ids)
        for index, child in enumerate(value):
            token = "@networkId=" + str(ids[index]) if use_ids else str(index)
            flatten(child, path + "/" + token, result)
    return result


def path_value(flat, path):
    value = flat.get(path, MISSING)
    if value is not MISSING:
        return value, None
    parent = path
    while "/" in parent:
        parent = parent.rsplit("/", 1)[0]
        ancestor = flat.get(parent or "/", MISSING)
        if ancestor is not MISSING and not isinstance(ancestor, (dict, list)):
            return MISSING, state(ancestor)
        if ancestor == [] or ancestor == {}:
            return MISSING, state(ancestor)
    return MISSING, None


def equal(a, b, path, time_tolerance, abs_tolerance, rel_tolerance):
    if a is MISSING or b is MISSING:
        return False
    if isinstance(a, dict) or isinstance(b, dict):
        return isinstance(a, dict) and isinstance(b, dict)
    if isinstance(a, list) or isinstance(b, list):
        return isinstance(a, list) and isinstance(b, list) and len(a) == len(b)
    if isinstance(a, bool) or isinstance(b, bool):
        return type(a) is type(b) and a == b
    if number(a) and number(b):
        if path == "/gameTime":
            return abs(a - b) <= time_tolerance
        # Never use relative tolerance to turn distinct integer IDs/counters equal.
        if isinstance(a, int) and isinstance(b, int):
            return a == b
        if path.rsplit("/", 1)[-1].lower().endswith(("id", "ids", "index")):
            return a == b
        return math.isclose(a, b, abs_tol=abs_tolerance, rel_tol=rel_tolerance)
    return type(a) is type(b) and a == b


def align(baseline, candidate, tolerance):
    """Greedy ordered one-to-one alignment, nearest available candidate time.

    No frame is reused. Unpaired samples block a complete observed-sample match.
    This is a sample comparison, not interpolation or an event-stream matcher.
    """
    times = [item[0] for item in candidate]
    last = -1
    pairs = []
    missing = []
    used = set()
    for index, (time, frame) in enumerate(baseline):
        insertion = bisect_left(times, time, lo=last + 1)
        choices = [i for i in (insertion - 1, insertion) if last < i < len(candidate)]
        if not choices:
            missing.append(index)
            continue
        chosen = min(choices, key=lambda i: (abs(times[i] - time), i))
        if abs(times[chosen] - time) > tolerance:
            missing.append(index)
            continue
        pairs.append((frame, candidate[chosen][1], times[chosen] - time))
        last = chosen
        used.add(chosen)
    return pairs, missing, [i for i in range(len(candidate)) if i not in used]


def compare(baseline_path=None, candidate_path=None, evidence_path=None,
            time_tolerance=0.15, abs_tolerance=0.001, rel_tolerance=0.00001):
    if any(not number(x) or x < 0 for x in (time_tolerance, abs_tolerance, rel_tolerance)):
        raise InputError("Tolerances must be finite and nonnegative")
    report = {
        "reportVersion": 1, "verdict": "blocked", "fullParityEstablished": False,
        "scope": "observed snapshot fields only; no claim of complete Free-tier parity",
        "blockingReasons": [], "unknowns": [
            "No authenticated recording proves every possible account-authorized field or event.",
            "Default/null values do not identify whether a field is gated, absent in game, or unsupported.",
            "Event stable IDs, delivery/exactly-once semantics and event retention are unverified.",
            "A candidate source label does not prove it was built or run independently of lblib.",
            "Overlay state, asset/config metadata and LCU are outside this snapshot-only comparison."
        ],
        "tolerances": {"gameTimeSeconds": time_tolerance,
                       "numericAbsolute": abs_tolerance, "numericRelative": rel_tolerance},
        "authenticationEvidence": {"state": "unknown", "entitlementTier": "unknown"},
        "alignment": {"method": "ordered one-to-one nearest gameTime; no interpolation"},
        "coverage": {}, "fields": [], "events": {"idSemantics": "unknown",
            "comparison": "raw arrays in snapshot order only; not event delivery parity"}
    }
    if not baseline_path or not candidate_path:
        report["blockingReasons"] = [name + ":recording_not_supplied"
                                     for name, path in (("baseline", baseline_path), ("candidate", candidate_path)) if not path]
        return report
    bf, bmeta = read_recording(baseline_path)
    cf, cmeta = read_recording(candidate_path)
    report["inputs"] = {"baseline": bmeta, "candidate": cmeta}
    for role, frames in (("baseline", bf), ("candidate", cf)):
        event_stats = defaultdict(lambda: {"snapshotsPresent": 0, "nonEmptySnapshots": 0, "entriesAcrossSnapshots": 0})
        for frame in frames:
            data = frame.get("data")
            events = data.get("gameEvents") if isinstance(data, dict) else None
            if not isinstance(events, dict):
                continue
            for name, values in events.items():
                if isinstance(values, list):
                    stat = event_stats[name]
                    stat["snapshotsPresent"] += 1
                    stat["nonEmptySnapshots"] += bool(values)
                    stat["entriesAcrossSnapshots"] += len(values)
        report["events"][role] = dict(sorted(event_stats.items()))
    baseline, bgames, breasons = validate(bf, "baseline")
    candidate, cgames, creasons = validate(cf, "candidate")
    reasons = breasons | creasons
    if len(bgames) != 1 or len(cgames) != 1:
        reasons.add("exactly_one_known_game_id_per_recording_required")
    if bgames != cgames:
        reasons.add("game_id_mismatch")
    if evidence_path:
        evidence = strict_json(Path(evidence_path).read_text(encoding="utf-8"))
        if not isinstance(evidence, dict):
            raise InputError("Baseline evidence must be a JSON object")
        auth = evidence.get("authentication", {})
        accepted = (evidence.get("baselineSha256") == bmeta["sha256"] and
                    evidence.get("currentAccountConfirmed") is True and
                    isinstance(auth, dict) and auth.get("serverLoginConfirmed") is True and
                    auth.get("nativeSessionAccepted") is True)
        report["authenticationEvidence"] = {
            "state": "capture_operator_asserted" if accepted else "incomplete_or_hash_mismatch",
            "entitlementTier": "unknown",
            "note": "Operator assertions are not independently verified server signatures; subscription404/features=[] never establish Free."
        }
        if not accepted:
            reasons.add("baseline_authenticated_current_account_evidence_incomplete")
    else:
        reasons.add("baseline_authenticated_current_account_evidence_missing")
    # Never align distinct or unknown games, even for an informational value report.
    if len(bgames) != 1 or len(cgames) != 1 or bgames != cgames:
        report["blockingReasons"] = sorted(reasons)
        return report
    pairs, missing, extra = align(baseline, candidate, time_tolerance)
    report["alignment"].update({"pairs": len(pairs), "unmatchedBaseline": len(missing),
        "unmatchedCandidate": len(extra), "maxAbsoluteTimeDelta": max((abs(p[2]) for p in pairs), default=None)})
    if missing:
        reasons.add("unmatched_baseline_samples")
    if extra:
        reasons.add("unmatched_candidate_samples")
    if not pairs:
        reasons.add("no_aligned_samples")
    field_stats = defaultdict(lambda: {"observations": 0, "equal": 0, "different": 0,
                                      "baselineStates": Counter(), "candidateStates": Counter(),
                                      "candidateParentStates": Counter()})
    for base, cand, _ in pairs:
        a, b = flatten(base["data"]), flatten(cand["data"])
        for path in sorted(a.keys() | b.keys()):
            av, _ = path_value(a, path)
            bv, parent_state = path_value(b, path)
            stat = field_stats[path]
            stat["observations"] += 1
            stat["baselineStates"][state(av)] += 1
            stat["candidateStates"][state(bv)] += 1
            if parent_state:
                stat["candidateParentStates"][parent_state] += 1
            match = equal(av, bv, path, time_tolerance, abs_tolerance, rel_tolerance)
            stat["equal" if match else "different"] += 1
    for path, stat in sorted(field_stats.items()):
        report["fields"].append({"path": path, **stat})
    counts = Counter()
    for stat in field_stats.values():
        for label in ("observations", "equal", "different"):
            counts[label] += stat[label]
        counts["baselinePresent"] += stat["observations"] - stat["baselineStates"]["missing"]
        counts["baselinePresentCandidateMissing"] += max(0, stat["candidateStates"]["missing"])
        counts["candidateExtra"] += stat["baselineStates"]["missing"]
    report["coverage"] = dict(counts)
    report["coverage"]["fieldPathsObserved"] = len(field_stats)
    report["coverage"]["note"] = "Containers and defaults count as observations; coverage of unknown/unobserved schema fields is unknown."
    report["blockingReasons"] = sorted(reasons)
    report["verdict"] = "blocked" if reasons else ("different_observed_samples" if counts["different"] else "matched_observed_samples")
    return report


def main(argv=None):
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("--baseline", help="Authenticated current-account native recording")
    parser.add_argument("--candidate", help="Independent recording from the same game")
    parser.add_argument("--baseline-evidence", help="Sidecar operator assertions bound to baseline SHA-256")
    parser.add_argument("--time-tolerance", type=float, default=0.15, help="Maximum gameTime delta in seconds")
    parser.add_argument("--abs-tolerance", type=float, default=0.001)
    parser.add_argument("--rel-tolerance", type=float, default=0.00001)
    parser.add_argument("--output", help="Write report here (otherwise stdout)")
    args = parser.parse_args(argv)
    try:
        report = compare(args.baseline, args.candidate, args.baseline_evidence,
                         args.time_tolerance, args.abs_tolerance, args.rel_tolerance)
        result = json.dumps(report, ensure_ascii=False, indent=2, allow_nan=False) + "\n"
        if args.output:
            Path(args.output).write_text(result, encoding="utf-8")
        else:
            print(result, end="")
        return 0 if report["verdict"] == "matched_observed_samples" else 1
    except (OSError, UnicodeError, ValueError) as exc:
        print("Comparison input error: " + str(exc), file=sys.stderr)
        return 2


if __name__ == "__main__":
    raise SystemExit(main())
