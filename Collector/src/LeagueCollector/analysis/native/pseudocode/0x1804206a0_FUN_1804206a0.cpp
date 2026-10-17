// REA / Ghidra decompiler pseudocode. Not original or buildable C++.
// Address: 0x1804206a0; descriptive alias: FUN_1804206a0
// Evidence: ev_7981f33a60840901ecbe2ba709a1d854a5a22b468cdd996a6634043bae10e7df
// Original Evidence: rea-collector/0x1804206a0.json
// SHA-256: a1028d56ef03c84a0808ac028a0ee3a982e7962e844592157ed4b6c2663141d3

float * FUN_1804206a0(float *param_1,float *param_2,float *param_3,undefined8 param_4)

{
  float fVar1;
  float fVar2;
  float fVar3;
  float fVar4;
  float fVar5;
  float fVar6;
  float fVar7;
  float fVar8;
  float fVar9;
  float fVar10;
  
  fVar7 = param_1[2];
  fVar9 = *param_1;
  fVar10 = param_1[1];
  fVar3 = (float)FUN_18098f730(param_4);
  fVar8 = param_3[2];
  fVar5 = param_3[1];
  fVar6 = *param_3;
  fVar4 = (float)FUN_180990440(param_4);
  fVar1 = fVar5 * fVar10 + fVar6 * fVar9 + fVar8 * fVar7;
  fVar2 = 1.0 - fVar3;
  *param_2 = fVar6 * fVar1 * fVar2 + (fVar5 * fVar7 - fVar8 * fVar10) * fVar4 + fVar9 * fVar3;
  param_2[1] = fVar5 * fVar1 * fVar2 + -(fVar6 * fVar7 - fVar8 * fVar9) * fVar4 + fVar10 * fVar3;
  param_2[2] = fVar8 * fVar1 * fVar2 + (fVar6 * fVar10 - fVar5 * fVar9) * fVar4 + fVar3 * fVar7;
  return param_2;
}

