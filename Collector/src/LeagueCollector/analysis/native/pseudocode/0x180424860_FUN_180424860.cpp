// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180424860; descriptive alias: FUN_180424860
// Evidence: ev_18816b20124b316280b492cf22f749749dd6719e8dc2ca39e93143ba74f516c2
// Original Evidence: rea-collector/0x180424860.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8 FUN_180424860(void)

{
  uint uVar1;
  
  if (DAT_180d469a0 == '\0') {
    uVar1 = DAT_180d46538 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar1 = FUN_18052b510(&DAT_180d46538);
  }
  if (uVar1 == 0) {
    return _DAT_00000000;
  }
  return *(undefined8 *)((ulonglong)uVar1 + DAT_180d20bd0);
}

