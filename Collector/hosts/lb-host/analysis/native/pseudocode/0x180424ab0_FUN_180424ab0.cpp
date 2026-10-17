// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180424ab0; descriptive alias: FUN_180424ab0
// Evidence: ev_4a676d80e054cce254f1a329e8bdd32725a303df1dbed4cfc3b2343ca0f3a32d
// Original Evidence: rea-collector/0x180424ab0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined4 FUN_180424ab0(longlong param_1)

{
  uint uVar1;
  
  if (DAT_180d47700 == '\0') {
    return *(undefined4 *)((ulonglong)(DAT_180d47298 + 0xe6632e3aU ^ 0x11bf48c) + param_1);
  }
  uVar1 = FUN_18052b510(&DAT_180d47298);
  return *(undefined4 *)((ulonglong)uVar1 + param_1);
}

