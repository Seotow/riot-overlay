// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x18043e9e0; descriptive alias: filter_game_events_by_features
// Evidence: ev_e01dec728266452a9c114a3598a92cf428be2d5ee6699238c7099e12ef19ff9d
// Original Evidence: rea-snapshot-events.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */

longlong FUN_18043e9e0(longlong param_1,longlong param_2,undefined8 param_3)

{
  longlong lVar1;
  longlong lVar2;
  undefined8 uVar3;
  undefined8 uVar4;
  undefined8 uVar5;
  undefined8 uVar6;
  undefined1 uVar7;
  undefined4 uVar8;
  undefined1 uVar9;
  undefined1 uVar10;
  undefined4 uVar11;
  undefined4 uVar12;
  undefined1 auStack_158 [32];
  undefined1 local_138 [24];
  undefined1 local_120 [24];
  undefined1 local_108 [24];
  undefined1 local_f0 [24];
  undefined1 local_d8 [24];
  undefined1 local_c0 [24];
  undefined1 local_a8 [24];
  undefined1 local_90 [24];
  undefined1 local_78 [24];
  longlong local_60;
  longlong local_58;
  undefined8 local_50;
  undefined8 local_48;
  undefined8 local_40;
  undefined8 local_38;
  ulonglong local_28;
  
  local_28 = DAT_180d06cc0 ^ (ulonglong)auStack_158;
  FUN_18043ec00(local_138,param_3);
  lVar1 = local_60;
  if ((*(byte *)(param_1 + 0x488) & 4) == 0) {
    for (; lVar1 != local_58; lVar1 = lVar1 + 0x1c) {
      if ((*(byte *)(param_1 + 0x488) & 1) == 0) {
        uVar12 = 0;
        uVar7 = 3;
        uVar9 = 7;
        uVar10 = 0;
        uVar8 = 0;
        uVar11 = 0;
      }
      else {
        uVar11 = *(undefined4 *)(lVar1 + 0xc);
        uVar8 = *(undefined4 *)(lVar1 + 0x14);
        uVar12 = *(undefined4 *)(lVar1 + 0x18);
        uVar7 = *(undefined1 *)(lVar1 + 0x10);
        uVar9 = *(undefined1 *)(lVar1 + 0x11);
        uVar10 = *(undefined1 *)(lVar1 + 0x12);
      }
      *(undefined4 *)(lVar1 + 0xc) = uVar11;
      *(undefined1 *)(lVar1 + 0x10) = uVar7;
      *(undefined1 *)(lVar1 + 0x11) = uVar9;
      *(undefined1 *)(lVar1 + 0x12) = uVar10;
      *(undefined1 *)(lVar1 + 0x13) = 0;
      *(undefined4 *)(lVar1 + 0x14) = uVar8;
      *(undefined4 *)(lVar1 + 0x18) = uVar12;
    }
    FUN_180443e60(local_78,0,0);
    FUN_180443b50(local_a8,0,0);
    if ((*(byte *)(param_1 + 0x488) & 2) == 0) {
      FUN_180443d00(local_c0,0,0);
      FUN_1802b4d00(local_d8,0,0);
      FUN_1804439a0(local_f0,0,0);
      FUN_180443b50(local_108,0,0);
      FUN_1804439a0(local_120,0,0);
    }
    FUN_18043ece0(param_2,local_138);
    uVar6 = local_38;
    uVar5 = local_40;
    uVar4 = local_48;
    uVar3 = local_50;
    lVar2 = local_58;
    lVar1 = local_60;
    local_50 = 0;
    local_58 = 0;
    local_60 = 0;
    *(longlong *)(param_2 + 0xd8) = lVar1;
    *(longlong *)(param_2 + 0xe0) = lVar2;
    *(undefined8 *)(param_2 + 0xe8) = uVar3;
    local_38 = 0;
    local_40 = 0;
    local_48 = 0;
    *(undefined8 *)(param_2 + 0xf0) = uVar4;
    *(undefined8 *)(param_2 + 0xf8) = uVar5;
    *(undefined8 *)(param_2 + 0x100) = uVar6;
  }
  else {
    FUN_18043ec00(param_2,param_3);
  }
  FUN_18022fbb0(&local_48);
  FUN_1801e5ed0(&local_60);
  FUN_1803fb4e0(local_78);
  FUN_1801d11e0(local_90);
  FUN_1801f3260(local_a8);
  FUN_1801d11e0(local_c0);
  FUN_1801ad9b0(local_d8);
  FUN_1802d14e0(local_f0);
  FUN_1801f3260(local_108);
  FUN_1802d14e0(local_120);
  FUN_1802d14e0(local_138);
  return param_2;
}

