// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180431690; descriptive alias: FUN_180431690
// Evidence: ev_ff82f6bf6c2d2e738ba0d14ca667cbbf1d2c38de442c5dca83844b473f38fb9a
// Original Evidence: rea-collector/0x180431690.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined4 FUN_180431690(longlong param_1)

{
  uint uVar1;
  
  if (DAT_180d31b28 == '\0') {
    return *(undefined4 *)((ulonglong)(DAT_180d316c0 + 0xe6632e3aU ^ 0x11bf48c) + param_1);
  }
  uVar1 = FUN_18052b510(&DAT_180d316c0);
  return *(undefined4 *)((ulonglong)uVar1 + param_1);
}

