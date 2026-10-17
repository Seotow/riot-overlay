// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180421af0; descriptive alias: FUN_180421af0
// Evidence: ev_e685b7d1c88c0b48f2f0d2a831fd2e8d5692addec7d457299beef89598c880d1
// Original Evidence: rea-collector/0x180421af0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8 FUN_180421af0(void)

{
  ulonglong uVar1;
  
  if (DAT_180d29a60 == '\0') {
    uVar1 = _DAT_180d295f8 + 0x6df70a65e6632e3aU ^ 0xbcd1994011bf48c;
  }
  else {
    uVar1 = FUN_18052c740(&DAT_180d295f8,0);
  }
  if (uVar1 == 0) {
    return _DAT_00000000;
  }
  return *(undefined8 *)(DAT_180d20bd0 + uVar1);
}

