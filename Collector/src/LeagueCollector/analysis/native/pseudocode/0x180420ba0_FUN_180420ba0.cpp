// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180420ba0; descriptive alias: FUN_180420ba0
// Evidence: ev_4026a351feb1a799c3cd09a5a50df0f65bf0d3e2083578ddd4aa4f0441396192
// Original Evidence: rea-collector/0x180420ba0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

void FUN_180420ba0(longlong param_1,undefined4 param_2)

{
  uint uVar1;
  
  if (DAT_180d5da20 == '\0') {
    *(undefined4 *)((ulonglong)(DAT_180d5d5b8 + 0xe6632e3aU ^ 0x11bf48c) + param_1) = param_2;
    return;
  }
  uVar1 = FUN_18052b510(&DAT_180d5d5b8);
  *(undefined4 *)((ulonglong)uVar1 + param_1) = param_2;
  return;
}

