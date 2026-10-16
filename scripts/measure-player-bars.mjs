import{createRequire}from"node:module";import{resolve}from"node:path";
const sharp=createRequire(import.meta.url)(resolve(process.env.OVERLAY_BROWSER_PACKAGES,"sharp"));
const path="C:/Users/Seotow/AppData/Local/Temp/codex-clipboard-fef32d02-cc29-488e-8b2e-6e673520d533.png";
await sharp(path).extract({left:715,top:840,width:460,height:100}).resize(1380,300,{kernel:"nearest"}).toFile(".npm-cache/visual-audit/player-bars-reference.png");
for(const [label,crop,filter]of[
 ["xp",{left:766,top:846,width:73,height:14},([r,g,b])=>r>70&&b>70&&r>g*1.4&&b>g*1.4],
 ["energy",{left:1086,top:859,width:69,height:15},([r,g,b])=>r>120&&g>120&&b<110],
]){const{data}=await sharp(path).extract(crop).removeAlpha().raw().toBuffer({resolveWithObject:true});const matches=[];for(let p=0;p<data.length;p+=3){const c=[...data.subarray(p,p+3)];if(filter(c))matches.push(c);}const median=[0,1,2].map(i=>matches.map(c=>c[i]).sort((a,b)=>a-b)[Math.floor(matches.length/2)]);console.log(JSON.stringify({label,pixels:matches.length,median,hex:median.every(n=>n!==undefined)?"#"+median.map(n=>n.toString(16).padStart(2,"0")).join(""):null}));}
