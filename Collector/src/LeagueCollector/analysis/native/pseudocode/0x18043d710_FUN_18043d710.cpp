// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x18043d710; descriptive alias: FUN_18043d710
// Evidence: ev_7085d285106bf98afb13505fad747f8aeb258b5d3032069a1c22aa4b866bb9b1
// Original Evidence: rea-collector/0x18043d710.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined8 FUN_18043d710(longlong param_1,undefined8 param_2,longlong *param_3)

{
  char cVar1;
  char cVar2;
  uint uVar3;
  undefined8 uVar4;
  undefined4 *puVar5;
  undefined4 uVar6;
  undefined4 uVar7;
  byte bVar8;
  undefined1 local_58 [4];
  undefined1 local_54 [44];
  
  bVar8 = 0;
  uVar6 = 0;
  uVar7 = 0;
  if ((*(byte *)(param_1 + 0x488) & 4) != 0) {
    if (DAT_180d37cd8 == '\0') {
      uVar3 = DAT_180d37870 + 0xe6632e3aU ^ 0x11bf48c;
    }
    else {
      uVar3 = FUN_18052b510(&DAT_180d37870);
    }
    cVar1 = (**(code **)(*param_3 + (ulonglong)uVar3 * 8))(param_3);
    bVar8 = cVar1 != '\0';
    if (DAT_180d38148 == '\0') {
      uVar3 = DAT_180d37ce0 + 0xe6632e3aU ^ 0x11bf48c;
    }
    else {
      uVar3 = FUN_18052b510(&DAT_180d37ce0);
    }
    cVar2 = (**(code **)(*param_3 + (ulonglong)uVar3 * 8))(param_3);
    if (cVar2 != '\0') {
      bVar8 = (cVar1 != '\0') + 2;
    }
    if (DAT_180d385b8 == '\0') {
      uVar3 = DAT_180d38150 + 0xe6632e3aU ^ 0x11bf48c;
    }
    else {
      uVar3 = FUN_18052b510(&DAT_180d38150);
    }
    cVar1 = (**(code **)(*param_3 + (ulonglong)uVar3 * 8))(param_3);
    if (cVar1 != '\0') {
      bVar8 = bVar8 | 4;
    }
    if (DAT_180d38a28 == '\0') {
      uVar3 = DAT_180d385c0 + 0xe6632e3aU ^ 0x11bf48c;
    }
    else {
      uVar3 = FUN_18052b510(&DAT_180d385c0);
    }
    cVar1 = (**(code **)(*param_3 + (ulonglong)uVar3 * 8))(param_3);
    if (cVar1 != '\0') {
      bVar8 = bVar8 | 8;
    }
    if (DAT_180d38e98 == '\0') {
      uVar3 = DAT_180d38a30 + 0xe6632e3aU ^ 0x11bf48c;
    }
    else {
      uVar3 = FUN_18052b510(&DAT_180d38a30);
    }
    cVar1 = (**(code **)(*param_3 + (ulonglong)uVar3 * 8))(param_3);
    if (cVar1 != '\0') {
      bVar8 = bVar8 | 0x10;
    }
    if (DAT_180d39308 == '\0') {
      uVar3 = DAT_180d38ea0 + 0xe6632e3aU ^ 0x11bf48c;
    }
    else {
      uVar3 = FUN_18052b510(&DAT_180d38ea0);
    }
    cVar1 = (**(code **)(*param_3 + (ulonglong)uVar3 * 8))(param_3);
    if (cVar1 != '\0') {
      bVar8 = bVar8 | 0x20;
    }
    if (DAT_180d39308 == '\0') {
      uVar3 = DAT_180d38ea0 + 0xe6632e3aU ^ 0x11bf48c;
    }
    else {
      uVar3 = FUN_18052b510(&DAT_180d38ea0);
    }
    cVar1 = (**(code **)(*param_3 + (ulonglong)uVar3 * 8))(param_3);
    uVar7 = uVar6;
    if (cVar1 == '\0') {
      if (DAT_180d38148 == '\0') {
        uVar3 = DAT_180d37ce0 + 0xe6632e3aU ^ 0x11bf48c;
      }
      else {
        uVar3 = FUN_18052b510(&DAT_180d37ce0);
      }
      cVar1 = (**(code **)(*param_3 + (ulonglong)uVar3 * 8))(param_3);
      if (cVar1 == '\0') {
        if (DAT_180d385b8 == '\0') {
          uVar3 = DAT_180d38150 + 0xe6632e3aU ^ 0x11bf48c;
        }
        else {
          uVar3 = FUN_18052b510(&DAT_180d38150);
        }
        cVar1 = (**(code **)(*param_3 + (ulonglong)uVar3 * 8))(param_3);
        if (cVar1 == '\0') {
          if (DAT_180d38a28 == '\0') {
            uVar3 = DAT_180d385c0 + 0xe6632e3aU ^ 0x11bf48c;
          }
          else {
            uVar3 = FUN_18052b510(&DAT_180d385c0);
          }
          cVar1 = (**(code **)(*param_3 + (ulonglong)uVar3 * 8))(param_3);
          if (cVar1 == '\0') goto LAB_18043d998;
        }
        uVar4 = FUN_180432200(param_3);
        puVar5 = (undefined4 *)FUN_18043b5c0(param_1,local_58,uVar4);
        uVar7 = *puVar5;
      }
    }
  }
LAB_18043d998:
  puVar5 = (undefined4 *)FUN_180439a70(param_1,local_58,param_3,0);
  uVar6 = *puVar5;
  puVar5 = (undefined4 *)FUN_1804395d0(param_1,local_54,param_3);
  FUN_180437be0(param_2,*(undefined8 *)(param_1 + 0x480),*puVar5,uVar6,bVar8,uVar7);
  return param_2;
}

