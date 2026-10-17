// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180422a90; descriptive alias: FUN_180422a90
// Evidence: ev_acc364d6395a73c9ac1b1dd8d921b241c8ab8ca5217cfffd732d14fa3e5b822c
// Original Evidence: rea-collector/0x180422a90.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* WARNING: Removing unreachable block (ram,0x000180422bf0) */
/* WARNING: Removing unreachable block (ram,0x000180422bcf) */
/* WARNING: Removing unreachable block (ram,0x000180422bfe) */

void FUN_180422a90(undefined8 param_1,undefined8 *param_2,undefined8 *param_3)

{
  code *pcVar1;
  undefined1 auVar2 [16];
  undefined1 auVar3 [16];
  undefined1 auVar4 [16];
  undefined1 auVar5 [16];
  undefined8 uVar6;
  int iVar7;
  undefined1 (*pauVar8) [16];
  longlong lVar9;
  ulonglong uVar10;
  undefined1 *puVar11;
  undefined1 *puVar12;
  undefined1 *puVar13;
  undefined8 uStack_270;
  undefined1 auStack_268 [8];
  undefined1 auStack_260 [24];
  undefined8 local_248;
  undefined1 local_238 [16];
  undefined *local_228;
  longlong local_220;
  longlong local_218;
  undefined8 *local_210;
  code *local_208;
  ulonglong local_200;
  undefined8 local_1f8;
  undefined1 local_1f0 [16];
  undefined8 local_1d8;
  longlong *local_1d0;
  undefined1 local_1c8 [16];
  undefined8 local_1b8;
  undefined8 uStack_1b0;
  undefined8 uStack_1a8;
  undefined8 uStack_1a0;
  undefined8 local_198;
  undefined8 uStack_190;
  undefined8 uStack_188;
  undefined8 uStack_180;
  undefined8 local_178;
  undefined8 uStack_170;
  undefined8 uStack_168;
  undefined8 uStack_160;
  undefined8 local_158;
  undefined8 uStack_150;
  undefined8 uStack_148;
  undefined8 uStack_140;
  undefined8 local_138;
  undefined8 uStack_130;
  undefined8 uStack_128;
  undefined8 uStack_120;
  undefined8 local_118;
  undefined8 uStack_110;
  undefined8 uStack_108;
  undefined8 uStack_100;
  undefined8 local_f8;
  undefined8 uStack_f0;
  undefined8 uStack_e8;
  undefined8 uStack_e0;
  undefined8 local_d8;
  undefined8 uStack_d0;
  undefined8 uStack_c8;
  undefined8 uStack_c0;
  undefined8 local_b8;
  int local_a8 [2];
  undefined1 local_a0 [16];
  undefined8 uStack_90;
  ulonglong uStack_88;
  undefined1 local_80 [16];
  undefined8 uStack_70;
  ulonglong uStack_68;
  int local_60 [2];
  undefined1 local_58 [16];
  undefined8 local_48;
  ulonglong local_40;
  ulonglong local_38;
  
  puVar12 = auStack_268;
  puVar13 = auStack_268;
  local_38 = DAT_180d06cc0 ^ (ulonglong)auStack_268;
  local_a8[0] = 0;
  local_1f0._0_9_ = ZEXT89(0x180d6eb78);
  local_1f0._9_7_ = 0;
  iVar7 = FUN_180973810(&DAT_180d6eb78);
  if (iVar7 != 0) {
                    /* WARNING: Subroutine does not return */
    FUN_1809737c0(5);
  }
  if (DAT_180d6ebc4 == 0x7fffffff) goto LAB_180423294;
  local_1f0[8] = 1;
  local_238[0] = 0;
  FUN_180185e60(&DAT_180d6eb28,local_238);
  local_a8[0] = 0x3f;
  FUN_1801877a0(&DAT_180d6eb28,local_a8,4);
  FUN_1801877a0(&DAT_180d6eb28,&DAT_180d0f418,0x3f);
  local_1f8 = _Xtime_get_ticks();
  local_210 = &local_1f8;
  local_208 = FUN_180191210;
  local_218 = -0x3000000000000000;
  local_48 = 0;
  local_40 = 0xf;
  local_58._1_15_ = SUB1615((undefined1  [16])0x0,1);
  auVar2[0xf] = 0;
  auVar2._0_15_ = local_58._1_15_;
  local_58 = auVar2 << 8;
  local_a8[0] = 2;
  FUN_18019f7a0(local_58,0x11);
  local_1d8 = 1;
  local_1d0 = &local_218;
  local_228 = &DAT_180c09610;
  local_220 = 9;
  local_248 = 0;
  FUN_18018ad00(local_1c8,local_58,&local_228,&local_1d8);
  local_a8[0] = 1;
  FUN_180185f70(&DAT_180d6eb28,local_a8);
  local_a8[0] = (int)local_48;
  FUN_1801877a0(&DAT_180d6eb28,local_a8,4);
  puVar11 = local_58;
  if (0xf < local_40) {
    puVar11 = (undefined1 *)local_58._0_8_;
  }
  FUN_1801877a0(&DAT_180d6eb28,puVar11,local_48);
  local_1b8 = *param_2;
  uStack_1b0 = param_2[1];
  uStack_1a8 = param_2[2];
  uStack_1a0 = param_2[3];
  local_198 = param_2[4];
  uStack_190 = param_2[5];
  uStack_188 = param_2[6];
  uStack_180 = param_2[7];
  local_178 = param_2[8];
  uStack_170 = param_2[9];
  uStack_168 = param_2[10];
  uStack_160 = param_2[0xb];
  local_158 = param_2[0xc];
  uStack_150 = param_2[0xd];
  uStack_148 = param_2[0xe];
  uStack_140 = param_2[0xf];
  local_138 = param_2[0x10];
  uStack_130 = param_2[0x11];
  uStack_128 = param_2[0x12];
  uStack_120 = param_2[0x13];
  local_118 = param_2[0x14];
  uStack_110 = param_2[0x15];
  uStack_108 = param_2[0x16];
  uStack_100 = param_2[0x17];
  local_f8 = param_2[0x18];
  uStack_f0 = param_2[0x19];
  uStack_e8 = param_2[0x1a];
  uStack_e0 = param_2[0x1b];
  local_d8 = param_2[0x1c];
  uStack_d0 = param_2[0x1d];
  uStack_c8 = param_2[0x1e];
  uStack_c0 = param_2[0x1f];
  local_b8 = param_2[0x20];
  uStack_90 = 0;
  uStack_88 = 0xf;
  local_a0._1_15_ = SUB1615((undefined1  [16])0x0,1);
  auVar3[0xf] = 0;
  auVar3._0_15_ = local_a0._1_15_;
  local_a0 = auVar3 << 8;
  pauVar8 = (undefined1 (*) [16])FUN_1801c7930(&local_1b8,&local_218);
  if (&local_a0 == pauVar8) {
LAB_180422de5:
    if (0xf < local_200) {
      uVar10 = local_200 + 1;
      lVar9 = local_218;
      if (0xfff < uVar10) {
        lVar9 = *(longlong *)(local_218 + -8);
        if (0x1f < (local_218 - lVar9) - 8U) goto LAB_180423278;
        uVar10 = local_200 + 0x28;
      }
      thunk_FUN_180895720(lVar9,uVar10);
    }
    uVar6 = uStack_90;
    puVar11 = local_a0;
    if (0xf < uStack_88) {
      puVar11 = (undefined1 *)local_a0._0_8_;
    }
    local_a8[0] = 1;
    FUN_180185f70(&DAT_180d6eb28,local_a8);
    local_a8[0] = (int)uVar6;
    FUN_1801877a0(&DAT_180d6eb28,local_a8,4);
    FUN_1801877a0(&DAT_180d6eb28,puVar11,uVar6);
    if (0xf < uStack_88) {
      uVar10 = uStack_88 + 1;
      lVar9 = local_a0._0_8_;
      if (uVar10 < 0x1000) {
LAB_180422ed1:
        thunk_FUN_180895720(lVar9,uVar10);
        goto LAB_180422ed6;
      }
      lVar9 = *(longlong *)(local_a0._0_8_ + -8);
      puVar11 = auStack_268;
      if ((local_a0._0_8_ - lVar9) - 8U < 0x20) {
        uVar10 = uStack_88 + 0x28;
        goto LAB_180422ed1;
      }
      goto LAB_180423286;
    }
LAB_180422ed6:
    local_1b8 = *param_3;
    uStack_1b0 = param_3[1];
    uStack_1a8 = param_3[2];
    uStack_1a0 = param_3[3];
    local_198 = param_3[4];
    uStack_190 = param_3[5];
    uStack_188 = param_3[6];
    uStack_180 = param_3[7];
    local_178 = param_3[8];
    uStack_170 = param_3[9];
    uStack_168 = param_3[10];
    uStack_160 = param_3[0xb];
    local_158 = param_3[0xc];
    uStack_150 = param_3[0xd];
    uStack_148 = param_3[0xe];
    uStack_140 = param_3[0xf];
    local_138 = param_3[0x10];
    uStack_130 = param_3[0x11];
    uStack_128 = param_3[0x12];
    uStack_120 = param_3[0x13];
    local_118 = param_3[0x14];
    uStack_110 = param_3[0x15];
    uStack_108 = param_3[0x16];
    uStack_100 = param_3[0x17];
    local_f8 = param_3[0x18];
    uStack_f0 = param_3[0x19];
    uStack_e8 = param_3[0x1a];
    uStack_e0 = param_3[0x1b];
    local_d8 = param_3[0x1c];
    uStack_d0 = param_3[0x1d];
    uStack_c8 = param_3[0x1e];
    uStack_c0 = param_3[0x1f];
    local_b8 = param_3[0x20];
    uStack_70 = 0;
    uStack_68 = 0xf;
    local_80._1_15_ = SUB1615((undefined1  [16])0x0,1);
    auVar4[0xf] = 0;
    auVar4._0_15_ = local_80._1_15_;
    local_80 = auVar4 << 8;
    pauVar8 = (undefined1 (*) [16])FUN_1801c7930(&local_1b8,&local_218);
    if (&local_80 != pauVar8) {
      if (0xf < uStack_68) {
        uVar10 = uStack_68 + 1;
        lVar9 = local_80._0_8_;
        if (0xfff < uVar10) {
          lVar9 = *(longlong *)(local_80._0_8_ + -8);
          puVar11 = auStack_268;
          if (0x1f < (local_80._0_8_ - lVar9) - 8U) goto LAB_18042327f;
          uVar10 = uStack_68 + 0x28;
        }
        thunk_FUN_180895720(lVar9,uVar10);
      }
      local_80 = *pauVar8;
      uStack_70 = *(undefined8 *)pauVar8[1];
      uStack_68 = *(ulonglong *)(pauVar8[1] + 8);
      *(undefined8 *)pauVar8[1] = 0;
      *(undefined8 *)(pauVar8[1] + 8) = 0xf;
      (*pauVar8)[0] = 0;
    }
    if (0xf < local_200) {
      uVar10 = local_200 + 1;
      lVar9 = local_218;
      if (0xfff < uVar10) {
        lVar9 = *(longlong *)(local_218 + -8);
        puVar11 = auStack_268;
        if (0x1f < (local_218 - lVar9) - 8U) goto LAB_18042327f;
        uVar10 = local_200 + 0x28;
      }
      thunk_FUN_180895720(lVar9,uVar10);
    }
    uVar6 = uStack_70;
    puVar11 = local_80;
    if (0xf < uStack_68) {
      puVar11 = (undefined1 *)local_80._0_8_;
    }
    local_a8[0] = 1;
    FUN_180185f70(&DAT_180d6eb28,local_a8);
    local_a8[0] = (int)uVar6;
    FUN_1801877a0(&DAT_180d6eb28,local_a8,4);
    FUN_1801877a0(&DAT_180d6eb28,puVar11,uVar6);
    if (0xf < uStack_68) {
      uVar10 = uStack_68 + 1;
      lVar9 = local_80._0_8_;
      if (0xfff < uVar10) {
        lVar9 = *(longlong *)(local_80._0_8_ + -8);
        puVar11 = auStack_268;
        if (0x1f < (local_80._0_8_ - lVar9) - 8U) goto LAB_180423286;
        uVar10 = uStack_68 + 0x28;
      }
      thunk_FUN_180895720(lVar9,uVar10);
    }
    if (DAT_180d6ebe0 != '\0') {
      local_a8[0] = (int)DAT_180d6eb30 - (int)DAT_180d6eb28;
      FUN_1803c9190(&DAT_180d6ebc8,&local_228,local_a8,4);
      FUN_1803c9190(&DAT_180d6ebc8,&local_228,CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28),
                    DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28));
    }
    DAT_180d6eb70 = DAT_180d6eb70 + 1;
    local_228 = (undefined *)CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
    local_220 = DAT_180d6eb30 - (longlong)local_228;
    FUN_1801806e0(&DAT_180d6eb40,&local_228);
    local_60[0] = ((int)DAT_180d6eb30 - (int)DAT_180d6eb28) + 4;
    FUN_180186fb0(&DAT_180d6ea20,local_60,4);
    FUN_180186fb0(&DAT_180d6ea20,CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28),
                  DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28));
    FUN_180186e20(&DAT_180d6ea20);
    if (CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28) != DAT_180d6eb30) {
      DAT_180d6eb30 = CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
    }
    if (local_40 < 0x10) goto LAB_180423231;
    uVar10 = local_40 + 1;
    lVar9 = local_58._0_8_;
    if (uVar10 < 0x1000) {
LAB_18042322c:
      thunk_FUN_180895720(lVar9,uVar10);
LAB_180423231:
      local_48 = 0;
      local_40 = 0xf;
      auVar5[0xf] = 0;
      auVar5._0_15_ = local_58._1_15_;
      local_58 = auVar5 << 8;
      FUN_180973930(&DAT_180d6eb78);
      return;
    }
    lVar9 = *(longlong *)(local_58._0_8_ + -8);
    if ((local_58._0_8_ - lVar9) - 8U < 0x20) {
      uVar10 = local_40 + 0x28;
      goto LAB_18042322c;
    }
  }
  else {
    if (uStack_88 < 0x10) {
LAB_180422db1:
      local_a0 = *pauVar8;
      uStack_90 = *(undefined8 *)pauVar8[1];
      uStack_88 = *(ulonglong *)(pauVar8[1] + 8);
      *(undefined8 *)pauVar8[1] = 0;
      *(undefined8 *)(pauVar8[1] + 8) = 0xf;
      (*pauVar8)[0] = 0;
      goto LAB_180422de5;
    }
    uVar10 = uStack_88 + 1;
    lVar9 = local_a0._0_8_;
    if (uVar10 < 0x1000) {
LAB_180422dac:
      thunk_FUN_180895720(lVar9,uVar10);
      goto LAB_180422db1;
    }
    lVar9 = *(longlong *)(local_a0._0_8_ + -8);
    if ((local_a0._0_8_ - lVar9) - 8U < 0x20) {
      uVar10 = uStack_88 + 0x28;
      goto LAB_180422dac;
    }
LAB_180423278:
    pcVar1 = (code *)swi(0x29);
    (*pcVar1)(5);
    puVar11 = auStack_260;
LAB_18042327f:
    pcVar1 = (code *)swi(0x29);
    (*pcVar1)(5);
    puVar11 = puVar11 + 8;
LAB_180423286:
    pcVar1 = (code *)swi(0x29);
    (*pcVar1)(5);
    puVar12 = puVar11 + 8;
  }
  pcVar1 = (code *)swi(0x29);
  DAT_180d6ebc4 = (*pcVar1)(5);
  puVar13 = puVar12 + 8;
LAB_180423294:
  DAT_180d6ebc4 = DAT_180d6ebc4 + -1;
                    /* WARNING: Subroutine does not return */
  *(undefined **)(puVar13 + -8) = &UNK_1804232a6;
  FUN_1809737c0(6);
}

