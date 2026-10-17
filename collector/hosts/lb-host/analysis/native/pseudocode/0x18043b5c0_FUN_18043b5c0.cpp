// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x18043b5c0; descriptive alias: FUN_18043b5c0
// Evidence: ev_559292f5dbf6e433932bc824bca8c48b405fc96fb58af5271022fa2dc4c1ca4f
// Original Evidence: rea-collector/0x18043b5c0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined4 * FUN_18043b5c0(undefined4 *param_1,undefined4 *param_2,longlong param_3)

{
  ulonglong uVar1;
  int iVar2;
  int iVar3;
  undefined8 uVar4;
  code *pcVar5;
  longlong lVar6;
  char cVar7;
  uint uVar8;
  undefined4 *puVar9;
  undefined4 *puVar10;
  ulonglong uVar11;
  undefined4 *puVar12;
  int *piVar13;
  ulonglong uVar14;
  longlong *plVar15;
  ulonglong uVar16;
  undefined1 *puVar17;
  longlong lVar18;
  longlong lVar19;
  undefined4 *puVar20;
  ulonglong uVar21;
  undefined8 *puVar22;
  undefined8 extraout_XMM0_Qa;
  undefined8 extraout_XMM0_Qa_00;
  undefined8 extraout_XMM0_Qa_01;
  undefined8 extraout_XMM0_Qa_02;
  undefined8 extraout_XMM0_Qa_03;
  undefined8 extraout_XMM0_Qa_04;
  undefined1 auStack_b8 [8];
  undefined1 auStack_b0 [24];
  longlong local_98;
  longlong local_90;
  undefined4 *local_88;
  undefined8 *local_80;
  longlong local_78;
  undefined1 local_70 [8];
  ulonglong local_68;
  undefined4 *local_60;
  undefined1 local_58 [8];
  ulonglong uStack_50;
  
  puVar17 = auStack_b8;
  stack0xffffffffffffffac = SUB1612((undefined1  [16])0x0,4);
  local_58._0_6_ = 0x73656e6f62;
  if ((param_3 == 0) || ((*(byte *)(param_1 + 0x122) & 4) == 0)) goto LAB_18043bb7e;
  local_88 = param_1;
  local_60 = param_2;
  if (DAT_180d3df28 == '\0') {
    uVar8 = DAT_180d3dac0 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar8 = FUN_18052b510(&DAT_180d3dac0);
  }
  if (uVar8 == 0) {
    lVar18 = 0;
  }
  else {
    if (DAT_180d3df28 == '\0') {
      uVar8 = DAT_180d3dac0 + 0xe6632e3aU ^ 0x11bf48c;
    }
    else {
      uVar8 = FUN_18052b510(&DAT_180d3dac0);
    }
    plVar15 = (longlong *)((ulonglong)uVar8 + param_3);
    cVar7 = FUN_1801fa260(*plVar15);
    if (cVar7 == '\0') {
      FUN_180426850(extraout_XMM0_Qa,plVar15);
      lVar18 = 0;
    }
    else {
      plVar15 = (longlong *)(*plVar15 + ((ulonglong)(DAT_180d3df30 + 0xe6632e3a) ^ 0x11bf48c));
      cVar7 = FUN_1801fa260(*plVar15);
      if (cVar7 == '\0') {
        FUN_180426c00(extraout_XMM0_Qa_00,plVar15);
        lVar18 = 0;
      }
      else {
        plVar15 = (longlong *)(*plVar15 + ((ulonglong)(DAT_180d3df34 + 0xe6632e3a) ^ 0x11bf48c));
        cVar7 = FUN_1801fa260(*plVar15);
        if (cVar7 == '\0') {
          FUN_180426fb0(extraout_XMM0_Qa_01,plVar15);
          lVar18 = 0;
        }
        else {
          lVar18 = *plVar15;
        }
      }
    }
  }
  local_90 = lVar18;
  if (DAT_180d3e3b0 == '\0') {
    uVar8 = DAT_180d3df48 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar8 = FUN_18052b510(&DAT_180d3df48);
  }
  if (uVar8 == 0) {
LAB_18043b7b6:
    lVar19 = 0;
    local_98 = 0;
  }
  else {
    if (DAT_180d3e3b0 == '\0') {
      uVar8 = DAT_180d3df48 + 0xe6632e3aU ^ 0x11bf48c;
    }
    else {
      uVar8 = FUN_18052b510(&DAT_180d3df48);
    }
    lVar19 = *(longlong *)((ulonglong)uVar8 + param_3);
    local_98 = lVar19;
    cVar7 = FUN_1801fa260(lVar19);
    if (cVar7 == '\0') {
      FUN_180427370(extraout_XMM0_Qa_02,&local_98);
      goto LAB_18043b7b6;
    }
    lVar19 = *(longlong *)(((ulonglong)(DAT_180d3e3bc + 0xe6632e3a) ^ 0x11bf48c) + lVar19);
    local_98 = lVar19;
    local_78 = lVar19;
    cVar7 = FUN_1801fa260(lVar19);
    if (cVar7 == '\0') {
      FUN_180427720(extraout_XMM0_Qa_03,&local_78);
      goto LAB_18043b7b6;
    }
  }
  if ((lVar18 == 0) || (lVar19 == 0)) {
LAB_18043bb7e:
    *param_2 = 0;
    return param_2;
  }
  if (DAT_180d3e3b0 == '\0') {
    uVar8 = DAT_180d3df48 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar8 = FUN_18052b510(&DAT_180d3df48);
  }
  uVar8 = *(uint *)(((ulonglong)(DAT_180d3e3c0 + 0xe6632e3a) ^ 0x11bf48c) +
                   *(longlong *)((ulonglong)uVar8 + param_3));
  uVar14 = (ulonglong)uVar8;
  if (uVar8 == 0) {
    puVar10 = (undefined4 *)0x0;
    lVar18 = *(longlong *)(param_1 + 0x120);
    local_98 = 0;
    puVar20 = (undefined4 *)0x0;
  }
  else {
    local_68 = uVar14;
    if (0x3fffffffffffffff < uVar14) {
                    /* WARNING: Subroutine does not return */
      FUN_180183310();
    }
    puVar9 = (undefined4 *)FUN_1801a22d0(uVar14 * 4);
    uVar21 = 0;
    puVar20 = puVar9 + uVar14;
    puVar12 = puVar9;
    do {
      uVar4 = *(undefined8 *)(param_1 + 0x120);
      puVar22 = (undefined8 *)
                (((ulonglong)(DAT_180d3df38 + 0xe6632e3a) ^ 0x11bf48c) +
                local_90 + ((ulonglong)(DAT_180d3df3c + 0xe6632e3a) ^ 0x11bf48c) * uVar21);
      cVar7 = FUN_1801fa260();
      if (cVar7 == '\0') {
        local_80 = puVar22;
        FUN_180427ad0(extraout_XMM0_Qa_04,&local_80);
        local_58 = (undefined1  [8])&DAT_180c0f302;
        uStack_50 = 0;
      }
      else {
        local_58 = (undefined1  [8])*puVar22;
        uStack_50 = (ulonglong)*(uint *)(puVar22 + 1);
      }
      puVar10 = (undefined4 *)FUN_180433ef0(uVar4,local_70,local_58);
      param_1 = local_88;
      local_80 = (undefined8 *)
                 FUN_180435dc0(&local_78,*(undefined8 *)(local_88 + 0x120),*puVar10,
                               lVar19 + uVar21 * 0x28);
      if (puVar9 == puVar20) {
        puVar9 = (undefined4 *)((longlong)puVar9 - (longlong)puVar12);
        if ((longlong)puVar9 >> 2 == 0x3fffffffffffffff) {
                    /* WARNING: Subroutine does not return */
          FUN_180183310();
        }
        uVar14 = ((longlong)puVar9 >> 2) + 1;
        uVar16 = (longlong)puVar20 - (longlong)puVar12 >> 2;
        if (0x3fffffffffffffff - (uVar16 >> 1) < uVar16) {
          uVar11 = 0x3fffffffffffffff;
        }
        else {
          uVar1 = (uVar16 >> 1) + uVar16;
          uVar11 = uVar14;
          if (uVar14 <= uVar1) {
            uVar11 = uVar1;
          }
          if (0x3fffffffffffffff < uVar11) {
                    /* WARNING: Subroutine does not return */
            FUN_1801a22b0();
          }
        }
        puVar10 = (undefined4 *)FUN_1801a22d0(uVar11 * 4);
        *(undefined4 *)((longlong)puVar10 + ((ulonglong)puVar9 & 0xfffffffffffffffc)) =
             *(undefined4 *)local_80;
        FUN_1809bf2f0(puVar10,puVar12,puVar9);
        if (puVar12 != (undefined4 *)0x0) {
          uVar16 = uVar16 * 4;
          if (0xfff < uVar16) {
            puVar20 = (undefined4 *)
                      ((longlong)puVar12 + (-8 - (longlong)*(undefined4 **)(puVar12 + -2)));
            if ((undefined4 *)0x1f < puVar20) goto LAB_18043bb6a;
            uVar16 = uVar16 + 0x27;
            puVar12 = *(undefined4 **)(puVar12 + -2);
          }
          thunk_FUN_180895720(puVar12,uVar16);
        }
        puVar9 = puVar10 + uVar14;
        puVar20 = puVar10 + uVar11;
        param_1 = local_88;
      }
      else {
        *puVar9 = *(undefined4 *)local_80;
        puVar9 = puVar9 + 1;
        puVar10 = puVar12;
      }
      uVar21 = uVar21 + 1;
      puVar12 = puVar10;
      lVar19 = local_98;
    } while (uVar21 < local_68);
    lVar18 = *(longlong *)(param_1 + 0x120);
    local_98 = (longlong)puVar9 - (longlong)puVar10 >> 2;
    local_88 = puVar10;
    if (puVar10 != puVar9) goto LAB_18043ba3d;
  }
  local_88 = (undefined4 *)&DAT_180d6e9ea;
LAB_18043ba3d:
  lVar19 = local_98;
  FUN_1801c3f20(lVar18,local_98,4);
  puVar9 = local_88;
  lVar6 = lVar19;
  while (lVar19 != 0) {
    lVar19 = lVar19 + -1;
    iVar2 = puVar9[lVar19];
    if (*(ulonglong *)(lVar18 + 0x68) < 4) {
      *(undefined8 *)(lVar18 + 0x68) = 4;
    }
    FUN_1801c5360(lVar18,-*(int *)(lVar18 + 0x30) & 3);
    iVar3 = *(int *)(lVar18 + 0x30);
    if (*(ulonglong *)(lVar18 + 0x68) < 4) {
      *(undefined8 *)(lVar18 + 0x68) = 4;
    }
    FUN_1801c5360(lVar18,-iVar3 & 3);
    FUN_1801c5410(lVar18,4);
    piVar13 = (int *)(*(longlong *)(lVar18 + 0x40) + -4);
    *(int **)(lVar18 + 0x40) = piVar13;
    *(int *)(lVar18 + 0x30) = *(int *)(lVar18 + 0x30) + 4;
    *piVar13 = (iVar3 - iVar2) + 4;
    lVar6 = local_98;
  }
  *(undefined1 *)(lVar18 + 0x60) = 0;
  if (*(ulonglong *)(lVar18 + 0x68) < 4) {
    *(undefined8 *)(lVar18 + 0x68) = 4;
  }
  FUN_1801c5360(lVar18,-*(int *)(lVar18 + 0x30) & 3);
  FUN_1801c5410(lVar18,4);
  puVar9 = local_60;
  *(longlong *)(lVar18 + 0x40) = *(longlong *)(lVar18 + 0x40) + -4;
  *(int *)(lVar18 + 0x30) = *(int *)(lVar18 + 0x30) + 4;
  **(undefined4 **)(lVar18 + 0x40) = (int)lVar6;
  *local_60 = *(undefined4 *)(lVar18 + 0x30);
  if (puVar10 == (undefined4 *)0x0) {
    return local_60;
  }
  uVar14 = ((longlong)puVar20 - (longlong)puVar10 >> 2) * 4;
  puVar20 = puVar10;
  if (0xfff < uVar14) {
    puVar20 = (undefined4 *)((longlong)puVar10 + (-8 - *(longlong *)(puVar10 + -2)));
    if (puVar20 < &DAT_00000020) {
      thunk_FUN_180895720(*(longlong *)(puVar10 + -2),uVar14 + 0x27);
      return puVar9;
    }
LAB_18043bb6a:
    pcVar5 = (code *)swi(0x29);
    (*pcVar5)(5);
    puVar17 = auStack_b0;
  }
  *(undefined8 *)(puVar17 + -8) = 0x18043bb79;
  thunk_FUN_180895720(puVar20);
  return puVar9;
}

