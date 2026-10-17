// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180430e70; descriptive alias: FUN_180430e70
// Evidence: ev_ed3b6c4a3a0f4e027894a010ef17f09275b7eec779a41b07366d432ef9b2e8b2
// Original Evidence: rea-collector/0x180430e70.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* WARNING: Removing unreachable block (ram,0x000180430f9a) */
/* WARNING: Removing unreachable block (ram,0x000180430f7a) */
/* WARNING: Removing unreachable block (ram,0x000180430fa8) */

void FUN_180430e70(void)

{
  code *pcVar1;
  undefined1 auVar2 [16];
  undefined1 auVar3 [16];
  int iVar4;
  longlong lVar5;
  undefined1 *puVar6;
  ulonglong uVar7;
  undefined1 *puVar8;
  undefined1 auStack_d8 [8];
  undefined1 auStack_d0 [24];
  undefined8 local_b8;
  undefined1 local_a8 [16];
  undefined *local_98;
  longlong local_90;
  undefined8 local_88;
  undefined1 local_80 [16];
  undefined8 local_70;
  undefined8 *local_68;
  code *local_60;
  undefined8 local_58;
  undefined8 *local_50;
  undefined1 local_48 [8];
  int local_40;
  int local_3c;
  undefined1 local_38 [16];
  undefined8 local_28;
  ulonglong local_20;
  ulonglong local_18;
  
  puVar8 = auStack_d8;
  local_18 = DAT_180d06cc0 ^ (ulonglong)auStack_d8;
  local_40 = 0;
  local_80._0_9_ = ZEXT89(0x180d6eb78);
  local_80._9_7_ = 0;
  iVar4 = FUN_180973810(&DAT_180d6eb78);
  if (iVar4 != 0) {
                    /* WARNING: Subroutine does not return */
    FUN_1809737c0(5);
  }
  if (DAT_180d6ebc4 != 0x7fffffff) {
    local_80[8] = 1;
    local_a8[0] = 0;
    FUN_180185e60(&DAT_180d6eb28,local_a8);
    local_40 = 0x1a;
    FUN_1801877a0(&DAT_180d6eb28,&local_40,4);
    FUN_1801877a0(&DAT_180d6eb28,&DAT_180d0ff40,0x1a);
    local_88 = _Xtime_get_ticks();
    local_68 = &local_88;
    local_60 = FUN_180191210;
    local_70 = 0xd000000000000000;
    local_28 = 0;
    local_20 = 0xf;
    local_38._1_15_ = SUB1615((undefined1  [16])0x0,1);
    auVar2[0xf] = 0;
    auVar2._0_15_ = local_38._1_15_;
    local_38 = auVar2 << 8;
    local_40 = 2;
    FUN_18019f7a0(local_38,0x11);
    local_58 = 1;
    local_50 = &local_70;
    local_98 = &DAT_180c09610;
    local_90 = 9;
    local_b8 = 0;
    FUN_18018ad00(local_48,local_38,&local_98,&local_58);
    local_40 = 1;
    FUN_180185f70(&DAT_180d6eb28,&local_40);
    local_40 = (int)local_28;
    FUN_1801877a0(&DAT_180d6eb28,&local_40,4);
    puVar6 = local_38;
    if (0xf < local_20) {
      puVar6 = (undefined1 *)local_38._0_8_;
    }
    FUN_1801877a0(&DAT_180d6eb28,puVar6,local_28);
    if (DAT_180d6ebe0 != '\0') {
      local_40 = (int)DAT_180d6eb30 - (int)DAT_180d6eb28;
      FUN_1803c9190(&DAT_180d6ebc8,&local_98,&local_40,4);
      FUN_1803c9190(&DAT_180d6ebc8,&local_98,CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28),
                    DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28));
    }
    DAT_180d6eb70 = DAT_180d6eb70 + 1;
    local_98 = (undefined *)CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
    local_90 = DAT_180d6eb30 - (longlong)local_98;
    FUN_1801806e0(&DAT_180d6eb40,&local_98);
    local_3c = ((int)DAT_180d6eb30 - (int)DAT_180d6eb28) + 4;
    FUN_180186fb0(&DAT_180d6ea20,&local_3c,4);
    FUN_180186fb0(&DAT_180d6ea20,CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28),
                  DAT_180d6eb30 - CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28));
    FUN_180186e20(&DAT_180d6ea20);
    if (CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28) != DAT_180d6eb30) {
      DAT_180d6eb30 = CONCAT44(DAT_180d6eb28._4_4_,(int)DAT_180d6eb28);
    }
    if (0xf < local_20) {
      uVar7 = local_20 + 1;
      lVar5 = local_38._0_8_;
      if (0xfff < uVar7) {
        lVar5 = *(longlong *)(local_38._0_8_ + -8);
        if (0x1f < (local_38._0_8_ - lVar5) - 8U) {
          pcVar1 = (code *)swi(0x29);
          DAT_180d6ebc4 = (*pcVar1)(5);
          puVar8 = auStack_d0;
          goto LAB_1804311b1;
        }
        uVar7 = local_20 + 0x28;
      }
      thunk_FUN_180895720(lVar5,uVar7);
    }
    local_28 = 0;
    local_20 = 0xf;
    auVar3[0xf] = 0;
    auVar3._0_15_ = local_38._1_15_;
    local_38 = auVar3 << 8;
    FUN_180973930(&DAT_180d6eb78);
    return;
  }
LAB_1804311b1:
  DAT_180d6ebc4 = DAT_180d6ebc4 + -1;
                    /* WARNING: Subroutine does not return */
  *(undefined **)(puVar8 + -8) = &UNK_1804311c3;
  FUN_1809737c0(6);
}

