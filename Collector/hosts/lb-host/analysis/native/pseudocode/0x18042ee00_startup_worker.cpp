// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x18042ee00; descriptive alias: startup_worker
// Evidence: ev_380e35d86b7a7617f708d4009f20d3a0bbdc166f9a1c083922adc5bbcddd31a9
// Original Evidence: rea-startup-worker.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* WARNING: Removing unreachable block (ram,0x00018042f434) */
/* WARNING: Removing unreachable block (ram,0x00018042f40e) */
/* WARNING: Removing unreachable block (ram,0x00018042f43b) */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8 FUN_18042ee00(undefined8 *param_1)

{
  undefined8 *puVar1;
  code *pcVar2;
  undefined1 auVar3 [16];
  undefined1 auVar4 [16];
  undefined1 auVar5 [16];
  undefined1 auVar6 [16];
  undefined1 auVar7 [16];
  char cVar8;
  HRESULT HVar9;
  int iVar10;
  DWORD DVar11;
  BOOL BVar12;
  undefined4 uVar13;
  ulonglong uVar14;
  LPCWSTR pWVar15;
  undefined4 *puVar16;
  longlong *plVar17;
  HANDLE hProcess;
  longlong lVar18;
  longlong lVar19;
  char *_Str;
  undefined8 uVar20;
  int *piVar21;
  undefined1 *puVar22;
  undefined8 *puVar23;
  size_t sVar24;
  undefined1 *puVar25;
  longlong lVar26;
  ulonglong uVar27;
  ulonglong uVar28;
  undefined8 ******ppppppuVar29;
  undefined **ppuVar30;
  undefined1 *puVar31;
  undefined **ppuVar32;
  LPCVOID lpBaseAddress;
  undefined8 extraout_XMM0_Qa;
  undefined1 auStackY_4a8 [8];
  undefined1 auStackY_4a0 [24];
  undefined1 local_478 [8];
  undefined8 *****local_470 [3];
  ulonglong local_458;
  undefined1 local_450 [40];
  undefined8 local_428;
  undefined8 uStack_420;
  undefined8 uStack_418;
  undefined8 uStack_410;
  undefined8 local_408;
  undefined8 uStack_400;
  undefined8 uStack_3f8;
  undefined8 uStack_3f0;
  undefined8 local_3e8;
  undefined8 uStack_3e0;
  undefined8 uStack_3d8;
  undefined8 uStack_3d0;
  undefined8 local_3c8;
  undefined8 uStack_3c0;
  undefined8 uStack_3b8;
  undefined8 uStack_3b0;
  undefined8 local_3a8;
  undefined8 uStack_3a0;
  undefined8 *****local_398;
  _SYSTEM_INFO local_390;
  undefined1 local_360 [2];
  undefined1 auStack_35e [14];
  undefined **local_350;
  undefined4 *local_348;
  undefined8 local_338;
  undefined **local_330;
  undefined8 ****local_318 [2];
  undefined *local_308;
  undefined1 auStack_300 [16];
  undefined8 local_2f0;
  longlong *local_2e8;
  GUID local_2d8;
  undefined1 local_2c8 [16];
  ulonglong local_2b8;
  ulonglong local_2b0;
  undefined *local_2a8;
  undefined8 *****local_2a0;
  code *local_298;
  undefined *local_290;
  undefined4 local_288;
  undefined4 local_284;
  undefined4 local_280;
  undefined4 local_27c;
  undefined1 local_278 [16];
  undefined **local_268;
  undefined1 local_260 [8];
  undefined8 uStack_258;
  undefined **ppuStack_250;
  undefined8 uStack_248;
  undefined4 local_240 [2];
  char local_238;
  undefined8 *local_230;
  undefined1 local_228 [16];
  undefined8 local_218;
  longlong *local_210;
  undefined1 *local_208;
  undefined1 *puStack_200;
  undefined **ppuStack_1f8;
  ulonglong uStack_1f0;
  undefined8 local_1e8;
  undefined8 uStack_1e0;
  undefined1 auStack_1d8 [16];
  undefined1 local_1c8 [16];
  undefined8 uStack_1b8;
  undefined8 uStack_1b0;
  undefined1 local_1a8 [16];
  undefined8 uStack_198;
  longlong lStack_190;
  undefined8 local_188;
  undefined8 local_180;
  LARGE_INTEGER local_178;
  LARGE_INTEGER local_170;
  LARGE_INTEGER local_168;
  undefined8 *local_160;
  undefined8 local_158;
  undefined8 local_150;
  undefined **local_148;
  undefined8 local_140;
  undefined8 uStack_138;
  undefined **ppuStack_130;
  undefined8 uStack_128;
  char local_120;
  undefined8 local_118;
  undefined8 uStack_110;
  longlong lStack_108;
  longlong lStack_100;
  undefined8 local_f8;
  undefined8 uStack_f0;
  undefined8 uStack_e8;
  undefined8 uStack_e0;
  undefined8 local_d8;
  undefined8 uStack_d0;
  undefined8 uStack_c8;
  undefined8 uStack_c0;
  undefined8 uStack_b8;
  undefined8 uStack_b0;
  undefined8 local_a8;
  undefined8 uStack_a0;
  undefined8 uStack_98;
  undefined8 uStack_90;
  undefined8 local_88;
  undefined8 uStack_80;
  undefined8 uStack_78;
  undefined8 uStack_70;
  undefined8 uStack_68;
  undefined8 uStack_60;
  ulonglong local_58;
  
  local_58 = DAT_180d06cc0 ^ (ulonglong)auStackY_4a8;
  local_2d8.Data1 = 0;
  local_2d8.Data2 = 0;
  local_2d8.Data3 = 0;
  local_2d8.Data4[0] = '\0';
  local_2d8.Data4[1] = '\0';
  local_2d8.Data4[2] = '\0';
  local_2d8.Data4[3] = '\0';
  local_2d8.Data4[4] = '\0';
  local_2d8.Data4[5] = '\0';
  local_2d8.Data4[6] = '\0';
  local_2d8.Data4[7] = '\0';
  local_a8 = 0;
  uStack_a0 = 0;
  uStack_98 = 0;
  uStack_90 = 0;
  local_88 = 0;
  uStack_80 = 0;
  uStack_78 = 0;
  uStack_70 = 0;
  uStack_68 = 0;
  uStack_60 = 0;
  local_160 = param_1;
  HVar9 = CoCreateGuid(&local_2d8);
  if ((HVar9 < 0) || (iVar10 = StringFromGUID2(&local_2d8,(LPOLESTR)&local_a8,0x28), iVar10 == 0)) {
LAB_18042f2dc:
    puVar31 = auStackY_4a8;
    puVar22 = auStackY_4a8;
    ppuVar32 = (undefined **)0x0;
    LOCK();
    DAT_180d6e971 = 0;
    UNLOCK();
    LOCK();
    DAT_180d6e970 = 0;
    UNLOCK();
    DAT_180d20bd0 = GetModuleHandleW((LPCWSTR)0x0);
    GetSystemInfo(&local_390);
    DAT_180d20be0 = local_390.lpMinimumApplicationAddress;
    DAT_180d20be8 = local_390.lpMaximumApplicationAddress;
    iVar10 = FUN_180973810(&DAT_180d6eb78);
    if (iVar10 != 0) {
                    /* WARNING: Subroutine does not return */
      FUN_1809737c0(5);
    }
    if (DAT_180d6ebc4 == 0x7fffffff) {
      DAT_180d6ebc4 = 0x7ffffffe;
                    /* WARNING: Subroutine does not return */
      FUN_1809737c0(6);
    }
    local_478[0] = 2;
    FUN_180185e60(&DAT_180d6eb28,local_478);
    local_318[0] = (undefined8 ****)CONCAT44(local_318[0]._4_4_,0x2b);
    FUN_1801877a0(&DAT_180d6eb28,local_318,4);
    FUN_1801877a0(&DAT_180d6eb28,&DAT_180d0dac8,0x2b);
    local_318[0] = (undefined8 ****)_Xtime_get_ticks();
    ppuVar30 = &local_2a8;
    lVar26 = 1;
    do {
      *ppuVar30 = (undefined *)0x0;
      ppuVar30 = ppuVar30 + 1;
      lVar26 = lVar26 + -1;
    } while (lVar26 != 0);
    local_2a0 = local_318;
    local_298 = FUN_180191210;
    local_2a8 = (undefined *)0xd000000000000000;
    local_350 = (undefined **)0x0;
    local_348 = (undefined4 *)0xf;
    stack0xfffffffffffffca1 = SUB1615((undefined1  [16])0x0,1);
    auVar4[0xf] = 0;
    auVar4._0_15_ = stack0xfffffffffffffca1;
    _local_360 = auVar4 << 8;
    FUN_18019f7a0(local_360,0x11);
    local_2d8.Data4 = (uchar  [8])&local_2a8;
    local_2d8.Data1 = 1;
    local_2d8.Data2 = 0;
    local_2d8.Data3 = 0;
    local_308 = &DAT_180c09610;
    auStack_300._0_8_ = 9;
    FUN_18018ad00(&local_398,local_360,&local_308,&local_2d8);
    local_318[0]._0_4_ = 1;
    FUN_180185f70(&DAT_180d6eb28,local_318);
    local_318[0] = (undefined8 ****)CONCAT44(local_318[0]._4_4_,local_350._0_4_);
    FUN_1801877a0(&DAT_180d6eb28,local_318,4);
    puVar25 = local_360;
    if ((undefined4 *)0xf < local_348) {
      puVar25 = (undefined1 *)_local_360;
    }
    FUN_1801877a0(&DAT_180d6eb28,puVar25,local_350);
    if (DAT_180d6ebe0 != '\0') {
      local_318[0] = (undefined8 ****)
                     CONCAT44(local_318[0]._4_4_,(int)DAT_180d6eb30 - (int)DAT_180d6eb28);
      FUN_1803c9190(&DAT_180d6ebc8,&local_308,local_318,4);
      FUN_1803c9190(&DAT_180d6ebc8,&local_308,CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28),
                    DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28));
    }
    DAT_180d6eb70 = DAT_180d6eb70 + 1;
    local_308 = (undefined *)CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
    auStack_300._0_8_ = DAT_180d6eb30 - (longlong)local_308;
    FUN_1801806e0(&DAT_180d6eb40,&local_308);
    local_338 = (undefined8 ******)
                CONCAT44(local_338._4_4_,((int)DAT_180d6eb30 - (int)DAT_180d6eb28) + 4);
    FUN_180186fb0(&DAT_180d6ea20,&local_338,4);
    FUN_180186fb0(&DAT_180d6ea20,CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28),
                  DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28));
    FUN_180186e20(&DAT_180d6ea20);
    if (CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28) != DAT_180d6eb30) {
      DAT_180d6eb30 = CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
    }
    if (local_348 < &DAT_00000010) goto LAB_18042f636;
    puVar16 = (undefined4 *)((longlong)local_348 + 1);
    lVar26 = (longlong)_local_360;
    if ((undefined4 *)0xfff < puVar16) {
      lVar26 = *(longlong *)((longlong)_local_360 + -8);
      if (0x1f < ((longlong)_local_360 - lVar26) - 8U) goto LAB_18042fd58;
      puVar16 = local_348 + 10;
    }
    thunk_FUN_180895720(lVar26,puVar16);
