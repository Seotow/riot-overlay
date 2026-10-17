// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180436a00; descriptive alias: FUN_180436a00
// Evidence: ev_573c0e6388ad6ca66cdabce74edae10fd96749241a034601647230ebe18755e6
// Original Evidence: rea-collector/0x180436a00.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined4 *
FUN_180436a00(undefined4 *param_1,longlong param_2,int param_3,int param_4,char param_5,
             float param_6,float param_7,float param_8,float param_9,int param_10,float param_11,
             float param_12,int param_13,int param_14,int param_15,int param_16,undefined4 param_17,
             int param_18)

{
  int iVar1;
  undefined4 *puVar2;
  undefined4 uVar3;
  int iVar4;
  char *pcVar5;
  float fVar6;
  undefined2 local_52;
  
  iVar1 = *(int *)(param_2 + 0x30);
  *(undefined1 *)(param_2 + 0x60) = 1;
  if (param_18 != 0) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-iVar1 & 3);
    FUN_1801bd800(param_2,0x22,(*(int *)(param_2 + 0x30) - param_18) + 4,0);
  }
  fVar6 = 0.0;
  FUN_1801bd8b0(param_2,0x20,param_17,0);
  if ((param_16 != 0) || (*(char *)(param_2 + 0x70) != '\0')) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    FUN_1801c5410(param_2,4);
    *(longlong *)(param_2 + 0x40) = *(longlong *)(param_2 + 0x40) + -4;
    *(int *)(param_2 + 0x30) = *(int *)(param_2 + 0x30) + 4;
    **(int **)(param_2 + 0x40) = param_16;
    uVar3 = *(undefined4 *)(param_2 + 0x30);
    FUN_1801c5410(param_2,8);
    puVar2 = *(undefined4 **)(param_2 + 0x48);
    *puVar2 = uVar3;
    *(undefined2 *)(puVar2 + 1) = 0x1e;
    *(undefined2 *)((longlong)puVar2 + 6) = local_52;
    *(longlong *)(param_2 + 0x48) = *(longlong *)(param_2 + 0x48) + 8;
    *(int *)(param_2 + 0x50) = *(int *)(param_2 + 0x50) + 1;
    if (*(ushort *)(param_2 + 0x54) < 0x1e) {
      *(undefined2 *)(param_2 + 0x54) = 0x1e;
    }
  }
  if (param_15 != 0) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    iVar4 = (*(int *)(param_2 + 0x30) - param_15) + 4;
    if ((iVar4 != 0) || (*(char *)(param_2 + 0x70) != '\0')) {
      if (*(ulonglong *)(param_2 + 0x68) < 4) {
        *(undefined8 *)(param_2 + 0x68) = 4;
      }
      FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
      FUN_1801c5410(param_2,4);
      *(longlong *)(param_2 + 0x40) = *(longlong *)(param_2 + 0x40) + -4;
      *(int *)(param_2 + 0x30) = *(int *)(param_2 + 0x30) + 4;
      **(int **)(param_2 + 0x40) = iVar4;
      uVar3 = *(undefined4 *)(param_2 + 0x30);
      FUN_1801c5410(param_2,8);
      puVar2 = *(undefined4 **)(param_2 + 0x48);
      *puVar2 = uVar3;
      *(undefined2 *)(puVar2 + 1) = 0x1c;
      *(undefined2 *)((longlong)puVar2 + 6) = local_52;
      *(longlong *)(param_2 + 0x48) = *(longlong *)(param_2 + 0x48) + 8;
      *(int *)(param_2 + 0x50) = *(int *)(param_2 + 0x50) + 1;
      if (*(ushort *)(param_2 + 0x54) < 0x1c) {
        *(undefined2 *)(param_2 + 0x54) = 0x1c;
      }
    }
  }
  if (param_14 != 0) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    iVar4 = (*(int *)(param_2 + 0x30) - param_14) + 4;
    if ((iVar4 != 0) || (*(char *)(param_2 + 0x70) != '\0')) {
      if (*(ulonglong *)(param_2 + 0x68) < 4) {
        *(undefined8 *)(param_2 + 0x68) = 4;
      }
      FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
      FUN_1801c5410(param_2,4);
      *(longlong *)(param_2 + 0x40) = *(longlong *)(param_2 + 0x40) + -4;
      *(int *)(param_2 + 0x30) = *(int *)(param_2 + 0x30) + 4;
      **(int **)(param_2 + 0x40) = iVar4;
      uVar3 = *(undefined4 *)(param_2 + 0x30);
      FUN_1801c5410(param_2,8);
      puVar2 = *(undefined4 **)(param_2 + 0x48);
      *puVar2 = uVar3;
      *(undefined2 *)(puVar2 + 1) = 0x1a;
      *(undefined2 *)((longlong)puVar2 + 6) = local_52;
      *(longlong *)(param_2 + 0x48) = *(longlong *)(param_2 + 0x48) + 8;
      *(int *)(param_2 + 0x50) = *(int *)(param_2 + 0x50) + 1;
      if (*(ushort *)(param_2 + 0x54) < 0x1a) {
        *(undefined2 *)(param_2 + 0x54) = 0x1a;
      }
    }
  }
  if (param_13 != 0) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    iVar4 = (*(int *)(param_2 + 0x30) - param_13) + 4;
    if ((iVar4 != 0) || (*(char *)(param_2 + 0x70) != '\0')) {
      if (*(ulonglong *)(param_2 + 0x68) < 4) {
        *(undefined8 *)(param_2 + 0x68) = 4;
      }
      FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
      FUN_1801c5410(param_2,4);
      *(longlong *)(param_2 + 0x40) = *(longlong *)(param_2 + 0x40) + -4;
      *(int *)(param_2 + 0x30) = *(int *)(param_2 + 0x30) + 4;
      **(int **)(param_2 + 0x40) = iVar4;
      uVar3 = *(undefined4 *)(param_2 + 0x30);
      FUN_1801c5410(param_2,8);
      puVar2 = *(undefined4 **)(param_2 + 0x48);
      *puVar2 = uVar3;
      *(undefined2 *)(puVar2 + 1) = 0x18;
      *(undefined2 *)((longlong)puVar2 + 6) = local_52;
      *(longlong *)(param_2 + 0x48) = *(longlong *)(param_2 + 0x48) + 8;
      *(int *)(param_2 + 0x50) = *(int *)(param_2 + 0x50) + 1;
      if (*(ushort *)(param_2 + 0x54) < 0x18) {
        *(undefined2 *)(param_2 + 0x54) = 0x18;
      }
    }
  }
  if ((param_12 != fVar6) || (*(char *)(param_2 + 0x70) != '\0')) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    FUN_1801c5410(param_2,4);
    *(longlong *)(param_2 + 0x40) = *(longlong *)(param_2 + 0x40) + -4;
    *(int *)(param_2 + 0x30) = *(int *)(param_2 + 0x30) + 4;
    **(float **)(param_2 + 0x40) = param_12;
    uVar3 = *(undefined4 *)(param_2 + 0x30);
    FUN_1801c5410(param_2,8);
    puVar2 = *(undefined4 **)(param_2 + 0x48);
    *puVar2 = uVar3;
    *(undefined2 *)(puVar2 + 1) = 0x16;
    *(undefined2 *)((longlong)puVar2 + 6) = local_52;
    *(longlong *)(param_2 + 0x48) = *(longlong *)(param_2 + 0x48) + 8;
    *(int *)(param_2 + 0x50) = *(int *)(param_2 + 0x50) + 1;
    if (*(ushort *)(param_2 + 0x54) < 0x16) {
      *(undefined2 *)(param_2 + 0x54) = 0x16;
    }
  }
  pcVar5 = (char *)(param_2 + 0x70);
  if ((param_11 != fVar6) || (*pcVar5 != '\0')) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    FUN_1801c5410(param_2,4);
    *(longlong *)(param_2 + 0x40) = *(longlong *)(param_2 + 0x40) + -4;
    *(int *)(param_2 + 0x30) = *(int *)(param_2 + 0x30) + 4;
    **(float **)(param_2 + 0x40) = param_11;
    uVar3 = *(undefined4 *)(param_2 + 0x30);
    FUN_1801c5410(param_2,8);
    puVar2 = *(undefined4 **)(param_2 + 0x48);
    *puVar2 = uVar3;
    *(undefined2 *)(puVar2 + 1) = 0x14;
    *(undefined2 *)((longlong)puVar2 + 6) = local_52;
    *(longlong *)(param_2 + 0x48) = *(longlong *)(param_2 + 0x48) + 8;
    *(int *)(param_2 + 0x50) = *(int *)(param_2 + 0x50) + 1;
    if (*(ushort *)(param_2 + 0x54) < 0x14) {
      *(undefined2 *)(param_2 + 0x54) = 0x14;
    }
  }
  if ((param_10 != 0) || (*pcVar5 != '\0')) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    FUN_1801c5410(param_2,4);
    *(longlong *)(param_2 + 0x40) = *(longlong *)(param_2 + 0x40) + -4;
    *(int *)(param_2 + 0x30) = *(int *)(param_2 + 0x30) + 4;
    **(int **)(param_2 + 0x40) = param_10;
    uVar3 = *(undefined4 *)(param_2 + 0x30);
    FUN_1801c5410(param_2,8);
    puVar2 = *(undefined4 **)(param_2 + 0x48);
    *puVar2 = uVar3;
    *(undefined2 *)(puVar2 + 1) = 0x12;
    *(undefined2 *)((longlong)puVar2 + 6) = local_52;
    *(longlong *)(param_2 + 0x48) = *(longlong *)(param_2 + 0x48) + 8;
    *(int *)(param_2 + 0x50) = *(int *)(param_2 + 0x50) + 1;
    if (*(ushort *)(param_2 + 0x54) < 0x12) {
      *(undefined2 *)(param_2 + 0x54) = 0x12;
    }
  }
  if ((param_9 != fVar6) || (*pcVar5 != '\0')) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    FUN_1801c5410(param_2,4);
    *(longlong *)(param_2 + 0x40) = *(longlong *)(param_2 + 0x40) + -4;
    *(int *)(param_2 + 0x30) = *(int *)(param_2 + 0x30) + 4;
    **(float **)(param_2 + 0x40) = param_9;
    uVar3 = *(undefined4 *)(param_2 + 0x30);
    FUN_1801c5410(param_2,8);
    puVar2 = *(undefined4 **)(param_2 + 0x48);
    *puVar2 = uVar3;
    *(undefined2 *)(puVar2 + 1) = 0x10;
    *(undefined2 *)((longlong)puVar2 + 6) = local_52;
    *(longlong *)(param_2 + 0x48) = *(longlong *)(param_2 + 0x48) + 8;
    *(int *)(param_2 + 0x50) = *(int *)(param_2 + 0x50) + 1;
    if (*(ushort *)(param_2 + 0x54) < 0x10) {
      *(undefined2 *)(param_2 + 0x54) = 0x10;
    }
  }
  if ((param_8 != fVar6) || (*(char *)(param_2 + 0x70) != '\0')) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    FUN_1801c5410(param_2,4);
    *(longlong *)(param_2 + 0x40) = *(longlong *)(param_2 + 0x40) + -4;
    *(int *)(param_2 + 0x30) = *(int *)(param_2 + 0x30) + 4;
    **(float **)(param_2 + 0x40) = param_8;
    uVar3 = *(undefined4 *)(param_2 + 0x30);
    FUN_1801c5410(param_2,8);
    puVar2 = *(undefined4 **)(param_2 + 0x48);
    *puVar2 = uVar3;
    *(undefined2 *)(puVar2 + 1) = 0xe;
    *(undefined2 *)((longlong)puVar2 + 6) = local_52;
    *(longlong *)(param_2 + 0x48) = *(longlong *)(param_2 + 0x48) + 8;
    *(int *)(param_2 + 0x50) = *(int *)(param_2 + 0x50) + 1;
    if (*(ushort *)(param_2 + 0x54) < 0xe) {
      *(undefined2 *)(param_2 + 0x54) = 0xe;
    }
  }
  if ((param_7 != fVar6) || (*(char *)(param_2 + 0x70) != '\0')) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    FUN_1801c5410(param_2,4);
    *(longlong *)(param_2 + 0x40) = *(longlong *)(param_2 + 0x40) + -4;
    *(int *)(param_2 + 0x30) = *(int *)(param_2 + 0x30) + 4;
    **(float **)(param_2 + 0x40) = param_7;
    uVar3 = *(undefined4 *)(param_2 + 0x30);
    FUN_1801c5410(param_2,8);
    puVar2 = *(undefined4 **)(param_2 + 0x48);
    *puVar2 = uVar3;
    *(undefined2 *)(puVar2 + 1) = 0xc;
    *(undefined2 *)((longlong)puVar2 + 6) = local_52;
    *(longlong *)(param_2 + 0x48) = *(longlong *)(param_2 + 0x48) + 8;
    *(int *)(param_2 + 0x50) = *(int *)(param_2 + 0x50) + 1;
    if (*(ushort *)(param_2 + 0x54) < 0xc) {
      *(undefined2 *)(param_2 + 0x54) = 0xc;
    }
  }
  if ((param_6 != fVar6) || (*(char *)(param_2 + 0x70) != '\0')) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    FUN_1801c5410(param_2,4);
    *(longlong *)(param_2 + 0x40) = *(longlong *)(param_2 + 0x40) + -4;
    *(int *)(param_2 + 0x30) = *(int *)(param_2 + 0x30) + 4;
    **(float **)(param_2 + 0x40) = param_6;
    uVar3 = *(undefined4 *)(param_2 + 0x30);
    FUN_1801c5410(param_2,8);
    puVar2 = *(undefined4 **)(param_2 + 0x48);
    *puVar2 = uVar3;
    *(undefined2 *)(puVar2 + 1) = 10;
    *(undefined2 *)((longlong)puVar2 + 6) = local_52;
    *(longlong *)(param_2 + 0x48) = *(longlong *)(param_2 + 0x48) + 8;
    *(int *)(param_2 + 0x50) = *(int *)(param_2 + 0x50) + 1;
    if (*(ushort *)(param_2 + 0x54) < 10) {
      *(undefined2 *)(param_2 + 0x54) = 10;
    }
  }
  if (param_4 != 0) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
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
      uVar3 = *(undefined4 *)(param_2 + 0x30);
      FUN_1801c5410(param_2,8);
      puVar2 = *(undefined4 **)(param_2 + 0x48);
      *puVar2 = uVar3;
      *(undefined2 *)(puVar2 + 1) = 6;
      *(undefined2 *)((longlong)puVar2 + 6) = local_52;
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
      uVar3 = *(undefined4 *)(param_2 + 0x30);
      FUN_1801c5410(param_2,8);
      puVar2 = *(undefined4 **)(param_2 + 0x48);
      *puVar2 = uVar3;
      *(undefined2 *)(puVar2 + 1) = 4;
      *(undefined2 *)((longlong)puVar2 + 6) = local_52;
      *(longlong *)(param_2 + 0x48) = *(longlong *)(param_2 + 0x48) + 8;
      *(int *)(param_2 + 0x50) = *(int *)(param_2 + 0x50) + 1;
      if (*(ushort *)(param_2 + 0x54) < 4) {
        *(undefined2 *)(param_2 + 0x54) = 4;
      }
    }
  }
  if ((param_5 != '\0') || (*(char *)(param_2 + 0x70) != '\0')) {
    if (*(longlong *)(param_2 + 0x68) == 0) {
      *(undefined8 *)(param_2 + 0x68) = 1;
    }
    FUN_1801c5410(param_2,1);
    *(longlong *)(param_2 + 0x40) = *(longlong *)(param_2 + 0x40) + -1;
    *(int *)(param_2 + 0x30) = *(int *)(param_2 + 0x30) + 1;
    **(char **)(param_2 + 0x40) = param_5;
    uVar3 = *(undefined4 *)(param_2 + 0x30);
    FUN_1801c5410(param_2,8);
    puVar2 = *(undefined4 **)(param_2 + 0x48);
    *puVar2 = uVar3;
    *(undefined2 *)(puVar2 + 1) = 8;
    *(undefined2 *)((longlong)puVar2 + 6) = local_52;
    *(longlong *)(param_2 + 0x48) = *(longlong *)(param_2 + 0x48) + 8;
    *(int *)(param_2 + 0x50) = *(int *)(param_2 + 0x50) + 1;
    if (*(ushort *)(param_2 + 0x54) < 8) {
      *(undefined2 *)(param_2 + 0x54) = 8;
    }
  }
  uVar3 = FUN_1801be990(param_2,iVar1);
  *param_1 = uVar3;
  return param_1;
}

