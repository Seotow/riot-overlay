// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180432570; descriptive alias: FUN_180432570
// Evidence: ev_2d071e36810922379f32529cca134a8b5ff424adcb64cc2f570692773b2dbbcf
// Original Evidence: rea-collector/0x180432570.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined4 FUN_180432570(undefined8 param_1)

{
  uint uVar1;
  longlong lVar2;
  ulonglong uVar3;
  
  if (*(int *)(*(longlong *)((longlong)ThreadLocalStoragePointer + (ulonglong)_tls_index * 8) +
              0x13b8) < DAT_180d72f34) {
    FUN_180977040(&DAT_180d72f34);
    if (DAT_180d72f34 == -1) {
      if (DAT_180d3d1d8 == '\0') {
        DAT_180d72f38 = DAT_180d3cd70 + 0xe6632e3aU ^ 0x11bf48c;
      }
      else {
        DAT_180d72f38 = FUN_18052b510(&DAT_180d3cd70);
      }
      _Init_thread_footer(&DAT_180d72f34);
    }
  }
  uVar1 = DAT_180d72f38;
  uVar3 = (ulonglong)DAT_180d72f38;
  lVar2 = FUN_180432380(param_1);
  if ((lVar2 != 0) && (uVar1 != 0)) {
    return *(undefined4 *)(uVar3 + lVar2);
  }
  return 0;
}

