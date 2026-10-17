// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180420df0; descriptive alias: FUN_180420df0
// Evidence: ev_43d0b847fe5880e69d0fddb12d044fd0b7ea7bb7982d27e83583239c30d29beb
// Original Evidence: rea-collector/0x180420df0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8 FUN_180420df0(void)

{
  uint uVar1;
  
  if (DAT_180d56240 == '\0') {
    uVar1 = DAT_180d55dd8 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar1 = FUN_18052b510(&DAT_180d55dd8);
  }
  if (uVar1 == 0) {
    return _DAT_00000000;
  }
  return *(undefined8 *)((ulonglong)uVar1 + DAT_180d20bd0);
}

