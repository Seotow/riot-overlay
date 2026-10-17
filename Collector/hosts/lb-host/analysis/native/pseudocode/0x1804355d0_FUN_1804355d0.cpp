// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1804355d0; descriptive alias: FUN_1804355d0
// Evidence: ev_c022f46dfd6de721dede64a753ab1a23fb77047899740029a3219f14c1549bf1
// Original Evidence: rea-collector/0x1804355d0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined4 *
FUN_1804355d0(undefined4 *param_1,longlong param_2,int param_3,undefined8 *param_4,int param_5,
             int param_6,char param_7,short param_8,short param_9,char param_10,int param_11)

{
  int iVar1;
  undefined4 *puVar2;
  undefined8 *puVar3;
  undefined8 uVar4;
  undefined8 uVar5;
  undefined8 uVar6;
  undefined4 uVar7;
  int iVar8;
  undefined2 local_52;
  
  iVar1 = *(int *)(param_2 + 0x30);
  *(undefined1 *)(param_2 + 0x60) = 1;
  if (param_11 != 0) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-iVar1 & 3);
    FUN_1801bd800(param_2,0x14,(*(int *)(param_2 + 0x30) - param_11) + 4,0);
  }
  if ((param_6 != 0) || (*(char *)(param_2 + 0x70) != '\0')) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    FUN_1801c5410(param_2,4);
    *(longlong *)(param_2 + 0x40) = *(longlong *)(param_2 + 0x40) + -4;
    *(int *)(param_2 + 0x30) = *(int *)(param_2 + 0x30) + 4;
    **(int **)(param_2 + 0x40) = param_6;
    uVar7 = *(undefined4 *)(param_2 + 0x30);
    FUN_1801c5410(param_2,8);
    puVar2 = *(undefined4 **)(param_2 + 0x48);
    *puVar2 = uVar7;
    *(undefined2 *)(puVar2 + 1) = 10;
    *(undefined2 *)((longlong)puVar2 + 6) = local_52;
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
    uVar7 = *(undefined4 *)(param_2 + 0x30);
    FUN_1801c5410(param_2,8);
    puVar2 = *(undefined4 **)(param_2 + 0x48);
    *puVar2 = uVar7;
    *(undefined2 *)(puVar2 + 1) = 8;
    *(undefined2 *)((longlong)puVar2 + 6) = local_52;
    *(longlong *)(param_2 + 0x48) = *(longlong *)(param_2 + 0x48) + 8;
    *(int *)(param_2 + 0x50) = *(int *)(param_2 + 0x50) + 1;
    if (*(ushort *)(param_2 + 0x54) < 8) {
      *(undefined2 *)(param_2 + 0x54) = 8;
    }
  }
  if (param_4 != (undefined8 *)0x0) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    FUN_1801c5410(param_2,0x3c);
    *(longlong *)(param_2 + 0x40) = *(longlong *)(param_2 + 0x40) + -0x3c;
    *(int *)(param_2 + 0x30) = *(int *)(param_2 + 0x30) + 0x3c;
    uVar4 = param_4[1];
    uVar5 = param_4[2];
    uVar6 = param_4[3];
    puVar3 = *(undefined8 **)(param_2 + 0x40);
    *puVar3 = *param_4;
    puVar3[1] = uVar4;
    puVar3[2] = uVar5;
    puVar3[3] = uVar6;
    uVar4 = *(undefined8 *)((longlong)param_4 + 0x24);
    uVar5 = *(undefined8 *)((longlong)param_4 + 0x2c);
    uVar6 = *(undefined8 *)((longlong)param_4 + 0x34);
    *(undefined8 *)((longlong)puVar3 + 0x1c) = *(undefined8 *)((longlong)param_4 + 0x1c);
    *(undefined8 *)((longlong)puVar3 + 0x24) = uVar4;
    *(undefined8 *)((longlong)puVar3 + 0x2c) = uVar5;
    *(undefined8 *)((longlong)puVar3 + 0x34) = uVar6;
    uVar7 = *(undefined4 *)(param_2 + 0x30);
    FUN_1801c5410(param_2,8);
    puVar2 = *(undefined4 **)(param_2 + 0x48);
    *puVar2 = uVar7;
    *(undefined2 *)(puVar2 + 1) = 6;
    *(undefined2 *)((longlong)puVar2 + 6) = local_52;
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
    iVar8 = (*(int *)(param_2 + 0x30) - param_3) + 4;
    if ((iVar8 != 0) || (*(char *)(param_2 + 0x70) != '\0')) {
      if (*(ulonglong *)(param_2 + 0x68) < 4) {
        *(undefined8 *)(param_2 + 0x68) = 4;
      }
      FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
      FUN_1801c5410(param_2,4);
      *(longlong *)(param_2 + 0x40) = *(longlong *)(param_2 + 0x40) + -4;
      *(int *)(param_2 + 0x30) = *(int *)(param_2 + 0x30) + 4;
      **(int **)(param_2 + 0x40) = iVar8;
      uVar7 = *(undefined4 *)(param_2 + 0x30);
      FUN_1801c5410(param_2,8);
      puVar2 = *(undefined4 **)(param_2 + 0x48);
      *puVar2 = uVar7;
      *(undefined2 *)(puVar2 + 1) = 4;
      *(undefined2 *)((longlong)puVar2 + 6) = local_52;
      *(longlong *)(param_2 + 0x48) = *(longlong *)(param_2 + 0x48) + 8;
      *(int *)(param_2 + 0x50) = *(int *)(param_2 + 0x50) + 1;
      if (*(ushort *)(param_2 + 0x54) < 4) {
        *(undefined2 *)(param_2 + 0x54) = 4;
      }
    }
  }
  if ((param_9 != 0) || (*(char *)(param_2 + 0x70) != '\0')) {
    if (*(ulonglong *)(param_2 + 0x68) < 2) {
      *(undefined8 *)(param_2 + 0x68) = 2;
    }
    FUN_1801c5360(param_2,~*(uint *)(param_2 + 0x30) - 1 & 1);
    FUN_1801c5410(param_2,2);
    *(longlong *)(param_2 + 0x40) = *(longlong *)(param_2 + 0x40) + -2;
    *(int *)(param_2 + 0x30) = *(int *)(param_2 + 0x30) + 2;
    **(short **)(param_2 + 0x40) = param_9;
    uVar7 = *(undefined4 *)(param_2 + 0x30);
    FUN_1801c5410(param_2,8);
    puVar2 = *(undefined4 **)(param_2 + 0x48);
    *puVar2 = uVar7;
    *(undefined2 *)(puVar2 + 1) = 0x10;
    *(undefined2 *)((longlong)puVar2 + 6) = local_52;
    *(longlong *)(param_2 + 0x48) = *(longlong *)(param_2 + 0x48) + 8;
    *(int *)(param_2 + 0x50) = *(int *)(param_2 + 0x50) + 1;
    if (*(ushort *)(param_2 + 0x54) < 0x10) {
      *(undefined2 *)(param_2 + 0x54) = 0x10;
    }
  }
  if ((param_8 != 0) || (*(char *)(param_2 + 0x70) != '\0')) {
    if (*(ulonglong *)(param_2 + 0x68) < 2) {
      *(undefined8 *)(param_2 + 0x68) = 2;
    }
    FUN_1801c5360(param_2,~*(uint *)(param_2 + 0x30) - 1 & 1);
    FUN_1801c5410(param_2,2);
    *(longlong *)(param_2 + 0x40) = *(longlong *)(param_2 + 0x40) + -2;
    *(int *)(param_2 + 0x30) = *(int *)(param_2 + 0x30) + 2;
    **(short **)(param_2 + 0x40) = param_8;
    uVar7 = *(undefined4 *)(param_2 + 0x30);
    FUN_1801c5410(param_2,8);
    puVar2 = *(undefined4 **)(param_2 + 0x48);
    *puVar2 = uVar7;
    *(undefined2 *)(puVar2 + 1) = 0xe;
    *(undefined2 *)((longlong)puVar2 + 6) = local_52;
    *(longlong *)(param_2 + 0x48) = *(longlong *)(param_2 + 0x48) + 8;
    *(int *)(param_2 + 0x50) = *(int *)(param_2 + 0x50) + 1;
    if (*(ushort *)(param_2 + 0x54) < 0xe) {
      *(undefined2 *)(param_2 + 0x54) = 0xe;
    }
  }
  if ((param_10 != '\0') || (*(char *)(param_2 + 0x70) != '\0')) {
    if (*(longlong *)(param_2 + 0x68) == 0) {
      *(undefined8 *)(param_2 + 0x68) = 1;
    }
    FUN_1801c5410(param_2,1);
    *(longlong *)(param_2 + 0x40) = *(longlong *)(param_2 + 0x40) + -1;
    *(int *)(param_2 + 0x30) = *(int *)(param_2 + 0x30) + 1;
    **(char **)(param_2 + 0x40) = param_10;
    uVar7 = *(undefined4 *)(param_2 + 0x30);
    FUN_1801c5410(param_2,8);
    puVar2 = *(undefined4 **)(param_2 + 0x48);
    *puVar2 = uVar7;
    *(undefined2 *)(puVar2 + 1) = 0x12;
    *(undefined2 *)((longlong)puVar2 + 6) = local_52;
    *(longlong *)(param_2 + 0x48) = *(longlong *)(param_2 + 0x48) + 8;
    *(int *)(param_2 + 0x50) = *(int *)(param_2 + 0x50) + 1;
    if (*(ushort *)(param_2 + 0x54) < 0x12) {
      *(undefined2 *)(param_2 + 0x54) = 0x12;
    }
  }
  if ((param_7 != '\0') || (*(char *)(param_2 + 0x70) != '\0')) {
    if (*(longlong *)(param_2 + 0x68) == 0) {
      *(undefined8 *)(param_2 + 0x68) = 1;
    }
    FUN_1801c5410(param_2,1);
    *(longlong *)(param_2 + 0x40) = *(longlong *)(param_2 + 0x40) + -1;
    *(int *)(param_2 + 0x30) = *(int *)(param_2 + 0x30) + 1;
    **(char **)(param_2 + 0x40) = param_7;
    uVar7 = *(undefined4 *)(param_2 + 0x30);
    FUN_1801c5410(param_2,8);
    puVar2 = *(undefined4 **)(param_2 + 0x48);
    *puVar2 = uVar7;
    *(undefined2 *)(puVar2 + 1) = 0xc;
    *(undefined2 *)((longlong)puVar2 + 6) = local_52;
    *(longlong *)(param_2 + 0x48) = *(longlong *)(param_2 + 0x48) + 8;
    *(int *)(param_2 + 0x50) = *(int *)(param_2 + 0x50) + 1;
    if (*(ushort *)(param_2 + 0x54) < 0xc) {
      *(undefined2 *)(param_2 + 0x54) = 0xc;
    }
  }
  uVar7 = FUN_1801be990(param_2,iVar1);
  *param_1 = uVar7;
  return param_1;
}

