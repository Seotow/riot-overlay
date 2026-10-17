// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1804312b0; descriptive alias: FUN_1804312b0
// Evidence: ev_115bd69a42dede994f2e1ac018c8cf25d9adbd9718b33f64d3ce833f4313f863
// Original Evidence: rea-collector/0x1804312b0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined4 FUN_1804312b0(longlong param_1)

{
  uint uVar1;
  
  if (DAT_180d2e5e8 == '\0') {
    return *(undefined4 *)((ulonglong)(DAT_180d2e180 + 0xe6632e3aU ^ 0x11bf48c) + param_1);
  }
  uVar1 = FUN_18052b510(&DAT_180d2e180);
  return *(undefined4 *)((ulonglong)uVar1 + param_1);
}

