// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1803e5ef0; descriptive alias: handle_object_address_dump
// Evidence: ev_3eac3a08e9d1cc959ec49211ceb7b08f4b84d0de399599e3b38e2c745a46585a
// Original Evidence: rea-command-four-handler.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */

void FUN_1803e5ef0(undefined8 param_1,longlong param_2,undefined1 (*param_3) [16])

{
  undefined1 (*pauVar1) [16];
  undefined4 uVar2;
  undefined4 uVar3;
  int iVar4;
  int iVar5;
  code *pcVar6;
  uint uVar7;
  undefined4 uVar8;
  undefined1 (*pauVar9) [16];
  longlong lVar10;
  undefined8 uVar11;
  longlong lVar12;
  int *piVar13;
  undefined1 *puVar14;
  undefined *puVar15;
  undefined1 auStack_b8 [8];
  undefined1 auStack_b0 [24];
  undefined1 (*local_98) [16];
  undefined1 (*local_88) [16];
  undefined1 (*local_80) [16];
  undefined1 (*local_78) [16];
  undefined1 local_70 [16];
  undefined1 local_60 [16];
  longlong local_50;
  ulonglong local_48;
  
  puVar14 = auStack_b8;
  local_48 = DAT_180d06cc0 ^ (ulonglong)auStack_b8;
  local_80 = param_3;
  if ((*(uint *)(param_2 + 0x130) & 0x200) == 0) {
    FUN_1803da020(param_2,param_3);
    puVar14 = auStack_b8;
  }
  else {
    pauVar9 = (undefined1 (*) [16])FUN_180976d80(0x98);
    *pauVar9 = (undefined1  [16])0x0;
    *(undefined4 *)(*pauVar9 + 8) = 1;
    *(undefined4 *)(*pauVar9 + 0xc) = 1;
    *(undefined ***)*pauVar9 = &PTR_FUN_180c5c310;
    pauVar1 = pauVar9 + 1;
    *(undefined8 *)*pauVar1 = 0;
    pauVar9[1][8] = 0;
    *(undefined8 *)pauVar9[2] = 0x10000;
    *(undefined4 *)(pauVar9[2] + 8) = 0x7fffffff;
    *(undefined8 *)pauVar9[3] = 8;
    *(undefined8 *)(pauVar9[3] + 8) = 0;
    *(undefined4 *)pauVar9[4] = 0;
    *(undefined8 *)(pauVar9[4] + 8) = 0;
    *(undefined8 *)pauVar9[5] = 0;
    *(undefined8 *)(pauVar9[5] + 8) = 0;
    *(undefined4 *)pauVar9[6] = 0;
    *(undefined2 *)(pauVar9[6] + 4) = 0;
    *(undefined8 *)(pauVar9[6] + 8) = 0;
    *(undefined2 *)pauVar9[7] = 0;
    *(undefined8 *)(pauVar9[7] + 8) = 1;
    *(undefined2 *)pauVar9[8] = 0x100;
    *(undefined8 *)(pauVar9[8] + 8) = 0;
    *(undefined8 *)pauVar9[9] = 0;
    local_70._8_8_ = pauVar9;
    local_70._0_8_ = pauVar1;
    local_60 = (undefined1  [16])0x0;
    local_50 = 0;
    local_88 = pauVar9;
    for (lVar10 = FUN_180425d20(); lVar10 != 0; lVar10 = FUN_180425de0(lVar10)) {
      uVar11 = FUN_180431510(lVar10);
      if ((DAT_180d21528 - DAT_180d21520 >> 3 != 0) &&
         (lVar12 = thunk_FUN_1809700d0(DAT_180d21520,DAT_180d21528,uVar11), lVar12 == DAT_180d21528)
         ) {
        uVar11 = 0;
      }
      if (DAT_180d2d428 == '\0') {
        uVar7 = DAT_180d2cfc0 + 0xe6632e3aU ^ 0x11bf48c;
      }
      else {
        uVar7 = FUN_18052b510(&DAT_180d2cfc0);
      }
      uVar8 = *(undefined4 *)(lVar10 + (ulonglong)uVar7);
      if (DAT_180d2e5e8 == '\0') {
        uVar7 = DAT_180d2e180 + 0xe6632e3aU ^ 0x11bf48c;
      }
      else {
        uVar7 = FUN_18052b510(&DAT_180d2e180);
      }
      uVar2 = *(undefined4 *)(lVar10 + (ulonglong)uVar7);
      pauVar9[7][0] = 1;
      uVar3 = *(undefined4 *)pauVar9[4];
      FUN_1801bd6b0(pauVar1,10,lVar10);
      FUN_1801bd6b0(pauVar1,8,uVar11);
      FUN_1801bd800(pauVar1,6,uVar8,0);
      FUN_1801bd800(pauVar1,4,uVar2);
      uVar8 = FUN_1801be990(pauVar1,uVar3);
      local_88 = (undefined1 (*) [16])CONCAT44(local_88._4_4_,uVar8);
      FUN_1801c3a50(local_60,&local_88);
    }
    lVar10 = (longlong)(local_60._8_8_ - local_60._0_8_) >> 2;
    puVar15 = &DAT_180d6e975;
    if (local_60._0_8_ != local_60._8_8_) {
      puVar15 = (undefined *)local_60._0_8_;
    }
    FUN_1801c3f20(pauVar1,lVar10,4);
    lVar12 = lVar10;
    while (lVar12 != 0) {
      lVar12 = lVar12 + -1;
      iVar4 = *(int *)(puVar15 + lVar12 * 4);
      if (*(ulonglong *)(pauVar9[7] + 8) < 4) {
        *(undefined8 *)(pauVar9[7] + 8) = 4;
      }
      FUN_1801c5360(pauVar1,-*(int *)pauVar9[4] & 3);
      iVar5 = *(int *)pauVar9[4];
      if (*(ulonglong *)(pauVar9[7] + 8) < 4) {
        *(undefined8 *)(pauVar9[7] + 8) = 4;
      }
      FUN_1801c5360(pauVar1,-iVar5 & 3);
      FUN_1801c5410(pauVar1,4);
      piVar13 = (int *)(*(longlong *)pauVar9[5] + -4);
      *(int **)pauVar9[5] = piVar13;
      *(int *)pauVar9[4] = *(int *)pauVar9[4] + 4;
      *piVar13 = (iVar5 - iVar4) + 4;
    }
    pauVar9[7][0] = 0;
    if (*(ulonglong *)(pauVar9[7] + 8) < 4) {
      *(undefined8 *)(pauVar9[7] + 8) = 4;
    }
    FUN_1801c5360(pauVar1,-*(int *)pauVar9[4] & 3);
    FUN_1801c5410(pauVar1,4);
    *(longlong *)pauVar9[5] = *(longlong *)pauVar9[5] + -4;
    *(int *)pauVar9[4] = *(int *)pauVar9[4] + 4;
    **(undefined4 **)pauVar9[5] = (int)lVar10;
    iVar4 = *(int *)pauVar9[4];
    pauVar9[7][0] = 1;
    if (iVar4 != 0) {
      if (*(ulonglong *)(pauVar9[7] + 8) < 4) {
        *(undefined8 *)(pauVar9[7] + 8) = 4;
      }
      FUN_1801c5360(pauVar1,-iVar4 & 3);
      FUN_1801bd800(pauVar1,4,(*(int *)pauVar9[4] - iVar4) + 4,0);
    }
    uVar8 = FUN_1801be990(pauVar1,iVar4);
    local_98 = local_80;
    FUN_1801b3ec0(&local_88,pauVar1,0x10,uVar8);
    FUN_1801c3db0(pauVar1,(ulonglong)local_88 & 0xffffffff);
    local_70 = (undefined1  [16])0x0;
    local_80 = pauVar1;
    local_78 = pauVar9;
    FUN_1803bd970(param_2,&local_80,0);
    if (local_60._0_8_ != 0) {
      lVar10 = local_60._0_8_;
      puVar14 = auStack_b8;
      if ((0xfff < (ulonglong)((local_50 - local_60._0_8_ >> 2) * 4)) &&
         (lVar10 = *(longlong *)(local_60._0_8_ + -8), puVar14 = auStack_b8,
         0x1f < (local_60._0_8_ - lVar10) - 8U)) {
        lVar10 = 5;
        pcVar6 = (code *)swi(0x29);
        (*pcVar6)(5);
        puVar14 = auStack_b0;
      }
      *(undefined8 *)(puVar14 + -8) = 0x1803e6301;
      thunk_FUN_180895720(lVar10);
    }
  }
  *(undefined8 *)(puVar14 + -8) = 0x1803e630f;
  return;
}

