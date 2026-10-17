// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x18043eea0; descriptive alias: build_leaguebroadcast_game_info
// Evidence: ev_967c2da169c9ec8074a59f30e796dd74ff026e7ba937d9d0c373e26b399ba6a7
// Original Evidence: rea-lb-snapshot-builder.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

longlong * FUN_18043eea0(undefined4 *param_1,longlong *param_2,undefined8 param_3)

{
  ulonglong *puVar1;
  undefined4 uVar2;
  int iVar3;
  undefined4 uVar4;
  longlong *plVar5;
  undefined1 auVar6 [16];
  char cVar7;
  uint uVar8;
  undefined8 uVar9;
  longlong lVar10;
  longlong *plVar11;
  ulonglong *puVar12;
  undefined8 uVar13;
  undefined8 *puVar14;
  undefined4 *puVar15;
  undefined4 *puVar16;
  longlong *plVar17;
  undefined1 (*pauVar18) [16];
  undefined4 *puVar19;
  ulonglong uVar20;
  ulonglong uVar21;
  ulonglong uVar22;
  int *piVar23;
  undefined4 *puVar24;
  uint *puVar25;
  ulonglong uVar26;
  ulonglong *puVar27;
  undefined1 *puVar28;
  undefined8 *puVar29;
  longlong lVar30;
  longlong lVar31;
  undefined *puVar32;
  code *pcVar33;
  code *pcVar34;
  code *pcVar35;
  ulonglong *puVar36;
  int iVar37;
  longlong lVar38;
  undefined8 extraout_XMM0_Qa;
  undefined1 auVar39 [8];
  undefined1 auVar40 [8];
  undefined1 auVar41 [64];
  undefined1 auStack_468 [8];
  undefined1 auStack_460 [24];
  longlong local_448;
  undefined4 local_440;
  undefined4 local_438;
  undefined4 local_430;
  undefined4 local_428;
  undefined4 local_420;
  undefined4 local_418;
  undefined4 local_410;
  undefined4 local_408;
  undefined4 local_400;
  undefined4 local_3f8;
  undefined4 local_3f0;
  undefined4 local_3e8;
  undefined1 local_3d8;
  undefined4 *local_3d0;
  undefined1 local_3c8 [8];
  undefined4 *puStack_3c0;
  undefined4 *local_3b8;
  undefined4 local_3b0;
  undefined4 local_3ac;
  undefined4 local_3a8;
  undefined4 local_3a4;
  undefined4 *local_3a0;
  longlong local_398;
  undefined4 local_390;
  undefined4 local_38c;
  undefined4 local_388;
  undefined4 local_384;
  undefined4 local_380;
  ulonglong *local_378;
  undefined1 local_370 [24];
  undefined1 local_358 [16];
  undefined4 *local_348;
  undefined1 local_338 [16];
  longlong local_328;
  longlong local_320;
  longlong local_318;
  undefined4 *local_310;
  undefined1 local_308 [16];
  undefined4 *local_2f8;
  undefined1 local_2f0 [16];
  longlong local_2e0;
  undefined4 *local_2d8;
  undefined4 *local_2d0;
  longlong local_2c8;
  undefined1 local_2c0 [16];
  undefined8 local_2b0;
  longlong *local_2a8;
  undefined1 local_2a0 [16];
  uint *local_290;
  undefined1 local_288 [16];
  undefined4 *local_278;
  longlong *local_270;
  undefined8 local_268;
  ulonglong local_260;
  code *local_258;
  code *local_250;
  undefined4 *local_248;
  undefined4 local_238;
  undefined4 local_234;
  ulonglong *local_230;
  undefined8 local_228;
  undefined8 local_220;
  undefined1 local_218 [16];
  undefined8 local_208;
  undefined8 local_200;
  undefined1 local_1f8 [16];
  longlong local_1e8;
  undefined1 local_1e0 [16];
  longlong local_1d0;
  undefined1 local_1c8 [8];
  longlong *local_1c0 [2];
  undefined1 local_1b0 [40];
  undefined1 local_188 [24];
  undefined1 local_170 [24];
  undefined1 local_158 [24];
  undefined1 local_140 [24];
  undefined1 local_128 [24];
  undefined1 local_110 [24];
  undefined1 local_f8 [24];
  undefined1 local_e0 [24];
  undefined1 local_c8 [24];
  undefined1 local_b0 [24];
  undefined1 local_98 [32];
  ulonglong local_78;
  
  puVar28 = auStack_468;
  local_78 = DAT_180d06cc0 ^ (ulonglong)auStack_468;
  local_3a0 = param_1;
  local_2a8 = param_2;
  FUN_1801a6370(local_2a0);
  local_2a0 = (undefined1  [16])0x0;
  local_290 = (uint *)0x0;
  FUN_180442e20(local_2a0);
  FUN_18043e9e0(param_1,local_188,param_3);
  local_3d0 = param_1;
  FUN_1804411e0(&local_270,&local_3d0,local_188);
  local_3d0 = param_1;
  FUN_180441280(&local_3a8,&local_3d0,&local_270);
  FUN_1803c3360(local_1c8);
  FUN_180442da0(local_1c8);
  local_3d0 = (undefined4 *)0xe260302c;
  uVar9 = FUN_180442920(local_1c8,&local_3d0);
  FUN_1801be8d0(uVar9,10);
  local_3d0 = (undefined4 *)0xcaa58cb2;
  uVar9 = FUN_180442920(local_1c8,&local_3d0);
  FUN_1801be8d0(uVar9,200);
  local_3d0 = (undefined4 *)0xbeba9102;
  uVar9 = FUN_180442920(local_1c8,&local_3d0);
  FUN_1801be8d0(uVar9,0x18);
  local_3d0 = (undefined4 *)0x60bb49c0;
  uVar9 = FUN_180442920(local_1c8,&local_3d0);
  FUN_1801be8d0(uVar9,8);
  local_3d0 = (undefined4 *)0x503ad0d2;
  uVar9 = FUN_180442920(local_1c8,&local_3d0);
  FUN_1801be8d0(uVar9,2);
  local_3d0 = (undefined4 *)0xdd4de76f;
  uVar9 = FUN_180442920(local_1c8,&local_3d0);
  FUN_1801be8d0(uVar9,0x400);
  lVar10 = FUN_180425d20();
  while (lVar10 != 0) {
    local_3d0 = (undefined4 *)FUN_180432030(lVar10);
    plVar11 = (longlong *)FUN_180442920(local_1c8,&local_3d0);
    plVar17 = (longlong *)plVar11[1];
    if (plVar17 == (longlong *)plVar11[2]) {
      uVar26 = (longlong)plVar17 - *plVar11;
      lVar38 = (longlong)uVar26 >> 3;
      if (lVar38 == 0x1fffffffffffffff) {
                    /* WARNING: Subroutine does not return */
        FUN_180183310();
      }
      uVar20 = lVar38 + 1;
      uVar21 = plVar11[2] - *plVar11 >> 3;
      if (0x1fffffffffffffff - (uVar21 >> 1) < uVar21) {
        uVar22 = 0x1fffffffffffffff;
      }
      else {
        uVar21 = (uVar21 >> 1) + uVar21;
        uVar22 = uVar20;
        if (uVar20 <= uVar21) {
          uVar22 = uVar21;
        }
        if (0x1fffffffffffffff < uVar22) {
                    /* WARNING: Subroutine does not return */
          FUN_1801a22b0();
        }
      }
      pcVar34 = (code *)FUN_1801a22d0(uVar22 * 8);
      local_258 = pcVar34 + (uVar26 & 0xfffffffffffffff8);
      pcVar33 = local_258 + 8;
      *(longlong *)local_258 = lVar10;
      plVar5 = (longlong *)*plVar11;
      local_270 = plVar11;
      local_260 = uVar22;
      local_250 = pcVar33;
      if (plVar17 == (longlong *)plVar11[1]) {
        lVar38 = plVar11[1] - (longlong)plVar5;
        pcVar33 = pcVar34;
        plVar17 = plVar5;
      }
      else {
        FUN_1809bf2f0(pcVar34,plVar5,(longlong)plVar17 - (longlong)plVar5);
        lVar38 = plVar11[1] - (longlong)plVar17;
        local_258 = pcVar34;
      }
      FUN_1809bf2f0(pcVar33,plVar17,lVar38);
      local_268 = 0;
      FUN_1801ada70(plVar11,pcVar34,uVar20,uVar22);
      FUN_180426350(&local_270);
    }
    else {
      *plVar17 = lVar10;
      plVar11[1] = plVar11[1] + 8;
    }
    lVar10 = FUN_180425de0(lVar10);
    param_1 = local_3a0;
  }
  local_2c0 = (undefined1  [16])0x0;
  local_2b0 = 0;
  auVar39 = (undefined1  [8])0x0;
  puVar15 = (undefined4 *)0x0;
  local_358 = (undefined1  [16])0x0;
  local_3d0 = (undefined4 *)0x0;
  local_348 = (undefined4 *)0x0;
  auVar40 = (undefined1  [8])0x0;
  puVar19 = (undefined4 *)0x0;
  local_308 = (undefined1  [16])0x0;
  local_310 = (undefined4 *)0x0;
  local_2f8 = (undefined4 *)0x0;
  local_1e0 = (undefined1  [16])0x0;
  local_1d0 = 0;
  local_1f8 = (undefined1  [16])0x0;
  local_1e8 = 0;
  local_2f0 = (undefined1  [16])0x0;
  local_318 = 0;
  local_2e0 = 0;
  local_338 = (undefined1  [16])0x0;
  local_320 = 0;
  local_328 = 0;
  local_234 = 0;
  local_220 = 0;
  local_218 = (undefined1  [16])0x0;
  local_208 = 0;
  local_200 = 0;
  local_238 = 0;
  local_230 = (ulonglong *)0x0;
  local_228 = 0;
  puVar12 = (ulonglong *)FUN_180976d80(0x30);
  *puVar12 = (ulonglong)puVar12;
  puVar12[1] = (ulonglong)puVar12;
  local_220 = 0;
  local_218 = (undefined1  [16])0x0;
  local_208 = 7;
  local_200 = 8;
  auVar41 = ZEXT464(0x3f800000);
  local_238 = 0x3f800000;
  local_230 = puVar12;
  uVar9 = FUN_1801ab260(&local_220,0x10,puVar12);
  plVar17 = (longlong *)*local_1c0[0];
  local_398 = local_338._0_8_;
  if (plVar17 != local_1c0[0]) {
    puVar12 = (ulonglong *)0x9c8ade94;
    pcVar33 = FUN_18043da00;
    pcVar34 = FUN_18043c210;
    pcVar35 = FUN_18043dcd0;
    do {
      puVar27 = (ulonglong *)plVar17[2];
      if (puVar27 < (ulonglong *)0xbeba9103) {
        if (puVar27 == (ulonglong *)0xbeba9102) {
          local_3c8 = (undefined1  [8])0x0;
          puStack_3c0 = (undefined4 *)0x0;
          local_3b8 = (undefined4 *)0x0;
          puVar14 = (undefined8 *)plVar17[4];
          puVar29 = (undefined8 *)plVar17[3];
          lVar10 = (longlong)puVar14 - (longlong)puVar29;
          auVar40 = local_3c8;
          puVar19 = puStack_3c0;
          if (lVar10 != 0) {
            uVar26 = lVar10 >> 3;
            if (0x3fffffffffffffff < uVar26) {
                    /* WARNING: Subroutine does not return */
              FUN_180183310();
            }
            puVar19 = (undefined4 *)FUN_1801a22d0(uVar26 * 4);
            puStack_3c0 = puVar19;
            local_3c8 = (undefined1  [8])puVar19;
            local_3b8 = puVar19 + uVar26;
            auVar40 = (undefined1  [8])puVar19;
            for (; puVar29 != puVar14; puVar29 = puVar29 + 1) {
              FUN_18043d650(param_1,&local_3ac,*puVar29);
              *puVar19 = local_3ac;
              puVar19 = puVar19 + 1;
              auVar40 = local_3c8;
            }
          }
          puStack_3c0 = puVar19;
          local_3c8 = auVar40;
          FUN_1801a2440(local_308);
          puVar19 = puStack_3c0;
          auVar40 = local_3c8;
          local_308._8_8_ = puStack_3c0;
          local_308._0_8_ = local_3c8;
          local_2f8 = local_3b8;
          _local_3c8 = (undefined1  [16])0x0;
          local_3b8 = (undefined4 *)0x0;
          uVar9 = FUN_1801a2440(local_3c8);
          goto LAB_18043f74c;
        }
        if (puVar27 == (ulonglong *)0x503ad0d2) {
          puStack_3c0._0_1_ = local_3d8;
          local_3c8 = (undefined1  [8])FUN_18043db40;
          local_3b8 = param_1;
          FUN_180441310(&local_270,plVar17 + 3,local_3c8);
          uVar9 = FUN_1804425e0(local_370);
          FUN_1801ef110(local_1f8,uVar9);
          uVar9 = FUN_1801a2440(local_370);
          goto LAB_18043f74c;
        }
        if (puVar27 == (ulonglong *)0x60bb49c0) {
          puStack_3c0._0_1_ = local_3d8;
          local_3c8 = (undefined1  [8])FUN_18043db40;
          local_3b8 = param_1;
          FUN_180441310(&local_270,plVar17 + 3,local_3c8);
          uVar9 = FUN_1804425e0(local_370);
          FUN_1801ef110(local_1e0,uVar9);
          uVar9 = FUN_1801a2440(local_370);
          goto LAB_18043f74c;
        }
        if (puVar27 != puVar12) goto LAB_18043f537;
        cVar7 = FUN_180393770(uVar9,1);
        uVar9 = extraout_XMM0_Qa;
        if (cVar7 != '\0') {
          puStack_3c0._0_1_ = local_3d8;
          local_3c8 = (undefined1  [8])pcVar33;
          local_3b8 = param_1;
          FUN_180441310(&local_270,plVar17 + 3,local_3c8);
          uVar9 = FUN_1804425e0(local_370);
          FUN_1801ef110(local_2f0,uVar9);
          uVar9 = FUN_1801a2440(local_370);
          goto LAB_18043f74c;
        }
      }
      else {
        if (puVar27 == (ulonglong *)0xcaa58cb2) {
          local_3c8 = (undefined1  [8])0x0;
          puStack_3c0 = (undefined4 *)0x0;
          local_3b8 = (undefined4 *)0x0;
          puVar14 = (undefined8 *)plVar17[4];
          puVar29 = (undefined8 *)plVar17[3];
          lVar10 = (longlong)puVar14 - (longlong)puVar29;
          auVar39 = local_3c8;
          puVar15 = puStack_3c0;
          if (lVar10 != 0) {
            uVar26 = lVar10 >> 3;
            if (0x3fffffffffffffff < uVar26) {
                    /* WARNING: Subroutine does not return */
              FUN_180183310();
            }
            puVar15 = (undefined4 *)FUN_1801a22d0(uVar26 * 4);
            puStack_3c0 = puVar15;
            local_3c8 = (undefined1  [8])puVar15;
            local_3b8 = puVar15 + uVar26;
            auVar39 = (undefined1  [8])puVar15;
            for (; puVar29 != puVar14; puVar29 = puVar29 + 1) {
              FUN_18043d710(param_1,&local_3b0,*puVar29);
              *puVar15 = local_3b0;
              puVar15 = puVar15 + 1;
              auVar39 = local_3c8;
            }
          }
          puStack_3c0 = puVar15;
          local_3c8 = auVar39;
          FUN_1801a2440(local_358);
          puVar15 = puStack_3c0;
          auVar39 = local_3c8;
          local_358._8_8_ = puStack_3c0;
          local_358._0_8_ = local_3c8;
          local_348 = local_3b8;
          _local_3c8 = (undefined1  [16])0x0;
          local_3b8 = (undefined4 *)0x0;
          uVar9 = FUN_1801a2440(local_3c8);
        }
        else if (puVar27 == (ulonglong *)0xdd4de76f) {
          puVar14 = (undefined8 *)FUN_180441330(local_3c8,plVar17 + 3);
          local_270 = (longlong *)*puVar14;
          *puVar14 = 0xffffffffffffffff;
          local_268 = puVar14[1];
          local_260 = CONCAT71(local_260._1_7_,*(undefined1 *)(puVar14 + 2));
          local_250 = (code *)CONCAT71(local_250._1_7_,local_3d8);
          local_258 = pcVar35;
          local_248 = param_1;
          pauVar18 = (undefined1 (*) [16])FUN_1804426b0(local_370,local_270,&local_270);
          if (&local_338 != pauVar18) {
            FUN_1801a2440(local_338);
            local_398 = *(longlong *)*pauVar18;
            local_338 = *pauVar18;
            local_328 = *(longlong *)pauVar18[1];
            *(undefined8 *)*pauVar18 = 0;
            *(undefined8 *)(*pauVar18 + 8) = 0;
            *(undefined8 *)pauVar18[1] = 0;
            local_320 = local_328;
          }
          uVar9 = FUN_1801a2440(local_370);
        }
        else if (puVar27 == (ulonglong *)0xe260302c) {
          puStack_3c0._0_1_ = local_3d8;
          local_3c8 = (undefined1  [8])pcVar34;
          local_3b8 = param_1;
          FUN_180441310(&local_270,plVar17 + 3,local_3c8);
          uVar9 = FUN_1804425e0(local_370);
          FUN_1801ef110(local_2c0,uVar9);
          uVar9 = FUN_1801a2440(local_370);
        }
        else {
LAB_18043f537:
          puStack_3c0._0_1_ = local_3d8;
          local_3c8 = (undefined1  [8])FUN_1804395d0;
          local_3b8 = param_1;
          FUN_180441310(&local_270,plVar17 + 3,local_3c8);
          uVar9 = FUN_1804425e0(local_370);
          uVar13 = FUN_180442890(&local_238,plVar17 + 2);
          FUN_1801ef110(uVar13,uVar9);
          uVar9 = FUN_1801a2440(local_370);
        }
LAB_18043f74c:
        pcVar35 = FUN_18043dcd0;
        pcVar34 = FUN_18043c210;
        pcVar33 = FUN_18043da00;
        puVar12 = (ulonglong *)0x9c8ade94;
      }
      plVar17 = (longlong *)*plVar17;
    } while (plVar17 != local_1c0[0]);
    local_3d0 = local_348;
    local_310 = local_2f8;
    local_318 = local_2e0;
  }
  local_288 = (undefined1  [16])0x0;
  local_278 = (undefined4 *)0x0;
  if ((*(byte *)(param_1 + 0x122) & 4) == 0) {
LAB_18043f950:
    iVar37 = 0;
    do {
      plVar17 = (longlong *)0x0;
      if (DAT_180d60680 == '\0') {
        uVar8 = DAT_180d60218 + 0xe6632e3aU ^ 0x11bf48c;
      }
      else {
        uVar8 = FUN_18052b510(&DAT_180d60218);
      }
      if (uVar8 != 0) {
        plVar17 = (longlong *)((ulonglong)uVar8 + DAT_180d20bd0);
      }
      lVar10 = *plVar17;
      if (iVar37 == 0) {
        if (DAT_180d60af0 == '\0') {
          puVar12 = (ulonglong *)
                    (ulonglong)
                    *(byte *)(lVar10 + (ulonglong)(DAT_180d60688 + 0xe6632e3aU ^ 0x11bf48c));
        }
        else {
          uVar8 = FUN_18052b510(&DAT_180d60688);
          puVar12 = (ulonglong *)(ulonglong)*(byte *)(lVar10 + (ulonglong)uVar8);
        }
      }
      else if (iVar37 == 1) {
        if (DAT_180d60f60 == '\0') {
          puVar12 = (ulonglong *)
                    (ulonglong)
                    *(byte *)(lVar10 + (ulonglong)(DAT_180d60af8 + 0xe6632e3aU ^ 0x11bf48c));
        }
        else {
          uVar8 = FUN_18052b510(&DAT_180d60af8);
          puVar12 = (ulonglong *)(ulonglong)*(byte *)(lVar10 + (ulonglong)uVar8);
        }
      }
      else {
        puVar12 = (ulonglong *)((ulonglong)puVar12 & 0xffffffffffffff00);
      }
      lVar10 = *(longlong *)(param_1 + 0x120);
      *(undefined1 *)(lVar10 + 0x60) = 1;
      uVar2 = *(undefined4 *)(lVar10 + 0x30);
      FUN_1801bd620(lVar10,4,puVar12,0);
      uVar8 = FUN_1801be990(lVar10,uVar2);
      plVar17 = (longlong *)(ulonglong)uVar8;
      puVar25 = (uint *)local_2a0._8_8_;
      if ((uint *)local_2a0._8_8_ == local_290) {
        uVar26 = local_2a0._8_8_ - local_2a0._0_8_;
        lVar10 = (longlong)uVar26 >> 2;
        if (lVar10 == 0x3fffffffffffffff) {
                    /* WARNING: Subroutine does not return */
          FUN_180183310();
        }
        uVar20 = lVar10 + 1;
        uVar21 = (longlong)local_290 - local_2a0._0_8_ >> 2;
        if (0x3fffffffffffffff - (uVar21 >> 1) < uVar21) {
          uVar22 = 0x3fffffffffffffff;
        }
        else {
          uVar21 = (uVar21 >> 1) + uVar21;
          uVar22 = uVar20;
          if (uVar20 <= uVar21) {
            uVar22 = uVar21;
          }
          if (0x3fffffffffffffff < uVar22) {
                    /* WARNING: Subroutine does not return */
            FUN_1801a22b0();
          }
        }
        lVar10 = FUN_1801a22d0(uVar22 * 4);
        uVar26 = uVar26 & 0xfffffffffffffffc;
        *(uint *)(uVar26 + lVar10) = uVar8;
        if (puVar25 == (uint *)local_2a0._8_8_) {
          puVar12 = (ulonglong *)(local_2a0._8_8_ - local_2a0._0_8_);
          lVar38 = lVar10;
          puVar25 = (uint *)local_2a0._0_8_;
        }
        else {
          FUN_1809bf2f0(lVar10,local_2a0._0_8_,(longlong)puVar25 - local_2a0._0_8_);
          puVar12 = (ulonglong *)(local_2a0._8_8_ - (longlong)puVar25);
          lVar38 = uVar26 + 4 + lVar10;
        }
        FUN_1809bf2f0(lVar38,puVar25);
        if (local_2a0._0_8_ != 0) {
          uVar26 = ((longlong)local_290 - local_2a0._0_8_ >> 2) * 4;
          lVar38 = local_2a0._0_8_;
          if (0xfff < uVar26) {
            if (0x1f < (local_2a0._0_8_ - *(longlong *)(local_2a0._0_8_ + -8)) - 8U)
            goto LAB_18044062b;
            uVar26 = uVar26 + 0x27;
            lVar38 = *(longlong *)(local_2a0._0_8_ + -8);
          }
          thunk_FUN_180895720(lVar38,uVar26);
        }
        local_2a0._8_8_ = lVar10 + uVar20 * 4;
        local_2a0._0_8_ = lVar10;
        local_290 = (uint *)(lVar10 + uVar22 * 4);
        param_1 = local_3a0;
      }
      else {
        *(uint *)local_2a0._8_8_ = uVar8;
        local_2a0._8_8_ = (uint *)(local_2a0._8_8_ + 4);
      }
      iVar37 = iVar37 + 1;
    } while (iVar37 < 2);
    puVar32 = &DAT_180d6e9ed;
    if (local_2c0._0_8_ != local_2c0._8_8_) {
      puVar32 = (undefined *)local_2c0._0_8_;
    }
    FUN_180442ea0(*(undefined8 *)(param_1 + 0x120),&local_388,puVar32,
                  (longlong)(local_2c0._8_8_ - local_2c0._0_8_) >> 2);
    lVar10 = *(longlong *)(param_1 + 0x120);
    lVar38 = (longlong)puVar15 - (longlong)auVar39 >> 2;
    puVar24 = (undefined4 *)((longlong)&DAT_180d6e9e3 + 3);
    if (auVar39 != (undefined1  [8])puVar15) {
      puVar24 = (undefined4 *)auVar39;
    }
    local_2d0 = (undefined4 *)auVar39;
    FUN_1801c3f20(lVar10,lVar38,4);
    lVar30 = lVar38;
    while (lVar30 != 0) {
      lVar30 = lVar30 + -1;
      iVar37 = puVar24[lVar30];
      if (*(ulonglong *)(lVar10 + 0x68) < 4) {
        *(undefined8 *)(lVar10 + 0x68) = 4;
      }
      FUN_1801c5360(lVar10,-*(int *)(lVar10 + 0x30) & 3);
      iVar3 = *(int *)(lVar10 + 0x30);
      if (*(ulonglong *)(lVar10 + 0x68) < 4) {
        *(undefined8 *)(lVar10 + 0x68) = 4;
      }
      FUN_1801c5360(lVar10,-iVar3 & 3);
      FUN_1801c5410(lVar10,4);
      piVar23 = (int *)(*(longlong *)(lVar10 + 0x40) + -4);
      *(int **)(lVar10 + 0x40) = piVar23;
      *(int *)(lVar10 + 0x30) = *(int *)(lVar10 + 0x30) + 4;
      *piVar23 = (iVar3 - iVar37) + 4;
    }
    *(undefined1 *)(lVar10 + 0x60) = 0;
    if (*(ulonglong *)(lVar10 + 0x68) < 4) {
      *(undefined8 *)(lVar10 + 0x68) = 4;
    }
    FUN_1801c5360(lVar10,-*(int *)(lVar10 + 0x30) & 3);
    FUN_1801c5410(lVar10,4);
    *(longlong *)(lVar10 + 0x40) = *(longlong *)(lVar10 + 0x40) + -4;
    *(int *)(lVar10 + 0x30) = *(int *)(lVar10 + 0x30) + 4;
    **(undefined4 **)(lVar10 + 0x40) = (int)lVar38;
    local_3a4 = *(undefined4 *)(lVar10 + 0x30);
    lVar10 = *(longlong *)(param_1 + 0x120);
    lVar38 = (longlong)puVar19 - (longlong)auVar40 >> 2;
    puVar15 = (undefined4 *)&DAT_180d6e9e7;
    if (auVar40 != (undefined1  [8])puVar19) {
      puVar15 = (undefined4 *)auVar40;
    }
    local_2d8 = (undefined4 *)auVar40;
    FUN_1801c3f20(lVar10,lVar38,4);
    lVar30 = lVar38;
    while (lVar30 != 0) {
      lVar30 = lVar30 + -1;
      iVar37 = puVar15[lVar30];
      if (*(ulonglong *)(lVar10 + 0x68) < 4) {
        *(undefined8 *)(lVar10 + 0x68) = 4;
      }
      FUN_1801c5360(lVar10,-*(int *)(lVar10 + 0x30) & 3);
      iVar3 = *(int *)(lVar10 + 0x30);
      if (*(ulonglong *)(lVar10 + 0x68) < 4) {
        *(undefined8 *)(lVar10 + 0x68) = 4;
      }
      FUN_1801c5360(lVar10,-iVar3 & 3);
      FUN_1801c5410(lVar10,4);
      piVar23 = (int *)(*(longlong *)(lVar10 + 0x40) + -4);
      *(int **)(lVar10 + 0x40) = piVar23;
      *(int *)(lVar10 + 0x30) = *(int *)(lVar10 + 0x30) + 4;
      *piVar23 = (iVar3 - iVar37) + 4;
    }
    *(undefined1 *)(lVar10 + 0x60) = 0;
    if (*(ulonglong *)(lVar10 + 0x68) < 4) {
      *(undefined8 *)(lVar10 + 0x68) = 4;
    }
    FUN_1801c5360(lVar10,-*(int *)(lVar10 + 0x30) & 3);
    FUN_1801c5410(lVar10,4);
    *(longlong *)(lVar10 + 0x40) = *(longlong *)(lVar10 + 0x40) + -4;
    *(int *)(lVar10 + 0x30) = *(int *)(lVar10 + 0x30) + 4;
    **(undefined4 **)(lVar10 + 0x40) = (int)lVar38;
    local_378 = (ulonglong *)CONCAT44(local_378._4_4_,*(undefined4 *)(lVar10 + 0x30));
    FUN_180442250(*(undefined8 *)(param_1 + 0x120),&local_38c,local_1e0);
    FUN_180442250(*(undefined8 *)(param_1 + 0x120),&local_390,local_1f8);
    lVar10 = *(longlong *)(param_1 + 0x120);
    lVar38 = (longlong)(local_2f0._8_8_ - local_2f0._0_8_) >> 2;
    puVar32 = &DAT_180d6e9e9;
    if (local_2f0._0_8_ != local_2f0._8_8_) {
      puVar32 = (undefined *)local_2f0._0_8_;
    }
    FUN_1801c3f20(lVar10,lVar38,4);
    lVar30 = lVar38;
    while (lVar30 != 0) {
      lVar30 = lVar30 + -1;
      iVar37 = *(int *)(puVar32 + lVar30 * 4);
      if (*(ulonglong *)(lVar10 + 0x68) < 4) {
        *(undefined8 *)(lVar10 + 0x68) = 4;
      }
      FUN_1801c5360(lVar10,-*(int *)(lVar10 + 0x30) & 3);
      iVar3 = *(int *)(lVar10 + 0x30);
      if (*(ulonglong *)(lVar10 + 0x68) < 4) {
        *(undefined8 *)(lVar10 + 0x68) = 4;
      }
      FUN_1801c5360(lVar10,-iVar3 & 3);
      FUN_1801c5410(lVar10,4);
      piVar23 = (int *)(*(longlong *)(lVar10 + 0x40) + -4);
      *(int **)(lVar10 + 0x40) = piVar23;
      *(int *)(lVar10 + 0x30) = *(int *)(lVar10 + 0x30) + 4;
      *piVar23 = (iVar3 - iVar37) + 4;
    }
    *(undefined1 *)(lVar10 + 0x60) = 0;
    if (*(ulonglong *)(lVar10 + 0x68) < 4) {
      *(undefined8 *)(lVar10 + 0x68) = 4;
    }
    FUN_1801c5360(lVar10,-*(int *)(lVar10 + 0x30) & 3);
    FUN_1801c5410(lVar10,4);
    *(longlong *)(lVar10 + 0x40) = *(longlong *)(lVar10 + 0x40) + -4;
    *(int *)(lVar10 + 0x30) = *(int *)(lVar10 + 0x30) + 4;
    **(undefined4 **)(lVar10 + 0x40) = (int)lVar38;
    local_380 = *(undefined4 *)(lVar10 + 0x30);
    local_3ac = 0;
    lVar10 = *(longlong *)(param_1 + 0x120);
    lVar30 = local_338._8_8_ - local_398 >> 2;
    lVar38 = 0x180d6e9e0;
    if (local_398 != local_338._8_8_) {
      lVar38 = local_398;
    }
    FUN_1801c3f20(lVar10,lVar30,4);
    lVar31 = lVar30;
    while (lVar31 != 0) {
      lVar31 = lVar31 + -1;
      iVar37 = *(int *)(lVar38 + lVar31 * 4);
      if (*(ulonglong *)(lVar10 + 0x68) < 4) {
        *(undefined8 *)(lVar10 + 0x68) = 4;
      }
      FUN_1801c5360(lVar10,-*(int *)(lVar10 + 0x30) & 3);
      iVar3 = *(int *)(lVar10 + 0x30);
      if (*(ulonglong *)(lVar10 + 0x68) < 4) {
        *(undefined8 *)(lVar10 + 0x68) = 4;
      }
      FUN_1801c5360(lVar10,-iVar3 & 3);
      FUN_1801c5410(lVar10,4);
      piVar23 = (int *)(*(longlong *)(lVar10 + 0x40) + -4);
      *(int **)(lVar10 + 0x40) = piVar23;
      *(int *)(lVar10 + 0x30) = *(int *)(lVar10 + 0x30) + 4;
      *piVar23 = (iVar3 - iVar37) + 4;
    }
    *(undefined1 *)(lVar10 + 0x60) = 0;
    if (*(ulonglong *)(lVar10 + 0x68) < 4) {
      *(undefined8 *)(lVar10 + 0x68) = 4;
    }
    FUN_1801c5360(lVar10,-*(int *)(lVar10 + 0x30) & 3);
    FUN_1801c5410(lVar10,4);
    *(longlong *)(lVar10 + 0x40) = *(longlong *)(lVar10 + 0x40) + -4;
    *(int *)(lVar10 + 0x30) = *(int *)(lVar10 + 0x30) + 4;
    **(undefined4 **)(lVar10 + 0x40) = (int)lVar30;
    local_384 = *(undefined4 *)(lVar10 + 0x30);
    if ((*(byte *)(param_1 + 0x122) & 4) != 0) {
      lVar10 = 0x180d6e9e1;
      if (local_288._0_8_ != local_288._8_8_) {
        lVar10 = local_288._0_8_;
      }
      FUN_1804430e0(*(undefined8 *)(param_1 + 0x120),&local_3b0,lVar10,
                    (longlong)(local_288._8_8_ - local_288._0_8_) >> 2);
      local_3ac = local_3b0;
    }
    lVar10 = *(longlong *)(param_1 + 0x120);
    lVar38 = (longlong)(local_2a0._8_8_ - local_2a0._0_8_) >> 2;
    puVar32 = &DAT_180d6e9ec;
    if (local_2a0._0_8_ != local_2a0._8_8_) {
      puVar32 = (undefined *)local_2a0._0_8_;
    }
    FUN_1801c3f20(lVar10,lVar38,4);
    lVar30 = lVar38;
    while (lVar30 != 0) {
      lVar30 = lVar30 + -1;
      iVar37 = *(int *)(puVar32 + lVar30 * 4);
      if (*(ulonglong *)(lVar10 + 0x68) < 4) {
        *(undefined8 *)(lVar10 + 0x68) = 4;
      }
      FUN_1801c5360(lVar10,-*(int *)(lVar10 + 0x30) & 3);
      iVar3 = *(int *)(lVar10 + 0x30);
      if (*(ulonglong *)(lVar10 + 0x68) < 4) {
        *(undefined8 *)(lVar10 + 0x68) = 4;
      }
      FUN_1801c5360(lVar10,-iVar3 & 3);
      FUN_1801c5410(lVar10,4);
      piVar23 = (int *)(*(longlong *)(lVar10 + 0x40) + -4);
      *(int **)(lVar10 + 0x40) = piVar23;
      *(int *)(lVar10 + 0x30) = *(int *)(lVar10 + 0x30) + 4;
      *piVar23 = (iVar3 - iVar37) + 4;
    }
    *(undefined1 *)(lVar10 + 0x60) = 0;
    if (*(ulonglong *)(lVar10 + 0x68) < 4) {
      *(undefined8 *)(lVar10 + 0x68) = 4;
    }
    FUN_1801c5360(lVar10,-*(int *)(lVar10 + 0x30) & 3);
    FUN_1801c5410(lVar10,4);
    *(longlong *)(lVar10 + 0x40) = *(longlong *)(lVar10 + 0x40) + -4;
    *(int *)(lVar10 + 0x30) = *(int *)(lVar10 + 0x30) + 4;
    **(undefined4 **)(lVar10 + 0x40) = (int)lVar38;
    uVar2 = *(undefined4 *)(lVar10 + 0x30);
    local_2c8 = _Xtime_get_ticks();
    local_2c8 = local_2c8 / 10000;
    uVar9 = *(undefined8 *)(param_1 + 0x120);
    pauVar18 = (undefined1 (*) [16])FUN_180438a20(local_3c8);
    local_358 = *pauVar18;
    FUN_180433ef0(uVar9,&local_3b0,local_358);
    puVar19 = (undefined4 *)FUN_18043e580(param_1,&local_3a8);
    uVar4 = *puVar19;
    if (DAT_180d56240 != '\0') {
      FUN_18052b510(&DAT_180d55dd8);
    }
    if (DAT_180d5a060 != '\0') {
      FUN_18052c740(&DAT_180d59bf8,0);
    }
    FUN_180426400(local_3c8);
    auVar6 = vpcmpeqd_avx(ZEXT116((byte)local_3b8),ZEXT416(0));
    auVar6 = vblendvps_avx(ZEXT416((uint)puStack_3c0),auVar41._0_16_,auVar6);
    uVar9 = auVar6._0_8_;
    auVar41 = ZEXT1664(auVar6);
    if (DAT_180d22288 == '\0') {
      puVar19 = (undefined4 *)(_DAT_180d21e20 + 0x6df70a65e6632e3aU ^ 0xbcd1994011bf48c);
    }
    else {
      puVar19 = (undefined4 *)FUN_18052c740(&DAT_180d21e20,0);
      uVar9 = auVar41._0_8_;
    }
    plVar17 = local_2a8;
    if (puVar19 != (undefined4 *)0x0) {
      puVar19 = (undefined4 *)((longlong)puVar19 + DAT_180d20bd0);
    }
    local_3e8 = local_3b0;
    local_3f0 = local_3ac;
    local_3f8 = local_384;
    local_400 = local_380;
    local_408 = local_390;
    local_410 = local_38c;
    local_418 = local_378._0_4_;
    local_420 = local_3a4;
    local_428 = local_388;
    local_430 = local_3a8;
    local_448 = local_2c8;
    local_440 = uVar4;
    local_438 = uVar2;
    FUN_180438630(local_2a8,*(undefined8 *)(local_3a0 + 0x120),*puVar19,uVar9);
    if (local_288._0_8_ != 0) {
      uVar26 = ((longlong)local_278 - local_288._0_8_ >> 2) * 4;
      lVar10 = local_288._0_8_;
      if (0xfff < uVar26) {
        if (0x1f < (local_288._0_8_ - *(longlong *)(local_288._0_8_ + -8)) - 8U) goto LAB_18044062b;
        uVar26 = uVar26 + 0x27;
        lVar10 = *(longlong *)(local_288._0_8_ + -8);
      }
      thunk_FUN_180895720(lVar10,uVar26);
      local_288 = (undefined1  [16])0x0;
      local_278 = (undefined4 *)0x0;
    }
    FUN_1801ad9b0(&local_220);
    FUN_180442820(&local_230);
    if (local_398 != 0) {
      uVar26 = (local_320 - local_398 >> 2) * 4;
      lVar10 = local_398;
      if (0xfff < uVar26) {
        if (0x1f < (local_398 - *(longlong *)(local_398 + -8)) - 8U) goto LAB_18044062b;
        uVar26 = uVar26 + 0x27;
        lVar10 = *(longlong *)(local_398 + -8);
      }
      thunk_FUN_180895720(lVar10,uVar26);
    }
    if (local_2f0._0_8_ != 0) {
      uVar26 = (local_318 - local_2f0._0_8_ >> 2) * 4;
      lVar10 = local_2f0._0_8_;
      if (0xfff < uVar26) {
        if (0x1f < (local_2f0._0_8_ - *(longlong *)(local_2f0._0_8_ + -8)) - 8U) goto LAB_18044062b;
        uVar26 = uVar26 + 0x27;
        lVar10 = *(longlong *)(local_2f0._0_8_ + -8);
      }
      thunk_FUN_180895720(lVar10,uVar26);
    }
    if (local_1f8._0_8_ != 0) {
      uVar26 = (local_1e8 - local_1f8._0_8_ >> 2) * 4;
      lVar10 = local_1f8._0_8_;
      if (0xfff < uVar26) {
        if (0x1f < (local_1f8._0_8_ - *(longlong *)(local_1f8._0_8_ + -8)) - 8U) goto LAB_18044062b;
        uVar26 = uVar26 + 0x27;
        lVar10 = *(longlong *)(local_1f8._0_8_ + -8);
      }
      thunk_FUN_180895720(lVar10,uVar26);
    }
    if (local_1e0._0_8_ != 0) {
      uVar26 = (local_1d0 - local_1e0._0_8_ >> 2) * 4;
      lVar10 = local_1e0._0_8_;
      if (0xfff < uVar26) {
        if (0x1f < (local_1e0._0_8_ - *(longlong *)(local_1e0._0_8_ + -8)) - 8U) goto LAB_18044062b;
        uVar26 = uVar26 + 0x27;
        lVar10 = *(longlong *)(local_1e0._0_8_ + -8);
      }
      thunk_FUN_180895720(lVar10,uVar26);
    }
    if (local_2d8 != (undefined4 *)0x0) {
      uVar26 = ((longlong)local_310 - (longlong)local_2d8 >> 2) * 4;
      puVar19 = local_2d8;
      if (0xfff < uVar26) {
        if ((undefined *)0x1f <
            (undefined *)((longlong)local_2d8 + (-8 - (longlong)*(undefined4 **)(local_2d8 + -2))))
        goto LAB_18044062b;
        uVar26 = uVar26 + 0x27;
        puVar19 = *(undefined4 **)(local_2d8 + -2);
      }
      thunk_FUN_180895720(puVar19,uVar26);
    }
    if (local_2d0 != (undefined4 *)0x0) {
      uVar26 = ((longlong)local_3d0 - (longlong)local_2d0 >> 2) * 4;
      puVar19 = local_2d0;
      if (0xfff < uVar26) {
        if (0x1f < (ulonglong)
                   ((longlong)local_2d0 + (-8 - (longlong)*(undefined4 **)(local_2d0 + -2))))
        goto LAB_18044062b;
        uVar26 = uVar26 + 0x27;
        puVar19 = *(undefined4 **)(local_2d0 + -2);
      }
      thunk_FUN_180895720(puVar19,uVar26);
    }
    FUN_1801a2440(local_2c0);
    FUN_1801ad9b0(local_1b0);
    FUN_1804428b0(local_1c0);
    FUN_18022fbb0(local_98);
    FUN_1801e5ed0(local_b0);
    FUN_1803fb4e0(local_c8);
    FUN_1801d11e0(local_e0);
    FUN_1801f3260(local_f8);
    FUN_1801d11e0(local_110);
    FUN_1801ad9b0(local_128);
    FUN_1802d14e0(local_140);
    FUN_1801f3260(local_158);
    FUN_1802d14e0(local_170);
    FUN_1802d14e0(local_188);
    if (local_2a0._0_8_ == 0) goto LAB_18044063d;
    lVar10 = local_2a0._0_8_;
    puVar28 = auStack_468;
    if ((0xfff < (ulonglong)(((longlong)local_290 - local_2a0._0_8_ >> 2) * 4)) &&
       (lVar10 = *(longlong *)(local_2a0._0_8_ + -8), puVar28 = auStack_468,
       0x1f < (local_2a0._0_8_ - *(longlong *)(local_2a0._0_8_ + -8)) - 8U)) goto LAB_18044062b;
  }
  else {
    lVar10 = FUN_180976d80(0x1f67);
    if (lVar10 != 0) {
      uVar26 = lVar10 + 0x27U & 0xffffffffffffffe0;
      *(longlong *)(uVar26 - 8) = lVar10;
      FUN_1809bf2f0(uVar26,local_288._0_8_,local_288._8_8_ - local_288._0_8_);
      puVar12 = (ulonglong *)0x0;
      FUN_180189f40(local_288,uVar26,0,2000);
      local_378 = local_230;
      puVar27 = (ulonglong *)*local_230;
      if (puVar27 != local_230) {
        do {
          puVar12 = (ulonglong *)puVar27[2];
          puVar16 = (undefined4 *)
                    FUN_180438470(&local_3a4,*(undefined8 *)(param_1 + 0x120),puVar12,puVar27 + 3);
          puVar24 = (undefined4 *)local_288._8_8_;
          if ((undefined4 *)local_288._8_8_ == local_278) {
            uVar26 = local_288._8_8_ - local_288._0_8_;
            lVar10 = (longlong)uVar26 >> 2;
            if (lVar10 == 0x3fffffffffffffff) {
                    /* WARNING: Subroutine does not return */
              FUN_180183310();
            }
            puVar12 = (ulonglong *)(lVar10 + 1);
            uVar20 = (longlong)local_278 - local_288._0_8_ >> 2;
            if (0x3fffffffffffffff - (uVar20 >> 1) < uVar20) {
              puVar36 = (ulonglong *)0x3fffffffffffffff;
            }
            else {
              puVar1 = (ulonglong *)((uVar20 >> 1) + uVar20);
              puVar36 = puVar12;
              if (puVar12 <= puVar1) {
                puVar36 = puVar1;
              }
              if ((ulonglong *)0x3fffffffffffffff < puVar36) {
                    /* WARNING: Subroutine does not return */
                FUN_1801a22b0();
              }
            }
            lVar10 = FUN_1801a22d0((longlong)puVar36 * 4);
            uVar26 = uVar26 & 0xfffffffffffffffc;
            *(undefined4 *)(uVar26 + lVar10) = *puVar16;
            if (puVar24 == (undefined4 *)local_288._8_8_) {
              lVar30 = local_288._8_8_ - local_288._0_8_;
              lVar38 = lVar10;
              puVar24 = (undefined4 *)local_288._0_8_;
            }
            else {
              FUN_1809bf2f0(lVar10,local_288._0_8_,(longlong)puVar24 - local_288._0_8_);
              lVar30 = local_288._8_8_ - (longlong)puVar24;
              lVar38 = uVar26 + 4 + lVar10;
            }
            FUN_1809bf2f0(lVar38,puVar24,lVar30);
            FUN_180189f40(local_288,lVar10,puVar12,puVar36);
          }
          else {
            *(undefined4 *)local_288._8_8_ = *puVar16;
            local_288._8_8_ = (undefined4 *)(local_288._8_8_ + 4);
          }
          puVar27 = (ulonglong *)*puVar27;
          param_1 = local_3a0;
        } while (puVar27 != local_378);
      }
      goto LAB_18043f950;
    }
LAB_18044062b:
    lVar10 = 5;
    pcVar33 = (code *)swi(0x29);
    (*pcVar33)(5);
    puVar28 = auStack_460;
  }
  *(undefined8 *)(puVar28 + -8) = 0x18044063d;
  thunk_FUN_180895720(lVar10);
LAB_18044063d:
  *(undefined8 *)(puVar28 + -8) = 0x18044064f;
  return plVar17;
}

