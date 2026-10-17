// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180435dc0; descriptive alias: FUN_180435dc0
// Evidence: ev_614e31970c6e422953856f3050bba30749dd25e015e6d2b31a4b2d363a6b8f8e
// Original Evidence: rea-collector/0x180435dc0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined4 * FUN_180435dc0(undefined4 *param_1,longlong param_2,int param_3,undefined8 *param_4)

{
  int iVar1;
  int iVar2;
  undefined8 *puVar3;
  undefined4 *puVar4;
  undefined8 uVar5;
  undefined8 uVar6;
  undefined8 uVar7;
  undefined4 uVar8;
  undefined2 local_42;
  
  iVar2 = *(int *)(param_2 + 0x30);
  *(undefined1 *)(param_2 + 0x60) = 1;
  if (param_4 != (undefined8 *)0x0) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-iVar2 & 3);
    FUN_1801c5410(param_2,0x28);
    *(longlong *)(param_2 + 0x40) = *(longlong *)(param_2 + 0x40) + -0x28;
    *(int *)(param_2 + 0x30) = *(int *)(param_2 + 0x30) + 0x28;
    uVar5 = param_4[1];
    uVar6 = param_4[2];
    uVar7 = param_4[3];
    puVar3 = *(undefined8 **)(param_2 + 0x40);
    *puVar3 = *param_4;
    puVar3[1] = uVar5;
    puVar3[2] = uVar6;
    puVar3[3] = uVar7;
    puVar3[4] = param_4[4];
    uVar8 = *(undefined4 *)(param_2 + 0x30);
    FUN_1801c5410(param_2,8);
    puVar4 = *(undefined4 **)(param_2 + 0x48);
    *puVar4 = uVar8;
    *(undefined2 *)(puVar4 + 1) = 6;
    *(undefined2 *)((longlong)puVar4 + 6) = local_42;
    *(longlong *)(param_2 + 0x48) = *(longlong *)(param_2 + 0x48) + 8;
    *(int *)(param_2 + 0x50) = *(int *)(param_2 + 0x50) + 1;
    if (*(ushort *)(param_2 + 0x54) < 6) {
      *(undefined2 *)(param_2 + 0x54) = 6;
    }
  }
  if (param_3 != 0) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    iVar1 = (*(int *)(param_2 + 0x30) - param_3) + 4;
    if ((iVar1 != 0) || (*(char *)(param_2 + 0x70) != '\0')) {
      if (*(ulonglong *)(param_2 + 0x68) < 4) {
        *(undefined8 *)(param_2 + 0x68) = 4;
      }
      FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
      FUN_1801c5410(param_2,4);
      *(longlong *)(param_2 + 0x40) = *(longlong *)(param_2 + 0x40) + -4;
      *(int *)(param_2 + 0x30) = *(int *)(param_2 + 0x30) + 4;
      **(int **)(param_2 + 0x40) = iVar1;
      uVar8 = *(undefined4 *)(param_2 + 0x30);
      FUN_1801c5410(param_2,8);
      puVar4 = *(undefined4 **)(param_2 + 0x48);
      *puVar4 = uVar8;
      *(undefined2 *)(puVar4 + 1) = 4;
      *(undefined2 *)((longlong)puVar4 + 6) = local_42;
      *(longlong *)(param_2 + 0x48) = *(longlong *)(param_2 + 0x48) + 8;
      *(int *)(param_2 + 0x50) = *(int *)(param_2 + 0x50) + 1;
      if (*(ushort *)(param_2 + 0x54) < 4) {
        *(undefined2 *)(param_2 + 0x54) = 4;
      }
    }
  }
  uVar8 = FUN_1801be990(param_2,iVar2);
  *param_1 = uVar8;
  return param_1;
}

