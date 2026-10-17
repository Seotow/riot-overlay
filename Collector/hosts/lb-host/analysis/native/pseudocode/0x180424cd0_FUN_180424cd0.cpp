// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180424cd0; descriptive alias: FUN_180424cd0
// Evidence: ev_7a7642222d6c44b5e0abf558266907ba24e91d7efef32bcf1837eff5e7363aaa
// Original Evidence: rea-collector/0x180424cd0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* WARNING: Removing unreachable block (ram,0x000180424dfc) */
/* WARNING: Removing unreachable block (ram,0x000180424ddb) */
/* WARNING: Removing unreachable block (ram,0x000180424e0a) */

void FUN_180424cd0(undefined8 param_1,ulonglong *param_2)

{
  code *pcVar1;
  undefined1 auVar2 [16];
  undefined1 auVar3 [16];
  int iVar4;
  longlong lVar5;
  undefined1 *puVar6;
  ulonglong uVar7;
  undefined1 *puVar8;
  undefined1 auStack_f8 [8];
  undefined1 auStack_f0 [24];
  undefined8 local_d8;
  undefined1 local_c8 [16];
  undefined *local_b8;
  longlong local_b0;
  undefined8 local_a8;
  undefined1 local_a0 [16];
  undefined8 local_90;
  undefined8 *local_88;
  code *local_80;
  undefined8 local_78;
  undefined8 *local_70;
  undefined1 local_68 [8];
  ulonglong local_60;
  int local_58 [2];
  undefined1 local_50 [16];
  undefined8 local_40;
  ulonglong local_38;
  ulonglong local_30;
  
  puVar8 = auStack_f8;
  local_30 = DAT_180d06cc0 ^ (ulonglong)auStack_f8;
  local_60 = local_60 & 0xffffffff00000000;
  local_a0._0_9_ = ZEXT89(0x180d6eb78);
  local_a0._9_7_ = 0;
  iVar4 = FUN_180973810(&DAT_180d6eb78);
  if (iVar4 != 0) {
                    /* WARNING: Subroutine does not return */
    FUN_1809737c0(5);
  }
  if (DAT_180d6ebc4 != 0x7fffffff) {
    local_a0[8] = 1;
    local_c8[0] = 1;
    FUN_180185e60(&DAT_180d6eb28,local_c8);
    local_60._0_4_ = 0x1e;
    FUN_1801877a0(&DAT_180d6eb28,&local_60,4);
    FUN_1801877a0(&DAT_180d6eb28,&DAT_180d0f4d8,0x1e);
    local_a8 = _Xtime_get_ticks();
    local_88 = &local_a8;
    local_80 = FUN_180191210;
    local_90 = 0xd000000000000000;
    local_40 = 0;
    local_38 = 0xf;
    local_50._1_15_ = SUB1615((undefined1  [16])0x0,1);
    auVar2[0xf] = 0;
    auVar2._0_15_ = local_50._1_15_;
    local_50 = auVar2 << 8;
    local_60._0_4_ = 2;
    FUN_18019f7a0(local_50,0x11);
    local_78 = 1;
    local_70 = &local_90;
    local_b8 = &DAT_180c09610;
    local_b0 = 9;
    local_d8 = 0;
    FUN_18018ad00(local_68,local_50,&local_b8,&local_78);
    local_60._0_4_ = 1;
    FUN_180185f70(&DAT_180d6eb28,&local_60);
    local_60._0_4_ = (undefined4)local_40;
    FUN_1801877a0(&DAT_180d6eb28,&local_60,4);
    puVar6 = local_50;
    if (0xf < local_38) {
      puVar6 = (undefined1 *)local_50._0_8_;
    }
    FUN_1801877a0(&DAT_180d6eb28,puVar6,local_40);
    uVar7 = *param_2;
    local_60._0_4_ = 0;
    FUN_180185f70(&DAT_180d6eb28,&local_60);
    local_60 = CONCAT44(local_60._4_4_,8);
    FUN_1801877a0(&DAT_180d6eb28,&local_60,4);
    local_60 = uVar7;
    FUN_1801877a0(&DAT_180d6eb28,&local_60,8);
    if (DAT_180d6ebe0 != '\0') {
      local_60 = CONCAT44(local_60._4_4_,(int)DAT_180d6eb30 - (int)DAT_180d6eb28);
      FUN_1803c9190(&DAT_180d6ebc8,&local_b8,&local_60,4);
      FUN_1803c9190(&DAT_180d6ebc8,&local_b8,CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28),
                    DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28));
    }
    DAT_180d6eb70 = DAT_180d6eb70 + 1;
    local_b8 = (undefined *)CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
    local_b0 = DAT_180d6eb30 - (longlong)local_b8;
    FUN_1801806e0(&DAT_180d6eb40,&local_b8);
    local_58[0] = ((int)DAT_180d6eb30 - (int)DAT_180d6eb28) + 4;
    FUN_180186fb0(&DAT_180d6ea20,local_58,4);
    FUN_180186fb0(&DAT_180d6ea20,CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28),
                  DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28));
    FUN_180186e20(&DAT_180d6ea20);
    if (CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28) != DAT_180d6eb30) {
      DAT_180d6eb30 = CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
    }
    if (0xf < local_38) {
      uVar7 = local_38 + 1;
      lVar5 = local_50._0_8_;
      if (0xfff < uVar7) {
        lVar5 = *(longlong *)(local_50._0_8_ + -8);
        if (0x1f < (local_50._0_8_ - lVar5) - 8U) {
          pcVar1 = (code *)swi(0x29);
          DAT_180d6ebc4 = (*pcVar1)(5);
          puVar8 = auStack_f0;
          goto LAB_180425057;
        }
        uVar7 = local_38 + 0x28;
      }
      thunk_FUN_180895720(lVar5,uVar7);
    }
    local_40 = 0;
    local_38 = 0xf;
    auVar3[0xf] = 0;
    auVar3._0_15_ = local_50._1_15_;
    local_50 = auVar3 << 8;
    FUN_180973930(&DAT_180d6eb78);
    return;
  }
LAB_180425057:
  DAT_180d6ebc4 = DAT_180d6ebc4 + -1;
                    /* WARNING: Subroutine does not return */
  *(undefined **)(puVar8 + -8) = &UNK_180425069;
  FUN_1809737c0(6);
}

