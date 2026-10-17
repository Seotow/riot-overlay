// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x18042d900; descriptive alias: DllMain
// Evidence: ev_3c796322c2e6df06a755836c9f44c58ac3b7217fc34a26a0b1b105aff82b1d6e
// Original Evidence: rea-collector/0x18042d900.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* WARNING: Removing unreachable block (ram,0x00018042df17) */
/* WARNING: Removing unreachable block (ram,0x00018042db88) */
/* WARNING: Removing unreachable block (ram,0x00018042df2c) */
/* WARNING: Removing unreachable block (ram,0x00018042db67) */
/* WARNING: Removing unreachable block (ram,0x00018042e265) */
/* WARNING: Removing unreachable block (ram,0x00018042df3b) */
/* WARNING: Removing unreachable block (ram,0x00018042db97) */
/* WARNING: Removing unreachable block (ram,0x00018042e274) */
/* WARNING: Removing unreachable block (ram,0x00018042e283) */

undefined8 DllMain(undefined8 param_1,int param_2,longlong param_3)

{
  code *pcVar1;
  undefined1 auVar2 [16];
  undefined1 auVar3 [16];
  undefined1 auVar4 [16];
  undefined1 auVar5 [16];
  undefined1 auVar6 [16];
  undefined1 auVar7 [16];
  undefined1 auVar8 [16];
  byte bVar9;
  undefined2 uVar10;
  DWORD DVar11;
  int iVar12;
  int iVar13;
  undefined4 uVar14;
  undefined8 *puVar15;
  undefined1 auVar16 [8];
  ulonglong uVar17;
  undefined1 *puVar18;
  longlong lVar19;
  undefined1 *puVar20;
  undefined8 unaff_RBX;
  ulonglong unaff_RSI;
  ulonglong unaff_RDI;
  code *unaff_R12;
  ulonglong unaff_R14;
  ulonglong unaff_R15;
  undefined1 auStack_408 [8];
  undefined1 auStack_400 [24];
  undefined8 local_3e8;
  undefined1 local_3d8 [16];
  undefined *local_3c8;
  undefined8 *local_3c0;
  code *pcStack_3b8;
  undefined *local_3a8;
  undefined1 *local_3a0;
  undefined8 local_398 [2];
  undefined8 local_388;
  undefined4 local_380;
  undefined4 local_37c;
  undefined8 local_378;
  undefined8 uStack_370;
  undefined8 uStack_368;
  undefined8 uStack_360;
  undefined1 local_358 [16];
  undefined1 local_348 [16];
  undefined1 local_338 [16];
  undefined1 local_328 [16];
  undefined1 local_318 [16];
  undefined1 local_308 [16];
  undefined1 local_2f8 [16];
  undefined1 local_2e8 [16];
  undefined1 local_2d8 [16];
  undefined1 local_2c8 [16];
  undefined1 local_2b8 [16];
  undefined1 local_2a8 [16];
  undefined1 local_298 [16];
  undefined8 local_288;
  ulonglong local_278;
  undefined8 local_270;
  undefined1 local_268 [16];
  undefined8 local_258;
  ulonglong local_250;
  undefined8 local_248;
  undefined **ppuStack_240;
  undefined1 local_238 [416];
  undefined1 local_98 [8];
  ulonglong *puStack_90;
  code *local_88;
  ulonglong local_80;
  ulonglong local_58;
  
                    /* 0x42d900  2  DllMain */
  puVar18 = auStack_408;
  local_58 = DAT_180d06cc0 ^ (ulonglong)auStack_408;
  local_398[0] = param_1;
  if (param_2 == 0) {
    if (param_3 != 0) {
      FUN_1801ad990(&DAT_180d20bf0,1,3);
      FUN_180211570();
      FUN_18042d860();
                    /* WARNING: Subroutine does not return */
      ExitThread(0);
    }
    FUN_18042d860();
    goto LAB_18042e975;
  }
  puVar18 = auStack_408;
  if (param_2 != 1) goto LAB_18042e975;
  local_388 = 0x26;
  local_380 = 0x23212d0e;
  local_37c = 0x2e001e2e;
  local_378 = 0x272e36362d002737;
  uStack_370 = 0x300027372523270e;
  uStack_368 = 0xe3631232126232d;
  uStack_360 = 0x372e671d202b;
  local_358 = (undefined1  [16])0x0;
  local_348 = (undefined1  [16])0x0;
  local_338 = (undefined1  [16])0x0;
  local_328 = (undefined1  [16])0x0;
  local_318 = (undefined1  [16])0x0;
  local_308 = (undefined1  [16])0x0;
  local_2f8 = (undefined1  [16])0x0;
  local_2e8 = (undefined1  [16])0x0;
  local_2d8 = (undefined1  [16])0x0;
  local_2c8 = (undefined1  [16])0x0;
  local_2b8 = (undefined1  [16])0x0;
  local_2a8 = (undefined1  [16])0x0;
  local_298 = (undefined1  [16])0x0;
  local_288 = 0;
  FUN_1801c7930(&local_388,local_268);
  DVar11 = GetCurrentProcessId();
  puVar18 = local_268;
  if (0xf < local_250) {
    puVar18 = (undefined1 *)local_268._0_8_;
  }
  FUN_18042ea40(local_98,puVar18,DVar11);
  DAT_180d6e8d8 = CreateMutexA((LPSECURITY_ATTRIBUTES)0x0,1,local_98);
  if ((DAT_180d6e8d8 == (HANDLE)0x0) || (DVar11 = GetLastError(), DVar11 != 0xb7)) {
    if (0xf < local_250) {
      uVar17 = local_250 + 1;
      lVar19 = local_268._0_8_;
      if (0xfff < uVar17) {
        lVar19 = *(longlong *)(local_268._0_8_ + -8);
        if (0x1f < (local_268._0_8_ - lVar19) - 8U) goto LAB_18042e518;
        uVar17 = local_250 + 0x28;
      }
      thunk_FUN_180895720(lVar19,uVar17);
    }
    iVar12 = FUN_180973810(&DAT_180d6eb78);
    if (iVar12 != 0) {
                    /* WARNING: Subroutine does not return */
      FUN_1809737c0(5);
    }
    if (DAT_180d6ebc4 == 0x7fffffff) {
      DAT_180d6ebc4 = 0x7ffffffe;
                    /* WARNING: Subroutine does not return */
      FUN_1809737c0(6);
    }
    local_3d8[0] = 2;
    FUN_180185e60(&DAT_180d6eb28,local_3d8);
    local_278 = CONCAT44(local_278._4_4_,0x1c);
    FUN_1801877a0(&DAT_180d6eb28,&local_278,4);
    FUN_1801877a0(&DAT_180d6eb28,&DAT_180d0fec0,0x1c);
    local_278 = _Xtime_get_ticks();
    unaff_RBX = 0;
    unaff_R12 = FUN_180191210;
    local_88 = FUN_180191210;
    unaff_RDI = 0xd000000000000000;
    puStack_90 = &local_278;
    local_98 = (undefined1  [8])0xd000000000000000;
    local_258 = 0;
    local_250 = 0xf;
    local_268._1_15_ = SUB1615((undefined1  [16])0x0,1);
    auVar4[0xf] = 0;
    auVar4._0_15_ = local_268._1_15_;
    local_268 = auVar4 << 8;
    unaff_RSI = 8;
    unaff_R15 = 0x20;
    unaff_R14 = 0xfffffffffffffff;
    FUN_18019f7a0(local_268,0x11);
    local_3a8 = (undefined *)0x1;
    local_3a0 = local_98;
    local_3c8 = &DAT_180c09610;
    local_3c0 = (undefined8 *)0x9;
    local_3e8 = 0;
    FUN_18018ad00(&local_248,local_268,&local_3c8,&local_3a8);
    local_278._0_4_ = 1;
    FUN_180185f70(&DAT_180d6eb28,&local_278);
    local_278 = CONCAT44(local_278._4_4_,(undefined4)local_258);
    FUN_1801877a0(&DAT_180d6eb28,&local_278,4);
    puVar18 = local_268;
    if (0xf < local_250) {
      puVar18 = (undefined1 *)local_268._0_8_;
    }
    FUN_1801877a0(&DAT_180d6eb28,puVar18,local_258);
    if (DAT_180d6ebe0 != '\0') {
      local_278 = CONCAT44(local_278._4_4_,(int)DAT_180d6eb30 - (int)DAT_180d6eb28);
      FUN_1803c9190(&DAT_180d6ebc8,&local_3c8,&local_278,4);
      FUN_1803c9190(&DAT_180d6ebc8,&local_3c8,CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28),
                    DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28));
    }
    DAT_180d6eb70 = DAT_180d6eb70 + 1;
    local_3c8 = (undefined *)CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
    local_3c0 = (undefined8 *)(DAT_180d6eb30 - (longlong)local_3c8);
    FUN_1801806e0(&DAT_180d6eb40,&local_3c8);
    local_270 = CONCAT44(local_270._4_4_,((int)DAT_180d6eb30 - (int)DAT_180d6eb28) + 4);
    FUN_180186fb0(&DAT_180d6ea20,&local_270,4);
    FUN_180186fb0(&DAT_180d6ea20,CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28),
                  DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28));
    FUN_180186e20(&DAT_180d6ea20);
    if (CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28) != DAT_180d6eb30) {
      DAT_180d6eb30 = CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
    }
    if (0xf < local_250) {
      uVar17 = local_250 + 1;
      lVar19 = local_268._0_8_;
      if (0xfff < uVar17) {
        lVar19 = *(longlong *)(local_268._0_8_ + -8);
        if (0x1f < (local_268._0_8_ - lVar19) - 8U) goto LAB_18042e518;
        uVar17 = local_250 + 0x28;
      }
      thunk_FUN_180895720(lVar19,uVar17);
    }
    local_258 = 0;
    local_250 = 0xf;
    auVar5[0xf] = 0;
    auVar5._0_15_ = local_268._1_15_;
    local_268 = auVar5 << 8;
    FUN_180973930(&DAT_180d6eb78);
    iVar12 = Ordinal_115(0x202,local_238);
    puVar18 = auStack_408;
    if (iVar12 != 0) {
      iVar13 = FUN_180973810(&DAT_180d6eb78);
      if (iVar13 != 0) {
                    /* WARNING: Subroutine does not return */
        FUN_1809737c0(5);
      }
      if (DAT_180d6ebc4 == 0x7fffffff) {
        DAT_180d6ebc4 = 0x7ffffffe;
                    /* WARNING: Subroutine does not return */
        FUN_1809737c0(6);
      }
      local_3d8[0] = 0;
      FUN_180185e60(&DAT_180d6eb28,local_3d8);
      local_278 = CONCAT44(local_278._4_4_,0x1e);
      FUN_1801877a0(&DAT_180d6eb28,&local_278,4);
      FUN_1801877a0(&DAT_180d6eb28,&DAT_180d0fe28,0x1e);
      local_278 = _Xtime_get_ticks();
      local_88 = FUN_180191210;
      puStack_90 = &local_278;
      local_98 = (undefined1  [8])0xd000000000000000;
      local_258 = 0;
      local_250 = 0xf;
      local_268._1_15_ = SUB1615((undefined1  [16])0x0,1);
      auVar6[0xf] = 0;
      auVar6._0_15_ = local_268._1_15_;
      local_268 = auVar6 << 8;
      unaff_RSI = 0x11;
      FUN_18019f7a0(local_268,0x11);
      local_3c8 = (undefined *)0x1;
      local_3c0 = (undefined8 *)local_98;
      local_3a8 = &DAT_180c09610;
      local_3a0 = &DAT_00000009;
      local_3e8 = 0;
      FUN_18018ad00(&local_248,local_268,&local_3a8,&local_3c8);
      local_278._0_4_ = 1;
      FUN_180185f70(&DAT_180d6eb28,&local_278);
      local_278._0_4_ = (undefined4)local_258;
      FUN_1801877a0(&DAT_180d6eb28,&local_278,4);
      puVar18 = local_268;
      if (0xf < local_250) {
        puVar18 = (undefined1 *)local_268._0_8_;
      }
      FUN_1801877a0(&DAT_180d6eb28,puVar18,local_258);
      local_278._0_4_ = 0;
      FUN_180185f70(&DAT_180d6eb28,&local_278);
      local_278._0_4_ = 4;
      FUN_1801877a0(&DAT_180d6eb28,&local_278,4);
      local_278 = CONCAT44(local_278._4_4_,iVar12);
      FUN_1801877a0(&DAT_180d6eb28,&local_278,4);
      if (DAT_180d6ebe0 != '\0') {
        local_278 = CONCAT44(local_278._4_4_,(int)DAT_180d6eb30 - (int)DAT_180d6eb28);
        FUN_1803c9190(&DAT_180d6ebc8,&local_3c8,&local_278,4);
        FUN_1803c9190(&DAT_180d6ebc8,&local_3c8,CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28),
                      DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28));
      }
      DAT_180d6eb70 = DAT_180d6eb70 + 1;
      local_3c8 = (undefined *)CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
      local_3c0 = (undefined8 *)(DAT_180d6eb30 - (longlong)local_3c8);
      FUN_1801806e0(&DAT_180d6eb40,&local_3c8);
      local_270 = CONCAT44(local_270._4_4_,((int)DAT_180d6eb30 - (int)DAT_180d6eb28) + 4);
      FUN_180186fb0(&DAT_180d6ea20,&local_270,4);
      FUN_180186fb0(&DAT_180d6ea20,CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28),
                    DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28));
      FUN_180186e20(&DAT_180d6ea20);
      if (CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28) != DAT_180d6eb30) {
        DAT_180d6eb30 = CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
      }
      if (0xf < local_250) {
        uVar17 = local_250 + 1;
        lVar19 = local_268._0_8_;
        if (0xfff < uVar17) {
          lVar19 = *(longlong *)(local_268._0_8_ + -8);
          unaff_RBX = 0;
          if (0x1f < (local_268._0_8_ - lVar19) - 8U) goto LAB_18042e518;
          uVar17 = local_250 + 0x28;
        }
        thunk_FUN_180895720(lVar19,uVar17);
      }
      local_258 = 0;
      local_250 = 0xf;
      auVar7[0xf] = 0;
      auVar7._0_15_ = local_268._1_15_;
      local_268 = auVar7 << 8;
      FUN_180973930(&DAT_180d6eb78);
      puVar18 = auStack_408;
      goto LAB_18042e975;
    }
  }
  else {
    CloseHandle(DAT_180d6e8d8);
    DAT_180d6e8d8 = (HANDLE)0x0;
    unaff_RBX = 0;
    if (local_250 < 0x10) {
LAB_18042da85:
      iVar12 = FUN_180973810(&DAT_180d6eb78);
      if (iVar12 != 0) {
                    /* WARNING: Subroutine does not return */
        FUN_1809737c0(5);
      }
      if (DAT_180d6ebc4 == 0x7fffffff) {
        DAT_180d6ebc4 = 0x7ffffffe;
                    /* WARNING: Subroutine does not return */
        FUN_1809737c0(6);
      }
      local_3d8[0] = 1;
      FUN_180185e60(&DAT_180d6eb28,local_3d8);
      local_270 = CONCAT44(local_270._4_4_,0x4b);
      FUN_1801877a0(&DAT_180d6eb28,&local_270,4);
      FUN_1801877a0(&DAT_180d6eb28,&DAT_180d0fe70,0x4b);
      local_270 = _Xtime_get_ticks();
      local_3c0 = &local_270;
      unaff_R12 = FUN_180191210;
      pcStack_3b8 = FUN_180191210;
      local_3c8 = (undefined *)0xd000000000000000;
      local_88 = (code *)0x0;
      local_80 = 0xf;
      stack0xffffffffffffff69 = SUB1615((undefined1  [16])0x0,1);
      auVar2[0xf] = 0;
      auVar2._0_15_ = stack0xffffffffffffff69;
      _local_98 = auVar2 << 8;
      unaff_R15 = 0x20;
      unaff_RDI = 0xd000000000000000;
      unaff_RSI = 0x11;
      FUN_18019f7a0(local_98,0x11);
      local_248 = 1;
      ppuStack_240 = &local_3c8;
      local_3a8 = &DAT_180c09610;
      local_3a0 = (undefined1 *)0x9;
      local_3e8 = 0;
      FUN_18018ad00(local_398,local_98,&local_3a8,&local_248);
      local_270._0_4_ = 1;
      FUN_180185f70(&DAT_180d6eb28,&local_270);
      local_270 = CONCAT44(local_270._4_4_,local_88._0_4_);
      FUN_1801877a0(&DAT_180d6eb28,&local_270,4);
      auVar16 = (undefined1  [8])local_98;
      if (0xf < local_80) {
        auVar16 = local_98;
      }
      FUN_1801877a0(&DAT_180d6eb28,auVar16,local_88);
      if (DAT_180d6ebe0 != '\0') {
        local_270 = CONCAT44(local_270._4_4_,(int)DAT_180d6eb30 - (int)DAT_180d6eb28);
        FUN_1803c9190(&DAT_180d6ebc8,&local_3c8,&local_270,4);
        FUN_1803c9190(&DAT_180d6ebc8,&local_3c8,CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28),
                      DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28));
      }
      DAT_180d6eb70 = DAT_180d6eb70 + 1;
      local_3a8 = (undefined *)CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
      local_3a0 = (undefined1 *)(DAT_180d6eb30 - (longlong)local_3a8);
      FUN_1801806e0(&DAT_180d6eb40,&local_3a8);
      local_278 = CONCAT44(local_278._4_4_,((int)DAT_180d6eb30 - (int)DAT_180d6eb28) + 4);
      FUN_180186fb0(&DAT_180d6ea20,&local_278,4);
      FUN_180186fb0(&DAT_180d6ea20,CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28),
                    DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28));
      FUN_180186e20(&DAT_180d6ea20);
      if (CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28) != DAT_180d6eb30) {
        DAT_180d6eb30 = CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
      }
      if (0xf < local_80) {
        uVar17 = local_80 + 1;
        auVar16 = local_98;
        if (0xfff < uVar17) {
          auVar16 = *(undefined1 (*) [8])((longlong)local_98 + -8);
          if (0x1f < ((longlong)local_98 - (longlong)auVar16) - 8U) goto LAB_18042e518;
          uVar17 = local_80 + 0x28;
        }
        thunk_FUN_180895720(auVar16,uVar17);
      }
      local_88 = (code *)0x0;
      local_80 = 0xf;
      auVar3[0xf] = 0;
      auVar3._0_15_ = stack0xffffffffffffff69;
      _local_98 = auVar3 << 8;
      FUN_180973930(&DAT_180d6eb78);
      puVar18 = auStack_408;
      goto LAB_18042e975;
    }
    uVar17 = local_250 + 1;
    lVar19 = local_268._0_8_;
    if (uVar17 < 0x1000) {
LAB_18042da80:
      thunk_FUN_180895720(lVar19,uVar17);
      goto LAB_18042da85;
    }
    lVar19 = *(longlong *)(local_268._0_8_ + -8);
    if ((local_268._0_8_ - lVar19) - 8U < 0x20) {
      uVar17 = local_250 + 0x28;
      goto LAB_18042da80;
    }
