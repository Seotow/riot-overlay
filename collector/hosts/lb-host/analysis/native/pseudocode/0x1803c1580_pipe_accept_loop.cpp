// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1803c1580; descriptive alias: pipe_accept_loop
// Evidence: ev_e4f0ef8ca3d41142084c9293f5db6184145f32aca0dccf4a6f029866dcd5ff9a
// Original Evidence: rea-pipe-accept-loop.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* WARNING: Removing unreachable block (ram,0x0001803c249b) */
/* WARNING: Removing unreachable block (ram,0x0001803c1a5a) */
/* WARNING: Removing unreachable block (ram,0x0001803c1a80) */
/* WARNING: Removing unreachable block (ram,0x0001803c2fb5) */
/* WARNING: Removing unreachable block (ram,0x0001803c1a87) */
/* WARNING: Removing unreachable block (ram,0x0001803c24bc) */
/* WARNING: Removing unreachable block (ram,0x0001803c24c4) */
/* WARNING: Removing unreachable block (ram,0x0001803c285a) */
/* WARNING: Removing unreachable block (ram,0x0001803c2fec) */
/* WARNING: Removing unreachable block (ram,0x0001803c2bc3) */
/* WARNING: Removing unreachable block (ram,0x0001803c3005) */
/* WARNING: Removing unreachable block (ram,0x0001803c2bcb) */
/* WARNING: Removing unreachable block (ram,0x0001803c301e) */
/* WARNING: Removing unreachable block (ram,0x0001803c30f2) */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void FUN_1803c1580(longlong *param_1,longlong param_2,longlong param_3)

