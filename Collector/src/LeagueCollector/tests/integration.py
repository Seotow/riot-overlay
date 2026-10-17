"""End-to-end collector checks using local HTTP/TLS/WebSocket fixtures only."""
from pathlib import Path
import base64
import contextlib
import hashlib
import http.server
import json
import os
import signal
import socket
import ssl
import struct
import subprocess
import tempfile
import threading
import time
import urllib.error
import urllib.request
import zipfile

ROOT = Path(__file__).resolve().parents[1]
DOTNET = str(Path(os.environ.get('DOTNET_ROOT', '/workspace/.tools/dotnet')) / ('dotnet.exe' if os.name == 'nt' else 'dotnet'))
APP = ROOT / 'dist/app/LeagueCollector.dll'
RESULTS = []

def free_port():
    with socket.socket() as s:
        s.bind(('127.0.0.1', 0)); return s.getsockname()[1]

def wait_for(fn, timeout=8):
    limit = time.monotonic() + timeout
    last = None
    while time.monotonic() < limit:
        try:
            result = fn()
            if result: return result
        except (OSError, ValueError, KeyError) as e: last = e
        time.sleep(.04)
    raise AssertionError('Timed out waiting for fixture condition: ' + str(type(last).__name__))

def request(port, path='/api/status', headers=None):
    r = urllib.request.Request(f'http://127.0.0.1:{port}{path}', headers=headers or {})
    try:
        with urllib.request.urlopen(r, timeout=2) as response:
            data = response.read(); return response.status, json.loads(data) if data and 'json' in response.headers.get('Content-Type', '') else data
    except urllib.error.HTTPError as e: return e.code, e.read()

@contextlib.contextmanager
def app(*args):
    port = free_port()
    env = {k:v for k,v in os.environ.items() if k not in ('LB_EMAIL','LB_PASSWORD')}
    with tempfile.TemporaryFile(mode='w+t') as log:
        process = subprocess.Popen([DOTNET, str(APP), '--port', str(port), '--interval', '50', '--no-lcu', *args], env=env, stdout=log, stderr=log)
        try:
            wait_for(lambda: request(port)[0] == 200)
            yield port, process
        finally:
            process.terminate()
            try: process.wait(timeout=8)
            except subprocess.TimeoutExpired: process.kill(); process.wait(); raise AssertionError('Collector did not shut down.')
            if process.returncode not in (0, -signal.SIGTERM):
                log.seek(0); raise AssertionError('Collector failed: ' + log.read()[-3000:])

class WebSocket:
    def __init__(self, port, origin=None):
        self.s = socket.create_connection(('127.0.0.1', port), timeout=3)
        key = base64.b64encode(os.urandom(16)).decode()
        text = f'GET /ws HTTP/1.1\r\nHost: 127.0.0.1:{port}\r\nUpgrade: websocket\r\nConnection: Upgrade\r\nSec-WebSocket-Version: 13\r\nSec-WebSocket-Key: {key}\r\n'
        if origin: text += f'Origin: {origin}\r\n'
        self.s.sendall((text+'\r\n').encode()); self.buffer = b''
        while b'\r\n\r\n' not in self.buffer: self.buffer += self.s.recv(4096)
        head,self.buffer=self.buffer.split(b'\r\n\r\n',1)
        assert b'101 Switching Protocols' in head
        expected = base64.b64encode(hashlib.sha1((key+'258EAFA5-E914-47DA-95CA-C5AB0DC85B11').encode()).digest())
        assert expected in head
    def read(self, n):
        while len(self.buffer)<n:
            block=self.s.recv(max(4096,n-len(self.buffer)))
            if not block: raise EOFError()
            self.buffer+=block
        result,self.buffer=self.buffer[:n],self.buffer[n:]; return result
    def frame(self):
        a,b=self.read(2);n=b&127
        if n==126:n=struct.unpack('!H',self.read(2))[0]
        elif n==127:n=struct.unpack('!Q',self.read(8))[0]
        assert n<16*1024*1024
        return a&15,self.read(n)
    def message(self):
        while True:
            op,data=self.frame()
            if op==1:return json.loads(data)
            if op==8:raise EOFError()
    def send(self, text):
        data=text.encode();mask=os.urandom(4);assert len(data)<126
        self.s.sendall(bytes([0x81,128|len(data)])+mask+bytes(v^mask[i%4] for i,v in enumerate(data)))
    def close(self):self.s.close()

