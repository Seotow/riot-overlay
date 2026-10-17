// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1804258b0; descriptive alias: FUN_1804258b0
// Evidence: ev_89863df61d1ebfd7ca3fcf02f5d4934c6a315a0e1adb17c4eb1890c360f99696
// Original Evidence: rea-collector/0x1804258b0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* WARNING: Removing unreachable block (ram,0x000180425a44) */
/* WARNING: Removing unreachable block (ram,0x000180425a23) */
/* WARNING: Removing unreachable block (ram,0x000180425a52) */

ulonglong FUN_1804258b0(undefined8 param_1,short param_2)

{
  code *pcVar1;
  undefined1 auVar2 [16];
  undefined1 auVar3 [16];
  char cVar4;
  int iVar5;
  ulonglong uVar6;
  longlong lVar7;
  undefined1 *puVar8;
  ulonglong uVar9;
  undefined1 auStack_e8 [8];
  undefined1 auStack_e0 [24];
  undefined8 local_c8;
  undefined1 local_b8 [16];
  undefined *local_a8;
  longlong local_a0;
  undefined8 local_98;
  undefined1 local_90 [16];
  undefined8 local_80;
  undefined8 *local_78;
  code *local_70;
  undefined8 local_68;
  undefined8 *local_60;
  undefined1 local_58 [8];
  ulonglong local_50;
  int local_48 [2];
  undefined1 local_40 [16];
  undefined8 local_30;
  ulonglong local_28;
  ulonglong local_20;
  
  puVar8 = auStack_e8;
  local_20 = DAT_180d06cc0 ^ (ulonglong)auStack_e8;
  local_50 = local_50 & 0xffffffff00000000;
  if (DAT_180d40778 == '\0') {
    uVar6 = DAT_180d40310 + 0x6df70a65e6632e3aU ^ 0xbcd1994011bf48c;
  }
  else {
    uVar6 = FUN_18052c740(&DAT_180d40310,0);
  }
  uVar6 = (*(code *)(uVar6 + DAT_180d20bd0))(param_1,param_2);
  cVar4 = FUN_1801fa260(uVar6);
  if (cVar4 == '\0') {
    local_90._0_9_ = ZEXT89(0x180d6eb78);
    local_90._9_7_ = 0;
    iVar5 = FUN_180973810(&DAT_180d6eb78);
    if (iVar5 != 0) {
                    /* WARNING: Subroutine does not return */
      FUN_1809737c0(5);
    }
    if (DAT_180d6ebc4 == 0x7fffffff) {
      DAT_180d6ebc4 = 0x7ffffffe;
                    /* WARNING: Subroutine does not return */
      FUN_1809737c0(6);
    }
    local_90[8] = 1;
    local_b8[0] = 0;
    FUN_180185e60(&DAT_180d6eb28,local_b8);
    local_50._0_4_ = 0x30;
    FUN_1801877a0(&DAT_180d6eb28,&local_50,4);
    FUN_1801877a0(&DAT_180d6eb28,&DAT_180d0f4f8,0x30);
    local_98 = _Xtime_get_ticks();
    local_78 = &local_98;
    local_70 = FUN_180191210;
    local_80 = 0xd000000000000000;
    local_30 = 0;
    local_28 = 0xf;
    local_40._1_15_ = SUB1615((undefined1  [16])0x0,1);
    auVar2[0xf] = 0;
    auVar2._0_15_ = local_40._1_15_;
    local_40 = auVar2 << 8;
    local_50._0_4_ = 2;
    FUN_18019f7a0(local_40,0x11);
    local_68 = 1;
    local_60 = &local_80;
    local_a8 = &DAT_180c09610;
    local_a0 = 9;
    local_c8 = 0;
    FUN_18018ad00(local_58,local_40,&local_a8,&local_68);
    local_50._0_4_ = 1;
    FUN_180185f70(&DAT_180d6eb28,&local_50);
    local_50._0_4_ = (undefined4)local_30;
    FUN_1801877a0(&DAT_180d6eb28,&local_50,4);
    puVar8 = local_40;
    if (0xf < local_28) {
      puVar8 = (undefined1 *)local_40._0_8_;
    }
    FUN_1801877a0(&DAT_180d6eb28,puVar8,local_30);
    local_50._0_4_ = 0;
    FUN_180185f70(&DAT_180d6eb28,&local_50);
    local_50 = CONCAT44(local_50._4_4_,8);
    FUN_1801877a0(&DAT_180d6eb28,&local_50,4);
    local_50 = uVar6;
    FUN_1801877a0(&DAT_180d6eb28,&local_50,8);
    local_50 = local_50 & 0xffffffff00000000;
    FUN_180185f70(&DAT_180d6eb28,&local_50);
    local_50._0_4_ = 4;
    FUN_1801877a0(&DAT_180d6eb28,&local_50,4);
    local_50._0_4_ = (int)param_2;
    FUN_1801877a0(&DAT_180d6eb28,&local_50,4);
    if (DAT_180d6ebe0 != '\0') {
      local_50._0_4_ = (int)DAT_180d6eb30 - (int)DAT_180d6eb28;
      FUN_1803c9190(&DAT_180d6ebc8,&local_a8,&local_50,4);
      FUN_1803c9190(&DAT_180d6ebc8,&local_a8,CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28),
                    DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28));
    }
    DAT_180d6eb70 = DAT_180d6eb70 + 1;
    local_a8 = (undefined *)CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
    local_a0 = DAT_180d6eb30 - (longlong)local_a8;
    FUN_1801806e0(&DAT_180d6eb40,&local_a8);
    local_48[0] = ((int)DAT_180d6eb30 - (int)DAT_180d6eb28) + 4;
    FUN_180186fb0(&DAT_180d6ea20,local_48,4);
    FUN_180186fb0(&DAT_180d6ea20,CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28),
                  DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28));
    FUN_180186e20(&DAT_180d6ea20);
    if (CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28) != DAT_180d6eb30) {
      DAT_180d6eb30 = CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
    }
    if (0xf < local_28) {
      uVar9 = local_28 + 1;
      lVar7 = local_40._0_8_;
      if (0xfff < uVar9) {
        lVar7 = *(longlong *)(local_40._0_8_ + -8);
        if (0x1f < (local_40._0_8_ - lVar7) - 8U) {
          pcVar1 = (code *)swi(0x29);
          (*pcVar1)(5);
          puVar8 = auStack_e0;
          goto LAB_180425cd4;
        }
        uVar9 = local_28 + 0x28;
      }
      thunk_FUN_180895720(lVar7,uVar9);
    }
    local_30 = 0;
    local_28 = 0xf;
    auVar3[0xf] = 0;
    auVar3._0_15_ = local_40._1_15_;
    local_40 = auVar3 << 8;
    FUN_180973930(&DAT_180d6eb78);
    uVar6 = 0;
    puVar8 = auStack_e8;
  }
LAB_180425cd4:
  *(undefined8 *)(puVar8 + -8) = 0x180425ce0;
  return uVar6;
}

