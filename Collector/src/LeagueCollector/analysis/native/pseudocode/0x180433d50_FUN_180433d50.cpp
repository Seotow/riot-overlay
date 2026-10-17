// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180433d50; descriptive alias: FUN_180433d50
// Evidence: ev_d87065ccd651db25cc6d146026cbc5da2464800d8e7107b0c7e6dab6d1063c1b
// Original Evidence: rea-collector/0x180433d50.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8 FUN_180433d50(void)

{
  ulonglong uVar1;
  
  if (DAT_180d682c8 == '\0') {
    uVar1 = _DAT_180d67e60 + 0x6df70a65e6632e3aU ^ 0xbcd1994011bf48c;
  }
  else {
    uVar1 = FUN_18052c740(&DAT_180d67e60,0);
  }
  if (uVar1 == 0) {
    return _DAT_00000000;
  }
  return *(undefined8 *)(DAT_180d20bd0 + uVar1);
}

