// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x18043dcd0; descriptive alias: FUN_18043dcd0
// Evidence: ev_82b4d7b461d7265c828e8c856759940835849e2af7d83b1439333692a9766c4b
// Original Evidence: rea-collector/0x18043dcd0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* WARNING: Removing unreachable block (ram,0x00018043e1e4) */
/* WARNING: Removing unreachable block (ram,0x00018043e1c3) */
/* WARNING: Removing unreachable block (ram,0x00018043e1f2) */

undefined8 FUN_18043dcd0(undefined8 param_1,undefined8 param_2,char *param_3)

{
  undefined8 uVar1;
  undefined8 uVar2;
  code *pcVar3;
  undefined1 auVar4 [16];
  undefined1 auVar5 [16];
  undefined1 auVar6 [16];
  char cVar7;
  uint uVar8;
  int iVar9;
  ulonglong uVar10;
  undefined4 *puVar11;
  longlong lVar12;
  ulonglong uVar13;
  undefined1 *puVar14;
  uint uVar15;
  undefined4 uVar16;
  undefined8 unaff_RBX;
  longlong lVar17;
  longlong *plVar18;
  longlong lVar19;
  undefined1 *puVar20;
  undefined1 *puVar21;
  ulonglong uVar22;
  undefined4 uVar23;
  longlong unaff_R12;
  int *piVar24;
  longlong unaff_R15;
  undefined1 auStack_168 [8];
  undefined1 auStack_160 [24];
  undefined8 local_148;
  undefined1 local_138 [16];
  undefined *local_128;
  longlong local_120;
  undefined8 local_118;
  undefined8 local_110;
  undefined8 local_108;
  undefined8 local_100;
  undefined8 local_f8;
  char **local_f0;
  code *local_e8;
  undefined8 local_d8;
  undefined8 *local_d0;
  undefined8 local_c8;
  undefined8 local_c0;
  undefined8 local_b8;
  undefined8 uStack_b0;
  undefined8 uStack_a8;
  ulonglong uStack_a0;
  undefined4 local_98;
  char *local_88;
  undefined8 local_80;
  undefined1 local_78 [4];
  undefined4 uStack_74;
  undefined8 uStack_70;
  undefined8 uStack_68;
  undefined8 uStack_60;
  char *local_50;
  ulonglong local_48;
  
  puVar20 = auStack_168;
  puVar21 = auStack_168;
  local_48 = DAT_180d06cc0 ^ (ulonglong)auStack_168;
  lVar17 = 0;
  uStack_68 = 0;
  uStack_60 = 0xf;
  stack0xffffffffffffff89 = SUB1615((undefined1  [16])0x0,1);
  auVar4[0xf] = 0;
  auVar4._0_15_ = stack0xffffffffffffff89;
  _local_78 = auVar4 << 8;
  local_118 = param_1;
  local_110 = param_2;
  FUN_18019f7a0(local_78,0xf);
  local_108 = 0;
  local_100 = 0;
  local_88 = "particleemitter";
  local_80 = 0xf;
  local_148 = 0;
  FUN_18018ad00(&local_50,local_78,&local_88,&local_108);
  if (uStack_60 < 0x10) {
LAB_18043dda4:
    if (DAT_180d2eec8 == '\0') {
      uVar8 = DAT_180d2ea60 + 0xe6632e3aU ^ 0x11bf48c;
    }
    else {
      uVar8 = FUN_18052b510(&DAT_180d2ea60);
    }
    uVar15 = DAT_180d457d4 + 0xe6632e3a;
    cVar7 = FUN_1801fa260(param_3 + ((ulonglong)uVar15 ^ 0x11bf48c) + (ulonglong)uVar8);
    lVar12 = lVar17;
    if ((cVar7 == '\0') ||
       ((param_3[((ulonglong)uVar15 ^ 0x11bf48c) + (ulonglong)uVar8] & 0xeU) == 0)) {
      uVar15 = DAT_180d457c4 + 0xe6632e3a;
      cVar7 = FUN_1801fa260(param_3 + ((ulonglong)uVar15 ^ 0x11bf48c) + (ulonglong)uVar8);
      if (cVar7 != '\0') {
        lVar12 = *(longlong *)(param_3 + ((ulonglong)uVar15 ^ 0x11bf48c) + (ulonglong)uVar8);
        cVar7 = FUN_1801fa260(lVar12);
        if (cVar7 == '\0') {
          lVar12 = 0;
        }
      }
      uVar15 = DAT_180d457c8 + 0xe6632e3a;
      cVar7 = FUN_1801fa260(param_3 + ((ulonglong)uVar15 ^ 0x11bf48c) + (ulonglong)uVar8);
      if (cVar7 != '\0') {
        lVar17 = *(longlong *)(param_3 + ((ulonglong)uVar15 ^ 0x11bf48c) + (ulonglong)uVar8);
        cVar7 = FUN_1801fa260(lVar17);
        if (cVar7 == '\0') {
          lVar17 = 0;
        }
        else {
          piVar24 = (int *)(((ulonglong)(DAT_180d457cc + 0xe6632e3a) ^ 0x11bf48c) + lVar17);
          cVar7 = FUN_1801fa260(piVar24);
          if (cVar7 == '\0') {
            lVar17 = 0;
          }
          else if (*piVar24 == 0) {
            lVar17 = 0;
          }
          else {
            plVar18 = (longlong *)(lVar17 + ((ulonglong)(DAT_180d457d0 + 0xe6632e3a) ^ 0x11bf48c));
            cVar7 = FUN_1801fa260(plVar18);
            if (cVar7 == '\0') {
              lVar17 = 0;
            }
            else {
              lVar17 = *plVar18;
              cVar7 = FUN_1801fa260(lVar17);
              if (cVar7 == '\0') {
                lVar17 = 0;
              }
            }
          }
        }
      }
    }
    lVar19 = 0;
    unaff_R12 = lVar19;
    if (lVar17 != 0) {
      unaff_R12 = FUN_180420820(lVar17);
    }
    unaff_R15 = lVar19;
    if (lVar12 != 0) {
      unaff_R15 = FUN_180420820(lVar12);
    }
    uVar15 = DAT_180d457c0 + 0xe6632e3a;
    cVar7 = FUN_1801fa260(param_3 + ((ulonglong)uVar15 ^ 0x11bf48c) + (ulonglong)uVar8);
    if (cVar7 != '\0') {
      lVar19 = *(longlong *)(param_3 + ((ulonglong)uVar15 ^ 0x11bf48c) + (ulonglong)uVar8);
    }
    local_b8 = 0;
    uStack_b0 = 0;
    uStack_a8 = 0;
    uStack_a0 = 0;
    local_98 = 0;
    cVar7 = FUN_1801fa260(lVar19);
    if (cVar7 == '\0') {
      if (DAT_180d2e178 == '\0') {
        uVar8 = DAT_180d2dd10 + 0xe6632e3aU ^ 0x11bf48c;
      }
      else {
        uVar8 = FUN_18052b510(&DAT_180d2dd10);
      }
      local_50 = param_3 + uVar8;
      if (PTR_PTR_180d0fac8 == (undefined *)0x0) {
                    /* WARNING: Subroutine does not return */
        FUN_18096ee50();
      }
      (**(code **)(*(longlong *)PTR_PTR_180d0fac8 + 0x10))(PTR_PTR_180d0fac8,&local_c8,&local_50);
      iVar9 = FUN_180973810(&DAT_180d6eb78);
      if (iVar9 != 0) {
                    /* WARNING: Subroutine does not return */
        FUN_1809737c0(5);
      }
      if (DAT_180d6ebc4 == 0x7fffffff) {
        DAT_180d6ebc4 = 0x7ffffffe;
                    /* WARNING: Subroutine does not return */
        FUN_1809737c0(6);
      }
      local_138[0] = 1;
      FUN_180185e60(&DAT_180d6eb28,local_138);
      local_88 = (char *)CONCAT44(local_88._4_4_,0x2c);
      FUN_1801877a0(&DAT_180d6eb28,&local_88,4);
      FUN_1801877a0(&DAT_180d6eb28,&DAT_180d100c8,0x2c);
      local_88 = (char *)_Xtime_get_ticks();
      local_f0 = &local_88;
      local_e8 = FUN_180191210;
      local_f8 = 0xd000000000000000;
      uStack_68 = 0;
      uStack_60 = 0xf;
      stack0xffffffffffffff89 = SUB1615((undefined1  [16])0x0,1);
      auVar5[0xf] = 0;
      auVar5._0_15_ = stack0xffffffffffffff89;
      _local_78 = auVar5 << 8;
      FUN_18019f7a0(local_78,0x11);
      local_d8 = 1;
      local_d0 = &local_f8;
      local_128 = &DAT_180c09610;
      local_120 = 9;
      local_148 = 0;
      FUN_18018ad00(&local_108,local_78,&local_128,&local_d8);
      local_88._0_4_ = 1;
      FUN_180185f70(&DAT_180d6eb28,&local_88);
      local_88._0_4_ = (undefined4)uStack_68;
      FUN_1801877a0(&DAT_180d6eb28,&local_88,4);
      puVar14 = local_78;
      if (0xf < uStack_60) {
        puVar14 = _local_78;
      }
      FUN_1801877a0(&DAT_180d6eb28,puVar14,uStack_68);
      local_88._0_4_ = 1;
      FUN_180185f70(&DAT_180d6eb28,&local_88);
      local_88._0_4_ = (undefined4)local_c0;
      FUN_1801877a0(&DAT_180d6eb28,&local_88,4);
      FUN_1801877a0(&DAT_180d6eb28,local_c8,local_c0);
      local_88._0_4_ = 0;
      FUN_180185f70(&DAT_180d6eb28,&local_88);
      local_88 = (char *)CONCAT44(local_88._4_4_,8);
      FUN_1801877a0(&DAT_180d6eb28,&local_88,4);
      local_88 = param_3;
      FUN_1801877a0(&DAT_180d6eb28,&local_88,8);
      if (DAT_180d6ebe0 != '\0') {
        local_88 = (char *)CONCAT44(local_88._4_4_,(int)DAT_180d6eb30 - (int)DAT_180d6eb28);
        FUN_1803c9190(&DAT_180d6ebc8,&local_128,&local_88,4);
        FUN_1803c9190(&DAT_180d6ebc8,&local_128,CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28),
                      DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28));
      }
      DAT_180d6eb70 = DAT_180d6eb70 + 1;
      local_128 = (undefined *)CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
      local_120 = DAT_180d6eb30 - (longlong)local_128;
      FUN_1801806e0(&DAT_180d6eb40,&local_128);
      local_50 = (char *)CONCAT44(local_50._4_4_,((int)DAT_180d6eb30 - (int)DAT_180d6eb28) + 4);
      FUN_180186fb0(&DAT_180d6ea20,&local_50,4);
      FUN_180186fb0(&DAT_180d6ea20,CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28),
                    DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28));
      FUN_180186e20(&DAT_180d6ea20);
      if (CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28) != DAT_180d6eb30) {
        DAT_180d6eb30 = CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
      }
      if (0xf < uStack_60) {
        uVar13 = uStack_60 + 1;
        lVar17 = (longlong)_local_78;
        if (0xfff < uVar13) {
          lVar17 = *(longlong *)((longlong)_local_78 + -8);
          unaff_RBX = local_c0;
          if (0x1f < ((longlong)_local_78 - lVar17) - 8U) goto LAB_18043e49b;
          uVar13 = uStack_60 + 0x28;
        }
        thunk_FUN_180895720(lVar17,uVar13);
      }
      uStack_68 = 0;
      uStack_60 = 0xf;
      auVar6[0xf] = 0;
      auVar6._0_15_ = stack0xffffffffffffff89;
      _local_78 = auVar6 << 8;
      FUN_180973930(&DAT_180d6eb78);
    }
    else {
      if (DAT_180d45c40 == '\0') {
        uVar8 = DAT_180d457d8 + 0xe6632e3aU ^ 0x11bf48c;
      }
      else {
        uVar8 = FUN_18052b510(&DAT_180d457d8);
      }
      uVar13 = (ulonglong)uVar8;
      if (DAT_180d45c40 == '\0') {
        uVar8 = DAT_180d457d8 + 0xe6632e3aU ^ 0x11bf48c;
      }
      else {
        uVar8 = FUN_18052b510(&DAT_180d457d8);
      }
      if (DAT_180d460b0 == '\0') {
        uVar15 = DAT_180d45c48 + 0xe6632e3aU ^ 0x11bf48c;
      }
      else {
        uVar15 = FUN_18052b510(&DAT_180d45c48);
      }
      uVar22 = (ulonglong)(uVar8 + uVar15);
      if (DAT_180d45c40 == '\0') {
        uVar8 = DAT_180d457d8 + 0xe6632e3aU ^ 0x11bf48c;
      }
      else {
        uVar8 = FUN_18052b510(&DAT_180d457d8);
      }
      if (DAT_180d46520 == '\0') {
        uVar15 = DAT_180d460b8 + 0xe6632e3aU ^ 0x11bf48c;
      }
      else {
        uVar15 = FUN_18052b510(&DAT_180d460b8);
      }
      uVar10 = (ulonglong)(uVar15 + uVar8);
      _local_78 = (undefined1 *)
                  CONCAT44(*(undefined4 *)(uVar13 + 4 + lVar19),*(undefined4 *)(uVar13 + lVar19));
      uStack_70._0_4_ = *(undefined4 *)(uVar13 + 8 + lVar19);
      uStack_70._4_4_ = *(undefined4 *)(uVar22 + lVar19);
      uStack_68 = CONCAT44(*(undefined4 *)(uVar22 + 8 + lVar19),*(undefined4 *)(uVar22 + 4 + lVar19)
                          );
      uStack_60 = CONCAT44(*(undefined4 *)(uVar10 + 4 + lVar19),*(undefined4 *)(uVar10 + lVar19));
      local_98 = *(undefined4 *)(uVar10 + 8 + lVar19);
      local_b8 = _local_78;
      uStack_b0 = uStack_70;
      uStack_a8 = uStack_68;
      uStack_a0 = uStack_60;
    }
    uVar23 = 0;
    uVar16 = uVar23;
    if (unaff_R12 == 0) goto LAB_18043e4b7;
    uVar16 = 0;
    if (DAT_180d2e5e8 != '\0') goto LAB_18043e4a2;
    uVar8 = DAT_180d2e180 + 0xe6632e3aU ^ 0x11bf48c;
    puVar21 = auStack_168;
    uVar16 = 0;
  }
  else {
    uVar13 = uStack_60 + 1;
    lVar12 = (longlong)_local_78;
    if (uVar13 < 0x1000) {
LAB_18043dd9f:
      thunk_FUN_180895720(lVar12,uVar13);
      goto LAB_18043dda4;
    }
    lVar12 = *(longlong *)((longlong)_local_78 + -8);
    if (((longlong)_local_78 - lVar12) - 8U < 0x20) {
      uVar13 = uStack_60 + 0x28;
      goto LAB_18043dd9f;
    }
LAB_18043e49b:
    uVar16 = (undefined4)unaff_RBX;
    pcVar3 = (code *)swi(0x29);
    (*pcVar3)(5);
    puVar20 = auStack_160;
LAB_18043e4a2:
    *(undefined8 *)(puVar20 + -8) = 0x18043e4b1;
    uVar8 = FUN_18052b510(&DAT_180d2e180);
    puVar21 = puVar20;
  }
  uVar23 = *(undefined4 *)((ulonglong)uVar8 + unaff_R12);
