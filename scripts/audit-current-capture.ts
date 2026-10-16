// Offline audit only: never opens game/provider sockets or modifies recorded payloads.
import {createReadStream} from 'node:fs';
import {readFile,writeFile,mkdir} from 'node:fs/promises';
import {createGunzip} from 'node:zlib';
import {createInterface} from 'node:readline';
import {resolve} from 'node:path';
import {normalizeCollector} from '../Collector/adapter/normalize';
import {liveChampion} from '../shared/live-assets';
const id=process.argv[2]??'2026-10-16T12-43-43-938Z';
if(!/^\d{4}-\d{2}-\d{2}T\d{2}-\d{2}-\d{2}-\d{3}Z$/.test(id))throw Error('Invalid capture id');
const root=resolve('data/captures',id),out=resolve('.npm-cache/capture-audit',id);
async function each(name:string,consume:(r:any)=>void,gzip=false){
  const file=createReadStream(resolve(root,name));const input=gzip?file.pipe(createGunzip()):file;
  const lines=createInterface({input,crlfDelay:Infinity});let count=0;
  for await(const line of lines){if(!line.trim())continue;consume(JSON.parse(line));count++;}
  return count;
}
const obj=(v:any)=>v&&typeof v==='object'&&!Array.isArray(v)?v:{};
const finite=(v:any)=>typeof v==='number'&&Number.isFinite(v);
const report:any={id,generatedAt:new Date().toISOString(),offline:true,inputUnmodified:true,manifest:JSON.parse(await readFile(resolve(root,'manifest.json'),'utf8')),references:0,nativeSnapshots:0,nativeStatus:0,normalizedFailures:0,observerSamples:0,sourceFields:{},observerFields:{},eventVectors:{},appEvents:{},referenceEvents:{},dragonDeaths:[],comparisons:{},heroFinal:[],objectiveBuffs:[],auxiliaryItems:[],nativeTopLevelKeys:[],examples:{}};
const refs:any[]=[];
const refEvents=new Set<string>();
await each('riot-reference.ndjson.gz',r=>{
  const players=new Map<string,any>();
  for(const p of r.sample?.players??[])players.set(`${p.team.value}:${p.championId.value}`,p);
  refs.push({wall:Date.parse(r.receivedAt),time:r.sample?.gameTime.value,players,raw:r.message});
  report.references++;
  for(const e of r.message?.events?.Events??[]){const key=`${e.EventID}:${e.EventName}:${e.EventTime}`;if(!refEvents.has(key)){refEvents.add(key);report.referenceEvents[e.EventName]=(report.referenceEvents[e.EventName]??0)+1;if(/Dragon|Baron|Herald|Turret|Inhib|GameEnd/.test(e.EventName))(report.examples.referenceObjectives??=[]).push(e);}}
},true);
function nearest(wall:number,time:number){
  let low=0,high=refs.length-1;
  while(low<=high){const mid=(low+high)>>1;if(refs[mid].wall<wall)low=mid+1;else high=mid-1;}
  return refs.slice(Math.max(0,low-2),low+3).filter(r=>Math.abs(r.wall-wall)<=400&&finite(r.time)&&Math.abs(r.time-time)<=0.2).sort((a,b)=>Math.abs(a.wall-wall)-Math.abs(b.wall-wall))[0];
}
function coverage(group:string,key:string,value:any){
  const c=report[group][key]??={present:0,missing:0,min:null,max:null,positive:0};
  if(value==null)c.missing++;else{c.present++;if(finite(value)){c.min=c.min==null?value:Math.min(c.min,value);c.max=c.max==null?value:Math.max(c.max,value);if(value>0)c.positive++;}}
}
const csExamples:any[]=[],diffs:Record<string,number>={},dragonUnits=new Map<number,any>(),heroesById=new Map<number,any>(),uniqueEvents=new Map<string,Set<string>>(),appEvents=new Set<string>(),aux=new Set<string>(),buffs=new Set<string>();
const lastHeroes=new Map<string,any>(),lastAlignedHeroes=new Map<string,any>(),buffWindows=new Map<string,any>();let aligned=0;
report.damageCandidates={positive:0,heroToHeroPositive:0,zeroOrMissing:0,negative:0};
report.csByChampion={};report.rawBuffExamples={};
function compare(field:string,native:any,reference:any,champion:string,time:number){
  if(native==null||reference==null)return;
  const c=report.comparisons[field]??={compared:0,equal:0,mismatch:0};c.compared++;
  const equal=typeof native==='number'&&typeof reference==='number'?Math.abs(native-reference)<0.0001:JSON.stringify(native)===JSON.stringify(reference);
  if(equal)c.equal++;else c.mismatch++;
  if(field==='csSum'&&finite(native)&&finite(reference)){
    const delta=native-reference;diffs[String(delta)]=(diffs[String(delta)]??0)+1;
    if(!equal&&csExamples.length<20)csExamples.push({champion,time,native,reference,delta});
  }
}
await each('collector-native.ndjson.gz',r=>{
  const e=r.message;if(e?.type!=='snapshot'){report.nativeStatus++;return;}
  const d=e.data,normalized=normalizeCollector(e,Date.parse(e.timestamp));
  report.nativeSnapshots++;if(!normalized)report.normalizedFailures++;
  if(report.nativeSnapshots===1){report.nativeTopLevelKeys=Object.keys(d);report.examples.teamStats=d.teamStats;report.examples.hqKeys=Object.keys(d.hqs?.[0]??{});report.examples.minionKeys=Object.keys(d.minions?.[0]??{});}
  if(report.nativeSnapshots%1500===0)console.log(JSON.stringify({progressNative:report.nativeSnapshots,gameTime:d.gameTime}));
  const ref=nearest(Date.parse(r.receivedAt),d.gameTime);if(ref)aligned++;
  for(const h of d.heroes??[]){
    const champion=h.common?.identifier,team=h.info?.team===1?'ORDER':'CHAOS',key=`${team}:${champion}`;
    heroesById.set(h.info?.networkId,{champion,team});
    const p=normalized?.sample.players.find(p=>p.team.value===team&&liveChampion(p.championId.value)?.id.toLowerCase()===String(champion).toLowerCase());
    const reference=p?ref?.players.get(`${team}:${p.championId.value}`):undefined;
    for(const [field,value]of Object.entries(h))if(field!=='heroIndex'&&(typeof value==='number'||value===null))coverage('sourceFields',field,value);
    for(const [field,value]of Object.entries(h.common??{}))if(typeof value==='number'||value===null)coverage('sourceFields','common.'+field,value);
    for(const slot of h.items??[])if(slot.slot>6)aux.add(`${slot.slot}:${slot.id}`);
    for(const b of h.common?.buffs??[]){const name=b.name??b.identifier??'';if(/baron|elder|dragon|exalted|soul/i.test(name))buffs.add(String(name));}
    if(p){
      for(const field of ['level','kills','deaths','assists','wardScore'])compare(field,(p as any)[field]?.value,reference?.[field]?.value,champion,d.gameTime);
      compare('csLane',h.laneMinionKills,reference?.cs.value,champion,d.gameTime);
      compare('csNeutral',h.neutralMinionKills,reference?.cs.value,champion,d.gameTime);
      compare('csSum',h.laneMinionKills+h.neutralMinionKills,reference?.cs.value,champion,d.gameTime);
      compare('items',p.inventory?.value?.filter(i=>i.id!==0).map(i=>`${i.slot}:${i.id}`).sort(),reference?.inventory?.value?.filter((i:any)=>i.id!==0).map((i:any)=>`${i.slot}:${i.id}`).sort(),champion,d.gameTime);
      compare('spells',p.spells?.value,reference?.spells?.value,champion,d.gameTime);
      compare('keystone',p.keystone?.value,reference?.keystone?.value,champion,d.gameTime);
      compare('isDeadStatusZero',h.common?.status===0,reference?.isDead?.value,champion,d.gameTime);
      if(finite(h.respawnTime)&&finite(reference?.respawnSeconds?.value)){
        const c=report.comparisons.respawnSeconds??={compared:0,withinQuarterSecond:0,maxDelta:0};const delta=Math.abs(h.respawnTime-reference.respawnSeconds.value);c.compared++;if(delta<=0.25)c.withinQuarterSecond++;c.maxDelta=Math.max(c.maxDelta,delta);
      }
      if(reference){
        lastAlignedHeroes.set(key,{champion,team,time:d.gameTime,referenceTime:ref.time,lane:h.laneMinionKills,neutral:h.neutralMinionKills,sum:h.laneMinionKills+h.neutralMinionKills,referenceCS:reference.cs.value});
        const c=report.csByChampion[key]??={compared:0,mismatch:0,maxDelta:0};c.compared++;const delta=h.laneMinionKills+h.neutralMinionKills-reference.cs.value;if(delta!==0)c.mismatch++;c.maxDelta=Math.max(c.maxDelta,Math.abs(delta));
      }
    }
    for(const b of h.common?.buffs??[]){const name=String(b.name??'').toLowerCase();if(['exaltedwithbaronnashor','elderdragonbuff','srx_dragonsoulbuffmountain'].includes(name)){
      const key=`${team}:${champion}:${name}`,window=buffWindows.get(key)??{champion,team,name,first:d.gameTime,last:d.gameTime};window.last=d.gameTime;buffWindows.set(key,window);report.rawBuffExamples[name]??=b;
    }}
    lastHeroes.set(key,{champion,team,time:d.gameTime,lane:h.laneMinionKills,neutral:h.neutralMinionKills,sum:h.laneMinionKills+h.neutralMinionKills,referenceCS:reference?.cs.value??null,kda:[h.kills,h.deaths,h.assists],status:h.common?.status,respawnTime:h.respawnTime});
  }
  for(const unit of d.minions??[]){const code=String(unit.common?.identifier??'').toLowerCase();if(code.includes('dragon')||code.includes('baron')||code.includes('herald'))dragonUnits.set(unit.info?.networkId,{code,firstSeen:dragonUnits.get(unit.info?.networkId)?.firstSeen??d.gameTime,lastSeen:d.gameTime,hp:unit.common?.health});}
  for(const [vector,value]of Object.entries(obj(d.gameEvents))){
    if(!Array.isArray(value))continue;
    const stats=report.eventVectors[vector]??={framesWithData:0,maxLength:0,unique:0,keys:[]};
    if(value.length){stats.framesWithData++;stats.maxLength=Math.max(stats.maxLength,value.length);if(!stats.keys.length){stats.keys=Object.keys(value[0]);report.examples[vector]=value[0];}}
    const seen=uniqueEvents.get(vector)??new Set<string>();uniqueEvents.set(vector,seen);
    for(const event of value){const key=JSON.stringify(event);if(seen.has(key))continue;seen.add(key);stats.unique++;
      if(vector==='damageDealtEvents'){
        if(!finite(event.damageDealt)||event.damageDealt===0)report.damageCandidates.zeroOrMissing++;
        else if(event.damageDealt<0)report.damageCandidates.negative++;
        else {report.damageCandidates.positive++;if(heroesById.has(event.sourceNetworkId)&&heroesById.has(event.targetNetworkId)){report.damageCandidates.heroToHeroPositive++;report.examples.heroDamage??=event;}}
      }
      if(vector==='deathEvents'){
        const unit=dragonUnits.get(event.victimNetworkId),killer=heroesById.get(event.killerNetworkId);
        if(unit)report.dragonDeaths.push({event,unit,killer:killer??null});
      }
    }
  }
},true);
await each('observer-samples.ndjson',r=>{
  const s=r.message.sample;report.observerSamples++;
  for(const p of s.players)for(const [key,f]of Object.entries(p))if(f&&typeof f==='object'&&'value'in f)coverage('observerFields',key,(f as any).value);
  for(const team of s.teams??[])for(const [key,f]of Object.entries(team))if(f&&typeof f==='object'&&'value'in f)coverage('observerFields','team.'+key,(f as any).value);
  for(const e of s.events){const key=`${e.id}:${e.at}:${e.kind}`;if(!appEvents.has(key)){appEvents.add(key);report.appEvents[e.kind]=(report.appEvents[e.kind]??0)+1;}}
});
report.alignedNativeFrames=aligned;report.csDifferenceHistogram=diffs;report.csMismatchExamples=csExamples;report.heroFinal=[...lastHeroes.values()];report.lastAlignedHeroes=[...lastAlignedHeroes.values()];report.buffWindows=[...buffWindows.values()];report.objectiveBuffs=[...buffs];report.auxiliaryItems=[...aux];report.nativeObjectiveUnits=[...dragonUnits.entries()].map(([networkId,unit])=>({networkId,...unit}));
await mkdir(out,{recursive:true});await writeFile(resolve(out,'audit.json'),JSON.stringify(report,null,2));
console.log(JSON.stringify({report:resolve(out,'audit.json'),nativeSnapshots:report.nativeSnapshots,observerSamples:report.observerSamples,referenceFrames:refs.length,appEvents:report.appEvents,dragonDeaths:report.dragonDeaths,comparisons:report.comparisons,heroFinal:report.heroFinal},null,2));
