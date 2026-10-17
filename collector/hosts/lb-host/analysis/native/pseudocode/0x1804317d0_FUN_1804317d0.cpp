// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1804317d0; descriptive alias: FUN_1804317d0
// Evidence: ev_35495d20ae142fc7ba99bf92ffe0e52caf8d145da425b841d91f89b8b8bb1423
// Original Evidence: rea-collector/0x1804317d0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined4 FUN_1804317d0(longlong param_1)

{
  uint uVar1;
  
  if (DAT_180d30088 == '\0') {
    return *(undefined4 *)((ulonglong)(DAT_180d2fc20 + 0xe6632e3aU ^ 0x11bf48c) + param_1);
  }
  uVar1 = FUN_18052b510(&DAT_180d2fc20);
  return *(undefined4 *)((ulonglong)uVar1 + param_1);
}

