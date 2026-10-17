// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1804248b0; descriptive alias: FUN_1804248b0
// Evidence: ev_bb0dc337025901f241f4bd86cb141cea5a1189ac85531b31a5d03bc7c7da9a8c
// Original Evidence: rea-collector/0x1804248b0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

longlong FUN_1804248b0(void)

{
  uint uVar1;
  
  if (DAT_180d47280 == '\0') {
    uVar1 = DAT_180d46e18 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar1 = FUN_18052b510(&DAT_180d46e18);
  }
  if (uVar1 == 0) {
    return 0;
  }
  return (ulonglong)uVar1 + DAT_180d20bd0;
}

