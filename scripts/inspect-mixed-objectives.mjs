import{createRequire}from"node:module";
import{resolve}from"node:path";
import{readFile,writeFile,mkdir}from"node:fs/promises";
const sharp=createRequire(import.meta.url)(resolve(process.env.OVERLAY_BROWSER_PACKAGES,"sharp"));
const root=".npm-cache/visual-audit/mixed-objectives";await mkdir(root,{recursive:true});
const input="C:/Users/Seotow/AppData/Local/Temp/codex-clipboard-31a4f690-8762-4de5-a093-1c83c4a30c13.png";
await sharp(input).extract({left:118,top:9,width:108,height:52}).resize(648,312,{kernel:"nearest"}).toFile(root+"/elder-reference.png");
const{data,info}=await sharp(input).extract({left:123,top:15,width:34,height:38}).removeAlpha().raw().toBuffer({resolveWithObject:true});
const colors=[];for(let p=0;p<data.length;p+=3){const[r,g,b]=data.subarray(p,p+3);if(g>150&&b>150&&r<90&&Math.abs(g-b)<70)colors.push([r,g,b]);}
const median=[0,1,2].map(i=>colors.map(c=>c[i]).sort((a,b)=>a-b)[Math.floor(colors.length/2)]);
console.log(JSON.stringify({cyanPixels:colors.length,median,hex:"#"+median.map(c=>c.toString(16).padStart(2,"0")).join("")}));
await sharp(await readFile("baron.svg")).resize(300,300).png().toFile(root+"/baron-user.png");
await sharp("public/broadcast/objectives/grubs.svg").resize(180,180).png().toFile(root+"/grubs-old.png");