LAB_18042f636:
    local_350 = (undefined **)0x0;
    local_348 = (undefined4 *)0xf;
    auVar5[0xf] = 0;
    auVar5._0_15_ = stack0xfffffffffffffca1;
    _local_360 = auVar5 << 8;
    FUN_180973930(&DAT_180d6eb78);
    plVar17 = (longlong *)FUN_1801fe670(&local_398);
    lVar26 = *plVar17;
LAB_18042f675:
    local_318[0] = (undefined8 ****)((ulonglong)local_318[0] & 0xffffffff00000000);
    if (DAT_180d219a8 == '\0') {
      uVar14 = DAT_180d21540 + 0x6df70a65e6632e3aU ^ 0xbcd1994011bf48c;
    }
    else {
      uVar14 = FUN_18052c740(&DAT_180d21540,0xbcd1994011bf401);
    }
    if ((uVar14 != 0) &&
       (lpBaseAddress = (LPCVOID)((longlong)&DAT_180d20bd0->unused + uVar14),
       (longlong)lpBaseAddress - 1U < 0xfffffffffffffffc)) {
      local_338 = (undefined8 ******)0x0;
      hProcess = GetCurrentProcess();
      BVar12 = ReadProcessMemory(hProcess,lpBaseAddress,local_318,4,&local_338);
      if ((BVar12 == 0) || ((local_338 != (undefined8 ******)0x4 || ((int)local_318[0] != 2))))
      goto LAB_18042f712;
      _Str = (char *)FUN_180421a40(local_450);
      local_228 = (undefined1  [16])0x0;
      local_218 = 0;
      local_210 = (longlong *)0x0;
      local_230 = (undefined8 *)0x0;
      FUN_1801823c0(local_228);
      FUN_1801830d0(&local_230,&DAT_180c09358,&DAT_180c09390,1);
      local_118 = 0;
      uStack_110 = 0;
      lStack_108 = 0;
      lStack_100 = 0;
      local_f8 = 0;
      uStack_f0 = 0;
      uStack_e8 = 0;
      uStack_e0 = 0;
      local_d8 = 0;
      uStack_d0 = 0;
      uStack_c8 = 0;
      uStack_c0 = 0;
      uStack_b8 = 0;
      uStack_b0 = 0;
      cVar8 = FUN_180180dc0(_Str,&local_118,&local_230,0);
      if (cVar8 != '\0') {
        local_278 = (undefined1  [16])0x0;
        local_268 = (undefined **)0x0;
        ppuStack_250 = (undefined **)0x0;
        uStack_248 = 0xf;
        stack0xfffffffffffffda1 = SUB1615((undefined1  [16])0x0,1);
        auVar6[0xf] = 0;
        auVar6._0_15_ = stack0xfffffffffffffda1;
        _local_260 = auVar6 << 8;
        if ((ulonglong)((lStack_100 - lStack_108 >> 3) * -0x5555555555555555) < 2) {
          puVar23 = &uStack_c0;
        }
        else {
          puVar23 = (undefined8 *)(lStack_108 + 0x18);
        }
        FUN_180181430(puVar23,local_360);
        if ((ulonglong)((lStack_100 - lStack_108 >> 3) * -0x5555555555555555) < 3) {
          puVar23 = &uStack_c0;
        }
        else {
          puVar23 = (undefined8 *)(lStack_108 + 0x30);
        }
        uVar20 = FUN_180181430(puVar23,&local_2a8);
        FUN_180181710(local_260,uVar20);
        FUN_1801a2650(&local_2a8);
        auStack_300 = (undefined1  [16])0x0;
        local_2f0 = 0;
        local_2e8 = (longlong *)0x0;
        local_308 = (undefined *)0x0;
        FUN_1801823c0(auStack_300);
        FUN_1801830d0(&local_308,&DAT_180c09394,&DAT_180c09397,1);
        puStack_200 = local_360;
        if ((undefined4 *)0xf < local_348) {
          puStack_200 = (undefined1 *)_local_360;
        }
        puStack_200 = (undefined1 *)((longlong)local_350 + (longlong)puStack_200);
        local_208 = local_360;
        if ((undefined4 *)0xf < local_348) {
          local_208 = (undefined1 *)_local_360;
        }
        ppuStack_1f8 = &local_308;
        uStack_1f0 = 0;
        local_1e8 = 0;
        uStack_1e0 = 0;
        auStack_1d8 = (undefined1  [16])0x0;
        local_1c8 = (undefined1  [16])0x0;
        uStack_1b8 = 0;
        uStack_1b0 = 0;
        local_1a8 = (undefined1  [16])0x0;
        uStack_198 = 0;
        lStack_190 = 0;
        local_188 = 0;
        local_180 = 0;
        cVar8 = FUN_180182e40(local_208,puStack_200,&local_1e8,&local_308);
        ppuVar30 = ppuStack_1f8;
        if (cVar8 == '\0') {
          ppuVar30 = ppuVar32;
        }
        local_428 = 0;
        uStack_420 = 0;
        uStack_418 = 0;
        uStack_410 = 0;
        local_408 = 0;
        uStack_400 = 0;
        uStack_3f8 = 0;
        uStack_3f0 = 0;
        local_3e8 = 0;
        uStack_3e0 = 0;
        uStack_3d8 = 0;
        uStack_3d0 = 0;
        local_3c8 = 0;
        uStack_3c0 = 0;
        uStack_3b8 = 0;
        uStack_3b0 = 0;
        local_3a8 = 0;
        uStack_3a0 = 0;
LAB_18042fabf:
LAB_18042fad0:
        ppuStack_1f8 = ppuVar30;
        ppuVar32 = (undefined **)0x0;
        if (ppuStack_1f8 != (undefined **)0x0) {
          plVar17 = &lStack_190;
          if (auStack_1d8._8_8_ != auStack_1d8._0_8_) {
            plVar17 = (longlong *)auStack_1d8._0_8_;
          }
          FUN_180181430(plVar17,local_470);
          piVar21 = (int *)FUN_18097f274();
          ppppppuVar29 = local_470;
          if (0xf < local_458) {
            ppppppuVar29 = (undefined8 ******)local_470[0];
          }
          *piVar21 = 0;
          uVar13 = FUN_18097edb0(ppppppuVar29,&local_398,10);
          if (ppppppuVar29 == (undefined8 ******)local_398) {
                    /* WARNING: Subroutine does not return */
            FUN_18096ee70("invalid stoi argument");
          }
          if (*piVar21 == 0x22) {
                    /* WARNING: Subroutine does not return */
            FUN_18096eed0("stoi argument out of range");
          }
          ppuVar30 = (undefined **)local_278._8_8_;
          if ((undefined **)local_278._8_8_ == local_268) {
            if (local_278._8_8_ - local_278._0_8_ == -4) {
                    /* WARNING: Subroutine does not return */
              FUN_180183310();
            }
            uVar14 = ((longlong)(local_278._8_8_ - local_278._0_8_) >> 2) + 1;
            uVar27 = (longlong)local_268 - local_278._0_8_ >> 2;
            if (0x3fffffffffffffff - (uVar27 >> 1) < uVar27) {
              uVar28 = 0x3fffffffffffffff;
            }
            else {
              uVar27 = (uVar27 >> 1) + uVar27;
              uVar28 = uVar14;
              if (uVar14 <= uVar27) {
                uVar28 = uVar27;
              }
              if (0x3fffffffffffffff < uVar28) {
                    /* WARNING: Subroutine does not return */
                FUN_1801a22b0();
              }
            }
            uVar27 = local_278._8_8_ - local_278._0_8_;
            puVar22 = (undefined1 *)FUN_1801a22d0(uVar28 * 4);
            ppuVar32 = (undefined **)(uVar27 & 0xfffffffffffffffc);
            *(undefined4 *)(puVar22 + (longlong)ppuVar32) = uVar13;
            if (ppuVar30 == (undefined **)local_278._8_8_) {
              lVar26 = local_278._8_8_ - local_278._0_8_;
              puVar25 = puVar22;
              ppuVar30 = (undefined **)local_278._0_8_;
            }
            else {
              FUN_1809bf2f0(puVar22,local_278._0_8_,(longlong)ppuVar30 - local_278._0_8_);
              lVar26 = local_278._8_8_ - (longlong)ppuVar30;
              puVar25 = (undefined1 *)((longlong)ppuVar32 + (longlong)(puVar22 + 4));
            }
            FUN_1809bf2f0(puVar25,ppuVar30,lVar26);
            if (local_278._0_8_ != 0) {
              uVar27 = ((longlong)local_268 - local_278._0_8_ >> 2) * 4;
              lVar26 = local_278._0_8_;
              if (0xfff < uVar27) {
                lVar26 = *(longlong *)(local_278._0_8_ + -8);
                if (0x1f < (local_278._0_8_ - lVar26) - 8U) goto LAB_18042fd58;
                uVar27 = uVar27 + 0x27;
              }
              thunk_FUN_180895720(lVar26,uVar27);
            }
            local_278._8_8_ = puVar22 + uVar14 * 4;
            local_278._0_8_ = puVar22;
            local_268 = (undefined **)(puVar22 + uVar28 * 4);
          }
          else {
            *(undefined4 *)local_278._8_8_ = uVar13;
            local_278._8_8_ = (undefined4 *)(local_278._8_8_ + 4);
          }
          ppuVar30 = (undefined **)0x0;
          FUN_1801a2650(local_470);
          puVar22 = *(undefined1 **)(auStack_1d8._0_8_ + 8);
          if (*(undefined1 **)auStack_1d8._0_8_ == puVar22) goto code_r0x00018042fc9f;
          goto LAB_18042fd0c;
        }
        goto LAB_18042fd5f;
      }
      if (0xf < *(ulonglong *)(_Str + 0x18)) {
        _Str = *(char **)_Str;
      }
      FUN_18019fb70(&DAT_180d6eb78);
      local_478[0] = 0;
      FUN_180185e60(&DAT_180d6eb28,local_478);
      local_338._0_4_ = 0x24;
      FUN_1801877a0(&DAT_180d6eb28,&local_338,4);
      FUN_1801877a0(&DAT_180d6eb28,&DAT_180d07b68,0x24);
      local_398 = (undefined8 *****)_Xtime_get_ticks();
      ppuVar30 = &local_2a8;
      lVar26 = 1;
      do {
        *ppuVar30 = (undefined *)0x0;
        ppuVar30 = ppuVar30 + 1;
        lVar26 = lVar26 + -1;
      } while (lVar26 != 0);
      local_2a0 = &local_398;
      local_298 = FUN_180191210;
      local_2a8 = (undefined *)0xd000000000000000;
      local_2d8.Data4 = (uchar  [8])&local_2a8;
      local_2d8.Data1 = 1;
      local_2d8.Data2 = 0;
      local_2d8.Data3 = 0;
      local_308 = &DAT_180c09610;
      auStack_300._0_8_ = 9;
      FUN_1801858b0(local_360,&local_308,&local_2d8);
      local_338._0_4_ = 1;
      FUN_180185f70(&DAT_180d6eb28,&local_338);
      local_338._0_4_ = local_350._0_4_;
      FUN_1801877a0(&DAT_180d6eb28,&local_338,4);
      puVar25 = local_360;
      if ((undefined4 *)0xf < local_348) {
        puVar25 = (undefined1 *)_local_360;
      }
      FUN_1801877a0(&DAT_180d6eb28,puVar25,local_350);
      sVar24 = strlen(_Str);
      local_338._0_4_ = 1;
      FUN_180185f70(&DAT_180d6eb28,&local_338);
      local_338 = (undefined8 ******)CONCAT44(local_338._4_4_,(int)sVar24);
      FUN_1801877a0(&DAT_180d6eb28,&local_338,4);
      FUN_1801877a0(&DAT_180d6eb28,_Str,sVar24);
      if (DAT_180d6ebe0 != '\0') {
        local_338 = (undefined8 ******)
                    CONCAT44(local_338._4_4_,(int)DAT_180d6eb30 - (int)DAT_180d6eb28);
        FUN_1803c9190(&DAT_180d6ebc8,&local_308,&local_338,4);
        FUN_1803c9190(&DAT_180d6ebc8,&local_308,CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28),
                      DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28));
      }
      DAT_180d6eb70 = DAT_180d6eb70 + 1;
      local_308 = (undefined *)CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
      auStack_300._0_8_ = DAT_180d6eb30 - (longlong)local_308;
      FUN_1801806e0(&DAT_180d6eb40,&local_308);
      local_318[0] = (undefined8 ****)
                     CONCAT44(local_318[0]._4_4_,((int)DAT_180d6eb30 - (int)DAT_180d6eb28) + 4);
      FUN_180186fb0(&DAT_180d6ea20,local_318,4);
      FUN_180186fb0(&DAT_180d6ea20,CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28),
                    DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28));
      FUN_180186e20(&DAT_180d6ea20);
      if (CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28) != DAT_180d6eb30) {
        DAT_180d6eb30 = CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
      }
      FUN_1801a2650(local_360);
      FUN_180973930(&DAT_180d6eb78);
      local_120 = '\0';
      FUN_1801810b0(&lStack_108);
      if (local_230 != (undefined8 *)0x0) {
        LOCK();
        piVar21 = (int *)((longlong)local_230 + 0x2c);
        iVar10 = *piVar21;
        *piVar21 = *piVar21 + -1;
        UNLOCK();
        puVar23 = local_230;
        if (iVar10 == 1) {
          while (puVar23 != (undefined8 *)0x0) {
            puVar1 = (undefined8 *)puVar23[2];
            puVar23[2] = 0;
            (**(code **)*puVar23)(puVar23,1);
            puVar23 = puVar1;
          }
        }
      }
      local_230 = (undefined8 *)0x0;
      goto LAB_180430181;
    }
