// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x180441310; descriptive alias: FUN_180441310
// Evidence: ev_7e13cbe025848dc70a58ef8e77a57b63f4a819bf99c394b1004c7361b4c0add0
// Original Evidence: rea-collector/0x180441310.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined8 * FUN_180441310(undefined8 *param_1,undefined8 param_2,undefined8 *param_3)

{
  undefined1 uVar1;
  undefined8 uVar2;
  undefined8 uVar3;
  
  uVar2 = *param_3;
  uVar1 = *(undefined1 *)(param_3 + 1);
  uVar3 = param_3[2];
  *param_1 = param_2;
  param_1[1] = uVar2;
  *(undefined1 *)(param_1 + 2) = uVar1;
  param_1[3] = uVar3;
  return param_1;
}

