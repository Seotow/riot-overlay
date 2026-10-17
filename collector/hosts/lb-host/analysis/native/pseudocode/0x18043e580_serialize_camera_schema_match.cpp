// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x18043e580; descriptive alias: serialize_camera_schema_match
// Evidence: ev_87cc00aab3d391dc8a25838b77306f973b35ea657af84658165e1846ce8d5f24
// Original Evidence: rea-snapshot-camera.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined4 * FUN_18043e580(longlong param_1,undefined4 *param_2)

{
  undefined1 uVar1;
  undefined1 uVar2;
  undefined4 uVar3;
  undefined8 uVar4;
  undefined8 uVar5;
  char cVar6;
  uint uVar7;
  int iVar8;
  undefined4 uVar9;
  longlong *plVar10;
  longlong lVar11;
  longlong *plVar12;
  undefined1 auVar13 [64];
  undefined1 auVar14 [64];
  undefined8 local_118;
  undefined4 local_110;
  undefined8 *local_108;
  longlong local_100;
  longlong local_f8;
  longlong local_e8;
  longlong lStack_e0;
  longlong lStack_d8;
  longlong lStack_d0;
  longlong local_c8;
  longlong lStack_c0;
  longlong lStack_b8;
  longlong lStack_b0;
  longlong local_a8;
  longlong lStack_a0;
  longlong lStack_98;
  longlong lStack_90;
  longlong local_88;
  longlong lStack_80;
  longlong lStack_78;
  longlong lStack_70;
  
  plVar12 = (longlong *)0x0;
  if ((*(byte *)(param_1 + 0x488) & 4) == 0) {
LAB_18043e6e4:
    *param_2 = 0;
  }
  else {
    local_f8 = param_1;
    if (DAT_180d469a0 == '\0') {
      uVar7 = DAT_180d46538 + 0xe6632e3aU ^ 0x11bf48c;
    }
    else {
      uVar7 = FUN_18052b510(&DAT_180d46538);
    }
    plVar10 = plVar12;
    if (uVar7 != 0) {
      plVar10 = (longlong *)((ulonglong)uVar7 + DAT_180d20bd0);
    }
    local_100 = *plVar10;
    local_e8 = 0;
    lStack_e0 = 0;
    lStack_d8 = 0;
    lStack_d0 = 0;
    local_c8 = 0;
    lStack_c0 = 0;
    lStack_b8 = 0;
    lStack_b0 = 0;
    local_a8 = 0;
    lStack_a0 = 0;
    lStack_98 = 0;
    lStack_90 = 0;
    local_88 = 0;
    lStack_80 = 0;
    lStack_78 = 0;
    lStack_70 = 0;
    if (DAT_180d47280 == '\0') {
      uVar7 = DAT_180d46e18 + 0xe6632e3aU ^ 0x11bf48c;
    }
    else {
      uVar7 = FUN_18052b510(&DAT_180d46e18);
    }
    if (uVar7 != 0) {
      plVar12 = (longlong *)((ulonglong)uVar7 + DAT_180d20bd0);
    }
    iVar8 = FUN_180973810(&DAT_180d0f9b0);
    if (iVar8 != 0) {
                    /* WARNING: Subroutine does not return */
      FUN_1809737c0(5);
    }
    if (DAT_180d0f9fc == 0x7fffffff) {
      DAT_180d0f9fc = 0x7ffffffe;
                    /* WARNING: Subroutine does not return */
      FUN_1809737c0(6);
    }
    if (DAT_180d0fa80 == '\0') {
      if (plVar12 == (longlong *)0x0) goto LAB_18043e6d7;
      local_e8 = *plVar12;
      lStack_e0 = plVar12[1];
      lStack_d8 = plVar12[2];
      lStack_d0 = plVar12[3];
      local_c8 = plVar12[4];
      lStack_c0 = plVar12[5];
      lStack_b8 = plVar12[6];
      lStack_b0 = plVar12[7];
      local_a8 = plVar12[8];
      lStack_a0 = plVar12[9];
      lStack_98 = plVar12[10];
      lStack_90 = plVar12[0xb];
      local_88 = plVar12[0xc];
      lStack_80 = plVar12[0xd];
      lStack_78 = plVar12[0xe];
      lStack_70 = plVar12[0xf];
    }
    else {
      if (DAT_180d0fa81 == '\0') {
LAB_18043e6d7:
        FUN_180973930(&DAT_180d0f9b0);
        goto LAB_18043e6e4;
      }
      local_e8 = _DAT_180d0fa00;
      lStack_e0 = lRam0000000180d0fa08;
      lStack_d8 = lRam0000000180d0fa10;
      lStack_d0 = lRam0000000180d0fa18;
      local_c8 = _DAT_180d0fa20;
      lStack_c0 = lRam0000000180d0fa28;
      lStack_b8 = lRam0000000180d0fa30;
      lStack_b0 = lRam0000000180d0fa38;
      local_a8 = _DAT_180d0fa40;
      lStack_a0 = lRam0000000180d0fa48;
      lStack_98 = lRam0000000180d0fa50;
      lStack_90 = lRam0000000180d0fa58;
      local_88 = _DAT_180d0fa60;
      lStack_80 = lRam0000000180d0fa68;
      lStack_78 = lRam0000000180d0fa70;
      lStack_70 = lRam0000000180d0fa78;
    }
    FUN_180973930(&DAT_180d0f9b0);
    local_118 = 0;
    local_110 = 0;
    local_108 = (undefined8 *)0x0;
    lVar11 = FUN_180420df0();
    if ((((lVar11 != 0) && (cVar6 = FUN_1801fa260(lVar11), cVar6 != '\0')) &&
        (lVar11 = FUN_1804212b0(lVar11), lVar11 != 0)) &&
       (cVar6 = FUN_1801fa260(lVar11), cVar6 != '\0')) {
      if (DAT_180d5d140 == '\0') {
        uVar7 = DAT_180d5ccd8 + 0xe6632e3aU ^ 0x11bf48c;
      }
      else {
        uVar7 = FUN_18052b510(&DAT_180d5ccd8);
      }
      local_118 = *(undefined8 *)((ulonglong)uVar7 + lVar11);
      local_110 = *(undefined4 *)((ulonglong)uVar7 + 8 + lVar11);
      local_108 = &local_118;
    }
    lVar11 = FUN_180233850();
    iVar8 = FUN_180973810(lVar11 + 0xf0);
    if (iVar8 != 0) {
                    /* WARNING: Subroutine does not return */
      FUN_1809737c0(5);
    }
    if (*(int *)(lVar11 + 0x13c) == 0x7fffffff) {
      *(undefined4 *)(lVar11 + 0x13c) = 0x7ffffffe;
                    /* WARNING: Subroutine does not return */
      FUN_1809737c0(6);
    }
    uVar1 = *(undefined1 *)(lVar11 + 0x140);
    uVar4 = *(undefined8 *)(lVar11 + 0x148);
    uVar5 = *(undefined8 *)(lVar11 + 0x150);
    auVar14 = ZEXT464(*(uint *)(lVar11 + 0x158));
    auVar13 = ZEXT464(*(uint *)(lVar11 + 0x15c));
    uVar9 = *(undefined4 *)(lVar11 + 0x160);
    uVar2 = *(undefined1 *)(lVar11 + 0x164);
    FUN_180973930(lVar11 + 0xf0);
    lVar11 = *(longlong *)(param_1 + 0x480);
    *(undefined1 *)(lVar11 + 0x60) = 1;
    uVar3 = *(undefined4 *)(lVar11 + 0x30);
    FUN_1801bd6b0(lVar11,8,uVar5);
    FUN_1801bd6b0(lVar11,6,uVar4);
    FUN_1801bd800(lVar11,0xe,uVar9,0);
    FUN_1801bd8b0(lVar11,0xc,auVar13._0_8_,0);
    FUN_1801bd8b0(lVar11,10,auVar14._0_8_,0);
    FUN_1801bd620(lVar11,0x10,uVar2,0);
    FUN_1801bd620(lVar11,4,uVar1,0);
    uVar9 = FUN_1801be990(lVar11,uVar3);
    if (DAT_180d47b70 == '\0') {
      uVar7 = DAT_180d47708 + 0xe6632e3aU ^ 0x11bf48c;
    }
    else {
      uVar7 = FUN_18052b510(&DAT_180d47708);
    }
    lVar11 = local_100;
    uVar3 = *(undefined4 *)((ulonglong)uVar7 + local_100);
    if (DAT_180d47700 == '\0') {
      uVar7 = DAT_180d47298 + 0xe6632e3aU ^ 0x11bf48c;
    }
    else {
      uVar7 = FUN_18052b510(&DAT_180d47298);
    }
    FUN_180434c40(param_2,*(undefined8 *)(local_f8 + 0x480),
                  *(undefined4 *)((ulonglong)uVar7 + lVar11),uVar3,&local_e8,&local_a8,local_108,
                  uVar9);
  }
  return param_2;
}

