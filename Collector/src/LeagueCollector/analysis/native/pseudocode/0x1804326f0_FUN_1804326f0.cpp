// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1804326f0; descriptive alias: FUN_1804326f0
// Evidence: ev_4758cf787a22706e29e7e88163b4a38f46bda6f6e8f34aea1020c5cf65d7697d
// Original Evidence: rea-collector/0x1804326f0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined4 FUN_1804326f0(undefined8 param_1)

{
  uint uVar1;
  longlong lVar2;
  ulonglong uVar3;
  
  if (*(int *)(*(longlong *)((longlong)ThreadLocalStoragePointer + (ulonglong)_tls_index * 8) +
              0x13b8) < DAT_180d72f44) {
    FUN_180977040(&DAT_180d72f44);
    if (DAT_180d72f44 == -1) {
      if (DAT_180d3dab8 == '\0') {
        DAT_180d72f48 = DAT_180d3d650 + 0xe6632e3aU ^ 0x11bf48c;
      }
      else {
        DAT_180d72f48 = FUN_18052b510(&DAT_180d3d650);
      }
      _Init_thread_footer(&DAT_180d72f44);
    }
  }
  uVar1 = DAT_180d72f48;
  uVar3 = (ulonglong)DAT_180d72f48;
  lVar2 = FUN_180432380(param_1);
  if ((lVar2 != 0) && (uVar1 != 0)) {
    return *(undefined4 *)(uVar3 + lVar2);
  }
  return 0;
}

