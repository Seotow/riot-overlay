// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1804263a0; descriptive alias: FUN_1804263a0
// Evidence: ev_10545b65ce445ec837c44e83909d411680c8fece247a8db6b75a003ae4d0f652
// Original Evidence: rea-collector/0x1804263a0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined4 FUN_1804263a0(void)

{
  ulonglong uVar1;
  
  if (DAT_180d22288 == '\0') {
    uVar1 = _DAT_180d21e20 + 0x6df70a65e6632e3aU ^ 0xbcd1994011bf48c;
  }
  else {
    uVar1 = FUN_18052c740(&DAT_180d21e20,0);
  }
  if (uVar1 == 0) {
    return _DAT_00000000;
  }
  return *(undefined4 *)(DAT_180d20bd0 + uVar1);
}

