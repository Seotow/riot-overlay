// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1803c0440; descriptive alias: tcp_accept_loop
// Evidence: ev_d66fbc3498615eca4b2ba52d35ce1c52e08c1cccb0d732fb61e97b96a2451492
// Original Evidence: rea-ipc-accept-loop.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* WARNING: Removing unreachable block (ram,0x0001803c069a) */
/* WARNING: Removing unreachable block (ram,0x0001803c0679) */
/* WARNING: Removing unreachable block (ram,0x0001803c0adb) */
/* WARNING: Removing unreachable block (ram,0x0001803c1049) */
/* WARNING: Removing unreachable block (ram,0x0001803c0afc) */
/* WARNING: Removing unreachable block (ram,0x0001803c06a2) */
/* WARNING: Removing unreachable block (ram,0x0001803c1067) */
/* WARNING: Removing unreachable block (ram,0x0001803c0b04) */
/* WARNING: Removing unreachable block (ram,0x0001803c106f) */

void FUN_1803c0440(longlong *param_1,longlong param_2,longlong *param_3)

{
  code *pcVar1;
  undefined1 auVar2 [16];
  undefined1 auVar3 [16];
  undefined1 auVar4 [16];
  undefined1 auVar5 [16];
  undefined1 auVar6 [16];
  undefined1 auVar7 [16];
  int iVar8;
  undefined4 uVar9;
  char *_Str;
  size_t sVar10;
  size_t *psVar11;
  undefined8 uVar12;
  longlong lVar13;
  int *piVar14;
  ulonglong uVar15;
  undefined1 *puVar16;
  undefined1 *puVar17;
  undefined1 *puVar18;
  uint uVar19;
  undefined8 uStack_470;
  undefined1 auStack_468 [8];
  undefined1 auStack_460 [24];
  undefined8 *local_448 [2];
  undefined1 local_438 [8];
  size_t local_430;
  undefined2 local_428;
  undefined6 uStack_426;
  undefined2 local_420;
  undefined4 uStack_41e;
  undefined2 uStack_41a;
  undefined1 local_418;
  undefined8 local_410;
  undefined1 local_408 [16];
  undefined *local_3f8;
  longlong local_3f0;
  undefined1 local_3e8 [16];
  undefined *local_3d8;
  size_t *local_3d0;
  undefined1 local_3c8 [16];
  undefined8 local_3b8;
  longlong local_3b0;
  size_t *local_3a8 [2];
  undefined8 local_398;
  size_t *local_390;
  undefined *local_388;
  undefined8 local_380;
  longlong local_378;
  longlong local_370;
  longlong *local_368;
  longlong *local_360;
  undefined1 local_358 [8];
  undefined1 local_350 [8];
  undefined1 local_348 [16];
  undefined1 local_338 [16];
  undefined1 local_328 [16];
  int local_318 [2];
  size_t *local_310;
  undefined8 local_308;
  undefined1 local_300 [16];
  size_t local_2f0;
  ulonglong local_2e8;
  int local_2e0 [2];
  ulonglong local_2d8;
  undefined2 local_2d0;
  undefined8 local_2ce;
  undefined4 local_2c6;
  undefined2 local_2c2;
  undefined1 local_2c0;
  char local_2b8;
  ulonglong local_2b0;
  undefined2 local_2a8;
  undefined8 local_2a6;
  undefined4 local_29e;
  undefined2 local_29a;
  undefined1 local_298;
  undefined8 local_290;
  undefined4 local_288 [2];
  longlong local_280;
  undefined1 local_278 [512];
  undefined1 local_78 [24];
  undefined1 local_60 [24];
  ulonglong local_48;
  
  puVar17 = auStack_468;
  puVar18 = auStack_468;
  local_48 = DAT_180d06cc0 ^ (ulonglong)auStack_468;
  uVar19 = 0;
  local_308 = local_308 & 0xffffffff00000000;
  iVar8 = *(int *)(param_2 + 0x238);
  local_360 = param_3;
  local_3b0 = param_2;
  local_368 = param_1;
  while (iVar8 != 0) {
    sVar10 = 0;
    if ((*param_1 != 0) && ((*(uint *)(*param_1 + 4) & 1) != 0)) break;
    local_290 = 1;
    local_288[0] = 1;
    local_280 = *param_3;
    FUN_1809bef30(local_278,0,0x1f8);
    local_448[0] = &local_290;
    iVar8 = Ordinal_18(1,local_288,0,0);
    if (iVar8 == -1) {
LAB_1803c0f58:
      *(undefined1 (*) [16])(puVar18 + 0x60) = (undefined1  [16])0x0;
      *(undefined8 **)(puVar18 + 0x60) = &DAT_180d6eb78;
      puVar18[0x68] = 0;
      *(undefined8 *)(puVar18 + -8) = 0x1803c0f7b;
      iVar8 = FUN_180973810(&DAT_180d6eb78);
      if (iVar8 != 0) {
                    /* WARNING: Subroutine does not return */
        *(undefined8 *)(puVar18 + -8) = 0x1803c153b;
        FUN_1809737c0(5);
      }
      if (DAT_180d6ebc4 == 0x7fffffff) {
LAB_1803c151e:
        DAT_180d6ebc4 = DAT_180d6ebc4 + -1;
                    /* WARNING: Subroutine does not return */
        *(undefined **)(puVar18 + -8) = &UNK_1803c1530;
        FUN_1809737c0(6);
      }
      puVar18[0x68] = 1;
      puVar18[0x30] = 0;
      *(undefined8 *)(puVar18 + -8) = 0x1803c0faf;
      FUN_180185e60(&DAT_180d6eb28,puVar18 + 0x30);
      local_318[0] = 0x14;
      *(undefined8 *)(puVar18 + -8) = 0x1803c0fcc;
      FUN_1801877a0(&DAT_180d6eb28,local_318,4);
      *(undefined8 *)(puVar18 + -8) = 0x1803c0fe5;
      FUN_1801877a0(&DAT_180d6eb28,&DAT_180d0dd10,0x14);
      *(undefined8 *)(puVar18 + -8) = 0x1803c0fea;
      uVar12 = _Xtime_get_ticks();
      *(undefined8 *)(puVar18 + 0x58) = uVar12;
      *(size_t *)(puVar18 + 0x38) = sVar10;
      *(undefined1 **)(puVar18 + 0x40) = puVar18 + 0x58;
      *(code **)(puVar18 + 0x48) = FUN_180191210;
      *(undefined8 *)(puVar18 + 0x38) = 0xd000000000000000;
      local_2e8 = 0xf;
      local_300._1_15_ = SUB1615((undefined1  [16])0x0,1);
      auVar6[0xf] = 0;
      auVar6._0_15_ = local_300._1_15_;
      local_300 = auVar6 << 8;
      local_308 = CONCAT44(local_308._4_4_,uVar19) | 2;
      *(undefined8 *)(puVar18 + -8) = 0x1803c107f;
      local_2f0 = sVar10;
      FUN_18019f7a0(local_300,0x11);
      local_3e8._8_8_ = puVar18 + 0x38;
      local_3e8._0_8_ = 1;
      *(undefined **)(puVar18 + 0x70) = &DAT_180c09610;
      *(undefined8 *)(puVar18 + 0x78) = 9;
      *(size_t *)(puVar18 + 0x20) = sVar10;
      *(undefined8 *)(puVar18 + -8) = 0x1803c10c0;
      FUN_18018ad00(local_3a8,local_300,puVar18 + 0x70,local_3e8);
      local_318[0] = 1;
      *(undefined8 *)(puVar18 + -8) = 0x1803c10d8;
      FUN_180185f70(&DAT_180d6eb28,local_318);
      local_318[0] = (int)local_2f0;
      *(undefined8 *)(puVar18 + -8) = 0x1803c10f4;
      FUN_1801877a0(&DAT_180d6eb28,local_318,4);
      puVar16 = local_300;
      if (0xf < local_2e8) {
        puVar16 = (undefined1 *)local_300._0_8_;
      }
      *(undefined8 *)(puVar18 + -8) = 0x1803c1115;
      FUN_1801877a0(&DAT_180d6eb28,puVar16,local_2f0);
      if (DAT_180d6ebe0 != '\0') {
        local_318[0] = (int)DAT_180d6eb30 - (int)DAT_180d6eb28;
        *(undefined8 *)(puVar18 + -8) = 0x1803c1147;
        FUN_1803c9190(&DAT_180d6ebc8,local_3c8,local_318,4);
        *(undefined8 *)(puVar18 + -8) = 0x1803c1168;
        FUN_1803c9190(&DAT_180d6ebc8,local_3c8,CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28),
                      DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28));
      }
      DAT_180d6eb70 = DAT_180d6eb70 + 1;
      local_3e8._8_8_ = DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
      local_3e8._0_8_ = CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
      *(undefined8 *)(puVar18 + -8) = 0x1803c11a3;
      FUN_1801806e0(&DAT_180d6eb40,local_3e8);
      local_2e0[0] = ((int)DAT_180d6eb30 - (int)DAT_180d6eb28) + 4;
      *(undefined8 *)(puVar18 + -8) = 0x1803c11d1;
      FUN_180186fb0(&DAT_180d6ea20,local_2e0,4);
      *(undefined8 *)(puVar18 + -8) = 0x1803c11ee;
      FUN_180186fb0(&DAT_180d6ea20,CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28),
                    DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28));
      *(undefined8 *)(puVar18 + -8) = 0x1803c11fa;
      FUN_180186e20(&DAT_180d6ea20);
      if (CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28) != DAT_180d6eb30) {
        DAT_180d6eb30 = CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
      }
      if (0xf < local_2e8) {
        uVar15 = local_2e8 + 1;
        lVar13 = local_300._0_8_;
        if (0xfff < uVar15) {
          lVar13 = *(longlong *)(local_300._0_8_ + -8);
          if (0x1f < (local_300._0_8_ - lVar13) - 8U) {
            pcVar1 = (code *)swi(0x29);
            DAT_180d6ebc4 = (*pcVar1)(5);
            puVar18 = puVar18 + 8;
            goto LAB_1803c151e;
          }
          uVar15 = local_2e8 + 0x28;
        }
        *(undefined8 *)(puVar18 + -8) = 0x1803c124f;
        thunk_FUN_180895720(lVar13,uVar15);
      }
      local_2e8 = 0xf;
      auVar7[0xf] = 0;
      auVar7._0_15_ = local_300._1_15_;
      local_300 = auVar7 << 8;
      *(undefined8 *)(puVar18 + -8) = 0x1803c126a;
      local_2f0 = sVar10;
      FUN_180973930(&DAT_180d6eb78);
      *(undefined8 *)(puVar18 + -8) = 0x1803c1270;
      iVar8 = Ordinal_111();
      local_3e8 = ZEXT816(0x180d6eb78);
      *(undefined8 *)(puVar18 + -8) = 0x1803c1287;
      FUN_18019fb70(&DAT_180d6eb78);
      local_3e8[8] = 1;
      puVar18[0x30] = 0;
      *(undefined8 *)(puVar18 + -8) = 0x1803c12a1;
      FUN_180185e60(&DAT_180d6eb28,puVar18 + 0x30);
      local_318[0] = 0x2b;
      *(undefined8 *)(puVar18 + -8) = 0x1803c12be;
      FUN_1801877a0(&DAT_180d6eb28,local_318,4);
      *(undefined8 *)(puVar18 + -8) = 0x1803c12d7;
      FUN_1801877a0(&DAT_180d6eb28,&DAT_180d0dbf0,0x2b);
      *(undefined8 *)(puVar18 + -8) = 0x1803c12dc;
      uVar12 = _Xtime_get_ticks();
      *(undefined8 *)(puVar18 + 0x58) = uVar12;
      *(undefined8 *)(puVar18 + 0x38) = 0;
      *(undefined1 **)(puVar18 + 0x40) = puVar18 + 0x58;
      *(code **)(puVar18 + 0x48) = FUN_180191210;
      *(undefined8 *)(puVar18 + 0x38) = 0xd000000000000000;
      *(undefined8 *)(puVar18 + 0x70) = 1;
      *(undefined1 **)(puVar18 + 0x78) = puVar18 + 0x38;
      local_3d8 = &DAT_180c09610;
      local_3d0 = (size_t *)&DAT_00000009;
      *(undefined8 *)(puVar18 + -8) = 0x1803c1341;
      FUN_1801858b0(local_300,&local_3d8,puVar18 + 0x70);
      local_318[0] = 1;
      *(undefined8 *)(puVar18 + -8) = 0x1803c1359;
      FUN_180185f70(&DAT_180d6eb28,local_318);
      local_318[0] = (int)local_2f0;
      *(undefined8 *)(puVar18 + -8) = 0x1803c1375;
      FUN_1801877a0(&DAT_180d6eb28,local_318,4);
      puVar16 = local_300;
      if (0xf < local_2e8) {
        puVar16 = (undefined1 *)local_300._0_8_;
      }
      *(undefined8 *)(puVar18 + -8) = 0x1803c1396;
      FUN_1801877a0(&DAT_180d6eb28,puVar16,local_2f0);
      local_318[0] = 0;
      *(undefined8 *)(puVar18 + -8) = 0x1803c13a9;
      FUN_180185f70(&DAT_180d6eb28,local_318);
      local_318[0] = 4;
      *(undefined8 *)(puVar18 + -8) = 0x1803c13c6;
      FUN_1801877a0(&DAT_180d6eb28,local_318,4);
      *(undefined8 *)(puVar18 + -8) = 0x1803c13df;
      local_318[0] = iVar8;
      FUN_1801877a0(&DAT_180d6eb28,local_318,4);
      if (DAT_180d6ebe0 != '\0') {
        local_318[0] = (int)DAT_180d6eb30 - (int)DAT_180d6eb28;
        *(undefined8 *)(puVar18 + -8) = 0x1803c1411;
        FUN_1803c9190(&DAT_180d6ebc8,local_3c8,local_318,4);
        *(undefined8 *)(puVar18 + -8) = 0x1803c1432;
        FUN_1803c9190(&DAT_180d6ebc8,local_3c8,CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28),
                      DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28));
      }
      DAT_180d6eb70 = DAT_180d6eb70 + 1;
      *(longlong *)(puVar18 + 0x70) = CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
      *(longlong *)(puVar18 + 0x78) =
           DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
      *(undefined8 *)(puVar18 + -8) = 0x1803c1470;
      FUN_1801806e0(&DAT_180d6eb40,puVar18 + 0x70);
      local_2e0[0] = ((int)DAT_180d6eb30 - (int)DAT_180d6eb28) + 4;
      *(undefined8 *)(puVar18 + -8) = 0x1803c149e;
      FUN_180186fb0(&DAT_180d6ea20,local_2e0,4);
      *(undefined8 *)(puVar18 + -8) = 0x1803c14bb;
      FUN_180186fb0(&DAT_180d6ea20,CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28),
                    DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28));
      *(undefined8 *)(puVar18 + -8) = 0x1803c14c7;
      FUN_180186e20(&DAT_180d6ea20);
      if (CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28) != DAT_180d6eb30) {
        DAT_180d6eb30 = CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
      }
      *(undefined8 *)(puVar18 + -8) = 0x1803c14e7;
      FUN_1801a2650(local_300);
      *(undefined8 *)(puVar18 + -8) = 0x1803c14f0;
      FUN_180973930(&DAT_180d6eb78);
      piVar14 = (int *)*param_1;
      if (piVar14 == (int *)0x0) goto LAB_1803c0f10;
      LOCK();
      iVar8 = *piVar14;
      *piVar14 = *piVar14 + -1;
      UNLOCK();
      puVar16 = puVar18;
      if (iVar8 != 1) goto LAB_1803c0f10;
      goto LAB_1803c0f0a;
    }
    if (iVar8 != 0) {
      local_2b0 = 0xffffffffffffffff;
      local_298 = 0;
      local_310 = (size_t *)CONCAT44(local_310._4_4_,0x10);
      local_2b0 = Ordinal_1(*param_3,&local_2a8,&local_310);
      if (local_2b0 == 0xffffffffffffffff) {
        _Str = (char *)inet_ntop(2,&local_2a8,local_78,0x11);
        local_408._0_9_ = ZEXT89(0x180d6eb78);
        local_408._9_7_ = 0;
        iVar8 = FUN_180973810(&DAT_180d6eb78);
        if (iVar8 != 0) {
                    /* WARNING: Subroutine does not return */
          FUN_1809737c0(5);
        }
        if (DAT_180d6ebc4 == 0x7fffffff) {
          DAT_180d6ebc4 = 0x7ffffffe;
                    /* WARNING: Subroutine does not return */
          FUN_1809737c0(6);
        }
        local_408[8] = 1;
        local_438[0] = 0;
        FUN_180185e60(&DAT_180d6eb28,local_438);
        local_308._0_4_ = 0x34;
        FUN_1801877a0(&DAT_180d6eb28,&local_308,4);
        FUN_1801877a0(&DAT_180d6eb28,&DAT_180d0dd28,0x34);
        local_3b8 = _Xtime_get_ticks();
        local_428 = SUB82(&local_3b8,0);
        uStack_426 = (undefined6)((ulonglong)&local_3b8 >> 0x10);
        local_420 = 0x1210;
        uStack_41e = 0x18019;
        uStack_41a = 0;
        local_430 = 0xd000000000000000;
        local_2f0 = 0;
        local_2e8 = 0xf;
        local_300._1_15_ = SUB1615((undefined1  [16])0x0,1);
        auVar2[0xf] = 0;
        auVar2._0_15_ = local_300._1_15_;
        local_300 = auVar2 << 8;
        local_308._0_4_ = uVar19 | 0x10;
        FUN_18019f7a0(local_300,0x11);
        local_398 = 1;
        local_390 = &local_430;
        local_388 = &DAT_180c09610;
        local_380 = 9;
        local_448[0] = (undefined8 *)0x0;
        FUN_18018ad00(local_358,local_300,&local_388);
        local_308._0_4_ = 1;
        FUN_180185f70(&DAT_180d6eb28,&local_308);
        local_308._0_4_ = (int)local_2f0;
        FUN_1801877a0(&DAT_180d6eb28,&local_308,4);
        puVar16 = local_300;
        if (0xf < local_2e8) {
          puVar16 = (undefined1 *)local_300._0_8_;
        }
        FUN_1801877a0(&DAT_180d6eb28,puVar16,local_2f0);
        sVar10 = strlen(_Str);
        local_308._0_4_ = 1;
        FUN_180185f70(&DAT_180d6eb28,&local_308);
        local_308 = CONCAT44(local_308._4_4_,(int)sVar10);
        FUN_1801877a0(&DAT_180d6eb28,&local_308,4);
        FUN_1801877a0(&DAT_180d6eb28,_Str,sVar10);
        if (DAT_180d6ebe0 != '\0') {
          local_308 = CONCAT44(local_308._4_4_,(int)DAT_180d6eb30 - (int)DAT_180d6eb28);
          FUN_1803c9190(&DAT_180d6ebc8,local_348,&local_308,4);
          FUN_1803c9190(&DAT_180d6ebc8,local_338);
        }
        DAT_180d6eb70 = DAT_180d6eb70 + 1;
        local_378 = CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
        local_370 = DAT_180d6eb30 - local_378;
        FUN_1801806e0(&DAT_180d6eb40,&local_378);
        local_2e0[0] = ((int)DAT_180d6eb30 - (int)DAT_180d6eb28) + 4;
        FUN_180186fb0(&DAT_180d6ea20,local_2e0,4);
        FUN_180186fb0(&DAT_180d6ea20,CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28),
                      DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28));
        FUN_180186e20(&DAT_180d6ea20);
        if (CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28) != DAT_180d6eb30) {
          DAT_180d6eb30 = CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
        }
        if (local_2e8 < 0x10) {
LAB_1803c08d3:
          local_2f0 = 0;
          local_2e8 = 0xf;
          auVar3[0xf] = 0;
          auVar3._0_15_ = local_300._1_15_;
          local_300 = auVar3 << 8;
          FUN_180973930(&DAT_180d6eb78);
          uVar9 = Ordinal_111();
          local_2d8 = CONCAT44(local_2d8._4_4_,uVar9);
          local_2b8 = '\0';
          uVar19 = uVar19 | 0xc;
          FUN_1803c95d0(&local_2b0);
          param_2 = local_3b0;
          goto LAB_1803c09d6;
        }
        uVar15 = local_2e8 + 1;
        lVar13 = local_300._0_8_;
        if (uVar15 < 0x1000) {
LAB_1803c08ce:
          thunk_FUN_180895720(lVar13,uVar15);
          goto LAB_1803c08d3;
        }
        lVar13 = *(longlong *)(local_300._0_8_ + -8);
        if ((local_300._0_8_ - lVar13) - 8U < 0x20) {
          uVar15 = local_2e8 + 0x28;
          goto LAB_1803c08ce;
        }
        pcVar1 = (code *)swi(0x29);
        (*pcVar1)(5);
        puVar17 = auStack_460;