LAB_18042e518:
    pcVar1 = (code *)swi(0x29);
    (*pcVar1)(5);
    puVar18 = auStack_400;
  }
  if (DAT_180d6ebc8 != -1) {
    *(undefined8 *)(puVar18 + -8) = 0x18042e532;
    Ordinal_3();
  }
  DAT_180d6ebc8 = -1;
  *(undefined8 *)(puVar18 + -8) = 0x18042e556;
  DAT_180d6ebc8 = Ordinal_23(2,1,6);
  if (DAT_180d6ebc8 == -1) {
LAB_18042e5fc:
    *(undefined8 *)(puVar18 + -8) = 0x18042e608;
    iVar12 = FUN_180973810(&DAT_180d6eb78);
    if (iVar12 != 0) {
                    /* WARNING: Subroutine does not return */
      *(undefined **)(puVar18 + -8) = &UNK_18042ea1d;
      FUN_1809737c0(5);
    }
    if (DAT_180d6ebc4 == 0x7fffffff) {
      DAT_180d6ebc4 = 0x7ffffffe;
                    /* WARNING: Subroutine does not return */
      *(undefined **)(puVar18 + -8) = &UNK_18042ea30;
      FUN_1809737c0(6);
    }
    puVar18[0x30] = 1;
    *(undefined8 *)(puVar18 + -8) = 0x18042e637;
    FUN_180185e60(&DAT_180d6eb28,puVar18 + 0x30);
    local_278 = CONCAT44(local_278._4_4_,0x1f);
    *(undefined8 *)(puVar18 + -8) = 0x18042e65a;
    FUN_1801877a0(&DAT_180d6eb28,&local_278,4);
    *(undefined8 *)(puVar18 + -8) = 0x18042e673;
    FUN_1801877a0(&DAT_180d6eb28,&DAT_180d0fe48,0x1f);
    *(undefined8 *)(puVar18 + -8) = 0x18042e678;
    local_278 = _Xtime_get_ticks();
    local_88 = unaff_R12;
    puStack_90 = &local_278;
    local_98 = (undefined1  [8])unaff_RDI;
    local_250 = 0xf;
    local_268._1_15_ = SUB1615((undefined1  [16])0x0,1);
    auVar8[0xf] = 0;
    auVar8._0_15_ = local_268._1_15_;
    local_268 = auVar8 << 8;
    bVar9 = (byte)(unaff_RDI >> 0x3c);
    if (bVar9 == 0xc) {
      uVar17 = *(ulonglong *)((longlong)&local_88 + (unaff_RDI & unaff_R14));
    }
    else {
      uVar17 = unaff_RSI;
      if (bVar9 == 0xb) {
        uVar17 = unaff_R15;
      }
    }
    lVar19 = uVar17 + 9;
    if (0xfffffffffffffff6 < uVar17) {
      lVar19 = -1;
    }
    *(undefined8 *)(puVar18 + -8) = 0x18042e6ff;
    local_258 = unaff_RBX;
    FUN_18019f7a0(local_268,lVar19);
    *(undefined8 *)(puVar18 + 0x40) = 1;
    *(undefined1 **)(puVar18 + 0x48) = local_98;
    *(undefined **)(puVar18 + 0x60) = &DAT_180c09610;
    *(undefined8 *)(puVar18 + 0x68) = 9;
    *(undefined8 *)(puVar18 + 0x20) = unaff_RBX;
    *(undefined8 *)(puVar18 + -8) = 0x18042e74b;
    FUN_18018ad00(&local_248,local_268,puVar18 + 0x60,puVar18 + 0x40);
    local_278._0_4_ = 1;
    *(undefined8 *)(puVar18 + -8) = 0x18042e768;
    FUN_180185f70(&DAT_180d6eb28,&local_278);
    local_278 = CONCAT44(local_278._4_4_,(undefined4)local_258);
    *(undefined8 *)(puVar18 + -8) = 0x18042e78d;
    FUN_1801877a0(&DAT_180d6eb28,&local_278,4);
    puVar20 = local_268;
    if (0xf < local_250) {
      puVar20 = (undefined1 *)local_268._0_8_;
    }
    *(undefined8 *)(puVar18 + -8) = 0x18042e7b7;
    FUN_1801877a0(&DAT_180d6eb28,puVar20,local_258);
    if (DAT_180d6ebe0 != '\0') {
      local_278 = CONCAT44(local_278._4_4_,(int)DAT_180d6eb30 - (int)DAT_180d6eb28);
      *(undefined8 *)(puVar18 + -8) = 0x18042e7f0;
      FUN_1803c9190(&DAT_180d6ebc8,puVar18 + 0x40,&local_278,4);
      *(undefined8 *)(puVar18 + -8) = 0x18042e812;
      FUN_1803c9190(&DAT_180d6ebc8,puVar18 + 0x40,CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28),
                    DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28));
    }
    DAT_180d6eb70 = DAT_180d6eb70 + 1;
    *(longlong *)(puVar18 + 0x40) = CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
    *(longlong *)(puVar18 + 0x48) = DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28)
    ;
    *(undefined8 *)(puVar18 + -8) = 0x18042e850;
    FUN_1801806e0(&DAT_180d6eb40,puVar18 + 0x40);
    local_270 = CONCAT44(local_270._4_4_,((int)DAT_180d6eb30 - (int)DAT_180d6eb28) + 4);
    *(undefined8 *)(puVar18 + -8) = 0x18042e87e;
    FUN_180186fb0(&DAT_180d6ea20,&local_270,4);
    *(undefined8 *)(puVar18 + -8) = 0x18042e89b;
    FUN_180186fb0(&DAT_180d6ea20,CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28),
                  DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28));
    *(undefined8 *)(puVar18 + -8) = 0x18042e8a7;
    FUN_180186e20(&DAT_180d6ea20);
    if (CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28) != DAT_180d6eb30) {
      DAT_180d6eb30 = CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
    }
    *(undefined8 *)(puVar18 + -8) = 0x18042e8ca;
    FUN_1801a2650(local_268);
    *(undefined8 *)(puVar18 + -8) = 0x18042e8d6;
    FUN_180973930(&DAT_180d6eb78);
  }
  else {
    local_248 = CONCAT62(local_248._2_6_,2);
    *(undefined8 *)(puVar18 + -8) = 0x18042e57d;
    uVar14 = Ordinal_8(0x7f000001);
    local_248 = CONCAT44(uVar14,(undefined4)local_248);
    *(undefined8 *)(puVar18 + -8) = 0x18042e58e;
    uVar10 = Ordinal_9(0xa6e7);
    local_248._0_4_ = CONCAT22(uVar10,(undefined2)local_248);
    *(undefined8 *)(puVar18 + -8) = 0x18042e5af;
    iVar12 = Ordinal_4(DAT_180d6ebc8,&local_248,0x10);
    if (iVar12 == -1) goto LAB_18042e5fc;
    *(undefined8 *)(puVar18 + -8) = 0x18042e5c0;
    FUN_1803c8ff0(DAT_180d6ebc8);
    DAT_180d6ebe0 = '\x01';
    *(undefined8 *)(puVar18 + -8) = 0x18042e5cd;
    DVar11 = GetCurrentProcessId();
    local_278 = (ulonglong)DVar11;
    *(undefined8 *)(puVar18 + -8) = 0x18042e5f1;
    FUN_1803c9190(&DAT_180d6ebc8,puVar18 + 0x40,&local_278,unaff_RSI);
    if (puVar18[0x48] == '\0') goto LAB_18042e5fc;
  }
  *(undefined8 *)(puVar18 + -8) = 0x18042e8de;
  puVar15 = (undefined8 *)FUN_180976d80(unaff_RSI);
  *puVar15 = *(undefined8 *)(puVar18 + 0x70);
  *(undefined ****)(puVar18 + 0x28) = &ppuStack_240;
  *(int *)(puVar18 + 0x20) = (int)unaff_RBX;
  *(undefined8 *)(puVar18 + -8) = 0x18042e909;
  local_248 = FUN_180988944(0,0,FUN_18042ee00,puVar15);
  if (local_248 == 0) {
    ppuStack_240 = (undefined **)CONCAT44(ppuStack_240._4_4_,(int)unaff_RBX);
                    /* WARNING: Subroutine does not return */
    *(undefined **)(puVar18 + -8) = &UNK_18042e9ad;
    FUN_1809737c0(6);
  }
  if ((int)ppuStack_240 != 0) {
    *(longlong *)(puVar18 + 0x40) = local_248;
    *(undefined ***)(puVar18 + 0x48) = ppuStack_240;
    *(undefined8 *)(puVar18 + -8) = 0x18042e93e;
    iVar12 = FUN_180974b30(puVar18 + 0x40);
    if (iVar12 == 0) {
LAB_18042e975:
      *(undefined8 *)(puVar18 + -8) = 0x18042e989;
      return 1;
    }
  }
                    /* WARNING: Subroutine does not return */
  *(undefined **)(puVar18 + -8) = &UNK_18042e9b8;
  FUN_1809737c0(1);
}

