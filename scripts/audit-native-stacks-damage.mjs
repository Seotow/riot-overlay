// Offline read-only audit: aggregate gameplay counters only, never names/IDs/credentials.
import{createReadStream}from"node:fs";
import{createGunzip}from"node:zlib";
import{createInterface}from"node:readline";
import{mkdir,writeFile,readFile}from"node:fs/promises";
const capture="2026-10-16T12-43-43-938Z",derived="2026-10-16T18-48-05-645Z";
const finite=n=>typeof n==="number"&&Number.isFinite(n);
const champions=new Map(),damagePaths=new Map(),damageEvents=new Set(),eventFields=new Set();
let frames=0,first=null,last=null,eventAppearances=0,championVictimEvents=0;
const identities=new Map();
function aggregate(map,key,value,time){
 if(!finite(value))return;
 let a=map.get(key);if(!a){a={samples:0,min:value,max:value,nonzero:0,changes:0,decreases:0,first:{time,value},last:{time,value},examples:[]};map.set(key,a);}
 a.samples++;a.min=Math.min(a.min,value);a.max=Math.max(a.max,value);if(value!==0)a.nonzero++;
 if(value!==a.last.value){a.changes++;if(value<a.last.value)a.decreases++;if(a.examples.length<8||a.changes%100===0){a.examples.push({time,value});if(a.examples.length>14)a.examples.splice(8,1);}}
 a.last={time,value};
}
function damageNumbers(value,path,time,depth=0){
 if(!value||typeof value!=="object"||depth>5)return;
 for(const[k,v]of Object.entries(value)){
  if(/name|id$|network|address|account|summoner|token|password/i.test(k))continue;
  const p=`${path}.${k}`;
  if(finite(v)&&/damage|amount/i.test(k))aggregate(damagePaths,p,v,time);
  else if(v&&typeof v==="object"&&!Array.isArray(v))damageNumbers(v,p,time,depth+1);
 }
}
for await(const line of createInterface({input:createReadStream(`data/captures/${capture}/collector-native.ndjson.gz`).pipe(createGunzip()),crlfDelay:Infinity})){
 const r=JSON.parse(line),m=r.message;if(m?.type!=="snapshot")continue;
 const d=m.data,time=d.gameTime;frames++;first??=time;last=time;
 for(const h of d.heroes??[])identities.set(h.info?.networkId,"champion");
 for(const h of d.heroes??[]){
  damageNumbers(h,"heroes[]",time);
  const champion=h.common?.identifier;
  if(!["Smolder","Veigar"].includes(champion))continue;
  let c=champions.get(champion);if(!c){c={frames:0,buffCounters:new Map(),buffNames:new Set(),spellFields:new Set(),heroKeys:Object.keys(h),commonKeys:Object.keys(h.common??{})};champions.set(champion,c);}c.frames++;
  for(const b of h.common?.buffs??[]){
   if(typeof b.name!=="string")continue;c.buffNames.add(b.name);
   if(/smolder|veigar|evil|stack|dragonpractice|phenomenal/i.test(b.name))aggregate(c.buffCounters,b.name,b.count,time);
  }
  for(const s of h.spells??[])for(const[k,v]of Object.entries(s))if(finite(v)&&/stack|charge|damage|ammo/i.test(k))c.spellFields.add(k);
 }
 for(const e of d.gameEvents?.damageDealtEvents??[]){
  eventAppearances++;Object.keys(e).forEach(k=>eventFields.add(k));damageNumbers(e,"gameEvents.damageDealtEvents[]",time);
  const key=JSON.stringify(e);if(damageEvents.has(key))continue;damageEvents.add(key);
  if(identities.has(e.targetNetworkId))championVictimEvents++;
 }
 damageNumbers(d.misc,"misc",time);
}
const records=(await readFile(`data/captures/${derived}/observer-samples.ndjson`,"utf8")).trim().split(/\r?\n/);
const referenceDamagePaths=new Map();let referenceFrames=0;
function referenceDamage(value,path="message"){
 if(!value||typeof value!=="object")return;
 for(const[k,v]of Object.entries(value)){
  const p=Array.isArray(value)?`${path}[]`:`${path}.${k}`;
  if(/damage/i.test(k)&&finite(v))referenceDamagePaths.set(p,(referenceDamagePaths.get(p)??0)+1);
  if(v&&typeof v==="object")referenceDamage(v,p);
 }
}
for await(const line of createInterface({input:createReadStream(`data/captures/${capture}/riot-reference.ndjson.gz`).pipe(createGunzip()),crlfDelay:Infinity})){
 const r=JSON.parse(line);referenceFrames++;referenceDamage(r.message);
}
let normalizedStackFields=0,normalizedDamageFields=0;
for(const line of records)for(const p of JSON.parse(line).message.sample.players){
 normalizedStackFields+=Object.keys(p).filter(k=>/stack/i.test(k)).length;
 normalizedDamageFields+=Object.keys(p).filter(k=>/damage/i.test(k)).length;
}
const report={capture,derived,frames,gameTime:{first,last},champions:Object.fromEntries([...champions].map(([k,c])=>[k,{...c,buffCounters:Object.fromEntries(c.buffCounters),buffNames:[...c.buffNames].sort(),spellFields:[...c.spellFields]}])),damage:{appearances:eventAppearances,unique:damageEvents.size,championVictimEvents,eventFields:[...eventFields],numericDamageFields:Object.fromEntries(damagePaths)},riotReference:{frames:referenceFrames,numericDamageFields:Object.fromEntries(referenceDamagePaths)},normalized:{frames:records.length,stackFields:normalizedStackFields,damageFields:normalizedDamageFields}};
await mkdir(".npm-cache/data-audit",{recursive:true});
await writeFile(".npm-cache/data-audit/native-stacks-damage.json",JSON.stringify(report,null,2)+"\n");
console.log(JSON.stringify({frames,gameTime:report.gameTime,champions:Object.fromEntries([...champions].map(([k,c])=>[k,Object.fromEntries(c.buffCounters)])),damage:report.damage,normalized:report.normalized}));
