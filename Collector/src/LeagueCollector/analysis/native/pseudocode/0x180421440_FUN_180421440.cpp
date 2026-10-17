// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180421440; descriptive alias: FUN_180421440
// Evidence: ev_21f2ac535109b3636ab2683608a4e33cb08d80ec76b1f1f1a5eb76376517f72f
// Original Evidence: rea-collector/0x180421440.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined8 FUN_180421440(longlong param_1)

{
  int iVar1;
  ulonglong uVar2;
  
  if (DAT_180d28d10 == '\0') {
    uVar2 = DAT_180d288a8 + 0x6df70a65e6632e3aU ^ 0xbcd1994011bf48c;
  }
  else {
    uVar2 = FUN_18052c740(&DAT_180d288a8,0);
  }
  iVar1 = *(int *)(uVar2 + param_1);
  if (iVar1 == 1) {
    return 1;
  }
  if (iVar1 == 2) {
    return 2;
  }
  if (iVar1 != 3) {
    if (iVar1 != 4) {
      return 0;
    }
    return 4;
  }
  return 3;
}

