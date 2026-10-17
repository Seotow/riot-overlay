// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180420d50; descriptive alias: FUN_180420d50
// Evidence: ev_7cd3902d477befa1ed64d6c7d72c22352f2034faeba7d6598feb0d710dbbfe77
// Original Evidence: rea-collector/0x180420d50.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void FUN_180420d50(longlong param_1,undefined4 param_2)

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
      *(undefined4 *)((ulonglong)((int)_DAT_180d5e308 + 0xe6632e3aU ^ 0x11bf48c) + param_1) =
           param_2;
      return;
    }
    uVar1 = FUN_18052b510(&DAT_180d5e308);
    *(undefined4 *)((ulonglong)uVar1 + param_1) = param_2;
  }
  return;
}

