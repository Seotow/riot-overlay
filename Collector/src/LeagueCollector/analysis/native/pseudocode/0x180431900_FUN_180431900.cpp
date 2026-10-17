// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180431900; descriptive alias: FUN_180431900
// Evidence: ev_4abfd8db65cf90dee93d37bea4486e906eef8f9911fe37ed4c3b33f4b4b9cbe2
// Original Evidence: rea-collector/0x180431900.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

byte FUN_180431900(longlong param_1)

{
  byte bVar1;
  byte bVar2;
  char cVar3;
  uint uVar4;
  longlong lVar5;
  
  bVar2 = FUN_180431a20();
  if (DAT_180d2d898 == '\0') {
    uVar4 = DAT_180d2d430 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar4 = FUN_18052b510(&DAT_180d2d430);
  }
  cVar3 = FUN_180432830((ulonglong)uVar4 + param_1);
  if (cVar3 != '\0') {
    bVar2 = bVar2 | 2;
  }
  lVar5 = FUN_180431510(param_1);
  bVar1 = bVar2;
  if (lVar5 == 0xe260302c) {
    cVar3 = FUN_180431fa0(param_1);
    bVar1 = bVar2 | 4;
    if (cVar3 == '\0') {
      bVar1 = bVar2;
    }
  }
  if (DAT_180d2fc18 == '\0') {
    uVar4 = DAT_180d2f7b0 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar4 = FUN_18052b510(&DAT_180d2f7b0);
  }
  bVar2 = bVar1 | 8;
  if (*(char *)((ulonglong)uVar4 + param_1) == '\0') {
    bVar2 = bVar1;
  }
  return bVar2;
}

