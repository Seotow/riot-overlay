// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180442250; descriptive alias: FUN_180442250
// Evidence: ev_e088d61fa3518c8eed496a0c2282c1303332e855579d62c4ad297f17de26df30
// Original Evidence: rea-collector/0x180442250.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined4 * FUN_180442250(longlong param_1,undefined4 *param_2,undefined8 *param_3)

{
  int iVar1;
  int iVar2;
  undefined *puVar3;
  int *piVar4;
  longlong lVar5;
  undefined *puVar6;
  longlong lVar7;
  
  puVar3 = (undefined *)*param_3;
  lVar7 = (longlong)param_3[1] - (longlong)puVar3 >> 2;
  puVar6 = &DAT_180d6e9e8;
  if (puVar3 != (undefined *)param_3[1]) {
    puVar6 = puVar3;
  }
  FUN_1801c3f20(param_1,lVar7,4);
  lVar5 = lVar7;
  while (lVar5 != 0) {
    iVar1 = *(int *)(puVar6 + lVar5 * 4 + -4);
    lVar5 = lVar5 + -1;
    if (*(ulonglong *)(param_1 + 0x68) < 4) {
      *(undefined8 *)(param_1 + 0x68) = 4;
    }
    FUN_1801c5360(param_1,-*(int *)(param_1 + 0x30) & 3);
    iVar2 = *(int *)(param_1 + 0x30);
    if (*(ulonglong *)(param_1 + 0x68) < 4) {
      *(undefined8 *)(param_1 + 0x68) = 4;
    }
    FUN_1801c5360(param_1,-iVar2 & 3);
    FUN_1801c5410(param_1,4);
    *(int *)(param_1 + 0x30) = *(int *)(param_1 + 0x30) + 4;
    piVar4 = (int *)(*(longlong *)(param_1 + 0x40) + -4);
    *(int **)(param_1 + 0x40) = piVar4;
    *piVar4 = (iVar2 - iVar1) + 4;
  }
  *(undefined1 *)(param_1 + 0x60) = 0;
  if (*(ulonglong *)(param_1 + 0x68) < 4) {
    *(undefined8 *)(param_1 + 0x68) = 4;
  }
  FUN_1801c5360(param_1,-*(int *)(param_1 + 0x30) & 3);
  FUN_1801c5410(param_1,4);
  *(longlong *)(param_1 + 0x40) = *(longlong *)(param_1 + 0x40) + -4;
  *(int *)(param_1 + 0x30) = *(int *)(param_1 + 0x30) + 4;
  **(undefined4 **)(param_1 + 0x40) = (int)lVar7;
  *param_2 = *(undefined4 *)(param_1 + 0x30);
  return param_2;
}

