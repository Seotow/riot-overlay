// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1804392f0; descriptive alias: FUN_1804392f0
// Evidence: ev_35e26ccf7d9afdeb0797180c6133dc4d99d66563b8f5e6be443ade6c41d78fd1
// Original Evidence: rea-collector/0x1804392f0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */

int * FUN_1804392f0(longlong param_1,int *param_2,undefined8 param_3)

{
  longlong lVar1;
  undefined4 uVar2;
  int iVar3;
  code *pcVar4;
  undefined8 uVar5;
  longlong *plVar6;
  undefined8 *puVar7;
  undefined4 *puVar8;
  ulonglong uVar9;
  undefined4 *puVar10;
  undefined4 *puVar11;
  undefined1 *puVar12;
  undefined4 *puVar13;
  int *piVar14;
  undefined4 *puVar15;
  float fVar16;
  float fVar17;
  undefined1 auStack_118 [8];
  undefined1 auStack_110 [24];
  undefined1 local_f8 [16];
  longlong local_e8;
  undefined1 local_d8 [16];
  undefined8 local_c8;
  undefined4 local_c0 [2];
  undefined4 local_b8 [4];
  undefined4 local_a8;
  undefined4 local_a4;
  undefined8 *local_a0;
  undefined4 *local_98;
  undefined8 local_90;
  undefined1 local_88 [16];
  undefined8 local_78;
  undefined8 local_70;
  ulonglong local_68;
  
  puVar12 = auStack_118;
  local_68 = DAT_180d06cc0 ^ (ulonglong)auStack_118;
  local_f8._0_10_ = (unkuint10)0x736e << 0x40;
  local_f8._10_6_ = 0;
  puVar10 = (undefined4 *)0x0;
  local_a4 = 0;
  local_90 = 0;
  local_88 = (undefined1  [16])0x0;
  local_78 = 0;
  local_70 = 0;
  fVar17 = 0.0;
  local_a8 = 0;
  local_a0 = (undefined8 *)0x0;
  local_98 = (undefined4 *)0x0;
  local_a0 = (undefined8 *)FUN_180976d80(0x18);
  *local_a0 = local_a0;
  local_a0[1] = local_a0;
  local_90 = 0;
  local_88 = (undefined1  [16])0x0;
  local_78 = 7;
  local_70 = 8;
  local_a8 = 0x3f800000;
  FUN_1801b0350(&local_90,0x10,local_a0);
  local_f8 = (undefined1  [16])0x0;
  local_e8 = 0;
  FUN_1804266d0(param_3,local_f8);
  uVar5 = local_f8._0_8_;
  puVar13 = (undefined4 *)local_f8._8_8_;
  for (puVar11 = (undefined4 *)local_f8._0_8_; puVar11 != puVar13; puVar11 = puVar11 + 1) {
    local_c0[0] = *puVar11;
    local_c8 = param_3;
    local_b8[0] = local_c0[0];
    if ((longlong *)PTR_PTR_180d0fc08 == (longlong *)0x0) {
                    /* WARNING: Subroutine does not return */
      FUN_18096ee50();
    }
    fVar16 = (float)(**(code **)(*(longlong *)PTR_PTR_180d0fc08 + 0x10))
                              (PTR_PTR_180d0fc08,&local_c8,local_c0);
    if (fVar16 != fVar17) {
      plVar6 = (longlong *)FUN_1804285e0(&local_a8,local_d8,local_b8);
      *(float *)(*plVar6 + 0x14) = fVar16;
    }
  }
  if ((undefined4 *)uVar5 != (undefined4 *)0x0) {
    uVar9 = (local_e8 - uVar5 >> 2) * 4;
    puVar15 = (undefined4 *)uVar5;
    if (0xfff < uVar9) {
      puVar15 = *(undefined4 **)(uVar5 + -8);
      piVar14 = (int *)(uVar5 + (-8 - (longlong)puVar15));
      if (&DAT_00000020 <= piVar14) {
        pcVar4 = (code *)swi(0x29);
        (*pcVar4)(5);
        puVar12 = auStack_110;
        goto LAB_180439538;
      }
      uVar9 = uVar9 + 0x27;
    }
    thunk_FUN_180895720(puVar15,uVar9);
  }
  puVar13 = local_98;
  puVar11 = *(undefined4 **)(param_1 + 0x480);
  FUN_1801c3f20(puVar11,local_98,8,4);
  lVar1 = (longlong)puVar13 * 8;
  if (lVar1 != 0) {
    FUN_1801c5410(puVar11,lVar1);
    *(longlong *)(puVar11 + 0x10) = *(longlong *)(puVar11 + 0x10) + (longlong)puVar13 * -8;
    puVar11[0xc] = puVar11[0xc] + (int)lVar1;
  }
  piVar14 = puVar11 + 0xc;
  puVar15 = *(undefined4 **)(puVar11 + 0x10);
  if (puVar13 != (undefined4 *)0x0) {
    do {
      puVar7 = (undefined8 *)*local_a0;
      for (puVar8 = puVar10; (longlong)puVar8 < 0; puVar8 = (undefined4 *)((longlong)puVar8 + 1)) {
        puVar7 = (undefined8 *)puVar7[1];
      }
      if (puVar8 != (undefined4 *)0x0) {
        do {
          puVar7 = (undefined8 *)*puVar7;
          puVar8 = (undefined4 *)((longlong)puVar8 + -1);
        } while (0 < (longlong)puVar8);
      }
      uVar2 = *(undefined4 *)((longlong)puVar7 + 0x14);
      *puVar15 = *(undefined4 *)(puVar7 + 2);
      puVar15[1] = uVar2;
      puVar15 = puVar15 + 2;
      puVar10 = (undefined4 *)((longlong)puVar10 + 1);
      puVar12 = auStack_118;
    } while (puVar10 < puVar13);
  }
LAB_180439538:
  *(undefined1 *)(puVar11 + 0x18) = 0;
  if (*(ulonglong *)(puVar11 + 0x1a) < 4) {
    *(undefined8 *)(puVar11 + 0x1a) = 4;
  }
  iVar3 = *piVar14;
  *(undefined8 *)(puVar12 + -8) = 0x180439560;
  FUN_1801c5360(puVar11,-iVar3 & 3);
  *(undefined8 *)(puVar12 + -8) = 0x18043956d;
  FUN_1801c5410(puVar11,4);
  *(longlong *)(puVar11 + 0x10) = *(longlong *)(puVar11 + 0x10) + -4;
  puVar11 = *(undefined4 **)(puVar11 + 0x10);
  *piVar14 = *piVar14 + 4;
  *puVar11 = (int)puVar13;
  *param_2 = *piVar14;
  *(undefined8 *)(puVar12 + -8) = 0x18043958a;
  FUN_1801ad9b0(&local_90);
  *(undefined8 *)(puVar12 + -8) = 0x180439593;
  FUN_1801c5db0(&local_a0);
  *(undefined8 *)(puVar12 + -8) = 0x1804395a2;
  return param_2;
}

