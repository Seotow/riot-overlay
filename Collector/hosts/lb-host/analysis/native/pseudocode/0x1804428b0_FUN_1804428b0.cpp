// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1804428b0; descriptive alias: FUN_1804428b0
// Evidence: ev_87001cd73f5a174b0b0a820a3b554d6a3d1d60ad55ed0b6d540ea52c60ad68fb
// Original Evidence: rea-collector/0x1804428b0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

void FUN_1804428b0(longlong *param_1)

{
  undefined8 *puVar1;
  undefined8 *puVar2;
  
  puVar1 = (undefined8 *)*param_1;
  *(undefined8 *)puVar1[1] = 0;
  puVar1 = (undefined8 *)*puVar1;
  while (puVar1 != (undefined8 *)0x0) {
    puVar2 = (undefined8 *)*puVar1;
    FUN_1801ad9b0(puVar1 + 3);
    thunk_FUN_180895720(puVar1,0x30);
    puVar1 = puVar2;
  }
  thunk_FUN_180895720(*param_1,0x30);
  return;
}

