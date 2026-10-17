// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180424c40; descriptive alias: FUN_180424c40
// Evidence: ev_ae1c3128963ee1c37d038f74dbd8676445d39224eccc3348fa9644eb0875ce58
// Original Evidence: rea-collector/0x180424c40.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined8 FUN_180424c40(undefined8 param_1)

{
  undefined1 auVar1 [12];
  uint uVar2;
  
  if (*(int *)(*(longlong *)((longlong)ThreadLocalStoragePointer + (ulonglong)_tls_index * 8) +
              0x13b8) < DAT_180d72f54) {
    FUN_180977040(&DAT_180d72f54);
    if (DAT_180d72f54 == -1) {
      DAT_180d72f58 = (code *)FUN_1801f3090(&DAT_180d3c490);
      _Init_thread_footer(&DAT_180d72f54);
    }
  }
  if (DAT_180d72f58 != (code *)0x0) {
    uVar2 = (*DAT_180d72f58)(param_1);
    auVar1._4_8_ = SUB128(ZEXT812(0),4);
    auVar1._0_4_ = (float)uVar2;
    return auVar1._0_8_;
  }
  return 0;
}

