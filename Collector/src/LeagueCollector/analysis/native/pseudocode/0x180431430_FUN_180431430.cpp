// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180431430; descriptive alias: FUN_180431430
// Evidence: ev_e5c0ccb0d187004ec9793c36a8c0243a2f65817072ae2e96cf97e56aab1ab1d5
// Original Evidence: rea-collector/0x180431430.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined8 * FUN_180431430(longlong param_1,undefined8 *param_2)

{
  undefined4 uVar1;
  uint uVar2;
  
  if (DAT_180d2ea58 == '\0') {
    uVar2 = DAT_180d2e5f0 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar2 = FUN_18052b510(&DAT_180d2e5f0);
  }
  uVar1 = *(undefined4 *)((ulonglong)uVar2 + 8 + param_1);
  *param_2 = *(undefined8 *)((ulonglong)uVar2 + param_1);
  *(undefined4 *)(param_2 + 1) = uVar1;
  return param_2;
}

