// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1804232c0; descriptive alias: FUN_1804232c0
// Evidence: ev_1d360a329195de3e5f089b26cf2dc5a2e99e706ab1011b98ecbb049bf8d68902
// Original Evidence: rea-collector/0x1804232c0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* WARNING: Removing unreachable block (ram,0x00018042342e) */
/* WARNING: Removing unreachable block (ram,0x00018042340d) */
/* WARNING: Removing unreachable block (ram,0x00018042343c) */

void FUN_1804232c0(undefined8 param_1,undefined8 *param_2,undefined8 *param_3,undefined1 *param_4,
                  undefined1 *param_5)

{
  undefined1 uVar1;
  code *pcVar2;
  undefined1 auVar3 [16];
  undefined1 auVar4 [16];
  undefined1 auVar5 [16];
  undefined1 auVar6 [16];
  undefined8 uVar7;
  int iVar8;
  undefined1 (*pauVar9) [16];
  longlong lVar10;
  ulonglong uVar11;
  undefined1 *puVar12;
  undefined1 *puVar13;
  undefined1 *puVar14;
  undefined8 uStack_280;
  undefined1 auStack_278 [8];
  undefined1 auStack_270 [24];
  undefined8 local_258;
  undefined1 local_248 [16];
  undefined *local_238;
  longlong local_230;
  longlong local_228;
  undefined8 *local_220;
  code *local_218;
  ulonglong local_210;
  undefined8 local_208;
  undefined1 local_200 [16];
  undefined8 local_1e8;
  longlong *local_1e0;
  undefined1 local_1d8 [16];
  undefined8 local_1c8;
  undefined8 uStack_1c0;
  undefined8 uStack_1b8;
  undefined8 uStack_1b0;
  undefined8 local_1a8;
  undefined8 uStack_1a0;
  undefined8 uStack_198;
  undefined8 uStack_190;
  undefined8 local_188;
  undefined8 uStack_180;
  undefined8 uStack_178;
  undefined8 uStack_170;
  undefined8 local_168;
  undefined8 uStack_160;
  undefined8 uStack_158;
  undefined8 uStack_150;
  undefined8 local_148;
  undefined8 uStack_140;
  undefined8 uStack_138;
  undefined8 uStack_130;
  undefined8 local_128;
  undefined8 uStack_120;
  undefined8 uStack_118;
  undefined8 uStack_110;
  undefined8 local_108;
  undefined8 uStack_100;
  undefined8 uStack_f8;
  undefined8 uStack_f0;
  undefined8 local_e8;
  undefined8 uStack_e0;
  undefined8 uStack_d8;
  undefined8 uStack_d0;
  undefined8 local_c8;
  int local_b8 [2];
  undefined1 local_b0 [16];
  undefined8 uStack_a0;
  ulonglong uStack_98;
  undefined1 local_90 [16];
  undefined8 uStack_80;
  ulonglong uStack_78;
  int local_70 [2];
  undefined1 local_68 [16];
  undefined8 local_58;
  ulonglong local_50;
  ulonglong local_48;
  
  puVar13 = auStack_278;
  puVar14 = auStack_278;
  local_48 = DAT_180d06cc0 ^ (ulonglong)auStack_278;
  local_b8[0] = 0;
  local_200._0_9_ = ZEXT89(0x180d6eb78);
  local_200._9_7_ = 0;
  iVar8 = FUN_180973810(&DAT_180d6eb78);
  if (iVar8 != 0) {
                    /* WARNING: Subroutine does not return */
    FUN_1809737c0(5);
  }
  if (DAT_180d6ebc4 == 0x7fffffff) goto LAB_180423b8e;
  local_200[8] = 1;
  local_248[0] = 0;
  FUN_180185e60(&DAT_180d6eb28,local_248);
  local_b8[0] = 0x56;
  FUN_1801877a0(&DAT_180d6eb28,local_b8,4);
  FUN_1801877a0(&DAT_180d6eb28,&DAT_180d0f460,0x56);
  local_208 = _Xtime_get_ticks();
  local_220 = &local_208;
  local_218 = FUN_180191210;
  local_228 = -0x3000000000000000;
  local_58 = 0;
  local_50 = 0xf;
  local_68._1_15_ = SUB1615((undefined1  [16])0x0,1);
  auVar3[0xf] = 0;
  auVar3._0_15_ = local_68._1_15_;
  local_68 = auVar3 << 8;
  local_b8[0] = 2;
  FUN_18019f7a0(local_68,0x11);
  local_1e8 = 1;
  local_1e0 = &local_228;
  local_238 = &DAT_180c09610;
  local_230 = 9;
  local_258 = 0;
  FUN_18018ad00(local_1d8,local_68,&local_238,&local_1e8);
  local_b8[0] = 1;
  FUN_180185f70(&DAT_180d6eb28,local_b8);
  local_b8[0] = (int)local_58;
  FUN_1801877a0(&DAT_180d6eb28,local_b8,4);
  puVar12 = local_68;
  if (0xf < local_50) {
    puVar12 = (undefined1 *)local_68._0_8_;
  }
  FUN_1801877a0(&DAT_180d6eb28,puVar12,local_58);
  local_1c8 = *param_2;
  uStack_1c0 = param_2[1];
  uStack_1b8 = param_2[2];
  uStack_1b0 = param_2[3];
  local_1a8 = param_2[4];
  uStack_1a0 = param_2[5];
  uStack_198 = param_2[6];
  uStack_190 = param_2[7];
  local_188 = param_2[8];
  uStack_180 = param_2[9];
  uStack_178 = param_2[10];
  uStack_170 = param_2[0xb];
  local_168 = param_2[0xc];
  uStack_160 = param_2[0xd];
  uStack_158 = param_2[0xe];
  uStack_150 = param_2[0xf];
  local_148 = param_2[0x10];
  uStack_140 = param_2[0x11];
  uStack_138 = param_2[0x12];
  uStack_130 = param_2[0x13];
  local_128 = param_2[0x14];
  uStack_120 = param_2[0x15];
  uStack_118 = param_2[0x16];
  uStack_110 = param_2[0x17];
  local_108 = param_2[0x18];
  uStack_100 = param_2[0x19];
  uStack_f8 = param_2[0x1a];
  uStack_f0 = param_2[0x1b];
  local_e8 = param_2[0x1c];
  uStack_e0 = param_2[0x1d];
  uStack_d8 = param_2[0x1e];
  uStack_d0 = param_2[0x1f];
  local_c8 = param_2[0x20];
  uStack_a0 = 0;
  uStack_98 = 0xf;
  local_b0._1_15_ = SUB1615((undefined1  [16])0x0,1);
  auVar4[0xf] = 0;
  auVar4._0_15_ = local_b0._1_15_;
  local_b0 = auVar4 << 8;
  pauVar9 = (undefined1 (*) [16])FUN_1801c7930(&local_1c8,&local_228);
  if (&local_b0 == pauVar9) {
LAB_180423623:
    if (0xf < local_210) {
      uVar11 = local_210 + 1;
      lVar10 = local_228;
      if (0xfff < uVar11) {
        lVar10 = *(longlong *)(local_228 + -8);
        if (0x1f < (local_228 - lVar10) - 8U) goto LAB_180423b72;
        uVar11 = local_210 + 0x28;
      }
      thunk_FUN_180895720(lVar10,uVar11);
    }
    uVar7 = uStack_a0;
    puVar12 = local_b0;
    if (0xf < uStack_98) {
      puVar12 = (undefined1 *)local_b0._0_8_;
    }
    local_b8[0] = 1;
    FUN_180185f70(&DAT_180d6eb28,local_b8);
    local_b8[0] = (int)uVar7;
    FUN_1801877a0(&DAT_180d6eb28,local_b8,4);
    FUN_1801877a0(&DAT_180d6eb28,puVar12,uVar7);
    if (0xf < uStack_98) {
      uVar11 = uStack_98 + 1;
      lVar10 = local_b0._0_8_;
      if (uVar11 < 0x1000) {
LAB_18042370f:
        thunk_FUN_180895720(lVar10,uVar11);
        goto LAB_180423714;
      }
      lVar10 = *(longlong *)(local_b0._0_8_ + -8);
      puVar12 = auStack_278;
      if ((local_b0._0_8_ - lVar10) - 8U < 0x20) {
        uVar11 = uStack_98 + 0x28;
        goto LAB_18042370f;
      }
      goto LAB_180423b80;
    }
LAB_180423714:
    local_1c8 = *param_3;
    uStack_1c0 = param_3[1];
    uStack_1b8 = param_3[2];
    uStack_1b0 = param_3[3];
    local_1a8 = param_3[4];
    uStack_1a0 = param_3[5];
    uStack_198 = param_3[6];
    uStack_190 = param_3[7];
    local_188 = param_3[8];
    uStack_180 = param_3[9];
    uStack_178 = param_3[10];
    uStack_170 = param_3[0xb];
    local_168 = param_3[0xc];
    uStack_160 = param_3[0xd];
    uStack_158 = param_3[0xe];
    uStack_150 = param_3[0xf];
    local_148 = param_3[0x10];
    uStack_140 = param_3[0x11];
    uStack_138 = param_3[0x12];
    uStack_130 = param_3[0x13];
    local_128 = param_3[0x14];
    uStack_120 = param_3[0x15];
    uStack_118 = param_3[0x16];
    uStack_110 = param_3[0x17];
    local_108 = param_3[0x18];
    uStack_100 = param_3[0x19];
    uStack_f8 = param_3[0x1a];
    uStack_f0 = param_3[0x1b];
    local_e8 = param_3[0x1c];
    uStack_e0 = param_3[0x1d];
    uStack_d8 = param_3[0x1e];
    uStack_d0 = param_3[0x1f];
    local_c8 = param_3[0x20];
    uStack_80 = 0;
    uStack_78 = 0xf;
    local_90._1_15_ = SUB1615((undefined1  [16])0x0,1);
    auVar5[0xf] = 0;
    auVar5._0_15_ = local_90._1_15_;
    local_90 = auVar5 << 8;
    pauVar9 = (undefined1 (*) [16])FUN_1801c7930(&local_1c8,&local_228);
    if (&local_90 != pauVar9) {
      if (0xf < uStack_78) {
        uVar11 = uStack_78 + 1;
        lVar10 = local_90._0_8_;
        if (0xfff < uVar11) {
          lVar10 = *(longlong *)(local_90._0_8_ + -8);
          puVar12 = auStack_278;
          if (0x1f < (local_90._0_8_ - lVar10) - 8U) goto LAB_180423b79;
          uVar11 = uStack_78 + 0x28;
        }
        thunk_FUN_180895720(lVar10,uVar11);
      }
      local_90 = *pauVar9;
      uStack_80 = *(undefined8 *)pauVar9[1];
      uStack_78 = *(ulonglong *)(pauVar9[1] + 8);
      *(undefined8 *)pauVar9[1] = 0;
      *(undefined8 *)(pauVar9[1] + 8) = 0xf;
      (*pauVar9)[0] = 0;
    }
    if (0xf < local_210) {
      uVar11 = local_210 + 1;
      lVar10 = local_228;
      if (0xfff < uVar11) {
        lVar10 = *(longlong *)(local_228 + -8);
        puVar12 = auStack_278;
        if (0x1f < (local_228 - lVar10) - 8U) goto LAB_180423b79;
        uVar11 = local_210 + 0x28;
      }
      thunk_FUN_180895720(lVar10,uVar11);
    }
    uVar7 = uStack_80;
    puVar12 = local_90;
    if (0xf < uStack_78) {
      puVar12 = (undefined1 *)local_90._0_8_;
    }
    local_b8[0] = 1;
    FUN_180185f70(&DAT_180d6eb28,local_b8);
    local_b8[0] = (int)uVar7;
    FUN_1801877a0(&DAT_180d6eb28,local_b8,4);
    FUN_1801877a0(&DAT_180d6eb28,puVar12,uVar7);
    if (0xf < uStack_78) {
      uVar11 = uStack_78 + 1;
      lVar10 = local_90._0_8_;
      if (0xfff < uVar11) {
        lVar10 = *(longlong *)(local_90._0_8_ + -8);
        puVar12 = auStack_278;
        if (0x1f < (local_90._0_8_ - lVar10) - 8U) goto LAB_180423b80;
        uVar11 = uStack_78 + 0x28;
      }
      thunk_FUN_180895720(lVar10,uVar11);
    }
    uVar1 = *param_4;
    local_b8[0] = 0;
    FUN_180185f70(&DAT_180d6eb28,local_b8);
    local_b8[0] = 1;
    FUN_1801877a0(&DAT_180d6eb28,local_b8,4);
    local_248[0] = uVar1;
    FUN_1801877a0(&DAT_180d6eb28,local_248,1);
    uVar1 = *param_5;
    local_b8[0] = 0;
    FUN_180185f70(&DAT_180d6eb28,local_b8);
    local_b8[0] = 1;
    FUN_1801877a0(&DAT_180d6eb28,local_b8,4);
    local_248[0] = uVar1;
    FUN_1801877a0(&DAT_180d6eb28,local_248,1);
    if (DAT_180d6ebe0 != '\0') {
      local_b8[0] = (int)DAT_180d6eb30 - (int)DAT_180d6eb28;
      FUN_1803c9190(&DAT_180d6ebc8,&local_238,local_b8,4);
      FUN_1803c9190(&DAT_180d6ebc8,&local_238,CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28),
                    DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28));
    }
    DAT_180d6eb70 = DAT_180d6eb70 + 1;
    local_238 = (undefined *)CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
    local_230 = DAT_180d6eb30 - (longlong)local_238;
    FUN_1801806e0(&DAT_180d6eb40,&local_238);
    local_70[0] = ((int)DAT_180d6eb30 - (int)DAT_180d6eb28) + 4;
    FUN_180186fb0(&DAT_180d6ea20,local_70,4);
    FUN_180186fb0(&DAT_180d6ea20,CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28),
                  DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28));
    FUN_180186e20(&DAT_180d6ea20);
    if (CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28) != DAT_180d6eb30) {
      DAT_180d6eb30 = CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
    }
    if (local_50 < 0x10) goto LAB_180423b27;
    uVar11 = local_50 + 1;
    lVar10 = local_68._0_8_;
    if (uVar11 < 0x1000) {
LAB_180423b22:
      thunk_FUN_180895720(lVar10,uVar11);
LAB_180423b27:
      local_58 = 0;
      local_50 = 0xf;
      auVar6[0xf] = 0;
      auVar6._0_15_ = local_68._1_15_;
      local_68 = auVar6 << 8;
      FUN_180973930(&DAT_180d6eb78);
      return;
    }
    lVar10 = *(longlong *)(local_68._0_8_ + -8);
    if ((local_68._0_8_ - lVar10) - 8U < 0x20) {
      uVar11 = local_50 + 0x28;
      goto LAB_180423b22;
    }
  }
  else {
    if (uStack_98 < 0x10) {
LAB_1804235ef:
      local_b0 = *pauVar9;
      uStack_a0 = *(undefined8 *)pauVar9[1];
      uStack_98 = *(ulonglong *)(pauVar9[1] + 8);
      *(undefined8 *)pauVar9[1] = 0;
      *(undefined8 *)(pauVar9[1] + 8) = 0xf;
      (*pauVar9)[0] = 0;
      goto LAB_180423623;
    }
    uVar11 = uStack_98 + 1;
    lVar10 = local_b0._0_8_;
    if (uVar11 < 0x1000) {
LAB_1804235ea:
      thunk_FUN_180895720(lVar10,uVar11);
      goto LAB_1804235ef;
    }
    lVar10 = *(longlong *)(local_b0._0_8_ + -8);
    if ((local_b0._0_8_ - lVar10) - 8U < 0x20) {
      uVar11 = uStack_98 + 0x28;
      goto LAB_1804235ea;
    }
LAB_180423b72:
    pcVar2 = (code *)swi(0x29);
    (*pcVar2)(5);
    puVar12 = auStack_270;
LAB_180423b79:
    pcVar2 = (code *)swi(0x29);
    (*pcVar2)(5);
    puVar12 = puVar12 + 8;
LAB_180423b80:
    pcVar2 = (code *)swi(0x29);
    (*pcVar2)(5);
    puVar13 = puVar12 + 8;
  }
  pcVar2 = (code *)swi(0x29);
  DAT_180d6ebc4 = (*pcVar2)(5);
  puVar14 = puVar13 + 8;
LAB_180423b8e:
  DAT_180d6ebc4 = DAT_180d6ebc4 + -1;
                    /* WARNING: Subroutine does not return */
  *(undefined **)(puVar14 + -8) = &UNK_180423ba0;
  FUN_1809737c0(6);
}

