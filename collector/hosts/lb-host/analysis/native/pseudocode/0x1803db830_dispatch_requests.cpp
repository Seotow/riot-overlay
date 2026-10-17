// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1803db830; descriptive alias: dispatch_requests
// Evidence: ev_7a737f17896a0441f5f0e6ddec1f67beb7b32b7ef3f12545aedcd269189f0bd2
// Original Evidence: rea-request-dispatcher.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* WARNING: Type propagation algorithm not settling */

void FUN_1803db830(longlong param_1)

{
  undefined4 uVar1;
  undefined4 uVar2;
  bool bVar3;
  char *pcVar4;
  char cVar5;
  byte bVar6;
  undefined1 uVar7;
  undefined1 uVar8;
  undefined1 uVar9;
  undefined1 uVar10;
  undefined1 uVar11;
  undefined1 uVar12;
  undefined1 uVar13;
  char cVar14;
  byte bVar15;
  byte bVar16;
  byte bVar17;
  ushort uVar18;
  int iVar19;
  uint uVar20;
  undefined4 uVar21;
  undefined4 uVar22;
  longlong lVar23;
  ulonglong uVar24;
  char *pcVar25;
  undefined8 *puVar26;
  longlong lVar27;
  undefined1 (*pauVar28) [16];
  undefined4 *puVar29;
  uint *puVar30;
  char *pcVar31;
  undefined8 uVar32;
  undefined8 uVar33;
  longlong lVar34;
  undefined4 *puVar35;
  longlong *plVar36;
  undefined1 *puVar37;
  undefined8 uVar38;
  undefined **ppuVar39;
  uint uVar40;
  undefined *puVar41;
  undefined *puVar42;
  undefined8 uVar43;
  undefined1 auVar44 [64];
  undefined1 auVar45 [64];
  undefined1 extraout_var_01 [56];
  undefined1 extraout_var_02 [56];
  undefined1 extraout_var_03 [56];
  undefined1 auVar46 [64];
  undefined1 auVar47 [64];
  undefined1 extraout_var_06 [56];
  undefined1 extraout_var_07 [56];
  undefined1 auVar48 [64];
  undefined1 auVar49 [64];
  undefined1 auVar50 [64];
  undefined1 auVar51 [64];
  undefined1 auVar52 [64];
  undefined1 auVar53 [64];
  undefined1 auVar54 [64];
  undefined1 auVar55 [64];
  undefined1 auVar56 [64];
  undefined1 auVar57 [64];
  undefined1 auVar58 [64];
  undefined1 auVar59 [64];
  undefined1 auVar60 [64];
  undefined1 auVar61 [64];
  undefined1 auVar62 [64];
  undefined1 auVar63 [64];
  undefined1 auVar64 [64];
  undefined1 auVar65 [64];
  undefined1 in_ZMM6 [64];
  undefined1 auVar66 [64];
  undefined1 auVar67 [64];
  undefined1 in_ZMM7 [64];
  undefined1 auVar68 [64];
  undefined1 in_ZMM8 [64];
  undefined1 auVar69 [64];
  undefined1 in_ZMM9 [64];
  undefined1 auVar70 [64];
  undefined1 auVar71 [16];
  undefined1 auVar72 [64];
  undefined1 auStack_c18 [32];
  char *pcStack_bf8;
  undefined **ppuStack_bf0;
  undefined1 *puStack_be8;
  char *pcStack_be0;
  undefined4 uStack_bd8;
  undefined4 uStack_bd0;
  undefined **ppuStack_bc8;
  undefined **ppuStack_bc0;
  undefined4 uStack_bb8;
  undefined1 uStack_bb0;
  uint uStack_ba8;
  undefined1 *puStack_ba0;
  undefined1 *puStack_b98;
  undefined4 uStack_b90;
  undefined1 uStack_b88;
  undefined1 uStack_b87;
  undefined1 uStack_b86;
  undefined1 uStack_b85;
  undefined1 uStack_b84;
  undefined1 local_b78 [16];
  undefined4 uStack_b68;
  char local_b58;
  undefined1 uStack_b57;
  char cStack_b56;
  undefined1 uStack_b55;
  undefined1 uStack_b54;
  char cStack_b53;
  undefined1 uStack_b52;
  undefined1 uStack_b51;
  undefined1 uStack_b50;
  undefined1 uStack_b4f;
  undefined1 uStack_b4e;
  undefined1 uStack_b4d;
  undefined1 uStack_b4c;
  undefined1 uStack_b4b;
  undefined1 uStack_b4a;
  undefined1 uStack_b49;
  undefined1 uStack_b48;
  undefined1 uStack_b47;
  undefined1 uStack_b46;
  undefined1 uStack_b45;
  undefined1 uStack_b44;
  undefined1 uStack_b43;
  undefined1 uStack_b42;
  undefined1 uStack_b41;
  undefined1 uStack_b40;
  undefined1 uStack_b3f;
  undefined1 uStack_b3e;
  char local_b3d;
  uint uStack_b3c;
  ulonglong uStack_b38;
  uint local_b30;
  longlong local_b28;
  undefined1 auStack_b20 [4];
  uint uStack_b1c;
  undefined1 uStack_b18;
  undefined2 uStack_b17;
  undefined4 uStack_b14;
  undefined4 uStack_b10;
  undefined4 uStack_b0c;
  undefined4 uStack_b08;
  undefined4 uStack_b04;
  undefined4 uStack_b00;
  undefined4 uStack_afc;
  undefined4 uStack_af8;
  undefined4 uStack_af4;
  undefined4 uStack_af0;
  undefined4 uStack_aec;
  undefined4 uStack_ae8;
  undefined4 uStack_ae4;
  undefined4 uStack_ae0;
  undefined4 uStack_adc;
  int iStack_ad8;
  undefined4 uStack_ad4;
  undefined4 uStack_ad0;
  undefined4 uStack_acc;
  undefined4 uStack_ac8;
  undefined4 uStack_ac4;
  undefined4 uStack_ac0;
  undefined4 uStack_abc;
  undefined4 uStack_ab8;
  undefined4 uStack_ab4;
  undefined4 uStack_ab0;
  undefined4 uStack_aac;
  undefined4 auStack_aa8 [2];
  longlong local_aa0;
  undefined4 uStack_a98;
  undefined4 uStack_a94;
  undefined4 uStack_a90;
  undefined8 uStack_a88;
  undefined1 auStack_a80 [4];
  undefined1 auStack_a7c [4];
  undefined1 auStack_a78 [4];
  undefined1 auStack_a74 [12];
  undefined8 uStack_a68;
  undefined4 uStack_a60;
  undefined8 uStack_a58;
  undefined4 uStack_a50;
  undefined8 uStack_a48;
  undefined4 uStack_a40;
  undefined1 auStack_a38 [4];
  undefined1 auStack_a34 [4];
  undefined1 auStack_a30 [4];
  undefined1 auStack_a2c [4];
  undefined1 auStack_a28 [4];
  undefined1 auStack_a24 [4];
  undefined1 auStack_a20 [4];
  undefined1 auStack_a1c [4];
  undefined1 auStack_a18 [4];
  undefined1 auStack_a14 [4];
  undefined1 auStack_a10 [4];
  undefined1 auStack_a0c [4];
  undefined1 auStack_a08 [4];
  undefined1 auStack_a04 [4];
  undefined1 auStack_a00 [4];
  undefined1 auStack_9fc [4];
  undefined1 auStack_9f8 [4];
  undefined1 auStack_9f4 [4];
  undefined1 auStack_9f0 [4];
  undefined1 auStack_9ec [4];
  undefined8 uStack_9e8;
  undefined8 uStack_9e0;
  undefined8 uStack_9d8;
  char *pcStack_9d0;
  undefined8 uStack_9c8;
  undefined8 uStack_9c0;
  undefined1 auStack_9b8 [8];
  undefined1 auStack_9b0 [16];
  undefined1 auStack_9a0 [8];
  undefined1 auStack_998 [8];
  undefined1 auStack_990 [8];
  undefined1 auStack_988 [8];
  undefined1 auStack_980 [8];
  undefined1 auStack_978 [8];
  undefined1 auStack_970 [8];
  undefined1 auStack_968 [16];
  undefined1 auStack_958 [16];
  undefined1 auStack_948 [16];
  undefined1 auStack_938 [16];
  undefined1 auStack_928 [16];
  undefined1 auStack_918 [8];
  undefined1 auStack_910 [8];
  undefined1 auStack_908 [8];
  undefined1 auStack_900 [8];
  undefined1 auStack_8f8 [8];
  undefined1 auStack_8f0 [16];
  undefined1 auStack_8e0 [8];
  undefined1 auStack_8d8 [16];
  undefined1 auStack_8c8 [16];
  undefined1 auStack_8b8 [16];
  undefined1 auStack_8a8 [16];
  undefined1 auStack_898 [16];
  undefined1 auStack_888 [16];
  undefined1 auStack_878 [16];
  undefined1 auStack_868 [16];
  undefined1 auStack_858 [16];
  undefined1 auStack_848 [16];
  undefined1 auStack_838 [12];
  undefined1 auStack_82c [12];
  undefined1 auStack_820 [16];
  undefined1 auStack_810 [16];
  undefined1 auStack_800 [12];
  undefined1 auStack_7f4 [12];
  undefined1 auStack_7e8 [12];
  undefined1 auStack_7dc [12];
  undefined1 auStack_7d0 [16];
  undefined1 auStack_7c0 [16];
  undefined1 auStack_7b0 [16];
  undefined1 auStack_7a0 [16];
  undefined1 auStack_790 [16];
  undefined1 auStack_780 [16];
  undefined1 auStack_770 [16];
  undefined1 auStack_760 [16];
  undefined1 auStack_750 [16];
  undefined1 auStack_740 [16];
  undefined1 auStack_730 [16];
  undefined1 auStack_720 [16];
  undefined1 auStack_710 [16];
  undefined1 auStack_700 [16];
  undefined1 auStack_6f0 [16];
  undefined1 auStack_6e0 [16];
  undefined1 auStack_6d0 [16];
  undefined1 auStack_6c0 [16];
  undefined1 auStack_6b0 [16];
  undefined1 auStack_6a0 [16];
  undefined1 auStack_690 [16];
  undefined1 auStack_680 [16];
  char acStack_670 [8];
  undefined1 auStack_668 [16];
  undefined1 *puStack_658;
  undefined1 auStack_648 [8];
  longlong alStack_640 [2];
  undefined1 auStack_630 [8];
  undefined1 auStack_628 [8];
  undefined4 uStack_620;
  undefined4 uStack_61c;
  undefined1 uStack_618;
  undefined4 uStack_614;
  undefined1 auStack_610 [24];
  undefined1 auStack_5f8 [24];
  undefined1 uStack_5e0;
  char *local_5d8;
  undefined1 local_5d0 [16];
  char cStack_5c0;
  undefined1 uStack_5bf;
  undefined1 auStack_5be [6];
  undefined8 uStack_5b8;
  longlong lStack_5b0;
  undefined8 uStack_5a8;
  undefined8 uStack_5a0;
  undefined *puStack_578;
  undefined *puStack_570;
  undefined2 auStack_558 [2];
  undefined1 auStack_554 [4];
  undefined *apuStack_550 [3];
  undefined1 auStack_538 [16];
  undefined8 uStack_528;
  undefined1 uStack_500;
  undefined1 uStack_4ff;
  undefined1 uStack_4fe;
  undefined1 uStack_4fd;
  undefined1 uStack_4fc;
  undefined1 uStack_4fb;
  undefined1 uStack_4fa;
  undefined1 uStack_4f9;
  longlong lStack_4f8;
  undefined8 auStack_4f0 [3];
  undefined1 uStack_4d8;
  undefined1 uStack_4d7;
  undefined4 uStack_4d4;
  undefined4 uStack_4d0;
  undefined4 uStack_4cc;
  undefined4 uStack_4c8;
  undefined4 uStack_4c4;
  undefined1 uStack_4c0;
  undefined4 uStack_4bc;
  uint uStack_4b8;
  undefined4 uStack_4b4;
  undefined4 uStack_4b0;
  undefined4 uStack_4ac;
  undefined4 uStack_4a8;
  uint uStack_4a4;
  undefined4 uStack_4a0;
  undefined8 uStack_498;
  undefined1 auStack_490 [16];
  undefined1 auStack_480 [8];
  undefined1 auStack_478 [16];
  undefined1 auStack_468 [8];
  undefined1 auStack_460 [24];
  undefined4 uStack_448;
  undefined4 uStack_444;
  undefined4 uStack_440;
  undefined4 uStack_43c;
  undefined8 uStack_438;
  undefined1 uStack_430;
  undefined4 uStack_42f;
  undefined2 uStack_42b;
  undefined1 uStack_429;
  undefined1 local_428 [16];
  undefined1 auStack_418 [8];
  undefined1 auStack_410 [8];
  undefined1 auStack_408 [8];
  undefined1 auStack_400 [8];
  undefined1 auStack_3f8 [8];
  undefined8 uStack_3f0;
  undefined1 auStack_3e8 [8];
  undefined1 auStack_3e0 [8];
  undefined1 auStack_3d8 [8];
  undefined1 auStack_3d0 [8];
  undefined1 auStack_3c8 [8];
  undefined1 auStack_3c0 [8];
  undefined1 auStack_3b8 [8];
  undefined1 auStack_3b0 [8];
  undefined1 auStack_3a8 [8];
  undefined1 auStack_3a0 [8];
  undefined1 auStack_398 [8];
  undefined1 auStack_390 [8];
  undefined1 auStack_388 [8];
  undefined1 auStack_380 [8];
  undefined1 auStack_378 [8];
  undefined1 auStack_370 [8];
  undefined1 auStack_368 [8];
  undefined1 auStack_360 [8];
  undefined1 auStack_358 [8];
  undefined1 auStack_350 [8];
  undefined1 auStack_348 [8];
  undefined1 auStack_340 [16];
  undefined1 auStack_330 [8];
  undefined1 auStack_328 [8];
  undefined1 auStack_320 [8];
  undefined1 auStack_318 [8];
  undefined1 auStack_310 [4];
  undefined1 auStack_30c [4];
  undefined4 uStack_308;
  undefined1 auStack_304 [4];
  undefined4 uStack_300;
  undefined4 uStack_2fc;
  undefined4 uStack_2f8;
  undefined4 uStack_2f4;
  undefined4 uStack_2f0;
  undefined1 auStack_2ec [4];
  undefined1 auStack_2e8 [4];
  undefined1 auStack_2e4 [4];
  undefined1 auStack_2e0 [4];
  undefined1 auStack_2dc [4];
  undefined4 uStack_2d8;
  undefined4 uStack_2d4;
  undefined4 uStack_2d0;
  undefined4 uStack_2cc;
  undefined4 auStack_2c8 [2];
  undefined1 auStack_2c0 [16];
  undefined1 auStack_2b0 [16];
  undefined1 auStack_2a0 [16];
  undefined1 auStack_290 [4];
  undefined4 uStack_28c;
  undefined4 uStack_288;
  undefined4 uStack_284;
  undefined4 uStack_280;
  undefined1 auStack_27c [4];
  undefined1 auStack_278 [4];
  undefined1 auStack_274 [4];
  undefined1 auStack_270 [16];
  undefined1 auStack_260 [16];
  undefined1 auStack_250 [16];
  undefined1 auStack_240 [16];
  undefined1 auStack_230 [16];
  undefined1 auStack_220 [8];
  undefined1 auStack_218 [8];
  undefined1 auStack_210 [8];
  undefined1 auStack_208 [8];
  undefined1 local_200 [16];
  undefined1 local_1f0 [8];
  longlong local_1e8;
  char local_1e0;
  undefined1 auStack_1d8 [8];
  undefined8 uStack_1d0;
  undefined8 uStack_1c8;
  undefined8 uStack_1c0;
  undefined1 auStack_1b8 [8];
  undefined1 auStack_1b0 [8];
  undefined8 uStack_1a8;
  undefined8 uStack_1a0;
  undefined1 auStack_198 [8];
  undefined1 auStack_190 [8];
  undefined1 auStack_188 [8];
  undefined1 auStack_180 [8];
  undefined1 auStack_178 [8];
  undefined1 auStack_170 [8];
  undefined1 auStack_168 [8];
  undefined1 auStack_160 [8];
  undefined1 auStack_158 [8];
  undefined1 auStack_150 [8];
  undefined1 auStack_148 [8];
  undefined1 auStack_140 [8];
  undefined1 auStack_138 [8];
  undefined1 auStack_130 [8];
  undefined1 auStack_128 [8];
  undefined1 auStack_120 [8];
  undefined1 auStack_118 [8];
  undefined1 auStack_110 [8];
  undefined1 auStack_108 [8];
  undefined1 auStack_100 [8];
  undefined1 auStack_f8 [8];
  undefined1 auStack_f0 [16];
  undefined1 auStack_e0 [16];
  undefined8 uStack_d0;
  undefined4 uStack_c8;
  undefined1 auStack_c0 [8];
  undefined1 auStack_b8 [8];
  undefined8 uStack_b0;
  undefined4 uStack_a8;
  undefined1 auStack_a0 [16];
  undefined1 auStack_90 [16];
  ulonglong local_80;
  undefined1 local_68 [16];
  undefined1 local_58 [16];
  undefined1 local_48 [16];
  undefined1 local_38 [16];
  undefined1 extraout_var [56];
  undefined1 extraout_var_00 [56];
  undefined1 extraout_var_04 [56];
  undefined1 extraout_var_05 [56];
  undefined1 extraout_var_08 [56];
  undefined1 extraout_var_09 [56];
  undefined1 extraout_var_10 [56];
  undefined1 extraout_var_11 [56];
  undefined1 extraout_var_12 [56];
  undefined1 extraout_var_13 [56];
  undefined1 extraout_var_14 [56];
  undefined1 extraout_var_15 [56];
  undefined1 extraout_var_16 [56];
  undefined1 extraout_var_17 [56];
  undefined1 extraout_var_18 [56];
  undefined1 extraout_var_19 [56];
  undefined1 extraout_var_20 [56];
  undefined1 extraout_var_21 [56];
  undefined1 extraout_var_22 [56];
  undefined1 extraout_var_23 [56];
  undefined1 extraout_var_24 [56];
  undefined1 extraout_var_25 [56];
  
  local_38 = in_ZMM6._0_16_;
  local_48 = in_ZMM7._0_16_;
  local_58 = in_ZMM8._0_16_;
  local_68 = in_ZMM9._0_16_;
  local_80 = DAT_180d06cc0 ^ (ulonglong)auStack_c18;
  local_b30 = 0;
  auVar72 = ZEXT1264(ZEXT812(0));
  uVar40 = 0;
  local_b28 = param_1;
  local_aa0 = param_1;
  do {
    while( true ) {
      while( true ) {
        pcVar25 = (char *)0x0;
        FUN_1803e9d40(param_1,local_200);
        if (local_1e0 == '\x02') {
          FUN_1803e3930(local_200);
          return;
        }
        lVar23 = FUN_1803e84a0(local_200);
        if (lVar23 == 0) break;
        FUN_1803e3d10(param_1,lVar23);
        FUN_1803e3930(local_200);
      }
      if (local_1e0 != '\0') {
                    /* WARNING: Subroutine does not return */
        FUN_1801c6b00();
      }
      local_5d0 = (undefined1  [16])0x0;
      FUN_1803fa2d0(local_5d0,local_200);
      if (local_5d0._0_8_ != 0) break;
LAB_1803db98f:
      FUN_1801be880(local_5d0);
      FUN_1803e3930(local_200);
    }
    local_428 = (undefined1  [16])0x0;
    FUN_1803be5d0(local_428,local_1f0);
    lVar23 = local_1e8;
    local_428._8_8_ = local_1e8;
    uVar32 = local_5d0._0_8_;
    FUN_1801bebe0(local_5d0._0_8_ + 0x68,0xffffffffffffffff,4);
    FUN_1801bebe0(uVar32 + 0x60,-lVar23,4);
    cVar5 = FUN_1803bdd40(local_5d0._0_8_);
    if (cVar5 != '\0') {
LAB_1803dba95:
      if (local_428._0_8_ != 0) {
        thunk_FUN_180895720();
      }
      goto LAB_1803db98f;
    }
    iVar19 = FUN_1801be960(local_5d0._0_8_ + 0x38,2);
    if (iVar19 == 2) goto LAB_1803dba95;
    cVar5 = FUN_1803d6e20(local_428);
    if (cVar5 == '\0') {
      local_b78._0_8_ = local_428._8_8_;
      FUN_1803ec190(&DAT_180d6ea00,local_b78);
      cVar5 = (**(code **)(*(longlong *)local_5d0._0_8_ + 0x20))();
      if (cVar5 == '\0') {
        FUN_1803da020(local_5d0._0_8_,0);
      }
      else {
LAB_1803dba87:
        FUN_1803bdd10(local_5d0._0_8_);
      }
      goto LAB_1803dba95;
    }
    pcVar31 = pcVar25;
    if ((uint *)local_428._0_8_ != (uint *)0x0) {
      pcVar31 = (char *)((ulonglong)*(uint *)local_428._0_8_ + local_428._0_8_);
    }
    uVar18 = FUN_1801c6d70(pcVar31,8);
    local_5d8 = pcVar25;
    if (uVar18 != 0) {
      local_5d8 = *(char **)(pcVar31 + uVar18);
    }
    cVar5 = (**(code **)(*(longlong *)local_5d0._0_8_ + 0x20))();
    if (cVar5 != '\0') {
      iVar19 = FUN_1801be960(local_5d0._0_8_ + 0x38,2);
      if ((iVar19 != 1) &&
         ((uVar18 = FUN_1801c6d70(pcVar31,4), uVar18 == 0 ||
          ((pcVar31[uVar18] != '\x10' && (1 < (byte)(pcVar31[uVar18] - 5U))))))) {
        uVar18 = FUN_1801c6d70(pcVar31,4);
        if (uVar18 == 0) {
          local_b58 = '\0';
        }
        else {
          local_b58 = pcVar31[uVar18];
        }
        FUN_1803ec540(&DAT_180d6ea00,&local_b58);
        goto LAB_1803dba87;
      }
    }
    uVar18 = FUN_1801c6d70(pcVar31,4);
    pcVar4 = local_5d8;
    if (uVar18 == 0) {
      cVar5 = '\0';
    }
    else {
      cVar5 = pcVar31[uVar18];
    }
    switch(cVar5) {
    case '\x01':
      uVar32 = func_0x0001803d0430(pcVar31);
      uVar21 = FUN_1801cc4b0(uVar32);
      uStack_af4 = func_0x00018036d290(uVar21);
      func_0x0001803e84c0(&DAT_180d6ea00,&uStack_af4);
      pcVar31 = (char *)FUN_1801b2640(uVar32);
      FUN_1801cc4b0(uVar32);
      pcVar25 = local_5d8;
      uVar32 = FUN_1801be340(local_5d0);
      pcStack_bf8 = pcVar31;
      FUN_1803da5d0(param_1,uVar32,pcVar25);
      break;
    case '\x02':
      uVar32 = func_0x0001803d0480(pcVar31);
      FUN_18019fc10(auStack_90,0x10);
      FUN_18019fbb0(auStack_90,param_1 + 0x1a8);
      FUN_1801b6400(auStack_348,8);
      uStack_af0 = FUN_1801cc4b0(uVar32);
      func_0x0001803e9990(param_1 + 0x1f8,auStack_348,&uStack_af0);
      uVar33 = func_0x0001803e9b00(param_1 + 0x1f8,auStack_998);
      cVar5 = func_0x0001803e98f0(auStack_348,uVar33);
      if (cVar5 == '\0') {
        lVar23 = func_0x0001803e9900(auStack_348);
        cVar5 = FUN_1801d9760(lVar23 + 8);
        if (cVar5 == '\0') goto code_r0x0001803dbd3a;
        lVar23 = func_0x0001803e9900(auStack_348);
        uVar33 = FUN_1801be340(lVar23 + 8);
        uVar32 = FUN_1801b2640(uVar32);
        uVar38 = FUN_1801be340(local_5d0);
        FUN_180404a80(uVar33,uVar38,uVar32);
      }
      else {
code_r0x0001803dbd3a:
        uVar21 = FUN_1801cc4b0(uVar32);
        uStack_aec = func_0x00018036d290(uVar21);
        func_0x0001803e84d0(&DAT_180d6ea00,&uStack_aec);
      }
      func_0x00018019fb60(auStack_90);
      break;
    case '\x03':
      func_0x0001803e84e0(&DAT_180d6ea00);
      uVar32 = func_0x0001803d04d0(pcVar31);
      FUN_1801cc4b0(uVar32);
      pcVar25 = local_5d8;
      uVar32 = FUN_1801be340(local_5d0);
      FUN_1803db0d0(param_1,uVar32,pcVar25);
      break;
    case '\x04':
      uVar32 = func_0x0001803d0520(pcVar31);
      uVar20 = FUN_1801cc4b0(uVar32);
      pcVar25 = local_5d8;
      if (0x539 < (int)uVar20) goto code_r0x0001803dc380;
      if (uVar20 == 0x539) break;
      if (99 < uVar20) {
code_r0x0001803dc380:
        uStack_adc = func_0x00018036d290(uVar20);
        func_0x0001803e8ac0(&DAT_180d6ea00,&uStack_adc);
        break;
      }
      switch(uVar20) {
      case 0:
        FUN_18019fc10(auStack_f0,0x10);
        uStack_ae0 = 0x40;
        FUN_1801e5bf0(auStack_f0,&uStack_ae0);
        uVar32 = FUN_1801be340(auStack_f0);
        FUN_180441340(uVar32);
        uVar32 = FUN_1801be340(local_5d0);
        uVar33 = func_0x0001801dbd60(auStack_948,auStack_f0);
        FUN_1803bd970(uVar32,uVar33,0);
        FUN_1801be880(auStack_f0);
        break;
      case 1:
        func_0x0001803e8510(&DAT_180d6ea00);
        uVar32 = func_0x0001803e35b0(&uStack_5b8,local_5d0,&local_5d8);
        local_b78._0_8_ = uVar32;
        uVar33 = func_0x0001803e39d0(auStack_538,uVar32);
        FUN_1803e35e0(auStack_938,uVar33,0x14);
        local_b30 = uVar40 | 0x20;
        FUN_1802e3fe0(uVar32);
        func_0x0001803c39c0(auStack_938);
        break;
      case 2:
        lVar23 = FUN_1801be340(local_5d0);
        iVar19 = FUN_1801be960(lVar23 + 0x134,2);
        if (iVar19 == 0) {
          func_0x0001803e84f0();
          goto code_r0x0001803dbfe8;
        }
        func_0x0001803e8500(&DAT_180d6ea00);
        FUN_1803d94f0(param_1);
        break;
      case 3:
        lVar23 = FUN_1801be340(local_5d0);
        cVar5 = FUN_180393770(lVar23 + 0x130,2);
        if (cVar5 != '\0') {
          func_0x0001801ada20(&DAT_180d6e971,1);
        }
        break;
      case 4:
        lVar23 = FUN_1801be340(local_5d0);
        cVar5 = FUN_180393770(lVar23 + 0x130,2);
        if (cVar5 != '\0') {
          func_0x0001801ada20(&DAT_180d6e971,0);
        }
        break;
      case 5:
        FUN_1801b2640(uVar32);
        pcVar25 = local_5d8;
        uVar32 = FUN_1801be340(local_5d0);
        FUN_1803e44d0(param_1,uVar32,pcVar25);
        break;
      case 6:
        lVar23 = FUN_1801be340(local_5d0);
        cVar5 = FUN_180393770(lVar23 + 0x130,0);
        if (cVar5 != '\0') {
          uVar32 = FUN_180420df0();
          uVar32 = FUN_1804212b0(uVar32);
          FUN_180420c60(uVar32,1);
          goto code_r0x0001803dc592;
        }
        goto code_r0x0001803dbfe8;
      case 7:
        lVar23 = FUN_1801be340(local_5d0);
        cVar5 = FUN_180393770(lVar23 + 0x130,0);
        if (cVar5 != '\0') {
          uVar32 = FUN_180420df0();
          uVar32 = FUN_1804212b0(uVar32);
          FUN_180420c60(uVar32,0);
          goto code_r0x0001803dc592;
        }
        goto code_r0x0001803dbfe8;
      case 8:
        FUN_1801b2640(uVar32);
        pcVar25 = local_5d8;
        uVar32 = FUN_1801be340(local_5d0);
        FUN_1803e41f0(param_1,uVar32,pcVar25);
        break;
      case 9:
        uVar32 = FUN_1801be340(local_5d0);
        FUN_1803e54b0(param_1,uVar32,pcVar25);
        break;
      case 10:
        uVar32 = FUN_1801be340(local_5d0);
        FUN_1803e5af0(param_1,uVar32,pcVar25);
        break;
      case 0xb:
        uVar32 = FUN_1801be340(local_5d0);
        FUN_1803e5ef0(param_1,uVar32,pcVar25);
        break;
      case 0xc:
        lVar23 = FUN_1801b2640(uVar32);
        if (lVar23 == 0) goto code_r0x0001803dbfe8;
        FUN_1801b2640(uVar32);
        pcVar25 = local_5d8;
        uVar32 = FUN_1801be340(local_5d0);
        FUN_1803e4660(param_1,uVar32,pcVar25);
        break;
      case 0xd:
      case 0xe:
        func_0x0001801ada20(&DAT_180d6e970,
                            CONCAT71((int7)((ulonglong)
                                            *(uint *)(&UNK_1803e347c +
                                                     (ulonglong)(byte)(&UNK_1803e34c0)[(int)uVar20]
                                                     * 4) + 0x180000000 >> 8),uVar20 == 0xd));
        goto code_r0x0001803dc592;
      case 0xf:
        uVar32 = FUN_1801be340(local_5d0);
        cVar5 = func_0x0001803bdd00(uVar32);
        if (cVar5 != '\0') {
          plVar36 = (longlong *)FUN_1801be340(local_5d0);
          cVar5 = (**(code **)(*plVar36 + 0x28))(plVar36);
          if (cVar5 == '\0') {
            lVar23 = FUN_1801be340(local_5d0);
            iVar19 = FUN_1801be960(lVar23 + 0x134,2);
            if ((iVar19 != 0) && (cVar5 = func_0x0001801a1d90(&DAT_180d11eb0), cVar5 == '\0')) {
              FUN_18019fc10(auStack_2c0,0x10);
              uStack_ae8 = 0x100;
              FUN_1801e5bf0(auStack_2c0,&uStack_ae8);
              uVar32 = FUN_1801be340(auStack_2c0);
              puVar29 = (undefined4 *)FUN_1801bd7d0(uVar32,auStack_a30,&DAT_180d11eb0);
              uVar21 = *puVar29;
              uVar32 = FUN_1801be340(auStack_2c0);
              FUN_1803cbd30(auStack_27c,uVar32,uVar21);
              uVar32 = FUN_1801be340(auStack_2c0);
              pcVar25 = local_5d8;
              func_0x0001803ea140(auStack_27c,auStack_a2c);
              uVar33 = FUN_1801be340(auStack_2c0);
              pcStack_bf8 = pcVar25;
              puVar29 = (undefined4 *)FUN_1801b3ec0(auStack_a24,uVar33,0x21);
              func_0x0001801be350(uVar32,*puVar29,0);
              uVar32 = FUN_1801be340(local_5d0);
              uVar33 = func_0x0001801dbd60(auStack_928,auStack_2c0);
              FUN_1803bd970(uVar32,uVar33,0);
              FUN_1801be880(auStack_2c0);
              break;
            }
          }
        }
        goto code_r0x0001803dbfe8;
      default:
        goto code_r0x0001803dc380;
      case 99:
        FUN_1801b2640(uVar32);
        pcVar25 = local_5d8;
        uVar32 = FUN_1801be340(local_5d0);
        FUN_1803e5350(param_1,uVar32,pcVar25);
      }
      break;
    case '\x05':
      uVar32 = FUN_1801be340(local_5d0);
      FUN_1803e6330(param_1,uVar32,pcVar4);
      break;
    case '\x06':
      uVar32 = func_0x0001803d5ab0(pcVar31);
      lVar23 = FUN_1801b2410(uVar32);
      if ((lVar23 == 0) || (lVar23 = FUN_1801b2170(uVar32), lVar23 == 0)) {
        func_0x0001803e8f90(&DAT_180d6ea00);
        lVar23 = FUN_1801be340(local_5d0);
        func_0x0001803948f0(lVar23 + 0x138);
        plVar36 = (longlong *)FUN_1801be340(local_5d0);
        cVar5 = (**(code **)(*plVar36 + 0x20))(plVar36);
        if (cVar5 == '\0') goto code_r0x0001803dc89c;
        uVar32 = FUN_1801be340(local_5d0);
        FUN_1803bdd10(uVar32);
      }
      else {
        pcVar31 = (char *)FUN_1801b2170(uVar32);
        uVar33 = FUN_1801b2410(uVar32);
        uVar33 = func_0x0001803ea180(uVar33);
        uVar32 = FUN_1801b2410(uVar32);
        uVar21 = FUN_1801be960(uVar32);
        pauVar28 = (undefined1 (*) [16])func_0x0001801c7890(auStack_780,uVar33,uVar21);
        pcVar25 = local_5d8;
        local_b78 = *pauVar28;
        uVar32 = FUN_1801be340(local_5d0);
        pcStack_bf8 = pcVar31;
        FUN_1803e6780(param_1,uVar32,pcVar25);
      }
      break;
    case '\a':
      lVar23 = FUN_1801be340(local_5d0);
      cVar5 = FUN_180393770(lVar23 + 0x130,5);
      if ((cVar5 == '\0') || (cVar5 = func_0x0001801a8a40(&DAT_180d6e440), cVar5 == '\0'))
      goto code_r0x0001803dbfe8;
      uVar32 = func_0x0001801a8a50(&DAT_180d6e440);
      cVar5 = func_0x0001801c6d90(uVar32);
      if (cVar5 == '\0') goto code_r0x0001803dbfe8;
      uVar32 = func_0x0001801a8a50(&DAT_180d6e440);
      uVar32 = func_0x0001801fe720(uVar32);
      local_b78._0_8_ = uVar32;
      uVar33 = func_0x0001803d5b00(pcVar31);
      uVar7 = FUN_1801b2610(uVar33);
      switch(uVar7) {
      case 1:
        uVar33 = func_0x0001803d0430(uVar33);
        uStack_b55 = FUN_1803ce340(uVar33);
        func_0x0001803e8dc0(&DAT_180d6ea00,&uStack_b55);
        uVar7 = FUN_1803ce340(uVar33);
        FUN_1803218c0(uVar32,uVar7);
        break;
      case 2:
        uVar33 = func_0x0001803d0480(uVar33);
        uVar7 = FUN_1801b2610(uVar33);
        uStack_b54 = func_0x0001801be360(uVar7);
        func_0x0001803e8dd0(&DAT_180d6ea00,&uStack_b54);
        uVar7 = FUN_1801b2610(uVar33);
        func_0x0001803219e0(uVar32,uVar7);
        break;
      case 3:
        uVar33 = func_0x0001803d04d0(uVar33);
        uVar38 = FUN_1801b2130(uVar33);
        bVar6 = func_0x0001801b1a50(uVar38);
        uVar38 = FUN_1801b2130(uVar33);
        bVar15 = FUN_1801b1a60(uVar38);
        uVar38 = FUN_1801b2130(uVar33);
        bVar16 = func_0x0001801b1a70(uVar38);
        uVar38 = FUN_1801b2130(uVar33);
        bVar17 = func_0x0001801b1a80(uVar38);
        uVar38 = FUN_1801b2130(uVar33);
        cStack_b53 = func_0x0001801b1a80(uVar38);
        uVar38 = FUN_1801b2130(uVar33);
        uStack_b52 = func_0x0001801b1a70(uVar38);
        uVar38 = FUN_1801b2130(uVar33);
        uStack_b51 = FUN_1801b1a60(uVar38);
        uVar33 = FUN_1801b2130(uVar33);
        uStack_b50 = func_0x0001801b1a50(uVar33);
        pcStack_bf8 = &cStack_b53;
        func_0x0001803e8de0(&DAT_180d6ea00,&uStack_b50,&uStack_b51);
        func_0x000180321940(uVar32,(uint)bVar6 << 0x18 | (uint)bVar15 << 0x10 | (uint)bVar16 << 8 |
                                   (uint)bVar17);
        break;
      case 4:
        uVar33 = func_0x0001803d0520(uVar33);
        uStack_ac4 = func_0x0001803ce370(uVar33);
        func_0x0001803e8df0(&DAT_180d6ea00,&uStack_ac4);
        func_0x0001803ce370(uVar33);
        func_0x000180321950(uVar32);
        break;
      case 5:
        FUN_1803220b0(uVar32);
        func_0x0001803e8e30(&DAT_180d6ea00);
        break;
      case 6:
        FUN_180322230(uVar32);
        func_0x0001803e8e40(&DAT_180d6ea00);
        break;
      case 7:
        FUN_1803223a0(uVar32);
        func_0x0001803e8e50(&DAT_180d6ea00);
        break;
      case 8:
        uVar33 = func_0x0001803d0570(uVar33);
        cVar5 = func_0x0001803ce5c0(uVar33);
        uVar7 = FUN_1801b2610(uVar33);
        uStack_b4c = func_0x0001801be360(uVar7);
        pcStack_9d0 = "end";
        if (cVar5 != '\0') {
          pcStack_9d0 = "start";
        }
        func_0x0001803e8e60(&DAT_180d6ea00,&pcStack_9d0,&uStack_b4c);
        uVar7 = FUN_1801b2610(uVar33);
        if (cVar5 == '\0') {
          func_0x000180321a00(uVar32,uVar7);
        }
        else {
          func_0x0001803219f0();
        }
        break;
      case 9:
        func_0x0001803e8ea0(&DAT_180d6ea00);
        FUN_18019fc10(auStack_e0,0x10);
        uStack_b14 = 0x5c;
        FUN_1801e5bf0(auStack_e0,&uStack_b14);
        pcVar25 = local_5d8;
        uVar33 = FUN_1801be340(auStack_e0);
        FUN_1803234a0(uVar32,uVar33,pcVar25);
        uVar32 = FUN_1801be340(local_5d0);
        uVar33 = func_0x0001801dbd60(auStack_8a8,auStack_e0);
        FUN_1803bd970(uVar32,uVar33,0);
        FUN_1801be880(auStack_e0);
        goto code_r0x0001803e3390;
      case 10:
        uVar33 = func_0x0001803d05c0(uVar33);
        uVar7 = FUN_1801b2610(uVar33);
        uStack_b4b = func_0x0001801be360(uVar7);
        func_0x0001803e8e70(&DAT_180d6ea00,&uStack_b4b);
        uVar7 = FUN_1801b2610(uVar33);
        func_0x000180321a10(uVar32,uVar7);
        break;
      case 0xb:
        uVar33 = func_0x0001803d0610(uVar33);
        auStack_aa8[0] = func_0x0001803ce370(uVar33);
        func_0x0001803e8e80(&DAT_180d6ea00,auStack_aa8);
        func_0x0001803ce370(uVar33);
        func_0x000180321a20(uVar32);
        break;
      case 0xc:
        uVar33 = func_0x0001803d0660(uVar33);
        uVar7 = FUN_1801b2610(uVar33);
        uStack_b4a = func_0x0001801be360(uVar7);
        func_0x0001803e8e90(&DAT_180d6ea00,&uStack_b4a);
        uVar7 = FUN_1801b2610(uVar33);
        func_0x000180321a40(uVar32,uVar7);
        break;
      case 0xd:
        uVar32 = func_0x0001803d06b0(uVar33);
        auStack_668._0_8_ = uVar32;
        uVar33 = FUN_1801b2410(uVar32);
        FUN_1801c6b40(uVar33,&uStack_5b8);
        uVar33 = FUN_1801b2170(uVar32);
        bVar6 = func_0x0001801b1a50(uVar33);
        uVar33 = FUN_1801b2170(uVar32);
        bVar15 = FUN_1801b1a60(uVar33);
        uVar33 = FUN_1801b2170(uVar32);
        bVar16 = func_0x0001801b1a70(uVar33);
        uVar33 = FUN_1801b2170(uVar32);
        bVar17 = func_0x0001801b1a80(uVar33);
        uStack_b38 = CONCAT44(uStack_b38._4_4_,
                              (uint)bVar6 << 0x18 | (uint)bVar15 << 0x10 | (uint)bVar16 << 8 |
                              (uint)bVar17);
        FUN_1801a6370(&puStack_578,0x18);
        func_0x0001801a8e50(&puStack_578);
        lVar23 = FUN_1801b1ac0(uVar32);
        if (lVar23 != 0) {
          uVar33 = FUN_1801b1ac0(uVar32);
          func_0x00018023a700(uVar33,auStack_370);
          func_0x0001803ea1b0(uVar33,auStack_158);
          cVar5 = func_0x0001803e92a0(auStack_370,auStack_158);
          while (cVar5 != '\0') {
            uVar33 = FUN_1801be340(auStack_370);
            auVar51._0_8_ = func_0x0001801b1a00(uVar33);
            auVar51._8_56_ = extraout_var_11;
            auVar69 = ZEXT1664(auVar51._0_16_);
            auVar52._0_8_ = func_0x0001801b1a10(uVar33);
            auVar52._8_56_ = extraout_var_12;
            auVar66 = ZEXT1664(auVar52._0_16_);
            uVar33 = func_0x0001801b1a20(uVar33);
            uVar33 = func_0x0001801b19e0(auStack_800,auVar69._0_8_,auVar66._0_8_,uVar33);
            FUN_1802a3900(&puStack_578,uVar33);
            func_0x0001803e9290(auStack_370);
            cVar5 = func_0x0001803e92a0(auStack_370,auStack_158);
          }
        }
        FUN_1801a6370(apuStack_550,0x18);
        func_0x0001801a8e50(apuStack_550);
        lVar23 = FUN_1801b27f0(uVar32);
        if (lVar23 != 0) {
          uVar33 = FUN_1801b27f0(uVar32);
          func_0x00018023a700(uVar33,auStack_378);
          FUN_1801be970(uVar33,auStack_150);
          cVar5 = func_0x0001803e92a0(auStack_378,auStack_150);
          while (cVar5 != '\0') {
            uStack_288 = func_0x00018023aba0(auStack_378);
            FUN_1802a4530(apuStack_550,&uStack_288);
            func_0x00018023ab90(auStack_378);
            cVar5 = func_0x0001803e92a0(auStack_378,auStack_150);
          }
        }
        FUN_1801a6370(auStack_538,0x18);
        func_0x0001801a8e50(auStack_538);
        lVar23 = func_0x0001803ce810(uVar32);
        if (lVar23 != 0) {
          uVar33 = func_0x0001803ce810(uVar32);
          func_0x00018023a700(uVar33,auStack_390);
          FUN_1801be970(uVar33,auStack_148);
          cVar5 = func_0x0001803e92a0(auStack_390,auStack_148);
          while (cVar5 != '\0') {
            uStack_28c = func_0x00018023aba0(auStack_390);
            FUN_1802a4530(auStack_538,&uStack_28c);
            func_0x00018023ab90(auStack_390);
            cVar5 = func_0x0001803e92a0(auStack_390,auStack_148);
          }
        }
        uStack_b3c = 0;
        lVar23 = func_0x0001803ce7a0(uVar32);
        if (lVar23 != 0) {
          uVar33 = func_0x0001803ce7a0(uVar32);
          bVar6 = func_0x0001801b1a50(uVar33);
          uVar33 = func_0x0001803ce7a0(uVar32);
          bVar15 = FUN_1801b1a60(uVar33);
          uVar33 = func_0x0001803ce7a0(uVar32);
          bVar16 = func_0x0001801b1a70(uVar33);
          uVar33 = func_0x0001803ce7a0(uVar32);
          bVar17 = func_0x0001801b1a80(uVar33);
          uStack_b3c = (uint)bVar6 << 0x18 | (uint)bVar15 << 0x10 | (uint)bVar16 << 8 | (uint)bVar17
          ;
        }
        uStack_9d8 = FUN_1802a4130(&puStack_578);
        _guard_check_icall(&DAT_180d6ea00,&uStack_5b8,&uStack_9d8);
        uStack_b1c = func_0x0001803ce7e0(uVar32);
        uVar7 = func_0x0001803ce770(uVar32);
        uVar8 = func_0x0001803ce740(uVar32);
        uStack_b88 = func_0x0001803ce710(uVar32);
        auVar53._0_8_ = func_0x0001803ce6e0(uVar32);
        auVar53._8_56_ = extraout_var_13;
        auVar66 = ZEXT1664(auVar53._0_16_);
        uVar9 = func_0x0001803ce6b0(uVar32);
        uVar10 = func_0x0001803ce680(uVar32);
        uVar11 = func_0x0001803ce650(uVar32);
        uVar12 = func_0x0001803ce620(auStack_668._0_8_);
        uVar32 = func_0x0001803ce5f0(auStack_668._0_8_);
        puStack_b98 = auStack_538;
        puStack_ba0 = (undefined1 *)CONCAT44(puStack_ba0._4_4_,uStack_b1c);
        uStack_ba8 = uStack_b3c;
        uStack_bb8 = CONCAT31(uStack_bb8._1_3_,uVar8);
        ppuStack_bc0 = &puStack_578;
        ppuStack_bc8 = apuStack_550;
        uStack_bd0 = CONCAT31(uStack_bd0._1_3_,uStack_b88);
        uStack_bd8 = auVar66._0_4_;
        pcStack_be0 = (char *)CONCAT71(pcStack_be0._1_7_,uVar9);
        puStack_be8 = (undefined1 *)CONCAT71(puStack_be8._1_7_,uVar10);
        ppuStack_bf0 = (undefined **)CONCAT71(ppuStack_bf0._1_7_,uVar11);
        pcStack_bf8 = (char *)CONCAT71(pcStack_bf8._1_7_,uVar12);
        uStack_bb0 = uVar7;
        FUN_18032a060(local_b78._0_8_,&uStack_5b8,uStack_b38 & 0xffffffff,uVar32);
        pcVar25 = local_5d8;
        uVar32 = FUN_1801be340(local_5d0);
        FUN_1803d9e90(uVar32,pcVar25);
        thunk_FUN_1801a2440(auStack_538);
        thunk_FUN_1801a2440(apuStack_550);
        thunk_FUN_1801f3260(&puStack_578);
        goto code_r0x0001803df6f5;
      case 0xe:
        uVar33 = func_0x0001803d0700(uVar33);
        uVar38 = FUN_1801b2410(uVar33);
        FUN_1801c6b40(uVar38,&uStack_5b8);
        FUN_1801a6370(&puStack_578,0x18);
        func_0x0001801a8e50(&puStack_578);
        lVar23 = FUN_1801b2640(uVar33);
        if (lVar23 != 0) {
          uVar38 = FUN_1801b2640(uVar33);
          func_0x00018023a700(uVar38,auStack_3a8);
          func_0x0001803ea1b0(uVar38,auStack_130);
          cVar5 = func_0x0001803e92a0(auStack_3a8,auStack_130);
          while (cVar5 != '\0') {
            uVar38 = FUN_1801be340(auStack_3a8);
            auVar58._0_8_ = func_0x0001801b1a00(uVar38);
            auVar58._8_56_ = extraout_var_18;
            auVar69 = ZEXT1664(auVar58._0_16_);
            auVar59._0_8_ = func_0x0001801b1a10(uVar38);
            auVar59._8_56_ = extraout_var_19;
            auVar66 = ZEXT1664(auVar59._0_16_);
            uVar38 = func_0x0001801b1a20(uVar38);
            uVar38 = func_0x0001801b19e0(auStack_7e8,auVar69._0_8_,auVar66._0_8_,uVar38);
            FUN_1802a3900(&puStack_578,uVar38);
            func_0x0001803e9290(auStack_3a8);
            cVar5 = func_0x0001803e92a0(auStack_3a8,auStack_130);
          }
        }
        FUN_1801a6370(apuStack_550,0x18);
        func_0x0001801a8e50(apuStack_550);
        lVar23 = FUN_1801ccce0(uVar33);
        if (lVar23 != 0) {
          uVar38 = FUN_1801ccce0(uVar33);
          func_0x00018023a700(uVar38,auStack_3b0);
          FUN_1801be970(uVar38,auStack_128);
          cVar5 = func_0x0001803e92a0(auStack_3b0,auStack_128);
          while (cVar5 != '\0') {
            uStack_2cc = func_0x00018023aba0(auStack_3b0);
            FUN_1802a4530(apuStack_550,&uStack_2cc);
            func_0x00018023ab90(auStack_3b0);
            cVar5 = func_0x0001803e92a0(auStack_3b0,auStack_128);
          }
        }
        FUN_1801a6370(auStack_538,0x18);
        func_0x0001801a8e50(auStack_538);
        lVar23 = FUN_1801b26a0(uVar33);
        if (lVar23 != 0) {
          uVar33 = FUN_1801b26a0(uVar33);
          func_0x00018023a700(uVar33,auStack_330);
          FUN_1801be970(uVar33,auStack_120);
          cVar5 = func_0x0001803e92a0(auStack_330,auStack_120);
          while (cVar5 != '\0') {
            uStack_2d0 = func_0x00018023aba0(auStack_330);
            FUN_1802a4530(auStack_538,&uStack_2d0);
            func_0x00018023ab90(auStack_330);
            cVar5 = func_0x0001803e92a0(auStack_330,auStack_120);
          }
        }
        uStack_9e8 = FUN_1802a4130(&puStack_578);
        _guard_check_icall(&DAT_180d6ea00,&uStack_9e8,&uStack_5b8);
        pcStack_bf8 = auStack_538;
        FUN_18032a390(uVar32,&uStack_5b8,&puStack_578);
        pcVar25 = local_5d8;
        uVar32 = FUN_1801be340(local_5d0);
        FUN_1803d9e90(uVar32,pcVar25);
        thunk_FUN_1801a2440(auStack_538);
        thunk_FUN_1801a2440(apuStack_550);
        thunk_FUN_1801f3260(&puStack_578);
        thunk_FUN_1801a2650(&uStack_5b8);
        goto code_r0x0001803e3390;
      case 0xf:
        uVar33 = func_0x0001803d0750(uVar33);
        uVar38 = FUN_1801b2410(uVar33);
        FUN_1801c6b40(uVar38,&uStack_5b8);
        FUN_1801a6370(&puStack_578,0x18);
        func_0x0001801a8e50(&puStack_578);
        lVar23 = FUN_1801b2640(uVar33);
        if (lVar23 != 0) {
          uVar38 = FUN_1801b2640(uVar33);
          func_0x00018023a700(uVar38,auStack_3c0);
          func_0x0001803ea1b0(uVar38,auStack_118);
          cVar5 = func_0x0001803e92a0(auStack_3c0,auStack_118);
          while (cVar5 != '\0') {
            uVar38 = FUN_1801be340(auStack_3c0);
            auVar60._0_8_ = func_0x0001801b1a00(uVar38);
            auVar60._8_56_ = extraout_var_20;
            auVar69 = ZEXT1664(auVar60._0_16_);
            auVar61._0_8_ = func_0x0001801b1a10(uVar38);
            auVar61._8_56_ = extraout_var_21;
            auVar66 = ZEXT1664(auVar61._0_16_);
            uVar38 = func_0x0001801b1a20(uVar38);
            uVar38 = func_0x0001801b19e0(auStack_7dc,auVar69._0_8_,auVar66._0_8_,uVar38);
            FUN_1802a3900(&puStack_578,uVar38);
            func_0x0001803e9290(auStack_3c0);
            cVar5 = func_0x0001803e92a0(auStack_3c0,auStack_118);
          }
        }
        FUN_1801a6370(apuStack_550,0x18);
        func_0x0001801a8e50(apuStack_550);
        lVar23 = FUN_1801ccce0(uVar33);
        if (lVar23 != 0) {
          uVar38 = FUN_1801ccce0(uVar33);
          func_0x00018023a700(uVar38,auStack_318);
          FUN_1801be970(uVar38,auStack_110);
          cVar5 = func_0x0001803e92a0(auStack_318,auStack_110);
          while (cVar5 != '\0') {
            uStack_2d4 = func_0x00018023aba0(auStack_318);
            FUN_1802a4530(apuStack_550,&uStack_2d4);
            func_0x00018023ab90(auStack_318);
            cVar5 = func_0x0001803e92a0(auStack_318,auStack_110);
          }
        }
        FUN_1801a6370(auStack_538,0x18);
        func_0x0001801a8e50(auStack_538);
        lVar23 = FUN_1801b26a0(uVar33);
        if (lVar23 != 0) {
          uVar33 = FUN_1801b26a0(uVar33);
          func_0x00018023a700(uVar33,auStack_320);
          FUN_1801be970(uVar33,auStack_108);
          cVar5 = func_0x0001803e92a0(auStack_320,auStack_108);
          while (cVar5 != '\0') {
            uStack_2d8 = func_0x00018023aba0(auStack_320);
            FUN_1802a4530(auStack_538,&uStack_2d8);
            func_0x00018023ab90(auStack_320);
            cVar5 = func_0x0001803e92a0(auStack_320,auStack_108);
          }
        }
        uStack_a88 = FUN_1802a4130(&puStack_578);
        _guard_check_icall(&DAT_180d6ea00,&uStack_5b8,&uStack_a88);
        pcStack_bf8 = auStack_538;
        FUN_18032ad00(uVar32,&uStack_5b8,&puStack_578);
        pcVar25 = local_5d8;
        uVar32 = FUN_1801be340(local_5d0);
        FUN_1803d9e90(uVar32,pcVar25);
        thunk_FUN_1801a2440(auStack_538);
        thunk_FUN_1801a2440(apuStack_550);
        thunk_FUN_1801f3260(&puStack_578);
        thunk_FUN_1801a2650(&uStack_5b8);
        goto code_r0x0001803e3390;
      case 0x10:
        uVar33 = func_0x0001803d07a0(uVar33);
        uVar33 = FUN_1801b2410(uVar33);
        FUN_1801c6b40(uVar33,&uStack_5b8);
        _guard_check_icall(&DAT_180d6ea00,&uStack_5b8);
        FUN_18032adb0(uVar32,&uStack_5b8);
        pcVar25 = local_5d8;
        uVar32 = FUN_1801be340(local_5d0);
        FUN_1803d9e90(uVar32,pcVar25);
        thunk_FUN_1801a2650(&uStack_5b8);
        goto code_r0x0001803e3390;
      case 0x11:
        uVar33 = func_0x0001803d07f0(uVar33);
        uStack_b49 = FUN_1803ce340(uVar33);
        func_0x0001803e8eb0(&DAT_180d6ea00,&uStack_b49);
        uVar7 = FUN_1803ce340(uVar33);
        FUN_1803283c0(uVar32,uVar7);
        break;
      case 0x12:
        uVar33 = func_0x0001803d0840(uVar33);
        func_0x0001803e8f30(&DAT_180d6ea00);
        func_0x0001803291a0(auStack_648);
        lVar23 = FUN_1801b2410(uVar33);
        if (lVar23 != 0) {
          uVar38 = FUN_1801b2410(uVar33);
          func_0x00018023a700(uVar38,auStack_388);
          FUN_1801be970(uVar38,auStack_218);
          cVar5 = func_0x0001803e92a0(auStack_388,auStack_218);
          while (cVar5 != '\0') {
            uVar38 = func_0x0001803ea1a0(auStack_388);
            func_0x000180328a10(&uStack_4d8);
            uVar43 = FUN_1801b2410(uVar38);
            uVar43 = FUN_1801c6b40(uVar43,&uStack_5b8);
            FUN_180181710(&uStack_4d8,uVar43);
            thunk_FUN_1801a2650(&uStack_5b8);
            uVar43 = FUN_1801b2170(uVar38);
            bVar6 = func_0x0001801b1a50(uVar43);
            uVar43 = FUN_1801b2170(uVar38);
            bVar15 = FUN_1801b1a60(uVar43);
            uVar43 = FUN_1801b2170(uVar38);
            bVar16 = func_0x0001801b1a70(uVar43);
            uVar43 = FUN_1801b2170(uVar38);
            bVar17 = func_0x0001801b1a80(uVar43);
            uStack_4b8 = (uint)bVar6 << 0x18 | (uint)bVar15 << 0x10 | (uint)bVar16 << 8 |
                         (uint)bVar17;
            uStack_4b4 = func_0x0001803ce5f0(uVar38);
            uVar7 = func_0x0001803ce620(uVar38);
            uStack_4b0 = CONCAT31(uStack_4b0._1_3_,uVar7);
            uVar7 = func_0x0001803ce650(uVar38);
            uStack_4b0._0_2_ = CONCAT11(uVar7,(undefined1)uStack_4b0);
            uVar7 = func_0x0001803ce680(uVar38);
            uStack_4b0._0_3_ = CONCAT12(uVar7,(undefined2)uStack_4b0);
            uVar7 = func_0x0001803ce6b0(uVar38);
            uStack_4b0 = CONCAT13(uVar7,(undefined3)uStack_4b0);
            uStack_4ac = func_0x0001803ce6e0(uVar38);
            uVar7 = func_0x0001803ce710(uVar38);
            uStack_4a8 = CONCAT31(uStack_4a8._1_3_,uVar7);
            uVar7 = func_0x0001803ce740(uVar38);
            uStack_4a8._0_2_ = CONCAT11(uVar7,(undefined1)uStack_4a8);
            uVar7 = func_0x0001803ce770(uVar38);
            uStack_4a8._0_3_ = CONCAT12(uVar7,(undefined2)uStack_4a8);
            lVar23 = func_0x0001803ce7a0(uVar38);
            if (lVar23 != 0) {
              uVar43 = func_0x0001803ce7a0(uVar38);
              bVar6 = func_0x0001801b1a50(uVar43);
              uVar43 = func_0x0001803ce7a0(uVar38);
              bVar15 = FUN_1801b1a60(uVar43);
              uVar43 = func_0x0001803ce7a0(uVar38);
              bVar16 = func_0x0001801b1a70(uVar43);
              uVar43 = func_0x0001803ce7a0(uVar38);
              bVar17 = func_0x0001801b1a80(uVar43);
              uStack_4a4 = (uint)bVar6 << 0x18 | (uint)bVar15 << 0x10 | (uint)bVar16 << 8 |
                           (uint)bVar17;
            }
            uStack_4a0 = func_0x0001803ce7e0(uVar38);
            lVar23 = FUN_1801b1ac0(uVar38);
            if (lVar23 != 0) {
              uVar43 = FUN_1801b1ac0(uVar38);
              func_0x00018023a700(uVar43,auStack_380);
              func_0x0001803ea1b0(uVar43,auStack_100);
              cVar5 = func_0x0001803e92a0(auStack_380,auStack_100);
              while (cVar5 != '\0') {
                uVar43 = FUN_1801be340(auStack_380);
                auVar62._0_8_ = func_0x0001801b1a00(uVar43);
                auVar62._8_56_ = extraout_var_22;
                auVar69 = ZEXT1664(auVar62._0_16_);
                auVar63._0_8_ = func_0x0001801b1a10(uVar43);
                auVar63._8_56_ = extraout_var_23;
                auVar66 = ZEXT1664(auVar63._0_16_);
                uVar43 = func_0x0001801b1a20(uVar43);
                uVar43 = func_0x0001801b19e0(auStack_82c,auVar69._0_8_,auVar66._0_8_,uVar43);
                FUN_1802a3900(auStack_480,uVar43);
                func_0x0001803e9290(auStack_380);
                cVar5 = func_0x0001803e92a0(auStack_380,auStack_100);
              }
            }
            lVar23 = FUN_1801b27f0(uVar38);
            if (lVar23 != 0) {
              uVar43 = FUN_1801b27f0(uVar38);
              func_0x00018023a700(uVar43,auStack_328);
              FUN_1801be970(uVar43,auStack_f8);
              cVar5 = func_0x0001803e92a0(auStack_328,auStack_f8);
              while (cVar5 != '\0') {
                uStack_2f4 = func_0x00018023aba0(auStack_328);
                FUN_1802a4530(&uStack_498,&uStack_2f4);
                func_0x00018023ab90(auStack_328);
                cVar5 = func_0x0001803e92a0(auStack_328,auStack_f8);
              }
            }
            lVar23 = func_0x0001803ce810(uVar38);
            if (lVar23 != 0) {
              uVar38 = func_0x0001803ce810(uVar38);
              func_0x00018023a700(uVar38,auStack_350);
              FUN_1801be970(uVar38,auStack_170);
              cVar5 = func_0x0001803e92a0(auStack_350,auStack_170);
              while (cVar5 != '\0') {
                uStack_2f8 = func_0x00018023aba0(auStack_350);
                FUN_1802a4530(auStack_468,&uStack_2f8);
                func_0x00018023ab90(auStack_350);
                cVar5 = func_0x0001803e92a0(auStack_350,auStack_170);
              }
            }
            FUN_180333b40(auStack_648,&uStack_4d8);
            FUN_180328a60(&uStack_4d8);
            func_0x00018023ab90(auStack_388);
            cVar5 = func_0x0001803e92a0(auStack_388,auStack_218);
          }
        }
        lVar23 = FUN_1801b2640(uVar33);
        if (lVar23 != 0) {
          uVar33 = FUN_1801b2640(uVar33);
          func_0x00018023a700(uVar33,auStack_3e0);
          FUN_1801be970(uVar33,auStack_178);
          cVar5 = func_0x0001803e92a0(auStack_3e0,auStack_178);
          while (cVar5 != '\0') {
            uVar33 = func_0x0001803ea1a0(auStack_3e0);
            func_0x000180328a10(&uStack_4d8);
            uVar38 = FUN_1801b2410(uVar33);
            uVar38 = FUN_1801c6b40(uVar38,&uStack_5b8);
            FUN_180181710(&uStack_4d8,uVar38);
            thunk_FUN_1801a2650(&uStack_5b8);
            uVar38 = FUN_1801b2170(uVar33);
            bVar6 = func_0x0001801b1a50(uVar38);
            uVar38 = FUN_1801b2170(uVar33);
            bVar15 = FUN_1801b1a60(uVar38);
            uVar38 = FUN_1801b2170(uVar33);
            bVar16 = func_0x0001801b1a70(uVar38);
            uVar38 = FUN_1801b2170(uVar33);
            bVar17 = func_0x0001801b1a80(uVar38);
            uStack_4b8 = (uint)bVar6 << 0x18 | (uint)bVar15 << 0x10 | (uint)bVar16 << 8 |
                         (uint)bVar17;
            uStack_4b4 = func_0x0001803ce5f0(uVar33);
            uVar7 = func_0x0001803ce620(uVar33);
            uStack_4b0 = CONCAT31(uStack_4b0._1_3_,uVar7);
            uVar7 = func_0x0001803ce650(uVar33);
            uStack_4b0._0_2_ = CONCAT11(uVar7,(undefined1)uStack_4b0);
            uVar7 = func_0x0001803ce680(uVar33);
            uStack_4b0._0_3_ = CONCAT12(uVar7,(undefined2)uStack_4b0);
            uVar7 = func_0x0001803ce6b0(uVar33);
            uStack_4b0 = CONCAT13(uVar7,(undefined3)uStack_4b0);
            uStack_4ac = func_0x0001803ce6e0(uVar33);
            uVar7 = func_0x0001803ce710(uVar33);
            uStack_4a8 = CONCAT31(uStack_4a8._1_3_,uVar7);
            uVar7 = func_0x0001803ce740(uVar33);
            uStack_4a8._0_2_ = CONCAT11(uVar7,(undefined1)uStack_4a8);
            uVar7 = func_0x0001803ce770(uVar33);
            uStack_4a8._0_3_ = CONCAT12(uVar7,(undefined2)uStack_4a8);
            lVar23 = func_0x0001803ce7a0(uVar33);
            if (lVar23 != 0) {
              uVar38 = func_0x0001803ce7a0(uVar33);
              bVar6 = func_0x0001801b1a50(uVar38);
              uVar38 = func_0x0001803ce7a0(uVar33);
              bVar15 = FUN_1801b1a60(uVar38);
              uVar38 = func_0x0001803ce7a0(uVar33);
              bVar16 = func_0x0001801b1a70(uVar38);
              uVar38 = func_0x0001803ce7a0(uVar33);
              bVar17 = func_0x0001801b1a80(uVar38);
              uStack_4a4 = (uint)bVar6 << 0x18 | (uint)bVar15 << 0x10 | (uint)bVar16 << 8 |
                           (uint)bVar17;
            }
            uStack_4a0 = func_0x0001803ce7e0(uVar33);
            lVar23 = FUN_1801b1ac0(uVar33);
            if (lVar23 != 0) {
              uVar38 = FUN_1801b1ac0(uVar33);
              func_0x00018023a700(uVar38,auStack_3c8);
              func_0x0001803ea1b0(uVar38,auStack_210);
              cVar5 = func_0x0001803e92a0(auStack_3c8,auStack_210);
              while (cVar5 != '\0') {
                uVar38 = FUN_1801be340(auStack_3c8);
                auVar64._0_8_ = func_0x0001801b1a00(uVar38);
                auVar64._8_56_ = extraout_var_24;
                auVar69 = ZEXT1664(auVar64._0_16_);
                auVar65._0_8_ = func_0x0001801b1a10(uVar38);
                auVar65._8_56_ = extraout_var_25;
                auVar66 = ZEXT1664(auVar65._0_16_);
                uVar38 = func_0x0001801b1a20(uVar38);
                uVar38 = func_0x0001801b19e0(auStack_820,auVar69._0_8_,auVar66._0_8_,uVar38);
                FUN_1802a3900(auStack_480,uVar38);
                func_0x0001803e9290(auStack_3c8);
                cVar5 = func_0x0001803e92a0(auStack_3c8,auStack_210);
              }
            }
            lVar23 = FUN_1801b27f0(uVar33);
            if (lVar23 != 0) {
              uVar38 = FUN_1801b27f0(uVar33);
              func_0x00018023a700(uVar38,auStack_3d0);
              FUN_1801be970(uVar38,auStack_1d8);
              cVar5 = func_0x0001803e92a0(auStack_3d0,auStack_1d8);
              while (cVar5 != '\0') {
                uStack_2fc = func_0x00018023aba0(auStack_3d0);
                FUN_1802a4530(&uStack_498,&uStack_2fc);
                func_0x00018023ab90(auStack_3d0);
                cVar5 = func_0x0001803e92a0(auStack_3d0,auStack_1d8);
              }
            }
            lVar23 = func_0x0001803ce810(uVar33);
            if (lVar23 != 0) {
              uVar33 = func_0x0001803ce810(uVar33);
              func_0x00018023a700(uVar33,auStack_3d8);
              FUN_1801be970(uVar33,auStack_208);
              cVar5 = func_0x0001803e92a0(auStack_3d8,auStack_208);
              while (cVar5 != '\0') {
                uStack_300 = func_0x00018023aba0(auStack_3d8);
                FUN_1802a4530(auStack_468,&uStack_300);
                func_0x00018023ab90(auStack_3d8);
                cVar5 = func_0x0001803e92a0(auStack_3d8,auStack_208);
              }
            }
            FUN_180333710(auStack_630,&uStack_4d8);
            FUN_180328a60(&uStack_4d8);
            func_0x00018023ab90(auStack_3e0);
            cVar5 = func_0x0001803e92a0(auStack_3e0,auStack_178);
          }
        }
        FUN_1803291e0(uVar32,auStack_648);
        pcVar25 = local_5d8;
        uVar32 = FUN_1801be340(local_5d0);
        FUN_1803d9e90(uVar32,pcVar25);
        FUN_1803291c0(auStack_648);
        goto code_r0x0001803e3390;
      case 0x13:
        func_0x0001803e8f20(&DAT_180d6ea00);
        FUN_180328aa0(uVar32,auStack_648);
        lStack_4f8 = 0x100;
        lVar23 = FUN_1801be340(auStack_648);
        lVar27 = FUN_1802a43e0(auStack_648);
        for (; lVar23 != lVar27; lVar23 = lVar23 + 0x88) {
          lVar34 = FUN_1801a1d50(lVar23);
          lStack_4f8 = lStack_4f8 + 0x80 + lVar34;
          lVar34 = FUN_1802a4130(lVar23 + 0x58);
          lStack_4f8 = lStack_4f8 + lVar34 * 0x10;
        }
        lVar23 = FUN_1801be340(auStack_630);
        lVar27 = FUN_1802a43e0(auStack_630);
        for (; lVar23 != lVar27; lVar23 = lVar23 + 0x88) {
          lVar34 = FUN_1801a1d50(lVar23);
          lStack_4f8 = lStack_4f8 + 0x80 + lVar34;
          lVar34 = FUN_1802a4130(lVar23 + 0x58);
          lStack_4f8 = lStack_4f8 + lVar34 * 0x10;
        }
        FUN_18019fc10(auStack_4f0,0x10);
        FUN_1801fddd0(auStack_4f0,&lStack_4f8);
        FUN_1801a6370(&uStack_5b8,0x18);
        func_0x0001801a8e50(&uStack_5b8);
        lVar23 = FUN_1801be340(auStack_648);
        lVar27 = FUN_1802a43e0(auStack_648);
        auStack_668._0_8_ = lVar27;
        if (lVar23 != lVar27) {
          do {
            FUN_1801a6370(auStack_538,0x18);
            func_0x0001801a8e50(auStack_538);
            puVar29 = (undefined4 *)FUN_1801be340(lVar23 + 0x58);
            puVar35 = (undefined4 *)FUN_1802a43e0(lVar23 + 0x58);
            for (; puVar29 != puVar35; puVar29 = puVar29 + 3) {
              uVar32 = func_0x0001801b19e0(auStack_838,*puVar29,puVar29[1],puVar29[2]);
              FUN_1802a3900(auStack_538,uVar32);
            }
            uVar40 = func_0x000180180be0(*(undefined4 *)(lVar23 + 0x20));
            pcStack_bf8._0_1_ = (char)uVar40;
            func_0x0001801b1a30(auStack_2e0,uVar40 >> 0x18,uVar40 >> 0x10,uVar40 >> 8);
            uVar40 = func_0x000180180be0(*(undefined4 *)(lVar23 + 0x34));
            pcStack_bf8 = (char *)CONCAT71(pcStack_bf8._1_7_,(char)uVar40);
            func_0x0001801b1a30(auStack_2dc,uVar40 >> 0x18,uVar40 >> 0x10,uVar40 >> 8);
            uVar32 = FUN_1801be340(auStack_4f0);
            puVar29 = (undefined4 *)FUN_1803e7170(uVar32,auStack_a80,lVar23 + 0x70);
            uVar21 = *puVar29;
            uStack_b38 = CONCAT44(uStack_b38._4_4_,*(undefined4 *)(lVar23 + 0x38));
            uStack_b88 = *(undefined1 *)(lVar23 + 0x32);
            uStack_b84 = *(undefined1 *)(lVar23 + 0x31);
            uVar32 = FUN_1801be340(auStack_4f0);
            puVar29 = (undefined4 *)FUN_1803e7170(uVar32,auStack_a18,lVar23 + 0x40);
            uVar22 = *puVar29;
            uVar32 = FUN_1801be340(auStack_4f0);
            puVar29 = (undefined4 *)FUN_1803e7370(uVar32,auStack_9b8,auStack_538);
            uVar1 = *puVar29;
            uVar7 = *(undefined1 *)(lVar23 + 0x30);
            auVar66 = ZEXT464(*(uint *)(lVar23 + 0x2c));
            uVar8 = *(undefined1 *)(lVar23 + 0x2b);
            uStack_b86 = *(undefined1 *)(lVar23 + 0x2a);
            uStack_b87 = *(undefined1 *)(lVar23 + 0x29);
            uStack_b85 = *(undefined1 *)(lVar23 + 0x28);
            auVar69 = ZEXT464(*(uint *)(lVar23 + 0x24));
            uVar32 = FUN_1801be340(auStack_4f0);
            puVar29 = (undefined4 *)FUN_1801bd7d0(uVar32,auStack_a1c,lVar23);
            uVar2 = *puVar29;
            uVar32 = FUN_1801be340(auStack_4f0);
            puStack_b98 = (undefined1 *)CONCAT44(puStack_b98._4_4_,(undefined4)uStack_b38);
            puStack_ba0 = auStack_2dc;
            uStack_ba8 = CONCAT31(uStack_ba8._1_3_,uStack_b88);
            uStack_bb0 = uStack_b84;
            ppuStack_bc0 = (undefined **)CONCAT44(ppuStack_bc0._4_4_,uVar1);
            ppuStack_bc8 = (undefined **)CONCAT71(ppuStack_bc8._1_7_,uVar7);
            uStack_bd0 = auVar66._0_4_;
            uStack_bd8 = CONCAT31(uStack_bd8._1_3_,uVar8);
            pcStack_be0 = (char *)CONCAT71(pcStack_be0._1_7_,uStack_b86);
            puStack_be8 = (undefined1 *)CONCAT71(puStack_be8._1_7_,uStack_b87);
            ppuStack_bf0 = (undefined **)CONCAT71(ppuStack_bf0._1_7_,uStack_b85);
            pcStack_bf8 = (char *)CONCAT44(pcStack_bf8._4_4_,auVar69._0_4_);
            uStack_bb8 = uVar22;
            uStack_b90 = uVar21;
            FUN_1803cec10(auStack_2e4,uVar32,uVar2,auStack_2e0);
            func_0x0001803ea190(&uStack_5b8,auStack_2e4);
            FUN_1801f3260(auStack_538);
            lVar23 = lVar23 + 0x88;
          } while (lVar23 != auStack_668._0_8_);
        }
        FUN_1801a6370(apuStack_550,0x18);
        func_0x0001801a8e50(apuStack_550);
        lVar23 = FUN_1801be340(auStack_630);
        auStack_668._0_8_ = FUN_1802a43e0(auStack_630);
        if (lVar23 != auStack_668._0_8_) {
          do {
            FUN_1801a6370(&puStack_578,0x18);
            func_0x0001801a8e50(&puStack_578);
            puVar29 = (undefined4 *)FUN_1801be340(lVar23 + 0x58);
            puVar35 = (undefined4 *)FUN_1802a43e0(lVar23 + 0x58);
            for (; puVar29 != puVar35; puVar29 = puVar29 + 3) {
              uStack_a98 = *puVar29;
              uStack_a94 = puVar29[1];
              uStack_a90 = puVar29[2];
              FUN_1802a3900(&puStack_578,&uStack_a98);
            }
            uVar21 = *(undefined4 *)(lVar23 + 0x20);
            uStack_4fe = (undefined1)((uint)uVar21 >> 0x10);
            uStack_4ff = (undefined1)((uint)uVar21 >> 8);
            uStack_500 = (undefined1)uVar21;
            uStack_4fd = (undefined1)((uint)uVar21 >> 0x18);
            uVar21 = *(undefined4 *)(lVar23 + 0x34);
            uStack_4fa = (undefined1)((uint)uVar21 >> 0x10);
            uStack_4fb = (undefined1)((uint)uVar21 >> 8);
            uStack_4fc = (undefined1)uVar21;
            uStack_4f9 = (undefined1)((uint)uVar21 >> 0x18);
            puVar42 = *(undefined **)(lVar23 + 0x70);
            puVar41 = &DAT_180d6e97b;
            if (puVar42 != *(undefined **)(lVar23 + 0x78)) {
              puVar41 = puVar42;
            }
            FUN_1803ea4e0(auStack_4f0[0],&uStack_b08,puVar41,
                          (longlong)*(undefined **)(lVar23 + 0x78) - (longlong)puVar42 >> 2);
            uVar21 = uStack_b08;
            uStack_b38 = CONCAT44(uStack_b38._4_4_,*(undefined4 *)(lVar23 + 0x38));
            uStack_b85 = *(undefined1 *)(lVar23 + 0x32);
            uStack_b88 = *(undefined1 *)(lVar23 + 0x31);
            puVar42 = *(undefined **)(lVar23 + 0x40);
            puVar41 = &DAT_180d6e97b;
            if (puVar42 != *(undefined **)(lVar23 + 0x48)) {
              puVar41 = puVar42;
            }
            FUN_1803ea4e0(auStack_4f0[0],&uStack_b04,puVar41,
                          (longlong)*(undefined **)(lVar23 + 0x48) - (longlong)puVar42 >> 2);
            uVar22 = uStack_b04;
            puVar42 = &DAT_180d6e979;
            if (puStack_578 != puStack_570) {
              puVar42 = puStack_578;
            }
            FUN_1803ea5b0(auStack_4f0[0],&uStack_b00,puVar42,
                          ((longlong)puStack_570 - (longlong)puStack_578 >> 2) * -0x5555555555555555
                         );
            uVar1 = uStack_b00;
            uVar7 = *(undefined1 *)(lVar23 + 0x30);
            auVar66 = ZEXT464(*(uint *)(lVar23 + 0x2c));
            uVar8 = *(undefined1 *)(lVar23 + 0x2b);
            uStack_b84 = *(undefined1 *)(lVar23 + 0x2a);
            uStack_b86 = *(undefined1 *)(lVar23 + 0x29);
            uStack_b87 = *(undefined1 *)(lVar23 + 0x28);
            auVar69 = ZEXT464(*(uint *)(lVar23 + 0x24));
            local_b78._0_8_ = auStack_4f0[0];
            uVar32 = *(undefined8 *)(lVar23 + 0x10);
            uVar38 = FUN_1801a20f0(lVar23);
            uVar33 = local_b78._0_8_;
            FUN_1801c5540(local_b78._0_8_,uVar38,uVar32);
            uStack_b90 = uVar21;
            puStack_b98 = (undefined1 *)CONCAT44(puStack_b98._4_4_,(undefined4)uStack_b38);
            puStack_ba0 = &uStack_4fc;
            uStack_ba8 = CONCAT31(uStack_ba8._1_3_,uStack_b85);
            uStack_bb0 = uStack_b88;
            uStack_bb8 = uVar22;
            ppuStack_bc0 = (undefined **)CONCAT44(ppuStack_bc0._4_4_,uVar1);
            ppuStack_bc8 = (undefined **)CONCAT71(ppuStack_bc8._1_7_,uVar7);
            uStack_bd0 = auVar66._0_4_;
            uStack_bd8 = CONCAT31(uStack_bd8._1_3_,uVar8);
            pcStack_be0 = (char *)CONCAT71(pcStack_be0._1_7_,uStack_b84);
            puStack_be8 = (undefined1 *)CONCAT71(puStack_be8._1_7_,uStack_b86);
            ppuStack_bf0 = (undefined **)CONCAT71(ppuStack_bf0._1_7_,uStack_b87);
            pcStack_bf8 = (char *)CONCAT44(pcStack_bf8._4_4_,auVar69._0_4_);
            FUN_1803cec10(auStack_2e8,auStack_4f0[0],*(undefined4 *)(uVar33 + 0x30),&uStack_500);
            func_0x0001803ea190(apuStack_550,auStack_2e8);
            FUN_1801f3260(&puStack_578);
            lVar23 = lVar23 + 0x88;
          } while (lVar23 != auStack_668._0_8_);
        }
        uVar32 = FUN_1801be340(auStack_4f0);
        puVar29 = (undefined4 *)FUN_1803e75c0(uVar32,auStack_a20,apuStack_550);
        uVar21 = *puVar29;
        uVar32 = FUN_1801be340(auStack_4f0);
        puVar29 = (undefined4 *)FUN_1803e7470(uVar32,auStack_a14,&uStack_5b8);
        uVar22 = *puVar29;
        uVar32 = FUN_1801be340(auStack_4f0);
        FUN_1803cf650(auStack_2ec,uVar32,uVar22,uVar21);
        pcVar25 = local_5d8;
        func_0x0001803ea140(auStack_2ec,auStack_a10);
        uVar32 = FUN_1801be340(auStack_4f0);
        pcStack_bf8 = pcVar25;
        FUN_1801b3ec0(&uStack_2f0,uVar32,9);
        uVar32 = FUN_1801be340(auStack_4f0);
        func_0x0001801be350(uVar32,uStack_2f0,0);
        uVar32 = FUN_1801be340(local_5d0);
        uVar33 = func_0x0001801dbd60(auStack_898,auStack_4f0);
        FUN_1803bd970(uVar32,uVar33,0);
        FUN_1801a2440(apuStack_550);
        FUN_1801a2440(&uStack_5b8);
        FUN_1801be880(auStack_4f0);
        FUN_1803291c0(auStack_648);
        param_1 = local_b28;
        goto code_r0x0001803e3390;
      case 0x14:
        uVar33 = func_0x0001803d0890(uVar33);
        uVar7 = FUN_1801b2610(uVar33);
        uStack_b48 = func_0x0001801be360(uVar7);
        func_0x0001803e8ec0(&DAT_180d6ea00,&uStack_b48);
        uVar7 = FUN_1801b2610(uVar33);
        FUN_180321a50(uVar32,uVar7);
        break;
      case 0x15:
        uVar33 = func_0x0001803d08e0(uVar33);
        uVar33 = FUN_1801b2410(uVar33);
        FUN_1801c6b40(uVar33,&uStack_5b8);
        _guard_check_icall(&DAT_180d6ea00,&uStack_5b8);
        FUN_180323040(uVar32,&uStack_5b8);
        pcVar25 = local_5d8;
        uVar32 = FUN_1801be340(local_5d0);
        FUN_1803d9e90(uVar32,pcVar25);
        thunk_FUN_1801a2650(&uStack_5b8);
        goto code_r0x0001803e3390;
      case 0x16:
        uVar33 = func_0x0001803d0930(uVar33);
        uVar38 = FUN_1801b2130(uVar33);
        bVar6 = func_0x0001801b1a50(uVar38);
        uVar38 = FUN_1801b2130(uVar33);
        bVar15 = FUN_1801b1a60(uVar38);
        uVar38 = FUN_1801b2130(uVar33);
        bVar16 = func_0x0001801b1a70(uVar38);
        uVar38 = FUN_1801b2130(uVar33);
        bVar17 = func_0x0001801b1a80(uVar38);
        uVar38 = FUN_1801b2130(uVar33);
        cStack_b56 = func_0x0001801b1a80(uVar38);
        uVar38 = FUN_1801b2130(uVar33);
        uStack_b47 = func_0x0001801b1a70(uVar38);
        uVar38 = FUN_1801b2130(uVar33);
        uStack_b46 = FUN_1801b1a60(uVar38);
        uVar33 = FUN_1801b2130(uVar33);
        uStack_b45 = func_0x0001801b1a50(uVar33);
        pcStack_bf8 = &cStack_b56;
        func_0x0001803e8ed0(&DAT_180d6ea00,&uStack_b45,&uStack_b46);
        func_0x000180321af0(uVar32,(uint)bVar6 << 0x18 | (uint)bVar15 << 0x10 | (uint)bVar16 << 8 |
                                   (uint)bVar17);
        break;
      case 0x17:
        uVar33 = func_0x0001803d0980(uVar33);
        uStack_b44 = FUN_1803ce340(uVar33);
        func_0x0001803e8ee0(&DAT_180d6ea00,&uStack_b44);
        uVar7 = FUN_1803ce340(uVar33);
        func_0x000180321b00(uVar32,uVar7);
        break;
      case 0x18:
        uVar32 = func_0x0001803d09d0(uVar33);
        auStack_668._0_8_ = uVar32;
        uVar33 = FUN_1801b2410(uVar32);
        FUN_1801c6b40(uVar33,&uStack_5b8);
        uVar33 = FUN_1801b2170(uVar32);
        bVar6 = func_0x0001801b1a50(uVar33);
        uVar33 = FUN_1801b2170(uVar32);
        bVar15 = FUN_1801b1a60(uVar33);
        uVar33 = FUN_1801b2170(uVar32);
        bVar16 = func_0x0001801b1a70(uVar33);
        uVar33 = FUN_1801b2170(uVar32);
        bVar17 = func_0x0001801b1a80(uVar33);
        uStack_b1c = (uint)bVar6 << 0x18 | (uint)bVar15 << 0x10 | (uint)bVar16 << 8 | (uint)bVar17;
        FUN_1801a6370(&puStack_578,0x18);
        func_0x0001801a8e50(&puStack_578);
        lVar23 = FUN_1801b1ac0(uVar32);
        if (lVar23 != 0) {
          uVar33 = FUN_1801b1ac0(uVar32);
          func_0x00018023a700(uVar33,auStack_398);
          func_0x0001803ea1b0(uVar33,auStack_140);
          cVar5 = func_0x0001803e92a0(auStack_398,auStack_140);
          while (cVar5 != '\0') {
            uVar33 = FUN_1801be340(auStack_398);
            auVar54._0_8_ = func_0x0001801b1a00(uVar33);
            auVar54._8_56_ = extraout_var_14;
            auVar69 = ZEXT1664(auVar54._0_16_);
            auVar55._0_8_ = func_0x0001801b1a10(uVar33);
            auVar55._8_56_ = extraout_var_15;
            auVar66 = ZEXT1664(auVar55._0_16_);
            uVar33 = func_0x0001801b1a20(uVar33);
            uVar33 = func_0x0001801b19e0(auStack_7f4,auVar69._0_8_,auVar66._0_8_,uVar33);
            FUN_1802a3900(&puStack_578,uVar33);
            func_0x0001803e9290(auStack_398);
            cVar5 = func_0x0001803e92a0(auStack_398,auStack_140);
          }
        }
        FUN_1801a6370(auStack_538,0x18);
        func_0x0001801a8e50(auStack_538);
        lVar23 = FUN_1801b27f0(uVar32);
        if (lVar23 != 0) {
          uVar33 = FUN_1801b27f0(uVar32);
          func_0x00018023a700(uVar33,auStack_3a0);
          FUN_1801be970(uVar33,auStack_138);
          cVar5 = func_0x0001803e92a0(auStack_3a0,auStack_138);
          while (cVar5 != '\0') {
            auStack_2c8[0] = func_0x00018023aba0(auStack_3a0);
            FUN_1802a4530(auStack_538,auStack_2c8);
            func_0x00018023ab90(auStack_3a0);
            cVar5 = func_0x0001803e92a0(auStack_3a0,auStack_138);
          }
        }
        uStack_b3c = 0;
        lVar23 = func_0x0001803ce7a0(uVar32);
        if (lVar23 != 0) {
          uVar33 = func_0x0001803ce7a0(uVar32);
          bVar6 = func_0x0001801b1a50(uVar33);
          uVar33 = func_0x0001803ce7a0(uVar32);
          bVar15 = FUN_1801b1a60(uVar33);
          uVar33 = func_0x0001803ce7a0(uVar32);
          bVar16 = func_0x0001801b1a70(uVar33);
          uVar33 = func_0x0001803ce7a0(uVar32);
          bVar17 = func_0x0001801b1a80(uVar33);
          uStack_b3c = (uint)bVar6 << 0x18 | (uint)bVar15 << 0x10 | (uint)bVar16 << 8 | (uint)bVar17
          ;
        }
        uStack_9e0 = FUN_1802a4130(&puStack_578);
        _guard_check_icall(&DAT_180d6ea00,&uStack_5b8,&uStack_9e0);
        uVar21 = func_0x0001803d00c0(uVar32);
        uStack_b38 = CONCAT44(uStack_b38._4_4_,uVar21);
        auVar56._0_8_ = func_0x0001803d0090(uVar32);
        auVar56._8_56_ = extraout_var_16;
        auVar69 = ZEXT1664(auVar56._0_16_);
        uVar7 = func_0x0001803ce770(uVar32);
        uVar8 = func_0x0001803ce740(uVar32);
        uStack_b88 = func_0x0001803ce710(uVar32);
        auVar57._0_8_ = func_0x0001803ce6e0(uVar32);
        auVar57._8_56_ = extraout_var_17;
        auVar66 = ZEXT1664(auVar57._0_16_);
        uVar9 = func_0x0001803ce6b0(uVar32);
        uVar10 = func_0x0001803ce680(uVar32);
        uVar11 = func_0x0001803ce650(uVar32);
        uVar12 = func_0x0001803ce620(auStack_668._0_8_);
        uVar32 = func_0x0001803ce5f0(auStack_668._0_8_);
        puStack_b98 = (undefined1 *)CONCAT44(puStack_b98._4_4_,(undefined4)uStack_b38);
        puStack_ba0 = (undefined1 *)CONCAT44(puStack_ba0._4_4_,auVar69._0_4_);
        uStack_ba8 = uStack_b3c;
        uStack_bb8 = CONCAT31(uStack_bb8._1_3_,uVar8);
        ppuStack_bc0 = (undefined **)auStack_538;
        ppuStack_bc8 = &puStack_578;
        uStack_bd0 = CONCAT31(uStack_bd0._1_3_,uStack_b88);
        uStack_bd8 = auVar66._0_4_;
        pcStack_be0 = (char *)CONCAT71(pcStack_be0._1_7_,uVar9);
        puStack_be8 = (undefined1 *)CONCAT71(puStack_be8._1_7_,uVar10);
        ppuStack_bf0 = (undefined **)CONCAT71(ppuStack_bf0._1_7_,uVar11);
        pcStack_bf8 = (char *)CONCAT71(pcStack_bf8._1_7_,uVar12);
        uStack_bb0 = uVar7;
        FUN_18032b510(local_b78._0_8_,&uStack_5b8,uStack_b1c,uVar32);
        pcVar25 = local_5d8;
        uVar32 = FUN_1801be340(local_5d0);
        FUN_1803d9e90(uVar32,pcVar25);
        thunk_FUN_1801a2440(auStack_538);
        thunk_FUN_1801f3260(&puStack_578);
code_r0x0001803df6f5:
        thunk_FUN_1801a2650(&uStack_5b8);
        param_1 = local_b28;
        goto code_r0x0001803e3390;
      case 0x19:
        uVar33 = func_0x0001803d0a20(uVar33);
        uStack_b43 = FUN_1803ce340(uVar33);
        func_0x0001803e8ef0(&DAT_180d6ea00,&uStack_b43);
        uVar7 = FUN_1803ce340(uVar33);
        func_0x000180321b10(uVar32,uVar7);
        break;
      case 0x1a:
        uVar33 = func_0x0001803d0a70(uVar33);
        uStack_ad0 = FUN_1801cc4b0(uVar33);
        func_0x0001803e8f00(&DAT_180d6ea00,&uStack_ad0);
        uVar21 = FUN_1801cc4b0(uVar33);
        FUN_180321b30(uVar32,uVar21);
        break;
      case 0x1b:
        uVar33 = func_0x0001803d0ac0(uVar33);
        FUN_1801a6370(&puStack_578,0x18);
        func_0x0001801a8e50(&puStack_578);
        lVar23 = FUN_1801ccce0(uVar33);
        if (lVar23 != 0) {
          uVar38 = FUN_1801ccce0(uVar33);
          func_0x00018023a700(uVar38,auStack_360);
          FUN_1801be970(uVar38,auStack_168);
          cVar5 = func_0x0001803e92a0(auStack_360,auStack_168);
          while (cVar5 != '\0') {
            uStack_280 = func_0x00018023aba0(auStack_360);
            FUN_1802a4530(&puStack_578,&uStack_280);
            func_0x00018023ab90(auStack_360);
            cVar5 = func_0x0001803e92a0(auStack_360,auStack_168);
          }
        }
        FUN_1801a6370(auStack_538,0x18);
        func_0x0001801a8e50(auStack_538);
        lVar23 = FUN_1801b26a0(uVar33);
        if (lVar23 != 0) {
          uVar38 = FUN_1801b26a0(uVar33);
          func_0x00018023a700(uVar38,auStack_368);
          FUN_1801be970(uVar38,auStack_160);
          cVar5 = func_0x0001803e92a0(auStack_368,auStack_160);
          while (cVar5 != '\0') {
            uStack_284 = func_0x00018023aba0(auStack_368);
            FUN_1802a4530(auStack_538,&uStack_284);
            func_0x00018023ab90(auStack_368);
            cVar5 = func_0x0001803e92a0(auStack_368,auStack_160);
          }
        }
        uStack_9c8 = func_0x0001801e8210(&puStack_578);
        uStack_ab8 = func_0x0001803ce3a0(uVar33);
        uStack_b4f = FUN_1803ce340(uVar33);
        func_0x0001803e8e00(&DAT_180d6ea00,&uStack_b4f,&uStack_ab8,&uStack_9c8);
        auVar48._0_8_ = func_0x0001803ce3a0(uVar33);
        auVar48._8_56_ = extraout_var_08;
        auVar66 = ZEXT1664(auVar48._0_16_);
        uVar7 = FUN_1803ce340(uVar33);
        pcStack_bf8 = auStack_538;
        FUN_180321970(uVar32,uVar7,auVar66._0_8_);
        pcVar25 = local_5d8;
        uVar32 = FUN_1801be340(local_5d0);
        FUN_1803d9e90(uVar32,pcVar25);
        thunk_FUN_1801a2440(auStack_538);
        thunk_FUN_1801a2440(&puStack_578);
        goto code_r0x0001803e3390;
      case 0x1c:
        uVar32 = func_0x0001803d0b10(uVar33);
        uVar7 = func_0x0001803ce5c0(uVar32);
        uVar8 = FUN_1803ce340(uVar32);
        FUN_180254f60(&DAT_180d105b0,uVar8,uVar7);
        break;
      case 0x1d:
        uVar32 = func_0x0001803d0b60(uVar33);
        uStack_ac0 = FUN_1801cc4b0(uVar32);
        func_0x0001803e8f10(&DAT_180d6ea00,&uStack_ac0);
        uVar33 = func_0x00018041a550();
        uVar21 = FUN_1801cc4b0(uVar32);
        FUN_18041a560(uVar33,uVar21);
        break;
      case 0x1e:
        uVar32 = func_0x0001803d0bb0(uVar33);
        uVar7 = FUN_1803ce340(uVar32);
        FUN_180254f90(&DAT_180d105b0,uVar7);
        break;
      case 0x1f:
        uVar32 = func_0x0001803d0c00(uVar33);
        uVar7 = FUN_1803ce340(uVar32);
        FUN_180254fb0(&DAT_180d105b0,uVar7);
        break;
      case 0x20:
        uVar33 = func_0x0001803d0c50(uVar33);
        uStack_b4e = func_0x0001803ce5c0(uVar33);
        uStack_b4d = FUN_1803ce340(uVar33);
        func_0x0001803e8e10(&DAT_180d6ea00,&uStack_b4d,&uStack_b4e);
        uVar7 = func_0x0001803ce5c0(uVar33);
        uVar8 = FUN_1803ce340(uVar33);
        func_0x000180321b20(uVar32,uVar8,uVar7);
        break;
      case 0x21:
        uVar33 = func_0x0001803d0ca0(uVar33);
        uStack_ab4 = func_0x0001803ce5f0(uVar33);
        uStack_ab0 = func_0x0001803ce3a0(uVar33);
        uStack_aac = func_0x0001803ce370(uVar33);
        func_0x0001803e8e20(&DAT_180d6ea00,&uStack_aac,&uStack_ab0);
        auVar49._0_8_ = func_0x0001803ce5f0(uVar33);
        auVar49._8_56_ = extraout_var_09;
        auVar69 = ZEXT1664(auVar49._0_16_);
        auVar50._0_8_ = func_0x0001803ce3a0(uVar33);
        auVar50._8_56_ = extraout_var_10;
        auVar66 = ZEXT1664(auVar50._0_16_);
        uVar33 = func_0x0001803ce370(uVar33);
        FUN_180321bd0(uVar32,uVar33,auVar66._0_8_,auVar69._0_8_);
        break;
      case 0x22:
        FUN_18019fc10(auStack_a0,0x10);
        FUN_18019fbb0(auStack_a0,param_1 + 0x1a8);
        FUN_1801b6400(auStack_418,8);
        uStack_ae4 = 3;
        func_0x0001803e9990(param_1 + 0x1f8,auStack_418,&uStack_ae4);
        bVar3 = false;
        uVar32 = func_0x0001803e9b00(param_1 + 0x1f8,auStack_910);
        cVar5 = func_0x0001803e98f0(auStack_418,uVar32);
        if (cVar5 == '\0') {
          lVar23 = func_0x0001803e9900(auStack_418);
          cVar5 = FUN_1801d9760(lVar23 + 8);
          if (cVar5 != '\0') {
            lVar23 = func_0x0001803e9900(auStack_418);
            uVar32 = FUN_1801be340(lVar23 + 8);
            func_0x00018040afa0(uVar32);
            bVar3 = true;
          }
        }
        func_0x00018019fb60(auStack_a0);
        pcVar25 = local_5d8;
        uVar32 = FUN_1801be340(local_5d0);
        if (!bVar3) goto code_r0x0001803e338a;
        FUN_1803d9e90(uVar32,pcVar25);
        goto code_r0x0001803e3390;
      default:
        func_0x0001803e8f40(&DAT_180d6ea00);
        goto code_r0x0001803dbfe8;
      }
code_r0x0001803dc592:
      pcVar25 = local_5d8;
      uVar32 = FUN_1801be340(local_5d0);
      FUN_1803d9e90(uVar32,pcVar25);
      break;
    case '\b':
      lVar23 = FUN_1801be340(local_5d0);
      cVar5 = func_0x0001803d80a0(lVar23 + 0x130);
      lVar23 = FUN_1801be340(local_5d0);
      bVar6 = FUN_180393770(lVar23 + 0x130,10);
      if (bVar6 == 0) {
code_r0x0001803e1a12:
        bVar3 = false;
      }
      else {
        lVar23 = FUN_1801be340(local_5d0);
        cVar14 = FUN_180393770(lVar23 + 0x130,1);
        if (cVar14 == '\0') goto code_r0x0001803e1a12;
        bVar3 = true;
      }
      uVar32 = FUN_1801be340(local_5d0);
      cVar14 = FUN_1803d6f50(uVar32,7);
      if (cVar5 == '\0' && (bVar6 == 0 && cVar14 == '\0')) {
code_r0x0001803dcd89:
        pcVar25 = local_5d8;
        uVar32 = FUN_1801be340(local_5d0);
        FUN_1803da020(uVar32,pcVar25);
      }
      else {
        lVar23 = func_0x0001803d0570(pcVar31);
        if (lVar23 == 0) {
          func_0x0001803e8f50(&DAT_180d6ea00);
          pcVar25 = local_5d8;
          uVar32 = FUN_1801be340(local_5d0);
          FUN_1803da020(uVar32,pcVar25);
        }
        else {
          uVar7 = FUN_1801b2610(lVar23);
          uStack_b42 = func_0x0001801be360(uVar7);
          _guard_check_icall(&DAT_180d6ea00,&uStack_b42);
          lVar27 = FUN_1801b2640(lVar23);
          if (lVar27 == 0) {
            uVar7 = FUN_1801b2610(lVar23);
            uStack_b41 = func_0x0001801be360(uVar7);
            func_0x0001803e8f60(&DAT_180d6ea00,&uStack_b41);
            pcVar25 = local_5d8;
            uVar32 = FUN_1801be340(local_5d0);
            FUN_1803da020(uVar32,pcVar25);
            param_1 = local_b28;
          }
          else {
            if (cVar5 == '\0') {
              if (bVar3) {
                uVar40 = 2;
              }
              else {
                uVar40 = (bVar6 ^ 1) * 2 | 1;
              }
            }
            else {
              uVar40 = 0;
            }
            uVar7 = FUN_1801b2610(lVar23);
            pcStack_bf8 = (char *)CONCAT44(pcStack_bf8._4_4_,uVar40);
            FUN_1801bd070(&uStack_5b8,uVar7,lVar27);
            if ((char)uStack_5b8 == '\0') {
              if (lStack_5b0 == 0) {
                uVar7 = FUN_1801b2610(lVar23);
                uStack_b3f = func_0x0001801be360(uVar7);
                func_0x0001803e8f80(&DAT_180d6ea00,&uStack_b3f);
              }
              else {
                uVar7 = FUN_1801b2610(lVar23);
                uStack_b40 = func_0x0001801be360(uVar7);
                func_0x0001803e8f70(&DAT_180d6ea00,&uStack_b40,&lStack_5b0);
              }
              pcVar25 = local_5d8;
              uVar32 = FUN_1801be340(local_5d0);
              FUN_1803da020(uVar32,pcVar25);
            }
            else {
              cVar5 = FUN_1801d9760(&uStack_5a8);
              if (cVar5 != '\0') {
                uVar32 = FUN_1801be340(&uStack_5a8);
                iVar19 = FUN_1801c5610(uVar32);
                if (iVar19 != 0) {
                  uVar32 = FUN_1801be340(local_5d0);
                  uVar33 = func_0x0001801dbd60(auStack_888,&uStack_5a8);
                  FUN_1803bd970(uVar32,uVar33,0);
                  goto code_r0x0001803e1ca0;
                }
              }
              pcVar25 = local_5d8;
              uVar32 = FUN_1801be340(local_5d0);
              FUN_1803d9e90(uVar32,pcVar25);
            }
code_r0x0001803e1ca0:
            FUN_1801b3c10(&uStack_5b8);
            param_1 = local_b28;
          }
        }
      }
      break;
    case '\t':
      lVar23 = func_0x0001803d5b50(pcVar31);
      lVar27 = FUN_1801be340(local_5d0);
      uVar7 = FUN_180393770(lVar27 + 0x130,1);
      lVar27 = FUN_1801be340(local_5d0);
      cVar5 = func_0x0001803d80a0(lVar27 + 0x130);
      if (cVar5 == '\0') {
        lVar27 = FUN_1801be340(local_5d0);
        cVar5 = FUN_180393770(lVar27 + 0x130,10);
        if ((cVar5 == '\0') || (cVar5 = FUN_1803d9070(lVar23,uVar7), cVar5 == '\0')) {
          uVar32 = FUN_1801be340(local_5d0);
          cVar5 = FUN_1803d6f50(uVar32,7);
          if ((cVar5 == '\0') || (cVar5 = FUN_1803d9150(lVar23), cVar5 == '\0'))
          goto code_r0x0001803dbfe8;
        }
      }
      if ((lVar23 != 0) && (lVar27 = FUN_1801b2640(lVar23), lVar27 != 0)) {
        uVar32 = func_0x0001801a8a50(&DAT_180d6e440);
        uVar32 = func_0x0001801b3e60(uVar32);
        lVar27 = FUN_1801b26a0(lVar23);
        if (lVar27 == 0) {
          pauVar28 = (undefined1 (*) [16])FUN_180199ea0(auStack_760);
        }
        else {
          uVar33 = FUN_1801b26a0(lVar23);
          pauVar28 = (undefined1 (*) [16])FUN_1801c6a50(uVar33,auStack_770);
        }
        auVar66 = ZEXT1664(*pauVar28);
        uStack_afc = 0;
        uVar33 = func_0x0001803cbbb0(lVar23,auStack_750);
        cVar5 = func_0x0001803e8fa0(uVar33,&uStack_afc);
        if (cVar5 == '\0') {
          pauVar28 = (undefined1 (*) [16])func_0x0001801a8a80(auStack_730,0);
        }
        else {
          pauVar28 = (undefined1 (*) [16])func_0x0001803cbbb0(lVar23,auStack_740);
        }
        auVar69 = ZEXT1664(*pauVar28);
        uVar33 = FUN_1801b2640(lVar23);
        uVar33 = FUN_1801c6b40(uVar33,auStack_538);
        FUN_180182b40(&uStack_5b8,uVar33,0);
        local_b78 = auVar66._0_16_;
        auStack_668 = auVar69._0_16_;
        uVar7 = FUN_1801b2610(lVar23);
        ppuStack_bf0 = (undefined **)local_b78;
        pcStack_bf8 = auStack_668;
        FUN_1801a4370(uVar32,auStack_b8,uVar7);
        thunk_FUN_1801a2550(&uStack_5b8);
        thunk_FUN_1801a2650(auStack_538);
        cVar5 = func_0x0001801a4330(auStack_b8);
joined_r0x0001803de6f2:
        if (cVar5 != '\0') goto code_r0x0001803dc592;
      }
      goto code_r0x0001803dbfe8;
    case '\n':
      lVar23 = func_0x0001803d05c0(pcVar31);
      if ((lVar23 != 0) && (lVar27 = FUN_1801b2410(lVar23), lVar27 != 0)) {
        lVar27 = FUN_1801be340(local_5d0);
        uStack_5bf = FUN_180393770(lVar27 + 0x130,1);
        lVar27 = FUN_1801be340(local_5d0);
        cVar5 = func_0x0001803d80a0(lVar27 + 0x130);
        if (cVar5 != '\0') {
code_r0x0001803e2133:
          uVar32 = func_0x0001801a8a50(&DAT_180d6e440);
          uVar32 = func_0x0001801b3e60(uVar32);
          FUN_1801a6370(apuStack_550,0x18);
          func_0x0001801a8e50(apuStack_550);
          uVar33 = FUN_1801b2410(lVar23);
          uVar21 = FUN_1801be960(uVar33);
          FUN_1803ea2e0(apuStack_550,uVar21);
          uVar33 = FUN_1801b2410(lVar23);
          func_0x00018023a700(uVar33,auStack_3e8);
          FUN_1801be970(uVar33,auStack_188);
          cVar5 = func_0x0001803e92a0(auStack_3e8,auStack_188);
          while (cVar5 != '\0') {
            lVar23 = func_0x0001803ea1a0(auStack_3e8);
            if ((lVar23 == 0) || (lVar27 = FUN_1801b2640(lVar23), lVar27 == 0)) {
              uStack_b85 = 0;
              puVar37 = &uStack_b85;
            }
            else {
              lVar27 = FUN_1801b26a0(lVar23);
              if (lVar27 == 0) {
                pauVar28 = (undefined1 (*) [16])FUN_180199ea0(auStack_710);
              }
              else {
                uVar33 = FUN_1801b26a0(lVar23);
                pauVar28 = (undefined1 (*) [16])FUN_1801c6a50(uVar33,auStack_720);
              }
              auVar66 = ZEXT1664(*pauVar28);
              uStack_af8 = 0;
              uVar33 = func_0x0001803cbbb0(lVar23,auStack_7d0);
              cVar5 = func_0x0001803e8fa0(uVar33,&uStack_af8);
              if (cVar5 == '\0') {
                pauVar28 = (undefined1 (*) [16])func_0x0001801a8a80(auStack_6f0,0);
              }
              else {
                pauVar28 = (undefined1 (*) [16])func_0x0001803cbbb0(lVar23,auStack_700);
              }
              auVar69 = ZEXT1664(*pauVar28);
              uVar33 = FUN_1801b2640(lVar23);
              uVar33 = FUN_1801c6b40(uVar33,auStack_538);
              FUN_180182b40(&uStack_5b8,uVar33,0);
              local_b78 = auVar66._0_16_;
              auStack_668 = auVar69._0_16_;
              uVar7 = FUN_1801b2610(lVar23);
              ppuStack_bf0 = (undefined **)local_b78;
              pcStack_bf8 = auStack_668;
              FUN_1801a4370(uVar32,auStack_c0,uVar7,&uStack_5b8);
              thunk_FUN_1801a2550(&uStack_5b8);
              thunk_FUN_1801a2650(auStack_538);
              uStack_b3e = func_0x0001801a4330(auStack_c0);
              puVar37 = &uStack_b3e;
            }
            FUN_1803ea370(apuStack_550,puVar37);
            func_0x00018023ab90(auStack_3e8);
            cVar5 = func_0x0001803e92a0(auStack_3e8,auStack_188);
          }
          FUN_18019fc10(auStack_2a0,0x10);
          FUN_1801be280(auStack_2a0);
          uVar32 = FUN_1801be340(auStack_2a0);
          puVar29 = (undefined4 *)FUN_1803e6dc0(uVar32,auStack_a0c,apuStack_550);
          uVar21 = *puVar29;
          uVar32 = FUN_1801be340(auStack_2a0);
          FUN_1803cbd30(auStack_304,uVar32,uVar21);
          pcVar25 = local_5d8;
          func_0x0001803ea140(auStack_304,auStack_a08);
          uVar32 = FUN_1801be340(auStack_2a0);
          pcStack_bf8 = pcVar25;
          FUN_1801b3ec0(&uStack_308,uVar32,0xc);
          uVar32 = FUN_1801be340(auStack_2a0);
          func_0x0001801be350(uVar32,uStack_308,0);
          uVar32 = FUN_1801be340(local_5d0);
          uVar33 = func_0x0001801dbd60(auStack_878,auStack_2a0);
          FUN_1803bd970(uVar32,uVar33,0);
          FUN_1801be880(auStack_2a0);
          func_0x0001801a8db0(apuStack_550);
          break;
        }
        lVar27 = FUN_1801be340(local_5d0);
        cVar5 = FUN_180393770(lVar27 + 0x130,10);
        if (cVar5 != '\0') {
          puVar37 = (undefined1 *)func_0x0001803e36b0(&uStack_b18,&uStack_5bf);
          uVar7 = *puVar37;
          uVar32 = FUN_1801b2410(lVar23);
          cVar5 = FUN_1803e8fc0(uVar32,uVar7,0);
          if (cVar5 != '\0') goto code_r0x0001803e2133;
        }
        uVar32 = FUN_1801be340(local_5d0);
        cVar5 = FUN_1803d6f50(uVar32,7);
        if (cVar5 != '\0') {
          uVar32 = FUN_1801b2410(lVar23);
          cVar5 = FUN_1803e9030(uVar32,FUN_1803d9150,0);
          if (cVar5 != '\0') goto code_r0x0001803e2133;
        }
      }
      goto code_r0x0001803dbfe8;
    case '\v':
      lVar23 = FUN_1801be340(local_5d0);
      cVar5 = func_0x0001803d80a0(lVar23 + 0x130);
      if ((cVar5 != '\0') && (lVar23 = func_0x0001803d0610(pcVar31), lVar23 != 0)) {
        uVar32 = func_0x0001801a8a50(&DAT_180d6e440);
        uVar32 = func_0x0001801b3e60(uVar32);
        func_0x0001801a4320(&uStack_3f0);
        cVar5 = FUN_1801b2610(lVar23);
        if (cVar5 == '\x01') {
          uVar33 = FUN_1801b2640();
          uVar33 = func_0x0001801b20b0(uVar33);
          puVar26 = (undefined8 *)FUN_1801a78a0(uVar32,auStack_908,uVar33);
code_r0x0001803e257c:
          uStack_3f0 = *puVar26;
        }
        else {
          cVar5 = FUN_1801b2610(lVar23);
          if (cVar5 == '\x02') {
            uVar33 = FUN_1801b2640(lVar23);
            pauVar28 = (undefined1 (*) [16])FUN_1801c6a50(uVar33,auStack_6e0);
            local_b78 = *pauVar28;
            puVar26 = (undefined8 *)FUN_1801a7d10(uVar32,auStack_8f8,local_b78);
            goto code_r0x0001803e257c;
          }
        }
        cVar5 = func_0x0001801a4330(&uStack_3f0);
        if (cVar5 != '\0') {
          FUN_1801a7120(uVar32,uStack_3f0);
          goto code_r0x0001803dc592;
        }
      }
      goto code_r0x0001803dbfe8;
    case '\f':
      lVar23 = func_0x0001803d0660(pcVar31);
      if ((lVar23 != 0) && (lVar27 = FUN_1801ccce0(lVar23), lVar27 != 0)) {
        uVar32 = FUN_1801b2640(lVar23);
        uVar7 = FUN_1801b2610(lVar23);
        lVar27 = FUN_1801be340(local_5d0);
        cVar5 = func_0x0001803d80d0(lVar27 + 0x130,uVar7,uVar32);
        if (cVar5 != '\0') {
          uVar32 = func_0x0001801a8a50(&DAT_180d6e440);
          uVar32 = func_0x0001801b3e60(uVar32);
          FUN_1801b2640(lVar23);
          uVar7 = FUN_1801b2610(lVar23);
          FUN_1803d8140(&uStack_1a0,uVar32,uVar7);
          cVar5 = func_0x0001801a4330(&uStack_1a0);
          if (cVar5 != '\0') {
            FUN_1801a6370(&uStack_5b8,0x18);
            func_0x0001801a8e50(&uStack_5b8);
            lVar27 = FUN_1801b26a0(lVar23);
            if (lVar27 != 0) {
              uVar33 = FUN_1801b26a0(lVar23);
              func_0x00018023a700(uVar33,auStack_400);
              FUN_1801be970(uVar33,auStack_198);
              cVar5 = func_0x0001803e92a0(auStack_400,auStack_198);
              while (cVar5 != '\0') {
                uVar33 = func_0x0001803ea1a0(auStack_400);
                func_0x0001803e38d0(auStack_648);
                lVar27 = FUN_1801b2410(uVar33);
                if (lVar27 != 0) {
                  uVar38 = FUN_1801b2410(uVar33);
                  func_0x00018023a700(uVar38,auStack_3f8);
                  FUN_1801be970(uVar38,auStack_190);
                  cVar5 = func_0x0001803e92a0(auStack_3f8,auStack_190);
                  while (cVar5 != '\0') {
                    uVar38 = func_0x0001803ea1a0(auStack_3f8);
                    uVar38 = FUN_1801c6a50(uVar38,auStack_6d0);
                    FUN_1803e9090(auStack_648,uVar38);
                    func_0x00018023ab90(auStack_3f8);
                    cVar5 = func_0x0001803e92a0(auStack_3f8,auStack_190);
                  }
                }
                lVar27 = FUN_1801b2640(uVar33);
                if (lVar27 != 0) {
                  uVar38 = FUN_1801b2640(uVar33);
                  uVar38 = FUN_1801c6b40(uVar38,&puStack_578);
                  FUN_180181710(auStack_630,uVar38);
                  thunk_FUN_1801a2650(&puStack_578);
                }
                lVar27 = FUN_1801ccce0(uVar33);
                if (lVar27 != 0) {
                  uVar33 = FUN_1801ccce0(uVar33);
                  uVar33 = FUN_1801c6b40(uVar33,&puStack_578);
                  FUN_180181710(auStack_610,uVar33);
                  thunk_FUN_1801a2650(&puStack_578);
                }
                FUN_1803e9120(&uStack_5b8,auStack_648);
                FUN_1803e3aa0(auStack_648);
                func_0x00018023ab90(auStack_400);
                cVar5 = func_0x0001803e92a0(auStack_400,auStack_198);
              }
            }
            FUN_1801a2420(auStack_538);
            pauVar28 = (undefined1 (*) [16])func_0x0001803e90f0(auStack_6c0,&uStack_5b8);
            auVar66 = ZEXT1664(*pauVar28);
            uVar33 = FUN_1801ccce0(lVar23);
            pauVar28 = (undefined1 (*) [16])FUN_1801c6a50(uVar33,auStack_6b0);
            local_b78 = auVar66._0_16_;
            auStack_668 = *pauVar28;
            pcStack_bf8 = auStack_538;
            iVar19 = FUN_1801a8160(uVar32,uStack_1a0,auStack_668,local_b78);
            FUN_18019fc10(auStack_340,0x10);
            uStack_abc = 0x100;
            FUN_1801e5bf0(auStack_340,&uStack_abc);
            if (iVar19 == 0) {
              uVar32 = FUN_1801a20f0(auStack_538);
              uVar33 = FUN_1801be340(auStack_340);
              FUN_1803cc290(auStack_30c,uVar33,uVar32,0);
              uVar32 = FUN_1801be340(auStack_340);
              pcVar25 = local_5d8;
              func_0x0001803ea140(auStack_30c,auStack_a04);
              uVar33 = FUN_1801be340(auStack_340);
              puVar37 = auStack_a00;
            }
            else {
              if (iVar19 == 1) {
                pcVar25 = "not a stream texture";
              }
              else {
                pcVar25 = "already connected";
                if (iVar19 != 2) {
                  pcVar25 = "unknown error";
                }
              }
              uVar32 = FUN_1801be340(auStack_340);
              FUN_1803cc290(auStack_310,uVar32,0,pcVar25);
              uVar32 = FUN_1801be340(auStack_340);
              pcVar25 = local_5d8;
              func_0x0001803ea140(auStack_310,auStack_9fc);
              uVar33 = FUN_1801be340(auStack_340);
              puVar37 = auStack_9f8;
            }
            pcStack_bf8 = pcVar25;
            puVar29 = (undefined4 *)FUN_1801b3ec0(puVar37,uVar33,0xd);
            func_0x0001801be350(uVar32,*puVar29,0);
            uVar32 = FUN_1801be340(local_5d0);
            uVar33 = func_0x0001801dbd60(auStack_868,auStack_340);
            FUN_1803bd970(uVar32,uVar33,0);
            FUN_1801be880(auStack_340);
            thunk_FUN_1801a2650(auStack_538);
            FUN_1803e91d0(&uStack_5b8);
            break;
          }
        }
      }
      goto code_r0x0001803dc89c;
    case '\r':
      lVar23 = func_0x0001803d06b0(pcVar31);
      if (lVar23 != 0) {
        uVar32 = FUN_1801b2640(lVar23);
        uVar7 = FUN_1801b2610(lVar23);
        lVar27 = FUN_1801be340(local_5d0);
        cVar5 = func_0x0001803d80d0(lVar27 + 0x130,uVar7,uVar32);
        if (cVar5 != '\0') {
          uVar32 = func_0x0001801a8a50(&DAT_180d6e440);
          uVar32 = func_0x0001801b3e60(uVar32);
          FUN_1801b2640(lVar23);
          uVar7 = FUN_1801b2610(lVar23);
          FUN_1803d8140(&uStack_1a8,uVar32,uVar7);
          cVar5 = func_0x0001801a4330(&uStack_1a8);
          if ((cVar5 != '\0') && (cVar5 = FUN_1801a8570(uVar32,uStack_1a8), cVar5 != '\0'))
          goto code_r0x0001803dcc97;
        }
      }
      goto code_r0x0001803dc89c;
    case '\x0e':
      lVar23 = FUN_1801be340(local_5d0);
      cVar5 = FUN_180393770(lVar23 + 0x130,0);
      if (cVar5 == '\0') goto code_r0x0001803dbfe8;
      uVar32 = func_0x0001803d0700(pcVar31);
      lVar23 = FUN_1801b2130(uVar32);
      lVar27 = func_0x0001803d3d50(uVar32);
      if (lVar23 == 0) {
        uVar43 = auVar72._0_8_;
        uVar33 = uVar43;
        uVar38 = uVar43;
      }
      else {
        uVar33 = func_0x0001801b1a00(lVar23);
        uVar38 = func_0x0001801b1a10(lVar23);
        uVar43 = func_0x0001801b1a20(lVar23);
      }
      func_0x0001801b19e0(&uStack_d0,uVar33,uVar38,uVar43);
      if (lVar27 == 0) {
        uVar43 = auVar72._0_8_;
        uVar33 = uVar43;
        uVar38 = uVar43;
      }
      else {
        auVar44._0_8_ = func_0x0001801b1a00(lVar27);
        auVar44._8_56_ = extraout_var;
        auVar66 = ZEXT1664(auVar44._0_16_);
        auVar45._0_8_ = func_0x0001801b1a10(lVar27);
        auVar45._8_56_ = extraout_var_00;
        auVar69 = ZEXT1664(auVar45._0_16_);
        uVar43 = func_0x0001801b1a20(lVar27);
        uVar33 = auVar66._0_8_;
        uVar38 = auVar69._0_8_;
      }
      func_0x0001801b19e0(&uStack_b0,uVar33,uVar38,uVar43);
      uVar33 = func_0x00018041a2d0();
      uVar21 = func_0x0001803d3dc0(uVar32);
      func_0x0001803d3d90(uVar32);
      uStack_a48 = uStack_b0;
      uStack_a40 = uStack_a8;
      uStack_a58 = uStack_d0;
      uStack_a50 = uStack_c8;
      pcStack_bf8 = (char *)CONCAT44(pcStack_bf8._4_4_,uVar21);
      FUN_18041a2e0(uVar33,&uStack_a58,&uStack_a48);
      break;
    case '\x0f':
      lVar23 = FUN_1801be340(local_5d0);
      cVar5 = FUN_180393770(lVar23 + 0x130,0);
      if (cVar5 != '\0') {
        uVar32 = func_0x0001803d0750(pcVar31);
        cVar5 = FUN_1803ce340(uVar32);
        if (cVar5 != '\0') {
          uVar32 = FUN_180233850();
          FUN_180233bb0(uVar32);
          uVar32 = FUN_18041d7e0();
          FUN_18041db50(uVar32);
          uVar32 = func_0x00018041a550();
          FUN_18041a560(uVar32,0);
        }
        uVar32 = func_0x00018041a2d0();
        FUN_18041a3b0(uVar32,cVar5);
        goto code_r0x0001803dc592;
      }
      goto code_r0x0001803dbfe8;
    case '\x10':
      lVar23 = func_0x0001803d07a0(pcVar31);
      if ((lVar23 != 0) && (lVar27 = FUN_1801b2410(lVar23), lVar27 != 0)) {
        uVar32 = FUN_1801b2410(lVar23);
        uVar32 = FUN_1801c6a50(uVar32,auStack_790);
        func_0x0001803e8db0(&DAT_180d6ea00,uVar32);
      }
      goto code_r0x0001803dc592;
    case '\x11':
      lVar23 = FUN_1801be340(local_5d0);
      cVar5 = FUN_180393770(lVar23 + 0x130,0);
      if (cVar5 == '\0') {
        lVar23 = FUN_1801be340(local_5d0);
        cVar5 = FUN_180393770(lVar23 + 0x130,7);
        if (cVar5 == '\0') {
          func_0x0001803e8ad0(&DAT_180d6ea00);
          goto code_r0x0001803dbfe8;
        }
      }
      uVar32 = func_0x0001803d07f0(pcVar31);
      FUN_1801a6370(auStack_668,0x18);
      func_0x0001801a8e50(auStack_668);
      lVar23 = FUN_1801b2410(uVar32);
      if (lVar23 != 0) {
        uVar33 = FUN_1801b2410(uVar32);
        uVar21 = FUN_1801be960(uVar33);
        FUN_1803e9620(auStack_668,uVar21);
        uVar32 = FUN_1801b2410(uVar32);
        func_0x00018023a700(uVar32,auStack_3b8);
        func_0x0001803ea160(uVar32,auStack_180);
        cVar5 = func_0x0001803e92a0(auStack_3b8,auStack_180);
        while (cVar5 != '\0') {
          uVar32 = FUN_1801be340(auStack_3b8);
          uVar21 = func_0x0001801b1a00(uVar32);
          local_b78._0_4_ = uVar21;
          auVar70._0_8_ = func_0x0001801b1a10(uVar32);
          auVar70._8_56_ = extraout_var_01;
          auVar66 = ZEXT1664(auVar70._0_16_);
          uVar33 = func_0x0001801b1a20(uVar32);
          func_0x0001801b19e0(local_b78 + 4,auVar66._0_8_,auVar72._0_8_,uVar33);
          uStack_b68 = func_0x000180354f90(uVar32);
          FUN_1803e96d0(auStack_668,local_b78);
          func_0x0001803e92b0(auStack_3b8);
          cVar5 = func_0x0001803e92a0(auStack_3b8,auStack_180);
        }
      }
      uStack_9c0 = func_0x0001803e95f0(auStack_668);
      func_0x0001803e8ae0(&DAT_180d6ea00,&uStack_9c0);
      cVar5 = func_0x0001803e9610(auStack_668);
      if (cVar5 == '\0') {
        uVar32 = func_0x00018041a2d0();
        FUN_18041a3b0(uVar32,0);
        uVar32 = func_0x00018041a550();
        FUN_18041a560(uVar32,0);
      }
      uVar32 = FUN_18041d7e0();
      uVar33 = func_0x0001803e9830(&uStack_5b8,auStack_668);
      FUN_18041d850(uVar32,uVar33);
      pcVar25 = local_5d8;
      uVar32 = FUN_1801be340(local_5d0);
      FUN_1803d9e90(uVar32,pcVar25);
      FUN_18022fbb0(auStack_668);
      break;
    case '\x12':
      func_0x0001803d0840(pcVar31);
      pcVar25 = local_5d8;
      uVar32 = FUN_1801be340(local_5d0);
      FUN_1803e4900(param_1,uVar32,pcVar25);
      break;
    case '\x13':
      lVar23 = func_0x0001803d5ba0(pcVar31);
      if (lVar23 == 0) goto code_r0x0001803dbfe8;
      FUN_1801d9500(auStack_220,param_1 + 0xb8);
      FUN_1801b6400(auStack_358,8);
      uVar32 = FUN_1801be340(local_5d0);
      uVar32 = func_0x0001803bdcf0(uVar32);
      FUN_1803e9bd0(param_1 + 0x108,auStack_358,uVar32);
      uVar32 = func_0x0001803e9b00(param_1 + 0x108,auStack_9a0);
      cVar5 = func_0x0001803e98f0(auStack_358,uVar32);
      if (cVar5 == '\0') {
        lVar27 = func_0x0001803e9900(auStack_358);
        lVar27 = FUN_1801be340(lVar27 + 0x10);
        uVar7 = FUN_1803ce340(lVar23);
        FUN_1801ad990(lVar27 + 0x145,uVar7,0);
        lVar27 = func_0x0001803e9900(auStack_358);
        lVar27 = FUN_1801be340(lVar27 + 0x10);
        uVar7 = func_0x0001803ce5c0(lVar23);
        FUN_1801ad990(lVar27 + 0x146,uVar7,0);
        func_0x0001803e5310(param_1);
        func_0x0001801d94f0(auStack_220);
        goto code_r0x0001803dc592;
      }
      func_0x0001801d94f0(auStack_220);
      break;
    default:
      uVar18 = FUN_1801c6d70(pcVar31,4);
      if (uVar18 == 0) {
        local_b3d = '\0';
      }
      else {
        local_b3d = pcVar31[uVar18];
      }
      FUN_1803f60c0(&DAT_180d6ea00,&local_b3d);
      uVar32 = local_5d0._0_8_;
      pcVar25 = local_5d8;
      goto code_r0x0001803e338a;
    case '\x16':
      lVar23 = func_0x0001803d0930(pcVar31);
      if (lVar23 != 0) {
        uVar32 = FUN_1801b2640(lVar23);
        uVar7 = FUN_1801b2610(lVar23);
        lVar27 = FUN_1801be340(local_5d0);
        cVar5 = func_0x0001803d80d0(lVar27 + 0x130,uVar7,uVar32);
        if (cVar5 != '\0') {
          uVar32 = func_0x0001801a8a50(&DAT_180d6e440);
          uVar32 = func_0x0001801b3e60(uVar32);
          FUN_1801b2640(lVar23);
          uVar7 = FUN_1801b2610(lVar23);
          FUN_1803d8140(&uStack_1c0,uVar32,uVar7);
          cVar5 = func_0x0001801a4330(&uStack_1c0);
          if (cVar5 != '\0') {
            FUN_1801a6370(&uStack_5b8,0x18);
            func_0x0001801a8e50(&uStack_5b8);
            lVar27 = FUN_1801ccce0(lVar23);
            if (lVar27 != 0) {
              uVar33 = FUN_1801ccce0(lVar23);
              func_0x00018023a700(uVar33,auStack_410);
              FUN_1801be970(uVar33,auStack_1b8);
              cVar5 = func_0x0001803e92a0(auStack_410,auStack_1b8);
              while (cVar5 != '\0') {
                uVar33 = func_0x0001803ea1a0(auStack_410);
                func_0x0001803e38d0(auStack_648);
                lVar23 = FUN_1801b2410(uVar33);
                if (lVar23 != 0) {
                  uVar38 = FUN_1801b2410(uVar33);
                  func_0x00018023a700(uVar38,auStack_408);
                  FUN_1801be970(uVar38,auStack_1b0);
                  cVar5 = func_0x0001803e92a0(auStack_408,auStack_1b0);
                  while (cVar5 != '\0') {
                    uVar38 = func_0x0001803ea1a0(auStack_408);
                    uVar38 = FUN_1801c6a50(uVar38,auStack_6a0);
                    FUN_1803e9090(auStack_648,uVar38);
                    func_0x00018023ab90(auStack_408);
                    cVar5 = func_0x0001803e92a0(auStack_408,auStack_1b0);
                  }
                }
                lVar23 = FUN_1801b2640(uVar33);
                if (lVar23 != 0) {
                  uVar38 = FUN_1801b2640(uVar33);
                  uVar38 = FUN_1801c6b40(uVar38,&puStack_578);
                  FUN_180181710(auStack_630,uVar38);
                  thunk_FUN_1801a2650(&puStack_578);
                }
                lVar23 = FUN_1801ccce0(uVar33);
                if (lVar23 != 0) {
                  uVar33 = FUN_1801ccce0(uVar33);
                  uVar33 = FUN_1801c6b40(uVar33,&puStack_578);
                  FUN_180181710(auStack_610,uVar33);
                  thunk_FUN_1801a2650(&puStack_578);
                }
                FUN_1803e9120(&uStack_5b8,auStack_648);
                FUN_1803e3aa0(auStack_648);
                func_0x00018023ab90(auStack_410);
                cVar5 = func_0x0001803e92a0(auStack_410,auStack_1b8);
              }
            }
            FUN_1801a2420(auStack_538);
            pauVar28 = (undefined1 (*) [16])func_0x0001803e90f0(auStack_690,&uStack_5b8);
            local_b78 = *pauVar28;
            iVar19 = FUN_1801a8250(uVar32,uStack_1c0,local_b78,auStack_538);
            if (iVar19 == 1) {
              pcVar31 = "not a stream texture";
            }
            else if (iVar19 == 2) {
              pcVar31 = "already connected";
            }
            else {
              pcVar31 = "failed to create SDP offer";
              if (iVar19 == 0) {
                pcVar31 = pcVar25;
              }
            }
            FUN_18019fc10(auStack_250,0x10);
            uStack_b10 = 0x100;
            FUN_1801e5bf0(auStack_250,&uStack_b10);
            if (pcVar31 == (char *)0x0) {
              pcVar25 = (char *)FUN_1801a20f0(auStack_538);
            }
            uVar32 = FUN_1801be340(auStack_250);
            FUN_1803cc290(auStack_274,uVar32,pcVar25,pcVar31);
            uVar32 = FUN_1801be340(auStack_250);
            pcVar25 = local_5d8;
            func_0x0001803ea140(auStack_274,auStack_9f4);
            uVar33 = FUN_1801be340(auStack_250);
            pcStack_bf8 = pcVar25;
            puVar29 = (undefined4 *)FUN_1801b3ec0(auStack_9f0,uVar33,0x17);
            func_0x0001801be350(uVar32,*puVar29,0);
            uVar32 = FUN_1801be340(local_5d0);
            uVar33 = func_0x0001801dbd60(auStack_858,auStack_250);
            FUN_1803bd970(uVar32,uVar33,0);
            FUN_1801be880(auStack_250);
            thunk_FUN_1801a2650(auStack_538);
            FUN_1803e91d0(&uStack_5b8);
            break;
          }
        }
      }
      goto code_r0x0001803dc89c;
    case '\x17':
      lVar23 = func_0x0001803d0980(pcVar31);
      if ((lVar23 != 0) && (lVar27 = FUN_1801ccce0(lVar23), lVar27 != 0)) {
        uVar32 = FUN_1801b2640(lVar23);
        uVar7 = FUN_1801b2610(lVar23);
        lVar27 = FUN_1801be340(local_5d0);
        cVar5 = func_0x0001803d80d0(lVar27 + 0x130,uVar7,uVar32);
        if (cVar5 != '\0') {
          uVar32 = func_0x0001801a8a50(&DAT_180d6e440);
          uVar32 = func_0x0001801b3e60(uVar32);
          FUN_1801b2640(lVar23);
          uVar7 = FUN_1801b2610(lVar23);
          FUN_1803d8140(&uStack_1c8,uVar32,uVar7);
          cVar5 = func_0x0001801a4330(&uStack_1c8);
          if (cVar5 != '\0') {
            uVar33 = FUN_1801ccce0(lVar23);
            pauVar28 = (undefined1 (*) [16])FUN_1801c6a50(uVar33,auStack_680);
            local_b78 = *pauVar28;
            iVar19 = FUN_1801a8310(uVar32,uStack_1c8,local_b78);
            if (iVar19 == 0) goto code_r0x0001803dcc97;
          }
        }
      }
      goto code_r0x0001803dc89c;
    case '\x18':
      lVar23 = func_0x0001803d09d0(pcVar31);
      if (lVar23 != 0) {
        uVar32 = FUN_1801b2640(lVar23);
        uVar7 = FUN_1801b2610(lVar23);
        lVar27 = FUN_1801be340(local_5d0);
        cVar5 = func_0x0001803d80d0(lVar27 + 0x130,uVar7,uVar32);
        if (cVar5 != '\0') {
          uVar32 = func_0x0001801a8a50(&DAT_180d6e440);
          uVar32 = func_0x0001801b3e60(uVar32);
          FUN_1801b2640(lVar23);
          uVar7 = FUN_1801b2610(lVar23);
          FUN_1803d8140(&uStack_1d0,uVar32,uVar7);
          func_0x0001803e3910(auStack_668);
          cVar5 = func_0x0001801a4330(&uStack_1d0);
          if ((cVar5 != '\0') &&
             (cVar5 = FUN_1801a83d0(uVar32,uStack_1d0,auStack_668), cVar5 != '\0')) {
            puVar29 = &DAT_180c62338;
            if (auStack_668[1] == '\x01') {
              puVar29 = &DAT_180c6231c;
            }
            if (auStack_668[0] == '\x04') {
              pcVar25 = "Peer connection failed";
            }
            FUN_18019fc10(auStack_240,0x10);
            uStack_b0c = 0x100;
            FUN_1801e5bf0(auStack_240,&uStack_b0c);
            uVar32 = FUN_1801be340(auStack_240);
            puStack_be8 = puStack_658;
            ppuStack_bf0 = (undefined **)CONCAT44(ppuStack_bf0._4_4_,auStack_668._8_4_);
            pcStack_bf8 = (char *)CONCAT44(pcStack_bf8._4_4_,auStack_668._4_4_);
            pcStack_be0 = pcVar25;
            FUN_1803cc9d0(auStack_278,uVar32,auStack_668[0],puVar29);
            uVar32 = FUN_1801be340(auStack_240);
            pcVar25 = local_5d8;
            func_0x0001803ea140(auStack_278,auStack_9ec);
            uVar33 = FUN_1801be340(auStack_240);
            pcStack_bf8 = pcVar25;
            puVar29 = (undefined4 *)FUN_1801b3ec0(auStack_a28,uVar33,0x18);
            func_0x0001801be350(uVar32,*puVar29,0);
            uVar32 = FUN_1801be340(local_5d0);
            uVar33 = func_0x0001801dbd60(auStack_848,auStack_240);
            FUN_1803bd970(uVar32,uVar33,0);
            FUN_1801be880(auStack_240);
            break;
          }
        }
      }
code_r0x0001803dc89c:
      pcVar25 = local_5d8;
      uVar32 = FUN_1801be340(local_5d0);
      FUN_1803da020(uVar32,pcVar25);
      break;
    case '\x19':
      lVar23 = FUN_1801be340(local_5d0);
      cVar5 = func_0x0001803d80a0(lVar23 + 0x130);
      if (cVar5 == '\0') goto code_r0x0001803dbfe8;
      lVar23 = func_0x0001803d0a20(pcVar31);
      cVar5 = func_0x0001801a8a40(&DAT_180d6e440);
      if (cVar5 != '\0') {
        uVar32 = func_0x0001801a8a50(&DAT_180d6e440);
        pcVar25 = (char *)func_0x0001801acb60(uVar32);
      }
      if ((lVar23 == 0) || (pcVar25 == (char *)0x0)) goto code_r0x0001803dcd89;
      uVar7 = FUN_1801b2760(lVar23);
      uVar8 = func_0x0001803d3e50(lVar23);
      uVar9 = FUN_1801b3120(lVar23);
      auVar68._0_8_ = func_0x0001803d3e20(lVar23);
      auVar68._8_56_ = extraout_var_02;
      auVar70 = ZEXT1664(auVar68._0_16_);
      auVar67._0_8_ = func_0x0001803d3df0(lVar23);
      auVar67._8_56_ = extraout_var_03;
      auVar68 = ZEXT1664(auVar67._0_16_);
      auVar46._0_8_ = func_0x0001803ce5f0(lVar23);
      auVar46._8_56_ = extraout_var_04;
      auVar69 = ZEXT1664(auVar46._0_16_);
      auVar47._0_8_ = func_0x0001803ce3a0(lVar23);
      auVar47._8_56_ = extraout_var_05;
      auVar66 = ZEXT1664(auVar47._0_16_);
      uVar10 = FUN_1803ce340(lVar23);
      uStack_bd8 = CONCAT31(uStack_bd8._1_3_,uVar7);
      pcStack_be0 = (char *)CONCAT71(pcStack_be0._1_7_,uVar8);
      puStack_be8 = (undefined1 *)CONCAT71(puStack_be8._1_7_,uVar9);
      ppuStack_bf0 = (undefined **)CONCAT44(ppuStack_bf0._4_4_,auVar70._0_4_);
      pcStack_bf8 = (char *)CONCAT44(pcStack_bf8._4_4_,auVar68._0_4_);
      FUN_1801fa310(pcVar25,uVar10,auVar66._0_8_,auVar69._0_8_);
      pcVar25 = local_5d8;
      uVar32 = FUN_1801be340(local_5d0);
      FUN_1803d9e90(uVar32,pcVar25);
      break;
    case '\x1a':
      lVar23 = FUN_1801be340(local_5d0);
      cVar5 = func_0x0001803d80a0(lVar23 + 0x130);
      if (cVar5 == '\0') goto code_r0x0001803dbfe8;
      FUN_180420e40(auStack_668);
      FUN_18019fc10(auStack_260,0x10);
      uStack_ad4 = 0x40;
      FUN_1801e5bf0(auStack_260,&uStack_ad4);
      cVar5 = func_0x0001801c6d90(auStack_668);
      if (cVar5 == '\0') {
        auVar66 = ZEXT1664(auVar72._0_16_);
      }
      else {
        lVar23 = FUN_1801a0430(auStack_668);
        auVar66 = ZEXT464(*(uint *)(lVar23 + 0xc));
      }
      cVar5 = func_0x0001801c6d90(auStack_668);
      if (cVar5 == '\0') {
        auVar69 = ZEXT1664(auVar72._0_16_);
      }
      else {
        lVar23 = FUN_1801a0430(auStack_668);
        auVar69 = ZEXT464(*(uint *)(lVar23 + 8));
      }
      cVar5 = func_0x0001801c6d90(auStack_668);
      if (cVar5 == '\0') {
        auVar68 = ZEXT1664(auVar72._0_16_);
      }
      else {
        lVar23 = FUN_1801a0430(auStack_668);
        auVar68 = ZEXT464(*(uint *)(lVar23 + 4));
      }
      cVar5 = func_0x0001801c6d90(auStack_668);
      if (cVar5 == '\0') {
        auVar67 = ZEXT1664(auVar72._0_16_);
      }
      else {
        puVar30 = (uint *)FUN_1801a0430(auStack_668);
        auVar67 = ZEXT464(*puVar30);
      }
      uVar7 = func_0x0001801c6d90(auStack_668);
      uVar32 = FUN_1801be340(auStack_260);
      puStack_be8 = (undefined1 *)CONCAT44(puStack_be8._4_4_,auVar66._0_4_);
      ppuStack_bf0 = (undefined **)CONCAT44(ppuStack_bf0._4_4_,auVar69._0_4_);
      pcStack_bf8 = (char *)CONCAT44(pcStack_bf8._4_4_,auVar68._0_4_);
      FUN_1803d6f70(auStack_290,uVar32,uVar7,auVar67._0_8_);
      uVar32 = FUN_1801be340(auStack_260);
      pcVar25 = local_5d8;
      func_0x0001803ea140(auStack_290,auStack_a78);
      uVar33 = FUN_1801be340(auStack_260);
      pcStack_bf8 = pcVar25;
      puVar29 = (undefined4 *)FUN_1801b3ec0(auStack_a7c,uVar33,0x19);
      func_0x0001801be350(uVar32,*puVar29,0);
      uVar32 = FUN_1801be340(local_5d0);
      uVar33 = func_0x0001801dbd60(auStack_8c8,auStack_260);
      FUN_1803bd970(uVar32,uVar33,0);
      FUN_1801be880(auStack_260);
      break;
    case '\x1b':
      lVar23 = func_0x0001803d0ac0(pcVar31);
      pcVar31 = pcVar25;
      if (lVar23 != 0) {
        pcVar31 = (char *)FUN_1801b2130(lVar23);
      }
      lVar23 = FUN_180420df0();
      if (lVar23 != 0) {
        pcVar25 = (char *)FUN_1804212b0(lVar23);
      }
      if ((pcVar31 != (char *)0x0) && (pcVar25 != (char *)0x0)) {
        uVar32 = func_0x00018041a2d0();
        FUN_18041a3b0(uVar32,0);
        uVar32 = FUN_180233850();
        FUN_180233bb0(uVar32);
        uVar32 = FUN_18041d7e0();
        FUN_18041db50(uVar32);
        uVar32 = func_0x00018041a550();
        FUN_18041a560(uVar32,0);
        uVar32 = func_0x0001804139a0();
        FUN_180413ac0(uVar32);
        FUN_180420ae0(pcVar25,0);
        auVar66._0_8_ = func_0x0001801b1a00(pcVar31);
        auVar66._8_56_ = extraout_var_06;
        auVar68 = ZEXT1664(auVar66._0_16_);
        auVar69._0_8_ = func_0x0001801b1a10(pcVar31);
        auVar69._8_56_ = extraout_var_07;
        auVar66 = ZEXT1664(auVar69._0_16_);
        uVar32 = func_0x0001801b1a20(pcVar31);
        puVar26 = (undefined8 *)func_0x0001801b19e0(auStack_810,auVar68._0_8_,auVar66._0_8_,uVar32);
        uStack_a68 = *puVar26;
        uStack_a60 = *(undefined4 *)(puVar26 + 1);
        FUN_180420b40(pcVar25,&uStack_a68);
        goto code_r0x0001803dc592;
      }
      goto code_r0x0001803dbfe8;
    case '\x1c':
      lVar23 = FUN_1801be340(local_5d0);
      cVar5 = func_0x0001803d80b0(lVar23 + 0x130);
      if ((cVar5 != '\0') && (lVar23 = func_0x0001803d0b10(pcVar31), lVar23 != 0)) {
        func_0x0001803ce370(lVar23);
        cVar5 = func_0x000180194b30();
        if (cVar5 != '\0') {
          uStack_acc = func_0x0001803ce370(lVar23);
          uStack_ac8 = auVar72._0_4_;
          func_0x0001801de740(&uStack_ac8,&uStack_acc);
          uVar32 = FUN_1804214d0();
          cVar5 = func_0x0001803e8d90(uVar32);
          if (cVar5 != '\0') {
            cVar5 = FUN_1804215f0(uVar32);
            goto joined_r0x0001803de6f2;
          }
        }
      }
      goto code_r0x0001803dbfe8;
    case '\x1d':
      lVar23 = FUN_1801be340(local_5d0);
      cVar5 = func_0x0001803d80b0(lVar23 + 0x130);
      if (cVar5 == '\0') goto code_r0x0001803dbfe8;
      uVar32 = func_0x0001803e36c0(&uStack_5b8,local_5d0,&local_5d8);
      local_b78._0_8_ = uVar32;
      uVar33 = func_0x0001803e39d0(auStack_538,uVar32);
      FUN_1803e36f0(auStack_8f0,uVar33,0x14);
      local_b30 = uVar40 | 8;
      FUN_1802e3fe0(uVar32);
      func_0x0001803c39c0(auStack_8f0);
      break;
    case '\x1e':
      lVar23 = FUN_1801be340(local_5d0);
      cVar5 = func_0x0001803d80b0(lVar23 + 0x130);
      if ((cVar5 == '\0') || (lVar23 = func_0x0001803d0bb0(pcVar31), lVar23 == 0))
      goto code_r0x0001803dbfe8;
      func_0x00018038d8a0(auStack_558);
      func_0x0001803d3fd0(lVar23,auStack_554);
      cVar5 = FUN_1801b1a60(auStack_554);
      if (cVar5 != '\0') {
        uVar32 = FUN_1801a0430(auStack_554);
        func_0x0001803e8da0(&uStack_b17,uVar32);
        auStack_558[0] = uStack_b17;
      }
      uVar32 = func_0x0001803e37c0(&uStack_5b8,local_5d0,&local_5d8);
      local_b78._0_8_ = uVar32;
      uVar33 = func_0x0001803e3a60(auStack_538,uVar32);
      FUN_1803e3800(auStack_8b8,uVar33,0x14);
      local_b30 = uVar40 | 0x10;
      FUN_1802e3fe0(uVar32);
      func_0x0001803c39c0(auStack_8b8);
      break;
    case '\x1f':
      cVar5 = func_0x0001801c6d90(param_1 + 0x150);
      if (cVar5 != '\0') {
        uVar32 = FUN_1801a0430(param_1 + 0x150);
        uVar33 = FUN_1801be340(local_5d0);
        uVar33 = func_0x0001803bdcf0(uVar33);
        cVar5 = func_0x0001803a2320(uVar32,uVar33);
        if (cVar5 == '\0') goto code_r0x0001803dbfe8;
      }
      lVar23 = FUN_1801be340(local_5d0);
      bVar6 = func_0x0001803d80a0(lVar23 + 0x130);
      if (bVar6 == 0) {
        lVar23 = FUN_1801be340(local_5d0);
        cVar5 = FUN_180393770(lVar23 + 0x130,10);
        auStack_5be[0] = 0;
        if (cVar5 != '\0') goto code_r0x0001803dc87b;
      }
      else {
code_r0x0001803dc87b:
        auStack_5be[0] = 1;
      }
      cVar5 = func_0x0001801a8a40(&DAT_180d6e440);
      if (cVar5 == '\0') goto code_r0x0001803dc89c;
      lVar23 = func_0x0001803d0c00(pcVar31);
      if (((lVar23 == 0) || (lVar23 = FUN_1801b2410(lVar23), lVar23 == 0)) ||
         (iVar19 = FUN_1801be960(lVar23), iVar19 == 0)) {
        uVar32 = func_0x0001801a8a50(&DAT_180d6e440);
        uVar32 = func_0x0001801fe740(uVar32);
        uVar33 = FUN_180199ea0(auStack_9b0,0);
        FUN_1801d5750(uVar32,uVar33);
        pcVar25 = local_5d8;
        uVar32 = FUN_1801be340(local_5d0);
        FUN_1803d9e90(uVar32,pcVar25);
      }
      else {
        cStack_5c0 = '\0';
        FUN_18019fc10(auStack_230,0x10);
        uVar32 = func_0x0001803e36b0(auStack_b20,auStack_5be);
        func_0x0001803e8af0(auStack_648,uVar32);
        uVar32 = func_0x0001803ea180(lVar23);
        uVar21 = FUN_1801be960(lVar23);
        pauVar28 = (undefined1 (*) [16])func_0x0001801c7890(auStack_7c0,uVar32,uVar21);
        local_b78 = *pauVar28;
        pcStack_bf8 = &cStack_5c0;
        FUN_1801cfc80(auStack_230,local_b78,bVar6 ^ 1);
        FUN_1801ac0b0(auStack_648);
        cVar5 = FUN_1801d9760(auStack_230);
        if (cVar5 == '\0') {
          uStack_b57 = func_0x0001801be360(cStack_5c0);
          func_0x0001803e8b10(&DAT_180d6ea00,&uStack_b57);
          pcVar25 = local_5d8;
          uVar32 = FUN_1801be340(local_5d0);
          FUN_1803da020(uVar32,pcVar25);
        }
        else {
          uVar32 = func_0x0001801a8a50(&DAT_180d6e440);
          uVar32 = func_0x0001801fe740(uVar32);
          uVar33 = func_0x0001801dbd60(auStack_958,auStack_230);
          FUN_1801d5750(uVar32,uVar33);
          pcVar25 = local_5d8;
          uVar32 = FUN_1801be340(local_5d0);
          FUN_1803d9e90(uVar32,pcVar25);
        }
        FUN_1801be880(auStack_230);
      }
      break;
    case ' ':
      cVar5 = func_0x0001801c6d90(param_1 + 0x150);
      if (cVar5 != '\0') {
        uVar32 = FUN_1801a0430(param_1 + 0x150);
        uVar33 = FUN_1801be340(local_5d0);
        uVar33 = func_0x0001803bdcf0(uVar33);
        cVar5 = func_0x0001803a2320(uVar32,uVar33);
        if (cVar5 == '\0') goto code_r0x0001803dc89c;
      }
      lVar23 = func_0x0001803d0c50(pcVar31);
      if ((lVar23 == 0) || (cVar5 = func_0x0001801a8a40(&DAT_180d6e440), cVar5 == '\0'))
      goto code_r0x0001803dc89c;
      uVar32 = func_0x0001801a8a50(&DAT_180d6e440);
      uVar32 = func_0x0001801fe740(uVar32);
      func_0x0001803d7ae0(uVar32,0);
      func_0x0001803e9b90(param_1 + 0x150);
      uVar32 = func_0x0001801a8a50(&DAT_180d6e440);
      lVar27 = func_0x0001801b3e70(uVar32);
      if (lVar27 != 0) {
        ppuStack_bc0 = (undefined **)((ulonglong)ppuStack_bc0 & 0xffffffffffffff00);
        ppuStack_bc8 = (undefined **)((ulonglong)ppuStack_bc8 & 0xffffffff00000000);
        uStack_bd0 = 0;
        uStack_bd8 = 0;
        pcStack_be0 = (char *)((ulonglong)pcStack_be0 & 0xffffffff00000000);
        puStack_be8 = (undefined1 *)((ulonglong)puStack_be8 & 0xffffffff00000000);
        ppuStack_bf0 = (undefined **)((ulonglong)ppuStack_bf0 & 0xffffffffffffff00);
        pcStack_bf8 = (char *)CONCAT44(pcStack_bf8._4_4_,auVar72._0_4_);
        FUN_1801dfa00(lVar27,0,0);
      }
      uVar32 = func_0x0001801a8a50(&DAT_180d6e440);
      uVar32 = func_0x0001801fe740(uVar32);
      auStack_648[0] = FUN_1801b2610(lVar23);
      lVar27 = FUN_1801b2640(lVar23);
      if (lVar27 == 0) {
        uVar33 = FUN_1801a2420(&lStack_5b0);
      }
      else {
        uVar33 = FUN_1801b2640(lVar23);
        uVar33 = FUN_1801c6b40(uVar33,&lStack_5b0);
      }
      func_0x0001801a1d60(alStack_640,uVar33);
      uStack_620 = func_0x0001803ce5f0(lVar23);
      uStack_61c = FUN_1801b30f0(lVar23);
      uStack_618 = func_0x0001803d4610(lVar23);
      uStack_614 = FUN_1801b2700(lVar23);
      uVar33 = func_0x0001801dcb30(auStack_538,auStack_648);
      FUN_1801d57f0(uVar32,uVar33);
      func_0x0001801cfc70(auStack_648);
code_r0x0001803dcc97:
      pcVar25 = local_5d8;
      uVar32 = FUN_1801be340(local_5d0);
      FUN_1803d9e90(uVar32,pcVar25);
      break;
    case '!':
      cVar5 = func_0x0001801a8a40(&DAT_180d6e440);
      if (cVar5 == '\0') goto code_r0x0001803dbfe8;
      uVar32 = func_0x0001801a8a50(&DAT_180d6e440);
      uVar32 = func_0x0001801fe740(uVar32);
      FUN_1801d6e40(uVar32,auStack_648);
      func_0x0001803e3a40(&uStack_4d8,0x80);
      pcStack_bf8 = (char *)0x8;
      func_0x0001803ea1d0(&uStack_4d8,0x200,0,0);
      FUN_1801a6370(&puStack_578,0x18);
      func_0x0001801a8e50(&puStack_578);
      uVar32 = func_0x0001803e95d0(auStack_628);
      FUN_1801d9870(&puStack_578,uVar32);
      lVar23 = FUN_1801be340(auStack_628);
      lVar27 = FUN_1802a43e0(auStack_628);
      for (; lVar23 != lVar27; lVar23 = lVar23 + 0x58) {
        pcVar25 = (char *)FUN_1801a20f0(lVar23 + 0x20);
        uVar7 = *(undefined1 *)(lVar23 + 0x50);
        uVar8 = *(undefined1 *)(lVar23 + 0x51);
        uVar32 = *(undefined8 *)(lVar23 + 0x48);
        auVar66 = ZEXT464(*(uint *)(lVar23 + 0x40));
        uVar33 = FUN_1801a20f0(lVar23);
        puStack_be8 = (undefined1 *)CONCAT71(puStack_be8._1_7_,uVar7);
        ppuStack_bf0 = (undefined **)CONCAT71(ppuStack_bf0._1_7_,uVar8);
        pcStack_bf8 = (char *)uVar32;
        pcStack_be0 = pcVar25;
        uVar32 = FUN_1803d7510(auStack_a34,&uStack_4d8,uVar33,auVar66._0_8_);
        FUN_180181510(&puStack_578,uVar32);
      }
      FUN_1801a6370(apuStack_550,0x18);
      func_0x0001801a8e50(apuStack_550);
      uVar32 = func_0x0001801d9630(auStack_5f8);
      FUN_1801d9870(apuStack_550,uVar32);
      lVar23 = FUN_1801be340(auStack_5f8);
      lVar27 = FUN_1802a43e0(auStack_5f8);
      for (; lVar23 != lVar27; lVar23 = lVar23 + 0x20) {
        uVar32 = *(undefined8 *)(lVar23 + 0x10);
        uVar33 = FUN_1801a20f0(lVar23);
        FUN_1801c5540(&uStack_4d8,uVar33,uVar32);
        iStack_ad8 = uStack_4a8;
        FUN_1802996d0(apuStack_550,&iStack_ad8);
      }
      auStack_538 = (undefined1  [16])0x0;
      uStack_528 = 0;
      FUN_1801d7d00(auStack_538);
      uVar32 = FUN_1801a20f0(auStack_648);
      pcStack_be0 = (char *)CONCAT71(pcStack_be0._1_7_,uStack_5e0);
      puStack_be8 = auStack_538;
      ppuStack_bf0 = apuStack_550;
      pcStack_bf8 = auStack_610;
      puVar29 = (undefined4 *)FUN_1803d77f0(auStack_a38,&uStack_4d8,uVar32,&puStack_578);
      FUN_1801c3db0(&uStack_4d8,*puVar29,0,0);
      auStack_270 = (undefined1  [16])0x0;
      uStack_b3c = uStack_4a8 + 0x40;
      FUN_1803e8c20(auStack_270,&uStack_b3c);
      uVar32 = uStack_498;
      iVar19 = uStack_4a8;
      uVar33 = auStack_270._0_8_;
      FUN_1801c3f20(auStack_270._0_8_,uStack_4a8,1);
      if (iVar19 != 0) {
        FUN_1801c3ea0(uVar33,uVar32,iVar19);
      }
      *(undefined1 *)(uVar33 + 0x60) = 0;
      uVar22 = FUN_1801bece0(uVar33,iVar19);
      uVar32 = auStack_270._0_8_;
      *(undefined1 *)(auStack_270._0_8_ + 0x60) = 1;
      uVar21 = *(undefined4 *)(auStack_270._0_8_ + 0x30);
      FUN_1803e6d60(auStack_270._0_8_,4,uVar22);
      FUN_1801be990(uVar32,uVar21);
      uVar32 = auStack_270._0_8_;
      pcStack_bf8 = local_5d8;
      puVar29 = (undefined4 *)FUN_1801b3ec0(auStack_a74,auStack_270._0_8_,0x1b);
      FUN_1801c3db0(uVar32,*puVar29,0);
      uVar32 = local_5d0._0_8_;
      auStack_668 = (undefined1  [16])0x0;
      func_0x0001801e5f50(auStack_668,auStack_270);
      local_b78._0_8_ = auStack_668;
      FUN_1803be5f0(uVar32 + 0x78,auStack_668);
      FUN_1801be880(auStack_668);
      FUN_1801be880(auStack_270);
      FUN_1801d97f0(auStack_538);
      FUN_1801a2440(apuStack_550);
      FUN_1801a2440(&puStack_578);
      FUN_1801c58d0(&uStack_4d8);
      FUN_1801dbc20(auStack_5f8);
      FUN_1801a2440(auStack_610);
      FUN_1801dbcb0(auStack_628);
      FUN_1801a2650(auStack_648);
      param_1 = local_b28;
      break;
    case '\"':
      lVar23 = func_0x0001803d5bf0(pcVar31);
      pcVar25 = local_5d8;
      if (lVar23 == 0) goto code_r0x0001803dbfe8;
      uVar32 = FUN_1801be340(local_5d0);
      FUN_1803e4a60(param_1,uVar32,pcVar25,lVar23);
      break;
    case '#':
      uVar32 = FUN_1801be340(local_5d0);
      FUN_1803e4f30(param_1,uVar32,pcVar4);
      break;
    case '$':
      lVar23 = func_0x0001803d5c40(pcVar31);
      pcVar25 = local_5d8;
      if (lVar23 == 0) goto code_r0x0001803dbfe8;
      uVar32 = FUN_1801be340(local_5d0);
      FUN_1803e4da0(param_1,uVar32,pcVar25,lVar23);
      break;
    case '%':
      uVar24 = func_0x0001803d5c90(pcVar31);
      uStack_b38 = uVar24;
      if (uVar24 == 0) goto code_r0x0001803dcd89;
      lVar23 = FUN_1801be340(local_5d0);
      cVar5 = func_0x0001803d80a0(lVar23 + 0x130);
      if (cVar5 == '\0') {
        lVar23 = FUN_1801be340(local_5d0);
        cVar5 = FUN_180393770(lVar23 + 0x130,10);
        if (cVar5 != '\0') goto code_r0x0001803dce01;
        lVar23 = FUN_1801be340(local_5d0);
        cVar5 = func_0x0001803d80b0(lVar23 + 0x130);
        if (cVar5 != '\0') goto code_r0x0001803dce01;
        bVar3 = false;
      }
      else {
code_r0x0001803dce01:
        bVar3 = true;
      }
      cVar5 = FUN_1803ce340(uVar24);
      if ((cVar5 == '\0') || (uStack_4d8 = 1, !bVar3)) {
        uStack_4d8 = 0;
      }
      cVar5 = func_0x0001803ce5c0(uVar24);
      if ((cVar5 == '\0') || (uStack_4d7 = 1, !bVar3)) {
        uStack_4d7 = 0;
      }
      uStack_4d4 = func_0x0001803d4d40(uVar24);
      uStack_4d0 = func_0x0001803d3df0(uVar24);
      uStack_4cc = func_0x0001803d3e20(uVar24);
      uStack_4c8 = FUN_1801b2700(uVar24);
      uStack_4c4 = func_0x0001803d4d70(uVar24);
      uStack_4c0 = func_0x0001803d5430(uVar24);
      uStack_4bc = func_0x0001803d4f80(uVar24);
      uStack_4b8 = func_0x0001803d5340(uVar24);
      uVar7 = func_0x0001803d4ef0(uVar24);
      uStack_4b4 = CONCAT31(uStack_4b4._1_3_,uVar7);
      uVar7 = func_0x0001803d5070(uVar24);
      uStack_4b4._0_2_ = CONCAT11(uVar7,(undefined1)uStack_4b4);
      uStack_4b0 = func_0x0001803d4f20(uVar24);
      uStack_4ac = func_0x0001803d4f50(uVar24);
      func_0x0001801a8e50(&uStack_4a8);
      func_0x0001801a8e50(auStack_490);
      func_0x0001801a8e50(auStack_478);
      func_0x0001801a8e50(auStack_460);
      uStack_448 = 0x6040908;
      uStack_444 = 0x507;
      uStack_440 = 0x706010c;
      uStack_43c = 0x3020504;
      uStack_438 = 0x1000908;
      uStack_430 = 0;
      uStack_42f = 0;
      uStack_42b = 0;
      uStack_429 = 0;
      lVar23 = func_0x0001803d4fb0(uVar24);
      if (lVar23 != 0) {
        uVar32 = FUN_1801be970(lVar23,auStack_990);
        uVar33 = func_0x00018023a700(lVar23,auStack_988);
        FUN_18023a600(auStack_478,uVar33,uVar32);
      }
      lVar23 = func_0x0001803d4fe0(uVar24);
      if (lVar23 != 0) {
        uVar32 = FUN_1801be970(lVar23,auStack_980);
        uVar33 = func_0x00018023a700(lVar23,auStack_978);
        FUN_18023a600(auStack_460,uVar33,uVar32);
      }
      lVar23 = func_0x0001803d5010(uVar24);
      if (lVar23 != 0) {
        uVar32 = FUN_1801be970(lVar23,auStack_970);
        uVar33 = func_0x00018023a700(lVar23,auStack_918);
        FUN_18023a600(&uStack_4a8,uVar33,uVar32);
      }
      lVar23 = func_0x0001803d5040(uVar24);
      if (lVar23 != 0) {
        uVar32 = FUN_1801be970(lVar23,auStack_8e0);
        uVar33 = func_0x00018023a700(lVar23,auStack_900);
        FUN_18023a600(auStack_490,uVar33,uVar32);
      }
      uVar7 = func_0x0001803d4da0(uVar24);
      uStack_448 = CONCAT31(uStack_448._1_3_,uVar7);
      uVar7 = func_0x0001803d4dd0(uVar24);
      uStack_448._0_2_ = CONCAT11(uVar7,(undefined1)uStack_448);
      uVar7 = func_0x0001803d4e00(uVar24);
      uVar8 = func_0x0001803d4e30(uVar24);
      uVar9 = func_0x0001803d4e60(uVar24);
      uVar10 = func_0x0001803d4e90(uVar24);
      uVar11 = func_0x0001803d4ec0(uVar24);
      uVar21 = uStack_444;
      uStack_448 = CONCAT13(uVar8,CONCAT12(uVar7,(undefined2)uStack_448));
      uStack_444._3_1_ = SUB41(uVar21,3);
      uStack_444._0_3_ = CONCAT12(uVar11,CONCAT11(uVar10,uVar9));
      uStack_b87 = func_0x0001803d50a0(uVar24);
      uStack_b86 = func_0x0001803d50d0(uVar24);
      uStack_b84 = func_0x0001803d5100(uVar24);
      uStack_b88 = func_0x0001803d5130(uVar24);
      uVar7 = func_0x0001803d5160(uVar24);
      uVar8 = func_0x0001803d5190(uVar24);
      uVar24 = uStack_b38;
      uVar9 = func_0x0001803d51c0(uStack_b38);
      uVar10 = func_0x0001803d5370(uVar24);
      uVar11 = func_0x0001803d53a0(uVar24);
      uVar12 = func_0x0001803d53d0(uVar24);
      uVar13 = func_0x0001803d5400(uStack_b38);
      uVar24 = uStack_b38;
      uStack_444 = CONCAT13(uStack_b87,(undefined3)uStack_444);
      uStack_440 = CONCAT13(uVar7,CONCAT12(uStack_b88,CONCAT11(uStack_b84,uStack_b86)));
      uStack_43c = CONCAT13(uVar11,CONCAT12(uVar10,CONCAT11(uVar9,uVar8)));
      uStack_438._0_2_ = CONCAT11(uVar13,uVar12);
      uVar7 = func_0x0001803d51f0(uStack_b38);
      uVar8 = func_0x0001803d5220(uVar24);
      uVar9 = func_0x0001803d5250(uVar24);
      uVar10 = func_0x0001803d5280(uVar24);
      uVar11 = func_0x0001803d52b0(uVar24);
      uVar12 = func_0x0001803d52e0(uVar24);
      uStack_430 = func_0x0001803d5310(uStack_b38);
      uStack_438 = CONCAT17(uVar12,CONCAT16(uVar11,CONCAT15(uVar10,CONCAT14(uVar9,CONCAT13(uVar8,
                                                  CONCAT12(uVar7,(undefined2)uStack_438))))));
      uVar32 = FUN_1804156c0();
      FUN_180415730(uVar32,&uStack_4d8);
      pcVar25 = local_5d8;
      uVar32 = FUN_1801be340(local_5d0);
      FUN_1803d9e90(uVar32,pcVar25);
      FUN_1803e3a00(&uStack_4d8);
      param_1 = local_b28;
      break;
    case '&':
      lVar23 = FUN_1801be340(local_5d0);
      cVar5 = func_0x0001803d80c0(lVar23 + 0x130);
      if (cVar5 != '\0') {
code_r0x0001803dd3c8:
        lVar23 = func_0x0001803d5ce0(pcVar31);
        if (lVar23 != 0) {
          pcVar25 = (char *)FUN_1801b2410(lVar23);
        }
        FUN_1803da580(param_1 + 0x180,*(undefined8 *)(param_1 + 0x198));
        if (pcVar25 == (char *)0x0) {
code_r0x0001803dd3fd:
          cVar5 = '\v';
        }
        else {
          cVar14 = func_0x0001801c6d90(param_1 + 0x180);
          if (cVar14 != '\0') {
            uVar32 = FUN_1801a0430(param_1 + 0x180);
            uVar33 = FUN_1801be340(local_5d0);
            uVar33 = func_0x0001803bdcf0(uVar33);
            cVar14 = func_0x0001803a2320(uVar32,uVar33);
            if (cVar14 == '\0') {
              cVar5 = '\x03';
              goto code_r0x0001803dd3ff;
            }
          }
          uVar32 = *(undefined8 *)(param_1 + 0x198);
          uVar33 = func_0x0001801b20b0(pcVar25);
          cVar14 = func_0x000180226340(uVar33,uVar32);
          if (cVar14 != '\0') {
            func_0x00018022f8f0(auStack_648);
            acStack_670[0] = '\0';
            cVar14 = FUN_180239680(pcVar25,auStack_648,acStack_670);
            if (cVar14 == '\0') {
              puVar26 = (undefined8 *)
                        FUN_1803da4e0(auStack_538,acStack_670[0],*(undefined8 *)(param_1 + 0x198));
              pcVar25 = local_5d8;
              uStack_5b8 = *puVar26;
              lStack_5b0 = puVar26[1];
              uStack_5a8 = puVar26[2];
              uStack_5a0 = puVar26[3];
              auVar72 = ZEXT1664(auVar72._0_16_);
              uVar32 = FUN_1801be340(local_5d0);
              FUN_1803da2f0(uVar32,pcVar25,&uStack_5b8);
              FUN_18022f920(auStack_648);
            }
            else if ((cVar5 == '\0') && (cVar5 = FUN_1803d7af0(pcVar25), cVar5 == '\0')) {
              puVar26 = (undefined8 *)func_0x0001803da560(auStack_538);
              pcVar25 = local_5d8;
              uStack_5b8 = *puVar26;
              lStack_5b0 = puVar26[1];
              uStack_5a8 = puVar26[2];
              uStack_5a0 = puVar26[3];
              auVar72 = ZEXT1664(auVar72._0_16_);
              uVar32 = FUN_1801be340(local_5d0);
              FUN_1803da2f0(uVar32,pcVar25,&uStack_5b8);
              FUN_18022f920(auStack_648);
            }
            else {
              alStack_640[0] = *(longlong *)(param_1 + 0x1a0) + 1;
              FUN_18019fc10(auStack_2b0,0x10);
              FUN_180199ea0(auStack_2b0);
              uVar32 = FUN_1803e8b20(auStack_968,auStack_648);
              FUN_1801d9770(auStack_2b0,uVar32);
              FUN_1801be880(auStack_968);
              uVar32 = FUN_18022bd70();
              uVar33 = func_0x00018022f410(auStack_8d8,auStack_2b0);
              acStack_670[0] = FUN_18022c460(uVar32,uVar33);
              if (acStack_670[0] == '\0') {
                uVar32 = FUN_1801be340(local_5d0);
                uVar32 = func_0x0001803bdcf0(uVar32);
                func_0x0001803e8bf0(param_1 + 0x180,uVar32);
                puVar26 = (undefined8 *)FUN_1801be340(auStack_2b0);
                *(undefined8 *)(param_1 + 0x198) = *puVar26;
                lVar23 = FUN_1801be340(auStack_2b0);
                *(undefined8 *)(param_1 + 0x1a0) = *(undefined8 *)(lVar23 + 8);
              }
              if (acStack_670[0] == '\0') {
                puVar26 = (undefined8 *)FUN_1803da490(auStack_538,*(undefined8 *)(param_1 + 0x198));
                auVar71 = auVar72._0_16_;
              }
              else {
                puVar26 = (undefined8 *)FUN_1803da4e0(&puStack_578,acStack_670[0]);
                auVar71 = auVar72._0_16_;
              }
              pcVar25 = local_5d8;
              uStack_5b8 = *puVar26;
              lStack_5b0 = puVar26[1];
              uStack_5a8 = puVar26[2];
              uStack_5a0 = puVar26[3];
              auVar72 = ZEXT1664(auVar71);
              uVar32 = FUN_1801be340(local_5d0);
              FUN_1803da2f0(uVar32,pcVar25,&uStack_5b8);
              FUN_1801be880(auStack_2b0);
              FUN_18022f920(auStack_648);
            }
            break;
          }
          cVar5 = '\x04';
        }
code_r0x0001803dd3ff:
        uVar32 = *(undefined8 *)(param_1 + 0x198);
        ppuVar39 = (undefined **)auStack_538;
code_r0x0001803dd40e:
        puVar26 = (undefined8 *)FUN_1803da4e0(ppuVar39,cVar5,uVar32);
        auVar71 = auVar72._0_16_;
        goto code_r0x0001803dd413;
      }
      cVar14 = func_0x0001801c6d90(param_1 + 0x150);
      if (cVar14 != '\0') {
        uVar32 = FUN_1801a0430(param_1 + 0x150);
        uVar33 = FUN_1801be340(local_5d0);
        uVar33 = func_0x0001803bdcf0(uVar33);
        cVar14 = func_0x0001803a2320(uVar32,uVar33);
        if (cVar14 != '\0') goto code_r0x0001803dd3c8;
      }
code_r0x0001803dd37e:
      puVar26 = (undefined8 *)func_0x0001803da560(auStack_538);
      auVar71 = auVar72._0_16_;
      goto code_r0x0001803dd38b;
    case '\'':
      lVar23 = FUN_1801be340(local_5d0);
      cVar5 = func_0x0001803d80c0(lVar23 + 0x130);
      if (cVar5 == '\0') {
        cVar5 = func_0x0001801c6d90(param_1 + 0x180);
        if (cVar5 != '\0') {
          uVar32 = FUN_1801a0430(param_1 + 0x180);
          uVar33 = FUN_1801be340(local_5d0);
          uVar33 = func_0x0001803bdcf0(uVar33);
          cVar5 = func_0x0001803a2320(uVar32,uVar33);
          if (cVar5 != '\0') goto code_r0x0001803dd805;
        }
        goto code_r0x0001803dd37e;
      }
code_r0x0001803dd805:
      lVar23 = func_0x0001803d5d30(pcVar31);
      FUN_1803da580(param_1 + 0x180,*(undefined8 *)(param_1 + 0x198));
      if (lVar23 == 0) goto code_r0x0001803dd3fd;
      cVar5 = func_0x0001801c6d90(param_1 + 0x180);
      if (cVar5 != '\0') {
        uVar32 = FUN_1801a0430(param_1 + 0x180);
        uVar33 = FUN_1801be340(local_5d0);
        uVar33 = func_0x0001803bdcf0(uVar33);
        cVar5 = func_0x0001803a2320(uVar32,uVar33);
        if (cVar5 == '\0') {
          cVar5 = '\x03';
          goto code_r0x0001803dd3ff;
        }
      }
      uVar32 = *(undefined8 *)(param_1 + 0x198);
      uVar33 = func_0x0001801b20b0(lVar23);
      cVar5 = func_0x000180226340(uVar33,uVar32);
      if (cVar5 == '\0') {
        cVar5 = '\x04';
        goto code_r0x0001803dd3ff;
      }
      uVar32 = FUN_18022bd70();
      lVar27 = *(longlong *)(param_1 + 0x1a0);
      uVar33 = func_0x0001801b20b0(lVar23);
      cVar5 = func_0x00018022c760(uVar32,uVar33,lVar27 + 1);
      if (cVar5 == '\0') {
        uVar32 = func_0x0001801b20b0(lVar23);
        *(undefined8 *)(param_1 + 0x198) = uVar32;
        *(longlong *)(param_1 + 0x1a0) = *(longlong *)(param_1 + 0x1a0) + 1;
        func_0x0001803e9b90(param_1 + 0x180);
      }
code_r0x0001803dd8ea:
      uVar32 = *(undefined8 *)(param_1 + 0x198);
      if (cVar5 != '\0') {
        ppuVar39 = &puStack_578;
        goto code_r0x0001803dd40e;
      }
      puVar26 = (undefined8 *)FUN_1803da490(auStack_538,uVar32);
      auVar71 = auVar72._0_16_;
code_r0x0001803dd413:
      pcVar25 = local_5d8;
      uStack_5b8 = *puVar26;
      lStack_5b0 = puVar26[1];
      uStack_5a8 = puVar26[2];
      uStack_5a0 = puVar26[3];
      auVar72 = ZEXT1664(auVar71);
      uVar32 = FUN_1801be340(local_5d0);
      FUN_1803da2f0(uVar32,pcVar25,&uStack_5b8);
      break;
    case '(':
      puVar26 = (undefined8 *)FUN_1803da490(&uStack_5b8,*(undefined8 *)(param_1 + 0x198));
      uStack_5b8 = *puVar26;
      lStack_5b0 = puVar26[1];
      uStack_5a8 = puVar26[2];
      uStack_5a0 = puVar26[3];
      auVar72 = ZEXT1664(auVar72._0_16_);
      FUN_1803da580(param_1 + 0x180,*(undefined8 *)(param_1 + 0x198));
      auVar71 = auVar72._0_16_;
      goto code_r0x0001803dd38f;
    case ')':
      lVar23 = FUN_1801be340(local_5d0);
      cVar5 = func_0x0001803d80c0(lVar23 + 0x130);
      if (cVar5 == '\0') goto code_r0x0001803dd37e;
      lVar23 = func_0x0001803d5d80(pcVar31);
      if (((lVar23 != 0) && (lVar27 = FUN_1801b2640(lVar23), lVar27 != 0)) &&
         (lVar27 = FUN_1801ccce0(lVar23), lVar27 != 0)) {
        uVar32 = FUN_1801b2640(lVar23);
        cVar5 = func_0x0001801beb60(uVar32);
        if (cVar5 == '\0') {
          uVar32 = FUN_1801ccce0(lVar23);
          cVar5 = func_0x0001801beb60(uVar32);
          if (cVar5 == '\0') {
            FUN_1803da580(param_1 + 0x180,*(undefined8 *)(param_1 + 0x198));
            cVar5 = func_0x0001801c6d90(param_1 + 0x180);
            if (cVar5 != '\0') {
              uVar32 = FUN_1801a0430(param_1 + 0x180);
              uVar33 = FUN_1801be340(local_5d0);
              uVar33 = func_0x0001803bdcf0(uVar33);
              cVar5 = func_0x0001803a2320(uVar32,uVar33);
              if (cVar5 == '\0') {
                cVar5 = '\x03';
                goto code_r0x0001803dd3ff;
              }
            }
            uVar32 = *(undefined8 *)(param_1 + 0x198);
            uVar33 = func_0x0001801b20b0(lVar23);
            cVar5 = func_0x000180226340(uVar33,uVar32);
            if (cVar5 == '\0') {
              cVar5 = '\x04';
              goto code_r0x0001803dd3ff;
            }
            lVar27 = *(longlong *)(param_1 + 0x1a0) + 1;
            uVar32 = FUN_18022bd70();
            uVar33 = FUN_1801ccce0(lVar23);
            pauVar28 = (undefined1 (*) [16])FUN_1801c6a50(uVar33,auStack_7b0);
            auVar66 = ZEXT1664(*pauVar28);
            uVar33 = FUN_1801b2640(lVar23);
            pauVar28 = (undefined1 (*) [16])FUN_1801c6a50(uVar33,auStack_7a0);
            local_b78 = auVar66._0_16_;
            auStack_668 = *pauVar28;
            uVar33 = func_0x0001801b20b0(lVar23);
            pcStack_bf8 = local_b78;
            cVar5 = FUN_18022c770(uVar32,uVar33,lVar27,auStack_668);
            if (cVar5 == '\0') {
              uVar32 = FUN_1801be340(local_5d0);
              uVar32 = func_0x0001803bdcf0(uVar32);
              func_0x0001803e8bf0(param_1 + 0x180,uVar32);
              uVar32 = func_0x0001801b20b0(lVar23);
              *(undefined8 *)(param_1 + 0x198) = uVar32;
              *(longlong *)(param_1 + 0x1a0) = lVar27;
            }
            goto code_r0x0001803dd8ea;
          }
        }
      }
      puVar26 = (undefined8 *)FUN_1803da4e0(auStack_538,5,*(undefined8 *)(param_1 + 0x198));
      auVar71 = auVar72._0_16_;
code_r0x0001803dd38b:
      uStack_5b8 = *puVar26;
      lStack_5b0 = puVar26[1];
      uStack_5a8 = puVar26[2];
      uStack_5a0 = puVar26[3];
code_r0x0001803dd38f:
      pcVar25 = local_5d8;
      auVar72 = ZEXT1664(auVar71);
      uVar32 = FUN_1801be340(local_5d0);
      FUN_1803da2f0(uVar32,pcVar25,&uStack_5b8);
      break;
    case '*':
      lVar23 = FUN_1801be340(local_5d0);
      cVar5 = func_0x0001803d80c0(lVar23 + 0x130);
      if ((cVar5 != '\0') && (lVar23 = func_0x0001803d5dd0(pcVar31), lVar23 != 0)) {
        cVar5 = FUN_1803ce340(lVar23);
        if (cVar5 == '\0') {
          uVar32 = FUN_180233850();
          FUN_180233bb0(uVar32);
          goto code_r0x0001803dc592;
        }
        cVar5 = func_0x0001801c6d90(param_1 + 0x150);
        if (cVar5 == '\0') {
          FUN_180239440(&uStack_4d8);
          uVar32 = FUN_1801b2640(lVar23);
          cVar5 = FUN_180238a00(uVar32,&uStack_4d8);
          if (cVar5 != '\0') {
            uVar32 = FUN_180233850();
            uVar33 = func_0x0001803d3fa0(lVar23);
            cVar5 = FUN_180233980(uVar32,&uStack_4d8,uVar33);
            if (cVar5 != '\0') {
              uVar32 = func_0x00018041a2d0();
              FUN_18041a3b0(uVar32,0);
              uVar32 = FUN_18041d7e0();
              FUN_18041db50(uVar32);
              uVar32 = func_0x00018041a550();
              FUN_18041a560(uVar32,0);
              thunk_FUN_1801e5ed0(&uStack_4d8);
              goto code_r0x0001803dc592;
            }
          }
          pcVar25 = local_5d8;
          uVar32 = FUN_1801be340(local_5d0);
          FUN_1803da020(uVar32,pcVar25);
          thunk_FUN_1801e5ed0(&uStack_4d8);
          break;
        }
      }
code_r0x0001803dbfe8:
      pcVar25 = local_5d8;
      uVar32 = FUN_1801be340(local_5d0);
code_r0x0001803e338a:
      FUN_1803da020(uVar32,pcVar25);
    }
code_r0x0001803e3390:
    if (local_428._0_8_ != 0) {
      thunk_FUN_180895720();
    }
    FUN_1801be880(local_5d0);
    FUN_1803e3930(local_200);
    uVar40 = local_b30;
  } while( true );
}

