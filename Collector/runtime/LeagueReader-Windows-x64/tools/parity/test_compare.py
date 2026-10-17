import copy
import hashlib
import json
from pathlib import Path
import tempfile
import unittest

from compare import compare, read_recording, InputError


def frame(time=10.0, source="lblib", game="game-A", **data):
    return {"schemaVersion": 1, "sequence": 1, "type": "snapshot", "source": source,
            "synthetic": False, "recordedAt": None,
            "data": {"gameTime": time, "gameId": game, **data}}


class ComparisonTests(unittest.TestCase):
    def setUp(self):
        self.temp = tempfile.TemporaryDirectory()
        self.addCleanup(self.temp.cleanup)
        self.root = Path(self.temp.name)

    def files(self, baseline, candidate, evidence=True):
        paths = []
        for name, frames in (("baseline", baseline), ("candidate", candidate)):
            path = self.root / (name + ".ndjson")
            path.write_text("".join(json.dumps(x) + "\n" for x in frames), encoding="utf-8")
            paths.append(path)
        sidecar = self.root / "baseline.evidence.json"
        sidecar.write_text(json.dumps({
            "baselineSha256": hashlib.sha256(paths[0].read_bytes()).hexdigest(),
            "currentAccountConfirmed": True,
            "authentication": {"serverLoginConfirmed": True, "nativeSessionAccepted": True},
            "accountTier": "Free"
        }), encoding="utf-8")
        return (*paths, sidecar if evidence else None)

    def run_comparison(self, baseline, candidate, evidence=True, **kwargs):
        return compare(*self.files(baseline, candidate, evidence), **kwargs)

    def test_no_reference_is_blocked(self):
        result = compare()
        self.assertEqual(result["verdict"], "blocked")
        self.assertIn("baseline:recording_not_supplied", result["blockingReasons"])

    def test_alignment_and_float_tolerance(self):
        result = self.run_comparison(
            [frame(10.0, health=100.0), frame(11.0, health=99.5)],
            [frame(10.05, "independent", health=100.0001), frame(11.04, "independent", health=99.5)])
        self.assertEqual(result["verdict"], "matched_observed_samples")
        self.assertEqual(result["alignment"]["pairs"], 2)
        self.assertFalse(result["fullParityEstablished"])
        self.assertEqual(result["authenticationEvidence"]["entitlementTier"], "unknown")

    def test_other_game_is_never_aligned(self):
        result = self.run_comparison([frame()], [frame(source="independent", game="game-B")])
        self.assertIn("game_id_mismatch", result["blockingReasons"])
        self.assertNotIn("pairs", result["alignment"])
        self.assertEqual(result["fields"], [])

    def test_missing_game_id_is_blocked(self):
        result = self.run_comparison([frame(game=None)], [frame(source="independent", game=None)])
        self.assertIn("baseline:game_id_missing_or_empty", result["blockingReasons"])

    def test_synthetic_never_confirms(self):
        candidate = frame(source="independent")
        candidate["synthetic"] = True
        result = self.run_comparison([frame()], [candidate])
        self.assertEqual(result["verdict"], "blocked")
        self.assertIn("candidate:synthetic_must_be_explicit_false", result["blockingReasons"])

    def test_replay_never_confirms_even_if_synthetic_false(self):
        for source, recorded_at in (("replay", None), ("independent", "2026-01-01T00:00:00Z")):
            candidate = frame(source=source)
            candidate["recordedAt"] = recorded_at
            with self.subTest(source=source):
                result = self.run_comparison([frame()], [candidate])
                self.assertEqual(result["verdict"], "blocked")

    def test_lblib_candidate_is_not_independent(self):
        result = self.run_comparison([frame()], [frame()])
        self.assertIn("candidate:original_lblib_is_not_independent_candidate", result["blockingReasons"])

    def test_missing_null_and_zero_are_distinct(self):
        result = self.run_comparison([frame(gold=0, camera=None, health=100.0)],
                                     [frame(source="independent", gold=None, health=0)])
        fields = {x["path"]: x for x in result["fields"]}
        self.assertEqual(fields["/gold"]["baselineStates"], {"default_zero": 1})
        self.assertEqual(fields["/gold"]["candidateStates"], {"null": 1})
        self.assertEqual(fields["/camera"]["baselineStates"], {"null": 1})
        self.assertEqual(fields["/camera"]["candidateStates"], {"missing": 1})
        self.assertEqual(fields["/health"]["candidateStates"], {"default_zero": 1})
        self.assertEqual(result["verdict"], "different_observed_samples")

    def test_null_parent_does_not_hide_missing_child(self):
        result = self.run_comparison([frame(hero={"health": 100})],
                                     [frame(source="independent", hero=None)])
        field = next(x for x in result["fields"] if x["path"] == "/hero/health")
        self.assertEqual(field["candidateStates"], {"missing": 1})
        self.assertEqual(field["candidateParentStates"], {"null": 1})

    def test_false_does_not_match_zero(self):
        result = self.run_comparison([frame(flag=False)], [frame(source="independent", flag=0)])
        self.assertEqual(result["verdict"], "different_observed_samples")

    def test_objects_are_aligned_by_network_id(self):
        heroes = [{"info": {"networkId": 12}, "gold": 100},
                  {"info": {"networkId": 13}, "gold": 200}]
        result = self.run_comparison([frame(heroes=heroes)],
                                     [frame(source="independent", heroes=list(reversed(heroes)))])
        self.assertEqual(result["verdict"], "matched_observed_samples")

    def test_integer_ids_do_not_use_relative_tolerance(self):
        result = self.run_comparison([frame(networkId=10000000)],
                                     [frame(source="independent", networkId=10000001)])
        self.assertEqual(result["verdict"], "different_observed_samples")

    def test_auth_missing_is_not_equivalent_to_free(self):
        result = self.run_comparison([frame()], [frame(source="independent")], evidence=False)
        self.assertIn("baseline_authenticated_current_account_evidence_missing", result["blockingReasons"])
        self.assertEqual(result["authenticationEvidence"]["entitlementTier"], "unknown")

    def test_evidence_bound_to_hash(self):
        args = self.files([frame()], [frame(source="independent")])
        Path(args[0]).write_text(json.dumps(frame(gold=0)), encoding="utf-8")
        result = compare(*args)
        self.assertIn("baseline_authenticated_current_account_evidence_incomplete", result["blockingReasons"])

    def test_frame_not_reused_and_unmatched_samples_reported(self):
        result = self.run_comparison([frame(10.0), frame(10.1)], [frame(10.05, "independent")])
        self.assertEqual(result["alignment"]["pairs"], 1)
        self.assertEqual(result["alignment"]["unmatchedBaseline"], 1)
        self.assertEqual(result["verdict"], "blocked")

    def test_unknown_event_semantics_remain_unknown(self):
        events = {"deathEvents": [{"gameTime": 9.0, "victimNetworkId": 20}]}
        result = self.run_comparison([frame(gameEvents=events)],
                                     [frame(source="independent", gameEvents=copy.deepcopy(events))])
        self.assertEqual(result["events"]["idSemantics"], "unknown")
        self.assertFalse(result["fullParityEstablished"])

    def test_json_array_and_status_frames(self):
        path = self.root / "record.json"
        path.write_text(json.dumps([{"type": "status"}, frame()]), encoding="utf-8")
        snapshots, meta = read_recording(path)
        self.assertEqual(len(snapshots), 1)
        self.assertEqual(meta["envelopes"], 2)

    def test_non_finite_values_rejected(self):
        path = self.root / "invalid.json"
        for value in ("NaN", "1e999"):
            path.write_text('{"type":"snapshot","data":{"gameTime":' + value + '}}', encoding="utf-8")
            with self.subTest(value=value), self.assertRaises(InputError):
                read_recording(path)

    def test_duplicate_json_properties_rejected(self):
        path = self.root / "invalid.json"
        path.write_text('{"type":"snapshot","synthetic":true,"synthetic":false}', encoding="utf-8")
        with self.assertRaises(InputError):
            read_recording(path)

    def test_boolean_schema_version_rejected(self):
        candidate = frame(source="independent")
        candidate["schemaVersion"] = True
        result = self.run_comparison([frame()], [candidate])
        self.assertIn("candidate:unsupported_or_missing_schema_version", result["blockingReasons"])

    def test_replay_seek_not_silently_sorted_into_parity(self):
        result = self.run_comparison([frame(10.0), frame(9.0)],
                                     [frame(10.0, "independent"), frame(9.0, "independent")])
        self.assertIn("baseline:non_monotonic_game_time_capture", result["blockingReasons"])
        self.assertEqual(result["verdict"], "blocked")


if __name__ == "__main__":
    unittest.main()
