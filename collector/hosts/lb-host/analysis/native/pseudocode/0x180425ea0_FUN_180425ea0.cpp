// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180425ea0; descriptive alias: FUN_180425ea0
// Evidence: ev_b0efde68f091c60c6a437073691a410a610678ebc86f9aea765a747aa36250fa
// Original Evidence: rea-collector/0x180425ea0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

void FUN_180425ea0(undefined4 param_1)

{
  ulonglong uVar1;
  undefined8 *puVar2;
  
  if (*(int *)(*(longlong *)((longlong)ThreadLocalStoragePointer + (ulonglong)_tls_index * 8) +
              0x13b8) < DAT_180d72f80) {
    FUN_180977040(&DAT_180d72f80);
    if (DAT_180d72f80 == -1) {
      puVar2 = (undefined8 *)FUN_1801f3090(&DAT_180d2b520);
      DAT_180d72f88 = *puVar2;
      _Init_thread_footer(&DAT_180d72f80);
    }
  }
  if (DAT_180d2ac20 == '\0') {
    uVar1 = DAT_180d2a7b8 + 0x6df70a65e6632e3aU ^ 0xbcd1994011bf48c;
  }
  else {
    uVar1 = FUN_18052c740(&DAT_180d2a7b8,0);
  }
                    /* WARNING: Could not recover jumptable at 0x000180425f1a. Too many branches */
                    /* WARNING: Treating indirect jump as call */
  (*(code *)(uVar1 + DAT_180d20bd0))(DAT_180d72f88,param_1);
  return;
}

