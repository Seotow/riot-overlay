// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x18042d8a0; descriptive alias: FUN_18042d8a0
// Evidence: ev_f7eac64d3aca12360802b99338d9516395f922e0ba3ffc42bc1a10648b450308
// Original Evidence: rea-collector/0x18042d8a0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

void FUN_18042d8a0(HMODULE param_1)

{
  if (DAT_180d6e920 != '\0') {
    FUN_18042eaa0();
    return;
  }
  FUN_18042d790();
  FUN_18042d860();
  Ordinal_116();
                    /* WARNING: Subroutine does not return */
  FreeLibraryAndExitThread(param_1,0);
}

