// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180424b50; descriptive alias: FUN_180424b50
// Evidence: ev_b82a837a12e813ba729f9ef4e4a30c5bcd38defb83b1ac9516c8b11d9fe4f218
// Original Evidence: rea-collector/0x180424b50.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

int FUN_180424b50(undefined8 param_1)

{
  longlong lVar1;
  float fVar2;
  undefined1 auVar3 [16];
  
  if (*(int *)(*(longlong *)((longlong)ThreadLocalStoragePointer + (ulonglong)_tls_index * 8) +
              0x13b8) < DAT_180d72f4c) {
    FUN_180977040(&DAT_180d72f4c);
    if (DAT_180d72f4c == -1) {
      if (DAT_180d3cd68 == '\0') {
        DAT_180d72f50 = DAT_180d3c900 + 0xe6632e3aU ^ 0x11bf48c;
      }
      else {
        DAT_180d72f50 = FUN_18052b510(&DAT_180d3c900);
      }
      _Init_thread_footer(&DAT_180d72f4c);
    }
  }
  lVar1 = FUN_180432380(param_1);
  auVar3._0_12_ = ZEXT812(0);
  auVar3._12_4_ = 0;
  if ((lVar1 == 0) || (DAT_180d72f50 == 0)) {
    fVar2 = 0.0;
  }
  else {
    fVar2 = *(float *)((ulonglong)DAT_180d72f50 + lVar1);
  }
  if (((((uint)fVar2 & 0x7f800000) != 0x7f800000) && (0.0 < fVar2)) && (fVar2 < 2.1474836e+09)) {
    auVar3 = vroundss_avx(auVar3,ZEXT416((uint)(fVar2 + 1e-05)),1);
    return (int)auVar3._0_4_;
  }
  return 0;
}

