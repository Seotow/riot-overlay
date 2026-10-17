import test from "node:test";import assert from "node:assert/strict";
import {projectItemCounters} from "../shared/item-counters";
import {ItemCounter} from "../src/overlay/ItemCounter";
import {normalizeIngame} from "../server/ingame-adapter";
import {createElement} from "react";import {renderToStaticMarkup} from "react-dom/server";

test("starter World Atlas hides quantity while every upgraded support item keeps ward stock",()=>{
 const p=normalizeIngame({allPlayers:[{}]},null,"2026-10-17T00:00:00Z").players[0];
 const upgrades=[3866,3867,3869,3870,3871,3876,3877];
 p.itemCounters={...p.totalGold,value:[3865,...upgrades].map((id,slot)=>({id,slot,stack:null,quantity:1})),availability:"observed"};
 const render=(id:number,slot?:number)=>renderToStaticMarkup(createElement(ItemCounter,{player:p,id,slot}));
 assert.equal(render(3865,0),"");assert.equal(render(3865),"");
 assert.equal(p.itemCounters.value?.[0].quantity,1); // UI suppression never deletes source data.
 for(const id of upgrades){assert.match(render(id),/item-stock-number[^]*?>1<\/small>/);}
 p.itemCounters.value=[{id:3867,slot:8,stack:null,quantity:0}];
 assert.match(render(3867),/item-stock-number[^]*?>0<\/small>/);
});
test("Riot live-client exposes actual inventory quantity but cannot fabricate Tear stacks or ward ammo",()=>{
 const p=normalizeIngame({allPlayers:[{items:[{itemID:2003,slot:0,count:2},{itemID:3070,slot:1,count:1},{itemID:3340,slot:6,count:1}]}]},null,"2026-10-17T00:00:00Z").players[0];
 assert.deepEqual(p.itemCounters?.value,[{id:2003,slot:0,stack:null,quantity:2}]);
});
test("Tear and Gluttonous Greaves use charges as points, never inventory quantity or generic stacks",()=>{
 assert.deepEqual(projectItemCounters([{id:3070,slot:0,count:1,stacks:1,charges:108},{id:3008,slot:1,count:1,charges:7}]),[
  {id:3070,slot:0,stack:108,quantity:null},{id:3008,slot:1,stack:7,quantity:null}]);
 assert.deepEqual(projectItemCounters([{id:3070,slot:0,count:1}]),[]);
});
test("potion quantity, trinket ammo, support ward stock and auxiliary control ward are separate direct values",()=>{
 assert.deepEqual(projectItemCounters([{id:2003,slot:0,count:2},{id:3340,slot:6,count:1,charges:0},{id:3866,slot:1,count:1,charges:3},{id:2055,slot:8,count:2}], [{index:12,ammoCount:2}]),[
  {id:2003,slot:0,stack:null,quantity:2},{id:3340,slot:6,stack:null,quantity:2},
  {id:3866,slot:1,stack:null,quantity:3},{id:2055,slot:8,stack:null,quantity:2}]);
 assert.deepEqual(projectItemCounters([{id:3340,slot:6,count:1}], [{index:12,ammoCount:0}]),[{id:3340,slot:6,stack:null,quantity:0}]);
});
test("item counter displays accumulation and stock using different positions and matches exact duplicate item slot",()=>{
 const p=normalizeIngame({allPlayers:[{}]},null,"2026-10-17T00:00:00Z").players[0];
 p.itemCounters={...p.totalGold,value:[{id:3070,slot:0,stack:108,quantity:null},{id:2055,slot:8,stack:null,quantity:2},{id:2055,slot:1,stack:null,quantity:1}],availability:"observed"};
 const render=(id:number,slot?:number)=>renderToStaticMarkup(createElement(ItemCounter,{player:p,id,slot}));
 assert.match(render(3070,0),/item-stack-number[^]*?>108<\/small>/);
 assert.match(render(2055,8),/item-stock-number[^]*?>2<\/small>/);
 assert.match(render(2055),/item-stock-number[^]*?>2<\/small>/);
 assert.equal(render(3070,1),"");
 p.itemCounters.availability="missing";assert.equal(render(3070,0),"");
});