LAB_18042f712:
    puVar25 = auStackY_4a8;
    if (DAT_180d20bf0 == '\0') {
      lVar18 = FUN_180973160();
      lVar19 = FUN_180973140();
      if (lVar18 == 10000000) {
        lVar19 = lVar19 * 100;
      }
      else if (lVar18 == 24000000) {
        lVar19 = (lVar19 * 2) / 3 + lVar19 * 0x29;
      }
      else {
        lVar19 = ((lVar19 % lVar18) * 1000000000) / lVar18 + (lVar19 / lVar18) * 1000000000;
      }
      if (lVar19 == lVar26 + 30000000000) {
        cVar8 = '\0';
      }
      else {
        cVar8 = -1;
        if (lVar26 + 30000000000 <= lVar19) {
          cVar8 = '\x01';
        }
      }
      if (cVar8 < '\0') goto code_r0x00018042f79f;
      local_2d8.Data1 = 0;
      local_2d8.Data2 = 0;
      local_2d8.Data3 = 0;
      local_2d8.Data4[0] = '\0';
      local_2d8.Data4[1] = '\0';
      local_2d8.Data4[2] = '\0';
      local_2d8.Data4[3] = '\0';
      local_2d8.Data4[4] = '\0';
      local_2d8.Data4[5] = '\0';
      local_2d8.Data4[6] = '\0';
      local_2d8.Data4[7] = '\0';
      FUN_18019fbb0(&local_2d8,&DAT_180d6eb78);
      local_478[0] = 0;
      FUN_180185e60(&DAT_180d6eb28,local_478);
      local_338 = (undefined8 ******)CONCAT44(local_338._4_4_,0x3f);
      FUN_1801877a0(&DAT_180d6eb28,&local_338,4);
      FUN_1801877a0(&DAT_180d6eb28,&DAT_180d0da88,0x3f);
      local_398 = (undefined8 *****)_Xtime_get_ticks();
      ppuVar32 = &local_2a8;
      lVar26 = 1;
      do {
        *ppuVar32 = (undefined *)0x0;
        ppuVar32 = ppuVar32 + 1;
        lVar26 = lVar26 + -1;
      } while (lVar26 != 0);
      local_2a0 = &local_398;
      local_298 = FUN_180191210;
      local_2a8 = (undefined *)0xd000000000000000;
      local_338 = (undefined8 ******)0x1;
      local_330 = &local_2a8;
      local_308 = &DAT_180c09610;
      auStack_300._0_8_ = 9;
      FUN_1801858b0(local_360,&local_308,&local_338);
      local_338._0_4_ = 1;
      FUN_180185f70(&DAT_180d6eb28,&local_338);
      local_338 = (undefined8 ******)CONCAT44(local_338._4_4_,local_350._0_4_);
      FUN_1801877a0(&DAT_180d6eb28,&local_338,4);
      puVar22 = local_360;
      if ((undefined4 *)0xf < local_348) {
        puVar22 = (undefined1 *)_local_360;
      }
      FUN_1801877a0(&DAT_180d6eb28,puVar22,local_350);
      if (DAT_180d6ebe0 != '\0') {
        local_338 = (undefined8 ******)
                    CONCAT44(local_338._4_4_,(int)DAT_180d6eb30 - (int)DAT_180d6eb28);
        FUN_1803c9190(&DAT_180d6ebc8,&local_308,&local_338,4);
        FUN_1803c9190(&DAT_180d6ebc8,&local_308,CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28),
                      DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28));
      }
      DAT_180d6eb70 = DAT_180d6eb70 + 1;
      local_308 = (undefined *)CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
      auStack_300._0_8_ = DAT_180d6eb30 - (longlong)local_308;
      FUN_1801806e0(&DAT_180d6eb40,&local_308);
      local_318[0] = (undefined8 ****)
                     CONCAT44(local_318[0]._4_4_,((int)DAT_180d6eb30 - (int)DAT_180d6eb28) + 4);
      FUN_180186fb0(&DAT_180d6ea20,local_318,4);
      FUN_180186fb0(&DAT_180d6ea20,CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28),
                    DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28));
      FUN_180186e20(&DAT_180d6ea20);
      if (CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28) != DAT_180d6eb30) {
        DAT_180d6eb30 = CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
      }
      FUN_1801a2650(local_360);
      puVar25 = auStackY_4a8;
      if (local_2d8.Data4[0] != '\0') {
        FUN_180973930(local_2d8._0_8_);
        puVar25 = auStackY_4a8;
      }
    }
    goto LAB_1804308ab;
  }
  local_2c8 = (undefined1  [16])0x0;
  local_2b8 = 0;
  local_2b0 = 0;
  FUN_1801ac520(local_2c8,L"Local\\BlueBottleGG.Farsight.Crash.v1.",0x25);
  uVar14 = FUN_180995750(&local_a8);
  if (local_2b0 - local_2b8 < uVar14) {
    FUN_1801a1480(local_2c8,uVar14,local_478[0],&local_a8);
  }
  else {
    uVar27 = local_2b8 + uVar14;
    puVar22 = local_2c8;
    if (7 < local_2b0) {
      puVar22 = (undefined1 *)local_2c8._0_8_;
    }
    lVar26 = local_2b8 * 2;
    local_2b8 = uVar27;
    FUN_1809bf2f0(puVar22 + lVar26,&local_a8,uVar14 * 2);
    *(undefined2 *)(puVar22 + uVar27 * 2) = 0;
  }
  pWVar15 = (LPCWSTR)local_2c8;
  if (7 < local_2b0) {
    pWVar15 = (LPCWSTR)local_2c8._0_8_;
  }
  DAT_180d6e9c8 =
       CreateFileMappingW((HANDLE)0xffffffffffffffff,(LPSECURITY_ATTRIBUTES)0x0,4,0,0x4000240,
                          pWVar15);
  if ((DAT_180d6e9c8 == (HANDLE)0x0) ||
     (DVar11 = GetLastError(), uVar14 = local_2b8, DVar11 == 0xb7)) {
LAB_18042f28d:
    FUN_18042d790();
LAB_18042f292:
    ppuVar32 = (undefined **)0x0;
    if (7 < local_2b0) {
      uVar14 = local_2b0 * 2 + 2;
      lVar26 = local_2c8._0_8_;
      if (0xfff < uVar14) {
        lVar26 = *(longlong *)(local_2c8._0_8_ + -8);
        if (0x1f < (local_2c8._0_8_ - lVar26) - 8U) goto LAB_18042fd58;
        uVar14 = local_2b0 * 2 + 0x29;
      }
      thunk_FUN_180895720(lVar26,uVar14);
    }
    goto LAB_18042f2dc;
  }
  if (0x7ffffffffffffffe - local_2b8 < 6) {
                    /* WARNING: Subroutine does not return */
    FUN_1801a21a0();
  }
  puVar22 = local_2c8;
  if (7 < local_2b0) {
    puVar22 = (undefined1 *)local_2c8._0_8_;
  }
  _local_360 = (undefined1  [16])0x0;
  local_350 = (undefined **)0x0;
  local_348 = (undefined4 *)0x0;
  ppuVar32 = (undefined **)(local_2b8 + 6);
  if (ppuVar32 < &DAT_00000008) {
    puVar16 = (undefined4 *)&DAT_00000007;
    puVar25 = local_360;
  }
  else {
    puVar16 = (undefined4 *)((ulonglong)ppuVar32 | 7);
    if (puVar16 < (undefined4 *)0x7fffffffffffffff) {
      if (puVar16 < (undefined4 *)0xa) {
        puVar16 = (undefined4 *)0xa;
      }
      puVar25 = (undefined1 *)((longlong)puVar16 + 1);
      if ((undefined1 *)0x7fffffffffffffff < puVar25) {
                    /* WARNING: Subroutine does not return */
        FUN_1801a22b0();
      }
    }
    else {
      puVar25 = (undefined1 *)0x7fffffffffffffff;
      puVar16 = (undefined4 *)0x7ffffffffffffffe;
    }
    puVar25 = (undefined1 *)FUN_1801a22d0((longlong)puVar25 * 2);
    _local_360 = (LPCWSTR)puVar25;
  }
  lVar26 = uVar14 * 2;
  local_350 = ppuVar32;
  local_348 = puVar16;
  FUN_1809bf2f0(puVar25,puVar22,lVar26);
  *(undefined8 *)(puVar25 + lVar26) = 0x6100650072002e;
  *(undefined4 *)(puVar25 + lVar26 + 8) = 0x790064;
  *(undefined2 *)(puVar25 + (longlong)ppuVar32 * 2) = 0;
  pWVar15 = (LPCWSTR)local_360;
  if (&DAT_00000007 < local_348) {
    pWVar15 = _local_360;
  }
  DAT_180d6e9c0 = CreateEventW((LPSECURITY_ATTRIBUTES)0x0,1,0,pWVar15);
  if (local_348 < &DAT_00000008) {
LAB_18042f10f:
    local_350 = (undefined **)0x0;
    local_348 = (undefined4 *)&DAT_00000007;
    auVar3._14_2_ = 0;
    auVar3._0_14_ = auStack_35e;
    _local_360 = auVar3 << 0x10;
    if (((DAT_180d6e9c0 == (HANDLE)0x0) || (DVar11 = GetLastError(), DVar11 == 0xb7)) ||
       (puVar16 = MapViewOfFile(DAT_180d6e9c8,2,0,0,0x4000240), DAT_180d6e9a8 = puVar16,
       puVar16 == (undefined4 *)0x0)) goto LAB_18042f28d;
    *puVar16 = 0x46534352;
    puVar16[1] = 1;
    DVar11 = GetCurrentProcessId();
    DAT_180d6e9a8[3] = DVar11;
    if (DAT_180d11ec0 < local_2b8) {
      FUN_18019eb90(&DAT_180d11eb0,local_2b8 - DAT_180d11ec0,0);
    }
    else {
      DAT_180d11ec0 = local_2b8;
      puVar23 = &DAT_180d11eb0;
      if (0xf < DAT_180d11ec8) {
        puVar23 = DAT_180d11eb0;
      }
      *(undefined1 *)((longlong)puVar23 + local_2b8) = 0;
    }
    puVar23 = &DAT_180d11eb0;
    if (0xf < DAT_180d11ec8) {
      puVar23 = DAT_180d11eb0;
    }
    puVar22 = local_2c8;
    if (7 < local_2b0) {
      puVar22 = (undefined1 *)local_2c8._0_8_;
    }
    puVar25 = local_2c8;
    if (7 < local_2b0) {
      puVar25 = (undefined1 *)local_2c8._0_8_;
    }
    for (; puVar25 != puVar22 + local_2b8 * 2; puVar25 = puVar25 + 2) {
      *(undefined1 *)puVar23 = *puVar25;
      puVar23 = (undefined8 *)((longlong)puVar23 + 1);
    }
    DAT_180d6e9a0 = LoadLibraryExW(L"dbghelp.dll",(HANDLE)0x0,0x800);
    if (DAT_180d6e9a0 != (HMODULE)0x0) {
      DAT_180d6e9b8 = GetProcAddress(DAT_180d6e9a0,"MiniDumpWriteDump");
    }
    DAT_180d6e9d0 = 0;
    DAT_180d6e9b0 = SetUnhandledExceptionFilter(FUN_18042d550);
    DAT_180d6e9d4 = 1;
    goto LAB_18042f292;
  }
  uVar14 = (longlong)local_348 * 2 + 2;
  lVar26 = (longlong)_local_360;
  if (uVar14 < 0x1000) {
LAB_18042f103:
    thunk_FUN_180895720(lVar26,uVar14);
    goto LAB_18042f10f;
  }
  lVar26 = *(longlong *)((longlong)_local_360 + -8);
  if (((longlong)_local_360 - lVar26) - 8U < 0x20) {
    uVar14 = (longlong)local_348 * 2 + 0x29;
    goto LAB_18042f103;
  }
