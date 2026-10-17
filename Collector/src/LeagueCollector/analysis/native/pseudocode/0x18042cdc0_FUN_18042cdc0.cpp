// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x18042cdc0; descriptive alias: FUN_18042cdc0
// Evidence: ev_f332ce0d70e8731ebdf2604a6266825bc0dd6253b14aa559ffe5cb9234348c79
// Original Evidence: rea-collector/0x18042cdc0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined8 *
FUN_18042cdc0(float *param_1,undefined8 *param_2,ulonglong *param_3,undefined8 *param_4)

{
  undefined8 *puVar1;
  undefined8 *puVar2;
  ulonglong uVar3;
  longlong lVar4;
  undefined8 *puVar5;
  ulonglong uVar6;
  ulonglong uVar7;
  undefined8 *puVar8;
  ulonglong uVar9;
  undefined1 auVar10 [16];
  float fVar11;
  undefined1 auVar12 [16];
  undefined1 auVar13 [16];
  
  uVar9 = ((param_3[1] ^ *param_3) >> 1 ^ param_3[2]) >> 3 ^ (ulonglong)(uint)param_3[3] * 2 ^
          (ulonglong)*(uint *)((longlong)param_3 + 0x1c);
  uVar6 = uVar9 & *(ulonglong *)(param_1 + 0xc);
  lVar4 = *(longlong *)(param_1 + 6);
  puVar2 = *(undefined8 **)(lVar4 + 8 + uVar6 * 0x10);
  uVar3 = uVar6;
  puVar8 = *(undefined8 **)(param_1 + 2);
  if (puVar2 != *(undefined8 **)(param_1 + 2)) {
    uVar3 = uVar6 * 2;
    while( true ) {
      if ((((*param_3 == puVar2[2]) && (param_3[1] == puVar2[3])) && (param_3[2] == puVar2[4])) &&
         (((uint)param_3[3] == *(uint *)(puVar2 + 5) &&
          (*(uint *)((longlong)param_3 + 0x1c) == *(uint *)((longlong)puVar2 + 0x2c))))) {
        *param_2 = puVar2;
        *(undefined1 *)(param_2 + 1) = 0;
        return param_2;
      }
      puVar8 = puVar2;
      if (puVar2 == *(undefined8 **)(lVar4 + uVar6 * 0x10)) break;
      puVar2 = (undefined8 *)puVar2[1];
    }
  }
  if (*(longlong *)(param_1 + 4) == 0x492492492492492) {
                    /* WARNING: Subroutine does not return */
    FUN_18096eea0("unordered_map/set too long");
  }
  puVar2 = (undefined8 *)FUN_180976d80(0x38,uVar3,lVar4,param_4,param_4,param_1 + 2,0);
  uVar3 = param_3[1];
  uVar6 = param_3[2];
  uVar7 = param_3[3];
  puVar2[2] = *param_3;
  puVar2[3] = uVar3;
  puVar2[4] = uVar6;
  puVar2[5] = uVar7;
  puVar2[6] = *param_4;
  uVar3 = *(longlong *)(param_1 + 4) + 1;
  if ((longlong)uVar3 < 0) {
    auVar12 = ZEXT416((uint)(float)uVar3);
  }
  else {
    auVar12._0_4_ = (float)(longlong)uVar3;
    auVar12._4_8_ = SUB128(ZEXT812(0),4);
    auVar12._12_4_ = 0;
  }
  uVar3 = *(ulonglong *)(param_1 + 0xe);
  if (*param_1 < auVar12._0_4_ / (float)uVar3) {
    auVar10._0_4_ = auVar12._0_4_ / *param_1;
    auVar10._4_12_ = auVar12._4_12_;
    auVar13._0_12_ = ZEXT812(0);
    auVar13._12_4_ = 0;
    auVar12 = vroundss_avx(auVar13,auVar10,2);
    fVar11 = auVar12._0_4_;
    lVar4 = 0;
    if ((9.223372e+18 <= fVar11) && (fVar11 = fVar11 - 9.223372e+18, fVar11 < 9.223372e+18)) {
      lVar4 = -0x8000000000000000;
    }
    uVar6 = 8;
    if (8 < (ulonglong)((longlong)fVar11 + lVar4)) {
      uVar6 = (longlong)fVar11 + lVar4;
    }
    uVar7 = uVar3;
    if ((uVar3 < uVar6) && ((0x1ff < uVar3 || (uVar7 = uVar3 * 8, uVar3 * 8 < uVar6)))) {
      uVar7 = uVar6;
    }
    FUN_18042d260(param_1,uVar7);
    puVar5 = *(undefined8 **)
              (*(longlong *)(param_1 + 6) + 8 + (uVar9 & *(ulonglong *)(param_1 + 0xc)) * 0x10);
    puVar8 = *(undefined8 **)(param_1 + 2);
    if (puVar5 != *(undefined8 **)(param_1 + 2)) {
      for (; (((puVar2[2] != puVar5[2] || (puVar2[3] != puVar5[3])) || (puVar2[4] != puVar5[4])) ||
             ((*(int *)(puVar2 + 5) != *(int *)(puVar5 + 5) ||
              (*(int *)((longlong)puVar2 + 0x2c) != *(int *)((longlong)puVar5 + 0x2c)))));
          puVar5 = (undefined8 *)puVar5[1]) {
        puVar8 = puVar5;
        if (puVar5 == *(undefined8 **)
                       (*(longlong *)(param_1 + 6) + (uVar9 & *(ulonglong *)(param_1 + 0xc)) * 0x10)
           ) goto LAB_18042d00d;
      }
      puVar8 = (undefined8 *)*puVar5;
    }
  }
LAB_18042d00d:
  puVar5 = (undefined8 *)puVar8[1];
  *(longlong *)(param_1 + 4) = *(longlong *)(param_1 + 4) + 1;
  *puVar2 = puVar8;
  puVar2[1] = puVar5;
  *puVar5 = puVar2;
  puVar8[1] = puVar2;
  lVar4 = *(longlong *)(param_1 + 6);
  uVar9 = *(ulonglong *)(param_1 + 0xc) & uVar9;
  puVar1 = *(undefined8 **)(lVar4 + uVar9 * 0x10);
  if (puVar1 == *(undefined8 **)(param_1 + 2)) {
    *(undefined8 **)(lVar4 + uVar9 * 0x10) = puVar2;
  }
  else {
    if (puVar1 == puVar8) {
      *(undefined8 **)(lVar4 + uVar9 * 0x10) = puVar2;
      goto LAB_18042d058;
    }
    if (*(undefined8 **)(lVar4 + 8 + uVar9 * 0x10) != puVar5) goto LAB_18042d058;
  }
  *(undefined8 **)(lVar4 + 8 + uVar9 * 0x10) = puVar2;
LAB_18042d058:
  *param_2 = puVar2;
  *(undefined1 *)(param_2 + 1) = 1;
  return param_2;
}

