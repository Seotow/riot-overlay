// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1804208f0; descriptive alias: FUN_1804208f0
// Evidence: ev_0e3aba530dedbbd69ad0a2f1f1010938a107d444cfc5d57c40d2fad168d84398
// Original Evidence: rea-collector/0x1804208f0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined8 * FUN_1804208f0(longlong param_1,undefined8 *param_2)

{
  undefined4 uVar1;
  uint uVar2;
  
  if (DAT_180d5d140 == '\0') {
    uVar2 = DAT_180d5ccd8 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar2 = FUN_18052b510(&DAT_180d5ccd8);
  }
  uVar1 = *(undefined4 *)((ulonglong)uVar2 + 8 + param_1);
  *param_2 = *(undefined8 *)((ulonglong)uVar2 + param_1);
  *(undefined4 *)(param_2 + 1) = uVar1;
  return param_2;
}