LAB_18042fd58:
  pcVar2 = (code *)swi(0x29);
  (*pcVar2)(5);
  puVar31 = auStackY_4a0;
LAB_18042fd5f:
  local_150 = local_278._8_8_;
  local_158 = local_278._0_8_;
  local_278._8_8_ = ppuVar32;
  local_278._0_8_ = ppuVar32;
  local_148 = local_268;
  local_140 = local_260;
  uStack_138 = uStack_258;
  ppuStack_130 = ppuStack_250;
  uStack_128 = uStack_248;
  uStack_248 = 0xf;
  auVar7[0xf] = 0;
  auVar7._0_15_ = stack0xfffffffffffffda1;
  _local_260 = auVar7 << 8;
  local_120 = '\x01';
  *(undefined8 *)(puVar31 + -8) = 0x18042fdda;
  local_268 = ppuVar32;
  ppuStack_250 = ppuVar32;
  FUN_1801810b0(&uStack_3f8);
  *(undefined8 *)(puVar31 + -8) = 0x18042fde6;
  FUN_1801810b0(auStack_1d8);
  *(undefined8 *)(puVar31 + -8) = 0x18042fdf2;
  FUN_180183390(&local_308);
  if (local_2e8 != (longlong *)0x0) {
    pcVar2 = *(code **)(*local_2e8 + 0x10);
    *(undefined8 *)(puVar31 + -8) = 0x18042fe04;
    puVar23 = (undefined8 *)(*pcVar2)();
    if (puVar23 != (undefined8 *)0x0) {
      pcVar2 = *(code **)*puVar23;
      *(undefined8 *)(puVar31 + -8) = 0x18042fe1b;
      (*pcVar2)(puVar23,1);
    }
  }
  *(undefined8 *)(puVar31 + -8) = 0x18042fe2c;
  FUN_1801a2650(local_360);
  *(undefined8 *)(puVar31 + -8) = 0x18042fe38;
  FUN_1801a2650(local_260);
  *(undefined8 *)(puVar31 + -8) = 0x18042fe44;
  FUN_1801a2440(local_278);
  *(undefined8 *)(puVar31 + -8) = 0x18042fe50;
  FUN_1801810b0(&lStack_108);
  *(undefined8 *)(puVar31 + -8) = 0x18042fe5c;
  FUN_180183390(&local_230);
  puVar22 = puVar31;