class Fixture(http.server.BaseHTTPRequestHandler):
    available = True
    phase = 'ChampSelect'
    token = 'fixture-token'
    def log_message(self,*args):pass
    def do_GET(self):
        if not type(self).available:self.send_error(503);return
        if self.path.startswith('/lol-'):
            expected='Basic '+base64.b64encode(('riot:'+type(self).token).encode()).decode()
            if self.headers.get('Authorization')!=expected:self.send_error(401);return
        if self.path=='/liveclientdata/allgamedata':
            body={'gameData':{'gameTime':123.5},'allPlayers':[{'championName':'Ahri','level':12,'scores':{'kills':4}}],'events':{'Events':[]}}
        elif self.path=='/lol-gameflow/v1/gameflow-phase':body=type(self).phase
        elif self.path=='/lol-champ-select/v1/session':body={'myTeam':[{'championId':103}],'enemyTeam':[]}
        else:self.send_error(404);return
        data=json.dumps(body).encode();self.send_response(200);self.send_header('Content-Type','application/json');self.send_header('Content-Length',str(len(data)));self.end_headers();self.wfile.write(data)

@contextlib.contextmanager
def fixture(tls=None):
    server=http.server.ThreadingHTTPServer(('127.0.0.1',0),Fixture)
    if tls:
        context=ssl.SSLContext(ssl.PROTOCOL_TLS_SERVER);context.load_cert_chain(*tls)
        server.socket=context.wrap_socket(server.socket,server_side=True)
    t=threading.Thread(target=server.serve_forever,daemon=True);t.start()
    try:yield server.server_port
    finally:server.shutdown();server.server_close();t.join()

def check(name, fn):
    started=time.monotonic();fn();RESULTS.append({'name':name,'passed':True,'seconds':round(time.monotonic()-started,3)});print(name+': passed',flush=True)

