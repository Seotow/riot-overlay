// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180425750; descriptive alias: FUN_180425750
// Evidence: ev_b5f78fc91f2c7a095872de9dcdc525294041845c5e69ea6c6e393fd0c4fe2ad6
// Original Evidence: rea-collector/0x180425750.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined8 * FUN_180425750(longlong param_1,undefined8 *param_2)

{
  uint uVar1;
  char *local_18;
  size_t sStack_10;
  
  if (DAT_180d3f590 == '\0') {
    uVar1 = DAT_180d3f128 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar1 = FUN_18052b510(&DAT_180d3f128);
  }
  if (*(longlong *)((ulonglong)uVar1 + param_1) != 0) {
    local_18 = *(char **)(((ulonglong)(DAT_180d3f598 + 0xe6632e3a) ^ 0x11bf48c) +
                         *(longlong *)((ulonglong)uVar1 + param_1));
    if ((local_18 == (char *)0x0) || (sStack_10 = strlen(local_18), 0x3f < sStack_10 - 1)) {
      sStack_10 = 0;
      local_18 = "";
    }
    *param_2 = local_18;
    param_2[1] = sStack_10;
    return param_2;
  }
  param_2[1] = 0;
  *param_2 = &DAT_180c0f302;
  return param_2;
}