LAB_180430181:
  if (local_210 != (longlong *)0x0) {
    pcVar2 = *(code **)(*local_210 + 0x10);
    *(undefined8 *)(puVar22 + -8) = 0x180430193;
    puVar23 = (undefined8 *)(*pcVar2)();
    if (puVar23 != (undefined8 *)0x0) {
      pcVar2 = *(code **)*puVar23;
      *(undefined8 *)(puVar22 + -8) = 0x1804301a4;
      (*pcVar2)(puVar23,1);
    }
  }
  *(undefined8 *)(puVar22 + -8) = 0x1804301ae;
  uVar20 = FUN_1801a2650(puVar22 + 0x58);
  puVar25 = puVar22;
  if (local_120 == '\0') {
    *(undefined8 *)(puVar22 + -8) = 0x1804301bc;
    FUN_1803c40c0();
  }
  else {
    *(undefined8 *)(puVar22 + -8) = 0x1804301d9;
    FUN_1803c3310(uVar20,&local_158);
    uVar14 = DAT_180d10540 - (longlong)DAT_180d10538 >> 2;
    local_27c = SUB84(ppuVar32,0);
    local_284 = local_27c;
    local_288 = local_27c;
    if ((uVar14 != 0) && (local_288 = *DAT_180d10538, 1 < uVar14)) {
      local_284 = DAT_180d10538[1];
    }
    local_280 = local_27c;
    if ((2 < uVar14) && (local_280 = DAT_180d10538[2], 3 < uVar14)) {
      local_27c = DAT_180d10538[3];
    }
    *(undefined8 *)(puVar22 + -8) = 0x180430249;
    QueryPerformanceFrequency(&local_168);
    *(undefined8 *)(puVar22 + -8) = 0x180430256;
    QueryPerformanceCounter(&local_170);
    ppuVar30 = ppuVar32;
    do {
      auStack_35e._6_8_ = &local_280;
      _local_360 = (LPCWSTR)&local_27c;
      local_350 = (undefined **)&local_284;
      local_348 = &local_288;
      local_2a8 = &DAT_180c5c04c + (longlong)ppuVar30 * 0x18;
      local_2a0 = (undefined8 *****)(&DAT_180c5c048 + (longlong)ppuVar30 * 0x18);
      local_298 = (code *)(&DAT_180c5c044 + (longlong)ppuVar30 * 0x18);
      local_290 = &DAT_180c5c040 + (longlong)ppuVar30 * 0x18;
      *(undefined8 *)(puVar22 + -8) = 0x1804302d8;
      cVar8 = FUN_180447f20(&local_2a8,local_360);
      uVar20 = extraout_XMM0_Qa;
      if ('\0' < cVar8) break;
      *(undefined8 *)(puVar22 + -8) = 0x1804302e4;
      lVar26 = FUN_18052b4e0(extraout_XMM0_Qa,ppuVar30);
      pcVar2 = *(code **)(lVar26 + 0x10);
      *(undefined8 *)(puVar22 + -8) = 0x1804302ee;
      uVar20 = (*pcVar2)(&DAT_180d21540);
      ppuVar30 = (undefined **)((longlong)ppuVar30 + 1);
    } while (ppuVar30 < &DAT_00000013);
    do {
      *(undefined8 *)(puVar22 + -8) = 0x180430308;
      lVar26 = FUN_1804483f0(uVar20,ppuVar32);
      *(undefined8 *)(puVar22 + -8) = 0x18043031a;
      cVar8 = FUN_180446840(lVar26,&local_288);
      if (cVar8 != '\0') break;
      pcVar2 = *(code **)(lVar26 + 0x10);
      *(undefined8 *)(puVar22 + -8) = 0x180430329;
      uVar20 = (*pcVar2)(&PTR_PTR_180d0fa90);
      ppuVar32 = (undefined **)((longlong)ppuVar32 + 1);
    } while (ppuVar32 < &DAT_00000008);
    *(undefined8 *)(puVar22 + -8) = 0x18043033f;
    QueryPerformanceCounter(&local_178);
    local_398 = (undefined8 *****)
                (((double)(local_178.QuadPart - (longlong)local_170) * 1000.0) /
                (double)local_168.QuadPart);
    *(undefined8 *)(puVar22 + -8) = 0x18043037d;
    FUN_1803c4420((double)local_168.QuadPart,&local_398);
    *(undefined8 *)(puVar22 + -8) = 0x180430382;
    cVar8 = FUN_1803a1c90();
    if (cVar8 == '\0') {
      *(undefined8 *)(puVar22 + -8) = 0x180430393;
      FUN_180421b50(&local_338);
      if ((local_338._4_1_ == '\0') || ((int)local_338 != 2)) {
        *(undefined8 *)(puVar22 + -8) = 0x180430622;
        FUN_1803c47e0();
        *(undefined8 *)(puVar22 + -8) = 0x18043062e;
        FUN_180180c80(&local_158);
      }
      else {
        *(undefined8 *)(puVar22 + -8) = 0x1804303ac;
        FUN_180447e70();
        *(undefined8 *)(puVar22 + -8) = 0x1804303b1;
        FUN_1803c3b30();
        *(undefined8 *)(puVar22 + -8) = 0x1804303bd;
        FUN_18019fc10(&local_2d8);
        *(undefined8 *)(puVar22 + -8) = 0x1804303c9;
        FUN_1803c3290(&local_2d8);
        *(undefined8 *)(puVar22 + -8) = 0x1804303ce;
        FUN_180210530();
        *(undefined8 *)(puVar22 + -8) = 0x1804303d3;
        FUN_180398df0();
        *(undefined8 *)(puVar22 + -8) = 0x1804303d8;
        FUN_1803c3500();
        *(undefined8 *)(puVar22 + -8) = 0x1804303e4;
        FUN_18019fc10(local_318);
        *(undefined8 *)(puVar22 + -8) = 0x1804303f0;
        FUN_1803c32d0(local_318);
        *(undefined8 *)(puVar22 + -8) = 0x1804303fc;
        FUN_1803c3360(&local_a8);
        *(undefined8 *)(puVar22 + -8) = 0x180430408;
        FUN_1803cafc0(&local_a8);
        *(undefined8 *)(puVar22 + -8) = 0x180430414;
        FUN_1803c9060(local_240);
        _DAT_180d6e870 = 0x1386;
        *(undefined8 *)(puVar22 + -8) = 0x18043042c;
        FUN_1801a6370(&local_2a8);
        *(undefined8 *)(puVar22 + -8) = 0x180430438;
        uVar20 = FUN_1802d6070(&local_2a8);
        if (local_238 == '\0') {
          local_338 = (undefined8 ******)CONCAT44(local_338._4_4_,local_240[0]);
          *(undefined8 *)(puVar22 + -8) = 0x180430492;
          FUN_1803c4b40(uVar20,&local_338);
        }
        else {
          local_398 = (undefined8 *****)&DAT_180d6e5b0;
          *(undefined8 *)(puVar22 + -8) = 0x180430463;
          uVar20 = FUN_1803c3680(&local_308);
          *(undefined8 *)(puVar22 + -8) = 0x180430472;
          FUN_18030e3d0(&local_2a8,uVar20);
          *(undefined8 *)(puVar22 + -8) = 0x18043047e;
          FUN_1802d5fd0(&local_308);
        }
        *(undefined8 *)(puVar22 + -8) = 0x18043049e;
        FUN_1801a6370(&local_308);
        *(undefined8 *)(puVar22 + -8) = 0x1804304aa;
        uVar20 = FUN_1802d6070(&local_308);
        if ((char)uStack_70 == '\0') {
          *(undefined8 *)(puVar22 + -8) = 0x1804304f1;
          FUN_1803c4ef0(uVar20,&local_a8);
        }
        else {
          local_398 = (undefined8 *****)&DAT_180d6e5b0;
          *(undefined8 *)(puVar22 + -8) = 0x1804304cb;
          uVar20 = FUN_1803c3770(&local_338);
          *(undefined8 *)(puVar22 + -8) = 0x1804304da;
          FUN_18030e3d0(&local_308,uVar20);
          *(undefined8 *)(puVar22 + -8) = 0x1804304e3;
          FUN_1802d5fd0(&local_338);
        }
        if ((local_238 == '\0') && ((char)uStack_70 == '\0')) {
          *(undefined8 *)(puVar22 + -8) = 0x180430508;
          FUN_1803c52a0();
          *(undefined8 *)(puVar22 + -8) = 0x180430510;
          FUN_1803d94f0(&DAT_180d6e5b0);
        }
        while (DAT_180d6e7e8 != 0) {
          local_398 = (undefined8 *****)&DAT_00000014;
          *(undefined8 *)(puVar22 + -8) = 0x180430531;
          FUN_1803a2a80(&local_398);
        }
        *(undefined8 *)(puVar22 + -8) = 0x180430547;
        FUN_1802d5df0(&local_298);
        *(undefined8 *)(puVar22 + -8) = 0x180430553;
        FUN_1802d5df0(auStack_300 + 8);
        if ((int)local_2a0 != 0) {
          *(undefined8 *)(puVar22 + -8) = 0x180430568;
          FUN_180226230(&local_2a8);
        }
        if (auStack_300._0_4_ != 0) {
          *(undefined8 *)(puVar22 + -8) = 0x18043057d;
          FUN_180226230(&local_308);
        }
        *(undefined8 *)(puVar22 + -8) = 0x180430585;
        FUN_1803d9650(&DAT_180d6e5b0);
        *(undefined8 *)(puVar22 + -8) = 0x18043058d;
        FUN_1803d96c0(&DAT_180d6e5b0);
        *(undefined8 *)(puVar22 + -8) = 0x180430595;
        FUN_1803d98a0(&DAT_180d6e5b0);
        *(undefined8 *)(puVar22 + -8) = 0x18043059a;
        FUN_180210550();
        *(undefined8 *)(puVar22 + -8) = 0x1804305a6;
        FUN_1803c38a0(&local_2d8);
        *(undefined8 *)(puVar22 + -8) = 0x1804305b2;
        FUN_1803c39d0(local_318);
        *(undefined8 *)(puVar22 + -8) = 0x1804305b7;
        FUN_1803c3a40();
        *(undefined8 *)(puVar22 + -8) = 0x1804305bf;
        FUN_1803d9a80(&DAT_180d6e5b0);
        *(undefined8 *)(puVar22 + -8) = 0x1804305c4;
        FUN_1803c3960();
        *(undefined8 *)(puVar22 + -8) = 0x1804305d0;
        FUN_1802d5fd0(&local_308);
        *(undefined8 *)(puVar22 + -8) = 0x1804305dc;
        FUN_1802d5fd0(&local_2a8);
        *(undefined8 *)(puVar22 + -8) = 0x1804305e8;
        FUN_1803c4010(local_240);
        *(undefined8 *)(puVar22 + -8) = 0x1804305f4;
        FUN_1803c3fb0(&local_a8);
        *(undefined8 *)(puVar22 + -8) = 0x180430600;
        FUN_1803c39d0(local_318);
        *(undefined8 *)(puVar22 + -8) = 0x18043060c;
        FUN_1803c38a0(&local_2d8);
        *(undefined8 *)(puVar22 + -8) = 0x180430618;
        FUN_180180c80(&local_158);
      }
      goto LAB_1804308ab;
    }
  }
  *(undefined8 *)(puVar22 + -8) = 0x1804301c8;
  FUN_180180c80(&local_158);
