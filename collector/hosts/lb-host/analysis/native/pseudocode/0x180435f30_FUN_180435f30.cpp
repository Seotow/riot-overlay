// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180435f30; descriptive alias: FUN_180435f30
// Evidence: ev_7dacc06b7534f9735e63d5c2106c5cf7c785c55b057ea5a65dbe892a85cbf1dd
// Original Evidence: rea-collector/0x180435f30.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined4 *
FUN_180435f30(undefined4 *param_1,longlong param_2,undefined8 param_3,int param_4,float param_5,
             float param_6,float param_7,int param_8,char param_9,int param_10)

{
  undefined4 uVar1;
  undefined4 *puVar2;
  undefined4 uVar3;
  float fVar4;
  undefined2 local_62;
  
  uVar3 = *(undefined4 *)(param_2 + 0x30);
  *(undefined1 *)(param_2 + 0x60) = 1;
  FUN_1801bd6b0(param_2,4);
  if (param_10 != 0) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    FUN_1801bd800(param_2,0x12,(*(int *)(param_2 + 0x30) - param_10) + 4,0);
  }
  if ((param_8 != 0) || (*(char *)(param_2 + 0x70) != '\0')) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    FUN_1801c5410(param_2,4);
    *(longlong *)(param_2 + 0x40) = *(longlong *)(param_2 + 0x40) + -4;
    *(int *)(param_2 + 0x30) = *(int *)(param_2 + 0x30) + 4;
    **(int **)(param_2 + 0x40) = param_8;
    uVar1 = *(undefined4 *)(param_2 + 0x30);
    FUN_1801c5410(param_2,8);
    puVar2 = *(undefined4 **)(param_2 + 0x48);
    *puVar2 = uVar1;
    *(undefined2 *)(puVar2 + 1) = 0xe;
    *(undefined2 *)((longlong)puVar2 + 6) = local_62;
    *(longlong *)(param_2 + 0x48) = *(longlong *)(param_2 + 0x48) + 8;
    *(int *)(param_2 + 0x50) = *(int *)(param_2 + 0x50) + 1;
    if (*(ushort *)(param_2 + 0x54) < 0xe) {
      *(undefined2 *)(param_2 + 0x54) = 0xe;
    }
  }
  fVar4 = 0.0;
  if ((param_7 != 0.0) || (*(char *)(param_2 + 0x70) != '\0')) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    FUN_1801c5410(param_2,4);
    *(longlong *)(param_2 + 0x40) = *(longlong *)(param_2 + 0x40) + -4;
    *(int *)(param_2 + 0x30) = *(int *)(param_2 + 0x30) + 4;
    **(float **)(param_2 + 0x40) = param_7;
    uVar1 = *(undefined4 *)(param_2 + 0x30);
    FUN_1801c5410(param_2,8);
    puVar2 = *(undefined4 **)(param_2 + 0x48);
    *puVar2 = uVar1;
    *(undefined2 *)(puVar2 + 1) = 0xc;
    *(undefined2 *)((longlong)puVar2 + 6) = local_62;
    *(longlong *)(param_2 + 0x48) = *(longlong *)(param_2 + 0x48) + 8;
    *(int *)(param_2 + 0x50) = *(int *)(param_2 + 0x50) + 1;
    if (*(ushort *)(param_2 + 0x54) < 0xc) {
      *(undefined2 *)(param_2 + 0x54) = 0xc;
    }
  }
  if ((param_6 != fVar4) || (*(char *)(param_2 + 0x70) != '\0')) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    FUN_1801c5410(param_2,4);
    *(longlong *)(param_2 + 0x40) = *(longlong *)(param_2 + 0x40) + -4;
    *(int *)(param_2 + 0x30) = *(int *)(param_2 + 0x30) + 4;
    **(float **)(param_2 + 0x40) = param_6;
    uVar1 = *(undefined4 *)(param_2 + 0x30);
    FUN_1801c5410(param_2,8);
    puVar2 = *(undefined4 **)(param_2 + 0x48);
    *puVar2 = uVar1;
    *(undefined2 *)(puVar2 + 1) = 10;
    *(undefined2 *)((longlong)puVar2 + 6) = local_62;
    *(longlong *)(param_2 + 0x48) = *(longlong *)(param_2 + 0x48) + 8;
    *(int *)(param_2 + 0x50) = *(int *)(param_2 + 0x50) + 1;
    if (*(ushort *)(param_2 + 0x54) < 10) {
      *(undefined2 *)(param_2 + 0x54) = 10;
    }
  }
  if ((param_5 != fVar4) || (*(char *)(param_2 + 0x70) != '\0')) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    FUN_1801c5410(param_2,4);
    *(longlong *)(param_2 + 0x40) = *(longlong *)(param_2 + 0x40) + -4;
    *(int *)(param_2 + 0x30) = *(int *)(param_2 + 0x30) + 4;
    **(float **)(param_2 + 0x40) = param_5;
    uVar1 = *(undefined4 *)(param_2 + 0x30);
    FUN_1801c5410(param_2,8);
    puVar2 = *(undefined4 **)(param_2 + 0x48);
    *puVar2 = uVar1;
    *(undefined2 *)(puVar2 + 1) = 8;
    *(undefined2 *)((longlong)puVar2 + 6) = local_62;
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
    uVar1 = *(undefined4 *)(param_2 + 0x30);
    FUN_1801c5410(param_2,8);
    puVar2 = *(undefined4 **)(param_2 + 0x48);
    *puVar2 = uVar1;
    *(undefined2 *)(puVar2 + 1) = 6;
    *(undefined2 *)((longlong)puVar2 + 6) = local_62;
    *(longlong *)(param_2 + 0x48) = *(longlong *)(param_2 + 0x48) + 8;
    *(int *)(param_2 + 0x50) = *(int *)(param_2 + 0x50) + 1;
    if (*(ushort *)(param_2 + 0x54) < 6) {
      *(undefined2 *)(param_2 + 0x54) = 6;
    }
  }
  if ((param_9 != '\0') || (*(char *)(param_2 + 0x70) != '\0')) {
    if (*(longlong *)(param_2 + 0x68) == 0) {
      *(undefined8 *)(param_2 + 0x68) = 1;
    }
    FUN_1801c5410(param_2,1);
    *(longlong *)(param_2 + 0x40) = *(longlong *)(param_2 + 0x40) + -1;
    *(int *)(param_2 + 0x30) = *(int *)(param_2 + 0x30) + 1;
    **(char **)(param_2 + 0x40) = param_9;
    uVar1 = *(undefined4 *)(param_2 + 0x30);
    FUN_1801c5410(param_2,8);
    puVar2 = *(undefined4 **)(param_2 + 0x48);
    *puVar2 = uVar1;
    *(undefined2 *)(puVar2 + 1) = 0x10;
    *(undefined2 *)((longlong)puVar2 + 6) = local_62;
    *(longlong *)(param_2 + 0x48) = *(longlong *)(param_2 + 0x48) + 8;
    *(int *)(param_2 + 0x50) = *(int *)(param_2 + 0x50) + 1;
    if (*(ushort *)(param_2 + 0x54) < 0x10) {
      *(undefined2 *)(param_2 + 0x54) = 0x10;
    }
  }
  uVar3 = FUN_1801be990(param_2,uVar3);
  *param_1 = uVar3;
  return param_1;
}

