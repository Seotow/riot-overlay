// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1804419e0; descriptive alias: FUN_1804419e0
// Evidence: ev_59248eb639b96b4fb9aace982bac42a6a28c97d6ea176fb5c2bc2bf78f4c71d2
// Original Evidence: rea-collector/0x1804419e0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* WARNING: Removing unreachable block (ram,0x000180441c0a) */
/* WARNING: Removing unreachable block (ram,0x000180441be9) */
/* WARNING: Removing unreachable block (ram,0x000180441c18) */

void FUN_1804419e0(longlong param_1,undefined8 *param_2,uint *param_3)

{
  ulonglong uVar1;
  uint uVar2;
  code *pcVar3;
  undefined1 auVar4 [16];
  undefined1 auVar5 [16];
  undefined1 auVar6 [16];
  undefined1 auVar7 [16];
  undefined8 ***pppuVar8;
  int iVar9;
  undefined4 *puVar10;
  longlong lVar11;
  ulonglong uVar12;
  longlong lVar13;
  undefined1 *puVar14;
  ulonglong uVar15;
  undefined4 *puVar16;
  ulonglong uVar17;
  undefined8 ***pppuVar18;
  longlong lVar19;
  undefined1 auStack_138 [8];
  undefined1 auStack_130 [24];
  undefined8 local_118;
  undefined1 local_108 [8];
  undefined1 local_100 [2];
  char cStack_fe;
  char cStack_fd;
  char cStack_fc;
  char cStack_fb;
  char cStack_fa;
  char cStack_f9;
  undefined8 uStack_f8;
  longlong lStack_f0;
  ulonglong uStack_e8;
  undefined8 local_e0;
  undefined8 **local_d8 [2];
  undefined1 local_c8 [8];
  longlong lStack_c0;
  undefined8 local_b8;
  undefined8 local_b0;
  undefined8 **local_a8;
  undefined8 *puStack_a0;
  code *pcStack_98;
  ulonglong uStack_90;
  undefined1 local_88 [16];
  undefined8 local_78;
  undefined8 **local_70;
  int local_68;
  int local_64;
  undefined1 local_60 [16];
  undefined8 local_50;
  ulonglong local_48;
  ulonglong local_40;
  
  puVar14 = auStack_138;
  local_40 = DAT_180d06cc0 ^ (ulonglong)auStack_138;
  local_68 = 0;
  *(uint *)(param_1 + 0x488) = *param_3;
  uVar2 = *param_3;
  if ((uVar2 & 4) == 0) {
    uStack_e8 = 0xf;
    local_100[1] = ((uVar2 >> 0xd & 1) != 0) + '0';
    local_100[0] = ((uVar2 >> 0xe & 1) != 0) + '0';
    cStack_fe = ((uVar2 >> 0xc & 1) != 0) + '0';
    cStack_fd = ((uVar2 >> 0xb & 1) != 0) + '0';
    cStack_fc = ((uVar2 >> 10 & 1) != 0) + '0';
    cStack_fb = ((uVar2 >> 9 & 1) != 0) + '0';
    cStack_fa = ((uVar2 >> 8 & 1) != 0) + '0';
    cStack_f9 = ((uVar2 & 0x80) != 0) + '0';
    uStack_f8._0_1_ = ((uVar2 & 0x40) != 0) + '0';
    uStack_f8._1_1_ = ((uVar2 & 0x20) != 0) + '0';
    uStack_f8._2_1_ = ((uVar2 & 0x10) != 0) + '0';
    uStack_f8._3_1_ = ((uVar2 & 8) != 0) + '0';
    uStack_f8._4_1_ = 0x30;
    uStack_f8._5_1_ = ((uVar2 & 2) != 0) + '0';
    uStack_f8._6_1_ = ((uVar2 & 1) != 0) + '0';
    lStack_f0 = 0xf;
    uStack_f8._7_1_ = 0;
    local_88._0_9_ = ZEXT89(0x180d6eb78);
    local_88._9_7_ = 0;
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
    local_88[8] = 1;
    local_108[0] = 0;
    FUN_180185e60(&DAT_180d6eb28,local_108);
    local_68 = 0x3a;
    FUN_1801877a0(&DAT_180d6eb28,&local_68,4);
    FUN_1801877a0(&DAT_180d6eb28,&DAT_180d100f8,0x3a);
    local_e0 = _Xtime_get_ticks();
    puStack_a0 = &local_e0;
    pcStack_98 = FUN_180191210;
    local_a8 = (undefined8 **)0xd000000000000000;
    local_50 = 0;
    local_48 = 0xf;
    local_60._1_15_ = SUB1615((undefined1  [16])0x0,1);
    auVar4[0xf] = 0;
    auVar4._0_15_ = local_60._1_15_;
    local_60 = auVar4 << 8;
    local_68 = 9;
    FUN_18019f7a0(local_60,0x11);
    local_78 = 1;
    local_70 = &local_a8;
    lStack_c0 = 9;
    local_c8 = (undefined1  [8])&DAT_180c09610;
    local_118 = 0;
    param_2 = &local_78;
    FUN_18018ad00(local_d8,local_60,local_c8,param_2);
    local_68 = 1;
    FUN_180185f70(&DAT_180d6eb28,&local_68);
    local_68 = (int)local_50;
    FUN_1801877a0(&DAT_180d6eb28,&local_68,4);
    puVar14 = local_60;
    if (0xf < local_48) {
      puVar14 = (undefined1 *)local_60._0_8_;
    }
    FUN_1801877a0(&DAT_180d6eb28,puVar14,local_50);
    uVar15 = uStack_e8;
    param_1 = lStack_f0;
    pppuVar8 = _local_100;
    local_a8 = _local_100;
    puStack_a0 = (undefined8 *)uStack_f8;
    pcStack_98 = (code *)lStack_f0;
    uStack_90 = uStack_e8;
    lStack_f0 = 0;
    uStack_e8 = 0xf;
    auVar5[0xf] = 0;
    auVar5._0_15_ = stack0xffffffffffffff01;
    _local_100 = auVar5 << 8;
    local_d8[0] = &local_a8;
    local_b8 = 0;
    local_b0 = 0xf;
    stack0xffffffffffffff39 = SUB1615((undefined1  [16])0x0,1);
    auVar6[0xf] = 0;
    auVar6._0_15_ = stack0xffffffffffffff39;
    _local_c8 = auVar6 << 8;
    pppuVar18 = &local_a8;
    if (0xf < uVar15) {
      pppuVar18 = pppuVar8;
    }
    local_68 = 1;
    FUN_180185f70(&DAT_180d6eb28,&local_68);
    local_68 = (int)param_1;
    FUN_1801877a0(&DAT_180d6eb28,&local_68,4);
    FUN_1801877a0(&DAT_180d6eb28,pppuVar18,param_1);
    FUN_1801a2650(&local_a8);
    if (DAT_180d6ebe0 != '\0') {
      local_68 = (int)DAT_180d6eb30 - (int)DAT_180d6eb28;
      FUN_1803c9190(&DAT_180d6ebc8,local_c8,&local_68,4);
      param_2 = (undefined8 *)(DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28));
      FUN_1803c9190(&DAT_180d6ebc8,local_c8,CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28),param_2
                   );
    }
    DAT_180d6eb70 = DAT_180d6eb70 + 1;
    lStack_c0 = DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
    local_c8 = (undefined1  [8])CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
    FUN_1801806e0(&DAT_180d6eb40,local_c8);
    local_64 = ((int)DAT_180d6eb30 - (int)DAT_180d6eb28) + 4;
    FUN_180186fb0(&DAT_180d6ea20,&local_64,4);
    FUN_180186fb0(&DAT_180d6ea20,CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28),
                  DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28));
    FUN_180186e20(&DAT_180d6ea20);
    if (CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28) != DAT_180d6eb30) {
      DAT_180d6eb30 = CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
    }
    if (0xf < local_48) {
      uVar15 = local_48 + 1;
      lVar11 = local_60._0_8_;
      if (0xfff < uVar15) {
        lVar11 = *(longlong *)(local_60._0_8_ + -8);
        if (0x1f < (local_60._0_8_ - lVar11) - 8U) {
          pcVar3 = (code *)swi(0x29);
          (*pcVar3)(5);
          puVar14 = auStack_130;
          goto LAB_180441ebc;
        }
        uVar15 = local_48 + 0x28;
      }
      thunk_FUN_180895720(lVar11,uVar15);
    }
    local_50 = 0;
    local_48 = 0xf;
    auVar7[0xf] = 0;
    auVar7._0_15_ = local_60._1_15_;
    local_60 = auVar7 << 8;
    FUN_180973930(&DAT_180d6eb78);
    puVar14 = auStack_138;
  }
  else {
LAB_180441ebc:
    if (*(char *)(param_1 + 0x8788) == '\0') {
      *(undefined8 *)(puVar14 + -8) = 0x180441eda;
      puVar10 = (undefined4 *)FUN_18043eea0(param_1,&local_64,param_2);
      *(undefined4 **)(puVar14 + 0x58) = puVar10;
      puVar16 = *(undefined4 **)(param_1 + 0x8778);
      if (puVar16 == *(undefined4 **)(param_1 + 0x8780)) {
        uVar17 = (longlong)puVar16 - *(longlong *)(param_1 + 0x8770);
        lVar11 = (longlong)uVar17 >> 2;
        uVar15 = 0x3fffffffffffffff;
        if (lVar11 == 0x3fffffffffffffff) {
                    /* WARNING: Subroutine does not return */
          *(undefined **)(puVar14 + -8) = &UNK_180442022;
          FUN_180183310();
        }
        uVar1 = lVar11 + 1;
        uVar12 = (longlong)*(undefined4 **)(param_1 + 0x8780) - *(longlong *)(param_1 + 0x8770) >> 2
        ;
        if (uVar12 <= 0x3fffffffffffffff - (uVar12 >> 1)) {
          uVar12 = (uVar12 >> 1) + uVar12;
          uVar15 = uVar1;
          if (uVar1 <= uVar12) {
            uVar15 = uVar12;
          }
          if (0x3fffffffffffffff < uVar15) {
                    /* WARNING: Subroutine does not return */
            *(undefined8 *)(puVar14 + -8) = 0x180441ffe;
            FUN_1801a22b0();
          }
        }
        *(undefined8 *)(puVar14 + -8) = 0x180441f6d;
        lVar11 = FUN_1801a22d0(uVar15 * 4);
        uVar17 = uVar17 & 0xfffffffffffffffc;
        *(undefined4 *)(uVar17 + lVar11) = **(undefined4 **)(puVar14 + 0x58);
        puVar10 = *(undefined4 **)(param_1 + 0x8770);
        if (puVar16 == *(undefined4 **)(param_1 + 0x8778)) {
          lVar19 = (longlong)*(undefined4 **)(param_1 + 0x8778) - (longlong)puVar10;
          lVar13 = lVar11;
          puVar16 = puVar10;
        }
        else {
          *(undefined8 *)(puVar14 + -8) = 0x180441fa4;
          FUN_1809bf2f0(lVar11,puVar10,(longlong)puVar16 - (longlong)puVar10);
          lVar13 = uVar17 + 4 + lVar11;
          lVar19 = *(longlong *)(param_1 + 0x8778) - (longlong)puVar16;
        }
        *(undefined8 *)(puVar14 + -8) = 0x180441fbd;
        FUN_1809bf2f0(lVar13,puVar16,lVar19);
        *(undefined8 *)(puVar14 + -8) = 0x180441fd2;
        FUN_180189f40(param_1 + 0x8770,lVar11,uVar1,uVar15);
      }
      else {
        *puVar16 = *puVar10;
        *(longlong *)(param_1 + 0x8778) = *(longlong *)(param_1 + 0x8778) + 4;
      }
    }
  }
  *(undefined8 *)(puVar14 + -8) = 0x180441fde;
  return;
}

