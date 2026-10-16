import type {ObservedPlayer} from "../../shared/observer";
export function ItemCounter({player,id,slot}:{player?:ObservedPlayer;id?:number|null;slot?:number}){
 if(!id)return null;
 const counters=player?.itemCounters;
 const rows=counters?.availability==="observed"?counters.value?.filter(c=>c.id===id):undefined;
 const c=slot===undefined ? rows?.find(c=>c.slot===8)??rows?.[0] : rows?.find(c=>c.slot===slot);
 return <>{c?.stack!=null&&<small className="item-stack-number" title={`Điểm tích lũy: ${c.stack}`}>{c.stack}</small>}
 {c?.quantity!=null&&<small className="item-stock-number" title={`Tích trữ: ${c.quantity}`}>{c.quantity}</small>}</>;
}
