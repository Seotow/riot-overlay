// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1804241d0; descriptive alias: FUN_1804241d0
// Evidence: ev_69b3343a43a156e636e299ab7a4297de3625adaaf9e73957ba67a56f3926e063
// Original Evidence: rea-collector/0x1804241d0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

void FUN_1804241d0(longlong param_1,undefined1 *param_2)

{
  undefined4 uVar1;
  undefined1 uVar2;
  undefined1 uVar3;
  undefined1 uVar4;
  undefined1 uVar5;
  byte bVar6;
  byte bVar7;
  uint uVar8;
  code *pcVar9;
  ulonglong uVar10;
  float fVar11;
  undefined4 local_48;
  
  if (DAT_180d62128 == '\0') {
    uVar8 = DAT_180d61cc0 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar8 = FUN_18052b510(&DAT_180d61cc0);
  }
  uVar8 = *(uint *)((ulonglong)uVar8 + param_1);
  if (DAT_180d62598 == '\0') {
    uVar10 = DAT_180d62130 + 0x6df70a65e6632e3aU ^ 0xbcd1994011bf48c;
  }
  else {
    uVar10 = FUN_18052c740(&DAT_180d62130,0);
  }
  uVar2 = (*(code *)(DAT_180d20bd0 + uVar10))(uVar8 & 0xff);
  uVar3 = (*(code *)(DAT_180d20bd0 + uVar10))(uVar8 >> 8 & 0xff);
  uVar4 = (*(code *)(DAT_180d20bd0 + uVar10))(uVar8 >> 0x10 & 0xff);
  uVar5 = (*(code *)(DAT_180d20bd0 + uVar10))(uVar8 >> 0x18);
  param_2[3] = uVar5;
  *param_2 = uVar2;
  param_2[1] = uVar3;
  param_2[2] = uVar4;
  if (DAT_180d61848 == '\0') {
    uVar8 = DAT_180d613e0 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar8 = FUN_18052b510(&DAT_180d613e0);
  }
  uVar8 = *(uint *)((ulonglong)uVar8 + param_1);
  if (DAT_180d61cb8 == '\0') {
    uVar10 = DAT_180d61850 + 0x6df70a65e6632e3aU ^ 0xbcd1994011bf48c;
  }
  else {
    uVar10 = FUN_18052c740(&DAT_180d61850,0);
  }
  uVar2 = (*(code *)(DAT_180d20bd0 + uVar10))(uVar8 & 0xff);
  uVar3 = (*(code *)(DAT_180d20bd0 + uVar10))(uVar8 >> 8 & 0xff);
  uVar4 = (*(code *)(DAT_180d20bd0 + uVar10))(uVar8 >> 0x10 & 0xff);
  uVar5 = (*(code *)(DAT_180d20bd0 + uVar10))(uVar8 >> 0x18);
  param_2[7] = uVar5;
  param_2[4] = uVar2;
  param_2[5] = uVar3;
  param_2[6] = uVar4;
  if (DAT_180d64918 == '\0') {
    uVar10 = DAT_180d644b0 + 0x6df70a65e6632e3aU ^ 0xbcd1994011bf48c;
  }
  else {
    uVar10 = FUN_18052c740(&DAT_180d644b0,0);
  }
  pcVar9 = (code *)(DAT_180d20bd0 + uVar10);
  if (DAT_180d644a8 == '\0') {
    uVar8 = DAT_180d64040 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar8 = FUN_18052b510(&DAT_180d64040);
  }
  uVar2 = (*pcVar9)(*(undefined1 *)((ulonglong)uVar8 + param_1));
  param_2[8] = uVar2;
  if (DAT_180d62e78 == '\0') {
    uVar10 = DAT_180d62a10 + 0x6df70a65e6632e3aU ^ 0xbcd1994011bf48c;
  }
  else {
    uVar10 = FUN_18052c740(&DAT_180d62a10,0);
  }
  pcVar9 = (code *)(DAT_180d20bd0 + uVar10);
  if (DAT_180d62a08 == '\0') {
    uVar8 = DAT_180d625a0 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar8 = FUN_18052b510(&DAT_180d625a0);
  }
  bVar6 = (*pcVar9)(*(undefined1 *)((ulonglong)uVar8 + param_1));
  bVar7 = 7;
  if (bVar6 < 7) {
    bVar7 = bVar6;
  }
  param_2[9] = bVar7;
  if (DAT_180d651f8 == '\0') {
    uVar10 = DAT_180d64d90 + 0x6df70a65e6632e3aU ^ 0xbcd1994011bf48c;
  }
  else {
    uVar10 = FUN_18052c740(&DAT_180d64d90,0);
  }
  pcVar9 = (code *)(DAT_180d20bd0 + uVar10);
  if (DAT_180d64d88 == '\0') {
    uVar8 = DAT_180d64920 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar8 = FUN_18052b510(&DAT_180d64920);
  }
  bVar6 = (*pcVar9)(*(undefined1 *)((ulonglong)uVar8 + param_1));
  bVar7 = 3;
  if (bVar6 < 3) {
    bVar7 = bVar6;
  }
  param_2[10] = bVar7;
  if (DAT_180d65f48 == '\0') {
    uVar8 = DAT_180d65ae0 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar8 = FUN_18052b510(&DAT_180d65ae0);
  }
  uVar8 = *(uint *)((ulonglong)uVar8 + param_1);
  if (DAT_180d663b8 == '\0') {
    uVar10 = DAT_180d65f50 + 0x6df70a65e6632e3aU ^ 0xbcd1994011bf48c;
  }
  else {
    uVar10 = FUN_18052c740(&DAT_180d65f50,0);
  }
  uVar2 = (*(code *)(DAT_180d20bd0 + uVar10))(uVar8 & 0xff);
  uVar3 = (*(code *)(DAT_180d20bd0 + uVar10))(uVar8 >> 8 & 0xff);
  uVar4 = (*(code *)(DAT_180d20bd0 + uVar10))(uVar8 >> 0x10 & 0xff);
  uVar5 = (*(code *)(DAT_180d20bd0 + uVar10))(uVar8 >> 0x18);
  param_2[0x13] = uVar5;
  param_2[0x10] = uVar2;
  param_2[0x11] = uVar3;
  param_2[0x12] = uVar4;
  if (DAT_180d632e8 == '\0') {
    uVar8 = DAT_180d62e80 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar8 = FUN_18052b510(&DAT_180d62e80);
  }
  uVar1 = *(undefined4 *)((ulonglong)uVar8 + param_1);
  if (DAT_180d63758 == '\0') {
    uVar10 = DAT_180d632f0 + 0x6df70a65e6632e3aU ^ 0xbcd1994011bf48c;
  }
  else {
    uVar10 = FUN_18052c740(&DAT_180d632f0,0);
  }
  local_48._0_1_ = (undefined1)uVar1;
  uVar2 = (*(code *)(DAT_180d20bd0 + uVar10))((undefined1)local_48);
  local_48._1_1_ = (undefined1)((uint)uVar1 >> 8);
  uVar3 = (*(code *)(DAT_180d20bd0 + uVar10))(local_48._1_1_);
  local_48._2_1_ = (undefined1)((uint)uVar1 >> 0x10);
  local_48._0_2_ = CONCAT11(uVar3,uVar2);
  uVar2 = (*(code *)(DAT_180d20bd0 + uVar10))(local_48._2_1_);
  local_48._3_1_ = (undefined1)((uint)uVar1 >> 0x18);
  local_48._0_3_ = CONCAT12(uVar2,(undefined2)local_48);
  uVar2 = (*(code *)(DAT_180d20bd0 + uVar10))(local_48._3_1_);
  local_48 = CONCAT13(uVar2,(undefined3)local_48);
  *(undefined4 *)(param_2 + 0xc) = local_48;
  if (DAT_180d63bc8 == '\0') {
    uVar8 = DAT_180d63760 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar8 = FUN_18052b510(&DAT_180d63760);
  }
  fVar11 = (float)(int)*(char *)((ulonglong)uVar8 + param_1);
  if (DAT_180d64038 == '\0') {
    uVar10 = DAT_180d63bd0 + 0x6df70a65e6632e3aU ^ 0xbcd1994011bf48c;
  }
  else {
    uVar10 = FUN_18052c740(&DAT_180d63bd0,0);
  }
  local_48._0_1_ = SUB41(fVar11,0);
  uVar2 = (*(code *)(DAT_180d20bd0 + uVar10))((undefined1)local_48);
  local_48._1_1_ = (undefined1)((uint)fVar11 >> 8);
  uVar3 = (*(code *)(DAT_180d20bd0 + uVar10))(local_48._1_1_);
  local_48._2_1_ = (undefined1)((uint)fVar11 >> 0x10);
  local_48._0_2_ = CONCAT11(uVar3,uVar2);
  uVar2 = (*(code *)(DAT_180d20bd0 + uVar10))(local_48._2_1_);
  local_48._3_1_ = (undefined1)((uint)fVar11 >> 0x18);
  local_48._0_3_ = CONCAT12(uVar2,(undefined2)local_48);
  uVar2 = (*(code *)(DAT_180d20bd0 + uVar10))(local_48._3_1_);
  local_48 = CONCAT13(uVar2,(undefined3)local_48);
  *(undefined4 *)(param_2 + 0x14) = local_48;
  if (DAT_180d65668 == '\0') {
    uVar8 = DAT_180d65200 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar8 = FUN_18052b510(&DAT_180d65200);
  }
  uVar8 = *(uint *)((ulonglong)uVar8 + param_1);
  if (DAT_180d65ad8 == '\0') {
    uVar10 = DAT_180d65670 + 0x6df70a65e6632e3aU ^ 0xbcd1994011bf48c;
  }
  else {
    uVar10 = FUN_18052c740(&DAT_180d65670,0);
  }
  uVar2 = (*(code *)(DAT_180d20bd0 + uVar10))(uVar8 & 0xff);
  uVar3 = (*(code *)(DAT_180d20bd0 + uVar10))((int)uVar8 >> 8 & 0xff);
  uVar4 = (*(code *)(DAT_180d20bd0 + uVar10))((int)uVar8 >> 0x10 & 0xff);
  uVar5 = (*(code *)(DAT_180d20bd0 + uVar10))((int)uVar8 >> 0x18 & 0xff);
  param_2[0x1a] = uVar4;
  param_2[0x1b] = uVar5;
  param_2[0x18] = uVar2;
  param_2[0x19] = uVar3;
  return;
}

