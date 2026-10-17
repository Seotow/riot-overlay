// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180442da0; descriptive alias: FUN_180442da0
// Evidence: ev_06a2b043f1922f88987da103faf1540a06821ef7ef86006ee8e5c9a70ecc641a
// Original Evidence: rea-collector/0x180442da0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined4 * FUN_180442da0(undefined4 *param_1)

{
  longlong lVar1;
  
  *param_1 = 0;
  *(undefined8 *)(param_1 + 2) = 0;
  *(undefined8 *)(param_1 + 4) = 0;
  lVar1 = FUN_180976d80(0x30);
  *(longlong *)lVar1 = lVar1;
  *(longlong *)(lVar1 + 8) = lVar1;
  *(longlong *)(param_1 + 2) = lVar1;
  *(undefined8 *)(param_1 + 6) = 0;
  *(undefined8 *)(param_1 + 8) = 0;
  *(undefined8 *)(param_1 + 10) = 0;
  *(undefined8 *)(param_1 + 0xc) = 7;
  *(undefined8 *)(param_1 + 0xe) = 8;
  *param_1 = 0x3f800000;
  FUN_1801ab260(param_1 + 6,0x10,*(undefined8 *)(param_1 + 2));
  return param_1;
}

