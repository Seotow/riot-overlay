// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180420950; descriptive alias: FUN_180420950
// Evidence: ev_f5919b3d191230116270e755b0893d97cceb6480e7a438c500e35d52245b0f0e
// Original Evidence: rea-collector/0x180420950.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined1 FUN_180420950(longlong param_1)

{
  uint uVar1;
  
  if (DAT_180d5e300 == '\0') {
    return *(undefined1 *)((ulonglong)(DAT_180d5de98 + 0xe6632e3aU ^ 0x11bf48c) + param_1);
  }
  uVar1 = FUN_18052b510(&DAT_180d5de98);
  return *(undefined1 *)((ulonglong)uVar1 + param_1);
}

