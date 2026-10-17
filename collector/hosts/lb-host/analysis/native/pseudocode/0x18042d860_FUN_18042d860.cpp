// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x18042d860; descriptive alias: FUN_18042d860
// Evidence: ev_a6f3576d10be24db03cee9f67281b257c9cfa60d68ebeab03a8ae37a0f371e45
// Original Evidence: rea-collector/0x18042d860.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

void FUN_18042d860(void)

{
  if (DAT_180d6e8d8 != (HANDLE)0x0) {
    ReleaseMutex(DAT_180d6e8d8);
    CloseHandle(DAT_180d6e8d8);
    DAT_180d6e8d8 = (HANDLE)0x0;
  }
  return;
}

