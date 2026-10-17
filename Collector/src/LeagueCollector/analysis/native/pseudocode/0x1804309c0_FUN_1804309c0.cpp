// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1804309c0; descriptive alias: FUN_1804309c0
// Evidence: ev_69b34888df52d017de1ba8519b68987dee1de1e830af3974fef8b4043bf4ef53
// Original Evidence: rea-collector/0x1804309c0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

ulonglong FUN_1804309c0(undefined8 param_1,longlong param_2)

{
  uint uVar1;
  int iVar2;
  longlong lVar3;
  longlong lVar4;
  uint uVar5;
  longlong *plVar6;
  ulonglong uVar7;
  
  if (DAT_180d2bdf8 == '\0') {
    uVar7 = DAT_180d2b990 + 0x6df70a65e6632e3aU ^ 0xbcd1994011bf48c;
  }
  else {
    uVar7 = FUN_18052c740(&DAT_180d2b990,0);
  }
  if (uVar7 == 0) {
    plVar6 = (longlong *)0x0;
  }
  else {
    plVar6 = (longlong *)(DAT_180d20bd0 + uVar7);
  }
  uVar1 = *(uint *)(*plVar6 + 0x10);
  if (uVar1 != 0) {
    if (0xff < uVar1) {
      FUN_180430e70();
      return 0xff;
    }
    uVar7 = 0;
    lVar3 = *(longlong *)(*plVar6 + 8);
    if (uVar1 != 0) {
      do {
        lVar4 = *(longlong *)(lVar3 + uVar7 * 8);
        if (DAT_180d2e5e8 == '\0') {
          uVar5 = DAT_180d2e180 + 0xe6632e3aU ^ 0x11bf48c;
        }
        else {
          uVar5 = FUN_18052b510(&DAT_180d2e180);
        }
        iVar2 = *(int *)(lVar4 + (ulonglong)uVar5);
        if (DAT_180d2e5e8 == '\0') {
          uVar5 = DAT_180d2e180 + 0xe6632e3aU ^ 0x11bf48c;
        }
        else {
          uVar5 = FUN_18052b510(&DAT_180d2e180);
        }
        if (iVar2 == *(int *)(param_2 + (ulonglong)uVar5)) {
          return uVar7 & 0xff;
        }
        uVar7 = uVar7 + 1;
      } while (uVar7 < (ulonglong)(longlong)(int)uVar1);
    }
    return 0xff;
  }
  FUN_180430b10();
  return 0xff;
}