LAB_18043e4b7:
  if (unaff_R15 != 0) {
    if (DAT_180d2e5e8 == '\0') {
      uVar8 = DAT_180d2e180 + 0xe6632e3aU ^ 0x11bf48c;
    }
    else {
      *(undefined8 *)(puVar21 + -8) = 0x18043e4e6;
      uVar8 = FUN_18052b510(&DAT_180d2e180);
    }
    uVar16 = *(undefined4 *)((ulonglong)uVar8 + unaff_R15);
  }
  lVar17 = *(longlong *)(puVar21 + 0x50);
  *(undefined8 *)(puVar21 + -8) = 0x18043e503;
  puVar11 = (undefined4 *)FUN_1804395d0(lVar17,&local_50,param_3);
  *(undefined8 **)(puVar21 + 0x28) = &local_b8;
  *(undefined4 *)(puVar21 + 0x20) = uVar23;
  uVar23 = *puVar11;
  uVar1 = *(undefined8 *)(lVar17 + 0x480);
  uVar2 = *(undefined8 *)(puVar21 + 0x58);
  *(undefined8 *)(puVar21 + -8) = 0x18043e52a;
  FUN_180438200(uVar2,uVar1,uVar23,uVar16);
  *(undefined8 *)(puVar21 + -8) = 0x18043e539;
  return uVar2;
}

