// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180425d20; descriptive alias: first_game_object
// Evidence: ev_e05761d5371165756530d6395433319a06ef7f4c825131efd2c77dfca1a40b9b
// Original Evidence: rea-object-first.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

void FUN_180425d20(void)

{
  ulonglong uVar1;
  undefined8 *puVar2;
  
  if (*(int *)(*(longlong *)((longlong)ThreadLocalStoragePointer + (ulonglong)_tls_index * 8) +
              0x13b8) < DAT_180d72f60) {
    FUN_180977040(&DAT_180d72f60);
    if (DAT_180d72f60 == -1) {
      puVar2 = (undefined8 *)FUN_1801f3090(&DAT_180d2b520);
      DAT_180d72f68 = *puVar2;
      _Init_thread_footer(&DAT_180d72f60);
    }
  }
  if (DAT_180d2a340 == '\0') {
    uVar1 = DAT_180d29ed8 + 0x6df70a65e6632e3aU ^ 0xbcd1994011bf48c;
  }
  else {
    uVar1 = FUN_18052c740(&DAT_180d29ed8,0);
  }
                    /* WARNING: Could not recover jumptable at 0x000180425d93. Too many branches */
                    /* WARNING: Treating indirect jump as call */
  (*(code *)(uVar1 + DAT_180d20bd0))(DAT_180d72f68);
  return;
}

