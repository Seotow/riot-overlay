// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180424b00; descriptive alias: FUN_180424b00
// Evidence: ev_6b0e0017023b6f49fdaf073130c3d14209cea428d9f5137ef716be95982fcf95
// Original Evidence: rea-collector/0x180424b00.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined4 FUN_180424b00(longlong param_1)

{
  uint uVar1;
  
  if (DAT_180d47b70 == '\0') {
    return *(undefined4 *)((ulonglong)(DAT_180d47708 + 0xe6632e3aU ^ 0x11bf48c) + param_1);
  }
  uVar1 = FUN_18052b510(&DAT_180d47708);
  return *(undefined4 *)((ulonglong)uVar1 + param_1);
}

