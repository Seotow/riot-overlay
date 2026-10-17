// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180439a70; descriptive alias: FUN_180439a70
// Evidence: ev_fb0b82e2d44054cd5d8315f61a7125cee89c56abb74c01ba8f61b1f9406c74eb
// Original Evidence: rea-collector/0x180439a70.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */

undefined8 FUN_180439a70(longlong param_1,undefined8 param_2,longlong param_3,char param_4)

{
  float *pfVar1;
  float fVar2;
  undefined8 uVar3;
  code *pcVar4;
  undefined8 uVar5;
  undefined2 uVar6;
  char cVar7;
  uint uVar8;
  undefined4 uVar9;
  uint uVar10;
  undefined4 uVar11;
  undefined4 uVar12;
  int iVar13;
  undefined4 uVar14;
  longlong lVar15;
  undefined8 *puVar16;
  longlong *plVar17;
  char *pcVar18;
  ulonglong uVar19;
  undefined4 *puVar20;
  undefined1 (*pauVar21) [16];
  undefined4 *puVar22;
  float *pfVar23;
  ulonglong uVar24;
  int *piVar25;
  int iVar26;
  longlong lVar27;
  undefined1 *puVar28;
  longlong *plVar29;
  undefined4 *puVar30;
  undefined4 uVar31;
  undefined4 uVar32;
  undefined1 extraout_var [56];
  undefined1 extraout_var_00 [56];
  undefined1 in_ZMM6 [64];
  undefined1 auVar33 [64];
  undefined1 in_ZMM7 [64];
  undefined1 auVar34 [64];
  undefined1 auVar35 [64];
  float fVar36;
  undefined1 auVar37 [16];
  undefined1 auVar38 [64];
  undefined1 auVar39 [64];
  undefined1 auVar40 [64];
  undefined1 auVar41 [64];
  undefined1 auVar42 [64];
  undefined1 auStack_8a8 [8];
  undefined1 auStack_8a0 [24];
  undefined4 local_888;
  undefined4 local_880;
  int local_878;
  undefined4 local_870;
  char local_868;
  undefined4 local_860;
  int local_818;
  char local_814;
  undefined1 local_813;
  longlong local_810;
  undefined4 local_808;
  int local_804;
  ulonglong local_800;
  longlong *local_7f8;
  undefined4 *local_7f0;
  longlong *local_7e8 [2];
  undefined1 local_7d8 [32];
  undefined1 local_7b8 [16];
  undefined1 *local_7a8;
  longlong local_7a0;
  undefined1 local_798 [8];
  longlong local_790;
  undefined1 *local_788;
  undefined8 local_780;
  undefined8 local_778;
  undefined4 *local_768 [2];
  undefined8 local_758;
  undefined8 local_750;
  undefined8 local_748;
  undefined8 local_740;
  undefined8 local_738;
  undefined8 local_730;
  undefined8 local_728;
  undefined8 local_720;
  undefined8 local_718;
  undefined8 local_710;
  undefined8 local_708;
  undefined8 local_700;
  undefined8 local_6f8;
  undefined8 local_6f0;
  undefined8 local_6e8;
  undefined8 local_6e0;
  undefined8 local_6d8;
  undefined8 local_6d0;
  undefined8 local_6c8;
  undefined8 local_6c0;
  undefined8 local_6b8;
  undefined8 local_6b0;
  undefined8 local_6a8;
  undefined8 local_6a0;
  undefined8 local_698;
  undefined8 local_690;
  undefined8 local_688;
  undefined8 local_680;
  undefined8 local_678;
  undefined8 local_670;
  undefined8 local_668;
  undefined8 local_660;
  undefined8 local_658;
  undefined8 local_650;
  undefined8 local_648;
  undefined8 local_640;
  undefined8 local_638;
  undefined8 local_630;
  undefined8 local_628;
  undefined8 local_620;
  undefined8 local_618;
  undefined8 local_610;
  undefined8 local_608;
  undefined8 local_600;
  undefined8 local_5f8;
  undefined8 local_5f0;
  undefined8 local_5e8;
  undefined8 local_5e0;
  float local_5d8 [6];
  undefined4 local_5c0;
  undefined4 local_5bc;
  undefined4 local_5b8;
  undefined4 local_5b4;
  undefined4 local_5b0;
  undefined4 local_5ac;
  undefined4 local_5a8;
  undefined4 local_5a4;
  undefined4 local_5a0;
  undefined4 local_59c;
  undefined4 local_598;
  undefined4 local_594;
  undefined4 local_590;
  undefined4 local_58c;
  undefined4 local_588;
  undefined4 local_584;
  undefined4 local_580;
  undefined4 local_57c;
  undefined4 local_578;
  undefined4 local_574;
  undefined4 local_570;
  undefined4 local_56c;
  undefined4 local_568;
  undefined4 local_564;
  undefined4 local_560;
  undefined4 local_55c;
  undefined4 local_558;
  undefined4 local_554;
  undefined4 local_550;
  undefined4 local_54c;
  undefined4 local_548;
  undefined4 local_544;
  undefined4 local_540;
  undefined4 local_53c;
  undefined4 local_538;
  undefined4 local_534;
  undefined4 local_530;
  undefined4 local_52c;
  undefined4 local_528;
  undefined4 local_524;
  undefined4 local_520;
  undefined4 local_51c;
  undefined4 local_518;
  undefined4 local_514;
  undefined4 local_510;
  undefined4 local_50c;
  undefined4 local_508;
  undefined4 local_504;
  undefined4 local_500;
  undefined4 local_4fc;
  undefined4 local_4f8;
  undefined4 local_4f4;
  undefined4 local_4f0;
  undefined4 local_4ec;
  undefined4 local_4e8;
  undefined4 local_4e4;
  undefined4 local_4e0;
  undefined4 local_4dc;
  undefined4 local_4d8;
  undefined4 local_4d4;
  undefined4 local_4d0;
  undefined4 local_4cc;
  undefined4 local_4c8;
  undefined4 local_4c4;
  undefined4 local_4c0;
  undefined4 local_4bc;
  undefined4 local_4b8;
  undefined4 local_4b4;
  undefined4 local_4b0;
  undefined4 local_4ac;
  undefined4 local_4a8;
  undefined4 local_4a4;
  undefined4 local_4a0;
  undefined4 local_49c;
  undefined4 local_498;
  undefined4 local_494;
  undefined4 local_490;
  undefined4 local_48c;
  undefined4 local_488;
  undefined4 local_484;
  undefined4 local_480;
  undefined4 local_47c;
  undefined4 local_478;
  undefined4 local_474;
  undefined4 local_470;
  undefined4 local_46c;
  undefined4 local_468;
  undefined4 local_464;
  undefined4 local_460;
  undefined4 local_45c;
  undefined4 local_458;
  undefined4 local_454;
  undefined4 local_450;
  undefined4 local_44c;
  undefined4 local_448;
  undefined4 local_444;
  undefined4 local_440;
  undefined4 local_43c;
  undefined4 local_438;
  undefined4 local_434;
  undefined4 local_430;
  undefined4 local_42c;
  undefined4 local_428;
  undefined4 local_424;
  undefined4 local_420;
  undefined4 local_41c;
  undefined4 local_418;
  undefined4 local_414;
  undefined4 local_410;
  undefined4 local_40c;
  undefined4 local_408;
  undefined4 local_404;
  undefined4 local_400;
  undefined4 local_3fc;
  undefined4 local_3f8;
  undefined4 local_3f4;
  undefined4 local_3f0;
  undefined4 local_3ec;
  undefined4 local_3e8;
  undefined4 local_3e4;
  undefined4 local_3e0;
  undefined4 local_3dc;
  undefined8 auStack_3d8 [64];
  undefined1 local_1d8 [256];
  ulonglong local_d8;
  undefined1 local_58 [16];
  undefined1 local_48 [16];
  
  puVar28 = auStack_8a8;
  local_48 = in_ZMM6._0_16_;
  local_58 = in_ZMM7._0_16_;
  local_d8 = DAT_180d06cc0 ^ (ulonglong)auStack_8a8;
  uVar3 = *(undefined8 *)(param_1 + 0x480);
  local_810 = param_1;
  local_790 = param_3;
  local_778 = param_2;
  if (DAT_180d33158 == '\0') {
    uVar8 = DAT_180d32cf0 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar8 = FUN_18052b510(&DAT_180d32cf0);
  }
  FUN_1804311d0(local_7d8,(ulonglong)uVar8 + param_3);
  FUN_180433ef0(uVar3,local_798);
  local_788 = &DAT_180c0f302;
  iVar13 = 0;
  uVar9 = 0;
  local_780 = 0;
  auVar38 = ZEXT464(0x7fc00000);
  auVar37 = auVar38._0_16_;
  auVar42 = ZEXT1664(auVar37);
  auVar41 = ZEXT1664(auVar37);
  auVar40 = ZEXT1664(auVar37);
  auVar39 = ZEXT1664(auVar37);
  uVar11 = 0;
  local_818 = 0;
  local_808 = 0;
  local_813 = FUN_180431900(param_3);
  uVar8 = *(uint *)(param_1 + 0x488);
  if ((uVar8 & 1) != 0) {
    lVar15 = FUN_180432260(param_3);
    local_7b8 = (undefined1  [16])0x0;
    local_7a8 = (undefined1 *)0x0;
    local_7a0 = 0;
    FUN_1801a0b30(local_7b8,"datastack");
    FUN_1801a2650(local_7b8);
    if ((*(uint *)(param_1 + 0x488) & 1) != 0) {
      uVar3 = *(undefined8 *)(param_1 + 0x480);
      pauVar21 = (undefined1 (*) [16])FUN_180425820(lVar15,local_7e8);
      local_7d8._0_16_ = *pauVar21;
      FUN_180433ef0(uVar3,&local_804,local_7d8);
      uVar9 = *(undefined4 *)(((ulonglong)(DAT_180d3931c + 0xe6632e3a) ^ 0x11bf48c) + lVar15);
      uVar12 = *(undefined4 *)(((ulonglong)(DAT_180d39314 + 0xe6632e3a) ^ 0x11bf48c) + lVar15);
      lVar15 = *(longlong *)(param_1 + 0x480);
      *(undefined1 *)(lVar15 + 0x60) = 1;
      uVar14 = *(undefined4 *)(lVar15 + 0x30);
      FUN_1801bd800(lVar15,8,uVar9,0);
      FUN_1801bd800(lVar15,6,uVar12,0);
      FUN_1801bd760(lVar15,4);
      uVar9 = FUN_1801be990(lVar15,uVar14);
    }
    uVar8 = *(uint *)(param_1 + 0x488);
    param_3 = local_790;
  }
  auVar35 = ZEXT1264(ZEXT812(0));
  if ((uVar8 & 4) != 0) {
    auVar38._0_8_ = FUN_180431300(param_3);
    auVar38._8_56_ = extraout_var;
    auVar38 = ZEXT1664(auVar38._0_16_);
    puVar16 = (undefined8 *)FUN_180432100(param_3,local_7d8);
    local_788 = (undefined1 *)*puVar16;
    local_780 = puVar16[1];
    auVar39._0_8_ = FUN_180431350(param_3);
    auVar39._8_56_ = extraout_var_00;
    auVar42 = ZEXT1664(auVar39._0_16_);
    if (DAT_180d32408 == '\0') {
      uVar8 = DAT_180d31fa0 + 0xe6632e3aU ^ 0x11bf48c;
    }
    else {
      uVar8 = FUN_18052b510(&DAT_180d31fa0);
    }
    auVar41 = ZEXT464(*(uint *)((ulonglong)uVar8 + param_3));
    if (DAT_180d32408 == '\0') {
      uVar8 = DAT_180d31fa0 + 0xe6632e3aU ^ 0x11bf48c;
    }
    else {
      uVar8 = FUN_18052b510(&DAT_180d31fa0);
    }
    if (DAT_180d32878 == '\0') {
      uVar10 = DAT_180d32410 + 0xe6632e3aU ^ 0x11bf48c;
    }
    else {
      uVar10 = FUN_18052b510(&DAT_180d32410);
    }
    auVar40 = ZEXT464(*(uint *)((ulonglong)(uVar10 + uVar8) + param_3));
    if (DAT_180d31f98 == '\0') {
      uVar8 = DAT_180d31b30 + 0xe6632e3aU ^ 0x11bf48c;
    }
    else {
      uVar8 = FUN_18052b510(&DAT_180d31b30);
    }
    auVar39 = ZEXT464(*(uint *)((ulonglong)uVar8 + param_3));
    plVar17 = (longlong *)FUN_180432200(param_3);
    lVar15 = local_810;
    local_7f8 = plVar17;
    if (param_4 == '\0') {
      puVar20 = (undefined4 *)FUN_1804392f0(local_810,&local_800);
      uVar11 = *puVar20;
    }
    else {
      pcVar18 = (char *)FUN_180429530(local_810 + 0x490,plVar17);
      uVar24 = 0;
      local_6d8 = 0;
      local_6d0 = 0;
      local_6c8 = 0;
      local_6c0 = 0;
      local_6b8 = 0;
      local_6b0 = 0;
      local_6a8 = 0;
      local_6a0 = 0;
      local_698 = 0;
      local_690 = 0;
      local_688 = 0;
      local_680 = 0;
      local_678 = 0;
      local_670 = 0;
      local_668 = 0;
      local_660 = 0;
      local_658 = 0;
      local_650 = 0;
      local_648 = 0;
      local_640 = 0;
      local_638 = 0;
      local_630 = 0;
      local_628 = 0;
      local_620 = 0;
      local_618 = 0;
      local_610 = 0;
      local_608 = 0;
      local_600 = 0;
      local_5f8 = 0;
      local_5f0 = 0;
      local_5e8 = 0;
      local_5e0 = 0;
      uVar19 = uVar24;
      do {
        *(undefined8 *)((longlong)auStack_3d8 + uVar19 * 4) = 0;
        *(undefined8 *)((longlong)auStack_3d8 + uVar19 * 4 + 8) = 0;
        *(undefined8 *)((longlong)auStack_3d8 + uVar19 * 4 + 0x10) = 0;
        *(undefined8 *)((longlong)auStack_3d8 + uVar19 * 4 + 0x18) = 0;
        *(undefined8 *)((longlong)auStack_3d8 + uVar19 * 4 + 0x20) = 0;
        *(undefined8 *)((longlong)auStack_3d8 + uVar19 * 4 + 0x28) = 0;
        *(undefined8 *)((longlong)auStack_3d8 + uVar19 * 4 + 0x30) = 0;
        *(undefined8 *)((longlong)auStack_3d8 + uVar19 * 4 + 0x38) = 0;
        uVar19 = uVar19 + 0x10;
      } while (uVar19 < 0x80);
      local_758 = 0;
      local_750 = 0;
      local_748 = 0;
      local_740 = 0;
      local_738 = 0;
      local_730 = 0;
      local_728 = 0;
      local_720 = 0;
      local_718 = 0;
      local_710 = 0;
      local_708 = 0;
      local_700 = 0;
      local_6f8 = 0;
      local_6f0 = 0;
      local_6e8 = 0;
      local_6e0 = 0;
      local_5d8[0] = 0.0;
      local_5d8[1] = auVar35._0_4_;
      local_5d8[2] = 0.0;
      local_5d8[4] = 0.0;
      local_5c0 = 0;
      local_5b8 = 0;
      local_5b0 = 0;
      local_5a8 = 0;
      local_5a0 = 0;
      local_598 = 0;
      local_590 = 0;
      local_588 = 0;
      local_580 = 0;
      local_578 = 0;
      local_570 = 0;
      local_568 = 0;
      local_560 = 0;
      local_558 = 0;
      local_550 = 0;
      local_548 = 0;
      local_540 = 0;
      local_538 = 0;
      local_530 = 0;
      local_528 = 0;
      local_520 = 0;
      local_518 = 0;
      local_510 = 0;
      local_508 = 0;
      local_500 = 0;
      local_4f8 = 0;
      local_4f0 = 0;
      local_4e8 = 0;
      local_4e0 = 0;
      local_4d8 = 0;
      local_4d0 = 0;
      local_4c8 = 0;
      local_4c0 = 0;
      local_4b8 = 0;
      local_4b0 = 0;
      local_4a8 = 0;
      local_4a0 = 0;
      local_498 = 0;
      local_490 = 0;
      local_488 = 0;
      local_480 = 0;
      local_478 = 0;
      local_470 = 0;
      local_468 = 0;
      local_460 = 0;
      local_458 = 0;
      local_450 = 0;
      local_448 = 0;
      local_440 = 0;
      local_438 = 0;
      local_430 = 0;
      local_428 = 0;
      local_420 = 0;
      local_418 = 0;
      local_410 = 0;
      local_408 = 0;
      local_400 = 0;
      local_3f8 = 0;
      local_3f0 = 0;
      local_3e8 = 0;
      local_3e0 = 0;
      local_5d8[3] = local_5d8[1];
      local_5d8[5] = local_5d8[1];
      local_5bc = local_5d8[1];
      local_5b4 = local_5d8[1];
      local_5ac = local_5d8[1];
      local_5a4 = local_5d8[1];
      local_59c = local_5d8[1];
      local_594 = local_5d8[1];
      local_58c = local_5d8[1];
      local_584 = local_5d8[1];
      local_57c = local_5d8[1];
      local_574 = local_5d8[1];
      local_56c = local_5d8[1];
      local_564 = local_5d8[1];
      local_55c = local_5d8[1];
      local_554 = local_5d8[1];
      local_54c = local_5d8[1];
      local_544 = local_5d8[1];
      local_53c = local_5d8[1];
      local_534 = local_5d8[1];
      local_52c = local_5d8[1];
      local_524 = local_5d8[1];
      local_51c = local_5d8[1];
      local_514 = local_5d8[1];
      local_50c = local_5d8[1];
      local_504 = local_5d8[1];
      local_4fc = local_5d8[1];
      local_4f4 = local_5d8[1];
      local_4ec = local_5d8[1];
      local_4e4 = local_5d8[1];
      local_4dc = local_5d8[1];
      local_4d4 = local_5d8[1];
      local_4cc = local_5d8[1];
      local_4c4 = local_5d8[1];
      local_4bc = local_5d8[1];
      local_4b4 = local_5d8[1];
      local_4ac = local_5d8[1];
      local_4a4 = local_5d8[1];
      local_49c = local_5d8[1];
      local_494 = local_5d8[1];
      local_48c = local_5d8[1];
      local_484 = local_5d8[1];
      local_47c = local_5d8[1];
      local_474 = local_5d8[1];
      local_46c = local_5d8[1];
      local_464 = local_5d8[1];
      local_45c = local_5d8[1];
      local_454 = local_5d8[1];
      local_44c = local_5d8[1];
      local_444 = local_5d8[1];
      local_43c = local_5d8[1];
      local_434 = local_5d8[1];
      local_42c = local_5d8[1];
      local_424 = local_5d8[1];
      local_41c = local_5d8[1];
      local_414 = local_5d8[1];
      local_40c = local_5d8[1];
      local_404 = local_5d8[1];
      local_3fc = local_5d8[1];
      local_3f4 = local_5d8[1];
      local_3ec = local_5d8[1];
      local_3e4 = local_5d8[1];
      local_3dc = local_5d8[1];
      FUN_1809bef30(local_1d8,0,0x100);
      local_768[0] = (undefined4 *)0x0;
      local_7b8._8_8_ = pcVar18;
      local_7b8._0_8_ = local_768;
      local_7a8 = local_1d8;
      local_7a0 = lVar15;
      uVar19 = uVar24;
      if (*(int *)(pcVar18 + 4) != 0) {
        do {
          lVar27 = uVar24 * 0x820;
          uVar11 = 0;
          if (pcVar18[lVar27 + 0x835] != '\0') {
            puVar20 = (undefined4 *)FUN_180439820(local_7b8,&local_800,pcVar18 + lVar27 + 0x838);
            uVar11 = *puVar20;
          }
          local_868 = pcVar18[lVar27 + 0x834];
          local_870 = *(undefined4 *)(pcVar18 + lVar27 + 0x824);
          local_878 = *(int *)(pcVar18 + lVar27 + 0x830);
          local_880 = *(undefined4 *)(pcVar18 + lVar27 + 0x82c);
          local_888 = *(undefined4 *)(pcVar18 + lVar27 + 0x828);
          local_860 = uVar11;
          puVar20 = (undefined4 *)
                    FUN_180435f30(&local_804,*(undefined8 *)(lVar15 + 0x480),
                                  *(undefined8 *)(pcVar18 + lVar27 + 0x818),
                                  *(undefined4 *)(pcVar18 + lVar27 + 0x820));
          *(undefined4 *)((longlong)&local_6d8 + uVar24 * 4) = *puVar20;
          pfVar1 = local_5d8 + uVar19 * 2;
          if (local_5d8 != pfVar1) {
            pfVar23 = local_5d8;
            do {
              if (*pfVar23 == *(float *)(pcVar18 + lVar27 + 0x820)) {
                if (pfVar23 != pfVar1) goto LAB_18043a58a;
                break;
              }
              pfVar23 = pfVar23 + 2;
            } while (pfVar23 != pfVar1);
          }
          fVar36 = *(float *)(pcVar18 + lVar27 + 0x828);
          fVar2 = *(float *)(pcVar18 + lVar27 + 0x82c);
          *pfVar1 = *(float *)(pcVar18 + lVar27 + 0x820);
          local_5d8[uVar19 * 2 + 1] = fVar36 / fVar2;
          uVar19 = uVar19 + 1;
LAB_18043a58a:
          uVar8 = (int)uVar24 + 1;
          uVar24 = (ulonglong)uVar8;
          plVar17 = local_7f8;
        } while (uVar8 < *(uint *)(pcVar18 + 4));
      }
      lVar15 = local_810;
      uVar24 = 0;
      if (*(int *)(pcVar18 + 0xc) != 0) {
        do {
          lVar27 = uVar24 * 0x1014;
          if (pcVar18[lVar27 + 0x21028] == '\0') {
            local_818 = 0;
          }
          else {
            FUN_180439820(local_7b8,&local_818,pcVar18 + lVar27 + 0x2102c);
          }
          if (pcVar18[lVar27 + 0x21029] == '\0') {
            local_808 = 0;
          }
          else {
            FUN_180439820(local_7b8,&local_808,pcVar18 + lVar27 + 0x2182c);
          }
          local_868 = pcVar18[lVar27 + 0x2102a];
          local_878 = local_818;
          local_880 = *(undefined4 *)(pcVar18 + lVar27 + 0x21024);
          local_888 = *(undefined4 *)(pcVar18 + lVar27 + 0x21020);
          local_870 = local_808;
          puVar20 = (undefined4 *)
                    FUN_180436300(&local_800,*(undefined8 *)(lVar15 + 0x480),
                                  *(undefined4 *)(pcVar18 + lVar27 + 0x21018),
                                  *(undefined4 *)(pcVar18 + lVar27 + 0x2101c));
          *(undefined4 *)((longlong)auStack_3d8 + uVar24 * 4) = *puVar20;
          uVar8 = (int)uVar24 + 1;
          uVar24 = (ulonglong)uVar8;
          plVar17 = local_7f8;
        } while (uVar8 < *(uint *)(pcVar18 + 0xc));
      }
      lVar15 = local_810;
      uVar24 = 0;
      if (*(int *)(pcVar18 + 0x10) != 0) {
        do {
          lVar27 = uVar24 * 0x810;
          if (pcVar18[lVar27 + 0xa1a25] == '\0') {
            local_818 = 0;
          }
          else {
            FUN_180439820(local_7b8,&local_818,pcVar18 + lVar27 + 0xa1a28);
          }
          local_880 = CONCAT31(local_880._1_3_,pcVar18[lVar27 + 0xa1a24]);
          local_888 = *(undefined4 *)(pcVar18 + lVar27 + 0xa1a20);
          local_878 = local_818;
          puVar20 = (undefined4 *)
                    FUN_1804365d0(&local_800,*(undefined8 *)(lVar15 + 0x480),
                                  *(undefined4 *)(pcVar18 + lVar27 + 0xa1a18),
                                  *(undefined4 *)(pcVar18 + lVar27 + 0xa1a1c));
          *(undefined4 *)((longlong)&local_758 + uVar24 * 4) = *puVar20;
          uVar8 = (int)uVar24 + 1;
          uVar24 = (ulonglong)uVar8;
          plVar17 = local_7f8;
        } while (uVar8 < *(uint *)(pcVar18 + 0x10));
      }
      lVar15 = local_810;
      if (*pcVar18 == '\x01') {
        uVar3 = *(undefined8 *)(local_810 + 0x480);
        FUN_1801c3f20(uVar3,uVar19,8,4);
        if (uVar19 != 0) {
          FUN_1801c3ea0(uVar3,local_5d8,uVar19 * 8);
        }
        uVar11 = FUN_1801bf100(uVar3,uVar19);
      }
      else {
        uVar11 = 0;
        if (plVar17 != (longlong *)0x0) {
          puVar20 = (undefined4 *)FUN_1804392f0(local_810,&local_800,plVar17);
          uVar11 = *puVar20;
        }
      }
      uVar3 = *(undefined8 *)(lVar15 + 0x480);
      uVar8 = *(uint *)(pcVar18 + 0x10);
      FUN_1801c3f20(uVar3,uVar8,4);
      uVar19 = (ulonglong)uVar8;
      if (uVar8 != 0) {
        do {
          uVar19 = uVar19 - 1;
          uVar12 = FUN_1801c3e60(uVar3,*(undefined4 *)((longlong)&local_758 + uVar19 * 4));
          FUN_1801bece0(uVar3,uVar12);
        } while (uVar19 != 0);
      }
      iVar13 = FUN_1801bf100(uVar3,uVar8);
      uVar3 = *(undefined8 *)(lVar15 + 0x480);
      uVar8 = *(uint *)(pcVar18 + 0xc);
      FUN_1801c3f20(uVar3,uVar8,4);
      uVar19 = (ulonglong)uVar8;
      if (uVar8 != 0) {
        do {
          uVar19 = uVar19 - 1;
          uVar12 = FUN_1801c3e60(uVar3,*(undefined4 *)((longlong)auStack_3d8 + uVar19 * 4));
          FUN_1801bece0(uVar3,uVar12);
        } while (uVar19 != 0);
      }
      uVar12 = FUN_1801bf100(uVar3,uVar8);
      uVar3 = *(undefined8 *)(local_810 + 0x480);
      uVar8 = *(uint *)(pcVar18 + 4);
      plVar29 = (longlong *)(ulonglong)uVar8;
      local_7e8[0] = plVar29;
      FUN_1801c3f20(uVar3,plVar29,4);
      plVar17 = (longlong *)(ulonglong)uVar8;
      if (uVar8 != 0) {
        do {
          plVar29 = (longlong *)((longlong)plVar29 - 1);
          uVar14 = FUN_1801c3e60(uVar3,*(undefined4 *)((longlong)&local_6d8 + (longlong)plVar29 * 4)
                                );
          FUN_1801bece0(uVar3,uVar14);
          plVar17 = local_7e8[0];
        } while (plVar29 != (longlong *)0x0);
      }
      local_888 = FUN_1801bf100(uVar3,plVar17);
      local_880 = uVar12;
      local_878 = iVar13;
      FUN_1804367f0(&local_804,*(undefined8 *)(local_810 + 0x480),2,*pcVar18);
      local_818 = local_804;
      param_3 = local_790;
      iVar13 = local_804;
    }
    if (DAT_180d36b08 == '\0') {
      uVar8 = DAT_180d366a0 + 0xe6632e3aU ^ 0x11bf48c;
    }
    else {
      uVar8 = FUN_18052b510(&DAT_180d366a0);
    }
    if (DAT_180d3b720 == '\0') {
      uVar10 = DAT_180d3b2b8 + 0xe6632e3aU ^ 0x11bf48c;
    }
    else {
      uVar10 = FUN_18052b510(&DAT_180d3b2b8);
    }
    lVar15 = (*(code *)((ulonglong)uVar10 + DAT_180d20bd0))((ulonglong)uVar8 + param_3);
    if (lVar15 == 0) {
      local_808 = 0;
    }
    else {
      if (DAT_180d3f118 == '\0') {
        uVar8 = DAT_180d3ecb0 + 0xe6632e3aU ^ 0x11bf48c;
      }
      else {
        uVar8 = FUN_18052b510(&DAT_180d3ecb0);
      }
      local_808 = *(undefined4 *)((ulonglong)uVar8 + lVar15);
    }
  }
  if (DAT_180d35068 == '\0') {
    uVar8 = DAT_180d34c00 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar8 = FUN_18052b510(&DAT_180d34c00);
  }
  local_7b8._7_4_ = 0x72656761;
  local_7b8._0_7_ = 0x6e616d66667562;
  local_7b8._11_5_ = 0;
  puVar20 = (undefined4 *)0x0;
  puVar30 = (undefined4 *)0x0;
  local_7f0 = (undefined4 *)0x0;
  local_768[0] = (undefined4 *)0x0;
  local_7e8[0] = *(longlong **)
                  (((ulonglong)(DAT_180d3f120 + 0xe6632e3a) ^ 0x11bf48c) +
                  (ulonglong)uVar8 + param_3);
  uVar19 = *(longlong *)
            (((ulonglong)(DAT_180d3f124 + 0xe6632e3a) ^ 0x11bf48c) + (ulonglong)uVar8 + param_3) -
           (longlong)local_7e8[0] & 0xfffffffffffffff0;
  plVar17 = (longlong *)(uVar19 + (longlong)local_7e8[0]);
  local_7f8 = plVar17;
  if (uVar19 != 0) {
    uVar6 = local_778._6_2_;
    fVar36 = 1000.0;
    do {
      lVar15 = *local_7e8[0];
      if (lVar15 != 0) {
        if (DAT_180d402f8 == '\0') {
          uVar8 = DAT_180d3fe90 + 0xe6632e3aU ^ 0x11bf48c;
        }
        else {
          uVar8 = FUN_18052b510(&DAT_180d3fe90);
        }
        cVar7 = (*(code *)((ulonglong)uVar8 + DAT_180d20bd0))(lVar15);
        plVar17 = local_7f8;
        puVar30 = local_7f0;
        if (cVar7 != '\0') {
          lVar15 = *local_7e8[0];
          local_7d8._4_12_ = SUB1612((undefined1  [16])0x0,4);
          local_7d8._0_5_ = 0x66667562;
          uVar3 = *(undefined8 *)(local_810 + 0x480);
          pauVar21 = (undefined1 (*) [16])FUN_180425750(lVar15,local_7b8);
          local_7d8._0_16_ = *pauVar21;
          FUN_180433ef0(uVar3,&local_804,local_7d8);
          if (DAT_180d3fa08 == '\0') {
            uVar8 = DAT_180d3f5a0 + 0xe6632e3aU ^ 0x11bf48c;
          }
          else {
            uVar8 = FUN_18052b510(&DAT_180d3f5a0);
          }
          local_814 = *(char *)((ulonglong)uVar8 + lVar15);
          uVar19 = (ulonglong)(DAT_180d3fe88 + 0xe6632e3a) ^ 0x11bf48c;
          iVar26 = *(int *)(uVar19 + lVar15);
          if ((iVar26 == 0) && (fVar2 = *(float *)(uVar19 + lVar15), fVar2 != auVar35._0_4_)) {
            iVar26 = (int)(fVar2 * fVar36);
          }
          if (DAT_180d3fe80 == '\0') {
            uVar8 = DAT_180d3fa18 + 0xe6632e3aU ^ 0x11bf48c;
          }
          else {
            uVar8 = FUN_18052b510(&DAT_180d3fa18);
          }
          auVar33 = ZEXT464(*(uint *)((ulonglong)uVar8 + lVar15));
          auVar34 = ZEXT464(*(uint *)(((ulonglong)(DAT_180d3fa10 + 0xe6632e3a) ^ 0x11bf48c) + lVar15
                                     ));
          lVar15 = *(longlong *)(local_810 + 0x480);
          *(undefined1 *)(lVar15 + 0x60) = 1;
          local_800 = CONCAT44(local_800._4_4_,*(undefined4 *)(lVar15 + 0x30));
          FUN_1801bd800(lVar15,10,iVar26,0);
          FUN_1801bd8b0(lVar15,8,auVar33._0_8_,auVar35._0_8_);
          FUN_1801bd8b0(lVar15,6,auVar34._0_8_,auVar35._0_8_);
          iVar26 = local_804;
          if (local_804 != 0) {
            if (*(ulonglong *)(lVar15 + 0x68) < 4) {
              *(undefined8 *)(lVar15 + 0x68) = 4;
            }
            FUN_1801c5360(lVar15,-*(int *)(lVar15 + 0x30) & 3);
            FUN_1801bd800(lVar15,4,(*(int *)(lVar15 + 0x30) - iVar26) + 4,0);
          }
          cVar7 = local_814;
          if ((local_814 != '\0') || (*(char *)(lVar15 + 0x70) != '\0')) {
            if (*(longlong *)(lVar15 + 0x68) == 0) {
              *(undefined8 *)(lVar15 + 0x68) = 1;
            }
            FUN_1801c5410(lVar15,1);
            *(longlong *)(lVar15 + 0x40) = *(longlong *)(lVar15 + 0x40) + -1;
            *(int *)(lVar15 + 0x30) = *(int *)(lVar15 + 0x30) + 1;
            **(char **)(lVar15 + 0x40) = cVar7;
            uVar12 = *(undefined4 *)(lVar15 + 0x30);
            FUN_1801c5410(lVar15,8);
            puVar30 = *(undefined4 **)(lVar15 + 0x48);
            *puVar30 = uVar12;
            *(undefined2 *)(puVar30 + 1) = 0xc;
            *(undefined2 *)((longlong)puVar30 + 6) = uVar6;
            *(longlong *)(lVar15 + 0x48) = *(longlong *)(lVar15 + 0x48) + 8;
            *(int *)(lVar15 + 0x50) = *(int *)(lVar15 + 0x50) + 1;
            if (*(ushort *)(lVar15 + 0x54) < 0xc) {
              *(undefined2 *)(lVar15 + 0x54) = 0xc;
            }
          }
          uVar12 = FUN_1801be990(lVar15,local_800 & 0xffffffff);
          if (local_7f0 == local_768[0]) {
            local_7f0 = (undefined4 *)((longlong)local_7f0 - (longlong)puVar20);
            if ((longlong)local_7f0 >> 2 == 0x3fffffffffffffff) {
                    /* WARNING: Subroutine does not return */
              FUN_180183310();
            }
            local_800 = ((longlong)local_7f0 >> 2) + 1;
            local_768[0] = (undefined4 *)((longlong)local_768[0] - (longlong)puVar20 >> 2);
            if ((undefined4 *)(0x3fffffffffffffff - ((ulonglong)local_768[0] >> 1)) < local_768[0])
            {
              uVar24 = 0x3fffffffffffffff;
            }
            else {
              uVar19 = ((ulonglong)local_768[0] >> 1) + (longlong)local_768[0];
              uVar24 = local_800;
              if (local_800 <= uVar19) {
                uVar24 = uVar19;
              }
              if (0x3fffffffffffffff < uVar24) {
                    /* WARNING: Subroutine does not return */
                FUN_1801a22b0();
              }
            }
            local_7d8._0_8_ = uVar24 * 4;
            puVar22 = (undefined4 *)FUN_1801a22d0(uVar24 * 4);
            *(undefined4 *)(((ulonglong)local_7f0 & 0xfffffffffffffffc) + (longlong)puVar22) =
                 uVar12;
            FUN_1809bf2f0(puVar22,puVar20);
            if (puVar20 != (undefined4 *)0x0) {
              uVar19 = (longlong)local_768[0] * 4;
              if (0xfff < uVar19) {
                puVar30 = (undefined4 *)
                          ((longlong)puVar20 + (-8 - (longlong)*(undefined4 **)(puVar20 + -2)));
                if ((undefined4 *)0x1f < puVar30) goto LAB_18043b08c;
                uVar19 = uVar19 + 0x27;
                puVar20 = *(undefined4 **)(puVar20 + -2);
              }
              thunk_FUN_180895720(puVar20,uVar19);
            }
            local_7f0 = puVar22 + local_800;
            local_768[0] = (undefined4 *)(local_7d8._0_8_ + (longlong)puVar22);
            plVar17 = local_7f8;
            puVar30 = local_7f0;
            puVar20 = puVar22;
          }
          else {
            *local_7f0 = uVar12;
            local_7f0 = local_7f0 + 1;
            plVar17 = local_7f8;
            puVar30 = local_7f0;
          }
        }
      }
      local_7e8[0] = local_7e8[0] + 2;
    } while (local_7e8[0] != plVar17);
  }
  lVar15 = *(longlong *)(local_810 + 0x480);
  plVar17 = (longlong *)((longlong)puVar30 - (longlong)puVar20 >> 2);
  puVar22 = (undefined4 *)((longlong)&DAT_180d6e9e3 + 2);
  if (puVar20 != puVar30) {
    puVar22 = puVar20;
  }
  local_7d8._0_8_ = puVar22;
  local_7e8[0] = plVar17;
  FUN_1801c3f20(lVar15,plVar17,4);
  plVar29 = plVar17;
  if (plVar17 != (longlong *)0x0) {
    uVar3 = local_7d8._0_8_;
    do {
      plVar17 = (longlong *)((longlong)plVar17 + -1);
      iVar13 = *(int *)(uVar3 + (longlong)plVar17 * 4);
      if (*(ulonglong *)(lVar15 + 0x68) < 4) {
        *(undefined8 *)(lVar15 + 0x68) = 4;
      }
      FUN_1801c5360(lVar15,-*(int *)(lVar15 + 0x30) & 3);
      iVar26 = *(int *)(lVar15 + 0x30);
      if (*(ulonglong *)(lVar15 + 0x68) < 4) {
        *(undefined8 *)(lVar15 + 0x68) = 4;
      }
      FUN_1801c5360(lVar15,-iVar26 & 3);
      FUN_1801c5410(lVar15,4);
      piVar25 = (int *)(*(longlong *)(lVar15 + 0x40) + -4);
      *(int **)(lVar15 + 0x40) = piVar25;
      *(int *)(lVar15 + 0x30) = *(int *)(lVar15 + 0x30) + 4;
      *piVar25 = (iVar26 - iVar13) + 4;
      plVar29 = local_7e8[0];
      iVar13 = local_818;
    } while (plVar17 != (longlong *)0x0);
  }
  *(undefined1 *)(lVar15 + 0x60) = 0;
  if (*(ulonglong *)(lVar15 + 0x68) < 4) {
    *(undefined8 *)(lVar15 + 0x68) = 4;
  }
  FUN_1801c5360(lVar15,-*(int *)(lVar15 + 0x30) & 3);
  FUN_1801c5410(lVar15,4);
  *(longlong *)(lVar15 + 0x40) = *(longlong *)(lVar15 + 0x40) + -4;
  *(int *)(lVar15 + 0x30) = *(int *)(lVar15 + 0x30) + 4;
  **(undefined4 **)(lVar15 + 0x40) = (int)plVar29;
  uVar12 = *(undefined4 *)(lVar15 + 0x30);
  if (puVar20 != (undefined4 *)0x0) {
    puVar22 = puVar20;
    puVar28 = auStack_8a8;
    if (0xfff < (ulonglong)(((longlong)local_768[0] - (longlong)puVar20 >> 2) * 4)) {
      puVar22 = *(undefined4 **)(puVar20 + -2);
      puVar30 = (undefined4 *)((longlong)puVar20 + (-8 - (longlong)puVar22));
      puVar28 = auStack_8a8;
      if ((undefined4 *)0x1f < puVar30) {
LAB_18043b08c:
        puVar22 = puVar30;
        pcVar4 = (code *)swi(0x29);
        (*pcVar4)(5);
        puVar28 = auStack_8a0;
      }
    }
    *(undefined8 *)(puVar28 + -8) = 0x18043b09b;
    thunk_FUN_180895720(puVar22);
  }
  if (DAT_180d373f8 == '\0') {
    uVar8 = DAT_180d36f90 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    *(undefined8 *)(puVar28 + -8) = 0x18043b0c3;
    uVar8 = FUN_18052b510(&DAT_180d36f90);
  }
  plVar17 = *(longlong **)(puVar28 + 0x118);
  pcVar4 = *(code **)(*plVar17 + (ulonglong)(uVar8 >> 3) * 8);
  *(undefined8 *)(puVar28 + -8) = 0x18043b0db;
  uVar14 = (*pcVar4)(plVar17);
  *(undefined8 *)(puVar28 + -8) = 0x18043b0e5;
  uVar31 = FUN_180431740(plVar17);
  *(undefined8 *)(puVar28 + -8) = 0x18043b0f1;
  uVar32 = FUN_180431690(plVar17);
  *(undefined8 *)(puVar28 + 0xd0) = *(undefined8 *)(puVar28 + 0x120);
  *(undefined8 *)(puVar28 + 0xd8) = *(undefined8 *)(puVar28 + 0x128);
  lVar15 = *(longlong *)(puVar28 + 0x98);
  uVar3 = *(undefined8 *)(lVar15 + 0x480);
  *(undefined8 *)(puVar28 + -8) = 0x18043b139;
  puVar20 = (undefined4 *)FUN_180433ef0(uVar3,puVar28 + 0x138,puVar28 + 0xd0);
  *(int *)(puVar28 + 0x88) = iVar13;
  *(int *)(puVar28 + 0x80) = auVar40._0_4_;
  *(undefined4 *)(puVar28 + 0x78) = *(undefined4 *)(puVar28 + 0xa0);
  *(undefined4 *)(puVar28 + 0x70) = uVar11;
  *(undefined4 *)(puVar28 + 0x68) = uVar12;
  *(undefined4 *)(puVar28 + 0x60) = uVar9;
  *(int *)(puVar28 + 0x58) = auVar39._0_4_;
  *(int *)(puVar28 + 0x50) = auVar41._0_4_;
  *(undefined4 *)(puVar28 + 0x48) = uVar14;
  *(int *)(puVar28 + 0x40) = auVar42._0_4_;
  *(int *)(puVar28 + 0x38) = auVar38._0_4_;
  *(undefined4 *)(puVar28 + 0x30) = uVar31;
  *(undefined4 *)(puVar28 + 0x28) = uVar32;
  puVar28[0x20] = puVar28[0x95];
  uVar11 = *puVar20;
  uVar3 = *(undefined8 *)(lVar15 + 0x480);
  uVar5 = *(undefined8 *)(puVar28 + 0x130);
  *(undefined8 *)(puVar28 + -8) = 0x18043b1b8;
  FUN_180436a00(uVar5,uVar3,*(undefined4 *)(puVar28 + 0x110),uVar11);
  *(undefined8 *)(puVar28 + -8) = 0x18043b1cb;
  return uVar5;
}

