// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180437d60; descriptive alias: FUN_180437d60
// Evidence: ev_5afbabfd22346146f07be932c2b6fd7af405f00dbe6ba9a802b24a3c2f3b1eaf
// Original Evidence: rea-collector/0x180437d60.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined4 *
FUN_180437d60(undefined4 *param_1,longlong param_2,int param_3,int param_4,char param_5,char param_6
             )

{
  int iVar1;
  undefined4 *puVar2;
  undefined4 uVar3;
  undefined2 local_22;
  
  iVar1 = *(int *)(param_2 + 0x30);
  *(undefined1 *)(param_2 + 0x60) = 1;
  if (param_4 != 0) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-iVar1 & 3);
    FUN_1801bd800(param_2,6,(*(int *)(param_2 + 0x30) - param_4) + 4,0);
  }
  if (param_3 != 0) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    FUN_1801bd800(param_2,4,(*(int *)(param_2 + 0x30) - param_3) + 4,0);
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
    *(undefined2 *)((longlong)puVar2 + 6) = local_22;
    *(longlong *)(param_2 + 0x48) = *(longlong *)(param_2 + 0x48) + 8;
    *(int *)(param_2 + 0x50) = *(int *)(param_2 + 0x50) + 1;
    if (*(ushort *)(param_2 + 0x54) < 10) {
      *(undefined2 *)(param_2 + 0x54) = 10;
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
    *(undefined2 *)((longlong)puVar2 + 6) = local_22;
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

