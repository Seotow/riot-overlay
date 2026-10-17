// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x18043db40; descriptive alias: FUN_18043db40
// Evidence: ev_a32953fe4b8e5c57e90f9a7a6b590ae429c4aaa689179830a4a4b367ef444ff0
// Original Evidence: rea-collector/0x18043db40.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined4 * FUN_18043db40(longlong param_1,undefined4 *param_2,longlong param_3)

{
  int iVar1;
  undefined4 uVar2;
  longlong lVar3;
  undefined4 *puVar4;
  char cVar5;
  uint uVar6;
  undefined4 uVar7;
  int *piVar8;
  undefined8 uVar9;
  undefined1 auVar10 [64];
  undefined1 local_58 [6];
  undefined2 local_52;
  
  uVar9 = FUN_180431740(param_3);
  cVar5 = FUN_180431900(param_3);
  if (DAT_180d31b28 == '\0') {
    uVar6 = DAT_180d316c0 + 0xe6632e3aU ^ 0x11bf48c;
  }
  else {
    uVar6 = FUN_18052b510(&DAT_180d316c0);
  }
  auVar10 = ZEXT464(*(uint *)((ulonglong)uVar6 + param_3));
  piVar8 = (int *)FUN_1804395d0(param_1,local_58,param_3);
  iVar1 = *piVar8;
  lVar3 = *(longlong *)(param_1 + 0x480);
  *(undefined1 *)(lVar3 + 0x60) = 1;
  uVar7 = *(undefined4 *)(lVar3 + 0x30);
  FUN_1801bd8b0(lVar3,8,uVar9,0);
  FUN_1801bd8b0(lVar3,6,auVar10._0_8_,0);
  if (iVar1 != 0) {
    if (*(ulonglong *)(lVar3 + 0x68) < 4) {
      *(undefined8 *)(lVar3 + 0x68) = 4;
    }
    FUN_1801c5360(lVar3,-*(int *)(lVar3 + 0x30) & 3);
    FUN_1801bd800(lVar3,4,(*(int *)(lVar3 + 0x30) - iVar1) + 4,0);
  }
  if ((cVar5 != '\0') || (*(char *)(lVar3 + 0x70) != '\0')) {
    if (*(longlong *)(lVar3 + 0x68) == 0) {
      *(undefined8 *)(lVar3 + 0x68) = 1;
    }
    FUN_1801c5410(lVar3,1);
    *(longlong *)(lVar3 + 0x40) = *(longlong *)(lVar3 + 0x40) + -1;
    *(int *)(lVar3 + 0x30) = *(int *)(lVar3 + 0x30) + 1;
    **(char **)(lVar3 + 0x40) = cVar5;
    uVar2 = *(undefined4 *)(lVar3 + 0x30);
    FUN_1801c5410(lVar3,8);
    puVar4 = *(undefined4 **)(lVar3 + 0x48);
    *puVar4 = uVar2;
    *(undefined2 *)(puVar4 + 1) = 10;
    *(undefined2 *)((longlong)puVar4 + 6) = local_52;
    *(longlong *)(lVar3 + 0x48) = *(longlong *)(lVar3 + 0x48) + 8;
    *(int *)(lVar3 + 0x50) = *(int *)(lVar3 + 0x50) + 1;
    if (*(ushort *)(lVar3 + 0x54) < 10) {
      *(undefined2 *)(lVar3 + 0x54) = 10;
    }
  }
  uVar7 = FUN_1801be990(lVar3,uVar7);
  *param_2 = uVar7;
  return param_2;
}

