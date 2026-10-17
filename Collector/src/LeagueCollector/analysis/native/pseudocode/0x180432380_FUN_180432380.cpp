// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180432380; descriptive alias: FUN_180432380
// Evidence: ev_d87f846304b5b2c942c05ba0bc84e9fc0d428aaaa757e92da51a7cd5c0dc94c5
// Original Evidence: rea-collector/0x180432380.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined8 FUN_180432380(longlong param_1)

{
  longlong lVar1;
  uint uVar2;
  undefined8 uVar3;
  
  lVar1 = *(longlong *)((longlong)ThreadLocalStoragePointer + (ulonglong)_tls_index * 8);
  if (*(int *)(lVar1 + 0x13b8) < DAT_180d72fa0) {
    FUN_180977040(&DAT_180d72fa0);
    if (DAT_180d72fa0 == -1) {
      if (DAT_180d36f78 == '\0') {
        uVar2 = DAT_180d36b10 + 0xe6632e3aU ^ 0x11bf48c;
      }
      else {
        uVar2 = FUN_18052b510(&DAT_180d36b10);
      }
      if (uVar2 == 0) {
        DAT_180d72fa8 = (code *)0x0;
      }
      else {
        DAT_180d72fa8 = (code *)((ulonglong)uVar2 + DAT_180d20bd0);
      }
      _Init_thread_footer(&DAT_180d72fa0);
    }
  }
  if (*(int *)(lVar1 + 0x13b8) < DAT_180d72fb0) {
    FUN_180977040(&DAT_180d72fb0);
    if (DAT_180d72fb0 == -1) {
      if (DAT_180d3c488 == '\0') {
        DAT_180d72fb4 = DAT_180d3c020 + 0xe6632e3aU ^ 0x11bf48c;
      }
      else {
        DAT_180d72fb4 = FUN_18052b510(&DAT_180d3c020);
      }
      _Init_thread_footer(&DAT_180d72fb0);
    }
  }
  if ((DAT_180d72fa8 != (code *)0x0) && (DAT_180d72fb4 != 0)) {
                    /* WARNING: Could not recover jumptable at 0x0001804323ec. Too many branches */
                    /* WARNING: Treating indirect jump as call */
    uVar3 = (*DAT_180d72fa8)((ulonglong)DAT_180d72fb4 + param_1);
    return uVar3;
  }
  return 0;
}

