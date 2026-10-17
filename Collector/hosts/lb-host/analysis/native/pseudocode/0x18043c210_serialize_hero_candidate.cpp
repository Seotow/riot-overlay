// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x18043c210; descriptive alias: serialize_hero_candidate
// Evidence: ev_ed4f91f464812693331ca8fd42d13249810a304a3d958e4320f04cb535ebabe6
// Original Evidence: rea-snapshot-hero.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* WARNING: Removing unreachable block (ram,0x00018043c9e1) */
/* WARNING: Removing unreachable block (ram,0x00018043c3c3) */
/* WARNING: Removing unreachable block (ram,0x00018043c3d9) */
/* WARNING: Removing unreachable block (ram,0x00018043c3ee) */
/* WARNING: Removing unreachable block (ram,0x00018043c3f5) */
/* WARNING: Removing unreachable block (ram,0x00018043c555) */
/* WARNING: Removing unreachable block (ram,0x00018043c57b) */
/* WARNING: Removing unreachable block (ram,0x00018043c589) */
/* WARNING: Removing unreachable block (ram,0x00018043ca07) */
/* WARNING: Removing unreachable block (ram,0x00018043ca15) */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8 FUN_18043c210(longlong param_1,undefined8 param_2,longlong param_3)

{
  undefined1 uVar1;
  undefined2 uVar2;
  undefined4 uVar3;
  undefined8 uVar4;
  code *pcVar5;
  undefined1 auVar6 [16];
  undefined1 auVar7 [16];
  bool bVar8;
  undefined1 auVar9 [16];
  bool bVar10;
  char cVar11;
  undefined1 uVar12;
  byte bVar13;
  int iVar14;
  uint uVar15;
  undefined4 uVar16;
  undefined4 uVar17;
  longlong *plVar18;
  undefined4 *puVar19;
  longlong lVar20;
  undefined8 uVar21;
  undefined1 auVar22 [8];
  ulonglong uVar23;
  ulonglong uVar24;
  uint uVar25;
  undefined8 *puVar26;
  longlong lVar27;
  undefined1 *puVar28;
  undefined4 *puVar29;
  undefined4 uVar30;
  undefined4 uVar31;
  undefined4 uVar32;
  float fVar33;
  undefined4 uVar34;
  undefined4 uVar35;
  undefined4 uVar36;
  undefined4 uVar37;
  undefined4 uVar38;
  undefined4 uVar39;
  undefined4 uVar40;
  undefined4 uVar41;
  undefined1 in_ZMM6 [64];
  undefined1 auVar42 [64];
  undefined1 in_ZMM7 [64];
  undefined1 auVar43 [64];
  undefined1 in_ZMM8 [64];
  undefined1 auVar44 [64];
  undefined1 in_ZMM10 [64];
  undefined1 auVar45 [64];
  undefined1 auVar46 [64];
  undefined1 auStack_3a8 [8];
  undefined1 auStack_3a0 [24];
  undefined8 local_388;
  uint local_380;
  undefined4 local_378;
  undefined4 local_370;
  undefined4 local_368;
  undefined2 local_360;
  undefined1 local_358;
  undefined1 local_350;
  undefined4 local_348;
  undefined1 local_340;
  undefined1 local_2e8 [4];
  undefined1 local_2e4 [4];
  undefined4 local_2e0;
  undefined1 local_2dc [4];
  longlong *local_2d8;
  longlong local_2d0;
  undefined8 local_2c8;
  ulonglong local_2c0;
  undefined8 *local_2b8;
  undefined8 *puStack_2b0;
  longlong local_2a8;
  undefined8 local_2a0;
  undefined8 local_298;
  undefined8 local_290;
  longlong local_288;
  longlong local_280;
  undefined8 local_278 [2];
  undefined8 local_268;
  undefined8 **local_260;
  undefined *local_258;
  undefined8 local_250;
  longlong local_248;
  longlong local_240;
  undefined1 *local_238;
  ulonglong local_230;
  undefined8 local_228;
  undefined8 **local_220;
  undefined *local_218;
  undefined8 local_210;
  longlong local_208;
  longlong local_200;
  longlong local_1f8;
  undefined *local_1e8;
  undefined8 uStack_1e0;
  undefined8 local_1d8;
  undefined1 *local_1d0;
  longlong local_1c8;
  longlong local_1c0;
  undefined1 local_1b8 [8];
  undefined1 local_1b0 [8];
  undefined1 local_1a8 [16];
  undefined1 local_198 [16];
  undefined1 local_188 [16];
  undefined1 local_178 [16];
  undefined1 local_168 [16];
  undefined1 local_158 [16];
  undefined8 *local_148;
  undefined8 *puStack_140;
  code *local_138;
  undefined1 local_128 [8];
  undefined8 *puStack_120;
  code *local_118;
  ulonglong local_110;
  int local_108;
  int local_104;
  int local_100 [2];
  undefined1 local_f8 [8];
  undefined4 uStack_f0;
  undefined4 uStack_ec;
  int local_e8;
  undefined4 uStack_e4;
  ulonglong local_e0;
  undefined1 local_d8 [16];
  undefined8 *local_c8;
  ulonglong local_c0;
  undefined1 local_88 [16];
  undefined1 local_68 [16];
  undefined1 local_58 [16];
  undefined1 local_48 [16];
  
  puVar28 = auStack_3a8;
  local_48 = in_ZMM6._0_16_;
  local_58 = in_ZMM7._0_16_;
  local_68 = in_ZMM8._0_16_;
  local_88 = in_ZMM10._0_16_;
  local_c0 = DAT_180d06cc0 ^ (ulonglong)auStack_3a8;
  uStack_f0 = 0x746e6569;
  local_2d0 = param_1;
  local_2c8 = param_2;
  local_2a8 = param_3;
  if (DAT_180d354d8 == '\0') {
    uVar25 = DAT_180d35070 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar25 = FUN_18052b510(&DAT_180d35070);
  }
  _local_f8 = (unkuint9)0x6b << 0x40;
  stack0xffffffffffffff11 = 0;
  local_290 = *(undefined8 *)(param_1 + 0x480);
  local_d8 = (undefined1  [16])0x0;
  local_c8 = (undefined8 *)0x0;
  local_288 = (ulonglong)uVar25 + param_3;
  local_d8._0_8_ = FUN_180976d80(0x40);
  local_c8 = (undefined8 *)(local_d8._0_8_ + 0x40);
  *(undefined8 *)local_d8._0_8_ = 0;
  *(undefined8 *)(local_d8._0_8_ + 8) = 0;
  *(undefined8 *)(local_d8._0_8_ + 0x10) = 0;
  *(undefined8 *)(local_d8._0_8_ + 0x18) = 0;
  *(undefined8 *)(local_d8._0_8_ + 0x20) = 0;
  *(undefined8 *)(local_d8._0_8_ + 0x28) = 0;
  *(undefined8 *)(local_d8._0_8_ + 0x30) = 0;
  *(undefined8 *)(local_d8._0_8_ + 0x38) = 0;
  local_d8._8_8_ = local_c8;
  local_2c0 = 0;
  auVar46 = ZEXT464(0x7fc00000);
  lVar20 = (ulonglong)uVar25 + param_3;
  uVar16 = (undefined4)local_2c8;
  uVar30 = (undefined4)local_2c8;
  do {
    auVar46 = ZEXT1664(auVar46._0_16_);
    plVar18 = (longlong *)FUN_1804258b0(lVar20,(&DAT_180d0f540)[local_2c0]);
    stack0xffffffffffffff0c = SUB1612((undefined1  [16])0x0,4);
    local_f8._0_6_ = 0x6c6c657073;
    local_2d8 = plVar18;
    cVar11 = (**(code **)(*plVar18 + 0x10))(plVar18);
    if (cVar11 == '\0') {
      bVar8 = false;
      bVar10 = false;
      lVar20 = local_280;
    }
    else {
      lVar20 = (**(code **)(*plVar18 + 0x18))(plVar18);
      uVar4 = *(undefined8 *)(param_1 + 0x480);
      puVar26 = (undefined8 *)(((ulonglong)(DAT_180d433ec + 0xe6632e3a) ^ 0x11bf48c) + lVar20);
      local_280 = lVar20;
      cVar11 = FUN_1801fa260(puVar26);
      if (cVar11 == '\0') {
        iVar14 = FUN_180973810(&DAT_180d6eb78);
        if (iVar14 != 0) {
                    /* WARNING: Subroutine does not return */
          FUN_1809737c0(5);
        }
        if (DAT_180d6ebc4 == 0x7fffffff) {
          DAT_180d6ebc4 = 0x7ffffffe;
                    /* WARNING: Subroutine does not return */
          FUN_1809737c0(6);
        }
        local_2e8[0] = 0;
        FUN_180185e60(&DAT_180d6eb28,local_2e8);
        local_148 = (undefined8 *)CONCAT44(local_148._4_4_,0x2a);
        FUN_1801877a0(&DAT_180d6eb28,&local_148,4);
        FUN_1801877a0(&DAT_180d6eb28,&DAT_180d10020,0x2a);
        local_278[0] = _Xtime_get_ticks();
        uVar23 = 0;
        puStack_140 = local_278;
        local_138 = FUN_180191210;
        local_148 = (undefined8 *)0xd000000000000000;
        local_118 = (code *)0x0;
        local_110 = 0xf;
        stack0xfffffffffffffed9 = SUB1615((undefined1  [16])0x0,1);
        auVar6[0xf] = 0;
        auVar6._0_15_ = stack0xfffffffffffffed9;
        _local_128 = auVar6 << 8;
        FUN_18019f7a0(local_128,0x11);
        local_268 = 1;
        local_260 = &local_148;
        local_258 = &DAT_180c09610;
        local_250 = 9;
        local_388 = 0;
        FUN_18018ad00(local_1b8,local_128,&local_258,&local_268);
        local_148._0_4_ = 1;
        FUN_180185f70(&DAT_180d6eb28,&local_148);
        local_148._0_4_ = local_118._0_4_;
        FUN_1801877a0(&DAT_180d6eb28,&local_148,4);
        auVar22 = (undefined1  [8])local_128;
        if (0xf < local_110) {
          auVar22 = local_128;
        }
        FUN_1801877a0(&DAT_180d6eb28,auVar22,local_118);
        local_148._0_4_ = 0;
        FUN_180185f70(&DAT_180d6eb28,&local_148);
        local_148 = (undefined8 *)CONCAT44(local_148._4_4_,8);
        FUN_1801877a0(&DAT_180d6eb28,&local_148,4);
        local_148 = puVar26;
        FUN_1801877a0(&DAT_180d6eb28,&local_148,8);
        if (DAT_180d6ebe0 != '\0') {
          local_148 = (undefined8 *)
                      CONCAT44(local_148._4_4_,(int)DAT_180d6eb30 - (int)DAT_180d6eb28);
          FUN_1803c9190(&DAT_180d6ebc8,local_1a8,&local_148,4);
          FUN_1803c9190(&DAT_180d6ebc8,local_198,CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28),
                        DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28));
        }
        DAT_180d6eb70 = DAT_180d6eb70 + 1;
        local_248 = CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
        local_240 = DAT_180d6eb30 - local_248;
        FUN_1801806e0(&DAT_180d6eb40,&local_248);
        local_108 = ((int)DAT_180d6eb30 - (int)DAT_180d6eb28) + 4;
        FUN_180186fb0(&DAT_180d6ea20,&local_108,4);
        FUN_180186fb0(&DAT_180d6ea20,CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28),
                      DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28));
        FUN_180186e20(&DAT_180d6ea20);
        if (CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28) != DAT_180d6eb30) {
          DAT_180d6eb30 = CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
        }
        if (0xf < local_110) {
          uVar24 = local_110 + 1;
          auVar22 = local_128;
          if (0xfff < uVar24) {
            auVar22 = *(undefined1 (*) [8])((longlong)local_128 + -8);
            if (0x1f < ((longlong)local_128 - (longlong)auVar22) - 8U) {
              pcVar5 = (code *)swi(0x29);
              (*pcVar5)(5);
              puVar28 = auStack_3a0;
              break;
            }
            uVar24 = local_110 + 0x28;
          }
          thunk_FUN_180895720(auVar22,uVar24);
        }
        local_118 = (code *)0x0;
        local_110 = 0xf;
        auVar7[0xf] = 0;
        auVar7._0_15_ = stack0xfffffffffffffed9;
        _local_128 = auVar7 << 8;
        FUN_180973930(&DAT_180d6eb78);
        local_238 = &DAT_180c0f302;
      }
      else {
        local_238 = (undefined1 *)*puVar26;
        uVar23 = (ulonglong)*(uint *)(puVar26 + 1);
      }
      bVar8 = true;
      local_230 = uVar23;
      puVar19 = (undefined4 *)FUN_180433ef0(uVar4,local_2e4,&local_238);
      uVar16 = *puVar19;
      bVar10 = true;
    }
    uVar31 = 0;
    if (bVar10) {
      uVar31 = uVar16;
    }
    if (bVar8) {
      if (DAT_180d43858 == '\0') {
        uVar25 = DAT_180d433f0 + 0xe6632e3aU ^ 0x11bf48c;
      }
      else {
        uVar25 = FUN_18052b510(&DAT_180d433f0);
      }
      lVar20 = *(longlong *)(lVar20 + (ulonglong)uVar25);
      cVar11 = FUN_1801fa260(lVar20);
      if (cVar11 == '\0') {
        iVar14 = FUN_180973810(&DAT_180d6eb78);
        if (iVar14 != 0) {
                    /* WARNING: Subroutine does not return */
          FUN_1809737c0(5);
        }
        if (DAT_180d6ebc4 == 0x7fffffff) {
          DAT_180d6ebc4 = 0x7ffffffe;
                    /* WARNING: Subroutine does not return */
          FUN_1809737c0(6);
        }
        local_2e8[0] = 0;
        FUN_180185e60(&DAT_180d6eb28,local_2e8);
        local_148 = (undefined8 *)CONCAT44(local_148._4_4_,0x1e);
        FUN_1801877a0(&DAT_180d6eb28,&local_148,4);
        FUN_1801877a0(&DAT_180d6eb28,&DAT_180d10070,0x1e);
        local_2a0 = _Xtime_get_ticks();
        puStack_140 = &local_2a0;
        local_138 = FUN_180191210;
        local_148 = (undefined8 *)0xd000000000000000;
        local_118 = (code *)0x0;
        local_110 = 0xf;
        stack0xfffffffffffffed9 = SUB1615((undefined1  [16])0x0,1);
        auVar9[0xf] = 0;
        auVar9._0_15_ = stack0xfffffffffffffed9;
        _local_128 = auVar9 << 8;
        FUN_18019f7a0(local_128,0x11);
        local_228 = 1;
        local_220 = &local_148;
        local_218 = &DAT_180c09610;
        local_210 = 9;
        local_388 = 0;
        FUN_18018ad00(local_1b0,local_128,&local_218,&local_228);
        local_148._0_4_ = 1;
        FUN_180185f70(&DAT_180d6eb28,&local_148);
        local_148 = (undefined8 *)CONCAT44(local_148._4_4_,local_118._0_4_);
        FUN_1801877a0(&DAT_180d6eb28,&local_148,4);
        auVar22 = (undefined1  [8])local_128;
        if (0xf < local_110) {
          auVar22 = local_128;
        }
        FUN_1801877a0(&DAT_180d6eb28,auVar22,local_118);
        if (DAT_180d6ebe0 != '\0') {
          local_148 = (undefined8 *)
                      CONCAT44(local_148._4_4_,(int)DAT_180d6eb30 - (int)DAT_180d6eb28);
          FUN_1803c9190(&DAT_180d6ebc8,local_188,&local_148,4);
          FUN_1803c9190(&DAT_180d6ebc8,local_178,CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28),
                        DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28));
        }
        DAT_180d6eb70 = DAT_180d6eb70 + 1;
        local_208 = CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
        local_200 = DAT_180d6eb30 - local_208;
        FUN_1801806e0(&DAT_180d6eb40,&local_208);
        local_104 = ((int)DAT_180d6eb30 - (int)DAT_180d6eb28) + 4;
        FUN_180186fb0(&DAT_180d6ea20,&local_104,4);
        FUN_180186fb0(&DAT_180d6ea20,CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28),
                      DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28));
        FUN_180186e20(&DAT_180d6ea20);
        if (CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28) != DAT_180d6eb30) {
          DAT_180d6eb30 = CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
        }
        FUN_1801a2650(local_128);
        FUN_180973930(&DAT_180d6eb78);
        goto LAB_18043cc2f;
      }
      bVar8 = true;
      local_1f8 = lVar20;
    }
    else {
LAB_18043cc2f:
      bVar8 = false;
    }
    lVar20 = local_1f8;
    if (bVar8) {
      uVar4 = *(undefined8 *)(param_1 + 0x480);
      if (DAT_180d43cc8 == '\0') {
        uVar25 = DAT_180d43860 + 0xe6632e3aU ^ 0x11bf48c;
      }
      else {
        uVar25 = FUN_18052b510(&DAT_180d43860);
      }
      puVar26 = *(undefined8 **)(lVar20 + (ulonglong)uVar25);
      if (DAT_180d43cc8 == '\0') {
        uVar25 = DAT_180d43860 + 0xe6632e3aU ^ 0x11bf48c;
      }
      else {
        uVar25 = FUN_18052b510(&DAT_180d43860);
      }
      if ((*(char *)(lVar20 + (ulonglong)(uVar25 + 8)) == '\0') || (puVar26 == (undefined8 *)0x0)) {
LAB_18043cfc4:
        puStack_2b0 = (undefined8 *)0x0;
        local_2b8 = (undefined8 *)&DAT_180c0f302;
      }
      else {
        cVar11 = FUN_1801fa260(puVar26);
        if (cVar11 == '\0') {
          FUN_18019fb70(&DAT_180d6eb78);
          local_2e8[0] = 0;
          FUN_180185e60(&DAT_180d6eb28,local_2e8);
          local_148 = (undefined8 *)CONCAT44(local_148._4_4_,0x1a);
          FUN_1801877a0(&DAT_180d6eb28,&local_148,4);
          FUN_1801877a0(&DAT_180d6eb28,&DAT_180d10050,0x1a);
          local_298 = _Xtime_get_ticks();
          local_118 = FUN_180191210;
          puStack_120 = &local_298;
          local_128 = (undefined1  [8])0xd000000000000000;
          local_1e8 = &DAT_180c09610;
          uStack_1e0 = 9;
          local_1d8 = 1;
          local_1d0 = local_128;
          local_148 = (undefined8 *)&DAT_180c09610;
          puStack_140 = (undefined8 *)0x9;
          FUN_1801858b0(local_f8,&local_148,&local_1d8);
          local_148._0_4_ = 1;
          FUN_180185f70(&DAT_180d6eb28,&local_148);
          local_148._0_4_ = local_e8;
          FUN_1801877a0(&DAT_180d6eb28,&local_148,4);
          auVar22 = (undefined1  [8])local_f8;
          if (0xf < local_e0) {
            auVar22 = local_f8;
          }
          FUN_1801877a0(&DAT_180d6eb28,auVar22,CONCAT44(uStack_e4,local_e8));
          if (DAT_180d6ebe0 != '\0') {
            local_148._0_4_ = (int)DAT_180d6eb30 - (int)DAT_180d6eb28;
            FUN_1803c9190(&DAT_180d6ebc8,local_168,&local_148,4);
            FUN_1803c9190(&DAT_180d6ebc8,local_158,CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28),
                          DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28));
          }
          DAT_180d6eb70 = DAT_180d6eb70 + 1;
          local_1c8 = CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
          local_1c0 = DAT_180d6eb30 - local_1c8;
          FUN_1801806e0(&DAT_180d6eb40,&local_1c8);
          local_100[0] = ((int)DAT_180d6eb30 - (int)DAT_180d6eb28) + 4;
          FUN_180186fb0(&DAT_180d6ea20,local_100,4);
          FUN_180186fb0(&DAT_180d6ea20,CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28),
                        DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28));
          FUN_180186e20(&DAT_180d6ea20);
          if (CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28) != DAT_180d6eb30) {
            DAT_180d6eb30 = CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
          }
          FUN_1801a2650(local_f8);
          FUN_180973930(&DAT_180d6eb78);
          goto LAB_18043cfc4;
        }
        local_2b8 = (undefined8 *)*puVar26;
        puStack_2b0 = (undefined8 *)(ulonglong)*(uint *)(puVar26 + 1);
      }
      local_148 = local_2b8;
      puStack_140 = puStack_2b0;
      puVar19 = (undefined4 *)FUN_180433ef0(uVar4,local_2dc,&local_148);
      uVar30 = *puVar19;
      bVar8 = true;
    }
    else {
      bVar8 = false;
    }
    uVar17 = 0;
    if (bVar8) {
      uVar17 = uVar30;
    }
    if ((*(byte *)(param_1 + 0x488) & 4) == 0) {
      auVar45 = ZEXT1664(auVar46._0_16_);
    }
    else {
      auVar45 = ZEXT464(*(uint *)((longlong)plVar18 +
                                 ((ulonglong)(DAT_180d41db0 + 0xe6632e3a) ^ 0x11bf48c)));
    }
    if (DAT_180d41058 == '\0') {
      uVar23 = _DAT_180d40bf0 + 0x6df70a65e6632e3aU ^ 0xbcd1994011bf48c;
    }
    else {
      uVar23 = FUN_18052c740(&DAT_180d40bf0,0);
    }
    cVar11 = (*(code *)(DAT_180d20bd0 + uVar23))(plVar18);
    if (cVar11 == '\0') {
      lVar20 = FUN_1801f3220(&DAT_180d41060);
      cVar11 = (*(code *)(lVar20 + DAT_180d20bd0))(plVar18);
      if (cVar11 != '\0') goto LAB_18043d0a6;
      uVar12 = 0;
    }
    else {
LAB_18043d0a6:
      uVar12 = 1;
    }
    uVar32 = FUN_180433ce0(plVar18);
    if (DAT_180d42220 == '\0') {
      uVar25 = DAT_180d41db8 + 0xe6632e3aU ^ 0x11bf48c;
    }
    else {
      uVar25 = FUN_18052b510(&DAT_180d41db8);
    }
    local_2e8[0] = *(undefined1 *)((longlong)plVar18 + (ulonglong)uVar25);
    if (DAT_180d41938 == '\0') {
      uVar25 = DAT_180d414d0 + 0xe6632e3aU ^ 0x11bf48c;
    }
    else {
      uVar25 = FUN_18052b510(&DAT_180d414d0);
    }
    uVar1 = *(undefined1 *)((longlong)plVar18 + (ulonglong)uVar25);
    if (DAT_180d433e0 == '\0') {
      uVar25 = DAT_180d42f78 + 0xe6632e3aU ^ 0x11bf48c;
    }
    else {
      uVar25 = FUN_18052b510(&DAT_180d42f78);
    }
    uVar2 = *(undefined2 *)((longlong)plVar18 + (ulonglong)uVar25);
    if (DAT_180d42b00 == '\0') {
      uVar25 = DAT_180d42698 + 0xe6632e3aU ^ 0x11bf48c;
    }
    else {
      uVar25 = FUN_18052b510(&DAT_180d42698);
    }
    auVar44 = ZEXT464(*(uint *)((longlong)local_2d8 + (ulonglong)uVar25));
    if (DAT_180d42690 == '\0') {
      uVar25 = DAT_180d42228 + 0xe6632e3aU ^ 0x11bf48c;
    }
    else {
      uVar25 = FUN_18052b510(&DAT_180d42228);
    }
    auVar43 = ZEXT464(*(uint *)((longlong)local_2d8 + (ulonglong)uVar25));
    if (DAT_180d42f70 == '\0') {
      uVar25 = DAT_180d42b08 + 0xe6632e3aU ^ 0x11bf48c;
    }
    else {
      uVar25 = FUN_18052b510(&DAT_180d42b08);
    }
    auVar42 = ZEXT464(*(uint *)((longlong)local_2d8 + (ulonglong)uVar25));
    if (DAT_180d41da8 == '\0') {
      uVar15 = DAT_180d41940 + 0xe6632e3aU ^ 0x11bf48c;
      local_348 = uVar32;
      local_368 = auVar45._0_4_;
      local_370 = auVar44._0_4_;
      local_378 = auVar43._0_4_;
      local_380 = *(uint *)((longlong)local_2d8 + (ulonglong)uVar25);
    }
    else {
      uVar15 = FUN_18052b510(&DAT_180d41940);
      local_348 = uVar32;
      local_380 = auVar42._0_4_;
      local_378 = auVar43._0_4_;
      local_370 = auVar44._0_4_;
      local_368 = auVar45._0_4_;
    }
    param_1 = local_2d0;
    local_350 = local_2e8[0];
    local_388 = CONCAT44(local_388._4_4_,*(undefined4 *)((longlong)local_2d8 + (ulonglong)uVar15));
    local_360 = uVar2;
    local_358 = uVar1;
    local_340 = uVar12;
    FUN_180435270(&local_2e0,*(undefined8 *)(local_2d0 + 0x480),uVar31,uVar17);
    *(undefined4 *)(local_d8._0_8_ + local_2c0 * 4) = local_2e0;
    local_2c0 = local_2c0 + 1;
    lVar20 = local_288;
  } while (local_2c0 < 0x10);
  puVar19 = *(undefined4 **)(puVar28 + 0x2d0);
  lVar20 = (longlong)*(undefined4 **)(puVar28 + 0x2d8) - (longlong)puVar19 >> 2;
  puVar29 = &DAT_180d6e9e3;
  if (puVar19 != *(undefined4 **)(puVar28 + 0x2d8)) {
    puVar29 = puVar19;
  }
  uVar4 = *(undefined8 *)(puVar28 + 0x118);
  *(undefined8 *)(puVar28 + -8) = 0x18043d30a;
  FUN_1801c3f20(uVar4,lVar20,4);
  lVar27 = lVar20;
  while (lVar27 != 0) {
    lVar27 = lVar27 + -1;
    uVar16 = puVar29[lVar27];
    *(undefined8 *)(puVar28 + -8) = 0x18043d320;
    uVar16 = FUN_1801c3e60(uVar4,uVar16);
    *(undefined8 *)(puVar28 + -8) = 0x18043d32a;
    FUN_1801bece0(uVar4,uVar16);
  }
  *(undefined8 *)(puVar28 + -8) = 0x18043d33a;
  uVar16 = FUN_1801bf100(uVar4,lVar20);
  *(undefined8 *)(puVar28 + -8) = 0x18043d34a;
  FUN_1801a2440(puVar28 + 0x2d0);
  uVar4 = *(undefined8 *)(puVar28 + 0x100);
  *(undefined8 *)(puVar28 + -8) = 0x18043d35b;
  uVar21 = FUN_1804322b0(uVar4);
  *(undefined8 *)(puVar28 + -8) = 0x18043d36e;
  FUN_18043b360(param_1,puVar28 + 0x2a8,uVar21);
  *(undefined8 *)(puVar28 + -8) = 0x18043d381;
  FUN_18043b230(param_1,puVar28 + 200,uVar4);
  *(undefined8 *)(puVar28 + -8) = 0x18043d392;
  cVar11 = FUN_180393770(param_1 + 0x488,2);
  if (cVar11 == '\0') {
    uVar30 = 0;
    uVar31 = 0;
  }
  else {
    *(undefined8 *)(puVar28 + -8) = 0x18043d39e;
    uVar21 = FUN_180432200(uVar4);
    *(undefined8 *)(puVar28 + -8) = 0x18043d3b1;
    puVar19 = (undefined4 *)FUN_18043b5c0(param_1,puVar28 + 0xc4,uVar21);
    uVar30 = *puVar19;
    *(undefined8 *)(puVar28 + -8) = 0x18043d3c7;
    puVar19 = (undefined4 *)FUN_18043bbb0(param_1,puVar28 + 0xc4,uVar4);
    uVar31 = *puVar19;
  }
  *(undefined8 *)(puVar28 + -8) = 0x18043d3da;
  uVar17 = FUN_180424b50(uVar4);
  *(undefined4 *)(puVar28 + 0xc4) = uVar17;
  *(undefined8 *)(puVar28 + -8) = 0x18043d3e9;
  fVar33 = (float)FUN_180424c40(uVar4);
  *(int *)(puVar28 + 0xcc) = (int)fVar33;
  *(undefined8 *)(puVar28 + -8) = 0x18043d3fc;
  uVar17 = FUN_1804326f0(uVar4);
  *(undefined4 *)(puVar28 + 0x2a4) = uVar17;
  *(undefined8 *)(puVar28 + -8) = 0x18043d40b;
  uVar17 = FUN_180432630(uVar4);
  *(undefined4 *)(puVar28 + 0x2a0) = uVar17;
  *(undefined8 *)(puVar28 + -8) = 0x18043d41a;
  uVar17 = FUN_180432570(uVar4);
  *(undefined4 *)(puVar28 + 0x260) = uVar17;
  uVar17 = *(undefined4 *)(puVar28 + 200);
  uVar32 = *(undefined4 *)(puVar28 + 0x2a8);
  *(undefined8 *)(puVar28 + -8) = 0x18043d437;
  uVar34 = FUN_180431f00(uVar4);
  *(undefined8 *)(puVar28 + -8) = 0x18043d443;
  uVar12 = FUN_1804318b0(uVar4);
  puVar28[0xc0] = uVar12;
  *(undefined8 *)(puVar28 + -8) = 0x18043d452;
  uVar35 = FUN_180431820(uVar4);
  *(undefined8 *)(puVar28 + -8) = 0x18043d45e;
  uVar36 = FUN_1804317d0(uVar4);
  *(undefined8 *)(puVar28 + -8) = 0x18043d46a;
  uVar37 = FUN_1804319d0(uVar4);
  *(undefined8 *)(puVar28 + -8) = 0x18043d476;
  uVar38 = FUN_180431f50(uVar4);
  *(undefined8 *)(puVar28 + -8) = 0x18043d482;
  uVar39 = FUN_180431600(uVar4);
  *(undefined8 *)(puVar28 + -8) = 0x18043d48e;
  uVar40 = FUN_1804315b0(uVar4);
  *(undefined8 *)(puVar28 + -8) = 0x18043d49a;
  uVar41 = FUN_180432300(uVar4);
  *(undefined8 *)(puVar28 + -8) = 0x18043d4a3;
  uVar21 = FUN_1804327b0();
  *(undefined8 *)(puVar28 + -8) = 0x18043d4ab;
  bVar13 = FUN_1804309c0(uVar21,uVar4);
  *(undefined8 *)(puVar28 + -8) = 0x18043d4ca;
  puVar19 = (undefined4 *)FUN_180439a70(*(undefined8 *)(puVar28 + 0xd8),puVar28 + 0xe8,uVar4,1);
  uVar3 = *puVar19;
  *(undefined8 *)(puVar28 + -8) = 0x18043d4e9;
  puVar19 = (undefined4 *)
            FUN_1804395d0(*(undefined8 *)(puVar28 + 0xd8),puVar28 + 0xd0,
                          *(undefined8 *)(puVar28 + 0x100));
  *(undefined4 *)(puVar28 + 0xb8) = *(undefined4 *)(puVar28 + 0x2a4);
  *(undefined4 *)(puVar28 + 0xb0) = *(undefined4 *)(puVar28 + 0x2a0);
  *(undefined4 *)(puVar28 + 0xa8) = *(undefined4 *)(puVar28 + 0x260);
  *(undefined4 *)(puVar28 + 0xa0) = *(undefined4 *)(puVar28 + 0xcc);
  *(undefined4 *)(puVar28 + 0x98) = *(undefined4 *)(puVar28 + 0xc4);
  *(undefined4 *)(puVar28 + 0x90) = uVar31;
  *(undefined4 *)(puVar28 + 0x88) = uVar30;
  *(undefined4 *)(puVar28 + 0x80) = uVar17;
  *(undefined4 *)(puVar28 + 0x78) = uVar32;
  *(undefined4 *)(puVar28 + 0x70) = uVar16;
  *(undefined4 *)(puVar28 + 0x68) = uVar34;
  puVar28[0x60] = puVar28[0xc0];
  *(undefined4 *)(puVar28 + 0x58) = uVar35;
  *(undefined4 *)(puVar28 + 0x50) = uVar36;
  *(undefined4 *)(puVar28 + 0x48) = uVar37;
  *(undefined4 *)(puVar28 + 0x40) = uVar38;
  *(undefined4 *)(puVar28 + 0x38) = uVar39;
  *(undefined4 *)(puVar28 + 0x30) = uVar40;
  *(undefined4 *)(puVar28 + 0x28) = uVar41;
  *(uint *)(puVar28 + 0x20) = (uint)bVar13;
  uVar16 = *puVar19;
  uVar4 = *(undefined8 *)(*(longlong *)(puVar28 + 0xd8) + 0x480);
  uVar21 = *(undefined8 *)(puVar28 + 0xe0);
  *(undefined8 *)(puVar28 + -8) = 0x18043d5b5;
  FUN_180437690(uVar21,uVar4,uVar16,uVar3);
  *(undefined8 *)(puVar28 + -8) = 0x18043d5c8;
  return uVar21;
}

