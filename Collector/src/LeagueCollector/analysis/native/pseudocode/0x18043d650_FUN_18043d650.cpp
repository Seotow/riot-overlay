// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x18043d650; descriptive alias: FUN_18043d650
// Evidence: ev_d6fe84e4186d4b5f989a0a909a9663549b9da5011938008497a30262a1dff3f9
// Original Evidence: rea-collector/0x18043d650.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined8 FUN_18043d650(longlong param_1,undefined8 param_2,longlong param_3)

{
  undefined4 uVar1;
  uint uVar2;
  undefined1 uVar3;
  uint uVar4;
  undefined4 *puVar5;
  undefined1 local_58 [4];
  undefined1 local_54 [44];
  
  uVar3 = FUN_180432080(param_3);
  if (DAT_180d30dd8 == '\0') {
    uVar4 = DAT_180d30970 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar4 = FUN_18052b510(&DAT_180d30970);
  }
  uVar2 = *(uint *)((ulonglong)uVar4 + param_3);
  if (0xff < *(uint *)((ulonglong)uVar4 + param_3)) {
    uVar2 = 0xff;
  }
  puVar5 = (undefined4 *)FUN_180439a70(param_1,local_58,param_3,0);
  uVar1 = *puVar5;
  puVar5 = (undefined4 *)FUN_1804395d0(param_1,local_54,param_3);
  FUN_180437d60(param_2,*(undefined8 *)(param_1 + 0x480),*puVar5,uVar1,(char)uVar2,uVar3);
  return param_2;
}

