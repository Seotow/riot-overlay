// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x18043b230; descriptive alias: FUN_18043b230
// Evidence: ev_049ffc98c60deaf03891868f38fd556c9c789c5d893b1c47438ffeb77bd0f802
// Original Evidence: rea-collector/0x18043b230.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined8 FUN_18043b230(longlong param_1,undefined8 param_2,longlong *param_3)

{
  uint uVar1;
  uint uVar2;
  longlong lVar3;
  undefined1 local_38 [8];
  longlong lStack_30;
  
  stack0xffffffffffffffcc = SUB1612((undefined1  [16])0x0,4);
  local_38._0_6_ = 0x736b726570;
  if (DAT_180d37868 == '\0') {
    uVar1 = DAT_180d37400 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar1 = FUN_18052b510(&DAT_180d37400);
  }
  lVar3 = (**(code **)(*param_3 + (ulonglong)(uVar1 >> 3) * 8))(param_3);
  if (DAT_180d3b2b0 == '\0') {
    uVar1 = DAT_180d3ae48 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar1 = FUN_18052b510(&DAT_180d3ae48);
  }
  if (DAT_180d3b2b0 == '\0') {
    uVar2 = DAT_180d3ae48 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar2 = FUN_18052b510(&DAT_180d3ae48);
  }
  lStack_30 = *(longlong *)((ulonglong)uVar2 + lVar3);
  local_38 = (undefined1  [8])param_1;
  FUN_1804423a0(*(undefined8 *)(param_1 + 0x480),param_2,
                (ulonglong)
                (*(longlong *)((ulonglong)uVar1 + 8 + lVar3) -
                *(longlong *)((ulonglong)uVar2 + lVar3)) /
                ((ulonglong)(DAT_180d43cd0 + 0xe6632e3a) ^ 0x11bf48c),local_38);
  return param_2;
}

