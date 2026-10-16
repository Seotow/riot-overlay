import assert from "node:assert/strict";
import { mkdir, writeFile } from "node:fs/promises";
import { resolve } from "node:path";
import { CollectorRuntime } from "../runtime/supervisor";

const runtime=new CollectorRuntime({port:18811});
const startedAt=new Date().toISOString();
let started=false,alive=false,stopped=false;
try{
  await runtime.setEnabled(true);assert.equal(runtime.snapshot().owned,true);started=true;
  for(let i=0;i<100;i++){
    try{alive=(await fetch("http://127.0.0.1:18811/api/health",{signal:AbortSignal.timeout(1000)})).ok;}catch{}
    if(alive)break;await new Promise(r=>setTimeout(r,100));
  }
  assert.ok(alive,"Owned collector health unavailable");
  assert.equal((await fetch("http://127.0.0.1:18811/internal/stop",{method:"POST"})).status,403);
  await runtime.stop();assert.equal(runtime.snapshot().owned,false);
  for(let i=0;i<30;i++){
    try{await fetch("http://127.0.0.1:18811/api/health",{signal:AbortSignal.timeout(500)});}catch{stopped=true;break;}
    await new Promise(r=>setTimeout(r,100));
  }
  assert.ok(stopped,"Owned collector still listening after stop");
}finally{await runtime.stop();}
const report={kind:"collector-owned-runtime-check",startedAt,dateLocal:"2026-10-15",started,alive,unauthenticatedStopRejected:true,stopped,
  rawRecorded:false,credentialsExported:false,gameTelemetryVerified:false};
const folder=resolve("Collector/evidence/validation");await mkdir(folder,{recursive:true});
await writeFile(resolve(folder,`owned-runtime-${startedAt.replaceAll(":","-")}.json`),JSON.stringify(report,null,2),{flag:"wx"});
console.log(JSON.stringify(report));
