// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180442820; descriptive alias: FUN_180442820
// Evidence: ev_347448feda77e1b6e0add1980263022ce58a4ed8ec9b8b538a357e1ef76a4e08
// Original Evidence: rea-collector/0x180442820.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

void FUN_180442820(longlong *param_1)

{
  undefined8 *puVar1;
  undefined8 *puVar2;
  
  puVar1 = (undefined8 *)*param_1;
  *(undefined8 *)puVar1[1] = 0;
  puVar1 = (undefined8 *)*puVar1;
  while (puVar1 != (undefined8 *)0x0) {
    puVar2 = (undefined8 *)*puVar1;
    FUN_1801a2440(puVar1 + 3);
    thunk_FUN_180895720(puVar1,0x30);
    puVar1 = puVar2;
  }
  thunk_FUN_180895720(*param_1,0x30);
  return;
}

