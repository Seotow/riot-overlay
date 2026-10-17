// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180432100; descriptive alias: FUN_180432100
// Evidence: ev_ebc86d0e9e852b8b95bd95ba7f23b7836b9a6529eb89d9df643d2c9ad6ef6157
// Original Evidence: rea-collector/0x180432100.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined8 * FUN_180432100(longlong param_1,undefined8 *param_2)

{
  longlong lVar1;
  char cVar2;
  uint uVar3;
  ulonglong uVar4;
  
  if (DAT_180d354d8 == '\0') {
    uVar3 = DAT_180d35070 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar3 = FUN_18052b510(&DAT_180d35070);
  }
  lVar1 = *(longlong *)((ulonglong)((DAT_180d40300 + 0xe6632e3aU ^ 0x11bf48c) + uVar3) + param_1);
  if (lVar1 != 0) {
    cVar2 = FUN_1801fa260(lVar1);
    if (cVar2 == '\0') {
      FUN_180433580();
    }
    else {
      lVar1 = *(longlong *)(((ulonglong)(DAT_180d40304 + 0xe6632e3a) ^ 0x11bf48c) + lVar1);
      cVar2 = FUN_1801fa260(lVar1);
      if (cVar2 != '\0') {
        uVar4 = (ulonglong)(DAT_180d40308 + 0xe6632e3a) ^ 0x11bf48c;
        *param_2 = *(undefined8 *)(uVar4 + lVar1);
        param_2[1] = (ulonglong)*(uint *)(uVar4 + 8 + lVar1);
        return param_2;
      }
      FUN_180433930();
    }
  }
  param_2[1] = 0;
  *param_2 = &DAT_180c0f302;
  return param_2;
}

