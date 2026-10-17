#!/usr/bin/env python3
"""Real .NET host/native ABI integration with localhost HTTP/WebSocket fixtures."""
import asyncio
import copy
from contextlib import contextmanager
import hashlib
import json
import os
from pathlib import Path
import socket
import signal
import subprocess
import tempfile
import time
import urllib.error
import urllib.request

from websockets.asyncio.client import connect
from websockets.exceptions import ConnectionClosed

ROOT = Path(__file__).resolve().parent.parent
NATIVE = ROOT.parent / "native"
DOTNET = Path(os.environ.get("DOTNET_ROOT", "/workspace/.tools/dotnet")) / "dotnet"
APP = ROOT / "dist/IndependentCollector.dll"
PROFILE = NATIVE / "profiles/sparse-fixture-v1.json"
FIXTURE = NATIVE / "tests/fixtures/memory.json"

def free_port():
    with socket.socket() as s:
        s.bind(("127.0.0.1", 0))
        return s.getsockname()[1]

def http(port, path, headers=None):
    req = urllib.request.Request(f"http://127.0.0.1:{port}{path}", headers=headers or {})
    try:
        with urllib.request.urlopen(req, timeout=3) as r:
            raw = r.read()
            return r.status, json.loads(raw) if raw else None
    except urllib.error.HTTPError as e:
        return e.code, None

@contextmanager
def launch(args, file_limit=None):
    port = free_port()
    def limit_file_size():
        signal.signal(signal.SIGXFSZ, signal.SIG_IGN)
    process = subprocess.Popen([str(DOTNET), str(APP), *map(str, args), "--port", str(port)],
        stdout=subprocess.PIPE, stderr=subprocess.PIPE, text=True,
        preexec_fn=limit_file_size if file_limit is not None else None)
    try:
        deadline = time.monotonic() + 15
        ready = None
        while time.monotonic() < deadline:
            if process.poll() is not None:
                stdout, stderr = process.communicate()
                raise AssertionError(("host terminated", process.returncode, stdout, stderr))
            try:
                code, status = http(port, "/api/status")
                if code == 200 and status["state"] != "starting":
                    ready = status
                    break
            except (OSError, urllib.error.URLError):
                pass
            time.sleep(.05)
        if ready is None:
            raise AssertionError("Host readiness timeout")
        if file_limit is not None:
            import resource
            # Apply after CoreCLR has initialized its shared-memory files.
            resource.prlimit(process.pid, resource.RLIMIT_FSIZE, (file_limit, file_limit))
        yield port, process, ready
    finally:
        process.terminate()
        try:
            process.wait(timeout=8)
        except subprocess.TimeoutExpired:
            process.kill(); process.wait(timeout=5)
        process.stdout.close(); process.stderr.close()

def fixture_args(profile=PROFILE, fixture=FIXTURE):
    return ["--profile", profile, "--fixture", fixture]

async def websocket_test(port):
    async with connect(f"ws://127.0.0.1:{port}/ws", origin=f"http://127.0.0.1:{port}") as ws:
        frames = [json.loads(await asyncio.wait_for(ws.recv(), 3)) for _ in range(3)]
        sequence = [x["sequence"] for x in frames]
        assert sequence == sorted(sequence) and len(set(sequence)) == 3
        snapshots = [x for x in frames if x["type"] == "snapshot"]
        assert snapshots and snapshots[0]["synthetic"] is True
        assert snapshots[0]["data"]["heroes"][0]["gold"] == 1350
        await ws.send("collector stream is read only")
        try:
            while True:
                await asyncio.wait_for(ws.recv(), 3)
        except ConnectionClosed as error:
            assert error.rcvd.code == 1008

