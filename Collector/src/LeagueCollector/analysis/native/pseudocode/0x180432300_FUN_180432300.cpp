// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180432300; descriptive alias: FUN_180432300
// Evidence: ev_1e0b26a793306ce9da1ef17e392fb2b5a79f843a382a55d02003d08aa46f883c
// Original Evidence: rea-collector/0x180432300.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

void FUN_180432300(undefined8 param_1)

{
  if (*(int *)(*(longlong *)((longlong)ThreadLocalStoragePointer + (ulonglong)_tls_index * 8) +
              0x13b8) < DAT_180d72f90) {
    FUN_180977040(&DAT_180d72f90);
    if (DAT_180d72f90 == -1) {
      DAT_180d72f98 = (code *)FUN_1801f3090(&DAT_180d23d30);
      _Init_thread_footer(&DAT_180d72f90);
    }
  }
                    /* WARNING: Could not recover jumptable at 0x00018043233b. Too many branches */
                    /* WARNING: Treating indirect jump as call */
  (*DAT_180d72f98)(param_1);
  return;
}

