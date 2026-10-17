// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180434f70; descriptive alias: FUN_180434f70
// Evidence: ev_e7267a036d2817c7dabbf7fc3d3cb84ea0531c2da6b226f3f9f2a7b386d6c93f
// Original Evidence: rea-collector/0x180434f70.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined4 *
FUN_180434f70(undefined4 *param_1,longlong param_2,int param_3,int param_4,int param_5,
             undefined8 *param_6,undefined4 param_7,char param_8)

{
  int iVar1;
  undefined4 uVar2;
  undefined8 *puVar3;
  undefined4 *puVar4;
  undefined4 uVar5;
  undefined2 local_52;
  
  uVar5 = *(undefined4 *)(param_2 + 0x30);
  *(undefined1 *)(param_2 + 0x60) = 1;
  FUN_1801bd8b0(param_2,0xc,param_7,0);
  if (param_6 != (undefined8 *)0x0) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    FUN_1801c5410(param_2,0xc);
    *(longlong *)(param_2 + 0x40) = *(longlong *)(param_2 + 0x40) + -0xc;
    *(int *)(param_2 + 0x30) = *(int *)(param_2 + 0x30) + 0xc;
    puVar3 = *(undefined8 **)(param_2 + 0x40);
    *puVar3 = *param_6;
    *(undefined4 *)(puVar3 + 1) = *(undefined4 *)(param_6 + 1);
    uVar2 = *(undefined4 *)(param_2 + 0x30);
    FUN_1801c5410(param_2,8);
    puVar4 = *(undefined4 **)(param_2 + 0x48);
    *puVar4 = uVar2;
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
    uVar2 = *(undefined4 *)(param_2 + 0x30);
    FUN_1801c5410(param_2,8);
    puVar4 = *(undefined4 **)(param_2 + 0x48);
    *puVar4 = uVar2;
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
    uVar2 = *(undefined4 *)(param_2 + 0x30);
    FUN_1801c5410(param_2,8);
    puVar4 = *(undefined4 **)(param_2 + 0x48);
    *puVar4 = uVar2;
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
      uVar2 = *(undefined4 *)(param_2 + 0x30);
      FUN_1801c5410(param_2,8);
      puVar4 = *(undefined4 **)(param_2 + 0x48);
      *puVar4 = uVar2;
      *(undefined2 *)(puVar4 + 1) = 4;
      *(undefined2 *)((longlong)puVar4 + 6) = local_52;
      *(longlong *)(param_2 + 0x48) = *(longlong *)(param_2 + 0x48) + 8;
      *(int *)(param_2 + 0x50) = *(int *)(param_2 + 0x50) + 1;
      if (*(ushort *)(param_2 + 0x54) < 4) {
        *(undefined2 *)(param_2 + 0x54) = 4;
      }
    }
  }
  if ((param_8 != '\0') || (*(char *)(param_2 + 0x70) != '\0')) {
    if (*(longlong *)(param_2 + 0x68) == 0) {
      *(undefined8 *)(param_2 + 0x68) = 1;
    }
    FUN_1801c5410(param_2,1);
    *(longlong *)(param_2 + 0x40) = *(longlong *)(param_2 + 0x40) + -1;
    *(int *)(param_2 + 0x30) = *(int *)(param_2 + 0x30) + 1;
    **(char **)(param_2 + 0x40) = param_8;
    uVar2 = *(undefined4 *)(param_2 + 0x30);
    FUN_1801c5410(param_2,8);
    puVar4 = *(undefined4 **)(param_2 + 0x48);
    *puVar4 = uVar2;
    *(undefined2 *)(puVar4 + 1) = 0xe;
    *(undefined2 *)((longlong)puVar4 + 6) = local_52;
    *(longlong *)(param_2 + 0x48) = *(longlong *)(param_2 + 0x48) + 8;
    *(int *)(param_2 + 0x50) = *(int *)(param_2 + 0x50) + 1;
    if (*(ushort *)(param_2 + 0x54) < 0xe) {
      *(undefined2 *)(param_2 + 0x54) = 0xe;
    }
  }
  uVar5 = FUN_1801be990(param_2,uVar5);
  *param_1 = uVar5;
  return param_1;
}