def main():
    checks = []
    with launch(fixture_args()) as (port, process, status):
        deadline = time.monotonic() + 3
        while status["snapshots"] == 0 and time.monotonic() < deadline:
            time.sleep(.02); _, status = http(port, "/api/status")
        assert status["state"] == "streaming", status
        assert status["synthetic"] is True and status["rootsKnown"] is True
        assert status["authenticationRequired"] is False and status["originalLibraryLoaded"] is False
        assert status["lbParityVerified"] is False and status["runtimeVerified"] is False
        code, snapshot = http(port, "/api/snapshot")
        assert code == 200 and snapshot["source"] == "independent-memory-reader"
        assert snapshot["synthetic"] is True and snapshot["data"]["gameTime"] == 900.5
        hero = snapshot["data"]["heroes"][0]
        assert hero["common"]["health"] == 1250 and hero["gold"] == 1350 and hero["kills"] == 3
        assert hero["info"]["position"] == {"x": 5400, "y": 52, "z": 6800}
        assert snapshot["metadata"]["issueCount"] == 0
        checks.append("HTTP snapshot preserves native values, null semantics and synthetic/evidence provenance")
        assert http(port, "/api/status", {"Origin": "https://remote.invalid"})[0] == 403
        assert http(port, "/api/status", {"Host": "remote.invalid"})[0] == 403
        checks.append("loopback origin/Host enforcement")
        asyncio.run(websocket_test(port))
        checks.append("WebSocket native snapshot, ordered sequence and read-only close1008")
        (ROOT / "tests/fixture-envelope.json").write_text(json.dumps(snapshot, indent=2) + "\n")

    with tempfile.TemporaryDirectory(prefix="independent-host-test-") as temporary:
        temp = Path(temporary)
        capture = temp / "capture.ndjson"
        with launch([*fixture_args(), "--record", capture]) as (port, _, status):
            deadline = time.monotonic() + 3
            while status["recording"]["written"] < 3 and time.monotonic() < deadline:
                time.sleep(.05); _, status = http(port, "/api/status")
            assert status["recording"]["state"] == "recording"
            assert status["recording"]["written"] >= 3 and status["recording"]["dropped"] == 0
        recorded = [json.loads(line) for line in capture.read_text().splitlines()]
        assert recorded and recorded[-1]["type"] == "status" and recorded[-1]["data"]["state"] == "stopped"
        snapshots = [frame for frame in recorded if frame["type"] == "snapshot"]
        assert snapshots and all(frame["synthetic"] is True for frame in snapshots)
        assert snapshots[0]["data"]["heroes"][0]["gold"] == 1350
        assert all(a["sequence"] < b["sequence"] for a, b in zip(recorded, recorded[1:]))
        original = capture.read_bytes()
        refused = subprocess.run([str(DOTNET), str(APP), *map(str, fixture_args()), "--record", str(capture)], capture_output=True, text=True)
        assert refused.returncode == 2 and json.loads(refused.stderr)["error"] == "recording_open_failed"
        assert capture.read_bytes() == original
        checks.append("NDJSON captures native snapshot/status with counters and shutdown flush; existing file never overwritten")

        if os.name != "nt":
            limited = temp / "limited.ndjson"
            with launch([*fixture_args(), "--record", limited], file_limit=16384) as (port, process, status):
                deadline = time.monotonic() + 5
                while status["recording"]["state"] != "error" and time.monotonic() < deadline:
                    time.sleep(.1); _, status = http(port, "/api/status")
                assert process.poll() is None and status["recording"]["state"] == "error", status
                assert status["recording"]["dropped"] > 0 and status["recording"]["error"]
                assert http(port, "/api/snapshot")[0] == 200
            checks.append("real recording I/O failure updates error/dropped without stopping collection or server")

        profile = json.loads(PROFILE.read_text())
        profile["fields"][2]["offset"] = 4096
        partial = temp / "partial-profile.json"; partial.write_text(json.dumps(profile))
        with launch(fixture_args(partial)) as (port, _, status):
            _, snapshot = http(port, "/api/snapshot")
            assert snapshot["data"]["heroes"][0]["common"]["health"] is None
            assert snapshot["data"]["heroes"][0]["gold"] == 1350
            assert snapshot["metadata"]["issueCount"] == 2
            assert status["state"] == "partial"
        checks.append("unreadable fields remain null through native ABI and HTTP; other values retained")

        fixture = json.loads(FIXTURE.read_text())
        fixture["heroesKnown"] = False; fixture["heroAddresses"] = []
        unknown = temp / "unknown-fixture.json"; unknown.write_text(json.dumps(fixture))
        profile = json.loads(PROFILE.read_text())
        profile["target"]["sha256"] = hashlib.sha256(unknown.read_bytes()).hexdigest()
        unknown_profile = temp / "unknown-profile.json"; unknown_profile.write_text(json.dumps(profile))
        with launch(fixture_args(unknown_profile, unknown)) as (port, _, status):
            _, snapshot = http(port, "/api/snapshot")
            assert snapshot["data"]["heroes"] is None
            assert status["rootsKnown"] is False and status["state"] == "waiting-for-roots"
        checks.append("unknown hero discovery yields null and waiting-for-roots instead of empty or invented players")

        with launch(fixture_args(PROFILE, unknown)) as (port, _, status):
            assert status["state"] == "error" and status["error"]["code"] == "profile_target_mismatch"
            assert http(port, "/api/snapshot")[0] == 204
        checks.append("actual fixture SHA mismatch rejected with no snapshot or fallback")

        oversized_profile = temp / "oversized-profile.json"
        with oversized_profile.open("wb") as stream:
            stream.truncate(128 * 1024 + 1)
        with launch(fixture_args(oversized_profile)) as (port, _, status):
            assert status["error"]["code"] == "profile_too_large" and http(port, "/api/snapshot")[0] == 204
        oversized_fixture = temp / "oversized-fixture.json"
        with oversized_fixture.open("wb") as stream:
            stream.truncate(8 * 1024 * 1024 + 1)
        with launch(fixture_args(PROFILE, oversized_fixture)) as (port, _, status):
            assert status["error"]["code"] == "fixture_too_large" and http(port, "/api/snapshot")[0] == 204
        checks.append("profile and fixture file-size bounds rejected before allocation/parsing")

    if os.name != "nt":
        with launch(["--pid", "123", "--profile", PROFILE]) as (port, _, status):
            assert status["state"] == "error" and status["error"]["code"] == "windows_x64_required"
            assert status["synthetic"] is None and http(port, "/api/snapshot")[0] == 204
        identity = subprocess.run([str(DOTNET), str(APP), "--identity", "--pid", "123"], capture_output=True, text=True)
        assert identity.returncode == 3 and json.loads(identity.stderr)["error"] == "windows_x64_required"
        checks.append("Linux cannot become game source or produce fake Windows process identity")
    report = {"allPassed": True, "checks": checks, "windowsExecutionTested": False,
              "gameRuntimeTested": False, "lbParityVerified": False}
    (ROOT / "tests/verification.json").write_text(json.dumps(report, indent=2) + "\n")
    print(json.dumps(report))

if __name__ == "__main__":
    main()
