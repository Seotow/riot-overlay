// Preserve operator controls while restarting this app after a schema upgrade.
import {WebSocket} from "ws";
import {readFile,writeFile} from "node:fs/promises";
const base="http://127.0.0.1:4310",path=".npm-cache/name-ui-session.json";
const ws=new WebSocket(base.replace("http","ws")+"/ws",{origin:base});
let state;ws.on("message",b=>{const r=JSON.parse(b);if(r.type==="snapshot")state=r.state;});
const pause=ms=>new Promise(r=>setTimeout(r,ms));
await new Promise((r,j)=>{ws.once("open",r);ws.once("error",j);});
try{
 for(let i=0;i<100&&!state;i++)await pause(50);
 if(!state)throw Error("No state");
 if(process.argv.includes("--save")){
  const p=await(await fetch(base+"/api/providers")).json();
  await writeFile(path,JSON.stringify({broadcast:state.broadcast,scene:state.scene,recording:p.recording},null,2));
  console.log(JSON.stringify({saved:true,scene:state.scene,capture:p.recording.id,position:p.recording.positionMs}));
 }else{
  const saved=JSON.parse(await readFile(path,"utf8"));
  const id="2026-10-16T19-49-29-104Z";
  ws.send(JSON.stringify({type:"captureLoad",id}));
  let loaded=false;for(let i=0;i<200;i++){
   const p=await(await fetch(base+"/api/providers")).json();
   if(p.recording.id===id){loaded=true;break;}await pause(100);
  }
  if(!loaded)throw Error("Capture not loaded");
  ws.send(JSON.stringify({type:"captureControl",playing:saved.recording.playing??false,positionMs:saved.recording.positionMs??770346,speed:saved.recording.speed??1}));
  if(saved.broadcast)ws.send(JSON.stringify({type:"broadcast",value:saved.broadcast}));
  ws.send(JSON.stringify({type:"scene",value:saved.scene??"ingame"}));
  await pause(400);
  console.log(JSON.stringify({restored:true,capture:id,broadcast:state.broadcast}));
 }
}finally{ws.close();}
