// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x18042c880; descriptive alias: FUN_18042c880
// Evidence: ev_e998e62d3478c5778405e9ea8dfc570785a796fa5971490d5356a460816629d6
// Original Evidence: rea-collector/0x18042c880.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

void FUN_18042c880(longlong param_1)

{
  longlong lVar1;
  ulonglong uVar2;
  ulonglong uVar3;
  
  uVar2 = 0;
  uVar3 = uVar2;
  do {
    lVar1 = uVar2 * 0x1014;
    *(undefined8 *)(param_1 + lVar1) = 0xffffffffffffffff;
    *(undefined4 *)(param_1 + 8 + lVar1) = 0xffffffff;
    *(undefined4 *)(param_1 + 0xc + lVar1) = 0;
    *(undefined2 *)(param_1 + 0x10 + lVar1) = 0;
    *(undefined1 *)(param_1 + 0x12 + lVar1) = 0;
    FUN_1809bef30(param_1 + 0x14 + lVar1,0,0x800);
    FUN_1809bef30(param_1 + 0x814 + lVar1,0,0x800);
    *(undefined8 *)(param_1 + 0x1014 + lVar1) = 0xffffffffffffffff;
    *(undefined4 *)(param_1 + 0x101c + lVar1) = 0xffffffff;
    *(undefined4 *)(param_1 + 0x1020 + lVar1) = 0;
    *(undefined2 *)(param_1 + 0x1024 + lVar1) = 0;
    *(undefined1 *)(param_1 + 0x1026 + lVar1) = 0;
    FUN_1809bef30(param_1 + 0x1028 + lVar1,0,0x800);
    FUN_1809bef30(param_1 + 0x1828 + lVar1,0,0x800);
    *(undefined4 *)(uVar3 + 0x2028 + param_1) = 0xffffffff;
    *(undefined8 *)(param_1 + 0x202c + lVar1) = 0xffffffffffffffff;
    *(undefined4 *)(param_1 + 0x2034 + lVar1) = 0;
    *(undefined2 *)(param_1 + 0x2038 + lVar1) = 0;
    *(undefined1 *)(param_1 + 0x203a + lVar1) = 0;
    FUN_1809bef30(param_1 + 0x203c + lVar1,0,0x800);
    FUN_1809bef30(param_1 + 0x283c + lVar1,0,0x800);
    *(undefined4 *)(uVar3 + 0x303c + param_1) = 0xffffffff;
    *(undefined8 *)(param_1 + 0x3040 + lVar1) = 0xffffffffffffffff;
    *(undefined4 *)(param_1 + 0x3048 + lVar1) = 0;
    *(undefined2 *)(param_1 + 0x304c + lVar1) = 0;
    *(undefined1 *)(param_1 + 0x304e + lVar1) = 0;
    FUN_1809bef30(param_1 + 0x3050 + lVar1,0,0x800);
    FUN_1809bef30(param_1 + 0x3850 + lVar1,0,0x800);
    *(undefined4 *)(uVar3 + 0x4050 + param_1) = 0xffffffff;
    *(undefined8 *)(param_1 + 0x4054 + lVar1) = 0xffffffffffffffff;
    *(undefined4 *)(param_1 + 0x405c + lVar1) = 0;
    *(undefined2 *)(param_1 + 0x4060 + lVar1) = 0;
    *(undefined1 *)(param_1 + 0x4062 + lVar1) = 0;
    FUN_1809bef30(param_1 + 0x4064 + lVar1,0,0x800);
    FUN_1809bef30(param_1 + 0x4864 + lVar1,0,0x800);
    *(undefined4 *)(uVar3 + 0x5064 + param_1) = 0xffffffff;
    *(undefined8 *)(param_1 + 0x5068 + lVar1) = 0xffffffffffffffff;
    *(undefined4 *)(param_1 + 0x5070 + lVar1) = 0;
    *(undefined2 *)(param_1 + 0x5074 + lVar1) = 0;
    *(undefined1 *)(param_1 + 0x5076 + lVar1) = 0;
    FUN_1809bef30(param_1 + 0x5078 + lVar1,0,0x800);
    FUN_1809bef30(param_1 + 0x5878 + lVar1,0,0x800);
    *(undefined4 *)(uVar3 + 0x6078 + param_1) = 0xffffffff;
    *(undefined8 *)(param_1 + 0x607c + lVar1) = 0xffffffffffffffff;
    *(undefined4 *)(param_1 + 0x6084 + lVar1) = 0;
    *(undefined2 *)(param_1 + 0x6088 + lVar1) = 0;
    *(undefined1 *)(param_1 + 0x608a + lVar1) = 0;
    FUN_1809bef30(param_1 + 0x608c + lVar1,0,0x800);
    FUN_1809bef30(param_1 + 0x688c + lVar1,0,0x800);
    *(undefined4 *)(uVar3 + 0x708c + param_1) = 0xffffffff;
    *(undefined8 *)(param_1 + 0x7090 + lVar1) = 0xffffffffffffffff;
    *(undefined4 *)(param_1 + 0x7098 + lVar1) = 0;
    *(undefined2 *)(param_1 + 0x709c + lVar1) = 0;
    *(undefined1 *)(param_1 + 0x709e + lVar1) = 0;
    FUN_1809bef30(param_1 + 0x70a0 + lVar1,0,0x800);
    FUN_1809bef30(param_1 + 0x78a0 + lVar1,0,0x800);
    uVar2 = uVar2 + 8;
    uVar3 = uVar3 + 0x80a0;
  } while (uVar2 < 0x80);
  return;
}

