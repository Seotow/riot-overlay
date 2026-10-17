// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180438200; descriptive alias: FUN_180438200
// Evidence: ev_8b1e4586c882e7f5b2fea8318ecfcb3308a7a1a10c06032ebd1b32bc9651271f
// Original Evidence: rea-collector/0x180438200.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined4 *
FUN_180438200(undefined4 *param_1,longlong param_2,int param_3,int param_4,int param_5,
             undefined8 *param_6)

{
  int iVar1;
  int iVar2;
  undefined8 *puVar3;
  undefined4 *puVar4;
  undefined8 uVar5;
  undefined8 uVar6;
  undefined8 uVar7;
  undefined4 uVar8;
  undefined2 local_52;
  
  iVar2 = *(int *)(param_2 + 0x30);
  *(undefined1 *)(param_2 + 0x60) = 1;
  if (param_6 != (undefined8 *)0x0) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-iVar2 & 3);
    FUN_1801c5410(param_2,0x24);
    *(longlong *)(param_2 + 0x40) = *(longlong *)(param_2 + 0x40) + -0x24;
    *(int *)(param_2 + 0x30) = *(int *)(param_2 + 0x30) + 0x24;
    uVar5 = param_6[1];
    uVar6 = param_6[2];
    uVar7 = param_6[3];
    puVar3 = *(undefined8 **)(param_2 + 0x40);
    *puVar3 = *param_6;
    puVar3[1] = uVar5;
    puVar3[2] = uVar6;
    puVar3[3] = uVar7;
    *(undefined4 *)(puVar3 + 4) = *(undefined4 *)(param_6 + 4);
    uVar8 = *(undefined4 *)(param_2 + 0x30);
    FUN_1801c5410(param_2,8);
    puVar4 = *(undefined4 **)(param_2 + 0x48);
    *puVar4 = uVar8;
    *(undefined2 *)(puVar4 + 1) = 10;
    *(undefined2 *)((longlong)puVar4 + 6) = local_52;
    *(longlong *)(param_2 + 0x48) = *(longlong *)(param_2 + 0x48) + 8;
    *(int *)(param_2 + 0x50) = *(int *)(param_2 + 0x50) + 1;
    if (*(ushort *)(param_2 + 0x54) < 10) {
      *(undefined2 *)(param_2 + 0x54) = 10;
    }
  }
  if ((param_5 != 0) || (*(char *)(param_2 + 0x70) != '\0')) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    FUN_1801c5410(param_2,4);
    *(longlong *)(param_2 + 0x40) = *(longlong *)(param_2 + 0x40) + -4;
    *(int *)(param_2 + 0x30) = *(int *)(param_2 + 0x30) + 4;
    **(int **)(param_2 + 0x40) = param_5;
    uVar8 = *(undefined4 *)(param_2 + 0x30);
    FUN_1801c5410(param_2,8);
    puVar4 = *(undefined4 **)(param_2 + 0x48);
    *puVar4 = uVar8;
    *(undefined2 *)(puVar4 + 1) = 8;
    *(undefined2 *)((longlong)puVar4 + 6) = local_52;
    *(longlong *)(param_2 + 0x48) = *(longlong *)(param_2 + 0x48) + 8;
    *(int *)(param_2 + 0x50) = *(int *)(param_2 + 0x50) + 1;
    if (*(ushort *)(param_2 + 0x54) < 8) {
      *(undefined2 *)(param_2 + 0x54) = 8;
    }
  }
  if ((param_4 != 0) || (*(char *)(param_2 + 0x70) != '\0')) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    FUN_1801c5410(param_2,4);
    *(longlong *)(param_2 + 0x40) = *(longlong *)(param_2 + 0x40) + -4;
    *(int *)(param_2 + 0x30) = *(int *)(param_2 + 0x30) + 4;
    **(int **)(param_2 + 0x40) = param_4;
    uVar8 = *(undefined4 *)(param_2 + 0x30);
    FUN_1801c5410(param_2,8);
    puVar4 = *(undefined4 **)(param_2 + 0x48);
    *puVar4 = uVar8;
    *(undefined2 *)(puVar4 + 1) = 6;
    *(undefined2 *)((longlong)puVar4 + 6) = local_52;
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
      *(undefined2 *)((longlong)puVar4 + 6) = local_52;
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

