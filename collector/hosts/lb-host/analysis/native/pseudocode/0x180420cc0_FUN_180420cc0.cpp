// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180420cc0; descriptive alias: FUN_180420cc0
// Evidence: ev_58e9fb233f9666a14df58f67613426500529c4ebc316b22401bd7cfa4ff44017
// Original Evidence: rea-collector/0x180420cc0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined4 FUN_180420cc0(longlong param_1)

{
  uint uVar1;
  
  if ((char)_DAT_180d5e770 == '\0') {
    uVar1 = (int)_DAT_180d5e308 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar1 = FUN_18052b510(&DAT_180d5e308);
  }
  if (uVar1 != 0) {
    if ((char)_DAT_180d5e770 == '\0') {
      return *(undefined4 *)((ulonglong)((int)_DAT_180d5e308 + 0xe6632e3aU ^ 0x11bf48c) + param_1);
    }
    uVar1 = FUN_18052b510(&DAT_180d5e308);
    return *(undefined4 *)((ulonglong)uVar1 + param_1);
  }
  return 0;
}

