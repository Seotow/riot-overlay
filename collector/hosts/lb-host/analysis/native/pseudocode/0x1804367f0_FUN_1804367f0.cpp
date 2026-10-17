// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1804367f0; descriptive alias: FUN_1804367f0
// Evidence: ev_5e95ace8fe02f294a50080131b81cf9975e78737960a9dac191031976a1a43c8
// Original Evidence: rea-collector/0x1804367f0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined4 *
FUN_1804367f0(undefined4 *param_1,longlong param_2,short param_3,char param_4,int param_5,
             int param_6,int param_7)

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
  if (param_6 != 0) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    FUN_1801bd800(param_2,10,(*(int *)(param_2 + 0x30) - param_6) + 4,0);
  }
  if (param_5 != 0) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    FUN_1801bd800(param_2,8,(*(int *)(param_2 + 0x30) - param_5) + 4,0);
  }
  if ((param_3 != 1) || (*(char *)(param_2 + 0x70) != '\0')) {
    if (*(ulonglong *)(param_2 + 0x68) < 2) {
      *(undefined8 *)(param_2 + 0x68) = 2;
    }
    FUN_1801c5360(param_2,~*(uint *)(param_2 + 0x30) - 1 & 1);
    FUN_1801c5410(param_2,2);
    *(longlong *)(param_2 + 0x40) = *(longlong *)(param_2 + 0x40) + -2;
    *(int *)(param_2 + 0x30) = *(int *)(param_2 + 0x30) + 2;
    **(short **)(param_2 + 0x40) = param_3;
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
  if ((param_4 != '\0') || (*(char *)(param_2 + 0x70) != '\0')) {
    if (*(longlong *)(param_2 + 0x68) == 0) {
      *(undefined8 *)(param_2 + 0x68) = 1;
    }
    FUN_1801c5410(param_2,1);
    *(longlong *)(param_2 + 0x40) = *(longlong *)(param_2 + 0x40) + -1;
    *(int *)(param_2 + 0x30) = *(int *)(param_2 + 0x30) + 1;
    **(char **)(param_2 + 0x40) = param_4;
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
  uVar3 = FUN_1801be990(param_2,iVar1);
  *param_1 = uVar3;
  return param_1;
}

