// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180439820; descriptive alias: FUN_180439820
// Evidence: ev_1d84f4bd94af66bbb9f0752e8ab41df58f32e6bc414e58b0862f1cc8640af035
// Original Evidence: rea-collector/0x180439820.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

int * FUN_180439820(undefined8 *param_1,int *param_2,float *param_3)

{
  float fVar1;
  uint uVar2;
  undefined4 uVar3;
  int iVar4;
  undefined8 *puVar5;
  longlong lVar6;
  longlong lVar7;
  longlong lVar8;
  float *pfVar9;
  ulonglong uVar10;
  float *pfVar11;
  undefined4 *puVar12;
  ulonglong uVar13;
  undefined8 *puVar14;
  int *piVar15;
  undefined4 uStack_3c;
  
  if (*(ulonglong *)*param_1 != 0) {
    puVar5 = (undefined8 *)param_1[2];
    pfVar11 = (float *)*puVar5;
    uVar13 = 0;
    pfVar9 = param_3;
    puVar14 = puVar5;
    if ((ulonglong)*(uint *)(param_1[1] + 8) != 0) {
      while( true ) {
        while (*pfVar9 != *pfVar11) {
          uVar13 = uVar13 + 1;
          if (*(ulonglong *)*param_1 <= uVar13) goto LAB_1804398bb;
          pfVar9 = param_3;
          puVar14 = puVar5 + uVar13 * 2;
          pfVar11 = (float *)puVar5[uVar13 * 2];
        }
        if (pfVar9 + 1 == param_3 + *(uint *)(param_1[1] + 8)) break;
        pfVar11 = pfVar11 + 1;
        pfVar9 = pfVar9 + 1;
      }
    }
    *param_2 = *(int *)(puVar14 + 1);
    return param_2;
  }
LAB_1804398bb:
  lVar6 = param_1[1];
  lVar7 = *(longlong *)(param_1[3] + 0x480);
  uVar2 = *(uint *)(lVar6 + 8);
  uVar13 = (ulonglong)uVar2;
  FUN_1801c3f20(lVar7,uVar13,8,4);
  if (uVar2 == 0) {
    puVar12 = *(undefined4 **)(lVar7 + 0x40);
  }
  else {
    FUN_1801c5410(lVar7,uVar13 * 8);
    *(longlong *)(lVar7 + 0x40) = *(longlong *)(lVar7 + 0x40) + uVar13 * -8;
    uVar10 = 0;
    *(int *)(lVar7 + 0x30) = *(int *)(lVar7 + 0x30) + (int)(uVar13 * 8);
    puVar12 = *(undefined4 **)(lVar7 + 0x40);
    if (3 < uVar2) {
      do {
        uVar3 = *(undefined4 *)(lVar6 + 0x14 + uVar10 * 4);
        puVar12[1] = param_3[uVar10];
        *puVar12 = uVar3;
        uVar3 = *(undefined4 *)(lVar6 + 0x18 + uVar10 * 4);
        puVar12[3] = param_3[uVar10 + 1];
        puVar12[2] = uVar3;
        uVar3 = *(undefined4 *)(lVar6 + 0x1c + uVar10 * 4);
        puVar12[5] = param_3[uVar10 + 2];
        puVar12[4] = uVar3;
        lVar8 = uVar10 + 3;
        uVar3 = *(undefined4 *)(lVar6 + 0x20 + uVar10 * 4);
        uVar10 = uVar10 + 4;
        puVar12[7] = param_3[lVar8];
        puVar12[6] = uVar3;
        puVar12 = puVar12 + 8;
      } while (uVar10 < uVar13 - 3);
      goto joined_r0x00018043999f;
    }
  }
  uVar10 = 0;
joined_r0x00018043999f:
  for (; uVar10 < uVar13; uVar10 = uVar10 + 1) {
    fVar1 = param_3[uVar10];
    *puVar12 = *(undefined4 *)(lVar6 + 0x14 + uVar10 * 4);
    puVar12[1] = fVar1;
    puVar12 = puVar12 + 2;
  }
  *(undefined1 *)(lVar7 + 0x60) = 0;
  if (*(ulonglong *)(lVar7 + 0x68) < 4) {
    *(undefined8 *)(lVar7 + 0x68) = 4;
  }
  piVar15 = (int *)(lVar7 + 0x30);
  FUN_1801c5360(lVar7,-*piVar15 & 3);
  FUN_1801c5410(lVar7,4);
  *(longlong *)(lVar7 + 0x40) = *(longlong *)(lVar7 + 0x40) + -4;
  *piVar15 = *piVar15 + 4;
  **(uint **)(lVar7 + 0x40) = uVar2;
  iVar4 = *piVar15;
  uVar13 = *(ulonglong *)*param_1;
  if (uVar13 < 0x10) {
    lVar6 = param_1[2];
    *(ulonglong *)*param_1 = uVar13 + 1;
    *(float **)(lVar6 + uVar13 * 0x10) = param_3;
    *(ulonglong *)(lVar6 + 8 + uVar13 * 0x10) = CONCAT44(uStack_3c,iVar4);
  }
  *param_2 = iVar4;
  return param_2;
}

