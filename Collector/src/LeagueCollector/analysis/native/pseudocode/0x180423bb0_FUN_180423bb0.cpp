// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180423bb0; descriptive alias: FUN_180423bb0
// Evidence: ev_a4fccf783d06988231f5dec84ee8c8e94c81a41e7dd44cb9b13973cfcc75a390
// Original Evidence: rea-collector/0x180423bb0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* WARNING: Removing unreachable block (ram,0x000180423d06) */
/* WARNING: Removing unreachable block (ram,0x000180423ce5) */
/* WARNING: Removing unreachable block (ram,0x000180423d14) */

void FUN_180423bb0(undefined8 param_1,undefined8 *param_2)

{
  code *pcVar1;
  undefined1 auVar2 [16];
  undefined1 auVar3 [16];
  int iVar4;
  longlong lVar5;
  undefined1 *puVar6;
  ulonglong uVar7;
  undefined1 *puVar8;
  undefined1 auStack_218 [8];
  undefined1 auStack_210 [24];
  undefined8 local_1f8;
  undefined1 local_1e8 [16];
  undefined *local_1d8;
  longlong local_1d0;
  undefined8 local_1c8;
  undefined1 local_1c0 [16];
  undefined8 local_1b0;
  undefined8 *local_1a8;
  code *local_1a0;
  undefined8 local_198;
  undefined8 *local_190;
  undefined1 local_188 [16];
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
  undefined8 uStack_b0;
  undefined8 uStack_a8;
  undefined8 uStack_a0;
  undefined8 local_98;
  undefined8 uStack_90;
  undefined8 uStack_88;
  undefined8 uStack_80;
  undefined8 local_78;
  undefined *local_68;
  int local_60 [2];
  undefined1 local_58 [16];
  undefined8 local_48;
  ulonglong local_40;
  ulonglong local_38;
  
  puVar8 = auStack_218;
  local_38 = DAT_180d06cc0 ^ (ulonglong)auStack_218;
  local_68 = (undefined *)((ulonglong)local_68 & 0xffffffff00000000);
  local_1c0._0_9_ = ZEXT89(0x180d6eb78);
  local_1c0._9_7_ = 0;
  iVar4 = FUN_180973810(&DAT_180d6eb78);
  if (iVar4 != 0) {
                    /* WARNING: Subroutine does not return */
    FUN_1809737c0(5);
  }
  if (DAT_180d6ebc4 != 0x7fffffff) {
    local_1c0[8] = 1;
    local_1e8[0] = 0;
    FUN_180185e60(&DAT_180d6eb28,local_1e8);
    local_68._0_4_ = 0x1d;
    FUN_1801877a0(&DAT_180d6eb28,&local_68,4);
    FUN_1801877a0(&DAT_180d6eb28,&DAT_180d0f3f8,0x1d);
    local_1c8 = _Xtime_get_ticks();
    local_1a8 = &local_1c8;
    local_1a0 = FUN_180191210;
    local_1b0 = 0xd000000000000000;
    local_48 = 0;
    local_40 = 0xf;
    local_58._1_15_ = SUB1615((undefined1  [16])0x0,1);
    auVar2[0xf] = 0;
    auVar2._0_15_ = local_58._1_15_;
    local_58 = auVar2 << 8;
    local_68._0_4_ = 2;
    FUN_18019f7a0(local_58,0x11);
    local_198 = 1;
    local_190 = &local_1b0;
    local_1d8 = &DAT_180c09610;
    local_1d0 = 9;
    local_1f8 = 0;
    FUN_18018ad00(local_188,local_58,&local_1d8,&local_198);
    local_68._0_4_ = 1;
    FUN_180185f70(&DAT_180d6eb28,&local_68);
    local_68 = (undefined *)CONCAT44(local_68._4_4_,(undefined4)local_48);
    FUN_1801877a0(&DAT_180d6eb28,&local_68,4);
    puVar6 = local_58;
    if (0xf < local_40) {
      puVar6 = (undefined1 *)local_58._0_8_;
    }
    FUN_1801877a0(&DAT_180d6eb28,puVar6,local_48);
    local_68 = &DAT_180d6ea00;
    local_178 = *param_2;
    uStack_170 = param_2[1];
    uStack_168 = param_2[2];
    uStack_160 = param_2[3];
    local_158 = param_2[4];
    uStack_150 = param_2[5];
    uStack_148 = param_2[6];
    uStack_140 = param_2[7];
    local_138 = param_2[8];
    uStack_130 = param_2[9];
    uStack_128 = param_2[10];
    uStack_120 = param_2[0xb];
    local_118 = param_2[0xc];
    uStack_110 = param_2[0xd];
    uStack_108 = param_2[0xe];
    uStack_100 = param_2[0xf];
    local_f8 = param_2[0x10];
    uStack_f0 = param_2[0x11];
    uStack_e8 = param_2[0x12];
    uStack_e0 = param_2[0x13];
    local_d8 = param_2[0x14];
    uStack_d0 = param_2[0x15];
    uStack_c8 = param_2[0x16];
    uStack_c0 = param_2[0x17];
    local_b8 = param_2[0x18];
    uStack_b0 = param_2[0x19];
    uStack_a8 = param_2[0x1a];
    uStack_a0 = param_2[0x1b];
    local_98 = param_2[0x1c];
    uStack_90 = param_2[0x1d];
    uStack_88 = param_2[0x1e];
    uStack_80 = param_2[0x1f];
    local_78 = param_2[0x20];
    FUN_180424010(&local_68,&local_178);
    if (DAT_180d6ebe0 != '\0') {
      local_68 = (undefined *)CONCAT44(local_68._4_4_,(int)DAT_180d6eb30 - (int)DAT_180d6eb28);
      FUN_1803c9190(&DAT_180d6ebc8,&local_1d8,&local_68,4);
      FUN_1803c9190(&DAT_180d6ebc8,&local_1d8,CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28),
                    DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28));
    }
    DAT_180d6eb70 = DAT_180d6eb70 + 1;
    local_1d8 = (undefined *)CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
    local_1d0 = DAT_180d6eb30 - (longlong)local_1d8;
    FUN_1801806e0(&DAT_180d6eb40,&local_1d8);
    local_60[0] = ((int)DAT_180d6eb30 - (int)DAT_180d6eb28) + 4;
    FUN_180186fb0(&DAT_180d6ea20,local_60,4);
    FUN_180186fb0(&DAT_180d6ea20,CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28),
                  DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28));
    FUN_180186e20(&DAT_180d6ea20);
    if (CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28) != DAT_180d6eb30) {
      DAT_180d6eb30 = CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
    }
    if (0xf < local_40) {
      uVar7 = local_40 + 1;
      lVar5 = local_58._0_8_;
      if (0xfff < uVar7) {
        lVar5 = *(longlong *)(local_58._0_8_ + -8);
        if (0x1f < (local_58._0_8_ - lVar5) - 8U) {
          pcVar1 = (code *)swi(0x29);
          DAT_180d6ebc4 = (*pcVar1)(5);
          puVar8 = auStack_210;
          goto LAB_180423fe9;
        }
        uVar7 = local_40 + 0x28;
      }
      thunk_FUN_180895720(lVar5,uVar7);
    }
    local_48 = 0;
    local_40 = 0xf;
    auVar3[0xf] = 0;
    auVar3._0_15_ = local_58._1_15_;
    local_58 = auVar3 << 8;
    FUN_180973930(&DAT_180d6eb78);
    return;
  }
LAB_180423fe9:
  DAT_180d6ebc4 = DAT_180d6ebc4 + -1;
                    /* WARNING: Subroutine does not return */
  *(undefined **)(puVar8 + -8) = &UNK_180423ffb;
  FUN_1809737c0(6);
}

