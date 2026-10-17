// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x18043ece0; descriptive alias: FUN_18043ece0
// Evidence: ev_422beedbb2a35bf574fb4a1a3188d5df4411ef66cdc53bf6d290386f420e3291
// Original Evidence: rea-collector/0x18043ece0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

undefined8 * FUN_18043ece0(undefined8 *param_1,undefined8 *param_2)

{
  undefined8 uVar1;
  undefined8 uVar2;
  undefined8 uVar3;
  
  uVar1 = param_2[1];
  uVar2 = *param_2;
  uVar3 = param_2[2];
  param_2[2] = 0;
  param_2[1] = 0;
  *param_2 = 0;
  *param_1 = uVar2;
  param_1[1] = uVar1;
  param_1[2] = uVar3;
  uVar1 = param_2[5];
  uVar2 = param_2[3];
  param_2[5] = 0;
  uVar3 = param_2[4];
  param_2[4] = 0;
  param_2[3] = 0;
  param_1[3] = uVar2;
  param_1[4] = uVar3;
  param_1[5] = uVar1;
  uVar1 = param_2[8];
  uVar2 = param_2[7];
  uVar3 = param_2[6];
  param_2[8] = 0;
  param_2[7] = 0;
  param_2[6] = 0;
  param_1[6] = uVar3;
  param_1[7] = uVar2;
  param_1[8] = uVar1;
  uVar1 = param_2[0xb];
  uVar2 = param_2[10];
  uVar3 = param_2[9];
  param_2[0xb] = 0;
  param_2[10] = 0;
  param_2[9] = 0;
  param_1[9] = uVar3;
  param_1[10] = uVar2;
  param_1[0xb] = uVar1;
  uVar1 = param_2[0xe];
  uVar2 = param_2[0xd];
  uVar3 = param_2[0xc];
  param_2[0xe] = 0;
  param_2[0xd] = 0;
  param_2[0xc] = 0;
  param_1[0xc] = uVar3;
  param_1[0xd] = uVar2;
  param_1[0xe] = uVar1;
  uVar1 = param_2[0x11];
  uVar2 = param_2[0x10];
  uVar3 = param_2[0xf];
  param_2[0x11] = 0;
  param_2[0x10] = 0;
  param_2[0xf] = 0;
  param_1[0xf] = uVar3;
  param_1[0x10] = uVar2;
  param_1[0x11] = uVar1;
  uVar1 = param_2[0x14];
  uVar2 = param_2[0x13];
  uVar3 = param_2[0x12];
  param_2[0x14] = 0;
  param_2[0x13] = 0;
  param_2[0x12] = 0;
  param_1[0x12] = uVar3;
  param_1[0x13] = uVar2;
  param_1[0x14] = uVar1;
  uVar1 = param_2[0x17];
  uVar2 = param_2[0x16];
  uVar3 = param_2[0x15];
  param_2[0x17] = 0;
  param_2[0x16] = 0;
  param_2[0x15] = 0;
  param_1[0x15] = uVar3;
  param_1[0x16] = uVar2;
  param_1[0x17] = uVar1;
  uVar1 = param_2[0x1a];
  uVar2 = param_2[0x19];
  uVar3 = param_2[0x18];
  param_2[0x1a] = 0;
  param_2[0x19] = 0;
  param_2[0x18] = 0;
  param_1[0x18] = uVar3;
  param_1[0x19] = uVar2;
  param_1[0x1a] = uVar1;
  return param_1;
}

