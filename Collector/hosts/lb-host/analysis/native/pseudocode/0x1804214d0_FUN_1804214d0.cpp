// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1804214d0; descriptive alias: FUN_1804214d0
// Evidence: ev_8576987a67f08242564f7e50297500deb62abbc10ffd2ea8df373575452bed74
// Original Evidence: rea-collector/0x1804214d0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8 FUN_1804214d0(void)

{
  ulonglong uVar1;
  
  if ((char)DAT_180d28428 == '\0') {
    uVar1 = DAT_180d27fc0 + 0x6df70a65e6632e3aU ^ 0xbcd1994011bf48c;
  }
  else {
    uVar1 = FUN_18052c740(&DAT_180d27fc0,0);
  }
  if (uVar1 == 0) {
    return 0;
  }
  if ((char)DAT_180d28428 == '\0') {
    uVar1 = DAT_180d27fc0 + 0x6df70a65e6632e3aU ^ 0xbcd1994011bf48c;
  }
  else {
    uVar1 = FUN_18052c740(&DAT_180d27fc0,0);
  }
  if (uVar1 == 0) {
    return _DAT_00000000;
  }
  return *(undefined8 *)(DAT_180d20bd0 + uVar1);
}

