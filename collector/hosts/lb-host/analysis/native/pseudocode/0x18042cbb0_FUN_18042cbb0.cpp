// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x18042cbb0; descriptive alias: FUN_18042cbb0
// Evidence: ev_a23178a18d04b56641c1b605c4df9b89ac4ed0a348dc4c3e7ed4d41526e3970d
// Original Evidence: rea-collector/0x18042cbb0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

void FUN_18042cbb0(longlong param_1)

{
  longlong lVar1;
  ulonglong uVar2;
  ulonglong uVar3;
  
  uVar2 = 0;
  uVar3 = uVar2;
  do {
    lVar1 = uVar2 * 0x810;
    *(undefined4 *)(param_1 + lVar1) = 0;
    *(undefined4 *)(param_1 + 4 + lVar1) = 0xffffffff;
    *(undefined4 *)(param_1 + 8 + lVar1) = 0;
    *(undefined2 *)(param_1 + 0xc + lVar1) = 0;
    FUN_1809bef30(param_1 + 0x10 + lVar1,0,0x800);
    *(undefined4 *)(param_1 + 0x810 + lVar1) = 0;
    *(undefined4 *)(param_1 + 0x814 + lVar1) = 0xffffffff;
    *(undefined4 *)(param_1 + 0x818 + lVar1) = 0;
    *(undefined2 *)(param_1 + 0x81c + lVar1) = 0;
    FUN_1809bef30(param_1 + 0x820 + lVar1,0,0x800);
    *(undefined4 *)(uVar3 + 0x1020 + param_1) = 0;
    *(undefined4 *)(param_1 + 0x1024 + lVar1) = 0xffffffff;
    *(undefined4 *)(param_1 + 0x1028 + lVar1) = 0;
    *(undefined2 *)(param_1 + 0x102c + lVar1) = 0;
    FUN_1809bef30(param_1 + 0x1030 + lVar1,0,0x800);
    *(undefined4 *)(uVar3 + 0x1830 + param_1) = 0;
    *(undefined4 *)(param_1 + 0x1834 + lVar1) = 0xffffffff;
    *(undefined4 *)(param_1 + 0x1838 + lVar1) = 0;
    *(undefined2 *)(param_1 + 0x183c + lVar1) = 0;
    FUN_1809bef30(param_1 + 0x1840 + lVar1,0,0x800);
    *(undefined4 *)(uVar3 + 0x2040 + param_1) = 0;
    *(undefined4 *)(param_1 + 0x2044 + lVar1) = 0xffffffff;
    *(undefined4 *)(param_1 + 0x2048 + lVar1) = 0;
    *(undefined2 *)(param_1 + 0x204c + lVar1) = 0;
    FUN_1809bef30(param_1 + 0x2050 + lVar1,0,0x800);
    *(undefined4 *)(uVar3 + 0x2850 + param_1) = 0;
    *(undefined4 *)(param_1 + 0x2854 + lVar1) = 0xffffffff;
    *(undefined4 *)(param_1 + 0x2858 + lVar1) = 0;
    *(undefined2 *)(param_1 + 0x285c + lVar1) = 0;
    FUN_1809bef30(param_1 + 0x2860 + lVar1,0,0x800);
    *(undefined4 *)(uVar3 + 0x3060 + param_1) = 0;
    *(undefined4 *)(param_1 + 0x3064 + lVar1) = 0xffffffff;
    *(undefined4 *)(param_1 + 0x3068 + lVar1) = 0;
    *(undefined2 *)(param_1 + 0x306c + lVar1) = 0;
    FUN_1809bef30(param_1 + 0x3070 + lVar1,0,0x800);
    *(undefined4 *)(uVar3 + 0x3870 + param_1) = 0;
    *(undefined4 *)(param_1 + 0x3874 + lVar1) = 0xffffffff;
    *(undefined4 *)(param_1 + 0x3878 + lVar1) = 0;
    *(undefined2 *)(param_1 + 0x387c + lVar1) = 0;
    FUN_1809bef30(param_1 + 0x3880 + lVar1,0,0x800);
    uVar2 = uVar2 + 8;
    uVar3 = uVar3 + 0x4080;
  } while (uVar2 < 0x20);
  return;
}

