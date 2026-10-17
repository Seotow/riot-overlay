// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180435270; descriptive alias: FUN_180435270
// Evidence: ev_a0f4278bd99436f2d65188478a2a71d5620064bda4bd22a80145432eacdfead5
// Original Evidence: rea-collector/0x180435270.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined4 *
FUN_180435270(undefined4 *param_1,longlong param_2,int param_3,int param_4,undefined4 param_5,
             undefined4 param_6,undefined4 param_7,undefined4 param_8,undefined4 param_9,
             short param_10,char param_11,char param_12,undefined4 param_13,char param_14)

{
  undefined4 uVar1;
  undefined4 *puVar2;
  undefined4 uVar3;
  undefined2 local_22;
  
  uVar3 = *(undefined4 *)(param_2 + 0x30);
  *(undefined1 *)(param_2 + 0x60) = 1;
  FUN_1801bd8b0(param_2,0x18,param_13,0);
  FUN_1801bd8b0(param_2,0x10,param_9,0);
  FUN_1801bd8b0(param_2,0xe,param_8,0);
  FUN_1801bd8b0(param_2,0xc,param_7,0);
  FUN_1801bd8b0(param_2,10,param_6,0);
  FUN_1801bd8b0(param_2,8,param_5,0);
  if (param_4 != 0) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    FUN_1801bd800(param_2,6,(*(int *)(param_2 + 0x30) - param_4) + 4,0);
  }
  if (param_3 != 0) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    FUN_1801bd800(param_2,4,(*(int *)(param_2 + 0x30) - param_3) + 4,0);
  }
  if ((param_10 != 0) || (*(char *)(param_2 + 0x70) != '\0')) {
    if (*(ulonglong *)(param_2 + 0x68) < 2) {
      *(ulonglong *)(param_2 + 0x68) = 2;
    }
    FUN_1801c5360(param_2,~*(uint *)(param_2 + 0x30) - 1 & 1);
    FUN_1801c5410(param_2,2);
    *(longlong *)(param_2 + 0x40) = *(longlong *)(param_2 + 0x40) + -2;
    *(int *)(param_2 + 0x30) = *(int *)(param_2 + 0x30) + 2;
    **(short **)(param_2 + 0x40) = param_10;
    uVar1 = *(undefined4 *)(param_2 + 0x30);
    FUN_1801c5410(param_2,8);
    puVar2 = *(undefined4 **)(param_2 + 0x48);
    *puVar2 = uVar1;
    *(undefined2 *)(puVar2 + 1) = 0x12;
    *(undefined2 *)((longlong)puVar2 + 6) = local_22;
    *(longlong *)(param_2 + 0x48) = *(longlong *)(param_2 + 0x48) + 8;
    *(int *)(param_2 + 0x50) = *(int *)(param_2 + 0x50) + 1;
    if (*(ushort *)(param_2 + 0x54) < 0x12) {
      *(undefined2 *)(param_2 + 0x54) = 0x12;
    }
  }
  if ((param_14 != '\0') || (*(char *)(param_2 + 0x70) != '\0')) {
    if (*(longlong *)(param_2 + 0x68) == 0) {
      *(undefined8 *)(param_2 + 0x68) = 1;
    }
    FUN_1801c5410(param_2,1);
    *(longlong *)(param_2 + 0x40) = *(longlong *)(param_2 + 0x40) + -1;
    *(int *)(param_2 + 0x30) = *(int *)(param_2 + 0x30) + 1;
    **(char **)(param_2 + 0x40) = param_14;
    uVar1 = *(undefined4 *)(param_2 + 0x30);
    FUN_1801c5410(param_2,8);
    puVar2 = *(undefined4 **)(param_2 + 0x48);
    *puVar2 = uVar1;
    *(undefined2 *)(puVar2 + 1) = 0x1a;
    *(undefined2 *)((longlong)puVar2 + 6) = local_22;
    *(longlong *)(param_2 + 0x48) = *(longlong *)(param_2 + 0x48) + 8;
    *(int *)(param_2 + 0x50) = *(int *)(param_2 + 0x50) + 1;
    if (*(ushort *)(param_2 + 0x54) < 0x1a) {
      *(undefined2 *)(param_2 + 0x54) = 0x1a;
    }
  }
  if ((param_12 != '\0') || (*(char *)(param_2 + 0x70) != '\0')) {
    if (*(longlong *)(param_2 + 0x68) == 0) {
      *(undefined8 *)(param_2 + 0x68) = 1;
    }
    FUN_1801c5410(param_2,1);
    *(longlong *)(param_2 + 0x40) = *(longlong *)(param_2 + 0x40) + -1;
    *(int *)(param_2 + 0x30) = *(int *)(param_2 + 0x30) + 1;
    **(char **)(param_2 + 0x40) = param_12;
    uVar1 = *(undefined4 *)(param_2 + 0x30);
    FUN_1801c5410(param_2,8);
    puVar2 = *(undefined4 **)(param_2 + 0x48);
    *puVar2 = uVar1;
    *(undefined2 *)(puVar2 + 1) = 0x16;
    *(undefined2 *)((longlong)puVar2 + 6) = local_22;
    *(longlong *)(param_2 + 0x48) = *(longlong *)(param_2 + 0x48) + 8;
    *(int *)(param_2 + 0x50) = *(int *)(param_2 + 0x50) + 1;
    if (*(ushort *)(param_2 + 0x54) < 0x16) {
      *(undefined2 *)(param_2 + 0x54) = 0x16;
    }
  }
  if ((param_11 != '\0') || (*(char *)(param_2 + 0x70) != '\0')) {
    if (*(longlong *)(param_2 + 0x68) == 0) {
      *(undefined8 *)(param_2 + 0x68) = 1;
    }
    FUN_1801c5410(param_2,1);
    *(longlong *)(param_2 + 0x40) = *(longlong *)(param_2 + 0x40) + -1;
    *(int *)(param_2 + 0x30) = *(int *)(param_2 + 0x30) + 1;
    **(char **)(param_2 + 0x40) = param_11;
    uVar1 = *(undefined4 *)(param_2 + 0x30);
    FUN_1801c5410(param_2,8);
    puVar2 = *(undefined4 **)(param_2 + 0x48);
    *puVar2 = uVar1;
    *(undefined2 *)(puVar2 + 1) = 0x14;
    *(undefined2 *)((longlong)puVar2 + 6) = local_22;
    *(longlong *)(param_2 + 0x48) = *(longlong *)(param_2 + 0x48) + 8;
    *(int *)(param_2 + 0x50) = *(int *)(param_2 + 0x50) + 1;
    if (*(ushort *)(param_2 + 0x54) < 0x14) {
      *(undefined2 *)(param_2 + 0x54) = 0x14;
    }
  }
  uVar3 = FUN_1801be990(param_2,uVar3);
  *param_1 = uVar3;
  return param_1;
}

