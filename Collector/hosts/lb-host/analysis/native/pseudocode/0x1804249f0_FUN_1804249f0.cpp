// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1804249f0; descriptive alias: FUN_1804249f0
// Evidence: ev_5bb939fe04f66c767b420393e0a5589d7e75665023b150ee1d43116e8874f85b
// Original Evidence: rea-collector/0x1804249f0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void FUN_1804249f0(void)

{
  int iVar1;
  
  iVar1 = FUN_180973810(&DAT_180d0f9b0);
  if (iVar1 != 0) {
                    /* WARNING: Subroutine does not return */
    FUN_1809737c0(5);
  }
  if (DAT_180d0f9fc != 0x7fffffff) {
    _DAT_180d0fa80 = 0;
    FUN_180973930(&DAT_180d0f9b0);
    return;
  }
  DAT_180d0f9fc = 0x7ffffffe;
                    /* WARNING: Subroutine does not return */
  FUN_1809737c0(6);
}

