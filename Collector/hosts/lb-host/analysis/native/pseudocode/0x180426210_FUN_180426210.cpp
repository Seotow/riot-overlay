// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180426210; descriptive alias: FUN_180426210
// Evidence: ev_9ff2b543a02cce28c15f7d20b779b94b9f91384b793c382c50e53ae3ae123344
// Original Evidence: rea-collector/0x180426210.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

void FUN_180426210(undefined8 param_1,undefined8 *param_2)

{
  ulonglong uVar1;
  longlong lVar2;
  ulonglong uVar3;
  longlong lVar4;
  undefined8 *puVar5;
  ulonglong uVar6;
  ulonglong uVar7;
  longlong lVar8;
  
  puVar5 = DAT_180d6e8c8;
  if (DAT_180d6e8c8 != DAT_180d6e8d0) {
    *DAT_180d6e8c8 = *param_2;
    DAT_180d6e8c8 = DAT_180d6e8c8 + 1;
    return;
  }
  uVar6 = (longlong)DAT_180d6e8c8 - (longlong)DAT_180d6e8c0;
  uVar7 = 0x1fffffffffffffff;
  lVar2 = (longlong)uVar6 >> 3;
  if (lVar2 == 0x1fffffffffffffff) {
                    /* WARNING: Subroutine does not return */
    FUN_180183310();
  }
  uVar3 = (longlong)DAT_180d6e8d0 - (longlong)DAT_180d6e8c0 >> 3;
  uVar1 = lVar2 + 1;
  if (uVar3 <= 0x1fffffffffffffff - (uVar3 >> 1)) {
    uVar3 = (uVar3 >> 1) + uVar3;
    uVar7 = uVar1;
    if (uVar1 <= uVar3) {
      uVar7 = uVar3;
    }
    if (0x1fffffffffffffff < uVar7) {
                    /* WARNING: Subroutine does not return */
      FUN_1801a22b0();
    }
  }
  lVar2 = FUN_1801a22d0(uVar7 * 8);
  uVar6 = uVar6 & 0xfffffffffffffff8;
  *(undefined8 *)(uVar6 + lVar2) = *param_2;
  if (puVar5 == DAT_180d6e8c8) {
    lVar8 = (longlong)DAT_180d6e8c8 - (longlong)DAT_180d6e8c0;
    lVar4 = lVar2;
    puVar5 = DAT_180d6e8c0;
  }
  else {
    FUN_1809bf2f0(lVar2,DAT_180d6e8c0,(longlong)puVar5 - (longlong)DAT_180d6e8c0);
    lVar8 = (longlong)DAT_180d6e8c8 - (longlong)puVar5;
    lVar4 = uVar6 + 8 + lVar2;
  }
  FUN_1809bf2f0(lVar4,puVar5,lVar8);
  FUN_1801ada70(&DAT_180d6e8c0,lVar2,uVar1,uVar7);
  return;
}