LAB_1804308ab:
  uVar20 = *param_1;
  *(undefined8 *)(puVar25 + -8) = 0x1804308b4;
  FUN_18042d8a0(uVar20);
  *(undefined8 *)(puVar25 + -8) = 0x1804308b9;
  FUN_180974e60();
  *(undefined8 *)(puVar25 + -8) = 0x1804308c5;
  FUN_180224ed0(&local_160);
  *(undefined8 *)(puVar25 + -8) = 0x1804308d6;
  return 0;
code_r0x00018042fc9f:
  if (puVar22 != puStack_200) {
    cVar8 = FUN_180182e40(puVar22,puStack_200,&local_1e8,ppuStack_1f8);
    if (cVar8 == '\0') {
LAB_18042fd0c:
      uStack_1f0 = uStack_1f0 | 0x100;
      cVar8 = FUN_180182e40(puVar22,puStack_200,&local_1e8,ppuStack_1f8);
      if (cVar8 == '\0') goto LAB_18042fabf;
    }
    ppuVar30 = ppuStack_1f8;
  }
  goto LAB_18042fad0;
code_r0x00018042f79f:
  FUN_1801fe670(&local_398);
  if ((longlong)local_398 < 0x7fffffffe2329aff) {
    local_338 = (undefined8 ******)(local_398 + 62500000);
    FUN_1802239d0(&local_338);
  }
  else {
    local_338 = (undefined8 ******)0x7fffffffffffffff;
    FUN_1802239d0(&local_338);
  }
  goto LAB_18042f675;
}

