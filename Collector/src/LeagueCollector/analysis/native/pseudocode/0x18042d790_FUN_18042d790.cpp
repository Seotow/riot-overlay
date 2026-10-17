// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x18042d790; descriptive alias: FUN_18042d790
// Evidence: ev_1a753acc40f1b061bee70b24fd9d519aca9c801ad8811f269a4b6f8f0942c515
// Original Evidence: rea-collector/0x18042d790.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

void FUN_18042d790(void)

{
  undefined8 *puVar1;
  
  if (DAT_180d6e9d4 != '\0') {
    SetUnhandledExceptionFilter(DAT_180d6e9b0);
    DAT_180d6e9d4 = '\0';
  }
  if (DAT_180d6e9a8 != (LPCVOID)0x0) {
    UnmapViewOfFile(DAT_180d6e9a8);
    DAT_180d6e9a8 = (LPCVOID)0x0;
  }
  if (DAT_180d6e9c8 != (HANDLE)0x0) {
    CloseHandle(DAT_180d6e9c8);
    DAT_180d6e9c8 = (HANDLE)0x0;
  }
  if (DAT_180d6e9c0 != (HANDLE)0x0) {
    SetEvent(DAT_180d6e9c0);
    CloseHandle(DAT_180d6e9c0);
    DAT_180d6e9c0 = (HANDLE)0x0;
  }
  if (DAT_180d6e9a0 != (HMODULE)0x0) {
    FreeLibrary(DAT_180d6e9a0);
    DAT_180d6e9a0 = (HMODULE)0x0;
  }
  DAT_180d11ec0 = 0;
  puVar1 = &DAT_180d11eb0;
  if (0xf < DAT_180d11ec8) {
    puVar1 = DAT_180d11eb0;
  }
  DAT_180d6e9b8 = 0;
  DAT_180d6e9b0 = (LPTOP_LEVEL_EXCEPTION_FILTER)0x0;
  *(undefined1 *)puVar1 = 0;
  return;
}

