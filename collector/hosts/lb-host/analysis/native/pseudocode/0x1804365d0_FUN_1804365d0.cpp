// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1804365d0; descriptive alias: FUN_1804365d0
// Evidence: ev_34b80e1a61ca8d722266103d493f52f97003f0c34e5ceb311f83d009a44568c1
// Original Evidence: rea-collector/0x1804365d0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined4 *
FUN_1804365d0(undefined4 *param_1,longlong param_2,int param_3,int param_4,undefined4 param_5,
             char param_6,int param_7)

{
  int iVar1;
  undefined4 *puVar2;
  undefined4 uVar3;
  undefined2 local_32;
  
  iVar1 = *(int *)(param_2 + 0x30);
  *(undefined1 *)(param_2 + 0x60) = 1;
  if (param_7 != 0) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-iVar1 & 3);
    FUN_1801bd800(param_2,0xc,(*(int *)(param_2 + 0x30) - param_7) + 4,0);
  }
  FUN_1801bd8b0(param_2,8,param_5,0);
  if ((param_4 != 0) || (*(char *)(param_2 + 0x70) != '\0')) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    FUN_1801c5410(param_2,4);
    *(longlong *)(param_2 + 0x40) = *(longlong *)(param_2 + 0x40) + -4;
    *(int *)(param_2 + 0x30) = *(int *)(param_2 + 0x30) + 4;
    **(int **)(param_2 + 0x40) = param_4;
    uVar3 = *(undefined4 *)(param_2 + 0x30);
    FUN_1801c5410(param_2,8);
    puVar2 = *(undefined4 **)(param_2 + 0x48);
    *puVar2 = uVar3;
    *(undefined2 *)(puVar2 + 1) = 6;
    *(undefined2 *)((longlong)puVar2 + 6) = local_32;
    *(longlong *)(param_2 + 0x48) = *(longlong *)(param_2 + 0x48) + 8;
    *(int *)(param_2 + 0x50) = *(int *)(param_2 + 0x50) + 1;
    if (*(ushort *)(param_2 + 0x54) < 6) {
      *(undefined2 *)(param_2 + 0x54) = 6;
    }
  }
  if ((param_3 != 0) || (*(char *)(param_2 + 0x70) != '\0')) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    FUN_1801c5410(param_2,4);
    *(longlong *)(param_2 + 0x40) = *(longlong *)(param_2 + 0x40) + -4;
    *(int *)(param_2 + 0x30) = *(int *)(param_2 + 0x30) + 4;
    **(int **)(param_2 + 0x40) = param_3;
    uVar3 = *(undefined4 *)(param_2 + 0x30);
    FUN_1801c5410(param_2,8);
    puVar2 = *(undefined4 **)(param_2 + 0x48);
    *puVar2 = uVar3;
    *(undefined2 *)(puVar2 + 1) = 4;
    *(undefined2 *)((longlong)puVar2 + 6) = local_32;
    *(longlong *)(param_2 + 0x48) = *(longlong *)(param_2 + 0x48) + 8;
    *(int *)(param_2 + 0x50) = *(int *)(param_2 + 0x50) + 1;
    if (*(ushort *)(param_2 + 0x54) < 4) {
      *(undefined2 *)(param_2 + 0x54) = 4;
    }
  }
  if ((param_6 != '\0') || (*(char *)(param_2 + 0x70) != '\0')) {
    if (*(longlong *)(param_2 + 0x68) == 0) {
      *(undefined8 *)(param_2 + 0x68) = 1;
    }
    FUN_1801c5410(param_2,1);
    *(longlong *)(param_2 + 0x40) = *(longlong *)(param_2 + 0x40) + -1;
    *(int *)(param_2 + 0x30) = *(int *)(param_2 + 0x30) + 1;
    **(char **)(param_2 + 0x40) = param_6;
    uVar3 = *(undefined4 *)(param_2 + 0x30);
    FUN_1801c5410(param_2,8);
    puVar2 = *(undefined4 **)(param_2 + 0x48);
    *puVar2 = uVar3;
    *(undefined2 *)(puVar2 + 1) = 10;
    *(undefined2 *)((longlong)puVar2 + 6) = local_32;
    *(longlong *)(param_2 + 0x48) = *(longlong *)(param_2 + 0x48) + 8;
    *(int *)(param_2 + 0x50) = *(int *)(param_2 + 0x50) + 1;
    if (*(ushort *)(param_2 + 0x54) < 10) {
      *(undefined2 *)(param_2 + 0x54) = 10;
    }
  }
  uVar3 = FUN_1801be990(param_2,iVar1);
  *param_1 = uVar3;
  return param_1;
}

