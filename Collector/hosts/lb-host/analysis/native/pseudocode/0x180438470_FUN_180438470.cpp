// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180438470; descriptive alias: FUN_180438470
// Evidence: ev_27ad039d686d7d7f1af3075bc1d942d44749201aeb15b758603ef4f3c06848b5
// Original Evidence: rea-collector/0x180438470.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined4 *
FUN_180438470(undefined4 *param_1,longlong param_2,undefined8 param_3,undefined8 *param_4)

{
  int iVar1;
  undefined *puVar2;
  undefined4 uVar3;
  int *piVar4;
  int iVar5;
  longlong lVar6;
  undefined *puVar7;
  longlong lVar8;
  
  if (param_4 == (undefined8 *)0x0) {
    iVar5 = *(int *)(param_2 + 0x30);
    *(undefined1 *)(param_2 + 0x60) = 1;
    FUN_1801bd6b0(param_2,4);
  }
  else {
    puVar2 = (undefined *)*param_4;
    lVar8 = (longlong)param_4[1] - (longlong)puVar2 >> 2;
    puVar7 = &DAT_180d6e9eb;
    if (puVar2 != (undefined *)param_4[1]) {
      puVar7 = puVar2;
    }
    FUN_1801c3f20(param_2,lVar8,4);
    lVar6 = lVar8;
    while (lVar6 != 0) {
      iVar5 = *(int *)(puVar7 + lVar6 * 4 + -4);
      lVar6 = lVar6 + -1;
      if (*(ulonglong *)(param_2 + 0x68) < 4) {
        *(undefined8 *)(param_2 + 0x68) = 4;
      }
      FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
      iVar1 = *(int *)(param_2 + 0x30);
      if (*(ulonglong *)(param_2 + 0x68) < 4) {
        *(undefined8 *)(param_2 + 0x68) = 4;
      }
      FUN_1801c5360(param_2,-iVar1 & 3);
      FUN_1801c5410(param_2,4);
      *(int *)(param_2 + 0x30) = *(int *)(param_2 + 0x30) + 4;
      piVar4 = (int *)(*(longlong *)(param_2 + 0x40) + -4);
      *(int **)(param_2 + 0x40) = piVar4;
      *piVar4 = (iVar1 - iVar5) + 4;
    }
    *(undefined1 *)(param_2 + 0x60) = 0;
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    FUN_1801c5410(param_2,4);
    *(longlong *)(param_2 + 0x40) = *(longlong *)(param_2 + 0x40) + -4;
    *(int *)(param_2 + 0x30) = *(int *)(param_2 + 0x30) + 4;
    **(undefined4 **)(param_2 + 0x40) = (int)lVar8;
    iVar5 = *(int *)(param_2 + 0x30);
    *(undefined1 *)(param_2 + 0x60) = 1;
    FUN_1801bd6b0(param_2,4,param_3);
    if (iVar5 != 0) {
      if (*(ulonglong *)(param_2 + 0x68) < 4) {
        *(undefined8 *)(param_2 + 0x68) = 4;
      }
      FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
      FUN_1801bd800(param_2,6,(*(int *)(param_2 + 0x30) - iVar5) + 4,0);
    }
  }
  uVar3 = FUN_1801be990(param_2,iVar5);
  *param_1 = uVar3;
  return param_1;
}

