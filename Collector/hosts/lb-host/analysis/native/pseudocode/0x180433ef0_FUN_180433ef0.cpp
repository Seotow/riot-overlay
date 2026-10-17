// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180433ef0; descriptive alias: FUN_180433ef0
// Evidence: ev_22e99d46c61346f14d8889d7c5c9e36df7bbfb87d843ed18ba3fae79ba5c1904
// Original Evidence: rea-collector/0x180433ef0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

uint * FUN_180433ef0(longlong param_1,uint *param_2,undefined8 *param_3)

{
  ulonglong *puVar1;
  uint uVar2;
  longlong *plVar3;
  int iVar4;
  longlong *plVar5;
  longlong lVar6;
  ulonglong uVar7;
  ulonglong *puVar8;
  ulonglong *puVar9;
  uint *puVar10;
  ulonglong uVar11;
  longlong lVar12;
  ulonglong uVar13;
  uint *puVar14;
  ulonglong uVar15;
  undefined1 auVar16 [16];
  undefined1 auVar17 [16];
  undefined1 auVar18 [16];
  float fVar19;
  undefined1 auVar20 [16];
  undefined1 auVar21 [16];
  undefined1 auVar22 [16];
  float fVar23;
  uint local_78 [2];
  longlong *local_70;
  longlong lStack_68;
  ulonglong *local_60;
  ulonglong *local_58;
  undefined4 local_4c;
  
  fVar23 = 9.223372e+18;
  if (*(longlong *)(param_1 + 0x80) == 0) {
    plVar5 = (longlong *)FUN_180976d80(0x50);
    *plVar5 = 0;
    plVar5[1] = 0;
    plVar5[2] = 0;
    plVar5[3] = 0;
    plVar5[4] = 0;
    plVar5[5] = 0;
    plVar5[6] = 0;
    plVar5[7] = 0;
    plVar5[6] = 0;
    plVar5[7] = 0;
    plVar5[8] = 0;
    plVar5[9] = 0;
    *plVar5 = param_1;
    plVar5[1] = param_1;
    *(undefined4 *)(plVar5 + 2) = 0;
    *(undefined4 *)((longlong)plVar5 + 0x14) = local_4c;
    plVar5[3] = 0;
    plVar5[4] = 0;
    local_70 = plVar5;
    lVar6 = FUN_180976d80(0x18);
    *(longlong *)lVar6 = lVar6;
    *(longlong *)(lVar6 + 8) = lVar6;
    plVar5[3] = lVar6;
    plVar5[5] = 0;
    plVar5[6] = 0;
    plVar5[7] = 0;
    plVar5[8] = 7;
    plVar5[9] = 8;
    *(undefined4 *)(plVar5 + 2) = 0x3f800000;
    FUN_1801ab260(plVar5 + 5,0x10,plVar5[3]);
    uVar13 = plVar5[4];
    if ((longlong)uVar13 < 0) {
      auVar16 = ZEXT416((uint)(float)uVar13);
    }
    else {
      auVar16._0_4_ = (float)(longlong)uVar13;
      auVar16._4_8_ = SUB128(ZEXT812(0),4);
      auVar16._12_4_ = 0;
    }
    auVar17._0_4_ = auVar16._0_4_ / *(float *)(plVar5 + 2);
    auVar17._4_12_ = auVar16._4_12_;
    auVar20._0_12_ = ZEXT812(0);
    auVar20._12_4_ = 0;
    auVar16 = vroundss_avx(auVar20,auVar17,2);
    fVar19 = auVar16._0_4_;
    lVar6 = 0;
    if ((fVar23 <= fVar19) && (fVar19 = fVar19 - fVar23, fVar19 < fVar23)) {
      lVar6 = -0x8000000000000000;
    }
    uVar13 = (longlong)fVar19 + lVar6;
    if (uVar13 < 0x20) {
      uVar13 = 0x20;
    }
    if ((ulonglong)plVar5[9] < uVar13) {
      FUN_1804347d0(plVar5);
    }
    lVar6 = *(longlong *)(param_1 + 0x80);
    *(longlong **)(param_1 + 0x80) = plVar5;
    if (lVar6 != 0) {
      FUN_1801ad9b0(lVar6 + 0x28);
      FUN_1801c5db0(lVar6 + 0x18);
      thunk_FUN_180895720(lVar6,0x50);
    }
  }
  local_70 = (longlong *)CONCAT44(local_70._4_4_,*(undefined4 *)(param_1 + 0x30));
  FUN_1801bec10(param_1,local_78,*param_3,param_3[1]);
  lVar6 = *(longlong *)(param_1 + 0x80);
  uVar7 = FUN_180434320(lVar6,local_78);
  uVar7 = uVar7 & *(ulonglong *)(lVar6 + 0x40);
  uVar13 = *(ulonglong *)(*(longlong *)(lVar6 + 0x28) + 8 + uVar7 * 0x10);
  uVar11 = *(ulonglong *)(lVar6 + 0x18);
  if (uVar13 != uVar11) {
    uVar7 = *(ulonglong *)(*(longlong *)(lVar6 + 0x28) + uVar7 * 0x10);
    lVar6 = *(longlong *)(*(longlong *)(lVar6 + 8) + 0x38) +
            *(longlong *)(*(longlong *)(lVar6 + 8) + 0x28);
    uVar15 = (ulonglong)local_78[0];
    while( true ) {
      puVar10 = (uint *)(lVar6 - uVar15);
      puVar14 = (uint *)(lVar6 - (ulonglong)*(uint *)(uVar13 + 0x10));
      uVar2 = *puVar10;
      if ((uVar2 == *puVar14) &&
         ((uVar2 == 0 || (iVar4 = memcmp(puVar10 + 1,puVar14 + 1,(ulonglong)uVar2), iVar4 == 0))))
      goto LAB_18043410a;
      if (uVar13 == uVar7) break;
      uVar13 = *(ulonglong *)(uVar13 + 8);
    }
  }
  uVar13 = 0;
LAB_18043410a:
  if (uVar13 == 0) {
    uVar13 = uVar11;
  }
  lVar6 = *(longlong *)(param_1 + 0x80);
  puVar1 = (ulonglong *)(lVar6 + 0x18);
  if (uVar13 != *puVar1) {
    lVar6 = (ulonglong)*(uint *)(param_1 + 0x30) - ((ulonglong)local_70 & 0xffffffff);
    *(longlong *)(param_1 + 0x40) = *(longlong *)(param_1 + 0x40) + lVar6;
    *(uint *)(param_1 + 0x30) = *(uint *)(param_1 + 0x30) - (int)lVar6;
    *param_2 = *(uint *)(uVar13 + 0x10);
    return param_2;
  }
  uVar13 = FUN_180434320(lVar6,local_78);
  FUN_1804346f0(lVar6,&local_70,local_78,uVar13);
  if (lStack_68 != 0) goto LAB_1804342e7;
  if (*(longlong *)(lVar6 + 0x20) == 0xaaaaaaaaaaaaaaa) {
                    /* WARNING: Subroutine does not return */
    FUN_18096eea0("unordered_map/set too long");
  }
  local_58 = (ulonglong *)0x0;
  local_60 = puVar1;
  puVar8 = (ulonglong *)FUN_180976d80(0x18);
  *(uint *)(puVar8 + 2) = local_78[0];
  uVar11 = *(longlong *)(lVar6 + 0x20) + 1;
  if ((longlong)uVar11 < 0) {
    auVar21 = ZEXT416((uint)(float)uVar11);
  }
  else {
    auVar21._0_4_ = (float)(longlong)uVar11;
    auVar21._4_8_ = SUB128(ZEXT812(0),4);
    auVar21._12_4_ = 0;
  }
  uVar11 = *(ulonglong *)(lVar6 + 0x48);
  if (*(float *)(lVar6 + 0x10) < auVar21._0_4_ / (float)uVar11) {
    auVar18._0_4_ = auVar21._0_4_ / *(float *)(lVar6 + 0x10);
    auVar18._4_12_ = auVar21._4_12_;
    auVar22._0_12_ = ZEXT812(0);
    auVar22._12_4_ = 0;
    auVar16 = vroundss_avx(auVar22,auVar18,2);
    fVar19 = auVar16._0_4_;
    lVar12 = 0;
    if ((fVar23 <= fVar19) && (fVar19 = fVar19 - fVar23, fVar19 < fVar23)) {
      lVar12 = -0x8000000000000000;
    }
    uVar7 = 8;
    if (8 < (ulonglong)((longlong)fVar19 + lVar12)) {
      uVar7 = (longlong)fVar19 + lVar12;
    }
    uVar15 = uVar11;
    if ((uVar11 < uVar7) && ((0x1ff < uVar11 || (uVar15 = uVar11 * 8, uVar11 * 8 < uVar7)))) {
      uVar15 = uVar7;
    }
    local_58 = puVar8;
    FUN_1804347d0(lVar6,uVar15);
    puVar9 = (ulonglong *)FUN_1804346f0(lVar6,&local_60,puVar8 + 2,uVar13);
    local_70 = (longlong *)*puVar9;
  }
  plVar5 = (longlong *)local_70[1];
  *(longlong *)(lVar6 + 0x20) = *(longlong *)(lVar6 + 0x20) + 1;
  *puVar8 = (ulonglong)local_70;
  puVar8[1] = (ulonglong)plVar5;
  *plVar5 = (longlong)puVar8;
  local_70[1] = (longlong)puVar8;
  lVar12 = *(longlong *)(lVar6 + 0x28);
  uVar13 = *(ulonglong *)(lVar6 + 0x40) & uVar13;
  plVar3 = *(longlong **)(lVar12 + uVar13 * 0x10);
  if (plVar3 == (longlong *)*puVar1) {
    *(ulonglong **)(lVar12 + uVar13 * 0x10) = puVar8;
  }
  else {
    if (plVar3 == local_70) {
      *(ulonglong **)(lVar12 + uVar13 * 0x10) = puVar8;
      goto LAB_1804342e7;
    }
    if (*(longlong **)(lVar12 + 8 + uVar13 * 0x10) != plVar5) goto LAB_1804342e7;
  }
  *(ulonglong **)(lVar12 + 8 + uVar13 * 0x10) = puVar8;
LAB_1804342e7:
  *param_2 = local_78[0];
  return param_2;
}

