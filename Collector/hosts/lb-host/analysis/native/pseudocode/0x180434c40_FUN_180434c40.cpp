// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180434c40; descriptive alias: FUN_180434c40
// Evidence: ev_48ae2ba64e0bd1a1e466cb856c5c783c88a9e8fef9c77a323ec6572a22de1cec
// Original Evidence: rea-collector/0x180434c40.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined4 *
FUN_180434c40(undefined4 *param_1,longlong param_2,int param_3,int param_4,undefined8 *param_5,
             undefined8 *param_6,undefined8 *param_7,int param_8)

{
  int iVar1;
  undefined8 *puVar2;
  undefined4 *puVar3;
  undefined8 uVar4;
  undefined8 uVar5;
  undefined8 uVar6;
  undefined4 uVar7;
  undefined2 local_52;
  
  iVar1 = *(int *)(param_2 + 0x30);
  *(undefined1 *)(param_2 + 0x60) = 1;
  if (param_8 != 0) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-iVar1 & 3);
    FUN_1801bd800(param_2,0xe,(*(int *)(param_2 + 0x30) - param_8) + 4,0);
  }
  if (param_7 != (undefined8 *)0x0) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    FUN_1801c5410(param_2,0xc);
    *(longlong *)(param_2 + 0x40) = *(longlong *)(param_2 + 0x40) + -0xc;
    *(int *)(param_2 + 0x30) = *(int *)(param_2 + 0x30) + 0xc;
    puVar2 = *(undefined8 **)(param_2 + 0x40);
    *puVar2 = *param_7;
    *(undefined4 *)(puVar2 + 1) = *(undefined4 *)(param_7 + 1);
    uVar7 = *(undefined4 *)(param_2 + 0x30);
    FUN_1801c5410(param_2,8);
    puVar3 = *(undefined4 **)(param_2 + 0x48);
    *puVar3 = uVar7;
    *(undefined2 *)(puVar3 + 1) = 0xc;
    *(undefined2 *)((longlong)puVar3 + 6) = local_52;
    *(longlong *)(param_2 + 0x48) = *(longlong *)(param_2 + 0x48) + 8;
    *(int *)(param_2 + 0x50) = *(int *)(param_2 + 0x50) + 1;
    if (*(ushort *)(param_2 + 0x54) < 0xc) {
      *(undefined2 *)(param_2 + 0x54) = 0xc;
    }
  }
  if (param_6 != (undefined8 *)0x0) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    FUN_1801c5410(param_2,0x40);
    *(longlong *)(param_2 + 0x40) = *(longlong *)(param_2 + 0x40) + -0x40;
    *(int *)(param_2 + 0x30) = *(int *)(param_2 + 0x30) + 0x40;
    uVar4 = param_6[1];
    uVar5 = param_6[2];
    uVar6 = param_6[3];
    puVar2 = *(undefined8 **)(param_2 + 0x40);
    *puVar2 = *param_6;
    puVar2[1] = uVar4;
    puVar2[2] = uVar5;
    puVar2[3] = uVar6;
    uVar4 = param_6[5];
    uVar5 = param_6[6];
    uVar6 = param_6[7];
    puVar2[4] = param_6[4];
    puVar2[5] = uVar4;
    puVar2[6] = uVar5;
    puVar2[7] = uVar6;
    uVar7 = *(undefined4 *)(param_2 + 0x30);
    FUN_1801c5410(param_2,8);
    puVar3 = *(undefined4 **)(param_2 + 0x48);
    *puVar3 = uVar7;
    *(undefined2 *)(puVar3 + 1) = 10;
    *(undefined2 *)((longlong)puVar3 + 6) = local_52;
    *(longlong *)(param_2 + 0x48) = *(longlong *)(param_2 + 0x48) + 8;
    *(int *)(param_2 + 0x50) = *(int *)(param_2 + 0x50) + 1;
    if (*(ushort *)(param_2 + 0x54) < 10) {
      *(undefined2 *)(param_2 + 0x54) = 10;
    }
  }
  if (param_5 != (undefined8 *)0x0) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    FUN_1801c5410(param_2,0x40);
    *(longlong *)(param_2 + 0x40) = *(longlong *)(param_2 + 0x40) + -0x40;
    *(int *)(param_2 + 0x30) = *(int *)(param_2 + 0x30) + 0x40;
    uVar4 = param_5[1];
    uVar5 = param_5[2];
    uVar6 = param_5[3];
    puVar2 = *(undefined8 **)(param_2 + 0x40);
    *puVar2 = *param_5;
    puVar2[1] = uVar4;
    puVar2[2] = uVar5;
    puVar2[3] = uVar6;
    uVar4 = param_5[5];
    uVar5 = param_5[6];
    uVar6 = param_5[7];
    puVar2[4] = param_5[4];
    puVar2[5] = uVar4;
    puVar2[6] = uVar5;
    puVar2[7] = uVar6;
    uVar7 = *(undefined4 *)(param_2 + 0x30);
    FUN_1801c5410(param_2,8);
    puVar3 = *(undefined4 **)(param_2 + 0x48);
    *puVar3 = uVar7;
    *(undefined2 *)(puVar3 + 1) = 8;
    *(undefined2 *)((longlong)puVar3 + 6) = local_52;
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
    uVar7 = *(undefined4 *)(param_2 + 0x30);
    FUN_1801c5410(param_2,8);
    puVar3 = *(undefined4 **)(param_2 + 0x48);
    *puVar3 = uVar7;
    *(undefined2 *)(puVar3 + 1) = 6;
    *(undefined2 *)((longlong)puVar3 + 6) = local_52;
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
    uVar7 = *(undefined4 *)(param_2 + 0x30);
    FUN_1801c5410(param_2,8);
    puVar3 = *(undefined4 **)(param_2 + 0x48);
    *puVar3 = uVar7;
    *(undefined2 *)(puVar3 + 1) = 4;
    *(undefined2 *)((longlong)puVar3 + 6) = local_52;
    *(longlong *)(param_2 + 0x48) = *(longlong *)(param_2 + 0x48) + 8;
    *(int *)(param_2 + 0x50) = *(int *)(param_2 + 0x50) + 1;
    if (*(ushort *)(param_2 + 0x54) < 4) {
      *(undefined2 *)(param_2 + 0x54) = 4;
    }
  }
  uVar7 = FUN_1801be990(param_2,iVar1);
  *param_1 = uVar7;
  return param_1;
}

