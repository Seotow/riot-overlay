// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1804318b0; descriptive alias: FUN_1804318b0
// Evidence: ev_76c24c88103f82d660187d12963f2c7e45d6622da69c55caecd0cdb9af583ab1
// Original Evidence: rea-collector/0x1804318b0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined1 FUN_1804318b0(longlong param_1)

{
  uint uVar1;
  
  if (DAT_180d304f8 == '\0') {
    return *(undefined1 *)((ulonglong)(DAT_180d30090 + 0xe6632e3aU ^ 0x11bf48c) + param_1);
  }
  uVar1 = FUN_18052b510(&DAT_180d30090);
  return *(undefined1 *)((ulonglong)uVar1 + param_1);
}

