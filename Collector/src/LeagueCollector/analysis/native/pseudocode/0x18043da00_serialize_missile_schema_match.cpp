// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x18043da00; descriptive alias: serialize_missile_schema_match
// Evidence: ev_3046bc66a93f9e69546ed7340f7c2a6e01abf86842fd653845c605e917677c4e
// Original Evidence: rea-snapshot-feature-object.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined4 * FUN_18043da00(longlong param_1,undefined4 *param_2,longlong param_3)

{
  undefined4 uVar1;
  uint uVar2;
  undefined4 *puVar3;
  undefined4 uVar4;
  uint uVar5;
  uint uVar6;
  undefined1 local_68 [15];
  undefined1 local_59;
  
  local_59 = 0;
  if ((*(byte *)(param_1 + 0x488) & 2) == 0) {
    *param_2 = 0;
  }
  else {
    uVar5 = DAT_180d3c018 + 0xe6632e3a;
    uVar6 = DAT_180d3c014 + 0xe6632e3a;
    if (DAT_180d3c008 == '\0') {
      uVar2 = DAT_180d3bba0 + 0xe6632e3aU ^ 0x11bf48c;
    }
    else {
      uVar2 = FUN_18052b510(&DAT_180d3bba0);
    }
    if (*(int *)((ulonglong)(uVar2 + 8) + param_3) == 0) {
      uVar4 = 0;
    }
    else {
      if (DAT_180d3c008 == '\0') {
        uVar2 = DAT_180d3bba0 + 0xe6632e3aU ^ 0x11bf48c;
      }
      else {
        uVar2 = FUN_18052b510(&DAT_180d3bba0);
      }
      uVar4 = **(undefined4 **)((ulonglong)uVar2 + param_3);
    }
    if (DAT_180d3bb98 == '\0') {
      uVar2 = DAT_180d3b730 + 0xe6632e3aU ^ 0x11bf48c;
    }
    else {
      uVar2 = FUN_18052b510(&DAT_180d3b730);
    }
    uVar1 = *(undefined4 *)((ulonglong)uVar2 + param_3);
    puVar3 = (undefined4 *)FUN_1804395d0(param_1,local_68,param_3);
    FUN_180437f10(param_2,*(undefined8 *)(param_1 + 0x480),*puVar3,uVar1,uVar4,
                  ((ulonglong)uVar6 ^ 0x11bf48c) + param_3,((ulonglong)uVar5 ^ 0x11bf48c) + param_3)
    ;
  }
  return param_2;
}