def main():
    with tempfile.TemporaryDirectory(prefix='collector-tests-') as folder:
        temp=Path(folder);record=temp/'record.ndjson'
        def demo():
            with app('--source','demo','--record',str(record)) as (port,process):
                frame=wait_for(lambda:request(port,'/api/snapshot')[1])
                assert frame['synthetic'] is True and frame['source']=='demo'
                assert frame['data']['heroes'][0]['info']['position']['x']>=5000
                ws=WebSocket(port,f'http://127.0.0.1:{port}');frames=[ws.message() for _ in range(4)];ws.close()
                assert all(f['schemaVersion']==1 for f in frames)
                assert [f['sequence'] for f in frames]==sorted({f['sequence'] for f in frames})
                wait_for(lambda:request(port)[1]['collector']['clients']==1) # recorder only
                assert request(port,'/api/status',{'Origin':'https://untrusted.example'})[0]==403
                assert request(port,'/api/status',{'Host':'untrusted.example'})[0]==403
                assert request(port,'/overlay.html')[0]==200
                reader=WebSocket(port);reader.send('unsupported-command');closed=False
                for _ in range(10):
                    op,body=reader.frame()
                    if op==8:
                        assert struct.unpack('!H',body[:2])[0]==1008;closed=True;break
                reader.close();assert closed
                status=request(port)[1]
                assert status['recording']['state']=='recording' and status['recording']['dropped']==0
            lines=[json.loads(line) for line in record.read_text().splitlines()]
            assert len(lines)>3 and any(f['type']=='snapshot' for f in lines)
            assert all(f['source']=='demo' for f in lines)
            before=record.read_bytes()
            with app('--source','demo','--record',str(record)) as (port,_):
                wait_for(lambda:request(port)[1]['recording']['state']=='error')
            assert record.read_bytes()==before
        check('demo_http_websocket_recording_origin_shutdown',demo)

        def replay():
            with app('--replay',str(record),'--speed','1','--loop') as (port,_):
                ws=WebSocket(port)
                frame=wait_for(lambda:next((f for f in [ws.message()] if f['type']=='snapshot'),None))
                ws.close()
                assert frame['source']=='replay' and frame['synthetic'] is True and frame['recordedAt']
                original=[json.loads(line) for line in record.read_text().splitlines() if json.loads(line)['type']=='snapshot']
                assert frame['data'] in [f['data'] for f in original]
            bad=temp/'bad.ndjson';bad.write_text('{"schemaVersion":2}\n')
            with app('--replay',str(bad)) as (port,_):
                wait_for(lambda:request(port)[1]['collector']['state']=='error')
                assert request(port,'/api/snapshot')[0]==204
        check('record_replay_provenance_invalid_replay',replay)

        def live():
            Fixture.available=True
            with fixture() as upstream,app('--source','live','--live-url',f'http://127.0.0.1:{upstream}/liveclientdata/allgamedata') as (port,_):
                frame=wait_for(lambda:request(port,'/api/snapshot')[1])
                assert frame['synthetic'] is False and frame['data']['camera'] is None
                assert frame['data']['rawLiveClientData']['gameData']['gameTime']==123.5
                Fixture.available=False
                wait_for(lambda:request(port,'/api/snapshot')[0]==204)
                Fixture.available=True
                wait_for(lambda:request(port,'/api/snapshot')[0]==200)
        check('live_api_full_payload_disconnect_reconnect',live)

        def lcu():
            cert=temp/'cert.pem';key=temp/'key.pem'
            subprocess.run(['openssl','req','-x509','-newkey','rsa:2048','-nodes','-keyout',str(key),'-out',str(cert),'-subj','/CN=localhost','-days','1'],stdout=subprocess.DEVNULL,stderr=subprocess.DEVNULL,check=True)
            lock=temp/'lockfile';Fixture.phase='ChampSelect';Fixture.token='first-fixture-token'
            with fixture((str(cert),str(key))) as upstream:
                lock.write_text(f'LeagueClient:123:{upstream}:{Fixture.token}:https')
                with app('--source','demo','--lockfile',str(lock)) as (port,_):
                    wait_for(lambda:request(port,'/api/lcu')[1].get('data',{}).get('state')=='connected')
                    data=request(port,'/api/lcu')[1];assert data['data']['champSelect']['myTeam'][0]['championId']==103
                    Fixture.phase='InProgress'
                    wait_for(lambda:request(port,'/api/lcu')[1]['data']['phase']=='InProgress')
                    assert request(port,'/api/lcu')[1]['data']['champSelect'] is None
                    lock.write_text('invalid')
                    wait_for(lambda:request(port,'/api/lcu')[1]['data']['state']=='waiting')
                    Fixture.token='rotated-fixture-token';lock.write_text(f'LeagueClient:123:{upstream}:{Fixture.token}:https')
                    wait_for(lambda:request(port,'/api/lcu')[1]['data']['state']=='connected')
                    assert Fixture.token not in json.dumps(request(port)[1])
        check('lcu_tls_champselect_phase_token_rotation',lcu)

        def native_guard():
            if os.name=='nt':return
            with app('--source','lblib') as (port,_):
                wait_for(lambda:request(port)[1]['collector']['state']=='error')
                data=request(port)[1]['collector']
                assert data['state']=='error' and data['error']=='windows_required'
                assert request(port,'/api/snapshot')[0]==204
        check('native_platform_guard_no_synthetic_fallback',native_guard)

        def diagnostics():
            destination=temp/'diagnostics'
            env={**os.environ,'LB_EMAIL':'diagnostic-fixture@example.invalid','LB_PASSWORD':'diagnostic-secret-sentinel'}
            def export(port):
                result=subprocess.run([DOTNET,str(APP),'--export-diagnostics','--port',str(port),'--diagnostics-dir',str(destination)],env=env,capture_output=True,text=True,timeout=25)
                info=json.loads(result.stdout)
                with zipfile.ZipFile(info['archive']) as archive:
                    assert archive.testzip() is None
                    payload={name:archive.read(name) for name in archive.namelist()}
                    assert all(name.endswith('.json') for name in payload)
                    assert b'diagnostic-secret-sentinel' not in b''.join(payload.values())
                    assert b'diagnostic-fixture@example.invalid' not in b''.join(payload.values())
                    summary=json.loads(payload['capture-summary.json'])
                return result,info,payload,summary
            with app('--source','demo') as (port,_):
                wait_for(lambda:request(port,'/api/snapshot')[0]==200)
                result,info,payload,summary=export(port)
                assert result.returncode==0 and info['collectorReached'] is True
                assert json.loads(payload['snapshot.json'])['source']=='demo'
                validation=json.loads(payload['status.json'])['validation']
                assert validation['freeTierParityVerified'] is False and validation['unauthenticatedNativeVerified'] is False
                assert any(c['endpoint']=='/api/lcu' and c['httpStatus']==204 for c in summary['captures'])
                assert 'lcu.json' not in payload
            result,info,payload,summary=export(free_port())
            assert result.returncode==1 and info['collectorReached'] is False
            assert set(payload)=={'capture-summary.json'}
            assert all(c['error']=='capture_failed' for c in summary['captures'])
        check('diagnostics_success_missing_data_offline_no_credentials',diagnostics)
    (ROOT/'build-logs/integration.json').write_text(json.dumps({'passed':True,'real_game_tested':False,'checks':RESULTS},indent=2))

if __name__=='__main__':main()
