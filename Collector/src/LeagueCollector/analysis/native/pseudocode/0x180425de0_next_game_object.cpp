// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180425de0; descriptive alias: next_game_object
// Evidence: ev_d0ef06fdae7460745047bd7d0f415e3a4d1fb47f63f62bebf4a194efaef93ca4
// Original Evidence: rea-object-next.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

void FUN_180425de0(undefined8 param_1)

{
  ulonglong uVar1;
  undefined8 *puVar2;
  
  if (*(int *)(*(longlong *)((longlong)ThreadLocalStoragePointer + (ulonglong)_tls_index * 8) +
              0x13b8) < DAT_180d72f70) {
    FUN_180977040(&DAT_180d72f70);
    if (DAT_180d72f70 == -1) {
      puVar2 = (undefined8 *)FUN_1801f3090(&DAT_180d2b520);
      DAT_180d72f78 = *puVar2;
      _Init_thread_footer(&DAT_180d72f70);
    }
  }
  if (DAT_180d2a7b0 == '\0') {
    uVar1 = DAT_180d2a348 + 0x6df70a65e6632e3aU ^ 0xbcd1994011bf48c;
  }
  else {
    uVar1 = FUN_18052c740(&DAT_180d2a348,0);
  }
                    /* WARNING: Could not recover jumptable at 0x000180425e5c. Too many branches */
                    /* WARNING: Treating indirect jump as call */
  (*(code *)(uVar1 + DAT_180d20bd0))(DAT_180d72f78,param_1);
  return;
}

