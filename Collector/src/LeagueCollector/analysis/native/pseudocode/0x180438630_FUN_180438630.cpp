// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180438630; descriptive alias: FUN_180438630
// Evidence: ev_155c3efc7e6e47f799925f783ad21ee0e4cdd6682caae8474e879b146c3fade0
// Original Evidence: rea-collector/0x180438630.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined4 *
FUN_180438630(undefined4 *param_1,longlong param_2,undefined8 param_3,undefined8 param_4,
             undefined8 param_5,int param_6,int param_7,int param_8,int param_9,int param_10,
             int param_11,int param_12,int param_13,int param_14,int param_15,int param_16,
             int param_17)

{
  undefined4 uVar1;
  ulonglong *puVar2;
  
  uVar1 = *(undefined4 *)(param_2 + 0x30);
  *(undefined1 *)(param_2 + 0x60) = 1;
  FUN_1801bd6b0(param_2,8,param_5);
  if (param_17 != 0) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    FUN_1801bd800(param_2,0x20,(*(int *)(param_2 + 0x30) - param_17) + 4,0);
  }
  if (param_16 != 0) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    FUN_1801bd800(param_2,0x1e,(*(int *)(param_2 + 0x30) - param_16) + 4,0);
  }
  if (param_15 != 0) {
    if (*(ulonglong *)(param_2 + 0x68) < 4) {
      *(undefined8 *)(param_2 + 0x68) = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    FUN_1801bd800(param_2,0x1c,(*(int *)(param_2 + 0x30) - param_15) + 4,0);
  }
  puVar2 = (ulonglong *)(param_2 + 0x68);
  if (param_14 != 0) {
    if (*puVar2 < 4) {
      *puVar2 = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    FUN_1801bd800(param_2,0x1a,(*(int *)(param_2 + 0x30) - param_14) + 4,0);
  }
  if (param_13 != 0) {
    if (*puVar2 < 4) {
      *puVar2 = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    FUN_1801bd800(param_2,0x18,(*(int *)(param_2 + 0x30) - param_13) + 4,0);
  }
  if (param_12 != 0) {
    if (*puVar2 < 4) {
      *puVar2 = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    FUN_1801bd800(param_2,0x16,(*(int *)(param_2 + 0x30) - param_12) + 4,0);
  }
  if (param_11 != 0) {
    if (*puVar2 < 4) {
      *puVar2 = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    FUN_1801bd800(param_2,0x14,(*(int *)(param_2 + 0x30) - param_11) + 4,0);
  }
  if (param_10 != 0) {
    if (*puVar2 < 4) {
      *puVar2 = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    FUN_1801bd800(param_2,0x12,(*(int *)(param_2 + 0x30) - param_10) + 4,0);
  }
  if (param_9 != 0) {
    if (*puVar2 < 4) {
      *puVar2 = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    FUN_1801bd800(param_2,0x10,(*(int *)(param_2 + 0x30) - param_9) + 4,0);
  }
  if (param_8 != 0) {
    if (*puVar2 < 4) {
      *puVar2 = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    FUN_1801bd800(param_2,0xe,(*(int *)(param_2 + 0x30) - param_8) + 4,0);
  }
  if (param_7 != 0) {
    if (*puVar2 < 4) {
      *puVar2 = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    FUN_1801bd800(param_2,0xc,(*(int *)(param_2 + 0x30) - param_7) + 4,0);
  }
  if (param_6 != 0) {
    if (*puVar2 < 4) {
      *puVar2 = 4;
    }
    FUN_1801c5360(param_2,-*(int *)(param_2 + 0x30) & 3);
    FUN_1801bd800(param_2,10,(*(int *)(param_2 + 0x30) - param_6) + 4,0);
  }
  FUN_1801bd8b0(param_2,6,param_4,0);
  FUN_1801bd8b0(param_2,4,param_3,0);
  uVar1 = FUN_1801be990(param_2,uVar1);
  *param_1 = uVar1;
  return param_1;
}

