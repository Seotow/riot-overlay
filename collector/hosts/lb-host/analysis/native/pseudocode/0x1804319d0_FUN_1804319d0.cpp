// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1804319d0; descriptive alias: FUN_1804319d0
// Evidence: ev_23882a92f69e8c981510acdd280c3d51f426c9ffb798b4ff439a63f8f26c4c66
// Original Evidence: rea-collector/0x1804319d0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined4 FUN_1804319d0(longlong param_1)

{
  uint uVar1;
  
  if (DAT_180d335c8 == '\0') {
    return *(undefined4 *)((ulonglong)(DAT_180d33160 + 0xe6632e3aU ^ 0x11bf48c) + param_1);
  }
  uVar1 = FUN_18052b510(&DAT_180d33160);
  return *(undefined4 *)((ulonglong)uVar1 + param_1);
}