LAB_1803c0f51:
        pcVar1 = (code *)swi(0x29);
        (*pcVar1)(5);
        puVar18 = puVar17 + 8;
        goto LAB_1803c0f58;
      }
      FUN_1803c8ff0(local_2b0);
      inet_ntop(2,&local_2a8,local_60);
      local_2d8 = local_2b0;
      local_2d0 = local_2a8;
      local_2ce = local_2a6;
      local_2c6 = local_29e;
      local_2c2 = local_29a;
      local_2c0 = 1;
      local_2b0 = 0xffffffffffffffff;
      local_2a8 = 0;
      local_2a6 = 0;
      local_29e = 0;
      local_29a = 0;
      local_298 = 0;
      local_2b8 = '\x01';
      uVar19 = uVar19 | 4;
      FUN_1803c95d0(&local_2b0);
LAB_1803c09d6:
      if (local_2b8 == '\0') {
        uVar9 = (undefined4)local_2d8;
        sVar10 = local_2d8 & 0xffffffff;
        local_408._0_9_ = ZEXT89(0x180d6eb78);
        local_408._9_7_ = 0;
        iVar8 = FUN_180973810(&DAT_180d6eb78);
        if (iVar8 != 0) {
                    /* WARNING: Subroutine does not return */
          FUN_1809737c0(5);
        }
        if (DAT_180d6ebc4 == 0x7fffffff) {
          DAT_180d6ebc4 = 0x7ffffffe;
                    /* WARNING: Subroutine does not return */
          FUN_1809737c0(6);
        }
        local_408[8] = 1;
        local_438[0] = 1;
        FUN_180185e60(&DAT_180d6eb28,local_438);
        local_310._0_4_ = 0x29;
        FUN_1801877a0(&DAT_180d6eb28,&local_310,4);
        FUN_1801877a0(&DAT_180d6eb28,&DAT_180d0dbc0,0x29);
        local_410 = _Xtime_get_ticks();
        local_428 = SUB82(&local_410,0);
        uStack_426 = (undefined6)((ulonglong)&local_410 >> 0x10);
        local_420 = 0x1210;
        uStack_41e = 0x18019;
        uStack_41a = 0;
        local_430 = 0xd000000000000000;
        local_2f0 = 0;
        local_2e8 = 0xf;
        local_300._1_15_ = SUB1615((undefined1  [16])0x0,1);
        auVar4[0xf] = 0;
        auVar4._0_15_ = local_300._1_15_;
        local_300 = auVar4 << 8;
        local_308 = CONCAT44(local_308._4_4_,uVar19) | 0x40;
        FUN_18019f7a0(local_300,0x11);
        local_3d8 = (undefined *)0x1;
        local_3d0 = &local_430;
        local_3f8 = &DAT_180c09610;
        local_3f0 = 9;
        local_448[0] = (undefined8 *)0x0;
        FUN_18018ad00(local_350,local_300,&local_3f8);
        local_308 = CONCAT44(local_308._4_4_,uVar19);
        uVar19 = uVar19 | 0x20;
        local_310._0_4_ = 1;
        FUN_180185f70(&DAT_180d6eb28,&local_310);
        local_310._0_4_ = (int)local_2f0;
        FUN_1801877a0(&DAT_180d6eb28,&local_310,4);
        puVar16 = local_300;
        if (0xf < local_2e8) {
          puVar16 = (undefined1 *)local_300._0_8_;
        }
        FUN_1801877a0(&DAT_180d6eb28,puVar16,local_2f0);
        local_310._0_4_ = 0;
        FUN_180185f70(&DAT_180d6eb28,&local_310);
        local_310._0_4_ = 4;
        FUN_1801877a0(&DAT_180d6eb28,&local_310,4);
        local_310 = (size_t *)CONCAT44(local_310._4_4_,uVar9);
        FUN_1801877a0(&DAT_180d6eb28,&local_310,4);
        if (DAT_180d6ebe0 != '\0') {
          local_310 = (size_t *)CONCAT44(local_310._4_4_,(int)DAT_180d6eb30 - (int)DAT_180d6eb28);
          FUN_1803c9190(&DAT_180d6ebc8,local_328,&local_310,4);
          FUN_1803c9190(&DAT_180d6ebc8,local_3c8);
        }
        DAT_180d6eb70 = DAT_180d6eb70 + 1;
        local_3e8._8_8_ = DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
        local_3e8._0_8_ = CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
        FUN_1801806e0(&DAT_180d6eb40,local_3e8);
        local_318[0] = ((int)DAT_180d6eb30 - (int)DAT_180d6eb28) + 4;
        FUN_180186fb0(&DAT_180d6ea20,local_318,4);
        FUN_180186fb0(&DAT_180d6ea20,CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28),
                      DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28));
        FUN_180186e20(&DAT_180d6ea20);
        if (CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28) != DAT_180d6eb30) {
          DAT_180d6eb30 = CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
        }
        if (0xf < local_2e8) {
          lVar13 = local_300._0_8_;
          if ((0xfff < local_2e8 + 1) &&
             (lVar13 = *(longlong *)(local_300._0_8_ + -8), 0x1f < (local_300._0_8_ - lVar13) - 8U))
          goto LAB_1803c0f51;
          thunk_FUN_180895720(lVar13);
        }
        local_2f0 = 0;
        local_2e8 = 0xf;
        auVar5[0xf] = 0;
        auVar5._0_15_ = local_300._1_15_;
        local_300 = auVar5 << 8;
        FUN_180973930(&DAT_180d6eb78);
        if (local_2b8 != '\0') {
          FUN_1803c95d0(&local_2d8);
        }
      }
      else {
        psVar11 = (size_t *)FUN_180976d80(0x168);
        local_3a8[0] = psVar11;
        FUN_1809bef30(psVar11,0,0x168);
        local_430 = local_2d8;
        local_428 = local_2d0;
        uStack_426 = (undefined6)local_2ce;
        local_420 = (undefined2)((ulonglong)local_2ce >> 0x30);
        uStack_41e = local_2c6;
        uStack_41a = local_2c2;
        local_418 = local_2c0;
        local_2d8 = 0xffffffffffffffff;
        local_2d0 = 0;
        local_2ce = 0;
        local_2c6 = 0;
        local_2c2 = 0;
        local_2c0 = 0;
        local_310 = &local_430;
        FUN_1803bd780(psVar11,param_2,0);
        *psVar11 = (size_t)&PTR_LAB_180c6ef88;
        psVar11[0x29] = local_430;
        *(undefined2 *)(psVar11 + 0x2a) = local_428;
        *(ulonglong *)((longlong)psVar11 + 0x152) = CONCAT26(local_420,uStack_426);
        *(undefined4 *)((longlong)psVar11 + 0x15a) = uStack_41e;
        *(undefined2 *)((longlong)psVar11 + 0x15e) = uStack_41a;
        *(undefined1 *)(psVar11 + 0x2c) = local_418;
        local_430 = 0xffffffffffffffff;
        local_428 = 0;
        uStack_426 = 0;
        local_420 = 0;
        uStack_41e = 0;
        uStack_41a = 0;
        local_418 = 0;
        FUN_1803c95d0(&local_430);
        uVar19 = uVar19 | 0x80;
        local_308 = 0;
        local_310 = psVar11;
        FUN_1803db220(param_2);
        if (local_310 != (size_t *)0x0) {
          (**(code **)(*local_310 + 0x18))();
        }
        if (local_2b8 != '\0') {
          FUN_1803c95d0(&local_2d8);
        }
      }
    }
    iVar8 = *(int *)(param_2 + 0x238);
  }
  piVar14 = (int *)*param_1;
  puVar18 = auStack_468;
  if (piVar14 != (int *)0x0) {
    LOCK();
    iVar8 = *piVar14;
    *piVar14 = *piVar14 + -1;
    UNLOCK();
    puVar18 = auStack_468;
    puVar16 = auStack_468;
    if (iVar8 == 1) {
LAB_1803c0f0a:
      puVar18 = puVar16;
      *(undefined8 *)(puVar18 + -8) = 0x1803c0f0f;
      thunk_FUN_180895720(piVar14,0x20);
    }
  }
LAB_1803c0f10:
  if (*param_3 != -1) {
    *(undefined8 *)(puVar18 + -8) = 0x1803c0f20;
    Ordinal_3();
  }
  *(undefined8 *)(puVar18 + -8) = 0x1803c0f2f;
  return;
}