{
  int *piVar1;
  code *pcVar2;
  undefined1 auVar3 [16];
  undefined1 auVar4 [16];
  bool bVar5;
  undefined1 auVar6 [16];
  undefined1 auVar7 [16];
  undefined1 auVar8 [16];
  undefined1 auVar9 [16];
  undefined1 auVar10 [16];
  undefined4 uVar11;
  ULONG_PTR UVar12;
  _union_540 _Var13;
  longlong *plVar14;
  byte bVar15;
  char cVar16;
  DWORD DVar17;
  BOOL BVar18;
  DWORD DVar19;
  int iVar20;
  HANDLE pvVar21;
  HANDLE pvVar22;
  longlong *plVar23;
  longlong lVar24;
  undefined1 auVar25 [8];
  ulonglong uVar26;
  undefined8 *****pppppuVar27;
  undefined1 *puVar28;
  undefined1 *puVar29;
  undefined1 *puVar30;
  undefined1 *puVar31;
  int iVar32;
  uint uVar33;
  undefined1 *puVar34;
  undefined8 uStack_3e0;
  undefined1 auStack_3d8 [8];
  undefined1 auStack_3d0 [24];
  undefined8 local_3b8;
  undefined1 local_3a8 [16];
  longlong *local_398;
  undefined8 uStack_390;
  longlong local_388;
  longlong **local_378;
  undefined8 uStack_370;
  undefined4 local_368;
  char local_364;
  longlong *local_360;
  undefined4 local_358;
  char local_354;
  undefined8 local_350;
  undefined8 local_348;
  undefined8 local_340;
  undefined8 local_338;
  undefined8 local_330;
  longlong local_328;
  longlong local_320;
  undefined8 local_318;
  undefined1 *local_310;
  undefined *local_308;
  undefined8 local_300;
  longlong local_2f8;
  longlong local_2f0;
  undefined *local_2e8;
  undefined8 uStack_2e0;
  undefined8 local_2d8;
  undefined1 *local_2d0;
  longlong local_2c8;
  longlong local_2c0;
  undefined8 local_2b8;
  undefined1 *local_2b0;
  undefined *local_2a8;
  undefined8 local_2a0;
  longlong local_298;
  longlong local_290;
  undefined *local_288;
  undefined8 uStack_280;
  undefined8 local_278;
  undefined1 *local_270;
  longlong local_268;
  longlong local_260;
  undefined4 *local_258;
  undefined8 local_250;
  undefined8 local_248;
  undefined1 *local_240;
  undefined *local_238;
  undefined8 local_230;
  undefined4 local_228 [2];
  char local_220;
  longlong *local_218;
  longlong *local_210;
  undefined1 local_208 [8];
  undefined1 local_200 [8];
  undefined1 local_1f8 [8];
  undefined1 local_1f0 [16];
  undefined1 local_1e0 [16];
  undefined1 local_1d0 [16];
  undefined1 local_1c0 [16];
  undefined1 local_1b0 [16];
  undefined1 local_1a0 [16];
  undefined1 local_190 [16];
  undefined1 local_180 [16];
  undefined1 local_170 [16];
  undefined1 local_160 [16];
  ULONG local_150 [2];
  longlong local_148;
  PSID local_140;
  undefined1 local_138 [8];
  ULONG_PTR UStack_130;
  _union_540 local_128;
  undefined1 *local_120;
  DWORD local_118;
  undefined1 local_110 [8];
  undefined1 local_108 [8];
  _union_540 _Stack_100;
  undefined1 *local_f8;
  DWORD local_f0;
  undefined1 local_e8 [16];
  code *local_d8;
  undefined4 local_d0 [2];
  undefined1 local_c8 [16];
  longlong local_b8;
  longlong *local_b0;
  HANDLE pvStack_a8;
  HANDLE pvStack_a0;
  undefined1 *puStack_98;
  ulonglong local_90;
  ulonglong local_88;
  DWORD local_80;
  DWORD local_7c;
  int local_78;
  int local_74;
  int local_70;
  int local_6c;
  int local_68 [2];
  undefined8 ****local_60 [2];
  undefined4 local_50;
  undefined4 uStack_4c;
  ulonglong local_48;
  ulonglong local_40;
  
  puVar28 = auStack_3d8;
  puVar29 = auStack_3d8;
  puVar30 = auStack_3d8;
  local_40 = DAT_180d06cc0 ^ (ulonglong)auStack_3d8;
  uVar33 = 0;
  local_140 = (PSID)((ulonglong)local_140 & 0xffffffff00000000);
  iVar20 = *(int *)(param_2 + 0x238);
  local_388 = param_2;
  local_360 = param_1;
  local_210 = param_1;
  local_148 = param_3;
LAB_1803c15e3:
  do {
    iVar32 = -1;
    puVar34 = &DAT_00000020;
    plVar23 = local_360;
    puVar31 = auStack_3d8;
    if ((iVar20 == 0) ||
       ((*local_360 != 0 && (puVar31 = auStack_3d8, (*(uint *)(*local_360 + 4) & 1) != 0))))
    goto LAB_1803c31e6;
    local_b0 = (longlong *)0x0;
    pvStack_a8 = (HANDLE)0x0;
    pvStack_a0 = (HANDLE)0x0;
    puStack_98 = (undefined1 *)0x0;
    local_90 = 0;
    local_88 = 0;
    local_398 = (longlong *)*local_360;
    if (local_398 != (longlong *)0x0) {
      LOCK();
      *(int *)local_398 = (int)*local_398 + 1;
      UNLOCK();
    }
    local_378 = &local_398;
    if ((*(longlong *)(param_3 + 0x28) != -1) ||
       (FUN_1803cb1f0(param_3,&local_358), local_354 != '\0')) {
      puVar34 = CreateEventW((LPSECURITY_ATTRIBUTES)0x0,1,0,(LPCWSTR)0x0);
      if (puVar34 == (undefined1 *)0x0) {
        DVar19 = GetLastError();
        local_b0 = (longlong *)CONCAT44(local_b0._4_4_,DVar19);
LAB_1803c16be:
        local_88 = local_88 & 0xffffffffffffff00;
        if (local_398 != (longlong *)0x0) {
          LOCK();
          lVar24 = *local_398;
          *(int *)local_398 = (int)*local_398 + -1;
          UNLOCK();
          if ((int)lVar24 == 1) {
            thunk_FUN_180895720(local_398,0x20);
          }
        }
        goto LAB_1803c1e29;
      }
      local_110 = (undefined1  [8])0x0;
      _local_108 = (undefined1  [16])0x0;
      local_f8 = puVar34;
      BVar18 = ConnectNamedPipe(*(HANDLE *)(param_3 + 0x28),(LPOVERLAPPED)local_110);
      if (BVar18 == 0) {
        DVar19 = GetLastError();
        BVar18 = 0;
        if (DVar19 != 0x3e5) {
          if (DVar19 != 0x217) goto LAB_1803c18a2;
          CloseHandle(puVar34);
          goto LAB_1803c185c;
        }
        do {
          if ((local_398 != (longlong *)0x0) && ((*local_398 & 0x100000000) != 0))
          goto LAB_1803c17ec;
          DVar17 = WaitForSingleObject(puVar34,100);
          if (DVar17 == 0) {
            local_140 = (PSID)((ulonglong)local_140 & 0xffffffff00000000);
            BVar18 = GetOverlappedResult(*(HANDLE *)(param_3 + 0x28),(LPOVERLAPPED)local_110,
                                         (LPDWORD)&local_140,0);
            if (BVar18 == 0) {
              DVar19 = GetLastError();
            }
            else {
              DVar19 = 0;
            }
            goto LAB_1803c17ec;
          }
        } while (DVar17 != 0xffffffff);
        DVar19 = GetLastError();
        CancelIoEx(*(HANDLE *)(param_3 + 0x28),(LPOVERLAPPED)local_110);
        local_68[1] = 0;
        GetOverlappedResult(*(HANDLE *)(param_3 + 0x28),(LPOVERLAPPED)local_110,
                            (LPDWORD)(local_68 + 1),1);
LAB_1803c17ec:
        if ((local_398 == (longlong *)0x0) || ((*local_398 & 0x100000000) == 0)) {
LAB_1803c18a2:
          CloseHandle(puVar34);
          if (BVar18 != 0) goto LAB_1803c185c;
          pvVar22 = *(HANDLE *)(param_3 + 0x28);
          *(undefined8 *)(param_3 + 0x28) = 0xffffffffffffffff;
          CloseHandle(pvVar22);
          local_b0 = (longlong *)CONCAT44(local_b0._4_4_,DVar19);
        }
        else {
          CancelIoEx(*(HANDLE *)(param_3 + 0x28),(LPOVERLAPPED)local_110);
          WaitForSingleObject(puVar34,0xffffffff);
          CloseHandle(puVar34);
          pvVar22 = *(HANDLE *)(param_3 + 0x28);
          *(undefined8 *)(param_3 + 0x28) = 0xffffffffffffffff;
          CloseHandle(pvVar22);
          local_b0 = (longlong *)CONCAT44(local_b0._4_4_,0x3e3);
        }
LAB_1803c1df7:
        local_88 = local_88 & 0xffffffffffffff00;
        if (local_398 != (longlong *)0x0) {
          LOCK();
          lVar24 = *local_398;
          *(int *)local_398 = (int)*local_398 + -1;
          UNLOCK();
          if ((int)lVar24 == 1) {
            thunk_FUN_180895720(local_398,0x20);
          }
        }
        goto LAB_1803c1e29;
      }
      CloseHandle(puVar34);
LAB_1803c185c:
      local_150[0] = 0;
      BVar18 = GetNamedPipeClientProcessId(*(HANDLE *)(param_3 + 0x28),local_150);
      if ((BVar18 == 0) || (pvVar22 = OpenProcess(0x101000,0,local_150[0]), pvVar22 == (HANDLE)0x0))
      {
        DVar19 = GetLastError();
        DisconnectNamedPipe(*(HANDLE *)(param_3 + 0x28));
        pvVar22 = *(HANDLE *)(param_3 + 0x28);
        *(undefined8 *)(param_3 + 0x28) = 0xffffffffffffffff;
        CloseHandle(pvVar22);
        local_b0 = (longlong *)CONCAT44(local_b0._4_4_,DVar19);
        goto LAB_1803c16be;
      }
      pvVar21 = CreateEventW((LPSECURITY_ATTRIBUTES)0x0,1,0,(LPCWSTR)0x0);
      if (pvVar21 == (HANDLE)0x0) {
        DVar19 = GetLastError();
LAB_1803c1dd0:
        CloseHandle(pvVar22);
        DisconnectNamedPipe(*(HANDLE *)(param_3 + 0x28));
        pvVar22 = *(HANDLE *)(param_3 + 0x28);
        *(undefined8 *)(param_3 + 0x28) = 0xffffffffffffffff;
        CloseHandle(pvVar22);
        local_b0 = (longlong *)CONCAT44(local_b0._4_4_,DVar19);
        goto LAB_1803c1df7;
      }
      puVar34 = CreateEventW((LPSECURITY_ATTRIBUTES)0x0,1,0,(LPCWSTR)0x0);
      if (puVar34 == (undefined1 *)0x0) {
        DVar19 = GetLastError();
        CloseHandle(pvVar21);
        goto LAB_1803c1dd0;
      }
      plVar23 = *(longlong **)(param_3 + 0x28);
      *(undefined8 *)(param_3 + 0x28) = 0xffffffffffffffff;
      FUN_1803cb1f0(param_3,&local_368);
      if (local_364 != '\0') {
LAB_1803c1d3b:
        local_90 = CONCAT44(local_90._4_4_,local_150[0]);
        local_88 = CONCAT71(local_88._1_7_,1);
        uVar33 = uVar33 | 1;
        local_b0 = plVar23;
        pvStack_a8 = pvVar22;
        pvStack_a0 = pvVar21;
        puStack_98 = puVar34;
        if (local_398 != (longlong *)0x0) {
          LOCK();
          lVar24 = *local_398;
          *(int *)local_398 = (int)*local_398 + -1;
          UNLOCK();
          if ((int)lVar24 == 1) {
            thunk_FUN_180895720(local_398,0x20);
          }
        }
        goto LAB_1803c1e2e;
      }
      local_c8._0_9_ = ZEXT89(0x180d6eb78);
      local_c8._9_7_ = 0;
      iVar20 = FUN_180973810();
      if (iVar20 != 0) {
                    /* WARNING: Subroutine does not return */
        FUN_1809737c0(5);
      }
      if (DAT_180d6ebc4 == 0x7fffffff) {
        DAT_180d6ebc4 = 0x7ffffffe;
                    /* WARNING: Subroutine does not return */
        FUN_1809737c0(6);
      }
      local_c8[8] = 1;
      local_3a8[0] = 1;
      FUN_180185e60(&DAT_180d6eb28,local_3a8);
      local_140._0_4_ = 0x3d;
      FUN_1801877a0(&DAT_180d6eb28,&local_140,4);
      FUN_1801877a0(&DAT_180d6eb28,&DAT_180d0dda0,0x3d);
      local_350 = _Xtime_get_ticks();
      local_d8 = FUN_180191210;
      local_e8._8_8_ = &local_350;
      local_e8._0_8_ = 0xd000000000000000;
      local_128 = (_union_540)0x0;
      local_120 = (undefined1 *)0xf;
      stack0xfffffffffffffec9 = SUB1615((undefined1  [16])0x0,1);
      auVar3[0xf] = 0;
      auVar3._0_15_ = stack0xfffffffffffffec9;
      _local_138 = auVar3 << 8;
      local_140._0_4_ = uVar33 | 4;
      FUN_18019f7a0(local_138,0x11);
      local_318 = 1;
      local_310 = local_e8;
      local_308 = &DAT_180c09610;
      local_300 = 9;
      local_3b8 = 0;
      FUN_18018ad00(local_208,local_138,&local_308);
      uVar33 = uVar33 | 2;
      local_140._0_4_ = 1;
      FUN_180185f70(&DAT_180d6eb28,&local_140);
      local_140._0_4_ = local_128._0_4_;
      FUN_1801877a0(&DAT_180d6eb28,&local_140,4);
      auVar25 = (undefined1  [8])local_138;
      if (0xf < local_120) {
        auVar25 = local_138;
      }
      FUN_1801877a0(&DAT_180d6eb28,auVar25,local_128);
      uVar11 = local_368;
      local_140._0_4_ = 0;
      FUN_180185f70(&DAT_180d6eb28,&local_140);
      local_140._0_4_ = 4;
      FUN_1801877a0(&DAT_180d6eb28,&local_140,4);
      local_140 = (PSID)CONCAT44(local_140._4_4_,uVar11);
      FUN_1801877a0(&DAT_180d6eb28,&local_140,4);
      if (DAT_180d6ebe0 != '\0') {
        local_140 = (PSID)CONCAT44(local_140._4_4_,(int)DAT_180d6eb30 - (int)DAT_180d6eb28);
        FUN_1803c9190(&DAT_180d6ebc8,local_170,&local_140,4);
        FUN_1803c9190(&DAT_180d6ebc8,local_180);
      }
      DAT_180d6eb70 = DAT_180d6eb70 + 1;
      local_2f8 = CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
      local_2f0 = DAT_180d6eb30 - local_2f8;
      FUN_1801806e0(&DAT_180d6eb40,&local_2f8);
      local_78 = ((int)DAT_180d6eb30 - (int)DAT_180d6eb28) + 4;
      FUN_180186fb0(&DAT_180d6ea20,&local_78,4);
      FUN_180186fb0(&DAT_180d6ea20);
      FUN_180186e20(&DAT_180d6ea20);
      if (CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28) != DAT_180d6eb30) {
        DAT_180d6eb30 = CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
      }
      if (local_120 < 0x10) {
LAB_1803c1d06:
        local_128 = (_union_540)0x0;
        local_120 = (undefined1 *)0xf;
        auVar4[0xf] = 0;
        auVar4._0_15_ = stack0xfffffffffffffec9;
        _local_138 = auVar4 << 8;
        FUN_180973930(&DAT_180d6eb78);
        goto LAB_1803c1d3b;
      }
      uVar26 = (longlong)local_120 + 1;
      auVar25 = local_138;
      if (uVar26 < 0x1000) {
LAB_1803c1d01:
        thunk_FUN_180895720(auVar25,uVar26);
        goto LAB_1803c1d06;
      }
      auVar25 = *(undefined1 (*) [8])((longlong)local_138 + -8);
      if (((longlong)local_138 - (longlong)auVar25) - 8U < 0x20) {
        uVar26 = (longlong)local_120 + 0x28;
        goto LAB_1803c1d01;
      }
      pcVar2 = (code *)swi(0x29);
      (*pcVar2)(5);
      puVar28 = auStack_3d0;
LAB_1803c31d1:
      pcVar2 = (code *)swi(0x29);
      (*pcVar2)(5);
      puVar29 = puVar28 + 8;
      iVar20 = (int)plVar23;
LAB_1803c31d8:
      iVar32 = iVar20;
      pcVar2 = (code *)swi(0x29);
      (*pcVar2)(5);
      puVar30 = puVar29 + 8;
LAB_1803c31df:
      plVar23 = (longlong *)&DAT_00000005;
      pcVar2 = (code *)swi(0x29);
      (*pcVar2)();
      puVar31 = puVar30 + 8;
LAB_1803c31e6:
      piVar1 = (int *)*plVar23;
      if (piVar1 != (int *)0x0) {
        LOCK();
        iVar20 = *piVar1;
        *piVar1 = *piVar1 + iVar32;
        UNLOCK();
        if (iVar20 == 1) {
          *(undefined8 *)(puVar31 + -8) = 0x1803c3201;
          thunk_FUN_180895720(piVar1,puVar34);
        }
      }
      *(undefined8 *)(puVar31 + -8) = 0x1803c320a;
      FUN_1803caf70(param_3);
      *(undefined8 *)(puVar31 + -8) = 0x1803c3219;
      return;
    }
    local_b0 = (longlong *)CONCAT44(local_b0._4_4_,local_358);
    local_88 = local_88 & 0xffffffffffffff00;
    if (local_398 != (longlong *)0x0) {
      LOCK();
      lVar24 = *local_398;
      *(int *)local_398 = (int)*local_398 + -1;
      UNLOCK();
      if ((int)lVar24 == 1) {
        thunk_FUN_180895720(local_398,0x20);
      }
    }
LAB_1803c1e29:
    uVar33 = uVar33 | 1;
LAB_1803c1e2e:
    puVar34 = puStack_98;
    pvVar21 = pvStack_a0;
    pvVar22 = pvStack_a8;
    plVar14 = local_b0;
    plVar23 = (longlong *)0xffffffffffffffff;
    iVar32 = -1;
    if ((char)local_88 == '\0') {
      if ((int)local_b0 != 0x3e3) {
        local_c8 = (undefined1  [16])0x0;
        FUN_18019fbb0(local_c8,&DAT_180d6eb78);
        local_3a8[0] = 1;
        FUN_180185e60(&DAT_180d6eb28,local_3a8);
        local_140._0_4_ = 0x30;
        FUN_1801877a0(&DAT_180d6eb28,&local_140,4);
        FUN_1801877a0(&DAT_180d6eb28,&DAT_180d0daf8,0x30);
        local_348 = _Xtime_get_ticks();
        local_d8 = FUN_180191210;
        local_e8._8_8_ = &local_348;
        local_e8._0_8_ = 0xd000000000000000;
        local_2e8 = &DAT_180c09610;
        uStack_2e0 = 9;
        local_2d8 = 1;
        local_2d0 = local_e8;
        local_378 = (longlong **)&DAT_180c09610;
        uStack_370 = 9;
        FUN_1801858b0(local_110,&local_378,&local_2d8);
        uVar33 = uVar33 | 0x400;
        local_140._0_4_ = 1;
        FUN_180185f70(&DAT_180d6eb28,&local_140);
        local_140._0_4_ = _Stack_100.s.Offset;
        FUN_1801877a0(&DAT_180d6eb28,&local_140,4);
        auVar25 = (undefined1  [8])local_110;
        if ((undefined1 *)0xf < local_f8) {
          auVar25 = local_110;
        }
        FUN_1801877a0(&DAT_180d6eb28,auVar25,_Stack_100.Pointer);
        uVar11 = (int)local_b0;
        local_140._0_4_ = 0;
        FUN_180185f70(&DAT_180d6eb28,&local_140);
        local_140._0_4_ = 4;
        FUN_1801877a0(&DAT_180d6eb28,&local_140,4);
        local_140 = (PSID)CONCAT44(local_140._4_4_,uVar11);
        FUN_1801877a0(&DAT_180d6eb28,&local_140,4);
        if (DAT_180d6ebe0 != '\0') {
          local_140 = (PSID)CONCAT44(local_140._4_4_,(int)DAT_180d6eb30 - (int)DAT_180d6eb28);
          FUN_1803c9190(&DAT_180d6ebc8,local_190,&local_140,4);
          FUN_1803c9190(&DAT_180d6ebc8,local_1a0);
        }
        DAT_180d6eb70 = DAT_180d6eb70 + 1;
        local_2c8 = CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
        local_2c0 = DAT_180d6eb30 - local_2c8;
        FUN_1801806e0(&DAT_180d6eb40,&local_2c8);
        local_68[0] = ((int)DAT_180d6eb30 - (int)DAT_180d6eb28) + 4;
        FUN_180186fb0(&DAT_180d6ea20,local_68,4);
        FUN_180186fb0(&DAT_180d6ea20);
        FUN_180186e20(&DAT_180d6ea20);
        if (CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28) != DAT_180d6eb30) {
          DAT_180d6eb30 = CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
        }
        FUN_1801a2650(local_110);
        if (local_c8[8] != '\0') {
          FUN_180973930(local_c8._0_8_);
        }
      }
      if ((char)local_88 != '\0') {
        FUN_1803cadd0(&local_b0);
        iVar20 = *(int *)(local_388 + 0x238);
        goto LAB_1803c15e3;
      }
    }
    else {
      local_b0 = (longlong *)0xffffffffffffffff;
      local_110 = (undefined1  [8])plVar14;
      pvStack_a8 = (HANDLE)0x0;
      pvStack_a0 = (HANDLE)0x0;
      _Stack_100 = (_union_540)pvVar21;
      local_108 = (undefined1  [8])pvVar22;
      puStack_98 = (undefined1 *)0x0;
      local_f8 = puVar34;
      local_f0 = (DWORD)local_90;
      local_90 = local_90 & 0xffffffff00000000;
      local_378 = (longlong **)local_110;
      bVar15 = FUN_180394840();
      DVar19 = local_f0;
      if (bVar15 == 0) {
        auVar25 = local_108;
        if ((local_108 != (undefined1  [8])0x0) &&
           (DVar17 = GetProcessId((HANDLE)local_108), DVar17 == DVar19)) {
          local_80 = 0;
          local_7c = 0;
          BVar18 = ProcessIdToSessionId(DVar19,&local_80);
          if (BVar18 != 0) {
            DVar19 = GetCurrentProcessId();
            BVar18 = ProcessIdToSessionId(DVar19,&local_7c);
            if ((BVar18 != 0) && (local_80 == local_7c)) {
              local_e8 = (undefined1  [16])0x0;
              local_d8 = (code *)0x0;
              local_c8 = (undefined1  [16])0x0;
              local_b8 = 0;
              local_140 = (PSID)0x0;
              local_398 = (longlong *)0x0;
              cVar16 = FUN_180394750(auVar25,local_e8,&local_140);
              if (cVar16 == '\0') {
LAB_1803c22e7:
                bVar5 = false;
              }
              else {
                pvVar22 = GetCurrentProcess();
                cVar16 = FUN_180394750(pvVar22,local_c8,&local_398);
                if ((cVar16 == '\0') || (BVar18 = EqualSid(local_140,local_398), BVar18 == 0))
                goto LAB_1803c22e7;
                bVar5 = true;
              }
              puVar34 = (undefined1 *)0x0;
              if (local_c8._0_8_ != 0) {
                uVar26 = local_b8 - local_c8._0_8_;
                lVar24 = local_c8._0_8_;
                if (0xfff < uVar26) {
                  if (0x1f < (local_c8._0_8_ - *(longlong *)(local_c8._0_8_ + -8)) - 8U)
                  goto LAB_1803c31d1;
                  uVar26 = uVar26 + 0x27;
                  lVar24 = *(longlong *)(local_c8._0_8_ + -8);
                }
                thunk_FUN_180895720(lVar24,uVar26);
                local_c8 = (undefined1  [16])0x0;
                local_b8 = 0;
              }
              if (local_e8._0_8_ != 0) {
                uVar26 = (longlong)local_d8 - local_e8._0_8_;
                lVar24 = local_e8._0_8_;
                if (0xfff < uVar26) {
                  iVar20 = -1;
                  if (0x1f < (local_e8._0_8_ - *(longlong *)(local_e8._0_8_ + -8)) - 8U)
                  goto LAB_1803c31d8;
                  uVar26 = uVar26 + 0x27;
                  lVar24 = *(longlong *)(local_e8._0_8_ + -8);
                }
                thunk_FUN_180895720(lVar24,uVar26);
              }
              if (bVar5) {
                local_c8._0_9_ = ZEXT89(0x180d6eb78);
                local_c8._9_7_ = 0;
                iVar20 = FUN_180973810(&DAT_180d6eb78);
                if (iVar20 != 0) {
                    /* WARNING: Subroutine does not return */
                  FUN_1809737c0(5);
                }
                if (DAT_180d6ebc4 == 0x7fffffff) {
                  DAT_180d6ebc4 = 0x7ffffffe;
                    /* WARNING: Subroutine does not return */
                  FUN_1809737c0(6);
                }
                local_c8[8] = 1;
                local_3a8[0] = 1;
                FUN_180185e60(&DAT_180d6eb28,local_3a8);
                local_140._0_4_ = 0x4c;
                FUN_1801877a0(&DAT_180d6eb28,&local_140,4);
                FUN_1801877a0(&DAT_180d6eb28,&DAT_180d0d1e0,0x4c);
                local_340 = _Xtime_get_ticks();
                local_d8 = FUN_180191210;
                local_e8._8_8_ = &local_340;
                local_e8._0_8_ = 0xd000000000000000;
                local_128 = (_union_540)0x0;
                local_120 = (undefined1 *)0xf;
                stack0xfffffffffffffec9 = SUB1615((undefined1  [16])0x0,1);
                auVar6[0xf] = 0;
                auVar6._0_15_ = stack0xfffffffffffffec9;
                _local_138 = auVar6 << 8;
                local_140._0_4_ = uVar33 | 0x20;
                FUN_18019f7a0(local_138,0x11);
                local_2b8 = 1;
                local_2b0 = local_e8;
                local_2a8 = &DAT_180c09610;
                local_2a0 = 9;
                local_3b8 = 0;
                FUN_18018ad00(local_200,local_138,&local_2a8,&local_2b8);
                uVar33 = uVar33 | 0x10;
                local_140._0_4_ = 1;
                FUN_180185f70(&DAT_180d6eb28,&local_140);
                local_140 = (PSID)CONCAT44(local_140._4_4_,local_128._0_4_);
                FUN_1801877a0(&DAT_180d6eb28,&local_140,4);
                auVar25 = (undefined1  [8])local_138;
                if (0xf < local_120) {
                  auVar25 = local_138;
                }
                FUN_1801877a0(&DAT_180d6eb28,auVar25,local_128);
                if (DAT_180d6ebe0 != '\0') {
                  local_140 = (PSID)CONCAT44(local_140._4_4_,(int)DAT_180d6eb30 - (int)DAT_180d6eb28
                                            );
                  FUN_1803c9190(&DAT_180d6ebc8,local_1b0,&local_140,4);
                  FUN_1803c9190(&DAT_180d6ebc8,local_1c0,
                                CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28),
                                DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28));
                }
                DAT_180d6eb70 = DAT_180d6eb70 + 1;
                local_298 = CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
                local_290 = DAT_180d6eb30 - local_298;
                FUN_1801806e0(&DAT_180d6eb40,&local_298);
                local_6c = ((int)DAT_180d6eb30 - (int)DAT_180d6eb28) + 4;
                FUN_180186fb0(&DAT_180d6ea20,&local_6c,4);
                FUN_180186fb0(&DAT_180d6ea20,CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28),
                              DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28));
                FUN_180186e20(&DAT_180d6ea20);
                if (CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28) != DAT_180d6eb30) {
                  DAT_180d6eb30 = CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
                }
                if (0xf < local_120) {
                  uVar26 = (longlong)local_120 + 1;
                  auVar25 = local_138;
                  if (0xfff < uVar26) {
                    auVar25 = *(undefined1 (*) [8])((longlong)local_138 + -8);
                    if (0x1f < ((longlong)local_138 - (longlong)auVar25) - 8U) goto LAB_1803c31df;
                    uVar26 = (longlong)local_120 + 0x28;
                  }
                  thunk_FUN_180895720(auVar25,uVar26);
                }
                local_128 = (_union_540)0x0;
                local_120 = (undefined1 *)0xf;
                auVar7[0xf] = 0;
                auVar7._0_15_ = stack0xfffffffffffffec9;
                _local_138 = auVar7 << 8;
                FUN_180973930(&DAT_180d6eb78);
                goto LAB_1803c26ff;
              }
            }
          }
        }
        plVar23 = (longlong *)0x0;
        local_c8 = ZEXT816(0x180d6eb78);
        FUN_18019fb70(&DAT_180d6eb78);
        local_c8[8] = 1;
        local_3a8[0] = 1;
        FUN_180185e60(&DAT_180d6eb28,local_3a8);
        local_140._0_4_ = 0x2c;
        FUN_1801877a0(&DAT_180d6eb28,&local_140,4);
        FUN_1801877a0(&DAT_180d6eb28,&DAT_180d0d9d0,0x2c);
        local_338 = _Xtime_get_ticks();
        local_d8 = FUN_180191210;
        local_e8._8_8_ = &local_338;
        local_e8._0_8_ = 0xd000000000000000;
        local_288 = &DAT_180c09610;
        uStack_280 = 9;
        local_278 = 1;
        local_270 = local_e8;
        local_398 = (longlong *)&DAT_180c09610;
        uStack_390 = 9;
        FUN_1801858b0(local_60,&local_398,&local_278);
        local_140._0_4_ = 1;
        FUN_180185f70(&DAT_180d6eb28,&local_140);
        local_140 = (PSID)CONCAT44(local_140._4_4_,local_50);
        FUN_1801877a0(&DAT_180d6eb28,&local_140,4);
        pppppuVar27 = local_60;
        if (0xf < local_48) {
          pppppuVar27 = (undefined8 *****)local_60[0];
        }
        FUN_1801877a0(&DAT_180d6eb28,pppppuVar27,CONCAT44(uStack_4c,local_50));
        if (DAT_180d6ebe0 != '\0') {
          local_140 = (PSID)CONCAT44(local_140._4_4_,(int)DAT_180d6eb30 - (int)DAT_180d6eb28);
          FUN_1803c9190(&DAT_180d6ebc8,local_1d0,&local_140,4);
          FUN_1803c9190(&DAT_180d6ebc8,local_1e0);
        }
        DAT_180d6eb70 = DAT_180d6eb70 + 1;
        local_268 = CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
        local_260 = DAT_180d6eb30 - local_268;
        FUN_1801806e0(&DAT_180d6eb40,&local_268);
        local_70 = ((int)DAT_180d6eb30 - (int)DAT_180d6eb28) + 4;
        FUN_180186fb0(&DAT_180d6ea20,&local_70,4);
        FUN_180186fb0(&DAT_180d6ea20);
        FUN_180186e20(&DAT_180d6ea20);
        if (CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28) != DAT_180d6eb30) {
          DAT_180d6eb30 = CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
        }
        FUN_1801a2650(local_60);
        FUN_180973930(&DAT_180d6eb78);
        if (local_110 != (undefined1  [8])0xffffffffffffffff) {
          CancelIoEx((HANDLE)local_110,(LPOVERLAPPED)0x0);
          DisconnectNamedPipe((HANDLE)local_110);
        }
        uVar33 = uVar33 | 0x208;
        if (local_110 != (undefined1  [8])0xffffffffffffffff) {
          CancelIoEx((HANDLE)local_110,(LPOVERLAPPED)0x0);
          DisconnectNamedPipe((HANDLE)local_110);
          CloseHandle((HANDLE)local_110);
          local_110 = (undefined1  [8])0xffffffffffffffff;
        }
        auVar25 = local_108;
        if (local_108 != (undefined1  [8])0x0) {
          auVar9._8_8_ = 0;
          auVar9._0_8_ = _Stack_100;
          _local_108 = auVar9 << 0x40;
          CloseHandle((HANDLE)auVar25);
        }
        _Var13 = _Stack_100;
        if (_Stack_100.Pointer != (HANDLE)0x0) {
          _Stack_100 = (_union_540)0x0;
          CloseHandle(_Var13.Pointer);
        }
        puVar34 = local_f8;
        lVar24 = local_388;
        if (local_f8 != (undefined1 *)0x0) {
          local_f8 = (undefined1 *)0x0;
          CloseHandle(puVar34);
          lVar24 = local_388;
        }
      }
      else {
LAB_1803c26ff:
        plVar23 = (longlong *)0x0;
        local_d0[0] = 0x32504242;
        local_258 = local_d0;
        local_250 = 4;
        FUN_1803cae60(local_110,local_228,&local_258);
        if (local_220 == '\0') {
          local_c8._0_9_ = ZEXT89(0x180d6eb78);
          local_c8._9_7_ = 0;
          iVar20 = FUN_180973810(&DAT_180d6eb78);
          if (iVar20 != 0) {
                    /* WARNING: Subroutine does not return */
            FUN_1809737c0(5);
          }
          if (DAT_180d6ebc4 == 0x7fffffff) {
            DAT_180d6ebc4 = 0x7ffffffe;
                    /* WARNING: Subroutine does not return */
            FUN_1809737c0(6);
          }
          local_c8[8] = 1;
          local_3a8[0] = 1;
          FUN_180185e60(&DAT_180d6eb28,local_3a8);
          local_140._0_4_ = 0x3c;
          FUN_1801877a0(&DAT_180d6eb28,&local_140,4);
          FUN_1801877a0(&DAT_180d6eb28,&DAT_180d0d990,0x3c);
          local_330 = _Xtime_get_ticks();
          local_d8 = FUN_180191210;
          local_e8._8_8_ = &local_330;
          local_e8._0_8_ = 0xd000000000000000;
          local_128 = (_union_540)0x0;
          local_120 = (undefined1 *)0xf;
          stack0xfffffffffffffec9 = SUB1615((undefined1  [16])0x0,1);
          auVar8[0xf] = 0;
          auVar8._0_15_ = stack0xfffffffffffffec9;
          _local_138 = auVar8 << 8;
          local_140._0_4_ = uVar33 | 0x80;
          FUN_18019f7a0(local_138,0x11);
          local_248 = 1;
          local_240 = local_e8;
          local_238 = &DAT_180c09610;
          local_230 = 9;
          local_3b8 = 0;
          FUN_18018ad00(local_1f8,local_138,&local_238);
          local_140._0_4_ = 1;
          FUN_180185f70(&DAT_180d6eb28,&local_140);
          local_140._0_4_ = local_128._0_4_;
          FUN_1801877a0(&DAT_180d6eb28,&local_140,4);
          auVar25 = (undefined1  [8])local_138;
          if (0xf < local_120) {
            auVar25 = local_138;
          }
          FUN_1801877a0(&DAT_180d6eb28,auVar25,local_128);
          uVar11 = local_228[0];
          local_140._0_4_ = 0;
          FUN_180185f70(&DAT_180d6eb28,&local_140);
          local_140._0_4_ = 4;
          FUN_1801877a0(&DAT_180d6eb28,&local_140,4);
          local_140 = (PSID)CONCAT44(local_140._4_4_,uVar11);
          FUN_1801877a0(&DAT_180d6eb28,&local_140,4);
          if (DAT_180d6ebe0 != '\0') {
            local_140 = (PSID)CONCAT44(local_140._4_4_,(int)DAT_180d6eb30 - (int)DAT_180d6eb28);
            FUN_1803c9190(&DAT_180d6ebc8,local_1f0,&local_140,4);
            FUN_1803c9190(&DAT_180d6ebc8,local_160);
          }
          DAT_180d6eb70 = DAT_180d6eb70 + 1;
          local_328 = CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
          local_320 = DAT_180d6eb30 - local_328;
          FUN_1801806e0(&DAT_180d6eb40,&local_328);
          local_74 = ((int)DAT_180d6eb30 - (int)DAT_180d6eb28) + 4;
          FUN_180186fb0(&DAT_180d6ea20,&local_74,4);
          FUN_180186fb0(&DAT_180d6ea20);
          FUN_180186e20(&DAT_180d6ea20);
          if (CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28) != DAT_180d6eb30) {
            DAT_180d6eb30 = CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
          }
          FUN_1801a2650(local_138);
          FUN_180973930(&DAT_180d6eb78);
          if (local_110 != (undefined1  [8])0xffffffffffffffff) {
            CancelIoEx((HANDLE)local_110,(LPOVERLAPPED)0x0);
            DisconnectNamedPipe((HANDLE)local_110);
          }
          uVar33 = uVar33 | 0x48;
          FUN_1803cadd0(local_110);
          lVar24 = local_388;
        }
        else {
          plVar23 = (longlong *)FUN_180976d80(0x178);
          local_218 = plVar23;
          FUN_1809bef30(plVar23,0,0x178);
          local_118 = local_f0;
          local_120 = local_f8;
          local_138 = local_110;
          lVar24 = local_388;
          local_110 = (undefined1  [8])0xffffffffffffffff;
          local_128 = _Stack_100;
          UStack_130 = (ULONG_PTR)local_108;
          _local_108 = ZEXT816(0);
          local_f8 = (undefined1 *)0x0;
          local_f0 = 0;
          local_398 = (longlong *)local_138;
          FUN_1803bd780(plVar23,local_388);
          UVar12 = UStack_130;
          *plVar23 = (longlong)&PTR_FUN_180c6efb8;
          plVar23[0x29] = (longlong)local_138;
          _local_138 = ZEXT816(0xffffffffffffffff);
          plVar23[0x2a] = UVar12;
          *(_union_540 *)(plVar23 + 0x2b) = local_128;
          plVar23[0x2c] = (longlong)local_120;
          *(DWORD *)(plVar23 + 0x2d) = local_118;
          *(uint *)(plVar23 + 0x2e) = (uint)(bVar15 ^ 1);
          local_118 = 0;
          local_120 = (undefined1 *)0x0;
          local_128 = (_union_540)0x0;
          uVar33 = uVar33 | 0x108;
          if (local_110 != (undefined1  [8])0xffffffffffffffff) {
            CancelIoEx((HANDLE)local_110,(LPOVERLAPPED)0x0);
            DisconnectNamedPipe((HANDLE)local_110);
            CloseHandle((HANDLE)local_110);
            local_110 = (undefined1  [8])0xffffffffffffffff;
          }
          auVar25 = local_108;
          if (local_108 != (undefined1  [8])0x0) {
            auVar10._8_8_ = 0;
            auVar10._0_8_ = _Stack_100;
            _local_108 = auVar10 << 0x40;
            CloseHandle((HANDLE)auVar25);
          }
          _Var13 = _Stack_100;
          if (_Stack_100.Pointer != (HANDLE)0x0) {
            _Stack_100 = (_union_540)0x0;
            CloseHandle(_Var13.Pointer);
          }
          puVar34 = local_f8;
          if (local_f8 != (undefined1 *)0x0) {
            local_f8 = (undefined1 *)0x0;
            CloseHandle(puVar34);
          }
        }
      }
      if (plVar23 != (longlong *)0x0) {
        local_378 = (longlong **)0x0;
        local_398 = plVar23;
        FUN_1803db220(lVar24,&local_398);
        if (local_398 != (longlong *)0x0) {
          (**(code **)(*local_398 + 0x18))(local_398,1);
        }
      }
      if ((char)local_88 != '\0') {
        if (local_b0 != (longlong *)0xffffffffffffffff) {
          CancelIoEx(local_b0,(LPOVERLAPPED)0x0);
          DisconnectNamedPipe(local_b0);
          CloseHandle(local_b0);
          local_b0 = (longlong *)0xffffffffffffffff;
        }
        pvVar22 = pvStack_a8;
        if (pvStack_a8 != (HANDLE)0x0) {
          pvStack_a8 = (HANDLE)0x0;
          CloseHandle(pvVar22);
        }
        pvVar22 = pvStack_a0;
        if (pvStack_a0 != (HANDLE)0x0) {
          pvStack_a0 = (HANDLE)0x0;
          CloseHandle(pvVar22);
        }
        puVar34 = puStack_98;
        if (puStack_98 != (undefined1 *)0x0) {
          puStack_98 = (undefined1 *)0x0;
          CloseHandle(puVar34);
        }
      }
    }
    iVar20 = *(int *)(local_388 + 0x238);
  } while( true );
}

