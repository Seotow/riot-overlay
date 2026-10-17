// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180429d50; descriptive alias: FUN_180429d50
// Evidence: ev_ccd5649c92477b7952c91f7efe6db998de75fb9048837e4ec875283dc55923ae
// Original Evidence: rea-collector/0x180429d50.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined8
FUN_180429d50(longlong param_1,undefined4 param_2,undefined4 param_3,undefined4 param_4,
             longlong param_5)

{
  uint uVar1;
  undefined1 *puVar2;
  longlong lVar3;
  longlong lVar4;
  
  puVar2 = *(undefined1 **)(param_1 + 0x70);
  uVar1 = *(uint *)(puVar2 + 0xc);
  if (0x7f < uVar1) {
    *puVar2 = 3;
    *(undefined4 *)(*(longlong *)(param_1 + 0x70) + 4) = 0;
    *(undefined4 *)(*(longlong *)(param_1 + 0x70) + 0xc) = 0;
    *(undefined4 *)(*(longlong *)(param_1 + 0x70) + 0x10) = 0;
    *(undefined4 *)(param_1 + 0x78) = 0xffffffff;
    return 0;
  }
  lVar4 = (longlong)(int)uVar1 * 0x1014;
  *(uint *)(puVar2 + 0xc) = uVar1 + 1;
  lVar3 = *(longlong *)(param_1 + 0x70);
  *(uint *)(param_1 + 0x78) = uVar1;
  *(undefined4 *)(lVar4 + 0x2101c + lVar3) = param_2;
  *(undefined4 *)(lVar4 + 0x21018 + lVar3) = 0xffffffff;
  *(undefined4 *)(lVar4 + 0x21024 + lVar3) = param_4;
  *(undefined4 *)(lVar4 + 0x21020 + lVar3) = param_3;
  *(bool *)(lVar4 + 0x21028 + lVar3) = param_5 != 0;
  *(undefined2 *)(lVar4 + 0x21029 + lVar3) = 0;
  if (param_5 != 0) {
    FUN_1809bf2f0(lVar3 + 0x2102c + lVar4,param_5,0x800);
  }
  return 1;
}

