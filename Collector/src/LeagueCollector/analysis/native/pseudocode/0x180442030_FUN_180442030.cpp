// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180442030; descriptive alias: FUN_180442030
// Evidence: ev_82a0421d88a468f7847c67148bddaafac6972d2b6c1e42abe1c6d38bffcb6eb5
// Original Evidence: rea-collector/0x180442030.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined8 * FUN_180442030(longlong param_1,undefined8 *param_2)

{
  int iVar1;
  longlong lVar2;
  undefined *puVar3;
  undefined8 uVar4;
  undefined4 uVar5;
  int *piVar6;
  longlong lVar7;
  int iVar8;
  longlong lVar9;
  undefined *puVar10;
  
  LOCK();
  *(undefined1 *)(param_1 + 0x8788) = 1;
  UNLOCK();
  lVar2 = *(longlong *)(param_1 + 0x480);
  if ((undefined8 *)(param_1 + 0x8770) == (undefined8 *)0x0) {
    iVar8 = *(int *)(lVar2 + 0x30);
    *(undefined1 *)(lVar2 + 0x60) = 1;
  }
  else {
    puVar3 = *(undefined **)(param_1 + 0x8770);
    lVar7 = (longlong)*(undefined **)(param_1 + 0x8778) - (longlong)puVar3 >> 2;
    puVar10 = &DAT_180d6e9e2;
    if (puVar3 != *(undefined **)(param_1 + 0x8778)) {
      puVar10 = puVar3;
    }
    FUN_1801c3f20(lVar2,lVar7,4);
    lVar9 = lVar7;
    while (lVar9 != 0) {
      iVar8 = *(int *)(puVar10 + lVar9 * 4 + -4);
      lVar9 = lVar9 + -1;
      if (*(ulonglong *)(lVar2 + 0x68) < 4) {
        *(undefined8 *)(lVar2 + 0x68) = 4;
      }
      FUN_1801c5360(lVar2,-*(int *)(lVar2 + 0x30) & 3);
      iVar1 = *(int *)(lVar2 + 0x30);
      if (*(ulonglong *)(lVar2 + 0x68) < 4) {
        *(undefined8 *)(lVar2 + 0x68) = 4;
      }
      FUN_1801c5360(lVar2,-iVar1 & 3);
      FUN_1801c5410(lVar2,4);
      *(int *)(lVar2 + 0x30) = *(int *)(lVar2 + 0x30) + 4;
      piVar6 = (int *)(*(longlong *)(lVar2 + 0x40) + -4);
      *(int **)(lVar2 + 0x40) = piVar6;
      *piVar6 = (iVar1 - iVar8) + 4;
    }
    *(undefined1 *)(lVar2 + 0x60) = 0;
    if (*(ulonglong *)(lVar2 + 0x68) < 4) {
      *(undefined8 *)(lVar2 + 0x68) = 4;
    }
    FUN_1801c5360(lVar2,-*(int *)(lVar2 + 0x30) & 3);
    FUN_1801c5410(lVar2,4);
    *(longlong *)(lVar2 + 0x40) = *(longlong *)(lVar2 + 0x40) + -4;
    *(int *)(lVar2 + 0x30) = *(int *)(lVar2 + 0x30) + 4;
    **(undefined4 **)(lVar2 + 0x40) = (int)lVar7;
    iVar8 = *(int *)(lVar2 + 0x30);
    *(undefined1 *)(lVar2 + 0x60) = 1;
    if (iVar8 != 0) {
      if (*(ulonglong *)(lVar2 + 0x68) < 4) {
        *(undefined8 *)(lVar2 + 0x68) = 4;
      }
      FUN_1801c5360(lVar2,-iVar8 & 3);
      FUN_1801bd800(lVar2,4,(*(int *)(lVar2 + 0x30) - iVar8) + 4,0);
    }
  }
  uVar5 = FUN_1801be990(lVar2,iVar8);
  FUN_1801c3db0(*(undefined8 *)(param_1 + 0x480),uVar5);
  if (*(longlong *)(param_1 + 0x8770) != *(longlong *)(param_1 + 0x8778)) {
    *(longlong *)(param_1 + 0x8778) = *(longlong *)(param_1 + 0x8770);
  }
  uVar4 = *(undefined8 *)(param_1 + 0x480);
  *(undefined8 *)(param_1 + 0x480) = 0;
  *param_2 = uVar4;
  return param_2;
}

