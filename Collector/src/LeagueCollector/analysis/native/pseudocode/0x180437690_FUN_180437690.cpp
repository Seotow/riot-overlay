// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180437690; descriptive alias: FUN_180437690
// Evidence: ev_de080eefd9f3cf48753a4a909853923752060f10cb33e70c03e6843eb28710f4
// Original Evidence: rea-collector/0x180437690.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined4 *
FUN_180437690(undefined4 *param_1,longlong param_2,int param_3,int param_4,int param_5,
             undefined4 param_6,undefined4 param_7,undefined4 param_8,undefined4 param_9,
             undefined4 param_10,undefined4 param_11,undefined4 param_12,char param_13,
             undefined4 param_14,int param_15,int param_16,int param_17,int param_18,int param_19,
             undefined4 param_20,undefined4 param_21,undefined4 param_22,undefined4 param_23,
             undefined4 param_24)

{
  undefined4 uVar1;
  undefined4 *puVar2;
  undefined4 uVar3;
  int iVar4;
  ulonglong *puVar5;
  undefined2 local_32;
  
  uVar3 = *(undefined4 *)(param_2 + 0x30);
  *(undefined1 *)(param_2 + 0x60) = 1;
  FUN_1801bd800(param_2,0x2e,param_24,0);
  FUN_1801bd800(param_2,0x2c,param_23,0);
  FUN_1801bd800(param_2,0x2a,param_22,0);
  FUN_1801bd800(param_2,0x28,param_21,0);
  FUN_1801bd800(param_2,0x26,param_20,0);
  if (param_19 != 0) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    FUN_1801bd800(param_2,0x24,(*(int *)(param_2 + 0x30) - param_19) + 4,0);
  }
  if (param_18 != 0) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    FUN_1801bd800(param_2,0x22,(*(int *)(param_2 + 0x30) - param_18) + 4,0);
  }
  if (param_17 != 0) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    FUN_1801bd800(param_2,0x20,(*(int *)(param_2 + 0x30) - param_17) + 4,0);
  }
  puVar5 = (ulonglong *)(param_2 + 0x68);
  if (param_16 != 0) {
    if (*puVar5 < 4) {
      *puVar5 = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    FUN_1801bd800(param_2,0x1e,(*(int *)(param_2 + 0x30) - param_16) + 4,0);
  }
  if (param_15 != 0) {
    if (*puVar5 < 4) {
      *puVar5 = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    FUN_1801bd800(param_2,0x1c,(*(int *)(param_2 + 0x30) - param_15) + 4,0);
  }
  FUN_1801bd8b0(param_2,0x1a,param_14,0);
  FUN_1801bd8b0(param_2,0x16,param_12,0);
  FUN_1801bd8b0(param_2,0x14,param_11,0);
  FUN_1801bd8b0(param_2,0x12,param_10,0);
  FUN_1801bd8b0(param_2,0x10,param_9,0);
  FUN_1801bd8b0(param_2,0xe,param_8,0);
  FUN_1801bd8b0(param_2,0xc,param_7,0);
  FUN_1801bd8b0(param_2,10,param_6,0);
  if ((param_5 != 0) || (*(char *)(param_2 + 0x70) != '\0')) {
    if (*puVar5 < 4) {
      *puVar5 = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    FUN_1801c5410(param_2,4);
    *(longlong *)(param_2 + 0x40) = *(longlong *)(param_2 + 0x40) + -4;
    *(int *)(param_2 + 0x30) = *(int *)(param_2 + 0x30) + 4;
    **(int **)(param_2 + 0x40) = param_5;
    uVar1 = *(undefined4 *)(param_2 + 0x30);
    FUN_1801c5410(param_2,8);
    puVar2 = *(undefined4 **)(param_2 + 0x48);
    *puVar2 = uVar1;
    *(undefined2 *)(puVar2 + 1) = 8;
    *(undefined2 *)((longlong)puVar2 + 6) = local_32;
    *(longlong *)(param_2 + 0x48) = *(longlong *)(param_2 + 0x48) + 8;
    *(int *)(param_2 + 0x50) = *(int *)(param_2 + 0x50) + 1;
    if (*(ushort *)(param_2 + 0x54) < 8) {
      *(undefined2 *)(param_2 + 0x54) = 8;
    }
  }
  if (param_4 != 0) {
    if (*puVar5 < 4) {
      *puVar5 = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    iVar4 = (*(int *)(param_2 + 0x30) - param_4) + 4;
    if ((iVar4 != 0) || (*(char *)(param_2 + 0x70) != '\0')) {
      if (*(ulonglong *)(param_2 + 0x68) < 4) {
        *(undefined8 *)(param_2 + 0x68) = 4;
      }
      FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
      FUN_1801c5410(param_2,4);
      *(longlong *)(param_2 + 0x40) = *(longlong *)(param_2 + 0x40) + -4;
      *(int *)(param_2 + 0x30) = *(int *)(param_2 + 0x30) + 4;
      **(int **)(param_2 + 0x40) = iVar4;
      uVar1 = *(undefined4 *)(param_2 + 0x30);
      FUN_1801c5410(param_2,8);
      puVar2 = *(undefined4 **)(param_2 + 0x48);
      *puVar2 = uVar1;
      *(undefined2 *)(puVar2 + 1) = 6;
      *(undefined2 *)((longlong)puVar2 + 6) = local_32;
      *(longlong *)(param_2 + 0x48) = *(longlong *)(param_2 + 0x48) + 8;
      *(int *)(param_2 + 0x50) = *(int *)(param_2 + 0x50) + 1;
      if (*(ushort *)(param_2 + 0x54) < 6) {
        *(undefined2 *)(param_2 + 0x54) = 6;
      }
    }
  }
  if (param_3 != 0) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    iVar4 = (*(int *)(param_2 + 0x30) - param_3) + 4;
    if ((iVar4 != 0) || (*(char *)(param_2 + 0x70) != '\0')) {
      if (*(ulonglong *)(param_2 + 0x68) < 4) {
        *(undefined8 *)(param_2 + 0x68) = 4;
      }
      FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
      FUN_1801c5410(param_2,4);
      *(longlong *)(param_2 + 0x40) = *(longlong *)(param_2 + 0x40) + -4;
      *(int *)(param_2 + 0x30) = *(int *)(param_2 + 0x30) + 4;
      **(int **)(param_2 + 0x40) = iVar4;
      uVar1 = *(undefined4 *)(param_2 + 0x30);
      FUN_1801c5410(param_2,8);
      puVar2 = *(undefined4 **)(param_2 + 0x48);
      *puVar2 = uVar1;
      *(undefined2 *)(puVar2 + 1) = 4;
      *(undefined2 *)((longlong)puVar2 + 6) = local_32;
      *(longlong *)(param_2 + 0x48) = *(longlong *)(param_2 + 0x48) + 8;
      *(int *)(param_2 + 0x50) = *(int *)(param_2 + 0x50) + 1;
      if (*(ushort *)(param_2 + 0x54) < 4) {
        *(undefined2 *)(param_2 + 0x54) = 4;
      }
    }
  }
  if ((param_13 != '\0') || (*(char *)(param_2 + 0x70) != '\0')) {
    if (*(longlong *)(param_2 + 0x68) == 0) {
      *(undefined8 *)(param_2 + 0x68) = 1;
    }
    FUN_1801c5410(param_2,1);
    *(longlong *)(param_2 + 0x40) = *(longlong *)(param_2 + 0x40) + -1;
    *(int *)(param_2 + 0x30) = *(int *)(param_2 + 0x30) + 1;
    **(char **)(param_2 + 0x40) = param_13;
    uVar1 = *(undefined4 *)(param_2 + 0x30);
    FUN_1801c5410(param_2,8);
    puVar2 = *(undefined4 **)(param_2 + 0x48);
    *puVar2 = uVar1;
    *(undefined2 *)(puVar2 + 1) = 0x18;
    *(undefined2 *)((longlong)puVar2 + 6) = local_32;
    *(longlong *)(param_2 + 0x48) = *(longlong *)(param_2 + 0x48) + 8;
    *(int *)(param_2 + 0x50) = *(int *)(param_2 + 0x50) + 1;
    if (*(ushort *)(param_2 + 0x54) < 0x18) {
      *(undefined2 *)(param_2 + 0x54) = 0x18;
    }
  }
  uVar3 = FUN_1801be990(param_2,uVar3);
  *param_1 = uVar3;
  return param_1;
}

