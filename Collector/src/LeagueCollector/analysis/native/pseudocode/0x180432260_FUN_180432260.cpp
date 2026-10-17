// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180432260; descriptive alias: FUN_180432260
// Evidence: ev_c7f9628a1b139d065da9cf9b89cc075f907fe3045d0647199a456c2d78a1cac0
// Original Evidence: rea-collector/0x180432260.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined8 FUN_180432260(longlong param_1)

{
  uint uVar1;
  
  if (DAT_180d35db8 == '\0') {
    return *(undefined8 *)((ulonglong)(DAT_180d35950 + 0xe6632e3aU ^ 0x11bf48c) + param_1);
  }
  uVar1 = FUN_18052b510(&DAT_180d35950);
  return *(undefined8 *)((ulonglong)uVar1 + param_1);
}

