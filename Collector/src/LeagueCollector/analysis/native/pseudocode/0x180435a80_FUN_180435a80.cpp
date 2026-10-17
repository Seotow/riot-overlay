// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180435a80; descriptive alias: FUN_180435a80
// Evidence: ev_d2e43947e2c563840ceb9be2b2678bbf91261d56d0a076bb2b80738a1a5feec8
// Original Evidence: rea-collector/0x180435a80.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined4 *
FUN_180435a80(undefined4 *param_1,longlong param_2,int param_3,int param_4,int param_5,int param_6,
             int param_7,int param_8,int param_9,int param_10,int param_11,int param_12,int param_13
             )

{
  int iVar1;
  undefined4 uVar2;
  
  iVar1 = *(int *)(param_2 + 0x30);
  *(undefined1 *)(param_2 + 0x60) = 1;
  if (param_13 != 0) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-iVar1 & 3);
    FUN_1801bd800(param_2,0x18,(*(int *)(param_2 + 0x30) - param_13) + 4,0);
  }
  if (param_12 != 0) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    FUN_1801bd800(param_2,0x16,(*(int *)(param_2 + 0x30) - param_12) + 4,0);
  }
  if (param_11 != 0) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    FUN_1801bd800(param_2,0x14,(*(int *)(param_2 + 0x30) - param_11) + 4,0);
  }
  if (param_10 != 0) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    FUN_1801bd800(param_2,0x12,(*(int *)(param_2 + 0x30) - param_10) + 4,0);
  }
  if (param_9 != 0) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    FUN_1801bd800(param_2,0x10,(*(int *)(param_2 + 0x30) - param_9) + 4,0);
  }
  if (param_8 != 0) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    FUN_1801bd800(param_2,0xe,(*(int *)(param_2 + 0x30) - param_8) + 4,0);
  }
  if (param_7 != 0) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
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
  uVar2 = FUN_1801be990(param_2,iVar1);
  *param_1 = uVar2;
  return param_1;
}

