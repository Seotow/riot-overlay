// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1804418b0; descriptive alias: FUN_1804418b0
// Evidence: ev_c628d1ecd33fe73b2f87505ad9bcc47ea8ff8b40b4fd05f747b0b12002801a6b
// Original Evidence: rea-collector/0x1804418b0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined8 * FUN_1804418b0(longlong param_1,undefined8 *param_2)

{
  uint uVar1;
  undefined8 uVar2;
  undefined8 *puVar3;
  
  FUN_1801c3db0(*(undefined8 *)(param_1 + 0x480),*(undefined4 *)(param_1 + 0x8770));
  *param_2 = 0;
  uVar1 = *(uint *)(*(longlong *)(param_1 + 0x480) + 0x30);
  puVar3 = (undefined8 *)FUN_180976d80(0x88);
  *puVar3 = 0;
  puVar3[1] = 0;
  puVar3[2] = 0;
  puVar3[3] = 0;
  puVar3[4] = 0;
  puVar3[5] = 0;
  puVar3[6] = 0;
  puVar3[7] = 0;
  puVar3[8] = 0;
  puVar3[9] = 0;
  puVar3[10] = 0;
  puVar3[0xb] = 0;
  puVar3[0xc] = 0;
  puVar3[0xd] = 0;
  puVar3[0xe] = 0;
  puVar3[0xf] = 0;
  *(undefined1 *)(puVar3 + 1) = 0;
  *puVar3 = 0;
  puVar3[2] = (ulonglong)uVar1;
  *(undefined4 *)(puVar3 + 3) = 0x7fffffff;
  puVar3[4] = 8;
  puVar3[5] = 0;
  *(undefined4 *)(puVar3 + 6) = 0;
  puVar3[7] = 0;
  puVar3[8] = 0;
  puVar3[9] = 0;
  *(undefined2 *)(puVar3 + 0xc) = 0;
  *(undefined4 *)(puVar3 + 10) = 0;
  *(undefined2 *)((longlong)puVar3 + 0x54) = 0;
  puVar3[0xb] = 0;
  puVar3[0xd] = 1;
  *(undefined2 *)(puVar3 + 0xe) = 0x100;
  puVar3[0xf] = 0;
  puVar3[0x10] = 0;
  *param_2 = puVar3;
  uVar2 = *(undefined8 *)(param_1 + 0x480);
  *(undefined8 **)(param_1 + 0x480) = puVar3;
  *param_2 = uVar2;
  return param_2;
}

