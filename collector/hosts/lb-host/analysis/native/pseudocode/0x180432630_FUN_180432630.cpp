// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180432630; descriptive alias: FUN_180432630
// Evidence: ev_f63f9383cc04c29a3803b677bc2653cc411d7c67ecffd8e511106b61a04762fb
// Original Evidence: rea-collector/0x180432630.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined4 FUN_180432630(undefined8 param_1)

{
  uint uVar1;
  longlong lVar2;
  ulonglong uVar3;
  
  if (*(int *)(*(longlong *)((longlong)ThreadLocalStoragePointer + (ulonglong)_tls_index * 8) +
              0x13b8) < DAT_180d72f3c) {
    FUN_180977040(&DAT_180d72f3c);
    if (DAT_180d72f3c == -1) {
      if (DAT_180d3d648 == '\0') {
        DAT_180d72f40 = DAT_180d3d1e0 + 0xe6632e3aU ^ 0x11bf48c;
      }
      else {
        DAT_180d72f40 = FUN_18052b510(&DAT_180d3d1e0);
      }
      _Init_thread_footer(&DAT_180d72f3c);
    }
  }
  uVar1 = DAT_180d72f40;
  uVar3 = (ulonglong)DAT_180d72f40;
  lVar2 = FUN_180432380(param_1);
  if ((lVar2 != 0) && (uVar1 != 0)) {
    return *(undefined4 *)(uVar3 + lVar2);
  }
  return 0;
}

