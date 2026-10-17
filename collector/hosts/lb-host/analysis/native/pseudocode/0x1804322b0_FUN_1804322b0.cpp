// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1804322b0; descriptive alias: FUN_1804322b0
// Evidence: ev_c26cf669abb9869dac4319d6ec65aaa9a3c2b65e043ac0ba392f0a43d32f92b7
// Original Evidence: rea-collector/0x1804322b0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

longlong FUN_1804322b0(longlong param_1)

{
  uint uVar1;
  
  if (DAT_180d35948 == '\0') {
    return (ulonglong)(DAT_180d354e0 + 0xe6632e3aU ^ 0x11bf48c) + param_1;
  }
  uVar1 = FUN_18052b510(&DAT_180d354e0);
  return (ulonglong)uVar1 + param_1;
}

