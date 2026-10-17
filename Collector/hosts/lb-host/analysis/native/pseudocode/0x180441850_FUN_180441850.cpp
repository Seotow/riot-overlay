// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180441850; descriptive alias: FUN_180441850
// Evidence: ev_65b9544a2e105e271c029b59bbf7ab33a9a5a5c6bb56e527ce6e7f41fba9a253
// Original Evidence: rea-collector/0x180441850.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

void FUN_180441850(longlong param_1,undefined8 param_2,undefined4 *param_3,undefined8 param_4)

{
  undefined4 *puVar1;
  undefined1 local_res8 [8];
  undefined1 local_res18 [16];
  
  *(undefined4 *)(param_1 + 0x488) = *param_3;
  puVar1 = (undefined4 *)FUN_18043eea0(param_1,local_res8,param_2);
  puVar1 = (undefined4 *)
           FUN_1801b3ec0(local_res18,*(undefined8 *)(param_1 + 0x480),1,*puVar1,param_4);
  *(undefined4 *)(param_1 + 0x8770) = *puVar1;
  return;
}

