// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x18042ea40; descriptive alias: FUN_18042ea40
// Evidence: ev_79ce8a2abba9fab4d069bd00c209353a8454725523a023da037e4917ad253a7f
// Original Evidence: rea-collector/0x18042ea40.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

int FUN_18042ea40(undefined8 param_1,undefined8 param_2,undefined8 param_3,undefined8 param_4)

{
  int iVar1;
  undefined8 *puVar2;
  undefined8 local_res18;
  undefined8 local_res20;
  
  local_res18 = param_3;
  local_res20 = param_4;
  puVar2 = (undefined8 *)FUN_18019e980();
  iVar1 = FUN_180986d28(*puVar2,param_1,0x40,param_2,0,&local_res18);
  if (iVar1 < 0) {
    iVar1 = -1;
  }
  return iVar1;
}

