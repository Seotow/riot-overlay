// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180424a50; descriptive alias: FUN_180424a50
// Evidence: ev_1d141af6560f63e7b7337fc7f3ef236e631921cb328ac3f91d6522a8b39ea1f1
// Original Evidence: rea-collector/0x180424a50.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

longlong FUN_180424a50(void)

{
  uint uVar1;
  longlong lVar2;
  
  if (DAT_180d47280 == '\0') {
    uVar1 = DAT_180d46e18 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar1 = FUN_18052b510(&DAT_180d46e18);
  }
  if (uVar1 == 0) {
    lVar2 = 0;
  }
  else {
    lVar2 = (ulonglong)uVar1 + DAT_180d20bd0;
  }
  return ((ulonglong)(DAT_180d47290 + 0xe6632e3a) ^ 0x11bf48c) + lVar2;
}

